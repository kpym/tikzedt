using System;
using System.Windows;
namespace TikzEdt
{
    /// <summary>
    /// The properties the rastercontrol exposes to the GUI framework.
    /// </summary>
    public interface IRasterControlView
    {
        System.Windows.Rect BB { get; set; }
        TikzEdt.Parser.TikzMatrix CoordinateTransform { get; set; }
        double ForceRadiusTo { get; set; }       
        bool IsCartesian { get; set; }
        bool OverrideWithHalfGridWidth { get; set; }
        bool OverrideWithZeroGridWidth { get; set; }
        double RadialOffset { get; set; }
        uint RasterRadialSteps { get; set; }
        double RasterWidth { get; set; }
        double Resolution { get; set; }
        bool ShowRaster { get; set; }
        
    }

    /// <summary>
    /// Contains the underlying control logic of the Raster Control.
    /// Should not contain GUI framework dependent methods.
    /// </summary>
    public class RasterControlModel
    {
        public IRasterControlView View { get; private set; }
        public RasterControlModel(IRasterControlView View)
        {
            this.View = View;
        }

        #region public methods
        /// <summary>
        /// Resets the raster to some default values
        /// </summary>
        public void ResetRaster()
        {
            View.ForceRadiusTo = -1;
            View.IsCartesian = true;
            View.CoordinateTransform = new Parser.TikzMatrix(); // unit matrix            
        }


        /// <summary>
        ///  Estimate size of raster to be drawn, in number of steps.
        /// </summary>
        /// <returns></returns>
        int EstimateRasterSteps()
        {
            TikzEdt.Parser.TikzMatrix M = View.CoordinateTransform.Inverse();
            Point p1 = M.Transform(View.BB.BottomLeft), p2 = View.BB.BottomRight, p3 = View.BB.TopLeft, p4 = View.BB.TopRight;
            double maxcoord = Math.Max(Math.Abs(p1.X), Math.Max(Math.Abs(p1.Y),
                Math.Max(Math.Abs(p2.X), Math.Max(Math.Abs(p2.Y),
                Math.Max(Math.Abs(p3.X), Math.Max(Math.Abs(p3.Y),
                Math.Max(Math.Abs(p4.X), Math.Abs(p4.Y))))))));
            if (maxcoord > 0) //if scale=0 maxcoord==NaN just return 0 then.
                return Convert.ToInt32(2 * maxcoord / GridWidth);
            return 0;
        }

        /// <summary>
        /// Returns the transformation matrix from Tikz coordinates to Screen coordinates.
        /// (Note: Tikz coordinates are bottom left centric, screen coordinates are top left centric.)
        /// </summary>
        /// <returns></returns>
        public Parser.TikzMatrix GetTikzToScreenTransform()
        {
            Parser.TikzMatrix AbsTikzToScreen = new Parser.TikzMatrix();
            AbsTikzToScreen.m[0, 0] = View.Resolution;
            AbsTikzToScreen.m[1, 1] = -View.Resolution;
            AbsTikzToScreen.m[0, 2] = -View.Resolution * View.BB.X;
            AbsTikzToScreen.m[1, 2] = View.Resolution * (View.BB.Height + View.BB.Y);

            Parser.TikzMatrix total = AbsTikzToScreen * View.CoordinateTransform;
            return total;
        }

        /// <summary>
        /// Draws the raster in a GUI framework independent way.
        /// Hence methods have to be provided to draw lines and ellipses.
        /// Both methods must still apply the transformation from Tikz to screen coordinates.
        /// </summary>
        /// <param name="LineDrawMethod">This method takes two points (in TIKZ coordinates) and draws a line between them.</param>
        /// <param name="EllipseDrawMethod">This method takes two radii and draws an ellipse centered at (0,0) (in Tikz coordinates) with these radii.</param>
        public void DrawRaster(Action<Point, Point> LineDrawMethod, Action<double, double> EllipseDrawMethod)
        {
            if (GridWidth <= 0 || !View.ShowRaster)
                return;

            int rasterwidth = EstimateRasterSteps();

            if (View.IsCartesian)
            {
                for (int i = -rasterwidth; i <= rasterwidth; i++)
                {
                    // draw both an x and a y coordinate line
                    LineDrawMethod(new Point(i * GridWidth, -rasterwidth * GridWidth), new Point(i * GridWidth, rasterwidth * GridWidth));
                    LineDrawMethod(new Point(-rasterwidth * GridWidth, i * GridWidth), new Point(rasterwidth * GridWidth, i * GridWidth));
                }
            }
            else
            {
                // draw circles
                for (int i = 1; i <= rasterwidth; i++)
                {
                    EllipseDrawMethod(i * GridWidth, i * GridWidth);
                }

                // draw radial lines
                for (int i = 0; i < RadialSteps; i++)
                {
                    LineDrawMethod( new Point(0, 0),new Point(rasterwidth * GridWidth * Math.Cos(View.RadialOffset + i * 2 * Math.PI / RadialSteps),
                                                            rasterwidth * GridWidth * Math.Sin(View.RadialOffset + i * 2 * Math.PI / RadialSteps)) );
                }
            }
        }

