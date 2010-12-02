using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.IO;

namespace TikzEdt
{
    static class Consts
    {
        public const float cmperin = 2.54F;
        public const float ptspertikzunit = 72.0F / cmperin;
        public const float TikzDefaultLinewidth = 0;
        public const string TikzDefaultFont = "Times";
        public const float TikzDefaultFontSize = 8F;
        public const int TikzImgResolution = 300; // resolution in dpi with which images are compiled

        public static string[] TikzArrowTipCodes = new string[] { "", ">", "<" };
        //public static DashStyle[] TikzToSystemDashStyle = new DashStyle[] { DashStyle.Solid, DashStyle.Dot, DashStyle.Dash };
        public static float[][] TikzToSystemDashPattern = new float[][] {
            new float[]{0.1F}, new float[]{.1F,.1F}, new float[]{.2F,.1F}
        };

        public const string cSettingsFile = "T2Gsettings.xml";
        public const string cSyntaxFile = "TikzSyntax.xshd";
        public const string cMRUFile = "T2GMRU.xml";
        public const int MaxMRU = 10;
        public const string cStyleRepoFile = "StyleRepo.dat";

        public const string CoordinateVertexStyleName = "helper";

        public const string DoubleFormat = "#.####";

        public const float selecttoler = .01F;
        public const float drawXsize = .1F; // drawn for invisible vertices
        public const float coordvertexsize = .25F; // size of size zero vertex (to ease selection)

        //const string cLatex = "Pdflatex";
        //string cLatexPath = "pdflatex"; //@"C:\Program Files\MiKTeX 2.8\miktex\bin\pdfplatex.exe";
        public const string cTempFile = "temp_preview";         // for preview
        public const string cTempImgFile = "temp_previewtexts"; // for equation rendering
        public const string defaultCurFile = "<new graph>";
        public const string PreviewHeader =
        @"\documentclass[fleqn]{article}
\usepackage{tikz,amsmath, amssymb,bm,color}
\usepackage[margin=0cm,nohead]{geometry}
";

        public const string ImgHeader =
        @"\documentclass[fleqn]{article}
\usepackage{amsmath, amssymb,bm,color}
";

        public const string precompilation_args = "-ini -job-name=\"" + cTempFile + "\" \"&pdflatex " + cTempFile + "pre.tex\\dump\"";
        public const string precompilation_args_img = "-ini -job-name=\"" + cTempImgFile + "\" \"&latex " + cTempImgFile + "pre.tex\\dump\"";


    }

    static class Helper
    {

        public static void GeneratePrecompiledHeaders()
        {
            StreamWriter s = new StreamWriter(Consts.cTempImgFile + "pre.tex");
            s.WriteLine(Consts.ImgHeader);
            s.Close();

            System.Diagnostics.Process p = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("latex");
            psi.Arguments = Consts.precompilation_args_img;
            psi.CreateNoWindow = true;
            p.StartInfo = psi;
            p.Start();

            s = new StreamWriter(Consts.cTempFile + "pre.tex");
            s.WriteLine(Consts.PreviewHeader);
            s.Close();

            p = new System.Diagnostics.Process();
            psi = new System.Diagnostics.ProcessStartInfo("pdflatex");
            psi.Arguments = Consts.precompilation_args;
            psi.CreateNoWindow = true;
            p.StartInfo = psi;
            p.Start();
        }

    }

    public class BBGatherer
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
    }

    public static class Rasterizer
    {

        public static Point rasterizeEucl(Point p, double GridWidth, Rect BB )
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

    }
}
