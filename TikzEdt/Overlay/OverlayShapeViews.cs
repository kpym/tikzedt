using System.Windows;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows.Documents;
using TikzEdt.Overlay;



namespace TikzEdt
{

    abstract class OverlayShapeView : Shape
    {
        // in upside down coordinates
        public virtual Rect GetBB()
        {
            Rect r = new Rect();
            r.X = Canvas.GetLeft(this);
            r.Y = Canvas.GetBottom(this);
            r.Width = Width;
            r.Height = Height;
            return r;
        }

        public void SetToolTip(string Text)
        {
            ToolTip tip = new ToolTip();
            tip.Content = new TextBlock(new Run(Text));
            this.ToolTip = tip;
        }

        double ParentHeight { get { return (Parent as Canvas).Height; } }
        double ParentWidth { get { return (Parent as Canvas).Width; } }

        public virtual double GetLeft()
        {
            return Canvas.GetLeft(this)+Width/2;
        }

        public virtual double GetBottom()
        {
            return Canvas.GetBottom(this)+Height/2;
        }

        public virtual void SetPosition(double Left, double Bottom, bool Relative = false)
        {
            if (Relative)
            {
                Canvas.SetLeft(this, Canvas.GetLeft(this)+ Left);
                Canvas.SetBottom(this, Canvas.GetBottom(this) + Bottom);
            }
            else
            {
                Canvas.SetLeft(this, Left - Width / 2);
                Canvas.SetBottom(this, Bottom - Height / 2);
            }
        }

    }

    class OverlayNodeView : OverlayShapeView, Overlay.IOverlayShapeView
    {

   /*     public void SetPosition(double left, double bottom)
        {
            Width = 10;
            Height = 10;
            Canvas.SetLeft(this, left - Width / 2);
            Canvas.SetBottom(this, bottom - Height / 2);
        }*/

        public void SetSelColor()
        {
            Stroke = new SolidColorBrush(Properties.Settings.Default.Overlay_CoordSelColor);
        }
        public void SetStdColor()
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
        protected virtual void InternalDrawNodeGeometry(StreamGeometryContext context)
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

