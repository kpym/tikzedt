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
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.Collections;

namespace TikzEdt.Snippets
{
    /// <summary>
    /// Interaction logic for SnippetImporter.xaml
    /// </summary>
    public partial class SnippetImporter : Window
    {


        public ObservableCollection<CodeSnippet> snippetList
        {
            get { return (ObservableCollection<CodeSnippet>)GetValue(snippetListProperty); }
            set { SetValue(snippetListProperty, value); }
        }

        // Using a DependencyProperty as the backing store for snippetList.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty snippetListProperty =
            DependencyProperty.Register("snippetList", typeof(ObservableCollection<CodeSnippet>), typeof(SnippetImporter), new UIPropertyMetadata(null));

        
        //ObservableCollection<CodeSnippet> snippetList {get; set;}

        SnippetsDataSet.SnippetsTableDataTable SnippTable; // the current snippet database, before importing anything

        public SnippetImporter(SnippetsDataSet.SnippetsTableDataTable st)
        {
            snippetList = new ObservableCollection<CodeSnippet>();
            InitializeComponent();
            DataContext = this;
            SnippTable = st;
        }

        private void LoadFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "";
            ofd.InitialDirectory = Helper.GetSettingsPath();
            ofd.ValidateNames = true;
            ofd.CheckFileExists = true;

            if (ofd.ShowDialog() == true)
            {
                // load snippets data
                SnippetsDataSet sd = new SnippetsDataSet();
                try
                {
                   // sd.ReadXmlSchema("Snippets\\SnippetsDataSet.xsd");
                    sd.ReadXml(ofd.FileName);

                    snippetList.Clear();
                    txtImportedFile.Clear();

                    foreach (SnippetsDataSet.SnippetsTableRow r in sd.SnippetsTable)
                        snippetList.Add(new CodeSnippet(r));

                    FindDuplicates();

                    txtImportedFile.Text = ofd.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read snippet data from file \"" + ofd.FileName + "\"." + Environment.NewLine + ex.Message, "Error loading snippets file.", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }

        }

        /// <summary>
        /// Finds items in the current snippet list that are already there in the 
        /// current snippet database and marks them as such.
        /// Note: duplicates based on category+name
        /// </summary>
        void FindDuplicates()
        {
            
            foreach (CodeSnippet s in snippetList)
            {
                SnippetsDataSet.SnippetsTableRow r = SnippTable.Cast< SnippetsDataSet.SnippetsTableRow>().FirstOrDefault(rr => rr.Category == s.Category && rr.Name == s.Name);
                if (r != null)
                {
                    s.IsAlreadyThere = true;
                    s.tag = r;
    
                    // Check if changed
                    s.IsChanged =!(
                        StrCompare(s.Description , (r.IsNull(SnippTable.DescriptionColumn) ? null : r.Description)) &&
                        StrCompare(s.SnippetCode , (r.IsNull(SnippTable.SnippetCodeColumn) ? null : r.SnippetCode)) &&
                        StrCompare(s.SampleCode , (r.IsNull(SnippTable.SampleCodeColumn) ? null : r.SampleCode)) &&
                        StrCompare(s.NodeStyle , (r.IsNull(SnippTable.NodeStyleColumn) ? null : r.NodeStyle)) &&
                        StrCompare(s.EdgeStyle , (r.IsNull(SnippTable.EdgeStyleColumn) ? null : r.EdgeStyle)) &&
                        StrCompare(s.Dependencies , (r.IsNull(SnippTable.DependenciesColumn) ? null : r.Dependencies)));
    
                }
            }
        }
        bool StrCompare(string s1, string s2)
        {
            if (s1 == null) s1 = "";
            if (s2 == null) s2 = "";
            return String.Compare(s1, s2) == 0;
        }

        private void Import_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("This will import the selected styles. There is no going back. Are you sure?", "Import", MessageBoxButton.YesNoCancel, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                // step 1: import changed items
                foreach (CodeSnippet s in snippetList )
                    if (s.IsSelected && s.IsAlreadyThere && s.IsChanged)
                    {
                        s.FillRow(s.tag);
                    }

                // step 2: add new items
                foreach (CodeSnippet s in snippetList )
                    if (s.IsSelected && !s.IsAlreadyThere)
                    {
                        SnippetsDataSet.SnippetsTableRow r = SnippTable.NewSnippetsTableRow();
                        s.FillRow(r);
                        SnippTable.Rows.Add(r);
                    }

                DialogResult = true;
                Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            foreach (CodeSnippet s in snippetList)
                s.IsSelected = true;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            foreach (CodeSnippet s in snippetList)
                s.IsSelected = false;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            foreach (CodeSnippet s in snippetList)
                s.IsSelected = !s.IsAlreadyThere;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            foreach (CodeSnippet s in snippetList)
                s.IsSelected = s.IsChanged;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

    }

    public class CodeSnippet : DependencyObject
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string SampleCode { get; set; }
        public string SnippetCode { get; set; }
        public string EdgeStyle { get; set; }
        public string NodeStyle { get; set; }
        public string Dependencies { get; set; }

        public bool IsAlreadyThere { get; set; }
        public bool IsChanged { get; set; }

        public string DisplayName { get { return Name + (IsChanged?" *":""); } }
        public Brush DisplayColor { get { return IsAlreadyThere?Brushes.Black:Brushes.Red; } }

        public bool IsSelected
        {
            get { return (bool)GetValue(IsSelectedProperty); }
            set { SetValue(IsSelectedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsSelected.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsSelectedProperty =
            DependencyProperty.Register("IsSelected", typeof(bool), typeof(CodeSnippet), new UIPropertyMetadata(false));

        public SnippetsDataSet.SnippetsTableRow tag; // used to remember the datatable row to be changed, if applicable

        public CodeSnippet( SnippetsDataSet.SnippetsTableRow r )
        {
            Name = r.Name;
            Category = r.Category;            
            Description = r.Description;
            SampleCode = r.SampleCode;
            SnippetCode = r.SnippetCode;
            EdgeStyle = r.IsEdgeStyleNull()?"":r.EdgeStyle;
            NodeStyle = r.IsNodeStyleNull() ? "" : r.NodeStyle;
            Dependencies = r.Dependencies;

            IsSelected = false;
            IsAlreadyThere = false; 
            IsChanged = false;
        }

        public void FillRow(SnippetsDataSet.SnippetsTableRow r)
        {
            r.Name = Name;
            r.Category = Category;
            r.Description = Description;
            r.SampleCode = SampleCode;
            r.SnippetCode = SnippetCode;
            r.EdgeStyle = EdgeStyle;
            r.NodeStyle = NodeStyle;
            r.Dependencies = Dependencies;
        }
    }


}
