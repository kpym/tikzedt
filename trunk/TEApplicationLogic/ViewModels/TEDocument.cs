using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
//using ICSharpCode.AvalonEdit;
using TikzEdt.Parser;
//using ICSharpCode.AvalonEdit.Document;
using System.Windows;
using System.IO;
using Microsoft.Win32;
using System.Collections.ObjectModel;
//using System.Windows.Input;
using System.Text.RegularExpressions;
using Antlr.Runtime;
using TESharedComponents;

namespace TikzEdt.ViewModels
{
    /// <summary>
    /// The viewmodel for a single TikzEdt document.
    /// </summary>
    public class TEDocumentVM<T> : ViewModelBase, IDisposable where T : class, TikzEdt.ViewModels.ITEDoc, new()
    {
        #region Commands
        TERelayCommand _CompileCommand;
        public TERelayCommand CompileCommand
        {
            get
            {
                 if (_CompileCommand == null)
                     _CompileCommand = new TERelayCommand(o => Recompile(), o => true);
                return _CompileCommand;
            }
        }
        TERelayCommand _SavePdfCommand;
        public TERelayCommand SavePdfCommand
        {
            get
            {
                if (_SavePdfCommand == null)
                    _SavePdfCommand = new TERelayCommand(o => SavePdf(o != null), o => true);
                return _SavePdfCommand;
            }
        }
        TERelayCommand _ExportFileCommand;
        public TERelayCommand ExportFileCommand
        {
            get
            {
                if (_ExportFileCommand == null)
                    _ExportFileCommand = new TERelayCommand(o => ExportFile());
                return _ExportFileCommand;
            }
        }

        //CommandBinding CompileCommandBinding { get { return new CommandBinding(CompileCommand, CompileCommandHandler); } }
  /*      private void CompileCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            Recompile();
        } */

        //public RelayCommand CloseCommand { get { return new RelayCommand((e); } } 
        public TERelayCommand CloseCommand { get { return new TERelayCommand((object sender) => RequestCloseFile()); } }
        void RequestCloseFile()
        {
            if (TryDisposeFile())
                if (OnClose != null)
                    OnClose(this, null);
        }

        //public RelayCommand CompileCommand { get { return new RoutedCommand();
        //public static RoutedCommand FindNextCommand = new RoutedCommand();
        //public static RoutedCommand FindPreviousCommand = new RoutedCommand();
        //public static RoutedCommand CommentCommand = new RoutedCommand();
        //public static RoutedCommand UnCommentCommand = new RoutedCommand();
        //public static RoutedCommand ShowCodeCompletionsCommand = new RoutedCommand();
        //public static RoutedCommand SavePdfCommand = new RoutedCommand();
        //public static RoutedCommand SavePdfAsCommand = new RoutedCommand();
        //public static RoutedCommand ShowPdfCommand = new RoutedCommand();
        //public static RoutedCommand ExportFileCommand = new RoutedCommand();

        #endregion

        #region Public Properties

        //string _DynamicPreamble = "";
        /// <summary>
        /// The value of the preamble should be pushed onto this property. 
        /// </summary>
        public string DynamicPreamble { get { if (TheVM != null) return TheVM.DynamicPreamble; else return null; } }

        /// <summary>
        /// Returns the current Tikz Code, including the dynamic preamble,
        /// but not including the static preamble (from the settings)
        /// </summary>
        public string CodeWithPreamble {
            get 
            {
                if (Document == null) 
                    return "";
                if (String.IsNullOrWhiteSpace(DynamicPreamble))
                    return Document.Text;
                else
                    return DynamicPreamble + Environment.NewLine + Document.Text;
            } 
        }

        string _FilePath = null;
        /// <summary>
        /// This is the full file path, including the directory
        /// FilePath = null means the document has not been saved yet
        /// </summary>
        public string FilePath
        {
            get { return _FilePath; }
            private set
            {
                _FilePath = value;
                NotifyPropertyChanged("FilePath");
                NotifyPropertyChanged("ShortFileName");
                NotifyPropertyChanged("DisplayString");
            }
        }
        /// <summary>
        /// Is the filename, or, if FilePath=null, the default file name
        /// </summary>
        public string ShortFileName
        {
            get
            {
                if (FilePath != null)
                    return System.IO.Path.GetFileName(FilePath);
                else
                    return Consts.defaultCurFile;
            }
        }
        /// <summary>
        /// Same as shortfilename, but with a *
        /// </summary>
        public string DisplayString
        {
            get
            {
                string c = ShortFileName;
                if (ChangesMade)
                    c += "*";
                return c;
            }
        }
        private T _Document = null;
        /// <summary>
        /// This is an instance of the document wrapped by TEDocument.
        /// It is set during construction and not supposed to change suring the lifetime of TEDocument.
        /// </summary>
        public T Document
        {
            get { return _Document; }
            private set
            {
                if (_Document != null)
                    Document.Changed -= new EventHandler(Document_TextChanged);
                    //Document.Changed -= new EventHandler<DocumentChangeEventArgs>(Document_TextChanged);
                _Document = value;
                if (_Document != null)
                    Document.Changed += new EventHandler(Document_TextChanged);
                    //Document.Changed += new EventHandler<DocumentChangeEventArgs>(Document_TextChanged);
                NotifyPropertyChanged("Document");
            }
        }

         
        /// <summary>
        /// Indicates whether the document can be compiled as/is, or whether a preamble has to be added
        /// </summary>
        public bool IsStandAlone
        {
            get { return _IsStandAlone; }
            private set
            {
                _IsStandAlone = value;
                NotifyPropertyChanged("IsStandAlone");
            }
        }
        bool _IsStandAlone = false;

