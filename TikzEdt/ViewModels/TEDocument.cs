using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using ICSharpCode.AvalonEdit;
using TikzEdt.Parser;
using ICSharpCode.AvalonEdit.Document;
using System.Windows;
using System.IO;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;
using System.Windows.Input;
using System.Text.RegularExpressions;
using Antlr.Runtime;

namespace TikzEdt.ViewModels
{
    /// <summary>
    /// The viewmodel for a single TikzEdt document.
    /// </summary>
    public class TEDocumentVM : ViewModelBase
    {
        RelayCommand _CompileCommand;
        public ICommand CompileCommand
        {
            get
            {
                 if (_CompileCommand == null)
                    _CompileCommand = new RelayCommand(o => Recompile(), o => true );
                return _CompileCommand;
            }
        }
        RelayCommand _SavePdfCommand;
        public ICommand SavePdfCommand
        {
            get
            {
                if (_SavePdfCommand == null)
                    _SavePdfCommand = new RelayCommand(o => SavePdf(o != null), o => true);
                return _SavePdfCommand;
            }
        }
        RelayCommand _ExportFileCommand;
        public ICommand ExportFileCommand
        {
            get
            {
                if (_ExportFileCommand == null)
                    _ExportFileCommand = new RelayCommand(o => ExportFile());
                return _ExportFileCommand;
            }
        }

        //CommandBinding CompileCommandBinding { get { return new CommandBinding(CompileCommand, CompileCommandHandler); } }
        private void CompileCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            Recompile();
        }

