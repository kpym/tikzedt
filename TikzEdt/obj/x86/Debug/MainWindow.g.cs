﻿#pragma checksum "..\..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "420223B04972505B0F3F933805D58361"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Common;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Editing;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Rendering;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using TikzEdt;
using TikzEdt.Properties;


namespace TikzEdt {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 65 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu menu1;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Common.RecentFileList RecentFileList;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdAbortCompilation;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkOverlay;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbGrid;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbZoom;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rb1;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rb2;
        
        #line default
        #line hidden
        
        
        #line 171 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rb3;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rb4;
        
        #line default
        #line hidden
        
        
        #line 181 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkAutoBB;
        
        #line default
        #line hidden
        
        
        #line 184 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBBX;
        
        #line default
        #line hidden
        
        
        #line 186 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBBY;
        
        #line default
        #line hidden
        
        
        #line 188 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBBW;
        
        #line default
        #line hidden
        
        
        #line 190 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBBH;
        
        #line default
        #line hidden
        
        
        #line 198 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition LeftMenuCol;
        
        #line default
        #line hidden
        
        
        #line 199 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition LeftToolsCol;
        
        #line default
        #line hidden
        
        
        #line 200 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition LeftSplitterCol;
        
        #line default
        #line hidden
        
        
        #line 206 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton cmdFiles;
        
        #line default
        #line hidden
        
        
        #line 212 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton cmdSnippets;
        
        #line default
        #line hidden
        
        
        #line 220 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TikzEdt.SnippetList snippetlist1;
        
        #line default
        #line hidden
        
        
        #line 228 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox txtStatus;
        
        #line default
        #line hidden
        
        
        #line 229 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ICSharpCode.AvalonEdit.TextEditor txtCode;
        
        #line default
        #line hidden
        
        
        #line 250 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TikzEdt.RasterControl rasterControl1;
        
        #line default
        #line hidden
        
        
        #line 251 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TikzEdt.TikzDisplay tikzDisplay1;
        
        #line default
        #line hidden
        
        
        #line 252 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TikzEdt.PdfOverlay pdfOverlay1;
        
