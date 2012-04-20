using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TikzEdt;
using System.Drawing.Drawing2D;
using TikzEdt.Overlay;

namespace TikzEdtWForms
{
    public partial class RasterControl : Control, IRasterControlView, ITikzDisplayView, TikzEdt.Overlay.IPdfOverlayView, TikzEdt.Overlay.IOverlayShapeFactory
    {
        public RasterControlModel TheRasterModel;
        ToolTip toolTip1 = new ToolTip();

        public RasterControl()
        {
            InitializeComponent();

            if (DesignMode)
                return;

            disablerPanel = new Panel() { Dock = DockStyle.Fill, BackColor = Color.Transparent, Visible= false, Cursor=Cursors.No };
            toolTip1.SetToolTip(disablerPanel, "Overlay out of sync. WYSIWYG editing is disabled");
            this.Controls.Add(disablerPanel);

            //this.CanFocus = true;
            this.SetStyle(  ControlStyles.AllPaintingInWmPaint |  ControlStyles.UserPaint |  ControlStyles.DoubleBuffer | ControlStyles.Selectable, true);

            TheRasterModel = new RasterControlModel(this);

            TheDisplayModel = new TikzDisplayModel<Bitmap>(this, new PdfToBmpExtWinForms());

            TheOverlayModel = new PdfOverlayModel(this, this);

            // listen to Bitmap changes
            MyBindings.Add( BindingFactory.CreateBinding(TheDisplayModel, "Bmp", (o)=>this.Invalidate(), null) );

        }

        List<object> MyBindings = new List<object>();

        protected override void OnPaint(PaintEventArgs pe)
        {
            //base.OnPaint(pe);

            // Draw white background
            Graphics dc = pe.Graphics;
            dc.ResetTransform();
            dc.FillRectangle(Brushes.White, 0, 0, Width, Height);
            
            // Draw the raster
            Matrix t = TheRasterModel.GetTikzToScreenTransform().ToMatrix();
            //t.Freeze();
            
            Pen pen = new Pen(Brushes.WhiteSmoke, 0.000001f);
            //pen.Freeze();   
            dc.Transform = t;

            TheRasterModel.DrawRaster(
                (p1, p2) => dc.DrawLine(pen, p1.ToPointF(), p2.ToPointF()),
                (r1, r2) =>
                {
                    float rr1=(float)r1, rr2=(float)r2;
                    dc.DrawEllipse(pen, -rr1, -rr2, 2*rr1, 2*rr2);
                });

            dc.ResetTransform();

            // draw unavailable note
            if (TheDisplayModel.IsUnavailable)
            {
                StringFormat f = new StringFormat();
                f.Alignment = StringAlignment.Center;
                f.LineAlignment = StringAlignment.Center;
                dc.DrawString("<Unavailable>", new Font("Arial", 16), Brushes.Black, ClientRectangle, f);
            }

            // draw the pdf image
            if (TheDisplayModel.IsImageVisible && TheDisplayModel.Bmp != null)
            {
                Point p = new Point((Width - TheDisplayModel.Bmp.Width)/2, (Height- TheDisplayModel.Bmp.Height)/2);
                dc.DrawImageUnscaled(TheDisplayModel.Bmp, p);
            }

            if (ShowOverlay)
            {
                // draw shapes from parsetree
                foreach (var osv in OSViews)
                    osv.Draw(pe.Graphics);

                // draw (visible) auxiliary shapes
                foreach (var ps in PreviewShapes.Where(o => o.Visible))
                    ps.Draw(pe.Graphics);

            }
        }

        /// <summary>
        /// This is the main routine, it does what one might guess.
        /// </summary>
        public void DrawRaster()
        {
            this.Invalidate();
        }

        void AdjustSize()
        {
            Width = Convert.ToInt32(Resolution * BB.Width);
            Height = Convert.ToInt32(Resolution * BB.Height);
            DrawRaster();
            TheOverlayModel.AdjustPositions();
        }

        #region Properties
        System.Windows.Rect _BB = new System.Windows.Rect(0, 0, 10, 10);
        public System.Windows.Rect BB
        {
            get
            {
                return _BB;
            }
            set
            {
                _BB = value;
                AdjustSize();
            }
        }

        TikzEdt.Parser.TikzMatrix _CoordinateTransform = new TikzEdt.Parser.TikzMatrix();
        public TikzEdt.Parser.TikzMatrix CoordinateTransform
        {
            get
            {
                return _CoordinateTransform;
            }
            set
            {
                _CoordinateTransform = value;
                DrawRaster();
            }
        }

        double _ForceRadiusTo = -1;
        public double ForceRadiusTo
        {
            get
            {
                return _ForceRadiusTo;
            }
            set
            {
                _ForceRadiusTo = value;
            }
        }

        bool _IsCartesian = true;
        public bool IsCartesian
        {
            get
            {
                return _IsCartesian;
            }
            set
            {
                _IsCartesian = value;
                DrawRaster();
            }
        }

        bool _OverrideWithHalfGridWidth = false;
        public bool OverrideWithHalfGridWidth
        {
            get
            {
                return _OverrideWithHalfGridWidth;
            }
            set
            {
                _OverrideWithHalfGridWidth = value;
                DrawRaster();
            }
        }

        bool _OverrideWithZeroGridWidth = false;
        public bool OverrideWithZeroGridWidth
        {
            get
            {
                return _OverrideWithZeroGridWidth;
            }
            set
            {
                _OverrideWithZeroGridWidth = value;
                DrawRaster();
            }
        }

