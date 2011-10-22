using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Windows.Interop;
using System.IO;

namespace TikzEdt
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // define application exception handler
            Application.Current.DispatcherUnhandledException += new
                System.Windows.Threading.DispatcherUnhandledExceptionEventHandler(
                  AppDispatcherUnhandledException);

            // This shouldn't be necessary... but it is. On my machine there are rendering issues....
            RenderOptions.ProcessRenderMode = RenderMode.SoftwareOnly;

            // set application data path and settings path          
            if (e.Args.Contains("-p") || e.Args.Contains("--portable"))
            {
                Helper.SetAppdataPath(Helper.AppdataPathOptions.ExeDir);
            }
            else
                Helper.SetAppdataPath(Helper.AppdataPathOptions.AppData);           

            // load/store settings at a sensible location (not the standard cryptic one)
            RewireSettingsProvider(TikzEdt.Properties.Settings.Default);

            // tie settings to Viewmodels
            CompilerSettings.Instance = new PropertiesCompilerSettings();
            TikzEdt.Parser.ParserSettings.Instance = new PropertiesParserSettings();

            // check that necessary config files are in place
            string missingfile = "";
            if (false == FirstRunPreparations(out missingfile))
                MessageBox.Show("File " + missingfile + " not found. Please re-install program or provide file manually.", "File missing", MessageBoxButton.OK, 
                    MessageBoxImage.Error);

            // defer other startup processing to base class
            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
        }

        private  void RewireSettingsProvider(ApplicationSettingsBase settings)
        {
            var portableSettingsProvider = 
                new TESettingsProvider(Path.Combine( Helper.GetAppdataPath(),  "TikzEdt.settings"));
            settings.Providers.Add(portableSettingsProvider);
            foreach (System.Configuration.SettingsProperty prop in settings.Properties)
                prop.Provider = portableSettingsProvider;
            settings.Reload();
        }


        /// <summary>
        /// Checks if all config files are available and copies them
        /// from the application direction to UserAppDataPath.
        /// </summary>
        /// <param name="missing"></param>
        /// <returns></returns>
        bool FirstRunPreparations(out string missing)
        {
            bool success = true;
            missing = "";
            //these files need to be in the appdata path.
            List<String> InstallFiles = new List<string>();
            InstallFiles.Add(Consts.cCompletionsFile);
            InstallFiles.Add(Consts.cSyntaxFile);
            InstallFiles.Add(Consts.cSnippetsFile);

            foreach (string file in InstallFiles)
            {
                //check if file is in Helper.GetSettingsPath() if not try to copy it from exe dir.
                if (!File.Exists(Helper.GetSettingsPath() + file))
                {
                    //if not there check if it is in exe dir
                    if (!File.Exists(System.AppDomain.CurrentDomain.BaseDirectory + "\\Editor\\" + file))
                    {
                        success = false;
                        missing = file;
                        break;
                    }
                    else
                    {
                        Directory.CreateDirectory(Helper.GetSettingsPath());
                        File.Copy(System.AppDomain.CurrentDomain.BaseDirectory + "\\Editor\\" + file, Helper.GetSettingsPath() + file);
                        //let global exception handler show exception to user.
                    }
                }
            }
            return success;
        }

        void AppDispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            //do whatever you need to do with the exception
            //e.Exception
            if (System.Diagnostics.Debugger.IsAttached)
            {
                // in debug mode, let the debugger handle the exception
            }
            else
            {
                System.Windows.Forms.DialogResult result = System.Windows.Forms.DialogResult.Cancel;
                try
                {
                    result = this.ShowThreadExceptionDialog(e.Exception);
                }
                catch
                {
                    try
                    {
                        MessageBox.Show("Fatal Error", "Fatal Error", MessageBoxButton.OK, MessageBoxImage.Stop);
                    }
                    finally
                    {
                        System.Environment.Exit(1);
                        Application.Current.MainWindow.Close();
                    }
                }

                // Exits the program when the user clicks Abort.
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    System.Environment.Exit(1);
                }
                else if (result == System.Windows.Forms.DialogResult.No)
                {
                    Application.Current.MainWindow.Close();
                }

                e.Handled = true;
            }
        }

        // Creates the error message, displays and logs it.
        private System.Windows.Forms.DialogResult ShowThreadExceptionDialog(Exception e)
        {
            string logfilepath = System.IO.Directory.GetCurrentDirectory() + "\\tikzedt_exception.log";

            string firstline = "An error occurred. If it can be reproduced please inform the author of this program providing log file "+logfilepath+"\n\n";
            string errorMsg = e.Message;
            Exception innerexception = e.InnerException;
            while (innerexception != null)
            {
                errorMsg += Environment.NewLine + "caused by:";
                errorMsg += Environment.NewLine + innerexception.Message;
                innerexception = innerexception.InnerException;
            }
            if (errorMsg.Contains("Could not load file or assembly"))
                firstline = "An error occurred. Please try to reinstall this program or provided all required libary files." + Environment.NewLine + Environment.NewLine;
            errorMsg += Environment.NewLine + Environment.NewLine + "Stack Trace:\n" + e.StackTrace;
            errorMsg += e.Message + Environment.NewLine + Environment.NewLine + "Terminate application immediately?";
            errorMsg += Environment.NewLine + "Click 'no' if you want to try close the main window gracefully, 'cancel' to ignore this exception.";

            errorMsg = firstline + errorMsg;

            System.IO.File.AppendAllText(logfilepath, "========== TIKZEDT UNCAUGHT EXCEPTION ======" + Environment.NewLine);
            System.IO.File.AppendAllText(logfilepath, DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + Environment.NewLine);
            System.IO.File.AppendAllText(logfilepath, e.Message + Environment.NewLine+ Environment.NewLine +"Stack Trace:" + Environment.NewLine + e.StackTrace + Environment.NewLine);
            System.IO.File.AppendAllText(logfilepath, "===== END: TIKZEDT UNCAUGHT EXCEPTION ======" + Environment.NewLine);

            return System.Windows.Forms.MessageBox.Show(errorMsg, "Application Error", System.Windows.Forms.MessageBoxButtons.YesNoCancel, System.Windows.Forms.MessageBoxIcon.Stop);
        }
    }


}
