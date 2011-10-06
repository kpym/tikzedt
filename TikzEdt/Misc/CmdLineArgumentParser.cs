using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Specialized;
using System.Collections;
using System.Resources;

namespace CLAParser
{
    /// <summary>
    /// <para>Class CLAParser provides everything for easy and fast handling of commandline arguments.</para>
    /// <para>Required and optional parameters can be defined, as well as the type of each parameter (e.g. bool, int, string).</para>
    /// <para>If commandline is correct, all arguments and their values can be accessed via a Dictionary interface.</para>
    /// <para>In case of an error, an exception is raised which explains the error.</para>
    /// <para>All output text can be nationalized by means of a ResourceManager.</para>
    /// </summary>
    class CLAParser : IEnumerable, IEnumerator
    {
        //private
        /// <summary>
        /// On parsing all parameters of command line are stored here
        /// if they match the requirements defined in WanntedParameters.
        /// </summary>
        private StringDictionary FoundParameters;
        private IEnumerator Enumerator;                
        ResourceManager CmdLineArgResourceManager;
        /// <summary>
        /// Stores all available information about a parameter defined by the programmer.
        /// </summary>
        private class ParameterDefintion
        {
            public ParameterDefintion(string ParameterName, ParamAllowType AllowType, ValueType ValueType, string ParameterHelp)
            {
                this.Parameter = ParameterName;
                this.AllowType = AllowType;
                this.ValueType = ValueType;
                this.Help = ParameterHelp;
            }           
            public string Parameter { get; set; }
            public ParamAllowType AllowType { get; set; }
            public ValueType ValueType { get; set; }
            public string Help { get; set; }
        }
        /// <summary>
        /// Collection of all optional and required parameters. This is the base for validation.
        /// </summary>
        private SortedDictionary<string, ParameterDefintion> WantedParameters;

        //public                                         
        /// <summary>
        /// Defines the type of possible commandline arguments.
        /// Note all arguments can either start with / or with -.
        /// </summary>
        public enum ValueType
        {
            /// <summary>
            /// <para>Parameter must be followed by a string,</para>
            /// examples: /p string, /p two string, /p "enclosed by quotes", /p "enclosed by single quotes"
            /// </summary>
            String,
            /// <summary>
            /// <para>Paramter can be followed by a string,</para>
            /// examples: /p, /p string
            /// </summary>
            OptionalString,
            /// <summary>
            /// <para>Parameter must be following be a whole number. Note: Negativ numbers must be quoted!</para>
            /// Examples: /p 12, /p "-100"
            /// </summary>
            Int,
            /// <summary>
            /// <para>Parameter can be followed by a whole number. Note: Negativ numbers must be quoted!</para>
            /// <para>If no number is specified it will be interpreted as 0.</para>
            /// Examples: /p, /p 12, /p "-100"
            /// </summary>
            OptionalInt, 
            /// <summary>
            /// <para>Parameter is a switch. It can be defined or not.</para>
            /// <para>Note: If AllowType is set to Required, this parameter kind does not make much sense!</para>
            /// Examples: program.exe, program.exe /p
            /// </summary>
            Bool,
            /// <summary>
            /// <para>Parameter can be used many times, however they must not be a value defined.</para>
            /// <para>The number of times of occurances is count (/p /p /p will return "3").</para>
            /// <para>Note: If AllowType is set to Required, switch must appear at least once!</para>
            /// Examples: program.exe, program.exe /p, program.exe /p /p /p /p
            /// </summary>
            MultipleBool,
            /// <summary>
            /// <para>Parameter can be followed by several whole numbers.</para>
            /// <para>If AllowType is set to Required, at least one number must be specified.</para>
            /// <para>Note: Inclusing a negativ number requires quoting the series of numbers.</para>
            /// Examples: /p 1, /p 1 2 3, /p "0 1 -1 2 -2"
            /// </summary>
            MultipleInts
        };
        /// <summary>
        /// Specifies wether the parameter has to be supplied or wether it is optional.
        /// </summary>
        public enum ParamAllowType { Optional, Required };
        /// <summary>
        /// <para>Additional paramters are those not defined by the programmers using the Parameter() function.</para>
        /// <para>By default this variable is false, thus causing an exception if the user specifies an undefined paramter,</para>
        /// <para>e.g. program.exe /undefined_parameter value_5</para>
        /// </summary>
        public bool AllowAdditionalParameters { get; set; }
        /// <summary>
        /// <para>ParameterPrefix specifies the prefix for all parameters. It is just used by</para>
        /// <para>GetUsage() and GetParameterInfo(), not the Parse(). [Parse always accepts / and -]</para>
        /// <para>By default this variable is set to /</para>
        /// </summary>
        public string ParameterPrefix { get; set; }
        /// <summary>
        /// <para>Retrieve a parameter value if it exists.</para>
        /// <para>Remember: program.exe /parameter value.</para>
        /// <para>Note: Function Parse() must be called before!</para>
        /// </summary>
        /// <param name="Param">Specifies the parameter</param>
        /// <returns>The corresponding value, or null if the is no such parameter,
        /// or if Parse() was not called yet.</returns> 
        public string this[string Param]
        {
            get
            {
                if (FoundParameters == null) return null;
                else return (FoundParameters[Param]);
            }
        }

