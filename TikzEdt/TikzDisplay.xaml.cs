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
using System.Runtime.InteropServices;
using PDFLibNet;

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
        public delegate void TexOutputHandler(string Message);
        public event TexOutputHandler OnTexOutput;

        readonly public static DependencyProperty CompilingProperty = DependencyProperty.Register(
                "Compiling", typeof(bool), typeof(TikzDisplay));
        public bool Compiling
        {
            get { return (bool)GetValue(CompilingProperty); }
            set { }
        }

        public void Compile(string code, Rect BB, bool IsStandAlone)
        {
            if (IsStandAlone)
                nextToCompile = code;
            else nextToCompile = @"%&" + Consts.cTempFile + "\r\n\\begin{document}\r\n" + code + "\r\n" + Properties.Settings.Default.Tex_Postamble;  
            nextBB = BB;
            doCompile();
        }

        private double _Resolution = Consts.ptspertikzunit;
        public double Resolution
        {
            get { return _Resolution; }
            set {
                if (value > 0)
                {
                    _Resolution = value;
                    RecalcSize();
                }
            }
        }

        protected Process texProcess = new Process();
        protected String nextToCompile = "";
        Rect nextBB, compilingBB, currentBB;
        protected bool isRunning = false;
        //PDFLibNet.PDFWrapper mypdfDoc = null;
        PdfToBmp mypdfDoc = new PdfToBmp();

        //System.Windows.Forms.Control dummy = new System.Windows.Forms.Control();

        /// <summary>
        /// If the compilation gets stuck (actually it shouldn't), 
        /// one can call this method to kill the pdflatex-process.
        /// </summary>
        public void AbortCompilation()
        {
            try
            {
                if (!texProcess.HasExited)
                    texProcess.Kill();
            }
            catch (InvalidOperationException)
            {
                isRunning = false;
                //process has already terminated. that is okay.
            }
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
                //GeneratePrecompiledHeaders() has no callback function. thus:                
                isRunning = false;
                return;
            }

            // save into temporary textfile
            // add bounding box, if bounding box provided has size other than 0
            bool lsucceeded= true;
            string codetowrite;
            if (nextBB.Width * nextBB.Height == 0)
                codetowrite = nextToCompile;
            else
                codetowrite = writeBBtoTikz(nextToCompile, nextBB, out lsucceeded);

            StreamWriter s = new StreamWriter(Consts.cTempFile + ".tex");
 
            s.WriteLine(codetowrite);
            s.Close();
            nextToCompile = "";
            if (lsucceeded)
                compilingBB = nextBB;
            else compilingBB = new Rect(0, 0, 0, 0);

            // call pdflatex         
            OnCompileEvent("Compiling document for preview: " + texProcess.StartInfo.FileName + " " + texProcess.StartInfo.Arguments, CompileEventType.Start);
            
            //clear error windows
            ((MainWindow)Application.Current.Windows[0]).txtTexout.Document.Blocks.Clear();
            ((MainWindow)Application.Current.Windows[0]).clearProblemMarkers();
            

            try
            {
                if (texProcess.HasExited == true)
                {
                    texProcess.CancelOutputRead();
                    texProcess.CancelErrorRead();
                }
            }
            catch (InvalidOperationException Ex)
            {
                //on first call when texProcess was not started, HasExited raises exception.
            }

            texProcess.Start();
            texProcess.BeginOutputReadLine();
            texProcess.BeginErrorReadLine();
            
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
            string cend = @"\end{tikzpicture}"; // hack
            string[] tok = code.Split(new string[] { cend }, StringSplitOptions.None);
            succeeded = (tok.Length == 2 && nextBB.Width * nextBB.Height > 0); //TODO: check
            if (succeeded)
                return tok[0] + @"\draw (" + BB.X + "," + BB.Y + ") rectangle (" + (BB.X + BB.Width).ToString() + "," + (BB.Y + BB.Height).ToString() + ");\r\n " + cend + tok[1];
            else
                return code;
        }

        public TikzDisplay()
        {
            InitializeComponent();

            texProcess.EnableRaisingEvents = true;
            texProcess.StartInfo.Arguments = "-halt-on-error " + Consts.cTempFile + ".tex";
            texProcess.StartInfo.FileName = "pdflatex";
            texProcess.StartInfo.CreateNoWindow = true;
            texProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            texProcess.StartInfo.UseShellExecute = false;
            texProcess.StartInfo.RedirectStandardOutput = true;
            texProcess.StartInfo.RedirectStandardError = true;
            
            // texProcess.SynchronizingObject = (System.ComponentModel.ISynchronizeInvoke) this;
            texProcess.Exited += new EventHandler(texProcess_Exited);
            texProcess.OutputDataReceived += new DataReceivedEventHandler(texProcess_OutputDataReceived);
            texProcess.ErrorDataReceived += new DataReceivedEventHandler(texProcess_ErrorDataReceived);
        }

        void texProcess_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            string s = "ErrorDataReceived: " + e.Data;
            Dispatcher.Invoke(
                new Action(
                    delegate()
                    {
                        if (OnTexOutput != null)
                            OnTexOutput(s);
                    }
                )
            );
        }
        
        void texProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Dispatcher.Invoke(
                new Action(
                    delegate()
                    {
                        if (OnTexOutput != null)
                            OnTexOutput(e.Data);
                    }
                )
            );
        }

        /// <summary>
        /// Reload the PDF file. This is called only when the pdf file changes on disk.
        /// It is not called, for example, when the pdf just needs to be redrawn, e.g., due to 
        /// a changed display size.
        /// </summary>
        void RefreshPDF()
        {
            mypdfDoc.LoadPdf(Consts.cTempFile + ".pdf");
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
                //call OnTexOutput once more to make sure line de-breaking buffer is processed.
                Dispatcher.Invoke(
                    new Action(
                        delegate()
                        {
                            if (OnTexOutput != null)
                                OnTexOutput("");
                        }
                    )
                );


                if (texProcess.ExitCode == 0)
                {
                    currentBB = compilingBB;
                    RefreshPDF();
                    //string texout = texProcess.StandardOutput.ReadToEnd();
                    OnCompileEvent("Compilation done", CompileEventType.Success);
                }
                else
                {
                    //string err = texProcess.StandardOutput.ReadToEnd();
                    OnCompileEvent("Compilation failed wih exit code " + texProcess.ExitCode, CompileEventType.Error);
                }
                
                isRunning = false;
                SetValue(CompilingProperty, false);
              ///  if (nextToCompile != "")
               //     doCompile();


                //this is bad. lines that are still "on its way" will be discarded.
                //cf. example on http://msdn.microsoft.com/de-de/library/system.diagnostics.process.beginoutputreadline(VS.80).aspx
                //there is no CancelOutputRead() call.
                ///texProcess.CancelOutputRead();
            }
            ));
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
                Width = double.NaN; // auto height/width
                Height = double.NaN;
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
                image1.Source = mypdfDoc.GetBitmap(Resolution, currentBB.Width*currentBB.Height >0); // mypdfDoc.GetBitmap(currentBB, Resolution);                
            }
        }

        private void image1_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //RedrawBMP();
        }

    }



    public class PdfToBmp
    {
        PDFWrapper mypdfDoc;

        public bool LoadPdf(string cfile)
        {
            if (mypdfDoc != null)
                mypdfDoc.Dispose();
            mypdfDoc = new PDFLibNet.PDFWrapper();
            mypdfDoc.UseMuPDF = true;
            if (!File.Exists(cfile))
                return false;
            return mypdfDoc.LoadPDF(cfile);
        }

        public BitmapSource GetBitmap(Rect r, double Resolution)
        {
            if (mypdfDoc != null)
            {
                if (r.Width <= 0 || r.Height <= 0) // TODO: this should not be necessary
                    return null;
                Bitmap tmp = mypdfDoc.Pages[1].GetBitmap(72 * Resolution / Consts.ptspertikzunit);
                tmp.Save("temptem.bmp");
                System.Drawing.Rectangle rect = new System.Drawing.Rectangle(0, tmp.Height - Convert.ToInt32(r.Height * Resolution), Convert.ToInt32(r.Width * Resolution), Convert.ToInt32(r.Height * Resolution));
                Bitmap b = tmp.Clone(rect, tmp.PixelFormat);
                b.Save("temptemp.bmp");
                
                b.MakeTransparent(System.Drawing.Color.White);
                b.MakeTransparent(System.Drawing.Color.FromArgb(255, 253, 253, 253));
                b.MakeTransparent(System.Drawing.Color.FromArgb(255, 254, 254, 254));
                BitmapSource ret = loadBitmap(b);
                //b.Save("temptemp.bmp");
                b.Dispose();
                tmp.Dispose();
                return ret;
                //GC.Collect();
            }
            else return null;
        }
        public BitmapSource GetBitmap(double Resolution, bool Transparent = true)
        {
            if (mypdfDoc != null && mypdfDoc.PageCount >0)
            {
 
                Bitmap b = mypdfDoc.Pages[1].GetBitmap(72 * Resolution / Consts.ptspertikzunit);
                if (Transparent)
                {
                    b.MakeTransparent(System.Drawing.Color.White);
                    b.MakeTransparent(System.Drawing.Color.FromArgb(255, 253, 253, 253));
                    b.MakeTransparent(System.Drawing.Color.FromArgb(255, 254, 254, 254));
                }
                BitmapSource ret = loadBitmap(b);
                b.Dispose();
                return ret;
                //GC.Collect();
            }
            else return null;
        }

        public void SaveBmp(string cFile, double Resolution)
        {
            if (mypdfDoc != null)
            {

                Bitmap b = mypdfDoc.Pages[1].GetBitmap(72 * Resolution / Consts.ptspertikzunit);
                b.MakeTransparent(System.Drawing.Color.White);
                b.MakeTransparent(System.Drawing.Color.FromArgb(255, 253, 253, 253));
                b.MakeTransparent(System.Drawing.Color.FromArgb(255, 254, 254, 254));
                b.Save(cFile);
                b.Dispose();
                //GC.Collect();
            }            
        }

        [DllImport("gdi32")]
        static extern int DeleteObject(IntPtr o);
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
                DeleteObject(ip);
            }

            return bs;
        }

        ~PdfToBmp()
        {
            //if (mypdfDoc != null)
              //  mypdfDoc.Dispose();
        }
    }
}
