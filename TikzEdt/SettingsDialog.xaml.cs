/*This file is part of TikzEdt.
 
TikzEdt is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.
 
TikzEdt is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
GNU General Public License for more details.
 
You should have received a copy of the GNU General Public License
along with TikzEdt.  If not, see <http://www.gnu.org/licenses/>.*/

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
using System.IO;
//using Microsoft.Windows.Controls;
using System.Xml;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.CodeCompletion;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;
using System.Diagnostics;

namespace TikzEdt
{
    /// <summary>
    /// Interaction logic for SettingsDialog.xaml
    /// </summary>
    public partial class SettingsDialog : Window
    {
        public SettingsDialog()
        {
            InitializeComponent();            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           /* if (!File.Exists(Helper.GetSettingsPath() + Consts.cSyntaxFile))
            {
                MessageBox.Show("Syntax definitions not found");
            }
            else
            {
                XmlReader r = new XmlTextReader(Helper.GetSettingsPath() + Consts.cSyntaxFile);
                txtPreamble.SyntaxHighlighting = HighlightingLoader.Load(r, null);  //HighlightingManager.Instance..GetDefinition("C#");
                txtPostamble.SyntaxHighlighting = txtPreamble.SyntaxHighlighting;  //HighlightingManager.Instance..GetDefinition("C#");
                r.Close();
            } */

            txtPreamble.Text = Properties.Settings.Default.Tex_Preamble;
            txtPostamble.Text = Properties.Settings.Default.Tex_Postamble;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // remove focus from current control, so that pending data is written to settings
            lstNav.Focus();

            TheCompiler.Instance.timeout = Properties.Settings.Default.Compiler_Timeout;
            TikzToBMPFactory.Instance.timeout = Properties.Settings.Default.Compiler_SnippetTimeout;

            if (txtPreamble.Text != Properties.Settings.Default.Tex_Preamble)
            {
                // todo: do some checks
                Properties.Settings.Default.Tex_Preamble = txtPreamble.Text;
                TheCompiler.GeneratePrecompiledHeaders();
            }
            if (txtPostamble.Text != Properties.Settings.Default.Tex_Postamble)
            {
                // todo: do some checks
                Properties.Settings.Default.Tex_Postamble = txtPostamble.Text;
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                Close();
        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            if (sender == LinkToSyntaxFolder)
            {
                Process.Start(new ProcessStartInfo(Helper.GetSettingsPath()));
                e.Handled = true;
            }
        }

        private void AssociateTikz_Click(object sender, RoutedEventArgs e)
        {
            string exepath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            if (MessageBox.Show("This will change the registry to associate *.tikz files with:"+Environment.NewLine + exepath +
                Environment.NewLine +  "You also need to run this program in administrator mode."+
                "Do you want to continue?", "Associate file extension", MessageBoxButton.YesNoCancel, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                try
                {
                    FileAssociation.Associate(".tikz", "TikzEdt.TikzEdt", "Tikz file", null, exepath);
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to associate the file extension. You need to run this program in administrator mode (right click TikzEdt.exe -> run as administrator).", "Failed",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
