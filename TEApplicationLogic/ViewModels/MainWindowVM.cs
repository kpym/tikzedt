using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows;
using Microsoft.Win32;
//using TikzEdt.Views;
using System.Windows.Threading;
using System.IO;
using FileDownloaderApp;
using System.Windows.Forms;

namespace TikzEdt.ViewModels
{
    public class MainWindowVM<T> : ViewModelBase where T : class, ITEDoc, new()
    {
        /*  public ObservableCollection<TEDocumentView> Documents { get; private set; }

          private TEDocumentView _ActiveView = null;
          public TEDocumentView ActiveView
          {
              get { return _ActiveView; }
              set
              {
                  if (_ActiveView != value)
                  {
                      _ActiveView = value;
                      NotifyPropertyChanged("ActiveView");
                      NotifyPropertyChanged("ActiveVM");
                  }
              }
          } */

        #region Properties

        public string DynamicPreamble
        {
            get;
            set;
        }

        private TEDocumentVM<T> _TheDocument; // = new TEDocumentVM();
        /// <summary>
        /// The currently active document.
        /// </summary>
        public TEDocumentVM<T> TheDocument
        {
            get {return _TheDocument; }
            private set 
            {
                if (_TheDocument != null && _TheDocument != value)
                    _TheDocument.Dispose();
                _TheDocument = value;
                NotifyPropertyChanged("TheDocument");
            }
        }

        TEMode _EditorMode = TEMode.Wysiwyg;
        public TEMode EditorMode
        {
            get { return _EditorMode; }
            set
            {
                if (value != _EditorMode)
                {
                    _EditorMode = value;
                    NotifyPropertyChanged("EditorMode");
                }
            }
        }

        bool _ShowOverlay = true;
        /// <summary>
        /// Indicates whether the overlay should be displayed in Wysiwyg mode
        /// </summary>
        public bool ShowOverlay
        {
            get { return _ShowOverlay; }
            set
            {
                if (value != _ShowOverlay)
                {
                    _ShowOverlay = value;
                    NotifyPropertyChanged("ShowOverlay");
                }
            }
        }

        double _RasterWidth = .5;
        public double RasterWidth
        {
            get { return _RasterWidth; }
            set
            {
                if (value != _RasterWidth)
                {
                    _RasterWidth = value;
                    NotifyPropertyChanged("RasterWidth");
                }
            }
        }
        double _RasterRadialOffset = 0;
        public double RasterRadialOffset
        {
            get { return _RasterRadialOffset; }
            set
            {
                if (value != _RasterRadialOffset)
                {
                    _RasterRadialOffset = value;
                    NotifyPropertyChanged("RasterRadialOffset");
                }
            }
        }
        int _RasterSteps = 18;
        public int RasterSteps
        {
            get { return _RasterSteps; }
            set
            {
                if (value != _RasterSteps)
                {
                    _RasterSteps = value;
                    NotifyPropertyChanged("RasterSteps");
                }
            }
        }

        OverlayToolType _CurrentTool = OverlayToolType.move;
        public OverlayToolType CurrentTool
        {
            get { return _CurrentTool; }
            set
            {
                if (value != _CurrentTool)
                {
                    _CurrentTool = value;
                    NotifyPropertyChanged("CurrentTool");
                }
            }
        }

        #endregion

        //ObservableCollection<AvalonDock.DocumentContent> _DocumentsAD = new ObservableCollection<AvalonDock.DocumentContent>();
        //[CLSCompliant(false)]
        //public ObservableCollection<AvalonDock.DocumentContent> DocumentsAD { get { return _DocumentsAD; } set { DocumentsAD = value; } }
        //{ get { return Documents.Select<TEDocumentVM, TEDocumentContent>( (s, i) => s.doccontent ); } } 
   //     public AvalonDock.DocumentContent SelectedTab { get; set; }

        TexCompiler Compiler;

        public MainWindowVM(TexCompiler compiler)
        {
            Compiler = compiler;
            //Documents = new ObservableCollection<TEDocumentView>();
            // create one document to start with
            //AddDocument();

            /*  for (int i = 0; i < 3; i++)
              {
                  AvalonDock.DocumentContent ad = new AvalonDock.DocumentContent() { Title = "Hallo Welt" };
                  ICSharpCode.AvalonEdit.TextEditor aedit = new ICSharpCode.AvalonEdit.TextEditor();
                  //avalonDoc.DataContext = tabViewModel;
                  ad.Content = aedit;
                  //DocumentContents.Insert(0, avalonDoc);
                  //avalonDoc.Focus();

                  DocumentsAD.Add(ad);
              }*/
        }


