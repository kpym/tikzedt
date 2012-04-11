using System.Windows;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows.Documents;
using TikzEdt.Overlay;
using System;
using System.Collections.Generic;



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

    class WPFShapeBase<T> : IPreviewShape where T : Shape, new()
    {
        Canvas TheCanvas;
        public T TheShape = new T();
        public WPFShapeBase(Canvas TheCanvas)
        {
            this.TheCanvas = TheCanvas;
        }

        public bool Visible
        {
            get
            {
                return TheShape.Visibility == Visibility.Visible;
            }
            set
            {
                if (value)
                {
                    if (!TheCanvas.Children.Contains(TheShape))
                        TheCanvas.Children.Add(TheShape);
                    Canvas.SetZIndex(TheShape, TheCanvas.Children.Count);
                    TheShape.Visibility = Visibility.Visible;
                }
                else
                    TheShape.Visibility = Visibility.Collapsed;
            }
        }

        public Rect GetBB()
        {
            return System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(TheShape);
        }

    }

    class WPFRectangleShape<T> : WPFShapeBase<T>, IRectangleShape where T:Shape, new()
    {
        public WPFRectangleShape(Canvas TheCanvas) : base(TheCanvas)
        {  }

        public void SetPosition(double Left, double Top, double Width, double Height)
        {
            Canvas.SetTop(TheShape, Top);
            Canvas.SetLeft(TheShape, Left);
            TheShape.Width = Width;
            TheShape.Height = Height;
        }

        public void SetCenter(double Left, double Bottom)
        {
            Canvas.SetBottom(TheShape, Bottom - TheShape.Height / 2);
            Canvas.SetLeft(TheShape, Left - TheShape.Width / 2);
        }
    }

    class WPFFanshape : WPFShapeBase<FanShape>, IFanShape
    {
        public WPFFanshape(Canvas TheCanvas) : base(TheCanvas) { }

        public double R { get { return TheShape.R; } set { TheShape.R = value; } }
        public Point Center { get { return TheShape.Center; } set { TheShape.Center = value; } }
        public List<double> Spokes { get { return TheShape.Spokes; } set { TheShape.Spokes = value; } }    // the angles of the spokes, in radians
    }


    /// <summary>
    /// Describes a fan, i.e., a pie segment with multiple "spokes"
    /// 
    /// It describe by a center point Center, a Radius and the various spokes
    /// </summary>
    class FanShape : Shape
    {
        public double R { get; set; }
        public Point Center { get; set; }
        public List<double> Spokes { get; set; }    // the angles of the spokes, in radians

        //public OverlayInterface overlay;

        /// <summary>
        /// Sets the parameters according to the Tikz_Arc's parameters
        /// </summary>
        /// <param name="arc"></param>
        /*public void AdjustPos(Tikz_Arc arc)
        {
            Point p;
            if (!arc.GetStartPointAbs(out p))
                throw new Exception("Broken Arc.");

            p = overlay.TikzToScreen(p);

            X = p.X;
            Y = p.Y;
            phi1 = Math.PI * arc.phi1.GetInCM() / 180;
            phi2 = Math.PI * arc.phi2.GetInCM() / 180;

            Point c;
            arc.GetArcCenterAbs(out c);
            c = overlay.TikzToScreen(c);
            r = (c - p).Length;

            InvalidateVisual();
        } */

        /* public Point center
        {
            get
            {
                return new Point(X - r * Math.Cos(phi1), Y - r * Math.Sin(phi1));
            }
        } */
        /// <summary>
        /// Adjusts whether to display larger/smaller arc
        /// </summary>
        /*public void AdjustPreviewPos()
        {
            double d = phi2 - phi1;
            if (Keyboard.Modifiers.HasFlag(ModifierKeys.Shift) != (Math.Abs(d) > Math.PI))
                d -= 2 * Math.PI * Math.Sign(d);
            phi2 = phi1 + d;
            InvalidateVisual();
        } */
        /*public void AdjustPreviewPos(Point p)
        {
            double newa = Math.Atan2(p.Y - center.Y, p.X - center.X);
            phi2 = newa;
            AdjustPreviewPos();
        }*/

        /// <summary>
        /// In pixel coordinates, not upside down!
        /// </summary>
        /*Point EndPoint
        {
            get
            {
                return new Point(X + r * Math.Cos(phi2) - r * Math.Cos(phi1), overlay.Height - (Y + r * Math.Sin(phi2) - r * Math.Sin(phi1)));
            }
        } */

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
                //geometry.Freeze();

                return geometry;
            }
        }


        Point spokep(int i)
        {
            return Center + R * (new Vector(Math.Cos(Spokes[i]), -Math.Sin(Spokes[i])));
        }

        /// <summary>
        /// Draw an arc
        /// </summary>
        /// <param name="context"></param>
        private void InternalDrawNodeGeometry(StreamGeometryContext context)
        {
            if (R == 0 || Spokes == null || Spokes.Count() < 2)
                return;

            context.BeginFigure(Center, false, false);

            context.LineTo(spokep(0), true, false);

            for (int i = 1; i < Spokes.Count(); i++)
            {
                if (Math.Abs(Spokes[i] - Spokes[i - 1]) > 2 * Math.PI - .001)
                {
                    // Display a circle
                    double ControlPointRatio = (Math.Sqrt(2) - 1) * 4 / 3;

                    var x0 = Center.X - R;
                    var x1 = Center.X - R * ControlPointRatio;
                    var x2 = Center.X;
                    var x3 = Center.X + R * ControlPointRatio;
                    var x4 = Center.X + R;

                    var y0 = Center.Y - R;
                    var y1 = Center.Y - R * ControlPointRatio;
                    var y2 = Center.Y;
                    var y3 = Center.Y + R * ControlPointRatio;
                    var y4 = Center.Y + R;

                    context.BeginFigure(new Point(x2, y0), true, true);
                    context.BezierTo(new Point(x3, y0), new Point(x4, y1), new Point(x4, y2), true, true);
                    context.BezierTo(new Point(x4, y3), new Point(x3, y4), new Point(x2, y4), true, true);
                    context.BezierTo(new Point(x1, y4), new Point(x0, y3), new Point(x0, y2), true, true);
                    context.BezierTo(new Point(x0, y1), new Point(x1, y0), new Point(x2, y0), true, true);

                }
                else
                {
                    bool largearc = Math.Abs(Spokes[i] - Spokes[i - 1]) > Math.PI;
                    SweepDirection sd = SweepDirection.Counterclockwise;
                    if (Spokes[i] < Spokes[i - 1])
                        sd = SweepDirection.Clockwise;

                    context.ArcTo(spokep(i), new Size(R, R), 0, largearc, sd, true, false);
                }

                context.BeginFigure(Center, false, false);
                context.LineTo(spokep(i), true, false);

            }

        }

    }

}