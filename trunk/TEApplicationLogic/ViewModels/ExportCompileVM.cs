using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using TESharedComponents;

namespace TikzEdt.ExportCompiler
{
    public class ExportCompileVM : ViewModels.ViewModelBase
    {

        #region properties

        private string _CloseButtonText = "Abort";
        /// <summary>
        /// The text of the button. 
        /// </summary>
        public string CloseButtonText
        {
            get { return _CloseButtonText; }
            set {
                if (_CloseButtonText != value)
                {
                    _CloseButtonText = value;
                    NotifyPropertyChanged("CloseButtonText");
                }
            }
        }

        private string _StatusText = "";
        /// <summary>
        /// The text to be displayed by the status textbox.
        /// </summary>
        public string StatusText
        {
            get { return _StatusText; }
            set
            {
                if (_StatusText != value)
                {
                    _StatusText = value;
                    NotifyPropertyChanged("StatusText");
                }
            }
        }

        private bool _ProgressBarVisible = true;

        public bool ProgressBarVisible
        {
            get { return _ProgressBarVisible; }
            set { 
                if ( _ProgressBarVisible != value)
                {
                    _ProgressBarVisible = value;
                    NotifyPropertyChanged("ProgressBarVisible");
                }
            }
        }
        private bool _FailedLabelVisible = false;

        public bool FailedLabelVisible
        {
            get { return _FailedLabelVisible; }
            set
            {
                if (_FailedLabelVisible != value)
                {
                    _FailedLabelVisible = value;
                    NotifyPropertyChanged("FailedLabelVisible");
                }
            }
        }

        private bool _SuccessLabelVisible = false;

        public bool SuccessLabelVisible
        {
            get { return _SuccessLabelVisible; }
            set
            {
                if (_SuccessLabelVisible != value)
                {
                    _SuccessLabelVisible = value;
                    NotifyPropertyChanged("SuccessLabelVisible");
                }
            }
        }


        protected Process texProcess = new Process();
        System.Timers.Timer CloseTimer = new System.Timers.Timer();
        int CloseCountDown = 10; // n seconds before closing after compilation complete
        string TempFile; // stores the filename (without extension) of the temporary tex file
        string DesiredOutputFile;
        string WorkingDir; // save the working dir in case it is changed while compiling

        #endregion

        #region events

        public event EventHandler RequestClose;

        #endregion

        public ExportCompileVM()
        {
            // Initialize
            texProcess.EnableRaisingEvents = true;
            //texProcess.StartInfo.Arguments = "-quiet -halt-on-error " + Consts.cTempFile + ".tex";
            texProcess.OutputDataReceived += new DataReceivedEventHandler(texProcess_OutputDataReceived);
            texProcess.StartInfo.RedirectStandardOutput = true;
            texProcess.StartInfo.FileName = CompilerSettings.Instance.Path_htlatex;
            texProcess.StartInfo.CreateNoWindow = true;
            texProcess.StartInfo.UseShellExecute = false;
            texProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            texProcess.Exited += new EventHandler(texProcess_Exited);
            CloseTimer.Elapsed += CloseTimer_Tick;
            CloseTimer.Interval = 1000;
        }

        /// <summary>
        /// Starts the compilation.
        /// </summary>
        /// <param name="TexCode">The raw Tex code, possibly without preamble.</param>
        /// <param name="OutputFile">The desired output file. The extension determines the file type.</param>
        public void DoCompile(string TexCode, string OutputFile)
        {
            DesiredOutputFile = OutputFile;
            WorkingDir = Directory.GetCurrentDirectory();

            

            // add pre- and postamble if file is not standalone... don't use precompiled headers here since we need 
            // to add a \def\pgfsysdriver{pgfsys-tex4ht.def}
            if (!TexCompiler.IsStandalone(TexCode))
            {
                TexCode = CompilerSettings.Instance.Tex_Preamble
                    + Environment.NewLine
                    + "\\begin{document}"
                    + Environment.NewLine
                    + TexCode
                    + Environment.NewLine
                    + CompilerSettings.Instance.Tex_Postamble;
            }

            switch (System.IO.Path.GetExtension(OutputFile).ToLower())
            {
                case ".htm":
                case ".html":
                case ".svg":
                    // inject a \def\pgfsysdriver{pgfsys-tex4ht.def} after the line with \documentclass 
                    TexCode = InsertAfterDocumentClass(TexCode, @"\def\pgfsysdriver{pgfsys-tex4ht.def}");
                    break;
                default:
                    AddStatusLine("Error: unsupported file type: " + System.IO.Path.GetExtension(OutputFile));
                    return;
            }

            // get a temp filename and save the tex file
            TempFile = Consts.cTempExportFile + DateTime.Now.Ticks.ToString();
            try
            {
                File.WriteAllText(TempFile + ".tex", TexCode);
            }
            catch (Exception)
            {
                AddStatusLine("Failed to save temporary tex file to: " + TempFile + ".tex");
                AddStatusLine("Export cancelled");
                return;
            }

            // finally run htlatex...
            texProcess.StartInfo.Arguments = TempFile + ".tex"; // ".tex \"\" \"\" \"\" \"-interaction=nonstopmode \"";
            AddStatusLine("Running htlatex: " + texProcess.StartInfo.FileName + " " + texProcess.StartInfo.Arguments);
            texProcess.Start();
            texProcess.BeginOutputReadLine();
        }

