using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TikzEdt.ViewModels;
using TikzEdt;
using System.Diagnostics;
using ICSharpCode.TextEditor;

namespace TikzEdtWForms
{
    public partial class Form1 : Form
    {
        MainWindowVM<TextEditorDocumentWrapper> TheVM;

        RasterControl rasterControl1;
        SnippetList snippetList1;
        //PdfOverlay pdfOverlay1;

        public Form1()
        {
            (GlobalUI.UI as GlobalUIWinForms).MainForm = this;
            TheVM = new MainWindowVM<TextEditorDocumentWrapper>(TheCompiler.Instance);

            InitializeComponent();

            if (DesignMode)
                return;

            TextEditorDocumentWrapper.TheOneAndOnly = txtCode;
            
            // The order should be exactly the same as that in the OverlayToolType enum!!!
            ToolButtons = new List<ToolStripButton> { cmdMove, cmdNode, cmdEdge, cmdPath, cmdSmoothCurve, cmdBezier, cmdRectangle, cmdEllipse, cmdGrid, cmdArc, cmdArcEdit };
            ToolPaneButtons = new List<ToolStripButton> { cmdSnippets, cmdFiles, cmdDynPreamble };

            splitContainer2.Panel2.BackColor = Color.DarkGray;
            rasterControl1 = new RasterControl();
            splitContainer2.Panel2.Controls.Add(rasterControl1);
      //      tikzDisplay1.Visible = false;
     //       tikzDisplay1.Parent = rasterControl1;


       /*     pdfOverlay1 = new PdfOverlay();
            pdfOverlay1.Left = 0;
            pdfOverlay1.Top = 0;
            pdfOverlay1.Parent = tikzDisplay1;
            pdfOverlay1.BringToFront();
            pdfOverlay1.Visible = true; */
            //pdfOverlay1.Rasterizer = rasterControl1.TheRasterModel;
            rasterControl1.Rasterizer = rasterControl1.TheRasterModel;

            rasterControl1.Visible = true;
            //rasterControl1.Anchor = AnchorStyles.None;
            //rasterControl1.OverrideWithZeroGridWidth = true;
            //rasterControl1.Left = 0;
            //rasterControl1.Top = 0;

            splitContainer2.Panel2.Resize += new EventHandler(Panel2_Resize);
            rasterControl1.Resize += new EventHandler(Panel2_Resize);
      //      tikzDisplay1.Resize += new EventHandler(Panel2_Resize);

            cmbEdgeStyle.TextChanged += (s, e) => TheVM.TheDocument.EdgeStyle = cmbEdgeStyle.Text;
            cmbNodeStyle.TextChanged += (s, e) => TheVM.TheDocument.NodeStyle = cmbNodeStyle.Text;
            cmbEdgeStyle.DropDown += (s, e) => { cmbEdgeStyle.Items.Clear(); cmbEdgeStyle.Items.AddRange(TheVM.TheDocument.TikzStyles.ToArray()); };
            cmbNodeStyle.DropDown += (s, e) => { cmbNodeStyle.Items.Clear(); cmbNodeStyle.Items.AddRange(TheVM.TheDocument.TikzStyles.ToArray()); };

            snippetList1 = new SnippetList();
            snippetList1.Parent = splitContainer1.Panel1;
            snippetList1.Visible = true;
            snippetList1.Dock = DockStyle.Fill;
            snippetList1.OnInsert += new EventHandler<TikzEdt.Snippets.InsertEventArgs>(snippetList1_OnInsert);
            snippetList1.OnUseStyles += new EventHandler<TikzEdt.Snippets.UseStylesEventArgs>(snippetList1_OnUseStyles);



            //TheVM.NewCommandHandler(this, new System.Windows.Input.ExecutedRoutedEventArgs()) ;
            TheVM.CreateNewFile(false);
            
            // add bindings
            var bs = new BindingSource(TheVM, null);
            Binding b = new Binding("Document", bs, "TheDocument.Document", true, DataSourceUpdateMode.Never);
            b.Format += new ConvertEventHandler((s,e) => 
            {
                TextEditorDocumentWrapper W = e.Value as TextEditorDocumentWrapper;
                if (W == null) e.Value = null;
                else e.Value = W.Document;
            });
      //      txtCode.DataBindings.Add(b);
      //      txtCode.Document = TheVM.TheDocument.Document.Document;

     //       b = new Binding("ReloadPdf", bs, "TheDocument.ReloadPdf", false, DataSourceUpdateMode.Never);
     //       rasterControl1.DataBindings.Add(b);
            //TheVM.TheDocument.
            //tikzDisplay1.Bou
     //       b = new Binding("PdfPath", bs, "TheDocument.PdfPath", false, DataSourceUpdateMode.Never);
     //       rasterControl1.DataBindings.Add(b);
        //    b = new Binding("Resolution", bs, "TheDocument.Resolution", false, DataSourceUpdateMode.Never);
       //     tikzDisplay1.DataBindings.Add(b);

            
     //       b = new Binding("Resolution", bs, "TheDocument.Resolution", false, DataSourceUpdateMode.Never);
     //       rasterControl1.DataBindings.Add(b);
     //       b = new Binding("BB", bs, "TheDocument.CurrentBB", false, DataSourceUpdateMode.Never);
     //       rasterControl1.DataBindings.Add(b);

        //    b = new Binding("BB", bs, "TheDocument.CurrentBB", false, DataSourceUpdateMode.Never);
        //    pdfOverlay1.DataBindings.Add(b);
       //     b = new Binding("Tool", bs, "CurrentTool", false, DataSourceUpdateMode.OnPropertyChanged);
       //     rasterControl1.DataBindings.Add(b);
     //       b = new Binding("Resolution", bs, "TheDocument.Resolution", false, DataSourceUpdateMode.Never);
      //      pdfOverlay1.DataBindings.Add(b);
      //      b = new Binding("AllowEditing", bs, "TheDocument.AllowEditing", false, DataSourceUpdateMode.Never);
      //      rasterControl1.DataBindings.Add(b);

      //      b = new Binding("EdgeStyle", bs, "TheDocument.EdgeStyle", false, DataSourceUpdateMode.Never);
      //      rasterControl1.DataBindings.Add(b);
      //      b = new Binding("NodeStyle", bs, "TheDocument.NodeStyle", false, DataSourceUpdateMode.Never);
      //      rasterControl1.DataBindings.Add(b);

            rasterControl1.DataBindings.Add("ShowOverlay", cmdShowOverlay, "Checked");
            rasterControl1.DataBindings.Add("UsePolarCoordinates", chkUsePolar, "Checked");
            

      //      b = new Binding("Text", bs, "TheDocument.EdgeStyle", false, DataSourceUpdateMode.Never);
      //      cmbEdgeStyle.DataBindings.Add(b);
      //      b = new Binding("Text", bs, "TheDocument.NodeStyle", false, DataSourceUpdateMode.Never);
      //      cmbNodeStyle.DataBindings.Add(b);

            //b = new Binding("ParseTree", bs, "TheDocument.ParseTree", false, DataSourceUpdateMode.Never);
            //pdfOverlay1.DataBindings.Add(b);
            //TheVM.TheDocument.Parse
            //pdfOverlay1.Pars

            var sp = BindingFactory.CreateProvider(TheVM, "TheDocument", vm => vm.TheDocument);
            BindingFactory.CreateBindingSP(sp, "ParseTree", doc => rasterControl1.ParseTree = doc.ParseTree, () => rasterControl1.ParseTree = null);
			
			BindingFactory.CreateBindingSP(sp, "PdfPath", doc => rasterControl1.PdfPath = doc.PdfPath, () => rasterControl1.PdfPath = "");
			BindingFactory.CreateBindingSP(sp, "ReloadPdf", doc => rasterControl1.ReloadPdf = doc.ReloadPdf, null);
			BindingFactory.CreateBindingSP(sp, "Resolution", doc => rasterControl1.Resolution = doc.Resolution, null);
			BindingFactory.CreateBindingSP(sp, "CurrentBB", doc => rasterControl1.BB = doc.CurrentBB, null);
			BindingFactory.CreateBindingSP(sp, "AllowEditing", doc => rasterControl1.AllowEditing = doc.AllowEditing, null);
			BindingFactory.CreateBindingSP(sp, "EdgeStyle", doc => rasterControl1.EdgeStyle = doc.EdgeStyle, null);
			BindingFactory.CreateBindingSP(sp, "NodeStyle", doc => rasterControl1.NodeStyle = doc.NodeStyle, null);

			BindingFactory.CreateBinding(TheVM, "CurrentTool", vm => rasterControl1.Tool = vm.CurrentTool, null);
			rasterControl1.ToolChanged += (sender, e) => TheVM.CurrentTool = rasterControl1.Tool;
			
            var errlistsp = BindingFactory.CreateProviderSP(sp, "TexErrors", doc => doc.TexErrors);
            BindingFactory.CreateCollectionBindingSP(errlistsp, (s, e) => FillErrorsList());

            BindingFactory.CreateBinding(TheVM, "CurrentTool",
                vm =>
                {
                    ToolButtons.Each((tsb, i) => tsb.Checked = ((int)vm.CurrentTool == i));
                }, null);

            BindingFactory.CreateBinding(TheCompiler.Instance, "Compiling", 
                (c) => { cmdAbortCompile.Enabled = abortCompilationToolStripMenuItem.Enabled = c.Compiling; },
                () => { cmdAbortCompile.Enabled = abortCompilationToolStripMenuItem.Enabled = true; });

            // load settings
            var S = Properties.Settings.Default;
            Width = S.Window_Width;
            Height = S.Window_Height;
            SizeChanged += (s, e) => { Properties.Settings.Default.Window_Height = Height; Properties.Settings.Default.Window_Width = Width; };

            this.Left = S.Window_Left;
            this.Top = S.Window_Top;
            LocationChanged += (s, e) => { Properties.Settings.Default.Window_Top = Top; Properties.Settings.Default.Window_Left = Left; };

            WindowState = S.Window_State;
            ClientSizeChanged += (s,e) => Properties.Settings.Default.Window_State = this.WindowState;

            try
            {
                splitContainer2.SplitterDistance = S.OverlayCanvasCol2WidthSetting;
                splitContainer1.SplitterDistance = S.LeftToolsColWidthSetting;
            }
            catch (Exception) { }
            splitContainer2.SplitterMoved += (s, e) => Properties.Settings.Default.OverlayCanvasCol2WidthSetting = splitContainer2.SplitterDistance;
            splitContainer1.SplitterMoved += (s, e) => Properties.Settings.Default.LeftToolsColSelectedIndex = splitContainer1.SplitterDistance;

            
			
			//test
			//TheVM.TheDocument.OnPdfReady += (sender, e) => rasterControl1.ReloadPdf++;
			
/* * 
 * */
            txtCode.SetHighlighting("Tikz");
            //txtCode.
        }

