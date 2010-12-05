using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Data;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Globalization;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.CodeCompletion;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;

namespace TikzEdt
{
    /// <summary>
    /// Interaction logic for SnippetManager.xaml
    /// </summary>
    public partial class SnippetManager : Window
    {
        public TikzToBMPFactory fact = new TikzToBMPFactory();

        public SnippetManager()
        {
            InitializeComponent();
            string appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
            //xmldp.Source = new Uri(appPath + @"\Snippets.xml");
        }



        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            //string source = xmldp.Source.LocalPath;
            //xmldp.Document.Save(source);

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //string source = xmldp.Source.LocalPath;
            //xmldp.Document.Save(source);
            snippetsDataSet.WriteXml("TheSnippets.xml");
        }

        private void cmdDeleteClick(object sender, RoutedEventArgs e)
        {
            if (lstSnippets.SelectedIndex >= 0)
            {
                ((DataRowView)(lstSnippets.SelectedItem)).Delete();
                //snippetsDataSet.Tables["SnippetsTable"].Rows.Remove(lstSnippets.SelectedIndex);
            }
        }


        private void cmdAddClick(object sender, RoutedEventArgs e)
        {
            SnippetsDataSet.SnippetsTableRow r = snippetsTable.NewSnippetsTableRow();
            r.Name = "New Snippet";
            r.Category = "Styles";            
            if (lstSnippets.SelectedItem != null)
            {
                SnippetsDataSet.SnippetsTableRow curr = ((DataRowView)(lstSnippets.SelectedItem)).Row as SnippetsDataSet.SnippetsTableRow;
                r.Category = curr.Category;
            }
            r.Description = "Add descriptive text here \r\nWill be displayed as tooltip";
            r.SampleCode = "\\begin{tikzpicture}\r\n  \\draw (1,1)--(3,3);\r\n\\end{tikzpicture}";
            r.SnippetCode = "draw";
            r.Dependencies = "";

            snippetsTable.Rows.Add(r);         
        }

        TikzEdt.SnippetsDataSet snippetsDataSet;
        CollectionViewSource snippetsTableViewSource;
        SnippetsDataSet.SnippetsTableDataTable snippetsTable;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            FrameworkElement overflowGrid = tlbNewDelete.Template.FindName("OverflowGrid", tlbNewDelete) as FrameworkElement;
            if (overflowGrid != null)
            {
                overflowGrid.Visibility = Visibility.Collapsed;
            }

            if (!File.Exists(Consts.cSyntaxFile))
            {
                MessageBox.Show("Syntax definitions not found");
            }
            else
            {
                XmlReader r = new XmlTextReader(Consts.cSyntaxFile);
                txtSnippetCode.SyntaxHighlighting = HighlightingLoader.Load(r, null);  //HighlightingManager.Instance..GetDefinition("C#");
                txtSampleCode.SyntaxHighlighting = txtSnippetCode.SyntaxHighlighting;  //HighlightingManager.Instance..GetDefinition("C#");
                r.Close();
            }

