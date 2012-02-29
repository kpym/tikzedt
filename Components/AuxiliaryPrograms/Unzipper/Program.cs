using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ionic.Zip;

namespace Unzipper
{
    /// <summary>
    /// Unzips the provided snippet thumbnails file to the target directory
    /// 
    /// Usage:
    ///   Unzipper (zipfile) (targetdirectory)
    /// </summary>
    class Program
    {

        static int Main(string[] args)
        {
            if (args.Count() != 2)
            {
                Console.WriteLine("Wrong number of arguments.");
                return -1;
            }

            string zipfile = args[0], tgt = args[1];

            try
            {
                Console.WriteLine("Unzipping...");
                using (var z = ZipFile.Read(zipfile))
                {
                    z.ExtractAll(tgt, ExtractExistingFileAction.OverwriteSilently);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Couldn't unzip: "+ex.Message);
                return -1;
            }

            Console.WriteLine("Done");
            

            //Console.ReadKey(true);
            return 0;
        }
    }
}
