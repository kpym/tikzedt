using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICSharpCode.AvalonEdit.Document;

namespace TikzEdt
{
    public class AvalonDocumentWrapper : TikzEdt.ViewModels.ITEDoc
    {
        public TextDocument Document { get; private set; }

        public AvalonDocumentWrapper() : this(""){  }

        public AvalonDocumentWrapper(string Text)
        {
            Document = new TextDocument(Text);
            Document.Changed += new EventHandler<DocumentChangeEventArgs>(Document_Changed);
        }

        void Document_Changed(object sender, DocumentChangeEventArgs e)
        {
            if (Changed != null)
                Changed(this, e);
        }

        public void BeginUpdate()
        {
            Document.BeginUpdate();
        }

        public void EndUpdate()
        {
            Document.EndUpdate();
        }

        public string Text
        {
            get { return Document.Text; }
            set { Document.Text = value; }
        }

        public event EventHandler Changed;

        public void Replace(int Start, int Length, string NewText)
        {
            Document.Replace(Start, Length, NewText);
        }

        public static implicit operator TextDocument(AvalonDocumentWrapper W)
        {
            return W.Document;
        }


        public int LineCount
        {
            get { return Document.LineCount; }
        }
    }
}
