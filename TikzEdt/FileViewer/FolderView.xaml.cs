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
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Interop;
using System.ComponentModel;

namespace WpfApplication6
{
    /// <summary>
    /// Interaction logic for FolderView.xaml
    /// </summary>
    public partial class FolderView : UserControl
    {
        public static readonly DependencyProperty CurrentFolderProperty = DependencyProperty.Register("CurrentFolder", typeof(string), typeof(FolderView),
              new PropertyMetadata("", OnCurrentFolderChangedS));
        static void OnCurrentFolderChangedS(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as FolderView).PopulateView();
        }

        public string CurrentFolder
        {
            get { return (string)GetValue(CurrentFolderProperty); }
            set { SetValue(CurrentFolderProperty, value); }
        }

        public static readonly DependencyProperty AllowNavigationProperty = DependencyProperty.Register("AllowNavigation", typeof(bool), typeof(FolderView),
                new PropertyMetadata(false));

        public bool AllowNavigation
        {
            get { return (bool)GetValue(AllowNavigationProperty); }
            set { SetValue(AllowNavigationProperty, value); }
        }


        public ObservableCollection<FSItemVM> CurrentItems {get; set;}
        public ObservableStack<string> RecentFolders { get; set; }
        public ObservableStack<string> FutureFolders { get; set; }
        //bool AddToRecent = true;
        bool ClearFuture = true;

        void PopulateView()
        {
            CurrentItems.Clear();
            System.Drawing.Icon icon;
            icon = Etier.IconHelper.IconReader.GetFolderIcon(Etier.IconHelper.IconReader.IconSize.Small, Etier.IconHelper.IconReader.FolderType.Closed);

            try
            {

                foreach (string s in Directory.EnumerateDirectories(CurrentFolder))
                {
                    FSItemVM info = new FSItemVM()
                    {
                        FullPath = s,
                        DisplayName = System.IO.Path.GetFileName(s),
                        type = FSItemType.Folder,
                        DisplayIcon = Etier.IconHelper.IconReader.GetFolderIcon(s, Etier.IconHelper.IconReader.IconSize.Small, Etier.IconHelper.IconReader.FolderType.Closed).ToImageSource()
                    };
                    CurrentItems.Add(info);
                }
            } catch (Exception) {}

            try
            {
                foreach (string s in Directory.EnumerateFiles(CurrentFolder))
                {
                    FSItemVM info = new FSItemVM() { FullPath = s, DisplayName = System.IO.Path.GetFileName(s), type = FSItemType.File };
                    try
                    {
                        icon = Etier.IconHelper.IconReader.GetFileIcon(info.FullPath, Etier.IconHelper.IconReader.IconSize.Small, false);
                        info.DisplayIcon = icon.ToImageSource();
                    }
                    catch (Exception)
                    {
                        info.DisplayIcon = null;
                    }
                    CurrentItems.Add(info);
                }
            }
            catch (Exception) { }

            if (RecentFolders.Count == 0 || String.Compare(CurrentFolder, RecentFolders.Last()) != 0)
                RecentFolders.Push(CurrentFolder);
            if (ClearFuture)
                FutureFolders.Clear();
        }

        public FolderView()
        {
            InitializeComponent();
            CurrentItems = new ObservableCollection<FSItemVM>();
            RecentFolders = new ObservableStack<string>();
            FutureFolders = new ObservableStack<string>();
            DataContext = this;
           // Directory.EnumerateFileSystemEntries
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            CurrentFolder = Directory.GetCurrentDirectory();
        }

        protected void HandleDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (AllowNavigation)
            {
                //((ListViewItem)sender).
                FSItemVM info =((ListViewItem)sender).Content as FSItemVM; //.Content as Track; //Casting back to the binded Track
                if (info.type == FSItemType.Folder)
                {
                    CurrentFolder = info.FullPath;
                }
            }
        }

        private void cmdUp_Click(object sender, RoutedEventArgs e)
        {
            string[] dirs = CurrentFolder.Split(new char[] {System.IO.Path.DirectorySeparatorChar}, StringSplitOptions.RemoveEmptyEntries);
            if (dirs.Length > 1)
            {
                string newf = String.Join(System.IO.Path.DirectorySeparatorChar.ToString(), dirs, 0, dirs.Length - 1);
                if (dirs.Length == 2)
                    newf += System.IO.Path.DirectorySeparatorChar;
                CurrentFolder = newf;
            }
            
        }

        private void cmdBack_Click(object sender, RoutedEventArgs e)
        {
            if (RecentFolders.Count > 1)
            {
                //AddToRecent = false;
                FutureFolders.Push(RecentFolders.Pop()); // top of stack is current folder
                ClearFuture = false;
                CurrentFolder = RecentFolders.Pop();
                ClearFuture = true;
                //AddToRecent = true;
            }
        }

        private void cmdForward_Click(object sender, RoutedEventArgs e)
        {
            if (FutureFolders.Count > 0)
            {
                //AddToRecent = false;
                //RecentFolders.Pop(); // top of stack is current folder
                ClearFuture = false;
                CurrentFolder = FutureFolders.Pop();
                ClearFuture = true;
                //AddToRecent = true;
            }
        }

    }

    public class ObservableStack<T> : ObservableCollection<T>
    {
        public virtual void Push(T item)
        {
            Add(item);
        }
        public virtual T Pop()
        {
            T item = this.Last();
            RemoveAt(this.Count-1);
            return item;
        }
    }

    public enum FSItemType { Folder, File }
    public class FSItemVM
    {
        public string DisplayName { get; set; }
        public string FullPath { get; set; }
        public FSItemType type { get; set; }
        public ImageSource DisplayIcon { get; set; }

        public int Indentation { get; set; }

        public override string ToString()
        {
            return FullPath;
        }
    }

    internal static class IconUtilities
    {
        [DllImport("gdi32.dll", SetLastError = true)]
        private static extern bool DeleteObject(IntPtr hObject);

        public static ImageSource ToImageSource(this Icon icon)
        {
            Bitmap bitmap = icon.ToBitmap();
            IntPtr hBitmap = bitmap.GetHbitmap();

            ImageSource wpfBitmap = Imaging.CreateBitmapSourceFromHBitmap(
                hBitmap,
                IntPtr.Zero,
                Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());

            if (!DeleteObject(hBitmap))
            {
                throw new Win32Exception();
            }

            return wpfBitmap;
        }
    }

    [ValueConversion(typeof(int), typeof(bool))]
    public class IntToBoolConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            if (targetType != typeof(bool))
                throw new InvalidOperationException("The target must be a boolean");

            return ((int)value > Int32.Parse(parameter.ToString()));
        }

        public object ConvertBack(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