        /// <summary>
        /// <para>Class CLAParser provides everything for easy and fast handling of commandline arguments.</para>
        /// <para>Usage:</para>
        /// <para>1) Create an instance of CLAParser by calling this constructor.</para>
        /// <para>2) Define parameters by calling Parameter() as often as needed.</para>
        /// <para>3) Optionally: Set variables such as AllowAdditionalParameters and ParameterPrefix.</para>
        /// <para>4) Call Parse(), catch all CmdLineArgumentExceptions, and show those to user.</para>
        /// <para>5) Call GetUsage() and GetParameterInfo() to create information about using commandline arguments.</para>
        /// </summary>
        /// <param name="NamespaceOfResX">Pass the name of the default namespace (usually the namespace of main code file Program.cs)<para>[This is necessary so that CLAParser can find its resource files (CmdLineArgumentParserRes.resx, CmdLineArgumentParserRes.de-DE.resx, ...)]</para></param>
        public CLAParser(string NamespaceOfResX)
        {            
            CmdLineArgResourceManager = new ResourceManager(NamespaceOfResX + ".CmdLineArgumentParserRes", this.GetType().Assembly);            

            FoundParameters = new StringDictionary();
            WantedParameters = new SortedDictionary<string, ParameterDefintion>(StringComparer.InvariantCultureIgnoreCase);
            Enumerator = FoundParameters.GetEnumerator();

            ParameterPrefix = "/";
            AllowAdditionalParameters = false;                       
        }
        
        /// <summary>
        /// <para>Defines parameters which program understands.</para>
        /// <para>Parameter() can be called as often as required.</para>
        /// <para>Information passed to CLAParser by Parameter() is later used by Parse(), GetUsage(), GetParamaterInfo()</para>
        /// </summary>
        /// <param name="AllowType">Choose parameter to be either as optional or required.</param>
        /// <param name="ParameterName">Name of the parameter (everything behind / )</param>
        /// <param name="ValueType">Defines valid values for the parameter.</param>
        /// <param name="ParameterHelp">Information about the parameter. This string will later be used by GetParameterInfo().</param>
        public void Parameter(ParamAllowType AllowType, string ParameterName, ValueType ValueType, string ParameterHelp)
        {
            //for the first value without parameter name only type string is accepted.
            //this is supposed to be a development exception which needs no i18n.
            if (ParameterName == "" && ValueType != ValueType.String)
                throw new Exception("For the first value (without parameter name) only type ValueType.String is accepted! ");
            ParameterDefintion Param = new ParameterDefintion(ParameterName, AllowType, ValueType, ParameterHelp);
            WantedParameters.Add(Param.Parameter, Param);           
        }
        
