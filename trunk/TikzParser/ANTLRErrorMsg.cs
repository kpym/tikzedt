/*This file is part of TikzEdt.
 
TikzEdt is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.
 
TikzEdt is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
GNU General Public License for more details.
 
You should have received a copy of the GNU General Public License
along with TikzEdt.  If not, see <http://www.gnu.org/licenses/>.*/

using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;

namespace TikzEdt.Parser
{
    /// <summary>
    /// This static class creates a human readable error string
    /// from a ANTLRException. This string can be passed to the user.
    /// </summary>
    public static class ANTLRErrorMsg
    {
        static public string ToString(RecognitionException Ex, string[] tokenNames)
        {
            //Stores a string that will be displayed after the actual error message
            //to give the user a specific hint what might be wrong.
            string TikzEdtNotice = "";
            //message that will be returned.
            string msg = "";
            //Types of RecognitionException are defined here:
            //http://www.antlr.org/api/Python/classantlr3_1_1_recognition_exception.html
            if (Ex is EarlyExitException)
            {
                EarlyExitException ex = Ex as EarlyExitException;
                msg += "EarlyExitException";
            }
            else if (Ex is FailedPredicateException)
            {
                FailedPredicateException ex = Ex as FailedPredicateException;
                msg += "FailedPredicateException";
            }
            else if (Ex is MismatchedRangeException)
            {
                MismatchedRangeException ex = Ex as MismatchedRangeException;
                msg += "MismatchedRangeException";
            }
            else if (Ex is MismatchedSetException)
            {
                MismatchedSetException ex = Ex as MismatchedSetException;
                msg += "MismatchedSetException";
                if (Ex is MismatchedNotSetException)
                {
                    MismatchedNotSetException ex2 = ex as MismatchedNotSetException;
                    msg += " -> MismatchedNotSetException";
                }
            }
            else if (Ex is MismatchedTokenException)
            {
                MismatchedTokenException ex = Ex as MismatchedTokenException;
                msg += "MismatchedTokenException";
                if (Ex is MissingTokenException)
                {
                    MissingTokenException ex2 = ex as MissingTokenException;
                    msg += " -> MissingTokenException";
                }
                else if (Ex is UnwantedTokenException)
                {
                    UnwantedTokenException ex2 = ex as UnwantedTokenException;
                    msg += " -> UnwantedTokenException";
                }
                else if(ex.Token != null)
                {
                    //this seem to be a parser exception.

                    msg += ": Expected token " + tokenNames[ex.Expecting] + ".";
                    if (ex.Token.Text != null)
                    {
                        msg += " Instead found \"" + ex.Token.Text.Replace("\n", "<NewLine>") + "\"";
                        if(! tokenNames[ex.Token.Type].Contains(ex.Token.Text))
                            msg += " which is of type " + tokenNames[ex.Token.Type];                        
                    }
                    else
                    {
                        msg += " Instead found EOF";
                        TikzEdtNotice = "Does document include \\begin{tikzpicture} and \\end{tikzpicture}?";
                    }
                }
                else if (ex.Token == null)
                {
                    //this is probably a lexer exception.
                    if (ex.Node is String)
                    {
                        msg += ": Parser expected to start token \""+ ex.Node.ToString() +"\"";
                    }
                }
            }
            else if (Ex is MismatchedTreeNodeException)
            {
                MismatchedTreeNodeException ex = Ex as MismatchedTreeNodeException;
                msg += "MismatchedTreeNodeException";
            }
            else if (Ex is NoViableAltException)
            {
                NoViableAltException ex = Ex as NoViableAltException;
                msg += "NoViableAltException";
                if (ex.grammarDecisionDescription != null && ex.grammarDecisionDescription != "")
                {
                    if (ex.grammarDecisionDescription.ToLower().Contains("loopback"))
                    {
                        string loop = ex.grammarDecisionDescription.Substring(ex.grammarDecisionDescription.LastIndexOf(':') + 1);
                        msg += ": Parser is stuck in following recursion: " + loop.Trim();
                    }
                }
                TikzEdtNotice = "Is some \\end{} command missing?";
            }
            else
            {
                msg += "UnkownExcpetion (this is really bad)";
            }
            if (Ex.Line > 0)
                msg += " in line " + Ex.Line.ToString() + " at position " + Ex.CharPositionInLine.ToString();
            else
                msg += " at end of document";

            if (Ex.approximateLineInfo)
                msg += " (approximately)";

            msg += ".";

            if (TikzEdtNotice != "")
                msg += " " + TikzEdtNotice;

            return msg;
        }
    }
}
