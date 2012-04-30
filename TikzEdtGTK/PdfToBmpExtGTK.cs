using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TikzEdt;
using System.IO;

namespace TikzEdtGTK
{
    public class PdfToBmpExtGTK : PdfToBmpExtBase, IPdfToBmp<Cairo.ImageSurface>
    {
        public Cairo.ImageSurface GetBitmap(double Resolution, bool Transparent = true)
        {
            if (CallExternalRenderer(Resolution, Transparent) && File.Exists(PngFile))
            {
                try
                {
                    Cairo.ImageSurface ret = new Cairo.ImageSurface(PngFile);

                    /*Bitmap ret = null;
                using (var fs = new FileStream(PngFile, FileMode.Open))
                {
                    ret = (Bitmap)Image.FromStream(fs);
                } */
                    return ret;
                }
                catch (Exception) { }
            }


            return null;
        }


        public void SaveBmp(string cFile, double Resolution, bool Transparent, System.Drawing.Imaging.ImageFormat imgFormat)
        {
            /*Bitmap b = GetBitmap(Resolution, Transparent);
            if (b != null)
            {
                b.Save(cFile, imgFormat);
                b.Dispose();
            };*/
            // TODO
        }

    }
}

