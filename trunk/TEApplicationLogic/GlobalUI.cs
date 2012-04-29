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

        /// <summary>
        /// Stores messages that arrive before a listener is connected.
        /// </summary>
        private static List<Pair<object, GlobalStatusEventData>> StatusLineBuffer = new List<Pair<object, GlobalStatusEventData>>();

        public void AddStatusLine(object sender, string line, bool error = false)
        {
            if (OnGlobalStatus != null)
            {
                if (StatusLineBuffer.Count > 0)
                {
                    // send pending messages first
                    foreach (var p in StatusLineBuffer)
                        OnGlobalStatus(p.First, p.Second);
                    StatusLineBuffer.Clear();
                }

                OnGlobalStatus(sender, new GlobalStatusEventData() { StatusLine = line, IsError = error });
            }
            else StatusLineBuffer.Add(new Pair<object, GlobalStatusEventData>(sender, new GlobalStatusEventData() { StatusLine = line, IsError = error }));
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

    
}
