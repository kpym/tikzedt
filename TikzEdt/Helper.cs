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
using System.Windows.Shapes;
//using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Windows.Threading;
using System.Runtime.InteropServices;

//using System.Drawing;

namespace TikzEdt
{
    /// <summary>
    /// Please put all global constants that are not in the Properties.Settings into this static class.
    /// </summary>
    static class Consts
    {
        public const double cmperin = 2.54;
        public const double ptspertikzunit = 72.0 / cmperin; // 28.3464567
        public const double TikzDefaultLinewidth = 0;
        public const string TikzDefaultFont = "Times";
        public const double TikzDefaultFontSize = 8;
        public const int TikzImgResolution = 300; // resolution in dpi with which images are compiled

        //public static string[] TikzArrowTipCodes = new string[] { "", ">", "<" };
        //public static DashStyle[] TikzToSystemDashStyle = new DashStyle[] { DashStyle.Solid, DashStyle.Dot, DashStyle.Dash };
        //public static float[][] TikzToSystemDashPattern = new float[][] {
        //    new float[]{0.1F}, new float[]{.1F,.1F}, new float[]{.2F,.1F}
        //};

        public const string cCompletionsFile = "Editor\\CodeCompletions.xml";
        public const string cSettingsFile = "T2Gsettings.xml";
        public const string cSyntaxFile = "Editor\\TikzSyntax.xshd";
        public const string cSnippetsFile = "TheSnippets.xml";
        public const string cSnippetThumbsDir = "img";
        public const string cMRUFile = "T2GMRU.xml";    // not used
        public const int MaxMRU = 10;// not used
       // public const string cStyleRepoFile = "StyleRepo.dat";

        //public const string CoordinateVertexStyleName = "helper";

        public const string DoubleFormat = "#.####";

        public const float selecttoler = .01F;
        public const float drawXsize = .1F; // drawn for invisible vertices
        public const float coordvertexsize = .25F; // size of size zero vertex (to ease selection)

        //const string cLatex = "Pdflatex";
        //string cLatexPath = "pdflatex"; //@"C:\Program Files\MiKTeX 2.8\miktex\bin\pdfplatex.exe";
        public const string cTempFile = "temp_preview";         // for preview
        public const string cTempImgFile = "temp_previewtexts"; // for equation rendering
        public const string defaultCurFile = "New Tikzfile";
        public const string PreviewHeader =
        @"\documentclass[tight]{article}
\usepackage{tikz,amsmath, amssymb,bm,color}
\usepackage[margin=0cm,nohead]{geometry}
\usepackage[active,tightpage]{preview}
";

        public const string ImgHeader =
        @"\documentclass[fleqn]{article}
\usepackage{amsmath, amssymb,bm,color}
";

        public const string CodeToWriteBB =
@"\usetikzlibrary{calc}
\newwrite\metadatafile
\immediate\openout\metadatafile=\jobname_BB.txt
\path
  let
    \p1=(current bounding box.south west),
    \p2=(current bounding box.north east)
  in
  node at (current bounding box) {
\immediate\write\metadatafile{\p1,\p2}
};
\immediate\closeout\metadatafile
";

        public const string precompilation_args = "-ini -job-name=\"" + cTempFile + "\" \"&pdflatex " + cTempFile + "pre.tex\\dump\"";
        public const string precompilation_args_img = "-ini -job-name=\"" + cTempImgFile + "\" \"&latex " + cTempImgFile + "pre.tex\\dump\"";


    }

    /// <summary>
    /// This purely static class is host to functions of global interest (or those which have no home).
    /// </summary>
    static class Helper
    {
        /// <summary>
        /// This function takes a string and removes all trailing and leading and all multiple whitespace.
        /// E.g. "  brown    fox  " -> "brown fox"
        /// </summary>
        /// <param name="inputString">the string</param>
        /// <returns>the same string, with the whitespace removed</returns>
        public static string RemoveMultipleWhitespace(string inputString)
        {
            string[] parts = inputString.Trim().Split(new char[] { ' ', '\n', '\t', '\r', '\f', '\v' }, 
                StringSplitOptions.RemoveEmptyEntries);
            return String.Join(" ", parts);
        }

        public static string GetAppDir() // w/o trailing backslash 
        {
            string appPath = "";
            try
            {
                appPath = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
                //since CodeBase returns a URI formatted string, character '#' has special meaning
                //(separating base URI from parameters)
                //however, we have a directory here. '#' is a valid, normal character here.
                appPath = appPath.Replace("#", "%23");
                appPath = System.IO.Path.GetDirectoryName(appPath);
                Uri uriAddress2 = (new Uri(appPath));
                appPath = uriAddress2.LocalPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.ToString());
            }
            return appPath;
        }

        public static string GetPrecompiledHeaderPath()
        {
            return GetAppDir() + "\\" + Consts.cTempFile;
        }

