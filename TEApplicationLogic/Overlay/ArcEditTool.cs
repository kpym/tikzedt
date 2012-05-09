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
using TikzEdt.Parser;
using TikzEdt.Overlay;

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
        IFanShape PreviewArc;
        /// <summary>
        /// This list holds the nodes along the currently edited arc.
        /// </summary>
        List<Tikz_XYItem> nodesOnArc = new List<Tikz_XYItem>();
        int curDraggedInd;      // the index of the currently dragged item in nodesOnArc

        // all these points are in bottom left centered coordinates (as in LaTeX)
        OverlayShapeVM curDragged;
        Point DragOrigin; // relative to the currently dragged object
        Point DragOriginC; // Mouse position on Canvas when started dragging
        Point DragOriginO; // bottom left of dragged object
        bool movedenough = false;   // is set to true when mouse moved more than xx pixels. This is to prevent accidental dragging

        // in absolute tikz coordinates
        Point center_tikz;

        public ArcEditTool(IOverlayInterface overlay)
            : base(overlay)
        {
            PreviewArc = overlay.ShapeFactory.GetPreviewFan();
        }

        public void SetCursorDefault()
        {
            ////overlay.canvas.Cursor = Cursors.Arrow;
            overlay.SetCursor(System.Windows.Forms.Cursors.Arrow);
        }
        public void SetCursorNo()
        {
            ////overlay.canvas.Cursor = Cursors.No;
            overlay.SetCursor(System.Windows.Forms.Cursors.No);
        }
        public override void OnActivate()
        {
            SetCursorDefault();
        }
        public override void OnDeactivate()
        {
            PreviewArc.Visible = false;
        }


        public override void OnLeftMouseButtonDown(OverlayShapeVM item, Point p, TEMouseArgs e)
        {

            if (item != null)
            {
                // initiate a drag/drop operation
                curDragged = (OverlayShapeVM)item;
                DragOrigin = (new Point(item.View.GetLeft(), item.View.GetBottom()))-(Vector)p ;
                ////DragOrigin = e.GetPosition(item);
                ////DragOrigin = new Point(DragOrigin.X, (item as OverlayShape).Height - DragOrigin.Y);
                DragOriginC = p;
                DragOriginO = new Point(curDragged.View.GetLeft(), curDragged.View.GetBottom());
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
                //if (curDragged.item is Tikz_Arc)
                //{
                    FillNodesOnArc();
                    //check whether starting moving arc was successful
                    if (PreviewArc.Spokes == null)
                    {
                        SetCursorNo();
                        curDragged = null;
                        return;
                    }
                    AdjustPreviewPos(p);
                    PreviewArc.Visible = true;
                //}

                // capture mouse. this is important if the user drags sth. outside canvas1's bounds
                if (curDragged != null) 
                    overlay.MouseCaptured = true;
            }
            


        }


        public override void OnMouseMove(Point p, TEMouseArgs e)
        {
            Point mousep = overlay.CursorPosition;

            // start a drag operation only after the mouse moved at least xx pixels to avoid accidental moving
            if ((DragOriginC - p).Length > 5)
                movedenough = true;
            // for a dragged scope, the relative movement gets rasterized
            // for a dragged node, the center of the node gets rasterized
            if (curDragged != null && e.LeftButtonPressed && movedenough)
            {
                if (curDragged is OverlayScope)
                {
                }
                else if (curDragged is OverlayNode)
                {
                    // use width instead actual width
                    Point center_pixel = new Point(p.X - DragOrigin.X ,
                                                   p.Y - DragOrigin.Y );
                    // the center pixel of the node should go here
                    center_pixel = overlay.Rasterizer.RasterizePixel(center_pixel);

                    // shift yet to be done
                    Point relshift_tobedone = new Point(
                         center_pixel.X - curDragged.View.GetLeft(),
                         center_pixel.Y - curDragged.View.GetBottom() 
                        );
                    //ShiftSelItemsOnScreen(relshift_tobedone);

                    curDragged.View.SetPosition(center_pixel.X, center_pixel.Y);

                    AdjustPreviewPos(center_pixel);
                    
                }
            }
        }

        public override void OnLeftMouseButtonUp(Point p, TEMouseArgs e)
        {
            if (PreviewArc.Spokes == null)
            {
                SetCursorDefault();
                return;
            }

            PreviewArc.Visible = false;
            // adjust position of dragged item (in parsetree)
            if (curDragged != null && movedenough && curDragged.item is Tikz_XYItem)
            {                

                overlay.BeginUpdate();
                // determine the relative shift
                Vector relshift = new Vector(curDragged.View.GetLeft() - DragOriginO.X, curDragged.View.GetBottom() - DragOriginO.Y);
                Vector relshift_tikz = relshift / overlay.Resolution;

                // compute new radius 
                Point pold;
                (curDragged.item as Tikz_XYItem).GetAbsPos(out pold);
                Point pnew = pold + relshift_tikz;
                double Rnew = (pnew - center_tikz).Length;

                // adjust all position accordingly...                
                for (int i=0;i<nodesOnArc.Count;i++)
                {
                    Point newp = center_tikz + Rnew * (new Vector(Math.Cos(PreviewArc.Spokes[i]), Math.Sin(PreviewArc.Spokes[i])));

                    if (i == 0)
                    {
                        nodesOnArc[i].SetAbsPos(newp);
                    }
                    else
                    {
                        //if (nodesOnArc[i] == curDragged.item)
                        //(nodesOnArc[i] as Tikz_Arc).SetAbsPosRandPhi2(Rnew, PreviewArc.Spokes[i]);
                        (nodesOnArc[i] as Tikz_Arc).SetFromPoints(center_tikz, newp, PreviewArc.Spokes[i-1], PreviewArc.Spokes[i]);
                        //else
                        //    (nodesOnArc[i] as Tikz_Arc).SetAbsPosOnlyR(newp);
                        
                    }                        

                    nodesOnArc[i].UpdateText();
                   
                }

                

                // set first angle of arc segment directly after curDragged
                //if (curDraggedInd + 1 < nodesOnArc.Count)
                //{
                //    (nodesOnArc[curDraggedInd + 1] as Tikz_Arc).SetAbsPosRandPhi1(pnew);
                //}

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
                foreach (OverlayShapeVM o in overlay.TopLevelItems)
                    o.AdjustPosition(overlay.Resolution);

                curDragged = null;
                PreviewArc.Spokes = null;

                overlay.EndUpdate();
            }
            else if (curDragged != null && curDragged.item is Tikz_XYItem)
            { //if not movedenough, reset all "moving variables" anyways
                curDragged = null;
                PreviewArc.Spokes = null;
            }
        }


        public override void KeyDown(TEKeyArgs e)
        {
            base.KeyDown(e);
           // if (PreviewArc.Visibility == Visibility.Visible)
           //     AdjustPreviewPos();
        }
        public override void KeyUp(TEKeyArgs e)
        {
            base.KeyUp(e);

           // if (PreviewArc.Visibility == Visibility.Visible)
           //     AdjustPreviewPos();
        }

        bool FillNodesOnArc()
        {
            TikzContainerParseItem pa = curDragged.item.parent;
            if (!(curDragged.item is Tikz_XYItem))
                return false;
            Tikz_XYItem cur = curDragged.item as Tikz_XYItem;
                       
            nodesOnArc.Clear();
            nodesOnArc.Add(cur);
            // find all arcs to the right
            for (int i = pa.Children.IndexOf(cur) + 1; i < pa.Children.Count; i++)
            {
                if (pa.Children[i] is Tikz_Arc)
                    nodesOnArc.Add(pa.Children[i] as Tikz_Arc);
                else if (pa.Children[i].ChangesCurPoint())
                    break;
            }

            // find all arcs to left, including startpoint
            if (cur is Tikz_Arc)
            {
                for (int i = pa.Children.IndexOf(cur) - 1; i >=0; i--)
                {
                    if (pa.Children[i] is Tikz_Arc)
                        nodesOnArc.Insert(0,pa.Children[i] as Tikz_Arc);
                    else if (pa.Children[i].ChangesCurPoint())
                    {
                        if (pa.Children[i] is Tikz_XYItem)
                            nodesOnArc.Insert(0, pa.Children[i] as Tikz_XYItem);
                        break;
                    }
                }
            }

            // todo: no startpoint present...
            if (nodesOnArc.First() is Tikz_Arc)
            {

            }

            // compute radius and center
            // in absolute tikz coordinates
            Point center, p;
            double R;
            Tikz_Arc ta;
            if (cur is Tikz_Arc)
                ta = cur as Tikz_Arc;
            else if (nodesOnArc.Count > 1 && nodesOnArc[1] is Tikz_Arc)
                ta = nodesOnArc[1] as Tikz_Arc;
            else return false;

            if (!ta.GetArcCenterAbs(out center) || !ta.GetAbsPos(out p))
                throw new Exception("ArcEditTool: Invalid coordinate discovered.");

            R = (p - center).Length;
            
            // throw out all items with non-fitting parameters
            for (int i = nodesOnArc.Count - 1; i >= 0; i--)
            {
                if (nodesOnArc[i] is Tikz_Arc)
                {
                    Point cc, pp;
                    double RR;
                    if (!(nodesOnArc[i] as Tikz_Arc).GetArcCenterAbs(out cc) || !nodesOnArc[i].GetAbsPos(out pp))
                        throw new Exception("ArcEditTool: Invalid coordinate discovered.");
                    RR = (cc - pp).Length;
                    if ((cc - center).Length > 1e-3 || Math.Abs(RR - R) > 1e-3)
                        nodesOnArc.RemoveAt(i);
                }
                else  // other Tikz_XYItem, namely startpoint
                {
                    Point pp;
                    if (!nodesOnArc[i].GetAbsPos(out pp))
                        throw new Exception("ArcEditTool: Invalid coordinate discovered.");
                    // check if pooint lies on circle
                    if (Math.Abs(R - (pp-center).Length) > 1e-3)
                        nodesOnArc.RemoveAt(i);
                }
            }
            curDraggedInd = nodesOnArc.IndexOf(cur);
            PreviewArc.Center = overlay.TikzToScreen(center, true);
            center_tikz = center;

            // Fill the PreviewArcs Spokes array            
            List<double> spokes = new List<double>();
            for (int i = 0; i < nodesOnArc.Count; i++)
            {
                if (nodesOnArc[i] is Tikz_Arc)
                {
                    Tikz_Arc tia = nodesOnArc[i] as Tikz_Arc;
                    double a1 = tia.phi1.GetInCM() * Math.PI / 180, a2 = tia.phi2.GetInCM() * Math.PI / 180;

                    //if (!(spokes.Count > 0 && spokes.Last() == a1))
                    //    spokes.Add(a1);
                    spokes.Add(a2);

                    //Point pp;
                    //if (!nodesOnArc[i].GetAbsPos(out pp))
                    //    throw new Exception("ArcEditTool: Invalid coordinate discovered.");
                    //Vector v = pp - center;

                }
                else
                {
                    // should go here at most for the first item in list
                    double a1 = (nodesOnArc[1] as Tikz_Arc).phi1.GetInCM() * Math.PI / 180;
                    spokes.Add(a1);
                }
            }
            PreviewArc.Spokes = spokes;
            
            return true;
        }

        /// <summary>
        /// Adjust small/large arc of the currently dragged node to state of Shift key
        /// </summary>
        public void AdjustPreviewPos()
        {
            //double d = phi2 - phi1;
            //if (Keyboard.Modifiers.HasFlag(ModifierKeys.Shift) != (Math.Abs(d) > Math.PI))
            //    d -= 2 * Math.PI * Math.Sign(d);
            //phi2 = phi1 + d;

            // ensure the currently edited angle is "sensible", i.e., it does not overlap with other things along the arc            
            /*if (nodesOnArc.Count == 2)
            {
                // Case 1: We are editing a single arc segment,... switch larger/smaller angle by shift
                double editedPhi = PreviewArc.Spokes[curDraggedInd], otherPhi = PreviewArc.Spokes[(curDraggedInd + 1) % 2];
                if (Keyboard.Modifiers.HasFlag(ModifierKeys.Shift) != (Math.Abs(editedPhi - otherPhi) > Math.PI))
                    editedPhi -= 2 * Math.PI * Math.Sign(editedPhi - otherPhi);

                PreviewArc.Spokes[curDraggedInd] = editedPhi;
            }
            else
            {
                // Case 2: We are editing multiple arc segments -> try to put arc st. it does not intersect the other segments
                if (curDraggedInd == 0)
                {
                    double mid = -(PreviewArc.Spokes[1] - PreviewArc.Spokes[nodesOnArc.Count]);
                    PreviewArc.Spokes[curDraggedInd] = ClosestPt(PreviewArc.Spokes[curDraggedInd], mid);
                }
                else if (curDraggedInd + 1 == nodesOnArc.Count)
                {
                    double mid = PreviewArc.Spokes[curDraggedInd + 1] - PreviewArc.Spokes[curDraggedInd - 1];
                    PreviewArc.Spokes[curDraggedInd] = ClosestPt(PreviewArc.Spokes[curDraggedInd], mid);
                }
                else
                {
                    double mid = PreviewArc.Spokes[curDraggedInd + 1] - PreviewArc.Spokes[curDraggedInd - 1];
                    PreviewArc.Spokes[curDraggedInd] = ClosestPt(PreviewArc.Spokes[curDraggedInd], mid);
                }
            }*/


            PreviewArc.Refresh();
        } 
        /// <summary>
        /// Adjusts the radius of the preview to arc to the current mouse position.        
        /// </summary>
        /// <param name="p">The rasterized position of the mouse cursor, in upside down coordinates</param>
        public void AdjustPreviewPos(Point p)
        {
            Point pp = new Point(p.X, overlay.Height - p.Y);
            Vector v = (pp - PreviewArc.Center);
            
            PreviewArc.R = v.Length;
            double olda = PreviewArc.Spokes[curDraggedInd], a = -Math.Atan2(v.Y, v.X);
            PreviewArc.Spokes[curDraggedInd] = Helper.ClosestPt(a, olda);
            AdjustPreviewPos();
        }


        double ClosestPtGt(double angle, double closeto)
        {
            double diff = angle - closeto;
            return angle - Math.Floor(diff / (2 * Math.PI)) * 2 * Math.PI;
        }
        double ClosestPtSm(double angle, double closeto)
        {
            double diff = angle - closeto;
            return angle - Math.Floor(diff / (2 * Math.PI)) * 2 * Math.PI;
        }
 

    }
}
