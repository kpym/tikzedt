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
            // mockup
            canvas1.Children.Clear();
            foreach (TikzParseItem t in ParseTree.Children)
                if (t is Tikz_Node)
                {
                    Tikz_Node tt = t as Tikz_Node;
                    Ellipse el = new Ellipse();
                    el.Stroke = Brushes.Red;
                    el.Fill = Brushes.Red;
                    //OverlayItem el = new OverlayItem();
                    el.Width = 10;
                    el.Height = 10;
                    Canvas.SetLeft(el, Resolution*tt.x - el.Width/2);
                    Canvas.SetBottom(el, Resolution*tt.y - el.Height/2);
                    canvas1.Children.Add(el);
                }
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

}
