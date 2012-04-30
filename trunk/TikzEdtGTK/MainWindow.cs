using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using Gtk;
using Sansguerre;
using System.IO;
using TikzEdt;
using TikzEdt.ViewModels;

namespace TikzEdtGTK
{
    class MainWindow : Window
    {
        MainWindowVM<ScintillaDocumentWrapper> TheVM;


        Label myLabel = new Label();
        MenuBar mainMenu = new MenuBar();
        Menu fileMenu = new Menu(), editMenu = new Menu(), helpMenu = new Menu(), compileMenu = new Menu(), settingsMenu= new Menu();
        Toolbar mainToolbar = new Toolbar(), toolsToolbar = new Toolbar(), toolsPaneBar = new Toolbar();
        Statusbar statusBar = new Statusbar();

        ToolButton cmdAbortCompile;
        List<ToolButton> ToolButtons = new List<ToolButton>();

        ComboBoxEntry cmbEdgeStyle, cmbNodeStyle, cmbGrid = ComboBoxEntry.NewText();
        SpinButton txtRadialSteps = new SpinButton(0, 100, 1) { Value=18 },
                   txtRadialOffset = new SpinButton(-1000, 1000, 1) { Value = 0 };

        Label lblStandAlone = new Label("[Standalone]") { Visible = false };

        RasterControl rasterControl1 = new RasterControl();

        HScale scZoom = new HScale(5, 200, 3) { };

        MenuItem abortCompilationToolStripMenuItem;

        HPaned hSplitter1 = new HPaned();
        HPaned hSplitter2 = new HPaned();
        VPaned vSplitter1 = new VPaned();

        //TextBuffer StatusBuffer = new TextBuffer(
        TextView txtStatus = new TextView() { WrapMode= WrapMode.Word,  },
                 txtTexOut = new TextView() { WrapMode = WrapMode.Word, };
        TreeView lstErrors = new TreeView();

        GtkScintilla txtCode = new GtkScintilla();

        Notebook statusTabPanel = new Notebook();

        //Gtk.Action actOpen = new Gtk.Action("Open", "Open", "Open file", Stock.Open);

        public MainWindow() : base("TikzEdt ")
        {
            (GlobalUI.UI as GlobalUIGTK).MainForm = this;
            ScintillaDocumentWrapper.TheOneAndOnly = txtCode;
            TheVM = new MainWindowVM<ScintillaDocumentWrapper>(TheCompiler.Instance);

            rasterControl1.Rasterizer = rasterControl1.TheRasterModel;


            Resize(800, 600);
            Destroyed += (s, e) => Application.Quit();
            myLabel.Text = "Hello World!!!!";

            CreateMenus();
            CreateToolBars();

            VBox vb = new VBox(false, 0);
            vb.PackStart(mainMenu, false, false, 0);
            vb.PackStart(mainToolbar, false, false, 0);
            vb.PackStart(toolsToolbar, false, false, 0);

            HBox hb = new HBox(false, 0);
            hb.PackStart(toolsPaneBar, false, false, 0);

            ScrolledWindow scrw = new ScrolledWindow();
            scrw.Add(txtStatus);
            statusTabPanel.AppendPage(scrw, new Label("Status"));

            statusTabPanel.AppendPage(lstErrors, new Label("Errors"));
            scrw = new ScrolledWindow();
            scrw.Add(txtTexOut);
            statusTabPanel.AppendPage(scrw, new Label("TeX Output"));

            //txtCode.SetText("This is Scintilla");

            vSplitter1.Add1(txtCode);
            vSplitter1.Add2(statusTabPanel);
            vSplitter1.Position = 400;

            hSplitter1.Add1(vSplitter1);
            var sw = new ScrolledWindow();
			//Alignment a = new Alignment(0.5f,0.5f,0,0);
            //var vv = new Table(1,1,false);
            //vv.Attach(rasterControl1, 0, 0, 1,1,AttachOptions.Expand, AttachOptions.Expand, 0,0);
            /*var vv = new VBox();
            var vh = new HBox();
            vv.PackStart(rasterControl1, true, false, 0);
            vh.PackStart(vv, true, false, 0);*/
            Alignment al = new Alignment(.5f, .5f, 0, 0);
            al.Add(rasterControl1);
            sw.Add(al);
            hSplitter1.Add2(sw);
            hSplitter1.Position = 350;

            hSplitter2.Add1(new TextView() );
            hSplitter2.Add2(hSplitter1);
            hSplitter2.Position = 150;
            hb.PackStart(hSplitter2, true, true, 0);

            vb.PackStart(hb, true, true, 0);


            statusBar.PackStart(new Alignment(.5f, .5f, 1, 1), true, true, 0);
            statusBar.PackStart(lblStandAlone, false, false, 0);
            statusBar.PackStart(new Label("Grid"), false, false, 0);
            statusBar.PackStart(cmbGrid, false, false, 0);
            statusBar.PackStart(new Label("RS"), false, false, 0);
            statusBar.PackStart(txtRadialSteps, false, false, 0);
            statusBar.PackStart(new Label("RO"), false, false, 0);
            statusBar.PackStart(txtRadialOffset, false, false, 0);
            //statusBar.PackStart(new Separator(), false, false, 0);
            Button b = new Button(Stock.ZoomOut);
            //b.Label = "";
            statusBar.PackStart(b);
            statusBar.PackStart(scZoom);
            statusBar.PackStart(new Button(Stock.ZoomIn));
            vb.PackEnd(statusBar, false, false, 0);

            Add(vb);

            SetupBindings();

            ShowAll();

        }


