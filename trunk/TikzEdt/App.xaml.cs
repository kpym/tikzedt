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
        /// <summary>
        /// Represents the file to load on startup
        /// </summary>
        public static string StartupFile = null;

        protected override void OnStartup(StartupEventArgs e)
        {
            StartupFile = e.Args.FirstOrDefault(str => !str.StartsWith("-"));
            AppMethods.StartupFile = StartupFile;

            // define application exception handler
            Application.Current.DispatcherUnhandledException += new
                System.Windows.Threading.DispatcherUnhandledExceptionEventHandler(
                  AppDispatcherUnhandledException);

            // This shouldn't be necessary... but it seems to be. On my machine there were rendering issues with hardware mode....
            if (!e.Args.Contains("-h"))
                RenderOptions.ProcessRenderMode = RenderMode.SoftwareOnly;            

            // Set Global UI service
            GlobalUI.UI = new GlobalUIWPF();

            // set application data path and settings path          
            if (e.Args.Contains("-p") || e.Args.Contains("--portable"))
            {
                Helper.SetAppdataPath(Helper.AppdataPathOptions.ExeDir);
            }
            else
                Helper.SetAppdataPath(Helper.AppdataPathOptions.AppData);           

            // load/store settings at a sensible location (not the standard cryptic one)
            RewireSettingsProvider(TikzEdt.Properties.Settings.Default);

            // tie settings to Viewmodels (TODO... maybe change to std dependency injection pattern)
            CompilerSettings.Instance = new PropertiesCompilerSettings();
            TikzEdt.Parser.ParserSettings.Instance = new PropertiesParserSettings();

            // check that necessary config files are in place
            string missingfile = "";
            if (false == AppMethods.FirstRunPreparations(out missingfile))
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
                if (e == null || e.Exception == null)
                    return;

                System.Windows.Forms.DialogResult result = System.Windows.Forms.DialogResult.Cancel;
                try
                {
                    result = AppMethods.ShowThreadExceptionDialog(e.Exception);
                }
                catch
                {
                    try
                    {
                        MessageBox.Show("An error occurred in TikzEdt. Sorry for the inconvenience. Please save and restart TikzEdt."+Environment.NewLine +
                            (e.Exception != null? e.Exception.Message : ""), "Fatal Error", MessageBoxButton.OK, MessageBoxImage.Stop);
                    }
                    catch (Exception)
                    { }
                    finally
                    {
                        //System.Environment.Exit(1);
                        //Application.Current.MainWindow.Close();
                    }
                }

                try
                {
                    // Exits the program when the user clicks Abort.
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        System.Environment.Exit(1);
                    }
                    else if (result == System.Windows.Forms.DialogResult.No)
                    {
                        Application.Current.MainWindow.Close();
                    }

                }
                catch (Exception)
                { }

                e.Handled = true;
            }            
        }

    }


}