       /* public static void GeneratePrecompiledHeaders()
        {
            //StreamWriter s = new StreamWriter(Consts.cTempImgFile + "pre.tex");
            //s.WriteLine(Consts.ImgHeader);
            //s.Close();bool ImgHeader=false

            //System.Diagnostics.Process p = new System.Diagnostics.Process();
            //System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("latex");
            //psi.Arguments = Consts.precompilation_args_img;
            //psi.CreateNoWindow = true;
            //p.StartInfo = psi;
            //p.Start();
            
            StreamWriter s = new StreamWriter(Consts.cTempFile + "pre.tex");
            s.WriteLine(Properties.Settings.Default.Tex_Preamble);
            s.Close();

            System.Diagnostics.Process p = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("pdflatex");
            psi.Arguments = Consts.precompilation_args;
            psi.CreateNoWindow = true;
            p.StartInfo = psi;
            //p.Exited +=new EventHandler(Helper.precompilation_Exited);
            //needs non-static callback function.
            //however, since this function is static it cannot reach anything non-static.
            p.Start();
        } */

        public static string RemoveFileExtension(string file)
        {
            string ext = System.IO.Path.GetExtension(file);
            return file.Remove(file.Length - ext.Length, ext.Length);
        }

        public static Brush GetHatchBrush()
        {
            VisualBrush vb = new VisualBrush();

            vb.TileMode = TileMode.Tile;

            vb.Viewport = new Rect(0, 0, 5, 5);
            vb.ViewportUnits = BrushMappingMode.Absolute;

            vb.Viewbox = new Rect(0, 0, 6, 6);
            vb.ViewboxUnits = BrushMappingMode.Absolute;

            Line l = new Line();
            l.X1 = 0; l.X2 = 6; l.Y1 = 6; l.Y2 = 0;
            l.Stroke = Brushes.Black;
            vb.Visual = l;

            return vb;
        }
    }

    /*public class BBGatherer
    {
        public Rect r;
        public void Add(Point p)
        {
            if (r == null)
            {
                r = new Rect(p.X, p.Y, 0, 0);
            }
            else
            {
                r = Rect.Union(r, p);
            }
        }
        public void Add(Rect tr)
        {
            if (r == null)
            {
                r = tr;
            }
            else
            {
                r = Rect.Union(r, tr);
            }
        }
        public Rect GetRect(double margin)
        {
            return Rect.Inflate(r, margin, margin);
            //.new Rect(r.X - margin, r.Y - margin, r.Width + 2 * margin, r.Height + 2 * margin);
            //return rr;
        }
    }*/
    /*
    public static class Rasterizer
    {

        public static Point rasterizeEucl(Point p, double GridWidth, Rect BB)
        {
            return new Point(Math.Round(p.X / GridWidth) * GridWidth, Math.Round(p.Y / GridWidth) * GridWidth);
        }
        // input: p in Eucl. coordinates
        //public static Point rasterizePolar(Point p, Point center, double rstep, int nsectors)
        //{
        //Point pp = Point.eucltopolar(p, center);
        //pp.X = Math.Round(pp.X / rstep) * rstep;
        //pp.Y = Math.Round(pp.Y * nsectors / (2 * Math.PI)) * 2 * Math.PI / nsectors;
        //return Point.polartoeucl(pp, center);
        //}

    }*/


    [ValueConversion(typeof(bool), typeof(bool))]
    public class InverseBooleanConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            if (targetType != typeof(bool))
                throw new InvalidOperationException("The target must be a boolean");

            return !(bool)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }

        #endregion
    }

    [ValueConversion(typeof(Nullable<bool>), typeof(Nullable<bool>))]
    public class InverseNullableBooleanConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            if (targetType != typeof(Nullable<bool>))
                throw new InvalidOperationException("The target must be a nullable boolean");

            Nullable<bool> b = value as Nullable<bool>;            
            return !b;
        }

        public object ConvertBack(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            if (targetType != typeof(Nullable<bool>))
                throw new InvalidOperationException("The target must be a nullable boolean");

            Nullable<bool> b = value as Nullable<bool>;
            return !b;
        }

        #endregion
    }

    [ValueConversion(typeof(ICSharpCode.AvalonEdit.Document.TextDocument), typeof(ICSharpCode.AvalonEdit.Document.TextDocument))]
    public class AvalonEditDocConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            if (targetType != typeof(ICSharpCode.AvalonEdit.Document.TextDocument))
                throw new InvalidOperationException("The target must be a boolean");

            return (ICSharpCode.AvalonEdit.Document.TextDocument)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }

        #endregion
    }

    [ValueConversion(typeof(Severity), typeof(ImageSource))]
    public sealed class SeverityImageConverter : IValueConverter
    {
        static BitmapSource WarningBmp, ErrorBmp, DefaultBmp;

        static SeverityImageConverter()
        {
            System.Drawing.Icon icon = System.Drawing.SystemIcons.Warning;
            WarningBmp = System.Windows.Interop.Imaging.CreateBitmapSourceFromHIcon(icon.Handle, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
            icon = System.Drawing.SystemIcons.Error;
            ErrorBmp = System.Windows.Interop.Imaging.CreateBitmapSourceFromHIcon(icon.Handle, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            DefaultBmp = null;
        }

        public object Convert(object value, Type targetType,
                              object parameter, System.Globalization.CultureInfo culture)
        {
            if (targetType != typeof(ImageSource))
                throw new InvalidOperationException("The target must be ImageSource");
            Severity s = (Severity) value;
            switch (s)
            {
                case Severity.ERROR:
                    return ErrorBmp;
                case Severity.WARNING:
                    return WarningBmp;
                default:
                    return DefaultBmp;
            }
        }

        public object ConvertBack(object value, Type targetType,
                                  object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
