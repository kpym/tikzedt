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
using ICSharpCode.AvalonEdit.Document;
using System.Xml;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;
using System.IO;
using System.Text.RegularExpressions;
using ICSharpCode.AvalonEdit.CodeCompletion;


namespace TikzEdt.Editor
{
    /// <summary>
    /// Interaction logic for TextEditorEx.xaml
    /// </summary>
    public class TextEditorEx : TextEditor
    {
        public static readonly DependencyProperty Document2Property = DependencyProperty.Register("Document2",
            typeof(TextDocument), typeof(TextEditorEx), 
            new PropertyMetadata(null, new PropertyChangedCallback(OnDocument2Changed)));

        static void OnDocument2Changed(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            (sender as TextEditorEx).Document =  (sender as TextEditorEx).Document2;
        }
        /// <summary>
        /// This property is solely for binding, a hack to circumvent a binding bug in TextEditor.
        /// One-Way bind to this, but use Document property otherwise 
        /// </summary>
        public TextDocument Document2 { 
            get{return (TextDocument)GetValue(Document2Property);}  
            set { SetValue(Document2Property, value); } 
        }

        public static readonly DependencyProperty HDFileProperty = DependencyProperty.Register("HDFile",
            typeof(string), typeof(TextEditorEx),
            new PropertyMetadata(null, new PropertyChangedCallback(OnHDFileChanged)));
        static void OnHDFileChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            if (System.ComponentModel.DesignerProperties.GetIsInDesignMode(sender))
                return;
            
            string cFile = (sender as TextEditorEx).HDFile;
            if (File.Exists(cFile))
            {
                XmlReader r = new XmlTextReader(cFile);
                (sender as TextEditorEx).SyntaxHighlighting = HighlightingLoader.Load(r, null);  //HighlightingManager.Instance..GetDefinition("C#");
                r.Close();
            }
            else (sender as TextEditorEx).SyntaxHighlighting = null;
        }
        /// <summary>
        /// Indicates the .xshd file that contains the syntax highlighting definitions.
        /// </summary>
        public string HDFile
        {
            get { return (string)GetValue(HDFileProperty); }
            set { SetValue(HDFileProperty, value); }
        }

