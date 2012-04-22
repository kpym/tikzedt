using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TikzEdt.DynPreamble;

namespace TikzEdtWForms
{
    public partial class DynPreambleDialog : Form
    {
        private DynPreambleDialog()
        {
            InitializeComponent();

            txtCode.SetHighlighting("Tikz");
        }

        public static bool ShowDynPreambleDialog(IWin32Window owner, DynPreambleElementVM vm)
        {
            var dd = new DynPreambleDialog();
            dd.txtCode.Text = vm.Code;
            dd.txtName.Text = vm.Name;

            var res = dd.ShowDialog(owner);

            if (res == DialogResult.OK)
            {
                vm.Code = dd.txtCode.Text;
                vm.Name = dd.txtName.Text;
            }

            dd.Dispose();
            return (res == DialogResult.OK);
        }
    }
}
