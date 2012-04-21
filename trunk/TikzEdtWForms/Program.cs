using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TikzEdt;

namespace TikzEdtWForms
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string[] Args = Environment.GetCommandLineArgs();

            GlobalUI.UI = new GlobalUIWinForms();

            // set application data path and settings path          
            if (Args.Contains("-p") || Args.Contains("--portable"))
            {
                Helper.SetAppdataPath(Helper.AppdataPathOptions.ExeDir);
            }
            else
                Helper.SetAppdataPath(Helper.AppdataPathOptions.AppData);

            // load/store settings at a sensible location (not the standard cryptic one)
            AppMethods.RewireSettingsProvider(Properties.Settings.Default);
			TouchAllSettings();
			
            // tie settings to Viewmodels (TODO... maybe change to std dependency injection pattern)
            CompilerSettings.Instance = new PropertiesCompilerSettings();
            TikzEdt.Parser.ParserSettings.Instance = new PropertiesParserSettings();

            // check that necessary config files are in place
            string missingfile = "";
            if (false == AppMethods.FirstRunPreparations(out missingfile))
                MessageBox.Show("File " + missingfile + " not found. Please re-install program or provide file manually.", "File missing", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
		
		/// <summary>
		/// This is a workaround to cope with a Mono bug, not writing the default settings to file.
		/// </summary>
		static void TouchAllSettings()
		{
			var S = Properties.Settings.Default;
			S.AutoCompileOnDocumentChange = S.AutoCompileOnDocumentChange;
			S.BB_Margin = S.BB_Margin;
			S.CheckForUpdates = S.CheckForUpdates;
			S.CompileOnCodeChangeRadioButton = S.CompileOnCodeChangeRadioButton;
			S.CompileOnCTRLPressRadioButton = S.CompileOnCTRLPressRadioButton;
			S.Compiler_SnippetTimeout = S.Compiler_SnippetTimeout;
			S.Compiler_Timeout = S.Compiler_Timeout;
			S.Editor_CodeCompletion = S.Editor_CodeCompletion;
			S.Editor_CompleteBegins = S.Editor_CodeCompletion;
			S.Editor_Font = S.Editor_Font;
			S.Editor_ShowLineNumbers = S.Editor_ShowLineNumbers;
			S.Editor_WordWrap = S.Editor_WordWrap;
			S.FolderView_ShowHidden = S.FolderView_ShowHidden;
			S.LeftMenuColWidthSetting = S.LeftMenuColWidthSetting;
			S.LeftToolsColSelectedIndex = S.LeftToolsColSelectedIndex;
			S.LeftToolsColWidthSetting = S.LeftToolsColWidthSetting;
			S.LineColWidth = S.LineColWidth;
			S.MessageColWidth = S.MessageColWidth;
			S.OverlayCanvasCol2WidthSetting = S.OverlayCanvasCol2WidthSetting;
			S.Overlay_CoordColor = S.Overlay_CoordColor;
			S.Overlay_CoordSelColor = S.Overlay_CoordSelColor;
			S.Overlay_ScopeColor = S.Overlay_ScopeSelColor;
			S.Path_externalviewer = S.Path_externalviewer;
			S.Path_htlatex = S.Path_htlatex;
			S.Path_pdflatex = S.Path_pdflatex;
			S.PrecompiledHeaderCompileCommand = S.PrecompiledHeaderCompileCommand;
			S.Raster_GridWidth = S.Raster_GridWidth;
			S.Raster_RadialOffset = S.Raster_RadialOffset;
			S.Raster_RadSteps = S.Raster_RadSteps;
			S.RoundToDecimals = S.RoundToDecimals;
			S.Snippets_ShowThumbs = S.Snippets_ShowThumbs;
			S.Tex_Postamble = S.Tex_Postamble;
			S.Tex_Preamble = S.Tex_Preamble;
			S.Window_Height = S.Window_Height;
			S.Window_Left = S.Window_Left;
			S.Window_State = S.Window_State;
			S.Window_Top = S.Window_Top;
			S.Window_Width = S.Window_Width;
			
		}

    }
}