            snippetsDataSet = ((TikzEdt.SnippetsDataSet)(this.FindResource("snippetsDataSet")));
            snippetsTable = snippetsDataSet.Tables["SnippetsTable"] as SnippetsDataSet.SnippetsTableDataTable;
            snippetsTableViewSource = (CollectionViewSource)this.FindResource("snippetsTableViewSource");
            if (File.Exists("TheSnippets.xml"))
                snippetsDataSet.ReadXml("TheSnippets.xml");         // TODO: Program stops here...very strange ... due to images???
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            snippetsDataSet.WriteXml("TheSnippets.xml");
        }

        private void Image_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lstSnippets.SelectedIndex >= 0)
            {
                SnippetsDataSet.SnippetsTableRow r = ((DataRowView)lstSnippets.SelectedItem).Row as SnippetsDataSet.SnippetsTableRow;
                if (!r.IsNull(snippetsTable.SampleCodeColumn))
                    fact.AddJob(r.SampleCode, Directory.GetCurrentDirectory() + "\\img\\" + r.ID, new Rect(0, 0, 4, 4));
            }
        }


        private void lstSnippets_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lProgrammatic = true;
            if (lstSnippets.SelectedItem == null)
            {
                txtSnippetCode.Clear();
                //txtSnippetCode.IsEnabled = false;
            }
            else
            {
                SnippetsDataSet.SnippetsTableRow r = ((DataRowView)lstSnippets.SelectedItem).Row as SnippetsDataSet.SnippetsTableRow;
                if (r.IsNull(snippetsTable.SnippetCodeColumn))
                {
                    txtSnippetCode.Clear();
                }
                else
                {
                    txtSnippetCode.Text = r.SnippetCode;
                }
                if (r.IsNull(snippetsTable.SampleCodeColumn))
                {
                    txtSampleCode.Clear();
                }
                else
                {
                    txtSampleCode.Text = r.SampleCode;
                }
            }
            lProgrammatic = false;
        }

        bool lProgrammatic = false;
        private void txtSnippetCode_TextChanged(object sender, EventArgs e)
        {
            if (lstSnippets.SelectedItem != null && !lProgrammatic)
            {
                SnippetsDataSet.SnippetsTableRow r = ((DataRowView)lstSnippets.SelectedItem).Row as SnippetsDataSet.SnippetsTableRow;
                if (sender == txtSampleCode)
                    r.SampleCode = txtSampleCode.Text;
                else if (sender == txtSnippetCode)
                    r.SnippetCode = txtSnippetCode.Text;
            }
        }

        private void cmdRefreshClick(object sender, RoutedEventArgs e)
        {
            //lstSnippets.Items.Refresh();            
            snippetsDataSet.WriteXml("TheSnippets.xml");
            snippetsDataSet.Clear();
            snippetsDataSet.ReadXml("TheSnippets.xml");
        }
    }

    public sealed class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
                              object parameter, CultureInfo culture)
        {
            try
            {
                string appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
                string fullpath = appPath + "\\img\\" + value.ToString() +".bmp";
                //string fullpath2 = fullpath.Substring(;
                BitmapImage bi = new BitmapImage();
                bi.BeginInit();
                if (File.Exists((new Uri(fullpath)).LocalPath))
                    bi.UriSource = new Uri(fullpath);
                else if (File.Exists("unavailable.png"))
                    bi.UriSource = new Uri(appPath+"\\unavailable.png");
                else return null;
                bi.CacheOption = BitmapCacheOption.OnLoad;
                bi.EndInit();
                return bi;
               
                 //   return new BitmapImage(new Uri(fullpath));
               // else
                  //  return new BitmapImage(); // TODO: load unavailable image
            }
            catch(Exception e)
            {
                return null;// new BitmapImage();
            }
        }

        public object ConvertBack(object value, Type targetType,
                                  object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    class TextEditorWithBinding : TextEditor
    {
        public static readonly DependencyProperty BindableTextProperty =
                DependencyProperty.Register(
                "BindableText", typeof(string), typeof(TextEditorWithBinding),
                new PropertyMetadata("", textChangedCallBack, LastNameCoerceCallback));//new PropertyChangedCallback(textChangedCallBack)));

        //[Bindable(true)]
        public string BindableText
        {
            get 
            { 
                //return Text; 
                return (string)GetValue(BindableTextProperty);
            }
            set 
            { 
                SetValue(BindableTextProperty, value);
            }
        }

        public TextEditorWithBinding() : base()
        {
            TextChanged += new EventHandler(TextEditorWithBinding_DocumentChanged);
            Loaded += new RoutedEventHandler(TextEditorWithBinding_Loaded);
        }

        void TextEditorWithBinding_Loaded(object sender, RoutedEventArgs e)
        {
            stisloaded = true;
        }
        static bool stisloaded = false;
        static object LastNameCoerceCallback(DependencyObject obj, object o)
        {
            string s = o as string;
            TextEditorWithBinding txt = (TextEditorWithBinding)obj;
            if (stisloaded)
            {
                txt.isProgrammatic = true;
                if (s != null)
                    txt.Text = s;
                else txt.Clear();
                txt.isProgrammatic = false;
            }
            return s;
        }

        static void textChangedCallBack(DependencyObject property, DependencyPropertyChangedEventArgs args) 
        {
            TextEditorWithBinding txt = (TextEditorWithBinding)property;
            if (args.NewValue == null)
                txt.Text = "";
            else
                txt.Text = (string)args.NewValue; 
        }

        bool isProgrammatic = false;
        void TextEditorWithBinding_DocumentChanged(object sender, EventArgs e)
        {
            if (!isProgrammatic) 
               SetValue(BindableTextProperty, Text);
        }

    }
}
