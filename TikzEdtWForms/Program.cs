using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TikzEdt;

namespace TikzEdtWForms
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string[] Args = Environment.GetCommandLineArgs();

            GlobalUI.UI = new GlobalUIWinForms();

            // set application data path and settings path          
            if (true) //(Args.Contains("-p") || Args.Contains("--portable"))
            {
                Helper.SetAppdataPath(Helper.AppdataPathOptions.ExeDir);
            }
            else
                Helper.SetAppdataPath(Helper.AppdataPathOptions.AppData);

            // load/store settings at a sensible location (not the standard cryptic one)
            //RewireSettingsProvider(TikzEdt.Properties.Settings.Default);

            // tie settings to Viewmodels (TODO... maybe change to std dependency injection pattern)
            //CompilerSettings.Instance = new PropertiesCompilerSettings();
            //TikzEdt.Parser.ParserSettings.Instance = new PropertiesParserSettings();

            // check that necessary config files are in place
            string missingfile = "";
            if (false == AppMethods.FirstRunPreparations(out missingfile))
                MessageBox.Show("File " + missingfile + " not found. Please re-install program or provide file manually.", "File missing", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


    }
}
