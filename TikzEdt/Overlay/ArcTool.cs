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
    class ThreePointArc : Shape
    {
        public Point p1, p2, center;
        public bool IsPie {get; set; }       
 
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

        double r { get { return (p1 - center).Length; } }
        public bool LargeArc { get; set; } 

        /// <summary>
        /// Draw an arc
        /// </summary>
        /// <param name="context"></param>
        private void InternalDrawNodeGeometry(StreamGeometryContext context)
        {
            context.BeginFigure(p1, false, IsPie);
            Vector v1 = p1 - center, v2 = p2 - center;
            SweepDirection sd;
            if ((v1.X*v2.Y - v1.Y*v2.X > 0) != LargeArc)
                sd = SweepDirection.Clockwise;
            else 
                sd = SweepDirection.Counterclockwise;            

            context.ArcTo(p2, new Size(r, r), 0, LargeArc, sd, true, false);
            if (IsPie)
            {
                context.LineTo(center, true, false);
                context.LineTo(p1, true, false);
            }

        }

    }

    class ArcTool : OverlayAdderTool
    {
        int pointcount = 0;
        // points are in Tikz coordinates
        Point center, p1;
        ThreePointArc PreviewArc = new ThreePointArc(), PreviewPie = new ThreePointArc();

        public ArcTool(OverlayInterface overlay) : base(overlay)
        {
            PreviewArc.Stroke = PreviewPie.Stroke = Brushes.Black;
            PreviewPie.Visibility = PreviewArc.Visibility = Visibility.Collapsed;
            PreviewPie.IsPie = true;
        }
        public override void OnDeactivate()
        {
            base.OnDeactivate();
            PreviewPie.Visibility = PreviewArc.Visibility = Visibility.Collapsed;
            overlay.Rasterizer.View.ForceRadiusTo = -1;
            overlay.SetCorrectRaster(overlay.CurEditing, true); // don't keep our temporary polar raster
        }
        public override void OnActivate() 
        {
            base.OnActivate();
            ////overlay.canvas.Cursor = Cursors.Cross;
            overlay.SetCursor(System.Windows.Forms.Cursors.Cross);
            overlay.SetCorrectRaster(overlay.CurEditing, true);

            pointcount = 0;
            
        }
        public override void OnMouseMove(Point p, MouseEventArgs e)
        {
            base.OnMouseMove(p, e);
            p = overlay.Rasterizer.RasterizePixel(p);

            if (pointcount > 0)
                UpdatePreviewDisplay(p);

        }
        public override void KeyDown(KeyEventArgs e)
        {
            base.KeyDown(e);
            UpdatePreviewDisplay();
        }
        public override void KeyUp(KeyEventArgs e)
        {
            base.KeyUp(e);
            UpdatePreviewDisplay();
        }
        
        public override void OnLeftMouseButtonDown(OverlayShape item, Point p, MouseButtonEventArgs e) 
        {
            if (!EnsureParseTreeExists())
                return;

            Point ptikz = overlay.Rasterizer.RasterizePixelToTikz(p);
            p = overlay.Rasterizer.RasterizePixel(p);
            if (ContinueWithBigImage(ptikz) == false)
                return;           

            if (pointcount == 0)
            {
                //overlay.SetCorrectRaster(overlay.CurEditing, true);
                center = ptikz;

                // set raster to polar, and such that origin is at center
                overlay.Rasterizer.View.IsCartesian = false;
                TikzMatrix M = overlay.Rasterizer.View.CoordinateTransform;
                M.m[0, 2] = center.X;
                M.m[1, 2] = center.Y;
                overlay.Rasterizer.View.CoordinateTransform = M;
                pointcount = 1;

                PreviewPie.center = PreviewArc.center = new Point(p.X, overlay.Height - p.Y);

                if (!overlay.canvas.Children.Contains(PreviewArc))
                    overlay.canvas.Children.Add(PreviewArc);
                if (!overlay.canvas.Children.Contains(PreviewPie))
                    overlay.canvas.Children.Add(PreviewPie);
            }
            else if (pointcount == 1)
            {
                p1 = ptikz;
                pointcount = 2;
                PreviewPie.p1 = PreviewArc.p2 = new Point(p.X, overlay.Height - p.Y);

                // compute radius 
                TikzMatrix M = overlay.Rasterizer.View.CoordinateTransform;
                Point ploc = M.Inverse().Transform(p1);
                overlay.Rasterizer.View.ForceRadiusTo = (ploc - (new Point(0, 0))).Length;

            }
            else if (pointcount == 2)
            {
                // **** create arc / pie ****
                overlay.BeginUpdate();
                // find next tikzpicture and add
                if (AddNewCurAddTo()) //(EnsureCurAddToExists(out lcreated))
                {

                    // Pie?                    
                    if (IsPie)
                    {
                        // create new coordinate
                        Tikz_Coord tc = new Parser.Tikz_Coord();
                        tc.type = overlay.UsePolarCoordinates ? Parser.Tikz_CoordType.Polar : Parser.Tikz_CoordType.Cartesian;
                        curAddTo.AddChild(tc);
                        tc.SetAbsPos(center);
                        curAddTo.AddChild(new Parser.Tikz_Something(" -- "));
                    }

                    Tikz_Coord tc1 = new Parser.Tikz_Coord();
                    if (IsPie)
                    {
                        tc1.type = Tikz_CoordType.Polar;
                        tc1.deco = "++";
                    }
                    curAddTo.AddChild(tc1);
                    tc1.SetAbsPos(p1);
                    curAddTo.AddChild(new Parser.Tikz_Something(" "));

                    // create arc                    
                    Tikz_Arc ta = new Tikz_Arc();                    
                    curAddTo.AddChild(ta);
                    ta.SetFromPoints(center, ptikz, IsLargeArc);
                    
                    if (IsPie)
                        curAddTo.AddChild(new Parser.Tikz_Something(" -- cycle"));

                    //tn.UpdateText();
                    curAddTo.UpdateText();
                    //tpict.UpdateText();

                    // draw the added object in the overlay
                    overlay.AddToDisplayTree(curAddTo);

                }

                overlay.EndUpdate();

                // reset everything
                pointcount = 0;
                overlay.Rasterizer.View.ForceRadiusTo = -1;
                overlay.SetCorrectRaster(overlay.CurEditing, true);
            }
            //Point p = new Point(e.GetPosition(canvas1).X, Height - e.GetPosition(canvas1).Y);
            UpdatePreviewDisplay(p);

        }

        bool IsPie { get { return Keyboard.Modifiers.HasFlag(ModifierKeys.Control); } }
        bool IsLargeArc { get { return Keyboard.Modifiers.HasFlag(ModifierKeys.Shift); } }

        /// <summary>
        /// Set the Preview Arc/Pie to the correct position(s)
        /// </summary>
        /// <param name="curMousePos">The (rasterized) mouse position, in (upside down) pixel coordinates.</param>
        void UpdatePreviewDisplay(Point curMousePos)
        {
            curMousePos = new Point(curMousePos.X, overlay.Height - curMousePos.Y);
            if (pointcount == 1)
            {                
                PreviewPie.p1 = PreviewPie.p2 = PreviewArc.p1 = PreviewArc.p2 = curMousePos;            
            }
            else if (pointcount == 2)
            {
                PreviewArc.p2 = PreviewPie.p2 = curMousePos;                
            }
            UpdatePreviewDisplay();
        }
        void UpdatePreviewDisplay()
        {
            if (pointcount == 0)
            {
                PreviewArc.Visibility = PreviewPie.Visibility = Visibility.Hidden;
            }
            else 
            {
                PreviewArc.LargeArc = PreviewPie.LargeArc = IsLargeArc;
                if (IsPie)
                {
                    PreviewPie.StrokeDashArray = null;
                    PreviewPie.Stroke = Brushes.Black;
                    PreviewPie.Visibility = Visibility.Visible;
                    PreviewArc.Visibility = Visibility.Collapsed;
                }
                else
                {
                    PreviewPie.StrokeDashArray = new DoubleCollection(new double[] { 4, 4 });
                    PreviewPie.Stroke = Brushes.Gray;
                    PreviewPie.Visibility = Visibility.Visible;
                    PreviewArc.Visibility = Visibility.Visible;
                }
                PreviewArc.InvalidateVisual();
                PreviewPie.InvalidateVisual();
            }
        }

    }
}
