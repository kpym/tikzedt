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
        
        public readonly ExportCompileVM TheVM;

        public ExportCompileDialog()
        {
            InitializeComponent();

            DataContext = TheVM = new ExportCompileVM();
            TheVM.RequestClose += (s, e) => Close();
 
        }

        /// <summary>
        /// This is the main method. It shows the dialog and runs the compiler
        /// </summary>
        /// <param name="TexCode"></param>
        /// <param name="OutputFile"></param>
        public static void Export(string TexCode, string OutputFile)
        {
            ExportCompileDialog ecd = new ExportCompileDialog();
            ecd.TheVM.DoCompile(TexCode, OutputFile);

            ecd.Show();
        }


        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TheVM.KillProcess();
        }

        private void cmdExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void txtOutput_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtOutput.ScrollToEnd();
        }

    }
}
