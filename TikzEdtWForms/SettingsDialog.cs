using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TikzEdt;

namespace TikzEdtWForms
{
    public partial class SettingsDialog : Form
    {
        bool Dirty 
        {
            get
            {
                var S = Properties.Settings.Default;
                return txtExtViewer.Text != S.Path_externalviewer ||
                txtHtLatex.Text != S.Path_htlatex ||
                txtPdfLatex.Text != S.Path_pdflatex ||
                txtPrecompArgs.Text != S.PrecompiledHeaderCompileCommand ||
                txtPrepended.Text != S.Tex_Preamble ||
                numCoordDec.Value != S.RoundToDecimals ||
                cmdFont.Font != S.Editor_Font ||
                numMarginBB.Value != (decimal)S.BB_Margin ||
                numTimeoutCompile.Value != S.Compiler_Timeout ||
                numTimeOutSnippetCompile.Value != S.Compiler_SnippetTimeout ||
                chkBeginCompletion.Checked != S.Editor_CompleteBegins ||
                chkCodeCompletion.Checked != S.Editor_CodeCompletion ||
                chkShowLineNr.Checked != S.Editor_ShowLineNumbers ||
                cmdColorNode.BackColor != S.Overlay_CoordColor ||
                cmdColorScope.BackColor != S.Overlay_ScopeColor ||
                cmdColorSNode.BackColor != S.Overlay_CoordSelColor ||
                cmdColorSScope.BackColor != S.Overlay_ScopeSelColor;

            }
            
        }

        public SettingsDialog()
        {
            InitializeComponent();

            // fill everything with settings
            var S = Properties.Settings.Default;
            txtExtViewer.Text = S.Path_externalviewer;
            txtHtLatex.Text = S.Path_htlatex;
            txtPdfLatex.Text = S.Path_pdflatex;
            txtPrecompArgs.Text = S.PrecompiledHeaderCompileCommand;
            txtPrepended.Text = S.Tex_Preamble;

            numCoordDec.Value = S.RoundToDecimals;
            numMarginBB.Value = (decimal)S.BB_Margin;
            numTimeoutCompile.Value = S.Compiler_Timeout;
            numTimeOutSnippetCompile.Value = S.Compiler_SnippetTimeout;

            chkBeginCompletion.Checked = S.Editor_CompleteBegins;
            chkCodeCompletion.Checked = S.Editor_CodeCompletion;
            chkShowLineNr.Checked = S.Editor_ShowLineNumbers;
            
            cmdColorNode.BackColor = S.Overlay_CoordColor;
            cmdColorScope.BackColor = S.Overlay_ScopeColor;
            cmdColorSNode.BackColor = S.Overlay_CoordSelColor;
            cmdColorSScope.BackColor = S.Overlay_ScopeSelColor;

            cmdFont.Font = S.Editor_Font;

        }

        public void Save()
        {
            // read out settings
            var S = Properties.Settings.Default;

            S.Path_externalviewer = txtExtViewer.Text;
            S.Path_htlatex = txtHtLatex.Text;
            S.Path_pdflatex = txtPdfLatex.Text;
            S.PrecompiledHeaderCompileCommand = txtPrecompArgs.Text;
            S.Tex_Preamble = txtPrepended.Text;

            S.RoundToDecimals = (uint) Convert.ToInt32(numCoordDec.Value);
            S.Editor_Font = cmdFont.Font;
            S.BB_Margin = (double)numMarginBB.Value;
            S.Compiler_Timeout = Convert.ToInt32(numTimeoutCompile.Value);
            S.Compiler_SnippetTimeout = Convert.ToInt32(numTimeOutSnippetCompile.Value);

            S.Editor_CompleteBegins = chkBeginCompletion.Checked ;
            S.Editor_CodeCompletion = chkCodeCompletion.Checked;
            S.Editor_ShowLineNumbers = chkShowLineNr.Checked;

            S.Overlay_CoordColor = cmdColorNode.BackColor;
            S.Overlay_ScopeColor = cmdColorScope.BackColor;
            S.Overlay_CoordSelColor = cmdColorSNode.BackColor;
            S.Overlay_ScopeSelColor = cmdColorSScope.BackColor;

            S.Save();

        }

        private void cmdColorNode_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b == null) return;
            colorDialog1.Color = b.BackColor;

            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                b.BackColor = colorDialog1.Color;

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            Save();
            Close();
        }

        private void SettingsDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Dirty)
            {
                if (GlobalUI.UI.ShowMessageBox("Do you want to exit without saving and loose the changes?", "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.Yes)
                    e.Cancel = true;
            }
        }

        private void cmdFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = cmdFont.Font;
            if (fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                cmdFont.Font = fontDialog1.Font;
        }



    }
}
