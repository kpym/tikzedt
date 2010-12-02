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
    /// Interaction logic for RasterControl.xaml
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
            set { _Resolution = value; DrawRaster(); }
        }

        double _GridWidth = 1;
        public double GridWidth
        {
            get { return _GridWidth; }
            set { _GridWidth = value; DrawRaster(); }
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

        public void DrawRaster()
        {
            canvas1.Children.Clear();

            if (GridWidth <= 0)
                return;

            for (double x = Math.Ceiling(BB.X / GridWidth) * GridWidth; x < BB.X+BB.Width; x += GridWidth)
            {
                Line myLine = new Line();
                myLine.Stroke = System.Windows.Media.Brushes.WhiteSmoke;
                myLine.X1 = (x-BB.X)*Resolution;
                myLine.X2 = myLine.X1;
                myLine.Y1 = 0;
                myLine.Y2 = Height;
                canvas1.Children.Add(myLine);
            }
            
            for (double y = Math.Ceiling(BB.Y / GridWidth) * GridWidth; y < BB.Y+BB.Height; y += GridWidth)
            {
                Line myLine = new Line();
                myLine.Stroke = System.Windows.Media.Brushes.WhiteSmoke;
                myLine.X1 = 0;
                myLine.X2 = Width;
                myLine.Y1 = (y-BB.Y)*Resolution;
                myLine.Y2 = myLine.Y1;
                canvas1.Children.Add(myLine);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p">The point, in Tikz coordinates</param>
        public Point Rasterize(Point p)
        {
            return new Point( 
                Math.Round(p.X /GridWidth)*GridWidth,
                Math.Round(p.Y /GridWidth)*GridWidth 
                );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p">The point, in screen coordinates</param>
        public Point RasterizePixel(Point p)
        {
            Point pp = new Point(p.X/Resolution - BB.X, p.Y/Resolution - BB.Y);
            pp = Rasterize(pp);
            return new Point((pp.X + BB.X) * Resolution, (pp.Y + BB.Y) * Resolution);
        }
    }
}