        #endregion


        #region Derived Properties

        /// <summary>
        /// Same as RasterRadialSteps, with modififers (OverrideWithHalfGridWidth) applied.
        /// </summary>
        private uint RadialSteps
        {
            get
            {
                if (View.OverrideWithHalfGridWidth)
                    return 2 * View.RasterRadialSteps;
                else
                    return View.RasterRadialSteps;
            }
        }


        /// <summary>
        /// Gridwidth is the width of the raster after modifiers (OverrideWithZeroGridWidth or OverrideWithHalfGridWidth)
        /// </summary>
        public double GridWidth
        {
            get
            {
                if (View.OverrideWithZeroGridWidth)
                    return 0;
                else if (View.OverrideWithHalfGridWidth)
                    return View.RasterWidth / 2;
                else
                    return View.RasterWidth;
            }
            //set { RasterWidth = value; }
        }


        #endregion


        #region public rasterization functions
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p">The point, in absolute Cartesian Tikz coordinates.</param>
        /// <param name="IsRelative">Specifies whether the point is a shift, rather than an absolute position.</param>
        /// <returns>The rasterized point, in absolute Cartesian Tikz coordinates.</returns>
        public Point Rasterize(Point p, bool IsRelative = false)
        {
            if (GridWidth <= 0)
                return p;
            // transform to std coordinates
            Point pstd = View.CoordinateTransform.Inverse().Transform(p, IsRelative);
            Point pstd_rast;
            // Rasterize
            if (View.IsCartesian)
            {
                pstd_rast = new Point(Math.Round(pstd.X / GridWidth) * GridWidth, Math.Round(pstd.Y / GridWidth) * GridWidth);
            }
            else
            {
                Point polar = TikzEdt.Parser.Helper.CartToPol(pstd);
                polar = new Point(Math.Round(polar.X / GridWidth) * GridWidth,
                                   Math.Round((polar.Y - View.RadialOffset) / (2 * Math.PI / RadialSteps)) * (2 * Math.PI / RadialSteps) + View.RadialOffset
                                   );
                if (View.ForceRadiusTo >= 0)
                    polar = new Point(View.ForceRadiusTo, polar.Y);
                pstd_rast = TikzEdt.Parser.Helper.PolToCart(polar);
            }
            return View.CoordinateTransform.Transform(pstd_rast, IsRelative);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p">The point, in Cartesian screen coordinates. (bottom left centered)</param>
        /// <returns>The rasterized point, in Cartesian screen coordinates. </returns>
        public Point RasterizePixel(Point p)
        {
            Point pp = new Point(p.X / View.Resolution + View.BB.X, p.Y / View.Resolution + View.BB.Y); // point in absolute Cartesian tikz coordinates
            pp = Rasterize(pp);
            return new Point((pp.X - View.BB.X) * View.Resolution, (pp.Y - View.BB.Y) * View.Resolution);
        }
        /// <summary>
        /// Rasterizes a relative shift.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public Point RasterizePixelRelative(Point p)
        {
            Point pp = new Point(p.X / View.Resolution, p.Y / View.Resolution);
            pp = Rasterize(pp, true);
            return new Point((pp.X) * View.Resolution, (pp.Y) * View.Resolution);
        }
        /// <summary>
        /// The output is in absolute Cartesian Tikz coordinates (It disregards 
        /// the coordinate tranformation and Polar setting.)
        /// </summary>
        /// <param name="p">The point, in Cartesian screen coordinates</param>
        /// <returns>The rasterized point, in absolute Cartesian Tikz coordinates.</returns>
        public Point RasterizePixelToTikz(Point p)
        {
            Point pp = new Point(p.X / View.Resolution + View.BB.X, p.Y / View.Resolution + View.BB.Y);
            pp = Rasterize(pp);
            return pp;
        }

        #endregion

    }
}
