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
using System.Windows.Input;
using System.Windows.Shapes;
using System.Windows.Media;
using TikzEdt.Parser;

namespace TikzEdt
{
    class SmoothCurveTool : OverlayAdderTool
    {
        public override void OnActivate() 
        {
            base.OnActivate();
            overlay.canvas.Cursor = Cursors.Cross;
        }

        /// <summary>
        /// The base curaddto only adds a \draw ;
        /// We also need to add a plot coordinates {   }
        /// </summary>
        /// <param name="created"></param>
        /// <returns></returns>
        protected override bool EnsureCurAddToExists(out bool created)
        {
            bool ret=base.EnsureCurAddToExists(out created);
            if (!ret)
                return ret;

            if (created)
            {
                curAddTo.AddChild(new Tikz_Something(" plot"));

                Tikz_Options topts = new Tikz_Options();
                topts.starttag = "[";
                topts.endtag = "]";
                smoothOption = topts.AddOption("smooth");
                topts.AddOption("tension", ".7");

                curAddTo.options = topts;
                curAddTo.AddChild(topts);
                curAddTo.AddChild(new Tikz_Something(" coordinates "));

                Tikz_Path tp = new Tikz_Path();
                tp.starttag = "{";
                tp.endtag = "}";
                curAddTo.AddChild(tp);

                curAddTo = tp;
            }

            return ret;
        }
        Tikz_Option smoothOption; // this has to be changed to smooth cycle for closed curve

        public override void OnLeftMouseButtonDown(OverlayShape item, Point p, MouseButtonEventArgs e) 
        {
            if (!EnsureParseTreeExists())
                return;

            p = overlay.Rasterizer.RasterizePixelToTikz(p);
            if (ContinueWithBigImage(p) == false)
                return;

            overlay.BeginUpdate();

            overlay.SetCorrectRaster(overlay.CurEditing, true);

            //Point p = new Point(e.GetPosition(canvas1).X, Height - e.GetPosition(canvas1).Y);


            // find tikzpicture and add
            bool lcreated;
            if (EnsureCurAddToExists(out lcreated))
            {
                // on double click -> close path
                if (e.ClickCount == 2)
                {
                    if (!lcreated)
                    {
                        smoothOption.key = "smooth cycle";
                        smoothOption.UpdateText();
                    }
                }
                else
                {
                    if (!lcreated)
                    {
                        // for prettier formatting
                        curAddTo.AddChild(new Parser.Tikz_Something(" "));
                    }

                    // create new coordinate
                    Parser.Tikz_Coord tc = new Parser.Tikz_Coord();
                    tc.type = overlay.UsePolarCoordinates ? Parser.Tikz_CoordType.Polar : Parser.Tikz_CoordType.Cartesian;
                    curAddTo.AddChild(tc);
                    if (item is OverlayNode && IsReferenceable(item))
                    {
                        Tikz_Node tn = MakeReferenceableNode((item as OverlayNode).tikzitem);
                        tc.type = Tikz_CoordType.Named;
                        tc.nameref = tn.name;
                    }
                    else
                    {
                        // do it here since the coordinate calculation needs the parents' coord. transform
                        tc.SetAbsPos(new Point(p.X, p.Y)); 
                    }

                    //tn.UpdateText();
                    curAddTo.UpdateText();
                    //tpict.UpdateText();

                    // draw the added object in the overlay
                    overlay.AddToDisplayTree(tc);
                }
            }

            overlay.EndUpdate();

            // doubleclick also stops path drawing
            if (e.ClickCount == 2)
                overlay.ActivateDefaultTool();
        }
    }
}
