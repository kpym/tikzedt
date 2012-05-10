using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using TikzEdt.Parser;
using TikzEdt.Overlay;

namespace TikzEdt
{
   /// <summary>
   /// The code here is not functional yet
   /// </summary>
   
   
    class RectangleTool : OverlayAdderTool
    {
        // point where the rectangle originates, in screen coordinates
        Point origin;
        OverlayShapeVM originRef = null;  // the reference to the coordinate at origin... if there is one.

        /// <summary>
        /// If this flag is set, the first coordinate is bottom left, the second is top right.
        /// This is used for drawing the grid (subclass GridTool)
        /// </summary>
        protected bool ForcePointsBLTR = false;

        // the rectangle to be shown on drawing
        protected IRectangleShape PreviewRect;
        // this is overwritten in GridTool
        protected string codeToInsert = " rectangle ";

        /// <summary>
        /// Creates the shape used for preview. Override in subclasses to display different shapes (ellipse, grid).
        /// </summary>
        /// <returns>An interface to the created shape.</returns>
        protected virtual IRectangleShape CreatePreviewShape()
        {
            return overlay.ShapeFactory.GetPreviewRectangle();
        }

        public RectangleTool(IOverlayInterface overlay) : base(overlay)
        {
            PreviewRect = CreatePreviewShape();
        }

        public override void OnActivate()
        {
            base.OnActivate();
            overlay.SetCursor(System.Windows.Forms.Cursors.Cross);
        }
        public override void OnDeactivate()
        {
            base.OnDeactivate();
            PreviewRect.Visible = false;
        }

        public override void OnLeftMouseButtonDown(OverlayShapeVM item, Point p, TEMouseArgs e)
        {
            // initiate drawing process
            Point mousep = overlay.Rasterizer.RasterizePixel(p);
            origin = new Point(mousep.X, overlay.Height - mousep.Y);

            if (IsReferenceable(item))
                originRef = item;
            else
                originRef = null;

            PreviewRect.SetPosition(origin.X, origin.Y, 0,0);

            // adjust rotation in case we are in a rotated frame
            double angle = -Helper.RotationFromMatrix(overlay.Rasterizer.View.CoordinateTransform) * 180 / Math.PI;
            PreviewRect.Rotation = angle;

            ////if (!overlay.canvas.Children.Contains(PreviewRect))
            ////    overlay.canvas.Children.Add(PreviewRect);
            /////PreviewRect.Visibility = Visibility.Visible;
            PreviewRect.Visible = true;

            overlay.MouseCaptured = true;
        }
        public override void OnLeftMouseButtonUp(Point p, TEMouseArgs e)
        {
            // add the rectangle
            if (PreviewRect.Visible)
            {
                if (!EnsureParseTreeExists())
                    return;

                Point firstpoint = overlay.ScreenToTikz(origin, true);
                Point secondpoint = overlay.Rasterizer.RasterizePixelToTikz(p);

                double angle = -Helper.RotationFromMatrix(overlay.Rasterizer.View.CoordinateTransform);
                TikzMatrix R = TikzMatrix.RotationMatrix(angle);
                TikzMatrix RI = R.Inverse();

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

                if (overlay.KeyboardModifiers.HasFlag(TEModifierKeys.Control))
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

                    OverlayShapeVM hit = overlay.ObjectAtCursor;
                    if ((hit is OverlayNode) && IsReferenceable(hit as OverlayNode))
                    {
                        Tikz_Node tn = MakeReferenceableNode((hit as OverlayNode).tikzitem);
                        tc2.type = Tikz_CoordType.Named;
                        tc2.nameref = tn.name;
                    } else
                    {            
                        tc2.SetAbsPos(secondpoint);
                    }
                    
         //           overlay.AddToDisplayTree(tc1);
         //           overlay.AddToDisplayTree(tc2);

                    curAddTo.UpdateText();
                }

                overlay.EndUpdate();

                PreviewRect.Visible = false;
            }
        }



