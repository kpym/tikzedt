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
using System.Windows.Forms.Design;
//using TikzEdt.Parser;

namespace TikzEdtWForms
{
    public partial class Form1 : Form
    {
        MainWindowVM<TextEditorDocumentWrapper> TheVM;

        RasterControl rasterControl1;
        SnippetList snippetList1;
        FileViewer fileViewer;
        DynamicPreamble dynamicPreamble;
        FindReplaceNoWPF.FindReplaceMgr findReplaceMgr;
        ToolStripLabel lblStandAlone;
        ToolStripTextBox  txtRadialOffset, txtRadialSteps;
        ToolStripComboBox cmbGrid;
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

            SetupComponents();

            SetupBindings();

            GlobalUI.UI.OnRecentFileEvent += (s, e) => { if (e.IsInsert) MyMRU.Insert(e.FileName); else MyMRU.Remove(e.FileName); };
            MyMRU.OnFileOpen += (s, e) => TheVM.Open(e.FileName, ModifierKeys.HasFlag(Keys.Control));    

            TheVM.CreateNewFile(false);

            
        }

        /// <summary>
        /// Create those controls that are not set u via the designer.
        /// </summary>
        void SetupComponents()
        {
            lblStandAlone = new ToolStripLabel("[Document is standalone]") { Visible = false };
            statusStrip1.Items.Insert(2, lblStandAlone);
            statusStrip1.Items.Insert(3, new ToolStripLabel("Grid:"));
            cmbGrid = new ToolStripComboBox() { Width = 50 };
            cmbGrid.ComboBox.MaximumSize = new Size(50, 0);
            cmbGrid.ComboBox.Items.AddRange(new double[] { 0, 0.1, 0.2, 0.5, 1, 2, 5 });
            statusStrip1.Items.Insert(4, cmbGrid);
            statusStrip1.Items.Insert(5, new ToolStripLabel("RS:"));
            txtRadialSteps = new ToolStripTextBox();
            statusStrip1.Items.Insert(6, txtRadialSteps);
            statusStrip1.Items.Insert(7, new ToolStripLabel("RO:"));
            txtRadialOffset = new ToolStripTextBox();
            statusStrip1.Items.Insert(8, txtRadialOffset);
            toolStripZoomCtrlItem1.Width = 110;
            toolStripZoomCtrlItem1.Height = 20;
            toolStripZoomCtrlItem1.Visible = true;
            //toolStripZoomCtrlItem1.MinimumSize = new Size(110, 20);

            findReplaceMgr = new FindReplaceNoWPF.FindReplaceMgr();
            //findReplaceMgr.Editors = new object[] { new FindReplaceNoWPF.TextEditorAdapter(txtCode) };
            findReplaceMgr.CurrentEditor = new FindReplaceNoWPF.TextEditorAdapter(txtCode);
            findReplaceMgr.SearchIn = FindReplaceNoWPF.FindReplaceMgr.SearchScope.CurrentDocument;
            findReplaceMgr.OwnerWindow = this;

            CreateContextMenu();
            lblCompileInfo.TextAlign = ContentAlignment.MiddleLeft;
            splitContainer2.Panel2.BackColor = Color.FromArgb(0x30, 0x30, 0x30);
            rasterControl1 = new RasterControl();
            splitContainer2.Panel2.Controls.Add(rasterControl1);

            rasterControl1.Rasterizer = rasterControl1.TheRasterModel;

            rasterControl1.Visible = true;

            snippetList1 = new SnippetList();
            snippetList1.Visible = true;
            snippetList1.Dock = DockStyle.Fill;
            snippetList1.OnInsert += new EventHandler<TikzEdt.Snippets.InsertEventArgs>(snippetList1_OnInsert);
            snippetList1.OnUseStyles += new EventHandler<TikzEdt.Snippets.UseStylesEventArgs>(snippetList1_OnUseStyles);
            splitContainer1.Panel1.Controls.Add(snippetList1);

            fileViewer = new FileViewer() { Dock = DockStyle.Fill, Visible = false };
            splitContainer1.Panel1.Controls.Add(fileViewer);
            fileViewer.OnFileSelect += new EventHandler<FileViewer.FileSelectEventArgs>(fileViewer_OnFileSelect);

            dynamicPreamble = new DynamicPreamble() { Dock = DockStyle.Fill, Visible = false, PreamblesFile = Consts.DynPreamblesFileFullPath };
            splitContainer1.Panel1.Controls.Add(dynamicPreamble);

            txtCode.SetHighlighting("Tikz");

        }