        string _FilePath = null;
        /// <summary>
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
        private TextDocument _Document = null;
        public TextDocument Document
        {
            get { return _Document; }
            private set
            {
                if (_Document != null)
                    Document.Changed -= new EventHandler<DocumentChangeEventArgs>(Document_TextChanged);
                _Document = value;
                if (_Document != null)
                    Document.Changed += new EventHandler<DocumentChangeEventArgs>(Document_TextChanged);
                NotifyPropertyChanged("Document");
            }
        }

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
                    MainWindow.AddStatusLine("Trying to insert code \"" + e.ChangedItem.ToString().Replace(Environment.NewLine, "<NEWLINE>") + "\" to position " + e.ChangedItem.StartPosition() + " but document has only " + Document.Text.Length + " characters."
                    + " Inserting code at end of document instead. Code does probably not compile now. Please correct or choose undo.", true);
                    InsertAt = Document.Text.Length;
                }

                Document.Replace(InsertAt, e.OldText.Length, e.ChangedItem.ToString());
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

        //public delegate void NoArgsEventHandler(object sender);
        public event EventHandler OnClose;
        public event EventHandler OnSaved;
        public class PdfReadyEventArgs : EventArgs { public bool ReloadPdf; }
        public event EventHandler<PdfReadyEventArgs> OnPdfReady;

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
        public BitmapSource bmp { get; private set; }



        /// <summary>
        /// The document ID uniquely identifies the current document. It is used to assure that results of 
        /// asynchronous operations (parser & pdflatex) can be matched with the document they belong to.
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
        // indicates whether changes (that need to be saved) are made to the current file
        private bool _ChangesMade = false;
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

        private bool _useBB;
        bool useBB
        {
            get { return _useBB; }
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
                    AsyncParser.RunWorkerAsync(new AsyncParserJob(Document.Text, DocumentID));
                }
            }
        }

        string _PdfPath = "";
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

        #region commands
        //public RelayCommand CloseCommand { get { return new RelayCommand((e); } } 
        public RelayCommand CloseCommand { get { return new RelayCommand((object sender) => RequestCloseFile()); } }
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


        #region private fields
        FileSystemWatcher fileWatcher = new FileSystemWatcher();
        System.ComponentModel.BackgroundWorker AsyncParser = new System.ComponentModel.BackgroundWorker();
        class AsyncParserJob
        {
            public string code;
            public long DocumentID;
            public AsyncParserJob(string tcode, long tDocumentID)
            {
                code = tcode; DocumentID = tDocumentID;
            }
        }

        #endregion

        /// <summary>
        /// If cFile != null, the new Document will be loaded from file
        /// </summary>
        /// <param name="cFile"></param>
        public TEDocumentVM(string cFile = null)
        {
            // Set new document ID, before receiving any compiler events
            DocumentID = DateTime.Now.Ticks;

            
            TikzStyles = new ObservableCollection<string>();
            TexErrors = new ObservableCollection<TexOutputParser.TexError>();
            TheCompiler.Instance.JobSucceeded += new TexCompiler.JobEventHandler(TheCompiler_JobSucceeded);
            TheCompiler.Instance.OnTexError += new TexCompiler.TexErrorHandler(addProblemMarker);

            AsyncParser.DoWork += new System.ComponentModel.DoWorkEventHandler(AsyncParser_DoWork);
            AsyncParser.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(AsyncParser_RunWorkerCompleted);
            fileWatcher.Changed += new FileSystemEventHandler(fileWatcher_Changed);

            // stop listening for changes
            //fileWatcher.EnableRaisingEvents = false;
            //isLoaded = false;
            //CurFileNeverSaved = true;
            ChangesMade = false;

            if (cFile == null)
                Document = new TextDocument(Consts.DefaultTikzCode);
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


        #region methods

        void TheCompiler_JobSucceeded(object sender, TexCompiler.Job job)
        {
            // it may happen that pdflatex returns after a new document has been created->then don't load the pdf
            if (job.DocumentID == DocumentID)
            {
                if (!job.GeneratePrecompiledHeaders)
                {
                    // set the currrent BB, if the BB could be determined.
                    // if not, and we are in preview mode, we have a problem
                    if (job.hasBB)
                    {
                        Rect newBB = job.BB;
                        newBB.Inflate(Properties.Settings.Default.BB_Margin, Properties.Settings.Default.BB_Margin);
                        CurrentBB = newBB;
                    }
                    BBvalid = job.hasBB;
                    // (re-)load the pdf to display                
                    PdfPath = Helper.RemoveFileExtension(job.path) + ".pdf";
                    if (OnPdfReady != null)
                        OnPdfReady(this, new PdfReadyEventArgs() { ReloadPdf = true });
                    ReloadPdf++;

                }
            }
        }

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

        public bool TryDisposeFile(bool DeleteTemporaryFiles = true)
        {
            if (ChangesMade)
            {
                switch (MessageBox.Show("Save changes to " + ShortFileName + "?", "Changes need to be saved",
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
                //tikzDisplay1.SetUnavailable();
                // TODOOOO
                //if (CurFile == Consts.defaultCurFile)
                //    Helper.DeleteTemporaryFiles(Helper.GetTempFileName(), true);
                //else
                //    Helper.DeleteTemporaryFiles(CurFile);
            }
            return true;
        }


        public void Reload()
        {
            if (FilePath != null)
                LoadFile(FilePath);
            Document = new TextDocument("Hallo WElt");
        }

        public override string ToString()
        {
            return DisplayString;

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
            if (ParseTree == null || !ParseTree.MoreChangesToCome)
                Recompile();
            
            //}
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
            //Helper.SetCurrentWorkingDir(Helper.WorkingDirOptions.DirFromFile, cFile);
            //MainWindow.AddStatusLine("Working directory is now: " + Helper.GetCurrentWorkingDir());


            string newcode = File.ReadAllText(cFile);
            bmp = null; //tikzDisplay1.SetUnavailable(); // new file is directly compiled... but set unavailable in case error occurs
            ParseTree = null; //(null, currentBB);
            TikzStyles.Clear(); //ClearStyleLists();
            FilePath = cFile;
            ChangesMade = false;
            //CurFileNeverSaved = false;

            Document = new TextDocument(newcode);
            //Document.Insert(0, newcode);
            ChangesMade = false;  // set here since txtCode sets ChangesMade on Text change

            // start watching for external changes
            fileWatcher.Path = Path.GetDirectoryName(FilePath); // Directory.GetCurrentDirectory();
            fileWatcher.Filter = Path.GetFileName(FilePath); //ShortFileName;
            fileWatcher.EnableRaisingEvents = true;

        }


        public bool SaveCurFile(bool saveas = false)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Tex Files|*.tex" + "|All Files|*.*",
                OverwritePrompt = true,
                ValidateNames = true
            };
            bool isTempFile = false;
            if (CurFileNeverSaved)
                isTempFile = true;
            string OldFileName = FilePath;

            sfd.FileName = System.IO.Path.GetFileName(FilePath);
            //sfd.InitialDirectory = System.IO.Path.GetDirectoryName(CurFile);
            sfd.InitialDirectory = Directory.GetCurrentDirectory();

            bool WeNeedRecompilationAfterSave = false;
            if (CurFileNeverSaved || saveas)
            {
                if (sfd.ShowDialog() != true)
                    return false;
                else FilePath = sfd.FileName; //note temporarily CurFile is absolute.
                WeNeedRecompilationAfterSave = true;
            }

            // turn off listening for changes... we don't want to catch our change
            fileWatcher.EnableRaisingEvents = false;

            StreamWriter wr = new StreamWriter(FilePath);
            wr.Write(Document.Text);
            wr.Close();
            ChangesMade = false;
            //CurFileNeverSaved = false;
            MainWindow.AddStatusLine("File saved to " + FilePath + ".");
            if (OnSaved != null)
                OnSaved(this, new EventArgs());

            //delete old temp data.
            if (saveas)
            {
                //before delete temp data, we have to close the pdf
                bmp = null; // tikzDisplay1.SetUnavailable();

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
                FilePath = System.IO.Path.GetFileName(FilePath);
            }

            // start watching for external changes again
            fileWatcher.Path = Directory.GetCurrentDirectory();
            fileWatcher.Filter = FilePath;
            fileWatcher.EnableRaisingEvents = true;

            if (WeNeedRecompilationAfterSave)
                Recompile();
            return true;
        }

        public bool ProgrammaticTextChange = false;
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

            if (MainWindow.TheVM == null || MainWindow.TheVM.EditorMode == TEMode.Wysiwyg)
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
                        ParseTree = null;
                        AllowEditing = true;
                    }
                }

                //compiling only must be started if there is latex code
                if (Document.Text.Trim() != "")
                    TheCompiler.Instance.AddJobExclusive(Document.Text, path, true, DocumentID);
                else
                    PdfPath = "";
                
            }
            else if (MainWindow.TheVM.EditorMode == TEMode.Preview)
            {
                TheCompiler.Instance.AddJobExclusive(Document.Text, path, false, DocumentID);
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
                MainWindow.AddStatusLine("Please save document first", true);
                return "";
            }

            string s = Helper.GetCurrentWorkingDir();
            string t = Helper.GetPreviewFilename();
            string PreviewPdfFilePath = s + "\\" + FilePath + t + ".pdf";
            string PdfFilePath = s + "\\" + Helper.RemoveFileExtension(FilePath) + ".pdf";

            if (SaveAs == true)
            {
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.Filter = "Pdf Files|*.pdf" +
             "|All Files|*.*";
                sfd.OverwritePrompt = true;
                sfd.ValidateNames = true;

                sfd.FileName = System.IO.Path.GetFileName(FilePath);
                // change file extension to .pdf
                sfd.FileName = Helper.RemoveFileExtension(sfd.FileName) + ".pdf";
                sfd.InitialDirectory = System.IO.Path.GetDirectoryName(FilePath);
                if (sfd.ShowDialog() != true)
                    return "";
                PdfFilePath = sfd.FileName;
            }



            try
            {
                File.Copy(PreviewPdfFilePath, PdfFilePath, true);
            }
            catch (Exception Ex)
            {
                MainWindow.AddStatusLine("Could not save PDF. " + Ex.Message, true);
                return "";
            }

            MainWindow.AddStatusLine("Preview PDF file saved as " + PdfFilePath);
            return PdfFilePath;
        }
        /// <summary>
        /// Displays an Export As dialog and, if successful, exports the current tikzpicture 
        /// as either bmp, jpeg, tiff or png.
        /// </summary>
        void ExportFile()
        {
            if (CurFileNeverSaved)
            {
                MainWindow.AddStatusLine("Please save document first", true);
                return;
            }

            string s = Helper.GetCurrentWorkingDir();
            string t = Helper.GetPreviewFilename();
            string PreviewPdfFilePath = s + "\\" + this.FilePath + t + ".pdf";
            string TheFilePath = Helper.RemoveFileExtension(this.FilePath) + ".pdf";

            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Jpeg Files|*.jpg|Portable Network Graphics|*.png|Bitmap Files|*.bmp|Tiff Files|*.tif|Graphics Interchange Format|*.gif|Extended Meta File|*.emf|Windows Meta File|*.wmf|Html File|*.html|Scalable Vector Graphics|*.svg";
            sfd.FilterIndex = 1;
            sfd.OverwritePrompt = true;
            sfd.ValidateNames = true;
            sfd.AddExtension = true;

            sfd.FileName = System.IO.Path.GetFileName(TheFilePath);
            // change file extension to .pdf
            sfd.FileName = Helper.RemoveFileExtension(sfd.FileName) + ".jpg";
            sfd.InitialDirectory = System.IO.Path.GetDirectoryName(TheFilePath);
            if (sfd.ShowDialog() != true)
                return;
            TheFilePath = sfd.FileName;

            try
            {
                System.Drawing.Imaging.ImageFormat imgFormat;
                bool Transparent = true;
                switch (System.IO.Path.GetExtension(TheFilePath).ToLower())
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
                        ExportCompiler.ExportCompileDialog.Export(Document.Text, TheFilePath);
                        return;
                    default:
                        MainWindow.AddStatusLine("Could not export file: Unknown file extension.", true);
                        return;
                }

                PdfToBmp p2b = new PdfToBmp();
                p2b.LoadPdf(PreviewPdfFilePath);
                p2b.SaveBmp(TheFilePath, Consts.ptspertikzunit, Transparent, imgFormat);
            }
            catch (Exception Ex)
            {
                MainWindow.AddStatusLine("Could not export file. " + Ex.Message, true);
                return;
            }

            MainWindow.AddStatusLine("File exported as " + TheFilePath);
        }

  /*      private string SavePdf(bool SaveAs)
        {
            if (SaveAs == false && CurFileNeverSaved)
            {
                MainWindow.AddStatusLine("Please save document first", true);
                return "";
            }

            string s = Helper.GetCurrentWorkingDir();
            string t = Helper.GetPreviewFilename();
            string PreviewPdfFilePath = System.IO.Path.GetFullPath(CurFile) + t + ".pdf";
            string PdfFilePath = Helper.RemoveFileExtension(System.IO.Path.GetFullPath(CurFile)) + ".pdf";
            //            string PreviewPdfFilePath = s + "\\" + CurFile + t + ".pdf";
            //            string PdfFilePath = s + "\\" + Helper.RemoveFileExtension(CurFile) + ".pdf";

            if (SaveAs == true)
            {
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.Filter = "Pdf Files|*.pdf" +
             "|All Files|*.*";
                sfd.OverwritePrompt = true;
                sfd.ValidateNames = true;

                sfd.FileName = System.IO.Path.GetFileName(CurFile);
                // change file extension to .pdf
                sfd.FileName = Helper.RemoveFileExtension(sfd.FileName) + ".pdf";
                sfd.InitialDirectory = System.IO.Path.GetDirectoryName(CurFile);
                if (sfd.ShowDialog() != true)
                    return "";
                PdfFilePath = sfd.FileName;
            }

            try
            {
                File.Copy(PreviewPdfFilePath, PdfFilePath, true);
            }
            catch (Exception Ex)
            {
                AddStatusLine("Could not save PDF. " + Ex.Message, true);
                return "";
            }

            AddStatusLine("Preview PDF file saved as " + PdfFilePath);
            return PdfFilePath;
        } */

        void fileWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            Dispatcher.Invoke(new Action(delegate()
            {
                // there is a well-known issue with filewatcher raising multiple events... so, as a hack, stop wtaching
                fileWatcher.EnableRaisingEvents = false;
                // the currently watched file was changed -> ask the user to reload
                switch (MessageBox.Show("The currently open file was modified outside the editor.\r\nDo you want to reload the file from disk?",
                    "Modified outside TikzEdt", MessageBoxButton.YesNo, MessageBoxImage.Warning))
                {
                    case MessageBoxResult.Yes:
                        ChangesMade = false;
                        LoadFile(FilePath); // here the filewatcher is turned on again implicitly
                        break;
                    case MessageBoxResult.No:
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

            //check if error occurred
            if (Result.Error != null && Result.Error is RecognitionException)
            {
                RecognitionException ex = Result.Error as RecognitionException;
                string errmsg = ANTLRErrorMsg.ToString(ex, simpletikzParser.tokenNames);
                MainWindow.AddStatusLine("Couldn't parse code. " + errmsg, true);
                if (ex.Line == 0 && ex.CharPositionInLine == -1)
                {
                    addProblemMarker(errmsg, Document.LineCount, 0, Severity.ERROR, ShortFileName);

                }
                else
                {
                    addProblemMarker(errmsg, ex.Line, ex.CharPositionInLine, Severity.ERROR, ShortFileName);
                }
                ParseTree = null;
                TikzStyles.Clear();

            }
            else if (Result.Error != null)
            {
                string errmsg = Result.Error.GetType().ToString();
                if (Result.Error is Exception)
                    errmsg += ":" + ((Exception)Result.Error).Message;
                MainWindow.AddStatusLine("Couldn't parse code. " + errmsg, true);
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
                    MainWindow.AddStatusLine("Couldn't parse included file. " + errmsg, true);
                    if (ex.Line == 0 && ex.CharPositionInLine == -1)
                    {
                        addProblemMarker(errmsg, Document.LineCount, 0, Severity.WARNING, Result.WarningSource);

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
                    MainWindow.AddStatusLine("Couldn't parse included file " + Result.WarningSource + ". " + errmsg, true);
                }
            }

            // Restart parser if necessary
            ParseNeeded = ParseNeeded;
        }

        // this is called upon latex error,... the error is extracted from the latex output in the TexCompiler class
        void addProblemMarker(object sender, TexOutputParser.TexError err, TexCompiler.Job job = null) //String error, int linenr, TexCompiler.Severity severity)
        {
            // if job = null, the error was generated by the parser => always display
            // otherwise display only if the job really was the current document
            if (job == null || job.DocumentID == DocumentID)
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
                                    if (!Result.ParseTree.styles.ContainsKey(style.Key))
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
                Result.WarningSource = ShortFileName;
            }
            finally
            {
                e.Result = Result;
            }
        }

        #endregion

        #region static methods


        #endregion

        #region commands

        //ICommand ReloadCommand = new RelayCommand();

        #endregion

        public static implicit operator TEDocumentContent(TEDocumentVM m)
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

    }

    public class TEDocumentContent : AvalonDock.DocumentContent
    {
        public TEDocumentContent()
        {
            //Content = new TextEditor();
            Title = "Hallo Welt";
        }
    }

}
