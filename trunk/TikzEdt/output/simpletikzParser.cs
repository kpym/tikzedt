// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g 2011-02-01 23:59:05

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
		"'\\\\coordinate'", 
		"'\\\\draw'", 
		"'\\\\path'", 
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
    public const int EXPONENT = 33;
    public const int T__67 = 67;
    public const int T__64 = 64;
    public const int TIKZEDT_CMD_COMMENT = 26;
    public const int IM_STARTTAG = 13;
    public const int T__65 = 65;
    public const int T__62 = 62;
    public const int T__63 = 63;
    public const int IM_CONTROLS = 23;
    public const int IM_PATH = 4;
    public const int IM_ID = 18;
    public const int IM_DONTCARE = 25;
    public const int SOMETHING = 36;
    public const int ID = 27;
    public const int T__61 = 61;
    public const int EOF = -1;
    public const int T__60 = 60;
    public const int MATHSTRING = 35;
    public const int COMMAND = 30;
    public const int IM_ENDTAG = 14;
    public const int IM_USETIKZLIB = 20;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int IM_DOCUMENT = 11;
    public const int T__58 = 58;
    public const int ESC_SEQ = 34;
    public const int IM_STRING = 21;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int IM_TIKZSET = 19;
    public const int T__59 = 59;
    public const int IM_OPTION_KV = 17;
    public const int COMMENT = 32;
    public const int T__50 = 50;
    public const int IM_TIKZEDT_CMD = 24;
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
    public const int INT = 29;
    public const int IM_NODE = 5;
    public const int IM_STYLE = 22;
    public const int IM_SCOPE = 12;
    public const int IM_NUMBERUNIT = 9;
    public const int WS = 31;
    public const int T__71 = 71;
    public const int T__72 = 72;
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
    public const int T__79 = 79;
    public const int FLOAT_WO_EXP = 28;
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
		get { return "C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g"; }
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:138:1: tikzdocument : ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* tikzpicture ( . )* -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture ) ;
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
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:139:2: ( ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* tikzpicture ( . )* -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:139:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* tikzpicture ( . )*
            {
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:139:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )*
            	do 
            	{
            	    int alt1 = 4;
            	    switch ( input.LA(1) ) 
            	    {
            	    case 37:
            	    	{
            	        int LA1_1 = input.LA(2);

            	        if ( (LA1_1 == 40) )
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
            	    case 79:
            	    case 80:
            	    case 81:
            	    case 82:
            	    case 83:
            	    	{
            	        alt1 = 1;
            	        }
            	        break;
            	    case TIKZEDT_CMD_COMMENT:
            	    case 38:
            	    case 39:
            	    	{
            	        alt1 = 2;
            	        }
            	        break;

            	    }

            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:139:5: dontcare_preamble
            			    {
            			    	PushFollow(FOLLOW_dontcare_preamble_in_tikzdocument253);
            			    	dontcare_preamble1 = dontcare_preamble();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_dontcare_preamble.Add(dontcare_preamble1.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:139:25: tikz_styleorsetorcmd
            			    {
            			    	PushFollow(FOLLOW_tikz_styleorsetorcmd_in_tikzdocument257);
            			    	tikz_styleorsetorcmd2 = tikz_styleorsetorcmd();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikz_styleorsetorcmd.Add(tikz_styleorsetorcmd2.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:139:48: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzdocument261);
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

            	PushFollow(FOLLOW_tikzpicture_in_tikzdocument266);
            	tikzpicture4 = tikzpicture();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzpicture.Add(tikzpicture4.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:139:74: ( . )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= IM_PATH && LA2_0 <= 83)) )
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
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:139:74: .
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
            	// 139:77: -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:139:80: ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DOCUMENT, "IM_DOCUMENT"), root_1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:139:94: ( tikz_styleorsetorcmd )*
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:142:1: tikzdocument_wo_tikzpicture : ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* EOF -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* ) ;
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
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:143:2: ( ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* EOF -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:143:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* EOF
            {
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:143:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )*
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
            	    case 79:
            	    case 80:
            	    case 81:
            	    case 82:
            	    case 83:
            	    	{
            	        alt3 = 1;
            	        }
            	        break;
            	    case TIKZEDT_CMD_COMMENT:
            	    case 38:
            	    case 39:
            	    	{
            	        alt3 = 2;
            	        }
            	        break;
            	    case 37:
            	    	{
            	        alt3 = 3;
            	        }
            	        break;

            	    }

            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:143:5: dontcare_preamble
            			    {
            			    	PushFollow(FOLLOW_dontcare_preamble_in_tikzdocument_wo_tikzpicture292);
            			    	dontcare_preamble6 = dontcare_preamble();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_dontcare_preamble.Add(dontcare_preamble6.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:143:25: tikz_styleorsetorcmd
            			    {
            			    	PushFollow(FOLLOW_tikz_styleorsetorcmd_in_tikzdocument_wo_tikzpicture296);
            			    	tikz_styleorsetorcmd7 = tikz_styleorsetorcmd();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikz_styleorsetorcmd.Add(tikz_styleorsetorcmd7.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:143:48: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzdocument_wo_tikzpicture300);
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

            	EOF9=(IToken)Match(input,EOF,FOLLOW_EOF_in_tikzdocument_wo_tikzpicture305); if (state.failed) return retval; 
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
            	// 143:66: -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:143:69: ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DOCUMENT, "IM_DOCUMENT"), root_1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:143:83: ( tikz_styleorsetorcmd )*
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:146:1: tikz_cmd_comment : TIKZEDT_CMD_COMMENT -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT ) ;
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
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:2: ( TIKZEDT_CMD_COMMENT -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:4: TIKZEDT_CMD_COMMENT
            {
            	TIKZEDT_CMD_COMMENT10=(IToken)Match(input,TIKZEDT_CMD_COMMENT,FOLLOW_TIKZEDT_CMD_COMMENT_in_tikz_cmd_comment326); if (state.failed) return retval; 
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
            	// 147:27: -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:30: ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT )
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:150:1: tikz_styleorsetorcmd : ( tikz_style | tikz_set | tikz_cmd_comment );
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
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:2: ( tikz_style | tikz_set | tikz_cmd_comment )
            int alt4 = 3;
            switch ( input.LA(1) ) 
            {
            case 38:
            	{
                alt4 = 1;
                }
                break;
            case 39:
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
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:4: tikz_style
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_style_in_tikz_styleorsetorcmd348);
                    	tikz_style11 = tikz_style();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style11.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:17: tikz_set
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_set_in_tikz_styleorsetorcmd352);
                    	tikz_set12 = tikz_set();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set12.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:28: tikz_cmd_comment
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_cmd_comment_in_tikz_styleorsetorcmd356);
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:154:1: dontcare_preamble : ~ ( '\\\\begin' | '\\\\tikzstyle' | '\\\\tikzset' | TIKZEDT_CMD_COMMENT ) ;
    public simpletikzParser.dontcare_preamble_return dontcare_preamble() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_preamble_return retval = new simpletikzParser.dontcare_preamble_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set14 = null;

        object set14_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:155:2: (~ ( '\\\\begin' | '\\\\tikzstyle' | '\\\\tikzset' | TIKZEDT_CMD_COMMENT ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:155:4: ~ ( '\\\\begin' | '\\\\tikzstyle' | '\\\\tikzset' | TIKZEDT_CMD_COMMENT )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set14 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= IM_DONTCARE) || (input.LA(1) >= ID && input.LA(1) <= SOMETHING) || (input.LA(1) >= 40 && input.LA(1) <= 83) ) 
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:157:1: otherbegin : '\\\\begin' '{' idd2 '}' ;
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
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:158:2: ( '\\\\begin' '{' idd2 '}' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:158:4: '\\\\begin' '{' idd2 '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal15=(IToken)Match(input,37,FOLLOW_37_in_otherbegin392); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal15_tree = (object)adaptor.Create(string_literal15);
            		adaptor.AddChild(root_0, string_literal15_tree);
            	}
            	char_literal16=(IToken)Match(input,40,FOLLOW_40_in_otherbegin394); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal16_tree = (object)adaptor.Create(char_literal16);
            		adaptor.AddChild(root_0, char_literal16_tree);
            	}
            	PushFollow(FOLLOW_idd2_in_otherbegin396);
            	idd217 = idd2();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idd217.Tree);
            	char_literal18=(IToken)Match(input,41,FOLLOW_41_in_otherbegin398); if (state.failed) return retval;
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:1: tikz_style : '\\\\tikzstyle' '{' idd '}' '=' tikz_options -> ^( IM_STYLE idd tikz_options ) ;
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
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleTokenStream stream_38 = new RewriteRuleTokenStream(adaptor,"token 38");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:162:2: ( '\\\\tikzstyle' '{' idd '}' '=' tikz_options -> ^( IM_STYLE idd tikz_options ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:162:4: '\\\\tikzstyle' '{' idd '}' '=' tikz_options
            {
            	string_literal19=(IToken)Match(input,38,FOLLOW_38_in_tikz_style410); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_38.Add(string_literal19);

            	char_literal20=(IToken)Match(input,40,FOLLOW_40_in_tikz_style412); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_40.Add(char_literal20);

            	PushFollow(FOLLOW_idd_in_tikz_style414);
            	idd21 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idd.Add(idd21.Tree);
            	char_literal22=(IToken)Match(input,41,FOLLOW_41_in_tikz_style416); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(char_literal22);

            	char_literal23=(IToken)Match(input,42,FOLLOW_42_in_tikz_style418); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_42.Add(char_literal23);

            	PushFollow(FOLLOW_tikz_options_in_tikz_style420);
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
            	// 162:47: -> ^( IM_STYLE idd tikz_options )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:162:50: ^( IM_STYLE idd tikz_options )
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:1: tikz_options : squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) ;
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
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleSubtreeStream stream_squarebr_start = new RewriteRuleSubtreeStream(adaptor,"rule squarebr_start");
        RewriteRuleSubtreeStream stream_squarebr_end = new RewriteRuleSubtreeStream(adaptor,"rule squarebr_end");
        RewriteRuleSubtreeStream stream_option = new RewriteRuleSubtreeStream(adaptor,"rule option");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:166:2: ( squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:166:5: squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end
            {
            	PushFollow(FOLLOW_squarebr_start_in_tikz_options442);
            	squarebr_start25 = squarebr_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_squarebr_start.Add(squarebr_start25.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:166:20: ( option ( ',' option )* ( ',' )? )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( ((LA7_0 >= IM_PATH && LA7_0 <= 39) || LA7_0 == 47 || (LA7_0 >= 53 && LA7_0 <= 83)) )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:166:21: option ( ',' option )* ( ',' )?
            	        {
            	        	PushFollow(FOLLOW_option_in_tikz_options445);
            	        	option26 = option();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_option.Add(option26.Tree);
            	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:166:28: ( ',' option )*
            	        	do 
            	        	{
            	        	    int alt5 = 2;
            	        	    int LA5_0 = input.LA(1);

            	        	    if ( (LA5_0 == 43) )
            	        	    {
            	        	        int LA5_1 = input.LA(2);

            	        	        if ( ((LA5_1 >= IM_PATH && LA5_1 <= 39) || LA5_1 == 47 || (LA5_1 >= 53 && LA5_1 <= 83)) )
            	        	        {
            	        	            alt5 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt5) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:166:29: ',' option
            	        			    {
            	        			    	char_literal27=(IToken)Match(input,43,FOLLOW_43_in_tikz_options448); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_43.Add(char_literal27);

            	        			    	PushFollow(FOLLOW_option_in_tikz_options450);
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

            	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:166:42: ( ',' )?
            	        	int alt6 = 2;
            	        	int LA6_0 = input.LA(1);

            	        	if ( (LA6_0 == 43) )
            	        	{
            	        	    alt6 = 1;
            	        	}
            	        	switch (alt6) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:166:42: ','
            	        	        {
            	        	        	char_literal29=(IToken)Match(input,43,FOLLOW_43_in_tikz_options454); if (state.failed) return retval; 
            	        	        	if ( (state.backtracking==0) ) stream_43.Add(char_literal29);


            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_squarebr_end_in_tikz_options459);
            	squarebr_end30 = squarebr_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_squarebr_end.Add(squarebr_end30.Tree);


            	// AST REWRITE
            	// elements:          squarebr_start, squarebr_end, option
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 166:63: -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:166:66: ^( IM_OPTIONS squarebr_start ( option )* squarebr_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTIONS, "IM_OPTIONS"), root_1);

            	    adaptor.AddChild(root_1, stream_squarebr_start.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:166:94: ( option )*
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:169:1: option : ( option_style | option_kv );
    public simpletikzParser.option_return option() // throws RecognitionException [1]
    {   
        simpletikzParser.option_return retval = new simpletikzParser.option_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.option_style_return option_style31 = default(simpletikzParser.option_style_return);

        simpletikzParser.option_kv_return option_kv32 = default(simpletikzParser.option_kv_return);



        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:170:2: ( option_style | option_kv )
            int alt8 = 2;
            alt8 = dfa8.Predict(input);
            switch (alt8) 
            {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:170:4: option_style
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_option_style_in_option484);
                    	option_style31 = option_style();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, option_style31.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:171:5: option_kv
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_option_kv_in_option493);
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:174:1: option_kv : idd ( '=' iddornumberunitorstringorrange )? -> ^( IM_OPTION_KV idd ( iddornumberunitorstringorrange )? ) ;
    public simpletikzParser.option_kv_return option_kv() // throws RecognitionException [1]
    {   
        simpletikzParser.option_kv_return retval = new simpletikzParser.option_kv_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal34 = null;
        simpletikzParser.idd_return idd33 = default(simpletikzParser.idd_return);

        simpletikzParser.iddornumberunitorstringorrange_return iddornumberunitorstringorrange35 = default(simpletikzParser.iddornumberunitorstringorrange_return);


        object char_literal34_tree=null;
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleSubtreeStream stream_iddornumberunitorstringorrange = new RewriteRuleSubtreeStream(adaptor,"rule iddornumberunitorstringorrange");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:175:2: ( idd ( '=' iddornumberunitorstringorrange )? -> ^( IM_OPTION_KV idd ( iddornumberunitorstringorrange )? ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:175:4: idd ( '=' iddornumberunitorstringorrange )?
            {
            	PushFollow(FOLLOW_idd_in_option_kv507);
            	idd33 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idd.Add(idd33.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:175:8: ( '=' iddornumberunitorstringorrange )?
            	int alt9 = 2;
            	int LA9_0 = input.LA(1);

            	if ( (LA9_0 == 42) )
            	{
            	    alt9 = 1;
            	}
            	switch (alt9) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:175:9: '=' iddornumberunitorstringorrange
            	        {
            	        	char_literal34=(IToken)Match(input,42,FOLLOW_42_in_option_kv510); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_42.Add(char_literal34);

            	        	PushFollow(FOLLOW_iddornumberunitorstringorrange_in_option_kv512);
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
            	// 175:47: -> ^( IM_OPTION_KV idd ( iddornumberunitorstringorrange )? )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:175:50: ^( IM_OPTION_KV idd ( iddornumberunitorstringorrange )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTION_KV, "IM_OPTION_KV"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:175:69: ( iddornumberunitorstringorrange )?
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:178:1: tikzstring : '{' ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* '}' -> ^( IM_STRING '{' '}' ) ;
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
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleSubtreeStream stream_tikzstring = new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_no_rlbrace = new RewriteRuleSubtreeStream(adaptor,"rule no_rlbrace");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:179:2: ( '{' ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* '}' -> ^( IM_STRING '{' '}' ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:179:4: '{' ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* '}'
            {
            	char_literal36=(IToken)Match(input,40,FOLLOW_40_in_tikzstring540); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_40.Add(char_literal36);

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:179:8: ( no_rlbrace )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( ((LA10_0 >= IM_PATH && LA10_0 <= 39) || (LA10_0 >= 42 && LA10_0 <= 83)) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:179:8: no_rlbrace
            			    {
            			    	PushFollow(FOLLOW_no_rlbrace_in_tikzstring542);
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

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:179:20: ( tikzstring ( no_rlbrace )* )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( (LA12_0 == 40) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:179:21: tikzstring ( no_rlbrace )*
            			    {
            			    	PushFollow(FOLLOW_tikzstring_in_tikzstring546);
            			    	tikzstring38 = tikzstring();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikzstring.Add(tikzstring38.Tree);
            			    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:179:32: ( no_rlbrace )*
            			    	do 
            			    	{
            			    	    int alt11 = 2;
            			    	    int LA11_0 = input.LA(1);

            			    	    if ( ((LA11_0 >= IM_PATH && LA11_0 <= 39) || (LA11_0 >= 42 && LA11_0 <= 83)) )
            			    	    {
            			    	        alt11 = 1;
            			    	    }


            			    	    switch (alt11) 
            			    		{
            			    			case 1 :
            			    			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:179:32: no_rlbrace
            			    			    {
            			    			    	PushFollow(FOLLOW_no_rlbrace_in_tikzstring548);
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

            	char_literal40=(IToken)Match(input,41,FOLLOW_41_in_tikzstring553); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(char_literal40);



            	// AST REWRITE
            	// elements:          40, 41
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 179:50: -> ^( IM_STRING '{' '}' )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:179:53: ^( IM_STRING '{' '}' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STRING, "IM_STRING"), root_1);

            	    adaptor.AddChild(root_1, stream_40.NextNode());
            	    adaptor.AddChild(root_1, stream_41.NextNode());

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:1: no_rlbrace : ~ ( '{' | '}' ) ;
    public simpletikzParser.no_rlbrace_return no_rlbrace() // throws RecognitionException [1]
    {   
        simpletikzParser.no_rlbrace_return retval = new simpletikzParser.no_rlbrace_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set41 = null;

        object set41_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:2: (~ ( '{' | '}' ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:4: ~ ( '{' | '}' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set41 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= 39) || (input.LA(1) >= 42 && input.LA(1) <= 83) ) 
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:185:1: iddornumberunitorstringorrange : ( range | numberunit | bracedcoord | idd | tikzstring );
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
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:186:2: ( range | numberunit | bracedcoord | idd | tikzstring )
            int alt13 = 5;
            alt13 = dfa13.Predict(input);
            switch (alt13) 
            {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:186:5: range
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_range_in_iddornumberunitorstringorrange594);
                    	range42 = range();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, range42.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:186:13: numberunit
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_numberunit_in_iddornumberunitorstringorrange598);
                    	numberunit43 = numberunit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, numberunit43.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:186:26: bracedcoord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_bracedcoord_in_iddornumberunitorstringorrange602);
                    	bracedcoord44 = bracedcoord();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bracedcoord44.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:186:40: idd
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_idd_in_iddornumberunitorstringorrange606);
                    	idd45 = idd();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idd45.Tree);

                    }
                    break;
                case 5 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:186:46: tikzstring
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikzstring_in_iddornumberunitorstringorrange610);
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:188:1: bracedcoord : '{' coord '}' ;
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
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:189:2: ( '{' coord '}' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:189:4: '{' coord '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal47=(IToken)Match(input,40,FOLLOW_40_in_bracedcoord623); if (state.failed) return retval;
            	PushFollow(FOLLOW_coord_in_bracedcoord627);
            	coord48 = coord();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, coord48.Tree);
            	char_literal49=(IToken)Match(input,41,FOLLOW_41_in_bracedcoord629); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:191:1: range : numberunit ':' numberunit -> ^( IM_STRING numberunit ':' numberunit ) ;
    public simpletikzParser.range_return range() // throws RecognitionException [1]
    {   
        simpletikzParser.range_return retval = new simpletikzParser.range_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal51 = null;
        simpletikzParser.numberunit_return numberunit50 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit52 = default(simpletikzParser.numberunit_return);


        object char_literal51_tree=null;
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:192:2: ( numberunit ':' numberunit -> ^( IM_STRING numberunit ':' numberunit ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:192:4: numberunit ':' numberunit
            {
            	PushFollow(FOLLOW_numberunit_in_range640);
            	numberunit50 = numberunit();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit50.Tree);
            	char_literal51=(IToken)Match(input,44,FOLLOW_44_in_range642); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_44.Add(char_literal51);

            	PushFollow(FOLLOW_numberunit_in_range644);
            	numberunit52 = numberunit();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit52.Tree);


            	// AST REWRITE
            	// elements:          numberunit, numberunit, 44
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 192:30: -> ^( IM_STRING numberunit ':' numberunit )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:192:33: ^( IM_STRING numberunit ':' numberunit )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STRING, "IM_STRING"), root_1);

            	    adaptor.AddChild(root_1, stream_numberunit.NextTree());
            	    adaptor.AddChild(root_1, stream_44.NextNode());
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:194:1: option_style : idd ( '/.style' | ( '/.append' 'style' ) ) '=' '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}' -> ^( IM_OPTION_STYLE idd ( option_kv )* ) ;
    public simpletikzParser.option_style_return option_style() // throws RecognitionException [1]
    {   
        simpletikzParser.option_style_return retval = new simpletikzParser.option_style_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal54 = null;
        IToken string_literal55 = null;
        IToken string_literal56 = null;
        IToken char_literal57 = null;
        IToken char_literal58 = null;
        IToken char_literal60 = null;
        IToken char_literal62 = null;
        IToken char_literal63 = null;
        simpletikzParser.idd_return idd53 = default(simpletikzParser.idd_return);

        simpletikzParser.option_kv_return option_kv59 = default(simpletikzParser.option_kv_return);

        simpletikzParser.option_kv_return option_kv61 = default(simpletikzParser.option_kv_return);


        object string_literal54_tree=null;
        object string_literal55_tree=null;
        object string_literal56_tree=null;
        object char_literal57_tree=null;
        object char_literal58_tree=null;
        object char_literal60_tree=null;
        object char_literal62_tree=null;
        object char_literal63_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleTokenStream stream_47 = new RewriteRuleTokenStream(adaptor,"token 47");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleTokenStream stream_46 = new RewriteRuleTokenStream(adaptor,"token 46");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_option_kv = new RewriteRuleSubtreeStream(adaptor,"rule option_kv");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:2: ( idd ( '/.style' | ( '/.append' 'style' ) ) '=' '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}' -> ^( IM_OPTION_STYLE idd ( option_kv )* ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:4: idd ( '/.style' | ( '/.append' 'style' ) ) '=' '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}'
            {
            	PushFollow(FOLLOW_idd_in_option_style668);
            	idd53 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idd.Add(idd53.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:8: ( '/.style' | ( '/.append' 'style' ) )
            	int alt14 = 2;
            	int LA14_0 = input.LA(1);

            	if ( (LA14_0 == 45) )
            	{
            	    alt14 = 1;
            	}
            	else if ( (LA14_0 == 46) )
            	{
            	    alt14 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d14s0 =
            	        new NoViableAltException("", 14, 0, input);

            	    throw nvae_d14s0;
            	}
            	switch (alt14) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:9: '/.style'
            	        {
            	        	string_literal54=(IToken)Match(input,45,FOLLOW_45_in_option_style671); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_45.Add(string_literal54);


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:21: ( '/.append' 'style' )
            	        {
            	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:21: ( '/.append' 'style' )
            	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:22: '/.append' 'style'
            	        	{
            	        		string_literal55=(IToken)Match(input,46,FOLLOW_46_in_option_style676); if (state.failed) return retval; 
            	        		if ( (state.backtracking==0) ) stream_46.Add(string_literal55);

            	        		string_literal56=(IToken)Match(input,47,FOLLOW_47_in_option_style678); if (state.failed) return retval; 
            	        		if ( (state.backtracking==0) ) stream_47.Add(string_literal56);


            	        	}


            	        }
            	        break;

            	}

            	char_literal57=(IToken)Match(input,42,FOLLOW_42_in_option_style682); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_42.Add(char_literal57);

            	char_literal58=(IToken)Match(input,40,FOLLOW_40_in_option_style684); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_40.Add(char_literal58);

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:51: ( option_kv ( ',' option_kv )* )?
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( ((LA16_0 >= IM_PATH && LA16_0 <= 39) || LA16_0 == 47 || (LA16_0 >= 53 && LA16_0 <= 83)) )
            	{
            	    alt16 = 1;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:52: option_kv ( ',' option_kv )*
            	        {
            	        	PushFollow(FOLLOW_option_kv_in_option_style687);
            	        	option_kv59 = option_kv();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_option_kv.Add(option_kv59.Tree);
            	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:62: ( ',' option_kv )*
            	        	do 
            	        	{
            	        	    int alt15 = 2;
            	        	    int LA15_0 = input.LA(1);

            	        	    if ( (LA15_0 == 43) )
            	        	    {
            	        	        int LA15_1 = input.LA(2);

            	        	        if ( ((LA15_1 >= IM_PATH && LA15_1 <= 39) || LA15_1 == 47 || (LA15_1 >= 53 && LA15_1 <= 83)) )
            	        	        {
            	        	            alt15 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt15) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:63: ',' option_kv
            	        			    {
            	        			    	char_literal60=(IToken)Match(input,43,FOLLOW_43_in_option_style690); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_43.Add(char_literal60);

            	        			    	PushFollow(FOLLOW_option_kv_in_option_style692);
            	        			    	option_kv61 = option_kv();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( (state.backtracking==0) ) stream_option_kv.Add(option_kv61.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop15;
            	        	    }
            	        	} while (true);

            	        	loop15:
            	        		;	// Stops C# compiler whining that label 'loop15' has no statements


            	        }
            	        break;

            	}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:82: ( ',' )?
            	int alt17 = 2;
            	int LA17_0 = input.LA(1);

            	if ( (LA17_0 == 43) )
            	{
            	    alt17 = 1;
            	}
            	switch (alt17) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:82: ','
            	        {
            	        	char_literal62=(IToken)Match(input,43,FOLLOW_43_in_option_style699); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_43.Add(char_literal62);


            	        }
            	        break;

            	}

            	char_literal63=(IToken)Match(input,41,FOLLOW_41_in_option_style702); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(char_literal63);



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
            	// 195:92: -> ^( IM_OPTION_STYLE idd ( option_kv )* )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:95: ^( IM_OPTION_STYLE idd ( option_kv )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTION_STYLE, "IM_OPTION_STYLE"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:117: ( option_kv )*
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:207:1: idd : idd_heavenknowswhythisisnecessary -> ^( IM_ID ) ;
    public simpletikzParser.idd_return idd() // throws RecognitionException [1]
    {   
        simpletikzParser.idd_return retval = new simpletikzParser.idd_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.idd_heavenknowswhythisisnecessary_return idd_heavenknowswhythisisnecessary64 = default(simpletikzParser.idd_heavenknowswhythisisnecessary_return);


        RewriteRuleSubtreeStream stream_idd_heavenknowswhythisisnecessary = new RewriteRuleSubtreeStream(adaptor,"rule idd_heavenknowswhythisisnecessary");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:208:2: ( idd_heavenknowswhythisisnecessary -> ^( IM_ID ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:208:4: idd_heavenknowswhythisisnecessary
            {
            	PushFollow(FOLLOW_idd_heavenknowswhythisisnecessary_in_idd737);
            	idd_heavenknowswhythisisnecessary64 = idd_heavenknowswhythisisnecessary();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idd_heavenknowswhythisisnecessary.Add(idd_heavenknowswhythisisnecessary64.Tree);


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
            	// 208:39: -> ^( IM_ID )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:208:42: ^( IM_ID )
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:210:1: idd_heavenknowswhythisisnecessary : (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' ) )+ ;
    public simpletikzParser.idd_heavenknowswhythisisnecessary_return idd_heavenknowswhythisisnecessary() // throws RecognitionException [1]
    {   
        simpletikzParser.idd_heavenknowswhythisisnecessary_return retval = new simpletikzParser.idd_heavenknowswhythisisnecessary_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set65 = null;

        object set65_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:211:3: ( (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' ) )+ )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:211:6: (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' ) )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:211:6: (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' ) )+
            	int cnt18 = 0;
            	do 
            	{
            	    int alt18 = 2;
            	    int LA18_0 = input.LA(1);

            	    if ( ((LA18_0 >= IM_PATH && LA18_0 <= 39) || LA18_0 == 47 || (LA18_0 >= 53 && LA18_0 <= 83)) )
            	    {
            	        alt18 = 1;
            	    }


            	    switch (alt18) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:211:6: ~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' )
            			    {
            			    	set65 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= 39) || input.LA(1) == 47 || (input.LA(1) >= 53 && input.LA(1) <= 83) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set65));
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


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:212:1: idd2 : ( ID )+ -> ^( IM_ID ) ;
    public simpletikzParser.idd2_return idd2() // throws RecognitionException [1]
    {   
        simpletikzParser.idd2_return retval = new simpletikzParser.idd2_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID66 = null;

        object ID66_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:213:2: ( ( ID )+ -> ^( IM_ID ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:213:4: ( ID )+
            {
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:213:4: ( ID )+
            	int cnt19 = 0;
            	do 
            	{
            	    int alt19 = 2;
            	    int LA19_0 = input.LA(1);

            	    if ( (LA19_0 == ID) )
            	    {
            	        alt19 = 1;
            	    }


            	    switch (alt19) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:213:4: ID
            			    {
            			    	ID66=(IToken)Match(input,ID,FOLLOW_ID_in_idd2816); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_ID.Add(ID66);


            			    }
            			    break;

            			default:
            			    if ( cnt19 >= 1 ) goto loop19;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee19 =
            		                new EarlyExitException(19, input);
            		            throw eee19;
            	    }
            	    cnt19++;
            	} while (true);

            	loop19:
            		;	// Stops C# compiler whining that label 'loop19' has no statements



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
            	// 213:8: -> ^( IM_ID )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:213:11: ^( IM_ID )
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:217:1: numberunit : number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) ;
    public simpletikzParser.numberunit_return numberunit() // throws RecognitionException [1]
    {   
        simpletikzParser.numberunit_return retval = new simpletikzParser.numberunit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.number_return number67 = default(simpletikzParser.number_return);

        simpletikzParser.unit_return unit68 = default(simpletikzParser.unit_return);


        RewriteRuleSubtreeStream stream_unit = new RewriteRuleSubtreeStream(adaptor,"rule unit");
        RewriteRuleSubtreeStream stream_number = new RewriteRuleSubtreeStream(adaptor,"rule number");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:218:2: ( number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:218:4: number ( unit )?
            {
            	PushFollow(FOLLOW_number_in_numberunit839);
            	number67 = number();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_number.Add(number67.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:218:11: ( unit )?
            	int alt20 = 2;
            	int LA20_0 = input.LA(1);

            	if ( ((LA20_0 >= 53 && LA20_0 <= 58)) )
            	{
            	    alt20 = 1;
            	}
            	switch (alt20) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:218:11: unit
            	        {
            	        	PushFollow(FOLLOW_unit_in_numberunit841);
            	        	unit68 = unit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_unit.Add(unit68.Tree);

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
            	// 218:17: -> ^( IM_NUMBERUNIT number ( unit )? )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:218:20: ^( IM_NUMBERUNIT number ( unit )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NUMBERUNIT, "IM_NUMBERUNIT"), root_1);

            	    adaptor.AddChild(root_1, stream_number.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:218:43: ( unit )?
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:222:1: number : ( FLOAT_WO_EXP | INT ) ;
    public simpletikzParser.number_return number() // throws RecognitionException [1]
    {   
        simpletikzParser.number_return retval = new simpletikzParser.number_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set69 = null;

        object set69_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:223:2: ( ( FLOAT_WO_EXP | INT ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:223:4: ( FLOAT_WO_EXP | INT )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set69 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= FLOAT_WO_EXP && input.LA(1) <= INT) ) 
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

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:226:1: unit : ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' | 'em' );
    public simpletikzParser.unit_return unit() // throws RecognitionException [1]
    {   
        simpletikzParser.unit_return retval = new simpletikzParser.unit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set70 = null;

        object set70_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:227:2: ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' | 'em' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set70 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 53 && input.LA(1) <= 58) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set70));
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:230:1: tikz_set : tikz_set_start ( option ( ',' option )* ( ',' )? )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) ;
    public simpletikzParser.tikz_set_return tikz_set() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_set_return retval = new simpletikzParser.tikz_set_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal73 = null;
        IToken char_literal75 = null;
        simpletikzParser.tikz_set_start_return tikz_set_start71 = default(simpletikzParser.tikz_set_start_return);

        simpletikzParser.option_return option72 = default(simpletikzParser.option_return);

        simpletikzParser.option_return option74 = default(simpletikzParser.option_return);

        simpletikzParser.roundbr_end_return roundbr_end76 = default(simpletikzParser.roundbr_end_return);


        object char_literal73_tree=null;
        object char_literal75_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleSubtreeStream stream_tikz_set_start = new RewriteRuleSubtreeStream(adaptor,"rule tikz_set_start");
        RewriteRuleSubtreeStream stream_roundbr_end = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        RewriteRuleSubtreeStream stream_option = new RewriteRuleSubtreeStream(adaptor,"rule option");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:231:2: ( tikz_set_start ( option ( ',' option )* ( ',' )? )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:231:5: tikz_set_start ( option ( ',' option )* ( ',' )? )? roundbr_end
            {
            	PushFollow(FOLLOW_tikz_set_start_in_tikz_set922);
            	tikz_set_start71 = tikz_set_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikz_set_start.Add(tikz_set_start71.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:231:20: ( option ( ',' option )* ( ',' )? )?
            	int alt23 = 2;
            	int LA23_0 = input.LA(1);

            	if ( ((LA23_0 >= IM_PATH && LA23_0 <= 39) || LA23_0 == 47 || (LA23_0 >= 53 && LA23_0 <= 83)) )
            	{
            	    alt23 = 1;
            	}
            	switch (alt23) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:231:21: option ( ',' option )* ( ',' )?
            	        {
            	        	PushFollow(FOLLOW_option_in_tikz_set925);
            	        	option72 = option();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_option.Add(option72.Tree);
            	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:231:28: ( ',' option )*
            	        	do 
            	        	{
            	        	    int alt21 = 2;
            	        	    int LA21_0 = input.LA(1);

            	        	    if ( (LA21_0 == 43) )
            	        	    {
            	        	        int LA21_1 = input.LA(2);

            	        	        if ( ((LA21_1 >= IM_PATH && LA21_1 <= 39) || LA21_1 == 47 || (LA21_1 >= 53 && LA21_1 <= 83)) )
            	        	        {
            	        	            alt21 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt21) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:231:29: ',' option
            	        			    {
            	        			    	char_literal73=(IToken)Match(input,43,FOLLOW_43_in_tikz_set928); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_43.Add(char_literal73);

            	        			    	PushFollow(FOLLOW_option_in_tikz_set930);
            	        			    	option74 = option();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( (state.backtracking==0) ) stream_option.Add(option74.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop21;
            	        	    }
            	        	} while (true);

            	        	loop21:
            	        		;	// Stops C# compiler whining that label 'loop21' has no statements

            	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:231:42: ( ',' )?
            	        	int alt22 = 2;
            	        	int LA22_0 = input.LA(1);

            	        	if ( (LA22_0 == 43) )
            	        	{
            	        	    alt22 = 1;
            	        	}
            	        	switch (alt22) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:231:42: ','
            	        	        {
            	        	        	char_literal75=(IToken)Match(input,43,FOLLOW_43_in_tikz_set934); if (state.failed) return retval; 
            	        	        	if ( (state.backtracking==0) ) stream_43.Add(char_literal75);


            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_roundbr_end_in_tikz_set939);
            	roundbr_end76 = roundbr_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_roundbr_end.Add(roundbr_end76.Tree);


            	// AST REWRITE
            	// elements:          tikz_set_start, roundbr_end, option
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 231:61: -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:231:64: ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_TIKZSET, "IM_TIKZSET"), root_1);

            	    adaptor.AddChild(root_1, stream_tikz_set_start.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:231:92: ( option )*
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:236:1: tikzpicture : tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) ;
    public simpletikzParser.tikzpicture_return tikzpicture() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_return retval = new simpletikzParser.tikzpicture_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzpicture_start_return tikzpicture_start77 = default(simpletikzParser.tikzpicture_start_return);

        simpletikzParser.tikz_options_return tikz_options78 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody_return tikzbody79 = default(simpletikzParser.tikzbody_return);

        simpletikzParser.tikzpicture_end_return tikzpicture_end80 = default(simpletikzParser.tikzpicture_end_return);


        RewriteRuleSubtreeStream stream_tikzpicture_end = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_end");
        RewriteRuleSubtreeStream stream_tikzpicture_start = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_start");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:237:2: ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:237:5: tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end
            {
            	PushFollow(FOLLOW_tikzpicture_start_in_tikzpicture967);
            	tikzpicture_start77 = tikzpicture_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzpicture_start.Add(tikzpicture_start77.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:237:23: ( tikz_options )?
            	int alt24 = 2;
            	int LA24_0 = input.LA(1);

            	if ( (LA24_0 == 50) )
            	{
            	    alt24 = 1;
            	}
            	switch (alt24) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:237:23: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_tikzpicture969);
            	        	tikz_options78 = tikz_options();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_tikz_options.Add(tikz_options78.Tree);

            	        }
            	        break;

            	}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:237:37: ( tikzbody )?
            	int alt25 = 2;
            	int LA25_0 = input.LA(1);

            	if ( ((LA25_0 >= IM_PATH && LA25_0 <= 49) || (LA25_0 >= 51 && LA25_0 <= 58) || (LA25_0 >= 60 && LA25_0 <= 83)) )
            	{
            	    alt25 = 1;
            	}
            	else if ( (LA25_0 == 59) )
            	{
            	    int LA25_2 = input.LA(2);

            	    if ( (LA25_2 == 40) )
            	    {
            	        int LA25_3 = input.LA(3);

            	        if ( (LA25_3 == ID) )
            	        {
            	            alt25 = 1;
            	        }
            	    }
            	}
            	switch (alt25) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:237:37: tikzbody
            	        {
            	        	PushFollow(FOLLOW_tikzbody_in_tikzpicture972);
            	        	tikzbody79 = tikzbody();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_tikzbody.Add(tikzbody79.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzpicture_end_in_tikzpicture975);
            	tikzpicture_end80 = tikzpicture_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzpicture_end.Add(tikzpicture_end80.Tree);


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
            	// 237:64: -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:237:67: ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PICTURE, "IM_PICTURE"), root_1);

            	    adaptor.AddChild(root_1, stream_tikzpicture_start.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:237:98: ( tikz_options )?
            	    if ( stream_tikz_options.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikz_options.NextTree());

            	    }
            	    stream_tikz_options.Reset();
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:237:112: ( tikzbody )?
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:240:1: tikzbody : ( tikzscope | tikzpath | tikznode_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )* ;
    public simpletikzParser.tikzbody_return tikzbody() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzbody_return retval = new simpletikzParser.tikzbody_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_return tikzscope81 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath82 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznode_ext_return tikznode_ext83 = default(simpletikzParser.tikznode_ext_return);

        simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext84 = default(simpletikzParser.tikzcoordinate_ext_return);

        simpletikzParser.tikz_set_return tikz_set85 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style86 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin87 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend88 = default(simpletikzParser.otherend_return);

        simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr89 = default(simpletikzParser.dontcare_body_nobr_return);

        simpletikzParser.tikzscope_return tikzscope90 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath91 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznode_ext_return tikznode_ext92 = default(simpletikzParser.tikznode_ext_return);

        simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext93 = default(simpletikzParser.tikzcoordinate_ext_return);

        simpletikzParser.tikz_set_return tikz_set94 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style95 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin96 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend97 = default(simpletikzParser.otherend_return);

        simpletikzParser.dontcare_body_return dontcare_body98 = default(simpletikzParser.dontcare_body_return);



        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:241:2: ( ( tikzscope | tikzpath | tikznode_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )* )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:241:4: ( tikzscope | tikzpath | tikznode_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:241:4: ( tikzscope | tikzpath | tikznode_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr )
            	int alt26 = 9;
            	alt26 = dfa26.Predict(input);
            	switch (alt26) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:241:6: tikzscope
            	        {
            	        	PushFollow(FOLLOW_tikzscope_in_tikzbody1005);
            	        	tikzscope81 = tikzscope();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzscope81.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:241:18: tikzpath
            	        {
            	        	PushFollow(FOLLOW_tikzpath_in_tikzbody1009);
            	        	tikzpath82 = tikzpath();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath82.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:241:29: tikznode_ext
            	        {
            	        	PushFollow(FOLLOW_tikznode_ext_in_tikzbody1013);
            	        	tikznode_ext83 = tikznode_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_ext83.Tree);

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:241:44: tikzcoordinate_ext
            	        {
            	        	PushFollow(FOLLOW_tikzcoordinate_ext_in_tikzbody1017);
            	        	tikzcoordinate_ext84 = tikzcoordinate_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_ext84.Tree);

            	        }
            	        break;
            	    case 5 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:241:65: tikz_set
            	        {
            	        	PushFollow(FOLLOW_tikz_set_in_tikzbody1021);
            	        	tikz_set85 = tikz_set();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set85.Tree);

            	        }
            	        break;
            	    case 6 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:241:76: tikz_style
            	        {
            	        	PushFollow(FOLLOW_tikz_style_in_tikzbody1025);
            	        	tikz_style86 = tikz_style();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style86.Tree);

            	        }
            	        break;
            	    case 7 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:241:89: otherbegin
            	        {
            	        	PushFollow(FOLLOW_otherbegin_in_tikzbody1029);
            	        	otherbegin87 = otherbegin();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;
            	    case 8 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:241:103: otherend
            	        {
            	        	PushFollow(FOLLOW_otherend_in_tikzbody1034);
            	        	otherend88 = otherend();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;
            	    case 9 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:241:115: dontcare_body_nobr
            	        {
            	        	PushFollow(FOLLOW_dontcare_body_nobr_in_tikzbody1039);
            	        	dontcare_body_nobr89 = dontcare_body_nobr();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;

            	}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:242:3: ( tikzscope | tikzpath | tikznode_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*
            	do 
            	{
            	    int alt27 = 10;
            	    alt27 = dfa27.Predict(input);
            	    switch (alt27) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:242:5: tikzscope
            			    {
            			    	PushFollow(FOLLOW_tikzscope_in_tikzbody1050);
            			    	tikzscope90 = tikzscope();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzscope90.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:242:17: tikzpath
            			    {
            			    	PushFollow(FOLLOW_tikzpath_in_tikzbody1054);
            			    	tikzpath91 = tikzpath();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath91.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:242:28: tikznode_ext
            			    {
            			    	PushFollow(FOLLOW_tikznode_ext_in_tikzbody1058);
            			    	tikznode_ext92 = tikznode_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_ext92.Tree);

            			    }
            			    break;
            			case 4 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:242:43: tikzcoordinate_ext
            			    {
            			    	PushFollow(FOLLOW_tikzcoordinate_ext_in_tikzbody1062);
            			    	tikzcoordinate_ext93 = tikzcoordinate_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_ext93.Tree);

            			    }
            			    break;
            			case 5 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:242:64: tikz_set
            			    {
            			    	PushFollow(FOLLOW_tikz_set_in_tikzbody1066);
            			    	tikz_set94 = tikz_set();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set94.Tree);

            			    }
            			    break;
            			case 6 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:242:75: tikz_style
            			    {
            			    	PushFollow(FOLLOW_tikz_style_in_tikzbody1070);
            			    	tikz_style95 = tikz_style();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style95.Tree);

            			    }
            			    break;
            			case 7 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:242:88: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzbody1074);
            			    	otherbegin96 = otherbegin();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;
            			case 8 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:242:102: otherend
            			    {
            			    	PushFollow(FOLLOW_otherend_in_tikzbody1079);
            			    	otherend97 = otherend();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;
            			case 9 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:242:114: dontcare_body
            			    {
            			    	PushFollow(FOLLOW_dontcare_body_in_tikzbody1084);
            			    	dontcare_body98 = dontcare_body();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

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

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:245:1: dontcare_body_nobr : (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) ) ;
    public simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body_nobr_return retval = new simpletikzParser.dontcare_body_nobr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set99 = null;

        object set99_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:246:2: ( (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:246:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:246:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) )
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:246:5: ~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' )
            	{
            		set99 = (IToken)input.LT(1);
            		if ( (input.LA(1) >= IM_PATH && input.LA(1) <= SOMETHING) || (input.LA(1) >= 40 && input.LA(1) <= 49) || (input.LA(1) >= 51 && input.LA(1) <= 58) || (input.LA(1) >= 66 && input.LA(1) <= 83) ) 
            		{
            		    input.Consume();
            		    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set99));
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:248:1: dontcare_body : (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) ) ;
    public simpletikzParser.dontcare_body_return dontcare_body() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body_return retval = new simpletikzParser.dontcare_body_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set100 = null;

        object set100_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:249:2: ( (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:249:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:249:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) )
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:249:5: ~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' )
            	{
            		set100 = (IToken)input.LT(1);
            		if ( (input.LA(1) >= IM_PATH && input.LA(1) <= SOMETHING) || (input.LA(1) >= 40 && input.LA(1) <= 58) || (input.LA(1) >= 66 && input.LA(1) <= 83) ) 
            		{
            		    input.Consume();
            		    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set100));
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:251:1: otherend : '\\\\end' '{' idd2 '}' ;
    public simpletikzParser.otherend_return otherend() // throws RecognitionException [1]
    {   
        simpletikzParser.otherend_return retval = new simpletikzParser.otherend_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal101 = null;
        IToken char_literal102 = null;
        IToken char_literal104 = null;
        simpletikzParser.idd2_return idd2103 = default(simpletikzParser.idd2_return);


        object string_literal101_tree=null;
        object char_literal102_tree=null;
        object char_literal104_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:252:2: ( '\\\\end' '{' idd2 '}' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:252:4: '\\\\end' '{' idd2 '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal101=(IToken)Match(input,59,FOLLOW_59_in_otherend1214); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal101_tree = (object)adaptor.Create(string_literal101);
            		adaptor.AddChild(root_0, string_literal101_tree);
            	}
            	char_literal102=(IToken)Match(input,40,FOLLOW_40_in_otherend1216); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal102_tree = (object)adaptor.Create(char_literal102);
            		adaptor.AddChild(root_0, char_literal102_tree);
            	}
            	PushFollow(FOLLOW_idd2_in_otherend1218);
            	idd2103 = idd2();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idd2103.Tree);
            	char_literal104=(IToken)Match(input,41,FOLLOW_41_in_otherend1220); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal104_tree = (object)adaptor.Create(char_literal104);
            		adaptor.AddChild(root_0, char_literal104_tree);
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:266:1: tikzscope : tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end ) ;
    public simpletikzParser.tikzscope_return tikzscope() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_return retval = new simpletikzParser.tikzscope_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_start_return tikzscope_start105 = default(simpletikzParser.tikzscope_start_return);

        simpletikzParser.tikz_options_return tikz_options106 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody_return tikzbody107 = default(simpletikzParser.tikzbody_return);

        simpletikzParser.tikzscope_end_return tikzscope_end108 = default(simpletikzParser.tikzscope_end_return);


        RewriteRuleSubtreeStream stream_tikzscope_start = new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_start");
        RewriteRuleSubtreeStream stream_tikzscope_end = new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_end");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:267:2: ( tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:267:4: tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end
            {
            	PushFollow(FOLLOW_tikzscope_start_in_tikzscope1247);
            	tikzscope_start105 = tikzscope_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzscope_start.Add(tikzscope_start105.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:267:20: ( tikz_options )?
            	int alt28 = 2;
            	int LA28_0 = input.LA(1);

            	if ( (LA28_0 == 50) )
            	{
            	    alt28 = 1;
            	}
            	switch (alt28) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:267:20: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_tikzscope1249);
            	        	tikz_options106 = tikz_options();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_tikz_options.Add(tikz_options106.Tree);

            	        }
            	        break;

            	}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:267:34: ( tikzbody )?
            	int alt29 = 2;
            	int LA29_0 = input.LA(1);

            	if ( ((LA29_0 >= IM_PATH && LA29_0 <= 49) || (LA29_0 >= 51 && LA29_0 <= 58) || (LA29_0 >= 60 && LA29_0 <= 83)) )
            	{
            	    alt29 = 1;
            	}
            	else if ( (LA29_0 == 59) )
            	{
            	    int LA29_2 = input.LA(2);

            	    if ( (LA29_2 == 40) )
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
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:267:34: tikzbody
            	        {
            	        	PushFollow(FOLLOW_tikzbody_in_tikzscope1252);
            	        	tikzbody107 = tikzbody();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_tikzbody.Add(tikzbody107.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzscope_end_in_tikzscope1255);
            	tikzscope_end108 = tikzscope_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzscope_end.Add(tikzscope_end108.Tree);


            	// AST REWRITE
            	// elements:          tikzbody, tikz_options, tikzscope_end, tikzscope_start
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 267:59: -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:267:62: ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_SCOPE, "IM_SCOPE"), root_1);

            	    adaptor.AddChild(root_1, stream_tikzscope_start.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:267:89: ( tikz_options )?
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:293:1: tikzpath : ( path_start ( tikzpath_element )* semicolon_end -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end ) | path_start 'let' ( let_assignment )* 'in' ( tikzpath_element )* semicolon_end -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end ) );
    public simpletikzParser.tikzpath_return tikzpath() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_return retval = new simpletikzParser.tikzpath_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal113 = null;
        IToken string_literal115 = null;
        simpletikzParser.path_start_return path_start109 = default(simpletikzParser.path_start_return);

        simpletikzParser.tikzpath_element_return tikzpath_element110 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end111 = default(simpletikzParser.semicolon_end_return);

        simpletikzParser.path_start_return path_start112 = default(simpletikzParser.path_start_return);

        simpletikzParser.let_assignment_return let_assignment114 = default(simpletikzParser.let_assignment_return);

        simpletikzParser.tikzpath_element_return tikzpath_element116 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end117 = default(simpletikzParser.semicolon_end_return);


        object string_literal113_tree=null;
        object string_literal115_tree=null;
        RewriteRuleTokenStream stream_66 = new RewriteRuleTokenStream(adaptor,"token 66");
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_path_start = new RewriteRuleSubtreeStream(adaptor,"rule path_start");
        RewriteRuleSubtreeStream stream_let_assignment = new RewriteRuleSubtreeStream(adaptor,"rule let_assignment");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:294:2: ( path_start ( tikzpath_element )* semicolon_end -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end ) | path_start 'let' ( let_assignment )* 'in' ( tikzpath_element )* semicolon_end -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end ) )
            int alt33 = 2;
            int LA33_0 = input.LA(1);

            if ( ((LA33_0 >= 62 && LA33_0 <= 65)) )
            {
                int LA33_1 = input.LA(2);

                if ( (LA33_1 == 66) )
                {
                    alt33 = 2;
                }
                else if ( (LA33_1 == ID || LA33_1 == 40 || LA33_1 == 48 || LA33_1 == 50 || LA33_1 == 52 || (LA33_1 >= 68 && LA33_1 <= 69) || (LA33_1 >= 71 && LA33_1 <= 80)) )
                {
                    alt33 = 1;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d33s1 =
                        new NoViableAltException("", 33, 1, input);

                    throw nvae_d33s1;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d33s0 =
                    new NoViableAltException("", 33, 0, input);

                throw nvae_d33s0;
            }
            switch (alt33) 
            {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:294:4: path_start ( tikzpath_element )* semicolon_end
                    {
                    	PushFollow(FOLLOW_path_start_in_tikzpath1310);
                    	path_start109 = path_start();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_path_start.Add(path_start109.Tree);
                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:294:15: ( tikzpath_element )*
                    	do 
                    	{
                    	    int alt30 = 2;
                    	    int LA30_0 = input.LA(1);

                    	    if ( (LA30_0 == ID || LA30_0 == 40 || LA30_0 == 48 || LA30_0 == 50 || (LA30_0 >= 68 && LA30_0 <= 69) || (LA30_0 >= 71 && LA30_0 <= 80)) )
                    	    {
                    	        alt30 = 1;
                    	    }


                    	    switch (alt30) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:294:15: tikzpath_element
                    			    {
                    			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath1312);
                    			    	tikzpath_element110 = tikzpath_element();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element110.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop30;
                    	    }
                    	} while (true);

                    	loop30:
                    		;	// Stops C# compiler whining that label 'loop30' has no statements

                    	PushFollow(FOLLOW_semicolon_end_in_tikzpath1315);
                    	semicolon_end111 = semicolon_end();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_semicolon_end.Add(semicolon_end111.Tree);


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
                    	// 294:47: -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end )
                    	{
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:294:50: ^( IM_PATH path_start ( tikzpath_element )* semicolon_end )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

                    	    adaptor.AddChild(root_1, stream_path_start.NextTree());
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:294:71: ( tikzpath_element )*
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
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:295:4: path_start 'let' ( let_assignment )* 'in' ( tikzpath_element )* semicolon_end
                    {
                    	PushFollow(FOLLOW_path_start_in_tikzpath1334);
                    	path_start112 = path_start();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_path_start.Add(path_start112.Tree);
                    	string_literal113=(IToken)Match(input,66,FOLLOW_66_in_tikzpath1336); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_66.Add(string_literal113);

                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:295:21: ( let_assignment )*
                    	do 
                    	{
                    	    int alt31 = 2;
                    	    int LA31_0 = input.LA(1);

                    	    if ( (LA31_0 == COMMAND) )
                    	    {
                    	        alt31 = 1;
                    	    }


                    	    switch (alt31) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:295:21: let_assignment
                    			    {
                    			    	PushFollow(FOLLOW_let_assignment_in_tikzpath1338);
                    			    	let_assignment114 = let_assignment();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_let_assignment.Add(let_assignment114.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop31;
                    	    }
                    	} while (true);

                    	loop31:
                    		;	// Stops C# compiler whining that label 'loop31' has no statements

                    	string_literal115=(IToken)Match(input,54,FOLLOW_54_in_tikzpath1341); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_54.Add(string_literal115);

                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:295:42: ( tikzpath_element )*
                    	do 
                    	{
                    	    int alt32 = 2;
                    	    int LA32_0 = input.LA(1);

                    	    if ( (LA32_0 == ID || LA32_0 == 40 || LA32_0 == 48 || LA32_0 == 50 || (LA32_0 >= 68 && LA32_0 <= 69) || (LA32_0 >= 71 && LA32_0 <= 80)) )
                    	    {
                    	        alt32 = 1;
                    	    }


                    	    switch (alt32) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:295:42: tikzpath_element
                    			    {
                    			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath1343);
                    			    	tikzpath_element116 = tikzpath_element();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element116.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop32;
                    	    }
                    	} while (true);

                    	loop32:
                    		;	// Stops C# compiler whining that label 'loop32' has no statements

                    	PushFollow(FOLLOW_semicolon_end_in_tikzpath1346);
                    	semicolon_end117 = semicolon_end();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_semicolon_end.Add(semicolon_end117.Tree);


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
                    	// 295:74: -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end )
                    	{
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:295:77: ^( IM_PATH path_start ( tikzpath_element )* semicolon_end )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

                    	    adaptor.AddChild(root_1, stream_path_start.NextTree());
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:295:98: ( tikzpath_element )*
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:298:1: let_assignment : COMMAND '=' ( tikzpath_element )* ;
    public simpletikzParser.let_assignment_return let_assignment() // throws RecognitionException [1]
    {   
        simpletikzParser.let_assignment_return retval = new simpletikzParser.let_assignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken COMMAND118 = null;
        IToken char_literal119 = null;
        simpletikzParser.tikzpath_element_return tikzpath_element120 = default(simpletikzParser.tikzpath_element_return);


        object COMMAND118_tree=null;
        object char_literal119_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:299:2: ( COMMAND '=' ( tikzpath_element )* )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:299:4: COMMAND '=' ( tikzpath_element )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	COMMAND118=(IToken)Match(input,COMMAND,FOLLOW_COMMAND_in_let_assignment1372); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{COMMAND118_tree = (object)adaptor.Create(COMMAND118);
            		adaptor.AddChild(root_0, COMMAND118_tree);
            	}
            	char_literal119=(IToken)Match(input,42,FOLLOW_42_in_let_assignment1374); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal119_tree = (object)adaptor.Create(char_literal119);
            		adaptor.AddChild(root_0, char_literal119_tree);
            	}
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:299:16: ( tikzpath_element )*
            	do 
            	{
            	    int alt34 = 2;
            	    int LA34_0 = input.LA(1);

            	    if ( (LA34_0 == ID || LA34_0 == 40 || LA34_0 == 48 || LA34_0 == 50 || (LA34_0 >= 68 && LA34_0 <= 69) || (LA34_0 >= 71 && LA34_0 <= 80)) )
            	    {
            	        alt34 = 1;
            	    }


            	    switch (alt34) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:299:16: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_let_assignment1376);
            			    	tikzpath_element120 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath_element120.Tree);

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

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:302:1: tikzpath_element : ( tikz_options | coord | controls | tikznode_int | tikzcoordinate_int | circle | arc | roundbr_start ( tikzpath_element )* roundbr_end -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end ) | edgeop );
    public simpletikzParser.tikzpath_element_return tikzpath_element() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_element_return retval = new simpletikzParser.tikzpath_element_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikz_options_return tikz_options121 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.coord_return coord122 = default(simpletikzParser.coord_return);

        simpletikzParser.controls_return controls123 = default(simpletikzParser.controls_return);

        simpletikzParser.tikznode_int_return tikznode_int124 = default(simpletikzParser.tikznode_int_return);

        simpletikzParser.tikzcoordinate_int_return tikzcoordinate_int125 = default(simpletikzParser.tikzcoordinate_int_return);

        simpletikzParser.circle_return circle126 = default(simpletikzParser.circle_return);

        simpletikzParser.arc_return arc127 = default(simpletikzParser.arc_return);

        simpletikzParser.roundbr_start_return roundbr_start128 = default(simpletikzParser.roundbr_start_return);

        simpletikzParser.tikzpath_element_return tikzpath_element129 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.roundbr_end_return roundbr_end130 = default(simpletikzParser.roundbr_end_return);

        simpletikzParser.edgeop_return edgeop131 = default(simpletikzParser.edgeop_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_roundbr_start = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_start");
        RewriteRuleSubtreeStream stream_roundbr_end = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:303:2: ( tikz_options | coord | controls | tikznode_int | tikzcoordinate_int | circle | arc | roundbr_start ( tikzpath_element )* roundbr_end -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end ) | edgeop )
            int alt36 = 9;
            switch ( input.LA(1) ) 
            {
            case 50:
            	{
                alt36 = 1;
                }
                break;
            case 48:
            case 78:
            case 79:
            	{
                alt36 = 2;
                }
                break;
            case 80:
            	{
                alt36 = 3;
                }
                break;
            case 69:
            	{
                alt36 = 4;
                }
                break;
            case 68:
            	{
                alt36 = 5;
                }
                break;
            case 71:
            case 72:
            	{
                alt36 = 6;
                }
                break;
            case 73:
            	{
                alt36 = 7;
                }
                break;
            case 40:
            	{
                alt36 = 8;
                }
                break;
            case ID:
            case 74:
            case 75:
            case 76:
            case 77:
            	{
                alt36 = 9;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d36s0 =
            	        new NoViableAltException("", 36, 0, input);

            	    throw nvae_d36s0;
            }

            switch (alt36) 
            {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:304:5: tikz_options
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_options_in_tikzpath_element1392);
                    	tikz_options121 = tikz_options();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_options121.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:305:5: coord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_coord_in_tikzpath_element1399);
                    	coord122 = coord();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, coord122.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:306:5: controls
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_controls_in_tikzpath_element1405);
                    	controls123 = controls();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, controls123.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:307:5: tikznode_int
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikznode_int_in_tikzpath_element1411);
                    	tikznode_int124 = tikznode_int();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_int124.Tree);

                    }
                    break;
                case 5 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:308:5: tikzcoordinate_int
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikzcoordinate_int_in_tikzpath_element1417);
                    	tikzcoordinate_int125 = tikzcoordinate_int();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_int125.Tree);

                    }
                    break;
                case 6 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:309:5: circle
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_circle_in_tikzpath_element1423);
                    	circle126 = circle();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;

                    }
                    break;
                case 7 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:310:5: arc
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arc_in_tikzpath_element1430);
                    	arc127 = arc();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;

                    }
                    break;
                case 8 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:311:5: roundbr_start ( tikzpath_element )* roundbr_end
                    {
                    	PushFollow(FOLLOW_roundbr_start_in_tikzpath_element1437);
                    	roundbr_start128 = roundbr_start();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_roundbr_start.Add(roundbr_start128.Tree);
                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:311:19: ( tikzpath_element )*
                    	do 
                    	{
                    	    int alt35 = 2;
                    	    int LA35_0 = input.LA(1);

                    	    if ( (LA35_0 == ID || LA35_0 == 40 || LA35_0 == 48 || LA35_0 == 50 || (LA35_0 >= 68 && LA35_0 <= 69) || (LA35_0 >= 71 && LA35_0 <= 80)) )
                    	    {
                    	        alt35 = 1;
                    	    }


                    	    switch (alt35) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:311:19: tikzpath_element
                    			    {
                    			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath_element1439);
                    			    	tikzpath_element129 = tikzpath_element();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element129.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop35;
                    	    }
                    	} while (true);

                    	loop35:
                    		;	// Stops C# compiler whining that label 'loop35' has no statements

                    	PushFollow(FOLLOW_roundbr_end_in_tikzpath_element1442);
                    	roundbr_end130 = roundbr_end();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_roundbr_end.Add(roundbr_end130.Tree);


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
                    	// 311:49: -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end )
                    	{
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:311:52: ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

                    	    adaptor.AddChild(root_1, stream_roundbr_start.NextTree());
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:311:76: ( tikzpath_element )*
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
                case 9 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:312:5: edgeop
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_edgeop_in_tikzpath_element1461);
                    	edgeop131 = edgeop();
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:315:1: controls : controls_start coord ( 'and' coord )? controls_end -> ^( IM_CONTROLS controls_start ( coord )+ controls_end ) ;
    public simpletikzParser.controls_return controls() // throws RecognitionException [1]
    {   
        simpletikzParser.controls_return retval = new simpletikzParser.controls_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal134 = null;
        simpletikzParser.controls_start_return controls_start132 = default(simpletikzParser.controls_start_return);

        simpletikzParser.coord_return coord133 = default(simpletikzParser.coord_return);

        simpletikzParser.coord_return coord135 = default(simpletikzParser.coord_return);

        simpletikzParser.controls_end_return controls_end136 = default(simpletikzParser.controls_end_return);


        object string_literal134_tree=null;
        RewriteRuleTokenStream stream_67 = new RewriteRuleTokenStream(adaptor,"token 67");
        RewriteRuleSubtreeStream stream_coord = new RewriteRuleSubtreeStream(adaptor,"rule coord");
        RewriteRuleSubtreeStream stream_controls_start = new RewriteRuleSubtreeStream(adaptor,"rule controls_start");
        RewriteRuleSubtreeStream stream_controls_end = new RewriteRuleSubtreeStream(adaptor,"rule controls_end");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:316:2: ( controls_start coord ( 'and' coord )? controls_end -> ^( IM_CONTROLS controls_start ( coord )+ controls_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:316:4: controls_start coord ( 'and' coord )? controls_end
            {
            	PushFollow(FOLLOW_controls_start_in_controls1476);
            	controls_start132 = controls_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_controls_start.Add(controls_start132.Tree);
            	PushFollow(FOLLOW_coord_in_controls1478);
            	coord133 = coord();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_coord.Add(coord133.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:316:25: ( 'and' coord )?
            	int alt37 = 2;
            	int LA37_0 = input.LA(1);

            	if ( (LA37_0 == 67) )
            	{
            	    alt37 = 1;
            	}
            	switch (alt37) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:316:26: 'and' coord
            	        {
            	        	string_literal134=(IToken)Match(input,67,FOLLOW_67_in_controls1481); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_67.Add(string_literal134);

            	        	PushFollow(FOLLOW_coord_in_controls1483);
            	        	coord135 = coord();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_coord.Add(coord135.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_controls_end_in_controls1487);
            	controls_end136 = controls_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_controls_end.Add(controls_end136.Tree);


            	// AST REWRITE
            	// elements:          controls_end, coord, controls_start
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 316:53: -> ^( IM_CONTROLS controls_start ( coord )+ controls_end )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:316:56: ^( IM_CONTROLS controls_start ( coord )+ controls_end )
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:319:1: tikznode_ext : node_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikznode_ext_return tikznode_ext() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_ext_return retval = new simpletikzParser.tikznode_ext_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.node_start_return node_start137 = default(simpletikzParser.node_start_return);

        simpletikzParser.tikznode_core_return tikznode_core138 = default(simpletikzParser.tikznode_core_return);

        simpletikzParser.tikzpath_element_return tikzpath_element139 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end140 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_node_start = new RewriteRuleSubtreeStream(adaptor,"rule node_start");
        RewriteRuleSubtreeStream stream_tikznode_core = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_core");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:320:2: ( node_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:320:4: node_start tikznode_core ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_node_start_in_tikznode_ext1513);
            	node_start137 = node_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_node_start.Add(node_start137.Tree);
            	PushFollow(FOLLOW_tikznode_core_in_tikznode_ext1515);
            	tikznode_core138 = tikznode_core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_core.Add(tikznode_core138.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:320:29: ( tikzpath_element )*
            	do 
            	{
            	    int alt38 = 2;
            	    int LA38_0 = input.LA(1);

            	    if ( (LA38_0 == ID || LA38_0 == 40 || LA38_0 == 48 || LA38_0 == 50 || (LA38_0 >= 68 && LA38_0 <= 69) || (LA38_0 >= 71 && LA38_0 <= 80)) )
            	    {
            	        alt38 = 1;
            	    }


            	    switch (alt38) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:320:29: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikznode_ext1517);
            			    	tikzpath_element139 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element139.Tree);

            			    }
            			    break;

            			default:
            			    goto loop38;
            	    }
            	} while (true);

            	loop38:
            		;	// Stops C# compiler whining that label 'loop38' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikznode_ext1520);
            	semicolon_end140 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_semicolon_end.Add(semicolon_end140.Tree);


            	// AST REWRITE
            	// elements:          semicolon_end, tikzpath_element, node_start, tikznode_core
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 320:61: -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:320:64: ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_node_start.NextTree());
            	    adaptor.AddChild(root_1, stream_tikznode_core.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:320:99: ( tikzpath_element )*
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:324:1: tikzcoordinate_ext : coordinate_start ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ( tikzpath_element )* semicolon_end -> ^( IM_PATH coordinate_start ( tikzcoordinate_core3 )? ( tikzcoordinate_core2 )? ( tikzcoordinate_core1 )? ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_ext_return retval = new simpletikzParser.tikzcoordinate_ext_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.coordinate_start_return coordinate_start141 = default(simpletikzParser.coordinate_start_return);

        simpletikzParser.tikzcoordinate_core3_return tikzcoordinate_core3142 = default(simpletikzParser.tikzcoordinate_core3_return);

        simpletikzParser.tikzcoordinate_core2_return tikzcoordinate_core2143 = default(simpletikzParser.tikzcoordinate_core2_return);

        simpletikzParser.tikzcoordinate_core1_return tikzcoordinate_core1144 = default(simpletikzParser.tikzcoordinate_core1_return);

        simpletikzParser.tikzpath_element_return tikzpath_element145 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end146 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_tikzcoordinate_core3 = new RewriteRuleSubtreeStream(adaptor,"rule tikzcoordinate_core3");
        RewriteRuleSubtreeStream stream_tikzcoordinate_core2 = new RewriteRuleSubtreeStream(adaptor,"rule tikzcoordinate_core2");
        RewriteRuleSubtreeStream stream_coordinate_start = new RewriteRuleSubtreeStream(adaptor,"rule coordinate_start");
        RewriteRuleSubtreeStream stream_tikzcoordinate_core1 = new RewriteRuleSubtreeStream(adaptor,"rule tikzcoordinate_core1");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:325:2: ( coordinate_start ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ( tikzpath_element )* semicolon_end -> ^( IM_PATH coordinate_start ( tikzcoordinate_core3 )? ( tikzcoordinate_core2 )? ( tikzcoordinate_core1 )? ( tikzpath_element )* semicolon_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:325:4: coordinate_start ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_coordinate_start_in_tikzcoordinate_ext1548);
            	coordinate_start141 = coordinate_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_coordinate_start.Add(coordinate_start141.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:326:5: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?
            	int alt39 = 4;
            	alt39 = dfa39.Predict(input);
            	switch (alt39) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:326:7: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        {
            	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:326:7: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:326:8: ( tikzcoordinate_core3 )=> tikzcoordinate_core3
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_ext1563);
            	        		tikzcoordinate_core3142 = tikzcoordinate_core3();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( (state.backtracking==0) ) stream_tikzcoordinate_core3.Add(tikzcoordinate_core3142.Tree);

            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:327:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        {
            	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:327:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:327:12: ( tikzcoordinate_core2 )=> tikzcoordinate_core2
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_ext1582);
            	        		tikzcoordinate_core2143 = tikzcoordinate_core2();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( (state.backtracking==0) ) stream_tikzcoordinate_core2.Add(tikzcoordinate_core2143.Tree);

            	        	}


            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:328:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        {
            	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:328:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:328:12: ( tikzcoordinate_core1 )=> tikzcoordinate_core1
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_ext1602);
            	        		tikzcoordinate_core1144 = tikzcoordinate_core1();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( (state.backtracking==0) ) stream_tikzcoordinate_core1.Add(tikzcoordinate_core1144.Tree);

            	        	}


            	        }
            	        break;

            	}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:329:6: ( tikzpath_element )*
            	do 
            	{
            	    int alt40 = 2;
            	    int LA40_0 = input.LA(1);

            	    if ( (LA40_0 == ID || LA40_0 == 40 || LA40_0 == 48 || LA40_0 == 50 || (LA40_0 >= 68 && LA40_0 <= 69) || (LA40_0 >= 71 && LA40_0 <= 80)) )
            	    {
            	        alt40 = 1;
            	    }


            	    switch (alt40) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:329:6: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikzcoordinate_ext1613);
            			    	tikzpath_element145 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element145.Tree);

            			    }
            			    break;

            			default:
            			    goto loop40;
            	    }
            	} while (true);

            	loop40:
            		;	// Stops C# compiler whining that label 'loop40' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikzcoordinate_ext1616);
            	semicolon_end146 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_semicolon_end.Add(semicolon_end146.Tree);


            	// AST REWRITE
            	// elements:          coordinate_start, tikzcoordinate_core3, semicolon_end, tikzpath_element, tikzcoordinate_core1, tikzcoordinate_core2
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 330:6: -> ^( IM_PATH coordinate_start ( tikzcoordinate_core3 )? ( tikzcoordinate_core2 )? ( tikzcoordinate_core1 )? ( tikzpath_element )* semicolon_end )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:330:9: ^( IM_PATH coordinate_start ( tikzcoordinate_core3 )? ( tikzcoordinate_core2 )? ( tikzcoordinate_core1 )? ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_coordinate_start.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:331:6: ( tikzcoordinate_core3 )?
            	    if ( stream_tikzcoordinate_core3.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzcoordinate_core3.NextTree());

            	    }
            	    stream_tikzcoordinate_core3.Reset();
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:332:6: ( tikzcoordinate_core2 )?
            	    if ( stream_tikzcoordinate_core2.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzcoordinate_core2.NextTree());

            	    }
            	    stream_tikzcoordinate_core2.Reset();
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:333:6: ( tikzcoordinate_core1 )?
            	    if ( stream_tikzcoordinate_core1.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzcoordinate_core1.NextTree());

            	    }
            	    stream_tikzcoordinate_core1.Reset();
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:334:6: ( tikzpath_element )*
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:336:1: tikzcoordinate_int : 'coordinate' ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ;
    public simpletikzParser.tikzcoordinate_int_return tikzcoordinate_int() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_int_return retval = new simpletikzParser.tikzcoordinate_int_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal147 = null;
        simpletikzParser.tikzcoordinate_core3_return tikzcoordinate_core3148 = default(simpletikzParser.tikzcoordinate_core3_return);

        simpletikzParser.tikzcoordinate_core2_return tikzcoordinate_core2149 = default(simpletikzParser.tikzcoordinate_core2_return);

        simpletikzParser.tikzcoordinate_core1_return tikzcoordinate_core1150 = default(simpletikzParser.tikzcoordinate_core1_return);


        object string_literal147_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:337:2: ( 'coordinate' ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:337:4: 'coordinate' ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal147=(IToken)Match(input,68,FOLLOW_68_in_tikzcoordinate_int1676); if (state.failed) return retval;
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:337:18: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?
            	int alt41 = 4;
            	alt41 = dfa41.Predict(input);
            	switch (alt41) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:337:20: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        {
            	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:337:20: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:337:21: ( tikzcoordinate_core3 )=> tikzcoordinate_core3
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_int1687);
            	        		tikzcoordinate_core3148 = tikzcoordinate_core3();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_core3148.Tree);

            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:338:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        {
            	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:338:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:338:12: ( tikzcoordinate_core2 )=> tikzcoordinate_core2
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_int1706);
            	        		tikzcoordinate_core2149 = tikzcoordinate_core2();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_core2149.Tree);

            	        	}


            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:339:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        {
            	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:339:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:339:12: ( tikzcoordinate_core1 )=> tikzcoordinate_core1
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_int1726);
            	        		tikzcoordinate_core1150 = tikzcoordinate_core1();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_core1150.Tree);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:341:1: tikznode_int : 'node' tikznode_core ;
    public simpletikzParser.tikznode_int_return tikznode_int() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_int_return retval = new simpletikzParser.tikznode_int_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal151 = null;
        simpletikzParser.tikznode_core_return tikznode_core152 = default(simpletikzParser.tikznode_core_return);


        object string_literal151_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:342:2: ( 'node' tikznode_core )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:342:4: 'node' tikznode_core
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal151=(IToken)Match(input,69,FOLLOW_69_in_tikznode_int1742); if (state.failed) return retval;
            	PushFollow(FOLLOW_tikznode_core_in_tikznode_int1745);
            	tikznode_core152 = tikznode_core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_core152.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:344:1: tikznode_core : ( tikznode_decorator )* tikzstring -> ^( IM_NODE ( tikznode_decorator )* tikzstring ) ;
    public simpletikzParser.tikznode_core_return tikznode_core() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_core_return retval = new simpletikzParser.tikznode_core_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator153 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikzstring_return tikzstring154 = default(simpletikzParser.tikzstring_return);


        RewriteRuleSubtreeStream stream_tikzstring = new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:345:2: ( ( tikznode_decorator )* tikzstring -> ^( IM_NODE ( tikznode_decorator )* tikzstring ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:345:4: ( tikznode_decorator )* tikzstring
            {
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:345:4: ( tikznode_decorator )*
            	do 
            	{
            	    int alt42 = 2;
            	    int LA42_0 = input.LA(1);

            	    if ( (LA42_0 == 48 || LA42_0 == 50 || LA42_0 == 70) )
            	    {
            	        alt42 = 1;
            	    }


            	    switch (alt42) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:345:4: tikznode_decorator
            			    {
            			    	PushFollow(FOLLOW_tikznode_decorator_in_tikznode_core1755);
            			    	tikznode_decorator153 = tikznode_decorator();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator153.Tree);

            			    }
            			    break;

            			default:
            			    goto loop42;
            	    }
            	} while (true);

            	loop42:
            		;	// Stops C# compiler whining that label 'loop42' has no statements

            	PushFollow(FOLLOW_tikzstring_in_tikznode_core1758);
            	tikzstring154 = tikzstring();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzstring.Add(tikzstring154.Tree);


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
            	// 345:36: -> ^( IM_NODE ( tikznode_decorator )* tikzstring )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:345:39: ^( IM_NODE ( tikznode_decorator )* tikzstring )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NODE, "IM_NODE"), root_1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:345:49: ( tikznode_decorator )*
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:348:1: tikzcoordinate_core3 : tikznode_decorator tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator ) ;
    public simpletikzParser.tikzcoordinate_core3_return tikzcoordinate_core3() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_core3_return retval = new simpletikzParser.tikzcoordinate_core3_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator155 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikznode_decorator_return tikznode_decorator156 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikznode_decorator_return tikznode_decorator157 = default(simpletikzParser.tikznode_decorator_return);


        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:349:2: ( tikznode_decorator tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:349:6: tikznode_decorator tikznode_decorator tikznode_decorator
            {
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core31783);
            	tikznode_decorator155 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator155.Tree);
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core31785);
            	tikznode_decorator156 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator156.Tree);
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core31787);
            	tikznode_decorator157 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator157.Tree);


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
            	// 349:64: -> ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:349:67: ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator )
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:353:1: tikzcoordinate_core2 : tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator ) ;
    public simpletikzParser.tikzcoordinate_core2_return tikzcoordinate_core2() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_core2_return retval = new simpletikzParser.tikzcoordinate_core2_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator158 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikznode_decorator_return tikznode_decorator159 = default(simpletikzParser.tikznode_decorator_return);


        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:354:2: ( tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:355:4: tikznode_decorator tikznode_decorator
            {
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core21821);
            	tikznode_decorator158 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator158.Tree);
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core21823);
            	tikznode_decorator159 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator159.Tree);


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
            	// 355:47: -> ^( IM_NODE tikznode_decorator tikznode_decorator )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:355:50: ^( IM_NODE tikznode_decorator tikznode_decorator )
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:358:1: tikzcoordinate_core1 : tikznode_decorator -> ^( IM_NODE tikznode_decorator ) ;
    public simpletikzParser.tikzcoordinate_core1_return tikzcoordinate_core1() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_core1_return retval = new simpletikzParser.tikzcoordinate_core1_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator160 = default(simpletikzParser.tikznode_decorator_return);


        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:359:2: ( tikznode_decorator -> ^( IM_NODE tikznode_decorator ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:360:4: tikznode_decorator
            {
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core11856);
            	tikznode_decorator160 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator160.Tree);


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
            	// 360:31: -> ^( IM_NODE tikznode_decorator )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:360:34: ^( IM_NODE tikznode_decorator )
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:367:1: tikznode_decorator : ( nodename | 'at' coord | tikz_options_dontcare );
    public simpletikzParser.tikznode_decorator_return tikznode_decorator() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_decorator_return retval = new simpletikzParser.tikznode_decorator_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal162 = null;
        simpletikzParser.nodename_return nodename161 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_return coord163 = default(simpletikzParser.coord_return);

        simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare164 = default(simpletikzParser.tikz_options_dontcare_return);


        object string_literal162_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:368:2: ( nodename | 'at' coord | tikz_options_dontcare )
            int alt43 = 3;
            switch ( input.LA(1) ) 
            {
            case 48:
            	{
                alt43 = 1;
                }
                break;
            case 70:
            	{
                alt43 = 2;
                }
                break;
            case 50:
            	{
                alt43 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d43s0 =
            	        new NoViableAltException("", 43, 0, input);

            	    throw nvae_d43s0;
            }

            switch (alt43) 
            {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:368:6: nodename
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_nodename_in_tikznode_decorator1893);
                    	nodename161 = nodename();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, nodename161.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:369:5: 'at' coord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal162=(IToken)Match(input,70,FOLLOW_70_in_tikznode_decorator1900); if (state.failed) return retval;
                    	PushFollow(FOLLOW_coord_in_tikznode_decorator1903);
                    	coord163 = coord();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, coord163.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:370:5: tikz_options_dontcare
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_options_dontcare_in_tikznode_decorator1909);
                    	tikz_options_dontcare164 = tikz_options_dontcare();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_options_dontcare164.Tree);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:372:1: tikz_options_dontcare : '[' ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* ']' -> ^( IM_OPTIONS ) ;
    public simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_options_dontcare_return retval = new simpletikzParser.tikz_options_dontcare_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal165 = null;
        IToken char_literal169 = null;
        simpletikzParser.no_rlbracket_return no_rlbracket166 = default(simpletikzParser.no_rlbracket_return);

        simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare167 = default(simpletikzParser.tikz_options_dontcare_return);

        simpletikzParser.no_rlbracket_return no_rlbracket168 = default(simpletikzParser.no_rlbracket_return);


        object char_literal165_tree=null;
        object char_literal169_tree=null;
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_tikz_options_dontcare = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options_dontcare");
        RewriteRuleSubtreeStream stream_no_rlbracket = new RewriteRuleSubtreeStream(adaptor,"rule no_rlbracket");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:373:2: ( '[' ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* ']' -> ^( IM_OPTIONS ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:373:4: '[' ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* ']'
            {
            	char_literal165=(IToken)Match(input,50,FOLLOW_50_in_tikz_options_dontcare1919); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_50.Add(char_literal165);

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:373:8: ( no_rlbracket )*
            	do 
            	{
            	    int alt44 = 2;
            	    int LA44_0 = input.LA(1);

            	    if ( ((LA44_0 >= IM_PATH && LA44_0 <= 49) || (LA44_0 >= 52 && LA44_0 <= 83)) )
            	    {
            	        alt44 = 1;
            	    }


            	    switch (alt44) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:373:8: no_rlbracket
            			    {
            			    	PushFollow(FOLLOW_no_rlbracket_in_tikz_options_dontcare1921);
            			    	no_rlbracket166 = no_rlbracket();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_no_rlbracket.Add(no_rlbracket166.Tree);

            			    }
            			    break;

            			default:
            			    goto loop44;
            	    }
            	} while (true);

            	loop44:
            		;	// Stops C# compiler whining that label 'loop44' has no statements

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:373:22: ( tikz_options_dontcare ( no_rlbracket )* )*
            	do 
            	{
            	    int alt46 = 2;
            	    int LA46_0 = input.LA(1);

            	    if ( (LA46_0 == 50) )
            	    {
            	        alt46 = 1;
            	    }


            	    switch (alt46) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:373:23: tikz_options_dontcare ( no_rlbracket )*
            			    {
            			    	PushFollow(FOLLOW_tikz_options_dontcare_in_tikz_options_dontcare1925);
            			    	tikz_options_dontcare167 = tikz_options_dontcare();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikz_options_dontcare.Add(tikz_options_dontcare167.Tree);
            			    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:373:45: ( no_rlbracket )*
            			    	do 
            			    	{
            			    	    int alt45 = 2;
            			    	    int LA45_0 = input.LA(1);

            			    	    if ( ((LA45_0 >= IM_PATH && LA45_0 <= 49) || (LA45_0 >= 52 && LA45_0 <= 83)) )
            			    	    {
            			    	        alt45 = 1;
            			    	    }


            			    	    switch (alt45) 
            			    		{
            			    			case 1 :
            			    			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:373:45: no_rlbracket
            			    			    {
            			    			    	PushFollow(FOLLOW_no_rlbracket_in_tikz_options_dontcare1927);
            			    			    	no_rlbracket168 = no_rlbracket();
            			    			    	state.followingStackPointer--;
            			    			    	if (state.failed) return retval;
            			    			    	if ( (state.backtracking==0) ) stream_no_rlbracket.Add(no_rlbracket168.Tree);

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop45;
            			    	    }
            			    	} while (true);

            			    	loop45:
            			    		;	// Stops C# compiler whining that label 'loop45' has no statements


            			    }
            			    break;

            			default:
            			    goto loop46;
            	    }
            	} while (true);

            	loop46:
            		;	// Stops C# compiler whining that label 'loop46' has no statements

            	char_literal169=(IToken)Match(input,51,FOLLOW_51_in_tikz_options_dontcare1932); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_51.Add(char_literal169);



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
            	// 373:65: -> ^( IM_OPTIONS )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:373:68: ^( IM_OPTIONS )
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:375:1: no_rlbracket : ~ ( '[' | ']' ) ;
    public simpletikzParser.no_rlbracket_return no_rlbracket() // throws RecognitionException [1]
    {   
        simpletikzParser.no_rlbracket_return retval = new simpletikzParser.no_rlbracket_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set170 = null;

        object set170_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:376:2: (~ ( '[' | ']' ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:376:4: ~ ( '[' | ']' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set170 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= 49) || (input.LA(1) >= 52 && input.LA(1) <= 83) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set170));
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:378:1: nodename : '(' idd ')' -> ^( IM_NODENAME idd ) ;
    public simpletikzParser.nodename_return nodename() // throws RecognitionException [1]
    {   
        simpletikzParser.nodename_return retval = new simpletikzParser.nodename_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal171 = null;
        IToken char_literal173 = null;
        simpletikzParser.idd_return idd172 = default(simpletikzParser.idd_return);


        object char_literal171_tree=null;
        object char_literal173_tree=null;
        RewriteRuleTokenStream stream_49 = new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_48 = new RewriteRuleTokenStream(adaptor,"token 48");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:379:2: ( '(' idd ')' -> ^( IM_NODENAME idd ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:379:4: '(' idd ')'
            {
            	char_literal171=(IToken)Match(input,48,FOLLOW_48_in_nodename1967); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_48.Add(char_literal171);

            	PushFollow(FOLLOW_idd_in_nodename1969);
            	idd172 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idd.Add(idd172.Tree);
            	char_literal173=(IToken)Match(input,49,FOLLOW_49_in_nodename1971); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_49.Add(char_literal173);



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
            	// 379:17: -> ^( IM_NODENAME idd )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:379:20: ^( IM_NODENAME idd )
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:385:1: circle : ( 'circle' | 'ellipse' ) ( ( size )=> size )? ->;
    public simpletikzParser.circle_return circle() // throws RecognitionException [1]
    {   
        simpletikzParser.circle_return retval = new simpletikzParser.circle_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal174 = null;
        IToken string_literal175 = null;
        simpletikzParser.size_return size176 = default(simpletikzParser.size_return);


        object string_literal174_tree=null;
        object string_literal175_tree=null;
        RewriteRuleTokenStream stream_71 = new RewriteRuleTokenStream(adaptor,"token 71");
        RewriteRuleTokenStream stream_72 = new RewriteRuleTokenStream(adaptor,"token 72");
        RewriteRuleSubtreeStream stream_size = new RewriteRuleSubtreeStream(adaptor,"rule size");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:386:2: ( ( 'circle' | 'ellipse' ) ( ( size )=> size )? ->)
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:386:4: ( 'circle' | 'ellipse' ) ( ( size )=> size )?
            {
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:386:4: ( 'circle' | 'ellipse' )
            	int alt47 = 2;
            	int LA47_0 = input.LA(1);

            	if ( (LA47_0 == 71) )
            	{
            	    alt47 = 1;
            	}
            	else if ( (LA47_0 == 72) )
            	{
            	    alt47 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d47s0 =
            	        new NoViableAltException("", 47, 0, input);

            	    throw nvae_d47s0;
            	}
            	switch (alt47) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:386:5: 'circle'
            	        {
            	        	string_literal174=(IToken)Match(input,71,FOLLOW_71_in_circle1995); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_71.Add(string_literal174);


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:386:16: 'ellipse'
            	        {
            	        	string_literal175=(IToken)Match(input,72,FOLLOW_72_in_circle1999); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_72.Add(string_literal175);


            	        }
            	        break;

            	}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:386:27: ( ( size )=> size )?
            	int alt48 = 2;
            	alt48 = dfa48.Predict(input);
            	switch (alt48) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:386:28: ( size )=> size
            	        {
            	        	PushFollow(FOLLOW_size_in_circle2008);
            	        	size176 = size();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_size.Add(size176.Tree);

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
            	// 386:44: ->
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:388:1: arc : 'arc' ( '(' numberunit ':' numberunit ':' numberunit ( 'and' numberunit )? ')' )? ->;
    public simpletikzParser.arc_return arc() // throws RecognitionException [1]
    {   
        simpletikzParser.arc_return retval = new simpletikzParser.arc_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal177 = null;
        IToken char_literal178 = null;
        IToken char_literal180 = null;
        IToken char_literal182 = null;
        IToken string_literal184 = null;
        IToken char_literal186 = null;
        simpletikzParser.numberunit_return numberunit179 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit181 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit183 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit185 = default(simpletikzParser.numberunit_return);


        object string_literal177_tree=null;
        object char_literal178_tree=null;
        object char_literal180_tree=null;
        object char_literal182_tree=null;
        object string_literal184_tree=null;
        object char_literal186_tree=null;
        RewriteRuleTokenStream stream_49 = new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_67 = new RewriteRuleTokenStream(adaptor,"token 67");
        RewriteRuleTokenStream stream_48 = new RewriteRuleTokenStream(adaptor,"token 48");
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_73 = new RewriteRuleTokenStream(adaptor,"token 73");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:389:2: ( 'arc' ( '(' numberunit ':' numberunit ':' numberunit ( 'and' numberunit )? ')' )? ->)
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:389:4: 'arc' ( '(' numberunit ':' numberunit ':' numberunit ( 'and' numberunit )? ')' )?
            {
            	string_literal177=(IToken)Match(input,73,FOLLOW_73_in_arc2023); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_73.Add(string_literal177);

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:389:10: ( '(' numberunit ':' numberunit ':' numberunit ( 'and' numberunit )? ')' )?
            	int alt50 = 2;
            	int LA50_0 = input.LA(1);

            	if ( (LA50_0 == 48) )
            	{
            	    int LA50_1 = input.LA(2);

            	    if ( ((LA50_1 >= FLOAT_WO_EXP && LA50_1 <= INT)) )
            	    {
            	        int LA50_3 = input.LA(3);

            	        if ( (LA50_3 == 44) )
            	        {
            	            int LA50_4 = input.LA(4);

            	            if ( ((LA50_4 >= FLOAT_WO_EXP && LA50_4 <= INT)) )
            	            {
            	                int LA50_6 = input.LA(5);

            	                if ( ((LA50_6 >= 53 && LA50_6 <= 58)) )
            	                {
            	                    int LA50_7 = input.LA(6);

            	                    if ( (LA50_7 == 44) )
            	                    {
            	                        alt50 = 1;
            	                    }
            	                }
            	                else if ( (LA50_6 == 44) )
            	                {
            	                    alt50 = 1;
            	                }
            	            }
            	        }
            	        else if ( ((LA50_3 >= 53 && LA50_3 <= 58)) )
            	        {
            	            int LA50_5 = input.LA(4);

            	            if ( (LA50_5 == 44) )
            	            {
            	                int LA50_4 = input.LA(5);

            	                if ( ((LA50_4 >= FLOAT_WO_EXP && LA50_4 <= INT)) )
            	                {
            	                    int LA50_6 = input.LA(6);

            	                    if ( ((LA50_6 >= 53 && LA50_6 <= 58)) )
            	                    {
            	                        int LA50_7 = input.LA(7);

            	                        if ( (LA50_7 == 44) )
            	                        {
            	                            alt50 = 1;
            	                        }
            	                    }
            	                    else if ( (LA50_6 == 44) )
            	                    {
            	                        alt50 = 1;
            	                    }
            	                }
            	            }
            	        }
            	    }
            	}
            	switch (alt50) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:389:11: '(' numberunit ':' numberunit ':' numberunit ( 'and' numberunit )? ')'
            	        {
            	        	char_literal178=(IToken)Match(input,48,FOLLOW_48_in_arc2026); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_48.Add(char_literal178);

            	        	PushFollow(FOLLOW_numberunit_in_arc2028);
            	        	numberunit179 = numberunit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit179.Tree);
            	        	char_literal180=(IToken)Match(input,44,FOLLOW_44_in_arc2030); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_44.Add(char_literal180);

            	        	PushFollow(FOLLOW_numberunit_in_arc2032);
            	        	numberunit181 = numberunit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit181.Tree);
            	        	char_literal182=(IToken)Match(input,44,FOLLOW_44_in_arc2034); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_44.Add(char_literal182);

            	        	PushFollow(FOLLOW_numberunit_in_arc2036);
            	        	numberunit183 = numberunit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit183.Tree);
            	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:389:56: ( 'and' numberunit )?
            	        	int alt49 = 2;
            	        	int LA49_0 = input.LA(1);

            	        	if ( (LA49_0 == 67) )
            	        	{
            	        	    alt49 = 1;
            	        	}
            	        	switch (alt49) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:389:57: 'and' numberunit
            	        	        {
            	        	        	string_literal184=(IToken)Match(input,67,FOLLOW_67_in_arc2039); if (state.failed) return retval; 
            	        	        	if ( (state.backtracking==0) ) stream_67.Add(string_literal184);

            	        	        	PushFollow(FOLLOW_numberunit_in_arc2041);
            	        	        	numberunit185 = numberunit();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit185.Tree);

            	        	        }
            	        	        break;

            	        	}

            	        	char_literal186=(IToken)Match(input,49,FOLLOW_49_in_arc2045); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_49.Add(char_literal186);


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
            	// 389:82: ->
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:392:1: size : '(' numberunit ( 'and' numberunit )? ')' -> ^( IM_SIZE ( numberunit )* ) ;
    public simpletikzParser.size_return size() // throws RecognitionException [1]
    {   
        simpletikzParser.size_return retval = new simpletikzParser.size_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal187 = null;
        IToken string_literal189 = null;
        IToken char_literal191 = null;
        simpletikzParser.numberunit_return numberunit188 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit190 = default(simpletikzParser.numberunit_return);


        object char_literal187_tree=null;
        object string_literal189_tree=null;
        object char_literal191_tree=null;
        RewriteRuleTokenStream stream_49 = new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_67 = new RewriteRuleTokenStream(adaptor,"token 67");
        RewriteRuleTokenStream stream_48 = new RewriteRuleTokenStream(adaptor,"token 48");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:393:2: ( '(' numberunit ( 'and' numberunit )? ')' -> ^( IM_SIZE ( numberunit )* ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:393:6: '(' numberunit ( 'and' numberunit )? ')'
            {
            	char_literal187=(IToken)Match(input,48,FOLLOW_48_in_size2063); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_48.Add(char_literal187);

            	PushFollow(FOLLOW_numberunit_in_size2065);
            	numberunit188 = numberunit();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit188.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:393:21: ( 'and' numberunit )?
            	int alt51 = 2;
            	int LA51_0 = input.LA(1);

            	if ( (LA51_0 == 67) )
            	{
            	    alt51 = 1;
            	}
            	switch (alt51) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:393:22: 'and' numberunit
            	        {
            	        	string_literal189=(IToken)Match(input,67,FOLLOW_67_in_size2068); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_67.Add(string_literal189);

            	        	PushFollow(FOLLOW_numberunit_in_size2070);
            	        	numberunit190 = numberunit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit190.Tree);

            	        }
            	        break;

            	}

            	char_literal191=(IToken)Match(input,49,FOLLOW_49_in_size2074); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_49.Add(char_literal191);



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
            	// 393:46: -> ^( IM_SIZE ( numberunit )* )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:393:49: ^( IM_SIZE ( numberunit )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_SIZE, "IM_SIZE"), root_1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:393:59: ( numberunit )*
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:400:1: coord : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) );
    public simpletikzParser.coord_return coord() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_return retval = new simpletikzParser.coord_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal194 = null;
        IToken char_literal198 = null;
        IToken char_literal200 = null;
        IToken char_literal204 = null;
        simpletikzParser.nodename_return nodename192 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_modifier_return coord_modifier193 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.numberunit_return numberunit195 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_sep_return coord_sep196 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.numberunit_return numberunit197 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_modifier_return coord_modifier199 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.coord_part_return coord_part201 = default(simpletikzParser.coord_part_return);

        simpletikzParser.coord_sep_return coord_sep202 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.coord_part_return coord_part203 = default(simpletikzParser.coord_part_return);


        object char_literal194_tree=null;
        object char_literal198_tree=null;
        object char_literal200_tree=null;
        object char_literal204_tree=null;
        RewriteRuleTokenStream stream_49 = new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_48 = new RewriteRuleTokenStream(adaptor,"token 48");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_coord_part = new RewriteRuleSubtreeStream(adaptor,"rule coord_part");
        RewriteRuleSubtreeStream stream_coord_sep = new RewriteRuleSubtreeStream(adaptor,"rule coord_sep");
        RewriteRuleSubtreeStream stream_nodename = new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        RewriteRuleSubtreeStream stream_coord_modifier = new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:401:2: ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) )
            int alt54 = 3;
            alt54 = dfa54.Predict(input);
            switch (alt54) 
            {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:401:6: nodename
                    {
                    	PushFollow(FOLLOW_nodename_in_coord2104);
                    	nodename192 = nodename();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_nodename.Add(nodename192.Tree);


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
                    	// 401:23: -> ^( IM_COORD nodename )
                    	{
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:401:26: ^( IM_COORD nodename )
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
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:402:5: ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' )
                    {
                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:402:5: ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' )
                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:402:7: ( coord_modifier )? '(' numberunit coord_sep numberunit ')'
                    	{
                    		// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:402:7: ( coord_modifier )?
                    		int alt52 = 2;
                    		int LA52_0 = input.LA(1);

                    		if ( ((LA52_0 >= 78 && LA52_0 <= 79)) )
                    		{
                    		    alt52 = 1;
                    		}
                    		switch (alt52) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:402:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord2128);
                    		        	coord_modifier193 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_coord_modifier.Add(coord_modifier193.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal194=(IToken)Match(input,48,FOLLOW_48_in_coord2131); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_48.Add(char_literal194);

                    		PushFollow(FOLLOW_numberunit_in_coord2133);
                    		numberunit195 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit195.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord2135);
                    		coord_sep196 = coord_sep();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_sep.Add(coord_sep196.Tree);
                    		PushFollow(FOLLOW_numberunit_in_coord2137);
                    		numberunit197 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit197.Tree);
                    		char_literal198=(IToken)Match(input,49,FOLLOW_49_in_coord2139); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_49.Add(char_literal198);


                    	}



                    	// AST REWRITE
                    	// elements:          coord_sep, coord_modifier, numberunit
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 402:65: -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep )
                    	{
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:402:68: ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:402:79: ( coord_modifier )?
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
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:403:5: ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' )
                    {
                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:403:5: ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' )
                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:403:7: ( coord_modifier )? '(' coord_part coord_sep coord_part ')'
                    	{
                    		// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:403:7: ( coord_modifier )?
                    		int alt53 = 2;
                    		int LA53_0 = input.LA(1);

                    		if ( ((LA53_0 >= 78 && LA53_0 <= 79)) )
                    		{
                    		    alt53 = 1;
                    		}
                    		switch (alt53) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:403:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord2163);
                    		        	coord_modifier199 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_coord_modifier.Add(coord_modifier199.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal200=(IToken)Match(input,48,FOLLOW_48_in_coord2166); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_48.Add(char_literal200);

                    		PushFollow(FOLLOW_coord_part_in_coord2168);
                    		coord_part201 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_part.Add(coord_part201.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord2170);
                    		coord_sep202 = coord_sep();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_sep.Add(coord_sep202.Tree);
                    		PushFollow(FOLLOW_coord_part_in_coord2172);
                    		coord_part203 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_part.Add(coord_part203.Tree);
                    		char_literal204=(IToken)Match(input,49,FOLLOW_49_in_coord2174); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_49.Add(char_literal204);


                    	}



                    	// AST REWRITE
                    	// elements:          coord_modifier, coord_part, coord_sep
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 403:65: -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep )
                    	{
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:403:68: ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:403:79: ( coord_modifier )?
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:407:1: coord_part : ( idd -> ^( IM_DONTCARE idd ) | '{' idd '}' -> ^( IM_DONTCARE '{' idd '}' ) );
    public simpletikzParser.coord_part_return coord_part() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_part_return retval = new simpletikzParser.coord_part_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal206 = null;
        IToken char_literal208 = null;
        simpletikzParser.idd_return idd205 = default(simpletikzParser.idd_return);

        simpletikzParser.idd_return idd207 = default(simpletikzParser.idd_return);


        object char_literal206_tree=null;
        object char_literal208_tree=null;
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:408:2: ( idd -> ^( IM_DONTCARE idd ) | '{' idd '}' -> ^( IM_DONTCARE '{' idd '}' ) )
            int alt55 = 2;
            int LA55_0 = input.LA(1);

            if ( ((LA55_0 >= IM_PATH && LA55_0 <= 39) || LA55_0 == 47 || (LA55_0 >= 53 && LA55_0 <= 83)) )
            {
                alt55 = 1;
            }
            else if ( (LA55_0 == 40) )
            {
                alt55 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d55s0 =
                    new NoViableAltException("", 55, 0, input);

                throw nvae_d55s0;
            }
            switch (alt55) 
            {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:408:4: idd
                    {
                    	PushFollow(FOLLOW_idd_in_coord_part2202);
                    	idd205 = idd();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_idd.Add(idd205.Tree);


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
                    	// 408:9: -> ^( IM_DONTCARE idd )
                    	{
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:408:12: ^( IM_DONTCARE idd )
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
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:409:4: '{' idd '}'
                    {
                    	char_literal206=(IToken)Match(input,40,FOLLOW_40_in_coord_part2217); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_40.Add(char_literal206);

                    	PushFollow(FOLLOW_idd_in_coord_part2219);
                    	idd207 = idd();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_idd.Add(idd207.Tree);
                    	char_literal208=(IToken)Match(input,41,FOLLOW_41_in_coord_part2221); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_41.Add(char_literal208);



                    	// AST REWRITE
                    	// elements:          idd, 40, 41
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 409:16: -> ^( IM_DONTCARE '{' idd '}' )
                    	{
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:409:19: ^( IM_DONTCARE '{' idd '}' )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DONTCARE, "IM_DONTCARE"), root_1);

                    	    adaptor.AddChild(root_1, stream_40.NextNode());
                    	    adaptor.AddChild(root_1, stream_idd.NextTree());
                    	    adaptor.AddChild(root_1, stream_41.NextNode());

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:411:1: coord_sep : ( ',' | ':' ) ;
    public simpletikzParser.coord_sep_return coord_sep() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_sep_return retval = new simpletikzParser.coord_sep_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set209 = null;

        object set209_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:412:2: ( ( ',' | ':' ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:412:4: ( ',' | ':' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set209 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 43 && input.LA(1) <= 44) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set209));
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:416:1: edgeop : ( '--' | '->' | '|-' | '-|' | ID );
    public simpletikzParser.edgeop_return edgeop() // throws RecognitionException [1]
    {   
        simpletikzParser.edgeop_return retval = new simpletikzParser.edgeop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set210 = null;

        object set210_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:417:2: ( '--' | '->' | '|-' | '-|' | ID )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set210 = (IToken)input.LT(1);
            	if ( input.LA(1) == ID || (input.LA(1) >= 74 && input.LA(1) <= 77) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set210));
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:421:1: coord_modifier : ( '+' | '++' );
    public simpletikzParser.coord_modifier_return coord_modifier() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_modifier_return retval = new simpletikzParser.coord_modifier_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set211 = null;

        object set211_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:422:2: ( '+' | '++' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set211 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 78 && input.LA(1) <= 79) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set211));
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:464:1: squarebr_start : '[' -> ^( IM_STARTTAG '[' ) ;
    public simpletikzParser.squarebr_start_return squarebr_start() // throws RecognitionException [1]
    {   
        simpletikzParser.squarebr_start_return retval = new simpletikzParser.squarebr_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal212 = null;

        object char_literal212_tree=null;
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:465:2: ( '[' -> ^( IM_STARTTAG '[' ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:465:4: '['
            {
            	char_literal212=(IToken)Match(input,50,FOLLOW_50_in_squarebr_start2317); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_50.Add(char_literal212);



            	// AST REWRITE
            	// elements:          50
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 465:8: -> ^( IM_STARTTAG '[' )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:465:11: ^( IM_STARTTAG '[' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_50.NextNode());

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:467:1: squarebr_end : ']' -> ^( IM_ENDTAG ']' ) ;
    public simpletikzParser.squarebr_end_return squarebr_end() // throws RecognitionException [1]
    {   
        simpletikzParser.squarebr_end_return retval = new simpletikzParser.squarebr_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal213 = null;

        object char_literal213_tree=null;
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:468:2: ( ']' -> ^( IM_ENDTAG ']' ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:468:4: ']'
            {
            	char_literal213=(IToken)Match(input,51,FOLLOW_51_in_squarebr_end2335); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_51.Add(char_literal213);



            	// AST REWRITE
            	// elements:          51
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 468:8: -> ^( IM_ENDTAG ']' )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:468:11: ^( IM_ENDTAG ']' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_51.NextNode());

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:470:1: semicolon_end : ';' -> ^( IM_ENDTAG ';' ) ;
    public simpletikzParser.semicolon_end_return semicolon_end() // throws RecognitionException [1]
    {   
        simpletikzParser.semicolon_end_return retval = new simpletikzParser.semicolon_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal214 = null;

        object char_literal214_tree=null;
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:471:2: ( ';' -> ^( IM_ENDTAG ';' ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:471:4: ';'
            {
            	char_literal214=(IToken)Match(input,52,FOLLOW_52_in_semicolon_end2354); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_52.Add(char_literal214);



            	// AST REWRITE
            	// elements:          52
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 471:8: -> ^( IM_ENDTAG ';' )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:471:11: ^( IM_ENDTAG ';' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_52.NextNode());

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:473:1: roundbr_start : '{' -> ^( IM_STARTTAG '{' ) ;
    public simpletikzParser.roundbr_start_return roundbr_start() // throws RecognitionException [1]
    {   
        simpletikzParser.roundbr_start_return retval = new simpletikzParser.roundbr_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal215 = null;

        object char_literal215_tree=null;
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:474:2: ( '{' -> ^( IM_STARTTAG '{' ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:474:4: '{'
            {
            	char_literal215=(IToken)Match(input,40,FOLLOW_40_in_roundbr_start2372); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_40.Add(char_literal215);



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
            	// 474:8: -> ^( IM_STARTTAG '{' )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:474:11: ^( IM_STARTTAG '{' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:476:1: roundbr_end : '}' -> ^( IM_ENDTAG '}' ) ;
    public simpletikzParser.roundbr_end_return roundbr_end() // throws RecognitionException [1]
    {   
        simpletikzParser.roundbr_end_return retval = new simpletikzParser.roundbr_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal216 = null;

        object char_literal216_tree=null;
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:477:2: ( '}' -> ^( IM_ENDTAG '}' ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:477:4: '}'
            {
            	char_literal216=(IToken)Match(input,41,FOLLOW_41_in_roundbr_end2390); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(char_literal216);



            	// AST REWRITE
            	// elements:          41
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 477:8: -> ^( IM_ENDTAG '}' )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:477:11: ^( IM_ENDTAG '}' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_41.NextNode());

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:479:1: controls_start : '..' 'controls' -> ^( IM_STARTTAG '..' ) ;
    public simpletikzParser.controls_start_return controls_start() // throws RecognitionException [1]
    {   
        simpletikzParser.controls_start_return retval = new simpletikzParser.controls_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal217 = null;
        IToken string_literal218 = null;

        object string_literal217_tree=null;
        object string_literal218_tree=null;
        RewriteRuleTokenStream stream_80 = new RewriteRuleTokenStream(adaptor,"token 80");
        RewriteRuleTokenStream stream_81 = new RewriteRuleTokenStream(adaptor,"token 81");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:480:2: ( '..' 'controls' -> ^( IM_STARTTAG '..' ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:480:4: '..' 'controls'
            {
            	string_literal217=(IToken)Match(input,80,FOLLOW_80_in_controls_start2408); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_80.Add(string_literal217);

            	string_literal218=(IToken)Match(input,81,FOLLOW_81_in_controls_start2410); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_81.Add(string_literal218);



            	// AST REWRITE
            	// elements:          80
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 480:20: -> ^( IM_STARTTAG '..' )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:480:23: ^( IM_STARTTAG '..' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_80.NextNode());

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:482:1: controls_end : '..' -> ^( IM_ENDTAG '..' ) ;
    public simpletikzParser.controls_end_return controls_end() // throws RecognitionException [1]
    {   
        simpletikzParser.controls_end_return retval = new simpletikzParser.controls_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal219 = null;

        object string_literal219_tree=null;
        RewriteRuleTokenStream stream_80 = new RewriteRuleTokenStream(adaptor,"token 80");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:483:2: ( '..' -> ^( IM_ENDTAG '..' ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:483:4: '..'
            {
            	string_literal219=(IToken)Match(input,80,FOLLOW_80_in_controls_end2428); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_80.Add(string_literal219);



            	// AST REWRITE
            	// elements:          80
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 483:9: -> ^( IM_ENDTAG '..' )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:483:12: ^( IM_ENDTAG '..' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_80.NextNode());

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:485:1: tikz_set_start : '\\\\tikzset' '{' -> ^( IM_STARTTAG ) ;
    public simpletikzParser.tikz_set_start_return tikz_set_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_set_start_return retval = new simpletikzParser.tikz_set_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal220 = null;
        IToken char_literal221 = null;

        object string_literal220_tree=null;
        object char_literal221_tree=null;
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:486:2: ( '\\\\tikzset' '{' -> ^( IM_STARTTAG ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:486:4: '\\\\tikzset' '{'
            {
            	string_literal220=(IToken)Match(input,39,FOLLOW_39_in_tikz_set_start2446); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_39.Add(string_literal220);

            	char_literal221=(IToken)Match(input,40,FOLLOW_40_in_tikz_set_start2448); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_40.Add(char_literal221);



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
            	// 486:21: -> ^( IM_STARTTAG )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:486:24: ^( IM_STARTTAG )
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:488:1: tikzpicture_start : '\\\\begin' '{' 'tikzpicture' '}' -> ^( IM_STARTTAG '\\\\begin' ) ;
    public simpletikzParser.tikzpicture_start_return tikzpicture_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_start_return retval = new simpletikzParser.tikzpicture_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal222 = null;
        IToken char_literal223 = null;
        IToken string_literal224 = null;
        IToken char_literal225 = null;

        object string_literal222_tree=null;
        object char_literal223_tree=null;
        object string_literal224_tree=null;
        object char_literal225_tree=null;
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleTokenStream stream_82 = new RewriteRuleTokenStream(adaptor,"token 82");
        RewriteRuleTokenStream stream_37 = new RewriteRuleTokenStream(adaptor,"token 37");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:489:2: ( '\\\\begin' '{' 'tikzpicture' '}' -> ^( IM_STARTTAG '\\\\begin' ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:489:4: '\\\\begin' '{' 'tikzpicture' '}'
            {
            	string_literal222=(IToken)Match(input,37,FOLLOW_37_in_tikzpicture_start2467); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_37.Add(string_literal222);

            	char_literal223=(IToken)Match(input,40,FOLLOW_40_in_tikzpicture_start2469); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_40.Add(char_literal223);

            	string_literal224=(IToken)Match(input,82,FOLLOW_82_in_tikzpicture_start2471); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_82.Add(string_literal224);

            	char_literal225=(IToken)Match(input,41,FOLLOW_41_in_tikzpicture_start2473); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(char_literal225);



            	// AST REWRITE
            	// elements:          37
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 489:36: -> ^( IM_STARTTAG '\\\\begin' )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:489:39: ^( IM_STARTTAG '\\\\begin' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_37.NextNode());

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:491:1: tikzpicture_end : '\\\\end' '{' 'tikzpicture' '}' -> ^( IM_ENDTAG '\\\\end' ) ;
    public simpletikzParser.tikzpicture_end_return tikzpicture_end() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_end_return retval = new simpletikzParser.tikzpicture_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal226 = null;
        IToken char_literal227 = null;
        IToken string_literal228 = null;
        IToken char_literal229 = null;

        object string_literal226_tree=null;
        object char_literal227_tree=null;
        object string_literal228_tree=null;
        object char_literal229_tree=null;
        RewriteRuleTokenStream stream_59 = new RewriteRuleTokenStream(adaptor,"token 59");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleTokenStream stream_82 = new RewriteRuleTokenStream(adaptor,"token 82");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:492:2: ( '\\\\end' '{' 'tikzpicture' '}' -> ^( IM_ENDTAG '\\\\end' ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:492:4: '\\\\end' '{' 'tikzpicture' '}'
            {
            	string_literal226=(IToken)Match(input,59,FOLLOW_59_in_tikzpicture_end2491); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_59.Add(string_literal226);

            	char_literal227=(IToken)Match(input,40,FOLLOW_40_in_tikzpicture_end2493); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_40.Add(char_literal227);

            	string_literal228=(IToken)Match(input,82,FOLLOW_82_in_tikzpicture_end2495); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_82.Add(string_literal228);

            	char_literal229=(IToken)Match(input,41,FOLLOW_41_in_tikzpicture_end2497); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(char_literal229);



            	// AST REWRITE
            	// elements:          59
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 492:34: -> ^( IM_ENDTAG '\\\\end' )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:492:37: ^( IM_ENDTAG '\\\\end' )
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

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:494:1: tikzscope_start : '\\\\begin' '{' 'scope' '}' -> ^( IM_STARTTAG '\\\\begin' ) ;
    public simpletikzParser.tikzscope_start_return tikzscope_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_start_return retval = new simpletikzParser.tikzscope_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal230 = null;
        IToken char_literal231 = null;
        IToken string_literal232 = null;
        IToken char_literal233 = null;

        object string_literal230_tree=null;
        object char_literal231_tree=null;
        object string_literal232_tree=null;
        object char_literal233_tree=null;
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleTokenStream stream_83 = new RewriteRuleTokenStream(adaptor,"token 83");
        RewriteRuleTokenStream stream_37 = new RewriteRuleTokenStream(adaptor,"token 37");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:495:2: ( '\\\\begin' '{' 'scope' '}' -> ^( IM_STARTTAG '\\\\begin' ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:495:4: '\\\\begin' '{' 'scope' '}'
            {
            	string_literal230=(IToken)Match(input,37,FOLLOW_37_in_tikzscope_start2515); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_37.Add(string_literal230);

            	char_literal231=(IToken)Match(input,40,FOLLOW_40_in_tikzscope_start2517); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_40.Add(char_literal231);

            	string_literal232=(IToken)Match(input,83,FOLLOW_83_in_tikzscope_start2519); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_83.Add(string_literal232);

            	char_literal233=(IToken)Match(input,41,FOLLOW_41_in_tikzscope_start2521); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(char_literal233);



            	// AST REWRITE
            	// elements:          37
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 495:30: -> ^( IM_STARTTAG '\\\\begin' )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:495:33: ^( IM_STARTTAG '\\\\begin' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_37.NextNode());

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:497:1: tikzscope_end : '\\\\end' '{' 'scope' '}' -> ^( IM_ENDTAG '\\\\end' ) ;
    public simpletikzParser.tikzscope_end_return tikzscope_end() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_end_return retval = new simpletikzParser.tikzscope_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal234 = null;
        IToken char_literal235 = null;
        IToken string_literal236 = null;
        IToken char_literal237 = null;

        object string_literal234_tree=null;
        object char_literal235_tree=null;
        object string_literal236_tree=null;
        object char_literal237_tree=null;
        RewriteRuleTokenStream stream_59 = new RewriteRuleTokenStream(adaptor,"token 59");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleTokenStream stream_83 = new RewriteRuleTokenStream(adaptor,"token 83");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:498:2: ( '\\\\end' '{' 'scope' '}' -> ^( IM_ENDTAG '\\\\end' ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:498:4: '\\\\end' '{' 'scope' '}'
            {
            	string_literal234=(IToken)Match(input,59,FOLLOW_59_in_tikzscope_end2539); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_59.Add(string_literal234);

            	char_literal235=(IToken)Match(input,40,FOLLOW_40_in_tikzscope_end2541); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_40.Add(char_literal235);

            	string_literal236=(IToken)Match(input,83,FOLLOW_83_in_tikzscope_end2543); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_83.Add(string_literal236);

            	char_literal237=(IToken)Match(input,41,FOLLOW_41_in_tikzscope_end2545); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(char_literal237);



            	// AST REWRITE
            	// elements:          59
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 498:28: -> ^( IM_ENDTAG '\\\\end' )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:498:31: ^( IM_ENDTAG '\\\\end' )
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

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:500:1: path_start : path_start_tag -> ^( IM_STARTTAG path_start_tag ) ;
    public simpletikzParser.path_start_return path_start() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_return retval = new simpletikzParser.path_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.path_start_tag_return path_start_tag238 = default(simpletikzParser.path_start_tag_return);


        RewriteRuleSubtreeStream stream_path_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule path_start_tag");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:501:2: ( path_start_tag -> ^( IM_STARTTAG path_start_tag ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:501:4: path_start_tag
            {
            	PushFollow(FOLLOW_path_start_tag_in_path_start2564);
            	path_start_tag238 = path_start_tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_path_start_tag.Add(path_start_tag238.Tree);


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
            	// 501:19: -> ^( IM_STARTTAG path_start_tag )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:501:22: ^( IM_STARTTAG path_start_tag )
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:503:1: node_start : node_start_tag -> ^( IM_STARTTAG node_start_tag ) ;
    public simpletikzParser.node_start_return node_start() // throws RecognitionException [1]
    {   
        simpletikzParser.node_start_return retval = new simpletikzParser.node_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.node_start_tag_return node_start_tag239 = default(simpletikzParser.node_start_tag_return);


        RewriteRuleSubtreeStream stream_node_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule node_start_tag");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:504:2: ( node_start_tag -> ^( IM_STARTTAG node_start_tag ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:504:4: node_start_tag
            {
            	PushFollow(FOLLOW_node_start_tag_in_node_start2582);
            	node_start_tag239 = node_start_tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_node_start_tag.Add(node_start_tag239.Tree);


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
            	// 504:19: -> ^( IM_STARTTAG node_start_tag )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:504:22: ^( IM_STARTTAG node_start_tag )
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:506:1: node_start_tag : '\\\\node' ;
    public simpletikzParser.node_start_tag_return node_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.node_start_tag_return retval = new simpletikzParser.node_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal240 = null;

        object string_literal240_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:507:2: ( '\\\\node' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:507:4: '\\\\node'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal240=(IToken)Match(input,60,FOLLOW_60_in_node_start_tag2600); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal240_tree = (object)adaptor.Create(string_literal240);
            		adaptor.AddChild(root_0, string_literal240_tree);
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:509:1: coordinate_start : '\\\\coordinate' -> ^( IM_STARTTAG '\\\\coordinate' ) ;
    public simpletikzParser.coordinate_start_return coordinate_start() // throws RecognitionException [1]
    {   
        simpletikzParser.coordinate_start_return retval = new simpletikzParser.coordinate_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal241 = null;

        object string_literal241_tree=null;
        RewriteRuleTokenStream stream_61 = new RewriteRuleTokenStream(adaptor,"token 61");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:510:2: ( '\\\\coordinate' -> ^( IM_STARTTAG '\\\\coordinate' ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:510:4: '\\\\coordinate'
            {
            	string_literal241=(IToken)Match(input,61,FOLLOW_61_in_coordinate_start2610); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_61.Add(string_literal241);



            	// AST REWRITE
            	// elements:          61
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 510:19: -> ^( IM_STARTTAG '\\\\coordinate' )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:510:22: ^( IM_STARTTAG '\\\\coordinate' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_61.NextNode());

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:512:1: path_start_tag : ( '\\\\draw' | '\\\\fill' | '\\\\path' | '\\\\clip' );
    public simpletikzParser.path_start_tag_return path_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_tag_return retval = new simpletikzParser.path_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set242 = null;

        object set242_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:513:2: ( '\\\\draw' | '\\\\fill' | '\\\\path' | '\\\\clip' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set242 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 62 && input.LA(1) <= 65) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set242));
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
        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:326:8: ( tikzcoordinate_core3 )
        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:326:9: tikzcoordinate_core3
        {
        	PushFollow(FOLLOW_tikzcoordinate_core3_in_synpred1_simpletikz1559);
        	tikzcoordinate_core3();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred1_simpletikz"

    // $ANTLR start "synpred2_simpletikz"
    public void synpred2_simpletikz_fragment() {
        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:327:12: ( tikzcoordinate_core2 )
        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:327:13: tikzcoordinate_core2
        {
        	PushFollow(FOLLOW_tikzcoordinate_core2_in_synpred2_simpletikz1578);
        	tikzcoordinate_core2();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred2_simpletikz"

    // $ANTLR start "synpred3_simpletikz"
    public void synpred3_simpletikz_fragment() {
        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:328:12: ( tikzcoordinate_core1 )
        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:328:13: tikzcoordinate_core1
        {
        	PushFollow(FOLLOW_tikzcoordinate_core1_in_synpred3_simpletikz1598);
        	tikzcoordinate_core1();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred3_simpletikz"

    // $ANTLR start "synpred4_simpletikz"
    public void synpred4_simpletikz_fragment() {
        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:337:21: ( tikzcoordinate_core3 )
        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:337:22: tikzcoordinate_core3
        {
        	PushFollow(FOLLOW_tikzcoordinate_core3_in_synpred4_simpletikz1683);
        	tikzcoordinate_core3();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred4_simpletikz"

    // $ANTLR start "synpred5_simpletikz"
    public void synpred5_simpletikz_fragment() {
        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:338:12: ( tikzcoordinate_core2 )
        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:338:13: tikzcoordinate_core2
        {
        	PushFollow(FOLLOW_tikzcoordinate_core2_in_synpred5_simpletikz1702);
        	tikzcoordinate_core2();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred5_simpletikz"

    // $ANTLR start "synpred6_simpletikz"
    public void synpred6_simpletikz_fragment() {
        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:339:12: ( tikzcoordinate_core1 )
        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:339:13: tikzcoordinate_core1
        {
        	PushFollow(FOLLOW_tikzcoordinate_core1_in_synpred6_simpletikz1722);
        	tikzcoordinate_core1();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred6_simpletikz"

    // $ANTLR start "synpred7_simpletikz"
    public void synpred7_simpletikz_fragment() {
        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:386:28: ( size )
        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:386:29: size
        {
        	PushFollow(FOLLOW_size_in_synpred7_simpletikz2004);
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
   	protected DFA26 dfa26;
   	protected DFA27 dfa27;
   	protected DFA39 dfa39;
   	protected DFA41 dfa41;
   	protected DFA48 dfa48;
   	protected DFA54 dfa54;
	private void InitializeCyclicDFAs()
	{
    	this.dfa8 = new DFA8(this);
    	this.dfa13 = new DFA13(this);
    	this.dfa26 = new DFA26(this);
    	this.dfa27 = new DFA27(this);
    	this.dfa39 = new DFA39(this);
    	this.dfa41 = new DFA41(this);
    	this.dfa48 = new DFA48(this);
    	this.dfa54 = new DFA54(this);
	    this.dfa39.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA39_SpecialStateTransition);
	    this.dfa41.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA41_SpecialStateTransition);
	    this.dfa48.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA48_SpecialStateTransition);
	}

    const string DFA8_eotS =
        "\x04\uffff";
    const string DFA8_eofS =
        "\x04\uffff";
    const string DFA8_minS =
        "\x02\x04\x02\uffff";
    const string DFA8_maxS =
        "\x02\x53\x02\uffff";
    const string DFA8_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA8_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA8_transitionS = {
            "\x24\x01\x07\uffff\x01\x01\x05\uffff\x1f\x01",
            "\x24\x01\x01\uffff\x03\x03\x01\uffff\x02\x02\x01\x01\x03\uffff"+
            "\x01\x03\x01\uffff\x1f\x01",
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
            get { return "169:1: option : ( option_style | option_kv );"; }
        }

    }

    const string DFA13_eotS =
        "\x23\uffff";
    const string DFA13_eofS =
        "\x23\uffff";
    const string DFA13_minS =
        "\x01\x04\x01\x29\x01\x04\x01\uffff\x01\x29\x02\uffff\x01\x04\x01"+
        "\uffff\x0f\x04\x01\uffff\x0a\x04";
    const string DFA13_maxS =
        "\x01\x53\x01\x3a\x01\x53\x01\uffff\x01\x33\x02\uffff\x01\x53\x01"+
        "\uffff\x0f\x53\x01\uffff\x0a\x53";
    const string DFA13_acceptS =
        "\x03\uffff\x01\x04\x01\uffff\x01\x02\x01\x01\x01\uffff\x01\x05"+
        "\x0f\uffff\x01\x03\x0a\uffff";
    const string DFA13_specialS =
        "\x23\uffff}>";
    static readonly string[] DFA13_transitionS = {
            "\x18\x03\x02\x01\x0a\x03\x01\x02\x06\uffff\x01\x03\x05\uffff"+
            "\x1f\x03",
            "\x01\x05\x01\uffff\x01\x05\x01\x06\x06\uffff\x01\x05\x01\uffff"+
            "\x06\x04",
            "\x2c\x08\x01\x07\x1d\x08\x02\x09\x04\x08",
            "",
            "\x01\x05\x01\uffff\x01\x05\x01\x06\x06\uffff\x01\x05",
            "",
            "",
            "\x18\x0c\x02\x0a\x0a\x0c\x01\x0b\x06\x08\x01\x0c\x05\x08\x1f"+
            "\x0c",
            "",
            "\x2c\x08\x01\x0d\x23\x08",
            "\x24\x0c\x03\x08\x02\x0e\x02\x08\x01\x0c\x01\x08\x01\x10\x03"+
            "\x08\x06\x0f\x19\x0c",
            "\x24\x11\x07\x08\x01\x11\x05\x08\x1f\x11",
            "\x24\x0c\x03\x08\x02\x12\x02\x08\x01\x0c\x01\x08\x01\x10\x03"+
            "\x08\x1f\x0c",
            "\x18\x14\x02\x13\x0a\x14\x01\x0b\x06\x08\x01\x14\x05\x08\x1f"+
            "\x14",
            "\x18\x17\x02\x15\x0a\x17\x01\x16\x06\x08\x01\x17\x05\x08\x1f"+
            "\x17",
            "\x24\x0c\x03\x08\x02\x0e\x02\x08\x01\x0c\x01\x08\x01\x10\x03"+
            "\x08\x1f\x0c",
            "\x25\x08\x01\x18\x2a\x08",
            "\x24\x11\x01\x08\x01\x19\x05\x08\x01\x11\x05\x08\x1f\x11",
            "\x24\x17\x01\x16\x06\x08\x01\x17\x05\x08\x1f\x17",
            "\x24\x14\x03\x08\x02\x0e\x02\x08\x01\x14\x05\x08\x06\x1a\x19"+
            "\x14",
            "\x24\x14\x03\x08\x02\x12\x02\x08\x01\x14\x05\x08\x1f\x14",
            "\x24\x17\x07\x08\x01\x17\x01\x08\x01\x1b\x03\x08\x06\x1c\x19"+
            "\x17",
            "\x24\x1d\x07\x08\x01\x1d\x05\x08\x1f\x1d",
            "\x24\x17\x07\x08\x01\x17\x01\x08\x01\x1e\x03\x08\x1f\x17",
            "",
            "\x27\x08\x02\x1f\x27\x08",
            "\x24\x14\x03\x08\x02\x0e\x02\x08\x01\x14\x05\x08\x1f\x14",
            "\x25\x08\x01\x18\x2a\x08",
            "\x24\x17\x07\x08\x01\x17\x01\x08\x01\x1b\x03\x08\x1f\x17",
            "\x24\x1d\x01\x08\x01\x20\x05\x08\x01\x1d\x05\x08\x1f\x1d",
            "\x25\x08\x01\x18\x2a\x08",
            "\x24\x21\x01\x16\x06\x08\x01\x21\x05\x08\x1f\x21",
            "\x2d\x08\x01\x22\x22\x08",
            "\x24\x21\x07\x08\x01\x21\x01\x08\x01\x22\x03\x08\x1f\x21",
            "\x25\x08\x01\x18\x2a\x08"
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
            get { return "185:1: iddornumberunitorstringorrange : ( range | numberunit | bracedcoord | idd | tikzstring );"; }
        }

    }

    const string DFA26_eotS =
        "\x0c\uffff";
    const string DFA26_eofS =
        "\x0c\uffff";
    const string DFA26_minS =
        "\x01\x04\x01\x28\x07\uffff\x01\x1b\x02\uffff";
    const string DFA26_maxS =
        "\x01\x53\x01\x28\x07\uffff\x01\x53\x02\uffff";
    const string DFA26_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x08\x01"+
        "\x09\x01\uffff\x01\x01\x01\x07";
    const string DFA26_specialS =
        "\x0c\uffff}>";
    static readonly string[] DFA26_transitionS = {
            "\x21\x08\x01\x01\x01\x06\x01\x05\x0a\x08\x01\uffff\x08\x08"+
            "\x01\x07\x01\x03\x01\x04\x04\x02\x12\x08",
            "\x01\x09",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0b\x37\uffff\x01\x0a",
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
            get { return "241:4: ( tikzscope | tikzpath | tikznode_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr )"; }
        }

    }

    const string DFA27_eotS =
        "\x0f\uffff";
    const string DFA27_eofS =
        "\x0f\uffff";
    const string DFA27_minS =
        "\x01\x04\x02\x28\x06\uffff\x02\x1b\x04\uffff";
    const string DFA27_maxS =
        "\x01\x53\x02\x28\x06\uffff\x02\x53\x04\uffff";
    const string DFA27_acceptS =
        "\x03\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x09\x02"+
        "\uffff\x01\x0a\x01\x08\x01\x01\x01\x07";
    const string DFA27_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA27_transitionS = {
            "\x21\x08\x01\x02\x01\x07\x01\x06\x13\x08\x01\x01\x01\x04\x01"+
            "\x05\x04\x03\x12\x08",
            "\x01\x09",
            "\x01\x0a",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0c\x36\uffff\x02\x0b",
            "\x01\x0e\x37\uffff\x01\x0d",
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
            get { return "()* loopback of 242:3: ( tikzscope | tikzpath | tikznode_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*"; }
        }

    }

    const string DFA39_eotS =
        "\x11\uffff";
    const string DFA39_eofS =
        "\x11\uffff";
    const string DFA39_minS =
        "\x01\x1b\x03\x00\x0d\uffff";
    const string DFA39_maxS =
        "\x01\x50\x03\x00\x0d\uffff";
    const string DFA39_acceptS =
        "\x04\uffff\x01\x04\x09\uffff\x01\x01\x01\x02\x01\x03";
    const string DFA39_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x0d\uffff}>";
    static readonly string[] DFA39_transitionS = {
            "\x01\x04\x0c\uffff\x01\x04\x07\uffff\x01\x01\x01\uffff\x01"+
            "\x03\x01\uffff\x01\x04\x0f\uffff\x02\x04\x01\x02\x0a\x04",
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
            ""
    };

    static readonly short[] DFA39_eot = DFA.UnpackEncodedString(DFA39_eotS);
    static readonly short[] DFA39_eof = DFA.UnpackEncodedString(DFA39_eofS);
    static readonly char[] DFA39_min = DFA.UnpackEncodedStringToUnsignedChars(DFA39_minS);
    static readonly char[] DFA39_max = DFA.UnpackEncodedStringToUnsignedChars(DFA39_maxS);
    static readonly short[] DFA39_accept = DFA.UnpackEncodedString(DFA39_acceptS);
    static readonly short[] DFA39_special = DFA.UnpackEncodedString(DFA39_specialS);
    static readonly short[][] DFA39_transition = DFA.UnpackEncodedStringArray(DFA39_transitionS);

    protected class DFA39 : DFA
    {
        public DFA39(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 39;
            this.eot = DFA39_eot;
            this.eof = DFA39_eof;
            this.min = DFA39_min;
            this.max = DFA39_max;
            this.accept = DFA39_accept;
            this.special = DFA39_special;
            this.transition = DFA39_transition;

        }

        override public string Description
        {
            get { return "326:5: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?"; }
        }

    }


    protected internal int DFA39_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA39_1 = input.LA(1);

                   	 
                   	int index39_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_simpletikz()) ) { s = 14; }

                   	else if ( (synpred2_simpletikz()) ) { s = 15; }

                   	else if ( (synpred3_simpletikz()) ) { s = 16; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index39_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA39_2 = input.LA(1);

                   	 
                   	int index39_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_simpletikz()) ) { s = 14; }

                   	else if ( (synpred2_simpletikz()) ) { s = 15; }

                   	else if ( (synpred3_simpletikz()) ) { s = 16; }

                   	 
                   	input.Seek(index39_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA39_3 = input.LA(1);

                   	 
                   	int index39_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_simpletikz()) ) { s = 14; }

                   	else if ( (synpred2_simpletikz()) ) { s = 15; }

                   	else if ( (synpred3_simpletikz()) ) { s = 16; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index39_3);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae39 =
            new NoViableAltException(dfa.Description, 39, _s, input);
        dfa.Error(nvae39);
        throw nvae39;
    }
    const string DFA41_eotS =
        "\x14\uffff";
    const string DFA41_eofS =
        "\x14\uffff";
    const string DFA41_minS =
        "\x01\x1b\x03\x00\x10\uffff";
    const string DFA41_maxS =
        "\x01\x50\x03\x00\x10\uffff";
    const string DFA41_acceptS =
        "\x04\uffff\x01\x04\x0c\uffff\x01\x01\x01\x02\x01\x03";
    const string DFA41_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x10\uffff}>";
    static readonly string[] DFA41_transitionS = {
            "\x01\x04\x02\uffff\x01\x04\x09\uffff\x02\x04\x06\uffff\x01"+
            "\x01\x01\uffff\x01\x03\x01\uffff\x01\x04\x01\uffff\x01\x04\x0d"+
            "\uffff\x02\x04\x01\x02\x0a\x04",
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
            get { return "337:18: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?"; }
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
                   	if ( (synpred4_simpletikz()) ) { s = 17; }

                   	else if ( (synpred5_simpletikz()) ) { s = 18; }

                   	else if ( (synpred6_simpletikz()) ) { s = 19; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index41_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA41_2 = input.LA(1);

                   	 
                   	int index41_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred4_simpletikz()) ) { s = 17; }

                   	else if ( (synpred5_simpletikz()) ) { s = 18; }

                   	else if ( (synpred6_simpletikz()) ) { s = 19; }

                   	 
                   	input.Seek(index41_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA41_3 = input.LA(1);

                   	 
                   	int index41_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred4_simpletikz()) ) { s = 17; }

                   	else if ( (synpred5_simpletikz()) ) { s = 18; }

                   	else if ( (synpred6_simpletikz()) ) { s = 19; }

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
    const string DFA48_eotS =
        "\x0a\uffff";
    const string DFA48_eofS =
        "\x0a\uffff";
    const string DFA48_minS =
        "\x01\x1b\x01\x04\x01\uffff\x02\x04\x01\x00\x01\x04\x01\uffff\x02"+
        "\x04";
    const string DFA48_maxS =
        "\x01\x50\x01\x53\x01\uffff\x02\x53\x01\x00\x01\x53\x01\uffff\x02"+
        "\x53";
    const string DFA48_acceptS =
        "\x02\uffff\x01\x02\x04\uffff\x01\x01\x02\uffff";
    const string DFA48_specialS =
        "\x05\uffff\x01\x00\x04\uffff}>";
    static readonly string[] DFA48_transitionS = {
            "\x01\x02\x02\uffff\x01\x02\x09\uffff\x02\x02\x06\uffff\x01"+
            "\x01\x01\uffff\x01\x02\x01\uffff\x01\x02\x01\uffff\x01\x02\x0d"+
            "\uffff\x02\x02\x01\uffff\x0a\x02",
            "\x18\x02\x02\x03\x0b\x02\x06\uffff\x01\x02\x05\uffff\x1f\x02",
            "",
            "\x24\x02\x03\uffff\x02\x02\x02\uffff\x01\x02\x01\uffff\x01"+
            "\x05\x03\uffff\x06\x04\x08\x02\x01\x06\x10\x02",
            "\x24\x02\x03\uffff\x02\x02\x02\uffff\x01\x02\x01\uffff\x01"+
            "\x05\x03\uffff\x0e\x02\x01\x06\x10\x02",
            "\x01\uffff",
            "\x18\x02\x02\x08\x0a\x02\x03\uffff\x02\x02\x02\uffff\x01\x02"+
            "\x01\uffff\x01\x02\x03\uffff\x1f\x02",
            "",
            "\x24\x02\x03\uffff\x02\x02\x02\uffff\x01\x02\x01\uffff\x01"+
            "\x05\x03\uffff\x06\x09\x19\x02",
            "\x24\x02\x03\uffff\x02\x02\x02\uffff\x01\x02\x01\uffff\x01"+
            "\x05\x03\uffff\x1f\x02"
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
            get { return "386:27: ( ( size )=> size )?"; }
        }

    }


    protected internal int DFA48_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA48_5 = input.LA(1);

                   	 
                   	int index48_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred7_simpletikz()) ) { s = 7; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index48_5);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae48 =
            new NoViableAltException(dfa.Description, 48, _s, input);
        dfa.Error(nvae48);
        throw nvae48;
    }
    const string DFA54_eotS =
        "\x0f\uffff";
    const string DFA54_eofS =
        "\x0f\uffff";
    const string DFA54_minS =
        "\x01\x30\x01\x04\x01\x30\x01\x04\x01\uffff\x04\x04\x01\uffff\x03"+
        "\x04\x01\uffff\x01\x04";
    const string DFA54_maxS =
        "\x01\x4f\x01\x53\x01\x30\x01\x53\x01\uffff\x04\x53\x01\uffff\x03"+
        "\x53\x01\uffff\x01\x53";
    const string DFA54_acceptS =
        "\x04\uffff\x01\x03\x04\uffff\x01\x01\x03\uffff\x01\x02\x01\uffff";
    const string DFA54_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA54_transitionS = {
            "\x01\x01\x1d\uffff\x02\x02",
            "\x18\x05\x02\x03\x0a\x05\x01\x04\x06\uffff\x01\x05\x05\uffff"+
            "\x1f\x05",
            "\x01\x06",
            "\x24\x05\x03\uffff\x02\x07\x02\uffff\x01\x05\x01\uffff\x01"+
            "\x09\x03\uffff\x06\x08\x19\x05",
            "",
            "\x24\x05\x03\uffff\x02\x04\x02\uffff\x01\x05\x01\uffff\x01"+
            "\x09\x03\uffff\x1f\x05",
            "\x18\x04\x02\x0a\x0b\x04\x06\uffff\x01\x04\x05\uffff\x1f\x04",
            "\x18\x04\x02\x0b\x0b\x04\x06\uffff\x01\x04\x05\uffff\x1f\x04",
            "\x24\x05\x03\uffff\x02\x07\x02\uffff\x01\x05\x01\uffff\x01"+
            "\x09\x03\uffff\x1f\x05",
            "",
            "\x24\x04\x03\uffff\x02\x07\x02\uffff\x01\x04\x05\uffff\x06"+
            "\x0c\x19\x04",
            "\x24\x04\x07\uffff\x01\x04\x01\uffff\x01\x0d\x03\uffff\x06"+
            "\x0e\x19\x04",
            "\x24\x04\x03\uffff\x02\x07\x02\uffff\x01\x04\x05\uffff\x1f"+
            "\x04",
            "",
            "\x24\x04\x07\uffff\x01\x04\x01\uffff\x01\x0d\x03\uffff\x1f"+
            "\x04"
    };

    static readonly short[] DFA54_eot = DFA.UnpackEncodedString(DFA54_eotS);
    static readonly short[] DFA54_eof = DFA.UnpackEncodedString(DFA54_eofS);
    static readonly char[] DFA54_min = DFA.UnpackEncodedStringToUnsignedChars(DFA54_minS);
    static readonly char[] DFA54_max = DFA.UnpackEncodedStringToUnsignedChars(DFA54_maxS);
    static readonly short[] DFA54_accept = DFA.UnpackEncodedString(DFA54_acceptS);
    static readonly short[] DFA54_special = DFA.UnpackEncodedString(DFA54_specialS);
    static readonly short[][] DFA54_transition = DFA.UnpackEncodedStringArray(DFA54_transitionS);

    protected class DFA54 : DFA
    {
        public DFA54(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 54;
            this.eot = DFA54_eot;
            this.eof = DFA54_eof;
            this.min = DFA54_min;
            this.max = DFA54_max;
            this.accept = DFA54_accept;
            this.special = DFA54_special;
            this.transition = DFA54_transition;

        }

        override public string Description
        {
            get { return "400:1: coord : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_dontcare_preamble_in_tikzdocument253 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_tikz_styleorsetorcmd_in_tikzdocument257 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzdocument261 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_tikzpicture_in_tikzdocument266 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_dontcare_preamble_in_tikzdocument_wo_tikzpicture292 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_tikz_styleorsetorcmd_in_tikzdocument_wo_tikzpicture296 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzdocument_wo_tikzpicture300 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_EOF_in_tikzdocument_wo_tikzpicture305 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TIKZEDT_CMD_COMMENT_in_tikz_cmd_comment326 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikz_styleorsetorcmd348 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikz_styleorsetorcmd352 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_cmd_comment_in_tikz_styleorsetorcmd356 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_preamble367 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_37_in_otherbegin392 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_otherbegin394 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_idd2_in_otherbegin396 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_otherbegin398 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_tikz_style410 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_tikz_style412 = new BitSet(new ulong[]{0xFFE080FFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_idd_in_tikz_style414 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_tikz_style416 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_tikz_style418 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikz_style420 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_squarebr_start_in_tikz_options442 = new BitSet(new ulong[]{0xFFE880FFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_options445 = new BitSet(new ulong[]{0xFFE888FFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_43_in_tikz_options448 = new BitSet(new ulong[]{0xFFE080FFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_options450 = new BitSet(new ulong[]{0xFFE888FFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_43_in_tikz_options454 = new BitSet(new ulong[]{0xFFE880FFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_squarebr_end_in_tikz_options459 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_option_style_in_option484 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_option_kv_in_option493 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_option_kv507 = new BitSet(new ulong[]{0x0000040000000002UL});
    public static readonly BitSet FOLLOW_42_in_option_kv510 = new BitSet(new ulong[]{0xFFE081FFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_iddornumberunitorstringorrange_in_option_kv512 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_tikzstring540 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_no_rlbrace_in_tikzstring542 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikzstring546 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_no_rlbrace_in_tikzstring548 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_41_in_tikzstring553 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_no_rlbrace576 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_range_in_iddornumberunitorstringorrange594 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_numberunit_in_iddornumberunitorstringorrange598 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_bracedcoord_in_iddornumberunitorstringorrange602 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_iddornumberunitorstringorrange606 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzstring_in_iddornumberunitorstringorrange610 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_bracedcoord623 = new BitSet(new ulong[]{0x0001000000000000UL,0x000000000000C000UL});
    public static readonly BitSet FOLLOW_coord_in_bracedcoord627 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_bracedcoord629 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_numberunit_in_range640 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_range642 = new BitSet(new ulong[]{0x0000000030000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_range644 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_option_style668 = new BitSet(new ulong[]{0x0000600000000000UL});
    public static readonly BitSet FOLLOW_45_in_option_style671 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_46_in_option_style676 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_47_in_option_style678 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_option_style682 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_option_style684 = new BitSet(new ulong[]{0xFFE08AFFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_option_kv_in_option_style687 = new BitSet(new ulong[]{0x00000A0000000000UL});
    public static readonly BitSet FOLLOW_43_in_option_style690 = new BitSet(new ulong[]{0xFFE080FFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_option_kv_in_option_style692 = new BitSet(new ulong[]{0x00000A0000000000UL});
    public static readonly BitSet FOLLOW_43_in_option_style699 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_option_style702 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_heavenknowswhythisisnecessary_in_idd737 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_idd_heavenknowswhythisisnecessary757 = new BitSet(new ulong[]{0xFFE080FFFFFFFFF2UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_ID_in_idd2816 = new BitSet(new ulong[]{0x0000000008000002UL});
    public static readonly BitSet FOLLOW_number_in_numberunit839 = new BitSet(new ulong[]{0x07E0000000000002UL});
    public static readonly BitSet FOLLOW_unit_in_numberunit841 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_number867 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unit0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_set_start_in_tikz_set922 = new BitSet(new ulong[]{0xFFE082FFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_set925 = new BitSet(new ulong[]{0xFFE08AFFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_43_in_tikz_set928 = new BitSet(new ulong[]{0xFFE080FFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_set930 = new BitSet(new ulong[]{0xFFE08AFFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_43_in_tikz_set934 = new BitSet(new ulong[]{0xFFE082FFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_roundbr_end_in_tikz_set939 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzpicture_start_in_tikzpicture967 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpicture969 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzpicture972 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_tikzpicture_end_in_tikzpicture975 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody1005 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody1009 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_ext_in_tikzbody1013 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_tikzcoordinate_ext_in_tikzbody1017 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody1021 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody1025 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody1029 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody1034 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_dontcare_body_nobr_in_tikzbody1039 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody1050 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody1054 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_ext_in_tikzbody1058 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_tikzcoordinate_ext_in_tikzbody1062 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody1066 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody1070 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody1074 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody1079 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_dontcare_body_in_tikzbody1084 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body_nobr1101 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body1159 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_59_in_otherend1214 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_otherend1216 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_idd2_in_otherend1218 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_otherend1220 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzscope_start_in_tikzscope1247 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzscope1249 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzscope1252 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_tikzscope_end_in_tikzscope1255 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_in_tikzpath1310 = new BitSet(new ulong[]{0x0015010008000000UL,0x000000000001FFB0UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath1312 = new BitSet(new ulong[]{0x0015010008000000UL,0x000000000001FFB0UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzpath1315 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_in_tikzpath1334 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_tikzpath1336 = new BitSet(new ulong[]{0x0040000040000000UL});
    public static readonly BitSet FOLLOW_let_assignment_in_tikzpath1338 = new BitSet(new ulong[]{0x0040000040000000UL});
    public static readonly BitSet FOLLOW_54_in_tikzpath1341 = new BitSet(new ulong[]{0x0015010008000000UL,0x000000000001FFB0UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath1343 = new BitSet(new ulong[]{0x0015010008000000UL,0x000000000001FFB0UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzpath1346 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COMMAND_in_let_assignment1372 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_let_assignment1374 = new BitSet(new ulong[]{0x0005010008000002UL,0x000000000001FFB0UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_let_assignment1376 = new BitSet(new ulong[]{0x0005010008000002UL,0x000000000001FFB0UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpath_element1392 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_in_tikzpath_element1399 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_controls_in_tikzpath_element1405 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_int_in_tikzpath_element1411 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_int_in_tikzpath_element1417 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_circle_in_tikzpath_element1423 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arc_in_tikzpath_element1430 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_roundbr_start_in_tikzpath_element1437 = new BitSet(new ulong[]{0xFFE583FFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath_element1439 = new BitSet(new ulong[]{0xFFE583FFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_roundbr_end_in_tikzpath_element1442 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_edgeop_in_tikzpath_element1461 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_controls_start_in_controls1476 = new BitSet(new ulong[]{0x0001000000000000UL,0x000000000000C000UL});
    public static readonly BitSet FOLLOW_coord_in_controls1478 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010008UL});
    public static readonly BitSet FOLLOW_67_in_controls1481 = new BitSet(new ulong[]{0x0001000000000000UL,0x000000000000C000UL});
    public static readonly BitSet FOLLOW_coord_in_controls1483 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010008UL});
    public static readonly BitSet FOLLOW_controls_end_in_controls1487 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_node_start_in_tikznode_ext1513 = new BitSet(new ulong[]{0xFFE581FFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_core_in_tikznode_ext1515 = new BitSet(new ulong[]{0x0015010008000000UL,0x000000000001FFB0UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikznode_ext1517 = new BitSet(new ulong[]{0x0015010008000000UL,0x000000000001FFB0UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikznode_ext1520 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coordinate_start_in_tikzcoordinate_ext1548 = new BitSet(new ulong[]{0x0015010008000000UL,0x000000000001FFF0UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_ext1563 = new BitSet(new ulong[]{0x0015010008000000UL,0x000000000001FFB0UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_ext1582 = new BitSet(new ulong[]{0x0015010008000000UL,0x000000000001FFB0UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_ext1602 = new BitSet(new ulong[]{0x0015010008000000UL,0x000000000001FFB0UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzcoordinate_ext1613 = new BitSet(new ulong[]{0x0015010008000000UL,0x000000000001FFB0UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzcoordinate_ext1616 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_68_in_tikzcoordinate_int1676 = new BitSet(new ulong[]{0x0005000000000002UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_int1687 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_int1706 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_int1726 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_69_in_tikznode_int1742 = new BitSet(new ulong[]{0xFFE581FFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_core_in_tikznode_int1745 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikznode_core1755 = new BitSet(new ulong[]{0xFFE581FFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikznode_core1758 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core31783 = new BitSet(new ulong[]{0x0005000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core31785 = new BitSet(new ulong[]{0x0005000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core31787 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core21821 = new BitSet(new ulong[]{0x0005000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core21823 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core11856 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_tikznode_decorator1893 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_70_in_tikznode_decorator1900 = new BitSet(new ulong[]{0x0001000000000000UL,0x000000000000C000UL});
    public static readonly BitSet FOLLOW_coord_in_tikznode_decorator1903 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_options_dontcare_in_tikznode_decorator1909 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_50_in_tikz_options_dontcare1919 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_no_rlbracket_in_tikz_options_dontcare1921 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_tikz_options_dontcare_in_tikz_options_dontcare1925 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_no_rlbracket_in_tikz_options_dontcare1927 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_51_in_tikz_options_dontcare1932 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_no_rlbracket1950 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_48_in_nodename1967 = new BitSet(new ulong[]{0xFFE080FFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_idd_in_nodename1969 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_nodename1971 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_71_in_circle1995 = new BitSet(new ulong[]{0x0001000000000002UL});
    public static readonly BitSet FOLLOW_72_in_circle1999 = new BitSet(new ulong[]{0x0001000000000002UL});
    public static readonly BitSet FOLLOW_size_in_circle2008 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_73_in_arc2023 = new BitSet(new ulong[]{0x0001000000000002UL});
    public static readonly BitSet FOLLOW_48_in_arc2026 = new BitSet(new ulong[]{0x0000000030000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_arc2028 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_arc2030 = new BitSet(new ulong[]{0x0000000030000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_arc2032 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_arc2034 = new BitSet(new ulong[]{0x0000000030000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_arc2036 = new BitSet(new ulong[]{0x0002000000000000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_arc2039 = new BitSet(new ulong[]{0x0000000030000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_arc2041 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_arc2045 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_48_in_size2063 = new BitSet(new ulong[]{0x0000000030000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_size2065 = new BitSet(new ulong[]{0x0002000000000000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_size2068 = new BitSet(new ulong[]{0x0000000030000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_size2070 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_size2074 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_coord2104 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord2128 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_coord2131 = new BitSet(new ulong[]{0x0000000030000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord2133 = new BitSet(new ulong[]{0x0000180000000000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord2135 = new BitSet(new ulong[]{0x0000000030000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord2137 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_coord2139 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord2163 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_coord2166 = new BitSet(new ulong[]{0xFFE081FFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_coord2168 = new BitSet(new ulong[]{0x0000180000000000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord2170 = new BitSet(new ulong[]{0xFFE081FFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_coord2172 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_coord2174 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_coord_part2202 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_coord_part2217 = new BitSet(new ulong[]{0xFFE080FFFFFFFFF0UL,0x00000000000FFFFFUL});
    public static readonly BitSet FOLLOW_idd_in_coord_part2219 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_coord_part2221 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_coord_sep2243 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_edgeop0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_coord_modifier0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_50_in_squarebr_start2317 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_51_in_squarebr_end2335 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_semicolon_end2354 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_roundbr_start2372 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_41_in_roundbr_end2390 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_80_in_controls_start2408 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_81_in_controls_start2410 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_80_in_controls_end2428 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_tikz_set_start2446 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_tikz_set_start2448 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_37_in_tikzpicture_start2467 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_tikzpicture_start2469 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_82_in_tikzpicture_start2471 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_tikzpicture_start2473 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_59_in_tikzpicture_end2491 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_tikzpicture_end2493 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_82_in_tikzpicture_end2495 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_tikzpicture_end2497 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_37_in_tikzscope_start2515 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_tikzscope_start2517 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000080000UL});
    public static readonly BitSet FOLLOW_83_in_tikzscope_start2519 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_tikzscope_start2521 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_59_in_tikzscope_end2539 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_tikzscope_end2541 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000080000UL});
    public static readonly BitSet FOLLOW_83_in_tikzscope_end2543 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_tikzscope_end2545 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_tag_in_path_start2564 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_node_start_tag_in_node_start2582 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_60_in_node_start_tag2600 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_61_in_coordinate_start2610 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_path_start_tag0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_synpred1_simpletikz1559 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_synpred2_simpletikz1578 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_synpred3_simpletikz1598 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_synpred4_simpletikz1683 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_synpred5_simpletikz1702 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_synpred6_simpletikz1722 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_size_in_synpred7_simpletikz2004 = new BitSet(new ulong[]{0x0000000000000002UL});

}