        /// <summary>
        /// <para>Starts the parsing process. Throws CmdLineArgumentExceptions in case of errors.</para>
        /// <para>Afterwards use the enumerator or the dictionary interface to access the found paramters and their values.</para>
        /// </summary>
        /// <param name="ArgumentLine">Argument line passed via command line to the program.</param>        
        private void Parse(string ArgumentLine)
        {
            //pure: ^[\s]*(?<unknownvalues>("[^"]*")|('[^']*')|[^"'/-]*|[^ ]*?)?([\s]+[/-](?<name>[^\s-/:=]+)([:=]?)([\s]*)(?<value>("[^"]*")|('[^']*')|([\s]*[^/-][^\s]+[\s]*)|([^/-]+)|)?([\s]*))*$
            string CorrectCmdLineRegEx = "^([\\s]*(?<unknownvalues>(\"[^\"]*\")|('[^']*')|([^\"'/-]*)|([^ ]*?)))?(([\\s]+[/-])(?<name>[^\\s-/:=]+)([:=]?)([\\s]*)(?<value>(\"[^\"]*\")|('[^']*')|([\\s]*[^/-][^\\s]+[\\s]*)|([^/-]+)|)?([\\s]*))*$";

            //start from beginning (^) and go to very end ($)
            //first optionally remove spaces [\s]* (this might not be necessary)
            //find optionally values without parameter. one of following:
            //  1) anything enclosed by double quotes ("[^"]*")
            //  2) anything enclosed by single quotes ('[^']*')
            //  3) anything that is not double or single quote nor slash nor minus [^"'/-]*
            //  4) or anything that contains no space [^ ]*?
            //find each parameter-value pair which seems to be okay. however, there might be unwanted some / or - signs in between.
            //each pair must start with a space followed by / or - ([\s]+[/-])
            //next is the parameter name which can be anything but spaces, -, /, or : ([^\\s-/:=])
            //next is the value which can either be one of following: (note: order matters!)
            //  -anything except " enclosed by " or anything except ' enclosed by ' ((\"[^\"]*\")|('[^']*'))
            //  -anything but spaces not starting with / nor -  optionally enclosed by spaces (([\\s]*[^/-][^\\s]+[\\s]*))
            //  -anything but / or - ([^/-]+).
            //the argument may end with spaces (([\\s]*))

            RegexOptions ro = new RegexOptions();
            ro = ro | RegexOptions.IgnoreCase; 
            ro = ro | RegexOptions.Multiline;            
            Regex ParseCmdLine = new Regex(CorrectCmdLineRegEx, ro);

            ///For test and debug purposes function Matches() is used which returns
            ///a MatchCollection. However, there should never be more than one entry.
            /*MatchCollection mc = ParseCmdLine.Matches(ArgumentLine.ToString());            
            if (mc.Count > 1)
                throw new Exception("Internal Exception: MatchCollection contains more than 1 entry!");
            foreach (Match m in mc)*/

            ///By default use Match() because in case of no match raising ExceptionSyntaxError would be skipped by Matches() and foreach.
            Match m = ParseCmdLine.Match(ArgumentLine.ToString());
            {

                if (m.Success == false)
                {
                    ///Regular expression did not match ArgumentLine. There might be two / or -.
                    ///Find out up to where ArgumentLine seems to be okay and raise an exception reporting the rest.
                    int LastCorrectPosition = FindMismatchReasonInRegex(CorrectCmdLineRegEx, ArgumentLine);
                    string ProbableErrorCause = ArgumentLine.Substring(LastCorrectPosition);
                    throw new ExceptionSyntaxError(String("Exception") + String("ExceptionSyntaxError") + ArgumentLine +
                                                  String("ExceptionSyntaxError2") + ProbableErrorCause + String("ExceptionSyntaxError3"));
                }
                else
                {
                    //RegEx match ArgumentLine, thus syntax is ok.

                    ///try to add values without parameters to FoundParameter using function
                    ///AddNewFoundParameter(). Before adding move quotes if any.
                    ///If those arguments are not allowed AddNewFoundParameter() raises an exception.
                    Group u_grp = m.Groups["unknownvalues"];
                    if (u_grp != null && u_grp.Value != string.Empty)
                    {
                        string unknown = u_grp.Value.Trim();
                        Regex Enclosed = new Regex("^(\".*\")|('.*')$");
                        Match e = Enclosed.Match(unknown);
                        if (e.Length != 0)
                            unknown = unknown.Substring(1, unknown.Length - 2);

                        AddNewFoundParameter("", unknown);
                    }

                    Group param_grp = m.Groups["name"];
                    Group value_grp = m.Groups["value"];
                    if (param_grp == null || value_grp == null)
                    {
                        //this should never happen.
                        throw new Exception("Internal Exception: Commandline parameter(s) incorrect.");
                    }

                    ///RegEx find always pairs of name- and value-group. their count should thus always match.
                    if (param_grp.Captures.Count != value_grp.Captures.Count)
                        throw new Exception("Internal Exception: Number of parameters and number of values is not equal. This should never happen.");

                    ///try to add each name-value-match to FoundParameters using AddNewFoundParameter() function.
                    ///if value is quoted, remove quotes before calling AddNewFoundParameter().
                    ///if value is of wrong type AddNewFoundParameter() throws an exception.
                    for (int i = 0; i < param_grp.Captures.Count; i++)
                    {
                        //if there are spaces at either side of value or param, trim those.
                        string value = value_grp.Captures[i].ToString().Trim();
                        string param = param_grp.Captures[i].ToString().Trim();
                        Regex Enclosed = new Regex("^(\".*\")|('.*')$");
                        Match e = Enclosed.Match(value);
                        if (e.Length != 0)
                            value = value.Substring(1, value.Length - 2);
                        AddNewFoundParameter(param, value);
                    }
                }
            }
            CheckRequiredParameters();
        }

