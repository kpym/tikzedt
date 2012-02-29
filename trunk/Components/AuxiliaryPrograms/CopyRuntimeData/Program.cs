using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Ionic.Zip;

namespace CopyRuntimeData
{
    /// <summary>
    /// This helper program copies the current snippet list and the current thumbnail directory (in zipped form)
    /// to the source folder for deployment.
    /// 
    /// So, after you changed the snippet list in TikzEdt, run this script to integrate the changes into the deployment.
    /// 
    /// Usage: 
    ///    CopyRuntimeData (BaseFolder)
    /// where BaseFolder is the folder where data should be copied to.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Count() != 1)
            {
                Console.WriteLine("Wrong number of arguments");
                Console.ReadKey(true);
                return;
            }
            string tgt = args[0], src;

            try
            {
                src = GetSourceDir();
                Console.WriteLine("Source directory is '" + src + "'.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Couldn't find source directory, "+ex.Message);
                Console.ReadKey(true);
                return;
            }

            // copy snippets file
            string src_snippetsfile = Path.Combine(src, "Editor\\TheSnippets.xml");
            string tgt_snippetsfile = Path.Combine(tgt, "Editor\\TheSnippets.xml");

            try
            {
                string dir = Path.GetDirectoryName(tgt_snippetsfile);
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);
                File.Copy(src_snippetsfile, tgt_snippetsfile, true);
                Console.WriteLine("Copied Snippets file from '" + src_snippetsfile + "' to '" + tgt_snippetsfile + "'.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Could not copy snippets file: " + ex.Message);
            }

            // zip and copy 
            try{

                string src_dir = Path.Combine(src, "img");
                string tgt_zipfile = Path.Combine(tgt, "SnippetThumbs.zip");

                if (File.Exists(tgt_zipfile))
                    File.Delete(tgt_zipfile);
                int count = 0;
                using (var z = new ZipFile())
                {
                    // add all png files
                    var fs = Directory.GetFiles(src_dir, "*.png");
                    count = fs.Count();
                    z.AddFiles( fs, "img");                    
                    z.Save(tgt_zipfile);
                }

                Console.WriteLine("Zipped and copied {0} Snippet thumbnails to " + tgt_zipfile + ".", count);

            } catch (Exception ex)
            {
                Console.WriteLine("Error: Could not copy snippets thumbnails: " + ex.Message);
            }

            Console.WriteLine("Done");
            Console.ReadKey(true);
        }

        /// <summary>
        /// Tries to find the application data directory 
        /// </summary>
        /// <returns></returns>
        private static string GetSourceDir()
        {
            // data for all versions stored here
            string dir = Path.Combine( Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TikzEdt\\TikzEdt");
            
            // find latest version
            var dirs = Directory.GetDirectories(dir);
            return dirs.OrderBy(s => new Version( Path.GetFileName(s) ) ).Last();

        }
    }
}
