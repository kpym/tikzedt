using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;
using System.ComponentModel;

namespace TESharedComponents
{
    /// <summary>
    /// This is a wrapper around the BackgroundWorker class that allows for 
    /// switching to synchronous execution by setting the static IsSynchronous
    /// switch. This is intended to allow for easy unit testing of asynchronous methods.
    /// </summary>
    public class MyBackgroundWorker
    {
        public static void Invoke(Dispatcher dispatcher, Action action)
        {
            if (IsSynchronous)
                action();
            else
                dispatcher.Invoke(action);
        }

        public static void BeginInvoke(Dispatcher dispatcher, Action action)
        {
            if (IsSynchronous)
                action();
            else
                dispatcher.BeginInvoke(action);
        }

        public static bool IsSynchronous = false;

        public event DoWorkEventHandler DoWork;
        public event RunWorkerCompletedEventHandler RunWorkerCompleted;
        public event ProgressChangedEventHandler ProgressChanged;

        BackgroundWorker bgw = new BackgroundWorker();

        public bool IsBusy { get { return bgw.IsBusy; } }

        public void CancelAsync() { bgw.CancelAsync(); }

        public void RunWorkerAsync()
        {
            RunWorkerAsync(null);
        }
        public void RunWorkerAsync(object argument)
        {
            if (IsSynchronous)
            {
                DoWorkEventArgs e = new DoWorkEventArgs(argument);
                Exception error = null;
                if (DoWork != null)
                {
                    try
                    {
                        DoWork(this, e);
                    }
                    catch (Exception exc)
                    {
                        error = exc;
                    }
                }
                if (RunWorkerCompleted != null)
                    RunWorkerCompleted(this, new RunWorkerCompletedEventArgs(e.Result, error, false));
            }
            else
            {
                bgw.RunWorkerAsync(argument);
            }
        }

        public void ReportProgress(int percentProgress) { bgw.ReportProgress(percentProgress); }
        public void ReportProgress(int percentProgress, object userState) { bgw.ReportProgress(percentProgress, userState); }
        public bool WorkerReportsProgress { get { return bgw.WorkerReportsProgress; } set { bgw.WorkerReportsProgress = value; } }
        public bool WorkerSupportsCancellation { get { return bgw.WorkerSupportsCancellation; } set { bgw.WorkerSupportsCancellation = value; } }

        public MyBackgroundWorker()
        {
            bgw.DoWork += new DoWorkEventHandler(bgw_DoWork);
            bgw.RunWorkerCompleted += bgw_RunWorkerCompleted;
            bgw.ProgressChanged += new ProgressChangedEventHandler(bgw_ProgressChanged);
        }

        void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (ProgressChanged != null)
                ProgressChanged(this, e);
        }

        void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            if (DoWork != null)
                DoWork(this, e);
        }
        void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (RunWorkerCompleted != null)
                RunWorkerCompleted(this, e);
        }

    }
}
