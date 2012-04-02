using System;
using System.ComponentModel;
using System.Drawing;
namespace TikzEdt
{
    public interface ITikzDisplayView
    {
        string PdfPath { get; set; }
        int ReloadPdf { get; set; }
        bool RenderTransparent { get; set; }
        double Resolution { get; set; }
    }

    /// <summary>
    /// The control model for the TikzDisplay control.
    /// This contains all control logic, except the UI Framework specific parts.
    /// 
    /// The type parameter T should be set to the Bitmap of the UI framework.
    /// The constructor needs to be fed with a converter from the standard Bitmap type to T.
    /// </summary>
    public class TikzDisplayModel<T> : ViewModels.ViewModelBase where T : class
    {

        #region properties
       

        public ITikzDisplayView View { get; private set; }

        private bool _IsImageVisible = false;
        public bool IsImageVisible
        {
            get { return _IsImageVisible; }
            set
            {
                if (value != _IsImageVisible)
                {
                    _IsImageVisible = value;
                    NotifyPropertyChanged("IsImageVisible");
                }
            }
        }

        private bool _IsUnavailable = true;
        public bool IsUnavailable
        {
            get { return _IsUnavailable; }
            set
            {
                if (value != _IsUnavailable)
                {
                    _IsUnavailable = value;
                    NotifyPropertyChanged("IsUnavailable");
                }
            }
        }

        private T _Bmp;
        public T Bmp
        {
            get { return _Bmp; }
            set
            {
                if (value != _Bmp)
                {
                    _Bmp = value;
                    NotifyPropertyChanged("Bmp");
                }
            }
        }

        #endregion

        Func<Bitmap, T> BmpConverter;
        public TikzDisplayModel(ITikzDisplayView View, Func<Bitmap, T> BmpConverter)
        {
            this.View = View;
            this.BmpConverter = BmpConverter;

            myPdfBmpDoc = new PdfToBmp();
            AsyncBmpGenerator.DoWork += new DoWorkEventHandler(AsyncBmpGenerator_DoWork);
            AsyncBmpGenerator.RunWorkerCompleted += new RunWorkerCompletedEventHandler(AsyncBmpGenerator_RunWorkerCompleted);
        }

        PdfToBmp myPdfBmpDoc;

        BackgroundWorker AsyncBmpGenerator = new BackgroundWorker();
        class AsyncBmpData
        {
            public double Resolution;
            public bool RenderTransparent, Reload;
            public string File;


            public T bmp; // this contains the bmp after return
        }
        private AsyncBmpData _NextBmpJob = null;
        AsyncBmpData NextBmpJob
        {
            get { return _NextBmpJob; }
            set
            {
                _NextBmpJob = value;
                if (_NextBmpJob != null && !AsyncBmpGenerator.IsBusy)
                {
                    AsyncBmpGenerator.RunWorkerAsync(NextBmpJob);
                    _NextBmpJob = null;
                }
            }
        }

        void AsyncBmpGenerator_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            AsyncBmpData data = e.Result as AsyncBmpData;
            // if filename has changed while the bmp was generated-> don't display
            if (data.File == View.PdfPath)
            {
                // if returned bitmap null or error -> set unavailable
                if (e.Error == null && data.bmp != null)
                {
                    Bmp = data.bmp;
                    IsImageVisible = true;
                    IsUnavailable = false;
                }
                else
                {
                    Bmp = null;
                    IsImageVisible = false;
                    IsUnavailable = true;
                }
            }
            // restart compilation if job pending
            NextBmpJob = NextBmpJob;
        }

        void AsyncBmpGenerator_DoWork(object sender, DoWorkEventArgs e)
        {
            AsyncBmpData data = e.Argument as AsyncBmpData;
            if (data.File != null)
            {
                myPdfBmpDoc.LoadPdf(data.File);
            }
            // this is not optimal since the pdf might be changing when called.... pass PdfWrapper instead to remedy....
            //data.bmp = myPdfBmpDoc.GetBitmapSource(data.Resolution, data.RenderTransparent);

            Bitmap _backbuffer = myPdfBmpDoc.GetBitmap(data.Resolution, data.RenderTransparent);
            if (_backbuffer != null)
            {
                T ret = BmpConverter(_backbuffer);
                _backbuffer.Dispose();
                data.bmp = ret;
            }
            else data.bmp = null;

            e.Result = data;
        }

        /// <summary>
        /// This method draws the currently loaded Pdf into a bitmap, and displays this bitmap in the image control.
        /// It is called, e.g., when the size of the TikzDisplay control changes
        /// Warning: It reloads the Pdf only if ReloadFile is set. 
        /// </summary>
        /// <param name="ReloadFile">Reload the pdf file from disk.</param>
        public void RedrawBMP(bool ReloadFile)
        {

            if (myPdfBmpDoc != null)
            {
                AsyncBmpData data = new AsyncBmpData();
                data.Resolution = View.Resolution;
                data.RenderTransparent = View.RenderTransparent;
                data.File = View.PdfPath;
                data.Reload = ReloadFile;

                NextBmpJob = data; // this automatically starts the background worker if no other job is in progress

                return;
            }

        }

        /// <summary>
        /// Updates the control state. Should be called whenever the PdfPath property changes
        /// </summary>
        public void Refresh()
        {
            if (View.PdfPath == "")
            {
                IsUnavailable = true;
                IsImageVisible = false;
                NextBmpJob = null; // if manually set to unavailable-> clear pending bmp jobs
                myPdfBmpDoc.UnloadPdf();
            }
            else
                RedrawBMP(true);
        }

    }
}
