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
using System.Diagnostics;

namespace TikzEdt
{
    /// <summary>
    /// Interaction logic for TipsTricksWindow.xaml
    /// </summary>
    public partial class TipsTricksWindow : Window
    {
        public TipsTricksWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.ShowTipsTricksWindow = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void Hyperlink_RequestNavigate_ExeFolder(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            // executes a file in exe folder 
            try
            {
                Process.Start(new ProcessStartInfo(System.IO.Path.Combine(Helper.GetAppDir(), e.Uri.OriginalString)));
            }
            catch (Exception )
            {
                MessageBox.Show(this, "Could not start " + e.Uri.OriginalString + ". Maybe the installation is broken.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            e.Handled = true;
        }
    }
}
