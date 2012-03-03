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
//using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
//using System.Windows.Shapes;
//using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Windows.Threading;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using SmartWeakEvent;
using TESharedComponents;

namespace TikzEdt
{
    public class TexCompiler : TikzEdt.ViewModels.ViewModelBase //DependencyObject //DispatcherObject
    {
        #region events
        //*** Note that some events are consumed by TEDocumentVM, which has a shorter lifetime than TexCompiler
        //*** Hence we need to use weak events to avoid memory leaks

        FastSmartWeakEvent<EventHandler> _BitmapGenerated = new FastSmartWeakEvent<EventHandler>();
        public event EventHandler BitmapGenerated
        {
            add { _BitmapGenerated.Add(value); }
            remove { _BitmapGenerated.Remove(value); }
        }

        FastSmartWeakEvent<EventHandler> _JobNumberChanged = new FastSmartWeakEvent<EventHandler>();
        public event EventHandler JobNumberChanged
        {
            add { _JobNumberChanged.Add(value); }
            remove { _JobNumberChanged.Remove(value); }
        }
        
 //       public delegate void NoArgsEventHandler(object sender);
 //       public event NoArgsEventHandler BitmapGenerated;            // called after _successful_ bitmap generation
 //       public event NoArgsEventHandler JobNumberChanged;           // called whenever the number of jobs in the queue changed
        public class JobEventArgs : EventArgs
        {
            public Job job;
            public TexOutputParser.ParseResult OutputParseResult;
            public int ExitCode; // the exitcode of the pdflatex process
            
            //public JobEventArgs(Job tjob) { job = tjob; }
            public JobEventArgs(Job tjob, TexOutputParser.ParseResult presult, int exitCode) { job = tjob; OutputParseResult = presult; ExitCode = exitCode; }
        }

        FastSmartWeakEvent<EventHandler<JobEventArgs>> _JobDone = new FastSmartWeakEvent<EventHandler<JobEventArgs>>();
        public event EventHandler<JobEventArgs> JobDone
        {
            add { _JobDone.Add(value); }
            remove { _JobDone.Remove(value); }
        }
    /*    FastSmartWeakEvent<EventHandler<JobEventArgs>> _JobSucceeded = new FastSmartWeakEvent<EventHandler<JobEventArgs>>();
        public event EventHandler<JobEventArgs> JobSucceeded
        {
            add { _JobSucceeded.Add(value); }
            remove { _JobSucceeded.Remove(value); }
        }
        */

    //    public delegate void JobEventHandler(object sender, Job job);
    //    public event JobEventHandler JobFailed;
    //    public event JobEventHandler JobSucceeded;

        public enum CompileEventType { Start, Error, Success, Status };
        public class CompileEventArgs : EventArgs
        {
            public CompileEventType Type = CompileEventType.Status;
            public string Message;
            //public TexOutputParser.TexError Error = null;
            public Job job;
            
            public CompileEventArgs() { }
            public CompileEventArgs(string message) { Message = message; }
            public CompileEventArgs(string message, CompileEventType type) { Message = message; Type = type; }
        }
        FastSmartWeakEvent<EventHandler<CompileEventArgs>> _OnCompileEvent = new FastSmartWeakEvent<EventHandler<CompileEventArgs>>();
        public event EventHandler<CompileEventArgs> OnCompileEvent
        {
            add { _OnCompileEvent.Add(value); }
            remove { _OnCompileEvent.Remove(value); }
        }
        FastSmartWeakEvent<EventHandler<CompileEventArgs>> _OnTexOutput = new FastSmartWeakEvent<EventHandler<CompileEventArgs>>();
        public event EventHandler<CompileEventArgs> OnTexOutput
        {
            add { _OnTexOutput.Add(value); }
            remove { _OnTexOutput.Remove(value); }
        }
       /* FastSmartWeakEvent<EventHandler<CompileEventArgs>> _OnTexError = new FastSmartWeakEvent<EventHandler<CompileEventArgs>>();
        public event EventHandler<CompileEventArgs> OnTexError
        {
            add { _OnTexError.Add(value); }
            remove { _OnTexError.Remove(value); }
        } */

