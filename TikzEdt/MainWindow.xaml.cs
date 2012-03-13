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
using System.Xml;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.CodeCompletion;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using TikzEdt.Parser;
using FileDownloaderApp;
using TikzEdt.ViewModels;
using System.Windows.Threading;
using System.Windows.Interop;
using TESharedComponents;
using System.Diagnostics;
using System.ComponentModel;

namespace TikzEdt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindowVM TheVM { get; set; }
        public static Common.RecentFileList recentFileList;               

    //    public static RoutedCommand CompileCommand = new RoutedCommand();
        //public static RoutedCommand FindNextCommand = new RoutedCommand();
        //public static RoutedCommand FindPreviousCommand = new RoutedCommand();
        public static RoutedCommand CommentCommand = new RoutedCommand();
        public static RoutedCommand UnCommentCommand = new RoutedCommand();
        //public static RoutedCommand ShowCodeCompletionsCommand = new RoutedCommand();
        //public static RoutedCommand SavePdfCommand = new RoutedCommand();
        //public static RoutedCommand SavePdfAsCommand = new RoutedCommand();
        public static RoutedCommand ShowPdfCommand = new RoutedCommand();
        //public static RoutedCommand ExportFileCommand = new RoutedCommand();
        public static RoutedCommand OpenPgfManualCommand = new RoutedCommand();

        FindReplace.FindReplaceMgr FindReplaceManager = new FindReplace.FindReplaceMgr();

        public TESharedComponents.UpdateChecker updateChecker = new TESharedComponents.UpdateChecker() { VersionInfoURL = Consts.VersionInfoURL };

 /*       System.ComponentModel.BackgroundWorker AsyncParser = new System.ComponentModel.BackgroundWorker();
        class AsyncParserJob
        {
            public string code;
            public long DocumentID;
            public AsyncParserJob(string tcode, long tDocumentID)
            {
                code = tcode; DocumentID = tDocumentID;
            }
        }

        // the current file
        private string _CurFile= Consts.defaultCurFile;
        string CurFile
        {
            get { return _CurFile; }
            set
            {
                _CurFile = value;
                string AbsoluteCurFilePath = "";
                //if file is relative, add current work dir.
                if (System.IO.Path.GetDirectoryName(_CurFile) == "")
                    AbsoluteCurFilePath = Helper.GetCurrentWorkingDir() + "\\" + _CurFile;
                else
                    AbsoluteCurFilePath = _CurFile;

                Title = "TikzEdt: ";
                if (Properties.Settings.Default.ShowFullPathInTitle)
                    Title += AbsoluteCurFilePath;
                else
                    Title += System.IO.Path.GetFileName(AbsoluteCurFilePath);

                if (TheVM.TheDocument.ChangesMade)
                    Title += "*";
                // Add to MRU
                if (!CurFileNeverSaved)
                {
                    RecentFileList.InsertFile(AbsoluteCurFilePath);
                }

            }
        }
        */
        /// <summary>
        /// The document ID uniquely identifies the current document. It is used to assure that results of 
        /// asynchronous operations (parser & pdflatex) can be matched with the document they belong to.
        /// Note that a problem arises, e.g., when
        ///     one changes the file-> it gets compiled with pdflatex-> now one hits newfile
        ///     -> the compiler returns -> if careless, the wrong file is displayed.
        /// 
        /// </summary>
    //    long CurDocumentID=0;

        /// <summary>
        /// indicates whether current file has never been saved (=created with new file and not yet saved)
        /// </summary>
  //      bool CurFileNeverSaved = false;
        // indicates whether changes (that need to be saved) are made to the current file
   /*     private bool _ChangesMade = false;
        public bool ChangesMade
        {
            get { return _ChangesMade; }
            set
            {
                _ChangesMade = value;
                CurFile = CurFile;
            }
        }

        private bool _useBB;
        bool useBB
        {
            get { return _useBB;}
            set
            {
                _useBB = value;
                if (value == true)
                { }
            }
        }
        private Rect _currentBB = new Rect(Properties.Settings.Default.BB_Std_X, Properties.Settings.Default.BB_Std_Y, Properties.Settings.Default.BB_Std_W, Properties.Settings.Default.BB_Std_H);
        /// <summary>
        /// The currently active bounding box.
        /// </summary>
        Rect currentBB
        {
            get { return _currentBB; }
            set
            {
                _currentBB = value;

                CoordinateStatusBarItem.Content = "Bounding Box: ("+Math.Round(currentBB.X,2) + ", " + Math.Round(currentBB.Y,2) + ") ("
                    +Math.Round(currentBB.X+currentBB.Width,2) + ", " + Math.Round(currentBB.Y+currentBB.Height,2) + ")";

                // add some margin
                Rect bigger = currentBB;
                bigger.Inflate(Properties.Settings.Default.BB_Margin, Properties.Settings.Default.BB_Margin);
                pdfOverlay1.BB = bigger;
                rasterControl1.BB = bigger;
            }
        }
        /// <summary>
        /// Indicates whether the current BB is valid for the pdf currently displayed.
        /// It can be invalid upon failure to determine the bounding box.
        /// In this case, the bounding box (in wysiwyg mode at least) should be determined from the pdf's size.
        /// </summary>
        bool BBvalid = true;

        bool _ParseNeeded = false;
        bool ParseNeeded
        {
            get { return _ParseNeeded; }
            set
            {
                _ParseNeeded = value;
                if (_ParseNeeded && !AsyncParser.IsBusy)
                {
                    _ParseNeeded = false;
                    AsyncParser.RunWorkerAsync(new AsyncParserJob(txtCode.Text, CurDocumentID));
                }
            }
        }

        OpenFileDialog ofd = new OpenFileDialog();
        SaveFileDialog sfd = new SaveFileDialog();
   * 
   * */
    //    Editor.FindReplaceDialog FindDialog;
    //    Editor.CodeCompleter codeCompleter = new Editor.CodeCompleter();

        /// <summary>
        /// Indicates whether the form is succesfully loaded.
        /// This false on startup and set to true once and for all thereafter.
        /// </summary>
        public static bool isLoaded = false;
        public static bool isClosing = false;
        //public static List<TexOutputParser.TexError> TexErrors = new List<TexOutputParser.TexError>();
  //      public static System.Collections.ObjectModel.ObservableCollection<TexOutputParser.TexError> TexErrors = new System.Collections.ObjectModel.ObservableCollection<TexOutputParser.TexError>();
   //     public FileSystemWatcher fileWatcher = new FileSystemWatcher();
        public MainWindow()
        {
            this.DataContext = TheVM = new ViewModels.MainWindowVM(TheCompiler.Instance);
            InitializeComponent();
            
            // register GlobalUI events 
            GlobalUI.OnGlobalStatus += (s, e) => AddStatusLine(e.StatusLine, e.IsError);
            GlobalUI.OnExportCompile += (s, e) => ExportCompiler.ExportCompileDialog.Export(e.Code, e.File);
            GlobalUI.OnRecentFileEvent += (s, e) => { if (e.IsInsert) recentFileList.InsertFile(e.FileName); else recentFileList.RemoveFile(e.FileName); };
            GlobalUI.MessageBoxOwner = this;

            //make sure that double to string is converted with decimal point (not comma!)       
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");

            // set up command bindings
            CommandBindings.Add(TheVM.NewCommandBinding);
            CommandBindings.Add(TheVM.OpenCommandBinding);
            CommandBindings.Add(TheVM.SaveCommandBinding);
            CommandBindings.Add(TheVM.SaveAsCommandBinding);
            
            CommandBinding CommentCommandBinding = new CommandBinding(CommentCommand, CommentCommandHandler, AlwaysTrue);
            CommandBinding UnCommentCommandBinding = new CommandBinding(UnCommentCommand, UnCommentCommandHandler, AlwaysTrue);
       //     CommandBinding FindNextCommandBinding = new CommandBinding(FindNextCommand, FindNextCommandHandler, AlwaysTrue);
        //    CommandBinding FindPreviousCommandBinding = new CommandBinding(FindPreviousCommand, FindPreviousCommandHandler, AlwaysTrue);
        //    CommandBinding ShowCodeCompletionsCommandBinding = new CommandBinding(ShowCodeCompletionsCommand, ShowCodeCompletionsCommandHandler, AlwaysTrue);
        //    CommandBinding CompileCommandBinding = new CommandBinding(CompileCommand, CompileCommandHandler, AlwaysTrue);
       //     CommandBinding SavePdfCommandBinding = new CommandBinding(SavePdfCommand, SavePdfHandler, AlwaysTrue);
       //     CommandBinding SavePdfAsCommandBinding = new CommandBinding(SavePdfAsCommand, SavePdfAsHandler, AlwaysTrue);
            CommandBinding ShowPdfCommandBinding = new CommandBinding(ShowPdfCommand, ShowPdfHandler, AlwaysTrue);
       //     CommandBinding ExportFileCommandBinding = new CommandBinding(ExportFileCommand, ExportFileHandler, AlwaysTrue);
            CommandBinding OpenPgfManualBinding = new CommandBinding(OpenPgfManualCommand, OpenPgfManualHandler, AlwaysTrue); 
            
            pdfOverlay1.Rasterizer = rasterControl1;
      //      EnsureFindDialogExists();

            TikzToBMPFactory.Instance.JobNumberChanged += TikzToBmpFactory_JobNumberChanged;

            // set up find/replace dialog
            FindReplaceManager.CurrentEditor = new FindReplace.TextEditorAdapter(txtCode);
            FindReplaceManager.ShowSearchIn = false;
            FindReplaceManager.OwnerWindow = this;
            CommandBindings.Add(FindReplaceManager.FindBinding);
            CommandBindings.Add(FindReplaceManager.ReplaceBinding);
            CommandBindings.Add(FindReplaceManager.FindNextBinding);

            updateChecker.Status += (s, e) => AddStatusLine(e.Description, e.HasFailed);
            updateChecker.Success += new EventHandler<TESharedComponents.UpdateChecker.SuccessEventArgs>(updateChecker_Success);

            recentFileList = RecentFileList;
            recentFileList.UseXmlPersister(System.IO.Path.Combine(Helper.GetAppdataPath(), "RecentFileList.xml"));
            
            //recentFileList.UseXmlPersister();
       //     AsyncParser.DoWork += new System.ComponentModel.DoWorkEventHandler(AsyncParser_DoWork);
       //     AsyncParser.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(AsyncParser_RunWorkerCompleted);

            //fileWatcher.NotifyFilter = NotifyFilters.LastWrite;
    //        fileWatcher.Changed += new FileSystemEventHandler(fileWatcher_Changed);

            this.KeyDown += new KeyEventHandler(MainWindow_KeyDown);

            // Register events with the global compiler
            TheCompiler.Instance.OnCompileEvent += TexCompiler_OnCompileEvent;
      //      TheCompiler.Instance.JobSucceeded += new TexCompiler.JobEventHandler(TheCompiler_JobSucceeded);
      //      TheCompiler.Instance.OnTexError += new TexCompiler.TexErrorHandler(addProblemMarker);
            TheCompiler.Instance.OnTexOutput += TexCompiler_OnTexOutput;
            //tikzDisplay1.TexCompilerToListen = TheCompiler.Instance;

            // manually bind dynamic preamble
            DependencyPropertyDescriptor dpd = DependencyPropertyDescriptor.FromProperty(DynPreamble.DynPreambleView.PreambleProperty, typeof(DynPreamble.DynPreambleView) );
            if (dpd != null)
            {
                dpd.AddValueChanged(preambleView, delegate
                {
                    if (TheVM != null) TheVM.DynamicPreamble = preambleView.Preamble;
                });
            }
            if (TheVM != null) TheVM.DynamicPreamble = preambleView.Preamble;

            // bind lstError to TexErrors (make sure that TexErrors is suitable object for data binding!)
            //lstErrors.ItemsSource = TexErrors;
            //lstErrors.Items.GroupDescriptions.Add(new System.ComponentModel.GroupDescription())
            //lstErrors.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("severity", System.ComponentModel.ListSortDirection.Ascending));

            // in the constructor:
  //          txtCode.TextArea.TextEntering += textEditor_TextArea_TextEntering;
  //          txtCode.TextArea.TextEntered += textEditor_TextArea_TextEntered;

  /*          ofd.CheckFileExists = true;
            ofd.ValidateNames = true;
            ofd.Filter = "Tex Files|*.tex"+"|All Files|*.*";
            sfd.Filter = "Tex Files|*.tex"+"|All Files|*.*";
            sfd.OverwritePrompt = true;
            sfd.ValidateNames = true;

   * */
            txtStatus.Document.Blocks.Clear();

            RecentFileList.MenuClick += (s, e) => {
                if (Keyboard.Modifiers.HasFlag(ModifierKeys.Control))
                    MainWindowVM.StartNewTEInstance( "\"" + e.Filepath + "\"");
                else if (TheVM.TheDocument.TryDisposeFile()) 
                    TheVM.LoadFile(e.Filepath); 
            };            

            //cmbGrid.SelectedIndex = 4;
        }

        void updateChecker_Success(object sender, TESharedComponents.UpdateChecker.SuccessEventArgs e)
        {
            if (e.HasNewerVersion)
            {
                Paragraph p = new Paragraph();
                p.Margin = new Thickness(0);
                p.Inlines.Add(new Run("There is a new version of TikzEdt. Version " + e.LatestVersion + " is available for download at "));                
                Hyperlink hl = new Hyperlink(new Run(e.DownloadURL));
                hl.NavigateUri = new Uri(e.DownloadURL);
                hl.RequestNavigate += (s, ee) =>
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(ee.Uri.AbsoluteUri));
                    ee.Handled = true;
                };
                p.Inlines.Add(hl);
                txtStatus.Document.Blocks.Add(p);
                EditingCommands.MoveToDocumentEnd.Execute(null, txtStatus);
                txtStatus.ScrollToEnd();

                //MessageBox.Show("A new version of TikzEdt is available. Your current version is " + e.CurrentVersion + ", the new version is " + e.LatestVersion + "."
                //    +Environment.NewLine + "Download: " +Environment.NewLine +"    " + e.DownloadURL + Environment.NewLine + "or see more download options: "
                //    + Environment.NewLine + "    " + e.WebpageURL, "New Version", MessageBoxButton.OK, MessageBoxImage.Information
                //    );
                MyMessageBox.ShowWithHyperlinks("A new version of TikzEdt is available. Your current version is " + e.CurrentVersion + ", the new version is " + e.LatestVersion + "."
                    + Environment.NewLine + "Download: " + Environment.NewLine + "    " + e.DownloadURL + Environment.NewLine + "or see more download options: "
                    + Environment.NewLine + "    " + e.WebpageURL, "New Version", MessageBoxImage.Information, this
                );
            }
            else
            {
                AddStatusLine("TikzEdt is up to date. The current version is "+e.CurrentVersion+".");

                GlobalUI.ShowMessageBox("Your current version of TikzEdt ("+e.CurrentVersion+ ") is the latest available.", "TikzEdt up to date",
                    MessageBoxButton.OK, MessageBoxImage.Information );
            }
        }

        void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (Properties.Settings.Default.CompileOnCTRLPressRadioButton)
            {
                if (e.Key == Key.LeftCtrl || e.Key == Key.RightCtrl)
                {
                    TheVM.TheDocument.Recompile();
                }
            }
        }

  /*      void fileWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            Dispatcher.Invoke(new Action( delegate() {
                // there is a well-known issue with filewatcher raising multiple events... so, as a hack, stop wtaching
                fileWatcher.EnableRaisingEvents = false;
                // the currently watched file was changed -> ask the user to reload
                switch (MessageBox.Show("The currently open file was modified outside the editor.\r\nDo you want to reload the file from disk?", 
                    "Modified outside TikzEdt", MessageBoxButton.YesNo, MessageBoxImage.Warning))
                {
                    case MessageBoxResult.Yes:
                        ChangesMade = false;
                        LoadFile(Directory.GetCurrentDirectory() + "\\" + CurFile); // here the filewatcher is turned on again implicitly
                        break;
                    case MessageBoxResult.No:
                        ChangesMade = true;
                        fileWatcher.EnableRaisingEvents = true;
                        break;
                } } ));
        }
        */
     /*     void TheCompiler_JobSucceeded(object sender, TexCompiler.Job job)
        {
          // it may happen that pdflatex returns after a new document has been created->then don't load the pdf
            if (job.DocumentID == CurDocumentID)
            {
                if (!job.GeneratePrecompiledHeaders)
                {
                    // set the currrent BB, if the BB could be determined.
                    // if not, and we are in preview mode, we have a problem
                    if (job.hasBB)
                    {
                        currentBB = job.BB;
                    }
                    BBvalid = job.hasBB;
                    // (re-)load the pdf to display                
                    string pdfpath = Helper.RemoveFileExtension(job.path) + ".pdf";
                    tikzDisplay1.PdfPath = pdfpath;
                }
            }
       
        }* */

        void TexCompiler_OnCompileEvent(object sender, TexCompiler.CompileEventArgs e)
        {
            AddStatusLine(e.Message, e.Type == TexCompiler.CompileEventType.Error);
            if (e.Type == TexCompiler.CompileEventType.Start)
            {
                txtTexout.Document.Blocks.Clear();
                //clearProblemMarkers();
            }
     
        } 


  /*      void AsyncParser_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            AsyncParserResultType Result = e.Result as AsyncParserResultType;
            if (Result == null)
                throw new Exception("AsyncParser_RunWorkerCompleted() can only handle e.Result  of type AsyncParserResultType!");

            // in case of outdated parse -> ignore
            if (Result.DocumentID != CurDocumentID)
                return;

            //check if error occurred
            if (Result.Error != null && Result.Error is RecognitionException)
            {
                RecognitionException ex = Result.Error as RecognitionException;
                string errmsg = ANTLRErrorMsg.ToString(ex, simpletikzParser.tokenNames);
                AddStatusLine("Couldn't parse code. " + errmsg, true);
                if (ex.Line == 0 && ex.CharPositionInLine == -1)
                {
                    addProblemMarker(errmsg, txtCode.LineCount, 0, Severity.ERROR, CurFile); 
                    
                }
                else
                {
                    addProblemMarker(errmsg, ex.Line, ex.CharPositionInLine, Severity.ERROR, CurFile); 
                }
                pdfOverlay1.SetParseTree(null, currentBB);
                ClearStyleLists();
                
            }
            else if (Result.Error != null)
            {
                string errmsg = Result.Error.GetType().ToString();
                if(Result.Error is Exception)
                    errmsg += ":" + ((Exception)Result.Error).Message;
                AddStatusLine("Couldn't parse code. " + errmsg, true);
                pdfOverlay1.SetParseTree(null, currentBB);
                ClearStyleLists();
            }
            else
            {
                // parsing succesfull
                Tikz_ParseTree tp = Result.ParseTree as Tikz_ParseTree;
                pdfOverlay1.SetParseTree(tp, currentBB);

                // if no other changes are pending, we can turn on editing again
                pdfOverlay1.AllowEditing = true;
                
                // fill the style list
                UpdateStyleLists(tp);

                //now check if a warning occured. That would be a parser error in an included file.                
                if (Result.Warning != null && Result.Warning is RecognitionException)
                {
                    RecognitionException ex = Result.Warning as RecognitionException;
                    string errmsg = ANTLRErrorMsg.ToString(ex, simpletikzParser.tokenNames);
                    AddStatusLine("Couldn't parse included file. " + errmsg, true);
                    if (ex.Line == 0 && ex.CharPositionInLine == -1)
                    {
                        addProblemMarker(errmsg, txtCode.LineCount, 0, Severity.WARNING, Result.WarningSource);

                    }
                    else
                    {
                        addProblemMarker(errmsg, ex.Line, ex.CharPositionInLine, Severity.WARNING, Result.WarningSource);                        
                    }

                }
                else if (Result.Warning != null && Result.Warning is ParserException)
                {
                    ParserException pe = Result.Warning as ParserException;
                    addProblemMarker(this, pe.e);
                }
                else if (Result.Warning != null && Result.Warning is Exception)
                {
                    string errmsg = ((Exception)Result.Warning).Message;
                    AddStatusLine("Couldn't parse included file " + Result.WarningSource + ". " + errmsg, true);
                }
            }

            // Restart parser if necessary
            ParseNeeded = ParseNeeded;
 
        } */

        /// <summary>
        /// The this is given from AsyncParser_DoWork() to AsyncParser_RunWorkerCompleted().
        /// </summary>
   /*     class AsyncParserResultType { 
            /// <summary>
            /// Holds the ParseTree of the main file (shown in txtCode) if successful.
            /// </summary>
            public Tikz_ParseTree ParseTree {get; set;}
            /// <summary>
            /// Holds an error if parsing of main file was not successful.
            /// </summary>
            public Exception Error { get; set; }
            /// <summary>
            /// Warning if parsing of an included file was not successful.
            /// </summary>
            public Exception Warning { get; set; }
            /// <summary>
            /// Name of the included file which could not be parsed.
            /// </summary>
            public string WarningSource { get; set; }
            /// <summary>
            /// The ID of the document that was parsed.
            /// </summary>
            public long DocumentID;
        }
        class ParserException : Exception
        {
            public ParserException(string message) : base(message) { }
            public TexOutputParser.TexError e;
        }
        // Unfortunately, due to a debugger "bug", the exception has to be caught and transferred into a cancelled event
        // this cancel event type is AsyncParserResultType. It is passed to AsyncParser_RunWorkerCompleted().
        void AsyncParser_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            AsyncParserResultType Result = new AsyncParserResultType();
            //make sure that double typed numbers are converted with decimal point (not comma!) to string
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");

            try
            {
                AsyncParserJob job = e.Argument as AsyncParserJob;
                Result.DocumentID = job.DocumentID;
                Tikz_ParseTree tp = TikzParser.Parse(job.code);
                Result.ParseTree = tp;                

                //include any styles from include files via \input cmd
                string inputfile = "";
                try
                {
                    //find input files using Regex
                    Regex InputsRegex = new Regex(@"(^[^%]*|\n[^\n%]*?)\\input{(?<file>.*)}", RegexOptions.Compiled);
                    MatchCollection files = InputsRegex.Matches(job.code);
                    foreach (Match file in files)
                    {
                        //open, read, parse, and close each included file.
                        inputfile = file.Groups["file"].ToString();
                        if (File.Exists(inputfile))
                        {
                            StreamReader sr = new StreamReader(inputfile);
                            string inputcode = sr.ReadToEnd();
                            sr.Close();
                            Tikz_ParseTree tp2 = TikzParser.ParseInputFile(inputcode);
                            //if tp2 == null there probably was nothing useful included.
                            if (tp2 != null)
                            {
                                //every style that was found in included file, add it to parse tree of main file.
                                foreach (KeyValuePair<string, Tikz_Option> style in tp2.styles)
                                {
                                    if(! Result.ParseTree.styles.ContainsKey(style.Key))
                                    {
                                        Result.ParseTree.styles.Add(style.Key, style.Value);
                                    }
                                    else
                                    {
                                        ParserException pe = new ParserException("");
                                        TexOutputParser.TexError te = new TexOutputParser.TexError();
                                        te.Message = "Style [" + style.Key + "] is defined multiple times. Check position " + style.Value.StartPosition() + " in " + inputfile + " and this definition.";
                                        te.pos = Result.ParseTree.styles[style.Key].StartPosition();
                                        te.severity = Severity.WARNING;
                                        pe.e = te;
                                        throw pe;
                                    }
                                }
                            }

                        }
                    }

                }
                catch (Exception ex)
                {
                    Result.Warning = ex;
                    Result.WarningSource = inputfile;
                }
            }
            catch (Exception ex)
            {                
                //never set e.Cancel = true;
                //if you do, you cannot access e.Result from AsyncParser_RunWorkerCompleted.
                Result.Error = ex;
                Result.WarningSource = CurFile;
            }
            finally
            {
                e.Result = Result;
            }
        }
        */
        void TikzToBmpFactory_JobNumberChanged(object sender, EventArgs e)
        {
            //Dispatcher.Invoke(new Action(
            //    delegate()
            //    {
                    if (TikzToBMPFactory.Instance.JobsInQueue == 0)
                    {
                        progressCompile.IsIndeterminate = false;
                        progressCompile.Visibility = Visibility.Collapsed;
                        textCompileInfo.Text = "Thumbnail compilation complete.";
                    }
                    else
                    {
                        progressCompile.IsIndeterminate = true;
                        textCompileInfo.Text = "Compiling thumbnails... (" + TikzToBMPFactory.Instance.JobsInQueue + " to go)";
                        progressCompile.Visibility = Visibility.Visible;
                    }
             //   }
             //   ));
        }

    //    CompletionWindow completionWindow;

  /*      void textEditor_TextArea_TextEntered(object sender, TextCompositionEventArgs e)
        {
            if (codeCompleter.CompletionTriggers.Contains(e.Text))
            {
                ShowCodeCompletionsCommand.Execute(null, this);
            }
        }

        static Regex _beginRegex = new Regex(@"^\\begin\{(?<tag>\s*\w*\s*)\}(?<content>.*)$", RegexOptions.Compiled);
        void textEditor_TextArea_TextEntering(object sender, TextCompositionEventArgs e)
        {
            // The following code auto-completes \begin{something} +<return> by inserting \end{something}
            // This autocompletion can be turned off in the settings
            if (e.Text == "\n")
            {
                if (Properties.Settings.Default.Editor_CompleteBegins)
                {
                    ICSharpCode.AvalonEdit.Document.DocumentLine l = txtCode.Document.GetLineByOffset(txtCode.CaretOffset);
                    //if (l.LineNumber > 0) //todo 1?
                    {
                        //get current line
                        string s = txtCode.Document.GetText(l.Offset, l.Length).Trim();                        
                        //and check if it contains \begin{
                        Match m = _beginRegex.Match(s);
                        if (m.Success && m.Groups["tag"] != null && m.Groups["content"] != null)
                        {
                            string tag = m.Groups["tag"].Value, content = m.Groups["content"].Value;
                            int cp = txtCode.CaretOffset;
                            string insert = "\\end{" + tag + "}";

                            //only insert if document does not already hold the corresponding \end{}
                            if (txtCode.Text.IndexOf(insert, cp) == -1)
                            {
                                txtCode.Document.Insert(l.Offset + l.Length, "\r\n" + insert);
                                txtCode.CaretOffset = cp;
                            }                            
                        }
                    }

                }
            }

            if (e.Text.Length > 0 && completionWindow != null)
            {
                if (!char.IsLetterOrDigit(e.Text[0]))
                {
                    // Whenever a non-letter is typed while the completion window is open,
                    // insert the currently selected element.
                    completionWindow.CompletionList.RequestInsertion(e);
                }
            }
            // Do not set e.Handled=true.
            // We still want to insert the character that was typed.
        }
        */

      /*  public void SetStandAloneStatus(bool IsStandAlone)
        {
            if (IsStandAlone)
                StandAloneStatusBarItem.Content = "[Document is standalone]";
            else
                StandAloneStatusBarItem.Content = "";
        } */


        public static void AddStatusLine(string text, bool lError = false)
        {
            if (Application.Current.Dispatcher.CheckAccess())
            {
                MainWindow mw = ((MainWindow)Application.Current.Windows[0]);
                if (mw != null)
                    mw._AddStatusLine(text, lError);
            }
            else
            {
                Application.Current.Dispatcher.Invoke(new Action(delegate()
                    {
                        MainWindow mw = ((MainWindow)Application.Current.Windows[0]);
                        if (mw != null)
                            mw._AddStatusLine(text, lError);
                    }
                    ));
            }
        }
        private void _AddStatusLine(string text, bool lError = false)
        {
            Paragraph p = new Paragraph();
            if (lError)
                p.Foreground = Brushes.Red;
            p.Margin = new Thickness(0);
            p.Inlines.Add(new Run(text));
            txtStatus.Document.Blocks.Add(p);
           
            EditingCommands.MoveToDocumentEnd.Execute(null, txtStatus);
            txtStatus.ScrollToEnd();
        }

        //private void tikzDisplay1_OnCompileEvent(string Message, TikzDisplay.CompileEventType type)
        //{
        //    AddStatusLine(Message, type == TikzDisplay.CompileEventType.Error);            
        //}

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            {
                //MessageBox.Show(Directory.GetCurrentDirectory());
                return;
            }

            
            AddStatusLine("Welcome to TikzEdt");
            AddStatusLine("This software is under development. All help/feedback/feature requests/error reports are welcome.");

            /*
            FrameworkElement overflowGrid = tlbMode.Template.FindName("OverflowGrid", tlbMode) as FrameworkElement;
            if (overflowGrid != null)
                overflowGrid.Visibility = Visibility.Collapsed;
            overflowGrid = tlbTools.Template.FindName("OverflowGrid", tlbTools) as FrameworkElement;
            if (overflowGrid != null)
                overflowGrid.Visibility = Visibility.Collapsed;
            overflowGrid = tlbZoom.Template.FindName("OverflowGrid", tlbZoom) as FrameworkElement;
            if (overflowGrid != null)
                overflowGrid.Visibility = Visibility.Collapsed;
            overflowGrid = tlbBB.Template.FindName("OverflowGrid", tlbBB) as FrameworkElement;
            if (overflowGrid != null)
                overflowGrid.Visibility = Visibility.Collapsed;
            overflowGrid = tlbMain.Template.FindName("OverflowGrid", tlbMain) as FrameworkElement;
            if (overflowGrid != null)
                overflowGrid.Visibility = Visibility.Collapsed;
            overflowGrid = tlbGrid.Template.FindName("OverflowGrid", tlbGrid) as FrameworkElement;
            if (overflowGrid != null)
                overflowGrid.Visibility = Visibility.Collapsed;
            */
            //cmbGrid.SelectedIndex = 4;

            //parse command line parameter... *** There seemed to be a problem with the CLA Parser I couldn't fix. Temporarily disabled it.
    /*        CLAParser.CLAParser CmdLine = new CLAParser.CLAParser("TikzEdt");
            CmdLine.ParameterPrefix = "-";
            CmdLine.Parameter(CLAParser.CLAParser.ParamAllowType.Optional, "", CLAParser.CLAParser.ValueType.String, "Path to file that is to be loaded on starting TikzEdt.");
            CmdLine.Parameter(CLAParser.CLAParser.ParamAllowType.Optional, "portable", CLAParser.CLAParser.ValueType.Bool, "Read configuration files from the application directory, else it is read from %appdata% folder. ");// + System.Windows.Forms.Application.UserAppDataPath);
            CmdLine.Parameter(CLAParser.CLAParser.ParamAllowType.Optional, "p", CLAParser.CLAParser.ValueType.Bool, "Read configuration files from the application directory, else it is read from %appdata% folder. ");
            CmdLine.AllowAdditionalParameters = false;
            try
            {
                CmdLine.Parse();
            }
            catch (CLAParser.CLAParser.CmdLineArgumentException Ex)
            {
                String msg = Ex.Message + Environment.NewLine + Environment.NewLine;
                msg += CmdLine.GetUsage() + Environment.NewLine + Environment.NewLine;
                msg += CmdLine.GetParameterInfo();
                GlobalUI.ShowMessageBox(msg, "Unknown command line arguments", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            */
            //do we need such a routine that checks whether all files are available?            
            /*string missing;
            if (FirstRunPreparations(out missing) == false)
            {
                AddStatusLine("Required file \"" + missing + "\" not found. Please reinstall program.", true);
            }*/

            //set path to user-defined application data. depending on cmdline parameter user data
            //is stored next to .exe or in %appdata%. If program dir is not writable %userappdata% is used.
            //if ( CmdLine["userapp"] != null || !Helper.IsAppDirWritable()) // hack: always use Appdata folder (...since I couldn't make HasWritePermissionOnDir work) 
            //if ( CmdLine["portable"] == null)
            //    Helper.SetAppdataPath(Helper.AppdataPathOptions.AppData);
            //else
            //    Helper.SetAppdataPath(Helper.AppdataPathOptions.ExeDir);

            AddStatusLine("Application data directory is " + Helper.GetAppdataPath());            

            AddStatusLine("Working directory is now: " + Helper.GetCurrentWorkingDir());
