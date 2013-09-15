/* Legal note:
 * This code interfaces the AvalonEdit TextEditor library,
 * which is provided under the terms of the GNU Lesser General Public license (LGPL),
 * available here: http://www.gnu.org/copyleft/lesser.html.
 * If you use this code in your project you might be subject to restrictions
 * imposed by the LGPL.
*/

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
using System.Collections.ObjectModel;
using ICSharpCode.AvalonEdit;
using FindReplace;
using System.ComponentModel;
using System.Windows.Markup;
using System.Windows.Forms.Integration;

namespace FindReplaceTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {       
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
            
            FindReplaceMgr fr = Resources["FRep"] as FindReplaceMgr;
            fr.OwnerWindow = this;
            //CommandBindings.Add(fr.FindBinding);
            //BindingOperations.SetBinding(fr, FindReplaceVM.CurrentEditorProperty, new Binding("ActiveView") { Source=this, Mode=BindingMode.TwoWay });
            //BindingOperations.SetBinding(fr, FindReplaceVM.EditorsProperty, new Binding("Views") { Source = this });
        }

        private void MW_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void FindReplaceMgr_DialogWindowCreated(object sender, FindReplaceMgr.DialogWindowCreatedEventArgs e)
        {
            // register command bindings so hotkeys work when dialog window is active
            var s = sender as FindReplaceMgr;
            if (s == null) 
                return;
            e.Dialog.CommandBindings.Add(s.FindBinding);
            e.Dialog.CommandBindings.Add(s.FindNextBinding);
            e.Dialog.CommandBindings.Add(s.ReplaceBinding);
            e.Dialog.InputBindings.Add(new KeyBinding(NavigationCommands.Search, new KeyGesture(Key.F3, ModifierKeys.Shift)));
        }
    }

    public class MyViewData : DependencyObject
    {
        public ObservableCollection<UIElement> Views
        {
            get { return (ObservableCollection<UIElement>)GetValue(ViewsProperty); }
            set { SetValue(ViewsProperty, value); }
        }
        public static readonly DependencyProperty ViewsProperty =
            DependencyProperty.Register("Views", typeof(ObservableCollection<UIElement>), typeof(MyViewData), new UIPropertyMetadata(new ObservableCollection<UIElement>()));

        public UIElement ActiveView
        {
            get { return (UIElement)GetValue(ActiveViewProperty); }
            set { SetValue(ActiveViewProperty, value); }
        }
        public static readonly DependencyProperty ActiveViewProperty =
            DependencyProperty.Register("ActiveView", typeof(UIElement), typeof(MyViewData), new UIPropertyMetadata(null));

        public MyViewData()
        {
            Views.Clear();
            Views.Add(new TextEditor() { Tag = "Avalon TextEditor", Text = TestString });
            Views.Add(new TextEditor() { Tag = "Avalon TextEditor", Text = TestString });
            Views.Add(new RichTextBox(new FlowDocument(new Paragraph(new Run(TestString)))) { Tag = "WPF RichTextBox", VerticalScrollBarVisibility=ScrollBarVisibility.Auto });
            Views.Add(new WindowsFormsHost() { Child = new System.Windows.Forms.TextBox() {Text = TestString, HideSelection=false, Multiline=true }, Tag="WinForms TextBox" });
            Views.Add(new WindowsFormsHost() { Child = new System.Windows.Forms.RichTextBox() { Text = TestString, HideSelection=false }, Tag = "WinForms RichTextBox" });
            //Views.Add(new TextBox() { Tag = "WPF TextBox (*)", Text = TestString, VerticalScrollBarVisibility = ScrollBarVisibility.Auto });
            ActiveView = Views[0];
        }
        const string TestString =
@"Lorem ipsum dolor sit amet, consectetur adipiscing elit.
In ac adipiscing massa. Sed fringilla neque id massa lobortis
sed varius erat fermentum. Donec nec interdum arcu. Aliquam
sit amet libero nisi, in feugiat purus. Curabitur tellus 
urna, euismod quis tristique vel, consectetur ac quam. 
Suspendisse dui nibh, volutpat quis facilisis ac, faucibus
et elit. Nunc neque dolor, egestas at ultrices a, mollis
posuere nibh. Phasellus egestas, sem a commodo porttitor, 
diam nisl sodales dolor, at accumsan odio velit in nulla. 
Praesent rhoncus quam eu lacus suscipit eleifend. Quisque 
aliquet felis a justo pretium sed eleifend massa fermentum.
Duis porta tristique pharetra. Curabitur consectetur interdum
dolor, quis sollicitudin magna varius vel. Etiam malesuada
tristique elit dapibus fermentum. Integer vel risus tortor, vel
cursus libero. Ut sed massa lectus. Curabitur turpis eros, 
tristique non convallis in, dapibus in enim. Donec vestibulum 
ullamcorper ullamcorper. Quisque sodales, purus sodales gravida 
pretium, mauris sapien dictum purus, quis egestas lectus
mauris ac metus. ";
    }

    public class StaticResourceEx : StaticResourceExtension
    {
        public PropertyPath Path { get; set; }
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            object o = base.ProvideValue(serviceProvider);
            return (Path==null ? o : PathEvaluator.Eval(o, Path));
        }

        class PathEvaluator : DependencyObject
        {
            private static readonly DependencyProperty DummyProperty =
                DependencyProperty.Register("Dummy", typeof(object), typeof(PathEvaluator), new UIPropertyMetadata(null));

            public static object Eval(object source, PropertyPath path)
            {
                PathEvaluator d = new PathEvaluator();
                BindingOperations.SetBinding(d, DummyProperty, new Binding(path.Path) { Source=source } );
                return d.GetValue(DummyProperty);
            }
        }
    }
}
