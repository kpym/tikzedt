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
