// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g 2011-10-05 15:44:49

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
		"'\\\\filldraw'", 
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

    public const int T__68 = 68;
    public const int T__69 = 69;
    public const int T__66 = 66;
    public const int EXPONENT = 34;
    public const int T__67 = 67;
    public const int T__64 = 64;
    public const int TIKZEDT_CMD_COMMENT = 27;
    public const int IM_STARTTAG = 13;
    public const int T__65 = 65;
    public const int T__62 = 62;
    public const int T__63 = 63;
    public const int IM_CONTROLS = 23;
    public const int IM_PATH = 4;
    public const int IM_ID = 18;
    public const int IM_DONTCARE = 25;
    public const int SOMETHING = 37;
    public const int ID = 28;
    public const int T__61 = 61;
    public const int EOF = -1;
    public const int T__60 = 60;
    public const int MATHSTRING = 36;
    public const int IM_ARC = 26;
    public const int COMMAND = 29;
    public const int IM_ENDTAG = 14;
    public const int IM_USETIKZLIB = 20;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int IM_DOCUMENT = 11;
    public const int T__58 = 58;
    public const int ESC_SEQ = 35;
    public const int IM_STRING = 21;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int IM_TIKZSET = 19;
    public const int T__59 = 59;
    public const int IM_OPTION_KV = 17;
    public const int COMMENT = 33;
    public const int T__50 = 50;
    public const int IM_TIKZEDT_CMD = 24;
    public const int SOMETHING1 = 38;
    public const int T__42 = 42;
    public const int T__43 = 43;
    public const int T__40 = 40;
    public const int T__41 = 41;
    public const int IM_OPTIONS = 15;
    public const int T__80 = 80;
    public const int T__46 = 46;
    public const int T__81 = 81;
    public const int T__47 = 47;
    public const int IM_OPTION_STYLE = 16;
    public const int T__82 = 82;
    public const int T__44 = 44;
    public const int T__83 = 83;
    public const int T__45 = 45;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int IM_COORD = 6;
    public const int IM_PICTURE = 10;
    public const int INT = 31;
    public const int T__85 = 85;
    public const int T__84 = 84;
    public const int T__87 = 87;
    public const int T__86 = 86;
    public const int IM_NODE = 5;
    public const int T__88 = 88;
    public const int IM_STYLE = 22;
    public const int IM_SCOPE = 12;
    public const int IM_NUMBERUNIT = 9;
    public const int WS = 32;
    public const int T__71 = 71;
    public const int T__72 = 72;
    public const int T__70 = 70;
    public const int T__39 = 39;
    public const int IM_SIZE = 7;
    public const int T__76 = 76;
    public const int T__75 = 75;
    public const int T__74 = 74;
    public const int IM_NODENAME = 8;
    public const int T__73 = 73;
    public const int T__79 = 79;
    public const int FLOAT_WO_EXP = 30;
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
		get { return "C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g"; }
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:140:1: tikzdocument : ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* tikzpicture ( . )* -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture ) ;
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:141:2: ( ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* tikzpicture ( . )* -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:141:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* tikzpicture ( . )*
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:141:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )*
            	do 
            	{
            	    int alt1 = 4;
            	    switch ( input.LA(1) ) 
            	    {
            	    case 39:
            	    	{
            	        int LA1_1 = input.LA(2);

            	        if ( (LA1_1 == 42) )
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
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:141:5: dontcare_preamble
            			    {
            			    	PushFollow(FOLLOW_dontcare_preamble_in_tikzdocument257);
            			    	dontcare_preamble1 = dontcare_preamble();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_dontcare_preamble.Add(dontcare_preamble1.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:141:25: tikz_styleorsetorcmd
            			    {
            			    	PushFollow(FOLLOW_tikz_styleorsetorcmd_in_tikzdocument261);
            			    	tikz_styleorsetorcmd2 = tikz_styleorsetorcmd();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikz_styleorsetorcmd.Add(tikz_styleorsetorcmd2.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:141:48: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzdocument265);
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

            	PushFollow(FOLLOW_tikzpicture_in_tikzdocument270);
            	tikzpicture4 = tikzpicture();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzpicture.Add(tikzpicture4.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:141:74: ( . )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= IM_PATH && LA2_0 <= 88)) )
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
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:141:74: .
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
            	// 141:77: -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:141:80: ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DOCUMENT, "IM_DOCUMENT"), root_1);

            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:141:94: ( tikz_styleorsetorcmd )*
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:144:1: tikzdocument_wo_tikzpicture : ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* EOF -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* ) ;
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:145:2: ( ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* EOF -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:145:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* EOF
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:145:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )*
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
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:145:5: dontcare_preamble
            			    {
            			    	PushFollow(FOLLOW_dontcare_preamble_in_tikzdocument_wo_tikzpicture296);
            			    	dontcare_preamble6 = dontcare_preamble();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_dontcare_preamble.Add(dontcare_preamble6.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:145:25: tikz_styleorsetorcmd
            			    {
            			    	PushFollow(FOLLOW_tikz_styleorsetorcmd_in_tikzdocument_wo_tikzpicture300);
            			    	tikz_styleorsetorcmd7 = tikz_styleorsetorcmd();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikz_styleorsetorcmd.Add(tikz_styleorsetorcmd7.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:145:48: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzdocument_wo_tikzpicture304);
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

            	EOF9=(IToken)Match(input,EOF,FOLLOW_EOF_in_tikzdocument_wo_tikzpicture309); if (state.failed) return retval; 
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
            	// 145:66: -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:145:69: ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DOCUMENT, "IM_DOCUMENT"), root_1);

            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:145:83: ( tikz_styleorsetorcmd )*
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:148:1: tikz_cmd_comment : TIKZEDT_CMD_COMMENT -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT ) ;
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:149:2: ( TIKZEDT_CMD_COMMENT -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:149:4: TIKZEDT_CMD_COMMENT
            {
            	TIKZEDT_CMD_COMMENT10=(IToken)Match(input,TIKZEDT_CMD_COMMENT,FOLLOW_TIKZEDT_CMD_COMMENT_in_tikz_cmd_comment330); if (state.failed) return retval; 
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
            	// 149:27: -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:149:30: ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:152:1: tikz_styleorsetorcmd : ( tikz_style | tikz_set | tikz_cmd_comment );
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:153:2: ( tikz_style | tikz_set | tikz_cmd_comment )
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
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:153:4: tikz_style
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
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:153:17: tikz_set
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
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:153:28: tikz_cmd_comment
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:156:1: dontcare_preamble : ~ ( '\\\\begin' | '\\\\tikzstyle' | '\\\\tikzset' | TIKZEDT_CMD_COMMENT ) ;
    public simpletikzParser.dontcare_preamble_return dontcare_preamble() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_preamble_return retval = new simpletikzParser.dontcare_preamble_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set14 = null;

        object set14_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:157:2: (~ ( '\\\\begin' | '\\\\tikzstyle' | '\\\\tikzset' | TIKZEDT_CMD_COMMENT ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:157:4: ~ ( '\\\\begin' | '\\\\tikzstyle' | '\\\\tikzset' | TIKZEDT_CMD_COMMENT )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set14 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= IM_ARC) || (input.LA(1) >= ID && input.LA(1) <= SOMETHING1) || (input.LA(1) >= 42 && input.LA(1) <= 88) ) 
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:159:1: otherbegin : '\\\\begin' '{' idd2 '}' ;
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:160:2: ( '\\\\begin' '{' idd2 '}' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:160:4: '\\\\begin' '{' idd2 '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal15=(IToken)Match(input,39,FOLLOW_39_in_otherbegin396); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal15_tree = (object)adaptor.Create(string_literal15);
            		adaptor.AddChild(root_0, string_literal15_tree);
            	}
            	char_literal16=(IToken)Match(input,42,FOLLOW_42_in_otherbegin398); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal16_tree = (object)adaptor.Create(char_literal16);
            		adaptor.AddChild(root_0, char_literal16_tree);
            	}
            	PushFollow(FOLLOW_idd2_in_otherbegin400);
            	idd217 = idd2();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idd217.Tree);
            	char_literal18=(IToken)Match(input,43,FOLLOW_43_in_otherbegin402); if (state.failed) return retval;
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:163:1: tikz_style : '\\\\tikzstyle' '{' idd '}' ( '=' | '+=' ) tikz_options -> ^( IM_STYLE idd tikz_options ) ;
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
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:164:2: ( '\\\\tikzstyle' '{' idd '}' ( '=' | '+=' ) tikz_options -> ^( IM_STYLE idd tikz_options ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:164:4: '\\\\tikzstyle' '{' idd '}' ( '=' | '+=' ) tikz_options
            {
            	string_literal19=(IToken)Match(input,40,FOLLOW_40_in_tikz_style414); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_40.Add(string_literal19);

            	char_literal20=(IToken)Match(input,42,FOLLOW_42_in_tikz_style416); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_42.Add(char_literal20);

            	PushFollow(FOLLOW_idd_in_tikz_style418);
            	idd21 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idd.Add(idd21.Tree);
            	char_literal22=(IToken)Match(input,43,FOLLOW_43_in_tikz_style420); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_43.Add(char_literal22);

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:164:30: ( '=' | '+=' )
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == 44) )
            	{
            	    alt5 = 1;
            	}
            	else if ( (LA5_0 == 45) )
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
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:164:31: '='
            	        {
            	        	char_literal23=(IToken)Match(input,44,FOLLOW_44_in_tikz_style423); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_44.Add(char_literal23);


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:164:37: '+='
            	        {
            	        	string_literal24=(IToken)Match(input,45,FOLLOW_45_in_tikz_style427); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_45.Add(string_literal24);


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikz_options_in_tikz_style430);
            	tikz_options25 = tikz_options();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikz_options.Add(tikz_options25.Tree);


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
            	// 164:56: -> ^( IM_STYLE idd tikz_options )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:164:59: ^( IM_STYLE idd tikz_options )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:167:1: tikz_options : squarebr_start ( option ( ',' option )* ( ',' )? )? ( tikzstring )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) ;
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
        RewriteRuleTokenStream stream_46 = new RewriteRuleTokenStream(adaptor,"token 46");
        RewriteRuleSubtreeStream stream_squarebr_start = new RewriteRuleSubtreeStream(adaptor,"rule squarebr_start");
        RewriteRuleSubtreeStream stream_tikzstring = new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_squarebr_end = new RewriteRuleSubtreeStream(adaptor,"rule squarebr_end");
        RewriteRuleSubtreeStream stream_option = new RewriteRuleSubtreeStream(adaptor,"rule option");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:168:2: ( squarebr_start ( option ( ',' option )* ( ',' )? )? ( tikzstring )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:168:5: squarebr_start ( option ( ',' option )* ( ',' )? )? ( tikzstring )? squarebr_end
            {
            	PushFollow(FOLLOW_squarebr_start_in_tikz_options452);
            	squarebr_start26 = squarebr_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_squarebr_start.Add(squarebr_start26.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:168:20: ( option ( ',' option )* ( ',' )? )?
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( ((LA8_0 >= IM_PATH && LA8_0 <= 41) || LA8_0 == 45 || LA8_0 == 50 || (LA8_0 >= 56 && LA8_0 <= 88)) )
            	{
            	    alt8 = 1;
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:168:21: option ( ',' option )* ( ',' )?
            	        {
            	        	PushFollow(FOLLOW_option_in_tikz_options455);
            	        	option27 = option();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_option.Add(option27.Tree);
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:168:28: ( ',' option )*
            	        	do 
            	        	{
            	        	    int alt6 = 2;
            	        	    int LA6_0 = input.LA(1);

            	        	    if ( (LA6_0 == 46) )
            	        	    {
            	        	        int LA6_1 = input.LA(2);

            	        	        if ( ((LA6_1 >= IM_PATH && LA6_1 <= 41) || LA6_1 == 45 || LA6_1 == 50 || (LA6_1 >= 56 && LA6_1 <= 88)) )
            	        	        {
            	        	            alt6 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt6) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:168:29: ',' option
            	        			    {
            	        			    	char_literal28=(IToken)Match(input,46,FOLLOW_46_in_tikz_options458); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_46.Add(char_literal28);

            	        			    	PushFollow(FOLLOW_option_in_tikz_options460);
            	        			    	option29 = option();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( (state.backtracking==0) ) stream_option.Add(option29.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop6;
            	        	    }
            	        	} while (true);

            	        	loop6:
            	        		;	// Stops C# compiler whining that label 'loop6' has no statements

            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:168:42: ( ',' )?
            	        	int alt7 = 2;
            	        	int LA7_0 = input.LA(1);

            	        	if ( (LA7_0 == 46) )
            	        	{
            	        	    alt7 = 1;
            	        	}
            	        	switch (alt7) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:168:42: ','
            	        	        {
            	        	        	char_literal30=(IToken)Match(input,46,FOLLOW_46_in_tikz_options464); if (state.failed) return retval; 
            	        	        	if ( (state.backtracking==0) ) stream_46.Add(char_literal30);


            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:168:49: ( tikzstring )?
            	int alt9 = 2;
            	int LA9_0 = input.LA(1);

            	if ( (LA9_0 == 42) )
            	{
            	    alt9 = 1;
            	}
            	switch (alt9) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:168:49: tikzstring
            	        {
            	        	PushFollow(FOLLOW_tikzstring_in_tikz_options469);
            	        	tikzstring31 = tikzstring();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_tikzstring.Add(tikzstring31.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_squarebr_end_in_tikz_options472);
            	squarebr_end32 = squarebr_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_squarebr_end.Add(squarebr_end32.Tree);


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
            	// 168:75: -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:168:78: ^( IM_OPTIONS squarebr_start ( option )* squarebr_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTIONS, "IM_OPTIONS"), root_1);

            	    adaptor.AddChild(root_1, stream_squarebr_start.NextTree());
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:168:106: ( option )*
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:171:1: option : ( option_style | option_kv );
    public simpletikzParser.option_return option() // throws RecognitionException [1]
    {   
        simpletikzParser.option_return retval = new simpletikzParser.option_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.option_style_return option_style33 = default(simpletikzParser.option_style_return);

        simpletikzParser.option_kv_return option_kv34 = default(simpletikzParser.option_kv_return);



        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:172:2: ( option_style | option_kv )
            int alt10 = 2;
            alt10 = dfa10.Predict(input);
            switch (alt10) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:172:4: option_style
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_option_style_in_option497);
                    	option_style33 = option_style();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, option_style33.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:173:5: option_kv
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_option_kv_in_option506);
                    	option_kv34 = option_kv();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, option_kv34.Tree);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:176:1: option_kv : idd ( '=' iddornumberunitorstringorrange )? -> ^( IM_OPTION_KV idd ( iddornumberunitorstringorrange )? ) ;
    public simpletikzParser.option_kv_return option_kv() // throws RecognitionException [1]
    {   
        simpletikzParser.option_kv_return retval = new simpletikzParser.option_kv_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal36 = null;
        simpletikzParser.idd_return idd35 = default(simpletikzParser.idd_return);

        simpletikzParser.iddornumberunitorstringorrange_return iddornumberunitorstringorrange37 = default(simpletikzParser.iddornumberunitorstringorrange_return);


        object char_literal36_tree=null;
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleSubtreeStream stream_iddornumberunitorstringorrange = new RewriteRuleSubtreeStream(adaptor,"rule iddornumberunitorstringorrange");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:177:2: ( idd ( '=' iddornumberunitorstringorrange )? -> ^( IM_OPTION_KV idd ( iddornumberunitorstringorrange )? ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:177:4: idd ( '=' iddornumberunitorstringorrange )?
            {
            	PushFollow(FOLLOW_idd_in_option_kv520);
            	idd35 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idd.Add(idd35.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:177:8: ( '=' iddornumberunitorstringorrange )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == 44) )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:177:9: '=' iddornumberunitorstringorrange
            	        {
            	        	char_literal36=(IToken)Match(input,44,FOLLOW_44_in_option_kv523); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_44.Add(char_literal36);

            	        	PushFollow(FOLLOW_iddornumberunitorstringorrange_in_option_kv525);
            	        	iddornumberunitorstringorrange37 = iddornumberunitorstringorrange();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_iddornumberunitorstringorrange.Add(iddornumberunitorstringorrange37.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          idd, iddornumberunitorstringorrange
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 177:47: -> ^( IM_OPTION_KV idd ( iddornumberunitorstringorrange )? )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:177:50: ^( IM_OPTION_KV idd ( iddornumberunitorstringorrange )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTION_KV, "IM_OPTION_KV"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:177:69: ( iddornumberunitorstringorrange )?
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:180:1: tikzstring : '{' ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* '}' -> ^( IM_STRING '{' '}' ) ;
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
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleSubtreeStream stream_tikzstring = new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_no_rlbrace = new RewriteRuleSubtreeStream(adaptor,"rule no_rlbrace");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:181:2: ( '{' ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* '}' -> ^( IM_STRING '{' '}' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:181:4: '{' ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* '}'
            {
            	char_literal38=(IToken)Match(input,42,FOLLOW_42_in_tikzstring553); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_42.Add(char_literal38);

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:181:8: ( no_rlbrace )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( ((LA12_0 >= IM_PATH && LA12_0 <= 41) || (LA12_0 >= 44 && LA12_0 <= 88)) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:181:8: no_rlbrace
            			    {
            			    	PushFollow(FOLLOW_no_rlbrace_in_tikzstring555);
            			    	no_rlbrace39 = no_rlbrace();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_no_rlbrace.Add(no_rlbrace39.Tree);

            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:181:20: ( tikzstring ( no_rlbrace )* )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( (LA14_0 == 42) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:181:21: tikzstring ( no_rlbrace )*
            			    {
            			    	PushFollow(FOLLOW_tikzstring_in_tikzstring559);
            			    	tikzstring40 = tikzstring();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikzstring.Add(tikzstring40.Tree);
            			    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:181:32: ( no_rlbrace )*
            			    	do 
            			    	{
            			    	    int alt13 = 2;
            			    	    int LA13_0 = input.LA(1);

            			    	    if ( ((LA13_0 >= IM_PATH && LA13_0 <= 41) || (LA13_0 >= 44 && LA13_0 <= 88)) )
            			    	    {
            			    	        alt13 = 1;
            			    	    }


            			    	    switch (alt13) 
            			    		{
            			    			case 1 :
            			    			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:181:32: no_rlbrace
            			    			    {
            			    			    	PushFollow(FOLLOW_no_rlbrace_in_tikzstring561);
            			    			    	no_rlbrace41 = no_rlbrace();
            			    			    	state.followingStackPointer--;
            			    			    	if (state.failed) return retval;
            			    			    	if ( (state.backtracking==0) ) stream_no_rlbrace.Add(no_rlbrace41.Tree);

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

            	char_literal42=(IToken)Match(input,43,FOLLOW_43_in_tikzstring566); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_43.Add(char_literal42);



            	// AST REWRITE
            	// elements:          43, 42
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 181:50: -> ^( IM_STRING '{' '}' )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:181:53: ^( IM_STRING '{' '}' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STRING, "IM_STRING"), root_1);

            	    adaptor.AddChild(root_1, stream_42.NextNode());
            	    adaptor.AddChild(root_1, stream_43.NextNode());

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:184:1: no_rlbrace : ~ ( '{' | '}' ) ;
    public simpletikzParser.no_rlbrace_return no_rlbrace() // throws RecognitionException [1]
    {   
        simpletikzParser.no_rlbrace_return retval = new simpletikzParser.no_rlbrace_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set43 = null;

        object set43_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:185:2: (~ ( '{' | '}' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:185:4: ~ ( '{' | '}' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set43 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= 41) || (input.LA(1) >= 44 && input.LA(1) <= 88) ) 
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:187:1: iddornumberunitorstringorrange : ( range | numberunit | bracedcoord | idd | tikzstring );
    public simpletikzParser.iddornumberunitorstringorrange_return iddornumberunitorstringorrange() // throws RecognitionException [1]
    {   
        simpletikzParser.iddornumberunitorstringorrange_return retval = new simpletikzParser.iddornumberunitorstringorrange_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.range_return range44 = default(simpletikzParser.range_return);

        simpletikzParser.numberunit_return numberunit45 = default(simpletikzParser.numberunit_return);

        simpletikzParser.bracedcoord_return bracedcoord46 = default(simpletikzParser.bracedcoord_return);

        simpletikzParser.idd_return idd47 = default(simpletikzParser.idd_return);

        simpletikzParser.tikzstring_return tikzstring48 = default(simpletikzParser.tikzstring_return);



        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:188:2: ( range | numberunit | bracedcoord | idd | tikzstring )
            int alt15 = 5;
            alt15 = dfa15.Predict(input);
            switch (alt15) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:188:5: range
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_range_in_iddornumberunitorstringorrange607);
                    	range44 = range();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, range44.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:188:13: numberunit
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_numberunit_in_iddornumberunitorstringorrange611);
                    	numberunit45 = numberunit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, numberunit45.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:188:26: bracedcoord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_bracedcoord_in_iddornumberunitorstringorrange615);
                    	bracedcoord46 = bracedcoord();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bracedcoord46.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:188:40: idd
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_idd_in_iddornumberunitorstringorrange619);
                    	idd47 = idd();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idd47.Tree);

                    }
                    break;
                case 5 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:188:46: tikzstring
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikzstring_in_iddornumberunitorstringorrange623);
                    	tikzstring48 = tikzstring();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzstring48.Tree);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:190:1: bracedcoord : '{' coord_nooption '}' ;
    public simpletikzParser.bracedcoord_return bracedcoord() // throws RecognitionException [1]
    {   
        simpletikzParser.bracedcoord_return retval = new simpletikzParser.bracedcoord_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal49 = null;
        IToken char_literal51 = null;
        simpletikzParser.coord_nooption_return coord_nooption50 = default(simpletikzParser.coord_nooption_return);


        object char_literal49_tree=null;
        object char_literal51_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:191:2: ( '{' coord_nooption '}' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:191:4: '{' coord_nooption '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal49=(IToken)Match(input,42,FOLLOW_42_in_bracedcoord636); if (state.failed) return retval;
            	PushFollow(FOLLOW_coord_nooption_in_bracedcoord640);
            	coord_nooption50 = coord_nooption();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, coord_nooption50.Tree);
            	char_literal51=(IToken)Match(input,43,FOLLOW_43_in_bracedcoord642); if (state.failed) return retval;

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:193:1: range : numberunit ':' numberunit -> ^( IM_STRING numberunit ':' numberunit ) ;
    public simpletikzParser.range_return range() // throws RecognitionException [1]
    {   
        simpletikzParser.range_return retval = new simpletikzParser.range_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal53 = null;
        simpletikzParser.numberunit_return numberunit52 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit54 = default(simpletikzParser.numberunit_return);


        object char_literal53_tree=null;
        RewriteRuleTokenStream stream_47 = new RewriteRuleTokenStream(adaptor,"token 47");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:194:2: ( numberunit ':' numberunit -> ^( IM_STRING numberunit ':' numberunit ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:194:4: numberunit ':' numberunit
            {
            	PushFollow(FOLLOW_numberunit_in_range653);
            	numberunit52 = numberunit();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit52.Tree);
            	char_literal53=(IToken)Match(input,47,FOLLOW_47_in_range655); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_47.Add(char_literal53);

            	PushFollow(FOLLOW_numberunit_in_range657);
            	numberunit54 = numberunit();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit54.Tree);


            	// AST REWRITE
            	// elements:          47, numberunit, numberunit
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 194:30: -> ^( IM_STRING numberunit ':' numberunit )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:194:33: ^( IM_STRING numberunit ':' numberunit )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STRING, "IM_STRING"), root_1);

            	    adaptor.AddChild(root_1, stream_numberunit.NextTree());
            	    adaptor.AddChild(root_1, stream_47.NextNode());
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:196:1: option_style : idd ( '/.style' | ( '/.append' 'style' ) ) '=' '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}' -> ^( IM_OPTION_STYLE idd ( option_kv )* ) ;
    public simpletikzParser.option_style_return option_style() // throws RecognitionException [1]
    {   
        simpletikzParser.option_style_return retval = new simpletikzParser.option_style_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal56 = null;
        IToken string_literal57 = null;
        IToken string_literal58 = null;
        IToken char_literal59 = null;
        IToken char_literal60 = null;
        IToken char_literal62 = null;
        IToken char_literal64 = null;
        IToken char_literal65 = null;
        simpletikzParser.idd_return idd55 = default(simpletikzParser.idd_return);

        simpletikzParser.option_kv_return option_kv61 = default(simpletikzParser.option_kv_return);

        simpletikzParser.option_kv_return option_kv63 = default(simpletikzParser.option_kv_return);


        object string_literal56_tree=null;
        object string_literal57_tree=null;
        object string_literal58_tree=null;
        object char_literal59_tree=null;
        object char_literal60_tree=null;
        object char_literal62_tree=null;
        object char_literal64_tree=null;
        object char_literal65_tree=null;
        RewriteRuleTokenStream stream_49 = new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_48 = new RewriteRuleTokenStream(adaptor,"token 48");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_46 = new RewriteRuleTokenStream(adaptor,"token 46");
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_option_kv = new RewriteRuleSubtreeStream(adaptor,"rule option_kv");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:197:2: ( idd ( '/.style' | ( '/.append' 'style' ) ) '=' '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}' -> ^( IM_OPTION_STYLE idd ( option_kv )* ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:197:4: idd ( '/.style' | ( '/.append' 'style' ) ) '=' '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}'
            {
            	PushFollow(FOLLOW_idd_in_option_style681);
            	idd55 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idd.Add(idd55.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:197:8: ( '/.style' | ( '/.append' 'style' ) )
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( (LA16_0 == 48) )
            	{
            	    alt16 = 1;
            	}
            	else if ( (LA16_0 == 49) )
            	{
            	    alt16 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d16s0 =
            	        new NoViableAltException("", 16, 0, input);

            	    throw nvae_d16s0;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:197:9: '/.style'
            	        {
            	        	string_literal56=(IToken)Match(input,48,FOLLOW_48_in_option_style684); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_48.Add(string_literal56);


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:197:21: ( '/.append' 'style' )
            	        {
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:197:21: ( '/.append' 'style' )
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:197:22: '/.append' 'style'
            	        	{
            	        		string_literal57=(IToken)Match(input,49,FOLLOW_49_in_option_style689); if (state.failed) return retval; 
            	        		if ( (state.backtracking==0) ) stream_49.Add(string_literal57);

            	        		string_literal58=(IToken)Match(input,50,FOLLOW_50_in_option_style691); if (state.failed) return retval; 
            	        		if ( (state.backtracking==0) ) stream_50.Add(string_literal58);


            	        	}


            	        }
            	        break;

            	}

            	char_literal59=(IToken)Match(input,44,FOLLOW_44_in_option_style695); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_44.Add(char_literal59);

            	char_literal60=(IToken)Match(input,42,FOLLOW_42_in_option_style697); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_42.Add(char_literal60);

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:197:51: ( option_kv ( ',' option_kv )* )?
            	int alt18 = 2;
            	int LA18_0 = input.LA(1);

            	if ( ((LA18_0 >= IM_PATH && LA18_0 <= 41) || LA18_0 == 45 || LA18_0 == 50 || (LA18_0 >= 56 && LA18_0 <= 88)) )
            	{
            	    alt18 = 1;
            	}
            	switch (alt18) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:197:52: option_kv ( ',' option_kv )*
            	        {
            	        	PushFollow(FOLLOW_option_kv_in_option_style700);
            	        	option_kv61 = option_kv();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_option_kv.Add(option_kv61.Tree);
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:197:62: ( ',' option_kv )*
            	        	do 
            	        	{
            	        	    int alt17 = 2;
            	        	    int LA17_0 = input.LA(1);

            	        	    if ( (LA17_0 == 46) )
            	        	    {
            	        	        int LA17_1 = input.LA(2);

            	        	        if ( ((LA17_1 >= IM_PATH && LA17_1 <= 41) || LA17_1 == 45 || LA17_1 == 50 || (LA17_1 >= 56 && LA17_1 <= 88)) )
            	        	        {
            	        	            alt17 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt17) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:197:63: ',' option_kv
            	        			    {
            	        			    	char_literal62=(IToken)Match(input,46,FOLLOW_46_in_option_style703); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_46.Add(char_literal62);

            	        			    	PushFollow(FOLLOW_option_kv_in_option_style705);
            	        			    	option_kv63 = option_kv();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( (state.backtracking==0) ) stream_option_kv.Add(option_kv63.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop17;
            	        	    }
            	        	} while (true);

            	        	loop17:
            	        		;	// Stops C# compiler whining that label 'loop17' has no statements


            	        }
            	        break;

            	}

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:197:82: ( ',' )?
            	int alt19 = 2;
            	int LA19_0 = input.LA(1);

            	if ( (LA19_0 == 46) )
            	{
            	    alt19 = 1;
            	}
            	switch (alt19) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:197:82: ','
            	        {
            	        	char_literal64=(IToken)Match(input,46,FOLLOW_46_in_option_style712); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_46.Add(char_literal64);


            	        }
            	        break;

            	}

            	char_literal65=(IToken)Match(input,43,FOLLOW_43_in_option_style715); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_43.Add(char_literal65);



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
            	// 197:92: -> ^( IM_OPTION_STYLE idd ( option_kv )* )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:197:95: ^( IM_OPTION_STYLE idd ( option_kv )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTION_STYLE, "IM_OPTION_STYLE"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:197:117: ( option_kv )*
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:209:1: idd : idd_heavenknowswhythisisnecessary -> ^( IM_ID ) ;
    public simpletikzParser.idd_return idd() // throws RecognitionException [1]
    {   
        simpletikzParser.idd_return retval = new simpletikzParser.idd_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.idd_heavenknowswhythisisnecessary_return idd_heavenknowswhythisisnecessary66 = default(simpletikzParser.idd_heavenknowswhythisisnecessary_return);


        RewriteRuleSubtreeStream stream_idd_heavenknowswhythisisnecessary = new RewriteRuleSubtreeStream(adaptor,"rule idd_heavenknowswhythisisnecessary");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:210:2: ( idd_heavenknowswhythisisnecessary -> ^( IM_ID ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:210:4: idd_heavenknowswhythisisnecessary
            {
            	PushFollow(FOLLOW_idd_heavenknowswhythisisnecessary_in_idd750);
            	idd_heavenknowswhythisisnecessary66 = idd_heavenknowswhythisisnecessary();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idd_heavenknowswhythisisnecessary.Add(idd_heavenknowswhythisisnecessary66.Tree);


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
            	// 210:39: -> ^( IM_ID )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:210:42: ^( IM_ID )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:212:1: idd_heavenknowswhythisisnecessary : (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' ) )+ ;
    public simpletikzParser.idd_heavenknowswhythisisnecessary_return idd_heavenknowswhythisisnecessary() // throws RecognitionException [1]
    {   
        simpletikzParser.idd_heavenknowswhythisisnecessary_return retval = new simpletikzParser.idd_heavenknowswhythisisnecessary_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set67 = null;

        object set67_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:213:3: ( (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' ) )+ )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:213:6: (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' ) )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:213:6: (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' ) )+
            	int cnt20 = 0;
            	do 
            	{
            	    int alt20 = 2;
            	    int LA20_0 = input.LA(1);

            	    if ( (LA20_0 == 72) )
            	    {
            	        int LA20_2 = input.LA(2);

            	        if ( ((LA20_2 >= IM_PATH && LA20_2 <= COMMAND) || (LA20_2 >= WS && LA20_2 <= 50) || LA20_2 == 52 || LA20_2 == 54 || (LA20_2 >= 56 && LA20_2 <= 88)) )
            	        {
            	            alt20 = 1;
            	        }
            	        else if ( ((LA20_2 >= FLOAT_WO_EXP && LA20_2 <= INT)) )
            	        {
            	            alt20 = 1;
            	        }


            	    }
            	    else if ( ((LA20_0 >= IM_PATH && LA20_0 <= 41) || LA20_0 == 45 || LA20_0 == 50 || (LA20_0 >= 56 && LA20_0 <= 71) || (LA20_0 >= 73 && LA20_0 <= 88)) )
            	    {
            	        alt20 = 1;
            	    }


            	    switch (alt20) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:213:6: ~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' )
            			    {
            			    	set67 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= 41) || input.LA(1) == 45 || input.LA(1) == 50 || (input.LA(1) >= 56 && input.LA(1) <= 88) ) 
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
            			    break;

            			default:
            			    if ( cnt20 >= 1 ) goto loop20;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee20 =
            		                new EarlyExitException(20, input);
            		            throw eee20;
            	    }
            	    cnt20++;
            	} while (true);

            	loop20:
            		;	// Stops C# compiler whining that label 'loop20' has no statements


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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:214:1: idd2 : ( ID )+ -> ^( IM_ID ) ;
    public simpletikzParser.idd2_return idd2() // throws RecognitionException [1]
    {   
        simpletikzParser.idd2_return retval = new simpletikzParser.idd2_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID68 = null;

        object ID68_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:215:2: ( ( ID )+ -> ^( IM_ID ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:215:4: ( ID )+
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:215:4: ( ID )+
            	int cnt21 = 0;
            	do 
            	{
            	    int alt21 = 2;
            	    int LA21_0 = input.LA(1);

            	    if ( (LA21_0 == ID) )
            	    {
            	        alt21 = 1;
            	    }


            	    switch (alt21) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:215:4: ID
            			    {
            			    	ID68=(IToken)Match(input,ID,FOLLOW_ID_in_idd2830); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_ID.Add(ID68);


            			    }
            			    break;

            			default:
            			    if ( cnt21 >= 1 ) goto loop21;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee21 =
            		                new EarlyExitException(21, input);
            		            throw eee21;
            	    }
            	    cnt21++;
            	} while (true);

            	loop21:
            		;	// Stops C# compiler whining that label 'loop21' has no statements



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
            	// 215:8: -> ^( IM_ID )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:215:11: ^( IM_ID )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:218:1: numberunitorvariable : ( numberunit | COMMAND );
    public simpletikzParser.numberunitorvariable_return numberunitorvariable() // throws RecognitionException [1]
    {   
        simpletikzParser.numberunitorvariable_return retval = new simpletikzParser.numberunitorvariable_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken COMMAND70 = null;
        simpletikzParser.numberunit_return numberunit69 = default(simpletikzParser.numberunit_return);


        object COMMAND70_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:219:2: ( numberunit | COMMAND )
            int alt22 = 2;
            int LA22_0 = input.LA(1);

            if ( ((LA22_0 >= FLOAT_WO_EXP && LA22_0 <= INT)) )
            {
                alt22 = 1;
            }
            else if ( (LA22_0 == COMMAND) )
            {
                alt22 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d22s0 =
                    new NoViableAltException("", 22, 0, input);

                throw nvae_d22s0;
            }
            switch (alt22) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:219:4: numberunit
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_numberunit_in_numberunitorvariable849);
                    	numberunit69 = numberunit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, numberunit69.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:220:4: COMMAND
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	COMMAND70=(IToken)Match(input,COMMAND,FOLLOW_COMMAND_in_numberunitorvariable854); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{COMMAND70_tree = (object)adaptor.Create(COMMAND70);
                    		adaptor.AddChild(root_0, COMMAND70_tree);
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:223:1: numberunit : number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) ;
    public simpletikzParser.numberunit_return numberunit() // throws RecognitionException [1]
    {   
        simpletikzParser.numberunit_return retval = new simpletikzParser.numberunit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.number_return number71 = default(simpletikzParser.number_return);

        simpletikzParser.unit_return unit72 = default(simpletikzParser.unit_return);


        RewriteRuleSubtreeStream stream_unit = new RewriteRuleSubtreeStream(adaptor,"rule unit");
        RewriteRuleSubtreeStream stream_number = new RewriteRuleSubtreeStream(adaptor,"rule number");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:224:2: ( number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:224:4: number ( unit )?
            {
            	PushFollow(FOLLOW_number_in_numberunit867);
            	number71 = number();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_number.Add(number71.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:224:11: ( unit )?
            	int alt23 = 2;
            	int LA23_0 = input.LA(1);

            	if ( ((LA23_0 >= 56 && LA23_0 <= 61)) )
            	{
            	    alt23 = 1;
            	}
            	switch (alt23) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:224:11: unit
            	        {
            	        	PushFollow(FOLLOW_unit_in_numberunit869);
            	        	unit72 = unit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_unit.Add(unit72.Tree);

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
            	// 224:17: -> ^( IM_NUMBERUNIT number ( unit )? )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:224:20: ^( IM_NUMBERUNIT number ( unit )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NUMBERUNIT, "IM_NUMBERUNIT"), root_1);

            	    adaptor.AddChild(root_1, stream_number.NextTree());
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:224:43: ( unit )?
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:228:1: number : ( FLOAT_WO_EXP | INT ) ;
    public simpletikzParser.number_return number() // throws RecognitionException [1]
    {   
        simpletikzParser.number_return retval = new simpletikzParser.number_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set73 = null;

        object set73_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:229:2: ( ( FLOAT_WO_EXP | INT ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:229:4: ( FLOAT_WO_EXP | INT )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set73 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= FLOAT_WO_EXP && input.LA(1) <= INT) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set73));
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:232:1: unit : ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' | 'em' );
    public simpletikzParser.unit_return unit() // throws RecognitionException [1]
    {   
        simpletikzParser.unit_return retval = new simpletikzParser.unit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set74 = null;

        object set74_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:233:2: ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' | 'em' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set74 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 56 && input.LA(1) <= 61) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set74));
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:236:1: tikz_set : tikz_set_start ( option ( ',' option )* ( ',' )? )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) ;
    public simpletikzParser.tikz_set_return tikz_set() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_set_return retval = new simpletikzParser.tikz_set_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal77 = null;
        IToken char_literal79 = null;
        simpletikzParser.tikz_set_start_return tikz_set_start75 = default(simpletikzParser.tikz_set_start_return);

        simpletikzParser.option_return option76 = default(simpletikzParser.option_return);

        simpletikzParser.option_return option78 = default(simpletikzParser.option_return);

        simpletikzParser.roundbr_end_return roundbr_end80 = default(simpletikzParser.roundbr_end_return);


        object char_literal77_tree=null;
        object char_literal79_tree=null;
        RewriteRuleTokenStream stream_46 = new RewriteRuleTokenStream(adaptor,"token 46");
        RewriteRuleSubtreeStream stream_tikz_set_start = new RewriteRuleSubtreeStream(adaptor,"rule tikz_set_start");
        RewriteRuleSubtreeStream stream_roundbr_end = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        RewriteRuleSubtreeStream stream_option = new RewriteRuleSubtreeStream(adaptor,"rule option");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:237:2: ( tikz_set_start ( option ( ',' option )* ( ',' )? )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:237:5: tikz_set_start ( option ( ',' option )* ( ',' )? )? roundbr_end
            {
            	PushFollow(FOLLOW_tikz_set_start_in_tikz_set950);
            	tikz_set_start75 = tikz_set_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikz_set_start.Add(tikz_set_start75.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:237:20: ( option ( ',' option )* ( ',' )? )?
            	int alt26 = 2;
            	int LA26_0 = input.LA(1);

            	if ( ((LA26_0 >= IM_PATH && LA26_0 <= 41) || LA26_0 == 45 || LA26_0 == 50 || (LA26_0 >= 56 && LA26_0 <= 88)) )
            	{
            	    alt26 = 1;
            	}
            	switch (alt26) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:237:21: option ( ',' option )* ( ',' )?
            	        {
            	        	PushFollow(FOLLOW_option_in_tikz_set953);
            	        	option76 = option();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_option.Add(option76.Tree);
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:237:28: ( ',' option )*
            	        	do 
            	        	{
            	        	    int alt24 = 2;
            	        	    int LA24_0 = input.LA(1);

            	        	    if ( (LA24_0 == 46) )
            	        	    {
            	        	        int LA24_1 = input.LA(2);

            	        	        if ( ((LA24_1 >= IM_PATH && LA24_1 <= 41) || LA24_1 == 45 || LA24_1 == 50 || (LA24_1 >= 56 && LA24_1 <= 88)) )
            	        	        {
            	        	            alt24 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt24) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:237:29: ',' option
            	        			    {
            	        			    	char_literal77=(IToken)Match(input,46,FOLLOW_46_in_tikz_set956); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_46.Add(char_literal77);

            	        			    	PushFollow(FOLLOW_option_in_tikz_set958);
            	        			    	option78 = option();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( (state.backtracking==0) ) stream_option.Add(option78.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop24;
            	        	    }
            	        	} while (true);

            	        	loop24:
            	        		;	// Stops C# compiler whining that label 'loop24' has no statements

            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:237:42: ( ',' )?
            	        	int alt25 = 2;
            	        	int LA25_0 = input.LA(1);

            	        	if ( (LA25_0 == 46) )
            	        	{
            	        	    alt25 = 1;
            	        	}
            	        	switch (alt25) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:237:42: ','
            	        	        {
            	        	        	char_literal79=(IToken)Match(input,46,FOLLOW_46_in_tikz_set962); if (state.failed) return retval; 
            	        	        	if ( (state.backtracking==0) ) stream_46.Add(char_literal79);


            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_roundbr_end_in_tikz_set967);
            	roundbr_end80 = roundbr_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_roundbr_end.Add(roundbr_end80.Tree);


            	// AST REWRITE
            	// elements:          option, roundbr_end, tikz_set_start
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 237:61: -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:237:64: ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_TIKZSET, "IM_TIKZSET"), root_1);

            	    adaptor.AddChild(root_1, stream_tikz_set_start.NextTree());
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:237:92: ( option )*
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:242:1: tikzpicture : tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) ;
    public simpletikzParser.tikzpicture_return tikzpicture() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_return retval = new simpletikzParser.tikzpicture_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzpicture_start_return tikzpicture_start81 = default(simpletikzParser.tikzpicture_start_return);

        simpletikzParser.tikz_options_return tikz_options82 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody_return tikzbody83 = default(simpletikzParser.tikzbody_return);

        simpletikzParser.tikzpicture_end_return tikzpicture_end84 = default(simpletikzParser.tikzpicture_end_return);


        RewriteRuleSubtreeStream stream_tikzpicture_end = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_end");
        RewriteRuleSubtreeStream stream_tikzpicture_start = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_start");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:243:2: ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:243:5: tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end
            {
            	PushFollow(FOLLOW_tikzpicture_start_in_tikzpicture995);
            	tikzpicture_start81 = tikzpicture_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzpicture_start.Add(tikzpicture_start81.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:243:23: ( tikz_options )?
            	int alt27 = 2;
            	int LA27_0 = input.LA(1);

            	if ( (LA27_0 == 53) )
            	{
            	    alt27 = 1;
            	}
            	switch (alt27) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:243:23: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_tikzpicture997);
            	        	tikz_options82 = tikz_options();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_tikz_options.Add(tikz_options82.Tree);

            	        }
            	        break;

            	}

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:243:37: ( tikzbody )?
            	int alt28 = 2;
            	int LA28_0 = input.LA(1);

            	if ( ((LA28_0 >= IM_PATH && LA28_0 <= 52) || (LA28_0 >= 54 && LA28_0 <= 61) || (LA28_0 >= 63 && LA28_0 <= 88)) )
            	{
            	    alt28 = 1;
            	}
            	else if ( (LA28_0 == 62) )
            	{
            	    int LA28_2 = input.LA(2);

            	    if ( (LA28_2 == 42) )
            	    {
            	        int LA28_3 = input.LA(3);

            	        if ( (LA28_3 == ID) )
            	        {
            	            alt28 = 1;
            	        }
            	    }
            	}
            	switch (alt28) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:243:37: tikzbody
            	        {
            	        	PushFollow(FOLLOW_tikzbody_in_tikzpicture1000);
            	        	tikzbody83 = tikzbody();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_tikzbody.Add(tikzbody83.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzpicture_end_in_tikzpicture1003);
            	tikzpicture_end84 = tikzpicture_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzpicture_end.Add(tikzpicture_end84.Tree);


            	// AST REWRITE
            	// elements:          tikzbody, tikzpicture_end, tikzpicture_start, tikz_options
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 243:64: -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:243:67: ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PICTURE, "IM_PICTURE"), root_1);

            	    adaptor.AddChild(root_1, stream_tikzpicture_start.NextTree());
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:243:98: ( tikz_options )?
            	    if ( stream_tikz_options.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikz_options.NextTree());

            	    }
            	    stream_tikz_options.Reset();
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:243:112: ( tikzbody )?
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:246:1: tikzbody : ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )* ;
    public simpletikzParser.tikzbody_return tikzbody() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzbody_return retval = new simpletikzParser.tikzbody_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_return tikzscope85 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath86 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznode_ext_return tikznode_ext87 = default(simpletikzParser.tikznode_ext_return);

        simpletikzParser.tikzmatrix_ext_return tikzmatrix_ext88 = default(simpletikzParser.tikzmatrix_ext_return);

        simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext89 = default(simpletikzParser.tikzcoordinate_ext_return);

        simpletikzParser.tikz_set_return tikz_set90 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style91 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin92 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend93 = default(simpletikzParser.otherend_return);

        simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr94 = default(simpletikzParser.dontcare_body_nobr_return);

        simpletikzParser.tikzscope_return tikzscope95 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath96 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznode_ext_return tikznode_ext97 = default(simpletikzParser.tikznode_ext_return);

        simpletikzParser.tikzmatrix_ext_return tikzmatrix_ext98 = default(simpletikzParser.tikzmatrix_ext_return);

        simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext99 = default(simpletikzParser.tikzcoordinate_ext_return);

        simpletikzParser.tikz_set_return tikz_set100 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style101 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin102 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend103 = default(simpletikzParser.otherend_return);

        simpletikzParser.dontcare_body_return dontcare_body104 = default(simpletikzParser.dontcare_body_return);



        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:247:2: ( ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )* )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:247:4: ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:247:4: ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr )
            	int alt29 = 10;
            	alt29 = dfa29.Predict(input);
            	switch (alt29) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:247:6: tikzscope
            	        {
            	        	PushFollow(FOLLOW_tikzscope_in_tikzbody1033);
            	        	tikzscope85 = tikzscope();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzscope85.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:247:18: tikzpath
            	        {
            	        	PushFollow(FOLLOW_tikzpath_in_tikzbody1037);
            	        	tikzpath86 = tikzpath();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath86.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:247:29: tikznode_ext
            	        {
            	        	PushFollow(FOLLOW_tikznode_ext_in_tikzbody1041);
            	        	tikznode_ext87 = tikznode_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_ext87.Tree);

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:247:44: tikzmatrix_ext
            	        {
            	        	PushFollow(FOLLOW_tikzmatrix_ext_in_tikzbody1045);
            	        	tikzmatrix_ext88 = tikzmatrix_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzmatrix_ext88.Tree);

            	        }
            	        break;
            	    case 5 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:247:61: tikzcoordinate_ext
            	        {
            	        	PushFollow(FOLLOW_tikzcoordinate_ext_in_tikzbody1049);
            	        	tikzcoordinate_ext89 = tikzcoordinate_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_ext89.Tree);

            	        }
            	        break;
            	    case 6 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:247:82: tikz_set
            	        {
            	        	PushFollow(FOLLOW_tikz_set_in_tikzbody1053);
            	        	tikz_set90 = tikz_set();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set90.Tree);

            	        }
            	        break;
            	    case 7 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:247:93: tikz_style
            	        {
            	        	PushFollow(FOLLOW_tikz_style_in_tikzbody1057);
            	        	tikz_style91 = tikz_style();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style91.Tree);

            	        }
            	        break;
            	    case 8 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:247:106: otherbegin
            	        {
            	        	PushFollow(FOLLOW_otherbegin_in_tikzbody1061);
            	        	otherbegin92 = otherbegin();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;
            	    case 9 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:247:120: otherend
            	        {
            	        	PushFollow(FOLLOW_otherend_in_tikzbody1066);
            	        	otherend93 = otherend();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;
            	    case 10 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:247:132: dontcare_body_nobr
            	        {
            	        	PushFollow(FOLLOW_dontcare_body_nobr_in_tikzbody1071);
            	        	dontcare_body_nobr94 = dontcare_body_nobr();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;

            	}

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:248:3: ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*
            	do 
            	{
            	    int alt30 = 11;
            	    alt30 = dfa30.Predict(input);
            	    switch (alt30) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:248:5: tikzscope
            			    {
            			    	PushFollow(FOLLOW_tikzscope_in_tikzbody1082);
            			    	tikzscope95 = tikzscope();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzscope95.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:248:17: tikzpath
            			    {
            			    	PushFollow(FOLLOW_tikzpath_in_tikzbody1086);
            			    	tikzpath96 = tikzpath();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath96.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:248:28: tikznode_ext
            			    {
            			    	PushFollow(FOLLOW_tikznode_ext_in_tikzbody1090);
            			    	tikznode_ext97 = tikznode_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_ext97.Tree);

            			    }
            			    break;
            			case 4 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:248:43: tikzmatrix_ext
            			    {
            			    	PushFollow(FOLLOW_tikzmatrix_ext_in_tikzbody1094);
            			    	tikzmatrix_ext98 = tikzmatrix_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzmatrix_ext98.Tree);

            			    }
            			    break;
            			case 5 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:248:60: tikzcoordinate_ext
            			    {
            			    	PushFollow(FOLLOW_tikzcoordinate_ext_in_tikzbody1098);
            			    	tikzcoordinate_ext99 = tikzcoordinate_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_ext99.Tree);

            			    }
            			    break;
            			case 6 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:248:81: tikz_set
            			    {
            			    	PushFollow(FOLLOW_tikz_set_in_tikzbody1102);
            			    	tikz_set100 = tikz_set();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set100.Tree);

            			    }
            			    break;
            			case 7 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:248:92: tikz_style
            			    {
            			    	PushFollow(FOLLOW_tikz_style_in_tikzbody1106);
            			    	tikz_style101 = tikz_style();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style101.Tree);

            			    }
            			    break;
            			case 8 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:248:105: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzbody1110);
            			    	otherbegin102 = otherbegin();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;
            			case 9 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:248:119: otherend
            			    {
            			    	PushFollow(FOLLOW_otherend_in_tikzbody1115);
            			    	otherend103 = otherend();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;
            			case 10 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:248:131: dontcare_body
            			    {
            			    	PushFollow(FOLLOW_dontcare_body_in_tikzbody1120);
            			    	dontcare_body104 = dontcare_body();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop30;
            	    }
            	} while (true);

            	loop30:
            		;	// Stops C# compiler whining that label 'loop30' has no statements


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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:251:1: dontcare_body_nobr : (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\filldraw' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) ) ;
    public simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body_nobr_return retval = new simpletikzParser.dontcare_body_nobr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set105 = null;

        object set105_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:252:2: ( (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\filldraw' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:252:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\filldraw' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:252:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\filldraw' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) )
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:252:5: ~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\filldraw' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' )
            	{
            		set105 = (IToken)input.LT(1);
            		if ( (input.LA(1) >= IM_PATH && input.LA(1) <= SOMETHING1) || (input.LA(1) >= 42 && input.LA(1) <= 52) || (input.LA(1) >= 54 && input.LA(1) <= 61) || (input.LA(1) >= 71 && input.LA(1) <= 88) ) 
            		{
            		    input.Consume();
            		    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set105));
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:254:1: dontcare_body : (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\filldraw' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) ) ;
    public simpletikzParser.dontcare_body_return dontcare_body() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body_return retval = new simpletikzParser.dontcare_body_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set106 = null;

        object set106_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:255:2: ( (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\filldraw' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:255:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\filldraw' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:255:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\filldraw' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) )
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:255:5: ~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\filldraw' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' )
            	{
            		set106 = (IToken)input.LT(1);
            		if ( (input.LA(1) >= IM_PATH && input.LA(1) <= SOMETHING1) || (input.LA(1) >= 42 && input.LA(1) <= 61) || (input.LA(1) >= 71 && input.LA(1) <= 88) ) 
            		{
            		    input.Consume();
            		    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set106));
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:257:1: otherend : '\\\\end' '{' idd2 '}' ;
    public simpletikzParser.otherend_return otherend() // throws RecognitionException [1]
    {   
        simpletikzParser.otherend_return retval = new simpletikzParser.otherend_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal107 = null;
        IToken char_literal108 = null;
        IToken char_literal110 = null;
        simpletikzParser.idd2_return idd2109 = default(simpletikzParser.idd2_return);


        object string_literal107_tree=null;
        object char_literal108_tree=null;
        object char_literal110_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:258:2: ( '\\\\end' '{' idd2 '}' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:258:4: '\\\\end' '{' idd2 '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal107=(IToken)Match(input,62,FOLLOW_62_in_otherend1266); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal107_tree = (object)adaptor.Create(string_literal107);
            		adaptor.AddChild(root_0, string_literal107_tree);
            	}
            	char_literal108=(IToken)Match(input,42,FOLLOW_42_in_otherend1268); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal108_tree = (object)adaptor.Create(char_literal108);
            		adaptor.AddChild(root_0, char_literal108_tree);
            	}
            	PushFollow(FOLLOW_idd2_in_otherend1270);
            	idd2109 = idd2();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idd2109.Tree);
            	char_literal110=(IToken)Match(input,43,FOLLOW_43_in_otherend1272); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal110_tree = (object)adaptor.Create(char_literal110);
            		adaptor.AddChild(root_0, char_literal110_tree);
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:272:1: tikzscope : tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end ) ;
    public simpletikzParser.tikzscope_return tikzscope() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_return retval = new simpletikzParser.tikzscope_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_start_return tikzscope_start111 = default(simpletikzParser.tikzscope_start_return);

        simpletikzParser.tikz_options_return tikz_options112 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody_return tikzbody113 = default(simpletikzParser.tikzbody_return);

        simpletikzParser.tikzscope_end_return tikzscope_end114 = default(simpletikzParser.tikzscope_end_return);


        RewriteRuleSubtreeStream stream_tikzscope_start = new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_start");
        RewriteRuleSubtreeStream stream_tikzscope_end = new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_end");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:273:2: ( tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:273:4: tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end
            {
            	PushFollow(FOLLOW_tikzscope_start_in_tikzscope1299);
            	tikzscope_start111 = tikzscope_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzscope_start.Add(tikzscope_start111.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:273:20: ( tikz_options )?
            	int alt31 = 2;
            	int LA31_0 = input.LA(1);

            	if ( (LA31_0 == 53) )
            	{
            	    alt31 = 1;
            	}
            	switch (alt31) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:273:20: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_tikzscope1301);
            	        	tikz_options112 = tikz_options();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_tikz_options.Add(tikz_options112.Tree);

            	        }
            	        break;

            	}

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:273:34: ( tikzbody )?
            	int alt32 = 2;
            	int LA32_0 = input.LA(1);

            	if ( ((LA32_0 >= IM_PATH && LA32_0 <= 52) || (LA32_0 >= 54 && LA32_0 <= 61) || (LA32_0 >= 63 && LA32_0 <= 88)) )
            	{
            	    alt32 = 1;
            	}
            	else if ( (LA32_0 == 62) )
            	{
            	    int LA32_2 = input.LA(2);

            	    if ( (LA32_2 == 42) )
            	    {
            	        int LA32_3 = input.LA(3);

            	        if ( (LA32_3 == ID) )
            	        {
            	            alt32 = 1;
            	        }
            	    }
            	}
            	switch (alt32) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:273:34: tikzbody
            	        {
            	        	PushFollow(FOLLOW_tikzbody_in_tikzscope1304);
            	        	tikzbody113 = tikzbody();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_tikzbody.Add(tikzbody113.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzscope_end_in_tikzscope1307);
            	tikzscope_end114 = tikzscope_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzscope_end.Add(tikzscope_end114.Tree);


            	// AST REWRITE
            	// elements:          tikzbody, tikzscope_end, tikz_options, tikzscope_start
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 273:59: -> ^( IM_SCOPE tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:273:62: ^( IM_SCOPE tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_SCOPE, "IM_SCOPE"), root_1);

            	    adaptor.AddChild(root_1, stream_tikzscope_start.NextTree());
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:273:89: ( tikz_options )?
            	    if ( stream_tikz_options.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikz_options.NextTree());

            	    }
            	    stream_tikz_options.Reset();
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:273:103: ( tikzbody )?
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:299:1: tikzpath : path_start ( tikzpath_element )* semicolon_end -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikzpath_return tikzpath() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_return retval = new simpletikzParser.tikzpath_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.path_start_return path_start115 = default(simpletikzParser.path_start_return);

        simpletikzParser.tikzpath_element_return tikzpath_element116 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end117 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_path_start = new RewriteRuleSubtreeStream(adaptor,"rule path_start");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:300:2: ( path_start ( tikzpath_element )* semicolon_end -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:300:4: path_start ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_path_start_in_tikzpath1363);
            	path_start115 = path_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_path_start.Add(path_start115.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:300:15: ( tikzpath_element )*
            	do 
            	{
            	    int alt33 = 2;
            	    int LA33_0 = input.LA(1);

            	    if ( ((LA33_0 >= ID && LA33_0 <= COMMAND) || LA33_0 == 42 || LA33_0 == 44 || LA33_0 == 51 || LA33_0 == 53 || LA33_0 == 57 || LA33_0 == 71 || (LA33_0 >= 73 && LA33_0 <= 74) || (LA33_0 >= 76 && LA33_0 <= 85)) )
            	    {
            	        alt33 = 1;
            	    }


            	    switch (alt33) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:300:15: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath1365);
            			    	tikzpath_element116 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element116.Tree);

            			    }
            			    break;

            			default:
            			    goto loop33;
            	    }
            	} while (true);

            	loop33:
            		;	// Stops C# compiler whining that label 'loop33' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikzpath1368);
            	semicolon_end117 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_semicolon_end.Add(semicolon_end117.Tree);


            	// AST REWRITE
            	// elements:          path_start, semicolon_end, tikzpath_element
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 300:47: -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:300:50: ^( IM_PATH path_start ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_path_start.NextTree());
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:300:71: ( tikzpath_element )*
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:305:1: let_cmd_parts : ( 'let' | 'in' | '=' | COMMAND );
    public simpletikzParser.let_cmd_parts_return let_cmd_parts() // throws RecognitionException [1]
    {   
        simpletikzParser.let_cmd_parts_return retval = new simpletikzParser.let_cmd_parts_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set118 = null;

        object set118_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:306:2: ( 'let' | 'in' | '=' | COMMAND )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set118 = (IToken)input.LT(1);
            	if ( input.LA(1) == COMMAND || input.LA(1) == 44 || input.LA(1) == 57 || input.LA(1) == 71 ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set118));
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:310:1: tikzpath_element : tikzpath_element_single ( ',' )? ;
    public simpletikzParser.tikzpath_element_return tikzpath_element() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_element_return retval = new simpletikzParser.tikzpath_element_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal120 = null;
        simpletikzParser.tikzpath_element_single_return tikzpath_element_single119 = default(simpletikzParser.tikzpath_element_single_return);


        object char_literal120_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:311:2: ( tikzpath_element_single ( ',' )? )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:311:4: tikzpath_element_single ( ',' )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_tikzpath_element_single_in_tikzpath_element1424);
            	tikzpath_element_single119 = tikzpath_element_single();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath_element_single119.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:311:28: ( ',' )?
            	int alt34 = 2;
            	int LA34_0 = input.LA(1);

            	if ( (LA34_0 == 46) )
            	{
            	    alt34 = 1;
            	}
            	switch (alt34) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:311:28: ','
            	        {
            	        	char_literal120=(IToken)Match(input,46,FOLLOW_46_in_tikzpath_element1426); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal120_tree = (object)adaptor.Create(char_literal120);
            	        		adaptor.AddChild(root_0, char_literal120_tree);
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:314:1: tikzpath_element_single : ( tikz_options | let_cmd_parts -> ^( IM_TIKZEDT_CMD ( let_cmd_parts )+ ) | arc | ( coord )=> coord | controls | tikznode_int | tikzcoordinate_int | circle | roundbr_start ( tikzpath_element )* roundbr_end -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end ) | '(' ( tikzpath_element )* ')' -> ^( IM_PATH '(' ( tikzpath_element )* ')' ) | edgeop );
    public simpletikzParser.tikzpath_element_single_return tikzpath_element_single() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_element_single_return retval = new simpletikzParser.tikzpath_element_single_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal132 = null;
        IToken char_literal134 = null;
        simpletikzParser.tikz_options_return tikz_options121 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.let_cmd_parts_return let_cmd_parts122 = default(simpletikzParser.let_cmd_parts_return);

        simpletikzParser.arc_return arc123 = default(simpletikzParser.arc_return);

        simpletikzParser.coord_return coord124 = default(simpletikzParser.coord_return);

        simpletikzParser.controls_return controls125 = default(simpletikzParser.controls_return);

        simpletikzParser.tikznode_int_return tikznode_int126 = default(simpletikzParser.tikznode_int_return);

        simpletikzParser.tikzcoordinate_int_return tikzcoordinate_int127 = default(simpletikzParser.tikzcoordinate_int_return);

        simpletikzParser.circle_return circle128 = default(simpletikzParser.circle_return);

        simpletikzParser.roundbr_start_return roundbr_start129 = default(simpletikzParser.roundbr_start_return);

        simpletikzParser.tikzpath_element_return tikzpath_element130 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.roundbr_end_return roundbr_end131 = default(simpletikzParser.roundbr_end_return);

        simpletikzParser.tikzpath_element_return tikzpath_element133 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.edgeop_return edgeop135 = default(simpletikzParser.edgeop_return);


        object char_literal132_tree=null;
        object char_literal134_tree=null;
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_roundbr_start = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_start");
        RewriteRuleSubtreeStream stream_roundbr_end = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        RewriteRuleSubtreeStream stream_let_cmd_parts = new RewriteRuleSubtreeStream(adaptor,"rule let_cmd_parts");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:315:2: ( tikz_options | let_cmd_parts -> ^( IM_TIKZEDT_CMD ( let_cmd_parts )+ ) | arc | ( coord )=> coord | controls | tikznode_int | tikzcoordinate_int | circle | roundbr_start ( tikzpath_element )* roundbr_end -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end ) | '(' ( tikzpath_element )* ')' -> ^( IM_PATH '(' ( tikzpath_element )* ')' ) | edgeop )
            int alt37 = 11;
            alt37 = dfa37.Predict(input);
            switch (alt37) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:316:5: tikz_options
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_options_in_tikzpath_element_single1443);
                    	tikz_options121 = tikz_options();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_options121.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:317:5: let_cmd_parts
                    {
                    	PushFollow(FOLLOW_let_cmd_parts_in_tikzpath_element_single1450);
                    	let_cmd_parts122 = let_cmd_parts();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_let_cmd_parts.Add(let_cmd_parts122.Tree);


                    	// AST REWRITE
                    	// elements:          let_cmd_parts
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 317:19: -> ^( IM_TIKZEDT_CMD ( let_cmd_parts )+ )
                    	{
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:317:22: ^( IM_TIKZEDT_CMD ( let_cmd_parts )+ )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_TIKZEDT_CMD, "IM_TIKZEDT_CMD"), root_1);

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
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:319:5: arc
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arc_in_tikzpath_element_single1468);
                    	arc123 = arc();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arc123.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:320:5: ( coord )=> coord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_coord_in_tikzpath_element_single1478);
                    	coord124 = coord();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, coord124.Tree);

                    }
                    break;
                case 5 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:321:5: controls
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_controls_in_tikzpath_element_single1484);
                    	controls125 = controls();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, controls125.Tree);

                    }
                    break;
                case 6 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:322:5: tikznode_int
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikznode_int_in_tikzpath_element_single1490);
                    	tikznode_int126 = tikznode_int();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_int126.Tree);

                    }
                    break;
                case 7 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:323:5: tikzcoordinate_int
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikzcoordinate_int_in_tikzpath_element_single1496);
                    	tikzcoordinate_int127 = tikzcoordinate_int();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_int127.Tree);

                    }
                    break;
                case 8 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:324:5: circle
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_circle_in_tikzpath_element_single1502);
                    	circle128 = circle();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;

                    }
                    break;
                case 9 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:325:5: roundbr_start ( tikzpath_element )* roundbr_end
                    {
                    	PushFollow(FOLLOW_roundbr_start_in_tikzpath_element_single1509);
                    	roundbr_start129 = roundbr_start();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_roundbr_start.Add(roundbr_start129.Tree);
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:325:19: ( tikzpath_element )*
                    	do 
                    	{
                    	    int alt35 = 2;
                    	    int LA35_0 = input.LA(1);

                    	    if ( ((LA35_0 >= ID && LA35_0 <= COMMAND) || LA35_0 == 42 || LA35_0 == 44 || LA35_0 == 51 || LA35_0 == 53 || LA35_0 == 57 || LA35_0 == 71 || (LA35_0 >= 73 && LA35_0 <= 74) || (LA35_0 >= 76 && LA35_0 <= 85)) )
                    	    {
                    	        alt35 = 1;
                    	    }


                    	    switch (alt35) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:325:19: tikzpath_element
                    			    {
                    			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath_element_single1511);
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

                    	PushFollow(FOLLOW_roundbr_end_in_tikzpath_element_single1514);
                    	roundbr_end131 = roundbr_end();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_roundbr_end.Add(roundbr_end131.Tree);


                    	// AST REWRITE
                    	// elements:          roundbr_start, tikzpath_element, roundbr_end
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 325:49: -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end )
                    	{
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:325:52: ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

                    	    adaptor.AddChild(root_1, stream_roundbr_start.NextTree());
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:325:76: ( tikzpath_element )*
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
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:326:6: '(' ( tikzpath_element )* ')'
                    {
                    	char_literal132=(IToken)Match(input,51,FOLLOW_51_in_tikzpath_element_single1534); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_51.Add(char_literal132);

                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:326:10: ( tikzpath_element )*
                    	do 
                    	{
                    	    int alt36 = 2;
                    	    int LA36_0 = input.LA(1);

                    	    if ( ((LA36_0 >= ID && LA36_0 <= COMMAND) || LA36_0 == 42 || LA36_0 == 44 || LA36_0 == 51 || LA36_0 == 53 || LA36_0 == 57 || LA36_0 == 71 || (LA36_0 >= 73 && LA36_0 <= 74) || (LA36_0 >= 76 && LA36_0 <= 85)) )
                    	    {
                    	        alt36 = 1;
                    	    }


                    	    switch (alt36) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:326:10: tikzpath_element
                    			    {
                    			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath_element_single1536);
                    			    	tikzpath_element133 = tikzpath_element();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element133.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop36;
                    	    }
                    	} while (true);

                    	loop36:
                    		;	// Stops C# compiler whining that label 'loop36' has no statements

                    	char_literal134=(IToken)Match(input,52,FOLLOW_52_in_tikzpath_element_single1539); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_52.Add(char_literal134);



                    	// AST REWRITE
                    	// elements:          52, 51, tikzpath_element
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 326:32: -> ^( IM_PATH '(' ( tikzpath_element )* ')' )
                    	{
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:326:35: ^( IM_PATH '(' ( tikzpath_element )* ')' )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

                    	    adaptor.AddChild(root_1, stream_51.NextNode());
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:326:49: ( tikzpath_element )*
                    	    while ( stream_tikzpath_element.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_tikzpath_element.NextTree());

                    	    }
                    	    stream_tikzpath_element.Reset();
                    	    adaptor.AddChild(root_1, stream_52.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 11 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:327:5: edgeop
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_edgeop_in_tikzpath_element_single1558);
                    	edgeop135 = edgeop();
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:330:1: controls : controls_start coord ( 'and' coord )? controls_end -> ^( IM_CONTROLS controls_start ( coord )+ controls_end ) ;
    public simpletikzParser.controls_return controls() // throws RecognitionException [1]
    {   
        simpletikzParser.controls_return retval = new simpletikzParser.controls_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal138 = null;
        simpletikzParser.controls_start_return controls_start136 = default(simpletikzParser.controls_start_return);

        simpletikzParser.coord_return coord137 = default(simpletikzParser.coord_return);

        simpletikzParser.coord_return coord139 = default(simpletikzParser.coord_return);

        simpletikzParser.controls_end_return controls_end140 = default(simpletikzParser.controls_end_return);


        object string_literal138_tree=null;
        RewriteRuleTokenStream stream_72 = new RewriteRuleTokenStream(adaptor,"token 72");
        RewriteRuleSubtreeStream stream_coord = new RewriteRuleSubtreeStream(adaptor,"rule coord");
        RewriteRuleSubtreeStream stream_controls_start = new RewriteRuleSubtreeStream(adaptor,"rule controls_start");
        RewriteRuleSubtreeStream stream_controls_end = new RewriteRuleSubtreeStream(adaptor,"rule controls_end");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:331:2: ( controls_start coord ( 'and' coord )? controls_end -> ^( IM_CONTROLS controls_start ( coord )+ controls_end ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:331:4: controls_start coord ( 'and' coord )? controls_end
            {
            	PushFollow(FOLLOW_controls_start_in_controls1573);
            	controls_start136 = controls_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_controls_start.Add(controls_start136.Tree);
            	PushFollow(FOLLOW_coord_in_controls1575);
            	coord137 = coord();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_coord.Add(coord137.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:331:25: ( 'and' coord )?
            	int alt38 = 2;
            	int LA38_0 = input.LA(1);

            	if ( (LA38_0 == 72) )
            	{
            	    alt38 = 1;
            	}
            	switch (alt38) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:331:26: 'and' coord
            	        {
            	        	string_literal138=(IToken)Match(input,72,FOLLOW_72_in_controls1578); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_72.Add(string_literal138);

            	        	PushFollow(FOLLOW_coord_in_controls1580);
            	        	coord139 = coord();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_coord.Add(coord139.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_controls_end_in_controls1584);
            	controls_end140 = controls_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_controls_end.Add(controls_end140.Tree);


            	// AST REWRITE
            	// elements:          controls_start, controls_end, coord
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 331:53: -> ^( IM_CONTROLS controls_start ( coord )+ controls_end )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:331:56: ^( IM_CONTROLS controls_start ( coord )+ controls_end )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:334:1: tikznode_ext : node_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikznode_ext_return tikznode_ext() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_ext_return retval = new simpletikzParser.tikznode_ext_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.node_start_return node_start141 = default(simpletikzParser.node_start_return);

        simpletikzParser.tikznode_core_return tikznode_core142 = default(simpletikzParser.tikznode_core_return);

        simpletikzParser.tikzpath_element_return tikzpath_element143 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end144 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_node_start = new RewriteRuleSubtreeStream(adaptor,"rule node_start");
        RewriteRuleSubtreeStream stream_tikznode_core = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_core");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:335:2: ( node_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:335:4: node_start tikznode_core ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_node_start_in_tikznode_ext1610);
            	node_start141 = node_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_node_start.Add(node_start141.Tree);
            	PushFollow(FOLLOW_tikznode_core_in_tikznode_ext1612);
            	tikznode_core142 = tikznode_core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_core.Add(tikznode_core142.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:335:29: ( tikzpath_element )*
            	do 
            	{
            	    int alt39 = 2;
            	    int LA39_0 = input.LA(1);

            	    if ( ((LA39_0 >= ID && LA39_0 <= COMMAND) || LA39_0 == 42 || LA39_0 == 44 || LA39_0 == 51 || LA39_0 == 53 || LA39_0 == 57 || LA39_0 == 71 || (LA39_0 >= 73 && LA39_0 <= 74) || (LA39_0 >= 76 && LA39_0 <= 85)) )
            	    {
            	        alt39 = 1;
            	    }


            	    switch (alt39) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:335:29: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikznode_ext1614);
            			    	tikzpath_element143 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element143.Tree);

            			    }
            			    break;

            			default:
            			    goto loop39;
            	    }
            	} while (true);

            	loop39:
            		;	// Stops C# compiler whining that label 'loop39' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikznode_ext1617);
            	semicolon_end144 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_semicolon_end.Add(semicolon_end144.Tree);


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
            	// 335:61: -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:335:64: ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_node_start.NextTree());
            	    adaptor.AddChild(root_1, stream_tikznode_core.NextTree());
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:335:99: ( tikzpath_element )*
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:338:1: tikzmatrix_ext : matrix_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH matrix_start tikznode_core ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikzmatrix_ext_return tikzmatrix_ext() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzmatrix_ext_return retval = new simpletikzParser.tikzmatrix_ext_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.matrix_start_return matrix_start145 = default(simpletikzParser.matrix_start_return);

        simpletikzParser.tikznode_core_return tikznode_core146 = default(simpletikzParser.tikznode_core_return);

        simpletikzParser.tikzpath_element_return tikzpath_element147 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end148 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_matrix_start = new RewriteRuleSubtreeStream(adaptor,"rule matrix_start");
        RewriteRuleSubtreeStream stream_tikznode_core = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_core");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:339:2: ( matrix_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH matrix_start tikznode_core ( tikzpath_element )* semicolon_end ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:339:4: matrix_start tikznode_core ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_matrix_start_in_tikzmatrix_ext1644);
            	matrix_start145 = matrix_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_matrix_start.Add(matrix_start145.Tree);
            	PushFollow(FOLLOW_tikznode_core_in_tikzmatrix_ext1646);
            	tikznode_core146 = tikznode_core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_core.Add(tikznode_core146.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:339:31: ( tikzpath_element )*
            	do 
            	{
            	    int alt40 = 2;
            	    int LA40_0 = input.LA(1);

            	    if ( ((LA40_0 >= ID && LA40_0 <= COMMAND) || LA40_0 == 42 || LA40_0 == 44 || LA40_0 == 51 || LA40_0 == 53 || LA40_0 == 57 || LA40_0 == 71 || (LA40_0 >= 73 && LA40_0 <= 74) || (LA40_0 >= 76 && LA40_0 <= 85)) )
            	    {
            	        alt40 = 1;
            	    }


            	    switch (alt40) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:339:31: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikzmatrix_ext1648);
            			    	tikzpath_element147 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element147.Tree);

            			    }
            			    break;

            			default:
            			    goto loop40;
            	    }
            	} while (true);

            	loop40:
            		;	// Stops C# compiler whining that label 'loop40' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikzmatrix_ext1651);
            	semicolon_end148 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_semicolon_end.Add(semicolon_end148.Tree);


            	// AST REWRITE
            	// elements:          tikznode_core, semicolon_end, tikzpath_element, matrix_start
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 339:63: -> ^( IM_PATH matrix_start tikznode_core ( tikzpath_element )* semicolon_end )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:339:66: ^( IM_PATH matrix_start tikznode_core ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_matrix_start.NextTree());
            	    adaptor.AddChild(root_1, stream_tikznode_core.NextTree());
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:339:103: ( tikzpath_element )*
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:343:1: tikzcoordinate_ext : coordinate_start ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ( tikzpath_element )* semicolon_end -> ^( IM_PATH coordinate_start ( tikzcoordinate_core3 )? ( tikzcoordinate_core2 )? ( tikzcoordinate_core1 )? ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_ext_return retval = new simpletikzParser.tikzcoordinate_ext_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.coordinate_start_return coordinate_start149 = default(simpletikzParser.coordinate_start_return);

        simpletikzParser.tikzcoordinate_core3_return tikzcoordinate_core3150 = default(simpletikzParser.tikzcoordinate_core3_return);

        simpletikzParser.tikzcoordinate_core2_return tikzcoordinate_core2151 = default(simpletikzParser.tikzcoordinate_core2_return);

        simpletikzParser.tikzcoordinate_core1_return tikzcoordinate_core1152 = default(simpletikzParser.tikzcoordinate_core1_return);

        simpletikzParser.tikzpath_element_return tikzpath_element153 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end154 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_tikzcoordinate_core3 = new RewriteRuleSubtreeStream(adaptor,"rule tikzcoordinate_core3");
        RewriteRuleSubtreeStream stream_tikzcoordinate_core2 = new RewriteRuleSubtreeStream(adaptor,"rule tikzcoordinate_core2");
        RewriteRuleSubtreeStream stream_coordinate_start = new RewriteRuleSubtreeStream(adaptor,"rule coordinate_start");
        RewriteRuleSubtreeStream stream_tikzcoordinate_core1 = new RewriteRuleSubtreeStream(adaptor,"rule tikzcoordinate_core1");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:344:2: ( coordinate_start ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ( tikzpath_element )* semicolon_end -> ^( IM_PATH coordinate_start ( tikzcoordinate_core3 )? ( tikzcoordinate_core2 )? ( tikzcoordinate_core1 )? ( tikzpath_element )* semicolon_end ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:344:4: coordinate_start ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_coordinate_start_in_tikzcoordinate_ext1679);
            	coordinate_start149 = coordinate_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_coordinate_start.Add(coordinate_start149.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:345:5: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?
            	int alt41 = 4;
            	alt41 = dfa41.Predict(input);
            	switch (alt41) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:345:7: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        {
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:345:7: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:345:8: ( tikzcoordinate_core3 )=> tikzcoordinate_core3
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_ext1694);
            	        		tikzcoordinate_core3150 = tikzcoordinate_core3();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( (state.backtracking==0) ) stream_tikzcoordinate_core3.Add(tikzcoordinate_core3150.Tree);

            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:346:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        {
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:346:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:346:12: ( tikzcoordinate_core2 )=> tikzcoordinate_core2
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_ext1713);
            	        		tikzcoordinate_core2151 = tikzcoordinate_core2();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( (state.backtracking==0) ) stream_tikzcoordinate_core2.Add(tikzcoordinate_core2151.Tree);

            	        	}


            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:347:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        {
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:347:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:347:12: ( tikzcoordinate_core1 )=> tikzcoordinate_core1
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_ext1733);
            	        		tikzcoordinate_core1152 = tikzcoordinate_core1();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( (state.backtracking==0) ) stream_tikzcoordinate_core1.Add(tikzcoordinate_core1152.Tree);

            	        	}


            	        }
            	        break;

            	}

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:348:6: ( tikzpath_element )*
            	do 
            	{
            	    int alt42 = 2;
            	    int LA42_0 = input.LA(1);

            	    if ( ((LA42_0 >= ID && LA42_0 <= COMMAND) || LA42_0 == 42 || LA42_0 == 44 || LA42_0 == 51 || LA42_0 == 53 || LA42_0 == 57 || LA42_0 == 71 || (LA42_0 >= 73 && LA42_0 <= 74) || (LA42_0 >= 76 && LA42_0 <= 85)) )
            	    {
            	        alt42 = 1;
            	    }


            	    switch (alt42) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:348:6: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikzcoordinate_ext1744);
            			    	tikzpath_element153 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element153.Tree);

            			    }
            			    break;

            			default:
            			    goto loop42;
            	    }
            	} while (true);

            	loop42:
            		;	// Stops C# compiler whining that label 'loop42' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikzcoordinate_ext1747);
            	semicolon_end154 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_semicolon_end.Add(semicolon_end154.Tree);


            	// AST REWRITE
            	// elements:          tikzcoordinate_core3, tikzpath_element, tikzcoordinate_core2, semicolon_end, tikzcoordinate_core1, coordinate_start
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 349:6: -> ^( IM_PATH coordinate_start ( tikzcoordinate_core3 )? ( tikzcoordinate_core2 )? ( tikzcoordinate_core1 )? ( tikzpath_element )* semicolon_end )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:349:9: ^( IM_PATH coordinate_start ( tikzcoordinate_core3 )? ( tikzcoordinate_core2 )? ( tikzcoordinate_core1 )? ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_coordinate_start.NextTree());
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:350:6: ( tikzcoordinate_core3 )?
            	    if ( stream_tikzcoordinate_core3.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzcoordinate_core3.NextTree());

            	    }
            	    stream_tikzcoordinate_core3.Reset();
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:351:6: ( tikzcoordinate_core2 )?
            	    if ( stream_tikzcoordinate_core2.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzcoordinate_core2.NextTree());

            	    }
            	    stream_tikzcoordinate_core2.Reset();
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:352:6: ( tikzcoordinate_core1 )?
            	    if ( stream_tikzcoordinate_core1.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzcoordinate_core1.NextTree());

            	    }
            	    stream_tikzcoordinate_core1.Reset();
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:353:6: ( tikzpath_element )*
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:355:1: tikzcoordinate_int : 'coordinate' ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ;
    public simpletikzParser.tikzcoordinate_int_return tikzcoordinate_int() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_int_return retval = new simpletikzParser.tikzcoordinate_int_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal155 = null;
        simpletikzParser.tikzcoordinate_core3_return tikzcoordinate_core3156 = default(simpletikzParser.tikzcoordinate_core3_return);

        simpletikzParser.tikzcoordinate_core2_return tikzcoordinate_core2157 = default(simpletikzParser.tikzcoordinate_core2_return);

        simpletikzParser.tikzcoordinate_core1_return tikzcoordinate_core1158 = default(simpletikzParser.tikzcoordinate_core1_return);


        object string_literal155_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:356:2: ( 'coordinate' ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:356:4: 'coordinate' ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal155=(IToken)Match(input,73,FOLLOW_73_in_tikzcoordinate_int1807); if (state.failed) return retval;
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:356:18: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?
            	int alt43 = 4;
            	alt43 = dfa43.Predict(input);
            	switch (alt43) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:356:20: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        {
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:356:20: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:356:21: ( tikzcoordinate_core3 )=> tikzcoordinate_core3
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_int1818);
            	        		tikzcoordinate_core3156 = tikzcoordinate_core3();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_core3156.Tree);

            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:357:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        {
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:357:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:357:12: ( tikzcoordinate_core2 )=> tikzcoordinate_core2
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_int1837);
            	        		tikzcoordinate_core2157 = tikzcoordinate_core2();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_core2157.Tree);

            	        	}


            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:358:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        {
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:358:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:358:12: ( tikzcoordinate_core1 )=> tikzcoordinate_core1
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_int1857);
            	        		tikzcoordinate_core1158 = tikzcoordinate_core1();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_core1158.Tree);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:360:1: tikznode_int : 'node' tikznode_core ;
    public simpletikzParser.tikznode_int_return tikznode_int() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_int_return retval = new simpletikzParser.tikznode_int_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal159 = null;
        simpletikzParser.tikznode_core_return tikznode_core160 = default(simpletikzParser.tikznode_core_return);


        object string_literal159_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:361:2: ( 'node' tikznode_core )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:361:4: 'node' tikznode_core
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal159=(IToken)Match(input,74,FOLLOW_74_in_tikznode_int1873); if (state.failed) return retval;
            	PushFollow(FOLLOW_tikznode_core_in_tikznode_int1876);
            	tikznode_core160 = tikznode_core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_core160.Tree);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:363:1: tikznode_core : ( tikznode_decorator )* tikzstring -> ^( IM_NODE ( tikznode_decorator )* tikzstring ) ;
    public simpletikzParser.tikznode_core_return tikznode_core() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_core_return retval = new simpletikzParser.tikznode_core_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator161 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikzstring_return tikzstring162 = default(simpletikzParser.tikzstring_return);


        RewriteRuleSubtreeStream stream_tikzstring = new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:364:2: ( ( tikznode_decorator )* tikzstring -> ^( IM_NODE ( tikznode_decorator )* tikzstring ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:364:4: ( tikznode_decorator )* tikzstring
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:364:4: ( tikznode_decorator )*
            	do 
            	{
            	    int alt44 = 2;
            	    int LA44_0 = input.LA(1);

            	    if ( (LA44_0 == 51 || LA44_0 == 53 || LA44_0 == 75) )
            	    {
            	        alt44 = 1;
            	    }


            	    switch (alt44) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:364:4: tikznode_decorator
            			    {
            			    	PushFollow(FOLLOW_tikznode_decorator_in_tikznode_core1886);
            			    	tikznode_decorator161 = tikznode_decorator();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator161.Tree);

            			    }
            			    break;

            			default:
            			    goto loop44;
            	    }
            	} while (true);

            	loop44:
            		;	// Stops C# compiler whining that label 'loop44' has no statements

            	PushFollow(FOLLOW_tikzstring_in_tikznode_core1889);
            	tikzstring162 = tikzstring();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzstring.Add(tikzstring162.Tree);


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
            	// 364:36: -> ^( IM_NODE ( tikznode_decorator )* tikzstring )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:364:39: ^( IM_NODE ( tikznode_decorator )* tikzstring )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NODE, "IM_NODE"), root_1);

            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:364:49: ( tikznode_decorator )*
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:367:1: tikzcoordinate_core3 : tikznode_decorator tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator ) ;
    public simpletikzParser.tikzcoordinate_core3_return tikzcoordinate_core3() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_core3_return retval = new simpletikzParser.tikzcoordinate_core3_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator163 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikznode_decorator_return tikznode_decorator164 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikznode_decorator_return tikznode_decorator165 = default(simpletikzParser.tikznode_decorator_return);


        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:368:2: ( tikznode_decorator tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:368:6: tikznode_decorator tikznode_decorator tikznode_decorator
            {
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core31914);
            	tikznode_decorator163 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator163.Tree);
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core31916);
            	tikznode_decorator164 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator164.Tree);
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core31918);
            	tikznode_decorator165 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator165.Tree);


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
            	// 368:64: -> ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:368:67: ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:372:1: tikzcoordinate_core2 : tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator ) ;
    public simpletikzParser.tikzcoordinate_core2_return tikzcoordinate_core2() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_core2_return retval = new simpletikzParser.tikzcoordinate_core2_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator166 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikznode_decorator_return tikznode_decorator167 = default(simpletikzParser.tikznode_decorator_return);


        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:373:2: ( tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:374:4: tikznode_decorator tikznode_decorator
            {
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core21952);
            	tikznode_decorator166 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator166.Tree);
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core21954);
            	tikznode_decorator167 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator167.Tree);


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
            	// 374:47: -> ^( IM_NODE tikznode_decorator tikznode_decorator )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:374:50: ^( IM_NODE tikznode_decorator tikznode_decorator )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:377:1: tikzcoordinate_core1 : tikznode_decorator -> ^( IM_NODE tikznode_decorator ) ;
    public simpletikzParser.tikzcoordinate_core1_return tikzcoordinate_core1() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_core1_return retval = new simpletikzParser.tikzcoordinate_core1_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator168 = default(simpletikzParser.tikznode_decorator_return);


        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:378:2: ( tikznode_decorator -> ^( IM_NODE tikznode_decorator ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:379:4: tikznode_decorator
            {
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core11987);
            	tikznode_decorator168 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator168.Tree);


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
            	// 379:31: -> ^( IM_NODE tikznode_decorator )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:379:34: ^( IM_NODE tikznode_decorator )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:386:1: tikznode_decorator : ( nodename | 'at' COMMAND | 'at' coord | tikz_options_dontcare );
    public simpletikzParser.tikznode_decorator_return tikznode_decorator() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_decorator_return retval = new simpletikzParser.tikznode_decorator_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal170 = null;
        IToken COMMAND171 = null;
        IToken string_literal172 = null;
        simpletikzParser.nodename_return nodename169 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_return coord173 = default(simpletikzParser.coord_return);

        simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare174 = default(simpletikzParser.tikz_options_dontcare_return);


        object string_literal170_tree=null;
        object COMMAND171_tree=null;
        object string_literal172_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:387:2: ( nodename | 'at' COMMAND | 'at' coord | tikz_options_dontcare )
            int alt45 = 4;
            switch ( input.LA(1) ) 
            {
            case 51:
            	{
                alt45 = 1;
                }
                break;
            case 75:
            	{
                int LA45_2 = input.LA(2);

                if ( (LA45_2 == COMMAND) )
                {
                    alt45 = 2;
                }
                else if ( (LA45_2 == 51 || (LA45_2 >= 83 && LA45_2 <= 84)) )
                {
                    alt45 = 3;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d45s2 =
                        new NoViableAltException("", 45, 2, input);

                    throw nvae_d45s2;
                }
                }
                break;
            case 53:
            	{
                alt45 = 4;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d45s0 =
            	        new NoViableAltException("", 45, 0, input);

            	    throw nvae_d45s0;
            }

            switch (alt45) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:387:6: nodename
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_nodename_in_tikznode_decorator2024);
                    	nodename169 = nodename();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, nodename169.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:388:5: 'at' COMMAND
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal170=(IToken)Match(input,75,FOLLOW_75_in_tikznode_decorator2031); if (state.failed) return retval;
                    	COMMAND171=(IToken)Match(input,COMMAND,FOLLOW_COMMAND_in_tikznode_decorator2034); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{COMMAND171_tree = (object)adaptor.Create(COMMAND171);
                    		adaptor.AddChild(root_0, COMMAND171_tree);
                    	}

                    }
                    break;
                case 3 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:389:5: 'at' coord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal172=(IToken)Match(input,75,FOLLOW_75_in_tikznode_decorator2040); if (state.failed) return retval;
                    	PushFollow(FOLLOW_coord_in_tikznode_decorator2043);
                    	coord173 = coord();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, coord173.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:390:5: tikz_options_dontcare
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_options_dontcare_in_tikznode_decorator2049);
                    	tikz_options_dontcare174 = tikz_options_dontcare();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_options_dontcare174.Tree);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:392:1: tikz_options_dontcare : '[' ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* ']' -> ^( IM_OPTIONS ) ;
    public simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_options_dontcare_return retval = new simpletikzParser.tikz_options_dontcare_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal175 = null;
        IToken char_literal179 = null;
        simpletikzParser.no_rlbracket_return no_rlbracket176 = default(simpletikzParser.no_rlbracket_return);

        simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare177 = default(simpletikzParser.tikz_options_dontcare_return);

        simpletikzParser.no_rlbracket_return no_rlbracket178 = default(simpletikzParser.no_rlbracket_return);


        object char_literal175_tree=null;
        object char_literal179_tree=null;
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleSubtreeStream stream_tikz_options_dontcare = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options_dontcare");
        RewriteRuleSubtreeStream stream_no_rlbracket = new RewriteRuleSubtreeStream(adaptor,"rule no_rlbracket");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:393:2: ( '[' ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* ']' -> ^( IM_OPTIONS ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:393:4: '[' ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* ']'
            {
            	char_literal175=(IToken)Match(input,53,FOLLOW_53_in_tikz_options_dontcare2059); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_53.Add(char_literal175);

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:393:8: ( no_rlbracket )*
            	do 
            	{
            	    int alt46 = 2;
            	    int LA46_0 = input.LA(1);

            	    if ( ((LA46_0 >= IM_PATH && LA46_0 <= 52) || (LA46_0 >= 55 && LA46_0 <= 88)) )
            	    {
            	        alt46 = 1;
            	    }


            	    switch (alt46) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:393:8: no_rlbracket
            			    {
            			    	PushFollow(FOLLOW_no_rlbracket_in_tikz_options_dontcare2061);
            			    	no_rlbracket176 = no_rlbracket();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_no_rlbracket.Add(no_rlbracket176.Tree);

            			    }
            			    break;

            			default:
            			    goto loop46;
            	    }
            	} while (true);

            	loop46:
            		;	// Stops C# compiler whining that label 'loop46' has no statements

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:393:22: ( tikz_options_dontcare ( no_rlbracket )* )*
            	do 
            	{
            	    int alt48 = 2;
            	    int LA48_0 = input.LA(1);

            	    if ( (LA48_0 == 53) )
            	    {
            	        alt48 = 1;
            	    }


            	    switch (alt48) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:393:23: tikz_options_dontcare ( no_rlbracket )*
            			    {
            			    	PushFollow(FOLLOW_tikz_options_dontcare_in_tikz_options_dontcare2065);
            			    	tikz_options_dontcare177 = tikz_options_dontcare();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikz_options_dontcare.Add(tikz_options_dontcare177.Tree);
            			    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:393:45: ( no_rlbracket )*
            			    	do 
            			    	{
            			    	    int alt47 = 2;
            			    	    int LA47_0 = input.LA(1);

            			    	    if ( ((LA47_0 >= IM_PATH && LA47_0 <= 52) || (LA47_0 >= 55 && LA47_0 <= 88)) )
            			    	    {
            			    	        alt47 = 1;
            			    	    }


            			    	    switch (alt47) 
            			    		{
            			    			case 1 :
            			    			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:393:45: no_rlbracket
            			    			    {
            			    			    	PushFollow(FOLLOW_no_rlbracket_in_tikz_options_dontcare2067);
            			    			    	no_rlbracket178 = no_rlbracket();
            			    			    	state.followingStackPointer--;
            			    			    	if (state.failed) return retval;
            			    			    	if ( (state.backtracking==0) ) stream_no_rlbracket.Add(no_rlbracket178.Tree);

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop47;
            			    	    }
            			    	} while (true);

            			    	loop47:
            			    		;	// Stops C# compiler whining that label 'loop47' has no statements


            			    }
            			    break;

            			default:
            			    goto loop48;
            	    }
            	} while (true);

            	loop48:
            		;	// Stops C# compiler whining that label 'loop48' has no statements

            	char_literal179=(IToken)Match(input,54,FOLLOW_54_in_tikz_options_dontcare2072); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_54.Add(char_literal179);



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
            	// 393:65: -> ^( IM_OPTIONS )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:393:68: ^( IM_OPTIONS )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:395:1: no_rlbracket : ~ ( '[' | ']' ) ;
    public simpletikzParser.no_rlbracket_return no_rlbracket() // throws RecognitionException [1]
    {   
        simpletikzParser.no_rlbracket_return retval = new simpletikzParser.no_rlbracket_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set180 = null;

        object set180_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:396:2: (~ ( '[' | ']' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:396:4: ~ ( '[' | ']' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set180 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= 52) || (input.LA(1) >= 55 && input.LA(1) <= 88) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set180));
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:398:1: nodename : '(' idd ')' -> ^( IM_NODENAME idd ) ;
    public simpletikzParser.nodename_return nodename() // throws RecognitionException [1]
    {   
        simpletikzParser.nodename_return retval = new simpletikzParser.nodename_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal181 = null;
        IToken char_literal183 = null;
        simpletikzParser.idd_return idd182 = default(simpletikzParser.idd_return);


        object char_literal181_tree=null;
        object char_literal183_tree=null;
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:399:2: ( '(' idd ')' -> ^( IM_NODENAME idd ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:399:4: '(' idd ')'
            {
            	char_literal181=(IToken)Match(input,51,FOLLOW_51_in_nodename2107); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_51.Add(char_literal181);

            	PushFollow(FOLLOW_idd_in_nodename2109);
            	idd182 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idd.Add(idd182.Tree);
            	char_literal183=(IToken)Match(input,52,FOLLOW_52_in_nodename2111); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_52.Add(char_literal183);



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
            	// 399:17: -> ^( IM_NODENAME idd )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:399:20: ^( IM_NODENAME idd )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:405:1: circle : ( 'circle' | 'ellipse' ) ( ( size )=> size )? ->;
    public simpletikzParser.circle_return circle() // throws RecognitionException [1]
    {   
        simpletikzParser.circle_return retval = new simpletikzParser.circle_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal184 = null;
        IToken string_literal185 = null;
        simpletikzParser.size_return size186 = default(simpletikzParser.size_return);


        object string_literal184_tree=null;
        object string_literal185_tree=null;
        RewriteRuleTokenStream stream_77 = new RewriteRuleTokenStream(adaptor,"token 77");
        RewriteRuleTokenStream stream_76 = new RewriteRuleTokenStream(adaptor,"token 76");
        RewriteRuleSubtreeStream stream_size = new RewriteRuleSubtreeStream(adaptor,"rule size");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:406:2: ( ( 'circle' | 'ellipse' ) ( ( size )=> size )? ->)
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:406:4: ( 'circle' | 'ellipse' ) ( ( size )=> size )?
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:406:4: ( 'circle' | 'ellipse' )
            	int alt49 = 2;
            	int LA49_0 = input.LA(1);

            	if ( (LA49_0 == 76) )
            	{
            	    alt49 = 1;
            	}
            	else if ( (LA49_0 == 77) )
            	{
            	    alt49 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d49s0 =
            	        new NoViableAltException("", 49, 0, input);

            	    throw nvae_d49s0;
            	}
            	switch (alt49) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:406:5: 'circle'
            	        {
            	        	string_literal184=(IToken)Match(input,76,FOLLOW_76_in_circle2136); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_76.Add(string_literal184);


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:406:16: 'ellipse'
            	        {
            	        	string_literal185=(IToken)Match(input,77,FOLLOW_77_in_circle2140); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_77.Add(string_literal185);


            	        }
            	        break;

            	}

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:406:27: ( ( size )=> size )?
            	int alt50 = 2;
            	alt50 = dfa50.Predict(input);
            	switch (alt50) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:406:28: ( size )=> size
            	        {
            	        	PushFollow(FOLLOW_size_in_circle2149);
            	        	size186 = size();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_size.Add(size186.Tree);

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
            	// 406:44: ->
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:408:1: arc : ( 'arc' ( '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')' ) -> ^( IM_ARC ( numberunitorvariable )+ ( numberunit )? ) | 'arc' ( '(' coord_part ':' coord_part ':' coord_part ( 'and' numberunit )? ')' ) -> ^( IM_ARC ( coord_part )+ ( numberunit )? ) | 'arc' tikz_options -> ^( IM_DONTCARE ) );
    public simpletikzParser.arc_return arc() // throws RecognitionException [1]
    {   
        simpletikzParser.arc_return retval = new simpletikzParser.arc_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal187 = null;
        IToken char_literal188 = null;
        IToken char_literal190 = null;
        IToken char_literal192 = null;
        IToken string_literal194 = null;
        IToken char_literal196 = null;
        IToken string_literal197 = null;
        IToken char_literal198 = null;
        IToken char_literal200 = null;
        IToken char_literal202 = null;
        IToken string_literal204 = null;
        IToken char_literal206 = null;
        IToken string_literal207 = null;
        simpletikzParser.numberunitorvariable_return numberunitorvariable189 = default(simpletikzParser.numberunitorvariable_return);

        simpletikzParser.numberunitorvariable_return numberunitorvariable191 = default(simpletikzParser.numberunitorvariable_return);

        simpletikzParser.numberunitorvariable_return numberunitorvariable193 = default(simpletikzParser.numberunitorvariable_return);

        simpletikzParser.numberunit_return numberunit195 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_part_return coord_part199 = default(simpletikzParser.coord_part_return);

        simpletikzParser.coord_part_return coord_part201 = default(simpletikzParser.coord_part_return);

        simpletikzParser.coord_part_return coord_part203 = default(simpletikzParser.coord_part_return);

        simpletikzParser.numberunit_return numberunit205 = default(simpletikzParser.numberunit_return);

        simpletikzParser.tikz_options_return tikz_options208 = default(simpletikzParser.tikz_options_return);


        object string_literal187_tree=null;
        object char_literal188_tree=null;
        object char_literal190_tree=null;
        object char_literal192_tree=null;
        object string_literal194_tree=null;
        object char_literal196_tree=null;
        object string_literal197_tree=null;
        object char_literal198_tree=null;
        object char_literal200_tree=null;
        object char_literal202_tree=null;
        object string_literal204_tree=null;
        object char_literal206_tree=null;
        object string_literal207_tree=null;
        RewriteRuleTokenStream stream_78 = new RewriteRuleTokenStream(adaptor,"token 78");
        RewriteRuleTokenStream stream_47 = new RewriteRuleTokenStream(adaptor,"token 47");
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleTokenStream stream_72 = new RewriteRuleTokenStream(adaptor,"token 72");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_numberunitorvariable = new RewriteRuleSubtreeStream(adaptor,"rule numberunitorvariable");
        RewriteRuleSubtreeStream stream_coord_part = new RewriteRuleSubtreeStream(adaptor,"rule coord_part");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:409:2: ( 'arc' ( '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')' ) -> ^( IM_ARC ( numberunitorvariable )+ ( numberunit )? ) | 'arc' ( '(' coord_part ':' coord_part ':' coord_part ( 'and' numberunit )? ')' ) -> ^( IM_ARC ( coord_part )+ ( numberunit )? ) | 'arc' tikz_options -> ^( IM_DONTCARE ) )
            int alt53 = 3;
            alt53 = dfa53.Predict(input);
            switch (alt53) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:409:4: 'arc' ( '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')' )
                    {
                    	string_literal187=(IToken)Match(input,78,FOLLOW_78_in_arc2164); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_78.Add(string_literal187);

                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:409:10: ( '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')' )
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:409:11: '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')'
                    	{
                    		char_literal188=(IToken)Match(input,51,FOLLOW_51_in_arc2167); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_51.Add(char_literal188);

                    		PushFollow(FOLLOW_numberunitorvariable_in_arc2169);
                    		numberunitorvariable189 = numberunitorvariable();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_numberunitorvariable.Add(numberunitorvariable189.Tree);
                    		char_literal190=(IToken)Match(input,47,FOLLOW_47_in_arc2171); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_47.Add(char_literal190);

                    		PushFollow(FOLLOW_numberunitorvariable_in_arc2173);
                    		numberunitorvariable191 = numberunitorvariable();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_numberunitorvariable.Add(numberunitorvariable191.Tree);
                    		char_literal192=(IToken)Match(input,47,FOLLOW_47_in_arc2175); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_47.Add(char_literal192);

                    		PushFollow(FOLLOW_numberunitorvariable_in_arc2177);
                    		numberunitorvariable193 = numberunitorvariable();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_numberunitorvariable.Add(numberunitorvariable193.Tree);
                    		// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:409:86: ( 'and' numberunit )?
                    		int alt51 = 2;
                    		int LA51_0 = input.LA(1);

                    		if ( (LA51_0 == 72) )
                    		{
                    		    alt51 = 1;
                    		}
                    		switch (alt51) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:409:87: 'and' numberunit
                    		        {
                    		        	string_literal194=(IToken)Match(input,72,FOLLOW_72_in_arc2180); if (state.failed) return retval; 
                    		        	if ( (state.backtracking==0) ) stream_72.Add(string_literal194);

                    		        	PushFollow(FOLLOW_numberunit_in_arc2182);
                    		        	numberunit195 = numberunit();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit195.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal196=(IToken)Match(input,52,FOLLOW_52_in_arc2186); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_52.Add(char_literal196);


                    	}



                    	// AST REWRITE
                    	// elements:          numberunitorvariable, numberunit
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 409:111: -> ^( IM_ARC ( numberunitorvariable )+ ( numberunit )? )
                    	{
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:409:114: ^( IM_ARC ( numberunitorvariable )+ ( numberunit )? )
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
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:409:145: ( numberunit )?
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
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:410:4: 'arc' ( '(' coord_part ':' coord_part ':' coord_part ( 'and' numberunit )? ')' )
                    {
                    	string_literal197=(IToken)Match(input,78,FOLLOW_78_in_arc2204); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_78.Add(string_literal197);

                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:410:10: ( '(' coord_part ':' coord_part ':' coord_part ( 'and' numberunit )? ')' )
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:410:11: '(' coord_part ':' coord_part ':' coord_part ( 'and' numberunit )? ')'
                    	{
                    		char_literal198=(IToken)Match(input,51,FOLLOW_51_in_arc2207); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_51.Add(char_literal198);

                    		PushFollow(FOLLOW_coord_part_in_arc2209);
                    		coord_part199 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_part.Add(coord_part199.Tree);
                    		char_literal200=(IToken)Match(input,47,FOLLOW_47_in_arc2211); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_47.Add(char_literal200);

                    		PushFollow(FOLLOW_coord_part_in_arc2213);
                    		coord_part201 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_part.Add(coord_part201.Tree);
                    		char_literal202=(IToken)Match(input,47,FOLLOW_47_in_arc2215); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_47.Add(char_literal202);

                    		PushFollow(FOLLOW_coord_part_in_arc2217);
                    		coord_part203 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_part.Add(coord_part203.Tree);
                    		// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:410:56: ( 'and' numberunit )?
                    		int alt52 = 2;
                    		int LA52_0 = input.LA(1);

                    		if ( (LA52_0 == 72) )
                    		{
                    		    alt52 = 1;
                    		}
                    		switch (alt52) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:410:57: 'and' numberunit
                    		        {
                    		        	string_literal204=(IToken)Match(input,72,FOLLOW_72_in_arc2220); if (state.failed) return retval; 
                    		        	if ( (state.backtracking==0) ) stream_72.Add(string_literal204);

                    		        	PushFollow(FOLLOW_numberunit_in_arc2222);
                    		        	numberunit205 = numberunit();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit205.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal206=(IToken)Match(input,52,FOLLOW_52_in_arc2226); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_52.Add(char_literal206);


                    	}



                    	// AST REWRITE
                    	// elements:          coord_part, numberunit
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 410:81: -> ^( IM_ARC ( coord_part )+ ( numberunit )? )
                    	{
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:410:84: ^( IM_ARC ( coord_part )+ ( numberunit )? )
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
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:410:105: ( numberunit )?
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
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:411:4: 'arc' tikz_options
                    {
                    	string_literal207=(IToken)Match(input,78,FOLLOW_78_in_arc2244); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_78.Add(string_literal207);

                    	PushFollow(FOLLOW_tikz_options_in_arc2246);
                    	tikz_options208 = tikz_options();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_tikz_options.Add(tikz_options208.Tree);


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
                    	// 411:23: -> ^( IM_DONTCARE )
                    	{
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:411:25: ^( IM_DONTCARE )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:418:1: size : '(' numberunit ( 'and' numberunit )? ')' -> ^( IM_SIZE ( numberunit )* ) ;
    public simpletikzParser.size_return size() // throws RecognitionException [1]
    {   
        simpletikzParser.size_return retval = new simpletikzParser.size_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal209 = null;
        IToken string_literal211 = null;
        IToken char_literal213 = null;
        simpletikzParser.numberunit_return numberunit210 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit212 = default(simpletikzParser.numberunit_return);


        object char_literal209_tree=null;
        object string_literal211_tree=null;
        object char_literal213_tree=null;
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleTokenStream stream_72 = new RewriteRuleTokenStream(adaptor,"token 72");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:419:2: ( '(' numberunit ( 'and' numberunit )? ')' -> ^( IM_SIZE ( numberunit )* ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:419:6: '(' numberunit ( 'and' numberunit )? ')'
            {
            	char_literal209=(IToken)Match(input,51,FOLLOW_51_in_size2271); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_51.Add(char_literal209);

            	PushFollow(FOLLOW_numberunit_in_size2273);
            	numberunit210 = numberunit();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit210.Tree);
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:419:21: ( 'and' numberunit )?
            	int alt54 = 2;
            	int LA54_0 = input.LA(1);

            	if ( (LA54_0 == 72) )
            	{
            	    alt54 = 1;
            	}
            	switch (alt54) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:419:22: 'and' numberunit
            	        {
            	        	string_literal211=(IToken)Match(input,72,FOLLOW_72_in_size2276); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_72.Add(string_literal211);

            	        	PushFollow(FOLLOW_numberunit_in_size2278);
            	        	numberunit212 = numberunit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit212.Tree);

            	        }
            	        break;

            	}

            	char_literal213=(IToken)Match(input,52,FOLLOW_52_in_size2282); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_52.Add(char_literal213);



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
            	// 419:46: -> ^( IM_SIZE ( numberunit )* )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:419:49: ^( IM_SIZE ( numberunit )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_SIZE, "IM_SIZE"), root_1);

            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:419:59: ( numberunit )*
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:426:1: coord_nodename : '(' ( tikz_options )? idd ')' -> ^( IM_NODENAME idd ( tikz_options )? ) ;
    public simpletikzParser.coord_nodename_return coord_nodename() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_nodename_return retval = new simpletikzParser.coord_nodename_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal214 = null;
        IToken char_literal217 = null;
        simpletikzParser.tikz_options_return tikz_options215 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.idd_return idd216 = default(simpletikzParser.idd_return);


        object char_literal214_tree=null;
        object char_literal217_tree=null;
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:427:2: ( '(' ( tikz_options )? idd ')' -> ^( IM_NODENAME idd ( tikz_options )? ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:427:4: '(' ( tikz_options )? idd ')'
            {
            	char_literal214=(IToken)Match(input,51,FOLLOW_51_in_coord_nodename2310); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_51.Add(char_literal214);

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:427:8: ( tikz_options )?
            	int alt55 = 2;
            	int LA55_0 = input.LA(1);

            	if ( (LA55_0 == 53) )
            	{
            	    alt55 = 1;
            	}
            	switch (alt55) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:427:8: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_coord_nodename2312);
            	        	tikz_options215 = tikz_options();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_tikz_options.Add(tikz_options215.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_idd_in_coord_nodename2315);
            	idd216 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idd.Add(idd216.Tree);
            	char_literal217=(IToken)Match(input,52,FOLLOW_52_in_coord_nodename2318); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_52.Add(char_literal217);



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
            	// 427:32: -> ^( IM_NODENAME idd ( tikz_options )? )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:427:35: ^( IM_NODENAME idd ( tikz_options )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NODENAME, "IM_NODENAME"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:427:53: ( tikz_options )?
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:428:1: coord : ( coord_nodename -> ^( IM_COORD coord_nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) );
    public simpletikzParser.coord_return coord() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_return retval = new simpletikzParser.coord_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal220 = null;
        IToken char_literal224 = null;
        IToken char_literal226 = null;
        IToken char_literal230 = null;
        simpletikzParser.coord_nodename_return coord_nodename218 = default(simpletikzParser.coord_nodename_return);

        simpletikzParser.coord_modifier_return coord_modifier219 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.numberunit_return numberunit221 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_sep_return coord_sep222 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.numberunit_return numberunit223 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_modifier_return coord_modifier225 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.coord_part_return coord_part227 = default(simpletikzParser.coord_part_return);

        simpletikzParser.coord_sep_return coord_sep228 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.coord_part_return coord_part229 = default(simpletikzParser.coord_part_return);


        object char_literal220_tree=null;
        object char_literal224_tree=null;
        object char_literal226_tree=null;
        object char_literal230_tree=null;
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_coord_nodename = new RewriteRuleSubtreeStream(adaptor,"rule coord_nodename");
        RewriteRuleSubtreeStream stream_coord_part = new RewriteRuleSubtreeStream(adaptor,"rule coord_part");
        RewriteRuleSubtreeStream stream_coord_sep = new RewriteRuleSubtreeStream(adaptor,"rule coord_sep");
        RewriteRuleSubtreeStream stream_coord_modifier = new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:429:2: ( coord_nodename -> ^( IM_COORD coord_nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) )
            int alt58 = 3;
            alt58 = dfa58.Predict(input);
            switch (alt58) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:429:6: coord_nodename
                    {
                    	PushFollow(FOLLOW_coord_nodename_in_coord2342);
                    	coord_nodename218 = coord_nodename();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_coord_nodename.Add(coord_nodename218.Tree);


                    	// AST REWRITE
                    	// elements:          coord_nodename
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 429:27: -> ^( IM_COORD coord_nodename )
                    	{
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:429:30: ^( IM_COORD coord_nodename )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    adaptor.AddChild(root_1, stream_coord_nodename.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:430:5: ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' )
                    {
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:430:5: ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' )
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:430:7: ( coord_modifier )? '(' numberunit coord_sep numberunit ')'
                    	{
                    		// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:430:7: ( coord_modifier )?
                    		int alt56 = 2;
                    		int LA56_0 = input.LA(1);

                    		if ( ((LA56_0 >= 83 && LA56_0 <= 84)) )
                    		{
                    		    alt56 = 1;
                    		}
                    		switch (alt56) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:430:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord2366);
                    		        	coord_modifier219 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_coord_modifier.Add(coord_modifier219.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal220=(IToken)Match(input,51,FOLLOW_51_in_coord2369); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_51.Add(char_literal220);

                    		PushFollow(FOLLOW_numberunit_in_coord2371);
                    		numberunit221 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit221.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord2373);
                    		coord_sep222 = coord_sep();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_sep.Add(coord_sep222.Tree);
                    		PushFollow(FOLLOW_numberunit_in_coord2375);
                    		numberunit223 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit223.Tree);
                    		char_literal224=(IToken)Match(input,52,FOLLOW_52_in_coord2377); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_52.Add(char_literal224);


                    	}



                    	// AST REWRITE
                    	// elements:          coord_sep, numberunit, coord_modifier
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 430:65: -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep )
                    	{
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:430:68: ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:430:79: ( coord_modifier )?
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
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:431:5: ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' )
                    {
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:431:5: ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' )
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:431:7: ( coord_modifier )? '(' coord_part coord_sep coord_part ')'
                    	{
                    		// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:431:7: ( coord_modifier )?
                    		int alt57 = 2;
                    		int LA57_0 = input.LA(1);

                    		if ( ((LA57_0 >= 83 && LA57_0 <= 84)) )
                    		{
                    		    alt57 = 1;
                    		}
                    		switch (alt57) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:431:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord2401);
                    		        	coord_modifier225 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_coord_modifier.Add(coord_modifier225.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal226=(IToken)Match(input,51,FOLLOW_51_in_coord2404); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_51.Add(char_literal226);

                    		PushFollow(FOLLOW_coord_part_in_coord2406);
                    		coord_part227 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_part.Add(coord_part227.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord2408);
                    		coord_sep228 = coord_sep();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_sep.Add(coord_sep228.Tree);
                    		PushFollow(FOLLOW_coord_part_in_coord2410);
                    		coord_part229 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_part.Add(coord_part229.Tree);
                    		char_literal230=(IToken)Match(input,52,FOLLOW_52_in_coord2412); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_52.Add(char_literal230);


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
                    	// 431:65: -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep )
                    	{
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:431:68: ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:431:79: ( coord_modifier )?
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:433:1: coord_nooption : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) );
    public simpletikzParser.coord_nooption_return coord_nooption() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_nooption_return retval = new simpletikzParser.coord_nooption_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal233 = null;
        IToken char_literal237 = null;
        IToken char_literal239 = null;
        IToken char_literal243 = null;
        simpletikzParser.nodename_return nodename231 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_modifier_return coord_modifier232 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.numberunit_return numberunit234 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_sep_return coord_sep235 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.numberunit_return numberunit236 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_modifier_return coord_modifier238 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.coord_part_return coord_part240 = default(simpletikzParser.coord_part_return);

        simpletikzParser.coord_sep_return coord_sep241 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.coord_part_return coord_part242 = default(simpletikzParser.coord_part_return);


        object char_literal233_tree=null;
        object char_literal237_tree=null;
        object char_literal239_tree=null;
        object char_literal243_tree=null;
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_coord_part = new RewriteRuleSubtreeStream(adaptor,"rule coord_part");
        RewriteRuleSubtreeStream stream_coord_sep = new RewriteRuleSubtreeStream(adaptor,"rule coord_sep");
        RewriteRuleSubtreeStream stream_nodename = new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        RewriteRuleSubtreeStream stream_coord_modifier = new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:434:2: ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) )
            int alt61 = 3;
            alt61 = dfa61.Predict(input);
            switch (alt61) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:434:6: nodename
                    {
                    	PushFollow(FOLLOW_nodename_in_coord_nooption2441);
                    	nodename231 = nodename();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_nodename.Add(nodename231.Tree);


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
                    	// 434:22: -> ^( IM_COORD nodename )
                    	{
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:434:25: ^( IM_COORD nodename )
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
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:435:5: ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' )
                    {
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:435:5: ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' )
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:435:7: ( coord_modifier )? '(' numberunit coord_sep numberunit ')'
                    	{
                    		// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:435:7: ( coord_modifier )?
                    		int alt59 = 2;
                    		int LA59_0 = input.LA(1);

                    		if ( ((LA59_0 >= 83 && LA59_0 <= 84)) )
                    		{
                    		    alt59 = 1;
                    		}
                    		switch (alt59) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:435:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord_nooption2465);
                    		        	coord_modifier232 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_coord_modifier.Add(coord_modifier232.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal233=(IToken)Match(input,51,FOLLOW_51_in_coord_nooption2468); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_51.Add(char_literal233);

                    		PushFollow(FOLLOW_numberunit_in_coord_nooption2470);
                    		numberunit234 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit234.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord_nooption2472);
                    		coord_sep235 = coord_sep();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_sep.Add(coord_sep235.Tree);
                    		PushFollow(FOLLOW_numberunit_in_coord_nooption2474);
                    		numberunit236 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit236.Tree);
                    		char_literal237=(IToken)Match(input,52,FOLLOW_52_in_coord_nooption2476); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_52.Add(char_literal237);


                    	}



                    	// AST REWRITE
                    	// elements:          coord_modifier, numberunit, coord_sep
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 435:65: -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep )
                    	{
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:435:68: ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:435:79: ( coord_modifier )?
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
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:436:5: ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' )
                    {
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:436:5: ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' )
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:436:7: ( coord_modifier )? '(' coord_part coord_sep coord_part ')'
                    	{
                    		// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:436:7: ( coord_modifier )?
                    		int alt60 = 2;
                    		int LA60_0 = input.LA(1);

                    		if ( ((LA60_0 >= 83 && LA60_0 <= 84)) )
                    		{
                    		    alt60 = 1;
                    		}
                    		switch (alt60) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:436:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord_nooption2500);
                    		        	coord_modifier238 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_coord_modifier.Add(coord_modifier238.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal239=(IToken)Match(input,51,FOLLOW_51_in_coord_nooption2503); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_51.Add(char_literal239);

                    		PushFollow(FOLLOW_coord_part_in_coord_nooption2505);
                    		coord_part240 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_part.Add(coord_part240.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord_nooption2507);
                    		coord_sep241 = coord_sep();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_sep.Add(coord_sep241.Tree);
                    		PushFollow(FOLLOW_coord_part_in_coord_nooption2509);
                    		coord_part242 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_part.Add(coord_part242.Tree);
                    		char_literal243=(IToken)Match(input,52,FOLLOW_52_in_coord_nooption2511); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_52.Add(char_literal243);


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
                    	// 436:65: -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep )
                    	{
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:436:68: ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:436:79: ( coord_modifier )?
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:445:1: coord_part : ( idd -> ^( IM_DONTCARE idd ) | '{' idd '}' -> ^( IM_DONTCARE '{' idd '}' ) | ( idd '=' numberunit ( ',' )? )+ -> ^( IM_DONTCARE ( idd '=' numberunit ( ',' )? )+ ) );
    public simpletikzParser.coord_part_return coord_part() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_part_return retval = new simpletikzParser.coord_part_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal245 = null;
        IToken char_literal247 = null;
        IToken char_literal249 = null;
        IToken char_literal251 = null;
        simpletikzParser.idd_return idd244 = default(simpletikzParser.idd_return);

        simpletikzParser.idd_return idd246 = default(simpletikzParser.idd_return);

        simpletikzParser.idd_return idd248 = default(simpletikzParser.idd_return);

        simpletikzParser.numberunit_return numberunit250 = default(simpletikzParser.numberunit_return);


        object char_literal245_tree=null;
        object char_literal247_tree=null;
        object char_literal249_tree=null;
        object char_literal251_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleTokenStream stream_46 = new RewriteRuleTokenStream(adaptor,"token 46");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:446:2: ( idd -> ^( IM_DONTCARE idd ) | '{' idd '}' -> ^( IM_DONTCARE '{' idd '}' ) | ( idd '=' numberunit ( ',' )? )+ -> ^( IM_DONTCARE ( idd '=' numberunit ( ',' )? )+ ) )
            int alt64 = 3;
            alt64 = dfa64.Predict(input);
            switch (alt64) 
            {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:446:4: idd
                    {
                    	PushFollow(FOLLOW_idd_in_coord_part2544);
                    	idd244 = idd();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_idd.Add(idd244.Tree);


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
                    	// 446:9: -> ^( IM_DONTCARE idd )
                    	{
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:446:12: ^( IM_DONTCARE idd )
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
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:447:4: '{' idd '}'
                    {
                    	char_literal245=(IToken)Match(input,42,FOLLOW_42_in_coord_part2559); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_42.Add(char_literal245);

                    	PushFollow(FOLLOW_idd_in_coord_part2561);
                    	idd246 = idd();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_idd.Add(idd246.Tree);
                    	char_literal247=(IToken)Match(input,43,FOLLOW_43_in_coord_part2563); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_43.Add(char_literal247);



                    	// AST REWRITE
                    	// elements:          43, idd, 42
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 447:16: -> ^( IM_DONTCARE '{' idd '}' )
                    	{
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:447:19: ^( IM_DONTCARE '{' idd '}' )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DONTCARE, "IM_DONTCARE"), root_1);

                    	    adaptor.AddChild(root_1, stream_42.NextNode());
                    	    adaptor.AddChild(root_1, stream_idd.NextTree());
                    	    adaptor.AddChild(root_1, stream_43.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:448:4: ( idd '=' numberunit ( ',' )? )+
                    {
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:448:4: ( idd '=' numberunit ( ',' )? )+
                    	int cnt63 = 0;
                    	do 
                    	{
                    	    int alt63 = 2;
                    	    int LA63_0 = input.LA(1);

                    	    if ( (LA63_0 == 72) )
                    	    {
                    	        int LA63_2 = input.LA(2);

                    	        if ( ((LA63_2 >= IM_PATH && LA63_2 <= COMMAND) || (LA63_2 >= WS && LA63_2 <= 41) || (LA63_2 >= 44 && LA63_2 <= 45) || LA63_2 == 50 || (LA63_2 >= 56 && LA63_2 <= 88)) )
                    	        {
                    	            alt63 = 1;
                    	        }
                    	        else if ( ((LA63_2 >= FLOAT_WO_EXP && LA63_2 <= INT)) )
                    	        {
                    	            int LA63_4 = input.LA(3);

                    	            if ( ((LA63_4 >= IM_PATH && LA63_4 <= 41) || (LA63_4 >= 44 && LA63_4 <= 45) || LA63_4 == 50 || (LA63_4 >= 62 && LA63_4 <= 88)) )
                    	            {
                    	                alt63 = 1;
                    	            }
                    	            else if ( ((LA63_4 >= 56 && LA63_4 <= 61)) )
                    	            {
                    	                int LA63_5 = input.LA(4);

                    	                if ( ((LA63_5 >= IM_PATH && LA63_5 <= 41) || (LA63_5 >= 44 && LA63_5 <= 45) || LA63_5 == 50 || (LA63_5 >= 56 && LA63_5 <= 88)) )
                    	                {
                    	                    alt63 = 1;
                    	                }


                    	            }


                    	        }


                    	    }
                    	    else if ( ((LA63_0 >= IM_PATH && LA63_0 <= 41) || LA63_0 == 45 || LA63_0 == 50 || (LA63_0 >= 56 && LA63_0 <= 71) || (LA63_0 >= 73 && LA63_0 <= 88)) )
                    	    {
                    	        alt63 = 1;
                    	    }


                    	    switch (alt63) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:448:5: idd '=' numberunit ( ',' )?
                    			    {
                    			    	PushFollow(FOLLOW_idd_in_coord_part2581);
                    			    	idd248 = idd();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_idd.Add(idd248.Tree);
                    			    	char_literal249=(IToken)Match(input,44,FOLLOW_44_in_coord_part2583); if (state.failed) return retval; 
                    			    	if ( (state.backtracking==0) ) stream_44.Add(char_literal249);

                    			    	PushFollow(FOLLOW_numberunit_in_coord_part2585);
                    			    	numberunit250 = numberunit();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit250.Tree);
                    			    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:448:24: ( ',' )?
                    			    	int alt62 = 2;
                    			    	int LA62_0 = input.LA(1);

                    			    	if ( (LA62_0 == 46) )
                    			    	{
                    			    	    alt62 = 1;
                    			    	}
                    			    	switch (alt62) 
                    			    	{
                    			    	    case 1 :
                    			    	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:448:24: ','
                    			    	        {
                    			    	        	char_literal251=(IToken)Match(input,46,FOLLOW_46_in_coord_part2587); if (state.failed) return retval; 
                    			    	        	if ( (state.backtracking==0) ) stream_46.Add(char_literal251);


                    			    	        }
                    			    	        break;

                    			    	}


                    			    }
                    			    break;

                    			default:
                    			    if ( cnt63 >= 1 ) goto loop63;
                    			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    		            EarlyExitException eee63 =
                    		                new EarlyExitException(63, input);
                    		            throw eee63;
                    	    }
                    	    cnt63++;
                    	} while (true);

                    	loop63:
                    		;	// Stops C# compiler whining that label 'loop63' has no statements



                    	// AST REWRITE
                    	// elements:          numberunit, 44, idd, 46
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 448:31: -> ^( IM_DONTCARE ( idd '=' numberunit ( ',' )? )+ )
                    	{
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:448:34: ^( IM_DONTCARE ( idd '=' numberunit ( ',' )? )+ )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DONTCARE, "IM_DONTCARE"), root_1);

                    	    if ( !(stream_numberunit.HasNext() || stream_44.HasNext() || stream_idd.HasNext()) ) {
                    	        throw new RewriteEarlyExitException();
                    	    }
                    	    while ( stream_numberunit.HasNext() || stream_44.HasNext() || stream_idd.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_idd.NextTree());
                    	        adaptor.AddChild(root_1, stream_44.NextNode());
                    	        adaptor.AddChild(root_1, stream_numberunit.NextTree());
                    	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:448:69: ( ',' )?
                    	        if ( stream_46.HasNext() )
                    	        {
                    	            adaptor.AddChild(root_1, stream_46.NextNode());

                    	        }
                    	        stream_46.Reset();

                    	    }
                    	    stream_numberunit.Reset();
                    	    stream_44.Reset();
                    	    stream_idd.Reset();

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:450:1: coord_sep : ( ',' | ':' ) ;
    public simpletikzParser.coord_sep_return coord_sep() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_sep_return retval = new simpletikzParser.coord_sep_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set252 = null;

        object set252_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:451:2: ( ( ',' | ':' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:451:4: ( ',' | ':' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set252 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 46 && input.LA(1) <= 47) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set252));
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:455:1: edgeop : ( '--' | '->' | '|-' | '-|' | ID );
    public simpletikzParser.edgeop_return edgeop() // throws RecognitionException [1]
    {   
        simpletikzParser.edgeop_return retval = new simpletikzParser.edgeop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set253 = null;

        object set253_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:456:2: ( '--' | '->' | '|-' | '-|' | ID )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set253 = (IToken)input.LT(1);
            	if ( input.LA(1) == ID || (input.LA(1) >= 79 && input.LA(1) <= 82) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set253));
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:460:1: coord_modifier : ( '+' | '++' );
    public simpletikzParser.coord_modifier_return coord_modifier() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_modifier_return retval = new simpletikzParser.coord_modifier_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set254 = null;

        object set254_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:461:2: ( '+' | '++' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set254 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 83 && input.LA(1) <= 84) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set254));
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:503:1: squarebr_start : '[' -> ^( IM_STARTTAG '[' ) ;
    public simpletikzParser.squarebr_start_return squarebr_start() // throws RecognitionException [1]
    {   
        simpletikzParser.squarebr_start_return retval = new simpletikzParser.squarebr_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal255 = null;

        object char_literal255_tree=null;
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:504:2: ( '[' -> ^( IM_STARTTAG '[' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:504:4: '['
            {
            	char_literal255=(IToken)Match(input,53,FOLLOW_53_in_squarebr_start2693); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_53.Add(char_literal255);



            	// AST REWRITE
            	// elements:          53
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 504:8: -> ^( IM_STARTTAG '[' )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:504:11: ^( IM_STARTTAG '[' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_53.NextNode());

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:506:1: squarebr_end : ']' -> ^( IM_ENDTAG ']' ) ;
    public simpletikzParser.squarebr_end_return squarebr_end() // throws RecognitionException [1]
    {   
        simpletikzParser.squarebr_end_return retval = new simpletikzParser.squarebr_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal256 = null;

        object char_literal256_tree=null;
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:507:2: ( ']' -> ^( IM_ENDTAG ']' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:507:4: ']'
            {
            	char_literal256=(IToken)Match(input,54,FOLLOW_54_in_squarebr_end2711); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_54.Add(char_literal256);



            	// AST REWRITE
            	// elements:          54
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 507:8: -> ^( IM_ENDTAG ']' )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:507:11: ^( IM_ENDTAG ']' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_54.NextNode());

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:509:1: semicolon_end : ';' -> ^( IM_ENDTAG ';' ) ;
    public simpletikzParser.semicolon_end_return semicolon_end() // throws RecognitionException [1]
    {   
        simpletikzParser.semicolon_end_return retval = new simpletikzParser.semicolon_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal257 = null;

        object char_literal257_tree=null;
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:510:2: ( ';' -> ^( IM_ENDTAG ';' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:510:4: ';'
            {
            	char_literal257=(IToken)Match(input,55,FOLLOW_55_in_semicolon_end2730); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_55.Add(char_literal257);



            	// AST REWRITE
            	// elements:          55
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 510:8: -> ^( IM_ENDTAG ';' )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:510:11: ^( IM_ENDTAG ';' )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:512:1: roundbr_start : '{' -> ^( IM_STARTTAG '{' ) ;
    public simpletikzParser.roundbr_start_return roundbr_start() // throws RecognitionException [1]
    {   
        simpletikzParser.roundbr_start_return retval = new simpletikzParser.roundbr_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal258 = null;

        object char_literal258_tree=null;
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:513:2: ( '{' -> ^( IM_STARTTAG '{' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:513:4: '{'
            {
            	char_literal258=(IToken)Match(input,42,FOLLOW_42_in_roundbr_start2748); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_42.Add(char_literal258);



            	// AST REWRITE
            	// elements:          42
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 513:8: -> ^( IM_STARTTAG '{' )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:513:11: ^( IM_STARTTAG '{' )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:515:1: roundbr_end : '}' -> ^( IM_ENDTAG '}' ) ;
    public simpletikzParser.roundbr_end_return roundbr_end() // throws RecognitionException [1]
    {   
        simpletikzParser.roundbr_end_return retval = new simpletikzParser.roundbr_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal259 = null;

        object char_literal259_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:516:2: ( '}' -> ^( IM_ENDTAG '}' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:516:4: '}'
            {
            	char_literal259=(IToken)Match(input,43,FOLLOW_43_in_roundbr_end2766); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_43.Add(char_literal259);



            	// AST REWRITE
            	// elements:          43
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 516:8: -> ^( IM_ENDTAG '}' )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:516:11: ^( IM_ENDTAG '}' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_43.NextNode());

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:518:1: controls_start : '..' 'controls' -> ^( IM_STARTTAG '..' ) ;
    public simpletikzParser.controls_start_return controls_start() // throws RecognitionException [1]
    {   
        simpletikzParser.controls_start_return retval = new simpletikzParser.controls_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal260 = null;
        IToken string_literal261 = null;

        object string_literal260_tree=null;
        object string_literal261_tree=null;
        RewriteRuleTokenStream stream_86 = new RewriteRuleTokenStream(adaptor,"token 86");
        RewriteRuleTokenStream stream_85 = new RewriteRuleTokenStream(adaptor,"token 85");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:519:2: ( '..' 'controls' -> ^( IM_STARTTAG '..' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:519:4: '..' 'controls'
            {
            	string_literal260=(IToken)Match(input,85,FOLLOW_85_in_controls_start2784); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_85.Add(string_literal260);

            	string_literal261=(IToken)Match(input,86,FOLLOW_86_in_controls_start2786); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_86.Add(string_literal261);



            	// AST REWRITE
            	// elements:          85
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 519:20: -> ^( IM_STARTTAG '..' )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:519:23: ^( IM_STARTTAG '..' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_85.NextNode());

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:521:1: controls_end : '..' -> ^( IM_ENDTAG '..' ) ;
    public simpletikzParser.controls_end_return controls_end() // throws RecognitionException [1]
    {   
        simpletikzParser.controls_end_return retval = new simpletikzParser.controls_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal262 = null;

        object string_literal262_tree=null;
        RewriteRuleTokenStream stream_85 = new RewriteRuleTokenStream(adaptor,"token 85");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:522:2: ( '..' -> ^( IM_ENDTAG '..' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:522:4: '..'
            {
            	string_literal262=(IToken)Match(input,85,FOLLOW_85_in_controls_end2804); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_85.Add(string_literal262);



            	// AST REWRITE
            	// elements:          85
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 522:9: -> ^( IM_ENDTAG '..' )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:522:12: ^( IM_ENDTAG '..' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_85.NextNode());

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:524:1: tikz_set_start : '\\\\tikzset' '{' -> ^( IM_STARTTAG ) ;
    public simpletikzParser.tikz_set_start_return tikz_set_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_set_start_return retval = new simpletikzParser.tikz_set_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal263 = null;
        IToken char_literal264 = null;

        object string_literal263_tree=null;
        object char_literal264_tree=null;
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:525:2: ( '\\\\tikzset' '{' -> ^( IM_STARTTAG ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:525:4: '\\\\tikzset' '{'
            {
            	string_literal263=(IToken)Match(input,41,FOLLOW_41_in_tikz_set_start2822); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(string_literal263);

            	char_literal264=(IToken)Match(input,42,FOLLOW_42_in_tikz_set_start2824); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_42.Add(char_literal264);



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
            	// 525:21: -> ^( IM_STARTTAG )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:525:24: ^( IM_STARTTAG )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:527:1: tikzpicture_start : '\\\\begin' '{' 'tikzpicture' '}' -> ^( IM_STARTTAG '\\\\begin' ) ;
    public simpletikzParser.tikzpicture_start_return tikzpicture_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_start_return retval = new simpletikzParser.tikzpicture_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal265 = null;
        IToken char_literal266 = null;
        IToken string_literal267 = null;
        IToken char_literal268 = null;

        object string_literal265_tree=null;
        object char_literal266_tree=null;
        object string_literal267_tree=null;
        object char_literal268_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");
        RewriteRuleTokenStream stream_87 = new RewriteRuleTokenStream(adaptor,"token 87");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:528:2: ( '\\\\begin' '{' 'tikzpicture' '}' -> ^( IM_STARTTAG '\\\\begin' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:528:4: '\\\\begin' '{' 'tikzpicture' '}'
            {
            	string_literal265=(IToken)Match(input,39,FOLLOW_39_in_tikzpicture_start2843); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_39.Add(string_literal265);

            	char_literal266=(IToken)Match(input,42,FOLLOW_42_in_tikzpicture_start2845); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_42.Add(char_literal266);

            	string_literal267=(IToken)Match(input,87,FOLLOW_87_in_tikzpicture_start2847); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_87.Add(string_literal267);

            	char_literal268=(IToken)Match(input,43,FOLLOW_43_in_tikzpicture_start2849); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_43.Add(char_literal268);



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
            	// 528:36: -> ^( IM_STARTTAG '\\\\begin' )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:528:39: ^( IM_STARTTAG '\\\\begin' )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:530:1: tikzpicture_end : '\\\\end' '{' 'tikzpicture' '}' -> ^( IM_ENDTAG '\\\\end' ) ;
    public simpletikzParser.tikzpicture_end_return tikzpicture_end() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_end_return retval = new simpletikzParser.tikzpicture_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal269 = null;
        IToken char_literal270 = null;
        IToken string_literal271 = null;
        IToken char_literal272 = null;

        object string_literal269_tree=null;
        object char_literal270_tree=null;
        object string_literal271_tree=null;
        object char_literal272_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleTokenStream stream_62 = new RewriteRuleTokenStream(adaptor,"token 62");
        RewriteRuleTokenStream stream_87 = new RewriteRuleTokenStream(adaptor,"token 87");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:531:2: ( '\\\\end' '{' 'tikzpicture' '}' -> ^( IM_ENDTAG '\\\\end' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:531:4: '\\\\end' '{' 'tikzpicture' '}'
            {
            	string_literal269=(IToken)Match(input,62,FOLLOW_62_in_tikzpicture_end2867); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_62.Add(string_literal269);

            	char_literal270=(IToken)Match(input,42,FOLLOW_42_in_tikzpicture_end2869); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_42.Add(char_literal270);

            	string_literal271=(IToken)Match(input,87,FOLLOW_87_in_tikzpicture_end2871); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_87.Add(string_literal271);

            	char_literal272=(IToken)Match(input,43,FOLLOW_43_in_tikzpicture_end2873); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_43.Add(char_literal272);



            	// AST REWRITE
            	// elements:          62
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 531:34: -> ^( IM_ENDTAG '\\\\end' )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:531:37: ^( IM_ENDTAG '\\\\end' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_62.NextNode());

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:533:1: tikzscope_start : '\\\\begin' '{' 'scope' '}' -> ^( IM_STARTTAG '\\\\begin' ) ;
    public simpletikzParser.tikzscope_start_return tikzscope_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_start_return retval = new simpletikzParser.tikzscope_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal273 = null;
        IToken char_literal274 = null;
        IToken string_literal275 = null;
        IToken char_literal276 = null;

        object string_literal273_tree=null;
        object char_literal274_tree=null;
        object string_literal275_tree=null;
        object char_literal276_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");
        RewriteRuleTokenStream stream_88 = new RewriteRuleTokenStream(adaptor,"token 88");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:534:2: ( '\\\\begin' '{' 'scope' '}' -> ^( IM_STARTTAG '\\\\begin' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:534:4: '\\\\begin' '{' 'scope' '}'
            {
            	string_literal273=(IToken)Match(input,39,FOLLOW_39_in_tikzscope_start2891); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_39.Add(string_literal273);

            	char_literal274=(IToken)Match(input,42,FOLLOW_42_in_tikzscope_start2893); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_42.Add(char_literal274);

            	string_literal275=(IToken)Match(input,88,FOLLOW_88_in_tikzscope_start2895); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_88.Add(string_literal275);

            	char_literal276=(IToken)Match(input,43,FOLLOW_43_in_tikzscope_start2897); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_43.Add(char_literal276);



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
            	// 534:30: -> ^( IM_STARTTAG '\\\\begin' )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:534:33: ^( IM_STARTTAG '\\\\begin' )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:536:1: tikzscope_end : '\\\\end' '{' 'scope' '}' -> ^( IM_ENDTAG '\\\\end' ) ;
    public simpletikzParser.tikzscope_end_return tikzscope_end() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_end_return retval = new simpletikzParser.tikzscope_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal277 = null;
        IToken char_literal278 = null;
        IToken string_literal279 = null;
        IToken char_literal280 = null;

        object string_literal277_tree=null;
        object char_literal278_tree=null;
        object string_literal279_tree=null;
        object char_literal280_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleTokenStream stream_62 = new RewriteRuleTokenStream(adaptor,"token 62");
        RewriteRuleTokenStream stream_88 = new RewriteRuleTokenStream(adaptor,"token 88");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:537:2: ( '\\\\end' '{' 'scope' '}' -> ^( IM_ENDTAG '\\\\end' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:537:4: '\\\\end' '{' 'scope' '}'
            {
            	string_literal277=(IToken)Match(input,62,FOLLOW_62_in_tikzscope_end2915); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_62.Add(string_literal277);

            	char_literal278=(IToken)Match(input,42,FOLLOW_42_in_tikzscope_end2917); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_42.Add(char_literal278);

            	string_literal279=(IToken)Match(input,88,FOLLOW_88_in_tikzscope_end2919); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_88.Add(string_literal279);

            	char_literal280=(IToken)Match(input,43,FOLLOW_43_in_tikzscope_end2921); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_43.Add(char_literal280);



            	// AST REWRITE
            	// elements:          62
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 537:28: -> ^( IM_ENDTAG '\\\\end' )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:537:31: ^( IM_ENDTAG '\\\\end' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_62.NextNode());

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:539:1: path_start : path_start_tag -> ^( IM_STARTTAG path_start_tag ) ;
    public simpletikzParser.path_start_return path_start() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_return retval = new simpletikzParser.path_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.path_start_tag_return path_start_tag281 = default(simpletikzParser.path_start_tag_return);


        RewriteRuleSubtreeStream stream_path_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule path_start_tag");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:540:2: ( path_start_tag -> ^( IM_STARTTAG path_start_tag ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:540:4: path_start_tag
            {
            	PushFollow(FOLLOW_path_start_tag_in_path_start2940);
            	path_start_tag281 = path_start_tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_path_start_tag.Add(path_start_tag281.Tree);


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
            	// 540:19: -> ^( IM_STARTTAG path_start_tag )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:540:22: ^( IM_STARTTAG path_start_tag )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:542:1: node_start : node_start_tag -> ^( IM_STARTTAG node_start_tag ) ;
    public simpletikzParser.node_start_return node_start() // throws RecognitionException [1]
    {   
        simpletikzParser.node_start_return retval = new simpletikzParser.node_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.node_start_tag_return node_start_tag282 = default(simpletikzParser.node_start_tag_return);


        RewriteRuleSubtreeStream stream_node_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule node_start_tag");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:543:2: ( node_start_tag -> ^( IM_STARTTAG node_start_tag ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:543:4: node_start_tag
            {
            	PushFollow(FOLLOW_node_start_tag_in_node_start2958);
            	node_start_tag282 = node_start_tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_node_start_tag.Add(node_start_tag282.Tree);


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
            	// 543:19: -> ^( IM_STARTTAG node_start_tag )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:543:22: ^( IM_STARTTAG node_start_tag )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:545:1: matrix_start : matrix_start_tag -> ^( IM_STARTTAG matrix_start_tag ) ;
    public simpletikzParser.matrix_start_return matrix_start() // throws RecognitionException [1]
    {   
        simpletikzParser.matrix_start_return retval = new simpletikzParser.matrix_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.matrix_start_tag_return matrix_start_tag283 = default(simpletikzParser.matrix_start_tag_return);


        RewriteRuleSubtreeStream stream_matrix_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule matrix_start_tag");
        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:546:2: ( matrix_start_tag -> ^( IM_STARTTAG matrix_start_tag ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:546:4: matrix_start_tag
            {
            	PushFollow(FOLLOW_matrix_start_tag_in_matrix_start2976);
            	matrix_start_tag283 = matrix_start_tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_matrix_start_tag.Add(matrix_start_tag283.Tree);


            	// AST REWRITE
            	// elements:          matrix_start_tag
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 546:21: -> ^( IM_STARTTAG matrix_start_tag )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:546:24: ^( IM_STARTTAG matrix_start_tag )
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:548:1: node_start_tag : '\\\\node' ;
    public simpletikzParser.node_start_tag_return node_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.node_start_tag_return retval = new simpletikzParser.node_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal284 = null;

        object string_literal284_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:549:2: ( '\\\\node' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:549:4: '\\\\node'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal284=(IToken)Match(input,63,FOLLOW_63_in_node_start_tag2994); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal284_tree = (object)adaptor.Create(string_literal284);
            		adaptor.AddChild(root_0, string_literal284_tree);
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:551:1: matrix_start_tag : '\\\\matrix' ;
    public simpletikzParser.matrix_start_tag_return matrix_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.matrix_start_tag_return retval = new simpletikzParser.matrix_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal285 = null;

        object string_literal285_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:552:2: ( '\\\\matrix' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:552:4: '\\\\matrix'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal285=(IToken)Match(input,64,FOLLOW_64_in_matrix_start_tag3004); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal285_tree = (object)adaptor.Create(string_literal285);
            		adaptor.AddChild(root_0, string_literal285_tree);
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:554:1: coordinate_start : '\\\\coordinate' -> ^( IM_STARTTAG '\\\\coordinate' ) ;
    public simpletikzParser.coordinate_start_return coordinate_start() // throws RecognitionException [1]
    {   
        simpletikzParser.coordinate_start_return retval = new simpletikzParser.coordinate_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal286 = null;

        object string_literal286_tree=null;
        RewriteRuleTokenStream stream_65 = new RewriteRuleTokenStream(adaptor,"token 65");

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:555:2: ( '\\\\coordinate' -> ^( IM_STARTTAG '\\\\coordinate' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:555:4: '\\\\coordinate'
            {
            	string_literal286=(IToken)Match(input,65,FOLLOW_65_in_coordinate_start3014); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_65.Add(string_literal286);



            	// AST REWRITE
            	// elements:          65
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 555:19: -> ^( IM_STARTTAG '\\\\coordinate' )
            	{
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:555:22: ^( IM_STARTTAG '\\\\coordinate' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_65.NextNode());

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:557:1: path_start_tag : ( '\\\\draw' | '\\\\fill' | '\\\\path' | '\\\\clip' | '\\\\filldraw' );
    public simpletikzParser.path_start_tag_return path_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_tag_return retval = new simpletikzParser.path_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set287 = null;

        object set287_tree=null;

        try 
    	{
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:558:2: ( '\\\\draw' | '\\\\fill' | '\\\\path' | '\\\\clip' | '\\\\filldraw' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set287 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 66 && input.LA(1) <= 70) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set287));
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
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:320:5: ( coord )
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:320:6: coord
        {
        	PushFollow(FOLLOW_coord_in_synpred1_simpletikz1475);
        	coord();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred1_simpletikz"

    // $ANTLR start "synpred2_simpletikz"
    public void synpred2_simpletikz_fragment() {
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:345:8: ( tikzcoordinate_core3 )
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:345:9: tikzcoordinate_core3
        {
        	PushFollow(FOLLOW_tikzcoordinate_core3_in_synpred2_simpletikz1690);
        	tikzcoordinate_core3();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred2_simpletikz"

    // $ANTLR start "synpred3_simpletikz"
    public void synpred3_simpletikz_fragment() {
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:346:12: ( tikzcoordinate_core2 )
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:346:13: tikzcoordinate_core2
        {
        	PushFollow(FOLLOW_tikzcoordinate_core2_in_synpred3_simpletikz1709);
        	tikzcoordinate_core2();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred3_simpletikz"

    // $ANTLR start "synpred4_simpletikz"
    public void synpred4_simpletikz_fragment() {
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:347:12: ( tikzcoordinate_core1 )
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:347:13: tikzcoordinate_core1
        {
        	PushFollow(FOLLOW_tikzcoordinate_core1_in_synpred4_simpletikz1729);
        	tikzcoordinate_core1();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred4_simpletikz"

    // $ANTLR start "synpred5_simpletikz"
    public void synpred5_simpletikz_fragment() {
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:356:21: ( tikzcoordinate_core3 )
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:356:22: tikzcoordinate_core3
        {
        	PushFollow(FOLLOW_tikzcoordinate_core3_in_synpred5_simpletikz1814);
        	tikzcoordinate_core3();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred5_simpletikz"

    // $ANTLR start "synpred6_simpletikz"
    public void synpred6_simpletikz_fragment() {
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:357:12: ( tikzcoordinate_core2 )
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:357:13: tikzcoordinate_core2
        {
        	PushFollow(FOLLOW_tikzcoordinate_core2_in_synpred6_simpletikz1833);
        	tikzcoordinate_core2();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred6_simpletikz"

    // $ANTLR start "synpred7_simpletikz"
    public void synpred7_simpletikz_fragment() {
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:358:12: ( tikzcoordinate_core1 )
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:358:13: tikzcoordinate_core1
        {
        	PushFollow(FOLLOW_tikzcoordinate_core1_in_synpred7_simpletikz1853);
        	tikzcoordinate_core1();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred7_simpletikz"

    // $ANTLR start "synpred8_simpletikz"
    public void synpred8_simpletikz_fragment() {
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:406:28: ( size )
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\trunk\\TikzParser\\simpletikz.g:406:29: size
        {
        	PushFollow(FOLLOW_size_in_synpred8_simpletikz2145);
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
   	protected DFA15 dfa15;
   	protected DFA29 dfa29;
   	protected DFA30 dfa30;
   	protected DFA37 dfa37;
   	protected DFA41 dfa41;
   	protected DFA43 dfa43;
   	protected DFA50 dfa50;
   	protected DFA53 dfa53;
   	protected DFA58 dfa58;
   	protected DFA61 dfa61;
   	protected DFA64 dfa64;
	private void InitializeCyclicDFAs()
	{
    	this.dfa10 = new DFA10(this);
    	this.dfa15 = new DFA15(this);
    	this.dfa29 = new DFA29(this);
    	this.dfa30 = new DFA30(this);
    	this.dfa37 = new DFA37(this);
    	this.dfa41 = new DFA41(this);
    	this.dfa43 = new DFA43(this);
    	this.dfa50 = new DFA50(this);
    	this.dfa53 = new DFA53(this);
    	this.dfa58 = new DFA58(this);
    	this.dfa61 = new DFA61(this);
    	this.dfa64 = new DFA64(this);
	    this.dfa37.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA37_SpecialStateTransition);
	    this.dfa41.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA41_SpecialStateTransition);
	    this.dfa43.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA43_SpecialStateTransition);
	    this.dfa50.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA50_SpecialStateTransition);
	}

    const string DFA10_eotS =
        "\x04\uffff";
    const string DFA10_eofS =
        "\x04\uffff";
    const string DFA10_minS =
        "\x02\x04\x02\uffff";
    const string DFA10_maxS =
        "\x02\x58\x02\uffff";
    const string DFA10_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA10_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA10_transitionS = {
            "\x26\x01\x03\uffff\x01\x01\x04\uffff\x01\x01\x05\uffff\x21"+
            "\x01",
            "\x26\x01\x03\x03\x01\x01\x01\x03\x01\uffff\x02\x02\x01\x01"+
            "\x03\uffff\x01\x03\x01\uffff\x21\x01",
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

    const string DFA15_eotS =
        "\x38\uffff";
    const string DFA15_eofS =
        "\x38\uffff";
    const string DFA15_minS =
        "\x01\x04\x01\x2a\x01\x04\x02\uffff\x01\x2a\x01\uffff\x01\x04\x01"+
        "\uffff\x12\x04\x01\uffff\x1c\x04";
    const string DFA15_maxS =
        "\x01\x58\x01\x3d\x01\x58\x02\uffff\x01\x36\x01\uffff\x01\x58\x01"+
        "\uffff\x12\x58\x01\uffff\x1c\x58";
    const string DFA15_acceptS =
        "\x03\uffff\x01\x04\x01\x02\x01\uffff\x01\x01\x01\uffff\x01\x05"+
        "\x12\uffff\x01\x03\x1c\uffff";
    const string DFA15_specialS =
        "\x38\uffff}>";
    static readonly string[] DFA15_transitionS = {
            "\x1a\x03\x02\x01\x0a\x03\x01\x02\x02\uffff\x01\x03\x04\uffff"+
            "\x01\x03\x05\uffff\x21\x03",
            "\x02\x04\x02\uffff\x01\x04\x01\x06\x06\uffff\x01\x04\x01\uffff"+
            "\x06\x05",
            "\x2f\x08\x01\x07\x1f\x08\x02\x09\x04\x08",
            "",
            "",
            "\x02\x04\x02\uffff\x01\x04\x01\x06\x06\uffff\x01\x04",
            "",
            "\x1a\x0c\x02\x0b\x0a\x0c\x01\x0a\x02\x08\x01\x0c\x04\x08\x01"+
            "\x0c\x05\x08\x21\x0c",
            "",
            "\x2f\x08\x01\x0d\x25\x08",
            "\x26\x0e\x03\x08\x01\x0e\x04\x08\x01\x0e\x05\x08\x21\x0e",
            "\x26\x0c\x02\x08\x01\x0f\x01\x0c\x02\x11\x02\x08\x01\x0c\x01"+
            "\x08\x01\x12\x03\x08\x06\x10\x1b\x0c",
            "\x26\x0c\x02\x08\x01\x0f\x01\x0c\x02\x13\x02\x08\x01\x0c\x01"+
            "\x08\x01\x12\x03\x08\x21\x0c",
            "\x1a\x15\x02\x14\x0a\x15\x01\x0a\x02\x08\x01\x15\x04\x08\x01"+
            "\x15\x05\x08\x21\x15",
            "\x26\x0e\x01\x08\x01\x16\x01\x08\x01\x0e\x04\x08\x01\x0e\x05"+
            "\x08\x21\x0e",
            "\x1a\x08\x02\x17\x39\x08",
            "\x26\x0c\x02\x08\x01\x0f\x01\x0c\x02\x11\x02\x08\x01\x0c\x01"+
            "\x08\x01\x12\x03\x08\x21\x0c",
            "\x1a\x1a\x02\x19\x0a\x1a\x01\x18\x02\x08\x01\x1a\x04\x08\x01"+
            "\x1a\x05\x08\x21\x1a",
            "\x27\x08\x01\x1b\x2d\x08",
            "\x26\x1a\x01\x18\x02\x08\x01\x1a\x04\x08\x01\x1a\x05\x08\x21"+
            "\x1a",
            "\x26\x15\x02\x08\x01\x0f\x01\x15\x02\x11\x02\x08\x01\x15\x05"+
            "\x08\x06\x1c\x1b\x15",
            "\x26\x15\x02\x08\x01\x0f\x01\x15\x02\x13\x02\x08\x01\x15\x05"+
            "\x08\x21\x15",
            "\x2a\x08\x02\x1d\x29\x08",
            "\x26\x20\x03\x08\x01\x20\x01\x1f\x01\x13\x02\x08\x01\x20\x05"+
            "\x08\x06\x1e\x1b\x20",
            "\x26\x21\x03\x08\x01\x21\x04\x08\x01\x21\x05\x08\x21\x21",
            "\x26\x1a\x02\x08\x01\x22\x01\x1a\x04\x08\x01\x1a\x01\x08\x01"+
            "\x24\x03\x08\x06\x23\x1b\x1a",
            "\x26\x1a\x02\x08\x01\x22\x01\x1a\x04\x08\x01\x1a\x01\x08\x01"+
            "\x25\x03\x08\x21\x1a",
            "",
            "\x26\x15\x02\x08\x01\x0f\x01\x15\x02\x11\x02\x08\x01\x15\x05"+
            "\x08\x21\x15",
            "\x26\x26\x01\x18\x02\x08\x01\x26\x04\x08\x01\x26\x05\x08\x21"+
            "\x26",
            "\x26\x20\x02\x08\x01\x0f\x01\x20\x01\x1f\x01\x13\x02\x08\x01"+
            "\x20\x05\x08\x21\x20",
            "\x26\x27\x01\x18\x02\x08\x01\x27\x02\x13\x02\x08\x01\x27\x05"+
            "\x08\x21\x27",
            "\x26\x20\x02\x08\x01\x0f\x01\x20\x04\x08\x01\x20\x05\x08\x21"+
            "\x20",
            "\x26\x21\x01\x08\x01\x28\x01\x08\x01\x21\x04\x08\x01\x21\x05"+
            "\x08\x21\x21",
            "\x1a\x08\x02\x29\x39\x08",
            "\x26\x1a\x02\x08\x01\x22\x01\x1a\x04\x08\x01\x1a\x01\x08\x01"+
            "\x24\x03\x08\x21\x1a",
            "\x27\x08\x01\x1b\x2d\x08",
            "\x27\x08\x01\x1b\x2d\x08",
            "\x26\x26\x02\x08\x01\x2a\x01\x26\x04\x08\x01\x26\x01\x08\x01"+
            "\x2b\x03\x08\x21\x26",
            "\x26\x27\x02\x08\x01\x2c\x01\x27\x04\x08\x01\x27\x01\x08\x01"+
            "\x25\x03\x08\x21\x27",
            "\x30\x08\x01\x2b\x24\x08",
            "\x26\x2f\x03\x08\x01\x2f\x01\x2e\x03\x08\x01\x2f\x01\x08\x01"+
            "\x25\x03\x08\x06\x2d\x1b\x2f",
            "\x1a\x08\x02\x30\x39\x08",
            "\x27\x08\x01\x1b\x2d\x08",
            "\x1a\x08\x02\x31\x39\x08",
            "\x26\x2f\x02\x08\x01\x22\x01\x2f\x01\x2e\x03\x08\x01\x2f\x01"+
            "\x08\x01\x25\x03\x08\x21\x2f",
            "\x26\x2f\x03\x08\x01\x2f\x04\x08\x01\x2f\x01\x08\x01\x25\x03"+
            "\x08\x21\x2f",
            "\x26\x2f\x02\x08\x01\x22\x01\x2f\x04\x08\x01\x2f\x05\x08\x21"+
            "\x2f",
            "\x26\x34\x03\x08\x01\x34\x01\x33\x03\x08\x01\x34\x01\x08\x01"+
            "\x2b\x03\x08\x06\x32\x1b\x34",
            "\x26\x37\x03\x08\x01\x37\x01\x36\x01\x13\x02\x08\x01\x37\x01"+
            "\x08\x01\x25\x03\x08\x06\x35\x1b\x37",
            "\x26\x34\x02\x08\x01\x2a\x01\x34\x01\x33\x03\x08\x01\x34\x01"+
            "\x08\x01\x2b\x03\x08\x21\x34",
            "\x26\x34\x03\x08\x01\x34\x04\x08\x01\x34\x01\x08\x01\x2b\x03"+
            "\x08\x21\x34",
            "\x26\x34\x02\x08\x01\x2a\x01\x34\x04\x08\x01\x34\x05\x08\x21"+
            "\x34",
            "\x26\x37\x02\x08\x01\x2c\x01\x37\x01\x36\x01\x13\x02\x08\x01"+
            "\x37\x01\x08\x01\x25\x03\x08\x21\x37",
            "\x26\x27\x01\x18\x02\x08\x01\x27\x02\x13\x02\x08\x01\x27\x01"+
            "\x08\x01\x25\x03\x08\x21\x27",
            "\x26\x37\x02\x08\x01\x2c\x01\x37\x04\x08\x01\x37\x05\x08\x21"+
            "\x37"
    };

    static readonly short[] DFA15_eot = DFA.UnpackEncodedString(DFA15_eotS);
    static readonly short[] DFA15_eof = DFA.UnpackEncodedString(DFA15_eofS);
    static readonly char[] DFA15_min = DFA.UnpackEncodedStringToUnsignedChars(DFA15_minS);
    static readonly char[] DFA15_max = DFA.UnpackEncodedStringToUnsignedChars(DFA15_maxS);
    static readonly short[] DFA15_accept = DFA.UnpackEncodedString(DFA15_acceptS);
    static readonly short[] DFA15_special = DFA.UnpackEncodedString(DFA15_specialS);
    static readonly short[][] DFA15_transition = DFA.UnpackEncodedStringArray(DFA15_transitionS);

    protected class DFA15 : DFA
    {
        public DFA15(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 15;
            this.eot = DFA15_eot;
            this.eof = DFA15_eof;
            this.min = DFA15_min;
            this.max = DFA15_max;
            this.accept = DFA15_accept;
            this.special = DFA15_special;
            this.transition = DFA15_transition;

        }

        override public string Description
        {
            get { return "187:1: iddornumberunitorstringorrange : ( range | numberunit | bracedcoord | idd | tikzstring );"; }
        }

    }

    const string DFA29_eotS =
        "\x0d\uffff";
    const string DFA29_eofS =
        "\x0d\uffff";
    const string DFA29_minS =
        "\x01\x04\x01\x2a\x08\uffff\x01\x1c\x02\uffff";
    const string DFA29_maxS =
        "\x01\x58\x01\x2a\x08\uffff\x01\x58\x02\uffff";
    const string DFA29_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07\x01"+
        "\x09\x01\x0a\x01\uffff\x01\x01\x01\x08";
    const string DFA29_specialS =
        "\x0d\uffff}>";
    static readonly string[] DFA29_transitionS = {
            "\x23\x09\x01\x01\x01\x07\x01\x06\x0b\x09\x01\uffff\x08\x09"+
            "\x01\x08\x01\x03\x01\x04\x01\x05\x05\x02\x12\x09",
            "\x01\x0a",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0c\x3b\uffff\x01\x0b",
            "",
            ""
    };

    static readonly short[] DFA29_eot = DFA.UnpackEncodedString(DFA29_eotS);
    static readonly short[] DFA29_eof = DFA.UnpackEncodedString(DFA29_eofS);
    static readonly char[] DFA29_min = DFA.UnpackEncodedStringToUnsignedChars(DFA29_minS);
    static readonly char[] DFA29_max = DFA.UnpackEncodedStringToUnsignedChars(DFA29_maxS);
    static readonly short[] DFA29_accept = DFA.UnpackEncodedString(DFA29_acceptS);
    static readonly short[] DFA29_special = DFA.UnpackEncodedString(DFA29_specialS);
    static readonly short[][] DFA29_transition = DFA.UnpackEncodedStringArray(DFA29_transitionS);

    protected class DFA29 : DFA
    {
        public DFA29(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 29;
            this.eot = DFA29_eot;
            this.eof = DFA29_eof;
            this.min = DFA29_min;
            this.max = DFA29_max;
            this.accept = DFA29_accept;
            this.special = DFA29_special;
            this.transition = DFA29_transition;

        }

        override public string Description
        {
            get { return "247:4: ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr )"; }
        }

    }

    const string DFA30_eotS =
        "\x10\uffff";
    const string DFA30_eofS =
        "\x10\uffff";
    const string DFA30_minS =
        "\x01\x04\x02\x2a\x07\uffff\x02\x1c\x04\uffff";
    const string DFA30_maxS =
        "\x01\x58\x02\x2a\x07\uffff\x02\x58\x04\uffff";
    const string DFA30_acceptS =
        "\x03\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07\x01"+
        "\x0a\x02\uffff\x01\x0b\x01\x09\x01\x01\x01\x08";
    const string DFA30_specialS =
        "\x10\uffff}>";
    static readonly string[] DFA30_transitionS = {
            "\x23\x09\x01\x02\x01\x08\x01\x07\x14\x09\x01\x01\x01\x04\x01"+
            "\x05\x01\x06\x05\x03\x12\x09",
            "\x01\x0a",
            "\x01\x0b",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0d\x3a\uffff\x02\x0c",
            "\x01\x0f\x3b\uffff\x01\x0e",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA30_eot = DFA.UnpackEncodedString(DFA30_eotS);
    static readonly short[] DFA30_eof = DFA.UnpackEncodedString(DFA30_eofS);
    static readonly char[] DFA30_min = DFA.UnpackEncodedStringToUnsignedChars(DFA30_minS);
    static readonly char[] DFA30_max = DFA.UnpackEncodedStringToUnsignedChars(DFA30_maxS);
    static readonly short[] DFA30_accept = DFA.UnpackEncodedString(DFA30_acceptS);
    static readonly short[] DFA30_special = DFA.UnpackEncodedString(DFA30_specialS);
    static readonly short[][] DFA30_transition = DFA.UnpackEncodedStringArray(DFA30_transitionS);

    protected class DFA30 : DFA
    {
        public DFA30(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 30;
            this.eot = DFA30_eot;
            this.eof = DFA30_eof;
            this.min = DFA30_min;
            this.max = DFA30_max;
            this.accept = DFA30_accept;
            this.special = DFA30_special;
            this.transition = DFA30_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 248:3: ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*"; }
        }

    }

    const string DFA37_eotS =
        "\x0e\uffff";
    const string DFA37_eofS =
        "\x0e\uffff";
    const string DFA37_minS =
        "\x01\x1c\x03\uffff\x01\x00\x09\uffff";
    const string DFA37_maxS =
        "\x01\x55\x03\uffff\x01\x00\x09\uffff";
    const string DFA37_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\uffff\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x01\x08\x01\uffff\x01\x09\x01\x0b\x01\x0a";
    const string DFA37_specialS =
        "\x01\x00\x03\uffff\x01\x01\x09\uffff}>";
    static readonly string[] DFA37_transitionS = {
            "\x01\x0c\x01\x02\x0c\uffff\x01\x0b\x01\uffff\x01\x02\x06\uffff"+
            "\x01\x04\x01\uffff\x01\x01\x03\uffff\x01\x02\x0d\uffff\x01\x02"+
            "\x01\uffff\x01\x08\x01\x07\x01\uffff\x02\x09\x01\x03\x04\x0c"+
            "\x02\x05\x01\x06",
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
            get { return "314:1: tikzpath_element_single : ( tikz_options | let_cmd_parts -> ^( IM_TIKZEDT_CMD ( let_cmd_parts )+ ) | arc | ( coord )=> coord | controls | tikznode_int | tikzcoordinate_int | circle | roundbr_start ( tikzpath_element )* roundbr_end -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end ) | '(' ( tikzpath_element )* ')' -> ^( IM_PATH '(' ( tikzpath_element )* ')' ) | edgeop );"; }
        }

    }


    protected internal int DFA37_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA37_0 = input.LA(1);

                   	 
                   	int index37_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA37_0 == 53) ) { s = 1; }

                   	else if ( (LA37_0 == COMMAND || LA37_0 == 44 || LA37_0 == 57 || LA37_0 == 71) ) { s = 2; }

                   	else if ( (LA37_0 == 78) ) { s = 3; }

                   	else if ( (LA37_0 == 51) ) { s = 4; }

                   	else if ( ((LA37_0 >= 83 && LA37_0 <= 84)) && (synpred1_simpletikz()) ) { s = 5; }

                   	else if ( (LA37_0 == 85) ) { s = 6; }

                   	else if ( (LA37_0 == 74) ) { s = 7; }

                   	else if ( (LA37_0 == 73) ) { s = 8; }

                   	else if ( ((LA37_0 >= 76 && LA37_0 <= 77)) ) { s = 9; }

                   	else if ( (LA37_0 == 42) ) { s = 11; }

                   	else if ( (LA37_0 == ID || (LA37_0 >= 79 && LA37_0 <= 82)) ) { s = 12; }

                   	 
                   	input.Seek(index37_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA37_4 = input.LA(1);

                   	 
                   	int index37_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_simpletikz()) ) { s = 5; }

                   	else if ( (true) ) { s = 13; }

                   	 
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
    const string DFA41_eotS =
        "\x12\uffff";
    const string DFA41_eofS =
        "\x12\uffff";
    const string DFA41_minS =
        "\x01\x1c\x03\x00\x0e\uffff";
    const string DFA41_maxS =
        "\x01\x55\x03\x00\x0e\uffff";
    const string DFA41_acceptS =
        "\x04\uffff\x01\x04\x0a\uffff\x01\x01\x01\x02\x01\x03";
    const string DFA41_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x0e\uffff}>";
    static readonly string[] DFA41_transitionS = {
            "\x02\x04\x0c\uffff\x01\x04\x01\uffff\x01\x04\x06\uffff\x01"+
            "\x01\x01\uffff\x01\x03\x01\uffff\x01\x04\x01\uffff\x01\x04\x0d"+
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

    static readonly short[] DFA41_eot = DFA.UnpackEncodedString(DFA41_eotS);
    static readonly short[] DFA41_eof = DFA.UnpackEncodedString(DFA41_eofS);
    static readonly char[] DFA41_min = DFA.UnpackEncodedStringToUnsignedChars(DFA41_minS);
    static readonly char[] DFA41_max = DFA.UnpackEncodedStringToUnsignedChars(DFA41_maxS);
    static readonly short[] DFA41_accept = DFA.UnpackEncodedString(DFA41_acceptS);
    static readonly short[] DFA41_special = DFA.UnpackEncodedString(DFA41_specialS);
    static readonly short[][] DFA41_transition = DFA.UnpackEncodedStringArray(DFA41_transitionS);

    protected class DFA41 : DFA
    {
        public DFA41(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 41;
            this.eot = DFA41_eot;
            this.eof = DFA41_eof;
            this.min = DFA41_min;
            this.max = DFA41_max;
            this.accept = DFA41_accept;
            this.special = DFA41_special;
            this.transition = DFA41_transition;

        }

        override public string Description
        {
            get { return "345:5: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?"; }
        }

    }


    protected internal int DFA41_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA41_1 = input.LA(1);

                   	 
                   	int index41_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred2_simpletikz()) ) { s = 15; }

                   	else if ( (synpred3_simpletikz()) ) { s = 16; }

                   	else if ( (synpred4_simpletikz()) ) { s = 17; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index41_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA41_2 = input.LA(1);

                   	 
                   	int index41_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred2_simpletikz()) ) { s = 15; }

                   	else if ( (synpred3_simpletikz()) ) { s = 16; }

                   	else if ( (synpred4_simpletikz()) ) { s = 17; }

                   	 
                   	input.Seek(index41_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA41_3 = input.LA(1);

                   	 
                   	int index41_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred2_simpletikz()) ) { s = 15; }

                   	else if ( (synpred3_simpletikz()) ) { s = 16; }

                   	else if ( (synpred4_simpletikz()) ) { s = 17; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index41_3);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae41 =
            new NoViableAltException(dfa.Description, 41, _s, input);
        dfa.Error(nvae41);
        throw nvae41;
    }
    const string DFA43_eotS =
        "\x15\uffff";
    const string DFA43_eofS =
        "\x15\uffff";
    const string DFA43_minS =
        "\x01\x1c\x03\x00\x11\uffff";
    const string DFA43_maxS =
        "\x01\x55\x03\x00\x11\uffff";
    const string DFA43_acceptS =
        "\x04\uffff\x01\x04\x0d\uffff\x01\x01\x01\x02\x01\x03";
    const string DFA43_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x11\uffff}>";
    static readonly string[] DFA43_transitionS = {
            "\x02\x04\x0c\uffff\x03\x04\x01\uffff\x01\x04\x04\uffff\x01"+
            "\x01\x01\x04\x01\x03\x01\uffff\x01\x04\x01\uffff\x01\x04\x0d"+
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
            get { return "356:18: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?"; }
        }

    }


    protected internal int DFA43_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA43_1 = input.LA(1);

                   	 
                   	int index43_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred5_simpletikz()) ) { s = 18; }

                   	else if ( (synpred6_simpletikz()) ) { s = 19; }

                   	else if ( (synpred7_simpletikz()) ) { s = 20; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index43_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA43_2 = input.LA(1);

                   	 
                   	int index43_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred5_simpletikz()) ) { s = 18; }

                   	else if ( (synpred6_simpletikz()) ) { s = 19; }

                   	else if ( (synpred7_simpletikz()) ) { s = 20; }

                   	 
                   	input.Seek(index43_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA43_3 = input.LA(1);

                   	 
                   	int index43_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred5_simpletikz()) ) { s = 18; }

                   	else if ( (synpred6_simpletikz()) ) { s = 19; }

                   	else if ( (synpred7_simpletikz()) ) { s = 20; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index43_3);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae43 =
            new NoViableAltException(dfa.Description, 43, _s, input);
        dfa.Error(nvae43);
        throw nvae43;
    }
    const string DFA50_eotS =
        "\x0a\uffff";
    const string DFA50_eofS =
        "\x0a\uffff";
    const string DFA50_minS =
        "\x01\x1c\x01\x04\x01\uffff\x03\x04\x01\x00\x01\x04\x01\uffff\x01"+
        "\x04";
    const string DFA50_maxS =
        "\x01\x55\x01\x58\x01\uffff\x03\x58\x01\x00\x01\x58\x01\uffff\x01"+
        "\x58";
    const string DFA50_acceptS =
        "\x02\uffff\x01\x02\x05\uffff\x01\x01\x01\uffff";
    const string DFA50_specialS =
        "\x06\uffff\x01\x00\x03\uffff}>";
    static readonly string[] DFA50_transitionS = {
            "\x02\x02\x0c\uffff\x03\x02\x01\uffff\x01\x02\x04\uffff\x01"+
            "\x01\x02\x02\x01\uffff\x01\x02\x01\uffff\x01\x02\x0d\uffff\x01"+
            "\x02\x01\uffff\x02\x02\x01\uffff\x0a\x02",
            "\x1a\x02\x02\x03\x0b\x02\x01\uffff\x02\x02\x04\uffff\x04\x02"+
            "\x02\uffff\x21\x02",
            "",
            "\x26\x02\x02\uffff\x04\x02\x02\uffff\x01\x02\x01\uffff\x01"+
            "\x06\x03\uffff\x06\x04\x0a\x02\x01\x05\x10\x02",
            "\x26\x02\x02\uffff\x04\x02\x02\uffff\x01\x02\x01\uffff\x01"+
            "\x06\x03\uffff\x10\x02\x01\x05\x10\x02",
            "\x1a\x02\x02\x07\x0a\x02\x02\uffff\x04\x02\x02\uffff\x01\x02"+
            "\x01\uffff\x01\x02\x03\uffff\x21\x02",
            "\x01\uffff",
            "\x26\x02\x02\uffff\x04\x02\x02\uffff\x01\x02\x01\uffff\x01"+
            "\x06\x03\uffff\x06\x09\x1b\x02",
            "",
            "\x26\x02\x02\uffff\x04\x02\x02\uffff\x01\x02\x01\uffff\x01"+
            "\x06\x03\uffff\x21\x02"
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
            get { return "406:27: ( ( size )=> size )?"; }
        }

    }


    protected internal int DFA50_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA50_6 = input.LA(1);

                   	 
                   	int index50_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_simpletikz()) ) { s = 8; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index50_6);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae50 =
            new NoViableAltException(dfa.Description, 50, _s, input);
        dfa.Error(nvae50);
        throw nvae50;
    }
    const string DFA53_eotS =
        "\x14\uffff";
    const string DFA53_eofS =
        "\x14\uffff";
    const string DFA53_minS =
        "\x01\x4e\x01\x33\x01\uffff\x03\x04\x01\uffff\x0a\x04\x01\uffff"+
        "\x02\x04";
    const string DFA53_maxS =
        "\x01\x4e\x01\x35\x01\uffff\x03\x58\x01\uffff\x0a\x58\x01\uffff"+
        "\x02\x58";
    const string DFA53_acceptS =
        "\x02\uffff\x01\x03\x03\uffff\x01\x02\x0a\uffff\x01\x01\x02\uffff";
    const string DFA53_specialS =
        "\x14\uffff}>";
    static readonly string[] DFA53_transitionS = {
            "\x01\x01",
            "\x01\x03\x01\uffff\x01\x02",
            "",
            "\x19\x06\x01\x05\x02\x04\x0b\x06\x02\uffff\x01\x06\x04\uffff"+
            "\x01\x06\x05\uffff\x21\x06",
            "\x26\x06\x02\uffff\x02\x06\x01\uffff\x01\x08\x02\uffff\x01"+
            "\x06\x05\uffff\x06\x07\x1b\x06",
            "\x26\x06\x02\uffff\x02\x06\x01\uffff\x01\x08\x02\uffff\x01"+
            "\x06\x05\uffff\x21\x06",
            "",
            "\x26\x06\x02\uffff\x02\x06\x01\uffff\x01\x08\x02\uffff\x01"+
            "\x06\x05\uffff\x21\x06",
            "\x19\x06\x01\x0a\x02\x09\x0b\x06\x02\uffff\x01\x06\x04\uffff"+
            "\x01\x06\x05\uffff\x21\x06",
            "\x26\x06\x02\uffff\x02\x06\x01\uffff\x01\x0b\x02\uffff\x01"+
            "\x06\x05\uffff\x06\x0c\x1b\x06",
            "\x26\x06\x02\uffff\x02\x06\x01\uffff\x01\x0b\x02\uffff\x01"+
            "\x06\x05\uffff\x21\x06",
            "\x19\x06\x01\x0e\x02\x0d\x0b\x06\x02\uffff\x01\x06\x04\uffff"+
            "\x01\x06\x05\uffff\x21\x06",
            "\x26\x06\x02\uffff\x02\x06\x01\uffff\x01\x0b\x02\uffff\x01"+
            "\x06\x05\uffff\x21\x06",
            "\x26\x06\x02\uffff\x02\x06\x04\uffff\x01\x06\x01\uffff\x01"+
            "\x11\x03\uffff\x06\x0f\x0a\x06\x01\x10\x10\x06",
            "\x26\x06\x02\uffff\x02\x06\x04\uffff\x01\x06\x01\uffff\x01"+
            "\x11\x03\uffff\x10\x06\x01\x10\x10\x06",
            "\x26\x06\x02\uffff\x02\x06\x04\uffff\x01\x06\x01\uffff\x01"+
            "\x11\x03\uffff\x10\x06\x01\x10\x10\x06",
            "\x1a\x06\x02\x12\x0a\x06\x02\uffff\x02\x06\x04\uffff\x01\x06"+
            "\x01\uffff\x01\x06\x03\uffff\x21\x06",
            "",
            "\x26\x06\x02\uffff\x02\x06\x04\uffff\x01\x06\x01\uffff\x01"+
            "\x11\x03\uffff\x06\x13\x1b\x06",
            "\x26\x06\x02\uffff\x02\x06\x04\uffff\x01\x06\x01\uffff\x01"+
            "\x11\x03\uffff\x21\x06"
    };

    static readonly short[] DFA53_eot = DFA.UnpackEncodedString(DFA53_eotS);
    static readonly short[] DFA53_eof = DFA.UnpackEncodedString(DFA53_eofS);
    static readonly char[] DFA53_min = DFA.UnpackEncodedStringToUnsignedChars(DFA53_minS);
    static readonly char[] DFA53_max = DFA.UnpackEncodedStringToUnsignedChars(DFA53_maxS);
    static readonly short[] DFA53_accept = DFA.UnpackEncodedString(DFA53_acceptS);
    static readonly short[] DFA53_special = DFA.UnpackEncodedString(DFA53_specialS);
    static readonly short[][] DFA53_transition = DFA.UnpackEncodedStringArray(DFA53_transitionS);

    protected class DFA53 : DFA
    {
        public DFA53(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 53;
            this.eot = DFA53_eot;
            this.eof = DFA53_eof;
            this.min = DFA53_min;
            this.max = DFA53_max;
            this.accept = DFA53_accept;
            this.special = DFA53_special;
            this.transition = DFA53_transition;

        }

        override public string Description
        {
            get { return "408:1: arc : ( 'arc' ( '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')' ) -> ^( IM_ARC ( numberunitorvariable )+ ( numberunit )? ) | 'arc' ( '(' coord_part ':' coord_part ':' coord_part ( 'and' numberunit )? ')' ) -> ^( IM_ARC ( coord_part )+ ( numberunit )? ) | 'arc' tikz_options -> ^( IM_DONTCARE ) );"; }
        }

    }

    const string DFA58_eotS =
        "\x0f\uffff";
    const string DFA58_eofS =
        "\x0f\uffff";
    const string DFA58_minS =
        "\x01\x33\x01\x04\x01\x33\x02\x04\x02\uffff\x07\x04\x01\uffff";
    const string DFA58_maxS =
        "\x01\x54\x01\x58\x01\x33\x02\x58\x02\uffff\x07\x58\x01\uffff";
    const string DFA58_acceptS =
        "\x05\uffff\x01\x03\x01\x01\x07\uffff\x01\x02";
    const string DFA58_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA58_transitionS = {
            "\x01\x01\x1f\uffff\x02\x02",
            "\x1a\x04\x02\x03\x0a\x04\x01\x05\x02\uffff\x01\x04\x04\uffff"+
            "\x01\x04\x02\uffff\x01\x06\x02\uffff\x21\x04",
            "\x01\x07",
            "\x26\x04\x02\uffff\x01\x05\x01\x04\x02\x09\x02\uffff\x01\x04"+
            "\x01\uffff\x01\x06\x03\uffff\x06\x08\x1b\x04",
            "\x26\x04\x02\uffff\x01\x05\x01\x04\x02\x05\x02\uffff\x01\x04"+
            "\x01\uffff\x01\x06\x03\uffff\x21\x04",
            "",
            "",
            "\x1a\x05\x02\x0a\x0b\x05\x02\uffff\x01\x05\x04\uffff\x01\x05"+
            "\x05\uffff\x21\x05",
            "\x26\x04\x02\uffff\x01\x05\x01\x04\x02\x09\x02\uffff\x01\x04"+
            "\x01\uffff\x01\x06\x03\uffff\x21\x04",
            "\x1a\x05\x02\x0b\x0b\x05\x02\uffff\x01\x05\x04\uffff\x01\x05"+
            "\x05\uffff\x21\x05",
            "\x26\x05\x02\uffff\x02\x05\x02\x09\x02\uffff\x01\x05\x05\uffff"+
            "\x06\x0c\x1b\x05",
            "\x26\x05\x02\uffff\x02\x05\x04\uffff\x01\x05\x01\uffff\x01"+
            "\x0e\x03\uffff\x06\x0d\x1b\x05",
            "\x26\x05\x02\uffff\x02\x05\x02\x09\x02\uffff\x01\x05\x05\uffff"+
            "\x21\x05",
            "\x26\x05\x02\uffff\x02\x05\x04\uffff\x01\x05\x01\uffff\x01"+
            "\x0e\x03\uffff\x21\x05",
            ""
    };

    static readonly short[] DFA58_eot = DFA.UnpackEncodedString(DFA58_eotS);
    static readonly short[] DFA58_eof = DFA.UnpackEncodedString(DFA58_eofS);
    static readonly char[] DFA58_min = DFA.UnpackEncodedStringToUnsignedChars(DFA58_minS);
    static readonly char[] DFA58_max = DFA.UnpackEncodedStringToUnsignedChars(DFA58_maxS);
    static readonly short[] DFA58_accept = DFA.UnpackEncodedString(DFA58_acceptS);
    static readonly short[] DFA58_special = DFA.UnpackEncodedString(DFA58_specialS);
    static readonly short[][] DFA58_transition = DFA.UnpackEncodedStringArray(DFA58_transitionS);

    protected class DFA58 : DFA
    {
        public DFA58(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 58;
            this.eot = DFA58_eot;
            this.eof = DFA58_eof;
            this.min = DFA58_min;
            this.max = DFA58_max;
            this.accept = DFA58_accept;
            this.special = DFA58_special;
            this.transition = DFA58_transition;

        }

        override public string Description
        {
            get { return "428:1: coord : ( coord_nodename -> ^( IM_COORD coord_nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) );"; }
        }

    }

    const string DFA61_eotS =
        "\x0f\uffff";
    const string DFA61_eofS =
        "\x0f\uffff";
    const string DFA61_minS =
        "\x01\x33\x01\x04\x01\x33\x01\x04\x01\uffff\x02\x04\x01\uffff\x06"+
        "\x04\x01\uffff";
    const string DFA61_maxS =
        "\x01\x54\x01\x58\x01\x33\x01\x58\x01\uffff\x02\x58\x01\uffff\x06"+
        "\x58\x01\uffff";
    const string DFA61_acceptS =
        "\x04\uffff\x01\x03\x02\uffff\x01\x01\x06\uffff\x01\x02";
    const string DFA61_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA61_transitionS = {
            "\x01\x01\x1f\uffff\x02\x02",
            "\x1a\x05\x02\x03\x0a\x05\x01\x04\x02\uffff\x01\x05\x04\uffff"+
            "\x01\x05\x05\uffff\x21\x05",
            "\x01\x06",
            "\x26\x05\x02\uffff\x01\x04\x01\x05\x02\x09\x02\uffff\x01\x05"+
            "\x01\uffff\x01\x07\x03\uffff\x06\x08\x1b\x05",
            "",
            "\x26\x05\x02\uffff\x01\x04\x01\x05\x02\x04\x02\uffff\x01\x05"+
            "\x01\uffff\x01\x07\x03\uffff\x21\x05",
            "\x1a\x04\x02\x0a\x0b\x04\x02\uffff\x01\x04\x04\uffff\x01\x04"+
            "\x05\uffff\x21\x04",
            "",
            "\x26\x05\x02\uffff\x01\x04\x01\x05\x02\x09\x02\uffff\x01\x05"+
            "\x01\uffff\x01\x07\x03\uffff\x21\x05",
            "\x1a\x04\x02\x0b\x0b\x04\x02\uffff\x01\x04\x04\uffff\x01\x04"+
            "\x05\uffff\x21\x04",
            "\x26\x04\x02\uffff\x02\x04\x02\x09\x02\uffff\x01\x04\x05\uffff"+
            "\x06\x0c\x1b\x04",
            "\x26\x04\x02\uffff\x02\x04\x04\uffff\x01\x04\x01\uffff\x01"+
            "\x0e\x03\uffff\x06\x0d\x1b\x04",
            "\x26\x04\x02\uffff\x02\x04\x02\x09\x02\uffff\x01\x04\x05\uffff"+
            "\x21\x04",
            "\x26\x04\x02\uffff\x02\x04\x04\uffff\x01\x04\x01\uffff\x01"+
            "\x0e\x03\uffff\x21\x04",
            ""
    };

    static readonly short[] DFA61_eot = DFA.UnpackEncodedString(DFA61_eotS);
    static readonly short[] DFA61_eof = DFA.UnpackEncodedString(DFA61_eofS);
    static readonly char[] DFA61_min = DFA.UnpackEncodedStringToUnsignedChars(DFA61_minS);
    static readonly char[] DFA61_max = DFA.UnpackEncodedStringToUnsignedChars(DFA61_maxS);
    static readonly short[] DFA61_accept = DFA.UnpackEncodedString(DFA61_acceptS);
    static readonly short[] DFA61_special = DFA.UnpackEncodedString(DFA61_specialS);
    static readonly short[][] DFA61_transition = DFA.UnpackEncodedStringArray(DFA61_transitionS);

    protected class DFA61 : DFA
    {
        public DFA61(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 61;
            this.eot = DFA61_eot;
            this.eof = DFA61_eof;
            this.min = DFA61_min;
            this.max = DFA61_max;
            this.accept = DFA61_accept;
            this.special = DFA61_special;
            this.transition = DFA61_transition;

        }

        override public string Description
        {
            get { return "433:1: coord_nooption : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) );"; }
        }

    }

    const string DFA64_eotS =
        "\x08\uffff";
    const string DFA64_eofS =
        "\x08\uffff";
    const string DFA64_minS =
        "\x02\x04\x02\uffff\x01\x04\x01\uffff\x02\x04";
    const string DFA64_maxS =
        "\x02\x58\x02\uffff\x01\x58\x01\uffff\x02\x58";
    const string DFA64_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\uffff\x01\x01\x02\uffff";
    const string DFA64_specialS =
        "\x08\uffff}>";
    static readonly string[] DFA64_transitionS = {
            "\x26\x01\x01\x02\x02\uffff\x01\x01\x04\uffff\x01\x01\x05\uffff"+
            "\x21\x01",
            "\x26\x01\x02\uffff\x01\x03\x01\x01\x02\x05\x02\uffff\x01\x01"+
            "\x01\uffff\x01\x05\x03\uffff\x10\x01\x01\x04\x10\x01",
            "",
            "",
            "\x1a\x01\x02\x06\x0a\x01\x02\uffff\x01\x03\x01\x01\x02\x05"+
            "\x02\uffff\x01\x01\x01\uffff\x01\x05\x03\uffff\x10\x01\x01\x04"+
            "\x10\x01",
            "",
            "\x26\x01\x02\uffff\x01\x03\x01\x01\x02\x05\x02\uffff\x01\x01"+
            "\x01\uffff\x01\x05\x03\uffff\x06\x07\x0a\x01\x01\x04\x10\x01",
            "\x26\x01\x02\uffff\x01\x03\x01\x01\x02\x05\x02\uffff\x01\x01"+
            "\x01\uffff\x01\x05\x03\uffff\x10\x01\x01\x04\x10\x01"
    };

    static readonly short[] DFA64_eot = DFA.UnpackEncodedString(DFA64_eotS);
    static readonly short[] DFA64_eof = DFA.UnpackEncodedString(DFA64_eofS);
    static readonly char[] DFA64_min = DFA.UnpackEncodedStringToUnsignedChars(DFA64_minS);
    static readonly char[] DFA64_max = DFA.UnpackEncodedStringToUnsignedChars(DFA64_maxS);
    static readonly short[] DFA64_accept = DFA.UnpackEncodedString(DFA64_acceptS);
    static readonly short[] DFA64_special = DFA.UnpackEncodedString(DFA64_specialS);
    static readonly short[][] DFA64_transition = DFA.UnpackEncodedStringArray(DFA64_transitionS);

    protected class DFA64 : DFA
    {
        public DFA64(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 64;
            this.eot = DFA64_eot;
            this.eof = DFA64_eof;
            this.min = DFA64_min;
            this.max = DFA64_max;
            this.accept = DFA64_accept;
            this.special = DFA64_special;
            this.transition = DFA64_transition;

        }

        override public string Description
        {
            get { return "445:1: coord_part : ( idd -> ^( IM_DONTCARE idd ) | '{' idd '}' -> ^( IM_DONTCARE '{' idd '}' ) | ( idd '=' numberunit ( ',' )? )+ -> ^( IM_DONTCARE ( idd '=' numberunit ( ',' )? )+ ) );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_dontcare_preamble_in_tikzdocument257 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_styleorsetorcmd_in_tikzdocument261 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzdocument265 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpicture_in_tikzdocument270 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_dontcare_preamble_in_tikzdocument_wo_tikzpicture296 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_styleorsetorcmd_in_tikzdocument_wo_tikzpicture300 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzdocument_wo_tikzpicture304 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_EOF_in_tikzdocument_wo_tikzpicture309 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TIKZEDT_CMD_COMMENT_in_tikz_cmd_comment330 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikz_styleorsetorcmd352 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikz_styleorsetorcmd356 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_cmd_comment_in_tikz_styleorsetorcmd360 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_preamble371 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_otherbegin396 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_otherbegin398 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_idd2_in_otherbegin400 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_otherbegin402 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_tikz_style414 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_tikz_style416 = new BitSet(new ulong[]{0xFF0423FFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_idd_in_tikz_style418 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikz_style420 = new BitSet(new ulong[]{0x0000300000000000UL});
    public static readonly BitSet FOLLOW_44_in_tikz_style423 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_45_in_tikz_style427 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikz_style430 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_squarebr_start_in_tikz_options452 = new BitSet(new ulong[]{0xFF4427FFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_options455 = new BitSet(new ulong[]{0xFF4467FFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_46_in_tikz_options458 = new BitSet(new ulong[]{0xFF0423FFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_options460 = new BitSet(new ulong[]{0xFF4467FFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_46_in_tikz_options464 = new BitSet(new ulong[]{0xFF4427FFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikz_options469 = new BitSet(new ulong[]{0xFF4427FFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_squarebr_end_in_tikz_options472 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_option_style_in_option497 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_option_kv_in_option506 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_option_kv520 = new BitSet(new ulong[]{0x0000100000000002UL});
    public static readonly BitSet FOLLOW_44_in_option_kv523 = new BitSet(new ulong[]{0xFF0427FFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_iddornumberunitorstringorrange_in_option_kv525 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_42_in_tikzstring553 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_no_rlbrace_in_tikzstring555 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikzstring559 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_no_rlbrace_in_tikzstring561 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_43_in_tikzstring566 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_no_rlbrace589 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_range_in_iddornumberunitorstringorrange607 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_numberunit_in_iddornumberunitorstringorrange611 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_bracedcoord_in_iddornumberunitorstringorrange615 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_iddornumberunitorstringorrange619 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzstring_in_iddornumberunitorstringorrange623 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_42_in_bracedcoord636 = new BitSet(new ulong[]{0x0008000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_coord_nooption_in_bracedcoord640 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_bracedcoord642 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_numberunit_in_range653 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_47_in_range655 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_range657 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_option_style681 = new BitSet(new ulong[]{0x0003000000000000UL});
    public static readonly BitSet FOLLOW_48_in_option_style684 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_49_in_option_style689 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_option_style691 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_option_style695 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_option_style697 = new BitSet(new ulong[]{0xFF046BFFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_option_kv_in_option_style700 = new BitSet(new ulong[]{0x0000480000000000UL});
    public static readonly BitSet FOLLOW_46_in_option_style703 = new BitSet(new ulong[]{0xFF0423FFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_option_kv_in_option_style705 = new BitSet(new ulong[]{0x0000480000000000UL});
    public static readonly BitSet FOLLOW_46_in_option_style712 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_option_style715 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_heavenknowswhythisisnecessary_in_idd750 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_idd_heavenknowswhythisisnecessary770 = new BitSet(new ulong[]{0xFF0423FFFFFFFFF2UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_ID_in_idd2830 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_numberunit_in_numberunitorvariable849 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COMMAND_in_numberunitorvariable854 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_number_in_numberunit867 = new BitSet(new ulong[]{0x3F00000000000002UL});
    public static readonly BitSet FOLLOW_unit_in_numberunit869 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_number895 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unit0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_set_start_in_tikz_set950 = new BitSet(new ulong[]{0xFF042BFFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_set953 = new BitSet(new ulong[]{0xFF046BFFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_46_in_tikz_set956 = new BitSet(new ulong[]{0xFF0423FFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_set958 = new BitSet(new ulong[]{0xFF046BFFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_46_in_tikz_set962 = new BitSet(new ulong[]{0xFF042BFFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_roundbr_end_in_tikz_set967 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzpicture_start_in_tikzpicture995 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpicture997 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzpicture1000 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpicture_end_in_tikzpicture1003 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody1033 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody1037 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_ext_in_tikzbody1041 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzmatrix_ext_in_tikzbody1045 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzcoordinate_ext_in_tikzbody1049 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody1053 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody1057 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody1061 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody1066 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_dontcare_body_nobr_in_tikzbody1071 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody1082 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody1086 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_ext_in_tikzbody1090 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzmatrix_ext_in_tikzbody1094 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzcoordinate_ext_in_tikzbody1098 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody1102 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody1106 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody1110 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody1115 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_dontcare_body_in_tikzbody1120 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body_nobr1137 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body1203 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_62_in_otherend1266 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_otherend1268 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_idd2_in_otherend1270 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_otherend1272 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzscope_start_in_tikzscope1299 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzscope1301 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzscope1304 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzscope_end_in_tikzscope1307 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_in_tikzpath1363 = new BitSet(new ulong[]{0x02A8140030000000UL,0x00000000003FF680UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath1365 = new BitSet(new ulong[]{0x02A8140030000000UL,0x00000000003FF680UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzpath1368 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_let_cmd_parts0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzpath_element_single_in_tikzpath_element1424 = new BitSet(new ulong[]{0x0000400000000002UL});
    public static readonly BitSet FOLLOW_46_in_tikzpath_element1426 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpath_element_single1443 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_let_cmd_parts_in_tikzpath_element_single1450 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arc_in_tikzpath_element_single1468 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_in_tikzpath_element_single1478 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_controls_in_tikzpath_element_single1484 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_int_in_tikzpath_element_single1490 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_int_in_tikzpath_element_single1496 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_circle_in_tikzpath_element_single1502 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_roundbr_start_in_tikzpath_element_single1509 = new BitSet(new ulong[]{0xFF2C3FFFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath_element_single1511 = new BitSet(new ulong[]{0xFF2C3FFFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_roundbr_end_in_tikzpath_element_single1514 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_51_in_tikzpath_element_single1534 = new BitSet(new ulong[]{0x0238140030000000UL,0x00000000003FF680UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath_element_single1536 = new BitSet(new ulong[]{0x0238140030000000UL,0x00000000003FF680UL});
    public static readonly BitSet FOLLOW_52_in_tikzpath_element_single1539 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_edgeop_in_tikzpath_element_single1558 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_controls_start_in_controls1573 = new BitSet(new ulong[]{0x0008000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_coord_in_controls1575 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000200100UL});
    public static readonly BitSet FOLLOW_72_in_controls1578 = new BitSet(new ulong[]{0x0008000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_coord_in_controls1580 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000200100UL});
    public static readonly BitSet FOLLOW_controls_end_in_controls1584 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_node_start_in_tikznode_ext1610 = new BitSet(new ulong[]{0x0028040000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_tikznode_core_in_tikznode_ext1612 = new BitSet(new ulong[]{0x02A8140030000000UL,0x00000000003FF680UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikznode_ext1614 = new BitSet(new ulong[]{0x02A8140030000000UL,0x00000000003FF680UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikznode_ext1617 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrix_start_in_tikzmatrix_ext1644 = new BitSet(new ulong[]{0x0028040000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_tikznode_core_in_tikzmatrix_ext1646 = new BitSet(new ulong[]{0x02A8140030000000UL,0x00000000003FF680UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzmatrix_ext1648 = new BitSet(new ulong[]{0x02A8140030000000UL,0x00000000003FF680UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzmatrix_ext1651 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coordinate_start_in_tikzcoordinate_ext1679 = new BitSet(new ulong[]{0x02A8140030000000UL,0x00000000003FFE80UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_ext1694 = new BitSet(new ulong[]{0x02A8140030000000UL,0x00000000003FF680UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_ext1713 = new BitSet(new ulong[]{0x02A8140030000000UL,0x00000000003FF680UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_ext1733 = new BitSet(new ulong[]{0x02A8140030000000UL,0x00000000003FF680UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzcoordinate_ext1744 = new BitSet(new ulong[]{0x02A8140030000000UL,0x00000000003FF680UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzcoordinate_ext1747 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_73_in_tikzcoordinate_int1807 = new BitSet(new ulong[]{0x0028000000000002UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_int1818 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_int1837 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_int1857 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_74_in_tikznode_int1873 = new BitSet(new ulong[]{0x0028040000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_tikznode_core_in_tikznode_int1876 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikznode_core1886 = new BitSet(new ulong[]{0x0028040000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikznode_core1889 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core31914 = new BitSet(new ulong[]{0x0028000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core31916 = new BitSet(new ulong[]{0x0028000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core31918 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core21952 = new BitSet(new ulong[]{0x0028000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core21954 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core11987 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_tikznode_decorator2024 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_75_in_tikznode_decorator2031 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_COMMAND_in_tikznode_decorator2034 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_75_in_tikznode_decorator2040 = new BitSet(new ulong[]{0x0008000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_coord_in_tikznode_decorator2043 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_options_dontcare_in_tikznode_decorator2049 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_53_in_tikz_options_dontcare2059 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_no_rlbracket_in_tikz_options_dontcare2061 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_options_dontcare_in_tikz_options_dontcare2065 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_no_rlbracket_in_tikz_options_dontcare2067 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_54_in_tikz_options_dontcare2072 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_no_rlbracket2090 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_51_in_nodename2107 = new BitSet(new ulong[]{0xFF0423FFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_idd_in_nodename2109 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_nodename2111 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_76_in_circle2136 = new BitSet(new ulong[]{0x0008000000000002UL});
    public static readonly BitSet FOLLOW_77_in_circle2140 = new BitSet(new ulong[]{0x0008000000000002UL});
    public static readonly BitSet FOLLOW_size_in_circle2149 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_78_in_arc2164 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_arc2167 = new BitSet(new ulong[]{0x00000000E0000000UL});
    public static readonly BitSet FOLLOW_numberunitorvariable_in_arc2169 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_47_in_arc2171 = new BitSet(new ulong[]{0x00000000E0000000UL});
    public static readonly BitSet FOLLOW_numberunitorvariable_in_arc2173 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_47_in_arc2175 = new BitSet(new ulong[]{0x00000000E0000000UL});
    public static readonly BitSet FOLLOW_numberunitorvariable_in_arc2177 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_72_in_arc2180 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_arc2182 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_arc2186 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_78_in_arc2204 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_arc2207 = new BitSet(new ulong[]{0xFF0427FFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_arc2209 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_47_in_arc2211 = new BitSet(new ulong[]{0xFF0427FFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_arc2213 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_47_in_arc2215 = new BitSet(new ulong[]{0xFF0427FFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_arc2217 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_72_in_arc2220 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_arc2222 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_arc2226 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_78_in_arc2244 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_tikz_options_in_arc2246 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_51_in_size2271 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_size2273 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_72_in_size2276 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_size2278 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_size2282 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_51_in_coord_nodename2310 = new BitSet(new ulong[]{0xFF2423FFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_options_in_coord_nodename2312 = new BitSet(new ulong[]{0xFF0423FFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_idd_in_coord_nodename2315 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_coord_nodename2318 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_nodename_in_coord2342 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord2366 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_coord2369 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord2371 = new BitSet(new ulong[]{0x0000C00000000000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord2373 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord2375 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_coord2377 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord2401 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_coord2404 = new BitSet(new ulong[]{0xFF0427FFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_coord2406 = new BitSet(new ulong[]{0x0000C00000000000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord2408 = new BitSet(new ulong[]{0xFF0427FFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_coord2410 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_coord2412 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_coord_nooption2441 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord_nooption2465 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_coord_nooption2468 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord_nooption2470 = new BitSet(new ulong[]{0x0000C00000000000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord_nooption2472 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord_nooption2474 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_coord_nooption2476 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord_nooption2500 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_coord_nooption2503 = new BitSet(new ulong[]{0xFF0427FFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_coord_nooption2505 = new BitSet(new ulong[]{0x0000C00000000000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord_nooption2507 = new BitSet(new ulong[]{0xFF0427FFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_coord_nooption2509 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_coord_nooption2511 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_coord_part2544 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_42_in_coord_part2559 = new BitSet(new ulong[]{0xFF0423FFFFFFFFF0UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_idd_in_coord_part2561 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_coord_part2563 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_coord_part2581 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_coord_part2583 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord_part2585 = new BitSet(new ulong[]{0xFF0463FFFFFFFFF2UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_46_in_coord_part2587 = new BitSet(new ulong[]{0xFF0423FFFFFFFFF2UL,0x0000000001FFFFFFUL});
    public static readonly BitSet FOLLOW_set_in_coord_sep2619 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_edgeop0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_coord_modifier0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_53_in_squarebr_start2693 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_squarebr_end2711 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_semicolon_end2730 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_42_in_roundbr_start2748 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_roundbr_end2766 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_85_in_controls_start2784 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_86_in_controls_start2786 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_85_in_controls_end2804 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_41_in_tikz_set_start2822 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_tikz_set_start2824 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_tikzpicture_start2843 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_tikzpicture_start2845 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_87_in_tikzpicture_start2847 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikzpicture_start2849 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_62_in_tikzpicture_end2867 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_tikzpicture_end2869 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_87_in_tikzpicture_end2871 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikzpicture_end2873 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_tikzscope_start2891 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_tikzscope_start2893 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000001000000UL});
    public static readonly BitSet FOLLOW_88_in_tikzscope_start2895 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikzscope_start2897 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_62_in_tikzscope_end2915 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_tikzscope_end2917 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000001000000UL});
    public static readonly BitSet FOLLOW_88_in_tikzscope_end2919 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikzscope_end2921 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_tag_in_path_start2940 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_node_start_tag_in_node_start2958 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrix_start_tag_in_matrix_start2976 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_63_in_node_start_tag2994 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_64_in_matrix_start_tag3004 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_65_in_coordinate_start3014 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_path_start_tag0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_in_synpred1_simpletikz1475 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_synpred2_simpletikz1690 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_synpred3_simpletikz1709 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_synpred4_simpletikz1729 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_synpred5_simpletikz1814 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_synpred6_simpletikz1833 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_synpred7_simpletikz1853 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_size_in_synpred8_simpletikz2145 = new BitSet(new ulong[]{0x0000000000000002UL});

}
