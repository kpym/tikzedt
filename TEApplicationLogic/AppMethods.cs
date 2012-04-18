using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TikzEdt
{
    public static class AppMethods
    {
        /// <summary>
        /// Represents the file to load on startup
        /// </summary>
        public static string StartupFile = null;


        /// <summary>
        /// Checks if all config files are available and copies them
        /// from the application direction to UserAppDataPath.
        /// </summary>
        /// <param name="missing"></param>
        /// <returns></returns>
        public static bool FirstRunPreparations(out string missing)
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
                string SettingsDirFile = Path.Combine(Helper.GetSettingsPath(), file);
                if (!File.Exists(SettingsDirFile))
                {
                    //if not there check if it is in exe dir
                    string ExeDirFile = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Editor\\" + file);
                    if (!File.Exists(ExeDirFile))
                    {
                        success = false;
                        missing = file;
                        break;
                    }
                    else
                    {
                        Directory.CreateDirectory(Helper.GetSettingsPath());
                        File.Copy(ExeDirFile, SettingsDirFile);
                        //let global exception handler show exception to user.
                    }
                }
            }
            return success;
        }

        // Creates the error message, displays and logs it.
        public static System.Windows.Forms.DialogResult ShowThreadExceptionDialog(Exception e)
        {
            string logfilepath = System.IO.Path.Combine(Helper.GetAppdataPath(), "tikzedt_exception.log");

            string firstline = "An error occurred. If it can be reproduced please inform the author of this program providing log file " + logfilepath + "\n\n";
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

            try
            {
                System.IO.File.AppendAllText(logfilepath, "========== TIKZEDT UNCAUGHT EXCEPTION ======" + Environment.NewLine);
                System.IO.File.AppendAllText(logfilepath, DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + Environment.NewLine);
                System.IO.File.AppendAllText(logfilepath, e.Message + Environment.NewLine + Environment.NewLine + "Stack Trace:" + Environment.NewLine + e.StackTrace + Environment.NewLine);
                System.IO.File.AppendAllText(logfilepath, "===== END: TIKZEDT UNCAUGHT EXCEPTION ======" + Environment.NewLine);
            }
            catch (Exception) { }

            return System.Windows.Forms.MessageBox.Show(errorMsg, "Application Error", System.Windows.Forms.MessageBoxButtons.YesNoCancel, System.Windows.Forms.MessageBoxIcon.Stop);
        }

    }
}
