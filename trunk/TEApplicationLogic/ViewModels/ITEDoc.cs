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

        /// <summary>
        /// Gets the line number of the specified offset.
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        int LineFromOffset(int offset);
        /// <summary>
        /// Gets the offset at the beginning of the specified line. (The first line has number 1.)
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        int OffsetFromLine(int line);

        string GetLine(int line);

        event EventHandler Changed;

        void Replace(int Start, int Length, string NewText);

    }

    public static class ITEDocExtensions
    {
        public static void Insert(this ITEDoc doc, int offset, string Text)
        {
            doc.Replace(offset, 0, Text);
        }
        public static void Remove(this ITEDoc doc, int offset, int length)
        {
            doc.Replace(offset, length, "");
        }
    }
}
