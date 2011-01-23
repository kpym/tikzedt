using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TikzEdt
{
    /// <summary>
    /// The class Rastercontrol has two responsibilities:
    /// 1. Visually draw a raster, Cartesian or polar, on the Screen
    /// 2. Rasterize (quantize) coordinates
    /// </summary>
    public partial class RasterControl : UserControl
    {
        public RasterControl()
        {
            InitializeComponent();
        }

        double _Resolution = Consts.ptspertikzunit;
        public double Resolution
        {
            get { return _Resolution; }
            set
            {
                _Resolution = value; 
                Width = Resolution * BB.Width;
                Height = Resolution * BB.Height;
                DrawRaster();
            }
        }

        double _GridWidth = Properties.Settings.Default.Raster_GridWidth;
        public double GridWidth
        {
            get { return _GridWidth; }
            set { _GridWidth = value; DrawRaster(); }
        }
        uint _RadialSteps = Properties.Settings.Default.Raster_RadSteps;
        public uint RadialSteps
        {
            //get { return Properties.Settings.Default.Raster_RadSteps; }
            get { return _RadialSteps; }
            set 
            { 
                _RadialSteps = value; 
                if (!IsCartesian)
                    DrawRaster();
            }
        }
        
        double _RadialOffset = Properties.Settings.Default.Raster_RadialOffset;
        /// <summary>
        /// Offset for phi=const coordinate lines, in radians. 0=east pole
        /// </summary>
        public double RadialOffset
        {
           // get { return Properties.Settings.Default.Raster_RadialOffset *Math.PI /180; }
            get { return _RadialOffset; }
            set
            {
                _RadialOffset = value;
                if (!IsCartesian)
                    DrawRaster();
            }
        }
        public int RadialOffsetInt
        {
            get { return Convert.ToInt32(RadialOffset); }
            set
            {
                RadialOffset = value * Math.PI / 180;                
            }
        }

        Rect _BB = new Rect(0,0,10,10);
        public Rect BB
        {
            get { return _BB; }
            set { _BB = value;
                Width = Resolution * BB.Width;
                Height = Resolution * BB.Height;     
                DrawRaster(); 
            }
        }

        private TikzEdt.Parser.TikzMatrix _CoordinateTransform = new Parser.TikzMatrix();
        public TikzEdt.Parser.TikzMatrix CoordinateTransform
        {
            get { return _CoordinateTransform; }
            set { 
                _CoordinateTransform = value.CloneIt();
                // temp
                //RasterScaleX = CoordinateTransform.m[0, 0];
                //RasterScaleY = CoordinateTransform.m[1, 1];
                //RasterOrigin = CoordinateTransform.Transform(new Point(0, 0));

                DrawRaster();
            }
        }

        //public Point RasterOrigin = new Point(0,0);
        //public double RasterScaleX = 1;
        //public double RasterScaleY = 1;
        private bool _IsCartesian = true;
        public bool IsCartesian
        {   
            get {return _IsCartesian; }
            set { _IsCartesian = value; DrawRaster(); }
        }

        // the scaled GridWidth
        /*double scGWX
        {
            get { return GridWidth * RasterScaleX; }
        }
        double scGWY
        {
            get { return GridWidth * RasterScaleY; }
        }*/

        /// <summary>
        /// This is the main routine, it does what one might guess.
        /// </summary>
        public void DrawRaster()
        {
            canvas1.Children.Clear();

            if (GridWidth <= 0)
                return;            
            /*if (IsCartesian)
            {
                for (double x = Math.Ceiling((BB.X - RasterOrigin.X) / scGWX) * scGWX; x < BB.X - RasterOrigin.X + BB.Width; x += scGWX)
                {
                    Line myLine = new Line();
                    myLine.Stroke = System.Windows.Media.Brushes.WhiteSmoke;
                    myLine.X1 = (x - BB.X + RasterOrigin.X) * Resolution;
                    myLine.X2 = myLine.X1;
                    myLine.Y1 = 0;
                    myLine.Y2 = Height;
                    canvas1.Children.Add(myLine);
                }

                for (double y = Math.Ceiling((BB.Y - RasterOrigin.Y) / scGWY) * scGWY; y < BB.Y - RasterOrigin.Y + BB.Height; y += scGWY)
                {
                    Line myLine = new Line();
                    myLine.Stroke = System.Windows.Media.Brushes.WhiteSmoke;
                    myLine.X1 = 0;
                    myLine.X2 = Width;
                    myLine.Y1 = Height - (y - BB.Y + RasterOrigin.Y) * Resolution;
                    myLine.Y2 = myLine.Y1;
                    canvas1.Children.Add(myLine);
                }
            }
            else
            {
                
                Point pixelorig = new Point((RasterOrigin.X-BB.X)*Resolution, (RasterOrigin.Y -BB.Y)*Resolution);
                double R = 2 * (BB.Width + BB.Height)/Math.Min(Math.Abs(RasterScaleX), Math.Abs(RasterScaleY));
                for (double r = 0; r < R; r += GridWidth)
                {
                    Ellipse el = new Ellipse();
                    el.Stroke = System.Windows.Media.Brushes.WhiteSmoke;
                    el.Height = 2 * r * Resolution * RasterScaleY;  
                    el.Width = 2 * r * Resolution * RasterScaleX;
                    Canvas.SetLeft(el, pixelorig.X - el.Width/2);
                    Canvas.SetBottom(el, pixelorig.Y - el.Height / 2);
                    canvas1.Children.Add(el);
                }

                for (int i=0;i<RadialSteps;i++)                    
                {
                    Line myLine = new Line();
                    myLine.Stroke = System.Windows.Media.Brushes.WhiteSmoke;
                    myLine.X1 = pixelorig.X;
                    myLine.Y1 = Height-pixelorig.Y;
                    myLine.X2 = pixelorig.X + R * Resolution * Math.Cos(i *2* Math.PI / RadialSteps + RadialOffset) *RasterScaleX;
                    myLine.Y2 = Height - (pixelorig.Y + R * Resolution * Math.Sin(i * 2 * Math.PI / RadialSteps + RadialOffset) * RasterScaleY);

                    canvas1.Children.Add(myLine);
                }


            } */

            Path p = new Path();
            p.Stroke = Brushes.WhiteSmoke;
            p.StrokeThickness = 1;
            p.Data = DrawRasterGeometry(EstimateRasterSteps());
            canvas1.Children.Add(p);
        }

        // estimate size of raster to be drawn, in number of steps
        int EstimateRasterSteps()
        {
            TikzEdt.Parser.TikzMatrix M = CoordinateTransform.Inverse();
            Point p1 = M.Transform(BB.BottomLeft), p2=BB.BottomRight, p3=BB.TopLeft, p4=BB.TopRight;
            double maxcoord = Math.Max(Math.Abs(p1.X), Math.Max(Math.Abs(p1.Y),
                Math.Max(Math.Abs(p2.X), Math.Max(Math.Abs(p2.Y),
                Math.Max(Math.Abs(p3.X), Math.Max(Math.Abs(p3.Y),
                Math.Max(Math.Abs(p4.X), Math.Abs(p4.Y))))))));
            return Convert.ToInt32(2 * maxcoord / GridWidth);
        }
        GeometryGroup DrawRasterGeometry(int rasterwidth)
        {
            GeometryGroup gc = new GeometryGroup();

            if (IsCartesian)
            {
                for (int i = -rasterwidth; i <= rasterwidth; i++)
                {
                    // draw both an x and a y coordinate line
                    LineGeometry lg = new LineGeometry(new Point(i * GridWidth, - rasterwidth * GridWidth),
                                                       new Point(i * GridWidth,   rasterwidth * GridWidth));
                    gc.Children.Add(lg);
                    lg = new LineGeometry(new Point(-rasterwidth * GridWidth, i * GridWidth),
                                          new Point( rasterwidth * GridWidth, i * GridWidth));
                    gc.Children.Add(lg);
                }
            }
            else
            {
                // draw circles
                for (int i = 1; i <= rasterwidth; i++)
                {
                    EllipseGeometry eg = new EllipseGeometry(new Point(0, 0), i * GridWidth, i * GridWidth);
                    gc.Children.Add(eg);
                }
                // draw radial lines
                for (int i = 0; i < RadialSteps; i++)
                {
                    LineGeometry lg = new LineGeometry( new Point(0, 0), 
                                                        new Point(rasterwidth * GridWidth *  Math.Cos(RadialOffset+ i*2*Math.PI/RadialSteps),
                                                                  rasterwidth * GridWidth *  Math.Sin(RadialOffset+ i*2*Math.PI/RadialSteps)));
                    gc.Children.Add(lg);
                }
            }

            // set transform
            gc.Transform = GetTikzToScreenTransform();

            gc.Freeze();
            return gc;
        }

        Transform GetTikzToScreenTransform()
        {
            Parser.TikzMatrix AbsTikzToScreen = new Parser.TikzMatrix();
            AbsTikzToScreen.m[0, 0] = Resolution;
            AbsTikzToScreen.m[1, 1] = -Resolution;
            AbsTikzToScreen.m[0, 2] = -Resolution * BB.X;
            AbsTikzToScreen.m[1, 2] = Resolution * (BB.Height + BB.Y);

            Parser.TikzMatrix total = AbsTikzToScreen * CoordinateTransform;
            return new MatrixTransform(total.ToWpfMatrix());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p">The point, in absolute Cartesian Tikz coordinates.</param>
        /// <returns>The rasterized point, in absolute Cartesian Tikz coordinates.</returns>
        public Point Rasterize(Point p)
        {
            //if (scGWX == 0 || scGWY == 0)
            if (GridWidth <= 0)
                return p;
            // transform to std coordinates
            Point pstd = CoordinateTransform.Inverse().Transform(p);
            Point pstd_rast;
            // Rasterize
            if (IsCartesian)
            {
                //return new Point(
                //    Math.Round((p.X - RasterOrigin.X) / scGWX) * scGWX + RasterOrigin.X,
                //    Math.Round((p.Y - RasterOrigin.Y) / scGWX) * scGWX + RasterOrigin.Y
                //    );
                pstd_rast = new Point(Math.Round(pstd.X / GridWidth) * GridWidth, Math.Round(pstd.Y / GridWidth) * GridWidth);
            }
            else
            {
                //Point polar = CartesianToPolar(p);
                //polar = new Point( Math.Round(polar.X / GridWidth)  * GridWidth,
                //                   Math.Round((polar.Y - RadialOffset) / (2 * Math.PI / RadialSteps)) * (2 * Math.PI / RadialSteps) + RadialOffset 
                //                   );

                //return PolarToCartesian(polar);

                Point polar = CartToPol(pstd);
                polar = new Point( Math.Round(polar.X / GridWidth)  * GridWidth,
                                   Math.Round((polar.Y - RadialOffset) / (2 * Math.PI / RadialSteps)) * (2 * Math.PI / RadialSteps) + RadialOffset 
                                   );
                pstd_rast = PolToCart(polar);
            }
            return CoordinateTransform.Transform(pstd_rast);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p">The point, in Cartesian screen coordinates. (bottom left centered)</param>
        /// <returns>The rasterized point, in Cartesian screen coordinates. </returns>
        public Point RasterizePixel(Point p)
        {
            Point pp = new Point(p.X/Resolution + BB.X, p.Y/Resolution + BB.Y); // point in absolute Cartesian tikz coordinates
            pp = Rasterize(pp);
            return new Point((pp.X - BB.X) * Resolution, (pp.Y - BB.Y) * Resolution);
        }
        /// <summary>
        /// Rasterizes a relative shift.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public Point RasterizePixelRelative(Point p)
        {
            Point pp = new Point(p.X / Resolution, p.Y / Resolution);
            pp = Rasterize(pp);
            return new Point((pp.X ) * Resolution, (pp.Y ) * Resolution);
        }
        /// <summary>
        /// The output is in absolute Cartesian Tikz coordinates (It disregards 
        /// the coordinate tranformation and Polar setting.)
        /// </summary>
        /// <param name="p">The point, in Cartesian screen coordinates</param>
        /// <returns>The rasterized point, in absolute Cartesian Tikz coordinates.</returns>
        public Point RasterizePixelToTikz(Point p)
        {
            Point pp = new Point(p.X / Resolution + BB.X, p.Y / Resolution + BB.Y);
            pp = Rasterize(pp);            
            return pp;
        }

        /// <summary>
        /// Convertes polar to Cartesian, USING THE COORDINATE TRANSFORM!
        /// (I.e., takes "normalized polar" coordinates.)
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        //public Point PolarToCartesian(Point p)
        //{
        //    Point pcart = PolToCart(p);
        //    return new Point(RasterOrigin.X + pcart.X * RasterScaleX, RasterOrigin.Y + pcart.Y * RasterScaleY);
        //}

        /// <summary>
        /// Convertes Cartesian to polar, USING THE COORDINATE TRANSFORM!
        /// (I.e., converts to "normalized polar" coordinates.)
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        //public Point CartesianToPolar(Point p)
        //{
        //    Point pp = new Point((p.X-RasterOrigin.X)/RasterScaleX, (p.Y-RasterOrigin.Y)/RasterScaleY);
        //    return CartToPol(pp);
        //}
        /// <summary>
        /// Converts Cartesian to polar (standard, does not use the coordinate transf.)
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Point CartToPol(Point p)
        {
            double r = Math.Sqrt(p.X * p.X + p.Y * p.Y);
            double phi = Math.Atan2(p.Y, p.X);
            return new Point(r, phi);
        }
        /// <summary>
        /// Converts polar to Cartesian (standard, does not use the coordinate transf.)
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Point PolToCart(Point p)
        {
            return new Point(p.X * Math.Cos(p.Y), p.X * Math.Sin(p.Y));
        }

        /// <summary>
        /// Tikz convention, i.e. (angle in degrees, radius) 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Point CartToPolTC(Point p)
        {
            Point pp = CartToPol(p);
            return new Point(
                Math.Round(180 * pp.Y / Math.PI),
                Math.Round(pp.X, (int)Properties.Settings.Default.RoundToDecimals)
                );            
        }

        public static Point PolToCartTC(Point p)
        {
            Point pp = new Point(p.Y, p.X * Math.PI / 180);
            return PolToCart(pp);
        }

    }
}
