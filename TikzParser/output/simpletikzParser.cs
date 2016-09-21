// $ANTLR 3.1.1 E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g 2016-09-21 11:07:05

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
		"'args'", 
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

    public const int T__50 = 50;
    public const int IM_NUMBERUNIT = 9;
    public const int IM_OPTIONS = 15;
    public const int IM_PATH = 4;
    public const int T__59 = 59;
    public const int T__55 = 55;
    public const int IM_TIKZEDT_CMD = 24;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int IM_SCOPE = 12;
    public const int T__58 = 58;
    public const int ID = 28;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int IM_NODENAME = 8;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int T__60 = 60;
    public const int T__61 = 61;
    public const int SOMETHING1 = 38;
    public const int SOMETHING = 37;
    public const int T__66 = 66;
    public const int T__67 = 67;
    public const int T__68 = 68;
    public const int T__69 = 69;
    public const int T__62 = 62;
    public const int T__63 = 63;
    public const int T__64 = 64;
    public const int T__65 = 65;
    public const int IM_ID = 18;
    public const int COMMENT = 33;
    public const int IM_SIZE = 7;
    public const int T__39 = 39;
    public const int IM_NODE = 5;
    public const int COMMAND = 29;
    public const int IM_DOCUMENT = 11;
    public const int IM_STARTTAG = 13;
    public const int IM_ARC = 26;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int T__44 = 44;
    public const int T__45 = 45;
    public const int EXPONENT = 34;
    public const int T__46 = 46;
    public const int T__47 = 47;
    public const int T__40 = 40;
    public const int T__41 = 41;
    public const int IM_TIKZSET = 19;
    public const int T__42 = 42;
    public const int T__43 = 43;
    public const int T__91 = 91;
    public const int T__92 = 92;
    public const int T__93 = 93;
    public const int T__94 = 94;
    public const int T__90 = 90;
    public const int IM_ENDTAG = 14;
    public const int IM_STRING = 21;
    public const int MATHSTRING = 36;
    public const int T__95 = 95;
    public const int IM_COORD = 6;
    public const int IM_USETIKZLIB = 20;
    public const int FLOAT_WO_EXP = 30;
    public const int IM_PICTURE = 10;
    public const int IM_DONTCARE = 25;
    public const int T__70 = 70;
    public const int T__71 = 71;
    public const int T__72 = 72;
    public const int IM_OPTION_STYLE = 16;
    public const int INT = 31;
    public const int IM_OPTION_KV = 17;
    public const int T__77 = 77;
    public const int T__78 = 78;
    public const int ESC_SEQ = 35;
    public const int T__79 = 79;
    public const int T__73 = 73;
    public const int WS = 32;
    public const int EOF = -1;
    public const int T__74 = 74;
    public const int T__75 = 75;
    public const int T__76 = 76;
    public const int T__80 = 80;
    public const int T__81 = 81;
    public const int T__82 = 82;
    public const int T__83 = 83;
    public const int TIKZEDT_CMD_COMMENT = 27;
    public const int T__88 = 88;
    public const int T__89 = 89;
    public const int T__84 = 84;
    public const int T__85 = 85;
    public const int IM_STYLE = 22;
    public const int T__86 = 86;
    public const int T__87 = 87;
    public const int IM_CONTROLS = 23;

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
		get { return "E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g"; }
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:140:1: tikzdocument : ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* tikzpicture ( . )* -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture ) ;
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
        RewriteRuleSubtreeStream stream_tikzpicture = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture");
        RewriteRuleSubtreeStream stream_dontcare_preamble = new RewriteRuleSubtreeStream(adaptor,"rule dontcare_preamble");
        RewriteRuleSubtreeStream stream_tikz_styleorsetorcmd = new RewriteRuleSubtreeStream(adaptor,"rule tikz_styleorsetorcmd");
        RewriteRuleSubtreeStream stream_otherbegin = new RewriteRuleSubtreeStream(adaptor,"rule otherbegin");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:141:2: ( ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* tikzpicture ( . )* -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:141:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* tikzpicture ( . )*
            {
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:141:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )*
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
            	    case 95:
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
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:141:5: dontcare_preamble
            			    {
            			    	PushFollow(FOLLOW_dontcare_preamble_in_tikzdocument257);
            			    	dontcare_preamble1 = dontcare_preamble();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_dontcare_preamble.Add(dontcare_preamble1.Tree);

            			    }
            			    break;
            			case 2 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:141:25: tikz_styleorsetorcmd
            			    {
            			    	PushFollow(FOLLOW_tikz_styleorsetorcmd_in_tikzdocument261);
            			    	tikz_styleorsetorcmd2 = tikz_styleorsetorcmd();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikz_styleorsetorcmd.Add(tikz_styleorsetorcmd2.Tree);

            			    }
            			    break;
            			case 3 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:141:48: otherbegin
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
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:141:74: ( . )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= IM_PATH && LA2_0 <= 95)) )
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
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:141:74: .
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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:141:80: ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DOCUMENT, "IM_DOCUMENT"), root_1);

            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:141:94: ( tikz_styleorsetorcmd )*
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:144:1: tikzdocument_wo_tikzpicture : ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* EOF -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* ) ;
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
        RewriteRuleSubtreeStream stream_tikz_styleorsetorcmd = new RewriteRuleSubtreeStream(adaptor,"rule tikz_styleorsetorcmd");
        RewriteRuleSubtreeStream stream_otherbegin = new RewriteRuleSubtreeStream(adaptor,"rule otherbegin");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:145:2: ( ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* EOF -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:145:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* EOF
            {
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:145:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )*
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
            	    case 95:
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
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:145:5: dontcare_preamble
            			    {
            			    	PushFollow(FOLLOW_dontcare_preamble_in_tikzdocument_wo_tikzpicture296);
            			    	dontcare_preamble6 = dontcare_preamble();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_dontcare_preamble.Add(dontcare_preamble6.Tree);

            			    }
            			    break;
            			case 2 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:145:25: tikz_styleorsetorcmd
            			    {
            			    	PushFollow(FOLLOW_tikz_styleorsetorcmd_in_tikzdocument_wo_tikzpicture300);
            			    	tikz_styleorsetorcmd7 = tikz_styleorsetorcmd();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikz_styleorsetorcmd.Add(tikz_styleorsetorcmd7.Tree);

            			    }
            			    break;
            			case 3 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:145:48: otherbegin
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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:145:69: ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DOCUMENT, "IM_DOCUMENT"), root_1);

            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:145:83: ( tikz_styleorsetorcmd )*
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:148:1: tikz_cmd_comment : TIKZEDT_CMD_COMMENT -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT ) ;
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
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:149:2: ( TIKZEDT_CMD_COMMENT -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:149:4: TIKZEDT_CMD_COMMENT
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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:149:30: ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT )
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:152:1: tikz_styleorsetorcmd : ( tikz_style | tikz_set | tikz_cmd_comment );
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
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:153:2: ( tikz_style | tikz_set | tikz_cmd_comment )
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
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:153:4: tikz_style
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
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:153:17: tikz_set
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
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:153:28: tikz_cmd_comment
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:156:1: dontcare_preamble : ~ ( '\\\\begin' | '\\\\tikzstyle' | '\\\\tikzset' | '\\\\tikz' | TIKZEDT_CMD_COMMENT ) ;
    public simpletikzParser.dontcare_preamble_return dontcare_preamble() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_preamble_return retval = new simpletikzParser.dontcare_preamble_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set14 = null;

        object set14_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:157:2: (~ ( '\\\\begin' | '\\\\tikzstyle' | '\\\\tikzset' | '\\\\tikz' | TIKZEDT_CMD_COMMENT ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:157:4: ~ ( '\\\\begin' | '\\\\tikzstyle' | '\\\\tikzset' | '\\\\tikz' | TIKZEDT_CMD_COMMENT )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set14 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= IM_ARC) || (input.LA(1) >= ID && input.LA(1) <= SOMETHING1) || (input.LA(1) >= 43 && input.LA(1) <= 95) ) 
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:159:1: otherbegin : '\\\\begin' '{' idd2 '}' ;
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
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:160:2: ( '\\\\begin' '{' idd2 '}' )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:160:4: '\\\\begin' '{' idd2 '}'
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:163:1: tikz_style : '\\\\tikzstyle' '{' idd '}' ( '=' | '+=' ) tikz_options -> ^( IM_STYLE idd tikz_options ) ;
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
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_46 = new RewriteRuleTokenStream(adaptor,"token 46");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:164:2: ( '\\\\tikzstyle' '{' idd '}' ( '=' | '+=' ) tikz_options -> ^( IM_STYLE idd tikz_options ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:164:4: '\\\\tikzstyle' '{' idd '}' ( '=' | '+=' ) tikz_options
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

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:164:30: ( '=' | '+=' )
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
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:164:31: '='
            	        {
            	        	char_literal23=(IToken)Match(input,45,FOLLOW_45_in_tikz_style427); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_45.Add(char_literal23);


            	        }
            	        break;
            	    case 2 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:164:37: '+='
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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:164:59: ^( IM_STYLE idd tikz_options )
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:167:1: tikz_options : squarebr_start ( option ( ',' option )* ( ',' )? )? ( tikzstring )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) ;
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
        RewriteRuleSubtreeStream stream_tikzstring = new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_squarebr_end = new RewriteRuleSubtreeStream(adaptor,"rule squarebr_end");
        RewriteRuleSubtreeStream stream_squarebr_start = new RewriteRuleSubtreeStream(adaptor,"rule squarebr_start");
        RewriteRuleSubtreeStream stream_option = new RewriteRuleSubtreeStream(adaptor,"rule option");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:168:2: ( squarebr_start ( option ( ',' option )* ( ',' )? )? ( tikzstring )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:168:5: squarebr_start ( option ( ',' option )* ( ',' )? )? ( tikzstring )? squarebr_end
            {
            	PushFollow(FOLLOW_squarebr_start_in_tikz_options456);
            	squarebr_start26 = squarebr_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_squarebr_start.Add(squarebr_start26.Tree);
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:168:20: ( option ( ',' option )* ( ',' )? )?
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( ((LA8_0 >= IM_PATH && LA8_0 <= 42) || LA8_0 == 46 || (LA8_0 >= 51 && LA8_0 <= 52) || (LA8_0 >= 58 && LA8_0 <= 95)) )
            	{
            	    alt8 = 1;
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:168:21: option ( ',' option )* ( ',' )?
            	        {
            	        	PushFollow(FOLLOW_option_in_tikz_options459);
            	        	option27 = option();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_option.Add(option27.Tree);
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:168:28: ( ',' option )*
            	        	do 
            	        	{
            	        	    int alt6 = 2;
            	        	    int LA6_0 = input.LA(1);

            	        	    if ( (LA6_0 == 47) )
            	        	    {
            	        	        int LA6_1 = input.LA(2);

            	        	        if ( ((LA6_1 >= IM_PATH && LA6_1 <= 42) || LA6_1 == 46 || (LA6_1 >= 51 && LA6_1 <= 52) || (LA6_1 >= 58 && LA6_1 <= 95)) )
            	        	        {
            	        	            alt6 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt6) 
            	        		{
            	        			case 1 :
            	        			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:168:29: ',' option
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

            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:168:42: ( ',' )?
            	        	int alt7 = 2;
            	        	int LA7_0 = input.LA(1);

            	        	if ( (LA7_0 == 47) )
            	        	{
            	        	    alt7 = 1;
            	        	}
            	        	switch (alt7) 
            	        	{
            	        	    case 1 :
            	        	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:168:42: ','
            	        	        {
            	        	        	char_literal30=(IToken)Match(input,47,FOLLOW_47_in_tikz_options468); if (state.failed) return retval; 
            	        	        	if ( state.backtracking==0 ) stream_47.Add(char_literal30);


            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:168:49: ( tikzstring )?
            	int alt9 = 2;
            	int LA9_0 = input.LA(1);

            	if ( (LA9_0 == 43) )
            	{
            	    alt9 = 1;
            	}
            	switch (alt9) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:168:49: tikzstring
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
            	// elements:          option, squarebr_end, squarebr_start
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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:168:78: ^( IM_OPTIONS squarebr_start ( option )* squarebr_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTIONS, "IM_OPTIONS"), root_1);

            	    adaptor.AddChild(root_1, stream_squarebr_start.NextTree());
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:168:106: ( option )*
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:171:1: option : ( option_style | option_kv );
    public simpletikzParser.option_return option() // throws RecognitionException [1]
    {   
        simpletikzParser.option_return retval = new simpletikzParser.option_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.option_style_return option_style33 = default(simpletikzParser.option_style_return);

        simpletikzParser.option_kv_return option_kv34 = default(simpletikzParser.option_kv_return);



        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:172:2: ( option_style | option_kv )
            int alt10 = 2;
            alt10 = dfa10.Predict(input);
            switch (alt10) 
            {
                case 1 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:172:4: option_style
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
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:173:5: option_kv
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:176:1: option_kv : idd ( '=' iddornumberunitorstringorrange )? -> ^( IM_OPTION_KV idd ( iddornumberunitorstringorrange )? ) ;
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
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:177:2: ( idd ( '=' iddornumberunitorstringorrange )? -> ^( IM_OPTION_KV idd ( iddornumberunitorstringorrange )? ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:177:4: idd ( '=' iddornumberunitorstringorrange )?
            {
            	PushFollow(FOLLOW_idd_in_option_kv524);
            	idd35 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_idd.Add(idd35.Tree);
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:177:8: ( '=' iddornumberunitorstringorrange )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == 45) )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:177:9: '=' iddornumberunitorstringorrange
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
            	// elements:          iddornumberunitorstringorrange, idd
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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:177:50: ^( IM_OPTION_KV idd ( iddornumberunitorstringorrange )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTION_KV, "IM_OPTION_KV"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:177:69: ( iddornumberunitorstringorrange )?
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:180:1: tikzstring : '{' ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* '}' -> ^( IM_STRING '{' '}' ) ;
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
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleSubtreeStream stream_tikzstring = new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_no_rlbrace = new RewriteRuleSubtreeStream(adaptor,"rule no_rlbrace");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:181:2: ( '{' ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* '}' -> ^( IM_STRING '{' '}' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:181:4: '{' ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* '}'
            {
            	char_literal38=(IToken)Match(input,43,FOLLOW_43_in_tikzstring557); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_43.Add(char_literal38);

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:181:8: ( no_rlbrace )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( ((LA12_0 >= IM_PATH && LA12_0 <= 42) || (LA12_0 >= 45 && LA12_0 <= 95)) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:181:8: no_rlbrace
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

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:181:20: ( tikzstring ( no_rlbrace )* )*
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
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:181:21: tikzstring ( no_rlbrace )*
            			    {
            			    	PushFollow(FOLLOW_tikzstring_in_tikzstring563);
            			    	tikzstring40 = tikzstring();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikzstring.Add(tikzstring40.Tree);
            			    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:181:32: ( no_rlbrace )*
            			    	do 
            			    	{
            			    	    int alt13 = 2;
            			    	    int LA13_0 = input.LA(1);

            			    	    if ( ((LA13_0 >= IM_PATH && LA13_0 <= 42) || (LA13_0 >= 45 && LA13_0 <= 95)) )
            			    	    {
            			    	        alt13 = 1;
            			    	    }


            			    	    switch (alt13) 
            			    		{
            			    			case 1 :
            			    			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:181:32: no_rlbrace
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
            	// elements:          44, 43
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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:181:53: ^( IM_STRING '{' '}' )
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:184:1: no_rlbrace : ~ ( '{' | '}' ) ;
    public simpletikzParser.no_rlbrace_return no_rlbrace() // throws RecognitionException [1]
    {   
        simpletikzParser.no_rlbrace_return retval = new simpletikzParser.no_rlbrace_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set43 = null;

        object set43_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:185:2: (~ ( '{' | '}' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:185:4: ~ ( '{' | '}' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set43 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= 42) || (input.LA(1) >= 45 && input.LA(1) <= 95) ) 
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:187:1: iddornumberunitorstringorrange : ( range | numberunit | bracedcoord | idd | ( ( number ':' )? tikzstring ) );
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
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:188:2: ( range | numberunit | bracedcoord | idd | ( ( number ':' )? tikzstring ) )
            int alt16 = 5;
            alt16 = dfa16.Predict(input);
            switch (alt16) 
            {
                case 1 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:188:5: range
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
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:188:13: numberunit
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
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:188:26: bracedcoord
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
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:188:40: idd
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
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:188:46: ( ( number ':' )? tikzstring )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:188:46: ( ( number ':' )? tikzstring )
                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:188:47: ( number ':' )? tikzstring
                    	{
                    		// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:188:47: ( number ':' )?
                    		int alt15 = 2;
                    		int LA15_0 = input.LA(1);

                    		if ( ((LA15_0 >= FLOAT_WO_EXP && LA15_0 <= INT)) )
                    		{
                    		    alt15 = 1;
                    		}
                    		switch (alt15) 
                    		{
                    		    case 1 :
                    		        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:188:49: number ':'
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:190:1: bracedcoord : '{' coord_nooption '}' ;
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
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:191:2: ( '{' coord_nooption '}' )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:191:4: '{' coord_nooption '}'
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:193:1: range : numberunit ':' numberunit -> ^( IM_STRING numberunit ':' numberunit ) ;
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
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:194:2: ( numberunit ':' numberunit -> ^( IM_STRING numberunit ':' numberunit ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:194:4: numberunit ':' numberunit
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
            	// elements:          48, numberunit, numberunit
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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:194:33: ^( IM_STRING numberunit ':' numberunit )
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:196:1: option_style : idd ( '/.style' | ( '/.append' 'style' ) | ( '/.style' number 'args' ) ) '=' '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}' -> ^( IM_OPTION_STYLE idd ( option_kv )* ) ;
    public simpletikzParser.option_style_return option_style() // throws RecognitionException [1]
    {   
        simpletikzParser.option_style_return retval = new simpletikzParser.option_style_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal58 = null;
        IToken string_literal59 = null;
        IToken string_literal60 = null;
        IToken string_literal61 = null;
        IToken string_literal63 = null;
        IToken char_literal64 = null;
        IToken char_literal65 = null;
        IToken char_literal67 = null;
        IToken char_literal69 = null;
        IToken char_literal70 = null;
        simpletikzParser.idd_return idd57 = default(simpletikzParser.idd_return);

        simpletikzParser.number_return number62 = default(simpletikzParser.number_return);

        simpletikzParser.option_kv_return option_kv66 = default(simpletikzParser.option_kv_return);

        simpletikzParser.option_kv_return option_kv68 = default(simpletikzParser.option_kv_return);


        object string_literal58_tree=null;
        object string_literal59_tree=null;
        object string_literal60_tree=null;
        object string_literal61_tree=null;
        object string_literal63_tree=null;
        object char_literal64_tree=null;
        object char_literal65_tree=null;
        object char_literal67_tree=null;
        object char_literal69_tree=null;
        object char_literal70_tree=null;
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_47 = new RewriteRuleTokenStream(adaptor,"token 47");
        RewriteRuleTokenStream stream_49 = new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleSubtreeStream stream_number = new RewriteRuleSubtreeStream(adaptor,"rule number");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_option_kv = new RewriteRuleSubtreeStream(adaptor,"rule option_kv");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:2: ( idd ( '/.style' | ( '/.append' 'style' ) | ( '/.style' number 'args' ) ) '=' '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}' -> ^( IM_OPTION_STYLE idd ( option_kv )* ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:4: idd ( '/.style' | ( '/.append' 'style' ) | ( '/.style' number 'args' ) ) '=' '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}'
            {
            	PushFollow(FOLLOW_idd_in_option_style697);
            	idd57 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_idd.Add(idd57.Tree);
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:8: ( '/.style' | ( '/.append' 'style' ) | ( '/.style' number 'args' ) )
            	int alt17 = 3;
            	int LA17_0 = input.LA(1);

            	if ( (LA17_0 == 49) )
            	{
            	    int LA17_1 = input.LA(2);

            	    if ( ((LA17_1 >= FLOAT_WO_EXP && LA17_1 <= INT)) )
            	    {
            	        alt17 = 3;
            	    }
            	    else if ( (LA17_1 == 45) )
            	    {
            	        alt17 = 1;
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d17s1 =
            	            new NoViableAltException("", 17, 1, input);

            	        throw nvae_d17s1;
            	    }
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
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:9: '/.style'
            	        {
            	        	string_literal58=(IToken)Match(input,49,FOLLOW_49_in_option_style700); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_49.Add(string_literal58);


            	        }
            	        break;
            	    case 2 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:21: ( '/.append' 'style' )
            	        {
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:21: ( '/.append' 'style' )
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:22: '/.append' 'style'
            	        	{
            	        		string_literal59=(IToken)Match(input,50,FOLLOW_50_in_option_style705); if (state.failed) return retval; 
            	        		if ( state.backtracking==0 ) stream_50.Add(string_literal59);

            	        		string_literal60=(IToken)Match(input,51,FOLLOW_51_in_option_style707); if (state.failed) return retval; 
            	        		if ( state.backtracking==0 ) stream_51.Add(string_literal60);


            	        	}


            	        }
            	        break;
            	    case 3 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:45: ( '/.style' number 'args' )
            	        {
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:45: ( '/.style' number 'args' )
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:46: '/.style' number 'args'
            	        	{
            	        		string_literal61=(IToken)Match(input,49,FOLLOW_49_in_option_style714); if (state.failed) return retval; 
            	        		if ( state.backtracking==0 ) stream_49.Add(string_literal61);

            	        		PushFollow(FOLLOW_number_in_option_style716);
            	        		number62 = number();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking==0 ) stream_number.Add(number62.Tree);
            	        		string_literal63=(IToken)Match(input,52,FOLLOW_52_in_option_style718); if (state.failed) return retval; 
            	        		if ( state.backtracking==0 ) stream_52.Add(string_literal63);


            	        	}


            	        }
            	        break;

            	}

            	char_literal64=(IToken)Match(input,45,FOLLOW_45_in_option_style722); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_45.Add(char_literal64);

            	char_literal65=(IToken)Match(input,43,FOLLOW_43_in_option_style724); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_43.Add(char_literal65);

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:80: ( option_kv ( ',' option_kv )* )?
            	int alt19 = 2;
            	int LA19_0 = input.LA(1);

            	if ( ((LA19_0 >= IM_PATH && LA19_0 <= 42) || LA19_0 == 46 || (LA19_0 >= 51 && LA19_0 <= 52) || (LA19_0 >= 58 && LA19_0 <= 95)) )
            	{
            	    alt19 = 1;
            	}
            	switch (alt19) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:81: option_kv ( ',' option_kv )*
            	        {
            	        	PushFollow(FOLLOW_option_kv_in_option_style727);
            	        	option_kv66 = option_kv();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_option_kv.Add(option_kv66.Tree);
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:91: ( ',' option_kv )*
            	        	do 
            	        	{
            	        	    int alt18 = 2;
            	        	    int LA18_0 = input.LA(1);

            	        	    if ( (LA18_0 == 47) )
            	        	    {
            	        	        int LA18_1 = input.LA(2);

            	        	        if ( ((LA18_1 >= IM_PATH && LA18_1 <= 42) || LA18_1 == 46 || (LA18_1 >= 51 && LA18_1 <= 52) || (LA18_1 >= 58 && LA18_1 <= 95)) )
            	        	        {
            	        	            alt18 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt18) 
            	        		{
            	        			case 1 :
            	        			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:92: ',' option_kv
            	        			    {
            	        			    	char_literal67=(IToken)Match(input,47,FOLLOW_47_in_option_style730); if (state.failed) return retval; 
            	        			    	if ( state.backtracking==0 ) stream_47.Add(char_literal67);

            	        			    	PushFollow(FOLLOW_option_kv_in_option_style732);
            	        			    	option_kv68 = option_kv();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking==0 ) stream_option_kv.Add(option_kv68.Tree);

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

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:111: ( ',' )?
            	int alt20 = 2;
            	int LA20_0 = input.LA(1);

            	if ( (LA20_0 == 47) )
            	{
            	    alt20 = 1;
            	}
            	switch (alt20) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:111: ','
            	        {
            	        	char_literal69=(IToken)Match(input,47,FOLLOW_47_in_option_style739); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_47.Add(char_literal69);


            	        }
            	        break;

            	}

            	char_literal70=(IToken)Match(input,44,FOLLOW_44_in_option_style742); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_44.Add(char_literal70);



            	// AST REWRITE
            	// elements:          option_kv, idd
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 197:121: -> ^( IM_OPTION_STYLE idd ( option_kv )* )
            	{
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:124: ^( IM_OPTION_STYLE idd ( option_kv )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTION_STYLE, "IM_OPTION_STYLE"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:146: ( option_kv )*
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:209:1: idd : idd_heavenknowswhythisisnecessary -> ^( IM_ID ) ;
    public simpletikzParser.idd_return idd() // throws RecognitionException [1]
    {   
        simpletikzParser.idd_return retval = new simpletikzParser.idd_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.idd_heavenknowswhythisisnecessary_return idd_heavenknowswhythisisnecessary71 = default(simpletikzParser.idd_heavenknowswhythisisnecessary_return);


        RewriteRuleSubtreeStream stream_idd_heavenknowswhythisisnecessary = new RewriteRuleSubtreeStream(adaptor,"rule idd_heavenknowswhythisisnecessary");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:210:2: ( idd_heavenknowswhythisisnecessary -> ^( IM_ID ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:210:4: idd_heavenknowswhythisisnecessary
            {
            	PushFollow(FOLLOW_idd_heavenknowswhythisisnecessary_in_idd777);
            	idd_heavenknowswhythisisnecessary71 = idd_heavenknowswhythisisnecessary();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_idd_heavenknowswhythisisnecessary.Add(idd_heavenknowswhythisisnecessary71.Tree);


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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:210:42: ^( IM_ID )
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:212:1: idd_heavenknowswhythisisnecessary : (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' ) )+ ;
    public simpletikzParser.idd_heavenknowswhythisisnecessary_return idd_heavenknowswhythisisnecessary() // throws RecognitionException [1]
    {   
        simpletikzParser.idd_heavenknowswhythisisnecessary_return retval = new simpletikzParser.idd_heavenknowswhythisisnecessary_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set72 = null;

        object set72_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:213:3: ( (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' ) )+ )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:213:6: (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' ) )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:213:6: (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' ) )+
            	int cnt21 = 0;
            	do 
            	{
            	    int alt21 = 2;
            	    int LA21_0 = input.LA(1);

            	    if ( (LA21_0 == 79) )
            	    {
            	        int LA21_2 = input.LA(2);

            	        if ( ((LA21_2 >= FLOAT_WO_EXP && LA21_2 <= INT) || (LA21_2 >= 43 && LA21_2 <= 45) || (LA21_2 >= 47 && LA21_2 <= 50) || LA21_2 == 54 || LA21_2 == 56 || LA21_2 == 79) )
            	        {
            	            alt21 = 1;
            	        }
            	        else if ( ((LA21_2 >= IM_PATH && LA21_2 <= COMMAND) || (LA21_2 >= WS && LA21_2 <= 42) || LA21_2 == 46 || (LA21_2 >= 51 && LA21_2 <= 52) || (LA21_2 >= 58 && LA21_2 <= 78) || (LA21_2 >= 80 && LA21_2 <= 95)) )
            	        {
            	            alt21 = 1;
            	        }


            	    }
            	    else if ( ((LA21_0 >= IM_PATH && LA21_0 <= 42) || LA21_0 == 46 || (LA21_0 >= 51 && LA21_0 <= 52) || (LA21_0 >= 58 && LA21_0 <= 78) || (LA21_0 >= 80 && LA21_0 <= 95)) )
            	    {
            	        alt21 = 1;
            	    }


            	    switch (alt21) 
            		{
            			case 1 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:213:6: ~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' )
            			    {
            			    	set72 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= 42) || input.LA(1) == 46 || (input.LA(1) >= 51 && input.LA(1) <= 52) || (input.LA(1) >= 58 && input.LA(1) <= 95) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set72));
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:214:1: idd2 : ( ID )+ -> ^( IM_ID ) ;
    public simpletikzParser.idd2_return idd2() // throws RecognitionException [1]
    {   
        simpletikzParser.idd2_return retval = new simpletikzParser.idd2_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID73 = null;

        object ID73_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:215:2: ( ( ID )+ -> ^( IM_ID ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:215:4: ( ID )+
            {
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:215:4: ( ID )+
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
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:215:4: ID
            			    {
            			    	ID73=(IToken)Match(input,ID,FOLLOW_ID_in_idd2857); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_ID.Add(ID73);


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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:215:11: ^( IM_ID )
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:218:1: numberunitorvariable : ( numberunit | COMMAND );
    public simpletikzParser.numberunitorvariable_return numberunitorvariable() // throws RecognitionException [1]
    {   
        simpletikzParser.numberunitorvariable_return retval = new simpletikzParser.numberunitorvariable_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken COMMAND75 = null;
        simpletikzParser.numberunit_return numberunit74 = default(simpletikzParser.numberunit_return);


        object COMMAND75_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:219:2: ( numberunit | COMMAND )
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
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:219:4: numberunit
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_numberunit_in_numberunitorvariable876);
                    	numberunit74 = numberunit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, numberunit74.Tree);

                    }
                    break;
                case 2 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:220:4: COMMAND
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	COMMAND75=(IToken)Match(input,COMMAND,FOLLOW_COMMAND_in_numberunitorvariable881); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{COMMAND75_tree = (object)adaptor.Create(COMMAND75);
                    		adaptor.AddChild(root_0, COMMAND75_tree);
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:223:1: numberunit : number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) ;
    public simpletikzParser.numberunit_return numberunit() // throws RecognitionException [1]
    {   
        simpletikzParser.numberunit_return retval = new simpletikzParser.numberunit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.number_return number76 = default(simpletikzParser.number_return);

        simpletikzParser.unit_return unit77 = default(simpletikzParser.unit_return);


        RewriteRuleSubtreeStream stream_number = new RewriteRuleSubtreeStream(adaptor,"rule number");
        RewriteRuleSubtreeStream stream_unit = new RewriteRuleSubtreeStream(adaptor,"rule unit");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:224:2: ( number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:224:4: number ( unit )?
            {
            	PushFollow(FOLLOW_number_in_numberunit894);
            	number76 = number();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_number.Add(number76.Tree);
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:224:11: ( unit )?
            	int alt24 = 2;
            	int LA24_0 = input.LA(1);

            	if ( ((LA24_0 >= 58 && LA24_0 <= 63)) )
            	{
            	    alt24 = 1;
            	}
            	switch (alt24) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:224:11: unit
            	        {
            	        	PushFollow(FOLLOW_unit_in_numberunit896);
            	        	unit77 = unit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_unit.Add(unit77.Tree);

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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:224:20: ^( IM_NUMBERUNIT number ( unit )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NUMBERUNIT, "IM_NUMBERUNIT"), root_1);

            	    adaptor.AddChild(root_1, stream_number.NextTree());
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:224:43: ( unit )?
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:228:1: number : ( FLOAT_WO_EXP | INT ) ;
    public simpletikzParser.number_return number() // throws RecognitionException [1]
    {   
        simpletikzParser.number_return retval = new simpletikzParser.number_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set78 = null;

        object set78_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:229:2: ( ( FLOAT_WO_EXP | INT ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:229:4: ( FLOAT_WO_EXP | INT )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set78 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= FLOAT_WO_EXP && input.LA(1) <= INT) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set78));
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:232:1: unit : ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' | 'em' );
    public simpletikzParser.unit_return unit() // throws RecognitionException [1]
    {   
        simpletikzParser.unit_return retval = new simpletikzParser.unit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set79 = null;

        object set79_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:233:2: ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' | 'em' )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set79 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 58 && input.LA(1) <= 63) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set79));
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:236:1: tikz_set : tikz_set_start ( option ( ',' option )* ( ',' )? )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) ;
    public simpletikzParser.tikz_set_return tikz_set() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_set_return retval = new simpletikzParser.tikz_set_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal82 = null;
        IToken char_literal84 = null;
        simpletikzParser.tikz_set_start_return tikz_set_start80 = default(simpletikzParser.tikz_set_start_return);

        simpletikzParser.option_return option81 = default(simpletikzParser.option_return);

        simpletikzParser.option_return option83 = default(simpletikzParser.option_return);

        simpletikzParser.roundbr_end_return roundbr_end85 = default(simpletikzParser.roundbr_end_return);


        object char_literal82_tree=null;
        object char_literal84_tree=null;
        RewriteRuleTokenStream stream_47 = new RewriteRuleTokenStream(adaptor,"token 47");
        RewriteRuleSubtreeStream stream_tikz_set_start = new RewriteRuleSubtreeStream(adaptor,"rule tikz_set_start");
        RewriteRuleSubtreeStream stream_roundbr_end = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        RewriteRuleSubtreeStream stream_option = new RewriteRuleSubtreeStream(adaptor,"rule option");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:237:2: ( tikz_set_start ( option ( ',' option )* ( ',' )? )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:237:5: tikz_set_start ( option ( ',' option )* ( ',' )? )? roundbr_end
            {
            	PushFollow(FOLLOW_tikz_set_start_in_tikz_set977);
            	tikz_set_start80 = tikz_set_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikz_set_start.Add(tikz_set_start80.Tree);
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:237:20: ( option ( ',' option )* ( ',' )? )?
            	int alt27 = 2;
            	int LA27_0 = input.LA(1);

            	if ( ((LA27_0 >= IM_PATH && LA27_0 <= 42) || LA27_0 == 46 || (LA27_0 >= 51 && LA27_0 <= 52) || (LA27_0 >= 58 && LA27_0 <= 95)) )
            	{
            	    alt27 = 1;
            	}
            	switch (alt27) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:237:21: option ( ',' option )* ( ',' )?
            	        {
            	        	PushFollow(FOLLOW_option_in_tikz_set980);
            	        	option81 = option();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_option.Add(option81.Tree);
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:237:28: ( ',' option )*
            	        	do 
            	        	{
            	        	    int alt25 = 2;
            	        	    int LA25_0 = input.LA(1);

            	        	    if ( (LA25_0 == 47) )
            	        	    {
            	        	        int LA25_1 = input.LA(2);

            	        	        if ( ((LA25_1 >= IM_PATH && LA25_1 <= 42) || LA25_1 == 46 || (LA25_1 >= 51 && LA25_1 <= 52) || (LA25_1 >= 58 && LA25_1 <= 95)) )
            	        	        {
            	        	            alt25 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt25) 
            	        		{
            	        			case 1 :
            	        			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:237:29: ',' option
            	        			    {
            	        			    	char_literal82=(IToken)Match(input,47,FOLLOW_47_in_tikz_set983); if (state.failed) return retval; 
            	        			    	if ( state.backtracking==0 ) stream_47.Add(char_literal82);

            	        			    	PushFollow(FOLLOW_option_in_tikz_set985);
            	        			    	option83 = option();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking==0 ) stream_option.Add(option83.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop25;
            	        	    }
            	        	} while (true);

            	        	loop25:
            	        		;	// Stops C# compiler whining that label 'loop25' has no statements

            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:237:42: ( ',' )?
            	        	int alt26 = 2;
            	        	int LA26_0 = input.LA(1);

            	        	if ( (LA26_0 == 47) )
            	        	{
            	        	    alt26 = 1;
            	        	}
            	        	switch (alt26) 
            	        	{
            	        	    case 1 :
            	        	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:237:42: ','
            	        	        {
            	        	        	char_literal84=(IToken)Match(input,47,FOLLOW_47_in_tikz_set989); if (state.failed) return retval; 
            	        	        	if ( state.backtracking==0 ) stream_47.Add(char_literal84);


            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_roundbr_end_in_tikz_set994);
            	roundbr_end85 = roundbr_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_roundbr_end.Add(roundbr_end85.Tree);


            	// AST REWRITE
            	// elements:          tikz_set_start, option, roundbr_end
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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:237:64: ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_TIKZSET, "IM_TIKZSET"), root_1);

            	    adaptor.AddChild(root_1, stream_tikz_set_start.NextTree());
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:237:92: ( option )*
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:242:1: tikzpicture : ( ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) | ( tikz_start ( tikz_options )? '{' ( tikzbody2 )? roundbr_end ) -> ^( IM_PICTURE tikz_start ( tikz_options )? ( tikzbody2 )? roundbr_end ) );
    public simpletikzParser.tikzpicture_return tikzpicture() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_return retval = new simpletikzParser.tikzpicture_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal92 = null;
        simpletikzParser.tikzpicture_start_return tikzpicture_start86 = default(simpletikzParser.tikzpicture_start_return);

        simpletikzParser.tikz_options_return tikz_options87 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody_return tikzbody88 = default(simpletikzParser.tikzbody_return);

        simpletikzParser.tikzpicture_end_return tikzpicture_end89 = default(simpletikzParser.tikzpicture_end_return);

        simpletikzParser.tikz_start_return tikz_start90 = default(simpletikzParser.tikz_start_return);

        simpletikzParser.tikz_options_return tikz_options91 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody2_return tikzbody293 = default(simpletikzParser.tikzbody2_return);

        simpletikzParser.roundbr_end_return roundbr_end94 = default(simpletikzParser.roundbr_end_return);


        object char_literal92_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        RewriteRuleSubtreeStream stream_tikz_start = new RewriteRuleSubtreeStream(adaptor,"rule tikz_start");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikzpicture_start = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_start");
        RewriteRuleSubtreeStream stream_tikzpicture_end = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_end");
        RewriteRuleSubtreeStream stream_tikzbody2 = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody2");
        RewriteRuleSubtreeStream stream_roundbr_end = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:243:2: ( ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) | ( tikz_start ( tikz_options )? '{' ( tikzbody2 )? roundbr_end ) -> ^( IM_PICTURE tikz_start ( tikz_options )? ( tikzbody2 )? roundbr_end ) )
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
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:243:7: ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
                    {
                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:243:7: ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:243:9: tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end
                    	{
                    		PushFollow(FOLLOW_tikzpicture_start_in_tikzpicture1026);
                    		tikzpicture_start86 = tikzpicture_start();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_tikzpicture_start.Add(tikzpicture_start86.Tree);
                    		// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:243:27: ( tikz_options )?
                    		int alt28 = 2;
                    		int LA28_0 = input.LA(1);

                    		if ( (LA28_0 == 55) )
                    		{
                    		    alt28 = 1;
                    		}
                    		switch (alt28) 
                    		{
                    		    case 1 :
                    		        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:243:27: tikz_options
                    		        {
                    		        	PushFollow(FOLLOW_tikz_options_in_tikzpicture1028);
                    		        	tikz_options87 = tikz_options();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_tikz_options.Add(tikz_options87.Tree);

                    		        }
                    		        break;

                    		}

                    		// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:243:41: ( tikzbody )?
                    		int alt29 = 2;
                    		int LA29_0 = input.LA(1);

                    		if ( ((LA29_0 >= IM_PATH && LA29_0 <= 54) || (LA29_0 >= 56 && LA29_0 <= 63) || (LA29_0 >= 65 && LA29_0 <= 95)) )
                    		{
                    		    alt29 = 1;
                    		}
                    		else if ( (LA29_0 == 64) )
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
                    		        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:243:41: tikzbody
                    		        {
                    		        	PushFollow(FOLLOW_tikzbody_in_tikzpicture1031);
                    		        	tikzbody88 = tikzbody();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_tikzbody.Add(tikzbody88.Tree);

                    		        }
                    		        break;

                    		}

                    		PushFollow(FOLLOW_tikzpicture_end_in_tikzpicture1034);
                    		tikzpicture_end89 = tikzpicture_end();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_tikzpicture_end.Add(tikzpicture_end89.Tree);

                    	}



                    	// AST REWRITE
                    	// elements:          tikzbody, tikzpicture_start, tikzpicture_end, tikz_options
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
                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:243:71: ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PICTURE, "IM_PICTURE"), root_1);

                    	    adaptor.AddChild(root_1, stream_tikzpicture_start.NextTree());
                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:243:102: ( tikz_options )?
                    	    if ( stream_tikz_options.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_tikz_options.NextTree());

                    	    }
                    	    stream_tikz_options.Reset();
                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:243:116: ( tikzbody )?
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
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:244:5: ( tikz_start ( tikz_options )? '{' ( tikzbody2 )? roundbr_end )
                    {
                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:244:5: ( tikz_start ( tikz_options )? '{' ( tikzbody2 )? roundbr_end )
                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:244:7: tikz_start ( tikz_options )? '{' ( tikzbody2 )? roundbr_end
                    	{
                    		PushFollow(FOLLOW_tikz_start_in_tikzpicture1059);
                    		tikz_start90 = tikz_start();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_tikz_start.Add(tikz_start90.Tree);
                    		// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:244:19: ( tikz_options )?
                    		int alt30 = 2;
                    		int LA30_0 = input.LA(1);

                    		if ( (LA30_0 == 55) )
                    		{
                    		    alt30 = 1;
                    		}
                    		switch (alt30) 
                    		{
                    		    case 1 :
                    		        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:244:19: tikz_options
                    		        {
                    		        	PushFollow(FOLLOW_tikz_options_in_tikzpicture1062);
                    		        	tikz_options91 = tikz_options();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_tikz_options.Add(tikz_options91.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal92=(IToken)Match(input,43,FOLLOW_43_in_tikzpicture1065); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_43.Add(char_literal92);

                    		// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:244:37: ( tikzbody2 )?
                    		int alt31 = 2;
                    		int LA31_0 = input.LA(1);

                    		if ( ((LA31_0 >= IM_PATH && LA31_0 <= 42) || (LA31_0 >= 45 && LA31_0 <= 54) || (LA31_0 >= 56 && LA31_0 <= 95)) )
                    		{
                    		    alt31 = 1;
                    		}
                    		switch (alt31) 
                    		{
                    		    case 1 :
                    		        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:244:37: tikzbody2
                    		        {
                    		        	PushFollow(FOLLOW_tikzbody2_in_tikzpicture1067);
                    		        	tikzbody293 = tikzbody2();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_tikzbody2.Add(tikzbody293.Tree);

                    		        }
                    		        break;

                    		}

                    		PushFollow(FOLLOW_roundbr_end_in_tikzpicture1070);
                    		roundbr_end94 = roundbr_end();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_roundbr_end.Add(roundbr_end94.Tree);

                    	}



                    	// AST REWRITE
                    	// elements:          tikzbody2, tikz_start, tikz_options, roundbr_end
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
                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:244:66: ^( IM_PICTURE tikz_start ( tikz_options )? ( tikzbody2 )? roundbr_end )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PICTURE, "IM_PICTURE"), root_1);

                    	    adaptor.AddChild(root_1, stream_tikz_start.NextTree());
                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:244:90: ( tikz_options )?
                    	    if ( stream_tikz_options.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_tikz_options.NextTree());

                    	    }
                    	    stream_tikz_options.Reset();
                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:244:104: ( tikzbody2 )?
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:247:1: tikzbody : ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )* ;
    public simpletikzParser.tikzbody_return tikzbody() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzbody_return retval = new simpletikzParser.tikzbody_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_return tikzscope95 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath96 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznode_ext_return tikznode_ext97 = default(simpletikzParser.tikznode_ext_return);

        simpletikzParser.tikzdef_ext_return tikzdef_ext98 = default(simpletikzParser.tikzdef_ext_return);

        simpletikzParser.tikzmatrix_ext_return tikzmatrix_ext99 = default(simpletikzParser.tikzmatrix_ext_return);

        simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext100 = default(simpletikzParser.tikzcoordinate_ext_return);

        simpletikzParser.tikz_set_return tikz_set101 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style102 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin103 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend104 = default(simpletikzParser.otherend_return);

        simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr105 = default(simpletikzParser.dontcare_body_nobr_return);

        simpletikzParser.tikzscope_return tikzscope106 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath107 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznode_ext_return tikznode_ext108 = default(simpletikzParser.tikznode_ext_return);

        simpletikzParser.tikzdef_ext_return tikzdef_ext109 = default(simpletikzParser.tikzdef_ext_return);

        simpletikzParser.tikzmatrix_ext_return tikzmatrix_ext110 = default(simpletikzParser.tikzmatrix_ext_return);

        simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext111 = default(simpletikzParser.tikzcoordinate_ext_return);

        simpletikzParser.tikz_set_return tikz_set112 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style113 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin114 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend115 = default(simpletikzParser.otherend_return);

        simpletikzParser.dontcare_body_return dontcare_body116 = default(simpletikzParser.dontcare_body_return);



        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:248:2: ( ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )* )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:248:4: ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:248:4: ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr )
            	int alt33 = 11;
            	alt33 = dfa33.Predict(input);
            	switch (alt33) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:248:6: tikzscope
            	        {
            	        	PushFollow(FOLLOW_tikzscope_in_tikzbody1102);
            	        	tikzscope95 = tikzscope();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzscope95.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:248:18: tikzpath
            	        {
            	        	PushFollow(FOLLOW_tikzpath_in_tikzbody1106);
            	        	tikzpath96 = tikzpath();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath96.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:248:29: tikznode_ext
            	        {
            	        	PushFollow(FOLLOW_tikznode_ext_in_tikzbody1110);
            	        	tikznode_ext97 = tikznode_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_ext97.Tree);

            	        }
            	        break;
            	    case 4 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:248:44: tikzdef_ext
            	        {
            	        	PushFollow(FOLLOW_tikzdef_ext_in_tikzbody1114);
            	        	tikzdef_ext98 = tikzdef_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzdef_ext98.Tree);

            	        }
            	        break;
            	    case 5 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:248:58: tikzmatrix_ext
            	        {
            	        	PushFollow(FOLLOW_tikzmatrix_ext_in_tikzbody1118);
            	        	tikzmatrix_ext99 = tikzmatrix_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzmatrix_ext99.Tree);

            	        }
            	        break;
            	    case 6 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:248:75: tikzcoordinate_ext
            	        {
            	        	PushFollow(FOLLOW_tikzcoordinate_ext_in_tikzbody1122);
            	        	tikzcoordinate_ext100 = tikzcoordinate_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_ext100.Tree);

            	        }
            	        break;
            	    case 7 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:248:96: tikz_set
            	        {
            	        	PushFollow(FOLLOW_tikz_set_in_tikzbody1126);
            	        	tikz_set101 = tikz_set();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set101.Tree);

            	        }
            	        break;
            	    case 8 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:248:107: tikz_style
            	        {
            	        	PushFollow(FOLLOW_tikz_style_in_tikzbody1130);
            	        	tikz_style102 = tikz_style();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style102.Tree);

            	        }
            	        break;
            	    case 9 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:248:120: otherbegin
            	        {
            	        	PushFollow(FOLLOW_otherbegin_in_tikzbody1134);
            	        	otherbegin103 = otherbegin();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;
            	    case 10 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:248:134: otherend
            	        {
            	        	PushFollow(FOLLOW_otherend_in_tikzbody1139);
            	        	otherend104 = otherend();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;
            	    case 11 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:248:146: dontcare_body_nobr
            	        {
            	        	PushFollow(FOLLOW_dontcare_body_nobr_in_tikzbody1144);
            	        	dontcare_body_nobr105 = dontcare_body_nobr();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;

            	}

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:249:3: ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*
            	do 
            	{
            	    int alt34 = 12;
            	    alt34 = dfa34.Predict(input);
            	    switch (alt34) 
            		{
            			case 1 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:249:5: tikzscope
            			    {
            			    	PushFollow(FOLLOW_tikzscope_in_tikzbody1155);
            			    	tikzscope106 = tikzscope();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzscope106.Tree);

            			    }
            			    break;
            			case 2 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:249:17: tikzpath
            			    {
            			    	PushFollow(FOLLOW_tikzpath_in_tikzbody1159);
            			    	tikzpath107 = tikzpath();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath107.Tree);

            			    }
            			    break;
            			case 3 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:249:28: tikznode_ext
            			    {
            			    	PushFollow(FOLLOW_tikznode_ext_in_tikzbody1163);
            			    	tikznode_ext108 = tikznode_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_ext108.Tree);

            			    }
            			    break;
            			case 4 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:249:43: tikzdef_ext
            			    {
            			    	PushFollow(FOLLOW_tikzdef_ext_in_tikzbody1167);
            			    	tikzdef_ext109 = tikzdef_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzdef_ext109.Tree);

            			    }
            			    break;
            			case 5 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:249:57: tikzmatrix_ext
            			    {
            			    	PushFollow(FOLLOW_tikzmatrix_ext_in_tikzbody1171);
            			    	tikzmatrix_ext110 = tikzmatrix_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzmatrix_ext110.Tree);

            			    }
            			    break;
            			case 6 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:249:74: tikzcoordinate_ext
            			    {
            			    	PushFollow(FOLLOW_tikzcoordinate_ext_in_tikzbody1175);
            			    	tikzcoordinate_ext111 = tikzcoordinate_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_ext111.Tree);

            			    }
            			    break;
            			case 7 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:249:95: tikz_set
            			    {
            			    	PushFollow(FOLLOW_tikz_set_in_tikzbody1179);
            			    	tikz_set112 = tikz_set();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set112.Tree);

            			    }
            			    break;
            			case 8 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:249:106: tikz_style
            			    {
            			    	PushFollow(FOLLOW_tikz_style_in_tikzbody1183);
            			    	tikz_style113 = tikz_style();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style113.Tree);

            			    }
            			    break;
            			case 9 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:249:119: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzbody1187);
            			    	otherbegin114 = otherbegin();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;
            			case 10 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:249:133: otherend
            			    {
            			    	PushFollow(FOLLOW_otherend_in_tikzbody1192);
            			    	otherend115 = otherend();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;
            			case 11 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:249:145: dontcare_body
            			    {
            			    	PushFollow(FOLLOW_dontcare_body_in_tikzbody1197);
            			    	dontcare_body116 = dontcare_body();
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:251:1: tikzbody2 : ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr2 ) ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body2 )* ;
    public simpletikzParser.tikzbody2_return tikzbody2() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzbody2_return retval = new simpletikzParser.tikzbody2_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_return tikzscope117 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath118 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznode_ext_return tikznode_ext119 = default(simpletikzParser.tikznode_ext_return);

        simpletikzParser.tikzdef_ext_return tikzdef_ext120 = default(simpletikzParser.tikzdef_ext_return);

        simpletikzParser.tikzmatrix_ext_return tikzmatrix_ext121 = default(simpletikzParser.tikzmatrix_ext_return);

        simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext122 = default(simpletikzParser.tikzcoordinate_ext_return);

        simpletikzParser.tikz_set_return tikz_set123 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style124 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin125 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend126 = default(simpletikzParser.otherend_return);

        simpletikzParser.dontcare_body_nobr2_return dontcare_body_nobr2127 = default(simpletikzParser.dontcare_body_nobr2_return);

        simpletikzParser.tikzscope_return tikzscope128 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath129 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznode_ext_return tikznode_ext130 = default(simpletikzParser.tikznode_ext_return);

        simpletikzParser.tikzdef_ext_return tikzdef_ext131 = default(simpletikzParser.tikzdef_ext_return);

        simpletikzParser.tikzmatrix_ext_return tikzmatrix_ext132 = default(simpletikzParser.tikzmatrix_ext_return);

        simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext133 = default(simpletikzParser.tikzcoordinate_ext_return);

        simpletikzParser.tikz_set_return tikz_set134 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style135 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin136 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend137 = default(simpletikzParser.otherend_return);

        simpletikzParser.dontcare_body2_return dontcare_body2138 = default(simpletikzParser.dontcare_body2_return);



        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:252:2: ( ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr2 ) ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body2 )* )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:252:4: ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr2 ) ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body2 )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:252:4: ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr2 )
            	int alt35 = 11;
            	alt35 = dfa35.Predict(input);
            	switch (alt35) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:252:6: tikzscope
            	        {
            	        	PushFollow(FOLLOW_tikzscope_in_tikzbody21213);
            	        	tikzscope117 = tikzscope();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzscope117.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:252:18: tikzpath
            	        {
            	        	PushFollow(FOLLOW_tikzpath_in_tikzbody21217);
            	        	tikzpath118 = tikzpath();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath118.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:252:29: tikznode_ext
            	        {
            	        	PushFollow(FOLLOW_tikznode_ext_in_tikzbody21221);
            	        	tikznode_ext119 = tikznode_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_ext119.Tree);

            	        }
            	        break;
            	    case 4 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:252:44: tikzdef_ext
            	        {
            	        	PushFollow(FOLLOW_tikzdef_ext_in_tikzbody21225);
            	        	tikzdef_ext120 = tikzdef_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzdef_ext120.Tree);

            	        }
            	        break;
            	    case 5 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:252:58: tikzmatrix_ext
            	        {
            	        	PushFollow(FOLLOW_tikzmatrix_ext_in_tikzbody21229);
            	        	tikzmatrix_ext121 = tikzmatrix_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzmatrix_ext121.Tree);

            	        }
            	        break;
            	    case 6 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:252:75: tikzcoordinate_ext
            	        {
            	        	PushFollow(FOLLOW_tikzcoordinate_ext_in_tikzbody21233);
            	        	tikzcoordinate_ext122 = tikzcoordinate_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_ext122.Tree);

            	        }
            	        break;
            	    case 7 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:252:96: tikz_set
            	        {
            	        	PushFollow(FOLLOW_tikz_set_in_tikzbody21237);
            	        	tikz_set123 = tikz_set();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set123.Tree);

            	        }
            	        break;
            	    case 8 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:252:107: tikz_style
            	        {
            	        	PushFollow(FOLLOW_tikz_style_in_tikzbody21241);
            	        	tikz_style124 = tikz_style();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style124.Tree);

            	        }
            	        break;
            	    case 9 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:252:120: otherbegin
            	        {
            	        	PushFollow(FOLLOW_otherbegin_in_tikzbody21245);
            	        	otherbegin125 = otherbegin();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;
            	    case 10 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:252:134: otherend
            	        {
            	        	PushFollow(FOLLOW_otherend_in_tikzbody21250);
            	        	otherend126 = otherend();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;
            	    case 11 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:252:146: dontcare_body_nobr2
            	        {
            	        	PushFollow(FOLLOW_dontcare_body_nobr2_in_tikzbody21255);
            	        	dontcare_body_nobr2127 = dontcare_body_nobr2();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;

            	}

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:253:3: ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body2 )*
            	do 
            	{
            	    int alt36 = 12;
            	    alt36 = dfa36.Predict(input);
            	    switch (alt36) 
            		{
            			case 1 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:253:5: tikzscope
            			    {
            			    	PushFollow(FOLLOW_tikzscope_in_tikzbody21266);
            			    	tikzscope128 = tikzscope();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzscope128.Tree);

            			    }
            			    break;
            			case 2 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:253:17: tikzpath
            			    {
            			    	PushFollow(FOLLOW_tikzpath_in_tikzbody21270);
            			    	tikzpath129 = tikzpath();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath129.Tree);

            			    }
            			    break;
            			case 3 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:253:28: tikznode_ext
            			    {
            			    	PushFollow(FOLLOW_tikznode_ext_in_tikzbody21274);
            			    	tikznode_ext130 = tikznode_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_ext130.Tree);

            			    }
            			    break;
            			case 4 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:253:43: tikzdef_ext
            			    {
            			    	PushFollow(FOLLOW_tikzdef_ext_in_tikzbody21278);
            			    	tikzdef_ext131 = tikzdef_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzdef_ext131.Tree);

            			    }
            			    break;
            			case 5 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:253:57: tikzmatrix_ext
            			    {
            			    	PushFollow(FOLLOW_tikzmatrix_ext_in_tikzbody21282);
            			    	tikzmatrix_ext132 = tikzmatrix_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzmatrix_ext132.Tree);

            			    }
            			    break;
            			case 6 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:253:74: tikzcoordinate_ext
            			    {
            			    	PushFollow(FOLLOW_tikzcoordinate_ext_in_tikzbody21286);
            			    	tikzcoordinate_ext133 = tikzcoordinate_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_ext133.Tree);

            			    }
            			    break;
            			case 7 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:253:95: tikz_set
            			    {
            			    	PushFollow(FOLLOW_tikz_set_in_tikzbody21290);
            			    	tikz_set134 = tikz_set();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set134.Tree);

            			    }
            			    break;
            			case 8 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:253:106: tikz_style
            			    {
            			    	PushFollow(FOLLOW_tikz_style_in_tikzbody21294);
            			    	tikz_style135 = tikz_style();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style135.Tree);

            			    }
            			    break;
            			case 9 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:253:119: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzbody21298);
            			    	otherbegin136 = otherbegin();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;
            			case 10 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:253:133: otherend
            			    {
            			    	PushFollow(FOLLOW_otherend_in_tikzbody21303);
            			    	otherend137 = otherend();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;
            			case 11 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:253:145: dontcare_body2
            			    {
            			    	PushFollow(FOLLOW_dontcare_body2_in_tikzbody21308);
            			    	dontcare_body2138 = dontcare_body2();
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:256:1: dontcare_body_nobr2 : (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' | '{' | '}' ) ) ;
    public simpletikzParser.dontcare_body_nobr2_return dontcare_body_nobr2() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body_nobr2_return retval = new simpletikzParser.dontcare_body_nobr2_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set139 = null;

        object set139_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:257:2: ( (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' | '{' | '}' ) ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:257:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' | '{' | '}' ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:257:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' | '{' | '}' ) )
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:257:5: ~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' | '{' | '}' )
            	{
            		set139 = (IToken)input.LT(1);
            		if ( (input.LA(1) >= IM_PATH && input.LA(1) <= SOMETHING1) || input.LA(1) == 42 || (input.LA(1) >= 45 && input.LA(1) <= 54) || (input.LA(1) >= 56 && input.LA(1) <= 63) || (input.LA(1) >= 78 && input.LA(1) <= 95) ) 
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:259:1: dontcare_body2 : (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '{' | '}' ) ) ;
    public simpletikzParser.dontcare_body2_return dontcare_body2() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body2_return retval = new simpletikzParser.dontcare_body2_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set140 = null;

        object set140_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:260:2: ( (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '{' | '}' ) ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:260:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '{' | '}' ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:260:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '{' | '}' ) )
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:260:5: ~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '{' | '}' )
            	{
            		set140 = (IToken)input.LT(1);
            		if ( (input.LA(1) >= IM_PATH && input.LA(1) <= SOMETHING1) || input.LA(1) == 42 || (input.LA(1) >= 45 && input.LA(1) <= 63) || (input.LA(1) >= 78 && input.LA(1) <= 95) ) 
            		{
            		    input.Consume();
            		    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set140));
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:262:1: dontcare_body_nobr : (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) ) ;
    public simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body_nobr_return retval = new simpletikzParser.dontcare_body_nobr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set141 = null;

        object set141_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:263:2: ( (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:263:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:263:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) )
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:263:5: ~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' )
            	{
            		set141 = (IToken)input.LT(1);
            		if ( (input.LA(1) >= IM_PATH && input.LA(1) <= SOMETHING1) || (input.LA(1) >= 42 && input.LA(1) <= 54) || (input.LA(1) >= 56 && input.LA(1) <= 63) || (input.LA(1) >= 78 && input.LA(1) <= 95) ) 
            		{
            		    input.Consume();
            		    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set141));
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:265:1: dontcare_body : (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) ) ;
    public simpletikzParser.dontcare_body_return dontcare_body() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body_return retval = new simpletikzParser.dontcare_body_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set142 = null;

        object set142_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:266:2: ( (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:266:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:266:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) )
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:266:5: ~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' )
            	{
            		set142 = (IToken)input.LT(1);
            		if ( (input.LA(1) >= IM_PATH && input.LA(1) <= SOMETHING1) || (input.LA(1) >= 42 && input.LA(1) <= 63) || (input.LA(1) >= 78 && input.LA(1) <= 95) ) 
            		{
            		    input.Consume();
            		    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set142));
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:268:1: otherend : '\\\\end' '{' idd2 '}' ;
    public simpletikzParser.otherend_return otherend() // throws RecognitionException [1]
    {   
        simpletikzParser.otherend_return retval = new simpletikzParser.otherend_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal143 = null;
        IToken char_literal144 = null;
        IToken char_literal146 = null;
        simpletikzParser.idd2_return idd2145 = default(simpletikzParser.idd2_return);


        object string_literal143_tree=null;
        object char_literal144_tree=null;
        object char_literal146_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:269:2: ( '\\\\end' '{' idd2 '}' )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:269:4: '\\\\end' '{' idd2 '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal143=(IToken)Match(input,64,FOLLOW_64_in_otherend1679); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal143_tree = (object)adaptor.Create(string_literal143);
            		adaptor.AddChild(root_0, string_literal143_tree);
            	}
            	char_literal144=(IToken)Match(input,43,FOLLOW_43_in_otherend1681); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal144_tree = (object)adaptor.Create(char_literal144);
            		adaptor.AddChild(root_0, char_literal144_tree);
            	}
            	PushFollow(FOLLOW_idd2_in_otherend1683);
            	idd2145 = idd2();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idd2145.Tree);
            	char_literal146=(IToken)Match(input,44,FOLLOW_44_in_otherend1685); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal146_tree = (object)adaptor.Create(char_literal146);
            		adaptor.AddChild(root_0, char_literal146_tree);
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:283:1: tikzscope : tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end ) ;
    public simpletikzParser.tikzscope_return tikzscope() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_return retval = new simpletikzParser.tikzscope_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_start_return tikzscope_start147 = default(simpletikzParser.tikzscope_start_return);

        simpletikzParser.tikz_options_return tikz_options148 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody_return tikzbody149 = default(simpletikzParser.tikzbody_return);

        simpletikzParser.tikzscope_end_return tikzscope_end150 = default(simpletikzParser.tikzscope_end_return);


        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikzscope_start = new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_start");
        RewriteRuleSubtreeStream stream_tikzscope_end = new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_end");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:284:2: ( tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:284:4: tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end
            {
            	PushFollow(FOLLOW_tikzscope_start_in_tikzscope1712);
            	tikzscope_start147 = tikzscope_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikzscope_start.Add(tikzscope_start147.Tree);
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:284:20: ( tikz_options )?
            	int alt37 = 2;
            	int LA37_0 = input.LA(1);

            	if ( (LA37_0 == 55) )
            	{
            	    alt37 = 1;
            	}
            	switch (alt37) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:284:20: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_tikzscope1714);
            	        	tikz_options148 = tikz_options();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_tikz_options.Add(tikz_options148.Tree);

            	        }
            	        break;

            	}

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:284:34: ( tikzbody )?
            	int alt38 = 2;
            	int LA38_0 = input.LA(1);

            	if ( ((LA38_0 >= IM_PATH && LA38_0 <= 54) || (LA38_0 >= 56 && LA38_0 <= 63) || (LA38_0 >= 65 && LA38_0 <= 95)) )
            	{
            	    alt38 = 1;
            	}
            	else if ( (LA38_0 == 64) )
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
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:284:34: tikzbody
            	        {
            	        	PushFollow(FOLLOW_tikzbody_in_tikzscope1717);
            	        	tikzbody149 = tikzbody();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_tikzbody.Add(tikzbody149.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzscope_end_in_tikzscope1720);
            	tikzscope_end150 = tikzscope_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikzscope_end.Add(tikzscope_end150.Tree);


            	// AST REWRITE
            	// elements:          tikz_options, tikzbody, tikzscope_start, tikzscope_end
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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:284:62: ^( IM_SCOPE tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_SCOPE, "IM_SCOPE"), root_1);

            	    adaptor.AddChild(root_1, stream_tikzscope_start.NextTree());
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:284:89: ( tikz_options )?
            	    if ( stream_tikz_options.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikz_options.NextTree());

            	    }
            	    stream_tikz_options.Reset();
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:284:103: ( tikzbody )?
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:310:1: tikzpath : path_start ( tikzpath_element )* semicolon_end -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikzpath_return tikzpath() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_return retval = new simpletikzParser.tikzpath_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.path_start_return path_start151 = default(simpletikzParser.path_start_return);

        simpletikzParser.tikzpath_element_return tikzpath_element152 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end153 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        RewriteRuleSubtreeStream stream_path_start = new RewriteRuleSubtreeStream(adaptor,"rule path_start");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:311:2: ( path_start ( tikzpath_element )* semicolon_end -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:311:4: path_start ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_path_start_in_tikzpath1776);
            	path_start151 = path_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_path_start.Add(path_start151.Tree);
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:311:15: ( tikzpath_element )*
            	do 
            	{
            	    int alt39 = 2;
            	    int LA39_0 = input.LA(1);

            	    if ( ((LA39_0 >= ID && LA39_0 <= COMMAND) || LA39_0 == 43 || LA39_0 == 45 || LA39_0 == 53 || LA39_0 == 55 || LA39_0 == 59 || LA39_0 == 78 || (LA39_0 >= 80 && LA39_0 <= 81) || (LA39_0 >= 83 && LA39_0 <= 92)) )
            	    {
            	        alt39 = 1;
            	    }


            	    switch (alt39) 
            		{
            			case 1 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:311:15: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath1778);
            			    	tikzpath_element152 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikzpath_element.Add(tikzpath_element152.Tree);

            			    }
            			    break;

            			default:
            			    goto loop39;
            	    }
            	} while (true);

            	loop39:
            		;	// Stops C# compiler whining that label 'loop39' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikzpath1781);
            	semicolon_end153 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_semicolon_end.Add(semicolon_end153.Tree);


            	// AST REWRITE
            	// elements:          path_start, tikzpath_element, semicolon_end
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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:311:50: ^( IM_PATH path_start ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_path_start.NextTree());
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:311:71: ( tikzpath_element )*
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:316:1: let_cmd_parts : ( 'let' | 'in' | '=' | COMMAND );
    public simpletikzParser.let_cmd_parts_return let_cmd_parts() // throws RecognitionException [1]
    {   
        simpletikzParser.let_cmd_parts_return retval = new simpletikzParser.let_cmd_parts_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set154 = null;

        object set154_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:317:2: ( 'let' | 'in' | '=' | COMMAND )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set154 = (IToken)input.LT(1);
            	if ( input.LA(1) == COMMAND || input.LA(1) == 45 || input.LA(1) == 59 || input.LA(1) == 78 ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set154));
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:321:1: tikzpath_element : tikzpath_element_single ( ',' )? ;
    public simpletikzParser.tikzpath_element_return tikzpath_element() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_element_return retval = new simpletikzParser.tikzpath_element_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal156 = null;
        simpletikzParser.tikzpath_element_single_return tikzpath_element_single155 = default(simpletikzParser.tikzpath_element_single_return);


        object char_literal156_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:322:2: ( tikzpath_element_single ( ',' )? )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:322:4: tikzpath_element_single ( ',' )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_tikzpath_element_single_in_tikzpath_element1837);
            	tikzpath_element_single155 = tikzpath_element_single();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath_element_single155.Tree);
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:322:31: ( ',' )?
            	int alt40 = 2;
            	int LA40_0 = input.LA(1);

            	if ( (LA40_0 == 47) )
            	{
            	    alt40 = 1;
            	}
            	switch (alt40) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:322:31: ','
            	        {
            	        	char_literal156=(IToken)Match(input,47,FOLLOW_47_in_tikzpath_element1839); if (state.failed) return retval;

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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:325:1: tikzpath_element_single : ( tikz_options | let_cmd_parts -> ^( IM_DONTCARE ( let_cmd_parts )+ ) | arc | ( coord )=> coord | controls | tikznode_int | tikzcoordinate_int | circle | roundbr_start ( tikzpath_element )* roundbr_end -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end ) | '(' ( tikzpath_element )* ')' -> ^( IM_PATH '(' ( tikzpath_element )* ')' ) | edgeop );
    public simpletikzParser.tikzpath_element_single_return tikzpath_element_single() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_element_single_return retval = new simpletikzParser.tikzpath_element_single_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal168 = null;
        IToken char_literal170 = null;
        simpletikzParser.tikz_options_return tikz_options157 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.let_cmd_parts_return let_cmd_parts158 = default(simpletikzParser.let_cmd_parts_return);

        simpletikzParser.arc_return arc159 = default(simpletikzParser.arc_return);

        simpletikzParser.coord_return coord160 = default(simpletikzParser.coord_return);

        simpletikzParser.controls_return controls161 = default(simpletikzParser.controls_return);

        simpletikzParser.tikznode_int_return tikznode_int162 = default(simpletikzParser.tikznode_int_return);

        simpletikzParser.tikzcoordinate_int_return tikzcoordinate_int163 = default(simpletikzParser.tikzcoordinate_int_return);

        simpletikzParser.circle_return circle164 = default(simpletikzParser.circle_return);

        simpletikzParser.roundbr_start_return roundbr_start165 = default(simpletikzParser.roundbr_start_return);

        simpletikzParser.tikzpath_element_return tikzpath_element166 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.roundbr_end_return roundbr_end167 = default(simpletikzParser.roundbr_end_return);

        simpletikzParser.tikzpath_element_return tikzpath_element169 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.edgeop_return edgeop171 = default(simpletikzParser.edgeop_return);


        object char_literal168_tree=null;
        object char_literal170_tree=null;
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_let_cmd_parts = new RewriteRuleSubtreeStream(adaptor,"rule let_cmd_parts");
        RewriteRuleSubtreeStream stream_roundbr_start = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_start");
        RewriteRuleSubtreeStream stream_roundbr_end = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:326:2: ( tikz_options | let_cmd_parts -> ^( IM_DONTCARE ( let_cmd_parts )+ ) | arc | ( coord )=> coord | controls | tikznode_int | tikzcoordinate_int | circle | roundbr_start ( tikzpath_element )* roundbr_end -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end ) | '(' ( tikzpath_element )* ')' -> ^( IM_PATH '(' ( tikzpath_element )* ')' ) | edgeop )
            int alt43 = 11;
            alt43 = dfa43.Predict(input);
            switch (alt43) 
            {
                case 1 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:327:5: tikz_options
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_options_in_tikzpath_element_single1857);
                    	tikz_options157 = tikz_options();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_options157.Tree);

                    }
                    break;
                case 2 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:328:5: let_cmd_parts
                    {
                    	PushFollow(FOLLOW_let_cmd_parts_in_tikzpath_element_single1864);
                    	let_cmd_parts158 = let_cmd_parts();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_let_cmd_parts.Add(let_cmd_parts158.Tree);


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
                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:328:22: ^( IM_DONTCARE ( let_cmd_parts )+ )
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
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:330:5: arc
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arc_in_tikzpath_element_single1882);
                    	arc159 = arc();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arc159.Tree);

                    }
                    break;
                case 4 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:331:5: ( coord )=> coord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_coord_in_tikzpath_element_single1892);
                    	coord160 = coord();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, coord160.Tree);

                    }
                    break;
                case 5 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:332:5: controls
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_controls_in_tikzpath_element_single1898);
                    	controls161 = controls();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, controls161.Tree);

                    }
                    break;
                case 6 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:333:5: tikznode_int
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikznode_int_in_tikzpath_element_single1904);
                    	tikznode_int162 = tikznode_int();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_int162.Tree);

                    }
                    break;
                case 7 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:334:5: tikzcoordinate_int
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikzcoordinate_int_in_tikzpath_element_single1910);
                    	tikzcoordinate_int163 = tikzcoordinate_int();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_int163.Tree);

                    }
                    break;
                case 8 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:335:5: circle
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_circle_in_tikzpath_element_single1916);
                    	circle164 = circle();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;

                    }
                    break;
                case 9 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:336:5: roundbr_start ( tikzpath_element )* roundbr_end
                    {
                    	PushFollow(FOLLOW_roundbr_start_in_tikzpath_element_single1923);
                    	roundbr_start165 = roundbr_start();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_roundbr_start.Add(roundbr_start165.Tree);
                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:336:19: ( tikzpath_element )*
                    	do 
                    	{
                    	    int alt41 = 2;
                    	    int LA41_0 = input.LA(1);

                    	    if ( ((LA41_0 >= ID && LA41_0 <= COMMAND) || LA41_0 == 43 || LA41_0 == 45 || LA41_0 == 53 || LA41_0 == 55 || LA41_0 == 59 || LA41_0 == 78 || (LA41_0 >= 80 && LA41_0 <= 81) || (LA41_0 >= 83 && LA41_0 <= 92)) )
                    	    {
                    	        alt41 = 1;
                    	    }


                    	    switch (alt41) 
                    		{
                    			case 1 :
                    			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:336:19: tikzpath_element
                    			    {
                    			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath_element_single1925);
                    			    	tikzpath_element166 = tikzpath_element();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking==0 ) stream_tikzpath_element.Add(tikzpath_element166.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop41;
                    	    }
                    	} while (true);

                    	loop41:
                    		;	// Stops C# compiler whining that label 'loop41' has no statements

                    	PushFollow(FOLLOW_roundbr_end_in_tikzpath_element_single1928);
                    	roundbr_end167 = roundbr_end();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_roundbr_end.Add(roundbr_end167.Tree);


                    	// AST REWRITE
                    	// elements:          roundbr_end, roundbr_start, tikzpath_element
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
                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:336:52: ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

                    	    adaptor.AddChild(root_1, stream_roundbr_start.NextTree());
                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:336:76: ( tikzpath_element )*
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
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:337:6: '(' ( tikzpath_element )* ')'
                    {
                    	char_literal168=(IToken)Match(input,53,FOLLOW_53_in_tikzpath_element_single1948); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_53.Add(char_literal168);

                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:337:10: ( tikzpath_element )*
                    	do 
                    	{
                    	    int alt42 = 2;
                    	    int LA42_0 = input.LA(1);

                    	    if ( ((LA42_0 >= ID && LA42_0 <= COMMAND) || LA42_0 == 43 || LA42_0 == 45 || LA42_0 == 53 || LA42_0 == 55 || LA42_0 == 59 || LA42_0 == 78 || (LA42_0 >= 80 && LA42_0 <= 81) || (LA42_0 >= 83 && LA42_0 <= 92)) )
                    	    {
                    	        alt42 = 1;
                    	    }


                    	    switch (alt42) 
                    		{
                    			case 1 :
                    			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:337:10: tikzpath_element
                    			    {
                    			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath_element_single1950);
                    			    	tikzpath_element169 = tikzpath_element();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking==0 ) stream_tikzpath_element.Add(tikzpath_element169.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop42;
                    	    }
                    	} while (true);

                    	loop42:
                    		;	// Stops C# compiler whining that label 'loop42' has no statements

                    	char_literal170=(IToken)Match(input,54,FOLLOW_54_in_tikzpath_element_single1953); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_54.Add(char_literal170);



                    	// AST REWRITE
                    	// elements:          54, tikzpath_element, 53
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
                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:337:35: ^( IM_PATH '(' ( tikzpath_element )* ')' )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

                    	    adaptor.AddChild(root_1, stream_53.NextNode());
                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:337:49: ( tikzpath_element )*
                    	    while ( stream_tikzpath_element.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_tikzpath_element.NextTree());

                    	    }
                    	    stream_tikzpath_element.Reset();
                    	    adaptor.AddChild(root_1, stream_54.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 11 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:338:5: edgeop
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_edgeop_in_tikzpath_element_single1972);
                    	edgeop171 = edgeop();
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:341:1: controls : controls_start coord ( 'and' coord )? controls_end -> ^( IM_CONTROLS controls_start ( coord )+ controls_end ) ;
    public simpletikzParser.controls_return controls() // throws RecognitionException [1]
    {   
        simpletikzParser.controls_return retval = new simpletikzParser.controls_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal174 = null;
        simpletikzParser.controls_start_return controls_start172 = default(simpletikzParser.controls_start_return);

        simpletikzParser.coord_return coord173 = default(simpletikzParser.coord_return);

        simpletikzParser.coord_return coord175 = default(simpletikzParser.coord_return);

        simpletikzParser.controls_end_return controls_end176 = default(simpletikzParser.controls_end_return);


        object string_literal174_tree=null;
        RewriteRuleTokenStream stream_79 = new RewriteRuleTokenStream(adaptor,"token 79");
        RewriteRuleSubtreeStream stream_controls_end = new RewriteRuleSubtreeStream(adaptor,"rule controls_end");
        RewriteRuleSubtreeStream stream_coord = new RewriteRuleSubtreeStream(adaptor,"rule coord");
        RewriteRuleSubtreeStream stream_controls_start = new RewriteRuleSubtreeStream(adaptor,"rule controls_start");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:342:2: ( controls_start coord ( 'and' coord )? controls_end -> ^( IM_CONTROLS controls_start ( coord )+ controls_end ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:342:4: controls_start coord ( 'and' coord )? controls_end
            {
            	PushFollow(FOLLOW_controls_start_in_controls1987);
            	controls_start172 = controls_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_controls_start.Add(controls_start172.Tree);
            	PushFollow(FOLLOW_coord_in_controls1989);
            	coord173 = coord();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_coord.Add(coord173.Tree);
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:342:25: ( 'and' coord )?
            	int alt44 = 2;
            	int LA44_0 = input.LA(1);

            	if ( (LA44_0 == 79) )
            	{
            	    alt44 = 1;
            	}
            	switch (alt44) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:342:26: 'and' coord
            	        {
            	        	string_literal174=(IToken)Match(input,79,FOLLOW_79_in_controls1992); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_79.Add(string_literal174);

            	        	PushFollow(FOLLOW_coord_in_controls1994);
            	        	coord175 = coord();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_coord.Add(coord175.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_controls_end_in_controls1998);
            	controls_end176 = controls_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_controls_end.Add(controls_end176.Tree);


            	// AST REWRITE
            	// elements:          controls_start, coord, controls_end
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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:342:56: ^( IM_CONTROLS controls_start ( coord )+ controls_end )
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:345:1: tikznode_ext : node_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikznode_ext_return tikznode_ext() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_ext_return retval = new simpletikzParser.tikznode_ext_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.node_start_return node_start177 = default(simpletikzParser.node_start_return);

        simpletikzParser.tikznode_core_return tikznode_core178 = default(simpletikzParser.tikznode_core_return);

        simpletikzParser.tikzpath_element_return tikzpath_element179 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end180 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_tikznode_core = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_core");
        RewriteRuleSubtreeStream stream_node_start = new RewriteRuleSubtreeStream(adaptor,"rule node_start");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:346:2: ( node_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:346:4: node_start tikznode_core ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_node_start_in_tikznode_ext2024);
            	node_start177 = node_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_node_start.Add(node_start177.Tree);
            	PushFollow(FOLLOW_tikznode_core_in_tikznode_ext2026);
            	tikznode_core178 = tikznode_core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_core.Add(tikznode_core178.Tree);
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:346:29: ( tikzpath_element )*
            	do 
            	{
            	    int alt45 = 2;
            	    int LA45_0 = input.LA(1);

            	    if ( ((LA45_0 >= ID && LA45_0 <= COMMAND) || LA45_0 == 43 || LA45_0 == 45 || LA45_0 == 53 || LA45_0 == 55 || LA45_0 == 59 || LA45_0 == 78 || (LA45_0 >= 80 && LA45_0 <= 81) || (LA45_0 >= 83 && LA45_0 <= 92)) )
            	    {
            	        alt45 = 1;
            	    }


            	    switch (alt45) 
            		{
            			case 1 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:346:29: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikznode_ext2028);
            			    	tikzpath_element179 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikzpath_element.Add(tikzpath_element179.Tree);

            			    }
            			    break;

            			default:
            			    goto loop45;
            	    }
            	} while (true);

            	loop45:
            		;	// Stops C# compiler whining that label 'loop45' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikznode_ext2031);
            	semicolon_end180 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_semicolon_end.Add(semicolon_end180.Tree);


            	// AST REWRITE
            	// elements:          node_start, tikzpath_element, semicolon_end, tikznode_core
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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:346:64: ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_node_start.NextTree());
            	    adaptor.AddChild(root_1, stream_tikznode_core.NextTree());
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:346:99: ( tikzpath_element )*
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:348:1: tikzdef_ext : def_start ( tikzpath_element )* semicolon_end -> ^( IM_PATH def_start ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikzdef_ext_return tikzdef_ext() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzdef_ext_return retval = new simpletikzParser.tikzdef_ext_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.def_start_return def_start181 = default(simpletikzParser.def_start_return);

        simpletikzParser.tikzpath_element_return tikzpath_element182 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end183 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_def_start = new RewriteRuleSubtreeStream(adaptor,"rule def_start");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:349:2: ( def_start ( tikzpath_element )* semicolon_end -> ^( IM_PATH def_start ( tikzpath_element )* semicolon_end ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:349:4: def_start ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_def_start_in_tikzdef_ext2056);
            	def_start181 = def_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_def_start.Add(def_start181.Tree);
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:349:14: ( tikzpath_element )*
            	do 
            	{
            	    int alt46 = 2;
            	    int LA46_0 = input.LA(1);

            	    if ( ((LA46_0 >= ID && LA46_0 <= COMMAND) || LA46_0 == 43 || LA46_0 == 45 || LA46_0 == 53 || LA46_0 == 55 || LA46_0 == 59 || LA46_0 == 78 || (LA46_0 >= 80 && LA46_0 <= 81) || (LA46_0 >= 83 && LA46_0 <= 92)) )
            	    {
            	        alt46 = 1;
            	    }


            	    switch (alt46) 
            		{
            			case 1 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:349:14: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikzdef_ext2058);
            			    	tikzpath_element182 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikzpath_element.Add(tikzpath_element182.Tree);

            			    }
            			    break;

            			default:
            			    goto loop46;
            	    }
            	} while (true);

            	loop46:
            		;	// Stops C# compiler whining that label 'loop46' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikzdef_ext2061);
            	semicolon_end183 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_semicolon_end.Add(semicolon_end183.Tree);


            	// AST REWRITE
            	// elements:          def_start, semicolon_end, tikzpath_element
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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:349:49: ^( IM_PATH def_start ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_def_start.NextTree());
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:349:69: ( tikzpath_element )*
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:352:1: tikzmatrix_ext : matrix_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH matrix_start tikznode_core ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikzmatrix_ext_return tikzmatrix_ext() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzmatrix_ext_return retval = new simpletikzParser.tikzmatrix_ext_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.matrix_start_return matrix_start184 = default(simpletikzParser.matrix_start_return);

        simpletikzParser.tikznode_core_return tikznode_core185 = default(simpletikzParser.tikznode_core_return);

        simpletikzParser.tikzpath_element_return tikzpath_element186 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end187 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_tikznode_core = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_core");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        RewriteRuleSubtreeStream stream_matrix_start = new RewriteRuleSubtreeStream(adaptor,"rule matrix_start");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:353:2: ( matrix_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH matrix_start tikznode_core ( tikzpath_element )* semicolon_end ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:353:4: matrix_start tikznode_core ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_matrix_start_in_tikzmatrix_ext2086);
            	matrix_start184 = matrix_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_matrix_start.Add(matrix_start184.Tree);
            	PushFollow(FOLLOW_tikznode_core_in_tikzmatrix_ext2088);
            	tikznode_core185 = tikznode_core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_core.Add(tikznode_core185.Tree);
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:353:31: ( tikzpath_element )*
            	do 
            	{
            	    int alt47 = 2;
            	    int LA47_0 = input.LA(1);

            	    if ( ((LA47_0 >= ID && LA47_0 <= COMMAND) || LA47_0 == 43 || LA47_0 == 45 || LA47_0 == 53 || LA47_0 == 55 || LA47_0 == 59 || LA47_0 == 78 || (LA47_0 >= 80 && LA47_0 <= 81) || (LA47_0 >= 83 && LA47_0 <= 92)) )
            	    {
            	        alt47 = 1;
            	    }


            	    switch (alt47) 
            		{
            			case 1 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:353:31: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikzmatrix_ext2090);
            			    	tikzpath_element186 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikzpath_element.Add(tikzpath_element186.Tree);

            			    }
            			    break;

            			default:
            			    goto loop47;
            	    }
            	} while (true);

            	loop47:
            		;	// Stops C# compiler whining that label 'loop47' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikzmatrix_ext2093);
            	semicolon_end187 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_semicolon_end.Add(semicolon_end187.Tree);


            	// AST REWRITE
            	// elements:          matrix_start, semicolon_end, tikzpath_element, tikznode_core
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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:353:66: ^( IM_PATH matrix_start tikznode_core ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_matrix_start.NextTree());
            	    adaptor.AddChild(root_1, stream_tikznode_core.NextTree());
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:353:103: ( tikzpath_element )*
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:357:1: tikzcoordinate_ext : coordinate_start ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ( tikzpath_element )* semicolon_end -> ^( IM_PATH coordinate_start ( tikzcoordinate_core3 )? ( tikzcoordinate_core2 )? ( tikzcoordinate_core1 )? ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_ext_return retval = new simpletikzParser.tikzcoordinate_ext_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.coordinate_start_return coordinate_start188 = default(simpletikzParser.coordinate_start_return);

        simpletikzParser.tikzcoordinate_core3_return tikzcoordinate_core3189 = default(simpletikzParser.tikzcoordinate_core3_return);

        simpletikzParser.tikzcoordinate_core2_return tikzcoordinate_core2190 = default(simpletikzParser.tikzcoordinate_core2_return);

        simpletikzParser.tikzcoordinate_core1_return tikzcoordinate_core1191 = default(simpletikzParser.tikzcoordinate_core1_return);

        simpletikzParser.tikzpath_element_return tikzpath_element192 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end193 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzcoordinate_core3 = new RewriteRuleSubtreeStream(adaptor,"rule tikzcoordinate_core3");
        RewriteRuleSubtreeStream stream_tikzcoordinate_core2 = new RewriteRuleSubtreeStream(adaptor,"rule tikzcoordinate_core2");
        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_coordinate_start = new RewriteRuleSubtreeStream(adaptor,"rule coordinate_start");
        RewriteRuleSubtreeStream stream_tikzcoordinate_core1 = new RewriteRuleSubtreeStream(adaptor,"rule tikzcoordinate_core1");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:358:2: ( coordinate_start ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ( tikzpath_element )* semicolon_end -> ^( IM_PATH coordinate_start ( tikzcoordinate_core3 )? ( tikzcoordinate_core2 )? ( tikzcoordinate_core1 )? ( tikzpath_element )* semicolon_end ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:358:4: coordinate_start ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_coordinate_start_in_tikzcoordinate_ext2121);
            	coordinate_start188 = coordinate_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_coordinate_start.Add(coordinate_start188.Tree);
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:359:5: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?
            	int alt48 = 4;
            	alt48 = dfa48.Predict(input);
            	switch (alt48) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:359:7: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        {
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:359:7: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:359:8: ( tikzcoordinate_core3 )=> tikzcoordinate_core3
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_ext2136);
            	        		tikzcoordinate_core3189 = tikzcoordinate_core3();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking==0 ) stream_tikzcoordinate_core3.Add(tikzcoordinate_core3189.Tree);

            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:360:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        {
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:360:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:360:12: ( tikzcoordinate_core2 )=> tikzcoordinate_core2
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_ext2155);
            	        		tikzcoordinate_core2190 = tikzcoordinate_core2();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking==0 ) stream_tikzcoordinate_core2.Add(tikzcoordinate_core2190.Tree);

            	        	}


            	        }
            	        break;
            	    case 3 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:361:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        {
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:361:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:361:12: ( tikzcoordinate_core1 )=> tikzcoordinate_core1
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_ext2175);
            	        		tikzcoordinate_core1191 = tikzcoordinate_core1();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking==0 ) stream_tikzcoordinate_core1.Add(tikzcoordinate_core1191.Tree);

            	        	}


            	        }
            	        break;

            	}

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:362:6: ( tikzpath_element )*
            	do 
            	{
            	    int alt49 = 2;
            	    int LA49_0 = input.LA(1);

            	    if ( ((LA49_0 >= ID && LA49_0 <= COMMAND) || LA49_0 == 43 || LA49_0 == 45 || LA49_0 == 53 || LA49_0 == 55 || LA49_0 == 59 || LA49_0 == 78 || (LA49_0 >= 80 && LA49_0 <= 81) || (LA49_0 >= 83 && LA49_0 <= 92)) )
            	    {
            	        alt49 = 1;
            	    }


            	    switch (alt49) 
            		{
            			case 1 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:362:6: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikzcoordinate_ext2186);
            			    	tikzpath_element192 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikzpath_element.Add(tikzpath_element192.Tree);

            			    }
            			    break;

            			default:
            			    goto loop49;
            	    }
            	} while (true);

            	loop49:
            		;	// Stops C# compiler whining that label 'loop49' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikzcoordinate_ext2189);
            	semicolon_end193 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_semicolon_end.Add(semicolon_end193.Tree);


            	// AST REWRITE
            	// elements:          semicolon_end, coordinate_start, tikzcoordinate_core2, tikzcoordinate_core3, tikzcoordinate_core1, tikzpath_element
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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:363:9: ^( IM_PATH coordinate_start ( tikzcoordinate_core3 )? ( tikzcoordinate_core2 )? ( tikzcoordinate_core1 )? ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_coordinate_start.NextTree());
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:364:6: ( tikzcoordinate_core3 )?
            	    if ( stream_tikzcoordinate_core3.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzcoordinate_core3.NextTree());

            	    }
            	    stream_tikzcoordinate_core3.Reset();
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:365:6: ( tikzcoordinate_core2 )?
            	    if ( stream_tikzcoordinate_core2.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzcoordinate_core2.NextTree());

            	    }
            	    stream_tikzcoordinate_core2.Reset();
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:366:6: ( tikzcoordinate_core1 )?
            	    if ( stream_tikzcoordinate_core1.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzcoordinate_core1.NextTree());

            	    }
            	    stream_tikzcoordinate_core1.Reset();
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:367:6: ( tikzpath_element )*
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:369:1: tikzcoordinate_int : 'coordinate' ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ;
    public simpletikzParser.tikzcoordinate_int_return tikzcoordinate_int() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_int_return retval = new simpletikzParser.tikzcoordinate_int_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal194 = null;
        simpletikzParser.tikzcoordinate_core3_return tikzcoordinate_core3195 = default(simpletikzParser.tikzcoordinate_core3_return);

        simpletikzParser.tikzcoordinate_core2_return tikzcoordinate_core2196 = default(simpletikzParser.tikzcoordinate_core2_return);

        simpletikzParser.tikzcoordinate_core1_return tikzcoordinate_core1197 = default(simpletikzParser.tikzcoordinate_core1_return);


        object string_literal194_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:370:2: ( 'coordinate' ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:370:4: 'coordinate' ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal194=(IToken)Match(input,80,FOLLOW_80_in_tikzcoordinate_int2249); if (state.failed) return retval;
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:370:18: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?
            	int alt50 = 4;
            	alt50 = dfa50.Predict(input);
            	switch (alt50) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:370:20: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        {
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:370:20: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:370:21: ( tikzcoordinate_core3 )=> tikzcoordinate_core3
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_int2260);
            	        		tikzcoordinate_core3195 = tikzcoordinate_core3();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_core3195.Tree);

            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:371:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        {
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:371:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:371:12: ( tikzcoordinate_core2 )=> tikzcoordinate_core2
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_int2279);
            	        		tikzcoordinate_core2196 = tikzcoordinate_core2();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_core2196.Tree);

            	        	}


            	        }
            	        break;
            	    case 3 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:372:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        {
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:372:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:372:12: ( tikzcoordinate_core1 )=> tikzcoordinate_core1
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_int2299);
            	        		tikzcoordinate_core1197 = tikzcoordinate_core1();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_core1197.Tree);

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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:374:1: tikznode_int : 'node' tikznode_core ;
    public simpletikzParser.tikznode_int_return tikznode_int() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_int_return retval = new simpletikzParser.tikznode_int_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal198 = null;
        simpletikzParser.tikznode_core_return tikznode_core199 = default(simpletikzParser.tikznode_core_return);


        object string_literal198_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:375:2: ( 'node' tikznode_core )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:375:4: 'node' tikznode_core
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal198=(IToken)Match(input,81,FOLLOW_81_in_tikznode_int2315); if (state.failed) return retval;
            	PushFollow(FOLLOW_tikznode_core_in_tikznode_int2318);
            	tikznode_core199 = tikznode_core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_core199.Tree);

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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:377:1: tikznode_core : ( tikznode_decorator )* tikzstring -> ^( IM_NODE ( tikznode_decorator )* tikzstring ) ;
    public simpletikzParser.tikznode_core_return tikznode_core() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_core_return retval = new simpletikzParser.tikznode_core_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator200 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikzstring_return tikzstring201 = default(simpletikzParser.tikzstring_return);


        RewriteRuleSubtreeStream stream_tikzstring = new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:378:2: ( ( tikznode_decorator )* tikzstring -> ^( IM_NODE ( tikznode_decorator )* tikzstring ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:378:4: ( tikznode_decorator )* tikzstring
            {
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:378:4: ( tikznode_decorator )*
            	do 
            	{
            	    int alt51 = 2;
            	    int LA51_0 = input.LA(1);

            	    if ( (LA51_0 == 53 || LA51_0 == 55 || LA51_0 == 82) )
            	    {
            	        alt51 = 1;
            	    }


            	    switch (alt51) 
            		{
            			case 1 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:378:4: tikznode_decorator
            			    {
            			    	PushFollow(FOLLOW_tikznode_decorator_in_tikznode_core2328);
            			    	tikznode_decorator200 = tikznode_decorator();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikznode_decorator.Add(tikznode_decorator200.Tree);

            			    }
            			    break;

            			default:
            			    goto loop51;
            	    }
            	} while (true);

            	loop51:
            		;	// Stops C# compiler whining that label 'loop51' has no statements

            	PushFollow(FOLLOW_tikzstring_in_tikznode_core2331);
            	tikzstring201 = tikzstring();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikzstring.Add(tikzstring201.Tree);


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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:378:39: ^( IM_NODE ( tikznode_decorator )* tikzstring )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NODE, "IM_NODE"), root_1);

            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:378:49: ( tikznode_decorator )*
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:381:1: tikzcoordinate_core3 : tikznode_decorator tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator ) ;
    public simpletikzParser.tikzcoordinate_core3_return tikzcoordinate_core3() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_core3_return retval = new simpletikzParser.tikzcoordinate_core3_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator202 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikznode_decorator_return tikznode_decorator203 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikznode_decorator_return tikznode_decorator204 = default(simpletikzParser.tikznode_decorator_return);


        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:382:2: ( tikznode_decorator tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:382:6: tikznode_decorator tikznode_decorator tikznode_decorator
            {
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core32356);
            	tikznode_decorator202 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_decorator.Add(tikznode_decorator202.Tree);
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core32358);
            	tikznode_decorator203 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_decorator.Add(tikznode_decorator203.Tree);
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core32360);
            	tikznode_decorator204 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_decorator.Add(tikznode_decorator204.Tree);


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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:382:67: ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator )
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:386:1: tikzcoordinate_core2 : tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator ) ;
    public simpletikzParser.tikzcoordinate_core2_return tikzcoordinate_core2() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_core2_return retval = new simpletikzParser.tikzcoordinate_core2_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator205 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikznode_decorator_return tikznode_decorator206 = default(simpletikzParser.tikznode_decorator_return);


        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:387:2: ( tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:388:4: tikznode_decorator tikznode_decorator
            {
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core22394);
            	tikznode_decorator205 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_decorator.Add(tikznode_decorator205.Tree);
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core22396);
            	tikznode_decorator206 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_decorator.Add(tikznode_decorator206.Tree);


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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:388:50: ^( IM_NODE tikznode_decorator tikznode_decorator )
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:391:1: tikzcoordinate_core1 : tikznode_decorator -> ^( IM_NODE tikznode_decorator ) ;
    public simpletikzParser.tikzcoordinate_core1_return tikzcoordinate_core1() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_core1_return retval = new simpletikzParser.tikzcoordinate_core1_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator207 = default(simpletikzParser.tikznode_decorator_return);


        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:392:2: ( tikznode_decorator -> ^( IM_NODE tikznode_decorator ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:393:4: tikznode_decorator
            {
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core12429);
            	tikznode_decorator207 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_decorator.Add(tikznode_decorator207.Tree);


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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:393:34: ^( IM_NODE tikznode_decorator )
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:400:1: tikznode_decorator : ( nodename | 'at' COMMAND | 'at' coord | tikz_options_dontcare );
    public simpletikzParser.tikznode_decorator_return tikznode_decorator() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_decorator_return retval = new simpletikzParser.tikznode_decorator_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal209 = null;
        IToken COMMAND210 = null;
        IToken string_literal211 = null;
        simpletikzParser.nodename_return nodename208 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_return coord212 = default(simpletikzParser.coord_return);

        simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare213 = default(simpletikzParser.tikz_options_dontcare_return);


        object string_literal209_tree=null;
        object COMMAND210_tree=null;
        object string_literal211_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:401:2: ( nodename | 'at' COMMAND | 'at' coord | tikz_options_dontcare )
            int alt52 = 4;
            switch ( input.LA(1) ) 
            {
            case 53:
            	{
                alt52 = 1;
                }
                break;
            case 82:
            	{
                int LA52_2 = input.LA(2);

                if ( (LA52_2 == COMMAND) )
                {
                    alt52 = 2;
                }
                else if ( (LA52_2 == 53 || (LA52_2 >= 90 && LA52_2 <= 91)) )
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
            case 55:
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
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:401:6: nodename
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_nodename_in_tikznode_decorator2466);
                    	nodename208 = nodename();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, nodename208.Tree);

                    }
                    break;
                case 2 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:402:5: 'at' COMMAND
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal209=(IToken)Match(input,82,FOLLOW_82_in_tikznode_decorator2473); if (state.failed) return retval;
                    	COMMAND210=(IToken)Match(input,COMMAND,FOLLOW_COMMAND_in_tikznode_decorator2476); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{COMMAND210_tree = (object)adaptor.Create(COMMAND210);
                    		adaptor.AddChild(root_0, COMMAND210_tree);
                    	}

                    }
                    break;
                case 3 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:403:5: 'at' coord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal211=(IToken)Match(input,82,FOLLOW_82_in_tikznode_decorator2482); if (state.failed) return retval;
                    	PushFollow(FOLLOW_coord_in_tikznode_decorator2485);
                    	coord212 = coord();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, coord212.Tree);

                    }
                    break;
                case 4 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:404:5: tikz_options_dontcare
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_options_dontcare_in_tikznode_decorator2491);
                    	tikz_options_dontcare213 = tikz_options_dontcare();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_options_dontcare213.Tree);

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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:406:1: tikz_options_dontcare : '[' ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* ']' -> ^( IM_OPTIONS ) ;
    public simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_options_dontcare_return retval = new simpletikzParser.tikz_options_dontcare_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal214 = null;
        IToken char_literal218 = null;
        simpletikzParser.no_rlbracket_return no_rlbracket215 = default(simpletikzParser.no_rlbracket_return);

        simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare216 = default(simpletikzParser.tikz_options_dontcare_return);

        simpletikzParser.no_rlbracket_return no_rlbracket217 = default(simpletikzParser.no_rlbracket_return);


        object char_literal214_tree=null;
        object char_literal218_tree=null;
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleSubtreeStream stream_tikz_options_dontcare = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options_dontcare");
        RewriteRuleSubtreeStream stream_no_rlbracket = new RewriteRuleSubtreeStream(adaptor,"rule no_rlbracket");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:407:2: ( '[' ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* ']' -> ^( IM_OPTIONS ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:407:4: '[' ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* ']'
            {
            	char_literal214=(IToken)Match(input,55,FOLLOW_55_in_tikz_options_dontcare2501); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_55.Add(char_literal214);

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:407:8: ( no_rlbracket )*
            	do 
            	{
            	    int alt53 = 2;
            	    int LA53_0 = input.LA(1);

            	    if ( ((LA53_0 >= IM_PATH && LA53_0 <= 54) || (LA53_0 >= 57 && LA53_0 <= 95)) )
            	    {
            	        alt53 = 1;
            	    }


            	    switch (alt53) 
            		{
            			case 1 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:407:8: no_rlbracket
            			    {
            			    	PushFollow(FOLLOW_no_rlbracket_in_tikz_options_dontcare2503);
            			    	no_rlbracket215 = no_rlbracket();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_no_rlbracket.Add(no_rlbracket215.Tree);

            			    }
            			    break;

            			default:
            			    goto loop53;
            	    }
            	} while (true);

            	loop53:
            		;	// Stops C# compiler whining that label 'loop53' has no statements

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:407:22: ( tikz_options_dontcare ( no_rlbracket )* )*
            	do 
            	{
            	    int alt55 = 2;
            	    int LA55_0 = input.LA(1);

            	    if ( (LA55_0 == 55) )
            	    {
            	        alt55 = 1;
            	    }


            	    switch (alt55) 
            		{
            			case 1 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:407:23: tikz_options_dontcare ( no_rlbracket )*
            			    {
            			    	PushFollow(FOLLOW_tikz_options_dontcare_in_tikz_options_dontcare2507);
            			    	tikz_options_dontcare216 = tikz_options_dontcare();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikz_options_dontcare.Add(tikz_options_dontcare216.Tree);
            			    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:407:45: ( no_rlbracket )*
            			    	do 
            			    	{
            			    	    int alt54 = 2;
            			    	    int LA54_0 = input.LA(1);

            			    	    if ( ((LA54_0 >= IM_PATH && LA54_0 <= 54) || (LA54_0 >= 57 && LA54_0 <= 95)) )
            			    	    {
            			    	        alt54 = 1;
            			    	    }


            			    	    switch (alt54) 
            			    		{
            			    			case 1 :
            			    			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:407:45: no_rlbracket
            			    			    {
            			    			    	PushFollow(FOLLOW_no_rlbracket_in_tikz_options_dontcare2509);
            			    			    	no_rlbracket217 = no_rlbracket();
            			    			    	state.followingStackPointer--;
            			    			    	if (state.failed) return retval;
            			    			    	if ( state.backtracking==0 ) stream_no_rlbracket.Add(no_rlbracket217.Tree);

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

            	char_literal218=(IToken)Match(input,56,FOLLOW_56_in_tikz_options_dontcare2514); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_56.Add(char_literal218);



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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:407:68: ^( IM_OPTIONS )
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:409:1: no_rlbracket : ~ ( '[' | ']' ) ;
    public simpletikzParser.no_rlbracket_return no_rlbracket() // throws RecognitionException [1]
    {   
        simpletikzParser.no_rlbracket_return retval = new simpletikzParser.no_rlbracket_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set219 = null;

        object set219_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:410:2: (~ ( '[' | ']' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:410:4: ~ ( '[' | ']' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set219 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= 54) || (input.LA(1) >= 57 && input.LA(1) <= 95) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set219));
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:412:1: nodename : '(' idd ')' -> ^( IM_NODENAME idd ) ;
    public simpletikzParser.nodename_return nodename() // throws RecognitionException [1]
    {   
        simpletikzParser.nodename_return retval = new simpletikzParser.nodename_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal220 = null;
        IToken char_literal222 = null;
        simpletikzParser.idd_return idd221 = default(simpletikzParser.idd_return);


        object char_literal220_tree=null;
        object char_literal222_tree=null;
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:413:2: ( '(' idd ')' -> ^( IM_NODENAME idd ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:413:4: '(' idd ')'
            {
            	char_literal220=(IToken)Match(input,53,FOLLOW_53_in_nodename2549); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_53.Add(char_literal220);

            	PushFollow(FOLLOW_idd_in_nodename2551);
            	idd221 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_idd.Add(idd221.Tree);
            	char_literal222=(IToken)Match(input,54,FOLLOW_54_in_nodename2553); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_54.Add(char_literal222);



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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:413:20: ^( IM_NODENAME idd )
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:419:1: circle : ( 'circle' | 'ellipse' ) ( ( size )=> size )? ->;
    public simpletikzParser.circle_return circle() // throws RecognitionException [1]
    {   
        simpletikzParser.circle_return retval = new simpletikzParser.circle_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal223 = null;
        IToken string_literal224 = null;
        simpletikzParser.size_return size225 = default(simpletikzParser.size_return);


        object string_literal223_tree=null;
        object string_literal224_tree=null;
        RewriteRuleTokenStream stream_83 = new RewriteRuleTokenStream(adaptor,"token 83");
        RewriteRuleTokenStream stream_84 = new RewriteRuleTokenStream(adaptor,"token 84");
        RewriteRuleSubtreeStream stream_size = new RewriteRuleSubtreeStream(adaptor,"rule size");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:420:2: ( ( 'circle' | 'ellipse' ) ( ( size )=> size )? ->)
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:420:4: ( 'circle' | 'ellipse' ) ( ( size )=> size )?
            {
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:420:4: ( 'circle' | 'ellipse' )
            	int alt56 = 2;
            	int LA56_0 = input.LA(1);

            	if ( (LA56_0 == 83) )
            	{
            	    alt56 = 1;
            	}
            	else if ( (LA56_0 == 84) )
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
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:420:5: 'circle'
            	        {
            	        	string_literal223=(IToken)Match(input,83,FOLLOW_83_in_circle2578); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_83.Add(string_literal223);


            	        }
            	        break;
            	    case 2 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:420:16: 'ellipse'
            	        {
            	        	string_literal224=(IToken)Match(input,84,FOLLOW_84_in_circle2582); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_84.Add(string_literal224);


            	        }
            	        break;

            	}

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:420:27: ( ( size )=> size )?
            	int alt57 = 2;
            	alt57 = dfa57.Predict(input);
            	switch (alt57) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:420:28: ( size )=> size
            	        {
            	        	PushFollow(FOLLOW_size_in_circle2591);
            	        	size225 = size();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_size.Add(size225.Tree);

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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:422:1: arc : ( 'arc' ( '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')' ) -> ^( IM_ARC ( numberunitorvariable )+ ( numberunit )? ) | 'arc' ( '(' coord_part ':' coord_part ':' coord_part ( 'and' numberunit )? ')' ) -> ^( IM_ARC ( coord_part )+ ( numberunit )? ) | 'arc' tikz_options -> ^( IM_DONTCARE ) );
    public simpletikzParser.arc_return arc() // throws RecognitionException [1]
    {   
        simpletikzParser.arc_return retval = new simpletikzParser.arc_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal226 = null;
        IToken char_literal227 = null;
        IToken char_literal229 = null;
        IToken char_literal231 = null;
        IToken string_literal233 = null;
        IToken char_literal235 = null;
        IToken string_literal236 = null;
        IToken char_literal237 = null;
        IToken char_literal239 = null;
        IToken char_literal241 = null;
        IToken string_literal243 = null;
        IToken char_literal245 = null;
        IToken string_literal246 = null;
        simpletikzParser.numberunitorvariable_return numberunitorvariable228 = default(simpletikzParser.numberunitorvariable_return);

        simpletikzParser.numberunitorvariable_return numberunitorvariable230 = default(simpletikzParser.numberunitorvariable_return);

        simpletikzParser.numberunitorvariable_return numberunitorvariable232 = default(simpletikzParser.numberunitorvariable_return);

        simpletikzParser.numberunit_return numberunit234 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_part_return coord_part238 = default(simpletikzParser.coord_part_return);

        simpletikzParser.coord_part_return coord_part240 = default(simpletikzParser.coord_part_return);

        simpletikzParser.coord_part_return coord_part242 = default(simpletikzParser.coord_part_return);

        simpletikzParser.numberunit_return numberunit244 = default(simpletikzParser.numberunit_return);

        simpletikzParser.tikz_options_return tikz_options247 = default(simpletikzParser.tikz_options_return);


        object string_literal226_tree=null;
        object char_literal227_tree=null;
        object char_literal229_tree=null;
        object char_literal231_tree=null;
        object string_literal233_tree=null;
        object char_literal235_tree=null;
        object string_literal236_tree=null;
        object char_literal237_tree=null;
        object char_literal239_tree=null;
        object char_literal241_tree=null;
        object string_literal243_tree=null;
        object char_literal245_tree=null;
        object string_literal246_tree=null;
        RewriteRuleTokenStream stream_79 = new RewriteRuleTokenStream(adaptor,"token 79");
        RewriteRuleTokenStream stream_48 = new RewriteRuleTokenStream(adaptor,"token 48");
        RewriteRuleTokenStream stream_85 = new RewriteRuleTokenStream(adaptor,"token 85");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleSubtreeStream stream_numberunitorvariable = new RewriteRuleSubtreeStream(adaptor,"rule numberunitorvariable");
        RewriteRuleSubtreeStream stream_coord_part = new RewriteRuleSubtreeStream(adaptor,"rule coord_part");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:423:2: ( 'arc' ( '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')' ) -> ^( IM_ARC ( numberunitorvariable )+ ( numberunit )? ) | 'arc' ( '(' coord_part ':' coord_part ':' coord_part ( 'and' numberunit )? ')' ) -> ^( IM_ARC ( coord_part )+ ( numberunit )? ) | 'arc' tikz_options -> ^( IM_DONTCARE ) )
            int alt60 = 3;
            alt60 = dfa60.Predict(input);
            switch (alt60) 
            {
                case 1 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:423:4: 'arc' ( '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')' )
                    {
                    	string_literal226=(IToken)Match(input,85,FOLLOW_85_in_arc2606); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_85.Add(string_literal226);

                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:423:10: ( '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')' )
                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:423:11: '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')'
                    	{
                    		char_literal227=(IToken)Match(input,53,FOLLOW_53_in_arc2609); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_53.Add(char_literal227);

                    		PushFollow(FOLLOW_numberunitorvariable_in_arc2611);
                    		numberunitorvariable228 = numberunitorvariable();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_numberunitorvariable.Add(numberunitorvariable228.Tree);
                    		char_literal229=(IToken)Match(input,48,FOLLOW_48_in_arc2613); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_48.Add(char_literal229);

                    		PushFollow(FOLLOW_numberunitorvariable_in_arc2615);
                    		numberunitorvariable230 = numberunitorvariable();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_numberunitorvariable.Add(numberunitorvariable230.Tree);
                    		char_literal231=(IToken)Match(input,48,FOLLOW_48_in_arc2617); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_48.Add(char_literal231);

                    		PushFollow(FOLLOW_numberunitorvariable_in_arc2619);
                    		numberunitorvariable232 = numberunitorvariable();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_numberunitorvariable.Add(numberunitorvariable232.Tree);
                    		// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:423:86: ( 'and' numberunit )?
                    		int alt58 = 2;
                    		int LA58_0 = input.LA(1);

                    		if ( (LA58_0 == 79) )
                    		{
                    		    alt58 = 1;
                    		}
                    		switch (alt58) 
                    		{
                    		    case 1 :
                    		        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:423:87: 'and' numberunit
                    		        {
                    		        	string_literal233=(IToken)Match(input,79,FOLLOW_79_in_arc2622); if (state.failed) return retval; 
                    		        	if ( state.backtracking==0 ) stream_79.Add(string_literal233);

                    		        	PushFollow(FOLLOW_numberunit_in_arc2624);
                    		        	numberunit234 = numberunit();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_numberunit.Add(numberunit234.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal235=(IToken)Match(input,54,FOLLOW_54_in_arc2628); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_54.Add(char_literal235);


                    	}



                    	// AST REWRITE
                    	// elements:          numberunit, numberunitorvariable
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
                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:423:114: ^( IM_ARC ( numberunitorvariable )+ ( numberunit )? )
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
                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:423:145: ( numberunit )?
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
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:424:4: 'arc' ( '(' coord_part ':' coord_part ':' coord_part ( 'and' numberunit )? ')' )
                    {
                    	string_literal236=(IToken)Match(input,85,FOLLOW_85_in_arc2646); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_85.Add(string_literal236);

                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:424:10: ( '(' coord_part ':' coord_part ':' coord_part ( 'and' numberunit )? ')' )
                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:424:11: '(' coord_part ':' coord_part ':' coord_part ( 'and' numberunit )? ')'
                    	{
                    		char_literal237=(IToken)Match(input,53,FOLLOW_53_in_arc2649); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_53.Add(char_literal237);

                    		PushFollow(FOLLOW_coord_part_in_arc2651);
                    		coord_part238 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_part.Add(coord_part238.Tree);
                    		char_literal239=(IToken)Match(input,48,FOLLOW_48_in_arc2653); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_48.Add(char_literal239);

                    		PushFollow(FOLLOW_coord_part_in_arc2655);
                    		coord_part240 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_part.Add(coord_part240.Tree);
                    		char_literal241=(IToken)Match(input,48,FOLLOW_48_in_arc2657); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_48.Add(char_literal241);

                    		PushFollow(FOLLOW_coord_part_in_arc2659);
                    		coord_part242 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_part.Add(coord_part242.Tree);
                    		// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:424:56: ( 'and' numberunit )?
                    		int alt59 = 2;
                    		int LA59_0 = input.LA(1);

                    		if ( (LA59_0 == 79) )
                    		{
                    		    alt59 = 1;
                    		}
                    		switch (alt59) 
                    		{
                    		    case 1 :
                    		        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:424:57: 'and' numberunit
                    		        {
                    		        	string_literal243=(IToken)Match(input,79,FOLLOW_79_in_arc2662); if (state.failed) return retval; 
                    		        	if ( state.backtracking==0 ) stream_79.Add(string_literal243);

                    		        	PushFollow(FOLLOW_numberunit_in_arc2664);
                    		        	numberunit244 = numberunit();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_numberunit.Add(numberunit244.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal245=(IToken)Match(input,54,FOLLOW_54_in_arc2668); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_54.Add(char_literal245);


                    	}



                    	// AST REWRITE
                    	// elements:          coord_part, numberunit
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
                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:424:84: ^( IM_ARC ( coord_part )+ ( numberunit )? )
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
                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:424:105: ( numberunit )?
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
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:425:4: 'arc' tikz_options
                    {
                    	string_literal246=(IToken)Match(input,85,FOLLOW_85_in_arc2686); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_85.Add(string_literal246);

                    	PushFollow(FOLLOW_tikz_options_in_arc2688);
                    	tikz_options247 = tikz_options();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_tikz_options.Add(tikz_options247.Tree);


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
                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:425:25: ^( IM_DONTCARE )
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:432:1: size : '(' numberunit ( 'and' numberunit )? ')' -> ^( IM_SIZE ( numberunit )* ) ;
    public simpletikzParser.size_return size() // throws RecognitionException [1]
    {   
        simpletikzParser.size_return retval = new simpletikzParser.size_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal248 = null;
        IToken string_literal250 = null;
        IToken char_literal252 = null;
        simpletikzParser.numberunit_return numberunit249 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit251 = default(simpletikzParser.numberunit_return);


        object char_literal248_tree=null;
        object string_literal250_tree=null;
        object char_literal252_tree=null;
        RewriteRuleTokenStream stream_79 = new RewriteRuleTokenStream(adaptor,"token 79");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:433:2: ( '(' numberunit ( 'and' numberunit )? ')' -> ^( IM_SIZE ( numberunit )* ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:433:6: '(' numberunit ( 'and' numberunit )? ')'
            {
            	char_literal248=(IToken)Match(input,53,FOLLOW_53_in_size2713); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_53.Add(char_literal248);

            	PushFollow(FOLLOW_numberunit_in_size2715);
            	numberunit249 = numberunit();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_numberunit.Add(numberunit249.Tree);
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:433:21: ( 'and' numberunit )?
            	int alt61 = 2;
            	int LA61_0 = input.LA(1);

            	if ( (LA61_0 == 79) )
            	{
            	    alt61 = 1;
            	}
            	switch (alt61) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:433:22: 'and' numberunit
            	        {
            	        	string_literal250=(IToken)Match(input,79,FOLLOW_79_in_size2718); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_79.Add(string_literal250);

            	        	PushFollow(FOLLOW_numberunit_in_size2720);
            	        	numberunit251 = numberunit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_numberunit.Add(numberunit251.Tree);

            	        }
            	        break;

            	}

            	char_literal252=(IToken)Match(input,54,FOLLOW_54_in_size2724); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_54.Add(char_literal252);



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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:433:49: ^( IM_SIZE ( numberunit )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_SIZE, "IM_SIZE"), root_1);

            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:433:59: ( numberunit )*
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:440:1: coord_nodename : '(' ( tikz_options )? idd ')' -> ^( IM_NODENAME idd ( tikz_options )? ) ;
    public simpletikzParser.coord_nodename_return coord_nodename() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_nodename_return retval = new simpletikzParser.coord_nodename_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal253 = null;
        IToken char_literal256 = null;
        simpletikzParser.tikz_options_return tikz_options254 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.idd_return idd255 = default(simpletikzParser.idd_return);


        object char_literal253_tree=null;
        object char_literal256_tree=null;
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:441:2: ( '(' ( tikz_options )? idd ')' -> ^( IM_NODENAME idd ( tikz_options )? ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:441:4: '(' ( tikz_options )? idd ')'
            {
            	char_literal253=(IToken)Match(input,53,FOLLOW_53_in_coord_nodename2752); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_53.Add(char_literal253);

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:441:8: ( tikz_options )?
            	int alt62 = 2;
            	int LA62_0 = input.LA(1);

            	if ( (LA62_0 == 55) )
            	{
            	    alt62 = 1;
            	}
            	switch (alt62) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:441:8: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_coord_nodename2754);
            	        	tikz_options254 = tikz_options();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_tikz_options.Add(tikz_options254.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_idd_in_coord_nodename2757);
            	idd255 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_idd.Add(idd255.Tree);
            	char_literal256=(IToken)Match(input,54,FOLLOW_54_in_coord_nodename2760); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_54.Add(char_literal256);



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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:441:35: ^( IM_NODENAME idd ( tikz_options )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NODENAME, "IM_NODENAME"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:441:53: ( tikz_options )?
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:442:1: coord : ( ( ( coord_modifier )? coord_nodename ) -> ^( IM_COORD ( coord_modifier )? coord_nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) | ( ( coord_modifier )? '(' ')' ) -> ^( IM_COORD ) );
    public simpletikzParser.coord_return coord() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_return retval = new simpletikzParser.coord_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal260 = null;
        IToken char_literal264 = null;
        IToken char_literal266 = null;
        IToken char_literal270 = null;
        IToken char_literal272 = null;
        IToken char_literal273 = null;
        simpletikzParser.coord_modifier_return coord_modifier257 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.coord_nodename_return coord_nodename258 = default(simpletikzParser.coord_nodename_return);

        simpletikzParser.coord_modifier_return coord_modifier259 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.numberunit_return numberunit261 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_sep_return coord_sep262 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.numberunit_return numberunit263 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_modifier_return coord_modifier265 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.coord_part_return coord_part267 = default(simpletikzParser.coord_part_return);

        simpletikzParser.coord_sep_return coord_sep268 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.coord_part_return coord_part269 = default(simpletikzParser.coord_part_return);

        simpletikzParser.coord_modifier_return coord_modifier271 = default(simpletikzParser.coord_modifier_return);


        object char_literal260_tree=null;
        object char_literal264_tree=null;
        object char_literal266_tree=null;
        object char_literal270_tree=null;
        object char_literal272_tree=null;
        object char_literal273_tree=null;
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleSubtreeStream stream_coord_part = new RewriteRuleSubtreeStream(adaptor,"rule coord_part");
        RewriteRuleSubtreeStream stream_coord_nodename = new RewriteRuleSubtreeStream(adaptor,"rule coord_nodename");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_coord_sep = new RewriteRuleSubtreeStream(adaptor,"rule coord_sep");
        RewriteRuleSubtreeStream stream_coord_modifier = new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:443:2: ( ( ( coord_modifier )? coord_nodename ) -> ^( IM_COORD ( coord_modifier )? coord_nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) | ( ( coord_modifier )? '(' ')' ) -> ^( IM_COORD ) )
            int alt67 = 4;
            alt67 = dfa67.Predict(input);
            switch (alt67) 
            {
                case 1 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:443:6: ( ( coord_modifier )? coord_nodename )
                    {
                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:443:6: ( ( coord_modifier )? coord_nodename )
                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:443:8: ( coord_modifier )? coord_nodename
                    	{
                    		// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:443:8: ( coord_modifier )?
                    		int alt63 = 2;
                    		int LA63_0 = input.LA(1);

                    		if ( ((LA63_0 >= 90 && LA63_0 <= 91)) )
                    		{
                    		    alt63 = 1;
                    		}
                    		switch (alt63) 
                    		{
                    		    case 1 :
                    		        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:443:8: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord2786);
                    		        	coord_modifier257 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_coord_modifier.Add(coord_modifier257.Tree);

                    		        }
                    		        break;

                    		}

                    		PushFollow(FOLLOW_coord_nodename_in_coord2789);
                    		coord_nodename258 = coord_nodename();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_nodename.Add(coord_nodename258.Tree);

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
                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:443:47: ^( IM_COORD ( coord_modifier )? coord_nodename )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:443:58: ( coord_modifier )?
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
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:444:5: ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' )
                    {
                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:444:5: ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' )
                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:444:7: ( coord_modifier )? '(' numberunit coord_sep numberunit ')'
                    	{
                    		// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:444:7: ( coord_modifier )?
                    		int alt64 = 2;
                    		int LA64_0 = input.LA(1);

                    		if ( ((LA64_0 >= 90 && LA64_0 <= 91)) )
                    		{
                    		    alt64 = 1;
                    		}
                    		switch (alt64) 
                    		{
                    		    case 1 :
                    		        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:444:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord2815);
                    		        	coord_modifier259 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_coord_modifier.Add(coord_modifier259.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal260=(IToken)Match(input,53,FOLLOW_53_in_coord2818); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_53.Add(char_literal260);

                    		PushFollow(FOLLOW_numberunit_in_coord2820);
                    		numberunit261 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_numberunit.Add(numberunit261.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord2822);
                    		coord_sep262 = coord_sep();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_sep.Add(coord_sep262.Tree);
                    		PushFollow(FOLLOW_numberunit_in_coord2824);
                    		numberunit263 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_numberunit.Add(numberunit263.Tree);
                    		char_literal264=(IToken)Match(input,54,FOLLOW_54_in_coord2826); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_54.Add(char_literal264);


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
                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:444:68: ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:444:79: ( coord_modifier )?
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
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:445:5: ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' )
                    {
                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:445:5: ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' )
                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:445:7: ( coord_modifier )? '(' coord_part coord_sep coord_part ')'
                    	{
                    		// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:445:7: ( coord_modifier )?
                    		int alt65 = 2;
                    		int LA65_0 = input.LA(1);

                    		if ( ((LA65_0 >= 90 && LA65_0 <= 91)) )
                    		{
                    		    alt65 = 1;
                    		}
                    		switch (alt65) 
                    		{
                    		    case 1 :
                    		        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:445:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord2850);
                    		        	coord_modifier265 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_coord_modifier.Add(coord_modifier265.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal266=(IToken)Match(input,53,FOLLOW_53_in_coord2853); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_53.Add(char_literal266);

                    		PushFollow(FOLLOW_coord_part_in_coord2855);
                    		coord_part267 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_part.Add(coord_part267.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord2857);
                    		coord_sep268 = coord_sep();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_sep.Add(coord_sep268.Tree);
                    		PushFollow(FOLLOW_coord_part_in_coord2859);
                    		coord_part269 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_part.Add(coord_part269.Tree);
                    		char_literal270=(IToken)Match(input,54,FOLLOW_54_in_coord2861); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_54.Add(char_literal270);


                    	}



                    	// AST REWRITE
                    	// elements:          coord_sep, coord_modifier, coord_part
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
                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:445:68: ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:445:79: ( coord_modifier )?
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
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:446:5: ( ( coord_modifier )? '(' ')' )
                    {
                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:446:5: ( ( coord_modifier )? '(' ')' )
                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:446:7: ( coord_modifier )? '(' ')'
                    	{
                    		// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:446:7: ( coord_modifier )?
                    		int alt66 = 2;
                    		int LA66_0 = input.LA(1);

                    		if ( ((LA66_0 >= 90 && LA66_0 <= 91)) )
                    		{
                    		    alt66 = 1;
                    		}
                    		switch (alt66) 
                    		{
                    		    case 1 :
                    		        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:446:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord2885);
                    		        	coord_modifier271 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_coord_modifier.Add(coord_modifier271.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal272=(IToken)Match(input,53,FOLLOW_53_in_coord2888); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_53.Add(char_literal272);

                    		char_literal273=(IToken)Match(input,54,FOLLOW_54_in_coord2890); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_54.Add(char_literal273);


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
                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:446:40: ^( IM_COORD )
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:448:1: coord_nooption : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) );
    public simpletikzParser.coord_nooption_return coord_nooption() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_nooption_return retval = new simpletikzParser.coord_nooption_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal276 = null;
        IToken char_literal280 = null;
        IToken char_literal282 = null;
        IToken char_literal286 = null;
        simpletikzParser.nodename_return nodename274 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_modifier_return coord_modifier275 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.numberunit_return numberunit277 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_sep_return coord_sep278 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.numberunit_return numberunit279 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_modifier_return coord_modifier281 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.coord_part_return coord_part283 = default(simpletikzParser.coord_part_return);

        simpletikzParser.coord_sep_return coord_sep284 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.coord_part_return coord_part285 = default(simpletikzParser.coord_part_return);


        object char_literal276_tree=null;
        object char_literal280_tree=null;
        object char_literal282_tree=null;
        object char_literal286_tree=null;
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleSubtreeStream stream_nodename = new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        RewriteRuleSubtreeStream stream_coord_part = new RewriteRuleSubtreeStream(adaptor,"rule coord_part");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_coord_sep = new RewriteRuleSubtreeStream(adaptor,"rule coord_sep");
        RewriteRuleSubtreeStream stream_coord_modifier = new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:449:2: ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) )
            int alt70 = 3;
            alt70 = dfa70.Predict(input);
            switch (alt70) 
            {
                case 1 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:449:6: nodename
                    {
                    	PushFollow(FOLLOW_nodename_in_coord_nooption2918);
                    	nodename274 = nodename();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_nodename.Add(nodename274.Tree);


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
                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:449:25: ^( IM_COORD nodename )
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
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:450:5: ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' )
                    {
                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:450:5: ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' )
                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:450:7: ( coord_modifier )? '(' numberunit coord_sep numberunit ')'
                    	{
                    		// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:450:7: ( coord_modifier )?
                    		int alt68 = 2;
                    		int LA68_0 = input.LA(1);

                    		if ( ((LA68_0 >= 90 && LA68_0 <= 91)) )
                    		{
                    		    alt68 = 1;
                    		}
                    		switch (alt68) 
                    		{
                    		    case 1 :
                    		        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:450:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord_nooption2942);
                    		        	coord_modifier275 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_coord_modifier.Add(coord_modifier275.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal276=(IToken)Match(input,53,FOLLOW_53_in_coord_nooption2945); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_53.Add(char_literal276);

                    		PushFollow(FOLLOW_numberunit_in_coord_nooption2947);
                    		numberunit277 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_numberunit.Add(numberunit277.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord_nooption2949);
                    		coord_sep278 = coord_sep();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_sep.Add(coord_sep278.Tree);
                    		PushFollow(FOLLOW_numberunit_in_coord_nooption2951);
                    		numberunit279 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_numberunit.Add(numberunit279.Tree);
                    		char_literal280=(IToken)Match(input,54,FOLLOW_54_in_coord_nooption2953); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_54.Add(char_literal280);


                    	}



                    	// AST REWRITE
                    	// elements:          numberunit, coord_sep, coord_modifier
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
                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:450:68: ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:450:79: ( coord_modifier )?
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
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:451:5: ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' )
                    {
                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:451:5: ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' )
                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:451:7: ( coord_modifier )? '(' coord_part coord_sep coord_part ')'
                    	{
                    		// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:451:7: ( coord_modifier )?
                    		int alt69 = 2;
                    		int LA69_0 = input.LA(1);

                    		if ( ((LA69_0 >= 90 && LA69_0 <= 91)) )
                    		{
                    		    alt69 = 1;
                    		}
                    		switch (alt69) 
                    		{
                    		    case 1 :
                    		        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:451:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord_nooption2977);
                    		        	coord_modifier281 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_coord_modifier.Add(coord_modifier281.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal282=(IToken)Match(input,53,FOLLOW_53_in_coord_nooption2980); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_53.Add(char_literal282);

                    		PushFollow(FOLLOW_coord_part_in_coord_nooption2982);
                    		coord_part283 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_part.Add(coord_part283.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord_nooption2984);
                    		coord_sep284 = coord_sep();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_sep.Add(coord_sep284.Tree);
                    		PushFollow(FOLLOW_coord_part_in_coord_nooption2986);
                    		coord_part285 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_part.Add(coord_part285.Tree);
                    		char_literal286=(IToken)Match(input,54,FOLLOW_54_in_coord_nooption2988); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_54.Add(char_literal286);


                    	}



                    	// AST REWRITE
                    	// elements:          coord_sep, coord_modifier, coord_part
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
                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:451:68: ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:451:79: ( coord_modifier )?
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:460:1: coord_part : ( idd -> ^( IM_DONTCARE idd ) | '{' idd '}' -> ^( IM_DONTCARE '{' idd '}' ) | ( idd '=' numberunit ( ',' )? )+ -> ^( IM_DONTCARE ( idd '=' numberunit ( ',' )? )+ ) );
    public simpletikzParser.coord_part_return coord_part() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_part_return retval = new simpletikzParser.coord_part_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal288 = null;
        IToken char_literal290 = null;
        IToken char_literal292 = null;
        IToken char_literal294 = null;
        simpletikzParser.idd_return idd287 = default(simpletikzParser.idd_return);

        simpletikzParser.idd_return idd289 = default(simpletikzParser.idd_return);

        simpletikzParser.idd_return idd291 = default(simpletikzParser.idd_return);

        simpletikzParser.numberunit_return numberunit293 = default(simpletikzParser.numberunit_return);


        object char_literal288_tree=null;
        object char_literal290_tree=null;
        object char_literal292_tree=null;
        object char_literal294_tree=null;
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_47 = new RewriteRuleTokenStream(adaptor,"token 47");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:461:2: ( idd -> ^( IM_DONTCARE idd ) | '{' idd '}' -> ^( IM_DONTCARE '{' idd '}' ) | ( idd '=' numberunit ( ',' )? )+ -> ^( IM_DONTCARE ( idd '=' numberunit ( ',' )? )+ ) )
            int alt73 = 3;
            alt73 = dfa73.Predict(input);
            switch (alt73) 
            {
                case 1 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:461:4: idd
                    {
                    	PushFollow(FOLLOW_idd_in_coord_part3021);
                    	idd287 = idd();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_idd.Add(idd287.Tree);


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
                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:461:12: ^( IM_DONTCARE idd )
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
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:462:4: '{' idd '}'
                    {
                    	char_literal288=(IToken)Match(input,43,FOLLOW_43_in_coord_part3036); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_43.Add(char_literal288);

                    	PushFollow(FOLLOW_idd_in_coord_part3038);
                    	idd289 = idd();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_idd.Add(idd289.Tree);
                    	char_literal290=(IToken)Match(input,44,FOLLOW_44_in_coord_part3040); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_44.Add(char_literal290);



                    	// AST REWRITE
                    	// elements:          43, 44, idd
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
                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:462:19: ^( IM_DONTCARE '{' idd '}' )
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
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:463:4: ( idd '=' numberunit ( ',' )? )+
                    {
                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:463:4: ( idd '=' numberunit ( ',' )? )+
                    	int cnt72 = 0;
                    	do 
                    	{
                    	    int alt72 = 2;
                    	    int LA72_0 = input.LA(1);

                    	    if ( (LA72_0 == 79) )
                    	    {
                    	        int LA72_2 = input.LA(2);

                    	        if ( ((LA72_2 >= FLOAT_WO_EXP && LA72_2 <= INT)) )
                    	        {
                    	            int LA72_4 = input.LA(3);

                    	            if ( ((LA72_4 >= 58 && LA72_4 <= 63)) )
                    	            {
                    	                int LA72_5 = input.LA(4);

                    	                if ( ((LA72_5 >= IM_PATH && LA72_5 <= 42) || (LA72_5 >= 45 && LA72_5 <= 46) || (LA72_5 >= 51 && LA72_5 <= 52) || (LA72_5 >= 58 && LA72_5 <= 95)) )
                    	                {
                    	                    alt72 = 1;
                    	                }


                    	            }
                    	            else if ( ((LA72_4 >= IM_PATH && LA72_4 <= 42) || (LA72_4 >= 45 && LA72_4 <= 46) || (LA72_4 >= 51 && LA72_4 <= 52) || (LA72_4 >= 64 && LA72_4 <= 95)) )
                    	            {
                    	                alt72 = 1;
                    	            }


                    	        }
                    	        else if ( ((LA72_2 >= IM_PATH && LA72_2 <= COMMAND) || (LA72_2 >= WS && LA72_2 <= 42) || (LA72_2 >= 45 && LA72_2 <= 46) || (LA72_2 >= 51 && LA72_2 <= 52) || (LA72_2 >= 58 && LA72_2 <= 95)) )
                    	        {
                    	            alt72 = 1;
                    	        }


                    	    }
                    	    else if ( ((LA72_0 >= IM_PATH && LA72_0 <= 42) || LA72_0 == 46 || (LA72_0 >= 51 && LA72_0 <= 52) || (LA72_0 >= 58 && LA72_0 <= 78) || (LA72_0 >= 80 && LA72_0 <= 95)) )
                    	    {
                    	        alt72 = 1;
                    	    }


                    	    switch (alt72) 
                    		{
                    			case 1 :
                    			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:463:5: idd '=' numberunit ( ',' )?
                    			    {
                    			    	PushFollow(FOLLOW_idd_in_coord_part3058);
                    			    	idd291 = idd();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking==0 ) stream_idd.Add(idd291.Tree);
                    			    	char_literal292=(IToken)Match(input,45,FOLLOW_45_in_coord_part3060); if (state.failed) return retval; 
                    			    	if ( state.backtracking==0 ) stream_45.Add(char_literal292);

                    			    	PushFollow(FOLLOW_numberunit_in_coord_part3062);
                    			    	numberunit293 = numberunit();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking==0 ) stream_numberunit.Add(numberunit293.Tree);
                    			    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:463:24: ( ',' )?
                    			    	int alt71 = 2;
                    			    	int LA71_0 = input.LA(1);

                    			    	if ( (LA71_0 == 47) )
                    			    	{
                    			    	    alt71 = 1;
                    			    	}
                    			    	switch (alt71) 
                    			    	{
                    			    	    case 1 :
                    			    	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:463:24: ','
                    			    	        {
                    			    	        	char_literal294=(IToken)Match(input,47,FOLLOW_47_in_coord_part3064); if (state.failed) return retval; 
                    			    	        	if ( state.backtracking==0 ) stream_47.Add(char_literal294);


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
                    	// elements:          45, idd, numberunit, 47
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
                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:463:34: ^( IM_DONTCARE ( idd '=' numberunit ( ',' )? )+ )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DONTCARE, "IM_DONTCARE"), root_1);

                    	    if ( !(stream_45.HasNext() || stream_idd.HasNext() || stream_numberunit.HasNext()) ) {
                    	        throw new RewriteEarlyExitException();
                    	    }
                    	    while ( stream_45.HasNext() || stream_idd.HasNext() || stream_numberunit.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_idd.NextTree());
                    	        adaptor.AddChild(root_1, stream_45.NextNode());
                    	        adaptor.AddChild(root_1, stream_numberunit.NextTree());
                    	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:463:69: ( ',' )?
                    	        if ( stream_47.HasNext() )
                    	        {
                    	            adaptor.AddChild(root_1, stream_47.NextNode());

                    	        }
                    	        stream_47.Reset();

                    	    }
                    	    stream_45.Reset();
                    	    stream_idd.Reset();
                    	    stream_numberunit.Reset();

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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:465:1: coord_sep : ( ',' | ':' ) ;
    public simpletikzParser.coord_sep_return coord_sep() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_sep_return retval = new simpletikzParser.coord_sep_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set295 = null;

        object set295_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:466:2: ( ( ',' | ':' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:466:4: ( ',' | ':' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set295 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 47 && input.LA(1) <= 48) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set295));
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:470:1: edgeop : ( '--' | '->' | '|-' | '-|' | ID );
    public simpletikzParser.edgeop_return edgeop() // throws RecognitionException [1]
    {   
        simpletikzParser.edgeop_return retval = new simpletikzParser.edgeop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set296 = null;

        object set296_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:471:2: ( '--' | '->' | '|-' | '-|' | ID )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set296 = (IToken)input.LT(1);
            	if ( input.LA(1) == ID || (input.LA(1) >= 86 && input.LA(1) <= 89) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set296));
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:475:1: coord_modifier : ( '+' | '++' );
    public simpletikzParser.coord_modifier_return coord_modifier() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_modifier_return retval = new simpletikzParser.coord_modifier_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set297 = null;

        object set297_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:476:2: ( '+' | '++' )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set297 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 90 && input.LA(1) <= 91) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set297));
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:518:1: squarebr_start : '[' -> ^( IM_STARTTAG '[' ) ;
    public simpletikzParser.squarebr_start_return squarebr_start() // throws RecognitionException [1]
    {   
        simpletikzParser.squarebr_start_return retval = new simpletikzParser.squarebr_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal298 = null;

        object char_literal298_tree=null;
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:519:2: ( '[' -> ^( IM_STARTTAG '[' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:519:4: '['
            {
            	char_literal298=(IToken)Match(input,55,FOLLOW_55_in_squarebr_start3170); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_55.Add(char_literal298);



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
            	// 519:8: -> ^( IM_STARTTAG '[' )
            	{
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:519:11: ^( IM_STARTTAG '[' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:521:1: squarebr_end : ']' -> ^( IM_ENDTAG ']' ) ;
    public simpletikzParser.squarebr_end_return squarebr_end() // throws RecognitionException [1]
    {   
        simpletikzParser.squarebr_end_return retval = new simpletikzParser.squarebr_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal299 = null;

        object char_literal299_tree=null;
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:522:2: ( ']' -> ^( IM_ENDTAG ']' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:522:4: ']'
            {
            	char_literal299=(IToken)Match(input,56,FOLLOW_56_in_squarebr_end3188); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_56.Add(char_literal299);



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
            	// 522:8: -> ^( IM_ENDTAG ']' )
            	{
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:522:11: ^( IM_ENDTAG ']' )
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:524:1: semicolon_end : ';' -> ^( IM_ENDTAG ';' ) ;
    public simpletikzParser.semicolon_end_return semicolon_end() // throws RecognitionException [1]
    {   
        simpletikzParser.semicolon_end_return retval = new simpletikzParser.semicolon_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal300 = null;

        object char_literal300_tree=null;
        RewriteRuleTokenStream stream_57 = new RewriteRuleTokenStream(adaptor,"token 57");

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:525:2: ( ';' -> ^( IM_ENDTAG ';' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:525:4: ';'
            {
            	char_literal300=(IToken)Match(input,57,FOLLOW_57_in_semicolon_end3207); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_57.Add(char_literal300);



            	// AST REWRITE
            	// elements:          57
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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:525:11: ^( IM_ENDTAG ';' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_57.NextNode());

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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:527:1: roundbr_start : '{' -> ^( IM_STARTTAG '{' ) ;
    public simpletikzParser.roundbr_start_return roundbr_start() // throws RecognitionException [1]
    {   
        simpletikzParser.roundbr_start_return retval = new simpletikzParser.roundbr_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal301 = null;

        object char_literal301_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:528:2: ( '{' -> ^( IM_STARTTAG '{' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:528:4: '{'
            {
            	char_literal301=(IToken)Match(input,43,FOLLOW_43_in_roundbr_start3225); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_43.Add(char_literal301);



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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:528:11: ^( IM_STARTTAG '{' )
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:530:1: roundbr_end : '}' -> ^( IM_ENDTAG '}' ) ;
    public simpletikzParser.roundbr_end_return roundbr_end() // throws RecognitionException [1]
    {   
        simpletikzParser.roundbr_end_return retval = new simpletikzParser.roundbr_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal302 = null;

        object char_literal302_tree=null;
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:531:2: ( '}' -> ^( IM_ENDTAG '}' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:531:4: '}'
            {
            	char_literal302=(IToken)Match(input,44,FOLLOW_44_in_roundbr_end3243); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_44.Add(char_literal302);



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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:531:11: ^( IM_ENDTAG '}' )
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:533:1: controls_start : '..' 'controls' -> ^( IM_STARTTAG '..' ) ;
    public simpletikzParser.controls_start_return controls_start() // throws RecognitionException [1]
    {   
        simpletikzParser.controls_start_return retval = new simpletikzParser.controls_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal303 = null;
        IToken string_literal304 = null;

        object string_literal303_tree=null;
        object string_literal304_tree=null;
        RewriteRuleTokenStream stream_92 = new RewriteRuleTokenStream(adaptor,"token 92");
        RewriteRuleTokenStream stream_93 = new RewriteRuleTokenStream(adaptor,"token 93");

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:534:2: ( '..' 'controls' -> ^( IM_STARTTAG '..' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:534:4: '..' 'controls'
            {
            	string_literal303=(IToken)Match(input,92,FOLLOW_92_in_controls_start3261); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_92.Add(string_literal303);

            	string_literal304=(IToken)Match(input,93,FOLLOW_93_in_controls_start3263); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_93.Add(string_literal304);



            	// AST REWRITE
            	// elements:          92
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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:534:23: ^( IM_STARTTAG '..' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_92.NextNode());

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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:536:1: controls_end : '..' -> ^( IM_ENDTAG '..' ) ;
    public simpletikzParser.controls_end_return controls_end() // throws RecognitionException [1]
    {   
        simpletikzParser.controls_end_return retval = new simpletikzParser.controls_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal305 = null;

        object string_literal305_tree=null;
        RewriteRuleTokenStream stream_92 = new RewriteRuleTokenStream(adaptor,"token 92");

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:537:2: ( '..' -> ^( IM_ENDTAG '..' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:537:4: '..'
            {
            	string_literal305=(IToken)Match(input,92,FOLLOW_92_in_controls_end3281); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_92.Add(string_literal305);



            	// AST REWRITE
            	// elements:          92
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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:537:12: ^( IM_ENDTAG '..' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_92.NextNode());

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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:539:1: tikz_set_start : '\\\\tikzset' '{' -> ^( IM_STARTTAG ) ;
    public simpletikzParser.tikz_set_start_return tikz_set_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_set_start_return retval = new simpletikzParser.tikz_set_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal306 = null;
        IToken char_literal307 = null;

        object string_literal306_tree=null;
        object char_literal307_tree=null;
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:540:2: ( '\\\\tikzset' '{' -> ^( IM_STARTTAG ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:540:4: '\\\\tikzset' '{'
            {
            	string_literal306=(IToken)Match(input,41,FOLLOW_41_in_tikz_set_start3299); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_41.Add(string_literal306);

            	char_literal307=(IToken)Match(input,43,FOLLOW_43_in_tikz_set_start3301); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_43.Add(char_literal307);



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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:540:24: ^( IM_STARTTAG )
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:542:1: tikzpicture_start : '\\\\begin' '{' 'tikzpicture' '}' -> ^( IM_STARTTAG '\\\\begin' ) ;
    public simpletikzParser.tikzpicture_start_return tikzpicture_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_start_return retval = new simpletikzParser.tikzpicture_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal308 = null;
        IToken char_literal309 = null;
        IToken string_literal310 = null;
        IToken char_literal311 = null;

        object string_literal308_tree=null;
        object char_literal309_tree=null;
        object string_literal310_tree=null;
        object char_literal311_tree=null;
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");
        RewriteRuleTokenStream stream_94 = new RewriteRuleTokenStream(adaptor,"token 94");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:543:2: ( '\\\\begin' '{' 'tikzpicture' '}' -> ^( IM_STARTTAG '\\\\begin' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:543:4: '\\\\begin' '{' 'tikzpicture' '}'
            {
            	string_literal308=(IToken)Match(input,39,FOLLOW_39_in_tikzpicture_start3320); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_39.Add(string_literal308);

            	char_literal309=(IToken)Match(input,43,FOLLOW_43_in_tikzpicture_start3322); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_43.Add(char_literal309);

            	string_literal310=(IToken)Match(input,94,FOLLOW_94_in_tikzpicture_start3324); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_94.Add(string_literal310);

            	char_literal311=(IToken)Match(input,44,FOLLOW_44_in_tikzpicture_start3326); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_44.Add(char_literal311);



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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:543:39: ^( IM_STARTTAG '\\\\begin' )
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:545:1: tikz_start : '\\\\tikz' -> ^( IM_STARTTAG '\\\\tikz' ) ;
    public simpletikzParser.tikz_start_return tikz_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_start_return retval = new simpletikzParser.tikz_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal312 = null;

        object string_literal312_tree=null;
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:546:2: ( '\\\\tikz' -> ^( IM_STARTTAG '\\\\tikz' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:546:4: '\\\\tikz'
            {
            	string_literal312=(IToken)Match(input,42,FOLLOW_42_in_tikz_start3344); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_42.Add(string_literal312);



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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:546:16: ^( IM_STARTTAG '\\\\tikz' )
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:548:1: tikzpicture_end : '\\\\end' '{' 'tikzpicture' '}' -> ^( IM_ENDTAG '\\\\end' ) ;
    public simpletikzParser.tikzpicture_end_return tikzpicture_end() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_end_return retval = new simpletikzParser.tikzpicture_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal313 = null;
        IToken char_literal314 = null;
        IToken string_literal315 = null;
        IToken char_literal316 = null;

        object string_literal313_tree=null;
        object char_literal314_tree=null;
        object string_literal315_tree=null;
        object char_literal316_tree=null;
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_94 = new RewriteRuleTokenStream(adaptor,"token 94");
        RewriteRuleTokenStream stream_64 = new RewriteRuleTokenStream(adaptor,"token 64");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:549:2: ( '\\\\end' '{' 'tikzpicture' '}' -> ^( IM_ENDTAG '\\\\end' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:549:4: '\\\\end' '{' 'tikzpicture' '}'
            {
            	string_literal313=(IToken)Match(input,64,FOLLOW_64_in_tikzpicture_end3362); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_64.Add(string_literal313);

            	char_literal314=(IToken)Match(input,43,FOLLOW_43_in_tikzpicture_end3364); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_43.Add(char_literal314);

            	string_literal315=(IToken)Match(input,94,FOLLOW_94_in_tikzpicture_end3366); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_94.Add(string_literal315);

            	char_literal316=(IToken)Match(input,44,FOLLOW_44_in_tikzpicture_end3368); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_44.Add(char_literal316);



            	// AST REWRITE
            	// elements:          64
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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:549:37: ^( IM_ENDTAG '\\\\end' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_64.NextNode());

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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:551:1: tikzscope_start : '\\\\begin' '{' 'scope' '}' -> ^( IM_STARTTAG '\\\\begin' ) ;
    public simpletikzParser.tikzscope_start_return tikzscope_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_start_return retval = new simpletikzParser.tikzscope_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal317 = null;
        IToken char_literal318 = null;
        IToken string_literal319 = null;
        IToken char_literal320 = null;

        object string_literal317_tree=null;
        object char_literal318_tree=null;
        object string_literal319_tree=null;
        object char_literal320_tree=null;
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");
        RewriteRuleTokenStream stream_95 = new RewriteRuleTokenStream(adaptor,"token 95");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:552:2: ( '\\\\begin' '{' 'scope' '}' -> ^( IM_STARTTAG '\\\\begin' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:552:4: '\\\\begin' '{' 'scope' '}'
            {
            	string_literal317=(IToken)Match(input,39,FOLLOW_39_in_tikzscope_start3386); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_39.Add(string_literal317);

            	char_literal318=(IToken)Match(input,43,FOLLOW_43_in_tikzscope_start3388); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_43.Add(char_literal318);

            	string_literal319=(IToken)Match(input,95,FOLLOW_95_in_tikzscope_start3390); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_95.Add(string_literal319);

            	char_literal320=(IToken)Match(input,44,FOLLOW_44_in_tikzscope_start3392); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_44.Add(char_literal320);



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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:552:33: ^( IM_STARTTAG '\\\\begin' )
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:554:1: tikzscope_end : '\\\\end' '{' 'scope' '}' -> ^( IM_ENDTAG '\\\\end' ) ;
    public simpletikzParser.tikzscope_end_return tikzscope_end() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_end_return retval = new simpletikzParser.tikzscope_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal321 = null;
        IToken char_literal322 = null;
        IToken string_literal323 = null;
        IToken char_literal324 = null;

        object string_literal321_tree=null;
        object char_literal322_tree=null;
        object string_literal323_tree=null;
        object char_literal324_tree=null;
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_95 = new RewriteRuleTokenStream(adaptor,"token 95");
        RewriteRuleTokenStream stream_64 = new RewriteRuleTokenStream(adaptor,"token 64");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:555:2: ( '\\\\end' '{' 'scope' '}' -> ^( IM_ENDTAG '\\\\end' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:555:4: '\\\\end' '{' 'scope' '}'
            {
            	string_literal321=(IToken)Match(input,64,FOLLOW_64_in_tikzscope_end3410); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_64.Add(string_literal321);

            	char_literal322=(IToken)Match(input,43,FOLLOW_43_in_tikzscope_end3412); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_43.Add(char_literal322);

            	string_literal323=(IToken)Match(input,95,FOLLOW_95_in_tikzscope_end3414); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_95.Add(string_literal323);

            	char_literal324=(IToken)Match(input,44,FOLLOW_44_in_tikzscope_end3416); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_44.Add(char_literal324);



            	// AST REWRITE
            	// elements:          64
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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:555:31: ^( IM_ENDTAG '\\\\end' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_64.NextNode());

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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:557:1: path_start : path_start_tag -> ^( IM_STARTTAG path_start_tag ) ;
    public simpletikzParser.path_start_return path_start() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_return retval = new simpletikzParser.path_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.path_start_tag_return path_start_tag325 = default(simpletikzParser.path_start_tag_return);


        RewriteRuleSubtreeStream stream_path_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule path_start_tag");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:558:2: ( path_start_tag -> ^( IM_STARTTAG path_start_tag ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:558:4: path_start_tag
            {
            	PushFollow(FOLLOW_path_start_tag_in_path_start3435);
            	path_start_tag325 = path_start_tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_path_start_tag.Add(path_start_tag325.Tree);


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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:558:22: ^( IM_STARTTAG path_start_tag )
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:560:1: node_start : node_start_tag -> ^( IM_STARTTAG node_start_tag ) ;
    public simpletikzParser.node_start_return node_start() // throws RecognitionException [1]
    {   
        simpletikzParser.node_start_return retval = new simpletikzParser.node_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.node_start_tag_return node_start_tag326 = default(simpletikzParser.node_start_tag_return);


        RewriteRuleSubtreeStream stream_node_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule node_start_tag");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:561:2: ( node_start_tag -> ^( IM_STARTTAG node_start_tag ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:561:4: node_start_tag
            {
            	PushFollow(FOLLOW_node_start_tag_in_node_start3453);
            	node_start_tag326 = node_start_tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_node_start_tag.Add(node_start_tag326.Tree);


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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:561:22: ^( IM_STARTTAG node_start_tag )
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:563:1: def_start : def_start_tag -> ^( IM_STARTTAG def_start_tag ) ;
    public simpletikzParser.def_start_return def_start() // throws RecognitionException [1]
    {   
        simpletikzParser.def_start_return retval = new simpletikzParser.def_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.def_start_tag_return def_start_tag327 = default(simpletikzParser.def_start_tag_return);


        RewriteRuleSubtreeStream stream_def_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule def_start_tag");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:564:2: ( def_start_tag -> ^( IM_STARTTAG def_start_tag ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:564:4: def_start_tag
            {
            	PushFollow(FOLLOW_def_start_tag_in_def_start3471);
            	def_start_tag327 = def_start_tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_def_start_tag.Add(def_start_tag327.Tree);


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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:564:21: ^( IM_STARTTAG def_start_tag )
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:566:1: matrix_start : matrix_start_tag -> ^( IM_STARTTAG matrix_start_tag ) ;
    public simpletikzParser.matrix_start_return matrix_start() // throws RecognitionException [1]
    {   
        simpletikzParser.matrix_start_return retval = new simpletikzParser.matrix_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.matrix_start_tag_return matrix_start_tag328 = default(simpletikzParser.matrix_start_tag_return);


        RewriteRuleSubtreeStream stream_matrix_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule matrix_start_tag");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:567:2: ( matrix_start_tag -> ^( IM_STARTTAG matrix_start_tag ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:567:4: matrix_start_tag
            {
            	PushFollow(FOLLOW_matrix_start_tag_in_matrix_start3489);
            	matrix_start_tag328 = matrix_start_tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_matrix_start_tag.Add(matrix_start_tag328.Tree);


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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:567:24: ^( IM_STARTTAG matrix_start_tag )
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:569:1: node_start_tag : '\\\\node' ;
    public simpletikzParser.node_start_tag_return node_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.node_start_tag_return retval = new simpletikzParser.node_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal329 = null;

        object string_literal329_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:570:2: ( '\\\\node' )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:570:4: '\\\\node'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal329=(IToken)Match(input,65,FOLLOW_65_in_node_start_tag3507); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal329_tree = (object)adaptor.Create(string_literal329);
            		adaptor.AddChild(root_0, string_literal329_tree);
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:572:1: def_start_tag : '\\\\def' ;
    public simpletikzParser.def_start_tag_return def_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.def_start_tag_return retval = new simpletikzParser.def_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal330 = null;

        object string_literal330_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:573:2: ( '\\\\def' )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:573:4: '\\\\def'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal330=(IToken)Match(input,70,FOLLOW_70_in_def_start_tag3517); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal330_tree = (object)adaptor.Create(string_literal330);
            		adaptor.AddChild(root_0, string_literal330_tree);
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:575:1: matrix_start_tag : '\\\\matrix' ;
    public simpletikzParser.matrix_start_tag_return matrix_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.matrix_start_tag_return retval = new simpletikzParser.matrix_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal331 = null;

        object string_literal331_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:576:2: ( '\\\\matrix' )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:576:4: '\\\\matrix'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal331=(IToken)Match(input,66,FOLLOW_66_in_matrix_start_tag3527); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal331_tree = (object)adaptor.Create(string_literal331);
            		adaptor.AddChild(root_0, string_literal331_tree);
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:578:1: coordinate_start : '\\\\coordinate' -> ^( IM_STARTTAG '\\\\coordinate' ) ;
    public simpletikzParser.coordinate_start_return coordinate_start() // throws RecognitionException [1]
    {   
        simpletikzParser.coordinate_start_return retval = new simpletikzParser.coordinate_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal332 = null;

        object string_literal332_tree=null;
        RewriteRuleTokenStream stream_67 = new RewriteRuleTokenStream(adaptor,"token 67");

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:579:2: ( '\\\\coordinate' -> ^( IM_STARTTAG '\\\\coordinate' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:579:4: '\\\\coordinate'
            {
            	string_literal332=(IToken)Match(input,67,FOLLOW_67_in_coordinate_start3537); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_67.Add(string_literal332);



            	// AST REWRITE
            	// elements:          67
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
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:579:22: ^( IM_STARTTAG '\\\\coordinate' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_67.NextNode());

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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:581:1: path_start_tag : ( '\\\\draw' | '\\\\fill' | '\\\\path' | '\\\\clip' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' );
    public simpletikzParser.path_start_tag_return path_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_tag_return retval = new simpletikzParser.path_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set333 = null;

        object set333_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:582:2: ( '\\\\draw' | '\\\\fill' | '\\\\path' | '\\\\clip' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set333 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 68 && input.LA(1) <= 69) || (input.LA(1) >= 71 && input.LA(1) <= 77) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set333));
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
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:331:5: ( coord )
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:331:6: coord
        {
        	PushFollow(FOLLOW_coord_in_synpred1_simpletikz1889);
        	coord();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred1_simpletikz"

    // $ANTLR start "synpred2_simpletikz"
    public void synpred2_simpletikz_fragment() {
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:359:8: ( tikzcoordinate_core3 )
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:359:9: tikzcoordinate_core3
        {
        	PushFollow(FOLLOW_tikzcoordinate_core3_in_synpred2_simpletikz2132);
        	tikzcoordinate_core3();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred2_simpletikz"

    // $ANTLR start "synpred3_simpletikz"
    public void synpred3_simpletikz_fragment() {
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:360:12: ( tikzcoordinate_core2 )
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:360:13: tikzcoordinate_core2
        {
        	PushFollow(FOLLOW_tikzcoordinate_core2_in_synpred3_simpletikz2151);
        	tikzcoordinate_core2();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred3_simpletikz"

    // $ANTLR start "synpred4_simpletikz"
    public void synpred4_simpletikz_fragment() {
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:361:12: ( tikzcoordinate_core1 )
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:361:13: tikzcoordinate_core1
        {
        	PushFollow(FOLLOW_tikzcoordinate_core1_in_synpred4_simpletikz2171);
        	tikzcoordinate_core1();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred4_simpletikz"

    // $ANTLR start "synpred5_simpletikz"
    public void synpred5_simpletikz_fragment() {
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:370:21: ( tikzcoordinate_core3 )
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:370:22: tikzcoordinate_core3
        {
        	PushFollow(FOLLOW_tikzcoordinate_core3_in_synpred5_simpletikz2256);
        	tikzcoordinate_core3();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred5_simpletikz"

    // $ANTLR start "synpred6_simpletikz"
    public void synpred6_simpletikz_fragment() {
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:371:12: ( tikzcoordinate_core2 )
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:371:13: tikzcoordinate_core2
        {
        	PushFollow(FOLLOW_tikzcoordinate_core2_in_synpred6_simpletikz2275);
        	tikzcoordinate_core2();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred6_simpletikz"

    // $ANTLR start "synpred7_simpletikz"
    public void synpred7_simpletikz_fragment() {
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:372:12: ( tikzcoordinate_core1 )
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:372:13: tikzcoordinate_core1
        {
        	PushFollow(FOLLOW_tikzcoordinate_core1_in_synpred7_simpletikz2295);
        	tikzcoordinate_core1();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred7_simpletikz"

    // $ANTLR start "synpred8_simpletikz"
    public void synpred8_simpletikz_fragment() {
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:420:28: ( size )
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:420:29: size
        {
        	PushFollow(FOLLOW_size_in_synpred8_simpletikz2587);
        	size();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred8_simpletikz"

    // Delegated rules

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
        "\x02\x5f\x02\uffff";
    const string DFA10_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA10_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA10_transitionS = {
            "\x27\x01\x03\uffff\x01\x01\x04\uffff\x02\x01\x05\uffff\x26"+
            "\x01",
            "\x27\x01\x03\x02\x01\x01\x01\x02\x01\uffff\x02\x03\x02\x01"+
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
        "\x01\x04\x01\x2b\x01\x04\x01\uffff\x01\x2b\x01\x1e\x01\uffff\x02"+
        "\x04\x02\uffff\x10\x04\x01\uffff\x1d\x04";
    const string DFA16_maxS =
        "\x01\x5f\x01\x3f\x01\x5f\x01\uffff\x01\x38\x01\x2b\x01\uffff\x02"+
        "\x5f\x02\uffff\x10\x5f\x01\uffff\x1d\x5f";
    const string DFA16_acceptS =
        "\x03\uffff\x01\x04\x02\uffff\x01\x02\x02\uffff\x01\x05\x01\x01"+
        "\x10\uffff\x01\x03\x1d\uffff";
    const string DFA16_specialS =
        "\x39\uffff}>";
    static readonly string[] DFA16_transitionS = {
            "\x1a\x03\x02\x01\x0b\x03\x01\x02\x02\uffff\x01\x03\x04\uffff"+
            "\x02\x03\x05\uffff\x26\x03",
            "\x02\x06\x02\uffff\x01\x06\x01\x05\x07\uffff\x01\x06\x01\uffff"+
            "\x06\x04",
            "\x31\x09\x01\x07\x24\x09\x02\x08\x04\x09",
            "",
            "\x02\x06\x02\uffff\x01\x06\x01\x0a\x07\uffff\x01\x06",
            "\x02\x0a\x0b\uffff\x01\x09",
            "",
            "\x1a\x0c\x02\x0b\x0b\x0c\x01\x0d\x02\x09\x01\x0c\x04\x09\x02"+
            "\x0c\x05\x09\x26\x0c",
            "\x31\x09\x01\x0e\x2a\x09",
            "",
            "",
            "\x27\x0c\x02\x09\x01\x0f\x01\x0c\x02\x11\x02\x09\x02\x0c\x01"+
            "\x09\x01\x12\x03\x09\x06\x10\x20\x0c",
            "\x27\x0c\x02\x09\x01\x0f\x01\x0c\x02\x13\x02\x09\x02\x0c\x01"+
            "\x09\x01\x12\x03\x09\x26\x0c",
            "\x27\x14\x03\x09\x01\x14\x04\x09\x02\x14\x05\x09\x26\x14",
            "\x1a\x16\x02\x15\x0b\x16\x01\x0d\x02\x09\x01\x16\x04\x09\x02"+
            "\x16\x05\x09\x26\x16",
            "\x1a\x09\x02\x17\x40\x09",
            "\x27\x0c\x02\x09\x01\x0f\x01\x0c\x02\x11\x02\x09\x02\x0c\x01"+
            "\x09\x01\x12\x03\x09\x26\x0c",
            "\x1a\x1a\x02\x18\x0b\x1a\x01\x19\x02\x09\x01\x1a\x04\x09\x02"+
            "\x1a\x05\x09\x26\x1a",
            "\x28\x09\x01\x1b\x33\x09",
            "\x27\x1a\x01\x19\x02\x09\x01\x1a\x04\x09\x02\x1a\x05\x09\x26"+
            "\x1a",
            "\x27\x14\x01\x09\x01\x1c\x01\x09\x01\x14\x04\x09\x02\x14\x05"+
            "\x09\x26\x14",
            "\x27\x16\x02\x09\x01\x0f\x01\x16\x02\x11\x02\x09\x02\x16\x05"+
            "\x09\x06\x1d\x20\x16",
            "\x27\x16\x02\x09\x01\x0f\x01\x16\x02\x13\x02\x09\x02\x16\x05"+
            "\x09\x26\x16",
            "\x27\x20\x03\x09\x01\x20\x01\x1f\x01\x13\x02\x09\x02\x20\x05"+
            "\x09\x06\x1e\x20\x20",
            "\x27\x1a\x02\x09\x01\x23\x01\x1a\x04\x09\x02\x1a\x01\x09\x01"+
            "\x21\x03\x09\x06\x22\x20\x1a",
            "\x27\x24\x03\x09\x01\x24\x04\x09\x02\x24\x05\x09\x26\x24",
            "\x27\x1a\x02\x09\x01\x23\x01\x1a\x04\x09\x02\x1a\x01\x09\x01"+
            "\x25\x03\x09\x26\x1a",
            "",
            "\x2b\x09\x02\x26\x2f\x09",
            "\x27\x16\x02\x09\x01\x0f\x01\x16\x02\x11\x02\x09\x02\x16\x05"+
            "\x09\x26\x16",
            "\x27\x20\x02\x09\x01\x0f\x01\x20\x01\x1f\x01\x13\x02\x09\x02"+
            "\x20\x05\x09\x26\x20",
            "\x27\x27\x01\x19\x02\x09\x01\x27\x02\x13\x02\x09\x02\x27\x05"+
            "\x09\x26\x27",
            "\x27\x20\x02\x09\x01\x0f\x01\x20\x04\x09\x02\x20\x05\x09\x26"+
            "\x20",
            "\x28\x09\x01\x1b\x33\x09",
            "\x27\x1a\x02\x09\x01\x23\x01\x1a\x04\x09\x02\x1a\x01\x09\x01"+
            "\x21\x03\x09\x26\x1a",
            "\x1a\x09\x02\x28\x40\x09",
            "\x27\x24\x01\x09\x01\x29\x01\x09\x01\x24\x04\x09\x02\x24\x05"+
            "\x09\x26\x24",
            "\x28\x09\x01\x1b\x33\x09",
            "\x27\x2a\x01\x19\x02\x09\x01\x2a\x04\x09\x02\x2a\x05\x09\x26"+
            "\x2a",
            "\x27\x27\x02\x09\x01\x2b\x01\x27\x04\x09\x02\x27\x01\x09\x01"+
            "\x25\x03\x09\x26\x27",
            "\x27\x2e\x03\x09\x01\x2e\x01\x2d\x03\x09\x02\x2e\x01\x09\x01"+
            "\x25\x03\x09\x06\x2c\x20\x2e",
            "\x32\x09\x01\x2f\x29\x09",
            "\x27\x2a\x02\x09\x01\x30\x01\x2a\x04\x09\x02\x2a\x01\x09\x01"+
            "\x2f\x03\x09\x26\x2a",
            "\x1a\x09\x02\x31\x40\x09",
            "\x27\x2e\x02\x09\x01\x23\x01\x2e\x01\x2d\x03\x09\x02\x2e\x01"+
            "\x09\x01\x25\x03\x09\x26\x2e",
            "\x27\x2e\x03\x09\x01\x2e\x04\x09\x02\x2e\x01\x09\x01\x25\x03"+
            "\x09\x26\x2e",
            "\x27\x2e\x02\x09\x01\x23\x01\x2e\x04\x09\x02\x2e\x05\x09\x26"+
            "\x2e",
            "\x28\x09\x01\x1b\x33\x09",
            "\x1a\x09\x02\x32\x40\x09",
            "\x27\x35\x03\x09\x01\x35\x01\x34\x01\x13\x02\x09\x02\x35\x01"+
            "\x09\x01\x25\x03\x09\x06\x33\x20\x35",
            "\x27\x38\x03\x09\x01\x38\x01\x37\x03\x09\x02\x38\x01\x09\x01"+
            "\x2f\x03\x09\x06\x36\x20\x38",
            "\x27\x35\x02\x09\x01\x2b\x01\x35\x01\x34\x01\x13\x02\x09\x02"+
            "\x35\x01\x09\x01\x25\x03\x09\x26\x35",
            "\x27\x27\x01\x19\x02\x09\x01\x27\x02\x13\x02\x09\x02\x27\x01"+
            "\x09\x01\x25\x03\x09\x26\x27",
            "\x27\x35\x02\x09\x01\x2b\x01\x35\x04\x09\x02\x35\x05\x09\x26"+
            "\x35",
            "\x27\x38\x02\x09\x01\x30\x01\x38\x01\x37\x03\x09\x02\x38\x01"+
            "\x09\x01\x2f\x03\x09\x26\x38",
            "\x27\x38\x03\x09\x01\x38\x04\x09\x02\x38\x01\x09\x01\x2f\x03"+
            "\x09\x26\x38",
            "\x27\x38\x02\x09\x01\x30\x01\x38\x04\x09\x02\x38\x05\x09\x26"+
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
        "\x01\x5f\x01\x2b\x09\uffff\x01\x5f\x02\uffff";
    const string DFA33_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07\x01"+
        "\x08\x01\x0a\x01\x0b\x01\uffff\x01\x01\x01\x09";
    const string DFA33_specialS =
        "\x0e\uffff}>";
    static readonly string[] DFA33_transitionS = {
            "\x23\x0a\x01\x01\x01\x08\x01\x07\x0d\x0a\x01\uffff\x08\x0a"+
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
            "\x01\x0d\x42\uffff\x01\x0c",
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
        "\x01\x5f\x02\x2b\x08\uffff\x02\x5f\x04\uffff";
    const string DFA34_acceptS =
        "\x03\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07\x01"+
        "\x08\x01\x0b\x02\uffff\x01\x0c\x01\x0a\x01\x01\x01\x09";
    const string DFA34_specialS =
        "\x11\uffff}>";
    static readonly string[] DFA34_transitionS = {
            "\x23\x0a\x01\x02\x01\x09\x01\x08\x16\x0a\x01\x01\x01\x04\x01"+
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
            "\x01\x0e\x41\uffff\x02\x0d",
            "\x01\x10\x42\uffff\x01\x0f",
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
        "\x01\x5f\x01\x2b\x09\uffff\x01\x5f\x02\uffff";
    const string DFA35_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07\x01"+
        "\x08\x01\x0a\x01\x0b\x01\uffff\x01\x01\x01\x09";
    const string DFA35_specialS =
        "\x0e\uffff}>";
    static readonly string[] DFA35_transitionS = {
            "\x23\x0a\x01\x01\x01\x08\x01\x07\x01\x0a\x02\uffff\x0a\x0a"+
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
            "\x01\x0d\x42\uffff\x01\x0c",
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
        "\x01\x5f\x01\uffff\x01\x2b\x09\uffff\x01\x5f\x02\uffff";
    const string DFA36_acceptS =
        "\x01\uffff\x01\x0c\x01\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x01\x08\x01\x0a\x01\x0b\x01\uffff\x01\x01\x01\x09";
    const string DFA36_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA36_transitionS = {
            "\x23\x0b\x01\x02\x01\x09\x01\x08\x01\x0b\x01\uffff\x01\x01"+
            "\x13\x0b\x01\x0a\x01\x04\x01\x06\x01\x07\x02\x03\x01\x05\x07"+
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
            "\x01\x0e\x42\uffff\x01\x0d",
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
        "\x01\x5c\x04\uffff\x01\x00\x08\uffff";
    const string DFA43_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\uffff\x01\x05\x01"+
        "\x06\x01\x07\x01\x08\x01\uffff\x01\x09\x01\x0b\x01\x0a";
    const string DFA43_specialS =
        "\x01\x00\x04\uffff\x01\x01\x08\uffff}>";
    static readonly string[] DFA43_transitionS = {
            "\x01\x0c\x01\x02\x0d\uffff\x01\x0b\x01\uffff\x01\x02\x07\uffff"+
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
                   	if ( (LA43_0 == 55) ) { s = 1; }

                   	else if ( (LA43_0 == COMMAND || LA43_0 == 45 || LA43_0 == 59 || LA43_0 == 78) ) { s = 2; }

                   	else if ( (LA43_0 == 85) ) { s = 3; }

                   	else if ( ((LA43_0 >= 90 && LA43_0 <= 91)) && (synpred1_simpletikz()) ) { s = 4; }

                   	else if ( (LA43_0 == 53) ) { s = 5; }

                   	else if ( (LA43_0 == 92) ) { s = 6; }

                   	else if ( (LA43_0 == 81) ) { s = 7; }

                   	else if ( (LA43_0 == 80) ) { s = 8; }

                   	else if ( ((LA43_0 >= 83 && LA43_0 <= 84)) ) { s = 9; }

                   	else if ( (LA43_0 == 43) ) { s = 11; }

                   	else if ( (LA43_0 == ID || (LA43_0 >= 86 && LA43_0 <= 89)) ) { s = 12; }

                   	 
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
        "\x01\x5c\x03\x00\x0e\uffff";
    const string DFA48_acceptS =
        "\x04\uffff\x01\x04\x0a\uffff\x01\x01\x01\x02\x01\x03";
    const string DFA48_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x0e\uffff}>";
    static readonly string[] DFA48_transitionS = {
            "\x02\x04\x0d\uffff\x01\x04\x01\uffff\x01\x04\x07\uffff\x01"+
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
        "\x01\x5c\x03\x00\x11\uffff";
    const string DFA50_acceptS =
        "\x04\uffff\x01\x04\x0d\uffff\x01\x01\x01\x02\x01\x03";
    const string DFA50_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x11\uffff}>";
    static readonly string[] DFA50_transitionS = {
            "\x02\x04\x0d\uffff\x03\x04\x01\uffff\x01\x04\x05\uffff\x01"+
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
        "\x01\x1c\x01\x04\x01\uffff\x03\x04\x01\x00\x01\x04\x01\uffff\x01"+
        "\x04";
    const string DFA57_maxS =
        "\x01\x5c\x01\x5f\x01\uffff\x03\x5f\x01\x00\x01\x5f\x01\uffff\x01"+
        "\x5f";
    const string DFA57_acceptS =
        "\x02\uffff\x01\x02\x05\uffff\x01\x01\x01\uffff";
    const string DFA57_specialS =
        "\x06\uffff\x01\x00\x03\uffff}>";
    static readonly string[] DFA57_transitionS = {
            "\x02\x02\x0d\uffff\x03\x02\x01\uffff\x01\x02\x05\uffff\x01"+
            "\x01\x02\x02\x01\uffff\x01\x02\x01\uffff\x01\x02\x12\uffff\x01"+
            "\x02\x01\uffff\x02\x02\x01\uffff\x0a\x02",
            "\x1a\x02\x02\x03\x0c\x02\x01\uffff\x02\x02\x04\uffff\x05\x02"+
            "\x02\uffff\x26\x02",
            "",
            "\x27\x02\x02\uffff\x04\x02\x02\uffff\x02\x02\x01\uffff\x01"+
            "\x06\x03\uffff\x06\x04\x0f\x02\x01\x05\x10\x02",
            "\x27\x02\x02\uffff\x04\x02\x02\uffff\x02\x02\x01\uffff\x01"+
            "\x06\x03\uffff\x15\x02\x01\x05\x10\x02",
            "\x1a\x02\x02\x07\x0b\x02\x02\uffff\x04\x02\x02\uffff\x02\x02"+
            "\x01\uffff\x01\x02\x03\uffff\x26\x02",
            "\x01\uffff",
            "\x27\x02\x02\uffff\x04\x02\x02\uffff\x02\x02\x01\uffff\x01"+
            "\x06\x03\uffff\x06\x09\x20\x02",
            "",
            "\x27\x02\x02\uffff\x04\x02\x02\uffff\x02\x02\x01\uffff\x01"+
            "\x06\x03\uffff\x26\x02"
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
                   	int LA57_6 = input.LA(1);

                   	 
                   	int index57_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_simpletikz()) ) { s = 8; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index57_6);
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
        "\x01\x55\x01\x35\x01\x04\x01\uffff\x01\x04\x01\uffff\x0a\x04\x01"+
        "\uffff\x03\x04";
    const string DFA60_maxS =
        "\x01\x55\x01\x37\x01\x5f\x01\uffff\x01\x5f\x01\uffff\x0a\x5f\x01"+
        "\uffff\x03\x5f";
    const string DFA60_acceptS =
        "\x03\uffff\x01\x03\x01\uffff\x01\x02\x0a\uffff\x01\x01\x03\uffff";
    const string DFA60_specialS =
        "\x14\uffff}>";
    static readonly string[] DFA60_transitionS = {
            "\x01\x01",
            "\x01\x02\x01\uffff\x01\x03",
            "\x19\x05\x01\x06\x02\x04\x0c\x05\x02\uffff\x01\x05\x04\uffff"+
            "\x02\x05\x05\uffff\x26\x05",
            "",
            "\x27\x05\x02\uffff\x02\x05\x01\uffff\x01\x08\x02\uffff\x02"+
            "\x05\x05\uffff\x06\x07\x20\x05",
            "",
            "\x27\x05\x02\uffff\x02\x05\x01\uffff\x01\x08\x02\uffff\x02"+
            "\x05\x05\uffff\x26\x05",
            "\x27\x05\x02\uffff\x02\x05\x01\uffff\x01\x08\x02\uffff\x02"+
            "\x05\x05\uffff\x26\x05",
            "\x19\x05\x01\x0a\x02\x09\x0c\x05\x02\uffff\x01\x05\x04\uffff"+
            "\x02\x05\x05\uffff\x26\x05",
            "\x27\x05\x02\uffff\x02\x05\x01\uffff\x01\x0c\x02\uffff\x02"+
            "\x05\x05\uffff\x06\x0b\x20\x05",
            "\x27\x05\x02\uffff\x02\x05\x01\uffff\x01\x0c\x02\uffff\x02"+
            "\x05\x05\uffff\x26\x05",
            "\x27\x05\x02\uffff\x02\x05\x01\uffff\x01\x0c\x02\uffff\x02"+
            "\x05\x05\uffff\x26\x05",
            "\x19\x05\x01\x0e\x02\x0d\x0c\x05\x02\uffff\x01\x05\x04\uffff"+
            "\x02\x05\x05\uffff\x26\x05",
            "\x27\x05\x02\uffff\x02\x05\x04\uffff\x02\x05\x01\uffff\x01"+
            "\x10\x03\uffff\x06\x11\x0f\x05\x01\x0f\x10\x05",
            "\x27\x05\x02\uffff\x02\x05\x04\uffff\x02\x05\x01\uffff\x01"+
            "\x10\x03\uffff\x15\x05\x01\x0f\x10\x05",
            "\x1a\x05\x02\x12\x0b\x05\x02\uffff\x02\x05\x04\uffff\x02\x05"+
            "\x01\uffff\x01\x05\x03\uffff\x26\x05",
            "",
            "\x27\x05\x02\uffff\x02\x05\x04\uffff\x02\x05\x01\uffff\x01"+
            "\x10\x03\uffff\x15\x05\x01\x0f\x10\x05",
            "\x27\x05\x02\uffff\x02\x05\x04\uffff\x02\x05\x01\uffff\x01"+
            "\x10\x03\uffff\x06\x13\x20\x05",
            "\x27\x05\x02\uffff\x02\x05\x04\uffff\x02\x05\x01\uffff\x01"+
            "\x10\x03\uffff\x26\x05"
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
        "\x02\x35\x01\x04\x01\uffff\x02\x04\x02\uffff\x04\x04\x01\uffff";
    const string DFA67_maxS =
        "\x01\x5b\x01\x35\x01\x5f\x01\uffff\x02\x5f\x02\uffff\x04\x5f\x01"+
        "\uffff";
    const string DFA67_acceptS =
        "\x03\uffff\x01\x04\x02\uffff\x01\x03\x01\x01\x04\uffff\x01\x02";
    const string DFA67_specialS =
        "\x0d\uffff}>";
    static readonly string[] DFA67_transitionS = {
            "\x01\x02\x24\uffff\x02\x01",
            "\x01\x02",
            "\x1a\x05\x02\x04\x0b\x05\x01\x06\x02\uffff\x01\x05\x04\uffff"+
            "\x02\x05\x01\uffff\x01\x03\x01\x07\x02\uffff\x26\x05",
            "",
            "\x27\x05\x02\uffff\x01\x06\x01\x05\x02\x09\x02\uffff\x02\x05"+
            "\x01\uffff\x01\x07\x03\uffff\x06\x08\x20\x05",
            "\x27\x05\x02\uffff\x01\x06\x01\x05\x02\x06\x02\uffff\x02\x05"+
            "\x01\uffff\x01\x07\x03\uffff\x26\x05",
            "",
            "",
            "\x27\x05\x02\uffff\x01\x06\x01\x05\x02\x09\x02\uffff\x02\x05"+
            "\x01\uffff\x01\x07\x03\uffff\x26\x05",
            "\x1a\x06\x02\x0a\x0c\x06\x02\uffff\x01\x06\x04\uffff\x02\x06"+
            "\x05\uffff\x26\x06",
            "\x27\x06\x02\uffff\x02\x06\x04\uffff\x02\x06\x01\uffff\x01"+
            "\x0c\x03\uffff\x06\x0b\x20\x06",
            "\x27\x06\x02\uffff\x02\x06\x04\uffff\x02\x06\x01\uffff\x01"+
            "\x0c\x03\uffff\x26\x06",
            ""
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
        "\x01\x35\x01\x04\x01\x35\x01\x04\x01\uffff\x02\x04\x01\uffff\x06"+
        "\x04\x01\uffff";
    const string DFA70_maxS =
        "\x01\x5b\x01\x5f\x01\x35\x01\x5f\x01\uffff\x02\x5f\x01\uffff\x06"+
        "\x5f\x01\uffff";
    const string DFA70_acceptS =
        "\x04\uffff\x01\x03\x02\uffff\x01\x01\x06\uffff\x01\x02";
    const string DFA70_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA70_transitionS = {
            "\x01\x01\x24\uffff\x02\x02",
            "\x1a\x05\x02\x03\x0b\x05\x01\x04\x02\uffff\x01\x05\x04\uffff"+
            "\x02\x05\x05\uffff\x26\x05",
            "\x01\x06",
            "\x27\x05\x02\uffff\x01\x04\x01\x05\x02\x09\x02\uffff\x02\x05"+
            "\x01\uffff\x01\x07\x03\uffff\x06\x08\x20\x05",
            "",
            "\x27\x05\x02\uffff\x01\x04\x01\x05\x02\x04\x02\uffff\x02\x05"+
            "\x01\uffff\x01\x07\x03\uffff\x26\x05",
            "\x1a\x04\x02\x0a\x0c\x04\x02\uffff\x01\x04\x04\uffff\x02\x04"+
            "\x05\uffff\x26\x04",
            "",
            "\x27\x05\x02\uffff\x01\x04\x01\x05\x02\x09\x02\uffff\x02\x05"+
            "\x01\uffff\x01\x07\x03\uffff\x26\x05",
            "\x1a\x04\x02\x0b\x0c\x04\x02\uffff\x01\x04\x04\uffff\x02\x04"+
            "\x05\uffff\x26\x04",
            "\x27\x04\x02\uffff\x02\x04\x02\x09\x02\uffff\x02\x04\x05\uffff"+
            "\x06\x0c\x20\x04",
            "\x27\x04\x02\uffff\x02\x04\x04\uffff\x02\x04\x01\uffff\x01"+
            "\x0e\x03\uffff\x06\x0d\x20\x04",
            "\x27\x04\x02\uffff\x02\x04\x02\x09\x02\uffff\x02\x04\x05\uffff"+
            "\x26\x04",
            "\x27\x04\x02\uffff\x02\x04\x04\uffff\x02\x04\x01\uffff\x01"+
            "\x0e\x03\uffff\x26\x04",
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
        "\x02\x5f\x02\uffff\x01\x5f\x01\uffff\x02\x5f";
    const string DFA73_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\uffff\x01\x01\x02\uffff";
    const string DFA73_specialS =
        "\x08\uffff}>";
    static readonly string[] DFA73_transitionS = {
            "\x27\x01\x01\x02\x02\uffff\x01\x01\x04\uffff\x02\x01\x05\uffff"+
            "\x26\x01",
            "\x27\x01\x02\uffff\x01\x03\x01\x01\x02\x05\x02\uffff\x02\x01"+
            "\x01\uffff\x01\x05\x03\uffff\x15\x01\x01\x04\x10\x01",
            "",
            "",
            "\x1a\x01\x02\x06\x0b\x01\x02\uffff\x01\x03\x01\x01\x02\x05"+
            "\x02\uffff\x02\x01\x01\uffff\x01\x05\x03\uffff\x15\x01\x01\x04"+
            "\x10\x01",
            "",
            "\x27\x01\x02\uffff\x01\x03\x01\x01\x02\x05\x02\uffff\x02\x01"+
            "\x01\uffff\x01\x05\x03\uffff\x06\x07\x0f\x01\x01\x04\x10\x01",
            "\x27\x01\x02\uffff\x01\x03\x01\x01\x02\x05\x02\uffff\x02\x01"+
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

 

    public static readonly BitSet FOLLOW_dontcare_preamble_in_tikzdocument257 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_styleorsetorcmd_in_tikzdocument261 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzdocument265 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpicture_in_tikzdocument270 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_dontcare_preamble_in_tikzdocument_wo_tikzpicture296 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_styleorsetorcmd_in_tikzdocument_wo_tikzpicture300 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzdocument_wo_tikzpicture304 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
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
    public static readonly BitSet FOLLOW_43_in_tikz_style420 = new BitSet(new ulong[]{0xFC1847FFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_idd_in_tikz_style422 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_tikz_style424 = new BitSet(new ulong[]{0x0000600000000000UL});
    public static readonly BitSet FOLLOW_45_in_tikz_style427 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_46_in_tikz_style431 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikz_style434 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_squarebr_start_in_tikz_options456 = new BitSet(new ulong[]{0xFD184FFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_options459 = new BitSet(new ulong[]{0xFD18CFFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_47_in_tikz_options462 = new BitSet(new ulong[]{0xFC1847FFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_options464 = new BitSet(new ulong[]{0xFD18CFFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_47_in_tikz_options468 = new BitSet(new ulong[]{0xFD184FFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikz_options473 = new BitSet(new ulong[]{0xFD184FFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_squarebr_end_in_tikz_options476 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_option_style_in_option501 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_option_kv_in_option510 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_option_kv524 = new BitSet(new ulong[]{0x0000200000000002UL});
    public static readonly BitSet FOLLOW_45_in_option_kv527 = new BitSet(new ulong[]{0xFC184FFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_iddornumberunitorstringorrange_in_option_kv529 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_tikzstring557 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_no_rlbrace_in_tikzstring559 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikzstring563 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_no_rlbrace_in_tikzstring565 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_44_in_tikzstring570 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_no_rlbrace593 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_range_in_iddornumberunitorstringorrange611 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_numberunit_in_iddornumberunitorstringorrange615 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_bracedcoord_in_iddornumberunitorstringorrange619 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_iddornumberunitorstringorrange623 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_number_in_iddornumberunitorstringorrange630 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_iddornumberunitorstringorrange633 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_tikzstring_in_iddornumberunitorstringorrange638 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_bracedcoord652 = new BitSet(new ulong[]{0x0020000000000000UL,0x000000000C000000UL});
    public static readonly BitSet FOLLOW_coord_nooption_in_bracedcoord656 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_bracedcoord658 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_numberunit_in_range669 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_range671 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_range673 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_option_style697 = new BitSet(new ulong[]{0x0006000000000000UL});
    public static readonly BitSet FOLLOW_49_in_option_style700 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_50_in_option_style705 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_option_style707 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_49_in_option_style714 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_number_in_option_style716 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_option_style718 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_option_style722 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_option_style724 = new BitSet(new ulong[]{0xFC18D7FFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_option_kv_in_option_style727 = new BitSet(new ulong[]{0x0000900000000000UL});
    public static readonly BitSet FOLLOW_47_in_option_style730 = new BitSet(new ulong[]{0xFC1847FFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_option_kv_in_option_style732 = new BitSet(new ulong[]{0x0000900000000000UL});
    public static readonly BitSet FOLLOW_47_in_option_style739 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_option_style742 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_heavenknowswhythisisnecessary_in_idd777 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_idd_heavenknowswhythisisnecessary797 = new BitSet(new ulong[]{0xFC1847FFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_ID_in_idd2857 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_numberunit_in_numberunitorvariable876 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COMMAND_in_numberunitorvariable881 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_number_in_numberunit894 = new BitSet(new ulong[]{0xFC00000000000002UL});
    public static readonly BitSet FOLLOW_unit_in_numberunit896 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_number922 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unit0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_set_start_in_tikz_set977 = new BitSet(new ulong[]{0xFC1857FFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_set980 = new BitSet(new ulong[]{0xFC18D7FFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_47_in_tikz_set983 = new BitSet(new ulong[]{0xFC1847FFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_set985 = new BitSet(new ulong[]{0xFC18D7FFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_47_in_tikz_set989 = new BitSet(new ulong[]{0xFC1857FFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_roundbr_end_in_tikz_set994 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzpicture_start_in_tikzpicture1026 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpicture1028 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzpicture1031 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpicture_end_in_tikzpicture1034 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_start_in_tikzpicture1059 = new BitSet(new ulong[]{0x0080080000000000UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpicture1062 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikzpicture1065 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzbody2_in_tikzpicture1067 = new BitSet(new ulong[]{0xFC1857FFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_roundbr_end_in_tikzpicture1070 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody1102 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody1106 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_ext_in_tikzbody1110 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzdef_ext_in_tikzbody1114 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzmatrix_ext_in_tikzbody1118 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzcoordinate_ext_in_tikzbody1122 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody1126 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody1130 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody1134 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody1139 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_dontcare_body_nobr_in_tikzbody1144 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody1155 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody1159 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_ext_in_tikzbody1163 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzdef_ext_in_tikzbody1167 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzmatrix_ext_in_tikzbody1171 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzcoordinate_ext_in_tikzbody1175 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody1179 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody1183 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody1187 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody1192 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_dontcare_body_in_tikzbody1197 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody21213 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody21217 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_ext_in_tikzbody21221 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzdef_ext_in_tikzbody21225 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzmatrix_ext_in_tikzbody21229 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzcoordinate_ext_in_tikzbody21233 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody21237 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody21241 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody21245 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody21250 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_dontcare_body_nobr2_in_tikzbody21255 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody21266 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody21270 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_ext_in_tikzbody21274 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzdef_ext_in_tikzbody21278 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzmatrix_ext_in_tikzbody21282 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzcoordinate_ext_in_tikzbody21286 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody21290 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody21294 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody21298 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody21303 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_dontcare_body2_in_tikzbody21308 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body_nobr21325 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body21419 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body_nobr1509 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body1596 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_64_in_otherend1679 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_otherend1681 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_idd2_in_otherend1683 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_otherend1685 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzscope_start_in_tikzscope1712 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzscope1714 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzscope1717 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzscope_end_in_tikzscope1720 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_in_tikzpath1776 = new BitSet(new ulong[]{0x0AA0280030000000UL,0x000000001FFB4000UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath1778 = new BitSet(new ulong[]{0x0AA0280030000000UL,0x000000001FFB4000UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzpath1781 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_let_cmd_parts0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzpath_element_single_in_tikzpath_element1837 = new BitSet(new ulong[]{0x0000800000000002UL});
    public static readonly BitSet FOLLOW_47_in_tikzpath_element1839 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpath_element_single1857 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_let_cmd_parts_in_tikzpath_element_single1864 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arc_in_tikzpath_element_single1882 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_in_tikzpath_element_single1892 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_controls_in_tikzpath_element_single1898 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_int_in_tikzpath_element_single1904 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_int_in_tikzpath_element_single1910 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_circle_in_tikzpath_element_single1916 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_roundbr_start_in_tikzpath_element_single1923 = new BitSet(new ulong[]{0xFCB87FFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath_element_single1925 = new BitSet(new ulong[]{0xFCB87FFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_roundbr_end_in_tikzpath_element_single1928 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_53_in_tikzpath_element_single1948 = new BitSet(new ulong[]{0x08E0280030000000UL,0x000000001FFB4000UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath_element_single1950 = new BitSet(new ulong[]{0x08E0280030000000UL,0x000000001FFB4000UL});
    public static readonly BitSet FOLLOW_54_in_tikzpath_element_single1953 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_edgeop_in_tikzpath_element_single1972 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_controls_start_in_controls1987 = new BitSet(new ulong[]{0x0020000000000000UL,0x000000000C000000UL});
    public static readonly BitSet FOLLOW_coord_in_controls1989 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000010008000UL});
    public static readonly BitSet FOLLOW_79_in_controls1992 = new BitSet(new ulong[]{0x0020000000000000UL,0x000000000C000000UL});
    public static readonly BitSet FOLLOW_coord_in_controls1994 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000010008000UL});
    public static readonly BitSet FOLLOW_controls_end_in_controls1998 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_node_start_in_tikznode_ext2024 = new BitSet(new ulong[]{0x00A0080000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_tikznode_core_in_tikznode_ext2026 = new BitSet(new ulong[]{0x0AA0280030000000UL,0x000000001FFB4000UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikznode_ext2028 = new BitSet(new ulong[]{0x0AA0280030000000UL,0x000000001FFB4000UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikznode_ext2031 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_def_start_in_tikzdef_ext2056 = new BitSet(new ulong[]{0x0AA0280030000000UL,0x000000001FFB4000UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzdef_ext2058 = new BitSet(new ulong[]{0x0AA0280030000000UL,0x000000001FFB4000UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzdef_ext2061 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrix_start_in_tikzmatrix_ext2086 = new BitSet(new ulong[]{0x00A0080000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_tikznode_core_in_tikzmatrix_ext2088 = new BitSet(new ulong[]{0x0AA0280030000000UL,0x000000001FFB4000UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzmatrix_ext2090 = new BitSet(new ulong[]{0x0AA0280030000000UL,0x000000001FFB4000UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzmatrix_ext2093 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coordinate_start_in_tikzcoordinate_ext2121 = new BitSet(new ulong[]{0x0AA0280030000000UL,0x000000001FFF4000UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_ext2136 = new BitSet(new ulong[]{0x0AA0280030000000UL,0x000000001FFB4000UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_ext2155 = new BitSet(new ulong[]{0x0AA0280030000000UL,0x000000001FFB4000UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_ext2175 = new BitSet(new ulong[]{0x0AA0280030000000UL,0x000000001FFB4000UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzcoordinate_ext2186 = new BitSet(new ulong[]{0x0AA0280030000000UL,0x000000001FFB4000UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzcoordinate_ext2189 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_80_in_tikzcoordinate_int2249 = new BitSet(new ulong[]{0x00A0000000000002UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_int2260 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_int2279 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_int2299 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_81_in_tikznode_int2315 = new BitSet(new ulong[]{0x00A0080000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_tikznode_core_in_tikznode_int2318 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikznode_core2328 = new BitSet(new ulong[]{0x00A0080000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikznode_core2331 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core32356 = new BitSet(new ulong[]{0x00A0000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core32358 = new BitSet(new ulong[]{0x00A0000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core32360 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core22394 = new BitSet(new ulong[]{0x00A0000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core22396 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core12429 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_tikznode_decorator2466 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_82_in_tikznode_decorator2473 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_COMMAND_in_tikznode_decorator2476 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_82_in_tikznode_decorator2482 = new BitSet(new ulong[]{0x0020000000000000UL,0x000000000C000000UL});
    public static readonly BitSet FOLLOW_coord_in_tikznode_decorator2485 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_options_dontcare_in_tikznode_decorator2491 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_tikz_options_dontcare2501 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_no_rlbracket_in_tikz_options_dontcare2503 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_options_dontcare_in_tikz_options_dontcare2507 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_no_rlbracket_in_tikz_options_dontcare2509 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_56_in_tikz_options_dontcare2514 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_no_rlbracket2532 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_53_in_nodename2549 = new BitSet(new ulong[]{0xFC1847FFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_idd_in_nodename2551 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_nodename2553 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_83_in_circle2578 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_84_in_circle2582 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_size_in_circle2591 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_85_in_arc2606 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_arc2609 = new BitSet(new ulong[]{0x00000000E0000000UL});
    public static readonly BitSet FOLLOW_numberunitorvariable_in_arc2611 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_arc2613 = new BitSet(new ulong[]{0x00000000E0000000UL});
    public static readonly BitSet FOLLOW_numberunitorvariable_in_arc2615 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_arc2617 = new BitSet(new ulong[]{0x00000000E0000000UL});
    public static readonly BitSet FOLLOW_numberunitorvariable_in_arc2619 = new BitSet(new ulong[]{0x0040000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_79_in_arc2622 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_arc2624 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_arc2628 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_85_in_arc2646 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_arc2649 = new BitSet(new ulong[]{0xFC184FFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_arc2651 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_arc2653 = new BitSet(new ulong[]{0xFC184FFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_arc2655 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_arc2657 = new BitSet(new ulong[]{0xFC184FFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_arc2659 = new BitSet(new ulong[]{0x0040000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_79_in_arc2662 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_arc2664 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_arc2668 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_85_in_arc2686 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_tikz_options_in_arc2688 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_53_in_size2713 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_size2715 = new BitSet(new ulong[]{0x0040000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_79_in_size2718 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_size2720 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_size2724 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_53_in_coord_nodename2752 = new BitSet(new ulong[]{0xFC9847FFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_options_in_coord_nodename2754 = new BitSet(new ulong[]{0xFC1847FFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_idd_in_coord_nodename2757 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_coord_nodename2760 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord2786 = new BitSet(new ulong[]{0x0020000000000000UL,0x000000000C000000UL});
    public static readonly BitSet FOLLOW_coord_nodename_in_coord2789 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord2815 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_coord2818 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord2820 = new BitSet(new ulong[]{0x0001800000000000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord2822 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord2824 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_coord2826 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord2850 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_coord2853 = new BitSet(new ulong[]{0xFC184FFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_coord2855 = new BitSet(new ulong[]{0x0001800000000000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord2857 = new BitSet(new ulong[]{0xFC184FFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_coord2859 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_coord2861 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord2885 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_coord2888 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_coord2890 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_coord_nooption2918 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord_nooption2942 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_coord_nooption2945 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord_nooption2947 = new BitSet(new ulong[]{0x0001800000000000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord_nooption2949 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord_nooption2951 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_coord_nooption2953 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord_nooption2977 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_coord_nooption2980 = new BitSet(new ulong[]{0xFC184FFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_coord_nooption2982 = new BitSet(new ulong[]{0x0001800000000000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord_nooption2984 = new BitSet(new ulong[]{0xFC184FFFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_coord_nooption2986 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_coord_nooption2988 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_coord_part3021 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_coord_part3036 = new BitSet(new ulong[]{0xFC1847FFFFFFFFF0UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_idd_in_coord_part3038 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_coord_part3040 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_coord_part3058 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_coord_part3060 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord_part3062 = new BitSet(new ulong[]{0xFC18C7FFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_47_in_coord_part3064 = new BitSet(new ulong[]{0xFC1847FFFFFFFFF2UL,0x00000000FFFFFFFFUL});
    public static readonly BitSet FOLLOW_set_in_coord_sep3096 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_edgeop0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_coord_modifier0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_squarebr_start3170 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_squarebr_end3188 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_57_in_semicolon_end3207 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_roundbr_start3225 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_44_in_roundbr_end3243 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_92_in_controls_start3261 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000020000000UL});
    public static readonly BitSet FOLLOW_93_in_controls_start3263 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_92_in_controls_end3281 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_41_in_tikz_set_start3299 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikz_set_start3301 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_tikzpicture_start3320 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikzpicture_start3322 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000040000000UL});
    public static readonly BitSet FOLLOW_94_in_tikzpicture_start3324 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_tikzpicture_start3326 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_42_in_tikz_start3344 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_64_in_tikzpicture_end3362 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikzpicture_end3364 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000040000000UL});
    public static readonly BitSet FOLLOW_94_in_tikzpicture_end3366 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_tikzpicture_end3368 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_tikzscope_start3386 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikzscope_start3388 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000080000000UL});
    public static readonly BitSet FOLLOW_95_in_tikzscope_start3390 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_tikzscope_start3392 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_64_in_tikzscope_end3410 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikzscope_end3412 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000080000000UL});
    public static readonly BitSet FOLLOW_95_in_tikzscope_end3414 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_tikzscope_end3416 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_tag_in_path_start3435 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_node_start_tag_in_node_start3453 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_def_start_tag_in_def_start3471 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrix_start_tag_in_matrix_start3489 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_65_in_node_start_tag3507 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_70_in_def_start_tag3517 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_66_in_matrix_start_tag3527 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_67_in_coordinate_start3537 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_path_start_tag0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_in_synpred1_simpletikz1889 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_synpred2_simpletikz2132 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_synpred3_simpletikz2151 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_synpred4_simpletikz2171 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_synpred5_simpletikz2256 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_synpred6_simpletikz2275 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_synpred7_simpletikz2295 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_size_in_synpred8_simpletikz2587 = new BitSet(new ulong[]{0x0000000000000002UL});

}
