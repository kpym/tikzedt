using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;
using System.Diagnostics;
using System.IO;

namespace TikzEdt
{
    /// <summary>
    /// Interaction logic for TikzDisplay.xaml 
    /// NOT THREAD-SAFE SO FAR
    /// </summary>
    public partial class TikzDisplay : UserControl
    {
        public enum CompileEventType {Start, Error, Success, Status};
        public delegate void CompileEventHandler(string Message, CompileEventType type);
        public event CompileEventHandler OnCompileEvent;

        readonly public static DependencyProperty CompilingProperty = DependencyProperty.Register(
                "Compiling", typeof(bool), typeof(TikzDisplay));
        public bool Compiling
        {
            get { return (bool)GetValue(CompilingProperty); }
            set { }
        }

        public void Compile(string code, Rect BB)
        {
            nextToCompile = code;
            nextBB = BB;
            doCompile();
        }

        private double lResolution = Consts.ptspertikzunit;
        public double Resolution
        {
            get { return lResolution; }
            set { 
                if (value >0)
                    lResolution = value; 
            }
        }

        protected Process texProcess = new Process();
        protected String nextToCompile = "";
        Rect nextBB, compilingBB, currentBB;
        protected bool isRunning = false;
        PDFLibNet.PDFWrapper mypdfDoc = null;
        System.Windows.Forms.Control dummy = new System.Windows.Forms.Control();

        public void AbortCompilation()
        {
            if (!texProcess.HasExited)
                texProcess.Kill();
        }

        protected void doCompile()
        {
            if (isRunning || nextToCompile == "")
            {
                return;
            }
            isRunning = true;
            SetValue(CompilingProperty, true);

            if (!File.Exists(Consts.cTempFile + ".fmt"))
            {
                OnCompileEvent("Generating precompiled headers.... please restart in some moments", CompileEventType.Status); 
                Helper.GeneratePrecompiledHeaders();
                return;
            }

            // save into temporary textfile
            // add bounding box
            bool lsucceeded;
            string codetowrite = writeBBtoTikz(nextToCompile, nextBB, out lsucceeded);

            StreamWriter s = new StreamWriter(Consts.cTempFile + ".tex");
            s.WriteLine(@"%&" + Consts.cTempFile);

            if (lsucceeded)
            {
                s.WriteLine(@"\pdfpageattr{/MediaBox [0 0 " + Convert.ToInt32(nextBB.Width * Consts.ptspertikzunit) + " "
                                                            + Convert.ToInt32(nextBB.Height * Consts.ptspertikzunit) + "]}");
                s.WriteLine(@"\begin{document}");
                s.WriteLine(@"\thispagestyle{empty}");
                s.WriteLine(@"\mathindent0cm \parindent0cm");
                s.WriteLine(@"not seen");
                s.WriteLine(@"\vfill");
            }
            else
            {
                s.WriteLine(@"\begin{document}");
                s.WriteLine(@"\thispagestyle{empty}");
                s.WriteLine(@"\mathindent0cm \parindent0cm");
            }

            s.WriteLine(codetowrite);
            s.WriteLine(@"\end{document}");
            s.Close();
            nextToCompile = "";
            if (lsucceeded)
                compilingBB = nextBB;
            else compilingBB = new Rect(0, 0, 0, 0);

            // call pdflatex         
            OnCompileEvent("Compiling document for preview: " + texProcess.StartInfo.FileName + " " + texProcess.StartInfo.Arguments, CompileEventType.Start);
            texProcess.Start();
        }

        string writeBBtoTikz(string code, Rect BB, out bool succeeded)
        {
            // hack
            string cend = @"\end{tikzpicture}";
            string[] tok = code.Split(new string[] { cend }, StringSplitOptions.None);
            succeeded = (tok.Length == 2 && nextBB.Width * nextBB.Height > 0);
            if (succeeded)
                return tok[0] + @"\draw (" + BB.X + "," + BB.Y + ") rectangle (" + (BB.X + BB.Width).ToString() + "," + (BB.Y + BB.Height).ToString() + "); " + cend + tok[1];
            else
                return code;
        }

