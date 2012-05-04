using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TikzEdt.Overlay;
using TikzEdt;

namespace TikzEdtWForms
{


    public partial class RasterControl : Control
    {
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

        public PdfOverlayModel TheOverlayModel {get; private set;}

        Panel disablerPanel;

        private bool _ShowOverlay=true;

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

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            this.Focus();

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
                            TheContextMenu.Show(this, e.Location);
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

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            var mousep = e.Location.ToPoint();
            // convert to bottom left coordinates
            var p = new System.Windows.Point(mousep.X, Height - mousep.Y);

            TEMouseArgs ee = e.ToTEMouseArgs();
            TheOverlayModel.CurrentTool.OnMouseMove(p, ee);
            //GlobalUI.UI.AddStatusLine(this, "mm " + mousep+" " + CursorPosition);
            //e.Handled = ee.Handled;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

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

        protected override void  OnKeyDown(KeyEventArgs e)
        {
            //base.OnKeyDown(e);
            TEKeyArgs ee = e.ToTEKeyArgs();
            TheOverlayModel.CurrentTool.KeyDown(ee);
            e.Handled = ee.Handled;

            // turn off raster on Alt
            Rasterizer.View.OverrideWithZeroGridWidth = Control.ModifierKeys.HasFlag(Keys.Alt) && !Control.ModifierKeys.HasFlag(Keys.Shift);
            Rasterizer.View.OverrideWithHalfGridWidth = Control.ModifierKeys.HasFlag(Keys.Alt) && Control.ModifierKeys.HasFlag(Keys.Shift);

            if (e.KeyCode == Keys.Alt )
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
                    GlobalUI.UI.ShowMessageBox( "Currently pasting directly in the WYSIWYG area is not possible. However, you can paste into the code (text) field.",
                                                "Paste not possible", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (e.KeyCode == Keys.Delete)
                    TheOverlayModel.PerformCodeBlockOperation(PdfOverlayModel.CodeBlockAction.Delete);
            }

        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            //base.OnKeyUp(e);

            // route event to current tool
            TEKeyArgs ee = e.ToTEKeyArgs();
            TheOverlayModel.CurrentTool.KeyUp(ee);
            e.Handled = ee.Handled;

            // turn on raster on Alt released
            Rasterizer.View.OverrideWithZeroGridWidth = Control.ModifierKeys.HasFlag(Keys.Alt) && !Control.ModifierKeys.HasFlag(Keys.Shift);
            Rasterizer.View.OverrideWithHalfGridWidth = Control.ModifierKeys.HasFlag(Keys.Alt) && Control.ModifierKeys.HasFlag(Keys.Shift);

            if (e.KeyCode == Keys.Alt )
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
            set { 
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
            set 
            { 
                if (_UsePolarCoordinates != value)
                {
                    _UsePolarCoordinates = value;
                    if (UsePolarCoordinatesChanged != null)
                        UsePolarCoordinatesChanged(this, new EventArgs());
                    Invalidate();
                }
            }
        }
        public event EventHandler UsePolarCoordinatesChanged;

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
                    JumpToSource(this, new JumpToSourceEventArgs() { JumpToPos=o.item.StartPosition(), SelectionLength=o.item.text.Length });
            }
        }

        public void Clear()
        {
            OSViews.Clear();
            Invalidate();
        }

        public void SetCursor(Cursor cursor)
        {
            Cursor = cursor;
        }

        public bool MouseCaptured
        {
            set { Capture = value; }
            get { return Capture; }
        }

        /// <summary>
        /// The cursor position, in top left centric coordinates
        /// </summary>
        public System.Windows.Point CursorPosition
        {
            get { return PointToClient(Control.MousePosition).ToPoint(); }
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

    }

}
