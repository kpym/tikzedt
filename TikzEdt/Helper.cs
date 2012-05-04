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
using System.Windows.Shapes;
//using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Windows.Threading;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security;
using Microsoft.Win32;
using System.Globalization;


namespace TikzEdt
{

    public class FileAssociation
    {
        // Associate file extension with progID, description, icon and application
        public static void Associate(string extension,
               string progID, string description, string icon, string application)
        {
            Registry.ClassesRoot.CreateSubKey(extension).SetValue("", progID);
            if (progID != null && progID.Length > 0)
                using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(progID))
                {
                    if (description != null)
                        key.SetValue("", description);
                    if (icon != null)
                        key.CreateSubKey("DefaultIcon").SetValue("", ToShortPathName(icon));
                    if (application != null)
                        key.CreateSubKey(@"Shell\Open\Command").SetValue("",
                                    ToShortPathName(application) + " \"%1\"");
                }
        }

        // Return true if extension already associated in registry
        public static bool IsAssociated(string extension)
        {
            return (Registry.ClassesRoot.OpenSubKey(extension, false) != null);
        }

        [DllImport("Kernel32.dll")]
        private static extern uint GetShortPathName(string lpszLongPath,
            [Out] StringBuilder lpszShortPath, uint cchBuffer);

        // Return short path format of a file name
        private static string ToShortPathName(string longName)
        {
            StringBuilder s = new StringBuilder(1000);
            uint iSize = (uint)s.Capacity;
            uint iRet = GetShortPathName(longName, s, iSize);
            return s.ToString();
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

    class PropertiesParserSettings : TikzEdt.Parser.ParserSettings
    {
        public override uint RoundToDecimals
        {
            get
            {
                return Properties.Settings.Default.RoundToDecimals;
            }
        }
    }

    /// <summary>
    /// This class ties the settings of the viewmodel assembly to the global settings
    /// </summary>
    class PropertiesCompilerSettings : CompilerSettings
    {
        public override double BB_Std_X { get { return Properties.Settings.Default.BB_Std_X; } }
        public override double BB_Std_Y { get { return Properties.Settings.Default.BB_Std_Y; } }
        public override double BB_Std_W { get { return Properties.Settings.Default.BB_Std_W; } }
        public override double BB_Std_H { get { return Properties.Settings.Default.BB_Std_H; } }
        public override double BB_Margin { get { return Properties.Settings.Default.BB_Margin; } }
        public override string Tex_Preamble { get { return Properties.Settings.Default.Tex_Preamble; } }
        public override string Tex_Postamble { get { return Properties.Settings.Default.Tex_Postamble; } }

        public override string PrecompiledHeaderCompileCommand { get { return Properties.Settings.Default.PrecompiledHeaderCompileCommand;  } }
        public override int Compiler_SnippetTimeout { get { return Properties.Settings.Default.Compiler_SnippetTimeout; } }
        public override int Compiler_Timeout { get { return Properties.Settings.Default.Compiler_Timeout; } }
        public override string Path_pdflatex { get { return Properties.Settings.Default.Path_pdflatex; } }
        public override string Path_htlatex { get { return Properties.Settings.Default.Path_htlatex; } }


        public override uint RoundToDecimals { get { return Properties.Settings.Default.RoundToDecimals; } }

        public override bool UseExternalRenderer
        {
            get
            {
                return Properties.Settings.Default.UseExternalRenderer;
            }
        }
    }


}
