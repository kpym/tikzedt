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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TikzEdt
{
    /// <summary>
    /// Interaction logic for PdfOverlay.xaml
    /// </summary>
    public partial class PdfOverlay : UserControl
    {

        public delegate void ModifiedEventHandler();
        /// <summary>
        /// This event is called whenever the picture gets modified.
        /// For example, in the handler one should update the code listing
        /// </summary>
        public event ModifiedEventHandler OnModified;

        Tikz_ParseTree _parsetree;
        /// <summary>
        /// The Parse tree currently being displayed is stored in this property.
        /// </summary>
        public Tikz_ParseTree ParseTree
        {
            get { return _parsetree; }
            set { curSel = null; curDragged = null; _parsetree = value; RedrawObjects(); }
        }

        private double lResolution = Consts.ptspertikzunit;
        public double Resolution
        {
            get { return lResolution; }
            set
            {
                if (value > 0)
                    lResolution = value;
            }
        }

        public enum ToolType { move, addvert, addedge, addpath }
        ToolType _tool=ToolType.move;
        public ToolType tool
        {
            get { return _tool; }
            set { _tool = value; }
        }

        public RasterControl rasterizer;

        //List<Control> objects = new List<Control>();

        public PdfOverlay()
        {
            InitializeComponent();
        }

        public void RedrawObjects()
        {
            canvas1.Children.Clear();
            //curDragged = null;
            curSel = null;
            if (ParseTree == null)
                return; // nothing to display

            // set render transform
            //canvas1.RenderTransform

            DrawObject(ParseTree);

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

        public Rect DrawObject(TikzParseItem tpi)
        {
            BBGatherer bbg = new BBGatherer();
            if (tpi is TikzContainerParseItem)
            {
                foreach (TikzParseItem t in (tpi as TikzContainerParseItem).Children)
                    bbg.Add(DrawObject(t));
            }
            if (tpi is Tikz_Scope)
            {
                // draw a rectangle 
                Rectangle r = new Rectangle();
                r.Stroke = Brushes.Yellow;
                Rect rr = bbg.GetRect(10);
                r.Width = rr.Width;
                r.Height = rr.Height;
                Canvas.SetTop(r, rr.Y);
                Canvas.SetLeft(r, rr.X);
                canvas1.Children.Add(r);
                bbg.Add(rr);
            }
            if (tpi is Tikz_XYItem)
            {
                if (!(tpi is Tikz_Coord && (tpi as Tikz_Coord).type == Tikz_CoordType.Named)
                    && !(tpi is Tikz_Node && (tpi as Tikz_Node).coord == null) // TODO: yet to decide whether to draw such things
                    )
                {
                    OverlayNode el = new OverlayNode();
                    el.tikzitem = tpi as Tikz_XYItem;
                    //Ellipse el = new Ellipse();                                   
                    el.Stroke = Brushes.Red;
                    el.Fill = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
                    el.AdjustPosition(Resolution);

                    canvas1.Children.Add(el);

                    bbg.Add(new Rect(Canvas.GetLeft(el), Canvas.GetTop(el), el.Width, el.Height));
                }
            }

            return bbg.GetRect(0);
        }

        OverlayNode curDragged;
        Point DragOrigin; // relative to the currently dragged object
        private void canvas1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            IInputElement o = canvas1.InputHitTest(e.GetPosition(canvas1));
            if (o is OverlayNode)
            {
                curDragged = (OverlayNode) canvas1.InputHitTest(e.GetPosition(canvas1));
                DragOrigin = e.GetPosition(o);
                //MessageBox.Show(o.ToString());
            }

        }

        private void canvas1_MouseMove(object sender, MouseEventArgs e)
        {
            if (tool == ToolType.move && e.LeftButton == MouseButtonState.Pressed && curDragged != null)
            {
                Point p = new Point(e.GetPosition(canvas1).X - DragOrigin.X + 5, Height- (e.GetPosition(canvas1).Y - DragOrigin.Y)-5);
                p = rasterizer.RasterizePixel(p);
                Canvas.SetLeft(curDragged, p.X-5);
                //Canvas.SetTop(curDragged, e.GetPosition(canvas1).Y - DragOrigin.Y);
                //Canvas.SetBottom(curDragged, Canvas.GetTop(curDragged) + 10); //hack

                Canvas.SetBottom(curDragged, p.Y-5); //hack
            }
        }

        private void canvas1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            // adjust position of dragged item (in parsetree) // hack
            if (tool == ToolType.move && curDragged != null)
            {
                Point pp = new Point((Canvas.GetLeft(curDragged)+5) / Resolution, (Canvas.GetBottom(curDragged)+5) / Resolution);
                curDragged.tikzitem.SetAbsPos(pp);
                curDragged.tikzitem.UpdateText();
                // update all other item's positions
                foreach (IInputElement o in canvas1.Children)
                {
                    if (o is OverlayNode)
                        (o as OverlayNode).AdjustPosition(Resolution);
                }
                curDragged = null;

                OnModified.Invoke();
            }
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
        private void canvas1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (tool == ToolType.addvert)
            {
                Point p = new Point(e.GetPosition(canvas1).X, Height - e.GetPosition(canvas1).Y );                
                p = rasterizer.RasterizePixel(p);

                // find next tikzpicture and add
                Tikz_Picture tpict = ParseTree.GetTikzPicture();
                if (tpict != null)
                {
                    Tikz_Node tn = new Tikz_Node();
                    tn.label = "?";
                    tn.coord = new Tikz_Coord();
                    

                    Tikz_Path tp = new Tikz_Path();
                    tp.starttag = @"\node ";
                    tp.endtag = ";";
                    
                    tp.AddChild(tn);
                    tpict.AddChild(tp);
                    tpict.AddChild(new Tikz_Something("\r\n"));

                    // do it here since the coordinate calculation needs the parents' coord. transform
                    tn.SetAbsPos(new Point(p.X / Resolution, p.Y / Resolution)); //hack

                    //tn.UpdateText();
                    tp.UpdateText();
                    //tpict.UpdateText();

                    RedrawObjects();
                    OnModified.Invoke();
                }
            }
            else if (tool == ToolType.addedge)
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
                    curSel=n;
                    return;
                }

                // add an edge curSel to n 
                // find tikzpicture
                Tikz_Picture tpict = ParseTree.GetTikzPicture();
                if (tpict != null)
                {
                    // make sure both nodes involved are nodes
                    if (!(curSel.tikzitem is Tikz_Node) || !(n.tikzitem is Tikz_Node))
                        return; // hack
                    Tikz_Node t1 = curSel.tikzitem as Tikz_Node, t2 = n.tikzitem as Tikz_Node;

                    Tikz_Path tp = new Tikz_Path();
                    tp.starttag = @"\draw ";
                    tp.endtag = ";";

                    Tikz_Coord tc1 = new Tikz_Coord();
                    tc1.type = Tikz_CoordType.Named;
                    Tikz_Coord tc2 = new Tikz_Coord();
                    tc2.type = Tikz_CoordType.Named;

                    tp.AddChild(tc1);
                    tp.AddChild(new Tikz_Something(" edge "));
                    tp.AddChild(tc2);
                    tpict.AddChild(tp);
                    tpict.AddChild(new Tikz_Something("\r\n"));

                    // make sure both nodes have names
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
                    tp.UpdateText();
                    //tpict.UpdateText();

                    //RedrawObjects();
                    OnModified.Invoke();
                }

            }
        }
    }

    public class OverlayNode : Shape
    {
        public Tikz_XYItem tikzitem;

        /// <summary>
        /// Sets the item's position according to its tikzitem's value
        /// </summary>
        public void AdjustPosition(double Resolution)
        {
            Width = 10;
            Height = 10;

            Point p = tikzitem.GetAbsPos();
            Canvas.SetLeft(this, Resolution * p.X - Width / 2);
            Canvas.SetBottom(this, Resolution * p.Y - Height / 2);  // not quite ok like this?
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

}
