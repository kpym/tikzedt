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

namespace TikzEdt
{
    public class TexCompiler
    {
        public delegate void NoArgsEventHandler();
        public event NoArgsEventHandler BitmapGenerated;            // called after _successful_ bitmap generation
        public event NoArgsEventHandler JobNumberChanged;           // called whenever the number of jobs in the queue changed

        public double timeout = 5000; // in milliseconds
        public double Resolution = 50;
        protected struct Job
        {
            public string code, path, name;
            public Rect BB;
            public Job(string tcode, string tpath, Rect tBB, string tname)
            {
                code = tcode; path = tpath; BB = tBB; name = tname;
            }
        }
        protected Queue<Job> todo_tex = new Queue<Job>();

        /// <summary>
        /// Adds some tikz code to the internal TODO list, to be compiled as soon as possible.
        /// </summary>
        /// <param name="code">Tikz Code to compile</param>
        /// <param name="path">Path, without ending, e.g. img\myfile </param>
        /// <param name="BB">The bounding box</param>
        public void AddJob(string code, string path, Rect BB, string name = "")
        {
            todo_tex.Enqueue(new Job(code, path, BB, name));
            if (JobNumberChanged != null)
                JobNumberChanged();
            if (!isRunning)
                doCompile();
        }

        public int JobsInQueue
        {
            get { return todo_tex.Count; }
        }

        protected Process texProcess = new Process();
        protected bool isRunning = false;
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
            if (isRunning || todo_tex.Count == 0)
            {
                return;
            }
            isRunning = true;
            Job job = todo_tex.Peek();

            if (!File.Exists(Consts.cTempFile + ".fmt"))
            {
                Helper.GeneratePrecompiledHeaders();
                return;
            }

            // save into temporary textfile
            // add bounding box
            bool lsucceeded;
            string codetowrite = job.code;
            if (job.BB.Width > 0 && job.BB.Height > 0)
                codetowrite = writeBBtoTikz(job.code, job.BB, out lsucceeded);

            if (!Directory.Exists(System.IO.Path.GetDirectoryName(job.path)))
                Directory.CreateDirectory(System.IO.Path.GetDirectoryName(job.path));

            StreamWriter s = new StreamWriter(job.path + ".tex");
            if (IsStandalone(job.code))
            {
                s.WriteLine(codetowrite);
            }
            else
            {
                s.WriteLine(@"%& ..\" + Consts.cTempFile);
                s.WriteLine("\\begin{document}");
                s.WriteLine(codetowrite);
                s.WriteLine(Properties.Settings.Default.Tex_Postamble);
            }
            s.Close();

            // call pdflatex         
            texProcess.StartInfo.Arguments = "-quiet -halt-on-error " + "\"" + job.path + ".tex" + "\"";
            texProcess.StartInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(job.path);

            // Set reset timer in case something goes wrong
            timer.Interval = TimeSpan.FromMilliseconds(timeout);
            timer.Start();
            texProcess.Start();
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
            if (succeeded)
                return tok[0] + @"\draw (" + BB.X + "," + BB.Y + ") rectangle (" + (BB.X + BB.Width).ToString() + "," + (BB.Y + BB.Height).ToString() + "); " + cend + tok[1];
            else
                return code;
        }

        public TexCompiler()
        {

            texProcess.EnableRaisingEvents = true;
            //texProcess.StartInfo.Arguments = "-quiet -halt-on-error " + Consts.cTempFile + ".tex";
            texProcess.StartInfo.FileName = "pdflatex";
            texProcess.StartInfo.CreateNoWindow = true;
            texProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            // texProcess.SynchronizingObject = (System.ComponentModel.ISynchronizeInvoke) this;
            texProcess.Exited += new EventHandler(texProcess_Exited);
            timer.Tick += new EventHandler(timer_Tick);

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
            Job job = todo_tex.Dequeue();
            if (JobNumberChanged != null)
                JobNumberChanged();

            if (texProcess.ExitCode == 0)
            {

                if (!mypdfDoc.LoadPdf(job.path + ".pdf"))
                {
                    MessageBox.Show("Couldn't load pdf");
                }
                else
                {
                    Dispatcher.CurrentDispatcher.Invoke(new Action(
                        delegate()
                        {
                            mypdfDoc.SaveBmp(job.path + ".bmp", Resolution);
                            if (BitmapGenerated != null)
                                BitmapGenerated();
                        }
                        ));
                }
            }
            else MessageBox.Show("Compilation of the Codesnippet-Thumbnail " + job.path + " (" + job.name + ") failed.\r\nPlease re-check the code.");

            isRunning = false;
            if (todo_tex.Count > 0)
                doCompile();
        }

        /// <summary>
        /// Checks whether the current code can be compiled,
        /// or whether we need to append pre-/postambles
        /// </summary>
        /// <returns></returns>
        public static bool IsStandalone(string code)
        {
            return (code.Contains("\\documentclass") 
                    || code.Trim().StartsWith("%&") );    // precompiled header
        }

    }


    /// <summary>
    /// This class receives strings with Tikz-Code (see AddJob) and compiles them to BMP images.
    /// </summary>
    public class TikzToBMPFactory : TexCompiler 
    {
        public static TikzToBMPFactory Instance = new TikzToBMPFactory();



    }


}
