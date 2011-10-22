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
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Windows.Interop;

namespace TESharedComponents
{
    /// <summary>
    /// Interaction logic for MyMessageBox.xaml
    /// </summary>
    public partial class MyMessageBox : Window
    {

        //static BitmapSource imgWarning, imgError, imgInfo, imgQuestion;
        int result=-1;

        static MyMessageBox()
        {
           /* System.Drawing.Icon icon = System.Drawing.SystemIcons.Warning;
            imgWarning = System.Windows.Interop.Imaging.CreateBitmapSourceFromHIcon(icon.Handle, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());            
            icon = System.Drawing.SystemIcons.Error;
            imgError = System.Windows.Interop.Imaging.CreateBitmapSourceFromHIcon(icon.Handle, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
            icon = System.Drawing.SystemIcons.Question;
            imgQuestion = System.Windows.Interop.Imaging.CreateBitmapSourceFromHIcon(icon.Handle, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
            icon = System.Drawing.SystemIcons.Information;
            imgInfo = System.Windows.Interop.Imaging.CreateBitmapSourceFromHIcon(icon.Handle, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
            */
        }

        static ImageSource MBoxImgToImageSource(MessageBoxImage img)
        {
            switch (img)
            {
                //case MessageBoxImage.Asterisk:
                case MessageBoxImage.Information:
                    return SystemIconProvider.InfoIcon;                    
                case MessageBoxImage.Question:
                    return SystemIconProvider.QuestionIcon;
                case MessageBoxImage.Warning:
                    return SystemIconProvider.WarningIcon;
                case MessageBoxImage.Error:
                    return SystemIconProvider.ErrorIcon;
                default:
                    return null;
            }
        }

        /// <summary>
        /// Shows a dialog box. The return value is the index of the button clicked, or -1 if cancelled by clicking X.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="title"></param>
        /// <param name="img"></param>
        /// <param name="buttons"></param>
        /// <param name="owner"></param>
        /// <returns></returns>
        public static int Show(object content, string title, ImageSource img, string[] buttons, int DefaultButton, Window owner)
        {
            MyMessageBox mbox = new MyMessageBox();
            mbox.Title = title;
            mbox.imgIcon.Source = img;
            mbox.Owner = owner;
            mbox.ButtonPanel.Children.Clear();

            // add buttons
            for (int i = buttons.Length - 1; i >= 0; i--)
            {
                Button b = new Button();
                b.Content = buttons[i];
                b.Margin = new Thickness(0,10,10,10);
                b.MinWidth = 80;
                b.MinHeight = 25;
                b.Tag = i;
                b.IsDefault = (i == DefaultButton);
                b.Click += new RoutedEventHandler(mbox.Button_Click);
                DockPanel.SetDock(b, Dock.Right);

                mbox.ButtonPanel.Children.Add(b);
            }

            // add content
            if (content is string)
            {
                TextBlock tb = new TextBlock() { MaxWidth = 400, Margin = new Thickness(20), TextWrapping = TextWrapping.Wrap };
                tb.Inlines.Add(content as string);
                content = tb;
            }
            mbox.TheContent.Content = content;

            mbox.ShowDialog();
            return mbox.result;
        }
        public static int Show(object content, string title, MessageBoxImage img, string[] buttons, int DefaultButton, Window owner)
        {
            return Show(content, title, MBoxImgToImageSource(img), buttons, DefaultButton, owner);
        }

        static Regex urlregex = new Regex(@"((?:https?|ftp|gopher|telnet|file|notes|ms-help):(?:(?://)|(?:\\\\))+[\w\d:#@%/;$()~_?\+-=\\\.&]*)",
                        RegexOptions.IgnoreCase | RegexOptions.Compiled);
        //static Regex emailregex = new Regex(@"([a-zA-Z_0-9.-]+\@[a-zA-Z_0-9.-]+\.\w+)", RegexOptions.IgnoreCase | RegexOptions.Compiled);
        public static int ShowWithHyperlinks(string content, string title, MessageBoxImage img, Window owner)
        {
            TextBlock newContent = new TextBlock() { MaxWidth=400, Margin=new Thickness(20), TextWrapping=TextWrapping.Wrap };            

            string[] textbetween = urlregex.Split(content);
            int i=0;
            newContent.Inlines.Add(textbetween[i++]);

            while ( i < textbetween.Count() )
            {
                string link = textbetween[i++];
                Hyperlink hl = new Hyperlink();
                hl.NavigateUri = new Uri(link);
                hl.Inlines.Add(link);
                hl.RequestNavigate += (s, e) =>
                {
                    System.Diagnostics.Process.Start(e.Uri.ToString());
                    Window w = Window.GetWindow(s as DependencyObject);
                    if (w != null) 
                        w.Close();
                };
                newContent.Inlines.Add(hl);

                newContent.Inlines.Add(textbetween[i++]);
            }

            return Show(newContent, title, img, new string[] { "OK" }, 0, owner);
        }