        /// <summary>
        /// Wire controls to viewmodels (etc).
        /// </summary>
        void SetupBindings()
        {
            
            cmbEdgeStyle.Changed += (s, e) => TheVM.TheDocument.EdgeStyle = cmbEdgeStyle.ActiveText;
            cmbNodeStyle.Changed += (s, e) => TheVM.TheDocument.NodeStyle = cmbNodeStyle.ActiveText;
            // todo!!
            cmbEdgeStyle.PopupMenu += (s, e) => { cmbEdgeStyle.Clear(); TheVM.TheDocument.TikzStyles.Each((s2,i) => cmbEdgeStyle.AppendText(s2)); };
            cmbNodeStyle.PopupMenu += (s, e) => { cmbNodeStyle.Clear(); TheVM.TheDocument.TikzStyles.Each((s2, i) => cmbNodeStyle.AppendText(s2)); };


            /*splitContainer2.Panel2.ClientSizeChanged += new EventHandler(Panel2_Resize);

            //rasterControl1.Resize += new EventHandler(Panel2_Resize);
            rasterControl1.SizeChanged += new EventHandler(Panel2_Resize);
            rasterControl1.MouseMove += new MouseEventHandler(rasterControl1_MouseMove);
            rasterControl1.MouseWheel += new MouseEventHandler(rasterControl1_MouseWheel);
             
            rasterControl1.JumpToSource += new EventHandler<RasterControl.JumpToSourceEventArgs>(rasterControl1_JumpToSource);
            rasterControl1.ReplaceText += new EventHandler<TikzEdt.Overlay.ReplaceTextEventArgs>(rasterControl1_ReplaceText);




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
            };*/

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
            BindingFactory.CreateBindingSP(sp, "Resolution", doc => scZoom.Value = Convert.ToInt32(doc.Resolution), null);
            scZoom.ValueChanged += (s,e)=> TheVM.TheDocument.Resolution = scZoom.Value;
            BindingFactory.CreateBindingSP(sp, "DisplayString", doc => this.Title = "TikzEdt - " + doc.DisplayString, () => this.Title = "TikzEdt");
            BindingFactory.CreateBindingSP(sp, "IsStandAlone", doc => lblStandAlone.Visible = doc.IsStandAlone, () => lblStandAlone.Visible = false);


            BindingFactory.CreateBinding(TheVM, "RasterRadialOffset", vm =>
            { txtRadialOffset.Value = vm.RasterRadialOffset; rasterControl1.RadialOffset = vm.RasterRadialOffset; }, null);
            BindingFactory.CreateBinding(TheVM, "RasterSteps", vm =>
            { txtRadialSteps.Value = vm.RasterSteps; rasterControl1.RasterRadialSteps = (uint)vm.RasterSteps; }, null);
            BindingFactory.CreateBinding(TheVM, "RasterWidth", vm =>
            { cmbGrid.Entry.Text = vm.RasterWidth.ToString(); rasterControl1.RasterWidth = vm.RasterWidth; }, null);
            txtRadialOffset.ValueChanged += (s, e) =>
            {
                //double d;
                //if (Double.TryParse(txtRadialOffset.TextBox.Text, out d))
                    TheVM.RasterRadialOffset = txtRadialOffset.Value;
            };
            txtRadialSteps.ValueChanged += (s, e) =>
            {
                //uint d;
                //if (UInt32.TryParse(txtRadialSteps.TextBox.Text, out d))
                    TheVM.RasterSteps = txtRadialSteps.ValueAsInt;
            };
            cmbGrid.Changed += (s, e) =>
            {
                double d;
                if (Double.TryParse(cmbGrid.ActiveText, out d))
                    TheVM.RasterWidth = d;
            };

            rasterControl1.ToolChanged += (sender, e) => TheVM.CurrentTool = rasterControl1.Tool;

            BindingFactory.CreateBinding(TheVM, "CurrentTool",
                vm =>
                {
                    ToolButtons.Each((tsb, i) => tsb.SetChecked((int)vm.CurrentTool == i));
                    rasterControl1.Tool = vm.CurrentTool;
                }, null);

            BindingFactory.CreateBinding(TheCompiler.Instance, "Compiling",
                (c) => { cmdAbortCompile.Sensitive = abortCompilationToolStripMenuItem.Sensitive = c.Compiling; },
                () => { cmdAbortCompile.Sensitive = abortCompilationToolStripMenuItem.Sensitive = true; });


        }


