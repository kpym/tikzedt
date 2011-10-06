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
    public partial class TikzDisplay : UserControl
    {
                
        readonly public static DependencyProperty RenderTransparentProperty = DependencyProperty.Register(
                    "RenderTransparent", typeof(bool), typeof(TikzDisplay),
                    new PropertyMetadata(true, OnRenderTransparentChanged));
        static void OnRenderTransparentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as TikzDisplay).RedrawBMP(false);
        }
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
        /// The current bounding box.
        /// </summary>
        public double Resolution
        {
            get { return (double)GetValue(ResolutionProperty); }
            set { SetValue(ResolutionProperty, value); }
        }
        static void OnResolutionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TikzDisplay td = d as TikzDisplay;
            td.RedrawBMP(false);
        }

        readonly public static DependencyProperty PdfPathProperty = DependencyProperty.Register(
            "PdfPath", typeof(string), typeof(TikzDisplay),
            new PropertyMetadata("", OnPdfPathChanged, new CoerceValueCallback(OnPdfPathCoerce)));
        static void OnPdfPathChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TikzDisplay td = d as TikzDisplay;
            if (td.PdfPath == "")
            {
                td.lblUnavailable.Visibility = Visibility.Visible;
                td.image1.Visibility = Visibility.Collapsed;
                td.NextBmpJob = null; // if manually set to unavailable-> clear pending bmp jobs
                td.myPdfBmpDoc.UnloadPdf();
            }
            else
                td.RedrawBMP(true);
        }
        static object OnPdfPathCoerce(DependencyObject d, object o)
        {
            return o;
        }

        /// <summary>
        /// Set this property to "" to set the control to an unavailable state. 
        /// </summary>
        public string PdfPath
        {
            get { return (string)GetValue(PdfPathProperty); }
            set { SetValue(PdfPathProperty, value); }
        }



        /// <summary>
        /// This dependency property is a hack to eneble signalling of a pdf reload from the viewmodel to this control.
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
            td.RedrawBMP(true);
        }
        

        //protected Process texProcess = new Process();
        //protected String nextToCompile = "";
        //Rect currentBB;
        //public Rect BB
        //{
          //  get { return currentBB; }
           // set
            //{
              //  currentBB = value;
                //RecalcSize();
            //}
        //}

        PdfToBmp myPdfBmpDoc;

        BackgroundWorker AsyncBmpGenerator = new BackgroundWorker();
        class AsyncBmpData
        {
            public double Resolution;
            public bool RenderTransparent, Reload;
            public string File;
            

            public BitmapSource bmp; // this contains the bmp after return
        }
        private AsyncBmpData _NextBmpJob = null;
        AsyncBmpData NextBmpJob
        {
            get { return _NextBmpJob; }
            set
            {
                _NextBmpJob = value;
                if (_NextBmpJob != null && !AsyncBmpGenerator.IsBusy)
                {
                    AsyncBmpGenerator.RunWorkerAsync(NextBmpJob);
                    _NextBmpJob = null;
                }
            }
        }

        public TikzDisplay()
        {
            InitializeComponent();

            if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            {
                myPdfBmpDoc = new PdfToBmp();
                AsyncBmpGenerator.DoWork += new DoWorkEventHandler(AsyncBmpGenerator_DoWork);
                AsyncBmpGenerator.RunWorkerCompleted += new RunWorkerCompletedEventHandler(AsyncBmpGenerator_RunWorkerCompleted);
            }
        }

        void AsyncBmpGenerator_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            AsyncBmpData data = e.Result as AsyncBmpData;
            // if filename has changed while the bmp was generated-> don't display
            if (data.File == PdfPath)
            {                
                // if returned bitmap null or error -> set unavailable
                if (e.Error == null && data.bmp != null)
                {
                    image1.Source = data.bmp;
                    image1.Visibility = Visibility.Visible;
                    lblUnavailable.Visibility = Visibility.Collapsed;
                }
                else
                {
                    image1.Source = null;
                    image1.Visibility = Visibility.Collapsed;
                    lblUnavailable.Visibility = Visibility.Visible;
                }
            }
            // restart compilation if job pending
            NextBmpJob = NextBmpJob;
        }

        void AsyncBmpGenerator_DoWork(object sender, DoWorkEventArgs e)
        {
            AsyncBmpData data = e.Argument as AsyncBmpData;
            if (data.File != null)
            {
                myPdfBmpDoc.LoadPdf(data.File);
            }
            // this is not optimal since the pdf might be changing when called.... pass PdfWrapper instead to remedy....
            data.bmp = myPdfBmpDoc.GetBitmapSource(data.Resolution, data.RenderTransparent);
            //data.bmp = myPdfBmpDoc.GetBitmapSourceOld(data.Resolution, data.RenderTransparent);
            if (data.bmp != null)
                data.bmp.Freeze();  // this is important because we want to access it in a different thread
            e.Result = data;
        }

        /// <summary>
        /// Reload the PDF file. This is called only when the pdf file changes on disk.
        /// It is not called, for example, when the pdf just needs to be redrawn, e.g., due to 
        /// a changed display size.
        /// </summary>
       /* void RefreshPDF(string cFile)
        {
            //mypdfDoc.LoadPdf(Consts.cTempFile + ".pdf");
            if (cFile == "")
            {
                lblUnavailable.Visibility = Visibility.Visible;
                image1.Visibility = Visibility.Collapsed;
            }
            else
            {
                lblUnavailable.Visibility = Visibility.Collapsed;
                myPdfBmpDoc.LoadPdf(cFile);                
                image1.Visibility = Visibility.Visible;                
            }
            RedrawBMP();
            //RecalcSize();            
        } */
        public void SetUnavailable()
        {
            PdfPath = "";            
            //here it would be nice to release the handle to the pdf document
            //so it can be deleted. but how?
        }


        /// <summary>
        /// This method draws the currently loaded Pdf into a bitmap, and displays this bitmap in the image control.
        /// It is called, e.g., when the size of the TikzDisplay control changes
        /// Warning: It does _not_ reload the Pdf. 
        /// </summary>
        public void RedrawBMP(bool ReloadFile)
        {
            
            if (myPdfBmpDoc != null)
            {
                AsyncBmpData data = new AsyncBmpData();
                data.Resolution = Resolution;
                data.RenderTransparent = RenderTransparent;
                data.File = PdfPath;
                data.Reload = ReloadFile;

                NextBmpJob = data;

                return;

        /*        //check version of PDFLibNet, if the old 1.0.6.6 use old GetBitmap
                System.Reflection.Assembly a = System.Reflection.Assembly.GetAssembly(typeof(PDFWrapper));
                if(a.GetName().Version.Major == 1)
                    if(a.GetName().Version.Minor == 0)
                        if(a.GetName().Version.Build == 6)
                            if (a.GetName().Version.Revision == 6)
                            {
                                BitmapSource bitmap = myPdfBmpDoc.GetBitmapSourceOld(Resolution, RenderTransparent); // mypdfDoc.GetBitmap(currentBB, Resolution);                
                                if (bitmap != null)
                                  image1.Source = bitmap;
                                return;
                            }
                 
                //otherwise the new Bitmap2 function
                
                image1.Source = null;
                //myPdfBmpDoc.GetBitmap2(Resolution, currentBB.Width * currentBB.Height > 0); ;
                //image1.Source = myPdfBmpDoc.GetBitmapSource(Resolution, RenderTransparent); ;   
                image1.Source = myPdfBmpDoc.GetBitmapSourceOld(Resolution, RenderTransparent); ;        */        
            }

        }

       // private void image1_SizeChanged(object sender, SizeChangedEventArgs e)
       // {
            //RedrawBMP();
        //}

    }


}