        private MyMessageBox()
        {
            InitializeComponent();
        }
        protected override void OnSourceInitialized(EventArgs e)
        {
            IconHelper.RemoveIcon(this);
        }

        private void NavigateUri(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.ToString());
            Close();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            result = (int)(sender as Control).Tag;
            Close();
        }


    }

    public static class SystemIconProvider
    {
        private static BitmapSource _ErrorIcon = null;
        public static BitmapSource ErrorIcon
        {
            get
            {
                if (_ErrorIcon != null)
                    return _ErrorIcon;
                else
                    return _ErrorIcon = System.Windows.Interop.Imaging.CreateBitmapSourceFromHIcon(
                        System.Drawing.SystemIcons.Error.Handle, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions()); 
            }
        }
        private static BitmapSource _WarningIcon = null;
        public static BitmapSource WarningIcon
        {
            get
            {
                if (_ErrorIcon != null)
                    return _WarningIcon;
                else
                    return _WarningIcon = System.Windows.Interop.Imaging.CreateBitmapSourceFromHIcon(
                        System.Drawing.SystemIcons.Warning.Handle, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
            }
        }
        private static BitmapSource _InfoIcon = null;
        public static BitmapSource InfoIcon
        {
            get
            {
                if (_ErrorIcon != null)
                    return _InfoIcon;
                else
                    return _InfoIcon = System.Windows.Interop.Imaging.CreateBitmapSourceFromHIcon(
                        System.Drawing.SystemIcons.Information.Handle, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
            }
        }
        private static BitmapSource _QuestionIcon = null;
        public static BitmapSource QuestionIcon
        {
            get
            {
                if (_ErrorIcon != null)
                    return _QuestionIcon;
                else
                    return _QuestionIcon = System.Windows.Interop.Imaging.CreateBitmapSourceFromHIcon(
                        System.Drawing.SystemIcons.Question.Handle, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
            }
        }
    }

    public static class IconHelper
    {
        [DllImport("user32.dll")]
        static extern int GetWindowLong(IntPtr hwnd, int index);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hwnd, int index, int newStyle);

        [DllImport("user32.dll")]
        static extern bool SetWindowPos(IntPtr hwnd, IntPtr hwndInsertAfter,
                   int x, int y, int width, int height, uint flags);

        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hwnd, uint msg,
                   IntPtr wParam, IntPtr lParam);

        const int GWL_EXSTYLE = -20;
        const int WS_EX_DLGMODALFRAME = 0x0001;
        const int SWP_NOSIZE = 0x0001;
        const int SWP_NOMOVE = 0x0002;
        const int SWP_NOZORDER = 0x0004;
        const int SWP_FRAMECHANGED = 0x0020;
        const uint WM_SETICON = 0x0080;

        public static void RemoveIcon(Window window)
        {
            // Get this window's handle
            IntPtr hwnd = new WindowInteropHelper(window).Handle;

            // Change the extended window style to not show a window icon
            int extendedStyle = GetWindowLong(hwnd, GWL_EXSTYLE);
            SetWindowLong(hwnd, GWL_EXSTYLE, extendedStyle | WS_EX_DLGMODALFRAME);

            // Update the window's non-client area to reflect the changes
            SetWindowPos(hwnd, IntPtr.Zero, 0, 0, 0, 0, SWP_NOMOVE |
                  SWP_NOSIZE | SWP_NOZORDER | SWP_FRAMECHANGED);
        }

    }
}
