using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TikzEdt;


namespace TEApplicationLogicUnitTests
{
    /// <summary>
    /// This class shall emulate the global UI
    /// </summary>
    class GlobalUIMock : GlobalUIBase, IGlobalUI 
    {
        /// <summary>
        /// For unit testing the IO, set this to the desired result. 
        /// Otherwise leave null, then a modal message box is displayed.
        /// </summary>
        public DialogResult MockResult;
        public string LastMessage = ""; // stores the last messagebox text for testing

        public DialogResult ShowMessageBox(string Text, string Caption, MessageBoxButtons Button, MessageBoxIcon Icon)
        {
                LastMessage = Text;
                return MockResult;
        }

        /// <summary>
        /// To enable unit testing, queries for filenames by the viewmodels are channeled through these methods
        /// </summary>
        public bool? MockFileDialogResult = null;
        public string MockFileDialogFileName = null;
        public bool? ShowOpenFileDialog(out string FileName, string Filter = Consts.StdFileDialogFilter)
        {
                FileName = MockFileDialogFileName;
                return MockFileDialogResult;
        }
        public bool? ShowSaveFileDialog(out string FileName, string InitFilename, string Filter = Consts.StdFileDialogFilter)
        {
                FileName = MockFileDialogFileName;
                return MockFileDialogResult;
        }


        public void AddStatusLine(object sender, string line, bool error = false)
        {
            
        }

        public string MockInputDialogText = "";
        public DialogResult ShowInputDialog(string Title, string Message, out string Text)
        {
            Text = MockInputDialogText;
            return MockResult;
        }


        public void InvokeInUIThread(Action a)
        {
            a();
        }

        public void BeginInvokeInUIThread(Action a)
        {
            a();
        }
    }
}