        void snippetList1_OnUseStyles(object sender, TikzEdt.Snippets.UseStylesEventArgs e)
        {
            TheVM.TheDocument.InsertUseTikzLibrary(e.dependencies);

            if (!String.IsNullOrWhiteSpace(cmbEdgeStyle.Text) && e.InAddition)
                cmbEdgeStyle.Text = Helper.MergeStyles(cmbEdgeStyle.Text, e.edgestyle);
            else
                cmbEdgeStyle.Text = e.edgestyle;

            if (!String.IsNullOrWhiteSpace(cmbNodeStyle.Text) && e.InAddition)
                cmbNodeStyle.Text = Helper.MergeStyles(cmbNodeStyle.Text, e.nodestyle);
            else
                cmbNodeStyle.Text = e.nodestyle;
        }

        void snippetList1_OnInsert(object sender, TikzEdt.Snippets.InsertEventArgs e)
        {
            txtCode.Document.Insert(txtCode.ActiveTextAreaControl.Caret.Offset, e.code);
        }

        //List<object> MyBindings = new List<object>();

        void Panel2_Resize(object sender, EventArgs e)
        {
            //rasterControl1.Left = (splitContainer2.Panel2.ClientSize.Width - rasterControl1.Width) / 2;
            //rasterControl1.Top = (splitContainer2.Panel2.Height - rasterControl1.Height) / 2;
            //tikzDisplay1.Left = (rasterControl1.ClientSize.Width - tikzDisplay1.Width) / 2;
            //tikzDisplay1.Top = (rasterControl1.ClientSize.Height - tikzDisplay1.Height) / 2;

            rasterControl1.Left = (splitContainer2.Panel2.ClientSize.Width - rasterControl1.Width) / 2;
            rasterControl1.Top = (splitContainer2.Panel2.ClientSize.Height - rasterControl1.Height) / 2;


        }

