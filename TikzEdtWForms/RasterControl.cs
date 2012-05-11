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
            //toolTip1.SetToolTip(this, "The WYSIWYG area");
            //toolTip1.Popup += new PopupEventHandler(toolTip1_Popup);
            //toolTip1.ReshowDelay = 50;
            //toolTip1.InitialDelay = 100;
            //toolTip1.ShowAlways = true;
            toolTip1.Active = true;

            this.MouseHover += new EventHandler(RasterControl_MouseHover);

            this.Controls.Add(disablerPanel);

            CreateContextMenu();

            //this.CanFocus = true;
            this.SetStyle(  ControlStyles.AllPaintingInWmPaint |  ControlStyles.UserPaint |  ControlStyles.DoubleBuffer | ControlStyles.Selectable, true);

            TheRasterModel = new RasterControlModel(this);

            IPdfToBmp<Bitmap> Pdf2Bmp;
            if (CompilerSettings.Instance.UseExternalRenderer)
                Pdf2Bmp = new PdfToBmpExtWinForms();
            else
                Pdf2Bmp = new PdfToBmp();
            TheDisplayModel = new TikzDisplayModel<Bitmap>(this, Pdf2Bmp);

            TheOverlayModel = new PdfOverlayModel(this, this);
            TheOverlayModel.DisplayTree.DisplayTreeChanged += new EventHandler<TikzDisplayTree.DisplayTreeChangedEventArgs>(DisplayTree_DisplayTreeChanged);

            MarkObject_Timer.Interval = 500;
            MarkObject_Timer.Tick += new EventHandler(MarkObject_Timer_Tick);

            // listen to Bitmap changes
            MyBindings.Add( BindingFactory.CreateBinding(TheDisplayModel, "Bmp", (o)=>this.Invalidate(), null) );

        }


        List<MyBinding<OverlayShapeVM>> DisplayTreeBindings = new List<MyBinding<OverlayShapeVM>>();
        void DisplayTree_DisplayTreeChanged(object sender, TikzDisplayTree.DisplayTreeChangedEventArgs e)
        {
            if (e.Type == TikzDisplayTree.DisplayTreeChangedType.Clear)
            {
                // clear bindings
                foreach (var b in DisplayTreeBindings)
                    b.Source = null;
                DisplayTreeBindings.Clear();
                Invalidate();
            } if (e.Type == TikzDisplayTree.DisplayTreeChangedType.Insert)
            {
                // listen to BB changed to redraw if necessary
                foreach (var os in e.AffectedItems)
                    DisplayTreeBindings.Add(BindingFactory.CreateBinding(os, "BB", o => this.Invalidate(), null));

                Invalidate();
            }
        }

        void RasterControl_MouseHover(object sender, EventArgs e)
        {
            // display the proper tooltip
            if (ObjectAtCursor != null && !String.IsNullOrWhiteSpace(ObjectAtCursor.ToolTip))
            {
                var s = ObjectAtCursor.ToolTip;
                toolTip1.Show(s, this, PointToClient(Control.MousePosition).X, PointToClient(Control.MousePosition).Y + 20);
            }

            ResetMouseEventArgs(); // not a very good solution
        }

        void MarkObject_Timer_Tick(object sender, EventArgs e)
        {
            MarkObject_BlinkCount++;
            if (MarkObject_BlinkCount < 10)
            {
                MarkObject_ShowMarker = !MarkObject_ShowMarker;
            }
            else
            {
                MarkObject_ShowMarker = false;
                MarkObject_Timer.Enabled = false;
                MarkObject_Marked = null;
            }
            Invalidate();
        }

        OverlayShapeVM PopupSource = null;
        bool PreventContextMenuOpening = false;
        ContextMenu TheContextMenu;
        private void CreateContextMenu()
        {
            var m = TheContextMenu = new ContextMenu();
            var i = new MenuItem("Jump to source");
            i.Click += (s, e) => { JumpToSourceDoIt(PopupSource); };
            m.MenuItems.Add(i);
            var ieditscope = i = new MenuItem("Edit this scope");
            i.Click += (s, e) => { TheOverlayModel.CurEditing = PopupSource as OverlayScope; };
            m.MenuItems.Add(i);

            var mm = new MenuItem("Assign style");
            var massignstyle = mm;
            i = new MenuItem("Assign new style...");
            i.Click += (s, e) => TheOverlayModel.AssignStyle(PdfOverlayModel.AssignStyleType.AssignNewStyle);
            mm.MenuItems.Add(i);
            i = new MenuItem("Assign current node style");
            i.Click += (s, e) => TheOverlayModel.AssignStyle(PdfOverlayModel.AssignStyleType.AssignCurrentNodeStyle);
            mm.MenuItems.Add(i);
            i = new MenuItem("Change style to new style...");
            i.Click += (s, e) => TheOverlayModel.AssignStyle(PdfOverlayModel.AssignStyleType.ChangeToNewStyle);
            mm.MenuItems.Add(i);
            i = new MenuItem("Change style to current node style");
            i.Click += (s, e) => TheOverlayModel.AssignStyle(PdfOverlayModel.AssignStyleType.ChangeToCurrentNodeStyle);
            mm.MenuItems.Add(i);
            m.MenuItems.Add(mm);

            var mselection = mm = new MenuItem("Selection");
            i = new MenuItem("Copy");
            i.Click += (s, e) => TheOverlayModel.PerformCodeBlockOperation(PdfOverlayModel.CodeBlockAction.Copy);
            mm.MenuItems.Add(i);
            i = new MenuItem("Copy enscoped");
            i.Click += (s, e) => TheOverlayModel.PerformCodeBlockOperation(PdfOverlayModel.CodeBlockAction.CopyEnscoped);
            mm.MenuItems.Add(i);
            i = new MenuItem("Cut");
            i.Click += (s, e) => TheOverlayModel.PerformCodeBlockOperation(PdfOverlayModel.CodeBlockAction.Cut);
            mm.MenuItems.Add(i);
            i = new MenuItem("Cut enscoped");
            i.Click += (s, e) => TheOverlayModel.PerformCodeBlockOperation(PdfOverlayModel.CodeBlockAction.CutEnscoped);
            mm.MenuItems.Add(i);
            i = new MenuItem("Delete");
            i.Click += (s, e) => TheOverlayModel.PerformCodeBlockOperation(PdfOverlayModel.CodeBlockAction.Delete);
            mm.MenuItems.Add(i);
            i = new MenuItem("Collect");
            i.Click += (s, e) => TheOverlayModel.PerformCodeBlockOperation(PdfOverlayModel.CodeBlockAction.Collect);
            mm.MenuItems.Add(i);
            i = new MenuItem("Collect and enscope");
            i.Click += (s, e) => TheOverlayModel.PerformCodeBlockOperation(PdfOverlayModel.CodeBlockAction.CollectEnscoped);
            mm.MenuItems.Add(i);
            m.MenuItems.Add(mm);

            m.Popup += (s, e) => { 
                PopupSource = ObjectAtCursor;
                massignstyle.Enabled = mselection.Enabled = TheOverlayModel.selectionTool.SelItems.Count() > 0;
                ieditscope.Enabled = (PopupSource is OverlayScope);
            };
            
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

            using (Pen pen = new Pen(Brushes.WhiteSmoke, 0.000001f))
            {
                dc.Transform = t;

                TheRasterModel.DrawRaster(
                    (p1, p2) => dc.DrawLine(pen, p1.ToPointF(), p2.ToPointF()),
                    (r1, r2) =>
                    {
                        float rr1 = (float)r1, rr2 = (float)r2;
                        dc.DrawEllipse(pen, -rr1, -rr2, 2 * rr1, 2 * rr2);
                    });
            }

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

            // draw the overlay
            if (ShowOverlay)
            {
                // draw shapes from parsetree
                //foreach (var osv in OSViews)
                    //osv.Draw(pe.Graphics);
                foreach (var os in TheOverlayModel.DisplayTree.AllItems)
                    os.Draw(dc, Height);

                // draw (visible) auxiliary shapes
                foreach (var ps in PreviewShapes.Where(o => o.Visible))
                    ps.Draw(pe.Graphics);

            }

            // draw adorner(s)
            foreach (var scope in this.TheOverlayModel.DisplayTree.AllItems.OfType<OverlayScope>().Where(v => v.IsCurEditing))
            {
                System.Windows.Rect ShowAt = scope.BB.UpsideDown(Height);
                ShowAt.Inflate(6, 6);

                dc.DrawRectangle(PensAndBrushes.AdornerPen, ShowAt.ToRectangleF());
            }


            // draw the object marker
            if (MarkObject_ShowMarker && MarkObject_Marked != null)
            {
                System.Windows.Rect ShowAt = MarkObject_Marked.BB.UpsideDown(Height);
                ShowAt.Inflate(15,15);
                using (Pen p = new Pen(Brushes.Red, 6))
                {
                    dc.DrawEllipse(p, ShowAt.ToRectangleF());
                }
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
            TheOverlayModel.DisplayTree.AdjustPositions();
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

        public static System.Windows.Point ToPoint(this System.Drawing.Point p)
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

    }
}
