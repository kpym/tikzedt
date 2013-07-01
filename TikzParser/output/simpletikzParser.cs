// $ANTLR 3.1.1 C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g 2013-07-01 14:00:49

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
		"IM_CONTROLS", 
		"IM_TIKZEDT_CMD", 
		"IM_DONTCARE", 
		"IM_ARC", 
		"TIKZEDT_CMD_COMMENT", 
		"ID", 
		"COMMAND", 
		"FLOAT_WO_EXP", 
		"INT", 
		"WS", 
		"COMMENT", 
		"EXPONENT", 
		"ESC_SEQ", 
		"MATHSTRING", 
		"SOMETHING", 
		"SOMETHING1", 
		"'\\\\begin'", 
		"'\\\\tikzstyle'", 
		"'\\\\tikzset'", 
		"'\\\\tikz'", 
		"'{'", 
		"'}'", 
		"'='", 
		"'+='", 
		"','", 
		"':'", 
		"'/.style'", 
		"'/.append'", 
		"'style'", 
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
		"'\\\\matrix'", 
		"'\\\\coordinate'", 
		"'\\\\draw'", 
		"'\\\\path'", 
		"'\\\\def'", 
		"'\\\\filldraw'", 
		"'\\\\pattern'", 
		"'\\\\shade'", 
		"'\\\\shadedraw'", 
		"'\\\\useasboundingbox'", 
		"'\\\\fill'", 
		"'\\\\clip'", 
		"'let'", 
		"'and'", 
		"'coordinate'", 
		"'node'", 
		"'at'", 
		"'circle'", 
		"'ellipse'", 
		"'arc'", 
		"'--'", 
		"'->'", 
		"'|-'", 
		"'-|'", 
		"'+'", 
		"'++'", 
		"'..'", 
		"'controls'", 
		"'tikzpicture'", 
		"'scope'"
    };

    public const int EXPONENT = 34;
    public const int TIKZEDT_CMD_COMMENT = 27;
    public const int IM_PATH = 4;
    public const int IM_ID = 18;
    public const int IM_DONTCARE = 25;
    public const int SOMETHING = 37;
    public const int EOF = -1;
    public const int IM_ARC = 26;
    public const int COMMAND = 29;
    public const int IM_ENDTAG = 14;
    public const int T__93 = 93;
    public const int T__94 = 94;
    public const int T__91 = 91;
    public const int T__92 = 92;
    public const int IM_DOCUMENT = 11;
    public const int IM_STRING = 21;
    public const int T__90 = 90;
    public const int IM_TIKZSET = 19;
    public const int COMMENT = 33;
    public const int SOMETHING1 = 38;
    public const int T__80 = 80;
    public const int IM_OPTIONS = 15;
    public const int T__81 = 81;
    public const int T__82 = 82;
    public const int IM_OPTION_STYLE = 16;
    public const int T__83 = 83;
    public const int IM_COORD = 6;
    public const int INT = 31;
    public const int T__85 = 85;
    public const int T__84 = 84;
    public const int T__87 = 87;
    public const int T__86 = 86;
    public const int T__89 = 89;
    public const int T__88 = 88;
    public const int IM_NODE = 5;
    public const int IM_STYLE = 22;
    public const int T__71 = 71;
    public const int WS = 32;
    public const int T__72 = 72;
    public const int T__70 = 70;
    public const int T__76 = 76;
    public const int T__75 = 75;
    public const int T__74 = 74;
    public const int T__73 = 73;
    public const int T__79 = 79;
    public const int T__78 = 78;
    public const int T__77 = 77;
    public const int T__68 = 68;
    public const int T__69 = 69;
    public const int T__66 = 66;
    public const int T__67 = 67;
    public const int T__64 = 64;
    public const int T__65 = 65;
    public const int IM_STARTTAG = 13;
    public const int T__62 = 62;
    public const int T__63 = 63;
    public const int IM_CONTROLS = 23;
    public const int T__61 = 61;
    public const int ID = 28;
    public const int T__60 = 60;
    public const int MATHSTRING = 36;
    public const int T__55 = 55;
    public const int IM_USETIKZLIB = 20;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int ESC_SEQ = 35;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int T__59 = 59;
    public const int IM_OPTION_KV = 17;
    public const int T__50 = 50;
    public const int IM_TIKZEDT_CMD = 24;
    public const int T__42 = 42;
    public const int T__43 = 43;
    public const int T__40 = 40;
    public const int T__41 = 41;
    public const int T__46 = 46;
    public const int T__47 = 47;
    public const int T__44 = 44;
    public const int T__45 = 45;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int IM_PICTURE = 10;
    public const int IM_NUMBERUNIT = 9;
    public const int IM_SCOPE = 12;
    public const int T__39 = 39;
    public const int IM_SIZE = 7;
    public const int IM_NODENAME = 8;
    public const int FLOAT_WO_EXP = 30;

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
		get { return "C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g"; }
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:140:1: tikzdocument : ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* tikzpicture ( . )* -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture ) ;
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
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:141:2: ( ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* tikzpicture ( . )* -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:141:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* tikzpicture ( . )*
            {
            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:141:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )*
            	do 
            	{
            	    int alt1 = 4;
            	    switch ( input.LA(1) ) 
            	    {
            	    case 39:
            	    	{
            	        int LA1_1 = input.LA(2);

            	        if ( (LA1_1 == 43) )
            	        {
            	            int LA1_5 = input.LA(3);

            	            if ( (LA1_5 == ID) )
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
            	    case IM_CONTROLS:
            	    case IM_TIKZEDT_CMD:
            	    case IM_DONTCARE:
            	    case IM_ARC:
            	    case ID:
            	    case COMMAND:
            	    case FLOAT_WO_EXP:
            	    case INT:
            	    case WS:
            	    case COMMENT:
            	    case EXPONENT:
            	    case ESC_SEQ:
            	    case MATHSTRING:
            	    case SOMETHING:
            	    case SOMETHING1:
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
            	    case 79:
            	    case 80:
            	    case 81:
            	    case 82:
            	    case 83:
            	    case 84:
            	    case 85:
            	    case 86:
            	    case 87:
            	    case 88:
            	    case 89:
            	    case 90:
            	    case 91:
            	    case 92:
            	    case 93:
            	    case 94:
            	    	{
            	        alt1 = 1;
            	        }
            	        break;
            	    case TIKZEDT_CMD_COMMENT:
            	    case 40:
            	    case 41:
            	    	{
            	        alt1 = 2;
            	        }
            	        break;

            	    }

            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:141:5: dontcare_preamble
            			    {
            			    	PushFollow(FOLLOW_dontcare_preamble_in_tikzdocument257);
            			    	dontcare_preamble1 = dontcare_preamble();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_dontcare_preamble.Add(dontcare_preamble1.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:141:25: tikz_styleorsetorcmd
            			    {
            			    	PushFollow(FOLLOW_tikz_styleorsetorcmd_in_tikzdocument261);
            			    	tikz_styleorsetorcmd2 = tikz_styleorsetorcmd();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikz_styleorsetorcmd.Add(tikz_styleorsetorcmd2.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:141:48: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzdocument265);
            			    	otherbegin3 = otherbegin();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_otherbegin.Add(otherbegin3.Tree);

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	PushFollow(FOLLOW_tikzpicture_in_tikzdocument270);
            	tikzpicture4 = tikzpicture();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikzpicture.Add(tikzpicture4.Tree);
            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:141:74: ( . )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= IM_PATH && LA2_0 <= 94)) )
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
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:141:74: .
            			    {
            			    	wildcard5 = (IToken)input.LT(1);
            			    	MatchAny(input); if (state.failed) return retval;

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
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 141:77: -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:141:80: ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DOCUMENT, "IM_DOCUMENT"), root_1);

            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:141:94: ( tikz_styleorsetorcmd )*
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

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:144:1: tikzdocument_wo_tikzpicture : ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* EOF -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* ) ;
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
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:145:2: ( ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* EOF -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:145:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* EOF
            {
            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:145:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )*
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
            	    case IM_CONTROLS:
            	    case IM_TIKZEDT_CMD:
            	    case IM_DONTCARE:
            	    case IM_ARC:
            	    case ID:
            	    case COMMAND:
            	    case FLOAT_WO_EXP:
            	    case INT:
            	    case WS:
            	    case COMMENT:
            	    case EXPONENT:
            	    case ESC_SEQ:
            	    case MATHSTRING:
            	    case SOMETHING:
            	    case SOMETHING1:
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
            	    case 79:
            	    case 80:
            	    case 81:
            	    case 82:
            	    case 83:
            	    case 84:
            	    case 85:
            	    case 86:
            	    case 87:
            	    case 88:
            	    case 89:
            	    case 90:
            	    case 91:
            	    case 92:
            	    case 93:
            	    case 94:
            	    	{
            	        alt3 = 1;
            	        }
            	        break;
            	    case TIKZEDT_CMD_COMMENT:
            	    case 40:
            	    case 41:
            	    	{
            	        alt3 = 2;
            	        }
            	        break;
            	    case 39:
            	    	{
            	        alt3 = 3;
            	        }
            	        break;

            	    }

            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:145:5: dontcare_preamble
            			    {
            			    	PushFollow(FOLLOW_dontcare_preamble_in_tikzdocument_wo_tikzpicture296);
            			    	dontcare_preamble6 = dontcare_preamble();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_dontcare_preamble.Add(dontcare_preamble6.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:145:25: tikz_styleorsetorcmd
            			    {
            			    	PushFollow(FOLLOW_tikz_styleorsetorcmd_in_tikzdocument_wo_tikzpicture300);
            			    	tikz_styleorsetorcmd7 = tikz_styleorsetorcmd();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikz_styleorsetorcmd.Add(tikz_styleorsetorcmd7.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:145:48: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzdocument_wo_tikzpicture304);
            			    	otherbegin8 = otherbegin();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_otherbegin.Add(otherbegin8.Tree);

            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements

            	EOF9=(IToken)Match(input,EOF,FOLLOW_EOF_in_tikzdocument_wo_tikzpicture309); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_EOF.Add(EOF9);



            	// AST REWRITE
            	// elements:          tikz_styleorsetorcmd
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 145:66: -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:145:69: ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DOCUMENT, "IM_DOCUMENT"), root_1);

            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:145:83: ( tikz_styleorsetorcmd )*
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

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:148:1: tikz_cmd_comment : TIKZEDT_CMD_COMMENT -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT ) ;
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
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:149:2: ( TIKZEDT_CMD_COMMENT -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:149:4: TIKZEDT_CMD_COMMENT
            {
            	TIKZEDT_CMD_COMMENT10=(IToken)Match(input,TIKZEDT_CMD_COMMENT,FOLLOW_TIKZEDT_CMD_COMMENT_in_tikz_cmd_comment330); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_TIKZEDT_CMD_COMMENT.Add(TIKZEDT_CMD_COMMENT10);



            	// AST REWRITE
            	// elements:          TIKZEDT_CMD_COMMENT
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 149:27: -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:149:30: ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT )
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

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:152:1: tikz_styleorsetorcmd : ( tikz_style | tikz_set | tikz_cmd_comment );
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
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:153:2: ( tikz_style | tikz_set | tikz_cmd_comment )
            int alt4 = 3;
            switch ( input.LA(1) ) 
            {
            case 40:
            	{
                alt4 = 1;
                }
                break;
            case 41:
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
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:153:4: tikz_style
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_style_in_tikz_styleorsetorcmd352);
                    	tikz_style11 = tikz_style();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style11.Tree);

                    }
                    break;
                case 2 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:153:17: tikz_set
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_set_in_tikz_styleorsetorcmd356);
                    	tikz_set12 = tikz_set();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set12.Tree);

                    }
                    break;
                case 3 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:153:28: tikz_cmd_comment
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_cmd_comment_in_tikz_styleorsetorcmd360);
                    	tikz_cmd_comment13 = tikz_cmd_comment();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_cmd_comment13.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:156:1: dontcare_preamble : ~ ( '\\\\begin' | '\\\\tikzstyle' | '\\\\tikzset' | '\\\\tikz' | TIKZEDT_CMD_COMMENT ) ;
    public simpletikzParser.dontcare_preamble_return dontcare_preamble() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_preamble_return retval = new simpletikzParser.dontcare_preamble_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set14 = null;

        object set14_tree=null;

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:157:2: (~ ( '\\\\begin' | '\\\\tikzstyle' | '\\\\tikzset' | '\\\\tikz' | TIKZEDT_CMD_COMMENT ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:157:4: ~ ( '\\\\begin' | '\\\\tikzstyle' | '\\\\tikzset' | '\\\\tikz' | TIKZEDT_CMD_COMMENT )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set14 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= IM_ARC) || (input.LA(1) >= ID && input.LA(1) <= SOMETHING1) || (input.LA(1) >= 43 && input.LA(1) <= 94) ) 
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

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:159:1: otherbegin : '\\\\begin' '{' idd2 '}' ;
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
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:160:2: ( '\\\\begin' '{' idd2 '}' )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:160:4: '\\\\begin' '{' idd2 '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal15=(IToken)Match(input,39,FOLLOW_39_in_otherbegin400); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal15_tree = (object)adaptor.Create(string_literal15);
            		adaptor.AddChild(root_0, string_literal15_tree);
            	}
            	char_literal16=(IToken)Match(input,43,FOLLOW_43_in_otherbegin402); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal16_tree = (object)adaptor.Create(char_literal16);
            		adaptor.AddChild(root_0, char_literal16_tree);
            	}
            	PushFollow(FOLLOW_idd2_in_otherbegin404);
            	idd217 = idd2();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idd217.Tree);
            	char_literal18=(IToken)Match(input,44,FOLLOW_44_in_otherbegin406); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal18_tree = (object)adaptor.Create(char_literal18);
            		adaptor.AddChild(root_0, char_literal18_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:163:1: tikz_style : '\\\\tikzstyle' '{' idd '}' ( '=' | '+=' ) tikz_options -> ^( IM_STYLE idd tikz_options ) ;
    public simpletikzParser.tikz_style_return tikz_style() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_style_return retval = new simpletikzParser.tikz_style_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal19 = null;
        IToken char_literal20 = null;
        IToken char_literal22 = null;
        IToken char_literal23 = null;
        IToken string_literal24 = null;
        simpletikzParser.idd_return idd21 = default(simpletikzParser.idd_return);

        simpletikzParser.tikz_options_return tikz_options25 = default(simpletikzParser.tikz_options_return);


        object string_literal19_tree=null;
        object char_literal20_tree=null;
        object char_literal22_tree=null;
        object char_literal23_tree=null;
        object string_literal24_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_46 = new RewriteRuleTokenStream(adaptor,"token 46");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:164:2: ( '\\\\tikzstyle' '{' idd '}' ( '=' | '+=' ) tikz_options -> ^( IM_STYLE idd tikz_options ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:164:4: '\\\\tikzstyle' '{' idd '}' ( '=' | '+=' ) tikz_options
            {
            	string_literal19=(IToken)Match(input,40,FOLLOW_40_in_tikz_style418); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_40.Add(string_literal19);

            	char_literal20=(IToken)Match(input,43,FOLLOW_43_in_tikz_style420); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_43.Add(char_literal20);

            	PushFollow(FOLLOW_idd_in_tikz_style422);
            	idd21 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_idd.Add(idd21.Tree);
            	char_literal22=(IToken)Match(input,44,FOLLOW_44_in_tikz_style424); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_44.Add(char_literal22);

            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:164:30: ( '=' | '+=' )
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == 45) )
            	{
            	    alt5 = 1;
            	}
            	else if ( (LA5_0 == 46) )
            	{
            	    alt5 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d5s0 =
            	        new NoViableAltException("", 5, 0, input);

            	    throw nvae_d5s0;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:164:31: '='
            	        {
            	        	char_literal23=(IToken)Match(input,45,FOLLOW_45_in_tikz_style427); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_45.Add(char_literal23);


            	        }
            	        break;
            	    case 2 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:164:37: '+='
            	        {
            	        	string_literal24=(IToken)Match(input,46,FOLLOW_46_in_tikz_style431); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_46.Add(string_literal24);


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikz_options_in_tikz_style434);
            	tikz_options25 = tikz_options();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikz_options.Add(tikz_options25.Tree);


            	// AST REWRITE
            	// elements:          idd, tikz_options
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 164:56: -> ^( IM_STYLE idd tikz_options )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:164:59: ^( IM_STYLE idd tikz_options )
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

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:167:1: tikz_options : squarebr_start ( option ( ',' option )* ( ',' )? )? ( tikzstring )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) ;
    public simpletikzParser.tikz_options_return tikz_options() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_options_return retval = new simpletikzParser.tikz_options_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal28 = null;
        IToken char_literal30 = null;
        simpletikzParser.squarebr_start_return squarebr_start26 = default(simpletikzParser.squarebr_start_return);

        simpletikzParser.option_return option27 = default(simpletikzParser.option_return);

        simpletikzParser.option_return option29 = default(simpletikzParser.option_return);

        simpletikzParser.tikzstring_return tikzstring31 = default(simpletikzParser.tikzstring_return);

        simpletikzParser.squarebr_end_return squarebr_end32 = default(simpletikzParser.squarebr_end_return);


        object char_literal28_tree=null;
        object char_literal30_tree=null;
        RewriteRuleTokenStream stream_47 = new RewriteRuleTokenStream(adaptor,"token 47");
        RewriteRuleSubtreeStream stream_squarebr_start = new RewriteRuleSubtreeStream(adaptor,"rule squarebr_start");
        RewriteRuleSubtreeStream stream_tikzstring = new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_squarebr_end = new RewriteRuleSubtreeStream(adaptor,"rule squarebr_end");
        RewriteRuleSubtreeStream stream_option = new RewriteRuleSubtreeStream(adaptor,"rule option");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:168:2: ( squarebr_start ( option ( ',' option )* ( ',' )? )? ( tikzstring )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:168:5: squarebr_start ( option ( ',' option )* ( ',' )? )? ( tikzstring )? squarebr_end
            {
            	PushFollow(FOLLOW_squarebr_start_in_tikz_options456);
            	squarebr_start26 = squarebr_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_squarebr_start.Add(squarebr_start26.Tree);
            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:168:20: ( option ( ',' option )* ( ',' )? )?
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( ((LA8_0 >= IM_PATH && LA8_0 <= 42) || LA8_0 == 46 || LA8_0 == 51 || (LA8_0 >= 57 && LA8_0 <= 94)) )
            	{
            	    alt8 = 1;
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:168:21: option ( ',' option )* ( ',' )?
            	        {
            	        	PushFollow(FOLLOW_option_in_tikz_options459);
            	        	option27 = option();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_option.Add(option27.Tree);
            	        	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:168:28: ( ',' option )*
            	        	do 
            	        	{
            	        	    int alt6 = 2;
            	        	    int LA6_0 = input.LA(1);

            	        	    if ( (LA6_0 == 47) )
            	        	    {
            	        	        int LA6_1 = input.LA(2);

            	        	        if ( ((LA6_1 >= IM_PATH && LA6_1 <= 42) || LA6_1 == 46 || LA6_1 == 51 || (LA6_1 >= 57 && LA6_1 <= 94)) )
            	        	        {
            	        	            alt6 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt6) 
            	        		{
            	        			case 1 :
            	        			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:168:29: ',' option
            	        			    {
            	        			    	char_literal28=(IToken)Match(input,47,FOLLOW_47_in_tikz_options462); if (state.failed) return retval; 
            	        			    	if ( state.backtracking==0 ) stream_47.Add(char_literal28);

            	        			    	PushFollow(FOLLOW_option_in_tikz_options464);
            	        			    	option29 = option();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking==0 ) stream_option.Add(option29.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop6;
            	        	    }
            	        	} while (true);

            	        	loop6:
            	        		;	// Stops C# compiler whining that label 'loop6' has no statements

            	        	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:168:42: ( ',' )?
            	        	int alt7 = 2;
            	        	int LA7_0 = input.LA(1);

            	        	if ( (LA7_0 == 47) )
            	        	{
            	        	    alt7 = 1;
            	        	}
            	        	switch (alt7) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:168:42: ','
            	        	        {
            	        	        	char_literal30=(IToken)Match(input,47,FOLLOW_47_in_tikz_options468); if (state.failed) return retval; 
            	        	        	if ( state.backtracking==0 ) stream_47.Add(char_literal30);


            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:168:49: ( tikzstring )?
            	int alt9 = 2;
            	int LA9_0 = input.LA(1);

            	if ( (LA9_0 == 43) )
            	{
            	    alt9 = 1;
            	}
            	switch (alt9) 
            	{
            	    case 1 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:168:49: tikzstring
            	        {
            	        	PushFollow(FOLLOW_tikzstring_in_tikz_options473);
            	        	tikzstring31 = tikzstring();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_tikzstring.Add(tikzstring31.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_squarebr_end_in_tikz_options476);
            	squarebr_end32 = squarebr_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_squarebr_end.Add(squarebr_end32.Tree);


            	// AST REWRITE
            	// elements:          squarebr_end, squarebr_start, option
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 168:75: -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:168:78: ^( IM_OPTIONS squarebr_start ( option )* squarebr_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTIONS, "IM_OPTIONS"), root_1);

            	    adaptor.AddChild(root_1, stream_squarebr_start.NextTree());
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:168:106: ( option )*
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

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:171:1: option : ( option_style | option_kv );
    public simpletikzParser.option_return option() // throws RecognitionException [1]
    {   
        simpletikzParser.option_return retval = new simpletikzParser.option_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.option_style_return option_style33 = default(simpletikzParser.option_style_return);

        simpletikzParser.option_kv_return option_kv34 = default(simpletikzParser.option_kv_return);



        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:172:2: ( option_style | option_kv )
            int alt10 = 2;
            alt10 = dfa10.Predict(input);
            switch (alt10) 
            {
                case 1 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:172:4: option_style
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_option_style_in_option501);
                    	option_style33 = option_style();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, option_style33.Tree);

                    }
                    break;
                case 2 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:173:5: option_kv
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_option_kv_in_option510);
                    	option_kv34 = option_kv();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, option_kv34.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:176:1: option_kv : idd ( '=' iddornumberunitorstringorrange )? -> ^( IM_OPTION_KV idd ( iddornumberunitorstringorrange )? ) ;
    public simpletikzParser.option_kv_return option_kv() // throws RecognitionException [1]
    {   
        simpletikzParser.option_kv_return retval = new simpletikzParser.option_kv_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal36 = null;
        simpletikzParser.idd_return idd35 = default(simpletikzParser.idd_return);

        simpletikzParser.iddornumberunitorstringorrange_return iddornumberunitorstringorrange37 = default(simpletikzParser.iddornumberunitorstringorrange_return);


        object char_literal36_tree=null;
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleSubtreeStream stream_iddornumberunitorstringorrange = new RewriteRuleSubtreeStream(adaptor,"rule iddornumberunitorstringorrange");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:177:2: ( idd ( '=' iddornumberunitorstringorrange )? -> ^( IM_OPTION_KV idd ( iddornumberunitorstringorrange )? ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:177:4: idd ( '=' iddornumberunitorstringorrange )?
            {
            	PushFollow(FOLLOW_idd_in_option_kv524);
            	idd35 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_idd.Add(idd35.Tree);
            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:177:8: ( '=' iddornumberunitorstringorrange )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == 45) )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:177:9: '=' iddornumberunitorstringorrange
            	        {
            	        	char_literal36=(IToken)Match(input,45,FOLLOW_45_in_option_kv527); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_45.Add(char_literal36);

            	        	PushFollow(FOLLOW_iddornumberunitorstringorrange_in_option_kv529);
            	        	iddornumberunitorstringorrange37 = iddornumberunitorstringorrange();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_iddornumberunitorstringorrange.Add(iddornumberunitorstringorrange37.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          idd, iddornumberunitorstringorrange
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 177:47: -> ^( IM_OPTION_KV idd ( iddornumberunitorstringorrange )? )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:177:50: ^( IM_OPTION_KV idd ( iddornumberunitorstringorrange )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTION_KV, "IM_OPTION_KV"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:177:69: ( iddornumberunitorstringorrange )?
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

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:180:1: tikzstring : '{' ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* '}' -> ^( IM_STRING '{' '}' ) ;
    public simpletikzParser.tikzstring_return tikzstring() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzstring_return retval = new simpletikzParser.tikzstring_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal38 = null;
        IToken char_literal42 = null;
        simpletikzParser.no_rlbrace_return no_rlbrace39 = default(simpletikzParser.no_rlbrace_return);

        simpletikzParser.tikzstring_return tikzstring40 = default(simpletikzParser.tikzstring_return);

        simpletikzParser.no_rlbrace_return no_rlbrace41 = default(simpletikzParser.no_rlbrace_return);


        object char_literal38_tree=null;
        object char_literal42_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleSubtreeStream stream_tikzstring = new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_no_rlbrace = new RewriteRuleSubtreeStream(adaptor,"rule no_rlbrace");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:181:2: ( '{' ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* '}' -> ^( IM_STRING '{' '}' ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:181:4: '{' ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* '}'
            {
            	char_literal38=(IToken)Match(input,43,FOLLOW_43_in_tikzstring557); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_43.Add(char_literal38);

            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:181:8: ( no_rlbrace )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( ((LA12_0 >= IM_PATH && LA12_0 <= 42) || (LA12_0 >= 45 && LA12_0 <= 94)) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:181:8: no_rlbrace
            			    {
            			    	PushFollow(FOLLOW_no_rlbrace_in_tikzstring559);
            			    	no_rlbrace39 = no_rlbrace();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_no_rlbrace.Add(no_rlbrace39.Tree);

            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements

            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:181:20: ( tikzstring ( no_rlbrace )* )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( (LA14_0 == 43) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:181:21: tikzstring ( no_rlbrace )*
            			    {
            			    	PushFollow(FOLLOW_tikzstring_in_tikzstring563);
            			    	tikzstring40 = tikzstring();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikzstring.Add(tikzstring40.Tree);
            			    	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:181:32: ( no_rlbrace )*
            			    	do 
            			    	{
            			    	    int alt13 = 2;
            			    	    int LA13_0 = input.LA(1);

            			    	    if ( ((LA13_0 >= IM_PATH && LA13_0 <= 42) || (LA13_0 >= 45 && LA13_0 <= 94)) )
            			    	    {
            			    	        alt13 = 1;
            			    	    }


            			    	    switch (alt13) 
            			    		{
            			    			case 1 :
            			    			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:181:32: no_rlbrace
            			    			    {
            			    			    	PushFollow(FOLLOW_no_rlbrace_in_tikzstring565);
            			    			    	no_rlbrace41 = no_rlbrace();
            			    			    	state.followingStackPointer--;
            			    			    	if (state.failed) return retval;
            			    			    	if ( state.backtracking==0 ) stream_no_rlbrace.Add(no_rlbrace41.Tree);

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

            	char_literal42=(IToken)Match(input,44,FOLLOW_44_in_tikzstring570); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_44.Add(char_literal42);



            	// AST REWRITE
            	// elements:          43, 44
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 181:50: -> ^( IM_STRING '{' '}' )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:181:53: ^( IM_STRING '{' '}' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STRING, "IM_STRING"), root_1);

            	    adaptor.AddChild(root_1, stream_43.NextNode());
            	    adaptor.AddChild(root_1, stream_44.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:184:1: no_rlbrace : ~ ( '{' | '}' ) ;
    public simpletikzParser.no_rlbrace_return no_rlbrace() // throws RecognitionException [1]
    {   
        simpletikzParser.no_rlbrace_return retval = new simpletikzParser.no_rlbrace_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set43 = null;

        object set43_tree=null;

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:185:2: (~ ( '{' | '}' ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:185:4: ~ ( '{' | '}' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set43 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= 42) || (input.LA(1) >= 45 && input.LA(1) <= 94) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set43));
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

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:187:1: iddornumberunitorstringorrange : ( range | numberunit | bracedcoord | idd | ( ( number ':' )? tikzstring ) );
    public simpletikzParser.iddornumberunitorstringorrange_return iddornumberunitorstringorrange() // throws RecognitionException [1]
    {   
        simpletikzParser.iddornumberunitorstringorrange_return retval = new simpletikzParser.iddornumberunitorstringorrange_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal49 = null;
        simpletikzParser.range_return range44 = default(simpletikzParser.range_return);

        simpletikzParser.numberunit_return numberunit45 = default(simpletikzParser.numberunit_return);

        simpletikzParser.bracedcoord_return bracedcoord46 = default(simpletikzParser.bracedcoord_return);

        simpletikzParser.idd_return idd47 = default(simpletikzParser.idd_return);

        simpletikzParser.number_return number48 = default(simpletikzParser.number_return);

        simpletikzParser.tikzstring_return tikzstring50 = default(simpletikzParser.tikzstring_return);


        object char_literal49_tree=null;

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:188:2: ( range | numberunit | bracedcoord | idd | ( ( number ':' )? tikzstring ) )
            int alt16 = 5;
            alt16 = dfa16.Predict(input);
            switch (alt16) 
            {
                case 1 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:188:5: range
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_range_in_iddornumberunitorstringorrange611);
                    	range44 = range();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, range44.Tree);

                    }
                    break;
                case 2 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:188:13: numberunit
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_numberunit_in_iddornumberunitorstringorrange615);
                    	numberunit45 = numberunit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, numberunit45.Tree);

                    }
                    break;
                case 3 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:188:26: bracedcoord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_bracedcoord_in_iddornumberunitorstringorrange619);
                    	bracedcoord46 = bracedcoord();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bracedcoord46.Tree);

                    }
                    break;
                case 4 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:188:40: idd
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_idd_in_iddornumberunitorstringorrange623);
                    	idd47 = idd();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idd47.Tree);

                    }
                    break;
                case 5 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:188:46: ( ( number ':' )? tikzstring )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:188:46: ( ( number ':' )? tikzstring )
                    	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:188:47: ( number ':' )? tikzstring
                    	{
                    		// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:188:47: ( number ':' )?
                    		int alt15 = 2;
                    		int LA15_0 = input.LA(1);

                    		if ( ((LA15_0 >= FLOAT_WO_EXP && LA15_0 <= INT)) )
                    		{
                    		    alt15 = 1;
                    		}
                    		switch (alt15) 
                    		{
                    		    case 1 :
                    		        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:188:49: number ':'
                    		        {
                    		        	PushFollow(FOLLOW_number_in_iddornumberunitorstringorrange630);
                    		        	number48 = number();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	char_literal49=(IToken)Match(input,48,FOLLOW_48_in_iddornumberunitorstringorrange633); if (state.failed) return retval;

                    		        }
                    		        break;

                    		}

                    		PushFollow(FOLLOW_tikzstring_in_iddornumberunitorstringorrange638);
                    		tikzstring50 = tikzstring();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzstring50.Tree);

                    	}


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:190:1: bracedcoord : '{' coord_nooption '}' ;
    public simpletikzParser.bracedcoord_return bracedcoord() // throws RecognitionException [1]
    {   
        simpletikzParser.bracedcoord_return retval = new simpletikzParser.bracedcoord_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal51 = null;
        IToken char_literal53 = null;
        simpletikzParser.coord_nooption_return coord_nooption52 = default(simpletikzParser.coord_nooption_return);


        object char_literal51_tree=null;
        object char_literal53_tree=null;

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:191:2: ( '{' coord_nooption '}' )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:191:4: '{' coord_nooption '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal51=(IToken)Match(input,43,FOLLOW_43_in_bracedcoord652); if (state.failed) return retval;
            	PushFollow(FOLLOW_coord_nooption_in_bracedcoord656);
            	coord_nooption52 = coord_nooption();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, coord_nooption52.Tree);
            	char_literal53=(IToken)Match(input,44,FOLLOW_44_in_bracedcoord658); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:193:1: range : numberunit ':' numberunit -> ^( IM_STRING numberunit ':' numberunit ) ;
    public simpletikzParser.range_return range() // throws RecognitionException [1]
    {   
        simpletikzParser.range_return retval = new simpletikzParser.range_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal55 = null;
        simpletikzParser.numberunit_return numberunit54 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit56 = default(simpletikzParser.numberunit_return);


        object char_literal55_tree=null;
        RewriteRuleTokenStream stream_48 = new RewriteRuleTokenStream(adaptor,"token 48");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:194:2: ( numberunit ':' numberunit -> ^( IM_STRING numberunit ':' numberunit ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:194:4: numberunit ':' numberunit
            {
            	PushFollow(FOLLOW_numberunit_in_range669);
            	numberunit54 = numberunit();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_numberunit.Add(numberunit54.Tree);
            	char_literal55=(IToken)Match(input,48,FOLLOW_48_in_range671); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_48.Add(char_literal55);

            	PushFollow(FOLLOW_numberunit_in_range673);
            	numberunit56 = numberunit();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_numberunit.Add(numberunit56.Tree);


            	// AST REWRITE
            	// elements:          numberunit, numberunit, 48
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 194:30: -> ^( IM_STRING numberunit ':' numberunit )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:194:33: ^( IM_STRING numberunit ':' numberunit )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STRING, "IM_STRING"), root_1);

            	    adaptor.AddChild(root_1, stream_numberunit.NextTree());
            	    adaptor.AddChild(root_1, stream_48.NextNode());
            	    adaptor.AddChild(root_1, stream_numberunit.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:196:1: option_style : idd ( '/.style' | ( '/.append' 'style' ) ) '=' '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}' -> ^( IM_OPTION_STYLE idd ( option_kv )* ) ;
    public simpletikzParser.option_style_return option_style() // throws RecognitionException [1]
    {   
        simpletikzParser.option_style_return retval = new simpletikzParser.option_style_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal58 = null;
        IToken string_literal59 = null;
        IToken string_literal60 = null;
        IToken char_literal61 = null;
        IToken char_literal62 = null;
        IToken char_literal64 = null;
        IToken char_literal66 = null;
        IToken char_literal67 = null;
        simpletikzParser.idd_return idd57 = default(simpletikzParser.idd_return);

        simpletikzParser.option_kv_return option_kv63 = default(simpletikzParser.option_kv_return);

        simpletikzParser.option_kv_return option_kv65 = default(simpletikzParser.option_kv_return);


        object string_literal58_tree=null;
        object string_literal59_tree=null;
        object string_literal60_tree=null;
        object char_literal61_tree=null;
        object char_literal62_tree=null;
        object char_literal64_tree=null;
        object char_literal66_tree=null;
        object char_literal67_tree=null;
        RewriteRuleTokenStream stream_49 = new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_47 = new RewriteRuleTokenStream(adaptor,"token 47");
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_option_kv = new RewriteRuleSubtreeStream(adaptor,"rule option_kv");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:197:2: ( idd ( '/.style' | ( '/.append' 'style' ) ) '=' '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}' -> ^( IM_OPTION_STYLE idd ( option_kv )* ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:197:4: idd ( '/.style' | ( '/.append' 'style' ) ) '=' '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}'
            {
            	PushFollow(FOLLOW_idd_in_option_style697);
            	idd57 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_idd.Add(idd57.Tree);
            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:197:8: ( '/.style' | ( '/.append' 'style' ) )
            	int alt17 = 2;
            	int LA17_0 = input.LA(1);

            	if ( (LA17_0 == 49) )
            	{
            	    alt17 = 1;
            	}
            	else if ( (LA17_0 == 50) )
            	{
            	    alt17 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d17s0 =
            	        new NoViableAltException("", 17, 0, input);

            	    throw nvae_d17s0;
            	}
            	switch (alt17) 
            	{
            	    case 1 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:197:9: '/.style'
            	        {
            	        	string_literal58=(IToken)Match(input,49,FOLLOW_49_in_option_style700); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_49.Add(string_literal58);


            	        }
            	        break;
            	    case 2 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:197:21: ( '/.append' 'style' )
            	        {
            	        	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:197:21: ( '/.append' 'style' )
            	        	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:197:22: '/.append' 'style'
            	        	{
            	        		string_literal59=(IToken)Match(input,50,FOLLOW_50_in_option_style705); if (state.failed) return retval; 
            	        		if ( state.backtracking==0 ) stream_50.Add(string_literal59);

            	        		string_literal60=(IToken)Match(input,51,FOLLOW_51_in_option_style707); if (state.failed) return retval; 
            	        		if ( state.backtracking==0 ) stream_51.Add(string_literal60);


            	        	}


            	        }
            	        break;

            	}

            	char_literal61=(IToken)Match(input,45,FOLLOW_45_in_option_style711); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_45.Add(char_literal61);

            	char_literal62=(IToken)Match(input,43,FOLLOW_43_in_option_style713); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_43.Add(char_literal62);

            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:197:51: ( option_kv ( ',' option_kv )* )?
            	int alt19 = 2;
            	int LA19_0 = input.LA(1);

            	if ( ((LA19_0 >= IM_PATH && LA19_0 <= 42) || LA19_0 == 46 || LA19_0 == 51 || (LA19_0 >= 57 && LA19_0 <= 94)) )
            	{
            	    alt19 = 1;
            	}
            	switch (alt19) 
            	{
            	    case 1 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:197:52: option_kv ( ',' option_kv )*
            	        {
            	        	PushFollow(FOLLOW_option_kv_in_option_style716);
            	        	option_kv63 = option_kv();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_option_kv.Add(option_kv63.Tree);
            	        	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:197:62: ( ',' option_kv )*
            	        	do 
            	        	{
            	        	    int alt18 = 2;
            	        	    int LA18_0 = input.LA(1);

            	        	    if ( (LA18_0 == 47) )
            	        	    {
            	        	        int LA18_1 = input.LA(2);

            	        	        if ( ((LA18_1 >= IM_PATH && LA18_1 <= 42) || LA18_1 == 46 || LA18_1 == 51 || (LA18_1 >= 57 && LA18_1 <= 94)) )
            	        	        {
            	        	            alt18 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt18) 
            	        		{
            	        			case 1 :
            	        			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:197:63: ',' option_kv
            	        			    {
            	        			    	char_literal64=(IToken)Match(input,47,FOLLOW_47_in_option_style719); if (state.failed) return retval; 
            	        			    	if ( state.backtracking==0 ) stream_47.Add(char_literal64);

            	        			    	PushFollow(FOLLOW_option_kv_in_option_style721);
            	        			    	option_kv65 = option_kv();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking==0 ) stream_option_kv.Add(option_kv65.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop18;
            	        	    }
            	        	} while (true);

            	        	loop18:
            	        		;	// Stops C# compiler whining that label 'loop18' has no statements


            	        }
            	        break;

            	}

            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:197:82: ( ',' )?
            	int alt20 = 2;
            	int LA20_0 = input.LA(1);

            	if ( (LA20_0 == 47) )
            	{
            	    alt20 = 1;
            	}
            	switch (alt20) 
            	{
            	    case 1 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:197:82: ','
            	        {
            	        	char_literal66=(IToken)Match(input,47,FOLLOW_47_in_option_style728); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_47.Add(char_literal66);


            	        }
            	        break;

            	}

            	char_literal67=(IToken)Match(input,44,FOLLOW_44_in_option_style731); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_44.Add(char_literal67);



            	// AST REWRITE
            	// elements:          idd, option_kv
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 197:92: -> ^( IM_OPTION_STYLE idd ( option_kv )* )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:197:95: ^( IM_OPTION_STYLE idd ( option_kv )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTION_STYLE, "IM_OPTION_STYLE"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:197:117: ( option_kv )*
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

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:209:1: idd : idd_heavenknowswhythisisnecessary -> ^( IM_ID ) ;
    public simpletikzParser.idd_return idd() // throws RecognitionException [1]
    {   
        simpletikzParser.idd_return retval = new simpletikzParser.idd_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.idd_heavenknowswhythisisnecessary_return idd_heavenknowswhythisisnecessary68 = default(simpletikzParser.idd_heavenknowswhythisisnecessary_return);


        RewriteRuleSubtreeStream stream_idd_heavenknowswhythisisnecessary = new RewriteRuleSubtreeStream(adaptor,"rule idd_heavenknowswhythisisnecessary");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:210:2: ( idd_heavenknowswhythisisnecessary -> ^( IM_ID ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:210:4: idd_heavenknowswhythisisnecessary
            {
            	PushFollow(FOLLOW_idd_heavenknowswhythisisnecessary_in_idd766);
            	idd_heavenknowswhythisisnecessary68 = idd_heavenknowswhythisisnecessary();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_idd_heavenknowswhythisisnecessary.Add(idd_heavenknowswhythisisnecessary68.Tree);


            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 210:39: -> ^( IM_ID )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:210:42: ^( IM_ID )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ID, "IM_ID"), root_1);

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:212:1: idd_heavenknowswhythisisnecessary : (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' ) )+ ;
    public simpletikzParser.idd_heavenknowswhythisisnecessary_return idd_heavenknowswhythisisnecessary() // throws RecognitionException [1]
    {   
        simpletikzParser.idd_heavenknowswhythisisnecessary_return retval = new simpletikzParser.idd_heavenknowswhythisisnecessary_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set69 = null;

        object set69_tree=null;

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:213:3: ( (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' ) )+ )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:213:6: (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' ) )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:213:6: (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' ) )+
            	int cnt21 = 0;
            	do 
            	{
            	    int alt21 = 2;
            	    int LA21_0 = input.LA(1);

            	    if ( (LA21_0 == 78) )
            	    {
            	        int LA21_2 = input.LA(2);

            	        if ( ((LA21_2 >= FLOAT_WO_EXP && LA21_2 <= INT) || (LA21_2 >= 43 && LA21_2 <= 45) || (LA21_2 >= 47 && LA21_2 <= 50) || LA21_2 == 53 || LA21_2 == 55 || LA21_2 == 78) )
            	        {
            	            alt21 = 1;
            	        }
            	        else if ( ((LA21_2 >= IM_PATH && LA21_2 <= COMMAND) || (LA21_2 >= WS && LA21_2 <= 42) || LA21_2 == 46 || LA21_2 == 51 || (LA21_2 >= 57 && LA21_2 <= 77) || (LA21_2 >= 79 && LA21_2 <= 94)) )
            	        {
            	            alt21 = 1;
            	        }


            	    }
            	    else if ( ((LA21_0 >= IM_PATH && LA21_0 <= 42) || LA21_0 == 46 || LA21_0 == 51 || (LA21_0 >= 57 && LA21_0 <= 77) || (LA21_0 >= 79 && LA21_0 <= 94)) )
            	    {
            	        alt21 = 1;
            	    }


            	    switch (alt21) 
            		{
            			case 1 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:213:6: ~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' )
            			    {
            			    	set69 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= 42) || input.LA(1) == 46 || input.LA(1) == 51 || (input.LA(1) >= 57 && input.LA(1) <= 94) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set69));
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
            			    if ( cnt21 >= 1 ) goto loop21;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee =
            		                new EarlyExitException(21, input);
            		            throw eee;
            	    }
            	    cnt21++;
            	} while (true);

            	loop21:
            		;	// Stops C# compiler whinging that label 'loop21' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:214:1: idd2 : ( ID )+ -> ^( IM_ID ) ;
    public simpletikzParser.idd2_return idd2() // throws RecognitionException [1]
    {   
        simpletikzParser.idd2_return retval = new simpletikzParser.idd2_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID70 = null;

        object ID70_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:215:2: ( ( ID )+ -> ^( IM_ID ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:215:4: ( ID )+
            {
            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:215:4: ( ID )+
            	int cnt22 = 0;
            	do 
            	{
            	    int alt22 = 2;
            	    int LA22_0 = input.LA(1);

            	    if ( (LA22_0 == ID) )
            	    {
            	        alt22 = 1;
            	    }


            	    switch (alt22) 
            		{
            			case 1 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:215:4: ID
            			    {
            			    	ID70=(IToken)Match(input,ID,FOLLOW_ID_in_idd2846); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_ID.Add(ID70);


            			    }
            			    break;

            			default:
            			    if ( cnt22 >= 1 ) goto loop22;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee =
            		                new EarlyExitException(22, input);
            		            throw eee;
            	    }
            	    cnt22++;
            	} while (true);

            	loop22:
            		;	// Stops C# compiler whinging that label 'loop22' has no statements



            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 215:8: -> ^( IM_ID )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:215:11: ^( IM_ID )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ID, "IM_ID"), root_1);

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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

    public class numberunitorvariable_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "numberunitorvariable"
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:218:1: numberunitorvariable : ( numberunit | COMMAND );
    public simpletikzParser.numberunitorvariable_return numberunitorvariable() // throws RecognitionException [1]
    {   
        simpletikzParser.numberunitorvariable_return retval = new simpletikzParser.numberunitorvariable_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken COMMAND72 = null;
        simpletikzParser.numberunit_return numberunit71 = default(simpletikzParser.numberunit_return);


        object COMMAND72_tree=null;

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:219:2: ( numberunit | COMMAND )
            int alt23 = 2;
            int LA23_0 = input.LA(1);

            if ( ((LA23_0 >= FLOAT_WO_EXP && LA23_0 <= INT)) )
            {
                alt23 = 1;
            }
            else if ( (LA23_0 == COMMAND) )
            {
                alt23 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d23s0 =
                    new NoViableAltException("", 23, 0, input);

                throw nvae_d23s0;
            }
            switch (alt23) 
            {
                case 1 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:219:4: numberunit
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_numberunit_in_numberunitorvariable865);
                    	numberunit71 = numberunit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, numberunit71.Tree);

                    }
                    break;
                case 2 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:220:4: COMMAND
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	COMMAND72=(IToken)Match(input,COMMAND,FOLLOW_COMMAND_in_numberunitorvariable870); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{COMMAND72_tree = (object)adaptor.Create(COMMAND72);
                    		adaptor.AddChild(root_0, COMMAND72_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // $ANTLR end "numberunitorvariable"

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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:223:1: numberunit : number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) ;
    public simpletikzParser.numberunit_return numberunit() // throws RecognitionException [1]
    {   
        simpletikzParser.numberunit_return retval = new simpletikzParser.numberunit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.number_return number73 = default(simpletikzParser.number_return);

        simpletikzParser.unit_return unit74 = default(simpletikzParser.unit_return);


        RewriteRuleSubtreeStream stream_unit = new RewriteRuleSubtreeStream(adaptor,"rule unit");
        RewriteRuleSubtreeStream stream_number = new RewriteRuleSubtreeStream(adaptor,"rule number");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:224:2: ( number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:224:4: number ( unit )?
            {
            	PushFollow(FOLLOW_number_in_numberunit883);
            	number73 = number();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_number.Add(number73.Tree);
            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:224:11: ( unit )?
            	int alt24 = 2;
            	int LA24_0 = input.LA(1);

            	if ( ((LA24_0 >= 57 && LA24_0 <= 62)) )
            	{
            	    alt24 = 1;
            	}
            	switch (alt24) 
            	{
            	    case 1 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:224:11: unit
            	        {
            	        	PushFollow(FOLLOW_unit_in_numberunit885);
            	        	unit74 = unit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_unit.Add(unit74.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          number, unit
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 224:17: -> ^( IM_NUMBERUNIT number ( unit )? )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:224:20: ^( IM_NUMBERUNIT number ( unit )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NUMBERUNIT, "IM_NUMBERUNIT"), root_1);

            	    adaptor.AddChild(root_1, stream_number.NextTree());
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:224:43: ( unit )?
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

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:228:1: number : ( FLOAT_WO_EXP | INT ) ;
    public simpletikzParser.number_return number() // throws RecognitionException [1]
    {   
        simpletikzParser.number_return retval = new simpletikzParser.number_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set75 = null;

        object set75_tree=null;

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:229:2: ( ( FLOAT_WO_EXP | INT ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:229:4: ( FLOAT_WO_EXP | INT )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set75 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= FLOAT_WO_EXP && input.LA(1) <= INT) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set75));
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

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:232:1: unit : ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' | 'em' );
    public simpletikzParser.unit_return unit() // throws RecognitionException [1]
    {   
        simpletikzParser.unit_return retval = new simpletikzParser.unit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set76 = null;

        object set76_tree=null;

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:233:2: ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' | 'em' )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set76 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 57 && input.LA(1) <= 62) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set76));
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

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:236:1: tikz_set : tikz_set_start ( option ( ',' option )* ( ',' )? )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) ;
    public simpletikzParser.tikz_set_return tikz_set() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_set_return retval = new simpletikzParser.tikz_set_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal79 = null;
        IToken char_literal81 = null;
        simpletikzParser.tikz_set_start_return tikz_set_start77 = default(simpletikzParser.tikz_set_start_return);

        simpletikzParser.option_return option78 = default(simpletikzParser.option_return);

        simpletikzParser.option_return option80 = default(simpletikzParser.option_return);

        simpletikzParser.roundbr_end_return roundbr_end82 = default(simpletikzParser.roundbr_end_return);


        object char_literal79_tree=null;
        object char_literal81_tree=null;
        RewriteRuleTokenStream stream_47 = new RewriteRuleTokenStream(adaptor,"token 47");
        RewriteRuleSubtreeStream stream_tikz_set_start = new RewriteRuleSubtreeStream(adaptor,"rule tikz_set_start");
        RewriteRuleSubtreeStream stream_roundbr_end = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        RewriteRuleSubtreeStream stream_option = new RewriteRuleSubtreeStream(adaptor,"rule option");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:237:2: ( tikz_set_start ( option ( ',' option )* ( ',' )? )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:237:5: tikz_set_start ( option ( ',' option )* ( ',' )? )? roundbr_end
            {
            	PushFollow(FOLLOW_tikz_set_start_in_tikz_set966);
            	tikz_set_start77 = tikz_set_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikz_set_start.Add(tikz_set_start77.Tree);
            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:237:20: ( option ( ',' option )* ( ',' )? )?
            	int alt27 = 2;
            	int LA27_0 = input.LA(1);

            	if ( ((LA27_0 >= IM_PATH && LA27_0 <= 42) || LA27_0 == 46 || LA27_0 == 51 || (LA27_0 >= 57 && LA27_0 <= 94)) )
            	{
            	    alt27 = 1;
            	}
            	switch (alt27) 
            	{
            	    case 1 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:237:21: option ( ',' option )* ( ',' )?
            	        {
            	        	PushFollow(FOLLOW_option_in_tikz_set969);
            	        	option78 = option();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_option.Add(option78.Tree);
            	        	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:237:28: ( ',' option )*
            	        	do 
            	        	{
            	        	    int alt25 = 2;
            	        	    int LA25_0 = input.LA(1);

            	        	    if ( (LA25_0 == 47) )
            	        	    {
            	        	        int LA25_1 = input.LA(2);

            	        	        if ( ((LA25_1 >= IM_PATH && LA25_1 <= 42) || LA25_1 == 46 || LA25_1 == 51 || (LA25_1 >= 57 && LA25_1 <= 94)) )
            	        	        {
            	        	            alt25 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt25) 
            	        		{
            	        			case 1 :
            	        			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:237:29: ',' option
            	        			    {
            	        			    	char_literal79=(IToken)Match(input,47,FOLLOW_47_in_tikz_set972); if (state.failed) return retval; 
            	        			    	if ( state.backtracking==0 ) stream_47.Add(char_literal79);

            	        			    	PushFollow(FOLLOW_option_in_tikz_set974);
            	        			    	option80 = option();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking==0 ) stream_option.Add(option80.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop25;
            	        	    }
            	        	} while (true);

            	        	loop25:
            	        		;	// Stops C# compiler whining that label 'loop25' has no statements

            	        	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:237:42: ( ',' )?
            	        	int alt26 = 2;
            	        	int LA26_0 = input.LA(1);

            	        	if ( (LA26_0 == 47) )
            	        	{
            	        	    alt26 = 1;
            	        	}
            	        	switch (alt26) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:237:42: ','
            	        	        {
            	        	        	char_literal81=(IToken)Match(input,47,FOLLOW_47_in_tikz_set978); if (state.failed) return retval; 
            	        	        	if ( state.backtracking==0 ) stream_47.Add(char_literal81);


            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_roundbr_end_in_tikz_set983);
            	roundbr_end82 = roundbr_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_roundbr_end.Add(roundbr_end82.Tree);


            	// AST REWRITE
            	// elements:          option, tikz_set_start, roundbr_end
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 237:61: -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:237:64: ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_TIKZSET, "IM_TIKZSET"), root_1);

            	    adaptor.AddChild(root_1, stream_tikz_set_start.NextTree());
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:237:92: ( option )*
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

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:242:1: tikzpicture : ( ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) | ( tikz_start ( tikz_options )? '{' ( tikzbody2 )? roundbr_end ) -> ^( IM_PICTURE tikz_start ( tikz_options )? ( tikzbody2 )? roundbr_end ) );
    public simpletikzParser.tikzpicture_return tikzpicture() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_return retval = new simpletikzParser.tikzpicture_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal89 = null;
        simpletikzParser.tikzpicture_start_return tikzpicture_start83 = default(simpletikzParser.tikzpicture_start_return);

        simpletikzParser.tikz_options_return tikz_options84 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody_return tikzbody85 = default(simpletikzParser.tikzbody_return);

        simpletikzParser.tikzpicture_end_return tikzpicture_end86 = default(simpletikzParser.tikzpicture_end_return);

        simpletikzParser.tikz_start_return tikz_start87 = default(simpletikzParser.tikz_start_return);

        simpletikzParser.tikz_options_return tikz_options88 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody2_return tikzbody290 = default(simpletikzParser.tikzbody2_return);

        simpletikzParser.roundbr_end_return roundbr_end91 = default(simpletikzParser.roundbr_end_return);


        object char_literal89_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleSubtreeStream stream_tikzbody2 = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody2");
        RewriteRuleSubtreeStream stream_tikzpicture_end = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_end");
        RewriteRuleSubtreeStream stream_tikzpicture_start = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_start");
        RewriteRuleSubtreeStream stream_tikz_start = new RewriteRuleSubtreeStream(adaptor,"rule tikz_start");
        RewriteRuleSubtreeStream stream_roundbr_end = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:243:2: ( ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) | ( tikz_start ( tikz_options )? '{' ( tikzbody2 )? roundbr_end ) -> ^( IM_PICTURE tikz_start ( tikz_options )? ( tikzbody2 )? roundbr_end ) )
            int alt32 = 2;
            int LA32_0 = input.LA(1);

            if ( (LA32_0 == 39) )
            {
                alt32 = 1;
            }
            else if ( (LA32_0 == 42) )
            {
                alt32 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d32s0 =
                    new NoViableAltException("", 32, 0, input);

                throw nvae_d32s0;
            }
            switch (alt32) 
            {
                case 1 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:243:7: ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
                    {
                    	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:243:7: ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
                    	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:243:9: tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end
                    	{
                    		PushFollow(FOLLOW_tikzpicture_start_in_tikzpicture1015);
                    		tikzpicture_start83 = tikzpicture_start();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_tikzpicture_start.Add(tikzpicture_start83.Tree);
                    		// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:243:27: ( tikz_options )?
                    		int alt28 = 2;
                    		int LA28_0 = input.LA(1);

                    		if ( (LA28_0 == 54) )
                    		{
                    		    alt28 = 1;
                    		}
                    		switch (alt28) 
                    		{
                    		    case 1 :
                    		        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:243:27: tikz_options
                    		        {
                    		        	PushFollow(FOLLOW_tikz_options_in_tikzpicture1017);
                    		        	tikz_options84 = tikz_options();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_tikz_options.Add(tikz_options84.Tree);

                    		        }
                    		        break;

                    		}

                    		// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:243:41: ( tikzbody )?
                    		int alt29 = 2;
                    		int LA29_0 = input.LA(1);

                    		if ( ((LA29_0 >= IM_PATH && LA29_0 <= 53) || (LA29_0 >= 55 && LA29_0 <= 62) || (LA29_0 >= 64 && LA29_0 <= 94)) )
                    		{
                    		    alt29 = 1;
                    		}
                    		else if ( (LA29_0 == 63) )
                    		{
                    		    int LA29_2 = input.LA(2);

                    		    if ( (LA29_2 == 43) )
                    		    {
                    		        int LA29_3 = input.LA(3);

                    		        if ( (LA29_3 == ID) )
                    		        {
                    		            alt29 = 1;
                    		        }
                    		    }
                    		}
                    		switch (alt29) 
                    		{
                    		    case 1 :
                    		        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:243:41: tikzbody
                    		        {
                    		        	PushFollow(FOLLOW_tikzbody_in_tikzpicture1020);
                    		        	tikzbody85 = tikzbody();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_tikzbody.Add(tikzbody85.Tree);

                    		        }
                    		        break;

                    		}

                    		PushFollow(FOLLOW_tikzpicture_end_in_tikzpicture1023);
                    		tikzpicture_end86 = tikzpicture_end();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_tikzpicture_end.Add(tikzpicture_end86.Tree);

                    	}



                    	// AST REWRITE
                    	// elements:          tikzpicture_end, tikzbody, tikzpicture_start, tikz_options
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 243:68: -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
                    	{
                    	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:243:71: ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PICTURE, "IM_PICTURE"), root_1);

                    	    adaptor.AddChild(root_1, stream_tikzpicture_start.NextTree());
                    	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:243:102: ( tikz_options )?
                    	    if ( stream_tikz_options.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_tikz_options.NextTree());

                    	    }
                    	    stream_tikz_options.Reset();
                    	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:243:116: ( tikzbody )?
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
                    break;
                case 2 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:244:5: ( tikz_start ( tikz_options )? '{' ( tikzbody2 )? roundbr_end )
                    {
                    	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:244:5: ( tikz_start ( tikz_options )? '{' ( tikzbody2 )? roundbr_end )
                    	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:244:7: tikz_start ( tikz_options )? '{' ( tikzbody2 )? roundbr_end
                    	{
                    		PushFollow(FOLLOW_tikz_start_in_tikzpicture1048);
                    		tikz_start87 = tikz_start();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_tikz_start.Add(tikz_start87.Tree);
                    		// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:244:19: ( tikz_options )?
                    		int alt30 = 2;
                    		int LA30_0 = input.LA(1);

                    		if ( (LA30_0 == 54) )
                    		{
                    		    alt30 = 1;
                    		}
                    		switch (alt30) 
                    		{
                    		    case 1 :
                    		        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:244:19: tikz_options
                    		        {
                    		        	PushFollow(FOLLOW_tikz_options_in_tikzpicture1051);
                    		        	tikz_options88 = tikz_options();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_tikz_options.Add(tikz_options88.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal89=(IToken)Match(input,43,FOLLOW_43_in_tikzpicture1054); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_43.Add(char_literal89);

                    		// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:244:37: ( tikzbody2 )?
                    		int alt31 = 2;
                    		int LA31_0 = input.LA(1);

                    		if ( ((LA31_0 >= IM_PATH && LA31_0 <= 42) || (LA31_0 >= 45 && LA31_0 <= 53) || (LA31_0 >= 55 && LA31_0 <= 94)) )
                    		{
                    		    alt31 = 1;
                    		}
                    		switch (alt31) 
                    		{
                    		    case 1 :
                    		        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:244:37: tikzbody2
                    		        {
                    		        	PushFollow(FOLLOW_tikzbody2_in_tikzpicture1056);
                    		        	tikzbody290 = tikzbody2();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_tikzbody2.Add(tikzbody290.Tree);

                    		        }
                    		        break;

                    		}

                    		PushFollow(FOLLOW_roundbr_end_in_tikzpicture1059);
                    		roundbr_end91 = roundbr_end();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_roundbr_end.Add(roundbr_end91.Tree);

                    	}



                    	// AST REWRITE
                    	// elements:          roundbr_end, tikzbody2, tikz_start, tikz_options
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 244:63: -> ^( IM_PICTURE tikz_start ( tikz_options )? ( tikzbody2 )? roundbr_end )
                    	{
                    	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:244:66: ^( IM_PICTURE tikz_start ( tikz_options )? ( tikzbody2 )? roundbr_end )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PICTURE, "IM_PICTURE"), root_1);

                    	    adaptor.AddChild(root_1, stream_tikz_start.NextTree());
                    	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:244:90: ( tikz_options )?
                    	    if ( stream_tikz_options.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_tikz_options.NextTree());

                    	    }
                    	    stream_tikz_options.Reset();
                    	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:244:104: ( tikzbody2 )?
                    	    if ( stream_tikzbody2.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_tikzbody2.NextTree());

                    	    }
                    	    stream_tikzbody2.Reset();
                    	    adaptor.AddChild(root_1, stream_roundbr_end.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:247:1: tikzbody : ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )* ;
    public simpletikzParser.tikzbody_return tikzbody() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzbody_return retval = new simpletikzParser.tikzbody_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_return tikzscope92 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath93 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznode_ext_return tikznode_ext94 = default(simpletikzParser.tikznode_ext_return);

        simpletikzParser.tikzdef_ext_return tikzdef_ext95 = default(simpletikzParser.tikzdef_ext_return);

        simpletikzParser.tikzmatrix_ext_return tikzmatrix_ext96 = default(simpletikzParser.tikzmatrix_ext_return);

        simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext97 = default(simpletikzParser.tikzcoordinate_ext_return);

        simpletikzParser.tikz_set_return tikz_set98 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style99 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin100 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend101 = default(simpletikzParser.otherend_return);

        simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr102 = default(simpletikzParser.dontcare_body_nobr_return);

        simpletikzParser.tikzscope_return tikzscope103 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath104 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznode_ext_return tikznode_ext105 = default(simpletikzParser.tikznode_ext_return);

        simpletikzParser.tikzdef_ext_return tikzdef_ext106 = default(simpletikzParser.tikzdef_ext_return);

        simpletikzParser.tikzmatrix_ext_return tikzmatrix_ext107 = default(simpletikzParser.tikzmatrix_ext_return);

        simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext108 = default(simpletikzParser.tikzcoordinate_ext_return);

        simpletikzParser.tikz_set_return tikz_set109 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style110 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin111 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend112 = default(simpletikzParser.otherend_return);

        simpletikzParser.dontcare_body_return dontcare_body113 = default(simpletikzParser.dontcare_body_return);



        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:248:2: ( ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )* )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:248:4: ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:248:4: ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr )
            	int alt33 = 11;
            	alt33 = dfa33.Predict(input);
            	switch (alt33) 
            	{
            	    case 1 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:248:6: tikzscope
            	        {
            	        	PushFollow(FOLLOW_tikzscope_in_tikzbody1091);
            	        	tikzscope92 = tikzscope();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzscope92.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:248:18: tikzpath
            	        {
            	        	PushFollow(FOLLOW_tikzpath_in_tikzbody1095);
            	        	tikzpath93 = tikzpath();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath93.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:248:29: tikznode_ext
            	        {
            	        	PushFollow(FOLLOW_tikznode_ext_in_tikzbody1099);
            	        	tikznode_ext94 = tikznode_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_ext94.Tree);

            	        }
            	        break;
            	    case 4 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:248:44: tikzdef_ext
            	        {
            	        	PushFollow(FOLLOW_tikzdef_ext_in_tikzbody1103);
            	        	tikzdef_ext95 = tikzdef_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzdef_ext95.Tree);

            	        }
            	        break;
            	    case 5 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:248:58: tikzmatrix_ext
            	        {
            	        	PushFollow(FOLLOW_tikzmatrix_ext_in_tikzbody1107);
            	        	tikzmatrix_ext96 = tikzmatrix_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzmatrix_ext96.Tree);

            	        }
            	        break;
            	    case 6 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:248:75: tikzcoordinate_ext
            	        {
            	        	PushFollow(FOLLOW_tikzcoordinate_ext_in_tikzbody1111);
            	        	tikzcoordinate_ext97 = tikzcoordinate_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_ext97.Tree);

            	        }
            	        break;
            	    case 7 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:248:96: tikz_set
            	        {
            	        	PushFollow(FOLLOW_tikz_set_in_tikzbody1115);
            	        	tikz_set98 = tikz_set();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set98.Tree);

            	        }
            	        break;
            	    case 8 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:248:107: tikz_style
            	        {
            	        	PushFollow(FOLLOW_tikz_style_in_tikzbody1119);
            	        	tikz_style99 = tikz_style();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style99.Tree);

            	        }
            	        break;
            	    case 9 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:248:120: otherbegin
            	        {
            	        	PushFollow(FOLLOW_otherbegin_in_tikzbody1123);
            	        	otherbegin100 = otherbegin();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;
            	    case 10 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:248:134: otherend
            	        {
            	        	PushFollow(FOLLOW_otherend_in_tikzbody1128);
            	        	otherend101 = otherend();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;
            	    case 11 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:248:146: dontcare_body_nobr
            	        {
            	        	PushFollow(FOLLOW_dontcare_body_nobr_in_tikzbody1133);
            	        	dontcare_body_nobr102 = dontcare_body_nobr();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;

            	}

            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:249:3: ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*
            	do 
            	{
            	    int alt34 = 12;
            	    alt34 = dfa34.Predict(input);
            	    switch (alt34) 
            		{
            			case 1 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:249:5: tikzscope
            			    {
            			    	PushFollow(FOLLOW_tikzscope_in_tikzbody1144);
            			    	tikzscope103 = tikzscope();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzscope103.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:249:17: tikzpath
            			    {
            			    	PushFollow(FOLLOW_tikzpath_in_tikzbody1148);
            			    	tikzpath104 = tikzpath();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath104.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:249:28: tikznode_ext
            			    {
            			    	PushFollow(FOLLOW_tikznode_ext_in_tikzbody1152);
            			    	tikznode_ext105 = tikznode_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_ext105.Tree);

            			    }
            			    break;
            			case 4 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:249:43: tikzdef_ext
            			    {
            			    	PushFollow(FOLLOW_tikzdef_ext_in_tikzbody1156);
            			    	tikzdef_ext106 = tikzdef_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzdef_ext106.Tree);

            			    }
            			    break;
            			case 5 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:249:57: tikzmatrix_ext
            			    {
            			    	PushFollow(FOLLOW_tikzmatrix_ext_in_tikzbody1160);
            			    	tikzmatrix_ext107 = tikzmatrix_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzmatrix_ext107.Tree);

            			    }
            			    break;
            			case 6 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:249:74: tikzcoordinate_ext
            			    {
            			    	PushFollow(FOLLOW_tikzcoordinate_ext_in_tikzbody1164);
            			    	tikzcoordinate_ext108 = tikzcoordinate_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_ext108.Tree);

            			    }
            			    break;
            			case 7 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:249:95: tikz_set
            			    {
            			    	PushFollow(FOLLOW_tikz_set_in_tikzbody1168);
            			    	tikz_set109 = tikz_set();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set109.Tree);

            			    }
            			    break;
            			case 8 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:249:106: tikz_style
            			    {
            			    	PushFollow(FOLLOW_tikz_style_in_tikzbody1172);
            			    	tikz_style110 = tikz_style();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style110.Tree);

            			    }
            			    break;
            			case 9 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:249:119: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzbody1176);
            			    	otherbegin111 = otherbegin();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;
            			case 10 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:249:133: otherend
            			    {
            			    	PushFollow(FOLLOW_otherend_in_tikzbody1181);
            			    	otherend112 = otherend();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;
            			case 11 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:249:145: dontcare_body
            			    {
            			    	PushFollow(FOLLOW_dontcare_body_in_tikzbody1186);
            			    	dontcare_body113 = dontcare_body();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop34;
            	    }
            	} while (true);

            	loop34:
            		;	// Stops C# compiler whining that label 'loop34' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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

    public class tikzbody2_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikzbody2"
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:251:1: tikzbody2 : ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr2 ) ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body2 )* ;
    public simpletikzParser.tikzbody2_return tikzbody2() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzbody2_return retval = new simpletikzParser.tikzbody2_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_return tikzscope114 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath115 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznode_ext_return tikznode_ext116 = default(simpletikzParser.tikznode_ext_return);

        simpletikzParser.tikzdef_ext_return tikzdef_ext117 = default(simpletikzParser.tikzdef_ext_return);

        simpletikzParser.tikzmatrix_ext_return tikzmatrix_ext118 = default(simpletikzParser.tikzmatrix_ext_return);

        simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext119 = default(simpletikzParser.tikzcoordinate_ext_return);

        simpletikzParser.tikz_set_return tikz_set120 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style121 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin122 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend123 = default(simpletikzParser.otherend_return);

        simpletikzParser.dontcare_body_nobr2_return dontcare_body_nobr2124 = default(simpletikzParser.dontcare_body_nobr2_return);

        simpletikzParser.tikzscope_return tikzscope125 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath126 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznode_ext_return tikznode_ext127 = default(simpletikzParser.tikznode_ext_return);

        simpletikzParser.tikzdef_ext_return tikzdef_ext128 = default(simpletikzParser.tikzdef_ext_return);

        simpletikzParser.tikzmatrix_ext_return tikzmatrix_ext129 = default(simpletikzParser.tikzmatrix_ext_return);

        simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext130 = default(simpletikzParser.tikzcoordinate_ext_return);

        simpletikzParser.tikz_set_return tikz_set131 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style132 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin133 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend134 = default(simpletikzParser.otherend_return);

        simpletikzParser.dontcare_body2_return dontcare_body2135 = default(simpletikzParser.dontcare_body2_return);



        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:252:2: ( ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr2 ) ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body2 )* )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:252:4: ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr2 ) ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body2 )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:252:4: ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr2 )
            	int alt35 = 11;
            	alt35 = dfa35.Predict(input);
            	switch (alt35) 
            	{
            	    case 1 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:252:6: tikzscope
            	        {
            	        	PushFollow(FOLLOW_tikzscope_in_tikzbody21202);
            	        	tikzscope114 = tikzscope();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzscope114.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:252:18: tikzpath
            	        {
            	        	PushFollow(FOLLOW_tikzpath_in_tikzbody21206);
            	        	tikzpath115 = tikzpath();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath115.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:252:29: tikznode_ext
            	        {
            	        	PushFollow(FOLLOW_tikznode_ext_in_tikzbody21210);
            	        	tikznode_ext116 = tikznode_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_ext116.Tree);

            	        }
            	        break;
            	    case 4 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:252:44: tikzdef_ext
            	        {
            	        	PushFollow(FOLLOW_tikzdef_ext_in_tikzbody21214);
            	        	tikzdef_ext117 = tikzdef_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzdef_ext117.Tree);

            	        }
            	        break;
            	    case 5 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:252:58: tikzmatrix_ext
            	        {
            	        	PushFollow(FOLLOW_tikzmatrix_ext_in_tikzbody21218);
            	        	tikzmatrix_ext118 = tikzmatrix_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzmatrix_ext118.Tree);

            	        }
            	        break;
            	    case 6 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:252:75: tikzcoordinate_ext
            	        {
            	        	PushFollow(FOLLOW_tikzcoordinate_ext_in_tikzbody21222);
            	        	tikzcoordinate_ext119 = tikzcoordinate_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_ext119.Tree);

            	        }
            	        break;
            	    case 7 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:252:96: tikz_set
            	        {
            	        	PushFollow(FOLLOW_tikz_set_in_tikzbody21226);
            	        	tikz_set120 = tikz_set();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set120.Tree);

            	        }
            	        break;
            	    case 8 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:252:107: tikz_style
            	        {
            	        	PushFollow(FOLLOW_tikz_style_in_tikzbody21230);
            	        	tikz_style121 = tikz_style();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style121.Tree);

            	        }
            	        break;
            	    case 9 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:252:120: otherbegin
            	        {
            	        	PushFollow(FOLLOW_otherbegin_in_tikzbody21234);
            	        	otherbegin122 = otherbegin();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;
            	    case 10 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:252:134: otherend
            	        {
            	        	PushFollow(FOLLOW_otherend_in_tikzbody21239);
            	        	otherend123 = otherend();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;
            	    case 11 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:252:146: dontcare_body_nobr2
            	        {
            	        	PushFollow(FOLLOW_dontcare_body_nobr2_in_tikzbody21244);
            	        	dontcare_body_nobr2124 = dontcare_body_nobr2();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;

            	}

            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:253:3: ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body2 )*
            	do 
            	{
            	    int alt36 = 12;
            	    alt36 = dfa36.Predict(input);
            	    switch (alt36) 
            		{
            			case 1 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:253:5: tikzscope
            			    {
            			    	PushFollow(FOLLOW_tikzscope_in_tikzbody21255);
            			    	tikzscope125 = tikzscope();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzscope125.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:253:17: tikzpath
            			    {
            			    	PushFollow(FOLLOW_tikzpath_in_tikzbody21259);
            			    	tikzpath126 = tikzpath();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath126.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:253:28: tikznode_ext
            			    {
            			    	PushFollow(FOLLOW_tikznode_ext_in_tikzbody21263);
            			    	tikznode_ext127 = tikznode_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_ext127.Tree);

            			    }
            			    break;
            			case 4 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:253:43: tikzdef_ext
            			    {
            			    	PushFollow(FOLLOW_tikzdef_ext_in_tikzbody21267);
            			    	tikzdef_ext128 = tikzdef_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzdef_ext128.Tree);

            			    }
            			    break;
            			case 5 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:253:57: tikzmatrix_ext
            			    {
            			    	PushFollow(FOLLOW_tikzmatrix_ext_in_tikzbody21271);
            			    	tikzmatrix_ext129 = tikzmatrix_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzmatrix_ext129.Tree);

            			    }
            			    break;
            			case 6 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:253:74: tikzcoordinate_ext
            			    {
            			    	PushFollow(FOLLOW_tikzcoordinate_ext_in_tikzbody21275);
            			    	tikzcoordinate_ext130 = tikzcoordinate_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_ext130.Tree);

            			    }
            			    break;
            			case 7 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:253:95: tikz_set
            			    {
            			    	PushFollow(FOLLOW_tikz_set_in_tikzbody21279);
            			    	tikz_set131 = tikz_set();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set131.Tree);

            			    }
            			    break;
            			case 8 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:253:106: tikz_style
            			    {
            			    	PushFollow(FOLLOW_tikz_style_in_tikzbody21283);
            			    	tikz_style132 = tikz_style();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style132.Tree);

            			    }
            			    break;
            			case 9 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:253:119: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzbody21287);
            			    	otherbegin133 = otherbegin();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;
            			case 10 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:253:133: otherend
            			    {
            			    	PushFollow(FOLLOW_otherend_in_tikzbody21292);
            			    	otherend134 = otherend();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;
            			case 11 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:253:145: dontcare_body2
            			    {
            			    	PushFollow(FOLLOW_dontcare_body2_in_tikzbody21297);
            			    	dontcare_body2135 = dontcare_body2();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop36;
            	    }
            	} while (true);

            	loop36:
            		;	// Stops C# compiler whining that label 'loop36' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // $ANTLR end "tikzbody2"

    public class dontcare_body_nobr2_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "dontcare_body_nobr2"
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:256:1: dontcare_body_nobr2 : (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' | '{' | '}' ) ) ;
    public simpletikzParser.dontcare_body_nobr2_return dontcare_body_nobr2() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body_nobr2_return retval = new simpletikzParser.dontcare_body_nobr2_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set136 = null;

        object set136_tree=null;

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:257:2: ( (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' | '{' | '}' ) ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:257:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' | '{' | '}' ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:257:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' | '{' | '}' ) )
            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:257:5: ~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' | '{' | '}' )
            	{
            		set136 = (IToken)input.LT(1);
            		if ( (input.LA(1) >= IM_PATH && input.LA(1) <= SOMETHING1) || input.LA(1) == 42 || (input.LA(1) >= 45 && input.LA(1) <= 53) || (input.LA(1) >= 55 && input.LA(1) <= 62) || (input.LA(1) >= 77 && input.LA(1) <= 94) ) 
            		{
            		    input.Consume();
            		    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set136));
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

            if ( state.backtracking==0 )
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
    // $ANTLR end "dontcare_body_nobr2"

    public class dontcare_body2_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "dontcare_body2"
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:259:1: dontcare_body2 : (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '{' | '}' ) ) ;
    public simpletikzParser.dontcare_body2_return dontcare_body2() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body2_return retval = new simpletikzParser.dontcare_body2_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set137 = null;

        object set137_tree=null;

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:260:2: ( (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '{' | '}' ) ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:260:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '{' | '}' ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:260:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '{' | '}' ) )
            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:260:5: ~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '{' | '}' )
            	{
            		set137 = (IToken)input.LT(1);
            		if ( (input.LA(1) >= IM_PATH && input.LA(1) <= SOMETHING1) || input.LA(1) == 42 || (input.LA(1) >= 45 && input.LA(1) <= 62) || (input.LA(1) >= 77 && input.LA(1) <= 94) ) 
            		{
            		    input.Consume();
            		    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set137));
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

            if ( state.backtracking==0 )
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
    // $ANTLR end "dontcare_body2"

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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:262:1: dontcare_body_nobr : (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) ) ;
    public simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body_nobr_return retval = new simpletikzParser.dontcare_body_nobr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set138 = null;

        object set138_tree=null;

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:263:2: ( (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:263:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:263:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) )
            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:263:5: ~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' )
            	{
            		set138 = (IToken)input.LT(1);
            		if ( (input.LA(1) >= IM_PATH && input.LA(1) <= SOMETHING1) || (input.LA(1) >= 42 && input.LA(1) <= 53) || (input.LA(1) >= 55 && input.LA(1) <= 62) || (input.LA(1) >= 77 && input.LA(1) <= 94) ) 
            		{
            		    input.Consume();
            		    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set138));
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

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:265:1: dontcare_body : (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) ) ;
    public simpletikzParser.dontcare_body_return dontcare_body() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body_return retval = new simpletikzParser.dontcare_body_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set139 = null;

        object set139_tree=null;

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:266:2: ( (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:266:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:266:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) )
            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:266:5: ~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' )
            	{
            		set139 = (IToken)input.LT(1);
            		if ( (input.LA(1) >= IM_PATH && input.LA(1) <= SOMETHING1) || (input.LA(1) >= 42 && input.LA(1) <= 62) || (input.LA(1) >= 77 && input.LA(1) <= 94) ) 
            		{
            		    input.Consume();
            		    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set139));
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

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:268:1: otherend : '\\\\end' '{' idd2 '}' ;
    public simpletikzParser.otherend_return otherend() // throws RecognitionException [1]
    {   
        simpletikzParser.otherend_return retval = new simpletikzParser.otherend_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal140 = null;
        IToken char_literal141 = null;
        IToken char_literal143 = null;
        simpletikzParser.idd2_return idd2142 = default(simpletikzParser.idd2_return);


        object string_literal140_tree=null;
        object char_literal141_tree=null;
        object char_literal143_tree=null;

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:269:2: ( '\\\\end' '{' idd2 '}' )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:269:4: '\\\\end' '{' idd2 '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal140=(IToken)Match(input,63,FOLLOW_63_in_otherend1668); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal140_tree = (object)adaptor.Create(string_literal140);
            		adaptor.AddChild(root_0, string_literal140_tree);
            	}
            	char_literal141=(IToken)Match(input,43,FOLLOW_43_in_otherend1670); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal141_tree = (object)adaptor.Create(char_literal141);
            		adaptor.AddChild(root_0, char_literal141_tree);
            	}
            	PushFollow(FOLLOW_idd2_in_otherend1672);
            	idd2142 = idd2();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idd2142.Tree);
            	char_literal143=(IToken)Match(input,44,FOLLOW_44_in_otherend1674); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal143_tree = (object)adaptor.Create(char_literal143);
            		adaptor.AddChild(root_0, char_literal143_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:283:1: tikzscope : tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end ) ;
    public simpletikzParser.tikzscope_return tikzscope() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_return retval = new simpletikzParser.tikzscope_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_start_return tikzscope_start144 = default(simpletikzParser.tikzscope_start_return);

        simpletikzParser.tikz_options_return tikz_options145 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody_return tikzbody146 = default(simpletikzParser.tikzbody_return);

        simpletikzParser.tikzscope_end_return tikzscope_end147 = default(simpletikzParser.tikzscope_end_return);


        RewriteRuleSubtreeStream stream_tikzscope_start = new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_start");
        RewriteRuleSubtreeStream stream_tikzscope_end = new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_end");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:284:2: ( tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:284:4: tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end
            {
            	PushFollow(FOLLOW_tikzscope_start_in_tikzscope1701);
            	tikzscope_start144 = tikzscope_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikzscope_start.Add(tikzscope_start144.Tree);
            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:284:20: ( tikz_options )?
            	int alt37 = 2;
            	int LA37_0 = input.LA(1);

            	if ( (LA37_0 == 54) )
            	{
            	    alt37 = 1;
            	}
            	switch (alt37) 
            	{
            	    case 1 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:284:20: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_tikzscope1703);
            	        	tikz_options145 = tikz_options();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_tikz_options.Add(tikz_options145.Tree);

            	        }
            	        break;

            	}

            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:284:34: ( tikzbody )?
            	int alt38 = 2;
            	int LA38_0 = input.LA(1);

            	if ( ((LA38_0 >= IM_PATH && LA38_0 <= 53) || (LA38_0 >= 55 && LA38_0 <= 62) || (LA38_0 >= 64 && LA38_0 <= 94)) )
            	{
            	    alt38 = 1;
            	}
            	else if ( (LA38_0 == 63) )
            	{
            	    int LA38_2 = input.LA(2);

            	    if ( (LA38_2 == 43) )
            	    {
            	        int LA38_3 = input.LA(3);

            	        if ( (LA38_3 == ID) )
            	        {
            	            alt38 = 1;
            	        }
            	    }
            	}
            	switch (alt38) 
            	{
            	    case 1 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:284:34: tikzbody
            	        {
            	        	PushFollow(FOLLOW_tikzbody_in_tikzscope1706);
            	        	tikzbody146 = tikzbody();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_tikzbody.Add(tikzbody146.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzscope_end_in_tikzscope1709);
            	tikzscope_end147 = tikzscope_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikzscope_end.Add(tikzscope_end147.Tree);


            	// AST REWRITE
            	// elements:          tikzscope_start, tikzbody, tikz_options, tikzscope_end
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 284:59: -> ^( IM_SCOPE tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:284:62: ^( IM_SCOPE tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_SCOPE, "IM_SCOPE"), root_1);

            	    adaptor.AddChild(root_1, stream_tikzscope_start.NextTree());
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:284:89: ( tikz_options )?
            	    if ( stream_tikz_options.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikz_options.NextTree());

            	    }
            	    stream_tikz_options.Reset();
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:284:103: ( tikzbody )?
            	    if ( stream_tikzbody.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzbody.NextTree());

            	    }
            	    stream_tikzbody.Reset();
            	    adaptor.AddChild(root_1, stream_tikzscope_end.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:310:1: tikzpath : path_start ( tikzpath_element )* semicolon_end -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikzpath_return tikzpath() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_return retval = new simpletikzParser.tikzpath_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.path_start_return path_start148 = default(simpletikzParser.path_start_return);

        simpletikzParser.tikzpath_element_return tikzpath_element149 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end150 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_path_start = new RewriteRuleSubtreeStream(adaptor,"rule path_start");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:311:2: ( path_start ( tikzpath_element )* semicolon_end -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:311:4: path_start ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_path_start_in_tikzpath1765);
            	path_start148 = path_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_path_start.Add(path_start148.Tree);
            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:311:15: ( tikzpath_element )*
            	do 
            	{
            	    int alt39 = 2;
            	    int LA39_0 = input.LA(1);

            	    if ( ((LA39_0 >= ID && LA39_0 <= COMMAND) || LA39_0 == 43 || LA39_0 == 45 || LA39_0 == 52 || LA39_0 == 54 || LA39_0 == 58 || LA39_0 == 77 || (LA39_0 >= 79 && LA39_0 <= 80) || (LA39_0 >= 82 && LA39_0 <= 91)) )
            	    {
            	        alt39 = 1;
            	    }


            	    switch (alt39) 
            		{
            			case 1 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:311:15: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath1767);
            			    	tikzpath_element149 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikzpath_element.Add(tikzpath_element149.Tree);

            			    }
            			    break;

            			default:
            			    goto loop39;
            	    }
            	} while (true);

            	loop39:
            		;	// Stops C# compiler whining that label 'loop39' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikzpath1770);
            	semicolon_end150 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_semicolon_end.Add(semicolon_end150.Tree);


            	// AST REWRITE
            	// elements:          path_start, semicolon_end, tikzpath_element
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 311:47: -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:311:50: ^( IM_PATH path_start ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_path_start.NextTree());
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:311:71: ( tikzpath_element )*
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

            if ( state.backtracking==0 )
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

    public class let_cmd_parts_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "let_cmd_parts"
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:316:1: let_cmd_parts : ( 'let' | 'in' | '=' | COMMAND );
    public simpletikzParser.let_cmd_parts_return let_cmd_parts() // throws RecognitionException [1]
    {   
        simpletikzParser.let_cmd_parts_return retval = new simpletikzParser.let_cmd_parts_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set151 = null;

        object set151_tree=null;

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:317:2: ( 'let' | 'in' | '=' | COMMAND )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set151 = (IToken)input.LT(1);
            	if ( input.LA(1) == COMMAND || input.LA(1) == 45 || input.LA(1) == 58 || input.LA(1) == 77 ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set151));
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

            if ( state.backtracking==0 )
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
    // $ANTLR end "let_cmd_parts"

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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:321:1: tikzpath_element : tikzpath_element_single ( ',' )? ;
    public simpletikzParser.tikzpath_element_return tikzpath_element() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_element_return retval = new simpletikzParser.tikzpath_element_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal153 = null;
        simpletikzParser.tikzpath_element_single_return tikzpath_element_single152 = default(simpletikzParser.tikzpath_element_single_return);


        object char_literal153_tree=null;

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:322:2: ( tikzpath_element_single ( ',' )? )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:322:4: tikzpath_element_single ( ',' )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_tikzpath_element_single_in_tikzpath_element1826);
            	tikzpath_element_single152 = tikzpath_element_single();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath_element_single152.Tree);
            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:322:31: ( ',' )?
            	int alt40 = 2;
            	int LA40_0 = input.LA(1);

            	if ( (LA40_0 == 47) )
            	{
            	    alt40 = 1;
            	}
            	switch (alt40) 
            	{
            	    case 1 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:322:31: ','
            	        {
            	        	char_literal153=(IToken)Match(input,47,FOLLOW_47_in_tikzpath_element1828); if (state.failed) return retval;

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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

    public class tikzpath_element_single_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikzpath_element_single"
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:325:1: tikzpath_element_single : ( tikz_options | let_cmd_parts -> ^( IM_DONTCARE ( let_cmd_parts )+ ) | arc | ( coord )=> coord | controls | tikznode_int | tikzcoordinate_int | circle | roundbr_start ( tikzpath_element )* roundbr_end -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end ) | '(' ( tikzpath_element )* ')' -> ^( IM_PATH '(' ( tikzpath_element )* ')' ) | edgeop );
    public simpletikzParser.tikzpath_element_single_return tikzpath_element_single() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_element_single_return retval = new simpletikzParser.tikzpath_element_single_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal165 = null;
        IToken char_literal167 = null;
        simpletikzParser.tikz_options_return tikz_options154 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.let_cmd_parts_return let_cmd_parts155 = default(simpletikzParser.let_cmd_parts_return);

        simpletikzParser.arc_return arc156 = default(simpletikzParser.arc_return);

        simpletikzParser.coord_return coord157 = default(simpletikzParser.coord_return);

        simpletikzParser.controls_return controls158 = default(simpletikzParser.controls_return);

        simpletikzParser.tikznode_int_return tikznode_int159 = default(simpletikzParser.tikznode_int_return);

        simpletikzParser.tikzcoordinate_int_return tikzcoordinate_int160 = default(simpletikzParser.tikzcoordinate_int_return);

        simpletikzParser.circle_return circle161 = default(simpletikzParser.circle_return);

        simpletikzParser.roundbr_start_return roundbr_start162 = default(simpletikzParser.roundbr_start_return);

        simpletikzParser.tikzpath_element_return tikzpath_element163 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.roundbr_end_return roundbr_end164 = default(simpletikzParser.roundbr_end_return);

        simpletikzParser.tikzpath_element_return tikzpath_element166 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.edgeop_return edgeop168 = default(simpletikzParser.edgeop_return);


        object char_literal165_tree=null;
        object char_literal167_tree=null;
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_roundbr_start = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_start");
        RewriteRuleSubtreeStream stream_roundbr_end = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        RewriteRuleSubtreeStream stream_let_cmd_parts = new RewriteRuleSubtreeStream(adaptor,"rule let_cmd_parts");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:326:2: ( tikz_options | let_cmd_parts -> ^( IM_DONTCARE ( let_cmd_parts )+ ) | arc | ( coord )=> coord | controls | tikznode_int | tikzcoordinate_int | circle | roundbr_start ( tikzpath_element )* roundbr_end -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end ) | '(' ( tikzpath_element )* ')' -> ^( IM_PATH '(' ( tikzpath_element )* ')' ) | edgeop )
            int alt43 = 11;
            alt43 = dfa43.Predict(input);
            switch (alt43) 
            {
                case 1 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:327:5: tikz_options
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_options_in_tikzpath_element_single1846);
                    	tikz_options154 = tikz_options();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_options154.Tree);

                    }
                    break;
                case 2 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:328:5: let_cmd_parts
                    {
                    	PushFollow(FOLLOW_let_cmd_parts_in_tikzpath_element_single1853);
                    	let_cmd_parts155 = let_cmd_parts();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_let_cmd_parts.Add(let_cmd_parts155.Tree);


                    	// AST REWRITE
                    	// elements:          let_cmd_parts
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 328:19: -> ^( IM_DONTCARE ( let_cmd_parts )+ )
                    	{
                    	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:328:22: ^( IM_DONTCARE ( let_cmd_parts )+ )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DONTCARE, "IM_DONTCARE"), root_1);

                    	    if ( !(stream_let_cmd_parts.HasNext()) ) {
                    	        throw new RewriteEarlyExitException();
                    	    }
                    	    while ( stream_let_cmd_parts.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_let_cmd_parts.NextTree());

                    	    }
                    	    stream_let_cmd_parts.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:330:5: arc
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arc_in_tikzpath_element_single1871);
                    	arc156 = arc();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arc156.Tree);

                    }
                    break;
                case 4 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:331:5: ( coord )=> coord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_coord_in_tikzpath_element_single1881);
                    	coord157 = coord();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, coord157.Tree);

                    }
                    break;
                case 5 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:332:5: controls
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_controls_in_tikzpath_element_single1887);
                    	controls158 = controls();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, controls158.Tree);

                    }
                    break;
                case 6 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:333:5: tikznode_int
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikznode_int_in_tikzpath_element_single1893);
                    	tikznode_int159 = tikznode_int();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_int159.Tree);

                    }
                    break;
                case 7 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:334:5: tikzcoordinate_int
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikzcoordinate_int_in_tikzpath_element_single1899);
                    	tikzcoordinate_int160 = tikzcoordinate_int();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_int160.Tree);

                    }
                    break;
                case 8 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:335:5: circle
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_circle_in_tikzpath_element_single1905);
                    	circle161 = circle();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;

                    }
                    break;
                case 9 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:336:5: roundbr_start ( tikzpath_element )* roundbr_end
                    {
                    	PushFollow(FOLLOW_roundbr_start_in_tikzpath_element_single1912);
                    	roundbr_start162 = roundbr_start();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_roundbr_start.Add(roundbr_start162.Tree);
                    	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:336:19: ( tikzpath_element )*
                    	do 
                    	{
                    	    int alt41 = 2;
                    	    int LA41_0 = input.LA(1);

                    	    if ( ((LA41_0 >= ID && LA41_0 <= COMMAND) || LA41_0 == 43 || LA41_0 == 45 || LA41_0 == 52 || LA41_0 == 54 || LA41_0 == 58 || LA41_0 == 77 || (LA41_0 >= 79 && LA41_0 <= 80) || (LA41_0 >= 82 && LA41_0 <= 91)) )
                    	    {
                    	        alt41 = 1;
                    	    }


                    	    switch (alt41) 
                    		{
                    			case 1 :
                    			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:336:19: tikzpath_element
                    			    {
                    			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath_element_single1914);
                    			    	tikzpath_element163 = tikzpath_element();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking==0 ) stream_tikzpath_element.Add(tikzpath_element163.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop41;
                    	    }
                    	} while (true);

                    	loop41:
                    		;	// Stops C# compiler whining that label 'loop41' has no statements

                    	PushFollow(FOLLOW_roundbr_end_in_tikzpath_element_single1917);
                    	roundbr_end164 = roundbr_end();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_roundbr_end.Add(roundbr_end164.Tree);


                    	// AST REWRITE
                    	// elements:          roundbr_end, tikzpath_element, roundbr_start
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 336:49: -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end )
                    	{
                    	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:336:52: ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

                    	    adaptor.AddChild(root_1, stream_roundbr_start.NextTree());
                    	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:336:76: ( tikzpath_element )*
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
                case 10 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:337:6: '(' ( tikzpath_element )* ')'
                    {
                    	char_literal165=(IToken)Match(input,52,FOLLOW_52_in_tikzpath_element_single1937); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_52.Add(char_literal165);

                    	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:337:10: ( tikzpath_element )*
                    	do 
                    	{
                    	    int alt42 = 2;
                    	    int LA42_0 = input.LA(1);

                    	    if ( ((LA42_0 >= ID && LA42_0 <= COMMAND) || LA42_0 == 43 || LA42_0 == 45 || LA42_0 == 52 || LA42_0 == 54 || LA42_0 == 58 || LA42_0 == 77 || (LA42_0 >= 79 && LA42_0 <= 80) || (LA42_0 >= 82 && LA42_0 <= 91)) )
                    	    {
                    	        alt42 = 1;
                    	    }


                    	    switch (alt42) 
                    		{
                    			case 1 :
                    			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:337:10: tikzpath_element
                    			    {
                    			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath_element_single1939);
                    			    	tikzpath_element166 = tikzpath_element();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking==0 ) stream_tikzpath_element.Add(tikzpath_element166.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop42;
                    	    }
                    	} while (true);

                    	loop42:
                    		;	// Stops C# compiler whining that label 'loop42' has no statements

                    	char_literal167=(IToken)Match(input,53,FOLLOW_53_in_tikzpath_element_single1942); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_53.Add(char_literal167);



                    	// AST REWRITE
                    	// elements:          53, tikzpath_element, 52
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 337:32: -> ^( IM_PATH '(' ( tikzpath_element )* ')' )
                    	{
                    	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:337:35: ^( IM_PATH '(' ( tikzpath_element )* ')' )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

                    	    adaptor.AddChild(root_1, stream_52.NextNode());
                    	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:337:49: ( tikzpath_element )*
                    	    while ( stream_tikzpath_element.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_tikzpath_element.NextTree());

                    	    }
                    	    stream_tikzpath_element.Reset();
                    	    adaptor.AddChild(root_1, stream_53.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 11 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:338:5: edgeop
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_edgeop_in_tikzpath_element_single1961);
                    	edgeop168 = edgeop();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // $ANTLR end "tikzpath_element_single"

    public class controls_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "controls"
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:341:1: controls : controls_start coord ( 'and' coord )? controls_end -> ^( IM_CONTROLS controls_start ( coord )+ controls_end ) ;
    public simpletikzParser.controls_return controls() // throws RecognitionException [1]
    {   
        simpletikzParser.controls_return retval = new simpletikzParser.controls_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal171 = null;
        simpletikzParser.controls_start_return controls_start169 = default(simpletikzParser.controls_start_return);

        simpletikzParser.coord_return coord170 = default(simpletikzParser.coord_return);

        simpletikzParser.coord_return coord172 = default(simpletikzParser.coord_return);

        simpletikzParser.controls_end_return controls_end173 = default(simpletikzParser.controls_end_return);


        object string_literal171_tree=null;
        RewriteRuleTokenStream stream_78 = new RewriteRuleTokenStream(adaptor,"token 78");
        RewriteRuleSubtreeStream stream_coord = new RewriteRuleSubtreeStream(adaptor,"rule coord");
        RewriteRuleSubtreeStream stream_controls_start = new RewriteRuleSubtreeStream(adaptor,"rule controls_start");
        RewriteRuleSubtreeStream stream_controls_end = new RewriteRuleSubtreeStream(adaptor,"rule controls_end");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:342:2: ( controls_start coord ( 'and' coord )? controls_end -> ^( IM_CONTROLS controls_start ( coord )+ controls_end ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:342:4: controls_start coord ( 'and' coord )? controls_end
            {
            	PushFollow(FOLLOW_controls_start_in_controls1976);
            	controls_start169 = controls_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_controls_start.Add(controls_start169.Tree);
            	PushFollow(FOLLOW_coord_in_controls1978);
            	coord170 = coord();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_coord.Add(coord170.Tree);
            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:342:25: ( 'and' coord )?
            	int alt44 = 2;
            	int LA44_0 = input.LA(1);

            	if ( (LA44_0 == 78) )
            	{
            	    alt44 = 1;
            	}
            	switch (alt44) 
            	{
            	    case 1 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:342:26: 'and' coord
            	        {
            	        	string_literal171=(IToken)Match(input,78,FOLLOW_78_in_controls1981); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_78.Add(string_literal171);

            	        	PushFollow(FOLLOW_coord_in_controls1983);
            	        	coord172 = coord();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_coord.Add(coord172.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_controls_end_in_controls1987);
            	controls_end173 = controls_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_controls_end.Add(controls_end173.Tree);


            	// AST REWRITE
            	// elements:          coord, controls_start, controls_end
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 342:53: -> ^( IM_CONTROLS controls_start ( coord )+ controls_end )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:342:56: ^( IM_CONTROLS controls_start ( coord )+ controls_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_CONTROLS, "IM_CONTROLS"), root_1);

            	    adaptor.AddChild(root_1, stream_controls_start.NextTree());
            	    if ( !(stream_coord.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_coord.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_coord.NextTree());

            	    }
            	    stream_coord.Reset();
            	    adaptor.AddChild(root_1, stream_controls_end.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // $ANTLR end "controls"

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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:345:1: tikznode_ext : node_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikznode_ext_return tikznode_ext() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_ext_return retval = new simpletikzParser.tikznode_ext_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.node_start_return node_start174 = default(simpletikzParser.node_start_return);

        simpletikzParser.tikznode_core_return tikznode_core175 = default(simpletikzParser.tikznode_core_return);

        simpletikzParser.tikzpath_element_return tikzpath_element176 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end177 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_node_start = new RewriteRuleSubtreeStream(adaptor,"rule node_start");
        RewriteRuleSubtreeStream stream_tikznode_core = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_core");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:346:2: ( node_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:346:4: node_start tikznode_core ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_node_start_in_tikznode_ext2013);
            	node_start174 = node_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_node_start.Add(node_start174.Tree);
            	PushFollow(FOLLOW_tikznode_core_in_tikznode_ext2015);
            	tikznode_core175 = tikznode_core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_core.Add(tikznode_core175.Tree);
            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:346:29: ( tikzpath_element )*
            	do 
            	{
            	    int alt45 = 2;
            	    int LA45_0 = input.LA(1);

            	    if ( ((LA45_0 >= ID && LA45_0 <= COMMAND) || LA45_0 == 43 || LA45_0 == 45 || LA45_0 == 52 || LA45_0 == 54 || LA45_0 == 58 || LA45_0 == 77 || (LA45_0 >= 79 && LA45_0 <= 80) || (LA45_0 >= 82 && LA45_0 <= 91)) )
            	    {
            	        alt45 = 1;
            	    }


            	    switch (alt45) 
            		{
            			case 1 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:346:29: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikznode_ext2017);
            			    	tikzpath_element176 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikzpath_element.Add(tikzpath_element176.Tree);

            			    }
            			    break;

            			default:
            			    goto loop45;
            	    }
            	} while (true);

            	loop45:
            		;	// Stops C# compiler whining that label 'loop45' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikznode_ext2020);
            	semicolon_end177 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_semicolon_end.Add(semicolon_end177.Tree);


            	// AST REWRITE
            	// elements:          tikznode_core, node_start, semicolon_end, tikzpath_element
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 346:61: -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:346:64: ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_node_start.NextTree());
            	    adaptor.AddChild(root_1, stream_tikznode_core.NextTree());
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:346:99: ( tikzpath_element )*
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

            if ( state.backtracking==0 )
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

    public class tikzdef_ext_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikzdef_ext"
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:348:1: tikzdef_ext : def_start ( tikzpath_element )* semicolon_end -> ^( IM_PATH def_start ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikzdef_ext_return tikzdef_ext() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzdef_ext_return retval = new simpletikzParser.tikzdef_ext_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.def_start_return def_start178 = default(simpletikzParser.def_start_return);

        simpletikzParser.tikzpath_element_return tikzpath_element179 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end180 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_def_start = new RewriteRuleSubtreeStream(adaptor,"rule def_start");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:349:2: ( def_start ( tikzpath_element )* semicolon_end -> ^( IM_PATH def_start ( tikzpath_element )* semicolon_end ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:349:4: def_start ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_def_start_in_tikzdef_ext2045);
            	def_start178 = def_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_def_start.Add(def_start178.Tree);
            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:349:14: ( tikzpath_element )*
            	do 
            	{
            	    int alt46 = 2;
            	    int LA46_0 = input.LA(1);

            	    if ( ((LA46_0 >= ID && LA46_0 <= COMMAND) || LA46_0 == 43 || LA46_0 == 45 || LA46_0 == 52 || LA46_0 == 54 || LA46_0 == 58 || LA46_0 == 77 || (LA46_0 >= 79 && LA46_0 <= 80) || (LA46_0 >= 82 && LA46_0 <= 91)) )
            	    {
            	        alt46 = 1;
            	    }


            	    switch (alt46) 
            		{
            			case 1 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:349:14: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikzdef_ext2047);
            			    	tikzpath_element179 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikzpath_element.Add(tikzpath_element179.Tree);

            			    }
            			    break;

            			default:
            			    goto loop46;
            	    }
            	} while (true);

            	loop46:
            		;	// Stops C# compiler whining that label 'loop46' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikzdef_ext2050);
            	semicolon_end180 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_semicolon_end.Add(semicolon_end180.Tree);


            	// AST REWRITE
            	// elements:          tikzpath_element, semicolon_end, def_start
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 349:46: -> ^( IM_PATH def_start ( tikzpath_element )* semicolon_end )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:349:49: ^( IM_PATH def_start ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_def_start.NextTree());
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:349:69: ( tikzpath_element )*
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

            if ( state.backtracking==0 )
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
    // $ANTLR end "tikzdef_ext"

    public class tikzmatrix_ext_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikzmatrix_ext"
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:352:1: tikzmatrix_ext : matrix_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH matrix_start tikznode_core ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikzmatrix_ext_return tikzmatrix_ext() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzmatrix_ext_return retval = new simpletikzParser.tikzmatrix_ext_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.matrix_start_return matrix_start181 = default(simpletikzParser.matrix_start_return);

        simpletikzParser.tikznode_core_return tikznode_core182 = default(simpletikzParser.tikznode_core_return);

        simpletikzParser.tikzpath_element_return tikzpath_element183 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end184 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_matrix_start = new RewriteRuleSubtreeStream(adaptor,"rule matrix_start");
        RewriteRuleSubtreeStream stream_tikznode_core = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_core");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:353:2: ( matrix_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH matrix_start tikznode_core ( tikzpath_element )* semicolon_end ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:353:4: matrix_start tikznode_core ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_matrix_start_in_tikzmatrix_ext2075);
            	matrix_start181 = matrix_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_matrix_start.Add(matrix_start181.Tree);
            	PushFollow(FOLLOW_tikznode_core_in_tikzmatrix_ext2077);
            	tikznode_core182 = tikznode_core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_core.Add(tikznode_core182.Tree);
            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:353:31: ( tikzpath_element )*
            	do 
            	{
            	    int alt47 = 2;
            	    int LA47_0 = input.LA(1);

            	    if ( ((LA47_0 >= ID && LA47_0 <= COMMAND) || LA47_0 == 43 || LA47_0 == 45 || LA47_0 == 52 || LA47_0 == 54 || LA47_0 == 58 || LA47_0 == 77 || (LA47_0 >= 79 && LA47_0 <= 80) || (LA47_0 >= 82 && LA47_0 <= 91)) )
            	    {
            	        alt47 = 1;
            	    }


            	    switch (alt47) 
            		{
            			case 1 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:353:31: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikzmatrix_ext2079);
            			    	tikzpath_element183 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikzpath_element.Add(tikzpath_element183.Tree);

            			    }
            			    break;

            			default:
            			    goto loop47;
            	    }
            	} while (true);

            	loop47:
            		;	// Stops C# compiler whining that label 'loop47' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikzmatrix_ext2082);
            	semicolon_end184 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_semicolon_end.Add(semicolon_end184.Tree);


            	// AST REWRITE
            	// elements:          tikznode_core, matrix_start, semicolon_end, tikzpath_element
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 353:63: -> ^( IM_PATH matrix_start tikznode_core ( tikzpath_element )* semicolon_end )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:353:66: ^( IM_PATH matrix_start tikznode_core ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_matrix_start.NextTree());
            	    adaptor.AddChild(root_1, stream_tikznode_core.NextTree());
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:353:103: ( tikzpath_element )*
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

            if ( state.backtracking==0 )
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
    // $ANTLR end "tikzmatrix_ext"

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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:357:1: tikzcoordinate_ext : coordinate_start ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ( tikzpath_element )* semicolon_end -> ^( IM_PATH coordinate_start ( tikzcoordinate_core3 )? ( tikzcoordinate_core2 )? ( tikzcoordinate_core1 )? ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_ext_return retval = new simpletikzParser.tikzcoordinate_ext_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.coordinate_start_return coordinate_start185 = default(simpletikzParser.coordinate_start_return);

        simpletikzParser.tikzcoordinate_core3_return tikzcoordinate_core3186 = default(simpletikzParser.tikzcoordinate_core3_return);

        simpletikzParser.tikzcoordinate_core2_return tikzcoordinate_core2187 = default(simpletikzParser.tikzcoordinate_core2_return);

        simpletikzParser.tikzcoordinate_core1_return tikzcoordinate_core1188 = default(simpletikzParser.tikzcoordinate_core1_return);

        simpletikzParser.tikzpath_element_return tikzpath_element189 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end190 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_tikzcoordinate_core3 = new RewriteRuleSubtreeStream(adaptor,"rule tikzcoordinate_core3");
        RewriteRuleSubtreeStream stream_tikzcoordinate_core2 = new RewriteRuleSubtreeStream(adaptor,"rule tikzcoordinate_core2");
        RewriteRuleSubtreeStream stream_coordinate_start = new RewriteRuleSubtreeStream(adaptor,"rule coordinate_start");
        RewriteRuleSubtreeStream stream_tikzcoordinate_core1 = new RewriteRuleSubtreeStream(adaptor,"rule tikzcoordinate_core1");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:358:2: ( coordinate_start ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ( tikzpath_element )* semicolon_end -> ^( IM_PATH coordinate_start ( tikzcoordinate_core3 )? ( tikzcoordinate_core2 )? ( tikzcoordinate_core1 )? ( tikzpath_element )* semicolon_end ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:358:4: coordinate_start ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_coordinate_start_in_tikzcoordinate_ext2110);
            	coordinate_start185 = coordinate_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_coordinate_start.Add(coordinate_start185.Tree);
            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:359:5: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?
            	int alt48 = 4;
            	alt48 = dfa48.Predict(input);
            	switch (alt48) 
            	{
            	    case 1 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:359:7: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        {
            	        	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:359:7: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:359:8: ( tikzcoordinate_core3 )=> tikzcoordinate_core3
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_ext2125);
            	        		tikzcoordinate_core3186 = tikzcoordinate_core3();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking==0 ) stream_tikzcoordinate_core3.Add(tikzcoordinate_core3186.Tree);

            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:360:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        {
            	        	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:360:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:360:12: ( tikzcoordinate_core2 )=> tikzcoordinate_core2
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_ext2144);
            	        		tikzcoordinate_core2187 = tikzcoordinate_core2();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking==0 ) stream_tikzcoordinate_core2.Add(tikzcoordinate_core2187.Tree);

            	        	}


            	        }
            	        break;
            	    case 3 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:361:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        {
            	        	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:361:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:361:12: ( tikzcoordinate_core1 )=> tikzcoordinate_core1
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_ext2164);
            	        		tikzcoordinate_core1188 = tikzcoordinate_core1();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking==0 ) stream_tikzcoordinate_core1.Add(tikzcoordinate_core1188.Tree);

            	        	}


            	        }
            	        break;

            	}

            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:362:6: ( tikzpath_element )*
            	do 
            	{
            	    int alt49 = 2;
            	    int LA49_0 = input.LA(1);

            	    if ( ((LA49_0 >= ID && LA49_0 <= COMMAND) || LA49_0 == 43 || LA49_0 == 45 || LA49_0 == 52 || LA49_0 == 54 || LA49_0 == 58 || LA49_0 == 77 || (LA49_0 >= 79 && LA49_0 <= 80) || (LA49_0 >= 82 && LA49_0 <= 91)) )
            	    {
            	        alt49 = 1;
            	    }


            	    switch (alt49) 
            		{
            			case 1 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:362:6: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikzcoordinate_ext2175);
            			    	tikzpath_element189 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikzpath_element.Add(tikzpath_element189.Tree);

            			    }
            			    break;

            			default:
            			    goto loop49;
            	    }
            	} while (true);

            	loop49:
            		;	// Stops C# compiler whining that label 'loop49' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikzcoordinate_ext2178);
            	semicolon_end190 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_semicolon_end.Add(semicolon_end190.Tree);


            	// AST REWRITE
            	// elements:          tikzcoordinate_core1, tikzcoordinate_core3, semicolon_end, tikzpath_element, tikzcoordinate_core2, coordinate_start
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 363:6: -> ^( IM_PATH coordinate_start ( tikzcoordinate_core3 )? ( tikzcoordinate_core2 )? ( tikzcoordinate_core1 )? ( tikzpath_element )* semicolon_end )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:363:9: ^( IM_PATH coordinate_start ( tikzcoordinate_core3 )? ( tikzcoordinate_core2 )? ( tikzcoordinate_core1 )? ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_coordinate_start.NextTree());
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:364:6: ( tikzcoordinate_core3 )?
            	    if ( stream_tikzcoordinate_core3.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzcoordinate_core3.NextTree());

            	    }
            	    stream_tikzcoordinate_core3.Reset();
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:365:6: ( tikzcoordinate_core2 )?
            	    if ( stream_tikzcoordinate_core2.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzcoordinate_core2.NextTree());

            	    }
            	    stream_tikzcoordinate_core2.Reset();
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:366:6: ( tikzcoordinate_core1 )?
            	    if ( stream_tikzcoordinate_core1.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzcoordinate_core1.NextTree());

            	    }
            	    stream_tikzcoordinate_core1.Reset();
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:367:6: ( tikzpath_element )*
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

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:369:1: tikzcoordinate_int : 'coordinate' ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ;
    public simpletikzParser.tikzcoordinate_int_return tikzcoordinate_int() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_int_return retval = new simpletikzParser.tikzcoordinate_int_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal191 = null;
        simpletikzParser.tikzcoordinate_core3_return tikzcoordinate_core3192 = default(simpletikzParser.tikzcoordinate_core3_return);

        simpletikzParser.tikzcoordinate_core2_return tikzcoordinate_core2193 = default(simpletikzParser.tikzcoordinate_core2_return);

        simpletikzParser.tikzcoordinate_core1_return tikzcoordinate_core1194 = default(simpletikzParser.tikzcoordinate_core1_return);


        object string_literal191_tree=null;

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:370:2: ( 'coordinate' ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:370:4: 'coordinate' ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal191=(IToken)Match(input,79,FOLLOW_79_in_tikzcoordinate_int2238); if (state.failed) return retval;
            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:370:18: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?
            	int alt50 = 4;
            	alt50 = dfa50.Predict(input);
            	switch (alt50) 
            	{
            	    case 1 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:370:20: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        {
            	        	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:370:20: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:370:21: ( tikzcoordinate_core3 )=> tikzcoordinate_core3
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_int2249);
            	        		tikzcoordinate_core3192 = tikzcoordinate_core3();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_core3192.Tree);

            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:371:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        {
            	        	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:371:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:371:12: ( tikzcoordinate_core2 )=> tikzcoordinate_core2
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_int2268);
            	        		tikzcoordinate_core2193 = tikzcoordinate_core2();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_core2193.Tree);

            	        	}


            	        }
            	        break;
            	    case 3 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:372:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        {
            	        	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:372:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:372:12: ( tikzcoordinate_core1 )=> tikzcoordinate_core1
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_int2288);
            	        		tikzcoordinate_core1194 = tikzcoordinate_core1();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_core1194.Tree);

            	        	}


            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:374:1: tikznode_int : 'node' tikznode_core ;
    public simpletikzParser.tikznode_int_return tikznode_int() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_int_return retval = new simpletikzParser.tikznode_int_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal195 = null;
        simpletikzParser.tikznode_core_return tikznode_core196 = default(simpletikzParser.tikznode_core_return);


        object string_literal195_tree=null;

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:375:2: ( 'node' tikznode_core )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:375:4: 'node' tikznode_core
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal195=(IToken)Match(input,80,FOLLOW_80_in_tikznode_int2304); if (state.failed) return retval;
            	PushFollow(FOLLOW_tikznode_core_in_tikznode_int2307);
            	tikznode_core196 = tikznode_core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_core196.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:377:1: tikznode_core : ( tikznode_decorator )* tikzstring -> ^( IM_NODE ( tikznode_decorator )* tikzstring ) ;
    public simpletikzParser.tikznode_core_return tikznode_core() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_core_return retval = new simpletikzParser.tikznode_core_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator197 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikzstring_return tikzstring198 = default(simpletikzParser.tikzstring_return);


        RewriteRuleSubtreeStream stream_tikzstring = new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:378:2: ( ( tikznode_decorator )* tikzstring -> ^( IM_NODE ( tikznode_decorator )* tikzstring ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:378:4: ( tikznode_decorator )* tikzstring
            {
            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:378:4: ( tikznode_decorator )*
            	do 
            	{
            	    int alt51 = 2;
            	    int LA51_0 = input.LA(1);

            	    if ( (LA51_0 == 52 || LA51_0 == 54 || LA51_0 == 81) )
            	    {
            	        alt51 = 1;
            	    }


            	    switch (alt51) 
            		{
            			case 1 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:378:4: tikznode_decorator
            			    {
            			    	PushFollow(FOLLOW_tikznode_decorator_in_tikznode_core2317);
            			    	tikznode_decorator197 = tikznode_decorator();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikznode_decorator.Add(tikznode_decorator197.Tree);

            			    }
            			    break;

            			default:
            			    goto loop51;
            	    }
            	} while (true);

            	loop51:
            		;	// Stops C# compiler whining that label 'loop51' has no statements

            	PushFollow(FOLLOW_tikzstring_in_tikznode_core2320);
            	tikzstring198 = tikzstring();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikzstring.Add(tikzstring198.Tree);


            	// AST REWRITE
            	// elements:          tikzstring, tikznode_decorator
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 378:36: -> ^( IM_NODE ( tikznode_decorator )* tikzstring )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:378:39: ^( IM_NODE ( tikznode_decorator )* tikzstring )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NODE, "IM_NODE"), root_1);

            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:378:49: ( tikznode_decorator )*
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

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:381:1: tikzcoordinate_core3 : tikznode_decorator tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator ) ;
    public simpletikzParser.tikzcoordinate_core3_return tikzcoordinate_core3() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_core3_return retval = new simpletikzParser.tikzcoordinate_core3_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator199 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikznode_decorator_return tikznode_decorator200 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikznode_decorator_return tikznode_decorator201 = default(simpletikzParser.tikznode_decorator_return);


        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:382:2: ( tikznode_decorator tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:382:6: tikznode_decorator tikznode_decorator tikznode_decorator
            {
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core32345);
            	tikznode_decorator199 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_decorator.Add(tikznode_decorator199.Tree);
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core32347);
            	tikznode_decorator200 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_decorator.Add(tikznode_decorator200.Tree);
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core32349);
            	tikznode_decorator201 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_decorator.Add(tikznode_decorator201.Tree);


            	// AST REWRITE
            	// elements:          tikznode_decorator, tikznode_decorator, tikznode_decorator
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 382:64: -> ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:382:67: ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator )
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

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:386:1: tikzcoordinate_core2 : tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator ) ;
    public simpletikzParser.tikzcoordinate_core2_return tikzcoordinate_core2() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_core2_return retval = new simpletikzParser.tikzcoordinate_core2_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator202 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikznode_decorator_return tikznode_decorator203 = default(simpletikzParser.tikznode_decorator_return);


        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:387:2: ( tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:388:4: tikznode_decorator tikznode_decorator
            {
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core22383);
            	tikznode_decorator202 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_decorator.Add(tikznode_decorator202.Tree);
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core22385);
            	tikznode_decorator203 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_decorator.Add(tikznode_decorator203.Tree);


            	// AST REWRITE
            	// elements:          tikznode_decorator, tikznode_decorator
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 388:47: -> ^( IM_NODE tikznode_decorator tikznode_decorator )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:388:50: ^( IM_NODE tikznode_decorator tikznode_decorator )
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

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:391:1: tikzcoordinate_core1 : tikznode_decorator -> ^( IM_NODE tikznode_decorator ) ;
    public simpletikzParser.tikzcoordinate_core1_return tikzcoordinate_core1() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_core1_return retval = new simpletikzParser.tikzcoordinate_core1_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator204 = default(simpletikzParser.tikznode_decorator_return);


        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:392:2: ( tikznode_decorator -> ^( IM_NODE tikznode_decorator ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:393:4: tikznode_decorator
            {
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core12418);
            	tikznode_decorator204 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_decorator.Add(tikznode_decorator204.Tree);


            	// AST REWRITE
            	// elements:          tikznode_decorator
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 393:31: -> ^( IM_NODE tikznode_decorator )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:393:34: ^( IM_NODE tikznode_decorator )
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

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:400:1: tikznode_decorator : ( nodename | 'at' COMMAND | 'at' coord | tikz_options_dontcare );
    public simpletikzParser.tikznode_decorator_return tikznode_decorator() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_decorator_return retval = new simpletikzParser.tikznode_decorator_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal206 = null;
        IToken COMMAND207 = null;
        IToken string_literal208 = null;
        simpletikzParser.nodename_return nodename205 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_return coord209 = default(simpletikzParser.coord_return);

        simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare210 = default(simpletikzParser.tikz_options_dontcare_return);


        object string_literal206_tree=null;
        object COMMAND207_tree=null;
        object string_literal208_tree=null;

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:401:2: ( nodename | 'at' COMMAND | 'at' coord | tikz_options_dontcare )
            int alt52 = 4;
            switch ( input.LA(1) ) 
            {
            case 52:
            	{
                alt52 = 1;
                }
                break;
            case 81:
            	{
                int LA52_2 = input.LA(2);

                if ( (LA52_2 == COMMAND) )
                {
                    alt52 = 2;
                }
                else if ( (LA52_2 == 52 || (LA52_2 >= 89 && LA52_2 <= 90)) )
                {
                    alt52 = 3;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d52s2 =
                        new NoViableAltException("", 52, 2, input);

                    throw nvae_d52s2;
                }
                }
                break;
            case 54:
            	{
                alt52 = 4;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d52s0 =
            	        new NoViableAltException("", 52, 0, input);

            	    throw nvae_d52s0;
            }

            switch (alt52) 
            {
                case 1 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:401:6: nodename
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_nodename_in_tikznode_decorator2455);
                    	nodename205 = nodename();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, nodename205.Tree);

                    }
                    break;
                case 2 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:402:5: 'at' COMMAND
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal206=(IToken)Match(input,81,FOLLOW_81_in_tikznode_decorator2462); if (state.failed) return retval;
                    	COMMAND207=(IToken)Match(input,COMMAND,FOLLOW_COMMAND_in_tikznode_decorator2465); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{COMMAND207_tree = (object)adaptor.Create(COMMAND207);
                    		adaptor.AddChild(root_0, COMMAND207_tree);
                    	}

                    }
                    break;
                case 3 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:403:5: 'at' coord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal208=(IToken)Match(input,81,FOLLOW_81_in_tikznode_decorator2471); if (state.failed) return retval;
                    	PushFollow(FOLLOW_coord_in_tikznode_decorator2474);
                    	coord209 = coord();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, coord209.Tree);

                    }
                    break;
                case 4 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:404:5: tikz_options_dontcare
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_options_dontcare_in_tikznode_decorator2480);
                    	tikz_options_dontcare210 = tikz_options_dontcare();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_options_dontcare210.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:406:1: tikz_options_dontcare : '[' ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* ']' -> ^( IM_OPTIONS ) ;
    public simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_options_dontcare_return retval = new simpletikzParser.tikz_options_dontcare_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal211 = null;
        IToken char_literal215 = null;
        simpletikzParser.no_rlbracket_return no_rlbracket212 = default(simpletikzParser.no_rlbracket_return);

        simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare213 = default(simpletikzParser.tikz_options_dontcare_return);

        simpletikzParser.no_rlbracket_return no_rlbracket214 = default(simpletikzParser.no_rlbracket_return);


        object char_literal211_tree=null;
        object char_literal215_tree=null;
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleSubtreeStream stream_tikz_options_dontcare = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options_dontcare");
        RewriteRuleSubtreeStream stream_no_rlbracket = new RewriteRuleSubtreeStream(adaptor,"rule no_rlbracket");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:407:2: ( '[' ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* ']' -> ^( IM_OPTIONS ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:407:4: '[' ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* ']'
            {
            	char_literal211=(IToken)Match(input,54,FOLLOW_54_in_tikz_options_dontcare2490); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_54.Add(char_literal211);

            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:407:8: ( no_rlbracket )*
            	do 
            	{
            	    int alt53 = 2;
            	    int LA53_0 = input.LA(1);

            	    if ( ((LA53_0 >= IM_PATH && LA53_0 <= 53) || (LA53_0 >= 56 && LA53_0 <= 94)) )
            	    {
            	        alt53 = 1;
            	    }


            	    switch (alt53) 
            		{
            			case 1 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:407:8: no_rlbracket
            			    {
            			    	PushFollow(FOLLOW_no_rlbracket_in_tikz_options_dontcare2492);
            			    	no_rlbracket212 = no_rlbracket();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_no_rlbracket.Add(no_rlbracket212.Tree);

            			    }
            			    break;

            			default:
            			    goto loop53;
            	    }
            	} while (true);

            	loop53:
            		;	// Stops C# compiler whining that label 'loop53' has no statements

            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:407:22: ( tikz_options_dontcare ( no_rlbracket )* )*
            	do 
            	{
            	    int alt55 = 2;
            	    int LA55_0 = input.LA(1);

            	    if ( (LA55_0 == 54) )
            	    {
            	        alt55 = 1;
            	    }


            	    switch (alt55) 
            		{
            			case 1 :
            			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:407:23: tikz_options_dontcare ( no_rlbracket )*
            			    {
            			    	PushFollow(FOLLOW_tikz_options_dontcare_in_tikz_options_dontcare2496);
            			    	tikz_options_dontcare213 = tikz_options_dontcare();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikz_options_dontcare.Add(tikz_options_dontcare213.Tree);
            			    	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:407:45: ( no_rlbracket )*
            			    	do 
            			    	{
            			    	    int alt54 = 2;
            			    	    int LA54_0 = input.LA(1);

            			    	    if ( ((LA54_0 >= IM_PATH && LA54_0 <= 53) || (LA54_0 >= 56 && LA54_0 <= 94)) )
            			    	    {
            			    	        alt54 = 1;
            			    	    }


            			    	    switch (alt54) 
            			    		{
            			    			case 1 :
            			    			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:407:45: no_rlbracket
            			    			    {
            			    			    	PushFollow(FOLLOW_no_rlbracket_in_tikz_options_dontcare2498);
            			    			    	no_rlbracket214 = no_rlbracket();
            			    			    	state.followingStackPointer--;
            			    			    	if (state.failed) return retval;
            			    			    	if ( state.backtracking==0 ) stream_no_rlbracket.Add(no_rlbracket214.Tree);

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop54;
            			    	    }
            			    	} while (true);

            			    	loop54:
            			    		;	// Stops C# compiler whining that label 'loop54' has no statements


            			    }
            			    break;

            			default:
            			    goto loop55;
            	    }
            	} while (true);

            	loop55:
            		;	// Stops C# compiler whining that label 'loop55' has no statements

            	char_literal215=(IToken)Match(input,55,FOLLOW_55_in_tikz_options_dontcare2503); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_55.Add(char_literal215);



            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 407:65: -> ^( IM_OPTIONS )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:407:68: ^( IM_OPTIONS )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTIONS, "IM_OPTIONS"), root_1);

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:409:1: no_rlbracket : ~ ( '[' | ']' ) ;
    public simpletikzParser.no_rlbracket_return no_rlbracket() // throws RecognitionException [1]
    {   
        simpletikzParser.no_rlbracket_return retval = new simpletikzParser.no_rlbracket_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set216 = null;

        object set216_tree=null;

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:410:2: (~ ( '[' | ']' ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:410:4: ~ ( '[' | ']' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set216 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= 53) || (input.LA(1) >= 56 && input.LA(1) <= 94) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set216));
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

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:412:1: nodename : '(' idd ')' -> ^( IM_NODENAME idd ) ;
    public simpletikzParser.nodename_return nodename() // throws RecognitionException [1]
    {   
        simpletikzParser.nodename_return retval = new simpletikzParser.nodename_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal217 = null;
        IToken char_literal219 = null;
        simpletikzParser.idd_return idd218 = default(simpletikzParser.idd_return);


        object char_literal217_tree=null;
        object char_literal219_tree=null;
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:413:2: ( '(' idd ')' -> ^( IM_NODENAME idd ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:413:4: '(' idd ')'
            {
            	char_literal217=(IToken)Match(input,52,FOLLOW_52_in_nodename2538); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_52.Add(char_literal217);

            	PushFollow(FOLLOW_idd_in_nodename2540);
            	idd218 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_idd.Add(idd218.Tree);
            	char_literal219=(IToken)Match(input,53,FOLLOW_53_in_nodename2542); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_53.Add(char_literal219);



            	// AST REWRITE
            	// elements:          idd
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 413:17: -> ^( IM_NODENAME idd )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:413:20: ^( IM_NODENAME idd )
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

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:419:1: circle : ( 'circle' | 'ellipse' ) ( ( size )=> size )? ->;
    public simpletikzParser.circle_return circle() // throws RecognitionException [1]
    {   
        simpletikzParser.circle_return retval = new simpletikzParser.circle_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal220 = null;
        IToken string_literal221 = null;
        simpletikzParser.size_return size222 = default(simpletikzParser.size_return);


        object string_literal220_tree=null;
        object string_literal221_tree=null;
        RewriteRuleTokenStream stream_82 = new RewriteRuleTokenStream(adaptor,"token 82");
        RewriteRuleTokenStream stream_83 = new RewriteRuleTokenStream(adaptor,"token 83");
        RewriteRuleSubtreeStream stream_size = new RewriteRuleSubtreeStream(adaptor,"rule size");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:420:2: ( ( 'circle' | 'ellipse' ) ( ( size )=> size )? ->)
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:420:4: ( 'circle' | 'ellipse' ) ( ( size )=> size )?
            {
            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:420:4: ( 'circle' | 'ellipse' )
            	int alt56 = 2;
            	int LA56_0 = input.LA(1);

            	if ( (LA56_0 == 82) )
            	{
            	    alt56 = 1;
            	}
            	else if ( (LA56_0 == 83) )
            	{
            	    alt56 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d56s0 =
            	        new NoViableAltException("", 56, 0, input);

            	    throw nvae_d56s0;
            	}
            	switch (alt56) 
            	{
            	    case 1 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:420:5: 'circle'
            	        {
            	        	string_literal220=(IToken)Match(input,82,FOLLOW_82_in_circle2567); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_82.Add(string_literal220);


            	        }
            	        break;
            	    case 2 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:420:16: 'ellipse'
            	        {
            	        	string_literal221=(IToken)Match(input,83,FOLLOW_83_in_circle2571); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_83.Add(string_literal221);


            	        }
            	        break;

            	}

            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:420:27: ( ( size )=> size )?
            	int alt57 = 2;
            	alt57 = dfa57.Predict(input);
            	switch (alt57) 
            	{
            	    case 1 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:420:28: ( size )=> size
            	        {
            	        	PushFollow(FOLLOW_size_in_circle2580);
            	        	size222 = size();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_size.Add(size222.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 420:44: ->
            	{
            	    root_0 = null;
            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:422:1: arc : ( 'arc' ( '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')' ) -> ^( IM_ARC ( numberunitorvariable )+ ( numberunit )? ) | 'arc' ( '(' coord_part ':' coord_part ':' coord_part ( 'and' numberunit )? ')' ) -> ^( IM_ARC ( coord_part )+ ( numberunit )? ) | 'arc' tikz_options -> ^( IM_DONTCARE ) );
    public simpletikzParser.arc_return arc() // throws RecognitionException [1]
    {   
        simpletikzParser.arc_return retval = new simpletikzParser.arc_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal223 = null;
        IToken char_literal224 = null;
        IToken char_literal226 = null;
        IToken char_literal228 = null;
        IToken string_literal230 = null;
        IToken char_literal232 = null;
        IToken string_literal233 = null;
        IToken char_literal234 = null;
        IToken char_literal236 = null;
        IToken char_literal238 = null;
        IToken string_literal240 = null;
        IToken char_literal242 = null;
        IToken string_literal243 = null;
        simpletikzParser.numberunitorvariable_return numberunitorvariable225 = default(simpletikzParser.numberunitorvariable_return);

        simpletikzParser.numberunitorvariable_return numberunitorvariable227 = default(simpletikzParser.numberunitorvariable_return);

        simpletikzParser.numberunitorvariable_return numberunitorvariable229 = default(simpletikzParser.numberunitorvariable_return);

        simpletikzParser.numberunit_return numberunit231 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_part_return coord_part235 = default(simpletikzParser.coord_part_return);

        simpletikzParser.coord_part_return coord_part237 = default(simpletikzParser.coord_part_return);

        simpletikzParser.coord_part_return coord_part239 = default(simpletikzParser.coord_part_return);

        simpletikzParser.numberunit_return numberunit241 = default(simpletikzParser.numberunit_return);

        simpletikzParser.tikz_options_return tikz_options244 = default(simpletikzParser.tikz_options_return);


        object string_literal223_tree=null;
        object char_literal224_tree=null;
        object char_literal226_tree=null;
        object char_literal228_tree=null;
        object string_literal230_tree=null;
        object char_literal232_tree=null;
        object string_literal233_tree=null;
        object char_literal234_tree=null;
        object char_literal236_tree=null;
        object char_literal238_tree=null;
        object string_literal240_tree=null;
        object char_literal242_tree=null;
        object string_literal243_tree=null;
        RewriteRuleTokenStream stream_48 = new RewriteRuleTokenStream(adaptor,"token 48");
        RewriteRuleTokenStream stream_78 = new RewriteRuleTokenStream(adaptor,"token 78");
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleTokenStream stream_84 = new RewriteRuleTokenStream(adaptor,"token 84");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_numberunitorvariable = new RewriteRuleSubtreeStream(adaptor,"rule numberunitorvariable");
        RewriteRuleSubtreeStream stream_coord_part = new RewriteRuleSubtreeStream(adaptor,"rule coord_part");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:423:2: ( 'arc' ( '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')' ) -> ^( IM_ARC ( numberunitorvariable )+ ( numberunit )? ) | 'arc' ( '(' coord_part ':' coord_part ':' coord_part ( 'and' numberunit )? ')' ) -> ^( IM_ARC ( coord_part )+ ( numberunit )? ) | 'arc' tikz_options -> ^( IM_DONTCARE ) )
            int alt60 = 3;
            alt60 = dfa60.Predict(input);
            switch (alt60) 
            {
                case 1 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:423:4: 'arc' ( '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')' )
                    {
                    	string_literal223=(IToken)Match(input,84,FOLLOW_84_in_arc2595); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_84.Add(string_literal223);

                    	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:423:10: ( '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')' )
                    	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:423:11: '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')'
                    	{
                    		char_literal224=(IToken)Match(input,52,FOLLOW_52_in_arc2598); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_52.Add(char_literal224);

                    		PushFollow(FOLLOW_numberunitorvariable_in_arc2600);
                    		numberunitorvariable225 = numberunitorvariable();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_numberunitorvariable.Add(numberunitorvariable225.Tree);
                    		char_literal226=(IToken)Match(input,48,FOLLOW_48_in_arc2602); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_48.Add(char_literal226);

                    		PushFollow(FOLLOW_numberunitorvariable_in_arc2604);
                    		numberunitorvariable227 = numberunitorvariable();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_numberunitorvariable.Add(numberunitorvariable227.Tree);
                    		char_literal228=(IToken)Match(input,48,FOLLOW_48_in_arc2606); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_48.Add(char_literal228);

                    		PushFollow(FOLLOW_numberunitorvariable_in_arc2608);
                    		numberunitorvariable229 = numberunitorvariable();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_numberunitorvariable.Add(numberunitorvariable229.Tree);
                    		// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:423:86: ( 'and' numberunit )?
                    		int alt58 = 2;
                    		int LA58_0 = input.LA(1);

                    		if ( (LA58_0 == 78) )
                    		{
                    		    alt58 = 1;
                    		}
                    		switch (alt58) 
                    		{
                    		    case 1 :
                    		        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:423:87: 'and' numberunit
                    		        {
                    		        	string_literal230=(IToken)Match(input,78,FOLLOW_78_in_arc2611); if (state.failed) return retval; 
                    		        	if ( state.backtracking==0 ) stream_78.Add(string_literal230);

                    		        	PushFollow(FOLLOW_numberunit_in_arc2613);
                    		        	numberunit231 = numberunit();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_numberunit.Add(numberunit231.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal232=(IToken)Match(input,53,FOLLOW_53_in_arc2617); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_53.Add(char_literal232);


                    	}



                    	// AST REWRITE
                    	// elements:          numberunitorvariable, numberunit
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 423:111: -> ^( IM_ARC ( numberunitorvariable )+ ( numberunit )? )
                    	{
                    	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:423:114: ^( IM_ARC ( numberunitorvariable )+ ( numberunit )? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ARC, "IM_ARC"), root_1);

                    	    if ( !(stream_numberunitorvariable.HasNext()) ) {
                    	        throw new RewriteEarlyExitException();
                    	    }
                    	    while ( stream_numberunitorvariable.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_numberunitorvariable.NextTree());

                    	    }
                    	    stream_numberunitorvariable.Reset();
                    	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:423:145: ( numberunit )?
                    	    if ( stream_numberunit.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_numberunit.NextTree());

                    	    }
                    	    stream_numberunit.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:424:4: 'arc' ( '(' coord_part ':' coord_part ':' coord_part ( 'and' numberunit )? ')' )
                    {
                    	string_literal233=(IToken)Match(input,84,FOLLOW_84_in_arc2635); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_84.Add(string_literal233);

                    	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:424:10: ( '(' coord_part ':' coord_part ':' coord_part ( 'and' numberunit )? ')' )
                    	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:424:11: '(' coord_part ':' coord_part ':' coord_part ( 'and' numberunit )? ')'
                    	{
                    		char_literal234=(IToken)Match(input,52,FOLLOW_52_in_arc2638); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_52.Add(char_literal234);

                    		PushFollow(FOLLOW_coord_part_in_arc2640);
                    		coord_part235 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_part.Add(coord_part235.Tree);
                    		char_literal236=(IToken)Match(input,48,FOLLOW_48_in_arc2642); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_48.Add(char_literal236);

                    		PushFollow(FOLLOW_coord_part_in_arc2644);
                    		coord_part237 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_part.Add(coord_part237.Tree);
                    		char_literal238=(IToken)Match(input,48,FOLLOW_48_in_arc2646); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_48.Add(char_literal238);

                    		PushFollow(FOLLOW_coord_part_in_arc2648);
                    		coord_part239 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_part.Add(coord_part239.Tree);
                    		// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:424:56: ( 'and' numberunit )?
                    		int alt59 = 2;
                    		int LA59_0 = input.LA(1);

                    		if ( (LA59_0 == 78) )
                    		{
                    		    alt59 = 1;
                    		}
                    		switch (alt59) 
                    		{
                    		    case 1 :
                    		        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:424:57: 'and' numberunit
                    		        {
                    		        	string_literal240=(IToken)Match(input,78,FOLLOW_78_in_arc2651); if (state.failed) return retval; 
                    		        	if ( state.backtracking==0 ) stream_78.Add(string_literal240);

                    		        	PushFollow(FOLLOW_numberunit_in_arc2653);
                    		        	numberunit241 = numberunit();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_numberunit.Add(numberunit241.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal242=(IToken)Match(input,53,FOLLOW_53_in_arc2657); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_53.Add(char_literal242);


                    	}



                    	// AST REWRITE
                    	// elements:          numberunit, coord_part
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 424:81: -> ^( IM_ARC ( coord_part )+ ( numberunit )? )
                    	{
                    	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:424:84: ^( IM_ARC ( coord_part )+ ( numberunit )? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ARC, "IM_ARC"), root_1);

                    	    if ( !(stream_coord_part.HasNext()) ) {
                    	        throw new RewriteEarlyExitException();
                    	    }
                    	    while ( stream_coord_part.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_coord_part.NextTree());

                    	    }
                    	    stream_coord_part.Reset();
                    	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:424:105: ( numberunit )?
                    	    if ( stream_numberunit.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_numberunit.NextTree());

                    	    }
                    	    stream_numberunit.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:425:4: 'arc' tikz_options
                    {
                    	string_literal243=(IToken)Match(input,84,FOLLOW_84_in_arc2675); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_84.Add(string_literal243);

                    	PushFollow(FOLLOW_tikz_options_in_arc2677);
                    	tikz_options244 = tikz_options();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_tikz_options.Add(tikz_options244.Tree);


                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 425:23: -> ^( IM_DONTCARE )
                    	{
                    	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:425:25: ^( IM_DONTCARE )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DONTCARE, "IM_DONTCARE"), root_1);

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:432:1: size : '(' numberunit ( 'and' numberunit )? ')' -> ^( IM_SIZE ( numberunit )* ) ;
    public simpletikzParser.size_return size() // throws RecognitionException [1]
    {   
        simpletikzParser.size_return retval = new simpletikzParser.size_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal245 = null;
        IToken string_literal247 = null;
        IToken char_literal249 = null;
        simpletikzParser.numberunit_return numberunit246 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit248 = default(simpletikzParser.numberunit_return);


        object char_literal245_tree=null;
        object string_literal247_tree=null;
        object char_literal249_tree=null;
        RewriteRuleTokenStream stream_78 = new RewriteRuleTokenStream(adaptor,"token 78");
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:433:2: ( '(' numberunit ( 'and' numberunit )? ')' -> ^( IM_SIZE ( numberunit )* ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:433:6: '(' numberunit ( 'and' numberunit )? ')'
            {
            	char_literal245=(IToken)Match(input,52,FOLLOW_52_in_size2702); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_52.Add(char_literal245);

            	PushFollow(FOLLOW_numberunit_in_size2704);
            	numberunit246 = numberunit();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_numberunit.Add(numberunit246.Tree);
            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:433:21: ( 'and' numberunit )?
            	int alt61 = 2;
            	int LA61_0 = input.LA(1);

            	if ( (LA61_0 == 78) )
            	{
            	    alt61 = 1;
            	}
            	switch (alt61) 
            	{
            	    case 1 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:433:22: 'and' numberunit
            	        {
            	        	string_literal247=(IToken)Match(input,78,FOLLOW_78_in_size2707); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_78.Add(string_literal247);

            	        	PushFollow(FOLLOW_numberunit_in_size2709);
            	        	numberunit248 = numberunit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_numberunit.Add(numberunit248.Tree);

            	        }
            	        break;

            	}

            	char_literal249=(IToken)Match(input,53,FOLLOW_53_in_size2713); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_53.Add(char_literal249);



            	// AST REWRITE
            	// elements:          numberunit
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 433:46: -> ^( IM_SIZE ( numberunit )* )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:433:49: ^( IM_SIZE ( numberunit )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_SIZE, "IM_SIZE"), root_1);

            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:433:59: ( numberunit )*
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

            if ( state.backtracking==0 )
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

    public class coord_nodename_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "coord_nodename"
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:440:1: coord_nodename : '(' ( tikz_options )? idd ')' -> ^( IM_NODENAME idd ( tikz_options )? ) ;
    public simpletikzParser.coord_nodename_return coord_nodename() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_nodename_return retval = new simpletikzParser.coord_nodename_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal250 = null;
        IToken char_literal253 = null;
        simpletikzParser.tikz_options_return tikz_options251 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.idd_return idd252 = default(simpletikzParser.idd_return);


        object char_literal250_tree=null;
        object char_literal253_tree=null;
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:441:2: ( '(' ( tikz_options )? idd ')' -> ^( IM_NODENAME idd ( tikz_options )? ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:441:4: '(' ( tikz_options )? idd ')'
            {
            	char_literal250=(IToken)Match(input,52,FOLLOW_52_in_coord_nodename2741); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_52.Add(char_literal250);

            	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:441:8: ( tikz_options )?
            	int alt62 = 2;
            	int LA62_0 = input.LA(1);

            	if ( (LA62_0 == 54) )
            	{
            	    alt62 = 1;
            	}
            	switch (alt62) 
            	{
            	    case 1 :
            	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:441:8: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_coord_nodename2743);
            	        	tikz_options251 = tikz_options();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_tikz_options.Add(tikz_options251.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_idd_in_coord_nodename2746);
            	idd252 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_idd.Add(idd252.Tree);
            	char_literal253=(IToken)Match(input,53,FOLLOW_53_in_coord_nodename2749); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_53.Add(char_literal253);



            	// AST REWRITE
            	// elements:          tikz_options, idd
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 441:32: -> ^( IM_NODENAME idd ( tikz_options )? )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:441:35: ^( IM_NODENAME idd ( tikz_options )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NODENAME, "IM_NODENAME"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:441:53: ( tikz_options )?
            	    if ( stream_tikz_options.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikz_options.NextTree());

            	    }
            	    stream_tikz_options.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // $ANTLR end "coord_nodename"

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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:442:1: coord : ( ( ( coord_modifier )? coord_nodename ) -> ^( IM_COORD ( coord_modifier )? coord_nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) | ( ( coord_modifier )? '(' ')' ) -> ^( IM_COORD ) );
    public simpletikzParser.coord_return coord() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_return retval = new simpletikzParser.coord_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal257 = null;
        IToken char_literal261 = null;
        IToken char_literal263 = null;
        IToken char_literal267 = null;
        IToken char_literal269 = null;
        IToken char_literal270 = null;
        simpletikzParser.coord_modifier_return coord_modifier254 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.coord_nodename_return coord_nodename255 = default(simpletikzParser.coord_nodename_return);

        simpletikzParser.coord_modifier_return coord_modifier256 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.numberunit_return numberunit258 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_sep_return coord_sep259 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.numberunit_return numberunit260 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_modifier_return coord_modifier262 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.coord_part_return coord_part264 = default(simpletikzParser.coord_part_return);

        simpletikzParser.coord_sep_return coord_sep265 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.coord_part_return coord_part266 = default(simpletikzParser.coord_part_return);

        simpletikzParser.coord_modifier_return coord_modifier268 = default(simpletikzParser.coord_modifier_return);


        object char_literal257_tree=null;
        object char_literal261_tree=null;
        object char_literal263_tree=null;
        object char_literal267_tree=null;
        object char_literal269_tree=null;
        object char_literal270_tree=null;
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_coord_nodename = new RewriteRuleSubtreeStream(adaptor,"rule coord_nodename");
        RewriteRuleSubtreeStream stream_coord_part = new RewriteRuleSubtreeStream(adaptor,"rule coord_part");
        RewriteRuleSubtreeStream stream_coord_sep = new RewriteRuleSubtreeStream(adaptor,"rule coord_sep");
        RewriteRuleSubtreeStream stream_coord_modifier = new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:443:2: ( ( ( coord_modifier )? coord_nodename ) -> ^( IM_COORD ( coord_modifier )? coord_nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) | ( ( coord_modifier )? '(' ')' ) -> ^( IM_COORD ) )
            int alt67 = 4;
            alt67 = dfa67.Predict(input);
            switch (alt67) 
            {
                case 1 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:443:6: ( ( coord_modifier )? coord_nodename )
                    {
                    	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:443:6: ( ( coord_modifier )? coord_nodename )
                    	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:443:8: ( coord_modifier )? coord_nodename
                    	{
                    		// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:443:8: ( coord_modifier )?
                    		int alt63 = 2;
                    		int LA63_0 = input.LA(1);

                    		if ( ((LA63_0 >= 89 && LA63_0 <= 90)) )
                    		{
                    		    alt63 = 1;
                    		}
                    		switch (alt63) 
                    		{
                    		    case 1 :
                    		        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:443:8: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord2775);
                    		        	coord_modifier254 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_coord_modifier.Add(coord_modifier254.Tree);

                    		        }
                    		        break;

                    		}

                    		PushFollow(FOLLOW_coord_nodename_in_coord2778);
                    		coord_nodename255 = coord_nodename();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_nodename.Add(coord_nodename255.Tree);

                    	}



                    	// AST REWRITE
                    	// elements:          coord_nodename, coord_modifier
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 443:44: -> ^( IM_COORD ( coord_modifier )? coord_nodename )
                    	{
                    	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:443:47: ^( IM_COORD ( coord_modifier )? coord_nodename )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:443:58: ( coord_modifier )?
                    	    if ( stream_coord_modifier.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_coord_modifier.NextTree());

                    	    }
                    	    stream_coord_modifier.Reset();
                    	    adaptor.AddChild(root_1, stream_coord_nodename.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:444:5: ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' )
                    {
                    	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:444:5: ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' )
                    	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:444:7: ( coord_modifier )? '(' numberunit coord_sep numberunit ')'
                    	{
                    		// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:444:7: ( coord_modifier )?
                    		int alt64 = 2;
                    		int LA64_0 = input.LA(1);

                    		if ( ((LA64_0 >= 89 && LA64_0 <= 90)) )
                    		{
                    		    alt64 = 1;
                    		}
                    		switch (alt64) 
                    		{
                    		    case 1 :
                    		        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:444:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord2804);
                    		        	coord_modifier256 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_coord_modifier.Add(coord_modifier256.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal257=(IToken)Match(input,52,FOLLOW_52_in_coord2807); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_52.Add(char_literal257);

                    		PushFollow(FOLLOW_numberunit_in_coord2809);
                    		numberunit258 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_numberunit.Add(numberunit258.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord2811);
                    		coord_sep259 = coord_sep();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_sep.Add(coord_sep259.Tree);
                    		PushFollow(FOLLOW_numberunit_in_coord2813);
                    		numberunit260 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_numberunit.Add(numberunit260.Tree);
                    		char_literal261=(IToken)Match(input,53,FOLLOW_53_in_coord2815); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_53.Add(char_literal261);


                    	}



                    	// AST REWRITE
                    	// elements:          coord_modifier, coord_sep, numberunit
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 444:65: -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep )
                    	{
                    	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:444:68: ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:444:79: ( coord_modifier )?
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
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:445:5: ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' )
                    {
                    	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:445:5: ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' )
                    	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:445:7: ( coord_modifier )? '(' coord_part coord_sep coord_part ')'
                    	{
                    		// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:445:7: ( coord_modifier )?
                    		int alt65 = 2;
                    		int LA65_0 = input.LA(1);

                    		if ( ((LA65_0 >= 89 && LA65_0 <= 90)) )
                    		{
                    		    alt65 = 1;
                    		}
                    		switch (alt65) 
                    		{
                    		    case 1 :
                    		        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:445:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord2839);
                    		        	coord_modifier262 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_coord_modifier.Add(coord_modifier262.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal263=(IToken)Match(input,52,FOLLOW_52_in_coord2842); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_52.Add(char_literal263);

                    		PushFollow(FOLLOW_coord_part_in_coord2844);
                    		coord_part264 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_part.Add(coord_part264.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord2846);
                    		coord_sep265 = coord_sep();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_sep.Add(coord_sep265.Tree);
                    		PushFollow(FOLLOW_coord_part_in_coord2848);
                    		coord_part266 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_part.Add(coord_part266.Tree);
                    		char_literal267=(IToken)Match(input,53,FOLLOW_53_in_coord2850); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_53.Add(char_literal267);


                    	}



                    	// AST REWRITE
                    	// elements:          coord_modifier, coord_sep, coord_part
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 445:65: -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep )
                    	{
                    	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:445:68: ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:445:79: ( coord_modifier )?
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
                case 4 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:446:5: ( ( coord_modifier )? '(' ')' )
                    {
                    	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:446:5: ( ( coord_modifier )? '(' ')' )
                    	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:446:7: ( coord_modifier )? '(' ')'
                    	{
                    		// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:446:7: ( coord_modifier )?
                    		int alt66 = 2;
                    		int LA66_0 = input.LA(1);

                    		if ( ((LA66_0 >= 89 && LA66_0 <= 90)) )
                    		{
                    		    alt66 = 1;
                    		}
                    		switch (alt66) 
                    		{
                    		    case 1 :
                    		        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:446:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord2874);
                    		        	coord_modifier268 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_coord_modifier.Add(coord_modifier268.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal269=(IToken)Match(input,52,FOLLOW_52_in_coord2877); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_52.Add(char_literal269);

                    		char_literal270=(IToken)Match(input,53,FOLLOW_53_in_coord2879); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_53.Add(char_literal270);


                    	}



                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 446:37: -> ^( IM_COORD )
                    	{
                    	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:446:40: ^( IM_COORD )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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

    public class coord_nooption_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "coord_nooption"
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:448:1: coord_nooption : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) );
    public simpletikzParser.coord_nooption_return coord_nooption() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_nooption_return retval = new simpletikzParser.coord_nooption_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal273 = null;
        IToken char_literal277 = null;
        IToken char_literal279 = null;
        IToken char_literal283 = null;
        simpletikzParser.nodename_return nodename271 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_modifier_return coord_modifier272 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.numberunit_return numberunit274 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_sep_return coord_sep275 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.numberunit_return numberunit276 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_modifier_return coord_modifier278 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.coord_part_return coord_part280 = default(simpletikzParser.coord_part_return);

        simpletikzParser.coord_sep_return coord_sep281 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.coord_part_return coord_part282 = default(simpletikzParser.coord_part_return);


        object char_literal273_tree=null;
        object char_literal277_tree=null;
        object char_literal279_tree=null;
        object char_literal283_tree=null;
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_coord_part = new RewriteRuleSubtreeStream(adaptor,"rule coord_part");
        RewriteRuleSubtreeStream stream_coord_sep = new RewriteRuleSubtreeStream(adaptor,"rule coord_sep");
        RewriteRuleSubtreeStream stream_nodename = new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        RewriteRuleSubtreeStream stream_coord_modifier = new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:449:2: ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) )
            int alt70 = 3;
            alt70 = dfa70.Predict(input);
            switch (alt70) 
            {
                case 1 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:449:6: nodename
                    {
                    	PushFollow(FOLLOW_nodename_in_coord_nooption2907);
                    	nodename271 = nodename();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_nodename.Add(nodename271.Tree);


                    	// AST REWRITE
                    	// elements:          nodename
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 449:22: -> ^( IM_COORD nodename )
                    	{
                    	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:449:25: ^( IM_COORD nodename )
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
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:450:5: ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' )
                    {
                    	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:450:5: ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' )
                    	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:450:7: ( coord_modifier )? '(' numberunit coord_sep numberunit ')'
                    	{
                    		// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:450:7: ( coord_modifier )?
                    		int alt68 = 2;
                    		int LA68_0 = input.LA(1);

                    		if ( ((LA68_0 >= 89 && LA68_0 <= 90)) )
                    		{
                    		    alt68 = 1;
                    		}
                    		switch (alt68) 
                    		{
                    		    case 1 :
                    		        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:450:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord_nooption2931);
                    		        	coord_modifier272 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_coord_modifier.Add(coord_modifier272.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal273=(IToken)Match(input,52,FOLLOW_52_in_coord_nooption2934); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_52.Add(char_literal273);

                    		PushFollow(FOLLOW_numberunit_in_coord_nooption2936);
                    		numberunit274 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_numberunit.Add(numberunit274.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord_nooption2938);
                    		coord_sep275 = coord_sep();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_sep.Add(coord_sep275.Tree);
                    		PushFollow(FOLLOW_numberunit_in_coord_nooption2940);
                    		numberunit276 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_numberunit.Add(numberunit276.Tree);
                    		char_literal277=(IToken)Match(input,53,FOLLOW_53_in_coord_nooption2942); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_53.Add(char_literal277);


                    	}



                    	// AST REWRITE
                    	// elements:          coord_sep, numberunit, coord_modifier
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 450:65: -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep )
                    	{
                    	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:450:68: ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:450:79: ( coord_modifier )?
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
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:451:5: ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' )
                    {
                    	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:451:5: ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' )
                    	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:451:7: ( coord_modifier )? '(' coord_part coord_sep coord_part ')'
                    	{
                    		// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:451:7: ( coord_modifier )?
                    		int alt69 = 2;
                    		int LA69_0 = input.LA(1);

                    		if ( ((LA69_0 >= 89 && LA69_0 <= 90)) )
                    		{
                    		    alt69 = 1;
                    		}
                    		switch (alt69) 
                    		{
                    		    case 1 :
                    		        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:451:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord_nooption2966);
                    		        	coord_modifier278 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_coord_modifier.Add(coord_modifier278.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal279=(IToken)Match(input,52,FOLLOW_52_in_coord_nooption2969); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_52.Add(char_literal279);

                    		PushFollow(FOLLOW_coord_part_in_coord_nooption2971);
                    		coord_part280 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_part.Add(coord_part280.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord_nooption2973);
                    		coord_sep281 = coord_sep();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_sep.Add(coord_sep281.Tree);
                    		PushFollow(FOLLOW_coord_part_in_coord_nooption2975);
                    		coord_part282 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_part.Add(coord_part282.Tree);
                    		char_literal283=(IToken)Match(input,53,FOLLOW_53_in_coord_nooption2977); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_53.Add(char_literal283);


                    	}



                    	// AST REWRITE
                    	// elements:          coord_modifier, coord_part, coord_sep
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 451:65: -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep )
                    	{
                    	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:451:68: ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:451:79: ( coord_modifier )?
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

            if ( state.backtracking==0 )
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
    // $ANTLR end "coord_nooption"

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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:460:1: coord_part : ( idd -> ^( IM_DONTCARE idd ) | '{' idd '}' -> ^( IM_DONTCARE '{' idd '}' ) | ( idd '=' numberunit ( ',' )? )+ -> ^( IM_DONTCARE ( idd '=' numberunit ( ',' )? )+ ) );
    public simpletikzParser.coord_part_return coord_part() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_part_return retval = new simpletikzParser.coord_part_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal285 = null;
        IToken char_literal287 = null;
        IToken char_literal289 = null;
        IToken char_literal291 = null;
        simpletikzParser.idd_return idd284 = default(simpletikzParser.idd_return);

        simpletikzParser.idd_return idd286 = default(simpletikzParser.idd_return);

        simpletikzParser.idd_return idd288 = default(simpletikzParser.idd_return);

        simpletikzParser.numberunit_return numberunit290 = default(simpletikzParser.numberunit_return);


        object char_literal285_tree=null;
        object char_literal287_tree=null;
        object char_literal289_tree=null;
        object char_literal291_tree=null;
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_47 = new RewriteRuleTokenStream(adaptor,"token 47");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:461:2: ( idd -> ^( IM_DONTCARE idd ) | '{' idd '}' -> ^( IM_DONTCARE '{' idd '}' ) | ( idd '=' numberunit ( ',' )? )+ -> ^( IM_DONTCARE ( idd '=' numberunit ( ',' )? )+ ) )
            int alt73 = 3;
            alt73 = dfa73.Predict(input);
            switch (alt73) 
            {
                case 1 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:461:4: idd
                    {
                    	PushFollow(FOLLOW_idd_in_coord_part3010);
                    	idd284 = idd();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_idd.Add(idd284.Tree);


                    	// AST REWRITE
                    	// elements:          idd
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 461:9: -> ^( IM_DONTCARE idd )
                    	{
                    	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:461:12: ^( IM_DONTCARE idd )
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
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:462:4: '{' idd '}'
                    {
                    	char_literal285=(IToken)Match(input,43,FOLLOW_43_in_coord_part3025); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_43.Add(char_literal285);

                    	PushFollow(FOLLOW_idd_in_coord_part3027);
                    	idd286 = idd();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_idd.Add(idd286.Tree);
                    	char_literal287=(IToken)Match(input,44,FOLLOW_44_in_coord_part3029); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_44.Add(char_literal287);



                    	// AST REWRITE
                    	// elements:          idd, 43, 44
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 462:16: -> ^( IM_DONTCARE '{' idd '}' )
                    	{
                    	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:462:19: ^( IM_DONTCARE '{' idd '}' )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DONTCARE, "IM_DONTCARE"), root_1);

                    	    adaptor.AddChild(root_1, stream_43.NextNode());
                    	    adaptor.AddChild(root_1, stream_idd.NextTree());
                    	    adaptor.AddChild(root_1, stream_44.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:463:4: ( idd '=' numberunit ( ',' )? )+
                    {
                    	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:463:4: ( idd '=' numberunit ( ',' )? )+
                    	int cnt72 = 0;
                    	do 
                    	{
                    	    int alt72 = 2;
                    	    int LA72_0 = input.LA(1);

                    	    if ( (LA72_0 == 78) )
                    	    {
                    	        int LA72_2 = input.LA(2);

                    	        if ( ((LA72_2 >= FLOAT_WO_EXP && LA72_2 <= INT)) )
                    	        {
                    	            int LA72_4 = input.LA(3);

                    	            if ( ((LA72_4 >= 57 && LA72_4 <= 62)) )
                    	            {
                    	                int LA72_5 = input.LA(4);

                    	                if ( ((LA72_5 >= IM_PATH && LA72_5 <= 42) || (LA72_5 >= 45 && LA72_5 <= 46) || LA72_5 == 51 || (LA72_5 >= 57 && LA72_5 <= 94)) )
                    	                {
                    	                    alt72 = 1;
                    	                }


                    	            }
                    	            else if ( ((LA72_4 >= IM_PATH && LA72_4 <= 42) || (LA72_4 >= 45 && LA72_4 <= 46) || LA72_4 == 51 || (LA72_4 >= 63 && LA72_4 <= 94)) )
                    	            {
                    	                alt72 = 1;
                    	            }


                    	        }
                    	        else if ( ((LA72_2 >= IM_PATH && LA72_2 <= COMMAND) || (LA72_2 >= WS && LA72_2 <= 42) || (LA72_2 >= 45 && LA72_2 <= 46) || LA72_2 == 51 || (LA72_2 >= 57 && LA72_2 <= 94)) )
                    	        {
                    	            alt72 = 1;
                    	        }


                    	    }
                    	    else if ( ((LA72_0 >= IM_PATH && LA72_0 <= 42) || LA72_0 == 46 || LA72_0 == 51 || (LA72_0 >= 57 && LA72_0 <= 77) || (LA72_0 >= 79 && LA72_0 <= 94)) )
                    	    {
                    	        alt72 = 1;
                    	    }


                    	    switch (alt72) 
                    		{
                    			case 1 :
                    			    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:463:5: idd '=' numberunit ( ',' )?
                    			    {
                    			    	PushFollow(FOLLOW_idd_in_coord_part3047);
                    			    	idd288 = idd();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking==0 ) stream_idd.Add(idd288.Tree);
                    			    	char_literal289=(IToken)Match(input,45,FOLLOW_45_in_coord_part3049); if (state.failed) return retval; 
                    			    	if ( state.backtracking==0 ) stream_45.Add(char_literal289);

                    			    	PushFollow(FOLLOW_numberunit_in_coord_part3051);
                    			    	numberunit290 = numberunit();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking==0 ) stream_numberunit.Add(numberunit290.Tree);
                    			    	// C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:463:24: ( ',' )?
                    			    	int alt71 = 2;
                    			    	int LA71_0 = input.LA(1);

                    			    	if ( (LA71_0 == 47) )
                    			    	{
                    			    	    alt71 = 1;
                    			    	}
                    			    	switch (alt71) 
                    			    	{
                    			    	    case 1 :
                    			    	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:463:24: ','
                    			    	        {
                    			    	        	char_literal291=(IToken)Match(input,47,FOLLOW_47_in_coord_part3053); if (state.failed) return retval; 
                    			    	        	if ( state.backtracking==0 ) stream_47.Add(char_literal291);


                    			    	        }
                    			    	        break;

                    			    	}


                    			    }
                    			    break;

                    			default:
                    			    if ( cnt72 >= 1 ) goto loop72;
                    			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    		            EarlyExitException eee =
                    		                new EarlyExitException(72, input);
                    		            throw eee;
                    	    }
                    	    cnt72++;
                    	} while (true);

                    	loop72:
                    		;	// Stops C# compiler whinging that label 'loop72' has no statements



                    	// AST REWRITE
                    	// elements:          47, numberunit, idd, 45
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 463:31: -> ^( IM_DONTCARE ( idd '=' numberunit ( ',' )? )+ )
                    	{
                    	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:463:34: ^( IM_DONTCARE ( idd '=' numberunit ( ',' )? )+ )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DONTCARE, "IM_DONTCARE"), root_1);

                    	    if ( !(stream_numberunit.HasNext() || stream_idd.HasNext() || stream_45.HasNext()) ) {
                    	        throw new RewriteEarlyExitException();
                    	    }
                    	    while ( stream_numberunit.HasNext() || stream_idd.HasNext() || stream_45.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_idd.NextTree());
                    	        adaptor.AddChild(root_1, stream_45.NextNode());
                    	        adaptor.AddChild(root_1, stream_numberunit.NextTree());
                    	        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:463:69: ( ',' )?
                    	        if ( stream_47.HasNext() )
                    	        {
                    	            adaptor.AddChild(root_1, stream_47.NextNode());

                    	        }
                    	        stream_47.Reset();

                    	    }
                    	    stream_numberunit.Reset();
                    	    stream_idd.Reset();
                    	    stream_45.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:465:1: coord_sep : ( ',' | ':' ) ;
    public simpletikzParser.coord_sep_return coord_sep() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_sep_return retval = new simpletikzParser.coord_sep_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set292 = null;

        object set292_tree=null;

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:466:2: ( ( ',' | ':' ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:466:4: ( ',' | ':' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set292 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 47 && input.LA(1) <= 48) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set292));
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

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:470:1: edgeop : ( '--' | '->' | '|-' | '-|' | ID );
    public simpletikzParser.edgeop_return edgeop() // throws RecognitionException [1]
    {   
        simpletikzParser.edgeop_return retval = new simpletikzParser.edgeop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set293 = null;

        object set293_tree=null;

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:471:2: ( '--' | '->' | '|-' | '-|' | ID )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set293 = (IToken)input.LT(1);
            	if ( input.LA(1) == ID || (input.LA(1) >= 85 && input.LA(1) <= 88) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set293));
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

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:475:1: coord_modifier : ( '+' | '++' );
    public simpletikzParser.coord_modifier_return coord_modifier() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_modifier_return retval = new simpletikzParser.coord_modifier_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set294 = null;

        object set294_tree=null;

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:476:2: ( '+' | '++' )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set294 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 89 && input.LA(1) <= 90) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set294));
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

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:518:1: squarebr_start : '[' -> ^( IM_STARTTAG '[' ) ;
    public simpletikzParser.squarebr_start_return squarebr_start() // throws RecognitionException [1]
    {   
        simpletikzParser.squarebr_start_return retval = new simpletikzParser.squarebr_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal295 = null;

        object char_literal295_tree=null;
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:519:2: ( '[' -> ^( IM_STARTTAG '[' ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:519:4: '['
            {
            	char_literal295=(IToken)Match(input,54,FOLLOW_54_in_squarebr_start3159); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_54.Add(char_literal295);



            	// AST REWRITE
            	// elements:          54
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 519:8: -> ^( IM_STARTTAG '[' )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:519:11: ^( IM_STARTTAG '[' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_54.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:521:1: squarebr_end : ']' -> ^( IM_ENDTAG ']' ) ;
    public simpletikzParser.squarebr_end_return squarebr_end() // throws RecognitionException [1]
    {   
        simpletikzParser.squarebr_end_return retval = new simpletikzParser.squarebr_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal296 = null;

        object char_literal296_tree=null;
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:522:2: ( ']' -> ^( IM_ENDTAG ']' ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:522:4: ']'
            {
            	char_literal296=(IToken)Match(input,55,FOLLOW_55_in_squarebr_end3177); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_55.Add(char_literal296);



            	// AST REWRITE
            	// elements:          55
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 522:8: -> ^( IM_ENDTAG ']' )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:522:11: ^( IM_ENDTAG ']' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_55.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:524:1: semicolon_end : ';' -> ^( IM_ENDTAG ';' ) ;
    public simpletikzParser.semicolon_end_return semicolon_end() // throws RecognitionException [1]
    {   
        simpletikzParser.semicolon_end_return retval = new simpletikzParser.semicolon_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal297 = null;

        object char_literal297_tree=null;
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:525:2: ( ';' -> ^( IM_ENDTAG ';' ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:525:4: ';'
            {
            	char_literal297=(IToken)Match(input,56,FOLLOW_56_in_semicolon_end3196); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_56.Add(char_literal297);



            	// AST REWRITE
            	// elements:          56
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 525:8: -> ^( IM_ENDTAG ';' )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:525:11: ^( IM_ENDTAG ';' )
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

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:527:1: roundbr_start : '{' -> ^( IM_STARTTAG '{' ) ;
    public simpletikzParser.roundbr_start_return roundbr_start() // throws RecognitionException [1]
    {   
        simpletikzParser.roundbr_start_return retval = new simpletikzParser.roundbr_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal298 = null;

        object char_literal298_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:528:2: ( '{' -> ^( IM_STARTTAG '{' ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:528:4: '{'
            {
            	char_literal298=(IToken)Match(input,43,FOLLOW_43_in_roundbr_start3214); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_43.Add(char_literal298);



            	// AST REWRITE
            	// elements:          43
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 528:8: -> ^( IM_STARTTAG '{' )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:528:11: ^( IM_STARTTAG '{' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_43.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:530:1: roundbr_end : '}' -> ^( IM_ENDTAG '}' ) ;
    public simpletikzParser.roundbr_end_return roundbr_end() // throws RecognitionException [1]
    {   
        simpletikzParser.roundbr_end_return retval = new simpletikzParser.roundbr_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal299 = null;

        object char_literal299_tree=null;
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:531:2: ( '}' -> ^( IM_ENDTAG '}' ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:531:4: '}'
            {
            	char_literal299=(IToken)Match(input,44,FOLLOW_44_in_roundbr_end3232); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_44.Add(char_literal299);



            	// AST REWRITE
            	// elements:          44
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 531:8: -> ^( IM_ENDTAG '}' )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:531:11: ^( IM_ENDTAG '}' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_44.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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

    public class controls_start_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "controls_start"
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:533:1: controls_start : '..' 'controls' -> ^( IM_STARTTAG '..' ) ;
    public simpletikzParser.controls_start_return controls_start() // throws RecognitionException [1]
    {   
        simpletikzParser.controls_start_return retval = new simpletikzParser.controls_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal300 = null;
        IToken string_literal301 = null;

        object string_literal300_tree=null;
        object string_literal301_tree=null;
        RewriteRuleTokenStream stream_92 = new RewriteRuleTokenStream(adaptor,"token 92");
        RewriteRuleTokenStream stream_91 = new RewriteRuleTokenStream(adaptor,"token 91");

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:534:2: ( '..' 'controls' -> ^( IM_STARTTAG '..' ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:534:4: '..' 'controls'
            {
            	string_literal300=(IToken)Match(input,91,FOLLOW_91_in_controls_start3250); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_91.Add(string_literal300);

            	string_literal301=(IToken)Match(input,92,FOLLOW_92_in_controls_start3252); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_92.Add(string_literal301);



            	// AST REWRITE
            	// elements:          91
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 534:20: -> ^( IM_STARTTAG '..' )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:534:23: ^( IM_STARTTAG '..' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_91.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // $ANTLR end "controls_start"

    public class controls_end_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "controls_end"
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:536:1: controls_end : '..' -> ^( IM_ENDTAG '..' ) ;
    public simpletikzParser.controls_end_return controls_end() // throws RecognitionException [1]
    {   
        simpletikzParser.controls_end_return retval = new simpletikzParser.controls_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal302 = null;

        object string_literal302_tree=null;
        RewriteRuleTokenStream stream_91 = new RewriteRuleTokenStream(adaptor,"token 91");

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:537:2: ( '..' -> ^( IM_ENDTAG '..' ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:537:4: '..'
            {
            	string_literal302=(IToken)Match(input,91,FOLLOW_91_in_controls_end3270); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_91.Add(string_literal302);



            	// AST REWRITE
            	// elements:          91
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 537:9: -> ^( IM_ENDTAG '..' )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:537:12: ^( IM_ENDTAG '..' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_91.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // $ANTLR end "controls_end"

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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:539:1: tikz_set_start : '\\\\tikzset' '{' -> ^( IM_STARTTAG ) ;
    public simpletikzParser.tikz_set_start_return tikz_set_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_set_start_return retval = new simpletikzParser.tikz_set_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal303 = null;
        IToken char_literal304 = null;

        object string_literal303_tree=null;
        object char_literal304_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:540:2: ( '\\\\tikzset' '{' -> ^( IM_STARTTAG ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:540:4: '\\\\tikzset' '{'
            {
            	string_literal303=(IToken)Match(input,41,FOLLOW_41_in_tikz_set_start3288); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_41.Add(string_literal303);

            	char_literal304=(IToken)Match(input,43,FOLLOW_43_in_tikz_set_start3290); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_43.Add(char_literal304);



            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 540:21: -> ^( IM_STARTTAG )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:540:24: ^( IM_STARTTAG )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:542:1: tikzpicture_start : '\\\\begin' '{' 'tikzpicture' '}' -> ^( IM_STARTTAG '\\\\begin' ) ;
    public simpletikzParser.tikzpicture_start_return tikzpicture_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_start_return retval = new simpletikzParser.tikzpicture_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal305 = null;
        IToken char_literal306 = null;
        IToken string_literal307 = null;
        IToken char_literal308 = null;

        object string_literal305_tree=null;
        object char_literal306_tree=null;
        object string_literal307_tree=null;
        object char_literal308_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_93 = new RewriteRuleTokenStream(adaptor,"token 93");
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:543:2: ( '\\\\begin' '{' 'tikzpicture' '}' -> ^( IM_STARTTAG '\\\\begin' ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:543:4: '\\\\begin' '{' 'tikzpicture' '}'
            {
            	string_literal305=(IToken)Match(input,39,FOLLOW_39_in_tikzpicture_start3309); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_39.Add(string_literal305);

            	char_literal306=(IToken)Match(input,43,FOLLOW_43_in_tikzpicture_start3311); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_43.Add(char_literal306);

            	string_literal307=(IToken)Match(input,93,FOLLOW_93_in_tikzpicture_start3313); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_93.Add(string_literal307);

            	char_literal308=(IToken)Match(input,44,FOLLOW_44_in_tikzpicture_start3315); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_44.Add(char_literal308);



            	// AST REWRITE
            	// elements:          39
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 543:36: -> ^( IM_STARTTAG '\\\\begin' )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:543:39: ^( IM_STARTTAG '\\\\begin' )
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

            if ( state.backtracking==0 )
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

    public class tikz_start_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikz_start"
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:545:1: tikz_start : '\\\\tikz' -> ^( IM_STARTTAG '\\\\tikz' ) ;
    public simpletikzParser.tikz_start_return tikz_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_start_return retval = new simpletikzParser.tikz_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal309 = null;

        object string_literal309_tree=null;
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:546:2: ( '\\\\tikz' -> ^( IM_STARTTAG '\\\\tikz' ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:546:4: '\\\\tikz'
            {
            	string_literal309=(IToken)Match(input,42,FOLLOW_42_in_tikz_start3333); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_42.Add(string_literal309);



            	// AST REWRITE
            	// elements:          42
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 546:13: -> ^( IM_STARTTAG '\\\\tikz' )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:546:16: ^( IM_STARTTAG '\\\\tikz' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_42.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // $ANTLR end "tikz_start"

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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:548:1: tikzpicture_end : '\\\\end' '{' 'tikzpicture' '}' -> ^( IM_ENDTAG '\\\\end' ) ;
    public simpletikzParser.tikzpicture_end_return tikzpicture_end() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_end_return retval = new simpletikzParser.tikzpicture_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal310 = null;
        IToken char_literal311 = null;
        IToken string_literal312 = null;
        IToken char_literal313 = null;

        object string_literal310_tree=null;
        object char_literal311_tree=null;
        object string_literal312_tree=null;
        object char_literal313_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_93 = new RewriteRuleTokenStream(adaptor,"token 93");
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_63 = new RewriteRuleTokenStream(adaptor,"token 63");

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:549:2: ( '\\\\end' '{' 'tikzpicture' '}' -> ^( IM_ENDTAG '\\\\end' ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:549:4: '\\\\end' '{' 'tikzpicture' '}'
            {
            	string_literal310=(IToken)Match(input,63,FOLLOW_63_in_tikzpicture_end3351); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_63.Add(string_literal310);

            	char_literal311=(IToken)Match(input,43,FOLLOW_43_in_tikzpicture_end3353); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_43.Add(char_literal311);

            	string_literal312=(IToken)Match(input,93,FOLLOW_93_in_tikzpicture_end3355); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_93.Add(string_literal312);

            	char_literal313=(IToken)Match(input,44,FOLLOW_44_in_tikzpicture_end3357); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_44.Add(char_literal313);



            	// AST REWRITE
            	// elements:          63
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 549:34: -> ^( IM_ENDTAG '\\\\end' )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:549:37: ^( IM_ENDTAG '\\\\end' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_63.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:551:1: tikzscope_start : '\\\\begin' '{' 'scope' '}' -> ^( IM_STARTTAG '\\\\begin' ) ;
    public simpletikzParser.tikzscope_start_return tikzscope_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_start_return retval = new simpletikzParser.tikzscope_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal314 = null;
        IToken char_literal315 = null;
        IToken string_literal316 = null;
        IToken char_literal317 = null;

        object string_literal314_tree=null;
        object char_literal315_tree=null;
        object string_literal316_tree=null;
        object char_literal317_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_94 = new RewriteRuleTokenStream(adaptor,"token 94");
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:552:2: ( '\\\\begin' '{' 'scope' '}' -> ^( IM_STARTTAG '\\\\begin' ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:552:4: '\\\\begin' '{' 'scope' '}'
            {
            	string_literal314=(IToken)Match(input,39,FOLLOW_39_in_tikzscope_start3375); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_39.Add(string_literal314);

            	char_literal315=(IToken)Match(input,43,FOLLOW_43_in_tikzscope_start3377); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_43.Add(char_literal315);

            	string_literal316=(IToken)Match(input,94,FOLLOW_94_in_tikzscope_start3379); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_94.Add(string_literal316);

            	char_literal317=(IToken)Match(input,44,FOLLOW_44_in_tikzscope_start3381); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_44.Add(char_literal317);



            	// AST REWRITE
            	// elements:          39
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 552:30: -> ^( IM_STARTTAG '\\\\begin' )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:552:33: ^( IM_STARTTAG '\\\\begin' )
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

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:554:1: tikzscope_end : '\\\\end' '{' 'scope' '}' -> ^( IM_ENDTAG '\\\\end' ) ;
    public simpletikzParser.tikzscope_end_return tikzscope_end() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_end_return retval = new simpletikzParser.tikzscope_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal318 = null;
        IToken char_literal319 = null;
        IToken string_literal320 = null;
        IToken char_literal321 = null;

        object string_literal318_tree=null;
        object char_literal319_tree=null;
        object string_literal320_tree=null;
        object char_literal321_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_94 = new RewriteRuleTokenStream(adaptor,"token 94");
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_63 = new RewriteRuleTokenStream(adaptor,"token 63");

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:555:2: ( '\\\\end' '{' 'scope' '}' -> ^( IM_ENDTAG '\\\\end' ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:555:4: '\\\\end' '{' 'scope' '}'
            {
            	string_literal318=(IToken)Match(input,63,FOLLOW_63_in_tikzscope_end3399); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_63.Add(string_literal318);

            	char_literal319=(IToken)Match(input,43,FOLLOW_43_in_tikzscope_end3401); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_43.Add(char_literal319);

            	string_literal320=(IToken)Match(input,94,FOLLOW_94_in_tikzscope_end3403); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_94.Add(string_literal320);

            	char_literal321=(IToken)Match(input,44,FOLLOW_44_in_tikzscope_end3405); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_44.Add(char_literal321);



            	// AST REWRITE
            	// elements:          63
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 555:28: -> ^( IM_ENDTAG '\\\\end' )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:555:31: ^( IM_ENDTAG '\\\\end' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_63.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:557:1: path_start : path_start_tag -> ^( IM_STARTTAG path_start_tag ) ;
    public simpletikzParser.path_start_return path_start() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_return retval = new simpletikzParser.path_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.path_start_tag_return path_start_tag322 = default(simpletikzParser.path_start_tag_return);


        RewriteRuleSubtreeStream stream_path_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule path_start_tag");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:558:2: ( path_start_tag -> ^( IM_STARTTAG path_start_tag ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:558:4: path_start_tag
            {
            	PushFollow(FOLLOW_path_start_tag_in_path_start3424);
            	path_start_tag322 = path_start_tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_path_start_tag.Add(path_start_tag322.Tree);


            	// AST REWRITE
            	// elements:          path_start_tag
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 558:19: -> ^( IM_STARTTAG path_start_tag )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:558:22: ^( IM_STARTTAG path_start_tag )
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

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:560:1: node_start : node_start_tag -> ^( IM_STARTTAG node_start_tag ) ;
    public simpletikzParser.node_start_return node_start() // throws RecognitionException [1]
    {   
        simpletikzParser.node_start_return retval = new simpletikzParser.node_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.node_start_tag_return node_start_tag323 = default(simpletikzParser.node_start_tag_return);


        RewriteRuleSubtreeStream stream_node_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule node_start_tag");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:561:2: ( node_start_tag -> ^( IM_STARTTAG node_start_tag ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:561:4: node_start_tag
            {
            	PushFollow(FOLLOW_node_start_tag_in_node_start3442);
            	node_start_tag323 = node_start_tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_node_start_tag.Add(node_start_tag323.Tree);


            	// AST REWRITE
            	// elements:          node_start_tag
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 561:19: -> ^( IM_STARTTAG node_start_tag )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:561:22: ^( IM_STARTTAG node_start_tag )
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

            if ( state.backtracking==0 )
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

    public class def_start_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "def_start"
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:563:1: def_start : def_start_tag -> ^( IM_STARTTAG def_start_tag ) ;
    public simpletikzParser.def_start_return def_start() // throws RecognitionException [1]
    {   
        simpletikzParser.def_start_return retval = new simpletikzParser.def_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.def_start_tag_return def_start_tag324 = default(simpletikzParser.def_start_tag_return);


        RewriteRuleSubtreeStream stream_def_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule def_start_tag");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:564:2: ( def_start_tag -> ^( IM_STARTTAG def_start_tag ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:564:4: def_start_tag
            {
            	PushFollow(FOLLOW_def_start_tag_in_def_start3460);
            	def_start_tag324 = def_start_tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_def_start_tag.Add(def_start_tag324.Tree);


            	// AST REWRITE
            	// elements:          def_start_tag
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 564:18: -> ^( IM_STARTTAG def_start_tag )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:564:21: ^( IM_STARTTAG def_start_tag )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_def_start_tag.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // $ANTLR end "def_start"

    public class matrix_start_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "matrix_start"
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:566:1: matrix_start : matrix_start_tag -> ^( IM_STARTTAG matrix_start_tag ) ;
    public simpletikzParser.matrix_start_return matrix_start() // throws RecognitionException [1]
    {   
        simpletikzParser.matrix_start_return retval = new simpletikzParser.matrix_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.matrix_start_tag_return matrix_start_tag325 = default(simpletikzParser.matrix_start_tag_return);


        RewriteRuleSubtreeStream stream_matrix_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule matrix_start_tag");
        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:567:2: ( matrix_start_tag -> ^( IM_STARTTAG matrix_start_tag ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:567:4: matrix_start_tag
            {
            	PushFollow(FOLLOW_matrix_start_tag_in_matrix_start3478);
            	matrix_start_tag325 = matrix_start_tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_matrix_start_tag.Add(matrix_start_tag325.Tree);


            	// AST REWRITE
            	// elements:          matrix_start_tag
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 567:21: -> ^( IM_STARTTAG matrix_start_tag )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:567:24: ^( IM_STARTTAG matrix_start_tag )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_matrix_start_tag.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // $ANTLR end "matrix_start"

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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:569:1: node_start_tag : '\\\\node' ;
    public simpletikzParser.node_start_tag_return node_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.node_start_tag_return retval = new simpletikzParser.node_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal326 = null;

        object string_literal326_tree=null;

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:570:2: ( '\\\\node' )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:570:4: '\\\\node'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal326=(IToken)Match(input,64,FOLLOW_64_in_node_start_tag3496); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal326_tree = (object)adaptor.Create(string_literal326);
            		adaptor.AddChild(root_0, string_literal326_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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

    public class def_start_tag_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "def_start_tag"
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:572:1: def_start_tag : '\\\\def' ;
    public simpletikzParser.def_start_tag_return def_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.def_start_tag_return retval = new simpletikzParser.def_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal327 = null;

        object string_literal327_tree=null;

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:573:2: ( '\\\\def' )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:573:4: '\\\\def'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal327=(IToken)Match(input,69,FOLLOW_69_in_def_start_tag3506); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal327_tree = (object)adaptor.Create(string_literal327);
            		adaptor.AddChild(root_0, string_literal327_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // $ANTLR end "def_start_tag"

    public class matrix_start_tag_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "matrix_start_tag"
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:575:1: matrix_start_tag : '\\\\matrix' ;
    public simpletikzParser.matrix_start_tag_return matrix_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.matrix_start_tag_return retval = new simpletikzParser.matrix_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal328 = null;

        object string_literal328_tree=null;

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:576:2: ( '\\\\matrix' )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:576:4: '\\\\matrix'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal328=(IToken)Match(input,65,FOLLOW_65_in_matrix_start_tag3516); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal328_tree = (object)adaptor.Create(string_literal328);
            		adaptor.AddChild(root_0, string_literal328_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // $ANTLR end "matrix_start_tag"

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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:578:1: coordinate_start : '\\\\coordinate' -> ^( IM_STARTTAG '\\\\coordinate' ) ;
    public simpletikzParser.coordinate_start_return coordinate_start() // throws RecognitionException [1]
    {   
        simpletikzParser.coordinate_start_return retval = new simpletikzParser.coordinate_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal329 = null;

        object string_literal329_tree=null;
        RewriteRuleTokenStream stream_66 = new RewriteRuleTokenStream(adaptor,"token 66");

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:579:2: ( '\\\\coordinate' -> ^( IM_STARTTAG '\\\\coordinate' ) )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:579:4: '\\\\coordinate'
            {
            	string_literal329=(IToken)Match(input,66,FOLLOW_66_in_coordinate_start3526); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_66.Add(string_literal329);



            	// AST REWRITE
            	// elements:          66
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 579:19: -> ^( IM_STARTTAG '\\\\coordinate' )
            	{
            	    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:579:22: ^( IM_STARTTAG '\\\\coordinate' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_66.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:581:1: path_start_tag : ( '\\\\draw' | '\\\\fill' | '\\\\path' | '\\\\clip' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' );
    public simpletikzParser.path_start_tag_return path_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_tag_return retval = new simpletikzParser.path_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set330 = null;

        object set330_tree=null;

        try 
    	{
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:582:2: ( '\\\\draw' | '\\\\fill' | '\\\\path' | '\\\\clip' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' )
            // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set330 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 67 && input.LA(1) <= 68) || (input.LA(1) >= 70 && input.LA(1) <= 76) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set330));
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

            if ( state.backtracking==0 )
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
        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:331:5: ( coord )
        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:331:6: coord
        {
        	PushFollow(FOLLOW_coord_in_synpred1_simpletikz1878);
        	coord();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred1_simpletikz"

    // $ANTLR start "synpred2_simpletikz"
    public void synpred2_simpletikz_fragment() {
        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:359:8: ( tikzcoordinate_core3 )
        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:359:9: tikzcoordinate_core3
        {
        	PushFollow(FOLLOW_tikzcoordinate_core3_in_synpred2_simpletikz2121);
        	tikzcoordinate_core3();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred2_simpletikz"

    // $ANTLR start "synpred3_simpletikz"
    public void synpred3_simpletikz_fragment() {
        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:360:12: ( tikzcoordinate_core2 )
        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:360:13: tikzcoordinate_core2
        {
        	PushFollow(FOLLOW_tikzcoordinate_core2_in_synpred3_simpletikz2140);
        	tikzcoordinate_core2();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred3_simpletikz"

    // $ANTLR start "synpred4_simpletikz"
    public void synpred4_simpletikz_fragment() {
        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:361:12: ( tikzcoordinate_core1 )
        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:361:13: tikzcoordinate_core1
        {
        	PushFollow(FOLLOW_tikzcoordinate_core1_in_synpred4_simpletikz2160);
        	tikzcoordinate_core1();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred4_simpletikz"

    // $ANTLR start "synpred5_simpletikz"
    public void synpred5_simpletikz_fragment() {
        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:370:21: ( tikzcoordinate_core3 )
        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:370:22: tikzcoordinate_core3
        {
        	PushFollow(FOLLOW_tikzcoordinate_core3_in_synpred5_simpletikz2245);
        	tikzcoordinate_core3();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred5_simpletikz"

    // $ANTLR start "synpred6_simpletikz"
    public void synpred6_simpletikz_fragment() {
        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:371:12: ( tikzcoordinate_core2 )
        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:371:13: tikzcoordinate_core2
        {
        	PushFollow(FOLLOW_tikzcoordinate_core2_in_synpred6_simpletikz2264);
        	tikzcoordinate_core2();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred6_simpletikz"

    // $ANTLR start "synpred7_simpletikz"
    public void synpred7_simpletikz_fragment() {
        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:372:12: ( tikzcoordinate_core1 )
        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:372:13: tikzcoordinate_core1
        {
        	PushFollow(FOLLOW_tikzcoordinate_core1_in_synpred7_simpletikz2284);
        	tikzcoordinate_core1();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred7_simpletikz"

    // $ANTLR start "synpred8_simpletikz"
    public void synpred8_simpletikz_fragment() {
        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:420:28: ( size )
        // C:\\_TUHH\\SVN\\projects\\wsn\\dibus\\SvgMap\\SvgNaviMap\\bargraph\\tikzedt\\TikzParser\\simpletikz.g:420:29: size
        {
        	PushFollow(FOLLOW_size_in_synpred8_simpletikz2576);
        	size();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred8_simpletikz"

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
   	public bool synpred8_simpletikz() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred8_simpletikz_fragment(); // can never throw exception
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


   	protected DFA10 dfa10;
   	protected DFA16 dfa16;
   	protected DFA33 dfa33;
   	protected DFA34 dfa34;
   	protected DFA35 dfa35;
   	protected DFA36 dfa36;
   	protected DFA43 dfa43;
   	protected DFA48 dfa48;
   	protected DFA50 dfa50;
   	protected DFA57 dfa57;
   	protected DFA60 dfa60;
   	protected DFA67 dfa67;
   	protected DFA70 dfa70;
   	protected DFA73 dfa73;
	private void InitializeCyclicDFAs()
	{
    	this.dfa10 = new DFA10(this);
    	this.dfa16 = new DFA16(this);
    	this.dfa33 = new DFA33(this);
    	this.dfa34 = new DFA34(this);
    	this.dfa35 = new DFA35(this);
    	this.dfa36 = new DFA36(this);
    	this.dfa43 = new DFA43(this);
    	this.dfa48 = new DFA48(this);
    	this.dfa50 = new DFA50(this);
    	this.dfa57 = new DFA57(this);
    	this.dfa60 = new DFA60(this);
    	this.dfa67 = new DFA67(this);
    	this.dfa70 = new DFA70(this);
    	this.dfa73 = new DFA73(this);






	    this.dfa43.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA43_SpecialStateTransition);
	    this.dfa48.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA48_SpecialStateTransition);
	    this.dfa50.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA50_SpecialStateTransition);
	    this.dfa57.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA57_SpecialStateTransition);




	}

    const string DFA10_eotS =
        "\x04\uffff";
    const string DFA10_eofS =
        "\x04\uffff";
    const string DFA10_minS =
        "\x02\x04\x02\uffff";
    const string DFA10_maxS =
        "\x02\x5e\x02\uffff";
    const string DFA10_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA10_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA10_transitionS = {
            "\x27\x01\x03\uffff\x01\x01\x04\uffff\x01\x01\x05\uffff\x26"+
            "\x01",
            "\x27\x01\x03\x02\x01\x01\x01\x02\x01\uffff\x02\x03\x01\x01"+
            "\x03\uffff\x01\x02\x01\uffff\x26\x01",
            "",
            ""
    };

    static readonly short[] DFA10_eot = DFA.UnpackEncodedString(DFA10_eotS);
    static readonly short[] DFA10_eof = DFA.UnpackEncodedString(DFA10_eofS);
    static readonly char[] DFA10_min = DFA.UnpackEncodedStringToUnsignedChars(DFA10_minS);
    static readonly char[] DFA10_max = DFA.UnpackEncodedStringToUnsignedChars(DFA10_maxS);
    static readonly short[] DFA10_accept = DFA.UnpackEncodedString(DFA10_acceptS);
    static readonly short[] DFA10_special = DFA.UnpackEncodedString(DFA10_specialS);
    static readonly short[][] DFA10_transition = DFA.UnpackEncodedStringArray(DFA10_transitionS);

    protected class DFA10 : DFA
    {
        public DFA10(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 10;
            this.eot = DFA10_eot;
            this.eof = DFA10_eof;
            this.min = DFA10_min;
            this.max = DFA10_max;
            this.accept = DFA10_accept;
            this.special = DFA10_special;
            this.transition = DFA10_transition;

        }

        override public string Description
        {
            get { return "171:1: option : ( option_style | option_kv );"; }
        }

    }

    const string DFA16_eotS =
        "\x39\uffff";
    const string DFA16_eofS =
        "\x39\uffff";
    const string DFA16_minS =
        "\x01\x04\x01\x2b\x01\x04\x01\uffff\x01\x2b\x01\x1e\x01\uffff\x01"+
        "\x04\x01\uffff\x01\x04\x01\uffff\x11\x04\x01\uffff\x1c\x04";
    const string DFA16_maxS =
        "\x01\x5e\x01\x3e\x01\x5e\x01\uffff\x01\x37\x01\x2b\x01\uffff\x01"+
        "\x5e\x01\uffff\x01\x5e\x01\uffff\x11\x5e\x01\uffff\x1c\x5e";
    const string DFA16_acceptS =
        "\x03\uffff\x01\x04\x02\uffff\x01\x02\x01\uffff\x01\x05\x01\uffff"+
        "\x01\x01\x11\uffff\x01\x03\x1c\uffff";
    const string DFA16_specialS =
        "\x39\uffff}>";
    static readonly string[] DFA16_transitionS = {
            "\x1a\x03\x02\x01\x0b\x03\x01\x02\x02\uffff\x01\x03\x04\uffff"+
            "\x01\x03\x05\uffff\x26\x03",
            "\x02\x06\x02\uffff\x01\x06\x01\x05\x06\uffff\x01\x06\x01\uffff"+
            "\x06\x04",
            "\x30\x08\x01\x07\x24\x08\x02\x09\x04\x08",
            "",
            "\x02\x06\x02\uffff\x01\x06\x01\x0a\x06\uffff\x01\x06",
            "\x02\x0a\x0b\uffff\x01\x08",
            "",
            "\x1a\x0d\x02\x0c\x0b\x0d\x01\x0b\x02\x08\x01\x0d\x04\x08\x01"+
            "\x0d\x05\x08\x26\x0d",
            "",
            "\x30\x08\x01\x0e\x2a\x08",
            "",
            "\x27\x0f\x03\x08\x01\x0f\x04\x08\x01\x0f\x05\x08\x26\x0f",
            "\x27\x0d\x02\x08\x01\x12\x01\x0d\x02\x11\x02\x08\x01\x0d\x01"+
            "\x08\x01\x13\x03\x08\x06\x10\x20\x0d",
            "\x27\x0d\x02\x08\x01\x12\x01\x0d\x02\x14\x02\x08\x01\x0d\x01"+
            "\x08\x01\x13\x03\x08\x26\x0d",
            "\x1a\x16\x02\x15\x0b\x16\x01\x0b\x02\x08\x01\x16\x04\x08\x01"+
            "\x16\x05\x08\x26\x16",
            "\x27\x0f\x01\x08\x01\x17\x01\x08\x01\x0f\x04\x08\x01\x0f\x05"+
            "\x08\x26\x0f",
            "\x27\x0d\x02\x08\x01\x12\x01\x0d\x02\x11\x02\x08\x01\x0d\x01"+
            "\x08\x01\x13\x03\x08\x26\x0d",
            "\x1a\x1a\x02\x19\x0b\x1a\x01\x18\x02\x08\x01\x1a\x04\x08\x01"+
            "\x1a\x05\x08\x26\x1a",
            "\x1a\x08\x02\x1b\x3f\x08",
            "\x28\x08\x01\x1c\x32\x08",
            "\x27\x1a\x01\x18\x02\x08\x01\x1a\x04\x08\x01\x1a\x05\x08\x26"+
            "\x1a",
            "\x27\x16\x02\x08\x01\x12\x01\x16\x02\x11\x02\x08\x01\x16\x05"+
            "\x08\x06\x1d\x20\x16",
            "\x27\x16\x02\x08\x01\x12\x01\x16\x02\x14\x02\x08\x01\x16\x05"+
            "\x08\x26\x16",
            "\x2b\x08\x02\x1e\x2e\x08",
            "\x27\x1f\x03\x08\x01\x1f\x04\x08\x01\x1f\x05\x08\x26\x1f",
            "\x27\x1a\x02\x08\x01\x20\x01\x1a\x04\x08\x01\x1a\x01\x08\x01"+
            "\x22\x03\x08\x06\x21\x20\x1a",
            "\x27\x1a\x02\x08\x01\x20\x01\x1a\x04\x08\x01\x1a\x01\x08\x01"+
            "\x23\x03\x08\x26\x1a",
            "\x27\x26\x03\x08\x01\x26\x01\x25\x01\x14\x02\x08\x01\x26\x05"+
            "\x08\x06\x24\x20\x26",
            "",
            "\x27\x16\x02\x08\x01\x12\x01\x16\x02\x11\x02\x08\x01\x16\x05"+
            "\x08\x26\x16",
            "\x27\x27\x01\x18\x02\x08\x01\x27\x04\x08\x01\x27\x05\x08\x26"+
            "\x27",
            "\x27\x1f\x01\x08\x01\x28\x01\x08\x01\x1f\x04\x08\x01\x1f\x05"+
            "\x08\x26\x1f",
            "\x1a\x08\x02\x29\x3f\x08",
            "\x27\x1a\x02\x08\x01\x20\x01\x1a\x04\x08\x01\x1a\x01\x08\x01"+
            "\x22\x03\x08\x26\x1a",
            "\x28\x08\x01\x1c\x32\x08",
            "\x28\x08\x01\x1c\x32\x08",
            "\x27\x26\x02\x08\x01\x12\x01\x26\x01\x25\x01\x14\x02\x08\x01"+
            "\x26\x05\x08\x26\x26",
            "\x27\x2a\x01\x18\x02\x08\x01\x2a\x02\x14\x02\x08\x01\x2a\x05"+
            "\x08\x26\x2a",
            "\x27\x26\x02\x08\x01\x12\x01\x26\x04\x08\x01\x26\x05\x08\x26"+
            "\x26",
            "\x27\x27\x02\x08\x01\x2b\x01\x27\x04\x08\x01\x27\x01\x08\x01"+
            "\x2c\x03\x08\x26\x27",
            "\x31\x08\x01\x2c\x29\x08",
            "\x27\x2f\x03\x08\x01\x2f\x01\x2e\x03\x08\x01\x2f\x01\x08\x01"+
            "\x23\x03\x08\x06\x2d\x20\x2f",
            "\x27\x2a\x02\x08\x01\x30\x01\x2a\x04\x08\x01\x2a\x01\x08\x01"+
            "\x23\x03\x08\x26\x2a",
            "\x1a\x08\x02\x31\x3f\x08",
            "\x28\x08\x01\x1c\x32\x08",
            "\x27\x2f\x02\x08\x01\x20\x01\x2f\x01\x2e\x03\x08\x01\x2f\x01"+
            "\x08\x01\x23\x03\x08\x26\x2f",
            "\x27\x2f\x03\x08\x01\x2f\x04\x08\x01\x2f\x01\x08\x01\x23\x03"+
            "\x08\x26\x2f",
            "\x27\x2f\x02\x08\x01\x20\x01\x2f\x04\x08\x01\x2f\x05\x08\x26"+
            "\x2f",
            "\x1a\x08\x02\x32\x3f\x08",
            "\x27\x35\x03\x08\x01\x35\x01\x34\x03\x08\x01\x35\x01\x08\x01"+
            "\x2c\x03\x08\x06\x33\x20\x35",
            "\x27\x38\x03\x08\x01\x38\x01\x37\x01\x14\x02\x08\x01\x38\x01"+
            "\x08\x01\x23\x03\x08\x06\x36\x20\x38",
            "\x27\x35\x02\x08\x01\x2b\x01\x35\x01\x34\x03\x08\x01\x35\x01"+
            "\x08\x01\x2c\x03\x08\x26\x35",
            "\x27\x35\x03\x08\x01\x35\x04\x08\x01\x35\x01\x08\x01\x2c\x03"+
            "\x08\x26\x35",
            "\x27\x35\x02\x08\x01\x2b\x01\x35\x04\x08\x01\x35\x05\x08\x26"+
            "\x35",
            "\x27\x38\x02\x08\x01\x30\x01\x38\x01\x37\x01\x14\x02\x08\x01"+
            "\x38\x01\x08\x01\x23\x03\x08\x26\x38",
            "\x27\x2a\x01\x18\x02\x08\x01\x2a\x02\x14\x02\x08\x01\x2a\x01"+
            "\x08\x01\x23\x03\x08\x26\x2a",
            "\x27\x38\x02\x08\x01\x30\x01\x38\x04\x08\x01\x38\x05\x08\x26"+
            "\x38"
    };

    static readonly short[] DFA16_eot = DFA.UnpackEncodedString(DFA16_eotS);
    static readonly short[] DFA16_eof = DFA.UnpackEncodedString(DFA16_eofS);
    static readonly char[] DFA16_min = DFA.UnpackEncodedStringToUnsignedChars(DFA16_minS);
    static readonly char[] DFA16_max = DFA.UnpackEncodedStringToUnsignedChars(DFA16_maxS);
    static readonly short[] DFA16_accept = DFA.UnpackEncodedString(DFA16_acceptS);
    static readonly short[] DFA16_special = DFA.UnpackEncodedString(DFA16_specialS);
    static readonly short[][] DFA16_transition = DFA.UnpackEncodedStringArray(DFA16_transitionS);

    protected class DFA16 : DFA
    {
        public DFA16(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 16;
            this.eot = DFA16_eot;
            this.eof = DFA16_eof;
            this.min = DFA16_min;
            this.max = DFA16_max;
            this.accept = DFA16_accept;
            this.special = DFA16_special;
            this.transition = DFA16_transition;

        }

        override public string Description
        {
            get { return "187:1: iddornumberunitorstringorrange : ( range | numberunit | bracedcoord | idd | ( ( number ':' )? tikzstring ) );"; }
        }

    }

    const string DFA33_eotS =
        "\x0e\uffff";
    const string DFA33_eofS =
        "\x0e\uffff";
    const string DFA33_minS =
        "\x01\x04\x01\x2b\x09\uffff\x01\x1c\x02\uffff";
    const string DFA33_maxS =
        "\x01\x5e\x01\x2b\x09\uffff\x01\x5e\x02\uffff";
    const string DFA33_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07\x01"+
        "\x08\x01\x0a\x01\x0b\x01\uffff\x01\x01\x01\x09";
    const string DFA33_specialS =
        "\x0e\uffff}>";
    static readonly string[] DFA33_transitionS = {
            "\x23\x0a\x01\x01\x01\x08\x01\x07\x0c\x0a\x01\uffff\x08\x0a"+
            "\x01\x09\x01\x03\x01\x05\x01\x06\x02\x02\x01\x04\x07\x02\x12"+
            "\x0a",
            "\x01\x0b",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0d\x41\uffff\x01\x0c",
            "",
            ""
    };

    static readonly short[] DFA33_eot = DFA.UnpackEncodedString(DFA33_eotS);
    static readonly short[] DFA33_eof = DFA.UnpackEncodedString(DFA33_eofS);
    static readonly char[] DFA33_min = DFA.UnpackEncodedStringToUnsignedChars(DFA33_minS);
    static readonly char[] DFA33_max = DFA.UnpackEncodedStringToUnsignedChars(DFA33_maxS);
    static readonly short[] DFA33_accept = DFA.UnpackEncodedString(DFA33_acceptS);
    static readonly short[] DFA33_special = DFA.UnpackEncodedString(DFA33_specialS);
    static readonly short[][] DFA33_transition = DFA.UnpackEncodedStringArray(DFA33_transitionS);

    protected class DFA33 : DFA
    {
        public DFA33(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 33;
            this.eot = DFA33_eot;
            this.eof = DFA33_eof;
            this.min = DFA33_min;
            this.max = DFA33_max;
            this.accept = DFA33_accept;
            this.special = DFA33_special;
            this.transition = DFA33_transition;

        }

        override public string Description
        {
            get { return "248:4: ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr )"; }
        }

    }

    const string DFA34_eotS =
        "\x11\uffff";
    const string DFA34_eofS =
        "\x11\uffff";
    const string DFA34_minS =
        "\x01\x04\x02\x2b\x08\uffff\x02\x1c\x04\uffff";
    const string DFA34_maxS =
        "\x01\x5e\x02\x2b\x08\uffff\x02\x5e\x04\uffff";
    const string DFA34_acceptS =
        "\x03\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07\x01"+
        "\x08\x01\x0b\x02\uffff\x01\x0c\x01\x0a\x01\x01\x01\x09";
    const string DFA34_specialS =
        "\x11\uffff}>";
    static readonly string[] DFA34_transitionS = {
            "\x23\x0a\x01\x02\x01\x09\x01\x08\x15\x0a\x01\x01\x01\x04\x01"+
            "\x06\x01\x07\x02\x03\x01\x05\x07\x03\x12\x0a",
            "\x01\x0b",
            "\x01\x0c",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0e\x40\uffff\x02\x0d",
            "\x01\x10\x41\uffff\x01\x0f",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA34_eot = DFA.UnpackEncodedString(DFA34_eotS);
    static readonly short[] DFA34_eof = DFA.UnpackEncodedString(DFA34_eofS);
    static readonly char[] DFA34_min = DFA.UnpackEncodedStringToUnsignedChars(DFA34_minS);
    static readonly char[] DFA34_max = DFA.UnpackEncodedStringToUnsignedChars(DFA34_maxS);
    static readonly short[] DFA34_accept = DFA.UnpackEncodedString(DFA34_acceptS);
    static readonly short[] DFA34_special = DFA.UnpackEncodedString(DFA34_specialS);
    static readonly short[][] DFA34_transition = DFA.UnpackEncodedStringArray(DFA34_transitionS);

    protected class DFA34 : DFA
    {
        public DFA34(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 34;
            this.eot = DFA34_eot;
            this.eof = DFA34_eof;
            this.min = DFA34_min;
            this.max = DFA34_max;
            this.accept = DFA34_accept;
            this.special = DFA34_special;
            this.transition = DFA34_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 249:3: ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*"; }
        }

    }

    const string DFA35_eotS =
        "\x0e\uffff";
    const string DFA35_eofS =
        "\x0e\uffff";
    const string DFA35_minS =
        "\x01\x04\x01\x2b\x09\uffff\x01\x1c\x02\uffff";
    const string DFA35_maxS =
        "\x01\x5e\x01\x2b\x09\uffff\x01\x5e\x02\uffff";
    const string DFA35_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07\x01"+
        "\x08\x01\x0a\x01\x0b\x01\uffff\x01\x01\x01\x09";
    const string DFA35_specialS =
        "\x0e\uffff}>";
    static readonly string[] DFA35_transitionS = {
            "\x23\x0a\x01\x01\x01\x08\x01\x07\x01\x0a\x02\uffff\x09\x0a"+
            "\x01\uffff\x08\x0a\x01\x09\x01\x03\x01\x05\x01\x06\x02\x02\x01"+
            "\x04\x07\x02\x12\x0a",
            "\x01\x0b",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0d\x41\uffff\x01\x0c",
            "",
            ""
    };

    static readonly short[] DFA35_eot = DFA.UnpackEncodedString(DFA35_eotS);
    static readonly short[] DFA35_eof = DFA.UnpackEncodedString(DFA35_eofS);
    static readonly char[] DFA35_min = DFA.UnpackEncodedStringToUnsignedChars(DFA35_minS);
    static readonly char[] DFA35_max = DFA.UnpackEncodedStringToUnsignedChars(DFA35_maxS);
    static readonly short[] DFA35_accept = DFA.UnpackEncodedString(DFA35_acceptS);
    static readonly short[] DFA35_special = DFA.UnpackEncodedString(DFA35_specialS);
    static readonly short[][] DFA35_transition = DFA.UnpackEncodedStringArray(DFA35_transitionS);

    protected class DFA35 : DFA
    {
        public DFA35(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 35;
            this.eot = DFA35_eot;
            this.eof = DFA35_eof;
            this.min = DFA35_min;
            this.max = DFA35_max;
            this.accept = DFA35_accept;
            this.special = DFA35_special;
            this.transition = DFA35_transition;

        }

        override public string Description
        {
            get { return "252:4: ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr2 )"; }
        }

    }

    const string DFA36_eotS =
        "\x0f\uffff";
    const string DFA36_eofS =
        "\x0f\uffff";
    const string DFA36_minS =
        "\x01\x04\x01\uffff\x01\x2b\x09\uffff\x01\x1c\x02\uffff";
    const string DFA36_maxS =
        "\x01\x5e\x01\uffff\x01\x2b\x09\uffff\x01\x5e\x02\uffff";
    const string DFA36_acceptS =
        "\x01\uffff\x01\x0c\x01\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x01\x08\x01\x0a\x01\x0b\x01\uffff\x01\x01\x01\x09";
    const string DFA36_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA36_transitionS = {
            "\x23\x0b\x01\x02\x01\x09\x01\x08\x01\x0b\x01\uffff\x01\x01"+
            "\x12\x0b\x01\x0a\x01\x04\x01\x06\x01\x07\x02\x03\x01\x05\x07"+
            "\x03\x12\x0b",
            "",
            "\x01\x0c",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0e\x41\uffff\x01\x0d",
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
            get { return "()* loopback of 253:3: ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body2 )*"; }
        }

    }

    const string DFA43_eotS =
        "\x0e\uffff";
    const string DFA43_eofS =
        "\x0e\uffff";
    const string DFA43_minS =
        "\x01\x1c\x04\uffff\x01\x00\x08\uffff";
    const string DFA43_maxS =
        "\x01\x5b\x04\uffff\x01\x00\x08\uffff";
    const string DFA43_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\uffff\x01\x05\x01"+
        "\x06\x01\x07\x01\x08\x01\uffff\x01\x09\x01\x0b\x01\x0a";
    const string DFA43_specialS =
        "\x01\x00\x04\uffff\x01\x01\x08\uffff}>";
    static readonly string[] DFA43_transitionS = {
            "\x01\x0c\x01\x02\x0d\uffff\x01\x0b\x01\uffff\x01\x02\x06\uffff"+
            "\x01\x05\x01\uffff\x01\x01\x03\uffff\x01\x02\x12\uffff\x01\x02"+
            "\x01\uffff\x01\x08\x01\x07\x01\uffff\x02\x09\x01\x03\x04\x0c"+
            "\x02\x04\x01\x06",
            "",
            "",
            "",
            "",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
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
            get { return "325:1: tikzpath_element_single : ( tikz_options | let_cmd_parts -> ^( IM_DONTCARE ( let_cmd_parts )+ ) | arc | ( coord )=> coord | controls | tikznode_int | tikzcoordinate_int | circle | roundbr_start ( tikzpath_element )* roundbr_end -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end ) | '(' ( tikzpath_element )* ')' -> ^( IM_PATH '(' ( tikzpath_element )* ')' ) | edgeop );"; }
        }

    }


    protected internal int DFA43_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA43_0 = input.LA(1);

                   	 
                   	int index43_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA43_0 == 54) ) { s = 1; }

                   	else if ( (LA43_0 == COMMAND || LA43_0 == 45 || LA43_0 == 58 || LA43_0 == 77) ) { s = 2; }

                   	else if ( (LA43_0 == 84) ) { s = 3; }

                   	else if ( ((LA43_0 >= 89 && LA43_0 <= 90)) && (synpred1_simpletikz()) ) { s = 4; }

                   	else if ( (LA43_0 == 52) ) { s = 5; }

                   	else if ( (LA43_0 == 91) ) { s = 6; }

                   	else if ( (LA43_0 == 80) ) { s = 7; }

                   	else if ( (LA43_0 == 79) ) { s = 8; }

                   	else if ( ((LA43_0 >= 82 && LA43_0 <= 83)) ) { s = 9; }

                   	else if ( (LA43_0 == 43) ) { s = 11; }

                   	else if ( (LA43_0 == ID || (LA43_0 >= 85 && LA43_0 <= 88)) ) { s = 12; }

                   	 
                   	input.Seek(index43_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA43_5 = input.LA(1);

                   	 
                   	int index43_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_simpletikz()) ) { s = 4; }

                   	else if ( (true) ) { s = 13; }

                   	 
                   	input.Seek(index43_5);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae =
            new NoViableAltException(dfa.Description, 43, _s, input);
        dfa.Error(nvae);
        throw nvae;
    }
    const string DFA48_eotS =
        "\x12\uffff";
    const string DFA48_eofS =
        "\x12\uffff";
    const string DFA48_minS =
        "\x01\x1c\x03\x00\x0e\uffff";
    const string DFA48_maxS =
        "\x01\x5b\x03\x00\x0e\uffff";
    const string DFA48_acceptS =
        "\x04\uffff\x01\x04\x0a\uffff\x01\x01\x01\x02\x01\x03";
    const string DFA48_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x0e\uffff}>";
    static readonly string[] DFA48_transitionS = {
            "\x02\x04\x0d\uffff\x01\x04\x01\uffff\x01\x04\x06\uffff\x01"+
            "\x01\x01\uffff\x01\x03\x01\uffff\x01\x04\x01\uffff\x01\x04\x12"+
            "\uffff\x01\x04\x01\uffff\x02\x04\x01\x02\x0a\x04",
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
            ""
    };

    static readonly short[] DFA48_eot = DFA.UnpackEncodedString(DFA48_eotS);
    static readonly short[] DFA48_eof = DFA.UnpackEncodedString(DFA48_eofS);
    static readonly char[] DFA48_min = DFA.UnpackEncodedStringToUnsignedChars(DFA48_minS);
    static readonly char[] DFA48_max = DFA.UnpackEncodedStringToUnsignedChars(DFA48_maxS);
    static readonly short[] DFA48_accept = DFA.UnpackEncodedString(DFA48_acceptS);
    static readonly short[] DFA48_special = DFA.UnpackEncodedString(DFA48_specialS);
    static readonly short[][] DFA48_transition = DFA.UnpackEncodedStringArray(DFA48_transitionS);

    protected class DFA48 : DFA
    {
        public DFA48(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 48;
            this.eot = DFA48_eot;
            this.eof = DFA48_eof;
            this.min = DFA48_min;
            this.max = DFA48_max;
            this.accept = DFA48_accept;
            this.special = DFA48_special;
            this.transition = DFA48_transition;

        }

        override public string Description
        {
            get { return "359:5: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?"; }
        }

    }


    protected internal int DFA48_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA48_1 = input.LA(1);

                   	 
                   	int index48_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred2_simpletikz()) ) { s = 15; }

                   	else if ( (synpred3_simpletikz()) ) { s = 16; }

                   	else if ( (synpred4_simpletikz()) ) { s = 17; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index48_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA48_2 = input.LA(1);

                   	 
                   	int index48_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred2_simpletikz()) ) { s = 15; }

                   	else if ( (synpred3_simpletikz()) ) { s = 16; }

                   	else if ( (synpred4_simpletikz()) ) { s = 17; }

                   	 
                   	input.Seek(index48_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA48_3 = input.LA(1);

                   	 
                   	int index48_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred2_simpletikz()) ) { s = 15; }

                   	else if ( (synpred3_simpletikz()) ) { s = 16; }

                   	else if ( (synpred4_simpletikz()) ) { s = 17; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index48_3);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae =
            new NoViableAltException(dfa.Description, 48, _s, input);
        dfa.Error(nvae);
        throw nvae;
    }
    const string DFA50_eotS =
        "\x15\uffff";
    const string DFA50_eofS =
        "\x15\uffff";
    const string DFA50_minS =
        "\x01\x1c\x03\x00\x11\uffff";
    const string DFA50_maxS =
        "\x01\x5b\x03\x00\x11\uffff";
    const string DFA50_acceptS =
        "\x04\uffff\x01\x04\x0d\uffff\x01\x01\x01\x02\x01\x03";
    const string DFA50_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x11\uffff}>";
    static readonly string[] DFA50_transitionS = {
            "\x02\x04\x0d\uffff\x03\x04\x01\uffff\x01\x04\x04\uffff\x01"+
            "\x01\x01\x04\x01\x03\x01\uffff\x01\x04\x01\uffff\x01\x04\x12"+
            "\uffff\x01\x04\x01\uffff\x02\x04\x01\x02\x0a\x04",
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
            "",
            "",
            ""
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
            get { return "370:18: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?"; }
        }

    }


    protected internal int DFA50_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA50_1 = input.LA(1);

                   	 
                   	int index50_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred5_simpletikz()) ) { s = 18; }

                   	else if ( (synpred6_simpletikz()) ) { s = 19; }

                   	else if ( (synpred7_simpletikz()) ) { s = 20; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index50_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA50_2 = input.LA(1);

                   	 
                   	int index50_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred5_simpletikz()) ) { s = 18; }

                   	else if ( (synpred6_simpletikz()) ) { s = 19; }

                   	else if ( (synpred7_simpletikz()) ) { s = 20; }

                   	 
                   	input.Seek(index50_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA50_3 = input.LA(1);

                   	 
                   	int index50_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred5_simpletikz()) ) { s = 18; }

                   	else if ( (synpred6_simpletikz()) ) { s = 19; }

                   	else if ( (synpred7_simpletikz()) ) { s = 20; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index50_3);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae =
            new NoViableAltException(dfa.Description, 50, _s, input);
        dfa.Error(nvae);
        throw nvae;
    }
    const string DFA57_eotS =
        "\x0a\uffff";
    const string DFA57_eofS =
        "\x0a\uffff";
    const string DFA57_minS =
        "\x01\x1c\x01\x04\x01\uffff\x01\x04\x01\x00\x02\x04\x01\uffff\x02"+
        "\x04";
    const string DFA57_maxS =
        "\x01\x5b\x01\x5e\x01\uffff\x01\x5e\x01\x00\x02\x5e\x01\uffff\x02"+
        "\x5e";
    const string DFA57_acceptS =
        "\x02\uffff\x01\x02\x04\uffff\x01\x01\x02\uffff";
    const string DFA57_specialS =
        "\x04\uffff\x01\x00\x05\uffff}>";
    static readonly string[] DFA57_transitionS = {
            "\x02\x02\x0d\uffff\x03\x02\x01\uffff\x01\x02\x04\uffff\x01"+
            "\x01\x02\x02\x01\uffff\x01\x02\x01\uffff\x01\x02\x12\uffff\x01"+
            "\x02\x01\uffff\x02\x02\x01\uffff\x0a\x02",
            "\x1a\x02\x02\x03\x0c\x02\x01\uffff\x02\x02\x04\uffff\x04\x02"+
            "\x02\uffff\x26\x02",
            "",
            "\x27\x02\x02\uffff\x04\x02\x02\uffff\x01\x02\x01\uffff\x01"+
            "\x04\x03\uffff\x06\x05\x0f\x02\x01\x06\x10\x02",
            "\x01\uffff",
            "\x27\x02\x02\uffff\x04\x02\x02\uffff\x01\x02\x01\uffff\x01"+
            "\x04\x03\uffff\x15\x02\x01\x06\x10\x02",
            "\x1a\x02\x02\x08\x0b\x02\x02\uffff\x04\x02\x02\uffff\x01\x02"+
            "\x01\uffff\x01\x02\x03\uffff\x26\x02",
            "",
            "\x27\x02\x02\uffff\x04\x02\x02\uffff\x01\x02\x01\uffff\x01"+
            "\x04\x03\uffff\x06\x09\x20\x02",
            "\x27\x02\x02\uffff\x04\x02\x02\uffff\x01\x02\x01\uffff\x01"+
            "\x04\x03\uffff\x26\x02"
    };

    static readonly short[] DFA57_eot = DFA.UnpackEncodedString(DFA57_eotS);
    static readonly short[] DFA57_eof = DFA.UnpackEncodedString(DFA57_eofS);
    static readonly char[] DFA57_min = DFA.UnpackEncodedStringToUnsignedChars(DFA57_minS);
    static readonly char[] DFA57_max = DFA.UnpackEncodedStringToUnsignedChars(DFA57_maxS);
    static readonly short[] DFA57_accept = DFA.UnpackEncodedString(DFA57_acceptS);
    static readonly short[] DFA57_special = DFA.UnpackEncodedString(DFA57_specialS);
    static readonly short[][] DFA57_transition = DFA.UnpackEncodedStringArray(DFA57_transitionS);

    protected class DFA57 : DFA
    {
        public DFA57(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 57;
            this.eot = DFA57_eot;
            this.eof = DFA57_eof;
            this.min = DFA57_min;
            this.max = DFA57_max;
            this.accept = DFA57_accept;
            this.special = DFA57_special;
            this.transition = DFA57_transition;

        }

        override public string Description
        {
            get { return "420:27: ( ( size )=> size )?"; }
        }

    }


    protected internal int DFA57_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA57_4 = input.LA(1);

                   	 
                   	int index57_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_simpletikz()) ) { s = 7; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index57_4);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae =
            new NoViableAltException(dfa.Description, 57, _s, input);
        dfa.Error(nvae);
        throw nvae;
    }
    const string DFA60_eotS =
        "\x14\uffff";
    const string DFA60_eofS =
        "\x14\uffff";
    const string DFA60_minS =
        "\x01\x54\x01\x34\x01\x04\x01\uffff\x02\x04\x01\uffff\x0a\x04\x01"+
        "\uffff\x02\x04";
    const string DFA60_maxS =
        "\x01\x54\x01\x36\x01\x5e\x01\uffff\x02\x5e\x01\uffff\x0a\x5e\x01"+
        "\uffff\x02\x5e";
    const string DFA60_acceptS =
        "\x03\uffff\x01\x03\x02\uffff\x01\x02\x0a\uffff\x01\x01\x02\uffff";
    const string DFA60_specialS =
        "\x14\uffff}>";
    static readonly string[] DFA60_transitionS = {
            "\x01\x01",
            "\x01\x02\x01\uffff\x01\x03",
            "\x19\x06\x01\x05\x02\x04\x0c\x06\x02\uffff\x01\x06\x04\uffff"+
            "\x01\x06\x05\uffff\x26\x06",
            "",
            "\x27\x06\x02\uffff\x02\x06\x01\uffff\x01\x07\x02\uffff\x01"+
            "\x06\x05\uffff\x06\x08\x20\x06",
            "\x27\x06\x02\uffff\x02\x06\x01\uffff\x01\x07\x02\uffff\x01"+
            "\x06\x05\uffff\x26\x06",
            "",
            "\x19\x06\x01\x0a\x02\x09\x0c\x06\x02\uffff\x01\x06\x04\uffff"+
            "\x01\x06\x05\uffff\x26\x06",
            "\x27\x06\x02\uffff\x02\x06\x01\uffff\x01\x07\x02\uffff\x01"+
            "\x06\x05\uffff\x26\x06",
            "\x27\x06\x02\uffff\x02\x06\x01\uffff\x01\x0c\x02\uffff\x01"+
            "\x06\x05\uffff\x06\x0b\x20\x06",
            "\x27\x06\x02\uffff\x02\x06\x01\uffff\x01\x0c\x02\uffff\x01"+
            "\x06\x05\uffff\x26\x06",
            "\x27\x06\x02\uffff\x02\x06\x01\uffff\x01\x0c\x02\uffff\x01"+
            "\x06\x05\uffff\x26\x06",
            "\x19\x06\x01\x0e\x02\x0d\x0c\x06\x02\uffff\x01\x06\x04\uffff"+
            "\x01\x06\x05\uffff\x26\x06",
            "\x27\x06\x02\uffff\x02\x06\x04\uffff\x01\x06\x01\uffff\x01"+
            "\x11\x03\uffff\x06\x0f\x0f\x06\x01\x10\x10\x06",
            "\x27\x06\x02\uffff\x02\x06\x04\uffff\x01\x06\x01\uffff\x01"+
            "\x11\x03\uffff\x15\x06\x01\x10\x10\x06",
            "\x27\x06\x02\uffff\x02\x06\x04\uffff\x01\x06\x01\uffff\x01"+
            "\x11\x03\uffff\x15\x06\x01\x10\x10\x06",
            "\x1a\x06\x02\x12\x0b\x06\x02\uffff\x02\x06\x04\uffff\x01\x06"+
            "\x01\uffff\x01\x06\x03\uffff\x26\x06",
            "",
            "\x27\x06\x02\uffff\x02\x06\x04\uffff\x01\x06\x01\uffff\x01"+
            "\x11\x03\uffff\x06\x13\x20\x06",
            "\x27\x06\x02\uffff\x02\x06\x04\uffff\x01\x06\x01\uffff\x01"+
            "\x11\x03\uffff\x26\x06"
    };

    static readonly short[] DFA60_eot = DFA.UnpackEncodedString(DFA60_eotS);
    static readonly short[] DFA60_eof = DFA.UnpackEncodedString(DFA60_eofS);
    static readonly char[] DFA60_min = DFA.UnpackEncodedStringToUnsignedChars(DFA60_minS);
    static readonly char[] DFA60_max = DFA.UnpackEncodedStringToUnsignedChars(DFA60_maxS);
    static readonly short[] DFA60_accept = DFA.UnpackEncodedString(DFA60_acceptS);
    static readonly short[] DFA60_special = DFA.UnpackEncodedString(DFA60_specialS);
    static readonly short[][] DFA60_transition = DFA.UnpackEncodedStringArray(DFA60_transitionS);

    protected class DFA60 : DFA
    {
        public DFA60(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 60;
            this.eot = DFA60_eot;
            this.eof = DFA60_eof;
            this.min = DFA60_min;
            this.max = DFA60_max;
            this.accept = DFA60_accept;
            this.special = DFA60_special;
            this.transition = DFA60_transition;

        }

        override public string Description
        {
            get { return "422:1: arc : ( 'arc' ( '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')' ) -> ^( IM_ARC ( numberunitorvariable )+ ( numberunit )? ) | 'arc' ( '(' coord_part ':' coord_part ':' coord_part ( 'and' numberunit )? ')' ) -> ^( IM_ARC ( coord_part )+ ( numberunit )? ) | 'arc' tikz_options -> ^( IM_DONTCARE ) );"; }
        }

    }

    const string DFA67_eotS =
        "\x0d\uffff";
    const string DFA67_eofS =
        "\x0d\uffff";
    const string DFA67_minS =
        "\x02\x34\x01\x04\x01\uffff\x01\x04\x01\uffff\x01\x04\x01\uffff"+
        "\x03\x04\x01\uffff\x01\x04";
    const string DFA67_maxS =
        "\x01\x5a\x01\x34\x01\x5e\x01\uffff\x01\x5e\x01\uffff\x01\x5e\x01"+
        "\uffff\x03\x5e\x01\uffff\x01\x5e";
    const string DFA67_acceptS =
        "\x03\uffff\x01\x04\x01\uffff\x01\x01\x01\uffff\x01\x03\x03\uffff"+
        "\x01\x02\x01\uffff";
    const string DFA67_specialS =
        "\x0d\uffff}>";
    static readonly string[] DFA67_transitionS = {
            "\x01\x02\x24\uffff\x02\x01",
            "\x01\x02",
            "\x1a\x06\x02\x04\x0b\x06\x01\x07\x02\uffff\x01\x06\x04\uffff"+
            "\x01\x06\x01\uffff\x01\x03\x01\x05\x02\uffff\x26\x06",
            "",
            "\x27\x06\x02\uffff\x01\x07\x01\x06\x02\x09\x02\uffff\x01\x06"+
            "\x01\uffff\x01\x05\x03\uffff\x06\x08\x20\x06",
            "",
            "\x27\x06\x02\uffff\x01\x07\x01\x06\x02\x07\x02\uffff\x01\x06"+
            "\x01\uffff\x01\x05\x03\uffff\x26\x06",
            "",
            "\x27\x06\x02\uffff\x01\x07\x01\x06\x02\x09\x02\uffff\x01\x06"+
            "\x01\uffff\x01\x05\x03\uffff\x26\x06",
            "\x1a\x07\x02\x0a\x0c\x07\x02\uffff\x01\x07\x04\uffff\x01\x07"+
            "\x05\uffff\x26\x07",
            "\x27\x07\x02\uffff\x02\x07\x04\uffff\x01\x07\x01\uffff\x01"+
            "\x0b\x03\uffff\x06\x0c\x20\x07",
            "",
            "\x27\x07\x02\uffff\x02\x07\x04\uffff\x01\x07\x01\uffff\x01"+
            "\x0b\x03\uffff\x26\x07"
    };

    static readonly short[] DFA67_eot = DFA.UnpackEncodedString(DFA67_eotS);
    static readonly short[] DFA67_eof = DFA.UnpackEncodedString(DFA67_eofS);
    static readonly char[] DFA67_min = DFA.UnpackEncodedStringToUnsignedChars(DFA67_minS);
    static readonly char[] DFA67_max = DFA.UnpackEncodedStringToUnsignedChars(DFA67_maxS);
    static readonly short[] DFA67_accept = DFA.UnpackEncodedString(DFA67_acceptS);
    static readonly short[] DFA67_special = DFA.UnpackEncodedString(DFA67_specialS);
    static readonly short[][] DFA67_transition = DFA.UnpackEncodedStringArray(DFA67_transitionS);

    protected class DFA67 : DFA
    {
        public DFA67(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 67;
            this.eot = DFA67_eot;
            this.eof = DFA67_eof;
            this.min = DFA67_min;
            this.max = DFA67_max;
            this.accept = DFA67_accept;
            this.special = DFA67_special;
            this.transition = DFA67_transition;

        }

        override public string Description
        {
            get { return "442:1: coord : ( ( ( coord_modifier )? coord_nodename ) -> ^( IM_COORD ( coord_modifier )? coord_nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) | ( ( coord_modifier )? '(' ')' ) -> ^( IM_COORD ) );"; }
        }

    }

    const string DFA70_eotS =
        "\x0f\uffff";
    const string DFA70_eofS =
        "\x0f\uffff";
    const string DFA70_minS =
        "\x01\x34\x01\x04\x01\x34\x02\x04\x01\uffff\x02\x04\x01\uffff\x05"+
        "\x04\x01\uffff";
    const string DFA70_maxS =
        "\x01\x5a\x01\x5e\x01\x34\x02\x5e\x01\uffff\x02\x5e\x01\uffff\x05"+
        "\x5e\x01\uffff";
    const string DFA70_acceptS =
        "\x05\uffff\x01\x03\x02\uffff\x01\x01\x05\uffff\x01\x02";
    const string DFA70_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA70_transitionS = {
            "\x01\x01\x24\uffff\x02\x02",
            "\x1a\x04\x02\x03\x0b\x04\x01\x05\x02\uffff\x01\x04\x04\uffff"+
            "\x01\x04\x05\uffff\x26\x04",
            "\x01\x06",
            "\x27\x04\x02\uffff\x01\x05\x01\x04\x02\x09\x02\uffff\x01\x04"+
            "\x01\uffff\x01\x08\x03\uffff\x06\x07\x20\x04",
            "\x27\x04\x02\uffff\x01\x05\x01\x04\x02\x05\x02\uffff\x01\x04"+
            "\x01\uffff\x01\x08\x03\uffff\x26\x04",
            "",
            "\x1a\x05\x02\x0a\x0c\x05\x02\uffff\x01\x05\x04\uffff\x01\x05"+
            "\x05\uffff\x26\x05",
            "\x27\x04\x02\uffff\x01\x05\x01\x04\x02\x09\x02\uffff\x01\x04"+
            "\x01\uffff\x01\x08\x03\uffff\x26\x04",
            "",
            "\x1a\x05\x02\x0b\x0c\x05\x02\uffff\x01\x05\x04\uffff\x01\x05"+
            "\x05\uffff\x26\x05",
            "\x27\x05\x02\uffff\x02\x05\x02\x09\x02\uffff\x01\x05\x05\uffff"+
            "\x06\x0c\x20\x05",
            "\x27\x05\x02\uffff\x02\x05\x04\uffff\x01\x05\x01\uffff\x01"+
            "\x0e\x03\uffff\x06\x0d\x20\x05",
            "\x27\x05\x02\uffff\x02\x05\x02\x09\x02\uffff\x01\x05\x05\uffff"+
            "\x26\x05",
            "\x27\x05\x02\uffff\x02\x05\x04\uffff\x01\x05\x01\uffff\x01"+
            "\x0e\x03\uffff\x26\x05",
            ""
    };

    static readonly short[] DFA70_eot = DFA.UnpackEncodedString(DFA70_eotS);
    static readonly short[] DFA70_eof = DFA.UnpackEncodedString(DFA70_eofS);
    static readonly char[] DFA70_min = DFA.UnpackEncodedStringToUnsignedChars(DFA70_minS);
    static readonly char[] DFA70_max = DFA.UnpackEncodedStringToUnsignedChars(DFA70_maxS);
    static readonly short[] DFA70_accept = DFA.UnpackEncodedString(DFA70_acceptS);
    static readonly short[] DFA70_special = DFA.UnpackEncodedString(DFA70_specialS);
    static readonly short[][] DFA70_transition = DFA.UnpackEncodedStringArray(DFA70_transitionS);

    protected class DFA70 : DFA
    {
        public DFA70(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 70;
            this.eot = DFA70_eot;
            this.eof = DFA70_eof;
            this.min = DFA70_min;
            this.max = DFA70_max;
            this.accept = DFA70_accept;
            this.special = DFA70_special;
            this.transition = DFA70_transition;

        }

        override public string Description
        {
            get { return "448:1: coord_nooption : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) );"; }
        }

    }

    const string DFA73_eotS =
        "\x08\uffff";
    const string DFA73_eofS =
        "\x08\uffff";
    const string DFA73_minS =
        "\x02\x04\x02\uffff\x01\x04\x01\uffff\x02\x04";
    const string DFA73_maxS =
        "\x02\x5e\x02\uffff\x01\x5e\x01\uffff\x02\x5e";
    const string DFA73_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\uffff\x01\x01\x02\uffff";
    const string DFA73_specialS =
        "\x08\uffff}>";
    static readonly string[] DFA73_transitionS = {
            "\x27\x01\x01\x02\x02\uffff\x01\x01\x04\uffff\x01\x01\x05\uffff"+
            "\x26\x01",
            "\x27\x01\x02\uffff\x01\x03\x01\x01\x02\x05\x02\uffff\x01\x01"+
            "\x01\uffff\x01\x05\x03\uffff\x15\x01\x01\x04\x10\x01",
            "",
            "",
            "\x1a\x01\x02\x06\x0b\x01\x02\uffff\x01\x03\x01\x01\x02\x05"+
            "\x02\uffff\x01\x01\x01\uffff\x01\x05\x03\uffff\x15\x01\x01\x04"+
            "\x10\x01",
            "",
            "\x27\x01\x02\uffff\x01\x03\x01\x01\x02\x05\x02\uffff\x01\x01"+
            "\x01\uffff\x01\x05\x03\uffff\x06\x07\x0f\x01\x01\x04\x10\x01",
            "\x27\x01\x02\uffff\x01\x03\x01\x01\x02\x05\x02\uffff\x01\x01"+
            "\x01\uffff\x01\x05\x03\uffff\x15\x01\x01\x04\x10\x01"
    };

    static readonly short[] DFA73_eot = DFA.UnpackEncodedString(DFA73_eotS);
    static readonly short[] DFA73_eof = DFA.UnpackEncodedString(DFA73_eofS);
    static readonly char[] DFA73_min = DFA.UnpackEncodedStringToUnsignedChars(DFA73_minS);
    static readonly char[] DFA73_max = DFA.UnpackEncodedStringToUnsignedChars(DFA73_maxS);
    static readonly short[] DFA73_accept = DFA.UnpackEncodedString(DFA73_acceptS);
    static readonly short[] DFA73_special = DFA.UnpackEncodedString(DFA73_specialS);
    static readonly short[][] DFA73_transition = DFA.UnpackEncodedStringArray(DFA73_transitionS);

    protected class DFA73 : DFA
    {
        public DFA73(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 73;
            this.eot = DFA73_eot;
            this.eof = DFA73_eof;
            this.min = DFA73_min;
            this.max = DFA73_max;
            this.accept = DFA73_accept;
            this.special = DFA73_special;
            this.transition = DFA73_transition;

        }

        override public string Description
        {
            get { return "460:1: coord_part : ( idd -> ^( IM_DONTCARE idd ) | '{' idd '}' -> ^( IM_DONTCARE '{' idd '}' ) | ( idd '=' numberunit ( ',' )? )+ -> ^( IM_DONTCARE ( idd '=' numberunit ( ',' )? )+ ) );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_dontcare_preamble_in_tikzdocument257 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_styleorsetorcmd_in_tikzdocument261 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzdocument265 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpicture_in_tikzdocument270 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_dontcare_preamble_in_tikzdocument_wo_tikzpicture296 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_styleorsetorcmd_in_tikzdocument_wo_tikzpicture300 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzdocument_wo_tikzpicture304 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_EOF_in_tikzdocument_wo_tikzpicture309 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TIKZEDT_CMD_COMMENT_in_tikz_cmd_comment330 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikz_styleorsetorcmd352 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikz_styleorsetorcmd356 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_cmd_comment_in_tikz_styleorsetorcmd360 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_preamble371 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_otherbegin400 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_otherbegin402 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_idd2_in_otherbegin404 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_otherbegin406 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_tikz_style418 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikz_style420 = new BitSet(new ulong[]{0xFE0847FFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_idd_in_tikz_style422 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_tikz_style424 = new BitSet(new ulong[]{0x0000600000000000UL});
    public static readonly BitSet FOLLOW_45_in_tikz_style427 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_46_in_tikz_style431 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikz_style434 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_squarebr_start_in_tikz_options456 = new BitSet(new ulong[]{0xFE884FFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_options459 = new BitSet(new ulong[]{0xFE88CFFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_47_in_tikz_options462 = new BitSet(new ulong[]{0xFE0847FFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_options464 = new BitSet(new ulong[]{0xFE88CFFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_47_in_tikz_options468 = new BitSet(new ulong[]{0xFE884FFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikz_options473 = new BitSet(new ulong[]{0xFE884FFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_squarebr_end_in_tikz_options476 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_option_style_in_option501 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_option_kv_in_option510 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_option_kv524 = new BitSet(new ulong[]{0x0000200000000002UL});
    public static readonly BitSet FOLLOW_45_in_option_kv527 = new BitSet(new ulong[]{0xFE084FFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_iddornumberunitorstringorrange_in_option_kv529 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_tikzstring557 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_no_rlbrace_in_tikzstring559 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikzstring563 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_no_rlbrace_in_tikzstring565 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_44_in_tikzstring570 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_no_rlbrace593 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_range_in_iddornumberunitorstringorrange611 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_numberunit_in_iddornumberunitorstringorrange615 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_bracedcoord_in_iddornumberunitorstringorrange619 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_iddornumberunitorstringorrange623 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_number_in_iddornumberunitorstringorrange630 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_iddornumberunitorstringorrange633 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_tikzstring_in_iddornumberunitorstringorrange638 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_bracedcoord652 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000006000000UL});
    public static readonly BitSet FOLLOW_coord_nooption_in_bracedcoord656 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_bracedcoord658 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_numberunit_in_range669 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_range671 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_range673 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_option_style697 = new BitSet(new ulong[]{0x0006000000000000UL});
    public static readonly BitSet FOLLOW_49_in_option_style700 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_50_in_option_style705 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_option_style707 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_option_style711 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_option_style713 = new BitSet(new ulong[]{0xFE08D7FFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_option_kv_in_option_style716 = new BitSet(new ulong[]{0x0000900000000000UL});
    public static readonly BitSet FOLLOW_47_in_option_style719 = new BitSet(new ulong[]{0xFE0847FFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_option_kv_in_option_style721 = new BitSet(new ulong[]{0x0000900000000000UL});
    public static readonly BitSet FOLLOW_47_in_option_style728 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_option_style731 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_heavenknowswhythisisnecessary_in_idd766 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_idd_heavenknowswhythisisnecessary786 = new BitSet(new ulong[]{0xFE0847FFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_ID_in_idd2846 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_numberunit_in_numberunitorvariable865 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COMMAND_in_numberunitorvariable870 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_number_in_numberunit883 = new BitSet(new ulong[]{0x7E00000000000002UL});
    public static readonly BitSet FOLLOW_unit_in_numberunit885 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_number911 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unit0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_set_start_in_tikz_set966 = new BitSet(new ulong[]{0xFE0857FFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_set969 = new BitSet(new ulong[]{0xFE08D7FFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_47_in_tikz_set972 = new BitSet(new ulong[]{0xFE0847FFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_set974 = new BitSet(new ulong[]{0xFE08D7FFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_47_in_tikz_set978 = new BitSet(new ulong[]{0xFE0857FFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_roundbr_end_in_tikz_set983 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzpicture_start_in_tikzpicture1015 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpicture1017 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzpicture1020 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpicture_end_in_tikzpicture1023 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_start_in_tikzpicture1048 = new BitSet(new ulong[]{0x0040080000000000UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpicture1051 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikzpicture1054 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzbody2_in_tikzpicture1056 = new BitSet(new ulong[]{0xFE0857FFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_roundbr_end_in_tikzpicture1059 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody1091 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody1095 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_ext_in_tikzbody1099 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzdef_ext_in_tikzbody1103 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzmatrix_ext_in_tikzbody1107 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzcoordinate_ext_in_tikzbody1111 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody1115 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody1119 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody1123 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody1128 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_dontcare_body_nobr_in_tikzbody1133 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody1144 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody1148 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_ext_in_tikzbody1152 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzdef_ext_in_tikzbody1156 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzmatrix_ext_in_tikzbody1160 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzcoordinate_ext_in_tikzbody1164 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody1168 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody1172 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody1176 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody1181 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_dontcare_body_in_tikzbody1186 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody21202 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody21206 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_ext_in_tikzbody21210 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzdef_ext_in_tikzbody21214 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzmatrix_ext_in_tikzbody21218 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzcoordinate_ext_in_tikzbody21222 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody21226 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody21230 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody21234 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody21239 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_dontcare_body_nobr2_in_tikzbody21244 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody21255 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody21259 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_ext_in_tikzbody21263 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzdef_ext_in_tikzbody21267 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzmatrix_ext_in_tikzbody21271 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzcoordinate_ext_in_tikzbody21275 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody21279 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody21283 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody21287 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody21292 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_dontcare_body2_in_tikzbody21297 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body_nobr21314 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body21408 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body_nobr1498 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body1585 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_63_in_otherend1668 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_otherend1670 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_idd2_in_otherend1672 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_otherend1674 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzscope_start_in_tikzscope1701 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzscope1703 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzscope1706 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzscope_end_in_tikzscope1709 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_in_tikzpath1765 = new BitSet(new ulong[]{0x0550280030000000UL,0x000000000FFDA000UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath1767 = new BitSet(new ulong[]{0x0550280030000000UL,0x000000000FFDA000UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzpath1770 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_let_cmd_parts0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzpath_element_single_in_tikzpath_element1826 = new BitSet(new ulong[]{0x0000800000000002UL});
    public static readonly BitSet FOLLOW_47_in_tikzpath_element1828 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpath_element_single1846 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_let_cmd_parts_in_tikzpath_element_single1853 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arc_in_tikzpath_element_single1871 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_in_tikzpath_element_single1881 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_controls_in_tikzpath_element_single1887 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_int_in_tikzpath_element_single1893 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_int_in_tikzpath_element_single1899 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_circle_in_tikzpath_element_single1905 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_roundbr_start_in_tikzpath_element_single1912 = new BitSet(new ulong[]{0xFE587FFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath_element_single1914 = new BitSet(new ulong[]{0xFE587FFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_roundbr_end_in_tikzpath_element_single1917 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_tikzpath_element_single1937 = new BitSet(new ulong[]{0x0470280030000000UL,0x000000000FFDA000UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath_element_single1939 = new BitSet(new ulong[]{0x0470280030000000UL,0x000000000FFDA000UL});
    public static readonly BitSet FOLLOW_53_in_tikzpath_element_single1942 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_edgeop_in_tikzpath_element_single1961 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_controls_start_in_controls1976 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000006000000UL});
    public static readonly BitSet FOLLOW_coord_in_controls1978 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000008004000UL});
    public static readonly BitSet FOLLOW_78_in_controls1981 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000006000000UL});
    public static readonly BitSet FOLLOW_coord_in_controls1983 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000008004000UL});
    public static readonly BitSet FOLLOW_controls_end_in_controls1987 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_node_start_in_tikznode_ext2013 = new BitSet(new ulong[]{0x0050080000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_tikznode_core_in_tikznode_ext2015 = new BitSet(new ulong[]{0x0550280030000000UL,0x000000000FFDA000UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikznode_ext2017 = new BitSet(new ulong[]{0x0550280030000000UL,0x000000000FFDA000UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikznode_ext2020 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_def_start_in_tikzdef_ext2045 = new BitSet(new ulong[]{0x0550280030000000UL,0x000000000FFDA000UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzdef_ext2047 = new BitSet(new ulong[]{0x0550280030000000UL,0x000000000FFDA000UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzdef_ext2050 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrix_start_in_tikzmatrix_ext2075 = new BitSet(new ulong[]{0x0050080000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_tikznode_core_in_tikzmatrix_ext2077 = new BitSet(new ulong[]{0x0550280030000000UL,0x000000000FFDA000UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzmatrix_ext2079 = new BitSet(new ulong[]{0x0550280030000000UL,0x000000000FFDA000UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzmatrix_ext2082 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coordinate_start_in_tikzcoordinate_ext2110 = new BitSet(new ulong[]{0x0550280030000000UL,0x000000000FFFA000UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_ext2125 = new BitSet(new ulong[]{0x0550280030000000UL,0x000000000FFDA000UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_ext2144 = new BitSet(new ulong[]{0x0550280030000000UL,0x000000000FFDA000UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_ext2164 = new BitSet(new ulong[]{0x0550280030000000UL,0x000000000FFDA000UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzcoordinate_ext2175 = new BitSet(new ulong[]{0x0550280030000000UL,0x000000000FFDA000UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzcoordinate_ext2178 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_79_in_tikzcoordinate_int2238 = new BitSet(new ulong[]{0x0050000000000002UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_int2249 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_int2268 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_int2288 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_80_in_tikznode_int2304 = new BitSet(new ulong[]{0x0050080000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_tikznode_core_in_tikznode_int2307 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikznode_core2317 = new BitSet(new ulong[]{0x0050080000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikznode_core2320 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core32345 = new BitSet(new ulong[]{0x0050000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core32347 = new BitSet(new ulong[]{0x0050000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core32349 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core22383 = new BitSet(new ulong[]{0x0050000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core22385 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core12418 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_tikznode_decorator2455 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_81_in_tikznode_decorator2462 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_COMMAND_in_tikznode_decorator2465 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_81_in_tikznode_decorator2471 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000006000000UL});
    public static readonly BitSet FOLLOW_coord_in_tikznode_decorator2474 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_options_dontcare_in_tikznode_decorator2480 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_tikz_options_dontcare2490 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_no_rlbracket_in_tikz_options_dontcare2492 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_options_dontcare_in_tikz_options_dontcare2496 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_no_rlbracket_in_tikz_options_dontcare2498 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_55_in_tikz_options_dontcare2503 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_no_rlbracket2521 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_nodename2538 = new BitSet(new ulong[]{0xFE0847FFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_idd_in_nodename2540 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_nodename2542 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_82_in_circle2567 = new BitSet(new ulong[]{0x0010000000000002UL});
    public static readonly BitSet FOLLOW_83_in_circle2571 = new BitSet(new ulong[]{0x0010000000000002UL});
    public static readonly BitSet FOLLOW_size_in_circle2580 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_84_in_arc2595 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_arc2598 = new BitSet(new ulong[]{0x00000000E0000000UL});
    public static readonly BitSet FOLLOW_numberunitorvariable_in_arc2600 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_arc2602 = new BitSet(new ulong[]{0x00000000E0000000UL});
    public static readonly BitSet FOLLOW_numberunitorvariable_in_arc2604 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_arc2606 = new BitSet(new ulong[]{0x00000000E0000000UL});
    public static readonly BitSet FOLLOW_numberunitorvariable_in_arc2608 = new BitSet(new ulong[]{0x0020000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_78_in_arc2611 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_arc2613 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_arc2617 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_84_in_arc2635 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_arc2638 = new BitSet(new ulong[]{0xFE084FFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_arc2640 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_arc2642 = new BitSet(new ulong[]{0xFE084FFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_arc2644 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_arc2646 = new BitSet(new ulong[]{0xFE084FFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_arc2648 = new BitSet(new ulong[]{0x0020000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_78_in_arc2651 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_arc2653 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_arc2657 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_84_in_arc2675 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_tikz_options_in_arc2677 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_size2702 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_size2704 = new BitSet(new ulong[]{0x0020000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_78_in_size2707 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_size2709 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_size2713 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_coord_nodename2741 = new BitSet(new ulong[]{0xFE4847FFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_options_in_coord_nodename2743 = new BitSet(new ulong[]{0xFE0847FFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_idd_in_coord_nodename2746 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_coord_nodename2749 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord2775 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000006000000UL});
    public static readonly BitSet FOLLOW_coord_nodename_in_coord2778 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord2804 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_coord2807 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord2809 = new BitSet(new ulong[]{0x0001800000000000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord2811 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord2813 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_coord2815 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord2839 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_coord2842 = new BitSet(new ulong[]{0xFE084FFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_coord2844 = new BitSet(new ulong[]{0x0001800000000000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord2846 = new BitSet(new ulong[]{0xFE084FFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_coord2848 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_coord2850 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord2874 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_coord2877 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_coord2879 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_coord_nooption2907 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord_nooption2931 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_coord_nooption2934 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord_nooption2936 = new BitSet(new ulong[]{0x0001800000000000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord_nooption2938 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord_nooption2940 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_coord_nooption2942 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord_nooption2966 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_coord_nooption2969 = new BitSet(new ulong[]{0xFE084FFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_coord_nooption2971 = new BitSet(new ulong[]{0x0001800000000000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord_nooption2973 = new BitSet(new ulong[]{0xFE084FFFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_coord_nooption2975 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_coord_nooption2977 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_coord_part3010 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_coord_part3025 = new BitSet(new ulong[]{0xFE0847FFFFFFFFF0UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_idd_in_coord_part3027 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_coord_part3029 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_coord_part3047 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_coord_part3049 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord_part3051 = new BitSet(new ulong[]{0xFE08C7FFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_47_in_coord_part3053 = new BitSet(new ulong[]{0xFE0847FFFFFFFFF2UL,0x000000007FFFFFFFUL});
    public static readonly BitSet FOLLOW_set_in_coord_sep3085 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_edgeop0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_coord_modifier0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_squarebr_start3159 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_squarebr_end3177 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_semicolon_end3196 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_roundbr_start3214 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_44_in_roundbr_end3232 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_91_in_controls_start3250 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000010000000UL});
    public static readonly BitSet FOLLOW_92_in_controls_start3252 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_91_in_controls_end3270 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_41_in_tikz_set_start3288 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikz_set_start3290 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_tikzpicture_start3309 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikzpicture_start3311 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000020000000UL});
    public static readonly BitSet FOLLOW_93_in_tikzpicture_start3313 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_tikzpicture_start3315 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_42_in_tikz_start3333 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_63_in_tikzpicture_end3351 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikzpicture_end3353 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000020000000UL});
    public static readonly BitSet FOLLOW_93_in_tikzpicture_end3355 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_tikzpicture_end3357 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_tikzscope_start3375 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikzscope_start3377 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000040000000UL});
    public static readonly BitSet FOLLOW_94_in_tikzscope_start3379 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_tikzscope_start3381 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_63_in_tikzscope_end3399 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikzscope_end3401 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000040000000UL});
    public static readonly BitSet FOLLOW_94_in_tikzscope_end3403 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_tikzscope_end3405 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_tag_in_path_start3424 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_node_start_tag_in_node_start3442 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_def_start_tag_in_def_start3460 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrix_start_tag_in_matrix_start3478 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_64_in_node_start_tag3496 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_69_in_def_start_tag3506 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_65_in_matrix_start_tag3516 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_66_in_coordinate_start3526 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_path_start_tag0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_in_synpred1_simpletikz1878 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_synpred2_simpletikz2121 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_synpred3_simpletikz2140 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_synpred4_simpletikz2160 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_synpred5_simpletikz2245 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_synpred6_simpletikz2264 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_synpred7_simpletikz2284 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_size_in_synpred8_simpletikz2576 = new BitSet(new ulong[]{0x0000000000000002UL});

}
