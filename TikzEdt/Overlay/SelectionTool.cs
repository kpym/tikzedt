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
using System.Collections.ObjectModel;
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
    /// <summary>
    /// The selection/Move tool can be used to move several objects around.
    /// Multiselect is supported.
    /// 
    /// As a rule, only the coordinate (in code) of the moved item is changed.
    /// That means, e.g., if you move (1,1) in 
    ///     \draw (1,1) -- +(2,2);
    /// then the coordinates (2,2) in the code are not changed, but this means that the 
    /// (2,2)-node in the preview changes position since it is given in relative coordinates.
    /// </summary>
    public class SelectionTool : OverlayTool
    {
        IRectangleShape SelectionRect;

        public SelectionTool(OverlayInterface overlay) : base(overlay)
        {
            SelectionRect = overlay.ShapeFactory.GetSelectionRect();
        }

        HashSet<OverlayShape> SelectedItems = new HashSet<OverlayShape>();
        HashSet<OverlayShape> SelectedItemsBak;

        public IEnumerable<OverlayShape> SelItems
        {
            get { return SelectedItems.AsEnumerable(); }
        }

        Point SelectionRectOrigin;

        // all these points are in bottom left centered coordinates (as in LaTeX)
        OverlayShape curDragged;
        Point DragOrigin; // relative to the currently dragged object
        Point DragOriginC; // Mouse position on Canvas when started dragging
        Point DragOriginO; // bottom left of dragged object
        bool movedenough = false;   // is set to true when mouse moved more than xx pixels. This is to prevent accidental dragging

        public override void OnActivate()
        {
            overlay.canvas.Cursor = Cursors.Arrow;
        }
        public override void OnDeactivate()
        {
            Clear();
        }
        public override void UpdateRaster()
        {
            base.UpdateRaster();
            overlay.SetCorrectRaster(overlay.CurEditing, false);
        }

        /// <summary>
        /// Adds an item to the list of selected items.
        /// </summary>
        /// <param name="o">The item to add.</param>
        /// <param name="Exclusive">If Exclusive is set, all other items are unselected.</param>
        public void AddItem(OverlayShape o, bool Exclusive = false)
        {
            if (Exclusive)
                Clear(o);
            if (!SelectedItems.Contains(o))
            {
                o.SetSelectedColor();
                SelectedItems.Add(o);
            }
        }


        public bool IsItemSelected(OverlayShape o)
        {
            return SelectedItems.Contains(o);
        }

        void RemoveItem(OverlayShape o)
        {
            if (SelectedItems.Contains(o))
            {
                SelectedItems.Remove(o);
                o.SetStdColor();
            }
        }

        /// <summary>
        /// Toggles selection state, returns new selection state.
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool ToggleItem(OverlayShape o)
        {
            if (SelectedItems.Contains(o))
            {
                RemoveItem(o);
                return false;
            }
            else
            {
                AddItem(o);
                return true;
            }
        }

        /// <summary>
        /// Clears the list, except possibly the item "except".
        /// </summary>
        /// <param name="except">The thing not to remove.</param>
        void Clear(OverlayShape except = null)
        {
            foreach (OverlayShape o in SelectedItems)
                if (o != except)
                    o.SetStdColor();
            SelectedItems.RemoveWhere(o => (o != except));
            //SelectedItems.Clear();
        }

        public void ShiftSelItemsOnScreen(Point RelShift)
        {
            foreach (OverlayShape o in SelectedItems)
            {
                ////Canvas.SetLeft(o, Canvas.GetLeft(o) + RelShift.X);
                ////Canvas.SetBottom(o, Canvas.GetBottom(o) + RelShift.Y);
                o.View.SetPosition(RelShift.X, RelShift.Y, true);
            }
        }

        public override void KeyDown(KeyEventArgs e)
        {
            // move the selected object
            if (SelectedItems.Count > 0)
            {
                double x=0, y=0;
                if (e.Key == Key.Right)
                    x = 1;
                else if (e.Key == Key.Left)
                    x = -1;
                else if (e.Key == Key.Down)
                    y = -1;
                else if (e.Key == Key.Up)
                    y = 1;

                if (x != 0 || y != 0)
                {
                    double step = overlay.Rasterizer.GridWidth * .1;
                    if (step == 0)
                        step = 1;
                    overlay.BeginUpdate();                    
                    ShiftSelItemsInParseTree(new Point(x*step, y*step), overlay.TopLevelItems );
                    overlay.EndUpdate();
                    // update overlay positions
                    foreach (OverlayShape o in overlay.TopLevelItems)
                        o.AdjustPosition(overlay.Resolution);

                    e.Handled = true;
                }
            }
            base.KeyDown(e);
        }

        public override void OnLeftMouseButtonDown(OverlayShape item, Point p, MouseButtonEventArgs e)
        {
            //IInputElement o = canvas1.InputHitTest(e.GetPosition(canvas1));

            if (e.ClickCount == 2 && (item is OverlayScope)) // Select for editing
            {
                overlay.CurEditing = item as OverlayScope;
            }
            else if (e.ClickCount == 2 && (item is OverlayNode))
            {
                overlay.JumpToSourceDoIt(item);
            }
            else if (item is OverlayShape)
            {
                // initiate a drag/drop operation
                curDragged = (OverlayShape)item;
                DragOrigin = (Point)((new Point(item.View.GetLeft(), item.View.GetBottom()))-p); ////e.GetPosition(item);
                ////DragOrigin = new Point(DragOrigin.X, (item as OverlayShape).Height - DragOrigin.Y);
                DragOriginC = p;
                DragOriginO = new Point(curDragged.View.GetLeft(), curDragged.View.GetBottom());
                movedenough = false;
                //MessageBox.Show(o.ToString());

                // select the clicked shape
                if (Keyboard.Modifiers.HasFlag(ModifierKeys.Control))
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
                }

                // adjust raster origin/scale/polar/cartesian
                overlay.SetCorrectRaster(curDragged);

                // capture mouse. this is important if the user drags sth. outside canvas1's bounds
                if (curDragged != null && !overlay.canvas.IsMouseCaptured)
                    overlay.canvas.CaptureMouse();
            }
            else if (item == null)
            {
                BeginSelectionChange(Keyboard.Modifiers.HasFlag(ModifierKeys.Control));

                // display selection rectangle
                SelectionRectOrigin = e.GetPosition(overlay.canvas);
                //SelectionRect.RenderTransform = new TranslateTransform(SelectionRectOrigin.X, SelectionRectOrigin.Y);
                SelectionRect.SetPosition(SelectionRectOrigin.X, SelectionRectOrigin.Y,0,0);
                ////Canvas.SetLeft(SelectionRect, SelectionRectOrigin.X);
                ////Canvas.SetTop(SelectionRect, SelectionRectOrigin.Y);
                ////SelectionRect.Width = 0;
                ////SelectionRect.Height = 0;
                ////Canvas.SetZIndex(SelectionRect, overlay.canvas.Children.Count);
                ////if (!overlay.canvas.Children.Contains(SelectionRect))
                ////    overlay.canvas.Children.Add(SelectionRect);
                ////SelectionRect.Visibility = System.Windows.Visibility.Visible;
                SelectionRect.Visible = true;
                if (!overlay.canvas.IsMouseCaptured)
                    overlay.canvas.CaptureMouse();

            }


        }


        public override void OnMouseMove(Point p, MouseEventArgs e)
        {
            Point mousep = e.GetPosition(overlay.canvas);
            if (SelectionRect.Visible)
            {
                // update the size of the selection rect
                double x = Math.Min(mousep.X, SelectionRectOrigin.X),
                       y = Math.Min(mousep.Y, SelectionRectOrigin.Y);
                //SelectionRect.RenderTransform = new TranslateTransform(x, y);
                ////Canvas.SetLeft(SelectionRect, x);
                ////Canvas.SetTop(SelectionRect, y);
                ////SelectionRect.Width = Math.Abs(mousep.X - SelectionRectOrigin.X);
                ////SelectionRect.Height = Math.Abs(mousep.Y - SelectionRectOrigin.Y);
                SelectionRect.SetPosition(x, y, Math.Abs(mousep.X - SelectionRectOrigin.X), Math.Abs(mousep.Y - SelectionRectOrigin.Y));

                // update current selection
                Rect selr = SelectionRect.GetBB();////System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(SelectionRect); // this is BB of selection rect
                UpdateSelection(selr, Keyboard.Modifiers.HasFlag(ModifierKeys.Control));

            }

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
                         DragOriginO.X + relshift_pixel.X - curDragged.View.GetLeft(),
                         DragOriginO.Y + relshift_pixel.Y - curDragged.View.GetBottom()
                        );

                    ShiftSelItemsOnScreen(relshift_tobedone);
                }
                else if (curDragged is OverlayNode)
                {
                    // use width instead actual width
                    ////Point center_pixel = new Point(p.X - DragOrigin.X + curDragged.Width / 2,
                    ////                               p.Y - DragOrigin.Y + curDragged.Height / 2);
                    Point center_pixel = new Point(p.X - DragOrigin.X,
                                                   p.Y - DragOrigin.Y);
                    // the center pixel of the node should go here
                    center_pixel = overlay.Rasterizer.RasterizePixel(center_pixel);

                    // shift yet to be done
                    Point relshift_tobedone = new Point(
                         center_pixel.X - curDragged.View.GetLeft(),
                         center_pixel.Y - curDragged.View.GetBottom()
                        );
                    ShiftSelItemsOnScreen(relshift_tobedone);

                }
            }
        }

        public override void OnLeftMouseButtonUp(MouseButtonEventArgs e, Point p)
        {
            if (SelectionRect.Visible)
            {
                SelectionRect.Visible = false;
            }

            // adjust position of dragged item (in parsetree)
            if (curDragged != null && movedenough)
            {
                overlay.BeginUpdate();
                // determine the relative shift
                Point relshift = new Point(curDragged.View.GetLeft() - DragOriginO.X, curDragged.View.GetBottom() - DragOriginO.Y);
                Point relshift_tikz = new Point(relshift.X / overlay.Resolution, relshift.Y / overlay.Resolution);
                ShiftSelItemsInParseTree(relshift_tikz, overlay.TopLevelItems);
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

                // update raster in case it has changed
                overlay.SetCorrectRaster(curDragged);

                curDragged = null;

                overlay.EndUpdate();
            }
        }

        /// <summary>
        /// Shifts each selected item's coordinates by specified amount.
        /// Note that items position might be relative to some other node, which can be either also shifted or not.
        /// That's why the dictionary is needed.
        /// The shifting for scopes and nodes is a bit different.
        /// </summary>
        /// <param name="RelShift"></param>
        /// <param name="AllItems"></param>
        public void ShiftSelItemsInParseTree(Point RelShift, List<OverlayShape> AllItems)
        {
            // remember the positions of nodes to which RelShift must be added
            Dictionary<OverlayNode, Point> origPositions = new Dictionary<OverlayNode, Point>();
            foreach (OverlayShape o in SelectedItems)
                if (o is OverlayNode)
                {
                    Point p;
                    if ((o as OverlayNode).tikzitem.GetAbsPos(out p))
                        origPositions[o as OverlayNode] = p;
                    else
                        throw new Exception("Noneditable overlay node found");
                }


            doShiftSelItemsRelative(RelShift, AllItems, origPositions);

        }

        void doShiftSelItemsRelative(Point RelShift, List<OverlayShape> AllItems, Dictionary<OverlayNode, Point> origPositions)
        {
            foreach (OverlayShape o in AllItems)
            {
                if (o is OverlayScope)
                {
                    if (SelectedItems.Contains(o))
                    {
                        o.ShiftItemRelative(RelShift);
                    }
                    else
                    {
                        ShiftSelItemsInParseTree(RelShift, (o as OverlayScope).children);
                    }
                }
                else if (o is OverlayNode && SelectedItems.Contains(o))
                {
                    OverlayNode on = o as OverlayNode;
                    on.tikzitem.SetAbsPos(new Point(origPositions[on].X + RelShift.X, origPositions[on].Y + RelShift.Y));
                    on.tikzitem.UpdateText();
                }
            }
        }

        public void BeginSelectionChange(bool CtrlPressed)
        {
            if (!CtrlPressed)
                Clear();

            SelectedItemsBak = new HashSet<OverlayShape>(SelectedItems);
        }
        public void UpdateSelection(Rect SelectionRect, bool CtrlPressed)
        {
            foreach (OverlayShape o in overlay.GetAllDescendants())
            {
                Rect r = o.View.GetBB();////System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(o);
                bool nowsel = r.IntersectsWith(SelectionRect);
                // for overlayscope, we do not want select it when it it contains completely the selection rect
                if (o is OverlayScope)
                {
                    double framewidth = 10;/// (o as OverlayScope).StrokeThickness; //approximate guess for framewidth
                    r.Inflate(-framewidth, -framewidth);
                    if (r.Contains(SelectionRect))
                        nowsel = false;
                }
                bool shouldbeselected;
                if (Keyboard.Modifiers.HasFlag(ModifierKeys.Control))
                {
                    if (nowsel)
                        shouldbeselected = !SelectedItemsBak.Contains(o);
                    else
                        shouldbeselected = SelectedItemsBak.Contains(o);
                }
                else
                    shouldbeselected = nowsel;

                if (shouldbeselected)
                    AddItem(o as OverlayShape);
                else
                    RemoveItem(o as OverlayShape);

            }
        }

        /* void SelectedItems_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
         {

             if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove
                 || e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Replace
                 )
             {
                 if (e.OldItems != null)
                     foreach (OverLayShape ols in e.OldItems)
                     {
                         ols.SetStdColor();
                     }
             }
             if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
             {
             }
             if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add
                 || e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Replace
                 )
             {
                 if (e.NewItems != null)
                     foreach (OverLayShape ols in e.NewItems)
                     {
                         ols.SetSelectedColor();
                     }
             }

             //throw new NotImplementedException();
         }*/


    }

}