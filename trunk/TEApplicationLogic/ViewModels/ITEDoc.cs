using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TikzEdt.ViewModels
{
    /// <summary>
    /// This is the interface abstracting access to a document type used for display in the editor component.
    /// (I.e., in ICSharpCode.AvalonEdit, ICSharpCode.TextEditor or later, maybe, Scintilla.)
    /// </summary>
    public interface ITEDoc
    {
        void BeginUpdate();
        void EndUpdate();
        string Text { get; set; }
        int LineCount { get; }

        event EventHandler Changed;

        void Replace(int Start, int Length, string NewText);

    }
}
