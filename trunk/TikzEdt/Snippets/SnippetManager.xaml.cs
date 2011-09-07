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
            // remove focus from current control, so that pending data is written to dataset
            lstSnippets.Focus();
            if (isSuccessfullyLoaded)
                snippetsDataSet.WriteXml(Helper.GetSettingsPath() + Consts.cSnippetsFile);
            
        }

        private void cmdDeleteClick(object sender, RoutedEventArgs e)
        {
            if (lstSnippets.SelectedIndex >= 0)
            {
                SnippetsDataSet.SnippetsTableRow curr = ((DataRowView)(lstSnippets.SelectedItem)).Row as SnippetsDataSet.SnippetsTableRow;
                if (MessageBox.Show("Do you really want to delete entry \"" + curr.Name + "\" from category \"" + curr.Category + "\"?", "Delete \"" + curr.Name + "\" from \"" + curr.Category + "\"?", MessageBoxButton.YesNoCancel, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
                    ((DataRowView)(lstSnippets.SelectedItem)).Delete();
                //snippetsDataSet.Tables["SnippetsTable"].Rows.Remove(lstSnippets.SelectedIndex);
            }
        }

        public static childItem FindVisualChild<childItem>(DependencyObject obj)
                where childItem : DependencyObject
        {
            // Search immediate children
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(obj, i);

                if (child is childItem)
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

        public Expander GetExpander(object ItemOfLstSnippet)
        {
            if (ItemOfLstSnippet as DataRowView == null) return null;
            foreach (CollectionViewGroup Group in lstSnippets.Items.Groups)
            {
                if (Group.Items.Contains(ItemOfLstSnippet))
                {
                    DependencyObject obj2 = lstSnippets.ItemContainerGenerator.ContainerFromItem(Group);
                    Expander obj22 = FindVisualChild<Expander>(obj2);
                    return obj22;
                }
            }
            return null;
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
            //make sure lstsnippets is update to date (i.e. just added r is shown)
            lstSnippets.UpdateLayout();
            //now find entry in lstsnippets that corresponds to the just added row r
            foreach(DataRowView lstEntry in lstSnippets.Items)
                if (lstEntry.Row == r)
                {
                    //get the expander of this entry in order to expand it.
                    Expander eee = GetExpander(lstEntry);
                    if (eee != null)
                        eee.IsExpanded = true;
                    else
                        eee = GetExpander(lstEntry);
                    //also select the just added entey.
                    lstSnippets.SelectedItem = lstEntry;
                    break;
                }

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

            if (!File.Exists(Helper.GetSettingsPath() + Consts.cSyntaxFile))
            {
                MessageBox.Show("Syntax definitions not found");
            }
            else
            {
                XmlReader r = new XmlTextReader(Helper.GetSettingsPath() + Consts.cSyntaxFile);
                txtSnippetCode.SyntaxHighlighting = HighlightingLoader.Load(r, null);  //HighlightingManager.Instance..GetDefinition("C#");
                txtSampleCode.SyntaxHighlighting = txtSnippetCode.SyntaxHighlighting;  //HighlightingManager.Instance..GetDefinition("C#");
                r.Close();
            }

            snippetsDataSet = ((SnippetsDataSet)(this.FindResource("snippetsDataSet")));
            snippetsTable = snippetsDataSet.Tables["SnippetsTable"] as SnippetsDataSet.SnippetsTableDataTable;
            snippetsTableViewSource = (CollectionViewSource)this.FindResource("snippetsTableViewSource");
            if (File.Exists(Helper.GetSettingsPath() + Consts.cSnippetsFile))
            {
                snippetsDataSet.ReadXml(Helper.GetSettingsPath() + Consts.cSnippetsFile);         // TODO: Program stops here...very strange ... due to images???
                snippetsTableViewSource.View.Refresh();
            }
        }

        private void cmdCompile_Click(object sender, RoutedEventArgs e)
        {
            if (lstSnippets.SelectedItem == null)
            {
                MessageBox.Show("Select an item from snippet table on the left!");
                return;
            }

            SnippetsDataSet.SnippetsTableRow r = ((DataRowView)lstSnippets.SelectedItem).Row as SnippetsDataSet.SnippetsTableRow;
            if (!r.IsNull(snippetsTable.SampleCodeColumn))
                fact.AddJob(r.SampleCode, Helper.GetSnippetsPath() + r.ID + Helper.GetSnippetsExt(), new Rect(0, 0, 0, 0), r.Name, true);
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
                snippetsDataSet.WriteXml(Helper.GetSettingsPath() + Consts.cSnippetsFile);
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
                        string cFile =  Helper.GetSnippetsPath() + r.ID;
                        if (mbres == MessageBoxResult.Yes || !File.Exists(cFile+".png"))
                            fact.AddJob(r.SampleCode, cFile + Helper.GetSnippetsExt(), new Rect(0, 0, 0, 0), r.Name, true);
                    }
                }
            }
        }

        private void Image_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                Close();
        }
    }

    public sealed class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
                              object parameter, CultureInfo culture)
        {
            try
            {
                string appPath = Helper.GetAppDir(); //System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
                string fullpath = Helper.GetSnippetsPath() + value.ToString() +".png";
                //string fullpath2 = fullpath.Substring(;
                BitmapImage bi = new BitmapImage();
                bi.BeginInit();
                if (File.Exists((new Uri(fullpath)).LocalPath))
                    bi.UriSource = new Uri(fullpath);
                else if (File.Exists(appPath+"unavailable.png"))
                    bi.UriSource = new Uri(appPath+"unavailable.png");
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
