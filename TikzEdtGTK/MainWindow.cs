using System;
using System.Collections.Generic;
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
        Menu fileMenu = new Menu(), editMenu = new Menu(), helpMenu = new Menu();
        Toolbar mainToolbar = new Toolbar(), toolsToolbar = new Toolbar(), toolsPaneBar = new Toolbar();
        Statusbar statusBar = new Statusbar();

        RasterControl rasterControl1 = new RasterControl();

        HPaned hSplitter1 = new HPaned();
        HPaned hSplitter2 = new HPaned();
        VPaned vSplitter1 = new VPaned();

        //TextBuffer StatusBuffer = new TextBuffer(
        TextView txtStatus = new TextView(), txtTexOut = new TextView();
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
            

            statusTabPanel.AppendPage(txtStatus, new Label("Status"));
            statusTabPanel.AppendPage(lstErrors, new Label("Errors"));
            statusTabPanel.AppendPage(txtTexOut, new Label("TeX Output"));

            //txtCode.SetText("This is Scintilla");

            vSplitter1.Add1(txtCode);
            vSplitter1.Add2(statusTabPanel);
            vSplitter1.Position = 400;

            hSplitter1.Add1(vSplitter1);
            var sw = new ScrolledWindow();
            sw.Add(rasterControl1);
            hSplitter1.Add2(sw);
            hSplitter1.Position = 350;

            hSplitter2.Add1(new TextView() );
            hSplitter2.Add2(hSplitter1);
            hSplitter2.Position = 150;
            hb.PackStart(hSplitter2, true, true, 0);

            vb.PackStart(hb, true, true, 0);
            vb.PackEnd(statusBar, false, false, 0);

            Add(vb);
            ShowAll();

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
            T = new ToolButton(Stock.Cancel);
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
            T = new ToolButton(Properties.Resources.bmpvert.ToImage(), "");
            toolsToolbar.Add(T);
            T = new ToolButton(Properties.Resources.edge.ToImage(), "");
            toolsToolbar.Add(T);
            T = new ToolButton(Properties.Resources.path.ToImage(), "");
            toolsToolbar.Add(T);
            T = new ToolButton(Properties.Resources.Bezier.ToImage(), "");
            toolsToolbar.Add(T);
            T = new ToolButton(Properties.Resources.Smooth.ToImage(), "");
            toolsToolbar.Add(T);
            T = new ToolButton(Properties.Resources.arc.ToImage(), "");
            toolsToolbar.Add(T);
            T = new ToolButton(Properties.Resources.arcedit.ToImage(), "");
            toolsToolbar.Add(T);
            T = new ToolButton(Properties.Resources.Rectangle.ToImage(), "");
            toolsToolbar.Add(T);
            T = new ToolButton(Properties.Resources.Ellipse.ToImage(), "");
            toolsToolbar.Add(T);
            T = new ToolButton(Properties.Resources.grid.ToImage(), "");
            toolsToolbar.Add(T);

            ToolItem it = new ToolItem();
            it.Add(new Label("Node style:"));
            toolsToolbar.Add(it);
            it = new ToolItem() { WidthRequest = 100 };
            it.Add(new ComboBoxEntry());
            toolsToolbar.Add(it);
            it = new ToolItem();
            it.Add(new Label("Edge style:"));
            toolsToolbar.Add(it);
            it = new ToolItem() { WidthRequest = 100 };
            it.Add(new ComboBoxEntry());
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

    }
}