        /*int _CaretOffset = 0;
        public int CaretOffset
        {
            get { return _CaretOffset; }
            set
            {
                if (_CaretOffset != value)
                {
                    _CaretOffset = value;
                    NotifyPropertyChanged("CaretOffset");
                }
            }
        }*/

        Tikz_ParseTree _ParseTree = null;
        public Tikz_ParseTree ParseTree
        {
            get { return _ParseTree; }
            private set 
            {
                if (value != _ParseTree)
                {
                    if (_ParseTree != null)
                    {
                        _ParseTree.TextChanged -= OnParseTreeTextChanged;
                        _ParseTree.OnBeginModify -= OnParseTreeBeginModify;
                        _ParseTree.OnEndModify -= OnParseTreeEndModify;
                    }

                    _ParseTree = value;

                    if (_ParseTree != null)
                    {
                        _ParseTree.TextChanged += OnParseTreeTextChanged;
                        _ParseTree.OnBeginModify += OnParseTreeBeginModify;
                        _ParseTree.OnEndModify += OnParseTreeEndModify;
                    }

                    NotifyPropertyChanged("ParseTree");
                }
            }
        }

        bool _AllowEditing = false;
        public bool AllowEditing
        {
            get { return _AllowEditing; }
            private set
            {
                if (_AllowEditing != value)
                {
                    _AllowEditing = value;
                    NotifyPropertyChanged("AllowEditing");
                }
            }
        }

        public ObservableCollection<TexOutputParser.TexError> TexErrors { get; set; }

        /// <summary>
        /// The list of styles parsed from the File.
        /// </summary>
        public ObservableCollection<string> TikzStyles { get; set; }
        string _EdgeStyle = "", _NodeStyle = "";
        /// <summary>
        /// The currently selected edge style.
        /// </summary>
        public string EdgeStyle
        {
            get { return _EdgeStyle; }
            set
            {
                if (_EdgeStyle != value)
                {
                    _EdgeStyle = value;
                    NotifyPropertyChanged("EdgeStyle");
                }
            }
        }
        public string NodeStyle
        {
            get { return _NodeStyle; }
            set
            {
                if (_NodeStyle != value)
                {
                    _NodeStyle = value;
                    NotifyPropertyChanged("NodeStyle");
                }
            }
        }
        public bool AutomaticCompile { get; set; }
        public bool AutomaticParse { get; set; }

        double _Resolution = Consts.ptspertikzunit;
        public double Resolution
        {
            get { return _Resolution; }
            set
            {
                if (Resolution != value)
                {
                    _Resolution = value;
                    NotifyPropertyChanged("Resolution");
                    //if (OnPdfReady != null)
                    //    OnPdfReady(this, new PdfReadyEventArgs() { ReloadPdf=false });
                }
            }
        }
        //public BitmapSource bmp { get; private set; }

        private bool _ChangesMade = false;
        /// <summary>
        /// indicates whether changes (that need to be saved) have been made to the current file
        /// </summary> 
        public bool ChangesMade
        {
            get { return _ChangesMade; }
            set
            {
                if (_ChangesMade != value)
                {
                    _ChangesMade = value;
                    NotifyPropertyChanged("ChangesMade");
                    NotifyPropertyChanged("DisplayString");
                }
                //CurFile = CurFile;
            }
        }

        private Rect _currentBB = new Rect(CompilerSettings.Instance.BB_Std_X, CompilerSettings.Instance.BB_Std_Y, CompilerSettings.Instance.BB_Std_W, CompilerSettings.Instance.BB_Std_H);
        /// <summary>
        /// The currently active bounding box.
        /// </summary>
        public Rect CurrentBB
        {
            get { return _currentBB; }
            private set
            {
                _currentBB = value;
                NotifyPropertyChanged("CurrentBB");
                //BBStatusBarItem.Content = "Bounding Box: (" + Math.Round(currentBB.X, 2) + ", " + Math.Round(currentBB.Y, 2) + ") ("
                //    + Math.Round(currentBB.X + currentBB.Width, 2) + ", " + Math.Round(currentBB.Y + currentBB.Height, 2) + ")";

                // add some margin
                //Rect bigger = currentBB;
                //bigger.Inflate(Properties.Settings.Default.BB_Margin, Properties.Settings.Default.BB_Margin);
                //pdfOverlay1.BB = bigger;
                //rasterControl1.BB = bigger;
            }
        }

        string _PdfPath = "";
        /// <summary>
        /// The path to the Pdf file that is currently displayed.
        /// </summary>
        public string PdfPath
        {
            get { return _PdfPath; }
            set
            {
                if (_PdfPath != value)
                {
                    _PdfPath = value;
                    NotifyPropertyChanged("PdfPath");
                }
            }
        }

