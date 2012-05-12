using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using TikzEdt.Parser;

namespace TikzEdt.Overlay
{

    /// <summary>
    /// Overlay Tools access the PdfOverlay control through this interface.
    /// It is used to hide the many irrelevant public members of PdfOverlay from
    /// tools.
    /// </summary>
    public interface IOverlayInterface
    {
        Parser.Tikz_ParseTree ParseTree { get; }

        bool AllowEditing { get; }

        TEModifierKeys KeyboardModifiers { get; }

        /// <summary>
        /// The tool must call this method before it makes changes to the parsetree.
        /// </summary>
        void BeginUpdate();
        /// <summary>
        /// The tool must call this method after all (...possibly multiple) changes to the parsetree are done.
        /// </summary>
        void EndUpdate();

        void SetCorrectRaster(OverlayShapeVM o, bool IsParent = false);
        void SetCorrectRaster(TikzParseItem tpi, bool IsParent = false);

        /// <summary>
        /// De-activates the current tool, and activates the default tool (i.e., select/move)
        /// </summary>
        void ActivateDefaultTool();

        RasterControlModel Rasterizer { get; }

        OverlayScope CurEditing { get; set; }
        double Resolution { get; }

        string NodeStyle { get; }
        string EdgeStyle { get; }

        Point ScreenToTikz(Point p, bool invY = false);
        Point TikzToScreen(Point p, bool invY = false);

        double Height { get; }
        double Width { get; }

        /// <summary>
        /// Determines whether to use absolute "", or relative "+" or "++" coordinates
        /// </summary>
        string NewNodeModifier { get; }
        /// <summary>
        /// Whether newly placed nodes shall be written in polar or euclidean coordinates.
        /// </summary>
        bool UsePolarCoordinates { get; }

        /// <summary>
        /// Jumps to the offset (in the code editor) of the provided overlayshape.
        /// </summary>
        /// <param name="o">Jumps to the TikzParseItem represented by o.</param>
        void JumpToSourceDoIt(OverlayShapeVM o);

        /// <summary>
        /// Provides (auxiliary) shapes that the tools may use for drawing, like the selection rectangle.
        /// </summary>
        IOverlayShapeFactory ShapeFactory { get; }


        void SetCursor(System.Windows.Forms.Cursor cursor);

        bool MouseCaptured { set; }

        Point CursorPosition { get; }

        OverlayShapeVM ObjectAtCursor { get; }

        TikzDisplayTree DisplayTree { get; }
    }

    /// <summary>
    /// The PdfOverlayModel accesses some properties in the view (i.e., the PdfOverlay control) through this interface.
    /// </summary>
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

        void MarkObject(OverlayShapeVM v);
        void JumpToSourceDoIt(OverlayShapeVM o);
        void RaiseReplaceText(ReplaceTextEventArgs e);
        void Clear();
        void SetCursor(System.Windows.Forms.Cursor cursor);

        bool MouseCaptured { set; }
        Point CursorPosition { get; }
        OverlayShapeVM ObjectAtCursor { get; }
    }

    /*
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
        OverlayShapeVM TheUnderlyingShape { get; set; }
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
    }*/

    /// <summary>
    /// The OverlayShapeFactory is used by the tools to create auxiliary (preview) shapes for drawing,
    /// like the selection rectangle.
    /// 
    /// It is not used to create the views for overlay shapes.
    /// </summary>
    public interface IOverlayShapeFactory
    {
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

    // the interfaces for shapes that are created by the OverlayShapeFactory
    #region previewshapes

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

    #endregion
}
