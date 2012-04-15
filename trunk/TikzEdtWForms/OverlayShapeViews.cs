using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TikzEdt.Overlay;
using System.Windows.Forms;
using System.Drawing;

namespace TikzEdtWForms
{
    abstract class OverlayShapeView : IOverlayShapeView
    {
        /// <summary>
        /// Stores the underlying OverlayShape displayed by this view.
        /// </summary>
        public OverlayShape TheUnderlyingShape { get; set; }

        /// <summary>
        ///  In upside down coordinates!
        /// </summary>
        protected System.Windows.Rect BB = new System.Windows.Rect(0,0,0,0);

        protected Control Parent;

        // in upside down coordinates
        public abstract System.Windows.Rect GetBB()
        {
            return new System.Windows.Rect(BB.X, Parent.Height - BB.Y - BB.Height, BB.Width, BB.Height);
        }

        string ToolTip { get; set; }
        public void SetToolTip(string Text)
        {
            this.ToolTip = Text;
        }

        //double ParentHeight { get { return (Parent as Canvas).Height; } }
        //double ParentWidth { get { return (Parent as Canvas).Width; } }


        public virtual double GetLeft()
        {
            return BB.X + BB.Width / 2;
        }

        public virtual double GetBottom()
        {
            return BB.Y + BB.Height / 2;
        }

        public virtual void SetPosition(double Left, double Bottom, bool Relative = false)
        {
            if (Relative)
            {
                BB.X = BB.X + Left;
                BB.Y = BB.Y + Bottom;
            }
            else
            {
                BB.X = Left - BB.Width / 2;
                BB.Y = Bottom - BB.Height / 2;
            }
            Parent.Invalidate();
        }

        protected bool IsSelected = false;
        public void SetStdColor() { IsSelected = false; Parent.Invalidate(); }
        public void SetSelColor() { IsSelected = true; Parent.Invalidate(); }

        protected Pen StdPen, SelPen;

        public OverlayShapeView(Control Parent)
        {
            this.Parent = Parent;
        }

        public abstract void Draw(Graphics dc);
    }

    class OverlayNodeView : OverlayShapeView
    {
        /*
        public override void SetSelColor()
        {
            Stroke = new SolidColorBrush(Properties.Settings.Default.Overlay_CoordSelColor);
        }
        public override void SetStdColor()
        {
            Stroke = new SolidColorBrush(Properties.Settings.Default.Overlay_CoordColor);
        }
        */
       
        /// <summary>
        /// Draw an X
        /// </summary>
        /// <param name="dc"></param>
        public override void Draw(Graphics dc)
        {
            Pen p = IsSelected ? SelPen : StdPen;
            RectangleF lBB = GetBB().ToRectangleF();
            dc.DrawLine(p, lBB.TopLeft(), lBB.BottomRight());
            dc.DrawLine(p, lBB.BottomLeft(), lBB.TopRight());
        }

        public OverlayNodeView(Control Parent) : base(Parent)
        {
            BB.Width = 10;
            BB.Height = 10;

            SelPen = Pens.Red;
            StdPen = Pens.Green;
        }
    }

    class OverlayScopeView : OverlayShapeView, IOverlayScopeView
    {

        public override void SetPosition(double Left, double Bottom, bool Relative = false)
        {
            if (Relative)
            {
                BB.X = BB.X + Left;
                BB.Y = BB.Y + Bottom;
            }
            else
            {
                BB.X = Left;
                BB.Y = Bottom;
            }
            Parent.Invalidate();
        }

        public OverlayScopeView(Control Parent) : base(Parent)
        {
            SelPen = new Pen(Brushes.LightGoldenrodYellow, 5);
            StdPen = new Pen(Brushes.LightBlue, 5);

        }

        public void SetSize(double Width, double Height)
        {
            BB.Width = Width;
            BB.Height = Height;
        }

        bool IsAdornerVisible = false;
        public void ShowAdorner()
        {
            IsAdornerVisible = true; Parent.Invalidate();
        }

        public void RemoveAdorner()
        {
            IsAdornerVisible = false; Parent.Invalidate();
        }

        public override double GetLeft()
        {
            return BB.X;
        }

        public override double GetBottom()
        {
            return BB.Y;
        }

        public override void Draw(Graphics dc)
        {
            RectangleF lBB = GetBB().ToRectangleF();
            Pen p = IsSelected ? SelPen : StdPen;

            dc.DrawRectangle(p, lBB.X, lBB.Y, lBB.Width, lBB.Height);

            // todo: draw adorner
        }
    }