        int _ReloadPdf = 0;
        /// <summary>
        /// The value is changed whenever the Pdf file's content has changed (i.e., after compilation).
        /// (This is a hack to enable the viewmodel to "call events" in the view.)
        /// The view typically binds to ReloadPdf and reloads the pdf when the value has changed
        /// </summary>
        public int ReloadPdf
        {
            get { return _ReloadPdf; }
            set
            {
                if (_ReloadPdf != value)
                {
                    _ReloadPdf = value;
                    NotifyPropertyChanged("ReloadPdf");
                }
            }
        }

        #endregion

        #region Events

        public event EventHandler OnClose;
        public event EventHandler OnSaved;
        public class PdfReadyEventArgs : EventArgs { public bool ReloadPdf; }
        public event EventHandler<PdfReadyEventArgs> OnPdfReady;

        #endregion

        #region Event Handlers
        void OnParseTreeBeginModify(object sender, EventArgs e)
        {
            Document.BeginUpdate();
        }
        void OnParseTreeEndModify(object sender, EventArgs e)
        {
            Document.EndUpdate();
            Recompile(true);
            UpdateStyleList();
        }
        void OnParseTreeTextChanged(object sender, ParseTreeTextChangedEventArgs e)
        {
            if (e.ChangedItem != null)
            {
                int InsertAt = e.ChangedItem.StartPosition();
                if (InsertAt > Document.Text.Length)
                {
                    GlobalUI.UI.AddStatusLine(this, "Trying to insert code \"" + e.ChangedItem.ToString().Replace(Environment.NewLine, "<NEWLINE>") + "\" to position " + e.ChangedItem.StartPosition() + " but document has only " + Document.Text.Length + " characters."
                    + " Inserting code at end of document instead. Code does probably not compile now. Please correct or choose undo.", true);
                    InsertAt = Document.Text.Length;
                }

                WYSIWYGTextChange = true;
                Document.Replace(InsertAt, e.OldText.Length, e.ChangedItem.ToString());
                WYSIWYGTextChange = false;
            }
        }

        void TheCompiler_JobDone(object sender, TexCompiler.JobEventArgs e)
        {
            TexCompiler.Job job = e.job;
            // it may happen that pdflatex returns after a new document has been created->then don't load the pdf
            if (job.DocumentID == DocumentID)
            {
                if (!job.GeneratePrecompiledHeaders && e.ExitCode == 0)
                {
                    // set the currrent BB, if the BB could be determined.
                    // if not, and we are in preview mode, we have a problem
                    if (job.hasBB)
                    {
                        Rect newBB = job.BB;
                        newBB.Inflate(CompilerSettings.Instance.BB_Margin, CompilerSettings.Instance.BB_Margin);
                        CurrentBB = newBB;
                    }
                    BBvalid = job.hasBB;
                    // (re-)load the pdf to display                
                    PdfPath = Helper.RemoveFileExtension(job.path) + ".pdf";
                    if (OnPdfReady != null)
                        OnPdfReady(this, new PdfReadyEventArgs() { ReloadPdf = true });
                    ReloadPdf++;

                }

                // add error markers
                if (e.OutputParseResult != null && e.OutputParseResult.Errors != null)
                    foreach (var err in e.OutputParseResult.Errors)
                        addProblemMarker(err, job);
            }

        }

        /// <summary>
        /// This is called whenever the text in the current document changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Document_TextChanged(object sender, EventArgs e)
        {

            //if (isLoaded)
            //{
            //doc.Text = "asdf";
            //txtCode.Document = doc;
            //SourceManager.Instance.SourceCode.Text = txtCode.Document.Text;

            ChangesMade = true;
            
            // no auto-compilation in Production Mode (no Auto saving)
            //if (chkProductionMode.IsChecked == false)
            if (TheVM == null || TheVM.EditorMode != TEMode.Production)
            {
                if (TheVM.AutoCompileOnDocumentChange || WYSIWYGTextChange)
                {
                    if (ParseTree == null || !ParseTree.MoreChangesToCome)
                        Recompile();
                }
                else
                    AllowEditing = false; // out of sync -> disable editing
            }

            //}
        }


