using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace TikzEdt
{
    /// <summary>
    /// The purpose of this interface is to channel the (limited) Viewmodel user interaction,
    /// so that the viewmodel can be tested in unit tests.
    /// </summary>
    public interface IGlobalUI
    {
        DialogResult ShowMessageBox(string Text, string Caption, MessageBoxButtons Button, MessageBoxIcon Icon);
        bool? ShowOpenFileDialog(out string FileName, string Filter = Consts.StdFileDialogFilter);
        bool? ShowSaveFileDialog(out string FileName, string InitFilename, string Filter = Consts.StdFileDialogFilter);
        void AddStatusLine(object sender, string line, bool error = false);
        DialogResult ShowInputDialog(string Title, string Message, out string Text);
        void RaiseRecentFileEvent(object sender, string file, bool insert);
        void ShowExportCompileDialog(object sender, string code, string file);

        void InvokeInUIThread(Action a);
        void BeginInvokeInUIThread(Action a);

        event EventHandler<RecentFileEventData> OnRecentFileEvent;
        event EventHandler<GlobalStatusEventData> OnGlobalStatus;
        event EventHandler<ExportCompileEventData> OnExportCompile;
    }
        public class RecentFileEventData : EventArgs
        {
            public string FileName;
            public bool IsInsert; // if false it means the file should be removed
        }
        
        public class GlobalStatusEventData : EventArgs
        {
            public string StatusLine;
            public bool IsError;
        }
        
        public class ExportCompileEventData : EventArgs
        {
            public string Code;
            public string File;
        }


    /// <summary>
    /// The purpose of this class is to channel the (limited) Viewmodel user interaction,
    /// so that the viewmodel can be tested in unit tests.
    /// 
    /// Also acts as mediator with the main window
    /// </summary>
    public static class GlobalUI
    {
        /// <summary>
        /// The global UI handler. Must be filled on application startup. 
        /// </summary>
        public static IGlobalUI UI;

    }

    /// <summary>
    /// The mediator part of GlobalUI.
    /// </summary>
    public class GlobalUIBase
    {
        # region Events (mediator part)
        public event EventHandler<RecentFileEventData> OnRecentFileEvent;
        public event EventHandler<GlobalStatusEventData> OnGlobalStatus;
        public event EventHandler<ExportCompileEventData> OnExportCompile;


        public void AddStatusLine(object sender, string line, bool error = false)
        {
            if (OnGlobalStatus != null)
                OnGlobalStatus(sender, new GlobalStatusEventData() { StatusLine = line, IsError = error });
        }

        public void RaiseRecentFileEvent(object sender, string file, bool insert)
        {
            if (OnRecentFileEvent != null)
                OnRecentFileEvent(sender, new RecentFileEventData() { FileName = file, IsInsert = insert });
        }

        public void ShowExportCompileDialog(object sender, string code, string file)
        {
            if (OnExportCompile != null)
                OnExportCompile(sender, new ExportCompileEventData() { File = file, Code = code });
        }
        #endregion
    }

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
            return MessageBox.Show(MainForm, Text,  Caption, Button, Icon);
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
            Text = Microsoft.VisualBasic.Interaction.InputBox(Message, Title);
            return (Text == null ? DialogResult.Cancel : DialogResult.OK);
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
