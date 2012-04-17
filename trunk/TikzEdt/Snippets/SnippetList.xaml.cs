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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Data;


namespace TikzEdt.Snippets
{
    /// <summary>
    /// Interaction logic for SnippetList.xaml
    /// </summary>
    public partial class SnippetList : UserControl, ISnippetListView
    {
        public SnippetListModel TheModel { get; private set; }

        #region Exposed Events
        //public delegate void InsertEventHandler(string code, string dependencies);
        public event EventHandler<InsertEventArgs> OnInsert;

        public event EventHandler<UseStylesEventArgs> OnUseStyles;

        #endregion

        #region Properties
        readonly public static DependencyProperty ShowThumbnailsProperty = DependencyProperty.Register(
         "ShowThumbnails", typeof(bool), typeof(SnippetList), new PropertyMetadata(true));
        public bool ShowThumbnails
        {
            get { return (bool)GetValue(ShowThumbnailsProperty); }
            set { SetValue(ShowThumbnailsProperty, value); }
        }

        public double ThumbnailSize
        {
            get { return (double)GetValue(ThumbnailSizeProperty); }
            set { SetValue(ThumbnailSizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ThumbnailSize.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ThumbnailSizeProperty =
            DependencyProperty.Register("ThumbnailSize", typeof(double), typeof(SnippetList), new UIPropertyMetadata(40.0));

        #endregion


        public SnippetList()
        {
            InitializeComponent();

            TheModel = new SnippetListModel(this);

            // there is a binding problem (bug) that makes the following line necessary
            NameScope.SetNameScope(contextMenu, NameScope.GetNameScope(this));

        }

        //SnippetsDataSet snippetsDataSet;
        CollectionViewSource snippetsTableViewSource;
        //SnippetsDataSet.SnippetsTableDataTable snippetsTable;
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {            
     //       snippetsDataSet = ((SnippetsDataSet)(this.FindResource("snippetsDataSet")));
     //       snippetsTable = snippetsDataSet.Tables["SnippetsTable"] as SnippetsDataSet.SnippetsTableDataTable;
            snippetsTableViewSource = (CollectionViewSource)this.FindResource("snippetsTableViewSource");
            // add source binding
            Binding b = new Binding("SnippetsTable")
            {
                Source = TheModel.snippetsDataSet
            };
            BindingOperations.SetBinding(snippetsTableViewSource, CollectionViewSource.SourceProperty, b);

            TheModel.Reload();

            if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))  // we don't want this to happen in the vs designer
               TheModel.CheckForThumbnails();
 
        }

        private void lstSnippets_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lstSnippets.SelectedItem != null)
            {
                SnippetsDataSet.SnippetsTableRow r = ((DataRowView)lstSnippets.SelectedItem).Row as SnippetsDataSet.SnippetsTableRow;
                TheModel.HandleMouseDoubleClick(r);
            }
        }

        private void InsertSnippetClick(object sender, RoutedEventArgs e)
        {
            if (lstSnippets.SelectedItem != null)
            {
                SnippetsDataSet.SnippetsTableRow r = ((DataRowView)lstSnippets.SelectedItem).Row as SnippetsDataSet.SnippetsTableRow;
                TheModel.HandleInsertSnippetClick(r);
            }
        }

        private void InsertFullCodeClick(object sender, RoutedEventArgs e)
        {
            if (lstSnippets.SelectedItem != null)
            {
                SnippetsDataSet.SnippetsTableRow r = ((DataRowView)lstSnippets.SelectedItem).Row as SnippetsDataSet.SnippetsTableRow;
                TheModel.HandleInsertFullCodeClick(r);
            }
        }

        private void InsertDependenciesClick(object sender, RoutedEventArgs e)
        {
            if (lstSnippets.SelectedItem != null)
            {
                SnippetsDataSet.SnippetsTableRow r = ((DataRowView)lstSnippets.SelectedItem).Row as SnippetsDataSet.SnippetsTableRow;
                TheModel.HandleInsertDependenciesClick(r);
            }
        }

        private void InsertAsTikzStyle_Click(object sender, RoutedEventArgs e)
        {
            // find row corresponding to clicked button
            object curItem = ((ListBoxItem)lstSnippets.ContainerFromElement((Button)sender)).Content;
            if (curItem != null)
            {
                SnippetsDataSet.SnippetsTableRow r = (curItem as DataRowView).Row as SnippetsDataSet.SnippetsTableRow;
                TheModel.HandleInsertAsTikzStyleClick(r);
            }
            
        }

        private void UseStyleButton_Click(object sender, RoutedEventArgs e)
        {
            // find row corresponding to clicked button
            object curItem = ((ListBoxItem)lstSnippets.ContainerFromElement((Button)sender)).Content;
            if (curItem != null)
            {
                SnippetsDataSet.SnippetsTableRow r = (curItem as DataRowView).Row as SnippetsDataSet.SnippetsTableRow;
                TheModel.HandleUseStyleButtonClick(r);
            }
        }

        void ISnippetListView.Refresh()
        {
            snippetsTableViewSource.View.Refresh();
        }


        void ISnippetListView.RaiseOnInsert(InsertEventArgs e)
        {
            if (OnInsert != null)
                OnInsert(this, e);
        }

        void ISnippetListView.RaiseOnUseStyle(UseStylesEventArgs e)
        {
            if (OnUseStyles != null)
                OnUseStyles(this, e);
        }
    }

    /// <summary>
    /// Returns visible iff one of the strings is nonempty (and non-null)
    /// </summary>
    public class StringToVisibilityConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType,
                              object parameter, System.Globalization.CultureInfo culture)
        {
            if ((values[0] is string && values[0].ToString().Trim() != "") || (values[1] is string && values[1].ToString().Trim() != ""))
                return Visibility.Visible;
            else
                return Visibility.Collapsed;
        }

        public object[] ConvertBack(object value, Type[] targetType,
                                  object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
