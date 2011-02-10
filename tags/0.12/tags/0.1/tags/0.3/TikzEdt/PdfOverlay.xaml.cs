using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TikzEdt.Parser;

using System.Text.RegularExpressions;

namespace TikzEdt
{
    /// <summary>
    /// The PdfOverlay component is responsible for displaying the Wysiwyg layer on top of the displayed pdf.
    /// It contains all the logic for the Wysiwyg manipulations.
    /// It does not manipulate the sourcecode directly, but manipulates the TikzParseTree.
    /// All changes can be caught by subscribing to the OnModified event.
    /// (MainWindow subsribes to this event and updates the source code appropriately.)
    /// 
    /// Note on coordinates:
    /// Two sorts of coordinates are used:
    ///     (i)  Pixel coordinates (of course, since wpf needs them).
    ///     (ii) Absolute Cartesian Tikz coordinates. (Disregarding polar setting / coordinate transform).
    /// </summary>
    public partial class PdfOverlay : UserControl, OverlayInterface
    {
        #region EVENTS
        public delegate void ModifiedEventHandler(TikzParseItem sender, string oldtext);
        /// <summary>
        /// This event is called whenever the picture gets modified.
        /// For example, in the handler one should update the code listing
        /// The sender is the TIkzparseItem modified and oldtext is its text prior to the change.
        /// </summary>
        public event ModifiedEventHandler OnModified;
        public delegate void NoArgsEventHandler(object sender);
        /// <summary>
        /// This gets called prior to each group of modifications.
        /// One user action, i.e., add path, might trigger multiple OnModified events.
        /// Events will then be raised like this 
        ///     BeginModify
        ///     OnModified
        ///     ...
        ///     OnModified
        ///     EndModify
        /// </summary>
        public event NoArgsEventHandler BeginModify;
        public void BeginUpdate()
        {
            if (BeginModify != null)
                BeginModify(this);
        }
        /// <summary>
        /// Called after group of modifiactions has been done.
        /// See BeginModify.
        /// </summary>
        public event NoArgsEventHandler EndModify;
        public void EndUpdate()
        {
            if (EndModify != null)
                EndModify(this);
        }
        /// <summary>
        /// Called when the currently selected tool has changed.
        /// </summary>
        public event NoArgsEventHandler ToolChanged;
        public delegate void CallbackEventHandler(object sender, out bool allow);
        /// <summary>
        /// If the user attempts to add something (node, path...) to the empty PdfOverlay Control (i.e., ParseTree=null)
        /// by default a new TikzPicture is created, to add the something to.
        /// By catching the TryCreateNew Callback this can be forbidden.
        /// (E.g., in a situation when the ParseTree is null because of errors in the document, 
        /// not because nothing has been drawn yet.)
        /// </summary>
        //public event CallbackEventHandler TryCreateNew;
        /// <summary>
        /// This event is called when user selectes Jump To Source on an Overlay item.
        /// The parameter sender will contain the TikzParseItem the user wants to jump to.
        /// (Call its StartPosition() method to determine the text offset.)
        /// </summary>
        public event NoArgsEventHandler JumpToSource;

        #endregion

        #region PROPERTIES
        public static readonly DependencyProperty NodeStyleProperty = DependencyProperty.Register(
        "NodeStyle", typeof(string), typeof(PdfOverlay), new PropertyMetadata(""));
        public string NodeStyle
        {
            get { return (string)GetValue(NodeStyleProperty); }
            set { }
        }
        public static readonly DependencyProperty EdgeStyleProperty = DependencyProperty.Register(
        "EdgeStyle", typeof(string), typeof(PdfOverlay), new PropertyMetadata(""));
        public string EdgeStyle
        {
            get { return (string)GetValue(EdgeStyleProperty); }
            set { }
        }