        public static readonly DependencyProperty CompletionsFileProperty = DependencyProperty.Register("CompletionsFile",
             typeof(string), typeof(TextEditorEx),
             new PropertyMetadata(null, new PropertyChangedCallback(OnCompletionsFileChanged)));
        static void OnCompletionsFileChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            if (System.ComponentModel.DesignerProperties.GetIsInDesignMode(sender))
                return;
            (sender as TextEditorEx).codeCompleter.LoadCompletions((sender as TextEditorEx).CompletionsFile);
        }



        /// <summary>
        /// Enables / disables the find/replace dialog on CTRL+F
        /// </summary>
   /*     public bool UseMultiDocumentFindDialog
        {
            get { return (bool)GetValue(UseMultiDocumentFindDialogProperty); }
            set { SetValue(UseMultiDocumentFindDialogProperty, value); }
        }

        // Using a DependencyProperty as the backing store for EnableFind.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UseMultiDocumentFindDialogProperty =
            DependencyProperty.Register("UseMultiDocumentFindDialog", typeof(bool), typeof(TextEditorEx), new UIPropertyMetadata(true, OnUseMultiDocumentFindDialogPropertyChanged));
        static void OnUseMultiDocumentFindDialogPropertyChanged(DependencyObject s, DependencyPropertyChangedEventArgs e)
        {
            // register/unregister with global find dialog
            if ((bool)e.NewValue)            
                FindReplaceDialog.Editors.Add(s as TextEditor);
            else
                FindReplaceDialog.Editors.Remove(s as TextEditor);
        }
        */
        
        /// <summary>
        /// Indicates the .xml file that contains the code completions.
        /// </summary>
        public string CompletionsFile
        {
            get { return (string)GetValue(CompletionsFileProperty); }
            set { SetValue(CompletionsFileProperty, value); }
        }

        protected CodeCompleter codeCompleter = new CodeCompleter();

        #region commands
        public static RoutedCommand ShowCodeCompletionsCommand = new RoutedCommand();
        #endregion


        public TextEditorEx()
        {
            if (Document2 != null)
                Document = Document2;

            this.CommandBindings.Add( new CommandBinding(ShowCodeCompletionsCommand, ShowCodeCompletionsCommandHandler, AlwaysTrue) );
            this.InputBindings.Add(new KeyBinding(ShowCodeCompletionsCommand, new KeyGesture(Key.Space, ModifierKeys.Control)));
         //   this.CommandBindings.Add(new CommandBinding(ApplicationCommands.Find, FindCommandHandler));
         //   this.CommandBindings.Add(new CommandBinding(ApplicationCommands.Replace, ReplaceCommandHandler));
         //   this.CommandBindings.Add(new CommandBinding(NavigationCommands.Search, FindNextCommandHandler));
            
            TextArea.TextEntering += textEditor_TextArea_TextEntering;
            TextArea.TextEntered += textEditor_TextArea_TextEntered;

            Unloaded += new RoutedEventHandler(TextEditorEx_Unloaded);

            //CommandBinding FindBinding = new CommandBinding(ApplicationCommands.Find, FindCommandHandler, AlwaysTrue); 
            //EnsureFindDialogExists();
            //FindDialog.ShowAsFind();
        }

        void TextEditorEx_Unloaded(object sender, RoutedEventArgs e)
        {
           // if (UseMultiDocumentFindDialog)
           //     FindReplaceDialog.Editors.Remove(this);
        }

        static Regex _beginRegex = new Regex(@"^\\begin\{(?<tag>\s*\w*\s*)\}(?<content>.*)$", RegexOptions.Compiled);
        void textEditor_TextArea_TextEntering(object sender, TextCompositionEventArgs e)
        {
            // The following code auto-completes \begin{something} +<return> by inserting \end{something}
            // This autocompletion can be turned off in the settings
            if (e.Text == "\n")
            {
                if (Properties.Settings.Default.Editor_CompleteBegins)
                {
                    ICSharpCode.AvalonEdit.Document.DocumentLine l = Document.GetLineByOffset(CaretOffset);
                    //if (l.LineNumber > 0) //todo 1?
                    {
                        //get current line
                        string s = Document.GetText(l.Offset, l.Length).Trim();
                        //and check if it contains \begin{
                        Match m = _beginRegex.Match(s);
                        if (m.Success && m.Groups["tag"] != null && m.Groups["content"] != null)
                        {
                            string tag = m.Groups["tag"].Value, content = m.Groups["content"].Value;
                            int cp = CaretOffset;
                            string insert = "\\end{" + tag + "}";

                            //only insert if document does not already hold the corresponding \end{}
                            if (Text.IndexOf(insert, cp) == -1)
                            {
                                Document.Insert(l.Offset + l.Length, "\r\n" + insert);
                                CaretOffset = cp;
                            }
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

        CompletionWindow completionWindow;

        void textEditor_TextArea_TextEntered(object sender, TextCompositionEventArgs e)
        {
            if (codeCompleter.CompletionTriggers.Contains(e.Text))
            {
                ShowCodeCompletionsCommand.Execute(null, this);
            }
        }

        private void AlwaysTrue(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void ShowCodeCompletionsCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            // Open code completion window
            completionWindow = new CompletionWindow(TextArea);
            IList<ICompletionData> data = completionWindow.CompletionList.CompletionData;
            codeCompleter.GetCompletions(Document, CaretOffset, data);
            // use the word at current cursor position to filter the list 
            // (i.e., if we type bla<CTRL+SPACE>, the list should be filtered by bla
            int LineStartOffset = Document.GetLineByOffset(CaretOffset).Offset;
            string curLineToCursor = Document.GetText(LineStartOffset, CaretOffset - LineStartOffset);
            string[] words = Regex.Split(curLineToCursor, @"\W+"); // split at non-word characters
            if (words.Length > 0 && words.Last() != "")
            {
                completionWindow.CompletionList.SelectItem(words.Last());
                completionWindow.StartOffset = CaretOffset - words.Last().Length;
            }

            completionWindow.Show();
            completionWindow.Closed += delegate
            {
                completionWindow = null;
            };
        }

    /*    private void FindCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {            
            FindReplaceDialog.ShowAsFind(this);
        }
        private void FindNextCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            FindReplaceDialog.FindNext(this);
        }
        private void ReplaceCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            FindReplaceDialog.ShowAsReplace(this);
        }*/
    }
}
