// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g 2011-01-08 18:40:42

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
		"IM_DONTCARE", 
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
		"'\\\\begin'", 
		"'\\\\tikzstyle'", 
		"'\\\\tikzset'", 
		"'{'", 
		"'}'", 
		"'='", 
		"','", 
		"':'", 
		"'/.style'", 
		"'('", 
		"')'", 
		"'['", 
		"']'", 
		"';'", 
		"'cm'", 
		"'in'", 
		"'ex'", 
		"'mm'", 
		"'pt'", 
		"'em'", 
		"'\\\\end'", 
		"'\\\\node'", 
		"'\\\\coordinate'", 
		"'\\\\draw'", 
		"'\\\\path'", 
		"'\\\\fill'", 
		"'\\\\clip'", 
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
    public const int EXPONENT = 31;
    public const int T__67 = 67;
    public const int T__64 = 64;
    public const int TIKZEDT_CMD_COMMENT = 25;
    public const int IM_STARTTAG = 13;
    public const int T__65 = 65;
    public const int T__62 = 62;
    public const int T__63 = 63;
    public const int IM_PATH = 4;
    public const int IM_ID = 18;
    public const int IM_DONTCARE = 24;
    public const int SOMETHING = 35;
    public const int ID = 26;
    public const int T__61 = 61;
    public const int EOF = -1;
    public const int T__60 = 60;
    public const int MATHSTRING = 33;
    public const int COMMAND = 34;
    public const int IM_ENDTAG = 14;
    public const int IM_USETIKZLIB = 20;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int IM_DOCUMENT = 11;
    public const int T__58 = 58;
    public const int ESC_SEQ = 32;
    public const int IM_STRING = 21;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int IM_TIKZSET = 19;
    public const int T__59 = 59;
    public const int IM_OPTION_KV = 17;
    public const int COMMENT = 30;
    public const int T__50 = 50;
    public const int IM_TIKZEDT_CMD = 23;
    public const int T__42 = 42;
    public const int T__43 = 43;
    public const int T__40 = 40;
    public const int T__41 = 41;
    public const int IM_OPTIONS = 15;
    public const int T__46 = 46;
    public const int T__47 = 47;
    public const int IM_OPTION_STYLE = 16;
    public const int T__44 = 44;
    public const int T__45 = 45;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int IM_COORD = 6;
    public const int IM_PICTURE = 10;
    public const int INT = 28;
    public const int IM_NODE = 5;
    public const int IM_STYLE = 22;
    public const int IM_SCOPE = 12;
    public const int IM_NUMBERUNIT = 9;
    public const int WS = 29;
    public const int T__71 = 71;
    public const int T__72 = 72;
    public const int T__36 = 36;
    public const int T__70 = 70;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int IM_SIZE = 7;
    public const int T__76 = 76;
    public const int T__75 = 75;
    public const int T__74 = 74;
    public const int IM_NODENAME = 8;
    public const int T__73 = 73;
    public const int FLOAT_WO_EXP = 27;

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
		get { return "C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g"; }
    }



      //@Override
      protected override object RecoverFromMismatchedToken(IIntStream input, int ttype, BitSet follow)
        {
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:137:1: tikzdocument : ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* tikzpicture ( . )* -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture ) ;
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:138:2: ( ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* tikzpicture ( . )* -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:138:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* tikzpicture ( . )*
            {
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:138:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )*
            	do 
            	{
            	    int alt1 = 4;
            	    switch ( input.LA(1) ) 
            	    {
            	    case 36:
            	    	{
            	        int LA1_1 = input.LA(2);

            	        if ( (LA1_1 == 39) )
            	        {
            	            int LA1_4 = input.LA(3);

            	            if ( (LA1_4 == ID) )
            	            {
            	                alt1 = 3;
            	            }


            	        }


            	        }
            	        break;
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
            	    case IM_DONTCARE:
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
            	    case 39:
            	    case 40:
            	    case 41:
            	    case 42:
            	    case 43:
            	    case 44:
            	    case 45:
            	    case 46:
            	    case 47:
            	    case 48:
            	    case 49:
            	    case 50:
            	    case 51:
            	    case 52:
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
            	    case 69:
            	    case 70:
            	    case 71:
            	    case 72:
            	    case 73:
            	    case 74:
            	    case 75:
            	    case 76:
            	    	{
            	        alt1 = 1;
            	        }
            	        break;
            	    case TIKZEDT_CMD_COMMENT:
            	    case 37:
            	    case 38:
            	    	{
            	        alt1 = 2;
            	        }
            	        break;

            	    }

            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:138:5: dontcare_preamble
            			    {
            			    	PushFollow(FOLLOW_dontcare_preamble_in_tikzdocument249);
            			    	dontcare_preamble1 = dontcare_preamble();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_dontcare_preamble.Add(dontcare_preamble1.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:138:25: tikz_styleorsetorcmd
            			    {
            			    	PushFollow(FOLLOW_tikz_styleorsetorcmd_in_tikzdocument253);
            			    	tikz_styleorsetorcmd2 = tikz_styleorsetorcmd();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikz_styleorsetorcmd.Add(tikz_styleorsetorcmd2.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:138:48: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzdocument257);
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

            	PushFollow(FOLLOW_tikzpicture_in_tikzdocument262);
            	tikzpicture4 = tikzpicture();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzpicture.Add(tikzpicture4.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:138:74: ( . )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= IM_PATH && LA2_0 <= 76)) )
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
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:138:74: .
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
            	// 138:77: -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:138:80: ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DOCUMENT, "IM_DOCUMENT"), root_1);

            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:138:94: ( tikz_styleorsetorcmd )*
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

    public class tikzdocument_wo_tikzpicture_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikzdocument_wo_tikzpicture"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:141:1: tikzdocument_wo_tikzpicture : ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* EOF -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* ) ;
    public simpletikzParser.tikzdocument_wo_tikzpicture_return tikzdocument_wo_tikzpicture() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzdocument_wo_tikzpicture_return retval = new simpletikzParser.tikzdocument_wo_tikzpicture_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EOF9 = null;
        simpletikzParser.dontcare_preamble_return dontcare_preamble6 = default(simpletikzParser.dontcare_preamble_return);

        simpletikzParser.tikz_styleorsetorcmd_return tikz_styleorsetorcmd7 = default(simpletikzParser.tikz_styleorsetorcmd_return);

        simpletikzParser.otherbegin_return otherbegin8 = default(simpletikzParser.otherbegin_return);


        object EOF9_tree=null;
        RewriteRuleTokenStream stream_EOF = new RewriteRuleTokenStream(adaptor,"token EOF");
        RewriteRuleSubtreeStream stream_dontcare_preamble = new RewriteRuleSubtreeStream(adaptor,"rule dontcare_preamble");
        RewriteRuleSubtreeStream stream_otherbegin = new RewriteRuleSubtreeStream(adaptor,"rule otherbegin");
        RewriteRuleSubtreeStream stream_tikz_styleorsetorcmd = new RewriteRuleSubtreeStream(adaptor,"rule tikz_styleorsetorcmd");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:142:2: ( ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* EOF -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:142:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* EOF
            {
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:142:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )*
            	do 
            	{
            	    int alt3 = 4;
            	    switch ( input.LA(1) ) 
            	    {
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
            	    case IM_DONTCARE:
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
            	    case 39:
            	    case 40:
            	    case 41:
            	    case 42:
            	    case 43:
            	    case 44:
            	    case 45:
            	    case 46:
            	    case 47:
            	    case 48:
            	    case 49:
            	    case 50:
            	    case 51:
            	    case 52:
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
            	    case 69:
            	    case 70:
            	    case 71:
            	    case 72:
            	    case 73:
            	    case 74:
            	    case 75:
            	    case 76:
            	    	{
            	        alt3 = 1;
            	        }
            	        break;
            	    case TIKZEDT_CMD_COMMENT:
            	    case 37:
            	    case 38:
            	    	{
            	        alt3 = 2;
            	        }
            	        break;
            	    case 36:
            	    	{
            	        alt3 = 3;
            	        }
            	        break;

            	    }

            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:142:5: dontcare_preamble
            			    {
            			    	PushFollow(FOLLOW_dontcare_preamble_in_tikzdocument_wo_tikzpicture288);
            			    	dontcare_preamble6 = dontcare_preamble();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_dontcare_preamble.Add(dontcare_preamble6.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:142:25: tikz_styleorsetorcmd
            			    {
            			    	PushFollow(FOLLOW_tikz_styleorsetorcmd_in_tikzdocument_wo_tikzpicture292);
            			    	tikz_styleorsetorcmd7 = tikz_styleorsetorcmd();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikz_styleorsetorcmd.Add(tikz_styleorsetorcmd7.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:142:48: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzdocument_wo_tikzpicture296);
            			    	otherbegin8 = otherbegin();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_otherbegin.Add(otherbegin8.Tree);

            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements

            	EOF9=(IToken)Match(input,EOF,FOLLOW_EOF_in_tikzdocument_wo_tikzpicture301); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_EOF.Add(EOF9);



            	// AST REWRITE
            	// elements:          tikz_styleorsetorcmd
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 142:66: -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:142:69: ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DOCUMENT, "IM_DOCUMENT"), root_1);

            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:142:83: ( tikz_styleorsetorcmd )*
            	    while ( stream_tikz_styleorsetorcmd.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikz_styleorsetorcmd.NextTree());

            	    }
            	    stream_tikz_styleorsetorcmd.Reset();

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
    // $ANTLR end "tikzdocument_wo_tikzpicture"

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:145:1: tikz_cmd_comment : TIKZEDT_CMD_COMMENT -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT ) ;
    public simpletikzParser.tikz_cmd_comment_return tikz_cmd_comment() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_cmd_comment_return retval = new simpletikzParser.tikz_cmd_comment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken TIKZEDT_CMD_COMMENT10 = null;

        object TIKZEDT_CMD_COMMENT10_tree=null;
        RewriteRuleTokenStream stream_TIKZEDT_CMD_COMMENT = new RewriteRuleTokenStream(adaptor,"token TIKZEDT_CMD_COMMENT");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:146:2: ( TIKZEDT_CMD_COMMENT -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:146:4: TIKZEDT_CMD_COMMENT
            {
            	TIKZEDT_CMD_COMMENT10=(IToken)Match(input,TIKZEDT_CMD_COMMENT,FOLLOW_TIKZEDT_CMD_COMMENT_in_tikz_cmd_comment322); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_TIKZEDT_CMD_COMMENT.Add(TIKZEDT_CMD_COMMENT10);



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
            	// 146:27: -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:146:30: ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:149:1: tikz_styleorsetorcmd : ( tikz_style | tikz_set | tikz_cmd_comment );
    public simpletikzParser.tikz_styleorsetorcmd_return tikz_styleorsetorcmd() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_styleorsetorcmd_return retval = new simpletikzParser.tikz_styleorsetorcmd_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikz_style_return tikz_style11 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.tikz_set_return tikz_set12 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_cmd_comment_return tikz_cmd_comment13 = default(simpletikzParser.tikz_cmd_comment_return);



        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:150:2: ( tikz_style | tikz_set | tikz_cmd_comment )
            int alt4 = 3;
            switch ( input.LA(1) ) 
            {
            case 37:
            	{
                alt4 = 1;
                }
                break;
            case 38:
            	{
                alt4 = 2;
                }
                break;
            case TIKZEDT_CMD_COMMENT:
            	{
                alt4 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d4s0 =
            	        new NoViableAltException("", 4, 0, input);

            	    throw nvae_d4s0;
            }

            switch (alt4) 
            {
                case 1 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:150:4: tikz_style
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_style_in_tikz_styleorsetorcmd344);
                    	tikz_style11 = tikz_style();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style11.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:150:17: tikz_set
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_set_in_tikz_styleorsetorcmd348);
                    	tikz_set12 = tikz_set();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set12.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:150:28: tikz_cmd_comment
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_cmd_comment_in_tikz_styleorsetorcmd352);
                    	tikz_cmd_comment13 = tikz_cmd_comment();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_cmd_comment13.Tree);

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:153:1: dontcare_preamble : ~ ( '\\\\begin' | '\\\\tikzstyle' | '\\\\tikzset' | TIKZEDT_CMD_COMMENT ) ;
    public simpletikzParser.dontcare_preamble_return dontcare_preamble() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_preamble_return retval = new simpletikzParser.dontcare_preamble_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set14 = null;

        object set14_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:154:2: (~ ( '\\\\begin' | '\\\\tikzstyle' | '\\\\tikzset' | TIKZEDT_CMD_COMMENT ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:154:4: ~ ( '\\\\begin' | '\\\\tikzstyle' | '\\\\tikzset' | TIKZEDT_CMD_COMMENT )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set14 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= IM_DONTCARE) || (input.LA(1) >= ID && input.LA(1) <= SOMETHING) || (input.LA(1) >= 39 && input.LA(1) <= 76) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set14));
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:156:1: otherbegin : '\\\\begin' '{' idd2 '}' ;
    public simpletikzParser.otherbegin_return otherbegin() // throws RecognitionException [1]
    {   
        simpletikzParser.otherbegin_return retval = new simpletikzParser.otherbegin_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal15 = null;
        IToken char_literal16 = null;
        IToken char_literal18 = null;
        simpletikzParser.idd2_return idd217 = default(simpletikzParser.idd2_return);


        object string_literal15_tree=null;
        object char_literal16_tree=null;
        object char_literal18_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:157:2: ( '\\\\begin' '{' idd2 '}' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:157:4: '\\\\begin' '{' idd2 '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal15=(IToken)Match(input,36,FOLLOW_36_in_otherbegin388); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal15_tree = (object)adaptor.Create(string_literal15);
            		adaptor.AddChild(root_0, string_literal15_tree);
            	}
            	char_literal16=(IToken)Match(input,39,FOLLOW_39_in_otherbegin390); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal16_tree = (object)adaptor.Create(char_literal16);
            		adaptor.AddChild(root_0, char_literal16_tree);
            	}
            	PushFollow(FOLLOW_idd2_in_otherbegin392);
            	idd217 = idd2();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idd217.Tree);
            	char_literal18=(IToken)Match(input,40,FOLLOW_40_in_otherbegin394); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal18_tree = (object)adaptor.Create(char_literal18);
            		adaptor.AddChild(root_0, char_literal18_tree);
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:160:1: tikz_style : '\\\\tikzstyle' '{' idd '}' '=' tikz_options -> ^( IM_STYLE idd tikz_options ) ;
    public simpletikzParser.tikz_style_return tikz_style() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_style_return retval = new simpletikzParser.tikz_style_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal19 = null;
        IToken char_literal20 = null;
        IToken char_literal22 = null;
        IToken char_literal23 = null;
        simpletikzParser.idd_return idd21 = default(simpletikzParser.idd_return);

        simpletikzParser.tikz_options_return tikz_options24 = default(simpletikzParser.tikz_options_return);


        object string_literal19_tree=null;
        object char_literal20_tree=null;
        object char_literal22_tree=null;
        object char_literal23_tree=null;
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");
        RewriteRuleTokenStream stream_37 = new RewriteRuleTokenStream(adaptor,"token 37");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:161:2: ( '\\\\tikzstyle' '{' idd '}' '=' tikz_options -> ^( IM_STYLE idd tikz_options ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:161:4: '\\\\tikzstyle' '{' idd '}' '=' tikz_options
            {
            	string_literal19=(IToken)Match(input,37,FOLLOW_37_in_tikz_style406); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_37.Add(string_literal19);

            	char_literal20=(IToken)Match(input,39,FOLLOW_39_in_tikz_style408); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_39.Add(char_literal20);

            	PushFollow(FOLLOW_idd_in_tikz_style410);
            	idd21 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idd.Add(idd21.Tree);
            	char_literal22=(IToken)Match(input,40,FOLLOW_40_in_tikz_style412); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_40.Add(char_literal22);

            	char_literal23=(IToken)Match(input,41,FOLLOW_41_in_tikz_style414); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(char_literal23);

            	PushFollow(FOLLOW_tikz_options_in_tikz_style416);
            	tikz_options24 = tikz_options();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikz_options.Add(tikz_options24.Tree);


            	// AST REWRITE
            	// elements:          idd, tikz_options
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 161:47: -> ^( IM_STYLE idd tikz_options )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:161:50: ^( IM_STYLE idd tikz_options )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:164:1: tikz_options : squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) ;
    public simpletikzParser.tikz_options_return tikz_options() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_options_return retval = new simpletikzParser.tikz_options_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal27 = null;
        IToken char_literal29 = null;
        simpletikzParser.squarebr_start_return squarebr_start25 = default(simpletikzParser.squarebr_start_return);

        simpletikzParser.option_return option26 = default(simpletikzParser.option_return);

        simpletikzParser.option_return option28 = default(simpletikzParser.option_return);

        simpletikzParser.squarebr_end_return squarebr_end30 = default(simpletikzParser.squarebr_end_return);


        object char_literal27_tree=null;
        object char_literal29_tree=null;
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleSubtreeStream stream_squarebr_start = new RewriteRuleSubtreeStream(adaptor,"rule squarebr_start");
        RewriteRuleSubtreeStream stream_squarebr_end = new RewriteRuleSubtreeStream(adaptor,"rule squarebr_end");
        RewriteRuleSubtreeStream stream_option = new RewriteRuleSubtreeStream(adaptor,"rule option");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:165:2: ( squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:165:5: squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end
            {
            	PushFollow(FOLLOW_squarebr_start_in_tikz_options438);
            	squarebr_start25 = squarebr_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_squarebr_start.Add(squarebr_start25.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:165:20: ( option ( ',' option )* ( ',' )? )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( ((LA7_0 >= IM_PATH && LA7_0 <= 38) || (LA7_0 >= 50 && LA7_0 <= 76)) )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:165:21: option ( ',' option )* ( ',' )?
            	        {
            	        	PushFollow(FOLLOW_option_in_tikz_options441);
            	        	option26 = option();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_option.Add(option26.Tree);
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:165:28: ( ',' option )*
            	        	do 
            	        	{
            	        	    int alt5 = 2;
            	        	    int LA5_0 = input.LA(1);

            	        	    if ( (LA5_0 == 42) )
            	        	    {
            	        	        int LA5_1 = input.LA(2);

            	        	        if ( ((LA5_1 >= IM_PATH && LA5_1 <= 38) || (LA5_1 >= 50 && LA5_1 <= 76)) )
            	        	        {
            	        	            alt5 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt5) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:165:29: ',' option
            	        			    {
            	        			    	char_literal27=(IToken)Match(input,42,FOLLOW_42_in_tikz_options444); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_42.Add(char_literal27);

            	        			    	PushFollow(FOLLOW_option_in_tikz_options446);
            	        			    	option28 = option();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( (state.backtracking==0) ) stream_option.Add(option28.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop5;
            	        	    }
            	        	} while (true);

            	        	loop5:
            	        		;	// Stops C# compiler whining that label 'loop5' has no statements

            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:165:42: ( ',' )?
            	        	int alt6 = 2;
            	        	int LA6_0 = input.LA(1);

            	        	if ( (LA6_0 == 42) )
            	        	{
            	        	    alt6 = 1;
            	        	}
            	        	switch (alt6) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:165:42: ','
            	        	        {
            	        	        	char_literal29=(IToken)Match(input,42,FOLLOW_42_in_tikz_options450); if (state.failed) return retval; 
            	        	        	if ( (state.backtracking==0) ) stream_42.Add(char_literal29);


            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_squarebr_end_in_tikz_options455);
            	squarebr_end30 = squarebr_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_squarebr_end.Add(squarebr_end30.Tree);


            	// AST REWRITE
            	// elements:          squarebr_start, option, squarebr_end
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 165:63: -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:165:66: ^( IM_OPTIONS squarebr_start ( option )* squarebr_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTIONS, "IM_OPTIONS"), root_1);

            	    adaptor.AddChild(root_1, stream_squarebr_start.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:165:94: ( option )*
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:168:1: option : ( option_style | option_kv );
    public simpletikzParser.option_return option() // throws RecognitionException [1]
    {   
        simpletikzParser.option_return retval = new simpletikzParser.option_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.option_style_return option_style31 = default(simpletikzParser.option_style_return);

        simpletikzParser.option_kv_return option_kv32 = default(simpletikzParser.option_kv_return);



        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:169:2: ( option_style | option_kv )
            int alt8 = 2;
            alt8 = dfa8.Predict(input);
            switch (alt8) 
            {
                case 1 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:169:4: option_style
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_option_style_in_option480);
                    	option_style31 = option_style();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, option_style31.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:170:5: option_kv
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_option_kv_in_option489);
                    	option_kv32 = option_kv();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, option_kv32.Tree);

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:173:1: option_kv : idd ( '=' iddornumberunitorstringorrange )? -> ^( IM_OPTION_KV idd ( iddornumberunitorstringorrange )? ) ;
    public simpletikzParser.option_kv_return option_kv() // throws RecognitionException [1]
    {   
        simpletikzParser.option_kv_return retval = new simpletikzParser.option_kv_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal34 = null;
        simpletikzParser.idd_return idd33 = default(simpletikzParser.idd_return);

        simpletikzParser.iddornumberunitorstringorrange_return iddornumberunitorstringorrange35 = default(simpletikzParser.iddornumberunitorstringorrange_return);


        object char_literal34_tree=null;
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleSubtreeStream stream_iddornumberunitorstringorrange = new RewriteRuleSubtreeStream(adaptor,"rule iddornumberunitorstringorrange");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:174:2: ( idd ( '=' iddornumberunitorstringorrange )? -> ^( IM_OPTION_KV idd ( iddornumberunitorstringorrange )? ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:174:4: idd ( '=' iddornumberunitorstringorrange )?
            {
            	PushFollow(FOLLOW_idd_in_option_kv503);
            	idd33 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idd.Add(idd33.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:174:8: ( '=' iddornumberunitorstringorrange )?
            	int alt9 = 2;
            	int LA9_0 = input.LA(1);

            	if ( (LA9_0 == 41) )
            	{
            	    alt9 = 1;
            	}
            	switch (alt9) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:174:9: '=' iddornumberunitorstringorrange
            	        {
            	        	char_literal34=(IToken)Match(input,41,FOLLOW_41_in_option_kv506); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_41.Add(char_literal34);

            	        	PushFollow(FOLLOW_iddornumberunitorstringorrange_in_option_kv508);
            	        	iddornumberunitorstringorrange35 = iddornumberunitorstringorrange();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_iddornumberunitorstringorrange.Add(iddornumberunitorstringorrange35.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          iddornumberunitorstringorrange, idd
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 174:47: -> ^( IM_OPTION_KV idd ( iddornumberunitorstringorrange )? )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:174:50: ^( IM_OPTION_KV idd ( iddornumberunitorstringorrange )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTION_KV, "IM_OPTION_KV"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:174:69: ( iddornumberunitorstringorrange )?
            	    if ( stream_iddornumberunitorstringorrange.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_iddornumberunitorstringorrange.NextTree());

            	    }
            	    stream_iddornumberunitorstringorrange.Reset();

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:177:1: tikzstring : '{' ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* '}' -> ^( IM_STRING '{' '}' ) ;
    public simpletikzParser.tikzstring_return tikzstring() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzstring_return retval = new simpletikzParser.tikzstring_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal36 = null;
        IToken char_literal40 = null;
        simpletikzParser.no_rlbrace_return no_rlbrace37 = default(simpletikzParser.no_rlbrace_return);

        simpletikzParser.tikzstring_return tikzstring38 = default(simpletikzParser.tikzstring_return);

        simpletikzParser.no_rlbrace_return no_rlbrace39 = default(simpletikzParser.no_rlbrace_return);


        object char_literal36_tree=null;
        object char_literal40_tree=null;
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");
        RewriteRuleSubtreeStream stream_tikzstring = new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_no_rlbrace = new RewriteRuleSubtreeStream(adaptor,"rule no_rlbrace");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:178:2: ( '{' ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* '}' -> ^( IM_STRING '{' '}' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:178:4: '{' ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* '}'
            {
            	char_literal36=(IToken)Match(input,39,FOLLOW_39_in_tikzstring536); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_39.Add(char_literal36);

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:178:8: ( no_rlbrace )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( ((LA10_0 >= IM_PATH && LA10_0 <= 38) || (LA10_0 >= 41 && LA10_0 <= 76)) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:178:8: no_rlbrace
            			    {
            			    	PushFollow(FOLLOW_no_rlbrace_in_tikzstring538);
            			    	no_rlbrace37 = no_rlbrace();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_no_rlbrace.Add(no_rlbrace37.Tree);

            			    }
            			    break;

            			default:
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:178:20: ( tikzstring ( no_rlbrace )* )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( (LA12_0 == 39) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:178:21: tikzstring ( no_rlbrace )*
            			    {
            			    	PushFollow(FOLLOW_tikzstring_in_tikzstring542);
            			    	tikzstring38 = tikzstring();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikzstring.Add(tikzstring38.Tree);
            			    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:178:32: ( no_rlbrace )*
            			    	do 
            			    	{
            			    	    int alt11 = 2;
            			    	    int LA11_0 = input.LA(1);

            			    	    if ( ((LA11_0 >= IM_PATH && LA11_0 <= 38) || (LA11_0 >= 41 && LA11_0 <= 76)) )
            			    	    {
            			    	        alt11 = 1;
            			    	    }


            			    	    switch (alt11) 
            			    		{
            			    			case 1 :
            			    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:178:32: no_rlbrace
            			    			    {
            			    			    	PushFollow(FOLLOW_no_rlbrace_in_tikzstring544);
            			    			    	no_rlbrace39 = no_rlbrace();
            			    			    	state.followingStackPointer--;
            			    			    	if (state.failed) return retval;
            			    			    	if ( (state.backtracking==0) ) stream_no_rlbrace.Add(no_rlbrace39.Tree);

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop11;
            			    	    }
            			    	} while (true);

            			    	loop11:
            			    		;	// Stops C# compiler whining that label 'loop11' has no statements


            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements

            	char_literal40=(IToken)Match(input,40,FOLLOW_40_in_tikzstring549); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_40.Add(char_literal40);



            	// AST REWRITE
            	// elements:          40, 39
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 178:50: -> ^( IM_STRING '{' '}' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:178:53: ^( IM_STRING '{' '}' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STRING, "IM_STRING"), root_1);

            	    adaptor.AddChild(root_1, stream_39.NextNode());
            	    adaptor.AddChild(root_1, stream_40.NextNode());

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:181:1: no_rlbrace : ~ ( '{' | '}' ) ;
    public simpletikzParser.no_rlbrace_return no_rlbrace() // throws RecognitionException [1]
    {   
        simpletikzParser.no_rlbrace_return retval = new simpletikzParser.no_rlbrace_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set41 = null;

        object set41_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:182:2: (~ ( '{' | '}' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:182:4: ~ ( '{' | '}' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set41 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= 38) || (input.LA(1) >= 41 && input.LA(1) <= 76) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set41));
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

    public class iddornumberunitorstringorrange_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "iddornumberunitorstringorrange"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:184:1: iddornumberunitorstringorrange : ( numberunit | idd | tikzstring | range );
    public simpletikzParser.iddornumberunitorstringorrange_return iddornumberunitorstringorrange() // throws RecognitionException [1]
    {   
        simpletikzParser.iddornumberunitorstringorrange_return retval = new simpletikzParser.iddornumberunitorstringorrange_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.numberunit_return numberunit42 = default(simpletikzParser.numberunit_return);

        simpletikzParser.idd_return idd43 = default(simpletikzParser.idd_return);

        simpletikzParser.tikzstring_return tikzstring44 = default(simpletikzParser.tikzstring_return);

        simpletikzParser.range_return range45 = default(simpletikzParser.range_return);



        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:185:2: ( numberunit | idd | tikzstring | range )
            int alt13 = 4;
            switch ( input.LA(1) ) 
            {
            case FLOAT_WO_EXP:
            case INT:
            	{
                switch ( input.LA(2) ) 
                {
                case 40:
                case 42:
                case 48:
                	{
                    alt13 = 1;
                    }
                    break;
                case 50:
                case 51:
                case 52:
                case 53:
                case 54:
                case 55:
                	{
                    int LA13_5 = input.LA(3);

                    if ( (LA13_5 == 43) )
                    {
                        alt13 = 4;
                    }
                    else if ( (LA13_5 == 40 || LA13_5 == 42 || LA13_5 == 48) )
                    {
                        alt13 = 1;
                    }
                    else 
                    {
                        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                        NoViableAltException nvae_d13s5 =
                            new NoViableAltException("", 13, 5, input);

                        throw nvae_d13s5;
                    }
                    }
                    break;
                case 43:
                	{
                    alt13 = 4;
                    }
                    break;
                	default:
                	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                	    NoViableAltException nvae_d13s1 =
                	        new NoViableAltException("", 13, 1, input);

                	    throw nvae_d13s1;
                }

                }
                break;
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
            case IM_DONTCARE:
            case TIKZEDT_CMD_COMMENT:
            case ID:
            case WS:
            case COMMENT:
            case EXPONENT:
            case ESC_SEQ:
            case MATHSTRING:
            case COMMAND:
            case SOMETHING:
            case 36:
            case 37:
            case 38:
            case 50:
            case 51:
            case 52:
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
            case 69:
            case 70:
            case 71:
            case 72:
            case 73:
            case 74:
            case 75:
            case 76:
            	{
                alt13 = 2;
                }
                break;
            case 39:
            	{
                alt13 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d13s0 =
            	        new NoViableAltException("", 13, 0, input);

            	    throw nvae_d13s0;
            }

            switch (alt13) 
            {
                case 1 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:185:4: numberunit
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_numberunit_in_iddornumberunitorstringorrange589);
                    	numberunit42 = numberunit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, numberunit42.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:185:17: idd
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_idd_in_iddornumberunitorstringorrange593);
                    	idd43 = idd();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idd43.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:185:23: tikzstring
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikzstring_in_iddornumberunitorstringorrange597);
                    	tikzstring44 = tikzstring();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzstring44.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:185:36: range
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_range_in_iddornumberunitorstringorrange601);
                    	range45 = range();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, range45.Tree);

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
    // $ANTLR end "iddornumberunitorstringorrange"

    public class range_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "range"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:187:1: range : numberunit ':' numberunit ;
    public simpletikzParser.range_return range() // throws RecognitionException [1]
    {   
        simpletikzParser.range_return retval = new simpletikzParser.range_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal47 = null;
        simpletikzParser.numberunit_return numberunit46 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit48 = default(simpletikzParser.numberunit_return);


        object char_literal47_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:188:2: ( numberunit ':' numberunit )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:188:4: numberunit ':' numberunit
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_numberunit_in_range611);
            	numberunit46 = numberunit();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, numberunit46.Tree);
            	char_literal47=(IToken)Match(input,43,FOLLOW_43_in_range613); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal47_tree = (object)adaptor.Create(char_literal47);
            		adaptor.AddChild(root_0, char_literal47_tree);
            	}
            	PushFollow(FOLLOW_numberunit_in_range615);
            	numberunit48 = numberunit();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, numberunit48.Tree);

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
    // $ANTLR end "range"

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:190:1: option_style : idd '/.style' '=' '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}' -> ^( IM_OPTION_STYLE idd ( option_kv )* ) ;
    public simpletikzParser.option_style_return option_style() // throws RecognitionException [1]
    {   
        simpletikzParser.option_style_return retval = new simpletikzParser.option_style_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal50 = null;
        IToken char_literal51 = null;
        IToken char_literal52 = null;
        IToken char_literal54 = null;
        IToken char_literal56 = null;
        IToken char_literal57 = null;
        simpletikzParser.idd_return idd49 = default(simpletikzParser.idd_return);

        simpletikzParser.option_kv_return option_kv53 = default(simpletikzParser.option_kv_return);

        simpletikzParser.option_kv_return option_kv55 = default(simpletikzParser.option_kv_return);


        object string_literal50_tree=null;
        object char_literal51_tree=null;
        object char_literal52_tree=null;
        object char_literal54_tree=null;
        object char_literal56_tree=null;
        object char_literal57_tree=null;
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_option_kv = new RewriteRuleSubtreeStream(adaptor,"rule option_kv");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:191:2: ( idd '/.style' '=' '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}' -> ^( IM_OPTION_STYLE idd ( option_kv )* ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:191:4: idd '/.style' '=' '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}'
            {
            	PushFollow(FOLLOW_idd_in_option_style626);
            	idd49 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idd.Add(idd49.Tree);
            	string_literal50=(IToken)Match(input,44,FOLLOW_44_in_option_style628); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_44.Add(string_literal50);

            	char_literal51=(IToken)Match(input,41,FOLLOW_41_in_option_style630); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(char_literal51);

            	char_literal52=(IToken)Match(input,39,FOLLOW_39_in_option_style632); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_39.Add(char_literal52);

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:191:26: ( option_kv ( ',' option_kv )* )?
            	int alt15 = 2;
            	int LA15_0 = input.LA(1);

            	if ( ((LA15_0 >= IM_PATH && LA15_0 <= 38) || (LA15_0 >= 50 && LA15_0 <= 76)) )
            	{
            	    alt15 = 1;
            	}
            	switch (alt15) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:191:27: option_kv ( ',' option_kv )*
            	        {
            	        	PushFollow(FOLLOW_option_kv_in_option_style635);
            	        	option_kv53 = option_kv();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_option_kv.Add(option_kv53.Tree);
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:191:37: ( ',' option_kv )*
            	        	do 
            	        	{
            	        	    int alt14 = 2;
            	        	    int LA14_0 = input.LA(1);

            	        	    if ( (LA14_0 == 42) )
            	        	    {
            	        	        int LA14_1 = input.LA(2);

            	        	        if ( ((LA14_1 >= IM_PATH && LA14_1 <= 38) || (LA14_1 >= 50 && LA14_1 <= 76)) )
            	        	        {
            	        	            alt14 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt14) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:191:38: ',' option_kv
            	        			    {
            	        			    	char_literal54=(IToken)Match(input,42,FOLLOW_42_in_option_style638); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_42.Add(char_literal54);

            	        			    	PushFollow(FOLLOW_option_kv_in_option_style640);
            	        			    	option_kv55 = option_kv();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( (state.backtracking==0) ) stream_option_kv.Add(option_kv55.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop14;
            	        	    }
            	        	} while (true);

            	        	loop14:
            	        		;	// Stops C# compiler whining that label 'loop14' has no statements


            	        }
            	        break;

            	}

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:191:57: ( ',' )?
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( (LA16_0 == 42) )
            	{
            	    alt16 = 1;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:191:57: ','
            	        {
            	        	char_literal56=(IToken)Match(input,42,FOLLOW_42_in_option_style647); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_42.Add(char_literal56);


            	        }
            	        break;

            	}

            	char_literal57=(IToken)Match(input,40,FOLLOW_40_in_option_style650); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_40.Add(char_literal57);



            	// AST REWRITE
            	// elements:          option_kv, idd
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 191:67: -> ^( IM_OPTION_STYLE idd ( option_kv )* )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:191:70: ^( IM_OPTION_STYLE idd ( option_kv )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTION_STYLE, "IM_OPTION_STYLE"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:191:92: ( option_kv )*
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:203:1: idd : idd_heavenknowswhythisisnecessary -> ^( IM_ID ) ;
    public simpletikzParser.idd_return idd() // throws RecognitionException [1]
    {   
        simpletikzParser.idd_return retval = new simpletikzParser.idd_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.idd_heavenknowswhythisisnecessary_return idd_heavenknowswhythisisnecessary58 = default(simpletikzParser.idd_heavenknowswhythisisnecessary_return);


        RewriteRuleSubtreeStream stream_idd_heavenknowswhythisisnecessary = new RewriteRuleSubtreeStream(adaptor,"rule idd_heavenknowswhythisisnecessary");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:204:2: ( idd_heavenknowswhythisisnecessary -> ^( IM_ID ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:204:4: idd_heavenknowswhythisisnecessary
            {
            	PushFollow(FOLLOW_idd_heavenknowswhythisisnecessary_in_idd685);
            	idd_heavenknowswhythisisnecessary58 = idd_heavenknowswhythisisnecessary();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idd_heavenknowswhythisisnecessary.Add(idd_heavenknowswhythisisnecessary58.Tree);


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
            	// 204:39: -> ^( IM_ID )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:204:42: ^( IM_ID )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:206:1: idd_heavenknowswhythisisnecessary : (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' ) )+ ;
    public simpletikzParser.idd_heavenknowswhythisisnecessary_return idd_heavenknowswhythisisnecessary() // throws RecognitionException [1]
    {   
        simpletikzParser.idd_heavenknowswhythisisnecessary_return retval = new simpletikzParser.idd_heavenknowswhythisisnecessary_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set59 = null;

        object set59_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:207:3: ( (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' ) )+ )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:207:6: (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' ) )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:207:6: (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' ) )+
            	int cnt17 = 0;
            	do 
            	{
            	    int alt17 = 2;
            	    int LA17_0 = input.LA(1);

            	    if ( ((LA17_0 >= IM_PATH && LA17_0 <= 38) || (LA17_0 >= 50 && LA17_0 <= 76)) )
            	    {
            	        alt17 = 1;
            	    }


            	    switch (alt17) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:207:6: ~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' )
            			    {
            			    	set59 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= 38) || (input.LA(1) >= 50 && input.LA(1) <= 76) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set59));
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:208:1: idd2 : ( ID )+ -> ^( IM_ID ) ;
    public simpletikzParser.idd2_return idd2() // throws RecognitionException [1]
    {   
        simpletikzParser.idd2_return retval = new simpletikzParser.idd2_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID60 = null;

        object ID60_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:209:2: ( ( ID )+ -> ^( IM_ID ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:209:4: ( ID )+
            {
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:209:4: ( ID )+
            	int cnt18 = 0;
            	do 
            	{
            	    int alt18 = 2;
            	    int LA18_0 = input.LA(1);

            	    if ( (LA18_0 == ID) )
            	    {
            	        alt18 = 1;
            	    }


            	    switch (alt18) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:209:4: ID
            			    {
            			    	ID60=(IToken)Match(input,ID,FOLLOW_ID_in_idd2759); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_ID.Add(ID60);


            			    }
            			    break;

            			default:
            			    if ( cnt18 >= 1 ) goto loop18;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee18 =
            		                new EarlyExitException(18, input);
            		            throw eee18;
            	    }
            	    cnt18++;
            	} while (true);

            	loop18:
            		;	// Stops C# compiler whining that label 'loop18' has no statements



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
            	// 209:8: -> ^( IM_ID )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:209:11: ^( IM_ID )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:213:1: numberunit : number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) ;
    public simpletikzParser.numberunit_return numberunit() // throws RecognitionException [1]
    {   
        simpletikzParser.numberunit_return retval = new simpletikzParser.numberunit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.number_return number61 = default(simpletikzParser.number_return);

        simpletikzParser.unit_return unit62 = default(simpletikzParser.unit_return);


        RewriteRuleSubtreeStream stream_unit = new RewriteRuleSubtreeStream(adaptor,"rule unit");
        RewriteRuleSubtreeStream stream_number = new RewriteRuleSubtreeStream(adaptor,"rule number");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:214:2: ( number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:214:4: number ( unit )?
            {
            	PushFollow(FOLLOW_number_in_numberunit782);
            	number61 = number();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_number.Add(number61.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:214:11: ( unit )?
            	int alt19 = 2;
            	int LA19_0 = input.LA(1);

            	if ( ((LA19_0 >= 50 && LA19_0 <= 55)) )
            	{
            	    alt19 = 1;
            	}
            	switch (alt19) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:214:11: unit
            	        {
            	        	PushFollow(FOLLOW_unit_in_numberunit784);
            	        	unit62 = unit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_unit.Add(unit62.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          number, unit
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 214:17: -> ^( IM_NUMBERUNIT number ( unit )? )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:214:20: ^( IM_NUMBERUNIT number ( unit )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NUMBERUNIT, "IM_NUMBERUNIT"), root_1);

            	    adaptor.AddChild(root_1, stream_number.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:214:43: ( unit )?
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:218:1: number : ( FLOAT_WO_EXP | INT ) ;
    public simpletikzParser.number_return number() // throws RecognitionException [1]
    {   
        simpletikzParser.number_return retval = new simpletikzParser.number_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set63 = null;

        object set63_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:219:2: ( ( FLOAT_WO_EXP | INT ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:219:4: ( FLOAT_WO_EXP | INT )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set63 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= FLOAT_WO_EXP && input.LA(1) <= INT) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set63));
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:222:1: unit : ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' | 'em' );
    public simpletikzParser.unit_return unit() // throws RecognitionException [1]
    {   
        simpletikzParser.unit_return retval = new simpletikzParser.unit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set64 = null;

        object set64_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:223:2: ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' | 'em' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set64 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 50 && input.LA(1) <= 55) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set64));
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:226:1: tikz_set : tikz_set_start ( option ( ',' option )* )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) ;
    public simpletikzParser.tikz_set_return tikz_set() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_set_return retval = new simpletikzParser.tikz_set_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal67 = null;
        simpletikzParser.tikz_set_start_return tikz_set_start65 = default(simpletikzParser.tikz_set_start_return);

        simpletikzParser.option_return option66 = default(simpletikzParser.option_return);

        simpletikzParser.option_return option68 = default(simpletikzParser.option_return);

        simpletikzParser.roundbr_end_return roundbr_end69 = default(simpletikzParser.roundbr_end_return);


        object char_literal67_tree=null;
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleSubtreeStream stream_tikz_set_start = new RewriteRuleSubtreeStream(adaptor,"rule tikz_set_start");
        RewriteRuleSubtreeStream stream_roundbr_end = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        RewriteRuleSubtreeStream stream_option = new RewriteRuleSubtreeStream(adaptor,"rule option");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:227:2: ( tikz_set_start ( option ( ',' option )* )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:227:5: tikz_set_start ( option ( ',' option )* )? roundbr_end
            {
            	PushFollow(FOLLOW_tikz_set_start_in_tikz_set865);
            	tikz_set_start65 = tikz_set_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikz_set_start.Add(tikz_set_start65.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:227:20: ( option ( ',' option )* )?
            	int alt21 = 2;
            	int LA21_0 = input.LA(1);

            	if ( ((LA21_0 >= IM_PATH && LA21_0 <= 38) || (LA21_0 >= 50 && LA21_0 <= 76)) )
            	{
            	    alt21 = 1;
            	}
            	switch (alt21) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:227:21: option ( ',' option )*
            	        {
            	        	PushFollow(FOLLOW_option_in_tikz_set868);
            	        	option66 = option();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_option.Add(option66.Tree);
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:227:28: ( ',' option )*
            	        	do 
            	        	{
            	        	    int alt20 = 2;
            	        	    int LA20_0 = input.LA(1);

            	        	    if ( (LA20_0 == 42) )
            	        	    {
            	        	        alt20 = 1;
            	        	    }


            	        	    switch (alt20) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:227:29: ',' option
            	        			    {
            	        			    	char_literal67=(IToken)Match(input,42,FOLLOW_42_in_tikz_set871); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_42.Add(char_literal67);

            	        			    	PushFollow(FOLLOW_option_in_tikz_set873);
            	        			    	option68 = option();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( (state.backtracking==0) ) stream_option.Add(option68.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop20;
            	        	    }
            	        	} while (true);

            	        	loop20:
            	        		;	// Stops C# compiler whining that label 'loop20' has no statements


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_roundbr_end_in_tikz_set879);
            	roundbr_end69 = roundbr_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_roundbr_end.Add(roundbr_end69.Tree);


            	// AST REWRITE
            	// elements:          roundbr_end, option, tikz_set_start
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 227:56: -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:227:59: ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_TIKZSET, "IM_TIKZSET"), root_1);

            	    adaptor.AddChild(root_1, stream_tikz_set_start.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:227:87: ( option )*
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:232:1: tikzpicture : tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) ;
    public simpletikzParser.tikzpicture_return tikzpicture() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_return retval = new simpletikzParser.tikzpicture_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzpicture_start_return tikzpicture_start70 = default(simpletikzParser.tikzpicture_start_return);

        simpletikzParser.tikz_options_return tikz_options71 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody_return tikzbody72 = default(simpletikzParser.tikzbody_return);

        simpletikzParser.tikzpicture_end_return tikzpicture_end73 = default(simpletikzParser.tikzpicture_end_return);


        RewriteRuleSubtreeStream stream_tikzpicture_end = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_end");
        RewriteRuleSubtreeStream stream_tikzpicture_start = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_start");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:233:2: ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:233:5: tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end
            {
            	PushFollow(FOLLOW_tikzpicture_start_in_tikzpicture907);
            	tikzpicture_start70 = tikzpicture_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzpicture_start.Add(tikzpicture_start70.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:233:23: ( tikz_options )?
            	int alt22 = 2;
            	int LA22_0 = input.LA(1);

            	if ( (LA22_0 == 47) )
            	{
            	    alt22 = 1;
            	}
            	switch (alt22) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:233:23: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_tikzpicture909);
            	        	tikz_options71 = tikz_options();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_tikz_options.Add(tikz_options71.Tree);

            	        }
            	        break;

            	}

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:233:37: ( tikzbody )?
            	int alt23 = 2;
            	int LA23_0 = input.LA(1);

            	if ( ((LA23_0 >= IM_PATH && LA23_0 <= 46) || (LA23_0 >= 48 && LA23_0 <= 55) || (LA23_0 >= 57 && LA23_0 <= 76)) )
            	{
            	    alt23 = 1;
            	}
            	else if ( (LA23_0 == 56) )
            	{
            	    int LA23_2 = input.LA(2);

            	    if ( (LA23_2 == 39) )
            	    {
            	        int LA23_3 = input.LA(3);

            	        if ( (LA23_3 == ID) )
            	        {
            	            alt23 = 1;
            	        }
            	    }
            	}
            	switch (alt23) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:233:37: tikzbody
            	        {
            	        	PushFollow(FOLLOW_tikzbody_in_tikzpicture912);
            	        	tikzbody72 = tikzbody();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_tikzbody.Add(tikzbody72.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzpicture_end_in_tikzpicture915);
            	tikzpicture_end73 = tikzpicture_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzpicture_end.Add(tikzpicture_end73.Tree);


            	// AST REWRITE
            	// elements:          tikz_options, tikzpicture_end, tikzbody, tikzpicture_start
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 233:64: -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:233:67: ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PICTURE, "IM_PICTURE"), root_1);

            	    adaptor.AddChild(root_1, stream_tikzpicture_start.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:233:98: ( tikz_options )?
            	    if ( stream_tikz_options.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikz_options.NextTree());

            	    }
            	    stream_tikz_options.Reset();
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:233:112: ( tikzbody )?
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:236:1: tikzbody : ( tikzscope | tikzpath | tikznode_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )* ;
    public simpletikzParser.tikzbody_return tikzbody() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzbody_return retval = new simpletikzParser.tikzbody_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_return tikzscope74 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath75 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznode_ext_return tikznode_ext76 = default(simpletikzParser.tikznode_ext_return);

        simpletikzParser.tikz_set_return tikz_set77 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style78 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin79 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend80 = default(simpletikzParser.otherend_return);

        simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr81 = default(simpletikzParser.dontcare_body_nobr_return);

        simpletikzParser.tikzscope_return tikzscope82 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath83 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznode_ext_return tikznode_ext84 = default(simpletikzParser.tikznode_ext_return);

        simpletikzParser.tikz_set_return tikz_set85 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style86 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin87 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend88 = default(simpletikzParser.otherend_return);

        simpletikzParser.dontcare_body_return dontcare_body89 = default(simpletikzParser.dontcare_body_return);



        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:237:2: ( ( tikzscope | tikzpath | tikznode_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )* )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:237:4: ( tikzscope | tikzpath | tikznode_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:237:4: ( tikzscope | tikzpath | tikznode_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr )
            	int alt24 = 8;
            	alt24 = dfa24.Predict(input);
            	switch (alt24) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:237:6: tikzscope
            	        {
            	        	PushFollow(FOLLOW_tikzscope_in_tikzbody945);
            	        	tikzscope74 = tikzscope();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzscope74.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:237:18: tikzpath
            	        {
            	        	PushFollow(FOLLOW_tikzpath_in_tikzbody949);
            	        	tikzpath75 = tikzpath();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath75.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:237:29: tikznode_ext
            	        {
            	        	PushFollow(FOLLOW_tikznode_ext_in_tikzbody953);
            	        	tikznode_ext76 = tikznode_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_ext76.Tree);

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:237:44: tikz_set
            	        {
            	        	PushFollow(FOLLOW_tikz_set_in_tikzbody957);
            	        	tikz_set77 = tikz_set();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set77.Tree);

            	        }
            	        break;
            	    case 5 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:237:55: tikz_style
            	        {
            	        	PushFollow(FOLLOW_tikz_style_in_tikzbody961);
            	        	tikz_style78 = tikz_style();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style78.Tree);

            	        }
            	        break;
            	    case 6 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:237:68: otherbegin
            	        {
            	        	PushFollow(FOLLOW_otherbegin_in_tikzbody965);
            	        	otherbegin79 = otherbegin();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;
            	    case 7 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:237:82: otherend
            	        {
            	        	PushFollow(FOLLOW_otherend_in_tikzbody970);
            	        	otherend80 = otherend();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;
            	    case 8 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:237:94: dontcare_body_nobr
            	        {
            	        	PushFollow(FOLLOW_dontcare_body_nobr_in_tikzbody975);
            	        	dontcare_body_nobr81 = dontcare_body_nobr();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;

            	}

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:238:3: ( tikzscope | tikzpath | tikznode_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*
            	do 
            	{
            	    int alt25 = 9;
            	    alt25 = dfa25.Predict(input);
            	    switch (alt25) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:238:5: tikzscope
            			    {
            			    	PushFollow(FOLLOW_tikzscope_in_tikzbody986);
            			    	tikzscope82 = tikzscope();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzscope82.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:238:17: tikzpath
            			    {
            			    	PushFollow(FOLLOW_tikzpath_in_tikzbody990);
            			    	tikzpath83 = tikzpath();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath83.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:238:28: tikznode_ext
            			    {
            			    	PushFollow(FOLLOW_tikznode_ext_in_tikzbody994);
            			    	tikznode_ext84 = tikznode_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_ext84.Tree);

            			    }
            			    break;
            			case 4 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:238:43: tikz_set
            			    {
            			    	PushFollow(FOLLOW_tikz_set_in_tikzbody998);
            			    	tikz_set85 = tikz_set();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set85.Tree);

            			    }
            			    break;
            			case 5 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:238:54: tikz_style
            			    {
            			    	PushFollow(FOLLOW_tikz_style_in_tikzbody1002);
            			    	tikz_style86 = tikz_style();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style86.Tree);

            			    }
            			    break;
            			case 6 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:238:67: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzbody1006);
            			    	otherbegin87 = otherbegin();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;
            			case 7 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:238:81: otherend
            			    {
            			    	PushFollow(FOLLOW_otherend_in_tikzbody1011);
            			    	otherend88 = otherend();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;
            			case 8 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:238:93: dontcare_body
            			    {
            			    	PushFollow(FOLLOW_dontcare_body_in_tikzbody1016);
            			    	dontcare_body89 = dontcare_body();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop25;
            	    }
            	} while (true);

            	loop25:
            		;	// Stops C# compiler whining that label 'loop25' has no statements


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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:241:1: dontcare_body_nobr : (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) ) ;
    public simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body_nobr_return retval = new simpletikzParser.dontcare_body_nobr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set90 = null;

        object set90_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:242:2: ( (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:242:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:242:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) )
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:242:5: ~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' )
            	{
            		set90 = (IToken)input.LT(1);
            		if ( (input.LA(1) >= IM_PATH && input.LA(1) <= SOMETHING) || (input.LA(1) >= 39 && input.LA(1) <= 46) || (input.LA(1) >= 48 && input.LA(1) <= 55) || (input.LA(1) >= 63 && input.LA(1) <= 76) ) 
            		{
            		    input.Consume();
            		    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set90));
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:244:1: dontcare_body : (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) ) ;
    public simpletikzParser.dontcare_body_return dontcare_body() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body_return retval = new simpletikzParser.dontcare_body_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set91 = null;

        object set91_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:245:2: ( (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:245:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:245:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) )
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:245:5: ~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' )
            	{
            		set91 = (IToken)input.LT(1);
            		if ( (input.LA(1) >= IM_PATH && input.LA(1) <= SOMETHING) || (input.LA(1) >= 39 && input.LA(1) <= 55) || (input.LA(1) >= 63 && input.LA(1) <= 76) ) 
            		{
            		    input.Consume();
            		    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set91));
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:247:1: otherend : '\\\\end' '{' idd2 '}' ;
    public simpletikzParser.otherend_return otherend() // throws RecognitionException [1]
    {   
        simpletikzParser.otherend_return retval = new simpletikzParser.otherend_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal92 = null;
        IToken char_literal93 = null;
        IToken char_literal95 = null;
        simpletikzParser.idd2_return idd294 = default(simpletikzParser.idd2_return);


        object string_literal92_tree=null;
        object char_literal93_tree=null;
        object char_literal95_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:248:2: ( '\\\\end' '{' idd2 '}' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:248:4: '\\\\end' '{' idd2 '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal92=(IToken)Match(input,56,FOLLOW_56_in_otherend1146); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal92_tree = (object)adaptor.Create(string_literal92);
            		adaptor.AddChild(root_0, string_literal92_tree);
            	}
            	char_literal93=(IToken)Match(input,39,FOLLOW_39_in_otherend1148); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal93_tree = (object)adaptor.Create(char_literal93);
            		adaptor.AddChild(root_0, char_literal93_tree);
            	}
            	PushFollow(FOLLOW_idd2_in_otherend1150);
            	idd294 = idd2();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idd294.Tree);
            	char_literal95=(IToken)Match(input,40,FOLLOW_40_in_otherend1152); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal95_tree = (object)adaptor.Create(char_literal95);
            		adaptor.AddChild(root_0, char_literal95_tree);
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:262:1: tikzscope : tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end ) ;
    public simpletikzParser.tikzscope_return tikzscope() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_return retval = new simpletikzParser.tikzscope_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_start_return tikzscope_start96 = default(simpletikzParser.tikzscope_start_return);

        simpletikzParser.tikz_options_return tikz_options97 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody_return tikzbody98 = default(simpletikzParser.tikzbody_return);

        simpletikzParser.tikzscope_end_return tikzscope_end99 = default(simpletikzParser.tikzscope_end_return);


        RewriteRuleSubtreeStream stream_tikzscope_start = new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_start");
        RewriteRuleSubtreeStream stream_tikzscope_end = new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_end");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:263:2: ( tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:263:4: tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end
            {
            	PushFollow(FOLLOW_tikzscope_start_in_tikzscope1179);
            	tikzscope_start96 = tikzscope_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzscope_start.Add(tikzscope_start96.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:263:20: ( tikz_options )?
            	int alt26 = 2;
            	int LA26_0 = input.LA(1);

            	if ( (LA26_0 == 47) )
            	{
            	    alt26 = 1;
            	}
            	switch (alt26) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:263:20: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_tikzscope1181);
            	        	tikz_options97 = tikz_options();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_tikz_options.Add(tikz_options97.Tree);

            	        }
            	        break;

            	}

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:263:34: ( tikzbody )?
            	int alt27 = 2;
            	int LA27_0 = input.LA(1);

            	if ( ((LA27_0 >= IM_PATH && LA27_0 <= 46) || (LA27_0 >= 48 && LA27_0 <= 55) || (LA27_0 >= 57 && LA27_0 <= 76)) )
            	{
            	    alt27 = 1;
            	}
            	else if ( (LA27_0 == 56) )
            	{
            	    int LA27_2 = input.LA(2);

            	    if ( (LA27_2 == 39) )
            	    {
            	        int LA27_3 = input.LA(3);

            	        if ( (LA27_3 == ID) )
            	        {
            	            alt27 = 1;
            	        }
            	    }
            	}
            	switch (alt27) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:263:34: tikzbody
            	        {
            	        	PushFollow(FOLLOW_tikzbody_in_tikzscope1184);
            	        	tikzbody98 = tikzbody();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_tikzbody.Add(tikzbody98.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzscope_end_in_tikzscope1187);
            	tikzscope_end99 = tikzscope_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzscope_end.Add(tikzscope_end99.Tree);


            	// AST REWRITE
            	// elements:          tikzbody, tikzscope_end, tikzscope_start, tikz_options
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 263:59: -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:263:62: ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_SCOPE, "IM_SCOPE"), root_1);

            	    adaptor.AddChild(root_1, stream_tikzscope_start.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:263:89: ( tikz_options )?
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:289:1: tikzpath : path_start ( tikzpath_element )* semicolon_end -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikzpath_return tikzpath() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_return retval = new simpletikzParser.tikzpath_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.path_start_return path_start100 = default(simpletikzParser.path_start_return);

        simpletikzParser.tikzpath_element_return tikzpath_element101 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end102 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_path_start = new RewriteRuleSubtreeStream(adaptor,"rule path_start");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:290:2: ( path_start ( tikzpath_element )* semicolon_end -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:290:4: path_start ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_path_start_in_tikzpath1242);
            	path_start100 = path_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_path_start.Add(path_start100.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:290:15: ( tikzpath_element )*
            	do 
            	{
            	    int alt28 = 2;
            	    int LA28_0 = input.LA(1);

            	    if ( (LA28_0 == ID || LA28_0 == 39 || LA28_0 == 45 || LA28_0 == 47 || LA28_0 == 63 || (LA28_0 >= 65 && LA28_0 <= 67) || (LA28_0 >= 69 && LA28_0 <= 74)) )
            	    {
            	        alt28 = 1;
            	    }


            	    switch (alt28) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:290:15: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath1244);
            			    	tikzpath_element101 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element101.Tree);

            			    }
            			    break;

            			default:
            			    goto loop28;
            	    }
            	} while (true);

            	loop28:
            		;	// Stops C# compiler whining that label 'loop28' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikzpath1247);
            	semicolon_end102 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_semicolon_end.Add(semicolon_end102.Tree);


            	// AST REWRITE
            	// elements:          tikzpath_element, path_start, semicolon_end
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 290:47: -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:290:50: ^( IM_PATH path_start ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_path_start.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:290:71: ( tikzpath_element )*
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:293:1: tikzpath_element : ( tikz_options | coord | tikznode_int | circle | arc | roundbr_start ( tikzpath_element )* roundbr_end -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end ) | edgeop );
    public simpletikzParser.tikzpath_element_return tikzpath_element() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_element_return retval = new simpletikzParser.tikzpath_element_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikz_options_return tikz_options103 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.coord_return coord104 = default(simpletikzParser.coord_return);

        simpletikzParser.tikznode_int_return tikznode_int105 = default(simpletikzParser.tikznode_int_return);

        simpletikzParser.circle_return circle106 = default(simpletikzParser.circle_return);

        simpletikzParser.arc_return arc107 = default(simpletikzParser.arc_return);

        simpletikzParser.roundbr_start_return roundbr_start108 = default(simpletikzParser.roundbr_start_return);

        simpletikzParser.tikzpath_element_return tikzpath_element109 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.roundbr_end_return roundbr_end110 = default(simpletikzParser.roundbr_end_return);

        simpletikzParser.edgeop_return edgeop111 = default(simpletikzParser.edgeop_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_roundbr_start = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_start");
        RewriteRuleSubtreeStream stream_roundbr_end = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:294:2: ( tikz_options | coord | tikznode_int | circle | arc | roundbr_start ( tikzpath_element )* roundbr_end -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end ) | edgeop )
            int alt30 = 7;
            switch ( input.LA(1) ) 
            {
            case 47:
            	{
                alt30 = 1;
                }
                break;
            case 45:
            case 73:
            case 74:
            	{
                alt30 = 2;
                }
                break;
            case 63:
            	{
                alt30 = 3;
                }
                break;
            case 65:
            case 66:
            	{
                alt30 = 4;
                }
                break;
            case 67:
            	{
                alt30 = 5;
                }
                break;
            case 39:
            	{
                alt30 = 6;
                }
                break;
            case ID:
            case 69:
            case 70:
            case 71:
            case 72:
            	{
                alt30 = 7;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d30s0 =
            	        new NoViableAltException("", 30, 0, input);

            	    throw nvae_d30s0;
            }

            switch (alt30) 
            {
                case 1 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:295:5: tikz_options
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_options_in_tikzpath_element1276);
                    	tikz_options103 = tikz_options();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_options103.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:296:5: coord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_coord_in_tikzpath_element1283);
                    	coord104 = coord();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, coord104.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:297:5: tikznode_int
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikznode_int_in_tikzpath_element1289);
                    	tikznode_int105 = tikznode_int();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_int105.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:298:5: circle
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_circle_in_tikzpath_element1295);
                    	circle106 = circle();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;

                    }
                    break;
                case 5 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:299:5: arc
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arc_in_tikzpath_element1302);
                    	arc107 = arc();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;

                    }
                    break;
                case 6 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:300:5: roundbr_start ( tikzpath_element )* roundbr_end
                    {
                    	PushFollow(FOLLOW_roundbr_start_in_tikzpath_element1309);
                    	roundbr_start108 = roundbr_start();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_roundbr_start.Add(roundbr_start108.Tree);
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:300:19: ( tikzpath_element )*
                    	do 
                    	{
                    	    int alt29 = 2;
                    	    int LA29_0 = input.LA(1);

                    	    if ( (LA29_0 == ID || LA29_0 == 39 || LA29_0 == 45 || LA29_0 == 47 || LA29_0 == 63 || (LA29_0 >= 65 && LA29_0 <= 67) || (LA29_0 >= 69 && LA29_0 <= 74)) )
                    	    {
                    	        alt29 = 1;
                    	    }


                    	    switch (alt29) 
                    		{
                    			case 1 :
                    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:300:19: tikzpath_element
                    			    {
                    			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath_element1311);
                    			    	tikzpath_element109 = tikzpath_element();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element109.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop29;
                    	    }
                    	} while (true);

                    	loop29:
                    		;	// Stops C# compiler whining that label 'loop29' has no statements

                    	PushFollow(FOLLOW_roundbr_end_in_tikzpath_element1314);
                    	roundbr_end110 = roundbr_end();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_roundbr_end.Add(roundbr_end110.Tree);


                    	// AST REWRITE
                    	// elements:          tikzpath_element, roundbr_start, roundbr_end
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 300:49: -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end )
                    	{
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:300:52: ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

                    	    adaptor.AddChild(root_1, stream_roundbr_start.NextTree());
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:300:76: ( tikzpath_element )*
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
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:301:5: edgeop
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_edgeop_in_tikzpath_element1333);
                    	edgeop111 = edgeop();
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:303:1: tikznode_ext : node_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikznode_ext_return tikznode_ext() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_ext_return retval = new simpletikzParser.tikznode_ext_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.node_start_return node_start112 = default(simpletikzParser.node_start_return);

        simpletikzParser.tikznode_core_return tikznode_core113 = default(simpletikzParser.tikznode_core_return);

        simpletikzParser.tikzpath_element_return tikzpath_element114 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end115 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_node_start = new RewriteRuleSubtreeStream(adaptor,"rule node_start");
        RewriteRuleSubtreeStream stream_tikznode_core = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_core");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:304:2: ( node_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:304:4: node_start tikznode_core ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_node_start_in_tikznode_ext1344);
            	node_start112 = node_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_node_start.Add(node_start112.Tree);
            	PushFollow(FOLLOW_tikznode_core_in_tikznode_ext1346);
            	tikznode_core113 = tikznode_core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_core.Add(tikznode_core113.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:304:29: ( tikzpath_element )*
            	do 
            	{
            	    int alt31 = 2;
            	    int LA31_0 = input.LA(1);

            	    if ( (LA31_0 == ID || LA31_0 == 39 || LA31_0 == 45 || LA31_0 == 47 || LA31_0 == 63 || (LA31_0 >= 65 && LA31_0 <= 67) || (LA31_0 >= 69 && LA31_0 <= 74)) )
            	    {
            	        alt31 = 1;
            	    }


            	    switch (alt31) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:304:29: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikznode_ext1348);
            			    	tikzpath_element114 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element114.Tree);

            			    }
            			    break;

            			default:
            			    goto loop31;
            	    }
            	} while (true);

            	loop31:
            		;	// Stops C# compiler whining that label 'loop31' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikznode_ext1351);
            	semicolon_end115 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_semicolon_end.Add(semicolon_end115.Tree);


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
            	// 304:61: -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:304:64: ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_node_start.NextTree());
            	    adaptor.AddChild(root_1, stream_tikznode_core.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:304:99: ( tikzpath_element )*
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:306:1: tikznode_int : 'node' tikznode_core ;
    public simpletikzParser.tikznode_int_return tikznode_int() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_int_return retval = new simpletikzParser.tikznode_int_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal116 = null;
        simpletikzParser.tikznode_core_return tikznode_core117 = default(simpletikzParser.tikznode_core_return);


        object string_literal116_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:307:2: ( 'node' tikznode_core )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:307:4: 'node' tikznode_core
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal116=(IToken)Match(input,63,FOLLOW_63_in_tikznode_int1376); if (state.failed) return retval;
            	PushFollow(FOLLOW_tikznode_core_in_tikznode_int1379);
            	tikznode_core117 = tikznode_core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_core117.Tree);

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:309:1: tikznode_core : ( tikznode_decorator )* tikzstring -> ^( IM_NODE ( tikznode_decorator )* tikzstring ) ;
    public simpletikzParser.tikznode_core_return tikznode_core() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_core_return retval = new simpletikzParser.tikznode_core_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator118 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikzstring_return tikzstring119 = default(simpletikzParser.tikzstring_return);


        RewriteRuleSubtreeStream stream_tikzstring = new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:310:2: ( ( tikznode_decorator )* tikzstring -> ^( IM_NODE ( tikznode_decorator )* tikzstring ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:310:4: ( tikznode_decorator )* tikzstring
            {
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:310:4: ( tikznode_decorator )*
            	do 
            	{
            	    int alt32 = 2;
            	    int LA32_0 = input.LA(1);

            	    if ( (LA32_0 == 45 || LA32_0 == 47 || LA32_0 == 64) )
            	    {
            	        alt32 = 1;
            	    }


            	    switch (alt32) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:310:4: tikznode_decorator
            			    {
            			    	PushFollow(FOLLOW_tikznode_decorator_in_tikznode_core1389);
            			    	tikznode_decorator118 = tikznode_decorator();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator118.Tree);

            			    }
            			    break;

            			default:
            			    goto loop32;
            	    }
            	} while (true);

            	loop32:
            		;	// Stops C# compiler whining that label 'loop32' has no statements

            	PushFollow(FOLLOW_tikzstring_in_tikznode_core1392);
            	tikzstring119 = tikzstring();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzstring.Add(tikzstring119.Tree);


            	// AST REWRITE
            	// elements:          tikznode_decorator, tikzstring
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 310:36: -> ^( IM_NODE ( tikznode_decorator )* tikzstring )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:310:39: ^( IM_NODE ( tikznode_decorator )* tikzstring )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NODE, "IM_NODE"), root_1);

            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:310:49: ( tikznode_decorator )*
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:315:1: tikznode_decorator : ( nodename | 'at' coord | tikz_options_dontcare );
    public simpletikzParser.tikznode_decorator_return tikznode_decorator() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_decorator_return retval = new simpletikzParser.tikznode_decorator_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal121 = null;
        simpletikzParser.nodename_return nodename120 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_return coord122 = default(simpletikzParser.coord_return);

        simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare123 = default(simpletikzParser.tikz_options_dontcare_return);


        object string_literal121_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:316:2: ( nodename | 'at' coord | tikz_options_dontcare )
            int alt33 = 3;
            switch ( input.LA(1) ) 
            {
            case 45:
            	{
                alt33 = 1;
                }
                break;
            case 64:
            	{
                alt33 = 2;
                }
                break;
            case 47:
            	{
                alt33 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d33s0 =
            	        new NoViableAltException("", 33, 0, input);

            	    throw nvae_d33s0;
            }

            switch (alt33) 
            {
                case 1 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:316:6: nodename
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_nodename_in_tikznode_decorator1419);
                    	nodename120 = nodename();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, nodename120.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:317:5: 'at' coord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal121=(IToken)Match(input,64,FOLLOW_64_in_tikznode_decorator1426); if (state.failed) return retval;
                    	PushFollow(FOLLOW_coord_in_tikznode_decorator1429);
                    	coord122 = coord();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, coord122.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:318:5: tikz_options_dontcare
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_options_dontcare_in_tikznode_decorator1435);
                    	tikz_options_dontcare123 = tikz_options_dontcare();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_options_dontcare123.Tree);

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:320:1: tikz_options_dontcare : '[' ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* ']' -> ^( IM_OPTIONS ) ;
    public simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_options_dontcare_return retval = new simpletikzParser.tikz_options_dontcare_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal124 = null;
        IToken char_literal128 = null;
        simpletikzParser.no_rlbracket_return no_rlbracket125 = default(simpletikzParser.no_rlbracket_return);

        simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare126 = default(simpletikzParser.tikz_options_dontcare_return);

        simpletikzParser.no_rlbracket_return no_rlbracket127 = default(simpletikzParser.no_rlbracket_return);


        object char_literal124_tree=null;
        object char_literal128_tree=null;
        RewriteRuleTokenStream stream_48 = new RewriteRuleTokenStream(adaptor,"token 48");
        RewriteRuleTokenStream stream_47 = new RewriteRuleTokenStream(adaptor,"token 47");
        RewriteRuleSubtreeStream stream_tikz_options_dontcare = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options_dontcare");
        RewriteRuleSubtreeStream stream_no_rlbracket = new RewriteRuleSubtreeStream(adaptor,"rule no_rlbracket");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:321:2: ( '[' ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* ']' -> ^( IM_OPTIONS ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:321:4: '[' ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* ']'
            {
            	char_literal124=(IToken)Match(input,47,FOLLOW_47_in_tikz_options_dontcare1445); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_47.Add(char_literal124);

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:321:8: ( no_rlbracket )*
            	do 
            	{
            	    int alt34 = 2;
            	    int LA34_0 = input.LA(1);

            	    if ( ((LA34_0 >= IM_PATH && LA34_0 <= 46) || (LA34_0 >= 49 && LA34_0 <= 76)) )
            	    {
            	        alt34 = 1;
            	    }


            	    switch (alt34) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:321:8: no_rlbracket
            			    {
            			    	PushFollow(FOLLOW_no_rlbracket_in_tikz_options_dontcare1447);
            			    	no_rlbracket125 = no_rlbracket();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_no_rlbracket.Add(no_rlbracket125.Tree);

            			    }
            			    break;

            			default:
            			    goto loop34;
            	    }
            	} while (true);

            	loop34:
            		;	// Stops C# compiler whining that label 'loop34' has no statements

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:321:22: ( tikz_options_dontcare ( no_rlbracket )* )*
            	do 
            	{
            	    int alt36 = 2;
            	    int LA36_0 = input.LA(1);

            	    if ( (LA36_0 == 47) )
            	    {
            	        alt36 = 1;
            	    }


            	    switch (alt36) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:321:23: tikz_options_dontcare ( no_rlbracket )*
            			    {
            			    	PushFollow(FOLLOW_tikz_options_dontcare_in_tikz_options_dontcare1451);
            			    	tikz_options_dontcare126 = tikz_options_dontcare();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikz_options_dontcare.Add(tikz_options_dontcare126.Tree);
            			    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:321:45: ( no_rlbracket )*
            			    	do 
            			    	{
            			    	    int alt35 = 2;
            			    	    int LA35_0 = input.LA(1);

            			    	    if ( ((LA35_0 >= IM_PATH && LA35_0 <= 46) || (LA35_0 >= 49 && LA35_0 <= 76)) )
            			    	    {
            			    	        alt35 = 1;
            			    	    }


            			    	    switch (alt35) 
            			    		{
            			    			case 1 :
            			    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:321:45: no_rlbracket
            			    			    {
            			    			    	PushFollow(FOLLOW_no_rlbracket_in_tikz_options_dontcare1453);
            			    			    	no_rlbracket127 = no_rlbracket();
            			    			    	state.followingStackPointer--;
            			    			    	if (state.failed) return retval;
            			    			    	if ( (state.backtracking==0) ) stream_no_rlbracket.Add(no_rlbracket127.Tree);

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop35;
            			    	    }
            			    	} while (true);

            			    	loop35:
            			    		;	// Stops C# compiler whining that label 'loop35' has no statements


            			    }
            			    break;

            			default:
            			    goto loop36;
            	    }
            	} while (true);

            	loop36:
            		;	// Stops C# compiler whining that label 'loop36' has no statements

            	char_literal128=(IToken)Match(input,48,FOLLOW_48_in_tikz_options_dontcare1458); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_48.Add(char_literal128);



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
            	// 321:65: -> ^( IM_OPTIONS )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:321:68: ^( IM_OPTIONS )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:323:1: no_rlbracket : ~ ( '[' | ']' ) ;
    public simpletikzParser.no_rlbracket_return no_rlbracket() // throws RecognitionException [1]
    {   
        simpletikzParser.no_rlbracket_return retval = new simpletikzParser.no_rlbracket_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set129 = null;

        object set129_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:324:2: (~ ( '[' | ']' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:324:4: ~ ( '[' | ']' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set129 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= 46) || (input.LA(1) >= 49 && input.LA(1) <= 76) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set129));
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:326:1: nodename : '(' idd ')' -> ^( IM_NODENAME idd ) ;
    public simpletikzParser.nodename_return nodename() // throws RecognitionException [1]
    {   
        simpletikzParser.nodename_return retval = new simpletikzParser.nodename_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal130 = null;
        IToken char_literal132 = null;
        simpletikzParser.idd_return idd131 = default(simpletikzParser.idd_return);


        object char_literal130_tree=null;
        object char_literal132_tree=null;
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_46 = new RewriteRuleTokenStream(adaptor,"token 46");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:327:2: ( '(' idd ')' -> ^( IM_NODENAME idd ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:327:4: '(' idd ')'
            {
            	char_literal130=(IToken)Match(input,45,FOLLOW_45_in_nodename1493); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_45.Add(char_literal130);

            	PushFollow(FOLLOW_idd_in_nodename1495);
            	idd131 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idd.Add(idd131.Tree);
            	char_literal132=(IToken)Match(input,46,FOLLOW_46_in_nodename1497); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_46.Add(char_literal132);



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
            	// 327:17: -> ^( IM_NODENAME idd )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:327:20: ^( IM_NODENAME idd )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:333:1: circle : ( 'circle' | 'ellipse' ) ( ( size )=> size )? ->;
    public simpletikzParser.circle_return circle() // throws RecognitionException [1]
    {   
        simpletikzParser.circle_return retval = new simpletikzParser.circle_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal133 = null;
        IToken string_literal134 = null;
        simpletikzParser.size_return size135 = default(simpletikzParser.size_return);


        object string_literal133_tree=null;
        object string_literal134_tree=null;
        RewriteRuleTokenStream stream_66 = new RewriteRuleTokenStream(adaptor,"token 66");
        RewriteRuleTokenStream stream_65 = new RewriteRuleTokenStream(adaptor,"token 65");
        RewriteRuleSubtreeStream stream_size = new RewriteRuleSubtreeStream(adaptor,"rule size");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:334:2: ( ( 'circle' | 'ellipse' ) ( ( size )=> size )? ->)
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:334:4: ( 'circle' | 'ellipse' ) ( ( size )=> size )?
            {
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:334:4: ( 'circle' | 'ellipse' )
            	int alt37 = 2;
            	int LA37_0 = input.LA(1);

            	if ( (LA37_0 == 65) )
            	{
            	    alt37 = 1;
            	}
            	else if ( (LA37_0 == 66) )
            	{
            	    alt37 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d37s0 =
            	        new NoViableAltException("", 37, 0, input);

            	    throw nvae_d37s0;
            	}
            	switch (alt37) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:334:5: 'circle'
            	        {
            	        	string_literal133=(IToken)Match(input,65,FOLLOW_65_in_circle1521); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_65.Add(string_literal133);


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:334:16: 'ellipse'
            	        {
            	        	string_literal134=(IToken)Match(input,66,FOLLOW_66_in_circle1525); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_66.Add(string_literal134);


            	        }
            	        break;

            	}

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:334:27: ( ( size )=> size )?
            	int alt38 = 2;
            	alt38 = dfa38.Predict(input);
            	switch (alt38) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:334:28: ( size )=> size
            	        {
            	        	PushFollow(FOLLOW_size_in_circle1534);
            	        	size135 = size();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_size.Add(size135.Tree);

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
            	// 334:44: ->
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:336:1: arc : 'arc' ( '(' numberunit ':' numberunit ':' numberunit ')' )? ->;
    public simpletikzParser.arc_return arc() // throws RecognitionException [1]
    {   
        simpletikzParser.arc_return retval = new simpletikzParser.arc_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal136 = null;
        IToken char_literal137 = null;
        IToken char_literal139 = null;
        IToken char_literal141 = null;
        IToken char_literal143 = null;
        simpletikzParser.numberunit_return numberunit138 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit140 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit142 = default(simpletikzParser.numberunit_return);


        object string_literal136_tree=null;
        object char_literal137_tree=null;
        object char_literal139_tree=null;
        object char_literal141_tree=null;
        object char_literal143_tree=null;
        RewriteRuleTokenStream stream_67 = new RewriteRuleTokenStream(adaptor,"token 67");
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_46 = new RewriteRuleTokenStream(adaptor,"token 46");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:337:2: ( 'arc' ( '(' numberunit ':' numberunit ':' numberunit ')' )? ->)
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:337:4: 'arc' ( '(' numberunit ':' numberunit ':' numberunit ')' )?
            {
            	string_literal136=(IToken)Match(input,67,FOLLOW_67_in_arc1549); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_67.Add(string_literal136);

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:337:10: ( '(' numberunit ':' numberunit ':' numberunit ')' )?
            	int alt39 = 2;
            	int LA39_0 = input.LA(1);

            	if ( (LA39_0 == 45) )
            	{
            	    int LA39_1 = input.LA(2);

            	    if ( ((LA39_1 >= FLOAT_WO_EXP && LA39_1 <= INT)) )
            	    {
            	        int LA39_3 = input.LA(3);

            	        if ( ((LA39_3 >= 50 && LA39_3 <= 55)) )
            	        {
            	            int LA39_4 = input.LA(4);

            	            if ( (LA39_4 == 43) )
            	            {
            	                int LA39_5 = input.LA(5);

            	                if ( ((LA39_5 >= FLOAT_WO_EXP && LA39_5 <= INT)) )
            	                {
            	                    int LA39_6 = input.LA(6);

            	                    if ( ((LA39_6 >= 50 && LA39_6 <= 55)) )
            	                    {
            	                        int LA39_7 = input.LA(7);

            	                        if ( (LA39_7 == 43) )
            	                        {
            	                            alt39 = 1;
            	                        }
            	                    }
            	                    else if ( (LA39_6 == 43) )
            	                    {
            	                        alt39 = 1;
            	                    }
            	                }
            	            }
            	        }
            	        else if ( (LA39_3 == 43) )
            	        {
            	            int LA39_5 = input.LA(4);

            	            if ( ((LA39_5 >= FLOAT_WO_EXP && LA39_5 <= INT)) )
            	            {
            	                int LA39_6 = input.LA(5);

            	                if ( ((LA39_6 >= 50 && LA39_6 <= 55)) )
            	                {
            	                    int LA39_7 = input.LA(6);

            	                    if ( (LA39_7 == 43) )
            	                    {
            	                        alt39 = 1;
            	                    }
            	                }
            	                else if ( (LA39_6 == 43) )
            	                {
            	                    alt39 = 1;
            	                }
            	            }
            	        }
            	    }
            	}
            	switch (alt39) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:337:11: '(' numberunit ':' numberunit ':' numberunit ')'
            	        {
            	        	char_literal137=(IToken)Match(input,45,FOLLOW_45_in_arc1552); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_45.Add(char_literal137);

            	        	PushFollow(FOLLOW_numberunit_in_arc1554);
            	        	numberunit138 = numberunit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit138.Tree);
            	        	char_literal139=(IToken)Match(input,43,FOLLOW_43_in_arc1556); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_43.Add(char_literal139);

            	        	PushFollow(FOLLOW_numberunit_in_arc1558);
            	        	numberunit140 = numberunit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit140.Tree);
            	        	char_literal141=(IToken)Match(input,43,FOLLOW_43_in_arc1560); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_43.Add(char_literal141);

            	        	PushFollow(FOLLOW_numberunit_in_arc1562);
            	        	numberunit142 = numberunit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit142.Tree);
            	        	char_literal143=(IToken)Match(input,46,FOLLOW_46_in_arc1564); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_46.Add(char_literal143);


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
            	// 337:62: ->
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:340:1: size : '(' numberunit ( 'and' numberunit )? ')' -> ^( IM_SIZE ( numberunit )* ) ;
    public simpletikzParser.size_return size() // throws RecognitionException [1]
    {   
        simpletikzParser.size_return retval = new simpletikzParser.size_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal144 = null;
        IToken string_literal146 = null;
        IToken char_literal148 = null;
        simpletikzParser.numberunit_return numberunit145 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit147 = default(simpletikzParser.numberunit_return);


        object char_literal144_tree=null;
        object string_literal146_tree=null;
        object char_literal148_tree=null;
        RewriteRuleTokenStream stream_68 = new RewriteRuleTokenStream(adaptor,"token 68");
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_46 = new RewriteRuleTokenStream(adaptor,"token 46");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:341:2: ( '(' numberunit ( 'and' numberunit )? ')' -> ^( IM_SIZE ( numberunit )* ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:341:6: '(' numberunit ( 'and' numberunit )? ')'
            {
            	char_literal144=(IToken)Match(input,45,FOLLOW_45_in_size1582); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_45.Add(char_literal144);

            	PushFollow(FOLLOW_numberunit_in_size1584);
            	numberunit145 = numberunit();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit145.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:341:21: ( 'and' numberunit )?
            	int alt40 = 2;
            	int LA40_0 = input.LA(1);

            	if ( (LA40_0 == 68) )
            	{
            	    alt40 = 1;
            	}
            	switch (alt40) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:341:22: 'and' numberunit
            	        {
            	        	string_literal146=(IToken)Match(input,68,FOLLOW_68_in_size1587); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_68.Add(string_literal146);

            	        	PushFollow(FOLLOW_numberunit_in_size1589);
            	        	numberunit147 = numberunit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit147.Tree);

            	        }
            	        break;

            	}

            	char_literal148=(IToken)Match(input,46,FOLLOW_46_in_size1593); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_46.Add(char_literal148);



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
            	// 341:46: -> ^( IM_SIZE ( numberunit )* )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:341:49: ^( IM_SIZE ( numberunit )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_SIZE, "IM_SIZE"), root_1);

            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:341:59: ( numberunit )*
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:348:1: coord : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_DONTCARE ( coord_modifier )? ( coord_part )+ coord_sep ) );
    public simpletikzParser.coord_return coord() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_return retval = new simpletikzParser.coord_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal151 = null;
        IToken char_literal155 = null;
        IToken char_literal157 = null;
        IToken char_literal161 = null;
        simpletikzParser.nodename_return nodename149 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_modifier_return coord_modifier150 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.numberunit_return numberunit152 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_sep_return coord_sep153 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.numberunit_return numberunit154 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_modifier_return coord_modifier156 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.coord_part_return coord_part158 = default(simpletikzParser.coord_part_return);

        simpletikzParser.coord_sep_return coord_sep159 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.coord_part_return coord_part160 = default(simpletikzParser.coord_part_return);


        object char_literal151_tree=null;
        object char_literal155_tree=null;
        object char_literal157_tree=null;
        object char_literal161_tree=null;
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_46 = new RewriteRuleTokenStream(adaptor,"token 46");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_coord_part = new RewriteRuleSubtreeStream(adaptor,"rule coord_part");
        RewriteRuleSubtreeStream stream_coord_sep = new RewriteRuleSubtreeStream(adaptor,"rule coord_sep");
        RewriteRuleSubtreeStream stream_nodename = new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        RewriteRuleSubtreeStream stream_coord_modifier = new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:349:2: ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_DONTCARE ( coord_modifier )? ( coord_part )+ coord_sep ) )
            int alt43 = 3;
            alt43 = dfa43.Predict(input);
            switch (alt43) 
            {
                case 1 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:349:6: nodename
                    {
                    	PushFollow(FOLLOW_nodename_in_coord1623);
                    	nodename149 = nodename();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_nodename.Add(nodename149.Tree);


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
                    	// 349:23: -> ^( IM_COORD nodename )
                    	{
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:349:26: ^( IM_COORD nodename )
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
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:350:5: ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' )
                    {
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:350:5: ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' )
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:350:7: ( coord_modifier )? '(' numberunit coord_sep numberunit ')'
                    	{
                    		// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:350:7: ( coord_modifier )?
                    		int alt41 = 2;
                    		int LA41_0 = input.LA(1);

                    		if ( ((LA41_0 >= 73 && LA41_0 <= 74)) )
                    		{
                    		    alt41 = 1;
                    		}
                    		switch (alt41) 
                    		{
                    		    case 1 :
                    		        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:350:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord1647);
                    		        	coord_modifier150 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_coord_modifier.Add(coord_modifier150.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal151=(IToken)Match(input,45,FOLLOW_45_in_coord1650); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_45.Add(char_literal151);

                    		PushFollow(FOLLOW_numberunit_in_coord1652);
                    		numberunit152 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit152.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord1654);
                    		coord_sep153 = coord_sep();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_sep.Add(coord_sep153.Tree);
                    		PushFollow(FOLLOW_numberunit_in_coord1656);
                    		numberunit154 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit154.Tree);
                    		char_literal155=(IToken)Match(input,46,FOLLOW_46_in_coord1658); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_46.Add(char_literal155);


                    	}



                    	// AST REWRITE
                    	// elements:          numberunit, coord_modifier, coord_sep
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 350:65: -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep )
                    	{
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:350:68: ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:350:79: ( coord_modifier )?
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
                case 3 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:351:5: ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' )
                    {
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:351:5: ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' )
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:351:7: ( coord_modifier )? '(' coord_part coord_sep coord_part ')'
                    	{
                    		// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:351:7: ( coord_modifier )?
                    		int alt42 = 2;
                    		int LA42_0 = input.LA(1);

                    		if ( ((LA42_0 >= 73 && LA42_0 <= 74)) )
                    		{
                    		    alt42 = 1;
                    		}
                    		switch (alt42) 
                    		{
                    		    case 1 :
                    		        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:351:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord1682);
                    		        	coord_modifier156 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_coord_modifier.Add(coord_modifier156.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal157=(IToken)Match(input,45,FOLLOW_45_in_coord1685); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_45.Add(char_literal157);

                    		PushFollow(FOLLOW_coord_part_in_coord1687);
                    		coord_part158 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_part.Add(coord_part158.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord1689);
                    		coord_sep159 = coord_sep();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_sep.Add(coord_sep159.Tree);
                    		PushFollow(FOLLOW_coord_part_in_coord1691);
                    		coord_part160 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_part.Add(coord_part160.Tree);
                    		char_literal161=(IToken)Match(input,46,FOLLOW_46_in_coord1693); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_46.Add(char_literal161);


                    	}



                    	// AST REWRITE
                    	// elements:          coord_part, coord_modifier, coord_sep
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 351:65: -> ^( IM_DONTCARE ( coord_modifier )? ( coord_part )+ coord_sep )
                    	{
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:351:68: ^( IM_DONTCARE ( coord_modifier )? ( coord_part )+ coord_sep )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DONTCARE, "IM_DONTCARE"), root_1);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:351:82: ( coord_modifier )?
                    	    if ( stream_coord_modifier.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_coord_modifier.NextTree());

                    	    }
                    	    stream_coord_modifier.Reset();
                    	    if ( !(stream_coord_part.HasNext()) ) {
                    	        throw new RewriteEarlyExitException();
                    	    }
                    	    while ( stream_coord_part.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_coord_part.NextTree());

                    	    }
                    	    stream_coord_part.Reset();
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

    public class coord_part_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "coord_part"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:355:1: coord_part : ( idd | '{' idd '}' );
    public simpletikzParser.coord_part_return coord_part() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_part_return retval = new simpletikzParser.coord_part_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal163 = null;
        IToken char_literal165 = null;
        simpletikzParser.idd_return idd162 = default(simpletikzParser.idd_return);

        simpletikzParser.idd_return idd164 = default(simpletikzParser.idd_return);


        object char_literal163_tree=null;
        object char_literal165_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:356:2: ( idd | '{' idd '}' )
            int alt44 = 2;
            int LA44_0 = input.LA(1);

            if ( ((LA44_0 >= IM_PATH && LA44_0 <= 38) || (LA44_0 >= 50 && LA44_0 <= 76)) )
            {
                alt44 = 1;
            }
            else if ( (LA44_0 == 39) )
            {
                alt44 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d44s0 =
                    new NoViableAltException("", 44, 0, input);

                throw nvae_d44s0;
            }
            switch (alt44) 
            {
                case 1 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:356:4: idd
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_idd_in_coord_part1721);
                    	idd162 = idd();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idd162.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:357:4: '{' idd '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal163=(IToken)Match(input,39,FOLLOW_39_in_coord_part1726); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal163_tree = (object)adaptor.Create(char_literal163);
                    		adaptor.AddChild(root_0, char_literal163_tree);
                    	}
                    	PushFollow(FOLLOW_idd_in_coord_part1728);
                    	idd164 = idd();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idd164.Tree);
                    	char_literal165=(IToken)Match(input,40,FOLLOW_40_in_coord_part1730); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal165_tree = (object)adaptor.Create(char_literal165);
                    		adaptor.AddChild(root_0, char_literal165_tree);
                    	}

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
    // $ANTLR end "coord_part"

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:359:1: coord_sep : ( ',' | ':' ) ;
    public simpletikzParser.coord_sep_return coord_sep() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_sep_return retval = new simpletikzParser.coord_sep_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set166 = null;

        object set166_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:360:2: ( ( ',' | ':' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:360:4: ( ',' | ':' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set166 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 42 && input.LA(1) <= 43) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set166));
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:364:1: edgeop : ( '--' | '->' | '|-' | '-|' | ID );
    public simpletikzParser.edgeop_return edgeop() // throws RecognitionException [1]
    {   
        simpletikzParser.edgeop_return retval = new simpletikzParser.edgeop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set167 = null;

        object set167_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:365:2: ( '--' | '->' | '|-' | '-|' | ID )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set167 = (IToken)input.LT(1);
            	if ( input.LA(1) == ID || (input.LA(1) >= 69 && input.LA(1) <= 72) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set167));
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:369:1: coord_modifier : ( '+' | '++' );
    public simpletikzParser.coord_modifier_return coord_modifier() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_modifier_return retval = new simpletikzParser.coord_modifier_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set168 = null;

        object set168_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:370:2: ( '+' | '++' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set168 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 73 && input.LA(1) <= 74) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set168));
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:412:1: squarebr_start : '[' -> ^( IM_STARTTAG '[' ) ;
    public simpletikzParser.squarebr_start_return squarebr_start() // throws RecognitionException [1]
    {   
        simpletikzParser.squarebr_start_return retval = new simpletikzParser.squarebr_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal169 = null;

        object char_literal169_tree=null;
        RewriteRuleTokenStream stream_47 = new RewriteRuleTokenStream(adaptor,"token 47");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:413:2: ( '[' -> ^( IM_STARTTAG '[' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:413:4: '['
            {
            	char_literal169=(IToken)Match(input,47,FOLLOW_47_in_squarebr_start1814); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_47.Add(char_literal169);



            	// AST REWRITE
            	// elements:          47
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 413:8: -> ^( IM_STARTTAG '[' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:413:11: ^( IM_STARTTAG '[' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_47.NextNode());

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:415:1: squarebr_end : ']' -> ^( IM_ENDTAG ']' ) ;
    public simpletikzParser.squarebr_end_return squarebr_end() // throws RecognitionException [1]
    {   
        simpletikzParser.squarebr_end_return retval = new simpletikzParser.squarebr_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal170 = null;

        object char_literal170_tree=null;
        RewriteRuleTokenStream stream_48 = new RewriteRuleTokenStream(adaptor,"token 48");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:416:2: ( ']' -> ^( IM_ENDTAG ']' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:416:4: ']'
            {
            	char_literal170=(IToken)Match(input,48,FOLLOW_48_in_squarebr_end1832); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_48.Add(char_literal170);



            	// AST REWRITE
            	// elements:          48
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 416:8: -> ^( IM_ENDTAG ']' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:416:11: ^( IM_ENDTAG ']' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_48.NextNode());

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:418:1: semicolon_end : ';' -> ^( IM_ENDTAG ';' ) ;
    public simpletikzParser.semicolon_end_return semicolon_end() // throws RecognitionException [1]
    {   
        simpletikzParser.semicolon_end_return retval = new simpletikzParser.semicolon_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal171 = null;

        object char_literal171_tree=null;
        RewriteRuleTokenStream stream_49 = new RewriteRuleTokenStream(adaptor,"token 49");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:419:2: ( ';' -> ^( IM_ENDTAG ';' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:419:4: ';'
            {
            	char_literal171=(IToken)Match(input,49,FOLLOW_49_in_semicolon_end1851); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_49.Add(char_literal171);



            	// AST REWRITE
            	// elements:          49
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 419:8: -> ^( IM_ENDTAG ';' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:419:11: ^( IM_ENDTAG ';' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_49.NextNode());

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:421:1: roundbr_start : '{' -> ^( IM_STARTTAG '{' ) ;
    public simpletikzParser.roundbr_start_return roundbr_start() // throws RecognitionException [1]
    {   
        simpletikzParser.roundbr_start_return retval = new simpletikzParser.roundbr_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal172 = null;

        object char_literal172_tree=null;
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:422:2: ( '{' -> ^( IM_STARTTAG '{' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:422:4: '{'
            {
            	char_literal172=(IToken)Match(input,39,FOLLOW_39_in_roundbr_start1869); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_39.Add(char_literal172);



            	// AST REWRITE
            	// elements:          39
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 422:8: -> ^( IM_STARTTAG '{' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:422:11: ^( IM_STARTTAG '{' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_39.NextNode());

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:424:1: roundbr_end : '}' -> ^( IM_ENDTAG '}' ) ;
    public simpletikzParser.roundbr_end_return roundbr_end() // throws RecognitionException [1]
    {   
        simpletikzParser.roundbr_end_return retval = new simpletikzParser.roundbr_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal173 = null;

        object char_literal173_tree=null;
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:425:2: ( '}' -> ^( IM_ENDTAG '}' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:425:4: '}'
            {
            	char_literal173=(IToken)Match(input,40,FOLLOW_40_in_roundbr_end1887); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_40.Add(char_literal173);



            	// AST REWRITE
            	// elements:          40
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 425:8: -> ^( IM_ENDTAG '}' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:425:11: ^( IM_ENDTAG '}' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_40.NextNode());

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:427:1: tikz_set_start : '\\\\tikzset' '{' -> ^( IM_STARTTAG ) ;
    public simpletikzParser.tikz_set_start_return tikz_set_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_set_start_return retval = new simpletikzParser.tikz_set_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal174 = null;
        IToken char_literal175 = null;

        object string_literal174_tree=null;
        object char_literal175_tree=null;
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");
        RewriteRuleTokenStream stream_38 = new RewriteRuleTokenStream(adaptor,"token 38");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:428:2: ( '\\\\tikzset' '{' -> ^( IM_STARTTAG ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:428:4: '\\\\tikzset' '{'
            {
            	string_literal174=(IToken)Match(input,38,FOLLOW_38_in_tikz_set_start1905); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_38.Add(string_literal174);

            	char_literal175=(IToken)Match(input,39,FOLLOW_39_in_tikz_set_start1907); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_39.Add(char_literal175);



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
            	// 428:21: -> ^( IM_STARTTAG )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:428:24: ^( IM_STARTTAG )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:430:1: tikzpicture_start : '\\\\begin' '{' 'tikzpicture' '}' -> ^( IM_STARTTAG '\\\\begin' ) ;
    public simpletikzParser.tikzpicture_start_return tikzpicture_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_start_return retval = new simpletikzParser.tikzpicture_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal176 = null;
        IToken char_literal177 = null;
        IToken string_literal178 = null;
        IToken char_literal179 = null;

        object string_literal176_tree=null;
        object char_literal177_tree=null;
        object string_literal178_tree=null;
        object char_literal179_tree=null;
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleTokenStream stream_36 = new RewriteRuleTokenStream(adaptor,"token 36");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");
        RewriteRuleTokenStream stream_75 = new RewriteRuleTokenStream(adaptor,"token 75");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:431:2: ( '\\\\begin' '{' 'tikzpicture' '}' -> ^( IM_STARTTAG '\\\\begin' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:431:4: '\\\\begin' '{' 'tikzpicture' '}'
            {
            	string_literal176=(IToken)Match(input,36,FOLLOW_36_in_tikzpicture_start1926); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_36.Add(string_literal176);

            	char_literal177=(IToken)Match(input,39,FOLLOW_39_in_tikzpicture_start1928); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_39.Add(char_literal177);

            	string_literal178=(IToken)Match(input,75,FOLLOW_75_in_tikzpicture_start1930); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_75.Add(string_literal178);

            	char_literal179=(IToken)Match(input,40,FOLLOW_40_in_tikzpicture_start1932); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_40.Add(char_literal179);



            	// AST REWRITE
            	// elements:          36
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 431:36: -> ^( IM_STARTTAG '\\\\begin' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:431:39: ^( IM_STARTTAG '\\\\begin' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_36.NextNode());

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:433:1: tikzpicture_end : '\\\\end' '{' 'tikzpicture' '}' -> ^( IM_ENDTAG '\\\\end' ) ;
    public simpletikzParser.tikzpicture_end_return tikzpicture_end() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_end_return retval = new simpletikzParser.tikzpicture_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal180 = null;
        IToken char_literal181 = null;
        IToken string_literal182 = null;
        IToken char_literal183 = null;

        object string_literal180_tree=null;
        object char_literal181_tree=null;
        object string_literal182_tree=null;
        object char_literal183_tree=null;
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");
        RewriteRuleTokenStream stream_75 = new RewriteRuleTokenStream(adaptor,"token 75");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:434:2: ( '\\\\end' '{' 'tikzpicture' '}' -> ^( IM_ENDTAG '\\\\end' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:434:4: '\\\\end' '{' 'tikzpicture' '}'
            {
            	string_literal180=(IToken)Match(input,56,FOLLOW_56_in_tikzpicture_end1950); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_56.Add(string_literal180);

            	char_literal181=(IToken)Match(input,39,FOLLOW_39_in_tikzpicture_end1952); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_39.Add(char_literal181);

            	string_literal182=(IToken)Match(input,75,FOLLOW_75_in_tikzpicture_end1954); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_75.Add(string_literal182);

            	char_literal183=(IToken)Match(input,40,FOLLOW_40_in_tikzpicture_end1956); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_40.Add(char_literal183);



            	// AST REWRITE
            	// elements:          56
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 434:34: -> ^( IM_ENDTAG '\\\\end' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:434:37: ^( IM_ENDTAG '\\\\end' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_56.NextNode());

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:436:1: tikzscope_start : '\\\\begin' '{' 'scope' '}' -> ^( IM_STARTTAG '\\\\begin' ) ;
    public simpletikzParser.tikzscope_start_return tikzscope_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_start_return retval = new simpletikzParser.tikzscope_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal184 = null;
        IToken char_literal185 = null;
        IToken string_literal186 = null;
        IToken char_literal187 = null;

        object string_literal184_tree=null;
        object char_literal185_tree=null;
        object string_literal186_tree=null;
        object char_literal187_tree=null;
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleTokenStream stream_36 = new RewriteRuleTokenStream(adaptor,"token 36");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");
        RewriteRuleTokenStream stream_76 = new RewriteRuleTokenStream(adaptor,"token 76");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:437:2: ( '\\\\begin' '{' 'scope' '}' -> ^( IM_STARTTAG '\\\\begin' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:437:4: '\\\\begin' '{' 'scope' '}'
            {
            	string_literal184=(IToken)Match(input,36,FOLLOW_36_in_tikzscope_start1974); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_36.Add(string_literal184);

            	char_literal185=(IToken)Match(input,39,FOLLOW_39_in_tikzscope_start1976); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_39.Add(char_literal185);

            	string_literal186=(IToken)Match(input,76,FOLLOW_76_in_tikzscope_start1978); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_76.Add(string_literal186);

            	char_literal187=(IToken)Match(input,40,FOLLOW_40_in_tikzscope_start1980); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_40.Add(char_literal187);



            	// AST REWRITE
            	// elements:          36
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 437:30: -> ^( IM_STARTTAG '\\\\begin' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:437:33: ^( IM_STARTTAG '\\\\begin' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_36.NextNode());

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:439:1: tikzscope_end : '\\\\end' '{' 'scope' '}' -> ^( IM_ENDTAG '\\\\end' ) ;
    public simpletikzParser.tikzscope_end_return tikzscope_end() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_end_return retval = new simpletikzParser.tikzscope_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal188 = null;
        IToken char_literal189 = null;
        IToken string_literal190 = null;
        IToken char_literal191 = null;

        object string_literal188_tree=null;
        object char_literal189_tree=null;
        object string_literal190_tree=null;
        object char_literal191_tree=null;
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");
        RewriteRuleTokenStream stream_76 = new RewriteRuleTokenStream(adaptor,"token 76");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:440:2: ( '\\\\end' '{' 'scope' '}' -> ^( IM_ENDTAG '\\\\end' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:440:4: '\\\\end' '{' 'scope' '}'
            {
            	string_literal188=(IToken)Match(input,56,FOLLOW_56_in_tikzscope_end1998); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_56.Add(string_literal188);

            	char_literal189=(IToken)Match(input,39,FOLLOW_39_in_tikzscope_end2000); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_39.Add(char_literal189);

            	string_literal190=(IToken)Match(input,76,FOLLOW_76_in_tikzscope_end2002); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_76.Add(string_literal190);

            	char_literal191=(IToken)Match(input,40,FOLLOW_40_in_tikzscope_end2004); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_40.Add(char_literal191);



            	// AST REWRITE
            	// elements:          56
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 440:28: -> ^( IM_ENDTAG '\\\\end' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:440:31: ^( IM_ENDTAG '\\\\end' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_56.NextNode());

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:442:1: path_start : path_start_tag -> ^( IM_STARTTAG path_start_tag ) ;
    public simpletikzParser.path_start_return path_start() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_return retval = new simpletikzParser.path_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.path_start_tag_return path_start_tag192 = default(simpletikzParser.path_start_tag_return);


        RewriteRuleSubtreeStream stream_path_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule path_start_tag");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:443:2: ( path_start_tag -> ^( IM_STARTTAG path_start_tag ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:443:4: path_start_tag
            {
            	PushFollow(FOLLOW_path_start_tag_in_path_start2023);
            	path_start_tag192 = path_start_tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_path_start_tag.Add(path_start_tag192.Tree);


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
            	// 443:19: -> ^( IM_STARTTAG path_start_tag )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:443:22: ^( IM_STARTTAG path_start_tag )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:445:1: node_start : node_start_tag -> ^( IM_STARTTAG node_start_tag ) ;
    public simpletikzParser.node_start_return node_start() // throws RecognitionException [1]
    {   
        simpletikzParser.node_start_return retval = new simpletikzParser.node_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.node_start_tag_return node_start_tag193 = default(simpletikzParser.node_start_tag_return);


        RewriteRuleSubtreeStream stream_node_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule node_start_tag");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:446:2: ( node_start_tag -> ^( IM_STARTTAG node_start_tag ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:446:4: node_start_tag
            {
            	PushFollow(FOLLOW_node_start_tag_in_node_start2041);
            	node_start_tag193 = node_start_tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_node_start_tag.Add(node_start_tag193.Tree);


            	// AST REWRITE
            	// elements:          node_start_tag
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 446:19: -> ^( IM_STARTTAG node_start_tag )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:446:22: ^( IM_STARTTAG node_start_tag )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_node_start_tag.NextTree());

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

    public class node_start_tag_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "node_start_tag"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:448:1: node_start_tag : ( '\\\\node' | '\\\\coordinate' );
    public simpletikzParser.node_start_tag_return node_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.node_start_tag_return retval = new simpletikzParser.node_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set194 = null;

        object set194_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:449:2: ( '\\\\node' | '\\\\coordinate' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set194 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 57 && input.LA(1) <= 58) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set194));
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
    // $ANTLR end "node_start_tag"

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:451:1: path_start_tag : ( '\\\\draw' | '\\\\fill' | '\\\\path' | '\\\\clip' );
    public simpletikzParser.path_start_tag_return path_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_tag_return retval = new simpletikzParser.path_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set195 = null;

        object set195_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:452:2: ( '\\\\draw' | '\\\\fill' | '\\\\path' | '\\\\clip' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set195 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 59 && input.LA(1) <= 62) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set195));
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
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:334:28: ( size )
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:334:29: size
        {
        	PushFollow(FOLLOW_size_in_synpred1_simpletikz1530);
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


   	protected DFA8 dfa8;
   	protected DFA24 dfa24;
   	protected DFA25 dfa25;
   	protected DFA38 dfa38;
   	protected DFA43 dfa43;
	private void InitializeCyclicDFAs()
	{
    	this.dfa8 = new DFA8(this);
    	this.dfa24 = new DFA24(this);
    	this.dfa25 = new DFA25(this);
    	this.dfa38 = new DFA38(this);
    	this.dfa43 = new DFA43(this);
	    this.dfa38.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA38_SpecialStateTransition);
	}

    const string DFA8_eotS =
        "\x04\uffff";
    const string DFA8_eofS =
        "\x04\uffff";
    const string DFA8_minS =
        "\x02\x04\x02\uffff";
    const string DFA8_maxS =
        "\x02\x4c\x02\uffff";
    const string DFA8_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA8_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA8_transitionS = {
            "\x23\x01\x0b\uffff\x1b\x01",
            "\x23\x01\x01\uffff\x03\x03\x01\uffff\x01\x02\x03\uffff\x01"+
            "\x03\x01\uffff\x1b\x01",
            "",
            ""
    };

    static readonly short[] DFA8_eot = DFA.UnpackEncodedString(DFA8_eotS);
    static readonly short[] DFA8_eof = DFA.UnpackEncodedString(DFA8_eofS);
    static readonly char[] DFA8_min = DFA.UnpackEncodedStringToUnsignedChars(DFA8_minS);
    static readonly char[] DFA8_max = DFA.UnpackEncodedStringToUnsignedChars(DFA8_maxS);
    static readonly short[] DFA8_accept = DFA.UnpackEncodedString(DFA8_acceptS);
    static readonly short[] DFA8_special = DFA.UnpackEncodedString(DFA8_specialS);
    static readonly short[][] DFA8_transition = DFA.UnpackEncodedStringArray(DFA8_transitionS);

    protected class DFA8 : DFA
    {
        public DFA8(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 8;
            this.eot = DFA8_eot;
            this.eof = DFA8_eof;
            this.min = DFA8_min;
            this.max = DFA8_max;
            this.accept = DFA8_accept;
            this.special = DFA8_special;
            this.transition = DFA8_transition;

        }

        override public string Description
        {
            get { return "168:1: option : ( option_style | option_kv );"; }
        }

    }

    const string DFA24_eotS =
        "\x0b\uffff";
    const string DFA24_eofS =
        "\x0b\uffff";
    const string DFA24_minS =
        "\x01\x04\x01\x27\x06\uffff\x01\x1a\x02\uffff";
    const string DFA24_maxS =
        "\x01\x4c\x01\x27\x06\uffff\x01\x4c\x02\uffff";
    const string DFA24_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x07\x01\x08\x01"+
        "\uffff\x01\x01\x01\x06";
    const string DFA24_specialS =
        "\x0b\uffff}>";
    static readonly string[] DFA24_transitionS = {
            "\x20\x07\x01\x01\x01\x05\x01\x04\x08\x07\x01\uffff\x08\x07"+
            "\x01\x06\x02\x03\x04\x02\x0e\x07",
            "\x01\x08",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0a\x31\uffff\x01\x09",
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
            get { return "237:4: ( tikzscope | tikzpath | tikznode_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr )"; }
        }

    }

    const string DFA25_eotS =
        "\x0e\uffff";
    const string DFA25_eofS =
        "\x0e\uffff";
    const string DFA25_minS =
        "\x01\x04\x02\x27\x05\uffff\x02\x1a\x04\uffff";
    const string DFA25_maxS =
        "\x01\x4c\x02\x27\x05\uffff\x02\x4c\x04\uffff";
    const string DFA25_acceptS =
        "\x03\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x08\x02\uffff\x01"+
        "\x09\x01\x07\x01\x01\x01\x06";
    const string DFA25_specialS =
        "\x0e\uffff}>";
    static readonly string[] DFA25_transitionS = {
            "\x20\x07\x01\x02\x01\x06\x01\x05\x11\x07\x01\x01\x02\x04\x04"+
            "\x03\x0e\x07",
            "\x01\x08",
            "\x01\x09",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0b\x30\uffff\x02\x0a",
            "\x01\x0d\x31\uffff\x01\x0c",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA25_eot = DFA.UnpackEncodedString(DFA25_eotS);
    static readonly short[] DFA25_eof = DFA.UnpackEncodedString(DFA25_eofS);
    static readonly char[] DFA25_min = DFA.UnpackEncodedStringToUnsignedChars(DFA25_minS);
    static readonly char[] DFA25_max = DFA.UnpackEncodedStringToUnsignedChars(DFA25_maxS);
    static readonly short[] DFA25_accept = DFA.UnpackEncodedString(DFA25_acceptS);
    static readonly short[] DFA25_special = DFA.UnpackEncodedString(DFA25_specialS);
    static readonly short[][] DFA25_transition = DFA.UnpackEncodedStringArray(DFA25_transitionS);

    protected class DFA25 : DFA
    {
        public DFA25(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 25;
            this.eot = DFA25_eot;
            this.eof = DFA25_eof;
            this.min = DFA25_min;
            this.max = DFA25_max;
            this.accept = DFA25_accept;
            this.special = DFA25_special;
            this.transition = DFA25_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 238:3: ( tikzscope | tikzpath | tikznode_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*"; }
        }

    }

    const string DFA38_eotS =
        "\x0a\uffff";
    const string DFA38_eofS =
        "\x0a\uffff";
    const string DFA38_minS =
        "\x01\x1a\x01\x04\x01\uffff\x03\x04\x01\x00\x01\x04\x01\uffff\x01"+
        "\x04";
    const string DFA38_maxS =
        "\x01\x4a\x01\x4c\x01\uffff\x03\x4c\x01\x00\x01\x4c\x01\uffff\x01"+
        "\x4c";
    const string DFA38_acceptS =
        "\x02\uffff\x01\x02\x05\uffff\x01\x01\x01\uffff";
    const string DFA38_specialS =
        "\x06\uffff\x01\x00\x03\uffff}>";
    static readonly string[] DFA38_transitionS = {
            "\x01\x02\x0c\uffff\x02\x02\x04\uffff\x01\x01\x01\uffff\x01"+
            "\x02\x01\uffff\x01\x02\x0d\uffff\x01\x02\x01\uffff\x03\x02\x01"+
            "\uffff\x06\x02",
            "\x17\x02\x02\x03\x0b\x02\x0a\uffff\x1b\x02",
            "",
            "\x23\x02\x03\uffff\x02\x02\x02\uffff\x01\x06\x03\uffff\x06"+
            "\x04\x0c\x02\x01\x05\x08\x02",
            "\x23\x02\x03\uffff\x02\x02\x02\uffff\x01\x06\x03\uffff\x12"+
            "\x02\x01\x05\x08\x02",
            "\x17\x02\x02\x07\x0a\x02\x03\uffff\x02\x02\x02\uffff\x01\x02"+
            "\x03\uffff\x1b\x02",
            "\x01\uffff",
            "\x23\x02\x03\uffff\x02\x02\x02\uffff\x01\x06\x03\uffff\x06"+
            "\x09\x15\x02",
            "",
            "\x23\x02\x03\uffff\x02\x02\x02\uffff\x01\x06\x03\uffff\x1b"+
            "\x02"
    };

    static readonly short[] DFA38_eot = DFA.UnpackEncodedString(DFA38_eotS);
    static readonly short[] DFA38_eof = DFA.UnpackEncodedString(DFA38_eofS);
    static readonly char[] DFA38_min = DFA.UnpackEncodedStringToUnsignedChars(DFA38_minS);
    static readonly char[] DFA38_max = DFA.UnpackEncodedStringToUnsignedChars(DFA38_maxS);
    static readonly short[] DFA38_accept = DFA.UnpackEncodedString(DFA38_acceptS);
    static readonly short[] DFA38_special = DFA.UnpackEncodedString(DFA38_specialS);
    static readonly short[][] DFA38_transition = DFA.UnpackEncodedStringArray(DFA38_transitionS);

    protected class DFA38 : DFA
    {
        public DFA38(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 38;
            this.eot = DFA38_eot;
            this.eof = DFA38_eof;
            this.min = DFA38_min;
            this.max = DFA38_max;
            this.accept = DFA38_accept;
            this.special = DFA38_special;
            this.transition = DFA38_transition;

        }

        override public string Description
        {
            get { return "334:27: ( ( size )=> size )?"; }
        }

    }


    protected internal int DFA38_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA38_6 = input.LA(1);

                   	 
                   	int index38_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_simpletikz()) ) { s = 8; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index38_6);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae38 =
            new NoViableAltException(dfa.Description, 38, _s, input);
        dfa.Error(nvae38);
        throw nvae38;
    }
    const string DFA43_eotS =
        "\x0f\uffff";
    const string DFA43_eofS =
        "\x0f\uffff";
    const string DFA43_minS =
        "\x01\x2d\x01\x04\x01\x2d\x02\x04\x01\uffff\x03\x04\x01\uffff\x03"+
        "\x04\x01\uffff\x01\x04";
    const string DFA43_maxS =
        "\x01\x4a\x01\x4c\x01\x2d\x02\x4c\x01\uffff\x03\x4c\x01\uffff\x03"+
        "\x4c\x01\uffff\x01\x4c";
    const string DFA43_acceptS =
        "\x05\uffff\x01\x03\x03\uffff\x01\x01\x03\uffff\x01\x02\x01\uffff";
    const string DFA43_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA43_transitionS = {
            "\x01\x01\x1b\uffff\x02\x02",
            "\x17\x04\x02\x03\x0a\x04\x01\x05\x0a\uffff\x1b\x04",
            "\x01\x06",
            "\x23\x04\x03\uffff\x02\x07\x02\uffff\x01\x09\x03\uffff\x06"+
            "\x08\x15\x04",
            "\x23\x04\x03\uffff\x02\x05\x02\uffff\x01\x09\x03\uffff\x1b"+
            "\x04",
            "",
            "\x17\x05\x02\x0a\x0b\x05\x0a\uffff\x1b\x05",
            "\x17\x05\x02\x0b\x0b\x05\x0a\uffff\x1b\x05",
            "\x23\x04\x03\uffff\x02\x07\x02\uffff\x01\x09\x03\uffff\x1b"+
            "\x04",
            "",
            "\x23\x05\x03\uffff\x02\x07\x06\uffff\x06\x0c\x15\x05",
            "\x23\x05\x07\uffff\x01\x0d\x03\uffff\x06\x0e\x15\x05",
            "\x23\x05\x03\uffff\x02\x07\x06\uffff\x1b\x05",
            "",
            "\x23\x05\x07\uffff\x01\x0d\x03\uffff\x1b\x05"
    };

    static readonly short[] DFA43_eot = DFA.UnpackEncodedString(DFA43_eotS);
    static readonly short[] DFA43_eof = DFA.UnpackEncodedString(DFA43_eofS);
    static readonly char[] DFA43_min = DFA.UnpackEncodedStringToUnsignedChars(DFA43_minS);
    static readonly char[] DFA43_max = DFA.UnpackEncodedStringToUnsignedChars(DFA43_maxS);
    static readonly short[] DFA43_accept = DFA.UnpackEncodedString(DFA43_acceptS);
    static readonly short[] DFA43_special = DFA.UnpackEncodedString(DFA43_specialS);
    static readonly short[][] DFA43_transition = DFA.UnpackEncodedStringArray(DFA43_transitionS);

    protected class DFA43 : DFA
    {
        public DFA43(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 43;
            this.eot = DFA43_eot;
            this.eof = DFA43_eof;
            this.min = DFA43_min;
            this.max = DFA43_max;
            this.accept = DFA43_accept;
            this.special = DFA43_special;
            this.transition = DFA43_transition;

        }

        override public string Description
        {
            get { return "348:1: coord : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_DONTCARE ( coord_modifier )? ( coord_part )+ coord_sep ) );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_dontcare_preamble_in_tikzdocument249 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_tikz_styleorsetorcmd_in_tikzdocument253 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzdocument257 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_tikzpicture_in_tikzdocument262 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_dontcare_preamble_in_tikzdocument_wo_tikzpicture288 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_tikz_styleorsetorcmd_in_tikzdocument_wo_tikzpicture292 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzdocument_wo_tikzpicture296 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_EOF_in_tikzdocument_wo_tikzpicture301 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TIKZEDT_CMD_COMMENT_in_tikz_cmd_comment322 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikz_styleorsetorcmd344 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikz_styleorsetorcmd348 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_cmd_comment_in_tikz_styleorsetorcmd352 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_preamble363 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_36_in_otherbegin388 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_39_in_otherbegin390 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_idd2_in_otherbegin392 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_otherbegin394 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_37_in_tikz_style406 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_39_in_tikz_style408 = new BitSet(new ulong[]{0xFFFC007FFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_idd_in_tikz_style410 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_tikz_style412 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_tikz_style414 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikz_style416 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_squarebr_start_in_tikz_options438 = new BitSet(new ulong[]{0xFFFD007FFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_options441 = new BitSet(new ulong[]{0xFFFD047FFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_42_in_tikz_options444 = new BitSet(new ulong[]{0xFFFC007FFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_options446 = new BitSet(new ulong[]{0xFFFD047FFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_42_in_tikz_options450 = new BitSet(new ulong[]{0xFFFD007FFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_squarebr_end_in_tikz_options455 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_option_style_in_option480 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_option_kv_in_option489 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_option_kv503 = new BitSet(new ulong[]{0x0000020000000002UL});
    public static readonly BitSet FOLLOW_41_in_option_kv506 = new BitSet(new ulong[]{0xFFFC00FFFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_iddornumberunitorstringorrange_in_option_kv508 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_tikzstring536 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_no_rlbrace_in_tikzstring538 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikzstring542 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_no_rlbrace_in_tikzstring544 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_40_in_tikzstring549 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_no_rlbrace572 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_numberunit_in_iddornumberunitorstringorrange589 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_iddornumberunitorstringorrange593 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzstring_in_iddornumberunitorstringorrange597 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_range_in_iddornumberunitorstringorrange601 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_numberunit_in_range611 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_range613 = new BitSet(new ulong[]{0x0000000018000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_range615 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_option_style626 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_option_style628 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_option_style630 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_39_in_option_style632 = new BitSet(new ulong[]{0xFFFC057FFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_option_kv_in_option_style635 = new BitSet(new ulong[]{0x0000050000000000UL});
    public static readonly BitSet FOLLOW_42_in_option_style638 = new BitSet(new ulong[]{0xFFFC007FFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_option_kv_in_option_style640 = new BitSet(new ulong[]{0x0000050000000000UL});
    public static readonly BitSet FOLLOW_42_in_option_style647 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_option_style650 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_heavenknowswhythisisnecessary_in_idd685 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_idd_heavenknowswhythisisnecessary705 = new BitSet(new ulong[]{0xFFFC007FFFFFFFF2UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_ID_in_idd2759 = new BitSet(new ulong[]{0x0000000004000002UL});
    public static readonly BitSet FOLLOW_number_in_numberunit782 = new BitSet(new ulong[]{0x00FC000000000002UL});
    public static readonly BitSet FOLLOW_unit_in_numberunit784 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_number810 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unit0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_set_start_in_tikz_set865 = new BitSet(new ulong[]{0xFFFC017FFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_set868 = new BitSet(new ulong[]{0xFFFC057FFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_42_in_tikz_set871 = new BitSet(new ulong[]{0xFFFC007FFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_set873 = new BitSet(new ulong[]{0xFFFC057FFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_roundbr_end_in_tikz_set879 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzpicture_start_in_tikzpicture907 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpicture909 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzpicture912 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_tikzpicture_end_in_tikzpicture915 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody945 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody949 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_tikznode_ext_in_tikzbody953 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody957 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody961 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody965 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody970 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_dontcare_body_nobr_in_tikzbody975 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody986 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody990 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_tikznode_ext_in_tikzbody994 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody998 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody1002 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody1006 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody1011 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_dontcare_body_in_tikzbody1016 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body_nobr1033 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body1091 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_otherend1146 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_39_in_otherend1148 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_idd2_in_otherend1150 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_otherend1152 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzscope_start_in_tikzscope1179 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzscope1181 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzscope1184 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_tikzscope_end_in_tikzscope1187 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_in_tikzpath1242 = new BitSet(new ulong[]{0x8002A08004000000UL,0x00000000000007EEUL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath1244 = new BitSet(new ulong[]{0x8002A08004000000UL,0x00000000000007EEUL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzpath1247 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpath_element1276 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_in_tikzpath_element1283 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_int_in_tikzpath_element1289 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_circle_in_tikzpath_element1295 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arc_in_tikzpath_element1302 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_roundbr_start_in_tikzpath_element1309 = new BitSet(new ulong[]{0xFFFCA1FFFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath_element1311 = new BitSet(new ulong[]{0xFFFCA1FFFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_roundbr_end_in_tikzpath_element1314 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_edgeop_in_tikzpath_element1333 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_node_start_in_tikznode_ext1344 = new BitSet(new ulong[]{0x0000A08000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_tikznode_core_in_tikznode_ext1346 = new BitSet(new ulong[]{0x8002A08004000000UL,0x00000000000007EEUL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikznode_ext1348 = new BitSet(new ulong[]{0x8002A08004000000UL,0x00000000000007EEUL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikznode_ext1351 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_63_in_tikznode_int1376 = new BitSet(new ulong[]{0x0000A08000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_tikznode_core_in_tikznode_int1379 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikznode_core1389 = new BitSet(new ulong[]{0x0000A08000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikznode_core1392 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_tikznode_decorator1419 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_64_in_tikznode_decorator1426 = new BitSet(new ulong[]{0x0000200000000000UL,0x0000000000000600UL});
    public static readonly BitSet FOLLOW_coord_in_tikznode_decorator1429 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_options_dontcare_in_tikznode_decorator1435 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_47_in_tikz_options_dontcare1445 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_no_rlbracket_in_tikz_options_dontcare1447 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_tikz_options_dontcare_in_tikz_options_dontcare1451 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_no_rlbracket_in_tikz_options_dontcare1453 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_48_in_tikz_options_dontcare1458 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_no_rlbracket1476 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_nodename1493 = new BitSet(new ulong[]{0xFFFC007FFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_idd_in_nodename1495 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_nodename1497 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_65_in_circle1521 = new BitSet(new ulong[]{0x0000200000000002UL});
    public static readonly BitSet FOLLOW_66_in_circle1525 = new BitSet(new ulong[]{0x0000200000000002UL});
    public static readonly BitSet FOLLOW_size_in_circle1534 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_67_in_arc1549 = new BitSet(new ulong[]{0x0000200000000002UL});
    public static readonly BitSet FOLLOW_45_in_arc1552 = new BitSet(new ulong[]{0x0000000018000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_arc1554 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_arc1556 = new BitSet(new ulong[]{0x0000000018000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_arc1558 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_arc1560 = new BitSet(new ulong[]{0x0000000018000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_arc1562 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_arc1564 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_size1582 = new BitSet(new ulong[]{0x0000000018000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_size1584 = new BitSet(new ulong[]{0x0000400000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_68_in_size1587 = new BitSet(new ulong[]{0x0000000018000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_size1589 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_size1593 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_coord1623 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord1647 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_coord1650 = new BitSet(new ulong[]{0x0000000018000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord1652 = new BitSet(new ulong[]{0x00000C0000000000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord1654 = new BitSet(new ulong[]{0x0000000018000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord1656 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_coord1658 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord1682 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_coord1685 = new BitSet(new ulong[]{0xFFFC00FFFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_coord1687 = new BitSet(new ulong[]{0x00000C0000000000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord1689 = new BitSet(new ulong[]{0xFFFC00FFFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_coord1691 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_coord1693 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_coord_part1721 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_coord_part1726 = new BitSet(new ulong[]{0xFFFC007FFFFFFFF0UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_idd_in_coord_part1728 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_coord_part1730 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_coord_sep1740 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_edgeop0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_coord_modifier0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_47_in_squarebr_start1814 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_48_in_squarebr_end1832 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_49_in_semicolon_end1851 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_roundbr_start1869 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_roundbr_end1887 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_tikz_set_start1905 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_39_in_tikz_set_start1907 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_36_in_tikzpicture_start1926 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_39_in_tikzpicture_start1928 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_75_in_tikzpicture_start1930 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_tikzpicture_start1932 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_tikzpicture_end1950 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_39_in_tikzpicture_end1952 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_75_in_tikzpicture_end1954 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_tikzpicture_end1956 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_36_in_tikzscope_start1974 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_39_in_tikzscope_start1976 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_76_in_tikzscope_start1978 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_tikzscope_start1980 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_tikzscope_end1998 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_39_in_tikzscope_end2000 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_76_in_tikzscope_end2002 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_tikzscope_end2004 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_tag_in_path_start2023 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_node_start_tag_in_node_start2041 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_node_start_tag0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_path_start_tag0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_size_in_synpred1_simpletikz1530 = new BitSet(new ulong[]{0x0000000000000002UL});

}
