using System;
using System.Collections.Generic;
using System.Windows;
using TikzEdt.Parser;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace TikzEdt.Overlay
{
    public interface IPdfOverlayView
    {
        bool AllowEditing { get; set; }
        System.Windows.Rect BB { get; set; }
        string EdgeStyle { get; set; }
        string NewNodeModifier { get; set; }
        string NodeStyle { get; set; }
        TikzEdt.Parser.Tikz_ParseTree ParseTree { get; set; }
        TikzEdt.RasterControlModel Rasterizer { get; set; }
        double Resolution { get; set; }
        bool UsePolarCoordinates { get; set; }
        OverlayToolType Tool { get; set; }

        void MarkObject(IOverlayShapeView v);
        void JumpToSourceDoIt(OverlayShape o);
        void Clear();
        void SetCursor(Cursor cursor);

        bool MouseCaptured { set; }
        Point CursorPosition { get; }
        OverlayShape ObjectAtCursor { get; }
    }

    public interface IOverlayShapeView
    {
        /// <summary>
        /// Sets the position of the shape on screen.
        /// For Nodes, this is the center of the node. For scopes, the lower right.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="bottom"></param>
        /// <param name="Relative"></param>
        void SetPosition(double left, double bottom, bool Relative=false);
        double GetLeft();
        double GetBottom();
        
        /// <summary>
        /// In top left centric coordinates.
        /// </summary>
        Rect GetBB();
        void SetStdColor();
        void SetSelColor();
        void SetToolTip(string Text);

        /// <summary>
        /// The underlying OverlayShape. Mustbe filled by the OverlayShape that creates the View.
        /// </summary>
        OverlayShape TheUnderlyingShape { get; set; }
    }
    public interface IOverlayScopeView : IOverlayShapeView
    {
        void SetSize(double Width, double Height);
        void ShowAdorner();
        void RemoveAdorner();
    }
    public interface IOverlayCPView : IOverlayShapeView
    {
        /// <summary>
        /// Sets the second endpoint of the line connecting the control point with its origin.
        /// </summary>
        /// <param name="Left"></param>
        /// <param name="Bottom"></param>
        void SetOrigin1(double Left, double Top, double CanvasHeight);
        void SetOrigin2(double Left, double Top, double CanvasHeight);
    }

    public interface IOverlayShapeFactory
    {
        // the following methods create views of objects in the parse tree
        IOverlayShapeView NewNodeView();
        IOverlayScopeView NewScopeView();
        IOverlayCPView NewCPView();

        // the following methods produce geometric shapes for (preview) use in the tools
        // they are not backed by an object in the parsetree
        IRectangleShape GetSelectionRect();
        IRectangleShape GetCPCircle();
        IRectangleShape GetPreviewEllipse();
        IRectangleShape GetPreviewRectangle();
        IFanShape GetPreviewFan();
        IRectangleShape GetPreviewGrid();
        IArcShape GetPreviewArc();
        IArcShape GetPreviewPie();
    }

    public interface IPreviewShape
    {
        Rect GetBB();
        bool Visible { get; set; }
        /// <summary>
        /// Determines the rotation of the shape in radians.
        /// </summary>
        double Rotation { set; }

        void Refresh();
    }

    public interface IRectangleShape : IPreviewShape
    {
        void SetPosition(double Left, double Top, double Width, double Height);
        void SetCenter(double Left, double Bottom);
    }

    public interface IFanShape : IPreviewShape
    {
        double R { get; set; }
        Point Center { get; set; }
        List<double> Spokes { get; set; } 
    }

    public interface IArcShape : IPreviewShape
    {
        Point p1 {get; set;} 
        Point p2 {get; set;} 
        Point center {get; set;}
        bool IsLargeArc { get; set; }
        /// <summary>
        /// Makes shape dashed and Gray instead of solid black
        /// </summary>
        bool IsDashed { set; }
    }

    public class PdfOverlayModel : ViewModels.ViewModelBase, OverlayInterface
    {
        IPdfOverlayView View { get; set; }
        public IOverlayShapeFactory ShapeFactory { get; set; }

        /// <summary>
        /// The link to the overlay (display) tree.
        /// </summary>
        public List<OverlayShape> TopLevelItems { get; set; }

        /// <summary>
        /// Gets a list of all descendants of the specified parent in the Display tree, including the parent itself.
        /// </summary>
        /// <param name="OfParent">The parent. If null, it is taken to be the root.</param>
        /// <returns></returns>
        public IEnumerable<OverlayShape> GetAllDescendants(OverlayShape OfParent = null)
        {
            IEnumerable<OverlayShape> src = null;
            List<OverlayShape> ret = new List<OverlayShape>();
            if (OfParent != null)
                ret.Add(OfParent);
            else src = TopLevelItems;

            if (OfParent is OverlayScope)
                src = (OfParent as OverlayScope).children;

            if (src != null)
                ret.AddRange( src.SelectMany( os => GetAllDescendants(os) ) );

            return ret;
        }

        OverlayScope _CurEditing;
        /// <summary>
        /// This is a link to the scope currently selected for editing.
        /// New nodes/paths are added to this scope.
        /// The scope can be selected for editing by double-clicking or context menu command.
        /// It then becomes highlighted, i.e., a hatched thick additional border is drawn.
        /// </summary>
        public OverlayScope CurEditing
        {
            get { return _CurEditing; }
            set
            {
                if (_CurEditing != null)
                {
                    // remove adorner
                    _CurEditing.View.RemoveAdorner();
                }
                _CurEditing = value;
                if (_CurEditing != null)
                {
                    _CurEditing.View.ShowAdorner();
                }

                SetCorrectRaster(CurEditing); // todo: correct? ,true
            }
        }

        public OverlayTool CurrentTool
        {
            get
            {
                return ToolList[(int)View.Tool];
            }
        }

        // Member variables for the tools
        public SelectionTool selectionTool; // todo: make private
        /*EdgeTool edgeTool = new EdgeTool();
        PathTool pathTool = new PathTool();
        NodeTool nodeTool = new NodeTool();
        SmoothCurveTool smoothCurveTool = new SmoothCurveTool();
        BezierTool bezierTool = new BezierTool();
        GridTool gridTool = new GridTool();
        RectangleTool rectangleTool = new RectangleTool();
        EllipseTool ellipseTool = new EllipseTool();
        ArcTool arcTool = new ArcTool();
        ArcEditTool arcEditTool = new ArcEditTool(); */

        public OverlayTool[] ToolList; // is filled in the constructor


        public PdfOverlayModel(IPdfOverlayView View, IOverlayShapeFactory ShapeFactory)
        {
            this.View = View;
            this.ShapeFactory = ShapeFactory;

            // initialize tools
            selectionTool = new SelectionTool(this);

            // must be in the order of ToolType
            ////ToolList = new OverlayTool[] { selectionTool, nodeTool, edgeTool, pathTool, smoothCurveTool, bezierTool, rectangleTool, ellipseTool, gridTool, arcTool, arcEditTool };
            ToolList = new OverlayTool[] { selectionTool, new NodeTool(this), new EdgeTool(this), new PathTool(this), new SmoothCurveTool(this),
                                           new BezierTool(this), new RectangleTool(this), new EllipseTool(this), new GridTool(this), new ArcTool(this), new ArcEditTool(this) };
            ////foreach (OverlayTool t in ToolList)
            ////    t.overlay = this;
        }       

        public enum AssignStyleType { AssignNewStyle, ChangeToNewStyle, AssignCurrentNodeStyle, ChangeToCurrentNodeStyle }
        public void AssignStyle(AssignStyleType type)
        {
            string cStyle = NodeStyle;
            Tikz_Picture tp = ParseTree.GetTikzPicture();
            if (tp == null)
                return;
            if (View.Tool != OverlayToolType.move)
                return;     // context menu should actually only open with move tool,... but to be safe against later changes...

            if (type == AssignStyleType.AssignNewStyle || type == AssignStyleType.ChangeToNewStyle)
            {
                if (Overlay.InputMessageBox.ShowInputDialog("New style...", "Please enter a unique style name", out cStyle) != MessageBoxResult.OK)
                    return;
                cStyle = cStyle.Trim();
                // check if style name is valid and unique
                if (ParseTree == null || cStyle == "")
                    return;
                if (ParseTree.styles.ContainsKey(cStyle))
                {
                    GlobalUI.ShowMessageBox("Error: Style name '" + cStyle + "' already exists.", "Style exists", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                // add new style, immediately before \begin{tikzpicture}[...]
                BeginUpdate();
                Tikz_Option to = new Tikz_Option();
                to.type = Tikz_OptionType.style;
                to.key = cStyle;
                to.val = "";
                to.text = "\\tikzstyle{" + cStyle + "}=[];";

                int index = ParseTree.Children.IndexOf(tp);
                if (index >= 0)
                {
                    ParseTree.InsertChildAt(to, index);
                    to.RegisterNodeAndStyleRefs();
                    ParseTree.InsertChildAt(new Tikz_Something(Environment.NewLine), index + 1);
                }
            }
            else
            {

                if (cStyle.Trim() == "")
                    return;


                BeginUpdate();
            }

            // loop through selected items and set styles
            foreach (OverlayShape ols in selectionTool.SelItems)
            {
                // currently only node styles can be set
                if (ols.item is Tikz_Node)
                {
                    Tikz_Node tn = ols.item as Tikz_Node;
                    if (tn.options == "" || type  == AssignStyleType.ChangeToCurrentNodeStyle || type == AssignStyleType.ChangeToNewStyle)
                    {
                        tn.options = "[" + cStyle + "]";
                    }
                    else // just add option
                    {
                        string o = tn.options.Trim();
                        if (o.EndsWith("]"))
                        {
                            o = o.Substring(0, o.Length - 1);
                            o = o + ", " + cStyle + "]";
                        } // otherwise, do nothing (error)
                        tn.options = o;
                    }
                    tn.UpdateText();
                }
            }

            EndUpdate();        // Make sure EndUpdate() is always called (..if Beginupdate() was)!
        }

        /// <summary>
        /// This recomputes the positions of all OverlayItems.
        /// (It does not recreate the displaytree, just adjusts positions.)
        /// </summary>
        public void AdjustPositions()
        {
            if (TopLevelItems != null)
                foreach (OverlayShape o in TopLevelItems)
                    o.AdjustPosition(Resolution);
        }

        /// <summary>
        /// Clears all items from the canvas.
        /// </summary>
        public void Clear()
        {
            View.Clear();
            CurEditing = null;
            ParseTree = null;
            View.Tool = View.Tool;    // this deactivates + reactivates the current tool to reset its status... e.g., it might contain links to some selected objects etc.
            TopLevelItems = new List<OverlayShape>();
            Rasterizer.ResetRaster();
        }
        public void RedrawObjects()
        {
            View.Clear();
            //curSel = null;
            CurEditing = null;
            View.Tool = View.Tool;    // this deactivates + reactivates the current tool to reset its status
            TopLevelItems = new List<OverlayShape>();

            if (ParseTree == null)
            {
                Rasterizer.ResetRaster();
                return; // nothing to display
            }

            try
            {
                DrawObject(ParseTree, TopLevelItems);
                BindControlPointsToOrigins();
                SetCorrectRaster((TikzParseItem)null);
            }
            catch (Exception e)
            {
                // we should really not come here.... but there are conceivable tex files with cyclic references that might 
                // produce errors.
                Clear();
                View.AllowEditing = false;
                MainWindow.AddStatusLine("Error in Overlay rendering: '" + e.Message + "' Overlay disabled for now.", true);
            }
        }

        public Point CursorPosition { get { return View.CursorPosition; } }
        public OverlayShape ObjectAtCursor { get { return View.ObjectAtCursor; } }

        /// <summary>
        /// Draws the TikzParseItem tpi, if it is drawn, or its children, if they can be drawn, 
        /// or grandchildren etc..., and adds the drawn items to bag.
        /// </summary>
        /// <param name="tpi"></param>
        /// <param name="bag"></param>
        public void DrawObject(TikzParseItem tpi, List<OverlayShape> bag)
        {
            //BBGatherer bbg = new BBGatherer();
            if (bag == null)
                bag = new List<OverlayShape>();  // dummy, it is not used
            if (tpi is Tikz_Scope)
            {
                OverlayScope os = new OverlayScope(ShapeFactory.NewScopeView());
                os.pol = this;
                os.tikzitem = tpi as Tikz_Scope;
                foreach (TikzParseItem t in (tpi as TikzContainerParseItem).Children)
                    DrawObject(t, os.children);

                // don't draw scopes with no drawable children
                // (we don't know where to render them)
                if (os.children.Count > 0)
                {
                    bag.Add(os);
                    os.AdjustPosition(Resolution);
                    ////canvas1.Children.Add(os);
                }
            }
            else if (tpi is TikzContainerParseItem)
            {
                foreach (TikzParseItem t in (tpi as TikzContainerParseItem).Children)
                    DrawObject(t, bag);
            }
            if (tpi is Tikz_XYItem)
            {
                if ((tpi as Tikz_XYItem).HasEditableCoordinate())
                {
                    OverlayNode el;
                    if (tpi.parent is Tikz_Controls)
                        el = new OverlayControlPoint(ShapeFactory.NewCPView());     // control points for Bezier curves
                    else
                        el = new OverlayNode(ShapeFactory.NewNodeView());
                    el.pol = this;
                    el.tikzitem = tpi as Tikz_XYItem;
                    //Ellipse el = new Ellipse();                                   
                    //el.Stroke = Brushes.Red;

                    el.AdjustPosition(Resolution);

                    // add tooltip
                    Tikz_Node nref = TikzParseTreeHelper.GetReferenceableNode(tpi as Tikz_XYItem, ParseTree.GetTikzPicture());
                    if (nref != null && nref.name != "")
                    {
                        el.View.SetToolTip(nref.name);                        
                    }

                    ////canvas1.Children.Add(el);
                    bag.Add(el);

                    //bbg.Add(new Rect(Canvas.GetLeft(el), Canvas.GetTop(el), el.Width, el.Height));
                }
            }
            else if (tpi is Tikz_Path)
            {
                //could this be a possibility to show edges and provide backward search?

                //there are many possibility for draw commands. here we 
                /* string simpleEdge_RegexString = @"[ \t\s]*\\draw.*\((?<start>.*)\).*\((?<end>.*)\).*";
                Regex BB_Regex = new Regex(simpleEdge_RegexString);
                Match m = BB_Regex.Match(tpi.ToString());
                if (m.Success == true)
                {
                    //we just found a LaTex draw cmd, e.g.: \draw[default_edge] (v91) to (v99);

                    //get both nodes
                    Tikz_Node StartNode = tpi.parent.GetNodeByName(m.Groups[1].Value);
                    Tikz_Node EndNode = tpi.parent.GetNodeByName(m.Groups[2].Value);

                    if (StartNode != null && EndNode != null)
                    {
                        //and determine the position in between both nodes
                        Point start, end;
                        if (StartNode.GetAbsPos()
                        double x = (StartNode.GetAbsPos().X + EndNode.GetAbsPos().X) / 2;
                        double y = (StartNode.GetAbsPos().Y + EndNode.GetAbsPos().Y) / 2;

                        //draw an arrow at this pos.
                        //(new Point(x, y));
                        //and when clicked, jump to AvalonEdit at position tpi.StartPosition                        
                    }

                }       */
            }

        }

        /// <summary>
        /// The displayed raster changes depending on the currently selected object.
        /// This method sets the raster, so as to fit the coordinate transformation at o.
        /// There are two cases:    (i)  (IsParent=false) o is the object being modified, so the relevant coordinate trsf. is that at o
        ///                         (ii) (IsParent=true)  o is a parent object to which items are added. 
        ///                              In this case the relevant transf. is that at the end of o, since new items are inserted at the end.
        /// </summary>
        /// <param name="o">The object. If null, it is taken to be the tikzpicture.</param>
        /// <param name="IsParent">Indicates whether object is to be moved itself, or children added.</param>        
        public void SetCorrectRaster(OverlayShape o, bool IsParent = false)
        {
            SetCorrectRaster(o == null ? null : o.item, IsParent);
        }
        public void SetCorrectRaster(TikzParseItem tpi, bool IsParent = false)
        {
            if (ParseTree == null)
                return;
            if (tpi == null)
            {
                Tikz_Picture tp = ParseTree.GetTikzPicture();
                if (tp != null)
                {
                    TikzMatrix M;
                    if (!tp.GetCurrentTransformAt(null, out M))
                        Rasterizer.View.CoordinateTransform = new TikzMatrix();   // if the program gets here, the global coord. transformation could not be understood->ovelay should display nothing
                    else
                        Rasterizer.View.CoordinateTransform = M;
                    //rasterizer.RasterOrigin = M.Transform(new Point(0, 0));
                    //rasterizer.RasterScale = M.m[1, 1];
                    Rasterizer.View.IsCartesian = !UsePolarCoordinates;
                }
            }
            else if (tpi is Tikz_Scope)
            {
                Tikz_Scope ts = tpi as Tikz_Scope;
                TikzMatrix M;
                if (IsParent)
                {
                    if (!ts.GetCurrentTransformAt(null, out M))  // todo
                        M = new TikzMatrix(); // broken coords-> take unity as backup
                }
                else
                {
                    //if (!ts.parent.GetCurrentTransformAt(ts, out M))
                    //    M = new TikzMatrix();
                    if (!ts.GetRasterTransform(out M))
                        M = new TikzMatrix();
                }
                Rasterizer.View.CoordinateTransform = M;
                //rasterizer.RasterOrigin = M.Transform(new Point(0, 0));
                //rasterizer.RasterScale = M.m[1, 1];
                Rasterizer.View.IsCartesian = !IsParent || !UsePolarCoordinates;
            }
            else if (tpi is Tikz_XYItem)
            {
                Tikz_XYItem t = tpi as Tikz_XYItem;
                Point offset;
                if (t.GetAbsPos(out offset, true))
                {
                    TikzMatrix M;
                    if (!t.parent.GetCurrentTransformAt(t, out M)) //.CloneIt();
                        M = new TikzMatrix();

                    M.m[0, 2] = offset.X;
                    M.m[1, 2] = offset.Y;
                    //rasterizer.RasterScale = M.m[1, 1];
                    Rasterizer.View.CoordinateTransform = M;
                    Rasterizer.View.IsCartesian = !(t.IsPolar());
                }
                else throw new Exception("In PdfOverlay: Encountered drawn item without valid coordinates");
            }
            else if (tpi is Tikz_Path)
            {
                Tikz_Path ts = tpi as Tikz_Path;
                TikzMatrix M;
                if (IsParent)
                {
                    Point curPointAtEnd;
                    if (!ts.GetCurrentTransformAt(null, out M))  // todo
                        M = new TikzMatrix(); // broken coords-> take unity as backup
                    if (ts.GetAbsOffset(out curPointAtEnd, null))
                    {
                        M.m[0, 2] = curPointAtEnd.X;
                        M.m[1, 2] = curPointAtEnd.Y;
                    }
                }
                else
                {
                    if (!ts.parent.GetCurrentTransformAt(ts, out M))
                        M = new TikzMatrix();
                    //if (!ts.GetRasterTransform(out M))
                    //    M = new TikzMatrix();
                }
                Rasterizer.View.CoordinateTransform = M;
                //rasterizer.RasterOrigin = M.Transform(new Point(0, 0));
                //rasterizer.RasterScale = M.m[1, 1];
                Rasterizer.View.IsCartesian = !IsParent || !UsePolarCoordinates;
            }
            else
                Debug.WriteLine("Error in SetCorrectRaster: unsupported type");//Rasterizer.IsCartesian = true;  // should not get here
        }

        /// <summary>
        /// Adds a single parseitem to the display tree and redraws.
        /// This is called by tools adding something to the parsetree to refresh the overlay
        /// without redrawing it completely.
        /// </summary>
        /// <param name="tpi">The parseitem to add.</param>
        public void AddToDisplayTree(TikzParseItem tpi)
        {
            List<OverlayShape> l = new List<OverlayShape>();
            DrawObject(tpi, l);
            if (CurEditing == null)
            {
                //do not redraw if there is nothing to show.
                if (TopLevelItems == null)
                    RedrawObjects();
                TopLevelItems.AddRange(l);
            }
            else
            {
                CurEditing.children.AddRange(l);
            }
            AdjustPositions();
            BindControlPointsToOrigins();
        }

        public void BindControlPointsToOrigins()
        {
            /* ////for (int i = 0; i < canvas1.Children.Count; i++)
            {
                if (canvas1.Children[i] is OverlayControlPoint)
                {
                    (canvas1.Children[i] as OverlayControlPoint).BindToOrigin();
                }
            }*/
            foreach (var ocp in GetAllDescendants().OfType<OverlayControlPoint>())
                ocp.BindToOrigin();

        }

        public Point ScreenToTikz(Point p, bool invY = false)
        {
            if (invY)
                return new Point(p.X / Resolution + View.BB.X, (Height - p.Y) / Resolution + View.BB.Y);
            else return new Point(p.X / Resolution + View.BB.X, p.Y / Resolution + View.BB.Y);
        }
        public Point TikzToScreen(Point p, bool invY = false)
        {
            if (invY)
                return new Point((p.X - View.BB.X) * Resolution, Height - (p.Y - View.BB.Y) * Resolution);
            else return new Point((p.X - View.BB.X) * Resolution, (p.Y - View.BB.Y) * Resolution);
        }


        #region OverlayInterface
        public Parser.Tikz_ParseTree ParseTree
        {
            get { return View.ParseTree; }
            set { View.ParseTree = value; }
        }

        public bool AllowEditing
        {
            get { return View.AllowEditing; }
        }

        public void BeginUpdate()
        {
            if (ParseTree != null)
                ParseTree.BeginModify();
        }

        public void EndUpdate()
        {
            if (ParseTree != null)
                ParseTree.EndModify();
        }

        public void ActivateDefaultTool()
        {
            View.Tool = OverlayToolType.move;
        }

        public RasterControlModel Rasterizer
        {
            get { return View.Rasterizer; }
        }

        public double Resolution
        {
            get { return View.Resolution; }
        }

        public string NodeStyle
        {
            get { return View.NodeStyle; }
        }

        public string EdgeStyle
        {
            get { return View.EdgeStyle; }
        }

        public double Height
        {
            get { return View.BB.Height * View.Resolution; }
        }

        public double Width
        {
            get { return View.BB.Width * View.Resolution; }
        }

        public string NewNodeModifier
        {
            get { return View.NewNodeModifier; }
        }

        public bool UsePolarCoordinates
        {
            get { return View.UsePolarCoordinates; }
        }

        public void JumpToSourceDoIt(OverlayShape o)
        {
            View.JumpToSourceDoIt(o);
        }

        #endregion


        /// <summary>
        /// Tries to display a ring around the object at text position
        /// offset.
        /// </summary>
        /// <param name="offset">The text position.</param>
        public void MarkObjectAt(int offset)
        {
            OverlayShape ols = ObjectFromOffset(offset, TopLevelItems);
            if (ols != null)
            {
                View.MarkObject(ols.View);
            }
        }

        /// <summary>
        /// This method searches recursively among all items in the displaytree for one whose associated code segment
        /// contains the position offset. In case multiple items match, the deepest (in the tree) one is chosen.
        /// E.g., if a scope contains a node, and the offset matches the node, it also also lies within the scope,
        /// but the node is returned.
        /// </summary>
        /// <param name="offset">The code position.</param>
        /// <param name="bag">Overlayshapes to search in.</param>
        /// <returns></returns>
        public OverlayShape ObjectFromOffset(int offset, List<OverlayShape> bag)
        {
            foreach (OverlayShape ols in bag)
            {
                if (ols.item.StartPosition() <= offset && ols.item.StartPosition() + ols.item.ToString().Length > offset)
                {
                    // check if there is a child that fits better
                    if (ols is OverlayScope)
                    {
                        OverlayShape olsinner = ObjectFromOffset(offset, (ols as OverlayScope).children);
                        if (olsinner != null)
                            return olsinner;
                    }
                    return ols;
                }
            }
            return null;
        }



        public void SetCursor(System.Windows.Forms.Cursor cursor)
        {
            View.SetCursor(cursor);
        }


        public bool MouseCaptured
        {
            set { View.MouseCaptured = value; }
        }
    }

}