        public override void OnMouseMove(Point p, TEMouseArgs e)
        {
            base.OnMouseMove(p, e);

            //Point mousep = e.GetPosition(overlay.canvas);
            Point mousep = overlay.Rasterizer.RasterizePixel(p);
            ////mousep = new Point(mousep.X, overlay.canvas.ActualHeight - mousep.Y);
            mousep = new Point(mousep.X, overlay.Height - mousep.Y);
            if (PreviewRect.Visible)
            {
                // compute rotated diagonal
                double angle = -Helper.RotationFromMatrix(overlay.Rasterizer.View.CoordinateTransform);
                TikzMatrix R =TikzMatrix.RotationMatrix(-angle);
                Vector newdiag = R.Transform(mousep-origin);

                // update the size and position of the preview rect
                double width, height;
                if (overlay.KeyboardModifiers.HasFlag(TEModifierKeys.Control))
                {
                    // both sides the same
                    width = height = Math.Max(Math.Abs(newdiag.X), Math.Abs(newdiag.Y));
                    newdiag = new Vector(Math.Sign(newdiag.X) * width, Math.Sign(newdiag.Y) * height);
                }
                else
                {
                    width = Math.Abs(newdiag.X);
                    height = Math.Abs(newdiag.Y);
                }
               
                R = R.Inverse();
                Point topleft = origin + R.Transform( new Vector(Math.Min(0, newdiag.X), Math.Min(0, newdiag.Y)) );

                //double x = (newdiag.X<0 ?  mousep.X : origin.X),
                //       y = (newdiag.Y<0 ?  mousep.Y : origin.Y);
                //SelectionRect.RenderTransform = new TranslateTransform(x, y);
                PreviewRect.SetPosition(topleft.X, topleft.Y, width, height);

            }
        }