        /// <summary>
        /// <para>Obsolete! Please use Parse(void) instead!</para>
        /// <para>Starts the parsing process using args. Note that args is preprocessed by .NET (e.g. quotes are removed).</para>
        /// <para>Using this function user has to escape quotes of quoted arguments (e.g. my.exe /param \"argument with spaces\")</para>
        /// <para>Afterwards use the enumerator or the dictionary interface to access the found paramters and their values.</para>
        /// </summary>
        /// <param name="Arguments">Arguments as string array passed via command line to the program.</param>
        public void Parse(string[] Arguments)
        {
            //NOTE: IF PARSING DOES NOT WORK AS EXPECTED, TRY TO ESCAPE QUOTES (ie. \" )
            //(from cmd.exe this seems to be necessary; instead single quotes could be used.)

            string mArgs = "";
            foreach (string s in Arguments)
                mArgs += s + " ";
            Parse(mArgs);
        }

        /// <summary>
        /// <para>Starts the parsing process. Throws CmdLineArgumentExceptions in case of errors.</para>
        /// <para>Afterwards use the enumerator or the dictionary interface to access the found paramters and their values.</para>
        /// </summary>
        public void Parse()
        {
            Parse(GetRawCommandlineArgs());
        }
        

        private void CheckRequiredParameters()
        {
            foreach (KeyValuePair<string, ParameterDefintion> Param in WantedParameters)
            {
                if (Param.Value.AllowType == ParamAllowType.Required)
                    if (FoundParameters.ContainsKey(Param.Key) == false)
                    {
                        if (Param.Key=="")
                            throw new ExceptionRequiredParameterMissing(String("Exception") + String("ExceptionRequiredFirstParameterMissing"));
                        else
                            throw new ExceptionRequiredParameterMissing(String("Exception") + String("ExceptionRequiredParameterMissing") + Param.Key + String("ExceptionRequiredParameterMissing2"));
                    }
            }
        }

        /// <summary>
        /// <para>Creates information for commandline usage for user.</para>        
        /// <para>To create this usage string information passed to CLAParser by function Parameter() is used.</para>
        /// <para>Format of returned string:</para>
        /// <para>&#182;</para>
        /// <para>Usage:</para>
        /// <para>name_of_program.exe /output_file &lt;string&gt; /character &lt;string&gt; /number &lt;int&gt; [/v [/v [...]]]</para>
        /// </summary>
        /// <returns></returns>
        public string GetUsage()
        {
            string Value = "";
            string Usage = String("Usage") + "\r\n" + System.IO.Path.GetFileName(Environment.GetCommandLineArgs()[0]);
            string OptionalBracketLeft = "";
            string OptionalBracketRight = "";
            string ParamString;

            for (int i = 0; i < 2; i++)
            {
                foreach (KeyValuePair<string, ParameterDefintion> Param in WantedParameters)
                {
                    //first take only required parameters then only optional
                    if (i == 0 && Param.Value.AllowType == ParamAllowType.Optional && Param.Key != "") continue;
                    else if (i == 1 && (Param.Value.AllowType == ParamAllowType.Required || Param.Key == "" && Param.Value.AllowType == ParamAllowType.Optional)) continue;

                    ParamString = Param.Key;
                    if (Param.Value.AllowType == ParamAllowType.Optional)
                    {
                        OptionalBracketLeft = "[";
                        OptionalBracketRight = "]";
                    }
                    //if this is the first parameter (ParamString == ""), we do not want this extra space.
                    string ExtraSpace = "";
                    string ShownParameterPrefix = "";
                    if (ParamString != "")
                    {
                        ExtraSpace = " ";
                        ShownParameterPrefix = ParameterPrefix;
                    }
                    switch (Param.Value.ValueType)
                    {
                        default:
                        case ValueType.Bool: Value = ""; break;
                        case ValueType.String: Value = /*no leading space!*/ "<" + String("String") + ">"; break;
                        case ValueType.Int: Value = " <" + String("Int") + ">"; break;
                        case ValueType.OptionalString: Value = " [<" + String("String") + ">]"; break;
                        case ValueType.OptionalInt: Value = " [<" + String("Int") + ">]"; break;
                        case ValueType.MultipleBool: Value = ""; ParamString += " [" + ParameterPrefix + ParamString + " [...]]"; break;
                        case ValueType.MultipleInts: Value = " [<" + String("Int") + "1> [<" + String("Int") + "2> [...]]]"; break;
                    }
                    Usage += " " + OptionalBracketLeft + ShownParameterPrefix + ParamString + ExtraSpace + Value + OptionalBracketRight + " ";
                }
            }
            return Usage;
        }