/*            if (!File.Exists(Helper.GetSettingsPath() + Consts.cSyntaxFile))
            {
                AddStatusLine("Syntax definitions not found", true);
            } else{
                XmlReader r = new XmlTextReader(Helper.GetSettingsPath() + Consts.cSyntaxFile);
                txtCode.SyntaxHighlighting = HighlightingLoader.Load(r,null);  //HighlightingManager.Instance..GetDefinition("C#");
                r.Close();
            } */

  //          codeCompleter.LoadCompletions(Helper.GetSettingsPath() + Consts.cCompletionsFile);            

            isLoaded = true;    // indicates that all components are loaded and can be safely accessed (.. is almost obsolete)
            //txtRadialOffset.Text = txtRadialOffset.Text;
            //txtRadialSteps.Text = txtRadialSteps.Text;

            ///Dictory handling:
            ///Upon opening a new file or loading one, the current
            ///directory is the to the corresponding path
            ///(i.e. %temp% or path of loaded file)
            ///use Helper.SetCurrentWorkingDir() to do that.
            ///all function calls assume that they are in the correct dir.


            // start checking for Updates?
            if (Properties.Settings.Default.CheckForUpdates)
                updateChecker.CheckForUpdatesAsync();

            // Open a new file 
            ApplicationCommands.New.Execute(null, this);
            
            //open file specified via command line parameter.            
            //if (CmdLine[""] != null)            
            //    TheVM.LoadFile(CmdLine[""]);
            if (!String.IsNullOrWhiteSpace( App.StartupFile ))
                TheVM.LoadFile(App.StartupFile);

            //TheVM.TheDocument.Recompile();
            //Width = Width - 1;
            if (Properties.Settings.Default.ShowTipsTricksWindow)
                (new TipsTricksWindow() { Owner=this }).ShowDialog();
        }

        
        /// <summary>
        /// Determines the current Bounding Box.
        /// Priorities are as follows:
        ///     1. If Auto unchecked, take manually specified BB
        ///     2. Otherwise, if TikzEdt Command BOUNDINGBOX present in t, then takes this BB.
        ///     3. Otherwise, determine BB automatically.
        ///     4. If this is impossible, leave the BB unchanged.
        /// </summary>
        /// <param name="t">The Parsetree used to determine the BB.</param>
        /// <returns>True if BB changed, false if same.</returns>
      /*  bool DetermineBB(Tikz_ParseTree t)
        {
            // not needed anymore
           

            Rect newBB = new Rect(Properties.Settings.Default.BB_Std_X, Properties.Settings.Default.BB_Std_Y, Properties.Settings.Default.BB_Std_W, Properties.Settings.Default.BB_Std_H);
            //Rect newBB2;
            bool lret = false;
            if (chkAutoBB.IsChecked == false)
            {
                // Parse
                double d;
                if (Double.TryParse(txtBBX.Text, out d))
                    if (d>-100 && d<100)
                        newBB.X=d;
                if (Double.TryParse(txtBBY.Text, out d))
                    if (d>-100 && d<100)
                        newBB.Y=d;
                if (Double.TryParse(txtBBW.Text, out d))
                    if (d>0 && d<100)
                        newBB.Width=d;
                if (Double.TryParse(txtBBH.Text, out d))
                    if (d>0 && d<100)
                        newBB.Height=d;
                lret = (currentBB != newBB);
                currentBB = newBB;
            }
            else
            {
                if (t != null)
                {
                    if (ParseForBBCommand(t, out newBB))
                    {
                        // BOUNDINGBOX command in code found
                        //txtBB.ToolTip = "";
                        //chkAutoBB.IsEnabled = false;
                        //txtBB.ToolTip = "BB determined in source code by BOUNDINGBOX command";
                        lret = (currentBB != newBB);
                        currentBB = newBB;
                    }
                    else if (t.GetBB(out newBB))
                    {
                        newBB.Inflate(Properties.Settings.Default.BB_Margin, Properties.Settings.Default.BB_Margin);
                        lret = (currentBB != newBB);
                        currentBB = newBB;
                    }
                }
            }
            return lret; 
        }*/
        /// <summary>
        /// Fills the currently displayed lists of styles from the parsetree provided
        /// </summary>
        /// <param name="t">The parse tree to extract the styles from</param>
     /*    private void UpdateStyleLists(Tikz_ParseTree t)
        {
           if (t == null) return;
            string oldsel = cmbNodeStyles.Text;
            cmbNodeStyles.Items.Clear();
            foreach (string s in t.styles.Keys)
            {
                cmbNodeStyles.Items.Add(s);
            }
            cmbNodeStyles.Text = oldsel;

            oldsel = cmbEdgeStyles.Text;
            cmbEdgeStyles.Items.Clear();
            foreach (string s in t.styles.Keys)
            {
                cmbEdgeStyles.Items.Add(s);
            }
            cmbEdgeStyles.Text = oldsel;
        }
        private void ClearStyleLists()
        {
          //  cmbNodeStyles.Items.Clear();
          //  cmbEdgeStyles.Items.Clear();
        } */

        /// <summary>
        /// Tries to find a BOUNDINGBOX command in the parsetree specified.
        /// </summary>
        /// <param name="t">The parsetree in which to search for BOUNDINGBOX commands.</param>
        /// <param name="BB">Contains the BB found after return.</param>
        /// <returns>Returns true if a valid BOUNDINGBOX command is found, false otherwise.</returns>
        bool ParseForBBCommand(Tikz_ParseTree t, out Rect BB)
        {
            // run through all commands in parsetree (only top level)
            BB = new Rect(Properties.Settings.Default.BB_Std_X, Properties.Settings.Default.BB_Std_Y, Properties.Settings.Default.BB_Std_W, Properties.Settings.Default.BB_Std_H);
            RegexOptions ro = new RegexOptions();
            ro = ro | RegexOptions.IgnoreCase;
            ro = ro | RegexOptions.Multiline;
            //string BB_RegexString = @".*BOUNDINGBOX[ \t\s]*=[ \t\s]*(?<left>[+-]?[0-9]+[.[0-9]+]?)+[ \t\s]+(?<bottom>[0-9])+[ \t\s]+(?<right>[0-9])+[ \t\s]+(?<top>[0-9])+[ \t\s]+.*";
            //string BB_RegexString = @".*BOUNDINGBOX[ \t\s]*=[ \t\s]*((?<left>[+-]?[0-9]+(\.[0-9]+)?)[ \t\s]*){4}.*";
            string BB_RegexString = @".*BOUNDINGBOX[ \t\s]*=[ \t\s]*(?<left>[+-]?[0-9]+(\.[0-9]+)?)+[ \t\s]+(?<bottom>[+-]?[0-9]+(\.[0-9]+)?)+[ \t\s]+(?<width>[+-]?[0-9]+(\.[0-9]+)?)+[ \t\s]+(?<height>[+-]?[0-9]+(\.[0-9]+)?)+[ \t\s]+.*";
            Regex BB_Regex = new Regex(BB_RegexString, ro);

            foreach (TikzParseItem tpi in t.Children)
            {
                if (tpi is Tikz_EdtCommand)
                {
                    Match m = BB_Regex.Match(tpi.text);

                    if (m.Success == true)
                    {
                        try
                        {
                            double x = Convert.ToDouble(m.Groups[5].Value);
                            double y = Convert.ToDouble(m.Groups[6].Value);
                            double width = Convert.ToDouble(m.Groups[7].Value);
                            double height = Convert.ToDouble(m.Groups[8].Value);

                            Rect newBB = new Rect(x, y, width, height);
                            //chkAutoBB.IsChecked = true;
                            //chkAutoBB.IsEnabled = false;
                            //txtBB.ToolTip = "Managed by source code";

                            if (width > 0 && height > 0)
                            {
                                BB = newBB;
                                return true;
                            }
                        }
                        catch (Exception) { /*width or height negative. ignore. */}


                    }
                }
            }
//                    else
//                    {

//                        chkAutoBB.IsEnabled = true;
//                        txtBB.ToolTip = "";
//                        DetermineBB(t);
//                    }
//                }

            return false;
            //try
            //{
            //    Tikz_ParseTree t = TikzParser.Parse(txtCode.Text);
            //    if (t == null) return;
                ////SourceManager.Parse(txtCode.Text);
                //Regex
                //TikzParser.TIKZEDT_CMD_COMMENT

                //UpdateStyleLists(t);
                // Refresh overlay                    
                //pdfOverlay1.SetParseTree(t, currentBB);
            //}
            //catch (Exception e)
            //{
            //    AddStatusLine("Couldn't parse code. " + e.Message, true);
            //    pdfOverlay1.SetParseTree(null, currentBB);
            //}
        }

        /// <summary>
        /// If the tex code is changed, this method Reompiles it.
        /// The action taken depends upon the currently active mode:
        /// Fancy Mode: 
        ///     Starts asynchronous parse and compile operations.
        ///     The compilation is done on a temporary file in the current document's folder.
        /// Standard Mode:
        ///     Compilation only, done on a temporary file in the current document's folder.
        /// Production Mode:
        ///     Compilation only, done on the current document directly (not on temp file).
        /// </summary>
        /// <param name="NoParse">Skip the parsing step if true. (compile only)</param>
    /*      private void Recompile(bool NoParse = false)
        {
          // Parse and compile, depending on current mode
            string path = CurFile + Helper.GetPreviewFilename() + Helper.GetPreviewFilenameExt();
            if (CurFileNeverSaved)
                path = "";      // use a temp file in the application directory

            if (chkFancyMode.IsChecked == true)
            {
                if (ProgrammaticTextChange || NoParse)
                {
                    //DetermineBB(pdfOverlay1.ParseTree);
                    //pdfOverlay1.BB = currentBB;
                }
                else
                {
                    //start asynchronous parsing if there is something todo, otherwise clear canvas
                    //if (!(txtCodeWasEmpty == true && txtCode.Text.Trim() == ""))
                    if (txtCode.Text.Trim() != "")
                    {
                        pdfOverlay1.AllowEditing = false;   // overlay out of date->turn off editing
                        ParseNeeded = true;
                    }
                    else
                    {
                        pdfOverlay1.Clear();
                        pdfOverlay1.AllowEditing = true;
                    }
                }

                // Always Compile tex
                //tikzDisplay1.Compile(txtCode.Text, currentBB, TexCompiler.IsStandalone(txtCode.Text));
                //rasterControl1.BB = currentBB;

                //start compiling if NOT: txtCode was empty and still is empty now
                //if (!(txtCodeWasEmpty == true && txtCode.Text.Trim() == ""))
                //    TheCompiler.Instance.AddJobExclusive(txtCode.Text, path, currentBB);

                //compiling only must be started if there is latex code
                if( txtCode.Text.Trim() != "")
                    TheCompiler.Instance.AddJobExclusive(txtCode.Text, path, true, CurDocumentID);
                else
                    tikzDisplay1.SetUnavailable();
            }
            else if (chkStandardMode.IsChecked == true)
            {
                //tikzDisplay1.Compile(txtCode.Text, new Rect(0, 0, 0, 0), TexCompiler.IsStandalone(txtCode.Text));

                TheCompiler.Instance.AddJobExclusive(txtCode.Text, path, false, CurDocumentID);
            }
            else
            {
                if (SaveCurFile())
                    TheCompiler.Instance.AddJobExclusive(CurFile, CurDocumentID);
                else
                    tikzDisplay1.SetUnavailable();
            } 
        }

        public void txtCode_TextChanged(object sender, EventArgs e)
        {
            
            if (isLoaded)
            {
                ChangesMade = true;

                //only compile on keypress if code change option enabled.
                if (Properties.Settings.Default.CompileOnCodeChangeRadioButton == false)
                    return;

                if (txtCode.IsModified == false)
                    return;
                
                // no auto-compilation in Production Mode (no Auto saving)
                if (chkProductionMode.IsChecked == true)
                    return;

                Recompile();
            }
        }*/

     /*   private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            //if (pdfOverlay1 != null)
            //    pdfOverlay1.Visibility = Visibility.Visible;
        }

        private void chkOverlay_Unchecked(object sender, RoutedEventArgs e)
        {
            //if (pdfOverlay1 != null)
            //    pdfOverlay1.Visibility = Visibility.Hidden;
        }

        private void Image_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        } */

        
        /// <summary>
        /// Loads a file and sets the current directory to its containing folder.
        /// </summary>
        /// <param name="cFile">Specify file to load. This must be a full path (not relative).</param>
    /*    private void LoadFile(string cFile)
        {
            if (!File.Exists(cFile))
            {
                MessageBox.Show("Error: File not found: " + cFile, "File not found", MessageBoxButton.OK, MessageBoxImage.Error);
                RecentFileList.RemoveFile(cFile);
                return;
            }

            //clean everything before loading file:
            CleanupForNewFile();

            //set current dir to dir containing cFile.
            Helper.SetCurrentWorkingDir(Helper.WorkingDirOptions.DirFromFile, cFile);
            AddStatusLine("Working directory is now: " + Helper.GetCurrentWorkingDir());

            StreamReader stream = new StreamReader(cFile);
            try {
                string newcode = stream.ReadToEnd();
                tikzDisplay1.SetUnavailable(); // new file is directly compiled... but set unavailable in case error occurs
                pdfOverlay1.SetParseTree(null, currentBB);
                ClearStyleLists();
                CurFile = System.IO.Path.GetFileName(cFile); //always working in current dir, no need for absolute path.
                ChangesMade = false;
                CurFileNeverSaved = false;

                txtCode.Text = newcode;
                ChangesMade = false;  // set here since txtCode sets ChangesMade on Text change

                // start watching for external changes
                fileWatcher.Path = Directory.GetCurrentDirectory();
                fileWatcher.Filter = CurFile;
                fileWatcher.EnableRaisingEvents = true;

                //if compiling only on CTRL, compile after loading file
                //(otherwise loaded file is compiled because txtCode was changed)
                if (Properties.Settings.Default.CompileOnCTRLPressRadioButton)
                    Recompile();
            }
            catch (Exception Ex)
            {

                
                string d = Ex.Message;
                AddStatusLine(d, true);
                MessageBox.Show("Error: Could not load " + cFile + ". Is it in the correct format?",
                    "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                stream.Close();
            }

            ShowFilesOfCurrentDirectory();  
            
        }*/

  /*      private void ShowFilesOfCurrentDirectory()
        {
            lstFiles.Items.Clear();

            string[] Files = Directory.GetFiles(Helper.GetCurrentWorkingDir(), "*" + Helper.GetPreviewFilenameExt());            

            foreach (string file in Files)
            {
                if (!file.EndsWith(Helper.GetPreviewFilename() + Helper.GetPreviewFilenameExt()) && !System.IO.Path.GetFileName(file).StartsWith(Consts.cTempFile))
                {
                    TextBlock textBlock1 = new TextBlock();
                    textBlock1.Text = System.IO.Path.GetFileNameWithoutExtension(file);
                   
                    if (System.IO.Path.GetFileName(file) == CurFile)
                    {
                        lstFiles.SelectedIndex = lstFiles.Items.Count;
                        //textBlock1.FontStyle = System.Windows.FontStyles.Oblique;
                        textBlock1.FontWeight = System.Windows.FontWeights.Bold;
                    }
                    lstFiles.Items.Add(textBlock1);


                }
            }

            
        }*/


 /*       private bool TryDisposeFile(bool DeleteTemporaryFiles = true)
        {
            if (ChangesMade)
            {
                switch (MessageBox.Show("Save changes to " + CurFile + "?", "Changes need to be saved",
                    MessageBoxButton.YesNoCancel, MessageBoxImage.Warning))
                {
                    case (MessageBoxResult.Yes):
                        if (!SaveCurFile()) return false;
                        break;
                    case (MessageBoxResult.Cancel):
                        return false;
                }
            }
            if (DeleteTemporaryFiles)
            {
                //before delete temp data, we have to cloase the pdf
                tikzDisplay1.SetUnavailable();

                if (CurFile == Consts.defaultCurFile)
                    Helper.DeleteTemporaryFiles(Helper.GetTempFileName(), true);
                else
                    Helper.DeleteTemporaryFiles(CurFile);
            }
            return true;
        }
        private void OpenCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            //ofd.InitialDirectory = System.IO.Path.GetDirectoryName(CurFile);
            ofd.InitialDirectory = Directory.GetCurrentDirectory();
            ofd.FileName = System.IO.Path.GetFileName(CurFile);
            if (ofd.ShowDialog() == true)
            {
                if (TryDisposeFile())
                    LoadFile(ofd.FileName);
            }
        }

        bool SaveCurFile(bool saveas = false)
        {
            bool isTempFile = false;
            if (CurFile == Consts.defaultCurFile)
                isTempFile = true;
            string OldFileName = CurFile;                 

            sfd.FileName = System.IO.Path.GetFileName(CurFile);
            //sfd.InitialDirectory = System.IO.Path.GetDirectoryName(CurFile);
            sfd.InitialDirectory = Directory.GetCurrentDirectory();

            bool WeNeedRecompilationAfterSave = false;
            if (CurFileNeverSaved || saveas)
            {
                if (sfd.ShowDialog() != true)
                    return false;
                else CurFile = sfd.FileName; //note temporarily CurFile is absolute.
                WeNeedRecompilationAfterSave = true;
            }

            // turn off listening for changes... we don't want to catch our change
            fileWatcher.EnableRaisingEvents = false;

            StreamWriter wr = new StreamWriter(CurFile);
            wr.Write(txtCode.Text);
            wr.Close();
            ChangesMade = false;
            CurFileNeverSaved = false;
            AddStatusLine("File saved to " + CurFile + ".");

            //delete old temp data.
            if (saveas)
            { 
                //before delete temp data, we have to close the pdf
                tikzDisplay1.SetUnavailable();

                //if file was not saved yet, this data is in temp folder.
                if (isTempFile)
                {
                    //current work dir still is temp dir

                    //delete temp files there.
                    Helper.DeleteTemporaryFiles(Helper.GetTempFileName(), true);
                }
                else
                {   //else data is in current dir (note: current dir was not changed yet) 
                    Helper.DeleteTemporaryFiles(OldFileName);
                }

                //now change current dir.
                Helper.SetCurrentWorkingDir(Helper.WorkingDirOptions.DirFromFile, CurFile);
                CurFile = System.IO.Path.GetFileName(CurFile);
            }

            // start watching for external changes again
            fileWatcher.Path = Directory.GetCurrentDirectory();
            fileWatcher.Filter = CurFile;
            fileWatcher.EnableRaisingEvents = true;

            if (WeNeedRecompilationAfterSave)
                Recompile();
            return true;
        }
        */
        private void AlwaysTrue(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

     /*   private void SaveCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            SaveCurFile();
        }

        private void SaveAsCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            SaveCurFile(true);            
        }
        */
        private void ExitCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }


     /*   private void NewCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            if (!TryDisposeFile())
                return;
            
            //all temporary files should be saved in the temporary folder.
            Helper.SetCurrentWorkingDir(Helper.WorkingDirOptions.TempDir);
            AddStatusLine("Working directory is now: " + Helper.GetCurrentWorkingDir());

            CleanupForNewFile();
            
            // start with std code
            txtCode.Document.BeginUpdate();
            txtCode.Document.Insert(0, "\\begin{tikzpicture}" + Environment.NewLine + Environment.NewLine + "\\end{tikzpicture}");
            txtCode.Document.EndUpdate();
            ChangesMade = false;

            ShowFilesOfCurrentDirectory(); 

        }
        private void CleanupForNewFile()
        {
            // stop listening for changes
            fileWatcher.EnableRaisingEvents = false;
            //isLoaded = false;
            CurFileNeverSaved = true;
            ChangesMade = false;  //Note: first set ChangesMade=false, then set CurFile.
            CurFile = Consts.defaultCurFile;
            txtCode.Text = "";
            tikzDisplay1.SetUnavailable();
            //pdfOverlay1.Clear();
            //DetermineBB(null);
            rasterControl1.ResetRaster();
            pdfOverlay1.SetParseTree(null, currentBB);
            pdfOverlay1.AllowEditing = true;
            currentBB = new Rect(Properties.Settings.Default.BB_Std_X, Properties.Settings.Default.BB_Std_Y, Properties.Settings.Default.BB_Std_W, Properties.Settings.Default.BB_Std_H);
            ClearStyleLists();

            // Set new document ID
            CurDocumentID = DateTime.Now.Ticks;
        } */

    /*    private void CompileCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            Recompile();
        }
        */
       // private void CompileClick(object sender, RoutedEventArgs e)
      //  {
       //     Recompile();
       // }

        private void AbortCompilationClick(object sender, RoutedEventArgs e)
        {
            TheCompiler.Instance.AbortCompilation();
        }

     /*   private void button1_Click(object sender, RoutedEventArgs e)
        {
            string s = Clipboard.GetText();
            simpletikzLexer lex = new simpletikzLexer(new ANTLRStringStream(s));
            CommonTokenStream tokens = new CommonTokenStream(lex);

            for (int i = 0; i < tokens.Count; i++)
            {
                string ds = tokens.Get(i).Text;
                ds = ds + "eee";
            }

            simpletikzParser parser = new simpletikzParser(tokens);

            //tikzgrammarParser.expr_return r =
            simpletikzParser.tikzpath_return ret = parser.tikzpath();
            
            //CommonTreeAdaptor adaptor = new CommonTreeAdaptor();
            CommonTree t = (CommonTree)ret.Tree;
            MessageBox.Show(printTree(t,0));

        }
     


        public string printTree(CommonTree t, int indent)
        {
            string s="";
            if ( t != null ) {
		        for ( int i = 0; i < indent; i++ )
			        s = s+"   ";

                string r = "";// s + t.ToString() + "\r\n";
                
                if (t.ChildCount >0)
		            foreach ( object o in t.Children ) {
			            r=r+s+o.ToString()+"\r\n" + printTree((CommonTree)o, indent+1);
                    }

                return r;
            }  else return "";
		}
 * */
     /*    private void pdfOverlay1_OnModified(TikzParseItem sender, string oldtext)
        {
            // update code
            //ProgrammaticTextChange = true; 

            //txtCode.Text = pdfOverlay1.ParseTree.ToString();

           int InsertAt = sender.StartPosition();
            if (InsertAt > txtCode.Text.Length)
            {
                AddStatusLine("Trying to insert code \"" + sender.ToString().Replace(Environment.NewLine, "<NEWLINE>") + "\" to position " + sender.StartPosition() + " but document has only " + txtCode.Text.Length + " characters." 
                +" Inserting code at end of document instead. Code does probably not compile now. Please correct or choose undo.", true);
                InsertAt = txtCode.Text.Length;
            }

            txtCode.Document.Replace(InsertAt, oldtext.Length, sender.ToString());

            //ProgrammaticTextChange = false; 
            //MessageBox.Show(pdfOverlay1.ParseTree.ToString());
        }
*/
        private void CommentCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            txtCode.BeginChange();
            int startline = txtCode.Document.GetLocation(txtCode.SelectionStart).Line,
                endline = txtCode.Document.GetLocation(txtCode.SelectionStart+txtCode.SelectionLength).Line;
            for (int i = startline; i <= endline; i++)
                txtCode.Document.Insert(txtCode.Document.Lines[i-1].Offset, "% ");
            txtCode.EndChange();

            /*string[] lines = txtCode.Text.Split(new char[] { '\n' }), newstr = new string[lines.Length];
            int curpos = 0, sels = txtCode.SelectionStart, sellength = txtCode.SelectionLength;
            for (int i = 0; i < lines.Length; i++)
            {
                if (curpos + lines[i].Length >= txtCode.SelectionStart && curpos <= txtCode.SelectionStart + txtCode.SelectionLength)
                {
                    newstr[i] = "% " + lines[i];
                    if (curpos <= txtCode.SelectionStart)
                        sels += 2;
                    else
                        sellength += 2;
                }
                else
                    newstr[i] = lines[i];
                curpos += lines[i].Length + 1;
            }

            txtCode.Text = String.Join("\n", newstr);
            // set selection
            txtCode.SelectionStart = sels;
            txtCode.SelectionLength = sellength;
            */
            // Comment all currently selected lines //todo: nothing selected?          
            //string s =  txtCode.SelectedText.Replace("\n", "\n% ");
            //if (txtCode.SelectionStart == 0 || txtCode.Text[SelectionStart-1]=='\n')
            //    s= "% "+s;
            //txtCode.SelectedText = s;  
        }

        private void UnCommentCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            txtCode.BeginChange();
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
            txtCode.EndChange();

            /*string[] lines = txtCode.Text.Split(new char[] { '\n' }), newstr = new string[lines.Length];
            int curpos = 0, sels = txtCode.SelectionStart, sellength = txtCode.SelectionLength;
            for (int i = 0; i < lines.Length; i++)
            {
                if (curpos + lines[i].Length >= txtCode.SelectionStart && curpos <= txtCode.SelectionStart + txtCode.SelectionLength)
                {
                    if (lines[i].StartsWith("% "))
                    {
                        newstr[i] = lines[i].Remove(0, 2);
                        if (curpos <= txtCode.SelectionStart)
                            sels -= 2;
                        else
                            sellength -= 2;
                    }
                    else if (lines[i].StartsWith("%"))
                    {
                        newstr[i] = lines[i].Remove(0, 1);
                        if (curpos <= txtCode.SelectionStart)
                            sels -= 1;
                        else
                            sellength -= 1;
                    }
                    else newstr[i] = lines[i];
                }
                else
                    newstr[i] = lines[i];
                curpos += lines[i].Length + 1;
            }

            txtCode.Text = String.Join("\n", newstr);
            // set selection
            txtCode.SelectionStart = sels;
            txtCode.SelectionLength = sellength; */
        }

    /*    private void cmbGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (cmbGrid.SelectedIndex >= 0 && rasterControl1 != null)
            //{
                //string c = (cmbGrid.SelectedItem as ComboBoxItem).Content;
            //    rasterControl1.GridWidth = Double.Parse((cmbGrid.SelectedItem as ComboBoxItem).Content.ToString());
            //}
        }
        private void cmbGridTextChanged(object sender, TextChangedEventArgs e)
        {
            double d;
            if (rasterControl1 != null && Double.TryParse(cmbGrid.Text, out d))
            {
                //string c = (cmbGrid.SelectedItem as ComboBoxItem).Content;
                if (d>=0 && d<100)
                    rasterControl1.GridWidth = d;
            }
        }
     * */
        

    //    private void button2_Click(object sender, RoutedEventArgs e)
    //    {
    //        rasterControl1.Visibility = Visibility.Hidden;
    //    }

    /*    private void rb1_Checked(object sender, RoutedEventArgs e)
        {
            if (pdfOverlay1 == null)
                return;
            if (sender == rbToolMove)
                pdfOverlay1.Tool = OverlayToolType.move;
            else if (sender == rbToolAddVert)
                pdfOverlay1.Tool = OverlayToolType.addvert;
            else if (sender == rbToolAddEdge)
                pdfOverlay1.Tool = OverlayToolType.addedge;
            else if (sender == rbToolAddPath)
                pdfOverlay1.Tool = OverlayToolType.addpath;
            else if (sender == rbToolRectangle)
                pdfOverlay1.Tool = OverlayToolType.rectangle;
            else if (sender == rbToolEllipse)
                pdfOverlay1.Tool = OverlayToolType.ellipse;
            else if (sender == rbToolBezier)
                pdfOverlay1.Tool = OverlayToolType.bezier;
            else if (sender == rbToolSmooth)
                pdfOverlay1.Tool = OverlayToolType.smooth;
            else if (sender == rbToolArc)
                pdfOverlay1.Tool = OverlayToolType.arc;
            else if (sender == rbToolGrid)
                pdfOverlay1.Tool = OverlayToolType.grid;
            else if (sender == rbToolArcEdit)
                pdfOverlay1.Tool = OverlayToolType.arcedit; 
        }*/

        private void SnippetMenuClick(object sender, RoutedEventArgs e)
        {
            Snippets.SnippetManager s = new Snippets.SnippetManager();
            if (s.isSuccessfullyLoaded) // could stop loading due to not getting a lock
            {
                s.Owner = this;
                s.ShowDialog();
                // reload snippets
                snippetlist1.Reload();
            }
        }

        //GridLength oldwidth;
        /*
        private void cmdSnippets_Checked(object sender, RoutedEventArgs e)
        {
            if (cmdSnippets != null && cmdFiles != null && snippetlist1 != null)
            {
                if (sender == cmdFiles)
                {
                    cmdSnippets.IsChecked = false;
                    cmdDynPreamble.IsChecked = false;
                    //snippetlist1.Visibility = System.Windows.Visibility.Hidden;
                }
                else if (sender == cmdSnippets)
                {
                    cmdFiles.IsChecked = false;
                    cmdDynPreamble.IsChecked = false;
                    //snippetlist1.Visibility = System.Windows.Visibility.Visible;
                }
                else if (sender == cmdDynPreamble)
                {
                    cmdFiles.IsChecked = false;
                    cmdSnippets.IsChecked = false;
                    //snippetlist1.Visibility = System.Windows.Visibility.Visible;
                }

                Properties.Settings.Default.LeftToolsColVisible =  (cmdSnippets.IsChecked == true || cmdFiles.IsChecked == true || cmdDynPreamble.IsChecked == true);
                //GridLengthConverter g = new GridLengthConverter();
                //if (LeftSplitterCol.Width == (GridLength)g.ConvertFrom(0))
                //{
                //    LeftToolsCol.Width = oldwidth;
                //    LeftSplitterCol.Width = (GridLength)g.ConvertFrom(3);
                //}
            }
        }

        private void cmdSnippets_Unchecked(object sender, RoutedEventArgs e)
        {
            if (sender == cmdFiles)
            {
                //cmdSnippets.IsChecked = false;
                //snippetlist1.Visibility = System.Windows.Visibility.Hidden;
            }
            else if (sender == cmdSnippets)
            {
                //cmdFiles.IsChecked = false;
                //snippetlist1.Visibility = System.Windows.Visibility.Hidden;
            }
            if (cmdFiles.IsChecked == false && cmdSnippets.IsChecked == false && cmdDynPreamble.IsChecked == false)
            {
                Properties.Settings.Default.LeftToolsColVisible = false;
                //GridLengthConverter g = new GridLengthConverter();
                //oldwidth = LeftToolsCol.Width;
                //LeftToolsCol.Width = (GridLength)g.ConvertFrom(0);
                //LeftSplitterCol.Width = (GridLength)g.ConvertFrom(0);                
            }
        } */

        private void snippetlist1_OnInsert(string code, string dependencies)
        {
            //txtCode.BeginChange();
            //string s = txtCode.Text, a=s.Substring(0,txtCode.CaretOffset), b=s.Substring(txtCode.CaretOffset);
            //txtCode.Text = a + code + b;            
            //txtCode.EndChange();
            txtCode.Document.Insert(txtCode.CaretOffset, code);
            
        }

        private void cmdZoomInClick(object sender, RoutedEventArgs e)
        {
            if (cmbZoom.SelectedIndex < cmbZoom.Items.Count - 1)            
                cmbZoom.SelectedIndex++;
        }

        private void cmdZoomOutClick(object sender, RoutedEventArgs e)
        {
            if (cmbZoom.SelectedIndex > 0)
                cmbZoom.SelectedIndex--;
        }
        private void cmdZoomIn2Click(object sender, RoutedEventArgs e)
        {
            if (cmbZoom2.SelectedIndex < cmbZoom2.Items.Count - 1)
                cmbZoom2.SelectedIndex++;
        }

        private void cmdZoomOut2Click(object sender, RoutedEventArgs e)
        {
            if (cmbZoom2.SelectedIndex > 0)
                cmbZoom2.SelectedIndex--;
        }

