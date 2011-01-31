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

        public Point RasterOrigin = new Point(0,0);
        public double RasterScale=1;
        private bool _IsCartesian = true;
        public bool IsCartesian
        {   
            get {return _IsCartesian; }
            set { _IsCartesian = value; DrawRaster(); }
        }

        // the scaled GridWidth
        double scGW
        {
            get { return GridWidth * RasterScale; }
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
                for (double x = Math.Ceiling((BB.X - RasterOrigin.X) / scGW) * scGW; x < BB.X - RasterOrigin.X + BB.Width; x += scGW)
                {
                    Line myLine = new Line();
                    myLine.Stroke = System.Windows.Media.Brushes.WhiteSmoke;
                    myLine.X1 = (x - BB.X + RasterOrigin.X) * Resolution;
                    myLine.X2 = myLine.X1;
                    myLine.Y1 = 0;
                    myLine.Y2 = Height;
                    canvas1.Children.Add(myLine);
                }

                for (double y = Math.Ceiling((BB.Y - RasterOrigin.Y) / scGW) * scGW; y < BB.Y - RasterOrigin.Y + BB.Height; y += scGW)
                {
                    Line myLine = new Line();
                    myLine.Stroke = System.Windows.Media.Brushes.WhiteSmoke;
                    myLine.X1 = 0;
                    myLine.X2 = Width;
                    myLine.Y1 = (y - BB.Y + RasterOrigin.Y) * Resolution;
                    myLine.Y2 = myLine.Y1;
                    canvas1.Children.Add(myLine);
                }
            }
            else
            {
                
                Point pixelorig = new Point((RasterOrigin.X-BB.X)*Resolution, (RasterOrigin.Y -BB.Y)*Resolution);
                double R = 2 * (BB.Width + BB.Height)/RasterScale;
                for (double r = 0; r < R; r += GridWidth)
                {
                    Ellipse el = new Ellipse();
                    el.Stroke = System.Windows.Media.Brushes.WhiteSmoke;
                    el.Height = 2 * r * Resolution * RasterScale;
                    el.Width = el.Height;
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
                    myLine.X2 = pixelorig.X + R * Resolution * Math.Cos(i *2* Math.PI / RadialSteps + RadialOffset);
                    myLine.Y2 = Height-( pixelorig.Y + R * Resolution * Math.Sin(i * 2 * Math.PI / RadialSteps + RadialOffset) );

                    canvas1.Children.Add(myLine);
                }


            }
        }

        /// <summary>
        /// Note: In polar coordinates X is the r-coordinate
        /// </summary>
        /// <param name="p">The point, in Tikz coordinates. In particular, in polar coordinates.</param>
        /// <returns>The rasterized point, in Tikz coordinates. In particular, in polar coordinates.</returns>
        public Point Rasterize(Point p)
        {
            if (scGW == 0)
                return p;
            if (IsCartesian)
            {
                return new Point(
                    Math.Round((p.X - RasterOrigin.X) / scGW) * scGW + RasterOrigin.X,
                    Math.Round((p.Y - RasterOrigin.Y) / scGW) * scGW + RasterOrigin.Y
                    );
            }
            else
            {
                return new Point(
                    Math.Round(p.X / (GridWidth *RasterScale )) * GridWidth*RasterScale,
                    Math.Round((p.Y - RadialOffset) / (2 * Math.PI / RadialSteps)) * (2 * Math.PI / RadialSteps) + RadialOffset
                    );
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

            if (IsCartesian)
            {
                pp = Rasterize(pp);                
            }
            else
            {
                pp = CartesianToPolar(pp);
                pp = Rasterize(pp);
                pp = PolarToCartesian(pp);
            }
            return new Point((pp.X - BB.X) * Resolution, (pp.Y - BB.Y) * Resolution);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p">The point, in Cartesian screen coordinates</param>
        /// <returns>The rasterized point, in Tikz coordinates. (polar for polar coordinates)</returns>
        public Point RasterizePixelToTikz(Point p)
        {
            Point pp = new Point(p.X / Resolution + BB.X, p.Y / Resolution + BB.Y);
            if (IsCartesian)
            {
                pp = Rasterize(pp);
            }
            else
            {
                pp = CartesianToPolar(pp);
                pp = Rasterize(pp);
            }
            return pp;
        }

        public Point PolarToCartesian(Point p)
        {
            return new Point(RasterOrigin.X + p.X * Math.Cos(p.Y), RasterOrigin.Y + p.X * Math.Sin(p.Y));
        }

        public Point CartesianToPolar(Point p)
        {
            Point pp = new Point(p.X-RasterOrigin.X, p.Y-RasterOrigin.Y);
            return CartToPol(pp);
        }

        public static Point CartToPol(Point p)
        {
            double r = Math.Sqrt(p.X * p.X + p.Y * p.Y);
            double phi = Math.Atan2(p.Y, p.X);
            return new Point(r, phi);
        }

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
