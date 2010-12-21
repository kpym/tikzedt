// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g 2010-12-21 07:56:41

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

public partial class tikzedt4Parser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"TIKZEDT", 
		"INPUT", 
		"SOMETHING_IN_BRACKETS", 
		"SOMETHING_IN_CURLY_BRACKETS", 
		"NEWLINE", 
		"TEX_CMD", 
		"TIKZEDT_CMD_COMMENT", 
		"DOUBLENEWLINE", 
		"WS", 
		"COMMENT", 
		"ID", 
		"INT", 
		"FLOAT", 
		"HEX_DIGIT", 
		"'='"
    };

    public const int SOMETHING_IN_BRACKETS = 6;
    public const int WS = 12;
    public const int TIKZEDT_CMD_COMMENT = 10;
    public const int NEWLINE = 8;
    public const int T__18 = 18;
    public const int TIKZEDT = 4;
    public const int INPUT = 5;
    public const int HEX_DIGIT = 17;
    public const int FLOAT = 16;
    public const int INT = 15;
    public const int ID = 14;
    public const int COMMENT = 13;
    public const int EOF = -1;
    public const int SOMETHING_IN_CURLY_BRACKETS = 7;
    public const int DOUBLENEWLINE = 11;
    public const int TEX_CMD = 9;

    // delegates
    // delegators



        public tikzedt4Parser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public tikzedt4Parser(ITokenStream input, RecognizerSharedState state)
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
		get { return tikzedt4Parser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g"; }
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:36:1: tikzdocument : ( tikzedt_cmd_comment )* ( options {greedy=true; } : ( latex_cmd | doublenewline | newline | ( options {greedy=false; } : broken_cmd ) )* ) EOF ;
    public tikzedt4Parser.tikzdocument_return tikzdocument() // throws RecognitionException [1]
    {   
        tikzedt4Parser.tikzdocument_return retval = new tikzedt4Parser.tikzdocument_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EOF6 = null;
        tikzedt4Parser.tikzedt_cmd_comment_return tikzedt_cmd_comment1 = default(tikzedt4Parser.tikzedt_cmd_comment_return);

        tikzedt4Parser.latex_cmd_return latex_cmd2 = default(tikzedt4Parser.latex_cmd_return);

        tikzedt4Parser.doublenewline_return doublenewline3 = default(tikzedt4Parser.doublenewline_return);

        tikzedt4Parser.newline_return newline4 = default(tikzedt4Parser.newline_return);

        tikzedt4Parser.broken_cmd_return broken_cmd5 = default(tikzedt4Parser.broken_cmd_return);


        object EOF6_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:41:2: ( ( tikzedt_cmd_comment )* ( options {greedy=true; } : ( latex_cmd | doublenewline | newline | ( options {greedy=false; } : broken_cmd ) )* ) EOF )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:41:4: ( tikzedt_cmd_comment )* ( options {greedy=true; } : ( latex_cmd | doublenewline | newline | ( options {greedy=false; } : broken_cmd ) )* ) EOF
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:41:4: ( tikzedt_cmd_comment )*
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
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:41:6: tikzedt_cmd_comment
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

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:42:3: ( options {greedy=true; } : ( latex_cmd | doublenewline | newline | ( options {greedy=false; } : broken_cmd ) )* )
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:43:6: ( latex_cmd | doublenewline | newline | ( options {greedy=false; } : broken_cmd ) )*
            	{
            		// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:43:6: ( latex_cmd | doublenewline | newline | ( options {greedy=false; } : broken_cmd ) )*
            		do 
            		{
            		    int alt2 = 5;
            		    switch ( input.LA(1) ) 
            		    {
            		    case TEX_CMD:
            		    	{
            		        alt2 = 1;
            		        }
            		        break;
            		    case DOUBLENEWLINE:
            		    	{
            		        alt2 = 2;
            		        }
            		        break;
            		    case NEWLINE:
            		    	{
            		        alt2 = 3;
            		        }
            		        break;
            		    case TIKZEDT:
            		    case INPUT:
            		    case SOMETHING_IN_BRACKETS:
            		    case SOMETHING_IN_CURLY_BRACKETS:
            		    case TIKZEDT_CMD_COMMENT:
            		    case WS:
            		    case COMMENT:
            		    case ID:
            		    case INT:
            		    case FLOAT:
            		    case HEX_DIGIT:
            		    case 18:
            		    	{
            		        alt2 = 4;
            		        }
            		        break;

            		    }

            		    switch (alt2) 
            			{
            				case 1 :
            				    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:45:9: latex_cmd
            				    {
            				    	PushFollow(FOLLOW_latex_cmd_in_tikzdocument103);
            				    	latex_cmd2 = latex_cmd();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, latex_cmd2.Tree);

            				    }
            				    break;
            				case 2 :
            				    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:46:7: doublenewline
            				    {
            				    	PushFollow(FOLLOW_doublenewline_in_tikzdocument111);
            				    	doublenewline3 = doublenewline();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, doublenewline3.Tree);

            				    }
            				    break;
            				case 3 :
            				    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:47:7: newline
            				    {
            				    	PushFollow(FOLLOW_newline_in_tikzdocument119);
            				    	newline4 = newline();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, newline4.Tree);

            				    }
            				    break;
            				case 4 :
            				    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:48:7: ( options {greedy=false; } : broken_cmd )
            				    {
            				    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:48:7: ( options {greedy=false; } : broken_cmd )
            				    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:48:39: broken_cmd
            				    	{
            				    		PushFollow(FOLLOW_broken_cmd_in_tikzdocument143);
            				    		broken_cmd5 = broken_cmd();
            				    		state.followingStackPointer--;

            				    		adaptor.AddChild(root_0, broken_cmd5.Tree);

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

            	EOF6=(IToken)Match(input,EOF,FOLLOW_EOF_in_tikzdocument159); 
            		EOF6_tree = (object)adaptor.Create(EOF6);
            		adaptor.AddChild(root_0, EOF6_tree);


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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:64:1: latex_cmd : cmd_name ( SOMETHING_IN_BRACKETS | SOMETHING_IN_CURLY_BRACKETS | '=' | NEWLINE )* ;
    public tikzedt4Parser.latex_cmd_return latex_cmd() // throws RecognitionException [1]
    {   
        tikzedt4Parser.latex_cmd_return retval = new tikzedt4Parser.latex_cmd_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set8 = null;
        tikzedt4Parser.cmd_name_return cmd_name7 = default(tikzedt4Parser.cmd_name_return);


        object set8_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:65:2: ( cmd_name ( SOMETHING_IN_BRACKETS | SOMETHING_IN_CURLY_BRACKETS | '=' | NEWLINE )* )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:65:4: cmd_name ( SOMETHING_IN_BRACKETS | SOMETHING_IN_CURLY_BRACKETS | '=' | NEWLINE )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_cmd_name_in_latex_cmd176);
            	cmd_name7 = cmd_name();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, cmd_name7.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:65:13: ( SOMETHING_IN_BRACKETS | SOMETHING_IN_CURLY_BRACKETS | '=' | NEWLINE )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == NEWLINE) )
            	    {
            	        alt3 = 1;
            	    }
            	    else if ( ((LA3_0 >= SOMETHING_IN_BRACKETS && LA3_0 <= SOMETHING_IN_CURLY_BRACKETS) || LA3_0 == 18) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:
            			    {
            			    	set8 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= SOMETHING_IN_BRACKETS && input.LA(1) <= NEWLINE) || input.LA(1) == 18 ) 
            			    	{
            			    	    input.Consume();
            			    	    adaptor.AddChild(root_0, (object)adaptor.Create(set8));
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
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements


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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:68:1: cmd_name : TEX_CMD ;
    public tikzedt4Parser.cmd_name_return cmd_name() // throws RecognitionException [1]
    {   
        tikzedt4Parser.cmd_name_return retval = new tikzedt4Parser.cmd_name_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken TEX_CMD9 = null;

        object TEX_CMD9_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:68:10: ( TEX_CMD )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:68:12: TEX_CMD
            {
            	root_0 = (object)adaptor.GetNilNode();

            	TEX_CMD9=(IToken)Match(input,TEX_CMD,FOLLOW_TEX_CMD_in_cmd_name205); 
            		TEX_CMD9_tree = (object)adaptor.Create(TEX_CMD9);
            		adaptor.AddChild(root_0, TEX_CMD9_tree);


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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:70:1: tikzedt_cmd_comment : TIKZEDT_CMD_COMMENT ;
    public tikzedt4Parser.tikzedt_cmd_comment_return tikzedt_cmd_comment() // throws RecognitionException [1]
    {   
        tikzedt4Parser.tikzedt_cmd_comment_return retval = new tikzedt4Parser.tikzedt_cmd_comment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken TIKZEDT_CMD_COMMENT10 = null;

        object TIKZEDT_CMD_COMMENT10_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:71:2: ( TIKZEDT_CMD_COMMENT )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:71:4: TIKZEDT_CMD_COMMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	TIKZEDT_CMD_COMMENT10=(IToken)Match(input,TIKZEDT_CMD_COMMENT,FOLLOW_TIKZEDT_CMD_COMMENT_in_tikzedt_cmd_comment215); 
            		TIKZEDT_CMD_COMMENT10_tree = (object)adaptor.Create(TIKZEDT_CMD_COMMENT10);
            		adaptor.AddChild(root_0, TIKZEDT_CMD_COMMENT10_tree);


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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:74:1: newline : NEWLINE ;
    public tikzedt4Parser.newline_return newline() // throws RecognitionException [1]
    {   
        tikzedt4Parser.newline_return retval = new tikzedt4Parser.newline_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NEWLINE11 = null;

        object NEWLINE11_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:75:2: ( NEWLINE )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:75:5: NEWLINE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	NEWLINE11=(IToken)Match(input,NEWLINE,FOLLOW_NEWLINE_in_newline230); 
            		NEWLINE11_tree = (object)adaptor.Create(NEWLINE11);
            		adaptor.AddChild(root_0, NEWLINE11_tree);


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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:77:1: doublenewline : DOUBLENEWLINE ;
    public tikzedt4Parser.doublenewline_return doublenewline() // throws RecognitionException [1]
    {   
        tikzedt4Parser.doublenewline_return retval = new tikzedt4Parser.doublenewline_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken DOUBLENEWLINE12 = null;

        object DOUBLENEWLINE12_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:78:2: ( DOUBLENEWLINE )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:78:5: DOUBLENEWLINE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	DOUBLENEWLINE12=(IToken)Match(input,DOUBLENEWLINE,FOLLOW_DOUBLENEWLINE_in_doublenewline242); 
            		DOUBLENEWLINE12_tree = (object)adaptor.Create(DOUBLENEWLINE12);
            		adaptor.AddChild(root_0, DOUBLENEWLINE12_tree);


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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:82:1: broken_cmd : ( options {greedy=false; } : . )+ NEWLINE ;
    public tikzedt4Parser.broken_cmd_return broken_cmd() // throws RecognitionException [1]
    {   
        tikzedt4Parser.broken_cmd_return retval = new tikzedt4Parser.broken_cmd_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken wildcard13 = null;
        IToken NEWLINE14 = null;

        object wildcard13_tree=null;
        object NEWLINE14_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:83:2: ( ( options {greedy=false; } : . )+ NEWLINE )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:83:4: ( options {greedy=false; } : . )+ NEWLINE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:83:4: ( options {greedy=false; } : . )+
            	int cnt4 = 0;
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == NEWLINE) )
            	    {
            	        alt4 = 2;
            	    }
            	    else if ( ((LA4_0 >= TIKZEDT && LA4_0 <= SOMETHING_IN_CURLY_BRACKETS) || (LA4_0 >= TEX_CMD && LA4_0 <= 18)) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt4.g:83:39: .
            			    {
            			    	wildcard13 = (IToken)input.LT(1);
            			    	MatchAny(input); 
            			    		wildcard13_tree = (object)adaptor.Create(wildcard13);
            			    		adaptor.AddChild(root_0, wildcard13_tree);


            			    }
            			    break;

            			default:
            			    if ( cnt4 >= 1 ) goto loop4;
            		            EarlyExitException eee4 =
            		                new EarlyExitException(4, input);
            		            throw eee4;
            	    }
            	    cnt4++;
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements

            	NEWLINE14=(IToken)Match(input,NEWLINE,FOLLOW_NEWLINE_in_broken_cmd281); 
            		NEWLINE14_tree = (object)adaptor.Create(NEWLINE14);
            		adaptor.AddChild(root_0, NEWLINE14_tree);


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

 

    public static readonly BitSet FOLLOW_tikzedt_cmd_comment_in_tikzdocument67 = new BitSet(new ulong[]{0x000000000007FFF0UL});
    public static readonly BitSet FOLLOW_latex_cmd_in_tikzdocument103 = new BitSet(new ulong[]{0x000000000007FFF0UL});
    public static readonly BitSet FOLLOW_doublenewline_in_tikzdocument111 = new BitSet(new ulong[]{0x000000000007FFF0UL});
    public static readonly BitSet FOLLOW_newline_in_tikzdocument119 = new BitSet(new ulong[]{0x000000000007FFF0UL});
    public static readonly BitSet FOLLOW_broken_cmd_in_tikzdocument143 = new BitSet(new ulong[]{0x000000000007FFF0UL});
    public static readonly BitSet FOLLOW_EOF_in_tikzdocument159 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_cmd_name_in_latex_cmd176 = new BitSet(new ulong[]{0x00000000000401C2UL});
    public static readonly BitSet FOLLOW_set_in_latex_cmd178 = new BitSet(new ulong[]{0x00000000000401C2UL});
    public static readonly BitSet FOLLOW_TEX_CMD_in_cmd_name205 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TIKZEDT_CMD_COMMENT_in_tikzedt_cmd_comment215 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_newline230 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DOUBLENEWLINE_in_doublenewline242 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_broken_cmd281 = new BitSet(new ulong[]{0x0000000000000002UL});

}
