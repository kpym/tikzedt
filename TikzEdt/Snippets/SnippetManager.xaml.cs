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

namespace TikzEdt.Snippets
{
    /// <summary>
    /// This class is (as one might guess) the graphical editor
    /// for the Snippet library. Some things to remember:
    ///   - It uses a separate Snippets Dataset, not the one from the main window, for encapsulation reasons.
    ///   - 
    /// </summary>
    public partial class SnippetManager : Window
    {
        public TikzToBMPFactory fact;
        public bool isSuccessfullyLoaded = false;
        System.Threading.Mutex myMutex;

        SnippetsDataSet snippetsDataSet;
        CollectionViewSource snippetsTableViewSource;
        SnippetsDataSet.SnippetsTableDataTable snippetsTable;

        public SnippetManager()
        {
            InitializeComponent();

            // Try to get mutex. This is because we want to prevent several instances of the Snippetmanager 
            // to be open simultaneously, because the user might loose data by applying changes in both.
            myMutex = new System.Threading.Mutex(false, "SnippetManagerMutex");
            if (!myMutex.WaitOne(50))
            {
                MessageBox.Show("Cannot get a unique lock. \r\nPlease close other instances of the Snippetsmanager.\r\n(In order to avoid data corruption, only one Snippetmanager may be open at a time.)",
                    "Cannot get lock", MessageBoxButton.OK, MessageBoxImage.Warning);
                Close();
                return;
            }
            else
                isSuccessfullyLoaded = true;

            fact = TikzToBMPFactory.Instance;
            fact.BitmapGenerated += new TikzToBMPFactory.NoArgsEventHandler(fact_BitmapGenerated);

            //string appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
            //xmldp.Source = new Uri(appPath + @"\Snippets.xml");
        }

        /// <summary>
        /// This method is called (in a different thread) when the Bitmap Factory has succesfully compiled a Thumbnail
        /// </summary>
        void fact_BitmapGenerated(object sender)
        {
            //Dispatcher.Invoke(new Action(
            //                delegate()
            //                {
                                // refresh currently selected item
                                if (lstSnippets.SelectedItem != null)
                                {
                                    SnippetsDataSet.SnippetsTableRow curr = ((DataRowView)(lstSnippets.SelectedItem)).Row as SnippetsDataSet.SnippetsTableRow;
                                    curr.ID = curr.ID;
                                }
            //                }
            //                ));
        }


        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //string source = xmldp.Source.LocalPath;
            //xmldp.Document.Save(source);
            if (isSuccessfullyLoaded)
                snippetsDataSet.WriteXml(Consts.cSnippetsFile);
            
        }

        private void cmdDeleteClick(object sender, RoutedEventArgs e)
        {
            if (lstSnippets.SelectedIndex >= 0)
            {
                if (MessageBox.Show("Do you really want to delete this entry?", "Really????", MessageBoxButton.YesNoCancel, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
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

  
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            FrameworkElement overflowGrid = tlbNewDelete.Template.FindName("OverflowGrid", tlbNewDelete) as FrameworkElement;
            if (overflowGrid != null)
            {
                overflowGrid.Visibility = Visibility.Collapsed;
            }
            overflowGrid = tlbNewDelete.Template.FindName("OverflowGrid", tlbCompile) as FrameworkElement;
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

            snippetsDataSet = ((SnippetsDataSet)(this.FindResource("snippetsDataSet")));
            snippetsTable = snippetsDataSet.Tables["SnippetsTable"] as SnippetsDataSet.SnippetsTableDataTable;
            snippetsTableViewSource = (CollectionViewSource)this.FindResource("snippetsTableViewSource");
            if (File.Exists(Consts.cSnippetsFile))
            {
                snippetsDataSet.ReadXml(Consts.cSnippetsFile);         // TODO: Program stops here...very strange ... due to images???
                snippetsTableViewSource.View.Refresh();
            }
        }

        private void cmdCompile_Click(object sender, RoutedEventArgs e)
        {
            SnippetsDataSet.SnippetsTableRow r = ((DataRowView)lstSnippets.SelectedItem).Row as SnippetsDataSet.SnippetsTableRow;
            if (!r.IsNull(snippetsTable.SampleCodeColumn))
                fact.AddJob(r.SampleCode, Helper.GetAppDir() + "\\img\\" + r.ID + ".tex", new Rect(0, 0, 0, 0), r.Name, true);
        }

        /// <summary>
        /// Most controls are data bound, however, this is not (directly) possible for the AvalonEditors.
        /// (Text is not a dependency property). Hence we need this eventhandler here to update them manually.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Needed since one cannot databind Avavlon Editor.Text (see above)
        /// </summary>
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
            snippetsTableViewSource.View.Refresh();
        }

        private void cmdSaveClick(object sender, RoutedEventArgs e)
        {
            if (isSuccessfullyLoaded)
                snippetsDataSet.WriteXml(Consts.cSnippetsFile);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            fact.BitmapGenerated -= new TikzToBMPFactory.NoArgsEventHandler(fact_BitmapGenerated);
            // release mutex
            if (myMutex != null && isSuccessfullyLoaded)
                myMutex.ReleaseMutex();
        }

        private void cmdGenerateAllImagesClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mbres = MessageBox.Show("Do you really want to regenerate all images?\r\nNote that this will take some time.\r\nChoosing 'No' will only generate inexistent images, choosing 'Cancel' will do nothing.",
                "Regenerate images", MessageBoxButton.YesNoCancel, MessageBoxImage.Exclamation);

            if (mbres != MessageBoxResult.Cancel)
            {
                foreach (SnippetsDataSet.SnippetsTableRow r in snippetsTable.Rows)
                {
                    if (!r.IsNull(snippetsTable.SampleCodeColumn))
                    {
                        string cFile =  Helper.GetAppDir() + "\\img\\" + r.ID;
                        if (mbres == MessageBoxResult.Yes || !File.Exists(cFile+".bmp"))
                            fact.AddJob(r.SampleCode, cFile + ".tex", new Rect(0, 0, 0, 0), r.Name, true);
                    }
                }
            }
        }

        private void Image_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

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
                bi.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
                bi.EndInit();
                return bi;
               
                 //   return new BitmapImage(new Uri(fullpath));
               // else
                  //  return new BitmapImage(); // TODO: load unavailable image
            }
            catch(Exception)
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

}
