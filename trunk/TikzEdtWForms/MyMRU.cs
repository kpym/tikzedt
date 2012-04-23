using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TikzEdt;
using System.IO;
using System.Windows.Forms;

namespace TikzEdtWForms
{
    public static class MyMRU
    {
        static List<string> Files = new List<string>();
        const int MAX_ITEMS = 7;
        const int FilePath_Length = 60;

        public static event EventHandler<FileOpenArgs> OnFileOpen;
        public class FileOpenArgs : EventArgs
        {
            public string FileName;
            public FileOpenArgs(string FileName) { this.FileName = FileName; }
        }

        static MyMRU()
        {
            Load( Consts.MRUFileFullPath );
            AppDomain.CurrentDomain.ProcessExit += (s,e) => Save(Consts.MRUFileFullPath );
        }

        private static void Save(string p)
        {
            try
            {
                File.WriteAllLines(p, Files.ToArray());
            }
            catch (Exception )
            {
            }
        }

        private static void Load(string p)
        {
            try
            {
                Files.AddRange(File.ReadAllLines(p));
            }
            catch (Exception)
            {
            }
        }
        public static void Insert(string file)
        {
            Files.Remove(file);
            Files.Insert(0, file);
            if (Files.Count > MAX_ITEMS) 
                Files.RemoveAt(Files.Count - 1);
        }
        public static void Remove(string file)
        {
            Files.Remove(file);
        }
        static string ShortenPath(string file)
        {
            if (file.Length < FilePath_Length)
                return file;

            // shorten
            string s = Path.DirectorySeparatorChar + Path.GetFileName(file);
            int totake = Math.Max(0, FilePath_Length - s.Length);
            string t = file.Substring(0, totake);
            return t + "..." + s;
        }

        static object Token = new object();
        public static void UpdateMenu(ToolStripMenuItem M, ToolStripSeparator InsertAfter)
        {
            int InsertAt = M.DropDownItems.IndexOf(InsertAfter)+1;
            // delete old entries
            var todel = M.DropDownItems.OfType<ToolStripMenuItem>().Where(c => c.Tag == Token).ToList();
            M.DropDownItems.RemoveRange(todel);

            // fill again
            foreach (var f in Files)
            {
                var m = new ToolStripMenuItem(ShortenPath(f)) { Tag = Token };
                if (m.Text.Length < f.Length) 
                    m.ToolTipText =f;
                m.Click += (s, e) => { if (OnFileOpen != null) OnFileOpen(s, new FileOpenArgs(f) ); };
                M.DropDownItems.Insert(InsertAt++, m);
            }

        }
    }
}