        private bool _AllowEditing=true;
        /// <summary>
        /// This property determines when the overlay can be edited by the user.
        /// For TikzEdt, it is should be set to false whenever the document is out of sync with the current parsetree.
        /// This happens (i) while parsing a recent change and (ii) upon parse error
        /// </summary>
        public bool AllowEditing
        {
            get { return _AllowEditing; }
            set { 
                _AllowEditing = value;
                // display a transparent grid on top of the control that captures all input and displays 
                // a no-go message via tooltip
                if (_AllowEditing)
                    DisablerGrid.Visibility = System.Windows.Visibility.Collapsed;
                else
                    DisablerGrid.Visibility = System.Windows.Visibility.Visible;
            }
        }

        Tikz_ParseTree _parsetree;
        /// <summary>
        /// The Parse tree currently being displayed is stored in this property.
        /// </summary>
        public Tikz_ParseTree ParseTree
        {
            get { return _parsetree; }
            set 
            {
                if (_parsetree != null)
                    _parsetree.TextChanged -= new Tikz_ParseTree.TextChangedHandler(_parsetree_TextChanged);
                _parsetree = value;
                //curAddTo = null;
                if (_parsetree != null)
                    _parsetree.TextChanged += new Tikz_ParseTree.TextChangedHandler(_parsetree_TextChanged);
            }
        }

        private double _Resolution = Consts.ptspertikzunit;
        public double Resolution
        {
            get { return _Resolution; }
            set
            {
                if (value > 0)
                {
                    _Resolution = value;
                    Width = BB.Width * Resolution;
                    Height = BB.Height * Resolution;
                    AdjustPositions();
                }
            }
        }

        private Rect _BB = new Rect(0,0,10,10);
        public Rect BB
        {
            get { return _BB; }
            set 
            { 
                _BB = value;
                Resolution = Resolution; // to redraw
            }
        }

        private List<OverlayShape> _TopLevelItems;
        /// <summary>
        /// The link to the overlay (display) tree.
        /// </summary>
        public List<OverlayShape> TopLevelItems { get { return _TopLevelItems; } set { _TopLevelItems = value; } }

        public Canvas canvas { get { return canvas1; } }

        private RasterControl _Rasterizer;
        public RasterControl Rasterizer { get { return _Rasterizer; } set { _Rasterizer = value; } }

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
                    AdornerLayer al = AdornerLayer.GetAdornerLayer(CurEditing);
                    if (al != null)
                    {
                        Adorner[] toRemoveArray = al.GetAdorners(CurEditing);
                        if (toRemoveArray != null)
                        {
                            AdornerLayer.GetAdornerLayer(CurEditing).Remove(toRemoveArray[0]);
                        }
                    }
                }
                _CurEditing = value;
                if (_CurEditing != null)
                    AdornerLayer.GetAdornerLayer(CurEditing).Add(new ScopeAdorner(CurEditing));

