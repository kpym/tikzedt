using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TikzEdt;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace TikzEdtWForms
{
    public class GlobalUIWinForms : GlobalUIBase, IGlobalUI
    {
        /// <summary>
        ///  It is mandatory that this is set to the main window before using GlobalUI.
        /// </summary>
        public Form MainForm = null;

        SaveFileDialog sfd = new SaveFileDialog() { OverwritePrompt = true, ValidateNames = true, AddExtension = true };
        OpenFileDialog ofd = new OpenFileDialog() { CheckFileExists = true, CheckPathExists = true };

        public DialogResult ShowMessageBox(string Text, string Caption, MessageBoxButtons Button, MessageBoxIcon Icon)
        {
            return MessageBox.Show(MainForm, Text, Caption, Button, Icon);
        }

        public bool? ShowOpenFileDialog(out string FileName, string Filter = Consts.StdFileDialogFilter)
        {
            ofd.InitialDirectory = Directory.GetCurrentDirectory();
            ofd.Filter = Filter;
            bool? ret = ofd.ShowDialog(MainForm) == DialogResult.OK;
            FileName = ofd.FileName;
            return ret;
        }

        public bool? ShowSaveFileDialog(out string FileName, string InitFilename, string Filter = Consts.StdFileDialogFilter)
        {
            sfd.InitialDirectory = Directory.GetCurrentDirectory();
            sfd.FileName = InitFilename;
            sfd.Filter = Filter;
            bool? ret = sfd.ShowDialog(MainForm) == DialogResult.OK;
            FileName = sfd.FileName;
            return ret;
        }

        public DialogResult ShowInputDialog(string Title, string Message, out string Text)
        {
            return InputDialog.ShowInputDialog(MainForm, Title, Message, out Text);
            //return (Text == null ? DialogResult.Cancel : DialogResult.OK);
        }

        public void InvokeInUIThread(Action a)
        {
            while (!MainForm.IsHandleCreated)
                Thread.Sleep(50);
            MainForm.Invoke(a);
        }

        public void BeginInvokeInUIThread(Action a)
        {
            while (!MainForm.IsHandleCreated)
                Thread.Sleep(50);
            MainForm.BeginInvoke(a);
        }

        public GlobalUIWinForms()
        {
            //this.MainForm = MainForm;
        }

    }
}
