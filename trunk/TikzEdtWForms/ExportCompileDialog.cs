using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TikzEdt.ExportCompiler;
using TikzEdt;

namespace TikzEdtWForms
{
    public partial class ExportCompileDialog : Form
    {

        readonly ExportCompileVM TheVM;

        public ExportCompileDialog()
        {
            InitializeComponent();

            // set up bindings
            TheVM = new ExportCompileVM();
            BindingFactory.CreateBinding(TheVM, "CloseButtonText", vm => cmdCancel.Text = vm.CloseButtonText, null);
            BindingFactory.CreateBinding(TheVM, "StatusText", vm => 
                        { 
                            txtStatus.Text = vm.StatusText; 
                            txtStatus.SelectionStart = txtStatus.Text.Length; 
                            txtStatus.ScrollToCaret(); 
                        }, null);
            BindingFactory.CreateBinding(TheVM, "SuccessLabelVisible", vm => lblSuccess.Visible = vm.SuccessLabelVisible, null);
            BindingFactory.CreateBinding(TheVM, "FailedLabelVisible", vm => lblFailed.Visible = vm.FailedLabelVisible, null);
            BindingFactory.CreateBinding(TheVM, "ProgressBarVisible", vm => progressBar1.Visible = vm.ProgressBarVisible, null);

            TheVM.RequestClose += (s,e) => Close();

            FormClosing += (s,e) => TheVM.KillProcess();
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
    }
}
