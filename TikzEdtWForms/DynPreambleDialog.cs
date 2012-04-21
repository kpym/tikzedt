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
    public partial class DynPreambleDialog : Form
    {
        public DynPreambleDialog()
        {
            InitializeComponent();

            txtCode.SetHighlighting("Tikz");
        }
    }
}