        public OverlayNodeView()
        {
            Width = 10;
            Height = 10;
            Fill = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0)); // necessary?
            SetStdColor();
        }
    }

    class OverlayScopeView : OverlayShapeView, Overlay.IOverlayScopeView
    {
        // in upside down coordinates
        public override Rect GetBB()
        {
            Rect r = new Rect();
            r.X = Canvas.GetLeft(this);
            r.Y = Canvas.GetBottom(this);
            r.Width = Width;
            r.Height = Height;
            return r;
        }

        public void SetSelColor()
        {
            Stroke = new SolidColorBrush(Properties.Settings.Default.Overlay_ScopeSelColor);
        }
        public void SetStdColor()
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

        public void SetPosition(double left, double bottom, bool Relative=false)
        {
            if (Relative)
            {
                Canvas.SetLeft(this, Canvas.GetLeft(this) + left);
                Canvas.SetBottom(this, Canvas.GetBottom(this)+bottom);
            }
            else
            {
                Canvas.SetLeft(this, left);
                Canvas.SetBottom(this, bottom );
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

        public OverlayScopeView()
        {
            SetStdColor(); //os.Stroke = new SolidColorBrush(Color.FromArgb(100, 0, 255, 0));
            StrokeThickness = 10;
            //os.Fill = new SolidColorBrush(Color.FromArgb(100, 0, 255, 0));
        }

        public void SetSize(double Width, double Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        public void ShowAdorner()
        {
            AdornerLayer.GetAdornerLayer(this).Add(new ScopeAdorner(this));            
        }

        public void RemoveAdorner()
        {
            // remove adorner
            AdornerLayer al = AdornerLayer.GetAdornerLayer(this);
            if (al != null)
            {
                Adorner[] toRemoveArray = al.GetAdorners(this);
                if (toRemoveArray != null)
                {
                    AdornerLayer.GetAdornerLayer(this).Remove(toRemoveArray[0]);
                }
            }
        }

        public double GetLeft()
        {
            return Canvas.GetLeft(this);
        }

        public double GetBottom()
        {
            return Canvas.GetBottom(this);
        }
    }

    class OverlayCPView : OverlayShapeView, Overlay.IOverlayCPView
    {
        public Line lineToOrigin1 = new Line() { Stroke = Brushes.Gray, StrokeDashArray = new DoubleCollection(new double[] { 4, 4 }) };
        public Line lineToOrigin2 = new Line() { Stroke = Brushes.Gray, StrokeDashArray = new DoubleCollection(new double[] { 4, 4 }) };

        // in upside down coordinates
        public Rect GetBB()
        {
            Rect r = new Rect();
            r.X = Canvas.GetLeft(this);
            r.Y = Canvas.GetBottom(this);
            r.Width = Width;
            r.Height = Height;
            return r;
        }

        protected override Geometry DefiningGeometry
        {
            get
            {
                // Create a StreamGeometry for describing the shape
                EllipseGeometry geometry = new EllipseGeometry();
                geometry.Center = new Point(5, 5);
                geometry.RadiusX = geometry.RadiusY = 5;

                // Freeze the geometry for performance benefits
                geometry.Freeze();

                return geometry;
            }
        }

        public OverlayCPView()
        {
            Width = 10;
            Height = 10;
            Fill = Brushes.Gray;            
            Canvas.SetZIndex(lineToOrigin1, -1);
            Canvas.SetZIndex(lineToOrigin2, -1);
        }

        public void SetOrigin1(double Left, double Bottom)
        {
            Canvas parent = Parent as Canvas;
            if (parent == null)
                return;

            lineToOrigin1.X1 = Canvas.GetLeft(this) - Width/2;
            lineToOrigin1.Y1 = parent.Height - Canvas.GetBottom(this) - Height / 2;

            lineToOrigin1.X2 = Left;
            lineToOrigin1.Y2 = parent.Height - Bottom;

            lineToOrigin1.Visibility = Visibility.Visible;
        }

        public void SetOrigin2(double Left, double Bottom)
        {
            Canvas parent = Parent as Canvas;
            if (parent == null)
                return;

            lineToOrigin2.X1 = Canvas.GetLeft(this) - Width / 2;
            lineToOrigin2.Y1 = parent.Height - Canvas.GetBottom(this) - Height / 2;

            lineToOrigin2.X2 = Left;
            lineToOrigin2.Y2 = parent.Height - Bottom;

            lineToOrigin2.Visibility = Visibility.Visible;
        }

        public void SetPosition(double left, double bottom)
        {
            Width = 10;
            Height = 10;
            Canvas.SetLeft(this, left - Width / 2);
            Canvas.SetBottom(this, bottom - Height / 2);

        }

        public void SetSelColor()
        {
            Stroke = new SolidColorBrush(Properties.Settings.Default.Overlay_CoordSelColor);
        }
        public void SetStdColor()
        {
            Stroke = new SolidColorBrush(Properties.Settings.Default.Overlay_CoordColor);
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
            renderPen.Brush = GetHatchBrush();
            double renderRadius = 5.0;
            renderPen.Thickness = renderRadius;
            //renderPen.DashStyle = new DashStyle(

            // Draw a circle at each corner.
            //drawingContext.DrawEllipse(renderBrush, renderPen, adornedElementRect.TopLeft, renderRadius, renderRadius);
            //drawingContext.DrawEllipse(renderBrush, renderPen, adornedElementRect.TopRight, renderRadius, renderRadius);
            //drawingContext.DrawEllipse(renderBrush, renderPen, adornedElementRect.BottomLeft, renderRadius, renderRadius);
            //drawingContext.DrawEllipse(renderBrush, renderPen, adornedElementRect.BottomRight, renderRadius, renderRadius);
            drawingContext.DrawRectangle(null, renderPen, new Rect(adornedElementRect.X - renderRadius, adornedElementRect.Y - renderRadius,
                            adornedElementRect.Width + 2 * renderRadius, adornedElementRect.Height + 2 * renderRadius));
        }

        public static Brush GetHatchBrush()
        {
            VisualBrush vb = new VisualBrush();

            vb.TileMode = TileMode.Tile;

            vb.Viewport = new Rect(0, 0, 5, 5);
            vb.ViewportUnits = BrushMappingMode.Absolute;

            vb.Viewbox = new Rect(0, 0, 6, 6);
            vb.ViewboxUnits = BrushMappingMode.Absolute;

            Line l = new Line();
            l.X1 = 0; l.X2 = 6; l.Y1 = 6; l.Y2 = 0;
            l.Stroke = Brushes.Black;
            vb.Visual = l;

            return vb;
        }
    }


    class WPFRectangle : IRectangleShape
    {
        Canvas TheCanvas;
        public Rectangle TheRectangle = new Rectangle();
        public WPFRectangle(Canvas TheCanvas)
        {
            this.TheCanvas = TheCanvas;
        }

        public bool Visible
        {
            get
            {
                return TheRectangle.Visibility == Visibility.Visible;
            }
            set
            {
                if (value)
                {
                    if (!TheCanvas.Children.Contains(TheRectangle))
                        TheCanvas.Children.Add(TheRectangle);
                    Canvas.SetZIndex(TheRectangle, TheCanvas.Children.Count);
                    TheRectangle.Visibility = Visibility.Visible;
                }
                else
                    TheRectangle.Visibility = Visibility.Collapsed;
            }
        }

        public Rect GetBB()
        {
            return System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(TheRectangle);
        }

        public void SetPosition(double Top, double Left, double Width, double Height)
        {
            Canvas.SetTop(TheRectangle, Top);
            Canvas.SetLeft(TheRectangle, Left);
            TheRectangle.Width = Width;
            TheRectangle.Height = Height;
        }
    }

}