     //   public delegate void CompileEventHandler(object sender, string Message, CompileEventType type);
     //   public event CompileEventHandler OnCompileEvent;
     //   public delegate void TexOutputHandler(object sender, string Message);
     //   public event TexOutputHandler OnTexOutput;
     //   public delegate void TexErrorHandler(object sender, TexOutputParser.TexError Error, Job job);
     //   public event TexErrorHandler OnTexError;

        #endregion


        // This read only property indicates whether the Compiler is currently busy
    /*    readonly private static DependencyPropertyKey CompilingPropertyKey = DependencyProperty.RegisterReadOnly(
        "Compiling", typeof(bool), typeof(TexCompiler), new PropertyMetadata(false));
        readonly public static DependencyProperty CompilingProperty = CompilingPropertyKey.DependencyProperty;
        public bool Compiling
        {
            //if pre-compiling was started, isRunning stays true. No other compiliation can be started.
            //could CompilingProperty and isRunning be merged?
            get { return (bool)GetValue(CompilingProperty); }
            set { }
        } */
        bool _Compiling = false;
        public bool Compiling
        {
            get { return _Compiling; }
            private set
            {
                _Compiling = value;
                NotifyPropertyChanged("Compiling");
            }
        }
        void SetCompiling(bool value) { Compiling = value; }

        public double timeout = 0; // in milliseconds, 0 = no timeout. Note overwritten in doCompile()
        public double Resolution = 50;
        public class Job
        {
            public string   code="",   // The tex code 
                            path="",   // The tex-filename, if empty string "", the default tempfile is used
                            name="";   // (optional) A description, to be displayed on error
            public string ExtraCompileOptions = "";
            public Rect BB =new Rect(0,0,0,0);         // The BoundingBox. If it has size >0, a rectangle is inserted into the tex code
            public bool CreateBMP=false;  // if true, create bmp file, if false, create pdf only
            public bool WriteCode=true;  // true if code should be written to path, false if file already exists and just needs to be compiled
            public bool GeneratePrecompiledHeaders = false; // if set to true, a precompiled header is generated

            public bool BBShallBeWritten = false;   // indicates whether the compiler should try to smuggle BB code into the file
            public bool hasBB = false;              // indicates whether the BB could be determined
            public bool BBWritten = false;          // indicates whether code to determine the BB has been succesfully smuggled into the file

            public long DocumentID = 0;             // used to match jobs with documents, see comment on CurDocumentID


            //System.Collections.Generic.SortedDictionary<int, int> LineOffsetDict = new SortedDictionary<int, int>(); // key=line at which code was inserted, value=nr of inserted lines

