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
using System.Collections;
using System.Globalization;
//using Microsoft.WindowsAPICodePack.Shell;

namespace FileListView
{
    /// <summary>
    /// Interaction logic for FolderComboBox.xaml
    /// </summary>
    public partial class FolderComboBox : ComboBox
    {
        public static readonly DependencyProperty RecentLocationsProperty = DependencyProperty.Register("RecentLocations",
            typeof(IEnumerable), typeof(FolderComboBox),
        new PropertyMetadata(null));
        public IEnumerable RecentLocations
        {
            get { return (IEnumerable)GetValue(RecentLocationsProperty); }
            set { SetValue(RecentLocationsProperty, value); }
        }

        public static readonly DependencyProperty CurrentFolderProperty = DependencyProperty.Register("CurrentFolder", typeof(string), typeof(FolderComboBox),
                new PropertyMetadata(""));
        public string CurrentFolder
        {
            get { return (string)GetValue(CurrentFolderProperty); }
            set { SetValue(CurrentFolderProperty, value); }
        }

        public ObservableCollection<FSItemVM> CurrentItems { get; set; }

        void PopulateView()
        {
            //CurrentItems.Clear();
            string bak = CurrentFolder;
            var CurrentItems = Items;
            Items.Clear();
            CurrentFolder = bak;

            // add special folders
            CurrentItems.Add(new FSItemVM()
                {
                    FullPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                    DisplayName = "Desktop", //System.IO.Path.GetFileName(s),
                    type = FSItemType.Folder,
                    //DisplayIcon = 
                    //IconExtractor.GetFolderIcon(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)).ToImageSource()
                    //new BitmapImage(new Uri(@"/FileListView;component/Images/Desktop.png", UriKind.Relative)) //((ShellObject)o).Thumbnail.SmallBitmapSource//Etier.IconHelper.IconReader.GetFolderIcon(s, Etier.IconHelper.IconReader.IconSize.Small, Etier.IconHelper.IconReader.FolderType.Closed).ToImageSource()
                }
                );
            CurrentItems.Add(new FSItemVM()
                {
                    FullPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    DisplayName = "My Documents", //System.IO.Path.GetFileName(s),
                    type = FSItemType.Folder,
                    //DisplayIcon = IconExtractor.GetFolderIcon(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), true).ToImageSource()
                    //new BitmapImage(new Uri(@"/FileListView;component/Images/MyDocuments.png", UriKind.Relative)) //((ShellObject)o).Thumbnail.SmallBitmapSource//Etier.IconHelper.IconReader.GetFolderIcon(s, Etier.IconHelper.IconReader.IconSize.Small, Etier.IconHelper.IconReader.FolderType.Closed).ToImageSource()
                }
                );
            // The commented out code can be used with Microsofts Shell API Codepack
            //ShellObject o = (ShellObject)KnownFolders.Desktop;
           /* foreach (IKnownFolder o in new IKnownFolder[] { KnownFolders.Desktop, KnownFolders.Documents })
            {
                //string s = o. //Environment.GetFolderPath(spf);
                FSItemVM info = new FSItemVM()
                {
                    FullPath = o.Path,
                    DisplayName = o.LocalizedName, //System.IO.Path.GetFileName(s),
                    type = FSItemType.Folder,
                    DisplayIcon = ((ShellObject)o).Thumbnail.SmallBitmapSource//Etier.IconHelper.IconReader.GetFolderIcon(s, Etier.IconHelper.IconReader.IconSize.Small, Etier.IconHelper.IconReader.FolderType.Closed).ToImageSource()
                };
                CurrentItems.Add(info);
                //((ShellObject)o).Thumbnail.SmallBitmap.Save(o.LocalizedName + ".png");
            }*/

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

            CurrentItems.Add(null);     // add a separator
            // add drives
            string pathroot;
            try { pathroot = System.IO.Path.GetPathRoot(CurrentFolder); }
            catch (Exception) { pathroot = ""; }

            foreach (string s in Directory.GetLogicalDrives())
            {
                FSItemVM info = new FSItemVM()
                {
                    FullPath = s,
                    DisplayName = s,
                    type = FSItemType.Folder,
                    DisplayIcon = IconExtractor.GetFolderIcon(s).ToImageSource()
                };
                CurrentItems.Add(info);

                // add items under current folder
                if (String.Compare(pathroot,s,true) == 0)
                {
                    string[] dirs = CurrentFolder.Split(new char[] {System.IO.Path.DirectorySeparatorChar}, StringSplitOptions.RemoveEmptyEntries);                    
                    for (int i = 1; i < dirs.Length; i++)
                    {
                        string curdir = String.Join(""+System.IO.Path.DirectorySeparatorChar, dirs, 0, i+1);
                        info = new FSItemVM()
                        {
                            FullPath = curdir,
                            DisplayName = dirs[i],
                            type = FSItemType.Folder,
                            DisplayIcon = IconExtractor.GetFolderIcon(curdir, true).ToImageSource(),
                            Indentation = i*10
                        };
                        CurrentItems.Add(info);
                    }
                    SelectedItem = CurrentItems[CurrentItems.Count-1];
                }
            }

            CurrentItems.Add(null); 

            // add recent locations
            if (RecentLocations != null)
            {
                List<string> fullpaths = new List<string>();    // remember paths to avoid adding duplicates
                foreach (object o in RecentLocations)
                {
                    string s = o.ToString();
                    s = System.IO.Path.GetDirectoryName(s);
                    if (!fullpaths.Contains(s))
                    {
                        fullpaths.Add(s);
                        FSItemVM it = new FSItemVM()
                        {
                            FullPath = s,
                            ShowToolTip = true,
                            DisplayName = System.IO.Path.GetFileName(s),
                            type = FSItemType.Folder,
                            DisplayIcon = IconExtractor.GetFolderIcon(s).ToImageSource()
                        };
                        if (it.DisplayName.Trim() == "")
                            it.DisplayName = it.FullPath;
                        CurrentItems.Add(it);
                    }
                }
            }
        }

        public FolderComboBox()
        {
            InitializeComponent();
            CurrentItems = new ObservableCollection<FSItemVM>();
            SetBinding(TextProperty, new Binding("CurrentFolder") { Source = this });
            SetBinding(ToolTipProperty, new Binding("CurrentFolder") { Source = this });            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           /* if (SelectedItem != null)
            {
                FSItemVM item = SelectedItem as FSItemVM;
                CurrentFolder = item.FullPath;
            } */
        }

        private void ComboBox_KeyDown(object sender, KeyEventArgs e)
        {
           /* if (e.Key == Key.Return)
                if (Directory.Exists(Text))
                    CurrentFolder = Text; */
        }

        private void ComboBox_DropDownOpened(object sender, EventArgs e)
        {
            PopulateView();
        }
    }
}
