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
using Gtk;

namespace TikzEdtGTK
{
    public partial class RasterControl : DrawingArea, IRasterControlView, ITikzDisplayView, TikzEdt.Overlay.IPdfOverlayView, TikzEdt.Overlay.IOverlayShapeFactory
    {

        #region RasterControl

        public RasterControlModel TheRasterModel;
        ToolTip toolTip1 = new ToolTip();

        public RasterControl()
        {

            disablerPanel = new DrawingArea() ;//{ Opacit = Color.Transparent, Visible = false, Curso = Cursors.No }; 
            disablerPanel.TooltipText = "Overlay out of sync. WYSIWYG editing is disabled";
            //toolTip1.SetToolTip(disablerPanel, "Overlay out of sync. WYSIWYG editing is disabled");
    //        this.PackStart(disablerPanel, true, true,0);


            //toolTip1.SetToolTip(this, "The WYSIWYG area");
            //toolTip1.Popup += new PopupEventHandler(toolTip1_Popup);
            //toolTip1.ReshowDelay = 50;
            //toolTip1.InitialDelay = 100;
            //toolTip1.ShowAlways = true;
            toolTip1.Active = true;

            //todo this.MouseHover += new EventHandler(RasterControl_MouseHover);
            
            

            CreateContextMenu();

            //this.CanFocus = true;
            //this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.Selectable, true);
            DoubleBuffered = true;

            TheRasterModel = new RasterControlModel(this);

            TheDisplayModel = new TikzDisplayModel<Cairo.ImageSurface>(this, new PdfToBmpExtGTK());

            TheOverlayModel = new PdfOverlayModel(this, this);

            MarkObject_Timer.Interval = 500;
            MarkObject_Timer.Tick += new EventHandler(MarkObject_Timer_Tick);

            // listen to Bitmap changes
            MyBindings.Add(BindingFactory.CreateBinding(TheDisplayModel, "Bmp", (o) => this.Invalidate(), null));

        }

        public void Invalidate() { this.QueueDraw(); }