        /// <summary>
        /// Inserts text ToInsert after the line which begins with \documentclass.
        /// If no line starts with documentclass, null is returned.
        /// 
        /// Also comments out \usepackage{preview} and \PreviewEnvironment
        /// This is a bit of a hack...
        /// </summary>
        /// <param name="TexCode"></param>
        /// <param name="ToInsert"></param>
        /// <returns></returns>
        string InsertAfterDocumentClass(string TexCode, string ToInsert)
        {
            StringReader sr = new StringReader(TexCode);
            StringWriter sw = new StringWriter();
            bool found = false;
            string l;
            while (null != (l = sr.ReadLine()))
            {
                // filter out preview-package related stuff (it is a bit of a hack)                
                if ((l.Trim().StartsWith("\\usepackage") && l.Contains("preview"))
                    || (l.Trim().StartsWith("\\PreviewEnvironment")))
                {
                    sw.WriteLine("% " + l);
                }
                else
                    sw.WriteLine(l);

                if (l.Trim().StartsWith("\\documentclass"))
                {
                    sw.WriteLine(ToInsert);
                    found = true;
                }
            }

            // not found-> fail
            return found ? sw.ToString() : null;
        }

        void AddStatusLine(string line)
        {
            StatusText += line + Environment.NewLine;
            //txtOutput.ScrollToEnd();
        }

        void CloseTimer_Tick(object sender, EventArgs e)
        {
            MyBackgroundWorker.Invoke(delegate
            {
                CloseCountDown--;
                if (CloseCountDown == 0)
                {
                    if (RequestClose != null)
                        RequestClose(this, new EventArgs());
                }
                else
                    CloseButtonText = "Close [" + CloseCountDown + "s]";
            });
        }

        void texProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            MyBackgroundWorker.BeginInvoke(new Action(delegate()
            {
                AddStatusLine(e.Data); //txtOutput.Text += e.Data + Environment.NewLine;
            }));
        }


        void texProcess_Exited(object sender, EventArgs e)
        {
            MyBackgroundWorker.Invoke(new Action(delegate()
            {
                CloseButtonText = "Close";
                ProgressBarVisible = false;
                if (texProcess.ExitCode == 0)
                {
                    AddStatusLine("htlatex returned with exit code 0");

                    bool success1 = CopyOutputFiles();
                    bool success2 = CleanUp();

                    // if successful, start autoclose timer
                    if (success1)// && success2)
                    {
                        SuccessLabelVisible = true;
                        CloseButtonText = "Close [" + CloseCountDown + "s]";
                        CloseTimer.Start();
                    }
                    else
                    {
                        //lblFailed.Text = "Error: export failed";
                        CloseButtonText = "Close";
                        FailedLabelVisible = true;
                    }
                }
                else
                {
                    AddStatusLine("Error: compilation failed");
                    CloseButtonText = "Close";
                    FailedLabelVisible = true;
                    CleanUp();
                }
            }));
        }

        /// <summary>
        /// Deletes all temporary files created 
        /// </summary>
        bool CleanUp()
        {
            bool success = true;
            AddStatusLine("Deleting temporary files...");
            foreach (string file in Directory.GetFiles(WorkingDir, TempFile + "*"))
            {
                try
                {
                    File.Delete(file);
                }
                catch (Exception)
                {
                    AddStatusLine("Error: Could not delete file" + System.IO.Path.GetFileName(file) + ".");
                    success = false;
                }
            }
            AddStatusLine("Done");
            return success;
        }

        /// <summary>
        /// After successful compilation this method copies the output files produced to the desired locations.
        /// Note: The html contains references to the temporary files. 
        /// So some files used by the html file have strange names.
        /// </summary>
        /// <returns>true if output files successfully copied, false otherwise</returns>
        bool CopyOutputFiles()
        {
            AddStatusLine("Copying output files...");
            bool success = false;
            try
            {
                string OutputDir = System.IO.Path.GetDirectoryName(DesiredOutputFile);
                string ext = System.IO.Path.GetExtension(DesiredOutputFile).ToLower();
                string aux_filename = System.IO.Path.GetFileNameWithoutExtension(DesiredOutputFile) + "_aux";
                foreach (string file in Directory.GetFiles(WorkingDir, TempFile + "*.*"))
                {
                    string fext = System.IO.Path.GetExtension(file).ToLower();

                    switch (ext)
                    {
                        case ".html":
                        case ".htm":
                            if (fext == ".htm" || fext == ".html")
                            {
                                // replace references to temp files
                                string htmltext = File.ReadAllText(file);
                                htmltext = htmltext.Replace(TempFile, aux_filename);
                                File.WriteAllText(DesiredOutputFile, htmltext);
                                success = true;
                            }
                            else if (fext == ".svg" || fext == ".css")
                            {
                                string fname = System.IO.Path.GetFileName(file);
                                fname = fname.Replace(TempFile, aux_filename);
                                File.Copy(file, System.IO.Path.Combine(OutputDir, fname), true);
                            }
                            break;

                        case ".svg":
                            if (fext == ".svg")
                            {
                                File.Copy(file, DesiredOutputFile, true);
                                success = true;
                            }
                            break;
                    }
                }

                if (!success)
                    AddStatusLine("Error: It seems htlatex did not produce the right output file... is there an error in the tex code?");
            }
            catch (Exception ex)
            {
                AddStatusLine("Error: Could not copy output files.");
                AddStatusLine(ex.Message);
                success = false;
            }

            return success;
        }


        /// <summary>
        /// Ends the TeX process if it hasn't exited yet.
        /// </summary>
        public void KillProcess()
        {
            try
            {
                if (!texProcess.HasExited)
                    texProcess.Kill();
            }
            catch (Exception)
            {
            }

        }
    }
}
