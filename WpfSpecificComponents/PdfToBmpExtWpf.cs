using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TESharedComponents;
using System.Windows.Media.Imaging;
using System.IO;

namespace TikzEdt
{
    public class PdfToBmpExtWPF : PdfToBmpExtBase, IPdfToBmp<BitmapSource>
    {
        public BitmapSource GetBitmap(double Resolution, bool Transparent = true)
        {
            if (CallExternalRenderer(Resolution, Transparent) && File.Exists(PngFile))
            {
                BitmapImage src = new BitmapImage();
                src.BeginInit();
                src.UriSource = new Uri(PngFile, UriKind.Relative);
                src.CacheOption = BitmapCacheOption.OnLoad;
                src.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
                src.EndInit();
                src.Freeze();
                return src;
            }
            else
                return null;
        }

        public void SaveBmp(string cFile, double Resolution, bool Transparent, System.Drawing.Imaging.ImageFormat imgFormat)
        {
            //BitmapSource b = GetBitmap(Resolution, Transparent);
            
            // TODO: implement
        }

    }
}
