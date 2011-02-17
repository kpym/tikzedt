using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Controls.Primitives;

namespace CustomWPFColorPicker
{
    public partial class ColorPickerControlView : UserControl
    {
        public SolidColorBrush CurrentColor
        {
            get { return (SolidColorBrush)GetValue(CurrentColorProperty); }
            set { SetValue(CurrentColorProperty, value); }
        }

        public static DependencyProperty CurrentColorProperty =
            DependencyProperty.Register("CurrentColor", typeof(SolidColorBrush), typeof(ColorPickerControlView), new PropertyMetadata(Brushes.Black));
        
        public static RoutedUICommand SelectColorCommand = new RoutedUICommand("SelectColorCommand","SelectColorCommand", typeof(ColorPickerControlView));
        private Window _advancedPickerWindow;

        public ColorPickerControlView()
        {
            DataContext = this;
            InitializeComponent();
            CommandBindings.Add(new CommandBinding(SelectColorCommand, SelectColorCommandExecute));
        }

        private void SelectColorCommandExecute(object sender, ExecutedRoutedEventArgs e)
        {
            CurrentColor = new SolidColorBrush((Color)ColorConverter.ConvertFromString(e.Parameter.ToString()));
        }

        private static void ShowModal(Window advancedColorWindow)
        {
            advancedColorWindow.Owner = Application.Current.MainWindow;
            advancedColorWindow.ShowDialog();
        }

        void AdvancedPickerPopUpKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                _advancedPickerWindow.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            popup.IsOpen = false;
            e.Handled = false;
        }

        private void MoreColorsClicked(object sender, RoutedEventArgs e)
        {
            popup.IsOpen = false;
            var advancedColorPickerDialog = new AdvancedColorPickerDialog();
            _advancedPickerWindow = new Window
                                        {
                                            AllowsTransparency = true,
                                            Content = advancedColorPickerDialog,
                                            WindowStyle = WindowStyle.None,
                                            ShowInTaskbar = false,
                                            Background = new SolidColorBrush(Colors.Transparent),
                                            Padding = new Thickness(0),
                                            Margin = new Thickness(0),
                                            WindowState = WindowState.Normal,
                                            WindowStartupLocation = WindowStartupLocation.CenterOwner,
                                            SizeToContent = SizeToContent.WidthAndHeight
                                        };
            _advancedPickerWindow.DragMove();
            _advancedPickerWindow.KeyDown += AdvancedPickerPopUpKeyDown;
            advancedColorPickerDialog.DialogResultEvent += AdvancedColorPickerDialogDialogResultEvent;
            advancedColorPickerDialog.Drag += AdvancedColorPickerDialogDrag;
            ShowModal(_advancedPickerWindow);
        }

        void AdvancedColorPickerDialogDrag(object sender, DragDeltaEventArgs e)
        {
            _advancedPickerWindow.DragMove();
        }

        void AdvancedColorPickerDialogDialogResultEvent(object sender, EventArgs e)
        {
            _advancedPickerWindow.Close();
            var dialogEventArgs = (DialogEventArgs)e;
            if (dialogEventArgs.DialogResult == DialogResult.Cancel)
                return;
            CurrentColor = dialogEventArgs.SelectedColor;
        }
    }
}