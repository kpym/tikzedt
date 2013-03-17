/*This file is part of TikzEdt.
  
TikzEdt is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.
 
TikzEdt is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
GNU General Public License for more details.
 
You should have received a copy of the GNU General Public License
along with TikzEdt.  If not, see <http://www.gnu.org/licenses/>.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Diagnostics;
using System.IO;
using System.Windows.Threading;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security;
using Microsoft.Win32;
using System.Globalization;
using System.ComponentModel;
using System.Diagnostics.Contracts;

//using System.Drawing;

namespace TikzEdt
{
    /// <summary>
    /// Please put all global constants that are not in the Properties.Settings into this static class.
    /// </summary>
    public static class Consts
    {
        public const double cmperin = 2.54;
        public const double ptspertikzunit = 28.45;//72.0 / cmperin; // 28.3464567
        public const double cmperem = 10 / Consts.ptspertikzunit;   // this is a hack
        public const double cmperex = 4.3 / Consts.ptspertikzunit;  // this too
        public const double TikzDefaultLinewidth = 0;
        public const string TikzDefaultFont = "Times";
        public const double TikzDefaultFontSize = 8;
        public const int TikzImgResolution = 300; // resolution in dpi with which images are compiled

        //these files will be deleted, when file is closed. (by DeleteTemporaryFiles())
        public static string[] TemporaryFileExt = new string[] { ".aux", ".tmp", ".log", ".svn", ".toc", ".out" };
        public static string[] PreviewFileExt = new string[] { ".tex", ".pdf", ".aux", ".tmp", ".log", "_BB.txt", ".svn", ".toc", ".out", ".pdf.png" };

        //public static string[] TikzArrowTipCodes = new string[] { "", ">", "<" };
        //public static DashStyle[] TikzToSystemDashStyle = new DashStyle[] { DashStyle.Solid, DashStyle.Dot, DashStyle.Dash };
        //public static float[][] TikzToSystemDashPattern = new float[][] {
        //    new float[]{0.1F}, new float[]{.1F,.1F}, new float[]{.2F,.1F}
        //};
        public const string StdFileDialogFilter = "Tex Files|*.tex|Tikz files|*.tikz|All Files|*.*";
        public const string cSettingsDir = "Editor"; //this path is relative for GettAppdataPath().
        public const string cCompletionsFile = "CodeCompletions.xml";
        public const string cSettingsFile = "T2Gsettings.xml";
        public const string cSyntaxFile = "TikzSyntax.xshd";
        public const string cSnippetsFile = "TheSnippets.xml";
        public const string cDynPreamblesFile = "DynPreambles.xml";
        public const string cSnippetThumbsDir = "img";
        public const string PrecompiledHeaderFilename = "temp_header.tex";
        
        /// <summary>
        /// The file extension to be added to snippet samples before compilation.
        /// </summary>
        public const string SnippetsExtension = ".tex";

        public const string PreviewFilename = ".preview";
        public const string PreviewFilenameExt = ".tex";
        

        //public const string cMRUFile = "T2GMRU.xml";    // not used
        //public const int MaxMRU = 10;// not used
       // public const string cStyleRepoFile = "StyleRepo.dat";

        //public const string CoordinateVertexStyleName = "helper";

        public const string DoubleFormat = "#.####";

        public const float selecttoler = .01F;
        public const float drawXsize = .1F; // drawn for invisible vertices
        public const float coordvertexsize = .25F; // size of size zero vertex (to ease selection)

        //const string cLatex = "Pdflatex";
        //string cLatexPath = "pdflatex"; //@"C:\Program Files\MiKTeX 2.8\miktex\bin\pdfplatex.exe";
        public const string cTempFile = "TE_temp_preview";         // for preview
        public const string cTempExportFile = "TE_export";         // for export
        public const string cTempImgFile = "temp_previewtexts"; // for equation rendering
        public const string defaultCurFile = "New Tikzfile";
        public const string PreviewHeader =
        @"\documentclass[tight]{article}
\usepackage{tikz,amsmath, amssymb,bm,color}
\usepackage[margin=0cm,nohead]{geometry}
\usepackage[active,tightpage]{preview}
\usetikzlibrary{shapes,arrows}
";

        public const string ImgHeader =
        @"\documentclass[fleqn]{article}
\usepackage{amsmath, amssymb,bm,color}
";

        public const string VersionInfoURL = @"https://tikzedt.googlecode.com/svn/trunk/VersionInfo.xml"; // for wpf version
        public const string WFormsVersionInfoURL = @"https://tikzedt.googlecode.com/svn/trunk/WFormsVersionInfo.xml"; // for Linux (winforms) version

        /// <summary>
        /// The starting code for a new File 
        /// </summary>
        public const string DefaultTikzCode =
@"\begin{tikzpicture}

\end{tikzpicture}";
        /// <summary>
        ///  The tikz code that is inserted before \end{tikzpicture}.
        ///  It writes the bounding box to the auxiliary file ..._BB.txt.
        ///  The "unnecessary" invisible node at the beginning is inserted since for some strange reason
        ///  Tikz outputs a very large bounding box if the tikzpicture is empty.  
        /// </summary> 
        public const string CodeToWriteBB =
@"
\usetikzlibrary{calc}
\pgftransformreset
\node[inner sep=0pt,outer sep=0pt,minimum size=0pt,line width=0pt,text width=0pt,text height=0pt] at (current bounding box) {};
%add border to avoid cropping by pdflibnet
\foreach \border in {0.1}
  \useasboundingbox (current bounding box.south west)+(-\border,-\border) rectangle (current bounding box.north east)+(\border,\border);
\newwrite\metadatafile
\immediate\openout\metadatafile=\jobname_BB.txt
\path
  let
    \p1=(current bounding box.south west),
    \p2=(current bounding box.north east)
  in
  node[inner sep=0pt,outer sep=0pt,minimum size=0pt,line width=0pt,text width=0pt,text height=0pt,draw=white] at (current bounding box) {
\immediate\write\metadatafile{\p1,\p2}
};
\immediate\closeout\metadatafile
";

        //public const string precompilation_args = "-ini -job-name=\"" + cTempFile + "\" \"&pdflatex " + cTempFile + "pre.tex\\dump\"";
        //public const string precompilation_args_img = "-ini -job-name=\"" + cTempImgFile + "\" \"&latex " + cTempImgFile + "pre.tex\\dump\"";

        //Todo: the following creates a problem on first load
  //      public static string AppDataPath { get { return  System.Windows.Forms.Application.UserAppDataPath; } } 
        public static string SyntaxFileFullPath { get { return Path.Combine( Helper.GetAppdataPath() , Consts.cSettingsDir , Consts.cSyntaxFile); } }
        public static string CompletionsFileFullPath { get { return Path.Combine(Helper.GetAppdataPath() , Consts.cSettingsDir , Consts.cCompletionsFile); } }
        public static string DynPreamblesFileFullPath { get { return Path.Combine(Helper.GetAppdataPath() , Consts.cSettingsDir , Consts.cDynPreamblesFile); } }
        public static string MRUFileFullPath { get { return Path.Combine(Helper.GetAppdataPath(), "RecentFiles.txt"); } }

        // TE preprocessor commands
        public const string PreProc_Comment = "%!TE%";
        public static string PreProc_CompilerOptions = "%!TEO";
        public static string PreProc_Include = "%!TEI";
        public static string PGFManualDownloadPath = @"http://www.ctan.org/tex-archive/graphics/pgf/base/doc/generic/pgf/pgfmanual.pdf";
        public static string cSnippetThumbsZipfile = "SnippetThumbs.zip";
        public static string cUnzipper = "Unzipper.exe";
        public static string cXSHDEditor = "XSHDEditor.exe";
        public static string HelpUrl = @"http://www.tikzedt.org/doc.html";
        public static string QuickTourUrl = @"http://www.tikzedt.org/quicktour.html";     
		
		public static string Mudraw {
			get
			{
				if (Helper.IsLinux())
					return "pdfdraw";
				else 
					return "mudraw.exe";
			}
		}
				
    }

    /// <summary>
    /// This purely static class is host to functions of global interest (or those which have no home elsewhere).
    /// </summary>
    public static class Helper
    {
        [Pure]
		public static bool IsLinux()
		{
			return Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX ;
		}
		
        /// <summary>
        /// This function takes a string and removes all trailing and leading and all multiple whitespace.
        /// E.g. "  brown    fox  " -> "brown fox"
        /// </summary>
        /// <param name="inputString">the string</param>
        /// <returns>the same string, with the whitespace removed</returns>
        [System.Diagnostics.Contracts.Pure]
        public static string RemoveMultipleWhitespace(string inputString)
        {
            if (inputString == null)
                return null;
            string[] parts = inputString.Trim().Split(new char[] { ' ', '\n', '\t', '\r', '\f', '\v' }, 
                StringSplitOptions.RemoveEmptyEntries);
            return String.Join(" ", parts);
        }
        /// <summary>
        /// Options set current working directory can be set to.        
        /// </summary>
        public enum WorkingDirOptions { DirFromFile, TempDir };
        /// <summary>
        /// Set the current working directory. 
        /// </summary>
        /// <param name="option">Option to set work dir to.</param>
        /// <param name="file">If WorkingDirOptions.DirFromFile, specify file that shall be in the working dir afterwards.</param>
        public static void SetCurrentWorkingDir(WorkingDirOptions option, string file = "")
        {
            Contract.Requires(option == WorkingDirOptions.TempDir || (file != null && file != "")); 

            if(option==WorkingDirOptions.TempDir)
                Environment.CurrentDirectory = System.IO.Path.GetTempPath();
            else if (option == WorkingDirOptions.DirFromFile)
            {
                if (file == "")
                    throw new Exception("Parameter file in SetCurrentWorkingDir() must not be empty when option==WorkingDirOptions.DirFromFile!");

                String dir = System.IO.Path.GetDirectoryName(file);
                if (dir == "")
                    throw new Exception("Parameter file in SetCurrentWorkingDir() must contain the full path!");
                else
                    Environment.CurrentDirectory = dir;
            }
        }

        [Pure]
        public static string GetCurrentWorkingDir()
        {
            return Environment.CurrentDirectory;
        }

        /*public static string GetLayoutConfigFilepath()
        {
            return Path.Combine ( GetAppdataPath() , "TikzEdtLayout.xml");
        }*/

        public enum AppdataPathOptions { AppData, ExeDir };
        private static string _AppdataPath = System.Windows.Forms.Application.UserAppDataPath;

        /// <summary>
        /// The application data may either be stored in the system's appdata folder, or in the program folder (portable version).
        /// This method must be called on startup to set the folder.
        /// </summary>
        /// <param name="option"></param>
        public static void SetAppdataPath(AppdataPathOptions option)
        {
            if (option == AppdataPathOptions.AppData)
                _AppdataPath = System.Windows.Forms.Application.UserAppDataPath; 
            else
                _AppdataPath = GetAppDir();
        }

        /// <summary>
        /// Returns the path where the application data (snippets, settings, MRU etc.) are stored
        /// </summary>
        /// <returns></returns>
        [Pure]
        public static string GetAppdataPath()
        {
            if (String.IsNullOrWhiteSpace(_AppdataPath))
            {
                return System.Windows.Forms.Application.UserAppDataPath;
            }
            return _AppdataPath;
        }

       /* public static bool IsAppDirWritable()
        {           
            return HasWritePermissionOnDir(GetAppDir());
        } 

        public static bool HasWritePermissionOnDir(string path)
        {
            //**** This is still not  working well on my machine *******

            // stupid method: try to write to a file 
            string cFile = System.IO.Path.Combine(path, "TikzEdt_temp_todelete" + ".txt"); // DateTime.Now.Ticks.ToString()+
            //string cFile2 = System.IO.Path.Combine(path, "TikzEdt_temp_todelete" + ".txt"); // DateTime.Now.Ticks.ToString()+
            StreamWriter sw = null;
            StreamReader sr = null;
            string secret = DateTime.Now.Ticks.ToString();
            try
            {
                sw = new StreamWriter(cFile);
                sw.WriteLine(secret);
                sw.Close();

                sr = new StreamReader(cFile);
                string s = sr.ReadLine();
                sr.Close();
                
                //MainWindow.AddStatusLine("Testen " + cFile);
                File.Delete(cFile);

                if (secret == s)
                    return true;                
            }
            catch (Exception)
            {

            }
            finally
            {
                if (sw != null)
                    sw.Close();
                if (sr != null)
                    sr.Close();
            }
            return false;

            // this doesn't seem to work on my machine

        } */

        
        /// <summary>
        /// Returns the directory of the executable
        /// </summary>
        /// <returns></returns>
        [Pure]
        public static string GetAppDir() // w/o trailing backslash 
        {
            return System.AppDomain.CurrentDomain.BaseDirectory;
        }

        /// <summary>
        /// Path where is configuration files are stored (usually \\Editor)
        /// </summary>
        /// <returns></returns>
        [Pure]
        public static string GetSettingsPath()
        {
            return Path.Combine( GetAppdataPath() , Consts.cSettingsDir) + Path.DirectorySeparatorChar;
        }
        /// <summary>
        /// Path where the snippet thumbnails are stored (usually \\img)
        /// </summary>
        /// <returns></returns>
        [Pure]
        public static string GetSnippetsPath()
        {
            return Path.Combine( GetAppdataPath() , Consts.cSnippetThumbsDir)  + Path.DirectorySeparatorChar;
        }

      /*  /// <summary>
        /// This is where the precompiled header file (.fmt) is created.
        /// </summary>
        /// <returns></returns>
        [Pure]
        public static string GetPrecompiledHeaderPath()
        {
            string s = GetAppdataPath();
            if (s.EndsWith(Path.DirectorySeparatorChar.ToString()))
                return s;
            else
                return s + Path.DirectorySeparatorChar;
        }*/
        
        /// <summary>
        /// The location of the precompiled header file.
        /// </summary>
        /// <returns></returns>
        [Pure]
        public static string GetPrecompiledHeaderFMTFilePath()
        {
            return Path.Combine(GetAppdataPath(), System.IO.Path.GetFileNameWithoutExtension(Consts.PrecompiledHeaderFilename) + ".fmt");
        }

        /// <summary>
        /// The location of the precompiled header source file.
        /// </summary>
        /// <returns></returns>
        [Pure]
        public static string GetPrecompiledHeaderTexFilePath()
        {
            return Path.Combine(GetAppdataPath(), Consts.PrecompiledHeaderFilename);
        }

        /// <summary>
        /// Returns the shortened precompiled header name without extension.
        /// 
        /// </summary>
        /// <returns>The full path to the precompiled header file, in DOS format, without extension.</returns>
        [Pure]
        public static string GetPrecompiledHeaderShortFilePath()
        {
            string path = GetPrecompiledHeaderFMTFilePath();
            path = LongPathToShort(path);
            path = RemoveFileExtension(path);
            return path;
        }

        [Pure]
        public static string GetTempFileName()
        {
            Contract.Ensures( Contract.Result<string>() != null && Contract.Result<string>() != "");
            return Consts.cTempFile + Process.GetCurrentProcess().Id;
        }

        [Pure]
        public static string RemoveFileExtension(string file)
        {
            if (file == null)
                return null;
            string ext = System.IO.Path.GetExtension(file);
            return file.Remove(file.Length - ext.Length, ext.Length);
        }

        /// <summary>
        /// Delete all temporary files named FileName in working dir,
        /// </summary>
        /// <param name="FileName"></param>
        public static void DeleteTemporaryFiles(string FileName, bool IsTempFile = false)
        {
           // return;

            List<String> FilesToDelete = new List<string>();
            if (IsTempFile)
            {
                //if this is a temp file delete all files created by preview (incl. .tex and .pdf)
                foreach (string ext in Consts.PreviewFileExt)
                    FilesToDelete.Add(RemoveFileExtension(FileName) + ext);
            }
            else
            {
                //this is not a temp file so only delete tempary files (filename + log,aux, ...)
                foreach (string ext in Consts.TemporaryFileExt)
                    FilesToDelete.Add(RemoveFileExtension(FileName) + ext);
                //delete all preview files.
                foreach (string ext in Consts.PreviewFileExt)
                    FilesToDelete.Add(FileName + Consts.PreviewFilename + ext);
            }

            foreach (String file in FilesToDelete)
            {
                try
                {
                    System.IO.File.Delete(file);
                }
                catch (IOException)
                { 
                    //PDF file is still loading and cannot be deleted.
                }
            }
        }

      
        /// <summary>
        /// Finds the point in (angle + 2 Pi \Z) closest to (closeto)
        /// </summary>
        /// <param name="angle"></param>
        /// <param name="closeto"></param>
        /// <returns></returns>
        [Pure]
        public static double ClosestPt(double angle, double closeto)
        {
            double diff = angle - closeto;
            return angle - Math.Round(diff / (2 * Math.PI)) * 2 * Math.PI;
        }
        [Pure]
        public static double ClosestPtDeg(double angle, double closeto)
        {
            double diff = angle - closeto;
            return angle - Math.Round(diff / (360)) * 360;
        }

        /// <summary>
        /// Count occurrences of strings.
        /// </summary>
        [Pure]
        public static int CountStringOccurrences(string text, string pattern)
        {
            // Loop through all instances of the string 'text'.
            int count = 0;
            int i = 0;
            while ((i = text.IndexOf(pattern, i)) != -1)
            {
                i += pattern.Length;
                count++;
            }
            return count;
        }

        [Pure]
        public static double RotationFromMatrix(Parser.TikzMatrix M)
        {
            return Math.Atan2(M.m[1, 0], M.m[0, 0]);
        }

        /* */
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetShortPathName(
            [MarshalAs(UnmanagedType.LPTStr)]
        string path,
            [MarshalAs(UnmanagedType.LPTStr)]
        StringBuilder shortPath,
            int shortPathLength
            );

        /// <summary>
        /// Converts a long path to a DOS short path.
        /// </summary>
        /// <param name="LongPath"></param>
        /// <returns></returns>
        public static string LongPathToShort(string LongPath)
        {
            if (Helper.IsLinux())
                return LongPath;
            else
            {
                StringBuilder shortPath = new StringBuilder(255);
                GetShortPathName(LongPath, shortPath, shortPath.Capacity);
                return shortPath.ToString();
            }
        }


        /// <summary>
        /// Merges the two styles. If some style contains an arrow (i.e., contains -), the 
        /// arrow head/tail are copied together.
        /// For instance, -> + >- = >->
        /// (the way it is implemented is a bit of a hack)
        /// </summary>
        /// <param name="s1">The first style</param>
        /// <param name="s2">The second style</param>
        /// <returns>The merged style.</returns>
        [Pure]
        public static string MergeStyles(string s1, string s2)
        {

            List<string> sl1 = new List<string>(s1.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries));
            List<string> sl2 = new List<string>(s2.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries));

            foreach (string s in sl2)
            {
                if (s.Contains("-"))
                {
                    string[] ar2 = s.Split('-');
                    if (ar2.Length == 2)
                    {
                        // arrow style,... check if other arrow style exists
                        int ind = sl1.FindIndex(v => v.Contains("-"));
                        if (ind >= 0)
                        {
                            string[] ar1 = sl1[ind].Split('-');
                            if (ar1.Length == 2)
                            {
                                if (ar1[0].Trim() == "" && ar2[1].Trim() == "")
                                {
                                    sl1[ind] = ar2[0] + "-" + ar1[1];
                                    continue;
                                }
                                else if (ar1[1].Trim() == "" && ar2[0].Trim() == "")
                                {
                                    sl1[ind] = ar1[0] + "-" + ar2[1];
                                    continue;
                                }
                            }
                        }
                    }
                }

                if (!sl1.Contains(s))
                    sl1.Add(s);

            }

            return String.Join(", ", sl1);
        }

    }
     

    /// <summary>
    /// The settings service.
    /// Since we are in an assembly different from the main one, we cannot directly access the application settings (w/o doing a hack at least).
    /// To circumvent, all settings access is channeled through this class.
    /// 
    /// In the main application, the Instance variable is overridden with a subclass instance that accesses Properties.Settings
    /// </summary>
    public class CompilerSettings
    {
        /// <summary>
        /// This field holds the global compiler settings service.
        /// It must be set on application init, before the compiler is used.
        /// </summary>
        public static CompilerSettings Instance {get; set;}

        static CompilerSettings()
        {
             Instance = new CompilerSettings();
        }

        public virtual double BB_Std_X { get { return -5; } }
        public virtual double BB_Std_Y { get { return -5; } }
        public virtual double BB_Std_W { get { return 10; } }
        public virtual double BB_Std_H { get { return 10; } }
        public virtual double BB_Margin { get { return 6; } }
        public virtual string Tex_Preamble { get { return @"\documentclass{article}
\usepackage{tikz,amsmath, amssymb,bm,color}
\usepackage[margin=0cm,nohead]{geometry}
\usepackage[active,tightpage]{preview}
\usetikzlibrary{shapes,arrows}
% needed for BB
\usetikzlibrary{calc}

\PreviewEnvironment{tikzpicture}
";
        }
            set { }
        }

        public virtual string Tex_Postamble
        {
            get
            {
                return @"\end{document}";
            }
            set { }
        }

        public virtual string PrecompiledHeaderCompileCommand { get { return "-ini -jobname=\"$JOBNAME$\" \"&pdflatex $FILENAME$\\dump\" "; } set { }  }
        public virtual int Compiler_SnippetTimeout { get { return 0; } }
        public virtual int Compiler_Timeout { get { return 0; } }
        public virtual string Path_pdflatex { get { return "pdflatex"; } }
        public virtual string Path_htlatex { get { return "htlatex"; } }

        public virtual uint RoundToDecimals { get { return 4; } }

        public virtual bool UseExternalRenderer { get { return false; } }

        public virtual object GetDefaultSetting(string name) { return null;  }

        /// <summary>
        /// Resets the compiler related (user editable) settings to their default values
        /// </summary>
        public void ResetCompilerSettings()
        {
            Tex_Preamble = GetDefaultSetting("Tex_Preamble") as string;
            Tex_Postamble = GetDefaultSetting("Tex_Postamble") as string;
            PrecompiledHeaderCompileCommand = GetDefaultSetting("PrecompiledHeaderCompileCommand") as string;
        }
    }
   
    /// <summary>
    /// Note: consider to use Tuple instead.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="U"></typeparam>
    public class Pair<T, U>
    {
        public Pair()
        {
        }

        public Pair(T first, U second)
        {
            this.First = first;
            this.Second = second;
        }

        public T First { get; set; }
        public U Second { get; set; }
    };

}