        void RasterControl_MouseHover(object sender, EventArgs e)
        {
            // display the proper tooltip
            /* todo
            if (ObjectAtCursor != null && !String.IsNullOrWhiteSpace((ObjectAtCursor.View as OverlayShapeView).ToolTip))
            {
                var s = (ObjectAtCursor.View as OverlayShapeView).ToolTip;
                toolTip1.Show(s, this, PointToClient(Control.MousePosition).X, PointToClient(Control.MousePosition).Y + 20);
            }
            
            ResetMouseEventArgs(); // not a very good solution
             * */
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

        OverlayShape PopupSource = null;
        bool PreventContextMenuOpening = false;
        Gtk.Menu TheContextMenu;
        private void CreateContextMenu()
        {
            var m = TheContextMenu = new Gtk.Menu();
            var i = new Gtk.MenuItem("Jump to source");
            i.Activated += (s, e) => { JumpToSourceDoIt(PopupSource); };
            m.Add(i);
            i = new Gtk.MenuItem("Edit this scope");
            i.Activated += (s, e) => { };
            m.Add(i);

            var mm = new Gtk.MenuItem("Assign style");
            i = new Gtk.MenuItem("Assign new style...");
            i.Activated += (s, e) => TheOverlayModel.AssignStyle(PdfOverlayModel.AssignStyleType.AssignNewStyle);
            var mmm = new Gtk.Menu();
            mm.Submenu = mmm;
            mmm.Add(i);
            i = new Gtk.MenuItem("Assign current node style");
            i.Activated += (s, e) => TheOverlayModel.AssignStyle(PdfOverlayModel.AssignStyleType.AssignCurrentNodeStyle);
            mmm.Add(i);
            i = new Gtk.MenuItem("Change style to new style...");
            i.Activated += (s, e) => TheOverlayModel.AssignStyle(PdfOverlayModel.AssignStyleType.ChangeToNewStyle);
            mmm.Add(i);
            i = new Gtk.MenuItem("Change style to current node style");
            i.Activated += (s, e) => TheOverlayModel.AssignStyle(PdfOverlayModel.AssignStyleType.ChangeToCurrentNodeStyle);
            mmm.Add(i);
            m.Add(mm);

            mm = new Gtk.MenuItem("Selection");
            mmm = new Gtk.Menu();
            mm.Submenu = mmm;
            i = new Gtk.MenuItem("Copy");
            i.Activated += (s, e) => TheOverlayModel.PerformCodeBlockOperation(PdfOverlayModel.CodeBlockAction.Copy);
            mmm.Add(i);
            i = new Gtk.MenuItem("Copy enscoped");
            i.Activated += (s, e) => TheOverlayModel.PerformCodeBlockOperation(PdfOverlayModel.CodeBlockAction.CopyEnscoped);
            mmm.Add(i);
            i = new Gtk.MenuItem("Cut");
            i.Activated += (s, e) => TheOverlayModel.PerformCodeBlockOperation(PdfOverlayModel.CodeBlockAction.Cut);
            mmm.Add(i);
            i = new Gtk.MenuItem("Cut enscoped");
            i.Activated += (s, e) => TheOverlayModel.PerformCodeBlockOperation(PdfOverlayModel.CodeBlockAction.CutEnscoped);
            mmm.Add(i);
            i = new Gtk.MenuItem("Delete");
            i.Activated += (s, e) => TheOverlayModel.PerformCodeBlockOperation(PdfOverlayModel.CodeBlockAction.Delete);
            mmm.Add(i);
            i = new Gtk.MenuItem("Collect");
            i.Activated += (s, e) => TheOverlayModel.PerformCodeBlockOperation(PdfOverlayModel.CodeBlockAction.Collect);
            mmm.Add(i);
            i = new Gtk.MenuItem("Collect and enscope");
            i.Activated += (s, e) => TheOverlayModel.PerformCodeBlockOperation(PdfOverlayModel.CodeBlockAction.CollectEnscoped);
            mmm.Add(i);
            m.Add(mm);

            m.PopupMenu += (s, e) => { PopupSource = ObjectAtCursor; };

        }

        List<object> MyBindings = new List<object>();

        protected override bool OnExposeEvent(Gdk.EventExpose args)
        {
            //base.OnPaint(pe);
            Cairo.Context dc = Gdk.CairoHelper.Create(args.Window);
            
            // Draw white background
            //Graphics dc = pe.Graphics;
            dc.IdentityMatrix();
            
            dc.SetSourceRGB(1.0, 1.0, 0.72);
            dc.Rectangle(0, 0, Allocation.Width, Allocation.Height);
            dc.Fill();

            // Draw the raster
            Cairo.Matrix t = TheRasterModel.GetTikzToScreenTransform().ToCairoMatrix();
            //t.Freeze();

            dc.SetSourceRGB(0.7, 0.7, 0.7); // whitesmoke?
            {
                dc.Transform( t );

                TheRasterModel.DrawRaster(
                    (p1, p2) => { dc.MoveTo(p1.X, p1.Y); dc.LineTo(p2.X, p2.Y); dc.Stroke(); },
                    (r1, r2) =>
                    {                 
                        dc.DrawEllipse( 0, 0, 2 * r1, 2 * r2);
                    });
            }

            dc.IdentityMatrix();

            // draw unavailable note
            if (TheDisplayModel.IsUnavailable)
            {
                dc.SetSourceRGB(0, 0, 0);
                dc.SelectFontFace("Arial", Cairo.FontSlant.Normal, Cairo.FontWeight.Normal);
                //StringFormat f = new StringFormat();
                //f.Alignment = StringAlignment.Center;
                //f.LineAlignment = StringAlignment.Center;
                //dc.DrawString("<Unavailable>", new Font("Arial", 16), Brushes.Black, ClientRectangle, f);
                dc.MoveTo(Allocation.Width/2, Allocation.Height/2); //todo
                dc.ShowText("<Unavailable>");
            }

            // draw the pdf image
            if (TheDisplayModel.IsImageVisible && TheDisplayModel.Bmp != null)
            {
                Point p = new Point((Allocation.Width - TheDisplayModel.Bmp.Width) / 2, (Allocation.Height - TheDisplayModel.Bmp.Height) / 2);
                //dc.DrawImageUnscaled(TheDisplayModel.Bmp, p);
                dc.SetSource(TheDisplayModel.Bmp, 0,0);
                dc.Rectangle(p.X, p.Y, TheDisplayModel.Bmp.Width, TheDisplayModel.Bmp.Height);
                dc.Paint();
            }

            // draw the overlay
            if (ShowOverlay)
            {
                // draw shapes from parsetree
                foreach (var osv in OSViews)
                    osv.Draw(dc);

                // draw (visible) auxiliary shapes
                foreach (var ps in PreviewShapes.Where(o => o.Visible))
                    ps.Draw(dc);

            }

            // draw adorner(s)
            foreach (var scope in this.OSViews.OfType<OverlayScopeView>().Where(v => v.IsAdornerVisible))
            {
                System.Windows.Rect ShowAt = scope.GetBB(Allocation.Height);
                ShowAt.Inflate(6, 6);

                dc.Rectangle(ShowAt.ToCairoRectangle());  //(PensAndBrushes.AdornerPen, ShowAt.ToRectangleF());
                dc.Stroke();
            }


            // draw the object marker
            if (MarkObject_ShowMarker && MarkObject_Marked != null)
            {
                System.Windows.Rect ShowAt = MarkObject_Marked.GetBB(Allocation.Height);
                ShowAt.Inflate(15, 15);
                using (Pen p = new Pen(Brushes.Red, 6))
                {
                    dc.SetSourceRGB(1, 0, 0);
                    dc.DrawEllipse(ShowAt);//p, 
                }
            }

            ((IDisposable)dc.Target).Dispose();
            ((IDisposable)dc).Dispose();

            return true;
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
            WidthRequest = Convert.ToInt32(Resolution * BB.Width);
            HeightRequest = Convert.ToInt32(Resolution * BB.Height);
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
    

    

#endregion

        #region TikzDisplay
        TikzDisplayModel<Cairo.ImageSurface> TheDisplayModel;

        string _PdfPath = null;
        public string PdfPath
        {
            get { return _PdfPath; }
            set { _PdfPath = value; TheDisplayModel.Refresh(); }
        }

        //int ITikzDisplayView.ReloadPdf
        public int ReloadPdf
        {
            get { return 0; }
            set { TheDisplayModel.RedrawBMP(true); }
        }

        bool _RenderTransparent = true;
        public bool RenderTransparent
        {
            get { return _RenderTransparent; }
            set { _RenderTransparent = value; TheDisplayModel.RedrawBMP(false); }
        }

        #endregion

        #region PdfOverlay

        ToolTip toolTip;
        List<OverlayShapeView> OSViews = new List<OverlayShapeView>();
        List<WFShapeBase> PreviewShapes = new List<WFShapeBase>();

        /// <summary>
        /// Controls where the object marker is shown if the object needs to be marked.
        /// </summary>
        IOverlayShapeView MarkObject_Marked = null;
        bool MarkObject_ShowMarker = false;
        System.Windows.Forms.Timer MarkObject_Timer = new Timer();
        int MarkObject_BlinkCount = 0;

        public PdfOverlayModel TheOverlayModel { get; private set; }

        Widget disablerPanel;

        private bool _ShowOverlay = true;

        public bool ShowOverlay
        {
            get { return _ShowOverlay; }
            set { _ShowOverlay = value; Invalidate(); }
        }

        #region events
        /// <summary>
        /// This event is called when user selectes Jump To Source on an Overlay item.
        /// The parameter sender will contain the TikzParseItem the user wants to jump to.
        /// (Call its StartPosition() method to determine the text offset.)
        /// The MainWindow should subscribe to this event and mark the appropriate segment in the text editor.
        /// </summary>
        public event EventHandler<JumpToSourceEventArgs> JumpToSource;
        public class JumpToSourceEventArgs : EventArgs
        {
            public int JumpToPos;
            public int SelectionLength;
        }

        /// <summary>
        /// This event is called when the user requests some edits to the text that cannot be done by editing the parsetree.
        /// (Note: currently the parsetree does not support deleting nodes.)
        /// The Codeblock-commands use this event
        /// </summary>
        public event EventHandler<ReplaceTextEventArgs> ReplaceText;

        /// <summary>
        /// Called whenever the tool changes.
        /// </summary>
        public event EventHandler ToolChanged;
        #endregion

        #region Mouse and Keyboard Event handling

        public double Height { get { return Allocation.Height; } }

        protected override bool OnButtonPressEvent(Gdk.EventButton evnt)
        {
            return base.OnButtonPressEvent(evnt);
        }
        protected override bool OnButtonReleaseEvent(Gdk.EventButton evnt)
        {
            return base.OnButtonReleaseEvent(evnt);
        }

        protected void OnMouseDown(MouseEventArgs e)
        {
           // base.OnMouseDown(e);
          //  this.Focus(); // todo

            if (e.Button.HasFlag(MouseButtons.Left))
            {
                // call left down-method in the current tool
                var mousep = e.Location.ToPoint();
                var oo = ObjectAtCursor;
                TEMouseArgs ee = e.ToTEMouseArgs();
                TheOverlayModel.CurrentTool.OnLeftMouseButtonDown(oo, new System.Windows.Point(mousep.X, Height - mousep.Y), ee);
                //e.Handled = ee.Handled;
            }
            else if (e.Button.HasFlag(MouseButtons.Right))
            {
                // call right down-method in the current tool
                var mousep = e.Location.ToPoint();
                var oo = ObjectAtCursor;
                TEMouseArgs ee = e.ToTEMouseArgs();
                TheOverlayModel.CurrentTool.OnRightMouseButtonDown(oo, new System.Windows.Point(mousep.X, Height - mousep.Y), ee);
                //e.Handled = ee.Handled;

                // if the tool didn't use the click-> proceed with standard handling
                if (!ee.Handled)
                {
                    if (Tool == OverlayToolType.move)
                    {
                        //canvas1.ContextMenu.IsEnabled = true;
                        if (TheOverlayModel.CurEditing != null)
                        {
                            TheOverlayModel.CurEditing = null;
                            //PreventContextMenuOpening = true;
                        }
                        else
                        {
                            // right click not consumed yet -> open context menu
                       //     TheContextMenu.Popup(this, null, (x,y, out  xx, out  xxx)=> {e.Location}, 0,2000); // todo
                        }
                    }
                    else
                    {
                        Tool = OverlayToolType.move;
                        //PreventContextMenuOpening = true;
                    }
                }
            }

        }
        
        protected void OnMouseMove(MouseEventArgs e)
        {
           // base.OnMouseMove(e);

            var mousep = e.Location.ToPoint();
            // convert to bottom left coordinates
            var p = new System.Windows.Point(mousep.X, Height - mousep.Y);

            TEMouseArgs ee = e.ToTEMouseArgs();
            TheOverlayModel.CurrentTool.OnMouseMove(p, ee);
            //GlobalUI.UI.AddStatusLine(this, "mm " + mousep+" " + CursorPosition);
            //e.Handled = ee.Handled;
        }

        protected  void OnMouseUp(MouseEventArgs e)
        {
          //  base.OnMouseUp(e);

            if (e.Button.HasFlag(MouseButtons.Left))
            {
                if (MouseCaptured)
                    MouseCaptured = false;  // release mouse capture here to make sure the tools cannot forget
                var mousep = e.Location.ToPoint();
                TEMouseArgs ee = e.ToTEMouseArgs();
                TheOverlayModel.CurrentTool.OnLeftMouseButtonUp(new System.Windows.Point(mousep.X, Height - mousep.Y), ee);
                //e.Handled = ee.Handled;

            }
            else if (e.Button.HasFlag(MouseButtons.Right))
            {

            }

        }
        protected override bool OnKeyPressEvent(Gdk.EventKey evnt)
        {
            return base.OnKeyPressEvent(evnt);
        }
        protected  void OnKeyDown(KeyEventArgs e)
        {
            //base.OnKeyDown(e);
            TEKeyArgs ee = e.ToTEKeyArgs();
            TheOverlayModel.CurrentTool.KeyDown(ee);
            e.Handled = ee.Handled;

            // turn off raster on Alt
            Rasterizer.View.OverrideWithZeroGridWidth = Control.ModifierKeys.HasFlag(Keys.Alt) && !Control.ModifierKeys.HasFlag(Keys.Shift);
            Rasterizer.View.OverrideWithHalfGridWidth = Control.ModifierKeys.HasFlag(Keys.Alt) && Control.ModifierKeys.HasFlag(Keys.Shift);

            if (e.KeyCode == Keys.Alt)
                e.Handled = true;

            if (!e.Handled)
            {
                // escape cancels current operation
                if (e.KeyCode == Keys.Escape)
                    TheOverlayModel.ActivateDefaultTool();

                if (e.KeyCode == Keys.C && e.Control)
                    TheOverlayModel.PerformCodeBlockOperation(PdfOverlayModel.CodeBlockAction.Copy);
                else if (e.KeyCode == Keys.X && e.Control)
                    TheOverlayModel.PerformCodeBlockOperation(PdfOverlayModel.CodeBlockAction.Cut);
                else if (e.KeyCode == Keys.V && e.Control)
                    GlobalUI.UI.ShowMessageBox("Currently pasting directly in the WYSIWYG area is not possible. However, you can paste into the code (text) field.",
                                                "Paste not possible", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (e.KeyCode == Keys.Delete)
                    TheOverlayModel.PerformCodeBlockOperation(PdfOverlayModel.CodeBlockAction.Delete);
            }

        }
        protected override bool OnKeyReleaseEvent(Gdk.EventKey evnt)
        {
            return base.OnKeyReleaseEvent(evnt);
        }
        protected  void OnKeyUp(KeyEventArgs e)
        {
            //base.OnKeyUp(e);

            // route event to current tool
            TEKeyArgs ee = e.ToTEKeyArgs();
            TheOverlayModel.CurrentTool.KeyUp(ee);
            e.Handled = ee.Handled;

            // turn on raster on Alt released
            Rasterizer.View.OverrideWithZeroGridWidth = Control.ModifierKeys.HasFlag(Keys.Alt) && !Control.ModifierKeys.HasFlag(Keys.Shift);
            Rasterizer.View.OverrideWithHalfGridWidth = Control.ModifierKeys.HasFlag(Keys.Alt) && Control.ModifierKeys.HasFlag(Keys.Shift);

            if (e.KeyCode == Keys.Alt)
                e.Handled = true;
        }

        #endregion

        #region IOverlayShapeFactory
        IOverlayShapeView IOverlayShapeFactory.NewNodeView()
        {
            var o = new OverlayNodeView(this);
            OSViews.Add(o);
            return o;
        }

        IOverlayScopeView IOverlayShapeFactory.NewScopeView()
        {
            var o = new OverlayScopeView(this);
            OSViews.Add(o);
            return o;
        }

        IOverlayCPView IOverlayShapeFactory.NewCPView()
        {
            var o = new OverlayCPView(this);
            OSViews.Add(o);
            return o;
        }

        IRectangleShape IOverlayShapeFactory.GetSelectionRect()
        {
            var o = new WFRectangleShape(this);
            o.ThePen = Pens.Blue;
            o.TheFill = PensAndBrushes.SelectionRectFill;
            PreviewShapes.Add(o);
            return o;
        }

        IRectangleShape IOverlayShapeFactory.GetCPCircle()
        {
            var o = new WFEllipseShape(this);
            o.SetPosition(0, 0, 10, 10);
            o.ThePen = Pens.Green;
            o.TheFill = Brushes.Gray;
            PreviewShapes.Add(o);
            return o;
        }

        IRectangleShape IOverlayShapeFactory.GetPreviewEllipse()
        {
            var o = new WFEllipseShape(this);
            o.ThePen = Pens.Black;
            PreviewShapes.Add(o);
            return o;
        }

        IRectangleShape IOverlayShapeFactory.GetPreviewRectangle()
        {
            var o = new WFRectangleShape(this);
            o.ThePen = Pens.Black;
            PreviewShapes.Add(o);
            return o;
        }

        IFanShape IOverlayShapeFactory.GetPreviewFan()
        {
            var o = new WFFanshape(this);
            o.ThePen = Pens.Black;
            PreviewShapes.Add(o);
            return o;
        }

        IRectangleShape IOverlayShapeFactory.GetPreviewGrid()
        {
            var o = new WFPreviewGridShape(this);
            o.ThePen = Pens.Black;
            PreviewShapes.Add(o);
            return o;
        }

        IArcShape IOverlayShapeFactory.GetPreviewArc()
        {
            var o = new WFArcShape(this);
            o.IsPie = false;
            o.ThePen = Pens.Black;
            PreviewShapes.Add(o);
            return o;
        }

        IArcShape IOverlayShapeFactory.GetPreviewPie()
        {
            var o = new WFArcShape(this);
            o.IsPie = true;
            o.ThePen = Pens.Black;
            PreviewShapes.Add(o);
            return o;
        }
        #endregion

        #region IPdfOverlayView

        private bool _AllowEditing;
        public bool AllowEditing
        {
            get { return _AllowEditing; }
            set
            {
                _AllowEditing = value;
                disablerPanel.Visible = !AllowEditing;
            }
        }

        void IPdfOverlayView.RaiseReplaceText(ReplaceTextEventArgs e)
        {
            if (ReplaceText != null)
                ReplaceText(this, e);
        }

        private string _EdgeStyle;

        public string EdgeStyle
        {
            get { return _EdgeStyle; }
            set { _EdgeStyle = value; }
        }

        private string _NewNodeModifier;

        public string NewNodeModifier
        {
            get { return _NewNodeModifier; }
            set { _NewNodeModifier = value; }
        }


        private string _NodeStyle;
        public string NodeStyle
        {
            get { return _NodeStyle; }
            set { _NodeStyle = value; }
        }


        private TikzEdt.Parser.Tikz_ParseTree _ParseTree;
        public TikzEdt.Parser.Tikz_ParseTree ParseTree
        {
            get { return _ParseTree; }
            set { if (_ParseTree != value) { _ParseTree = value; OnParseTreeChanged(); } }
        }
        void OnParseTreeChanged()
        {
            TheOverlayModel.CurrentTool.OnDeactivate();
            TheOverlayModel.CurrentTool.OnActivate();
            TheOverlayModel.RedrawObjects();
        }

        private TikzEdt.RasterControlModel _Rasterizer;
        public TikzEdt.RasterControlModel Rasterizer
        {
            get { return _Rasterizer; }
            set { _Rasterizer = value; }
        }

        private bool _UsePolarCoordinates;
        public bool UsePolarCoordinates
        {
            get { return _UsePolarCoordinates; }
            set { _UsePolarCoordinates = value; }
        }

        private TikzEdt.OverlayToolType _Tool = OverlayToolType.move;
        public TikzEdt.OverlayToolType Tool
        {
            get { return _Tool; }
            set
            {
                TheOverlayModel.ToolList[(int)_Tool].OnDeactivate();
                if (_Tool != value)
                {
                    _Tool = value;
                    if (ToolChanged != null)
                        ToolChanged(this, new EventArgs());
                }
                TheOverlayModel.CurrentTool.OnActivate();

            }
        }

        public TikzEdt.TEModifierKeys KeyboardModifiers
        {
            get
            {
                TEModifierKeys ret = TEModifierKeys.None;
                if (Control.ModifierKeys.HasFlag(Keys.Control)) ret |= TEModifierKeys.Control;
                if (Control.ModifierKeys.HasFlag(Keys.Alt)) ret |= TEModifierKeys.Alt;
                if (Control.ModifierKeys.HasFlag(Keys.Shift)) ret |= TEModifierKeys.Shift;
                return ret;
            }
        }

        public void MarkObject(IOverlayShapeView v)
        {
            MarkObject_Timer.Stop();
            MarkObject_BlinkCount = 0;
            MarkObject_Marked = v;
            MarkObject_ShowMarker = true;
            MarkObject_Timer.Start();
            Invalidate();
        }

        public void JumpToSourceDoIt(OverlayShape o)
        {
            if (o != null)
            {
                if (JumpToSource != null)
                    JumpToSource(this, new JumpToSourceEventArgs() { JumpToPos = o.item.StartPosition(), SelectionLength = o.item.text.Length });
            }
        }

        public void Clear()
        {
            OSViews.Clear();
            Invalidate();
        }

        void IPdfOverlayView.SetCursor(Cursor cursor)
        {
            //Cursor = cursor;
            this.GdkWindow.Cursor = new Gdk.Cursor(cursor.ToGdkCursorType());
        }

        public bool MouseCaptured  // TODOOOO
        {
            set {
                //Capture = value; 
            }
            get { //return Capture; 
                return false; 
            }
        }

        /// <summary>
        /// The cursor position, in top left centric coordinates
        /// </summary>
        public System.Windows.Point CursorPosition
        {
            get { 
                int x, y;
                this.GetPointer(out x, out y);
                return new System.Windows.Point(x, y);
            }
        }

        public OverlayShape ObjectAtCursor
        {
            get
            {
                if (OSViews.Count == 0)
                    return null;

                var p = CursorPosition;
                var res = OSViews.MinBy(o => o.HitTest(p.X, p.Y));

                if (res.Second > 10000)
                    return null;
                else return res.First.TheUnderlyingShape;
            }
        }

        #endregion

        #endregion
    }

    public static class Extensions2
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

        public static Cairo.Matrix ToCairoMatrix(this TikzEdt.Parser.TikzMatrix M)
        {
            Cairo.Matrix MM = new Cairo.Matrix(
                M.m[0, 0],
                M.m[0, 1],
                M.m[1, 0],
                M.m[1, 1],
                M.m[0, 2],
                M.m[1, 2]
            );
            return MM;
        }

        public static void DrawEllipse(this Cairo.Context dc, double x, double y, double width, double height)
        {
            dc.Save();
            dc.Translate(x + width / 2, y + height / 2);
            dc.Scale(width / 2, height / 2);
            dc.Arc(0, 0, 1, 0, 2 * Math.PI);

            //dc.fill.SetupFill();
            //dc.fill_preserve()
            //dc.SetupStroke()
            dc.Stroke();

            dc.Restore();
        }
        public static void DrawEllipse(this Cairo.Context dc, System.Windows.Rect r )
        {
            dc.DrawEllipse(r.Center().X, r.Center().Y, r.Width, r.Height);
        }

        public static void FillEllipse(this Cairo.Context dc, System.Windows.Rect r)
        {
            dc.FillEllipse(r.Center().X, r.Center().Y, r.Width, r.Height);
        }
        public static void FillEllipse(this Cairo.Context dc, double x, double y, double width, double height)
        {
            dc.Save();
            dc.Translate(x + width / 2, y + height / 2);
            dc.Scale(width / 2, height / 2);
            dc.Arc(0, 0, 1, 0, 2 * Math.PI);

            //dc.fill.SetupFill();
            //dc.fill_preserve()
            //dc.SetupStroke()
            dc.Fill();
            dc.Restore();
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
            return new System.Windows.Point(p.X, p.Y);
        }

        public static System.Drawing.RectangleF ToRectangleF(this System.Windows.Rect r)
        {
            return new RectangleF((float)r.X, (float)r.Y, (float)r.Width, (float)r.Height);
        }
        public static Cairo.Rectangle ToCairoRectangle(this System.Windows.Rect r)
        {
            return new Cairo.Rectangle(r.X,r.Y, r.Width, r.Height);
        }

        public static void DrawLine(this Cairo.Context dc, System.Windows.Point p1, System.Windows.Point p2)
        {
            dc.MoveTo(p1.X, p1.Y);
            dc.LineTo(p2.X, p2.Y);
            dc.Stroke();
        }
        public static void DrawLine(this Cairo.Context dc, double x1, double y1, double x2, double y2)
        {
            dc.DrawLine(new System.Windows.Point(x1, y1), new System.Windows.Point(x2, y2));
        }

        // todo
        public static void DrawBeziers(this Cairo.Context dc, System.Windows.Point[] pts)
        {
            //dc.DrawLine( new System.Windows.Point(x1,y1), new System.Windows.Point(x2,y2))
        }

        public static System.Drawing.RectangleF ToRectangleF(this Rectangle r)
        {
            return new RectangleF((float)r.X, (float)r.Y, (float)r.Width, (float)r.Height);
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

        public static Gdk.CursorType ToGdkCursorType(this Cursor c)
        {
            if (c == Cursors.Cross)
                return Gdk.CursorType.Cross;
            else if (c == Cursors.No)
                return Gdk.CursorType.Fleur;
            else if (c == Cursors.SizeAll)
                return Gdk.CursorType.Hand2;
            else if (c == Cursors.UpArrow)
                return Gdk.CursorType.BasedArrowUp;
            else return Gdk.CursorType.Arrow;
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
