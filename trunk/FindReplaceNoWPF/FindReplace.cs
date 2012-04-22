
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FindReplaceNoWPF
{

    /// <summary>
    /// This class ensures that the settings and text to be found is preserved when the find/replace dialog is closed
    /// 
    /// We need two-way binding, otherwise we could just make all properties static properties of the window
    /// </summary>
    public class FindReplaceMgr : INotifyPropertyChanged
    {
        private FindReplaceDialog _dialog = null;

        /// <summary>
        /// Instance of the dialog window
        /// </summary>
        FindReplaceDialog dialog                     
        {
            get
            {
                if (_dialog == null)
                {
                    _dialog = new FindReplaceDialog(this);
                    _dialog.Closed += delegate { _dialog = null; };
                    if (OwnerWindow != null)
                        _dialog.Owner = OwnerWindow;
                }
                return _dialog;
            }
        }
        public Form OwnerWindow = null;

        public FindReplaceMgr()
        {
            ReplacementText = "";
            TextToFind = "";

            SearchIn = SearchScope.CurrentDocument;
            ShowSearchIn = true;
        }

        #region Public Properties

        /// <summary>
        /// The list of editors in which the search should take place.
        /// The elements must either implement the IEditor interface, or 
        /// InterfaceConverter should bne set.
        /// </summary>   
        public IEnumerable Editors
        {
            get { return _Editors; }
            set 
            {
                if (value != _Editors)
                {
                    _Editors = value;
                    NotifyPropertyChanged("Editors");
                }
            }
        }
        private IEnumerable _Editors = null;

        /// <summary>
        /// The editor in which the current search operation takes place.
        /// </summary>
        public object CurrentEditor
        {
            get { return _CurrentEditor; }
            set
            {
                if (value != _CurrentEditor)
                {
                    _CurrentEditor = value;
                    NotifyPropertyChanged("CurrentEditor");
                }
            }
        }
        private object _CurrentEditor = null;

        /// <summary>
        /// Objects in the Editors list that do not implement the IEditor interface are converted to IEditor using this converter.
        /// </summary>
        public Func<object, IEditor> Converter = null;

        /// <summary>
        /// The text to be found.
        /// </summary>
        public string TextToFind { get; set; }
        public string ReplacementText { get; set; }

        public bool UseWildcards { get; set; }

        public bool SearchUp { get; set; }
        
        public bool CaseSensitive {get; set;}

        public bool UseRegEx {get; set;}
       
        public bool WholeWord {get; set;}
        

        public bool AcceptsReturn {get; set;}
        

        public enum SearchScope { CurrentDocument, AllDocuments }
        public SearchScope SearchIn { get; set; }
        

        
        /// <summary>
        /// Determines whether to display the Search in combo box
        /// </summary>
        public bool ShowSearchIn { get; set; }


        /// <summary>
        /// Determines whether the "Replace"-page in the dialog in shown or not.
        /// </summary>
        public bool AllowReplace { get; set; }
              

        #endregion


        IEditor GetCurrentEditor()
        {
            if (CurrentEditor == null)
                return null;
            if (CurrentEditor is IEditor)
                return CurrentEditor as IEditor;
            if (Converter == null)
                return null;

            return Converter(CurrentEditor);
        }
        IEditor GetNextEditor(bool previous = false)
        {
            if (!ShowSearchIn || SearchIn == SearchScope.CurrentDocument || Editors == null)
                return GetCurrentEditor();

            List<object> l = new List<object>(Editors.Cast<object>());
            int i = l.IndexOf(CurrentEditor);
            if (i >= 0)
            {
                i = (i + (previous ? l.Count-1 : +1)) % l.Count;
                CurrentEditor = l[i];
            }
            return GetCurrentEditor();
        }

        /// <summary>
        /// Constructs a regular expression according to the currently selected search parameters.
        /// </summary>
        /// <param name="ForceLeftToRight"></param>
        /// <returns>The regular expression.</returns>
        public Regex GetRegEx(bool ForceLeftToRight = false)
        {
            Regex r;
            RegexOptions o = RegexOptions.None;
            if (SearchUp && !ForceLeftToRight)
                o = o | RegexOptions.RightToLeft;
            if (!CaseSensitive)
                o = o | RegexOptions.IgnoreCase;

            if (UseRegEx)
                r = new Regex(TextToFind, o);
            else
            {
                string s = Regex.Escape(TextToFind);
                if (UseWildcards)
                    s = s.Replace("\\*", ".*").Replace("\\?", ".");
                if (WholeWord)
                    s = "\\b" + s + "\\b";
                r = new Regex(s, o);
            }

            return r;
        }

        public void ReplaceAll(bool AskBefore = true)
        {
            IEditor CE = GetCurrentEditor();
            if (CE == null) return;

            if (!AskBefore || MessageBox.Show("Do you really want to replace all occurences of '" + TextToFind + "' with '" + ReplacementText + "'?",
                "Replace all", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                object InitialEditor = CurrentEditor;
                // loop through all editors, until we are back at the starting editor                
                do
                {
                    Regex r = GetRegEx(true);   // force left to right, otherwise indices are screwed up
                    int offset = 0;
                    CE.BeginChange();
                    foreach (Match m in r.Matches(CE.Text))
                    {
                        CE.Replace(offset + m.Index, m.Length, ReplacementText);
                        offset += ReplacementText.Length - m.Length;
                    }
                    CE.EndChange();
                    CE = GetNextEditor();
                } while (CurrentEditor != InitialEditor);
            }
        }

        /// <summary>
        /// Shows this instance of FindReplaceDialog, with the Find page active
        /// </summary>
        public void ShowAsFind()
        {
            dialog.ActivateFind();
            dialog.Show();
            dialog.Activate();
            dialog.txtTextToFind.Focus();
        }
        /// <summary>
        /// Shows this instance of FindReplaceDialog, with the Replace page active
        /// </summary>
        public void ShowAsReplace()
        {
            dialog.ActivateReplace();
            dialog.Show();
            dialog.Activate();
            dialog.txtTextToFind.Focus();
        }
        
        public void FindNext(object target, bool InvertLeftRight = false)
        {
            CurrentEditor = target;
            FindNext(InvertLeftRight);
        }
        public void FindNext(bool InvertLeftRight = false)
        {
            IEditor CE = GetCurrentEditor();
            if (CE == null) return;
            Regex r;
            if (InvertLeftRight)
            {
                SearchUp = !SearchUp;
                r = GetRegEx();
                SearchUp = !SearchUp;
            }
            else
                r = GetRegEx();

            Match m = r.Match(CE.Text,  r.Options.HasFlag(RegexOptions.RightToLeft) ? CE.SelectionStart : CE.SelectionStart+CE.SelectionLength);
            if (m.Success)
            {
                CE.Select(m.Index, m.Length);
            }
            else
            {
                // we have reached the end of the document
                // start again from the beginning/end,
                object OldEditor = CurrentEditor;
                do
                {
                    if (ShowSearchIn)
                    {
                        CE = GetNextEditor(r.Options.HasFlag(RegexOptions.RightToLeft));
                        if (CE == null) return;
                    }
                    if (r.Options.HasFlag(RegexOptions.RightToLeft))
                        m = r.Match(CE.Text, CE.Text.Length );
                    else
                        m = r.Match(CE.Text, 0);
                    if (m.Success)
                    {
                        CE.Select(m.Index, m.Length);
                        break;
                    }
                    else
                    {
                        // Failed to find the text
                        //MessageBox.Show("No occurence found.", "Search");
                    }
                } while (CurrentEditor != OldEditor);
            }
        }

        public void FindPrevious()
        {
            FindNext(true);
        }

        public void Replace()
        {
            IEditor CE = GetCurrentEditor();
            if (CE == null) return;

            // if currently selected text matches -> replace; anyways, find the next match
            Regex r = GetRegEx();
            string s = CE.Text.Substring(CE.SelectionStart, CE.SelectionLength); // CE.SelectedText;
            Match m = r.Match(s);
            if (m.Success && m.Index == 0 && m.Length == s.Length)
            {
                CE.Replace(CE.SelectionStart, CE.SelectionLength, ReplacementText);
                //CE.SelectedText = ReplacementText;
            }

            FindNext();
        }

        /// <summary>
        /// Closes the Find/Replace dialog, if it is open
        /// </summary>
        public void CloseWindow()
        {
            dialog.Close();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }

    public interface IEditor
    {
        string Text { get; }
        int SelectionStart { get; }
        int SelectionLength { get; }
        /// <summary>
        /// Selects the specified portion of Text and scrolls that part into view.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="length"></param>
        void Select(int start, int length);
        void Replace(int start, int length, string ReplaceWith);
        /// <summary>
        /// This method is called before a replace all operation.
        /// </summary>
        void BeginChange();
        /// <summary>
        /// This method is called after a replace all operation.
        /// </summary>
        void EndChange();
    }
}
