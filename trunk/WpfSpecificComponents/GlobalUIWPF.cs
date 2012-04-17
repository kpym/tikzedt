using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Forms;

namespace TikzEdt
{
    public class GlobalUIWPF : GlobalUIBase, IGlobalUI
    {

        public Window MessageBoxOwner;
        public DialogResult ShowMessageBox(string Text, string Caption, MessageBoxButtons Button, MessageBoxIcon Icon)
        {
            return System.Windows.MessageBox.Show(MessageBoxOwner, Text, Caption, Button.ToMessageBoxButton(), Icon.ToMessageBoxImage()).ToDialogResult();
        }

        /// <summary>
        /// To enable unit testing, queries for filenames by the viewmodels are channeled through these methods
        /// </summary>
        public bool? ShowOpenFileDialog(out string FileName, string Filter = Consts.StdFileDialogFilter)
        {
                ofd.InitialDirectory = Directory.GetCurrentDirectory();
                ofd.Filter = Filter;
                bool? ret = ofd.ShowDialog(MessageBoxOwner);
                FileName = ofd.FileName;
                return ret;
        }
        public bool? ShowSaveFileDialog(out string FileName, string InitFilename, string Filter = Consts.StdFileDialogFilter)
        {
                sfd.InitialDirectory = Directory.GetCurrentDirectory();
                sfd.FileName = InitFilename;
                sfd.Filter = Filter;
                bool? ret = sfd.ShowDialog(MessageBoxOwner);
                FileName = sfd.FileName;
                return ret;
        }
        Microsoft.Win32.OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog() { CheckFileExists = true, CheckPathExists = true };
        Microsoft.Win32.SaveFileDialog sfd = new Microsoft.Win32.SaveFileDialog() { OverwritePrompt = true, ValidateNames = true, AddExtension = true };

        public DialogResult ShowInputDialog(string Title, string Message, out string Text)
        {
            return TESharedComponents.InputMessageBox.ShowInputDialog(Title, Message, out Text).ToDialogResult();

            //Text = "";
            //return MessageBoxResult.Cancel;
        }


        public void InvokeInUIThread(Action a)
        {
            System.Windows.Application.Current.Dispatcher.Invoke(a);
        }

        public void BeginInvokeInUIThread(Action a)
        {
            System.Windows.Application.Current.Dispatcher.BeginInvoke(a);
        }
    }

    public static class DlgConversions
    {
        public static DialogResult ToDialogResult(this MessageBoxResult res)
        {
            if (res == MessageBoxResult.Cancel) return DialogResult.Cancel;
            if (res == MessageBoxResult.No) return DialogResult.No;
            if (res == MessageBoxResult.Yes) return DialogResult.Yes;
            if (res == MessageBoxResult.OK) return DialogResult.OK;
            return DialogResult.None;
        }

        public static MessageBoxButton ToMessageBoxButton(this MessageBoxButtons b)
        {
            if (b == MessageBoxButtons.OKCancel) return MessageBoxButton.OKCancel;
            if (b == MessageBoxButtons.YesNo) return MessageBoxButton.YesNo;
            if (b == MessageBoxButtons.YesNoCancel) return MessageBoxButton.YesNoCancel;
            return MessageBoxButton.OK;
        }

        public static MessageBoxImage ToMessageBoxImage(this MessageBoxIcon b)
        {
            if (b == MessageBoxIcon.Warning) return MessageBoxImage.Warning;
            if (b == MessageBoxIcon.Error) return MessageBoxImage.Error;
            if (b == MessageBoxIcon.Exclamation) return MessageBoxImage.Exclamation;
            if (b == MessageBoxIcon.Information) return MessageBoxImage.Information;
            if (b == MessageBoxIcon.Question) return MessageBoxImage.Question;
            if (b == MessageBoxIcon.Stop) return MessageBoxImage.Stop;
            if (b == MessageBoxIcon.Asterisk) return MessageBoxImage.Asterisk;
            if (b == MessageBoxIcon.Hand) return MessageBoxImage.Hand;
            return MessageBoxImage.None;
        }
    }
}
