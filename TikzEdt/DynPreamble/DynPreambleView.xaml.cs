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

namespace TikzEdt.DynPreamble
{
    /// <summary>
    /// Interaction logic for DynPreambleView.xaml
    /// </summary>
    public partial class DynPreambleView : UserControl
    {
        private DynPreambleVM TheVM = new DynPreambleVM((vm) =>
            {
                string name, code;
                if (DynPreambleEditDialog.ShowDynPreambleEditDialog(vm.Name, vm.Code, out name, out code) == true)
                {
                    vm.Code = code;
                    vm.Name = name;
                }
            });
        public DynPreambleView()
        {
            InitializeComponent();
            TheVM.PropertyChanged += (o, e) => { if (e.PropertyName == "Preamble") Preamble = TheVM.Preamble; };
            MainPanel.DataContext = TheVM;
            Dispatcher.ShutdownStarted += (o, e) => TheVM.SavePreambles(PreamblesFile);
        }

        /// <summary>
        /// The path to the xml file in which the preambles are stored.
        /// </summary>
        public string PreamblesFile
        {
            get { return (string)GetValue(PreamblesFileProperty); }
            set { SetValue(PreamblesFileProperty, value); }
        }
        public static readonly DependencyProperty PreamblesFileProperty =
            DependencyProperty.Register("PreamblesFile", typeof(string), typeof(DynPreambleView), new UIPropertyMetadata("", PreamblesFileChanged));

        private static void PreamblesFileChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            DynPreambleView v = o as DynPreambleView;
            if (v != null)
                v.TheVM.LoadPreambles(v.PreamblesFile);
        }

        private static readonly DependencyPropertyKey PreamblePropertyKey = DependencyProperty.RegisterReadOnly(
            "Preamble", typeof(string), typeof(DynPreambleView), new PropertyMetadata("", PreambleChanged));
        public static readonly DependencyProperty PreambleProperty = PreamblePropertyKey.DependencyProperty;
        /// <summary>
        /// This property reflects the current preamble. It is not supposed to be set.
        /// (It should be made readonly, but due to a bug in WPF it would make binding to source much more difficult.)
        /// </summary>
        //public string Preamble
        //{
        //    get { return (string)GetValue(PreambleProperty); }
        //    set { SetValue(PreambleProperty, value); }
        //}
        //public static readonly DependencyProperty PreambleProperty =
        //    DependencyProperty.Register("Preamble", typeof(string), typeof(DynPreambleView), new UIPropertyMetadata("", PreambleChanged));

        
        //public static readonly DependencyProperty PreambleProperty = PreamblePropertyKey.DependencyProperty;
        private static void PreambleChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            // Instead of binding the document property, we go the cheap way and push changes....
            DynPreambleView v = o as DynPreambleView;
            if (v != null)
                v.txtCode.Text = v.Preamble;
        }
        /// <summary>
        /// Returns the current dynamic Preamble
        /// </summary>
        public string Preamble{
            get { return GetValue(PreamblePropertyKey.DependencyProperty) as string; }
            private set { SetValue(PreamblePropertyKey, value); }
        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TheVM.EditCommand.Execute(null);
        }

        private void ListBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            // Enter shall open edit dialog, space bar shall toggle IsSelected
            if (e.Key == Key.Enter)
            {
                TheVM.EditCommand.Execute(null);
                e.Handled = true;
            }
            else if (e.Key == Key.Space)
            {
                TheVM.ToggleSelectedCommand.Execute(null);
                e.Handled = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (GlobalUI.UI.ShowMessageBox("This will reload the dynamic preamble file from disk. You lose all changes. Are you sure?", "Reload Dynamic Preamble", System.Windows.Forms.MessageBoxButtons.YesNoCancel, System.Windows.Forms.MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                TheVM.LoadPreambles(PreamblesFile);
        }

        

    }
}
