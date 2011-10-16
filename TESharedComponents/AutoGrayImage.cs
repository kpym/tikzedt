using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Imaging;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;

namespace TikzEdt
{
    public class AutoGrayImage : Image
    {
        public AutoGrayImage()
        {
            IsEnabledChanged += new DependencyPropertyChangedEventHandler(AutoGrayImage_IsEnabledChanged); 
        }

        void AutoGrayImage_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (IsEnabled)
            {
                Source = Source2;
                Opacity = 1.0;
            }
            else
            {
                Source = GrayedImage;
                Opacity = 0.5;
            }
        }
        FormatConvertedBitmap GrayedImage = null;

        public static readonly DependencyProperty Source2Property = DependencyProperty.Register("Source2", typeof(BitmapSource),
                            typeof(AutoGrayImage), new PropertyMetadata(null, OnSource2Changed));
        /// <summary>
        /// Sets the image to be grayed, or not.
        /// </summary>
        public BitmapSource Source2
        {
            get { return (BitmapSource)GetValue(Source2Property); }
            set { SetValue(Source2Property, value); }
        }
        static void OnSource2Changed(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            AutoGrayImage s = sender as AutoGrayImage;
            if (s.Source2 == null)
            {
                s.GrayedImage = null;
            }
            else
            {
                s.GrayedImage = new FormatConvertedBitmap(s.Source2, PixelFormats.Gray8, null, 0);
                s.OpacityMask = new ImageBrush(s.Source2);
            }
            s.AutoGrayImage_IsEnabledChanged(s, new DependencyPropertyChangedEventArgs());
        }
    }
}