/*        private void cmbZoomTextChanged(object sender, RoutedEventArgs e)
        {
            string s = cmbZoom.Text;
            s = s.Trim();
            if (s.EndsWith("%"))
                s = s.Remove(s.Length - 1);
            double d;
            if (Double.TryParse(s, out d))
            {
                if (d > 2 && d < 6000)
                {
                    //determine cursor position relative to PreviewScrollViewer
                    Point RelativeCursor = Mouse.GetPosition(PreviewScrollViewer);
                    //if mouse is not over PreviewScrollViewer, pretend mouse being at center of PreviewScrollViewer.
                    if (RelativeCursor.X < 0 || RelativeCursor.Y < 0 || RelativeCursor.X > PreviewScrollViewer.ViewportWidth || RelativeCursor.Y > PreviewScrollViewer.ViewportHeight)
                    {
                        RelativeCursor.X = PreviewScrollViewer.ViewportWidth / 2;
                        RelativeCursor.Y = PreviewScrollViewer.ViewportHeight / 2;
                    }
                    Point AbsoluteCursor = PreviewScrollViewer.PointToScreen(RelativeCursor);

                    Point CursorPosBeforeZoom = new Point(0, 0);
                    Point CursorPosBeforeZoomNormalized = new Point(0, 0);
                    try
                    {
                        //This is where the mouse is pointing to before zooming in.
                        CursorPosBeforeZoom = rasterControl1.PointFromScreen(AbsoluteCursor);
                        CursorPosBeforeZoomNormalized = new Point(CursorPosBeforeZoom.X / pdfOverlay1.Resolution, CursorPosBeforeZoom.Y / pdfOverlay1.Resolution);
                    }
                    catch (Exception) { 
                        //raises exception if run before rasterControl1 is connected to PresentationSource
                    }

                    //do the actual zooming
                    double res = d / 100 * Consts.ptspertikzunit;
                    tikzDisplay1.Resolution = res;
                    rasterControl1.Resolution = res;
                    pdfOverlay1.Resolution = res;

                    Point CursorPosAfterZoom = new Point(0, 0);
                    Point CursorPosAfterZoomNormalized = new Point(0, 0);
                    try
                    {
                        //This is where the mouse is pointing to after zooming in.
                        CursorPosAfterZoom = rasterControl1.PointFromScreen(AbsoluteCursor);
                        CursorPosAfterZoomNormalized = new Point(CursorPosAfterZoom.X / pdfOverlay1.Resolution, CursorPosAfterZoom.Y / pdfOverlay1.Resolution);
                    }
                    catch (Exception)
                    {
                        //raises exception if run before rasterControl1 is connected to PresentationSource
                    }

                    //calculate offset between Before and After position.
                    double DeltaX = (CursorPosBeforeZoomNormalized.X - CursorPosAfterZoomNormalized.X) * res;
                    double DeltaY = (CursorPosBeforeZoomNormalized.Y - CursorPosAfterZoomNormalized.Y) * res;

                    //correct offset.
                    PreviewScrollViewer.ScrollToHorizontalOffset(PreviewScrollViewer.HorizontalOffset + DeltaX);
                    PreviewScrollViewer.ScrollToVerticalOffset(PreviewScrollViewer.VerticalOffset + DeltaY);
                    
                }
            }
        }
        */
        private void SettingsMenuClick(object sender, RoutedEventArgs e)
        {
            SettingsDialog sd = new SettingsDialog();
            sd.ShowDialog();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            {
                //ad// dockManager.SaveLayout(Helper.GetLayoutConfigFilepath());
                Properties.Settings.Default.Save();

                if (!TheVM.TheDocument.TryDisposeFile())
                    e.Cancel = true;
                else
                {
                    // Set closing flag
                    isClosing = true;
                    //FindDialog.txtCode = null;
               //     if (FindDialog != null)
                //        FindDialog.Close();

                    // Exit running pdflatex instances
                    TheCompiler.Instance.AbortCompilation();
                    TikzToBMPFactory.Instance.AbortCompilation();
                }
            }
        }

   /*     private void TestClick(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("wp: " + Helper.HasWritePermissionOnDir(@"C:\Program Files").ToString());
            MessageBox.Show("wp: " + Helper.HasWritePermissionOnDir(@"C:\Program Files (x86)\TikzEdt\TikzEdt 0.1").ToString());
            MessageBox.Show("wp: " + Helper.GetAppDir() + " : " + Helper.HasWritePermissionOnDir(Helper.GetAppDir()).ToString());
            //Clipboard.SetText(pdfOverlay1.ParseTree.ToString());
            //return;
            //PDFLibNet.PDFWrapper p = new PDFLibNet.PDFWrapper();
            //p.LoadPDF("testtight.pdf");

            //System.Drawing.Bitmap b = p.Pages[1].GetBitmap(72);
            //b.Save("testtight.bmp");
            //b.Dispose();

            //int i = 5;
        }*/

    /*    private void pdfOverlay1_BeginModify(object sender)
        {
           // TheVM.TheDocument.ProgrammaticTextChange = true;
          //  txtCode.Document.BeginUpdate();            
        }

        private void pdfOverlay1_EndModify(object sender)
        {
        //    txtCode.Document.EndUpdate();
        //    TheVM.TheDocument.ProgrammaticTextChange = false;
            // refresh style list since styles may have changed (but: not necessary to fully reparse)
        //    TheVM.TheDocument.UpdateStyleList();
        }
        */
        private void TestUpdClick(object sender, RoutedEventArgs e)
        {
            pdfOverlay1.ParseTree.UpdateText();
        }

        private void GenerateHeadersClick(object sender, RoutedEventArgs e)
        {
            TheCompiler.GeneratePrecompiledHeaders();
        }
        private void GenerateSnippetThumbsClick(object sender, RoutedEventArgs e)
        {
            snippetlist1.CompileSnippets();
        }       
  /*      private void chkFancyMode_Checked(object sender, RoutedEventArgs e)
        {
            if (isLoaded)
                Recompile();
        }
        */
        private void Enscope_Click(object sender, RoutedEventArgs e)
        {
            if (txtCode.SelectionLength > 0)
                txtCode.Document.Replace(txtCode.SelectionStart, txtCode.SelectionLength,
                    "\\begin{scope}[]\r\n" + txtCode.SelectedText + "\r\n\\end{scope}");
            else
                txtCode.Document.Insert(txtCode.CaretOffset, "\\begin{scope}[]\r\n\r\n\\end{scope}");
        }

        private void pdfOverlay1_TryCreateNew(object sender, out bool allow)
        {
            if (txtCode.Text == "")
                allow = true;
            else
                allow = false;
        }

   /*     private void txtRadialOffset_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (rasterControl1 == null)
                return;
            int i;
            if (Int32.TryParse(txtRadialOffset.Text, out i))
                rasterControl1.RadialOffsetInt = i;

        }

        private void txtRadialSteps_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (rasterControl1 == null)
                return;
            int i;
            if (Int32.TryParse(txtRadialSteps.Text, out i))
                if (i>0 && i< 1000)
                    rasterControl1.RadialSteps = (uint)i;
        }
        */
        private void pdfOverlay1_JumpToSource(object sender, PdfOverlay.JumpToSourceEventArgs e)
        {            
            //string s = txtCode.Text.Substring();
            int spos = e.JumpToPos;
            int sellength = e.SelectionLength;

            // for nodes, try to jump directly to content (so that user can immediately start typing)
            
      /*      if (tpi is Tikz_Node)
            {
                int i = s.LastIndexOf('{');
                if (i >= 0)
                {
                    spos = spos + i;
                    sellength = 0;
                }
            } */

            if (spos > txtCode.Text.Length)
            {
                AddStatusLine("Trying to jump to position " + spos + " but document only has " + txtCode.Text.Length + " characters. Please correct any parser errors or restart TikzEdt.", true);
                return;
            }

            txtCode.SelectionLength = 0; //deselect first
            txtCode.CaretOffset = spos;
            txtCode.SelectionStart = spos;
            txtCode.SelectionLength = sellength;
            txtCode.ScrollToLine(txtCode.Document.GetLineByOffset(spos).LineNumber);
            txtCode.Focus();
                  
        }
        /*
        private void pdfOverlay1_ToolChanged(object sender)
        {
            rbToolMove.IsChecked = (pdfOverlay1.Tool == OverlayToolType.move);
            rbToolAddVert.IsChecked = (pdfOverlay1.Tool == OverlayToolType.addvert);
            rbToolAddEdge.IsChecked = (pdfOverlay1.Tool == OverlayToolType.addedge);
            rbToolAddPath.IsChecked = (pdfOverlay1.Tool == OverlayToolType.addpath);
        }

        private void cmbZoom_LostFocus(object sender, RoutedEventArgs e)
        {
            // add a "%"
            double d;
            if (Double.TryParse(cmbZoom.Text, out d))
            {
                cmbZoom.Text = d.ToString() + " %";
            }
        } */

        private void AboutClick(object sender, RoutedEventArgs e)
        {
            TikzEdtAbout ta = new TikzEdtAbout() { Owner=this };
            ta.ShowDialog();
        }

      /*  private void FindCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            EnsureFindDialogExists();
            FindDialog.ShowAsFind();
        }

        private void ReplaceCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            EnsureFindDialogExists();
            FindDialog.ShowAsReplace();
        } */

        private void HelpCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            // open the help page
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(Consts.HelpUrl));
            }
            catch (Exception)
            {
                AddStatusLine("Could not open " + Consts.HelpUrl);
            }
        }

        private void ZoomoutCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void ZoominCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {

        }
        
  /*      void EnsureFindDialogExists()
        {
            if (FindDialog == null)
            {
                FindDialog = new Editor.FindReplaceDialog(txtCode);
                FindDialog.Closed += delegate { FindDialog = null; }; 
            }
        }*/

   /*     private void FindNextCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            EnsureFindDialogExists();
            FindDialog.FindNext();
        }

        private void FindPreviousCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            EnsureFindDialogExists();
            FindDialog.FindPrevious();
        }
        */

    /*    private void ShowCodeCompletionsCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            // Open code completion window
            completionWindow = new CompletionWindow(txtCode.TextArea);
            IList<ICompletionData> data = completionWindow.CompletionList.CompletionData;
            codeCompleter.GetCompletions(txtCode.Document, txtCode.CaretOffset, data);
            // use the word at current cursor position to filter the list 
            // (i.e., if we type bla<CTRL+SPACE>, the list should be filtered by bla
            int LineStartOffset = txtCode.Document.GetLineByOffset(txtCode.CaretOffset).Offset;
            string curLineToCursor = txtCode.Document.GetText(LineStartOffset, txtCode.CaretOffset - LineStartOffset);
            string[] words = Regex.Split(curLineToCursor, @"\W+"); // split at non-word characters
            if (words.Length > 0 && words.Last() != "")
            {
                completionWindow.CompletionList.SelectItem(words.Last());
                completionWindow.StartOffset = txtCode.CaretOffset - words.Last().Length;
            }
            
            completionWindow.Show();
            completionWindow.Closed += delegate
            {
                completionWindow = null;
            }; 
        }
        */
        private void UndoCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            if (txtCode.CanUndo && e.Source != txtCode.TextArea)
                ApplicationCommands.Undo.Execute(e.Parameter, txtCode.TextArea);            
        }

        private void RedoCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            if (txtCode.CanRedo && e.Source != txtCode.TextArea)
                ApplicationCommands.Redo.Execute(e.Parameter, txtCode.TextArea);
        }

        private void UndoCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = txtCode.CanUndo;
        }

        private void RedoCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = txtCode.CanRedo;
        }

        private void TexCompiler_OnTexOutput(object sender, TexCompiler.CompileEventArgs e)
        {
            //add whole line as paragraph to txtTexout
            Paragraph p = new Paragraph();
            p.Margin = new Thickness(0);
            p.Inlines.Add(new Run(e.Message));
            txtTexout.Document.Blocks.Add(p);
            EditingCommands.MoveToDocumentEnd.Execute(null, txtTexout);
            txtTexout.ScrollToEnd();
        }        
        
        // this is called upon latex error,... the error is extracted from the latex output in the TexCompiler class