        /// <summary>
        /// <para>Creates information about each parameter which can be displayed to user as a help.</para>
        /// <para>To create this help string information passed to CLAParser by function Parameter() is used.</para>
        /// <para>Format of returned string:</para>
        /// <para>&#182;</para>
        /// <para>Parameters:</para>
        /// <para>Required:</para>
        /// <para>/output_file : Specify output file.</para>
        /// <para>/character   : Character to be written to output file.</para>
        /// <para>/number      : Number of times to write character to output file.</para>
        /// <para>&#182;</para>
        /// <para>Optional</para>
        /// <para>/v : Define (multiple) /v flag(s) for verbose output. Each /v increases verbosity more.</para>
        /// </summary>
        /// <returns>string with information about each parameter</returns>
        public string GetParameterInfo()
        {
            string ParameterInfo = String("Parameters") + "\r\n";

            for (int i = 0; i < 2; i++)
            {
                //find the longest parameter for this section (i==0->required, i==1->optional)
                int LongestParamter = 0;
                foreach (KeyValuePair<string, ParameterDefintion> Param in WantedParameters)
                {
                    String CurrentParam = Param.Key;
                    //for the first parameter we need a different representation.
                    if (CurrentParam == "") CurrentParam = /*"<" +*/ String("FirstParam") + ">";
                    if ((i == 0 && Param.Value.AllowType == ParamAllowType.Required) ||
                        (i == 1 && Param.Value.AllowType == ParamAllowType.Optional))
                        if (LongestParamter < CurrentParam.Length)
                            LongestParamter = CurrentParam.Length;
                }

                //Print section header only of there is at least one parameter.
                if (LongestParamter>0 && i == 0) ParameterInfo += String("Required") + "\r\n";
                else if (LongestParamter>0 && i == 1) ParameterInfo += "\r\n" + String("Optional") + "\r\n";

                foreach (KeyValuePair<string, ParameterDefintion> Param in WantedParameters)
                {
                    String CurrentParam = Param.Key;
                    String ShownParameterPrefix = ParameterPrefix;
                    int MakeUpForMissingSlash = 0;
                    //first take only required parameters then only optional
                    if (i == 0 && Param.Value.AllowType == ParamAllowType.Optional) continue;
                    else if (i == 1 && Param.Value.AllowType == ParamAllowType.Required) continue;
                    //for the first parameter we need a different representation.
                    if (CurrentParam == "")
                    {
                        CurrentParam = "<" + String("FirstParam") + ">";
                        ShownParameterPrefix = "";
                        MakeUpForMissingSlash = 1;
                    }
                    ParameterInfo += ShownParameterPrefix + CurrentParam + new string(' ', MakeUpForMissingSlash + LongestParamter - CurrentParam.Length) + " : " + Param.Value.Help + "\r\n";
                }
            }                        
            return ParameterInfo;
        }

        /* Needed since Implementing IEnumerable*/
        /// <summary>
        /// Returns a enumerator which walks through the dictionary of found parameters.
        /// </summary>
        /// <returns>enumerator of dictionary of found parameters</returns>
        public IEnumerator GetEnumerator()
        {
            Enumerator = FoundParameters.GetEnumerator();
            return Enumerator;
        }

        /* Needed since Implementing IEnumerator*/
        /// <summary>
        /// Sets the enumerator to the next found parameter.
        /// </summary>
        /// <returns>true if there is a next found parameter, else false</returns>
        public bool MoveNext()
        {
            return Enumerator.MoveNext();
        }
        /// <summary>
        /// Resets the enumerator to the initial position in front of the first found parameter.
        /// </summary>
        public void Reset()
        {
            Enumerator.Reset();
        }
        /// <summary>
        /// Returns the current found parameter from enumerator.
        /// </summary>
        public object Current
        {
            get
            {
                return ((DictionaryEntry)Enumerator.Current);
            }
        }
        /// <summary>
        /// Returns the number of found parameters.
        /// </summary>
        public int Count
        {
            get
            {
                return FoundParameters.Count;
            }
        }

