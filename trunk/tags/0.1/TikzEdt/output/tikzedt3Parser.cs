// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g 2010-12-21 07:34:54

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

public partial class tikzedt3Parser : Parser
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



        public tikzedt3Parser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public tikzedt3Parser(ITokenStream input, RecognizerSharedState state)
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
		get { return tikzedt3Parser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g"; }
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:36:1: tikzdocument : ( tikzedt_cmd_comment )* ( options {greedy=true; } : ( begin_end_block | latex_cmd | doublenewline | newline | ( options {greedy=false; } : broken_cmd ) )* ) EOF ;
    public tikzedt3Parser.tikzdocument_return tikzdocument() // throws RecognitionException [1]
    {   
        tikzedt3Parser.tikzdocument_return retval = new tikzedt3Parser.tikzdocument_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EOF7 = null;
        tikzedt3Parser.tikzedt_cmd_comment_return tikzedt_cmd_comment1 = default(tikzedt3Parser.tikzedt_cmd_comment_return);

        tikzedt3Parser.begin_end_block_return begin_end_block2 = default(tikzedt3Parser.begin_end_block_return);

        tikzedt3Parser.latex_cmd_return latex_cmd3 = default(tikzedt3Parser.latex_cmd_return);

        tikzedt3Parser.doublenewline_return doublenewline4 = default(tikzedt3Parser.doublenewline_return);

        tikzedt3Parser.newline_return newline5 = default(tikzedt3Parser.newline_return);

        tikzedt3Parser.broken_cmd_return broken_cmd6 = default(tikzedt3Parser.broken_cmd_return);


        object EOF7_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:41:2: ( ( tikzedt_cmd_comment )* ( options {greedy=true; } : ( begin_end_block | latex_cmd | doublenewline | newline | ( options {greedy=false; } : broken_cmd ) )* ) EOF )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:41:4: ( tikzedt_cmd_comment )* ( options {greedy=true; } : ( begin_end_block | latex_cmd | doublenewline | newline | ( options {greedy=false; } : broken_cmd ) )* ) EOF
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:41:4: ( tikzedt_cmd_comment )*
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
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:41:6: tikzedt_cmd_comment
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

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:42:3: ( options {greedy=true; } : ( begin_end_block | latex_cmd | doublenewline | newline | ( options {greedy=false; } : broken_cmd ) )* )
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:43:6: ( begin_end_block | latex_cmd | doublenewline | newline | ( options {greedy=false; } : broken_cmd ) )*
            	{
            		// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:43:6: ( begin_end_block | latex_cmd | doublenewline | newline | ( options {greedy=false; } : broken_cmd ) )*
            		do 
            		{
            		    int alt2 = 6;
            		    alt2 = dfa2.Predict(input);
            		    switch (alt2) 
            			{
            				case 1 :
            				    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:44:5: begin_end_block
            				    {
            				    	PushFollow(FOLLOW_begin_end_block_in_tikzdocument101);
            				    	begin_end_block2 = begin_end_block();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, begin_end_block2.Tree);

            				    }
            				    break;
            				case 2 :
            				    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:45:7: latex_cmd
            				    {
            				    	PushFollow(FOLLOW_latex_cmd_in_tikzdocument109);
            				    	latex_cmd3 = latex_cmd();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, latex_cmd3.Tree);

            				    }
            				    break;
            				case 3 :
            				    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:46:7: doublenewline
            				    {
            				    	PushFollow(FOLLOW_doublenewline_in_tikzdocument117);
            				    	doublenewline4 = doublenewline();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, doublenewline4.Tree);

            				    }
            				    break;
            				case 4 :
            				    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:47:7: newline
            				    {
            				    	PushFollow(FOLLOW_newline_in_tikzdocument125);
            				    	newline5 = newline();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, newline5.Tree);

            				    }
            				    break;
            				case 5 :
            				    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:48:7: ( options {greedy=false; } : broken_cmd )
            				    {
            				    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:48:7: ( options {greedy=false; } : broken_cmd )
            				    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:48:39: broken_cmd
            				    	{
            				    		PushFollow(FOLLOW_broken_cmd_in_tikzdocument149);
            				    		broken_cmd6 = broken_cmd();
            				    		state.followingStackPointer--;

            				    		adaptor.AddChild(root_0, broken_cmd6.Tree);

            				    	}


            				    }
            				    break;

            				default:
            				    goto loop2;
            		    }
            		} while (true);

            		loop2:
            			;	// Stops C# compiler whining that label 'loop2' has no statements


            	}

            	EOF7=(IToken)Match(input,EOF,FOLLOW_EOF_in_tikzdocument165); 
            		EOF7_tree = (object)adaptor.Create(EOF7);
            		adaptor.AddChild(root_0, EOF7_tree);


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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:54:1: begin_end_block : '\\\\begin{' ID '}' ( options {greedy=false; } : . )* '\\\\end{' ID '}' ;
    public tikzedt3Parser.begin_end_block_return begin_end_block() // throws RecognitionException [1]
    {   
        tikzedt3Parser.begin_end_block_return retval = new tikzedt3Parser.begin_end_block_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal8 = null;
        IToken ID9 = null;
        IToken char_literal10 = null;
        IToken wildcard11 = null;
        IToken string_literal12 = null;
        IToken ID13 = null;
        IToken char_literal14 = null;

        object string_literal8_tree=null;
        object ID9_tree=null;
        object char_literal10_tree=null;
        object wildcard11_tree=null;
        object string_literal12_tree=null;
        object ID13_tree=null;
        object char_literal14_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:55:2: ( '\\\\begin{' ID '}' ( options {greedy=false; } : . )* '\\\\end{' ID '}' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:55:4: '\\\\begin{' ID '}' ( options {greedy=false; } : . )* '\\\\end{' ID '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal8=(IToken)Match(input,18,FOLLOW_18_in_begin_end_block177); 
            		string_literal8_tree = (object)adaptor.Create(string_literal8);
            		adaptor.AddChild(root_0, string_literal8_tree);

            	ID9=(IToken)Match(input,ID,FOLLOW_ID_in_begin_end_block178); 
            		ID9_tree = (object)adaptor.Create(ID9);
            		adaptor.AddChild(root_0, ID9_tree);

            	char_literal10=(IToken)Match(input,19,FOLLOW_19_in_begin_end_block179); 
            		char_literal10_tree = (object)adaptor.Create(char_literal10);
            		adaptor.AddChild(root_0, char_literal10_tree);

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:56:3: ( options {greedy=false; } : . )*
            	do 
            	{
            	    int alt3 = 2;
            	    alt3 = dfa3.Predict(input);
            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:57:35: .
            			    {
            			    	wildcard11 = (IToken)input.LT(1);
            			    	MatchAny(input); 
            			    		wildcard11_tree = (object)adaptor.Create(wildcard11);
            			    		adaptor.AddChild(root_0, wildcard11_tree);


            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements

            	string_literal12=(IToken)Match(input,20,FOLLOW_20_in_begin_end_block212); 
            		string_literal12_tree = (object)adaptor.Create(string_literal12);
            		adaptor.AddChild(root_0, string_literal12_tree);

            	ID13=(IToken)Match(input,ID,FOLLOW_ID_in_begin_end_block213); 
            		ID13_tree = (object)adaptor.Create(ID13);
            		adaptor.AddChild(root_0, ID13_tree);

            	char_literal14=(IToken)Match(input,19,FOLLOW_19_in_begin_end_block214); 
            		char_literal14_tree = (object)adaptor.Create(char_literal14);
            		adaptor.AddChild(root_0, char_literal14_tree);


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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:62:1: latex_cmd : cmd_name ( SOMETHING_IN_BRACKETS | SOMETHING_IN_CURLY_BRACKETS | '=' | NEWLINE )* ;
    public tikzedt3Parser.latex_cmd_return latex_cmd() // throws RecognitionException [1]
    {   
        tikzedt3Parser.latex_cmd_return retval = new tikzedt3Parser.latex_cmd_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set16 = null;
        tikzedt3Parser.cmd_name_return cmd_name15 = default(tikzedt3Parser.cmd_name_return);


        object set16_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:63:2: ( cmd_name ( SOMETHING_IN_BRACKETS | SOMETHING_IN_CURLY_BRACKETS | '=' | NEWLINE )* )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:63:4: cmd_name ( SOMETHING_IN_BRACKETS | SOMETHING_IN_CURLY_BRACKETS | '=' | NEWLINE )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_cmd_name_in_latex_cmd228);
            	cmd_name15 = cmd_name();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, cmd_name15.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:63:13: ( SOMETHING_IN_BRACKETS | SOMETHING_IN_CURLY_BRACKETS | '=' | NEWLINE )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == NEWLINE) )
            	    {
            	        alt4 = 1;
            	    }
            	    else if ( ((LA4_0 >= SOMETHING_IN_BRACKETS && LA4_0 <= SOMETHING_IN_CURLY_BRACKETS) || LA4_0 == 21) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:
            			    {
            			    	set16 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= SOMETHING_IN_BRACKETS && input.LA(1) <= NEWLINE) || input.LA(1) == 21 ) 
            			    	{
            			    	    input.Consume();
            			    	    adaptor.AddChild(root_0, (object)adaptor.Create(set16));
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
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements


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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:66:1: cmd_name : TEX_CMD ;
    public tikzedt3Parser.cmd_name_return cmd_name() // throws RecognitionException [1]
    {   
        tikzedt3Parser.cmd_name_return retval = new tikzedt3Parser.cmd_name_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken TEX_CMD17 = null;

        object TEX_CMD17_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:66:10: ( TEX_CMD )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:66:12: TEX_CMD
            {
            	root_0 = (object)adaptor.GetNilNode();

            	TEX_CMD17=(IToken)Match(input,TEX_CMD,FOLLOW_TEX_CMD_in_cmd_name257); 
            		TEX_CMD17_tree = (object)adaptor.Create(TEX_CMD17);
            		adaptor.AddChild(root_0, TEX_CMD17_tree);


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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:68:1: tikzedt_cmd_comment : TIKZEDT_CMD_COMMENT ;
    public tikzedt3Parser.tikzedt_cmd_comment_return tikzedt_cmd_comment() // throws RecognitionException [1]
    {   
        tikzedt3Parser.tikzedt_cmd_comment_return retval = new tikzedt3Parser.tikzedt_cmd_comment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken TIKZEDT_CMD_COMMENT18 = null;

        object TIKZEDT_CMD_COMMENT18_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:69:2: ( TIKZEDT_CMD_COMMENT )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:69:4: TIKZEDT_CMD_COMMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	TIKZEDT_CMD_COMMENT18=(IToken)Match(input,TIKZEDT_CMD_COMMENT,FOLLOW_TIKZEDT_CMD_COMMENT_in_tikzedt_cmd_comment267); 
            		TIKZEDT_CMD_COMMENT18_tree = (object)adaptor.Create(TIKZEDT_CMD_COMMENT18);
            		adaptor.AddChild(root_0, TIKZEDT_CMD_COMMENT18_tree);


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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:72:1: newline : NEWLINE ;
    public tikzedt3Parser.newline_return newline() // throws RecognitionException [1]
    {   
        tikzedt3Parser.newline_return retval = new tikzedt3Parser.newline_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NEWLINE19 = null;

        object NEWLINE19_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:73:2: ( NEWLINE )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:73:5: NEWLINE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	NEWLINE19=(IToken)Match(input,NEWLINE,FOLLOW_NEWLINE_in_newline282); 
            		NEWLINE19_tree = (object)adaptor.Create(NEWLINE19);
            		adaptor.AddChild(root_0, NEWLINE19_tree);


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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:75:1: doublenewline : DOUBLENEWLINE ;
    public tikzedt3Parser.doublenewline_return doublenewline() // throws RecognitionException [1]
    {   
        tikzedt3Parser.doublenewline_return retval = new tikzedt3Parser.doublenewline_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken DOUBLENEWLINE20 = null;

        object DOUBLENEWLINE20_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:76:2: ( DOUBLENEWLINE )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:76:5: DOUBLENEWLINE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	DOUBLENEWLINE20=(IToken)Match(input,DOUBLENEWLINE,FOLLOW_DOUBLENEWLINE_in_doublenewline294); 
            		DOUBLENEWLINE20_tree = (object)adaptor.Create(DOUBLENEWLINE20);
            		adaptor.AddChild(root_0, DOUBLENEWLINE20_tree);


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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:80:1: broken_cmd : ( options {greedy=false; } : . )+ NEWLINE ;
    public tikzedt3Parser.broken_cmd_return broken_cmd() // throws RecognitionException [1]
    {   
        tikzedt3Parser.broken_cmd_return retval = new tikzedt3Parser.broken_cmd_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken wildcard21 = null;
        IToken NEWLINE22 = null;

        object wildcard21_tree=null;
        object NEWLINE22_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:81:2: ( ( options {greedy=false; } : . )+ NEWLINE )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:81:4: ( options {greedy=false; } : . )+ NEWLINE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:81:4: ( options {greedy=false; } : . )+
            	int cnt5 = 0;
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( (LA5_0 == NEWLINE) )
            	    {
            	        alt5 = 2;
            	    }
            	    else if ( ((LA5_0 >= TIKZEDT && LA5_0 <= SOMETHING_IN_CURLY_BRACKETS) || (LA5_0 >= TEX_CMD && LA5_0 <= 21)) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt3.g:81:39: .
            			    {
            			    	wildcard21 = (IToken)input.LT(1);
            			    	MatchAny(input); 
            			    		wildcard21_tree = (object)adaptor.Create(wildcard21);
            			    		adaptor.AddChild(root_0, wildcard21_tree);


            			    }
            			    break;

            			default:
            			    if ( cnt5 >= 1 ) goto loop5;
            		            EarlyExitException eee5 =
            		                new EarlyExitException(5, input);
            		            throw eee5;
            	    }
            	    cnt5++;
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements

            	NEWLINE22=(IToken)Match(input,NEWLINE,FOLLOW_NEWLINE_in_broken_cmd333); 
            		NEWLINE22_tree = (object)adaptor.Create(NEWLINE22);
            		adaptor.AddChild(root_0, NEWLINE22_tree);


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


   	protected DFA2 dfa2;
   	protected DFA3 dfa3;
	private void InitializeCyclicDFAs()
	{
    	this.dfa2 = new DFA2(this);
    	this.dfa3 = new DFA3(this);
	}

    const string DFA2_eotS =
        "\x16\uffff";
    const string DFA2_eofS =
        "\x01\x01\x08\uffff\x01\x06\x03\uffff\x03\x06\x02\uffff\x02\x06"+
        "\x02\uffff";
    const string DFA2_minS =
        "\x01\x04\x01\uffff\x01\x04\x04\uffff\x0d\x04\x02\uffff";
    const string DFA2_maxS =
        "\x01\x15\x01\uffff\x01\x15\x04\uffff\x0d\x15\x02\uffff";
    const string DFA2_acceptS =
        "\x01\uffff\x01\x06\x01\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x0d"+
        "\uffff\x02\x01";
    const string DFA2_specialS =
        "\x16\uffff}>";
    static readonly string[] DFA2_transitionS = {
            "\x05\x06\x01\x05\x01\x03\x01\x06\x01\x04\x05\x06\x01\x02\x03"+
            "\x06",
            "",
            "\x02\x06\x01\x07\x0f\x06",
            "",
            "",
            "",
            "",
            "\x0f\x06\x01\x08\x02\x06",
            "\x05\x0b\x01\x09\x0a\x0b\x01\x0a\x01\x0b",
            "\x05\x0b\x01\x0f\x01\x0d\x01\x0b\x01\x0e\x05\x0b\x01\x0c\x01"+
            "\x0b\x01\x0a\x01\x0b",
            "\x02\x0b\x01\x10\x02\x0b\x01\x09\x0a\x0b\x01\x0a\x01\x0b",
            "\x05\x0b\x01\x09\x0a\x0b\x01\x0a\x01\x0b",
            "\x02\x0b\x01\x11\x02\x0b\x01\x09\x0a\x0b\x01\x0a\x01\x0b",
            "\x03\x0b\x02\x13\x01\x12\x01\x0d\x01\x0b\x01\x0e\x05\x0b\x01"+
            "\x0c\x01\x0b\x01\x0a\x01\x13",
            "\x05\x0b\x01\x0f\x01\x0d\x01\x0b\x01\x0e\x05\x0b\x01\x0c\x01"+
            "\x0b\x01\x0a\x01\x0b",
            "\x05\x0b\x01\x0f\x01\x0d\x01\x0b\x01\x0e\x05\x0b\x01\x0c\x01"+
            "\x0b\x01\x0a\x01\x0b",
            "\x05\x0b\x01\x09\x09\x0b\x01\x14\x01\x0a\x01\x0b",
            "\x05\x0b\x01\x09\x09\x0b\x01\x15\x01\x0a\x01\x0b",
            "\x03\x0b\x02\x13\x01\x12\x01\x0d\x01\x0b\x01\x0e\x05\x0b\x01"+
            "\x0c\x01\x0b\x01\x0a\x01\x13",
            "\x03\x0b\x02\x13\x01\x12\x01\x0d\x01\x0b\x01\x0e\x05\x0b\x01"+
            "\x0c\x01\x0b\x01\x0a\x01\x13",
            "",
            ""
    };

    static readonly short[] DFA2_eot = DFA.UnpackEncodedString(DFA2_eotS);
    static readonly short[] DFA2_eof = DFA.UnpackEncodedString(DFA2_eofS);
    static readonly char[] DFA2_min = DFA.UnpackEncodedStringToUnsignedChars(DFA2_minS);
    static readonly char[] DFA2_max = DFA.UnpackEncodedStringToUnsignedChars(DFA2_maxS);
    static readonly short[] DFA2_accept = DFA.UnpackEncodedString(DFA2_acceptS);
    static readonly short[] DFA2_special = DFA.UnpackEncodedString(DFA2_specialS);
    static readonly short[][] DFA2_transition = DFA.UnpackEncodedStringArray(DFA2_transitionS);

    protected class DFA2 : DFA
    {
        public DFA2(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 2;
            this.eot = DFA2_eot;
            this.eof = DFA2_eof;
            this.min = DFA2_min;
            this.max = DFA2_max;
            this.accept = DFA2_accept;
            this.special = DFA2_special;
            this.transition = DFA2_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 43:6: ( begin_end_block | latex_cmd | doublenewline | newline | ( options {greedy=false; } : broken_cmd ) )*"; }
        }

    }

    const string DFA3_eotS =
        "\x14\uffff";
    const string DFA3_eofS =
        "\x04\uffff\x01\x07\x03\uffff\x03\x07\x02\uffff\x01\x07\x01\uffff"+
        "\x03\x07\x02\uffff";
    const string DFA3_minS =
        "\x02\x04\x01\uffff\x04\x04\x01\uffff\x0a\x04\x02\uffff";
    const string DFA3_maxS =
        "\x02\x15\x01\uffff\x04\x15\x01\uffff\x0a\x15\x02\uffff";
    const string DFA3_acceptS =
        "\x02\uffff\x01\x01\x04\uffff\x01\x02\x0a\uffff\x02\x02";
    const string DFA3_specialS =
        "\x14\uffff}>";
    static readonly string[] DFA3_transitionS = {
            "\x10\x02\x01\x01\x01\x02",
            "\x02\x02\x01\x03\x0f\x02",
            "",
            "\x0f\x02\x01\x04\x02\x02",
            "\x05\x0b\x01\x0a\x01\x08\x01\x0b\x01\x09\x05\x0b\x01\x06\x01"+
            "\x0b\x01\x05\x01\x0b",
            "\x02\x0b\x01\x0c\x02\x0b\x01\x0d\x0a\x0b\x01\x05\x01\x0b",
            "\x02\x0b\x01\x0e\x02\x0b\x01\x0d\x0a\x0b\x01\x05\x01\x0b",
            "",
            "\x03\x0b\x02\x10\x01\x0f\x01\x08\x01\x0b\x01\x09\x05\x0b\x01"+
            "\x06\x01\x0b\x01\x05\x01\x10",
            "\x05\x0b\x01\x11\x01\x08\x01\x0b\x01\x09\x05\x0b\x01\x06\x01"+
            "\x0b\x01\x05\x01\x0b",
            "\x05\x0b\x01\x11\x01\x08\x01\x0b\x01\x09\x05\x0b\x01\x06\x01"+
            "\x0b\x01\x05\x01\x0b",
            "\x05\x0b\x01\x0d\x0a\x0b\x01\x05\x01\x0b",
            "\x05\x0b\x01\x0d\x09\x0b\x01\x12\x01\x05\x01\x0b",
            "\x05\x0b\x01\x11\x01\x08\x01\x0b\x01\x09\x05\x0b\x01\x06\x01"+
            "\x0b\x01\x05\x01\x0b",
            "\x05\x0b\x01\x0d\x09\x0b\x01\x13\x01\x05\x01\x0b",
            "\x03\x0b\x02\x10\x01\x0f\x01\x08\x01\x0b\x01\x09\x05\x0b\x01"+
            "\x06\x01\x0b\x01\x05\x01\x10",
            "\x03\x0b\x02\x10\x01\x0f\x01\x08\x01\x0b\x01\x09\x05\x0b\x01"+
            "\x06\x01\x0b\x01\x05\x01\x10",
            "\x05\x0b\x01\x11\x01\x08\x01\x0b\x01\x09\x05\x0b\x01\x06\x01"+
            "\x0b\x01\x05\x01\x0b",
            "",
            ""
    };

    static readonly short[] DFA3_eot = DFA.UnpackEncodedString(DFA3_eotS);
    static readonly short[] DFA3_eof = DFA.UnpackEncodedString(DFA3_eofS);
    static readonly char[] DFA3_min = DFA.UnpackEncodedStringToUnsignedChars(DFA3_minS);
    static readonly char[] DFA3_max = DFA.UnpackEncodedStringToUnsignedChars(DFA3_maxS);
    static readonly short[] DFA3_accept = DFA.UnpackEncodedString(DFA3_acceptS);
    static readonly short[] DFA3_special = DFA.UnpackEncodedString(DFA3_specialS);
    static readonly short[][] DFA3_transition = DFA.UnpackEncodedStringArray(DFA3_transitionS);

    protected class DFA3 : DFA
    {
        public DFA3(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 3;
            this.eot = DFA3_eot;
            this.eof = DFA3_eof;
            this.min = DFA3_min;
            this.max = DFA3_max;
            this.accept = DFA3_accept;
            this.special = DFA3_special;
            this.transition = DFA3_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 56:3: ( options {greedy=false; } : . )*"; }
        }

    }

 

    public static readonly BitSet FOLLOW_tikzedt_cmd_comment_in_tikzdocument67 = new BitSet(new ulong[]{0x00000000003FFFF0UL});
    public static readonly BitSet FOLLOW_begin_end_block_in_tikzdocument101 = new BitSet(new ulong[]{0x00000000003FFFF0UL});
    public static readonly BitSet FOLLOW_latex_cmd_in_tikzdocument109 = new BitSet(new ulong[]{0x00000000003FFFF0UL});
    public static readonly BitSet FOLLOW_doublenewline_in_tikzdocument117 = new BitSet(new ulong[]{0x00000000003FFFF0UL});
    public static readonly BitSet FOLLOW_newline_in_tikzdocument125 = new BitSet(new ulong[]{0x00000000003FFFF0UL});
    public static readonly BitSet FOLLOW_broken_cmd_in_tikzdocument149 = new BitSet(new ulong[]{0x00000000003FFFF0UL});
    public static readonly BitSet FOLLOW_EOF_in_tikzdocument165 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_18_in_begin_end_block177 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_ID_in_begin_end_block178 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_begin_end_block179 = new BitSet(new ulong[]{0x00000000003FFFF0UL});
    public static readonly BitSet FOLLOW_20_in_begin_end_block212 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_ID_in_begin_end_block213 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_begin_end_block214 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_cmd_name_in_latex_cmd228 = new BitSet(new ulong[]{0x0000000000200382UL});
    public static readonly BitSet FOLLOW_set_in_latex_cmd230 = new BitSet(new ulong[]{0x0000000000200382UL});
    public static readonly BitSet FOLLOW_TEX_CMD_in_cmd_name257 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TIKZEDT_CMD_COMMENT_in_tikzedt_cmd_comment267 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_newline282 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DOUBLENEWLINE_in_doublenewline294 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_broken_cmd333 = new BitSet(new ulong[]{0x0000000000000002UL});

}
