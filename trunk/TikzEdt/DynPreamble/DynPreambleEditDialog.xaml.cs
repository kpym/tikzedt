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

namespace TikzEdt.DynPreamble
{
    /// <summary>
    /// Interaction logic for DynPreambleEditDialog.xaml
    /// </summary>
    public partial class DynPreambleEditDialog : Window
    {

        public static bool? ShowDynPreambleEditDialog(string InitialName, string InitialCode, out string Name, out string Code)
        {
            DynPreambleEditDialog dlg = new DynPreambleEditDialog();
            dlg.txtName.Text = InitialName;
            dlg.txtCode.Text = InitialCode;

            bool? res = dlg.ShowDialog();

            Name = dlg.txtName.Text;
            Code = dlg.txtCode.Text;

            return res;
        }

        private DynPreambleEditDialog()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}