        void AddStatusLine(string StatusLine, bool IsError = false)
        {
            Application.Invoke(delegate
            {
                txtStatus.Buffer.Text += StatusLine + Environment.NewLine;
                /*int length = txtStatus.TextLength;  // at end of text
                string toAppend = StatusLine + Environment.NewLine;
                txtStatus.AppendText(toAppend);
                txtStatus.SelectionStart = length;
                txtStatus.SelectionLength = toAppend.Length;
                txtStatus.SelectionColor = IsError ? Color.Red : Color.Black;
                txtStatus.SelectionLength = 0;

                txtStatus.SelectionStart = txtStatus.Text.Length - 1;
                txtStatus.ScrollToCaret();*/
            });
        }

        protected override void OnRealized()
        {
            base.OnRealized();

            AddStatusLine("Welcome to TikzEdt!");
            AddStatusLine("This software is under development. All help/feedback/feature requests/error reports are welcome.");
            AddStatusLine("Application data is stored in " + Helper.GetAppdataPath() + ".");
            AddStatusLine("Working directory is now: " + Helper.GetCurrentWorkingDir());

            GlobalUI.UI.OnGlobalStatus += (s,e)=>AddStatusLine(e.StatusLine, e.IsError);
            TheCompiler.Instance.OnTexOutput += (s,e)=>txtTexOut.Buffer.Text += e.Message + Environment.NewLine;
            TheCompiler.Instance.OnCompileEvent += (s, e) =>
                {
                    AddStatusLine(e.Message, e.Type == TexCompiler.CompileEventType.Error);
                    if (e.Type == TexCompiler.CompileEventType.Start)
                        txtTexOut.Buffer.Clear();
                };
            TikzToBMPFactory.Instance.JobNumberChanged += new EventHandler(Instance_JobNumberChanged);

            if (!String.IsNullOrWhiteSpace(AppMethods.StartupFile))
                TheVM.LoadFile(AppMethods.StartupFile);
            else
                TheVM.CreateNewFile();

           // txtCode.SetText("This is Scintilla");
        }

        void Instance_JobNumberChanged(object sender, EventArgs e)
        {
           /* if (TikzToBMPFactory.Instance.JobsInQueue == 0)
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
            * */
        }