        void Instance_OnCompileEvent(object sender, TexCompiler.CompileEventArgs e)
        {
            AddStatusLine(e.Message, e.Type == TexCompiler.CompileEventType.Error);
            if (e.Type == TexCompiler.CompileEventType.Start)
                txtTexOutput.Clear();
        }

        void AddStatusLine(string StatusLine, bool IsError)
        {
            this.BeginInvoke(new InvokeDelegate(() =>
            {
                int length = txtStatus.TextLength;  // at end of text
                string toAppend = StatusLine + Environment.NewLine;
                txtStatus.AppendText(toAppend);
                txtStatus.SelectionStart = length;
                txtStatus.SelectionLength = toAppend.Length;
                txtStatus.SelectionColor = IsError ? Color.Red : Color.Black;
                txtStatus.SelectionLength = 0;
                
                txtStatus.SelectionStart = txtStatus.Text.Length - 1;
                txtStatus.ScrollToCaret();
            }));
        }

        void Instance_OnTexOutput(object sender, TexCompiler.CompileEventArgs e)
        {
            //this.BeginInvoke(new InvokeDelegate(() =>
            //{
                txtTexOutput.AppendText(e.Message + Environment.NewLine);
            //}));
        }
        public delegate void InvokeDelegate();
        void UI_OnGlobalStatus(object sender, GlobalStatusEventData e)
        {
            AddStatusLine(e.StatusLine, e.IsError);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            GlobalUI.UI.OnGlobalStatus += new EventHandler<GlobalStatusEventData>(UI_OnGlobalStatus);
            TheCompiler.Instance.OnTexOutput += new EventHandler<TexCompiler.CompileEventArgs>(Instance_OnTexOutput);
            TheCompiler.Instance.OnCompileEvent += new EventHandler<TexCompiler.CompileEventArgs>(Instance_OnCompileEvent);

            //txtCode.SetHighlighting("C#");
            //ICSharpCode.TextEditor.Document.IDocument doc;
            //doc.
            //ICSharpCode.TextEditor.Document.DocumentFactory df = new ICSharpCode.TextEditor.Document.DocumentFactory();
            //ICSharpCode.TextEditor.Document.IDocument doc =  df.CreateDocument();
            //doc.HighlightingStrategy = ICSharpCode.TextEditor.Document.HighlightingStrategyFactory.CreateHighlightingStrategy();

            //txtCode.Document = doc;
            
            //doc.Insert(0, "gjhghjgjhG");
            //doc.TextContentChanged += new EventHandler(doc_TextContentChanged);
            //doc.DocumentChanged += new ICSharpCode.TextEditor.Document.DocumentEventHandler(doc_DocumentChanged);
            
            //txtCode.Refresh();
            //txtCode.LoadFile(
        }

