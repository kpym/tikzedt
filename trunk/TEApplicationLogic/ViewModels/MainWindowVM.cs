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

namespace TikzEdt.ViewModels
{
    public class MainWindowVM : ViewModelBase
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
        private TEDocumentVM _TheDocument; // = new TEDocumentVM();
        /// <summary>
        /// The currently active document.
        /// </summary>
        public TEDocumentVM TheDocument
        {
            get {return _TheDocument; }
            private set 
            {
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

        double _RasterWidth = 1;
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

        # region Commands and Command Bindings
        public CommandBinding NewCommandBinding
        {
            get { return new CommandBinding(ApplicationCommands.New, NewCommandHandler); }
        }
        public CommandBinding OpenCommandBinding
        {
            get { return new CommandBinding(ApplicationCommands.Open, OpenCommandHandler); }
        }
        public CommandBinding SaveCommandBinding
        {
            get { return new CommandBinding(ApplicationCommands.Save, SaveCommandHandler); }
        }
        public CommandBinding SaveAsCommandBinding
        {
            get { return new CommandBinding(ApplicationCommands.SaveAs, SaveAsCommandHandler); }
        }
        #endregion

        //ObservableCollection<AvalonDock.DocumentContent> _DocumentsAD = new ObservableCollection<AvalonDock.DocumentContent>();
        //[CLSCompliant(false)]
        //public ObservableCollection<AvalonDock.DocumentContent> DocumentsAD { get { return _DocumentsAD; } set { DocumentsAD = value; } }
        //{ get { return Documents.Select<TEDocumentVM, TEDocumentContent>( (s, i) => s.doccontent ); } } 
   //     public AvalonDock.DocumentContent SelectedTab { get; set; }

        public MainWindowVM()
        {
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
            TEDocumentVM doc;
            try
            {
                doc = new TEDocumentVM(this, cFile);
                //doc.OnClose += new EventHandler(doc_OnClose);
               // TEDocumentView view = new TEDocumentView(doc);
                doc.OnSaved += ( (s, e) => GlobalUI.RaiseRecentFileEvent(s, (s as TEDocumentVM).FilePath, true) );
                //Documents.Insert(0, view);
                //ActiveView = view;
                if (cFile != null)
                    GlobalUI.RaiseRecentFileEvent(doc, cFile, true);

                TheDocument = doc;
            }
            catch (Exception ex)
            {
                GlobalUI.ShowMessageBox(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                if (cFile != null)
                    GlobalUI.RaiseRecentFileEvent(this, cFile, false);
            }
        }

        /// <summary>
        /// Tries to create a new file. Is the command parameter is not null, then a new instance of TikzEdt is opened.
        /// If the current file is unsaved, the user has to be asked to save.
        /// </summary>
        private void NewCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Parameter != null)
            {
                // open a new instance (TODO: in the same folder...)
                System.Diagnostics.Process.Start( System.Reflection.Assembly.GetExecutingAssembly().Location );
            }
            else
            {
                if (TheDocument == null || TheDocument.TryDisposeFile())
                {
                    TheDocument = new TEDocumentVM(this);
                    TheDocument.OnSaved += ((s, args) => GlobalUI.RaiseRecentFileEvent(s, (s as TEDocumentVM).FilePath, true));
                }
            }

        }

        /// <summary>
        /// Tries to create a new file. Is the command parameter is true, then a new instance of TikzEdt is opened.
        /// If the current file is unsaved, the user has to be asked to save.
        /// </summary>
        private void OpenCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            string filename;
            if (e.Parameter != null)
            {                
                if (GlobalUI.ShowOpenFileDialog(out filename) == true)
                {
                    // open a new instance
                    System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location, "\""+filename+"\"");
                }
            }
            else
            {
                if (TheDocument == null || TheDocument.TryDisposeFile())
                    if (GlobalUI.ShowOpenFileDialog(out filename) == true)
                       LoadFile(filename);
            }
        }

        private void SaveCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            TheDocument.SaveCurFile();
        }
        private void SaveAsCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            TheDocument.SaveCurFile(true);
        }


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
    }

    public class ViewModelBase : DispatcherObject, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }



    /// <summary>
    /// The mode TE can be operated in
    /// </summary>
    public enum TEMode { Wysiwyg, Preview, Production }
}
