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
            set { _parsetree = value; RedrawObjects(); }
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

        List<Control> objects = new List<Control>();

        public PdfOverlay()
        {
            InitializeComponent();
        }

        public void RedrawObjects()
        {
            canvas1.Children.Clear();

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
                OverlayNode el = new OverlayNode();
                el.tikzitem = tpi as Tikz_XYItem;
                //Ellipse el = new Ellipse();                                   
                el.Stroke = Brushes.Red;
                el.Fill = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));

                el.Width = 10;
                el.Height = 10;

                // todo: add trafo
                Canvas.SetLeft(el, Resolution * el.tikzitem.x - el.Width / 2);
                Canvas.SetBottom(el, Resolution * el.tikzitem.y - el.Height / 2);  // not quite ok like this???
                canvas1.Children.Add(el);

                bbg.Add(new Rect(Canvas.GetLeft(el), Canvas.GetTop(el), el.Width, el.Height));
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
            if (e.LeftButton == MouseButtonState.Pressed && curDragged != null)
            {
                Canvas.SetLeft(curDragged, e.GetPosition(canvas1).X - DragOrigin.X);
                Canvas.SetTop(curDragged, e.GetPosition(canvas1).Y - DragOrigin.Y);
                Canvas.SetBottom(curDragged, Canvas.GetTop(curDragged) + 10); //hack
            }
        }

        private void canvas1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            // adjust position of dragged item (in parsetree) // hack
            if (curDragged!= null)
            {
                Point pp = new Point((Canvas.GetLeft(curDragged)+5) / Resolution, (Height-Canvas.GetTop(curDragged)-5) / Resolution);
                curDragged.tikzitem.SetPosition(pp);
                curDragged.tikzitem.UpdateText();
                curDragged = null;

                OnModified.Invoke();
            }
        }
    }

    public class OverlayNode : Shape
    {
        public Tikz_XYItem tikzitem;

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
