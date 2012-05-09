using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace TikzEdt.Overlay
{

    public interface IPdfOverlayView
    {
        bool AllowEditing { get; set; }
        System.Windows.Rect BB { get; set; }
        string EdgeStyle { get; set; }
        string NewNodeModifier { get; set; }
        string NodeStyle { get; set; }
        TikzEdt.Parser.Tikz_ParseTree ParseTree { get; set; }
        TikzEdt.RasterControlModel Rasterizer { get; set; }
        double Resolution { get; set; }
        bool UsePolarCoordinates { get; set; }
        OverlayToolType Tool { get; set; }

        TEModifierKeys KeyboardModifiers { get; }

        void MarkObject(IOverlayShapeView v);
        void JumpToSourceDoIt(OverlayShape o);
        void RaiseReplaceText(ReplaceTextEventArgs e);
        void Clear();
        void SetCursor(System.Windows.Forms.Cursor cursor);

        bool MouseCaptured { set; }
        Point CursorPosition { get; }
        OverlayShape ObjectAtCursor { get; }
    }

    public interface IOverlayShapeView
    {
        /// <summary>
        /// Sets the position of the shape on screen.
        /// For Nodes, this is the center of the node. For scopes, the lower right.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="bottom"></param>
        /// <param name="Relative"></param>
        void SetPosition(double left, double bottom, bool Relative = false);
        double GetLeft();
        double GetBottom();

        /// <summary>
        /// In top left centric coordinates.
        /// </summary>
        Rect GetBB(double CanvasHeight);
        void SetStdColor();
        void SetSelColor();
        void SetToolTip(string Text);

        /// <summary>
        /// The underlying OverlayShape. Mustbe filled by the OverlayShape that creates the View.
        /// </summary>
        OverlayShape TheUnderlyingShape { get; set; }
    }
    public interface IOverlayScopeView : IOverlayShapeView
    {
        void SetSize(double Width, double Height);
        void ShowAdorner();
        void RemoveAdorner();
    }
    public interface IOverlayCPView : IOverlayShapeView
    {
        /// <summary>
        /// Sets the second endpoint of the line connecting the control point with its origin.
        /// </summary>
        /// <param name="Left"></param>
        /// <param name="Bottom"></param>
        void SetOrigin1(double Left, double Top, double CanvasHeight);
        void SetOrigin2(double Left, double Top, double CanvasHeight);
    }

    public interface IOverlayShapeFactory
    {
        // the following methods create views of objects in the parse tree
        IOverlayShapeView NewNodeView();
        IOverlayScopeView NewScopeView();
        IOverlayCPView NewCPView();

        // the following methods produce geometric shapes for (preview) use in the tools
        // they are not backed by an object in the parsetree
        IRectangleShape GetSelectionRect();
        IRectangleShape GetCPCircle();
        IRectangleShape GetPreviewEllipse();
        IRectangleShape GetPreviewRectangle();
        IFanShape GetPreviewFan();
        IRectangleShape GetPreviewGrid();
        IArcShape GetPreviewArc();
        IArcShape GetPreviewPie();
    }

    public interface IPreviewShape
    {
        Rect GetBB();
        bool Visible { get; set; }
        /// <summary>
        /// Determines the rotation of the shape in radians.
        /// </summary>
        double Rotation { set; }

        void Refresh();
    }

    public interface IRectangleShape : IPreviewShape
    {
        void SetPosition(double Left, double Top, double Width, double Height);
        void SetCenter(double Left, double Bottom);
    }

    public interface IFanShape : IPreviewShape
    {
        double R { get; set; }
        Point Center { get; set; }
        List<double> Spokes { get; set; }
    }

    public interface IArcShape : IPreviewShape
    {
        Point p1 { get; set; }
        Point p2 { get; set; }
        Point center { get; set; }
        bool IsLargeArc { get; set; }
        /// <summary>
        /// Makes shape dashed and Gray instead of solid black
        /// </summary>
        bool IsDashed { set; }
    }


}
