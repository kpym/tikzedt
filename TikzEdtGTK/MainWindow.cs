using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gtk;
using Sansguerre;

namespace TikzEdtGTK
{
    class MainWindow : Window
    {
        Label myLabel = new Label();
        MenuBar mainMenu = new MenuBar();
        Menu fileMenu = new Menu(), editMenu = new Menu(), helpMenu = new Menu();
        Toolbar mainToolbar = new Toolbar(), toolsToolbar = new Toolbar(), toolsPaneBar = new Toolbar();

        HPaned hSplitter1 = new HPaned();
        VPaned vSplitter1 = new VPaned();

        TextView txtStatus = new TextView(), txtTexOut = new TextView();
        TreeView lstErrors = new TreeView();

        GtkScintilla txtCode = new GtkScintilla();

        Notebook statusTabPanel = new Notebook();

        Gtk.Action actOpen = new Gtk.Action("Open", "Open", "Open file", Stock.Open);

        public MainWindow() : base("TikzEdt ")
        {
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

            txtCode.SetText("This is Scintilla");

            vSplitter1.Add1(txtCode);
            vSplitter1.Add2(statusTabPanel);
            vSplitter1.Position = 400;

            hSplitter1.Add1(vSplitter1);
            hSplitter1.Add2(myLabel);
            hSplitter1.Position = 350;
            
            hb.PackStart(hSplitter1, true, true, 0);



            vb.PackStart(hb, true, true, 0);
            

            Add(vb);
            ShowAll();

        }

        private void CreateToolBars()
        {
            mainToolbar.ToolbarStyle = ToolbarStyle.Icons;
            toolsPaneBar.ToolbarStyle = ToolbarStyle.Icons;
            toolsPaneBar.Orientation = Orientation.Vertical;
            toolsToolbar.ToolbarStyle = ToolbarStyle.Icons;



            ToolButton T = new ToolButton(Stock.New);
            mainToolbar.Add(T);
            T = new ToolButton(Stock.Open);
            mainToolbar.Add(T);
            T = new ToolButton(Stock.Save);
            mainToolbar.Add(T);
            mainToolbar.Add(new SeparatorToolItem());
            T = new ToolButton(Stock.Quit);
            mainToolbar.Add(T);


            T = new ToolButton(Stock.Harddisk);
            toolsPaneBar.Add(T);
            T = new ToolButton(Stock.Harddisk);
            toolsPaneBar.Add(T);
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
}
