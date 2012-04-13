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

            TheModel = new TikzDisplayModel<Bitmap>(this, new PdfToBmpExtWinForms() );
            
            //lblUnavailable.DataBindings.Add(;

        }

        string _PdfPath;
        string ITikzDisplayView.PdfPath
        {
            get { return _PdfPath; }
            set { _PdfPath = value; TheModel.Refresh(); }
        }

        int ITikzDisplayView.ReloadPdf
        {
            get { return 0; }
            set { TheModel.RedrawBMP(true); }
        }

        bool _RenderTransparent;
        bool ITikzDisplayView.RenderTransparent
        {
            get { return _RenderTransparent; }
            set { _RenderTransparent = value; TheModel.RedrawBMP(false); }
        }

        double _Resolution;
        double ITikzDisplayView.Resolution
        {
            get { return _Resolution; }
            set { _Resolution = value; TheModel.RedrawBMP(false); }
        }
    }
}
