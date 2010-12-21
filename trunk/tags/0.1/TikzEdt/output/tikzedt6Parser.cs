// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g 2010-12-21 08:20:11

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

public partial class tikzedt6Parser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"TIKZEDT", 
		"INPUT", 
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

    public const int SOMETHING_IN_BRACKETS = 7;
    public const int TIKZEDT_CMD_COMMENT = 11;
    public const int T__21 = 21;
    public const int T__20 = 20;
    public const int INPUT = 5;
    public const int HEX_DIGIT = 17;
    public const int FLOAT = 16;
    public const int INT = 15;
    public const int ID = 6;
    public const int EOF = -1;
    public const int SOMETHING_IN_CURLY_BRACKETS = 8;
    public const int TEX_CMD = 10;
    public const int DOUBLENEWLINE = 12;
    public const int T__19 = 19;
    public const int WS = 13;
    public const int T__18 = 18;
    public const int NEWLINE = 9;
    public const int TIKZEDT = 4;
    public const int COMMENT = 14;

    // delegates
    // delegators



        public tikzedt6Parser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public tikzedt6Parser(ITokenStream input, RecognizerSharedState state)
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
		get { return tikzedt6Parser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g"; }
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:36:1: tikzdocument : ( tikzedt_cmd_comment )* ( statement )* EOF ;
    public tikzedt6Parser.tikzdocument_return tikzdocument() // throws RecognitionException [1]
    {   
        tikzedt6Parser.tikzdocument_return retval = new tikzedt6Parser.tikzdocument_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EOF3 = null;
        tikzedt6Parser.tikzedt_cmd_comment_return tikzedt_cmd_comment1 = default(tikzedt6Parser.tikzedt_cmd_comment_return);

        tikzedt6Parser.statement_return statement2 = default(tikzedt6Parser.statement_return);


        object EOF3_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:41:2: ( ( tikzedt_cmd_comment )* ( statement )* EOF )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:41:4: ( tikzedt_cmd_comment )* ( statement )* EOF
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:41:4: ( tikzedt_cmd_comment )*
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
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:41:6: tikzedt_cmd_comment
            			    {
            			    	PushFollow(FOLLOW_tikzedt_cmd_comment_in_tikzdocument67);
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

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:43:4: ( statement )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= TIKZEDT && LA2_0 <= 21)) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:45:5: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_tikzdocument89);
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

            	EOF3=(IToken)Match(input,EOF,FOLLOW_EOF_in_tikzdocument102); 
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:51:1: statement : ( begin_end_block | latex_cmd | doublenewline | newline | broken_cmd );
    public tikzedt6Parser.statement_return statement() // throws RecognitionException [1]
    {   
        tikzedt6Parser.statement_return retval = new tikzedt6Parser.statement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        tikzedt6Parser.begin_end_block_return begin_end_block4 = default(tikzedt6Parser.begin_end_block_return);

        tikzedt6Parser.latex_cmd_return latex_cmd5 = default(tikzedt6Parser.latex_cmd_return);

        tikzedt6Parser.doublenewline_return doublenewline6 = default(tikzedt6Parser.doublenewline_return);

        tikzedt6Parser.newline_return newline7 = default(tikzedt6Parser.newline_return);

        tikzedt6Parser.broken_cmd_return broken_cmd8 = default(tikzedt6Parser.broken_cmd_return);



        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:52:2: ( begin_end_block | latex_cmd | doublenewline | newline | broken_cmd )
            int alt3 = 5;
            switch ( input.LA(1) ) 
            {
            case 18:
            	{
                int LA3_1 = input.LA(2);

                if ( (LA3_1 == ID) )
                {
                    int LA3_6 = input.LA(3);

                    if ( (LA3_6 == 19) )
                    {
                        alt3 = 1;
                    }
                    else if ( ((LA3_6 >= TIKZEDT && LA3_6 <= 18) || (LA3_6 >= 20 && LA3_6 <= 21)) )
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
                else if ( ((LA3_1 >= TIKZEDT && LA3_1 <= INPUT) || (LA3_1 >= SOMETHING_IN_BRACKETS && LA3_1 <= 21)) )
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
            case INPUT:
            case ID:
            case SOMETHING_IN_BRACKETS:
            case SOMETHING_IN_CURLY_BRACKETS:
            case TIKZEDT_CMD_COMMENT:
            case WS:
            case COMMENT:
            case INT:
            case FLOAT:
            case HEX_DIGIT:
            case 19:
            case 20:
            case 21:
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
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:53:2: begin_end_block
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_begin_end_block_in_statement115);
                    	begin_end_block4 = begin_end_block();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, begin_end_block4.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:56:4: latex_cmd
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_latex_cmd_in_statement124);
                    	latex_cmd5 = latex_cmd();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, latex_cmd5.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:57:4: doublenewline
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_doublenewline_in_statement129);
                    	doublenewline6 = doublenewline();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, doublenewline6.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:58:4: newline
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_newline_in_statement134);
                    	newline7 = newline();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, newline7.Tree);

                    }
                    break;
                case 5 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:59:4: broken_cmd
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_broken_cmd_in_statement140);
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:71:1: begin_end_block : '\\\\begin{' ID '}' ( options {greedy=false; } : statement )* '\\\\end{' ID '}' ;
    public tikzedt6Parser.begin_end_block_return begin_end_block() // throws RecognitionException [1]
    {   
        tikzedt6Parser.begin_end_block_return retval = new tikzedt6Parser.begin_end_block_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal9 = null;
        IToken ID10 = null;
        IToken char_literal11 = null;
        IToken string_literal13 = null;
        IToken ID14 = null;
        IToken char_literal15 = null;
        tikzedt6Parser.statement_return statement12 = default(tikzedt6Parser.statement_return);


        object string_literal9_tree=null;
        object ID10_tree=null;
        object char_literal11_tree=null;
        object string_literal13_tree=null;
        object ID14_tree=null;
        object char_literal15_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:72:2: ( '\\\\begin{' ID '}' ( options {greedy=false; } : statement )* '\\\\end{' ID '}' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:72:4: '\\\\begin{' ID '}' ( options {greedy=false; } : statement )* '\\\\end{' ID '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal9=(IToken)Match(input,18,FOLLOW_18_in_begin_end_block155); 
            		string_literal9_tree = (object)adaptor.Create(string_literal9);
            		adaptor.AddChild(root_0, string_literal9_tree);

            	ID10=(IToken)Match(input,ID,FOLLOW_ID_in_begin_end_block157); 
            		ID10_tree = (object)adaptor.Create(ID10);
            		adaptor.AddChild(root_0, ID10_tree);

            	char_literal11=(IToken)Match(input,19,FOLLOW_19_in_begin_end_block159); 
            		char_literal11_tree = (object)adaptor.Create(char_literal11);
            		adaptor.AddChild(root_0, char_literal11_tree);

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:73:3: ( options {greedy=false; } : statement )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == 20) )
            	    {
            	        int LA4_1 = input.LA(2);

            	        if ( (LA4_1 == ID) )
            	        {
            	            int LA4_3 = input.LA(3);

            	            if ( (LA4_3 == 19) )
            	            {
            	                alt4 = 2;
            	            }
            	            else if ( ((LA4_3 >= TIKZEDT && LA4_3 <= 18) || (LA4_3 >= 20 && LA4_3 <= 21)) )
            	            {
            	                alt4 = 1;
            	            }


            	        }
            	        else if ( ((LA4_1 >= TIKZEDT && LA4_1 <= INPUT) || (LA4_1 >= SOMETHING_IN_BRACKETS && LA4_1 <= 21)) )
            	        {
            	            alt4 = 1;
            	        }


            	    }
            	    else if ( ((LA4_0 >= TIKZEDT && LA4_0 <= 19) || LA4_0 == 21) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:74:33: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_begin_end_block181);
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

            	string_literal13=(IToken)Match(input,20,FOLLOW_20_in_begin_end_block190); 
            		string_literal13_tree = (object)adaptor.Create(string_literal13);
            		adaptor.AddChild(root_0, string_literal13_tree);

            	ID14=(IToken)Match(input,ID,FOLLOW_ID_in_begin_end_block192); 
            		ID14_tree = (object)adaptor.Create(ID14);
            		adaptor.AddChild(root_0, ID14_tree);

            	char_literal15=(IToken)Match(input,19,FOLLOW_19_in_begin_end_block194); 
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:89:1: latex_cmd : cmd_name ( SOMETHING_IN_BRACKETS | SOMETHING_IN_CURLY_BRACKETS | '=' | NEWLINE )* ;
    public tikzedt6Parser.latex_cmd_return latex_cmd() // throws RecognitionException [1]
    {   
        tikzedt6Parser.latex_cmd_return retval = new tikzedt6Parser.latex_cmd_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set17 = null;
        tikzedt6Parser.cmd_name_return cmd_name16 = default(tikzedt6Parser.cmd_name_return);


        object set17_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:90:2: ( cmd_name ( SOMETHING_IN_BRACKETS | SOMETHING_IN_CURLY_BRACKETS | '=' | NEWLINE )* )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:90:4: cmd_name ( SOMETHING_IN_BRACKETS | SOMETHING_IN_CURLY_BRACKETS | '=' | NEWLINE )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_cmd_name_in_latex_cmd213);
            	cmd_name16 = cmd_name();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, cmd_name16.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:90:13: ( SOMETHING_IN_BRACKETS | SOMETHING_IN_CURLY_BRACKETS | '=' | NEWLINE )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( (LA5_0 == NEWLINE) )
            	    {
            	        alt5 = 1;
            	    }
            	    else if ( ((LA5_0 >= SOMETHING_IN_BRACKETS && LA5_0 <= SOMETHING_IN_CURLY_BRACKETS) || LA5_0 == 21) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:
            			    {
            			    	set17 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= SOMETHING_IN_BRACKETS && input.LA(1) <= NEWLINE) || input.LA(1) == 21 ) 
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:93:1: cmd_name : TEX_CMD ;
    public tikzedt6Parser.cmd_name_return cmd_name() // throws RecognitionException [1]
    {   
        tikzedt6Parser.cmd_name_return retval = new tikzedt6Parser.cmd_name_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken TEX_CMD18 = null;

        object TEX_CMD18_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:93:10: ( TEX_CMD )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:93:12: TEX_CMD
            {
            	root_0 = (object)adaptor.GetNilNode();

            	TEX_CMD18=(IToken)Match(input,TEX_CMD,FOLLOW_TEX_CMD_in_cmd_name242); 
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:95:1: tikzedt_cmd_comment : TIKZEDT_CMD_COMMENT ;
    public tikzedt6Parser.tikzedt_cmd_comment_return tikzedt_cmd_comment() // throws RecognitionException [1]
    {   
        tikzedt6Parser.tikzedt_cmd_comment_return retval = new tikzedt6Parser.tikzedt_cmd_comment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken TIKZEDT_CMD_COMMENT19 = null;

        object TIKZEDT_CMD_COMMENT19_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:96:2: ( TIKZEDT_CMD_COMMENT )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:96:4: TIKZEDT_CMD_COMMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	TIKZEDT_CMD_COMMENT19=(IToken)Match(input,TIKZEDT_CMD_COMMENT,FOLLOW_TIKZEDT_CMD_COMMENT_in_tikzedt_cmd_comment252); 
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:99:1: newline : NEWLINE ;
    public tikzedt6Parser.newline_return newline() // throws RecognitionException [1]
    {   
        tikzedt6Parser.newline_return retval = new tikzedt6Parser.newline_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NEWLINE20 = null;

        object NEWLINE20_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:100:2: ( NEWLINE )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:100:5: NEWLINE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	NEWLINE20=(IToken)Match(input,NEWLINE,FOLLOW_NEWLINE_in_newline267); 
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:102:1: doublenewline : DOUBLENEWLINE ;
    public tikzedt6Parser.doublenewline_return doublenewline() // throws RecognitionException [1]
    {   
        tikzedt6Parser.doublenewline_return retval = new tikzedt6Parser.doublenewline_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken DOUBLENEWLINE21 = null;

        object DOUBLENEWLINE21_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:103:2: ( DOUBLENEWLINE )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:103:5: DOUBLENEWLINE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	DOUBLENEWLINE21=(IToken)Match(input,DOUBLENEWLINE,FOLLOW_DOUBLENEWLINE_in_doublenewline279); 
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:107:1: broken_cmd : (~ ( NEWLINE ) )+ NEWLINE ;
    public tikzedt6Parser.broken_cmd_return broken_cmd() // throws RecognitionException [1]
    {   
        tikzedt6Parser.broken_cmd_return retval = new tikzedt6Parser.broken_cmd_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set22 = null;
        IToken NEWLINE23 = null;

        object set22_tree=null;
        object NEWLINE23_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:108:2: ( (~ ( NEWLINE ) )+ NEWLINE )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:108:4: (~ ( NEWLINE ) )+ NEWLINE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:108:4: (~ ( NEWLINE ) )+
            	int cnt6 = 0;
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( ((LA6_0 >= TIKZEDT && LA6_0 <= SOMETHING_IN_CURLY_BRACKETS) || (LA6_0 >= TEX_CMD && LA6_0 <= 21)) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt6.g:108:4: ~ ( NEWLINE )
            			    {
            			    	set22 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= TIKZEDT && input.LA(1) <= SOMETHING_IN_CURLY_BRACKETS) || (input.LA(1) >= TEX_CMD && input.LA(1) <= 21) ) 
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

            	NEWLINE23=(IToken)Match(input,NEWLINE,FOLLOW_NEWLINE_in_broken_cmd304); 
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

 

    public static readonly BitSet FOLLOW_tikzedt_cmd_comment_in_tikzdocument67 = new BitSet(new ulong[]{0x00000000003FFFF0UL});
    public static readonly BitSet FOLLOW_statement_in_tikzdocument89 = new BitSet(new ulong[]{0x00000000003FFFF0UL});
    public static readonly BitSet FOLLOW_EOF_in_tikzdocument102 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_begin_end_block_in_statement115 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_latex_cmd_in_statement124 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_doublenewline_in_statement129 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_newline_in_statement134 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_broken_cmd_in_statement140 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_18_in_begin_end_block155 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_ID_in_begin_end_block157 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_begin_end_block159 = new BitSet(new ulong[]{0x00000000003FFFF0UL});
    public static readonly BitSet FOLLOW_statement_in_begin_end_block181 = new BitSet(new ulong[]{0x00000000003FFFF0UL});
    public static readonly BitSet FOLLOW_20_in_begin_end_block190 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_ID_in_begin_end_block192 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_begin_end_block194 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_cmd_name_in_latex_cmd213 = new BitSet(new ulong[]{0x0000000000200382UL});
    public static readonly BitSet FOLLOW_set_in_latex_cmd215 = new BitSet(new ulong[]{0x0000000000200382UL});
    public static readonly BitSet FOLLOW_TEX_CMD_in_cmd_name242 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TIKZEDT_CMD_COMMENT_in_tikzedt_cmd_comment252 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_newline267 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DOUBLENEWLINE_in_doublenewline279 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_broken_cmd295 = new BitSet(new ulong[]{0x00000000003FFFF0UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_broken_cmd304 = new BitSet(new ulong[]{0x0000000000000002UL});

}
