using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TEApplicationLogic.Snippets;
using TikzEdt;
using System.IO;

namespace TikzEdtWForms
{
    public partial class SnippetEntry : UserControl
    {
        public int ImgWidth
        {
            get { return imgImage.Width; }
            set 
            {
                imgImage.Width = value;
                ReloadImage();
            }
        }
        public Snippet TheSnippet {get; private set; }
        public SnippetEntry( Snippet S )
        {
            InitializeComponent();

            TheSnippet = S;

            lblName.Text = TheSnippet.Name;

            imgImage.ImageLocation = Path.Combine(Helper.GetSnippetsPath() ,  TheSnippet.Key + ".png");
            //Use this style with WYSIWYG tools&#xa;CTRL to add the style to the current one (rather than replace it)"
            cmdInsertAsStyle.Visible = cmdUseStyle.Visible = !String.IsNullOrWhiteSpace(S.EdgeStyle) || !String.IsNullOrWhiteSpace(S.NodeStyle);

            // set tooltips
            toolTip1.SetToolTip(cmdUseStyle, "Use this style with WYSIWYG tools."+Environment.NewLine+"CTRL to add the style to the current one (rather than replace it)");
            toolTip1.SetToolTip(cmdInsertAsStyle, "Insert as \\tikzstyle{...} command");

            string description = S.Name + Environment.NewLine+ S.Code + Environment.NewLine+ "Sample:" + Environment.NewLine+ S.Example+ Environment.NewLine+ "Needs:" + S.Dependencies ;
            toolTip1.SetToolTip(lblName, description);
            toolTip1.SetToolTip(imgImage, description);
        }
		
		public void ReloadImage()
		{
            AdjustSize();
			imgImage.Refresh();	
		}

        public event EventHandler UseStyle;
        public event EventHandler InsertAsStyle;
        public event EventHandler DblClick;

        private void imgImage_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
			// The max () is a workaround for a mono bug... not nec. on windows
            AdjustSize();
        }

        void AdjustSize()
        {
            if (imgImage.Image != null)
                Height = Math.Max(imgImage.Width * imgImage.Image.Height / imgImage.Image.Width + 3, 35);
        }

        private void cmdInsertAsStyle_Click(object sender, EventArgs e)
        {
            if (InsertAsStyle != null)
                InsertAsStyle(this, null);
        }

        private void cmdUseStyle_Click(object sender, EventArgs e)
        {
            if (UseStyle != null)
                UseStyle(this, null);
        }

        private void lblName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (DblClick != null)
                DblClick(this, null);
        }
    }
}
