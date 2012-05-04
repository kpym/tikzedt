using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TikzEdt;

namespace TikzEdtWForms
{
    class PropertiesParserSettings : TikzEdt.Parser.ParserSettings
    {
        public override uint RoundToDecimals
        {
            get
            {
                return Properties.Settings.Default.RoundToDecimals;
            }
        }
    }

    /// <summary>
    /// This class ties the settings of the viewmodel assembly to the global settings
    /// </summary>
    class PropertiesCompilerSettings : CompilerSettings
    {
        public override double BB_Std_X { get { return Properties.Settings.Default.BB_Std_X; } }
        public override double BB_Std_Y { get { return Properties.Settings.Default.BB_Std_Y; } }
        public override double BB_Std_W { get { return Properties.Settings.Default.BB_Std_W; } }
        public override double BB_Std_H { get { return Properties.Settings.Default.BB_Std_H; } }
        public override double BB_Margin { get { return Properties.Settings.Default.BB_Margin; } }
        public override string Tex_Preamble { get { return Properties.Settings.Default.Tex_Preamble; } }
        public override string Tex_Postamble { get { return Properties.Settings.Default.Tex_Postamble; } }

        public override string PrecompiledHeaderCompileCommand { get { return Properties.Settings.Default.PrecompiledHeaderCompileCommand; } }
        public override int Compiler_SnippetTimeout { get { return Properties.Settings.Default.Compiler_SnippetTimeout; } }
        public override int Compiler_Timeout { get { return Properties.Settings.Default.Compiler_Timeout; } }
        public override string Path_pdflatex { get { return Properties.Settings.Default.Path_pdflatex; } }
        public override string Path_htlatex { get { return Properties.Settings.Default.Path_htlatex; } }


        public override uint RoundToDecimals { get { return Properties.Settings.Default.RoundToDecimals; } }
        public override bool UseExternalRenderer
        {
            get
            {
                return Properties.Settings.Default.UseExternalRenderer;
            }
        }
    }
}
