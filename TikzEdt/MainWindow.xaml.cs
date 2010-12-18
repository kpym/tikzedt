using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.CodeCompletion;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace TikzEdt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static RoutedCommand CompileCommand = new RoutedCommand();
        public static RoutedCommand FindNextCommand = new RoutedCommand();
        public static RoutedCommand CommentCommand = new RoutedCommand();
        public static RoutedCommand UnCommentCommand = new RoutedCommand();
        public static RoutedCommand ShowCodeCompletionsCommand = new RoutedCommand();

        // the current file
        private string _CurFile= Consts.defaultCurFile;
        string CurFile
        {
            get { return _CurFile; }
            set
            {
                _CurFile = value;
                Title = "TikzEdt: " + _CurFile;
                if (ChangesMade)
                    Title += "*";
                // Add to MRU
                if (_CurFile != Consts.defaultCurFile)
                    RecentFileList.InsertFile(_CurFile);
            }
        }
        // indicates whether changes (that need to be saved) are made to the current file
        private bool _ChangesMade = false;
        bool ChangesMade
        {
            get { return _ChangesMade; }
            set
            {
                _ChangesMade = value;
                CurFile = CurFile;
            }
        }


        private Rect _currentBB = new Rect(Properties.Settings.Default.BB_Std_X, Properties.Settings.Default.BB_Std_Y, Properties.Settings.Default.BB_Std_W, Properties.Settings.Default.BB_Std_H);
        Rect currentBB
        {
            get { return _currentBB; }
            set
            {
                _currentBB = value;
                txtBBX.Text = currentBB.X.ToString();
                txtBBY.Text = currentBB.Y.ToString();
                txtBBW.Text = currentBB.Width.ToString();
                txtBBH.Text = currentBB.Height.ToString();
            }
        }

        OpenFileDialog ofd = new OpenFileDialog();
        SaveFileDialog sfd = new SaveFileDialog();
        FindReplaceDialog FindDialog = new FindReplaceDialog();
        CodeCompleter codeCompleter = new CodeCompleter();

        public static bool isLoaded = false;
        public static bool isClosing = false;
        public MainWindow()
        {
            InitializeComponent();

            //make sure that double to string is converted with decimal point (not comma!)       
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");

            CommandBinding CommentCommandBinding = new CommandBinding(CommentCommand, CommentCommandHandler, AlwaysTrue);
            CommandBinding UnCommentCommandBinding = new CommandBinding(UnCommentCommand, UnCommentCommandHandler, AlwaysTrue);
            CommandBinding FindNextCommandBinding = new CommandBinding(FindNextCommand, FindNextCommandHandler, AlwaysTrue);
            CommandBinding ShowCodeCompletionsCommandBinding = new CommandBinding(ShowCodeCompletionsCommand, ShowCodeCompletionsCommandHandler, AlwaysTrue);
            //CommandBinding CompileCommandBinding = new CommandBinding(CompileCommand, CompileCommandHandler, AlwaysTrue);     

            pdfOverlay1.rasterizer = rasterControl1;
            FindDialog.txtCode = txtCode;

            // in the constructor:
            txtCode.TextArea.TextEntering += textEditor_TextArea_TextEntering;
            txtCode.TextArea.TextEntered += textEditor_TextArea_TextEntered;

            ofd.CheckFileExists = true;
            ofd.ValidateNames = true;
            ofd.Filter = "Tex Files|*.tex"+
             "|All Files|*.*";
            sfd.Filter = "Tex Files|*.tex"+
             "|All Files|*.*";
            sfd.OverwritePrompt = true;
            sfd.ValidateNames = true;

            RecentFileList.MenuClick += (s, e) => { if (TryDisposeFile()) LoadFile(e.Filepath); };

            //cmbGrid.SelectedIndex = 4;
        }

        CompletionWindow completionWindow;

        void textEditor_TextArea_TextEntered(object sender, TextCompositionEventArgs e)
        {
            if (codeCompleter.CompletionTriggers.Contains(e.Text))
            {
                ShowCodeCompletionsCommand.Execute(null, this);
            }
        }

        static Regex _beginRegex = new Regex(@"^\\begin\{(?<tag>\s*\w*\s*)\}(?<content>.*)$", RegexOptions.Compiled);
        void textEditor_TextArea_TextEntering(object sender, TextCompositionEventArgs e)
        {
            if (e.Text == "\n")
            {
                if (Properties.Settings.Default.Editor_CompleteBegins)
                {
                    ICSharpCode.AvalonEdit.Document.DocumentLine l = txtCode.Document.GetLineByOffset(txtCode.CaretOffset);
                    //if (l.LineNumber > 0) //todo 1?
                    {
                        string s = txtCode.Document.GetText(l.Offset, l.Length).Trim();                        
                        Match m = _beginRegex.Match(s);
                        if (m.Success && m.Groups["tag"] != null && m.Groups["content"] != null)
                        {
                            string tag = m.Groups["tag"].Value, content = m.Groups["content"].Value;
                            int cp = txtCode.CaretOffset;
                            txtCode.Document.Insert(l.Offset + l.Length, "\r\n\\end{" + tag + "}");
                            txtCode.CaretOffset = cp;
                        }
                    }

                }
            }

            if (e.Text.Length > 0 && completionWindow != null)
            {
                if (!char.IsLetterOrDigit(e.Text[0]))
                {
                    // Whenever a non-letter is typed while the completion window is open,
                    // insert the currently selected element.
                    completionWindow.CompletionList.RequestInsertion(e);
                }
            }
            // Do not set e.Handled=true.
            // We still want to insert the character that was typed.
        }

        void AddStatusLine(string text, bool lError = false)
        {
            Paragraph p = new Paragraph();
            if (lError)
                p.Foreground = Brushes.Red;
            p.Margin = new Thickness(0);
            p.Inlines.Add(new Run(text));
            txtStatus.Document.Blocks.Add(p);
            EditingCommands.MoveToDocumentEnd.Execute(null, txtStatus);
            txtStatus.ScrollToEnd();
        }

        private void tikzDisplay1_OnCompileEvent(string Message, TikzDisplay.CompileEventType type)
        {
            AddStatusLine(Message, type == TikzDisplay.CompileEventType.Error);            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AddStatusLine("Welcome to TikzEdt");
            AddStatusLine("Help/feedback/feature requests/error reports are welcome");

            FrameworkElement overflowGrid = tlbMode.Template.FindName("OverflowGrid", tlbMode) as FrameworkElement;
            if (overflowGrid != null)
                overflowGrid.Visibility = Visibility.Collapsed;
            overflowGrid = tlbTools.Template.FindName("OverflowGrid", tlbTools) as FrameworkElement;
            if (overflowGrid != null)
                overflowGrid.Visibility = Visibility.Collapsed;
            overflowGrid = tlbZoom.Template.FindName("OverflowGrid", tlbZoom) as FrameworkElement;
            if (overflowGrid != null)
                overflowGrid.Visibility = Visibility.Collapsed;
            overflowGrid = tlbBB.Template.FindName("OverflowGrid", tlbBB) as FrameworkElement;
            if (overflowGrid != null)
                overflowGrid.Visibility = Visibility.Collapsed;
            overflowGrid = tlbMain.Template.FindName("OverflowGrid", tlbMain) as FrameworkElement;
            if (overflowGrid != null)
                overflowGrid.Visibility = Visibility.Collapsed;
            overflowGrid = tlbGrid.Template.FindName("OverflowGrid", tlbGrid) as FrameworkElement;
            if (overflowGrid != null)
                overflowGrid.Visibility = Visibility.Collapsed;

            //cmbGrid.SelectedIndex = 4;

            if (!File.Exists(Consts.cSyntaxFile))
            {
                AddStatusLine("Syntax definitions not found");
            } else{
                XmlReader r = new XmlTextReader(Consts.cSyntaxFile);
                txtCode.SyntaxHighlighting = HighlightingLoader.Load(r,null);  //HighlightingManager.Instance..GetDefinition("C#");
                r.Close();
            }

            codeCompleter.LoadCompletions(Consts.cCompletionsFile);

            isLoaded = true;
            //txtRadialOffset.Text = txtRadialOffset.Text;
            //txtRadialSteps.Text = txtRadialSteps.Text;

            // Open a new file 
            ApplicationCommands.New.Execute(null, this);
        }

        /// <summary>
        /// Checks whether the current code can be compiled,
        /// or whether we need to append pre-/postambles
        /// </summary>
        /// <returns></returns>
        bool IsStandalone()
        {
            return txtCode.Text.Contains("\\documentclass");    // hack
            //foreach (ICSharpCode.AvalonEdit.Document.DocumentLine l in txtCode.Document.Lines)
           // {
                
           // }
            //return false;
        }

        void DetermineBB(Tikz_ParseTree t)
        {
            Rect newBB = new Rect(Properties.Settings.Default.BB_Std_X, Properties.Settings.Default.BB_Std_Y, Properties.Settings.Default.BB_Std_W, Properties.Settings.Default.BB_Std_H);
            if (chkAutoBB.IsChecked == false)
            {
                // Parse
                double d;
                if (Double.TryParse(txtBBX.Text, out d))
                    if (d>-100 && d<100)
                        newBB.X=d;
                if (Double.TryParse(txtBBY.Text, out d))
                    if (d>-100 && d<100)
                        newBB.Y=d;
                if (Double.TryParse(txtBBW.Text, out d))
                    if (d>0 && d<100)
                        newBB.Width=d;
                if (Double.TryParse(txtBBH.Text, out d))
                    if (d>0 && d<100)
                        newBB.Height=d;
                currentBB = newBB;
            }
            else
            {
                if (t != null)
                {                                 
                    if (t.GetBB(out newBB))
                    {
                        newBB.Inflate(Properties.Settings.Default.BB_Margin, Properties.Settings.Default.BB_Margin);
                        currentBB = newBB;
                    }
                }
            }
        }
        private void UpdateStyleLists(Tikz_ParseTree t)
        {
            string oldsel = cmbNodeStyles.Text;
            cmbNodeStyles.Items.Clear();
            foreach (string s in t.styles.Keys)
            {
                cmbNodeStyles.Items.Add(s);
            }
            cmbNodeStyles.Text = oldsel;

            oldsel = cmbEdgeStyles.Text;
            cmbEdgeStyles.Items.Clear();
            foreach (string s in t.styles.Keys)
            {
                cmbEdgeStyles.Items.Add(s);
            }
            cmbEdgeStyles.Text = oldsel;
        }
        private void Recompile()
        {
            // Parse            
            if (chkFancyMode.IsChecked == true)
            {
                if (ProgrammaticTextChange)
                {
                    DetermineBB(pdfOverlay1.ParseTree);
                    pdfOverlay1.BB = currentBB;
                }
                else
                {
                    //try
                    //{
                    Tikz_ParseTree t = TikzParser.Parse(txtCode.Text);
                    DetermineBB(t);
                    UpdateStyleLists(t);
                    // Refresh overlay                    
                    pdfOverlay1.SetParseTree(t, currentBB);
                    //}
                    //catch (Exception e)
                    //{
                    //AddStatusLine("Couldn't parse code. " + e.Message, true);
                    // pdfOverlay1.SetParseTree(null, currentBB);
                    //}
                }
                // Always Compile tex
                tikzDisplay1.Compile(txtCode.Text, currentBB, IsStandalone());
                rasterControl1.BB = currentBB;
            }
            else
            {
                tikzDisplay1.Compile(txtCode.Text, new Rect(0,0,0,0), IsStandalone());
            }            
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            ChangesMade = true;

            Recompile();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (pdfOverlay1 != null)
                pdfOverlay1.Visibility = Visibility.Visible;
        }

        private void chkOverlay_Unchecked(object sender, RoutedEventArgs e)
        {
            if (pdfOverlay1 != null)
                pdfOverlay1.Visibility = Visibility.Hidden;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            tikzDisplay1.AbortCompilation();
        }

        private void Image_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        
        private void LoadFile(string cFile)
        {
            if (!File.Exists(cFile))
            {
                MessageBox.Show("Error: File not found: " + cFile, "File not found", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            StreamReader stream = new StreamReader(cFile);
            //try            {
                txtCode.Text = stream.ReadToEnd();
                CurFile = cFile;
                ChangesMade = false;
            /*}
            catch (Exception Ex)
            {
                string d = Ex.Message;
                MessageBox.Show("Error: Could not load " + cFile + ". Is it in the correct format?",
                    "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                stream.Close();
            }*/
        }
        private bool TryDisposeFile()
        {
            if (ChangesMade)
            {
                switch (MessageBox.Show("Save changes to " + CurFile + "?", "Changes need to be saved",
                    MessageBoxButton.YesNoCancel, MessageBoxImage.Warning))
                {
                    case (MessageBoxResult.Yes):
                        if (!SaveCurFile()) return false;
                        break;
                    case (MessageBoxResult.Cancel):
                        return false;
                }
            }
            return true;
        }
        private void OpenCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            if (ofd.ShowDialog() == true)
            {
                if (TryDisposeFile())
                    LoadFile(ofd.FileName);             
            }
        }

        bool SaveCurFile(bool saveas = false)
        {
            if (CurFile != Consts.defaultCurFile)
                sfd.FileName = CurFile;
            if (CurFile == Consts.defaultCurFile || saveas)
            {
                if (sfd.ShowDialog() != true)
                    return false;
                else CurFile = sfd.FileName;

            }

            StreamWriter wr = new StreamWriter(CurFile);
            wr.Write(txtCode.Text);
            wr.Close();
            ChangesMade = false;
            AddStatusLine("File saved to " + CurFile + ".");

            return true;
        }

        private void AlwaysTrue(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void SaveCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            SaveCurFile();
        }

        private void SaveAsCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            SaveCurFile(true);
        }

        private void NewCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            if (!TryDisposeFile())
                return;

            CurFile = Consts.defaultCurFile;
            txtCode.Text = "";
        }

        private void CompileCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            Recompile();
        }

        private void CompileClick(object sender, RoutedEventArgs e)
        {
            Recompile();
        }

        private void AbortCompilationClick(object sender, RoutedEventArgs e)
        {
            tikzDisplay1.AbortCompilation();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string s = Clipboard.GetText();
            simpletikzLexer lex = new simpletikzLexer(new ANTLRStringStream(s));
            CommonTokenStream tokens = new CommonTokenStream(lex);

            for (int i = 0; i < tokens.Count; i++)
            {
                string ds = tokens.Get(i).Text;
                ds = ds + "eee";
            }

            simpletikzParser parser = new simpletikzParser(tokens);

            //tikzgrammarParser.expr_return r =
            simpletikzParser.tikzpath_return ret = parser.tikzpath();
            
            //CommonTreeAdaptor adaptor = new CommonTreeAdaptor();
            CommonTree t = (CommonTree)ret.Tree;
            MessageBox.Show(printTree(t,0));

        }


        public string printTree(CommonTree t, int indent)
        {
            string s="";
            if ( t != null ) {
		        for ( int i = 0; i < indent; i++ )
			        s = s+"   ";

                string r = "";// s + t.ToString() + "\r\n";
                
                if (t.ChildCount >0)
		            foreach ( object o in t.Children ) {
			            r=r+s+o.ToString()+"\r\n" + printTree((CommonTree)o, indent+1);
                    }

                return r;
            }  else return "";
		}

        bool ProgrammaticTextChange = false;
        private void pdfOverlay1_OnModified(TikzParseItem sender, string oldtext)
        {
            // update code
            //ProgrammaticTextChange = true; 

            //txtCode.Text = pdfOverlay1.ParseTree.ToString();
            txtCode.Document.Replace(sender.StartPosition(), oldtext.Length, sender.ToString());

            //ProgrammaticTextChange = false; 
            //MessageBox.Show(pdfOverlay1.ParseTree.ToString());
        }

        private void CommentCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            string[] lines = txtCode.Text.Split(new char[] { '\n' }), newstr = new string[lines.Length];
            int curpos = 0, sels = txtCode.SelectionStart, sellength = txtCode.SelectionLength;
            for (int i = 0; i < lines.Length; i++)
            {
                if (curpos + lines[i].Length >= txtCode.SelectionStart && curpos <= txtCode.SelectionStart + txtCode.SelectionLength)
                {
                    newstr[i] = "% " + lines[i];
                    if (curpos <= txtCode.SelectionStart)
                        sels += 2;
                    else
                        sellength += 2;
                }
                else
                    newstr[i] = lines[i];
                curpos += lines[i].Length + 1;
            }

            txtCode.Text = String.Join("\n", newstr);
            // set selection
            txtCode.SelectionStart = sels;
            txtCode.SelectionLength = sellength;

            // Comment all currently selected lines //todo: nothing selected?          
            //string s =  txtCode.SelectedText.Replace("\n", "\n% ");
            //if (txtCode.SelectionStart == 0 || txtCode.Text[SelectionStart-1]=='\n')
            //    s= "% "+s;
            //txtCode.SelectedText = s;  
        }

        private void UnCommentCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            string[] lines = txtCode.Text.Split(new char[] { '\n' }), newstr = new string[lines.Length];
            int curpos = 0, sels = txtCode.SelectionStart, sellength = txtCode.SelectionLength;
            for (int i = 0; i < lines.Length; i++)
            {
                if (curpos + lines[i].Length >= txtCode.SelectionStart && curpos <= txtCode.SelectionStart + txtCode.SelectionLength)
                {
                    if (lines[i].StartsWith("% "))
                    {
                        newstr[i] = lines[i].Remove(0, 2);
                        if (curpos <= txtCode.SelectionStart)
                            sels -= 2;
                        else
                            sellength -= 2;
                    }
                    else if (lines[i].StartsWith("%"))
                    {
                        newstr[i] = lines[i].Remove(0, 1);
                        if (curpos <= txtCode.SelectionStart)
                            sels -= 1;
                        else
                            sellength -= 1;
                    }
                    else newstr[i] = lines[i];
                }
                else
                    newstr[i] = lines[i];
                curpos += lines[i].Length + 1;
            }

            txtCode.Text = String.Join("\n", newstr);
            // set selection
            txtCode.SelectionStart = sels;
            txtCode.SelectionLength = sellength;
        }

        private void cmbGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (cmbGrid.SelectedIndex >= 0 && rasterControl1 != null)
            //{
                //string c = (cmbGrid.SelectedItem as ComboBoxItem).Content;
            //    rasterControl1.GridWidth = Double.Parse((cmbGrid.SelectedItem as ComboBoxItem).Content.ToString());
            //}
        }
        private void cmbGridTextChanged(object sender, TextChangedEventArgs e)
        {
            double d;
            if (rasterControl1 != null && Double.TryParse(cmbGrid.Text, out d))
            {
                //string c = (cmbGrid.SelectedItem as ComboBoxItem).Content;
                if (d>=0 && d<100)
                    rasterControl1.GridWidth = d;
            }
        }
        

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            rasterControl1.Visibility = Visibility.Hidden;
        }

        private void rb1_Checked(object sender, RoutedEventArgs e)
        {
            if (pdfOverlay1 == null)
                return;
            if (sender == rbToolMove)
                pdfOverlay1.tool = PdfOverlay.ToolType.move;
            else if (sender == rbToolAddVert)
                pdfOverlay1.tool = PdfOverlay.ToolType.addvert;
            else if (sender == rbToolAddEdge)
                pdfOverlay1.tool = PdfOverlay.ToolType.addedge;
            else if (sender == rbToolAddPath)
                pdfOverlay1.tool = PdfOverlay.ToolType.addpath;
        }

        private void SnippetMenuClick(object sender, RoutedEventArgs e)
        {
            SnippetManager s = new SnippetManager();
            if (s.isSuccessfullyLoaded) // could stop loading due to not getting a lock
            {
                s.ShowDialog();
                // reload snippets
                snippetlist1.Reload();                
            }
        }

        GridLength oldwidth;
        private void cmdSnippets_Checked(object sender, RoutedEventArgs e)
        {
            if (LeftSplitterCol != null && cmdSnippets != null && cmdFiles != null && snippetlist1 != null)
            {
                if (sender == cmdFiles)
                {
                    cmdSnippets.IsChecked = false;
                    //snippetlist1.Visibility = System.Windows.Visibility.Hidden;
                }
                else if (sender == cmdSnippets)
                {
                    cmdFiles.IsChecked = false;
                    snippetlist1.Visibility = System.Windows.Visibility.Visible;
                }

                GridLengthConverter g = new GridLengthConverter();
                if (LeftSplitterCol.Width == (GridLength)g.ConvertFrom(0))
                {
                    LeftToolsCol.Width = oldwidth;
                    LeftSplitterCol.Width = (GridLength)g.ConvertFrom(3);
                }
            }
        }

        private void cmdSnippets_Unchecked(object sender, RoutedEventArgs e)
        {
            if (sender == cmdFiles)
            {
                //cmdSnippets.IsChecked = false;
                //snippetlist1.Visibility = System.Windows.Visibility.Hidden;
            }
            else if (sender == cmdSnippets)
            {
                //cmdFiles.IsChecked = false;
                snippetlist1.Visibility = System.Windows.Visibility.Hidden;
            }
            if (cmdFiles.IsChecked == false && cmdSnippets.IsChecked == false)
            {
                GridLengthConverter g = new GridLengthConverter();
                oldwidth = LeftToolsCol.Width;
                LeftToolsCol.Width = (GridLength)g.ConvertFrom(0);
                LeftSplitterCol.Width = (GridLength)g.ConvertFrom(0);                
            }
        }

        private void snippetlist1_OnInsert(string code, string dependencies)
        {
            //txtCode.BeginChange();
            //string s = txtCode.Text, a=s.Substring(0,txtCode.CaretOffset), b=s.Substring(txtCode.CaretOffset);
            //txtCode.Text = a + code + b;            
            //txtCode.EndChange();
            txtCode.Document.Insert(txtCode.CaretOffset, code);
            
        }

        private void cmbZoom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cmdZoomInClick(object sender, RoutedEventArgs e)
        {
            if (cmbZoom.SelectedIndex < cmbZoom.Items.Count - 1)            
                cmbZoom.SelectedIndex++;
        }

        private void cmdZoomOutClick(object sender, RoutedEventArgs e)
        {
            if (cmbZoom.SelectedIndex > 0)
                cmbZoom.SelectedIndex--;
        }

        private void cmbZoom_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }
        private void cmbZoomTextChanged(object sender, RoutedEventArgs e)
        {
            string s = cmbZoom.Text;
            s = s.Trim();
            if (s.EndsWith("%"))
                s = s.Remove(s.Length - 1);
            double d;
            if (Double.TryParse(s, out d))
            {
                if (d > 2 && d < 6000)
                {
                    double res = d / 100 * Consts.ptspertikzunit;
                    tikzDisplay1.Resolution = res;
                    rasterControl1.Resolution = res;
                    pdfOverlay1.Resolution = res;
                }
            }
        }

        private void SettingsMenuClick(object sender, RoutedEventArgs e)
        {
            SettingsDialog sd = new SettingsDialog();
            sd.ShowDialog();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TikzEdt.Properties.Settings.Default.Save();

            if (!TryDisposeFile())
                e.Cancel = true;
            else
            {
                // Set closing flag
                isClosing = true;
                FindDialog.txtCode = null;
                FindDialog.Close();
            }
        }

        private void TestClick(object sender, RoutedEventArgs e)
        {
            PDFLibNet.PDFWrapper p = new PDFLibNet.PDFWrapper();
            p.LoadPDF("testtight.pdf");

            System.Drawing.Bitmap b = p.Pages[1].GetBitmap(72);
            b.Save("testtight.bmp");
            b.Dispose();

            //int i = 5;
        }

        private void pdfOverlay1_BeginModify(object sender)
        {
            ProgrammaticTextChange = true;
            txtCode.Document.BeginUpdate();            
        }

        private void pdfOverlay1_EndModify(object sender)
        {
            txtCode.Document.EndUpdate();
            ProgrammaticTextChange = false;
        }

        private void TestUpdClick(object sender, RoutedEventArgs e)
        {
            pdfOverlay1.ParseTree.UpdateText();            
        }

        private void GenerateHeadersClick(object sender, RoutedEventArgs e)
        {
            Helper.GeneratePrecompiledHeaders();
        }

        private void chkAutoBB_Checked(object sender, RoutedEventArgs e)
        {
            if (isLoaded)
                Recompile();
        }

        private void chkFancyMode_Checked(object sender, RoutedEventArgs e)
        {
            if (isLoaded)
                Recompile();
        }

        private void Enscope_Click(object sender, RoutedEventArgs e)
        {
            if (txtCode.SelectionLength > 0)
                txtCode.Document.Replace(txtCode.SelectionStart, txtCode.SelectionLength,
                    "\\begin{scope}[]\r\n" + txtCode.SelectedText + "\r\n\\end{scope}");
            else
                txtCode.Document.Insert(txtCode.CaretOffset, "\\begin{scope}[]\r\n\r\n\\end{scope}");
        }

        private void pdfOverlay1_TryCreateNew(object sender, out bool allow)
        {
            if (txtCode.Text == "")
                allow = true;
            else
                allow = false;
        }

        private void txtRadialOffset_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (rasterControl1 == null)
                return;
            int i;
            if (Int32.TryParse(txtRadialOffset.Text, out i))
                rasterControl1.RadialOffsetInt = i;

        }

        private void txtRadialSteps_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (rasterControl1 == null)
                return;
            int i;
            if (Int32.TryParse(txtRadialSteps.Text, out i))
                if (i>0 && i< 1000)
                    rasterControl1.RadialSteps = (uint)i;
        }

        private void pdfOverlay1_JumpToSource(object sender)
        {
            TikzParseItem tpi = sender as TikzParseItem;
            int spos = tpi.StartPosition();
            txtCode.CaretOffset = spos;
            txtCode.SelectionStart = spos;
            txtCode.SelectionLength = tpi.ToString().Length;
            txtCode.ScrollToLine(txtCode.Document.GetLineByOffset(spos).LineNumber);
            txtCode.Focus();
        }

        private void pdfOverlay1_ToolChanged(object sender)
        {
            rbToolMove.IsChecked = (pdfOverlay1.tool == PdfOverlay.ToolType.move);
            rbToolAddVert.IsChecked = (pdfOverlay1.tool == PdfOverlay.ToolType.addvert);
            rbToolAddEdge.IsChecked = (pdfOverlay1.tool == PdfOverlay.ToolType.addedge);
            rbToolAddPath.IsChecked = (pdfOverlay1.tool == PdfOverlay.ToolType.addpath);
        }

        private void cmbZoom_LostFocus(object sender, RoutedEventArgs e)
        {
            // add a "%"
            double d;
            if (Double.TryParse(cmbZoom.Text, out d))
            {
                cmbZoom.Text = d.ToString() + " %";
            }
        }

        private void AboutClick(object sender, RoutedEventArgs e)
        {
            TikzEdtAbout ta = new TikzEdtAbout();
            ta.ShowDialog();
        }

        private void FindCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            FindDialog.tabMain.SelectedIndex = 0;
            FindDialog.Show();
        }

        private void ReplaceCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            FindDialog.tabMain.SelectedIndex = 1;
            FindDialog.Show();
        }

        private void HelpCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void ZoomoutCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void ZoominCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void FindNextCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            FindDialog.FindNext();
        }


        private void ShowCodeCompletionsCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            // Open code completion after the user has pressed dot:
            completionWindow = new CompletionWindow(txtCode.TextArea);
            IList<ICompletionData> data = completionWindow.CompletionList.CompletionData;
            codeCompleter.GetCompletions(txtCode.Document, txtCode.CaretOffset, data);
            completionWindow.Show();
            completionWindow.Closed += delegate
            {
                completionWindow = null;
            }; 
        }

        private void UndoCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            if (txtCode.CanUndo && e.Source != txtCode.TextArea)
                ApplicationCommands.Undo.Execute(e.Parameter, txtCode.TextArea);            
        }

        private void RedoCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            if (txtCode.CanRedo && e.Source != txtCode.TextArea)
                ApplicationCommands.Redo.Execute(e.Parameter, txtCode.TextArea);
        }

        private void UndoCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = txtCode.CanUndo;
        }

        private void RedoCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = txtCode.CanRedo;
        }

        private void tikzDisplay1_OnTexOutput(string Message)
        {
            // add tex output
            if (Message != "")
            {
                Paragraph p = new Paragraph();
                p.Margin = new Thickness(0);
                p.Inlines.Add(new Run(Message));
                txtTexout.Document.Blocks.Add(p);
                EditingCommands.MoveToDocumentEnd.Execute(null, txtTexout);
                txtTexout.ScrollToEnd();
            }
        }

    }
}