/*        void addProblemMarker(object sender, TexOutputParser.TexError err, TexCompiler.Job job = null) //String error, int linenr, TexCompiler.Severity severity)
        {
            // if job = null, the error was generated by the parser => always display
            // otherwise display only if the job really was the current document
            if (job == null || job.DocumentID == CurDocumentID)
                TexErrors.Add(err);            
        }
        public void addProblemMarker(string msg, int line, int pos, Severity severity, string file)
        {
            TexOutputParser.TexError err = new TexOutputParser.TexError();
            err.error = msg;
            err.causingSourceFile = file;
            err.linenr = line;
            err.pos = pos;
            err.severity = severity;
            addProblemMarker(this, err);
        } 
        public void clearProblemMarkers()
        {
            TexErrors.Clear();            
        }
        */
        private void MarkAtOffsetClick(object sender, RoutedEventArgs e)
        {
            // the mouse position upon context menu opening is stored in mousepos_whenmenuopened
            // first place the caret at this position
            if (mousepos_whenmenuopened >= 0)
            {
                txtCode.CaretOffset = mousepos_whenmenuopened; 
            }
            pdfOverlay1.MarkObjectAt(txtCode.CaretOffset);
        }

        private void ShowPdfHandler(object sender, ExecutedRoutedEventArgs e)
        {
            string PdfPath = TheVM.TheDocument.SavePdf(false);

            if (PdfPath == "") return;

            if (Properties.Settings.Default.Path_externalviewer.Trim() == "")
            {
                System.Diagnostics.Process.Start(PdfPath);
            }
            else
            {
                System.Diagnostics.Process.Start(Properties.Settings.Default.Path_externalviewer, PdfPath);
            }
        }

       /* private void SavePdfHandler(object sender, ExecutedRoutedEventArgs e)
        {
            SavePdf(false);
        }

        private void SavePdfAsHandler(object sender, ExecutedRoutedEventArgs e)
        {
            SavePdf(true);
        } */

      
        private FileDownloader downloader;
        private void OpenPgfManualHandler(object sender, ExecutedRoutedEventArgs e)
        {
            String pgfmanualurl = Consts.PGFManualDownloadPath;
            
            //open file if it exists and downloader is not busy downloading it (then file is not complete)
            if (File.Exists(Helper.GetAppdataPath() + "\\" + "pgfmanual.pdf")
                && (downloader==null || (downloader != null && !downloader.IsBusy && downloader.CurrentFile.Path == pgfmanualurl)))
                System.Diagnostics.Process.Start(Helper.GetAppdataPath() + "\\" + "pgfmanual.pdf");
            else
            {
                // Creating a new instance of a FileDownloader
                if (downloader == null)
                {
                    downloader = new FileDownloader();
                    downloader.LocalDirectory = Helper.GetAppdataPath();
                    downloader.FileDownloadStarted += ((s, args) => AddStatusLine("Download of Tikz/Pgf manual started. Please be patient."));
                    downloader.FileDownloadSucceeded += ((s, args) => AddStatusLine("Download of Tikz/Pgf manual succeeded."));
                    downloader.FileDownloadFailed += ((s, args) => AddStatusLine("Download of Tikz/Pgf manual failed.", true));
                    
                }

                //if downloader is downloading file show status.
                if (downloader.IsBusy)
                {
                    String msg = String.Format("Downloaded {0} of {1} ({2}%)",
                           FileDownloader.FormatSizeBinary(downloader.CurrentFileProgress),
                           FileDownloader.FormatSizeBinary(downloader.CurrentFileSize),
                           downloader.CurrentFilePercentage()) + String.Format(" - {0}/s",
                           FileDownloader.FormatSizeBinary(downloader.DownloadSpeed));
                    if (MessageBoxResult.Cancel == MessageBox.Show(msg + Environment.NewLine + "Press cancel to abort download.", "Download in progress", MessageBoxButton.OKCancel, MessageBoxImage.Information, MessageBoxResult.OK))
                        downloader.Stop();
                }
                //else ask user to download file
                else
                {
                    FileDownloader.FileInfo loadfile = new FileDownloader.FileInfo(pgfmanualurl);
            
                    String msg = "Tikz/Pgf manual not found. Do you want to download it now?";
                    if (MessageBoxResult.Yes == MessageBox.Show(msg, "Start download?", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.Yes))
                    {
                        if (!downloader.Files.Contains(loadfile))
                            downloader.Files.Add(loadfile);
                        AddStatusLine("Starting download of Pgf manual from " + pgfmanualurl + " ...  (F2 for status)");
                        downloader.Start();                        
                    }
                }
            }
        }

        /// <summary>
        /// Displays an Export As dialog and, if successful, exports the current tikzpicture 
        /// as either bmp, jpeg, tiff or png.
        /// </summary>
    /*    private void ExportFileHandler(object sender, ExecutedRoutedEventArgs e)
        {
            if (CurFileNeverSaved)
            {
                AddStatusLine("Please save document first", true);
                return;
            }

            string s = Helper.GetCurrentWorkingDir();
            string t = Helper.GetPreviewFilename();
            string PreviewPdfFilePath = s + "\\" + CurFile + t + ".pdf";
            string FilePath = s + "\\" + Helper.RemoveFileExtension(CurFile) + ".pdf";

                SaveFileDialog sfd = new SaveFileDialog();

                sfd.Filter = "Jpeg Files|*.jpg|Portable Network Graphics|*.png|Bitmap Files|*.bmp|Tiff Files|*.tif|Graphics Interchange Format|*.gif|Extended Meta File|*.emf|Windows Meta File|*.wmf";
                sfd.OverwritePrompt = true;
                sfd.ValidateNames = true;

                sfd.FileName = System.IO.Path.GetFileName(CurFile);
                // change file extension to .pdf
                sfd.FileName = Helper.RemoveFileExtension(sfd.FileName) + ".jpg";
                sfd.InitialDirectory = System.IO.Path.GetDirectoryName(CurFile);
                if (sfd.ShowDialog() != true)
                    return;
                FilePath = sfd.FileName;

            try
            {
                System.Drawing.Imaging.ImageFormat imgFormat;
                bool Transparent = true;
                switch (System.IO.Path.GetExtension(FilePath).ToLower())
                {
                    case ".jpg":
                        imgFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
                        Transparent = false;
                        break;
                    case ".bmp":
                        imgFormat = System.Drawing.Imaging.ImageFormat.Bmp;
                        Transparent = false;
                        break;
                    case ".gif":
                        imgFormat = System.Drawing.Imaging.ImageFormat.Gif;
                        Transparent = false;
                        break;
                    case ".emf":
                        imgFormat = System.Drawing.Imaging.ImageFormat.Emf;
                        break;
                    case ".wmf":
                        imgFormat = System.Drawing.Imaging.ImageFormat.Wmf;
                        break;
                    case ".tif":
                        imgFormat = System.Drawing.Imaging.ImageFormat.Tiff;
                        break;                        
                    case ".png":
                        imgFormat = System.Drawing.Imaging.ImageFormat.Png;
                        break;
                    default:
                        AddStatusLine("Could not export file: Unknown file extension.", true);
                        return;
                }

                PdfToBmp p2b = new PdfToBmp();                
                p2b.LoadPdf(PreviewPdfFilePath);
                p2b.SaveBmp(FilePath, Consts.ptspertikzunit, Transparent, imgFormat);
            }
            catch (Exception Ex)
            {
                AddStatusLine("Could not export file. " + Ex.Message, true);
                return;
            }

            AddStatusLine("File exported as " + FilePath);            
        } */       
        
        private void lstErrors_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            // jump to source of selected error
            if (lstErrors.SelectedItem != null)
            {
                TexOutputParser.TexError err = lstErrors.SelectedItem as TexOutputParser.TexError;

                if (!err.inincludefile) // cannot jump to error position if it occured in \input-tex file 
                {
                    if (err.Pos < 0)
                        txtCode_Goto(err.Line, 1, true);
                    else if (err.Line == 0 && err.Pos > 0)
                        txtCode_Goto(err.Pos + 1, true);
                    else
                        txtCode_Goto(err.Line, err.Pos + 1, false, true);
                }   
            }
        }

  /*      private void lstFiles_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {            
            TextBlock item = lstFiles.SelectedItem as TextBlock;
            if (TheVM.TheDocument.TryDisposeFile())
                LoadFile(Helper.GetCurrentWorkingDir() + "\\" + item.Text + ".tex");
            
        }*/
      /*   private void lstFile_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            //ad//
            TextBlock item = lstFiles.SelectedItem as TextBlock;
            string file = item.Text;

            var documentContent = new AvalonDock.DocumentContent();
            documentContent.Title = file;
            
            ICSharpCode.AvalonEdit.TextEditor newEditor = new ICSharpCode.AvalonEdit.TextEditor();
            newEditor.ShowLineNumbers = txtCode.ShowLineNumbers;
            newEditor.WordWrap = txtCode.WordWrap;
            newEditor.SyntaxHighlighting = txtCode.SyntaxHighlighting;
            newEditor.Background = Brushes.LightGray;
            newEditor.Load(Helper.GetCurrentWorkingDir() + "\\" + file + ".tex");
            newEditor.IsReadOnly = true;

            documentContent.Content = newEditor;
            documentContent.Show(dockManager);
            //select the just added document
            if(dockManager.ActiveDocument != null)
                dockManager.ActiveDocument.ContainerPane.SelectedIndex = 0; 
        }*/
        
        
        private bool txtCode_Goto(int pos, bool HighlightLine = false, bool HighlightChar = false)
        {
            if (pos >= 1)
            {
                ICSharpCode.AvalonEdit.Document.DocumentLine l = txtCode.Document.GetLineByOffset(pos);
                return txtCode_Goto(l.LineNumber, pos - l.Offset, HighlightLine, HighlightChar);                
            }
            else
                return false;
        }
        /// <summary>
        /// First line is 1, first character in line is 0.
        /// </summary>
        /// <param name="line">line to go to</param>
        /// <param name="pos">pos in line to go to</param>
        /// <param name="HighlightLine">Highlight from pos to end of line</param>
        /// <param name="HighlightChar">Highlight one character beginning from pos</param>
        /// <returns></returns>
        private bool txtCode_Goto(int line, int pos, bool HighlightLine = false, bool HighlightChar = false)
        {
            if (txtCode.Document.LineCount >= line && line >= 1)
            {
                if (pos < 0) pos = 0;
                txtCode.CaretOffset = txtCode.Document.GetOffset(line, pos);
                if (HighlightLine)
                {
                    //if it is not the last line select it
                    if(txtCode.Text.IndexOf(Environment.NewLine, txtCode.CaretOffset) != -1)
                        txtCode.Select(txtCode.CaretOffset, txtCode.Text.IndexOf(Environment.NewLine, txtCode.CaretOffset) - txtCode.CaretOffset);
                    //else select to end.
                    else
                        txtCode.Select(txtCode.CaretOffset, txtCode.Text.Length - txtCode.CaretOffset);
                }
                else if (HighlightChar)
                {
                    if (txtCode.Text.Length > txtCode.CaretOffset)
                        txtCode.Select(txtCode.CaretOffset, 1);
                }
                txtCode.ScrollToLine(line);
                txtCode.Focus();
                return true;
            }
            else
                return false;
        }


        private void txtCode_Drop(object sender, DragEventArgs e)
        {
            //open file which was drag&dropped.
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                //open only single file
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length == 1)
                {
                    //warn user about wrong file extension
                    if (System.IO.Path.GetExtension(files[0]) != ".tex")
                    {
                        MessageBoxResult r = MessageBox.Show(this, "File does not seem to be a LaTeX-file. Proceed opening?", "Wrong file extension",
                            MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);
                        if (r == MessageBoxResult.No)
                            return;                        
                    }
                    if(TheVM.TheDocument.TryDisposeFile())
                        TheVM.LoadFile(files[0]);
                }
                else
                    GlobalUI.ShowMessageBox("Only one file at a time allowed via drag&drop.", "Too many files", MessageBoxButton.OK, MessageBoxImage.Information);
                        
            }
            
        }

        private void txtCode_DragEnter(object sender, DragEventArgs e)
        {
            //show that TikzEdt accepts files by drag&drop
            //however, only a single file is allowed.
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length == 1)                
                    e.Effects = DragDropEffects.Move;
                else
                    e.Effects = DragDropEffects.None;
                e.Handled = true;
            }
            //setting e.Effects = DragDropEffects.None is ignored. why?
        }

   /*     private void Test2Click(object sender, RoutedEventArgs e)
        {
            TexOutputParser.TexError err = new TexOutputParser.TexError();
            err.Line = 33;
            err.Message = "blabla";
            err.severity = Severity.WARNING;
            addProblemMarker(this, err);

            err = new TexOutputParser.TexError();
            err.Line = 44;
            err.Message = "blabl2a";
            err.severity = Severity.ERROR;
            addProblemMarker(this, err);

            err = new TexOutputParser.TexError();
            err.Line = 55;
            err.Message = "blabla3";
            err.severity = Severity.ERROR;
            addProblemMarker(this, err);

            err = new TexOutputParser.TexError();
            err.Line = 66;
            err.Message = "blabla4";
            err.severity = Severity.NOTICE;
            addProblemMarker(this, err);

            err = new TexOutputParser.TexError();
            err.Line = 77;
            err.Message = "blabla5";
            err.severity = Severity.WARNING;
            addProblemMarker(this, err);
        }
        */
        private void Preview_MouseWheel(object sender, MouseWheelEventArgs e)
        {            
            if (Keyboard.Modifiers.HasFlag(ModifierKeys.Control))
            {
                int count = cmbZoom.Items.Count;
                double factor = e.Delta > 0 ? 1.1 : .9;
                TheVM.TheDocument.Resolution *= factor;

                // get Mouse pos for correct scrolling
                Point p = Mouse.GetPosition(PreviewScrollViewer);

                // adjust scroll
                PreviewScrollViewer.ScrollToHorizontalOffset(PreviewScrollViewer.HorizontalOffset *factor + p.X * (factor-1));
                PreviewScrollViewer.ScrollToVerticalOffset(PreviewScrollViewer.VerticalOffset * factor  + p.Y* (factor - 1));

                e.Handled = true;
                //if (cmbZoom.SelectedIndex + step > 0 && cmbZoom.SelectedIndex + step < count)
                //cmbZoom.SelectedIndex += step;
            }

        }

      /*  private void DockManager_Loaded(object sender, RoutedEventArgs e)
        {
             //ad//
            if (File.Exists(Helper.GetLayoutConfigFilepath()))            
                dockManager.RestoreLayout(Helper.GetLayoutConfigFilepath());
            TextEditorsPane.ShowHeader = false;
            dockManager.Visibility = System.Windows.Visibility.Visible;  
        }

        private void ContextMenu_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {

        }*/

        int mousepos_whenmenuopened = -1;  // The mouse position (as a text offset) upon context menu opening; -1 = could not be determined
        private void txtCodeContextMenu_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            // the mouse position upon context menu opening is stored in mousepos_whenmenuopened
            Nullable<TextViewPosition> vp = txtCode.TextArea.TextView.GetPosition(new Point(e.CursorLeft, e.CursorTop));
            if (vp != null)
            {
                mousepos_whenmenuopened = txtCode.Document.GetOffset(vp.Value.Line, vp.Value.Column);
            }
            else
                mousepos_whenmenuopened = -1;
        }

        private void AbortSnippetCompilationClick(object sender, RoutedEventArgs e)
        {
            TikzToBMPFactory.Instance.AbortCompilation();
        }

        /// <summary>
        /// Inserts a \definecolor command into the document accoridng to the currently picked color 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorPicker1_OnInsert(object sender, RoutedEventArgs e)
        {
            if (pdfOverlay1.ParseTree == null) return;
            string colorName = "";
            if (Overlay.InputMessageBox.ShowInputDialog("New color...", "Please enter a unique color name", out colorName) != MessageBoxResult.OK)
                return;
            string colordef = @"\definecolor{"+colorName+"}{HTML}{" + ColorPicker1.CurrentColor.ToString().Substring(3) + "}" + Environment.NewLine;
            Tikz_Picture tp = pdfOverlay1.ParseTree.GetTikzPicture();
            int index = pdfOverlay1.ParseTree.Children.IndexOf(tp);
            if (index >= 0)
                txtCode.Document.Insert(pdfOverlay1.ParseTree.Children[index].StartPosition(), colordef);
            else
                txtCode.Document.Insert(txtCode.CaretOffset, colordef);
        }

        /// <summary>
        /// Tries to insert a \usetikzlibrary{lib} into the code, if it is not present
        /// </summary>
        /// <param name="lib"></param>
        void InsertUseTikzLibrary(string lib)
        {            
            try
            {
                if (lib.Trim() != "")
                {
                    // check if library already used (... it is a bit of a hack) 
                    Regex r = new Regex(@"\\usetikzlibrary(\s*)\{(\s*)" + lib + @"(\s*)\}", RegexOptions.IgnorePatternWhitespace);
                    if (!r.IsMatch(txtCode.Text))
                    {
                        Regex rr = new Regex(@"\\begin(\s*)\{(\s*)tikzpicture(\s*)}");
                        Match m = rr.Match(txtCode.Text);
                        if (m.Success)
                            txtCode.Document.Insert(m.Index, @"\usetikzlibrary{"+lib+"}"+Environment.NewLine);
                    }
                }
            } catch (Exception) 
            {
                // failed -> dont bother
            }

        }

        /// <summary>
        /// Merges the two styles. If some style contains an arrow (i.e., contains -), the 
        /// arrow head/tail are copied together.
        /// For instance, -> + >- = >->
        /// (the way it is implemented is a bit of a hack)
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        string MergeStyles(string s1, string s2)
        {           

            List<string> sl1 = new List<string>(s1.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries));
            List<string> sl2 = new List<string>(s2.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries));

            foreach (string s in sl2)
            {
                if (s.Contains("-"))
                {
                    string[] ar2 = s.Split('-');
                    if (ar2.Length == 2)
                    {
                        // arrow style,... check if other arrow style exists
                        int ind = sl1.FindIndex(v => v.Contains("-"));
                        if (ind >= 0)
                        {
                            string[] ar1 = sl1[ind].Split('-');
                            if (ar1.Length == 2)
                            {
                                if (ar1[0].Trim() == "" && ar2[1].Trim() == "")
                                {
                                    sl1[ind] = ar2[0] + "-" + ar1[1];
                                    continue;
                                }
                                else if (ar1[1].Trim() == "" && ar2[0].Trim() == "")
                                {
                                    sl1[ind] = ar1[0] + "-" + ar2[1];
                                    continue;
                                }
                            }
                        }
                    }
                }
                
                if (!sl1.Contains(s))
                    sl1.Add(s);

            }

            return String.Join(", ", sl1);
        }

        /// <summary>
        /// Changes the specified style to the one currently used.
        /// If e.InAddition is true, instead the style is added
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void snippetlist1_OnUseStyles(object sender, Snippets.SnippetList.UseStylesEventArgs e)
        {
            InsertUseTikzLibrary(e.dependencies);

            if (cmbEdgeStyles.Text.Trim() != "" && e.InAddition)
                cmbEdgeStyles.Text = MergeStyles(cmbEdgeStyles.Text, e.edgestyle);
            else
                cmbEdgeStyles.Text = e.edgestyle;

            if (cmbNodeStyles.Text.Trim() != "" && e.InAddition)
                cmbNodeStyles.Text = MergeStyles(cmbNodeStyles.Text, e.nodestyle);
            else
                cmbNodeStyles.Text = e.nodestyle;

        }

        private void cmdClear_Click(object sender, RoutedEventArgs e)
        {
            if (sender == cmdClearEStyle)
                cmbEdgeStyles.Text = "";
            if (sender == cmdClearNStyle)
                cmbNodeStyles.Text = "";

        }

        private void folderView_OnFileOpen(object sender, FileListView.FListView.FileOpenEventArgs e)
        {
            // open file, either in this window or in a new instance, depending on the command parameter
            if (e.CommandParameter == null)
            {
                if (TheVM.TheDocument.TryDisposeFile())
                    TheVM.LoadFile(e.FileName);
            }
            else if ((string)e.CommandParameter == "newinstance")
                MainWindowVM.StartNewTEInstance( "\"" + e.FileName + "\"");
            else if ((string)e.CommandParameter == "externalviewer")
            {
                try
                {
                    System.Diagnostics.Process.Start(e.FileName);
                }
                catch (Exception)
                {
                    GlobalUI.ShowMessageBox("Couldn't open file: " + e.FileName + ".", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void CopyAllWithFigureEnvironment_Click(object sender, RoutedEventArgs e)
        {
            string text = @"\begin{figure}" + Environment.NewLine + @"\centering" + Environment.NewLine + TheVM.TheDocument.Document.Text
                + Environment.NewLine + @"\caption{\label{fig:myfigure} My figure caption. }" + Environment.NewLine + @"\end{figure}";
            Clipboard.SetText(text);
        }

        private void pdfOverlay1_ReplaceText(object sender, PdfOverlay.ReplaceTextEventArgs e)
        {
            txtCode.BeginChange();

            // Note: we assume that the replacements are already brought into correct order !!
            foreach (var r in e.Replacements)
                txtCode.Document.Replace(r.StartPosition, r.Length, r.ReplacementText);

            txtCode.EndChange();
        }

        private void UniquefyNames_Click(object sender, RoutedEventArgs e)
        {
            TikzParseTreeHelper.UniquefyNodeNames(TheVM.TheDocument.ParseTree);
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            txtCode.InvalidateVisual();
        }

        private void TextBlock_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            InvalidateVisual();
            InvalidateArrange();
            //Width = Width - 1;
            //Width = Width + 1;
            //DockPanel.SetDock(txtCode, Dock.Bottom);
           // IntPtr windowHandle = new WindowInteropHelper(Application.Current.MainWindow).Handle;
            //Helper.UpdateWindow(windowHandle);
            UpdateLayout();
            InvalidateProperty(WidthProperty);
        }

        private void OpenInExplorer_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(folderView.CurrentFolder);
        }

        private void ShowTipsTricks_Click(object sender, RoutedEventArgs e)
        {
            (new TipsTricksWindow() { Owner = this }).ShowDialog();
        }

        private void pdfOverlay1_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousep = e.GetPosition(pdfOverlay1);
            // convert to bottom left coordinates
            Point p = new Point(mousep.X, pdfOverlay1.Height - mousep.Y);            

            // display the current mouse position
            p.Y /= pdfOverlay1.Resolution;
            p.X /= pdfOverlay1.Resolution;
            p.X += pdfOverlay1.BB.X;
            p.Y += pdfOverlay1.BB.Y;

            String s = "(" + String.Format("{0:f1}", p.X) + ", " + String.Format("{0:f1}", p.Y) + ")";
            CoordinateStatusBarItem.Content = s;
        }

        private void CheckForUpdates_Click(object sender, RoutedEventArgs e)
        {
            updateChecker.CheckForUpdatesAsync();
        }

        private void InstallLatexPackages_Click(object sender, RoutedEventArgs e)
        {
            int result = MyMessageBox.Show("This tries to install the required Latex packages by running InstallPackages_Miktex.bat "+
                "or InstallPackages_TexLive.bat in the installation directory.",
                "Install missing packages", MessageBoxImage.Information, new string[] { "I use MikTex", "I use TexLive", "Cancel" }, 2, this);
            try
            {
                if (result == 0)
                    Process.Start(new ProcessStartInfo(System.IO.Path.Combine(Helper.GetAppDir(), "InstallPackages_Miktex.bat")));
                else if (result == 1)
                    Process.Start(new ProcessStartInfo(System.IO.Path.Combine(Helper.GetAppDir(), "InstallPackages_TexLive.bat")));
            }
            catch (Exception)
            {
                GlobalUI.ShowMessageBox("Could not start the package installation script (InstallPackages_XXX.bat). Maybe the installation is broken.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void JumpToCurrentFolder_Click(object sender, RoutedEventArgs e)
        {
            folderView.CurrentFolder = Directory.GetCurrentDirectory();
        }

        Point PanningStart = new Point(0,0);
        Point OffsetStart = new Point(0, 0);
        private void PreviewScrollViewer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //if (this.isMoving == true) //Moving with a released wheel and pressing a button
            //    this.CancelScrolling();
            var sv = sender as ScrollViewer;
            if (sv != null && e.ChangedButton == MouseButton.Middle && e.ButtonState == MouseButtonState.Pressed)
            {
                PreviewScrollViewer.Cursor = Cursors.SizeAll;
                PanningStart = e.GetPosition(sv);
                OffsetStart = new Point(sv.HorizontalOffset, sv.VerticalOffset);
                PreviewScrollViewer.CaptureMouse(); // this causes MouseMove to be triggered
            }

        }

        private void PreviewScrollViewer_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Middle && e.ButtonState == MouseButtonState.Released)
            {
                PreviewScrollViewer.ReleaseMouseCapture();
                PreviewScrollViewer.Cursor = Cursors.Arrow;
            }
        }

        private void PreviewScrollViewer_MouseMove(object sender, MouseEventArgs e)
        {
            var sv = sender as ScrollViewer;

            if (sv != null && e.MiddleButton.HasFlag(MouseButtonState.Pressed))
            {
                var currentPosition = e.GetPosition(sv);
                var NewPosition = OffsetStart - currentPosition + PanningStart;

                sv.ScrollToHorizontalOffset(NewPosition.X);
                sv.ScrollToVerticalOffset(NewPosition.Y);
            }

        }

        private void QuickTour_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(Consts.QuickTourUrl));
            }
            catch (Exception)
            {
                AddStatusLine("Could not open " + Consts.QuickTourUrl);
            }
        }
       
    }
}
