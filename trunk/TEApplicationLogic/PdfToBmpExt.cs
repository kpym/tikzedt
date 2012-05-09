using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Diagnostics;
using System.IO;

namespace TikzEdt
{
    /// <summary>
    /// TikzEdt may use one of several methods to render a pdf file to an image.
    /// The Viewmodels access the pdf->image converter through this interface.
    /// </summary>
    /// <typeparam name="T">The type of the image to which the pdf is converted.</typeparam>
    public interface IPdfToBmp<T>
    {
        T GetBitmap(double Resolution, bool Transparent = true);
        void SaveBmp(string cFile, double Resolution, bool Transparent, System.Drawing.Imaging.ImageFormat imgFormat);
        bool IsEmpty();

        bool UnloadPdf();
        bool LoadPdf(string cfile);

    }


    /// <summary>
    /// Base class for rendering using an external executable. (Concretely: mudraw/pdfdraw)
    /// </summary>
    public class PdfToBmpExtBase
    {
        protected string PdfFile;
        protected string PngFile;
        protected bool CallExternalRenderer(double Resolution, bool Transparent = true)
        {
			if (!File.Exists(PdfFile))
			{
				//GlobalUI.UI.AddStatusLine(this, "Couldn't render pdf. No pdf file to render.", true);
				return false;
			}
				
            //try
            //{
            PngFile = PdfFile+".png";
            double dpi = 72 * Resolution / Consts.ptspertikzunit;
            //dpi = Math.Round(dpi, 10);
            string transp_arg = Transparent ? " -a" : "";
			string mudraw = Path.Combine(Helper.GetAppDir(), Consts.Mudraw);
            var psi = new ProcessStartInfo()
                {
                    FileName = mudraw,
					WorkingDirectory = Path.GetDirectoryName(PdfFile),
                    Arguments = "-o " + "\"" + PngFile + "\" -r " + dpi + transp_arg + " \"" + PdfFile + "\" 1",
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
            GlobalUI.UI.AddStatusLine(this, "Rendering: " + psi.FileName + " " + psi.Arguments);

            try
            {
                Process p = Process.Start(psi);

                p.WaitForExit();
                return (p.ExitCode == 0);
            }
            catch (Exception e)
            {
                GlobalUI.UI.AddStatusLine(this, "Couldn't render pdf. Probably mudraw was not found: "
					+ e.Message, true);
                return false;
            }
        }

        public bool  UnloadPdf()
        {
 	        return true;
        }

        public bool LoadPdf(string cfile)
        {
 	        PdfFile = cfile;
            return true;
        }

        public bool IsEmpty()
        {
            // HACK
            return !File.Exists(PdfFile);
        }

    }

    public class PdfToBmpExtWinForms : PdfToBmpExtBase, IPdfToBmp<Bitmap>
    {
        public Bitmap GetBitmap(double Resolution, bool Transparent = true)
        {
            if (CallExternalRenderer(Resolution, Transparent) && File.Exists(PngFile))
            {
                try
                {
                    Bitmap ret = null;
                    using (var fs = new FileStream(PngFile, FileMode.Open))
                    {
                        ret = (Bitmap)Image.FromStream(fs);
                    }
                    return ret;
                }
                catch (Exception ) {}
            }


            return null;
        }


        public void SaveBmp(string cFile, double Resolution, bool Transparent, System.Drawing.Imaging.ImageFormat imgFormat)
        {
            Bitmap b = GetBitmap(Resolution, Transparent);
            if (b != null)
            {
                b.Save(cFile, imgFormat);
                b.Dispose();
            };
        }

    }

}
