using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using TikzEdt.Parser;
using TikzEdt.Overlay;

namespace TikzEdt
{

    class ArcTool : OverlayAdderTool
    {
        int pointcount = 0;
        // points are in Tikz coordinates
        Point center, p1;
        IArcShape PreviewArc, PreviewPie;

        public ArcTool(IOverlayInterface overlay) : base(overlay)
        {
            PreviewArc = overlay.ShapeFactory.GetPreviewArc();
            PreviewPie = overlay.ShapeFactory.GetPreviewPie();
        }
        public override void OnDeactivate()
        {
            base.OnDeactivate();
            PreviewPie.Visible = PreviewArc.Visible = false;
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
        public override void OnMouseMove(Point p, TEMouseArgs e)
        {
            base.OnMouseMove(p, e);
            p = overlay.Rasterizer.RasterizePixel(p);

            if (pointcount > 0)
                UpdatePreviewDisplay(p);

        }
        public override void KeyDown(TEKeyArgs e)
        {
            base.KeyDown(e);
            UpdatePreviewDisplay();
        }
        public override void KeyUp(TEKeyArgs e)
        {
            base.KeyUp(e);
            UpdatePreviewDisplay();
        }

        public override void OnLeftMouseButtonDown(OverlayShapeVM item, Point p, TEMouseArgs e) 
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

                ////if (!overlay.canvas.Children.Contains(PreviewArc))
                ////    overlay.canvas.Children.Add(PreviewArc);
                ////if (!overlay.canvas.Children.Contains(PreviewPie))
                ////    overlay.canvas.Children.Add(PreviewPie);
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
          //          overlay.AddToDisplayTree(curAddTo);

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

        bool IsPie { get { return overlay.KeyboardModifiers.HasFlag(TEModifierKeys.Control); } }
        bool IsLargeArc { get { return overlay.KeyboardModifiers.HasFlag(TEModifierKeys.Shift); } }

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
            //GlobalUI.UI.AddStatusLine(this, "UPD");
            if (pointcount == 0)
            {
                PreviewArc.Visible = PreviewPie.Visible = false;
            }
            else 
            {
                PreviewArc.IsLargeArc = PreviewPie.IsLargeArc = IsLargeArc;
                if (IsPie)
                {
                    PreviewPie.IsDashed = false;
                    PreviewPie.Visible = true;
                    PreviewArc.Visible = false;
                }
                else
                {
                    PreviewPie.IsDashed = true;
                    PreviewPie.Visible = true;
                    PreviewArc.Visible = true;  
                }
                PreviewArc.Refresh();
                PreviewPie.Refresh();
            }
        }

    }
}
