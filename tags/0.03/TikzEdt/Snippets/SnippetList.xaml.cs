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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Data;


namespace TikzEdt.Snippets
{
    /// <summary>
    /// Interaction logic for SnippetList.xaml
    /// </summary>
    public partial class SnippetList : UserControl
    {        
        public delegate void InsertEventHandler(string code, string dependencies);
        public event InsertEventHandler OnInsert;

        readonly public static DependencyProperty ShowThumbnailsProperty = DependencyProperty.Register(
         "ShowThumbnails", typeof(bool), typeof(SnippetList), new PropertyMetadata(false));
        public bool ShowThumbnails
        {
            get { return (bool)GetValue(ShowThumbnailsProperty); }
            set { SetValue(ShowThumbnailsProperty, value); }
        }

        public SnippetList()
        {
            InitializeComponent();
        }

        SnippetsDataSet snippetsDataSet;
        CollectionViewSource snippetsTableViewSource;
        SnippetsDataSet.SnippetsTableDataTable snippetsTable;
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {            
            snippetsDataSet = ((SnippetsDataSet)(this.FindResource("snippetsDataSet")));
            snippetsTable = snippetsDataSet.Tables["SnippetsTable"] as SnippetsDataSet.SnippetsTableDataTable;
            snippetsTableViewSource = (CollectionViewSource)this.FindResource("snippetsTableViewSource");

            Reload();

            // Do Thumbnails exist? -> Recompile
            if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))  // we don't want this to happen in the vs designer
            if (!Directory.Exists(Helper.GetSnippetsPath()))
            {
                if (MessageBox.Show("The Snippet Thumbnails do not seem to exist. Do you want them to be created now?\r\nIt may take some time, but it will happen in the background. You can also recompile them later from the Snippet Manager.", "Compile Thumbnails", MessageBoxButton.YesNoCancel, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    // Compile
                    foreach (SnippetsDataSet.SnippetsTableRow r in snippetsTable.Rows)
                    {
                        if (!r.IsNull(snippetsTable.SampleCodeColumn))
                        {
                            string cFile = Helper.GetSnippetsPath() + r.ID;
                            TikzToBMPFactory.Instance.AddJob(r.SampleCode, cFile + ".tex", new Rect(0, 0, 0, 0), r.Name, true);
                        }
                    }
                }
            }            
        }

        public void Reload()
        {
            if (File.Exists(Helper.GetSettingsPath() + Consts.cSnippetsFile))
            {
                snippetsDataSet.Clear();
                snippetsDataSet.ReadXml(Helper.GetSettingsPath() + Consts.cSnippetsFile);
                snippetsTableViewSource.View.Refresh();
                //snippetsTableViewSource.SortDescriptions.Clear();
                //snippetsTableViewSource.SortDescriptions.Add(new System.ComponentModel.SortDescription("Category", System.ComponentModel.ListSortDirection.Ascending));
                //snippetsTableViewSource.SortDescriptions.Add(new System.ComponentModel.SortDescription("Name", System.ComponentModel.ListSortDirection.Ascending));
                //lstSnippets.ItemsSource = from rows in snippetsTable
                //                          orderby rows.Name
                //                          group rows by rows.Category into g
                //                          select g;
                                          //group rows by rows.Category into g
                                          //orderby g.Key
                                          //select g;
            }
        }

        private void lstSnippets_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lstSnippets.SelectedItem != null)
            {
                string c="", d="";
                SnippetsDataSet.SnippetsTableRow r = ((DataRowView)lstSnippets.SelectedItem).Row as SnippetsDataSet.SnippetsTableRow;
                if (!r.IsNull(snippetsTable.SnippetCodeColumn))
                    c = r.SnippetCode;
                if (!r.IsNull(snippetsTable.DependenciesColumn))
                    d = r.Dependencies;

                if (OnInsert!= null)
                    OnInsert(c,d);
            }
        }

        private void InsertSnippetClick(object sender, RoutedEventArgs e)
        {
            if (lstSnippets.SelectedItem != null)
            {
                string c="", d="";
                SnippetsDataSet.SnippetsTableRow r = ((DataRowView)lstSnippets.SelectedItem).Row as SnippetsDataSet.SnippetsTableRow;
                if (!r.IsNull(snippetsTable.SnippetCodeColumn))
                    c = r.SnippetCode;
                if (!r.IsNull(snippetsTable.DependenciesColumn))
                    d = r.Dependencies;

                if (OnInsert!= null)
                    OnInsert(c,d);
            }
        }

        private void InsertFullCodeClick(object sender, RoutedEventArgs e)
        {
            if (lstSnippets.SelectedItem != null)
            {
                string c = "", d = "";
                SnippetsDataSet.SnippetsTableRow r = ((DataRowView)lstSnippets.SelectedItem).Row as SnippetsDataSet.SnippetsTableRow;
                if (!r.IsNull(snippetsTable.SampleCodeColumn))
                    c = r.SampleCode;
                if (!r.IsNull(snippetsTable.DependenciesColumn))
                    d = r.Dependencies;

                if (OnInsert != null)
                    OnInsert(c, d);
            }
        }

        private void InsertDependenciesClick(object sender, RoutedEventArgs e)
        {
            if (lstSnippets.SelectedItem != null)
            {
                string d = "";
                SnippetsDataSet.SnippetsTableRow r = ((DataRowView)lstSnippets.SelectedItem).Row as SnippetsDataSet.SnippetsTableRow;
                if (!r.IsNull(snippetsTable.DependenciesColumn))
                    d = r.Dependencies;

                if (OnInsert != null)
                    OnInsert(d, d);
            }
        }
    }
}
