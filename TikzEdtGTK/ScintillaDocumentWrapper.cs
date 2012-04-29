using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.ComponentModel;

namespace TikzEdtGTK
{
    public class ScintillaDocumentWrapper : TikzEdt.ViewModels.ITEDoc, IDisposable
    {
        //public IDocument Document {get; private set; }

        /// <summary>
        /// Must be filled with a reference to the Texteditor control.
        /// Its Document is recycled, instead of creating new documents.
        /// (This is a hack and undesirable, but it seems one cannot set the ICSharpCode.Texteditor.Document to a newly created document.)
        /// TODO: the document must be disposed of to avoid memory leak!!
        /// </summary>
        public static Sansguerre.GtkScintilla TheOneAndOnly;
        public static ScintillaDocumentWrapper PreviousInstance = null;

        public ScintillaDocumentWrapper()
        {
            //Document = (new DocumentFactory()).CreateDocument();
            //Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy();

            //Document = TheOneAndOnly.Document;
            
            // remove other listeners
            //RemoveAllChangedHandlers();
            if (PreviousInstance != null)
                PreviousInstance.Dispose();
            PreviousInstance = this;

         //TheOneAndOnly.ClearAll();
            //Document.UndoStack.ClearAll();
            //TheOneAndOnly.Refresh();

    //        TheOneAndOnly.Modified += new Sansguerre.ModifiedHandler(TheOneAndOnly_Modified);
            //Document.DocumentChanged += new DocumentEventHandler(Document_DocumentChanged);
        }

        void TheOneAndOnly_Modified(object o, Sansguerre.ModifiedArgs args)
        {
            if (Changed != null)
                Changed(this, args);
        }


        public void BeginUpdate()
        {
            TheOneAndOnly.BeginUndoAction();// Document.UndoStack.StartUndoGroup();
        }

        public void EndUpdate()
        {
            TheOneAndOnly.EndUndoAction();//Document.UndoStack.EndUndoGroup();
        }

        public string Text
        {
            get
            {
                StringBuilder sb = new StringBuilder(TheOneAndOnly.TextLength);
                TheOneAndOnly.GetText(TheOneAndOnly.TextLength, sb);
                return sb.ToString();
            }
            set
            {
                TheOneAndOnly.SetText(value); //Document.TextContent = value;
            }
        }

        public int LineCount
        {
            get { return TheOneAndOnly.LineCount; }
        }

        public event EventHandler Changed;

        public void Replace(int Start, int Length, string NewText)
        {
            TheOneAndOnly.Anchor = Start;
            TheOneAndOnly.CurrentPos = Start+Length;
            TheOneAndOnly.ReplaceSel(NewText);
        }

        /* public static implicit operator DefaultDocument(TextEditorDocumentWrapper W)
        {
            return W.Document;
        } */


        public void Dispose()
        {
            TheOneAndOnly.Modified -= new Sansguerre.ModifiedHandler(TheOneAndOnly_Modified);
        }
    }
}
