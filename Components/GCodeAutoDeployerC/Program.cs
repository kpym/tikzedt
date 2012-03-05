using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using Ionic.Zip;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace GCodeAutoDeployerC
{
    class Program
    {
        [STAThread] 
        static void Main(string[] args)
        {
            string configfile = "autodeploy.xml";
            if (args != null && args.Count() > 0)
                configfile = args[0];

            Console.WriteLine("This is the Google Code Auto Deployer. \r\nConfig data read from file '"+configfile+"'.");

            // write a dummy file (for the lazy me)
            if (!File.Exists(configfile))
            {
                WriteDummyFile(configfile);
                WriteLineAndWait("");
                return;
            }

            // read settings
            ConfigData cf;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ConfigData));
                using (TextReader tr = new StreamReader(configfile))
                {
                    cf = serializer.Deserialize(tr) as ConfigData;
                }
            }
            catch (Exception ex)
            {
                WriteLineAndWait("Error, couldn't read config file: " + ex.Message);
                return;
            }

            if (cf == null)
            {
                WriteLineAndWait("Error, couldn't read config file.");
                return;
            }

            // find the installer file 
            string msi;
            try
            {
                msi = Directory.GetFiles(cf.InstallerDir, cf.InstallerPrefix + "*.msi").First();
            }
            catch (Exception)
            {
                WriteLineAndWait("Error: Installer file (.msi) not found.");
                return;
            }
            Console.WriteLine("Detected installer file is '"+msi+"'.");

            Version v = GetVersion(msi);
            Console.WriteLine("Detected version is '" + v.ToString() + "'.");

            string FolderInZipFile = Path.GetFileNameWithoutExtension(msi);
            string zipfile = FolderInZipFile + ".zip";

            // create the zip file
            Console.WriteLine("Creating Zip file: '" + zipfile + "' from folder '" + cf.RawFilesDir + "'...");
            if (File.Exists(zipfile))
                File.Delete(zipfile);

            using (ZipFile zf = new ZipFile())
            {
                zf.AddDirectory(cf.RawFilesDir, FolderInZipFile);
                zf.Save(zipfile);
            }
            Console.WriteLine("Done");
            Console.WriteLine();

            Console.WriteLine("Google code project: '"+cf.InstallerPrefix+"'.");
            Console.WriteLine("Filename (installer): " + Path.GetFileName(msi));
            Console.WriteLine("Summary (installer): " + cf.SummaryInstaller);
            Console.WriteLine("Labels (installer): " + String.Join(", ", cf.LabelsInstaller) + ".");
            Console.WriteLine("Filename (zip): " + zipfile);
            Console.WriteLine("Summary (zip): " + cf.SummaryZip);
            Console.WriteLine("Labels (zip): " + String.Join(", ", cf.LabelsZip) + ".");
            Console.WriteLine();

            Console.WriteLine("Enter password to proceed, or leave blank to use from clipboard, or 'x' to exit.");
            string pwd = Console.ReadLine();

            if (pwd == "x")
            {
                return;
            }
            else if (String.IsNullOrEmpty(pwd))
            {
                pwd = Clipboard.GetText();
            }

            Console.WriteLine("Uploading files to google code....");
            string up_script = "googlecode_upload.py";
            string parameters = "-p " + cf.ProjectName + " -u " + cf.UserName + " -w " + pwd + " -s \"" + cf.SummaryInstaller + "\"";
            if (cf.LabelsInstaller != null && cf.LabelsInstaller.Count() > 0)
                parameters += " -l \"" + String.Join(", ", cf.LabelsInstaller) + "\"";
            parameters += " \"" + msi +"\"";
            //Console.WriteLine(up_script + " " + parameters);

            RunProc(up_script, parameters);

            parameters = "-p " + cf.ProjectName + " -u " + cf.UserName + " -w " + pwd + " -s \"" + cf.SummaryZip + "\"";
            if (cf.LabelsZip != null && cf.LabelsZip.Count() > 0)
                parameters += " -l \"" + String.Join(", ", cf.LabelsZip) + "\"";
            parameters += " \"" + zipfile + "\"";
            //Console.WriteLine(up_script + " " + parameters);

            RunProc(up_script, parameters);

            Console.WriteLine("");
            Console.WriteLine("Creating version info file: '"+cf.VersionXML+"' ...");
            CreateVersionInfoFile(cf.VersionXML, cf.VersionXMLTemplate, msi, zipfile, v);

            WriteLineAndWait("Done.");

        }

        private static void WriteLineAndWait(string msg)
        {
            Console.WriteLine(msg);
            Console.WriteLine("(Press any key to continue)");
            Console.ReadKey(true);
        }



        private static void WriteDummyFile(string FileName)
        {
            Console.WriteLine("Writing dummy config file to " + FileName + ".");
            ConfigData cf = new ConfigData();
            XmlSerializer serializer = new XmlSerializer(typeof(ConfigData));
            try
            {
                using (TextWriter tw = new StreamWriter(FileName))
                {
                    serializer.Serialize(tw, cf);
                }
                Console.WriteLine("Done");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }

        /// <summary>
        /// In the version info file template, VVVVV is replaced by the version and FFFFF is replaced by the 
        /// </summary>
        /// <param name="target"></param>
        /// <param name="template"></param>
        static void CreateVersionInfoFile(string target, string template, string msi, string zipfile, Version v)
        {
            if (File.Exists(template))
            {
                string tpl = File.ReadAllText(template);
                tpl = tpl.Replace("VVVVV", v.ToString());
                tpl = tpl.Replace("FFFFF", Path.GetFileName(msi));
                tpl = tpl.Replace("ZZZZZ", Path.GetFileName(zipfile));

                File.WriteAllText(target, tpl);
            }
        }


        static Version GetVersion(string msi)
        {
            // extract version from msi name... we suppose msi name ends with combinations of _ and digits
            string msiname = Path.GetFileNameWithoutExtension(msi);

            var vv = msiname.Reverse()
                            .TakeWhile(c => Char.IsDigit(c) || c == '_')
                            .Reverse()
                            .SkipWhile(c => c == '_')
                            .Select(c => c.ToString())
                            .ToArray();
            string sv = String.Join("", vv);
            return new Version(sv.Replace('_', '.'));
        }


        /// <summary>
        /// Runs the python file and displays its output.
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="Params"></param>
        /// <returns></returns>
        static void RunProc(string FileName, string Params)
        {
            string python = Win32API.FindExecutable(FileName);

            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = python;
            start.Arguments = FileName + " " +Params;
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;

            Console.WriteLine("Running " + FileName + " " + Params);

            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.Write(result);
                }
            }            
        }


    }





    [Serializable()]
    public class ConfigData
    {
        public string SummaryInstaller = "This is the installer.";
        public string[] LabelsInstaller = new string[] { "Carrots" };
        public string[] LabelsZip = new string[] {"Carrots"};
        public string UserName = "johndoe";
        public string SummaryZip = "This is the zip.";
        public string InstallerDir = ".";
        public string InstallerPrefix = "myprog";
        public string RawFilesDir = "Rawdir";
        public string ProjectName = "myprog";
        public string VersionXML = "version.xml";
        public string VersionXMLTemplate = "tpl_version.xml";
    }


    public class Win32API
    {
        [DllImport("shell32.dll", EntryPoint = "FindExecutable")]
        public static extern long FindExecutableA(
          string lpFile, string lpDirectory, StringBuilder lpResult);

        public static string FindExecutable(
          string pv_strFilename)
        {
            StringBuilder objResultBuffer =
              new StringBuilder(1024);
            long lngResult = 0;

            lngResult =
              FindExecutableA(pv_strFilename,
                string.Empty, objResultBuffer);

            if (lngResult >= 32)
            {
                return objResultBuffer.ToString();
            }

            return string.Format(
              "Error: ({0})", lngResult);
        }
    }


}
