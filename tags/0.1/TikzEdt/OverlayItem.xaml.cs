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
    /// Interaction logic for OverlayItem.xaml
    /// </summary>
    public partial class OverlayItem : UserControl
    {
        Point pos=new Point(0,0);

        public OverlayItem()
        {
            InitializeComponent();
        }

        private void UserControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            pos = e.GetPosition(this);
        }

        private void UserControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Canvas v = Parent as Canvas;
                Canvas.SetLeft(this, e.GetPosition(v).X - pos.X);
                Canvas.SetTop(this, e.GetPosition(v).Y - pos.Y);
            }
        }
    }
}
