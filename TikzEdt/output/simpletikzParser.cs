// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g 2011-01-25 17:44:09

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
		"COMMAND", 
		"WS", 
		"COMMENT", 
		"EXPONENT", 
		"ESC_SEQ", 
		"MATHSTRING", 
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
		"'let'", 
		"'coordinate'", 
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
    public const int EXPONENT = 32;
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
    public const int MATHSTRING = 34;
    public const int COMMAND = 29;
    public const int IM_ENDTAG = 14;
    public const int IM_USETIKZLIB = 20;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int IM_DOCUMENT = 11;
    public const int T__58 = 58;
    public const int ESC_SEQ = 33;
    public const int IM_STRING = 21;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int IM_TIKZSET = 19;
    public const int T__59 = 59;
    public const int IM_OPTION_KV = 17;
    public const int COMMENT = 31;
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
    public const int WS = 30;
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
    public const int T__78 = 78;
    public const int T__77 = 77;

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:137:1: tikzdocument : ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* tikzpicture ( . )* -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture ) ;
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:138:2: ( ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* tikzpicture ( . )* -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:138:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* tikzpicture ( . )*
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:138:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )*
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
            	    case COMMAND:
            	    case WS:
            	    case COMMENT:
            	    case EXPONENT:
            	    case ESC_SEQ:
            	    case MATHSTRING:
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
            	    case 77:
            	    case 78:
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
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:138:5: dontcare_preamble
            			    {
            			    	PushFollow(FOLLOW_dontcare_preamble_in_tikzdocument249);
            			    	dontcare_preamble1 = dontcare_preamble();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_dontcare_preamble.Add(dontcare_preamble1.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:138:25: tikz_styleorsetorcmd
            			    {
            			    	PushFollow(FOLLOW_tikz_styleorsetorcmd_in_tikzdocument253);
            			    	tikz_styleorsetorcmd2 = tikz_styleorsetorcmd();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikz_styleorsetorcmd.Add(tikz_styleorsetorcmd2.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:138:48: otherbegin
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
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:138:74: ( . )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= IM_PATH && LA2_0 <= 78)) )
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
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:138:74: .
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
            	// elements:          tikzpicture, tikz_styleorsetorcmd
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
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:138:80: ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DOCUMENT, "IM_DOCUMENT"), root_1);

            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:138:94: ( tikz_styleorsetorcmd )*
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:141:1: tikzdocument_wo_tikzpicture : ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* EOF -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* ) ;
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:142:2: ( ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* EOF -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:142:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* EOF
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:142:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )*
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
            	    case COMMAND:
            	    case WS:
            	    case COMMENT:
            	    case EXPONENT:
            	    case ESC_SEQ:
            	    case MATHSTRING:
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
            	    case 77:
            	    case 78:
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
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:142:5: dontcare_preamble
            			    {
            			    	PushFollow(FOLLOW_dontcare_preamble_in_tikzdocument_wo_tikzpicture288);
            			    	dontcare_preamble6 = dontcare_preamble();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_dontcare_preamble.Add(dontcare_preamble6.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:142:25: tikz_styleorsetorcmd
            			    {
            			    	PushFollow(FOLLOW_tikz_styleorsetorcmd_in_tikzdocument_wo_tikzpicture292);
            			    	tikz_styleorsetorcmd7 = tikz_styleorsetorcmd();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikz_styleorsetorcmd.Add(tikz_styleorsetorcmd7.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:142:48: otherbegin
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
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:142:69: ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DOCUMENT, "IM_DOCUMENT"), root_1);

            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:142:83: ( tikz_styleorsetorcmd )*
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:145:1: tikz_cmd_comment : TIKZEDT_CMD_COMMENT -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT ) ;
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:146:2: ( TIKZEDT_CMD_COMMENT -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:146:4: TIKZEDT_CMD_COMMENT
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
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:146:30: ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:149:1: tikz_styleorsetorcmd : ( tikz_style | tikz_set | tikz_cmd_comment );
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:150:2: ( tikz_style | tikz_set | tikz_cmd_comment )
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
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:150:4: tikz_style
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
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:150:17: tikz_set
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
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:150:28: tikz_cmd_comment
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:153:1: dontcare_preamble : ~ ( '\\\\begin' | '\\\\tikzstyle' | '\\\\tikzset' | TIKZEDT_CMD_COMMENT ) ;
    public simpletikzParser.dontcare_preamble_return dontcare_preamble() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_preamble_return retval = new simpletikzParser.dontcare_preamble_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set14 = null;

        object set14_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:154:2: (~ ( '\\\\begin' | '\\\\tikzstyle' | '\\\\tikzset' | TIKZEDT_CMD_COMMENT ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:154:4: ~ ( '\\\\begin' | '\\\\tikzstyle' | '\\\\tikzset' | TIKZEDT_CMD_COMMENT )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set14 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= IM_DONTCARE) || (input.LA(1) >= ID && input.LA(1) <= SOMETHING) || (input.LA(1) >= 39 && input.LA(1) <= 78) ) 
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:156:1: otherbegin : '\\\\begin' '{' idd2 '}' ;
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:157:2: ( '\\\\begin' '{' idd2 '}' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:157:4: '\\\\begin' '{' idd2 '}'
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:160:1: tikz_style : '\\\\tikzstyle' '{' idd '}' '=' tikz_options -> ^( IM_STYLE idd tikz_options ) ;
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:161:2: ( '\\\\tikzstyle' '{' idd '}' '=' tikz_options -> ^( IM_STYLE idd tikz_options ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:161:4: '\\\\tikzstyle' '{' idd '}' '=' tikz_options
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
            	// 161:47: -> ^( IM_STYLE idd tikz_options )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:161:50: ^( IM_STYLE idd tikz_options )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:164:1: tikz_options : squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) ;
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:165:2: ( squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:165:5: squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end
            {
            	PushFollow(FOLLOW_squarebr_start_in_tikz_options438);
            	squarebr_start25 = squarebr_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_squarebr_start.Add(squarebr_start25.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:165:20: ( option ( ',' option )* ( ',' )? )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( ((LA7_0 >= IM_PATH && LA7_0 <= 38) || (LA7_0 >= 50 && LA7_0 <= 78)) )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:165:21: option ( ',' option )* ( ',' )?
            	        {
            	        	PushFollow(FOLLOW_option_in_tikz_options441);
            	        	option26 = option();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_option.Add(option26.Tree);
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:165:28: ( ',' option )*
            	        	do 
            	        	{
            	        	    int alt5 = 2;
            	        	    int LA5_0 = input.LA(1);

            	        	    if ( (LA5_0 == 42) )
            	        	    {
            	        	        int LA5_1 = input.LA(2);

            	        	        if ( ((LA5_1 >= IM_PATH && LA5_1 <= 38) || (LA5_1 >= 50 && LA5_1 <= 78)) )
            	        	        {
            	        	            alt5 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt5) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:165:29: ',' option
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

            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:165:42: ( ',' )?
            	        	int alt6 = 2;
            	        	int LA6_0 = input.LA(1);

            	        	if ( (LA6_0 == 42) )
            	        	{
            	        	    alt6 = 1;
            	        	}
            	        	switch (alt6) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:165:42: ','
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
            	// 165:63: -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:165:66: ^( IM_OPTIONS squarebr_start ( option )* squarebr_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTIONS, "IM_OPTIONS"), root_1);

            	    adaptor.AddChild(root_1, stream_squarebr_start.NextTree());
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:165:94: ( option )*
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:168:1: option : ( option_style | option_kv );
    public simpletikzParser.option_return option() // throws RecognitionException [1]
    {   
        simpletikzParser.option_return retval = new simpletikzParser.option_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.option_style_return option_style31 = default(simpletikzParser.option_style_return);

        simpletikzParser.option_kv_return option_kv32 = default(simpletikzParser.option_kv_return);



        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:169:2: ( option_style | option_kv )
            int alt8 = 2;
            alt8 = dfa8.Predict(input);
            switch (alt8) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:169:4: option_style
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
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:170:5: option_kv
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:173:1: option_kv : idd ( '=' iddornumberunitorstringorrange )? -> ^( IM_OPTION_KV idd ( iddornumberunitorstringorrange )? ) ;
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:174:2: ( idd ( '=' iddornumberunitorstringorrange )? -> ^( IM_OPTION_KV idd ( iddornumberunitorstringorrange )? ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:174:4: idd ( '=' iddornumberunitorstringorrange )?
            {
            	PushFollow(FOLLOW_idd_in_option_kv503);
            	idd33 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idd.Add(idd33.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:174:8: ( '=' iddornumberunitorstringorrange )?
            	int alt9 = 2;
            	int LA9_0 = input.LA(1);

            	if ( (LA9_0 == 41) )
            	{
            	    alt9 = 1;
            	}
            	switch (alt9) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:174:9: '=' iddornumberunitorstringorrange
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
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:174:50: ^( IM_OPTION_KV idd ( iddornumberunitorstringorrange )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTION_KV, "IM_OPTION_KV"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:174:69: ( iddornumberunitorstringorrange )?
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:177:1: tikzstring : '{' ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* '}' -> ^( IM_STRING '{' '}' ) ;
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:178:2: ( '{' ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* '}' -> ^( IM_STRING '{' '}' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:178:4: '{' ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* '}'
            {
            	char_literal36=(IToken)Match(input,39,FOLLOW_39_in_tikzstring536); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_39.Add(char_literal36);

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:178:8: ( no_rlbrace )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( ((LA10_0 >= IM_PATH && LA10_0 <= 38) || (LA10_0 >= 41 && LA10_0 <= 78)) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:178:8: no_rlbrace
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

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:178:20: ( tikzstring ( no_rlbrace )* )*
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
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:178:21: tikzstring ( no_rlbrace )*
            			    {
            			    	PushFollow(FOLLOW_tikzstring_in_tikzstring542);
            			    	tikzstring38 = tikzstring();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikzstring.Add(tikzstring38.Tree);
            			    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:178:32: ( no_rlbrace )*
            			    	do 
            			    	{
            			    	    int alt11 = 2;
            			    	    int LA11_0 = input.LA(1);

            			    	    if ( ((LA11_0 >= IM_PATH && LA11_0 <= 38) || (LA11_0 >= 41 && LA11_0 <= 78)) )
            			    	    {
            			    	        alt11 = 1;
            			    	    }


            			    	    switch (alt11) 
            			    		{
            			    			case 1 :
            			    			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:178:32: no_rlbrace
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
            	// elements:          39, 40
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
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:178:53: ^( IM_STRING '{' '}' )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:181:1: no_rlbrace : ~ ( '{' | '}' ) ;
    public simpletikzParser.no_rlbrace_return no_rlbrace() // throws RecognitionException [1]
    {   
        simpletikzParser.no_rlbrace_return retval = new simpletikzParser.no_rlbrace_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set41 = null;

        object set41_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:182:2: (~ ( '{' | '}' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:182:4: ~ ( '{' | '}' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set41 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= 38) || (input.LA(1) >= 41 && input.LA(1) <= 78) ) 
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:184:1: iddornumberunitorstringorrange : ( range | numberunit | bracedcoord | idd | tikzstring );
    public simpletikzParser.iddornumberunitorstringorrange_return iddornumberunitorstringorrange() // throws RecognitionException [1]
    {   
        simpletikzParser.iddornumberunitorstringorrange_return retval = new simpletikzParser.iddornumberunitorstringorrange_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.range_return range42 = default(simpletikzParser.range_return);

        simpletikzParser.numberunit_return numberunit43 = default(simpletikzParser.numberunit_return);

        simpletikzParser.bracedcoord_return bracedcoord44 = default(simpletikzParser.bracedcoord_return);

        simpletikzParser.idd_return idd45 = default(simpletikzParser.idd_return);

        simpletikzParser.tikzstring_return tikzstring46 = default(simpletikzParser.tikzstring_return);



        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:185:2: ( range | numberunit | bracedcoord | idd | tikzstring )
            int alt13 = 5;
            alt13 = dfa13.Predict(input);
            switch (alt13) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:185:5: range
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_range_in_iddornumberunitorstringorrange590);
                    	range42 = range();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, range42.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:185:13: numberunit
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_numberunit_in_iddornumberunitorstringorrange594);
                    	numberunit43 = numberunit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, numberunit43.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:185:26: bracedcoord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_bracedcoord_in_iddornumberunitorstringorrange598);
                    	bracedcoord44 = bracedcoord();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bracedcoord44.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:185:40: idd
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_idd_in_iddornumberunitorstringorrange602);
                    	idd45 = idd();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idd45.Tree);

                    }
                    break;
                case 5 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:185:46: tikzstring
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikzstring_in_iddornumberunitorstringorrange606);
                    	tikzstring46 = tikzstring();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzstring46.Tree);

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

    public class bracedcoord_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "bracedcoord"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:187:1: bracedcoord : '{' coord '}' ;
    public simpletikzParser.bracedcoord_return bracedcoord() // throws RecognitionException [1]
    {   
        simpletikzParser.bracedcoord_return retval = new simpletikzParser.bracedcoord_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal47 = null;
        IToken char_literal49 = null;
        simpletikzParser.coord_return coord48 = default(simpletikzParser.coord_return);


        object char_literal47_tree=null;
        object char_literal49_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:188:2: ( '{' coord '}' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:188:4: '{' coord '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal47=(IToken)Match(input,39,FOLLOW_39_in_bracedcoord619); if (state.failed) return retval;
            	PushFollow(FOLLOW_coord_in_bracedcoord623);
            	coord48 = coord();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, coord48.Tree);
            	char_literal49=(IToken)Match(input,40,FOLLOW_40_in_bracedcoord625); if (state.failed) return retval;

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
    // $ANTLR end "bracedcoord"

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:190:1: range : numberunit ':' numberunit -> ^( IM_STRING numberunit ':' numberunit ) ;
    public simpletikzParser.range_return range() // throws RecognitionException [1]
    {   
        simpletikzParser.range_return retval = new simpletikzParser.range_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal51 = null;
        simpletikzParser.numberunit_return numberunit50 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit52 = default(simpletikzParser.numberunit_return);


        object char_literal51_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:191:2: ( numberunit ':' numberunit -> ^( IM_STRING numberunit ':' numberunit ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:191:4: numberunit ':' numberunit
            {
            	PushFollow(FOLLOW_numberunit_in_range636);
            	numberunit50 = numberunit();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit50.Tree);
            	char_literal51=(IToken)Match(input,43,FOLLOW_43_in_range638); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_43.Add(char_literal51);

            	PushFollow(FOLLOW_numberunit_in_range640);
            	numberunit52 = numberunit();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit52.Tree);


            	// AST REWRITE
            	// elements:          numberunit, numberunit, 43
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 191:30: -> ^( IM_STRING numberunit ':' numberunit )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:191:33: ^( IM_STRING numberunit ':' numberunit )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STRING, "IM_STRING"), root_1);

            	    adaptor.AddChild(root_1, stream_numberunit.NextTree());
            	    adaptor.AddChild(root_1, stream_43.NextNode());
            	    adaptor.AddChild(root_1, stream_numberunit.NextTree());

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:193:1: option_style : idd '/.style' '=' '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}' -> ^( IM_OPTION_STYLE idd ( option_kv )* ) ;
    public simpletikzParser.option_style_return option_style() // throws RecognitionException [1]
    {   
        simpletikzParser.option_style_return retval = new simpletikzParser.option_style_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal54 = null;
        IToken char_literal55 = null;
        IToken char_literal56 = null;
        IToken char_literal58 = null;
        IToken char_literal60 = null;
        IToken char_literal61 = null;
        simpletikzParser.idd_return idd53 = default(simpletikzParser.idd_return);

        simpletikzParser.option_kv_return option_kv57 = default(simpletikzParser.option_kv_return);

        simpletikzParser.option_kv_return option_kv59 = default(simpletikzParser.option_kv_return);


        object string_literal54_tree=null;
        object char_literal55_tree=null;
        object char_literal56_tree=null;
        object char_literal58_tree=null;
        object char_literal60_tree=null;
        object char_literal61_tree=null;
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_option_kv = new RewriteRuleSubtreeStream(adaptor,"rule option_kv");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:194:2: ( idd '/.style' '=' '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}' -> ^( IM_OPTION_STYLE idd ( option_kv )* ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:194:4: idd '/.style' '=' '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}'
            {
            	PushFollow(FOLLOW_idd_in_option_style664);
            	idd53 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idd.Add(idd53.Tree);
            	string_literal54=(IToken)Match(input,44,FOLLOW_44_in_option_style666); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_44.Add(string_literal54);

            	char_literal55=(IToken)Match(input,41,FOLLOW_41_in_option_style668); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(char_literal55);

            	char_literal56=(IToken)Match(input,39,FOLLOW_39_in_option_style670); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_39.Add(char_literal56);

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:194:26: ( option_kv ( ',' option_kv )* )?
            	int alt15 = 2;
            	int LA15_0 = input.LA(1);

            	if ( ((LA15_0 >= IM_PATH && LA15_0 <= 38) || (LA15_0 >= 50 && LA15_0 <= 78)) )
            	{
            	    alt15 = 1;
            	}
            	switch (alt15) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:194:27: option_kv ( ',' option_kv )*
            	        {
            	        	PushFollow(FOLLOW_option_kv_in_option_style673);
            	        	option_kv57 = option_kv();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_option_kv.Add(option_kv57.Tree);
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:194:37: ( ',' option_kv )*
            	        	do 
            	        	{
            	        	    int alt14 = 2;
            	        	    int LA14_0 = input.LA(1);

            	        	    if ( (LA14_0 == 42) )
            	        	    {
            	        	        int LA14_1 = input.LA(2);

            	        	        if ( ((LA14_1 >= IM_PATH && LA14_1 <= 38) || (LA14_1 >= 50 && LA14_1 <= 78)) )
            	        	        {
            	        	            alt14 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt14) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:194:38: ',' option_kv
            	        			    {
            	        			    	char_literal58=(IToken)Match(input,42,FOLLOW_42_in_option_style676); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_42.Add(char_literal58);

            	        			    	PushFollow(FOLLOW_option_kv_in_option_style678);
            	        			    	option_kv59 = option_kv();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( (state.backtracking==0) ) stream_option_kv.Add(option_kv59.Tree);

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

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:194:57: ( ',' )?
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( (LA16_0 == 42) )
            	{
            	    alt16 = 1;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:194:57: ','
            	        {
            	        	char_literal60=(IToken)Match(input,42,FOLLOW_42_in_option_style685); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_42.Add(char_literal60);


            	        }
            	        break;

            	}

            	char_literal61=(IToken)Match(input,40,FOLLOW_40_in_option_style688); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_40.Add(char_literal61);



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
            	// 194:67: -> ^( IM_OPTION_STYLE idd ( option_kv )* )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:194:70: ^( IM_OPTION_STYLE idd ( option_kv )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTION_STYLE, "IM_OPTION_STYLE"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:194:92: ( option_kv )*
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:206:1: idd : idd_heavenknowswhythisisnecessary -> ^( IM_ID ) ;
    public simpletikzParser.idd_return idd() // throws RecognitionException [1]
    {   
        simpletikzParser.idd_return retval = new simpletikzParser.idd_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.idd_heavenknowswhythisisnecessary_return idd_heavenknowswhythisisnecessary62 = default(simpletikzParser.idd_heavenknowswhythisisnecessary_return);


        RewriteRuleSubtreeStream stream_idd_heavenknowswhythisisnecessary = new RewriteRuleSubtreeStream(adaptor,"rule idd_heavenknowswhythisisnecessary");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:207:2: ( idd_heavenknowswhythisisnecessary -> ^( IM_ID ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:207:4: idd_heavenknowswhythisisnecessary
            {
            	PushFollow(FOLLOW_idd_heavenknowswhythisisnecessary_in_idd723);
            	idd_heavenknowswhythisisnecessary62 = idd_heavenknowswhythisisnecessary();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idd_heavenknowswhythisisnecessary.Add(idd_heavenknowswhythisisnecessary62.Tree);


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
            	// 207:39: -> ^( IM_ID )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:207:42: ^( IM_ID )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:209:1: idd_heavenknowswhythisisnecessary : (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' ) )+ ;
    public simpletikzParser.idd_heavenknowswhythisisnecessary_return idd_heavenknowswhythisisnecessary() // throws RecognitionException [1]
    {   
        simpletikzParser.idd_heavenknowswhythisisnecessary_return retval = new simpletikzParser.idd_heavenknowswhythisisnecessary_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set63 = null;

        object set63_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:210:3: ( (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' ) )+ )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:210:6: (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' ) )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:210:6: (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' ) )+
            	int cnt17 = 0;
            	do 
            	{
            	    int alt17 = 2;
            	    int LA17_0 = input.LA(1);

            	    if ( ((LA17_0 >= IM_PATH && LA17_0 <= 38) || (LA17_0 >= 50 && LA17_0 <= 78)) )
            	    {
            	        alt17 = 1;
            	    }


            	    switch (alt17) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:210:6: ~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' )
            			    {
            			    	set63 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= 38) || (input.LA(1) >= 50 && input.LA(1) <= 78) ) 
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:211:1: idd2 : ( ID )+ -> ^( IM_ID ) ;
    public simpletikzParser.idd2_return idd2() // throws RecognitionException [1]
    {   
        simpletikzParser.idd2_return retval = new simpletikzParser.idd2_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID64 = null;

        object ID64_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:212:2: ( ( ID )+ -> ^( IM_ID ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:212:4: ( ID )+
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:212:4: ( ID )+
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
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:212:4: ID
            			    {
            			    	ID64=(IToken)Match(input,ID,FOLLOW_ID_in_idd2797); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_ID.Add(ID64);


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
            	// 212:8: -> ^( IM_ID )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:212:11: ^( IM_ID )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:216:1: numberunit : number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) ;
    public simpletikzParser.numberunit_return numberunit() // throws RecognitionException [1]
    {   
        simpletikzParser.numberunit_return retval = new simpletikzParser.numberunit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.number_return number65 = default(simpletikzParser.number_return);

        simpletikzParser.unit_return unit66 = default(simpletikzParser.unit_return);


        RewriteRuleSubtreeStream stream_unit = new RewriteRuleSubtreeStream(adaptor,"rule unit");
        RewriteRuleSubtreeStream stream_number = new RewriteRuleSubtreeStream(adaptor,"rule number");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:217:2: ( number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:217:4: number ( unit )?
            {
            	PushFollow(FOLLOW_number_in_numberunit820);
            	number65 = number();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_number.Add(number65.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:217:11: ( unit )?
            	int alt19 = 2;
            	int LA19_0 = input.LA(1);

            	if ( ((LA19_0 >= 50 && LA19_0 <= 55)) )
            	{
            	    alt19 = 1;
            	}
            	switch (alt19) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:217:11: unit
            	        {
            	        	PushFollow(FOLLOW_unit_in_numberunit822);
            	        	unit66 = unit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_unit.Add(unit66.Tree);

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
            	// 217:17: -> ^( IM_NUMBERUNIT number ( unit )? )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:217:20: ^( IM_NUMBERUNIT number ( unit )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NUMBERUNIT, "IM_NUMBERUNIT"), root_1);

            	    adaptor.AddChild(root_1, stream_number.NextTree());
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:217:43: ( unit )?
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:221:1: number : ( FLOAT_WO_EXP | INT ) ;
    public simpletikzParser.number_return number() // throws RecognitionException [1]
    {   
        simpletikzParser.number_return retval = new simpletikzParser.number_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set67 = null;

        object set67_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:222:2: ( ( FLOAT_WO_EXP | INT ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:222:4: ( FLOAT_WO_EXP | INT )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set67 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= FLOAT_WO_EXP && input.LA(1) <= INT) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set67));
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:225:1: unit : ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' | 'em' );
    public simpletikzParser.unit_return unit() // throws RecognitionException [1]
    {   
        simpletikzParser.unit_return retval = new simpletikzParser.unit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set68 = null;

        object set68_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:226:2: ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' | 'em' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set68 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 50 && input.LA(1) <= 55) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set68));
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:229:1: tikz_set : tikz_set_start ( option ( ',' option )* )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) ;
    public simpletikzParser.tikz_set_return tikz_set() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_set_return retval = new simpletikzParser.tikz_set_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal71 = null;
        simpletikzParser.tikz_set_start_return tikz_set_start69 = default(simpletikzParser.tikz_set_start_return);

        simpletikzParser.option_return option70 = default(simpletikzParser.option_return);

        simpletikzParser.option_return option72 = default(simpletikzParser.option_return);

        simpletikzParser.roundbr_end_return roundbr_end73 = default(simpletikzParser.roundbr_end_return);


        object char_literal71_tree=null;
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleSubtreeStream stream_tikz_set_start = new RewriteRuleSubtreeStream(adaptor,"rule tikz_set_start");
        RewriteRuleSubtreeStream stream_roundbr_end = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        RewriteRuleSubtreeStream stream_option = new RewriteRuleSubtreeStream(adaptor,"rule option");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:230:2: ( tikz_set_start ( option ( ',' option )* )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:230:5: tikz_set_start ( option ( ',' option )* )? roundbr_end
            {
            	PushFollow(FOLLOW_tikz_set_start_in_tikz_set903);
            	tikz_set_start69 = tikz_set_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikz_set_start.Add(tikz_set_start69.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:230:20: ( option ( ',' option )* )?
            	int alt21 = 2;
            	int LA21_0 = input.LA(1);

            	if ( ((LA21_0 >= IM_PATH && LA21_0 <= 38) || (LA21_0 >= 50 && LA21_0 <= 78)) )
            	{
            	    alt21 = 1;
            	}
            	switch (alt21) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:230:21: option ( ',' option )*
            	        {
            	        	PushFollow(FOLLOW_option_in_tikz_set906);
            	        	option70 = option();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_option.Add(option70.Tree);
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:230:28: ( ',' option )*
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
            	        			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:230:29: ',' option
            	        			    {
            	        			    	char_literal71=(IToken)Match(input,42,FOLLOW_42_in_tikz_set909); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_42.Add(char_literal71);

            	        			    	PushFollow(FOLLOW_option_in_tikz_set911);
            	        			    	option72 = option();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( (state.backtracking==0) ) stream_option.Add(option72.Tree);

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

            	PushFollow(FOLLOW_roundbr_end_in_tikz_set917);
            	roundbr_end73 = roundbr_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_roundbr_end.Add(roundbr_end73.Tree);


            	// AST REWRITE
            	// elements:          option, tikz_set_start, roundbr_end
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 230:56: -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:230:59: ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_TIKZSET, "IM_TIKZSET"), root_1);

            	    adaptor.AddChild(root_1, stream_tikz_set_start.NextTree());
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:230:87: ( option )*
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:235:1: tikzpicture : tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) ;
    public simpletikzParser.tikzpicture_return tikzpicture() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_return retval = new simpletikzParser.tikzpicture_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzpicture_start_return tikzpicture_start74 = default(simpletikzParser.tikzpicture_start_return);

        simpletikzParser.tikz_options_return tikz_options75 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody_return tikzbody76 = default(simpletikzParser.tikzbody_return);

        simpletikzParser.tikzpicture_end_return tikzpicture_end77 = default(simpletikzParser.tikzpicture_end_return);


        RewriteRuleSubtreeStream stream_tikzpicture_end = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_end");
        RewriteRuleSubtreeStream stream_tikzpicture_start = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_start");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:236:2: ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:236:5: tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end
            {
            	PushFollow(FOLLOW_tikzpicture_start_in_tikzpicture945);
            	tikzpicture_start74 = tikzpicture_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzpicture_start.Add(tikzpicture_start74.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:236:23: ( tikz_options )?
            	int alt22 = 2;
            	int LA22_0 = input.LA(1);

            	if ( (LA22_0 == 47) )
            	{
            	    alt22 = 1;
            	}
            	switch (alt22) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:236:23: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_tikzpicture947);
            	        	tikz_options75 = tikz_options();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_tikz_options.Add(tikz_options75.Tree);

            	        }
            	        break;

            	}

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:236:37: ( tikzbody )?
            	int alt23 = 2;
            	int LA23_0 = input.LA(1);

            	if ( ((LA23_0 >= IM_PATH && LA23_0 <= 46) || (LA23_0 >= 48 && LA23_0 <= 55) || (LA23_0 >= 57 && LA23_0 <= 78)) )
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
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:236:37: tikzbody
            	        {
            	        	PushFollow(FOLLOW_tikzbody_in_tikzpicture950);
            	        	tikzbody76 = tikzbody();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_tikzbody.Add(tikzbody76.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzpicture_end_in_tikzpicture953);
            	tikzpicture_end77 = tikzpicture_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzpicture_end.Add(tikzpicture_end77.Tree);


            	// AST REWRITE
            	// elements:          tikzbody, tikz_options, tikzpicture_end, tikzpicture_start
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 236:64: -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:236:67: ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PICTURE, "IM_PICTURE"), root_1);

            	    adaptor.AddChild(root_1, stream_tikzpicture_start.NextTree());
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:236:98: ( tikz_options )?
            	    if ( stream_tikz_options.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikz_options.NextTree());

            	    }
            	    stream_tikz_options.Reset();
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:236:112: ( tikzbody )?
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:239:1: tikzbody : ( tikzscope | tikzpath | tikznode_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )* ;
    public simpletikzParser.tikzbody_return tikzbody() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzbody_return retval = new simpletikzParser.tikzbody_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_return tikzscope78 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath79 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznode_ext_return tikznode_ext80 = default(simpletikzParser.tikznode_ext_return);

        simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext81 = default(simpletikzParser.tikzcoordinate_ext_return);

        simpletikzParser.tikz_set_return tikz_set82 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style83 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin84 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend85 = default(simpletikzParser.otherend_return);

        simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr86 = default(simpletikzParser.dontcare_body_nobr_return);

        simpletikzParser.tikzscope_return tikzscope87 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath88 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznode_ext_return tikznode_ext89 = default(simpletikzParser.tikznode_ext_return);

        simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext90 = default(simpletikzParser.tikzcoordinate_ext_return);

        simpletikzParser.tikz_set_return tikz_set91 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style92 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin93 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend94 = default(simpletikzParser.otherend_return);

        simpletikzParser.dontcare_body_return dontcare_body95 = default(simpletikzParser.dontcare_body_return);



        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:240:2: ( ( tikzscope | tikzpath | tikznode_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )* )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:240:4: ( tikzscope | tikzpath | tikznode_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:240:4: ( tikzscope | tikzpath | tikznode_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr )
            	int alt24 = 9;
            	alt24 = dfa24.Predict(input);
            	switch (alt24) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:240:6: tikzscope
            	        {
            	        	PushFollow(FOLLOW_tikzscope_in_tikzbody983);
            	        	tikzscope78 = tikzscope();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzscope78.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:240:18: tikzpath
            	        {
            	        	PushFollow(FOLLOW_tikzpath_in_tikzbody987);
            	        	tikzpath79 = tikzpath();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath79.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:240:29: tikznode_ext
            	        {
            	        	PushFollow(FOLLOW_tikznode_ext_in_tikzbody991);
            	        	tikznode_ext80 = tikznode_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_ext80.Tree);

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:240:44: tikzcoordinate_ext
            	        {
            	        	PushFollow(FOLLOW_tikzcoordinate_ext_in_tikzbody995);
            	        	tikzcoordinate_ext81 = tikzcoordinate_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_ext81.Tree);

            	        }
            	        break;
            	    case 5 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:240:65: tikz_set
            	        {
            	        	PushFollow(FOLLOW_tikz_set_in_tikzbody999);
            	        	tikz_set82 = tikz_set();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set82.Tree);

            	        }
            	        break;
            	    case 6 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:240:76: tikz_style
            	        {
            	        	PushFollow(FOLLOW_tikz_style_in_tikzbody1003);
            	        	tikz_style83 = tikz_style();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style83.Tree);

            	        }
            	        break;
            	    case 7 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:240:89: otherbegin
            	        {
            	        	PushFollow(FOLLOW_otherbegin_in_tikzbody1007);
            	        	otherbegin84 = otherbegin();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;
            	    case 8 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:240:103: otherend
            	        {
            	        	PushFollow(FOLLOW_otherend_in_tikzbody1012);
            	        	otherend85 = otherend();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;
            	    case 9 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:240:115: dontcare_body_nobr
            	        {
            	        	PushFollow(FOLLOW_dontcare_body_nobr_in_tikzbody1017);
            	        	dontcare_body_nobr86 = dontcare_body_nobr();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;

            	}

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:241:3: ( tikzscope | tikzpath | tikznode_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*
            	do 
            	{
            	    int alt25 = 10;
            	    alt25 = dfa25.Predict(input);
            	    switch (alt25) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:241:5: tikzscope
            			    {
            			    	PushFollow(FOLLOW_tikzscope_in_tikzbody1028);
            			    	tikzscope87 = tikzscope();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzscope87.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:241:17: tikzpath
            			    {
            			    	PushFollow(FOLLOW_tikzpath_in_tikzbody1032);
            			    	tikzpath88 = tikzpath();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath88.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:241:28: tikznode_ext
            			    {
            			    	PushFollow(FOLLOW_tikznode_ext_in_tikzbody1036);
            			    	tikznode_ext89 = tikznode_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_ext89.Tree);

            			    }
            			    break;
            			case 4 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:241:43: tikzcoordinate_ext
            			    {
            			    	PushFollow(FOLLOW_tikzcoordinate_ext_in_tikzbody1040);
            			    	tikzcoordinate_ext90 = tikzcoordinate_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_ext90.Tree);

            			    }
            			    break;
            			case 5 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:241:64: tikz_set
            			    {
            			    	PushFollow(FOLLOW_tikz_set_in_tikzbody1044);
            			    	tikz_set91 = tikz_set();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set91.Tree);

            			    }
            			    break;
            			case 6 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:241:75: tikz_style
            			    {
            			    	PushFollow(FOLLOW_tikz_style_in_tikzbody1048);
            			    	tikz_style92 = tikz_style();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style92.Tree);

            			    }
            			    break;
            			case 7 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:241:88: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzbody1052);
            			    	otherbegin93 = otherbegin();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;
            			case 8 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:241:102: otherend
            			    {
            			    	PushFollow(FOLLOW_otherend_in_tikzbody1057);
            			    	otherend94 = otherend();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;
            			case 9 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:241:114: dontcare_body
            			    {
            			    	PushFollow(FOLLOW_dontcare_body_in_tikzbody1062);
            			    	dontcare_body95 = dontcare_body();
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:244:1: dontcare_body_nobr : (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) ) ;
    public simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body_nobr_return retval = new simpletikzParser.dontcare_body_nobr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set96 = null;

        object set96_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:245:2: ( (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:245:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:245:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) )
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:245:5: ~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' )
            	{
            		set96 = (IToken)input.LT(1);
            		if ( (input.LA(1) >= IM_PATH && input.LA(1) <= SOMETHING) || (input.LA(1) >= 39 && input.LA(1) <= 46) || (input.LA(1) >= 48 && input.LA(1) <= 55) || (input.LA(1) >= 63 && input.LA(1) <= 78) ) 
            		{
            		    input.Consume();
            		    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set96));
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:247:1: dontcare_body : (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) ) ;
    public simpletikzParser.dontcare_body_return dontcare_body() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body_return retval = new simpletikzParser.dontcare_body_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set97 = null;

        object set97_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:248:2: ( (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:248:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:248:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) )
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:248:5: ~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' )
            	{
            		set97 = (IToken)input.LT(1);
            		if ( (input.LA(1) >= IM_PATH && input.LA(1) <= SOMETHING) || (input.LA(1) >= 39 && input.LA(1) <= 55) || (input.LA(1) >= 63 && input.LA(1) <= 78) ) 
            		{
            		    input.Consume();
            		    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set97));
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:250:1: otherend : '\\\\end' '{' idd2 '}' ;
    public simpletikzParser.otherend_return otherend() // throws RecognitionException [1]
    {   
        simpletikzParser.otherend_return retval = new simpletikzParser.otherend_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal98 = null;
        IToken char_literal99 = null;
        IToken char_literal101 = null;
        simpletikzParser.idd2_return idd2100 = default(simpletikzParser.idd2_return);


        object string_literal98_tree=null;
        object char_literal99_tree=null;
        object char_literal101_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:251:2: ( '\\\\end' '{' idd2 '}' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:251:4: '\\\\end' '{' idd2 '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal98=(IToken)Match(input,56,FOLLOW_56_in_otherend1192); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal98_tree = (object)adaptor.Create(string_literal98);
            		adaptor.AddChild(root_0, string_literal98_tree);
            	}
            	char_literal99=(IToken)Match(input,39,FOLLOW_39_in_otherend1194); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal99_tree = (object)adaptor.Create(char_literal99);
            		adaptor.AddChild(root_0, char_literal99_tree);
            	}
            	PushFollow(FOLLOW_idd2_in_otherend1196);
            	idd2100 = idd2();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idd2100.Tree);
            	char_literal101=(IToken)Match(input,40,FOLLOW_40_in_otherend1198); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal101_tree = (object)adaptor.Create(char_literal101);
            		adaptor.AddChild(root_0, char_literal101_tree);
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:265:1: tikzscope : tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end ) ;
    public simpletikzParser.tikzscope_return tikzscope() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_return retval = new simpletikzParser.tikzscope_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_start_return tikzscope_start102 = default(simpletikzParser.tikzscope_start_return);

        simpletikzParser.tikz_options_return tikz_options103 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody_return tikzbody104 = default(simpletikzParser.tikzbody_return);

        simpletikzParser.tikzscope_end_return tikzscope_end105 = default(simpletikzParser.tikzscope_end_return);


        RewriteRuleSubtreeStream stream_tikzscope_start = new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_start");
        RewriteRuleSubtreeStream stream_tikzscope_end = new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_end");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:266:2: ( tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:266:4: tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end
            {
            	PushFollow(FOLLOW_tikzscope_start_in_tikzscope1225);
            	tikzscope_start102 = tikzscope_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzscope_start.Add(tikzscope_start102.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:266:20: ( tikz_options )?
            	int alt26 = 2;
            	int LA26_0 = input.LA(1);

            	if ( (LA26_0 == 47) )
            	{
            	    alt26 = 1;
            	}
            	switch (alt26) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:266:20: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_tikzscope1227);
            	        	tikz_options103 = tikz_options();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_tikz_options.Add(tikz_options103.Tree);

            	        }
            	        break;

            	}

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:266:34: ( tikzbody )?
            	int alt27 = 2;
            	int LA27_0 = input.LA(1);

            	if ( ((LA27_0 >= IM_PATH && LA27_0 <= 46) || (LA27_0 >= 48 && LA27_0 <= 55) || (LA27_0 >= 57 && LA27_0 <= 78)) )
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
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:266:34: tikzbody
            	        {
            	        	PushFollow(FOLLOW_tikzbody_in_tikzscope1230);
            	        	tikzbody104 = tikzbody();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_tikzbody.Add(tikzbody104.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzscope_end_in_tikzscope1233);
            	tikzscope_end105 = tikzscope_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzscope_end.Add(tikzscope_end105.Tree);


            	// AST REWRITE
            	// elements:          tikzbody, tikzscope_start, tikzscope_end, tikz_options
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 266:59: -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:266:62: ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_SCOPE, "IM_SCOPE"), root_1);

            	    adaptor.AddChild(root_1, stream_tikzscope_start.NextTree());
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:266:89: ( tikz_options )?
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:292:1: tikzpath : ( path_start ( tikzpath_element )* semicolon_end -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end ) | path_start 'let' ( let_assignment )* 'in' ( tikzpath_element )* semicolon_end -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end ) );
    public simpletikzParser.tikzpath_return tikzpath() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_return retval = new simpletikzParser.tikzpath_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal110 = null;
        IToken string_literal112 = null;
        simpletikzParser.path_start_return path_start106 = default(simpletikzParser.path_start_return);

        simpletikzParser.tikzpath_element_return tikzpath_element107 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end108 = default(simpletikzParser.semicolon_end_return);

        simpletikzParser.path_start_return path_start109 = default(simpletikzParser.path_start_return);

        simpletikzParser.let_assignment_return let_assignment111 = default(simpletikzParser.let_assignment_return);

        simpletikzParser.tikzpath_element_return tikzpath_element113 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end114 = default(simpletikzParser.semicolon_end_return);


        object string_literal110_tree=null;
        object string_literal112_tree=null;
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_63 = new RewriteRuleTokenStream(adaptor,"token 63");
        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_path_start = new RewriteRuleSubtreeStream(adaptor,"rule path_start");
        RewriteRuleSubtreeStream stream_let_assignment = new RewriteRuleSubtreeStream(adaptor,"rule let_assignment");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:293:2: ( path_start ( tikzpath_element )* semicolon_end -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end ) | path_start 'let' ( let_assignment )* 'in' ( tikzpath_element )* semicolon_end -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end ) )
            int alt31 = 2;
            int LA31_0 = input.LA(1);

            if ( ((LA31_0 >= 59 && LA31_0 <= 62)) )
            {
                int LA31_1 = input.LA(2);

                if ( (LA31_1 == 63) )
                {
                    alt31 = 2;
                }
                else if ( (LA31_1 == ID || LA31_1 == 39 || LA31_1 == 45 || LA31_1 == 47 || LA31_1 == 49 || (LA31_1 >= 64 && LA31_1 <= 65) || (LA31_1 >= 67 && LA31_1 <= 69) || (LA31_1 >= 71 && LA31_1 <= 76)) )
                {
                    alt31 = 1;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d31s1 =
                        new NoViableAltException("", 31, 1, input);

                    throw nvae_d31s1;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d31s0 =
                    new NoViableAltException("", 31, 0, input);

                throw nvae_d31s0;
            }
            switch (alt31) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:293:4: path_start ( tikzpath_element )* semicolon_end
                    {
                    	PushFollow(FOLLOW_path_start_in_tikzpath1288);
                    	path_start106 = path_start();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_path_start.Add(path_start106.Tree);
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:293:15: ( tikzpath_element )*
                    	do 
                    	{
                    	    int alt28 = 2;
                    	    int LA28_0 = input.LA(1);

                    	    if ( (LA28_0 == ID || LA28_0 == 39 || LA28_0 == 45 || LA28_0 == 47 || (LA28_0 >= 64 && LA28_0 <= 65) || (LA28_0 >= 67 && LA28_0 <= 69) || (LA28_0 >= 71 && LA28_0 <= 76)) )
                    	    {
                    	        alt28 = 1;
                    	    }


                    	    switch (alt28) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:293:15: tikzpath_element
                    			    {
                    			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath1290);
                    			    	tikzpath_element107 = tikzpath_element();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element107.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop28;
                    	    }
                    	} while (true);

                    	loop28:
                    		;	// Stops C# compiler whining that label 'loop28' has no statements

                    	PushFollow(FOLLOW_semicolon_end_in_tikzpath1293);
                    	semicolon_end108 = semicolon_end();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_semicolon_end.Add(semicolon_end108.Tree);


                    	// AST REWRITE
                    	// elements:          semicolon_end, path_start, tikzpath_element
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 293:47: -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end )
                    	{
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:293:50: ^( IM_PATH path_start ( tikzpath_element )* semicolon_end )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

                    	    adaptor.AddChild(root_1, stream_path_start.NextTree());
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:293:71: ( tikzpath_element )*
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
                    break;
                case 2 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:294:4: path_start 'let' ( let_assignment )* 'in' ( tikzpath_element )* semicolon_end
                    {
                    	PushFollow(FOLLOW_path_start_in_tikzpath1312);
                    	path_start109 = path_start();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_path_start.Add(path_start109.Tree);
                    	string_literal110=(IToken)Match(input,63,FOLLOW_63_in_tikzpath1314); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_63.Add(string_literal110);

                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:294:21: ( let_assignment )*
                    	do 
                    	{
                    	    int alt29 = 2;
                    	    int LA29_0 = input.LA(1);

                    	    if ( (LA29_0 == COMMAND) )
                    	    {
                    	        alt29 = 1;
                    	    }


                    	    switch (alt29) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:294:21: let_assignment
                    			    {
                    			    	PushFollow(FOLLOW_let_assignment_in_tikzpath1316);
                    			    	let_assignment111 = let_assignment();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_let_assignment.Add(let_assignment111.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop29;
                    	    }
                    	} while (true);

                    	loop29:
                    		;	// Stops C# compiler whining that label 'loop29' has no statements

                    	string_literal112=(IToken)Match(input,51,FOLLOW_51_in_tikzpath1319); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_51.Add(string_literal112);

                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:294:42: ( tikzpath_element )*
                    	do 
                    	{
                    	    int alt30 = 2;
                    	    int LA30_0 = input.LA(1);

                    	    if ( (LA30_0 == ID || LA30_0 == 39 || LA30_0 == 45 || LA30_0 == 47 || (LA30_0 >= 64 && LA30_0 <= 65) || (LA30_0 >= 67 && LA30_0 <= 69) || (LA30_0 >= 71 && LA30_0 <= 76)) )
                    	    {
                    	        alt30 = 1;
                    	    }


                    	    switch (alt30) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:294:42: tikzpath_element
                    			    {
                    			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath1321);
                    			    	tikzpath_element113 = tikzpath_element();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element113.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop30;
                    	    }
                    	} while (true);

                    	loop30:
                    		;	// Stops C# compiler whining that label 'loop30' has no statements

                    	PushFollow(FOLLOW_semicolon_end_in_tikzpath1324);
                    	semicolon_end114 = semicolon_end();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_semicolon_end.Add(semicolon_end114.Tree);


                    	// AST REWRITE
                    	// elements:          semicolon_end, path_start, tikzpath_element
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 294:74: -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end )
                    	{
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:294:77: ^( IM_PATH path_start ( tikzpath_element )* semicolon_end )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

                    	    adaptor.AddChild(root_1, stream_path_start.NextTree());
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:294:98: ( tikzpath_element )*
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
    // $ANTLR end "tikzpath"

    public class let_assignment_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "let_assignment"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:297:1: let_assignment : COMMAND '=' ( tikzpath_element )* ;
    public simpletikzParser.let_assignment_return let_assignment() // throws RecognitionException [1]
    {   
        simpletikzParser.let_assignment_return retval = new simpletikzParser.let_assignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken COMMAND115 = null;
        IToken char_literal116 = null;
        simpletikzParser.tikzpath_element_return tikzpath_element117 = default(simpletikzParser.tikzpath_element_return);


        object COMMAND115_tree=null;
        object char_literal116_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:298:2: ( COMMAND '=' ( tikzpath_element )* )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:298:4: COMMAND '=' ( tikzpath_element )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	COMMAND115=(IToken)Match(input,COMMAND,FOLLOW_COMMAND_in_let_assignment1350); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{COMMAND115_tree = (object)adaptor.Create(COMMAND115);
            		adaptor.AddChild(root_0, COMMAND115_tree);
            	}
            	char_literal116=(IToken)Match(input,41,FOLLOW_41_in_let_assignment1352); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal116_tree = (object)adaptor.Create(char_literal116);
            		adaptor.AddChild(root_0, char_literal116_tree);
            	}
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:298:16: ( tikzpath_element )*
            	do 
            	{
            	    int alt32 = 2;
            	    int LA32_0 = input.LA(1);

            	    if ( (LA32_0 == ID || LA32_0 == 39 || LA32_0 == 45 || LA32_0 == 47 || (LA32_0 >= 64 && LA32_0 <= 65) || (LA32_0 >= 67 && LA32_0 <= 69) || (LA32_0 >= 71 && LA32_0 <= 76)) )
            	    {
            	        alt32 = 1;
            	    }


            	    switch (alt32) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:298:16: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_let_assignment1354);
            			    	tikzpath_element117 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath_element117.Tree);

            			    }
            			    break;

            			default:
            			    goto loop32;
            	    }
            	} while (true);

            	loop32:
            		;	// Stops C# compiler whining that label 'loop32' has no statements


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
    // $ANTLR end "let_assignment"

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:301:1: tikzpath_element : ( tikz_options | coord | tikznode_int | tikzcoordinate_int | circle | arc | roundbr_start ( tikzpath_element )* roundbr_end -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end ) | edgeop );
    public simpletikzParser.tikzpath_element_return tikzpath_element() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_element_return retval = new simpletikzParser.tikzpath_element_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikz_options_return tikz_options118 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.coord_return coord119 = default(simpletikzParser.coord_return);

        simpletikzParser.tikznode_int_return tikznode_int120 = default(simpletikzParser.tikznode_int_return);

        simpletikzParser.tikzcoordinate_int_return tikzcoordinate_int121 = default(simpletikzParser.tikzcoordinate_int_return);

        simpletikzParser.circle_return circle122 = default(simpletikzParser.circle_return);

        simpletikzParser.arc_return arc123 = default(simpletikzParser.arc_return);

        simpletikzParser.roundbr_start_return roundbr_start124 = default(simpletikzParser.roundbr_start_return);

        simpletikzParser.tikzpath_element_return tikzpath_element125 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.roundbr_end_return roundbr_end126 = default(simpletikzParser.roundbr_end_return);

        simpletikzParser.edgeop_return edgeop127 = default(simpletikzParser.edgeop_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_roundbr_start = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_start");
        RewriteRuleSubtreeStream stream_roundbr_end = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:302:2: ( tikz_options | coord | tikznode_int | tikzcoordinate_int | circle | arc | roundbr_start ( tikzpath_element )* roundbr_end -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end ) | edgeop )
            int alt34 = 8;
            switch ( input.LA(1) ) 
            {
            case 47:
            	{
                alt34 = 1;
                }
                break;
            case 45:
            case 75:
            case 76:
            	{
                alt34 = 2;
                }
                break;
            case 65:
            	{
                alt34 = 3;
                }
                break;
            case 64:
            	{
                alt34 = 4;
                }
                break;
            case 67:
            case 68:
            	{
                alt34 = 5;
                }
                break;
            case 69:
            	{
                alt34 = 6;
                }
                break;
            case 39:
            	{
                alt34 = 7;
                }
                break;
            case ID:
            case 71:
            case 72:
            case 73:
            case 74:
            	{
                alt34 = 8;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d34s0 =
            	        new NoViableAltException("", 34, 0, input);

            	    throw nvae_d34s0;
            }

            switch (alt34) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:303:5: tikz_options
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_options_in_tikzpath_element1370);
                    	tikz_options118 = tikz_options();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_options118.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:304:5: coord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_coord_in_tikzpath_element1377);
                    	coord119 = coord();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, coord119.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:305:5: tikznode_int
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikznode_int_in_tikzpath_element1383);
                    	tikznode_int120 = tikznode_int();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_int120.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:306:5: tikzcoordinate_int
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikzcoordinate_int_in_tikzpath_element1389);
                    	tikzcoordinate_int121 = tikzcoordinate_int();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_int121.Tree);

                    }
                    break;
                case 5 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:307:5: circle
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_circle_in_tikzpath_element1395);
                    	circle122 = circle();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;

                    }
                    break;
                case 6 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:308:5: arc
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arc_in_tikzpath_element1402);
                    	arc123 = arc();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;

                    }
                    break;
                case 7 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:309:5: roundbr_start ( tikzpath_element )* roundbr_end
                    {
                    	PushFollow(FOLLOW_roundbr_start_in_tikzpath_element1409);
                    	roundbr_start124 = roundbr_start();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_roundbr_start.Add(roundbr_start124.Tree);
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:309:19: ( tikzpath_element )*
                    	do 
                    	{
                    	    int alt33 = 2;
                    	    int LA33_0 = input.LA(1);

                    	    if ( (LA33_0 == ID || LA33_0 == 39 || LA33_0 == 45 || LA33_0 == 47 || (LA33_0 >= 64 && LA33_0 <= 65) || (LA33_0 >= 67 && LA33_0 <= 69) || (LA33_0 >= 71 && LA33_0 <= 76)) )
                    	    {
                    	        alt33 = 1;
                    	    }


                    	    switch (alt33) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:309:19: tikzpath_element
                    			    {
                    			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath_element1411);
                    			    	tikzpath_element125 = tikzpath_element();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element125.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop33;
                    	    }
                    	} while (true);

                    	loop33:
                    		;	// Stops C# compiler whining that label 'loop33' has no statements

                    	PushFollow(FOLLOW_roundbr_end_in_tikzpath_element1414);
                    	roundbr_end126 = roundbr_end();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_roundbr_end.Add(roundbr_end126.Tree);


                    	// AST REWRITE
                    	// elements:          roundbr_end, tikzpath_element, roundbr_start
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 309:49: -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end )
                    	{
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:309:52: ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

                    	    adaptor.AddChild(root_1, stream_roundbr_start.NextTree());
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:309:76: ( tikzpath_element )*
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
                case 8 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:310:5: edgeop
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_edgeop_in_tikzpath_element1433);
                    	edgeop127 = edgeop();
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:312:1: tikznode_ext : node_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikznode_ext_return tikznode_ext() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_ext_return retval = new simpletikzParser.tikznode_ext_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.node_start_return node_start128 = default(simpletikzParser.node_start_return);

        simpletikzParser.tikznode_core_return tikznode_core129 = default(simpletikzParser.tikznode_core_return);

        simpletikzParser.tikzpath_element_return tikzpath_element130 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end131 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_node_start = new RewriteRuleSubtreeStream(adaptor,"rule node_start");
        RewriteRuleSubtreeStream stream_tikznode_core = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_core");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:313:2: ( node_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:313:4: node_start tikznode_core ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_node_start_in_tikznode_ext1444);
            	node_start128 = node_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_node_start.Add(node_start128.Tree);
            	PushFollow(FOLLOW_tikznode_core_in_tikznode_ext1446);
            	tikznode_core129 = tikznode_core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_core.Add(tikznode_core129.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:313:29: ( tikzpath_element )*
            	do 
            	{
            	    int alt35 = 2;
            	    int LA35_0 = input.LA(1);

            	    if ( (LA35_0 == ID || LA35_0 == 39 || LA35_0 == 45 || LA35_0 == 47 || (LA35_0 >= 64 && LA35_0 <= 65) || (LA35_0 >= 67 && LA35_0 <= 69) || (LA35_0 >= 71 && LA35_0 <= 76)) )
            	    {
            	        alt35 = 1;
            	    }


            	    switch (alt35) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:313:29: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikznode_ext1448);
            			    	tikzpath_element130 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element130.Tree);

            			    }
            			    break;

            			default:
            			    goto loop35;
            	    }
            	} while (true);

            	loop35:
            		;	// Stops C# compiler whining that label 'loop35' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikznode_ext1451);
            	semicolon_end131 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_semicolon_end.Add(semicolon_end131.Tree);


            	// AST REWRITE
            	// elements:          node_start, semicolon_end, tikzpath_element, tikznode_core
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 313:61: -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:313:64: ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_node_start.NextTree());
            	    adaptor.AddChild(root_1, stream_tikznode_core.NextTree());
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:313:99: ( tikzpath_element )*
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

    public class tikzcoordinate_ext_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikzcoordinate_ext"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:317:1: tikzcoordinate_ext : coordinate_start ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ( tikzpath_element )* semicolon_end -> ^( IM_PATH coordinate_start ( tikzcoordinate_core3 )? ( tikzcoordinate_core2 )? ( tikzcoordinate_core1 )? ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_ext_return retval = new simpletikzParser.tikzcoordinate_ext_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.coordinate_start_return coordinate_start132 = default(simpletikzParser.coordinate_start_return);

        simpletikzParser.tikzcoordinate_core3_return tikzcoordinate_core3133 = default(simpletikzParser.tikzcoordinate_core3_return);

        simpletikzParser.tikzcoordinate_core2_return tikzcoordinate_core2134 = default(simpletikzParser.tikzcoordinate_core2_return);

        simpletikzParser.tikzcoordinate_core1_return tikzcoordinate_core1135 = default(simpletikzParser.tikzcoordinate_core1_return);

        simpletikzParser.tikzpath_element_return tikzpath_element136 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end137 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_tikzcoordinate_core3 = new RewriteRuleSubtreeStream(adaptor,"rule tikzcoordinate_core3");
        RewriteRuleSubtreeStream stream_tikzcoordinate_core2 = new RewriteRuleSubtreeStream(adaptor,"rule tikzcoordinate_core2");
        RewriteRuleSubtreeStream stream_coordinate_start = new RewriteRuleSubtreeStream(adaptor,"rule coordinate_start");
        RewriteRuleSubtreeStream stream_tikzcoordinate_core1 = new RewriteRuleSubtreeStream(adaptor,"rule tikzcoordinate_core1");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:318:2: ( coordinate_start ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ( tikzpath_element )* semicolon_end -> ^( IM_PATH coordinate_start ( tikzcoordinate_core3 )? ( tikzcoordinate_core2 )? ( tikzcoordinate_core1 )? ( tikzpath_element )* semicolon_end ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:318:4: coordinate_start ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_coordinate_start_in_tikzcoordinate_ext1479);
            	coordinate_start132 = coordinate_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_coordinate_start.Add(coordinate_start132.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:319:5: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?
            	int alt36 = 4;
            	alt36 = dfa36.Predict(input);
            	switch (alt36) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:319:7: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        {
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:319:7: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:319:8: ( tikzcoordinate_core3 )=> tikzcoordinate_core3
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_ext1494);
            	        		tikzcoordinate_core3133 = tikzcoordinate_core3();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( (state.backtracking==0) ) stream_tikzcoordinate_core3.Add(tikzcoordinate_core3133.Tree);

            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:320:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        {
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:320:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:320:12: ( tikzcoordinate_core2 )=> tikzcoordinate_core2
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_ext1513);
            	        		tikzcoordinate_core2134 = tikzcoordinate_core2();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( (state.backtracking==0) ) stream_tikzcoordinate_core2.Add(tikzcoordinate_core2134.Tree);

            	        	}


            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:321:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        {
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:321:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:321:12: ( tikzcoordinate_core1 )=> tikzcoordinate_core1
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_ext1533);
            	        		tikzcoordinate_core1135 = tikzcoordinate_core1();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( (state.backtracking==0) ) stream_tikzcoordinate_core1.Add(tikzcoordinate_core1135.Tree);

            	        	}


            	        }
            	        break;

            	}

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:322:6: ( tikzpath_element )*
            	do 
            	{
            	    int alt37 = 2;
            	    int LA37_0 = input.LA(1);

            	    if ( (LA37_0 == ID || LA37_0 == 39 || LA37_0 == 45 || LA37_0 == 47 || (LA37_0 >= 64 && LA37_0 <= 65) || (LA37_0 >= 67 && LA37_0 <= 69) || (LA37_0 >= 71 && LA37_0 <= 76)) )
            	    {
            	        alt37 = 1;
            	    }


            	    switch (alt37) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:322:6: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikzcoordinate_ext1544);
            			    	tikzpath_element136 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element136.Tree);

            			    }
            			    break;

            			default:
            			    goto loop37;
            	    }
            	} while (true);

            	loop37:
            		;	// Stops C# compiler whining that label 'loop37' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikzcoordinate_ext1547);
            	semicolon_end137 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_semicolon_end.Add(semicolon_end137.Tree);


            	// AST REWRITE
            	// elements:          tikzcoordinate_core2, tikzpath_element, tikzcoordinate_core1, coordinate_start, tikzcoordinate_core3, semicolon_end
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 323:6: -> ^( IM_PATH coordinate_start ( tikzcoordinate_core3 )? ( tikzcoordinate_core2 )? ( tikzcoordinate_core1 )? ( tikzpath_element )* semicolon_end )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:323:9: ^( IM_PATH coordinate_start ( tikzcoordinate_core3 )? ( tikzcoordinate_core2 )? ( tikzcoordinate_core1 )? ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_coordinate_start.NextTree());
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:324:6: ( tikzcoordinate_core3 )?
            	    if ( stream_tikzcoordinate_core3.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzcoordinate_core3.NextTree());

            	    }
            	    stream_tikzcoordinate_core3.Reset();
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:325:6: ( tikzcoordinate_core2 )?
            	    if ( stream_tikzcoordinate_core2.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzcoordinate_core2.NextTree());

            	    }
            	    stream_tikzcoordinate_core2.Reset();
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:326:6: ( tikzcoordinate_core1 )?
            	    if ( stream_tikzcoordinate_core1.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzcoordinate_core1.NextTree());

            	    }
            	    stream_tikzcoordinate_core1.Reset();
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:327:6: ( tikzpath_element )*
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
    // $ANTLR end "tikzcoordinate_ext"

    public class tikzcoordinate_int_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikzcoordinate_int"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:329:1: tikzcoordinate_int : 'coordinate' ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ;
    public simpletikzParser.tikzcoordinate_int_return tikzcoordinate_int() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_int_return retval = new simpletikzParser.tikzcoordinate_int_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal138 = null;
        simpletikzParser.tikzcoordinate_core3_return tikzcoordinate_core3139 = default(simpletikzParser.tikzcoordinate_core3_return);

        simpletikzParser.tikzcoordinate_core2_return tikzcoordinate_core2140 = default(simpletikzParser.tikzcoordinate_core2_return);

        simpletikzParser.tikzcoordinate_core1_return tikzcoordinate_core1141 = default(simpletikzParser.tikzcoordinate_core1_return);


        object string_literal138_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:330:2: ( 'coordinate' ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:330:4: 'coordinate' ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal138=(IToken)Match(input,64,FOLLOW_64_in_tikzcoordinate_int1607); if (state.failed) return retval;
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:330:18: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?
            	int alt38 = 4;
            	alt38 = dfa38.Predict(input);
            	switch (alt38) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:330:20: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        {
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:330:20: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:330:21: ( tikzcoordinate_core3 )=> tikzcoordinate_core3
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_int1618);
            	        		tikzcoordinate_core3139 = tikzcoordinate_core3();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_core3139.Tree);

            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:331:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        {
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:331:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:331:12: ( tikzcoordinate_core2 )=> tikzcoordinate_core2
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_int1637);
            	        		tikzcoordinate_core2140 = tikzcoordinate_core2();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_core2140.Tree);

            	        	}


            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:332:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        {
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:332:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:332:12: ( tikzcoordinate_core1 )=> tikzcoordinate_core1
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_int1657);
            	        		tikzcoordinate_core1141 = tikzcoordinate_core1();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_core1141.Tree);

            	        	}


            	        }
            	        break;

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
    // $ANTLR end "tikzcoordinate_int"

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:334:1: tikznode_int : 'node' tikznode_core ;
    public simpletikzParser.tikznode_int_return tikznode_int() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_int_return retval = new simpletikzParser.tikznode_int_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal142 = null;
        simpletikzParser.tikznode_core_return tikznode_core143 = default(simpletikzParser.tikznode_core_return);


        object string_literal142_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:335:2: ( 'node' tikznode_core )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:335:4: 'node' tikznode_core
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal142=(IToken)Match(input,65,FOLLOW_65_in_tikznode_int1673); if (state.failed) return retval;
            	PushFollow(FOLLOW_tikznode_core_in_tikznode_int1676);
            	tikznode_core143 = tikznode_core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_core143.Tree);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:337:1: tikznode_core : ( tikznode_decorator )* tikzstring -> ^( IM_NODE ( tikznode_decorator )* tikzstring ) ;
    public simpletikzParser.tikznode_core_return tikznode_core() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_core_return retval = new simpletikzParser.tikznode_core_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator144 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikzstring_return tikzstring145 = default(simpletikzParser.tikzstring_return);


        RewriteRuleSubtreeStream stream_tikzstring = new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:338:2: ( ( tikznode_decorator )* tikzstring -> ^( IM_NODE ( tikznode_decorator )* tikzstring ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:338:4: ( tikznode_decorator )* tikzstring
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:338:4: ( tikznode_decorator )*
            	do 
            	{
            	    int alt39 = 2;
            	    int LA39_0 = input.LA(1);

            	    if ( (LA39_0 == 45 || LA39_0 == 47 || LA39_0 == 66) )
            	    {
            	        alt39 = 1;
            	    }


            	    switch (alt39) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:338:4: tikznode_decorator
            			    {
            			    	PushFollow(FOLLOW_tikznode_decorator_in_tikznode_core1686);
            			    	tikznode_decorator144 = tikznode_decorator();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator144.Tree);

            			    }
            			    break;

            			default:
            			    goto loop39;
            	    }
            	} while (true);

            	loop39:
            		;	// Stops C# compiler whining that label 'loop39' has no statements

            	PushFollow(FOLLOW_tikzstring_in_tikznode_core1689);
            	tikzstring145 = tikzstring();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzstring.Add(tikzstring145.Tree);


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
            	// 338:36: -> ^( IM_NODE ( tikznode_decorator )* tikzstring )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:338:39: ^( IM_NODE ( tikznode_decorator )* tikzstring )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NODE, "IM_NODE"), root_1);

            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:338:49: ( tikznode_decorator )*
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

    public class tikzcoordinate_core3_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikzcoordinate_core3"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:341:1: tikzcoordinate_core3 : tikznode_decorator tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator ) ;
    public simpletikzParser.tikzcoordinate_core3_return tikzcoordinate_core3() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_core3_return retval = new simpletikzParser.tikzcoordinate_core3_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator146 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikznode_decorator_return tikznode_decorator147 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikznode_decorator_return tikznode_decorator148 = default(simpletikzParser.tikznode_decorator_return);


        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:342:2: ( tikznode_decorator tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:342:6: tikznode_decorator tikznode_decorator tikznode_decorator
            {
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core31714);
            	tikznode_decorator146 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator146.Tree);
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core31716);
            	tikznode_decorator147 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator147.Tree);
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core31718);
            	tikznode_decorator148 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator148.Tree);


            	// AST REWRITE
            	// elements:          tikznode_decorator, tikznode_decorator, tikznode_decorator
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 342:64: -> ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:342:67: ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NODE, "IM_NODE"), root_1);

            	    adaptor.AddChild(root_1, stream_tikznode_decorator.NextTree());
            	    adaptor.AddChild(root_1, stream_tikznode_decorator.NextTree());
            	    adaptor.AddChild(root_1, stream_tikznode_decorator.NextTree());

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
    // $ANTLR end "tikzcoordinate_core3"

    public class tikzcoordinate_core2_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikzcoordinate_core2"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:346:1: tikzcoordinate_core2 : tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator ) ;
    public simpletikzParser.tikzcoordinate_core2_return tikzcoordinate_core2() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_core2_return retval = new simpletikzParser.tikzcoordinate_core2_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator149 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikznode_decorator_return tikznode_decorator150 = default(simpletikzParser.tikznode_decorator_return);


        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:347:2: ( tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:348:4: tikznode_decorator tikznode_decorator
            {
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core21752);
            	tikznode_decorator149 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator149.Tree);
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core21754);
            	tikznode_decorator150 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator150.Tree);


            	// AST REWRITE
            	// elements:          tikznode_decorator, tikznode_decorator
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 348:47: -> ^( IM_NODE tikznode_decorator tikznode_decorator )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:348:50: ^( IM_NODE tikznode_decorator tikznode_decorator )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NODE, "IM_NODE"), root_1);

            	    adaptor.AddChild(root_1, stream_tikznode_decorator.NextTree());
            	    adaptor.AddChild(root_1, stream_tikznode_decorator.NextTree());

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
    // $ANTLR end "tikzcoordinate_core2"

    public class tikzcoordinate_core1_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikzcoordinate_core1"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:351:1: tikzcoordinate_core1 : tikznode_decorator -> ^( IM_NODE tikznode_decorator ) ;
    public simpletikzParser.tikzcoordinate_core1_return tikzcoordinate_core1() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_core1_return retval = new simpletikzParser.tikzcoordinate_core1_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator151 = default(simpletikzParser.tikznode_decorator_return);


        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:352:2: ( tikznode_decorator -> ^( IM_NODE tikznode_decorator ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:353:4: tikznode_decorator
            {
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core11787);
            	tikznode_decorator151 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator151.Tree);


            	// AST REWRITE
            	// elements:          tikznode_decorator
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 353:31: -> ^( IM_NODE tikznode_decorator )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:353:34: ^( IM_NODE tikznode_decorator )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NODE, "IM_NODE"), root_1);

            	    adaptor.AddChild(root_1, stream_tikznode_decorator.NextTree());

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
    // $ANTLR end "tikzcoordinate_core1"

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:360:1: tikznode_decorator : ( nodename | 'at' coord | tikz_options_dontcare );
    public simpletikzParser.tikznode_decorator_return tikznode_decorator() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_decorator_return retval = new simpletikzParser.tikznode_decorator_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal153 = null;
        simpletikzParser.nodename_return nodename152 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_return coord154 = default(simpletikzParser.coord_return);

        simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare155 = default(simpletikzParser.tikz_options_dontcare_return);


        object string_literal153_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:361:2: ( nodename | 'at' coord | tikz_options_dontcare )
            int alt40 = 3;
            switch ( input.LA(1) ) 
            {
            case 45:
            	{
                alt40 = 1;
                }
                break;
            case 66:
            	{
                alt40 = 2;
                }
                break;
            case 47:
            	{
                alt40 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d40s0 =
            	        new NoViableAltException("", 40, 0, input);

            	    throw nvae_d40s0;
            }

            switch (alt40) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:361:6: nodename
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_nodename_in_tikznode_decorator1824);
                    	nodename152 = nodename();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, nodename152.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:362:5: 'at' coord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal153=(IToken)Match(input,66,FOLLOW_66_in_tikznode_decorator1831); if (state.failed) return retval;
                    	PushFollow(FOLLOW_coord_in_tikznode_decorator1834);
                    	coord154 = coord();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, coord154.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:363:5: tikz_options_dontcare
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_options_dontcare_in_tikznode_decorator1840);
                    	tikz_options_dontcare155 = tikz_options_dontcare();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_options_dontcare155.Tree);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:365:1: tikz_options_dontcare : '[' ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* ']' -> ^( IM_OPTIONS ) ;
    public simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_options_dontcare_return retval = new simpletikzParser.tikz_options_dontcare_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal156 = null;
        IToken char_literal160 = null;
        simpletikzParser.no_rlbracket_return no_rlbracket157 = default(simpletikzParser.no_rlbracket_return);

        simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare158 = default(simpletikzParser.tikz_options_dontcare_return);

        simpletikzParser.no_rlbracket_return no_rlbracket159 = default(simpletikzParser.no_rlbracket_return);


        object char_literal156_tree=null;
        object char_literal160_tree=null;
        RewriteRuleTokenStream stream_48 = new RewriteRuleTokenStream(adaptor,"token 48");
        RewriteRuleTokenStream stream_47 = new RewriteRuleTokenStream(adaptor,"token 47");
        RewriteRuleSubtreeStream stream_tikz_options_dontcare = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options_dontcare");
        RewriteRuleSubtreeStream stream_no_rlbracket = new RewriteRuleSubtreeStream(adaptor,"rule no_rlbracket");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:366:2: ( '[' ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* ']' -> ^( IM_OPTIONS ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:366:4: '[' ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* ']'
            {
            	char_literal156=(IToken)Match(input,47,FOLLOW_47_in_tikz_options_dontcare1850); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_47.Add(char_literal156);

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:366:8: ( no_rlbracket )*
            	do 
            	{
            	    int alt41 = 2;
            	    int LA41_0 = input.LA(1);

            	    if ( ((LA41_0 >= IM_PATH && LA41_0 <= 46) || (LA41_0 >= 49 && LA41_0 <= 78)) )
            	    {
            	        alt41 = 1;
            	    }


            	    switch (alt41) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:366:8: no_rlbracket
            			    {
            			    	PushFollow(FOLLOW_no_rlbracket_in_tikz_options_dontcare1852);
            			    	no_rlbracket157 = no_rlbracket();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_no_rlbracket.Add(no_rlbracket157.Tree);

            			    }
            			    break;

            			default:
            			    goto loop41;
            	    }
            	} while (true);

            	loop41:
            		;	// Stops C# compiler whining that label 'loop41' has no statements

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:366:22: ( tikz_options_dontcare ( no_rlbracket )* )*
            	do 
            	{
            	    int alt43 = 2;
            	    int LA43_0 = input.LA(1);

            	    if ( (LA43_0 == 47) )
            	    {
            	        alt43 = 1;
            	    }


            	    switch (alt43) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:366:23: tikz_options_dontcare ( no_rlbracket )*
            			    {
            			    	PushFollow(FOLLOW_tikz_options_dontcare_in_tikz_options_dontcare1856);
            			    	tikz_options_dontcare158 = tikz_options_dontcare();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikz_options_dontcare.Add(tikz_options_dontcare158.Tree);
            			    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:366:45: ( no_rlbracket )*
            			    	do 
            			    	{
            			    	    int alt42 = 2;
            			    	    int LA42_0 = input.LA(1);

            			    	    if ( ((LA42_0 >= IM_PATH && LA42_0 <= 46) || (LA42_0 >= 49 && LA42_0 <= 78)) )
            			    	    {
            			    	        alt42 = 1;
            			    	    }


            			    	    switch (alt42) 
            			    		{
            			    			case 1 :
            			    			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:366:45: no_rlbracket
            			    			    {
            			    			    	PushFollow(FOLLOW_no_rlbracket_in_tikz_options_dontcare1858);
            			    			    	no_rlbracket159 = no_rlbracket();
            			    			    	state.followingStackPointer--;
            			    			    	if (state.failed) return retval;
            			    			    	if ( (state.backtracking==0) ) stream_no_rlbracket.Add(no_rlbracket159.Tree);

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop42;
            			    	    }
            			    	} while (true);

            			    	loop42:
            			    		;	// Stops C# compiler whining that label 'loop42' has no statements


            			    }
            			    break;

            			default:
            			    goto loop43;
            	    }
            	} while (true);

            	loop43:
            		;	// Stops C# compiler whining that label 'loop43' has no statements

            	char_literal160=(IToken)Match(input,48,FOLLOW_48_in_tikz_options_dontcare1863); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_48.Add(char_literal160);



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
            	// 366:65: -> ^( IM_OPTIONS )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:366:68: ^( IM_OPTIONS )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:368:1: no_rlbracket : ~ ( '[' | ']' ) ;
    public simpletikzParser.no_rlbracket_return no_rlbracket() // throws RecognitionException [1]
    {   
        simpletikzParser.no_rlbracket_return retval = new simpletikzParser.no_rlbracket_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set161 = null;

        object set161_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:369:2: (~ ( '[' | ']' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:369:4: ~ ( '[' | ']' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set161 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= 46) || (input.LA(1) >= 49 && input.LA(1) <= 78) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set161));
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:371:1: nodename : '(' idd ')' -> ^( IM_NODENAME idd ) ;
    public simpletikzParser.nodename_return nodename() // throws RecognitionException [1]
    {   
        simpletikzParser.nodename_return retval = new simpletikzParser.nodename_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal162 = null;
        IToken char_literal164 = null;
        simpletikzParser.idd_return idd163 = default(simpletikzParser.idd_return);


        object char_literal162_tree=null;
        object char_literal164_tree=null;
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_46 = new RewriteRuleTokenStream(adaptor,"token 46");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:372:2: ( '(' idd ')' -> ^( IM_NODENAME idd ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:372:4: '(' idd ')'
            {
            	char_literal162=(IToken)Match(input,45,FOLLOW_45_in_nodename1898); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_45.Add(char_literal162);

            	PushFollow(FOLLOW_idd_in_nodename1900);
            	idd163 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idd.Add(idd163.Tree);
            	char_literal164=(IToken)Match(input,46,FOLLOW_46_in_nodename1902); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_46.Add(char_literal164);



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
            	// 372:17: -> ^( IM_NODENAME idd )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:372:20: ^( IM_NODENAME idd )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:378:1: circle : ( 'circle' | 'ellipse' ) ( ( size )=> size )? ->;
    public simpletikzParser.circle_return circle() // throws RecognitionException [1]
    {   
        simpletikzParser.circle_return retval = new simpletikzParser.circle_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal165 = null;
        IToken string_literal166 = null;
        simpletikzParser.size_return size167 = default(simpletikzParser.size_return);


        object string_literal165_tree=null;
        object string_literal166_tree=null;
        RewriteRuleTokenStream stream_67 = new RewriteRuleTokenStream(adaptor,"token 67");
        RewriteRuleTokenStream stream_68 = new RewriteRuleTokenStream(adaptor,"token 68");
        RewriteRuleSubtreeStream stream_size = new RewriteRuleSubtreeStream(adaptor,"rule size");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:379:2: ( ( 'circle' | 'ellipse' ) ( ( size )=> size )? ->)
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:379:4: ( 'circle' | 'ellipse' ) ( ( size )=> size )?
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:379:4: ( 'circle' | 'ellipse' )
            	int alt44 = 2;
            	int LA44_0 = input.LA(1);

            	if ( (LA44_0 == 67) )
            	{
            	    alt44 = 1;
            	}
            	else if ( (LA44_0 == 68) )
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
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:379:5: 'circle'
            	        {
            	        	string_literal165=(IToken)Match(input,67,FOLLOW_67_in_circle1926); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_67.Add(string_literal165);


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:379:16: 'ellipse'
            	        {
            	        	string_literal166=(IToken)Match(input,68,FOLLOW_68_in_circle1930); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_68.Add(string_literal166);


            	        }
            	        break;

            	}

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:379:27: ( ( size )=> size )?
            	int alt45 = 2;
            	alt45 = dfa45.Predict(input);
            	switch (alt45) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:379:28: ( size )=> size
            	        {
            	        	PushFollow(FOLLOW_size_in_circle1939);
            	        	size167 = size();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_size.Add(size167.Tree);

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
            	// 379:44: ->
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:381:1: arc : 'arc' ( '(' numberunit ':' numberunit ':' numberunit ')' )? ->;
    public simpletikzParser.arc_return arc() // throws RecognitionException [1]
    {   
        simpletikzParser.arc_return retval = new simpletikzParser.arc_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal168 = null;
        IToken char_literal169 = null;
        IToken char_literal171 = null;
        IToken char_literal173 = null;
        IToken char_literal175 = null;
        simpletikzParser.numberunit_return numberunit170 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit172 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit174 = default(simpletikzParser.numberunit_return);


        object string_literal168_tree=null;
        object char_literal169_tree=null;
        object char_literal171_tree=null;
        object char_literal173_tree=null;
        object char_literal175_tree=null;
        RewriteRuleTokenStream stream_69 = new RewriteRuleTokenStream(adaptor,"token 69");
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_46 = new RewriteRuleTokenStream(adaptor,"token 46");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:382:2: ( 'arc' ( '(' numberunit ':' numberunit ':' numberunit ')' )? ->)
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:382:4: 'arc' ( '(' numberunit ':' numberunit ':' numberunit ')' )?
            {
            	string_literal168=(IToken)Match(input,69,FOLLOW_69_in_arc1954); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_69.Add(string_literal168);

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:382:10: ( '(' numberunit ':' numberunit ':' numberunit ')' )?
            	int alt46 = 2;
            	int LA46_0 = input.LA(1);

            	if ( (LA46_0 == 45) )
            	{
            	    int LA46_1 = input.LA(2);

            	    if ( ((LA46_1 >= FLOAT_WO_EXP && LA46_1 <= INT)) )
            	    {
            	        int LA46_3 = input.LA(3);

            	        if ( (LA46_3 == 43) )
            	        {
            	            int LA46_4 = input.LA(4);

            	            if ( ((LA46_4 >= FLOAT_WO_EXP && LA46_4 <= INT)) )
            	            {
            	                int LA46_6 = input.LA(5);

            	                if ( ((LA46_6 >= 50 && LA46_6 <= 55)) )
            	                {
            	                    int LA46_7 = input.LA(6);

            	                    if ( (LA46_7 == 43) )
            	                    {
            	                        alt46 = 1;
            	                    }
            	                }
            	                else if ( (LA46_6 == 43) )
            	                {
            	                    alt46 = 1;
            	                }
            	            }
            	        }
            	        else if ( ((LA46_3 >= 50 && LA46_3 <= 55)) )
            	        {
            	            int LA46_5 = input.LA(4);

            	            if ( (LA46_5 == 43) )
            	            {
            	                int LA46_4 = input.LA(5);

            	                if ( ((LA46_4 >= FLOAT_WO_EXP && LA46_4 <= INT)) )
            	                {
            	                    int LA46_6 = input.LA(6);

            	                    if ( ((LA46_6 >= 50 && LA46_6 <= 55)) )
            	                    {
            	                        int LA46_7 = input.LA(7);

            	                        if ( (LA46_7 == 43) )
            	                        {
            	                            alt46 = 1;
            	                        }
            	                    }
            	                    else if ( (LA46_6 == 43) )
            	                    {
            	                        alt46 = 1;
            	                    }
            	                }
            	            }
            	        }
            	    }
            	}
            	switch (alt46) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:382:11: '(' numberunit ':' numberunit ':' numberunit ')'
            	        {
            	        	char_literal169=(IToken)Match(input,45,FOLLOW_45_in_arc1957); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_45.Add(char_literal169);

            	        	PushFollow(FOLLOW_numberunit_in_arc1959);
            	        	numberunit170 = numberunit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit170.Tree);
            	        	char_literal171=(IToken)Match(input,43,FOLLOW_43_in_arc1961); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_43.Add(char_literal171);

            	        	PushFollow(FOLLOW_numberunit_in_arc1963);
            	        	numberunit172 = numberunit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit172.Tree);
            	        	char_literal173=(IToken)Match(input,43,FOLLOW_43_in_arc1965); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_43.Add(char_literal173);

            	        	PushFollow(FOLLOW_numberunit_in_arc1967);
            	        	numberunit174 = numberunit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit174.Tree);
            	        	char_literal175=(IToken)Match(input,46,FOLLOW_46_in_arc1969); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_46.Add(char_literal175);


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
            	// 382:62: ->
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:385:1: size : '(' numberunit ( 'and' numberunit )? ')' -> ^( IM_SIZE ( numberunit )* ) ;
    public simpletikzParser.size_return size() // throws RecognitionException [1]
    {   
        simpletikzParser.size_return retval = new simpletikzParser.size_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal176 = null;
        IToken string_literal178 = null;
        IToken char_literal180 = null;
        simpletikzParser.numberunit_return numberunit177 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit179 = default(simpletikzParser.numberunit_return);


        object char_literal176_tree=null;
        object string_literal178_tree=null;
        object char_literal180_tree=null;
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_46 = new RewriteRuleTokenStream(adaptor,"token 46");
        RewriteRuleTokenStream stream_70 = new RewriteRuleTokenStream(adaptor,"token 70");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:386:2: ( '(' numberunit ( 'and' numberunit )? ')' -> ^( IM_SIZE ( numberunit )* ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:386:6: '(' numberunit ( 'and' numberunit )? ')'
            {
            	char_literal176=(IToken)Match(input,45,FOLLOW_45_in_size1987); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_45.Add(char_literal176);

            	PushFollow(FOLLOW_numberunit_in_size1989);
            	numberunit177 = numberunit();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit177.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:386:21: ( 'and' numberunit )?
            	int alt47 = 2;
            	int LA47_0 = input.LA(1);

            	if ( (LA47_0 == 70) )
            	{
            	    alt47 = 1;
            	}
            	switch (alt47) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:386:22: 'and' numberunit
            	        {
            	        	string_literal178=(IToken)Match(input,70,FOLLOW_70_in_size1992); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_70.Add(string_literal178);

            	        	PushFollow(FOLLOW_numberunit_in_size1994);
            	        	numberunit179 = numberunit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit179.Tree);

            	        }
            	        break;

            	}

            	char_literal180=(IToken)Match(input,46,FOLLOW_46_in_size1998); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_46.Add(char_literal180);



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
            	// 386:46: -> ^( IM_SIZE ( numberunit )* )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:386:49: ^( IM_SIZE ( numberunit )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_SIZE, "IM_SIZE"), root_1);

            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:386:59: ( numberunit )*
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:393:1: coord : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) );
    public simpletikzParser.coord_return coord() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_return retval = new simpletikzParser.coord_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal183 = null;
        IToken char_literal187 = null;
        IToken char_literal189 = null;
        IToken char_literal193 = null;
        simpletikzParser.nodename_return nodename181 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_modifier_return coord_modifier182 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.numberunit_return numberunit184 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_sep_return coord_sep185 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.numberunit_return numberunit186 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_modifier_return coord_modifier188 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.coord_part_return coord_part190 = default(simpletikzParser.coord_part_return);

        simpletikzParser.coord_sep_return coord_sep191 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.coord_part_return coord_part192 = default(simpletikzParser.coord_part_return);


        object char_literal183_tree=null;
        object char_literal187_tree=null;
        object char_literal189_tree=null;
        object char_literal193_tree=null;
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_46 = new RewriteRuleTokenStream(adaptor,"token 46");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_coord_part = new RewriteRuleSubtreeStream(adaptor,"rule coord_part");
        RewriteRuleSubtreeStream stream_coord_sep = new RewriteRuleSubtreeStream(adaptor,"rule coord_sep");
        RewriteRuleSubtreeStream stream_nodename = new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        RewriteRuleSubtreeStream stream_coord_modifier = new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:394:2: ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) )
            int alt50 = 3;
            alt50 = dfa50.Predict(input);
            switch (alt50) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:394:6: nodename
                    {
                    	PushFollow(FOLLOW_nodename_in_coord2028);
                    	nodename181 = nodename();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_nodename.Add(nodename181.Tree);


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
                    	// 394:23: -> ^( IM_COORD nodename )
                    	{
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:394:26: ^( IM_COORD nodename )
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
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:395:5: ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' )
                    {
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:395:5: ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' )
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:395:7: ( coord_modifier )? '(' numberunit coord_sep numberunit ')'
                    	{
                    		// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:395:7: ( coord_modifier )?
                    		int alt48 = 2;
                    		int LA48_0 = input.LA(1);

                    		if ( ((LA48_0 >= 75 && LA48_0 <= 76)) )
                    		{
                    		    alt48 = 1;
                    		}
                    		switch (alt48) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:395:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord2052);
                    		        	coord_modifier182 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_coord_modifier.Add(coord_modifier182.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal183=(IToken)Match(input,45,FOLLOW_45_in_coord2055); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_45.Add(char_literal183);

                    		PushFollow(FOLLOW_numberunit_in_coord2057);
                    		numberunit184 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit184.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord2059);
                    		coord_sep185 = coord_sep();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_sep.Add(coord_sep185.Tree);
                    		PushFollow(FOLLOW_numberunit_in_coord2061);
                    		numberunit186 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit186.Tree);
                    		char_literal187=(IToken)Match(input,46,FOLLOW_46_in_coord2063); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_46.Add(char_literal187);


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
                    	// 395:65: -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep )
                    	{
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:395:68: ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:395:79: ( coord_modifier )?
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
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:396:5: ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' )
                    {
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:396:5: ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' )
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:396:7: ( coord_modifier )? '(' coord_part coord_sep coord_part ')'
                    	{
                    		// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:396:7: ( coord_modifier )?
                    		int alt49 = 2;
                    		int LA49_0 = input.LA(1);

                    		if ( ((LA49_0 >= 75 && LA49_0 <= 76)) )
                    		{
                    		    alt49 = 1;
                    		}
                    		switch (alt49) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:396:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord2087);
                    		        	coord_modifier188 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_coord_modifier.Add(coord_modifier188.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal189=(IToken)Match(input,45,FOLLOW_45_in_coord2090); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_45.Add(char_literal189);

                    		PushFollow(FOLLOW_coord_part_in_coord2092);
                    		coord_part190 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_part.Add(coord_part190.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord2094);
                    		coord_sep191 = coord_sep();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_sep.Add(coord_sep191.Tree);
                    		PushFollow(FOLLOW_coord_part_in_coord2096);
                    		coord_part192 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_part.Add(coord_part192.Tree);
                    		char_literal193=(IToken)Match(input,46,FOLLOW_46_in_coord2098); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_46.Add(char_literal193);


                    	}



                    	// AST REWRITE
                    	// elements:          coord_part, coord_sep, coord_modifier
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 396:65: -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep )
                    	{
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:396:68: ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:396:79: ( coord_modifier )?
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:400:1: coord_part : ( idd -> ^( IM_DONTCARE idd ) | '{' idd '}' -> ^( IM_DONTCARE '{' idd '}' ) );
    public simpletikzParser.coord_part_return coord_part() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_part_return retval = new simpletikzParser.coord_part_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal195 = null;
        IToken char_literal197 = null;
        simpletikzParser.idd_return idd194 = default(simpletikzParser.idd_return);

        simpletikzParser.idd_return idd196 = default(simpletikzParser.idd_return);


        object char_literal195_tree=null;
        object char_literal197_tree=null;
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:401:2: ( idd -> ^( IM_DONTCARE idd ) | '{' idd '}' -> ^( IM_DONTCARE '{' idd '}' ) )
            int alt51 = 2;
            int LA51_0 = input.LA(1);

            if ( ((LA51_0 >= IM_PATH && LA51_0 <= 38) || (LA51_0 >= 50 && LA51_0 <= 78)) )
            {
                alt51 = 1;
            }
            else if ( (LA51_0 == 39) )
            {
                alt51 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d51s0 =
                    new NoViableAltException("", 51, 0, input);

                throw nvae_d51s0;
            }
            switch (alt51) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:401:4: idd
                    {
                    	PushFollow(FOLLOW_idd_in_coord_part2126);
                    	idd194 = idd();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_idd.Add(idd194.Tree);


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
                    	// 401:9: -> ^( IM_DONTCARE idd )
                    	{
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:401:12: ^( IM_DONTCARE idd )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DONTCARE, "IM_DONTCARE"), root_1);

                    	    adaptor.AddChild(root_1, stream_idd.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:402:4: '{' idd '}'
                    {
                    	char_literal195=(IToken)Match(input,39,FOLLOW_39_in_coord_part2141); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_39.Add(char_literal195);

                    	PushFollow(FOLLOW_idd_in_coord_part2143);
                    	idd196 = idd();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_idd.Add(idd196.Tree);
                    	char_literal197=(IToken)Match(input,40,FOLLOW_40_in_coord_part2145); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_40.Add(char_literal197);



                    	// AST REWRITE
                    	// elements:          39, idd, 40
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 402:16: -> ^( IM_DONTCARE '{' idd '}' )
                    	{
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:402:19: ^( IM_DONTCARE '{' idd '}' )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DONTCARE, "IM_DONTCARE"), root_1);

                    	    adaptor.AddChild(root_1, stream_39.NextNode());
                    	    adaptor.AddChild(root_1, stream_idd.NextTree());
                    	    adaptor.AddChild(root_1, stream_40.NextNode());

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:404:1: coord_sep : ( ',' | ':' ) ;
    public simpletikzParser.coord_sep_return coord_sep() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_sep_return retval = new simpletikzParser.coord_sep_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set198 = null;

        object set198_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:405:2: ( ( ',' | ':' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:405:4: ( ',' | ':' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set198 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 42 && input.LA(1) <= 43) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set198));
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:409:1: edgeop : ( '--' | '->' | '|-' | '-|' | ID );
    public simpletikzParser.edgeop_return edgeop() // throws RecognitionException [1]
    {   
        simpletikzParser.edgeop_return retval = new simpletikzParser.edgeop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set199 = null;

        object set199_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:410:2: ( '--' | '->' | '|-' | '-|' | ID )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set199 = (IToken)input.LT(1);
            	if ( input.LA(1) == ID || (input.LA(1) >= 71 && input.LA(1) <= 74) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set199));
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:414:1: coord_modifier : ( '+' | '++' );
    public simpletikzParser.coord_modifier_return coord_modifier() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_modifier_return retval = new simpletikzParser.coord_modifier_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set200 = null;

        object set200_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:415:2: ( '+' | '++' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set200 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 75 && input.LA(1) <= 76) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set200));
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:457:1: squarebr_start : '[' -> ^( IM_STARTTAG '[' ) ;
    public simpletikzParser.squarebr_start_return squarebr_start() // throws RecognitionException [1]
    {   
        simpletikzParser.squarebr_start_return retval = new simpletikzParser.squarebr_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal201 = null;

        object char_literal201_tree=null;
        RewriteRuleTokenStream stream_47 = new RewriteRuleTokenStream(adaptor,"token 47");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:458:2: ( '[' -> ^( IM_STARTTAG '[' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:458:4: '['
            {
            	char_literal201=(IToken)Match(input,47,FOLLOW_47_in_squarebr_start2241); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_47.Add(char_literal201);



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
            	// 458:8: -> ^( IM_STARTTAG '[' )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:458:11: ^( IM_STARTTAG '[' )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:460:1: squarebr_end : ']' -> ^( IM_ENDTAG ']' ) ;
    public simpletikzParser.squarebr_end_return squarebr_end() // throws RecognitionException [1]
    {   
        simpletikzParser.squarebr_end_return retval = new simpletikzParser.squarebr_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal202 = null;

        object char_literal202_tree=null;
        RewriteRuleTokenStream stream_48 = new RewriteRuleTokenStream(adaptor,"token 48");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:461:2: ( ']' -> ^( IM_ENDTAG ']' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:461:4: ']'
            {
            	char_literal202=(IToken)Match(input,48,FOLLOW_48_in_squarebr_end2259); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_48.Add(char_literal202);



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
            	// 461:8: -> ^( IM_ENDTAG ']' )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:461:11: ^( IM_ENDTAG ']' )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:463:1: semicolon_end : ';' -> ^( IM_ENDTAG ';' ) ;
    public simpletikzParser.semicolon_end_return semicolon_end() // throws RecognitionException [1]
    {   
        simpletikzParser.semicolon_end_return retval = new simpletikzParser.semicolon_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal203 = null;

        object char_literal203_tree=null;
        RewriteRuleTokenStream stream_49 = new RewriteRuleTokenStream(adaptor,"token 49");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:464:2: ( ';' -> ^( IM_ENDTAG ';' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:464:4: ';'
            {
            	char_literal203=(IToken)Match(input,49,FOLLOW_49_in_semicolon_end2278); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_49.Add(char_literal203);



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
            	// 464:8: -> ^( IM_ENDTAG ';' )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:464:11: ^( IM_ENDTAG ';' )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:466:1: roundbr_start : '{' -> ^( IM_STARTTAG '{' ) ;
    public simpletikzParser.roundbr_start_return roundbr_start() // throws RecognitionException [1]
    {   
        simpletikzParser.roundbr_start_return retval = new simpletikzParser.roundbr_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal204 = null;

        object char_literal204_tree=null;
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:467:2: ( '{' -> ^( IM_STARTTAG '{' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:467:4: '{'
            {
            	char_literal204=(IToken)Match(input,39,FOLLOW_39_in_roundbr_start2296); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_39.Add(char_literal204);



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
            	// 467:8: -> ^( IM_STARTTAG '{' )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:467:11: ^( IM_STARTTAG '{' )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:469:1: roundbr_end : '}' -> ^( IM_ENDTAG '}' ) ;
    public simpletikzParser.roundbr_end_return roundbr_end() // throws RecognitionException [1]
    {   
        simpletikzParser.roundbr_end_return retval = new simpletikzParser.roundbr_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal205 = null;

        object char_literal205_tree=null;
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:470:2: ( '}' -> ^( IM_ENDTAG '}' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:470:4: '}'
            {
            	char_literal205=(IToken)Match(input,40,FOLLOW_40_in_roundbr_end2314); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_40.Add(char_literal205);



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
            	// 470:8: -> ^( IM_ENDTAG '}' )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:470:11: ^( IM_ENDTAG '}' )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:472:1: tikz_set_start : '\\\\tikzset' '{' -> ^( IM_STARTTAG ) ;
    public simpletikzParser.tikz_set_start_return tikz_set_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_set_start_return retval = new simpletikzParser.tikz_set_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal206 = null;
        IToken char_literal207 = null;

        object string_literal206_tree=null;
        object char_literal207_tree=null;
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");
        RewriteRuleTokenStream stream_38 = new RewriteRuleTokenStream(adaptor,"token 38");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:473:2: ( '\\\\tikzset' '{' -> ^( IM_STARTTAG ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:473:4: '\\\\tikzset' '{'
            {
            	string_literal206=(IToken)Match(input,38,FOLLOW_38_in_tikz_set_start2332); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_38.Add(string_literal206);

            	char_literal207=(IToken)Match(input,39,FOLLOW_39_in_tikz_set_start2334); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_39.Add(char_literal207);



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
            	// 473:21: -> ^( IM_STARTTAG )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:473:24: ^( IM_STARTTAG )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:475:1: tikzpicture_start : '\\\\begin' '{' 'tikzpicture' '}' -> ^( IM_STARTTAG '\\\\begin' ) ;
    public simpletikzParser.tikzpicture_start_return tikzpicture_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_start_return retval = new simpletikzParser.tikzpicture_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal208 = null;
        IToken char_literal209 = null;
        IToken string_literal210 = null;
        IToken char_literal211 = null;

        object string_literal208_tree=null;
        object char_literal209_tree=null;
        object string_literal210_tree=null;
        object char_literal211_tree=null;
        RewriteRuleTokenStream stream_77 = new RewriteRuleTokenStream(adaptor,"token 77");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleTokenStream stream_36 = new RewriteRuleTokenStream(adaptor,"token 36");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:476:2: ( '\\\\begin' '{' 'tikzpicture' '}' -> ^( IM_STARTTAG '\\\\begin' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:476:4: '\\\\begin' '{' 'tikzpicture' '}'
            {
            	string_literal208=(IToken)Match(input,36,FOLLOW_36_in_tikzpicture_start2353); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_36.Add(string_literal208);

            	char_literal209=(IToken)Match(input,39,FOLLOW_39_in_tikzpicture_start2355); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_39.Add(char_literal209);

            	string_literal210=(IToken)Match(input,77,FOLLOW_77_in_tikzpicture_start2357); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_77.Add(string_literal210);

            	char_literal211=(IToken)Match(input,40,FOLLOW_40_in_tikzpicture_start2359); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_40.Add(char_literal211);



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
            	// 476:36: -> ^( IM_STARTTAG '\\\\begin' )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:476:39: ^( IM_STARTTAG '\\\\begin' )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:478:1: tikzpicture_end : '\\\\end' '{' 'tikzpicture' '}' -> ^( IM_ENDTAG '\\\\end' ) ;
    public simpletikzParser.tikzpicture_end_return tikzpicture_end() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_end_return retval = new simpletikzParser.tikzpicture_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal212 = null;
        IToken char_literal213 = null;
        IToken string_literal214 = null;
        IToken char_literal215 = null;

        object string_literal212_tree=null;
        object char_literal213_tree=null;
        object string_literal214_tree=null;
        object char_literal215_tree=null;
        RewriteRuleTokenStream stream_77 = new RewriteRuleTokenStream(adaptor,"token 77");
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:479:2: ( '\\\\end' '{' 'tikzpicture' '}' -> ^( IM_ENDTAG '\\\\end' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:479:4: '\\\\end' '{' 'tikzpicture' '}'
            {
            	string_literal212=(IToken)Match(input,56,FOLLOW_56_in_tikzpicture_end2377); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_56.Add(string_literal212);

            	char_literal213=(IToken)Match(input,39,FOLLOW_39_in_tikzpicture_end2379); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_39.Add(char_literal213);

            	string_literal214=(IToken)Match(input,77,FOLLOW_77_in_tikzpicture_end2381); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_77.Add(string_literal214);

            	char_literal215=(IToken)Match(input,40,FOLLOW_40_in_tikzpicture_end2383); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_40.Add(char_literal215);



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
            	// 479:34: -> ^( IM_ENDTAG '\\\\end' )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:479:37: ^( IM_ENDTAG '\\\\end' )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:481:1: tikzscope_start : '\\\\begin' '{' 'scope' '}' -> ^( IM_STARTTAG '\\\\begin' ) ;
    public simpletikzParser.tikzscope_start_return tikzscope_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_start_return retval = new simpletikzParser.tikzscope_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal216 = null;
        IToken char_literal217 = null;
        IToken string_literal218 = null;
        IToken char_literal219 = null;

        object string_literal216_tree=null;
        object char_literal217_tree=null;
        object string_literal218_tree=null;
        object char_literal219_tree=null;
        RewriteRuleTokenStream stream_78 = new RewriteRuleTokenStream(adaptor,"token 78");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleTokenStream stream_36 = new RewriteRuleTokenStream(adaptor,"token 36");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:482:2: ( '\\\\begin' '{' 'scope' '}' -> ^( IM_STARTTAG '\\\\begin' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:482:4: '\\\\begin' '{' 'scope' '}'
            {
            	string_literal216=(IToken)Match(input,36,FOLLOW_36_in_tikzscope_start2401); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_36.Add(string_literal216);

            	char_literal217=(IToken)Match(input,39,FOLLOW_39_in_tikzscope_start2403); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_39.Add(char_literal217);

            	string_literal218=(IToken)Match(input,78,FOLLOW_78_in_tikzscope_start2405); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_78.Add(string_literal218);

            	char_literal219=(IToken)Match(input,40,FOLLOW_40_in_tikzscope_start2407); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_40.Add(char_literal219);



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
            	// 482:30: -> ^( IM_STARTTAG '\\\\begin' )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:482:33: ^( IM_STARTTAG '\\\\begin' )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:484:1: tikzscope_end : '\\\\end' '{' 'scope' '}' -> ^( IM_ENDTAG '\\\\end' ) ;
    public simpletikzParser.tikzscope_end_return tikzscope_end() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_end_return retval = new simpletikzParser.tikzscope_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal220 = null;
        IToken char_literal221 = null;
        IToken string_literal222 = null;
        IToken char_literal223 = null;

        object string_literal220_tree=null;
        object char_literal221_tree=null;
        object string_literal222_tree=null;
        object char_literal223_tree=null;
        RewriteRuleTokenStream stream_78 = new RewriteRuleTokenStream(adaptor,"token 78");
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:485:2: ( '\\\\end' '{' 'scope' '}' -> ^( IM_ENDTAG '\\\\end' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:485:4: '\\\\end' '{' 'scope' '}'
            {
            	string_literal220=(IToken)Match(input,56,FOLLOW_56_in_tikzscope_end2425); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_56.Add(string_literal220);

            	char_literal221=(IToken)Match(input,39,FOLLOW_39_in_tikzscope_end2427); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_39.Add(char_literal221);

            	string_literal222=(IToken)Match(input,78,FOLLOW_78_in_tikzscope_end2429); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_78.Add(string_literal222);

            	char_literal223=(IToken)Match(input,40,FOLLOW_40_in_tikzscope_end2431); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_40.Add(char_literal223);



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
            	// 485:28: -> ^( IM_ENDTAG '\\\\end' )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:485:31: ^( IM_ENDTAG '\\\\end' )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:487:1: path_start : path_start_tag -> ^( IM_STARTTAG path_start_tag ) ;
    public simpletikzParser.path_start_return path_start() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_return retval = new simpletikzParser.path_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.path_start_tag_return path_start_tag224 = default(simpletikzParser.path_start_tag_return);


        RewriteRuleSubtreeStream stream_path_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule path_start_tag");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:488:2: ( path_start_tag -> ^( IM_STARTTAG path_start_tag ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:488:4: path_start_tag
            {
            	PushFollow(FOLLOW_path_start_tag_in_path_start2450);
            	path_start_tag224 = path_start_tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_path_start_tag.Add(path_start_tag224.Tree);


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
            	// 488:19: -> ^( IM_STARTTAG path_start_tag )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:488:22: ^( IM_STARTTAG path_start_tag )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:490:1: node_start : node_start_tag -> ^( IM_STARTTAG node_start_tag ) ;
    public simpletikzParser.node_start_return node_start() // throws RecognitionException [1]
    {   
        simpletikzParser.node_start_return retval = new simpletikzParser.node_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.node_start_tag_return node_start_tag225 = default(simpletikzParser.node_start_tag_return);


        RewriteRuleSubtreeStream stream_node_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule node_start_tag");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:491:2: ( node_start_tag -> ^( IM_STARTTAG node_start_tag ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:491:4: node_start_tag
            {
            	PushFollow(FOLLOW_node_start_tag_in_node_start2468);
            	node_start_tag225 = node_start_tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_node_start_tag.Add(node_start_tag225.Tree);


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
            	// 491:19: -> ^( IM_STARTTAG node_start_tag )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:491:22: ^( IM_STARTTAG node_start_tag )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:493:1: node_start_tag : '\\\\node' ;
    public simpletikzParser.node_start_tag_return node_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.node_start_tag_return retval = new simpletikzParser.node_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal226 = null;

        object string_literal226_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:494:2: ( '\\\\node' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:494:4: '\\\\node'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal226=(IToken)Match(input,57,FOLLOW_57_in_node_start_tag2486); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal226_tree = (object)adaptor.Create(string_literal226);
            		adaptor.AddChild(root_0, string_literal226_tree);
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

    public class coordinate_start_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "coordinate_start"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:496:1: coordinate_start : '\\\\coordinate' -> ^( IM_STARTTAG '\\\\coordinate' ) ;
    public simpletikzParser.coordinate_start_return coordinate_start() // throws RecognitionException [1]
    {   
        simpletikzParser.coordinate_start_return retval = new simpletikzParser.coordinate_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal227 = null;

        object string_literal227_tree=null;
        RewriteRuleTokenStream stream_58 = new RewriteRuleTokenStream(adaptor,"token 58");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:497:2: ( '\\\\coordinate' -> ^( IM_STARTTAG '\\\\coordinate' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:497:4: '\\\\coordinate'
            {
            	string_literal227=(IToken)Match(input,58,FOLLOW_58_in_coordinate_start2496); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_58.Add(string_literal227);



            	// AST REWRITE
            	// elements:          58
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 497:19: -> ^( IM_STARTTAG '\\\\coordinate' )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:497:22: ^( IM_STARTTAG '\\\\coordinate' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_58.NextNode());

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
    // $ANTLR end "coordinate_start"

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:499:1: path_start_tag : ( '\\\\draw' | '\\\\fill' | '\\\\path' | '\\\\clip' );
    public simpletikzParser.path_start_tag_return path_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_tag_return retval = new simpletikzParser.path_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set228 = null;

        object set228_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:500:2: ( '\\\\draw' | '\\\\fill' | '\\\\path' | '\\\\clip' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set228 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 59 && input.LA(1) <= 62) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set228));
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
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:319:8: ( tikzcoordinate_core3 )
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:319:9: tikzcoordinate_core3
        {
        	PushFollow(FOLLOW_tikzcoordinate_core3_in_synpred1_simpletikz1490);
        	tikzcoordinate_core3();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred1_simpletikz"

    // $ANTLR start "synpred2_simpletikz"
    public void synpred2_simpletikz_fragment() {
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:320:12: ( tikzcoordinate_core2 )
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:320:13: tikzcoordinate_core2
        {
        	PushFollow(FOLLOW_tikzcoordinate_core2_in_synpred2_simpletikz1509);
        	tikzcoordinate_core2();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred2_simpletikz"

    // $ANTLR start "synpred3_simpletikz"
    public void synpred3_simpletikz_fragment() {
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:321:12: ( tikzcoordinate_core1 )
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:321:13: tikzcoordinate_core1
        {
        	PushFollow(FOLLOW_tikzcoordinate_core1_in_synpred3_simpletikz1529);
        	tikzcoordinate_core1();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred3_simpletikz"

    // $ANTLR start "synpred4_simpletikz"
    public void synpred4_simpletikz_fragment() {
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:330:21: ( tikzcoordinate_core3 )
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:330:22: tikzcoordinate_core3
        {
        	PushFollow(FOLLOW_tikzcoordinate_core3_in_synpred4_simpletikz1614);
        	tikzcoordinate_core3();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred4_simpletikz"

    // $ANTLR start "synpred5_simpletikz"
    public void synpred5_simpletikz_fragment() {
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:331:12: ( tikzcoordinate_core2 )
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:331:13: tikzcoordinate_core2
        {
        	PushFollow(FOLLOW_tikzcoordinate_core2_in_synpred5_simpletikz1633);
        	tikzcoordinate_core2();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred5_simpletikz"

    // $ANTLR start "synpred6_simpletikz"
    public void synpred6_simpletikz_fragment() {
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:332:12: ( tikzcoordinate_core1 )
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:332:13: tikzcoordinate_core1
        {
        	PushFollow(FOLLOW_tikzcoordinate_core1_in_synpred6_simpletikz1653);
        	tikzcoordinate_core1();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred6_simpletikz"

    // $ANTLR start "synpred7_simpletikz"
    public void synpred7_simpletikz_fragment() {
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:379:28: ( size )
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:379:29: size
        {
        	PushFollow(FOLLOW_size_in_synpred7_simpletikz1935);
        	size();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred7_simpletikz"

    // Delegated rules

   	public bool synpred7_simpletikz() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred7_simpletikz_fragment(); // can never throw exception
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
   	public bool synpred4_simpletikz() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred4_simpletikz_fragment(); // can never throw exception
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
   	public bool synpred5_simpletikz() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred5_simpletikz_fragment(); // can never throw exception
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
   	public bool synpred3_simpletikz() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred3_simpletikz_fragment(); // can never throw exception
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
   	public bool synpred6_simpletikz() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred6_simpletikz_fragment(); // can never throw exception
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
   	public bool synpred2_simpletikz() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred2_simpletikz_fragment(); // can never throw exception
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
   	protected DFA13 dfa13;
   	protected DFA24 dfa24;
   	protected DFA25 dfa25;
   	protected DFA36 dfa36;
   	protected DFA38 dfa38;
   	protected DFA45 dfa45;
   	protected DFA50 dfa50;
	private void InitializeCyclicDFAs()
	{
    	this.dfa8 = new DFA8(this);
    	this.dfa13 = new DFA13(this);
    	this.dfa24 = new DFA24(this);
    	this.dfa25 = new DFA25(this);
    	this.dfa36 = new DFA36(this);
    	this.dfa38 = new DFA38(this);
    	this.dfa45 = new DFA45(this);
    	this.dfa50 = new DFA50(this);
	    this.dfa36.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA36_SpecialStateTransition);
	    this.dfa38.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA38_SpecialStateTransition);
	    this.dfa45.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA45_SpecialStateTransition);
	}

    const string DFA8_eotS =
        "\x04\uffff";
    const string DFA8_eofS =
        "\x04\uffff";
    const string DFA8_minS =
        "\x02\x04\x02\uffff";
    const string DFA8_maxS =
        "\x02\x4e\x02\uffff";
    const string DFA8_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA8_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA8_transitionS = {
            "\x23\x01\x0b\uffff\x1d\x01",
            "\x23\x01\x01\uffff\x03\x03\x01\uffff\x01\x02\x03\uffff\x01"+
            "\x03\x01\uffff\x1d\x01",
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

    const string DFA13_eotS =
        "\x23\uffff";
    const string DFA13_eofS =
        "\x23\uffff";
    const string DFA13_minS =
        "\x01\x04\x01\x28\x01\x04\x01\uffff\x01\x28\x02\uffff\x02\x04\x01"+
        "\uffff\x0f\x04\x01\uffff\x09\x04";
    const string DFA13_maxS =
        "\x01\x4e\x01\x37\x01\x4e\x01\uffff\x01\x30\x02\uffff\x02\x4e\x01"+
        "\uffff\x0f\x4e\x01\uffff\x09\x4e";
    const string DFA13_acceptS =
        "\x03\uffff\x01\x04\x01\uffff\x01\x01\x01\x02\x02\uffff\x01\x05"+
        "\x0f\uffff\x01\x03\x09\uffff";
    const string DFA13_specialS =
        "\x23\uffff}>";
    static readonly string[] DFA13_transitionS = {
            "\x17\x03\x02\x01\x0a\x03\x01\x02\x0a\uffff\x1d\x03",
            "\x01\x06\x01\uffff\x01\x06\x01\x05\x04\uffff\x01\x06\x01\uffff"+
            "\x06\x04",
            "\x29\x09\x01\x07\x1d\x09\x02\x08\x02\x09",
            "",
            "\x01\x06\x01\uffff\x01\x06\x01\x05\x04\uffff\x01\x06",
            "",
            "",
            "\x17\x0c\x02\x0b\x0a\x0c\x01\x0a\x0a\x09\x1d\x0c",
            "\x29\x09\x01\x0d\x21\x09",
            "",
            "\x23\x0e\x0b\x09\x1d\x0e",
            "\x23\x0c\x03\x09\x02\x0f\x02\x09\x01\x11\x03\x09\x06\x10\x17"+
            "\x0c",
            "\x23\x0c\x03\x09\x02\x12\x02\x09\x01\x11\x03\x09\x1d\x0c",
            "\x17\x14\x02\x13\x0a\x14\x01\x0a\x0a\x09\x1d\x14",
            "\x23\x0e\x01\x09\x01\x15\x09\x09\x1d\x0e",
            "\x17\x18\x02\x16\x0a\x18\x01\x17\x0a\x09\x1d\x18",
            "\x23\x0c\x03\x09\x02\x0f\x02\x09\x01\x11\x03\x09\x1d\x0c",
            "\x24\x09\x01\x19\x26\x09",
            "\x23\x18\x01\x17\x0a\x09\x1d\x18",
            "\x23\x14\x03\x09\x02\x0f\x06\x09\x06\x1a\x17\x14",
            "\x23\x14\x03\x09\x02\x12\x06\x09\x1d\x14",
            "\x26\x09\x02\x1b\x23\x09",
            "\x23\x18\x07\x09\x01\x1d\x03\x09\x06\x1c\x17\x18",
            "\x23\x1e\x0b\x09\x1d\x1e",
            "\x23\x18\x07\x09\x01\x1f\x03\x09\x1d\x18",
            "",
            "\x23\x14\x03\x09\x02\x0f\x06\x09\x1d\x14",
            "\x23\x20\x01\x17\x0a\x09\x1d\x20",
            "\x23\x18\x07\x09\x01\x1d\x03\x09\x1d\x18",
            "\x24\x09\x01\x19\x26\x09",
            "\x23\x1e\x01\x09\x01\x21\x09\x09\x1d\x1e",
            "\x24\x09\x01\x19\x26\x09",
            "\x23\x20\x07\x09\x01\x22\x03\x09\x1d\x20",
            "\x2a\x09\x01\x22\x20\x09",
            "\x24\x09\x01\x19\x26\x09"
    };

    static readonly short[] DFA13_eot = DFA.UnpackEncodedString(DFA13_eotS);
    static readonly short[] DFA13_eof = DFA.UnpackEncodedString(DFA13_eofS);
    static readonly char[] DFA13_min = DFA.UnpackEncodedStringToUnsignedChars(DFA13_minS);
    static readonly char[] DFA13_max = DFA.UnpackEncodedStringToUnsignedChars(DFA13_maxS);
    static readonly short[] DFA13_accept = DFA.UnpackEncodedString(DFA13_acceptS);
    static readonly short[] DFA13_special = DFA.UnpackEncodedString(DFA13_specialS);
    static readonly short[][] DFA13_transition = DFA.UnpackEncodedStringArray(DFA13_transitionS);

    protected class DFA13 : DFA
    {
        public DFA13(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 13;
            this.eot = DFA13_eot;
            this.eof = DFA13_eof;
            this.min = DFA13_min;
            this.max = DFA13_max;
            this.accept = DFA13_accept;
            this.special = DFA13_special;
            this.transition = DFA13_transition;

        }

        override public string Description
        {
            get { return "184:1: iddornumberunitorstringorrange : ( range | numberunit | bracedcoord | idd | tikzstring );"; }
        }

    }

    const string DFA24_eotS =
        "\x0c\uffff";
    const string DFA24_eofS =
        "\x0c\uffff";
    const string DFA24_minS =
        "\x01\x04\x01\x27\x07\uffff\x01\x1a\x02\uffff";
    const string DFA24_maxS =
        "\x01\x4e\x01\x27\x07\uffff\x01\x4e\x02\uffff";
    const string DFA24_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x08\x01"+
        "\x09\x01\uffff\x01\x01\x01\x07";
    const string DFA24_specialS =
        "\x0c\uffff}>";
    static readonly string[] DFA24_transitionS = {
            "\x20\x08\x01\x01\x01\x06\x01\x05\x08\x08\x01\uffff\x08\x08"+
            "\x01\x07\x01\x03\x01\x04\x04\x02\x10\x08",
            "\x01\x09",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0b\x33\uffff\x01\x0a",
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
            get { return "240:4: ( tikzscope | tikzpath | tikznode_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr )"; }
        }

    }

    const string DFA25_eotS =
        "\x0f\uffff";
    const string DFA25_eofS =
        "\x0f\uffff";
    const string DFA25_minS =
        "\x01\x04\x02\x27\x06\uffff\x02\x1a\x04\uffff";
    const string DFA25_maxS =
        "\x01\x4e\x02\x27\x06\uffff\x02\x4e\x04\uffff";
    const string DFA25_acceptS =
        "\x03\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x09\x02"+
        "\uffff\x01\x0a\x01\x08\x01\x01\x01\x07";
    const string DFA25_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA25_transitionS = {
            "\x20\x08\x01\x02\x01\x07\x01\x06\x11\x08\x01\x01\x01\x04\x01"+
            "\x05\x04\x03\x10\x08",
            "\x01\x09",
            "\x01\x0a",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0c\x32\uffff\x02\x0b",
            "\x01\x0e\x33\uffff\x01\x0d",
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
            get { return "()* loopback of 241:3: ( tikzscope | tikzpath | tikznode_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*"; }
        }

    }

    const string DFA36_eotS =
        "\x10\uffff";
    const string DFA36_eofS =
        "\x10\uffff";
    const string DFA36_minS =
        "\x01\x1a\x03\x00\x0c\uffff";
    const string DFA36_maxS =
        "\x01\x4c\x03\x00\x0c\uffff";
    const string DFA36_acceptS =
        "\x04\uffff\x01\x04\x08\uffff\x01\x01\x01\x02\x01\x03";
    const string DFA36_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x0c\uffff}>";
    static readonly string[] DFA36_transitionS = {
            "\x01\x04\x0c\uffff\x01\x04\x05\uffff\x01\x01\x01\uffff\x01"+
            "\x03\x01\uffff\x01\x04\x0e\uffff\x02\x04\x01\x02\x03\x04\x01"+
            "\uffff\x06\x04",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA36_eot = DFA.UnpackEncodedString(DFA36_eotS);
    static readonly short[] DFA36_eof = DFA.UnpackEncodedString(DFA36_eofS);
    static readonly char[] DFA36_min = DFA.UnpackEncodedStringToUnsignedChars(DFA36_minS);
    static readonly char[] DFA36_max = DFA.UnpackEncodedStringToUnsignedChars(DFA36_maxS);
    static readonly short[] DFA36_accept = DFA.UnpackEncodedString(DFA36_acceptS);
    static readonly short[] DFA36_special = DFA.UnpackEncodedString(DFA36_specialS);
    static readonly short[][] DFA36_transition = DFA.UnpackEncodedStringArray(DFA36_transitionS);

    protected class DFA36 : DFA
    {
        public DFA36(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 36;
            this.eot = DFA36_eot;
            this.eof = DFA36_eof;
            this.min = DFA36_min;
            this.max = DFA36_max;
            this.accept = DFA36_accept;
            this.special = DFA36_special;
            this.transition = DFA36_transition;

        }

        override public string Description
        {
            get { return "319:5: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?"; }
        }

    }


    protected internal int DFA36_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA36_1 = input.LA(1);

                   	 
                   	int index36_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_simpletikz()) ) { s = 13; }

                   	else if ( (synpred2_simpletikz()) ) { s = 14; }

                   	else if ( (synpred3_simpletikz()) ) { s = 15; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index36_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA36_2 = input.LA(1);

                   	 
                   	int index36_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_simpletikz()) ) { s = 13; }

                   	else if ( (synpred2_simpletikz()) ) { s = 14; }

                   	else if ( (synpred3_simpletikz()) ) { s = 15; }

                   	 
                   	input.Seek(index36_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA36_3 = input.LA(1);

                   	 
                   	int index36_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_simpletikz()) ) { s = 13; }

                   	else if ( (synpred2_simpletikz()) ) { s = 14; }

                   	else if ( (synpred3_simpletikz()) ) { s = 15; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index36_3);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae36 =
            new NoViableAltException(dfa.Description, 36, _s, input);
        dfa.Error(nvae36);
        throw nvae36;
    }
    const string DFA38_eotS =
        "\x13\uffff";
    const string DFA38_eofS =
        "\x13\uffff";
    const string DFA38_minS =
        "\x01\x1a\x03\x00\x0f\uffff";
    const string DFA38_maxS =
        "\x01\x4c\x03\x00\x0f\uffff";
    const string DFA38_acceptS =
        "\x04\uffff\x01\x04\x0b\uffff\x01\x01\x01\x02\x01\x03";
    const string DFA38_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x0f\uffff}>";
    static readonly string[] DFA38_transitionS = {
            "\x01\x04\x02\uffff\x01\x04\x09\uffff\x02\x04\x04\uffff\x01"+
            "\x01\x01\uffff\x01\x03\x01\uffff\x01\x04\x01\uffff\x01\x04\x0c"+
            "\uffff\x02\x04\x01\x02\x03\x04\x01\uffff\x06\x04",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
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
            get { return "330:18: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?"; }
        }

    }


    protected internal int DFA38_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA38_1 = input.LA(1);

                   	 
                   	int index38_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred4_simpletikz()) ) { s = 16; }

                   	else if ( (synpred5_simpletikz()) ) { s = 17; }

                   	else if ( (synpred6_simpletikz()) ) { s = 18; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index38_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA38_2 = input.LA(1);

                   	 
                   	int index38_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred4_simpletikz()) ) { s = 16; }

                   	else if ( (synpred5_simpletikz()) ) { s = 17; }

                   	else if ( (synpred6_simpletikz()) ) { s = 18; }

                   	 
                   	input.Seek(index38_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA38_3 = input.LA(1);

                   	 
                   	int index38_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred4_simpletikz()) ) { s = 16; }

                   	else if ( (synpred5_simpletikz()) ) { s = 17; }

                   	else if ( (synpred6_simpletikz()) ) { s = 18; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index38_3);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae38 =
            new NoViableAltException(dfa.Description, 38, _s, input);
        dfa.Error(nvae38);
        throw nvae38;
    }
    const string DFA45_eotS =
        "\x0a\uffff";
    const string DFA45_eofS =
        "\x0a\uffff";
    const string DFA45_minS =
        "\x01\x1a\x01\x04\x01\uffff\x02\x04\x01\x00\x01\x04\x01\uffff\x02"+
        "\x04";
    const string DFA45_maxS =
        "\x01\x4c\x01\x4e\x01\uffff\x02\x4e\x01\x00\x01\x4e\x01\uffff\x02"+
        "\x4e";
    const string DFA45_acceptS =
        "\x02\uffff\x01\x02\x04\uffff\x01\x01\x02\uffff";
    const string DFA45_specialS =
        "\x05\uffff\x01\x00\x04\uffff}>";
    static readonly string[] DFA45_transitionS = {
            "\x01\x02\x02\uffff\x01\x02\x09\uffff\x02\x02\x04\uffff\x01"+
            "\x01\x01\uffff\x01\x02\x01\uffff\x01\x02\x01\uffff\x01\x02\x0c"+
            "\uffff\x02\x02\x01\uffff\x03\x02\x01\uffff\x06\x02",
            "\x17\x02\x02\x03\x0b\x02\x0a\uffff\x1d\x02",
            "",
            "\x23\x02\x03\uffff\x02\x02\x02\uffff\x01\x05\x03\uffff\x06"+
            "\x04\x0e\x02\x01\x06\x08\x02",
            "\x23\x02\x03\uffff\x02\x02\x02\uffff\x01\x05\x03\uffff\x14"+
            "\x02\x01\x06\x08\x02",
            "\x01\uffff",
            "\x17\x02\x02\x08\x0a\x02\x03\uffff\x02\x02\x02\uffff\x01\x02"+
            "\x03\uffff\x1d\x02",
            "",
            "\x23\x02\x03\uffff\x02\x02\x02\uffff\x01\x05\x03\uffff\x06"+
            "\x09\x17\x02",
            "\x23\x02\x03\uffff\x02\x02\x02\uffff\x01\x05\x03\uffff\x1d"+
            "\x02"
    };

    static readonly short[] DFA45_eot = DFA.UnpackEncodedString(DFA45_eotS);
    static readonly short[] DFA45_eof = DFA.UnpackEncodedString(DFA45_eofS);
    static readonly char[] DFA45_min = DFA.UnpackEncodedStringToUnsignedChars(DFA45_minS);
    static readonly char[] DFA45_max = DFA.UnpackEncodedStringToUnsignedChars(DFA45_maxS);
    static readonly short[] DFA45_accept = DFA.UnpackEncodedString(DFA45_acceptS);
    static readonly short[] DFA45_special = DFA.UnpackEncodedString(DFA45_specialS);
    static readonly short[][] DFA45_transition = DFA.UnpackEncodedStringArray(DFA45_transitionS);

    protected class DFA45 : DFA
    {
        public DFA45(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 45;
            this.eot = DFA45_eot;
            this.eof = DFA45_eof;
            this.min = DFA45_min;
            this.max = DFA45_max;
            this.accept = DFA45_accept;
            this.special = DFA45_special;
            this.transition = DFA45_transition;

        }

        override public string Description
        {
            get { return "379:27: ( ( size )=> size )?"; }
        }

    }


    protected internal int DFA45_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA45_5 = input.LA(1);

                   	 
                   	int index45_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred7_simpletikz()) ) { s = 7; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index45_5);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae45 =
            new NoViableAltException(dfa.Description, 45, _s, input);
        dfa.Error(nvae45);
        throw nvae45;
    }
    const string DFA50_eotS =
        "\x0f\uffff";
    const string DFA50_eofS =
        "\x0f\uffff";
    const string DFA50_minS =
        "\x01\x2d\x01\x04\x01\x2d\x02\x04\x01\uffff\x01\x04\x01\uffff\x05"+
        "\x04\x01\uffff\x01\x04";
    const string DFA50_maxS =
        "\x01\x4c\x01\x4e\x01\x2d\x02\x4e\x01\uffff\x01\x4e\x01\uffff\x05"+
        "\x4e\x01\uffff\x01\x4e";
    const string DFA50_acceptS =
        "\x05\uffff\x01\x03\x01\uffff\x01\x01\x05\uffff\x01\x02\x01\uffff";
    const string DFA50_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA50_transitionS = {
            "\x01\x01\x1d\uffff\x02\x02",
            "\x17\x04\x02\x03\x0a\x04\x01\x05\x0a\uffff\x1d\x04",
            "\x01\x06",
            "\x23\x04\x03\uffff\x02\x09\x02\uffff\x01\x07\x03\uffff\x06"+
            "\x08\x17\x04",
            "\x23\x04\x03\uffff\x02\x05\x02\uffff\x01\x07\x03\uffff\x1d"+
            "\x04",
            "",
            "\x17\x05\x02\x0a\x0b\x05\x0a\uffff\x1d\x05",
            "",
            "\x23\x04\x03\uffff\x02\x09\x02\uffff\x01\x07\x03\uffff\x1d"+
            "\x04",
            "\x17\x05\x02\x0b\x0b\x05\x0a\uffff\x1d\x05",
            "\x23\x05\x03\uffff\x02\x09\x06\uffff\x06\x0c\x17\x05",
            "\x23\x05\x07\uffff\x01\x0d\x03\uffff\x06\x0e\x17\x05",
            "\x23\x05\x03\uffff\x02\x09\x06\uffff\x1d\x05",
            "",
            "\x23\x05\x07\uffff\x01\x0d\x03\uffff\x1d\x05"
    };

    static readonly short[] DFA50_eot = DFA.UnpackEncodedString(DFA50_eotS);
    static readonly short[] DFA50_eof = DFA.UnpackEncodedString(DFA50_eofS);
    static readonly char[] DFA50_min = DFA.UnpackEncodedStringToUnsignedChars(DFA50_minS);
    static readonly char[] DFA50_max = DFA.UnpackEncodedStringToUnsignedChars(DFA50_maxS);
    static readonly short[] DFA50_accept = DFA.UnpackEncodedString(DFA50_acceptS);
    static readonly short[] DFA50_special = DFA.UnpackEncodedString(DFA50_specialS);
    static readonly short[][] DFA50_transition = DFA.UnpackEncodedStringArray(DFA50_transitionS);

    protected class DFA50 : DFA
    {
        public DFA50(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 50;
            this.eot = DFA50_eot;
            this.eof = DFA50_eof;
            this.min = DFA50_min;
            this.max = DFA50_max;
            this.accept = DFA50_accept;
            this.special = DFA50_special;
            this.transition = DFA50_transition;

        }

        override public string Description
        {
            get { return "393:1: coord : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_dontcare_preamble_in_tikzdocument249 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_tikz_styleorsetorcmd_in_tikzdocument253 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzdocument257 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_tikzpicture_in_tikzdocument262 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_dontcare_preamble_in_tikzdocument_wo_tikzpicture288 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_tikz_styleorsetorcmd_in_tikzdocument_wo_tikzpicture292 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzdocument_wo_tikzpicture296 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000007FFFUL});
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
    public static readonly BitSet FOLLOW_39_in_tikz_style408 = new BitSet(new ulong[]{0xFFFC007FFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_idd_in_tikz_style410 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_tikz_style412 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_tikz_style414 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikz_style416 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_squarebr_start_in_tikz_options438 = new BitSet(new ulong[]{0xFFFD007FFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_options441 = new BitSet(new ulong[]{0xFFFD047FFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_42_in_tikz_options444 = new BitSet(new ulong[]{0xFFFC007FFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_options446 = new BitSet(new ulong[]{0xFFFD047FFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_42_in_tikz_options450 = new BitSet(new ulong[]{0xFFFD007FFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_squarebr_end_in_tikz_options455 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_option_style_in_option480 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_option_kv_in_option489 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_option_kv503 = new BitSet(new ulong[]{0x0000020000000002UL});
    public static readonly BitSet FOLLOW_41_in_option_kv506 = new BitSet(new ulong[]{0xFFFC00FFFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_iddornumberunitorstringorrange_in_option_kv508 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_tikzstring536 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_no_rlbrace_in_tikzstring538 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikzstring542 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_no_rlbrace_in_tikzstring544 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_40_in_tikzstring549 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_no_rlbrace572 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_range_in_iddornumberunitorstringorrange590 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_numberunit_in_iddornumberunitorstringorrange594 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_bracedcoord_in_iddornumberunitorstringorrange598 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_iddornumberunitorstringorrange602 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzstring_in_iddornumberunitorstringorrange606 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_bracedcoord619 = new BitSet(new ulong[]{0x0000200000000000UL,0x0000000000001800UL});
    public static readonly BitSet FOLLOW_coord_in_bracedcoord623 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_bracedcoord625 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_numberunit_in_range636 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_range638 = new BitSet(new ulong[]{0x0000000018000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_range640 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_option_style664 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_option_style666 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_option_style668 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_39_in_option_style670 = new BitSet(new ulong[]{0xFFFC057FFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_option_kv_in_option_style673 = new BitSet(new ulong[]{0x0000050000000000UL});
    public static readonly BitSet FOLLOW_42_in_option_style676 = new BitSet(new ulong[]{0xFFFC007FFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_option_kv_in_option_style678 = new BitSet(new ulong[]{0x0000050000000000UL});
    public static readonly BitSet FOLLOW_42_in_option_style685 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_option_style688 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_heavenknowswhythisisnecessary_in_idd723 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_idd_heavenknowswhythisisnecessary743 = new BitSet(new ulong[]{0xFFFC007FFFFFFFF2UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_ID_in_idd2797 = new BitSet(new ulong[]{0x0000000004000002UL});
    public static readonly BitSet FOLLOW_number_in_numberunit820 = new BitSet(new ulong[]{0x00FC000000000002UL});
    public static readonly BitSet FOLLOW_unit_in_numberunit822 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_number848 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unit0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_set_start_in_tikz_set903 = new BitSet(new ulong[]{0xFFFC017FFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_set906 = new BitSet(new ulong[]{0xFFFC057FFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_42_in_tikz_set909 = new BitSet(new ulong[]{0xFFFC007FFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_set911 = new BitSet(new ulong[]{0xFFFC057FFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_roundbr_end_in_tikz_set917 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzpicture_start_in_tikzpicture945 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpicture947 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzpicture950 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_tikzpicture_end_in_tikzpicture953 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody983 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody987 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_tikznode_ext_in_tikzbody991 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_tikzcoordinate_ext_in_tikzbody995 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody999 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody1003 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody1007 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody1012 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_dontcare_body_nobr_in_tikzbody1017 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody1028 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody1032 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_tikznode_ext_in_tikzbody1036 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_tikzcoordinate_ext_in_tikzbody1040 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody1044 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody1048 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody1052 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody1057 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_dontcare_body_in_tikzbody1062 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body_nobr1079 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body1137 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_otherend1192 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_39_in_otherend1194 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_idd2_in_otherend1196 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_otherend1198 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzscope_start_in_tikzscope1225 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzscope1227 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzscope1230 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_tikzscope_end_in_tikzscope1233 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_in_tikzpath1288 = new BitSet(new ulong[]{0x0002A08004000000UL,0x0000000000001FBBUL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath1290 = new BitSet(new ulong[]{0x0002A08004000000UL,0x0000000000001FBBUL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzpath1293 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_in_tikzpath1312 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_63_in_tikzpath1314 = new BitSet(new ulong[]{0x0008000020000000UL});
    public static readonly BitSet FOLLOW_let_assignment_in_tikzpath1316 = new BitSet(new ulong[]{0x0008000020000000UL});
    public static readonly BitSet FOLLOW_51_in_tikzpath1319 = new BitSet(new ulong[]{0x0002A08004000000UL,0x0000000000001FBBUL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath1321 = new BitSet(new ulong[]{0x0002A08004000000UL,0x0000000000001FBBUL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzpath1324 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COMMAND_in_let_assignment1350 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_let_assignment1352 = new BitSet(new ulong[]{0x0000A08004000002UL,0x0000000000001FBBUL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_let_assignment1354 = new BitSet(new ulong[]{0x0000A08004000002UL,0x0000000000001FBBUL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpath_element1370 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_in_tikzpath_element1377 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_int_in_tikzpath_element1383 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_int_in_tikzpath_element1389 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_circle_in_tikzpath_element1395 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arc_in_tikzpath_element1402 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_roundbr_start_in_tikzpath_element1409 = new BitSet(new ulong[]{0xFFFCA1FFFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath_element1411 = new BitSet(new ulong[]{0xFFFCA1FFFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_roundbr_end_in_tikzpath_element1414 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_edgeop_in_tikzpath_element1433 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_node_start_in_tikznode_ext1444 = new BitSet(new ulong[]{0xFFFCA0FFFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_tikznode_core_in_tikznode_ext1446 = new BitSet(new ulong[]{0x0002A08004000000UL,0x0000000000001FBBUL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikznode_ext1448 = new BitSet(new ulong[]{0x0002A08004000000UL,0x0000000000001FBBUL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikznode_ext1451 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coordinate_start_in_tikzcoordinate_ext1479 = new BitSet(new ulong[]{0x0002A08004000000UL,0x0000000000001FBFUL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_ext1494 = new BitSet(new ulong[]{0x0002A08004000000UL,0x0000000000001FBBUL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_ext1513 = new BitSet(new ulong[]{0x0002A08004000000UL,0x0000000000001FBBUL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_ext1533 = new BitSet(new ulong[]{0x0002A08004000000UL,0x0000000000001FBBUL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzcoordinate_ext1544 = new BitSet(new ulong[]{0x0002A08004000000UL,0x0000000000001FBBUL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzcoordinate_ext1547 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_64_in_tikzcoordinate_int1607 = new BitSet(new ulong[]{0x0000A00000000002UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_int1618 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_int1637 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_int1657 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_65_in_tikznode_int1673 = new BitSet(new ulong[]{0xFFFCA0FFFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_tikznode_core_in_tikznode_int1676 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikznode_core1686 = new BitSet(new ulong[]{0xFFFCA0FFFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikznode_core1689 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core31714 = new BitSet(new ulong[]{0x0000A00000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core31716 = new BitSet(new ulong[]{0x0000A00000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core31718 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core21752 = new BitSet(new ulong[]{0x0000A00000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core21754 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core11787 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_tikznode_decorator1824 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_66_in_tikznode_decorator1831 = new BitSet(new ulong[]{0x0000200000000000UL,0x0000000000001800UL});
    public static readonly BitSet FOLLOW_coord_in_tikznode_decorator1834 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_options_dontcare_in_tikznode_decorator1840 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_47_in_tikz_options_dontcare1850 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_no_rlbracket_in_tikz_options_dontcare1852 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_tikz_options_dontcare_in_tikz_options_dontcare1856 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_no_rlbracket_in_tikz_options_dontcare1858 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_48_in_tikz_options_dontcare1863 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_no_rlbracket1881 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_nodename1898 = new BitSet(new ulong[]{0xFFFC007FFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_idd_in_nodename1900 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_nodename1902 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_67_in_circle1926 = new BitSet(new ulong[]{0x0000200000000002UL});
    public static readonly BitSet FOLLOW_68_in_circle1930 = new BitSet(new ulong[]{0x0000200000000002UL});
    public static readonly BitSet FOLLOW_size_in_circle1939 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_69_in_arc1954 = new BitSet(new ulong[]{0x0000200000000002UL});
    public static readonly BitSet FOLLOW_45_in_arc1957 = new BitSet(new ulong[]{0x0000000018000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_arc1959 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_arc1961 = new BitSet(new ulong[]{0x0000000018000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_arc1963 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_arc1965 = new BitSet(new ulong[]{0x0000000018000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_arc1967 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_arc1969 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_size1987 = new BitSet(new ulong[]{0x0000000018000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_size1989 = new BitSet(new ulong[]{0x0000400000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_70_in_size1992 = new BitSet(new ulong[]{0x0000000018000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_size1994 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_size1998 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_coord2028 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord2052 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_coord2055 = new BitSet(new ulong[]{0x0000000018000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord2057 = new BitSet(new ulong[]{0x00000C0000000000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord2059 = new BitSet(new ulong[]{0x0000000018000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord2061 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_coord2063 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord2087 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_coord2090 = new BitSet(new ulong[]{0xFFFC00FFFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_coord2092 = new BitSet(new ulong[]{0x00000C0000000000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord2094 = new BitSet(new ulong[]{0xFFFC00FFFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_coord2096 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_coord2098 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_coord_part2126 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_coord_part2141 = new BitSet(new ulong[]{0xFFFC007FFFFFFFF0UL,0x0000000000007FFFUL});
    public static readonly BitSet FOLLOW_idd_in_coord_part2143 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_coord_part2145 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_coord_sep2167 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_edgeop0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_coord_modifier0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_47_in_squarebr_start2241 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_48_in_squarebr_end2259 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_49_in_semicolon_end2278 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_roundbr_start2296 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_roundbr_end2314 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_tikz_set_start2332 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_39_in_tikz_set_start2334 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_36_in_tikzpicture_start2353 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_39_in_tikzpicture_start2355 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_77_in_tikzpicture_start2357 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_tikzpicture_start2359 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_tikzpicture_end2377 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_39_in_tikzpicture_end2379 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_77_in_tikzpicture_end2381 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_tikzpicture_end2383 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_36_in_tikzscope_start2401 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_39_in_tikzscope_start2403 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_78_in_tikzscope_start2405 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_tikzscope_start2407 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_tikzscope_end2425 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_39_in_tikzscope_end2427 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_78_in_tikzscope_end2429 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_tikzscope_end2431 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_tag_in_path_start2450 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_node_start_tag_in_node_start2468 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_57_in_node_start_tag2486 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_58_in_coordinate_start2496 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_path_start_tag0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_synpred1_simpletikz1490 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_synpred2_simpletikz1509 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_synpred3_simpletikz1529 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_synpred4_simpletikz1614 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_synpred5_simpletikz1633 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_synpred6_simpletikz1653 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_size_in_synpred7_simpletikz1935 = new BitSet(new ulong[]{0x0000000000000002UL});

}
