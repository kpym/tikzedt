using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TikzEdt.Parser;
using System.Windows.Media;

namespace TikzEdt.WpfSpecificComponents
{
    public static class ParserExtension
    {
        public static Matrix ToWpfMatrix(this TikzMatrix M)
        {
            // Which is correct? I think the first
            return new Matrix(M.m[0, 0], M.m[1, 0], M.m[0, 1], M.m[1, 1], M.m[0, 2], M.m[1, 2]);
            //return new Matrix(m[0, 0], m[0, 1], m[1, 0], m[1, 1], m[0, 2], m[1, 2]);
        }

    }
}
