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
    public partial class PdfOverlay : UserControl
    {

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
        /// <summary>
        /// Called after group of modifiactions has been done.
        /// See BeginModify.
        /// </summary>
        public event NoArgsEventHandler EndModify;
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
        public event CallbackEventHandler TryCreateNew;
        /// <summary>
        /// This event is called when user selectes Jump To Source on an Overlay item.
        /// The parameter sender will contain the TikzParseItem the user wants to jump to.
        /// (Call its StartPosition() method to determine the text offset.)
        /// </summary>
        public event NoArgsEventHandler JumpToSource;

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

        Tikz_ParseTree _parsetree;
        /// <summary>
        /// The Parse tree currently being displayed is stored in this property.
        /// </summary>
        public Tikz_ParseTree ParseTree
        {
            get { return _parsetree; }
            private set 
            {
                if (_parsetree != null)
                    _parsetree.TextChanged -= new Tikz_ParseTree.TextChangedHandler(_parsetree_TextChanged);
                _parsetree = value;
                curAddTo = null;
                if (_parsetree != null)
                    _parsetree.TextChanged += new Tikz_ParseTree.TextChangedHandler(_parsetree_TextChanged);
            }
        }

        void _parsetree_TextChanged(TikzParseItem sender, string oldtext)
        {
            if (OnModified != null)
                OnModified(sender, oldtext);
        }

        private double lResolution = Consts.ptspertikzunit;
        public double Resolution
        {
            get { return lResolution; }
            set
            {
                if (value > 0)
                {
                    lResolution = value;
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

        List<OverLayShape> TopLevelItems;

        public enum ToolType { move, addvert, addedge, addpath }
        ToolType _tool=ToolType.move;
        public ToolType tool
        {
            get { return _tool; }
            set {
                ToolType old = _tool;
                _tool = value;
                switch (tool)
                {
                    case ToolType.move:                    
                        Cursor = Cursors.Arrow;
                        break;
                    case ToolType.addvert:
                    case ToolType.addpath:
                        Cursor = Cursors.Cross;
                        break;
                    case ToolType.addedge:
                        Cursor = Cursors.UpArrow;
                        break;
                }
                if (old != _tool && ToolChanged != null)
                    ToolChanged(this);
            }
        }

        public RasterControl rasterizer;

        //List<Control> objects = new List<Control>();

        public PdfOverlay()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Tries to display a ring around the object at text position
        /// offset.
        /// </summary>
        /// <param name="offset"></param>
        public void MarkObjectAt(int offset)
        {
            OverLayShape ols = ObjectFromOffset(offset, TopLevelItems);
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
                Storyboard anim = (Storyboard) FindResource( "MarkerAnimation" ); 
                anim.Begin( this );
                MarkerEllipse.Visibility = System.Windows.Visibility.Visible;
            }
        }

        public OverLayShape ObjectFromOffset(int offset, List<OverLayShape> bag)
        {
            foreach (OverLayShape ols in bag)
            {
                if (ols.item.StartPosition() <= offset && ols.item.StartPosition() + ols.item.ToString().Length > offset)
                {
                    // check if there is a child that fits better
                    if (ols is OverlayScope)
                    {
                        OverLayShape olsinner = ObjectFromOffset(offset, (ols as OverlayScope).children);
                        if (olsinner != null)
                            return olsinner;
                    }
                    return ols;
                }
            }
            return null;
        }

        public void SetParseTree(Tikz_ParseTree t, Rect tBB)
        {
            BB = tBB;
            ParseTree = t;
            curSel = null; curDragged = null;
            Resolution = Resolution; // to recalc size
            RedrawObjects();
        }

        public void AdjustPositions()
        {
            if (TopLevelItems != null)
                foreach (OverLayShape o in TopLevelItems)
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
            curSel = null;
            CurEditing = null;
            ParseTree = null;
            TopLevelItems = new List<OverLayShape>();
        }
        public void RedrawObjects()
        {
            canvas1.Children.Clear();
            curSel = null;
            CurEditing = null;           
            TopLevelItems = new List<OverLayShape>();

            //curDragged = null;
            
            if (ParseTree == null)
                return; // nothing to display

            // set render transform
            //canvas1.RenderTransform
            
            DrawObject(ParseTree, TopLevelItems);

          /*  foreach (TikzParseItem t in ParseTree.Children)
                if (t is Tikz_Picture)
                    foreach (TikzParseItem tt in (t as Tikz_Picture).Children)
                        if (tt is Tikz_Path)
                            foreach (TikzParseItem ttt in (tt as Tikz_Path).Children)
                                if (ttt is Tikz_XYItem)
                                {
                                    OverlayNode el = new OverlayNode();
                                    el.tikzitem = ttt as Tikz_XYItem;
                                    //Ellipse el = new Ellipse();                                   
                                    el.Stroke = Brushes.Red;
                                    el.Fill = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
                    
                                    el.Width = 10;
                                    el.Height = 10;
                                    Canvas.SetLeft(el, Resolution * el.tikzitem.x - el.Width / 2);
                                    Canvas.SetBottom(el, Resolution * el.tikzitem.y - el.Height / 2);  // not quite ok like this???
                                    canvas1.Children.Add(el);
                                }
           * */

            // test 
            /*
            OverlayNode ell = new OverlayNode();
            ell.Stroke = Brushes.Red;
            ell.Fill = Brushes.Red;

            ell.Width = 10;
            ell.Height = 10;
            Canvas.SetLeft(ell, 100);
            Canvas.SetBottom(ell, 100);
            canvas1.Children.Add(ell); */
        }

        public void DrawObject(TikzParseItem tpi, List<OverLayShape> bag)
        {
            //BBGatherer bbg = new BBGatherer();
            if (bag == null)
                bag = new List<OverLayShape>();  // dummy, it is not used
            if (tpi is Tikz_Scope)
            {
                OverlayScope os = new OverlayScope();
                os.pol = this;
                os.tikzitem = tpi as Tikz_Scope;
                foreach (TikzParseItem t in (tpi as TikzContainerParseItem).Children)
                    DrawObject(t, os.children);
                bag.Add(os);
                os.Stroke = new SolidColorBrush(Color.FromArgb(100, 0, 255, 0));
                os.StrokeThickness = 10;
                //os.Fill = new SolidColorBrush(Color.FromArgb(100, 0, 255, 0));
                os.AdjustPosition(Resolution);
                canvas1.Children.Add(os);
            }
            else if (tpi is TikzContainerParseItem)
            {
                foreach (TikzParseItem t in (tpi as TikzContainerParseItem).Children)            
                    DrawObject(t, bag);
            }
            if (tpi is Tikz_XYItem)
            {
                if (!(tpi is Tikz_Coord && (tpi as Tikz_Coord).type == Tikz_CoordType.Named)
                    && !(tpi is Tikz_Node && (tpi as Tikz_Node).coord == null) // TODO: yet to decide whether to draw such things
                    )
                {
                    OverlayNode el = new OverlayNode();
                    el.pol = this;
                    el.tikzitem = tpi as Tikz_XYItem;
                    //Ellipse el = new Ellipse();                                   
                    el.Stroke = Brushes.Red;
                    el.Fill = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
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
                string simpleEdge_RegexString = @"[ \t\s]*\\draw.*\((?<start>.*)\).*\((?<end>.*)\).*";
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
                        double x = (StartNode.GetAbsPos().X + EndNode.GetAbsPos().X) / 2;
                        double y = (StartNode.GetAbsPos().Y + EndNode.GetAbsPos().Y) / 2;

                        //draw an arrow at this pos.
                        //(new Point(x, y));
                        //and when clicked, jump to AvalonEdit at position tpi.StartPosition                        
                    }

                }                
            }

        }

        OverLayShape curDragged;
        Point DragOrigin; // relative to the currently dragged object
        Point DragOriginC; // Mouse position on Canvas when started dragging
        Point DragOriginO; // bottom left of dragged object

        OverlayScope _CurEditing;
        OverlayScope CurEditing
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
            }
        }

        private void canvas1_MouseDown(object sender, MouseButtonEventArgs e)
        {
        

        }

        private void canvas1_MouseMove(object sender, MouseEventArgs e)
        {
            Point p;
            
                if (curDragged is OverlayScope)
                {
                    p = new Point(e.GetPosition(canvas1).X - DragOriginC.X, e.GetPosition(canvas1).Y - DragOriginC.Y);
                    p = rasterizer.RasterizePixel(p);

                    if (tool == ToolType.move && e.LeftButton == MouseButtonState.Pressed && curDragged != null)
                    {
                        Canvas.SetLeft(curDragged, DragOriginO.X + p.X);
                        Canvas.SetBottom(curDragged, DragOriginO.Y - p.Y); //hack
                    }
                }
                else
                {
                    p = new Point(e.GetPosition(canvas1).X - DragOrigin.X + 5, Height - (e.GetPosition(canvas1).Y - DragOrigin.Y) - 5);
                    p = rasterizer.RasterizePixel(p);

                    if (tool == ToolType.move && e.LeftButton == MouseButtonState.Pressed && curDragged != null)
                    {
                        Canvas.SetLeft(curDragged, p.X - curDragged.Width / 2);
                        //Canvas.SetTop(curDragged, e.GetPosition(canvas1).Y - DragOrigin.Y);
                        //Canvas.SetBottom(curDragged, Canvas.GetTop(curDragged) + 10); //hack

                        Canvas.SetBottom(curDragged, p.Y - curDragged.Height / 2); //hack
                    }
                }
            
            p.Y /= Resolution;
            p.X /= Resolution;
            p.X += _BB.X;
            p.Y += _BB.Y;
            
           
            String s = "(" + String.Format("{0:f1}", p.X) + "; "+ String.Format("{0:f1}", p.Y) + ")";
            ((MainWindow)Application.Current.Windows[0]).AddStatusBarCoordinate(s);
            
        }

        private void canvas1_MouseUp(object sender, MouseButtonEventArgs e)
        {
 
        }

        OverlayNode _curSel;
        OverlayNode curSel
        {
            get { return _curSel; }
            set
            {
                if (_curSel != null)
                    _curSel.Stroke = Brushes.Red;
                _curSel = value;
                if (_curSel != null)
                    _curSel.Stroke = Brushes.Gold;
            }
        }

        /// <summary>
        /// The displayed raster changes depending on the currently selected object.
        /// This method sets the raster, so as to fit the coordinate transformation at o.
        /// There are two cases:    (i) (IsParent=false) o is the object being modified, so the relevant coordinate trsf. is that at o
        ///                         (i) (IsParent=true)  o is a parent object to which items are added. 
        ///                             In this case the relevant transf. is that at the end of o, since new items are inserted at the end.
        /// </summary>
        /// <param name="o">The object. If null, it is taken to be the tikzpicture.</param>
        /// <param name="IsParent">Indicates whether object is to be moved itself, or children added.</param>
        void SetCorrectRaster(OverLayShape o, bool IsParent=false)
        {
            if (ParseTree == null)
                return;
            if (o == null)
            {
                Tikz_Picture tp = ParseTree.GetTikzPicture();
                if (tp != null)
                {
                    TikzMatrix M = tp.GetCurrentTransformAt(null);
                    rasterizer.CoordinateTransform = M;
                    //rasterizer.RasterOrigin = M.Transform(new Point(0, 0));
                    //rasterizer.RasterScale = M.m[1, 1];
                    rasterizer.IsCartesian = true;
                }
            }
            if (o is OverlayScope)
            {
                Tikz_Scope ts = (o as OverlayScope).tikzitem;
                TikzMatrix M;
                if (IsParent)
                    M = ts.GetCurrentTransformAt(null); // todo
                else
                    M = ts.parent.GetCurrentTransformAt(ts);
                rasterizer.CoordinateTransform = M;
                //rasterizer.RasterOrigin = M.Transform(new Point(0, 0));
                //rasterizer.RasterScale = M.m[1, 1];
                rasterizer.IsCartesian = true;
            }
            else if (o is OverlayNode)
            {
                Tikz_XYItem t = (o as OverlayNode).tikzitem;
                Point offset = t.GetAbsPos(true);
                TikzMatrix M = t.parent.GetCurrentTransformAt(t).CloneIt();
                M.m[0, 2] = offset.X;
                M.m[1, 2] = offset.Y;
                //rasterizer.RasterScale = M.m[1, 1];
                rasterizer.CoordinateTransform = M;
                rasterizer.IsCartesian = !(t.IsPolar());
            }
            else
                rasterizer.IsCartesian = true;  // should not get here
        }

        //create a new CurAddTo (even though their already might be one)
        //(needed for edge tool)
        bool AddNewCurAddTo()
        {
            // find tikzpicture
            Tikz_Picture tpict = ParseTree.GetTikzPicture();
            if (tpict == null)
                return false;


            Tikz_Path tp = new Tikz_Path();
            tp.starttag = @"\draw";
            tp.endtag = ";";
            if (EdgeStyle != "")
            {
                Tikz_Options topt = new Tikz_Options();
                topt.starttag = "[";
                topt.endtag = "]";
                Tikz_Option to = new Tikz_Option();
                to.type = Tikz_OptionType.key;
                to.key = EdgeStyle;

                topt.AddOption(to);
                tp.AddChild(topt);
                tp.options = topt;
            }
            if (CurEditing != null)
            {
                CurEditing.tikzitem.AddChild(tp);
                CurEditing.tikzitem.AddChild(new Tikz_Something("\r\n"));
            }
            else
            {
                tpict.AddChild(tp);
                tpict.AddChild(new Tikz_Something("\r\n"));
            }
            curAddTo = tp;

            return true;
        }
        bool EnsureCurAddToExists(out bool created)
        {
            created = false;            
            // find tikzpicture
            Tikz_Picture tpict = ParseTree.GetTikzPicture();
            if (tpict == null)
                return false;

            if (curAddTo == null || !(curAddTo is Tikz_Path))
            {
                created = AddNewCurAddTo();
            }

            return true;
        }

        void AddToDisplayTree(TikzParseItem tpi)
        {
            List<OverLayShape> l = new List<OverLayShape>();
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

        TikzContainerParseItem curAddTo;
        private void canvas1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Try to create a new ParseTree
            if (ParseTree == null)
            {
                if (TryCreateNew != null && ( tool == ToolType.addpath || tool == ToolType.addvert) )
                {
                    bool lret;
                    TryCreateNew(this, out lret);
                    if (lret)
                    {
                        // create a new parsetree
                        Tikz_ParseTree t = new Tikz_ParseTree();
                        Tikz_Picture tp = new Tikz_Picture();
                        tp.starttag = "\\begin{tikzpicture}";
                        tp.AddChild(new Tikz_Something("\r\n"));
                        tp.endtag = "\\end{tikzpicture}";                        

                        if (BeginModify != null)
                            BeginModify(this);

                        ParseTree = t;
                        t.AddChild(tp);
                        tp.UpdateText();

                        if (EndModify != null)
                            EndModify(this);

                    }
                    else return;
                } else  return;
            }

            if (tool == ToolType.move)
            #region move
            {
                IInputElement o = canvas1.InputHitTest(e.GetPosition(canvas1));

                if (e.ClickCount == 2 && (o is OverlayScope)) // Select for editing
                {
                    CurEditing = o as OverlayScope;
                    SetCorrectRaster(CurEditing); // todo: correct? ,true
                }
                else if (o is OverLayShape)
                {
                    curDragged = (OverLayShape)o;
                    DragOrigin = e.GetPosition(o);
                    DragOriginC = e.GetPosition(canvas1);
                    DragOriginO = new Point(Canvas.GetLeft(curDragged), Canvas.GetBottom(curDragged));
                    //MessageBox.Show(o.ToString());

                    // adjust raster origin/scale/polar/cartesian
                    SetCorrectRaster(curDragged);
                }
            }
            #endregion
            else if (tool == ToolType.addvert)
            #region addvert
            {
                if (BeginModify != null)
                    BeginModify(this);

                SetCorrectRaster(CurEditing, true);

                Point p = new Point(e.GetPosition(canvas1).X, Height - e.GetPosition(canvas1).Y);
                p = rasterizer.RasterizePixelToTikz(p);

                // find next tikzpicture and add
                Tikz_Picture tpict = ParseTree.GetTikzPicture();
                if (tpict != null)
                {
                    Tikz_Node tn = new Tikz_Node();
                    tn.label = "?";
                    tn.coord = new Tikz_Coord();
                    if (NodeStyle != "")
                        tn.options = "[" + NodeStyle + "]";

                    Tikz_Path tp = new Tikz_Path();
                    tp.starttag = @"\node ";
                    tp.endtag = ";";

                    tp.AddChild(tn);
                    if (CurEditing != null)
                    {
                        CurEditing.tikzitem.AddChild(tp);
                        CurEditing.tikzitem.AddChild(new Tikz_Something("\r\n"));
                    }
                    else
                    {
                        tpict.AddChild(tp);
                        tpict.AddChild(new Tikz_Something("\r\n"));
                    }
                    // do it here since the coordinate calculation needs the parents' coord. transform
                    tn.SetAbsPos(new Point(p.X, p.Y )); //hack

                    //tn.UpdateText();
                    tp.UpdateText();
                    //tpict.UpdateText();

                    //RedrawObjects();
                    AddToDisplayTree(tp);
                }
                if (EndModify != null)
                    EndModify(this);
            }
            #endregion
            else if (tool == ToolType.addedge)
            #region addedge
            {

                IInputElement o = canvas1.InputHitTest(e.GetPosition(canvas1));
                if (!(o is OverlayNode))
                {
                    curSel = null;
                    return;
                }
                OverlayNode n = o as OverlayNode;

                if (curSel == null)
                {
                    curSel = n;
                    return;
                }

                // make sure both nodes involved are nodes
                if (!(curSel.tikzitem is Tikz_Node) || !(n.tikzitem is Tikz_Node))
                {
                    String which = ""; String verb = "is";
                    if (!(curSel.tikzitem is Tikz_Node) && !(n.tikzitem is Tikz_Node))
                    {which = "Both"; verb = "are"; }
                    else if (!(curSel.tikzitem is Tikz_Node))
                        which = "The first";
                    else if (!(n.tikzitem is Tikz_Node))
                        which = "The second";
                    AddStatusLine(which + " of the selected coordinates "+verb+" not a node (i.e. not defined with \\node but rather with \\draw or \\path)", true);
                    curSel = null;
                    return; // hack
                }

                //the return from above must not interfere with BeginModify()
                if (BeginModify != null)
                    BeginModify(this);   

                // add an edge curSel to n
                //bool lcreated;
                //if (EnsureCurAddToExists(out lcreated))

                //always create new \draw command. otherwise it can happen that the \draw-command
                //is above the \node-definition which causes an error while compiling the latex code.
                if(AddNewCurAddTo())
                {

                    Tikz_Node t1 = curSel.tikzitem as Tikz_Node, t2 = n.tikzitem as Tikz_Node;

                    Tikz_Coord tc1 = new Tikz_Coord();
                    tc1.type = Tikz_CoordType.Named;
                    Tikz_Coord tc2 = new Tikz_Coord();
                    tc2.type = Tikz_CoordType.Named;

                    curAddTo.AddChild(new Tikz_Something(" "));
                    curAddTo.AddChild(tc1);
                    curAddTo.AddChild(new Tikz_Something(" edge "));
                    curAddTo.AddChild(tc2);
                    //tpict.AddChild(tp);                    

                    // make sure both nodes have names
                    Tikz_Picture tpict = ParseTree.GetTikzPicture();
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
                if (EndModify != null)
                    EndModify(this);
            }
            #endregion
            else if (tool == ToolType.addpath)
            #region addpath
            {
                if (BeginModify != null)
                    BeginModify(this);
                
                SetCorrectRaster(CurEditing); // todo: correct???

                Point p = new Point(e.GetPosition(canvas1).X, Height - e.GetPosition(canvas1).Y);
                p = rasterizer.RasterizePixelToTikz(p);

                // find next tikzpicture and add
                bool lcreated;
                if (EnsureCurAddToExists(out lcreated))
                {

                    if (!lcreated)
                    {
                        // add an edge
                        curAddTo.AddChild(new Tikz_Something(" -- "));
                    }

                    // create new coordinate
                    Tikz_Coord tc = new Tikz_Coord();
                    curAddTo.AddChild(tc);

                    // do it here since the coordinate calculation needs the parents' coord. transform
                    tc.SetAbsPos(new Point(p.X, p.Y)); //hack

                    //tn.UpdateText();
                    curAddTo.UpdateText();
                    //tpict.UpdateText();

                    //RedrawObjects();
                    AddToDisplayTree(tc);
                }
                if (EndModify != null)
                    EndModify(this);
            }
            #endregion
        }

        private void UserControl_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void canvas1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // adjust position of dragged item (in parsetree) // hack
            if (tool == ToolType.move && curDragged != null)
            {
                if (BeginModify != null)
                    BeginModify(this);
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

                    if (xs != 0 || ys != 0)
                    {
                        Tikz_Scope ts = (curDragged as OverlayScope).tikzitem;
                        if (ts.options == null)
                        {
                            ts.options = new Tikz_Options();
                            ts.AddChild(ts.options, true);
                        }
                        //Tikz_Options.SetShiftRel(ts, xs, ys);
                        ts.options.SetShiftRel(xs, ys);
                        ts.UpdateText();
                    }
                }
                // update all other item's positions
                foreach (IInputElement o in canvas1.Children)
                {
                    if (o is OverLayShape)
                        (o as OverLayShape).AdjustPosition(Resolution);
                }
                curDragged = null;

                //if (OnModified != null)
                //    OnModified.Invoke();
                if (EndModify != null)
                    EndModify(this);
            }
        }

        private void ContextMenu_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {

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
                if (o is OverLayShape)
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
            if (o is OverLayShape)
            {
                mnuJumpSource.Tag = o;
            }
            else mnuJumpSource.Tag = null;
            mnuJumpSource.IsEnabled = (mnuJumpSource.Tag != null);
            mnuEdit.IsEnabled = (o is OverlayScope);
        }

        private void canvas1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
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
                curAddTo = null;
                PreventContextMenuOpening = true;
            }
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

        /// <summary>
        /// Helper method for optional output PdflatexOutputParser has to say.
        /// </summary>
        /// <param name="text">what is to say</param>
        /// <param name="lError">defines it an error</param>
        private void AddStatusLine(string text, bool lError = false)
        {
            ((MainWindow)Application.Current.Windows[0]).AddStatusLine(text, lError);
        }
    }

    public abstract class OverLayShape : Shape {
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
        public abstract void AdjustPosition(double Resolution);
        public abstract TikzParseItem item { get; }
    }

    public class OverlayScope : OverLayShape
    {
        public List<OverLayShape> children = new List<OverLayShape>();
        public Tikz_Scope tikzitem;
        public override TikzParseItem item { get { return tikzitem; } } 

        /// <summary>
        /// Sets the item's position according to its tikzitem's value
        /// </summary>
        public override void AdjustPosition(double Resolution)
        {
            Rect r=new Rect(0,0,0,0);
            bool hasone = false;
            foreach (OverLayShape o in children)
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
                r.Inflate(20,20);
                //r = new Rect(10, 10, 100, 100);
                Width = r.Width;
                Height = r.Height;
                Canvas.SetLeft(this, r.X);
                Canvas.SetBottom(this, r.Y);
            }
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

    }

    public class OverlayNode : OverLayShape
    {
        public Tikz_XYItem tikzitem;
        public override TikzParseItem item { get { return tikzitem; } } 

        /// <summary>
        /// Sets the item's position according to its tikzitem's value
        /// </summary>
        public override void AdjustPosition(double Resolution)
        {
            Width = 10;
            Height = 10;

            Point p = tikzitem.GetAbsPos();
            Point pp = pol.TikzToScreen(p);
            Canvas.SetLeft(this, pp.X - Width / 2);
            Canvas.SetBottom(this, pp.Y - Height / 2);  // not quite ok like this?
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
