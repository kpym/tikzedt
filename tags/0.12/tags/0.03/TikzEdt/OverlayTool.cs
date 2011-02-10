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
    /// This is the abstract base class of tools for the PdfOverlay.
    /// 
    /// A tool essentially has the following responsibilities:
    ///     1. Call overlay.BeginUpdate() and EndUpdate() before and after editing the Parsetree.
    ///     2. Not edit the parsetree when overlay.Allowediting false.
    ///     3. Clean up when deselected!
    ///     
    /// </summary>
    class OverlayTool
    {
        /// <summary>
        /// Access to the PdfOverlay. It will be set before the first call to OnActivate().
        /// </summary>
        public OverlayInterface overlay;

        /// <summary>
        /// This method is called when the tool is selected by the user.
        /// For example, the cursor shape should be set here.
        /// </summary>
        public virtual void OnActivate() { }
        /// <summary>
        /// This is called when the tool is deselected.
        /// Todo: Clean up after yourself!
        /// </summary>
        public virtual void OnDeactivate() { }

        /// <summary>
        /// This method is called when the tool is active and the appropriate mouse event occurs.
        /// 
        /// </summary>
        /// <param name="item">The item at cursor position.</param>
        /// <param name="p">The cursor position, in BOTTOM LEFT CENTERED pixel coordinates.</param>
        /// <param name="e"></param>
        public virtual void OnLeftMouseButtonDown(OverlayShape item, Point p, MouseButtonEventArgs e) { }
        public virtual void OnLeftMouseButtonUp(MouseButtonEventArgs e, Point p) { }
        /// <summary>
        /// Set e.Handled if you want to turn off the default handling... like opening the context menu etc.
        /// </summary>
        /// <param name="e"></param>
        public virtual void OnRightMouseButtonDown(OverlayShape item, Point p, MouseButtonEventArgs e) { }
        public virtual void OnRightMouseButtonUp(MouseButtonEventArgs e) { }
        public virtual void OnMouseMove(Point p, MouseEventArgs e) { }

    }


    /// <summary>
    /// Tools access the PdfOverlay control through this interface.
    /// It is used to hide the many irrelevant public members of PdfOverlay from
    /// tools.
    /// </summary>
    interface OverlayInterface
    {
        Parser.Tikz_ParseTree ParseTree { get; set; }
        //void SetParseTree(
        bool AllowEditing { get; }

        /// <summary>
        /// The tool must call this method before it makes changes to the parsetree.
        /// </summary>
        void BeginUpdate();
        /// <summary>
        /// The tool must call this method after all (...possible multiple) changes to the parsetree are done.
        /// </summary>
        void EndUpdate();

        void SetCorrectRaster(OverlayShape o, bool IsParent=false);

        /// <summary>
        /// De-activates the current tool, and activates the default tool (select/move)
        /// </summary>
        void ActivateDefaultTool();

        void AddToDisplayTree(Parser.TikzParseItem tpi);

        List<OverlayShape> TopLevelItems { get; }

        Canvas canvas { get; }
        RasterControl Rasterizer { get; }

        OverlayScope CurEditing { get; set; }
        double Resolution { get; }

        string NodeStyle { get; }
        string EdgeStyle { get; }

        Point ScreenToTikz(Point p, bool invY=false);
        Point TikzToScreen(Point p, bool invY = false);

        double Height { get; }
        double Width { get; }
    }

    class SelectionTool : OverlayTool
    {
        Rectangle SelectionRect = new Rectangle();

        public SelectionTool()
        {   
            SelectionRect.Stroke = Brushes.Blue;
            SelectionRect.StrokeThickness = 1; 
            SelectionRect.Visibility = Visibility.Collapsed;
            SelectionRect.Fill = new SolidColorBrush( Color.FromArgb( 0x23, 0x00, 0x8A, 0xCA) );
            SelectionRect.Fill.Freeze();
        }

        HashSet<OverlayShape> SelectedItems = new HashSet<OverlayShape>();
        HashSet<OverlayShape> SelectedItemsBak;

        Point SelectionRectOrigin;

        // all these points are in bottom left centered coordinates (as in LaTeX)
        OverlayShape curDragged;
        Point DragOrigin; // relative to the currently dragged object
        Point DragOriginC; // Mouse position on Canvas when started dragging
        Point DragOriginO; // bottom left of dragged object


        public override void OnActivate()
        {
            overlay.canvas.Cursor = Cursors.Arrow;
        }
        public override void OnDeactivate()
        {
            Clear();
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
                Canvas.SetLeft(o, Canvas.GetLeft(o) + RelShift.X);
                Canvas.SetBottom(o, Canvas.GetBottom(o) + RelShift.Y);
            }
        }

        public override void OnLeftMouseButtonDown(OverlayShape item, Point p, MouseButtonEventArgs e) 
        {
            //IInputElement o = canvas1.InputHitTest(e.GetPosition(canvas1));

            if (e.ClickCount == 2 && (item is OverlayScope)) // Select for editing
            {
                overlay.CurEditing = item as OverlayScope;
            }
            else if (item is OverlayShape)
            {
                // initiate a drag/drop operation
                curDragged = (OverlayShape)item;
                DragOrigin = e.GetPosition(item);
                DragOrigin = new Point(DragOrigin.X, (item as OverlayShape).Height - DragOrigin.Y);
                DragOriginC = p;
                DragOriginO = new Point(Canvas.GetLeft(curDragged), Canvas.GetBottom(curDragged));
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
                Canvas.SetLeft(SelectionRect, SelectionRectOrigin.X);
                Canvas.SetTop(SelectionRect, SelectionRectOrigin.Y);
                SelectionRect.Width = 0;
                SelectionRect.Height = 0;
                Canvas.SetZIndex(SelectionRect, overlay.canvas.Children.Count);
                if (!overlay.canvas.Children.Contains(SelectionRect))
                    overlay.canvas.Children.Add(SelectionRect);
                SelectionRect.Visibility = System.Windows.Visibility.Visible;
                if (!overlay.canvas.IsMouseCaptured)
                    overlay.canvas.CaptureMouse();

            }
        
        
        }

        public override void OnMouseMove(Point p, MouseEventArgs e) 
        {
            Point mousep = e.GetPosition(overlay.canvas);
            if (SelectionRect.Visibility == Visibility.Visible)
            {
                // update the size of the selection rect
                double x = Math.Min(mousep.X, SelectionRectOrigin.X),
                       y = Math.Min(mousep.Y, SelectionRectOrigin.Y);
                //SelectionRect.RenderTransform = new TranslateTransform(x, y);
                Canvas.SetLeft(SelectionRect, x);
                Canvas.SetTop(SelectionRect, y);
                SelectionRect.Width = Math.Abs(mousep.X - SelectionRectOrigin.X);
                SelectionRect.Height = Math.Abs(mousep.Y - SelectionRectOrigin.Y);

                // update current selection
                Rect selr = System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(SelectionRect); // this is BB of selection rect
                UpdateSelection(selr, Keyboard.Modifiers.HasFlag(ModifierKeys.Control), overlay.canvas.Children);

            }

            // for a dragged scope, the relative movement gets rasterized
            // for a dragged node, the center of the node gets rasterized
            if (curDragged != null && e.LeftButton == MouseButtonState.Pressed)
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

                    ShiftSelItemsOnScreen(relshift_tobedone);
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
                    ShiftSelItemsOnScreen(relshift_tobedone);
                }
            }
        }

        public override void OnLeftMouseButtonUp(MouseButtonEventArgs e, Point p) 
        {
            if (SelectionRect.Visibility == Visibility.Visible)
            {
                SelectionRect.Visibility = Visibility.Collapsed;
            }

            // adjust position of dragged item (in parsetree)
            if (curDragged != null)
            {
                overlay.BeginUpdate();
                // determine the relative shift
                Point relshift = new Point(Canvas.GetLeft(curDragged) - DragOriginO.X, Canvas.GetBottom(curDragged) - DragOriginO.Y);
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
        public void UpdateSelection(Rect SelectionRect, bool CtrlPressed, UIElementCollection Elements)
        {
            foreach (FrameworkElement o in Elements)
            {
                if (o is OverlayShape)
                {
                    Rect r = System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(o);
                    bool nowsel = r.IntersectsWith(SelectionRect);
                    // for overlayscope, we do not want select it when it it contains completely the selection rect
                    if (o is OverlayScope)
                    {
                        double framewidth = (o as OverlayScope).StrokeThickness;
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


    class PathTool : OverlayAdderTool
    {
        public override void OnActivate() 
        {
            base.OnActivate();
            overlay.canvas.Cursor = Cursors.Cross;
        }
        
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


            // find next tikzpicture and add
            bool lcreated;
            if (EnsureCurAddToExists(out lcreated))
            {

                if (!lcreated)
                {
                    // add an edge
                    curAddTo.AddChild(new Parser.Tikz_Something(" -- "));
                }

                // create new coordinate
                Parser.Tikz_Coord tc = new Parser.Tikz_Coord();
                curAddTo.AddChild(tc);

                // do it here since the coordinate calculation needs the parents' coord. transform
                tc.SetAbsPos(new Point(p.X, p.Y)); //hack

                //tn.UpdateText();
                curAddTo.UpdateText();
                //tpict.UpdateText();

                // draw the added object in the overlay
                overlay.AddToDisplayTree(tc);
            }

            overlay.EndUpdate();
        }
    }

    class NodeTool : OverlayAdderTool
    {
        public override void OnActivate()
        {
            overlay.canvas.Cursor = Cursors.Cross;
        } 
        
        public override void OnLeftMouseButtonDown(OverlayShape item, Point p, MouseButtonEventArgs e) 
        {
            if (!EnsureParseTreeExists())
                return;

            overlay.BeginUpdate();

            overlay.SetCorrectRaster(overlay.CurEditing, true);

            //Point p = new Point(e.GetPosition(canvas1).X, Height - e.GetPosition(canvas1).Y);
            p = overlay.Rasterizer.RasterizePixelToTikz(p);
            if (ContinueWithBigImage(p) == false)
                return;

            // find next tikzpicture and add
            Parser.Tikz_Picture tpict = overlay.ParseTree.GetTikzPicture();
            if (tpict != null)
            {
                Parser.Tikz_Node tn = new Parser.Tikz_Node();
                tn.label = "?";
                tn.coord = new Parser.Tikz_Coord();
                if (overlay.NodeStyle != "")
                    tn.options = "[" + overlay.NodeStyle + "]";

                Parser.Tikz_Path tp = new Parser.Tikz_Path();
                tp.starttag = @"\node ";
                tp.endtag = ";";

                tp.AddChild(tn);
                if (overlay.CurEditing != null)
                {
                    overlay.CurEditing.tikzitem.AddChild(tp);
                    overlay.CurEditing.tikzitem.AddChild(new Parser.Tikz_Something("\r\n"));
                }
                else
                {
                    tpict.AddChild(tp);
                    tpict.AddChild(new Parser.Tikz_Something("\r\n"));
                }
                // do it here since the coordinate calculation needs the parents' coord. transform
                tn.SetAbsPos(new Point(p.X, p.Y)); //hack

                //tn.UpdateText();
                tp.UpdateText();
                //tpict.UpdateText();

                //RedrawObjects();
                overlay.AddToDisplayTree(tp);
            }

            overlay.EndUpdate();
        }
    }

    class EdgeTool : OverlayAdderTool
    {
        OverlayNode _curSel;
        /// <summary>
        /// Holds the node from which the edge is to be drawn
        /// </summary>
        OverlayNode curSel
        {
            get { return _curSel; }
            set
            {
                if (_curSel != null)
                    _curSel.SetStdColor();
                _curSel = value;
                if (_curSel != null)
                    _curSel.SetSelectedColor();
            }
        }
        public override void OnActivate()
        {
            base.OnActivate();
            overlay.canvas.Cursor = Cursors.UpArrow;
        }
        public override void OnDeactivate()
        {
            base.OnDeactivate();
            curSel = null;
        }

        /// <summary>
        /// Takes an XYItem (like (2,2) or a node) and tries to make it into a referenceable node
        /// (i.e, one with a name)
        /// 
        /// Concretely, the routine does the following:
        ///     - if item is a named node, return item.
        ///     - if item is an unnamed node, give it a unique name and return item.
        ///     - if item is a coordinate, see if there is a node at this coordinate
        ///         (algorithm: see if next non-tikz_something item is a node)
        ///         - if yes, start anew with item=this node
        ///         - if no, add a named node at the specified coordinate
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        Tikz_Node MakeReferenceableNode(Tikz_XYItem item)
        {
            Tikz_Picture tpict = overlay.ParseTree.GetTikzPicture();

            if (item is Tikz_Node)
            {
                Tikz_Node n = item as Tikz_Node;
                if (n.name == "")
                {
                    n.SetName(tpict.GetUniqueName());
                    n.UpdateText();
                }
                return n;
            }
            else if (item is Tikz_Coord)
            {
                // find the next node
                for (int i = item.parent.Children.IndexOf(item) + 1; i < item.parent.Children.Count; i++)
                {
                    if (item.parent.Children[i] is Tikz_Node)
                    {
                        // check if the node is really at the same position as the coordinate item
                        if ((item.parent.Children[i] as Tikz_Node).coord == null)
                            return MakeReferenceableNode(item.parent.Children[i] as Tikz_Node);
                        else
                            break;
                    }
                    
                    if (! (item.parent.Children[i] is Tikz_Something) )
                        break;
                }

                // if we get here, nothing was found => add a new node
                Tikz_Something ws = new Tikz_Something(" ");
                Tikz_Node n = new Tikz_Node();
                n.coord = null;

                item.parent.InsertChildAt(ws, item.parent.Children.IndexOf(item)+1);
                item.parent.InsertChildAt(n, item.parent.Children.IndexOf(item)+2);
                n.SetName(tpict.GetUniqueName());
                n.UpdateText();

                return n;
            }
            else
                throw new NotImplementedException("MakeReferenceableNode not implemented for this type");
        }

        public override void OnLeftMouseButtonDown(OverlayShape item, Point p, MouseButtonEventArgs e) 
        {

            //IInputElement o = canvas1.InputHitTest(e.GetPosition(canvas1));
            if (!(item is OverlayNode))
            {
                curSel = null;
                return;
            }
            OverlayNode n = item as OverlayNode;

            if (curSel == null)
            {
                curSel = n;
                return;
            }

            // make sure both nodes involved are nodes
          /*  if (!(curSel.tikzitem is Tikz_Node) || !(n.tikzitem is Tikz_Node))
            {
                String which = ""; String verb = "is";
                if (!(curSel.tikzitem is Tikz_Node) && !(n.tikzitem is Tikz_Node))
                { which = "Both"; verb = "are"; }
                else if (!(curSel.tikzitem is Tikz_Node))
                    which = "The first";
                else if (!(n.tikzitem is Tikz_Node))
                    which = "The second";
                MainWindow.AddStatusLine(which + " of the selected coordinates " + verb + " not a node (i.e. not defined with \\node but rather with \\draw or \\path)", true);
                curSel = null;
                return; // hack
            } */

            //the return from above must not interfere with BeginModify()
            overlay.BeginUpdate();

            // add an edge curSel to n
            //bool lcreated;
            //if (EnsureCurAddToExists(out lcreated))

            //always create new \draw command. otherwise it can happen that the \draw-command
            //is above the \node-definition which causes an error while compiling the latex code.
            if (AddNewCurAddTo())
            {
                // make sure both nodes involved are nodes


                Parser.Tikz_Node t1 = MakeReferenceableNode(curSel.tikzitem ),
                                 t2 = MakeReferenceableNode(n.tikzitem );

                Parser.Tikz_Coord tc1 = new Parser.Tikz_Coord();
                tc1.type = Parser.Tikz_CoordType.Named;
                Parser.Tikz_Coord tc2 = new Parser.Tikz_Coord();
                tc2.type = Parser.Tikz_CoordType.Named;

                curAddTo.AddChild(new Parser.Tikz_Something(" "));
                curAddTo.AddChild(tc1);
                curAddTo.AddChild(new Parser.Tikz_Something(" edge "));
                curAddTo.AddChild(tc2);
                //tpict.AddChild(tp);                    

                // make sure both nodes have names
                Tikz_Picture tpict = overlay.ParseTree.GetTikzPicture();
                if (t1.name == "")
                {
                    t1.SetName(tpict.GetUniqueName());
                    t1.UpdateText();
                }
                if (t2.name == "")
                {
                    t2.SetName(tpict.GetUniqueName());
                    t2.UpdateText();
                }

                tc1.nameref = t1.name;
                tc2.nameref = t2.name;
                //tc1.UpdateText();
                curAddTo.UpdateText();
                //tpict.UpdateText();
                //                    txtCode_TextChanged

                //RedrawObjects();
                //if (OnModified != null)
                //    OnModified.Invoke();

                //edge was drawn. release currently selected node.
                curSel = null;

                //will neither want to path tool to start from this last select nodes.
                curAddTo = null;
            }
            //forgetting to call EndModify causes weird "No undo group should be open at this point"-message.
            overlay.EndUpdate();
        }

        public override void OnRightMouseButtonDown(OverlayShape item, Point p, MouseButtonEventArgs e)
        {
            //base.OnRightMouseButtonDown(item, p, e);

            // if a node is selected, unselect it
            if (curSel != null)
            {
                curSel = null;
                e.Handled = true;   // we don't want anything else to happen (contextmenu opening etc)
            }
        }
    }

    /// <summary>
    /// This class encapsulates some common methods of tools that have to add something 
    /// (like an edge, path, node) to the tikzpicture.
    /// Many/most tools will be of this type.
    /// </summary>
    class OverlayAdderTool : OverlayTool
    {
        /// <summary>
        /// When adding multiple things in a row, this remembers the path object
        /// the segments are to be added to. 
        /// </summary>
        protected TikzContainerParseItem curAddTo;

        public override void OnActivate()
        {
            base.OnActivate();
            overlay.SetCorrectRaster(overlay.CurEditing, true);
        }

        public override void OnDeactivate()
        {
            base.OnDeactivate();
            curAddTo = null;
        }

        //create a new CurAddTo (even though their already might be one)
        //(needed for edge tool)
        protected bool AddNewCurAddTo()
        {
            // find tikzpicture
            Tikz_Picture tpict = overlay.ParseTree.GetTikzPicture();
            if (tpict == null)
                return false;


            Parser.Tikz_Path tp = new Parser.Tikz_Path();
            tp.starttag = @"\draw";
            tp.endtag = ";";
            if (overlay.EdgeStyle != "")
            {
                Parser.Tikz_Options topt = new Parser.Tikz_Options();
                topt.starttag = "[";
                topt.endtag = "]";
                Parser.Tikz_Option to = new Parser.Tikz_Option();
                to.type = Parser.Tikz_OptionType.key;
                to.key = overlay.EdgeStyle;

                topt.AddOption(to);
                tp.AddChild(topt);
                tp.options = topt;
            }
            if (overlay.CurEditing != null)
            {
                overlay.CurEditing.tikzitem.AddChild(tp);
                overlay.CurEditing.tikzitem.AddChild(new Parser.Tikz_Something("\r\n"));
            }
            else
            {
                tpict.AddChild(tp);
                tpict.AddChild(new Parser.Tikz_Something("\r\n"));
            }
            curAddTo = tp;

            return true;
        }
        protected bool EnsureCurAddToExists(out bool created)
        {
            created = false;
            // find tikzpicture
            Parser.Tikz_Picture tpict = overlay.ParseTree.GetTikzPicture();
            if (tpict == null)
                return false;

            if (curAddTo == null || !(curAddTo is Parser.Tikz_Path))
            {
                created = AddNewCurAddTo();
            }

            return true;
        }

        protected bool ContinueWithBigImage(Point p)
        {
            bool contin = true;
            if (p.X < -100 || p.X > 100 || p.Y < -100 || p.Y > 100)
            {
                if (MessageBoxResult.Cancel == MessageBox.Show("Warning! Image seems to be very big. TikzEdt might not be able to handle this.", "Image very big", MessageBoxButton.OKCancel))
                    contin = false;
            }
            return contin;
        }

        protected bool EnsureParseTreeExists()
        {
            // Try to create a new ParseTree
            if (overlay.ParseTree == null)
            {
                //TryCreateNew(this, out lret);
                if (overlay.AllowEditing)
                {
                    // create a new parsetree
                    Tikz_ParseTree t = new Tikz_ParseTree();
                    Tikz_Picture tp = new Tikz_Picture();
                    tp.starttag = "\\begin{tikzpicture}";
                    tp.AddChild(new Tikz_Something("\r\n"));
                    tp.endtag = "\\end{tikzpicture}";

                    overlay.BeginUpdate();

                    overlay.ParseTree = t;
                    t.AddChild(tp);
                    tp.UpdateText();

                    overlay.EndUpdate();
                    return true;

                }
                else
                {
                    MessageBox.Show("Parse tree could not be created. Please correct all parser errors in the code and try again.", "Function not available", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    return false;
                }
            }
            else return true;

        }

    }
}
