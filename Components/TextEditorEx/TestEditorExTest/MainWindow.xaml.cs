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
using System.Collections.ObjectModel;

namespace TestEditorExTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> SomeStyles { get; private set; }

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;

            SomeStyles = new ObservableCollection<string>();
            SomeStyles.Add("foo");
            SomeStyles.Add("foo bar ");
            SomeStyles.Add("HelloWorld");

            txtCode.Text="\\begin{tikzpicture}"+Environment.NewLine +Environment.NewLine+ "\\end{tikzpicture}";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SomeStyles.Add(txtText.Text);
        }
    }
}
