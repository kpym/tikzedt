using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FindReplaceNoWPF
{
    public partial class FindReplaceDialog : Form
    {
        FindReplaceMgr Mgr;
        public FindReplaceDialog(FindReplaceMgr Mgr)
        {
            this.Mgr = Mgr;
            InitializeComponent();

            // fill property values
            txtTextToFind.Text = Mgr.TextToFind;
            txtReplaceWith.Text = Mgr.ReplacementText;
            chkMatchCase.Checked = Mgr.CaseSensitive;
            chkRegex.Checked = Mgr.UseRegEx;
            chkSearchUp.Checked = Mgr.SearchUp;
            chkWholeWord.Checked = Mgr.WholeWord;
            chkWildcards.Checked = Mgr.UseWildcards;
        }

        private void radioFind_CheckedChanged(object sender, EventArgs e)
        {
            txtReplaceWith.Visible = lblReplace.Visible = cmdReplace.Visible = cmdReplaceAll.Visible = radioReplace.Checked;
        }

        void UpdateMgrWithFormvalues()
        {
            Mgr.TextToFind = txtTextToFind.Text;
            Mgr.ReplacementText = txtReplaceWith.Text;
            Mgr.CaseSensitive = chkMatchCase.Checked;
            Mgr.UseRegEx = chkRegex.Checked;
            Mgr.SearchUp = chkSearchUp.Checked;
            Mgr.WholeWord = chkWholeWord.Checked;
            Mgr.UseWildcards = chkWildcards.Checked;

        }

        private void cmdFind_Click(object sender, EventArgs e)
        {
            UpdateMgrWithFormvalues();
            Mgr.FindNext();
        }

        private void cmdReplace_Click(object sender, EventArgs e)
        {
            UpdateMgrWithFormvalues();
            Mgr.Replace();
        }

        private void cmdReplaceAll_Click(object sender, EventArgs e)
        {
            UpdateMgrWithFormvalues();
            Mgr.ReplaceAll();
        }

        private void FindReplaceDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        public void ActivateFind()
        { radioFind.Checked = true; }
        public void ActivateReplace()
        { radioReplace.Checked = true; }

        private void FindReplaceDialog_Deactivate(object sender, EventArgs e)
        {
            UpdateMgrWithFormvalues();
        }
    }
}
