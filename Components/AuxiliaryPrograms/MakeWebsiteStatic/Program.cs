using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;

namespace MakeWebsiteStatic
{
    /// <summary>
    /// Loads a website and stores it as static html files.
    /// </summary>
    class Program
    {
        static string[] files = new string[] { "index", "doc", "down", "quicktour", "usecases", "links", "style.css" };        
        static string baseurl = "http://localhost:8080/website/";        

        static void Main(string[] args)
        {
            string localbasedir = @"C:\Downloads\xampp\htdocs\website\";
            string localbasedirimg = localbasedir+"img\\";
            string targetdir = localbasedir+"static\\";
            string targetimgdir = localbasedir + "static\\img\\";
            string ftpaddress = "willwacher.de";
            string ftpbase = "ftp://willwacher.de/tikzedt/";            
            string username = "willwacher.de";

            if (!Directory.Exists(targetdir))
                Directory.CreateDirectory(targetdir);
            if (!Directory.Exists(targetimgdir))
                Directory.CreateDirectory(targetimgdir);

            WebClient wc = new WebClient();
            WebClient ftpwc = new WebClient();
            foreach (string s in files)
            {
                string src = baseurl + s;
                string tgt = targetdir + s;
                if (!Path.HasExtension(src))
                {
                    src += ".php";
                    tgt += ".html";
                }
                wc.DownloadFile(src, tgt);
                Console.WriteLine("Downloading "+src);

                // replace all references to php files with html files
                string c = File.ReadAllText(tgt);
                c = c.Replace(".php", ".html");
                File.WriteAllText(tgt, c);
            }

            Console.WriteLine("Copying images");
            foreach (string f in Directory.GetFiles(localbasedirimg, "*.png"))
                File.Copy(f, targetimgdir+ Path.GetFileName(f), true);

            Console.WriteLine("Please enter password for "+ username + " at " + ftpaddress);
            string pw = Console.ReadLine();

            ftpwc.Credentials = new NetworkCredential (username,pw);
            foreach (string s in Directory.GetFiles(targetdir))
            {
                Console.WriteLine("Uploading " + s);
                ftpwc.UploadFile(ftpbase + Path.GetFileName(s), s);
            }
            foreach (string s in Directory.GetFiles(targetimgdir))
            {
                Console.WriteLine("Uploading " + s);
                ftpwc.UploadFile(ftpbase +"img/"+ Path.GetFileName(s), s);
            }

            
            Console.WriteLine("Done");
            Console.ReadKey(true);


        }

        
    }
}
