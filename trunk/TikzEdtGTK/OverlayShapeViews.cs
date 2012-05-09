using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TikzEdt.Overlay;
using System.Windows.Forms;
using System.Drawing;
using TikzEdt;
using System.Windows;
using Gtk;

namespace TikzEdtGTK
{
    abstract class OverlayShapeView : IOverlayShapeView
    {
        /// <summary>
        /// Stores the underlying OverlayShape displayed by this view.
        /// </summary>
        public OverlayShapeVM TheUnderlyingShape { get; set; }

        /// <summary>
        ///  In upside down coordinates!
        /// </summary>
        protected System.Windows.Rect BB = new System.Windows.Rect(0,0,0,0);

        protected RasterControl Parent;

        // in upside down coordinates
        public virtual System.Windows.Rect GetBB(double CanvasHeight)
        {
            return new System.Windows.Rect(BB.X, Parent.Height - BB.Y - BB.Height, BB.Width, BB.Height);
        }

        public string ToolTip { get; set; }
        public void SetToolTip(string Text)
        {
            this.ToolTip = Text;
        }


        /// <summary>
        /// Tests whether the point p (in TL centric coordinates) lies within the object.
        /// If yes returns a "distance", based on which the object is selected. (smallest distance wins)
        /// If no returns a large value (1000000)
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public virtual double HitTest(double x, double y)
        {
            var lBB = GetBB(Parent.Height);
            if (lBB.Contains(x, y))
            {
                return (new System.Windows.Point(x, y) - lBB.Center()).Length;
            }
            else return 1000000;
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

        protected abstract Pen StdPen { get ; }
        protected abstract Pen SelPen { get; }

        public OverlayShapeView(RasterControl Parent)
        {
            this.Parent = Parent;
        }

        public abstract void Draw(Cairo.Context dc);
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
        public override void Draw(Cairo.Context dc)
        {
            Pen p = IsSelected ? SelPen : StdPen;
            Rect lBB = GetBB(Parent.Height);
            dc.SetSourceRGB(1, 0, 0); // todo
            dc.DrawLine(lBB.TopLeft, lBB.BottomRight);
            dc.DrawLine(lBB.BottomLeft, lBB.TopRight);
        }

        public OverlayNodeView(RasterControl Parent) : base(Parent)
        {
            BB.Width = 10;
            BB.Height = 10;

        }

        protected override Pen SelPen
        {
            get { return PensAndBrushes.OverlayNodeSelPen; }
        }
        protected override Pen StdPen
        {
            get { return PensAndBrushes.OverlayNodePen; }
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

        public OverlayScopeView(RasterControl Parent)
            : base(Parent)
        {
        }
        protected override Pen SelPen
        {
            get { return PensAndBrushes.OverlayScopeSelPen; }
        }
        protected override Pen StdPen
        {
            get { return PensAndBrushes.OverlayScopePen; }
        }

        public override double HitTest(double x, double y)
        {
            var lBB = GetBB(Parent.Height);
            var lBBs = GetBB(Parent.Height);
            lBBs.Inflate(10,10);
            if (lBB.Contains(x, y) && lBBs.Contains(x, y))
                return 10;
            else
                return 1000000;
        }

        public void SetSize(double Width, double Height)
        {
            BB.Width = Width;
            BB.Height = Height;
        }

        public bool IsAdornerVisible = false;
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

        public override void Draw(Cairo.Context dc)
        {
            RectangleF lBB = GetBB(Parent.Height).ToRectangleF();
            Pen p = IsSelected ? SelPen : StdPen;

            dc.Rectangle(lBB.X, lBB.Y, lBB.Width, lBB.Height);
            dc.Stroke();

            // todo: draw adorner
        }
    }

    class OverlayCPView : OverlayShapeView, IOverlayCPView
    {
        //public Line lineToOrigin1 = new Line() { Stroke = Brushes.Gray, StrokeDashArray = new DoubleCollection(new double[] { 4, 4 }) };
        //public Line lineToOrigin2 = new Line() { Stroke = Brushes.Gray, StrokeDashArray = new DoubleCollection(new double[] { 4, 4 }) };

        System.Windows.Point L1Origin, L2Origin;
        bool L1Visible = false, L2Visible = false;
        public OverlayCPView(RasterControl Parent)
            : base(Parent)
        {
            BB.Width = 10;
            BB.Height = 10;
        }
        protected override Pen SelPen
        {
            get { return PensAndBrushes.OverlayNodeSelPen; }
        }
        protected override Pen StdPen
        {
            get { return PensAndBrushes.OverlayNodePen; }
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

        static Pen DashedPen = PensAndBrushes.DashedPenGray;
        public override void Draw(Cairo.Context dc)
        {
            Pen p = IsSelected ? SelPen : StdPen;
            Rect lBB = GetBB(Parent.Height);

            // draw lines
            if (L1Visible)
                dc.DrawLine(L1Origin, lBB.Center()); //DashedPen, 
            if (L2Visible)
                dc.DrawLine(L2Origin, lBB.Center()); //DashedPen, 

            // draw CP
            dc.FillEllipse(lBB); //Brushes.Gray, 
            dc.DrawEllipse(lBB); //p, 


        }
    }


    public abstract class WFShapeBase : IPreviewShape
    {
        RasterControl TheCanvas;

        public WFShapeBase(RasterControl TheCanvas)
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
                if (value != _Visible)
                {
                    _Visible = value;
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

        public abstract void Draw(Cairo.Context dc);
    }

    class WFRectangleShape : WFShapeBase, IRectangleShape
    {
        public WFRectangleShape(RasterControl TheCanvas)
            : base(TheCanvas)
        { }

        public void SetPosition(double Left, double Top, double Width, double Height)
        {
            BB.X = Left;
            BB.Y = Top;
            BB.Width = Width;
            BB.Height = Height;
            //GlobalUI.UI.AddStatusLine(this, "setpos");
            Refresh();
        }

        /// <summary>
        /// in upside down coordinates
        /// </summary>
        protected System.Windows.Point Center = new System.Windows.Point(0, 0);
        public void SetCenter(double Left, double Bottom)
        {
            Center = new System.Windows.Point(Left, Bottom);
        }


        public override void Draw(Cairo.Context dc)
        {
            if (TheFill != null)
            {
                dc.Rectangle(BB.ToCairoRectangle()); //TheFill, 
                dc.Fill();
            }
            if (ThePen != null)
            {
                var r = BB;
                dc.Rectangle(r.ToCairoRectangle());//ThePen, 
                dc.Stroke();
                //dc.DrawRectangle(Pens.Green, new RectangleF(20, 20, 200, 200));
                //GlobalUI.UI.AddStatusLine(this, "p " + BB.Width + " " + BB.Height + " " + r);
            }
        }
    }

    class WFEllipseShape : WFRectangleShape
    {
        public override void Draw(Cairo.Context dc)
        {
            if (TheFill != null)
                dc.FillEllipse(BB); //TheFill, 
            if (ThePen != null)
                dc.DrawEllipse(BB); //ThePen, 
        }

        public WFEllipseShape(RasterControl C) : base(C) { }
    }

    /// <summary>
    /// Describes a fan, i.e., a pie segment with multiple "spokes"
    /// 
    /// It describe by a center point Center, a Radius and the various spokes
    /// </summary>
    class WFFanshape : WFShapeBase, IFanShape
    {
        public WFFanshape(RasterControl TheCanvas) : base(TheCanvas) { }

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
        public override void Draw(Cairo.Context dc)
        {
            if (R == 0 || Spokes == null || Spokes.Count < 2 || ThePen == null)
                return;

            dc.DrawLine(Center, spokep(0)); //ThePen, 

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

                    System.Windows.Point[] pts = new System.Windows.Point[] { new System.Windows.Point(x2, y0), new System.Windows.Point(x3, y0), new System.Windows.Point(x4, y1), 
                        new System.Windows.Point(x4, y2), new System.Windows.Point(x1, y4), new System.Windows.Point(x0, y3), new System.Windows.Point(x0, y2),
                        new System.Windows.Point(x0, y1), new System.Windows.Point(x1, y0), new System.Windows.Point(x2, y0) };

                    dc.DrawBeziers(pts); //ThePen, 

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

                dc.DrawLine(Center, spokep(i));//ThePen, 

            }
        }


        System.Windows.Point spokep(int i)
        {
            return (Center + R * (new System.Windows.Vector(Math.Cos(Spokes[i]), -Math.Sin(Spokes[i]))));
        }
    }



    class WFPreviewGridShape : WFRectangleShape
    {

        static Pen DashedPen = PensAndBrushes.DashedPen;

        /// <summary>
        /// Draw a Grid
        /// </summary>
        /// <param name="dc"></param>
        public override void Draw(Cairo.Context dc)
        {
            var lBB = GetBB();
            dc.Rectangle(lBB.ToCairoRectangle());//DashedPen, 

            dc.DrawLine(lBB.X + lBB.Width / 2, lBB.Y, lBB.X + lBB.Width / 2, lBB.Y + lBB.Height); //DashedPen, 
            dc.DrawLine(lBB.X, lBB.Y + lBB.Height/2, lBB.X + lBB.Width , lBB.Y + lBB.Height/2);  //DashedPen, 
        }

        public WFPreviewGridShape(RasterControl C) : base(C) { }
    }

    class WFArcShape : WFShapeBase, IArcShape
    {
        public System.Windows.Point p1  {get; set;}
        public System.Windows.Point p2  {get; set;}
        public System.Windows.Point center {get; set;}
        public bool IsPie { get; set; }
        public bool IsLargeArc { get; set; }

        double r { get { return (p1 - center).Length; } }

        public bool IsDashed
        {
            get;
            set;
        }

        public WFArcShape(RasterControl TheCanvas)
            : base(TheCanvas)
        {
            ThePen = Pens.Black;
        }

        public override void Draw(Cairo.Context dc)
        {
            Pen p = IsDashed ? PensAndBrushes.DashedPen : ThePen;
            float R = (float) (center-p1).Length;   // the radius of the circle
            var diag = new System.Windows.Vector(R,R);
            Rect re = new System.Windows.Rect(center+diag, center-diag);  // BB of the circle
            System.Windows.Vector v1 = p1 - center, v2 = p2 - center;


            if (IsPie)
            {
                dc.DrawLine(center, p1); //p, 
                dc.DrawLine(center, p2); //p, 
            }

            float angle2 = (float)( Math.Atan2(v2.Y, v2.X) *180 / Math.PI);
            float angle1 = (float)( Math.Atan2(v1.Y, v1.X) *180 / Math.PI);
            float angle = angle2 - angle1;
            float bngle = angle + (angle>0?-360:360);


            if (     ( IsLargeArc && Math.Abs(angle) < 180)
                 ||  (!IsLargeArc && Math.Abs(angle) > 180) )
                angle = bngle;

            if (re.Height * re.Width > 0)
            {
                dc.Arc( re.Center().X, re.Center().Y, re.Width/2, angle1, angle);//p, // hack
            }
            /* TODO
            context.BeginFigure(p1, false, IsPie);
            
            SweepDirection sd;
            if ((v1.X * v2.Y - v1.Y * v2.X > 0) != LargeArc)
                sd = SweepDirection.Clockwise;
            else
                sd = SweepDirection.Counterclockwise;

            context.ArcTo(p2, new Size(r, r), 0, LargeArc, sd, true, false);*/

            
        }
    }

    public static class PensAndBrushes
    {
        public static Pen DashedPen;
        public static Pen OverlayScopePen;
        public static Pen OverlayScopeSelPen;
        public static Pen OverlayNodePen;
        public static Pen OverlayNodeSelPen;
        public static Pen DashedPenGray;
        public static Brush SelectionRectFill;
        public static Pen AdornerPen;


        static PensAndBrushes()
        {
            CreatePens();
            DashedPen = new Pen(Brushes.Black) { DashPattern = new float[] { 4, 4 } };
            DashedPenGray = new Pen(Brushes.Gray) { DashPattern = new float[] { 4, 4 } };
            SelectionRectFill = new SolidBrush(Color.FromArgb(0x23, 0x00, 0x8A, 0xCA));
            AdornerPen = new Pen(new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.ForwardDiagonal, Color.Black, Color.White), 5);

            Properties.Settings.Default.PropertyChanged += (s, e) =>
                {
                    var names = new string[] { "Overlay_ScopeColor", "Overlay_ScopeSelColor", "Overlay_CoordColor", "Overlay_CoordSelColor" };
                    if (names.Contains(e.PropertyName))
                        PensAndBrushes.RecreatePens();
                };
        }


        static void CreatePens()
        {
            OverlayScopePen = new Pen(Properties.Settings.Default.Overlay_ScopeColor, 5);
            OverlayScopeSelPen = new Pen(Properties.Settings.Default.Overlay_ScopeSelColor, 5);
            OverlayNodePen = new Pen(Properties.Settings.Default.Overlay_CoordColor);
            OverlayNodeSelPen = new Pen(Properties.Settings.Default.Overlay_CoordSelColor);
        }

        static void DisposePens()
        {
            //if (DashedPen != null)          { DashedPen.Dispose(); DashedPen = null; }
            //if (DashedPenGray != null)      { DashedPenGray.Dispose(); DashedPenGray = null; }
            if (OverlayScopePen != null)    { OverlayScopePen.Dispose(); OverlayScopePen = null; }
            if (OverlayScopeSelPen != null) { OverlayScopeSelPen.Dispose(); OverlayScopeSelPen = null; }
            if (OverlayNodePen != null)     { OverlayNodePen.Dispose(); OverlayNodePen = null; }
            if (OverlayNodeSelPen != null)  { OverlayNodeSelPen.Dispose(); OverlayNodeSelPen = null; }
        }

        public static void RecreatePens()
        {
            DisposePens(); 
            CreatePens();
        }


    }

}
