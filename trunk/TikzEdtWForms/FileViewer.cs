using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using TikzEdt;

namespace TikzEdtWForms
{
    public partial class FileViewer : UserControl
    {
        public FileViewer()
        {
            InitializeComponent();

            if (DesignMode)
                return;

            cmbFilter.Items.Add("*.tex;*.tikz"); cmbFilter.Items.Add("*.tex"); cmbFilter.Items.Add("*.tikz"); cmbFilter.Items.Add("*.*");
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.SelectedIndex = 0;
            cmbFilter.SelectedIndexChanged += (s, e) => PopulateList();
            CurrentFolder = Directory.GetCurrentDirectory();

            CreateContextMenu();

        }

        private void CreateContextMenu()
        {
            var m = lstFiles.ContextMenu = new ContextMenu();
            var i = new MenuItem("Open");
            i.DefaultItem = true;
            i.Click += (s,e) => lstFiles_MouseDoubleClick(s,e);
            m.MenuItems.Add(i);
            i = new MenuItem("Open in new instance");
            i.Click += (s,e) => RaiseSelectEvent(true, false);
            m.MenuItems.Add(i);
            i = new MenuItem("Open externally");
            i.Click += (s, e) => RaiseSelectEvent(false, true);
            m.MenuItems.Add(i);
            i = new MenuItem("-");
            m.MenuItems.Add(i);
            i = new MenuItem("Explore current folder");
            i.Click += (s, e) =>
            {
                if (OnFileSelect != null)
                    OnFileSelect(this, new FileSelectEventArgs()
                    {
                        FileName = CurrentFolder, // + (CurrentFolder.EndsWith(Path.DirectorySeparatorChar.ToString()) ? "" : Path.DirectorySeparatorChar.ToString()),
                        InNewInstance = false,
                        InExternalViewer = true
                    });
            };
            m.MenuItems.Add(i);
        }

        void RaiseSelectEvent(bool NewInstance, bool ExternalViewer)
        {
            if (lstFiles.SelectedItems.Count == 1)
            {
                if (lstFiles.SelectedItems[0].ImageIndex == 1)   // file
                {
                    if (OnFileSelect != null)
                        OnFileSelect(this, new FileSelectEventArgs()
                        {
                            FileName = Path.Combine(CurrentFolder, lstFiles.SelectedItems[0].Text),
                            InNewInstance = NewInstance,
                            InExternalViewer = ExternalViewer
                        });

                }
            }
        }

        #region properties

        private string _CurrentFolder;
        public string CurrentFolder
        {
            get { return _CurrentFolder; }
            private set 
            { 
                _CurrentFolder = value;
                txtPath.Text = _CurrentFolder;
                toolTip1.SetToolTip(txtPath, txtPath.Text);
                PopulateList();
            }
        }

        #endregion


        #region Events

        /// <summary>
        /// This is fired when a file is double clicked.
        /// </summary>
        public event EventHandler<FileSelectEventArgs> OnFileSelect;
        public class FileSelectEventArgs : EventArgs
        {
            public string FileName;
            /// <summary>
            /// If true, file should be opened in external viewer regardless of the InNewInstance value. 
            /// </summary>
            public bool InExternalViewer = false;
            public bool InNewInstance = false;
        }

        #endregion

        void PopulateList()
        {
            lstFiles.Items.Clear();
            try
            {
                var Dirs = Directory.GetDirectories(CurrentFolder);
                var filters = cmbFilter.Text.Split(';');
                var Files = filters.SelectMany(f => Directory.GetFiles(CurrentFolder, f)).OrderBy(s => s);


                foreach (var d in Dirs.Select(dd => Path.GetFileName(dd)) )
                {
                    var i = new ListViewItem(d) { ImageIndex = 0 };
                    lstFiles.Items.Add(i);

                }
                foreach (var d in Files)
                {
                    var i = new ListViewItem(Path.GetFileName(d)) { ImageIndex = 1 };
                    i.SubItems.Add(File.GetLastWriteTime(d).ToString());
                    lstFiles.Items.Add(i);
                }

            }
            catch (Exception e)
            {
                GlobalUI.UI.AddStatusLine(this, "Couldn't populate file listview: "+e.Message, true);
                lstFiles.Clear();
            }
        }

        private void cmdUp_Click(object sender, EventArgs e)
        {
            var p = Directory.GetParent(CurrentFolder);
            if (p != null)
                CurrentFolder = p.FullName;
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            CurrentFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void lstFiles_MouseDoubleClick(object sender, EventArgs e)
        {
            if (lstFiles.SelectedItems.Count == 1)
            {
                if (lstFiles.SelectedItems[0].ImageIndex == 0) // folder
                {
                    CurrentFolder = Path.Combine(CurrentFolder, lstFiles.SelectedItems[0].Text);
                }
                else  // file
                {
                    if (OnFileSelect != null)
                        OnFileSelect(this, new FileSelectEventArgs() 
                        { 
                            FileName = Path.Combine(CurrentFolder, lstFiles.SelectedItems[0].Text), 
                            InNewInstance = Control.ModifierKeys.HasFlag(Keys.Control) });

                }
            }
        }

    }
}
