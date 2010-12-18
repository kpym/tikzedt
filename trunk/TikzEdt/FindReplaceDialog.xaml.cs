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

namespace TikzEdt
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

        public Regex GetRegEx()
        {
            Regex r;
            RegexOptions o = RegexOptions.None;
            if (DummyClass.SearchUp)
                o = o | RegexOptions.RightToLeft;
            if (!DummyClass.CaseSensitive)
                o = o | RegexOptions.IgnoreCase;

            if (DummyClass.UseRegExp)
                r = new Regex(DummyClass.TextToFind);
            else
            {
                string s = Regex.Escape(DummyClass.TextToFind);
                if (DummyClass.UseWildcards)
                    s = s.Replace("\\*", ".*");
                if (DummyClass.WholeWord)
                    s = "\\W" + s + "\\W";
                r = new Regex(s);
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
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Keep the window open (hide only)
            if (!MainWindow.isClosing)
            {
                this.Visibility = Visibility.Hidden;
                e.Cancel = true;
            }
        }

        private void FindNextClick(object sender, RoutedEventArgs e)
        {
            FindNext();
        }

        private void ReplaceClick(object sender, RoutedEventArgs e)
        {

        }

        private void ReplaceAllClick(object sender, RoutedEventArgs e)
        {
            Regex r = GetRegEx();
            txtCode.Document.Replace(0, txtCode.Document.TextLength, r.Replace(txtCode.Text, txtReplace.Text));
        }
    }

        public class DummyClass
        {

            public static string _TextToFind="";
        public static string TextToFind
        {
            get { return _TextToFind; }
            set { _TextToFind = value; }
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