    class OverlayCPView : OverlayShapeView, IOverlayCPView
    {
        //public Line lineToOrigin1 = new Line() { Stroke = Brushes.Gray, StrokeDashArray = new DoubleCollection(new double[] { 4, 4 }) };
        //public Line lineToOrigin2 = new Line() { Stroke = Brushes.Gray, StrokeDashArray = new DoubleCollection(new double[] { 4, 4 }) };

        System.Windows.Point L1Origin, L2Origin;
        bool L1Visible = false, L2Visible = false;
        public OverlayCPView(Control Parent)
            : base(Parent)
        {
            BB.Width = 10;
            BB.Height = 10;

            SelPen = Pens.Red;
            StdPen = Pens.Green;
        }

        public void SetOrigin1(double Left, double Top, double CanvasHeight)
        {
            L1Origin = new System.Windows.Point(Left, Top);
            L1Visible = true;
            Parent.Invalidate();
        }

        public void SetOrigin2(double Left, double Top, double CanvasHeight)
        {
            L2Origin = new System.Windows.Point(Left, Top);
            L2Visible = true;
            Parent.Invalidate();
        }

  /*      public void SetPosition(double left, double bottom)
        {
            Canvas.SetLeft(this, left - Width / 2);
            Canvas.SetBottom(this, bottom - Height / 2);

        }*/

