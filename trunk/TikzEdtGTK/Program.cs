using System;
using System.Collections.Generic;
using System.Linq;
using Gtk;

namespace TikzEdtGTK
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.Init(); //("test", ref args);
            Window myWin = new MainWindow();

            Application.Run();

           /* Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); */
        }
    }
}
