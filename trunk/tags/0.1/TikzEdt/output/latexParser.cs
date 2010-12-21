// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g 2010-12-21 08:51:34

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



using Antlr.Runtime.Tree;

public partial class latexParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"TIKZEDT", 
		"ID", 
		"SOMETHING_IN_BRACKETS", 
		"SOMETHING_IN_CURLY_BRACKETS", 
		"NEWLINE", 
		"TEX_CMD", 
		"TIKZEDT_CMD_COMMENT", 
		"DOUBLENEWLINE", 
		"WS", 
		"COMMENT", 
		"INT", 
		"FLOAT", 
		"HEX_DIGIT", 
		"'\\\\begin{'", 
		"'}'", 
		"'\\\\end{'", 
		"'='"
    };

    public const int SOMETHING_IN_BRACKETS = 6;
    public const int TIKZEDT_CMD_COMMENT = 10;
    public const int T__20 = 20;
    public const int HEX_DIGIT = 16;
    public const int INT = 14;
    public const int FLOAT = 15;
    public const int ID = 5;
    public const int EOF = -1;
    public const int SOMETHING_IN_CURLY_BRACKETS = 7;
    public const int TEX_CMD = 9;
    public const int DOUBLENEWLINE = 11;
    public const int T__19 = 19;
    public const int WS = 12;
    public const int T__18 = 18;
    public const int NEWLINE = 8;
    public const int T__17 = 17;
    public const int TIKZEDT = 4;
    public const int COMMENT = 13;

    // delegates
    // delegators



        public latexParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public latexParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return latexParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g"; }
    }


    public class tikzdocument_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikzdocument"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:34:1: tikzdocument : ( tikzedt_cmd_comment )* ( statement )* EOF ;
    public latexParser.tikzdocument_return tikzdocument() // throws RecognitionException [1]
    {   
        latexParser.tikzdocument_return retval = new latexParser.tikzdocument_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EOF3 = null;
        latexParser.tikzedt_cmd_comment_return tikzedt_cmd_comment1 = default(latexParser.tikzedt_cmd_comment_return);

        latexParser.statement_return statement2 = default(latexParser.statement_return);


        object EOF3_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:39:2: ( ( tikzedt_cmd_comment )* ( statement )* EOF )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:39:4: ( tikzedt_cmd_comment )* ( statement )* EOF
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:39:4: ( tikzedt_cmd_comment )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == TIKZEDT_CMD_COMMENT) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:39:6: tikzedt_cmd_comment
            			    {
            			    	PushFollow(FOLLOW_tikzedt_cmd_comment_in_tikzdocument56);
            			    	tikzedt_cmd_comment1 = tikzedt_cmd_comment();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, tikzedt_cmd_comment1.Tree);

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:41:4: ( statement )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= TIKZEDT && LA2_0 <= 20)) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:43:5: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_tikzdocument78);
            			    	statement2 = statement();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, statement2.Tree);

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements

            	EOF3=(IToken)Match(input,EOF,FOLLOW_EOF_in_tikzdocument91); 
            		EOF3_tree = (object)adaptor.Create(EOF3);
            		adaptor.AddChild(root_0, EOF3_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tikzdocument"

    public class statement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "statement"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:49:1: statement : ( begin_end_block | latex_cmd | doublenewline | newline | broken_cmd );
    public latexParser.statement_return statement() // throws RecognitionException [1]
    {   
        latexParser.statement_return retval = new latexParser.statement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        latexParser.begin_end_block_return begin_end_block4 = default(latexParser.begin_end_block_return);

        latexParser.latex_cmd_return latex_cmd5 = default(latexParser.latex_cmd_return);

        latexParser.doublenewline_return doublenewline6 = default(latexParser.doublenewline_return);

        latexParser.newline_return newline7 = default(latexParser.newline_return);

        latexParser.broken_cmd_return broken_cmd8 = default(latexParser.broken_cmd_return);



        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:50:2: ( begin_end_block | latex_cmd | doublenewline | newline | broken_cmd )
            int alt3 = 5;
            switch ( input.LA(1) ) 
            {
            case 17:
            	{
                int LA3_1 = input.LA(2);

                if ( (LA3_1 == ID) )
                {
                    int LA3_6 = input.LA(3);

                    if ( (LA3_6 == 18) )
                    {
                        alt3 = 1;
                    }
                    else if ( ((LA3_6 >= TIKZEDT && LA3_6 <= 17) || (LA3_6 >= 19 && LA3_6 <= 20)) )
                    {
                        alt3 = 5;
                    }
                    else 
                    {
                        NoViableAltException nvae_d3s6 =
                            new NoViableAltException("", 3, 6, input);

                        throw nvae_d3s6;
                    }
                }
                else if ( (LA3_1 == TIKZEDT || (LA3_1 >= SOMETHING_IN_BRACKETS && LA3_1 <= 20)) )
                {
                    alt3 = 5;
                }
                else 
                {
                    NoViableAltException nvae_d3s1 =
                        new NoViableAltException("", 3, 1, input);

                    throw nvae_d3s1;
                }
                }
                break;
            case TEX_CMD:
            	{
                alt3 = 2;
                }
                break;
            case DOUBLENEWLINE:
            	{
                alt3 = 3;
                }
                break;
            case NEWLINE:
            	{
                alt3 = 4;
                }
                break;
            case TIKZEDT:
            case ID:
            case SOMETHING_IN_BRACKETS:
            case SOMETHING_IN_CURLY_BRACKETS:
            case TIKZEDT_CMD_COMMENT:
            case WS:
            case COMMENT:
            case INT:
            case FLOAT:
            case HEX_DIGIT:
            case 18:
            case 19:
            case 20:
            	{
                alt3 = 5;
                }
                break;
            	default:
            	    NoViableAltException nvae_d3s0 =
            	        new NoViableAltException("", 3, 0, input);

            	    throw nvae_d3s0;
            }

            switch (alt3) 
            {
                case 1 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:51:2: begin_end_block
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_begin_end_block_in_statement104);
                    	begin_end_block4 = begin_end_block();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, begin_end_block4.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:54:4: latex_cmd
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_latex_cmd_in_statement113);
                    	latex_cmd5 = latex_cmd();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, latex_cmd5.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:55:4: doublenewline
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_doublenewline_in_statement118);
                    	doublenewline6 = doublenewline();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, doublenewline6.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:56:4: newline
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_newline_in_statement123);
                    	newline7 = newline();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, newline7.Tree);

                    }
                    break;
                case 5 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:57:4: broken_cmd
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_broken_cmd_in_statement129);
                    	broken_cmd8 = broken_cmd();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, broken_cmd8.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "statement"

    public class begin_end_block_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "begin_end_block"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:69:1: begin_end_block : '\\\\begin{' ID '}' ( options {greedy=false; } : statement )* '\\\\end{' ID '}' ;
    public latexParser.begin_end_block_return begin_end_block() // throws RecognitionException [1]
    {   
        latexParser.begin_end_block_return retval = new latexParser.begin_end_block_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal9 = null;
        IToken ID10 = null;
        IToken char_literal11 = null;
        IToken string_literal13 = null;
        IToken ID14 = null;
        IToken char_literal15 = null;
        latexParser.statement_return statement12 = default(latexParser.statement_return);


        object string_literal9_tree=null;
        object ID10_tree=null;
        object char_literal11_tree=null;
        object string_literal13_tree=null;
        object ID14_tree=null;
        object char_literal15_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:70:2: ( '\\\\begin{' ID '}' ( options {greedy=false; } : statement )* '\\\\end{' ID '}' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:70:4: '\\\\begin{' ID '}' ( options {greedy=false; } : statement )* '\\\\end{' ID '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal9=(IToken)Match(input,17,FOLLOW_17_in_begin_end_block144); 
            		string_literal9_tree = (object)adaptor.Create(string_literal9);
            		adaptor.AddChild(root_0, string_literal9_tree);

            	ID10=(IToken)Match(input,ID,FOLLOW_ID_in_begin_end_block146); 
            		ID10_tree = (object)adaptor.Create(ID10);
            		adaptor.AddChild(root_0, ID10_tree);

            	char_literal11=(IToken)Match(input,18,FOLLOW_18_in_begin_end_block148); 
            		char_literal11_tree = (object)adaptor.Create(char_literal11);
            		adaptor.AddChild(root_0, char_literal11_tree);

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:71:3: ( options {greedy=false; } : statement )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == 19) )
            	    {
            	        int LA4_1 = input.LA(2);

            	        if ( (LA4_1 == ID) )
            	        {
            	            int LA4_3 = input.LA(3);

            	            if ( (LA4_3 == 18) )
            	            {
            	                alt4 = 2;
            	            }
            	            else if ( ((LA4_3 >= TIKZEDT && LA4_3 <= 17) || (LA4_3 >= 19 && LA4_3 <= 20)) )
            	            {
            	                alt4 = 1;
            	            }


            	        }
            	        else if ( (LA4_1 == TIKZEDT || (LA4_1 >= SOMETHING_IN_BRACKETS && LA4_1 <= 20)) )
            	        {
            	            alt4 = 1;
            	        }


            	    }
            	    else if ( ((LA4_0 >= TIKZEDT && LA4_0 <= 18) || LA4_0 == 20) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:72:33: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_begin_end_block170);
            			    	statement12 = statement();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, statement12.Tree);

            			    }
            			    break;

            			default:
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements

            	string_literal13=(IToken)Match(input,19,FOLLOW_19_in_begin_end_block179); 
            		string_literal13_tree = (object)adaptor.Create(string_literal13);
            		adaptor.AddChild(root_0, string_literal13_tree);

            	ID14=(IToken)Match(input,ID,FOLLOW_ID_in_begin_end_block181); 
            		ID14_tree = (object)adaptor.Create(ID14);
            		adaptor.AddChild(root_0, ID14_tree);

            	char_literal15=(IToken)Match(input,18,FOLLOW_18_in_begin_end_block183); 
            		char_literal15_tree = (object)adaptor.Create(char_literal15);
            		adaptor.AddChild(root_0, char_literal15_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "begin_end_block"

    public class latex_cmd_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "latex_cmd"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:87:1: latex_cmd : cmd_name ( SOMETHING_IN_BRACKETS | SOMETHING_IN_CURLY_BRACKETS | '=' | NEWLINE )* ;
    public latexParser.latex_cmd_return latex_cmd() // throws RecognitionException [1]
    {   
        latexParser.latex_cmd_return retval = new latexParser.latex_cmd_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set17 = null;
        latexParser.cmd_name_return cmd_name16 = default(latexParser.cmd_name_return);


        object set17_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:88:2: ( cmd_name ( SOMETHING_IN_BRACKETS | SOMETHING_IN_CURLY_BRACKETS | '=' | NEWLINE )* )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:88:4: cmd_name ( SOMETHING_IN_BRACKETS | SOMETHING_IN_CURLY_BRACKETS | '=' | NEWLINE )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_cmd_name_in_latex_cmd202);
            	cmd_name16 = cmd_name();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, cmd_name16.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:88:13: ( SOMETHING_IN_BRACKETS | SOMETHING_IN_CURLY_BRACKETS | '=' | NEWLINE )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( (LA5_0 == NEWLINE) )
            	    {
            	        alt5 = 1;
            	    }
            	    else if ( ((LA5_0 >= SOMETHING_IN_BRACKETS && LA5_0 <= SOMETHING_IN_CURLY_BRACKETS) || LA5_0 == 20) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:
            			    {
            			    	set17 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= SOMETHING_IN_BRACKETS && input.LA(1) <= NEWLINE) || input.LA(1) == 20 ) 
            			    	{
            			    	    input.Consume();
            			    	    adaptor.AddChild(root_0, (object)adaptor.Create(set17));
            			    	    state.errorRecovery = false;
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}


            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "latex_cmd"

    public class cmd_name_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "cmd_name"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:91:1: cmd_name : TEX_CMD ;
    public latexParser.cmd_name_return cmd_name() // throws RecognitionException [1]
    {   
        latexParser.cmd_name_return retval = new latexParser.cmd_name_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken TEX_CMD18 = null;

        object TEX_CMD18_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:91:10: ( TEX_CMD )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:91:12: TEX_CMD
            {
            	root_0 = (object)adaptor.GetNilNode();

            	TEX_CMD18=(IToken)Match(input,TEX_CMD,FOLLOW_TEX_CMD_in_cmd_name231); 
            		TEX_CMD18_tree = (object)adaptor.Create(TEX_CMD18);
            		adaptor.AddChild(root_0, TEX_CMD18_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "cmd_name"

    public class tikzedt_cmd_comment_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikzedt_cmd_comment"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:93:1: tikzedt_cmd_comment : TIKZEDT_CMD_COMMENT ;
    public latexParser.tikzedt_cmd_comment_return tikzedt_cmd_comment() // throws RecognitionException [1]
    {   
        latexParser.tikzedt_cmd_comment_return retval = new latexParser.tikzedt_cmd_comment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken TIKZEDT_CMD_COMMENT19 = null;

        object TIKZEDT_CMD_COMMENT19_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:94:2: ( TIKZEDT_CMD_COMMENT )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:94:4: TIKZEDT_CMD_COMMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	TIKZEDT_CMD_COMMENT19=(IToken)Match(input,TIKZEDT_CMD_COMMENT,FOLLOW_TIKZEDT_CMD_COMMENT_in_tikzedt_cmd_comment241); 
            		TIKZEDT_CMD_COMMENT19_tree = (object)adaptor.Create(TIKZEDT_CMD_COMMENT19);
            		adaptor.AddChild(root_0, TIKZEDT_CMD_COMMENT19_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tikzedt_cmd_comment"

    public class newline_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "newline"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:97:1: newline : NEWLINE ;
    public latexParser.newline_return newline() // throws RecognitionException [1]
    {   
        latexParser.newline_return retval = new latexParser.newline_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NEWLINE20 = null;

        object NEWLINE20_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:98:2: ( NEWLINE )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:98:5: NEWLINE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	NEWLINE20=(IToken)Match(input,NEWLINE,FOLLOW_NEWLINE_in_newline256); 
            		NEWLINE20_tree = (object)adaptor.Create(NEWLINE20);
            		adaptor.AddChild(root_0, NEWLINE20_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "newline"

    public class doublenewline_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "doublenewline"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:100:1: doublenewline : DOUBLENEWLINE ;
    public latexParser.doublenewline_return doublenewline() // throws RecognitionException [1]
    {   
        latexParser.doublenewline_return retval = new latexParser.doublenewline_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken DOUBLENEWLINE21 = null;

        object DOUBLENEWLINE21_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:101:2: ( DOUBLENEWLINE )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:101:5: DOUBLENEWLINE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	DOUBLENEWLINE21=(IToken)Match(input,DOUBLENEWLINE,FOLLOW_DOUBLENEWLINE_in_doublenewline268); 
            		DOUBLENEWLINE21_tree = (object)adaptor.Create(DOUBLENEWLINE21);
            		adaptor.AddChild(root_0, DOUBLENEWLINE21_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "doublenewline"

    public class broken_cmd_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "broken_cmd"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:105:1: broken_cmd : (~ ( NEWLINE ) )+ NEWLINE ;
    public latexParser.broken_cmd_return broken_cmd() // throws RecognitionException [1]
    {   
        latexParser.broken_cmd_return retval = new latexParser.broken_cmd_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set22 = null;
        IToken NEWLINE23 = null;

        object set22_tree=null;
        object NEWLINE23_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:106:2: ( (~ ( NEWLINE ) )+ NEWLINE )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:106:4: (~ ( NEWLINE ) )+ NEWLINE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:106:4: (~ ( NEWLINE ) )+
            	int cnt6 = 0;
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( ((LA6_0 >= TIKZEDT && LA6_0 <= SOMETHING_IN_CURLY_BRACKETS) || (LA6_0 >= TEX_CMD && LA6_0 <= 20)) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:106:4: ~ ( NEWLINE )
            			    {
            			    	set22 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= TIKZEDT && input.LA(1) <= SOMETHING_IN_CURLY_BRACKETS) || (input.LA(1) >= TEX_CMD && input.LA(1) <= 20) ) 
            			    	{
            			    	    input.Consume();
            			    	    adaptor.AddChild(root_0, (object)adaptor.Create(set22));
            			    	    state.errorRecovery = false;
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}


            			    }
            			    break;

            			default:
            			    if ( cnt6 >= 1 ) goto loop6;
            		            EarlyExitException eee6 =
            		                new EarlyExitException(6, input);
            		            throw eee6;
            	    }
            	    cnt6++;
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements

            	NEWLINE23=(IToken)Match(input,NEWLINE,FOLLOW_NEWLINE_in_broken_cmd293); 
            		NEWLINE23_tree = (object)adaptor.Create(NEWLINE23);
            		adaptor.AddChild(root_0, NEWLINE23_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "broken_cmd"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_tikzedt_cmd_comment_in_tikzdocument56 = new BitSet(new ulong[]{0x00000000001FFFF0UL});
    public static readonly BitSet FOLLOW_statement_in_tikzdocument78 = new BitSet(new ulong[]{0x00000000001FFFF0UL});
    public static readonly BitSet FOLLOW_EOF_in_tikzdocument91 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_begin_end_block_in_statement104 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_latex_cmd_in_statement113 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_doublenewline_in_statement118 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_newline_in_statement123 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_broken_cmd_in_statement129 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_17_in_begin_end_block144 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_ID_in_begin_end_block146 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_18_in_begin_end_block148 = new BitSet(new ulong[]{0x00000000001FFFF0UL});
    public static readonly BitSet FOLLOW_statement_in_begin_end_block170 = new BitSet(new ulong[]{0x00000000001FFFF0UL});
    public static readonly BitSet FOLLOW_19_in_begin_end_block179 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_ID_in_begin_end_block181 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_18_in_begin_end_block183 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_cmd_name_in_latex_cmd202 = new BitSet(new ulong[]{0x00000000001001C2UL});
    public static readonly BitSet FOLLOW_set_in_latex_cmd204 = new BitSet(new ulong[]{0x00000000001001C2UL});
    public static readonly BitSet FOLLOW_TEX_CMD_in_cmd_name231 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TIKZEDT_CMD_COMMENT_in_tikzedt_cmd_comment241 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_newline256 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DOUBLENEWLINE_in_doublenewline268 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_broken_cmd284 = new BitSet(new ulong[]{0x00000000001FFFF0UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_broken_cmd293 = new BitSet(new ulong[]{0x0000000000000002UL});

}
