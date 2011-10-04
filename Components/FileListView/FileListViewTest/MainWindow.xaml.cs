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
using FileListView;
using System.Collections.ObjectModel;
using Microsoft.Win32;

namespace FileListViewTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> RecentFiles { get; set; }
        public MainWindow()
        {
            RecentFiles = new ObservableCollection<string>();
            RecentFiles.Add("C:\\temp\\");
            RecentFiles.Add("C:\\windows\\system\\test.txt");
            DataContext = this;

            InitializeComponent();
    
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Multiselect=true };
            if (ofd.ShowDialog() == true)
                foreach (string s in ofd.FileNames)
                    RecentFiles.Add(s);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (lstRecent.SelectedIndex >= 0)
                RecentFiles.RemoveAt(lstRecent.SelectedIndex);
        }

        private void folderView1_OnFileOpen(object sender, FListView.FileOpenEventArgs e)
        {
            // several commands possible
            if (e.CommandParameter == null)
                MessageBox.Show("File: " + e.FileName + " selected.");
            else if ((string)e.CommandParameter == "1")
                MessageBox.Show("File: " + e.FileName + " selected with alternate open command.");
        }
    }


}