        double _RadialOffset = 0;
        public double RadialOffset
        {
            get
            {
                return _RadialOffset;
            }
            set
            {
                _RadialOffset = value;
                DrawRaster();
            }
        }

        uint _RasterRadialSteps = 10;
        public uint RasterRadialSteps
        {
            get
            {
                return _RasterRadialSteps;
            }
            set
            {
                _RasterRadialSteps = value;
                DrawRaster();
            }
        }

        double _RasterWidth = .5;
        public double RasterWidth
        {
            get
            {
                return _RasterWidth;
            }
            set
            {
                _RasterWidth = value;
                DrawRaster();
            }
        }

        double _Resolution = Consts.ptspertikzunit;
        public double Resolution
        {
            get
            {
                return _Resolution;
            }
            set
            {
                _Resolution = value;
                AdjustSize();
                TheDisplayModel.RedrawBMP(false);
            }
        }

        bool _ShowRaster = true;
        public bool ShowRaster
        {
            get
            {
                return _ShowRaster;
            }
            set
            {
                _ShowRaster = value;
                DrawRaster();
            }
        }

        #endregion
    }

    public static class Extensions
    {

        public static Matrix ToMatrix(this TikzEdt.Parser.TikzMatrix M)
        {
            Matrix MM = new Matrix(
                (float)M.m[0, 0],
                (float)M.m[0, 1],
                (float)M.m[1, 0],
                (float)M.m[1, 1],
                (float)M.m[0, 2],
                (float)M.m[1, 2]
            );
            return MM;
        }

        public static Point Transform(this Matrix M, Point p)
        {
            Point[] pts = new Point[] { p };
            M.TransformPoints(pts);
            return pts[0];
        }

        public static System.Drawing.PointF ToPointF(this System.Windows.Point p)
        {
            return new PointF((float)p.X, (float)p.Y);
        }

        public static System.Windows.Point ToPoint(this Point p)
        {
            return new System.Windows.Point(p.X,p.Y);
        }

        public static System.Drawing.RectangleF ToRectangleF(this System.Windows.Rect r)
        {
            return new RectangleF((float)r.X, (float)r.Y, (float)r.Width, (float)r.Height);
        }
        public static System.Drawing.RectangleF ToRectangleF(this Rectangle r)
        {
            return new RectangleF((float)r.X, (float)r.Y, (float)r.Width, (float)r.Height);
        }

        public static System.Drawing.PointF TopLeft(this RectangleF r)
        {
            return new PointF(r.X, r.Y);
        }
        public static System.Drawing.PointF TopRight(this RectangleF r)
        {
            return new PointF(r.X+r.Width, r.Y);
        }
        public static System.Drawing.PointF BottomLeft(this RectangleF r)
        {
            return new PointF(r.X, r.Y+r.Height);
        }
        public static System.Drawing.PointF BottomRight(this RectangleF r)
        {
            return new PointF(r.X + r.Width, r.Y + r.Height);
        }
        public static System.Drawing.PointF Center(this RectangleF r)
        {
            return new PointF(r.X + r.Width/2, r.Y + r.Height/2);
        }
        public static System.Windows.Point Center(this System.Windows.Rect r)
        {
            return new System.Windows.Point(r.X + r.Width / 2, r.Y + r.Height / 2);
        }

        public static void DrawRectangle(this Graphics G, Pen p, RectangleF r)
        {
            G.DrawRectangle(p, r.X, r.Y, r.Width, r.Height);
        }

        public static Pair<TSource, TKey> MinBy<TSource, TKey>(this IEnumerable<TSource> source,
                    Func<TSource, TKey> selector)
        {
            return source.MinBy(selector, Comparer<TKey>.Default);
        }

        public static Pair<TSource, TKey> MinBy<TSource, TKey>(this IEnumerable<TSource> source,
            Func<TSource, TKey> selector, IComparer<TKey> comparer)
        {
            //source.ThrowIfNull("source");
            //selector.ThrowIfNull("selector");
            //comparer.ThrowIfNull("comparer");
            using (IEnumerator<TSource> sourceIterator = source.GetEnumerator())
            {
                if (!sourceIterator.MoveNext())
                {
                    throw new InvalidOperationException("Sequence was empty");
                }
                TSource min = sourceIterator.Current;
                TKey minKey = selector(min);
                while (sourceIterator.MoveNext())
                {
                    TSource candidate = sourceIterator.Current;
                    TKey candidateProjected = selector(candidate);
                    if (comparer.Compare(candidateProjected, minKey) < 0)
                    {
                        min = candidate;
                        minKey = candidateProjected;
                    }
                }
                return new Pair<TSource, TKey>(min, minKey);
            }

        }


        public static TEMouseArgs ToTEMouseArgs(this MouseEventArgs e)
        {
            return new TEMouseArgs()
            {
                ClickCount = e.Clicks,
                Handled = false,
                LeftButtonPressed = e.Button.HasFlag(MouseButtons.Left),
                RightButtonPressed = e.Button.HasFlag(MouseButtons.Right),
                MiddleButtonPressed = e.Button.HasFlag(MouseButtons.Middle)
            };
        }

        public static TEKeyArgs ToTEKeyArgs(this KeyEventArgs e)
        {
            return new TEKeyArgs()
            {
                Handled = e.Handled,
                KeyCode = e.KeyCode
            };
        }

        public static void Each<T>(this IEnumerable<T> ie, Action<T, int> action)
        {
            var i = 0;
            foreach (var e in ie) action(e, i++);
        }

    }
}
