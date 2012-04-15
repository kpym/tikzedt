using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TikzEdt;
using System.Drawing.Drawing2D;

namespace TikzEdtWForms
{
    public partial class RasterControl : Control, IRasterControlView
    {
        RasterControlModel TheModel;

        public RasterControl()
        {
            InitializeComponent();

            TheModel = new RasterControlModel(this);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            //base.OnPaint(pe);

            // Draw background
            Graphics dc = pe.Graphics;
            dc.ResetTransform();
            dc.FillRectangle(Brushes.White, 0, 0, Width, Height);
            
            Matrix t = TheModel.GetTikzToScreenTransform().ToMatrix();
            //t.Freeze();
            
            Pen pen = new Pen(Brushes.WhiteSmoke, 0.000001f);
            //pen.Freeze();   
            dc.Transform = t;

            TheModel.DrawRaster(
                (p1, p2) => dc.DrawLine(pen, p1.ToPointF(), p2.ToPointF()),
                (r1, r2) =>
                {
                    float rr1=(float)r1, rr2=(float)r2;
                    dc.DrawEllipse(pen, -rr1, -rr2, rr1, rr2);
                });

        }

        /// <summary>
        /// This is the main routine, it does what one might guess.
        /// </summary>
        public void DrawRaster()
        {
            this.Invalidate();
        }

        void AdjustSize()
        {
            Width = Convert.ToInt32(Resolution * BB.Width);
            Height = Convert.ToInt32(Resolution * BB.Height);
            DrawRaster();
        }

        #region Properties
        System.Windows.Rect _BB = new System.Windows.Rect(0, 0, 10, 10);
        public System.Windows.Rect BB
        {
            get
            {
                return _BB;
            }
            set
            {
                _BB = value;
                AdjustSize();
            }
        }

        TikzEdt.Parser.TikzMatrix _CoordinateTransform = new TikzEdt.Parser.TikzMatrix();
        public TikzEdt.Parser.TikzMatrix CoordinateTransform
        {
            get
            {
                return _CoordinateTransform;
            }
            set
            {
                _CoordinateTransform = value;
                DrawRaster();
            }
        }

        double _ForceRadiusTo = -1;
        public double ForceRadiusTo
        {
            get
            {
                return _ForceRadiusTo;
            }
            set
            {
                _ForceRadiusTo = value;
            }
        }

        bool _IsCartesian = true;
        public bool IsCartesian
        {
            get
            {
                return _IsCartesian;
            }
            set
            {
                _IsCartesian = value;
                DrawRaster();
            }
        }

        bool _OverrideWithHalfGridWidth = false;
        public bool OverrideWithHalfGridWidth
        {
            get
            {
                return _OverrideWithHalfGridWidth;
            }
            set
            {
                _OverrideWithHalfGridWidth = value;
                DrawRaster();
            }
        }

        bool _OverrideWithZeroGridWidth = false;
        public bool OverrideWithZeroGridWidth
        {
            get
            {
                return _OverrideWithZeroGridWidth;
            }
            set
            {
                _OverrideWithZeroGridWidth = value;
                DrawRaster();
            }
        }

        double _RadialOffset = 0;
        public double RadialOffset
        {
            get
            {
                return _RadialOffset;
            }
            set
            {
                _RadialOffset = value;
                DrawRaster();
            }
        }

        uint _RasterRadialSteps = 10;
        public uint RasterRadialSteps
        {
            get
            {
                return _RasterRadialSteps;
            }
            set
            {
                _RasterRadialSteps = value;
                DrawRaster();
            }
        }

        double _RasterWidth = .5;
        public double RasterWidth
        {
            get
            {
                return _RasterWidth;
            }
            set
            {
                _RasterWidth = value;
                DrawRaster();
            }
        }

        double _Resolution = Consts.ptspertikzunit;
        public double Resolution
        {
            get
            {
                return _Resolution;
            }
            set
            {
                _Resolution = value;
                AdjustSize();
            }
        }

        bool _ShowRaster = true;
        public bool ShowRaster
        {
            get
            {
                return _ShowRaster;
            }
            set
            {
                _ShowRaster = value;
                DrawRaster();
            }
        }

        #endregion
    }

    public static class Extensions
    {

        public static Matrix ToMatrix(this TikzEdt.Parser.TikzMatrix M)
        {
            Matrix MM = new Matrix(
                (float)M.m[0, 0],
                (float)M.m[0, 1],
                (float)M.m[1, 0],
                (float)M.m[1, 1],
                (float)M.m[0, 2],
                (float)M.m[1, 2]
            );
            return MM;
        }

        public static Point Transform(this Matrix M, Point p)
        {
            Point[] pts = new Point[] { p };
            M.TransformPoints(pts);
            return pts[0];
        }

        public static System.Drawing.PointF ToPointF(this System.Windows.Point p)
        {
            return new PointF((float)p.X, (float)p.Y);
        }
    }
}
