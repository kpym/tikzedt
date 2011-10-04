using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Media;
using System.Windows.Input;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Interop;
using System.Windows;
using System.Windows.Media.Imaging;
using System.ComponentModel;

namespace FileListView
{
    class FileListViewVM
    {
        public ObservableCollection<FSItemVM> CurrentItems { get; set; }
        // The "undo and redo stacks" for navigation
        public ObservableStack<string> RecentFolders { get; set; }
        public ObservableStack<string> FutureFolders { get; set; }

        /// <summary>
        /// Determines whether the redo stack (FutureFolders) should be cleared when the CurrentFolder changes next time
        /// </summary>
        bool ClearFuture = true;

        string[] FilterList { get { return FV.Filter.Split('|'); } } // todo
        int FilterCount
        {
            get
            {
                if (FV.Filter == null) return 0;
                return FilterList.Length;
            }
        }

        /// <summary>
        /// The link to the control.
        /// (Yes, this is not MVVM.... )
        /// </summary>
        FListView FV;

        public FileListViewVM(FListView parent)
        {
            CurrentItems = new ObservableCollection<FSItemVM>();
            RecentFolders = new ObservableStack<string>();
            FutureFolders = new ObservableStack<string>();

            FV = parent;
        }

        /// <summary>
        /// Fills the ListView, or rather CurrentItems
        /// </summary>
        public void PopulateView()
        {
            CurrentItems.Clear();
            if (!Directory.Exists(FV.CurrentFolder))
                return;

            try
            {
                DirectoryInfo cur = new DirectoryInfo(FV.CurrentFolder);
                ImageSource dummy = new BitmapImage();
                if (FV.ShowFolders)
                {
                    foreach (DirectoryInfo dir in cur.GetDirectories())
                    {
                        if (!FV.ShowHidden && dir.Attributes.HasFlag(FileAttributes.Hidden))
                            continue;
                        FSItemVM info = new FSItemVM()
                        {
                            FullPath = dir.FullName,
                            DisplayName = dir.Name,
                            type = FSItemType.Folder
                        };
                        if (!FV.ShowIcons)
                            info.DisplayIcon = dummy;  // to prevent the icon from being loaded from file later
                        CurrentItems.Add(info);
                    }
                }

                string FilterString = "*";
                if (FV.FilterIndex >= 0 && FV.FilterIndex < FilterCount)
                    FilterString = FilterList[FV.FilterIndex].ToString();
                foreach (var CurFilterString in FilterString.Split(';'))
                foreach (FileInfo f in cur.EnumerateFiles(CurFilterString))
                {
                    if (!FV.ShowHidden && f.Attributes.HasFlag(FileAttributes.Hidden))
                        continue;

                    FSItemVM info = new FSItemVM()
                    {
                        FullPath = f.FullName,
                        DisplayName = f.Name, //System.IO.Path.GetFileName(s),
                        type = FSItemType.File
                    };
                    if (!FV.ShowIcons)
                        info.DisplayIcon = dummy;  // to prevent the icon from being loaded from file later
                    CurrentItems.Add(info);
                }
            }
            catch (Exception) { }

            // reset column width manually (otherwise it is not updated)
            FV.TheGVColumn.Width = FV.TheGVColumn.ActualWidth;
            FV.TheGVColumn.Width = Double.NaN;

            if (RecentFolders.Count == 0 || String.Compare(FV.CurrentFolder, RecentFolders.Last()) != 0)
                if (Directory.Exists(FV.CurrentFolder))
                {
                    RecentFolders.Push(FV.CurrentFolder);
                    if (ClearFuture)
                        FutureFolders.Clear();
                }
        }

        public void Back()
        {
            if (RecentFolders.Count > 1)
            {
                FutureFolders.Push(RecentFolders.Pop()); // top of stack is always last valid folder
                ClearFuture = false;
                FV.CurrentFolder = RecentFolders.Pop();
                ClearFuture = true;
            }
        }

        public void Forward()
        {
            if (FutureFolders.Count > 0)
            {
                ClearFuture = false;
                FV.CurrentFolder = FutureFolders.Pop();
                ClearFuture = true;
            }
        }

        public void Up()
        {
            string[] dirs = FV.CurrentFolder.Split(new char[] { System.IO.Path.DirectorySeparatorChar }, StringSplitOptions.RemoveEmptyEntries);
            if (dirs.Length > 1)
            {
                string newf = String.Join(System.IO.Path.DirectorySeparatorChar.ToString(), dirs, 0, dirs.Length - 1);
                if (dirs.Length == 2)
                    newf += System.IO.Path.DirectorySeparatorChar;
                FV.CurrentFolder = newf;
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
            RemoveAt(this.Count - 1);
            return item;
        }
    }

    public enum FSItemType { Folder, File }
    /// <summary>
    /// The Viewmodel for file system items
    /// </summary>
    public class FSItemVM
    {
        public string DisplayName { get; set; }
        public string FullPath { get; set; }
        public FSItemType type { get; set; }
        private ImageSource _DisplayIcon = null;
        public ImageSource DisplayIcon
        {
            get
            {
                if (_DisplayIcon == null)
                {
                    try
                    {
                        if (type == FSItemType.Folder)
                            _DisplayIcon = IconExtractor.GetFolderIcon(FullPath).ToImageSource();
                        else
                            _DisplayIcon = IconExtractor.GetFileIcon(FullPath).ToImageSource();

                    }
                    catch (Exception e)
                    { 
                        
                    }
                }

                return _DisplayIcon;
            }

            set { _DisplayIcon = value; }
        }
        public bool ShowToolTip { get; set; }
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
            if (icon == null)
                return null;
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
}
