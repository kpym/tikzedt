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
    /// <summary>
    /// This class is dedicated to modify arcs.
    /// Arc modification can hardly be included in the usual Move-Tool for the following reasons:    
    ///     1. There are too many free parameters (2 angles and radius, vs just 2 coordinates).
    ///     2. There are inherent ambiguities when moving multiple nodes (-> ArcEditTool is single-select)
    ///     3. Often multiple coordinates have to be changed, for example if one changes the radius in a chain
    ///         ... arc(...) arc(...) arc (...)
    ///        of arcs of the same radius, one should change the radius for each arc.
    /// </summary>
    class ArcEditTool : OverlayAdderTool
    {
        ArcShape PreviewArc = new ArcShape();
        // all these points are in bottom left centered coordinates (as in LaTeX)
        OverlayShape curDragged;
        Point DragOrigin; // relative to the currently dragged object
        Point DragOriginC; // Mouse position on Canvas when started dragging
        Point DragOriginO; // bottom left of dragged object
        bool movedenough = false;   // is set to true when mouse moved more than xx pixels. This is to prevent accidental dragging


        public ArcEditTool()
        {
            PreviewArc.Stroke = Brushes.Black;
            PreviewArc.StrokeDashArray = new DoubleCollection(new double[] { 4, 4 });
            PreviewArc.Visibility = Visibility.Collapsed;
        }

        public override void OnActivate()
        {
            overlay.canvas.Cursor = Cursors.Arrow;
            PreviewArc.overlay = overlay;
        }
        public override void OnDeactivate()
        {
            PreviewArc.Visibility = Visibility.Collapsed;
        }


        public override void OnLeftMouseButtonDown(OverlayShape item, Point p, MouseButtonEventArgs e)
        {
            //IInputElement o = canvas1.InputHitTest(e.GetPosition(canvas1));

            if (item is OverlayShape)
            {
                // initiate a drag/drop operation
                curDragged = (OverlayShape)item;
                DragOrigin = e.GetPosition(item);
                DragOrigin = new Point(DragOrigin.X, (item as OverlayShape).Height - DragOrigin.Y);
                DragOriginC = p;
                DragOriginO = new Point(Canvas.GetLeft(curDragged), Canvas.GetBottom(curDragged));
                movedenough = false;
                //MessageBox.Show(o.ToString());

                // select the clicked shape
      /*          if (Keyboard.Modifiers.HasFlag(ModifierKeys.Control))
                {
                    if (!ToggleItem(curDragged))
                    {
                        // unselected -> start no drag operation
                        curDragged = null;
                    }
                }
                else
                {
                    AddItem(curDragged, !IsItemSelected(curDragged));
                }*/

                // adjust raster origin/scale/polar/cartesian
                overlay.SetCorrectRaster(curDragged);

                // for an arc, display preview
                if (curDragged.item is Tikz_Arc)
                {
                    PreviewArc.AdjustPos(curDragged.item as Tikz_Arc);
                    PreviewArc.Visibility = Visibility.Visible;
                    if (!overlay.canvas.Children.Contains(PreviewArc))
                        overlay.canvas.Children.Add(PreviewArc);
                }

                // capture mouse. this is important if the user drags sth. outside canvas1's bounds
                if (curDragged != null && !overlay.canvas.IsMouseCaptured)
                    overlay.canvas.CaptureMouse();
            }
            


        }


        public override void OnMouseMove(Point p, MouseEventArgs e)
        {
            Point mousep = e.GetPosition(overlay.canvas);

            // start a drag operation only after the mouse moved at least xx pixels to avoid accidental moving
            if ((DragOriginC - p).Length > 5)
                movedenough = true;
            // for a dragged scope, the relative movement gets rasterized
            // for a dragged node, the center of the node gets rasterized
            if (curDragged != null && e.LeftButton == MouseButtonState.Pressed && movedenough)
            {
                if (curDragged is OverlayScope)
                {
                    // total shift
                    Point relshift_pixel = new Point(p.X - DragOriginC.X, p.Y - DragOriginC.Y);
                    relshift_pixel = overlay.Rasterizer.RasterizePixelRelative(relshift_pixel);
                    // shift yet to be done
                    Point relshift_tobedone = new Point(
                         DragOriginO.X + relshift_pixel.X - Canvas.GetLeft(curDragged),
                         DragOriginO.Y + relshift_pixel.Y - Canvas.GetBottom(curDragged)
                        );

                    //ShiftSelItemsOnScreen(relshift_tobedone);
                }
                else if (curDragged is OverlayNode)
                {
                    // use width instead actual width
                    Point center_pixel = new Point(p.X - DragOrigin.X + curDragged.Width / 2,
                                                   p.Y - DragOrigin.Y + curDragged.Height / 2);
                    // the center pixel of the node should go here
                    center_pixel = overlay.Rasterizer.RasterizePixel(center_pixel);

                    // shift yet to be done
                    Point relshift_tobedone = new Point(
                         center_pixel.X - Canvas.GetLeft(curDragged) - curDragged.Width / 2,
                         center_pixel.Y - Canvas.GetBottom(curDragged) - curDragged.Height / 2
                        );
                    //ShiftSelItemsOnScreen(relshift_tobedone);

                    // for arc, update preview
                    if (curDragged.item is Tikz_Arc)
                    {
                        PreviewArc.AdjustPreviewPos(center_pixel);
                    }
                }
            }
        }

        public override void OnLeftMouseButtonUp(MouseButtonEventArgs e, Point p)
        {

            // adjust position of dragged item (in parsetree)
            if (curDragged != null && movedenough)
            {
                PreviewArc.Visibility = Visibility.Collapsed;

                overlay.BeginUpdate();
                // determine the relative shift
                Point relshift = new Point(Canvas.GetLeft(curDragged) - DragOriginO.X, Canvas.GetBottom(curDragged) - DragOriginO.Y);
                Point relshift_tikz = new Point(relshift.X / overlay.Resolution, relshift.Y / overlay.Resolution);
               // ShiftSelItemsInParseTree(relshift_tikz, overlay.TopLevelItems);
                /*
                Point pp = new Point(Canvas.GetLeft(curDragged) + curDragged.Width / 2, Canvas.GetBottom(curDragged) + curDragged.Height / 2);
                pp = ScreenToTikz(pp);
                if (curDragged is OverlayNode)
                {
                    (curDragged as OverlayNode).tikzitem.SetAbsPos(pp);
                    (curDragged as OverlayNode).tikzitem.UpdateText();

                }
                else if (curDragged is OverlayScope)
                {
                    Point pdiff = new Point(e.GetPosition(canvas1).X - DragOriginC.X, e.GetPosition(canvas1).Y - DragOriginC.Y);
                    pdiff = rasterizer.RasterizePixel(pdiff);

                    double xs = pdiff.X / Resolution, ys = -pdiff.Y / Resolution;

                    curDragged.ShiftItemRelative(pdiff);
                }*/
                // update all item's positions
                foreach (OverlayShape o in overlay.TopLevelItems)
                    o.AdjustPosition(overlay.Resolution);

                curDragged = null;

                overlay.EndUpdate();
            }
        }


        public override void KeyDown(KeyEventArgs e)
        {
            base.KeyDown(e);
            if (PreviewArc.Visibility == Visibility.Visible)
                PreviewArc.AdjustPreviewPos();
        }
        public override void KeyUp(KeyEventArgs e)
        {
            base.KeyUp(e);

            if (PreviewArc.Visibility == Visibility.Visible)
                PreviewArc.AdjustPreviewPos();
        }





        class ArcShape : Shape
        {
            double X { get; set; }
            double Y { get; set; }
            double phi1 { get; set; }
            double phi2 { get; set; }
            double r { get; set; }

            public OverlayInterface overlay;

            /// <summary>
            /// Sets the parameters according to the Tikz_Arc's parameters
            /// </summary>
            /// <param name="arc"></param>
            public void AdjustPos(Tikz_Arc arc)
            {
                Point p;
                if (!arc.GetStartPointAbs(out p))
                    throw new Exception("Broken Arc.");

                p = overlay.TikzToScreen(p);

                X = p.X;
                Y = p.Y;
                phi1 = Math.PI * arc.phi1.GetInCM() / 180;
                phi2 = Math.PI * arc.phi2.GetInCM() / 180;

                Point c;
                arc.GetArcCenterAbs(out c);
                c = overlay.TikzToScreen(c);
                r = (c - p).Length;

                InvalidateVisual();
            }

            public Point center
            {
                get
                {
                    return new Point(X - r * Math.Cos(phi1), Y - r * Math.Sin(phi1));
                }
            }
            /// <summary>
            /// Adjusts whether to display larger/smaller arc
            /// </summary>
            public void AdjustPreviewPos()
            {
                double d = phi2 - phi1;
                if (Keyboard.Modifiers.HasFlag(ModifierKeys.Shift) != (Math.Abs(d) > Math.PI))
                    d -= 2 * Math.PI * Math.Sign(d);
                phi2 = phi1 + d;
                InvalidateVisual();
            }
            public void AdjustPreviewPos(Point p)
            {
                double newa = Math.Atan2(p.Y - center.Y, p.X - center.X);
                phi2 = newa;
                AdjustPreviewPos();
            }

            /// <summary>
            /// In pixel coordinates, not upside down!
            /// </summary>
            Point EndPoint
            {
                get
                {
                    return new Point(X + r * Math.Cos(phi2) - r * Math.Cos(phi1), overlay.Height - (Y + r * Math.Sin(phi2) - r * Math.Sin(phi1)));
                }
            }

            protected override Geometry DefiningGeometry
            {
                get
                {
                    // Create a StreamGeometry for describing the shape
                    StreamGeometry geometry = new StreamGeometry();
                    geometry.FillRule = FillRule.EvenOdd;

                    using (StreamGeometryContext context = geometry.Open())
                    {
                        InternalDrawNodeGeometry(context);
                    }

                    // Freeze the geometry for performance benefits
                    //geometry.Freeze();

                    return geometry;
                }
            }


            /// <summary>
            /// Draw an arc
            /// </summary>
            /// <param name="context"></param>
            private void InternalDrawNodeGeometry(StreamGeometryContext context)
            {
                context.BeginFigure(new Point(X, overlay.Height - Y), false, false);
                bool largearc = Math.Abs(phi2 - phi1) > Math.PI;
                SweepDirection sd = SweepDirection.Counterclockwise;
                if (phi2 < phi1)
                    sd = SweepDirection.Clockwise;

                context.ArcTo(EndPoint, new Size(r, r), 0, largearc, sd, true, false);

            }

        }

    }
}
