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
   /// The code here is not functional yet
   /// </summary>
   
   
    class RectangleTool : OverlayAdderTool
    {
        // point where the rectangle originates, in screen coordinates
        Point origin;
        OverlayShape originRef = null;  // the reference to the coordinate at origin... if there is one.

        /// <summary>
        /// If this flag is set, the first coordinate is bottom left, the second is top right.
        /// This is used for drawing the grid (subclass GridTool)
        /// </summary>
        protected bool ForcePointsBLTR = false;

        // the rectangle to be shown on drawing
        protected Shape PreviewRect = new Rectangle();
        // this is overwritten in GridTool
        protected string codeToInsert = " rectangle ";

        public RectangleTool()
        {
            PreviewRect.Visibility = Visibility.Collapsed;
            PreviewRect.Stroke = Brushes.Black;

        }

        public override void OnActivate()
        {
            base.OnActivate();
            overlay.canvas.Cursor = Cursors.Cross;
        }
        public override void OnDeactivate()
        {
            base.OnDeactivate();
            PreviewRect.Visibility = Visibility.Collapsed;
        }

        public override void OnLeftMouseButtonDown(OverlayShape item, Point p, MouseButtonEventArgs e)
        {
            // initiate drawing process
            Point mousep = overlay.Rasterizer.RasterizePixel(p);
            origin = new Point(mousep.X, overlay.Height - mousep.Y);

            if (IsReferenceable(item))
                originRef = item;
            else
                originRef = null;

            Canvas.SetLeft(PreviewRect, origin.X);
            Canvas.SetTop(PreviewRect, origin.Y);
            PreviewRect.Width = PreviewRect.Height = 0;

            // adjust rotation in case we are in a rotated frame
            double angle = -Helper.RotationFromMatrix(overlay.Rasterizer.CoordinateTransform) * 180 / Math.PI;
            PreviewRect.RenderTransform = new RotateTransform(angle);

            if (!overlay.canvas.Children.Contains(PreviewRect))
                overlay.canvas.Children.Add(PreviewRect);
            PreviewRect.Visibility = Visibility.Visible;

            if (!overlay.canvas.IsMouseCaptured)
                overlay.canvas.CaptureMouse();
        }
        public override void OnLeftMouseButtonUp(MouseButtonEventArgs e, Point p)
        {
            // add the rectangle
            if (PreviewRect.Visibility == Visibility.Visible)
            {
                if (!EnsureParseTreeExists())
                    return;

                Point firstpoint = overlay.ScreenToTikz(origin, true);
                Point secondpoint = overlay.Rasterizer.RasterizePixelToTikz(p);

                double angle = -Helper.RotationFromMatrix(overlay.Rasterizer.CoordinateTransform);
                Matrix R = Matrix.Identity;
                R.Rotate(angle * 180 / Math.PI);
                Matrix RI = R;
                RI.Invert();  // RI = R inverse 

                Point firstpointR = R.Transform(firstpoint), secondpointR = R.Transform(secondpoint);

                if (ForcePointsBLTR)
                {
                    // ensure first pt is bottom left, second top right
                    Rect r = new Rect(firstpointR, secondpointR);
                    firstpointR = r.TopLeft; // note that we use upside down coordinates, so the c# notations are different
                    secondpointR = r.BottomRight;
                    firstpoint = RI.Transform(firstpointR);
                    secondpoint = RI.Transform(secondpointR);
                }

                if (Keyboard.Modifiers.HasFlag(ModifierKeys.Control))
                {
                    // both sides the same
                    double sidelength = Math.Max(Math.Abs(firstpointR.X-secondpointR.X), Math.Abs(firstpointR.Y-secondpointR.Y));
                    secondpointR = new Point(
                        firstpointR.X + Math.Sign(secondpointR.X-firstpointR.X) * sidelength,
                        firstpointR.Y + Math.Sign(secondpointR.Y-firstpointR.Y) * sidelength );
                    secondpoint = RI.Transform(secondpointR);
                }

                overlay.BeginUpdate();

                if (AddNewCurAddTo())
                {
                    Parser.Tikz_Coord tc1 = new Parser.Tikz_Coord();
                    tc1.type = overlay.UsePolarCoordinates? Parser.Tikz_CoordType.Polar : Parser.Tikz_CoordType.Cartesian;
                    Parser.Tikz_Coord tc2 = new Parser.Tikz_Coord();
                    tc2.type = overlay.UsePolarCoordinates ? Parser.Tikz_CoordType.Polar : Parser.Tikz_CoordType.Cartesian;

                    curAddTo.AddChild(new Parser.Tikz_Something(" "));
                    curAddTo.AddChild(tc1);
                    curAddTo.AddChild(new Parser.Tikz_Something(codeToInsert));
                    curAddTo.AddChild(tc2);

                    if (originRef == null)
                    {
                        tc1.SetAbsPos(firstpoint);
                    }
                    else
                    {
                        Tikz_Node tn = MakeReferenceableNode((originRef as OverlayNode).tikzitem);
                        tc1.type = Tikz_CoordType.Named;
                        tc1.nameref = tn.name;
                    }

                    object hit = overlay.canvas.InputHitTest(e.GetPosition(overlay.canvas));
                    if ((hit is OverlayNode) && IsReferenceable(hit as OverlayNode))
                    {
                        Tikz_Node tn = MakeReferenceableNode((hit as OverlayNode).tikzitem);
                        tc2.type = Tikz_CoordType.Named;
                        tc2.nameref = tn.name;
                    } else
                    {            
                        tc2.SetAbsPos(secondpoint);
                    }
                    
                    overlay.AddToDisplayTree(tc1);
                    overlay.AddToDisplayTree(tc2);

                    curAddTo.UpdateText();
                }

                overlay.EndUpdate();

                PreviewRect.Visibility = Visibility.Collapsed;
            }
        }



        public override void OnMouseMove(Point p, MouseEventArgs e)
        {
            base.OnMouseMove(p, e);

            //Point mousep = e.GetPosition(overlay.canvas);
            Point mousep = overlay.Rasterizer.RasterizePixel(p);
            mousep = new Point(mousep.X, overlay.canvas.ActualHeight - mousep.Y);
            if (PreviewRect.Visibility == Visibility.Visible)
            {
                // compute rotated diagonal
                double angle = -Helper.RotationFromMatrix(overlay.Rasterizer.CoordinateTransform) ;
                Matrix R = Matrix.Identity;
                R.Rotate(-angle * 180 / Math.PI);
                Vector newdiag = R.Transform(mousep-origin);

                // update the size and position of the preview rect
                if (Keyboard.Modifiers.HasFlag(ModifierKeys.Control))
                {
                    // both sides the same
                    PreviewRect.Width = PreviewRect.Height = Math.Max(Math.Abs(newdiag.X), Math.Abs(newdiag.Y));
                    newdiag = new Vector(Math.Sign(newdiag.X) * PreviewRect.Width, Math.Sign(newdiag.Y) * PreviewRect.Height);
                }
                else
                {
                    PreviewRect.Width = Math.Abs(newdiag.X);
                    PreviewRect.Height = Math.Abs(newdiag.Y);
                }
               
                R.Invert();
                Point topleft = origin + R.Transform( new Vector(Math.Min(0, newdiag.X), Math.Min(0, newdiag.Y)) );

                //double x = (newdiag.X<0 ?  mousep.X : origin.X),
                //       y = (newdiag.Y<0 ?  mousep.Y : origin.Y);
                //SelectionRect.RenderTransform = new TranslateTransform(x, y);
                Canvas.SetLeft(PreviewRect, topleft.X);
                Canvas.SetTop(PreviewRect, topleft.Y);

            }
        }

        public override void KeyDown(KeyEventArgs e)
        {
            base.KeyDown(e);
            // refresh preview rect size in case CTRL was pressed
            if (PreviewRect.Visibility == Visibility.Visible)
            {
                Point p = new Point(Mouse.GetPosition(overlay.canvas).X, overlay.Height - Mouse.GetPosition(overlay.canvas).Y);
                OnMouseMove(p, null);
            }
        }
        public override void KeyUp(KeyEventArgs e)
        {
            base.KeyUp(e);
            // refresh preview rect size in case CTRL was pressed
            if (PreviewRect.Visibility == Visibility.Visible)
            {
                Point p = new Point(Mouse.GetPosition(overlay.canvas).X, overlay.Height - Mouse.GetPosition(overlay.canvas).Y);
                OnMouseMove(p, null);
            }
        }

    }

    class EllipseTool : OverlayAdderTool
    {
        // point where the rectangle originates, in screen coordinates
        Point origin;
        OverlayShape originRef = null;  // the reference to the coordinate at origin... if there is one.

        // the rectangle to be shown on drawing
        Ellipse PreviewEllipse = new Ellipse();

        public EllipseTool()
        {
            PreviewEllipse.Visibility = Visibility.Collapsed;
            PreviewEllipse.Stroke = Brushes.Black;

        }

        public override void OnActivate()
        {
            base.OnActivate();
            overlay.canvas.Cursor = Cursors.Cross;
        }
        public override void OnDeactivate()
        {
            base.OnDeactivate();
            PreviewEllipse.Visibility = Visibility.Collapsed;
        }

        public override void OnLeftMouseButtonDown(OverlayShape item, Point p, MouseButtonEventArgs e)
        {
            // initiate drawing process
            Point mousep = overlay.Rasterizer.RasterizePixel(p);
            origin = new Point(mousep.X, overlay.Height - mousep.Y);

            if (IsReferenceable(item))
                originRef = item;
            else
                originRef = null;

            Canvas.SetLeft(PreviewEllipse, origin.X);
            Canvas.SetTop(PreviewEllipse, origin.Y);
            PreviewEllipse.Width = PreviewEllipse.Height = 0;

            double angle = -Helper.RotationFromMatrix(overlay.Rasterizer.CoordinateTransform) * 180 / Math.PI;
            PreviewEllipse.RenderTransform = new RotateTransform(angle);

            if (!overlay.canvas.Children.Contains(PreviewEllipse))
                overlay.canvas.Children.Add(PreviewEllipse);
            PreviewEllipse.Visibility = Visibility.Visible;

            if (!overlay.canvas.IsMouseCaptured)
                overlay.canvas.CaptureMouse();
        }
        public override void OnLeftMouseButtonUp(MouseButtonEventArgs e, Point p)
        {
            // add the rectangle
            if (PreviewEllipse.Visibility == Visibility.Visible)
            {
                if (!EnsureParseTreeExists())
                    return;

                Point center = overlay.ScreenToTikz(origin, true); 
                Point secondpoint = overlay.Rasterizer.RasterizePixelToTikz(p); // in axis aligned (untranformed) tikz coordinates

                // compute rotated diagonal
                double angle = -Helper.RotationFromMatrix(overlay.Rasterizer.CoordinateTransform);
                Matrix R = Matrix.Identity;
                R.Rotate(angle * 180 / Math.PI);
                Vector newdiag = R.Transform(secondpoint - center);

                double width = Math.Abs(newdiag.X),   // actually half the width/height!
                       height = Math.Abs(newdiag.Y);

                if (Keyboard.Modifiers.HasFlag(ModifierKeys.Control))
                    width = height = Math.Max(width, height);
                
                overlay.BeginUpdate();

                if (AddNewCurAddTo())
                {
                    Parser.Tikz_Coord tc1 = new Parser.Tikz_Coord();
                    tc1.type = overlay.UsePolarCoordinates ? Parser.Tikz_CoordType.Polar : Parser.Tikz_CoordType.Cartesian;

                    curAddTo.AddChild(new Parser.Tikz_Something(" "));
                    curAddTo.AddChild(tc1);
                    // since there might be a coordinate tranform, the width/height have to be transformed
                    // (note: rotates are not very well supported here) 
                    TikzMatrix M;
                    if (curAddTo.GetCurrentTransformAt(tc1, out M))
                    {
                        R.Invert();
                        Point size_trans = M.Inverse().Transform(R.Transform(new Point(width, height)), true);
                        width = size_trans.X;
                        height = size_trans.Y;
                    }
                    else
                    {
                        MainWindow.AddStatusLine("Warning: Couldn't compute tranform at insertion position. Coordinates might be wrong.", true);
                    }

                    width = Math.Round(width, (int)Properties.Settings.Default.RoundToDecimals);
                    height = Math.Round(height, (int)Properties.Settings.Default.RoundToDecimals);

                    if (Keyboard.Modifiers.HasFlag(ModifierKeys.Control) && width == height)
                        curAddTo.AddChild(new Parser.Tikz_Something(" circle (" + width + ")" ));
                    else
                        curAddTo.AddChild(new Parser.Tikz_Something(" ellipse (" + width + " and " + height + ")"));

                    if (originRef == null)
                    {
                        tc1.SetAbsPos(center);
                    }
                    else
                    {
                        Tikz_Node tn = MakeReferenceableNode((originRef as OverlayNode).tikzitem);
                        tc1.type = Tikz_CoordType.Named;
                        tc1.nameref = tn.name;
                    }
                    
                    overlay.AddToDisplayTree(tc1);

                    curAddTo.UpdateText();
                }

                overlay.EndUpdate();

                PreviewEllipse.Visibility = Visibility.Collapsed;
            }
        }



        public override void OnMouseMove(Point p, MouseEventArgs e)
        {
            base.OnMouseMove(p, e);

            //Point mousep = e.GetPosition(overlay.canvas);
            Point mousep = overlay.Rasterizer.RasterizePixel(p);
            mousep = new Point(mousep.X, overlay.canvas.ActualHeight - mousep.Y);
            if (PreviewEllipse.Visibility == Visibility.Visible)
            {
                // compute rotated diagonal
                double angle = -Helper.RotationFromMatrix(overlay.Rasterizer.CoordinateTransform);
                Matrix R = Matrix.Identity;
                R.Rotate(-angle * 180 / Math.PI);
                Vector newdiag = R.Transform(mousep - origin);

                double width = Math.Abs(newdiag.X),   // actually half the width/height!
                       height = Math.Abs(newdiag.Y);
                if (Keyboard.Modifiers.HasFlag(ModifierKeys.Control))
                    width = height = Math.Max(width, height);
                PreviewEllipse.Width = 2 * width;
                PreviewEllipse.Height = 2 * height;

                R.Invert();
                Point topleft = origin + R.Transform(new Vector(-width, -height));

                Canvas.SetLeft(PreviewEllipse, topleft.X);
                Canvas.SetTop(PreviewEllipse, topleft.Y);

            }
        }

        public override void KeyDown(KeyEventArgs e)
        {
            base.KeyDown(e);
            // refresh preview rect size in case CTRL was pressed
            if (PreviewEllipse.Visibility == Visibility.Visible)
            {
                Point p = new Point(Mouse.GetPosition(overlay.canvas).X, overlay.Height - Mouse.GetPosition(overlay.canvas).Y);
                OnMouseMove(p, null);
            }
        }
        public override void KeyUp(KeyEventArgs e)
        {
            base.KeyUp(e);
            // refresh preview rect size in case CTRL was pressed
            if (PreviewEllipse.Visibility == Visibility.Visible)
            {
                Point p = new Point(Mouse.GetPosition(overlay.canvas).X, overlay.Height - Mouse.GetPosition(overlay.canvas).Y);
                OnMouseMove(p, null);
            }
        }
    }

    class GridTool : RectangleTool
    {
        class PreviewGrid : Shape
        {
            public PreviewGrid()
            {
                StrokeThickness = 1;
                StrokeDashArray = new DoubleCollection(new double[] { 4, 4 } );
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
                    geometry.Freeze();

                    return geometry;
                }
            }

            /// <summary>
            /// Draw a rectangle
            /// </summary>
            /// <param name="context"></param>
            private void InternalDrawNodeGeometry(StreamGeometryContext context)
            {
                context.BeginFigure(new Point(0, 0), true, true);
                context.LineTo(new Point(Width, 0), true, false);
                context.LineTo(new Point(Width, Height), true, false);
                context.LineTo(new Point(0, Height), true, false);

                context.BeginFigure(new Point(Width/2, 0), true, true);
                context.LineTo(new Point(Width / 2, Height), true, false);

                context.BeginFigure(new Point(0, Height/2), true, true);
                context.LineTo(new Point(Width, Height/2), true, false);
            }
        }

        protected override bool AddNewCurAddTo()
        {
            bool ret = base.AddNewCurAddTo();

            if (ret)
            {
                // add options
                Tikz_Options topts = new Tikz_Options();
                topts.starttag = "[";
                topts.endtag = "]";
                topts.AddOption("help lines");
                topts.AddOption("step", "1cm");

                curAddTo.options = topts;
                curAddTo.AddChild(topts);
            }
            return ret;
        }

        public GridTool()
        {
            codeToInsert = " grid ";
            PreviewRect = new PreviewGrid();
            PreviewRect.Visibility = Visibility.Collapsed;
            PreviewRect.Stroke = Brushes.Black;
            ForcePointsBLTR = true;
        }
    }
}