        /// <summary>
        /// Loads a document from file.
        /// 
        /// </summary>
        /// <param name="cFile"></param>
        public void LoadFile(string cFile = null)
        {
            TEDocumentVM<T> doc;
            try
            {
                doc = new TEDocumentVM<T>(this, Compiler, cFile);
                //doc.OnClose += new EventHandler(doc_OnClose);
               // TEDocumentView view = new TEDocumentView(doc);
                doc.OnSaved += ((s, e) => GlobalUI.UI.RaiseRecentFileEvent(s, (s as TEDocumentVM<T>).FilePath, true));
                //Documents.Insert(0, view);
                //ActiveView = view;
                if (cFile != null)
                    GlobalUI.UI.RaiseRecentFileEvent(doc, cFile, true);

                TheDocument = doc;
            }
            catch (Exception ex)
            {
                GlobalUI.UI.ShowMessageBox(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                if (cFile != null)
                    GlobalUI.UI.RaiseRecentFileEvent(this, cFile, false);
            }
        }
/*
        /// <summary>
        /// Tries to create a new file. Is the command parameter is not null, then a new instance of TikzEdt is opened.
        /// If the current file is unsaved, the user has to be asked to save.
        /// </summary>
        public void NewCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            CreateNewFile(e.Parameter != null);
        } */

        /// <summary>
        /// Tries to cretae a new File.
        /// (If the current file contains changes and the user rejects to discard/save them, no file is created).
        /// </summary>
        /// <param name="InNewInstance">Whether to open a new instance of TikzEdt.</param>
        public void CreateNewFile(bool InNewInstance = false)
        {
            if (InNewInstance)
            {
                // open a new instance (TODO: in the same folder...)
                StartNewTEInstance();
            }
            else
            {
                if (TheDocument == null || TheDocument.TryDisposeFile())
                {
                    TheDocument = new TEDocumentVM<T>(this, Compiler);
                    TheDocument.OnSaved += ((s, args) => GlobalUI.UI.RaiseRecentFileEvent(s, (s as TEDocumentVM<T>).FilePath, true));
                }
            }
        }

        

        /// <summary>
        /// Starts a new instance of TikzEdt
        /// </summary>
        /// <param name="Arguments">The arguments to be passed to TE</param>
        public static void StartNewTEInstance(string Arguments = null)
        {
            string exe_location = System.Reflection.Assembly.GetEntryAssembly().Location;
            try
            {
                if (Arguments != null)
                    System.Diagnostics.Process.Start(exe_location, Arguments);
                else
                    System.Diagnostics.Process.Start(exe_location);
            }
            catch (Exception )
            {
                GlobalUI.UI.ShowMessageBox("Error: Couldn't start new instance of TikzEdt. (exe path read was: " + exe_location + ".", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }


   /*     /// <summary>
        /// Tries to create a new file. Is the command parameter is true, then a new instance of TikzEdt is opened.
        /// If the current file is unsaved, the user has to be asked to save.
        /// </summary>
        private void OpenCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            Open(e.Parameter != null);
        } */

        /// <summary>
        /// Tries to create a new file. Is the command parameter is true, then a new instance of TikzEdt is opened.
        /// If the current file is unsaved, the user has to be asked to save.
        /// </summary>
        public void Open(bool InNewInstance = false)
        {
            string filename;
            if (InNewInstance)
            {
                if (GlobalUI.UI.ShowOpenFileDialog(out filename) == true)
                {
                    // open a new instance
                    StartNewTEInstance("\"" + filename + "\"");
                }
            }
            else
            {
                if (TheDocument == null || TheDocument.TryDisposeFile())
                    if (GlobalUI.UI.ShowOpenFileDialog(out filename) == true)
                        LoadFile(filename);
            }
        }

        public void Save() { TheDocument.SaveCurFile(); }
        public void SaveAs() { TheDocument.SaveCurFile(true); }

        private FileDownloader downloader;
        /// <summary>
        /// Tries to open the pgf manual. If it is not present, downloads it.
        /// </summary>
        public void OpenPgfManual()
        {
            String pgfmanualurl = Consts.PGFManualDownloadPath;

            //open file if it exists and downloader is not busy downloading it (then file is not complete)
            string PgfManualPath = Path.Combine(Helper.GetAppdataPath(), "pgfmanual.pdf");
            if (File.Exists(PgfManualPath)
                && (downloader == null || (downloader != null && !downloader.IsBusy && downloader.CurrentFile.Path == pgfmanualurl)))
                System.Diagnostics.Process.Start(PgfManualPath);
            else
            {
                // Creating a new instance of a FileDownloader
                if (downloader == null)
                {
                    downloader = new FileDownloader();
                    downloader.LocalDirectory = Helper.GetAppdataPath();
                    downloader.FileDownloadStarted += ((s, args) => GlobalUI.UI.AddStatusLine(this,"Download of Tikz/Pgf manual started. Please be patient."));
                    downloader.FileDownloadSucceeded += ((s, args) => GlobalUI.UI.AddStatusLine(this, "Download of Tikz/Pgf manual succeeded."));
                    downloader.FileDownloadFailed += ((s, args) => GlobalUI.UI.AddStatusLine(this, "Download of Tikz/Pgf manual failed.", true));

                }

                //if downloader is downloading file show status.
                if (downloader.IsBusy)
                {
                    String msg = String.Format("Downloaded {0} of {1} ({2}%)",
                           FileDownloader.FormatSizeBinary(downloader.CurrentFileProgress),
                           FileDownloader.FormatSizeBinary(downloader.CurrentFileSize),
                           downloader.CurrentFilePercentage()) + String.Format(" - {0}/s",
                           FileDownloader.FormatSizeBinary(downloader.DownloadSpeed));
                    if (DialogResult.Cancel == GlobalUI.UI.ShowMessageBox(msg + Environment.NewLine + "Press cancel to abort download.", "Download in progress", 
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
                        downloader.Stop();
                }
                //else ask user to download file
                else
                {
                    FileDownloader.FileInfo loadfile = new FileDownloader.FileInfo(pgfmanualurl);

                    String msg = "Tikz/Pgf manual not found. Do you want to download it now?";
                    if (DialogResult.Yes == GlobalUI.UI.ShowMessageBox(msg, "Start download?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        if (!downloader.Files.Contains(loadfile))
                            downloader.Files.Add(loadfile);
                        GlobalUI.UI.AddStatusLine(this, "Starting download of Pgf manual from " + pgfmanualurl + " ...  (F2 for status)");
                        downloader.Start();
                    }
                }
            }
        }

   /*     private void SaveCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            Save();
        }
        private void SaveAsCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            SaveAs();
        }*/


    /*    public void OpenFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
         //   if (ActiveVM != null)
         //       ofd.InitialDirectory = System.IO.Path.GetDirectoryName(ActiveVM.FilePath);
            //ofd.InitialDirectory = Directory.GetCurrentDirectory();
            //ofd.FileName = System.IO.Path.GetFileName(CurFile);
            if (ofd.ShowDialog() == true)
            {
                AddDocument(ofd.FileName);
            }
        }
            */
   /*     void doc_OnClose(object sender, EventArgs e)
        {
            TEDocumentView view = ViewFromVM(sender as TEDocumentVM);
            if (view != null)
            {
                (sender as TEDocumentVM).OnClose -= new EventHandler(doc_OnClose);
                //Documents.Remove(view);
            }
        }*/

   /*     TEDocumentView ViewFromVM(TEDocumentVM vm)
        {
           // return Documents.FirstOrDefault(view => (view.TheVM == vm));
            return null;
        } */

        /// <summary>
        /// Tries to open the help page on the web.
        /// </summary>
        public void ShowHelp()
        {
            // open the help page
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(Consts.HelpUrl));
            }
            catch (Exception)
            {
                GlobalUI.UI.AddStatusLine(this, "Could not open " + Consts.HelpUrl, true);
            }
        }
    }

    /// <summary>
    /// The mode TE can be operated in
    /// </summary>
    public enum TEMode { Wysiwyg, Preview, Production }
}
