using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

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

            

            // defer other startup processing to base class
            base.OnStartup(e);
        }
        void AppDispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            //do whatever you need to do with the exception
            //e.Exception

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

        // Creates the error message, displays and logs it.
        private System.Windows.Forms.DialogResult ShowThreadExceptionDialog(Exception e)
        {
            string logfilepath = System.IO.Directory.GetCurrentDirectory() + "\\tikzedt_exception.log";

            string errorMsg = "An error occurred. If it can be reproduced please inform the author of this program providing log file "+logfilepath+"\n\n";
            errorMsg = errorMsg + e.Message + "\n\nStack Trace:\n" + e.StackTrace;
            errorMsg = errorMsg + e.Message + "\n\nTerminate application immediately?";

            System.IO.File.AppendAllText(logfilepath, "========== TIKZEDT UNCAUGHT EXCEPTION ======" + Environment.NewLine);
            System.IO.File.AppendAllText(logfilepath, DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + Environment.NewLine);
            System.IO.File.AppendAllText(logfilepath, e.Message + Environment.NewLine+ Environment.NewLine +"Stack Trace:" + Environment.NewLine + e.StackTrace + Environment.NewLine);
            System.IO.File.AppendAllText(logfilepath, "===== END: TIKZEDT UNCAUGHT EXCEPTION ======" + Environment.NewLine);

            return System.Windows.Forms.MessageBox.Show(errorMsg, "Application Error", System.Windows.Forms.MessageBoxButtons.YesNoCancel, System.Windows.Forms.MessageBoxIcon.Stop);
        }
    }


}
