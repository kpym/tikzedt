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

    abstract class OverlayShapeView : Shape //, IOverlayShapeView
    {
        /// <summary>
        /// Stores the underlying OverlayShape displayed by this view.
        /// </summary>
        public OverlayShapeVM TheUnderlyingShape {get; set; }

        public virtual Rect GetBB(double CanvasHeight)
        {
            double x = Canvas.GetLeft(this), y = CanvasHeight - Canvas.GetBottom(this);
            return new Rect(x, y, Width, Height);
        }
        //{
        //    return System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(this); ;
        //}

        public void SetToolTip(string Text)
        {
            ToolTip tip = new ToolTip();
            tip.Content = new TextBlock(new Run(Text));
            this.ToolTip = tip;
        }

        //double ParentHeight { get { return (Parent as Canvas).Height; } }
        //double ParentWidth { get { return (Parent as Canvas).Width; } }

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

        public abstract void SetStdColor();
        public abstract void SetSelColor();

        protected List<object> MyBindings = new List<object>();

        public OverlayShapeView(OverlayShapeVM osv)
        {
            TheUnderlyingShape = osv;
            MyBindings.Add(BindingFactory.CreateBinding(osv, "BB", vm => { Canvas.SetLeft(this, vm.BB.X); Canvas.SetBottom(this, vm.BB.Y); }, null, false));
            MyBindings.Add(BindingFactory.CreateBinding(osv, "IsSelected", vm => { if (vm.IsSelected) SetSelColor(); else SetStdColor(); }, null, false));
        }
    }

    class OverlayNodeView : OverlayShapeView //, Overlay.IOverlayShapeView
    {

   /*     public void SetPosition(double left, double bottom)
        {
            Width = 10;
            Height = 10;
            Canvas.SetLeft(this, left - Width / 2);
            Canvas.SetBottom(this, bottom - Height / 2);
        }*/

        public override void SetSelColor()
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

        public OverlayNodeView(OverlayNode on) : base(on)
        {
            Width = 10;
            Height = 10;
            Fill = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0)); // necessary?
        }
    }

    class OverlayScopeView : OverlayShapeView //, Overlay.IOverlayScopeView
    {

        public override void SetSelColor()
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

        public override void SetPosition(double left, double bottom, bool Relative=false)
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

        public OverlayScopeView(OverlayScope os) : base(os)
        {
            SetStdColor(); //os.Stroke = new SolidColorBrush(Color.FromArgb(100, 0, 255, 0));
            StrokeThickness = 10;
            //os.Fill = new SolidColorBrush(Color.FromArgb(100, 0, 255, 0));

            MyBindings.Add(BindingFactory.CreateBinding(os, "IsCurEditing", vm => { if (vm.IsCurEditing) ShowAdorner(); else RemoveAdorner(); }, null, false));
            MyBindings.Add(BindingFactory.CreateBinding(os, "BB", vm => { Width = vm.BB.Width; Height = vm.BB.Height; }, null, false));
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

        public override double GetLeft()
        {
            return Canvas.GetLeft(this);
        }

        public override double GetBottom()
        {
            return Canvas.GetBottom(this);
        }
    }

    class OverlayCPView : OverlayShapeView //, Overlay.IOverlayCPView
    {
        public Line lineToOrigin1 = new Line() { Stroke = Brushes.Gray, StrokeDashArray = new DoubleCollection(new double[] { 4, 4 }) };
        public Line lineToOrigin2 = new Line() { Stroke = Brushes.Gray, StrokeDashArray = new DoubleCollection(new double[] { 4, 4 }) };

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

        public OverlayCPView(OverlayControlPoint ocp) : base(ocp)
        {
            Width = 10;
            Height = 10;
            Fill = Brushes.Gray;
            SetStdColor();
            Canvas.SetZIndex(lineToOrigin1, -1);
            Canvas.SetZIndex(lineToOrigin2, -1);

            var sp1 = BindingFactory.CreateProvider(ocp, "Origin1", oc => oc.Origin1, false);
            var sp2 = BindingFactory.CreateProvider(ocp, "Origin2", oc => oc.Origin2, false);
            MyBindings.Add(sp1); MyBindings.Add(sp2);
            MyBindings.Add(BindingFactory.CreateBindingSP(sp1, "BB", vm => UpdateLinePos(lineToOrigin1, vm.Center), () => lineToOrigin1.Visibility = Visibility.Collapsed, false));
            MyBindings.Add(BindingFactory.CreateBindingSP(sp2, "BB", vm => UpdateLinePos(lineToOrigin2, vm.Center), () => lineToOrigin2.Visibility = Visibility.Collapsed, false));
            
            MyBindings.Add(BindingFactory.CreateBinding(ocp, "BB", vm => 
                { 
                    if (vm.Origin1 != null) UpdateLinePos(lineToOrigin1, vm.Origin1.Center);
                    if (vm.Origin2 != null) UpdateLinePos(lineToOrigin2, vm.Origin2.Center);
                }, null , false ) );

        }

        /// <summary>
        /// Adjusts the line position so that it points from the center of self to p.
        /// </summary>
        /// <param name="line"></param>
        /// <param name="p"></param>
        void UpdateLinePos(Line line, Point p)
        {
            var q = TheUnderlyingShape.Center;
            line.X1 = Math.Max(0, q.X-p.X); line.Y1=Math.Max(0, -(q.Y-p.Y));
            line.X2 = Math.Max(0, -(q.X-p.X)); line.Y2=Math.Max(0,q.Y-p.Y);

            Canvas.SetLeft(line, Math.Min(p.X, q.X));
            Canvas.SetBottom(line, Math.Min(p.Y, q.Y));

            line.Visibility = Visibility.Visible;
        }


        public void SetOrigin1(double Left, double Top, double CanvasHeight)
        {
            lineToOrigin1.X1 = Canvas.GetLeft(this) + Width/2;
            lineToOrigin1.Y1 = CanvasHeight - Canvas.GetBottom(this) - Height / 2;

            lineToOrigin1.X2 = Left;
            lineToOrigin1.Y2 = Top;

            lineToOrigin1.Visibility = Visibility.Visible;
        }

        public void SetOrigin2(double Left, double Top, double CanvasHeight)
        {
            lineToOrigin2.X1 = Canvas.GetLeft(this) + Width / 2;
            lineToOrigin2.Y1 = CanvasHeight - Canvas.GetBottom(this) - Height / 2;

            lineToOrigin2.X2 = Left;
            lineToOrigin2.Y2 = Top;

            lineToOrigin2.Visibility = Visibility.Visible;
        }

        public void SetPosition(double left, double bottom)
        {
            Width = 10;
            Height = 10;
            Canvas.SetLeft(this, left - Width / 2);
            Canvas.SetBottom(this, bottom - Height / 2);

        }

        public override void SetSelColor()
        {
            Stroke = new SolidColorBrush(Properties.Settings.Default.Overlay_CoordSelColor);
        }
        public override void SetStdColor()
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



        public double Rotation
        {
            set { TheShape.RenderTransform = new RotateTransform(value); }
        }

        public void Refresh()
        {
            TheShape.InvalidateVisual();
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
            if (R == 0 || Spokes == null || Spokes.Count < 2)
                return;

            context.BeginFigure(Center, false, false);

            context.LineTo(spokep(0), true, false);

            for (int i = 1; i < Spokes.Count; i++)
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

    class PreviewGridShape : Shape
    {
        public PreviewGridShape()
        {
            StrokeThickness = 1;
            StrokeDashArray = new DoubleCollection(new double[] { 4, 4 });
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

            context.BeginFigure(new Point(Width / 2, 0), true, true);
            context.LineTo(new Point(Width / 2, Height), true, false);

            context.BeginFigure(new Point(0, Height / 2), true, true);
            context.LineTo(new Point(Width, Height / 2), true, false);
        }
    }

    class WPFArcShape : WPFShapeBase<ThreePointArc>, IArcShape
    {
        public Point p1 { get {return TheShape.p1; } set {TheShape.p1 = value; } }
        public Point p2 { get {return TheShape.p2; } set {TheShape.p2 = value; } }
        public Point center { get {return TheShape.center; } set {TheShape.center = value; } }
        public bool IsLargeArc { get { return TheShape.LargeArc; } set { TheShape.LargeArc = value; } }
        public bool IsDashed
        {
            set
            {
                if (value)
                {
                    TheShape.StrokeDashArray = new DoubleCollection(new double[] { 4, 4 });
                    TheShape.Stroke = Brushes.Gray;
                }
                else
                {
                    TheShape.StrokeDashArray = null;
                    TheShape.Stroke = Brushes.Black;
                }
            }
        }

        public WPFArcShape(Canvas TheCanvas) : base(TheCanvas)
        {

        }
    }

    class ThreePointArc : Shape
    {
        public Point p1, p2, center;
        public bool IsPie { get; set; }

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

        double r { get { return (p1 - center).Length; } }
        public bool LargeArc { get; set; }

        /// <summary>
        /// Draw an arc
        /// </summary>
        /// <param name="context"></param>
        private void InternalDrawNodeGeometry(StreamGeometryContext context)
        {
            context.BeginFigure(p1, false, IsPie);
            Vector v1 = p1 - center, v2 = p2 - center;
            SweepDirection sd;
            if ((v1.X * v2.Y - v1.Y * v2.X > 0) != LargeArc)
                sd = SweepDirection.Clockwise;
            else
                sd = SweepDirection.Counterclockwise;

            context.ArcTo(p2, new Size(r, r), 0, LargeArc, sd, true, false);
            if (IsPie)
            {
                context.LineTo(center, true, false);
                context.LineTo(p1, true, false);
            }

        }

    }
}