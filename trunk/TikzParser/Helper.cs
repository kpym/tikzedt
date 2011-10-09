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
//using System.Drawing;
using System.Diagnostics;
using System.Security.Permissions;
using System.Security;
using System.Globalization;
using System.Windows;

//using System.Drawing;

namespace TikzEdt.Parser
{
    /// <summary>
    /// Please put all global constants that are not in the Properties.Settings into this static class.
    /// </summary>
    static class Consts
    {
        public const double cmperin = 2.54;
        public const double ptspertikzunit = 28.45;//72.0 / cmperin; // 28.3464567
        public const double cmperem = 10 / Consts.ptspertikzunit;   // this is a hack
        public const double cmperex = 4.3 / Consts.ptspertikzunit;  // this too
        public const double TikzDefaultLinewidth = 0;
        public const string TikzDefaultFont = "Times";
        public const double TikzDefaultFontSize = 8;
        public const int TikzImgResolution = 300; // resolution in dpi with which images are compiled
  
        public const string DoubleFormat = "#.####";

        public const float selecttoler = .01F;
        public const float drawXsize = .1F; // drawn for invisible vertices
        public const float coordvertexsize = .25F; // size of size zero vertex (to ease selection)

        // TODO: tie this to the global setting
        public static uint RoundToDecimals = 4;
    }

    /// <summary>
    /// This purely static class is host to functions of global interest (or those which have no home).
    /// </summary>
    public static class Helper
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
          
        /// <summary>
        /// Finds the point in (angle + 2 Pi \Z) closest to (closeto)
        /// </summary>
        /// <param name="angle"></param>
        /// <param name="closeto"></param>
        /// <returns></returns>
        public static double ClosestPt(double angle, double closeto)
        {
            double diff = angle - closeto;
            return angle - Math.Round(diff / (2 * Math.PI)) * 2 * Math.PI;
        }
        public static double ClosestPtDeg(double angle, double closeto)
        {
            double diff = angle - closeto;
            return angle - Math.Round(diff / (360)) * 360;
        }

        /// <summary>
        /// Count occurrences of strings.
        /// </summary>
        public static int CountStringOccurrences(string text, string pattern)
        {
            // Loop through all instances of the string 'text'.
            int count = 0;
            int i = 0;
            while ((i = text.IndexOf(pattern, i)) != -1)
            {
                i += pattern.Length;
                count++;
            }
            return count;
        }

        /// <summary>
        /// Converts Cartesian to polar (standard, does not use the coordinate transf.)
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Point CartToPol(Point p)
        {
            double r = Math.Sqrt(p.X * p.X + p.Y * p.Y);
            double phi = Math.Atan2(p.Y, p.X);
            return new Point(r, phi);
        }
        /// <summary>
        /// Converts polar to Cartesian (standard, does not use the coordinate transf.)
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Point PolToCart(Point p)
        {
            return new Point(p.X * Math.Cos(p.Y), p.X * Math.Sin(p.Y));
        }

        /// <summary>
        /// Tikz convention, i.e. (angle in degrees, radius) 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Point CartToPolTC(Point p)
        {
            Point pp = CartToPol(p);
            return new Point(
                Math.Round(180 * pp.Y / Math.PI),
                Math.Round(pp.X, (int)(Consts.RoundToDecimals))
                );
        }

        public static Point PolToCartTC(Point p)
        {
            Point pp = new Point(p.Y, p.X * Math.PI / 180);
            return PolToCart(pp);
        }
    }

    
}
