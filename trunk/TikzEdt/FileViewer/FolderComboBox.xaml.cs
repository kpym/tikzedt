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
using System.IO;
using Microsoft.WindowsAPICodePack.Shell;

namespace WpfApplication6
{
    /// <summary>
    /// Interaction logic for FolderComboBox.xaml
    /// </summary>
    public partial class FolderComboBox : ComboBox
    {

        public static readonly DependencyProperty CurrentFolderProperty = DependencyProperty.Register("CurrentFolder", typeof(string), typeof(FolderComboBox),
                new PropertyMetadata("", OnCurrentFolderChangedS));
        static void OnCurrentFolderChangedS(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as FolderComboBox).PopulateView();
        }

        public string CurrentFolder
        {
            get { return (string)GetValue(CurrentFolderProperty); }
            set { SetValue(CurrentFolderProperty, value); }
        }

        public ObservableCollection<FSItemVM> CurrentItems { get; set; }

        void PopulateView()
        {
            CurrentItems.Clear();
            System.Drawing.Icon icon;
            icon = Etier.IconHelper.IconReader.GetFolderIcon(Etier.IconHelper.IconReader.IconSize.Small, Etier.IconHelper.IconReader.FolderType.Closed);

            // add special folders
            //ShellObject o = (ShellObject)KnownFolders.Desktop;
            foreach (IKnownFolder o in new IKnownFolder[] { KnownFolders.Desktop, KnownFolders.Documents })
            {
                //string s = o. //Environment.GetFolderPath(spf);
                FSItemVM info = new FSItemVM()
                {
                    FullPath = o.Path,
                    DisplayName = o.LocalizedName, //System.IO.Path.GetFileName(s),
                    type = FSItemType.Folder,
                    DisplayIcon = ((ShellObject)o).Thumbnail.BitmapSource//Etier.IconHelper.IconReader.GetFolderIcon(s, Etier.IconHelper.IconReader.IconSize.Small, Etier.IconHelper.IconReader.FolderType.Closed).ToImageSource()
                };
                CurrentItems.Add(info);
            }
            /*foreach (ShellObject o in KnownFolders.Desktop)
            {
                FSItemVM info = new FSItemVM()
                {
                    FullPath = o.ParsingName,
                    DisplayName = o.Name, //System.IO.Path.GetFileName(s),
                    type = FSItemType.Folder,
                    DisplayIcon = ((ShellObject)o).Thumbnail.BitmapSource//Etier.IconHelper.IconReader.GetFolderIcon(s, Etier.IconHelper.IconReader.IconSize.Small, Etier.IconHelper.IconReader.FolderType.Closed).ToImageSource()
                };
                CurrentItems.Add(info);
            }*/
            
            // add drives
            foreach (string s in Directory.GetLogicalDrives())
            {
                FSItemVM info = new FSItemVM()
                {
                    FullPath = s,
                    DisplayName = s,//System.IO.Path.GetFileName(s),
                    type = FSItemType.Folder,
                    DisplayIcon = Etier.IconHelper.IconReader.GetFolderIcon(s, Etier.IconHelper.IconReader.IconSize.Small, Etier.IconHelper.IconReader.FolderType.Closed).ToImageSource()
                };
                CurrentItems.Add(info);

                // add items under current folder
                if (String.Compare(System.IO.Path.GetPathRoot(CurrentFolder),s,true) == 0)
                {
                    string[] dirs = CurrentFolder.Split(new char[] {System.IO.Path.DirectorySeparatorChar}, StringSplitOptions.RemoveEmptyEntries);                    
                    for (int i = 1; i < dirs.Length; i++)
                    {
                        string curdir = String.Join(""+System.IO.Path.DirectorySeparatorChar, dirs, 0, i+1);
                        info = new FSItemVM()
                        {
                            FullPath = curdir,
                            DisplayName = dirs[i],//System.IO.Path.GetFileName(s),
                            type = FSItemType.Folder,
                            DisplayIcon = Etier.IconHelper.IconReader.GetFolderIcon(curdir, Etier.IconHelper.IconReader.IconSize.Small, Etier.IconHelper.IconReader.FolderType.Closed).ToImageSource(),
                            Indentation = i*10
                        };
                        CurrentItems.Add(info);
                    }
                    SelectedItem = CurrentItems[CurrentItems.Count-1];
                }
            }            
        }

        public FolderComboBox()
        {

            InitializeComponent();
            CurrentItems = new ObservableCollection<FSItemVM>();

            SetBinding(ItemsSourceProperty, new Binding("CurrentItems") { Source=this });

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SelectedItem != null)
            {
                FSItemVM item = SelectedItem as FSItemVM;
                CurrentFolder = item.FullPath;
            }
        }

        private void ComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
                if (Directory.Exists(Text))
                    CurrentFolder = Text;
        }
    }
}
