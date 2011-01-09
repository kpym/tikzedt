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
using System.Xml;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.CodeCompletion;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;

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
            if (!File.Exists(Helper.GetSettingsPath() + Consts.cSyntaxFile))
            {
                MessageBox.Show("Syntax definitions not found");
            }
            else
            {
                XmlReader r = new XmlTextReader(Helper.GetSettingsPath() + Consts.cSyntaxFile);
                txtPreamble.SyntaxHighlighting = HighlightingLoader.Load(r, null);  //HighlightingManager.Instance..GetDefinition("C#");
                txtPostamble.SyntaxHighlighting = txtPreamble.SyntaxHighlighting;  //HighlightingManager.Instance..GetDefinition("C#");
                r.Close();
            }

            txtPreamble.Text = Properties.Settings.Default.Tex_Preamble;
            txtPostamble.Text = Properties.Settings.Default.Tex_Postamble;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
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
    }
}
