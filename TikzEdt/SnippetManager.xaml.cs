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

namespace TikzEdt
{
    /// <summary>
    /// Interaction logic for SnippetManager.xaml
    /// </summary>
    public partial class SnippetManager : Window
    {
        public SnippetManager()
        {
            InitializeComponent();
            string appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
            xmldp.Source = new Uri(appPath + @"\Snippets.xml");
        }



        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            string source = xmldp.Source.LocalPath;
            xmldp.Document.Save(source);

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string source = xmldp.Source.LocalPath;
            xmldp.Document.Save(source);
        }
    }
}