        /// <summary>
        /// Wire controls to viewmodels (etc).
        /// </summary>
        void SetupBindings()
        {
            splitContainer2.Panel2.ClientSizeChanged += new EventHandler(Panel2_Resize);

            //rasterControl1.Resize += new EventHandler(Panel2_Resize);
            rasterControl1.SizeChanged += new EventHandler(Panel2_Resize);
            rasterControl1.MouseMove += new MouseEventHandler(rasterControl1_MouseMove);
            rasterControl1.MouseWheel += new MouseEventHandler(rasterControl1_MouseWheel);
            rasterControl1.JumpToSource += new EventHandler<RasterControl.JumpToSourceEventArgs>(rasterControl1_JumpToSource);
            rasterControl1.ReplaceText += new EventHandler<TikzEdt.Overlay.ReplaceTextEventArgs>(rasterControl1_ReplaceText);

            cmbEdgeStyle.TextChanged += (s, e) => TheVM.TheDocument.EdgeStyle = cmbEdgeStyle.Text;
            cmbNodeStyle.TextChanged += (s, e) => TheVM.TheDocument.NodeStyle = cmbNodeStyle.Text;
            cmbEdgeStyle.DropDown += (s, e) => { cmbEdgeStyle.Items.Clear(); cmbEdgeStyle.Items.AddRange(TheVM.TheDocument.TikzStyles.ToArray()); };
            cmbNodeStyle.DropDown += (s, e) => { cmbNodeStyle.Items.Clear(); cmbNodeStyle.Items.AddRange(TheVM.TheDocument.TikzStyles.ToArray()); };


            dynamicPreamble.PreambleChanged += (s, e) => TheVM.DynamicPreamble = dynamicPreamble.Preamble;
            TheVM.DynamicPreamble = dynamicPreamble.Preamble;

            //TheVM.NewCommandHandler(this, new System.Windows.Input.ExecutedRoutedEventArgs()) ;
            

            // add bindings
            rasterControl1.DataBindings.Add("ShowOverlay", cmdShowOverlay, "Checked");
            rasterControl1.DataBindings.Add("UsePolarCoordinates", chkUsePolar, "Checked");

            // Note that the TheDocument.Document property is bound "automatically" by the hack described in the TextEditorDocumentWrapper class.
            var sp = BindingFactory.CreateProvider(TheVM, "TheDocument", vm => vm.TheDocument);
            BindingFactory.CreateBindingSP(sp, "ParseTree", doc => rasterControl1.ParseTree = doc.ParseTree, () => rasterControl1.ParseTree = null);

            BindingFactory.CreateBindingSP(sp, "PdfPath", doc => rasterControl1.PdfPath = doc.PdfPath, () => rasterControl1.PdfPath = "");
            BindingFactory.CreateBindingSP(sp, "ReloadPdf", doc => rasterControl1.ReloadPdf = doc.ReloadPdf, null);
            BindingFactory.CreateBindingSP(sp, "Resolution", doc => rasterControl1.Resolution = doc.Resolution, null);
            BindingFactory.CreateBindingSP(sp, "CurrentBB", doc => rasterControl1.BB = doc.CurrentBB, null);
            BindingFactory.CreateBindingSP(sp, "AllowEditing", doc => rasterControl1.AllowEditing = doc.AllowEditing, null);
            BindingFactory.CreateBindingSP(sp, "EdgeStyle", doc => rasterControl1.EdgeStyle = doc.EdgeStyle, null);
            BindingFactory.CreateBindingSP(sp, "NodeStyle", doc => rasterControl1.NodeStyle = doc.NodeStyle, null);
            BindingFactory.CreateBindingSP(sp, "Resolution", doc => toolStripZoomCtrlItem1.ZoomCtrl.Value = Convert.ToInt32(doc.Resolution), null);
            toolStripZoomCtrlItem1.ZoomCtrl.ValueChanged += (s, e) => TheVM.TheDocument.Resolution = toolStripZoomCtrlItem1.ZoomCtrl.Value;
            BindingFactory.CreateBindingSP(sp, "DisplayString", doc => this.Text = "TikzEdt - " + doc.DisplayString, () => this.Text = "TikzEdt");
            BindingFactory.CreateBindingSP(sp, "IsStandAlone", doc => lblStandAlone.Visible = doc.IsStandAlone, () => lblStandAlone.Visible = false);


            BindingFactory.CreateBinding(TheVM, "RasterRadialOffset", vm =>
            { txtRadialOffset.TextBox.Text = vm.RasterRadialOffset.ToString(); rasterControl1.RadialOffset = vm.RasterRadialOffset; }, null);
            BindingFactory.CreateBinding(TheVM, "RasterSteps", vm =>
            { txtRadialSteps.TextBox.Text = vm.RasterSteps.ToString(); rasterControl1.RasterRadialSteps = (uint)vm.RasterSteps; }, null);
            BindingFactory.CreateBinding(TheVM, "RasterWidth", vm =>
            { cmbGrid.ComboBox.Text = vm.RasterWidth.ToString(); rasterControl1.RasterWidth = vm.RasterWidth; }, null);
            txtRadialOffset.TextChanged += (s, e) =>
            {
                double d;
                if (Double.TryParse(txtRadialOffset.TextBox.Text, out d))
                    TheVM.RasterRadialOffset = d;
            };
            txtRadialSteps.TextChanged += (s, e) =>
            {
                uint d;
                if (UInt32.TryParse(txtRadialSteps.TextBox.Text, out d))
                    TheVM.RasterSteps = (int)d;
            };
            cmbGrid.ComboBox.TextChanged += (s, e) =>
            {
                double d;
                if (Double.TryParse(cmbGrid.ComboBox.Text, out d))
                    TheVM.RasterWidth = d;
            };

            rasterControl1.ToolChanged += (sender, e) => TheVM.CurrentTool = rasterControl1.Tool;

            BindingFactory.CreateBinding(TheVM, "EditorMode", vm =>
            {
                wYSIWYGToolStripMenuItem.Checked = vm.EditorMode == TEMode.Wysiwyg;
                productionToolStripMenuItem.Checked = vm.EditorMode == TEMode.Production;
                previewToolStripMenuItem.Checked = vm.EditorMode == TEMode.Preview;
            }, null);

            var errlistsp = BindingFactory.CreateProviderSP(sp, "TexErrors", doc => doc.TexErrors);
            BindingFactory.CreateCollectionBindingSP(errlistsp, (s, e) => FillErrorsList());

            BindingFactory.CreateBinding(TheVM, "CurrentTool",
                vm =>
                {
                    ToolButtons.Each((tsb, i) => tsb.Checked = ((int)vm.CurrentTool == i));
                    rasterControl1.Tool = vm.CurrentTool;
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
            ClientSizeChanged += (s, e) => Properties.Settings.Default.Window_State = this.WindowState;

            try
            {
                splitContainer2.SplitterDistance = S.OverlayCanvasCol2WidthSetting;
                splitContainer1.SplitterDistance = S.LeftToolsColWidthSetting;
            }
            catch (Exception) { }
            splitContainer2.SplitterMoved += (s, e) => Properties.Settings.Default.OverlayCanvasCol2WidthSetting = splitContainer2.SplitterDistance;
            splitContainer1.SplitterMoved += (s, e) => Properties.Settings.Default.LeftToolsColWidthSetting = splitContainer1.SplitterDistance;

            BindingFactory.CreateBinding(S, "Editor_ShowLineNumbers", s => txtCode.ShowLineNumbers = s.Editor_ShowLineNumbers, null);
            BindingFactory.CreateBinding(S, "Editor_Font", s => txtCode.Font = s.Editor_Font, null);
            BindingFactory.CreateBinding(S, "Snippets_ShowThumbs", s => snippetList1.ShowThumbnails = s.Snippets_ShowThumbs, null);

            BindingFactory.CreateBinding(S, "Snippets_ShowThumbs", s =>
            {
                autoCompilationOnChangeToolStripMenuItem.Checked = s.AutoCompileOnDocumentChange;
                TheVM.AutoCompileOnDocumentChange = s.AutoCompileOnDocumentChange;
            }, null);
            autoCompilationOnChangeToolStripMenuItem.CheckedChanged += (s, e) =>
            {
                S.AutoCompileOnDocumentChange = TheVM.AutoCompileOnDocumentChange = autoCompilationOnChangeToolStripMenuItem.Checked;
            };
        }

        void rasterControl1_ReplaceText(object sender, TikzEdt.Overlay.ReplaceTextEventArgs e)
        {
            txtCode.BeginUpdate();

            // Note: we assume that the replacements are already brought into correct order !!
            foreach (var r in e.Replacements)
                txtCode.Document.Replace(r.StartPosition, r.Length, r.ReplacementText);

            txtCode.EndUpdate();
            txtCode.Refresh();
        
        }

        void fileViewer_OnFileSelect(object sender, FileViewer.FileSelectEventArgs e)
        {
            if (e.InExternalViewer)
            {
                try
                {
                    System.Diagnostics.Process.Start(e.FileName);
                }
                catch (Exception)
                {
                    GlobalUI.UI.ShowMessageBox("Couldn't open file: " + e.FileName + ".", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
            }
            else
                TheVM.Open(e.FileName, e.InNewInstance);
        }

        void rasterControl1_JumpToSource(object sender, RasterControl.JumpToSourceEventArgs e)
        {
            txtCode.ActiveTextAreaControl.SelectionManager.SetSelection(
                txtCode.Document.OffsetToPosition(e.JumpToPos),
                txtCode.Document.OffsetToPosition(e.JumpToPos+e.SelectionLength) );

            // Move cursor to end of selection.
            txtCode.ActiveTextAreaControl.Caret.Position = txtCode.Document.OffsetToPosition(e.JumpToPos + e.SelectionLength);

        }

        private void CreateContextMenu()
        {
            var m = txtCode.ContextMenu = new ContextMenu();
            var i = new MenuItem("Copy");
            i.Click += (s,e) => txtCode.ActiveTextAreaControl.TextArea.ClipboardHandler.Copy(s, e);
            m.MenuItems.Add(i);
            i = new MenuItem("Cut");
            i.Click += (s, e) => txtCode.ActiveTextAreaControl.TextArea.ClipboardHandler.Cut(s, e);
            m.MenuItems.Add(i);
            i = new MenuItem("Paste");
            i.Click += (s, e) => txtCode.ActiveTextAreaControl.TextArea.ClipboardHandler.Paste(s, e);
            m.MenuItems.Add(i);
            m.MenuItems.Add(new MenuItem("-"));
            i = new MenuItem("Comment");
            i.Click += (s, e) => commentToolStripMenuItem_Click(s,e);
            m.MenuItems.Add(i);
            i = new MenuItem("Uncomment");
            i.Click += (s, e) => uncommentToolStripMenuItem_Click(s,e);
            m.MenuItems.Add(i);
            i = new MenuItem("En-scope");
            i.Click += (s, e) => enscopeToolStripMenuItem_Click(s, e);
            m.MenuItems.Add(i);
            m.MenuItems.Add(new MenuItem("-"));
            i = new MenuItem("Mark object in overlay (if possible)");
            i.Click += (s, e) => rasterControl1.TheOverlayModel.MarkObjectAt(txtCode.ActiveTextAreaControl.TextArea.Caret.Offset);
            m.MenuItems.Add(i);
        }

        void rasterControl1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys.HasFlag(Keys.Control))
            {          
                double factor = e.Delta > 0 ? 1.1 : .9;
                TheVM.TheDocument.Resolution *= factor;

                // get Mouse pos for correct scrolling
                //Point p = e.Location;

                // adjust scroll ... wish to but seems impossible in winforms
                //splitContainer2.Panel2.Vert
                //PreviewScrollViewer.ScrollToHorizontalOffset(PreviewScrollViewer.HorizontalOffset * factor + p.X * (factor - 1));
                //PreviewScrollViewer.ScrollToVerticalOffset(PreviewScrollViewer.VerticalOffset * factor + p.Y * (factor - 1));

                //e. = true;
                //if (cmbZoom.SelectedIndex + step > 0 && cmbZoom.SelectedIndex + step < count)
                //cmbZoom.SelectedIndex += step;
            }
        }
		
		
        void rasterControl1_MouseMove(object sender, MouseEventArgs e)
        {
            // convert to bottom left coordinates
            System.Windows.Point p = new System.Windows.Point(e.Location.X, rasterControl1.Height - e.Location.Y);            

            // display the current mouse position
            p.Y /= rasterControl1.Resolution;
            p.X /= rasterControl1.Resolution;
            p.X += rasterControl1.BB.X;
            p.Y += rasterControl1.BB.Y;

            String s = "(" + String.Format("{0:f1}", p.X) + ", " + String.Format("{0:f1}", p.Y) + ")";
            lblMousePos.Text = s;
        
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
			
			/*if (!IsHandleCreated) return;
			splitContainer2.Panel2.PerformLayout();
			splitContainer2.Panel2.Update();
			splitContainer2.Panel2.Refresh();
			splitContainer2.Panel2.Invalidate();
			splitContainer2.Invalidate();
			splitContainer2.Refresh();
			//splitContainer2.SplitterDistance = splitContainer2.SplitterDistance+1;
			//splitContainer2.SplitterDistance = splitContainer2.SplitterDistance-1;
			*/
			//GlobalUI.UI.AddStatusLine(this, " L T "+rasterControl1.Left +" , "+ rasterControl1.Top);
			//GlobalUI.UI.AddStatusLine(this, " W H "+splitContainer2.Panel2.ClientSize.Width +" , "+ splitContainer2.Panel2.ClientSize.Height);
        }

        void Instance_OnCompileEvent(object sender, TexCompiler.CompileEventArgs e)
        {
            AddStatusLine(e.Message, e.Type == TexCompiler.CompileEventType.Error);
            if (e.Type == TexCompiler.CompileEventType.Start)
                txtTexOutput.Clear();
        }

        void AddStatusLine(string StatusLine, bool IsError=false)
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
			
			AddStatusLine("Welcome to TikzEdt!");
            AddStatusLine("This software is under development. All help/feedback/feature requests/error reports are welcome.");
			AddStatusLine("Application data is stored in "+Helper.GetAppdataPath()+".");
			AddStatusLine("Working directory is now: " + Helper.GetCurrentWorkingDir());

            GlobalUI.UI.OnGlobalStatus += new EventHandler<GlobalStatusEventData>(UI_OnGlobalStatus);
            GlobalUI.UI.OnExportCompile += (s, ee) => ExportCompileDialog.Export(ee.Code, ee.File);
            TheCompiler.Instance.OnTexOutput += new EventHandler<TexCompiler.CompileEventArgs>(Instance_OnTexOutput);
            TheCompiler.Instance.OnCompileEvent += new EventHandler<TexCompiler.CompileEventArgs>(Instance_OnCompileEvent);
            TikzToBMPFactory.Instance.JobNumberChanged += new EventHandler(Instance_JobNumberChanged);

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

            if (!String.IsNullOrWhiteSpace( AppMethods.StartupFile ))
                TheVM.LoadFile(AppMethods.StartupFile);
        }

        void Instance_JobNumberChanged(object sender, EventArgs e)
        {
            if (TikzToBMPFactory.Instance.JobsInQueue == 0)
            {
                ProgressCompile.Style = ProgressBarStyle.Continuous;
                ProgressCompile.Visible = true;
                lblCompileInfo.Text = "Thumbnail compilation complete.";
            }
            else
            {
                ProgressCompile.Style = ProgressBarStyle.Marquee;
                lblCompileInfo.Text = "Compiling thumbnails... (" + TikzToBMPFactory.Instance.JobsInQueue + " to go)";
                ProgressCompile.Visible = true;
            }
        }

     /*   void doc_DocumentChanged(object sender, ICSharpCode.TextEditor.Document.DocumentEventArgs e)
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
        }*/

        private void recompileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TheVM.TheDocument.Recompile();
        }

