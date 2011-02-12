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

        private double _Resolution = Consts.ptspertikzunit;
        public double Resolution
        {
            get { return _Resolution; }
            set {
                if (value > 0)
                {
                    _Resolution = value;
                    //RecalcSize();
                    RedrawBMP(false);
                }
            }
        }

        private string _PdfPath = "";
        /// <summary>
        /// Set this property to "" to set the control to an unavailable state. 
        /// </summary>
        public string PdfPath
        {
            set { 
                _PdfPath = value;
                if (_PdfPath == "")
                {
                    lblUnavailable.Visibility = Visibility.Visible;
                    image1.Visibility = Visibility.Collapsed;
                    NextBmpJob = null; // if manually set to unavailable-> clear pending bmp jobs
                    myPdfBmpDoc.UnloadPdf();
                }
                else
                    RedrawBMP(true);
            }
            get { return _PdfPath; }
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


    /// <summary>
    /// The job of this class is to load a pdf file and render it into bitmaps of
    /// possibly varying resolutions. Internally it uses pdflibnet. to do the conversion.
    /// </summary>
    public class PdfToBmp
    {
        /// <summary>
        /// Holds the pdflibnet PdfWrapper, which does the conversion.
        /// </summary>
        PDFWrapper mypdfDoc=null;
        

        public bool LoadPdf(string cfile)
        {

            if (mypdfDoc != null)
            {
                mypdfDoc.Dispose();
                mypdfDoc = null;
                
            }
            mypdfDoc = new PDFLibNet.PDFWrapper();
            

            mypdfDoc.UseMuPDF = true;

            if (!File.Exists(cfile))
                return false;
            //this line creates a handle
            //it can be closed with Dispose()
            Stopwatch s = new Stopwatch();
            //s.Start();
             bool ret = mypdfDoc.LoadPDF(cfile);
            // s.Stop();
            // MainWindow.AddStatusLine("LoadPDF took " + s.ElapsedMilliseconds + " ms");
             return ret;
        }

        public bool UnloadPdf()
        {
            if (mypdfDoc != null)
            {
                //MessageBox.Show("UnloadPDF");
                mypdfDoc.Dispose();
                mypdfDoc = null;
                return true;
            }
            return false;
        }

       
        /// <summary>
        /// Returns a Bitmap from mypdfDoc. Do not forget to Dispose returned Bitmap!
        /// </summary>
        /// <param name="Resolution">Resolution of the Bitmap</param>
        /// <param name="Transparent">Makes white areas in Bitmap transparent</param>
        /// <returns></returns>
        private Bitmap GetBitmapViaFile(double Resolution, bool Transparent = true)
        {
            if (mypdfDoc != null && mypdfDoc.PageCount > 0)
            {
                double dpi = 72 * Resolution / Consts.ptspertikzunit;
                PDFPage p = mypdfDoc.Pages[1];
                double pwidth = p.Width, pheight = p.Height;
                // the following lines are as in the PDFPage.GetBitmap() function
                int width = Convert.ToInt32(pwidth*dpi/254);
		        int height= Convert.ToInt32(pheight*dpi/254);
                int safetymargin = 0; // >0 => hack to prevent cropping near boundary
		        
                // if we'd need too much memory -> don't proceed
                if (width * height > 20e6)
                {
                    MainWindow.AddStatusLine("Pdf rendering aborted: it's too big!", true);
                    return null;
                }


                mypdfDoc.RenderDPI = 72 * Resolution / Consts.ptspertikzunit;

                //System.Windows.Forms.PictureBox pic = new System.Windows.Forms.PictureBox();
                mypdfDoc.CurrentPage = 1;
                
                /*Added since 1.0.6.2*/
                mypdfDoc.CurrentX = 0;
                mypdfDoc.CurrentY = 0;
                mypdfDoc.ClientBounds = new System.Drawing.Rectangle(0, 0, width + safetymargin, height + safetymargin);//new Rectangle(0, 0, mypdfDoc.PageWidth, mypdfDoc.PageHeight);

                string cFile = @"C:\temp\temp.jpg";

                //Stopwatch s = new Stopwatch();
                //s.Start();

                mypdfDoc.ExportJpg(cFile, 1, 1, mypdfDoc.RenderDPI, 100, -1);

                //s.Stop();
                //MainWindow.AddStatusLine("ExportJpg took " + s.ElapsedMilliseconds + " ms");
                //s.Reset();
                
                // load file 
                //System.Drawing.Image imgjpg = System.Drawing.Image.FromFile(cFile);
                //System.Drawing.Bitmap imgbmp = new System.Drawing.Bitmap(cFile);
                
                //Bitmap bbb = mypdfDoc.Pages[1].GetBitmap(72 * Resolution / Consts.ptspertikzunit, false);                
                //System.Drawing.Image I = mypdfDoc.Pages[1].GetImage(1);
                //System.Drawing.Image I2 = mypdfDoc.Pages[1].GetImage(0);

                //if (mypdfDoc.PageWidth * mypdfDoc.PageHeight == 0)
                if (height * width == 0)
                    return null;
                //s.Start();
                Bitmap _backbuffer = new System.Drawing.Bitmap(cFile);
                
                if (Transparent)
                {
                    _backbuffer.MakeTransparent(System.Drawing.Color.White);
                    _backbuffer.MakeTransparent(System.Drawing.Color.FromArgb(255, 253, 253, 253));
                    _backbuffer.MakeTransparent(System.Drawing.Color.FromArgb(255, 254, 254, 254));
                }
                //s.Stop();
                //MainWindow.AddStatusLine("Bitmap generation took " + s.ElapsedMilliseconds + " ms");
                // test
                //_backbuffer.Save(@"C:\temp\temp.bmp");
                //mypdfDoc.ExportJpg(@"C:\temp\temp.jpg",1,1,75,100,9000);
                
                return _backbuffer;
            }
            else return null;
        }

        private Bitmap GetBitmap(double Resolution, bool Transparent = true)
        {
            if (mypdfDoc != null && mypdfDoc.PageCount > 0)
            {
                double dpi = 72 * Resolution / Consts.ptspertikzunit;
                PDFPage p = mypdfDoc.Pages[1];
                double pwidth = p.Width, pheight = p.Height;
                // the following lines are as in the PDFPage.GetBitmap() function
                int width = Convert.ToInt32(pwidth * dpi / 254);
                int height = Convert.ToInt32(pheight * dpi / 254);
                int safetymargin = 0; // >0 => hack to prevent cropping near boundary

                // if we'd need too much memory -> don't proceed
                if (width * height > 20e6)
                {
                    MainWindow.AddStatusLine("Pdf rendering aborted: it's too big!", true);
                    return null;
                }

                //Stopwatch s = new Stopwatch();
                //s.Start();

                mypdfDoc.RenderDPI = 72 * Resolution / Consts.ptspertikzunit;

                //System.Windows.Forms.PictureBox pic = new System.Windows.Forms.PictureBox();
                mypdfDoc.CurrentPage = 1;

                /*Added since 1.0.6.2*/
                mypdfDoc.CurrentX = 0;
                mypdfDoc.CurrentY = 0;
                mypdfDoc.ClientBounds = new System.Drawing.Rectangle(0, 0, width + safetymargin, height + safetymargin);//new Rectangle(0, 0, mypdfDoc.PageWidth, mypdfDoc.PageHeight);

                mypdfDoc.RenderPage(IntPtr.Zero, true); ///pic.Handle); // it works with zero, very strange!!!


                //Bitmap bbb = mypdfDoc.Pages[1].GetBitmap(72 * Resolution / Consts.ptspertikzunit, false);
                //System.Drawing.Image I = mypdfDoc.Pages[1].GetImage(1);
                //System.Drawing.Image I2 = mypdfDoc.Pages[1].GetImage(0);

                //if (mypdfDoc.PageWidth * mypdfDoc.PageHeight == 0)
                if (height * width == 0)
                    return null;
                Bitmap _backbuffer = new System.Drawing.Bitmap(width + safetymargin, height + safetymargin); //new Bitmap(mypdfDoc.PageWidth, mypdfDoc.PageHeight);
                using (Graphics g = Graphics.FromImage(_backbuffer))
                {
                    /*New thread safe method*/
                    mypdfDoc.DrawPageHDC(g.GetHdc());
                    g.ReleaseHdc();
                }

                //s.Stop();
                //MainWindow.AddStatusLine("DrawpageHdc took " + s.ElapsedMilliseconds + " ms");
               
                //pic.Dispose();

                if (Transparent)
                {
                    _backbuffer.MakeTransparent(System.Drawing.Color.White);
                    _backbuffer.MakeTransparent(System.Drawing.Color.FromArgb(255, 253, 253, 253));
                    _backbuffer.MakeTransparent(System.Drawing.Color.FromArgb(255, 254, 254, 254));
                }

                // test
                //_backbuffer.Save(@"C:\temp\temp.bmp");
                //mypdfDoc.ExportJpg(@"C:\temp\temp.jpg",1,1,75,100,9000);

                return _backbuffer;
            }
            else return null;
        }

        public BitmapSource GetBitmapSource(double Resolution, bool Transparent = true)
        {
            Bitmap _backbuffer = GetBitmap(Resolution, Transparent); // change to GetBitmap once it is working
            if (_backbuffer != null)
            {
                //Stopwatch s = new Stopwatch();
                //s.Start();

                BitmapSource ret = getBitmapSourceFromBitmap(_backbuffer);                
                _backbuffer.Dispose();

                //s.Stop();
                //MainWindow.AddStatusLine("Bitmap conversion took " + s.ElapsedMilliseconds + " ms");
                
                return ret;
            }
            else return null;
        }


        /// <summary>
        /// Use this function to obtain Bitmap from mypdfDoc if using Pdflibnet 1.0.6.6.
        /// For later version use function GetBitmapSource() instead.
        /// </summary>
        /// <param name="Resolution"></param>
        /// <param name="Transparent"></param>
        /// <returns></returns>
        public BitmapSource GetBitmapSourceOld(double Resolution, bool Transparent = true)
        {            
            if (mypdfDoc != null && mypdfDoc.PageCount >0)
            {

                Bitmap b;
                try
                {
                    //this line returns null if called with Pdflibnet > 1.0.6.6.
                    //Stopwatch s = new Stopwatch();
                    //s.Start();
                    // if we'd need too much memory -> don't proceed
                    if (mypdfDoc != null && mypdfDoc.PageCount > 0)
                    {
                        double dpi = 72 * Resolution / Consts.ptspertikzunit;
                        PDFPage p = mypdfDoc.Pages[1];
                        double pwidth = p.Width, pheight = p.Height;
                        // the following lines are as in the PDFPage.GetBitmap() function
                        int width = Convert.ToInt32(pwidth * dpi / 254);
                        int height = Convert.ToInt32(pheight * dpi / 254);

                        if (width * height > 20e6)
                        {
                            MainWindow.AddStatusLine("Pdf rendering aborted: it's too big!", true);
                            return null;
                        }
                        b = p.GetBitmap(72 * Resolution / Consts.ptspertikzunit);
                    }
                    else return null;
                    //s.Stop();
                    //MainWindow.AddStatusLine("GetBitmap took " + s.ElapsedMilliseconds +" ms");
                }
                catch (ArgumentException)
                {//this can happen if node position is very "big", like (500,500)
                    return null;
                }

                BitmapSource ret = null;

                if (b != null)
                {
                    if (Transparent)
                    {
                        b.MakeTransparent(System.Drawing.Color.White);
                        b.MakeTransparent(System.Drawing.Color.FromArgb(255, 253, 253, 253));
                        b.MakeTransparent(System.Drawing.Color.FromArgb(255, 254, 254, 254));
                    }
                    ret = getBitmapSourceFromBitmap(b);
                    b.Save(@"C:\temp\temp.bmp");
                    b.Dispose();
                }                
                
                return ret;                
            }
            else return null;
        }
        public bool IsEmpty()
        {
            if (mypdfDoc != null && mypdfDoc.Pages.Count == 0)
                return true;
            return false;
        }

        public void SaveBmp(string cFile, double Resolution)
        {
            SaveBmp(cFile, Resolution, true, System.Drawing.Imaging.ImageFormat.Bmp);
        }
        public void SaveBmp(string cFile, double Resolution, bool Transparent, System.Drawing.Imaging.ImageFormat imgFormat)
        {
            Bitmap b = GetBitmap(Resolution, Transparent);
            if (b != null)
            {
                b.Save(cFile, imgFormat);
                b.Dispose();
            } 
        }

        [DllImport("gdi32")]
        static extern int DeleteObject(IntPtr o);
        /// <summary>
        /// This method converts a System.Drawing.Bitmap to a WPF Bitmap.
        /// (This is necessary since the WPF Image control only accepts WPF bitmaps).
        /// Used by public functions SaveBmp and GetBitmapSource
        /// </summary>
        /// <param name="source">The System.Drawing.Bitmap</param>
        /// <returns>The same Bitmap, in Wpf format</returns>
        private static BitmapSource getBitmapSourceFromBitmap(System.Drawing.Bitmap source)
        {

            IntPtr ip = source.GetHbitmap();
            BitmapSource bs;
            try
            {
                bs = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(ip,
                   IntPtr.Zero, Int32Rect.Empty,
                   System.Windows.Media.Imaging.BitmapSizeOptions.FromEmptyOptions());
            }
            finally
            {                
                DeleteObject(ip);
            }

            return bs;
        }

        ~PdfToBmp()
        {
            if (mypdfDoc != null)
            {
                mypdfDoc.Dispose();
                mypdfDoc = null;
            }
        }
    }
}
