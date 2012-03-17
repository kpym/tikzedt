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
using ICSharpCode.AvalonEdit.Highlighting.Xshd;
using System.Xml;
using ICSharpCode.AvalonEdit.Highlighting;
using System.Runtime.Serialization;
using System.Globalization;

namespace XSHDEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        XshdSyntaxDefinition xshd;
        public List<XshdColor> colors { get; set; }

        public MainWindow()
        {
            
            InitializeComponent();
            DataContext = this;
            cmbFontStyle.ItemsSource = new FontStyle[] { FontStyles.Italic, FontStyles.Normal, FontStyles.Oblique };
            cmbFontWeight.ItemsSource = new FontWeight[] {  FontWeights.Black, FontWeights.Bold, FontWeights.DemiBold, FontWeights.ExtraBlack, FontWeights.ExtraBold, FontWeights.ExtraLight, FontWeights.Heavy,
                                                            FontWeights.Light, FontWeights.Medium, FontWeights.Normal, FontWeights.Regular, FontWeights.SemiBold, FontWeights.Thin, FontWeights.UltraBlack,
                                                            FontWeights.UltraBold, FontWeights.UltraLight };


            try
            {
                using (XmlTextReader reader = new XmlTextReader(App.XSHDFile))
                {
                    xshd = HighlightingLoader.LoadXshd(reader);
                    //XshdColor x; 
                    
                }
                colors = xshd.Elements.OfType<XshdColor>().ToList();

                /*using (XmlTextWriter writer = new XmlTextWriter("output.xshd", System.Text.Encoding.UTF8))
                {
                    writer.Formatting = Formatting.Indented;
                    new SaveXshdVisitor(writer).WriteDefinition(xshd);
                }*/
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Couldn't load syntax definition file." + Environment.NewLine + "Usage: XSHDEditor myfile.xshd", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(App.XSHDFile, System.Text.Encoding.UTF8))
                {
                    writer.Formatting = Formatting.Indented;
                    new SaveXshdVisitor(writer).WriteDefinition(xshd);
                }

                //Close();
                MessageBox.Show("XSHD File saved: "+App.XSHDFile+". You need to restart TikzEdt for the changes to have effect", "Saved", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception )
            {
                MessageBox.Show("Error: Couldn't write syntax definition file.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            
        }
    }

    [ValueConversion(typeof(HighlightingBrush), typeof(Color))]
    class BrushToColorConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            HighlightingBrush hb = (value as HighlightingBrush);
            if (hb == null )
                return null;
            Color? c = hb.GetColor(null);

            return c;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return Binding.DoNothing;
            else
                return new SimpleHighlightingBrush((Color) value);
        }
    }

    /// <summary>
    /// Highlighting brush implementation that takes a frozen brush.
    /// </summary>
    [Serializable]
    sealed class SimpleHighlightingBrush : HighlightingBrush, ISerializable
    {
        readonly SolidColorBrush brush;

        public SimpleHighlightingBrush(SolidColorBrush brush)
        {
            brush.Freeze();
            this.brush = brush;
        }

        public SimpleHighlightingBrush(Color color) : this(new SolidColorBrush(color)) { }

        public override Brush GetBrush(ICSharpCode.AvalonEdit.Rendering.ITextRunConstructionContext context)
        {
            return brush;
        }

        public override string ToString()
        {
            return brush.ToString();
        }

        SimpleHighlightingBrush(SerializationInfo info, StreamingContext context)
        {
            this.brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(info.GetString("color")));
            brush.Freeze();
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("color", brush.Color.ToString(CultureInfo.InvariantCulture));
        }
    }

}
