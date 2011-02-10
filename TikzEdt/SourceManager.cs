using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICSharpCode.AvalonEdit;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace TikzEdt
{
    /**
     * SourceManager provides the binding property for AvalonEdit.
     * The source code can always be grabbed from SourceManager.Instance.SourceCode.
     * 
     * SourceManager takes care that all infos from the source code are displayed.
     * Including drawing nodes on overlay, applying TIKZ_CMD_COMMENTS from source code, etc.
     */
    public class SourceManager : DependencyObject
    {
        /// <summary>
        /// Stores Avalon Document. Only access via SourceCode.
        /// </summary>
        private static readonly DependencyProperty SourceCodeProperty =
            DependencyProperty.Register("_sourceCode", typeof(ICSharpCode.AvalonEdit.Document.TextDocument),
            typeof(SourceManager), new UIPropertyMetadata(new ICSharpCode.AvalonEdit.Document.TextDocument()));

        /// <summary>
        /// Returns Source as TextDocument from Avalon.
        /// Needed for binding with AvalonEdit.
        /// </summary>
        public ICSharpCode.AvalonEdit.Document.TextDocument SourceCode
        {
            get { return (ICSharpCode.AvalonEdit.Document.TextDocument)GetValue(SourceCodeProperty); }
            set { throw new Exception("Setting this property would compromise binding properties."); }
        }
        /// <summary>
        /// Shortcut to read source code.
        /// </summary>
        public static string Code
        {            
            get { return Instance.SourceCode.Text; }
        }
        /// <summary>
        /// static instance property is needed for binding with avalonedit.
        /// </summary>
        public static SourceManager Instance { get; private set; }


        static SourceManager()
        {
            Instance = new SourceManager();
            Instance.SourceCode.TextChanged += new EventHandler(SourceCode_TextChanged);
            
             
        }

        /// <summary>
        /// EventHandler which is called whenever AvalonEdit changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static public void SourceCode_TextChanged(object sender, EventArgs e)
        { 
           
        }


        private void Parse()
        {
            simpletikzLexer lex = new simpletikzLexer(new ANTLRStringStream(Code));
            CommonTokenStream tokens = new CommonTokenStream(lex);
            simpletikzParser parser = new simpletikzParser(tokens);

            
            

        }
    }


    /// <summary>
    /// Is actually just a string plus integer property Position.
    /// </summary>
    class SourceToken
    {
        private string s;
        public uint Position;

        public SourceToken() { }
        public SourceToken(string String) { s = String; }
        public SourceToken(string String, uint Position) { this.s = String; this.Position = Position; }

        //this allows: SourceToken X = "string";
        public static implicit operator SourceToken(string x)
        {
            SourceToken t = new SourceToken(x);
            return t;
        }

        public override string ToString()
        {
            return s;
        }
    }
}
