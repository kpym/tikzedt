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
    //public enum OverlayToolType { move, addvert, addedge, addpath, smooth, bezier, rectangle, ellipse, grid, arc, arcedit } 

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
        /// This is called by the overlay when the tool should update the raster, (usually because the UsePolar... setting has changed) 
        /// </summary>
        public virtual void UpdateRaster() { }        

        /// <summary>
        /// This method is called when the tool is active and the appropriate mouse event occurs.
        /// 
        /// </summary>
        /// <param name="item">The item at cursor position.</param>
        /// <param name="p">The cursor position, in BOTTOM LEFT CENTERED pixel coordinates.</param>
        /// <param name="e"></param>
        public virtual void OnLeftMouseButtonDown(OverlayShape item, Point p, MouseButtonEventArgs e) { }
        /// <summary>
        /// LeftMouseButtonUp event, forwarded from the overlay control.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        public virtual void OnLeftMouseButtonUp(MouseButtonEventArgs e, Point p) { }
        /// <summary>
        /// Set e.Handled if you want to turn off the default handling... like opening the context menu etc.
        /// </summary>
        /// <param name="item">The item on which the event occurred.</param>   
        /// <param name="p">The cursor position, in BOTTOM LEFT CENTERED pixel coordinates.</param>
        /// <param name="e"></param>       
        public virtual void OnRightMouseButtonDown(OverlayShape item, Point p, MouseButtonEventArgs e) { }
        /// <summary>
        /// "Raw" MouseButtonUp event, forwarded from the overlay control.
        /// </summary>
        /// <param name="e"></param>
        public virtual void OnRightMouseButtonUp(MouseButtonEventArgs e) { }
        /// <summary>
        /// MouseMove event, forwarded from the overlay control.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="e"></param>
        public virtual void OnMouseMove(Point p, MouseEventArgs e) { }

        /// <summary>
        /// KeyDown event, forwarded from the overlay control.
        /// </summary>
        /// <param name="e"></param>
        public virtual void KeyDown(KeyEventArgs e) { }
        /// <summary>
        /// KeyUp event, forwarded from the overlay control.
        /// </summary>
        /// <param name="e"></param>
        public virtual void KeyUp(KeyEventArgs e) { }

    }


    /// <summary>
    /// Tools access the PdfOverlay control through this interface.
    /// It is used to hide the many irrelevant public members of PdfOverlay from
    /// tools.
    /// </summary>
    interface OverlayInterface
    {
        Parser.Tikz_ParseTree ParseTree { get;  }
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
        void SetCorrectRaster(TikzParseItem tpi, bool IsParent = false);

        /// <summary>
        /// De-activates the current tool, and activates the default tool (select/move)
        /// </summary>
        void ActivateDefaultTool();

        void AddToDisplayTree(Parser.TikzParseItem tpi);

        List<OverlayShape> TopLevelItems { get; }

        Canvas canvas { get; }
        RasterControlModel Rasterizer { get; }

        OverlayScope CurEditing { get; set; }
        double Resolution { get; }

        string NodeStyle { get; }
        string EdgeStyle { get; }

        Point ScreenToTikz(Point p, bool invY=false);
        Point TikzToScreen(Point p, bool invY = false);

        double Height { get; }
        double Width { get; }

        /// <summary>
        /// Determines whether to use absolute "", or relative "+" or "++" coordinates
        /// </summary>
        string NewNodeModifier { get; }
        bool UsePolarCoordinates { get; }

        void JumpToSourceDoIt(OverlayShape o);
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

            //overlay.SetCorrectRaster(overlay.CurEditing, true);
            UpdateRaster();
            //Point p = new Point(e.GetPosition(canvas1).X, Height - e.GetPosition(canvas1).Y);


            // find next tikzpicture and add
            bool lcreated;
            if (EnsureCurAddToExists(out lcreated))
            {
                // on double click -> close path
                if (e.ClickCount == 2)
                {
                    if (!lcreated)
                    {
                        //if (!Keyboard.Modifiers.HasFlag(ModifierKeys.Control))
                            curAddTo.AddChild(new Parser.Tikz_Something(" -- cycle"));
                        //else
                        //    curAddTo.AddChild(new Parser.Tikz_Something(" cycle"));
                    }
                }
                else
                {
                    if (!lcreated)
                    {
                        if (!Keyboard.Modifiers.HasFlag(ModifierKeys.Control))
                            // add an edge
                            curAddTo.AddChild(new Parser.Tikz_Something(" -- "));
                        else
                            curAddTo.AddChild(new Parser.Tikz_Something(" "));
                    }

                    // create new coordinate. If some node was clicked, set a reference to that node. Otherwise, just make new coordinates
                    Tikz_Coord tc = new Tikz_Coord();
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
                        tc.type = overlay.UsePolarCoordinates ? Tikz_CoordType.Polar : Tikz_CoordType.Cartesian;
                        if (!lcreated) 
                            tc.deco = overlay.NewNodeModifier;  // first node should always be in absolute coordinates
                        tc.SetAbsPos(new Point(p.X, p.Y)); //hack

                        // if a nonempty node style is selected, also add a node with that style
                        if (overlay.NodeStyle.Trim() != "")
                        {
                            Tikz_Node tn = new Tikz_Node()
                            {
                                options = "["+overlay.NodeStyle+"]",
                                coord = null,
                                text = ""
                            };
                            curAddTo.AddChild(new Tikz_Something(" "));
                            curAddTo.AddChild(tn);
                        }
                    }
                    //tn.UpdateText();
                    curAddTo.UpdateText();
                    //tpict.UpdateText();

                    // draw the added object in the overlay
                    overlay.AddToDisplayTree(tc);
                }
            }

            overlay.EndUpdate();
            UpdateRaster();

            // doubleclick also stops path drawing
            if (e.ClickCount == 2)
                overlay.ActivateDefaultTool();
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
                tn.label = "";
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


        public override void OnLeftMouseButtonDown(OverlayShape item, Point p, MouseButtonEventArgs e) 
        {

            //IInputElement o = canvas1.InputHitTest(e.GetPosition(canvas1));
            if (!(item is OverlayNode))
            {
                curSel = null;
                return;
            }
            OverlayNode n = item as OverlayNode;

            // make sure a referenceable item is selected... otherwise we cannot add an edge
            if (!IsReferenceable(item))
            {
                MainWindow.AddStatusLine("Only items that are referenceable (=can be given names) can be connected with the edge tool.");
                return;
            }

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
                // make sure both nodes involved have names
                Parser.Tikz_Node t1 = MakeReferenceableNode(curSel.tikzitem ),
                                 t2 = MakeReferenceableNode(n.tikzitem );

                Parser.Tikz_Coord tc1 = new Parser.Tikz_Coord();
                tc1.type = Parser.Tikz_CoordType.Named;
                Parser.Tikz_Coord tc2 = new Parser.Tikz_Coord();
                tc2.type = Parser.Tikz_CoordType.Named;

                curAddTo.AddChild(new Parser.Tikz_Something(" "));
                curAddTo.AddChild(tc1);
                if (t1 == t2)                
                    curAddTo.AddChild(new Parser.Tikz_Something(" edge[loop, looseness=20] "));                
                else
                    curAddTo.AddChild(new Parser.Tikz_Something(" edge "));
                curAddTo.AddChild(tc2);
                //tpict.AddChild(tp);                    

                // make sure both nodes have names
  /*              Tikz_Picture tpict = overlay.ParseTree.GetTikzPicture();
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
                */
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

        public override void UpdateRaster()
        {
            base.UpdateRaster();
            if (curAddTo != null)
                overlay.SetCorrectRaster(curAddTo, true);
            else
                overlay.SetCorrectRaster(overlay.CurEditing, true);
        }

        //create a new CurAddTo (even though their already might be one)
        //(needed for edge tool)
        protected virtual bool AddNewCurAddTo()
        {
            // find tikzpicture
            Tikz_Picture tpict = overlay.ParseTree.GetTikzPicture();
            if (tpict == null)
                return false;


            Parser.Tikz_Path tp = new Parser.Tikz_Path();
            tp.starttag = @"\draw ";
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
        protected virtual bool EnsureCurAddToExists(out bool created)
        {
            created = false;
            if (overlay.ParseTree == null)
                return false;
            // find tikzpicture
            Parser.Tikz_Picture tpict = overlay.ParseTree.GetTikzPicture();
            if (tpict == null)
            {
                if (overlay.AllowEditing)
                {
                    // add a new tikzpicture
                    Tikz_Picture tp = new Tikz_Picture();
                    tp.starttag = "\\begin{tikzpicture}";
                    tp.AddChild(new Tikz_Something("\r\n"));
                    tp.endtag = "\\end{tikzpicture}";

                    //overlay.BeginUpdate();

                    overlay.ParseTree.AddChild(tp);
                    tp.UpdateText();

                    //overlay.EndUpdate();
                }
                else 
                    return false;
            }

            if (curAddTo == null || !(curAddTo is Parser.Tikz_Path))
            {
                created = AddNewCurAddTo();
            }

            return true;
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
        protected Tikz_Node MakeReferenceableNode(Tikz_XYItem item)
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

                    if (!(item.parent.Children[i] is Tikz_Something))
                        break;
                }

                // if we get here, nothing was found => add a new node
                Tikz_Something ws = new Tikz_Something(" ");
                Tikz_Node n = new Tikz_Node();
                n.coord = null;

                item.parent.InsertChildAt(ws, item.parent.Children.IndexOf(item) + 1);
                item.parent.InsertChildAt(n, item.parent.Children.IndexOf(item) + 2);
                n.SetName(tpict.GetUniqueName());
                n.UpdateText();

                return n;
            }
            else
                throw new NotImplementedException("MakeReferenceableNode not implemented for this type");
        }

        /// <summary>
        /// Determines whether the object represented by the OverlayShape item can be 
        /// given a reference to. This is the case, e.g., for standard coordinates. It is
        /// however not the case for the coordinates in a smooth curve.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        protected bool IsReferenceable(OverlayShape item)
        {
            if (!(item is OverlayNode))
                return false;

            Tikz_XYItem it = (item as OverlayNode).tikzitem;

            // check whether item occurs in smooth curve 
            // we check whether the parent's parent has the word "coordinates" preceding the parent (this is a bit of a hack)
            if (it is Tikz_Coord && (it.parent.parent is Tikz_Path))
            {
                Tikz_Path grandpa = it.parent.parent as Tikz_Path;
                for (int i = grandpa.Children.IndexOf(it.parent) - 1; i > 0; i--)
                {
                    if (!(grandpa.Children[i] is Tikz_Something))
                        break;
                    if (grandpa.Children[i].text.ToLower().Contains("coordinates"))
                        return false;
                }

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
                // TODO
                return false;

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

              //      overlay.ParseTree = t;
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