        #line default
        #line hidden
        
        
        #line 258 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.StatusBar statusBar1;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TikzEdt;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 12 "..\..\..\MainWindow.xaml"
            ((TikzEdt.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\MainWindow.xaml"
            ((TikzEdt.MainWindow)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\MainWindow.xaml"
            ((TikzEdt.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 32 "..\..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.OpenCommandHandler);
            
            #line default
            #line hidden
            
            #line 33 "..\..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.AlwaysTrue);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 36 "..\..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.SaveCommandHandler);
            
            #line default
            #line hidden
            
            #line 37 "..\..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.AlwaysTrue);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 40 "..\..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.SaveAsCommandHandler);
            
            #line default
            #line hidden
            
            #line 41 "..\..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.AlwaysTrue);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 44 "..\..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.NewCommandHandler);
            
            #line default
            #line hidden
            
            #line 45 "..\..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.AlwaysTrue);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 48 "..\..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.CommentCommandHandler);
            
            #line default
            #line hidden
            
            #line 49 "..\..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.AlwaysTrue);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 51 "..\..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.UnCommentCommandHandler);
            
            #line default
            #line hidden
            
            #line 52 "..\..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.AlwaysTrue);
            
            #line default
            #line hidden
            return;
            case 8:
            this.menu1 = ((System.Windows.Controls.Menu)(target));
            return;
            case 9:
            this.RecentFileList = ((Common.RecentFileList)(target));
            return;
            case 10:
            
            #line 87 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.CompileClick);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 88 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.AbortCompilationClick);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 91 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.SnippetMenuClick);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 92 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.SettingsMenuClick);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 93 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.TestClick);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 94 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.TestUpdClick);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 119 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CompileClick);
            
            #line default
            #line hidden
            return;
            case 17:
            this.cmdAbortCompilation = ((System.Windows.Controls.Button)(target));
            
            #line 125 "..\..\..\MainWindow.xaml"
            this.cmdAbortCompilation.Click += new System.Windows.RoutedEventHandler(this.AbortCompilationClick);
            
            #line default
            #line hidden
            return;
            case 18:
            this.chkOverlay = ((System.Windows.Controls.CheckBox)(target));
            
            #line 130 "..\..\..\MainWindow.xaml"
            this.chkOverlay.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            
            #line default
            #line hidden
            
            #line 130 "..\..\..\MainWindow.xaml"
            this.chkOverlay.Unchecked += new System.Windows.RoutedEventHandler(this.chkOverlay_Unchecked);
            
            #line default
            #line hidden
            return;
            case 19:
            this.cmbGrid = ((System.Windows.Controls.ComboBox)(target));
            
            #line 136 "..\..\..\MainWindow.xaml"
            this.cmbGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 144 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cmdZoomOutClick);
            
            #line default
            #line hidden
            return;
            case 21:
            this.cmbZoom = ((System.Windows.Controls.ComboBox)(target));
            
            #line 147 "..\..\..\MainWindow.xaml"
            this.cmbZoom.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbZoom_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 147 "..\..\..\MainWindow.xaml"
            this.cmbZoom.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.cmbZoom_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 23:
            
            #line 161 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cmdZoomInClick);
            
            #line default
            #line hidden
            return;
            case 24:
            this.rb1 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 165 "..\..\..\MainWindow.xaml"
            this.rb1.Checked += new System.Windows.RoutedEventHandler(this.rb1_Checked);
            
            #line default
            #line hidden
            return;
            case 25:
            this.rb2 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 168 "..\..\..\MainWindow.xaml"
            this.rb2.Checked += new System.Windows.RoutedEventHandler(this.rb1_Checked);
            
            #line default
            #line hidden
            return;
            case 26:
            this.rb3 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 171 "..\..\..\MainWindow.xaml"
            this.rb3.Checked += new System.Windows.RoutedEventHandler(this.rb1_Checked);
            
            #line default
            #line hidden
            return;
            case 27:
            this.rb4 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 174 "..\..\..\MainWindow.xaml"
            this.rb4.Checked += new System.Windows.RoutedEventHandler(this.rb1_Checked);
            
            #line default
            #line hidden
            return;
            case 28:
            this.chkAutoBB = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 29:
            this.txtBBX = ((System.Windows.Controls.TextBox)(target));
            return;
            case 30:
            this.txtBBY = ((System.Windows.Controls.TextBox)(target));
            return;
            case 31:
            this.txtBBW = ((System.Windows.Controls.TextBox)(target));
            return;
            case 32:
            this.txtBBH = ((System.Windows.Controls.TextBox)(target));
            return;
            case 33:
            this.LeftMenuCol = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 34:
            this.LeftToolsCol = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 35:
            this.LeftSplitterCol = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 36:
            this.cmdFiles = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 206 "..\..\..\MainWindow.xaml"
            this.cmdFiles.Checked += new System.Windows.RoutedEventHandler(this.cmdSnippets_Checked);
            
            #line default
            #line hidden
            
            #line 206 "..\..\..\MainWindow.xaml"
            this.cmdFiles.Unchecked += new System.Windows.RoutedEventHandler(this.cmdSnippets_Unchecked);
            
            #line default
            #line hidden
            return;
            case 37:
            this.cmdSnippets = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 212 "..\..\..\MainWindow.xaml"
            this.cmdSnippets.Checked += new System.Windows.RoutedEventHandler(this.cmdSnippets_Checked);
            
            #line default
            #line hidden
            
            #line 212 "..\..\..\MainWindow.xaml"
            this.cmdSnippets.Unchecked += new System.Windows.RoutedEventHandler(this.cmdSnippets_Unchecked);
            
            #line default
            #line hidden
            return;
            case 38:
            this.snippetlist1 = ((TikzEdt.SnippetList)(target));
            return;
            case 39:
            this.txtStatus = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 40:
            this.txtCode = ((ICSharpCode.AvalonEdit.TextEditor)(target));
            
            #line 229 "..\..\..\MainWindow.xaml"
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            
            #line default
            #line hidden
            return;
            case 41:
            this.rasterControl1 = ((TikzEdt.RasterControl)(target));
            return;
            case 42:
            this.tikzDisplay1 = ((TikzEdt.TikzDisplay)(target));
            return;
            case 43:
            this.pdfOverlay1 = ((TikzEdt.PdfOverlay)(target));
            return;
            case 44:
            this.statusBar1 = ((System.Windows.Controls.Primitives.StatusBar)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 22:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Primitives.TextBoxBase.TextChangedEvent;
            
            #line 150 "..\..\..\MainWindow.xaml"
            eventSetter.Handler = new System.Windows.Controls.TextChangedEventHandler(this.cmbZoomTextChanged);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}
