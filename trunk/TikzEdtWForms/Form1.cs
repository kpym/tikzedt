using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TikzEdt.ViewModels;
using TikzEdt;

namespace TikzEdtWForms
{
    public partial class Form1 : Form
    {
        MainWindowVM TheVM = new MainWindowVM(TheCompiler.Instance);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //txtCode.SetHighlighting("C#");
            //ICSharpCode.TextEditor.Document.IDocument doc;
            //doc.
        }
    }
}
