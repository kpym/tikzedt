using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICSharpCode.TextEditor.Document;

namespace TikzEdtWForms
{
    public class TextEditorDocumentWrapper : TikzEdt.ViewModels.ITEDoc
    {
        public IDocument Document {get; private set; }

        public TextEditorDocumentWrapper()
        {
            Document = (new DocumentFactory()).CreateDocument();
            Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy();

            Document.DocumentChanged += new DocumentEventHandler(Document_DocumentChanged);
        }

        void Document_DocumentChanged(object sender, DocumentEventArgs e)
        {
            if (Changed != null)
                Changed(this, e);
        }

        public void BeginUpdate()
        {
            Document.UndoStack.StartUndoGroup();
        }

        public void EndUpdate()
        {
            Document.UndoStack.EndUndoGroup();
        }

        public string Text
        {
            get
            {
                return Document.TextContent;
            }
            set
            {
                Document.TextContent = value;
            }
        }

        public int LineCount
        {
            get { return Document.TotalNumberOfLines; }
        }

        public event EventHandler Changed;

        public void Replace(int Start, int Length, string NewText)
        {
            Document.Replace(Start, Length, NewText);
        }

        /* public static implicit operator DefaultDocument(TextEditorDocumentWrapper W)
        {
            return W.Document;
        } */

    }
}
