/*This file is part of TikzEdt.
 
TikzEdt is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.
 
TikzEdt is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
GNU General Public License for more details.
 
You should have received a copy of the GNU General Public License
along with TikzEdt.  If not, see <http://www.gnu.org/licenses/>.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
//using System.Windows.Shapes;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using PDFLibNet;
using System.ComponentModel;

namespace TikzEdt
{
    /// <summary>
    /// Interaction logic for TikzDisplay.xaml 
    /// NOT THREAD-SAFE SO FAR
    /// </summary>
    public partial class TikzDisplay : UserControl, TikzEdt.ITikzDisplayView
    {

        TikzDisplayModel<BitmapSource> TheModel { get; set; }

        #region properties
        readonly public static DependencyProperty RenderTransparentProperty = DependencyProperty.Register(
                    "RenderTransparent", typeof(bool), typeof(TikzDisplay),
                    new PropertyMetadata(true, OnResolutionChanged));
        /// <summary>
        /// Indicates whether the pdf background should be rendered transparent
        /// </summary>
        public bool RenderTransparent
        {
            get { return (bool)GetValue(RenderTransparentProperty); }
            set { SetValue(RenderTransparentProperty, value); }
        }


        readonly public static DependencyProperty ResolutionProperty = DependencyProperty.Register(
         "Resolution", typeof(double), typeof(TikzDisplay), new PropertyMetadata(Consts.ptspertikzunit,
             new PropertyChangedCallback(OnResolutionChanged)));
               
        /// <summary>
        /// The current resolution, in dots per cm (i.e., per Tikz unit).
        /// </summary>
        public double Resolution
        {
            get { return (double)GetValue(ResolutionProperty); }
            set { SetValue(ResolutionProperty, value); }
        }
        static void OnResolutionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TikzDisplay td = d as TikzDisplay;
            td.TheModel.RedrawBMP(false);
        }

        readonly public static DependencyProperty PdfPathProperty = DependencyProperty.Register(
            "PdfPath", typeof(string), typeof(TikzDisplay),
            new PropertyMetadata("", OnPdfPathChanged));
        static void OnPdfPathChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TikzDisplay td = d as TikzDisplay;
            td.TheModel.Refresh();
        }

        /// <summary>
        /// The pdf file to be displayed.
        /// Set this property to "" to set the control to an unavailable state. 
        /// </summary>
        public string PdfPath
        {
            get { return (string)GetValue(PdfPathProperty); }
            set { SetValue(PdfPathProperty, value); }
        }

        /// <summary>
        /// This dependency property is a hack to enable signalling of a pdf reload from the viewmodel to this control.
        /// Whenever the value changes, the pdf is reloaded.
        /// </summary>
        public int ReloadPdf
        {
            get { return (int)GetValue(ReloadPdfProperty); }
            set { SetValue(ReloadPdfProperty, value); }
        }        
        public static readonly DependencyProperty ReloadPdfProperty =
            DependencyProperty.Register("ReloadPdf", typeof(int), typeof(TikzDisplay), new UIPropertyMetadata(0, OnReloadChanged));
        static void OnReloadChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TikzDisplay td = d as TikzDisplay;
            td.TheModel.RedrawBMP(true);
        }

        #endregion        

        public TikzDisplay()
        {            
            InitializeComponent();

            if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            {
                IPdfToBmp<BitmapSource> Pdf2Bmp;
                if (CompilerSettings.Instance.UseExternalRenderer)
                    Pdf2Bmp = new PdfToBmpExtWPF();
                else
                    Pdf2Bmp = new PdfToBmpWPF();
                var e = System.Threading.Thread.CurrentThread.ExecutionContext;
                TheModel = new TikzDisplayModel<BitmapSource>(this, Pdf2Bmp);
                   /* (b) =>
                    {
                        if (b == null) return null;
                        BitmapSource bmps = PdfToBmp.GetBitmapSourceFromBitmap(b);
                        if (bmps != null)
                            bmps.Freeze();  // this is important because we want to access it in a different thread
                        return bmps;
                    });*/

                image1.DataContext = TheModel;
                lblUnavailable.DataContext = TheModel;
            }
        }

    }


}
