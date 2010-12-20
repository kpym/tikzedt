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
        public FindReplaceDialog()
        {
            InitializeComponent();         

        }

        //public static readonly DependencyProperty TextToFindProperty = DependencyProperty.Register(
        //    "TextToFind", typeof(string), typeof(PdfOverlay), new PropertyMetadata(""));
        //public string TextToFind
        //{
        //    get { return (string)GetValue(TextToFindProperty); }
        //    set { }
        //}


        public TextEditor txtCode;

        public Regex GetRegEx(bool ForceLeftToRight = false)
        {
            Regex r;
            RegexOptions o = RegexOptions.None;
            if (FindReplacePersist.SearchUp && !ForceLeftToRight)
                o = o | RegexOptions.RightToLeft;
            if (!FindReplacePersist.CaseSensitive)
                o = o | RegexOptions.IgnoreCase;

            if (FindReplacePersist.UseRegExp)
                r = new Regex(FindReplacePersist.TextToFind, o);
            else
            {
                string s = Regex.Escape(FindReplacePersist.TextToFind);
                if (FindReplacePersist.UseWildcards)
                    s = s.Replace("\\*", ".*");
                if (FindReplacePersist.WholeWord)
                    s = "\\W" + s + "\\W";
                r = new Regex(s, o);
            }

            return r;
        }

        public void FindNext()
        {
            Regex r = GetRegEx();

            Match m = r.Match(txtCode.Text, txtCode.CaretOffset);
            if (m.Success)
            {
                txtCode.Select(m.Index, m.Length);
                TextLocation loc = txtCode.Document.GetLocation(m.Index);
                txtCode.ScrollTo(loc.Line, loc.Column);
            }
            else
            {
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

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            /* // Keep the window open (hide only)
            if (!MainWindow.isClosing)
            {
                this.Visibility = Visibility.Hidden;
                e.Cancel = true;
            } */
        }

        private void FindNextClick(object sender, RoutedEventArgs e)
        {
            FindNext();
        }

        private void ReplaceClick(object sender, RoutedEventArgs e)
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
            if (MessageBox.Show("Do you really want to replace all occurences of '" + FindReplacePersist.TextToFind + "' with '" + txtReplace.Text + "'?",
                "Replace all", MessageBoxButton.YesNoCancel, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
            {

                Regex r = GetRegEx(true);   // force left to right, otherwise indices are screwed up
                int offset = 0;
                txtCode.BeginChange();
                foreach (Match m in r.Matches(txtCode.Text))
                {                
                    txtCode.Document.Replace(offset+m.Index, offset+m.Length, txtReplace.Text);
                    offset += txtReplace.Text.Length - m.Length;
                }
                txtCode.EndChange();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //object o = FindName("txtFind");
            /*try
            {
                DataTemplate myTemplate = tabFind.ContentTemplate;//FindResource("FindPageTemplate") as DataTemplate;  
                ContentPresenter c = FindVisualChild<ContentPresenter>(tabFind);
                object ctl = myTemplate.FindName("txtFind", c);
                (ctl as FrameworkElement).Focus();
            }
            catch
            {
                // focus something else if the template/item wasn't found?
            }
            */
            //DependencyObject o = FindVisualChild<TextBox>(tabFind);
            //if (o != null)
            //    (o as FrameworkElement).Focus();
            //object o = FindResource("FindPageTemplate");
            //if (o != null)
            //{
            //    object o = 
            //if (o is TextBox)
            //    (o as TextBox).Focus();
        }
        private childItem FindVisualChild<childItem>(DependencyObject obj)
    where childItem : DependencyObject
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(obj, i);
                if (child != null && child is childItem)
                    return (childItem)child;
                else
                {
                    childItem childOfChild = FindVisualChild<childItem>(child);
                    if (childOfChild != null)
                        return childOfChild;
                }
            }
            return null;
        }


    }

    public class FindReplacePersist
    {

        public static string _TextToFind = "";
        public static string TextToFind
        {
            get { return _TextToFind; }
            set { _TextToFind = value; }
        }
        public static string _ReplacementText = "";
        public static string ReplacementText
        {
            get { return _ReplacementText; }
            set { _ReplacementText = value; }
        }
        public static bool _CaseSensitive = false;
        public static bool CaseSensitive
        {
            get { return _CaseSensitive; }
            set { _CaseSensitive = value; }
        }
        public static bool _SearchUp = false;
        public static bool SearchUp
        {
            get { return _SearchUp; }
            set { _SearchUp = value; }
        }
        public static bool _UseWildcards = false;
        public static bool UseWildcards
        {
            get { return _UseWildcards; }
            set { _UseWildcards = value; }
        }
        public static bool _UseRegExp = false;
        public static bool UseRegExp
        {
            get { return _UseRegExp; }
            set { _UseRegExp = value; }
        }
        public static bool _WholeWord = false;
        public static bool WholeWord
        {
            get { return _WholeWord; }
            set { _WholeWord = value; }
        }
    }           
}
