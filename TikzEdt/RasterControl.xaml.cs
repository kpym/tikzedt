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

        private TikzEdt.Parser.TikzMatrix _CoordinateTransform;
        public TikzEdt.Parser.TikzMatrix CoordinateTransform
        {
            get { return _CoordinateTransform; }
            set { 
                _CoordinateTransform = value;
                // temp
                RasterScaleX = CoordinateTransform.m[0, 0];
                RasterScaleY = CoordinateTransform.m[1, 1];
                RasterOrigin = CoordinateTransform.Transform(new Point(0, 0));

                DrawRaster();
            }
        }

        public Point RasterOrigin = new Point(0,0);
        public double RasterScaleX = 1;
        public double RasterScaleY = 1;
        private bool _IsCartesian = true;
        public bool IsCartesian
        {   
            get {return _IsCartesian; }
            set { _IsCartesian = value; DrawRaster(); }
        }

        // the scaled GridWidth
        double scGWX
        {
            get { return GridWidth * RasterScaleX; }
        }
        double scGWY
        {
            get { return GridWidth * RasterScaleY; }
        }

        /// <summary>
        /// This is the main routine, it does what one might guess.
        /// </summary>
        public void DrawRaster()
        {
            canvas1.Children.Clear();

            if (GridWidth <= 0)
                return;            
            if (IsCartesian)
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


            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p">The point, in absolute Cartesian Tikz coordinates.</param>
        /// <returns>The rasterized point, in absolute Cartesian Tikz coordinates.</returns>
        public Point Rasterize(Point p)
        {
            if (scGWX == 0 || scGWY == 0)
                return p;
            if (IsCartesian)
            {
                return new Point(
                    Math.Round((p.X - RasterOrigin.X) / scGWX) * scGWX + RasterOrigin.X,
                    Math.Round((p.Y - RasterOrigin.Y) / scGWX) * scGWX + RasterOrigin.Y
                    );
            }
            else
            {
                Point polar = CartesianToPolar(p);
                polar = new Point( Math.Round(polar.X / GridWidth)  * GridWidth,
                                   Math.Round((polar.Y - RadialOffset) / (2 * Math.PI / RadialSteps)) * (2 * Math.PI / RadialSteps) + RadialOffset 
                                   );

                return PolarToCartesian(polar);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p">The point, in Cartesian screen coordinates</param>
        /// <returns>The rasterized point, in Cartesian screen coordinates. </returns>
        public Point RasterizePixel(Point p)
        {
            Point pp = new Point(p.X/Resolution + BB.X, p.Y/Resolution + BB.Y);
            pp = Rasterize(pp);
            return new Point((pp.X - BB.X) * Resolution, (pp.Y - BB.Y) * Resolution);
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
        public Point PolarToCartesian(Point p)
        {
            Point pcart = PolToCart(p);
            return new Point(RasterOrigin.X + pcart.X * RasterScaleX, RasterOrigin.Y + pcart.Y * RasterScaleY);
        }

        /// <summary>
        /// Convertes Cartesian to polar, USING THE COORDINATE TRANSFORM!
        /// (I.e., converts to "normalized polar" coordinates.)
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public Point CartesianToPolar(Point p)
        {
            Point pp = new Point((p.X-RasterOrigin.X)/RasterScaleX, (p.Y-RasterOrigin.Y)/RasterScaleY);
            return CartToPol(pp);
        }
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
