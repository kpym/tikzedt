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
using TikzEdt.Overlay;

namespace TikzEdt
{
    class BezierTool : OverlayAdderTool
    {
        Point CP1, CP2; // the control points
        IEllipseShape Preview_CP1, Preview_CP2;
        int CPCount = 0;

        public BezierTool(OverlayInterface overlay) : base(overlay)
        {
            Preview_CP1 = overlay.ShapeFactory.GetCPCircle();
            Preview_CP2 = overlay.ShapeFactory.GetCPCircle();
        }

        public override void OnActivate()
        {
            base.OnActivate();
            ////overlay.canvas.Cursor = Cursors.Cross;
            overlay.SetCursor(System.Windows.Forms.Cursors.Cross);
            CPCount = 0;            
        }

        public override void OnDeactivate()
        {
            base.OnDeactivate();
            Preview_CP1.Visible = Preview_CP2.Visible = false;
        }

        public override void OnLeftMouseButtonDown(OverlayShape item, Point p, MouseButtonEventArgs e)
        {
            if (!EnsureParseTreeExists())
                return;

            Point prast = overlay.Rasterizer.RasterizePixel(p);
            p = overlay.Rasterizer.RasterizePixelToTikz(p);
            if (ContinueWithBigImage(p) == false)
                return;

            overlay.BeginUpdate();

            overlay.SetCorrectRaster(overlay.CurEditing, true);

            //Point p = new Point(e.GetPosition(canvas1).X, Height - e.GetPosition(canvas1).Y);


            // find next tikzpicture and add
            bool lcreated;
            if (EnsureCurAddToExists(out lcreated))
            {
                {
                    // there are three states:  (i)   new path -> add coordinate
                    //                          (ii)  add controlpoints
                    //                          (iii) 2 cps's added -> add bezier segment
                    if (CPCount == 2)
                    {
                        // add controls
                        Tikz_Controls tcont = new Tikz_Controls();
                        tcont.starttag = " .. controls ";
                        tcont.endtag = " ..";
                        Parser.Tikz_Coord tc1 = new Parser.Tikz_Coord(), tc2 = new Parser.Tikz_Coord(); // control points
                        tc1.type = tc2.type = overlay.UsePolarCoordinates ? Parser.Tikz_CoordType.Polar : Parser.Tikz_CoordType.Cartesian;

                        tcont.AddChild(tc1);
                        tcont.AddChild(new Tikz_Something(" and "));
                        tcont.AddChild(tc2);

                        curAddTo.AddChild(tcont);

                        // the endpoint
                        Parser.Tikz_Coord tcend = new Parser.Tikz_Coord();
                        tcend.type = overlay.UsePolarCoordinates ? Parser.Tikz_CoordType.Polar : Parser.Tikz_CoordType.Cartesian;
                        curAddTo.AddChild(new Tikz_Something(" "));
                        curAddTo.AddChild(tcend);
                        
                        // do it here since the coordinate calculation needs the parents' coord. transform, and the second added point 
                        tcend.SetAbsPos(p);                        
                        tc1.SetAbsPos(CP1);
                        tc2.SetAbsPos(CP2);
 
                        tcont.UpdateText();
                        tcend.UpdateText();

                        // draw the added objects in the overlay
                        overlay.AddToDisplayTree(tcend);
                        overlay.AddToDisplayTree(tcont);

                        CPCount = 0;
                        Preview_CP1.Visible = Preview_CP2.Visible = false;
                    }
                    else if (lcreated)
                    {
                        // add starting point
                        // create new coordinate
                        Parser.Tikz_Coord tc = new Parser.Tikz_Coord();
                        tc.type = overlay.UsePolarCoordinates ? Parser.Tikz_CoordType.Polar : Parser.Tikz_CoordType.Cartesian;
                        curAddTo.AddChild(tc);
                        // do it here since the coordinate calculation needs the parents' coord. transform
                        tc.SetAbsPos(new Point(p.X, p.Y)); //hack
                        curAddTo.UpdateText();                        
                        // draw the added object in the overlay
                        overlay.AddToDisplayTree(tc);

                        CPCount = 0;
                    } else 
                    {
                        // remember control points
                        if (CPCount == 0)
                        {
                            CP1 = p;

                            Preview_CP1.SetPosition(prast.X, prast.Y);
                            ////Canvas.SetLeft(Preview_CP1, prast.X - Preview_CP1.Width / 2);
                            ////Canvas.SetBottom(Preview_CP1, prast.Y - Preview_CP1.Height / 2);
                            ////if (!overlay.canvas.Children.Contains(Preview_CP1))
                            ////    overlay.canvas.Children.Add(Preview_CP1);
                            ////Preview_CP1.Visibility = Visibility.Visible;
                            Preview_CP1.Visible = true;
                        }
                        else if (CPCount == 1)
                        {
                            CP2 = p;
                            Preview_CP2.SetPosition(prast.X, prast.Y);
                            ////Canvas.SetLeft(Preview_CP2, prast.X - Preview_CP2.Width / 2);
                            ////Canvas.SetBottom(Preview_CP2, prast.Y - Preview_CP2.Height / 2);
                            ////if (!overlay.canvas.Children.Contains(Preview_CP2))
                            ////    overlay.canvas.Children.Add(Preview_CP2);
                            ////Preview_CP2.Visibility = Visibility.Visible;
                            Preview_CP2.Visible = true;
                        }
                        CPCount++;
                    }
                }
            }

            overlay.EndUpdate();
        }
    }
}
