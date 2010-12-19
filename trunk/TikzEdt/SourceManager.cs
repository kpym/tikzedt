using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICSharpCode.AvalonEdit;

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

        private static readonly DependencyProperty SourceCodeProperty =
            DependencyProperty.Register("_sourceCode", typeof(ICSharpCode.AvalonEdit.Document.TextDocument),
            typeof(SourceManager), new UIPropertyMetadata(new ICSharpCode.AvalonEdit.Document.TextDocument()));

        public ICSharpCode.AvalonEdit.Document.TextDocument SourceCode
        {
            get { return (ICSharpCode.AvalonEdit.Document.TextDocument)GetValue(SourceCodeProperty); }
            set { SetValue(SourceCodeProperty, value); }
        }

        public static SourceManager Instance { get; private set; }

        static SourceManager()
        {
            Instance = new SourceManager();
            Instance.SourceCode.TextChanged += new EventHandler(SourceCode_TextChanged);
            
             
        }

        static public void SourceCode_TextChanged(object sender, EventArgs e)
        { 
            int asd = 3;
        }
    }


    public class VersionManager : DependencyObject
    {

        public static readonly DependencyProperty SourceCodeProperty =
            DependencyProperty.Register("version", typeof(string),
            typeof(SourceManager), new UIPropertyMetadata("text"));

        public string SourceCode
        {
            get
            {
                return (string)GetValue(SourceCodeProperty);
            }
            set
            {
                SetValue(SourceCodeProperty, value);
            }
        }

        public static VersionManager Instance { get; private set; }

        static VersionManager()
        {
            Instance = new VersionManager();
            


        }
    }
    
    
}