                SetCorrectRaster(CurEditing); // todo: correct? ,true
            }
        }

        OverlayTool CurrentTool
        {
            get
            {
                switch (tool)
                {
                    case ToolType.move:
                        return selectionTool;
                    case ToolType.addedge:
                        return edgeTool;
                    case ToolType.addpath:
                        return pathTool;
                    case ToolType.addvert:
                        return nodeTool;
                    case ToolType.rectangle:
                        return rectangleTool;
                    case ToolType.ellipse:
                        return ellipseTool;
                    default:
                        throw new Exception("Unknown tool type... please make sure all tool types are handled in PdfOverlay.CurrentTool."); // should not come here
                }
            }
        }

        public enum ToolType { move, addvert, addedge, addpath, rectangle, ellipse }
        ToolType _tool = ToolType.move;
        public ToolType tool
        {
            get { return _tool; }
            set
            {
                ToolType old = _tool;
                CurrentTool.OnDeactivate();
                _tool = value;
                CurrentTool.OnActivate();
                if (old != _tool && ToolChanged != null)
                    ToolChanged(this);
            }
        }

        // Member variables for the tools
        SelectionTool selectionTool = new SelectionTool();
        EdgeTool edgeTool = new EdgeTool();
        PathTool pathTool = new PathTool();
        NodeTool nodeTool = new NodeTool();
        RectangleTool rectangleTool = new RectangleTool();
        EllipseTool ellipseTool = new EllipseTool();


        #endregion

        #region MarkObjectAt

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
                MarkerCenter = new Point(Canvas.GetLeft(ols) + ols.Width / 2, Canvas.GetBottom(ols) + ols.Height / 2);
                MarkerEllipse.Width = Math.Max(ols.Width, ols.Height);
                //MarkerEllipse.Width = Math.Max(ols.ActualWidth, ols.ActualHeight);
                //da.KeyFrames.Add(new DoubleKeyFrame());
                Canvas.SetBottom(MarkerEllipse, MarkerCenter.Y - MarkerEllipse.ActualHeight / 2);
                Canvas.SetLeft(MarkerEllipse, MarkerCenter.X - MarkerEllipse.ActualWidth / 2);

                if (!canvas1.Children.Contains(MarkerEllipse))
                    canvas1.Children.Add(MarkerEllipse);
                Storyboard anim = (Storyboard)FindResource("MarkerAnimation");
                anim.Begin(this);
                MarkerEllipse.Visibility = System.Windows.Visibility.Visible;
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

        Point MarkerCenter = new Point(100, 100);
        private void DoubleAnimationUsingKeyFrames_Changed(object sender, EventArgs e)
        {
            if (MarkerEllipse != null)
            {
                Canvas.SetBottom(MarkerEllipse, MarkerCenter.Y - MarkerEllipse.ActualHeight / 2);
                Canvas.SetLeft(MarkerEllipse, MarkerCenter.X - MarkerEllipse.ActualWidth / 2);
            }
        }

        private void Storyboard_Completed(object sender, EventArgs e)
        {
            MarkerEllipse.Visibility = Visibility.Hidden;
        }
        #endregion

        /// <summary>
        /// This method is called by the parsetree upon change.
        /// It just redirects the event...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="oldtext"></param>
        void _parsetree_TextChanged(TikzParseItem sender, string oldtext)
        {
            if (OnModified != null)
                OnModified(sender, oldtext);
        }

        // resets tool to standard (= the move tool)
        public void ActivateDefaultTool()
        {
            tool = ToolType.move;
        }
        
        //List<Control> objects = new List<Control>();

        //System.Collections.ObjectModel.ObservableCollection<OverlayShape> SelectedItems = new System.Collections.ObjectModel.ObservableCollection<OverlayShape>();
        //List<OverlayShape> SelectedItemsBak = new List<OverlayShape>();   // stores old selection during SelectionRect display

        public PdfOverlay()
        {
            InitializeComponent();

            // initialize tools
            selectionTool.overlay = this;
            edgeTool.overlay = this;
            nodeTool.overlay = this;
            pathTool.overlay = this;
            rectangleTool.overlay = this;
            ellipseTool.overlay = this;
        }

        /// <summary>
        /// Sets the current parsetree and updates the overlay.
        /// </summary>
        /// <param name="t">The new parsetree.</param>
        /// <param name="tBB">The new bounding box.</param>
        public void SetParseTree(Tikz_ParseTree t, Rect tBB)
        {
            BB = tBB;
            ParseTree = t;
            //curSel = null; //curDragged = null;
            Resolution = Resolution; // to recalc size
            ActivateDefaultTool(); // to reset current tool
            RedrawObjects();
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

        public Point ScreenToTikz(Point p, bool invY=false)
        {
            if (invY)
                return new Point(p.X / Resolution + BB.X, (Height-p.Y)/Resolution + BB.Y );
            else return new Point(p.X / Resolution + BB.X, p.Y / Resolution + BB.Y);
        }
        public Point TikzToScreen(Point p, bool invY = false)
        {
            if (invY)
                return new Point((p.X- BB.X)*Resolution, Height - (p.Y- BB.Y)*Resolution );
            else return new Point((p.X - BB.X) * Resolution, (p.Y - BB.Y) * Resolution);
        }

        /// <summary>
        /// Clears all items from the canvas.
        /// </summary>
        public void Clear()
        {
            canvas1.Children.Clear();
            CurEditing = null;
            ParseTree = null;
            tool = tool;    // this deactivates + reactivates the current tool to reset its status... e.g., it might contain links to some selected objects etc.
            TopLevelItems = new List<OverlayShape>();
            Rasterizer.ResetRaster();
        }
        public void RedrawObjects()
        {
            canvas1.Children.Clear();
            //curSel = null;
            CurEditing = null;
            tool = tool;    // this deactivates + reactivates the current tool to reset its status
            TopLevelItems = new List<OverlayShape>();

            if (ParseTree == null)
            {
                Rasterizer.ResetRaster();
                return; // nothing to display
            }

            try
            {
                DrawObject(ParseTree, TopLevelItems);
                SetCorrectRaster(null);
            }
            catch (Exception e)
            {
                // we should really not come here.... but there are conceivable tex files with cyclic references that might 
                // produce errors.
                Clear();
                AllowEditing = false;
                MainWindow.AddStatusLine("Error in Overlay rendering: '"+e.Message + "' Overlay disabled for now.", true);
            }
        }

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
                OverlayScope os = new OverlayScope();
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
                    canvas1.Children.Add(os);
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
                    OverlayNode el = new OverlayNode();
                    el.pol = this;
                    el.tikzitem = tpi as Tikz_XYItem;
                    //Ellipse el = new Ellipse();                                   
                    //el.Stroke = Brushes.Red;
                    
                    el.AdjustPosition(Resolution);

                    // add tooltip
                    if (tpi is Tikz_Node && (tpi as Tikz_Node).name != "")
                    {
                        ToolTip tip = new ToolTip();
                        tip.Content = new TextBlock(new Run((tpi as Tikz_Node).name));
                        el.ToolTip = tip;                        
                    }

                    canvas1.Children.Add(el);
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

        private void canvas1_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousep = e.GetPosition(canvas1);
            // convert to bottom left coordinates
            Point p = new Point(mousep.X, Height - mousep.Y);

            CurrentTool.OnMouseMove(p, e);
            
            // display the current mouse position
            p.Y /= Resolution;
            p.X /= Resolution;
            p.X += _BB.X;
            p.Y += _BB.Y;
                   
            String s = "(" + String.Format("{0:f1}", p.X) + "; "+ String.Format("{0:f1}", p.Y) + ")";
            ((MainWindow)Application.Current.Windows[0]).AddStatusBarCoordinate(s);
            
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
        public void SetCorrectRaster(OverlayShape o, bool IsParent=false)
        {
            if (ParseTree == null)
                return;
            if (o == null)
            {
                Tikz_Picture tp = ParseTree.GetTikzPicture();
                if (tp != null)
                {
                    TikzMatrix M;
                    if (!tp.GetCurrentTransformAt(null, out M))
                       Rasterizer.CoordinateTransform = new TikzMatrix();   // if the program gets here, the global coord. transformation could not be understood->ovelay should display nothing
                    else
                        Rasterizer.CoordinateTransform = M;
                    //rasterizer.RasterOrigin = M.Transform(new Point(0, 0));
                    //rasterizer.RasterScale = M.m[1, 1];
                    Rasterizer.IsCartesian = true;
                }
            }
            if (o is OverlayScope)
            {
                Tikz_Scope ts = (o as OverlayScope).tikzitem;
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
                Rasterizer.CoordinateTransform = M;
                //rasterizer.RasterOrigin = M.Transform(new Point(0, 0));
                //rasterizer.RasterScale = M.m[1, 1];
                Rasterizer.IsCartesian = true;
            }
            else if (o is OverlayNode)
            {
                Tikz_XYItem t = (o as OverlayNode).tikzitem;
                Point offset;
                if (t.GetAbsPos(out offset, true))
                {
                    TikzMatrix M;
                    if (!t.parent.GetCurrentTransformAt(t, out M)) //.CloneIt();
                        M = new TikzMatrix();
                    M.m[0, 2] = offset.X;
                    M.m[1, 2] = offset.Y;
                    //rasterizer.RasterScale = M.m[1, 1];
                    Rasterizer.CoordinateTransform = M;
                    Rasterizer.IsCartesian = !(t.IsPolar());
                }
                else throw new Exception("In PdfOverlay: Encountered drawn item without valid coordinates");
            }
            else
                Rasterizer.IsCartesian = true;  // should not get here
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
        }
    
        private void canvas1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // call left down-method in the current tool
            Point mousep = e.GetPosition(canvas1);
            object oo = canvas1.InputHitTest(mousep);
            if (! ( oo is OverlayShape))
                oo = null;
            CurrentTool.OnLeftMouseButtonDown(oo as OverlayShape, new Point(mousep.X, Height - mousep.Y), e);
                        
        }


        private void canvas1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            if (canvas1.IsMouseCaptured)
                canvas1.ReleaseMouseCapture();
            Point mousep = e.GetPosition(canvas1);
            CurrentTool.OnLeftMouseButtonUp(e, new Point(mousep.X, Height - mousep.Y));

        }


        /// <summary>
        /// Raises the Jumptosource event.
        /// Note that the object to be jumped to might not be at the current mouse position.
        /// (Namely, if the context menu was opened->mouse position changed to menu item-> clicked)
        /// It is stored in mnuJumpSource.Tag
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JumpToSourceDoIt(object sender, RoutedEventArgs e)
        {
            if (sender != mnuJumpSource)
            {
                // jump to object at mouse position
                IInputElement o = canvas1.InputHitTest(Mouse.GetPosition(canvas1));
                if (o is OverlayShape)
                {
                    mnuJumpSource.Tag = o;
                }
                else mnuJumpSource.Tag = null;
            }

            if (JumpToSource != null && mnuJumpSource.Tag != null)
            {
                if (mnuJumpSource.Tag is OverlayScope)
                    JumpToSource((mnuJumpSource.Tag as OverlayScope).tikzitem);
                else if (mnuJumpSource.Tag is OverlayNode)
                    JumpToSource((mnuJumpSource.Tag as OverlayNode).tikzitem);
            }
        }
        private void contextmenuClick(object sender, RoutedEventArgs e)
        {
            if (sender == mnuMove)
                tool = ToolType.move;
            else if (sender == mnuAddNode)
                tool = ToolType.addvert;
            else if (sender == mnuAddEdge)
                tool = ToolType.addedge;
            else if (sender == mnuAddPath)
                tool = ToolType.addpath;
            else if (sender == mnuJumpSource)
            {
                JumpToSourceDoIt(sender, e);
            }
            else if (sender == mnuEdit)
            {
                CurEditing = mnuJumpSource.Tag as OverlayScope;
            }
        }

        bool PreventContextMenuOpening = false;
        private void canvas1_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            if (PreventContextMenuOpening)
            {
                e.Handled = true;
                PreventContextMenuOpening = false;
                return;
            }

            mnuMove.IsChecked = (tool == ToolType.move);
            mnuAddNode.IsChecked = (tool == ToolType.addvert);
            mnuAddEdge.IsChecked = (tool == ToolType.addedge);
            mnuAddPath.IsChecked = (tool == ToolType.addpath);

            
            IInputElement o = canvas1.InputHitTest(Mouse.GetPosition(canvas1));

            // some commands in the context menu (Jump to source, editing) operate on the object at mouse position
            // when the contextmenu opens. Since this position is lost when clicking the menu item, the object there 
            // has to be stored somewhere -> in the mnuJumpSource.Tag
            if (o is OverlayShape)
            {
                mnuJumpSource.Tag = o;
            }
            else mnuJumpSource.Tag = null;
            mnuJumpSource.IsEnabled = (mnuJumpSource.Tag != null);
            mnuEdit.IsEnabled = (o is OverlayScope);
        }

        /// <summary>
        /// The standard handling of right click is as follows (with this priority): 
        ///   1. The current tool uses the click.
        ///   2. Set the tool to the standrad tool (move)
        ///   3. Deselect the CurEditing item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void canvas1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            // call right down-method in the current tool
            Point mousep = e.GetPosition(canvas1);
            object oo = canvas1.InputHitTest(mousep);
            if (!(oo is OverlayShape))
                oo = null;
            CurrentTool.OnRightMouseButtonDown(oo as OverlayShape, new Point(mousep.X, Height - mousep.Y), e);
            
            // if the tool didn't use the click-> proceed with standard handling
            if (!e.Handled)
            {
                if (tool == ToolType.move)
                {
                    //canvas1.ContextMenu.IsEnabled = true;
                    if (CurEditing != null)
                    {
                        CurEditing = null;
                        PreventContextMenuOpening = true;
                    }
                }
                else
                {
                    tool = ToolType.move;
                    PreventContextMenuOpening = true;
                }
            }
            else 
                PreventContextMenuOpening = true;
        }

    }

    public abstract class OverlayShape : Shape {
        // in upside down coordinates
        public Rect getBB()
        {
            Rect r = new Rect();
            r.X = Canvas.GetLeft(this);
            r.Y = Canvas.GetBottom(this);
            r.Width = Width;
            r.Height = Height;
            return r;
        }
        public PdfOverlay pol;
        /// <summary>
        /// Sets the position of the Overlay Shape (and its children) according to the position of the underlying parseitem
        /// </summary>
        /// <param name="Resolution"></param>
        /// <returns></returns>
        public abstract bool AdjustPosition(double Resolution);
        /// <summary>
        /// Shifts the underlying parseitem by the indicated amount.
        /// </summary>
        /// <param name="RelShift"></param>
        public abstract void ShiftItemRelative(Point RelShift);
        /// <summary>
        /// The underlying ParseItem
        /// </summary>
        public abstract TikzParseItem item { get; }

        public abstract void SetSelectedColor();
        public abstract void SetStdColor();
    }

    public class OverlayScope : OverlayShape
    {
        public List<OverlayShape> children = new List<OverlayShape>();
        public Tikz_Scope tikzitem;
        public override TikzParseItem item { get { return tikzitem; } } 

        /// <summary>
        /// Sets the item's position according to its tikzitem's value
        /// </summary>
        public override bool AdjustPosition(double Resolution)
        {
            Rect r=new Rect(0,0,0,0);
            bool hasone = false;
            foreach (OverlayShape o in children)
            {
                o.AdjustPosition(Resolution);
                Rect rr = o.getBB();
                if (hasone)
                    r.Union(rr);
                else
                {
                    r = rr;
                    hasone = true;
                }
            }
            if (hasone)
            {
                r.Inflate(20, 20);
                //r = new Rect(10, 10, 100, 100);
                Width = r.Width;
                Height = r.Height;
                Canvas.SetLeft(this, r.X);
                Canvas.SetBottom(this, r.Y);
                return true;
            }
            else return false;
        }

        public override void ShiftItemRelative(Point RelShift)
        {
            if (RelShift.X != 0 || RelShift.Y != 0)
            {
                if (tikzitem.options == null)
                {
                    tikzitem.options = new Tikz_Options();
                    tikzitem.options.starttag = "[";
                    tikzitem.options.endtag = "]";
                    tikzitem.AddChild(tikzitem.options, true);
                }
                //Tikz_Options.SetShiftRel(ts, xs, ys);
                tikzitem.options.SetShiftRel(RelShift.X, RelShift.Y);
                tikzitem.UpdateText();  // todo: don't update text of ll children
            }
        }

        public override void SetSelectedColor()
        {
            Stroke = new SolidColorBrush(Properties.Settings.Default.Overlay_ScopeSelColor);
        }
        public override void SetStdColor()
        {
            Stroke = new SolidColorBrush(Properties.Settings.Default.Overlay_ScopeColor);
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

        }


        public OverlayScope()
        {
            SetStdColor(); //os.Stroke = new SolidColorBrush(Color.FromArgb(100, 0, 255, 0));
            StrokeThickness = 10;
            //os.Fill = new SolidColorBrush(Color.FromArgb(100, 0, 255, 0));
        }
    }

    public class OverlayNode : OverlayShape
    {
        public Tikz_XYItem tikzitem;
        public override TikzParseItem item { get { return tikzitem; } } 

        /// <summary>
        /// Sets the item's position according to its tikzitem's value
        /// </summary>
        public override bool AdjustPosition(double Resolution)
        {
            Width = 10;
            Height = 10;

            Point p;
            if (tikzitem.GetAbsPos(out p))
            {
                Point pp = pol.TikzToScreen(p);
                Canvas.SetLeft(this, pp.X - Width / 2);
                Canvas.SetBottom(this, pp.Y - Height / 2);  // not quite ok like this?
                return true;
            }
            else
            {
                //return false;
                throw new Exception("Encountered drawn item without valid coordinates.");
            }
        }

        public override void ShiftItemRelative(Point RelShift)
        {
            Point p;
            if (tikzitem.GetAbsPos(out p))
            {
                tikzitem.SetAbsPos(new Point(p.X + RelShift.X, p.Y + RelShift.Y));
                tikzitem.UpdateText();
            }
            else
                throw new Exception("Noneditable overlay node found");
        }

        public override void SetSelectedColor()
        {
            Stroke = new SolidColorBrush(Properties.Settings.Default.Overlay_CoordSelColor);
        }
        public override void SetStdColor()
        {
            Stroke = new SolidColorBrush(Properties.Settings.Default.Overlay_CoordColor);
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
        /// Draw an X
        /// </summary>
        /// <param name="context"></param>
        private void InternalDrawNodeGeometry(StreamGeometryContext context)
        {
            context.BeginFigure(new Point(0, 0), true, false);
            context.LineTo(new Point(10, 0), false, false);
            context.LineTo(new Point(10, 10), false, false);
            context.LineTo(new Point(0, 10), false, false);

            context.BeginFigure(new Point(0, 0), false, false);
            context.LineTo(new Point(10, 10), true, true);
            //context.LineTo(new Point(10, 0), true, true);
            
            context.BeginFigure(new Point(10, 0), false, false);
            context.LineTo(new Point(0, 10), true, true);
        }

        public OverlayNode()
        {
            Fill = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0)); // necessary?
            SetStdColor();
        }

    }

    // Adorners must subclass the abstract base class Adorner.
    public class ScopeAdorner : Adorner
    {
        // Be sure to call the base class constructor.
        public ScopeAdorner(UIElement adornedElement)
            : base(adornedElement)
        {
        }

        // A common way to implement an adorner's rendering behavior is to override the OnRender
        // method, which is called by the layout system as part of a rendering pass.
        protected override void OnRender(DrawingContext drawingContext)
        {
            Rect adornedElementRect = new Rect(this.AdornedElement.DesiredSize);

            // Some arbitrary drawing implements.
            //Brush renderBrush = Helper.GetHatchBrush();//new SolidColorBrush(Colors.Green);
            //Brush
            //renderBrush.Opacity = 0.2;
            Pen renderPen = new Pen(new SolidColorBrush(Colors.Navy), 1.5);
            renderPen.Brush = Helper.GetHatchBrush();
            double renderRadius = 5.0;
            renderPen.Thickness = renderRadius;
            //renderPen.DashStyle = new DashStyle(

            // Draw a circle at each corner.
            //drawingContext.DrawEllipse(renderBrush, renderPen, adornedElementRect.TopLeft, renderRadius, renderRadius);
            //drawingContext.DrawEllipse(renderBrush, renderPen, adornedElementRect.TopRight, renderRadius, renderRadius);
            //drawingContext.DrawEllipse(renderBrush, renderPen, adornedElementRect.BottomLeft, renderRadius, renderRadius);
            //drawingContext.DrawEllipse(renderBrush, renderPen, adornedElementRect.BottomRight, renderRadius, renderRadius);
            drawingContext.DrawRectangle(null, renderPen, new Rect(adornedElementRect.X-renderRadius, adornedElementRect.Y-renderRadius, 
                            adornedElementRect.Width+2*renderRadius, adornedElementRect.Height+2*renderRadius));
        }
    }

    

}
