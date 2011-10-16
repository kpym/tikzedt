using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Xml;

namespace TESharedComponents
{
    /// <summary>
    /// This class downloads an XMl file from the web and parses it to 
    /// determine whether there is a new version, and, if so, provides the download link.
    /// 
    /// The format of the xml file is like this:
    /// <?xml version="1.0" encoding="utf-8"?>  
    /// <tikzedt>
    ///   <latestversion>0.1.3</latestversion>  
    ///   <webpageurl>http://code.google.com/p/tikzedt/</webpageurl>
    ///   <dowloadurl>http://tikzedt.googlecode.com/files/TikzEdt0_1_3beta.msi</dowloadurl> 
    /// </tikzedt>
    /// 
    /// 
    /// It (currently) does not automatically download and install the update, although this might be an option for later
    /// </summary>
    public class UpdateChecker
    {
        /// <summary>
        /// This is the URL of the XML file containing the version information.
        /// For file format, see above.
        /// </summary>
        public string VersionInfoURL { get; set; }

        private MyBackgroundWorker worker = new MyBackgroundWorker();

        /// <summary>
        /// Starts checking for updates.         
        /// </summary>
        /// <returns>Returns false if there was an error.</returns>
        public bool CheckForUpdatesAsync()
        {
            if (String.IsNullOrWhiteSpace(VersionInfoURL))
                return false;

            worker.RunWorkerAsync(VersionInfoURL);

            return true;
        }

        public class SuccessEventArgs : EventArgs
        {
            public bool HasNewerVersion;
            public Version LatestVersion;
            public Version CurrentVersion;
            public string DownloadURL;
            public string WebpageURL;
        }
        public class StatusEventArgs : EventArgs
        {
            public string Description;
            public bool HasFailed;
        }
        public event EventHandler<SuccessEventArgs> Success;
        public event EventHandler<StatusEventArgs> Status;        

        public UpdateChecker()
        {
            worker.DoWork += new System.ComponentModel.DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
        }

        void worker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)                       
            {
                if (Status != null)
                    Status(this, new StatusEventArgs() { HasFailed = true, Description="Checking for new version cancelled" });
            }
            else if (e.Error != null)
            {
                if (Status != null)
                    Status(this, new StatusEventArgs() { HasFailed = true, Description = "Checking for new version failed: "+e.Error.Message });
            }
            else if (!(e.Result is SuccessEventArgs))
            {
                if (Status != null)
                    Status(this, new StatusEventArgs() { HasFailed = true, Description = "Checking for new version failed." });
            }
            else
            {
                SuccessEventArgs sea = e.Result as SuccessEventArgs;
                sea.CurrentVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                sea.HasNewerVersion = sea.LatestVersion > sea.CurrentVersion;
                if (Success != null)
                    Success(this, sea);
            }
        }

        void worker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            string url = e.Argument as string;
            SuccessEventArgs result = new SuccessEventArgs();

            MyBackgroundWorker bgw = sender as MyBackgroundWorker;
            bgw.ReportProgress(0, "Checking for new version ...");

            // Download xml file            
            //using (XmlTextReader reader = new XmlTextReader(url))
            using (WebClient wc = new WebClient())
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(wc.DownloadString(url));
                result.LatestVersion = new Version( doc.SelectSingleNode("//latestversion").InnerText );
                result.DownloadURL = doc.SelectSingleNode("//downloadurl").InnerText;
                result.WebpageURL = doc.SelectSingleNode("//webpageurl").InnerText;
            }

            e.Result = result;
            
        }


    }
}
