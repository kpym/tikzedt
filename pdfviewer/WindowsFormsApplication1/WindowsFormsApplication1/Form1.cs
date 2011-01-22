using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        PDFLibNet.PDFWrapper _pdfDoc;
        string pdfdoc = @"c:\temp\Pos_Adressen.pdf";
        Bitmap _backbuffer;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!File.Exists(pdfdoc))
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Portable Document Format (*.pdf)|*.pdf";
                if (dlg.ShowDialog() == DialogResult.OK)
                    pdfdoc = dlg.FileName;
                else
                    return;
            }

                _pdfDoc = new PDFLibNet.PDFWrapper();
                _pdfDoc.UseMuPDF = true;
                _pdfDoc.LoadPDF(pdfdoc);
                _pdfDoc.CurrentPage = 1;

                //render
                button4_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_pdfDoc != null)
            {
                _pdfDoc.Dispose();
                _pdfDoc = null;
            }         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(pdfdoc);
                MessageBox.Show("File " + pdfdoc + " deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
                pictureBox1.Image.Dispose();

            PictureBox pic = new PictureBox();
            pic.Width = 800;
            pic.Height = 1024;
            _pdfDoc.FitToWidth(pic.Handle);
            pic.Height = _pdfDoc.PageHeight;
            _pdfDoc.RenderPage(pic.Handle);
            /*Added since 1.0.6.2*/
            _pdfDoc.CurrentX = 0;
            _pdfDoc.CurrentY = 0;
            _pdfDoc.ClientBounds = new Rectangle(0, 0, _pdfDoc.PageWidth, _pdfDoc.PageHeight);

            _backbuffer = new Bitmap(_pdfDoc.PageWidth, _pdfDoc.PageHeight);

            using (Graphics g = Graphics.FromImage(_backbuffer))
            {
                /*New thread safe method*/
                _pdfDoc.DrawPageHDC(g.GetHdc());
                g.ReleaseHdc();
            }
            pic.Dispose();
            
            pictureBox1.Image = _backbuffer;
        }
    }
}
