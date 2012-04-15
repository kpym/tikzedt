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
    public partial class PdfOverlay : Control, IPdfOverlayView, IOverlayShapeFactory
    {
        ToolTip toolTip;
        List<OverlayShapeView> OSViews = new List<OverlayShapeView>();
        

        public PdfOverlay()
        {
            InitializeComponent();

            toolTip = new ToolTip();
            toolTip.SetToolTip(this, "Hallo Welt");
            toolTip.Popup += new PopupEventHandler(toolTip_Popup);


        }

        void toolTip_Popup(object sender, PopupEventArgs e)
        {
            
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

        }



        private bool _AllowEditing;
        public bool AllowEditing
        {
            get { return _AllowEditing; }
            set { _AllowEditing = value; }
        }


        private System.Windows.Rect _BB;
        public System.Windows.Rect BB
        {
            get { return _BB; }
            set { _BB = value; }
        }

        private string _EdgeStyle;

        public string EdgeStyle
        {
            get { return _EdgeStyle; }
            set { _EdgeStyle = value; }
        }

        private string  _NewNodeModifier;

        public string  NewNodeModifier
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
            set { _ParseTree = value; }
        }

        private TikzEdt.RasterControlModel _Rasterizer;

        public TikzEdt.RasterControlModel Rasterizer
        {
            get { return _Rasterizer; }
            set { _Rasterizer = value; }
        }

        private double _Resolution = Consts.ptspertikzunit;

        public double Resolution
        {
            get { return _Resolution; }
            set { _Resolution = value; }
        }

        private bool _UsePolarCoordinates;

        public bool UsePolarCoordinates
        {
            get { return _UsePolarCoordinates; }
            set { _UsePolarCoordinates = value; }
        }

        private TikzEdt.OverlayToolType _Tool;

        public TikzEdt.OverlayToolType Tool
        {
            get { return _Tool; }
            set { _Tool = value; }
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
            throw new NotImplementedException();
        }

        public void JumpToSourceDoIt(OverlayShape o)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void SetCursor(Cursor cursor)
        {
            Cursor = cursor;
        }

        public bool MouseCaptured
        {
            set { Capture = value; }
        }

        public System.Windows.Point CursorPosition
        {
            get { return Control.MousePosition.ToPoint(); }
        }

        public OverlayShape ObjectAtCursor
        {
            get { throw new NotImplementedException(); }
        }

        IOverlayShapeView IOverlayShapeFactory.NewNodeView()
        {
            throw new NotImplementedException();
        }

        IOverlayScopeView IOverlayShapeFactory.NewScopeView()
        {
            throw new NotImplementedException();
        }

        IOverlayCPView IOverlayShapeFactory.NewCPView()
        {
            throw new NotImplementedException();
        }

        IRectangleShape IOverlayShapeFactory.GetSelectionRect()
        {
            throw new NotImplementedException();
        }

        IRectangleShape IOverlayShapeFactory.GetCPCircle()
        {
            throw new NotImplementedException();
        }

        IRectangleShape IOverlayShapeFactory.GetPreviewEllipse()
        {
            throw new NotImplementedException();
        }

        IRectangleShape IOverlayShapeFactory.GetPreviewRectangle()
        {
            throw new NotImplementedException();
        }

        IFanShape IOverlayShapeFactory.GetPreviewFan()
        {
            throw new NotImplementedException();
        }

        IRectangleShape IOverlayShapeFactory.GetPreviewGrid()
        {
            throw new NotImplementedException();
        }

        IArcShape IOverlayShapeFactory.GetPreviewArc()
        {
            throw new NotImplementedException();
        }

        IArcShape IOverlayShapeFactory.GetPreviewPie()
        {
            throw new NotImplementedException();
        }
    }
}
