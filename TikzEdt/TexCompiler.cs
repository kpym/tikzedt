using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Windows.Threading;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace TikzEdt
{
    public class TexCompiler : DependencyObject //DispatcherObject
    {
        public delegate void NoArgsEventHandler(object sender);
        public event NoArgsEventHandler BitmapGenerated;            // called after _successful_ bitmap generation
        public event NoArgsEventHandler JobNumberChanged;           // called whenever the number of jobs in the queue changed
        public delegate void JobEventHandler(object sender, Job job);
        public event JobEventHandler JobFailed;
        public event JobEventHandler JobSucceeded;

        public enum CompileEventType { Start, Error, Success, Status };
        public delegate void CompileEventHandler(object sender, string Message, CompileEventType type);
        public event CompileEventHandler OnCompileEvent;
        public delegate void TexOutputHandler(object sender, string Message);
        public event TexOutputHandler OnTexOutput;

        // This read only property indicates whether the Compiler is currently busy
        readonly private static DependencyPropertyKey CompilingPropertyKey = DependencyProperty.RegisterReadOnly(
        "Compiling", typeof(bool), typeof(TexCompiler), new PropertyMetadata(false));
        readonly public static DependencyProperty CompilingProperty = CompilingPropertyKey.DependencyProperty;
        public bool Compiling
        {
            //if pre-compiling was started, isRunning stays true. No other compiliation can be started.
            //could CompilingProperty and isRunning be merged?
            get { return (bool)GetValue(CompilingProperty); }
            set { }
        }

        public double timeout = 0; // in milliseconds, 0 = no timeout
        public double Resolution = 50;
        public class Job
        {
            public string   code="",   // The tex code 
                            path="",   // The tex-filename, if empty string "", the default tempfile is used
                            name="";   // (optional) A description, to be displayed on error
            public Rect BB =new Rect(0,0,0,0);         // The BoundingBox. If it has size >0, a rectangle is inserted into the tex code
            public bool CreateBMP=false;  // if true, create bmp file, if false, create pdf only
            public bool WriteCode=true;  // true if code should be written to path, false if file already exists and just needs to be compiled
            public bool GeneratePrecompiledHeaders = false; // if set to true, all other arguments are ignored

            public bool BBShallBeWritten = false;   // indicates whether the compiler should try to smuggle BB code into the file
            public bool hasBB = false;              // indicates whether the BB could be determined
            public bool BBWritten = false;          // indicates whether code to determine the BB has been succesfully smuggled into the file
            
            public Job(string tcode, string tpath, Rect tBB, string tname, bool tCreateBMP)
            {
                code = tcode; path = tpath; BB = tBB; name = tname; CreateBMP = tCreateBMP;
            }
            public Job()
            {
            }
        }
        protected Queue<Job> todo_tex = new Queue<Job>();
        Job CurrentJob;     // the job that is currently compiling

        TexOutputParser myPdflatexOutputParser = new TexOutputParser();        
        public delegate void TexErrorHandler(object sender, TexOutputParser.TexError Error);
        public event TexErrorHandler OnTexError;

        /// <summary>
        /// Adds some tikz code to the internal TODO list, to be compiled as soon as possible.
        /// </summary>
        /// <param name="code">Tikz Code to compile</param>
        /// <param name="path">Path, without ending, e.g. img\myfile </param>
        /// <param name="BB">The bounding box</param>
        public void AddJob(string code, string path, Rect BB, string name, bool CreateBMP)
        {
            Job job = new Job();
            job.code = code;
            job.path = path;
            job.BB = BB;
            job.name = name;
            job.CreateBMP = CreateBMP;
            AddJob(job);
        }
        public void AddJob(Job job)
        {
            // if job.path is empty, fill with a temp file name
            if (job.path == "")
                job.path = Helper.GetAppDir() + "\\" + Consts.cTempFile + Process.GetCurrentProcess().Id + ".tex";

            todo_tex.Enqueue(job);
            if (JobNumberChanged != null)
                JobNumberChanged(this);
            if (!Compiling)//(!isRunning)
                doCompile();
        }
        /// <summary>
        /// Same as AddJob, but deletes all other pending jobs first.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="path"></param>
        /// <param name="BB"></param>
        /// <param name="name"></param>
        public void AddJobExclusive(string code, string path, bool BBShallBeWritten)
        {
            Job job = new Job();
            job.code = code;
            job.path = path;
            job.BBShallBeWritten = BBShallBeWritten;
            job.CreateBMP = false;
            job.WriteCode = true;

            AddJobExclusive(job);
        }
        public void AddJobExclusive(string path)
        {           
            Job job = new Job();
            job.path = path;
            job.CreateBMP = false;
            job.WriteCode = false;

            AddJobExclusive(job);
        }
        public void AddJobExclusive(Job job)
        {
            todo_tex.Clear();
            AddJob(job);
        }


        public int JobsInQueue
        {
            get { return todo_tex.Count; }
        }

        protected Process texProcess = new Process();
        //protected bool isRunning = false;
        //PDFLibNet.PDFWrapper mypdfDoc = null;
        //System.Windows.Forms.Control dummy = new System.Windows.Forms.Control();
        DispatcherTimer timer = new DispatcherTimer();
        PdfToBmp mypdfDoc = new PdfToBmp();

        /// <summary>
        /// If the compilation gets stuck (actually it shouldn't), 
        /// one can call this method to kill the pdflatex-process.
        /// </summary>
        public void AbortCompilation()
        {
            if (!texProcess.HasExited)
                texProcess.Kill();
            
        }

        /// <summary>
        /// The main routine, starts the compilation of the Tikz-Picture.
        /// If necessary it initiates compilation of the precompiled headers.
        /// </summary>
        protected void doCompile()
        {
            if (Compiling || todo_tex.Count == 0)
            {
                return;
            }
            

            if (!File.Exists(Helper.GetPrecompiledHeaderPath() + ".fmt"))
            {
                if (OnCompileEvent != null)
                    OnCompileEvent(this, "Generating precompiled headers.... please restart in some moments", CompileEventType.Status); 
                Helper.GeneratePrecompiledHeaders();  // todo: add as compile job
                return;
            }

            //isRunning = true;
            SetValue(CompilingPropertyKey, true);
            // Take the next job from the queue and process
            Job job = todo_tex.Dequeue();
            CurrentJob = job;

            // save into temporary textfile
            if (job.WriteCode)
            {
                // add bounding box
                bool lsucceeded;
                string codetowrite = job.code;
                //if (job.BB.Width > 0 && job.BB.Height > 0)
                //    codetowrite = writeBBtoTikz(job.code, job.BB, out lsucceeded);
                if (job.BBShallBeWritten)
                {
                    codetowrite = writeBBWritertoTikz(job.code, out lsucceeded);
                    if (lsucceeded)
                        job.BBWritten = true;
                }

                if (!Directory.Exists(System.IO.Path.GetDirectoryName(job.path)))
                    Directory.CreateDirectory(System.IO.Path.GetDirectoryName(job.path));

                StreamWriter s = new StreamWriter(job.path);
                if (IsStandalone(job.code))
                {
                    s.WriteLine(codetowrite);
                }
                else
                {
                    s.WriteLine("%& \"" + Helper.GetPrecompiledHeaderPath() + "\"");
                    s.WriteLine("\\begin{document}");
                    s.WriteLine(codetowrite);
                    s.WriteLine(Properties.Settings.Default.Tex_Postamble);
                }
                s.Close();
            }

            // call pdflatex         
            texProcess.StartInfo.Arguments = "-interaction=nonstopmode -halt-on-error \"" + job.path + "\""; 
            texProcess.StartInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(job.path);

            // Set reset timer in case something goes wrong
            if (timeout > 0)
            {
                timer.Interval = TimeSpan.FromMilliseconds(timeout);
                timer.Start();
            }

            try
            {
                if (texProcess.HasExited == true)
                {
                    texProcess.CancelOutputRead();
                    texProcess.CancelErrorRead();
                }
            }
            catch (InvalidOperationException)
            {
                //on first call when texProcess was not started, HasExited raises exception.
            }

            if (OnCompileEvent != null)
                OnCompileEvent(this, "Compiling document for preview: " + texProcess.StartInfo.FileName + " " + texProcess.StartInfo.Arguments, CompileEventType.Start);
  
            texProcess.Start();
            texProcess.BeginOutputReadLine();
            //texProcess.BeginErrorReadLine(); // this is not needed afaik....
            
        }

        void timer_Tick(object sender, EventArgs e)
        {
            ((MainWindow)Application.Current.Windows[0]).AddStatusLine("Timeout. Compilation aborted", true);
            AbortCompilation();
        }
        /// <summary>
        /// Adds a rectangle to the Tikzcode in the size specified by BB. 
        /// The rectangle is added as the last command before the \end{tikzpicture} 
        /// </summary>
        /// <param name="code">The Tikz Code. Must contain an "\end{tikzpicture}" </param>
        /// <param name="BB">The bounding box (= size of rectangle to be written) </param>
        /// <param name="succeeded">Returns success, i.e., whether the string "\end{tikzpicture}" has been found</param>
        /// <returns>The Tikzcode, with the "\draw rectangle ...." inserted </returns>
        string writeBBtoTikz(string code, Rect BB, out bool succeeded)
        {
            // hack
            string cend = @"\end{tikzpicture}";
            string[] tok = code.Split(new string[] { cend }, StringSplitOptions.None);
            succeeded = (tok.Length == 2 && BB.Width * BB.Height > 0);
            // for release, draw the rectangle in invisible color (white), or draw two points
            // for testing, it is better to be able to see the rectangle to see bounding box misalignments
            if (succeeded)
                return tok[0] + @"\pgftransformreset " +
                    @"\draw (" + BB.X + "," + BB.Y + ") rectangle (" + (BB.X + BB.Width).ToString() + "," + (BB.Y + BB.Height).ToString() + "); " + cend + tok[1];
            else
                return code;
        }

        string writeBBWritertoTikz(string code, out bool succeeded)
        {
            // hack
            string cend = @"\end{tikzpicture}";
            string[] tok = code.Split(new string[] { cend }, StringSplitOptions.None);
            succeeded = (tok.Length == 2 );
            if (succeeded)
                return tok[0] + Consts.CodeToWriteBB + cend + tok[1];
            else
                return code;
        }

        public TexCompiler()
        {

            texProcess.EnableRaisingEvents = true;
            //texProcess.StartInfo.Arguments = "-quiet -halt-on-error " + Consts.cTempFile + ".tex";
            texProcess.StartInfo.FileName = "pdflatex";
            texProcess.StartInfo.CreateNoWindow = true;
            texProcess.StartInfo.UseShellExecute = false;
            texProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            texProcess.StartInfo.RedirectStandardOutput = true;
            // texProcess.SynchronizingObject = (System.ComponentModel.ISynchronizeInvoke) this;
            texProcess.Exited += new EventHandler(texProcess_Exited);
            texProcess.OutputDataReceived += new DataReceivedEventHandler(texProcess_OutputDataReceived);
            timer.Tick += new EventHandler(timer_Tick);

            myPdflatexOutputParser.OnTexError += new TexOutputParser.TexErrorHandler(myPdflatexOutputParser_OnTexError);
            //myPdflatexOutputParser.addProblem +=new PdflatexOutputParser.addProblemEventHandler(myPdflatexOutputParser_addProblem);
            //texProcess.ErrorDataReceived += new DataReceivedEventHandler(texProcess_ErrorDataReceived);
        }

        void myPdflatexOutputParser_OnTexError(object sender, TexOutputParser.TexError e)
        {
            if (OnTexError != null)
            {
                OnTexError(sender, e);
            }            
        }


        /// <summary>
        /// This is called when PDFLatex has exited
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void texProcess_Exited(object sender, EventArgs e)
        {
            // HACK: make thread-safe
            //Dispatcher.Invoke(new Action(
            //delegate()
            //{
            timer.Stop();

            Dispatcher.BeginInvoke(new Action(delegate()
            {
            Job job = CurrentJob;       // todo_tex.Dequeue();
            if (JobNumberChanged != null)
                 JobNumberChanged(this);    // invoke here... it would also be possible to invoke on start of compilation...

            if (texProcess.ExitCode == 0)
            {
                if (job.BBWritten)
                {
                    ReadBBFromFile(job);
                }

                if (OnCompileEvent != null)
                    OnCompileEvent(this, "Compilation done", CompileEventType.Success);
                if (JobSucceeded != null)
                    JobSucceeded(this, job);

                if (job.CreateBMP)
                {
                    string pathnoext = Helper.RemoveFileExtension(job.path);

                    if (!mypdfDoc.LoadPdf(pathnoext + ".pdf"))
                    {
                        MessageBox.Show("Couldn't load pdf " + pathnoext + ".pdf");
                    }
                    else
                    {
                        mypdfDoc.SaveBmp(pathnoext + ".bmp", Resolution);
                        if (BitmapGenerated != null)
                            BitmapGenerated(this);
                    }
                }
            }
            else
            {
                if (OnCompileEvent != null)
                    OnCompileEvent(this, "Compilation failed wih exit code " + texProcess.ExitCode, CompileEventType.Error);
                if (JobFailed != null)
                {
                    JobFailed(this, job);
                }        
            }

            //parse output from pdflatex.
            //myPdflatexOutputParser.parseOutput();
            //This does not work because something texProcess_Exited is called
            //before the complete output was received by texProcess_OutputDataReceived().

            //isRunning = false;
            SetValue(CompilingPropertyKey, false);
 
            if (todo_tex.Count > 0)
                doCompile();

            }));
        }

        /// <summary>
        /// Tries to read the Tikz bounding box from Metadata file mytikzfile_BB.txt
        /// Format:
        ///         X1,Y1,X2,Y2
        /// (For example X1 = 27.3pt)
        /// </summary>
        /// <param name="job"></param>
        void ReadBBFromFile(Job job)
        {
            string cMetaFile = Helper.RemoveFileExtension(job.path) + "_BB.txt";
            if (File.Exists(cMetaFile))
            {
                StreamReader sr = new StreamReader(cMetaFile);;
                try
                {
                    string s = sr.ReadLine();
                    string[] arr = s.Split(new string[] {",", " ", "pt"}, StringSplitOptions.RemoveEmptyEntries);
                    if (arr.Length == 4)
                    {
                        Point p1 = new Point( Double.Parse(arr[0]) / Consts.ptspertikzunit, Double.Parse(arr[1]) / Consts.ptspertikzunit);
                        Point p2 = new Point( Double.Parse(arr[2]) / Consts.ptspertikzunit, Double.Parse(arr[3]) / Consts.ptspertikzunit);
                        job.BB = new Rect(p1, p2);
                        job.hasBB = true;

                    }
                }
                finally
                {
                    sr.Close();
                }

            }
        }

        /// <summary>
        /// Checks whether the current code can be compiled,
        /// or whether we need to append pre-/postambles.
        /// 
        /// Code is standalone if
        /// 1) defined by !TIKZEDT STANDALONE command or
        /// 2) it contains string "\documentclass" or
        /// 3) if it start with string "%&". (Precompiled header)
        /// </summary>
        /// <returns></returns>
        public static bool IsStandalone(string code)
        {
            bool ret;
            RegexOptions ro = new RegexOptions();
            ro = ro | RegexOptions.IgnoreCase;
            ro = ro | RegexOptions.Multiline;
            string StandAlone_RegexString = @"^[ \t\s]*%[ \t\s]*!TIKZEDT[ \t\s]*STANDALONE[ \t\s]*^";
            Regex BB_Regex = new Regex(StandAlone_RegexString, ro);
            Match m = BB_Regex.Match(code);
            if (m.Success == true)
                ret = true;
            else
                ret = (code.Contains("\\documentclass") 
                    || code.Trim().StartsWith("%&") );    // precompiled header

            //using data binding would probably be nicer...
            ((MainWindow)Application.Current.Windows[0]).SetStandAloneStatus(ret);

            return ret;
        }

        /*void texProcess_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            string s = "ErrorDataReceived: " + e.Data;
            Dispatcher.Invoke(
                new Action(
                    delegate()
                    {
                        if (OnTexOutput != null)
                            OnTexOutput(s);
                    }
                )
            );
        }*/

        //line de-breaking buffer for pdflatex output
        private string OnTexOutputBufferString = "";
        private const int MAX_LINE_LENGTH = 79;
        void texProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            
            Dispatcher.Invoke(
                new Action(
                    delegate()
                    {
                        string Message = e.Data;
                        if (Message==null)
                            return;

                        if (OnTexOutputBufferString != "")
                        {
                            Message = OnTexOutputBufferString + Message;
                            OnTexOutputBufferString = "";
                        }

                        // add tex output
                        if (Message != "")
                        {
                            //Add more lines if line length is a multiple of 79 and
                            //it does not end with ...
                            if (!Message.EndsWith("...") && Message.Length % MAX_LINE_LENGTH == 0)
                            {
                                OnTexOutputBufferString = Message;
                                //Message will be processed upon next call of this function.
                                return;
                            }
                        }


                        if (OnTexOutput != null)
                            OnTexOutput(this, Message);

                        //add warning and errors to
                        myPdflatexOutputParser.addLine(Message);
                        //if this was the last output line, start parsing.
                        if (Message.Contains("Transcript written on"))
                            myPdflatexOutputParser.parseOutput();
                    }
                )
            );
        }        

    }


    /// <summary>
    /// This class receives strings with Tikz-Code (see AddJob) and compiles them to BMP images.
    /// </summary>
    public class TikzToBMPFactory : TexCompiler 
    {
        public static TikzToBMPFactory Instance = new TikzToBMPFactory();

        static TikzToBMPFactory()
        {
            Instance.JobFailed += new JobEventHandler(OnJobFailed);
            Instance.timeout = 5000;
        }

        public static void OnJobFailed(object sender, Job job)
        {
            MessageBox.Show("Compilation of the Codesnippet-Thumbnail " + job.path + " (" + job.name + ") failed.\r\nPlease re-check the code.");
        }

    }

    /// <summary>
    /// This class hosts the single instance of the Compiler used for compiling all the tex files 
    /// (...but not the snippet thumbnails)
    /// </summary>
    public class TheCompiler : TexCompiler
    {
        public static TexCompiler _Instance = new TexCompiler();
        public static TexCompiler Instance
        {
            get { return _Instance; }
            set { }
        }
    }
}