        /// <summary>
        /// <para>Obtains strings from the CmdLineArgResourceManager.</para>
        /// <para>If resource does not exist or ResourceManager has no data assigned,
        /// the supplied ResourceManagerString is returned.</para>
        /// </summary>
        /// <param name="ResourceManagerString">Is looked up in ResourceManager</param>
        /// <returns>Match in ResourceManager or if no match available ResourceManagerString</returns>
        private string String(string ResourceManagerString)
        {
            string ret = "";
            try
            {
                ret = CmdLineArgResourceManager.GetString(ResourceManagerString);
            }
            catch (MissingManifestResourceException)
            {
                throw new Exception("Internal Exception: MissingManifestResourceException: Make sure NamespaceOfResX passed constructor CLAParser() is correct. If the resx-file is directly included to project, NamespaceOfResX must be the default namespace. In your main file Program.cs look for the line starting with \"namespace\" at top of file and try to pass the string which follows to constructor CLAParser().");
            }
            catch (Exception)
            {
                ret = ResourceManagerString; 
            }
            if (ret == null) ret = ResourceManagerString; 
            return ret;
        }

        /// <summary>
        /// <para>Call FindMismatchReasonInRegex() if SearchStr does not match RegEx in order to find out
        /// up to where SearchStr matches and where the mismatch starts.</para>
        /// <para>&#182;</para>
        /// <para>Decomposes regular expression RegEx into subexpressions according to parentesis groupings.
        /// Each subexpression which can be matched, indicates that SearchStr is valid up to that position.
        /// Thus this function can find out up to which position SearchStr is valid and where probably
        /// an error is located.</para>
        /// </summary>
        /// <param name="RegEx">Regular expression which is decomposed.</param>
        /// <param name="SearchStr">String which does not match RegEx.</param>
        /// <returns>Returns the character position where the reason for the regex dismatch probably is located.</returns>
        private int FindMismatchReasonInRegex(string RegEx, string SearchStr)
        {
            //disassemble RegEx string by finding all opening parenteses and their matching closing parts.
            SortedDictionary<int, int> Parentesis = new SortedDictionary<int, int>();
            Stack<int> OpenP = new Stack<int>();
            try
            {
                for (int i = 0; i < RegEx.Length; i++)
                {
                    if (RegEx[i] == '(')
                    {
                        //make sure that this ( is not escaped!
                        if (!((i == 1 && RegEx[i - 1] == '\\') ||
                               (i > 1 && RegEx[i - 1] == '\\' && RegEx[i - 2] != '\\')))
                            OpenP.Push(i);

                    }
                    else if (RegEx[i] == ')')
                    {
                        //make sure that this ) is not escaped!
                        if (!((i == 1 && RegEx[i - 1] == '\\') ||
                               (i > 1 && RegEx[i - 1] == '\\' && RegEx[i - 2] != '\\')))
                        {
                            int pop = OpenP.Pop();
                            Parentesis.Add(pop, i);
                        }
                    }
                }
                //since RegEx should be valid, this can never happen.
                if (OpenP.Count != 0) throw new Exception("Internal Exception: Parentesis not balanced!");
            }
            catch (Exception)
            {
                //since RegEx should be valid, this can never happen.
                throw new Exception("Internal Exception: Parentesis not balanced!");
            }

            ///Parentesis contains all parentesis matches ordered by the position of the opening parentesis
            IEnumerator e = Parentesis.GetEnumerator();
            int LastCorrectPosition = 0;
            while (e.MoveNext())
            {
                KeyValuePair<int, int> c = (KeyValuePair<int, int>)e.Current;

                //get sub-regular-expression of parentesis grouping.
                string SubRegEx = RegEx.Substring(c.Key, c.Value - c.Key + 1);
                Regex Sub = null;
                try
                {
                    Sub = new Regex(SubRegEx);
                }
                catch (Exception )
                {
                    //this should never happen since subexpression of a valid regex should still be valid.
                    throw new Exception("Internal Exception: SubRegEx invalid: " + SubRegEx.ToString());
                }
                Match m = Sub.Match(SearchStr);
                if (m.Success == true)
                {
                    ///if there is a match this subexpression matches the SearchStr and the mismatch must
                    ///follow afterwards.
                    ///find the end position of the match and increase LastCorrectPosition count to that position.
                    ///(warning: here the wrong match might be detected,
                    ///but since its is unlikely that commandline argument contains several identical parts,
                    ///this potential problem is ignored.)
                    int newLastCorrectPosition = SearchStr.IndexOf(m.Value) + m.Value.Length;
                    if (newLastCorrectPosition > LastCorrectPosition)
                        LastCorrectPosition = newLastCorrectPosition;
                }
            }
            return LastCorrectPosition;            
        }