        private void CreateToolBars()
        {
            mainToolbar.ToolbarStyle = ToolbarStyle.Icons;
            toolsPaneBar.ToolbarStyle = ToolbarStyle.Icons;
            toolsPaneBar.Orientation = Orientation.Vertical;
            toolsToolbar.ToolbarStyle = ToolbarStyle.Icons;
            toolsToolbar.IconSize = IconSize.Menu;


            ToolButton T = new ToolButton(Stock.New);
            T.Clicked += (s, e) => TheVM.CreateNewFile();
            mainToolbar.Add(T);
            T = new ToolButton(Stock.Open);
            T.ButtonPressEvent += (s, e) => TheVM.Open();
            mainToolbar.Add(T);
            T = new ToolButton(Stock.Save);
            T.ButtonPressEvent += (s, e) => TheVM.Save();
            mainToolbar.Add(T);
            mainToolbar.Add(new SeparatorToolItem());

            T = new ToolButton(Stock.Copy);
            mainToolbar.Add(T);
            T = new ToolButton(Stock.Cut);
            mainToolbar.Add(T);
            T = new ToolButton(Stock.Paste);
            mainToolbar.Add(T);
            T = new ToolButton(Stock.Undo);
            mainToolbar.Add(T);
            T = new ToolButton(Stock.Redo);
            mainToolbar.Add(T);
            mainToolbar.Add(new SeparatorToolItem());

            T = new ToolButton(Stock.Execute);
            mainToolbar.Add(T);
            T.Clicked += (s, e) => TheVM.TheDocument.Recompile();
            T = cmdAbortCompile = new ToolButton(Stock.Cancel);
            T.Clicked += (s, e) => TheCompiler.Instance.AbortCompilation();
            mainToolbar.Add(T);

            mainToolbar.Add(new SeparatorToolItem());
            T = new ToolButton(Stock.Quit);
            T.Clicked += (s, e) => Application.Quit();
            mainToolbar.Add(T);

            T = new ToolButton(Stock.Home);
            toolsPaneBar.Add(T);
            T = new ToolButton(Stock.Index);
            toolsPaneBar.Add(T);
            T = new ToolButton(Stock.Execute);
            toolsPaneBar.Add(T);

            // tools toolbar
            /*RadioToolButton RT0 = null;
            RadioToolButton RT;
            RT0 = RT = new RadioToolButton(RT0);
            RT.IconWidget = Properties.Resources.base_cursor.ToImage();
            toolsToolbar.Add(RT);
            RT = new RadioToolButton(RT0);
            RT.IconWidget = Properties.Resources.bmpvert.ToImage();
            toolsToolbar.Add(RT);
            RT = new RadioToolButton(null, Stock.Add);
            //RT.IconWidget = Properties.Resources.bmpvert.ToImage();
            RT.Label = "jhgjhgJH";
            toolsToolbar.Add(RT);*/

            T = new ToolButton(Properties.Resources.base_cursor.ToImage(), "");
            toolsToolbar.Add(T);
            ToolButtons.Add(T);
            T = new ToolButton(Properties.Resources.bmpvert.ToImage(), "");
            toolsToolbar.Add(T); ToolButtons.Add(T);
            T = new ToolButton(Properties.Resources.edge.ToImage(), "");
            toolsToolbar.Add(T); ToolButtons.Add(T);
            T = new ToolButton(Properties.Resources.path.ToImage(), "");
            toolsToolbar.Add(T); ToolButtons.Add(T);
            T = new ToolButton(Properties.Resources.Bezier.ToImage(), "");
            toolsToolbar.Add(T); ToolButtons.Add(T);
            T = new ToolButton(Properties.Resources.Smooth.ToImage(), "");
            toolsToolbar.Add(T); ToolButtons.Add(T);
            T = new ToolButton(Properties.Resources.arc.ToImage(), "");
            toolsToolbar.Add(T); ToolButtons.Add(T);
            T = new ToolButton(Properties.Resources.arcedit.ToImage(), "");
            toolsToolbar.Add(T); ToolButtons.Add(T);
            T = new ToolButton(Properties.Resources.Rectangle.ToImage(), "");
            toolsToolbar.Add(T); ToolButtons.Add(T);
            T = new ToolButton(Properties.Resources.Ellipse.ToImage(), "");
            toolsToolbar.Add(T); ToolButtons.Add(T);
            T = new ToolButton(Properties.Resources.grid.ToImage(), "");
            toolsToolbar.Add(T); ToolButtons.Add(T);

            ToolButtons.Each((b, i) =>
            {
                OverlayToolType t = (OverlayToolType)i;
                b.Clicked += (s,e)=> TheVM.CurrentTool = t;
            });

            ToolItem it = new ToolItem();
            it.Add(new Label("Node style:"));
            toolsToolbar.Add(it);
            it = new ToolItem() { WidthRequest = 100 };
            it.Add( cmbNodeStyle =  ComboBoxEntry.NewText());
            toolsToolbar.Add(it);
            it = new ToolItem();
            it.Add(new Label("Edge style:"));
            toolsToolbar.Add(it);
            it = new ToolItem() { WidthRequest = 100 };
            it.Add(cmbEdgeStyle = ComboBoxEntry.NewText());
            toolsToolbar.Add(it);


            toolsToolbar.Add(new SeparatorToolItem());
            T = new ToolButton(Properties.Resources.radial.ToImage(), "");
            toolsToolbar.Add(T);

        }