        public TikzDisplay()
        {
            InitializeComponent();

            texProcess.EnableRaisingEvents = true;
            texProcess.StartInfo.Arguments = "-quiet -halt-on-error " + Consts.cTempFile + ".tex";
            texProcess.StartInfo.FileName = "pdflatex";
            texProcess.StartInfo.CreateNoWindow = true;
            texProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            // texProcess.SynchronizingObject = (System.ComponentModel.ISynchronizeInvoke) this;
            texProcess.Exited += new EventHandler(texProcess_Exited);

        }

        /// <summary>
        /// Reload the PDF file
        /// </summary>
        void RefreshPDF()
        {
            if (mypdfDoc != null)
                mypdfDoc.Dispose();
            mypdfDoc = new PDFLibNet.PDFWrapper();
            mypdfDoc.UseMuPDF = true;
            mypdfDoc.LoadPDF(Consts.cTempFile + ".pdf");

            RecalcSize();          
        }

        void texProcess_Exited(object sender, EventArgs e)
        {
            Dispatcher.Invoke(new Action(
            delegate()
            {
                if (texProcess.ExitCode == 0)
                {
                    currentBB = compilingBB;
                    RefreshPDF();

                    OnCompileEvent("Compilation done", CompileEventType.Success);                                       
                }
                else OnCompileEvent("Compilation failed wih exit code " + texProcess.ExitCode, CompileEventType.Error);

                
                isRunning = false;
                SetValue(CompilingProperty, false);
              ///  if (nextToCompile != "")
               //     doCompile();
            }
            ));
        }


      //  [DllImport("gdi32")]
      //  static extern int DeleteObject(IntPtr o);

        public static BitmapSource loadBitmap(System.Drawing.Bitmap source)
        {
            IntPtr ip = source.GetHbitmap();
            BitmapSource bs;
            try
            {
                bs = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(ip,
                   IntPtr.Zero, Int32Rect.Empty,
                   System.Windows.Media.Imaging.BitmapSizeOptions.FromEmptyOptions());
            }
            finally
            {
                //DeleteObject(ip);
            }

            return bs;
        }

        /// <summary>
        /// Size is given by resolution * bounding box, if present.
        /// </summary>
        void RecalcSize()
        {
            if (currentBB.Width * currentBB.Height > 0)
            {
                Width = currentBB.Width * Resolution;
                Height = currentBB.Height * Resolution;
            }
            else
            {
                
            }

            RedrawBMP();
        }

        void RedrawBMP()
        {
            if (mypdfDoc != null)
            {
                double magicnumber = 0.45;
                dummy.Width = Convert.ToInt32(ActualWidth / magicnumber);
                dummy.Height = Convert.ToInt32(ActualHeight / magicnumber);
                //WindowInteropHelper helper = new WindowInteropHelper(dummy);
                mypdfDoc.FitToWidth(dummy.Handle);
                mypdfDoc.RenderPage(dummy.Handle);
                dummy.Width =  Convert.ToInt32(ActualWidth);
                dummy.Height =  Convert.ToInt32(ActualHeight);
                //int w = mypdfDoc.PageWidth;
                //mypdfDoc.RenderDPI *= (2.7)*dummy.Width / mypdfDoc.PageWidth;
                //int ww = mypdfDoc.PageWidth;

                //PDFLibNet.PDFPage p = mypdfDoc.Pages[mypdfDoc.CurrentPage];


                Bitmap b = new Bitmap(dummy.Width, dummy.Height);
                //Bitmap b = p.GetBitmap(dummy.Width, dummy.Height); //new Bitmap(dummy.Width, dummy.Height);
                Graphics gr = Graphics.FromImage(b);
                mypdfDoc.ClientBounds = new System.Drawing.Rectangle(0, 0, b.Width, b.Height);
                mypdfDoc.DrawPageHDC(gr.GetHdc());
                gr.ReleaseHdc();

                //b.Save("test.bmp");
                //pictureBox1.Image = b;
                image1.Source = loadBitmap(b);
            }
        }

        private void image1_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            RedrawBMP();
        }

    }
}
