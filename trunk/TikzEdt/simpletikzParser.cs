// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g 2010-12-18 17:40:56

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

public partial class simpletikzParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"BEGIN", 
		"END", 
		"USETIKZLIB", 
		"TIKZSTYLE", 
		"TIKZSET", 
		"NODE", 
		"DRAW", 
		"PATH", 
		"FILL", 
		"LPAR", 
		"RPAR", 
		"LBR", 
		"RBR", 
		"LBRR", 
		"RBRR", 
		"KOMMA", 
		"EQU", 
		"SEMIC", 
		"COLON", 
		"IM_PATH", 
		"IM_NODE", 
		"IM_COORD", 
		"IM_NODENAME", 
		"IM_NUMBERUNIT", 
		"IM_PICTURE", 
		"IM_DOCUMENT", 
		"IM_SCOPE", 
		"IM_STARTTAG", 
		"IM_ENDTAG", 
		"IM_OPTIONS", 
		"IM_TIKZEDT_CMD", 
		"IM_OPTION_STYLE", 
		"IM_OPTION_KV", 
		"IM_ID", 
		"IM_TIKZSET", 
		"IM_USETIKZLIB", 
		"IM_STRING", 
		"IM_STYLE", 
		"TIKZEDT_CMD_COMMENT", 
		"INT", 
		"FLOAT_WO_EXP", 
		"ID", 
		"WS", 
		"COMMENT", 
		"EXPONENT", 
		"ESC_SEQ", 
		"MATHSTRING", 
		"COMMAND", 
		"SOMETHING", 
		"'/.style'", 
		"'cm'", 
		"'in'", 
		"'ex'", 
		"'mm'", 
		"'pt'", 
		"'em'", 
		"'at'", 
		"'--'", 
		"'->'", 
		"'|-'", 
		"'-|'", 
		"'+'", 
		"'++'", 
		"'tikzpicture'", 
		"'scope'"
    };

    public const int T__68 = 68;
    public const int T__66 = 66;
    public const int EXPONENT = 48;
    public const int T__67 = 67;
    public const int T__64 = 64;
    public const int TIKZEDT_CMD_COMMENT = 42;
    public const int IM_STARTTAG = 31;
    public const int T__65 = 65;
    public const int T__62 = 62;
    public const int T__63 = 63;
    public const int RBR = 16;
    public const int IM_PATH = 23;
    public const int IM_ID = 37;
    public const int SOMETHING = 52;
    public const int ID = 45;
    public const int T__61 = 61;
    public const int T__60 = 60;
    public const int EOF = -1;
    public const int MATHSTRING = 50;
    public const int LBR = 15;
    public const int COMMAND = 51;
    public const int IM_ENDTAG = 32;
    public const int IM_USETIKZLIB = 39;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int IM_DOCUMENT = 29;
    public const int T__58 = 58;
    public const int RBRR = 18;
    public const int ESC_SEQ = 49;
    public const int IM_STRING = 40;
    public const int T__53 = 53;
    public const int LPAR = 13;
    public const int T__54 = 54;
    public const int FILL = 12;
    public const int PATH = 11;
    public const int IM_TIKZSET = 38;
    public const int T__59 = 59;
    public const int BEGIN = 4;
    public const int IM_OPTION_KV = 36;
    public const int COMMENT = 47;
    public const int IM_TIKZEDT_CMD = 34;
    public const int IM_OPTIONS = 33;
    public const int IM_OPTION_STYLE = 35;
    public const int NODE = 9;
    public const int TIKZSTYLE = 7;
    public const int TIKZSET = 8;
    public const int IM_COORD = 25;
    public const int IM_PICTURE = 28;
    public const int INT = 43;
    public const int LBRR = 17;
    public const int USETIKZLIB = 6;
    public const int IM_NODE = 24;
    public const int IM_STYLE = 41;
    public const int COLON = 22;
    public const int IM_SCOPE = 30;
    public const int IM_NUMBERUNIT = 27;
    public const int WS = 46;
    public const int KOMMA = 19;
    public const int EQU = 20;
    public const int RPAR = 14;
    public const int END = 5;
    public const int SEMIC = 21;
    public const int IM_NODENAME = 26;
    public const int FLOAT_WO_EXP = 44;
    public const int DRAW = 10;

    // delegates
    // delegators



        public simpletikzParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public simpletikzParser(ITokenStream input, RecognizerSharedState state)
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
		get { return simpletikzParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g"; }
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:88:1: tikzdocument : ( tikz_styleorsetorcmd | dontcare_preamble | otherbegin )* ( tikzpicture )? -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* ( tikzpicture )? ) ;
    public simpletikzParser.tikzdocument_return tikzdocument() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzdocument_return retval = new simpletikzParser.tikzdocument_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikz_styleorsetorcmd_return tikz_styleorsetorcmd1 = default(simpletikzParser.tikz_styleorsetorcmd_return);

        simpletikzParser.dontcare_preamble_return dontcare_preamble2 = default(simpletikzParser.dontcare_preamble_return);

        simpletikzParser.otherbegin_return otherbegin3 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.tikzpicture_return tikzpicture4 = default(simpletikzParser.tikzpicture_return);


        RewriteRuleSubtreeStream stream_dontcare_preamble = new RewriteRuleSubtreeStream(adaptor,"rule dontcare_preamble");
        RewriteRuleSubtreeStream stream_tikzpicture = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture");
        RewriteRuleSubtreeStream stream_otherbegin = new RewriteRuleSubtreeStream(adaptor,"rule otherbegin");
        RewriteRuleSubtreeStream stream_tikz_styleorsetorcmd = new RewriteRuleSubtreeStream(adaptor,"rule tikz_styleorsetorcmd");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:2: ( ( tikz_styleorsetorcmd | dontcare_preamble | otherbegin )* ( tikzpicture )? -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* ( tikzpicture )? ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:5: ( tikz_styleorsetorcmd | dontcare_preamble | otherbegin )* ( tikzpicture )?
            {
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:5: ( tikz_styleorsetorcmd | dontcare_preamble | otherbegin )*
            	do 
            	{
            	    int alt1 = 4;
            	    switch ( input.LA(1) ) 
            	    {
            	    case BEGIN:
            	    	{
            	        int LA1_1 = input.LA(2);

            	        if ( (LA1_1 == LBRR) )
            	        {
            	            int LA1_5 = input.LA(3);

            	            if ( (LA1_5 == ID || (LA1_5 >= 61 && LA1_5 <= 64)) )
            	            {
            	                alt1 = 3;
            	            }


            	        }


            	        }
            	        break;
            	    case TIKZSTYLE:
            	    case TIKZSET:
            	    case TIKZEDT_CMD_COMMENT:
            	    	{
            	        alt1 = 1;
            	        }
            	        break;
            	    case END:
            	    case USETIKZLIB:
            	    case NODE:
            	    case DRAW:
            	    case PATH:
            	    case FILL:
            	    case LPAR:
            	    case RPAR:
            	    case LBR:
            	    case RBR:
            	    case LBRR:
            	    case RBRR:
            	    case KOMMA:
            	    case EQU:
            	    case SEMIC:
            	    case COLON:
            	    case IM_PATH:
            	    case IM_NODE:
            	    case IM_COORD:
            	    case IM_NODENAME:
            	    case IM_NUMBERUNIT:
            	    case IM_PICTURE:
            	    case IM_DOCUMENT:
            	    case IM_SCOPE:
            	    case IM_STARTTAG:
            	    case IM_ENDTAG:
            	    case IM_OPTIONS:
            	    case IM_TIKZEDT_CMD:
            	    case IM_OPTION_STYLE:
            	    case IM_OPTION_KV:
            	    case IM_ID:
            	    case IM_TIKZSET:
            	    case IM_USETIKZLIB:
            	    case IM_STRING:
            	    case IM_STYLE:
            	    case INT:
            	    case FLOAT_WO_EXP:
            	    case ID:
            	    case WS:
            	    case COMMENT:
            	    case EXPONENT:
            	    case ESC_SEQ:
            	    case MATHSTRING:
            	    case COMMAND:
            	    case SOMETHING:
            	    case 53:
            	    case 54:
            	    case 55:
            	    case 56:
            	    case 57:
            	    case 58:
            	    case 59:
            	    case 60:
            	    case 61:
            	    case 62:
            	    case 63:
            	    case 64:
            	    case 65:
            	    case 66:
            	    case 67:
            	    case 68:
            	    	{
            	        alt1 = 2;
            	        }
            	        break;

            	    }

            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:7: tikz_styleorsetorcmd
            			    {
            			    	PushFollow(FOLLOW_tikz_styleorsetorcmd_in_tikzdocument344);
            			    	tikz_styleorsetorcmd1 = tikz_styleorsetorcmd();
            			    	state.followingStackPointer--;

            			    	stream_tikz_styleorsetorcmd.Add(tikz_styleorsetorcmd1.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:30: dontcare_preamble
            			    {
            			    	PushFollow(FOLLOW_dontcare_preamble_in_tikzdocument348);
            			    	dontcare_preamble2 = dontcare_preamble();
            			    	state.followingStackPointer--;

            			    	stream_dontcare_preamble.Add(dontcare_preamble2.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:50: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzdocument352);
            			    	otherbegin3 = otherbegin();
            			    	state.followingStackPointer--;

            			    	stream_otherbegin.Add(otherbegin3.Tree);

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:64: ( tikzpicture )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == BEGIN) )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:64: tikzpicture
            	        {
            	        	PushFollow(FOLLOW_tikzpicture_in_tikzdocument357);
            	        	tikzpicture4 = tikzpicture();
            	        	state.followingStackPointer--;

            	        	stream_tikzpicture.Add(tikzpicture4.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          tikzpicture, tikz_styleorsetorcmd
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 89:80: -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* ( tikzpicture )? )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:83: ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* ( tikzpicture )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DOCUMENT, "IM_DOCUMENT"), root_1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:97: ( tikz_styleorsetorcmd )*
            	    while ( stream_tikz_styleorsetorcmd.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikz_styleorsetorcmd.NextTree());

            	    }
            	    stream_tikz_styleorsetorcmd.Reset();
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:119: ( tikzpicture )?
            	    if ( stream_tikzpicture.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzpicture.NextTree());

            	    }
            	    stream_tikzpicture.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
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

    public class tikz_styleorsetorcmd_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikz_styleorsetorcmd"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:92:1: tikz_styleorsetorcmd : ( tikz_style | tikz_set | tikz_cmd_comment );
    public simpletikzParser.tikz_styleorsetorcmd_return tikz_styleorsetorcmd() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_styleorsetorcmd_return retval = new simpletikzParser.tikz_styleorsetorcmd_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikz_style_return tikz_style5 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.tikz_set_return tikz_set6 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_cmd_comment_return tikz_cmd_comment7 = default(simpletikzParser.tikz_cmd_comment_return);



        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:93:2: ( tikz_style | tikz_set | tikz_cmd_comment )
            int alt3 = 3;
            switch ( input.LA(1) ) 
            {
            case TIKZSTYLE:
            	{
                alt3 = 1;
                }
                break;
            case TIKZSET:
            	{
                alt3 = 2;
                }
                break;
            case TIKZEDT_CMD_COMMENT:
            	{
                alt3 = 3;
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
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:93:4: tikz_style
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_style_in_tikz_styleorsetorcmd384);
                    	tikz_style5 = tikz_style();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, tikz_style5.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:93:17: tikz_set
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_set_in_tikz_styleorsetorcmd388);
                    	tikz_set6 = tikz_set();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, tikz_set6.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:93:28: tikz_cmd_comment
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_cmd_comment_in_tikz_styleorsetorcmd392);
                    	tikz_cmd_comment7 = tikz_cmd_comment();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, tikz_cmd_comment7.Tree);

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
    // $ANTLR end "tikz_styleorsetorcmd"

    public class dontcare_preamble_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "dontcare_preamble"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:96:1: dontcare_preamble : ~ ( BEGIN | TIKZSTYLE | TIKZSET | TIKZEDT_CMD_COMMENT ) ;
    public simpletikzParser.dontcare_preamble_return dontcare_preamble() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_preamble_return retval = new simpletikzParser.dontcare_preamble_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set8 = null;

        object set8_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:97:2: (~ ( BEGIN | TIKZSTYLE | TIKZSET | TIKZEDT_CMD_COMMENT ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:97:4: ~ ( BEGIN | TIKZSTYLE | TIKZSET | TIKZEDT_CMD_COMMENT )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set8 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= END && input.LA(1) <= USETIKZLIB) || (input.LA(1) >= NODE && input.LA(1) <= IM_STYLE) || (input.LA(1) >= INT && input.LA(1) <= 68) ) 
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
    // $ANTLR end "dontcare_preamble"

    public class otherbegin_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "otherbegin"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:99:1: otherbegin : BEGIN LBRR idd RBRR ;
    public simpletikzParser.otherbegin_return otherbegin() // throws RecognitionException [1]
    {   
        simpletikzParser.otherbegin_return retval = new simpletikzParser.otherbegin_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken BEGIN9 = null;
        IToken LBRR10 = null;
        IToken RBRR12 = null;
        simpletikzParser.idd_return idd11 = default(simpletikzParser.idd_return);


        object BEGIN9_tree=null;
        object LBRR10_tree=null;
        object RBRR12_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:2: ( BEGIN LBRR idd RBRR )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:4: BEGIN LBRR idd RBRR
            {
            	root_0 = (object)adaptor.GetNilNode();

            	BEGIN9=(IToken)Match(input,BEGIN,FOLLOW_BEGIN_in_otherbegin428); 
            		BEGIN9_tree = (object)adaptor.Create(BEGIN9);
            		adaptor.AddChild(root_0, BEGIN9_tree);

            	LBRR10=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_otherbegin430); 
            		LBRR10_tree = (object)adaptor.Create(LBRR10);
            		adaptor.AddChild(root_0, LBRR10_tree);

            	PushFollow(FOLLOW_idd_in_otherbegin432);
            	idd11 = idd();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, idd11.Tree);
            	RBRR12=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_otherbegin434); 
            		RBRR12_tree = (object)adaptor.Create(RBRR12);
            		adaptor.AddChild(root_0, RBRR12_tree);


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
    // $ANTLR end "otherbegin"

    public class tikz_cmd_comment_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikz_cmd_comment"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:104:1: tikz_cmd_comment : TIKZEDT_CMD_COMMENT -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT ) ;
    public simpletikzParser.tikz_cmd_comment_return tikz_cmd_comment() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_cmd_comment_return retval = new simpletikzParser.tikz_cmd_comment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken TIKZEDT_CMD_COMMENT13 = null;

        object TIKZEDT_CMD_COMMENT13_tree=null;
        RewriteRuleTokenStream stream_TIKZEDT_CMD_COMMENT = new RewriteRuleTokenStream(adaptor,"token TIKZEDT_CMD_COMMENT");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:105:2: ( TIKZEDT_CMD_COMMENT -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:105:4: TIKZEDT_CMD_COMMENT
            {
            	TIKZEDT_CMD_COMMENT13=(IToken)Match(input,TIKZEDT_CMD_COMMENT,FOLLOW_TIKZEDT_CMD_COMMENT_in_tikz_cmd_comment447);  
            	stream_TIKZEDT_CMD_COMMENT.Add(TIKZEDT_CMD_COMMENT13);



            	// AST REWRITE
            	// elements:          TIKZEDT_CMD_COMMENT
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 105:25: -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:105:28: ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_TIKZEDT_CMD, "IM_TIKZEDT_CMD"), root_1);

            	    adaptor.AddChild(root_1, stream_TIKZEDT_CMD_COMMENT.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
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
    // $ANTLR end "tikz_cmd_comment"

    public class tikz_style_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikz_style"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:112:1: tikz_style : TIKZSTYLE LBRR idd RBRR '=' tikz_options -> ^( IM_STYLE idd tikz_options ) ;
    public simpletikzParser.tikz_style_return tikz_style() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_style_return retval = new simpletikzParser.tikz_style_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken TIKZSTYLE14 = null;
        IToken LBRR15 = null;
        IToken RBRR17 = null;
        IToken char_literal18 = null;
        simpletikzParser.idd_return idd16 = default(simpletikzParser.idd_return);

        simpletikzParser.tikz_options_return tikz_options19 = default(simpletikzParser.tikz_options_return);


        object TIKZSTYLE14_tree=null;
        object LBRR15_tree=null;
        object RBRR17_tree=null;
        object char_literal18_tree=null;
        RewriteRuleTokenStream stream_EQU = new RewriteRuleTokenStream(adaptor,"token EQU");
        RewriteRuleTokenStream stream_RBRR = new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_TIKZSTYLE = new RewriteRuleTokenStream(adaptor,"token TIKZSTYLE");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:113:2: ( TIKZSTYLE LBRR idd RBRR '=' tikz_options -> ^( IM_STYLE idd tikz_options ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:113:4: TIKZSTYLE LBRR idd RBRR '=' tikz_options
            {
            	TIKZSTYLE14=(IToken)Match(input,TIKZSTYLE,FOLLOW_TIKZSTYLE_in_tikz_style472);  
            	stream_TIKZSTYLE.Add(TIKZSTYLE14);

            	LBRR15=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_tikz_style474);  
            	stream_LBRR.Add(LBRR15);

            	PushFollow(FOLLOW_idd_in_tikz_style476);
            	idd16 = idd();
            	state.followingStackPointer--;

            	stream_idd.Add(idd16.Tree);
            	RBRR17=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_tikz_style478);  
            	stream_RBRR.Add(RBRR17);

            	char_literal18=(IToken)Match(input,EQU,FOLLOW_EQU_in_tikz_style480);  
            	stream_EQU.Add(char_literal18);

            	PushFollow(FOLLOW_tikz_options_in_tikz_style482);
            	tikz_options19 = tikz_options();
            	state.followingStackPointer--;

            	stream_tikz_options.Add(tikz_options19.Tree);


            	// AST REWRITE
            	// elements:          idd, tikz_options
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 113:45: -> ^( IM_STYLE idd tikz_options )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:113:48: ^( IM_STYLE idd tikz_options )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STYLE, "IM_STYLE"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    adaptor.AddChild(root_1, stream_tikz_options.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
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
    // $ANTLR end "tikz_style"

    public class tikz_options_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikz_options"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:116:1: tikz_options : squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) ;
    public simpletikzParser.tikz_options_return tikz_options() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_options_return retval = new simpletikzParser.tikz_options_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal22 = null;
        IToken char_literal24 = null;
        simpletikzParser.squarebr_start_return squarebr_start20 = default(simpletikzParser.squarebr_start_return);

        simpletikzParser.option_return option21 = default(simpletikzParser.option_return);

        simpletikzParser.option_return option23 = default(simpletikzParser.option_return);

        simpletikzParser.squarebr_end_return squarebr_end25 = default(simpletikzParser.squarebr_end_return);


        object char_literal22_tree=null;
        object char_literal24_tree=null;
        RewriteRuleTokenStream stream_KOMMA = new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_squarebr_start = new RewriteRuleSubtreeStream(adaptor,"rule squarebr_start");
        RewriteRuleSubtreeStream stream_squarebr_end = new RewriteRuleSubtreeStream(adaptor,"rule squarebr_end");
        RewriteRuleSubtreeStream stream_option = new RewriteRuleSubtreeStream(adaptor,"rule option");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:2: ( squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:5: squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end
            {
            	PushFollow(FOLLOW_squarebr_start_in_tikz_options504);
            	squarebr_start20 = squarebr_start();
            	state.followingStackPointer--;

            	stream_squarebr_start.Add(squarebr_start20.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:20: ( option ( ',' option )* ( ',' )? )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( (LA6_0 == ID || (LA6_0 >= 61 && LA6_0 <= 64)) )
            	{
            	    alt6 = 1;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:21: option ( ',' option )* ( ',' )?
            	        {
            	        	PushFollow(FOLLOW_option_in_tikz_options507);
            	        	option21 = option();
            	        	state.followingStackPointer--;

            	        	stream_option.Add(option21.Tree);
            	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:28: ( ',' option )*
            	        	do 
            	        	{
            	        	    int alt4 = 2;
            	        	    int LA4_0 = input.LA(1);

            	        	    if ( (LA4_0 == KOMMA) )
            	        	    {
            	        	        int LA4_1 = input.LA(2);

            	        	        if ( (LA4_1 == ID || (LA4_1 >= 61 && LA4_1 <= 64)) )
            	        	        {
            	        	            alt4 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt4) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:29: ',' option
            	        			    {
            	        			    	char_literal22=(IToken)Match(input,KOMMA,FOLLOW_KOMMA_in_tikz_options510);  
            	        			    	stream_KOMMA.Add(char_literal22);

            	        			    	PushFollow(FOLLOW_option_in_tikz_options512);
            	        			    	option23 = option();
            	        			    	state.followingStackPointer--;

            	        			    	stream_option.Add(option23.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop4;
            	        	    }
            	        	} while (true);

            	        	loop4:
            	        		;	// Stops C# compiler whining that label 'loop4' has no statements

            	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:42: ( ',' )?
            	        	int alt5 = 2;
            	        	int LA5_0 = input.LA(1);

            	        	if ( (LA5_0 == KOMMA) )
            	        	{
            	        	    alt5 = 1;
            	        	}
            	        	switch (alt5) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:42: ','
            	        	        {
            	        	        	char_literal24=(IToken)Match(input,KOMMA,FOLLOW_KOMMA_in_tikz_options516);  
            	        	        	stream_KOMMA.Add(char_literal24);


            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_squarebr_end_in_tikz_options521);
            	squarebr_end25 = squarebr_end();
            	state.followingStackPointer--;

            	stream_squarebr_end.Add(squarebr_end25.Tree);


            	// AST REWRITE
            	// elements:          squarebr_start, squarebr_end, option
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 117:63: -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:66: ^( IM_OPTIONS squarebr_start ( option )* squarebr_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTIONS, "IM_OPTIONS"), root_1);

            	    adaptor.AddChild(root_1, stream_squarebr_start.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:94: ( option )*
            	    while ( stream_option.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_option.NextTree());

            	    }
            	    stream_option.Reset();
            	    adaptor.AddChild(root_1, stream_squarebr_end.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
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
    // $ANTLR end "tikz_options"

    public class option_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "option"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:120:1: option : ( option_style | option_kv );
    public simpletikzParser.option_return option() // throws RecognitionException [1]
    {   
        simpletikzParser.option_return retval = new simpletikzParser.option_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.option_style_return option_style26 = default(simpletikzParser.option_style_return);

        simpletikzParser.option_kv_return option_kv27 = default(simpletikzParser.option_kv_return);



        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:2: ( option_style | option_kv )
            int alt7 = 2;
            alt7 = dfa7.Predict(input);
            switch (alt7) 
            {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:4: option_style
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_option_style_in_option546);
                    	option_style26 = option_style();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, option_style26.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:122:5: option_kv
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_option_kv_in_option555);
                    	option_kv27 = option_kv();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, option_kv27.Tree);

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
    // $ANTLR end "option"

    public class option_kv_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "option_kv"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:125:1: option_kv : idd ( '=' iddornumberunitorstring )? -> ^( IM_OPTION_KV idd ( iddornumberunitorstring )? ) ;
    public simpletikzParser.option_kv_return option_kv() // throws RecognitionException [1]
    {   
        simpletikzParser.option_kv_return retval = new simpletikzParser.option_kv_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal29 = null;
        simpletikzParser.idd_return idd28 = default(simpletikzParser.idd_return);

        simpletikzParser.iddornumberunitorstring_return iddornumberunitorstring30 = default(simpletikzParser.iddornumberunitorstring_return);


        object char_literal29_tree=null;
        RewriteRuleTokenStream stream_EQU = new RewriteRuleTokenStream(adaptor,"token EQU");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_iddornumberunitorstring = new RewriteRuleSubtreeStream(adaptor,"rule iddornumberunitorstring");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:126:2: ( idd ( '=' iddornumberunitorstring )? -> ^( IM_OPTION_KV idd ( iddornumberunitorstring )? ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:126:4: idd ( '=' iddornumberunitorstring )?
            {
            	PushFollow(FOLLOW_idd_in_option_kv569);
            	idd28 = idd();
            	state.followingStackPointer--;

            	stream_idd.Add(idd28.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:126:8: ( '=' iddornumberunitorstring )?
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( (LA8_0 == EQU) )
            	{
            	    alt8 = 1;
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:126:9: '=' iddornumberunitorstring
            	        {
            	        	char_literal29=(IToken)Match(input,EQU,FOLLOW_EQU_in_option_kv572);  
            	        	stream_EQU.Add(char_literal29);

            	        	PushFollow(FOLLOW_iddornumberunitorstring_in_option_kv574);
            	        	iddornumberunitorstring30 = iddornumberunitorstring();
            	        	state.followingStackPointer--;

            	        	stream_iddornumberunitorstring.Add(iddornumberunitorstring30.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          idd, iddornumberunitorstring
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 126:40: -> ^( IM_OPTION_KV idd ( iddornumberunitorstring )? )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:126:43: ^( IM_OPTION_KV idd ( iddornumberunitorstring )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTION_KV, "IM_OPTION_KV"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:126:62: ( iddornumberunitorstring )?
            	    if ( stream_iddornumberunitorstring.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_iddornumberunitorstring.NextTree());

            	    }
            	    stream_iddornumberunitorstring.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
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
    // $ANTLR end "option_kv"

    public class nodetype_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "nodetype"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:1: nodetype : LBR ( no_rlbracket )* ( nodetype ( no_rlbracket )* )* RBR -> ^( IM_STRING LBR RBR ) ;
    public simpletikzParser.nodetype_return nodetype() // throws RecognitionException [1]
    {   
        simpletikzParser.nodetype_return retval = new simpletikzParser.nodetype_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LBR31 = null;
        IToken RBR35 = null;
        simpletikzParser.no_rlbracket_return no_rlbracket32 = default(simpletikzParser.no_rlbracket_return);

        simpletikzParser.nodetype_return nodetype33 = default(simpletikzParser.nodetype_return);

        simpletikzParser.no_rlbracket_return no_rlbracket34 = default(simpletikzParser.no_rlbracket_return);


        object LBR31_tree=null;
        object RBR35_tree=null;
        RewriteRuleTokenStream stream_RBR = new RewriteRuleTokenStream(adaptor,"token RBR");
        RewriteRuleTokenStream stream_LBR = new RewriteRuleTokenStream(adaptor,"token LBR");
        RewriteRuleSubtreeStream stream_nodetype = new RewriteRuleSubtreeStream(adaptor,"rule nodetype");
        RewriteRuleSubtreeStream stream_no_rlbracket = new RewriteRuleSubtreeStream(adaptor,"rule no_rlbracket");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:130:2: ( LBR ( no_rlbracket )* ( nodetype ( no_rlbracket )* )* RBR -> ^( IM_STRING LBR RBR ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:130:4: LBR ( no_rlbracket )* ( nodetype ( no_rlbracket )* )* RBR
            {
            	LBR31=(IToken)Match(input,LBR,FOLLOW_LBR_in_nodetype602);  
            	stream_LBR.Add(LBR31);

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:130:8: ( no_rlbracket )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( ((LA9_0 >= BEGIN && LA9_0 <= RPAR) || (LA9_0 >= LBRR && LA9_0 <= 68)) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:130:8: no_rlbracket
            			    {
            			    	PushFollow(FOLLOW_no_rlbracket_in_nodetype604);
            			    	no_rlbracket32 = no_rlbracket();
            			    	state.followingStackPointer--;

            			    	stream_no_rlbracket.Add(no_rlbracket32.Tree);

            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:130:22: ( nodetype ( no_rlbracket )* )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( (LA11_0 == LBR) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:130:23: nodetype ( no_rlbracket )*
            			    {
            			    	PushFollow(FOLLOW_nodetype_in_nodetype608);
            			    	nodetype33 = nodetype();
            			    	state.followingStackPointer--;

            			    	stream_nodetype.Add(nodetype33.Tree);
            			    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:130:32: ( no_rlbracket )*
            			    	do 
            			    	{
            			    	    int alt10 = 2;
            			    	    int LA10_0 = input.LA(1);

            			    	    if ( ((LA10_0 >= BEGIN && LA10_0 <= RPAR) || (LA10_0 >= LBRR && LA10_0 <= 68)) )
            			    	    {
            			    	        alt10 = 1;
            			    	    }


            			    	    switch (alt10) 
            			    		{
            			    			case 1 :
            			    			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:130:32: no_rlbracket
            			    			    {
            			    			    	PushFollow(FOLLOW_no_rlbracket_in_nodetype610);
            			    			    	no_rlbracket34 = no_rlbracket();
            			    			    	state.followingStackPointer--;

            			    			    	stream_no_rlbracket.Add(no_rlbracket34.Tree);

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop10;
            			    	    }
            			    	} while (true);

            			    	loop10:
            			    		;	// Stops C# compiler whining that label 'loop10' has no statements


            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements

            	RBR35=(IToken)Match(input,RBR,FOLLOW_RBR_in_nodetype615);  
            	stream_RBR.Add(RBR35);



            	// AST REWRITE
            	// elements:          LBR, RBR
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 130:52: -> ^( IM_STRING LBR RBR )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:130:55: ^( IM_STRING LBR RBR )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STRING, "IM_STRING"), root_1);

            	    adaptor.AddChild(root_1, stream_LBR.NextNode());
            	    adaptor.AddChild(root_1, stream_RBR.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
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
    // $ANTLR end "nodetype"

    public class no_rlbracket_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "no_rlbracket"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:133:1: no_rlbracket : ~ ( LBR | RBR ) ;
    public simpletikzParser.no_rlbracket_return no_rlbracket() // throws RecognitionException [1]
    {   
        simpletikzParser.no_rlbracket_return retval = new simpletikzParser.no_rlbracket_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set36 = null;

        object set36_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:134:2: (~ ( LBR | RBR ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:134:4: ~ ( LBR | RBR )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set36 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= BEGIN && input.LA(1) <= RPAR) || (input.LA(1) >= LBRR && input.LA(1) <= 68) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set36));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


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
    // $ANTLR end "no_rlbracket"

    public class tikzstring_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikzstring"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:136:1: tikzstring : LBRR ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* RBRR -> ^( IM_STRING LBRR RBRR ) ;
    public simpletikzParser.tikzstring_return tikzstring() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzstring_return retval = new simpletikzParser.tikzstring_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LBRR37 = null;
        IToken RBRR41 = null;
        simpletikzParser.no_rlbrace_return no_rlbrace38 = default(simpletikzParser.no_rlbrace_return);

        simpletikzParser.tikzstring_return tikzstring39 = default(simpletikzParser.tikzstring_return);

        simpletikzParser.no_rlbrace_return no_rlbrace40 = default(simpletikzParser.no_rlbrace_return);


        object LBRR37_tree=null;
        object RBRR41_tree=null;
        RewriteRuleTokenStream stream_RBRR = new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleSubtreeStream stream_tikzstring = new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_no_rlbrace = new RewriteRuleSubtreeStream(adaptor,"rule no_rlbrace");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:2: ( LBRR ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* RBRR -> ^( IM_STRING LBRR RBRR ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:4: LBRR ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* RBRR
            {
            	LBRR37=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_tikzstring655);  
            	stream_LBRR.Add(LBRR37);

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:9: ( no_rlbrace )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( ((LA12_0 >= BEGIN && LA12_0 <= RBR) || (LA12_0 >= KOMMA && LA12_0 <= 68)) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:9: no_rlbrace
            			    {
            			    	PushFollow(FOLLOW_no_rlbrace_in_tikzstring657);
            			    	no_rlbrace38 = no_rlbrace();
            			    	state.followingStackPointer--;

            			    	stream_no_rlbrace.Add(no_rlbrace38.Tree);

            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:21: ( tikzstring ( no_rlbrace )* )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( (LA14_0 == LBRR) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:22: tikzstring ( no_rlbrace )*
            			    {
            			    	PushFollow(FOLLOW_tikzstring_in_tikzstring661);
            			    	tikzstring39 = tikzstring();
            			    	state.followingStackPointer--;

            			    	stream_tikzstring.Add(tikzstring39.Tree);
            			    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:33: ( no_rlbrace )*
            			    	do 
            			    	{
            			    	    int alt13 = 2;
            			    	    int LA13_0 = input.LA(1);

            			    	    if ( ((LA13_0 >= BEGIN && LA13_0 <= RBR) || (LA13_0 >= KOMMA && LA13_0 <= 68)) )
            			    	    {
            			    	        alt13 = 1;
            			    	    }


            			    	    switch (alt13) 
            			    		{
            			    			case 1 :
            			    			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:33: no_rlbrace
            			    			    {
            			    			    	PushFollow(FOLLOW_no_rlbrace_in_tikzstring663);
            			    			    	no_rlbrace40 = no_rlbrace();
            			    			    	state.followingStackPointer--;

            			    			    	stream_no_rlbrace.Add(no_rlbrace40.Tree);

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop13;
            			    	    }
            			    	} while (true);

            			    	loop13:
            			    		;	// Stops C# compiler whining that label 'loop13' has no statements


            			    }
            			    break;

            			default:
            			    goto loop14;
            	    }
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whining that label 'loop14' has no statements

            	RBRR41=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_tikzstring668);  
            	stream_RBRR.Add(RBRR41);



            	// AST REWRITE
            	// elements:          LBRR, RBRR
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 137:52: -> ^( IM_STRING LBRR RBRR )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:55: ^( IM_STRING LBRR RBRR )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STRING, "IM_STRING"), root_1);

            	    adaptor.AddChild(root_1, stream_LBRR.NextNode());
            	    adaptor.AddChild(root_1, stream_RBRR.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
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
    // $ANTLR end "tikzstring"

    public class no_rlbrace_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "no_rlbrace"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:140:1: no_rlbrace : ~ ( LBRR | RBRR ) ;
    public simpletikzParser.no_rlbrace_return no_rlbrace() // throws RecognitionException [1]
    {   
        simpletikzParser.no_rlbrace_return retval = new simpletikzParser.no_rlbrace_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set42 = null;

        object set42_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:141:2: (~ ( LBRR | RBRR ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:141:4: ~ ( LBRR | RBRR )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set42 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= BEGIN && input.LA(1) <= RBR) || (input.LA(1) >= KOMMA && input.LA(1) <= 68) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set42));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


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
    // $ANTLR end "no_rlbrace"

    public class iddornumberunitorstring_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "iddornumberunitorstring"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:143:1: iddornumberunitorstring : ( idd | numberunit | tikzstring );
    public simpletikzParser.iddornumberunitorstring_return iddornumberunitorstring() // throws RecognitionException [1]
    {   
        simpletikzParser.iddornumberunitorstring_return retval = new simpletikzParser.iddornumberunitorstring_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.idd_return idd43 = default(simpletikzParser.idd_return);

        simpletikzParser.numberunit_return numberunit44 = default(simpletikzParser.numberunit_return);

        simpletikzParser.tikzstring_return tikzstring45 = default(simpletikzParser.tikzstring_return);



        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:144:2: ( idd | numberunit | tikzstring )
            int alt15 = 3;
            switch ( input.LA(1) ) 
            {
            case ID:
            case 61:
            case 62:
            case 63:
            case 64:
            	{
                alt15 = 1;
                }
                break;
            case INT:
            case FLOAT_WO_EXP:
            	{
                alt15 = 2;
                }
                break;
            case LBRR:
            	{
                alt15 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d15s0 =
            	        new NoViableAltException("", 15, 0, input);

            	    throw nvae_d15s0;
            }

            switch (alt15) 
            {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:144:4: idd
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_idd_in_iddornumberunitorstring708);
                    	idd43 = idd();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, idd43.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:144:10: numberunit
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_numberunit_in_iddornumberunitorstring712);
                    	numberunit44 = numberunit();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, numberunit44.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:144:23: tikzstring
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikzstring_in_iddornumberunitorstring716);
                    	tikzstring45 = tikzstring();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, tikzstring45.Tree);

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
    // $ANTLR end "iddornumberunitorstring"

    public class option_style_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "option_style"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:146:1: option_style : idd '/.style' '=' LBRR ( option_kv ( ',' option_kv )* )? ( ',' )? RBRR -> ^( IM_OPTION_STYLE idd ( option_kv )* ) ;
    public simpletikzParser.option_style_return option_style() // throws RecognitionException [1]
    {   
        simpletikzParser.option_style_return retval = new simpletikzParser.option_style_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal47 = null;
        IToken char_literal48 = null;
        IToken LBRR49 = null;
        IToken char_literal51 = null;
        IToken char_literal53 = null;
        IToken RBRR54 = null;
        simpletikzParser.idd_return idd46 = default(simpletikzParser.idd_return);

        simpletikzParser.option_kv_return option_kv50 = default(simpletikzParser.option_kv_return);

        simpletikzParser.option_kv_return option_kv52 = default(simpletikzParser.option_kv_return);


        object string_literal47_tree=null;
        object char_literal48_tree=null;
        object LBRR49_tree=null;
        object char_literal51_tree=null;
        object char_literal53_tree=null;
        object RBRR54_tree=null;
        RewriteRuleTokenStream stream_EQU = new RewriteRuleTokenStream(adaptor,"token EQU");
        RewriteRuleTokenStream stream_RBRR = new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_KOMMA = new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_option_kv = new RewriteRuleSubtreeStream(adaptor,"rule option_kv");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:2: ( idd '/.style' '=' LBRR ( option_kv ( ',' option_kv )* )? ( ',' )? RBRR -> ^( IM_OPTION_STYLE idd ( option_kv )* ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:4: idd '/.style' '=' LBRR ( option_kv ( ',' option_kv )* )? ( ',' )? RBRR
            {
            	PushFollow(FOLLOW_idd_in_option_style726);
            	idd46 = idd();
            	state.followingStackPointer--;

            	stream_idd.Add(idd46.Tree);
            	string_literal47=(IToken)Match(input,53,FOLLOW_53_in_option_style728);  
            	stream_53.Add(string_literal47);

            	char_literal48=(IToken)Match(input,EQU,FOLLOW_EQU_in_option_style730);  
            	stream_EQU.Add(char_literal48);

            	LBRR49=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_option_style732);  
            	stream_LBRR.Add(LBRR49);

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:27: ( option_kv ( ',' option_kv )* )?
            	int alt17 = 2;
            	int LA17_0 = input.LA(1);

            	if ( (LA17_0 == ID || (LA17_0 >= 61 && LA17_0 <= 64)) )
            	{
            	    alt17 = 1;
            	}
            	switch (alt17) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:28: option_kv ( ',' option_kv )*
            	        {
            	        	PushFollow(FOLLOW_option_kv_in_option_style735);
            	        	option_kv50 = option_kv();
            	        	state.followingStackPointer--;

            	        	stream_option_kv.Add(option_kv50.Tree);
            	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:38: ( ',' option_kv )*
            	        	do 
            	        	{
            	        	    int alt16 = 2;
            	        	    int LA16_0 = input.LA(1);

            	        	    if ( (LA16_0 == KOMMA) )
            	        	    {
            	        	        int LA16_1 = input.LA(2);

            	        	        if ( (LA16_1 == ID || (LA16_1 >= 61 && LA16_1 <= 64)) )
            	        	        {
            	        	            alt16 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt16) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:39: ',' option_kv
            	        			    {
            	        			    	char_literal51=(IToken)Match(input,KOMMA,FOLLOW_KOMMA_in_option_style738);  
            	        			    	stream_KOMMA.Add(char_literal51);

            	        			    	PushFollow(FOLLOW_option_kv_in_option_style740);
            	        			    	option_kv52 = option_kv();
            	        			    	state.followingStackPointer--;

            	        			    	stream_option_kv.Add(option_kv52.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop16;
            	        	    }
            	        	} while (true);

            	        	loop16:
            	        		;	// Stops C# compiler whining that label 'loop16' has no statements


            	        }
            	        break;

            	}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:58: ( ',' )?
            	int alt18 = 2;
            	int LA18_0 = input.LA(1);

            	if ( (LA18_0 == KOMMA) )
            	{
            	    alt18 = 1;
            	}
            	switch (alt18) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:58: ','
            	        {
            	        	char_literal53=(IToken)Match(input,KOMMA,FOLLOW_KOMMA_in_option_style747);  
            	        	stream_KOMMA.Add(char_literal53);


            	        }
            	        break;

            	}

            	RBRR54=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_option_style750);  
            	stream_RBRR.Add(RBRR54);



            	// AST REWRITE
            	// elements:          option_kv, idd
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 147:69: -> ^( IM_OPTION_STYLE idd ( option_kv )* )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:72: ^( IM_OPTION_STYLE idd ( option_kv )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTION_STYLE, "IM_OPTION_STYLE"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:94: ( option_kv )*
            	    while ( stream_option_kv.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_option_kv.NextTree());

            	    }
            	    stream_option_kv.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
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
    // $ANTLR end "option_style"

    public class idd_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "idd"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:155:1: idd : ( edgeop ( edgeop )* -> ^( IM_ID ( edgeop )* ) | edgeop INT -> ^( IM_ID edgeop INT ) );
    public simpletikzParser.idd_return idd() // throws RecognitionException [1]
    {   
        simpletikzParser.idd_return retval = new simpletikzParser.idd_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INT58 = null;
        simpletikzParser.edgeop_return edgeop55 = default(simpletikzParser.edgeop_return);

        simpletikzParser.edgeop_return edgeop56 = default(simpletikzParser.edgeop_return);

        simpletikzParser.edgeop_return edgeop57 = default(simpletikzParser.edgeop_return);


        object INT58_tree=null;
        RewriteRuleTokenStream stream_INT = new RewriteRuleTokenStream(adaptor,"token INT");
        RewriteRuleSubtreeStream stream_edgeop = new RewriteRuleSubtreeStream(adaptor,"rule edgeop");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:2: ( edgeop ( edgeop )* -> ^( IM_ID ( edgeop )* ) | edgeop INT -> ^( IM_ID edgeop INT ) )
            int alt20 = 2;
            int LA20_0 = input.LA(1);

            if ( (LA20_0 == ID || (LA20_0 >= 61 && LA20_0 <= 64)) )
            {
                int LA20_1 = input.LA(2);

                if ( (LA20_1 == RBR || (LA20_1 >= RBRR && LA20_1 <= EQU) || LA20_1 == ID || LA20_1 == 53 || (LA20_1 >= 61 && LA20_1 <= 64)) )
                {
                    alt20 = 1;
                }
                else if ( (LA20_1 == INT) )
                {
                    alt20 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d20s1 =
                        new NoViableAltException("", 20, 1, input);

                    throw nvae_d20s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d20s0 =
                    new NoViableAltException("", 20, 0, input);

                throw nvae_d20s0;
            }
            switch (alt20) 
            {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:4: edgeop ( edgeop )*
                    {
                    	PushFollow(FOLLOW_edgeop_in_idd781);
                    	edgeop55 = edgeop();
                    	state.followingStackPointer--;

                    	stream_edgeop.Add(edgeop55.Tree);
                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:11: ( edgeop )*
                    	do 
                    	{
                    	    int alt19 = 2;
                    	    int LA19_0 = input.LA(1);

                    	    if ( (LA19_0 == ID || (LA19_0 >= 61 && LA19_0 <= 64)) )
                    	    {
                    	        alt19 = 1;
                    	    }


                    	    switch (alt19) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:12: edgeop
                    			    {
                    			    	PushFollow(FOLLOW_edgeop_in_idd784);
                    			    	edgeop56 = edgeop();
                    			    	state.followingStackPointer--;

                    			    	stream_edgeop.Add(edgeop56.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop19;
                    	    }
                    	} while (true);

                    	loop19:
                    		;	// Stops C# compiler whining that label 'loop19' has no statements



                    	// AST REWRITE
                    	// elements:          edgeop
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 156:21: -> ^( IM_ID ( edgeop )* )
                    	{
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:24: ^( IM_ID ( edgeop )* )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ID, "IM_ID"), root_1);

                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:32: ( edgeop )*
                    	    while ( stream_edgeop.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_edgeop.NextTree());

                    	    }
                    	    stream_edgeop.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:157:4: edgeop INT
                    {
                    	PushFollow(FOLLOW_edgeop_in_idd800);
                    	edgeop57 = edgeop();
                    	state.followingStackPointer--;

                    	stream_edgeop.Add(edgeop57.Tree);
                    	INT58=(IToken)Match(input,INT,FOLLOW_INT_in_idd802);  
                    	stream_INT.Add(INT58);



                    	// AST REWRITE
                    	// elements:          INT, edgeop
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 157:16: -> ^( IM_ID edgeop INT )
                    	{
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:157:19: ^( IM_ID edgeop INT )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ID, "IM_ID"), root_1);

                    	    adaptor.AddChild(root_1, stream_edgeop.NextTree());
                    	    adaptor.AddChild(root_1, stream_INT.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
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
    // $ANTLR end "idd"

    public class numberunit_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "numberunit"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:163:1: numberunit : number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) ;
    public simpletikzParser.numberunit_return numberunit() // throws RecognitionException [1]
    {   
        simpletikzParser.numberunit_return retval = new simpletikzParser.numberunit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.number_return number59 = default(simpletikzParser.number_return);

        simpletikzParser.unit_return unit60 = default(simpletikzParser.unit_return);


        RewriteRuleSubtreeStream stream_unit = new RewriteRuleSubtreeStream(adaptor,"rule unit");
        RewriteRuleSubtreeStream stream_number = new RewriteRuleSubtreeStream(adaptor,"rule number");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:164:2: ( number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:164:4: number ( unit )?
            {
            	PushFollow(FOLLOW_number_in_numberunit831);
            	number59 = number();
            	state.followingStackPointer--;

            	stream_number.Add(number59.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:164:11: ( unit )?
            	int alt21 = 2;
            	int LA21_0 = input.LA(1);

            	if ( ((LA21_0 >= 54 && LA21_0 <= 59)) )
            	{
            	    alt21 = 1;
            	}
            	switch (alt21) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:164:11: unit
            	        {
            	        	PushFollow(FOLLOW_unit_in_numberunit833);
            	        	unit60 = unit();
            	        	state.followingStackPointer--;

            	        	stream_unit.Add(unit60.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          unit, number
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 164:17: -> ^( IM_NUMBERUNIT number ( unit )? )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:164:20: ^( IM_NUMBERUNIT number ( unit )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NUMBERUNIT, "IM_NUMBERUNIT"), root_1);

            	    adaptor.AddChild(root_1, stream_number.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:164:43: ( unit )?
            	    if ( stream_unit.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_unit.NextTree());

            	    }
            	    stream_unit.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
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
    // $ANTLR end "numberunit"

    public class number_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "number"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:168:1: number : ( FLOAT_WO_EXP | INT ) ;
    public simpletikzParser.number_return number() // throws RecognitionException [1]
    {   
        simpletikzParser.number_return retval = new simpletikzParser.number_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set61 = null;

        object set61_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:169:2: ( ( FLOAT_WO_EXP | INT ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:169:4: ( FLOAT_WO_EXP | INT )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set61 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= INT && input.LA(1) <= FLOAT_WO_EXP) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set61));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


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
    // $ANTLR end "number"

    public class unit_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "unit"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:172:1: unit : ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' | 'em' );
    public simpletikzParser.unit_return unit() // throws RecognitionException [1]
    {   
        simpletikzParser.unit_return retval = new simpletikzParser.unit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set62 = null;

        object set62_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:2: ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' | 'em' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set62 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 54 && input.LA(1) <= 59) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set62));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


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
    // $ANTLR end "unit"

    public class tikz_set_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikz_set"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:176:1: tikz_set : tikz_set_start ( option ( ',' option )* )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) ;
    public simpletikzParser.tikz_set_return tikz_set() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_set_return retval = new simpletikzParser.tikz_set_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal65 = null;
        simpletikzParser.tikz_set_start_return tikz_set_start63 = default(simpletikzParser.tikz_set_start_return);

        simpletikzParser.option_return option64 = default(simpletikzParser.option_return);

        simpletikzParser.option_return option66 = default(simpletikzParser.option_return);

        simpletikzParser.roundbr_end_return roundbr_end67 = default(simpletikzParser.roundbr_end_return);


        object char_literal65_tree=null;
        RewriteRuleTokenStream stream_KOMMA = new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_tikz_set_start = new RewriteRuleSubtreeStream(adaptor,"rule tikz_set_start");
        RewriteRuleSubtreeStream stream_roundbr_end = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        RewriteRuleSubtreeStream stream_option = new RewriteRuleSubtreeStream(adaptor,"rule option");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:177:2: ( tikz_set_start ( option ( ',' option )* )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:177:5: tikz_set_start ( option ( ',' option )* )? roundbr_end
            {
            	PushFollow(FOLLOW_tikz_set_start_in_tikz_set914);
            	tikz_set_start63 = tikz_set_start();
            	state.followingStackPointer--;

            	stream_tikz_set_start.Add(tikz_set_start63.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:177:20: ( option ( ',' option )* )?
            	int alt23 = 2;
            	int LA23_0 = input.LA(1);

            	if ( (LA23_0 == ID || (LA23_0 >= 61 && LA23_0 <= 64)) )
            	{
            	    alt23 = 1;
            	}
            	switch (alt23) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:177:21: option ( ',' option )*
            	        {
            	        	PushFollow(FOLLOW_option_in_tikz_set917);
            	        	option64 = option();
            	        	state.followingStackPointer--;

            	        	stream_option.Add(option64.Tree);
            	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:177:28: ( ',' option )*
            	        	do 
            	        	{
            	        	    int alt22 = 2;
            	        	    int LA22_0 = input.LA(1);

            	        	    if ( (LA22_0 == KOMMA) )
            	        	    {
            	        	        alt22 = 1;
            	        	    }


            	        	    switch (alt22) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:177:29: ',' option
            	        			    {
            	        			    	char_literal65=(IToken)Match(input,KOMMA,FOLLOW_KOMMA_in_tikz_set920);  
            	        			    	stream_KOMMA.Add(char_literal65);

            	        			    	PushFollow(FOLLOW_option_in_tikz_set922);
            	        			    	option66 = option();
            	        			    	state.followingStackPointer--;

            	        			    	stream_option.Add(option66.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop22;
            	        	    }
            	        	} while (true);

            	        	loop22:
            	        		;	// Stops C# compiler whining that label 'loop22' has no statements


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_roundbr_end_in_tikz_set928);
            	roundbr_end67 = roundbr_end();
            	state.followingStackPointer--;

            	stream_roundbr_end.Add(roundbr_end67.Tree);


            	// AST REWRITE
            	// elements:          roundbr_end, option, tikz_set_start
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 177:56: -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:177:59: ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_TIKZSET, "IM_TIKZSET"), root_1);

            	    adaptor.AddChild(root_1, stream_tikz_set_start.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:177:87: ( option )*
            	    while ( stream_option.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_option.NextTree());

            	    }
            	    stream_option.Reset();
            	    adaptor.AddChild(root_1, stream_roundbr_end.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
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
    // $ANTLR end "tikz_set"

    public class tikzpicture_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikzpicture"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:1: tikzpicture : tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) ;
    public simpletikzParser.tikzpicture_return tikzpicture() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_return retval = new simpletikzParser.tikzpicture_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzpicture_start_return tikzpicture_start68 = default(simpletikzParser.tikzpicture_start_return);

        simpletikzParser.tikz_options_return tikz_options69 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody_return tikzbody70 = default(simpletikzParser.tikzbody_return);

        simpletikzParser.tikzpicture_end_return tikzpicture_end71 = default(simpletikzParser.tikzpicture_end_return);


        RewriteRuleSubtreeStream stream_tikzpicture_end = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_end");
        RewriteRuleSubtreeStream stream_tikzpicture_start = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_start");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:2: ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:5: tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end
            {
            	PushFollow(FOLLOW_tikzpicture_start_in_tikzpicture956);
            	tikzpicture_start68 = tikzpicture_start();
            	state.followingStackPointer--;

            	stream_tikzpicture_start.Add(tikzpicture_start68.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:23: ( tikz_options )?
            	int alt24 = 2;
            	int LA24_0 = input.LA(1);

            	if ( (LA24_0 == LBR) )
            	{
            	    alt24 = 1;
            	}
            	switch (alt24) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:23: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_tikzpicture958);
            	        	tikz_options69 = tikz_options();
            	        	state.followingStackPointer--;

            	        	stream_tikz_options.Add(tikz_options69.Tree);

            	        }
            	        break;

            	}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:37: ( tikzbody )?
            	int alt25 = 2;
            	int LA25_0 = input.LA(1);

            	if ( (LA25_0 == BEGIN || (LA25_0 >= USETIKZLIB && LA25_0 <= RPAR) || (LA25_0 >= RBR && LA25_0 <= 68)) )
            	{
            	    alt25 = 1;
            	}
            	else if ( (LA25_0 == END) )
            	{
            	    int LA25_2 = input.LA(2);

            	    if ( (LA25_2 == LBRR) )
            	    {
            	        int LA25_3 = input.LA(3);

            	        if ( (LA25_3 == ID || (LA25_3 >= 61 && LA25_3 <= 64)) )
            	        {
            	            alt25 = 1;
            	        }
            	    }
            	}
            	switch (alt25) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:37: tikzbody
            	        {
            	        	PushFollow(FOLLOW_tikzbody_in_tikzpicture961);
            	        	tikzbody70 = tikzbody();
            	        	state.followingStackPointer--;

            	        	stream_tikzbody.Add(tikzbody70.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzpicture_end_in_tikzpicture964);
            	tikzpicture_end71 = tikzpicture_end();
            	state.followingStackPointer--;

            	stream_tikzpicture_end.Add(tikzpicture_end71.Tree);


            	// AST REWRITE
            	// elements:          tikzpicture_start, tikzpicture_end, tikz_options, tikzbody
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 183:64: -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:67: ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PICTURE, "IM_PICTURE"), root_1);

            	    adaptor.AddChild(root_1, stream_tikzpicture_start.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:98: ( tikz_options )?
            	    if ( stream_tikz_options.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikz_options.NextTree());

            	    }
            	    stream_tikz_options.Reset();
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:112: ( tikzbody )?
            	    if ( stream_tikzbody.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzbody.NextTree());

            	    }
            	    stream_tikzbody.Reset();
            	    adaptor.AddChild(root_1, stream_tikzpicture_end.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
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
    // $ANTLR end "tikzpicture"

    public class tikzbody_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikzbody"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:186:1: tikzbody : ( tikzscope | tikzpath | tikznodee | dontcare_body_nobr | tikz_set | tikz_style | otherbegin | otherend ) ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )* ;
    public simpletikzParser.tikzbody_return tikzbody() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzbody_return retval = new simpletikzParser.tikzbody_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_return tikzscope72 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath73 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznodee_return tikznodee74 = default(simpletikzParser.tikznodee_return);

        simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr75 = default(simpletikzParser.dontcare_body_nobr_return);

        simpletikzParser.tikz_set_return tikz_set76 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style77 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin78 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend79 = default(simpletikzParser.otherend_return);

        simpletikzParser.tikzscope_return tikzscope80 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath81 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznodee_return tikznodee82 = default(simpletikzParser.tikznodee_return);

        simpletikzParser.dontcare_body_return dontcare_body83 = default(simpletikzParser.dontcare_body_return);

        simpletikzParser.tikz_set_return tikz_set84 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style85 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin86 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend87 = default(simpletikzParser.otherend_return);



        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:187:2: ( ( tikzscope | tikzpath | tikznodee | dontcare_body_nobr | tikz_set | tikz_style | otherbegin | otherend ) ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )* )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:187:4: ( tikzscope | tikzpath | tikznodee | dontcare_body_nobr | tikz_set | tikz_style | otherbegin | otherend ) ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:187:4: ( tikzscope | tikzpath | tikznodee | dontcare_body_nobr | tikz_set | tikz_style | otherbegin | otherend )
            	int alt26 = 8;
            	alt26 = dfa26.Predict(input);
            	switch (alt26) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:187:6: tikzscope
            	        {
            	        	PushFollow(FOLLOW_tikzscope_in_tikzbody994);
            	        	tikzscope72 = tikzscope();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, tikzscope72.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:187:18: tikzpath
            	        {
            	        	PushFollow(FOLLOW_tikzpath_in_tikzbody998);
            	        	tikzpath73 = tikzpath();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, tikzpath73.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:187:29: tikznodee
            	        {
            	        	PushFollow(FOLLOW_tikznodee_in_tikzbody1002);
            	        	tikznodee74 = tikznodee();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, tikznodee74.Tree);

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:187:41: dontcare_body_nobr
            	        {
            	        	PushFollow(FOLLOW_dontcare_body_nobr_in_tikzbody1006);
            	        	dontcare_body_nobr75 = dontcare_body_nobr();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, dontcare_body_nobr75.Tree);

            	        }
            	        break;
            	    case 5 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:187:62: tikz_set
            	        {
            	        	PushFollow(FOLLOW_tikz_set_in_tikzbody1010);
            	        	tikz_set76 = tikz_set();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, tikz_set76.Tree);

            	        }
            	        break;
            	    case 6 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:187:73: tikz_style
            	        {
            	        	PushFollow(FOLLOW_tikz_style_in_tikzbody1014);
            	        	tikz_style77 = tikz_style();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, tikz_style77.Tree);

            	        }
            	        break;
            	    case 7 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:187:86: otherbegin
            	        {
            	        	PushFollow(FOLLOW_otherbegin_in_tikzbody1018);
            	        	otherbegin78 = otherbegin();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, otherbegin78.Tree);

            	        }
            	        break;
            	    case 8 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:187:98: otherend
            	        {
            	        	PushFollow(FOLLOW_otherend_in_tikzbody1021);
            	        	otherend79 = otherend();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, otherend79.Tree);

            	        }
            	        break;

            	}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:188:3: ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )*
            	do 
            	{
            	    int alt27 = 9;
            	    alt27 = dfa27.Predict(input);
            	    switch (alt27) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:188:5: tikzscope
            			    {
            			    	PushFollow(FOLLOW_tikzscope_in_tikzbody1031);
            			    	tikzscope80 = tikzscope();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, tikzscope80.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:188:17: tikzpath
            			    {
            			    	PushFollow(FOLLOW_tikzpath_in_tikzbody1035);
            			    	tikzpath81 = tikzpath();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, tikzpath81.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:188:28: tikznodee
            			    {
            			    	PushFollow(FOLLOW_tikznodee_in_tikzbody1039);
            			    	tikznodee82 = tikznodee();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, tikznodee82.Tree);

            			    }
            			    break;
            			case 4 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:188:40: dontcare_body
            			    {
            			    	PushFollow(FOLLOW_dontcare_body_in_tikzbody1043);
            			    	dontcare_body83 = dontcare_body();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, dontcare_body83.Tree);

            			    }
            			    break;
            			case 5 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:188:61: tikz_set
            			    {
            			    	PushFollow(FOLLOW_tikz_set_in_tikzbody1052);
            			    	tikz_set84 = tikz_set();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, tikz_set84.Tree);

            			    }
            			    break;
            			case 6 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:188:72: tikz_style
            			    {
            			    	PushFollow(FOLLOW_tikz_style_in_tikzbody1056);
            			    	tikz_style85 = tikz_style();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, tikz_style85.Tree);

            			    }
            			    break;
            			case 7 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:188:85: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzbody1060);
            			    	otherbegin86 = otherbegin();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, otherbegin86.Tree);

            			    }
            			    break;
            			case 8 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:188:97: otherend
            			    {
            			    	PushFollow(FOLLOW_otherend_in_tikzbody1063);
            			    	otherend87 = otherend();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, otherend87.Tree);

            			    }
            			    break;

            			default:
            			    goto loop27;
            	    }
            	} while (true);

            	loop27:
            		;	// Stops C# compiler whining that label 'loop27' has no statements


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
    // $ANTLR end "tikzbody"

    public class dontcare_body_nobr_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "dontcare_body_nobr"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:191:1: dontcare_body_nobr : (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET | LBR ) ) ;
    public simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body_nobr_return retval = new simpletikzParser.dontcare_body_nobr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set88 = null;

        object set88_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:192:2: ( (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET | LBR ) ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:192:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET | LBR ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:192:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET | LBR ) )
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:192:5: ~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET | LBR )
            	{
            		set88 = (IToken)input.LT(1);
            		if ( input.LA(1) == USETIKZLIB || (input.LA(1) >= LPAR && input.LA(1) <= RPAR) || (input.LA(1) >= RBR && input.LA(1) <= 68) ) 
            		{
            		    input.Consume();
            		    adaptor.AddChild(root_0, (object)adaptor.Create(set88));
            		    state.errorRecovery = false;
            		}
            		else 
            		{
            		    MismatchedSetException mse = new MismatchedSetException(null,input);
            		    throw mse;
            		}


            	}


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
    // $ANTLR end "dontcare_body_nobr"

    public class dontcare_body_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "dontcare_body"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:194:1: dontcare_body : (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET ) ) ;
    public simpletikzParser.dontcare_body_return dontcare_body() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body_return retval = new simpletikzParser.dontcare_body_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set89 = null;

        object set89_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:2: ( (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET ) ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET ) )
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:5: ~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET )
            	{
            		set89 = (IToken)input.LT(1);
            		if ( input.LA(1) == USETIKZLIB || (input.LA(1) >= LPAR && input.LA(1) <= 68) ) 
            		{
            		    input.Consume();
            		    adaptor.AddChild(root_0, (object)adaptor.Create(set89));
            		    state.errorRecovery = false;
            		}
            		else 
            		{
            		    MismatchedSetException mse = new MismatchedSetException(null,input);
            		    throw mse;
            		}


            	}


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
    // $ANTLR end "dontcare_body"

    public class otherend_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "otherend"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:197:1: otherend : END '{' idd '}' ;
    public simpletikzParser.otherend_return otherend() // throws RecognitionException [1]
    {   
        simpletikzParser.otherend_return retval = new simpletikzParser.otherend_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken END90 = null;
        IToken char_literal91 = null;
        IToken char_literal93 = null;
        simpletikzParser.idd_return idd92 = default(simpletikzParser.idd_return);


        object END90_tree=null;
        object char_literal91_tree=null;
        object char_literal93_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:198:2: ( END '{' idd '}' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:198:4: END '{' idd '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	END90=(IToken)Match(input,END,FOLLOW_END_in_otherend1173); 
            		END90_tree = (object)adaptor.Create(END90);
            		adaptor.AddChild(root_0, END90_tree);

            	char_literal91=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_otherend1175); 
            		char_literal91_tree = (object)adaptor.Create(char_literal91);
            		adaptor.AddChild(root_0, char_literal91_tree);

            	PushFollow(FOLLOW_idd_in_otherend1177);
            	idd92 = idd();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, idd92.Tree);
            	char_literal93=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_otherend1179); 
            		char_literal93_tree = (object)adaptor.Create(char_literal93);
            		adaptor.AddChild(root_0, char_literal93_tree);


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
    // $ANTLR end "otherend"

    public class tikzpath_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikzpath"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:201:1: tikzpath : path_start ( tikz_options )? tikzpathi semicolon_end -> ^( IM_PATH path_start ( tikz_options )? tikzpathi semicolon_end ) ;
    public simpletikzParser.tikzpath_return tikzpath() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_return retval = new simpletikzParser.tikzpath_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.path_start_return path_start94 = default(simpletikzParser.path_start_return);

        simpletikzParser.tikz_options_return tikz_options95 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzpathi_return tikzpathi96 = default(simpletikzParser.tikzpathi_return);

        simpletikzParser.semicolon_end_return semicolon_end97 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_path_start = new RewriteRuleSubtreeStream(adaptor,"rule path_start");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        RewriteRuleSubtreeStream stream_tikzpathi = new RewriteRuleSubtreeStream(adaptor,"rule tikzpathi");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:202:2: ( path_start ( tikz_options )? tikzpathi semicolon_end -> ^( IM_PATH path_start ( tikz_options )? tikzpathi semicolon_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:202:4: path_start ( tikz_options )? tikzpathi semicolon_end
            {
            	PushFollow(FOLLOW_path_start_in_tikzpath1192);
            	path_start94 = path_start();
            	state.followingStackPointer--;

            	stream_path_start.Add(path_start94.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:202:15: ( tikz_options )?
            	int alt28 = 2;
            	int LA28_0 = input.LA(1);

            	if ( (LA28_0 == LBR) )
            	{
            	    alt28 = 1;
            	}
            	switch (alt28) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:202:15: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_tikzpath1194);
            	        	tikz_options95 = tikz_options();
            	        	state.followingStackPointer--;

            	        	stream_tikz_options.Add(tikz_options95.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzpathi_in_tikzpath1197);
            	tikzpathi96 = tikzpathi();
            	state.followingStackPointer--;

            	stream_tikzpathi.Add(tikzpathi96.Tree);
            	PushFollow(FOLLOW_semicolon_end_in_tikzpath1199);
            	semicolon_end97 = semicolon_end();
            	state.followingStackPointer--;

            	stream_semicolon_end.Add(semicolon_end97.Tree);


            	// AST REWRITE
            	// elements:          tikz_options, semicolon_end, tikzpathi, path_start
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 202:53: -> ^( IM_PATH path_start ( tikz_options )? tikzpathi semicolon_end )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:202:56: ^( IM_PATH path_start ( tikz_options )? tikzpathi semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_path_start.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:202:77: ( tikz_options )?
            	    if ( stream_tikz_options.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikz_options.NextTree());

            	    }
            	    stream_tikz_options.Reset();
            	    adaptor.AddChild(root_1, stream_tikzpathi.NextTree());
            	    adaptor.AddChild(root_1, stream_semicolon_end.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
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
    // $ANTLR end "tikzpath"

    public class tikzpathi_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikzpathi"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:207:1: tikzpathi : coordornode_new ( edgeop coordornode_new )* ;
    public simpletikzParser.tikzpathi_return tikzpathi() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpathi_return retval = new simpletikzParser.tikzpathi_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.coordornode_new_return coordornode_new98 = default(simpletikzParser.coordornode_new_return);

        simpletikzParser.edgeop_return edgeop99 = default(simpletikzParser.edgeop_return);

        simpletikzParser.coordornode_new_return coordornode_new100 = default(simpletikzParser.coordornode_new_return);



        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:208:2: ( coordornode_new ( edgeop coordornode_new )* )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:208:4: coordornode_new ( edgeop coordornode_new )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_coordornode_new_in_tikzpathi1230);
            	coordornode_new98 = coordornode_new();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, coordornode_new98.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:208:20: ( edgeop coordornode_new )*
            	do 
            	{
            	    int alt29 = 2;
            	    int LA29_0 = input.LA(1);

            	    if ( (LA29_0 == ID || (LA29_0 >= 61 && LA29_0 <= 64)) )
            	    {
            	        alt29 = 1;
            	    }


            	    switch (alt29) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:208:21: edgeop coordornode_new
            			    {
            			    	PushFollow(FOLLOW_edgeop_in_tikzpathi1233);
            			    	edgeop99 = edgeop();
            			    	state.followingStackPointer--;

            			    	PushFollow(FOLLOW_coordornode_new_in_tikzpathi1236);
            			    	coordornode_new100 = coordornode_new();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, coordornode_new100.Tree);

            			    }
            			    break;

            			default:
            			    goto loop29;
            	    }
            	} while (true);

            	loop29:
            		;	// Stops C# compiler whining that label 'loop29' has no statements


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
    // $ANTLR end "tikzpathi"

    public class tikzscope_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikzscope"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:213:1: tikzscope : tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end ) ;
    public simpletikzParser.tikzscope_return tikzscope() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_return retval = new simpletikzParser.tikzscope_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_start_return tikzscope_start101 = default(simpletikzParser.tikzscope_start_return);

        simpletikzParser.tikz_options_return tikz_options102 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody_return tikzbody103 = default(simpletikzParser.tikzbody_return);

        simpletikzParser.tikzscope_end_return tikzscope_end104 = default(simpletikzParser.tikzscope_end_return);


        RewriteRuleSubtreeStream stream_tikzscope_start = new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_start");
        RewriteRuleSubtreeStream stream_tikzscope_end = new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_end");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:214:2: ( tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:214:4: tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end
            {
            	PushFollow(FOLLOW_tikzscope_start_in_tikzscope1253);
            	tikzscope_start101 = tikzscope_start();
            	state.followingStackPointer--;

            	stream_tikzscope_start.Add(tikzscope_start101.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:214:20: ( tikz_options )?
            	int alt30 = 2;
            	int LA30_0 = input.LA(1);

            	if ( (LA30_0 == LBR) )
            	{
            	    alt30 = 1;
            	}
            	switch (alt30) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:214:20: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_tikzscope1255);
            	        	tikz_options102 = tikz_options();
            	        	state.followingStackPointer--;

            	        	stream_tikz_options.Add(tikz_options102.Tree);

            	        }
            	        break;

            	}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:214:34: ( tikzbody )?
            	int alt31 = 2;
            	int LA31_0 = input.LA(1);

            	if ( (LA31_0 == BEGIN || (LA31_0 >= USETIKZLIB && LA31_0 <= RPAR) || (LA31_0 >= RBR && LA31_0 <= 68)) )
            	{
            	    alt31 = 1;
            	}
            	else if ( (LA31_0 == END) )
            	{
            	    int LA31_2 = input.LA(2);

            	    if ( (LA31_2 == LBRR) )
            	    {
            	        int LA31_3 = input.LA(3);

            	        if ( (LA31_3 == ID || (LA31_3 >= 61 && LA31_3 <= 64)) )
            	        {
            	            alt31 = 1;
            	        }
            	    }
            	}
            	switch (alt31) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:214:34: tikzbody
            	        {
            	        	PushFollow(FOLLOW_tikzbody_in_tikzscope1258);
            	        	tikzbody103 = tikzbody();
            	        	state.followingStackPointer--;

            	        	stream_tikzbody.Add(tikzbody103.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzscope_end_in_tikzscope1261);
            	tikzscope_end104 = tikzscope_end();
            	state.followingStackPointer--;

            	stream_tikzscope_end.Add(tikzscope_end104.Tree);


            	// AST REWRITE
            	// elements:          tikzbody, tikz_options, tikzscope_end, tikzscope_start
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 214:59: -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:214:62: ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_SCOPE, "IM_SCOPE"), root_1);

            	    adaptor.AddChild(root_1, stream_tikzscope_start.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:214:89: ( tikz_options )?
            	    if ( stream_tikz_options.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikz_options.NextTree());

            	    }
            	    stream_tikz_options.Reset();
            	    adaptor.AddChild(root_1, stream_tikzbody.NextTree());
            	    adaptor.AddChild(root_1, stream_tikzscope_end.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
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
    // $ANTLR end "tikzscope"

    public class coordornode_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "coordornode"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:218:1: coordornode : ( coord | size | tikznodei );
    public simpletikzParser.coordornode_return coordornode() // throws RecognitionException [1]
    {   
        simpletikzParser.coordornode_return retval = new simpletikzParser.coordornode_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.coord_return coord105 = default(simpletikzParser.coord_return);

        simpletikzParser.size_return size106 = default(simpletikzParser.size_return);

        simpletikzParser.tikznodei_return tikznodei107 = default(simpletikzParser.tikznodei_return);



        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:219:2: ( coord | size | tikznodei )
            int alt32 = 3;
            switch ( input.LA(1) ) 
            {
            case LPAR:
            	{
                int LA32_1 = input.LA(2);

                if ( (LA32_1 == ID) )
                {
                    alt32 = 1;
                }
                else if ( ((LA32_1 >= INT && LA32_1 <= FLOAT_WO_EXP)) )
                {
                    switch ( input.LA(3) ) 
                    {
                    case 54:
                    case 55:
                    case 56:
                    case 57:
                    case 58:
                    case 59:
                    	{
                        int LA32_7 = input.LA(4);

                        if ( (LA32_7 == KOMMA || LA32_7 == COLON) )
                        {
                            alt32 = 1;
                        }
                        else if ( (LA32_7 == RPAR) )
                        {
                            alt32 = 2;
                        }
                        else 
                        {
                            NoViableAltException nvae_d32s7 =
                                new NoViableAltException("", 32, 7, input);

                            throw nvae_d32s7;
                        }
                        }
                        break;
                    case KOMMA:
                    case COLON:
                    	{
                        alt32 = 1;
                        }
                        break;
                    case RPAR:
                    	{
                        alt32 = 2;
                        }
                        break;
                    	default:
                    	    NoViableAltException nvae_d32s5 =
                    	        new NoViableAltException("", 32, 5, input);

                    	    throw nvae_d32s5;
                    }

                }
                else 
                {
                    NoViableAltException nvae_d32s1 =
                        new NoViableAltException("", 32, 1, input);

                    throw nvae_d32s1;
                }
                }
                break;
            case 65:
            case 66:
            	{
                int LA32_2 = input.LA(2);

                if ( (LA32_2 == LPAR) )
                {
                    int LA32_6 = input.LA(3);

                    if ( ((LA32_6 >= INT && LA32_6 <= FLOAT_WO_EXP)) )
                    {
                        switch ( input.LA(4) ) 
                        {
                        case 54:
                        case 55:
                        case 56:
                        case 57:
                        case 58:
                        case 59:
                        	{
                            int LA32_7 = input.LA(5);

                            if ( (LA32_7 == KOMMA || LA32_7 == COLON) )
                            {
                                alt32 = 1;
                            }
                            else if ( (LA32_7 == RPAR) )
                            {
                                alt32 = 2;
                            }
                            else 
                            {
                                NoViableAltException nvae_d32s7 =
                                    new NoViableAltException("", 32, 7, input);

                                throw nvae_d32s7;
                            }
                            }
                            break;
                        case KOMMA:
                        case COLON:
                        	{
                            alt32 = 1;
                            }
                            break;
                        case RPAR:
                        	{
                            alt32 = 2;
                            }
                            break;
                        	default:
                        	    NoViableAltException nvae_d32s5 =
                        	        new NoViableAltException("", 32, 5, input);

                        	    throw nvae_d32s5;
                        }

                    }
                    else 
                    {
                        NoViableAltException nvae_d32s6 =
                            new NoViableAltException("", 32, 6, input);

                        throw nvae_d32s6;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d32s2 =
                        new NoViableAltException("", 32, 2, input);

                    throw nvae_d32s2;
                }
                }
                break;
            case NODE:
            	{
                alt32 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d32s0 =
            	        new NoViableAltException("", 32, 0, input);

            	    throw nvae_d32s0;
            }

            switch (alt32) 
            {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:219:4: coord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_coord_in_coordornode1289);
                    	coord105 = coord();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, coord105.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:219:12: size
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_size_in_coordornode1293);
                    	size106 = size();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, size106.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:219:19: tikznodei
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikznodei_in_coordornode1297);
                    	tikznodei107 = tikznodei();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, tikznodei107.Tree);

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
    // $ANTLR end "coordornode"

    public class coordornode_new_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "coordornode_new"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:226:1: coordornode_new : ( coord ( ID ( nodetype )? ( tikzstring )? )? | size );
    public simpletikzParser.coordornode_new_return coordornode_new() // throws RecognitionException [1]
    {   
        simpletikzParser.coordornode_new_return retval = new simpletikzParser.coordornode_new_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID109 = null;
        simpletikzParser.coord_return coord108 = default(simpletikzParser.coord_return);

        simpletikzParser.nodetype_return nodetype110 = default(simpletikzParser.nodetype_return);

        simpletikzParser.tikzstring_return tikzstring111 = default(simpletikzParser.tikzstring_return);

        simpletikzParser.size_return size112 = default(simpletikzParser.size_return);


        object ID109_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:227:2: ( coord ( ID ( nodetype )? ( tikzstring )? )? | size )
            int alt36 = 2;
            int LA36_0 = input.LA(1);

            if ( (LA36_0 == LPAR) )
            {
                int LA36_1 = input.LA(2);

                if ( (LA36_1 == ID) )
                {
                    alt36 = 1;
                }
                else if ( ((LA36_1 >= INT && LA36_1 <= FLOAT_WO_EXP)) )
                {
                    switch ( input.LA(3) ) 
                    {
                    case 54:
                    case 55:
                    case 56:
                    case 57:
                    case 58:
                    case 59:
                    	{
                        int LA36_6 = input.LA(4);

                        if ( (LA36_6 == KOMMA || LA36_6 == COLON) )
                        {
                            alt36 = 1;
                        }
                        else if ( (LA36_6 == RPAR) )
                        {
                            alt36 = 2;
                        }
                        else 
                        {
                            NoViableAltException nvae_d36s6 =
                                new NoViableAltException("", 36, 6, input);

                            throw nvae_d36s6;
                        }
                        }
                        break;
                    case KOMMA:
                    case COLON:
                    	{
                        alt36 = 1;
                        }
                        break;
                    case RPAR:
                    	{
                        alt36 = 2;
                        }
                        break;
                    	default:
                    	    NoViableAltException nvae_d36s4 =
                    	        new NoViableAltException("", 36, 4, input);

                    	    throw nvae_d36s4;
                    }

                }
                else 
                {
                    NoViableAltException nvae_d36s1 =
                        new NoViableAltException("", 36, 1, input);

                    throw nvae_d36s1;
                }
            }
            else if ( ((LA36_0 >= 65 && LA36_0 <= 66)) )
            {
                int LA36_2 = input.LA(2);

                if ( (LA36_2 == LPAR) )
                {
                    int LA36_5 = input.LA(3);

                    if ( ((LA36_5 >= INT && LA36_5 <= FLOAT_WO_EXP)) )
                    {
                        switch ( input.LA(4) ) 
                        {
                        case 54:
                        case 55:
                        case 56:
                        case 57:
                        case 58:
                        case 59:
                        	{
                            int LA36_6 = input.LA(5);

                            if ( (LA36_6 == KOMMA || LA36_6 == COLON) )
                            {
                                alt36 = 1;
                            }
                            else if ( (LA36_6 == RPAR) )
                            {
                                alt36 = 2;
                            }
                            else 
                            {
                                NoViableAltException nvae_d36s6 =
                                    new NoViableAltException("", 36, 6, input);

                                throw nvae_d36s6;
                            }
                            }
                            break;
                        case KOMMA:
                        case COLON:
                        	{
                            alt36 = 1;
                            }
                            break;
                        case RPAR:
                        	{
                            alt36 = 2;
                            }
                            break;
                        	default:
                        	    NoViableAltException nvae_d36s4 =
                        	        new NoViableAltException("", 36, 4, input);

                        	    throw nvae_d36s4;
                        }

                    }
                    else 
                    {
                        NoViableAltException nvae_d36s5 =
                            new NoViableAltException("", 36, 5, input);

                        throw nvae_d36s5;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d36s2 =
                        new NoViableAltException("", 36, 2, input);

                    throw nvae_d36s2;
                }
            }
            else 
            {
                NoViableAltException nvae_d36s0 =
                    new NoViableAltException("", 36, 0, input);

                throw nvae_d36s0;
            }
            switch (alt36) 
            {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:227:4: coord ( ID ( nodetype )? ( tikzstring )? )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_coord_in_coordornode_new1314);
                    	coord108 = coord();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, coord108.Tree);
                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:227:10: ( ID ( nodetype )? ( tikzstring )? )?
                    	int alt35 = 2;
                    	int LA35_0 = input.LA(1);

                    	if ( (LA35_0 == ID) )
                    	{
                    	    int LA35_1 = input.LA(2);

                    	    if ( (LA35_1 == LBR || LA35_1 == LBRR || LA35_1 == SEMIC || LA35_1 == ID || (LA35_1 >= 61 && LA35_1 <= 64)) )
                    	    {
                    	        alt35 = 1;
                    	    }
                    	}
                    	switch (alt35) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:227:11: ID ( nodetype )? ( tikzstring )?
                    	        {
                    	        	ID109=(IToken)Match(input,ID,FOLLOW_ID_in_coordornode_new1317); 
                    	        		ID109_tree = (object)adaptor.Create(ID109);
                    	        		adaptor.AddChild(root_0, ID109_tree);

                    	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:227:14: ( nodetype )?
                    	        	int alt33 = 2;
                    	        	int LA33_0 = input.LA(1);

                    	        	if ( (LA33_0 == LBR) )
                    	        	{
                    	        	    alt33 = 1;
                    	        	}
                    	        	switch (alt33) 
                    	        	{
                    	        	    case 1 :
                    	        	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:227:15: nodetype
                    	        	        {
                    	        	        	PushFollow(FOLLOW_nodetype_in_coordornode_new1320);
                    	        	        	nodetype110 = nodetype();
                    	        	        	state.followingStackPointer--;

                    	        	        	adaptor.AddChild(root_0, nodetype110.Tree);

                    	        	        }
                    	        	        break;

                    	        	}

                    	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:227:26: ( tikzstring )?
                    	        	int alt34 = 2;
                    	        	int LA34_0 = input.LA(1);

                    	        	if ( (LA34_0 == LBRR) )
                    	        	{
                    	        	    alt34 = 1;
                    	        	}
                    	        	switch (alt34) 
                    	        	{
                    	        	    case 1 :
                    	        	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:227:27: tikzstring
                    	        	        {
                    	        	        	PushFollow(FOLLOW_tikzstring_in_coordornode_new1325);
                    	        	        	tikzstring111 = tikzstring();
                    	        	        	state.followingStackPointer--;

                    	        	        	adaptor.AddChild(root_0, tikzstring111.Tree);

                    	        	        }
                    	        	        break;

                    	        	}


                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:228:4: size
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_size_in_coordornode_new1334);
                    	size112 = size();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, size112.Tree);

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
    // $ANTLR end "coordornode_new"

    public class tikznodei_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikznodei"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:231:1: tikznodei : '\\\\node' tikznode ;
    public simpletikzParser.tikznodei_return tikznodei() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznodei_return retval = new simpletikzParser.tikznodei_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal113 = null;
        simpletikzParser.tikznode_return tikznode114 = default(simpletikzParser.tikznode_return);


        object string_literal113_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:232:2: ( '\\\\node' tikznode )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:232:4: '\\\\node' tikznode
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal113=(IToken)Match(input,NODE,FOLLOW_NODE_in_tikznodei1347); 
            	PushFollow(FOLLOW_tikznode_in_tikznodei1350);
            	tikznode114 = tikznode();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, tikznode114.Tree);

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
    // $ANTLR end "tikznodei"

    public class nodename_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "nodename"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:235:1: nodename : LPAR id= ID RPAR -> ^( IM_NODENAME $id) ;
    public simpletikzParser.nodename_return nodename() // throws RecognitionException [1]
    {   
        simpletikzParser.nodename_return retval = new simpletikzParser.nodename_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken id = null;
        IToken LPAR115 = null;
        IToken RPAR116 = null;

        object id_tree=null;
        object LPAR115_tree=null;
        object RPAR116_tree=null;
        RewriteRuleTokenStream stream_RPAR = new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR = new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:236:2: ( LPAR id= ID RPAR -> ^( IM_NODENAME $id) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:236:4: LPAR id= ID RPAR
            {
            	LPAR115=(IToken)Match(input,LPAR,FOLLOW_LPAR_in_nodename1362);  
            	stream_LPAR.Add(LPAR115);

            	id=(IToken)Match(input,ID,FOLLOW_ID_in_nodename1366);  
            	stream_ID.Add(id);

            	RPAR116=(IToken)Match(input,RPAR,FOLLOW_RPAR_in_nodename1368);  
            	stream_RPAR.Add(RPAR116);



            	// AST REWRITE
            	// elements:          id
            	// token labels:      id
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleTokenStream stream_id = new RewriteRuleTokenStream(adaptor, "token id", id);
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 236:21: -> ^( IM_NODENAME $id)
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:236:24: ^( IM_NODENAME $id)
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NODENAME, "IM_NODENAME"), root_1);

            	    adaptor.AddChild(root_1, stream_id.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
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
    // $ANTLR end "nodename"

    public class size_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "size"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:239:1: size : ( ( coord_modifier )? lc= LPAR numberunit RPAR ) ;
    public simpletikzParser.size_return size() // throws RecognitionException [1]
    {   
        simpletikzParser.size_return retval = new simpletikzParser.size_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken lc = null;
        IToken RPAR119 = null;
        simpletikzParser.coord_modifier_return coord_modifier117 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.numberunit_return numberunit118 = default(simpletikzParser.numberunit_return);


        object lc_tree=null;
        object RPAR119_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:240:2: ( ( ( coord_modifier )? lc= LPAR numberunit RPAR ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:240:6: ( ( coord_modifier )? lc= LPAR numberunit RPAR )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:240:6: ( ( coord_modifier )? lc= LPAR numberunit RPAR )
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:240:8: ( coord_modifier )? lc= LPAR numberunit RPAR
            	{
            		// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:240:8: ( coord_modifier )?
            		int alt37 = 2;
            		int LA37_0 = input.LA(1);

            		if ( ((LA37_0 >= 65 && LA37_0 <= 66)) )
            		{
            		    alt37 = 1;
            		}
            		switch (alt37) 
            		{
            		    case 1 :
            		        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:240:8: coord_modifier
            		        {
            		        	PushFollow(FOLLOW_coord_modifier_in_size1394);
            		        	coord_modifier117 = coord_modifier();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, coord_modifier117.Tree);

            		        }
            		        break;

            		}

            		lc=(IToken)Match(input,LPAR,FOLLOW_LPAR_in_size1399); 
            			lc_tree = (object)adaptor.Create(lc);
            			adaptor.AddChild(root_0, lc_tree);

            		PushFollow(FOLLOW_numberunit_in_size1401);
            		numberunit118 = numberunit();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, numberunit118.Tree);
            		RPAR119=(IToken)Match(input,RPAR,FOLLOW_RPAR_in_size1403); 
            			RPAR119_tree = (object)adaptor.Create(RPAR119);
            			adaptor.AddChild(root_0, RPAR119_tree);


            	}


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
    // $ANTLR end "size"

    public class coord_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "coord"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:246:1: coord : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? lc= LPAR numberunit coord_sep numberunit RPAR ) -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ coord_sep ) );
    public simpletikzParser.coord_return coord() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_return retval = new simpletikzParser.coord_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken lc = null;
        IToken RPAR125 = null;
        simpletikzParser.nodename_return nodename120 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_modifier_return coord_modifier121 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.numberunit_return numberunit122 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_sep_return coord_sep123 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.numberunit_return numberunit124 = default(simpletikzParser.numberunit_return);


        object lc_tree=null;
        object RPAR125_tree=null;
        RewriteRuleTokenStream stream_RPAR = new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR = new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_coord_sep = new RewriteRuleSubtreeStream(adaptor,"rule coord_sep");
        RewriteRuleSubtreeStream stream_nodename = new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        RewriteRuleSubtreeStream stream_coord_modifier = new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:247:2: ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? lc= LPAR numberunit coord_sep numberunit RPAR ) -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ coord_sep ) )
            int alt39 = 2;
            int LA39_0 = input.LA(1);

            if ( (LA39_0 == LPAR) )
            {
                int LA39_1 = input.LA(2);

                if ( (LA39_1 == ID) )
                {
                    alt39 = 1;
                }
                else if ( ((LA39_1 >= INT && LA39_1 <= FLOAT_WO_EXP)) )
                {
                    alt39 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d39s1 =
                        new NoViableAltException("", 39, 1, input);

                    throw nvae_d39s1;
                }
            }
            else if ( ((LA39_0 >= 65 && LA39_0 <= 66)) )
            {
                alt39 = 2;
            }
            else 
            {
                NoViableAltException nvae_d39s0 =
                    new NoViableAltException("", 39, 0, input);

                throw nvae_d39s0;
            }
            switch (alt39) 
            {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:247:6: nodename
                    {
                    	PushFollow(FOLLOW_nodename_in_coord1425);
                    	nodename120 = nodename();
                    	state.followingStackPointer--;

                    	stream_nodename.Add(nodename120.Tree);


                    	// AST REWRITE
                    	// elements:          nodename
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 247:23: -> ^( IM_COORD nodename )
                    	{
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:247:26: ^( IM_COORD nodename )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    adaptor.AddChild(root_1, stream_nodename.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:248:5: ( ( coord_modifier )? lc= LPAR numberunit coord_sep numberunit RPAR )
                    {
                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:248:5: ( ( coord_modifier )? lc= LPAR numberunit coord_sep numberunit RPAR )
                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:248:7: ( coord_modifier )? lc= LPAR numberunit coord_sep numberunit RPAR
                    	{
                    		// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:248:7: ( coord_modifier )?
                    		int alt38 = 2;
                    		int LA38_0 = input.LA(1);

                    		if ( ((LA38_0 >= 65 && LA38_0 <= 66)) )
                    		{
                    		    alt38 = 1;
                    		}
                    		switch (alt38) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:248:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord1449);
                    		        	coord_modifier121 = coord_modifier();
                    		        	state.followingStackPointer--;

                    		        	stream_coord_modifier.Add(coord_modifier121.Tree);

                    		        }
                    		        break;

                    		}

                    		lc=(IToken)Match(input,LPAR,FOLLOW_LPAR_in_coord1454);  
                    		stream_LPAR.Add(lc);

                    		PushFollow(FOLLOW_numberunit_in_coord1456);
                    		numberunit122 = numberunit();
                    		state.followingStackPointer--;

                    		stream_numberunit.Add(numberunit122.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord1458);
                    		coord_sep123 = coord_sep();
                    		state.followingStackPointer--;

                    		stream_coord_sep.Add(coord_sep123.Tree);
                    		PushFollow(FOLLOW_numberunit_in_coord1460);
                    		numberunit124 = numberunit();
                    		state.followingStackPointer--;

                    		stream_numberunit.Add(numberunit124.Tree);
                    		RPAR125=(IToken)Match(input,RPAR,FOLLOW_RPAR_in_coord1462);  
                    		stream_RPAR.Add(RPAR125);


                    	}



                    	// AST REWRITE
                    	// elements:          numberunit, coord_modifier, coord_sep
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 248:70: -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ coord_sep )
                    	{
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:248:73: ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ coord_sep )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, lc), root_1);

                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:248:89: ( coord_modifier )?
                    	    if ( stream_coord_modifier.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_coord_modifier.NextTree());

                    	    }
                    	    stream_coord_modifier.Reset();
                    	    if ( !(stream_numberunit.HasNext()) ) {
                    	        throw new RewriteEarlyExitException();
                    	    }
                    	    while ( stream_numberunit.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_numberunit.NextTree());

                    	    }
                    	    stream_numberunit.Reset();
                    	    adaptor.AddChild(root_1, stream_coord_sep.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
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
    // $ANTLR end "coord"

    public class coord_sep_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "coord_sep"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:250:1: coord_sep : ( ',' | ':' ) ;
    public simpletikzParser.coord_sep_return coord_sep() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_sep_return retval = new simpletikzParser.coord_sep_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set126 = null;

        object set126_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:251:2: ( ( ',' | ':' ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:251:4: ( ',' | ':' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set126 = (IToken)input.LT(1);
            	if ( input.LA(1) == KOMMA || input.LA(1) == COLON ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set126));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


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
    // $ANTLR end "coord_sep"

    public class tikznode_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikznode"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:254:1: tikznode : ( nodename )? ( 'at' coord )? ( nodetype )? tikzstring -> ^( IM_NODE ( nodename )? ( coord )? tikzstring ) ;
    public simpletikzParser.tikznode_return tikznode() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_return retval = new simpletikzParser.tikznode_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal128 = null;
        simpletikzParser.nodename_return nodename127 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_return coord129 = default(simpletikzParser.coord_return);

        simpletikzParser.nodetype_return nodetype130 = default(simpletikzParser.nodetype_return);

        simpletikzParser.tikzstring_return tikzstring131 = default(simpletikzParser.tikzstring_return);


        object string_literal128_tree=null;
        RewriteRuleTokenStream stream_60 = new RewriteRuleTokenStream(adaptor,"token 60");
        RewriteRuleSubtreeStream stream_coord = new RewriteRuleSubtreeStream(adaptor,"rule coord");
        RewriteRuleSubtreeStream stream_nodetype = new RewriteRuleSubtreeStream(adaptor,"rule nodetype");
        RewriteRuleSubtreeStream stream_tikzstring = new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_nodename = new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:2: ( ( nodename )? ( 'at' coord )? ( nodetype )? tikzstring -> ^( IM_NODE ( nodename )? ( coord )? tikzstring ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:4: ( nodename )? ( 'at' coord )? ( nodetype )? tikzstring
            {
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:4: ( nodename )?
            	int alt40 = 2;
            	int LA40_0 = input.LA(1);

            	if ( (LA40_0 == LPAR) )
            	{
            	    alt40 = 1;
            	}
            	switch (alt40) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:4: nodename
            	        {
            	        	PushFollow(FOLLOW_nodename_in_tikznode1509);
            	        	nodename127 = nodename();
            	        	state.followingStackPointer--;

            	        	stream_nodename.Add(nodename127.Tree);

            	        }
            	        break;

            	}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:14: ( 'at' coord )?
            	int alt41 = 2;
            	int LA41_0 = input.LA(1);

            	if ( (LA41_0 == 60) )
            	{
            	    alt41 = 1;
            	}
            	switch (alt41) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:15: 'at' coord
            	        {
            	        	string_literal128=(IToken)Match(input,60,FOLLOW_60_in_tikznode1513);  
            	        	stream_60.Add(string_literal128);

            	        	PushFollow(FOLLOW_coord_in_tikznode1515);
            	        	coord129 = coord();
            	        	state.followingStackPointer--;

            	        	stream_coord.Add(coord129.Tree);

            	        }
            	        break;

            	}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:28: ( nodetype )?
            	int alt42 = 2;
            	int LA42_0 = input.LA(1);

            	if ( (LA42_0 == LBR) )
            	{
            	    alt42 = 1;
            	}
            	switch (alt42) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:28: nodetype
            	        {
            	        	PushFollow(FOLLOW_nodetype_in_tikznode1519);
            	        	nodetype130 = nodetype();
            	        	state.followingStackPointer--;

            	        	stream_nodetype.Add(nodetype130.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzstring_in_tikznode1522);
            	tikzstring131 = tikzstring();
            	state.followingStackPointer--;

            	stream_tikzstring.Add(tikzstring131.Tree);


            	// AST REWRITE
            	// elements:          nodename, tikzstring, coord
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 255:50: -> ^( IM_NODE ( nodename )? ( coord )? tikzstring )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:53: ^( IM_NODE ( nodename )? ( coord )? tikzstring )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NODE, "IM_NODE"), root_1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:63: ( nodename )?
            	    if ( stream_nodename.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_nodename.NextTree());

            	    }
            	    stream_nodename.Reset();
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:73: ( coord )?
            	    if ( stream_coord.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_coord.NextTree());

            	    }
            	    stream_coord.Reset();
            	    adaptor.AddChild(root_1, stream_tikzstring.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
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
    // $ANTLR end "tikznode"

    public class edgeop_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "edgeop"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:259:1: edgeop : ( '--' | '->' | '|-' | '-|' | ID );
    public simpletikzParser.edgeop_return edgeop() // throws RecognitionException [1]
    {   
        simpletikzParser.edgeop_return retval = new simpletikzParser.edgeop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set132 = null;

        object set132_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:260:2: ( '--' | '->' | '|-' | '-|' | ID )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set132 = (IToken)input.LT(1);
            	if ( input.LA(1) == ID || (input.LA(1) >= 61 && input.LA(1) <= 64) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set132));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


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
    // $ANTLR end "edgeop"

    public class coord_modifier_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "coord_modifier"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:264:1: coord_modifier : ( '+' | '++' );
    public simpletikzParser.coord_modifier_return coord_modifier() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_modifier_return retval = new simpletikzParser.coord_modifier_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set133 = null;

        object set133_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:265:2: ( '+' | '++' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set133 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 65 && input.LA(1) <= 66) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set133));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


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
    // $ANTLR end "coord_modifier"

    public class tikznodee_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikznodee"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:268:1: tikznodee : node_start tikznode ( tikzpathi )? semicolon_end -> ^( IM_PATH node_start tikznode ( tikzpathi )? semicolon_end ) ;
    public simpletikzParser.tikznodee_return tikznodee() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznodee_return retval = new simpletikzParser.tikznodee_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.node_start_return node_start134 = default(simpletikzParser.node_start_return);

        simpletikzParser.tikznode_return tikznode135 = default(simpletikzParser.tikznode_return);

        simpletikzParser.tikzpathi_return tikzpathi136 = default(simpletikzParser.tikzpathi_return);

        simpletikzParser.semicolon_end_return semicolon_end137 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_node_start = new RewriteRuleSubtreeStream(adaptor,"rule node_start");
        RewriteRuleSubtreeStream stream_tikznode = new RewriteRuleSubtreeStream(adaptor,"rule tikznode");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        RewriteRuleSubtreeStream stream_tikzpathi = new RewriteRuleSubtreeStream(adaptor,"rule tikzpathi");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:269:2: ( node_start tikznode ( tikzpathi )? semicolon_end -> ^( IM_PATH node_start tikznode ( tikzpathi )? semicolon_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:269:4: node_start tikznode ( tikzpathi )? semicolon_end
            {
            	PushFollow(FOLLOW_node_start_in_tikznodee1597);
            	node_start134 = node_start();
            	state.followingStackPointer--;

            	stream_node_start.Add(node_start134.Tree);
            	PushFollow(FOLLOW_tikznode_in_tikznodee1599);
            	tikznode135 = tikznode();
            	state.followingStackPointer--;

            	stream_tikznode.Add(tikznode135.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:269:24: ( tikzpathi )?
            	int alt43 = 2;
            	int LA43_0 = input.LA(1);

            	if ( (LA43_0 == LPAR || (LA43_0 >= 65 && LA43_0 <= 66)) )
            	{
            	    alt43 = 1;
            	}
            	switch (alt43) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:269:24: tikzpathi
            	        {
            	        	PushFollow(FOLLOW_tikzpathi_in_tikznodee1601);
            	        	tikzpathi136 = tikzpathi();
            	        	state.followingStackPointer--;

            	        	stream_tikzpathi.Add(tikzpathi136.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_semicolon_end_in_tikznodee1604);
            	semicolon_end137 = semicolon_end();
            	state.followingStackPointer--;

            	stream_semicolon_end.Add(semicolon_end137.Tree);


            	// AST REWRITE
            	// elements:          tikzpathi, tikznode, semicolon_end, node_start
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 269:49: -> ^( IM_PATH node_start tikznode ( tikzpathi )? semicolon_end )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:269:52: ^( IM_PATH node_start tikznode ( tikzpathi )? semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_node_start.NextTree());
            	    adaptor.AddChild(root_1, stream_tikznode.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:269:82: ( tikzpathi )?
            	    if ( stream_tikzpathi.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzpathi.NextTree());

            	    }
            	    stream_tikzpathi.Reset();
            	    adaptor.AddChild(root_1, stream_semicolon_end.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
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
    // $ANTLR end "tikznodee"

    public class node_start_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "node_start"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:272:1: node_start : NODE -> ^( IM_STARTTAG NODE ) ;
    public simpletikzParser.node_start_return node_start() // throws RecognitionException [1]
    {   
        simpletikzParser.node_start_return retval = new simpletikzParser.node_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NODE138 = null;

        object NODE138_tree=null;
        RewriteRuleTokenStream stream_NODE = new RewriteRuleTokenStream(adaptor,"token NODE");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:273:2: ( NODE -> ^( IM_STARTTAG NODE ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:273:4: NODE
            {
            	NODE138=(IToken)Match(input,NODE,FOLLOW_NODE_in_node_start1632);  
            	stream_NODE.Add(NODE138);



            	// AST REWRITE
            	// elements:          NODE
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 273:9: -> ^( IM_STARTTAG NODE )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:273:12: ^( IM_STARTTAG NODE )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_NODE.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
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
    // $ANTLR end "node_start"

    public class squarebr_start_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "squarebr_start"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:315:1: squarebr_start : LBR -> ^( IM_STARTTAG LBR ) ;
    public simpletikzParser.squarebr_start_return squarebr_start() // throws RecognitionException [1]
    {   
        simpletikzParser.squarebr_start_return retval = new simpletikzParser.squarebr_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LBR139 = null;

        object LBR139_tree=null;
        RewriteRuleTokenStream stream_LBR = new RewriteRuleTokenStream(adaptor,"token LBR");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:316:2: ( LBR -> ^( IM_STARTTAG LBR ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:316:4: LBR
            {
            	LBR139=(IToken)Match(input,LBR,FOLLOW_LBR_in_squarebr_start1658);  
            	stream_LBR.Add(LBR139);



            	// AST REWRITE
            	// elements:          LBR
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 316:8: -> ^( IM_STARTTAG LBR )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:316:11: ^( IM_STARTTAG LBR )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_LBR.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
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
    // $ANTLR end "squarebr_start"

    public class squarebr_end_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "squarebr_end"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:318:1: squarebr_end : RBR -> ^( IM_ENDTAG RBR ) ;
    public simpletikzParser.squarebr_end_return squarebr_end() // throws RecognitionException [1]
    {   
        simpletikzParser.squarebr_end_return retval = new simpletikzParser.squarebr_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken RBR140 = null;

        object RBR140_tree=null;
        RewriteRuleTokenStream stream_RBR = new RewriteRuleTokenStream(adaptor,"token RBR");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:319:2: ( RBR -> ^( IM_ENDTAG RBR ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:319:4: RBR
            {
            	RBR140=(IToken)Match(input,RBR,FOLLOW_RBR_in_squarebr_end1676);  
            	stream_RBR.Add(RBR140);



            	// AST REWRITE
            	// elements:          RBR
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 319:8: -> ^( IM_ENDTAG RBR )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:319:11: ^( IM_ENDTAG RBR )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_RBR.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
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
    // $ANTLR end "squarebr_end"

    public class semicolon_end_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "semicolon_end"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:321:1: semicolon_end : ';' -> ^( IM_ENDTAG ';' ) ;
    public simpletikzParser.semicolon_end_return semicolon_end() // throws RecognitionException [1]
    {   
        simpletikzParser.semicolon_end_return retval = new simpletikzParser.semicolon_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal141 = null;

        object char_literal141_tree=null;
        RewriteRuleTokenStream stream_SEMIC = new RewriteRuleTokenStream(adaptor,"token SEMIC");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:322:2: ( ';' -> ^( IM_ENDTAG ';' ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:322:4: ';'
            {
            	char_literal141=(IToken)Match(input,SEMIC,FOLLOW_SEMIC_in_semicolon_end1695);  
            	stream_SEMIC.Add(char_literal141);



            	// AST REWRITE
            	// elements:          SEMIC
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 322:8: -> ^( IM_ENDTAG ';' )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:322:11: ^( IM_ENDTAG ';' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_SEMIC.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
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
    // $ANTLR end "semicolon_end"

    public class roundbr_end_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "roundbr_end"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:324:1: roundbr_end : '}' -> ^( IM_ENDTAG '}' ) ;
    public simpletikzParser.roundbr_end_return roundbr_end() // throws RecognitionException [1]
    {   
        simpletikzParser.roundbr_end_return retval = new simpletikzParser.roundbr_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal142 = null;

        object char_literal142_tree=null;
        RewriteRuleTokenStream stream_RBRR = new RewriteRuleTokenStream(adaptor,"token RBRR");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:325:2: ( '}' -> ^( IM_ENDTAG '}' ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:325:4: '}'
            {
            	char_literal142=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_roundbr_end1713);  
            	stream_RBRR.Add(char_literal142);



            	// AST REWRITE
            	// elements:          RBRR
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 325:8: -> ^( IM_ENDTAG '}' )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:325:11: ^( IM_ENDTAG '}' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_RBRR.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
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
    // $ANTLR end "roundbr_end"

    public class tikz_set_start_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikz_set_start"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:327:1: tikz_set_start : TIKZSET '{' -> ^( IM_STARTTAG ) ;
    public simpletikzParser.tikz_set_start_return tikz_set_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_set_start_return retval = new simpletikzParser.tikz_set_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken TIKZSET143 = null;
        IToken char_literal144 = null;

        object TIKZSET143_tree=null;
        object char_literal144_tree=null;
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_TIKZSET = new RewriteRuleTokenStream(adaptor,"token TIKZSET");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:328:2: ( TIKZSET '{' -> ^( IM_STARTTAG ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:328:4: TIKZSET '{'
            {
            	TIKZSET143=(IToken)Match(input,TIKZSET,FOLLOW_TIKZSET_in_tikz_set_start1731);  
            	stream_TIKZSET.Add(TIKZSET143);

            	char_literal144=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_tikz_set_start1733);  
            	stream_LBRR.Add(char_literal144);



            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 328:17: -> ^( IM_STARTTAG )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:328:20: ^( IM_STARTTAG )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
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
    // $ANTLR end "tikz_set_start"

    public class tikzpicture_start_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikzpicture_start"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:330:1: tikzpicture_start : BEGIN '{' 'tikzpicture' '}' -> ^( IM_STARTTAG BEGIN ) ;
    public simpletikzParser.tikzpicture_start_return tikzpicture_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_start_return retval = new simpletikzParser.tikzpicture_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken BEGIN145 = null;
        IToken char_literal146 = null;
        IToken string_literal147 = null;
        IToken char_literal148 = null;

        object BEGIN145_tree=null;
        object char_literal146_tree=null;
        object string_literal147_tree=null;
        object char_literal148_tree=null;
        RewriteRuleTokenStream stream_67 = new RewriteRuleTokenStream(adaptor,"token 67");
        RewriteRuleTokenStream stream_RBRR = new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_BEGIN = new RewriteRuleTokenStream(adaptor,"token BEGIN");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:331:2: ( BEGIN '{' 'tikzpicture' '}' -> ^( IM_STARTTAG BEGIN ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:331:4: BEGIN '{' 'tikzpicture' '}'
            {
            	BEGIN145=(IToken)Match(input,BEGIN,FOLLOW_BEGIN_in_tikzpicture_start1752);  
            	stream_BEGIN.Add(BEGIN145);

            	char_literal146=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_tikzpicture_start1754);  
            	stream_LBRR.Add(char_literal146);

            	string_literal147=(IToken)Match(input,67,FOLLOW_67_in_tikzpicture_start1756);  
            	stream_67.Add(string_literal147);

            	char_literal148=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_tikzpicture_start1758);  
            	stream_RBRR.Add(char_literal148);



            	// AST REWRITE
            	// elements:          BEGIN
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 331:32: -> ^( IM_STARTTAG BEGIN )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:331:35: ^( IM_STARTTAG BEGIN )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_BEGIN.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
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
    // $ANTLR end "tikzpicture_start"

    public class tikzpicture_end_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikzpicture_end"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:333:1: tikzpicture_end : END '{' 'tikzpicture' '}' -> ^( IM_ENDTAG END ) ;
    public simpletikzParser.tikzpicture_end_return tikzpicture_end() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_end_return retval = new simpletikzParser.tikzpicture_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken END149 = null;
        IToken char_literal150 = null;
        IToken string_literal151 = null;
        IToken char_literal152 = null;

        object END149_tree=null;
        object char_literal150_tree=null;
        object string_literal151_tree=null;
        object char_literal152_tree=null;
        RewriteRuleTokenStream stream_67 = new RewriteRuleTokenStream(adaptor,"token 67");
        RewriteRuleTokenStream stream_RBRR = new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_END = new RewriteRuleTokenStream(adaptor,"token END");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:334:2: ( END '{' 'tikzpicture' '}' -> ^( IM_ENDTAG END ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:334:4: END '{' 'tikzpicture' '}'
            {
            	END149=(IToken)Match(input,END,FOLLOW_END_in_tikzpicture_end1776);  
            	stream_END.Add(END149);

            	char_literal150=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_tikzpicture_end1778);  
            	stream_LBRR.Add(char_literal150);

            	string_literal151=(IToken)Match(input,67,FOLLOW_67_in_tikzpicture_end1780);  
            	stream_67.Add(string_literal151);

            	char_literal152=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_tikzpicture_end1782);  
            	stream_RBRR.Add(char_literal152);



            	// AST REWRITE
            	// elements:          END
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 334:30: -> ^( IM_ENDTAG END )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:334:33: ^( IM_ENDTAG END )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_END.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
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
    // $ANTLR end "tikzpicture_end"

    public class tikzscope_start_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikzscope_start"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:336:1: tikzscope_start : BEGIN '{' 'scope' '}' -> ^( IM_STARTTAG BEGIN ) ;
    public simpletikzParser.tikzscope_start_return tikzscope_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_start_return retval = new simpletikzParser.tikzscope_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken BEGIN153 = null;
        IToken char_literal154 = null;
        IToken string_literal155 = null;
        IToken char_literal156 = null;

        object BEGIN153_tree=null;
        object char_literal154_tree=null;
        object string_literal155_tree=null;
        object char_literal156_tree=null;
        RewriteRuleTokenStream stream_68 = new RewriteRuleTokenStream(adaptor,"token 68");
        RewriteRuleTokenStream stream_RBRR = new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_BEGIN = new RewriteRuleTokenStream(adaptor,"token BEGIN");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:337:2: ( BEGIN '{' 'scope' '}' -> ^( IM_STARTTAG BEGIN ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:337:4: BEGIN '{' 'scope' '}'
            {
            	BEGIN153=(IToken)Match(input,BEGIN,FOLLOW_BEGIN_in_tikzscope_start1800);  
            	stream_BEGIN.Add(BEGIN153);

            	char_literal154=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_tikzscope_start1802);  
            	stream_LBRR.Add(char_literal154);

            	string_literal155=(IToken)Match(input,68,FOLLOW_68_in_tikzscope_start1804);  
            	stream_68.Add(string_literal155);

            	char_literal156=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_tikzscope_start1806);  
            	stream_RBRR.Add(char_literal156);



            	// AST REWRITE
            	// elements:          BEGIN
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 337:26: -> ^( IM_STARTTAG BEGIN )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:337:29: ^( IM_STARTTAG BEGIN )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_BEGIN.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
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
    // $ANTLR end "tikzscope_start"

    public class tikzscope_end_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikzscope_end"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:339:1: tikzscope_end : END '{' 'scope' '}' -> ^( IM_ENDTAG END ) ;
    public simpletikzParser.tikzscope_end_return tikzscope_end() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_end_return retval = new simpletikzParser.tikzscope_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken END157 = null;
        IToken char_literal158 = null;
        IToken string_literal159 = null;
        IToken char_literal160 = null;

        object END157_tree=null;
        object char_literal158_tree=null;
        object string_literal159_tree=null;
        object char_literal160_tree=null;
        RewriteRuleTokenStream stream_68 = new RewriteRuleTokenStream(adaptor,"token 68");
        RewriteRuleTokenStream stream_RBRR = new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_END = new RewriteRuleTokenStream(adaptor,"token END");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:340:2: ( END '{' 'scope' '}' -> ^( IM_ENDTAG END ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:340:4: END '{' 'scope' '}'
            {
            	END157=(IToken)Match(input,END,FOLLOW_END_in_tikzscope_end1824);  
            	stream_END.Add(END157);

            	char_literal158=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_tikzscope_end1826);  
            	stream_LBRR.Add(char_literal158);

            	string_literal159=(IToken)Match(input,68,FOLLOW_68_in_tikzscope_end1828);  
            	stream_68.Add(string_literal159);

            	char_literal160=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_tikzscope_end1830);  
            	stream_RBRR.Add(char_literal160);



            	// AST REWRITE
            	// elements:          END
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 340:24: -> ^( IM_ENDTAG END )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:340:27: ^( IM_ENDTAG END )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_END.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
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
    // $ANTLR end "tikzscope_end"

    public class path_start_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "path_start"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:342:1: path_start : path_start_tag -> ^( IM_STARTTAG path_start_tag ) ;
    public simpletikzParser.path_start_return path_start() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_return retval = new simpletikzParser.path_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.path_start_tag_return path_start_tag161 = default(simpletikzParser.path_start_tag_return);


        RewriteRuleSubtreeStream stream_path_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule path_start_tag");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:343:2: ( path_start_tag -> ^( IM_STARTTAG path_start_tag ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:343:4: path_start_tag
            {
            	PushFollow(FOLLOW_path_start_tag_in_path_start1849);
            	path_start_tag161 = path_start_tag();
            	state.followingStackPointer--;

            	stream_path_start_tag.Add(path_start_tag161.Tree);


            	// AST REWRITE
            	// elements:          path_start_tag
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 343:19: -> ^( IM_STARTTAG path_start_tag )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:343:22: ^( IM_STARTTAG path_start_tag )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_path_start_tag.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
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
    // $ANTLR end "path_start"

    public class path_start_tag_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "path_start_tag"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:346:1: path_start_tag : ( DRAW | FILL | PATH );
    public simpletikzParser.path_start_tag_return path_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_tag_return retval = new simpletikzParser.path_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set162 = null;

        object set162_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:347:2: ( DRAW | FILL | PATH )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set162 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= DRAW && input.LA(1) <= FILL) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set162));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


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
    // $ANTLR end "path_start_tag"

    // Delegated rules


   	protected DFA7 dfa7;
   	protected DFA26 dfa26;
   	protected DFA27 dfa27;
	private void InitializeCyclicDFAs()
	{
    	this.dfa7 = new DFA7(this);
    	this.dfa26 = new DFA26(this);
    	this.dfa27 = new DFA27(this);
	}

    const string DFA7_eotS =
        "\x06\uffff";
    const string DFA7_eofS =
        "\x06\uffff";
    const string DFA7_minS =
        "\x01\x2d\x02\x10\x02\uffff\x01\x10";
    const string DFA7_maxS =
        "\x03\x40\x02\uffff\x01\x35";
    const string DFA7_acceptS =
        "\x03\uffff\x01\x01\x01\x02\x01\uffff";
    const string DFA7_specialS =
        "\x06\uffff}>";
    static readonly string[] DFA7_transitionS = {
            "\x01\x01\x0f\uffff\x04\x01",
            "\x01\x04\x01\uffff\x03\x04\x16\uffff\x01\x05\x01\uffff\x01"+
            "\x02\x07\uffff\x01\x03\x07\uffff\x04\x02",
            "\x01\x04\x01\uffff\x03\x04\x18\uffff\x01\x02\x07\uffff\x01"+
            "\x03\x07\uffff\x04\x02",
            "",
            "",
            "\x01\x04\x01\uffff\x03\x04\x20\uffff\x01\x03"
    };

    static readonly short[] DFA7_eot = DFA.UnpackEncodedString(DFA7_eotS);
    static readonly short[] DFA7_eof = DFA.UnpackEncodedString(DFA7_eofS);
    static readonly char[] DFA7_min = DFA.UnpackEncodedStringToUnsignedChars(DFA7_minS);
    static readonly char[] DFA7_max = DFA.UnpackEncodedStringToUnsignedChars(DFA7_maxS);
    static readonly short[] DFA7_accept = DFA.UnpackEncodedString(DFA7_acceptS);
    static readonly short[] DFA7_special = DFA.UnpackEncodedString(DFA7_specialS);
    static readonly short[][] DFA7_transition = DFA.UnpackEncodedStringArray(DFA7_transitionS);

    protected class DFA7 : DFA
    {
        public DFA7(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 7;
            this.eot = DFA7_eot;
            this.eof = DFA7_eof;
            this.min = DFA7_min;
            this.max = DFA7_max;
            this.accept = DFA7_accept;
            this.special = DFA7_special;
            this.transition = DFA7_transition;

        }

        override public string Description
        {
            get { return "120:1: option : ( option_style | option_kv );"; }
        }

    }

    const string DFA26_eotS =
        "\x0b\uffff";
    const string DFA26_eofS =
        "\x0b\uffff";
    const string DFA26_minS =
        "\x01\x04\x01\x11\x06\uffff\x01\x2d\x02\uffff";
    const string DFA26_maxS =
        "\x01\x44\x01\x11\x06\uffff\x01\x44\x02\uffff";
    const string DFA26_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x08\x01"+
        "\uffff\x01\x01\x01\x07";
    const string DFA26_specialS =
        "\x0b\uffff}>";
    static readonly string[] DFA26_transitionS = {
            "\x01\x01\x01\x07\x01\x04\x01\x06\x01\x05\x01\x03\x03\x02\x02"+
            "\x04\x01\uffff\x35\x04",
            "\x01\x08",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0a\x0f\uffff\x04\x0a\x03\uffff\x01\x09",
            "",
            ""
    };

    static readonly short[] DFA26_eot = DFA.UnpackEncodedString(DFA26_eotS);
    static readonly short[] DFA26_eof = DFA.UnpackEncodedString(DFA26_eofS);
    static readonly char[] DFA26_min = DFA.UnpackEncodedStringToUnsignedChars(DFA26_minS);
    static readonly char[] DFA26_max = DFA.UnpackEncodedStringToUnsignedChars(DFA26_maxS);
    static readonly short[] DFA26_accept = DFA.UnpackEncodedString(DFA26_acceptS);
    static readonly short[] DFA26_special = DFA.UnpackEncodedString(DFA26_specialS);
    static readonly short[][] DFA26_transition = DFA.UnpackEncodedStringArray(DFA26_transitionS);

    protected class DFA26 : DFA
    {
        public DFA26(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 26;
            this.eot = DFA26_eot;
            this.eof = DFA26_eof;
            this.min = DFA26_min;
            this.max = DFA26_max;
            this.accept = DFA26_accept;
            this.special = DFA26_special;
            this.transition = DFA26_transition;

        }

        override public string Description
        {
            get { return "187:4: ( tikzscope | tikzpath | tikznodee | dontcare_body_nobr | tikz_set | tikz_style | otherbegin | otherend )"; }
        }

    }

    const string DFA27_eotS =
        "\x0e\uffff";
    const string DFA27_eofS =
        "\x0e\uffff";
    const string DFA27_minS =
        "\x01\x04\x02\x11\x05\uffff\x02\x2d\x04\uffff";
    const string DFA27_maxS =
        "\x01\x44\x02\x11\x05\uffff\x02\x44\x04\uffff";
    const string DFA27_acceptS =
        "\x03\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x02\uffff\x01"+
        "\x09\x01\x08\x01\x01\x01\x07";
    const string DFA27_specialS =
        "\x0e\uffff}>";
    static readonly string[] DFA27_transitionS = {
            "\x01\x02\x01\x01\x01\x05\x01\x07\x01\x06\x01\x04\x03\x03\x38"+
            "\x05",
            "\x01\x08",
            "\x01\x09",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0b\x0f\uffff\x04\x0b\x02\uffff\x02\x0a",
            "\x01\x0d\x0f\uffff\x04\x0d\x03\uffff\x01\x0c",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA27_eot = DFA.UnpackEncodedString(DFA27_eotS);
    static readonly short[] DFA27_eof = DFA.UnpackEncodedString(DFA27_eofS);
    static readonly char[] DFA27_min = DFA.UnpackEncodedStringToUnsignedChars(DFA27_minS);
    static readonly char[] DFA27_max = DFA.UnpackEncodedStringToUnsignedChars(DFA27_maxS);
    static readonly short[] DFA27_accept = DFA.UnpackEncodedString(DFA27_acceptS);
    static readonly short[] DFA27_special = DFA.UnpackEncodedString(DFA27_specialS);
    static readonly short[][] DFA27_transition = DFA.UnpackEncodedStringArray(DFA27_transitionS);

    protected class DFA27 : DFA
    {
        public DFA27(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 27;
            this.eot = DFA27_eot;
            this.eof = DFA27_eof;
            this.min = DFA27_min;
            this.max = DFA27_max;
            this.accept = DFA27_accept;
            this.special = DFA27_special;
            this.transition = DFA27_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 188:3: ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )*"; }
        }

    }

 

    public static readonly BitSet FOLLOW_tikz_styleorsetorcmd_in_tikzdocument344 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_dontcare_preamble_in_tikzdocument348 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzdocument352 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_tikzpicture_in_tikzdocument357 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikz_styleorsetorcmd384 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikz_styleorsetorcmd388 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_cmd_comment_in_tikz_styleorsetorcmd392 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_preamble403 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BEGIN_in_otherbegin428 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_LBRR_in_otherbegin430 = new BitSet(new ulong[]{0xE000200000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_idd_in_otherbegin432 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_RBRR_in_otherbegin434 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TIKZEDT_CMD_COMMENT_in_tikz_cmd_comment447 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TIKZSTYLE_in_tikz_style472 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_LBRR_in_tikz_style474 = new BitSet(new ulong[]{0xE000200000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_idd_in_tikz_style476 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_RBRR_in_tikz_style478 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_EQU_in_tikz_style480 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikz_style482 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_squarebr_start_in_tikz_options504 = new BitSet(new ulong[]{0xE000200000010000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_option_in_tikz_options507 = new BitSet(new ulong[]{0xE000200000090000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_KOMMA_in_tikz_options510 = new BitSet(new ulong[]{0xE000200000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_option_in_tikz_options512 = new BitSet(new ulong[]{0xE000200000090000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_KOMMA_in_tikz_options516 = new BitSet(new ulong[]{0xE000200000010000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_squarebr_end_in_tikz_options521 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_option_style_in_option546 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_option_kv_in_option555 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_option_kv569 = new BitSet(new ulong[]{0x0000000000100002UL});
    public static readonly BitSet FOLLOW_EQU_in_option_kv572 = new BitSet(new ulong[]{0xE000380000020000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_iddornumberunitorstring_in_option_kv574 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBR_in_nodetype602 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_no_rlbracket_in_nodetype604 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_nodetype_in_nodetype608 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_no_rlbracket_in_nodetype610 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_RBR_in_nodetype615 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_no_rlbracket638 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRR_in_tikzstring655 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_no_rlbrace_in_tikzstring657 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikzstring661 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_no_rlbrace_in_tikzstring663 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_RBRR_in_tikzstring668 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_no_rlbrace691 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_iddornumberunitorstring708 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_numberunit_in_iddornumberunitorstring712 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzstring_in_iddornumberunitorstring716 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_option_style726 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_option_style728 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_EQU_in_option_style730 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_LBRR_in_option_style732 = new BitSet(new ulong[]{0xE0002000000C0000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_option_kv_in_option_style735 = new BitSet(new ulong[]{0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_KOMMA_in_option_style738 = new BitSet(new ulong[]{0xE000200000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_option_kv_in_option_style740 = new BitSet(new ulong[]{0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_KOMMA_in_option_style747 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_RBRR_in_option_style750 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_edgeop_in_idd781 = new BitSet(new ulong[]{0xE000200000000002UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_edgeop_in_idd784 = new BitSet(new ulong[]{0xE000200000000002UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_edgeop_in_idd800 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_INT_in_idd802 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_number_in_numberunit831 = new BitSet(new ulong[]{0x0FC0000000000002UL});
    public static readonly BitSet FOLLOW_unit_in_numberunit833 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_number859 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unit0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_set_start_in_tikz_set914 = new BitSet(new ulong[]{0xE000200000040000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_option_in_tikz_set917 = new BitSet(new ulong[]{0xE0002000000C0000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_KOMMA_in_tikz_set920 = new BitSet(new ulong[]{0xE000200000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_option_in_tikz_set922 = new BitSet(new ulong[]{0xE0002000000C0000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_roundbr_end_in_tikz_set928 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzpicture_start_in_tikzpicture956 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpicture958 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzpicture961 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_tikzpicture_end_in_tikzpicture964 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody994 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody998 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_tikznodee_in_tikzbody1002 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_dontcare_body_nobr_in_tikzbody1006 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody1010 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody1014 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody1018 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody1021 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody1031 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody1035 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_tikznodee_in_tikzbody1039 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_dontcare_body_in_tikzbody1043 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody1052 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody1056 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody1060 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody1063 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body_nobr1079 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body1129 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_END_in_otherend1173 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_LBRR_in_otherend1175 = new BitSet(new ulong[]{0xE000200000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_idd_in_otherend1177 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_RBRR_in_otherend1179 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_in_tikzpath1192 = new BitSet(new ulong[]{0x000000000000A000UL,0x0000000000000006UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpath1194 = new BitSet(new ulong[]{0x000000000000A000UL,0x0000000000000006UL});
    public static readonly BitSet FOLLOW_tikzpathi_in_tikzpath1197 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzpath1199 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coordornode_new_in_tikzpathi1230 = new BitSet(new ulong[]{0xE000200000000002UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_edgeop_in_tikzpathi1233 = new BitSet(new ulong[]{0x000000000000A000UL,0x0000000000000006UL});
    public static readonly BitSet FOLLOW_coordornode_new_in_tikzpathi1236 = new BitSet(new ulong[]{0xE000200000000002UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_tikzscope_start_in_tikzscope1253 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzscope1255 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzscope1258 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_tikzscope_end_in_tikzscope1261 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_in_coordornode1289 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_size_in_coordornode1293 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznodei_in_coordornode1297 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_in_coordornode_new1314 = new BitSet(new ulong[]{0x0000200000000002UL});
    public static readonly BitSet FOLLOW_ID_in_coordornode_new1317 = new BitSet(new ulong[]{0xE000380000028002UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_nodetype_in_coordornode_new1320 = new BitSet(new ulong[]{0xE000380000020002UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_tikzstring_in_coordornode_new1325 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_size_in_coordornode_new1334 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NODE_in_tikznodei1347 = new BitSet(new ulong[]{0xF00038000002A000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_tikznode_in_tikznodei1350 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAR_in_nodename1362 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_ID_in_nodename1366 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_RPAR_in_nodename1368 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_size1394 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LPAR_in_size1399 = new BitSet(new ulong[]{0x0000180000000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_size1401 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_RPAR_in_size1403 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_coord1425 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord1449 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LPAR_in_coord1454 = new BitSet(new ulong[]{0x0000180000000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord1456 = new BitSet(new ulong[]{0x0000000000480000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord1458 = new BitSet(new ulong[]{0x0000180000000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord1460 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_RPAR_in_coord1462 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_coord_sep1489 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_tikznode1509 = new BitSet(new ulong[]{0xF000380000028000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_60_in_tikznode1513 = new BitSet(new ulong[]{0x0000000000002000UL,0x0000000000000006UL});
    public static readonly BitSet FOLLOW_coord_in_tikznode1515 = new BitSet(new ulong[]{0xE000380000028000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_nodetype_in_tikznode1519 = new BitSet(new ulong[]{0xE000380000020000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikznode1522 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_edgeop0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_coord_modifier0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_node_start_in_tikznodee1597 = new BitSet(new ulong[]{0xF00038000002A000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_tikznode_in_tikznodee1599 = new BitSet(new ulong[]{0x000000000020A000UL,0x0000000000000006UL});
    public static readonly BitSet FOLLOW_tikzpathi_in_tikznodee1601 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikznodee1604 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NODE_in_node_start1632 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBR_in_squarebr_start1658 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RBR_in_squarebr_end1676 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SEMIC_in_semicolon_end1695 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RBRR_in_roundbr_end1713 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TIKZSET_in_tikz_set_start1731 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_LBRR_in_tikz_set_start1733 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BEGIN_in_tikzpicture_start1752 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_LBRR_in_tikzpicture_start1754 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_tikzpicture_start1756 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_RBRR_in_tikzpicture_start1758 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_END_in_tikzpicture_end1776 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_LBRR_in_tikzpicture_end1778 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_tikzpicture_end1780 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_RBRR_in_tikzpicture_end1782 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BEGIN_in_tikzscope_start1800 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_LBRR_in_tikzscope_start1802 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_68_in_tikzscope_start1804 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_RBRR_in_tikzscope_start1806 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_END_in_tikzscope_end1824 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_LBRR_in_tikzscope_end1826 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_68_in_tikzscope_end1828 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_RBRR_in_tikzscope_end1830 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_tag_in_path_start1849 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_path_start_tag0 = new BitSet(new ulong[]{0x0000000000000002UL});

}
