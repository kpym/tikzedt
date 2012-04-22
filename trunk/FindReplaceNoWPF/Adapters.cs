/* Legal note:
 * This code interfaces the AvalonEdit TextEditor library,
 * which is provided under the terms of the GNU Lesser General Public license (LGPL),
 * available here: http://www.gnu.org/copyleft/lesser.html.
 * If you use this code in your project you might be subject to restrictions
 * imposed by the LGPL.
*/

using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Collections;
using System;
using ICSharpCode.TextEditor;

namespace FindReplaceNoWPF
{
    /// <summary>
    /// Adapter for Avalonedit TextEditor
    /// </summary>
    public class TextEditorAdapter : IEditor
    {
        public TextEditorAdapter(TextEditorControl editor) { te = editor; }

        TextEditorControl te;
        public string Text { get { return te.Text; } }
        public int SelectionStart { 
            get 
            {
                if (te.ActiveTextAreaControl.TextArea.SelectionManager.HasSomethingSelected)
                    return te.ActiveTextAreaControl.TextArea.SelectionManager.SelectionCollection[0].Offset;
                else
                    return te.ActiveTextAreaControl.Caret.Offset;
            } 
        }
        public int SelectionLength { 
            get 
            {
                if (te.ActiveTextAreaControl.TextArea.SelectionManager.HasSomethingSelected)
                    return te.ActiveTextAreaControl.TextArea.SelectionManager.SelectionCollection[0].Length;
                else
                    return 0;
            } 
        }
        public void BeginChange() { te.BeginUpdate(); }
        public void EndChange() { te.EndUpdate(); }
        public void Select(int start, int length)
        {
            var s = te.Document.OffsetToPosition(start);
            var e = te.Document.OffsetToPosition(start+length);
            te.ActiveTextAreaControl.TextArea.SelectionManager.SetSelection(s, e);
            te.ActiveTextAreaControl.ScrollTo(s.Line);
        }
        public void Replace(int start, int length, string ReplaceWith) { te.Document.Replace(start, length, ReplaceWith); }

    }

    
}