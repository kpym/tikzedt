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
using TikzEdt.WpfSpecificComponents;

namespace TikzEdt
{
    /// <summary>
    /// The class Rastercontrol has two responsibilities:
    /// 1. Visually draw a raster, Cartesian or polar, on the Screen
    /// 2. Rasterize (quantize) coordinates
    /// 
    /// For portability to other GUI frameworks in the furture, all control logic is implemented in 
    /// RasterControlModel. RasterControl shall only provide the WPF interface to the RasterControlModel.
    /// </summary>
    public partial class RasterControl : UserControl, TikzEdt.IRasterControlView
    {
        public RasterControlModel TheModel {get; private set;}

        /// <summary>
        /// The default constructor.
        /// </summary>
        public RasterControl()
        {
            TheModel = new RasterControlModel(this);

            InitializeComponent();
            ClipToBounds = true;
            // these settings are to improve rendering speed
            RenderOptions.SetEdgeMode(this, EdgeMode.Aliased);
            IsHitTestVisible = false;
            
        }

        #region Properties

        readonly public static DependencyProperty ResolutionProperty = DependencyProperty.Register(
                    "Resolution", typeof(double), typeof(RasterControl), new PropertyMetadata(Consts.ptspertikzunit,
                    new PropertyChangedCallback(OnBBChanged)));
        /// <summary>
        /// The current Resolution, in dots per cm, i.e., dots per Tikz unit.
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
        // use this to half the GridWidth temporarily (e.g., on SHIFT+ALT pressed)
        public bool OverrideWithHalfGridWidth
        {
            set { _OverrideWithHalfGridWidth = value; DrawRaster(); }
            get { return _OverrideWithHalfGridWidth; }
        }

        /// <summary>
        /// RasterWidth is the raw width of the raster, before modifiers (OverrideWithHalfGridWidth and OverrideWithZeroGridWidth)
        /// </summary>
        public double RasterWidth
        {
            get { return (double)GetValue(RasterWidthProperty); }
            set { SetValue(RasterWidthProperty, value); }
        }
        public static readonly DependencyProperty RasterWidthProperty =
            DependencyProperty.Register("RasterWidth", typeof(double), typeof(RasterControl), new UIPropertyMetadata(Properties.Settings.Default.Raster_GridWidth, OnBBChanged));
       

        double _ForceRadiusTo = -1;
        /// <summary>
        /// Determines whether the radius of the rasterized point is fixed to ForceRadiusTo.
        /// This is used for situations (arc editing) where the radius is fixed and only the angular parameter 
        /// can vary. Is ignored if negative, or if IsCartesian = true.
        /// 
        /// Note: the radius is in the transformed coordinate system, not absolute !!
        /// (Otherwise it wouldn't make sense, say, with anisotropic scaling.)
        /// </summary>
        public double ForceRadiusTo
        {
            get { return _ForceRadiusTo; }
            set { _ForceRadiusTo = value; }
        }


        /// <summary>
        /// Controls how the phi coordinate is rasterized in polar coordinates.
        /// </summary>
        public uint RasterRadialSteps
        {
            get { return (uint)GetValue(RasterRadialStepsProperty); }
            set { SetValue(RasterRadialStepsProperty, value); }
        }
        public static readonly DependencyProperty RasterRadialStepsProperty =
            DependencyProperty.Register("RasterRadialSteps", typeof(uint), typeof(RasterControl), new UIPropertyMetadata(Properties.Settings.Default.Raster_RadSteps, OnBBChanged));        
        
 
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
      
        private TikzEdt.Parser.TikzMatrix _CoordinateTransform = new Parser.TikzMatrix();
        /// <summary>
        /// This holds the coordinate transform between Tikz relative coordinates (numbers in the latex file) and absolute coordinates. 
        /// </summary>
        public TikzEdt.Parser.TikzMatrix CoordinateTransform
        {
            get { return _CoordinateTransform; }
            set { 
                _CoordinateTransform = value.CloneIt();
                DrawRaster();
            }
        }

        private bool _IsCartesian = true;
        /// <summary>
        /// Determines whether the raster is Cartesian or polar.
        /// </summary>
        public bool IsCartesian
        {   
            get {return _IsCartesian; }
            set { _IsCartesian = value; DrawRaster(); }
        }

        #endregion

        /// <summary>
        /// This is the main routine, it does what one might guess.
        /// </summary>
        public void DrawRaster()
        {
            this.InvalidateVisual();
        }

        protected override void OnRender(DrawingContext dc)
        {
            // Draw background
            dc.DrawRectangle(Brushes.White, null, new Rect(RenderSize));

            Transform t = new MatrixTransform(TheModel.GetTikzToScreenTransform().ToWpfMatrix());
            t.Freeze();

            Pen pen = new Pen(Brushes.WhiteSmoke, 1);
            pen.Freeze();

            TheModel.DrawRaster(
                (p1, p2) => dc.DrawLine(pen, t.Transform(p1), t.Transform(p2)),
                (r1, r2) =>
                {
                    EllipseGeometry eg = new EllipseGeometry(new Point(0, 0), r1, r2);
                    eg.Transform = t;
                    eg.Freeze();
                    dc.DrawGeometry(null, pen, eg);
                });

        }


    }
}
