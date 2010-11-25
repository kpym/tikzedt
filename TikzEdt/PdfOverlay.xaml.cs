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
            foreach (TikzParseItem t in ParseTree.Children)
                if (t is Tikz_Picture)
                    foreach (TikzParseItem tt in (t as Tikz_Picture).Children)
                        if (tt is Tikz_Path)
                            foreach (TikzParseItem ttt in (tt as Tikz_Path).Children)
                                if (ttt is Tikz_XYItem)
                                {
                                    Tikz_XYItem tn = ttt as Tikz_XYItem;
                                    //Ellipse el = new Ellipse();
                                    OverlayNode el = new OverlayNode();
                                    el.Stroke = Brushes.Red;
                                    el.Fill = Brushes.Red;
                    
                                    el.Width = 10;
                                    el.Height = 10;
                                    Canvas.SetLeft(el, Resolution*tn.x - el.Width/2);
                                    Canvas.SetBottom(el, Resolution*tn.y - el.Height/2);
                                    canvas1.Children.Add(el);
                                }

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

        IInputElement o;
        Point p;
        private void canvas1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            o = canvas1.InputHitTest(e.GetPosition(canvas1));
            p = e.GetPosition(o);
            //MessageBox.Show(o.ToString());

        }

        private void canvas1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Canvas.SetLeft((UIElement) o, e.GetPosition(canvas1).X - p.X);
                Canvas.SetTop((UIElement) o, e.GetPosition(canvas1).Y - p.X);
            }
        }
    }

    public class OverlayNode : Shape
    {
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
            context.LineTo(new Point(10, 10), true, true);
            //context.LineTo(new Point(10, 0), true, true);
            
            context.BeginFigure(new Point(10, 0), false, false);
            context.LineTo(new Point(0, 10), true, true);
        }



    }

}
