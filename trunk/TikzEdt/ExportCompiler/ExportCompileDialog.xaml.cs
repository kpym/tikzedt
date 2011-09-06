using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Windows.Threading;
using System.IO;

namespace TikzEdt.ExportCompiler
{
    /// <summary>
    /// Interaction logic for ExportCompileDialog.xaml
    /// </summary>
    public partial class ExportCompileDialog : Window
    {
        protected Process texProcess = new Process();
        DispatcherTimer CloseTimer = new DispatcherTimer();
        int CloseCountDown = 10; // n seconds before closing after compilation complete
        string TempFile; // stores the filename (without extension) of the temporary tex file
        string DesiredOutputFile;
        string WorkingDir; // save the working dir in case it is changed while compiling

        public ExportCompileDialog()
        {
            InitializeComponent();

            // Initialize
            texProcess.EnableRaisingEvents = true;
            //texProcess.StartInfo.Arguments = "-quiet -halt-on-error " + Consts.cTempFile + ".tex";
            texProcess.OutputDataReceived += new DataReceivedEventHandler(texProcess_OutputDataReceived);
            texProcess.StartInfo.RedirectStandardOutput = true;
            texProcess.StartInfo.FileName = Properties.Settings.Default.Path_htlatex;
            texProcess.StartInfo.CreateNoWindow = true;
            texProcess.StartInfo.UseShellExecute = false;
            texProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            texProcess.Exited += new EventHandler(texProcess_Exited);
            CloseTimer.Tick += new EventHandler(CloseTimer_Tick);
            CloseTimer.Interval = new TimeSpan(0,0,1);
            
        }

        /// <summary>
        /// This is the main method. It shows the dialog and runs the compiler
        /// </summary>
        /// <param name="TexCode"></param>
        /// <param name="OutputFile"></param>
        public static void Export(string TexCode, string OutputFile)
        {
            ExportCompileDialog ecd = new ExportCompileDialog();
            ecd.DoCompile(TexCode, OutputFile);
        }

        void DoCompile(string TexCode, string OutputFile)
        {
            DesiredOutputFile = OutputFile;
            WorkingDir = Directory.GetCurrentDirectory();

            this.Show();

            // add pre- and postamble if file is not standalone... don't use precompiled headers here since we need 
            // to add a \def\pgfsysdriver{pgfsys-tex4ht.def}
            if (!TexCompiler.IsStandalone(TexCode))
            {
                TexCode = Properties.Settings.Default.Tex_Preamble 
                    + Environment.NewLine 
                    + "\\begin{document}" 
                    + Environment.NewLine 
                    + TexCode
                    + Environment.NewLine 
                    + Properties.Settings.Default.Tex_Postamble;
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
            } catch (Exception)
            {
                AddStatusLine("Failed to save temporary tex file to: "+TempFile+".tex");
                AddStatusLine("Export cancelled");
                return;
            }

            // finally run htlatex...
            texProcess.StartInfo.Arguments = TempFile + ".tex"; // ".tex \"\" \"\" \"\" \"-interaction=nonstopmode \"";
            AddStatusLine("Running htlatex: "+ texProcess.StartInfo.FileName +" " + texProcess.StartInfo.Arguments);
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
            while (null != (l = sr.ReadLine() ))
            {
                // filter out preview-package related stuff (it is a bit of a hack)                
                if ((l.Trim().StartsWith("\\usepackage") && l.Contains("preview"))
                    || (l.Trim().StartsWith("\\PreviewEnvironment")) )
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
            txtOutput.Text += line + Environment.NewLine;
            txtOutput.ScrollToEnd();
        }

        void texProcess_Exited(object sender, EventArgs e)
        {
            Dispatcher.Invoke(new Action(delegate()
            {
                cmdExit.Content = "Close";
                pbProgress.Visibility = Visibility.Collapsed;
                if (texProcess.ExitCode == 0)
                {
                    AddStatusLine("htlatex returned with exit code 0");

                    bool success1 = CopyOutputFiles();
                    bool success2 = CleanUp();

                    // if successful, start autoclose timer
                    if (success1)// && success2)
                    {
                        lblSuccess.Visibility = Visibility.Visible;
                        cmdExit.Content = "Close [" + CloseCountDown + "s]";
                        CloseTimer.Start();
                    }

                    if (!success1)
                    {
                        lblFailed.Text = "Error: export failed";
                        lblFailed.Visibility = Visibility.Visible;
                    }
                }
                else
                {
                    AddStatusLine("Error: compilation failed");
                    lblFailed.Visibility = Visibility.Visible;
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
                    AddStatusLine("Error: Could not delete file" + System.IO.Path.GetFileName(file) +  ".");
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
                string aux_filename = System.IO.Path.GetFileNameWithoutExtension(DesiredOutputFile)+"_aux";
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

        void CloseTimer_Tick(object sender, EventArgs e)
        {
            CloseCountDown--;
            if (CloseCountDown == 0)
                Close();
            else
                cmdExit.Content = "Close [" + CloseCountDown + "s]";
        }

        void texProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Dispatcher.BeginInvoke(new Action(delegate()
            {
                txtOutput.Text += e.Data + Environment.NewLine;
            }));
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void cmdExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
