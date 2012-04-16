using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TikzEdt;

namespace TikzEdtWForms
{
    public partial class TikzDisplay : UserControl, ITikzDisplayView
    {

        TikzDisplayModel<Bitmap> TheModel;

        public TikzDisplay()
        {
            InitializeComponent();

            this.BackColor = Color.Transparent;
            lblUnavailable.BackColor = Color.Transparent;
            imgImage.BackColor = Color.Transparent;
            //BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //imgImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            imgImage.SizeMode = PictureBoxSizeMode.AutoSize;
            imgImage.Dock = DockStyle.None;
            //imgImage.Anchor = AnchorStyles.None;
            Margin = new Padding(0);
            imgImage.Margin = new Padding(0);
            imgImage.Left = imgImage.Top = 0;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;



            if (this.DesignMode)
                return;

            TheModel = new TikzDisplayModel<Bitmap>(this, new PdfToBmpExtWinForms() );
            
            lblUnavailable.DataBindings.Add("Visible", TheModel, "IsUnavailable");
            imgImage.DataBindings.Add("Visible", TheModel, "IsImageVisible");
            //imgImage.Image
            Binding b = new Binding("Image", TheModel, "Bmp", true, DataSourceUpdateMode.Never);
            b.Format += new ConvertEventHandler(b_Format);
            imgImage.DataBindings.Add(b);

            this.AutoSize = true;
            this.imgImage.SizeMode = PictureBoxSizeMode.AutoSize;

        }

        void b_Format(object sender, ConvertEventArgs e)
        {
            Bitmap bmp = e.Value as Bitmap;
            e.Value = bmp as Image;
        }

        string _PdfPath = null;
        public string PdfPath
        {
            get { return _PdfPath; }
            set { _PdfPath = value; TheModel.Refresh(); }
        }

        //int ITikzDisplayView.ReloadPdf
        public int ReloadPdf
        {
            get { return 0; }
            set { TheModel.RedrawBMP(true); }
        }

        bool _RenderTransparent = true;
        public bool RenderTransparent
        {
            get { return _RenderTransparent; }
            set { _RenderTransparent = value; TheModel.RedrawBMP(false); }
        }

        double _Resolution = Consts.ptspertikzunit;
        public double Resolution
        {
            get { return _Resolution; }
            set { _Resolution = value; TheModel.RedrawBMP(false); }
        }
    }


    public partial class RasterControl : Control, IRasterControlView
    {
        TikzDisplayModel<Bitmap> TheDisplayModel;

        string _PdfPath = null;
        public string PdfPath
        {
            get { return _PdfPath; }
            set { _PdfPath = value; TheDisplayModel.Refresh(); }
        }

        //int ITikzDisplayView.ReloadPdf
        public int ReloadPdf
        {
            get { return 0; }
            set { TheDisplayModel.RedrawBMP(true); }
        }

        bool _RenderTransparent = true;
        public bool RenderTransparent
        {
            get { return _RenderTransparent; }
            set { _RenderTransparent = value; TheDisplayModel.RedrawBMP(false); }
        }


    }

}
