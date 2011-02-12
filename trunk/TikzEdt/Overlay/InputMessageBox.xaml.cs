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
using System.Windows.Shapes;

namespace TikzEdt.Overlay
{
    /// <summary>
    /// Interaction logic for InputMessageBox.xaml
    /// </summary>
    public partial class InputMessageBox : Window
    {
        public InputMessageBox()
        {
            InitializeComponent();
        }

        public static MessageBoxResult ShowInputDialog(string Title, string Message, out string Result)
        {
            InputMessageBox imb = new InputMessageBox();
            imb.tbMessage.Text = Message;
            imb.Title = Title;
            if (imb.ShowDialog() == true)
            {
                Result = imb.txtText.Text;
                return MessageBoxResult.OK;
            }
            else
            {
                Result = "";
                return MessageBoxResult.Cancel;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtText.Focus();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}