        List<ToolStripButton> ToolButtons;
        private void cmdToolClick_Click(object sender, EventArgs e)
        {
            OverlayToolType t = (OverlayToolType)ToolButtons.IndexOf(sender as ToolStripButton);
            TheVM.CurrentTool = t;
			//AddStatusLine("Hallowelt"+t.ToString());
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
                    case Severity.PARSERERROR: 
                        lvi.ImageIndex = 2;
                        break;
                    case Severity.ERROR:
                        lvi.ImageIndex = 0;
                        break;
                    case Severity.PARSERWARNING:
                        lvi.ImageIndex = 3;
                        break;
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
            fileViewer.Visible = cmdFiles.Checked;
            dynamicPreamble.Visible = cmdDynPreamble.Checked;
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
            /*Control ctrl = this.ActiveControl;

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
            else*/
            {
                txtCode.Undo();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Control ctrl = this.ActiveControl;

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
            else */
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

        private void recompileSnippetThumbnailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            snippetList1.TheModel.CompileSnippets();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            findReplaceMgr.ShowAsFind();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            findReplaceMgr.ShowAsReplace();
        }

        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            findReplaceMgr.FindNext();
        }

        private void enscopeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtCode.SelectionLength() > 0)
                txtCode.Document.Replace(txtCode.SelectionStart(), txtCode.SelectionLength(),
                    "\\begin{scope}[]\r\n" + txtCode.SelectedText() + "\r\n\\end{scope}");
            else
                txtCode.Document.Insert(txtCode.CaretOffset(), "\\begin{scope}[]\r\n\r\n\\end{scope}");
        }

        private void fileToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            MyMRU.UpdateMenu(fileToolStripMenuItem, toolStripSeparatorMRU);
        }

        private void wYSIWYGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender == wYSIWYGToolStripMenuItem)
                TheVM.EditorMode = TEMode.Wysiwyg;
            else if (sender == previewToolStripMenuItem)
                TheVM.EditorMode = TEMode.Preview;
            else if (sender == productionToolStripMenuItem)
                TheVM.EditorMode = TEMode.Production;
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            TikzEdt.Parser.TikzParseTreeHelper.UniquefyNodeNames(TheVM.TheDocument.ParseTree);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TheVM.TheDocument.ExportFile();
        }





    }


    public static class ControlExtensions
    {
        public static void Undo(this ComboBox cb)
        {
            
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


        public static int SelectionStart(this TextEditorControl T)
        {
                if (T.ActiveTextAreaControl.TextArea.SelectionManager.HasSomethingSelected)
                    return T.ActiveTextAreaControl.TextArea.SelectionManager.SelectionCollection[0].Offset;
                else
                    return T.ActiveTextAreaControl.Caret.Offset;
        }
        public static int SelectionLength(this TextEditorControl T)
        {
                if (T.ActiveTextAreaControl.TextArea.SelectionManager.HasSomethingSelected)
                    return T.ActiveTextAreaControl.TextArea.SelectionManager.SelectionCollection[0].Length;
                else
                    return 0;
        }

        public static string SelectedText(this TextEditorControl T)
        {
                return T.ActiveTextAreaControl.TextArea.SelectionManager.SelectedText;
        }

        public static int CaretOffset(this TextEditorControl T)
        {
                return T.ActiveTextAreaControl.Caret.Offset;
        }

    }

    /// <summary>
    /// Adds ZoomCtrl to toolstrip stuff
    /// </summary>
    [
    ToolStripItemDesignerAvailability
        (ToolStripItemDesignerAvailability.ToolStrip | ToolStripItemDesignerAvailability.StatusStrip)
    ]
    public class ToolStripZoomCtrlItem : ToolStripControlHost
    {
        public ToolStripZoomCtrlItem()
            : base(new ZoomCtrl())
        {
            ZoomCtrl = this.Control as ZoomCtrl;
        }

        public readonly ZoomCtrl ZoomCtrl;
    }

    [
ToolStripItemDesignerAvailability
    (ToolStripItemDesignerAvailability.ToolStrip | ToolStripItemDesignerAvailability.StatusStrip)
]
    public class ToolStripComboBox : ToolStripControlHost
    {
        public ToolStripComboBox()
            : base(new ComboBox())
        {
            ComboBox = this.Control as ComboBox;
        }

        public readonly ComboBox ComboBox;
    }

    [
ToolStripItemDesignerAvailability
    (ToolStripItemDesignerAvailability.ToolStrip | ToolStripItemDesignerAvailability.StatusStrip)
]
    public class ToolStripTextBox : ToolStripControlHost
    {
        public ToolStripTextBox()
            : base(new TextBox())
        {
            TextBox = this.Control as TextBox;
        }

        public readonly TextBox TextBox;
    }


}