        /// <summary>
        /// Adds and parameter-value-pair to FoundParameters if that pair matches the specification defined in WantedParameters.
        /// In case of a mismatch an exception is raised.
        /// </summary>
        /// <param name="NewParam">The new parameter which is to be added to FoundParameters.</param>
        /// <param name="NewValue">Value which corresponds to NewParam.</param>
        private void AddNewFoundParameter(string NewParam, string NewValue)
        {
            //just to make sure, however this should never happen.
            if (NewParam == null || NewValue == null)
                throw new Exception("Internal Exception: NewParam or NewValue in AddNewFoundParameter() == null!");

            ///values without parameter is only allowed if WantedParameters contains "" or if additional params are allowed.
            if (NewParam == "" && WantedParameters.ContainsKey(NewParam) == false && AllowAdditionalParameters == false)
                throw new ExceptionValueWithoutParameterFound(String("Exception") + String("ExceptionValueWithoutParameterFound") + NewValue + String("ExceptionValueWithoutParameterFound2"));
           /* else if (NewParam == "" && WantedParameters.ContainsKey(NewParam) == true)
            {
                ///values without parameter are allowed -> add them to FoundParameters
                FoundParameters.Add(NewParam, NewValue);
            }*/
            else
            {
                //NewParam is not empty. Test if it is a WantedParamter, raise exception if not, else add it to FoundParameters.
                if (WantedParameters.ContainsKey(NewParam) == false && AllowAdditionalParameters == false)
                    throw new ExceptionUnknownParameterFound(String("Exception")+String("ExceptionUnknownParameterFound") + NewParam + String("ExceptionUnknownParameterFound2"));
                else if (WantedParameters.ContainsKey(NewParam) == false && AllowAdditionalParameters == true)
                    FoundParameters.Add(NewParam, NewValue);
                else if(WantedParameters.ContainsKey(NewParam) == true)
                {
                    //found parameter is wanted. check if value has right format for each ValueType.
                    switch(WantedParameters[NewParam].ValueType)
                    {
                        ///bool parameters do not accept any value.
                        case ValueType.MultipleBool:
                        case ValueType.Bool: if(NewValue != "")
                                throw new ExceptionInvalidValueFound(String("Exception") + String("ExceptionInvalidValueFound") + NewParam + String("ExceptionInvalidValueFoundBool"));
                                                break;
                        ///optionalInt might be empty, then make it 0 and treat like a normal int.
                        case ValueType.OptionalInt: if (NewValue == "") NewValue = "0"; goto case ValueType.Int; //"" is okay for OptionalInt
                        ///int must be able to be converted to int32 without causing exception!
                        case ValueType.Int:                                                                      //else check if integer
                            try
                            {
                                Convert.ToInt32(NewValue);
                            }
                            catch (Exception)
                            {
                                throw new ExceptionInvalidValueFound(String("Exception")+String("ExceptionInvalidValueFound") + NewParam + String("ExceptionInvalidValueFoundInt"));
                            }
                            break;
                        ///multipleInt must be splitted and then be converted to int32.
                        case ValueType.MultipleInts:                        
                            try
                            {
                                Regex Split = new Regex("[\\s]+");
                                string[] values = Split.Split(NewValue);
                                foreach(string value in values)
                                    Convert.ToInt32(value);
                            }
                            catch (Exception)
                            {
                                throw new ExceptionInvalidValueFound(String("Exception")+String("ExceptionInvalidValueFound") + NewParam + String("ExceptionInvalidValueFoundInts"));
                            }
                            break;
                        //String can be anything but not empty.
                        case ValueType.String:
                                if (NewValue == "")
                                    throw new ExceptionInvalidValueFound(String("Exception")+String("ExceptionInvalidValueFound") + NewParam + String("ExceptionInvalidValueFoundString"));
                            break;
                        ///OptionalString can be anything. No check necessary.
                        case ValueType.OptionalString: break;
                        ///this should never happen because all cases are matched!
                        default: throw new Exception("Internal Exception: Unmatch case in AddNewFoundParameter()!");
                    }

                    ///now parameter is wanted and format is okay. insert param and value into FoundParameters
                    ///if param does not already exists!
                    ///only exception: multipleBool
                    if (FoundParameters.ContainsKey(NewParam))
                    {
                        if (WantedParameters[NewParam].ValueType != ValueType.MultipleBool)
                            throw new ExceptionRepeatedParameterFound(String("Exception")+String("ExceptionRepeatedParameterFound") + NewParam + String("ExceptionRepeatedParameterFoundOnce"));
                        else
                        {
                            FoundParameters[NewParam] = (Convert.ToInt32(FoundParameters[NewParam]) + 1).ToString();
                        }

                    }
                    else
                    {
                        if (WantedParameters[NewParam].ValueType == ValueType.MultipleBool)
                            FoundParameters[NewParam] = "1";
                        else
                            FoundParameters.Add(NewParam, NewValue);
                    }

                }                            
            }

        }