            /// <summary>
            /// Keeps a record of the lines inserted programmatically into the temp file to allow for matching error line numbers.
            /// First=line at which code was inserted, Second=nr of inserted lines
            /// </summary>
            List<Pair<int, int>> ProgrammaticInsertions = new List<Pair<int, int>>(); 
            /// <summary>
            /// Translates a line number of the temp file (that is the one that was compiled)
            /// to the corresponding line number in the editor.
            /// </summary>
            /// <param name="LineInTempFile"></param>
            /// <returns></returns>
            public int TempFileLineToEditorLine(int LineInTempFile)
            {
                int ret = LineInTempFile;
                for (int j = ProgrammaticInsertions.Count - 1; j >= 0; j--)
                    if (ProgrammaticInsertions[j].First <= ret)
                        ret -= Math.Min(ProgrammaticInsertions[j].Second, ret - ProgrammaticInsertions[j].First);
                return ret;


                /*
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
                return LineInTempFile - Offset; */
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

                ProgrammaticInsertions.Add(new Pair<int, int>(PositionOfAddedLine, NumberOfAddedLines));

                /*
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
                */
            }
            public void OffsetClear()
            {
                ProgrammaticInsertions.Clear();
                //LineOffsetDict.Clear();
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

       // TexOutputParser myPdflatexOutputParser = new TexOutputParser();

        /// <summary>
        /// We do not use the events generated by the c# process because it can not guarantee that all output is read before 
        /// the process_exited event is called (=> we would have some orphan output which is hard to match to a job)
        /// 
        /// Instead, all output is read in this backgroundworker, which generates the Outputdatareceived and 
        /// processExited events, in the correct order.
        /// (I.e., when exited occurs, all output has been read)
        /// </summary>
        //System.ComponentModel.BackgroundWorker AsyncReaderWorker = new System.ComponentModel.BackgroundWorker();
        MyBackgroundWorker AsyncReaderWorker = new MyBackgroundWorker();
        class AsyncReaderReturnType
        {
            public string stdout, stderr;
            public TexOutputParser.ParseResult OutputParseResult;
        }
        void AsyncReaderWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
        //    GlobalUI.AddStatusLine(this, "asyncreader called");
            Job job = e.Argument as Job;

            // read asynchronously from the process output
            StringWriter sw = new StringWriter();
            StringWriter ew = new StringWriter();
            try
            {
                // read all output from stdout
                string line;
                while ((line = texProcess.StandardOutput.ReadLine()) != null)
                {
      //              GlobalUI.AddStatusLine(this, "asyncreader 0");
                    sw.WriteLine(line);
                    // call handler
                    //texProcess_OutputDataReceived(texProcess, line);
                    string line2 = line; // we need a new variable in the closure below
                    MyBackgroundWorker.BeginInvoke(Dispatcher, () => _OnTexOutput.Raise(this, new CompileEventArgs(line2)) );
                }
        //        GlobalUI.AddStatusLine(this, "asyncreader 1");
                // read all output from stderr
                //err_out = texProcess.StandardError.ReadToEnd();
                while ((line = texProcess.StandardError.ReadLine()) != null)
                {
                    ew.WriteLine(line);
                    // call handler
                    MyBackgroundWorker.BeginInvoke(Dispatcher, () => _OnTexOutput.Raise(this, new CompileEventArgs(line)));
                }
            }
            catch (ThreadAbortException)
            {
                // process terminated by user
                GlobalUI.AddStatusLine(this, "PdfLatex: process terminated by user.", true);
            }
            finally
            {
                texProcess.WaitForExit();
                AsyncReaderReturnType ret = new AsyncReaderReturnType();
                ret.stderr = ew.ToString();
                ret.stdout = sw.ToString();
                // Parse tex errors/warnings and display,... do this here b/c it takes some time and we don't want to bother the UI thread
                ret.OutputParseResult = TexOutputParser.parseOutput(ret.stdout, job);
                e.Result = ret;

                if (texProcess.ExitCode == 0)
                {
                    if (job.BBWritten && !job.GeneratePrecompiledHeaders)
                    {
                        ReadBBFromFile(job);
                    }
                }
            }
        }
        void AsyncReaderWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            //EventArgs ea = new EventArgs();
            //texProcess_Exited(texProcess, ea);
            AsyncReaderReturnType ret = e.Result as AsyncReaderReturnType;
            texprocess_Exited(ret.stdout, ret.stderr, ret.OutputParseResult); 
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
            if (job.path == null || job.path == "") 
                job.path = /*Helper.GetAppDir() + "\\" + */ System.IO.Path.GetTempPath() +  Helper.GetTempFileName() + ".tex";

            todo_tex.Enqueue(job);
            _JobNumberChanged.Raise(this, EventArgs.Empty);
            if (!Compiling)//(!isRunning)
                doCompile();
        }
        // this Job generates the default precompiled header
        public static Job GetPrecompiledHeaderJob()
        {
            Job job = new Job();
            job.code = CompilerSettings.Instance.Tex_Preamble;
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
        public void AddJobExclusive(string code, string path, bool BBShallBeWritten, long DocumentID = 0, int InitialLineOffset=0)
        {
            Job job = new Job();
            job.code = code;
            job.path = path;
            job.BBShallBeWritten = BBShallBeWritten;
            job.CreateBMP = false;
            job.WriteCode = true;
            job.DocumentID = DocumentID;

            if (InitialLineOffset > 0)
                job.AddOffset(1, InitialLineOffset);

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
                //SetValue(CompilingPropertyKey, false);
                SetCompiling(false);
            }
            
        }

