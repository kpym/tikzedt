using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
//using System.Windows.Shapes;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using PDFLibNet;
using System.ComponentModel;

namespace TikzEdt
{
/// <summary>
/// The job of this class is to load a pdf file and render it into bitmaps of
/// possibly varying resolutions. Internally it uses pdflibnet. to do the conversion.
/// </summary>
    public class PdfToBmpBase
    {
        /// <summary>
        /// Holds the pdflibnet PdfWrapper, which does the conversion.
        /// </summary>
        protected PDFWrapper mypdfDoc = null;


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
                int width = Convert.ToInt32(pwidth * dpi / 254);
                int height = Convert.ToInt32(pheight * dpi / 254);
                int safetymargin = 0; // >0 => hack to prevent cropping near boundary

                // if we'd need too much memory -> don't proceed
                if (width * height > 20e6)
                {
                    GlobalUI.UI.AddStatusLine(this, "Pdf rendering aborted: it's too big!", true);
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

        protected Bitmap GetBitmapBase(double Resolution, bool Transparent = true)
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
                    GlobalUI.UI.AddStatusLine(this, "Pdf rendering aborted: it's too big!", true);
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

                mypdfDoc.RenderPage(IntPtr.Zero, true); ////pic.Handle); // it works with zero, very strange!!!


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
            Bitmap b = GetBitmapBase(Resolution, Transparent);
            if (b != null)
            {
                b.Save(cFile, imgFormat);
                b.Dispose();
            }
        }

        ~PdfToBmpBase()
        {
            if (mypdfDoc != null)
            {
                mypdfDoc.Dispose();
                mypdfDoc = null;
            }
        }

    }

    public class PdfToBmp : PdfToBmpBase, IPdfToBmp<Bitmap>
    {
        public Bitmap GetBitmap(double Resolution, bool Transparent = true)
        {
            return GetBitmapBase(Resolution, Transparent);
        }
    }

}