        /// <summary>
        /// All parsing and argument errors raise exceptions which are inherited from CmdLineArgumentException.
        /// Other exceptions should not be raised if they are they indicate an internal problem of CLAParser.
        /// </summary>
        public class CmdLineArgumentException : Exception
        {
            public CmdLineArgumentException() { }
            public CmdLineArgumentException(string message) : base(message) { }
        }
        /// <summary>
        /// Raised if argument line contains a syntax error, e.g. when containing "/-"
        /// </summary>
        public class ExceptionSyntaxError : CmdLineArgumentException{
            public ExceptionSyntaxError() { }
            public ExceptionSyntaxError(string message) : base(message) { }
        }
        /// <summary>
        /// Raised if a parameter which was previously defined by Parameter() is not part of argument line.
        /// </summary>
        public class ExceptionRequiredParameterMissing : CmdLineArgumentException{
            public ExceptionRequiredParameterMissing() { }
            public ExceptionRequiredParameterMissing(string message) : base(message) { }
        }
        /// <summary>
        /// Raised if a parameter which was not previously defined by Parameter() is part of argument line and
        /// AllowAdditionalParameters is not set to true.
        /// </summary>
        public class ExceptionUnknownParameterFound : CmdLineArgumentException{            
            public ExceptionUnknownParameterFound() { }
            public ExceptionUnknownParameterFound(string message) : base(message) { }
        }
        /// <summary>
        /// Raised if a parameter holds a value which does not comply with its specification defined by
        /// previous call of Parameter().
        /// </summary>
        public class ExceptionInvalidValueFound : CmdLineArgumentException{
            public ExceptionInvalidValueFound() { }
            public ExceptionInvalidValueFound(string message) : base(message) { }
        }
        /// <summary>
        /// Raised if a parameter was used more than once, e.g. program.exe /p value1 /p value2
        /// Only exception for parameters of type MultipleBool; no exception raised for program.exe /mp /mp
        /// </summary>
        public class ExceptionRepeatedParameterFound : CmdLineArgumentException{
            public ExceptionRepeatedParameterFound() { }
            public ExceptionRepeatedParameterFound(string message) : base(message) { }
        }
        /// <summary>
        /// Raised if a parameter of type String, Int, or MultipleInts does not hold a value.
        /// </summary>
        public class ExceptionValueWithoutParameterFound : CmdLineArgumentException{
            public ExceptionValueWithoutParameterFound() { }
            public ExceptionValueWithoutParameterFound(string message) : base(message) { }
        }


        /// <summary>This will return the raw unprocessed command line parameters as a string.</summary>
        /// <returns></returns>
        /// <remarks>Essentially, we are taking the unprocessed CommandLine and removing the executable path prefix by comparison to the .NET processed CommandLineArg[0].
        /// Credits to vermis0 from www.codeproject.com</remarks>
        static public string GetRawCommandlineArgs()
        {
            string Raw = Environment.CommandLine; string ExecutablePath = Environment.GetCommandLineArgs()[0]; string Parsed;
            // Raw is the completely unprocessed commandline the OS used to launch our application. This includes the  
            // path used to launch the executable as well as the parameters.
            // Our ExecutablePath is the .NET parsed path to the executable used to launch this application.  
            // It can be a relative or absolute path. Since it was parsed by .NET, if the OS passed the executable  
            // path as an encapsulated string, the surrounding " have been removed.  
            //
            // If the raw commandline starts with a ", then we need to take that into account when we chop off  
            // the executable path prefix (it was parsed out by .NET in ExecutablePath).  
            if (Raw.StartsWith("\"")) { Parsed = Raw.Substring(ExecutablePath.Length + 2); } else { Parsed = Raw.Substring(ExecutablePath.Length); }
            // do not trim (needed for regex to work)            
            return Parsed;
        }
    }
}
