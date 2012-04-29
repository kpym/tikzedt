using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TikzEdt;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Gtk;

namespace TikzEdtGTK
{
    public class GlobalUIGTK : GlobalUIBase, IGlobalUI
    {
        /// <summary>
        ///  It is mandatory that this is set to the main window before using GlobalUI.
        /// </summary>
        public Window MainForm = null;

        //FileChooserDialog sfd = new FileChooserDialog() { OverwritePrompt = true, ValidateNames = true, AddExtension = true };
        //FileChooserDialog ofd = new FileChooserDialog() { CheckFileExists = true, CheckPathExists = true };

        public DialogResult ShowMessageBox(string Text, string Caption, MessageBoxButtons Button, MessageBoxIcon Icon)
        {
            var m = new MessageDialog(MainForm, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Hallo Welt");
            m.Run();
            m.Destroy();
            return DialogResult.OK;
        }

        public bool? ShowOpenFileDialog(out string FileName, string Filter = Consts.StdFileDialogFilter)
        {
            var f = new FileChooserDialog("Open File", MainForm, FileChooserAction.Open);
            //f.CurrentFolder = Directory.GetCurrentDirectory();
            //f.Filters = 
            //f.Filter = Filter;
            //bool? ret = ofd.ShowDialog(MainForm) == DialogResult.OK;
            //FileName = ofd.FileName;

            f.Run();
            FileName = f.Filename;
            f.Destroy();
            return true;
        }

        public bool? ShowSaveFileDialog(out string FileName, string InitFilename, string Filter = Consts.StdFileDialogFilter)
        {
            /*sfd.InitialDirectory = Directory.GetCurrentDirectory();
            sfd.FileName = InitFilename;
            sfd.Filter = Filter;
            bool? ret = sfd.ShowDialog(MainForm) == DialogResult.OK;
            FileName = sfd.FileName;
            return ret;*/

            var f = new FileChooserDialog("Save File", MainForm, FileChooserAction.Open);
            f.Run();
            FileName = f.Filename;
            f.Destroy();
            return true;
        }

        public DialogResult ShowInputDialog(string Title, string Message, out string Text)
        {
            Text = "";
            return DialogResult.OK;
            //return InputDialog.ShowInputDialog(MainForm, Title, Message, out Text);
            //return (Text == null ? DialogResult.Cancel : DialogResult.OK);
        }

        public void InvokeInUIThread(System.Action a)
        {
            Gtk.Application.Invoke(delegate { a(); });
        }

        public void BeginInvokeInUIThread(System.Action a)
        {
            // hack
            Gtk.Application.Invoke(delegate { a(); });
        }

        public GlobalUIGTK()
        {
            //this.MainForm = MainForm;
        }

    }
}
