using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Imaging;
using System.Runtime.InteropServices;
using System.Drawing;
using PDFLibNet;
using System.Windows;

namespace TikzEdt
{
    class PdfToBmpWPF : PdfToBmpBase, IPdfToBmp<BitmapSource>
    {

        public BitmapSource GetBitmap(double Resolution, bool Transparent = true)
        {
            Bitmap _backbuffer = GetBitmapBase(Resolution, Transparent); // change to GetBitmap once it is working
            if (_backbuffer != null)
            {
                //Stopwatch s = new Stopwatch();
                //s.Start();

                BitmapSource ret = GetBitmapSourceFromBitmap(_backbuffer);
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
            if (mypdfDoc != null && mypdfDoc.PageCount > 0)
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
                            GlobalUI.UI.AddStatusLine(this, "Pdf rendering aborted: it's too big!", true);
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
                    ret = GetBitmapSourceFromBitmap(b);
                    b.Save(@"C:\temp\temp.bmp");
                    b.Dispose();
                }

                return ret;
            }
            else return null;
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
        public static BitmapSource GetBitmapSourceFromBitmap(System.Drawing.Bitmap source)
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
    }
}