        void fileWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            //return;
            GlobalUI.UI.BeginInvokeInUIThread( new Action(delegate()
            {
                // there is a well-known issue with filewatcher raising multiple events... so, as a hack, stop wtaching
                fileWatcher.EnableRaisingEvents = false;
                // the currently watched file was changed -> ask the user to reload
                switch (GlobalUI.UI.ShowMessageBox("The currently open file was modified outside the editor.\r\nDo you want to reload the file from disk?",
                    "Modified outside TikzEdt", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Warning))
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        ChangesMade = false;
                        LoadFile(FilePath); // here the filewatcher is turned on again implicitly
                        Recompile();
                        break;
                    case System.Windows.Forms.DialogResult.No:
                        ChangesMade = true;
                        fileWatcher.EnableRaisingEvents = true;
                        break;
                }
            }));
        }

        void AsyncParser_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            
            AsyncParserResultType Result = e.Result as AsyncParserResultType;
            if (Result == null)
                throw new Exception("AsyncParser_RunWorkerCompleted() can only handle e.Result  of type AsyncParserResultType!");

            // in case of outdated parse -> ignore
            if (Result.DocumentID != DocumentID)
                return;

            IsStandAlone = Result.IsStandAlone;       

            //check if error occurred
            if (Result.Error != null && Result.Error is RecognitionException)
            {
                RecognitionException ex = Result.Error as RecognitionException;
                string errmsg = ANTLRErrorMsg.ToString(ex, simpletikzParser.tokenNames);
                GlobalUI.UI.AddStatusLine(this, "Couldn't parse code. " + errmsg, true);
                if (ex.Line == 0 && ex.CharPositionInLine == -1)
                {
                    addProblemMarker(errmsg, Document.LineCount, 0, Severity.PARSERERROR, ShortFileName);
                }
                else
                {
                    addProblemMarker(errmsg, ex.Line, ex.CharPositionInLine, Severity.PARSERERROR, ShortFileName);
                }
                ParseTree = null;
                TikzStyles.Clear();

            }
            else if (Result.Error != null)
            {
                string errmsg = Result.Error.GetType().ToString();
                if (Result.Error is Exception)
                    errmsg += ":" + ((Exception)Result.Error).Message;
                GlobalUI.UI.AddStatusLine(this, "Couldn't parse code. " + errmsg, true);
                ParseTree = null;
                TikzStyles.Clear();
            }
            else
            {
                // parsing succesfull
                Tikz_ParseTree tp = Result.ParseTree as Tikz_ParseTree;
                ParseTree = tp;

                // if no other changes are pending, we can turn on editing again
                AllowEditing = true;

                // fill the style list
                UpdateStyleList();
                
                //now check if a warning occured. That would be a parser error in an included file.                
                if (Result.Warning != null && Result.Warning is RecognitionException)
                {
                    RecognitionException ex = Result.Warning as RecognitionException;
                    string errmsg = ANTLRErrorMsg.ToString(ex, simpletikzParser.tokenNames);
                    GlobalUI.UI.AddStatusLine(this, "Couldn't parse included file. " + errmsg, true);
                    if (ex.Line == 0 && ex.CharPositionInLine == -1)
                    {
                        addProblemMarker(errmsg, Document.LineCount, 0, Severity.PARSERWARNING, Result.WarningSource);

                    }
                    else
                    {
                        addProblemMarker(errmsg, ex.Line, ex.CharPositionInLine, Severity.PARSERWARNING, Result.WarningSource);
                    }

                }
                else if (Result.Warning != null && Result.Warning is ParserException)
                {
                    ParserException pe = Result.Warning as ParserException;
                    addProblemMarker(pe.e);
                }
                else if (Result.Warning != null && Result.Warning is Exception)
                {
                    string errmsg = ((Exception)Result.Warning).Message;
                    GlobalUI.UI.AddStatusLine(this, "Couldn't parse included file " + Result.WarningSource + ". " + errmsg, true);
                }
                
            }

            // Restart parser if necessary
            ParseNeeded = ParseNeeded;
        }

        #endregion    
                      

        #region private fields

        MainWindowVM<T> TheVM;
        TexCompiler Compiler;

        FileSystemWatcher fileWatcher = new FileSystemWatcher();
        //System.ComponentModel.BackgroundWorker AsyncParser = new System.ComponentModel.BackgroundWorker();
        MyBackgroundWorker AsyncParser = new MyBackgroundWorker();
        class AsyncParserJob
        {
            public string code;
            public long DocumentID;
            public string DynamicPreamble;
            public AsyncParserJob(string tcode, long tDocumentID, string tDynamicPreamble)
            {
                code = tcode; DocumentID = tDocumentID;
                DynamicPreamble = tDynamicPreamble;
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
                    AsyncParser.RunWorkerAsync(new AsyncParserJob(Document.Text, DocumentID, DynamicPreamble));
                }
            }
        }

        #endregion

        /// <summary>
        /// The document ID uniquely identifies the current document. It is used to assure that results of 
        /// asynchronous operations (parser and pdflatex) can be matched with the document they belong to.
        /// Note that a problem arises, e.g., when
        ///     one changes the file-> it gets compiled with pdflatex-> now one hits newfile
        ///     -> the compiler returns -> if careless, the wrong file is displayed.
        /// 
        /// </summary>
        long DocumentID = 0;

        /// <summary>
        /// indicates whether current file has never been saved (=created with new file and not yet saved)
        /// </summary>
        bool CurFileNeverSaved { get { return FilePath == null; } }
         
 /*       private bool _useBB;
        bool useBB
        {
            get { return _useBB; }
            set
            {
                _useBB = value;
                if (value == true)
                { }
            }
        }*/
 

        /// <summary>
        /// If cFile != null, the new Document will be loaded from file
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="compiler"></param>
        /// <param name="cFile"></param>
        public TEDocumentVM(MainWindowVM<T> parent, TexCompiler compiler, string cFile = null)
        {
            TheVM = parent;
            Compiler = compiler;
            // Set new document ID, before receiving any compiler events
            DocumentID = DateTime.Now.Ticks;
          
            TikzStyles = new ObservableCollection<string>();
            TexErrors = new ObservableCollection<TexOutputParser.TexError>();
            // TODO: strong coupling, introduces mem leaks
            Compiler.JobDone += TheCompiler_JobDone;

            AsyncParser.DoWork += new System.ComponentModel.DoWorkEventHandler(AsyncParser_DoWork);
            AsyncParser.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(AsyncParser_RunWorkerCompleted);
            fileWatcher.Changed += new FileSystemEventHandler(fileWatcher_Changed);

            // stop listening for changes
            //fileWatcher.EnableRaisingEvents = false;
            //isLoaded = false;
            //CurFileNeverSaved = true;
            ChangesMade = false;

            if (cFile == null)
            {
                T doc = new T(); doc.Text = Consts.DefaultTikzCode; Document = doc;
            }
            else
                LoadFile(cFile);

            // start compiling the file
            Recompile();

            //FilePath = cFile;
            //txtCode.Text = "";
            //tikzDisplay1.SetUnavailable();
            //pdfOverlay1.Clear();
            //DetermineBB(null);
            //rasterControl1.ResetRaster();
            //pdfOverlay1.SetParseTree(null, currentBB);
            //pdfOverlay1.AllowEditing = true;
            //currentBB = new Rect(Properties.Settings.Default.BB_Std_X, Properties.Settings.Default.BB_Std_Y, Properties.Settings.Default.BB_Std_W, Properties.Settings.Default.BB_Std_H);
            //ClearStyleLists();

        }

        ~TEDocumentVM()
        {
            if (CurFileNeverSaved)
            {
                //delete temp files there.
                Helper.DeleteTemporaryFiles(System.IO.Path.GetTempPath() + "\\" + Helper.GetTempFileName(), true);
            }
            else
            {    
                Helper.DeleteTemporaryFiles(FilePath);
            }
        }


        #region methods

        /// <summary>
        /// Fills the currently displayed lists of styles from the parsetree provided
        /// </summary>
        /// <param name="t">The parse tree to extract the styles from</param>
        public void UpdateStyleList()
        {
            if (ParseTree == null) return;
            string oldNodeStyle = NodeStyle, oldEdgeStyle = EdgeStyle;

            TikzStyles.Clear();
            foreach (string s in ParseTree.styles.Keys)
            {
                TikzStyles.Add(s);
            }

            NodeStyle = oldNodeStyle;
            EdgeStyle = oldEdgeStyle;

        }

        /// <summary>
        /// Tries to close the current file.
        /// If changes have to be saved, the user is asked whether or not to save.
        /// </summary>
        /// <param name="DeleteTemporaryFiles">Indicates whether temporary files should be deleted.</param>
        /// <returns></returns>
        public bool TryDisposeFile(bool DeleteTemporaryFiles = true)
        {
            if (ChangesMade)
            {
                switch (GlobalUI.UI.ShowMessageBox("Save changes to " + ShortFileName + "?", "Changes need to be saved",
                    System.Windows.Forms.MessageBoxButtons.YesNoCancel, System.Windows.Forms.MessageBoxIcon.Warning))
                {
                    case (System.Windows.Forms.DialogResult.Yes):
                        if (!SaveCurFile()) return false;
                        break;
                    case (System.Windows.Forms.DialogResult.Cancel):
                        return false;
                }
            }
            if (DeleteTemporaryFiles)
            {
                //before delete temp data, we have to cloase the pdf
                //tikzDisplay1.SetUnavailable();
                // TODOOOO
                //if (CurFile == Consts.defaultCurFile)
                //    Helper.DeleteTemporaryFiles(Helper.GetTempFileName(), true);
                //else
                //    Helper.DeleteTemporaryFiles(CurFile);
            }
            return true;
        }


        /// <summary>
        /// Comments out the lines intersecting the specified segment.
        /// </summary>
        /// <param name="startoffset"></param>
        /// <param name="endoffset"></param>
        public void CommentSegment(int startoffset, int endoffset)
        {
            if (startoffset < 0 || startoffset > Document.Text.Length || endoffset < 0 || endoffset > Document.Text.Length)
                return;
            Document.BeginUpdate();
            int startline = Document.LineFromOffset(startoffset),
                endline = Document.LineFromOffset(endoffset);
            for (int i = startline; i <= endline; i++)
                Document.Insert(Document.OffsetFromLine(i), "% ");
            Document.EndUpdate();
        }

        /// <summary>
        /// Removes comment marks from the lines intersecting the specified segment.
        /// </summary>
        /// <param name="startoffset"></param>
        /// <param name="endoffset"></param>
        public void UnCommentSegment(int startoffset, int endoffset)
        {
            if (startoffset < 0 || startoffset > Document.Text.Length || endoffset < 0 || endoffset > Document.Text.Length)
                return;
            Document.BeginUpdate();
            int startline = Document.LineFromOffset(startoffset),
                endline = Document.LineFromOffset(endoffset);
            for (int i = startline; i <= endline; i++)
            {
                int offset = Document.OffsetFromLine(i);
                string s = Document.GetLine(i);// GetText(offset, txtCode.Document.Lines[i - 1].Length);
                if (s.StartsWith("% "))
                    Document.Remove(offset, 2);
                else if (s.StartsWith("%"))
                    Document.Remove(offset, 1);
            }
            Document.EndUpdate();
        }


        public override string ToString()
        {
            return DisplayString;
        }

         /// <summary>
        /// Loads a file.
        /// Raises an exception on error.
        /// </summary>
        /// <param name="cFile">Specify file to load. This must be a full path (not relative).</param>
        public void LoadFile(string cFile)
        {
            //bool LoadedCorrectly = false;
            if (!File.Exists(cFile))
                throw new Exception("The file: " + cFile + " does not exist.");
            //MessageBox.Show("Error: File not found: " + cFile, "File not found", MessageBoxButton.OK, MessageBoxImage.Error);
            //RecentFileList.RemoveFile(cFile);
            //return;


            //clean everything before loading file:
            //CleanupForNewFile();

            //set current dir to dir containing cFile.
            Helper.SetCurrentWorkingDir(Helper.WorkingDirOptions.DirFromFile, cFile);
            //MainWindow.AddStatusLine("Working directory is now: " + Helper.GetCurrentWorkingDir());


            string newcode = File.ReadAllText(cFile);
            //bmp = null; //tikzDisplay1.SetUnavailable(); // new file is directly compiled... but set unavailable in case error occurs
            ParseTree = null; //(null, currentBB);
            TikzStyles.Clear(); //ClearStyleLists();
            FilePath = cFile;
            ChangesMade = false;
            //CurFileNeverSaved = false;

            T doc = new T(); doc.Text = newcode; Document = doc;
            
            //Document.Insert(0, newcode);
            ChangesMade = false;  // set here since txtCode sets ChangesMade on Text change        
            

            // start watching for external changes
            fileWatcher.Path = Path.GetDirectoryName(FilePath); // Directory.GetCurrentDirectory();
            fileWatcher.Filter = Path.GetFileName(FilePath); //ShortFileName;
            fileWatcher.EnableRaisingEvents = true;

        }


        public bool SaveCurFile(bool saveas = false)
        {
            bool isTempFile = CurFileNeverSaved;
            string OldFileName = FilePath, filename;

            bool WeNeedRecompilationAfterSave = false;
            if (CurFileNeverSaved || saveas)
            {
                if (GlobalUI.UI.ShowSaveFileDialog(out filename, ShortFileName) != true)
                    return false;
                
                FilePath = filename; 
                WeNeedRecompilationAfterSave = true;
            }

            // turn off listening for changes... we don't want to catch our change
            fileWatcher.EnableRaisingEvents = false;

            StreamWriter wr = new StreamWriter(FilePath);
            wr.Write(Document.Text);
            wr.Close();
            ChangesMade = false;
            //CurFileNeverSaved = false;

            GlobalUI.UI.AddStatusLine(this, "File saved to " + FilePath + ".");
            if (OnSaved != null)
                OnSaved(this, new EventArgs());

            //delete old temp data.
            if (saveas)
            {
                //before delete temp data, we have to close the pdf
                //bmp = null; // tikzDisplay1.SetUnavailable();

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
                Helper.SetCurrentWorkingDir(Helper.WorkingDirOptions.DirFromFile, FilePath);
           //     FilePath = System.IO.Path.GetFileName(FilePath);
            }

            // start watching for external changes again
            fileWatcher.Path = Directory.GetCurrentDirectory();
            fileWatcher.Filter = ShortFileName;
            fileWatcher.EnableRaisingEvents = true;

            if (WeNeedRecompilationAfterSave)
                Recompile();
            return true;
        }

        public bool ProgrammaticTextChange = false;
        bool WYSIWYGTextChange = false;
        /// <summary>
        /// If the tex code is changed, this method Reompiles it.
        /// The action taken depends upon the currently active mode:
        /// Wysiwyg Mode: 
        ///     Starts asynchronous parse and compile operations.
        ///     The compilation is done on a temporary file in the current document's folder.
        /// Preview Mode:
        ///     Compilation only, done on a temporary file in the current document's folder.
        /// Production Mode:
        ///     Compilation only, done on the current document directly (not on temp file).
        /// </summary>
        /// <param name="NoParse">Skip the parsing step if true. (compile only)</param>
        public void Recompile(bool NoParse = false)
        {            
            // Parse and compile, depending on current mode
            string path;
            if (FilePath != null)
                path = FilePath + Helper.GetPreviewFilename() + Helper.GetPreviewFilenameExt();
            else
                path = "";      // use a temp file
            
            if (TheVM == null || TheVM.EditorMode == TEMode.Wysiwyg)
            {
                if (!ProgrammaticTextChange && !NoParse)
                {
                    if (Document.Text.Trim() != "")
                    {
                        AllowEditing = false;   // overlay out of date->turn off editing
                        ParseNeeded = true;
                    }
                    else
                    {
                        ParseTree = new Tikz_ParseTree();
                        AllowEditing = true;
                    }
                }
                //return;
                //compiling must only be started if there is latex code
                if (Document.Text.Trim() != "")
                {
                    // prepend the Dynamic preamble
                    string DynPre = (String.IsNullOrWhiteSpace(DynamicPreamble)?"": DynamicPreamble+ Environment.NewLine);
                    TheCompiler.Instance.AddJobExclusive(DynPre+ Document.Text, path, true, DocumentID, DynPre.Count(c => c=='\n'));
                }
                else
                    PdfPath = "";
                
            }
            else if (TheVM.EditorMode == TEMode.Preview)
            {
                //TheCompiler.Instance.AddJobExclusive(Document.Text, path, false, DocumentID);
                TheCompiler.Instance.AddJobExclusive(CodeWithPreamble, path, false, DocumentID);
            }
            else
            {
                if (SaveCurFile())
                    TheCompiler.Instance.AddJobExclusive(FilePath, DocumentID);
                else
                    PdfPath = "";
            }

            TexErrors.Clear();
        }

        public string SavePdf(bool SaveAs)
        {
            if (SaveAs == false && CurFileNeverSaved)
            {
                GlobalUI.UI.AddStatusLine(this, "Please save document first", true);
                return "";
            }

            //string s = Helper.GetCurrentWorkingDir();
            //string t = Helper.GetPreviewFilename();
            //string PreviewPdfFilePath = s + "\\" + FilePath + t + ".pdf";
            string NewPdfFilePath = Helper.RemoveFileExtension(FilePath) + ".pdf";
            

            if (SaveAs == true)
            {             
                string filter = "Pdf Files|*.pdf|All Files|*.*";                
                string initFileName = System.IO.Path.GetFileName(FilePath);
                string outFileName;
                // change file extension to .pdf
                initFileName = Helper.RemoveFileExtension(initFileName) + ".pdf";
                //sfd.InitialDirectory = System.IO.Path.GetDirectoryName(FilePath);
                if (GlobalUI.UI.ShowSaveFileDialog(out outFileName, initFileName, filter) != true)
                    return "";
                NewPdfFilePath = outFileName;
            }

            try
            {
                File.Copy(PdfPath, NewPdfFilePath, true);
            }
            catch (Exception Ex)
            {
                GlobalUI.UI.AddStatusLine(this, "Could not save PDF. " + Ex.Message, true);
                return "";
            }

            GlobalUI.UI.AddStatusLine(this, "Preview PDF file saved as " + NewPdfFilePath);
            return NewPdfFilePath;
        }
        /// <summary>
        /// Displays an Export As dialog and, if successful, exports the current tikzpicture 
        /// as either bmp, jpeg, tiff or png.
        /// </summary>
        public void ExportFile()
        {
            if (!File.Exists(PdfPath))
            {
                GlobalUI.UI.AddStatusLine(this, "Please compile document first", true);
                return;
            }

            //string s = Helper.GetCurrentWorkingDir();
            //string t = Helper.GetPreviewFilename();
            //string PreviewPdfFilePath = s + "\\" + this.FilePath + t + ".pdf";
            //string TheFilePath = Helper.RemoveFileExtension(this.FilePath) + ".pdf";

            string filter = "Jpeg Files|*.jpg|Portable Network Graphics|*.png|Bitmap Files|*.bmp|Tiff Files|*.tif|Graphics Interchange Format|*.gif|Extended Meta File|*.emf|Windows Meta File|*.wmf|Html File|*.html|Scalable Vector Graphics|*.svg";
            //sfd.FilterIndex = 1;
            string initFileName = ShortFileName;
            initFileName = Helper.RemoveFileExtension(initFileName) + ".jpg";
            string outFileName;

            // change file extension to .pdf            
            //sfd.InitialDirectory = System.IO.Path.GetDirectoryName(TheFilePath);
            if (GlobalUI.UI.ShowSaveFileDialog(out outFileName, initFileName, filter) != true)
                return;
           
            try
            {
                System.Drawing.Imaging.ImageFormat imgFormat;
                bool Transparent = true;
                switch (System.IO.Path.GetExtension(outFileName).ToLower())
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
                    case ".svg":
                    case ".html":
                    case ".htm":
                        // The file will be compiled and exported by ExportCompileDialog
                        GlobalUI.UI.ShowExportCompileDialog(this, CodeWithPreamble, outFileName);
                        return;
                    default:
                        GlobalUI.UI.AddStatusLine(this, "Could not export file: Unknown file extension.", true);
                        return;
                }

                PdfToBmp p2b = new PdfToBmp();
                p2b.LoadPdf(PdfPath);
                p2b.SaveBmp(outFileName, Consts.ptspertikzunit, Transparent, imgFormat);
            }
            catch (Exception Ex)
            {
                GlobalUI.UI.AddStatusLine(this, "Could not export file. " + Ex.Message, true);
                return;
            }

            GlobalUI.UI.AddStatusLine(this, "File exported as " + outFileName);
        }

        void addProblemMarker(TexOutputParser.TexError err, TexCompiler.Job job = null) //String error, int linenr, TexCompiler.Severity severity)
        {
            // if job = null, the error was generated by the parser => always display
            // otherwise display only if the job really was the current document
            if (job == null || job.DocumentID == DocumentID)
                TexErrors.Add(err);
        } 
        void addProblemMarker(string msg, int line, int pos, Severity severity, string file)
        {
            TexOutputParser.TexError err = new TexOutputParser.TexError();
            err.error = msg;
            err.causingSourceFile = file;
            err.Line = line;
            err.Pos = pos;
            err.severity = severity;
            addProblemMarker(err);
        }

        /// <summary>
        /// The this is given from AsyncParser_DoWork() to AsyncParser_RunWorkerCompleted().
        /// </summary>
        class AsyncParserResultType
        {
            /// <summary>
            /// Holds the ParseTree of the main file (shown in txtCode) if successful.
            /// </summary>
            public Tikz_ParseTree ParseTree { get; set; }
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
            /// <summary>
            /// A flag indicating whether the document can be compiled as is.
            /// </summary>
            public bool IsStandAlone {get; set;}
            /// <summary>
            /// Records how many lines of Dynamic preamble have been added. Error line numbers must be corrected accordingly.
            /// </summary>
            //public int Err_Offset { get; set; }
        }
        class ParserException : Exception
        {
            public ParserException(string message) : base(message) { }
            public TexOutputParser.TexError e;
        }
        // Unfortunately, due to a debugger "bug", the exception has to be caught and transferred into a cancelled event
        // this cancel event type is AsyncParserResultType. It is passed to AsyncParser_RunWorkerCompleted().
        Regex InputsRegex = new Regex(@"((^[^%]*|\n[^\n%]*?)\\input{(?<file>.*)})|(^|\n(\s)*" +Consts.PreProc_Include+ @"\s+(?<file>))", RegexOptions.Compiled);
        void AsyncParser_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            AsyncParserResultType Result = new AsyncParserResultType();
            //make sure that double typed numbers are converted with decimal point (not comma!) to string
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");

            try
            {
                AsyncParserJob job = e.Argument as AsyncParserJob;
                Result.DocumentID = job.DocumentID;

                // the dynamic preamble
                //string DynPre = (String.IsNullOrWhiteSpace(job.DynamicPreamble) ? "" : job.DynamicPreamble + Environment.NewLine);
                //Result.Err_Offset = DynPre.Count(c => c == '\n');

                Tikz_ParseTree tp = TikzParser.Parse(job.code);
                Result.ParseTree = tp;

                Result.IsStandAlone = TexCompiler.IsStandalone(job.code);

                // parse Dynamic preamble
                if (!String.IsNullOrWhiteSpace(job.DynamicPreamble))
                {
                    try
                    {
                        Tikz_ParseTree tp2 = TikzParser.ParseInputFile(job.DynamicPreamble);
                        if (tp2 != null)
                        {
                            //every style that was found in included file, add it to parse tree of main file.
                            foreach (KeyValuePair<string, Tikz_Option> style in tp2.styles)
                            {
                                if (!Result.ParseTree.styles.ContainsKey(style.Key))
                                {
                                    Result.ParseTree.styles.Add(style.Key, style.Value);
                                }
                            }
                        }
                    }
                    catch (Exception )
                    {

                    }
                }

                //include any styles from include files via \input cmd
                string inputfile = "";
                try
                {
                    //find input files using Regex                    
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
                                    if (!Result.ParseTree.styles.ContainsKey(style.Key))
                                    {
                                        Result.ParseTree.styles.Add(style.Key, style.Value);
                                    }
                                    else
                                    {
                                        ParserException pe = new ParserException("");
                                        TexOutputParser.TexError te = new TexOutputParser.TexError();
                                        te.Message = "Style [" + style.Key + "] is defined multiple times. Check position " + style.Value.StartPosition() + " in " + inputfile + " and this definition.";
                                        te.Pos = Result.ParseTree.styles[style.Key].StartPosition();
                                        te.severity = Severity.PARSERWARNING;
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
                Result.WarningSource = ShortFileName;
            }
            finally
            {
                e.Result = Result;
            }
        }

        #endregion

        /// <summary>
        /// Tries to insert a \usetikzlibrary{lib} into the code, if it is not present
        /// </summary>
        /// <param name="lib"></param>
        public void InsertUseTikzLibrary(string lib)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(lib))
                {
                    // check if library already used (... it is a bit of a hack) 
                    Regex r = new Regex(@"\\usetikzlibrary(\s*)\{(\s*)" + lib + @"(\s*)\}", RegexOptions.IgnorePatternWhitespace);
                    if (!r.IsMatch(Document.Text))
                    {
                        Regex rr = new Regex(@"\\begin(\s*)\{(\s*)tikzpicture(\s*)}");
                        Match m = rr.Match(Document.Text);
                        if (m.Success)
                            Document.Replace(m.Index, 0, @"\usetikzlibrary{" + lib + "}" + Environment.NewLine);
                    }
                }
            }
            catch (Exception)
            {
                // failed -> dont bother
            }

        }


    /*    public static implicit operator TEDocumentContent(TEDocumentVM m)
        {
            // code to convert from MyType to int
            return new TEDocumentContent();
        }

        public TEDocumentContent doccontent
        {
            get
            {
                return new TEDocumentContent();
            }
        }
        */

        public void Dispose()
        {
            //Document = null;
            TheCompiler.Instance.JobDone -= TheCompiler_JobDone;
            fileWatcher.EnableRaisingEvents = false;
            ParseTree = null;
        }
    }

  /*  public class TEDocumentContent : AvalonDock.DocumentContent
    {
        public TEDocumentContent()
        {
            //Content = new TextEditor();
            Title = "Hallo Welt";
        }
    }
    */
}
