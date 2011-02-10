/*This file is part of TikzEdt.
 
TikzEdt is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.
 
TikzEdt is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
GNU General Public License for more details.
 
You should have received a copy of the GNU General Public License
along with TikzEdt.  If not, see <http://www.gnu.org/licenses/>.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Document;
using System.Text.RegularExpressions;

namespace TikzEdt.Editor
{

    /// <summary>
    /// Interaction logic for FindReplaceDialog.xaml
    /// </summary>
    public partial class FindReplaceDialog : Window
    {
        public FindReplaceDialog(TextEditor EditorToSearchWithin)
        {
            InitializeComponent();

            txtCode = EditorToSearchWithin;
        }

        /// <summary>
        /// Shows this instance of FindReplaceDialog, with the Find page active
        /// </summary>
        public void ShowAsFind()
        {
            tabMain.SelectedIndex = 0;
            Show();
            Activate();
            txtFind.Focus();
        }
        /// <summary>
        /// Shows this instance of FindReplaceDialog, with the Replace page active
        /// </summary>
        public void ShowAsReplace()
        {
            tabMain.SelectedIndex = 1;
            Show();
            Activate();
            txtFind2.Focus();
        }

        TextEditor txtCode;

        public Regex GetRegEx(bool ForceLeftToRight = false)
        {
            Regex r;
            RegexOptions o = RegexOptions.None;
            if (FindReplacePersist.Instance.SearchUp && !ForceLeftToRight)
                o = o | RegexOptions.RightToLeft;
            if (!FindReplacePersist.Instance.CaseSensitive)
                o = o | RegexOptions.IgnoreCase;

            if (FindReplacePersist.Instance.UseRegEx)
                r = new Regex(FindReplacePersist.Instance.TextToFind, o);
            else
            {
                string s = Regex.Escape(FindReplacePersist.Instance.TextToFind);
                if (FindReplacePersist.Instance.UseWildcards)
                    s = s.Replace("\\*", ".*");
                if (FindReplacePersist.Instance.WholeWord)
                    s = "\\W" + s + "\\W";
                r = new Regex(s, o);
            }

            return r;
        }

        public void FindNext(bool InvertLeftRight=false)
        {
            Regex r;
            if (InvertLeftRight)
            {
                FindReplacePersist.Instance.SearchUp = !FindReplacePersist.Instance.SearchUp;
                r = GetRegEx();
                FindReplacePersist.Instance.SearchUp = !FindReplacePersist.Instance.SearchUp;
            }
            else
                r = GetRegEx();

            Match m = r.Match(txtCode.Text, txtCode.CaretOffset);
            if (m.Success)
            {
                txtCode.Select(m.Index, m.Length);
                if (r.Options.HasFlag(RegexOptions.RightToLeft))
                    txtCode.CaretOffset = m.Index;
                TextLocation loc = txtCode.Document.GetLocation(m.Index);
                txtCode.ScrollTo(loc.Line, loc.Column);
            }
            else
            {
                // start again from the beginning/end
                if (r.Options.HasFlag(RegexOptions.RightToLeft))
                    m = r.Match(txtCode.Text, txtCode.Text.Length - 1);
                else
                    m = r.Match(txtCode.Text, 0);
                if (m.Success)
                {
                    txtCode.Select(m.Index, m.Length);
                    TextLocation loc = txtCode.Document.GetLocation(m.Index);
                    txtCode.ScrollTo(loc.Line, loc.Column);
                }
                else
                {
                    // Failed to find the text
                    MessageBox.Show("No occurence found.", "Search");
                }
            }
        }

        public void FindPrevious()
        {
            FindNext(true);
        }

        private void FindNextClick(object sender, RoutedEventArgs e)
        {
            FindNext();
        }

        private void ReplaceClick(object sender, RoutedEventArgs e)
        {
            Replace();
        }
        public void Replace()
        {
            // if currently selected text matches -> replace; anyways, find the next match
            Regex r = GetRegEx();
            string s = txtCode.SelectedText;
            Match m = r.Match(s);
            if (m.Success && m.Index == 0 && m.Length == s.Length)
            {
                txtCode.Document.Replace(txtCode.SelectionStart, txtCode.SelectionLength, txtReplace.Text);
            }

            FindNext();
        }

        private void ReplaceAllClick(object sender, RoutedEventArgs e)
        {
            ReplaceAll();
        }
        public void ReplaceAll(bool AskBefore = true )
        {
            if (!AskBefore || MessageBox.Show("Do you really want to replace all occurences of '" + FindReplacePersist.Instance.TextToFind + "' with '" + txtReplace.Text + "'?",
                "Replace all", MessageBoxButton.YesNoCancel, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
            {

                Regex r = GetRegEx(true);   // force left to right, otherwise indices are screwed up
                int offset = 0;
                txtCode.BeginChange();
                foreach (Match m in r.Matches(txtCode.Text))
                {                
                    txtCode.Document.Replace(offset+m.Index, m.Length, txtReplace.Text);
                    offset += txtReplace.Text.Length - m.Length;
                }
                txtCode.EndChange();
            }
        }
  
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                Close();
        }


    }

    /// <summary>
    /// This class ensures that the settings and text to be found is preserved when the find/replace dialog is closed
    /// 
    /// We need two-way binding, otherwise we could just make all properties static properties of the window
    /// </summary>
    public class FindReplacePersist : DependencyObject
    {
        // singleton pattern
        public static FindReplacePersist Instance { get; private set; }
        static FindReplacePersist()
        {
            Instance = new FindReplacePersist();
        }
        private FindReplacePersist() 
        {
            ReplacementText = "";
            CaseSensitive = SearchUp = UseWildcards = UseRegEx = WholeWord = false;
        }

        public static readonly DependencyProperty TextToFindProperty =
        DependencyProperty.Register("TextToFind", typeof(string),
        typeof(FindReplacePersist), new UIPropertyMetadata(""));
        public string TextToFind
        {
            get { return (string)GetValue(TextToFindProperty); }
            set { SetValue(TextToFindProperty, value); }
        }
        
        public string ReplacementText { get; set; }
        public bool CaseSensitive { get; set; }
        public bool SearchUp { get; set; }
        public bool UseWildcards { get; set; }
        public bool UseRegEx { get; set; }
        public bool WholeWord { get; set; }

    }           
}