        void doc_DocumentChanged(object sender, ICSharpCode.TextEditor.Document.DocumentEventArgs e)
        {
            GlobalUI.UI.AddStatusLine(this, "changed");
        }

        void doc_TextContentChanged(object sender, EventArgs e)
        {
            GlobalUI.UI.AddStatusLine(this, "changed");
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TheVM.TheDocument.Document.Text);
        }

        private void recompileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TheVM.TheDocument.Recompile();
        }

        List<ToolStripButton> ToolButtons;
        private void cmdToolClick_Click(object sender, EventArgs e)
        {
            OverlayToolType t = (OverlayToolType)ToolButtons.IndexOf(sender as ToolStripButton);
            TheVM.CurrentTool = t;
        }

        private void cmdSavePdf_Click(object sender, EventArgs e)
        {
            TheVM.TheDocument.SavePdf(false);
        }

        private void cmdCompile_Click(object sender, EventArgs e)
        {
            TheVM.TheDocument.Recompile();
        }

        private void cmdAbortCompile_Click(object sender, EventArgs e)
        {
            TheCompiler.Instance.AbortCompilation();
        }

        private void regeneratePrecompiledHeadersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TheCompiler.GeneratePrecompiledHeaders();
        }

        private void openInExternalViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string PdfPath = TheVM.TheDocument.SavePdf(false);

            if (PdfPath == "") return;

        //    if (Properties.Settings.Default.Path_externalviewer.Trim() == "")
            {
                System.Diagnostics.Process.Start(PdfPath);
            }
        //    else
            {
         //       System.Diagnostics.Process.Start(Properties.Settings.Default.Path_externalviewer, PdfPath);
            }
        }

        void FillErrorsList()
        {
            //return;
            lstErrors.Items.Clear();

            foreach (var err in TheVM.TheDocument.TexErrors)
            {
                ListViewItem lvi = new ListViewItem(err.Message);
                lvi.SubItems.Add(err.Line.ToString());
                lvi.SubItems.Add(err.Pos.ToString());
                lvi.SubItems.Add(err.causingSourceFile);

                switch (err.severity)
                {
                    case Severity.PARSERERROR: // todo: set status image
                    case Severity.ERROR:
                        lvi.ImageIndex = 0;
                        break;
                    case Severity.PARSERWARNING:
                    case Severity.WARNING:
                        lvi.ImageIndex = 1;
                        break;
                }

                lstErrors.Items.Add(lvi);
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            TheVM.CreateNewFile();
        }

        private void cmdNewInNew(object sender, EventArgs e)
        {
            TheVM.CreateNewFile(true);
        }

        private void cmdOpen_Click(object sender, EventArgs e)
        {
            TheVM.Open();
        }

        private void cmdOpenInNew_Click(object sender, EventArgs e)
        {
            TheVM.Open(true);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            TheVM.Save();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TheVM.SaveAs();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        List<ToolStripButton> ToolPaneButtons;
        private void cmdSnippets_Click(object sender, EventArgs e)
        {
            foreach (var b in ToolPaneButtons)
            {
                if (b != sender)
                    b.Checked = false;
            }

            splitContainer1.Panel1Collapsed = ToolPaneButtons.TrueForAll(b => !b.Checked);

            snippetList1.Visible = cmdSnippets.Checked;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            cmbNodeStyle.Text = "";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            cmbEdgeStyle.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!DesignMode)
            {
                //ad// dockManager.SaveLayout(Helper.GetLayoutConfigFilepath());
                Properties.Settings.Default.Save();

                if (!TheVM.TheDocument.TryDisposeFile())
                    e.Cancel = true;
                else
                {
                    // Set closing flag
         //           isClosing = true;
                    //FindDialog.txtCode = null;
                    //     if (FindDialog != null)
                    //        FindDialog.Close();

                    // Exit running pdflatex instances
                    TheCompiler.Instance.AbortCompilation();
                    TikzToBMPFactory.Instance.AbortCompilation();
                }
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            string colorname;
            if (colorDialog1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                if (GlobalUI.UI.ShowInputDialog("New color", "Please enter a unique color name.", out colorname) == System.Windows.Forms.DialogResult.OK)
                {
                    string colorcode = ColorTranslator.ToHtml(colorDialog1.Color).Substring(1);
                    txtCode.Document.Insert(txtCode.ActiveTextAreaControl.Caret.Offset,
                        @"\definecolor{" + colorname + "}{HTML}{" + colorcode + "}" + Environment.NewLine);
                }
        }

        private void indexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TheVM.OpenPgfManual();
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TheVM.ShowHelp();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.ShowDialog();
            a.Dispose();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            Control ctrl = this.ActiveControl;

            if (ctrl != null)
            {
                if (ctrl is TextBox)
                {
                    TextBox tx = (TextBox)ctrl;
                    tx.Copy();
                } else if (ctrl is ComboBox)
                {
                    ComboBox cb = (ComboBox)ctrl;
                    cb.Copy();
                }
                else
                {
                    txtCode.ActiveTextAreaControl.TextArea.ClipboardHandler.Copy(sender, e);
                }

            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            Control ctrl = this.ActiveControl;

            if (ctrl != null)
            {
                if (ctrl is TextBox)
                {
                    TextBox tx = (TextBox)ctrl;
                    tx.Cut();
                } else if (ctrl is ComboBox)
                {
                    ComboBox cb = (ComboBox)ctrl;
                    cb.Cut();
                }
                else
                {
                    txtCode.ActiveTextAreaControl.TextArea.ClipboardHandler.Cut(sender, e);
                }
            }
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            Control ctrl = this.ActiveControl;

            if (ctrl != null)
            {
                if (ctrl is TextBox)
                {
                    TextBox tx = (TextBox)ctrl;
                    tx.Paste();
                } else if (ctrl is ComboBox)
                {
                    ComboBox cb = (ComboBox)ctrl;
                    cb.Paste();
                }
                else
                {
                    txtCode.ActiveTextAreaControl.TextArea.ClipboardHandler.Paste(sender, e);
                }

            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control ctrl = this.ActiveControl;

            if (ctrl is TextBox)
            {
                TextBox tx = (TextBox)ctrl;
                tx.Undo();
            }
            else if (ctrl is ComboBox)
            {

                ComboBox cb = (ComboBox)ctrl;

                cb.Undo();

            }
            else
            {
                txtCode.Undo();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control ctrl = this.ActiveControl;

            if (ctrl is TextBox)
            {
                TextBox tx = (TextBox)ctrl;
                //tx.Redo();
            }
            else if (ctrl is ComboBox)
            {
                ComboBox cb = (ComboBox)ctrl;
                //cb.Redo();
            }
            else
            {
                txtCode.Redo();
            }
        }

        private void commentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            txtCode.BeginUpdate();
            int startline = txtCode.Document.GetLocation(txtCode.SelectionStart).Line,
                endline = txtCode.Document.GetLocation(txtCode.SelectionStart + txtCode.SelectionLength).Line;
            for (int i = startline; i <= endline; i++)
                txtCode.Document.Insert(txtCode.Document.Lines[i - 1].Offset, "% ");
            txtCode.EndUpdate(); */
        }

        private void uncommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
          /*  txtCode.BeginChange();
            int startline = txtCode.Document.GetLocation(txtCode.SelectionStart).Line,
                endline = txtCode.Document.GetLocation(txtCode.SelectionStart + txtCode.SelectionLength).Line;
            for (int i = startline; i <= endline; i++)
            {
                string s = txtCode.Document.GetText(txtCode.Document.Lines[i - 1].Offset, txtCode.Document.Lines[i - 1].Length);
                if (s.StartsWith("% "))
                    txtCode.Document.Remove(txtCode.Document.Lines[i - 1].Offset, 2);
                else if (s.StartsWith("%"))
                    txtCode.Document.Remove(txtCode.Document.Lines[i - 1].Offset, 1);
            }
            txtCode.EndChange(); */
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsDialog sd = new SettingsDialog();
            sd.ShowDialog();
            sd.Dispose();
        }




    }


    public static class ControlExtensions
    {
        public static void Undo(this ComboBox cb)
        {
            // not supported
        }

        public static void Copy(this ComboBox cb)
        {
            if (cb.SelectedText != string.Empty)
            {
                Clipboard.SetText(cb.SelectedText);
            }

        }

        public static void Paste(this ComboBox cb)
        {
            string txtInClip = Clipboard.GetText();

            int sPos = cb.SelectionStart;

            if (cb.SelectedText != string.Empty)
            {
                cb.SelectedText = txtInClip;
            }
            else
            {
                cb.Text = cb.Text.Insert(cb.SelectionStart, txtInClip);
                cb.SelectionStart = sPos + txtInClip.Length;
            }
        }

        public static void Cut(this ComboBox cb)
        {
            if (cb.SelectedText != string.Empty)
            {
                //set old text of combox, this value is need when undo
                //cb.oldText = cb.Text;
                string copied = cb.SelectedText;
                //int sPos = cb.SelectionStart, l = cb.SelectionLength;
                cb.SelectedText = "";
                //cb.SelectionStart = sPos;

                Clipboard.SetText(copied);

            }

        }
    }
}
