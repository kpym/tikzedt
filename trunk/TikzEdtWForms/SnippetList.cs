using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TikzEdt.Snippets;
using TEApplicationLogic.Snippets;
using System.Drawing;

namespace TikzEdtWForms
{
    class SnippetList : FlowLayoutPanel, ISnippetListView
    {
        public SnippetListModel TheModel {get; private set; }

        #region Exposed Events
        //public delegate void InsertEventHandler(string code, string dependencies);
        public event EventHandler<InsertEventArgs> OnInsert;
        public event EventHandler<UseStylesEventArgs> OnUseStyles;

        #endregion

        #region Properties
        private bool _ShowThumbnails = true;
        public bool ShowThumbnails
        {
            get { return _ShowThumbnails; }
            set { _ShowThumbnails = value; }
        }

        private int _ThumbnailSize = 40;
        public int ThumbnailSize
        {
            get { return _ThumbnailSize; }
            set 
            { 
                _ThumbnailSize = value;
                foreach (var c in Controls.OfType<SnippetEntry>())
                    c.ImgWidth = _ThumbnailSize;
            }
        }

        #endregion

        ContextMenu TheContextMenu;
        private void CreateContextMenu()
        {
            var m = TheContextMenu = new ContextMenu();
            var i = new MenuItem("Insert Snippet");
            i.Click += (s, e) => { if (PopupSource != null) TheModel.HandleInsertSnippetClick(PopupSource.TheSnippet.Row); };
            m.MenuItems.Add(i);
            i = new MenuItem("Insert full Code Sample");
            i.Click += (s, e) => { if (PopupSource != null) TheModel.HandleInsertFullCodeClick(PopupSource.TheSnippet.Row); };
            m.MenuItems.Add(i);
            i = new MenuItem("Insert Dependencies");
            i.Click += (s, e) => { if (PopupSource != null) TheModel.HandleInsertDependenciesClick(PopupSource.TheSnippet.Row); };
            m.MenuItems.Add(i);
            m.MenuItems.Add(new MenuItem("-"));

            var mm = new MenuItem("Thumbnails");
            i = new MenuItem("Off");
            i.Click += (s, e) => ShowThumbnails = false;
            mm.MenuItems.Add(i);
            i = new MenuItem("Small");
            i.Click += (s, e) => { ShowThumbnails = true; ThumbnailSize = 40; };
            mm.MenuItems.Add(i);
            i = new MenuItem("Middle");
            i.Click += (s, e) => { ShowThumbnails = true; ThumbnailSize = 70; };
            mm.MenuItems.Add(i);
            i = new MenuItem("Large");
            i.Click += (s, e) => { ShowThumbnails = true; ThumbnailSize = 150; };
            mm.MenuItems.Add(i);
            m.MenuItems.Add(mm);
            m.Popup += (s, e) => PopupSource = TheContextMenu.SourceControl as SnippetEntry;
            
        }
        SnippetEntry PopupSource = null;


        public SnippetList()
        {
            this.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;  //Orientation = Orientation.Vertical;
            BackColor = Color.White;
            this.Padding = new Padding(2);
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            this.AutoScroll = true;
            ClientSizeChanged += new EventHandler(SnippetList_Resize);

            if (DesignMode)
                return;

            TheModel = new SnippetListModel(this);

            TheModel.Reload();

            TheModel.CheckForThumbnails();

            CreateContextMenu();

            ((ISnippetListView)this).Refresh();
 
        }

        void SnippetList_Resize(object sender, EventArgs e)
        {
			SuspendLayout();
            foreach (var c in this.Controls)
                (c as Control).Width = ClientSize.Width * 95 / 100;
			ResumeLayout();
        }

        List<SnippetEntry> Children = new List<SnippetEntry>();

        void ISnippetListView.Refresh()
        {
            Controls.Clear();
			SuspendLayout();

            List<Snippet> L = new List<Snippet>();

            foreach (var rr in TheModel.snippetsDataSet.SnippetsTable.Rows)
            {
                SnippetsDataSet.SnippetsTableRow r = (SnippetsDataSet.SnippetsTableRow)rr;
                Snippet S = new Snippet()
                {
                    Name = r.Name,
                    Code = r.SnippetCode,
                    Example = r.SampleCode,
                    Key = r.ID,
                    Dependencies = r.Dependencies,
                    Category = r.Category,
                    Row = r,
                };
                L.Add(S);
            }

            //L.Sort((a, b) => String.Compare(a.Category, b.Category));
            var Categories = L.Select(s => s.Category).Distinct().OrderBy(s => s);

            foreach (string C in Categories)
            {
                var Butt = new CheckBox() { Text = C, Visible = true, Width = ClientSize.Width, Appearance=Appearance.Button, BackColor=Color.Gainsboro, Margin=new Padding(0), TabStop=false};
                Butt.Click += new EventHandler(Butt_Click);
                Controls.Add(Butt);
                foreach (var S in L.Where(s => s.Category == C))
                {
                    var o = new SnippetEntry(S);
                    o.Visible = false;
                    o.Parent = this;
                    o.Width = ClientSize.Width;
                    o.Margin = new Padding(0);
                    o.ImgWidth = ThumbnailSize;

                    o.ContextMenu = TheContextMenu;
                    
                    o.DblClick += new EventHandler(o_MouseDoubleClick);
                    o.UseStyle += new EventHandler(o_UseStyle);
                    o.InsertAsStyle += new EventHandler(o_InsertAsStyle);

                    //o.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                    Controls.Add(o);
                }
            }
			
			ResumeLayout();
        }

        void o_InsertAsStyle(object sender, EventArgs e)
        {
            TheModel.HandleInsertAsTikzStyleClick((sender as SnippetEntry).TheSnippet.Row);
        }

        void o_UseStyle(object sender, EventArgs e)
        {
            TheModel.HandleUseStyleButtonClick((sender as SnippetEntry).TheSnippet.Row);
        }

        void o_MouseDoubleClick(object sender, EventArgs e)
        {
            TheModel.HandleMouseDoubleClick((sender as SnippetEntry).TheSnippet.Row);
        }

        void Butt_Click(object sender, EventArgs e)
        {
            string Cat = (sender as Control).Text;

            var L = this.Controls.OfType<SnippetEntry>().Where(se => se.TheSnippet.Category == Cat);
            foreach (var se in L)
                se.Visible = !se.Visible;
        }

        void ISnippetListView.RaiseOnInsert(InsertEventArgs e)
        {
            if (OnInsert != null)
                OnInsert(this, e);
        }

        void ISnippetListView.RaiseOnUseStyle(UseStylesEventArgs e)
        {
            if (OnUseStyles != null)
                OnUseStyles(this, e);
        }
    }
}
