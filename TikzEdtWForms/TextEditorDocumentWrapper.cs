using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICSharpCode.TextEditor.Document;
using System.Reflection;
using System.ComponentModel;

namespace TikzEdtWForms
{
    public class TextEditorDocumentWrapper : TikzEdt.ViewModels.ITEDoc, IDisposable
    {
        public IDocument Document {get; private set; }

        /// <summary>
        /// Must be filled with a reference to the Texteditor control.
        /// Its Document is recycled, instead of creating new documents.
        /// (This is a hack and undesirable, but it seems one cannot set the ICSharpCode.Texteditor.Document to a newly created document.)
        /// TODO: the document must be disposed of to avoid memory leak!!
        /// </summary>
        public static ICSharpCode.TextEditor.TextEditorControl TheOneAndOnly;
        public static TextEditorDocumentWrapper PreviousInstance = null;

        public TextEditorDocumentWrapper()
        {
            //Document = (new DocumentFactory()).CreateDocument();
            //Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy();

            Document = TheOneAndOnly.Document;
            
            // remove other listeners
            //RemoveAllChangedHandlers();
            if (PreviousInstance != null)
                PreviousInstance.Dispose();
            PreviousInstance = this;

            TheOneAndOnly.ResetText();
            Document.UndoStack.ClearAll();
            TheOneAndOnly.Refresh();

            Document.DocumentChanged += new DocumentEventHandler(Document_DocumentChanged);
        }

        void RemoveAllChangedHandlers()
        {
            FieldInfo f1 = typeof(IDocument).GetField("DocumentChanged",
                BindingFlags.Static | BindingFlags.NonPublic);
            object obj = f1.GetValue(Document);
            PropertyInfo pi = Document.GetType().GetProperty("Events",
                BindingFlags.NonPublic | BindingFlags.Instance);
            EventHandlerList list = (EventHandlerList)pi.GetValue(Document, null);
            list.RemoveHandler(obj, list[obj]);
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


        public void Dispose()
        {
            Document.DocumentChanged -= new DocumentEventHandler(Document_DocumentChanged);
        }


        public int LineFromOffset(int offset)
        {
            return Document.GetLineNumberForOffset(offset);
        }

        public int OffsetFromLine(int line)
        {
            return Document.GetLineSegment(line).Offset;
        }


        public string GetLine(int line)
        {
            return Document.GetText( Document.GetLineSegment(line) );
        }
    }
}
