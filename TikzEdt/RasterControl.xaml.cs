/*This file is part of TikzEdt.
 
TikzEdt is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.
 
TikzEdt is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
GNU General Public License for more details.
 
You should have received a copy of the GNU General Public License
along with TikzEdt.  If not, see <http://www.gnu.org/licenses/>.*/

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
            ClipToBounds = true;
            // these settings are to improve rendering speed
            RenderOptions.SetEdgeMode(this, EdgeMode.Aliased);
            IsHitTestVisible = false;
        }

        readonly public static DependencyProperty ResolutionProperty = DependencyProperty.Register(
  "Resolution", typeof(double), typeof(RasterControl), new PropertyMetadata(Consts.ptspertikzunit,
      new PropertyChangedCallback(OnBBChanged)));
        /// <summary>
        /// The current bounding box.
        /// </summary>
        public double Resolution
        {
            get { return (double)GetValue(ResolutionProperty); }
            set { SetValue(ResolutionProperty, value); }
        }
        void AdjustSize()
        {
            Width = Resolution * BB.Width;
            Height = Resolution * BB.Height;
            DrawRaster();
        }
        readonly public static DependencyProperty BBProperty = DependencyProperty.Register(
            "BB", typeof(Rect), typeof(RasterControl), new PropertyMetadata(new Rect(0, 0, 10, 10),
                new PropertyChangedCallback(OnBBChanged)));
        static void OnBBChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            RasterControl rc = d as RasterControl;
            rc.AdjustSize();
        }
        /// <summary>
        /// The current bounding box.
        /// </summary>
        public Rect BB
        {
            get { return (Rect)GetValue(BBProperty); }
            set { SetValue(BBProperty, value); }
        }

        readonly public static DependencyProperty ShowRasterProperty = DependencyProperty.Register(
            "ShowRaster", typeof(bool), typeof(RasterControl), new PropertyMetadata(true,
                new PropertyChangedCallback(OnBBChanged)));
        /// <summary>
        /// Use this to temporarily turn off display of the raster (... the white background is still displayed).
        /// </summary>
        public bool ShowRaster
        {
            get { return (bool)GetValue(ShowRasterProperty); }
            set { SetValue(ShowRasterProperty, value); }
        }


        bool _OverrideWithZeroGridWidth = false;
        // use this to set GridWidth to zero temporarily (e.g., on ALT pressed)
        public bool OverrideWithZeroGridWidth
        {
            set { _OverrideWithZeroGridWidth = value; DrawRaster(); }
            get { return _OverrideWithZeroGridWidth; }
        }

        bool _OverrideWithHalfGridWidth = false;
        // use this to set GridWidth to zero temporarily (e.g., on ALT pressed)
        public bool OverrideWithHalfGridWidth
        {
            set { _OverrideWithHalfGridWidth = value; DrawRaster(); }
            get { return _OverrideWithHalfGridWidth; }
        }

        /// <summary>
        /// RasterWidth is the raw width of the raster, before modifiers
        /// </summary>
        public double RasterWidth
        {
            get { return (double)GetValue(RasterWidthProperty); }
            set { SetValue(RasterWidthProperty, value); }
        }
        public static readonly DependencyProperty RasterWidthProperty =
            DependencyProperty.Register("RasterWidth", typeof(double), typeof(RasterControl), new UIPropertyMetadata(Properties.Settings.Default.Raster_GridWidth, OnBBChanged));


        //double _GridWidth = Properties.Settings.Default.Raster_GridWidth;
        /// <summary>
        /// Gridwidth is the width of the raster after modifiers (OverrideWithZeroGridWidth or OverrideWithHalfGridWidth)
        /// </summary>
        public double GridWidth
        {
            get
            {
                if (OverrideWithZeroGridWidth)
                    return 0;
                else if (OverrideWithHalfGridWidth)
                    return RasterWidth / 2;
                else
                    return RasterWidth;
            }
            set { RasterWidth = value; }
        }

        double _ForceRadiusTo = -1;
        /// <summary>
        /// Determines whether the radius of the rasterized point is fixed to ForceRadiusTo.
        /// This is used for situations (arc editing) where the radius is fixed and only the angular parameter 
        /// can vary. Is ignored if negative, of is IsCartesian = true.
        /// 
        /// Note: the radius is in the transformed coordinate system, not absolute !!
        /// (Otherwise it wouldn't make sense, say, with anisotropic scaling.)
        /// </summary>
        public double ForceRadiusTo
        {
            get { return _ForceRadiusTo; }
            set { _ForceRadiusTo = value; }
        }



        public uint RasterRadialSteps
        {
            get { return (uint)GetValue(RasterRadialStepsProperty); }
            set { SetValue(RasterRadialStepsProperty, value); }
        }
        public static readonly DependencyProperty RasterRadialStepsProperty =
            DependencyProperty.Register("RasterRadialSteps", typeof(uint), typeof(RasterControl), new UIPropertyMetadata(Properties.Settings.Default.Raster_RadSteps, OnBBChanged));        
        //uint _RadialSteps = Properties.Settings.Default.Raster_RadSteps;
        public uint RadialSteps
        {
            //get { return Properties.Settings.Default.Raster_RadSteps; }
            get {
                if (OverrideWithHalfGridWidth)
                    return 2 * RasterRadialSteps;
                else
                    return RasterRadialSteps;
            }
            set 
            {
                RasterRadialSteps = value; 
            }
        }


        /// <summary>
        /// Offset for phi=const coordinate lines, in radians. 0=east pole
        /// </summary>
        public double RadialOffset
        {
            get { return (double)GetValue(RadialOffsetProperty); }
            set { SetValue(RadialOffsetProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RadialOffset.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RadialOffsetProperty =
            DependencyProperty.Register("RadialOffset", typeof(double), typeof(RasterControl), new UIPropertyMetadata(0.0, OnBBChanged));
      
        public int RadialOffsetInt
        {
            get { return Convert.ToInt32(RadialOffset); }
            set
            {
                RadialOffset = value * Math.PI / 180;                
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

        /// <summary>
        /// Resets the raster to some default values
        /// </summary>
        public void ResetRaster()
        {
            ForceRadiusTo = -1;
            IsCartesian = true;
            CoordinateTransform = new Parser.TikzMatrix(); // unit matrix            
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
            this.InvalidateVisual();
            //canvas1.Children.Clear();

            //if (GridWidth <= 0)
            //    return;            
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

           
            //return;
            //Path p = new Path();
            //p.Stroke = Brushes.WhiteSmoke;
            //p.StrokeThickness = 1;
            //p.Data = DrawRasterGeometry(EstimateRasterSteps());
            //canvas1.Children.Add(p);
            /* * */
            //canvas1.Children.Add(new GeometryDrawing(Brushes.WhiteSmoke, null, DrawRasterGeometry(EstimateRasterSteps()) ));
            /*Pen pen = new Pen(Brushes.Black, 1);
            pen.Freeze();

            GeometryDrawing gd = new GeometryDrawing(Brushes.WhiteSmoke, pen, DrawRasterGeometry(EstimateRasterSteps()));
            gd.Freeze();

            DrawingGroup dg = new DrawingGroup();
            dg.ClipGeometry = new RectangleGeometry(new Rect(0, 0, Width, Height));
            dg.Children.Add(gd);
                        
            imgRaster.Source = new DrawingImage(dg ); */
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
            if (maxcoord > 0) //if scale=0 maxcoord==NaN just return 0 then.
                return Convert.ToInt32(2 * maxcoord / GridWidth);
            return 0;
        }
        /*GeometryGroup DrawRasterGeometry(int rasterwidth)
        {
            GeometryGroup gc = new GeometryGroup();
          return gc;
            Transform t = GetTikzToScreenTransform();
            t.Freeze();
            //System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            //sw.Start();
            if (IsCartesian)
            {
                for (int i = -rasterwidth; i <= rasterwidth; i++)
                {
                    // draw both an x and a y coordinate line
                    LineGeometry lg = new LineGeometry(new Point(i * GridWidth, - rasterwidth * GridWidth),
                                                       new Point(i * GridWidth,   rasterwidth * GridWidth));
                    lg.Transform = t; 
                    Path pa = new Path();
                    pa.Data = lg;
                    pa.Stroke=Brushes.WhiteSmoke;
                    pa.StrokeThickness = 1;
                    canvas1.Children.Add(pa);
                    //gc.Children.Add(lg);
                    lg = new LineGeometry(new Point(-rasterwidth * GridWidth, i * GridWidth),
                                          new Point( rasterwidth * GridWidth, i * GridWidth));
                    lg.Transform = t; 
                    pa = new Path();
                    pa.Data = lg;
                    pa.Stroke = Brushes.WhiteSmoke;
                    pa.StrokeThickness = 1;
                    canvas1.Children.Add(pa);
                    //gc.Children.Add(lg);
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
            //gc.Transform = t;
            
            gc.Freeze();
            //sw.Stop();
            //if (sw.ElapsedMilliseconds> 1)
            //    MessageBox.Show("Zeit: " + sw.ElapsedMilliseconds);
            return gc;
        }*/

        protected override void OnRender(DrawingContext dc)
        {
            dc.DrawRectangle(Brushes.White, null, new Rect(RenderSize)); //new Rect(0, 0, Resolution * BB.Width, Resolution * BB.Height));//
            
            if (GridWidth <= 0 || !ShowRaster)
               return;    

            Transform t = GetTikzToScreenTransform();
            t.Freeze();
            //dc.PushTransform(t);
            int rasterwidth = EstimateRasterSteps();
            //System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            //sw.Start();
            Pen pen = new Pen(Brushes.WhiteSmoke, 1);
            pen.Freeze();
            if (IsCartesian)
            {
                for (int i = -rasterwidth; i <= rasterwidth; i++)
                {
                    // draw both an x and a y coordinate line
                    dc.DrawLine(pen, t.Transform( new Point(i * GridWidth, -rasterwidth * GridWidth) ),
                                     t.Transform( new Point(i * GridWidth, rasterwidth * GridWidth)));

                    dc.DrawLine(pen, t.Transform( new Point(-rasterwidth * GridWidth, i * GridWidth) ),
                                          t.Transform( new Point(rasterwidth * GridWidth, i * GridWidth)));
                }
            }
            else
            {
                // draw circles
                for (int i = 1; i <= rasterwidth; i++)
                {
                    EllipseGeometry eg = new EllipseGeometry(new Point(0, 0), i * GridWidth, i * GridWidth);
                    eg.Transform = t;
                    eg.Freeze();
                    dc.DrawGeometry(null, pen, eg);                    
                }

                // draw radial lines
                for (int i = 0; i < RadialSteps; i++)
                {
                    dc.DrawLine(pen, t.Transform( new Point(0, 0) ),
                                     t.Transform( new Point(rasterwidth * GridWidth * Math.Cos(RadialOffset + i * 2 * Math.PI / RadialSteps),
                                                            rasterwidth * GridWidth * Math.Sin(RadialOffset + i * 2 * Math.PI / RadialSteps))) );
                }
            }

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
        /// <param name="IsRelative">Specifies whether the point is a shift, rather than an absolute position.</param>
        /// <returns>The rasterized point, in absolute Cartesian Tikz coordinates.</returns>
        public Point Rasterize(Point p, bool IsRelative = false)
        {
            //if (scGWX == 0 || scGWY == 0)
            if (GridWidth <= 0)
                return p;
            // transform to std coordinates
            Point pstd = CoordinateTransform.Inverse().Transform(p, IsRelative);
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
                if (ForceRadiusTo >= 0)
                    polar = new Point(ForceRadiusTo, polar.Y);
                pstd_rast = PolToCart(polar);
            }
            return CoordinateTransform.Transform(pstd_rast, IsRelative);
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
            pp = Rasterize(pp, true);
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