        void CreateMenus()
        {
            MenuItem m = new MenuItem("File");
            m.Submenu = fileMenu;
            mainMenu.Append(m);

            m = new MenuItem("New");
            m.Activated += (s, e) => Application.Quit();
            fileMenu.Append(m);
            m = new MenuItem("Open");
            m.Activated += (s, e)=> Application.Quit();
            fileMenu.Append(m);
            m = new MenuItem("Save");
            m.Activated += (s, e)=> Application.Quit();
            fileMenu.Append(m);
            m = new MenuItem("Save As...");
            m.Activated += (s, e)=> Application.Quit();
            fileMenu.Append(m);
            fileMenu.Append(new SeparatorMenuItem());
            m = new MenuItem("Quit");
            m.Activated += (s, e)=> Application.Quit();
            fileMenu.Append(m);

            m = new MenuItem("Edit");
            m.Submenu = editMenu;
            mainMenu.Append(m);

            m = new MenuItem("Copy");
            m.Activated += (s, e) => Application.Quit();
            editMenu.Append(m);
            m = new MenuItem("Cut");
            m.Activated += (s, e) => Application.Quit();
            editMenu.Append(m);
            m = new MenuItem("Paste");
            m.Activated += (s, e) => Application.Quit();
            editMenu.Append(m);
            //fileMenu.Append(new SeparatorMenuItem());
            m = new MenuItem("Copy with picture environment");
            m.Activated += (s, e) => Application.Quit();
            editMenu.Append(m);


            m = new MenuItem("Compilation");
            m.Submenu = compileMenu;
            mainMenu.Append(m);

            m = new MenuItem("Compile");
            m.Activated += (s, e) => TheVM.TheDocument.Recompile();
            compileMenu.Append(m);
            m = abortCompilationToolStripMenuItem = new MenuItem("Abort Compilation");
            m.Activated += (s, e) => TheCompiler.Instance.AbortCompilation();
            compileMenu.Append(m);
            m = new MenuItem("Regenerate precompiled headers");
            m.Activated += (s, e) => TheCompiler.GeneratePrecompiledHeaders();
            compileMenu.Append(m);
            //fileMenu.Append(new SeparatorMenuItem());
            m = new MenuItem("Recompile snippets");
            m.Activated += (s, e) => { }; // todo
            compileMenu.Append(m);


            m = new MenuItem("Settings");
            m.Submenu = settingsMenu;
            mainMenu.Append(m);


            m = new MenuItem("Options");
            m.Activated += (s, e) => Application.Quit();
            settingsMenu.Append(m);


            m = new MenuItem("?");
            m.Submenu = helpMenu;
            mainMenu.Append(m);

            m = new MenuItem("Help");
            m.Activated += (s, e) => Application.Quit();
            helpMenu.Append(m);

        }

    }

    public static class Extensions
    {

        public static Image ToImage(this System.Drawing.Bitmap B)
        {
            using (var m = new MemoryStream())
            {
                B.Save(m, System.Drawing.Imaging.ImageFormat.Png);
                m.Seek(0, SeekOrigin.Begin);
                Image im = new Image(m);
                return im;
            }

        }

        public static void SetChecked(this ToolButton B, bool Checked)
        {
            if (Checked)
                B.ModifyBg(StateType.Normal, Colors.ButtonChecked);
            else
                B.ModifyBg(StateType.Normal, Colors.ButtonStd);
        }

    }

    public static class Colors
    {
        public static Gdk.Color ButtonChecked = new Gdk.Color(0,255,0);
        public static Gdk.Color ButtonStd = new Gdk.Color(192, 192,192);
    }
}