        public override void KeyDown(TEKeyArgs e)
        {
            base.KeyDown(e);
            // refresh preview rect size in case CTRL was pressed
            if (PreviewRect.Visible)
            {
                Point p = new Point(overlay.CursorPosition.X, overlay.Height - overlay.CursorPosition.Y);
                OnMouseMove(p, null);
            }
        }
        public override void KeyUp(TEKeyArgs e)
        {
            base.KeyUp(e);
            // refresh preview rect size in case CTRL was pressed
            if (PreviewRect.Visible)
            {
                Point p = new Point(overlay.CursorPosition.X, overlay.Height - overlay.CursorPosition.Y);
                OnMouseMove(p, null);
            }
        }

    }

    class EllipseTool : OverlayAdderTool
    {
        // point where the rectangle originates, in screen coordinates
        Point origin;
        OverlayShapeVM originRef = null;  // the reference to the coordinate at origin... if there is one.

        // the rectangle to be shown on drawing
        IRectangleShape PreviewEllipse;

        public EllipseTool(IOverlayInterface overlay)
            : base(overlay)
        {
            PreviewEllipse = overlay.ShapeFactory.GetPreviewEllipse();
        }

        public override void OnActivate()
        {
            base.OnActivate();
            overlay.SetCursor( System.Windows.Forms.Cursors.Cross );
        }
        public override void OnDeactivate()
        {
            base.OnDeactivate();
            PreviewEllipse.Visible = false;
        }

        public override void OnLeftMouseButtonDown(OverlayShapeVM item, Point p, TEMouseArgs e)
        {
            // initiate drawing process
            Point mousep = overlay.Rasterizer.RasterizePixel(p);
            origin = new Point(mousep.X, overlay.Height - mousep.Y);

            if (IsReferenceable(item))
                originRef = item;
            else
                originRef = null;

            PreviewEllipse.SetPosition(origin.X,origin.Y,0,0);

            double angle = -Helper.RotationFromMatrix(overlay.Rasterizer.View.CoordinateTransform) * 180 / Math.PI;
            PreviewEllipse.Rotation = angle;

            PreviewEllipse.Visible = true;

            overlay.MouseCaptured = true;
        }
        public override void OnLeftMouseButtonUp(Point p, TEMouseArgs e)
        {
            // add the rectangle
            if (PreviewEllipse.Visible)
            {
                if (!EnsureParseTreeExists())
                    return;

                Point center = overlay.ScreenToTikz(origin, true); 
                Point secondpoint = overlay.Rasterizer.RasterizePixelToTikz(p); // in axis aligned (untranformed) tikz coordinates

                // compute rotated diagonal
                double angle = -Helper.RotationFromMatrix(overlay.Rasterizer.View.CoordinateTransform);
                TikzMatrix R = TikzMatrix.RotationMatrix(angle);
                Vector newdiag = R.Transform(secondpoint - center);

                double width = Math.Abs(newdiag.X),   // actually half the width/height!
                       height = Math.Abs(newdiag.Y);

                if (overlay.KeyboardModifiers.HasFlag(TEModifierKeys.Control))
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
                        R = R.Inverse();
                        Point size_trans = M.Inverse().Transform(R.Transform(new Point(width, height)), true);
                        width = size_trans.X;
                        height = size_trans.Y;
                    }
                    else
                    {
                        GlobalUI.UI.AddStatusLine(this, "Warning: Couldn't compute tranform at insertion position. Coordinates might be wrong.", true);
                    }

                    width = Math.Round(width, (int)CompilerSettings.Instance.RoundToDecimals);
                    height = Math.Round(height, (int)CompilerSettings.Instance.RoundToDecimals);

                    if (overlay.KeyboardModifiers.HasFlag(TEModifierKeys.Control) && width == height)
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
                    
          //          overlay.AddToDisplayTree(tc1);

                    curAddTo.UpdateText();
                }

                overlay.EndUpdate();

                PreviewEllipse.Visible = false;
            }
        }



        public override void OnMouseMove(Point p, TEMouseArgs e)
        {
            base.OnMouseMove(p, e);

            //Point mousep = e.GetPosition(overlay.canvas);
            Point mousep = overlay.Rasterizer.RasterizePixel(p);
            ////mousep = new Point(mousep.X, overlay.canvas.ActualHeight - mousep.Y);
            mousep = new Point(mousep.X, overlay.Height - mousep.Y);
            if (PreviewEllipse.Visible)
            {
                // compute rotated diagonal
                double angle = -Helper.RotationFromMatrix(overlay.Rasterizer.View.CoordinateTransform);
                //TikzMatrix R
                TikzMatrix R = TikzMatrix.RotationMatrix(-angle);
                Vector newdiag = R.Transform(mousep - origin);

                double width = Math.Abs(newdiag.X),   // actually half the width/height!
                       height = Math.Abs(newdiag.Y);
                if (overlay.KeyboardModifiers.HasFlag(TEModifierKeys.Control))
                    width = height = Math.Max(width, height);

                R = R.Inverse();
                Point topleft = origin + R.Transform(new Vector(-width, -height));

                PreviewEllipse.SetPosition(topleft.X, topleft.Y, 2 * width, 2 * height);
            }
        }

        public override void KeyDown(TEKeyArgs e)
        {
            base.KeyDown(e);
            // refresh preview rect size in case CTRL was pressed
            if (PreviewEllipse.Visible)
            {
                Point p = new Point(overlay.CursorPosition.X, overlay.Height - overlay.CursorPosition.Y);
                OnMouseMove(p, null);
            }
        }
        public override void KeyUp(TEKeyArgs e)
        {
            base.KeyUp(e);
            // refresh preview rect size in case CTRL was pressed
            if (PreviewEllipse.Visible)
            {
                Point p = new Point(overlay.CursorPosition.X, overlay.Height - overlay.CursorPosition.Y);
                OnMouseMove(p, null);
            }
        }
    }

    class GridTool : RectangleTool
    {
        protected override IRectangleShape CreatePreviewShape()
        {
            return overlay.ShapeFactory.GetPreviewGrid();
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

        public GridTool(IOverlayInterface overlay)
            : base(overlay)
        {
            codeToInsert = " grid ";
            ForcePointsBLTR = true;
        }
    }
}
