// $ANTLR 3.1.1 E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g 2016-09-21 15:48:41

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
		"'n'", 
		"'args'", 
		"'2'", 
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
    public const int T__96 = 96;
    public const int IM_COORD = 6;
    public const int T__97 = 97;
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
            	    case 96:
            	    case 97:
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

            	    if ( ((LA2_0 >= IM_PATH && LA2_0 <= 97)) )
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
            	    case 96:
            	    case 97:
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
            	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= IM_ARC) || (input.LA(1) >= ID && input.LA(1) <= SOMETHING1) || (input.LA(1) >= 43 && input.LA(1) <= 97) ) 
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

            	if ( ((LA8_0 >= IM_PATH && LA8_0 <= 42) || LA8_0 == 46 || (LA8_0 >= 51 && LA8_0 <= 54) || (LA8_0 >= 60 && LA8_0 <= 97)) )
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

            	        	        if ( ((LA6_1 >= IM_PATH && LA6_1 <= 42) || LA6_1 == 46 || (LA6_1 >= 51 && LA6_1 <= 54) || (LA6_1 >= 60 && LA6_1 <= 97)) )
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
            	// elements:          squarebr_start, option, squarebr_end
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

            	    if ( ((LA12_0 >= IM_PATH && LA12_0 <= 42) || (LA12_0 >= 45 && LA12_0 <= 97)) )
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

            			    	    if ( ((LA13_0 >= IM_PATH && LA13_0 <= 42) || (LA13_0 >= 45 && LA13_0 <= 97)) )
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
            	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= 42) || (input.LA(1) >= 45 && input.LA(1) <= 97) ) 
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
    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:196:1: option_style : idd ( '/.style' | ( '/.append' 'style' ) ) ( ( ( 'n' 'args' )=> ( 'n' 'args' ) '=' '{' number '}' ) | ( '2' 'args' )? '=' ) '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}' -> ^( IM_OPTION_STYLE idd ( option_kv )* ) ;
    public simpletikzParser.option_style_return option_style() // throws RecognitionException [1]
    {   
        simpletikzParser.option_style_return retval = new simpletikzParser.option_style_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal58 = null;
        IToken string_literal59 = null;
        IToken string_literal60 = null;
        IToken char_literal61 = null;
        IToken string_literal62 = null;
        IToken char_literal63 = null;
        IToken char_literal64 = null;
        IToken char_literal66 = null;
        IToken char_literal67 = null;
        IToken string_literal68 = null;
        IToken char_literal69 = null;
        IToken char_literal70 = null;
        IToken char_literal72 = null;
        IToken char_literal74 = null;
        IToken char_literal75 = null;
        simpletikzParser.idd_return idd57 = default(simpletikzParser.idd_return);

        simpletikzParser.number_return number65 = default(simpletikzParser.number_return);

        simpletikzParser.option_kv_return option_kv71 = default(simpletikzParser.option_kv_return);

        simpletikzParser.option_kv_return option_kv73 = default(simpletikzParser.option_kv_return);


        object string_literal58_tree=null;
        object string_literal59_tree=null;
        object string_literal60_tree=null;
        object char_literal61_tree=null;
        object string_literal62_tree=null;
        object char_literal63_tree=null;
        object char_literal64_tree=null;
        object char_literal66_tree=null;
        object char_literal67_tree=null;
        object string_literal68_tree=null;
        object char_literal69_tree=null;
        object char_literal70_tree=null;
        object char_literal72_tree=null;
        object char_literal74_tree=null;
        object char_literal75_tree=null;
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_47 = new RewriteRuleTokenStream(adaptor,"token 47");
        RewriteRuleTokenStream stream_49 = new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleSubtreeStream stream_number = new RewriteRuleSubtreeStream(adaptor,"rule number");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_option_kv = new RewriteRuleSubtreeStream(adaptor,"rule option_kv");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:2: ( idd ( '/.style' | ( '/.append' 'style' ) ) ( ( ( 'n' 'args' )=> ( 'n' 'args' ) '=' '{' number '}' ) | ( '2' 'args' )? '=' ) '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}' -> ^( IM_OPTION_STYLE idd ( option_kv )* ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:4: idd ( '/.style' | ( '/.append' 'style' ) ) ( ( ( 'n' 'args' )=> ( 'n' 'args' ) '=' '{' number '}' ) | ( '2' 'args' )? '=' ) '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}'
            {
            	PushFollow(FOLLOW_idd_in_option_style697);
            	idd57 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_idd.Add(idd57.Tree);
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:8: ( '/.style' | ( '/.append' 'style' ) )
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

            	}

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:44: ( ( ( 'n' 'args' )=> ( 'n' 'args' ) '=' '{' number '}' ) | ( '2' 'args' )? '=' )
            	int alt19 = 2;
            	int LA19_0 = input.LA(1);

            	if ( (LA19_0 == 52) && (synpred1_simpletikz()) )
            	{
            	    alt19 = 1;
            	}
            	else if ( (LA19_0 == 45 || LA19_0 == 54) )
            	{
            	    alt19 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d19s0 =
            	        new NoViableAltException("", 19, 0, input);

            	    throw nvae_d19s0;
            	}
            	switch (alt19) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:45: ( ( 'n' 'args' )=> ( 'n' 'args' ) '=' '{' number '}' )
            	        {
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:45: ( ( 'n' 'args' )=> ( 'n' 'args' ) '=' '{' number '}' )
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:46: ( 'n' 'args' )=> ( 'n' 'args' ) '=' '{' number '}'
            	        	{
            	        		// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:61: ( 'n' 'args' )
            	        		// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:62: 'n' 'args'
            	        		{
            	        			char_literal61=(IToken)Match(input,52,FOLLOW_52_in_option_style722); if (state.failed) return retval; 
            	        			if ( state.backtracking==0 ) stream_52.Add(char_literal61);

            	        			string_literal62=(IToken)Match(input,53,FOLLOW_53_in_option_style724); if (state.failed) return retval; 
            	        			if ( state.backtracking==0 ) stream_53.Add(string_literal62);


            	        		}

            	        		char_literal63=(IToken)Match(input,45,FOLLOW_45_in_option_style727); if (state.failed) return retval; 
            	        		if ( state.backtracking==0 ) stream_45.Add(char_literal63);

            	        		char_literal64=(IToken)Match(input,43,FOLLOW_43_in_option_style729); if (state.failed) return retval; 
            	        		if ( state.backtracking==0 ) stream_43.Add(char_literal64);

            	        		PushFollow(FOLLOW_number_in_option_style731);
            	        		number65 = number();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking==0 ) stream_number.Add(number65.Tree);
            	        		char_literal66=(IToken)Match(input,44,FOLLOW_44_in_option_style733); if (state.failed) return retval; 
            	        		if ( state.backtracking==0 ) stream_44.Add(char_literal66);


            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:97: ( '2' 'args' )? '='
            	        {
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:97: ( '2' 'args' )?
            	        	int alt18 = 2;
            	        	int LA18_0 = input.LA(1);

            	        	if ( (LA18_0 == 54) )
            	        	{
            	        	    alt18 = 1;
            	        	}
            	        	switch (alt18) 
            	        	{
            	        	    case 1 :
            	        	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:98: '2' 'args'
            	        	        {
            	        	        	char_literal67=(IToken)Match(input,54,FOLLOW_54_in_option_style740); if (state.failed) return retval; 
            	        	        	if ( state.backtracking==0 ) stream_54.Add(char_literal67);

            	        	        	string_literal68=(IToken)Match(input,53,FOLLOW_53_in_option_style742); if (state.failed) return retval; 
            	        	        	if ( state.backtracking==0 ) stream_53.Add(string_literal68);


            	        	        }
            	        	        break;

            	        	}

            	        	char_literal69=(IToken)Match(input,45,FOLLOW_45_in_option_style746); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_45.Add(char_literal69);


            	        }
            	        break;

            	}

            	char_literal70=(IToken)Match(input,43,FOLLOW_43_in_option_style749); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_43.Add(char_literal70);

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:120: ( option_kv ( ',' option_kv )* )?
            	int alt21 = 2;
            	int LA21_0 = input.LA(1);

            	if ( ((LA21_0 >= IM_PATH && LA21_0 <= 42) || LA21_0 == 46 || (LA21_0 >= 51 && LA21_0 <= 54) || (LA21_0 >= 60 && LA21_0 <= 97)) )
            	{
            	    alt21 = 1;
            	}
            	switch (alt21) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:121: option_kv ( ',' option_kv )*
            	        {
            	        	PushFollow(FOLLOW_option_kv_in_option_style752);
            	        	option_kv71 = option_kv();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_option_kv.Add(option_kv71.Tree);
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:131: ( ',' option_kv )*
            	        	do 
            	        	{
            	        	    int alt20 = 2;
            	        	    int LA20_0 = input.LA(1);

            	        	    if ( (LA20_0 == 47) )
            	        	    {
            	        	        int LA20_1 = input.LA(2);

            	        	        if ( ((LA20_1 >= IM_PATH && LA20_1 <= 42) || LA20_1 == 46 || (LA20_1 >= 51 && LA20_1 <= 54) || (LA20_1 >= 60 && LA20_1 <= 97)) )
            	        	        {
            	        	            alt20 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt20) 
            	        		{
            	        			case 1 :
            	        			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:132: ',' option_kv
            	        			    {
            	        			    	char_literal72=(IToken)Match(input,47,FOLLOW_47_in_option_style755); if (state.failed) return retval; 
            	        			    	if ( state.backtracking==0 ) stream_47.Add(char_literal72);

            	        			    	PushFollow(FOLLOW_option_kv_in_option_style757);
            	        			    	option_kv73 = option_kv();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking==0 ) stream_option_kv.Add(option_kv73.Tree);

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

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:151: ( ',' )?
            	int alt22 = 2;
            	int LA22_0 = input.LA(1);

            	if ( (LA22_0 == 47) )
            	{
            	    alt22 = 1;
            	}
            	switch (alt22) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:151: ','
            	        {
            	        	char_literal74=(IToken)Match(input,47,FOLLOW_47_in_option_style764); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_47.Add(char_literal74);


            	        }
            	        break;

            	}

            	char_literal75=(IToken)Match(input,44,FOLLOW_44_in_option_style767); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_44.Add(char_literal75);



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
            	// 197:161: -> ^( IM_OPTION_STYLE idd ( option_kv )* )
            	{
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:164: ^( IM_OPTION_STYLE idd ( option_kv )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTION_STYLE, "IM_OPTION_STYLE"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:186: ( option_kv )*
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

        simpletikzParser.idd_heavenknowswhythisisnecessary_return idd_heavenknowswhythisisnecessary76 = default(simpletikzParser.idd_heavenknowswhythisisnecessary_return);


        RewriteRuleSubtreeStream stream_idd_heavenknowswhythisisnecessary = new RewriteRuleSubtreeStream(adaptor,"rule idd_heavenknowswhythisisnecessary");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:210:2: ( idd_heavenknowswhythisisnecessary -> ^( IM_ID ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:210:4: idd_heavenknowswhythisisnecessary
            {
            	PushFollow(FOLLOW_idd_heavenknowswhythisisnecessary_in_idd802);
            	idd_heavenknowswhythisisnecessary76 = idd_heavenknowswhythisisnecessary();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_idd_heavenknowswhythisisnecessary.Add(idd_heavenknowswhythisisnecessary76.Tree);


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

        IToken set77 = null;

        object set77_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:213:3: ( (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' ) )+ )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:213:6: (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' ) )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:213:6: (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' ) )+
            	int cnt23 = 0;
            	do 
            	{
            	    int alt23 = 2;
            	    int LA23_0 = input.LA(1);

            	    if ( (LA23_0 == 81) )
            	    {
            	        int LA23_2 = input.LA(2);

            	        if ( ((LA23_2 >= IM_PATH && LA23_2 <= COMMAND) || (LA23_2 >= WS && LA23_2 <= 54) || LA23_2 == 56 || LA23_2 == 58 || (LA23_2 >= 60 && LA23_2 <= 97)) )
            	        {
            	            alt23 = 1;
            	        }
            	        else if ( ((LA23_2 >= FLOAT_WO_EXP && LA23_2 <= INT)) )
            	        {
            	            alt23 = 1;
            	        }


            	    }
            	    else if ( ((LA23_0 >= IM_PATH && LA23_0 <= 42) || LA23_0 == 46 || (LA23_0 >= 51 && LA23_0 <= 54) || (LA23_0 >= 60 && LA23_0 <= 80) || (LA23_0 >= 82 && LA23_0 <= 97)) )
            	    {
            	        alt23 = 1;
            	    }


            	    switch (alt23) 
            		{
            			case 1 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:213:6: ~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' )
            			    {
            			    	set77 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= 42) || input.LA(1) == 46 || (input.LA(1) >= 51 && input.LA(1) <= 54) || (input.LA(1) >= 60 && input.LA(1) <= 97) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set77));
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
            			    if ( cnt23 >= 1 ) goto loop23;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee =
            		                new EarlyExitException(23, input);
            		            throw eee;
            	    }
            	    cnt23++;
            	} while (true);

            	loop23:
            		;	// Stops C# compiler whinging that label 'loop23' has no statements


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

        IToken ID78 = null;

        object ID78_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:215:2: ( ( ID )+ -> ^( IM_ID ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:215:4: ( ID )+
            {
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:215:4: ( ID )+
            	int cnt24 = 0;
            	do 
            	{
            	    int alt24 = 2;
            	    int LA24_0 = input.LA(1);

            	    if ( (LA24_0 == ID) )
            	    {
            	        alt24 = 1;
            	    }


            	    switch (alt24) 
            		{
            			case 1 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:215:4: ID
            			    {
            			    	ID78=(IToken)Match(input,ID,FOLLOW_ID_in_idd2882); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_ID.Add(ID78);


            			    }
            			    break;

            			default:
            			    if ( cnt24 >= 1 ) goto loop24;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee =
            		                new EarlyExitException(24, input);
            		            throw eee;
            	    }
            	    cnt24++;
            	} while (true);

            	loop24:
            		;	// Stops C# compiler whinging that label 'loop24' has no statements



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

        IToken COMMAND80 = null;
        simpletikzParser.numberunit_return numberunit79 = default(simpletikzParser.numberunit_return);


        object COMMAND80_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:219:2: ( numberunit | COMMAND )
            int alt25 = 2;
            int LA25_0 = input.LA(1);

            if ( ((LA25_0 >= FLOAT_WO_EXP && LA25_0 <= INT)) )
            {
                alt25 = 1;
            }
            else if ( (LA25_0 == COMMAND) )
            {
                alt25 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d25s0 =
                    new NoViableAltException("", 25, 0, input);

                throw nvae_d25s0;
            }
            switch (alt25) 
            {
                case 1 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:219:4: numberunit
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_numberunit_in_numberunitorvariable901);
                    	numberunit79 = numberunit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, numberunit79.Tree);

                    }
                    break;
                case 2 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:220:4: COMMAND
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	COMMAND80=(IToken)Match(input,COMMAND,FOLLOW_COMMAND_in_numberunitorvariable906); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{COMMAND80_tree = (object)adaptor.Create(COMMAND80);
                    		adaptor.AddChild(root_0, COMMAND80_tree);
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

        simpletikzParser.number_return number81 = default(simpletikzParser.number_return);

        simpletikzParser.unit_return unit82 = default(simpletikzParser.unit_return);


        RewriteRuleSubtreeStream stream_number = new RewriteRuleSubtreeStream(adaptor,"rule number");
        RewriteRuleSubtreeStream stream_unit = new RewriteRuleSubtreeStream(adaptor,"rule unit");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:224:2: ( number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:224:4: number ( unit )?
            {
            	PushFollow(FOLLOW_number_in_numberunit919);
            	number81 = number();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_number.Add(number81.Tree);
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:224:11: ( unit )?
            	int alt26 = 2;
            	int LA26_0 = input.LA(1);

            	if ( ((LA26_0 >= 60 && LA26_0 <= 65)) )
            	{
            	    alt26 = 1;
            	}
            	switch (alt26) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:224:11: unit
            	        {
            	        	PushFollow(FOLLOW_unit_in_numberunit921);
            	        	unit82 = unit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_unit.Add(unit82.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          unit, number
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

        IToken set83 = null;

        object set83_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:229:2: ( ( FLOAT_WO_EXP | INT ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:229:4: ( FLOAT_WO_EXP | INT )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set83 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= FLOAT_WO_EXP && input.LA(1) <= INT) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set83));
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

        IToken set84 = null;

        object set84_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:233:2: ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' | 'em' )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set84 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 60 && input.LA(1) <= 65) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set84));
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

        IToken char_literal87 = null;
        IToken char_literal89 = null;
        simpletikzParser.tikz_set_start_return tikz_set_start85 = default(simpletikzParser.tikz_set_start_return);

        simpletikzParser.option_return option86 = default(simpletikzParser.option_return);

        simpletikzParser.option_return option88 = default(simpletikzParser.option_return);

        simpletikzParser.roundbr_end_return roundbr_end90 = default(simpletikzParser.roundbr_end_return);


        object char_literal87_tree=null;
        object char_literal89_tree=null;
        RewriteRuleTokenStream stream_47 = new RewriteRuleTokenStream(adaptor,"token 47");
        RewriteRuleSubtreeStream stream_tikz_set_start = new RewriteRuleSubtreeStream(adaptor,"rule tikz_set_start");
        RewriteRuleSubtreeStream stream_roundbr_end = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        RewriteRuleSubtreeStream stream_option = new RewriteRuleSubtreeStream(adaptor,"rule option");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:237:2: ( tikz_set_start ( option ( ',' option )* ( ',' )? )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:237:5: tikz_set_start ( option ( ',' option )* ( ',' )? )? roundbr_end
            {
            	PushFollow(FOLLOW_tikz_set_start_in_tikz_set1002);
            	tikz_set_start85 = tikz_set_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikz_set_start.Add(tikz_set_start85.Tree);
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:237:20: ( option ( ',' option )* ( ',' )? )?
            	int alt29 = 2;
            	int LA29_0 = input.LA(1);

            	if ( ((LA29_0 >= IM_PATH && LA29_0 <= 42) || LA29_0 == 46 || (LA29_0 >= 51 && LA29_0 <= 54) || (LA29_0 >= 60 && LA29_0 <= 97)) )
            	{
            	    alt29 = 1;
            	}
            	switch (alt29) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:237:21: option ( ',' option )* ( ',' )?
            	        {
            	        	PushFollow(FOLLOW_option_in_tikz_set1005);
            	        	option86 = option();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_option.Add(option86.Tree);
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:237:28: ( ',' option )*
            	        	do 
            	        	{
            	        	    int alt27 = 2;
            	        	    int LA27_0 = input.LA(1);

            	        	    if ( (LA27_0 == 47) )
            	        	    {
            	        	        int LA27_1 = input.LA(2);

            	        	        if ( ((LA27_1 >= IM_PATH && LA27_1 <= 42) || LA27_1 == 46 || (LA27_1 >= 51 && LA27_1 <= 54) || (LA27_1 >= 60 && LA27_1 <= 97)) )
            	        	        {
            	        	            alt27 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt27) 
            	        		{
            	        			case 1 :
            	        			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:237:29: ',' option
            	        			    {
            	        			    	char_literal87=(IToken)Match(input,47,FOLLOW_47_in_tikz_set1008); if (state.failed) return retval; 
            	        			    	if ( state.backtracking==0 ) stream_47.Add(char_literal87);

            	        			    	PushFollow(FOLLOW_option_in_tikz_set1010);
            	        			    	option88 = option();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking==0 ) stream_option.Add(option88.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop27;
            	        	    }
            	        	} while (true);

            	        	loop27:
            	        		;	// Stops C# compiler whining that label 'loop27' has no statements

            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:237:42: ( ',' )?
            	        	int alt28 = 2;
            	        	int LA28_0 = input.LA(1);

            	        	if ( (LA28_0 == 47) )
            	        	{
            	        	    alt28 = 1;
            	        	}
            	        	switch (alt28) 
            	        	{
            	        	    case 1 :
            	        	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:237:42: ','
            	        	        {
            	        	        	char_literal89=(IToken)Match(input,47,FOLLOW_47_in_tikz_set1014); if (state.failed) return retval; 
            	        	        	if ( state.backtracking==0 ) stream_47.Add(char_literal89);


            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_roundbr_end_in_tikz_set1019);
            	roundbr_end90 = roundbr_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_roundbr_end.Add(roundbr_end90.Tree);


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

        IToken char_literal97 = null;
        simpletikzParser.tikzpicture_start_return tikzpicture_start91 = default(simpletikzParser.tikzpicture_start_return);

        simpletikzParser.tikz_options_return tikz_options92 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody_return tikzbody93 = default(simpletikzParser.tikzbody_return);

        simpletikzParser.tikzpicture_end_return tikzpicture_end94 = default(simpletikzParser.tikzpicture_end_return);

        simpletikzParser.tikz_start_return tikz_start95 = default(simpletikzParser.tikz_start_return);

        simpletikzParser.tikz_options_return tikz_options96 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody2_return tikzbody298 = default(simpletikzParser.tikzbody2_return);

        simpletikzParser.roundbr_end_return roundbr_end99 = default(simpletikzParser.roundbr_end_return);


        object char_literal97_tree=null;
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
            int alt34 = 2;
            int LA34_0 = input.LA(1);

            if ( (LA34_0 == 39) )
            {
                alt34 = 1;
            }
            else if ( (LA34_0 == 42) )
            {
                alt34 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d34s0 =
                    new NoViableAltException("", 34, 0, input);

                throw nvae_d34s0;
            }
            switch (alt34) 
            {
                case 1 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:243:7: ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
                    {
                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:243:7: ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:243:9: tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end
                    	{
                    		PushFollow(FOLLOW_tikzpicture_start_in_tikzpicture1051);
                    		tikzpicture_start91 = tikzpicture_start();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_tikzpicture_start.Add(tikzpicture_start91.Tree);
                    		// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:243:27: ( tikz_options )?
                    		int alt30 = 2;
                    		int LA30_0 = input.LA(1);

                    		if ( (LA30_0 == 57) )
                    		{
                    		    alt30 = 1;
                    		}
                    		switch (alt30) 
                    		{
                    		    case 1 :
                    		        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:243:27: tikz_options
                    		        {
                    		        	PushFollow(FOLLOW_tikz_options_in_tikzpicture1053);
                    		        	tikz_options92 = tikz_options();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_tikz_options.Add(tikz_options92.Tree);

                    		        }
                    		        break;

                    		}

                    		// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:243:41: ( tikzbody )?
                    		int alt31 = 2;
                    		int LA31_0 = input.LA(1);

                    		if ( ((LA31_0 >= IM_PATH && LA31_0 <= 56) || (LA31_0 >= 58 && LA31_0 <= 65) || (LA31_0 >= 67 && LA31_0 <= 97)) )
                    		{
                    		    alt31 = 1;
                    		}
                    		else if ( (LA31_0 == 66) )
                    		{
                    		    int LA31_2 = input.LA(2);

                    		    if ( (LA31_2 == 43) )
                    		    {
                    		        int LA31_3 = input.LA(3);

                    		        if ( (LA31_3 == ID) )
                    		        {
                    		            alt31 = 1;
                    		        }
                    		    }
                    		}
                    		switch (alt31) 
                    		{
                    		    case 1 :
                    		        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:243:41: tikzbody
                    		        {
                    		        	PushFollow(FOLLOW_tikzbody_in_tikzpicture1056);
                    		        	tikzbody93 = tikzbody();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_tikzbody.Add(tikzbody93.Tree);

                    		        }
                    		        break;

                    		}

                    		PushFollow(FOLLOW_tikzpicture_end_in_tikzpicture1059);
                    		tikzpicture_end94 = tikzpicture_end();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_tikzpicture_end.Add(tikzpicture_end94.Tree);

                    	}



                    	// AST REWRITE
                    	// elements:          tikz_options, tikzbody, tikzpicture_start, tikzpicture_end
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
                    		PushFollow(FOLLOW_tikz_start_in_tikzpicture1084);
                    		tikz_start95 = tikz_start();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_tikz_start.Add(tikz_start95.Tree);
                    		// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:244:19: ( tikz_options )?
                    		int alt32 = 2;
                    		int LA32_0 = input.LA(1);

                    		if ( (LA32_0 == 57) )
                    		{
                    		    alt32 = 1;
                    		}
                    		switch (alt32) 
                    		{
                    		    case 1 :
                    		        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:244:19: tikz_options
                    		        {
                    		        	PushFollow(FOLLOW_tikz_options_in_tikzpicture1087);
                    		        	tikz_options96 = tikz_options();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_tikz_options.Add(tikz_options96.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal97=(IToken)Match(input,43,FOLLOW_43_in_tikzpicture1090); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_43.Add(char_literal97);

                    		// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:244:37: ( tikzbody2 )?
                    		int alt33 = 2;
                    		int LA33_0 = input.LA(1);

                    		if ( ((LA33_0 >= IM_PATH && LA33_0 <= 42) || (LA33_0 >= 45 && LA33_0 <= 56) || (LA33_0 >= 58 && LA33_0 <= 97)) )
                    		{
                    		    alt33 = 1;
                    		}
                    		switch (alt33) 
                    		{
                    		    case 1 :
                    		        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:244:37: tikzbody2
                    		        {
                    		        	PushFollow(FOLLOW_tikzbody2_in_tikzpicture1092);
                    		        	tikzbody298 = tikzbody2();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_tikzbody2.Add(tikzbody298.Tree);

                    		        }
                    		        break;

                    		}

                    		PushFollow(FOLLOW_roundbr_end_in_tikzpicture1095);
                    		roundbr_end99 = roundbr_end();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_roundbr_end.Add(roundbr_end99.Tree);

                    	}



                    	// AST REWRITE
                    	// elements:          tikz_start, roundbr_end, tikzbody2, tikz_options
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

        simpletikzParser.tikzscope_return tikzscope100 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath101 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznode_ext_return tikznode_ext102 = default(simpletikzParser.tikznode_ext_return);

        simpletikzParser.tikzdef_ext_return tikzdef_ext103 = default(simpletikzParser.tikzdef_ext_return);

        simpletikzParser.tikzmatrix_ext_return tikzmatrix_ext104 = default(simpletikzParser.tikzmatrix_ext_return);

        simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext105 = default(simpletikzParser.tikzcoordinate_ext_return);

        simpletikzParser.tikz_set_return tikz_set106 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style107 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin108 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend109 = default(simpletikzParser.otherend_return);

        simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr110 = default(simpletikzParser.dontcare_body_nobr_return);

        simpletikzParser.tikzscope_return tikzscope111 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath112 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznode_ext_return tikznode_ext113 = default(simpletikzParser.tikznode_ext_return);

        simpletikzParser.tikzdef_ext_return tikzdef_ext114 = default(simpletikzParser.tikzdef_ext_return);

        simpletikzParser.tikzmatrix_ext_return tikzmatrix_ext115 = default(simpletikzParser.tikzmatrix_ext_return);

        simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext116 = default(simpletikzParser.tikzcoordinate_ext_return);

        simpletikzParser.tikz_set_return tikz_set117 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style118 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin119 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend120 = default(simpletikzParser.otherend_return);

        simpletikzParser.dontcare_body_return dontcare_body121 = default(simpletikzParser.dontcare_body_return);



        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:248:2: ( ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )* )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:248:4: ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:248:4: ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr )
            	int alt35 = 11;
            	alt35 = dfa35.Predict(input);
            	switch (alt35) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:248:6: tikzscope
            	        {
            	        	PushFollow(FOLLOW_tikzscope_in_tikzbody1127);
            	        	tikzscope100 = tikzscope();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzscope100.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:248:18: tikzpath
            	        {
            	        	PushFollow(FOLLOW_tikzpath_in_tikzbody1131);
            	        	tikzpath101 = tikzpath();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath101.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:248:29: tikznode_ext
            	        {
            	        	PushFollow(FOLLOW_tikznode_ext_in_tikzbody1135);
            	        	tikznode_ext102 = tikznode_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_ext102.Tree);

            	        }
            	        break;
            	    case 4 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:248:44: tikzdef_ext
            	        {
            	        	PushFollow(FOLLOW_tikzdef_ext_in_tikzbody1139);
            	        	tikzdef_ext103 = tikzdef_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzdef_ext103.Tree);

            	        }
            	        break;
            	    case 5 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:248:58: tikzmatrix_ext
            	        {
            	        	PushFollow(FOLLOW_tikzmatrix_ext_in_tikzbody1143);
            	        	tikzmatrix_ext104 = tikzmatrix_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzmatrix_ext104.Tree);

            	        }
            	        break;
            	    case 6 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:248:75: tikzcoordinate_ext
            	        {
            	        	PushFollow(FOLLOW_tikzcoordinate_ext_in_tikzbody1147);
            	        	tikzcoordinate_ext105 = tikzcoordinate_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_ext105.Tree);

            	        }
            	        break;
            	    case 7 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:248:96: tikz_set
            	        {
            	        	PushFollow(FOLLOW_tikz_set_in_tikzbody1151);
            	        	tikz_set106 = tikz_set();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set106.Tree);

            	        }
            	        break;
            	    case 8 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:248:107: tikz_style
            	        {
            	        	PushFollow(FOLLOW_tikz_style_in_tikzbody1155);
            	        	tikz_style107 = tikz_style();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style107.Tree);

            	        }
            	        break;
            	    case 9 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:248:120: otherbegin
            	        {
            	        	PushFollow(FOLLOW_otherbegin_in_tikzbody1159);
            	        	otherbegin108 = otherbegin();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;
            	    case 10 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:248:134: otherend
            	        {
            	        	PushFollow(FOLLOW_otherend_in_tikzbody1164);
            	        	otherend109 = otherend();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;
            	    case 11 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:248:146: dontcare_body_nobr
            	        {
            	        	PushFollow(FOLLOW_dontcare_body_nobr_in_tikzbody1169);
            	        	dontcare_body_nobr110 = dontcare_body_nobr();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;

            	}

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:249:3: ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*
            	do 
            	{
            	    int alt36 = 12;
            	    alt36 = dfa36.Predict(input);
            	    switch (alt36) 
            		{
            			case 1 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:249:5: tikzscope
            			    {
            			    	PushFollow(FOLLOW_tikzscope_in_tikzbody1180);
            			    	tikzscope111 = tikzscope();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzscope111.Tree);

            			    }
            			    break;
            			case 2 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:249:17: tikzpath
            			    {
            			    	PushFollow(FOLLOW_tikzpath_in_tikzbody1184);
            			    	tikzpath112 = tikzpath();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath112.Tree);

            			    }
            			    break;
            			case 3 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:249:28: tikznode_ext
            			    {
            			    	PushFollow(FOLLOW_tikznode_ext_in_tikzbody1188);
            			    	tikznode_ext113 = tikznode_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_ext113.Tree);

            			    }
            			    break;
            			case 4 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:249:43: tikzdef_ext
            			    {
            			    	PushFollow(FOLLOW_tikzdef_ext_in_tikzbody1192);
            			    	tikzdef_ext114 = tikzdef_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzdef_ext114.Tree);

            			    }
            			    break;
            			case 5 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:249:57: tikzmatrix_ext
            			    {
            			    	PushFollow(FOLLOW_tikzmatrix_ext_in_tikzbody1196);
            			    	tikzmatrix_ext115 = tikzmatrix_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzmatrix_ext115.Tree);

            			    }
            			    break;
            			case 6 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:249:74: tikzcoordinate_ext
            			    {
            			    	PushFollow(FOLLOW_tikzcoordinate_ext_in_tikzbody1200);
            			    	tikzcoordinate_ext116 = tikzcoordinate_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_ext116.Tree);

            			    }
            			    break;
            			case 7 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:249:95: tikz_set
            			    {
            			    	PushFollow(FOLLOW_tikz_set_in_tikzbody1204);
            			    	tikz_set117 = tikz_set();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set117.Tree);

            			    }
            			    break;
            			case 8 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:249:106: tikz_style
            			    {
            			    	PushFollow(FOLLOW_tikz_style_in_tikzbody1208);
            			    	tikz_style118 = tikz_style();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style118.Tree);

            			    }
            			    break;
            			case 9 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:249:119: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzbody1212);
            			    	otherbegin119 = otherbegin();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;
            			case 10 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:249:133: otherend
            			    {
            			    	PushFollow(FOLLOW_otherend_in_tikzbody1217);
            			    	otherend120 = otherend();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;
            			case 11 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:249:145: dontcare_body
            			    {
            			    	PushFollow(FOLLOW_dontcare_body_in_tikzbody1222);
            			    	dontcare_body121 = dontcare_body();
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

        simpletikzParser.tikzscope_return tikzscope122 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath123 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznode_ext_return tikznode_ext124 = default(simpletikzParser.tikznode_ext_return);

        simpletikzParser.tikzdef_ext_return tikzdef_ext125 = default(simpletikzParser.tikzdef_ext_return);

        simpletikzParser.tikzmatrix_ext_return tikzmatrix_ext126 = default(simpletikzParser.tikzmatrix_ext_return);

        simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext127 = default(simpletikzParser.tikzcoordinate_ext_return);

        simpletikzParser.tikz_set_return tikz_set128 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style129 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin130 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend131 = default(simpletikzParser.otherend_return);

        simpletikzParser.dontcare_body_nobr2_return dontcare_body_nobr2132 = default(simpletikzParser.dontcare_body_nobr2_return);

        simpletikzParser.tikzscope_return tikzscope133 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath134 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznode_ext_return tikznode_ext135 = default(simpletikzParser.tikznode_ext_return);

        simpletikzParser.tikzdef_ext_return tikzdef_ext136 = default(simpletikzParser.tikzdef_ext_return);

        simpletikzParser.tikzmatrix_ext_return tikzmatrix_ext137 = default(simpletikzParser.tikzmatrix_ext_return);

        simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext138 = default(simpletikzParser.tikzcoordinate_ext_return);

        simpletikzParser.tikz_set_return tikz_set139 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style140 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin141 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend142 = default(simpletikzParser.otherend_return);

        simpletikzParser.dontcare_body2_return dontcare_body2143 = default(simpletikzParser.dontcare_body2_return);



        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:252:2: ( ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr2 ) ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body2 )* )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:252:4: ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr2 ) ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body2 )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:252:4: ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr2 )
            	int alt37 = 11;
            	alt37 = dfa37.Predict(input);
            	switch (alt37) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:252:6: tikzscope
            	        {
            	        	PushFollow(FOLLOW_tikzscope_in_tikzbody21238);
            	        	tikzscope122 = tikzscope();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzscope122.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:252:18: tikzpath
            	        {
            	        	PushFollow(FOLLOW_tikzpath_in_tikzbody21242);
            	        	tikzpath123 = tikzpath();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath123.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:252:29: tikznode_ext
            	        {
            	        	PushFollow(FOLLOW_tikznode_ext_in_tikzbody21246);
            	        	tikznode_ext124 = tikznode_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_ext124.Tree);

            	        }
            	        break;
            	    case 4 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:252:44: tikzdef_ext
            	        {
            	        	PushFollow(FOLLOW_tikzdef_ext_in_tikzbody21250);
            	        	tikzdef_ext125 = tikzdef_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzdef_ext125.Tree);

            	        }
            	        break;
            	    case 5 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:252:58: tikzmatrix_ext
            	        {
            	        	PushFollow(FOLLOW_tikzmatrix_ext_in_tikzbody21254);
            	        	tikzmatrix_ext126 = tikzmatrix_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzmatrix_ext126.Tree);

            	        }
            	        break;
            	    case 6 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:252:75: tikzcoordinate_ext
            	        {
            	        	PushFollow(FOLLOW_tikzcoordinate_ext_in_tikzbody21258);
            	        	tikzcoordinate_ext127 = tikzcoordinate_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_ext127.Tree);

            	        }
            	        break;
            	    case 7 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:252:96: tikz_set
            	        {
            	        	PushFollow(FOLLOW_tikz_set_in_tikzbody21262);
            	        	tikz_set128 = tikz_set();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set128.Tree);

            	        }
            	        break;
            	    case 8 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:252:107: tikz_style
            	        {
            	        	PushFollow(FOLLOW_tikz_style_in_tikzbody21266);
            	        	tikz_style129 = tikz_style();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style129.Tree);

            	        }
            	        break;
            	    case 9 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:252:120: otherbegin
            	        {
            	        	PushFollow(FOLLOW_otherbegin_in_tikzbody21270);
            	        	otherbegin130 = otherbegin();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;
            	    case 10 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:252:134: otherend
            	        {
            	        	PushFollow(FOLLOW_otherend_in_tikzbody21275);
            	        	otherend131 = otherend();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;
            	    case 11 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:252:146: dontcare_body_nobr2
            	        {
            	        	PushFollow(FOLLOW_dontcare_body_nobr2_in_tikzbody21280);
            	        	dontcare_body_nobr2132 = dontcare_body_nobr2();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;

            	}

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:253:3: ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body2 )*
            	do 
            	{
            	    int alt38 = 12;
            	    alt38 = dfa38.Predict(input);
            	    switch (alt38) 
            		{
            			case 1 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:253:5: tikzscope
            			    {
            			    	PushFollow(FOLLOW_tikzscope_in_tikzbody21291);
            			    	tikzscope133 = tikzscope();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzscope133.Tree);

            			    }
            			    break;
            			case 2 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:253:17: tikzpath
            			    {
            			    	PushFollow(FOLLOW_tikzpath_in_tikzbody21295);
            			    	tikzpath134 = tikzpath();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath134.Tree);

            			    }
            			    break;
            			case 3 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:253:28: tikznode_ext
            			    {
            			    	PushFollow(FOLLOW_tikznode_ext_in_tikzbody21299);
            			    	tikznode_ext135 = tikznode_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_ext135.Tree);

            			    }
            			    break;
            			case 4 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:253:43: tikzdef_ext
            			    {
            			    	PushFollow(FOLLOW_tikzdef_ext_in_tikzbody21303);
            			    	tikzdef_ext136 = tikzdef_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzdef_ext136.Tree);

            			    }
            			    break;
            			case 5 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:253:57: tikzmatrix_ext
            			    {
            			    	PushFollow(FOLLOW_tikzmatrix_ext_in_tikzbody21307);
            			    	tikzmatrix_ext137 = tikzmatrix_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzmatrix_ext137.Tree);

            			    }
            			    break;
            			case 6 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:253:74: tikzcoordinate_ext
            			    {
            			    	PushFollow(FOLLOW_tikzcoordinate_ext_in_tikzbody21311);
            			    	tikzcoordinate_ext138 = tikzcoordinate_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_ext138.Tree);

            			    }
            			    break;
            			case 7 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:253:95: tikz_set
            			    {
            			    	PushFollow(FOLLOW_tikz_set_in_tikzbody21315);
            			    	tikz_set139 = tikz_set();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set139.Tree);

            			    }
            			    break;
            			case 8 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:253:106: tikz_style
            			    {
            			    	PushFollow(FOLLOW_tikz_style_in_tikzbody21319);
            			    	tikz_style140 = tikz_style();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style140.Tree);

            			    }
            			    break;
            			case 9 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:253:119: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzbody21323);
            			    	otherbegin141 = otherbegin();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;
            			case 10 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:253:133: otherend
            			    {
            			    	PushFollow(FOLLOW_otherend_in_tikzbody21328);
            			    	otherend142 = otherend();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;
            			case 11 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:253:145: dontcare_body2
            			    {
            			    	PushFollow(FOLLOW_dontcare_body2_in_tikzbody21333);
            			    	dontcare_body2143 = dontcare_body2();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop38;
            	    }
            	} while (true);

            	loop38:
            		;	// Stops C# compiler whining that label 'loop38' has no statements


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

        IToken set144 = null;

        object set144_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:257:2: ( (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' | '{' | '}' ) ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:257:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' | '{' | '}' ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:257:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' | '{' | '}' ) )
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:257:5: ~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' | '{' | '}' )
            	{
            		set144 = (IToken)input.LT(1);
            		if ( (input.LA(1) >= IM_PATH && input.LA(1) <= SOMETHING1) || input.LA(1) == 42 || (input.LA(1) >= 45 && input.LA(1) <= 56) || (input.LA(1) >= 58 && input.LA(1) <= 65) || (input.LA(1) >= 80 && input.LA(1) <= 97) ) 
            		{
            		    input.Consume();
            		    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set144));
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

        IToken set145 = null;

        object set145_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:260:2: ( (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '{' | '}' ) ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:260:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '{' | '}' ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:260:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '{' | '}' ) )
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:260:5: ~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '{' | '}' )
            	{
            		set145 = (IToken)input.LT(1);
            		if ( (input.LA(1) >= IM_PATH && input.LA(1) <= SOMETHING1) || input.LA(1) == 42 || (input.LA(1) >= 45 && input.LA(1) <= 65) || (input.LA(1) >= 80 && input.LA(1) <= 97) ) 
            		{
            		    input.Consume();
            		    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set145));
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

        IToken set146 = null;

        object set146_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:263:2: ( (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:263:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:263:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) )
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:263:5: ~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' )
            	{
            		set146 = (IToken)input.LT(1);
            		if ( (input.LA(1) >= IM_PATH && input.LA(1) <= SOMETHING1) || (input.LA(1) >= 42 && input.LA(1) <= 56) || (input.LA(1) >= 58 && input.LA(1) <= 65) || (input.LA(1) >= 80 && input.LA(1) <= 97) ) 
            		{
            		    input.Consume();
            		    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set146));
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

        IToken set147 = null;

        object set147_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:266:2: ( (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:266:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:266:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) )
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:266:5: ~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\def' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' )
            	{
            		set147 = (IToken)input.LT(1);
            		if ( (input.LA(1) >= IM_PATH && input.LA(1) <= SOMETHING1) || (input.LA(1) >= 42 && input.LA(1) <= 65) || (input.LA(1) >= 80 && input.LA(1) <= 97) ) 
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

        IToken string_literal148 = null;
        IToken char_literal149 = null;
        IToken char_literal151 = null;
        simpletikzParser.idd2_return idd2150 = default(simpletikzParser.idd2_return);


        object string_literal148_tree=null;
        object char_literal149_tree=null;
        object char_literal151_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:269:2: ( '\\\\end' '{' idd2 '}' )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:269:4: '\\\\end' '{' idd2 '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal148=(IToken)Match(input,66,FOLLOW_66_in_otherend1704); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal148_tree = (object)adaptor.Create(string_literal148);
            		adaptor.AddChild(root_0, string_literal148_tree);
            	}
            	char_literal149=(IToken)Match(input,43,FOLLOW_43_in_otherend1706); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal149_tree = (object)adaptor.Create(char_literal149);
            		adaptor.AddChild(root_0, char_literal149_tree);
            	}
            	PushFollow(FOLLOW_idd2_in_otherend1708);
            	idd2150 = idd2();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idd2150.Tree);
            	char_literal151=(IToken)Match(input,44,FOLLOW_44_in_otherend1710); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal151_tree = (object)adaptor.Create(char_literal151);
            		adaptor.AddChild(root_0, char_literal151_tree);
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

        simpletikzParser.tikzscope_start_return tikzscope_start152 = default(simpletikzParser.tikzscope_start_return);

        simpletikzParser.tikz_options_return tikz_options153 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody_return tikzbody154 = default(simpletikzParser.tikzbody_return);

        simpletikzParser.tikzscope_end_return tikzscope_end155 = default(simpletikzParser.tikzscope_end_return);


        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikzscope_start = new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_start");
        RewriteRuleSubtreeStream stream_tikzscope_end = new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_end");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:284:2: ( tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:284:4: tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end
            {
            	PushFollow(FOLLOW_tikzscope_start_in_tikzscope1737);
            	tikzscope_start152 = tikzscope_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikzscope_start.Add(tikzscope_start152.Tree);
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:284:20: ( tikz_options )?
            	int alt39 = 2;
            	int LA39_0 = input.LA(1);

            	if ( (LA39_0 == 57) )
            	{
            	    alt39 = 1;
            	}
            	switch (alt39) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:284:20: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_tikzscope1739);
            	        	tikz_options153 = tikz_options();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_tikz_options.Add(tikz_options153.Tree);

            	        }
            	        break;

            	}

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:284:34: ( tikzbody )?
            	int alt40 = 2;
            	int LA40_0 = input.LA(1);

            	if ( ((LA40_0 >= IM_PATH && LA40_0 <= 56) || (LA40_0 >= 58 && LA40_0 <= 65) || (LA40_0 >= 67 && LA40_0 <= 97)) )
            	{
            	    alt40 = 1;
            	}
            	else if ( (LA40_0 == 66) )
            	{
            	    int LA40_2 = input.LA(2);

            	    if ( (LA40_2 == 43) )
            	    {
            	        int LA40_3 = input.LA(3);

            	        if ( (LA40_3 == ID) )
            	        {
            	            alt40 = 1;
            	        }
            	    }
            	}
            	switch (alt40) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:284:34: tikzbody
            	        {
            	        	PushFollow(FOLLOW_tikzbody_in_tikzscope1742);
            	        	tikzbody154 = tikzbody();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_tikzbody.Add(tikzbody154.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzscope_end_in_tikzscope1745);
            	tikzscope_end155 = tikzscope_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikzscope_end.Add(tikzscope_end155.Tree);


            	// AST REWRITE
            	// elements:          tikzscope_start, tikzscope_end, tikzbody, tikz_options
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

        simpletikzParser.path_start_return path_start156 = default(simpletikzParser.path_start_return);

        simpletikzParser.tikzpath_element_return tikzpath_element157 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end158 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        RewriteRuleSubtreeStream stream_path_start = new RewriteRuleSubtreeStream(adaptor,"rule path_start");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:311:2: ( path_start ( tikzpath_element )* semicolon_end -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:311:4: path_start ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_path_start_in_tikzpath1801);
            	path_start156 = path_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_path_start.Add(path_start156.Tree);
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:311:15: ( tikzpath_element )*
            	do 
            	{
            	    int alt41 = 2;
            	    int LA41_0 = input.LA(1);

            	    if ( ((LA41_0 >= ID && LA41_0 <= COMMAND) || LA41_0 == 43 || LA41_0 == 45 || LA41_0 == 55 || LA41_0 == 57 || LA41_0 == 61 || LA41_0 == 80 || (LA41_0 >= 82 && LA41_0 <= 83) || (LA41_0 >= 85 && LA41_0 <= 94)) )
            	    {
            	        alt41 = 1;
            	    }


            	    switch (alt41) 
            		{
            			case 1 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:311:15: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath1803);
            			    	tikzpath_element157 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikzpath_element.Add(tikzpath_element157.Tree);

            			    }
            			    break;

            			default:
            			    goto loop41;
            	    }
            	} while (true);

            	loop41:
            		;	// Stops C# compiler whining that label 'loop41' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikzpath1806);
            	semicolon_end158 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_semicolon_end.Add(semicolon_end158.Tree);


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

        IToken set159 = null;

        object set159_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:317:2: ( 'let' | 'in' | '=' | COMMAND )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set159 = (IToken)input.LT(1);
            	if ( input.LA(1) == COMMAND || input.LA(1) == 45 || input.LA(1) == 61 || input.LA(1) == 80 ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set159));
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

        IToken char_literal161 = null;
        simpletikzParser.tikzpath_element_single_return tikzpath_element_single160 = default(simpletikzParser.tikzpath_element_single_return);


        object char_literal161_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:322:2: ( tikzpath_element_single ( ',' )? )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:322:4: tikzpath_element_single ( ',' )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_tikzpath_element_single_in_tikzpath_element1862);
            	tikzpath_element_single160 = tikzpath_element_single();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath_element_single160.Tree);
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:322:31: ( ',' )?
            	int alt42 = 2;
            	int LA42_0 = input.LA(1);

            	if ( (LA42_0 == 47) )
            	{
            	    alt42 = 1;
            	}
            	switch (alt42) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:322:31: ','
            	        {
            	        	char_literal161=(IToken)Match(input,47,FOLLOW_47_in_tikzpath_element1864); if (state.failed) return retval;

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

        IToken char_literal173 = null;
        IToken char_literal175 = null;
        simpletikzParser.tikz_options_return tikz_options162 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.let_cmd_parts_return let_cmd_parts163 = default(simpletikzParser.let_cmd_parts_return);

        simpletikzParser.arc_return arc164 = default(simpletikzParser.arc_return);

        simpletikzParser.coord_return coord165 = default(simpletikzParser.coord_return);

        simpletikzParser.controls_return controls166 = default(simpletikzParser.controls_return);

        simpletikzParser.tikznode_int_return tikznode_int167 = default(simpletikzParser.tikznode_int_return);

        simpletikzParser.tikzcoordinate_int_return tikzcoordinate_int168 = default(simpletikzParser.tikzcoordinate_int_return);

        simpletikzParser.circle_return circle169 = default(simpletikzParser.circle_return);

        simpletikzParser.roundbr_start_return roundbr_start170 = default(simpletikzParser.roundbr_start_return);

        simpletikzParser.tikzpath_element_return tikzpath_element171 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.roundbr_end_return roundbr_end172 = default(simpletikzParser.roundbr_end_return);

        simpletikzParser.tikzpath_element_return tikzpath_element174 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.edgeop_return edgeop176 = default(simpletikzParser.edgeop_return);


        object char_literal173_tree=null;
        object char_literal175_tree=null;
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_let_cmd_parts = new RewriteRuleSubtreeStream(adaptor,"rule let_cmd_parts");
        RewriteRuleSubtreeStream stream_roundbr_start = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_start");
        RewriteRuleSubtreeStream stream_roundbr_end = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:326:2: ( tikz_options | let_cmd_parts -> ^( IM_DONTCARE ( let_cmd_parts )+ ) | arc | ( coord )=> coord | controls | tikznode_int | tikzcoordinate_int | circle | roundbr_start ( tikzpath_element )* roundbr_end -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end ) | '(' ( tikzpath_element )* ')' -> ^( IM_PATH '(' ( tikzpath_element )* ')' ) | edgeop )
            int alt45 = 11;
            alt45 = dfa45.Predict(input);
            switch (alt45) 
            {
                case 1 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:327:5: tikz_options
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_options_in_tikzpath_element_single1882);
                    	tikz_options162 = tikz_options();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_options162.Tree);

                    }
                    break;
                case 2 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:328:5: let_cmd_parts
                    {
                    	PushFollow(FOLLOW_let_cmd_parts_in_tikzpath_element_single1889);
                    	let_cmd_parts163 = let_cmd_parts();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_let_cmd_parts.Add(let_cmd_parts163.Tree);


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

                    	PushFollow(FOLLOW_arc_in_tikzpath_element_single1907);
                    	arc164 = arc();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arc164.Tree);

                    }
                    break;
                case 4 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:331:5: ( coord )=> coord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_coord_in_tikzpath_element_single1917);
                    	coord165 = coord();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, coord165.Tree);

                    }
                    break;
                case 5 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:332:5: controls
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_controls_in_tikzpath_element_single1923);
                    	controls166 = controls();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, controls166.Tree);

                    }
                    break;
                case 6 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:333:5: tikznode_int
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikznode_int_in_tikzpath_element_single1929);
                    	tikznode_int167 = tikznode_int();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_int167.Tree);

                    }
                    break;
                case 7 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:334:5: tikzcoordinate_int
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikzcoordinate_int_in_tikzpath_element_single1935);
                    	tikzcoordinate_int168 = tikzcoordinate_int();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_int168.Tree);

                    }
                    break;
                case 8 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:335:5: circle
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_circle_in_tikzpath_element_single1941);
                    	circle169 = circle();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;

                    }
                    break;
                case 9 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:336:5: roundbr_start ( tikzpath_element )* roundbr_end
                    {
                    	PushFollow(FOLLOW_roundbr_start_in_tikzpath_element_single1948);
                    	roundbr_start170 = roundbr_start();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_roundbr_start.Add(roundbr_start170.Tree);
                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:336:19: ( tikzpath_element )*
                    	do 
                    	{
                    	    int alt43 = 2;
                    	    int LA43_0 = input.LA(1);

                    	    if ( ((LA43_0 >= ID && LA43_0 <= COMMAND) || LA43_0 == 43 || LA43_0 == 45 || LA43_0 == 55 || LA43_0 == 57 || LA43_0 == 61 || LA43_0 == 80 || (LA43_0 >= 82 && LA43_0 <= 83) || (LA43_0 >= 85 && LA43_0 <= 94)) )
                    	    {
                    	        alt43 = 1;
                    	    }


                    	    switch (alt43) 
                    		{
                    			case 1 :
                    			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:336:19: tikzpath_element
                    			    {
                    			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath_element_single1950);
                    			    	tikzpath_element171 = tikzpath_element();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking==0 ) stream_tikzpath_element.Add(tikzpath_element171.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop43;
                    	    }
                    	} while (true);

                    	loop43:
                    		;	// Stops C# compiler whining that label 'loop43' has no statements

                    	PushFollow(FOLLOW_roundbr_end_in_tikzpath_element_single1953);
                    	roundbr_end172 = roundbr_end();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_roundbr_end.Add(roundbr_end172.Tree);


                    	// AST REWRITE
                    	// elements:          tikzpath_element, roundbr_start, roundbr_end
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
                    	char_literal173=(IToken)Match(input,55,FOLLOW_55_in_tikzpath_element_single1973); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_55.Add(char_literal173);

                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:337:10: ( tikzpath_element )*
                    	do 
                    	{
                    	    int alt44 = 2;
                    	    int LA44_0 = input.LA(1);

                    	    if ( ((LA44_0 >= ID && LA44_0 <= COMMAND) || LA44_0 == 43 || LA44_0 == 45 || LA44_0 == 55 || LA44_0 == 57 || LA44_0 == 61 || LA44_0 == 80 || (LA44_0 >= 82 && LA44_0 <= 83) || (LA44_0 >= 85 && LA44_0 <= 94)) )
                    	    {
                    	        alt44 = 1;
                    	    }


                    	    switch (alt44) 
                    		{
                    			case 1 :
                    			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:337:10: tikzpath_element
                    			    {
                    			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath_element_single1975);
                    			    	tikzpath_element174 = tikzpath_element();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking==0 ) stream_tikzpath_element.Add(tikzpath_element174.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop44;
                    	    }
                    	} while (true);

                    	loop44:
                    		;	// Stops C# compiler whining that label 'loop44' has no statements

                    	char_literal175=(IToken)Match(input,56,FOLLOW_56_in_tikzpath_element_single1978); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_56.Add(char_literal175);



                    	// AST REWRITE
                    	// elements:          55, tikzpath_element, 56
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

                    	    adaptor.AddChild(root_1, stream_55.NextNode());
                    	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:337:49: ( tikzpath_element )*
                    	    while ( stream_tikzpath_element.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_tikzpath_element.NextTree());

                    	    }
                    	    stream_tikzpath_element.Reset();
                    	    adaptor.AddChild(root_1, stream_56.NextNode());

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

                    	PushFollow(FOLLOW_edgeop_in_tikzpath_element_single1997);
                    	edgeop176 = edgeop();
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

        IToken string_literal179 = null;
        simpletikzParser.controls_start_return controls_start177 = default(simpletikzParser.controls_start_return);

        simpletikzParser.coord_return coord178 = default(simpletikzParser.coord_return);

        simpletikzParser.coord_return coord180 = default(simpletikzParser.coord_return);

        simpletikzParser.controls_end_return controls_end181 = default(simpletikzParser.controls_end_return);


        object string_literal179_tree=null;
        RewriteRuleTokenStream stream_81 = new RewriteRuleTokenStream(adaptor,"token 81");
        RewriteRuleSubtreeStream stream_controls_end = new RewriteRuleSubtreeStream(adaptor,"rule controls_end");
        RewriteRuleSubtreeStream stream_coord = new RewriteRuleSubtreeStream(adaptor,"rule coord");
        RewriteRuleSubtreeStream stream_controls_start = new RewriteRuleSubtreeStream(adaptor,"rule controls_start");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:342:2: ( controls_start coord ( 'and' coord )? controls_end -> ^( IM_CONTROLS controls_start ( coord )+ controls_end ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:342:4: controls_start coord ( 'and' coord )? controls_end
            {
            	PushFollow(FOLLOW_controls_start_in_controls2012);
            	controls_start177 = controls_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_controls_start.Add(controls_start177.Tree);
            	PushFollow(FOLLOW_coord_in_controls2014);
            	coord178 = coord();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_coord.Add(coord178.Tree);
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:342:25: ( 'and' coord )?
            	int alt46 = 2;
            	int LA46_0 = input.LA(1);

            	if ( (LA46_0 == 81) )
            	{
            	    alt46 = 1;
            	}
            	switch (alt46) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:342:26: 'and' coord
            	        {
            	        	string_literal179=(IToken)Match(input,81,FOLLOW_81_in_controls2017); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_81.Add(string_literal179);

            	        	PushFollow(FOLLOW_coord_in_controls2019);
            	        	coord180 = coord();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_coord.Add(coord180.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_controls_end_in_controls2023);
            	controls_end181 = controls_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_controls_end.Add(controls_end181.Tree);


            	// AST REWRITE
            	// elements:          coord, controls_end, controls_start
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

        simpletikzParser.node_start_return node_start182 = default(simpletikzParser.node_start_return);

        simpletikzParser.tikznode_core_return tikznode_core183 = default(simpletikzParser.tikznode_core_return);

        simpletikzParser.tikzpath_element_return tikzpath_element184 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end185 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_tikznode_core = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_core");
        RewriteRuleSubtreeStream stream_node_start = new RewriteRuleSubtreeStream(adaptor,"rule node_start");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:346:2: ( node_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:346:4: node_start tikznode_core ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_node_start_in_tikznode_ext2049);
            	node_start182 = node_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_node_start.Add(node_start182.Tree);
            	PushFollow(FOLLOW_tikznode_core_in_tikznode_ext2051);
            	tikznode_core183 = tikznode_core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_core.Add(tikznode_core183.Tree);
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:346:29: ( tikzpath_element )*
            	do 
            	{
            	    int alt47 = 2;
            	    int LA47_0 = input.LA(1);

            	    if ( ((LA47_0 >= ID && LA47_0 <= COMMAND) || LA47_0 == 43 || LA47_0 == 45 || LA47_0 == 55 || LA47_0 == 57 || LA47_0 == 61 || LA47_0 == 80 || (LA47_0 >= 82 && LA47_0 <= 83) || (LA47_0 >= 85 && LA47_0 <= 94)) )
            	    {
            	        alt47 = 1;
            	    }


            	    switch (alt47) 
            		{
            			case 1 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:346:29: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikznode_ext2053);
            			    	tikzpath_element184 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikzpath_element.Add(tikzpath_element184.Tree);

            			    }
            			    break;

            			default:
            			    goto loop47;
            	    }
            	} while (true);

            	loop47:
            		;	// Stops C# compiler whining that label 'loop47' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikznode_ext2056);
            	semicolon_end185 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_semicolon_end.Add(semicolon_end185.Tree);


            	// AST REWRITE
            	// elements:          tikzpath_element, tikznode_core, node_start, semicolon_end
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

        simpletikzParser.def_start_return def_start186 = default(simpletikzParser.def_start_return);

        simpletikzParser.tikzpath_element_return tikzpath_element187 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end188 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_def_start = new RewriteRuleSubtreeStream(adaptor,"rule def_start");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:349:2: ( def_start ( tikzpath_element )* semicolon_end -> ^( IM_PATH def_start ( tikzpath_element )* semicolon_end ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:349:4: def_start ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_def_start_in_tikzdef_ext2081);
            	def_start186 = def_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_def_start.Add(def_start186.Tree);
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:349:14: ( tikzpath_element )*
            	do 
            	{
            	    int alt48 = 2;
            	    int LA48_0 = input.LA(1);

            	    if ( ((LA48_0 >= ID && LA48_0 <= COMMAND) || LA48_0 == 43 || LA48_0 == 45 || LA48_0 == 55 || LA48_0 == 57 || LA48_0 == 61 || LA48_0 == 80 || (LA48_0 >= 82 && LA48_0 <= 83) || (LA48_0 >= 85 && LA48_0 <= 94)) )
            	    {
            	        alt48 = 1;
            	    }


            	    switch (alt48) 
            		{
            			case 1 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:349:14: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikzdef_ext2083);
            			    	tikzpath_element187 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikzpath_element.Add(tikzpath_element187.Tree);

            			    }
            			    break;

            			default:
            			    goto loop48;
            	    }
            	} while (true);

            	loop48:
            		;	// Stops C# compiler whining that label 'loop48' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikzdef_ext2086);
            	semicolon_end188 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_semicolon_end.Add(semicolon_end188.Tree);


            	// AST REWRITE
            	// elements:          semicolon_end, def_start, tikzpath_element
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

        simpletikzParser.matrix_start_return matrix_start189 = default(simpletikzParser.matrix_start_return);

        simpletikzParser.tikznode_core_return tikznode_core190 = default(simpletikzParser.tikznode_core_return);

        simpletikzParser.tikzpath_element_return tikzpath_element191 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end192 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_tikznode_core = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_core");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        RewriteRuleSubtreeStream stream_matrix_start = new RewriteRuleSubtreeStream(adaptor,"rule matrix_start");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:353:2: ( matrix_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH matrix_start tikznode_core ( tikzpath_element )* semicolon_end ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:353:4: matrix_start tikznode_core ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_matrix_start_in_tikzmatrix_ext2111);
            	matrix_start189 = matrix_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_matrix_start.Add(matrix_start189.Tree);
            	PushFollow(FOLLOW_tikznode_core_in_tikzmatrix_ext2113);
            	tikznode_core190 = tikznode_core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_core.Add(tikznode_core190.Tree);
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:353:31: ( tikzpath_element )*
            	do 
            	{
            	    int alt49 = 2;
            	    int LA49_0 = input.LA(1);

            	    if ( ((LA49_0 >= ID && LA49_0 <= COMMAND) || LA49_0 == 43 || LA49_0 == 45 || LA49_0 == 55 || LA49_0 == 57 || LA49_0 == 61 || LA49_0 == 80 || (LA49_0 >= 82 && LA49_0 <= 83) || (LA49_0 >= 85 && LA49_0 <= 94)) )
            	    {
            	        alt49 = 1;
            	    }


            	    switch (alt49) 
            		{
            			case 1 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:353:31: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikzmatrix_ext2115);
            			    	tikzpath_element191 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikzpath_element.Add(tikzpath_element191.Tree);

            			    }
            			    break;

            			default:
            			    goto loop49;
            	    }
            	} while (true);

            	loop49:
            		;	// Stops C# compiler whining that label 'loop49' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikzmatrix_ext2118);
            	semicolon_end192 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_semicolon_end.Add(semicolon_end192.Tree);


            	// AST REWRITE
            	// elements:          tikznode_core, matrix_start, tikzpath_element, semicolon_end
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

        simpletikzParser.coordinate_start_return coordinate_start193 = default(simpletikzParser.coordinate_start_return);

        simpletikzParser.tikzcoordinate_core3_return tikzcoordinate_core3194 = default(simpletikzParser.tikzcoordinate_core3_return);

        simpletikzParser.tikzcoordinate_core2_return tikzcoordinate_core2195 = default(simpletikzParser.tikzcoordinate_core2_return);

        simpletikzParser.tikzcoordinate_core1_return tikzcoordinate_core1196 = default(simpletikzParser.tikzcoordinate_core1_return);

        simpletikzParser.tikzpath_element_return tikzpath_element197 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end198 = default(simpletikzParser.semicolon_end_return);


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
            	PushFollow(FOLLOW_coordinate_start_in_tikzcoordinate_ext2146);
            	coordinate_start193 = coordinate_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_coordinate_start.Add(coordinate_start193.Tree);
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:359:5: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?
            	int alt50 = 4;
            	alt50 = dfa50.Predict(input);
            	switch (alt50) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:359:7: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        {
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:359:7: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:359:8: ( tikzcoordinate_core3 )=> tikzcoordinate_core3
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_ext2161);
            	        		tikzcoordinate_core3194 = tikzcoordinate_core3();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking==0 ) stream_tikzcoordinate_core3.Add(tikzcoordinate_core3194.Tree);

            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:360:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        {
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:360:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:360:12: ( tikzcoordinate_core2 )=> tikzcoordinate_core2
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_ext2180);
            	        		tikzcoordinate_core2195 = tikzcoordinate_core2();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking==0 ) stream_tikzcoordinate_core2.Add(tikzcoordinate_core2195.Tree);

            	        	}


            	        }
            	        break;
            	    case 3 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:361:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        {
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:361:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:361:12: ( tikzcoordinate_core1 )=> tikzcoordinate_core1
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_ext2200);
            	        		tikzcoordinate_core1196 = tikzcoordinate_core1();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking==0 ) stream_tikzcoordinate_core1.Add(tikzcoordinate_core1196.Tree);

            	        	}


            	        }
            	        break;

            	}

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:362:6: ( tikzpath_element )*
            	do 
            	{
            	    int alt51 = 2;
            	    int LA51_0 = input.LA(1);

            	    if ( ((LA51_0 >= ID && LA51_0 <= COMMAND) || LA51_0 == 43 || LA51_0 == 45 || LA51_0 == 55 || LA51_0 == 57 || LA51_0 == 61 || LA51_0 == 80 || (LA51_0 >= 82 && LA51_0 <= 83) || (LA51_0 >= 85 && LA51_0 <= 94)) )
            	    {
            	        alt51 = 1;
            	    }


            	    switch (alt51) 
            		{
            			case 1 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:362:6: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikzcoordinate_ext2211);
            			    	tikzpath_element197 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikzpath_element.Add(tikzpath_element197.Tree);

            			    }
            			    break;

            			default:
            			    goto loop51;
            	    }
            	} while (true);

            	loop51:
            		;	// Stops C# compiler whining that label 'loop51' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikzcoordinate_ext2214);
            	semicolon_end198 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_semicolon_end.Add(semicolon_end198.Tree);


            	// AST REWRITE
            	// elements:          tikzcoordinate_core2, coordinate_start, tikzcoordinate_core1, semicolon_end, tikzcoordinate_core3, tikzpath_element
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

        IToken string_literal199 = null;
        simpletikzParser.tikzcoordinate_core3_return tikzcoordinate_core3200 = default(simpletikzParser.tikzcoordinate_core3_return);

        simpletikzParser.tikzcoordinate_core2_return tikzcoordinate_core2201 = default(simpletikzParser.tikzcoordinate_core2_return);

        simpletikzParser.tikzcoordinate_core1_return tikzcoordinate_core1202 = default(simpletikzParser.tikzcoordinate_core1_return);


        object string_literal199_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:370:2: ( 'coordinate' ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:370:4: 'coordinate' ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal199=(IToken)Match(input,82,FOLLOW_82_in_tikzcoordinate_int2274); if (state.failed) return retval;
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:370:18: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?
            	int alt52 = 4;
            	alt52 = dfa52.Predict(input);
            	switch (alt52) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:370:20: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        {
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:370:20: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:370:21: ( tikzcoordinate_core3 )=> tikzcoordinate_core3
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_int2285);
            	        		tikzcoordinate_core3200 = tikzcoordinate_core3();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_core3200.Tree);

            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:371:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        {
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:371:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:371:12: ( tikzcoordinate_core2 )=> tikzcoordinate_core2
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_int2304);
            	        		tikzcoordinate_core2201 = tikzcoordinate_core2();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_core2201.Tree);

            	        	}


            	        }
            	        break;
            	    case 3 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:372:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        {
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:372:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:372:12: ( tikzcoordinate_core1 )=> tikzcoordinate_core1
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_int2324);
            	        		tikzcoordinate_core1202 = tikzcoordinate_core1();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_core1202.Tree);

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

        IToken string_literal203 = null;
        simpletikzParser.tikznode_core_return tikznode_core204 = default(simpletikzParser.tikznode_core_return);


        object string_literal203_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:375:2: ( 'node' tikznode_core )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:375:4: 'node' tikznode_core
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal203=(IToken)Match(input,83,FOLLOW_83_in_tikznode_int2340); if (state.failed) return retval;
            	PushFollow(FOLLOW_tikznode_core_in_tikznode_int2343);
            	tikznode_core204 = tikznode_core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_core204.Tree);

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

        simpletikzParser.tikznode_decorator_return tikznode_decorator205 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikzstring_return tikzstring206 = default(simpletikzParser.tikzstring_return);


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
            	    int alt53 = 2;
            	    int LA53_0 = input.LA(1);

            	    if ( (LA53_0 == 55 || LA53_0 == 57 || LA53_0 == 84) )
            	    {
            	        alt53 = 1;
            	    }


            	    switch (alt53) 
            		{
            			case 1 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:378:4: tikznode_decorator
            			    {
            			    	PushFollow(FOLLOW_tikznode_decorator_in_tikznode_core2353);
            			    	tikznode_decorator205 = tikznode_decorator();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikznode_decorator.Add(tikznode_decorator205.Tree);

            			    }
            			    break;

            			default:
            			    goto loop53;
            	    }
            	} while (true);

            	loop53:
            		;	// Stops C# compiler whining that label 'loop53' has no statements

            	PushFollow(FOLLOW_tikzstring_in_tikznode_core2356);
            	tikzstring206 = tikzstring();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikzstring.Add(tikzstring206.Tree);


            	// AST REWRITE
            	// elements:          tikznode_decorator, tikzstring
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

        simpletikzParser.tikznode_decorator_return tikznode_decorator207 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikznode_decorator_return tikznode_decorator208 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikznode_decorator_return tikznode_decorator209 = default(simpletikzParser.tikznode_decorator_return);


        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:382:2: ( tikznode_decorator tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:382:6: tikznode_decorator tikznode_decorator tikznode_decorator
            {
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core32381);
            	tikznode_decorator207 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_decorator.Add(tikznode_decorator207.Tree);
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core32383);
            	tikznode_decorator208 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_decorator.Add(tikznode_decorator208.Tree);
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core32385);
            	tikznode_decorator209 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_decorator.Add(tikznode_decorator209.Tree);


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

        simpletikzParser.tikznode_decorator_return tikznode_decorator210 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikznode_decorator_return tikznode_decorator211 = default(simpletikzParser.tikznode_decorator_return);


        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:387:2: ( tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:388:4: tikznode_decorator tikznode_decorator
            {
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core22419);
            	tikznode_decorator210 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_decorator.Add(tikznode_decorator210.Tree);
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core22421);
            	tikznode_decorator211 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_decorator.Add(tikznode_decorator211.Tree);


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

        simpletikzParser.tikznode_decorator_return tikznode_decorator212 = default(simpletikzParser.tikznode_decorator_return);


        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:392:2: ( tikznode_decorator -> ^( IM_NODE tikznode_decorator ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:393:4: tikznode_decorator
            {
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core12454);
            	tikznode_decorator212 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_decorator.Add(tikznode_decorator212.Tree);


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

        IToken string_literal214 = null;
        IToken COMMAND215 = null;
        IToken string_literal216 = null;
        simpletikzParser.nodename_return nodename213 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_return coord217 = default(simpletikzParser.coord_return);

        simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare218 = default(simpletikzParser.tikz_options_dontcare_return);


        object string_literal214_tree=null;
        object COMMAND215_tree=null;
        object string_literal216_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:401:2: ( nodename | 'at' COMMAND | 'at' coord | tikz_options_dontcare )
            int alt54 = 4;
            switch ( input.LA(1) ) 
            {
            case 55:
            	{
                alt54 = 1;
                }
                break;
            case 84:
            	{
                int LA54_2 = input.LA(2);

                if ( (LA54_2 == COMMAND) )
                {
                    alt54 = 2;
                }
                else if ( (LA54_2 == 55 || (LA54_2 >= 92 && LA54_2 <= 93)) )
                {
                    alt54 = 3;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d54s2 =
                        new NoViableAltException("", 54, 2, input);

                    throw nvae_d54s2;
                }
                }
                break;
            case 57:
            	{
                alt54 = 4;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d54s0 =
            	        new NoViableAltException("", 54, 0, input);

            	    throw nvae_d54s0;
            }

            switch (alt54) 
            {
                case 1 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:401:6: nodename
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_nodename_in_tikznode_decorator2491);
                    	nodename213 = nodename();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, nodename213.Tree);

                    }
                    break;
                case 2 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:402:5: 'at' COMMAND
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal214=(IToken)Match(input,84,FOLLOW_84_in_tikznode_decorator2498); if (state.failed) return retval;
                    	COMMAND215=(IToken)Match(input,COMMAND,FOLLOW_COMMAND_in_tikznode_decorator2501); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{COMMAND215_tree = (object)adaptor.Create(COMMAND215);
                    		adaptor.AddChild(root_0, COMMAND215_tree);
                    	}

                    }
                    break;
                case 3 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:403:5: 'at' coord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal216=(IToken)Match(input,84,FOLLOW_84_in_tikznode_decorator2507); if (state.failed) return retval;
                    	PushFollow(FOLLOW_coord_in_tikznode_decorator2510);
                    	coord217 = coord();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, coord217.Tree);

                    }
                    break;
                case 4 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:404:5: tikz_options_dontcare
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_options_dontcare_in_tikznode_decorator2516);
                    	tikz_options_dontcare218 = tikz_options_dontcare();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_options_dontcare218.Tree);

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

        IToken char_literal219 = null;
        IToken char_literal223 = null;
        simpletikzParser.no_rlbracket_return no_rlbracket220 = default(simpletikzParser.no_rlbracket_return);

        simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare221 = default(simpletikzParser.tikz_options_dontcare_return);

        simpletikzParser.no_rlbracket_return no_rlbracket222 = default(simpletikzParser.no_rlbracket_return);


        object char_literal219_tree=null;
        object char_literal223_tree=null;
        RewriteRuleTokenStream stream_57 = new RewriteRuleTokenStream(adaptor,"token 57");
        RewriteRuleTokenStream stream_58 = new RewriteRuleTokenStream(adaptor,"token 58");
        RewriteRuleSubtreeStream stream_tikz_options_dontcare = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options_dontcare");
        RewriteRuleSubtreeStream stream_no_rlbracket = new RewriteRuleSubtreeStream(adaptor,"rule no_rlbracket");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:407:2: ( '[' ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* ']' -> ^( IM_OPTIONS ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:407:4: '[' ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* ']'
            {
            	char_literal219=(IToken)Match(input,57,FOLLOW_57_in_tikz_options_dontcare2526); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_57.Add(char_literal219);

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:407:8: ( no_rlbracket )*
            	do 
            	{
            	    int alt55 = 2;
            	    int LA55_0 = input.LA(1);

            	    if ( ((LA55_0 >= IM_PATH && LA55_0 <= 56) || (LA55_0 >= 59 && LA55_0 <= 97)) )
            	    {
            	        alt55 = 1;
            	    }


            	    switch (alt55) 
            		{
            			case 1 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:407:8: no_rlbracket
            			    {
            			    	PushFollow(FOLLOW_no_rlbracket_in_tikz_options_dontcare2528);
            			    	no_rlbracket220 = no_rlbracket();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_no_rlbracket.Add(no_rlbracket220.Tree);

            			    }
            			    break;

            			default:
            			    goto loop55;
            	    }
            	} while (true);

            	loop55:
            		;	// Stops C# compiler whining that label 'loop55' has no statements

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:407:22: ( tikz_options_dontcare ( no_rlbracket )* )*
            	do 
            	{
            	    int alt57 = 2;
            	    int LA57_0 = input.LA(1);

            	    if ( (LA57_0 == 57) )
            	    {
            	        alt57 = 1;
            	    }


            	    switch (alt57) 
            		{
            			case 1 :
            			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:407:23: tikz_options_dontcare ( no_rlbracket )*
            			    {
            			    	PushFollow(FOLLOW_tikz_options_dontcare_in_tikz_options_dontcare2532);
            			    	tikz_options_dontcare221 = tikz_options_dontcare();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikz_options_dontcare.Add(tikz_options_dontcare221.Tree);
            			    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:407:45: ( no_rlbracket )*
            			    	do 
            			    	{
            			    	    int alt56 = 2;
            			    	    int LA56_0 = input.LA(1);

            			    	    if ( ((LA56_0 >= IM_PATH && LA56_0 <= 56) || (LA56_0 >= 59 && LA56_0 <= 97)) )
            			    	    {
            			    	        alt56 = 1;
            			    	    }


            			    	    switch (alt56) 
            			    		{
            			    			case 1 :
            			    			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:407:45: no_rlbracket
            			    			    {
            			    			    	PushFollow(FOLLOW_no_rlbracket_in_tikz_options_dontcare2534);
            			    			    	no_rlbracket222 = no_rlbracket();
            			    			    	state.followingStackPointer--;
            			    			    	if (state.failed) return retval;
            			    			    	if ( state.backtracking==0 ) stream_no_rlbracket.Add(no_rlbracket222.Tree);

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop56;
            			    	    }
            			    	} while (true);

            			    	loop56:
            			    		;	// Stops C# compiler whining that label 'loop56' has no statements


            			    }
            			    break;

            			default:
            			    goto loop57;
            	    }
            	} while (true);

            	loop57:
            		;	// Stops C# compiler whining that label 'loop57' has no statements

            	char_literal223=(IToken)Match(input,58,FOLLOW_58_in_tikz_options_dontcare2539); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_58.Add(char_literal223);



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

        IToken set224 = null;

        object set224_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:410:2: (~ ( '[' | ']' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:410:4: ~ ( '[' | ']' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set224 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= 56) || (input.LA(1) >= 59 && input.LA(1) <= 97) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set224));
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

        IToken char_literal225 = null;
        IToken char_literal227 = null;
        simpletikzParser.idd_return idd226 = default(simpletikzParser.idd_return);


        object char_literal225_tree=null;
        object char_literal227_tree=null;
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:413:2: ( '(' idd ')' -> ^( IM_NODENAME idd ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:413:4: '(' idd ')'
            {
            	char_literal225=(IToken)Match(input,55,FOLLOW_55_in_nodename2574); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_55.Add(char_literal225);

            	PushFollow(FOLLOW_idd_in_nodename2576);
            	idd226 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_idd.Add(idd226.Tree);
            	char_literal227=(IToken)Match(input,56,FOLLOW_56_in_nodename2578); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_56.Add(char_literal227);



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

        IToken string_literal228 = null;
        IToken string_literal229 = null;
        simpletikzParser.size_return size230 = default(simpletikzParser.size_return);


        object string_literal228_tree=null;
        object string_literal229_tree=null;
        RewriteRuleTokenStream stream_85 = new RewriteRuleTokenStream(adaptor,"token 85");
        RewriteRuleTokenStream stream_86 = new RewriteRuleTokenStream(adaptor,"token 86");
        RewriteRuleSubtreeStream stream_size = new RewriteRuleSubtreeStream(adaptor,"rule size");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:420:2: ( ( 'circle' | 'ellipse' ) ( ( size )=> size )? ->)
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:420:4: ( 'circle' | 'ellipse' ) ( ( size )=> size )?
            {
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:420:4: ( 'circle' | 'ellipse' )
            	int alt58 = 2;
            	int LA58_0 = input.LA(1);

            	if ( (LA58_0 == 85) )
            	{
            	    alt58 = 1;
            	}
            	else if ( (LA58_0 == 86) )
            	{
            	    alt58 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d58s0 =
            	        new NoViableAltException("", 58, 0, input);

            	    throw nvae_d58s0;
            	}
            	switch (alt58) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:420:5: 'circle'
            	        {
            	        	string_literal228=(IToken)Match(input,85,FOLLOW_85_in_circle2603); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_85.Add(string_literal228);


            	        }
            	        break;
            	    case 2 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:420:16: 'ellipse'
            	        {
            	        	string_literal229=(IToken)Match(input,86,FOLLOW_86_in_circle2607); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_86.Add(string_literal229);


            	        }
            	        break;

            	}

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:420:27: ( ( size )=> size )?
            	int alt59 = 2;
            	alt59 = dfa59.Predict(input);
            	switch (alt59) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:420:28: ( size )=> size
            	        {
            	        	PushFollow(FOLLOW_size_in_circle2616);
            	        	size230 = size();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_size.Add(size230.Tree);

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

        IToken string_literal231 = null;
        IToken char_literal232 = null;
        IToken char_literal234 = null;
        IToken char_literal236 = null;
        IToken string_literal238 = null;
        IToken char_literal240 = null;
        IToken string_literal241 = null;
        IToken char_literal242 = null;
        IToken char_literal244 = null;
        IToken char_literal246 = null;
        IToken string_literal248 = null;
        IToken char_literal250 = null;
        IToken string_literal251 = null;
        simpletikzParser.numberunitorvariable_return numberunitorvariable233 = default(simpletikzParser.numberunitorvariable_return);

        simpletikzParser.numberunitorvariable_return numberunitorvariable235 = default(simpletikzParser.numberunitorvariable_return);

        simpletikzParser.numberunitorvariable_return numberunitorvariable237 = default(simpletikzParser.numberunitorvariable_return);

        simpletikzParser.numberunit_return numberunit239 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_part_return coord_part243 = default(simpletikzParser.coord_part_return);

        simpletikzParser.coord_part_return coord_part245 = default(simpletikzParser.coord_part_return);

        simpletikzParser.coord_part_return coord_part247 = default(simpletikzParser.coord_part_return);

        simpletikzParser.numberunit_return numberunit249 = default(simpletikzParser.numberunit_return);

        simpletikzParser.tikz_options_return tikz_options252 = default(simpletikzParser.tikz_options_return);


        object string_literal231_tree=null;
        object char_literal232_tree=null;
        object char_literal234_tree=null;
        object char_literal236_tree=null;
        object string_literal238_tree=null;
        object char_literal240_tree=null;
        object string_literal241_tree=null;
        object char_literal242_tree=null;
        object char_literal244_tree=null;
        object char_literal246_tree=null;
        object string_literal248_tree=null;
        object char_literal250_tree=null;
        object string_literal251_tree=null;
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleTokenStream stream_48 = new RewriteRuleTokenStream(adaptor,"token 48");
        RewriteRuleTokenStream stream_81 = new RewriteRuleTokenStream(adaptor,"token 81");
        RewriteRuleTokenStream stream_87 = new RewriteRuleTokenStream(adaptor,"token 87");
        RewriteRuleSubtreeStream stream_numberunitorvariable = new RewriteRuleSubtreeStream(adaptor,"rule numberunitorvariable");
        RewriteRuleSubtreeStream stream_coord_part = new RewriteRuleSubtreeStream(adaptor,"rule coord_part");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:423:2: ( 'arc' ( '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')' ) -> ^( IM_ARC ( numberunitorvariable )+ ( numberunit )? ) | 'arc' ( '(' coord_part ':' coord_part ':' coord_part ( 'and' numberunit )? ')' ) -> ^( IM_ARC ( coord_part )+ ( numberunit )? ) | 'arc' tikz_options -> ^( IM_DONTCARE ) )
            int alt62 = 3;
            alt62 = dfa62.Predict(input);
            switch (alt62) 
            {
                case 1 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:423:4: 'arc' ( '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')' )
                    {
                    	string_literal231=(IToken)Match(input,87,FOLLOW_87_in_arc2631); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_87.Add(string_literal231);

                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:423:10: ( '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')' )
                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:423:11: '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')'
                    	{
                    		char_literal232=(IToken)Match(input,55,FOLLOW_55_in_arc2634); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_55.Add(char_literal232);

                    		PushFollow(FOLLOW_numberunitorvariable_in_arc2636);
                    		numberunitorvariable233 = numberunitorvariable();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_numberunitorvariable.Add(numberunitorvariable233.Tree);
                    		char_literal234=(IToken)Match(input,48,FOLLOW_48_in_arc2638); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_48.Add(char_literal234);

                    		PushFollow(FOLLOW_numberunitorvariable_in_arc2640);
                    		numberunitorvariable235 = numberunitorvariable();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_numberunitorvariable.Add(numberunitorvariable235.Tree);
                    		char_literal236=(IToken)Match(input,48,FOLLOW_48_in_arc2642); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_48.Add(char_literal236);

                    		PushFollow(FOLLOW_numberunitorvariable_in_arc2644);
                    		numberunitorvariable237 = numberunitorvariable();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_numberunitorvariable.Add(numberunitorvariable237.Tree);
                    		// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:423:86: ( 'and' numberunit )?
                    		int alt60 = 2;
                    		int LA60_0 = input.LA(1);

                    		if ( (LA60_0 == 81) )
                    		{
                    		    alt60 = 1;
                    		}
                    		switch (alt60) 
                    		{
                    		    case 1 :
                    		        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:423:87: 'and' numberunit
                    		        {
                    		        	string_literal238=(IToken)Match(input,81,FOLLOW_81_in_arc2647); if (state.failed) return retval; 
                    		        	if ( state.backtracking==0 ) stream_81.Add(string_literal238);

                    		        	PushFollow(FOLLOW_numberunit_in_arc2649);
                    		        	numberunit239 = numberunit();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_numberunit.Add(numberunit239.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal240=(IToken)Match(input,56,FOLLOW_56_in_arc2653); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_56.Add(char_literal240);


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
                    	string_literal241=(IToken)Match(input,87,FOLLOW_87_in_arc2671); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_87.Add(string_literal241);

                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:424:10: ( '(' coord_part ':' coord_part ':' coord_part ( 'and' numberunit )? ')' )
                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:424:11: '(' coord_part ':' coord_part ':' coord_part ( 'and' numberunit )? ')'
                    	{
                    		char_literal242=(IToken)Match(input,55,FOLLOW_55_in_arc2674); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_55.Add(char_literal242);

                    		PushFollow(FOLLOW_coord_part_in_arc2676);
                    		coord_part243 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_part.Add(coord_part243.Tree);
                    		char_literal244=(IToken)Match(input,48,FOLLOW_48_in_arc2678); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_48.Add(char_literal244);

                    		PushFollow(FOLLOW_coord_part_in_arc2680);
                    		coord_part245 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_part.Add(coord_part245.Tree);
                    		char_literal246=(IToken)Match(input,48,FOLLOW_48_in_arc2682); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_48.Add(char_literal246);

                    		PushFollow(FOLLOW_coord_part_in_arc2684);
                    		coord_part247 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_part.Add(coord_part247.Tree);
                    		// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:424:56: ( 'and' numberunit )?
                    		int alt61 = 2;
                    		int LA61_0 = input.LA(1);

                    		if ( (LA61_0 == 81) )
                    		{
                    		    alt61 = 1;
                    		}
                    		switch (alt61) 
                    		{
                    		    case 1 :
                    		        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:424:57: 'and' numberunit
                    		        {
                    		        	string_literal248=(IToken)Match(input,81,FOLLOW_81_in_arc2687); if (state.failed) return retval; 
                    		        	if ( state.backtracking==0 ) stream_81.Add(string_literal248);

                    		        	PushFollow(FOLLOW_numberunit_in_arc2689);
                    		        	numberunit249 = numberunit();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_numberunit.Add(numberunit249.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal250=(IToken)Match(input,56,FOLLOW_56_in_arc2693); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_56.Add(char_literal250);


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
                    	string_literal251=(IToken)Match(input,87,FOLLOW_87_in_arc2711); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_87.Add(string_literal251);

                    	PushFollow(FOLLOW_tikz_options_in_arc2713);
                    	tikz_options252 = tikz_options();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_tikz_options.Add(tikz_options252.Tree);


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

        IToken char_literal253 = null;
        IToken string_literal255 = null;
        IToken char_literal257 = null;
        simpletikzParser.numberunit_return numberunit254 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit256 = default(simpletikzParser.numberunit_return);


        object char_literal253_tree=null;
        object string_literal255_tree=null;
        object char_literal257_tree=null;
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleTokenStream stream_81 = new RewriteRuleTokenStream(adaptor,"token 81");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:433:2: ( '(' numberunit ( 'and' numberunit )? ')' -> ^( IM_SIZE ( numberunit )* ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:433:6: '(' numberunit ( 'and' numberunit )? ')'
            {
            	char_literal253=(IToken)Match(input,55,FOLLOW_55_in_size2738); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_55.Add(char_literal253);

            	PushFollow(FOLLOW_numberunit_in_size2740);
            	numberunit254 = numberunit();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_numberunit.Add(numberunit254.Tree);
            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:433:21: ( 'and' numberunit )?
            	int alt63 = 2;
            	int LA63_0 = input.LA(1);

            	if ( (LA63_0 == 81) )
            	{
            	    alt63 = 1;
            	}
            	switch (alt63) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:433:22: 'and' numberunit
            	        {
            	        	string_literal255=(IToken)Match(input,81,FOLLOW_81_in_size2743); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_81.Add(string_literal255);

            	        	PushFollow(FOLLOW_numberunit_in_size2745);
            	        	numberunit256 = numberunit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_numberunit.Add(numberunit256.Tree);

            	        }
            	        break;

            	}

            	char_literal257=(IToken)Match(input,56,FOLLOW_56_in_size2749); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_56.Add(char_literal257);



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

        IToken char_literal258 = null;
        IToken char_literal261 = null;
        simpletikzParser.tikz_options_return tikz_options259 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.idd_return idd260 = default(simpletikzParser.idd_return);


        object char_literal258_tree=null;
        object char_literal261_tree=null;
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:441:2: ( '(' ( tikz_options )? idd ')' -> ^( IM_NODENAME idd ( tikz_options )? ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:441:4: '(' ( tikz_options )? idd ')'
            {
            	char_literal258=(IToken)Match(input,55,FOLLOW_55_in_coord_nodename2777); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_55.Add(char_literal258);

            	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:441:8: ( tikz_options )?
            	int alt64 = 2;
            	int LA64_0 = input.LA(1);

            	if ( (LA64_0 == 57) )
            	{
            	    alt64 = 1;
            	}
            	switch (alt64) 
            	{
            	    case 1 :
            	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:441:8: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_coord_nodename2779);
            	        	tikz_options259 = tikz_options();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_tikz_options.Add(tikz_options259.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_idd_in_coord_nodename2782);
            	idd260 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_idd.Add(idd260.Tree);
            	char_literal261=(IToken)Match(input,56,FOLLOW_56_in_coord_nodename2785); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_56.Add(char_literal261);



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

        IToken char_literal265 = null;
        IToken char_literal269 = null;
        IToken char_literal271 = null;
        IToken char_literal275 = null;
        IToken char_literal277 = null;
        IToken char_literal278 = null;
        simpletikzParser.coord_modifier_return coord_modifier262 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.coord_nodename_return coord_nodename263 = default(simpletikzParser.coord_nodename_return);

        simpletikzParser.coord_modifier_return coord_modifier264 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.numberunit_return numberunit266 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_sep_return coord_sep267 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.numberunit_return numberunit268 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_modifier_return coord_modifier270 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.coord_part_return coord_part272 = default(simpletikzParser.coord_part_return);

        simpletikzParser.coord_sep_return coord_sep273 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.coord_part_return coord_part274 = default(simpletikzParser.coord_part_return);

        simpletikzParser.coord_modifier_return coord_modifier276 = default(simpletikzParser.coord_modifier_return);


        object char_literal265_tree=null;
        object char_literal269_tree=null;
        object char_literal271_tree=null;
        object char_literal275_tree=null;
        object char_literal277_tree=null;
        object char_literal278_tree=null;
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleSubtreeStream stream_coord_part = new RewriteRuleSubtreeStream(adaptor,"rule coord_part");
        RewriteRuleSubtreeStream stream_coord_nodename = new RewriteRuleSubtreeStream(adaptor,"rule coord_nodename");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_coord_sep = new RewriteRuleSubtreeStream(adaptor,"rule coord_sep");
        RewriteRuleSubtreeStream stream_coord_modifier = new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:443:2: ( ( ( coord_modifier )? coord_nodename ) -> ^( IM_COORD ( coord_modifier )? coord_nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) | ( ( coord_modifier )? '(' ')' ) -> ^( IM_COORD ) )
            int alt69 = 4;
            alt69 = dfa69.Predict(input);
            switch (alt69) 
            {
                case 1 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:443:6: ( ( coord_modifier )? coord_nodename )
                    {
                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:443:6: ( ( coord_modifier )? coord_nodename )
                    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:443:8: ( coord_modifier )? coord_nodename
                    	{
                    		// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:443:8: ( coord_modifier )?
                    		int alt65 = 2;
                    		int LA65_0 = input.LA(1);

                    		if ( ((LA65_0 >= 92 && LA65_0 <= 93)) )
                    		{
                    		    alt65 = 1;
                    		}
                    		switch (alt65) 
                    		{
                    		    case 1 :
                    		        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:443:8: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord2811);
                    		        	coord_modifier262 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_coord_modifier.Add(coord_modifier262.Tree);

                    		        }
                    		        break;

                    		}

                    		PushFollow(FOLLOW_coord_nodename_in_coord2814);
                    		coord_nodename263 = coord_nodename();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_nodename.Add(coord_nodename263.Tree);

                    	}



                    	// AST REWRITE
                    	// elements:          coord_modifier, coord_nodename
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
                    		int alt66 = 2;
                    		int LA66_0 = input.LA(1);

                    		if ( ((LA66_0 >= 92 && LA66_0 <= 93)) )
                    		{
                    		    alt66 = 1;
                    		}
                    		switch (alt66) 
                    		{
                    		    case 1 :
                    		        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:444:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord2840);
                    		        	coord_modifier264 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_coord_modifier.Add(coord_modifier264.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal265=(IToken)Match(input,55,FOLLOW_55_in_coord2843); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_55.Add(char_literal265);

                    		PushFollow(FOLLOW_numberunit_in_coord2845);
                    		numberunit266 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_numberunit.Add(numberunit266.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord2847);
                    		coord_sep267 = coord_sep();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_sep.Add(coord_sep267.Tree);
                    		PushFollow(FOLLOW_numberunit_in_coord2849);
                    		numberunit268 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_numberunit.Add(numberunit268.Tree);
                    		char_literal269=(IToken)Match(input,56,FOLLOW_56_in_coord2851); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_56.Add(char_literal269);


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
                    		int alt67 = 2;
                    		int LA67_0 = input.LA(1);

                    		if ( ((LA67_0 >= 92 && LA67_0 <= 93)) )
                    		{
                    		    alt67 = 1;
                    		}
                    		switch (alt67) 
                    		{
                    		    case 1 :
                    		        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:445:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord2875);
                    		        	coord_modifier270 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_coord_modifier.Add(coord_modifier270.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal271=(IToken)Match(input,55,FOLLOW_55_in_coord2878); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_55.Add(char_literal271);

                    		PushFollow(FOLLOW_coord_part_in_coord2880);
                    		coord_part272 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_part.Add(coord_part272.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord2882);
                    		coord_sep273 = coord_sep();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_sep.Add(coord_sep273.Tree);
                    		PushFollow(FOLLOW_coord_part_in_coord2884);
                    		coord_part274 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_part.Add(coord_part274.Tree);
                    		char_literal275=(IToken)Match(input,56,FOLLOW_56_in_coord2886); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_56.Add(char_literal275);


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
                    		int alt68 = 2;
                    		int LA68_0 = input.LA(1);

                    		if ( ((LA68_0 >= 92 && LA68_0 <= 93)) )
                    		{
                    		    alt68 = 1;
                    		}
                    		switch (alt68) 
                    		{
                    		    case 1 :
                    		        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:446:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord2910);
                    		        	coord_modifier276 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_coord_modifier.Add(coord_modifier276.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal277=(IToken)Match(input,55,FOLLOW_55_in_coord2913); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_55.Add(char_literal277);

                    		char_literal278=(IToken)Match(input,56,FOLLOW_56_in_coord2915); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_56.Add(char_literal278);


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

        IToken char_literal281 = null;
        IToken char_literal285 = null;
        IToken char_literal287 = null;
        IToken char_literal291 = null;
        simpletikzParser.nodename_return nodename279 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_modifier_return coord_modifier280 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.numberunit_return numberunit282 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_sep_return coord_sep283 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.numberunit_return numberunit284 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_modifier_return coord_modifier286 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.coord_part_return coord_part288 = default(simpletikzParser.coord_part_return);

        simpletikzParser.coord_sep_return coord_sep289 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.coord_part_return coord_part290 = default(simpletikzParser.coord_part_return);


        object char_literal281_tree=null;
        object char_literal285_tree=null;
        object char_literal287_tree=null;
        object char_literal291_tree=null;
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleSubtreeStream stream_nodename = new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        RewriteRuleSubtreeStream stream_coord_part = new RewriteRuleSubtreeStream(adaptor,"rule coord_part");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_coord_sep = new RewriteRuleSubtreeStream(adaptor,"rule coord_sep");
        RewriteRuleSubtreeStream stream_coord_modifier = new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:449:2: ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) )
            int alt72 = 3;
            alt72 = dfa72.Predict(input);
            switch (alt72) 
            {
                case 1 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:449:6: nodename
                    {
                    	PushFollow(FOLLOW_nodename_in_coord_nooption2943);
                    	nodename279 = nodename();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_nodename.Add(nodename279.Tree);


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
                    		int alt70 = 2;
                    		int LA70_0 = input.LA(1);

                    		if ( ((LA70_0 >= 92 && LA70_0 <= 93)) )
                    		{
                    		    alt70 = 1;
                    		}
                    		switch (alt70) 
                    		{
                    		    case 1 :
                    		        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:450:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord_nooption2967);
                    		        	coord_modifier280 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_coord_modifier.Add(coord_modifier280.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal281=(IToken)Match(input,55,FOLLOW_55_in_coord_nooption2970); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_55.Add(char_literal281);

                    		PushFollow(FOLLOW_numberunit_in_coord_nooption2972);
                    		numberunit282 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_numberunit.Add(numberunit282.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord_nooption2974);
                    		coord_sep283 = coord_sep();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_sep.Add(coord_sep283.Tree);
                    		PushFollow(FOLLOW_numberunit_in_coord_nooption2976);
                    		numberunit284 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_numberunit.Add(numberunit284.Tree);
                    		char_literal285=(IToken)Match(input,56,FOLLOW_56_in_coord_nooption2978); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_56.Add(char_literal285);


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
                    		int alt71 = 2;
                    		int LA71_0 = input.LA(1);

                    		if ( ((LA71_0 >= 92 && LA71_0 <= 93)) )
                    		{
                    		    alt71 = 1;
                    		}
                    		switch (alt71) 
                    		{
                    		    case 1 :
                    		        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:451:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord_nooption3002);
                    		        	coord_modifier286 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_coord_modifier.Add(coord_modifier286.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal287=(IToken)Match(input,55,FOLLOW_55_in_coord_nooption3005); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_55.Add(char_literal287);

                    		PushFollow(FOLLOW_coord_part_in_coord_nooption3007);
                    		coord_part288 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_part.Add(coord_part288.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord_nooption3009);
                    		coord_sep289 = coord_sep();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_sep.Add(coord_sep289.Tree);
                    		PushFollow(FOLLOW_coord_part_in_coord_nooption3011);
                    		coord_part290 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_part.Add(coord_part290.Tree);
                    		char_literal291=(IToken)Match(input,56,FOLLOW_56_in_coord_nooption3013); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_56.Add(char_literal291);


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

        IToken char_literal293 = null;
        IToken char_literal295 = null;
        IToken char_literal297 = null;
        IToken char_literal299 = null;
        simpletikzParser.idd_return idd292 = default(simpletikzParser.idd_return);

        simpletikzParser.idd_return idd294 = default(simpletikzParser.idd_return);

        simpletikzParser.idd_return idd296 = default(simpletikzParser.idd_return);

        simpletikzParser.numberunit_return numberunit298 = default(simpletikzParser.numberunit_return);


        object char_literal293_tree=null;
        object char_literal295_tree=null;
        object char_literal297_tree=null;
        object char_literal299_tree=null;
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_47 = new RewriteRuleTokenStream(adaptor,"token 47");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:461:2: ( idd -> ^( IM_DONTCARE idd ) | '{' idd '}' -> ^( IM_DONTCARE '{' idd '}' ) | ( idd '=' numberunit ( ',' )? )+ -> ^( IM_DONTCARE ( idd '=' numberunit ( ',' )? )+ ) )
            int alt75 = 3;
            alt75 = dfa75.Predict(input);
            switch (alt75) 
            {
                case 1 :
                    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:461:4: idd
                    {
                    	PushFollow(FOLLOW_idd_in_coord_part3046);
                    	idd292 = idd();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_idd.Add(idd292.Tree);


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
                    	char_literal293=(IToken)Match(input,43,FOLLOW_43_in_coord_part3061); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_43.Add(char_literal293);

                    	PushFollow(FOLLOW_idd_in_coord_part3063);
                    	idd294 = idd();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_idd.Add(idd294.Tree);
                    	char_literal295=(IToken)Match(input,44,FOLLOW_44_in_coord_part3065); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_44.Add(char_literal295);



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
                    	int cnt74 = 0;
                    	do 
                    	{
                    	    int alt74 = 2;
                    	    int LA74_0 = input.LA(1);

                    	    if ( (LA74_0 == 81) )
                    	    {
                    	        int LA74_2 = input.LA(2);

                    	        if ( ((LA74_2 >= FLOAT_WO_EXP && LA74_2 <= INT)) )
                    	        {
                    	            int LA74_4 = input.LA(3);

                    	            if ( ((LA74_4 >= 60 && LA74_4 <= 65)) )
                    	            {
                    	                int LA74_5 = input.LA(4);

                    	                if ( ((LA74_5 >= IM_PATH && LA74_5 <= 42) || (LA74_5 >= 45 && LA74_5 <= 46) || (LA74_5 >= 51 && LA74_5 <= 54) || (LA74_5 >= 60 && LA74_5 <= 97)) )
                    	                {
                    	                    alt74 = 1;
                    	                }


                    	            }
                    	            else if ( ((LA74_4 >= IM_PATH && LA74_4 <= 42) || (LA74_4 >= 45 && LA74_4 <= 46) || (LA74_4 >= 51 && LA74_4 <= 54) || (LA74_4 >= 66 && LA74_4 <= 97)) )
                    	            {
                    	                alt74 = 1;
                    	            }


                    	        }
                    	        else if ( ((LA74_2 >= IM_PATH && LA74_2 <= COMMAND) || (LA74_2 >= WS && LA74_2 <= 42) || (LA74_2 >= 45 && LA74_2 <= 46) || (LA74_2 >= 51 && LA74_2 <= 54) || (LA74_2 >= 60 && LA74_2 <= 97)) )
                    	        {
                    	            alt74 = 1;
                    	        }


                    	    }
                    	    else if ( ((LA74_0 >= IM_PATH && LA74_0 <= 42) || LA74_0 == 46 || (LA74_0 >= 51 && LA74_0 <= 54) || (LA74_0 >= 60 && LA74_0 <= 80) || (LA74_0 >= 82 && LA74_0 <= 97)) )
                    	    {
                    	        alt74 = 1;
                    	    }


                    	    switch (alt74) 
                    		{
                    			case 1 :
                    			    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:463:5: idd '=' numberunit ( ',' )?
                    			    {
                    			    	PushFollow(FOLLOW_idd_in_coord_part3083);
                    			    	idd296 = idd();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking==0 ) stream_idd.Add(idd296.Tree);
                    			    	char_literal297=(IToken)Match(input,45,FOLLOW_45_in_coord_part3085); if (state.failed) return retval; 
                    			    	if ( state.backtracking==0 ) stream_45.Add(char_literal297);

                    			    	PushFollow(FOLLOW_numberunit_in_coord_part3087);
                    			    	numberunit298 = numberunit();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking==0 ) stream_numberunit.Add(numberunit298.Tree);
                    			    	// E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:463:24: ( ',' )?
                    			    	int alt73 = 2;
                    			    	int LA73_0 = input.LA(1);

                    			    	if ( (LA73_0 == 47) )
                    			    	{
                    			    	    alt73 = 1;
                    			    	}
                    			    	switch (alt73) 
                    			    	{
                    			    	    case 1 :
                    			    	        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:463:24: ','
                    			    	        {
                    			    	        	char_literal299=(IToken)Match(input,47,FOLLOW_47_in_coord_part3089); if (state.failed) return retval; 
                    			    	        	if ( state.backtracking==0 ) stream_47.Add(char_literal299);


                    			    	        }
                    			    	        break;

                    			    	}


                    			    }
                    			    break;

                    			default:
                    			    if ( cnt74 >= 1 ) goto loop74;
                    			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    		            EarlyExitException eee =
                    		                new EarlyExitException(74, input);
                    		            throw eee;
                    	    }
                    	    cnt74++;
                    	} while (true);

                    	loop74:
                    		;	// Stops C# compiler whinging that label 'loop74' has no statements



                    	// AST REWRITE
                    	// elements:          idd, 45, 47, numberunit
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

                    	    if ( !(stream_idd.HasNext() || stream_45.HasNext() || stream_numberunit.HasNext()) ) {
                    	        throw new RewriteEarlyExitException();
                    	    }
                    	    while ( stream_idd.HasNext() || stream_45.HasNext() || stream_numberunit.HasNext() )
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
                    	    stream_idd.Reset();
                    	    stream_45.Reset();
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

        IToken set300 = null;

        object set300_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:466:2: ( ( ',' | ':' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:466:4: ( ',' | ':' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set300 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 47 && input.LA(1) <= 48) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set300));
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

        IToken set301 = null;

        object set301_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:471:2: ( '--' | '->' | '|-' | '-|' | ID )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set301 = (IToken)input.LT(1);
            	if ( input.LA(1) == ID || (input.LA(1) >= 88 && input.LA(1) <= 91) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set301));
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

        IToken set302 = null;

        object set302_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:476:2: ( '+' | '++' )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set302 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 92 && input.LA(1) <= 93) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set302));
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

        IToken char_literal303 = null;

        object char_literal303_tree=null;
        RewriteRuleTokenStream stream_57 = new RewriteRuleTokenStream(adaptor,"token 57");

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:519:2: ( '[' -> ^( IM_STARTTAG '[' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:519:4: '['
            {
            	char_literal303=(IToken)Match(input,57,FOLLOW_57_in_squarebr_start3195); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_57.Add(char_literal303);



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
            	// 519:8: -> ^( IM_STARTTAG '[' )
            	{
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:519:11: ^( IM_STARTTAG '[' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

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

        IToken char_literal304 = null;

        object char_literal304_tree=null;
        RewriteRuleTokenStream stream_58 = new RewriteRuleTokenStream(adaptor,"token 58");

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:522:2: ( ']' -> ^( IM_ENDTAG ']' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:522:4: ']'
            {
            	char_literal304=(IToken)Match(input,58,FOLLOW_58_in_squarebr_end3213); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_58.Add(char_literal304);



            	// AST REWRITE
            	// elements:          58
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

            	    adaptor.AddChild(root_1, stream_58.NextNode());

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

        IToken char_literal305 = null;

        object char_literal305_tree=null;
        RewriteRuleTokenStream stream_59 = new RewriteRuleTokenStream(adaptor,"token 59");

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:525:2: ( ';' -> ^( IM_ENDTAG ';' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:525:4: ';'
            {
            	char_literal305=(IToken)Match(input,59,FOLLOW_59_in_semicolon_end3232); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_59.Add(char_literal305);



            	// AST REWRITE
            	// elements:          59
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

            	    adaptor.AddChild(root_1, stream_59.NextNode());

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

        IToken char_literal306 = null;

        object char_literal306_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:528:2: ( '{' -> ^( IM_STARTTAG '{' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:528:4: '{'
            {
            	char_literal306=(IToken)Match(input,43,FOLLOW_43_in_roundbr_start3250); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_43.Add(char_literal306);



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

        IToken char_literal307 = null;

        object char_literal307_tree=null;
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:531:2: ( '}' -> ^( IM_ENDTAG '}' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:531:4: '}'
            {
            	char_literal307=(IToken)Match(input,44,FOLLOW_44_in_roundbr_end3268); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_44.Add(char_literal307);



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

        IToken string_literal308 = null;
        IToken string_literal309 = null;

        object string_literal308_tree=null;
        object string_literal309_tree=null;
        RewriteRuleTokenStream stream_94 = new RewriteRuleTokenStream(adaptor,"token 94");
        RewriteRuleTokenStream stream_95 = new RewriteRuleTokenStream(adaptor,"token 95");

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:534:2: ( '..' 'controls' -> ^( IM_STARTTAG '..' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:534:4: '..' 'controls'
            {
            	string_literal308=(IToken)Match(input,94,FOLLOW_94_in_controls_start3286); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_94.Add(string_literal308);

            	string_literal309=(IToken)Match(input,95,FOLLOW_95_in_controls_start3288); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_95.Add(string_literal309);



            	// AST REWRITE
            	// elements:          94
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

            	    adaptor.AddChild(root_1, stream_94.NextNode());

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

        IToken string_literal310 = null;

        object string_literal310_tree=null;
        RewriteRuleTokenStream stream_94 = new RewriteRuleTokenStream(adaptor,"token 94");

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:537:2: ( '..' -> ^( IM_ENDTAG '..' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:537:4: '..'
            {
            	string_literal310=(IToken)Match(input,94,FOLLOW_94_in_controls_end3306); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_94.Add(string_literal310);



            	// AST REWRITE
            	// elements:          94
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

            	    adaptor.AddChild(root_1, stream_94.NextNode());

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

        IToken string_literal311 = null;
        IToken char_literal312 = null;

        object string_literal311_tree=null;
        object char_literal312_tree=null;
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:540:2: ( '\\\\tikzset' '{' -> ^( IM_STARTTAG ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:540:4: '\\\\tikzset' '{'
            {
            	string_literal311=(IToken)Match(input,41,FOLLOW_41_in_tikz_set_start3324); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_41.Add(string_literal311);

            	char_literal312=(IToken)Match(input,43,FOLLOW_43_in_tikz_set_start3326); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_43.Add(char_literal312);



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

        IToken string_literal313 = null;
        IToken char_literal314 = null;
        IToken string_literal315 = null;
        IToken char_literal316 = null;

        object string_literal313_tree=null;
        object char_literal314_tree=null;
        object string_literal315_tree=null;
        object char_literal316_tree=null;
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");
        RewriteRuleTokenStream stream_96 = new RewriteRuleTokenStream(adaptor,"token 96");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:543:2: ( '\\\\begin' '{' 'tikzpicture' '}' -> ^( IM_STARTTAG '\\\\begin' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:543:4: '\\\\begin' '{' 'tikzpicture' '}'
            {
            	string_literal313=(IToken)Match(input,39,FOLLOW_39_in_tikzpicture_start3345); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_39.Add(string_literal313);

            	char_literal314=(IToken)Match(input,43,FOLLOW_43_in_tikzpicture_start3347); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_43.Add(char_literal314);

            	string_literal315=(IToken)Match(input,96,FOLLOW_96_in_tikzpicture_start3349); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_96.Add(string_literal315);

            	char_literal316=(IToken)Match(input,44,FOLLOW_44_in_tikzpicture_start3351); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_44.Add(char_literal316);



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

        IToken string_literal317 = null;

        object string_literal317_tree=null;
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:546:2: ( '\\\\tikz' -> ^( IM_STARTTAG '\\\\tikz' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:546:4: '\\\\tikz'
            {
            	string_literal317=(IToken)Match(input,42,FOLLOW_42_in_tikz_start3369); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_42.Add(string_literal317);



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

        IToken string_literal318 = null;
        IToken char_literal319 = null;
        IToken string_literal320 = null;
        IToken char_literal321 = null;

        object string_literal318_tree=null;
        object char_literal319_tree=null;
        object string_literal320_tree=null;
        object char_literal321_tree=null;
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_66 = new RewriteRuleTokenStream(adaptor,"token 66");
        RewriteRuleTokenStream stream_96 = new RewriteRuleTokenStream(adaptor,"token 96");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:549:2: ( '\\\\end' '{' 'tikzpicture' '}' -> ^( IM_ENDTAG '\\\\end' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:549:4: '\\\\end' '{' 'tikzpicture' '}'
            {
            	string_literal318=(IToken)Match(input,66,FOLLOW_66_in_tikzpicture_end3387); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_66.Add(string_literal318);

            	char_literal319=(IToken)Match(input,43,FOLLOW_43_in_tikzpicture_end3389); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_43.Add(char_literal319);

            	string_literal320=(IToken)Match(input,96,FOLLOW_96_in_tikzpicture_end3391); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_96.Add(string_literal320);

            	char_literal321=(IToken)Match(input,44,FOLLOW_44_in_tikzpicture_end3393); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_44.Add(char_literal321);



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
            	// 549:34: -> ^( IM_ENDTAG '\\\\end' )
            	{
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:549:37: ^( IM_ENDTAG '\\\\end' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

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

        IToken string_literal322 = null;
        IToken char_literal323 = null;
        IToken string_literal324 = null;
        IToken char_literal325 = null;

        object string_literal322_tree=null;
        object char_literal323_tree=null;
        object string_literal324_tree=null;
        object char_literal325_tree=null;
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");
        RewriteRuleTokenStream stream_97 = new RewriteRuleTokenStream(adaptor,"token 97");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:552:2: ( '\\\\begin' '{' 'scope' '}' -> ^( IM_STARTTAG '\\\\begin' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:552:4: '\\\\begin' '{' 'scope' '}'
            {
            	string_literal322=(IToken)Match(input,39,FOLLOW_39_in_tikzscope_start3411); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_39.Add(string_literal322);

            	char_literal323=(IToken)Match(input,43,FOLLOW_43_in_tikzscope_start3413); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_43.Add(char_literal323);

            	string_literal324=(IToken)Match(input,97,FOLLOW_97_in_tikzscope_start3415); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_97.Add(string_literal324);

            	char_literal325=(IToken)Match(input,44,FOLLOW_44_in_tikzscope_start3417); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_44.Add(char_literal325);



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

        IToken string_literal326 = null;
        IToken char_literal327 = null;
        IToken string_literal328 = null;
        IToken char_literal329 = null;

        object string_literal326_tree=null;
        object char_literal327_tree=null;
        object string_literal328_tree=null;
        object char_literal329_tree=null;
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_66 = new RewriteRuleTokenStream(adaptor,"token 66");
        RewriteRuleTokenStream stream_97 = new RewriteRuleTokenStream(adaptor,"token 97");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:555:2: ( '\\\\end' '{' 'scope' '}' -> ^( IM_ENDTAG '\\\\end' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:555:4: '\\\\end' '{' 'scope' '}'
            {
            	string_literal326=(IToken)Match(input,66,FOLLOW_66_in_tikzscope_end3435); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_66.Add(string_literal326);

            	char_literal327=(IToken)Match(input,43,FOLLOW_43_in_tikzscope_end3437); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_43.Add(char_literal327);

            	string_literal328=(IToken)Match(input,97,FOLLOW_97_in_tikzscope_end3439); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_97.Add(string_literal328);

            	char_literal329=(IToken)Match(input,44,FOLLOW_44_in_tikzscope_end3441); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_44.Add(char_literal329);



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
            	// 555:28: -> ^( IM_ENDTAG '\\\\end' )
            	{
            	    // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:555:31: ^( IM_ENDTAG '\\\\end' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

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

        simpletikzParser.path_start_tag_return path_start_tag330 = default(simpletikzParser.path_start_tag_return);


        RewriteRuleSubtreeStream stream_path_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule path_start_tag");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:558:2: ( path_start_tag -> ^( IM_STARTTAG path_start_tag ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:558:4: path_start_tag
            {
            	PushFollow(FOLLOW_path_start_tag_in_path_start3460);
            	path_start_tag330 = path_start_tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_path_start_tag.Add(path_start_tag330.Tree);


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

        simpletikzParser.node_start_tag_return node_start_tag331 = default(simpletikzParser.node_start_tag_return);


        RewriteRuleSubtreeStream stream_node_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule node_start_tag");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:561:2: ( node_start_tag -> ^( IM_STARTTAG node_start_tag ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:561:4: node_start_tag
            {
            	PushFollow(FOLLOW_node_start_tag_in_node_start3478);
            	node_start_tag331 = node_start_tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_node_start_tag.Add(node_start_tag331.Tree);


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

        simpletikzParser.def_start_tag_return def_start_tag332 = default(simpletikzParser.def_start_tag_return);


        RewriteRuleSubtreeStream stream_def_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule def_start_tag");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:564:2: ( def_start_tag -> ^( IM_STARTTAG def_start_tag ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:564:4: def_start_tag
            {
            	PushFollow(FOLLOW_def_start_tag_in_def_start3496);
            	def_start_tag332 = def_start_tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_def_start_tag.Add(def_start_tag332.Tree);


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

        simpletikzParser.matrix_start_tag_return matrix_start_tag333 = default(simpletikzParser.matrix_start_tag_return);


        RewriteRuleSubtreeStream stream_matrix_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule matrix_start_tag");
        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:567:2: ( matrix_start_tag -> ^( IM_STARTTAG matrix_start_tag ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:567:4: matrix_start_tag
            {
            	PushFollow(FOLLOW_matrix_start_tag_in_matrix_start3514);
            	matrix_start_tag333 = matrix_start_tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_matrix_start_tag.Add(matrix_start_tag333.Tree);


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

        IToken string_literal334 = null;

        object string_literal334_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:570:2: ( '\\\\node' )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:570:4: '\\\\node'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal334=(IToken)Match(input,67,FOLLOW_67_in_node_start_tag3532); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal334_tree = (object)adaptor.Create(string_literal334);
            		adaptor.AddChild(root_0, string_literal334_tree);
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

        IToken string_literal335 = null;

        object string_literal335_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:573:2: ( '\\\\def' )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:573:4: '\\\\def'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal335=(IToken)Match(input,72,FOLLOW_72_in_def_start_tag3542); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal335_tree = (object)adaptor.Create(string_literal335);
            		adaptor.AddChild(root_0, string_literal335_tree);
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

        IToken string_literal336 = null;

        object string_literal336_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:576:2: ( '\\\\matrix' )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:576:4: '\\\\matrix'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal336=(IToken)Match(input,68,FOLLOW_68_in_matrix_start_tag3552); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal336_tree = (object)adaptor.Create(string_literal336);
            		adaptor.AddChild(root_0, string_literal336_tree);
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

        IToken string_literal337 = null;

        object string_literal337_tree=null;
        RewriteRuleTokenStream stream_69 = new RewriteRuleTokenStream(adaptor,"token 69");

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:579:2: ( '\\\\coordinate' -> ^( IM_STARTTAG '\\\\coordinate' ) )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:579:4: '\\\\coordinate'
            {
            	string_literal337=(IToken)Match(input,69,FOLLOW_69_in_coordinate_start3562); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_69.Add(string_literal337);



            	// AST REWRITE
            	// elements:          69
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

            	    adaptor.AddChild(root_1, stream_69.NextNode());

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

        IToken set338 = null;

        object set338_tree=null;

        try 
    	{
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:582:2: ( '\\\\draw' | '\\\\fill' | '\\\\path' | '\\\\clip' | '\\\\filldraw' | '\\\\pattern' | '\\\\shade' | '\\\\shadedraw' | '\\\\useasboundingbox' )
            // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set338 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 70 && input.LA(1) <= 71) || (input.LA(1) >= 73 && input.LA(1) <= 79) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set338));
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
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:46: ( 'n' 'args' )
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:197:47: 'n' 'args'
        {
        	Match(input,52,FOLLOW_52_in_synpred1_simpletikz715); if (state.failed) return ;
        	Match(input,53,FOLLOW_53_in_synpred1_simpletikz717); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred1_simpletikz"

    // $ANTLR start "synpred2_simpletikz"
    public void synpred2_simpletikz_fragment() {
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:331:5: ( coord )
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:331:6: coord
        {
        	PushFollow(FOLLOW_coord_in_synpred2_simpletikz1914);
        	coord();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred2_simpletikz"

    // $ANTLR start "synpred3_simpletikz"
    public void synpred3_simpletikz_fragment() {
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:359:8: ( tikzcoordinate_core3 )
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:359:9: tikzcoordinate_core3
        {
        	PushFollow(FOLLOW_tikzcoordinate_core3_in_synpred3_simpletikz2157);
        	tikzcoordinate_core3();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred3_simpletikz"

    // $ANTLR start "synpred4_simpletikz"
    public void synpred4_simpletikz_fragment() {
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:360:12: ( tikzcoordinate_core2 )
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:360:13: tikzcoordinate_core2
        {
        	PushFollow(FOLLOW_tikzcoordinate_core2_in_synpred4_simpletikz2176);
        	tikzcoordinate_core2();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred4_simpletikz"

    // $ANTLR start "synpred5_simpletikz"
    public void synpred5_simpletikz_fragment() {
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:361:12: ( tikzcoordinate_core1 )
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:361:13: tikzcoordinate_core1
        {
        	PushFollow(FOLLOW_tikzcoordinate_core1_in_synpred5_simpletikz2196);
        	tikzcoordinate_core1();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred5_simpletikz"

    // $ANTLR start "synpred6_simpletikz"
    public void synpred6_simpletikz_fragment() {
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:370:21: ( tikzcoordinate_core3 )
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:370:22: tikzcoordinate_core3
        {
        	PushFollow(FOLLOW_tikzcoordinate_core3_in_synpred6_simpletikz2281);
        	tikzcoordinate_core3();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred6_simpletikz"

    // $ANTLR start "synpred7_simpletikz"
    public void synpred7_simpletikz_fragment() {
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:371:12: ( tikzcoordinate_core2 )
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:371:13: tikzcoordinate_core2
        {
        	PushFollow(FOLLOW_tikzcoordinate_core2_in_synpred7_simpletikz2300);
        	tikzcoordinate_core2();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred7_simpletikz"

    // $ANTLR start "synpred8_simpletikz"
    public void synpred8_simpletikz_fragment() {
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:372:12: ( tikzcoordinate_core1 )
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:372:13: tikzcoordinate_core1
        {
        	PushFollow(FOLLOW_tikzcoordinate_core1_in_synpred8_simpletikz2320);
        	tikzcoordinate_core1();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred8_simpletikz"

    // $ANTLR start "synpred9_simpletikz"
    public void synpred9_simpletikz_fragment() {
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:420:28: ( size )
        // E:\\Promotion\\svn\\tikz\\tikzedt\\TikzParser\\simpletikz.g:420:29: size
        {
        	PushFollow(FOLLOW_size_in_synpred9_simpletikz2612);
        	size();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred9_simpletikz"

    // Delegated rules

   	public bool synpred9_simpletikz() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred9_simpletikz_fragment(); // can never throw exception
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
   	protected DFA35 dfa35;
   	protected DFA36 dfa36;
   	protected DFA37 dfa37;
   	protected DFA38 dfa38;
   	protected DFA45 dfa45;
   	protected DFA50 dfa50;
   	protected DFA52 dfa52;
   	protected DFA59 dfa59;
   	protected DFA62 dfa62;
   	protected DFA69 dfa69;
   	protected DFA72 dfa72;
   	protected DFA75 dfa75;
	private void InitializeCyclicDFAs()
	{
    	this.dfa10 = new DFA10(this);
    	this.dfa16 = new DFA16(this);
    	this.dfa35 = new DFA35(this);
    	this.dfa36 = new DFA36(this);
    	this.dfa37 = new DFA37(this);
    	this.dfa38 = new DFA38(this);
    	this.dfa45 = new DFA45(this);
    	this.dfa50 = new DFA50(this);
    	this.dfa52 = new DFA52(this);
    	this.dfa59 = new DFA59(this);
    	this.dfa62 = new DFA62(this);
    	this.dfa69 = new DFA69(this);
    	this.dfa72 = new DFA72(this);
    	this.dfa75 = new DFA75(this);






	    this.dfa45.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA45_SpecialStateTransition);
	    this.dfa50.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA50_SpecialStateTransition);
	    this.dfa52.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA52_SpecialStateTransition);
	    this.dfa59.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA59_SpecialStateTransition);




	}

    const string DFA10_eotS =
        "\x04\uffff";
    const string DFA10_eofS =
        "\x04\uffff";
    const string DFA10_minS =
        "\x02\x04\x02\uffff";
    const string DFA10_maxS =
        "\x02\x61\x02\uffff";
    const string DFA10_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA10_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA10_transitionS = {
            "\x27\x01\x03\uffff\x01\x01\x04\uffff\x04\x01\x05\uffff\x26"+
            "\x01",
            "\x27\x01\x03\x02\x01\x01\x01\x02\x01\uffff\x02\x03\x04\x01"+
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
        "\x04\x01\uffff\x01\x04\x01\uffff\x0c\x04\x01\uffff\x21\x04";
    const string DFA16_maxS =
        "\x01\x61\x01\x41\x01\x61\x01\uffff\x01\x3a\x01\x2b\x01\uffff\x01"+
        "\x61\x01\uffff\x01\x61\x01\uffff\x0c\x61\x01\uffff\x21\x61";
    const string DFA16_acceptS =
        "\x03\uffff\x01\x04\x02\uffff\x01\x02\x01\uffff\x01\x05\x01\uffff"+
        "\x01\x01\x0c\uffff\x01\x03\x21\uffff";
    const string DFA16_specialS =
        "\x39\uffff}>";
    static readonly string[] DFA16_transitionS = {
            "\x1a\x03\x02\x01\x0b\x03\x01\x02\x02\uffff\x01\x03\x04\uffff"+
            "\x04\x03\x05\uffff\x26\x03",
            "\x02\x06\x02\uffff\x01\x06\x01\x05\x09\uffff\x01\x06\x01\uffff"+
            "\x06\x04",
            "\x33\x08\x01\x07\x24\x08\x02\x09\x04\x08",
            "",
            "\x02\x06\x02\uffff\x01\x06\x01\x0a\x09\uffff\x01\x06",
            "\x02\x0a\x0b\uffff\x01\x08",
            "",
            "\x1a\x0d\x02\x0b\x0b\x0d\x01\x0c\x02\x08\x01\x0d\x04\x08\x04"+
            "\x0d\x05\x08\x26\x0d",
            "",
            "\x33\x08\x01\x0e\x2a\x08",
            "",
            "\x27\x0d\x02\x08\x01\x11\x01\x0d\x02\x12\x02\x08\x04\x0d\x01"+
            "\x08\x01\x0f\x03\x08\x06\x10\x20\x0d",
            "\x27\x13\x03\x08\x01\x13\x04\x08\x04\x13\x05\x08\x26\x13",
            "\x27\x0d\x02\x08\x01\x11\x01\x0d\x02\x14\x02\x08\x04\x0d\x01"+
            "\x08\x01\x0f\x03\x08\x26\x0d",
            "\x1a\x16\x02\x15\x0b\x16\x01\x0c\x02\x08\x01\x16\x04\x08\x04"+
            "\x16\x05\x08\x26\x16",
            "\x28\x08\x01\x17\x35\x08",
            "\x27\x0d\x02\x08\x01\x11\x01\x0d\x02\x12\x02\x08\x04\x0d\x01"+
            "\x08\x01\x0f\x03\x08\x26\x0d",
            "\x1a\x08\x02\x18\x42\x08",
            "\x1a\x1a\x02\x19\x0b\x1a\x01\x1b\x02\x08\x01\x1a\x04\x08\x04"+
            "\x1a\x05\x08\x26\x1a",
            "\x27\x13\x01\x08\x01\x1c\x01\x08\x01\x13\x04\x08\x04\x13\x05"+
            "\x08\x26\x13",
            "\x27\x1a\x01\x1b\x02\x08\x01\x1a\x04\x08\x04\x1a\x05\x08\x26"+
            "\x1a",
            "\x27\x16\x02\x08\x01\x11\x01\x16\x02\x12\x02\x08\x04\x16\x05"+
            "\x08\x06\x1d\x20\x16",
            "\x27\x16\x02\x08\x01\x11\x01\x16\x02\x14\x02\x08\x04\x16\x05"+
            "\x08\x26\x16",
            "",
            "\x27\x20\x03\x08\x01\x20\x01\x1f\x01\x14\x02\x08\x04\x20\x05"+
            "\x08\x06\x1e\x20\x20",
            "\x27\x1a\x02\x08\x01\x23\x01\x1a\x04\x08\x04\x1a\x01\x08\x01"+
            "\x22\x03\x08\x06\x21\x20\x1a",
            "\x27\x1a\x02\x08\x01\x23\x01\x1a\x04\x08\x04\x1a\x01\x08\x01"+
            "\x24\x03\x08\x26\x1a",
            "\x27\x25\x03\x08\x01\x25\x04\x08\x04\x25\x05\x08\x26\x25",
            "\x2b\x08\x02\x26\x31\x08",
            "\x27\x16\x02\x08\x01\x11\x01\x16\x02\x12\x02\x08\x04\x16\x05"+
            "\x08\x26\x16",
            "\x27\x20\x02\x08\x01\x11\x01\x20\x01\x1f\x01\x14\x02\x08\x04"+
            "\x20\x05\x08\x26\x20",
            "\x27\x27\x01\x1b\x02\x08\x01\x27\x02\x14\x02\x08\x04\x27\x05"+
            "\x08\x26\x27",
            "\x27\x20\x02\x08\x01\x11\x01\x20\x04\x08\x04\x20\x05\x08\x26"+
            "\x20",
            "\x27\x1a\x02\x08\x01\x23\x01\x1a\x04\x08\x04\x1a\x01\x08\x01"+
            "\x22\x03\x08\x26\x1a",
            "\x28\x08\x01\x17\x35\x08",
            "\x1a\x08\x02\x28\x42\x08",
            "\x28\x08\x01\x17\x35\x08",
            "\x27\x25\x01\x08\x01\x29\x01\x08\x01\x25\x04\x08\x04\x25\x05"+
            "\x08\x26\x25",
            "\x27\x2a\x01\x1b\x02\x08\x01\x2a\x04\x08\x04\x2a\x05\x08\x26"+
            "\x2a",
            "\x27\x27\x02\x08\x01\x2b\x01\x27\x04\x08\x04\x27\x01\x08\x01"+
            "\x24\x03\x08\x26\x27",
            "\x27\x2e\x03\x08\x01\x2e\x01\x2d\x03\x08\x04\x2e\x01\x08\x01"+
            "\x24\x03\x08\x06\x2c\x20\x2e",
            "\x34\x08\x01\x2f\x29\x08",
            "\x27\x2a\x02\x08\x01\x30\x01\x2a\x04\x08\x04\x2a\x01\x08\x01"+
            "\x2f\x03\x08\x26\x2a",
            "\x1a\x08\x02\x31\x42\x08",
            "\x27\x2e\x02\x08\x01\x23\x01\x2e\x01\x2d\x03\x08\x04\x2e\x01"+
            "\x08\x01\x24\x03\x08\x26\x2e",
            "\x27\x2e\x03\x08\x01\x2e\x04\x08\x04\x2e\x01\x08\x01\x24\x03"+
            "\x08\x26\x2e",
            "\x27\x2e\x02\x08\x01\x23\x01\x2e\x04\x08\x04\x2e\x05\x08\x26"+
            "\x2e",
            "\x28\x08\x01\x17\x35\x08",
            "\x1a\x08\x02\x32\x42\x08",
            "\x27\x35\x03\x08\x01\x35\x01\x34\x01\x14\x02\x08\x04\x35\x01"+
            "\x08\x01\x24\x03\x08\x06\x33\x20\x35",
            "\x27\x38\x03\x08\x01\x38\x01\x37\x03\x08\x04\x38\x01\x08\x01"+
            "\x2f\x03\x08\x06\x36\x20\x38",
            "\x27\x35\x02\x08\x01\x2b\x01\x35\x01\x34\x01\x14\x02\x08\x04"+
            "\x35\x01\x08\x01\x24\x03\x08\x26\x35",
            "\x27\x27\x01\x1b\x02\x08\x01\x27\x02\x14\x02\x08\x04\x27\x01"+
            "\x08\x01\x24\x03\x08\x26\x27",
            "\x27\x35\x02\x08\x01\x2b\x01\x35\x04\x08\x04\x35\x05\x08\x26"+
            "\x35",
            "\x27\x38\x02\x08\x01\x30\x01\x38\x01\x37\x03\x08\x04\x38\x01"+
            "\x08\x01\x2f\x03\x08\x26\x38",
            "\x27\x38\x03\x08\x01\x38\x04\x08\x04\x38\x01\x08\x01\x2f\x03"+
            "\x08\x26\x38",
            "\x27\x38\x02\x08\x01\x30\x01\x38\x04\x08\x04\x38\x05\x08\x26"+
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

    const string DFA35_eotS =
        "\x0e\uffff";
    const string DFA35_eofS =
        "\x0e\uffff";
    const string DFA35_minS =
        "\x01\x04\x01\x2b\x09\uffff\x01\x1c\x02\uffff";
    const string DFA35_maxS =
        "\x01\x61\x01\x2b\x09\uffff\x01\x61\x02\uffff";
    const string DFA35_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07\x01"+
        "\x08\x01\x0a\x01\x0b\x01\uffff\x01\x01\x01\x09";
    const string DFA35_specialS =
        "\x0e\uffff}>";
    static readonly string[] DFA35_transitionS = {
            "\x23\x0a\x01\x01\x01\x08\x01\x07\x0f\x0a\x01\uffff\x08\x0a"+
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
            "\x01\x0d\x44\uffff\x01\x0c",
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
            get { return "248:4: ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr )"; }
        }

    }

    const string DFA36_eotS =
        "\x11\uffff";
    const string DFA36_eofS =
        "\x11\uffff";
    const string DFA36_minS =
        "\x01\x04\x02\x2b\x08\uffff\x02\x1c\x04\uffff";
    const string DFA36_maxS =
        "\x01\x61\x02\x2b\x08\uffff\x02\x61\x04\uffff";
    const string DFA36_acceptS =
        "\x03\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07\x01"+
        "\x08\x01\x0b\x02\uffff\x01\x0c\x01\x0a\x01\x01\x01\x09";
    const string DFA36_specialS =
        "\x11\uffff}>";
    static readonly string[] DFA36_transitionS = {
            "\x23\x0a\x01\x02\x01\x09\x01\x08\x18\x0a\x01\x01\x01\x04\x01"+
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
            "\x01\x0e\x43\uffff\x02\x0d",
            "\x01\x10\x44\uffff\x01\x0f",
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
            get { return "()* loopback of 249:3: ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*"; }
        }

    }

    const string DFA37_eotS =
        "\x0e\uffff";
    const string DFA37_eofS =
        "\x0e\uffff";
    const string DFA37_minS =
        "\x01\x04\x01\x2b\x09\uffff\x01\x1c\x02\uffff";
    const string DFA37_maxS =
        "\x01\x61\x01\x2b\x09\uffff\x01\x61\x02\uffff";
    const string DFA37_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07\x01"+
        "\x08\x01\x0a\x01\x0b\x01\uffff\x01\x01\x01\x09";
    const string DFA37_specialS =
        "\x0e\uffff}>";
    static readonly string[] DFA37_transitionS = {
            "\x23\x0a\x01\x01\x01\x08\x01\x07\x01\x0a\x02\uffff\x0c\x0a"+
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
            "\x01\x0d\x44\uffff\x01\x0c",
            "",
            ""
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
            get { return "252:4: ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr2 )"; }
        }

    }

    const string DFA38_eotS =
        "\x0f\uffff";
    const string DFA38_eofS =
        "\x0f\uffff";
    const string DFA38_minS =
        "\x01\x04\x01\uffff\x01\x2b\x09\uffff\x01\x1c\x02\uffff";
    const string DFA38_maxS =
        "\x01\x61\x01\uffff\x01\x2b\x09\uffff\x01\x61\x02\uffff";
    const string DFA38_acceptS =
        "\x01\uffff\x01\x0c\x01\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x01\x08\x01\x0a\x01\x0b\x01\uffff\x01\x01\x01\x09";
    const string DFA38_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA38_transitionS = {
            "\x23\x0b\x01\x02\x01\x09\x01\x08\x01\x0b\x01\uffff\x01\x01"+
            "\x15\x0b\x01\x0a\x01\x04\x01\x06\x01\x07\x02\x03\x01\x05\x07"+
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
            "\x01\x0e\x44\uffff\x01\x0d",
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
            get { return "()* loopback of 253:3: ( tikzscope | tikzpath | tikznode_ext | tikzdef_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body2 )*"; }
        }

    }

    const string DFA45_eotS =
        "\x0e\uffff";
    const string DFA45_eofS =
        "\x0e\uffff";
    const string DFA45_minS =
        "\x01\x1c\x04\uffff\x01\x00\x08\uffff";
    const string DFA45_maxS =
        "\x01\x5e\x04\uffff\x01\x00\x08\uffff";
    const string DFA45_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\uffff\x01\x05\x01"+
        "\x06\x01\x07\x01\x08\x01\uffff\x01\x09\x01\x0b\x01\x0a";
    const string DFA45_specialS =
        "\x01\x00\x04\uffff\x01\x01\x08\uffff}>";
    static readonly string[] DFA45_transitionS = {
            "\x01\x0c\x01\x02\x0d\uffff\x01\x0b\x01\uffff\x01\x02\x09\uffff"+
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
            get { return "325:1: tikzpath_element_single : ( tikz_options | let_cmd_parts -> ^( IM_DONTCARE ( let_cmd_parts )+ ) | arc | ( coord )=> coord | controls | tikznode_int | tikzcoordinate_int | circle | roundbr_start ( tikzpath_element )* roundbr_end -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end ) | '(' ( tikzpath_element )* ')' -> ^( IM_PATH '(' ( tikzpath_element )* ')' ) | edgeop );"; }
        }

    }


    protected internal int DFA45_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA45_0 = input.LA(1);

                   	 
                   	int index45_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA45_0 == 57) ) { s = 1; }

                   	else if ( (LA45_0 == COMMAND || LA45_0 == 45 || LA45_0 == 61 || LA45_0 == 80) ) { s = 2; }

                   	else if ( (LA45_0 == 87) ) { s = 3; }

                   	else if ( ((LA45_0 >= 92 && LA45_0 <= 93)) && (synpred2_simpletikz()) ) { s = 4; }

                   	else if ( (LA45_0 == 55) ) { s = 5; }

                   	else if ( (LA45_0 == 94) ) { s = 6; }

                   	else if ( (LA45_0 == 83) ) { s = 7; }

                   	else if ( (LA45_0 == 82) ) { s = 8; }

                   	else if ( ((LA45_0 >= 85 && LA45_0 <= 86)) ) { s = 9; }

                   	else if ( (LA45_0 == 43) ) { s = 11; }

                   	else if ( (LA45_0 == ID || (LA45_0 >= 88 && LA45_0 <= 91)) ) { s = 12; }

                   	 
                   	input.Seek(index45_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA45_5 = input.LA(1);

                   	 
                   	int index45_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred2_simpletikz()) ) { s = 4; }

                   	else if ( (true) ) { s = 13; }

                   	 
                   	input.Seek(index45_5);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae =
            new NoViableAltException(dfa.Description, 45, _s, input);
        dfa.Error(nvae);
        throw nvae;
    }
    const string DFA50_eotS =
        "\x12\uffff";
    const string DFA50_eofS =
        "\x12\uffff";
    const string DFA50_minS =
        "\x01\x1c\x03\x00\x0e\uffff";
    const string DFA50_maxS =
        "\x01\x5e\x03\x00\x0e\uffff";
    const string DFA50_acceptS =
        "\x04\uffff\x01\x04\x0a\uffff\x01\x01\x01\x02\x01\x03";
    const string DFA50_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x0e\uffff}>";
    static readonly string[] DFA50_transitionS = {
            "\x02\x04\x0d\uffff\x01\x04\x01\uffff\x01\x04\x09\uffff\x01"+
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
            get { return "359:5: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?"; }
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
                   	if ( (synpred3_simpletikz()) ) { s = 15; }

                   	else if ( (synpred4_simpletikz()) ) { s = 16; }

                   	else if ( (synpred5_simpletikz()) ) { s = 17; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index50_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA50_2 = input.LA(1);

                   	 
                   	int index50_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred3_simpletikz()) ) { s = 15; }

                   	else if ( (synpred4_simpletikz()) ) { s = 16; }

                   	else if ( (synpred5_simpletikz()) ) { s = 17; }

                   	 
                   	input.Seek(index50_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA50_3 = input.LA(1);

                   	 
                   	int index50_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred3_simpletikz()) ) { s = 15; }

                   	else if ( (synpred4_simpletikz()) ) { s = 16; }

                   	else if ( (synpred5_simpletikz()) ) { s = 17; }

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
    const string DFA52_eotS =
        "\x15\uffff";
    const string DFA52_eofS =
        "\x15\uffff";
    const string DFA52_minS =
        "\x01\x1c\x03\x00\x11\uffff";
    const string DFA52_maxS =
        "\x01\x5e\x03\x00\x11\uffff";
    const string DFA52_acceptS =
        "\x04\uffff\x01\x04\x0d\uffff\x01\x01\x01\x02\x01\x03";
    const string DFA52_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x11\uffff}>";
    static readonly string[] DFA52_transitionS = {
            "\x02\x04\x0d\uffff\x03\x04\x01\uffff\x01\x04\x07\uffff\x01"+
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

    static readonly short[] DFA52_eot = DFA.UnpackEncodedString(DFA52_eotS);
    static readonly short[] DFA52_eof = DFA.UnpackEncodedString(DFA52_eofS);
    static readonly char[] DFA52_min = DFA.UnpackEncodedStringToUnsignedChars(DFA52_minS);
    static readonly char[] DFA52_max = DFA.UnpackEncodedStringToUnsignedChars(DFA52_maxS);
    static readonly short[] DFA52_accept = DFA.UnpackEncodedString(DFA52_acceptS);
    static readonly short[] DFA52_special = DFA.UnpackEncodedString(DFA52_specialS);
    static readonly short[][] DFA52_transition = DFA.UnpackEncodedStringArray(DFA52_transitionS);

    protected class DFA52 : DFA
    {
        public DFA52(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 52;
            this.eot = DFA52_eot;
            this.eof = DFA52_eof;
            this.min = DFA52_min;
            this.max = DFA52_max;
            this.accept = DFA52_accept;
            this.special = DFA52_special;
            this.transition = DFA52_transition;

        }

        override public string Description
        {
            get { return "370:18: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?"; }
        }

    }


    protected internal int DFA52_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA52_1 = input.LA(1);

                   	 
                   	int index52_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred6_simpletikz()) ) { s = 18; }

                   	else if ( (synpred7_simpletikz()) ) { s = 19; }

                   	else if ( (synpred8_simpletikz()) ) { s = 20; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index52_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA52_2 = input.LA(1);

                   	 
                   	int index52_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred6_simpletikz()) ) { s = 18; }

                   	else if ( (synpred7_simpletikz()) ) { s = 19; }

                   	else if ( (synpred8_simpletikz()) ) { s = 20; }

                   	 
                   	input.Seek(index52_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA52_3 = input.LA(1);

                   	 
                   	int index52_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred6_simpletikz()) ) { s = 18; }

                   	else if ( (synpred7_simpletikz()) ) { s = 19; }

                   	else if ( (synpred8_simpletikz()) ) { s = 20; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index52_3);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae =
            new NoViableAltException(dfa.Description, 52, _s, input);
        dfa.Error(nvae);
        throw nvae;
    }
    const string DFA59_eotS =
        "\x0a\uffff";
    const string DFA59_eofS =
        "\x0a\uffff";
    const string DFA59_minS =
        "\x01\x1c\x01\x04\x01\uffff\x01\x04\x01\x00\x02\x04\x01\uffff\x02"+
        "\x04";
    const string DFA59_maxS =
        "\x01\x5e\x01\x61\x01\uffff\x01\x61\x01\x00\x02\x61\x01\uffff\x02"+
        "\x61";
    const string DFA59_acceptS =
        "\x02\uffff\x01\x02\x04\uffff\x01\x01\x02\uffff";
    const string DFA59_specialS =
        "\x04\uffff\x01\x00\x05\uffff}>";
    static readonly string[] DFA59_transitionS = {
            "\x02\x02\x0d\uffff\x03\x02\x01\uffff\x01\x02\x07\uffff\x01"+
            "\x01\x02\x02\x01\uffff\x01\x02\x01\uffff\x01\x02\x12\uffff\x01"+
            "\x02\x01\uffff\x02\x02\x01\uffff\x0a\x02",
            "\x1a\x02\x02\x03\x0c\x02\x01\uffff\x02\x02\x04\uffff\x07\x02"+
            "\x02\uffff\x26\x02",
            "",
            "\x27\x02\x02\uffff\x04\x02\x02\uffff\x04\x02\x01\uffff\x01"+
            "\x04\x03\uffff\x06\x05\x0f\x02\x01\x06\x10\x02",
            "\x01\uffff",
            "\x27\x02\x02\uffff\x04\x02\x02\uffff\x04\x02\x01\uffff\x01"+
            "\x04\x03\uffff\x15\x02\x01\x06\x10\x02",
            "\x1a\x02\x02\x08\x0b\x02\x02\uffff\x04\x02\x02\uffff\x04\x02"+
            "\x01\uffff\x01\x02\x03\uffff\x26\x02",
            "",
            "\x27\x02\x02\uffff\x04\x02\x02\uffff\x04\x02\x01\uffff\x01"+
            "\x04\x03\uffff\x06\x09\x20\x02",
            "\x27\x02\x02\uffff\x04\x02\x02\uffff\x04\x02\x01\uffff\x01"+
            "\x04\x03\uffff\x26\x02"
    };

    static readonly short[] DFA59_eot = DFA.UnpackEncodedString(DFA59_eotS);
    static readonly short[] DFA59_eof = DFA.UnpackEncodedString(DFA59_eofS);
    static readonly char[] DFA59_min = DFA.UnpackEncodedStringToUnsignedChars(DFA59_minS);
    static readonly char[] DFA59_max = DFA.UnpackEncodedStringToUnsignedChars(DFA59_maxS);
    static readonly short[] DFA59_accept = DFA.UnpackEncodedString(DFA59_acceptS);
    static readonly short[] DFA59_special = DFA.UnpackEncodedString(DFA59_specialS);
    static readonly short[][] DFA59_transition = DFA.UnpackEncodedStringArray(DFA59_transitionS);

    protected class DFA59 : DFA
    {
        public DFA59(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 59;
            this.eot = DFA59_eot;
            this.eof = DFA59_eof;
            this.min = DFA59_min;
            this.max = DFA59_max;
            this.accept = DFA59_accept;
            this.special = DFA59_special;
            this.transition = DFA59_transition;

        }

        override public string Description
        {
            get { return "420:27: ( ( size )=> size )?"; }
        }

    }


    protected internal int DFA59_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA59_4 = input.LA(1);

                   	 
                   	int index59_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_simpletikz()) ) { s = 7; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index59_4);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae =
            new NoViableAltException(dfa.Description, 59, _s, input);
        dfa.Error(nvae);
        throw nvae;
    }
    const string DFA62_eotS =
        "\x14\uffff";
    const string DFA62_eofS =
        "\x14\uffff";
    const string DFA62_minS =
        "\x01\x57\x01\x37\x01\uffff\x02\x04\x01\uffff\x0a\x04\x01\uffff"+
        "\x03\x04";
    const string DFA62_maxS =
        "\x01\x57\x01\x39\x01\uffff\x02\x61\x01\uffff\x0a\x61\x01\uffff"+
        "\x03\x61";
    const string DFA62_acceptS =
        "\x02\uffff\x01\x03\x02\uffff\x01\x02\x0a\uffff\x01\x01\x03\uffff";
    const string DFA62_specialS =
        "\x14\uffff}>";
    static readonly string[] DFA62_transitionS = {
            "\x01\x01",
            "\x01\x03\x01\uffff\x01\x02",
            "",
            "\x19\x05\x01\x06\x02\x04\x0c\x05\x02\uffff\x01\x05\x04\uffff"+
            "\x04\x05\x05\uffff\x26\x05",
            "\x27\x05\x02\uffff\x02\x05\x01\uffff\x01\x08\x02\uffff\x04"+
            "\x05\x05\uffff\x06\x07\x20\x05",
            "",
            "\x27\x05\x02\uffff\x02\x05\x01\uffff\x01\x08\x02\uffff\x04"+
            "\x05\x05\uffff\x26\x05",
            "\x27\x05\x02\uffff\x02\x05\x01\uffff\x01\x08\x02\uffff\x04"+
            "\x05\x05\uffff\x26\x05",
            "\x19\x05\x01\x0a\x02\x09\x0c\x05\x02\uffff\x01\x05\x04\uffff"+
            "\x04\x05\x05\uffff\x26\x05",
            "\x27\x05\x02\uffff\x02\x05\x01\uffff\x01\x0c\x02\uffff\x04"+
            "\x05\x05\uffff\x06\x0b\x20\x05",
            "\x27\x05\x02\uffff\x02\x05\x01\uffff\x01\x0c\x02\uffff\x04"+
            "\x05\x05\uffff\x26\x05",
            "\x27\x05\x02\uffff\x02\x05\x01\uffff\x01\x0c\x02\uffff\x04"+
            "\x05\x05\uffff\x26\x05",
            "\x19\x05\x01\x0e\x02\x0d\x0c\x05\x02\uffff\x01\x05\x04\uffff"+
            "\x04\x05\x05\uffff\x26\x05",
            "\x27\x05\x02\uffff\x02\x05\x04\uffff\x04\x05\x01\uffff\x01"+
            "\x10\x03\uffff\x06\x11\x0f\x05\x01\x0f\x10\x05",
            "\x27\x05\x02\uffff\x02\x05\x04\uffff\x04\x05\x01\uffff\x01"+
            "\x10\x03\uffff\x15\x05\x01\x0f\x10\x05",
            "\x1a\x05\x02\x12\x0b\x05\x02\uffff\x02\x05\x04\uffff\x04\x05"+
            "\x01\uffff\x01\x05\x03\uffff\x26\x05",
            "",
            "\x27\x05\x02\uffff\x02\x05\x04\uffff\x04\x05\x01\uffff\x01"+
            "\x10\x03\uffff\x15\x05\x01\x0f\x10\x05",
            "\x27\x05\x02\uffff\x02\x05\x04\uffff\x04\x05\x01\uffff\x01"+
            "\x10\x03\uffff\x06\x13\x20\x05",
            "\x27\x05\x02\uffff\x02\x05\x04\uffff\x04\x05\x01\uffff\x01"+
            "\x10\x03\uffff\x26\x05"
    };

    static readonly short[] DFA62_eot = DFA.UnpackEncodedString(DFA62_eotS);
    static readonly short[] DFA62_eof = DFA.UnpackEncodedString(DFA62_eofS);
    static readonly char[] DFA62_min = DFA.UnpackEncodedStringToUnsignedChars(DFA62_minS);
    static readonly char[] DFA62_max = DFA.UnpackEncodedStringToUnsignedChars(DFA62_maxS);
    static readonly short[] DFA62_accept = DFA.UnpackEncodedString(DFA62_acceptS);
    static readonly short[] DFA62_special = DFA.UnpackEncodedString(DFA62_specialS);
    static readonly short[][] DFA62_transition = DFA.UnpackEncodedStringArray(DFA62_transitionS);

    protected class DFA62 : DFA
    {
        public DFA62(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 62;
            this.eot = DFA62_eot;
            this.eof = DFA62_eof;
            this.min = DFA62_min;
            this.max = DFA62_max;
            this.accept = DFA62_accept;
            this.special = DFA62_special;
            this.transition = DFA62_transition;

        }

        override public string Description
        {
            get { return "422:1: arc : ( 'arc' ( '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')' ) -> ^( IM_ARC ( numberunitorvariable )+ ( numberunit )? ) | 'arc' ( '(' coord_part ':' coord_part ':' coord_part ( 'and' numberunit )? ')' ) -> ^( IM_ARC ( coord_part )+ ( numberunit )? ) | 'arc' tikz_options -> ^( IM_DONTCARE ) );"; }
        }

    }

    const string DFA69_eotS =
        "\x0d\uffff";
    const string DFA69_eofS =
        "\x0d\uffff";
    const string DFA69_minS =
        "\x02\x37\x01\x04\x02\uffff\x02\x04\x01\uffff\x04\x04\x01\uffff";
    const string DFA69_maxS =
        "\x01\x5d\x01\x37\x01\x61\x02\uffff\x02\x61\x01\uffff\x04\x61\x01"+
        "\uffff";
    const string DFA69_acceptS =
        "\x03\uffff\x01\x04\x01\x01\x02\uffff\x01\x03\x04\uffff\x01\x02";
    const string DFA69_specialS =
        "\x0d\uffff}>";
    static readonly string[] DFA69_transitionS = {
            "\x01\x02\x24\uffff\x02\x01",
            "\x01\x02",
            "\x1a\x06\x02\x05\x0b\x06\x01\x07\x02\uffff\x01\x06\x04\uffff"+
            "\x04\x06\x01\uffff\x01\x03\x01\x04\x02\uffff\x26\x06",
            "",
            "",
            "\x27\x06\x02\uffff\x01\x07\x01\x06\x02\x09\x02\uffff\x04\x06"+
            "\x01\uffff\x01\x04\x03\uffff\x06\x08\x20\x06",
            "\x27\x06\x02\uffff\x01\x07\x01\x06\x02\x07\x02\uffff\x04\x06"+
            "\x01\uffff\x01\x04\x03\uffff\x26\x06",
            "",
            "\x27\x06\x02\uffff\x01\x07\x01\x06\x02\x09\x02\uffff\x04\x06"+
            "\x01\uffff\x01\x04\x03\uffff\x26\x06",
            "\x1a\x07\x02\x0a\x0c\x07\x02\uffff\x01\x07\x04\uffff\x04\x07"+
            "\x05\uffff\x26\x07",
            "\x27\x07\x02\uffff\x02\x07\x04\uffff\x04\x07\x01\uffff\x01"+
            "\x0c\x03\uffff\x06\x0b\x20\x07",
            "\x27\x07\x02\uffff\x02\x07\x04\uffff\x04\x07\x01\uffff\x01"+
            "\x0c\x03\uffff\x26\x07",
            ""
    };

    static readonly short[] DFA69_eot = DFA.UnpackEncodedString(DFA69_eotS);
    static readonly short[] DFA69_eof = DFA.UnpackEncodedString(DFA69_eofS);
    static readonly char[] DFA69_min = DFA.UnpackEncodedStringToUnsignedChars(DFA69_minS);
    static readonly char[] DFA69_max = DFA.UnpackEncodedStringToUnsignedChars(DFA69_maxS);
    static readonly short[] DFA69_accept = DFA.UnpackEncodedString(DFA69_acceptS);
    static readonly short[] DFA69_special = DFA.UnpackEncodedString(DFA69_specialS);
    static readonly short[][] DFA69_transition = DFA.UnpackEncodedStringArray(DFA69_transitionS);

    protected class DFA69 : DFA
    {
        public DFA69(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 69;
            this.eot = DFA69_eot;
            this.eof = DFA69_eof;
            this.min = DFA69_min;
            this.max = DFA69_max;
            this.accept = DFA69_accept;
            this.special = DFA69_special;
            this.transition = DFA69_transition;

        }

        override public string Description
        {
            get { return "442:1: coord : ( ( ( coord_modifier )? coord_nodename ) -> ^( IM_COORD ( coord_modifier )? coord_nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) | ( ( coord_modifier )? '(' ')' ) -> ^( IM_COORD ) );"; }
        }

    }

    const string DFA72_eotS =
        "\x0f\uffff";
    const string DFA72_eofS =
        "\x0f\uffff";
    const string DFA72_minS =
        "\x01\x37\x01\x04\x01\x37\x02\x04\x01\uffff\x03\x04\x01\uffff\x04"+
        "\x04\x01\uffff";
    const string DFA72_maxS =
        "\x01\x5d\x01\x61\x01\x37\x02\x61\x01\uffff\x03\x61\x01\uffff\x04"+
        "\x61\x01\uffff";
    const string DFA72_acceptS =
        "\x05\uffff\x01\x03\x03\uffff\x01\x01\x04\uffff\x01\x02";
    const string DFA72_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA72_transitionS = {
            "\x01\x01\x24\uffff\x02\x02",
            "\x1a\x04\x02\x03\x0b\x04\x01\x05\x02\uffff\x01\x04\x04\uffff"+
            "\x04\x04\x05\uffff\x26\x04",
            "\x01\x06",
            "\x27\x04\x02\uffff\x01\x05\x01\x04\x02\x08\x02\uffff\x04\x04"+
            "\x01\uffff\x01\x09\x03\uffff\x06\x07\x20\x04",
            "\x27\x04\x02\uffff\x01\x05\x01\x04\x02\x05\x02\uffff\x04\x04"+
            "\x01\uffff\x01\x09\x03\uffff\x26\x04",
            "",
            "\x1a\x05\x02\x0a\x0c\x05\x02\uffff\x01\x05\x04\uffff\x04\x05"+
            "\x05\uffff\x26\x05",
            "\x27\x04\x02\uffff\x01\x05\x01\x04\x02\x08\x02\uffff\x04\x04"+
            "\x01\uffff\x01\x09\x03\uffff\x26\x04",
            "\x1a\x05\x02\x0b\x0c\x05\x02\uffff\x01\x05\x04\uffff\x04\x05"+
            "\x05\uffff\x26\x05",
            "",
            "\x27\x05\x02\uffff\x02\x05\x02\x08\x02\uffff\x04\x05\x05\uffff"+
            "\x06\x0c\x20\x05",
            "\x27\x05\x02\uffff\x02\x05\x04\uffff\x04\x05\x01\uffff\x01"+
            "\x0e\x03\uffff\x06\x0d\x20\x05",
            "\x27\x05\x02\uffff\x02\x05\x02\x08\x02\uffff\x04\x05\x05\uffff"+
            "\x26\x05",
            "\x27\x05\x02\uffff\x02\x05\x04\uffff\x04\x05\x01\uffff\x01"+
            "\x0e\x03\uffff\x26\x05",
            ""
    };

    static readonly short[] DFA72_eot = DFA.UnpackEncodedString(DFA72_eotS);
    static readonly short[] DFA72_eof = DFA.UnpackEncodedString(DFA72_eofS);
    static readonly char[] DFA72_min = DFA.UnpackEncodedStringToUnsignedChars(DFA72_minS);
    static readonly char[] DFA72_max = DFA.UnpackEncodedStringToUnsignedChars(DFA72_maxS);
    static readonly short[] DFA72_accept = DFA.UnpackEncodedString(DFA72_acceptS);
    static readonly short[] DFA72_special = DFA.UnpackEncodedString(DFA72_specialS);
    static readonly short[][] DFA72_transition = DFA.UnpackEncodedStringArray(DFA72_transitionS);

    protected class DFA72 : DFA
    {
        public DFA72(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 72;
            this.eot = DFA72_eot;
            this.eof = DFA72_eof;
            this.min = DFA72_min;
            this.max = DFA72_max;
            this.accept = DFA72_accept;
            this.special = DFA72_special;
            this.transition = DFA72_transition;

        }

        override public string Description
        {
            get { return "448:1: coord_nooption : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) );"; }
        }

    }

    const string DFA75_eotS =
        "\x08\uffff";
    const string DFA75_eofS =
        "\x08\uffff";
    const string DFA75_minS =
        "\x02\x04\x02\uffff\x01\x04\x01\uffff\x02\x04";
    const string DFA75_maxS =
        "\x02\x61\x02\uffff\x01\x61\x01\uffff\x02\x61";
    const string DFA75_acceptS =
        "\x02\uffff\x01\x02\x01\x01\x01\uffff\x01\x03\x02\uffff";
    const string DFA75_specialS =
        "\x08\uffff}>";
    static readonly string[] DFA75_transitionS = {
            "\x27\x01\x01\x02\x02\uffff\x01\x01\x04\uffff\x04\x01\x05\uffff"+
            "\x26\x01",
            "\x27\x01\x02\uffff\x01\x05\x01\x01\x02\x03\x02\uffff\x04\x01"+
            "\x01\uffff\x01\x03\x03\uffff\x15\x01\x01\x04\x10\x01",
            "",
            "",
            "\x1a\x01\x02\x06\x0b\x01\x02\uffff\x01\x05\x01\x01\x02\x03"+
            "\x02\uffff\x04\x01\x01\uffff\x01\x03\x03\uffff\x15\x01\x01\x04"+
            "\x10\x01",
            "",
            "\x27\x01\x02\uffff\x01\x05\x01\x01\x02\x03\x02\uffff\x04\x01"+
            "\x01\uffff\x01\x03\x03\uffff\x06\x07\x0f\x01\x01\x04\x10\x01",
            "\x27\x01\x02\uffff\x01\x05\x01\x01\x02\x03\x02\uffff\x04\x01"+
            "\x01\uffff\x01\x03\x03\uffff\x15\x01\x01\x04\x10\x01"
    };

    static readonly short[] DFA75_eot = DFA.UnpackEncodedString(DFA75_eotS);
    static readonly short[] DFA75_eof = DFA.UnpackEncodedString(DFA75_eofS);
    static readonly char[] DFA75_min = DFA.UnpackEncodedStringToUnsignedChars(DFA75_minS);
    static readonly char[] DFA75_max = DFA.UnpackEncodedStringToUnsignedChars(DFA75_maxS);
    static readonly short[] DFA75_accept = DFA.UnpackEncodedString(DFA75_acceptS);
    static readonly short[] DFA75_special = DFA.UnpackEncodedString(DFA75_specialS);
    static readonly short[][] DFA75_transition = DFA.UnpackEncodedStringArray(DFA75_transitionS);

    protected class DFA75 : DFA
    {
        public DFA75(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 75;
            this.eot = DFA75_eot;
            this.eof = DFA75_eof;
            this.min = DFA75_min;
            this.max = DFA75_max;
            this.accept = DFA75_accept;
            this.special = DFA75_special;
            this.transition = DFA75_transition;

        }

        override public string Description
        {
            get { return "460:1: coord_part : ( idd -> ^( IM_DONTCARE idd ) | '{' idd '}' -> ^( IM_DONTCARE '{' idd '}' ) | ( idd '=' numberunit ( ',' )? )+ -> ^( IM_DONTCARE ( idd '=' numberunit ( ',' )? )+ ) );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_dontcare_preamble_in_tikzdocument257 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_styleorsetorcmd_in_tikzdocument261 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzdocument265 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpicture_in_tikzdocument270 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_dontcare_preamble_in_tikzdocument_wo_tikzpicture296 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_styleorsetorcmd_in_tikzdocument_wo_tikzpicture300 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzdocument_wo_tikzpicture304 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
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
    public static readonly BitSet FOLLOW_43_in_tikz_style420 = new BitSet(new ulong[]{0xF07847FFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_idd_in_tikz_style422 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_tikz_style424 = new BitSet(new ulong[]{0x0000600000000000UL});
    public static readonly BitSet FOLLOW_45_in_tikz_style427 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_46_in_tikz_style431 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikz_style434 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_squarebr_start_in_tikz_options456 = new BitSet(new ulong[]{0xF4784FFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_options459 = new BitSet(new ulong[]{0xF478CFFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_47_in_tikz_options462 = new BitSet(new ulong[]{0xF07847FFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_options464 = new BitSet(new ulong[]{0xF478CFFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_47_in_tikz_options468 = new BitSet(new ulong[]{0xF4784FFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikz_options473 = new BitSet(new ulong[]{0xF4784FFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_squarebr_end_in_tikz_options476 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_option_style_in_option501 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_option_kv_in_option510 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_option_kv524 = new BitSet(new ulong[]{0x0000200000000002UL});
    public static readonly BitSet FOLLOW_45_in_option_kv527 = new BitSet(new ulong[]{0xF0784FFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_iddornumberunitorstringorrange_in_option_kv529 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_tikzstring557 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_no_rlbrace_in_tikzstring559 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikzstring563 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_no_rlbrace_in_tikzstring565 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_44_in_tikzstring570 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_no_rlbrace593 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_range_in_iddornumberunitorstringorrange611 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_numberunit_in_iddornumberunitorstringorrange615 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_bracedcoord_in_iddornumberunitorstringorrange619 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_iddornumberunitorstringorrange623 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_number_in_iddornumberunitorstringorrange630 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_iddornumberunitorstringorrange633 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_tikzstring_in_iddornumberunitorstringorrange638 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_bracedcoord652 = new BitSet(new ulong[]{0x0080000000000000UL,0x0000000030000000UL});
    public static readonly BitSet FOLLOW_coord_nooption_in_bracedcoord656 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_bracedcoord658 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_numberunit_in_range669 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_range671 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_range673 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_option_style697 = new BitSet(new ulong[]{0x0006000000000000UL});
    public static readonly BitSet FOLLOW_49_in_option_style700 = new BitSet(new ulong[]{0x0050200000000000UL});
    public static readonly BitSet FOLLOW_50_in_option_style705 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_option_style707 = new BitSet(new ulong[]{0x0050200000000000UL});
    public static readonly BitSet FOLLOW_52_in_option_style722 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_option_style724 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_option_style727 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_option_style729 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_number_in_option_style731 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_option_style733 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_54_in_option_style740 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_option_style742 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_option_style746 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_option_style749 = new BitSet(new ulong[]{0xF078D7FFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_option_kv_in_option_style752 = new BitSet(new ulong[]{0x0000900000000000UL});
    public static readonly BitSet FOLLOW_47_in_option_style755 = new BitSet(new ulong[]{0xF07847FFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_option_kv_in_option_style757 = new BitSet(new ulong[]{0x0000900000000000UL});
    public static readonly BitSet FOLLOW_47_in_option_style764 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_option_style767 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_heavenknowswhythisisnecessary_in_idd802 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_idd_heavenknowswhythisisnecessary822 = new BitSet(new ulong[]{0xF07847FFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_ID_in_idd2882 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_numberunit_in_numberunitorvariable901 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COMMAND_in_numberunitorvariable906 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_number_in_numberunit919 = new BitSet(new ulong[]{0xF000000000000002UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_unit_in_numberunit921 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_number947 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unit0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_set_start_in_tikz_set1002 = new BitSet(new ulong[]{0xF07857FFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_set1005 = new BitSet(new ulong[]{0xF078D7FFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_47_in_tikz_set1008 = new BitSet(new ulong[]{0xF07847FFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_set1010 = new BitSet(new ulong[]{0xF078D7FFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_47_in_tikz_set1014 = new BitSet(new ulong[]{0xF07857FFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_roundbr_end_in_tikz_set1019 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzpicture_start_in_tikzpicture1051 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpicture1053 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzpicture1056 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpicture_end_in_tikzpicture1059 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_start_in_tikzpicture1084 = new BitSet(new ulong[]{0x0200080000000000UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpicture1087 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikzpicture1090 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzbody2_in_tikzpicture1092 = new BitSet(new ulong[]{0xF07857FFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_roundbr_end_in_tikzpicture1095 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody1127 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody1131 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_ext_in_tikzbody1135 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzdef_ext_in_tikzbody1139 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzmatrix_ext_in_tikzbody1143 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzcoordinate_ext_in_tikzbody1147 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody1151 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody1155 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody1159 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody1164 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_dontcare_body_nobr_in_tikzbody1169 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody1180 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody1184 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_ext_in_tikzbody1188 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzdef_ext_in_tikzbody1192 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzmatrix_ext_in_tikzbody1196 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzcoordinate_ext_in_tikzbody1200 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody1204 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody1208 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody1212 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody1217 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_dontcare_body_in_tikzbody1222 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody21238 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody21242 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_ext_in_tikzbody21246 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzdef_ext_in_tikzbody21250 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzmatrix_ext_in_tikzbody21254 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzcoordinate_ext_in_tikzbody21258 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody21262 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody21266 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody21270 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody21275 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_dontcare_body_nobr2_in_tikzbody21280 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody21291 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody21295 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_ext_in_tikzbody21299 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzdef_ext_in_tikzbody21303 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzmatrix_ext_in_tikzbody21307 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzcoordinate_ext_in_tikzbody21311 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody21315 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody21319 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody21323 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody21328 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_dontcare_body2_in_tikzbody21333 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body_nobr21350 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body21444 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body_nobr1534 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body1621 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_66_in_otherend1704 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_otherend1706 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_idd2_in_otherend1708 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_otherend1710 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzscope_start_in_tikzscope1737 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzscope1739 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzscope1742 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzscope_end_in_tikzscope1745 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_in_tikzpath1801 = new BitSet(new ulong[]{0x2A80280030000000UL,0x000000007FED0000UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath1803 = new BitSet(new ulong[]{0x2A80280030000000UL,0x000000007FED0000UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzpath1806 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_let_cmd_parts0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzpath_element_single_in_tikzpath_element1862 = new BitSet(new ulong[]{0x0000800000000002UL});
    public static readonly BitSet FOLLOW_47_in_tikzpath_element1864 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpath_element_single1882 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_let_cmd_parts_in_tikzpath_element_single1889 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arc_in_tikzpath_element_single1907 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_in_tikzpath_element_single1917 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_controls_in_tikzpath_element_single1923 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_int_in_tikzpath_element_single1929 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_int_in_tikzpath_element_single1935 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_circle_in_tikzpath_element_single1941 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_roundbr_start_in_tikzpath_element_single1948 = new BitSet(new ulong[]{0xF2F87FFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath_element_single1950 = new BitSet(new ulong[]{0xF2F87FFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_roundbr_end_in_tikzpath_element_single1953 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_tikzpath_element_single1973 = new BitSet(new ulong[]{0x2380280030000000UL,0x000000007FED0000UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath_element_single1975 = new BitSet(new ulong[]{0x2380280030000000UL,0x000000007FED0000UL});
    public static readonly BitSet FOLLOW_56_in_tikzpath_element_single1978 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_edgeop_in_tikzpath_element_single1997 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_controls_start_in_controls2012 = new BitSet(new ulong[]{0x0080000000000000UL,0x0000000030000000UL});
    public static readonly BitSet FOLLOW_coord_in_controls2014 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000040020000UL});
    public static readonly BitSet FOLLOW_81_in_controls2017 = new BitSet(new ulong[]{0x0080000000000000UL,0x0000000030000000UL});
    public static readonly BitSet FOLLOW_coord_in_controls2019 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000040020000UL});
    public static readonly BitSet FOLLOW_controls_end_in_controls2023 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_node_start_in_tikznode_ext2049 = new BitSet(new ulong[]{0x0280080000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_tikznode_core_in_tikznode_ext2051 = new BitSet(new ulong[]{0x2A80280030000000UL,0x000000007FED0000UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikznode_ext2053 = new BitSet(new ulong[]{0x2A80280030000000UL,0x000000007FED0000UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikznode_ext2056 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_def_start_in_tikzdef_ext2081 = new BitSet(new ulong[]{0x2A80280030000000UL,0x000000007FED0000UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzdef_ext2083 = new BitSet(new ulong[]{0x2A80280030000000UL,0x000000007FED0000UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzdef_ext2086 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrix_start_in_tikzmatrix_ext2111 = new BitSet(new ulong[]{0x0280080000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_tikznode_core_in_tikzmatrix_ext2113 = new BitSet(new ulong[]{0x2A80280030000000UL,0x000000007FED0000UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzmatrix_ext2115 = new BitSet(new ulong[]{0x2A80280030000000UL,0x000000007FED0000UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzmatrix_ext2118 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coordinate_start_in_tikzcoordinate_ext2146 = new BitSet(new ulong[]{0x2A80280030000000UL,0x000000007FFD0000UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_ext2161 = new BitSet(new ulong[]{0x2A80280030000000UL,0x000000007FED0000UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_ext2180 = new BitSet(new ulong[]{0x2A80280030000000UL,0x000000007FED0000UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_ext2200 = new BitSet(new ulong[]{0x2A80280030000000UL,0x000000007FED0000UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzcoordinate_ext2211 = new BitSet(new ulong[]{0x2A80280030000000UL,0x000000007FED0000UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzcoordinate_ext2214 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_82_in_tikzcoordinate_int2274 = new BitSet(new ulong[]{0x0280000000000002UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_int2285 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_int2304 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_int2324 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_83_in_tikznode_int2340 = new BitSet(new ulong[]{0x0280080000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_tikznode_core_in_tikznode_int2343 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikznode_core2353 = new BitSet(new ulong[]{0x0280080000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikznode_core2356 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core32381 = new BitSet(new ulong[]{0x0280000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core32383 = new BitSet(new ulong[]{0x0280000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core32385 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core22419 = new BitSet(new ulong[]{0x0280000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core22421 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core12454 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_tikznode_decorator2491 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_84_in_tikznode_decorator2498 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_COMMAND_in_tikznode_decorator2501 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_84_in_tikznode_decorator2507 = new BitSet(new ulong[]{0x0080000000000000UL,0x0000000030000000UL});
    public static readonly BitSet FOLLOW_coord_in_tikznode_decorator2510 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_options_dontcare_in_tikznode_decorator2516 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_57_in_tikz_options_dontcare2526 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_no_rlbracket_in_tikz_options_dontcare2528 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_options_dontcare_in_tikz_options_dontcare2532 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_no_rlbracket_in_tikz_options_dontcare2534 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_58_in_tikz_options_dontcare2539 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_no_rlbracket2557 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_nodename2574 = new BitSet(new ulong[]{0xF07847FFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_idd_in_nodename2576 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_nodename2578 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_85_in_circle2603 = new BitSet(new ulong[]{0x0080000000000002UL});
    public static readonly BitSet FOLLOW_86_in_circle2607 = new BitSet(new ulong[]{0x0080000000000002UL});
    public static readonly BitSet FOLLOW_size_in_circle2616 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_87_in_arc2631 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_arc2634 = new BitSet(new ulong[]{0x00000000E0000000UL});
    public static readonly BitSet FOLLOW_numberunitorvariable_in_arc2636 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_arc2638 = new BitSet(new ulong[]{0x00000000E0000000UL});
    public static readonly BitSet FOLLOW_numberunitorvariable_in_arc2640 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_arc2642 = new BitSet(new ulong[]{0x00000000E0000000UL});
    public static readonly BitSet FOLLOW_numberunitorvariable_in_arc2644 = new BitSet(new ulong[]{0x0100000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_81_in_arc2647 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_arc2649 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_arc2653 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_87_in_arc2671 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_arc2674 = new BitSet(new ulong[]{0xF0784FFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_arc2676 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_arc2678 = new BitSet(new ulong[]{0xF0784FFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_arc2680 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_arc2682 = new BitSet(new ulong[]{0xF0784FFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_arc2684 = new BitSet(new ulong[]{0x0100000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_81_in_arc2687 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_arc2689 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_arc2693 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_87_in_arc2711 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_tikz_options_in_arc2713 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_size2738 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_size2740 = new BitSet(new ulong[]{0x0100000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_81_in_size2743 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_size2745 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_size2749 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_coord_nodename2777 = new BitSet(new ulong[]{0xF27847FFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_options_in_coord_nodename2779 = new BitSet(new ulong[]{0xF07847FFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_idd_in_coord_nodename2782 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_coord_nodename2785 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord2811 = new BitSet(new ulong[]{0x0080000000000000UL,0x0000000030000000UL});
    public static readonly BitSet FOLLOW_coord_nodename_in_coord2814 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord2840 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_coord2843 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord2845 = new BitSet(new ulong[]{0x0001800000000000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord2847 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord2849 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_coord2851 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord2875 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_coord2878 = new BitSet(new ulong[]{0xF0784FFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_coord2880 = new BitSet(new ulong[]{0x0001800000000000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord2882 = new BitSet(new ulong[]{0xF0784FFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_coord2884 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_coord2886 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord2910 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_coord2913 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_coord2915 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_coord_nooption2943 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord_nooption2967 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_coord_nooption2970 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord_nooption2972 = new BitSet(new ulong[]{0x0001800000000000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord_nooption2974 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord_nooption2976 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_coord_nooption2978 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord_nooption3002 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_coord_nooption3005 = new BitSet(new ulong[]{0xF0784FFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_coord_nooption3007 = new BitSet(new ulong[]{0x0001800000000000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord_nooption3009 = new BitSet(new ulong[]{0xF0784FFFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_coord_nooption3011 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_coord_nooption3013 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_coord_part3046 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_coord_part3061 = new BitSet(new ulong[]{0xF07847FFFFFFFFF0UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_idd_in_coord_part3063 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_coord_part3065 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_coord_part3083 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_coord_part3085 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord_part3087 = new BitSet(new ulong[]{0xF078C7FFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_47_in_coord_part3089 = new BitSet(new ulong[]{0xF07847FFFFFFFFF2UL,0x00000003FFFFFFFFUL});
    public static readonly BitSet FOLLOW_set_in_coord_sep3121 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_edgeop0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_coord_modifier0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_57_in_squarebr_start3195 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_58_in_squarebr_end3213 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_59_in_semicolon_end3232 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_roundbr_start3250 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_44_in_roundbr_end3268 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_94_in_controls_start3286 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000080000000UL});
    public static readonly BitSet FOLLOW_95_in_controls_start3288 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_94_in_controls_end3306 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_41_in_tikz_set_start3324 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikz_set_start3326 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_tikzpicture_start3345 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikzpicture_start3347 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000100000000UL});
    public static readonly BitSet FOLLOW_96_in_tikzpicture_start3349 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_tikzpicture_start3351 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_42_in_tikz_start3369 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_66_in_tikzpicture_end3387 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikzpicture_end3389 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000100000000UL});
    public static readonly BitSet FOLLOW_96_in_tikzpicture_end3391 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_tikzpicture_end3393 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_tikzscope_start3411 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikzscope_start3413 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_97_in_tikzscope_start3415 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_tikzscope_start3417 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_66_in_tikzscope_end3435 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikzscope_end3437 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_97_in_tikzscope_end3439 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_tikzscope_end3441 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_tag_in_path_start3460 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_node_start_tag_in_node_start3478 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_def_start_tag_in_def_start3496 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrix_start_tag_in_matrix_start3514 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_67_in_node_start_tag3532 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_72_in_def_start_tag3542 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_68_in_matrix_start_tag3552 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_69_in_coordinate_start3562 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_path_start_tag0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_synpred1_simpletikz715 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_synpred1_simpletikz717 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_in_synpred2_simpletikz1914 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_synpred3_simpletikz2157 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_synpred4_simpletikz2176 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_synpred5_simpletikz2196 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_synpred6_simpletikz2281 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_synpred7_simpletikz2300 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_synpred8_simpletikz2320 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_size_in_synpred9_simpletikz2612 = new BitSet(new ulong[]{0x0000000000000002UL});

}
