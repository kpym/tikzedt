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
                if (value > 0)
                {
                    lResolution = value;
                    Width = currentBB.Width * Resolution;
                    Height = currentBB.Width * Resolution;
                    RedrawBMP();
                }
            }
        }

        protected Process texProcess = new Process();
        protected String nextToCompile = "";
        Rect nextBB, compilingBB, currentBB;
        protected bool isRunning = false;
        PDFLibNet.PDFWrapper mypdfDoc = null;
        System.Windows.Forms.Control dummy = new System.Windows.Forms.Control();

        /// <summary>
        /// If the compilation gets stuck (actually it shouldn't), 
        /// one can call this method to kill the pdflatex-process.
        /// </summary>
        public void AbortCompilation()
        {
            if (!texProcess.HasExited)
                texProcess.Kill();
        }

        /// <summary>
        /// The main routine, starts the compilation of the Tikz-Picture.
        /// If necessary it initiates compilation of the precompiled headers.
        /// </summary>
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
        /// <summary>
        /// Adds a rectangle to the Tikzcode in the size specified by BB. 
        /// The rectangle is added as the last command before the \end{tikzpicture} 
        /// </summary>
        /// <param name="code">The Tikz Code. Must contain an "\end{tikzpicture}" </param>
        /// <param name="BB">The bounding box (= size of rectangle to be written) </param>
        /// <param name="succeeded">Returns success, i.e., whether the string "\end{tikzpicture}" has been found</param>
        /// <returns>The Tikzcode, with the "\draw rectangle ...." inserted </returns>
        string writeBBtoTikz(string code, Rect BB, out bool succeeded)
        {
            // hack
            string cend = @"\end{tikzpicture}";
            string[] tok = code.Split(new string[] { cend }, StringSplitOptions.None);
            succeeded = (tok.Length == 2 && nextBB.Width * nextBB.Height > 0); //TODO: check
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
        /// Reload the PDF file. This is called only when the pdf file changes on disk.
        /// It is not called, for example, when the pdf just needs to be redrawn, e.g., due to 
        /// a changed display size.
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

        /// <summary>
        /// This is called when PDFLatex has exited
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This method converts a System.Drawing.Bitmap to a WPF Bitmap.
        /// (This is necessary since the WPF Image control only accepts WPF bitmaps)
        /// </summary>
        /// <param name="source">The System.Drawing.Bitmap</param>
        /// <returns>The same Bitmap, in Wpf format</returns>
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

        /// <summary>
        /// This method draws the currently loaded Pdf into a bitmap, and displays this bitmap in the image control.
        /// It is called, e.g., when the size of the TikzDisplay control changes
        /// Warning: It does _not_ reload the Pdf. 
        /// </summary>
        void RedrawBMP()
        {
            if (mypdfDoc != null)
            {
                double magicnumber = 0.45;
                dummy.Width = Convert.ToInt32(ActualWidth / magicnumber);
                dummy.Height = Convert.ToInt32(ActualHeight / magicnumber);

                mypdfDoc.FitToWidth(dummy.Handle);
                mypdfDoc.RenderPage(dummy.Handle);
                dummy.Width =  Convert.ToInt32(ActualWidth);
                dummy.Height =  Convert.ToInt32(ActualHeight);

                if (dummy.Width <= 0 || dummy.Height <= 0) // TODO: this hould nott be necessary
                    return;

                Bitmap b = new Bitmap(dummy.Width, dummy.Height);
                Graphics gr = Graphics.FromImage(b);
                mypdfDoc.ClientBounds = new System.Drawing.Rectangle(0, 0, b.Width, b.Height);
                mypdfDoc.DrawPageHDC(gr.GetHdc());
                gr.ReleaseHdc();
                System.Drawing.Color c = b.GetPixel(30, 30);
                b.MakeTransparent(b.GetPixel(5,5));//Color.White);
                b.MakeTransparent(System.Drawing.Color.White);
                b.MakeTransparent(System.Drawing.Color.FromArgb(255,253,253,253));
                image1.Source = loadBitmap(b);

            }
        }

        private void image1_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            RedrawBMP();
        }

    }
}