        /// <summary>
        /// The main routine, starts the compilation of the Tikz-Picture.
        /// If necessary it initiates compilation of the precompiled headers.
        /// </summary>
        protected void doCompile()
        {
            //return;
  //    GlobalUI.AddStatusLine(this, "docompile  called");
            if (Compiling || todo_tex.Count == 0)
            {
                return;
            }

            //get current timeout value from settings -> is set using property
            //TheCompiler.Instance.timeout = Properties.Settings.Default.Timeout_pdflatex;

            //SetValue(CompilingPropertyKey, true);
            SetCompiling(true);

            Job job;
            if (!File.Exists(Helper.GetPrecompiledHeaderFMTFilePath()))
            {
                //Note: If this job fails, header compiliation and compiliation of the main document is stopped to prevent infinite loop.
                job = GetPrecompiledHeaderJob();
            }
            else
            {
                // Take the next job from the queue and process
                job = todo_tex.Dequeue();
            }
            CurrentJob = job;
            // Do Preprocessing 
            PreprocessJob(CurrentJob);
//    GlobalUI.AddStatusLine(this, "docompile  called 1");
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
                    codetowrite = writeBBWritertoTikz(codetowrite, out lsucceeded, out PositionOfAddedLine, out NumberOfAddedLines);
                    if (lsucceeded)
                    {
                        job.BBWritten = true;
                        job.AddOffset(PositionOfAddedLine, NumberOfAddedLines);
                    }
                }
  //          GlobalUI.AddStatusLine(this, "docompile  called 2");
                try
                {

                    if (!Directory.Exists(System.IO.Path.GetDirectoryName(job.path)))
                        Directory.CreateDirectory(System.IO.Path.GetDirectoryName(System.IO.Path.GetFullPath(job.path)));

                    using (FileStream fs = new FileStream(job.path, FileMode.OpenOrCreate))
                    using (TextWriter s = new StreamWriter(fs))
                    {
                        if (job.GeneratePrecompiledHeaders || IsStandalone(job.code))
                        {
                            s.WriteLine(codetowrite);

                            //check for:
                            //\usepackage[active,tightpage]{preview}
                            //\PreviewEnvironment{tikzpicture}
                            //and insert if required
                            if (ContainsPreviewEnvironment(codetowrite) == false && ContainsDoNotInsertPreviewEnvironment(codetowrite) == false && !job.GeneratePrecompiledHeaders)
                            {

                                // Inserting code in the editor is not so good since it breaks some tex files, e.g., testcase 29.
                                // Also, in production mode, preview env. code is not necessary
                                // just display a warning


                                string PreviewEnvCode = Environment.NewLine + @"\usepackage[active,tightpage]{preview}" + Environment.NewLine
                                                        + @"\PreviewEnvironment{tikzpicture}";// +Environment.NewLine + Environment.NewLine;
                                GlobalUI.AddStatusLine(this, "Warning: No PreviewEnvironment code found, overlay might be misaligned. Insert:"
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
                            // unfortunately, texlive seemingly cannot cope with windows filenames and " ", so we have to convert to DOS 8.3 names 
                            //s.WriteLine("%& \"" + Helper.GetPrecompiledHeaderPath() + Helper.GetPrecompiledHeaderFilename() + "\"");                            
                            s.WriteLine("%& " + Helper.GetPrecompiledHeaderShortFilePath() );
                            s.WriteLine("\\begin{document}");
                            int LinesJustAdded = 2;
                            //job.lineoffset = 2;
                            job.AddOffset(1 /*start counting at 1*/, LinesJustAdded);

                            s.WriteLine(codetowrite);
                            s.WriteLine(CompilerSettings.Instance.Tex_Postamble);
                            job.AddOffset(LinesJustAdded + Helper.CountStringOccurrences(codetowrite, Environment.NewLine) + 1 /*start counting at 1*/,
                                Helper.CountStringOccurrences(CompilerSettings.Instance.Tex_Postamble, Environment.NewLine) + 1 /*add 1 for WriteLine()*/);
                        }
                    }

                    // make file invisible
                    File.SetAttributes(job.path, File.GetAttributes(job.path) | FileAttributes.Hidden );

                }
                catch (Exception ex)
                {
                    _OnCompileEvent.Raise(this, new CompileEventArgs() { Message = "Error: Cannot create target file '" + job.path + "'. " + ex.Message, Type = CompileEventType.Error } );
                    _JobDone.Raise(this, new JobEventArgs(job, null, -1) );
                    SetCompiling(false);
                    return;
                }
            }
     //       GlobalUI.AddStatusLine(this, "docompile  called 3");
            // call pdflatex 
            if (job.GeneratePrecompiledHeaders)
            {
                string pchArgs = CompilerSettings.Instance.PrecompiledHeaderCompileCommand;
                texProcess.StartInfo.Arguments = pchArgs.Replace("$JOBNAME$", job.name).Replace("$FILENAME$", System.IO.Path.GetFileName(job.path));
                //texProcess.StartInfo.Arguments = "-ini -jobname=\"" + job.name
                //    + "\" \"&pdflatex " + System.IO.Path.GetFileName(job.path) + "\\dump\"";          

                GlobalUI.AddStatusLine(this, "compiling header... " + job.path);
            }
            else
            {
                // convert backslashes in file path to slashes
                string PathWithSlashes = job.path.Replace('\\', '/');
                texProcess.StartInfo.Arguments = "-interaction=nonstopmode -halt-on-error \"" + PathWithSlashes + "\"" + " " + job.ExtraCompileOptions;
            }
            texProcess.StartInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(job.path);
      //      GlobalUI.AddStatusLine(this, "docompile  called 4");
            // Set reset timer in case something goes wrong
            if (timeout > 0)
            {
                timer.Interval = TimeSpan.FromMilliseconds(timeout);
                timer.Start();
            }
        //    GlobalUI.AddStatusLine(this, "docompile  called 5");
            try
            {
                if (texProcess != null &&  texProcess.HasExited == true)
                {
                    texProcess.CancelOutputRead();
                    texProcess.CancelErrorRead();
                }
            }
            catch (InvalidOperationException)
            {
                //on first call when texProcess was not started, HasExited raises exception.
            }


           if (job.GeneratePrecompiledHeaders)
                _OnCompileEvent.Raise(this, new CompileEventArgs() { Message = "Generating precompiled header: " + texProcess.StartInfo.FileName + " " + texProcess.StartInfo.Arguments, Type = CompileEventType.Start });
           else
                _OnCompileEvent.Raise(this, new CompileEventArgs() { Message = "Compiling document for preview: " + texProcess.StartInfo.FileName + " " + texProcess.StartInfo.Arguments, Type = CompileEventType.Start });

            job.cmdline =  texProcess.StartInfo.WorkingDirectory +">"+ texProcess.StartInfo.FileName + " " + texProcess.StartInfo.Arguments;
            try
            {
                texProcess.StartInfo.FileName = CompilerSettings.Instance.Path_pdflatex;
                texProcess.Start();

                // start asynchronous reading of the process output
                //texProcess.BeginOutputReadLine();
                //texProcess.BeginErrorReadLine(); // needed e.g. when %& "temp_preview_header" invalid.
                //myPdflatexOutputParser.Clear();
                AsyncReaderWorker.RunWorkerAsync(job);
            }
            catch (System.ComponentModel.Win32Exception)
            { 
                //texprocess_Exited("", "Cannot find pdf compiler pdflatex.");
                //ex.NativeErrorCode == 2

                timer.Stop();
                //SetValue(CompilingPropertyKey, false);
                SetCompiling(false);
                _OnCompileEvent.Raise(this, new CompileEventArgs() { Message = "Cannot find pdf compiler pdflatex. Please install and/or add to PATH variable.", Type = CompileEventType.Error });
                _JobDone.Raise(this, new JobEventArgs(job, null, -1) );
                GlobalUI.ShowMessageBox("It seems that you do not have Latex installed. TikzEdt cannot work without Latex. Please download a Latex distribution, e.g., MikTeX or TexLive. "+
                    "If you did install it, please check that pdflatex is in the %PATH% or that the path in the settings is set correctly.", "Error running pdflatex",  MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        /// <summary>
        /// This method takes as input a compile job and does necessary preprocessing.
        /// Currently, it just removes TE comments, i.e., strings "%!TE%", from the code
        /// and scans for compile options %TEO.
        /// </summary>
        /// <param name="job">The job to be processed</param>
        /// <returns></returns>
        private void PreprocessJob(Job job)
        {           
            StringReader sr = new StringReader(job.code);
            StringWriter sw = new StringWriter();
            string line, trimline;

            while ((line = sr.ReadLine()) != null)
            {
                trimline = line.Trim();
                if (trimline.StartsWith(Consts.PreProc_CompilerOptions))
                {
                    job.ExtraCompileOptions = job.ExtraCompileOptions + trimline.Remove(0, Consts.PreProc_CompilerOptions.Length); 
                }
                else if (trimline.StartsWith(Consts.PreProc_Include))
                    sw.WriteLine("\\input{"+trimline.Remove(0, Consts.PreProc_Include.Length)+"}");
                else
                    sw.WriteLine(line);
            }
            job.code = sw.ToString().Replace(Consts.PreProc_Comment, "");
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
                GlobalUI.AddStatusLine(this, "Timeout. Compilation aborted", true);
                AbortCompilation();
            }
            else 
            {
                GlobalUI.AddStatusLine(this, "Please wait. pdflatex seems to be installing some required package.");
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
            texProcess.StartInfo.FileName = CompilerSettings.Instance.Path_pdflatex;//"pdflatex";
            texProcess.StartInfo.CreateNoWindow = true;
            texProcess.StartInfo.UseShellExecute = false;
            
      //      texProcess.StartInfo.UseShellExecute = true;
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

            //myPdflatexOutputParser.OnTexError += new TexOutputParser.TexErrorHandler(myPdflatexOutputParser_OnTexError);
            //myPdflatexOutputParser.addProblem +=new PdflatexOutputParser.addProblemEventHandler(myPdflatexOutputParser_addProblem);
            //texProcess.ErrorDataReceived += new DataReceivedEventHandler(texProcess_ErrorDataReceived);
        }



     /*   void myPdflatexOutputParser_OnTexError(object sender, TexOutputParser.TexError e, Job tjob)
        {
            _OnTexError.Raise(sender, new CompileEventArgs() { Error = e, job = tjob } );                        
        }
        */

        /// <summary>
        /// This is called when PDFLatex has exited
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //void texProcess_Exited(object sender, EventArgs e)
        void texprocess_Exited(string StdOutput1, string ErrOutput1, TexOutputParser.ParseResult OutputParseResult)
        {
            timer.Stop();

            // Note: Try to do as much work as possible in the backgroundworker, to not delay the UI thread
                      

            // Some tasks require synchronization, ... so do them here
            MyBackgroundWorker.BeginInvoke(Dispatcher, new Action(delegate()
            {
                Job job = CurrentJob;
                _JobNumberChanged.Raise(this, EventArgs.Empty);    // invoke here... it would also be possible to invoke on start of compilation...
                   
            if (texProcess.ExitCode == 0)
            {
               // if (job.BBWritten && !job.GeneratePrecompiledHeaders)
               // {
               //     ReadBBFromFile(job);
               // }

                _OnCompileEvent.Raise(this, new CompileEventArgs() { Message="Compilation done", Type=CompileEventType.Success });                

                //for thumbnail generation
                if (job.CreateBMP && !job.GeneratePrecompiledHeaders)
                {
                    string pathnoext = Helper.RemoveFileExtension(job.path);

                    if (!mypdfDoc.LoadPdf(pathnoext + ".pdf"))
                    {
                        //GlobalUI.ShowMessageBox("Couldn't load pdf " + pathnoext + ".pdf", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        GlobalUI.AddStatusLine(this, "Couldn't load pdf " + pathnoext + ".pdf", true);
                    }
                    else if (mypdfDoc.IsEmpty())
                    {
                       // MessageBox.Show("Image is empty. Did you fill out the sample code block?" public static MessageBoxResult ShowMessageBox);
                        GlobalUI.AddStatusLine(this, "Image is empty. Did you fill out the sample code block?");
                    }
                    else
                    {
                        //mypdfDoc.SaveBmp(pathnoext + ".bmp", Resolution);
                        mypdfDoc.SaveBmp(pathnoext + ".png", Resolution, true, System.Drawing.Imaging.ImageFormat.Png);
                        _BitmapGenerated.Raise(this, EventArgs.Empty);
                    }
                }
                else if (job.GeneratePrecompiledHeaders == true)
                {   //if the header should have been generated but it was not
                    if (!File.Exists(Helper.GetPrecompiledHeaderPath() + System.IO.Path.GetFileNameWithoutExtension(Helper.GetPrecompiledHeaderFilename()) + ".fmt"))
                    {
                        todo_tex.Clear();
                        _OnCompileEvent.Raise(this, new CompileEventArgs()
                        {
                            Message = "Compilation of pre-compiled header succeded but the pre-compiled header file could not be found." +
                                " It is supposed to be here: " + Helper.GetPrecompiledHeaderPath() + System.IO.Path.GetFileNameWithoutExtension(Helper.GetPrecompiledHeaderFilename()) + ".fmt" +
                                Environment.NewLine + "Compilation of main document stopped. Check settings and read/write permissions!",
                            Type = CompileEventType.Error
                        });
                    }
                    else
                    { 
                        //clear source and temp files of compilation of header                        
                        //note: the .tex file must not be deleted!
                        Helper.DeleteTemporaryFiles(job.path, false);
                    }
                }
            }
            else // ExitCode != 0 => Error
            {
                
                //if generating pre-compiled header failed. it will not work next time.
                //so clear job queue and tell user to fix header code.
                if (job.GeneratePrecompiledHeaders == true)
                {
                    todo_tex.Clear();
                    _OnCompileEvent.Raise(this, new CompileEventArgs() { Message = "Compilation of pre-compiled header failed with exit code " + texProcess.ExitCode + 
                        ". Compilation of main document stopped. Check that all necessary packages are installed and that the pre-compiled header code (in the settings) has no errors!", Type = CompileEventType.Error });
                    _JobNumberChanged.Raise(this, EventArgs.Empty);
                }
                else
                {
                    _OnCompileEvent.Raise(this, new CompileEventArgs() { Message = "Compilation failed with exit code " + texProcess.ExitCode, Type = CompileEventType.Error });
                }

                //_JobFailed.Raise(this, new JobEventArgs( job, OutputParseResult ));                

            }

            _JobDone.Raise(this, new JobEventArgs(job, OutputParseResult, texProcess.ExitCode));
            
            //parse output from pdflatex.
            //myPdflatexOutputParser.parseOutput();
            //This does not work because something texProcess_Exited is called
            //before the complete output was received by texProcess_OutputDataReceived().

            //isRunning = false;
            //SetValue(CompilingPropertyKey, false);
            SetCompiling(false);
 
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
                try
                {
                    using (StreamReader sr = new StreamReader(cMetaFile))
                    {
                        string s = sr.ReadLine();
                        string[] arr = s.Split(new string[] { ",", " ", "pt" }, StringSplitOptions.RemoveEmptyEntries);
                        if (arr.Length == 4)
                        {
                            Point p1 = new Point(Double.Parse(arr[0]) / Consts.ptspertikzunit, Double.Parse(arr[1]) / Consts.ptspertikzunit);
                            Point p2 = new Point(Double.Parse(arr[2]) / Consts.ptspertikzunit, Double.Parse(arr[3]) / Consts.ptspertikzunit);

                            job.BB = new Rect(p1, p2);
                            if (job.BB.Width < 500 && job.BB.Height < 500)
                                job.hasBB = true;
                            else
                                job.hasBB = false;

                        }
                    }
                }
                catch(Exception )
                {
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
            //((MainWindow)Application.Current.Windows[0]).SetStandAloneStatus(ret);

            return ret;
        }

        public static bool ContainsPreviewEnvironment(string code)
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
        public static bool ContainsDoNotInsertPreviewEnvironment(string code)
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

    }


    /// <summary>
    /// This class receives strings with Tikz-Code (see AddJob) and compiles them to BMP images.
    /// </summary>
    public class TikzToBMPFactory : TexCompiler 
    {
        public static TikzToBMPFactory Instance = new TikzToBMPFactory() { Resolution = 100 };

        static TikzToBMPFactory()
        {
            Instance.JobDone += OnJobDone;
            Instance.timeout = CompilerSettings.Instance.Compiler_SnippetTimeout;//todo... has to be updated whenever timeout changes
        }

        public static void OnJobDone(object sender, JobEventArgs e)
        {
            if (e.ExitCode != 0)
            {
                string msg = "Compilation of the Codesnippet-Thumbnail " + e.job.path + " (" + e.job.name + ") failed.\r\nPlease re-check the code.";
                msg += Environment.NewLine + Environment.NewLine + "cmdline: " + e.job.cmdline;
                GlobalUI.AddStatusLine(null, msg, true);
            }
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
            Instance.timeout = CompilerSettings.Instance.Compiler_Timeout;// todo
        }

        public static void GeneratePrecompiledHeaders()
        {
            Instance.AddJob(GetPrecompiledHeaderJob());
        }
    }
}
