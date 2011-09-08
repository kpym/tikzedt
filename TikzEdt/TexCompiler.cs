/*This file is part of TikzEdt.
 
TikzEdt is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.
 
TikzEdt is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
GNU General Public License for more details.
 
You should have received a copy of the GNU General Public License
along with TikzEdt.  If not, see <http://www.gnu.org/licenses/>.*/

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
using System.Threading;

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
        public delegate void TexErrorHandler(object sender, TexOutputParser.TexError Error, Job job);
        public event TexErrorHandler OnTexError;

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

        public double timeout = 0; // in milliseconds, 0 = no timeout. Note overwritten in doCompile()
        public double Resolution = 50;
        public class Job
        {
            public string   code="",   // The tex code 
                            path="",   // The tex-filename, if empty string "", the default tempfile is used
                            name="";   // (optional) A description, to be displayed on error
            public Rect BB =new Rect(0,0,0,0);         // The BoundingBox. If it has size >0, a rectangle is inserted into the tex code
            public bool CreateBMP=false;  // if true, create bmp file, if false, create pdf only
            public bool WriteCode=true;  // true if code should be written to path, false if file already exists and just needs to be compiled
            public bool GeneratePrecompiledHeaders = false; // if set to true, a precompiled header is generated

            public bool BBShallBeWritten = false;   // indicates whether the compiler should try to smuggle BB code into the file
            public bool hasBB = false;              // indicates whether the BB could be determined
            public bool BBWritten = false;          // indicates whether code to determine the BB has been succesfully smuggled into the file

            public long DocumentID = 0;             // used to match jobs with documents, see comment on CurDocumentID

            //public int lineoffset = 0;     // stores how many lines were inserted at the beginning. This is to conpute the true linenr of errors

            System.Collections.Generic.SortedDictionary<int, int> LineOffsetDict = new SortedDictionary<int, int>();
            /// <summary>
            /// Translates a line number of the temp file (that is the one that was compiled)
            /// to the corresponding line number in the editor.
            /// </summary>
            /// <param name="LineInTempFile"></param>
            /// <returns></returns>
            public int TempFileLineToEditorLine(int LineInTempFile)
            {
                //search for the key (i.e. the line) that is just greater than LineInTempFile 
                //then take the value (as offset) of the previous line.
                //Note: If a line is requested that was inserted into the temp file, this will
                //return the line number in the editor of where the text was inserted.
                int Offset = 0;
                foreach(System.Collections.Generic.KeyValuePair<int, int> entry in LineOffsetDict)
                {
                    if (LineInTempFile > entry.Key && LineInTempFile >= entry.Key + entry.Value)
                        Offset = entry.Value;
                    else if (LineInTempFile > entry.Key && LineInTempFile < entry.Key + entry.Value)
                        Offset = entry.Key + entry.Value - LineInTempFile;
                    else
                        break;               
                }
                return LineInTempFile - Offset;
            }
            /// <summary>
            /// Call this function if text is added to the temp file (the one that is compiled).
            /// Automatically clears itself when called with LineNumber==0.
            /// Note: PositionOfAddedLine==1 means at the very top was something inserted.
            /// </summary>
            /// <param name="LineNumber">indicates where lines are added</param>
            /// <param name="LineCount">indicates how many line are added at that location</param>
            public void AddOffset(int PositionOfAddedLine, int NumberOfAddedLines)
            {
                
                //if there are offsets below the just inserted one, then all lower offsets have to be shifted down accordingly.
                System.Collections.Generic.SortedDictionary<int, int> TempDict = new SortedDictionary<int, int>();
                List<int> DeleteKeyList = new List<int>();
                foreach (System.Collections.Generic.KeyValuePair<int, int> entry in LineOffsetDict)
                {
                    if (PositionOfAddedLine <= entry.Key)
                    {
                        TempDict[entry.Key + NumberOfAddedLines] = LineOffsetDict[entry.Key] + NumberOfAddedLines;
                        DeleteKeyList.Add(entry.Key);
                    }
                    else if (PositionOfAddedLine > entry.Key)
                        break;
                }
                
                foreach (int key in DeleteKeyList)
                {
                    LineOffsetDict.Remove(key);                  
                }
                foreach (System.Collections.Generic.KeyValuePair<int, int> entry in TempDict)
                {
                    LineOffsetDict[entry.Key] = TempDict[entry.Key];
                }

                LineOffsetDict.Add(PositionOfAddedLine, NumberOfAddedLines);

            }
            public void OffsetClear()
            {
                LineOffsetDict.Clear();
            }

            //for debugging include cmdline which is executed
            public string cmdline;

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

        /// <summary>
        /// We do not use the events generated by the c# process because it can not guarantee that all output is read before 
        /// the process_exited event is called (=> we would have some orphan output which is hard to match to a job)
        /// 
        /// Instead, all output is read in this backgroundworker, which generates the Outputdatareceived and 
        /// processExited events, in the correct order.
        /// (I.e., when exited occurs, all output has been read)
        /// </summary>
        System.ComponentModel.BackgroundWorker AsyncReaderWorker = new System.ComponentModel.BackgroundWorker();
        class AsyncReaderReturnType
        {
            public string stdout, stderr;
        }
        void AsyncReaderWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // read asynchronously from the process output
            StringWriter sw = new StringWriter();
            StringWriter ew = new StringWriter();
            try
            {
                // read all output from stdout
                string line;
                while ((line = texProcess.StandardOutput.ReadLine()) != null)
                {
                    sw.WriteLine(line);
                    // call handler
                    texProcess_OutputDataReceived(texProcess, line);
                }

                // read all output from stderr
                //err_out = texProcess.StandardError.ReadToEnd();
                while ((line = texProcess.StandardError.ReadLine()) != null)
                {
                    ew.WriteLine(line);
                    // call handler
                    texProcess_OutputDataReceived(texProcess, line);
                }
            }
            catch (ThreadAbortException)
            {
                // process terminated by user
                MainWindow.AddStatusLine("PdfLatex: process terminated by user.", true);
            }
            finally
            {
                texProcess.WaitForExit();
                AsyncReaderReturnType ret = new AsyncReaderReturnType();
                ret.stderr = ew.ToString();
                ret.stdout = sw.ToString();
                e.Result = ret;
            }
        }
        void AsyncReaderWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            //EventArgs ea = new EventArgs();
            //texProcess_Exited(texProcess, ea);
            AsyncReaderReturnType ret = e.Result as AsyncReaderReturnType;
            texprocess_Exited(ret.stdout, ret.stderr); 
        }

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
            if (job.path == "") //compile in work dir!
                job.path = /*Helper.GetAppDir() + "\\" + */Helper.GetTempFileName() + ".tex";

            todo_tex.Enqueue(job);
            if (JobNumberChanged != null)
                JobNumberChanged(this);
            if (!Compiling)//(!isRunning)
                doCompile();
        }
        // this Job generates the default precompiled header
        public static Job GetPrecompiledHeaderJob()
        {
            Job job = new Job();
            job.code = Properties.Settings.Default.Tex_Preamble;
            job.path = Helper.GetPrecompiledHeaderPath() + Helper.GetPrecompiledHeaderFilename();
            job.name = System.IO.Path.GetFileNameWithoutExtension(Helper.GetPrecompiledHeaderFilename());
            job.GeneratePrecompiledHeaders = true;
            return job;
        }
        /// <summary>
        /// Same as AddJob, but deletes all other pending jobs first.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="path"></param>
        /// <param name="BB"></param>
        /// <param name="name"></param>
        public void AddJobExclusive(string code, string path, bool BBShallBeWritten, long DocumentID = 0)
        {
            Job job = new Job();
            job.code = code;
            job.path = path;
            job.BBShallBeWritten = BBShallBeWritten;
            job.CreateBMP = false;
            job.WriteCode = true;
            job.DocumentID = DocumentID;

            AddJobExclusive(job);
        }
        public void AddJobExclusive(string path, long DocumentID = 0)
        {           
            Job job = new Job();
            job.path = path;
            job.CreateBMP = false;
            job.WriteCode = false;
            job.DocumentID = DocumentID;

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
            try
            {

                if (!texProcess.HasExited)
                    texProcess.Kill();
            }
            catch (InvalidOperationException)
            {
                SetValue(CompilingPropertyKey, false);
            }
            
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

            //get current timeout value from settings -> is set using property
            //TheCompiler.Instance.timeout = Properties.Settings.Default.Timeout_pdflatex;

            SetValue(CompilingPropertyKey, true);

            Job job;
            if (!File.Exists(Helper.GetPrecompiledHeaderPath() + System.IO.Path.GetFileNameWithoutExtension(Helper.GetPrecompiledHeaderFilename()) + ".fmt"))
            {
                // if (OnCompileEvent != null)
                //    OnCompileEvent(this, "Generating precompiled headers.... please restart in some moments", CompileEventType.Status); 
                //Helper.GeneratePrecompiledHeaders();  // todo: add as compile job
                //return;

                //Note: If this job fails, header compiliation and compiliation of the main document is stopped to prevent infinite loop.
                job = GetPrecompiledHeaderJob();
            }
            else
            {
                // Take the next job from the queue and process
                job = todo_tex.Dequeue();
            }
            CurrentJob = job;

            // save into temporary textfile
            if (job.WriteCode || job.GeneratePrecompiledHeaders)
            {
                // add bounding box
                bool lsucceeded;
                int PositionOfAddedLine, NumberOfAddedLines;
                string codetowrite = job.code;
                //if (job.BB.Width > 0 && job.BB.Height > 0)
                //    codetowrite = writeBBtoTikz(job.code, job.BB, out lsucceeded);
                if (job.BBShallBeWritten && !job.GeneratePrecompiledHeaders)
                {
                    codetowrite = writeBBWritertoTikz(job.code, out lsucceeded, out PositionOfAddedLine, out NumberOfAddedLines);
                    if (lsucceeded)
                    {
                        job.BBWritten = true;
                        job.AddOffset(PositionOfAddedLine, NumberOfAddedLines);
                    }
                }

                if (!Directory.Exists(System.IO.Path.GetDirectoryName(job.path)))
                    Directory.CreateDirectory(System.IO.Path.GetDirectoryName(System.IO.Path.GetFullPath(job.path)));

                StreamWriter s = new StreamWriter(job.path);
                if (job.GeneratePrecompiledHeaders || IsStandalone(job.code))
                {
                    s.WriteLine(codetowrite);

                    //check for:
                    //\usepackage[active,tightpage]{preview}
                    //\PreviewEnvironment{tikzpicture}
                    //and insert if required
                    if (ContainsPreviewEnvironment(job.code) == false && ContainsDoNotInsertPreviewEnvironment(job.code) == false && !job.GeneratePrecompiledHeaders)
                    {

                        // Inserting code in the editor is not so good since it breaks some tex files, e.g., testcase 29.
                        // Also, in production mode, preview env. code is not necessary
                        // just display a warning


                        string PreviewEnvCode = Environment.NewLine + @"\usepackage[active,tightpage]{preview}" + Environment.NewLine
                                                + @"\PreviewEnvironment{tikzpicture}";// +Environment.NewLine + Environment.NewLine;
                        MainWindow.AddStatusLine("Warning: No PreviewEnvironment code found, overlay might be misaligned. Insert:"
                              + PreviewEnvCode);
                        /*int PosBeginDoc = ((MainWindow)Application.Current.Windows[0]).txtCode.Text.IndexOf(@"\begin{document}");
                        
                        //int PosBeginDoc = job.code.IndexOf(@"\begin{document}");
                        if (PosBeginDoc == -1)
                        {
                            MainWindow.AddStatusLine("Could not insert PreviewEnvironment code!", true);

                        }
                        else
                        {
                            ((MainWindow)Application.Current.Windows[0]).txtCode.Document.Insert(PosBeginDoc, PreviewEnvCode);
                            //((MainWindow)Application.Current.Windows[0]).txtCode.Text.Insert
                            MainWindow.AddStatusLine("PreviewEnvironment code inserted.");
                            ((MainWindow)Application.Current.Windows[0]).ChangesMade = true;                            
                        } */
                    }
                        
                }
                else
                {
                    s.WriteLine("%& \"" + Helper.GetPrecompiledHeaderPath() + Helper.GetPrecompiledHeaderFilename() + "\"");
                    s.WriteLine("\\begin{document}");
                    int LinesJustAdded = 2;
                    //job.lineoffset = 2;
                    job.AddOffset(1 /*start counting at 1*/, LinesJustAdded);

                    s.WriteLine(codetowrite);
                    s.WriteLine(Properties.Settings.Default.Tex_Postamble);
                    job.AddOffset(LinesJustAdded + Helper.CountStringOccurrences(codetowrite, Environment.NewLine) + 1 /*start counting at 1*/,
                        Helper.CountStringOccurrences(Properties.Settings.Default.Tex_Postamble, Environment.NewLine) + 1 /*add 1 for WriteLine()*/);
                }
                s.Close();
            }

            // call pdflatex 
            if (job.GeneratePrecompiledHeaders)
            {
                texProcess.StartInfo.Arguments = "-ini -job-name=\"" + job.name
                    + "\" \"&pdflatex " + System.IO.Path.GetFileName(job.path) + "\\dump\"";                
            }
            else
            {
                texProcess.StartInfo.Arguments = "-interaction=nonstopmode -halt-on-error \"" + job.path + "\"";
            }
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
            {
                if (job.GeneratePrecompiledHeaders)
                    OnCompileEvent(this, "Generating precompiled header: " + texProcess.StartInfo.FileName + " " + texProcess.StartInfo.Arguments, CompileEventType.Start);
                else
                    OnCompileEvent(this, "Compiling document for preview: " + texProcess.StartInfo.FileName + " " + texProcess.StartInfo.Arguments, CompileEventType.Start);
            }
            job.cmdline =  texProcess.StartInfo.WorkingDirectory +">"+ texProcess.StartInfo.FileName + " " + texProcess.StartInfo.Arguments;
            try
            {
                texProcess.Start();

                // start asynchronous reading of the process output
                //texProcess.BeginOutputReadLine();
                //texProcess.BeginErrorReadLine(); // needed e.g. when %& "temp_preview_header" invalid.
                //myPdflatexOutputParser.Clear();
                AsyncReaderWorker.RunWorkerAsync();
            }
            catch (System.ComponentModel.Win32Exception ex)
            { 
                //texprocess_Exited("", "Cannot find pdf compiler pdflatex.");
                //ex.NativeErrorCode == 2

                timer.Stop();
                SetValue(CompilingPropertyKey, false);
                OnCompileEvent(this, "Cannot find pdf compiler pdflatex. Please install and/or add to PATH variable.", CompileEventType.Error);
                

                if (JobFailed != null)
                {
                    JobFailed(this, job);
                }
            }
            
        }

        void timer_Tick(object sender, EventArgs e)
        {
            //if a timeout of pdflatex occured, check whether pdflatex has the packagemanager library loaded.
            //if it has, pdflatex is most probably loading a required package from the Internet.
            //in this case do not kill pdflatex (if pdflatex crashes now ... bad luck!)
            bool InstallingPacket = false;
            foreach (ProcessModule pm in texProcess.Modules)
            {
                if (pm.ModuleName.Contains("packagemanager"))
                {                    
                    InstallingPacket = true;
                }
            }

            if (InstallingPacket == false)
            {
                MainWindow.AddStatusLine("Timeout. Compilation aborted", true);
                AbortCompilation();
            }
            else 
            {
                MainWindow.AddStatusLine("Please wait. pdflatex seems to be installing some required package.");
            }
        }
        /// <summary>
        /// Adds a rectangle to the Tikzcode in the size specified by BB. 
        /// The rectangle is added as the last command before the \end{tikzpicture} 
        /// </summary>
        /// <param name="code">The Tikz Code. Must contain an "\end{tikzpicture}" </param>
        /// <param name="BB">The bounding box (= size of rectangle to be written) </param>
        /// <param name="succeeded">Returns success, i.e., whether the string "\end{tikzpicture}" has been found</param>
        /// <returns>The Tikzcode, with the "\draw rectangle ...." inserted </returns>
 /*       string writeBBtoTikz(string code, Rect BB, out bool succeeded)
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
        } */

        Regex endpictureRegex = new Regex(@"(\\end\s*{\s*tikzpicture\s*})", RegexOptions.Compiled);
        string writeBBWritertoTikz(string code, out bool succeeded, out int PositionOfAddedLine, out int NumberOfAddedLines)
        {

            string[] tok = endpictureRegex.Split(code, 3); // Regex.Split includes matched string in results if enclosed in parentheses
            succeeded = (tok.Length == 3 );
            if (succeeded)
            {
                //if a document contains "\n" as line break, Environment.Newline will not do. Use "\n" therefore.
                PositionOfAddedLine = Helper.CountStringOccurrences(tok[0], "\n") + 1 /*start counting at 1*/;
                NumberOfAddedLines = Helper.CountStringOccurrences(Consts.CodeToWriteBB, System.Environment.NewLine);
                return tok[0] + Consts.CodeToWriteBB + tok[1] + tok[2];
            }
            else
            {
                PositionOfAddedLine = 0;
                NumberOfAddedLines = 0;
                return code;
            }
        }


        public TexCompiler()
        {

            //texProcess.EnableRaisingEvents = true;
            //texProcess.StartInfo.Arguments = "-quiet -halt-on-error " + Consts.cTempFile + ".tex";
            texProcess.StartInfo.FileName = Properties.Settings.Default.Path_pdflatex;//"pdflatex";
            texProcess.StartInfo.CreateNoWindow = true;
            texProcess.StartInfo.UseShellExecute = false;
            texProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            texProcess.StartInfo.RedirectStandardOutput = true;
            texProcess.StartInfo.RedirectStandardError = true;
            // texProcess.SynchronizingObject = (System.ComponentModel.ISynchronizeInvoke) this;
            //texProcess.Exited += new EventHandler(texProcess_Exited);
            //texProcess.OutputDataReceived += new DataReceivedEventHandler(texProcess_OutputDataReceived);
            //texProcess.ErrorDataReceived += new DataReceivedEventHandler(texProcess_OutputDataReceived);
            timer.Tick += new EventHandler(timer_Tick);

            AsyncReaderWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(AsyncReaderWorker_DoWork);
            AsyncReaderWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(AsyncReaderWorker_RunWorkerCompleted);

            myPdflatexOutputParser.OnTexError += new TexOutputParser.TexErrorHandler(myPdflatexOutputParser_OnTexError);
            //myPdflatexOutputParser.addProblem +=new PdflatexOutputParser.addProblemEventHandler(myPdflatexOutputParser_addProblem);
            //texProcess.ErrorDataReceived += new DataReceivedEventHandler(texProcess_ErrorDataReceived);
        }



        void myPdflatexOutputParser_OnTexError(object sender, TexOutputParser.TexError e, Job job)
        {
            if (OnTexError != null)
            {
                OnTexError(sender, e, job);
            }            
        }


        /// <summary>
        /// This is called when PDFLatex has exited
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //void texProcess_Exited(object sender, EventArgs e)
        void texprocess_Exited(string StdOutput, string ErrOutput)
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

            // Parse tex errors/warnings and display
            myPdflatexOutputParser.parseOutput(job);


            if (texProcess.ExitCode == 0)
            {
                if (job.BBWritten && !job.GeneratePrecompiledHeaders)
                {
                    ReadBBFromFile(job);
                }

                if (OnCompileEvent != null)
                    OnCompileEvent(this, "Compilation done", CompileEventType.Success);
                if (JobSucceeded != null)
                    JobSucceeded(this, job);

                //for thumbnail generation
                if (job.CreateBMP && !job.GeneratePrecompiledHeaders)
                {
                    string pathnoext = Helper.RemoveFileExtension(job.path);

                    if (!mypdfDoc.LoadPdf(pathnoext + ".pdf"))
                    {
                        MessageBox.Show("Couldn't load pdf " + pathnoext + ".pdf");
                    }
                    else if (mypdfDoc.IsEmpty())
                    {
                        MessageBox.Show("Image is empty. Did you fill out the sample code block?");
                    }
                    else
                    {
                        //mypdfDoc.SaveBmp(pathnoext + ".bmp", Resolution);
                        mypdfDoc.SaveBmp(pathnoext + ".png", Resolution, true, System.Drawing.Imaging.ImageFormat.Png);
                        if (BitmapGenerated != null)
                            BitmapGenerated(this);
                    }
                }
                else if (job.GeneratePrecompiledHeaders == true)
                {   //if the header should have been generated but it was not
                    if (!File.Exists(Helper.GetPrecompiledHeaderPath() + System.IO.Path.GetFileNameWithoutExtension(Helper.GetPrecompiledHeaderFilename()) + ".fmt"))
                    {
                        todo_tex.Clear();
                        if (OnCompileEvent != null)
                            OnCompileEvent(this, "Compilation of pre-compiled header succeded but the pre-compiled header file could not be found." +
                                " It is supposed to be here: " + Helper.GetPrecompiledHeaderPath() + System.IO.Path.GetFileNameWithoutExtension(Helper.GetPrecompiledHeaderFilename()) + ".fmt" +
                                Environment.NewLine + "Compilation of main document stopped. Check settings and read/write permissions!", CompileEventType.Error);
                    }
                    else
                    { 
                        //clear source and temp files of compilation of header                        
                        //note: the .tex file must not be deleted!
                        Helper.DeleteTemporaryFiles(job.path, false);
                    }
                }
            }
            else
            {
                
                //if generating pre-compiled header failed. it will not work next time.
                //so clear job queue and tell user to fix header code.
                if (job.GeneratePrecompiledHeaders == true)
                {
                    todo_tex.Clear();
                    if (OnCompileEvent != null)
                        OnCompileEvent(this, "Compilation of pre-compiled header failed with exit code " + texProcess.ExitCode +". Compilation of main document stopped. Check under settings code of pre-compiled header!", CompileEventType.Error);
                    if (JobNumberChanged != null)
                        JobNumberChanged(this);
                }
                else
                {
                    if (OnCompileEvent != null)
                        OnCompileEvent(this, "Compilation failed with exit code " + texProcess.ExitCode, CompileEventType.Error);
                }

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
        /// Unfortunately, for exotic cases (e.g., \begin{tikzpicture}[overlay])  a bogus BB of 16000pt is written.
        /// In this case, report failure
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
                        if (job.BB.Width < 500 && job.BB.Height < 500)
                            job.hasBB = true;
                        else
                            job.hasBB = false;

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
        /// 3) if it starts with string "%&". (Precompiled header)
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
                ret = ( (code.Contains("\\documentclass") && !code.Contains("%\\documentclass") && !code.Contains("% \\documentclass")  )
                    || code.Trim().StartsWith("%&") );    // precompiled header

            //using data binding would probably be nicer...
            ((MainWindow)Application.Current.Windows[0]).SetStandAloneStatus(ret);

            return ret;
        }

        public bool ContainsPreviewEnvironment(string code)
        {
            RegexOptions ro = new RegexOptions();
            ro = ro | RegexOptions.IgnoreCase;
            ro = ro | RegexOptions.Multiline;
            string PreviewEnv_RegexString = @"\\usepackage\s*\[([^\],]*,)*(\s*(active|tightpage)\s*,)([^\],]*,)*(\s*(active|tightpage)\s*)(,[^\],]*)*\]\s*({\s*preview\s*})([\x00-\xFF]*?)\\previewenvironment\s*{\s*tikzpicture\s*}";
            Regex BB_Regex = new Regex(PreviewEnv_RegexString, ro);
            Match m = BB_Regex.Match(code);
            if (m.Success == true)
                return true;
            else
                return false; 
        }
        public bool ContainsDoNotInsertPreviewEnvironment(string code)
        {
            RegexOptions ro = new RegexOptions();
            ro = ro | RegexOptions.IgnoreCase;
            ro = ro | RegexOptions.Multiline;
            string NoPreview_RegexString = @"^[ \t\s]*%[ \t\s]*!TIKZEDT[ \t\s]*NOPREVIEW[ \t\s]*^";
            Regex BB_Regex = new Regex(NoPreview_RegexString, ro);
            Match m = BB_Regex.Match(code);
            if (m.Success == true)
                return true;
            else
                return false;
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
            texProcess_OutputDataReceived(sender, e.Data);
        }
        void texProcess_OutputDataReceived(object sender, string line)
        {
            
            Dispatcher.Invoke(
                new Action(
                    delegate()
                    {
                        string Message = line;
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
                            //it does not end with "...", '"', or ')'
                            //[These are the common line endings of lines with variable length]
                            if (!Message.EndsWith("...") && !Message.EndsWith("\"") && !Message.EndsWith(")") 
                                && Message.Length % MAX_LINE_LENGTH == 0)
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

                        // Note: parsing is now started in texprocess_exited 
                        //if this was the last output line, start parsing.
                        //if (Message.Contains("Transcript written on"))
                        //    myPdflatexOutputParser.parseOutput();
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
            Instance.timeout = Properties.Settings.Default.Compiler_SnippetTimeout;
        }

        public static void OnJobFailed(object sender, Job job)
        {
            string msg = "Compilation of the Codesnippet-Thumbnail " + job.path + " (" + job.name + ") failed.\r\nPlease re-check the code.";
            msg += Environment.NewLine + Environment.NewLine + "cmdline: " + job.cmdline;
            MessageBox.Show(msg);
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

        static TheCompiler()
        {
            Instance.timeout = Properties.Settings.Default.Compiler_Timeout;
        }

        public static void GeneratePrecompiledHeaders()
        {
            Instance.AddJob(GetPrecompiledHeaderJob());
        }
    }
}
