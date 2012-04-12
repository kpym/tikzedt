/*
 * This class is derived from LatexRunner.java which is part of the Latex plugin Texclipse for Eclipse.
 * 
 * From LatexRunner.java:
 * Copyright (c) 2004-2005 by the TeXlapse Team.
 * All rights reserved. This program and the accompanying materials
 * are made available under the terms of the Eclipse Public License v1.0
 * which accompanies this distribution, and is available at
 * http://www.eclipse.org/legal/epl-v10.html
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.IO;


namespace TikzEdt
{
       
    /// <summary>
    /// StringTokenizer is a minimal port of Java's StringTokenizer class. Only here needed functions are implemented.
    /// </summary>
    public class StringTokenizer
    {
        private string str;
        private string splitter;        
        private int currentChar;

        public StringTokenizer(string Text, string Splitter)
        {
            str = Text;
            splitter = Splitter;
            currentChar = 0;            
        }

        public string nextToken()
        {
            int nextChar = str.IndexOf(splitter, currentChar);
            if (nextChar == -1)
            {
                bool b = hasMoreTokens();
                return " ";
            }
            string ret = str.Substring(currentChar, nextChar - currentChar);
            currentChar = nextChar + Environment.NewLine.Length;
            return ret;
        }
        public bool hasMoreTokens()
        {
            if (str.IndexOf(splitter, currentChar) == -1 || str=="")
                return false;
            else
                return true;
        }
    }

    public enum Severity { NOTICE, PARSERWARNING, WARNING, PARSERERROR, ERROR }; // the order is the inverse sort order in the error listbox

    public class TexOutputParser
    {
        /*public delegate void TexErrorHandler(object sender, TexError Error);
        public event TexErrorHandler OnTexError;*/

        /// <summary>
        /// Class that contains the data for the alarm event. Derives from System.EventArgs.   
        /// </summary>
        public class TexError : EventArgs
        {
            public String error;
            public string Message { get { return error; } set { error = value; } }
            public String causingSourceFile;
            public String SourceFileName
            {
                get
                {
                    /*System.Uri AbsoluteFilePath = new Uri(causingSourceFile);
                    System.Uri AbsoluteDirectory = new Uri(Environment.CurrentDirectory);
                    Uri relativeUri = AbsoluteDirectory.MakeRelativeUri(AbsoluteFilePath);
                    return relativeUri.ToString();*/

                    return System.IO.Path.GetFileName(causingSourceFile);
                    //return new Uri(causingSourceFile).MakeRelativeUri(new Uri(Environment.CurrentDirectory)).ToString(); 
                }
                set { error = causingSourceFile; }
            }
            int linenr;
            public int Line { get { return linenr; } set { linenr = value; } }
            int pos;
            public int Pos { get { return pos; } set { pos = value; } }                       
            private Severity _severity;
            public Severity severity { get { return _severity; } set { _severity = value; } }
            public bool IsFromParser { get { return severity == Severity.PARSERERROR || severity == Severity.PARSERWARNING; } }


            public bool inincludefile=false;  // tells whether the error occured in a file \input-ted (rather than in the main file)
        }

        public class ParseResult
        {
            public bool ErrorsFound;
            public IEnumerable<TexError> Errors; 
        }

 
        /// <summary>
        /// Private function that is called for each found problem in output of pdflatex when
        /// calling parseOutput(). addProblemMarker() fits the arguments into addProblemEventArgs
        /// so that addProblemEventHandler addProblem can be triggered. 
        /// </summary>
        private static void addProblemMarker(String error, String causingSourceFile, int linenr, Severity severity, TexCompiler.Job job, List<TexError> AddToThisList)
        {
           // if (OnTexError != null)
           // {
                TexError e = new TexError();
                e.error = error;
                e.causingSourceFile = causingSourceFile;
                e.Line = linenr;
                if (job != null)
                {
                    if (e.causingSourceFile == null)
                        e.inincludefile = true;
                    else
                        e.inincludefile = (String.Compare(e.causingSourceFile.Trim().Replace('/','\\'),
                                            System.IO.Path.GetFullPath(job.path), true) != 0);
                    if (!e.inincludefile && linenr > 0)
                    {                        
                        e.Line = job.TempFileLineToEditorLine(e.Line);                        
                    }
                    if (!e.inincludefile && e.causingSourceFile != null)
                    {
                        // trim preview file ending.
                        e.causingSourceFile = e.causingSourceFile.Trim();
                        if (e.causingSourceFile.EndsWith(Helper.GetPreviewFilename()+Helper.GetPreviewFilenameExt()))
                            e.causingSourceFile = e.SourceFileName.Substring(0, (e.SourceFileName.Length - Helper.GetPreviewFilename().Length - Helper.GetPreviewFilenameExt().Length));
                    }
                }
                e.Pos = -1;
                e.severity = severity;
                AddToThisList.Add(e);
         //       OnTexError(this, e, job);
         //   }
        }

        /// <summary>
        /// clears the current code
        /// </summary>
  //      public void Clear()
  //      {
  //          WholeOutput = "";
  //      }

  /*      public TexOutputParser()
        {
            parsingStack = new Stack<string>();
            parseNewOutput();
        }
        private void parseNewOutput()
        {
            parsingStack.Clear();
            alreadyShowError = false;
            citeNotfound = false;
            hasProblem = false;
            error = "";
            occurance = "";
            linenr = -1;
            severity = Severity.WARNING;
            errorsFound = false;
            WholeOutput = "";
        } */

        public static ParseResult parseOutput( string WholeOutput, TexCompiler.Job job)
        {
            List<TexError> ErrorList = new List<TexError>();
            ParseResult ret = new ParseResult() { Errors= ErrorList, ErrorsFound=false };

            //if WholeOutput is not complete, ignore it. However, this should NEVER happen.
            if (!WholeOutput.Contains("Transcript written on"))
            {
                ret.ErrorsFound = true;
                return ret;
            }

            Stack<String> parsingStack = new Stack<string>();
            bool alreadyShowError = false;
            bool citeNotfound = false;
            bool hasProblem = false;
            string error = "";
            string occurance = "";
            int linenr = -1;
            Severity severity = Severity.WARNING;
            bool errorsFound = false;
            

            WholeOutput = DebreakLines(WholeOutput);


            //take WholeOutput and use each line as token
            StringTokenizer st = new StringTokenizer(WholeOutput, Environment.NewLine);

            Regex LATEXERROR = new Regex("^! LaTeX Error: (.*)$");
            Regex LATEXCERROR = new Regex("^(.+?\\.\\w{3}):(\\d+): (.+)$");
            Regex TEXERROR = new Regex("^!\\s+(.*)$");            
            Regex FULLBOX = new Regex("^(?:Over|Under)full \\\\[hv]box .* at lines? (\\d+)-?-?(\\d+)?");
            Regex WARNING = new Regex("^.+[Ww]arning.*: (.*)$");
            Regex ATLINE = new Regex("^l\\.(\\d+)(.*)$");
            Regex ATLINE2 = new Regex(".* line (\\d+).*");
            Regex NOBIBFILE = new Regex("^No file .+\\.bbl\\.$");
            Regex NOTOCFILE = new Regex("^No file .+\\.toc\\.$");

            String line = "";
            while (st.hasMoreTokens())
            {
                line = st.nextToken();

                #region Skipped
                /* //This is assumed to be performed before adding lines to WholeOutput by calling addLine()
                //Add more lines if line length is a multiple of 79 and
                //it does not end with ...
                while (!line.endsWith("...") && st.hasMoreTokens()
                      && line.length() % MAX_LINE_LENGTH == 0)
                {
                    line = line + st.nextToken();
                }
                */
                #endregion 

                //not sure what this is good for
                line = line.Replace(" {2,}", " ").Trim();

                Match m = LATEXCERROR.Match(line);
                if (m.Success)
                {
                    //C-Style LaTeX error
                    addProblemMarker(m.Groups[3].Value, m.Groups[1].Value, Convert.ToInt32(m.Groups[2]), Severity.ERROR, job, ErrorList);
                    //Maybe parsingStack is empty...
                    if (parsingStack.Count == 0)
                    {
                        //Add the file to the stack
                        parsingStack.Push("(" + m.Groups[1]);
                    }
                    continue;
                }

                 m = TEXERROR.Match(line);
                if (m.Success && line.IndexOf("warning", StringComparison.InvariantCultureIgnoreCase) == -1)
                {
                    if (hasProblem)
                    {
                        // We have a not reported problem
                        addProblemMarker(error, occurance, linenr, severity, job, ErrorList);
                        linenr = -1;
                    }
                    hasProblem = true;
                    errorsFound = true;
                    severity = Severity.ERROR;
                    occurance = determineSourceFile(parsingStack);
                    Match m2 = LATEXERROR.Match(line);
                    if (m2.Success)
                    {
                        // LaTex error
                        error = m2.Groups[1].Value; ;


                        String part2 = st.nextToken().Trim();

                        if (part2 != "" && Char.IsLower(part2[0]))
                        {
                            error += ' ' + part2;
                        }
                        updateParsedFile(part2, job, parsingStack, ErrorList, ref alreadyShowError);
                        continue;
                    }
                    if (line.StartsWith("! Undefined control sequence."))
                    {
                        // Undefined Control Sequence
                        error = "Undefined control sequence: ";
                        continue;
                    }
                    m2 = WARNING.Match(line);
                    if (m2.Success)
                        severity = Severity.WARNING;
                    error = m.Groups[1].Value;
                    continue;
                }
                m = WARNING.Match(line);
                if (m.Success)
                {
                    if (hasProblem)
                    {
                        // We have a not reported problem
                        addProblemMarker(error, occurance, linenr, severity, job, ErrorList);
                        linenr = -1;
                        hasProblem = false;
                    }
                    if (line.IndexOf("Label(s) may have changed.") > -1)
                    {
                        // prepare to re-run latex
                        /*TexlipseProperties.setSessionProperty(resource.getProject(),
                                TexlipseProperties.SESSION_LATEX_RERUN, "true");*/
                        GlobalUI.AddStatusLine(null, "SHOULD RERUN LATEX.", true);
                        continue;
                    }
                    else if (line.IndexOf("There were undefined") > -1)
                    {
                        if (citeNotfound)
                        {
                            // prepare to run bibtex
                            /*TexlipseProperties.setSessionProperty(resource.getProject(),
                                    TexlipseProperties.SESSION_BIBTEX_RERUN, "true");*/
                            GlobalUI.AddStatusLine(null, "SHOULD RERUN BIBTEX.", true);
                        }
                        continue;
                    }

                    // Ignore undefined references or citations because they are
                    // found by the parser
                    if (line.IndexOf("Warning: Reference `") > -1)
                        continue;
                    if (line.IndexOf("Warning: Citation `") > -1)
                    {
                        citeNotfound = true;
                        continue;
                    }
                    severity = Severity.WARNING;
                    occurance = determineSourceFile(parsingStack);
                    hasProblem = true;
                    if (line.StartsWith("LaTeX Warning: ") || line.IndexOf("pdfTeX warning") != -1)
                    {
                        error = m.Groups[1].Value;
                        //Try to get the line number
                        Match pm = ATLINE2.Match(line);
                        if (pm.Success)
                        {
                            linenr = Convert.ToInt32(pm.Groups[1].Value);
                        }

                        String nextLine = st.nextToken().Replace(" {2,}", " ");
                        pm = ATLINE2.Match(nextLine);
                        if (pm.Success)
                        {
                            linenr = Convert.ToInt32(pm.Groups[1].Value);
                        }
                        updateParsedFile(nextLine, job, parsingStack, ErrorList, ref alreadyShowError);
                        error += nextLine;
                        if (linenr != -1)
                        {
                            addProblemMarker(line, occurance, linenr, severity, job, ErrorList);
                            hasProblem = false;
                            linenr = -1;
                        }
                        continue;
                    }
                    else
                    {
                        error = m.Groups[1].Value;
                        //Try to get the line number
                        Match pm = ATLINE2.Match(line);
                        if (pm.Success)
                        {
                            linenr = Convert.ToInt32((pm.Groups[1].Value));
                        }
                        continue;
                    }
                }
                m = FULLBOX.Match(line);
                if (m.Success)
                {
                    if (hasProblem)
                    {
                        // We have a not reported problem
                        addProblemMarker(error, occurance, linenr, severity, job, ErrorList);
                        linenr = -1;
                        hasProblem = false;
                    }
                    severity = Severity.WARNING;
                    occurance = determineSourceFile(parsingStack);
                    error = line;
                    linenr = Convert.ToInt32(m.Groups[1].Value);
                    addProblemMarker(line, occurance, linenr, severity, job, ErrorList);
                    hasProblem = false;
                    linenr = -1;
                    continue;
                }
                m = NOBIBFILE.Match(line);
                if (m.Success)
                {
                    // prepare to run bibtex
                    GlobalUI.AddStatusLine(null, "SHOULD RUN BIBTEX.", true);
                    continue;
                }
                m = NOTOCFILE.Match(line);
                if (m.Success)
                {
                    // prepare to re-run latex
                    GlobalUI.AddStatusLine(null, "SHOULD RERUN LATEX.", true);
                    continue;
                }
                m = ATLINE.Match(line);                
                if (hasProblem && m.Success)
                {
                    linenr = Convert.ToInt32(m.Groups[1].Value);
                    String part2 = st.nextToken();
                    int index = line.IndexOf(' ');
                    if (index > -1)
                    {
                        error += " " + line.Substring(index).Trim() + " (followed by: "
                                + part2.Trim() + ")";
                        addProblemMarker(error, occurance, linenr, severity, job, ErrorList);
                        linenr = -1;
                        hasProblem = false;
                        continue;
                    }
                }
                m = ATLINE2.Match(line);
                if (hasProblem && m.Success)
                {
                    linenr = Convert.ToInt32(m.Groups[1].Value);
                    addProblemMarker(error, occurance, linenr, severity, job, ErrorList);
                    linenr = -1;
                    hasProblem = false;
                    continue;
                }
                updateParsedFile(line, job, parsingStack, ErrorList, ref alreadyShowError);

            }

            if (hasProblem)
            {
                // We have a not reported problem
                
                  // do not add "==> Fatal error blabla " to error list (is not an error)
                  //addProblemMarker(error, occurance, linenr, severity);
                //hasProblem = false;
            }
            ret.ErrorsFound = errorsFound;
            return ret;
        }

        const int MAX_LINE_LENGTH = 79;
        /// <summary>
        /// Some lines in the pdflatex output are broken by "..." markers.
        /// Remove those.
        /// </summary>
        /// <param name="WholeOutput">The latex output</param>
        /// <returns>The latex output, with lines appropraitely joined together.</returns>
        private static string DebreakLines(string WholeOutput)
        {
            StringReader sr = new StringReader(WholeOutput);
            StringWriter sw = new StringWriter();
            string LineBuffer = "";
            string line;

            while ((line = sr.ReadLine()) != null)
            {

                string Message = line;

                if (LineBuffer != "")
                {
                    Message = LineBuffer + Message;
                    LineBuffer = "";
                }

                // add tex output
                if (Message != "")
                {
                    //Add more lines if line length is a multiple of 79 and
                    //it does not end with "...", '"', or ')'
                    //[These are the common line endings of lines with variable length]
                    if (!Message.EndsWith("...") && !Message.EndsWith("\"") && !Message.EndsWith(")")
                        && Message.Length % MAX_LINE_LENGTH == 0)
                    {
                        LineBuffer = Message;
                        // Message will be processed upon next call of this function.
                        continue;
                    }
                }

                sw.WriteLine(Message);
            }
            if (LineBuffer != "")
                sw.WriteLine(LineBuffer);

            return sw.ToString();
        }

        /**
         * Updates the stack that determines which file we are currently
         * parsing, so that errors can be annotated in the correct file. 
         * 
         * @param logLine A line from latex' output containing which file we are in
         */
        private static void updateParsedFile(String logLine, TexCompiler.Job job, Stack<string> parsingStack, List<TexError> ErrorList, ref bool alreadyShowError)
        {
            if (logLine.IndexOf('(') == -1 && logLine.IndexOf(')') == -1)
                return;
            for (int i = 0; i < logLine.Length; i++)
            {
                if (logLine[i] == '(')
                {
                    int j;
                    for (j = i + 1; j < logLine.Length
                            && isAllowedinName(logLine[j]); j++)
                        ;
                    parsingStack.Push(logLine.Substring(i, j-i).Trim());
                    i = j - 1;
                }
                else if (logLine[i] == ')' && !(parsingStack.Count == 0))
                {
                    parsingStack.Pop();
                }
                else if (logLine[i] == ')' && !alreadyShowError)
                {
                    alreadyShowError = true;
                    // There was a parsing error, this is very rare
                    string err = "Error while parsing the LaTeX output. " +
                            "Please consult the console output";
                    GlobalUI.AddStatusLine(null, err, true);
                    addProblemMarker(err, "file", 0, Severity.ERROR, job, ErrorList);
                }
            }
        }

        /**
         * Check if the character is allowed in a filename
         * @param c the character
         * @return true if the character is legal
         */
        private static bool isAllowedinName(char c)
        {
            if (c == '(' || c == ')' || c == '[')
                return false;
            else
                return true;
        }

        private static bool isValidName(String name)
        {
            //File must have a file ending
            int p = name.LastIndexOf('.');
            if (p < 0) return false;
            //File ending must be shorter than 9 characters
            if (name.Length - p > 10) return false;
            return true;
        }

        /// <summary>
        /// Determines the source file we are currently parsing.
        /// </summary>
        /// <returns>The filename or null if no file could be determined</returns>
        private static string determineSourceFile( Stack<string> parsingStack )
        {
            int i = parsingStack.Count - 1;
            //creating a new stack reverses the order!
            Stack<String> tempStack = new Stack<string>(parsingStack);
            //so reverse it again!
            tempStack = new Stack<string>(tempStack);
            while (i >= 0)
            {
                //ORI: String fileName = parsingStack.get(i).substring(1);
                //However, C# does not support Stack.get()
                String fileName = tempStack.Pop().Substring(1);
                //Remove "
                if (fileName.StartsWith("\"") && fileName.EndsWith("\""))
                {
                    fileName = fileName.Substring(1, fileName.Length - 2);
                }
                if (isValidName(fileName)) return fileName;
                i--;
            }
            return null;
        }

    }
}
