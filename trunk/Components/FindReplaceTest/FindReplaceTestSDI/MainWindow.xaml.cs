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

namespace FindReplaceTestSDI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FindReplace.FindReplaceMgr FRM = new FindReplace.FindReplaceMgr();
        public MainWindow()
        {
            InitializeComponent();
            FRM.CurrentEditor = new FindReplace.TextEditorAdapter(MyTextEditor);
            FRM.ShowSearchIn = false;
            FRM.OwnerWindow = this;

            CommandBindings.Add(FRM.FindBinding);
            CommandBindings.Add(FRM.ReplaceBinding);
            CommandBindings.Add(FRM.FindNextBinding);
        }
    }
}
