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
                
            }
        }
        public Snippet TheSnippet {get; private set; }
        public SnippetEntry( Snippet S )
        {
            InitializeComponent();

            TheSnippet = S;

            lblName.Text = TheSnippet.Name;

            imgImage.ImageLocation = Path.Combine(Helper.GetSnippetsPath() ,  TheSnippet.Key + ".png");
            

        }

        public event EventHandler UseStyle;
        public event EventHandler InsertAsStyle;
        public event EventHandler DblClick;

        private void imgImage_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Height = imgImage.Width * imgImage.Image.Height / imgImage.Image.Width + 3;
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
