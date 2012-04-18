using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TikzEdtWForms
{
    public partial class InputDialog : Form
    {
        private InputDialog()
        {
            InitializeComponent();
        }

        public static DialogResult ShowInputDialog(Form Owner, string Title, string Message, out string Text)
        {
            InputDialog id = new InputDialog();
            id.Text = Title;
            id.lblText.Text = Message;
            var ret = id.ShowDialog(Owner);
            Text = id.txtText.Text;
            id.Dispose();
            return ret;
        }
    }
}
