// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g 2011-01-02 14:04:37

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;

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
		"CLIP", 
		"STYLETAG", 
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
		"IM_SIZE", 
		"IM_NODENAME", 
		"IM_NUMBERUNIT", 
		"IM_PICTURE", 
		"IM_DOCUMENT", 
		"IM_SCOPE", 
		"IM_STARTTAG", 
		"IM_ENDTAG", 
		"IM_OPTIONS", 
		"IM_OPTION_STYLE", 
		"IM_OPTION_KV", 
		"IM_ID", 
		"IM_TIKZSET", 
		"IM_USETIKZLIB", 
		"IM_STRING", 
		"IM_STYLE", 
		"IM_TIKZEDT_CMD", 
		"TIKZEDT_CMD_COMMENT", 
		"ID", 
		"FLOAT_WO_EXP", 
		"INT", 
		"WS", 
		"COMMENT", 
		"EXPONENT", 
		"ESC_SEQ", 
		"MATHSTRING", 
		"COMMAND", 
		"SOMETHING", 
		"'cm'", 
		"'in'", 
		"'ex'", 
		"'mm'", 
		"'pt'", 
		"'em'", 
		"'node'", 
		"'at'", 
		"'circle'", 
		"'ellipse'", 
		"'arc'", 
		"'and'", 
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
    public const int T__69 = 69;
    public const int T__66 = 66;
    public const int EXPONENT = 51;
    public const int T__67 = 67;
    public const int T__64 = 64;
    public const int TIKZEDT_CMD_COMMENT = 45;
    public const int IM_STARTTAG = 34;
    public const int T__65 = 65;
    public const int T__62 = 62;
    public const int T__63 = 63;
    public const int IM_PATH = 25;
    public const int RBR = 18;
    public const int IM_ID = 39;
    public const int SOMETHING = 55;
    public const int ID = 46;
    public const int T__61 = 61;
    public const int T__60 = 60;
    public const int EOF = -1;
    public const int MATHSTRING = 53;
    public const int LBR = 17;
    public const int COMMAND = 54;
    public const int IM_ENDTAG = 35;
    public const int IM_USETIKZLIB = 41;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int IM_DOCUMENT = 32;
    public const int T__58 = 58;
    public const int RBRR = 20;
    public const int ESC_SEQ = 52;
    public const int IM_STRING = 42;
    public const int LPAR = 15;
    public const int FILL = 12;
    public const int PATH = 11;
    public const int IM_TIKZSET = 40;
    public const int T__59 = 59;
    public const int BEGIN = 4;
    public const int IM_OPTION_KV = 38;
    public const int CLIP = 13;
    public const int COMMENT = 50;
    public const int IM_TIKZEDT_CMD = 44;
    public const int IM_OPTIONS = 36;
    public const int STYLETAG = 14;
    public const int IM_OPTION_STYLE = 37;
    public const int NODE = 9;
    public const int TIKZSTYLE = 7;
    public const int TIKZSET = 8;
    public const int IM_COORD = 27;
    public const int IM_PICTURE = 31;
    public const int INT = 48;
    public const int LBRR = 19;
    public const int IM_NODE = 26;
    public const int USETIKZLIB = 6;
    public const int IM_STYLE = 43;
    public const int COLON = 24;
    public const int IM_SCOPE = 33;
    public const int IM_NUMBERUNIT = 30;
    public const int WS = 49;
    public const int T__71 = 71;
    public const int T__72 = 72;
    public const int T__70 = 70;
    public const int KOMMA = 21;
    public const int EQU = 22;
    public const int IM_SIZE = 28;
    public const int RPAR = 16;
    public const int END = 5;
    public const int SEMIC = 23;
    public const int T__75 = 75;
    public const int T__74 = 74;
    public const int IM_NODENAME = 29;
    public const int T__73 = 73;
    public const int FLOAT_WO_EXP = 47;
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
		get { return "C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g"; }
    }



      //@Override
      protected override Object RecoverFromMismatchedToken(IIntStream input, int ttype, BitSet follow) {
        throw new MismatchedTokenException(ttype, input);
      }

      //@Override
      public override Object RecoverFromMismatchedSet(IIntStream input, RecognitionException e, BitSet follow) {
        throw e;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:120:1: tikzdocument : ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* tikzpicture ( . )* -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture ) ;
    public simpletikzParser.tikzdocument_return tikzdocument() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzdocument_return retval = new simpletikzParser.tikzdocument_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken wildcard5 = null;
        simpletikzParser.dontcare_preamble_return dontcare_preamble1 = default(simpletikzParser.dontcare_preamble_return);

        simpletikzParser.tikz_styleorsetorcmd_return tikz_styleorsetorcmd2 = default(simpletikzParser.tikz_styleorsetorcmd_return);

        simpletikzParser.otherbegin_return otherbegin3 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.tikzpicture_return tikzpicture4 = default(simpletikzParser.tikzpicture_return);


        object wildcard5_tree=null;
        RewriteRuleSubtreeStream stream_dontcare_preamble = new RewriteRuleSubtreeStream(adaptor,"rule dontcare_preamble");
        RewriteRuleSubtreeStream stream_tikzpicture = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture");
        RewriteRuleSubtreeStream stream_otherbegin = new RewriteRuleSubtreeStream(adaptor,"rule otherbegin");
        RewriteRuleSubtreeStream stream_tikz_styleorsetorcmd = new RewriteRuleSubtreeStream(adaptor,"rule tikz_styleorsetorcmd");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:121:2: ( ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* tikzpicture ( . )* -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:121:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* tikzpicture ( . )*
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:121:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )*
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
            	            int LA1_4 = input.LA(3);

            	            if ( (LA1_4 == ID) )
            	            {
            	                alt1 = 3;
            	            }


            	        }


            	        }
            	        break;
            	    case END:
            	    case USETIKZLIB:
            	    case NODE:
            	    case DRAW:
            	    case PATH:
            	    case FILL:
            	    case CLIP:
            	    case STYLETAG:
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
            	    case IM_SIZE:
            	    case IM_NODENAME:
            	    case IM_NUMBERUNIT:
            	    case IM_PICTURE:
            	    case IM_DOCUMENT:
            	    case IM_SCOPE:
            	    case IM_STARTTAG:
            	    case IM_ENDTAG:
            	    case IM_OPTIONS:
            	    case IM_OPTION_STYLE:
            	    case IM_OPTION_KV:
            	    case IM_ID:
            	    case IM_TIKZSET:
            	    case IM_USETIKZLIB:
            	    case IM_STRING:
            	    case IM_STYLE:
            	    case IM_TIKZEDT_CMD:
            	    case ID:
            	    case FLOAT_WO_EXP:
            	    case INT:
            	    case WS:
            	    case COMMENT:
            	    case EXPONENT:
            	    case ESC_SEQ:
            	    case MATHSTRING:
            	    case COMMAND:
            	    case SOMETHING:
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
            	    case 69:
            	    case 70:
            	    case 71:
            	    case 72:
            	    case 73:
            	    case 74:
            	    case 75:
            	    	{
            	        alt1 = 1;
            	        }
            	        break;
            	    case TIKZSTYLE:
            	    case TIKZSET:
            	    case TIKZEDT_CMD_COMMENT:
            	    	{
            	        alt1 = 2;
            	        }
            	        break;

            	    }

            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:121:5: dontcare_preamble
            			    {
            			    	PushFollow(FOLLOW_dontcare_preamble_in_tikzdocument392);
            			    	dontcare_preamble1 = dontcare_preamble();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_dontcare_preamble.Add(dontcare_preamble1.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:121:25: tikz_styleorsetorcmd
            			    {
            			    	PushFollow(FOLLOW_tikz_styleorsetorcmd_in_tikzdocument396);
            			    	tikz_styleorsetorcmd2 = tikz_styleorsetorcmd();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikz_styleorsetorcmd.Add(tikz_styleorsetorcmd2.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:121:48: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzdocument400);
            			    	otherbegin3 = otherbegin();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_otherbegin.Add(otherbegin3.Tree);

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	PushFollow(FOLLOW_tikzpicture_in_tikzdocument405);
            	tikzpicture4 = tikzpicture();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzpicture.Add(tikzpicture4.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:121:74: ( . )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= BEGIN && LA2_0 <= 75)) )
            	    {
            	        alt2 = 1;
            	    }
            	    else if ( (LA2_0 == EOF) )
            	    {
            	        alt2 = 2;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:121:74: .
            			    {
            			    	wildcard5 = (IToken)input.LT(1);
            			    	MatchAny(input); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{wildcard5_tree = (object)adaptor.Create(wildcard5);
            			    		adaptor.AddChild(root_0, wildcard5_tree);
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements



            	// AST REWRITE
            	// elements:          tikz_styleorsetorcmd, tikzpicture
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 121:77: -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:121:80: ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DOCUMENT, "IM_DOCUMENT"), root_1);

            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:121:94: ( tikz_styleorsetorcmd )*
            	    while ( stream_tikz_styleorsetorcmd.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikz_styleorsetorcmd.NextTree());

            	    }
            	    stream_tikz_styleorsetorcmd.Reset();
            	    adaptor.AddChild(root_1, stream_tikzpicture.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
            }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tikzdocument"

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:124:1: tikz_cmd_comment : TIKZEDT_CMD_COMMENT -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT ) ;
    public simpletikzParser.tikz_cmd_comment_return tikz_cmd_comment() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_cmd_comment_return retval = new simpletikzParser.tikz_cmd_comment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken TIKZEDT_CMD_COMMENT6 = null;

        object TIKZEDT_CMD_COMMENT6_tree=null;
        RewriteRuleTokenStream stream_TIKZEDT_CMD_COMMENT = new RewriteRuleTokenStream(adaptor,"token TIKZEDT_CMD_COMMENT");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:125:2: ( TIKZEDT_CMD_COMMENT -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:125:4: TIKZEDT_CMD_COMMENT
            {
            	TIKZEDT_CMD_COMMENT6=(IToken)Match(input,TIKZEDT_CMD_COMMENT,FOLLOW_TIKZEDT_CMD_COMMENT_in_tikz_cmd_comment431); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_TIKZEDT_CMD_COMMENT.Add(TIKZEDT_CMD_COMMENT6);



            	// AST REWRITE
            	// elements:          TIKZEDT_CMD_COMMENT
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 125:27: -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:125:30: ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_TIKZEDT_CMD, "IM_TIKZEDT_CMD"), root_1);

            	    adaptor.AddChild(root_1, stream_TIKZEDT_CMD_COMMENT.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
            }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tikz_cmd_comment"

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:128:1: tikz_styleorsetorcmd : ( tikz_style | tikz_set | tikz_cmd_comment );
    public simpletikzParser.tikz_styleorsetorcmd_return tikz_styleorsetorcmd() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_styleorsetorcmd_return retval = new simpletikzParser.tikz_styleorsetorcmd_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikz_style_return tikz_style7 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.tikz_set_return tikz_set8 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_cmd_comment_return tikz_cmd_comment9 = default(simpletikzParser.tikz_cmd_comment_return);



        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:129:2: ( tikz_style | tikz_set | tikz_cmd_comment )
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
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d3s0 =
            	        new NoViableAltException("", 3, 0, input);

            	    throw nvae_d3s0;
            }

            switch (alt3) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:129:4: tikz_style
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_style_in_tikz_styleorsetorcmd453);
                    	tikz_style7 = tikz_style();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style7.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:129:17: tikz_set
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_set_in_tikz_styleorsetorcmd457);
                    	tikz_set8 = tikz_set();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set8.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:129:28: tikz_cmd_comment
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_cmd_comment_in_tikz_styleorsetorcmd461);
                    	tikz_cmd_comment9 = tikz_cmd_comment();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_cmd_comment9.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:132:1: dontcare_preamble : ~ ( BEGIN | TIKZSTYLE | TIKZSET | TIKZEDT_CMD_COMMENT ) ;
    public simpletikzParser.dontcare_preamble_return dontcare_preamble() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_preamble_return retval = new simpletikzParser.dontcare_preamble_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set10 = null;

        object set10_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:133:2: (~ ( BEGIN | TIKZSTYLE | TIKZSET | TIKZEDT_CMD_COMMENT ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:133:4: ~ ( BEGIN | TIKZSTYLE | TIKZSET | TIKZEDT_CMD_COMMENT )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set10 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= END && input.LA(1) <= USETIKZLIB) || (input.LA(1) >= NODE && input.LA(1) <= IM_TIKZEDT_CMD) || (input.LA(1) >= ID && input.LA(1) <= 75) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set10));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:135:1: otherbegin : BEGIN LBRR idd2 RBRR ;
    public simpletikzParser.otherbegin_return otherbegin() // throws RecognitionException [1]
    {   
        simpletikzParser.otherbegin_return retval = new simpletikzParser.otherbegin_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken BEGIN11 = null;
        IToken LBRR12 = null;
        IToken RBRR14 = null;
        simpletikzParser.idd2_return idd213 = default(simpletikzParser.idd2_return);


        object BEGIN11_tree=null;
        object LBRR12_tree=null;
        object RBRR14_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:136:2: ( BEGIN LBRR idd2 RBRR )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:136:4: BEGIN LBRR idd2 RBRR
            {
            	root_0 = (object)adaptor.GetNilNode();

            	BEGIN11=(IToken)Match(input,BEGIN,FOLLOW_BEGIN_in_otherbegin497); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{BEGIN11_tree = (object)adaptor.Create(BEGIN11);
            		adaptor.AddChild(root_0, BEGIN11_tree);
            	}
            	LBRR12=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_otherbegin499); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LBRR12_tree = (object)adaptor.Create(LBRR12);
            		adaptor.AddChild(root_0, LBRR12_tree);
            	}
            	PushFollow(FOLLOW_idd2_in_otherbegin501);
            	idd213 = idd2();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idd213.Tree);
            	RBRR14=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_otherbegin503); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{RBRR14_tree = (object)adaptor.Create(RBRR14);
            		adaptor.AddChild(root_0, RBRR14_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
            }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "otherbegin"

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:139:1: tikz_style : TIKZSTYLE LBRR idd RBRR '=' tikz_options -> ^( IM_STYLE idd tikz_options ) ;
    public simpletikzParser.tikz_style_return tikz_style() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_style_return retval = new simpletikzParser.tikz_style_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken TIKZSTYLE15 = null;
        IToken LBRR16 = null;
        IToken RBRR18 = null;
        IToken char_literal19 = null;
        simpletikzParser.idd_return idd17 = default(simpletikzParser.idd_return);

        simpletikzParser.tikz_options_return tikz_options20 = default(simpletikzParser.tikz_options_return);


        object TIKZSTYLE15_tree=null;
        object LBRR16_tree=null;
        object RBRR18_tree=null;
        object char_literal19_tree=null;
        RewriteRuleTokenStream stream_EQU = new RewriteRuleTokenStream(adaptor,"token EQU");
        RewriteRuleTokenStream stream_RBRR = new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_TIKZSTYLE = new RewriteRuleTokenStream(adaptor,"token TIKZSTYLE");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:140:2: ( TIKZSTYLE LBRR idd RBRR '=' tikz_options -> ^( IM_STYLE idd tikz_options ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:140:4: TIKZSTYLE LBRR idd RBRR '=' tikz_options
            {
            	TIKZSTYLE15=(IToken)Match(input,TIKZSTYLE,FOLLOW_TIKZSTYLE_in_tikz_style515); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_TIKZSTYLE.Add(TIKZSTYLE15);

            	LBRR16=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_tikz_style517); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LBRR.Add(LBRR16);

            	PushFollow(FOLLOW_idd_in_tikz_style519);
            	idd17 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idd.Add(idd17.Tree);
            	RBRR18=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_tikz_style521); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RBRR.Add(RBRR18);

            	char_literal19=(IToken)Match(input,EQU,FOLLOW_EQU_in_tikz_style523); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_EQU.Add(char_literal19);

            	PushFollow(FOLLOW_tikz_options_in_tikz_style525);
            	tikz_options20 = tikz_options();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikz_options.Add(tikz_options20.Tree);


            	// AST REWRITE
            	// elements:          tikz_options, idd
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 140:45: -> ^( IM_STYLE idd tikz_options )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:140:48: ^( IM_STYLE idd tikz_options )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STYLE, "IM_STYLE"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    adaptor.AddChild(root_1, stream_tikz_options.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:143:1: tikz_options : squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) ;
    public simpletikzParser.tikz_options_return tikz_options() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_options_return retval = new simpletikzParser.tikz_options_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal23 = null;
        IToken char_literal25 = null;
        simpletikzParser.squarebr_start_return squarebr_start21 = default(simpletikzParser.squarebr_start_return);

        simpletikzParser.option_return option22 = default(simpletikzParser.option_return);

        simpletikzParser.option_return option24 = default(simpletikzParser.option_return);

        simpletikzParser.squarebr_end_return squarebr_end26 = default(simpletikzParser.squarebr_end_return);


        object char_literal23_tree=null;
        object char_literal25_tree=null;
        RewriteRuleTokenStream stream_KOMMA = new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_squarebr_start = new RewriteRuleSubtreeStream(adaptor,"rule squarebr_start");
        RewriteRuleSubtreeStream stream_squarebr_end = new RewriteRuleSubtreeStream(adaptor,"rule squarebr_end");
        RewriteRuleSubtreeStream stream_option = new RewriteRuleSubtreeStream(adaptor,"rule option");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:144:2: ( squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:144:5: squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end
            {
            	PushFollow(FOLLOW_squarebr_start_in_tikz_options547);
            	squarebr_start21 = squarebr_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_squarebr_start.Add(squarebr_start21.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:144:20: ( option ( ',' option )* ( ',' )? )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( ((LA6_0 >= BEGIN && LA6_0 <= CLIP) || (LA6_0 >= IM_PATH && LA6_0 <= 75)) )
            	{
            	    alt6 = 1;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:144:21: option ( ',' option )* ( ',' )?
            	        {
            	        	PushFollow(FOLLOW_option_in_tikz_options550);
            	        	option22 = option();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_option.Add(option22.Tree);
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:144:28: ( ',' option )*
            	        	do 
            	        	{
            	        	    int alt4 = 2;
            	        	    int LA4_0 = input.LA(1);

            	        	    if ( (LA4_0 == KOMMA) )
            	        	    {
            	        	        int LA4_1 = input.LA(2);

            	        	        if ( ((LA4_1 >= BEGIN && LA4_1 <= CLIP) || (LA4_1 >= IM_PATH && LA4_1 <= 75)) )
            	        	        {
            	        	            alt4 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt4) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:144:29: ',' option
            	        			    {
            	        			    	char_literal23=(IToken)Match(input,KOMMA,FOLLOW_KOMMA_in_tikz_options553); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_KOMMA.Add(char_literal23);

            	        			    	PushFollow(FOLLOW_option_in_tikz_options555);
            	        			    	option24 = option();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( (state.backtracking==0) ) stream_option.Add(option24.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop4;
            	        	    }
            	        	} while (true);

            	        	loop4:
            	        		;	// Stops C# compiler whining that label 'loop4' has no statements

            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:144:42: ( ',' )?
            	        	int alt5 = 2;
            	        	int LA5_0 = input.LA(1);

            	        	if ( (LA5_0 == KOMMA) )
            	        	{
            	        	    alt5 = 1;
            	        	}
            	        	switch (alt5) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:144:42: ','
            	        	        {
            	        	        	char_literal25=(IToken)Match(input,KOMMA,FOLLOW_KOMMA_in_tikz_options559); if (state.failed) return retval; 
            	        	        	if ( (state.backtracking==0) ) stream_KOMMA.Add(char_literal25);


            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_squarebr_end_in_tikz_options564);
            	squarebr_end26 = squarebr_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_squarebr_end.Add(squarebr_end26.Tree);


            	// AST REWRITE
            	// elements:          squarebr_end, option, squarebr_start
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 144:63: -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:144:66: ^( IM_OPTIONS squarebr_start ( option )* squarebr_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTIONS, "IM_OPTIONS"), root_1);

            	    adaptor.AddChild(root_1, stream_squarebr_start.NextTree());
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:144:94: ( option )*
            	    while ( stream_option.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_option.NextTree());

            	    }
            	    stream_option.Reset();
            	    adaptor.AddChild(root_1, stream_squarebr_end.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:147:1: option : ( option_style | option_kv );
    public simpletikzParser.option_return option() // throws RecognitionException [1]
    {   
        simpletikzParser.option_return retval = new simpletikzParser.option_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.option_style_return option_style27 = default(simpletikzParser.option_style_return);

        simpletikzParser.option_kv_return option_kv28 = default(simpletikzParser.option_kv_return);



        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:148:2: ( option_style | option_kv )
            int alt7 = 2;
            alt7 = dfa7.Predict(input);
            switch (alt7) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:148:4: option_style
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_option_style_in_option589);
                    	option_style27 = option_style();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, option_style27.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:149:5: option_kv
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_option_kv_in_option598);
                    	option_kv28 = option_kv();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, option_kv28.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:152:1: option_kv : idd ( '=' iddornumberunitorstring )? -> ^( IM_OPTION_KV idd ( iddornumberunitorstring )? ) ;
    public simpletikzParser.option_kv_return option_kv() // throws RecognitionException [1]
    {   
        simpletikzParser.option_kv_return retval = new simpletikzParser.option_kv_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal30 = null;
        simpletikzParser.idd_return idd29 = default(simpletikzParser.idd_return);

        simpletikzParser.iddornumberunitorstring_return iddornumberunitorstring31 = default(simpletikzParser.iddornumberunitorstring_return);


        object char_literal30_tree=null;
        RewriteRuleTokenStream stream_EQU = new RewriteRuleTokenStream(adaptor,"token EQU");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_iddornumberunitorstring = new RewriteRuleSubtreeStream(adaptor,"rule iddornumberunitorstring");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:153:2: ( idd ( '=' iddornumberunitorstring )? -> ^( IM_OPTION_KV idd ( iddornumberunitorstring )? ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:153:4: idd ( '=' iddornumberunitorstring )?
            {
            	PushFollow(FOLLOW_idd_in_option_kv612);
            	idd29 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idd.Add(idd29.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:153:8: ( '=' iddornumberunitorstring )?
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( (LA8_0 == EQU) )
            	{
            	    alt8 = 1;
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:153:9: '=' iddornumberunitorstring
            	        {
            	        	char_literal30=(IToken)Match(input,EQU,FOLLOW_EQU_in_option_kv615); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_EQU.Add(char_literal30);

            	        	PushFollow(FOLLOW_iddornumberunitorstring_in_option_kv617);
            	        	iddornumberunitorstring31 = iddornumberunitorstring();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_iddornumberunitorstring.Add(iddornumberunitorstring31.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          iddornumberunitorstring, idd
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 153:40: -> ^( IM_OPTION_KV idd ( iddornumberunitorstring )? )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:153:43: ^( IM_OPTION_KV idd ( iddornumberunitorstring )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTION_KV, "IM_OPTION_KV"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:153:62: ( iddornumberunitorstring )?
            	    if ( stream_iddornumberunitorstring.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_iddornumberunitorstring.NextTree());

            	    }
            	    stream_iddornumberunitorstring.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
            }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "option_kv"

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:156:1: tikzstring : LBRR ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* RBRR -> ^( IM_STRING LBRR RBRR ) ;
    public simpletikzParser.tikzstring_return tikzstring() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzstring_return retval = new simpletikzParser.tikzstring_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LBRR32 = null;
        IToken RBRR36 = null;
        simpletikzParser.no_rlbrace_return no_rlbrace33 = default(simpletikzParser.no_rlbrace_return);

        simpletikzParser.tikzstring_return tikzstring34 = default(simpletikzParser.tikzstring_return);

        simpletikzParser.no_rlbrace_return no_rlbrace35 = default(simpletikzParser.no_rlbrace_return);


        object LBRR32_tree=null;
        object RBRR36_tree=null;
        RewriteRuleTokenStream stream_RBRR = new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleSubtreeStream stream_tikzstring = new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_no_rlbrace = new RewriteRuleSubtreeStream(adaptor,"rule no_rlbrace");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:157:2: ( LBRR ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* RBRR -> ^( IM_STRING LBRR RBRR ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:157:4: LBRR ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* RBRR
            {
            	LBRR32=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_tikzstring645); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LBRR.Add(LBRR32);

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:157:9: ( no_rlbrace )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( ((LA9_0 >= BEGIN && LA9_0 <= RBR) || (LA9_0 >= KOMMA && LA9_0 <= 75)) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:157:9: no_rlbrace
            			    {
            			    	PushFollow(FOLLOW_no_rlbrace_in_tikzstring647);
            			    	no_rlbrace33 = no_rlbrace();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_no_rlbrace.Add(no_rlbrace33.Tree);

            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:157:21: ( tikzstring ( no_rlbrace )* )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( (LA11_0 == LBRR) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:157:22: tikzstring ( no_rlbrace )*
            			    {
            			    	PushFollow(FOLLOW_tikzstring_in_tikzstring651);
            			    	tikzstring34 = tikzstring();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikzstring.Add(tikzstring34.Tree);
            			    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:157:33: ( no_rlbrace )*
            			    	do 
            			    	{
            			    	    int alt10 = 2;
            			    	    int LA10_0 = input.LA(1);

            			    	    if ( ((LA10_0 >= BEGIN && LA10_0 <= RBR) || (LA10_0 >= KOMMA && LA10_0 <= 75)) )
            			    	    {
            			    	        alt10 = 1;
            			    	    }


            			    	    switch (alt10) 
            			    		{
            			    			case 1 :
            			    			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:157:33: no_rlbrace
            			    			    {
            			    			    	PushFollow(FOLLOW_no_rlbrace_in_tikzstring653);
            			    			    	no_rlbrace35 = no_rlbrace();
            			    			    	state.followingStackPointer--;
            			    			    	if (state.failed) return retval;
            			    			    	if ( (state.backtracking==0) ) stream_no_rlbrace.Add(no_rlbrace35.Tree);

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

            	RBRR36=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_tikzstring658); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RBRR.Add(RBRR36);



            	// AST REWRITE
            	// elements:          RBRR, LBRR
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 157:52: -> ^( IM_STRING LBRR RBRR )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:157:55: ^( IM_STRING LBRR RBRR )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STRING, "IM_STRING"), root_1);

            	    adaptor.AddChild(root_1, stream_LBRR.NextNode());
            	    adaptor.AddChild(root_1, stream_RBRR.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:160:1: no_rlbrace : ~ ( LBRR | RBRR ) ;
    public simpletikzParser.no_rlbrace_return no_rlbrace() // throws RecognitionException [1]
    {   
        simpletikzParser.no_rlbrace_return retval = new simpletikzParser.no_rlbrace_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set37 = null;

        object set37_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:161:2: (~ ( LBRR | RBRR ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:161:4: ~ ( LBRR | RBRR )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set37 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= BEGIN && input.LA(1) <= RBR) || (input.LA(1) >= KOMMA && input.LA(1) <= 75) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set37));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:163:1: iddornumberunitorstring : ( idd | tikzstring );
    public simpletikzParser.iddornumberunitorstring_return iddornumberunitorstring() // throws RecognitionException [1]
    {   
        simpletikzParser.iddornumberunitorstring_return retval = new simpletikzParser.iddornumberunitorstring_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.idd_return idd38 = default(simpletikzParser.idd_return);

        simpletikzParser.tikzstring_return tikzstring39 = default(simpletikzParser.tikzstring_return);



        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:164:2: ( idd | tikzstring )
            int alt12 = 2;
            int LA12_0 = input.LA(1);

            if ( ((LA12_0 >= BEGIN && LA12_0 <= CLIP) || (LA12_0 >= IM_PATH && LA12_0 <= 75)) )
            {
                alt12 = 1;
            }
            else if ( (LA12_0 == LBRR) )
            {
                alt12 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d12s0 =
                    new NoViableAltException("", 12, 0, input);

                throw nvae_d12s0;
            }
            switch (alt12) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:164:4: idd
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_idd_in_iddornumberunitorstring698);
                    	idd38 = idd();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idd38.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:164:10: tikzstring
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikzstring_in_iddornumberunitorstring702);
                    	tikzstring39 = tikzstring();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzstring39.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:166:1: option_style : idd STYLETAG '=' LBRR ( option_kv ( ',' option_kv )* )? ( ',' )? RBRR -> ^( IM_OPTION_STYLE idd ( option_kv )* ) ;
    public simpletikzParser.option_style_return option_style() // throws RecognitionException [1]
    {   
        simpletikzParser.option_style_return retval = new simpletikzParser.option_style_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken STYLETAG41 = null;
        IToken char_literal42 = null;
        IToken LBRR43 = null;
        IToken char_literal45 = null;
        IToken char_literal47 = null;
        IToken RBRR48 = null;
        simpletikzParser.idd_return idd40 = default(simpletikzParser.idd_return);

        simpletikzParser.option_kv_return option_kv44 = default(simpletikzParser.option_kv_return);

        simpletikzParser.option_kv_return option_kv46 = default(simpletikzParser.option_kv_return);


        object STYLETAG41_tree=null;
        object char_literal42_tree=null;
        object LBRR43_tree=null;
        object char_literal45_tree=null;
        object char_literal47_tree=null;
        object RBRR48_tree=null;
        RewriteRuleTokenStream stream_EQU = new RewriteRuleTokenStream(adaptor,"token EQU");
        RewriteRuleTokenStream stream_RBRR = new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_STYLETAG = new RewriteRuleTokenStream(adaptor,"token STYLETAG");
        RewriteRuleTokenStream stream_KOMMA = new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_option_kv = new RewriteRuleSubtreeStream(adaptor,"rule option_kv");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:167:2: ( idd STYLETAG '=' LBRR ( option_kv ( ',' option_kv )* )? ( ',' )? RBRR -> ^( IM_OPTION_STYLE idd ( option_kv )* ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:167:4: idd STYLETAG '=' LBRR ( option_kv ( ',' option_kv )* )? ( ',' )? RBRR
            {
            	PushFollow(FOLLOW_idd_in_option_style712);
            	idd40 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idd.Add(idd40.Tree);
            	STYLETAG41=(IToken)Match(input,STYLETAG,FOLLOW_STYLETAG_in_option_style714); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_STYLETAG.Add(STYLETAG41);

            	char_literal42=(IToken)Match(input,EQU,FOLLOW_EQU_in_option_style716); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_EQU.Add(char_literal42);

            	LBRR43=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_option_style718); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LBRR.Add(LBRR43);

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:167:26: ( option_kv ( ',' option_kv )* )?
            	int alt14 = 2;
            	int LA14_0 = input.LA(1);

            	if ( ((LA14_0 >= BEGIN && LA14_0 <= CLIP) || (LA14_0 >= IM_PATH && LA14_0 <= 75)) )
            	{
            	    alt14 = 1;
            	}
            	switch (alt14) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:167:27: option_kv ( ',' option_kv )*
            	        {
            	        	PushFollow(FOLLOW_option_kv_in_option_style721);
            	        	option_kv44 = option_kv();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_option_kv.Add(option_kv44.Tree);
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:167:37: ( ',' option_kv )*
            	        	do 
            	        	{
            	        	    int alt13 = 2;
            	        	    int LA13_0 = input.LA(1);

            	        	    if ( (LA13_0 == KOMMA) )
            	        	    {
            	        	        int LA13_1 = input.LA(2);

            	        	        if ( ((LA13_1 >= BEGIN && LA13_1 <= CLIP) || (LA13_1 >= IM_PATH && LA13_1 <= 75)) )
            	        	        {
            	        	            alt13 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt13) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:167:38: ',' option_kv
            	        			    {
            	        			    	char_literal45=(IToken)Match(input,KOMMA,FOLLOW_KOMMA_in_option_style724); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_KOMMA.Add(char_literal45);

            	        			    	PushFollow(FOLLOW_option_kv_in_option_style726);
            	        			    	option_kv46 = option_kv();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( (state.backtracking==0) ) stream_option_kv.Add(option_kv46.Tree);

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

            	}

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:167:57: ( ',' )?
            	int alt15 = 2;
            	int LA15_0 = input.LA(1);

            	if ( (LA15_0 == KOMMA) )
            	{
            	    alt15 = 1;
            	}
            	switch (alt15) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:167:57: ','
            	        {
            	        	char_literal47=(IToken)Match(input,KOMMA,FOLLOW_KOMMA_in_option_style733); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_KOMMA.Add(char_literal47);


            	        }
            	        break;

            	}

            	RBRR48=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_option_style736); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RBRR.Add(RBRR48);



            	// AST REWRITE
            	// elements:          idd, option_kv
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 167:68: -> ^( IM_OPTION_STYLE idd ( option_kv )* )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:167:71: ^( IM_OPTION_STYLE idd ( option_kv )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTION_STYLE, "IM_OPTION_STYLE"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:167:93: ( option_kv )*
            	    while ( stream_option_kv.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_option_kv.NextTree());

            	    }
            	    stream_option_kv.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:179:1: idd : idd_heavenknowswhythisisnecessary -> ^( IM_ID ) ;
    public simpletikzParser.idd_return idd() // throws RecognitionException [1]
    {   
        simpletikzParser.idd_return retval = new simpletikzParser.idd_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.idd_heavenknowswhythisisnecessary_return idd_heavenknowswhythisisnecessary49 = default(simpletikzParser.idd_heavenknowswhythisisnecessary_return);


        RewriteRuleSubtreeStream stream_idd_heavenknowswhythisisnecessary = new RewriteRuleSubtreeStream(adaptor,"rule idd_heavenknowswhythisisnecessary");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:180:2: ( idd_heavenknowswhythisisnecessary -> ^( IM_ID ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:180:4: idd_heavenknowswhythisisnecessary
            {
            	PushFollow(FOLLOW_idd_heavenknowswhythisisnecessary_in_idd771);
            	idd_heavenknowswhythisisnecessary49 = idd_heavenknowswhythisisnecessary();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idd_heavenknowswhythisisnecessary.Add(idd_heavenknowswhythisisnecessary49.Tree);


            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 180:39: -> ^( IM_ID )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:180:42: ^( IM_ID )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ID, "IM_ID"), root_1);

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
            }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "idd"

    public class idd_heavenknowswhythisisnecessary_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "idd_heavenknowswhythisisnecessary"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:182:1: idd_heavenknowswhythisisnecessary : (~ ( LPAR | RPAR | LBR | RBR | LBRR | RBRR | KOMMA | EQU | SEMIC | COLON | STYLETAG ) )+ ;
    public simpletikzParser.idd_heavenknowswhythisisnecessary_return idd_heavenknowswhythisisnecessary() // throws RecognitionException [1]
    {   
        simpletikzParser.idd_heavenknowswhythisisnecessary_return retval = new simpletikzParser.idd_heavenknowswhythisisnecessary_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set50 = null;

        object set50_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:183:3: ( (~ ( LPAR | RPAR | LBR | RBR | LBRR | RBRR | KOMMA | EQU | SEMIC | COLON | STYLETAG ) )+ )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:183:6: (~ ( LPAR | RPAR | LBR | RBR | LBRR | RBRR | KOMMA | EQU | SEMIC | COLON | STYLETAG ) )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:183:6: (~ ( LPAR | RPAR | LBR | RBR | LBRR | RBRR | KOMMA | EQU | SEMIC | COLON | STYLETAG ) )+
            	int cnt16 = 0;
            	do 
            	{
            	    int alt16 = 2;
            	    int LA16_0 = input.LA(1);

            	    if ( ((LA16_0 >= BEGIN && LA16_0 <= CLIP) || (LA16_0 >= IM_PATH && LA16_0 <= 75)) )
            	    {
            	        alt16 = 1;
            	    }


            	    switch (alt16) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:183:6: ~ ( LPAR | RPAR | LBR | RBR | LBRR | RBRR | KOMMA | EQU | SEMIC | COLON | STYLETAG )
            			    {
            			    	set50 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= BEGIN && input.LA(1) <= CLIP) || (input.LA(1) >= IM_PATH && input.LA(1) <= 75) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set50));
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}


            			    }
            			    break;

            			default:
            			    if ( cnt16 >= 1 ) goto loop16;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee16 =
            		                new EarlyExitException(16, input);
            		            throw eee16;
            	    }
            	    cnt16++;
            	} while (true);

            	loop16:
            		;	// Stops C# compiler whining that label 'loop16' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
            }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "idd_heavenknowswhythisisnecessary"

    public class idd2_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "idd2"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:184:1: idd2 : ( ID )+ -> ^( IM_ID ) ;
    public simpletikzParser.idd2_return idd2() // throws RecognitionException [1]
    {   
        simpletikzParser.idd2_return retval = new simpletikzParser.idd2_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID51 = null;

        object ID51_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:185:2: ( ( ID )+ -> ^( IM_ID ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:185:4: ( ID )+
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:185:4: ( ID )+
            	int cnt17 = 0;
            	do 
            	{
            	    int alt17 = 2;
            	    int LA17_0 = input.LA(1);

            	    if ( (LA17_0 == ID) )
            	    {
            	        alt17 = 1;
            	    }


            	    switch (alt17) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:185:4: ID
            			    {
            			    	ID51=(IToken)Match(input,ID,FOLLOW_ID_in_idd2845); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_ID.Add(ID51);


            			    }
            			    break;

            			default:
            			    if ( cnt17 >= 1 ) goto loop17;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee17 =
            		                new EarlyExitException(17, input);
            		            throw eee17;
            	    }
            	    cnt17++;
            	} while (true);

            	loop17:
            		;	// Stops C# compiler whining that label 'loop17' has no statements



            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 185:8: -> ^( IM_ID )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:185:11: ^( IM_ID )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ID, "IM_ID"), root_1);

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
            }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "idd2"

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:189:1: numberunit : number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) ;
    public simpletikzParser.numberunit_return numberunit() // throws RecognitionException [1]
    {   
        simpletikzParser.numberunit_return retval = new simpletikzParser.numberunit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.number_return number52 = default(simpletikzParser.number_return);

        simpletikzParser.unit_return unit53 = default(simpletikzParser.unit_return);


        RewriteRuleSubtreeStream stream_unit = new RewriteRuleSubtreeStream(adaptor,"rule unit");
        RewriteRuleSubtreeStream stream_number = new RewriteRuleSubtreeStream(adaptor,"rule number");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:190:2: ( number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:190:4: number ( unit )?
            {
            	PushFollow(FOLLOW_number_in_numberunit868);
            	number52 = number();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_number.Add(number52.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:190:11: ( unit )?
            	int alt18 = 2;
            	int LA18_0 = input.LA(1);

            	if ( ((LA18_0 >= 56 && LA18_0 <= 61)) )
            	{
            	    alt18 = 1;
            	}
            	switch (alt18) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:190:11: unit
            	        {
            	        	PushFollow(FOLLOW_unit_in_numberunit870);
            	        	unit53 = unit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_unit.Add(unit53.Tree);

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
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 190:17: -> ^( IM_NUMBERUNIT number ( unit )? )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:190:20: ^( IM_NUMBERUNIT number ( unit )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NUMBERUNIT, "IM_NUMBERUNIT"), root_1);

            	    adaptor.AddChild(root_1, stream_number.NextTree());
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:190:43: ( unit )?
            	    if ( stream_unit.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_unit.NextTree());

            	    }
            	    stream_unit.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:194:1: number : ( FLOAT_WO_EXP | INT ) ;
    public simpletikzParser.number_return number() // throws RecognitionException [1]
    {   
        simpletikzParser.number_return retval = new simpletikzParser.number_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set54 = null;

        object set54_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:195:2: ( ( FLOAT_WO_EXP | INT ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:195:4: ( FLOAT_WO_EXP | INT )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set54 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= FLOAT_WO_EXP && input.LA(1) <= INT) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set54));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:198:1: unit : ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' | 'em' );
    public simpletikzParser.unit_return unit() // throws RecognitionException [1]
    {   
        simpletikzParser.unit_return retval = new simpletikzParser.unit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set55 = null;

        object set55_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:199:2: ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' | 'em' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set55 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 56 && input.LA(1) <= 61) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set55));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:202:1: tikz_set : tikz_set_start ( option ( ',' option )* )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) ;
    public simpletikzParser.tikz_set_return tikz_set() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_set_return retval = new simpletikzParser.tikz_set_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal58 = null;
        simpletikzParser.tikz_set_start_return tikz_set_start56 = default(simpletikzParser.tikz_set_start_return);

        simpletikzParser.option_return option57 = default(simpletikzParser.option_return);

        simpletikzParser.option_return option59 = default(simpletikzParser.option_return);

        simpletikzParser.roundbr_end_return roundbr_end60 = default(simpletikzParser.roundbr_end_return);


        object char_literal58_tree=null;
        RewriteRuleTokenStream stream_KOMMA = new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_tikz_set_start = new RewriteRuleSubtreeStream(adaptor,"rule tikz_set_start");
        RewriteRuleSubtreeStream stream_roundbr_end = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        RewriteRuleSubtreeStream stream_option = new RewriteRuleSubtreeStream(adaptor,"rule option");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:203:2: ( tikz_set_start ( option ( ',' option )* )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:203:5: tikz_set_start ( option ( ',' option )* )? roundbr_end
            {
            	PushFollow(FOLLOW_tikz_set_start_in_tikz_set951);
            	tikz_set_start56 = tikz_set_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikz_set_start.Add(tikz_set_start56.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:203:20: ( option ( ',' option )* )?
            	int alt20 = 2;
            	int LA20_0 = input.LA(1);

            	if ( ((LA20_0 >= BEGIN && LA20_0 <= CLIP) || (LA20_0 >= IM_PATH && LA20_0 <= 75)) )
            	{
            	    alt20 = 1;
            	}
            	switch (alt20) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:203:21: option ( ',' option )*
            	        {
            	        	PushFollow(FOLLOW_option_in_tikz_set954);
            	        	option57 = option();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_option.Add(option57.Tree);
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:203:28: ( ',' option )*
            	        	do 
            	        	{
            	        	    int alt19 = 2;
            	        	    int LA19_0 = input.LA(1);

            	        	    if ( (LA19_0 == KOMMA) )
            	        	    {
            	        	        alt19 = 1;
            	        	    }


            	        	    switch (alt19) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:203:29: ',' option
            	        			    {
            	        			    	char_literal58=(IToken)Match(input,KOMMA,FOLLOW_KOMMA_in_tikz_set957); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_KOMMA.Add(char_literal58);

            	        			    	PushFollow(FOLLOW_option_in_tikz_set959);
            	        			    	option59 = option();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( (state.backtracking==0) ) stream_option.Add(option59.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop19;
            	        	    }
            	        	} while (true);

            	        	loop19:
            	        		;	// Stops C# compiler whining that label 'loop19' has no statements


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_roundbr_end_in_tikz_set965);
            	roundbr_end60 = roundbr_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_roundbr_end.Add(roundbr_end60.Tree);


            	// AST REWRITE
            	// elements:          tikz_set_start, option, roundbr_end
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 203:56: -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:203:59: ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_TIKZSET, "IM_TIKZSET"), root_1);

            	    adaptor.AddChild(root_1, stream_tikz_set_start.NextTree());
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:203:87: ( option )*
            	    while ( stream_option.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_option.NextTree());

            	    }
            	    stream_option.Reset();
            	    adaptor.AddChild(root_1, stream_roundbr_end.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:208:1: tikzpicture : tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) ;
    public simpletikzParser.tikzpicture_return tikzpicture() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_return retval = new simpletikzParser.tikzpicture_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzpicture_start_return tikzpicture_start61 = default(simpletikzParser.tikzpicture_start_return);

        simpletikzParser.tikz_options_return tikz_options62 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody_return tikzbody63 = default(simpletikzParser.tikzbody_return);

        simpletikzParser.tikzpicture_end_return tikzpicture_end64 = default(simpletikzParser.tikzpicture_end_return);


        RewriteRuleSubtreeStream stream_tikzpicture_end = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_end");
        RewriteRuleSubtreeStream stream_tikzpicture_start = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_start");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:209:2: ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:209:5: tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end
            {
            	PushFollow(FOLLOW_tikzpicture_start_in_tikzpicture993);
            	tikzpicture_start61 = tikzpicture_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzpicture_start.Add(tikzpicture_start61.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:209:23: ( tikz_options )?
            	int alt21 = 2;
            	int LA21_0 = input.LA(1);

            	if ( (LA21_0 == LBR) )
            	{
            	    alt21 = 1;
            	}
            	switch (alt21) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:209:23: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_tikzpicture995);
            	        	tikz_options62 = tikz_options();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_tikz_options.Add(tikz_options62.Tree);

            	        }
            	        break;

            	}

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:209:37: ( tikzbody )?
            	int alt22 = 2;
            	int LA22_0 = input.LA(1);

            	if ( (LA22_0 == BEGIN || (LA22_0 >= USETIKZLIB && LA22_0 <= RPAR) || (LA22_0 >= RBR && LA22_0 <= 75)) )
            	{
            	    alt22 = 1;
            	}
            	else if ( (LA22_0 == END) )
            	{
            	    int LA22_2 = input.LA(2);

            	    if ( (LA22_2 == LBRR) )
            	    {
            	        int LA22_3 = input.LA(3);

            	        if ( (LA22_3 == ID) )
            	        {
            	            alt22 = 1;
            	        }
            	    }
            	}
            	switch (alt22) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:209:37: tikzbody
            	        {
            	        	PushFollow(FOLLOW_tikzbody_in_tikzpicture998);
            	        	tikzbody63 = tikzbody();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_tikzbody.Add(tikzbody63.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzpicture_end_in_tikzpicture1001);
            	tikzpicture_end64 = tikzpicture_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzpicture_end.Add(tikzpicture_end64.Tree);


            	// AST REWRITE
            	// elements:          tikzbody, tikzpicture_end, tikz_options, tikzpicture_start
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 209:64: -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:209:67: ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PICTURE, "IM_PICTURE"), root_1);

            	    adaptor.AddChild(root_1, stream_tikzpicture_start.NextTree());
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:209:98: ( tikz_options )?
            	    if ( stream_tikz_options.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikz_options.NextTree());

            	    }
            	    stream_tikz_options.Reset();
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:209:112: ( tikzbody )?
            	    if ( stream_tikzbody.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzbody.NextTree());

            	    }
            	    stream_tikzbody.Reset();
            	    adaptor.AddChild(root_1, stream_tikzpicture_end.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:212:1: tikzbody : ( tikzscope | tikzpath | tikznode_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )* ;
    public simpletikzParser.tikzbody_return tikzbody() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzbody_return retval = new simpletikzParser.tikzbody_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_return tikzscope65 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath66 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznode_ext_return tikznode_ext67 = default(simpletikzParser.tikznode_ext_return);

        simpletikzParser.tikz_set_return tikz_set68 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style69 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin70 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend71 = default(simpletikzParser.otherend_return);

        simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr72 = default(simpletikzParser.dontcare_body_nobr_return);

        simpletikzParser.tikzscope_return tikzscope73 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath74 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznode_ext_return tikznode_ext75 = default(simpletikzParser.tikznode_ext_return);

        simpletikzParser.tikz_set_return tikz_set76 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style77 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin78 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend79 = default(simpletikzParser.otherend_return);

        simpletikzParser.dontcare_body_return dontcare_body80 = default(simpletikzParser.dontcare_body_return);



        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:213:2: ( ( tikzscope | tikzpath | tikznode_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )* )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:213:4: ( tikzscope | tikzpath | tikznode_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:213:4: ( tikzscope | tikzpath | tikznode_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr )
            	int alt23 = 8;
            	alt23 = dfa23.Predict(input);
            	switch (alt23) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:213:6: tikzscope
            	        {
            	        	PushFollow(FOLLOW_tikzscope_in_tikzbody1031);
            	        	tikzscope65 = tikzscope();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzscope65.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:213:18: tikzpath
            	        {
            	        	PushFollow(FOLLOW_tikzpath_in_tikzbody1035);
            	        	tikzpath66 = tikzpath();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath66.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:213:29: tikznode_ext
            	        {
            	        	PushFollow(FOLLOW_tikznode_ext_in_tikzbody1039);
            	        	tikznode_ext67 = tikznode_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_ext67.Tree);

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:213:44: tikz_set
            	        {
            	        	PushFollow(FOLLOW_tikz_set_in_tikzbody1043);
            	        	tikz_set68 = tikz_set();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set68.Tree);

            	        }
            	        break;
            	    case 5 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:213:55: tikz_style
            	        {
            	        	PushFollow(FOLLOW_tikz_style_in_tikzbody1047);
            	        	tikz_style69 = tikz_style();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style69.Tree);

            	        }
            	        break;
            	    case 6 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:213:68: otherbegin
            	        {
            	        	PushFollow(FOLLOW_otherbegin_in_tikzbody1051);
            	        	otherbegin70 = otherbegin();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;
            	    case 7 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:213:82: otherend
            	        {
            	        	PushFollow(FOLLOW_otherend_in_tikzbody1056);
            	        	otherend71 = otherend();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;
            	    case 8 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:213:94: dontcare_body_nobr
            	        {
            	        	PushFollow(FOLLOW_dontcare_body_nobr_in_tikzbody1061);
            	        	dontcare_body_nobr72 = dontcare_body_nobr();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;

            	}

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:214:3: ( tikzscope | tikzpath | tikznode_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*
            	do 
            	{
            	    int alt24 = 9;
            	    alt24 = dfa24.Predict(input);
            	    switch (alt24) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:214:5: tikzscope
            			    {
            			    	PushFollow(FOLLOW_tikzscope_in_tikzbody1072);
            			    	tikzscope73 = tikzscope();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzscope73.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:214:17: tikzpath
            			    {
            			    	PushFollow(FOLLOW_tikzpath_in_tikzbody1076);
            			    	tikzpath74 = tikzpath();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath74.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:214:28: tikznode_ext
            			    {
            			    	PushFollow(FOLLOW_tikznode_ext_in_tikzbody1080);
            			    	tikznode_ext75 = tikznode_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_ext75.Tree);

            			    }
            			    break;
            			case 4 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:214:43: tikz_set
            			    {
            			    	PushFollow(FOLLOW_tikz_set_in_tikzbody1084);
            			    	tikz_set76 = tikz_set();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set76.Tree);

            			    }
            			    break;
            			case 5 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:214:54: tikz_style
            			    {
            			    	PushFollow(FOLLOW_tikz_style_in_tikzbody1088);
            			    	tikz_style77 = tikz_style();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style77.Tree);

            			    }
            			    break;
            			case 6 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:214:67: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzbody1092);
            			    	otherbegin78 = otherbegin();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;
            			case 7 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:214:81: otherend
            			    {
            			    	PushFollow(FOLLOW_otherend_in_tikzbody1097);
            			    	otherend79 = otherend();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;
            			case 8 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:214:93: dontcare_body
            			    {
            			    	PushFollow(FOLLOW_dontcare_body_in_tikzbody1102);
            			    	dontcare_body80 = dontcare_body();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop24;
            	    }
            	} while (true);

            	loop24:
            		;	// Stops C# compiler whining that label 'loop24' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:217:1: dontcare_body_nobr : (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | CLIP | TIKZSTYLE | TIKZSET | LBR ) ) ;
    public simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body_nobr_return retval = new simpletikzParser.dontcare_body_nobr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set81 = null;

        object set81_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:218:2: ( (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | CLIP | TIKZSTYLE | TIKZSET | LBR ) ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:218:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | CLIP | TIKZSTYLE | TIKZSET | LBR ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:218:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | CLIP | TIKZSTYLE | TIKZSET | LBR ) )
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:218:5: ~ ( BEGIN | END | NODE | DRAW | PATH | FILL | CLIP | TIKZSTYLE | TIKZSET | LBR )
            	{
            		set81 = (IToken)input.LT(1);
            		if ( input.LA(1) == USETIKZLIB || (input.LA(1) >= STYLETAG && input.LA(1) <= RPAR) || (input.LA(1) >= RBR && input.LA(1) <= 75) ) 
            		{
            		    input.Consume();
            		    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set81));
            		    state.errorRecovery = false;state.failed = false;
            		}
            		else 
            		{
            		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		    MismatchedSetException mse = new MismatchedSetException(null,input);
            		    throw mse;
            		}


            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:220:1: dontcare_body : (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | CLIP | TIKZSTYLE | TIKZSET ) ) ;
    public simpletikzParser.dontcare_body_return dontcare_body() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body_return retval = new simpletikzParser.dontcare_body_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set82 = null;

        object set82_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:221:2: ( (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | CLIP | TIKZSTYLE | TIKZSET ) ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:221:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | CLIP | TIKZSTYLE | TIKZSET ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:221:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | CLIP | TIKZSTYLE | TIKZSET ) )
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:221:5: ~ ( BEGIN | END | NODE | DRAW | PATH | FILL | CLIP | TIKZSTYLE | TIKZSET )
            	{
            		set82 = (IToken)input.LT(1);
            		if ( input.LA(1) == USETIKZLIB || (input.LA(1) >= STYLETAG && input.LA(1) <= 75) ) 
            		{
            		    input.Consume();
            		    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set82));
            		    state.errorRecovery = false;state.failed = false;
            		}
            		else 
            		{
            		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		    MismatchedSetException mse = new MismatchedSetException(null,input);
            		    throw mse;
            		}


            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:223:1: otherend : END '{' idd2 '}' ;
    public simpletikzParser.otherend_return otherend() // throws RecognitionException [1]
    {   
        simpletikzParser.otherend_return retval = new simpletikzParser.otherend_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken END83 = null;
        IToken char_literal84 = null;
        IToken char_literal86 = null;
        simpletikzParser.idd2_return idd285 = default(simpletikzParser.idd2_return);


        object END83_tree=null;
        object char_literal84_tree=null;
        object char_literal86_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:224:2: ( END '{' idd2 '}' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:224:4: END '{' idd2 '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	END83=(IToken)Match(input,END,FOLLOW_END_in_otherend1224); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{END83_tree = (object)adaptor.Create(END83);
            		adaptor.AddChild(root_0, END83_tree);
            	}
            	char_literal84=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_otherend1226); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal84_tree = (object)adaptor.Create(char_literal84);
            		adaptor.AddChild(root_0, char_literal84_tree);
            	}
            	PushFollow(FOLLOW_idd2_in_otherend1228);
            	idd285 = idd2();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idd285.Tree);
            	char_literal86=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_otherend1230); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal86_tree = (object)adaptor.Create(char_literal86);
            		adaptor.AddChild(root_0, char_literal86_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
            }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "otherend"

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:238:1: tikzscope : tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end ) ;
    public simpletikzParser.tikzscope_return tikzscope() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_return retval = new simpletikzParser.tikzscope_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_start_return tikzscope_start87 = default(simpletikzParser.tikzscope_start_return);

        simpletikzParser.tikz_options_return tikz_options88 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody_return tikzbody89 = default(simpletikzParser.tikzbody_return);

        simpletikzParser.tikzscope_end_return tikzscope_end90 = default(simpletikzParser.tikzscope_end_return);


        RewriteRuleSubtreeStream stream_tikzscope_start = new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_start");
        RewriteRuleSubtreeStream stream_tikzscope_end = new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_end");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:239:2: ( tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:239:4: tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end
            {
            	PushFollow(FOLLOW_tikzscope_start_in_tikzscope1257);
            	tikzscope_start87 = tikzscope_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzscope_start.Add(tikzscope_start87.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:239:20: ( tikz_options )?
            	int alt25 = 2;
            	int LA25_0 = input.LA(1);

            	if ( (LA25_0 == LBR) )
            	{
            	    alt25 = 1;
            	}
            	switch (alt25) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:239:20: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_tikzscope1259);
            	        	tikz_options88 = tikz_options();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_tikz_options.Add(tikz_options88.Tree);

            	        }
            	        break;

            	}

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:239:34: ( tikzbody )?
            	int alt26 = 2;
            	int LA26_0 = input.LA(1);

            	if ( (LA26_0 == BEGIN || (LA26_0 >= USETIKZLIB && LA26_0 <= RPAR) || (LA26_0 >= RBR && LA26_0 <= 75)) )
            	{
            	    alt26 = 1;
            	}
            	else if ( (LA26_0 == END) )
            	{
            	    int LA26_2 = input.LA(2);

            	    if ( (LA26_2 == LBRR) )
            	    {
            	        int LA26_3 = input.LA(3);

            	        if ( (LA26_3 == ID) )
            	        {
            	            alt26 = 1;
            	        }
            	    }
            	}
            	switch (alt26) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:239:34: tikzbody
            	        {
            	        	PushFollow(FOLLOW_tikzbody_in_tikzscope1262);
            	        	tikzbody89 = tikzbody();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_tikzbody.Add(tikzbody89.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzscope_end_in_tikzscope1265);
            	tikzscope_end90 = tikzscope_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzscope_end.Add(tikzscope_end90.Tree);


            	// AST REWRITE
            	// elements:          tikzscope_end, tikzbody, tikz_options, tikzscope_start
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 239:59: -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:239:62: ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_SCOPE, "IM_SCOPE"), root_1);

            	    adaptor.AddChild(root_1, stream_tikzscope_start.NextTree());
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:239:89: ( tikz_options )?
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

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
            }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tikzscope"

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:265:1: tikzpath : path_start ( tikzpath_element )* semicolon_end -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikzpath_return tikzpath() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_return retval = new simpletikzParser.tikzpath_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.path_start_return path_start91 = default(simpletikzParser.path_start_return);

        simpletikzParser.tikzpath_element_return tikzpath_element92 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end93 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_path_start = new RewriteRuleSubtreeStream(adaptor,"rule path_start");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:266:2: ( path_start ( tikzpath_element )* semicolon_end -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:266:4: path_start ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_path_start_in_tikzpath1320);
            	path_start91 = path_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_path_start.Add(path_start91.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:266:15: ( tikzpath_element )*
            	do 
            	{
            	    int alt27 = 2;
            	    int LA27_0 = input.LA(1);

            	    if ( (LA27_0 == LPAR || LA27_0 == LBR || LA27_0 == LBRR || LA27_0 == ID || LA27_0 == 62 || (LA27_0 >= 64 && LA27_0 <= 66) || (LA27_0 >= 68 && LA27_0 <= 73)) )
            	    {
            	        alt27 = 1;
            	    }


            	    switch (alt27) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:266:15: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath1322);
            			    	tikzpath_element92 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element92.Tree);

            			    }
            			    break;

            			default:
            			    goto loop27;
            	    }
            	} while (true);

            	loop27:
            		;	// Stops C# compiler whining that label 'loop27' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikzpath1325);
            	semicolon_end93 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_semicolon_end.Add(semicolon_end93.Tree);


            	// AST REWRITE
            	// elements:          tikzpath_element, semicolon_end, path_start
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 266:47: -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:266:50: ^( IM_PATH path_start ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_path_start.NextTree());
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:266:71: ( tikzpath_element )*
            	    while ( stream_tikzpath_element.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzpath_element.NextTree());

            	    }
            	    stream_tikzpath_element.Reset();
            	    adaptor.AddChild(root_1, stream_semicolon_end.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
            }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tikzpath"

    public class tikzpath_element_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikzpath_element"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:269:1: tikzpath_element : ( tikz_options | coord | tikznode_int | circle | arc | roundbr_start ( tikzpath_element )* roundbr_end -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end ) | edgeop );
    public simpletikzParser.tikzpath_element_return tikzpath_element() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_element_return retval = new simpletikzParser.tikzpath_element_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikz_options_return tikz_options94 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.coord_return coord95 = default(simpletikzParser.coord_return);

        simpletikzParser.tikznode_int_return tikznode_int96 = default(simpletikzParser.tikznode_int_return);

        simpletikzParser.circle_return circle97 = default(simpletikzParser.circle_return);

        simpletikzParser.arc_return arc98 = default(simpletikzParser.arc_return);

        simpletikzParser.roundbr_start_return roundbr_start99 = default(simpletikzParser.roundbr_start_return);

        simpletikzParser.tikzpath_element_return tikzpath_element100 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.roundbr_end_return roundbr_end101 = default(simpletikzParser.roundbr_end_return);

        simpletikzParser.edgeop_return edgeop102 = default(simpletikzParser.edgeop_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_roundbr_start = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_start");
        RewriteRuleSubtreeStream stream_roundbr_end = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:270:2: ( tikz_options | coord | tikznode_int | circle | arc | roundbr_start ( tikzpath_element )* roundbr_end -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end ) | edgeop )
            int alt29 = 7;
            switch ( input.LA(1) ) 
            {
            case LBR:
            	{
                alt29 = 1;
                }
                break;
            case LPAR:
            case 72:
            case 73:
            	{
                alt29 = 2;
                }
                break;
            case 62:
            	{
                alt29 = 3;
                }
                break;
            case 64:
            case 65:
            	{
                alt29 = 4;
                }
                break;
            case 66:
            	{
                alt29 = 5;
                }
                break;
            case LBRR:
            	{
                alt29 = 6;
                }
                break;
            case ID:
            case 68:
            case 69:
            case 70:
            case 71:
            	{
                alt29 = 7;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d29s0 =
            	        new NoViableAltException("", 29, 0, input);

            	    throw nvae_d29s0;
            }

            switch (alt29) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:271:5: tikz_options
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_options_in_tikzpath_element1354);
                    	tikz_options94 = tikz_options();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_options94.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:272:5: coord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_coord_in_tikzpath_element1361);
                    	coord95 = coord();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, coord95.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:273:5: tikznode_int
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikznode_int_in_tikzpath_element1367);
                    	tikznode_int96 = tikznode_int();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_int96.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:274:5: circle
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_circle_in_tikzpath_element1373);
                    	circle97 = circle();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;

                    }
                    break;
                case 5 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:275:5: arc
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arc_in_tikzpath_element1380);
                    	arc98 = arc();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;

                    }
                    break;
                case 6 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:276:5: roundbr_start ( tikzpath_element )* roundbr_end
                    {
                    	PushFollow(FOLLOW_roundbr_start_in_tikzpath_element1387);
                    	roundbr_start99 = roundbr_start();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_roundbr_start.Add(roundbr_start99.Tree);
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:276:19: ( tikzpath_element )*
                    	do 
                    	{
                    	    int alt28 = 2;
                    	    int LA28_0 = input.LA(1);

                    	    if ( (LA28_0 == LPAR || LA28_0 == LBR || LA28_0 == LBRR || LA28_0 == ID || LA28_0 == 62 || (LA28_0 >= 64 && LA28_0 <= 66) || (LA28_0 >= 68 && LA28_0 <= 73)) )
                    	    {
                    	        alt28 = 1;
                    	    }


                    	    switch (alt28) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:276:19: tikzpath_element
                    			    {
                    			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath_element1389);
                    			    	tikzpath_element100 = tikzpath_element();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element100.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop28;
                    	    }
                    	} while (true);

                    	loop28:
                    		;	// Stops C# compiler whining that label 'loop28' has no statements

                    	PushFollow(FOLLOW_roundbr_end_in_tikzpath_element1392);
                    	roundbr_end101 = roundbr_end();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_roundbr_end.Add(roundbr_end101.Tree);


                    	// AST REWRITE
                    	// elements:          tikzpath_element, roundbr_end, roundbr_start
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 276:49: -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end )
                    	{
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:276:52: ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

                    	    adaptor.AddChild(root_1, stream_roundbr_start.NextTree());
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:276:76: ( tikzpath_element )*
                    	    while ( stream_tikzpath_element.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_tikzpath_element.NextTree());

                    	    }
                    	    stream_tikzpath_element.Reset();
                    	    adaptor.AddChild(root_1, stream_roundbr_end.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 7 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:277:5: edgeop
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_edgeop_in_tikzpath_element1411);
                    	edgeop102 = edgeop();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
            }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tikzpath_element"

    public class tikznode_ext_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikznode_ext"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:279:1: tikznode_ext : node_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikznode_ext_return tikznode_ext() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_ext_return retval = new simpletikzParser.tikznode_ext_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.node_start_return node_start103 = default(simpletikzParser.node_start_return);

        simpletikzParser.tikznode_core_return tikznode_core104 = default(simpletikzParser.tikznode_core_return);

        simpletikzParser.tikzpath_element_return tikzpath_element105 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end106 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_node_start = new RewriteRuleSubtreeStream(adaptor,"rule node_start");
        RewriteRuleSubtreeStream stream_tikznode_core = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_core");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:280:2: ( node_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:280:4: node_start tikznode_core ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_node_start_in_tikznode_ext1422);
            	node_start103 = node_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_node_start.Add(node_start103.Tree);
            	PushFollow(FOLLOW_tikznode_core_in_tikznode_ext1424);
            	tikznode_core104 = tikznode_core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_core.Add(tikznode_core104.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:280:29: ( tikzpath_element )*
            	do 
            	{
            	    int alt30 = 2;
            	    int LA30_0 = input.LA(1);

            	    if ( (LA30_0 == LPAR || LA30_0 == LBR || LA30_0 == LBRR || LA30_0 == ID || LA30_0 == 62 || (LA30_0 >= 64 && LA30_0 <= 66) || (LA30_0 >= 68 && LA30_0 <= 73)) )
            	    {
            	        alt30 = 1;
            	    }


            	    switch (alt30) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:280:29: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikznode_ext1426);
            			    	tikzpath_element105 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element105.Tree);

            			    }
            			    break;

            			default:
            			    goto loop30;
            	    }
            	} while (true);

            	loop30:
            		;	// Stops C# compiler whining that label 'loop30' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikznode_ext1429);
            	semicolon_end106 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_semicolon_end.Add(semicolon_end106.Tree);


            	// AST REWRITE
            	// elements:          semicolon_end, tikznode_core, tikzpath_element, node_start
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 280:61: -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:280:64: ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_node_start.NextTree());
            	    adaptor.AddChild(root_1, stream_tikznode_core.NextTree());
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:280:99: ( tikzpath_element )*
            	    while ( stream_tikzpath_element.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzpath_element.NextTree());

            	    }
            	    stream_tikzpath_element.Reset();
            	    adaptor.AddChild(root_1, stream_semicolon_end.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
            }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tikznode_ext"

    public class tikznode_int_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikznode_int"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:282:1: tikznode_int : 'node' tikznode_core ;
    public simpletikzParser.tikznode_int_return tikznode_int() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_int_return retval = new simpletikzParser.tikznode_int_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal107 = null;
        simpletikzParser.tikznode_core_return tikznode_core108 = default(simpletikzParser.tikznode_core_return);


        object string_literal107_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:283:2: ( 'node' tikznode_core )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:283:4: 'node' tikznode_core
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal107=(IToken)Match(input,62,FOLLOW_62_in_tikznode_int1454); if (state.failed) return retval;
            	PushFollow(FOLLOW_tikznode_core_in_tikznode_int1457);
            	tikznode_core108 = tikznode_core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_core108.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
            }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tikznode_int"

    public class tikznode_core_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikznode_core"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:285:1: tikznode_core : ( tikznode_decorator )* tikzstring -> ^( IM_NODE ( tikznode_decorator )* tikzstring ) ;
    public simpletikzParser.tikznode_core_return tikznode_core() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_core_return retval = new simpletikzParser.tikznode_core_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator109 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikzstring_return tikzstring110 = default(simpletikzParser.tikzstring_return);


        RewriteRuleSubtreeStream stream_tikzstring = new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:286:2: ( ( tikznode_decorator )* tikzstring -> ^( IM_NODE ( tikznode_decorator )* tikzstring ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:286:4: ( tikznode_decorator )* tikzstring
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:286:4: ( tikznode_decorator )*
            	do 
            	{
            	    int alt31 = 2;
            	    int LA31_0 = input.LA(1);

            	    if ( (LA31_0 == LPAR || LA31_0 == LBR || LA31_0 == 63) )
            	    {
            	        alt31 = 1;
            	    }


            	    switch (alt31) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:286:4: tikznode_decorator
            			    {
            			    	PushFollow(FOLLOW_tikznode_decorator_in_tikznode_core1467);
            			    	tikznode_decorator109 = tikznode_decorator();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator109.Tree);

            			    }
            			    break;

            			default:
            			    goto loop31;
            	    }
            	} while (true);

            	loop31:
            		;	// Stops C# compiler whining that label 'loop31' has no statements

            	PushFollow(FOLLOW_tikzstring_in_tikznode_core1470);
            	tikzstring110 = tikzstring();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzstring.Add(tikzstring110.Tree);


            	// AST REWRITE
            	// elements:          tikzstring, tikznode_decorator
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 286:36: -> ^( IM_NODE ( tikznode_decorator )* tikzstring )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:286:39: ^( IM_NODE ( tikznode_decorator )* tikzstring )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NODE, "IM_NODE"), root_1);

            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:286:49: ( tikznode_decorator )*
            	    while ( stream_tikznode_decorator.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikznode_decorator.NextTree());

            	    }
            	    stream_tikznode_decorator.Reset();
            	    adaptor.AddChild(root_1, stream_tikzstring.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
            }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tikznode_core"

    public class tikznode_decorator_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikznode_decorator"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:291:1: tikznode_decorator : ( nodename | 'at' coord | tikz_options_dontcare );
    public simpletikzParser.tikznode_decorator_return tikznode_decorator() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_decorator_return retval = new simpletikzParser.tikznode_decorator_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal112 = null;
        simpletikzParser.nodename_return nodename111 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_return coord113 = default(simpletikzParser.coord_return);

        simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare114 = default(simpletikzParser.tikz_options_dontcare_return);


        object string_literal112_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:292:2: ( nodename | 'at' coord | tikz_options_dontcare )
            int alt32 = 3;
            switch ( input.LA(1) ) 
            {
            case LPAR:
            	{
                alt32 = 1;
                }
                break;
            case 63:
            	{
                alt32 = 2;
                }
                break;
            case LBR:
            	{
                alt32 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d32s0 =
            	        new NoViableAltException("", 32, 0, input);

            	    throw nvae_d32s0;
            }

            switch (alt32) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:292:6: nodename
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_nodename_in_tikznode_decorator1497);
                    	nodename111 = nodename();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, nodename111.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:293:5: 'at' coord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal112=(IToken)Match(input,63,FOLLOW_63_in_tikznode_decorator1504); if (state.failed) return retval;
                    	PushFollow(FOLLOW_coord_in_tikznode_decorator1507);
                    	coord113 = coord();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, coord113.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:294:5: tikz_options_dontcare
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_options_dontcare_in_tikznode_decorator1513);
                    	tikz_options_dontcare114 = tikz_options_dontcare();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_options_dontcare114.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
            }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tikznode_decorator"

    public class tikz_options_dontcare_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikz_options_dontcare"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:296:1: tikz_options_dontcare : LBR ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* RBR -> ^( IM_OPTIONS ) ;
    public simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_options_dontcare_return retval = new simpletikzParser.tikz_options_dontcare_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LBR115 = null;
        IToken RBR119 = null;
        simpletikzParser.no_rlbracket_return no_rlbracket116 = default(simpletikzParser.no_rlbracket_return);

        simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare117 = default(simpletikzParser.tikz_options_dontcare_return);

        simpletikzParser.no_rlbracket_return no_rlbracket118 = default(simpletikzParser.no_rlbracket_return);


        object LBR115_tree=null;
        object RBR119_tree=null;
        RewriteRuleTokenStream stream_RBR = new RewriteRuleTokenStream(adaptor,"token RBR");
        RewriteRuleTokenStream stream_LBR = new RewriteRuleTokenStream(adaptor,"token LBR");
        RewriteRuleSubtreeStream stream_tikz_options_dontcare = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options_dontcare");
        RewriteRuleSubtreeStream stream_no_rlbracket = new RewriteRuleSubtreeStream(adaptor,"rule no_rlbracket");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:297:2: ( LBR ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* RBR -> ^( IM_OPTIONS ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:297:4: LBR ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* RBR
            {
            	LBR115=(IToken)Match(input,LBR,FOLLOW_LBR_in_tikz_options_dontcare1523); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LBR.Add(LBR115);

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:297:8: ( no_rlbracket )*
            	do 
            	{
            	    int alt33 = 2;
            	    int LA33_0 = input.LA(1);

            	    if ( ((LA33_0 >= BEGIN && LA33_0 <= RPAR) || (LA33_0 >= LBRR && LA33_0 <= 75)) )
            	    {
            	        alt33 = 1;
            	    }


            	    switch (alt33) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:297:8: no_rlbracket
            			    {
            			    	PushFollow(FOLLOW_no_rlbracket_in_tikz_options_dontcare1525);
            			    	no_rlbracket116 = no_rlbracket();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_no_rlbracket.Add(no_rlbracket116.Tree);

            			    }
            			    break;

            			default:
            			    goto loop33;
            	    }
            	} while (true);

            	loop33:
            		;	// Stops C# compiler whining that label 'loop33' has no statements

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:297:22: ( tikz_options_dontcare ( no_rlbracket )* )*
            	do 
            	{
            	    int alt35 = 2;
            	    int LA35_0 = input.LA(1);

            	    if ( (LA35_0 == LBR) )
            	    {
            	        alt35 = 1;
            	    }


            	    switch (alt35) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:297:23: tikz_options_dontcare ( no_rlbracket )*
            			    {
            			    	PushFollow(FOLLOW_tikz_options_dontcare_in_tikz_options_dontcare1529);
            			    	tikz_options_dontcare117 = tikz_options_dontcare();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikz_options_dontcare.Add(tikz_options_dontcare117.Tree);
            			    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:297:45: ( no_rlbracket )*
            			    	do 
            			    	{
            			    	    int alt34 = 2;
            			    	    int LA34_0 = input.LA(1);

            			    	    if ( ((LA34_0 >= BEGIN && LA34_0 <= RPAR) || (LA34_0 >= LBRR && LA34_0 <= 75)) )
            			    	    {
            			    	        alt34 = 1;
            			    	    }


            			    	    switch (alt34) 
            			    		{
            			    			case 1 :
            			    			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:297:45: no_rlbracket
            			    			    {
            			    			    	PushFollow(FOLLOW_no_rlbracket_in_tikz_options_dontcare1531);
            			    			    	no_rlbracket118 = no_rlbracket();
            			    			    	state.followingStackPointer--;
            			    			    	if (state.failed) return retval;
            			    			    	if ( (state.backtracking==0) ) stream_no_rlbracket.Add(no_rlbracket118.Tree);

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop34;
            			    	    }
            			    	} while (true);

            			    	loop34:
            			    		;	// Stops C# compiler whining that label 'loop34' has no statements


            			    }
            			    break;

            			default:
            			    goto loop35;
            	    }
            	} while (true);

            	loop35:
            		;	// Stops C# compiler whining that label 'loop35' has no statements

            	RBR119=(IToken)Match(input,RBR,FOLLOW_RBR_in_tikz_options_dontcare1536); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RBR.Add(RBR119);



            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 297:65: -> ^( IM_OPTIONS )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:297:68: ^( IM_OPTIONS )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTIONS, "IM_OPTIONS"), root_1);

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
            }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tikz_options_dontcare"

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:299:1: no_rlbracket : ~ ( LBR | RBR ) ;
    public simpletikzParser.no_rlbracket_return no_rlbracket() // throws RecognitionException [1]
    {   
        simpletikzParser.no_rlbracket_return retval = new simpletikzParser.no_rlbracket_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set120 = null;

        object set120_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:300:2: (~ ( LBR | RBR ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:300:4: ~ ( LBR | RBR )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set120 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= BEGIN && input.LA(1) <= RPAR) || (input.LA(1) >= LBRR && input.LA(1) <= 75) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set120));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
            }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "no_rlbracket"

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:302:1: nodename : LPAR idd RPAR -> ^( IM_NODENAME idd ) ;
    public simpletikzParser.nodename_return nodename() // throws RecognitionException [1]
    {   
        simpletikzParser.nodename_return retval = new simpletikzParser.nodename_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LPAR121 = null;
        IToken RPAR123 = null;
        simpletikzParser.idd_return idd122 = default(simpletikzParser.idd_return);


        object LPAR121_tree=null;
        object RPAR123_tree=null;
        RewriteRuleTokenStream stream_RPAR = new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR = new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:303:2: ( LPAR idd RPAR -> ^( IM_NODENAME idd ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:303:4: LPAR idd RPAR
            {
            	LPAR121=(IToken)Match(input,LPAR,FOLLOW_LPAR_in_nodename1571); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LPAR.Add(LPAR121);

            	PushFollow(FOLLOW_idd_in_nodename1573);
            	idd122 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idd.Add(idd122.Tree);
            	RPAR123=(IToken)Match(input,RPAR,FOLLOW_RPAR_in_nodename1575); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RPAR.Add(RPAR123);



            	// AST REWRITE
            	// elements:          idd
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 303:19: -> ^( IM_NODENAME idd )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:303:22: ^( IM_NODENAME idd )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NODENAME, "IM_NODENAME"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
            }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "nodename"

    public class circle_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "circle"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:309:1: circle : ( 'circle' | 'ellipse' ) ( ( size )=> size )? ->;
    public simpletikzParser.circle_return circle() // throws RecognitionException [1]
    {   
        simpletikzParser.circle_return retval = new simpletikzParser.circle_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal124 = null;
        IToken string_literal125 = null;
        simpletikzParser.size_return size126 = default(simpletikzParser.size_return);


        object string_literal124_tree=null;
        object string_literal125_tree=null;
        RewriteRuleTokenStream stream_64 = new RewriteRuleTokenStream(adaptor,"token 64");
        RewriteRuleTokenStream stream_65 = new RewriteRuleTokenStream(adaptor,"token 65");
        RewriteRuleSubtreeStream stream_size = new RewriteRuleSubtreeStream(adaptor,"rule size");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:310:2: ( ( 'circle' | 'ellipse' ) ( ( size )=> size )? ->)
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:310:4: ( 'circle' | 'ellipse' ) ( ( size )=> size )?
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:310:4: ( 'circle' | 'ellipse' )
            	int alt36 = 2;
            	int LA36_0 = input.LA(1);

            	if ( (LA36_0 == 64) )
            	{
            	    alt36 = 1;
            	}
            	else if ( (LA36_0 == 65) )
            	{
            	    alt36 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d36s0 =
            	        new NoViableAltException("", 36, 0, input);

            	    throw nvae_d36s0;
            	}
            	switch (alt36) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:310:5: 'circle'
            	        {
            	        	string_literal124=(IToken)Match(input,64,FOLLOW_64_in_circle1599); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_64.Add(string_literal124);


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:310:16: 'ellipse'
            	        {
            	        	string_literal125=(IToken)Match(input,65,FOLLOW_65_in_circle1603); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_65.Add(string_literal125);


            	        }
            	        break;

            	}

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:310:27: ( ( size )=> size )?
            	int alt37 = 2;
            	alt37 = dfa37.Predict(input);
            	switch (alt37) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:310:28: ( size )=> size
            	        {
            	        	PushFollow(FOLLOW_size_in_circle1612);
            	        	size126 = size();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_size.Add(size126.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 310:44: ->
            	{
            	    root_0 = null;
            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
            }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "circle"

    public class arc_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "arc"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:312:1: arc : 'arc' ( LPAR numberunit ':' numberunit ':' numberunit RPAR )? ->;
    public simpletikzParser.arc_return arc() // throws RecognitionException [1]
    {   
        simpletikzParser.arc_return retval = new simpletikzParser.arc_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal127 = null;
        IToken LPAR128 = null;
        IToken char_literal130 = null;
        IToken char_literal132 = null;
        IToken RPAR134 = null;
        simpletikzParser.numberunit_return numberunit129 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit131 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit133 = default(simpletikzParser.numberunit_return);


        object string_literal127_tree=null;
        object LPAR128_tree=null;
        object char_literal130_tree=null;
        object char_literal132_tree=null;
        object RPAR134_tree=null;
        RewriteRuleTokenStream stream_COLON = new RewriteRuleTokenStream(adaptor,"token COLON");
        RewriteRuleTokenStream stream_66 = new RewriteRuleTokenStream(adaptor,"token 66");
        RewriteRuleTokenStream stream_RPAR = new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR = new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:313:2: ( 'arc' ( LPAR numberunit ':' numberunit ':' numberunit RPAR )? ->)
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:313:4: 'arc' ( LPAR numberunit ':' numberunit ':' numberunit RPAR )?
            {
            	string_literal127=(IToken)Match(input,66,FOLLOW_66_in_arc1627); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_66.Add(string_literal127);

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:313:10: ( LPAR numberunit ':' numberunit ':' numberunit RPAR )?
            	int alt38 = 2;
            	int LA38_0 = input.LA(1);

            	if ( (LA38_0 == LPAR) )
            	{
            	    int LA38_1 = input.LA(2);

            	    if ( ((LA38_1 >= FLOAT_WO_EXP && LA38_1 <= INT)) )
            	    {
            	        int LA38_3 = input.LA(3);

            	        if ( ((LA38_3 >= 56 && LA38_3 <= 61)) )
            	        {
            	            int LA38_4 = input.LA(4);

            	            if ( (LA38_4 == COLON) )
            	            {
            	                int LA38_5 = input.LA(5);

            	                if ( ((LA38_5 >= FLOAT_WO_EXP && LA38_5 <= INT)) )
            	                {
            	                    int LA38_6 = input.LA(6);

            	                    if ( ((LA38_6 >= 56 && LA38_6 <= 61)) )
            	                    {
            	                        int LA38_7 = input.LA(7);

            	                        if ( (LA38_7 == COLON) )
            	                        {
            	                            alt38 = 1;
            	                        }
            	                    }
            	                    else if ( (LA38_6 == COLON) )
            	                    {
            	                        alt38 = 1;
            	                    }
            	                }
            	            }
            	        }
            	        else if ( (LA38_3 == COLON) )
            	        {
            	            int LA38_5 = input.LA(4);

            	            if ( ((LA38_5 >= FLOAT_WO_EXP && LA38_5 <= INT)) )
            	            {
            	                int LA38_6 = input.LA(5);

            	                if ( ((LA38_6 >= 56 && LA38_6 <= 61)) )
            	                {
            	                    int LA38_7 = input.LA(6);

            	                    if ( (LA38_7 == COLON) )
            	                    {
            	                        alt38 = 1;
            	                    }
            	                }
            	                else if ( (LA38_6 == COLON) )
            	                {
            	                    alt38 = 1;
            	                }
            	            }
            	        }
            	    }
            	}
            	switch (alt38) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:313:11: LPAR numberunit ':' numberunit ':' numberunit RPAR
            	        {
            	        	LPAR128=(IToken)Match(input,LPAR,FOLLOW_LPAR_in_arc1630); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_LPAR.Add(LPAR128);

            	        	PushFollow(FOLLOW_numberunit_in_arc1632);
            	        	numberunit129 = numberunit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit129.Tree);
            	        	char_literal130=(IToken)Match(input,COLON,FOLLOW_COLON_in_arc1634); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_COLON.Add(char_literal130);

            	        	PushFollow(FOLLOW_numberunit_in_arc1636);
            	        	numberunit131 = numberunit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit131.Tree);
            	        	char_literal132=(IToken)Match(input,COLON,FOLLOW_COLON_in_arc1638); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_COLON.Add(char_literal132);

            	        	PushFollow(FOLLOW_numberunit_in_arc1640);
            	        	numberunit133 = numberunit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit133.Tree);
            	        	RPAR134=(IToken)Match(input,RPAR,FOLLOW_RPAR_in_arc1642); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_RPAR.Add(RPAR134);


            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 313:64: ->
            	{
            	    root_0 = null;
            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
            }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "arc"

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:316:1: size : LPAR numberunit ( 'and' numberunit )? RPAR -> ^( IM_SIZE ( numberunit )* ) ;
    public simpletikzParser.size_return size() // throws RecognitionException [1]
    {   
        simpletikzParser.size_return retval = new simpletikzParser.size_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LPAR135 = null;
        IToken string_literal137 = null;
        IToken RPAR139 = null;
        simpletikzParser.numberunit_return numberunit136 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit138 = default(simpletikzParser.numberunit_return);


        object LPAR135_tree=null;
        object string_literal137_tree=null;
        object RPAR139_tree=null;
        RewriteRuleTokenStream stream_67 = new RewriteRuleTokenStream(adaptor,"token 67");
        RewriteRuleTokenStream stream_RPAR = new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR = new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:317:2: ( LPAR numberunit ( 'and' numberunit )? RPAR -> ^( IM_SIZE ( numberunit )* ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:317:6: LPAR numberunit ( 'and' numberunit )? RPAR
            {
            	LPAR135=(IToken)Match(input,LPAR,FOLLOW_LPAR_in_size1660); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LPAR.Add(LPAR135);

            	PushFollow(FOLLOW_numberunit_in_size1662);
            	numberunit136 = numberunit();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit136.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:317:22: ( 'and' numberunit )?
            	int alt39 = 2;
            	int LA39_0 = input.LA(1);

            	if ( (LA39_0 == 67) )
            	{
            	    alt39 = 1;
            	}
            	switch (alt39) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:317:23: 'and' numberunit
            	        {
            	        	string_literal137=(IToken)Match(input,67,FOLLOW_67_in_size1665); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_67.Add(string_literal137);

            	        	PushFollow(FOLLOW_numberunit_in_size1667);
            	        	numberunit138 = numberunit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit138.Tree);

            	        }
            	        break;

            	}

            	RPAR139=(IToken)Match(input,RPAR,FOLLOW_RPAR_in_size1671); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RPAR.Add(RPAR139);



            	// AST REWRITE
            	// elements:          numberunit
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 317:48: -> ^( IM_SIZE ( numberunit )* )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:317:51: ^( IM_SIZE ( numberunit )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_SIZE, "IM_SIZE"), root_1);

            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:317:61: ( numberunit )*
            	    while ( stream_numberunit.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_numberunit.NextTree());

            	    }
            	    stream_numberunit.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:323:1: coord : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? LPAR numberunit coord_sep numberunit RPAR ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) );
    public simpletikzParser.coord_return coord() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_return retval = new simpletikzParser.coord_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LPAR142 = null;
        IToken RPAR146 = null;
        simpletikzParser.nodename_return nodename140 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_modifier_return coord_modifier141 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.numberunit_return numberunit143 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_sep_return coord_sep144 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.numberunit_return numberunit145 = default(simpletikzParser.numberunit_return);


        object LPAR142_tree=null;
        object RPAR146_tree=null;
        RewriteRuleTokenStream stream_RPAR = new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR = new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_coord_sep = new RewriteRuleSubtreeStream(adaptor,"rule coord_sep");
        RewriteRuleSubtreeStream stream_nodename = new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        RewriteRuleSubtreeStream stream_coord_modifier = new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:324:2: ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? LPAR numberunit coord_sep numberunit RPAR ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) )
            int alt41 = 2;
            int LA41_0 = input.LA(1);

            if ( (LA41_0 == LPAR) )
            {
                int LA41_1 = input.LA(2);

                if ( ((LA41_1 >= FLOAT_WO_EXP && LA41_1 <= INT)) )
                {
                    switch ( input.LA(3) ) 
                    {
                    case 56:
                    case 57:
                    case 58:
                    case 59:
                    case 60:
                    case 61:
                    	{
                        int LA41_5 = input.LA(4);

                        if ( (LA41_5 == KOMMA || LA41_5 == COLON) )
                        {
                            alt41 = 2;
                        }
                        else if ( ((LA41_5 >= BEGIN && LA41_5 <= CLIP) || LA41_5 == RPAR || (LA41_5 >= IM_PATH && LA41_5 <= 75)) )
                        {
                            alt41 = 1;
                        }
                        else 
                        {
                            if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                            NoViableAltException nvae_d41s5 =
                                new NoViableAltException("", 41, 5, input);

                            throw nvae_d41s5;
                        }
                        }
                        break;
                    case KOMMA:
                    case COLON:
                    	{
                        alt41 = 2;
                        }
                        break;
                    case BEGIN:
                    case END:
                    case USETIKZLIB:
                    case TIKZSTYLE:
                    case TIKZSET:
                    case NODE:
                    case DRAW:
                    case PATH:
                    case FILL:
                    case CLIP:
                    case RPAR:
                    case IM_PATH:
                    case IM_NODE:
                    case IM_COORD:
                    case IM_SIZE:
                    case IM_NODENAME:
                    case IM_NUMBERUNIT:
                    case IM_PICTURE:
                    case IM_DOCUMENT:
                    case IM_SCOPE:
                    case IM_STARTTAG:
                    case IM_ENDTAG:
                    case IM_OPTIONS:
                    case IM_OPTION_STYLE:
                    case IM_OPTION_KV:
                    case IM_ID:
                    case IM_TIKZSET:
                    case IM_USETIKZLIB:
                    case IM_STRING:
                    case IM_STYLE:
                    case IM_TIKZEDT_CMD:
                    case TIKZEDT_CMD_COMMENT:
                    case ID:
                    case FLOAT_WO_EXP:
                    case INT:
                    case WS:
                    case COMMENT:
                    case EXPONENT:
                    case ESC_SEQ:
                    case MATHSTRING:
                    case COMMAND:
                    case SOMETHING:
                    case 62:
                    case 63:
                    case 64:
                    case 65:
                    case 66:
                    case 67:
                    case 68:
                    case 69:
                    case 70:
                    case 71:
                    case 72:
                    case 73:
                    case 74:
                    case 75:
                    	{
                        alt41 = 1;
                        }
                        break;
                    	default:
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    NoViableAltException nvae_d41s3 =
                    	        new NoViableAltException("", 41, 3, input);

                    	    throw nvae_d41s3;
                    }

                }
                else if ( ((LA41_1 >= BEGIN && LA41_1 <= CLIP) || (LA41_1 >= IM_PATH && LA41_1 <= ID) || (LA41_1 >= WS && LA41_1 <= 75)) )
                {
                    alt41 = 1;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d41s1 =
                        new NoViableAltException("", 41, 1, input);

                    throw nvae_d41s1;
                }
            }
            else if ( ((LA41_0 >= 72 && LA41_0 <= 73)) )
            {
                alt41 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d41s0 =
                    new NoViableAltException("", 41, 0, input);

                throw nvae_d41s0;
            }
            switch (alt41) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:324:6: nodename
                    {
                    	PushFollow(FOLLOW_nodename_in_coord1701);
                    	nodename140 = nodename();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_nodename.Add(nodename140.Tree);


                    	// AST REWRITE
                    	// elements:          nodename
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 324:23: -> ^( IM_COORD nodename )
                    	{
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:324:26: ^( IM_COORD nodename )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    adaptor.AddChild(root_1, stream_nodename.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:325:5: ( ( coord_modifier )? LPAR numberunit coord_sep numberunit RPAR )
                    {
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:325:5: ( ( coord_modifier )? LPAR numberunit coord_sep numberunit RPAR )
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:325:7: ( coord_modifier )? LPAR numberunit coord_sep numberunit RPAR
                    	{
                    		// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:325:7: ( coord_modifier )?
                    		int alt40 = 2;
                    		int LA40_0 = input.LA(1);

                    		if ( ((LA40_0 >= 72 && LA40_0 <= 73)) )
                    		{
                    		    alt40 = 1;
                    		}
                    		switch (alt40) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:325:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord1725);
                    		        	coord_modifier141 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_coord_modifier.Add(coord_modifier141.Tree);

                    		        }
                    		        break;

                    		}

                    		LPAR142=(IToken)Match(input,LPAR,FOLLOW_LPAR_in_coord1728); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_LPAR.Add(LPAR142);

                    		PushFollow(FOLLOW_numberunit_in_coord1730);
                    		numberunit143 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit143.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord1732);
                    		coord_sep144 = coord_sep();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_sep.Add(coord_sep144.Tree);
                    		PushFollow(FOLLOW_numberunit_in_coord1734);
                    		numberunit145 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit145.Tree);
                    		RPAR146=(IToken)Match(input,RPAR,FOLLOW_RPAR_in_coord1736); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_RPAR.Add(RPAR146);


                    	}



                    	// AST REWRITE
                    	// elements:          coord_modifier, coord_sep, numberunit
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 325:67: -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep )
                    	{
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:325:70: ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:325:81: ( coord_modifier )?
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

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:327:1: coord_sep : ( ',' | ':' ) ;
    public simpletikzParser.coord_sep_return coord_sep() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_sep_return retval = new simpletikzParser.coord_sep_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set147 = null;

        object set147_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:328:2: ( ( ',' | ':' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:328:4: ( ',' | ':' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set147 = (IToken)input.LT(1);
            	if ( input.LA(1) == KOMMA || input.LA(1) == COLON ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set147));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
            }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "coord_sep"

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:332:1: edgeop : ( '--' | '->' | '|-' | '-|' | ID );
    public simpletikzParser.edgeop_return edgeop() // throws RecognitionException [1]
    {   
        simpletikzParser.edgeop_return retval = new simpletikzParser.edgeop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set148 = null;

        object set148_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:333:2: ( '--' | '->' | '|-' | '-|' | ID )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set148 = (IToken)input.LT(1);
            	if ( input.LA(1) == ID || (input.LA(1) >= 68 && input.LA(1) <= 71) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set148));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:337:1: coord_modifier : ( '+' | '++' );
    public simpletikzParser.coord_modifier_return coord_modifier() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_modifier_return retval = new simpletikzParser.coord_modifier_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set149 = null;

        object set149_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:338:2: ( '+' | '++' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set149 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 72 && input.LA(1) <= 73) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set149));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
            }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "coord_modifier"

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:380:1: squarebr_start : LBR -> ^( IM_STARTTAG LBR ) ;
    public simpletikzParser.squarebr_start_return squarebr_start() // throws RecognitionException [1]
    {   
        simpletikzParser.squarebr_start_return retval = new simpletikzParser.squarebr_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LBR150 = null;

        object LBR150_tree=null;
        RewriteRuleTokenStream stream_LBR = new RewriteRuleTokenStream(adaptor,"token LBR");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:381:2: ( LBR -> ^( IM_STARTTAG LBR ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:381:4: LBR
            {
            	LBR150=(IToken)Match(input,LBR,FOLLOW_LBR_in_squarebr_start1836); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LBR.Add(LBR150);



            	// AST REWRITE
            	// elements:          LBR
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 381:8: -> ^( IM_STARTTAG LBR )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:381:11: ^( IM_STARTTAG LBR )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_LBR.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:383:1: squarebr_end : RBR -> ^( IM_ENDTAG RBR ) ;
    public simpletikzParser.squarebr_end_return squarebr_end() // throws RecognitionException [1]
    {   
        simpletikzParser.squarebr_end_return retval = new simpletikzParser.squarebr_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken RBR151 = null;

        object RBR151_tree=null;
        RewriteRuleTokenStream stream_RBR = new RewriteRuleTokenStream(adaptor,"token RBR");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:384:2: ( RBR -> ^( IM_ENDTAG RBR ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:384:4: RBR
            {
            	RBR151=(IToken)Match(input,RBR,FOLLOW_RBR_in_squarebr_end1854); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RBR.Add(RBR151);



            	// AST REWRITE
            	// elements:          RBR
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 384:8: -> ^( IM_ENDTAG RBR )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:384:11: ^( IM_ENDTAG RBR )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_RBR.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:386:1: semicolon_end : ';' -> ^( IM_ENDTAG ';' ) ;
    public simpletikzParser.semicolon_end_return semicolon_end() // throws RecognitionException [1]
    {   
        simpletikzParser.semicolon_end_return retval = new simpletikzParser.semicolon_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal152 = null;

        object char_literal152_tree=null;
        RewriteRuleTokenStream stream_SEMIC = new RewriteRuleTokenStream(adaptor,"token SEMIC");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:387:2: ( ';' -> ^( IM_ENDTAG ';' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:387:4: ';'
            {
            	char_literal152=(IToken)Match(input,SEMIC,FOLLOW_SEMIC_in_semicolon_end1873); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_SEMIC.Add(char_literal152);



            	// AST REWRITE
            	// elements:          SEMIC
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 387:8: -> ^( IM_ENDTAG ';' )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:387:11: ^( IM_ENDTAG ';' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_SEMIC.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
            }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "semicolon_end"

    public class roundbr_start_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "roundbr_start"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:389:1: roundbr_start : '{' -> ^( IM_STARTTAG '{' ) ;
    public simpletikzParser.roundbr_start_return roundbr_start() // throws RecognitionException [1]
    {   
        simpletikzParser.roundbr_start_return retval = new simpletikzParser.roundbr_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal153 = null;

        object char_literal153_tree=null;
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:390:2: ( '{' -> ^( IM_STARTTAG '{' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:390:4: '{'
            {
            	char_literal153=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_roundbr_start1891); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LBRR.Add(char_literal153);



            	// AST REWRITE
            	// elements:          LBRR
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 390:8: -> ^( IM_STARTTAG '{' )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:390:11: ^( IM_STARTTAG '{' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_LBRR.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
            }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "roundbr_start"

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:392:1: roundbr_end : '}' -> ^( IM_ENDTAG '}' ) ;
    public simpletikzParser.roundbr_end_return roundbr_end() // throws RecognitionException [1]
    {   
        simpletikzParser.roundbr_end_return retval = new simpletikzParser.roundbr_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal154 = null;

        object char_literal154_tree=null;
        RewriteRuleTokenStream stream_RBRR = new RewriteRuleTokenStream(adaptor,"token RBRR");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:393:2: ( '}' -> ^( IM_ENDTAG '}' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:393:4: '}'
            {
            	char_literal154=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_roundbr_end1909); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RBRR.Add(char_literal154);



            	// AST REWRITE
            	// elements:          RBRR
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 393:8: -> ^( IM_ENDTAG '}' )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:393:11: ^( IM_ENDTAG '}' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_RBRR.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:395:1: tikz_set_start : TIKZSET '{' -> ^( IM_STARTTAG ) ;
    public simpletikzParser.tikz_set_start_return tikz_set_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_set_start_return retval = new simpletikzParser.tikz_set_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken TIKZSET155 = null;
        IToken char_literal156 = null;

        object TIKZSET155_tree=null;
        object char_literal156_tree=null;
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_TIKZSET = new RewriteRuleTokenStream(adaptor,"token TIKZSET");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:396:2: ( TIKZSET '{' -> ^( IM_STARTTAG ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:396:4: TIKZSET '{'
            {
            	TIKZSET155=(IToken)Match(input,TIKZSET,FOLLOW_TIKZSET_in_tikz_set_start1927); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_TIKZSET.Add(TIKZSET155);

            	char_literal156=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_tikz_set_start1929); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LBRR.Add(char_literal156);



            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 396:17: -> ^( IM_STARTTAG )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:396:20: ^( IM_STARTTAG )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:398:1: tikzpicture_start : BEGIN '{' 'tikzpicture' '}' -> ^( IM_STARTTAG BEGIN ) ;
    public simpletikzParser.tikzpicture_start_return tikzpicture_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_start_return retval = new simpletikzParser.tikzpicture_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken BEGIN157 = null;
        IToken char_literal158 = null;
        IToken string_literal159 = null;
        IToken char_literal160 = null;

        object BEGIN157_tree=null;
        object char_literal158_tree=null;
        object string_literal159_tree=null;
        object char_literal160_tree=null;
        RewriteRuleTokenStream stream_RBRR = new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_BEGIN = new RewriteRuleTokenStream(adaptor,"token BEGIN");
        RewriteRuleTokenStream stream_74 = new RewriteRuleTokenStream(adaptor,"token 74");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:399:2: ( BEGIN '{' 'tikzpicture' '}' -> ^( IM_STARTTAG BEGIN ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:399:4: BEGIN '{' 'tikzpicture' '}'
            {
            	BEGIN157=(IToken)Match(input,BEGIN,FOLLOW_BEGIN_in_tikzpicture_start1948); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_BEGIN.Add(BEGIN157);

            	char_literal158=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_tikzpicture_start1950); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LBRR.Add(char_literal158);

            	string_literal159=(IToken)Match(input,74,FOLLOW_74_in_tikzpicture_start1952); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_74.Add(string_literal159);

            	char_literal160=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_tikzpicture_start1954); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RBRR.Add(char_literal160);



            	// AST REWRITE
            	// elements:          BEGIN
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 399:32: -> ^( IM_STARTTAG BEGIN )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:399:35: ^( IM_STARTTAG BEGIN )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_BEGIN.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:401:1: tikzpicture_end : END '{' 'tikzpicture' '}' -> ^( IM_ENDTAG END ) ;
    public simpletikzParser.tikzpicture_end_return tikzpicture_end() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_end_return retval = new simpletikzParser.tikzpicture_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken END161 = null;
        IToken char_literal162 = null;
        IToken string_literal163 = null;
        IToken char_literal164 = null;

        object END161_tree=null;
        object char_literal162_tree=null;
        object string_literal163_tree=null;
        object char_literal164_tree=null;
        RewriteRuleTokenStream stream_RBRR = new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_END = new RewriteRuleTokenStream(adaptor,"token END");
        RewriteRuleTokenStream stream_74 = new RewriteRuleTokenStream(adaptor,"token 74");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:402:2: ( END '{' 'tikzpicture' '}' -> ^( IM_ENDTAG END ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:402:4: END '{' 'tikzpicture' '}'
            {
            	END161=(IToken)Match(input,END,FOLLOW_END_in_tikzpicture_end1972); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_END.Add(END161);

            	char_literal162=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_tikzpicture_end1974); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LBRR.Add(char_literal162);

            	string_literal163=(IToken)Match(input,74,FOLLOW_74_in_tikzpicture_end1976); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_74.Add(string_literal163);

            	char_literal164=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_tikzpicture_end1978); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RBRR.Add(char_literal164);



            	// AST REWRITE
            	// elements:          END
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 402:30: -> ^( IM_ENDTAG END )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:402:33: ^( IM_ENDTAG END )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_END.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:404:1: tikzscope_start : BEGIN '{' 'scope' '}' -> ^( IM_STARTTAG BEGIN ) ;
    public simpletikzParser.tikzscope_start_return tikzscope_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_start_return retval = new simpletikzParser.tikzscope_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken BEGIN165 = null;
        IToken char_literal166 = null;
        IToken string_literal167 = null;
        IToken char_literal168 = null;

        object BEGIN165_tree=null;
        object char_literal166_tree=null;
        object string_literal167_tree=null;
        object char_literal168_tree=null;
        RewriteRuleTokenStream stream_RBRR = new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_BEGIN = new RewriteRuleTokenStream(adaptor,"token BEGIN");
        RewriteRuleTokenStream stream_75 = new RewriteRuleTokenStream(adaptor,"token 75");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:405:2: ( BEGIN '{' 'scope' '}' -> ^( IM_STARTTAG BEGIN ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:405:4: BEGIN '{' 'scope' '}'
            {
            	BEGIN165=(IToken)Match(input,BEGIN,FOLLOW_BEGIN_in_tikzscope_start1996); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_BEGIN.Add(BEGIN165);

            	char_literal166=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_tikzscope_start1998); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LBRR.Add(char_literal166);

            	string_literal167=(IToken)Match(input,75,FOLLOW_75_in_tikzscope_start2000); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_75.Add(string_literal167);

            	char_literal168=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_tikzscope_start2002); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RBRR.Add(char_literal168);



            	// AST REWRITE
            	// elements:          BEGIN
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 405:26: -> ^( IM_STARTTAG BEGIN )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:405:29: ^( IM_STARTTAG BEGIN )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_BEGIN.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:407:1: tikzscope_end : END '{' 'scope' '}' -> ^( IM_ENDTAG END ) ;
    public simpletikzParser.tikzscope_end_return tikzscope_end() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_end_return retval = new simpletikzParser.tikzscope_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken END169 = null;
        IToken char_literal170 = null;
        IToken string_literal171 = null;
        IToken char_literal172 = null;

        object END169_tree=null;
        object char_literal170_tree=null;
        object string_literal171_tree=null;
        object char_literal172_tree=null;
        RewriteRuleTokenStream stream_RBRR = new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_END = new RewriteRuleTokenStream(adaptor,"token END");
        RewriteRuleTokenStream stream_75 = new RewriteRuleTokenStream(adaptor,"token 75");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:408:2: ( END '{' 'scope' '}' -> ^( IM_ENDTAG END ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:408:4: END '{' 'scope' '}'
            {
            	END169=(IToken)Match(input,END,FOLLOW_END_in_tikzscope_end2020); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_END.Add(END169);

            	char_literal170=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_tikzscope_end2022); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LBRR.Add(char_literal170);

            	string_literal171=(IToken)Match(input,75,FOLLOW_75_in_tikzscope_end2024); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_75.Add(string_literal171);

            	char_literal172=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_tikzscope_end2026); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RBRR.Add(char_literal172);



            	// AST REWRITE
            	// elements:          END
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 408:24: -> ^( IM_ENDTAG END )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:408:27: ^( IM_ENDTAG END )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_END.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:410:1: path_start : path_start_tag -> ^( IM_STARTTAG path_start_tag ) ;
    public simpletikzParser.path_start_return path_start() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_return retval = new simpletikzParser.path_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.path_start_tag_return path_start_tag173 = default(simpletikzParser.path_start_tag_return);


        RewriteRuleSubtreeStream stream_path_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule path_start_tag");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:411:2: ( path_start_tag -> ^( IM_STARTTAG path_start_tag ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:411:4: path_start_tag
            {
            	PushFollow(FOLLOW_path_start_tag_in_path_start2045);
            	path_start_tag173 = path_start_tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_path_start_tag.Add(path_start_tag173.Tree);


            	// AST REWRITE
            	// elements:          path_start_tag
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 411:19: -> ^( IM_STARTTAG path_start_tag )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:411:22: ^( IM_STARTTAG path_start_tag )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_path_start_tag.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
            }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "path_start"

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:413:1: node_start : NODE -> ^( IM_STARTTAG NODE ) ;
    public simpletikzParser.node_start_return node_start() // throws RecognitionException [1]
    {   
        simpletikzParser.node_start_return retval = new simpletikzParser.node_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NODE174 = null;

        object NODE174_tree=null;
        RewriteRuleTokenStream stream_NODE = new RewriteRuleTokenStream(adaptor,"token NODE");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:414:2: ( NODE -> ^( IM_STARTTAG NODE ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:414:4: NODE
            {
            	NODE174=(IToken)Match(input,NODE,FOLLOW_NODE_in_node_start2063); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_NODE.Add(NODE174);



            	// AST REWRITE
            	// elements:          NODE
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 414:9: -> ^( IM_STARTTAG NODE )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:414:12: ^( IM_STARTTAG NODE )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_NODE.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
            }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "node_start"

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:416:1: path_start_tag : ( DRAW | FILL | PATH | CLIP );
    public simpletikzParser.path_start_tag_return path_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_tag_return retval = new simpletikzParser.path_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set175 = null;

        object set175_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:417:2: ( DRAW | FILL | PATH | CLIP )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set175 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= DRAW && input.LA(1) <= CLIP) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set175));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

            catch (RecognitionException e) {
                throw e;
            }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "path_start_tag"

    // $ANTLR start "synpred1_simpletikz"
    public void synpred1_simpletikz_fragment() {
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:310:28: ( size )
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:310:29: size
        {
        	PushFollow(FOLLOW_size_in_synpred1_simpletikz1608);
        	size();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred1_simpletikz"

    // Delegated rules

   	public bool synpred1_simpletikz() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred1_simpletikz_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}


   	protected DFA7 dfa7;
   	protected DFA23 dfa23;
   	protected DFA24 dfa24;
   	protected DFA37 dfa37;
	private void InitializeCyclicDFAs()
	{
    	this.dfa7 = new DFA7(this);
    	this.dfa23 = new DFA23(this);
    	this.dfa24 = new DFA24(this);
    	this.dfa37 = new DFA37(this);
	    this.dfa37.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA37_SpecialStateTransition);
	}

    const string DFA7_eotS =
        "\x04\uffff";
    const string DFA7_eofS =
        "\x04\uffff";
    const string DFA7_minS =
        "\x02\x04\x02\uffff";
    const string DFA7_maxS =
        "\x02\x4b\x02\uffff";
    const string DFA7_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA7_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA7_transitionS = {
            "\x0a\x01\x0b\uffff\x33\x01",
            "\x0a\x01\x01\x03\x03\uffff\x01\x02\x01\uffff\x03\x02\x02\uffff"+
            "\x33\x01",
            "",
            ""
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
            get { return "147:1: option : ( option_style | option_kv );"; }
        }

    }

    const string DFA23_eotS =
        "\x0b\uffff";
    const string DFA23_eofS =
        "\x0b\uffff";
    const string DFA23_minS =
        "\x01\x04\x01\x13\x06\uffff\x01\x2e\x02\uffff";
    const string DFA23_maxS =
        "\x01\x4b\x01\x13\x06\uffff\x01\x4b\x02\uffff";
    const string DFA23_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x07\x01\x08\x01"+
        "\uffff\x01\x01\x01\x06";
    const string DFA23_specialS =
        "\x0b\uffff}>";
    static readonly string[] DFA23_transitionS = {
            "\x01\x01\x01\x06\x01\x07\x01\x05\x01\x04\x01\x03\x04\x02\x03"+
            "\x07\x01\uffff\x3a\x07",
            "\x01\x08",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0a\x1c\uffff\x01\x09",
            "",
            ""
    };

    static readonly short[] DFA23_eot = DFA.UnpackEncodedString(DFA23_eotS);
    static readonly short[] DFA23_eof = DFA.UnpackEncodedString(DFA23_eofS);
    static readonly char[] DFA23_min = DFA.UnpackEncodedStringToUnsignedChars(DFA23_minS);
    static readonly char[] DFA23_max = DFA.UnpackEncodedStringToUnsignedChars(DFA23_maxS);
    static readonly short[] DFA23_accept = DFA.UnpackEncodedString(DFA23_acceptS);
    static readonly short[] DFA23_special = DFA.UnpackEncodedString(DFA23_specialS);
    static readonly short[][] DFA23_transition = DFA.UnpackEncodedStringArray(DFA23_transitionS);

    protected class DFA23 : DFA
    {
        public DFA23(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 23;
            this.eot = DFA23_eot;
            this.eof = DFA23_eof;
            this.min = DFA23_min;
            this.max = DFA23_max;
            this.accept = DFA23_accept;
            this.special = DFA23_special;
            this.transition = DFA23_transition;

        }

        override public string Description
        {
            get { return "213:4: ( tikzscope | tikzpath | tikznode_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr )"; }
        }

    }

    const string DFA24_eotS =
        "\x0e\uffff";
    const string DFA24_eofS =
        "\x0e\uffff";
    const string DFA24_minS =
        "\x01\x04\x02\x13\x05\uffff\x02\x2e\x04\uffff";
    const string DFA24_maxS =
        "\x01\x4b\x02\x13\x05\uffff\x02\x4b\x04\uffff";
    const string DFA24_acceptS =
        "\x03\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x08\x02\uffff\x01"+
        "\x09\x01\x07\x01\x01\x01\x06";
    const string DFA24_specialS =
        "\x0e\uffff}>";
    static readonly string[] DFA24_transitionS = {
            "\x01\x02\x01\x01\x01\x07\x01\x06\x01\x05\x01\x04\x04\x03\x3e"+
            "\x07",
            "\x01\x08",
            "\x01\x09",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0b\x1b\uffff\x02\x0a",
            "\x01\x0d\x1c\uffff\x01\x0c",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA24_eot = DFA.UnpackEncodedString(DFA24_eotS);
    static readonly short[] DFA24_eof = DFA.UnpackEncodedString(DFA24_eofS);
    static readonly char[] DFA24_min = DFA.UnpackEncodedStringToUnsignedChars(DFA24_minS);
    static readonly char[] DFA24_max = DFA.UnpackEncodedStringToUnsignedChars(DFA24_maxS);
    static readonly short[] DFA24_accept = DFA.UnpackEncodedString(DFA24_acceptS);
    static readonly short[] DFA24_special = DFA.UnpackEncodedString(DFA24_specialS);
    static readonly short[][] DFA24_transition = DFA.UnpackEncodedStringArray(DFA24_transitionS);

    protected class DFA24 : DFA
    {
        public DFA24(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 24;
            this.eot = DFA24_eot;
            this.eof = DFA24_eof;
            this.min = DFA24_min;
            this.max = DFA24_max;
            this.accept = DFA24_accept;
            this.special = DFA24_special;
            this.transition = DFA24_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 214:3: ( tikzscope | tikzpath | tikznode_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*"; }
        }

    }

    const string DFA37_eotS =
        "\x0a\uffff";
    const string DFA37_eofS =
        "\x0a\uffff";
    const string DFA37_minS =
        "\x01\x0f\x01\x04\x01\uffff\x01\x04\x01\x00\x02\x04\x01\uffff\x02"+
        "\x04";
    const string DFA37_maxS =
        "\x01\x49\x01\x4b\x01\uffff\x01\x4b\x01\x00\x02\x4b\x01\uffff\x02"+
        "\x4b";
    const string DFA37_acceptS =
        "\x02\uffff\x01\x02\x04\uffff\x01\x01\x02\uffff";
    const string DFA37_specialS =
        "\x04\uffff\x01\x00\x05\uffff}>";
    static readonly string[] DFA37_transitionS = {
            "\x01\x01\x01\uffff\x01\x02\x01\uffff\x02\x02\x02\uffff\x01"+
            "\x02\x16\uffff\x01\x02\x0f\uffff\x01\x02\x01\uffff\x03\x02\x01"+
            "\uffff\x06\x02",
            "\x0a\x02\x0b\uffff\x16\x02\x02\x03\x1b\x02",
            "",
            "\x0a\x02\x02\uffff\x01\x04\x04\uffff\x01\x02\x02\uffff\x20"+
            "\x02\x06\x05\x05\x02\x01\x06\x08\x02",
            "\x01\uffff",
            "\x0a\x02\x02\uffff\x01\x04\x04\uffff\x01\x02\x02\uffff\x2b"+
            "\x02\x01\x06\x08\x02",
            "\x0a\x02\x02\uffff\x01\x02\x08\uffff\x16\x02\x02\x08\x1b\x02",
            "",
            "\x0a\x02\x02\uffff\x01\x04\x08\uffff\x1f\x02\x06\x09\x0e\x02",
            "\x0a\x02\x02\uffff\x01\x04\x08\uffff\x33\x02"
    };

    static readonly short[] DFA37_eot = DFA.UnpackEncodedString(DFA37_eotS);
    static readonly short[] DFA37_eof = DFA.UnpackEncodedString(DFA37_eofS);
    static readonly char[] DFA37_min = DFA.UnpackEncodedStringToUnsignedChars(DFA37_minS);
    static readonly char[] DFA37_max = DFA.UnpackEncodedStringToUnsignedChars(DFA37_maxS);
    static readonly short[] DFA37_accept = DFA.UnpackEncodedString(DFA37_acceptS);
    static readonly short[] DFA37_special = DFA.UnpackEncodedString(DFA37_specialS);
    static readonly short[][] DFA37_transition = DFA.UnpackEncodedStringArray(DFA37_transitionS);

    protected class DFA37 : DFA
    {
        public DFA37(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 37;
            this.eot = DFA37_eot;
            this.eof = DFA37_eof;
            this.min = DFA37_min;
            this.max = DFA37_max;
            this.accept = DFA37_accept;
            this.special = DFA37_special;
            this.transition = DFA37_transition;

        }

        override public string Description
        {
            get { return "310:27: ( ( size )=> size )?"; }
        }

    }


    protected internal int DFA37_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA37_4 = input.LA(1);

                   	 
                   	int index37_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_simpletikz()) ) { s = 7; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index37_4);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae37 =
            new NoViableAltException(dfa.Description, 37, _s, input);
        dfa.Error(nvae37);
        throw nvae37;
    }
 

    public static readonly BitSet FOLLOW_dontcare_preamble_in_tikzdocument392 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_tikz_styleorsetorcmd_in_tikzdocument396 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzdocument400 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_tikzpicture_in_tikzdocument405 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_TIKZEDT_CMD_COMMENT_in_tikz_cmd_comment431 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikz_styleorsetorcmd453 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikz_styleorsetorcmd457 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_cmd_comment_in_tikz_styleorsetorcmd461 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_preamble472 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BEGIN_in_otherbegin497 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_LBRR_in_otherbegin499 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_idd2_in_otherbegin501 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_RBRR_in_otherbegin503 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TIKZSTYLE_in_tikz_style515 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_LBRR_in_tikz_style517 = new BitSet(new ulong[]{0xFFFFFFFFFE003FF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_idd_in_tikz_style519 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_RBRR_in_tikz_style521 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_EQU_in_tikz_style523 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikz_style525 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_squarebr_start_in_tikz_options547 = new BitSet(new ulong[]{0xFFFFFFFFFE043FF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_options550 = new BitSet(new ulong[]{0xFFFFFFFFFE243FF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_KOMMA_in_tikz_options553 = new BitSet(new ulong[]{0xFFFFFFFFFE003FF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_options555 = new BitSet(new ulong[]{0xFFFFFFFFFE243FF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_KOMMA_in_tikz_options559 = new BitSet(new ulong[]{0xFFFFFFFFFE043FF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_squarebr_end_in_tikz_options564 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_option_style_in_option589 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_option_kv_in_option598 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_option_kv612 = new BitSet(new ulong[]{0x0000000000400002UL});
    public static readonly BitSet FOLLOW_EQU_in_option_kv615 = new BitSet(new ulong[]{0xFFFFFFFFFE083FF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_iddornumberunitorstring_in_option_kv617 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRR_in_tikzstring645 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_no_rlbrace_in_tikzstring647 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikzstring651 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_no_rlbrace_in_tikzstring653 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_RBRR_in_tikzstring658 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_no_rlbrace681 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_iddornumberunitorstring698 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzstring_in_iddornumberunitorstring702 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_option_style712 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_STYLETAG_in_option_style714 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_EQU_in_option_style716 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_LBRR_in_option_style718 = new BitSet(new ulong[]{0xFFFFFFFFFE303FF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_option_kv_in_option_style721 = new BitSet(new ulong[]{0x0000000000300000UL});
    public static readonly BitSet FOLLOW_KOMMA_in_option_style724 = new BitSet(new ulong[]{0xFFFFFFFFFE003FF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_option_kv_in_option_style726 = new BitSet(new ulong[]{0x0000000000300000UL});
    public static readonly BitSet FOLLOW_KOMMA_in_option_style733 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_RBRR_in_option_style736 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_heavenknowswhythisisnecessary_in_idd771 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_idd_heavenknowswhythisisnecessary791 = new BitSet(new ulong[]{0xFFFFFFFFFE003FF2UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_ID_in_idd2845 = new BitSet(new ulong[]{0x0000400000000002UL});
    public static readonly BitSet FOLLOW_number_in_numberunit868 = new BitSet(new ulong[]{0x3F00000000000002UL});
    public static readonly BitSet FOLLOW_unit_in_numberunit870 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_number896 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unit0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_set_start_in_tikz_set951 = new BitSet(new ulong[]{0xFFFFFFFFFE103FF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_set954 = new BitSet(new ulong[]{0xFFFFFFFFFE303FF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_KOMMA_in_tikz_set957 = new BitSet(new ulong[]{0xFFFFFFFFFE003FF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_set959 = new BitSet(new ulong[]{0xFFFFFFFFFE303FF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_roundbr_end_in_tikz_set965 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzpicture_start_in_tikzpicture993 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpicture995 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzpicture998 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_tikzpicture_end_in_tikzpicture1001 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody1031 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody1035 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_tikznode_ext_in_tikzbody1039 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody1043 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody1047 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody1051 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody1056 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_dontcare_body_nobr_in_tikzbody1061 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody1072 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody1076 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_tikznode_ext_in_tikzbody1080 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody1084 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody1088 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody1092 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody1097 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_dontcare_body_in_tikzbody1102 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body_nobr1119 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body1173 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_END_in_otherend1224 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_LBRR_in_otherend1226 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_idd2_in_otherend1228 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_RBRR_in_otherend1230 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzscope_start_in_tikzscope1257 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzscope1259 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzscope1262 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_tikzscope_end_in_tikzscope1265 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_in_tikzpath1320 = new BitSet(new ulong[]{0x40004000008A8000UL,0x00000000000003F7UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath1322 = new BitSet(new ulong[]{0x40004000008A8000UL,0x00000000000003F7UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzpath1325 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpath_element1354 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_in_tikzpath_element1361 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_int_in_tikzpath_element1367 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_circle_in_tikzpath_element1373 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arc_in_tikzpath_element1380 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_roundbr_start_in_tikzpath_element1387 = new BitSet(new ulong[]{0xFFFFFFFFFE1ABFF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath_element1389 = new BitSet(new ulong[]{0xFFFFFFFFFE1ABFF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_roundbr_end_in_tikzpath_element1392 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_edgeop_in_tikzpath_element1411 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_node_start_in_tikznode_ext1422 = new BitSet(new ulong[]{0xFFFFFFFFFE0ABFF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_tikznode_core_in_tikznode_ext1424 = new BitSet(new ulong[]{0x40004000008A8000UL,0x00000000000003F7UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikznode_ext1426 = new BitSet(new ulong[]{0x40004000008A8000UL,0x00000000000003F7UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikznode_ext1429 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_62_in_tikznode_int1454 = new BitSet(new ulong[]{0xFFFFFFFFFE0ABFF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_tikznode_core_in_tikznode_int1457 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikznode_core1467 = new BitSet(new ulong[]{0xFFFFFFFFFE0ABFF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikznode_core1470 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_tikznode_decorator1497 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_63_in_tikznode_decorator1504 = new BitSet(new ulong[]{0x0000000000008000UL,0x0000000000000300UL});
    public static readonly BitSet FOLLOW_coord_in_tikznode_decorator1507 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_options_dontcare_in_tikznode_decorator1513 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBR_in_tikz_options_dontcare1523 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_no_rlbracket_in_tikz_options_dontcare1525 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_tikz_options_dontcare_in_tikz_options_dontcare1529 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_no_rlbracket_in_tikz_options_dontcare1531 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_RBR_in_tikz_options_dontcare1536 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_no_rlbracket1554 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAR_in_nodename1571 = new BitSet(new ulong[]{0xFFFFFFFFFE003FF0UL,0x0000000000000FFFUL});
    public static readonly BitSet FOLLOW_idd_in_nodename1573 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_RPAR_in_nodename1575 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_64_in_circle1599 = new BitSet(new ulong[]{0x0000000000008002UL});
    public static readonly BitSet FOLLOW_65_in_circle1603 = new BitSet(new ulong[]{0x0000000000008002UL});
    public static readonly BitSet FOLLOW_size_in_circle1612 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_66_in_arc1627 = new BitSet(new ulong[]{0x0000000000008002UL});
    public static readonly BitSet FOLLOW_LPAR_in_arc1630 = new BitSet(new ulong[]{0x0001800000000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_arc1632 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_COLON_in_arc1634 = new BitSet(new ulong[]{0x0001800000000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_arc1636 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_COLON_in_arc1638 = new BitSet(new ulong[]{0x0001800000000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_arc1640 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_RPAR_in_arc1642 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAR_in_size1660 = new BitSet(new ulong[]{0x0001800000000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_size1662 = new BitSet(new ulong[]{0x0000000000010000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_size1665 = new BitSet(new ulong[]{0x0001800000000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_size1667 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_RPAR_in_size1671 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_coord1701 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord1725 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_LPAR_in_coord1728 = new BitSet(new ulong[]{0x0001800000000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord1730 = new BitSet(new ulong[]{0x0000000001200000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord1732 = new BitSet(new ulong[]{0x0001800000000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord1734 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_RPAR_in_coord1736 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_coord_sep1762 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_edgeop0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_coord_modifier0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBR_in_squarebr_start1836 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RBR_in_squarebr_end1854 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SEMIC_in_semicolon_end1873 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRR_in_roundbr_start1891 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RBRR_in_roundbr_end1909 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TIKZSET_in_tikz_set_start1927 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_LBRR_in_tikz_set_start1929 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BEGIN_in_tikzpicture_start1948 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_LBRR_in_tikzpicture_start1950 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_74_in_tikzpicture_start1952 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_RBRR_in_tikzpicture_start1954 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_END_in_tikzpicture_end1972 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_LBRR_in_tikzpicture_end1974 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_74_in_tikzpicture_end1976 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_RBRR_in_tikzpicture_end1978 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BEGIN_in_tikzscope_start1996 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_LBRR_in_tikzscope_start1998 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_75_in_tikzscope_start2000 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_RBRR_in_tikzscope_start2002 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_END_in_tikzscope_end2020 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_LBRR_in_tikzscope_end2022 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_75_in_tikzscope_end2024 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_RBRR_in_tikzscope_end2026 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_tag_in_path_start2045 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NODE_in_node_start2063 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_path_start_tag0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_size_in_synpred1_simpletikz1608 = new BitSet(new ulong[]{0x0000000000000002UL});

}
