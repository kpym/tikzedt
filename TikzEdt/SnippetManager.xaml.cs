using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Globalization;

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
            if (lstSnippets.SelectedIndex >= 0)
            {
                SnippetsDataSet.SnippetsTableRow curr = ((DataRowView)(lstSnippets.SelectedItem)).Row as SnippetsDataSet.SnippetsTableRow;
                r.Category = curr.Category;
            }
            snippetsTable.Rows.Add(r);         
        }

        TikzEdt.SnippetsDataSet snippetsDataSet;
        CollectionViewSource snippetsTableViewSource;
        SnippetsDataSet.SnippetsTableDataTable snippetsTable;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            snippetsDataSet = ((TikzEdt.SnippetsDataSet)(this.FindResource("snippetsDataSet")));
            snippetsTable = snippetsDataSet.Tables["SnippetsTable"] as SnippetsDataSet.SnippetsTableDataTable;
            snippetsTableViewSource = (CollectionViewSource)this.FindResource("snippetsTableViewSource");
            if (File.Exists("TheSnippets.xml"))
                snippetsDataSet.ReadXml("TheSnippets.xml");
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
                fact.AddJob(r.SampleCode, "img\\"+r.ID, new Rect(0,0,4,4));
            }
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
}
