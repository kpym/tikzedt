using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TikzEdtWForms
{
    public partial class ZoomCtrl : UserControl
    {
        public int Value
        {
            get
            {
                return tb.Value;
            }
            set
            {
                tb.Value = Math.Min(Math.Max(value, tb.Minimum), tb.Maximum) ;
            }
        }

        public event EventHandler ValueChanged;

        public ZoomCtrl()
        {
            InitializeComponent();
        }

        private void cmdOut_Click(object sender, EventArgs e)
        {
            Value -= tb.LargeChange;
        }

        private void cmdIn_Click(object sender, EventArgs e)
        {
            Value += tb.LargeChange;
        }

        private void tb_ValueChanged(object sender, EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(this, e);
        }

    }
}