        static Pen DashedPen = new Pen(Brushes.Gray) { DashPattern = new float[] { 4, 4 } };
        public override void Draw(Graphics dc)
        {
            Pen p = IsSelected ? SelPen : StdPen;
            RectangleF lBB = GetBB().ToRectangleF();

            // draw lines
            if (L1Visible)
                dc.DrawLine(DashedPen, L1Origin.ToPointF(), lBB.Center();
            if (L2Visible)
                dc.DrawLine(DashedPen, L2Origin.ToPointF(), lBB.Center();

            // draw CP
            dc.FillEllipse(Brushes.Gray, lBB);
            dc.DrawEllipse(p, lBB);


        }
    }


    class WPFShapeBase : IPreviewShape
    {
        Control TheCanvas;
        
        public WPFShapeBase(Control TheCanvas)
        {
            this.TheCanvas = TheCanvas;
        }

        bool _Visible = false;
        public bool Visible
        {
            get
            {
                return _Visible;
            }
            set
            {
                if (value != Visible)
                {
                    Visible = value;
                    TheCanvas.Invalidate();
                }
            }
        }

        protected System.Windows.Rect BB = new System.Windows.Rect(0,0,0,0);
        public System.Windows.Rect GetBB()
        {
            return BB;
        }


        private double _Rotation;

	    public double Rotation
	    {
		    get { return _Rotation;}
		    set { _Rotation = value; TheCanvas.Invalidate(); }
	    }

        public void Refresh()
        {
            TheCanvas.Invalidate();
        }

        public Pen ThePen = null;
        public Brush TheFill = null;

        public abstract void Draw(Graphics dc);
    }

    class WPFRectangleShape : WPFShapeBase, IRectangleShape
    {
        public WPFRectangleShape(Control TheCanvas)
            : base(TheCanvas)
        { }

        public void SetPosition(double Left, double Top, double Width, double Height)
        {
            BB.X = Left;
            BB.Y = Top;
            BB.Width = Width;
            BB.Height = Height;
        }

        /// <summary>
        /// in upside down coordinates
        /// </summary>
        protected System.Windows.Point Center = new System.Windows.Point(0, 0);
        public void SetCenter(double Left, double Bottom)
        {
            Center = new System.Windows.Point(Left, Bottom);
        }

        
        public override void Draw(Graphics dc)
        {
            if (TheFill != null)
                dc.FillRectangle(TheFill, BB.ToRectangleF());
            if (ThePen != null)
                dc.DrawRectangle(ThePen, BB.ToRectangleF());
        }
    }

    class WPFEllipseShape : WPFRectangleShape
    {
        public override void Draw(Graphics dc)
        {
            if (TheFill != null)
                dc.FillEllipse(TheFill, BB.ToRectangleF());
            if (ThePen != null)
                dc.DrawEllipse(ThePen, BB.ToRectangleF());
        }
    }

    /// <summary>
    /// Describes a fan, i.e., a pie segment with multiple "spokes"
    /// 
    /// It describe by a center point Center, a Radius and the various spokes
    /// </summary>
    class WPFFanshape : WPFShapeBase, IFanShape
    {
        public WPFFanshape(Control TheCanvas) : base(TheCanvas) { }

        public double R { get; set; }
        public System.Windows.Point Center { get; set; }
        public List<double> Spokes { get; set; }    // the angles of the spokes, in radians


        //public double R { get { return TheShape.R; } set { TheShape.R = value; } }
        //public Point Center { get { return TheShape.Center; } set { TheShape.Center = value; } }
        //public List<double> Spokes { get { return TheShape.Spokes; } set { TheShape.Spokes = value; } }    // the angles of the spokes, in radians

        /// <summary>
        /// Draw an arc
        /// </summary>
        /// <param name="dc"></param>
        public override void Draw(Graphics dc)
        {
            if (R == 0 || Spokes == null || Spokes.Count < 2 || ThePen == null)
                return;

            dc.DrawLine(ThePen, Center.ToPointF(), spokep(0));

            for (int i = 1; i < Spokes.Count; i++)
            {
                if (Math.Abs(Spokes[i] - Spokes[i - 1]) > 2 * Math.PI - .001)
                {
                    // Display a circle
                    double ControlPointRatio = (Math.Sqrt(2) - 1) * 4 / 3;

                    var x0 = (float)(Center.X - R);
                    var x1 = (float)(Center.X - R * ControlPointRatio);
                    var x2 = (float)(Center.X);
                    var x3 = (float)(Center.X + R * ControlPointRatio);
                    var x4 = (float)(Center.X + R);

                    var y0 = (float)( Center.Y - R);
                    var y1 = (float)(Center.Y - R * ControlPointRatio);
                    var y2 = (float)(Center.Y);
                    var y3 = (float)(Center.Y + R * ControlPointRatio);
                    var y4 = (float)(Center.Y + R);

                    PointF[] pts = new PointF[] { new PointF(x2, y0), new PointF(x3, y0), new PointF(x4, y1), 
                        new PointF(x4, y2), new PointF(x1, y4), new PointF(x0, y3), new PointF(x0, y2),
                        new PointF(x0, y1), new PointF(x1, y0), new PointF(x2, y0) };

                    dc.DrawBeziers(ThePen, pts);

                    /* context.BeginFigure(new Point(x2, y0), true, true);
                    context.BezierTo(new Point(x3, y0), new Point(x4, y1), new Point(x4, y2), true, true);
                    context.BezierTo(new Point(x4, y3), new Point(x3, y4), new Point(x2, y4), true, true);
                    context.BezierTo(new Point(x1, y4), new Point(x0, y3), new Point(x0, y2), true, true);
                    context.BezierTo(new Point(x0, y1), new Point(x1, y0), new Point(x2, y0), true, true); */

                }
                else
                {
                    bool largearc = Math.Abs(Spokes[i] - Spokes[i - 1]) > Math.PI;
                   /* SweepDirection sd = SweepDirection.Counterclockwise;
                    if (Spokes[i] < Spokes[i - 1])
                        sd = SweepDirection.Clockwise;

                    dc.DrawArc(ThePen, (float)Center.X, (float(Center.Y), (float)R, (float)R, )
                    context.ArcTo(spokep(i), new Size(R, R), 0, largearc, sd, true, false);*/
                    //TODO:support
                }

                dc.DrawLine(ThePen, Center.ToPointF(), spokep(i));

            }
        }


        PointF spokep(int i)
        {
            return (Center + R * (new System.Windows.Vector(Math.Cos(Spokes[i]), -Math.Sin(Spokes[i])))).ToPointF();
        }
    }



    class WFPreviewGridShape : WPFRectangleShape
    {

        static Pen DashedPen = new Pen(Brushes.Black) { DashPattern = new float[] { 4, 4 } };

        /// <summary>
        /// Draw a Grid
        /// </summary>
        /// <param name="dc"></param>
        public override void Draw(Graphics dc)
        {
            RectangleF lBB = GetBB().ToRectangleF();
            dc.DrawRectangle(DashedPen, lBB);

            dc.DrawLine(DashedPen, lBB.X + lBB.Width / 2, lBB.Y, lBB.X + lBB.Width / 2, lBB.Y + lBB.Height);
            dc.DrawLine(DashedPen, lBB.X, lBB.Y + lBB.Height/2, lBB.X + lBB.Width , lBB.Y + lBB.Height/2);
        }
    }

    class WPFArcShape : WPFShapeBase, IArcShape
    {
        public Point p1, p2, center;
        public bool IsPie { get; set; }
        public bool LargeArc { get; set; }


        public bool IsDashed
        {
            set
            {
                if (value)
                {
                    ThePen = new 
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

        public WPFArcShape(Canvas TheCanvas)
            : base(TheCanvas)
        {
            ThePen 
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
