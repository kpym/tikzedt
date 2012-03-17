using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace XSHDEditor
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static string XSHDFile {get; set;} 

        protected override void OnStartup(StartupEventArgs e)
        {
            XSHDFile = e.Args.FirstOrDefault();

            // defer other startup processing to base class
            base.OnStartup(e);
        }
    }
}
