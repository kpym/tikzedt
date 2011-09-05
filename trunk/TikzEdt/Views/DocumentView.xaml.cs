using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ICSharpCode.AvalonEdit;
using TikzEdt.Parser;

namespace TikzEdt.Views
{
    /// <summary>
    /// Interaction logic for DocumentView.xaml
    /// </summary>
    public partial class TEDocumentView : UserControl
    {
        public ViewModels.TEDocumentVM TheVM {get; set; }

        public void InsertAtCurrentPos(string s)
        {
            txtCode.Document.Insert(txtCode.CaretOffset, s);
        }

        public TEDocumentView(ViewModels.TEDocumentVM theVM)
        {
            DataContext = TheVM = theVM;
            InitializeComponent();
            pdfOverlay1.Rasterizer = rasterControl1;

            TheVM.OnPdfReady += new EventHandler<ViewModels.TEDocumentVM.PdfReadyEventArgs>(TheVM_OnPdfReady);

        }

        void TheVM_OnPdfReady(object sender, ViewModels.TEDocumentVM.PdfReadyEventArgs e)
        {
            tikzDisplay1.RedrawBMP(e.ReloadPdf);
        }
        private void MarkAtOffsetClick(object sender, RoutedEventArgs e)
        {
            // the mouse position upon context menu opening is stored in mousepos_whenmenuopened
            // first place the caret at this position
            if (mousepos_whenmenuopened >= 0)
            {
                txtCode.CaretOffset = mousepos_whenmenuopened;
            }
            //TODOOO
            //pdfOverlay1.MarkObjectAt(txtCode.CaretOffset);
        }

        int mousepos_whenmenuopened = -1;  // The mouse position (as a text offset) upon context menu opening; -1 = could not be determined
        private void txtCodeContextMenu_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            // the mouse position upon context menu opening is stored in mousepos_whenmenuopened
            Nullable<TextViewPosition> vp = txtCode.TextArea.TextView.GetPosition(new Point(e.CursorLeft, e.CursorTop));
            if (vp != null)
            {
                mousepos_whenmenuopened = txtCode.Document.GetOffset(vp.Value.Line, vp.Value.Column);
            }
            else
                mousepos_whenmenuopened = -1;
        }

        private void Enscope_Click(object sender, RoutedEventArgs e)
        {
            if (txtCode.SelectionLength > 0)
                txtCode.Document.Replace(txtCode.SelectionStart, txtCode.SelectionLength,
                    "\\begin{scope}[]\r\n" + txtCode.SelectedText + "\r\n\\end{scope}");
            else
                txtCode.Document.Insert(txtCode.CaretOffset, "\\begin{scope}[]\r\n\r\n\\end{scope}");
        }

        private void txtCode_Drop(object sender, DragEventArgs e)
        {
            //open file which was drag&dropped.
         /*   if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                //open only single file
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length == 1)
                {
                    //warn user about wrong file extension
                    if (System.IO.Path.GetExtension(files[0]) != ".tex")
                    {
                        MessageBoxResult r = MessageBox.Show("File does not seem to be a LaTeX-file. Proceed opening?", "Wrong file extension", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);
                        if (r == MessageBoxResult.No)
                            return;
                    }
                    if (TryDisposeFile())
                        LoadFile(files[0]);
                }
                else
                    MessageBox.Show("Only one file at a time allowed via drag&drop.", "Too many files", MessageBoxButton.OK, MessageBoxImage.Information);

            }*/

        }

        private void txtCode_DragEnter(object sender, DragEventArgs e)
        {
            //show that TikzEdt accepts files by drag&drop
            //however, only a single file is allowed.
           /* if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length == 1)
                    e.Effects = DragDropEffects.Move;
                else
                    e.Effects = DragDropEffects.None;
                e.Handled = true;
            }
            //setting e.Effects = DragDropEffects.None is ignored. why? */
        }

        private void pdfOverlay1_OnModified(TikzParseItem sender, string oldtext)
        {
            // update code
            int InsertAt = sender.StartPosition();
            if (InsertAt > txtCode.Text.Length)
            {
                MainWindow.AddStatusLine("Trying to insert code \"" + sender.ToString().Replace(Environment.NewLine, "<NEWLINE>") + "\" to position " + sender.StartPosition() + " but document has only " + txtCode.Text.Length + " characters."
                + " Inserting code at end of document instead. Code does probably not compile now. Please correct or choose undo.", true);
                InsertAt = txtCode.Text.Length;
            }

            txtCode.Document.Replace(InsertAt, oldtext.Length, sender.ToString());

        }
        private void pdfOverlay1_BeginModify(object sender)
        {
            TheVM.ProgrammaticTextChange = true;
            txtCode.Document.BeginUpdate();
        }

        private void pdfOverlay1_EndModify(object sender)
        {
            txtCode.Document.EndUpdate();
            TheVM.ProgrammaticTextChange = false;
            // refresh style list since styles may have changed (but: not necessary to fully reparse)
            TheVM.UpdateStyleList();
        }

        private void pdfOverlay1_JumpToSource(object sender)
        {
            TikzParseItem tpi = sender as TikzParseItem;
            int spos = tpi.StartPosition();
            if (spos > txtCode.Text.Length)
            {
                MainWindow.AddStatusLine("Trying to jump to position " + spos + " but document only has " + txtCode.Text.Length + " characters. Please correct any parser errors or restart TikzEdt.", true);
                return;
            }
            txtCode.SelectionLength = 0; //deselect first
            txtCode.CaretOffset = spos;
            txtCode.SelectionStart = spos;
            txtCode.SelectionLength = tpi.ToString().Length;
            txtCode.ScrollToLine(txtCode.Document.GetLineByOffset(spos).LineNumber);
            txtCode.Focus();
        }

        /* private void pdfOverlay1_ToolChanged(object sender)
        {
           rbToolMove.IsChecked = (pdfOverlay1.tool == PdfOverlay.ToolType.move);
            rbToolAddVert.IsChecked = (pdfOverlay1.tool == PdfOverlay.ToolType.addvert);
            rbToolAddEdge.IsChecked = (pdfOverlay1.tool == PdfOverlay.ToolType.addedge);
            rbToolAddPath.IsChecked = (pdfOverlay1.tool == PdfOverlay.ToolType.addpath); 
        }*/

        private void pdfOverlay1_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (System.Windows.Forms.Control.ModifierKeys == System.Windows.Forms.Keys.Control)
            {
               /* TODO int count = cmbZoom.Items.Count;
                int step = e.Delta > 0 ? 1 : -1;
                if (cmbZoom.SelectedIndex + step > 0 && cmbZoom.SelectedIndex + step < count)
                    cmbZoom.SelectedIndex += step; */
            }

        }
    }
}
