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

namespace TikzEdt.ViewModels
{
    /// <summary>
    /// The viewmodel for a single TikzEdt document.
    /// </summary>
    public class TEDocumentVM : INotifyPropertyChanged
    {
        public string FilePath { get; set; }
        public string ShortFileName { get { return System.IO.Path.GetFileName(FilePath); } }

        public TextDocument Document { get; private set; }
        public Tikz_ParseTree ParseTree { get; private set; }

        /// <summary>
        /// The list of styles parsed from the File.
        /// </summary>
        public ObservableCollection<string> TikzStyles;

        public double Resolution { get; set; }
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
        bool CurFileNeverSaved = false;
        // indicates whether changes (that need to be saved) are made to the current file
        private bool _ChangesMade = false;
        public bool ChangesMade
        {
            get { return _ChangesMade; }
            set
            {
                _ChangesMade = value;
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

        #region private fields
        public FileSystemWatcher fileWatcher = new FileSystemWatcher();
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

        #region methods
        /// <summary>
        /// Loads a file and sets the current directory to its containing folder.
        /// </summary>
        /// <param name="cFile">Specify file to load. This must be a full path (not relative).</param>
        private void LoadFile(string cFile)
        {
            if (!File.Exists(cFile))
            {
                MessageBox.Show("Error: File not found: " + cFile, "File not found", MessageBoxButton.OK, MessageBoxImage.Error);
                //RecentFileList.RemoveFile(cFile);
                return;
            }

            //clean everything before loading file:
            //CleanupForNewFile();

            //set current dir to dir containing cFile.
            Helper.SetCurrentWorkingDir(Helper.WorkingDirOptions.DirFromFile, cFile);
            MainWindow.AddStatusLine("Working directory is now: " + Helper.GetCurrentWorkingDir());

            StreamReader stream = new StreamReader(cFile);
            try
            {
                string newcode = stream.ReadToEnd();
                bmp = null; //tikzDisplay1.SetUnavailable(); // new file is directly compiled... but set unavailable in case error occurs
                ParseTree = null; //(null, currentBB);
                TikzStyles.Clear(); //ClearStyleLists();
                FilePath = System.IO.Path.GetFileName(cFile); //always working in current dir, no need for absolute path.
                ChangesMade = false;
                CurFileNeverSaved = false;

                Document = new TextDocument(newcode);
                ChangesMade = false;  // set here since txtCode sets ChangesMade on Text change

                // start watching for external changes
                fileWatcher.Path = Path.GetDirectoryName(FilePath); // Directory.GetCurrentDirectory();
                fileWatcher.Filter = ShortFileName;
                fileWatcher.EnableRaisingEvents = true;
            }
            catch (Exception Ex)
            {
                string d = Ex.Message;
                MessageBox.Show("Error: Could not load " + cFile + ". Is it in the correct format?",
                    "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                stream.Close();
            }

            //ShowFilesOfCurrentDirectory();

        }


        bool SaveCurFile(bool saveas = false)
        {
            SaveFileDialog sfd = new SaveFileDialog();
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
            CurFileNeverSaved = false;
            MainWindow.AddStatusLine("File saved to " + FilePath + ".");

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

        void Recompile()
        {

        }

        private string SavePdf(bool SaveAs)
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
        void ExportFileHandler(object sender, ExecutedRoutedEventArgs e)
        {
            if (CurFileNeverSaved)
            {
                MainWindow.AddStatusLine("Please save document first", true);
                return;
            }

            string s = Helper.GetCurrentWorkingDir();
            string t = Helper.GetPreviewFilename();
            string PreviewPdfFilePath = s + "\\" + this.FilePath + t + ".pdf";
            string TheFilePath = s + "\\" + Helper.RemoveFileExtension(this.FilePath) + ".pdf";

            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Jpeg Files|*.jpg|Portable Network Graphics|*.png|Bitmap Files|*.bmp|Tiff Files|*.tif|Graphics Interchange Format|*.gif|Extended Meta File|*.emf|Windows Meta File|*.wmf";
            sfd.OverwritePrompt = true;
            sfd.ValidateNames = true;

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

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

    }
}
