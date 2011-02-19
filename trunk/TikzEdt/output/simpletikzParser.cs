// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g 2011-02-19 11:30:03

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
    public const int T__86 = 86;
    public const int IM_NODE = 5;
    public const int IM_STYLE = 22;
    public const int IM_SCOPE = 12;
    public const int IM_NUMBERUNIT = 9;
    public const int WS = 32;
    public const int T__71 = 71;
    public const int T__72 = 72;
    public const int T__70 = 70;
    public const int T__38 = 38;
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:139:1: tikzdocument : ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* tikzpicture ( . )* -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture ) ;
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:140:2: ( ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* tikzpicture ( . )* -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:140:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* tikzpicture ( . )*
            {
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:140:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )*
            	do 
            	{
            	    int alt1 = 4;
            	    switch ( input.LA(1) ) 
            	    {
            	    case 38:
            	    	{
            	        int LA1_1 = input.LA(2);

            	        if ( (LA1_1 == 41) )
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
            	    case 84:
            	    case 85:
            	    case 86:
            	    	{
            	        alt1 = 1;
            	        }
            	        break;
            	    case TIKZEDT_CMD_COMMENT:
            	    case 39:
            	    case 40:
            	    	{
            	        alt1 = 2;
            	        }
            	        break;

            	    }

            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:140:5: dontcare_preamble
            			    {
            			    	PushFollow(FOLLOW_dontcare_preamble_in_tikzdocument256);
            			    	dontcare_preamble1 = dontcare_preamble();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_dontcare_preamble.Add(dontcare_preamble1.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:140:25: tikz_styleorsetorcmd
            			    {
            			    	PushFollow(FOLLOW_tikz_styleorsetorcmd_in_tikzdocument260);
            			    	tikz_styleorsetorcmd2 = tikz_styleorsetorcmd();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikz_styleorsetorcmd.Add(tikz_styleorsetorcmd2.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:140:48: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzdocument264);
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

            	PushFollow(FOLLOW_tikzpicture_in_tikzdocument269);
            	tikzpicture4 = tikzpicture();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzpicture.Add(tikzpicture4.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:140:74: ( . )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= IM_PATH && LA2_0 <= 86)) )
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
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:140:74: .
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
            	// 140:77: -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:140:80: ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DOCUMENT, "IM_DOCUMENT"), root_1);

            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:140:94: ( tikz_styleorsetorcmd )*
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:143:1: tikzdocument_wo_tikzpicture : ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* EOF -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* ) ;
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:144:2: ( ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* EOF -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:144:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* EOF
            {
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:144:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )*
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
            	    case 84:
            	    case 85:
            	    case 86:
            	    	{
            	        alt3 = 1;
            	        }
            	        break;
            	    case TIKZEDT_CMD_COMMENT:
            	    case 39:
            	    case 40:
            	    	{
            	        alt3 = 2;
            	        }
            	        break;
            	    case 38:
            	    	{
            	        alt3 = 3;
            	        }
            	        break;

            	    }

            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:144:5: dontcare_preamble
            			    {
            			    	PushFollow(FOLLOW_dontcare_preamble_in_tikzdocument_wo_tikzpicture295);
            			    	dontcare_preamble6 = dontcare_preamble();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_dontcare_preamble.Add(dontcare_preamble6.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:144:25: tikz_styleorsetorcmd
            			    {
            			    	PushFollow(FOLLOW_tikz_styleorsetorcmd_in_tikzdocument_wo_tikzpicture299);
            			    	tikz_styleorsetorcmd7 = tikz_styleorsetorcmd();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikz_styleorsetorcmd.Add(tikz_styleorsetorcmd7.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:144:48: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzdocument_wo_tikzpicture303);
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

            	EOF9=(IToken)Match(input,EOF,FOLLOW_EOF_in_tikzdocument_wo_tikzpicture308); if (state.failed) return retval; 
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
            	// 144:66: -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:144:69: ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DOCUMENT, "IM_DOCUMENT"), root_1);

            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:144:83: ( tikz_styleorsetorcmd )*
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:147:1: tikz_cmd_comment : TIKZEDT_CMD_COMMENT -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT ) ;
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:148:2: ( TIKZEDT_CMD_COMMENT -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:148:4: TIKZEDT_CMD_COMMENT
            {
            	TIKZEDT_CMD_COMMENT10=(IToken)Match(input,TIKZEDT_CMD_COMMENT,FOLLOW_TIKZEDT_CMD_COMMENT_in_tikz_cmd_comment329); if (state.failed) return retval; 
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
            	// 148:27: -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:148:30: ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:151:1: tikz_styleorsetorcmd : ( tikz_style | tikz_set | tikz_cmd_comment );
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:152:2: ( tikz_style | tikz_set | tikz_cmd_comment )
            int alt4 = 3;
            switch ( input.LA(1) ) 
            {
            case 39:
            	{
                alt4 = 1;
                }
                break;
            case 40:
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
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:152:4: tikz_style
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_style_in_tikz_styleorsetorcmd351);
                    	tikz_style11 = tikz_style();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style11.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:152:17: tikz_set
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_set_in_tikz_styleorsetorcmd355);
                    	tikz_set12 = tikz_set();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set12.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:152:28: tikz_cmd_comment
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_cmd_comment_in_tikz_styleorsetorcmd359);
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:155:1: dontcare_preamble : ~ ( '\\\\begin' | '\\\\tikzstyle' | '\\\\tikzset' | TIKZEDT_CMD_COMMENT ) ;
    public simpletikzParser.dontcare_preamble_return dontcare_preamble() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_preamble_return retval = new simpletikzParser.dontcare_preamble_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set14 = null;

        object set14_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:156:2: (~ ( '\\\\begin' | '\\\\tikzstyle' | '\\\\tikzset' | TIKZEDT_CMD_COMMENT ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:156:4: ~ ( '\\\\begin' | '\\\\tikzstyle' | '\\\\tikzset' | TIKZEDT_CMD_COMMENT )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set14 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= IM_ARC) || (input.LA(1) >= ID && input.LA(1) <= SOMETHING) || (input.LA(1) >= 41 && input.LA(1) <= 86) ) 
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:158:1: otherbegin : '\\\\begin' '{' idd2 '}' ;
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:159:2: ( '\\\\begin' '{' idd2 '}' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:159:4: '\\\\begin' '{' idd2 '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal15=(IToken)Match(input,38,FOLLOW_38_in_otherbegin395); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal15_tree = (object)adaptor.Create(string_literal15);
            		adaptor.AddChild(root_0, string_literal15_tree);
            	}
            	char_literal16=(IToken)Match(input,41,FOLLOW_41_in_otherbegin397); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal16_tree = (object)adaptor.Create(char_literal16);
            		adaptor.AddChild(root_0, char_literal16_tree);
            	}
            	PushFollow(FOLLOW_idd2_in_otherbegin399);
            	idd217 = idd2();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idd217.Tree);
            	char_literal18=(IToken)Match(input,42,FOLLOW_42_in_otherbegin401); if (state.failed) return retval;
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:162:1: tikz_style : '\\\\tikzstyle' '{' idd '}' ( '=' | '+=' ) tikz_options -> ^( IM_STYLE idd tikz_options ) ;
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
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:163:2: ( '\\\\tikzstyle' '{' idd '}' ( '=' | '+=' ) tikz_options -> ^( IM_STYLE idd tikz_options ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:163:4: '\\\\tikzstyle' '{' idd '}' ( '=' | '+=' ) tikz_options
            {
            	string_literal19=(IToken)Match(input,39,FOLLOW_39_in_tikz_style413); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_39.Add(string_literal19);

            	char_literal20=(IToken)Match(input,41,FOLLOW_41_in_tikz_style415); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(char_literal20);

            	PushFollow(FOLLOW_idd_in_tikz_style417);
            	idd21 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idd.Add(idd21.Tree);
            	char_literal22=(IToken)Match(input,42,FOLLOW_42_in_tikz_style419); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_42.Add(char_literal22);

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:163:30: ( '=' | '+=' )
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == 43) )
            	{
            	    alt5 = 1;
            	}
            	else if ( (LA5_0 == 44) )
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
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:163:31: '='
            	        {
            	        	char_literal23=(IToken)Match(input,43,FOLLOW_43_in_tikz_style422); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_43.Add(char_literal23);


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:163:37: '+='
            	        {
            	        	string_literal24=(IToken)Match(input,44,FOLLOW_44_in_tikz_style426); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_44.Add(string_literal24);


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikz_options_in_tikz_style429);
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
            	// 163:56: -> ^( IM_STYLE idd tikz_options )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:163:59: ^( IM_STYLE idd tikz_options )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:166:1: tikz_options : squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) ;
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

        simpletikzParser.squarebr_end_return squarebr_end31 = default(simpletikzParser.squarebr_end_return);


        object char_literal28_tree=null;
        object char_literal30_tree=null;
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleSubtreeStream stream_squarebr_start = new RewriteRuleSubtreeStream(adaptor,"rule squarebr_start");
        RewriteRuleSubtreeStream stream_squarebr_end = new RewriteRuleSubtreeStream(adaptor,"rule squarebr_end");
        RewriteRuleSubtreeStream stream_option = new RewriteRuleSubtreeStream(adaptor,"rule option");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:167:2: ( squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:167:5: squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end
            {
            	PushFollow(FOLLOW_squarebr_start_in_tikz_options451);
            	squarebr_start26 = squarebr_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_squarebr_start.Add(squarebr_start26.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:167:20: ( option ( ',' option )* ( ',' )? )?
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( ((LA8_0 >= IM_PATH && LA8_0 <= 40) || LA8_0 == 44 || LA8_0 == 49 || (LA8_0 >= 55 && LA8_0 <= 86)) )
            	{
            	    alt8 = 1;
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:167:21: option ( ',' option )* ( ',' )?
            	        {
            	        	PushFollow(FOLLOW_option_in_tikz_options454);
            	        	option27 = option();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_option.Add(option27.Tree);
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:167:28: ( ',' option )*
            	        	do 
            	        	{
            	        	    int alt6 = 2;
            	        	    int LA6_0 = input.LA(1);

            	        	    if ( (LA6_0 == 45) )
            	        	    {
            	        	        int LA6_1 = input.LA(2);

            	        	        if ( ((LA6_1 >= IM_PATH && LA6_1 <= 40) || LA6_1 == 44 || LA6_1 == 49 || (LA6_1 >= 55 && LA6_1 <= 86)) )
            	        	        {
            	        	            alt6 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt6) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:167:29: ',' option
            	        			    {
            	        			    	char_literal28=(IToken)Match(input,45,FOLLOW_45_in_tikz_options457); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_45.Add(char_literal28);

            	        			    	PushFollow(FOLLOW_option_in_tikz_options459);
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

            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:167:42: ( ',' )?
            	        	int alt7 = 2;
            	        	int LA7_0 = input.LA(1);

            	        	if ( (LA7_0 == 45) )
            	        	{
            	        	    alt7 = 1;
            	        	}
            	        	switch (alt7) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:167:42: ','
            	        	        {
            	        	        	char_literal30=(IToken)Match(input,45,FOLLOW_45_in_tikz_options463); if (state.failed) return retval; 
            	        	        	if ( (state.backtracking==0) ) stream_45.Add(char_literal30);


            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_squarebr_end_in_tikz_options468);
            	squarebr_end31 = squarebr_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_squarebr_end.Add(squarebr_end31.Tree);


            	// AST REWRITE
            	// elements:          squarebr_end, squarebr_start, option
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 167:63: -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:167:66: ^( IM_OPTIONS squarebr_start ( option )* squarebr_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTIONS, "IM_OPTIONS"), root_1);

            	    adaptor.AddChild(root_1, stream_squarebr_start.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:167:94: ( option )*
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:170:1: option : ( option_style | option_kv );
    public simpletikzParser.option_return option() // throws RecognitionException [1]
    {   
        simpletikzParser.option_return retval = new simpletikzParser.option_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.option_style_return option_style32 = default(simpletikzParser.option_style_return);

        simpletikzParser.option_kv_return option_kv33 = default(simpletikzParser.option_kv_return);



        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:171:2: ( option_style | option_kv )
            int alt9 = 2;
            alt9 = dfa9.Predict(input);
            switch (alt9) 
            {
                case 1 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:171:4: option_style
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_option_style_in_option493);
                    	option_style32 = option_style();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, option_style32.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:172:5: option_kv
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_option_kv_in_option502);
                    	option_kv33 = option_kv();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, option_kv33.Tree);

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:175:1: option_kv : idd ( '=' iddornumberunitorstringorrange )? -> ^( IM_OPTION_KV idd ( iddornumberunitorstringorrange )? ) ;
    public simpletikzParser.option_kv_return option_kv() // throws RecognitionException [1]
    {   
        simpletikzParser.option_kv_return retval = new simpletikzParser.option_kv_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal35 = null;
        simpletikzParser.idd_return idd34 = default(simpletikzParser.idd_return);

        simpletikzParser.iddornumberunitorstringorrange_return iddornumberunitorstringorrange36 = default(simpletikzParser.iddornumberunitorstringorrange_return);


        object char_literal35_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleSubtreeStream stream_iddornumberunitorstringorrange = new RewriteRuleSubtreeStream(adaptor,"rule iddornumberunitorstringorrange");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:176:2: ( idd ( '=' iddornumberunitorstringorrange )? -> ^( IM_OPTION_KV idd ( iddornumberunitorstringorrange )? ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:176:4: idd ( '=' iddornumberunitorstringorrange )?
            {
            	PushFollow(FOLLOW_idd_in_option_kv516);
            	idd34 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idd.Add(idd34.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:176:8: ( '=' iddornumberunitorstringorrange )?
            	int alt10 = 2;
            	int LA10_0 = input.LA(1);

            	if ( (LA10_0 == 43) )
            	{
            	    alt10 = 1;
            	}
            	switch (alt10) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:176:9: '=' iddornumberunitorstringorrange
            	        {
            	        	char_literal35=(IToken)Match(input,43,FOLLOW_43_in_option_kv519); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_43.Add(char_literal35);

            	        	PushFollow(FOLLOW_iddornumberunitorstringorrange_in_option_kv521);
            	        	iddornumberunitorstringorrange36 = iddornumberunitorstringorrange();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_iddornumberunitorstringorrange.Add(iddornumberunitorstringorrange36.Tree);

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
            	// 176:47: -> ^( IM_OPTION_KV idd ( iddornumberunitorstringorrange )? )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:176:50: ^( IM_OPTION_KV idd ( iddornumberunitorstringorrange )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTION_KV, "IM_OPTION_KV"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:176:69: ( iddornumberunitorstringorrange )?
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:179:1: tikzstring : '{' ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* '}' -> ^( IM_STRING '{' '}' ) ;
    public simpletikzParser.tikzstring_return tikzstring() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzstring_return retval = new simpletikzParser.tikzstring_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal37 = null;
        IToken char_literal41 = null;
        simpletikzParser.no_rlbrace_return no_rlbrace38 = default(simpletikzParser.no_rlbrace_return);

        simpletikzParser.tikzstring_return tikzstring39 = default(simpletikzParser.tikzstring_return);

        simpletikzParser.no_rlbrace_return no_rlbrace40 = default(simpletikzParser.no_rlbrace_return);


        object char_literal37_tree=null;
        object char_literal41_tree=null;
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleSubtreeStream stream_tikzstring = new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_no_rlbrace = new RewriteRuleSubtreeStream(adaptor,"rule no_rlbrace");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:180:2: ( '{' ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* '}' -> ^( IM_STRING '{' '}' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:180:4: '{' ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* '}'
            {
            	char_literal37=(IToken)Match(input,41,FOLLOW_41_in_tikzstring549); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(char_literal37);

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:180:8: ( no_rlbrace )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( ((LA11_0 >= IM_PATH && LA11_0 <= 40) || (LA11_0 >= 43 && LA11_0 <= 86)) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:180:8: no_rlbrace
            			    {
            			    	PushFollow(FOLLOW_no_rlbrace_in_tikzstring551);
            			    	no_rlbrace38 = no_rlbrace();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_no_rlbrace.Add(no_rlbrace38.Tree);

            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:180:20: ( tikzstring ( no_rlbrace )* )*
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( (LA13_0 == 41) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:180:21: tikzstring ( no_rlbrace )*
            			    {
            			    	PushFollow(FOLLOW_tikzstring_in_tikzstring555);
            			    	tikzstring39 = tikzstring();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikzstring.Add(tikzstring39.Tree);
            			    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:180:32: ( no_rlbrace )*
            			    	do 
            			    	{
            			    	    int alt12 = 2;
            			    	    int LA12_0 = input.LA(1);

            			    	    if ( ((LA12_0 >= IM_PATH && LA12_0 <= 40) || (LA12_0 >= 43 && LA12_0 <= 86)) )
            			    	    {
            			    	        alt12 = 1;
            			    	    }


            			    	    switch (alt12) 
            			    		{
            			    			case 1 :
            			    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:180:32: no_rlbrace
            			    			    {
            			    			    	PushFollow(FOLLOW_no_rlbrace_in_tikzstring557);
            			    			    	no_rlbrace40 = no_rlbrace();
            			    			    	state.followingStackPointer--;
            			    			    	if (state.failed) return retval;
            			    			    	if ( (state.backtracking==0) ) stream_no_rlbrace.Add(no_rlbrace40.Tree);

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop12;
            			    	    }
            			    	} while (true);

            			    	loop12:
            			    		;	// Stops C# compiler whining that label 'loop12' has no statements


            			    }
            			    break;

            			default:
            			    goto loop13;
            	    }
            	} while (true);

            	loop13:
            		;	// Stops C# compiler whining that label 'loop13' has no statements

            	char_literal41=(IToken)Match(input,42,FOLLOW_42_in_tikzstring562); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_42.Add(char_literal41);



            	// AST REWRITE
            	// elements:          41, 42
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 180:50: -> ^( IM_STRING '{' '}' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:180:53: ^( IM_STRING '{' '}' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STRING, "IM_STRING"), root_1);

            	    adaptor.AddChild(root_1, stream_41.NextNode());
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:183:1: no_rlbrace : ~ ( '{' | '}' ) ;
    public simpletikzParser.no_rlbrace_return no_rlbrace() // throws RecognitionException [1]
    {   
        simpletikzParser.no_rlbrace_return retval = new simpletikzParser.no_rlbrace_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set42 = null;

        object set42_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:184:2: (~ ( '{' | '}' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:184:4: ~ ( '{' | '}' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set42 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= 40) || (input.LA(1) >= 43 && input.LA(1) <= 86) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set42));
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:186:1: iddornumberunitorstringorrange : ( range | numberunit | bracedcoord | idd | tikzstring );
    public simpletikzParser.iddornumberunitorstringorrange_return iddornumberunitorstringorrange() // throws RecognitionException [1]
    {   
        simpletikzParser.iddornumberunitorstringorrange_return retval = new simpletikzParser.iddornumberunitorstringorrange_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.range_return range43 = default(simpletikzParser.range_return);

        simpletikzParser.numberunit_return numberunit44 = default(simpletikzParser.numberunit_return);

        simpletikzParser.bracedcoord_return bracedcoord45 = default(simpletikzParser.bracedcoord_return);

        simpletikzParser.idd_return idd46 = default(simpletikzParser.idd_return);

        simpletikzParser.tikzstring_return tikzstring47 = default(simpletikzParser.tikzstring_return);



        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:187:2: ( range | numberunit | bracedcoord | idd | tikzstring )
            int alt14 = 5;
            alt14 = dfa14.Predict(input);
            switch (alt14) 
            {
                case 1 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:187:5: range
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_range_in_iddornumberunitorstringorrange603);
                    	range43 = range();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, range43.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:187:13: numberunit
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_numberunit_in_iddornumberunitorstringorrange607);
                    	numberunit44 = numberunit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, numberunit44.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:187:26: bracedcoord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_bracedcoord_in_iddornumberunitorstringorrange611);
                    	bracedcoord45 = bracedcoord();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bracedcoord45.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:187:40: idd
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_idd_in_iddornumberunitorstringorrange615);
                    	idd46 = idd();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idd46.Tree);

                    }
                    break;
                case 5 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:187:46: tikzstring
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikzstring_in_iddornumberunitorstringorrange619);
                    	tikzstring47 = tikzstring();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzstring47.Tree);

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:189:1: bracedcoord : '{' coord '}' ;
    public simpletikzParser.bracedcoord_return bracedcoord() // throws RecognitionException [1]
    {   
        simpletikzParser.bracedcoord_return retval = new simpletikzParser.bracedcoord_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal48 = null;
        IToken char_literal50 = null;
        simpletikzParser.coord_return coord49 = default(simpletikzParser.coord_return);


        object char_literal48_tree=null;
        object char_literal50_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:190:2: ( '{' coord '}' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:190:4: '{' coord '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal48=(IToken)Match(input,41,FOLLOW_41_in_bracedcoord632); if (state.failed) return retval;
            	PushFollow(FOLLOW_coord_in_bracedcoord636);
            	coord49 = coord();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, coord49.Tree);
            	char_literal50=(IToken)Match(input,42,FOLLOW_42_in_bracedcoord638); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:192:1: range : numberunit ':' numberunit -> ^( IM_STRING numberunit ':' numberunit ) ;
    public simpletikzParser.range_return range() // throws RecognitionException [1]
    {   
        simpletikzParser.range_return retval = new simpletikzParser.range_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal52 = null;
        simpletikzParser.numberunit_return numberunit51 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit53 = default(simpletikzParser.numberunit_return);


        object char_literal52_tree=null;
        RewriteRuleTokenStream stream_46 = new RewriteRuleTokenStream(adaptor,"token 46");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:193:2: ( numberunit ':' numberunit -> ^( IM_STRING numberunit ':' numberunit ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:193:4: numberunit ':' numberunit
            {
            	PushFollow(FOLLOW_numberunit_in_range649);
            	numberunit51 = numberunit();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit51.Tree);
            	char_literal52=(IToken)Match(input,46,FOLLOW_46_in_range651); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_46.Add(char_literal52);

            	PushFollow(FOLLOW_numberunit_in_range653);
            	numberunit53 = numberunit();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit53.Tree);


            	// AST REWRITE
            	// elements:          numberunit, numberunit, 46
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 193:30: -> ^( IM_STRING numberunit ':' numberunit )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:193:33: ^( IM_STRING numberunit ':' numberunit )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STRING, "IM_STRING"), root_1);

            	    adaptor.AddChild(root_1, stream_numberunit.NextTree());
            	    adaptor.AddChild(root_1, stream_46.NextNode());
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:195:1: option_style : idd ( '/.style' | ( '/.append' 'style' ) ) '=' '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}' -> ^( IM_OPTION_STYLE idd ( option_kv )* ) ;
    public simpletikzParser.option_style_return option_style() // throws RecognitionException [1]
    {   
        simpletikzParser.option_style_return retval = new simpletikzParser.option_style_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal55 = null;
        IToken string_literal56 = null;
        IToken string_literal57 = null;
        IToken char_literal58 = null;
        IToken char_literal59 = null;
        IToken char_literal61 = null;
        IToken char_literal63 = null;
        IToken char_literal64 = null;
        simpletikzParser.idd_return idd54 = default(simpletikzParser.idd_return);

        simpletikzParser.option_kv_return option_kv60 = default(simpletikzParser.option_kv_return);

        simpletikzParser.option_kv_return option_kv62 = default(simpletikzParser.option_kv_return);


        object string_literal55_tree=null;
        object string_literal56_tree=null;
        object string_literal57_tree=null;
        object char_literal58_tree=null;
        object char_literal59_tree=null;
        object char_literal61_tree=null;
        object char_literal63_tree=null;
        object char_literal64_tree=null;
        RewriteRuleTokenStream stream_49 = new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_48 = new RewriteRuleTokenStream(adaptor,"token 48");
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_47 = new RewriteRuleTokenStream(adaptor,"token 47");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_option_kv = new RewriteRuleSubtreeStream(adaptor,"rule option_kv");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:196:2: ( idd ( '/.style' | ( '/.append' 'style' ) ) '=' '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}' -> ^( IM_OPTION_STYLE idd ( option_kv )* ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:196:4: idd ( '/.style' | ( '/.append' 'style' ) ) '=' '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}'
            {
            	PushFollow(FOLLOW_idd_in_option_style677);
            	idd54 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idd.Add(idd54.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:196:8: ( '/.style' | ( '/.append' 'style' ) )
            	int alt15 = 2;
            	int LA15_0 = input.LA(1);

            	if ( (LA15_0 == 47) )
            	{
            	    alt15 = 1;
            	}
            	else if ( (LA15_0 == 48) )
            	{
            	    alt15 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d15s0 =
            	        new NoViableAltException("", 15, 0, input);

            	    throw nvae_d15s0;
            	}
            	switch (alt15) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:196:9: '/.style'
            	        {
            	        	string_literal55=(IToken)Match(input,47,FOLLOW_47_in_option_style680); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_47.Add(string_literal55);


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:196:21: ( '/.append' 'style' )
            	        {
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:196:21: ( '/.append' 'style' )
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:196:22: '/.append' 'style'
            	        	{
            	        		string_literal56=(IToken)Match(input,48,FOLLOW_48_in_option_style685); if (state.failed) return retval; 
            	        		if ( (state.backtracking==0) ) stream_48.Add(string_literal56);

            	        		string_literal57=(IToken)Match(input,49,FOLLOW_49_in_option_style687); if (state.failed) return retval; 
            	        		if ( (state.backtracking==0) ) stream_49.Add(string_literal57);


            	        	}


            	        }
            	        break;

            	}

            	char_literal58=(IToken)Match(input,43,FOLLOW_43_in_option_style691); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_43.Add(char_literal58);

            	char_literal59=(IToken)Match(input,41,FOLLOW_41_in_option_style693); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(char_literal59);

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:196:51: ( option_kv ( ',' option_kv )* )?
            	int alt17 = 2;
            	int LA17_0 = input.LA(1);

            	if ( ((LA17_0 >= IM_PATH && LA17_0 <= 40) || LA17_0 == 44 || LA17_0 == 49 || (LA17_0 >= 55 && LA17_0 <= 86)) )
            	{
            	    alt17 = 1;
            	}
            	switch (alt17) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:196:52: option_kv ( ',' option_kv )*
            	        {
            	        	PushFollow(FOLLOW_option_kv_in_option_style696);
            	        	option_kv60 = option_kv();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_option_kv.Add(option_kv60.Tree);
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:196:62: ( ',' option_kv )*
            	        	do 
            	        	{
            	        	    int alt16 = 2;
            	        	    int LA16_0 = input.LA(1);

            	        	    if ( (LA16_0 == 45) )
            	        	    {
            	        	        int LA16_1 = input.LA(2);

            	        	        if ( ((LA16_1 >= IM_PATH && LA16_1 <= 40) || LA16_1 == 44 || LA16_1 == 49 || (LA16_1 >= 55 && LA16_1 <= 86)) )
            	        	        {
            	        	            alt16 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt16) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:196:63: ',' option_kv
            	        			    {
            	        			    	char_literal61=(IToken)Match(input,45,FOLLOW_45_in_option_style699); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_45.Add(char_literal61);

            	        			    	PushFollow(FOLLOW_option_kv_in_option_style701);
            	        			    	option_kv62 = option_kv();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( (state.backtracking==0) ) stream_option_kv.Add(option_kv62.Tree);

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

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:196:82: ( ',' )?
            	int alt18 = 2;
            	int LA18_0 = input.LA(1);

            	if ( (LA18_0 == 45) )
            	{
            	    alt18 = 1;
            	}
            	switch (alt18) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:196:82: ','
            	        {
            	        	char_literal63=(IToken)Match(input,45,FOLLOW_45_in_option_style708); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_45.Add(char_literal63);


            	        }
            	        break;

            	}

            	char_literal64=(IToken)Match(input,42,FOLLOW_42_in_option_style711); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_42.Add(char_literal64);



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
            	// 196:92: -> ^( IM_OPTION_STYLE idd ( option_kv )* )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:196:95: ^( IM_OPTION_STYLE idd ( option_kv )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTION_STYLE, "IM_OPTION_STYLE"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:196:117: ( option_kv )*
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:208:1: idd : idd_heavenknowswhythisisnecessary -> ^( IM_ID ) ;
    public simpletikzParser.idd_return idd() // throws RecognitionException [1]
    {   
        simpletikzParser.idd_return retval = new simpletikzParser.idd_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.idd_heavenknowswhythisisnecessary_return idd_heavenknowswhythisisnecessary65 = default(simpletikzParser.idd_heavenknowswhythisisnecessary_return);


        RewriteRuleSubtreeStream stream_idd_heavenknowswhythisisnecessary = new RewriteRuleSubtreeStream(adaptor,"rule idd_heavenknowswhythisisnecessary");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:209:2: ( idd_heavenknowswhythisisnecessary -> ^( IM_ID ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:209:4: idd_heavenknowswhythisisnecessary
            {
            	PushFollow(FOLLOW_idd_heavenknowswhythisisnecessary_in_idd746);
            	idd_heavenknowswhythisisnecessary65 = idd_heavenknowswhythisisnecessary();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idd_heavenknowswhythisisnecessary.Add(idd_heavenknowswhythisisnecessary65.Tree);


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
            	// 209:39: -> ^( IM_ID )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:209:42: ^( IM_ID )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:211:1: idd_heavenknowswhythisisnecessary : (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' ) )+ ;
    public simpletikzParser.idd_heavenknowswhythisisnecessary_return idd_heavenknowswhythisisnecessary() // throws RecognitionException [1]
    {   
        simpletikzParser.idd_heavenknowswhythisisnecessary_return retval = new simpletikzParser.idd_heavenknowswhythisisnecessary_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set66 = null;

        object set66_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:212:3: ( (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' ) )+ )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:212:6: (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' ) )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:212:6: (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' ) )+
            	int cnt19 = 0;
            	do 
            	{
            	    int alt19 = 2;
            	    int LA19_0 = input.LA(1);

            	    if ( ((LA19_0 >= IM_PATH && LA19_0 <= 40) || LA19_0 == 44 || LA19_0 == 49 || (LA19_0 >= 55 && LA19_0 <= 86)) )
            	    {
            	        alt19 = 1;
            	    }


            	    switch (alt19) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:212:6: ~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' )
            			    {
            			    	set66 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= 40) || input.LA(1) == 44 || input.LA(1) == 49 || (input.LA(1) >= 55 && input.LA(1) <= 86) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set66));
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


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:213:1: idd2 : ( ID )+ -> ^( IM_ID ) ;
    public simpletikzParser.idd2_return idd2() // throws RecognitionException [1]
    {   
        simpletikzParser.idd2_return retval = new simpletikzParser.idd2_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID67 = null;

        object ID67_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:214:2: ( ( ID )+ -> ^( IM_ID ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:214:4: ( ID )+
            {
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:214:4: ( ID )+
            	int cnt20 = 0;
            	do 
            	{
            	    int alt20 = 2;
            	    int LA20_0 = input.LA(1);

            	    if ( (LA20_0 == ID) )
            	    {
            	        alt20 = 1;
            	    }


            	    switch (alt20) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:214:4: ID
            			    {
            			    	ID67=(IToken)Match(input,ID,FOLLOW_ID_in_idd2825); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_ID.Add(ID67);


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
            	// 214:8: -> ^( IM_ID )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:214:11: ^( IM_ID )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:217:1: numberunitorvariable : ( numberunit | COMMAND );
    public simpletikzParser.numberunitorvariable_return numberunitorvariable() // throws RecognitionException [1]
    {   
        simpletikzParser.numberunitorvariable_return retval = new simpletikzParser.numberunitorvariable_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken COMMAND69 = null;
        simpletikzParser.numberunit_return numberunit68 = default(simpletikzParser.numberunit_return);


        object COMMAND69_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:218:2: ( numberunit | COMMAND )
            int alt21 = 2;
            int LA21_0 = input.LA(1);

            if ( ((LA21_0 >= FLOAT_WO_EXP && LA21_0 <= INT)) )
            {
                alt21 = 1;
            }
            else if ( (LA21_0 == COMMAND) )
            {
                alt21 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d21s0 =
                    new NoViableAltException("", 21, 0, input);

                throw nvae_d21s0;
            }
            switch (alt21) 
            {
                case 1 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:218:4: numberunit
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_numberunit_in_numberunitorvariable844);
                    	numberunit68 = numberunit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, numberunit68.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:219:4: COMMAND
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	COMMAND69=(IToken)Match(input,COMMAND,FOLLOW_COMMAND_in_numberunitorvariable849); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{COMMAND69_tree = (object)adaptor.Create(COMMAND69);
                    		adaptor.AddChild(root_0, COMMAND69_tree);
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:222:1: numberunit : number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) ;
    public simpletikzParser.numberunit_return numberunit() // throws RecognitionException [1]
    {   
        simpletikzParser.numberunit_return retval = new simpletikzParser.numberunit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.number_return number70 = default(simpletikzParser.number_return);

        simpletikzParser.unit_return unit71 = default(simpletikzParser.unit_return);


        RewriteRuleSubtreeStream stream_unit = new RewriteRuleSubtreeStream(adaptor,"rule unit");
        RewriteRuleSubtreeStream stream_number = new RewriteRuleSubtreeStream(adaptor,"rule number");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:223:2: ( number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:223:4: number ( unit )?
            {
            	PushFollow(FOLLOW_number_in_numberunit862);
            	number70 = number();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_number.Add(number70.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:223:11: ( unit )?
            	int alt22 = 2;
            	int LA22_0 = input.LA(1);

            	if ( ((LA22_0 >= 55 && LA22_0 <= 60)) )
            	{
            	    alt22 = 1;
            	}
            	switch (alt22) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:223:11: unit
            	        {
            	        	PushFollow(FOLLOW_unit_in_numberunit864);
            	        	unit71 = unit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_unit.Add(unit71.Tree);

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
            	// 223:17: -> ^( IM_NUMBERUNIT number ( unit )? )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:223:20: ^( IM_NUMBERUNIT number ( unit )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NUMBERUNIT, "IM_NUMBERUNIT"), root_1);

            	    adaptor.AddChild(root_1, stream_number.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:223:43: ( unit )?
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:227:1: number : ( FLOAT_WO_EXP | INT ) ;
    public simpletikzParser.number_return number() // throws RecognitionException [1]
    {   
        simpletikzParser.number_return retval = new simpletikzParser.number_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set72 = null;

        object set72_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:228:2: ( ( FLOAT_WO_EXP | INT ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:228:4: ( FLOAT_WO_EXP | INT )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set72 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= FLOAT_WO_EXP && input.LA(1) <= INT) ) 
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

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:231:1: unit : ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' | 'em' );
    public simpletikzParser.unit_return unit() // throws RecognitionException [1]
    {   
        simpletikzParser.unit_return retval = new simpletikzParser.unit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set73 = null;

        object set73_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:232:2: ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' | 'em' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set73 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 55 && input.LA(1) <= 60) ) 
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:235:1: tikz_set : tikz_set_start ( option ( ',' option )* ( ',' )? )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) ;
    public simpletikzParser.tikz_set_return tikz_set() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_set_return retval = new simpletikzParser.tikz_set_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal76 = null;
        IToken char_literal78 = null;
        simpletikzParser.tikz_set_start_return tikz_set_start74 = default(simpletikzParser.tikz_set_start_return);

        simpletikzParser.option_return option75 = default(simpletikzParser.option_return);

        simpletikzParser.option_return option77 = default(simpletikzParser.option_return);

        simpletikzParser.roundbr_end_return roundbr_end79 = default(simpletikzParser.roundbr_end_return);


        object char_literal76_tree=null;
        object char_literal78_tree=null;
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleSubtreeStream stream_tikz_set_start = new RewriteRuleSubtreeStream(adaptor,"rule tikz_set_start");
        RewriteRuleSubtreeStream stream_roundbr_end = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        RewriteRuleSubtreeStream stream_option = new RewriteRuleSubtreeStream(adaptor,"rule option");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:236:2: ( tikz_set_start ( option ( ',' option )* ( ',' )? )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:236:5: tikz_set_start ( option ( ',' option )* ( ',' )? )? roundbr_end
            {
            	PushFollow(FOLLOW_tikz_set_start_in_tikz_set945);
            	tikz_set_start74 = tikz_set_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikz_set_start.Add(tikz_set_start74.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:236:20: ( option ( ',' option )* ( ',' )? )?
            	int alt25 = 2;
            	int LA25_0 = input.LA(1);

            	if ( ((LA25_0 >= IM_PATH && LA25_0 <= 40) || LA25_0 == 44 || LA25_0 == 49 || (LA25_0 >= 55 && LA25_0 <= 86)) )
            	{
            	    alt25 = 1;
            	}
            	switch (alt25) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:236:21: option ( ',' option )* ( ',' )?
            	        {
            	        	PushFollow(FOLLOW_option_in_tikz_set948);
            	        	option75 = option();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_option.Add(option75.Tree);
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:236:28: ( ',' option )*
            	        	do 
            	        	{
            	        	    int alt23 = 2;
            	        	    int LA23_0 = input.LA(1);

            	        	    if ( (LA23_0 == 45) )
            	        	    {
            	        	        int LA23_1 = input.LA(2);

            	        	        if ( ((LA23_1 >= IM_PATH && LA23_1 <= 40) || LA23_1 == 44 || LA23_1 == 49 || (LA23_1 >= 55 && LA23_1 <= 86)) )
            	        	        {
            	        	            alt23 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt23) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:236:29: ',' option
            	        			    {
            	        			    	char_literal76=(IToken)Match(input,45,FOLLOW_45_in_tikz_set951); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_45.Add(char_literal76);

            	        			    	PushFollow(FOLLOW_option_in_tikz_set953);
            	        			    	option77 = option();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( (state.backtracking==0) ) stream_option.Add(option77.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop23;
            	        	    }
            	        	} while (true);

            	        	loop23:
            	        		;	// Stops C# compiler whining that label 'loop23' has no statements

            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:236:42: ( ',' )?
            	        	int alt24 = 2;
            	        	int LA24_0 = input.LA(1);

            	        	if ( (LA24_0 == 45) )
            	        	{
            	        	    alt24 = 1;
            	        	}
            	        	switch (alt24) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:236:42: ','
            	        	        {
            	        	        	char_literal78=(IToken)Match(input,45,FOLLOW_45_in_tikz_set957); if (state.failed) return retval; 
            	        	        	if ( (state.backtracking==0) ) stream_45.Add(char_literal78);


            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_roundbr_end_in_tikz_set962);
            	roundbr_end79 = roundbr_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_roundbr_end.Add(roundbr_end79.Tree);


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
            	// 236:61: -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:236:64: ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_TIKZSET, "IM_TIKZSET"), root_1);

            	    adaptor.AddChild(root_1, stream_tikz_set_start.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:236:92: ( option )*
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:241:1: tikzpicture : tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) ;
    public simpletikzParser.tikzpicture_return tikzpicture() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_return retval = new simpletikzParser.tikzpicture_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzpicture_start_return tikzpicture_start80 = default(simpletikzParser.tikzpicture_start_return);

        simpletikzParser.tikz_options_return tikz_options81 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody_return tikzbody82 = default(simpletikzParser.tikzbody_return);

        simpletikzParser.tikzpicture_end_return tikzpicture_end83 = default(simpletikzParser.tikzpicture_end_return);


        RewriteRuleSubtreeStream stream_tikzpicture_end = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_end");
        RewriteRuleSubtreeStream stream_tikzpicture_start = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_start");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:242:2: ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:242:5: tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end
            {
            	PushFollow(FOLLOW_tikzpicture_start_in_tikzpicture990);
            	tikzpicture_start80 = tikzpicture_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzpicture_start.Add(tikzpicture_start80.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:242:23: ( tikz_options )?
            	int alt26 = 2;
            	int LA26_0 = input.LA(1);

            	if ( (LA26_0 == 52) )
            	{
            	    alt26 = 1;
            	}
            	switch (alt26) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:242:23: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_tikzpicture992);
            	        	tikz_options81 = tikz_options();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_tikz_options.Add(tikz_options81.Tree);

            	        }
            	        break;

            	}

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:242:37: ( tikzbody )?
            	int alt27 = 2;
            	int LA27_0 = input.LA(1);

            	if ( ((LA27_0 >= IM_PATH && LA27_0 <= 51) || (LA27_0 >= 53 && LA27_0 <= 60) || (LA27_0 >= 62 && LA27_0 <= 86)) )
            	{
            	    alt27 = 1;
            	}
            	else if ( (LA27_0 == 61) )
            	{
            	    int LA27_2 = input.LA(2);

            	    if ( (LA27_2 == 41) )
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
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:242:37: tikzbody
            	        {
            	        	PushFollow(FOLLOW_tikzbody_in_tikzpicture995);
            	        	tikzbody82 = tikzbody();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_tikzbody.Add(tikzbody82.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzpicture_end_in_tikzpicture998);
            	tikzpicture_end83 = tikzpicture_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzpicture_end.Add(tikzpicture_end83.Tree);


            	// AST REWRITE
            	// elements:          tikzpicture_end, tikzpicture_start, tikz_options, tikzbody
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 242:64: -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:242:67: ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PICTURE, "IM_PICTURE"), root_1);

            	    adaptor.AddChild(root_1, stream_tikzpicture_start.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:242:98: ( tikz_options )?
            	    if ( stream_tikz_options.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikz_options.NextTree());

            	    }
            	    stream_tikz_options.Reset();
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:242:112: ( tikzbody )?
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:245:1: tikzbody : ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )* ;
    public simpletikzParser.tikzbody_return tikzbody() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzbody_return retval = new simpletikzParser.tikzbody_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_return tikzscope84 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath85 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznode_ext_return tikznode_ext86 = default(simpletikzParser.tikznode_ext_return);

        simpletikzParser.tikzmatrix_ext_return tikzmatrix_ext87 = default(simpletikzParser.tikzmatrix_ext_return);

        simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext88 = default(simpletikzParser.tikzcoordinate_ext_return);

        simpletikzParser.tikz_set_return tikz_set89 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style90 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin91 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend92 = default(simpletikzParser.otherend_return);

        simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr93 = default(simpletikzParser.dontcare_body_nobr_return);

        simpletikzParser.tikzscope_return tikzscope94 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath95 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznode_ext_return tikznode_ext96 = default(simpletikzParser.tikznode_ext_return);

        simpletikzParser.tikzmatrix_ext_return tikzmatrix_ext97 = default(simpletikzParser.tikzmatrix_ext_return);

        simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext98 = default(simpletikzParser.tikzcoordinate_ext_return);

        simpletikzParser.tikz_set_return tikz_set99 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style100 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin101 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend102 = default(simpletikzParser.otherend_return);

        simpletikzParser.dontcare_body_return dontcare_body103 = default(simpletikzParser.dontcare_body_return);



        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:246:2: ( ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )* )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:246:4: ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:246:4: ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr )
            	int alt28 = 10;
            	alt28 = dfa28.Predict(input);
            	switch (alt28) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:246:6: tikzscope
            	        {
            	        	PushFollow(FOLLOW_tikzscope_in_tikzbody1028);
            	        	tikzscope84 = tikzscope();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzscope84.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:246:18: tikzpath
            	        {
            	        	PushFollow(FOLLOW_tikzpath_in_tikzbody1032);
            	        	tikzpath85 = tikzpath();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath85.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:246:29: tikznode_ext
            	        {
            	        	PushFollow(FOLLOW_tikznode_ext_in_tikzbody1036);
            	        	tikznode_ext86 = tikznode_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_ext86.Tree);

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:246:44: tikzmatrix_ext
            	        {
            	        	PushFollow(FOLLOW_tikzmatrix_ext_in_tikzbody1040);
            	        	tikzmatrix_ext87 = tikzmatrix_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzmatrix_ext87.Tree);

            	        }
            	        break;
            	    case 5 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:246:61: tikzcoordinate_ext
            	        {
            	        	PushFollow(FOLLOW_tikzcoordinate_ext_in_tikzbody1044);
            	        	tikzcoordinate_ext88 = tikzcoordinate_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_ext88.Tree);

            	        }
            	        break;
            	    case 6 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:246:82: tikz_set
            	        {
            	        	PushFollow(FOLLOW_tikz_set_in_tikzbody1048);
            	        	tikz_set89 = tikz_set();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set89.Tree);

            	        }
            	        break;
            	    case 7 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:246:93: tikz_style
            	        {
            	        	PushFollow(FOLLOW_tikz_style_in_tikzbody1052);
            	        	tikz_style90 = tikz_style();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style90.Tree);

            	        }
            	        break;
            	    case 8 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:246:106: otherbegin
            	        {
            	        	PushFollow(FOLLOW_otherbegin_in_tikzbody1056);
            	        	otherbegin91 = otherbegin();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;
            	    case 9 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:246:120: otherend
            	        {
            	        	PushFollow(FOLLOW_otherend_in_tikzbody1061);
            	        	otherend92 = otherend();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;
            	    case 10 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:246:132: dontcare_body_nobr
            	        {
            	        	PushFollow(FOLLOW_dontcare_body_nobr_in_tikzbody1066);
            	        	dontcare_body_nobr93 = dontcare_body_nobr();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;

            	}

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:247:3: ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*
            	do 
            	{
            	    int alt29 = 11;
            	    alt29 = dfa29.Predict(input);
            	    switch (alt29) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:247:5: tikzscope
            			    {
            			    	PushFollow(FOLLOW_tikzscope_in_tikzbody1077);
            			    	tikzscope94 = tikzscope();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzscope94.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:247:17: tikzpath
            			    {
            			    	PushFollow(FOLLOW_tikzpath_in_tikzbody1081);
            			    	tikzpath95 = tikzpath();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath95.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:247:28: tikznode_ext
            			    {
            			    	PushFollow(FOLLOW_tikznode_ext_in_tikzbody1085);
            			    	tikznode_ext96 = tikznode_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_ext96.Tree);

            			    }
            			    break;
            			case 4 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:247:43: tikzmatrix_ext
            			    {
            			    	PushFollow(FOLLOW_tikzmatrix_ext_in_tikzbody1089);
            			    	tikzmatrix_ext97 = tikzmatrix_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzmatrix_ext97.Tree);

            			    }
            			    break;
            			case 5 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:247:60: tikzcoordinate_ext
            			    {
            			    	PushFollow(FOLLOW_tikzcoordinate_ext_in_tikzbody1093);
            			    	tikzcoordinate_ext98 = tikzcoordinate_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_ext98.Tree);

            			    }
            			    break;
            			case 6 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:247:81: tikz_set
            			    {
            			    	PushFollow(FOLLOW_tikz_set_in_tikzbody1097);
            			    	tikz_set99 = tikz_set();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set99.Tree);

            			    }
            			    break;
            			case 7 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:247:92: tikz_style
            			    {
            			    	PushFollow(FOLLOW_tikz_style_in_tikzbody1101);
            			    	tikz_style100 = tikz_style();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style100.Tree);

            			    }
            			    break;
            			case 8 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:247:105: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzbody1105);
            			    	otherbegin101 = otherbegin();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;
            			case 9 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:247:119: otherend
            			    {
            			    	PushFollow(FOLLOW_otherend_in_tikzbody1110);
            			    	otherend102 = otherend();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;
            			case 10 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:247:131: dontcare_body
            			    {
            			    	PushFollow(FOLLOW_dontcare_body_in_tikzbody1115);
            			    	dontcare_body103 = dontcare_body();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

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

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:250:1: dontcare_body_nobr : (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) ) ;
    public simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body_nobr_return retval = new simpletikzParser.dontcare_body_nobr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set104 = null;

        object set104_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:251:2: ( (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:251:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:251:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) )
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:251:5: ~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' )
            	{
            		set104 = (IToken)input.LT(1);
            		if ( (input.LA(1) >= IM_PATH && input.LA(1) <= SOMETHING) || (input.LA(1) >= 41 && input.LA(1) <= 51) || (input.LA(1) >= 53 && input.LA(1) <= 60) || (input.LA(1) >= 69 && input.LA(1) <= 86) ) 
            		{
            		    input.Consume();
            		    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set104));
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:253:1: dontcare_body : (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) ) ;
    public simpletikzParser.dontcare_body_return dontcare_body() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body_return retval = new simpletikzParser.dontcare_body_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set105 = null;

        object set105_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:254:2: ( (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:254:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:254:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) )
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:254:5: ~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' )
            	{
            		set105 = (IToken)input.LT(1);
            		if ( (input.LA(1) >= IM_PATH && input.LA(1) <= SOMETHING) || (input.LA(1) >= 41 && input.LA(1) <= 60) || (input.LA(1) >= 69 && input.LA(1) <= 86) ) 
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:256:1: otherend : '\\\\end' '{' idd2 '}' ;
    public simpletikzParser.otherend_return otherend() // throws RecognitionException [1]
    {   
        simpletikzParser.otherend_return retval = new simpletikzParser.otherend_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal106 = null;
        IToken char_literal107 = null;
        IToken char_literal109 = null;
        simpletikzParser.idd2_return idd2108 = default(simpletikzParser.idd2_return);


        object string_literal106_tree=null;
        object char_literal107_tree=null;
        object char_literal109_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:257:2: ( '\\\\end' '{' idd2 '}' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:257:4: '\\\\end' '{' idd2 '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal106=(IToken)Match(input,61,FOLLOW_61_in_otherend1253); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal106_tree = (object)adaptor.Create(string_literal106);
            		adaptor.AddChild(root_0, string_literal106_tree);
            	}
            	char_literal107=(IToken)Match(input,41,FOLLOW_41_in_otherend1255); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal107_tree = (object)adaptor.Create(char_literal107);
            		adaptor.AddChild(root_0, char_literal107_tree);
            	}
            	PushFollow(FOLLOW_idd2_in_otherend1257);
            	idd2108 = idd2();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idd2108.Tree);
            	char_literal109=(IToken)Match(input,42,FOLLOW_42_in_otherend1259); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal109_tree = (object)adaptor.Create(char_literal109);
            		adaptor.AddChild(root_0, char_literal109_tree);
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:271:1: tikzscope : tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end ) ;
    public simpletikzParser.tikzscope_return tikzscope() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_return retval = new simpletikzParser.tikzscope_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_start_return tikzscope_start110 = default(simpletikzParser.tikzscope_start_return);

        simpletikzParser.tikz_options_return tikz_options111 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody_return tikzbody112 = default(simpletikzParser.tikzbody_return);

        simpletikzParser.tikzscope_end_return tikzscope_end113 = default(simpletikzParser.tikzscope_end_return);


        RewriteRuleSubtreeStream stream_tikzscope_start = new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_start");
        RewriteRuleSubtreeStream stream_tikzscope_end = new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_end");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:272:2: ( tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:272:4: tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end
            {
            	PushFollow(FOLLOW_tikzscope_start_in_tikzscope1286);
            	tikzscope_start110 = tikzscope_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzscope_start.Add(tikzscope_start110.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:272:20: ( tikz_options )?
            	int alt30 = 2;
            	int LA30_0 = input.LA(1);

            	if ( (LA30_0 == 52) )
            	{
            	    alt30 = 1;
            	}
            	switch (alt30) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:272:20: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_tikzscope1288);
            	        	tikz_options111 = tikz_options();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_tikz_options.Add(tikz_options111.Tree);

            	        }
            	        break;

            	}

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:272:34: ( tikzbody )?
            	int alt31 = 2;
            	int LA31_0 = input.LA(1);

            	if ( ((LA31_0 >= IM_PATH && LA31_0 <= 51) || (LA31_0 >= 53 && LA31_0 <= 60) || (LA31_0 >= 62 && LA31_0 <= 86)) )
            	{
            	    alt31 = 1;
            	}
            	else if ( (LA31_0 == 61) )
            	{
            	    int LA31_2 = input.LA(2);

            	    if ( (LA31_2 == 41) )
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
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:272:34: tikzbody
            	        {
            	        	PushFollow(FOLLOW_tikzbody_in_tikzscope1291);
            	        	tikzbody112 = tikzbody();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_tikzbody.Add(tikzbody112.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzscope_end_in_tikzscope1294);
            	tikzscope_end113 = tikzscope_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzscope_end.Add(tikzscope_end113.Tree);


            	// AST REWRITE
            	// elements:          tikz_options, tikzbody, tikzscope_start, tikzscope_end
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 272:59: -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:272:62: ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_SCOPE, "IM_SCOPE"), root_1);

            	    adaptor.AddChild(root_1, stream_tikzscope_start.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:272:89: ( tikz_options )?
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:298:1: tikzpath : ( path_start ( tikzpath_element )* semicolon_end -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end ) | path_start 'let' ( let_assignment )* 'in' ( COMMAND tikzstring )? ( tikzpath_element )* semicolon_end -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end ) );
    public simpletikzParser.tikzpath_return tikzpath() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_return retval = new simpletikzParser.tikzpath_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal118 = null;
        IToken string_literal120 = null;
        IToken COMMAND121 = null;
        simpletikzParser.path_start_return path_start114 = default(simpletikzParser.path_start_return);

        simpletikzParser.tikzpath_element_return tikzpath_element115 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end116 = default(simpletikzParser.semicolon_end_return);

        simpletikzParser.path_start_return path_start117 = default(simpletikzParser.path_start_return);

        simpletikzParser.let_assignment_return let_assignment119 = default(simpletikzParser.let_assignment_return);

        simpletikzParser.tikzstring_return tikzstring122 = default(simpletikzParser.tikzstring_return);

        simpletikzParser.tikzpath_element_return tikzpath_element123 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end124 = default(simpletikzParser.semicolon_end_return);


        object string_literal118_tree=null;
        object string_literal120_tree=null;
        object COMMAND121_tree=null;
        RewriteRuleTokenStream stream_69 = new RewriteRuleTokenStream(adaptor,"token 69");
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleTokenStream stream_COMMAND = new RewriteRuleTokenStream(adaptor,"token COMMAND");
        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_tikzstring = new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_path_start = new RewriteRuleSubtreeStream(adaptor,"rule path_start");
        RewriteRuleSubtreeStream stream_let_assignment = new RewriteRuleSubtreeStream(adaptor,"rule let_assignment");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:299:2: ( path_start ( tikzpath_element )* semicolon_end -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end ) | path_start 'let' ( let_assignment )* 'in' ( COMMAND tikzstring )? ( tikzpath_element )* semicolon_end -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end ) )
            int alt36 = 2;
            int LA36_0 = input.LA(1);

            if ( ((LA36_0 >= 65 && LA36_0 <= 68)) )
            {
                int LA36_1 = input.LA(2);

                if ( (LA36_1 == ID || LA36_1 == 41 || LA36_1 == 50 || LA36_1 == 52 || LA36_1 == 54 || (LA36_1 >= 71 && LA36_1 <= 72) || (LA36_1 >= 74 && LA36_1 <= 83)) )
                {
                    alt36 = 1;
                }
                else if ( (LA36_1 == 69) )
                {
                    alt36 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d36s1 =
                        new NoViableAltException("", 36, 1, input);

                    throw nvae_d36s1;
                }
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
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:299:4: path_start ( tikzpath_element )* semicolon_end
                    {
                    	PushFollow(FOLLOW_path_start_in_tikzpath1349);
                    	path_start114 = path_start();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_path_start.Add(path_start114.Tree);
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:299:15: ( tikzpath_element )*
                    	do 
                    	{
                    	    int alt32 = 2;
                    	    int LA32_0 = input.LA(1);

                    	    if ( (LA32_0 == ID || LA32_0 == 41 || LA32_0 == 50 || LA32_0 == 52 || (LA32_0 >= 71 && LA32_0 <= 72) || (LA32_0 >= 74 && LA32_0 <= 83)) )
                    	    {
                    	        alt32 = 1;
                    	    }


                    	    switch (alt32) 
                    		{
                    			case 1 :
                    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:299:15: tikzpath_element
                    			    {
                    			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath1351);
                    			    	tikzpath_element115 = tikzpath_element();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element115.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop32;
                    	    }
                    	} while (true);

                    	loop32:
                    		;	// Stops C# compiler whining that label 'loop32' has no statements

                    	PushFollow(FOLLOW_semicolon_end_in_tikzpath1354);
                    	semicolon_end116 = semicolon_end();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_semicolon_end.Add(semicolon_end116.Tree);


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
                    	// 299:47: -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end )
                    	{
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:299:50: ^( IM_PATH path_start ( tikzpath_element )* semicolon_end )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

                    	    adaptor.AddChild(root_1, stream_path_start.NextTree());
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:299:71: ( tikzpath_element )*
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
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:300:4: path_start 'let' ( let_assignment )* 'in' ( COMMAND tikzstring )? ( tikzpath_element )* semicolon_end
                    {
                    	PushFollow(FOLLOW_path_start_in_tikzpath1373);
                    	path_start117 = path_start();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_path_start.Add(path_start117.Tree);
                    	string_literal118=(IToken)Match(input,69,FOLLOW_69_in_tikzpath1375); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_69.Add(string_literal118);

                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:300:21: ( let_assignment )*
                    	do 
                    	{
                    	    int alt33 = 2;
                    	    int LA33_0 = input.LA(1);

                    	    if ( (LA33_0 == COMMAND) )
                    	    {
                    	        alt33 = 1;
                    	    }


                    	    switch (alt33) 
                    		{
                    			case 1 :
                    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:300:21: let_assignment
                    			    {
                    			    	PushFollow(FOLLOW_let_assignment_in_tikzpath1377);
                    			    	let_assignment119 = let_assignment();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_let_assignment.Add(let_assignment119.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop33;
                    	    }
                    	} while (true);

                    	loop33:
                    		;	// Stops C# compiler whining that label 'loop33' has no statements

                    	string_literal120=(IToken)Match(input,56,FOLLOW_56_in_tikzpath1380); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_56.Add(string_literal120);

                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:300:42: ( COMMAND tikzstring )?
                    	int alt34 = 2;
                    	int LA34_0 = input.LA(1);

                    	if ( (LA34_0 == COMMAND) )
                    	{
                    	    alt34 = 1;
                    	}
                    	switch (alt34) 
                    	{
                    	    case 1 :
                    	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:300:43: COMMAND tikzstring
                    	        {
                    	        	COMMAND121=(IToken)Match(input,COMMAND,FOLLOW_COMMAND_in_tikzpath1383); if (state.failed) return retval; 
                    	        	if ( (state.backtracking==0) ) stream_COMMAND.Add(COMMAND121);

                    	        	PushFollow(FOLLOW_tikzstring_in_tikzpath1385);
                    	        	tikzstring122 = tikzstring();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_tikzstring.Add(tikzstring122.Tree);

                    	        }
                    	        break;

                    	}

                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:300:64: ( tikzpath_element )*
                    	do 
                    	{
                    	    int alt35 = 2;
                    	    int LA35_0 = input.LA(1);

                    	    if ( (LA35_0 == ID || LA35_0 == 41 || LA35_0 == 50 || LA35_0 == 52 || (LA35_0 >= 71 && LA35_0 <= 72) || (LA35_0 >= 74 && LA35_0 <= 83)) )
                    	    {
                    	        alt35 = 1;
                    	    }


                    	    switch (alt35) 
                    		{
                    			case 1 :
                    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:300:64: tikzpath_element
                    			    {
                    			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath1389);
                    			    	tikzpath_element123 = tikzpath_element();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element123.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop35;
                    	    }
                    	} while (true);

                    	loop35:
                    		;	// Stops C# compiler whining that label 'loop35' has no statements

                    	PushFollow(FOLLOW_semicolon_end_in_tikzpath1392);
                    	semicolon_end124 = semicolon_end();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_semicolon_end.Add(semicolon_end124.Tree);


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
                    	// 300:96: -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end )
                    	{
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:300:99: ^( IM_PATH path_start ( tikzpath_element )* semicolon_end )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

                    	    adaptor.AddChild(root_1, stream_path_start.NextTree());
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:300:120: ( tikzpath_element )*
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:304:1: let_assignment : COMMAND '=' ( tikzpath_element )* ;
    public simpletikzParser.let_assignment_return let_assignment() // throws RecognitionException [1]
    {   
        simpletikzParser.let_assignment_return retval = new simpletikzParser.let_assignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken COMMAND125 = null;
        IToken char_literal126 = null;
        simpletikzParser.tikzpath_element_return tikzpath_element127 = default(simpletikzParser.tikzpath_element_return);


        object COMMAND125_tree=null;
        object char_literal126_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:305:2: ( COMMAND '=' ( tikzpath_element )* )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:305:4: COMMAND '=' ( tikzpath_element )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	COMMAND125=(IToken)Match(input,COMMAND,FOLLOW_COMMAND_in_let_assignment1419); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{COMMAND125_tree = (object)adaptor.Create(COMMAND125);
            		adaptor.AddChild(root_0, COMMAND125_tree);
            	}
            	char_literal126=(IToken)Match(input,43,FOLLOW_43_in_let_assignment1421); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal126_tree = (object)adaptor.Create(char_literal126);
            		adaptor.AddChild(root_0, char_literal126_tree);
            	}
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:305:16: ( tikzpath_element )*
            	do 
            	{
            	    int alt37 = 2;
            	    int LA37_0 = input.LA(1);

            	    if ( (LA37_0 == ID || LA37_0 == 41 || LA37_0 == 50 || LA37_0 == 52 || (LA37_0 >= 71 && LA37_0 <= 72) || (LA37_0 >= 74 && LA37_0 <= 83)) )
            	    {
            	        alt37 = 1;
            	    }


            	    switch (alt37) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:305:16: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_let_assignment1423);
            			    	tikzpath_element127 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath_element127.Tree);

            			    }
            			    break;

            			default:
            			    goto loop37;
            	    }
            	} while (true);

            	loop37:
            		;	// Stops C# compiler whining that label 'loop37' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:308:1: tikzpath_element : tikzpath_element_single ( ',' )? ;
    public simpletikzParser.tikzpath_element_return tikzpath_element() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_element_return retval = new simpletikzParser.tikzpath_element_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal129 = null;
        simpletikzParser.tikzpath_element_single_return tikzpath_element_single128 = default(simpletikzParser.tikzpath_element_single_return);


        object char_literal129_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:309:2: ( tikzpath_element_single ( ',' )? )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:309:4: tikzpath_element_single ( ',' )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_tikzpath_element_single_in_tikzpath_element1435);
            	tikzpath_element_single128 = tikzpath_element_single();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath_element_single128.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:309:28: ( ',' )?
            	int alt38 = 2;
            	int LA38_0 = input.LA(1);

            	if ( (LA38_0 == 45) )
            	{
            	    alt38 = 1;
            	}
            	switch (alt38) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:309:28: ','
            	        {
            	        	char_literal129=(IToken)Match(input,45,FOLLOW_45_in_tikzpath_element1437); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal129_tree = (object)adaptor.Create(char_literal129);
            	        		adaptor.AddChild(root_0, char_literal129_tree);
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:312:1: tikzpath_element_single : ( tikz_options | coord | controls | tikznode_int | tikzcoordinate_int | circle | arc | roundbr_start ( tikzpath_element )* roundbr_end -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end ) | '(' ( tikzpath_element )* ')' -> ^( IM_PATH '(' ( tikzpath_element )* ')' ) | edgeop );
    public simpletikzParser.tikzpath_element_single_return tikzpath_element_single() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_element_single_return retval = new simpletikzParser.tikzpath_element_single_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal140 = null;
        IToken char_literal142 = null;
        simpletikzParser.tikz_options_return tikz_options130 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.coord_return coord131 = default(simpletikzParser.coord_return);

        simpletikzParser.controls_return controls132 = default(simpletikzParser.controls_return);

        simpletikzParser.tikznode_int_return tikznode_int133 = default(simpletikzParser.tikznode_int_return);

        simpletikzParser.tikzcoordinate_int_return tikzcoordinate_int134 = default(simpletikzParser.tikzcoordinate_int_return);

        simpletikzParser.circle_return circle135 = default(simpletikzParser.circle_return);

        simpletikzParser.arc_return arc136 = default(simpletikzParser.arc_return);

        simpletikzParser.roundbr_start_return roundbr_start137 = default(simpletikzParser.roundbr_start_return);

        simpletikzParser.tikzpath_element_return tikzpath_element138 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.roundbr_end_return roundbr_end139 = default(simpletikzParser.roundbr_end_return);

        simpletikzParser.tikzpath_element_return tikzpath_element141 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.edgeop_return edgeop143 = default(simpletikzParser.edgeop_return);


        object char_literal140_tree=null;
        object char_literal142_tree=null;
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_roundbr_start = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_start");
        RewriteRuleSubtreeStream stream_roundbr_end = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:313:2: ( tikz_options | coord | controls | tikznode_int | tikzcoordinate_int | circle | arc | roundbr_start ( tikzpath_element )* roundbr_end -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end ) | '(' ( tikzpath_element )* ')' -> ^( IM_PATH '(' ( tikzpath_element )* ')' ) | edgeop )
            int alt41 = 10;
            alt41 = dfa41.Predict(input);
            switch (alt41) 
            {
                case 1 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:314:5: tikz_options
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_options_in_tikzpath_element_single1454);
                    	tikz_options130 = tikz_options();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_options130.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:315:5: coord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_coord_in_tikzpath_element_single1461);
                    	coord131 = coord();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, coord131.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:316:5: controls
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_controls_in_tikzpath_element_single1467);
                    	controls132 = controls();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, controls132.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:317:5: tikznode_int
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikznode_int_in_tikzpath_element_single1473);
                    	tikznode_int133 = tikznode_int();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_int133.Tree);

                    }
                    break;
                case 5 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:318:5: tikzcoordinate_int
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikzcoordinate_int_in_tikzpath_element_single1479);
                    	tikzcoordinate_int134 = tikzcoordinate_int();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_int134.Tree);

                    }
                    break;
                case 6 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:319:5: circle
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_circle_in_tikzpath_element_single1485);
                    	circle135 = circle();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;

                    }
                    break;
                case 7 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:320:5: arc
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arc_in_tikzpath_element_single1492);
                    	arc136 = arc();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arc136.Tree);

                    }
                    break;
                case 8 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:321:5: roundbr_start ( tikzpath_element )* roundbr_end
                    {
                    	PushFollow(FOLLOW_roundbr_start_in_tikzpath_element_single1498);
                    	roundbr_start137 = roundbr_start();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_roundbr_start.Add(roundbr_start137.Tree);
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:321:19: ( tikzpath_element )*
                    	do 
                    	{
                    	    int alt39 = 2;
                    	    int LA39_0 = input.LA(1);

                    	    if ( (LA39_0 == ID || LA39_0 == 41 || LA39_0 == 50 || LA39_0 == 52 || (LA39_0 >= 71 && LA39_0 <= 72) || (LA39_0 >= 74 && LA39_0 <= 83)) )
                    	    {
                    	        alt39 = 1;
                    	    }


                    	    switch (alt39) 
                    		{
                    			case 1 :
                    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:321:19: tikzpath_element
                    			    {
                    			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath_element_single1500);
                    			    	tikzpath_element138 = tikzpath_element();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element138.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop39;
                    	    }
                    	} while (true);

                    	loop39:
                    		;	// Stops C# compiler whining that label 'loop39' has no statements

                    	PushFollow(FOLLOW_roundbr_end_in_tikzpath_element_single1503);
                    	roundbr_end139 = roundbr_end();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_roundbr_end.Add(roundbr_end139.Tree);


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
                    	// 321:49: -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end )
                    	{
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:321:52: ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

                    	    adaptor.AddChild(root_1, stream_roundbr_start.NextTree());
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:321:76: ( tikzpath_element )*
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
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:322:6: '(' ( tikzpath_element )* ')'
                    {
                    	char_literal140=(IToken)Match(input,50,FOLLOW_50_in_tikzpath_element_single1523); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_50.Add(char_literal140);

                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:322:10: ( tikzpath_element )*
                    	do 
                    	{
                    	    int alt40 = 2;
                    	    int LA40_0 = input.LA(1);

                    	    if ( (LA40_0 == ID || LA40_0 == 41 || LA40_0 == 50 || LA40_0 == 52 || (LA40_0 >= 71 && LA40_0 <= 72) || (LA40_0 >= 74 && LA40_0 <= 83)) )
                    	    {
                    	        alt40 = 1;
                    	    }


                    	    switch (alt40) 
                    		{
                    			case 1 :
                    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:322:10: tikzpath_element
                    			    {
                    			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath_element_single1525);
                    			    	tikzpath_element141 = tikzpath_element();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element141.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop40;
                    	    }
                    	} while (true);

                    	loop40:
                    		;	// Stops C# compiler whining that label 'loop40' has no statements

                    	char_literal142=(IToken)Match(input,51,FOLLOW_51_in_tikzpath_element_single1528); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_51.Add(char_literal142);



                    	// AST REWRITE
                    	// elements:          51, tikzpath_element, 50
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 322:32: -> ^( IM_PATH '(' ( tikzpath_element )* ')' )
                    	{
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:322:35: ^( IM_PATH '(' ( tikzpath_element )* ')' )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

                    	    adaptor.AddChild(root_1, stream_50.NextNode());
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:322:49: ( tikzpath_element )*
                    	    while ( stream_tikzpath_element.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_tikzpath_element.NextTree());

                    	    }
                    	    stream_tikzpath_element.Reset();
                    	    adaptor.AddChild(root_1, stream_51.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 10 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:323:5: edgeop
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_edgeop_in_tikzpath_element_single1547);
                    	edgeop143 = edgeop();
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:326:1: controls : controls_start coord ( 'and' coord )? controls_end -> ^( IM_CONTROLS controls_start ( coord )+ controls_end ) ;
    public simpletikzParser.controls_return controls() // throws RecognitionException [1]
    {   
        simpletikzParser.controls_return retval = new simpletikzParser.controls_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal146 = null;
        simpletikzParser.controls_start_return controls_start144 = default(simpletikzParser.controls_start_return);

        simpletikzParser.coord_return coord145 = default(simpletikzParser.coord_return);

        simpletikzParser.coord_return coord147 = default(simpletikzParser.coord_return);

        simpletikzParser.controls_end_return controls_end148 = default(simpletikzParser.controls_end_return);


        object string_literal146_tree=null;
        RewriteRuleTokenStream stream_70 = new RewriteRuleTokenStream(adaptor,"token 70");
        RewriteRuleSubtreeStream stream_coord = new RewriteRuleSubtreeStream(adaptor,"rule coord");
        RewriteRuleSubtreeStream stream_controls_start = new RewriteRuleSubtreeStream(adaptor,"rule controls_start");
        RewriteRuleSubtreeStream stream_controls_end = new RewriteRuleSubtreeStream(adaptor,"rule controls_end");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:327:2: ( controls_start coord ( 'and' coord )? controls_end -> ^( IM_CONTROLS controls_start ( coord )+ controls_end ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:327:4: controls_start coord ( 'and' coord )? controls_end
            {
            	PushFollow(FOLLOW_controls_start_in_controls1562);
            	controls_start144 = controls_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_controls_start.Add(controls_start144.Tree);
            	PushFollow(FOLLOW_coord_in_controls1564);
            	coord145 = coord();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_coord.Add(coord145.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:327:25: ( 'and' coord )?
            	int alt42 = 2;
            	int LA42_0 = input.LA(1);

            	if ( (LA42_0 == 70) )
            	{
            	    alt42 = 1;
            	}
            	switch (alt42) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:327:26: 'and' coord
            	        {
            	        	string_literal146=(IToken)Match(input,70,FOLLOW_70_in_controls1567); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_70.Add(string_literal146);

            	        	PushFollow(FOLLOW_coord_in_controls1569);
            	        	coord147 = coord();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_coord.Add(coord147.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_controls_end_in_controls1573);
            	controls_end148 = controls_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_controls_end.Add(controls_end148.Tree);


            	// AST REWRITE
            	// elements:          controls_end, controls_start, coord
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 327:53: -> ^( IM_CONTROLS controls_start ( coord )+ controls_end )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:327:56: ^( IM_CONTROLS controls_start ( coord )+ controls_end )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:330:1: tikznode_ext : node_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikznode_ext_return tikznode_ext() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_ext_return retval = new simpletikzParser.tikznode_ext_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.node_start_return node_start149 = default(simpletikzParser.node_start_return);

        simpletikzParser.tikznode_core_return tikznode_core150 = default(simpletikzParser.tikznode_core_return);

        simpletikzParser.tikzpath_element_return tikzpath_element151 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end152 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_node_start = new RewriteRuleSubtreeStream(adaptor,"rule node_start");
        RewriteRuleSubtreeStream stream_tikznode_core = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_core");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:331:2: ( node_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:331:4: node_start tikznode_core ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_node_start_in_tikznode_ext1599);
            	node_start149 = node_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_node_start.Add(node_start149.Tree);
            	PushFollow(FOLLOW_tikznode_core_in_tikznode_ext1601);
            	tikznode_core150 = tikznode_core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_core.Add(tikznode_core150.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:331:29: ( tikzpath_element )*
            	do 
            	{
            	    int alt43 = 2;
            	    int LA43_0 = input.LA(1);

            	    if ( (LA43_0 == ID || LA43_0 == 41 || LA43_0 == 50 || LA43_0 == 52 || (LA43_0 >= 71 && LA43_0 <= 72) || (LA43_0 >= 74 && LA43_0 <= 83)) )
            	    {
            	        alt43 = 1;
            	    }


            	    switch (alt43) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:331:29: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikznode_ext1603);
            			    	tikzpath_element151 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element151.Tree);

            			    }
            			    break;

            			default:
            			    goto loop43;
            	    }
            	} while (true);

            	loop43:
            		;	// Stops C# compiler whining that label 'loop43' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikznode_ext1606);
            	semicolon_end152 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_semicolon_end.Add(semicolon_end152.Tree);


            	// AST REWRITE
            	// elements:          node_start, tikznode_core, tikzpath_element, semicolon_end
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 331:61: -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:331:64: ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_node_start.NextTree());
            	    adaptor.AddChild(root_1, stream_tikznode_core.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:331:99: ( tikzpath_element )*
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:334:1: tikzmatrix_ext : matrix_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH matrix_start tikznode_core ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikzmatrix_ext_return tikzmatrix_ext() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzmatrix_ext_return retval = new simpletikzParser.tikzmatrix_ext_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.matrix_start_return matrix_start153 = default(simpletikzParser.matrix_start_return);

        simpletikzParser.tikznode_core_return tikznode_core154 = default(simpletikzParser.tikznode_core_return);

        simpletikzParser.tikzpath_element_return tikzpath_element155 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end156 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_matrix_start = new RewriteRuleSubtreeStream(adaptor,"rule matrix_start");
        RewriteRuleSubtreeStream stream_tikznode_core = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_core");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:335:2: ( matrix_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH matrix_start tikznode_core ( tikzpath_element )* semicolon_end ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:335:4: matrix_start tikznode_core ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_matrix_start_in_tikzmatrix_ext1633);
            	matrix_start153 = matrix_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_matrix_start.Add(matrix_start153.Tree);
            	PushFollow(FOLLOW_tikznode_core_in_tikzmatrix_ext1635);
            	tikznode_core154 = tikznode_core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_core.Add(tikznode_core154.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:335:31: ( tikzpath_element )*
            	do 
            	{
            	    int alt44 = 2;
            	    int LA44_0 = input.LA(1);

            	    if ( (LA44_0 == ID || LA44_0 == 41 || LA44_0 == 50 || LA44_0 == 52 || (LA44_0 >= 71 && LA44_0 <= 72) || (LA44_0 >= 74 && LA44_0 <= 83)) )
            	    {
            	        alt44 = 1;
            	    }


            	    switch (alt44) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:335:31: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikzmatrix_ext1637);
            			    	tikzpath_element155 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element155.Tree);

            			    }
            			    break;

            			default:
            			    goto loop44;
            	    }
            	} while (true);

            	loop44:
            		;	// Stops C# compiler whining that label 'loop44' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikzmatrix_ext1640);
            	semicolon_end156 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_semicolon_end.Add(semicolon_end156.Tree);


            	// AST REWRITE
            	// elements:          matrix_start, semicolon_end, tikzpath_element, tikznode_core
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 335:63: -> ^( IM_PATH matrix_start tikznode_core ( tikzpath_element )* semicolon_end )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:335:66: ^( IM_PATH matrix_start tikznode_core ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_matrix_start.NextTree());
            	    adaptor.AddChild(root_1, stream_tikznode_core.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:335:103: ( tikzpath_element )*
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:339:1: tikzcoordinate_ext : coordinate_start ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ( tikzpath_element )* semicolon_end -> ^( IM_PATH coordinate_start ( tikzcoordinate_core3 )? ( tikzcoordinate_core2 )? ( tikzcoordinate_core1 )? ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_ext_return retval = new simpletikzParser.tikzcoordinate_ext_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.coordinate_start_return coordinate_start157 = default(simpletikzParser.coordinate_start_return);

        simpletikzParser.tikzcoordinate_core3_return tikzcoordinate_core3158 = default(simpletikzParser.tikzcoordinate_core3_return);

        simpletikzParser.tikzcoordinate_core2_return tikzcoordinate_core2159 = default(simpletikzParser.tikzcoordinate_core2_return);

        simpletikzParser.tikzcoordinate_core1_return tikzcoordinate_core1160 = default(simpletikzParser.tikzcoordinate_core1_return);

        simpletikzParser.tikzpath_element_return tikzpath_element161 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end162 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_tikzcoordinate_core3 = new RewriteRuleSubtreeStream(adaptor,"rule tikzcoordinate_core3");
        RewriteRuleSubtreeStream stream_tikzcoordinate_core2 = new RewriteRuleSubtreeStream(adaptor,"rule tikzcoordinate_core2");
        RewriteRuleSubtreeStream stream_coordinate_start = new RewriteRuleSubtreeStream(adaptor,"rule coordinate_start");
        RewriteRuleSubtreeStream stream_tikzcoordinate_core1 = new RewriteRuleSubtreeStream(adaptor,"rule tikzcoordinate_core1");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:340:2: ( coordinate_start ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ( tikzpath_element )* semicolon_end -> ^( IM_PATH coordinate_start ( tikzcoordinate_core3 )? ( tikzcoordinate_core2 )? ( tikzcoordinate_core1 )? ( tikzpath_element )* semicolon_end ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:340:4: coordinate_start ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_coordinate_start_in_tikzcoordinate_ext1668);
            	coordinate_start157 = coordinate_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_coordinate_start.Add(coordinate_start157.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:341:5: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?
            	int alt45 = 4;
            	alt45 = dfa45.Predict(input);
            	switch (alt45) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:341:7: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        {
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:341:7: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:341:8: ( tikzcoordinate_core3 )=> tikzcoordinate_core3
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_ext1683);
            	        		tikzcoordinate_core3158 = tikzcoordinate_core3();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( (state.backtracking==0) ) stream_tikzcoordinate_core3.Add(tikzcoordinate_core3158.Tree);

            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:342:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        {
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:342:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:342:12: ( tikzcoordinate_core2 )=> tikzcoordinate_core2
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_ext1702);
            	        		tikzcoordinate_core2159 = tikzcoordinate_core2();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( (state.backtracking==0) ) stream_tikzcoordinate_core2.Add(tikzcoordinate_core2159.Tree);

            	        	}


            	        }
            	        break;
            	    case 3 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:343:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        {
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:343:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:343:12: ( tikzcoordinate_core1 )=> tikzcoordinate_core1
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_ext1722);
            	        		tikzcoordinate_core1160 = tikzcoordinate_core1();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( (state.backtracking==0) ) stream_tikzcoordinate_core1.Add(tikzcoordinate_core1160.Tree);

            	        	}


            	        }
            	        break;

            	}

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:344:6: ( tikzpath_element )*
            	do 
            	{
            	    int alt46 = 2;
            	    int LA46_0 = input.LA(1);

            	    if ( (LA46_0 == ID || LA46_0 == 41 || LA46_0 == 50 || LA46_0 == 52 || (LA46_0 >= 71 && LA46_0 <= 72) || (LA46_0 >= 74 && LA46_0 <= 83)) )
            	    {
            	        alt46 = 1;
            	    }


            	    switch (alt46) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:344:6: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikzcoordinate_ext1733);
            			    	tikzpath_element161 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element161.Tree);

            			    }
            			    break;

            			default:
            			    goto loop46;
            	    }
            	} while (true);

            	loop46:
            		;	// Stops C# compiler whining that label 'loop46' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikzcoordinate_ext1736);
            	semicolon_end162 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_semicolon_end.Add(semicolon_end162.Tree);


            	// AST REWRITE
            	// elements:          tikzpath_element, tikzcoordinate_core3, coordinate_start, tikzcoordinate_core1, semicolon_end, tikzcoordinate_core2
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 345:6: -> ^( IM_PATH coordinate_start ( tikzcoordinate_core3 )? ( tikzcoordinate_core2 )? ( tikzcoordinate_core1 )? ( tikzpath_element )* semicolon_end )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:345:9: ^( IM_PATH coordinate_start ( tikzcoordinate_core3 )? ( tikzcoordinate_core2 )? ( tikzcoordinate_core1 )? ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_coordinate_start.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:346:6: ( tikzcoordinate_core3 )?
            	    if ( stream_tikzcoordinate_core3.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzcoordinate_core3.NextTree());

            	    }
            	    stream_tikzcoordinate_core3.Reset();
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:347:6: ( tikzcoordinate_core2 )?
            	    if ( stream_tikzcoordinate_core2.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzcoordinate_core2.NextTree());

            	    }
            	    stream_tikzcoordinate_core2.Reset();
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:348:6: ( tikzcoordinate_core1 )?
            	    if ( stream_tikzcoordinate_core1.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzcoordinate_core1.NextTree());

            	    }
            	    stream_tikzcoordinate_core1.Reset();
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:349:6: ( tikzpath_element )*
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:351:1: tikzcoordinate_int : 'coordinate' ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ;
    public simpletikzParser.tikzcoordinate_int_return tikzcoordinate_int() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_int_return retval = new simpletikzParser.tikzcoordinate_int_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal163 = null;
        simpletikzParser.tikzcoordinate_core3_return tikzcoordinate_core3164 = default(simpletikzParser.tikzcoordinate_core3_return);

        simpletikzParser.tikzcoordinate_core2_return tikzcoordinate_core2165 = default(simpletikzParser.tikzcoordinate_core2_return);

        simpletikzParser.tikzcoordinate_core1_return tikzcoordinate_core1166 = default(simpletikzParser.tikzcoordinate_core1_return);


        object string_literal163_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:352:2: ( 'coordinate' ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:352:4: 'coordinate' ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal163=(IToken)Match(input,71,FOLLOW_71_in_tikzcoordinate_int1796); if (state.failed) return retval;
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:352:18: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?
            	int alt47 = 4;
            	alt47 = dfa47.Predict(input);
            	switch (alt47) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:352:20: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        {
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:352:20: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:352:21: ( tikzcoordinate_core3 )=> tikzcoordinate_core3
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_int1807);
            	        		tikzcoordinate_core3164 = tikzcoordinate_core3();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_core3164.Tree);

            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:353:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        {
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:353:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:353:12: ( tikzcoordinate_core2 )=> tikzcoordinate_core2
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_int1826);
            	        		tikzcoordinate_core2165 = tikzcoordinate_core2();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_core2165.Tree);

            	        	}


            	        }
            	        break;
            	    case 3 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:354:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        {
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:354:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:354:12: ( tikzcoordinate_core1 )=> tikzcoordinate_core1
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_int1846);
            	        		tikzcoordinate_core1166 = tikzcoordinate_core1();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_core1166.Tree);

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:356:1: tikznode_int : 'node' tikznode_core ;
    public simpletikzParser.tikznode_int_return tikznode_int() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_int_return retval = new simpletikzParser.tikznode_int_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal167 = null;
        simpletikzParser.tikznode_core_return tikznode_core168 = default(simpletikzParser.tikznode_core_return);


        object string_literal167_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:357:2: ( 'node' tikznode_core )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:357:4: 'node' tikznode_core
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal167=(IToken)Match(input,72,FOLLOW_72_in_tikznode_int1862); if (state.failed) return retval;
            	PushFollow(FOLLOW_tikznode_core_in_tikznode_int1865);
            	tikznode_core168 = tikznode_core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_core168.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:359:1: tikznode_core : ( tikznode_decorator )* tikzstring -> ^( IM_NODE ( tikznode_decorator )* tikzstring ) ;
    public simpletikzParser.tikznode_core_return tikznode_core() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_core_return retval = new simpletikzParser.tikznode_core_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator169 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikzstring_return tikzstring170 = default(simpletikzParser.tikzstring_return);


        RewriteRuleSubtreeStream stream_tikzstring = new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:360:2: ( ( tikznode_decorator )* tikzstring -> ^( IM_NODE ( tikznode_decorator )* tikzstring ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:360:4: ( tikznode_decorator )* tikzstring
            {
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:360:4: ( tikznode_decorator )*
            	do 
            	{
            	    int alt48 = 2;
            	    int LA48_0 = input.LA(1);

            	    if ( (LA48_0 == 50 || LA48_0 == 52 || LA48_0 == 73) )
            	    {
            	        alt48 = 1;
            	    }


            	    switch (alt48) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:360:4: tikznode_decorator
            			    {
            			    	PushFollow(FOLLOW_tikznode_decorator_in_tikznode_core1875);
            			    	tikznode_decorator169 = tikznode_decorator();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator169.Tree);

            			    }
            			    break;

            			default:
            			    goto loop48;
            	    }
            	} while (true);

            	loop48:
            		;	// Stops C# compiler whining that label 'loop48' has no statements

            	PushFollow(FOLLOW_tikzstring_in_tikznode_core1878);
            	tikzstring170 = tikzstring();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzstring.Add(tikzstring170.Tree);


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
            	// 360:36: -> ^( IM_NODE ( tikznode_decorator )* tikzstring )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:360:39: ^( IM_NODE ( tikznode_decorator )* tikzstring )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NODE, "IM_NODE"), root_1);

            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:360:49: ( tikznode_decorator )*
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:363:1: tikzcoordinate_core3 : tikznode_decorator tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator ) ;
    public simpletikzParser.tikzcoordinate_core3_return tikzcoordinate_core3() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_core3_return retval = new simpletikzParser.tikzcoordinate_core3_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator171 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikznode_decorator_return tikznode_decorator172 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikznode_decorator_return tikznode_decorator173 = default(simpletikzParser.tikznode_decorator_return);


        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:364:2: ( tikznode_decorator tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:364:6: tikznode_decorator tikznode_decorator tikznode_decorator
            {
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core31903);
            	tikznode_decorator171 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator171.Tree);
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core31905);
            	tikznode_decorator172 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator172.Tree);
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core31907);
            	tikznode_decorator173 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator173.Tree);


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
            	// 364:64: -> ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:364:67: ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:368:1: tikzcoordinate_core2 : tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator ) ;
    public simpletikzParser.tikzcoordinate_core2_return tikzcoordinate_core2() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_core2_return retval = new simpletikzParser.tikzcoordinate_core2_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator174 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikznode_decorator_return tikznode_decorator175 = default(simpletikzParser.tikznode_decorator_return);


        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:369:2: ( tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:370:4: tikznode_decorator tikznode_decorator
            {
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core21941);
            	tikznode_decorator174 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator174.Tree);
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core21943);
            	tikznode_decorator175 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator175.Tree);


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
            	// 370:47: -> ^( IM_NODE tikznode_decorator tikznode_decorator )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:370:50: ^( IM_NODE tikznode_decorator tikznode_decorator )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:373:1: tikzcoordinate_core1 : tikznode_decorator -> ^( IM_NODE tikznode_decorator ) ;
    public simpletikzParser.tikzcoordinate_core1_return tikzcoordinate_core1() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_core1_return retval = new simpletikzParser.tikzcoordinate_core1_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator176 = default(simpletikzParser.tikznode_decorator_return);


        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:374:2: ( tikznode_decorator -> ^( IM_NODE tikznode_decorator ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:375:4: tikznode_decorator
            {
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core11976);
            	tikznode_decorator176 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator176.Tree);


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
            	// 375:31: -> ^( IM_NODE tikznode_decorator )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:375:34: ^( IM_NODE tikznode_decorator )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:382:1: tikznode_decorator : ( nodename | 'at' coord | tikz_options_dontcare );
    public simpletikzParser.tikznode_decorator_return tikznode_decorator() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_decorator_return retval = new simpletikzParser.tikznode_decorator_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal178 = null;
        simpletikzParser.nodename_return nodename177 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_return coord179 = default(simpletikzParser.coord_return);

        simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare180 = default(simpletikzParser.tikz_options_dontcare_return);


        object string_literal178_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:383:2: ( nodename | 'at' coord | tikz_options_dontcare )
            int alt49 = 3;
            switch ( input.LA(1) ) 
            {
            case 50:
            	{
                alt49 = 1;
                }
                break;
            case 73:
            	{
                alt49 = 2;
                }
                break;
            case 52:
            	{
                alt49 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d49s0 =
            	        new NoViableAltException("", 49, 0, input);

            	    throw nvae_d49s0;
            }

            switch (alt49) 
            {
                case 1 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:383:6: nodename
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_nodename_in_tikznode_decorator2013);
                    	nodename177 = nodename();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, nodename177.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:384:5: 'at' coord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal178=(IToken)Match(input,73,FOLLOW_73_in_tikznode_decorator2020); if (state.failed) return retval;
                    	PushFollow(FOLLOW_coord_in_tikznode_decorator2023);
                    	coord179 = coord();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, coord179.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:385:5: tikz_options_dontcare
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_options_dontcare_in_tikznode_decorator2029);
                    	tikz_options_dontcare180 = tikz_options_dontcare();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_options_dontcare180.Tree);

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:387:1: tikz_options_dontcare : '[' ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* ']' -> ^( IM_OPTIONS ) ;
    public simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_options_dontcare_return retval = new simpletikzParser.tikz_options_dontcare_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal181 = null;
        IToken char_literal185 = null;
        simpletikzParser.no_rlbracket_return no_rlbracket182 = default(simpletikzParser.no_rlbracket_return);

        simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare183 = default(simpletikzParser.tikz_options_dontcare_return);

        simpletikzParser.no_rlbracket_return no_rlbracket184 = default(simpletikzParser.no_rlbracket_return);


        object char_literal181_tree=null;
        object char_literal185_tree=null;
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleSubtreeStream stream_tikz_options_dontcare = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options_dontcare");
        RewriteRuleSubtreeStream stream_no_rlbracket = new RewriteRuleSubtreeStream(adaptor,"rule no_rlbracket");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:388:2: ( '[' ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* ']' -> ^( IM_OPTIONS ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:388:4: '[' ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* ']'
            {
            	char_literal181=(IToken)Match(input,52,FOLLOW_52_in_tikz_options_dontcare2039); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_52.Add(char_literal181);

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:388:8: ( no_rlbracket )*
            	do 
            	{
            	    int alt50 = 2;
            	    int LA50_0 = input.LA(1);

            	    if ( ((LA50_0 >= IM_PATH && LA50_0 <= 51) || (LA50_0 >= 54 && LA50_0 <= 86)) )
            	    {
            	        alt50 = 1;
            	    }


            	    switch (alt50) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:388:8: no_rlbracket
            			    {
            			    	PushFollow(FOLLOW_no_rlbracket_in_tikz_options_dontcare2041);
            			    	no_rlbracket182 = no_rlbracket();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_no_rlbracket.Add(no_rlbracket182.Tree);

            			    }
            			    break;

            			default:
            			    goto loop50;
            	    }
            	} while (true);

            	loop50:
            		;	// Stops C# compiler whining that label 'loop50' has no statements

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:388:22: ( tikz_options_dontcare ( no_rlbracket )* )*
            	do 
            	{
            	    int alt52 = 2;
            	    int LA52_0 = input.LA(1);

            	    if ( (LA52_0 == 52) )
            	    {
            	        alt52 = 1;
            	    }


            	    switch (alt52) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:388:23: tikz_options_dontcare ( no_rlbracket )*
            			    {
            			    	PushFollow(FOLLOW_tikz_options_dontcare_in_tikz_options_dontcare2045);
            			    	tikz_options_dontcare183 = tikz_options_dontcare();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikz_options_dontcare.Add(tikz_options_dontcare183.Tree);
            			    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:388:45: ( no_rlbracket )*
            			    	do 
            			    	{
            			    	    int alt51 = 2;
            			    	    int LA51_0 = input.LA(1);

            			    	    if ( ((LA51_0 >= IM_PATH && LA51_0 <= 51) || (LA51_0 >= 54 && LA51_0 <= 86)) )
            			    	    {
            			    	        alt51 = 1;
            			    	    }


            			    	    switch (alt51) 
            			    		{
            			    			case 1 :
            			    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:388:45: no_rlbracket
            			    			    {
            			    			    	PushFollow(FOLLOW_no_rlbracket_in_tikz_options_dontcare2047);
            			    			    	no_rlbracket184 = no_rlbracket();
            			    			    	state.followingStackPointer--;
            			    			    	if (state.failed) return retval;
            			    			    	if ( (state.backtracking==0) ) stream_no_rlbracket.Add(no_rlbracket184.Tree);

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop51;
            			    	    }
            			    	} while (true);

            			    	loop51:
            			    		;	// Stops C# compiler whining that label 'loop51' has no statements


            			    }
            			    break;

            			default:
            			    goto loop52;
            	    }
            	} while (true);

            	loop52:
            		;	// Stops C# compiler whining that label 'loop52' has no statements

            	char_literal185=(IToken)Match(input,53,FOLLOW_53_in_tikz_options_dontcare2052); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_53.Add(char_literal185);



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
            	// 388:65: -> ^( IM_OPTIONS )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:388:68: ^( IM_OPTIONS )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:390:1: no_rlbracket : ~ ( '[' | ']' ) ;
    public simpletikzParser.no_rlbracket_return no_rlbracket() // throws RecognitionException [1]
    {   
        simpletikzParser.no_rlbracket_return retval = new simpletikzParser.no_rlbracket_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set186 = null;

        object set186_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:391:2: (~ ( '[' | ']' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:391:4: ~ ( '[' | ']' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set186 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= 51) || (input.LA(1) >= 54 && input.LA(1) <= 86) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set186));
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:393:1: nodename : '(' idd ')' -> ^( IM_NODENAME idd ) ;
    public simpletikzParser.nodename_return nodename() // throws RecognitionException [1]
    {   
        simpletikzParser.nodename_return retval = new simpletikzParser.nodename_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal187 = null;
        IToken char_literal189 = null;
        simpletikzParser.idd_return idd188 = default(simpletikzParser.idd_return);


        object char_literal187_tree=null;
        object char_literal189_tree=null;
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:394:2: ( '(' idd ')' -> ^( IM_NODENAME idd ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:394:4: '(' idd ')'
            {
            	char_literal187=(IToken)Match(input,50,FOLLOW_50_in_nodename2087); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_50.Add(char_literal187);

            	PushFollow(FOLLOW_idd_in_nodename2089);
            	idd188 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idd.Add(idd188.Tree);
            	char_literal189=(IToken)Match(input,51,FOLLOW_51_in_nodename2091); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_51.Add(char_literal189);



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
            	// 394:17: -> ^( IM_NODENAME idd )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:394:20: ^( IM_NODENAME idd )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:400:1: circle : ( 'circle' | 'ellipse' ) ( ( size )=> size )? ->;
    public simpletikzParser.circle_return circle() // throws RecognitionException [1]
    {   
        simpletikzParser.circle_return retval = new simpletikzParser.circle_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal190 = null;
        IToken string_literal191 = null;
        simpletikzParser.size_return size192 = default(simpletikzParser.size_return);


        object string_literal190_tree=null;
        object string_literal191_tree=null;
        RewriteRuleTokenStream stream_74 = new RewriteRuleTokenStream(adaptor,"token 74");
        RewriteRuleTokenStream stream_75 = new RewriteRuleTokenStream(adaptor,"token 75");
        RewriteRuleSubtreeStream stream_size = new RewriteRuleSubtreeStream(adaptor,"rule size");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:401:2: ( ( 'circle' | 'ellipse' ) ( ( size )=> size )? ->)
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:401:4: ( 'circle' | 'ellipse' ) ( ( size )=> size )?
            {
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:401:4: ( 'circle' | 'ellipse' )
            	int alt53 = 2;
            	int LA53_0 = input.LA(1);

            	if ( (LA53_0 == 74) )
            	{
            	    alt53 = 1;
            	}
            	else if ( (LA53_0 == 75) )
            	{
            	    alt53 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d53s0 =
            	        new NoViableAltException("", 53, 0, input);

            	    throw nvae_d53s0;
            	}
            	switch (alt53) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:401:5: 'circle'
            	        {
            	        	string_literal190=(IToken)Match(input,74,FOLLOW_74_in_circle2115); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_74.Add(string_literal190);


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:401:16: 'ellipse'
            	        {
            	        	string_literal191=(IToken)Match(input,75,FOLLOW_75_in_circle2119); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_75.Add(string_literal191);


            	        }
            	        break;

            	}

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:401:27: ( ( size )=> size )?
            	int alt54 = 2;
            	alt54 = dfa54.Predict(input);
            	switch (alt54) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:401:28: ( size )=> size
            	        {
            	        	PushFollow(FOLLOW_size_in_circle2128);
            	        	size192 = size();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_size.Add(size192.Tree);

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
            	// 401:44: ->
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:403:1: arc : 'arc' ( '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')' )? -> ^( IM_ARC ( numberunitorvariable )+ ) ;
    public simpletikzParser.arc_return arc() // throws RecognitionException [1]
    {   
        simpletikzParser.arc_return retval = new simpletikzParser.arc_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal193 = null;
        IToken char_literal194 = null;
        IToken char_literal196 = null;
        IToken char_literal198 = null;
        IToken string_literal200 = null;
        IToken char_literal202 = null;
        simpletikzParser.numberunitorvariable_return numberunitorvariable195 = default(simpletikzParser.numberunitorvariable_return);

        simpletikzParser.numberunitorvariable_return numberunitorvariable197 = default(simpletikzParser.numberunitorvariable_return);

        simpletikzParser.numberunitorvariable_return numberunitorvariable199 = default(simpletikzParser.numberunitorvariable_return);

        simpletikzParser.numberunit_return numberunit201 = default(simpletikzParser.numberunit_return);


        object string_literal193_tree=null;
        object char_literal194_tree=null;
        object char_literal196_tree=null;
        object char_literal198_tree=null;
        object string_literal200_tree=null;
        object char_literal202_tree=null;
        RewriteRuleTokenStream stream_46 = new RewriteRuleTokenStream(adaptor,"token 46");
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_70 = new RewriteRuleTokenStream(adaptor,"token 70");
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleTokenStream stream_76 = new RewriteRuleTokenStream(adaptor,"token 76");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_numberunitorvariable = new RewriteRuleSubtreeStream(adaptor,"rule numberunitorvariable");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:404:2: ( 'arc' ( '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')' )? -> ^( IM_ARC ( numberunitorvariable )+ ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:404:4: 'arc' ( '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')' )?
            {
            	string_literal193=(IToken)Match(input,76,FOLLOW_76_in_arc2143); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_76.Add(string_literal193);

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:404:10: ( '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')' )?
            	int alt56 = 2;
            	alt56 = dfa56.Predict(input);
            	switch (alt56) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:404:11: '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')'
            	        {
            	        	char_literal194=(IToken)Match(input,50,FOLLOW_50_in_arc2146); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_50.Add(char_literal194);

            	        	PushFollow(FOLLOW_numberunitorvariable_in_arc2148);
            	        	numberunitorvariable195 = numberunitorvariable();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_numberunitorvariable.Add(numberunitorvariable195.Tree);
            	        	char_literal196=(IToken)Match(input,46,FOLLOW_46_in_arc2150); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_46.Add(char_literal196);

            	        	PushFollow(FOLLOW_numberunitorvariable_in_arc2152);
            	        	numberunitorvariable197 = numberunitorvariable();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_numberunitorvariable.Add(numberunitorvariable197.Tree);
            	        	char_literal198=(IToken)Match(input,46,FOLLOW_46_in_arc2154); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_46.Add(char_literal198);

            	        	PushFollow(FOLLOW_numberunitorvariable_in_arc2156);
            	        	numberunitorvariable199 = numberunitorvariable();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_numberunitorvariable.Add(numberunitorvariable199.Tree);
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:404:86: ( 'and' numberunit )?
            	        	int alt55 = 2;
            	        	int LA55_0 = input.LA(1);

            	        	if ( (LA55_0 == 70) )
            	        	{
            	        	    alt55 = 1;
            	        	}
            	        	switch (alt55) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:404:87: 'and' numberunit
            	        	        {
            	        	        	string_literal200=(IToken)Match(input,70,FOLLOW_70_in_arc2159); if (state.failed) return retval; 
            	        	        	if ( (state.backtracking==0) ) stream_70.Add(string_literal200);

            	        	        	PushFollow(FOLLOW_numberunit_in_arc2161);
            	        	        	numberunit201 = numberunit();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit201.Tree);

            	        	        }
            	        	        break;

            	        	}

            	        	char_literal202=(IToken)Match(input,51,FOLLOW_51_in_arc2165); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_51.Add(char_literal202);


            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          numberunitorvariable
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 404:112: -> ^( IM_ARC ( numberunitorvariable )+ )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:404:115: ^( IM_ARC ( numberunitorvariable )+ )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:407:1: size : '(' numberunit ( 'and' numberunit )? ')' -> ^( IM_SIZE ( numberunit )* ) ;
    public simpletikzParser.size_return size() // throws RecognitionException [1]
    {   
        simpletikzParser.size_return retval = new simpletikzParser.size_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal203 = null;
        IToken string_literal205 = null;
        IToken char_literal207 = null;
        simpletikzParser.numberunit_return numberunit204 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit206 = default(simpletikzParser.numberunit_return);


        object char_literal203_tree=null;
        object string_literal205_tree=null;
        object char_literal207_tree=null;
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_70 = new RewriteRuleTokenStream(adaptor,"token 70");
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:408:2: ( '(' numberunit ( 'and' numberunit )? ')' -> ^( IM_SIZE ( numberunit )* ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:408:6: '(' numberunit ( 'and' numberunit )? ')'
            {
            	char_literal203=(IToken)Match(input,50,FOLLOW_50_in_size2190); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_50.Add(char_literal203);

            	PushFollow(FOLLOW_numberunit_in_size2192);
            	numberunit204 = numberunit();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit204.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:408:21: ( 'and' numberunit )?
            	int alt57 = 2;
            	int LA57_0 = input.LA(1);

            	if ( (LA57_0 == 70) )
            	{
            	    alt57 = 1;
            	}
            	switch (alt57) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:408:22: 'and' numberunit
            	        {
            	        	string_literal205=(IToken)Match(input,70,FOLLOW_70_in_size2195); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_70.Add(string_literal205);

            	        	PushFollow(FOLLOW_numberunit_in_size2197);
            	        	numberunit206 = numberunit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit206.Tree);

            	        }
            	        break;

            	}

            	char_literal207=(IToken)Match(input,51,FOLLOW_51_in_size2201); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_51.Add(char_literal207);



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
            	// 408:46: -> ^( IM_SIZE ( numberunit )* )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:408:49: ^( IM_SIZE ( numberunit )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_SIZE, "IM_SIZE"), root_1);

            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:408:59: ( numberunit )*
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:415:1: coord : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) );
    public simpletikzParser.coord_return coord() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_return retval = new simpletikzParser.coord_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal210 = null;
        IToken char_literal214 = null;
        IToken char_literal216 = null;
        IToken char_literal220 = null;
        simpletikzParser.nodename_return nodename208 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_modifier_return coord_modifier209 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.numberunit_return numberunit211 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_sep_return coord_sep212 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.numberunit_return numberunit213 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_modifier_return coord_modifier215 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.coord_part_return coord_part217 = default(simpletikzParser.coord_part_return);

        simpletikzParser.coord_sep_return coord_sep218 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.coord_part_return coord_part219 = default(simpletikzParser.coord_part_return);


        object char_literal210_tree=null;
        object char_literal214_tree=null;
        object char_literal216_tree=null;
        object char_literal220_tree=null;
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_coord_part = new RewriteRuleSubtreeStream(adaptor,"rule coord_part");
        RewriteRuleSubtreeStream stream_coord_sep = new RewriteRuleSubtreeStream(adaptor,"rule coord_sep");
        RewriteRuleSubtreeStream stream_nodename = new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        RewriteRuleSubtreeStream stream_coord_modifier = new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:416:2: ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) )
            int alt60 = 3;
            alt60 = dfa60.Predict(input);
            switch (alt60) 
            {
                case 1 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:416:6: nodename
                    {
                    	PushFollow(FOLLOW_nodename_in_coord2231);
                    	nodename208 = nodename();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_nodename.Add(nodename208.Tree);


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
                    	// 416:23: -> ^( IM_COORD nodename )
                    	{
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:416:26: ^( IM_COORD nodename )
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
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:417:5: ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' )
                    {
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:417:5: ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' )
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:417:7: ( coord_modifier )? '(' numberunit coord_sep numberunit ')'
                    	{
                    		// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:417:7: ( coord_modifier )?
                    		int alt58 = 2;
                    		int LA58_0 = input.LA(1);

                    		if ( ((LA58_0 >= 81 && LA58_0 <= 82)) )
                    		{
                    		    alt58 = 1;
                    		}
                    		switch (alt58) 
                    		{
                    		    case 1 :
                    		        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:417:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord2255);
                    		        	coord_modifier209 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_coord_modifier.Add(coord_modifier209.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal210=(IToken)Match(input,50,FOLLOW_50_in_coord2258); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_50.Add(char_literal210);

                    		PushFollow(FOLLOW_numberunit_in_coord2260);
                    		numberunit211 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit211.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord2262);
                    		coord_sep212 = coord_sep();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_sep.Add(coord_sep212.Tree);
                    		PushFollow(FOLLOW_numberunit_in_coord2264);
                    		numberunit213 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit213.Tree);
                    		char_literal214=(IToken)Match(input,51,FOLLOW_51_in_coord2266); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_51.Add(char_literal214);


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
                    	// 417:65: -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep )
                    	{
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:417:68: ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:417:79: ( coord_modifier )?
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
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:418:5: ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' )
                    {
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:418:5: ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' )
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:418:7: ( coord_modifier )? '(' coord_part coord_sep coord_part ')'
                    	{
                    		// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:418:7: ( coord_modifier )?
                    		int alt59 = 2;
                    		int LA59_0 = input.LA(1);

                    		if ( ((LA59_0 >= 81 && LA59_0 <= 82)) )
                    		{
                    		    alt59 = 1;
                    		}
                    		switch (alt59) 
                    		{
                    		    case 1 :
                    		        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:418:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord2290);
                    		        	coord_modifier215 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_coord_modifier.Add(coord_modifier215.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal216=(IToken)Match(input,50,FOLLOW_50_in_coord2293); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_50.Add(char_literal216);

                    		PushFollow(FOLLOW_coord_part_in_coord2295);
                    		coord_part217 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_part.Add(coord_part217.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord2297);
                    		coord_sep218 = coord_sep();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_sep.Add(coord_sep218.Tree);
                    		PushFollow(FOLLOW_coord_part_in_coord2299);
                    		coord_part219 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_part.Add(coord_part219.Tree);
                    		char_literal220=(IToken)Match(input,51,FOLLOW_51_in_coord2301); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_51.Add(char_literal220);


                    	}



                    	// AST REWRITE
                    	// elements:          coord_sep, coord_modifier, coord_part
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 418:65: -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep )
                    	{
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:418:68: ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:418:79: ( coord_modifier )?
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:427:1: coord_part : ( idd -> ^( IM_DONTCARE idd ) | '{' idd '}' -> ^( IM_DONTCARE '{' idd '}' ) | ( idd '=' numberunit ( ',' )? )+ -> ^( IM_DONTCARE ( idd '=' numberunit ( ',' )? )+ ) );
    public simpletikzParser.coord_part_return coord_part() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_part_return retval = new simpletikzParser.coord_part_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal222 = null;
        IToken char_literal224 = null;
        IToken char_literal226 = null;
        IToken char_literal228 = null;
        simpletikzParser.idd_return idd221 = default(simpletikzParser.idd_return);

        simpletikzParser.idd_return idd223 = default(simpletikzParser.idd_return);

        simpletikzParser.idd_return idd225 = default(simpletikzParser.idd_return);

        simpletikzParser.numberunit_return numberunit227 = default(simpletikzParser.numberunit_return);


        object char_literal222_tree=null;
        object char_literal224_tree=null;
        object char_literal226_tree=null;
        object char_literal228_tree=null;
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:428:2: ( idd -> ^( IM_DONTCARE idd ) | '{' idd '}' -> ^( IM_DONTCARE '{' idd '}' ) | ( idd '=' numberunit ( ',' )? )+ -> ^( IM_DONTCARE ( idd '=' numberunit ( ',' )? )+ ) )
            int alt63 = 3;
            alt63 = dfa63.Predict(input);
            switch (alt63) 
            {
                case 1 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:428:4: idd
                    {
                    	PushFollow(FOLLOW_idd_in_coord_part2334);
                    	idd221 = idd();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_idd.Add(idd221.Tree);


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
                    	// 428:9: -> ^( IM_DONTCARE idd )
                    	{
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:428:12: ^( IM_DONTCARE idd )
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
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:429:4: '{' idd '}'
                    {
                    	char_literal222=(IToken)Match(input,41,FOLLOW_41_in_coord_part2349); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_41.Add(char_literal222);

                    	PushFollow(FOLLOW_idd_in_coord_part2351);
                    	idd223 = idd();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_idd.Add(idd223.Tree);
                    	char_literal224=(IToken)Match(input,42,FOLLOW_42_in_coord_part2353); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_42.Add(char_literal224);



                    	// AST REWRITE
                    	// elements:          idd, 41, 42
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 429:16: -> ^( IM_DONTCARE '{' idd '}' )
                    	{
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:429:19: ^( IM_DONTCARE '{' idd '}' )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DONTCARE, "IM_DONTCARE"), root_1);

                    	    adaptor.AddChild(root_1, stream_41.NextNode());
                    	    adaptor.AddChild(root_1, stream_idd.NextTree());
                    	    adaptor.AddChild(root_1, stream_42.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:430:4: ( idd '=' numberunit ( ',' )? )+
                    {
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:430:4: ( idd '=' numberunit ( ',' )? )+
                    	int cnt62 = 0;
                    	do 
                    	{
                    	    int alt62 = 2;
                    	    int LA62_0 = input.LA(1);

                    	    if ( ((LA62_0 >= IM_PATH && LA62_0 <= 40) || LA62_0 == 44 || LA62_0 == 49 || (LA62_0 >= 55 && LA62_0 <= 86)) )
                    	    {
                    	        alt62 = 1;
                    	    }


                    	    switch (alt62) 
                    		{
                    			case 1 :
                    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:430:5: idd '=' numberunit ( ',' )?
                    			    {
                    			    	PushFollow(FOLLOW_idd_in_coord_part2371);
                    			    	idd225 = idd();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_idd.Add(idd225.Tree);
                    			    	char_literal226=(IToken)Match(input,43,FOLLOW_43_in_coord_part2373); if (state.failed) return retval; 
                    			    	if ( (state.backtracking==0) ) stream_43.Add(char_literal226);

                    			    	PushFollow(FOLLOW_numberunit_in_coord_part2375);
                    			    	numberunit227 = numberunit();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit227.Tree);
                    			    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:430:24: ( ',' )?
                    			    	int alt61 = 2;
                    			    	int LA61_0 = input.LA(1);

                    			    	if ( (LA61_0 == 45) )
                    			    	{
                    			    	    alt61 = 1;
                    			    	}
                    			    	switch (alt61) 
                    			    	{
                    			    	    case 1 :
                    			    	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:430:24: ','
                    			    	        {
                    			    	        	char_literal228=(IToken)Match(input,45,FOLLOW_45_in_coord_part2377); if (state.failed) return retval; 
                    			    	        	if ( (state.backtracking==0) ) stream_45.Add(char_literal228);


                    			    	        }
                    			    	        break;

                    			    	}


                    			    }
                    			    break;

                    			default:
                    			    if ( cnt62 >= 1 ) goto loop62;
                    			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    		            EarlyExitException eee62 =
                    		                new EarlyExitException(62, input);
                    		            throw eee62;
                    	    }
                    	    cnt62++;
                    	} while (true);

                    	loop62:
                    		;	// Stops C# compiler whining that label 'loop62' has no statements



                    	// AST REWRITE
                    	// elements:          numberunit, 43, idd, 45
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 430:31: -> ^( IM_DONTCARE ( idd '=' numberunit ( ',' )? )+ )
                    	{
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:430:34: ^( IM_DONTCARE ( idd '=' numberunit ( ',' )? )+ )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DONTCARE, "IM_DONTCARE"), root_1);

                    	    if ( !(stream_numberunit.HasNext() || stream_43.HasNext() || stream_idd.HasNext()) ) {
                    	        throw new RewriteEarlyExitException();
                    	    }
                    	    while ( stream_numberunit.HasNext() || stream_43.HasNext() || stream_idd.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_idd.NextTree());
                    	        adaptor.AddChild(root_1, stream_43.NextNode());
                    	        adaptor.AddChild(root_1, stream_numberunit.NextTree());
                    	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:430:69: ( ',' )?
                    	        if ( stream_45.HasNext() )
                    	        {
                    	            adaptor.AddChild(root_1, stream_45.NextNode());

                    	        }
                    	        stream_45.Reset();

                    	    }
                    	    stream_numberunit.Reset();
                    	    stream_43.Reset();
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:432:1: coord_sep : ( ',' | ':' ) ;
    public simpletikzParser.coord_sep_return coord_sep() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_sep_return retval = new simpletikzParser.coord_sep_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set229 = null;

        object set229_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:433:2: ( ( ',' | ':' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:433:4: ( ',' | ':' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set229 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 45 && input.LA(1) <= 46) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set229));
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:437:1: edgeop : ( '--' | '->' | '|-' | '-|' | ID );
    public simpletikzParser.edgeop_return edgeop() // throws RecognitionException [1]
    {   
        simpletikzParser.edgeop_return retval = new simpletikzParser.edgeop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set230 = null;

        object set230_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:438:2: ( '--' | '->' | '|-' | '-|' | ID )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set230 = (IToken)input.LT(1);
            	if ( input.LA(1) == ID || (input.LA(1) >= 77 && input.LA(1) <= 80) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set230));
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:442:1: coord_modifier : ( '+' | '++' );
    public simpletikzParser.coord_modifier_return coord_modifier() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_modifier_return retval = new simpletikzParser.coord_modifier_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set231 = null;

        object set231_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:443:2: ( '+' | '++' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set231 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 81 && input.LA(1) <= 82) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set231));
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:485:1: squarebr_start : '[' -> ^( IM_STARTTAG '[' ) ;
    public simpletikzParser.squarebr_start_return squarebr_start() // throws RecognitionException [1]
    {   
        simpletikzParser.squarebr_start_return retval = new simpletikzParser.squarebr_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal232 = null;

        object char_literal232_tree=null;
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:486:2: ( '[' -> ^( IM_STARTTAG '[' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:486:4: '['
            {
            	char_literal232=(IToken)Match(input,52,FOLLOW_52_in_squarebr_start2483); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_52.Add(char_literal232);



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
            	// 486:8: -> ^( IM_STARTTAG '[' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:486:11: ^( IM_STARTTAG '[' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:488:1: squarebr_end : ']' -> ^( IM_ENDTAG ']' ) ;
    public simpletikzParser.squarebr_end_return squarebr_end() // throws RecognitionException [1]
    {   
        simpletikzParser.squarebr_end_return retval = new simpletikzParser.squarebr_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal233 = null;

        object char_literal233_tree=null;
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:489:2: ( ']' -> ^( IM_ENDTAG ']' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:489:4: ']'
            {
            	char_literal233=(IToken)Match(input,53,FOLLOW_53_in_squarebr_end2501); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_53.Add(char_literal233);



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
            	// 489:8: -> ^( IM_ENDTAG ']' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:489:11: ^( IM_ENDTAG ']' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:491:1: semicolon_end : ';' -> ^( IM_ENDTAG ';' ) ;
    public simpletikzParser.semicolon_end_return semicolon_end() // throws RecognitionException [1]
    {   
        simpletikzParser.semicolon_end_return retval = new simpletikzParser.semicolon_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal234 = null;

        object char_literal234_tree=null;
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:492:2: ( ';' -> ^( IM_ENDTAG ';' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:492:4: ';'
            {
            	char_literal234=(IToken)Match(input,54,FOLLOW_54_in_semicolon_end2520); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_54.Add(char_literal234);



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
            	// 492:8: -> ^( IM_ENDTAG ';' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:492:11: ^( IM_ENDTAG ';' )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:494:1: roundbr_start : '{' -> ^( IM_STARTTAG '{' ) ;
    public simpletikzParser.roundbr_start_return roundbr_start() // throws RecognitionException [1]
    {   
        simpletikzParser.roundbr_start_return retval = new simpletikzParser.roundbr_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal235 = null;

        object char_literal235_tree=null;
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:495:2: ( '{' -> ^( IM_STARTTAG '{' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:495:4: '{'
            {
            	char_literal235=(IToken)Match(input,41,FOLLOW_41_in_roundbr_start2538); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(char_literal235);



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
            	// 495:8: -> ^( IM_STARTTAG '{' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:495:11: ^( IM_STARTTAG '{' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:497:1: roundbr_end : '}' -> ^( IM_ENDTAG '}' ) ;
    public simpletikzParser.roundbr_end_return roundbr_end() // throws RecognitionException [1]
    {   
        simpletikzParser.roundbr_end_return retval = new simpletikzParser.roundbr_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal236 = null;

        object char_literal236_tree=null;
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:498:2: ( '}' -> ^( IM_ENDTAG '}' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:498:4: '}'
            {
            	char_literal236=(IToken)Match(input,42,FOLLOW_42_in_roundbr_end2556); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_42.Add(char_literal236);



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
            	// 498:8: -> ^( IM_ENDTAG '}' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:498:11: ^( IM_ENDTAG '}' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:500:1: controls_start : '..' 'controls' -> ^( IM_STARTTAG '..' ) ;
    public simpletikzParser.controls_start_return controls_start() // throws RecognitionException [1]
    {   
        simpletikzParser.controls_start_return retval = new simpletikzParser.controls_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal237 = null;
        IToken string_literal238 = null;

        object string_literal237_tree=null;
        object string_literal238_tree=null;
        RewriteRuleTokenStream stream_83 = new RewriteRuleTokenStream(adaptor,"token 83");
        RewriteRuleTokenStream stream_84 = new RewriteRuleTokenStream(adaptor,"token 84");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:501:2: ( '..' 'controls' -> ^( IM_STARTTAG '..' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:501:4: '..' 'controls'
            {
            	string_literal237=(IToken)Match(input,83,FOLLOW_83_in_controls_start2574); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_83.Add(string_literal237);

            	string_literal238=(IToken)Match(input,84,FOLLOW_84_in_controls_start2576); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_84.Add(string_literal238);



            	// AST REWRITE
            	// elements:          83
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 501:20: -> ^( IM_STARTTAG '..' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:501:23: ^( IM_STARTTAG '..' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_83.NextNode());

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:503:1: controls_end : '..' -> ^( IM_ENDTAG '..' ) ;
    public simpletikzParser.controls_end_return controls_end() // throws RecognitionException [1]
    {   
        simpletikzParser.controls_end_return retval = new simpletikzParser.controls_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal239 = null;

        object string_literal239_tree=null;
        RewriteRuleTokenStream stream_83 = new RewriteRuleTokenStream(adaptor,"token 83");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:504:2: ( '..' -> ^( IM_ENDTAG '..' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:504:4: '..'
            {
            	string_literal239=(IToken)Match(input,83,FOLLOW_83_in_controls_end2594); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_83.Add(string_literal239);



            	// AST REWRITE
            	// elements:          83
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 504:9: -> ^( IM_ENDTAG '..' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:504:12: ^( IM_ENDTAG '..' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_83.NextNode());

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:506:1: tikz_set_start : '\\\\tikzset' '{' -> ^( IM_STARTTAG ) ;
    public simpletikzParser.tikz_set_start_return tikz_set_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_set_start_return retval = new simpletikzParser.tikz_set_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal240 = null;
        IToken char_literal241 = null;

        object string_literal240_tree=null;
        object char_literal241_tree=null;
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:507:2: ( '\\\\tikzset' '{' -> ^( IM_STARTTAG ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:507:4: '\\\\tikzset' '{'
            {
            	string_literal240=(IToken)Match(input,40,FOLLOW_40_in_tikz_set_start2612); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_40.Add(string_literal240);

            	char_literal241=(IToken)Match(input,41,FOLLOW_41_in_tikz_set_start2614); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(char_literal241);



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
            	// 507:21: -> ^( IM_STARTTAG )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:507:24: ^( IM_STARTTAG )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:509:1: tikzpicture_start : '\\\\begin' '{' 'tikzpicture' '}' -> ^( IM_STARTTAG '\\\\begin' ) ;
    public simpletikzParser.tikzpicture_start_return tikzpicture_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_start_return retval = new simpletikzParser.tikzpicture_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal242 = null;
        IToken char_literal243 = null;
        IToken string_literal244 = null;
        IToken char_literal245 = null;

        object string_literal242_tree=null;
        object char_literal243_tree=null;
        object string_literal244_tree=null;
        object char_literal245_tree=null;
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_85 = new RewriteRuleTokenStream(adaptor,"token 85");
        RewriteRuleTokenStream stream_38 = new RewriteRuleTokenStream(adaptor,"token 38");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:510:2: ( '\\\\begin' '{' 'tikzpicture' '}' -> ^( IM_STARTTAG '\\\\begin' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:510:4: '\\\\begin' '{' 'tikzpicture' '}'
            {
            	string_literal242=(IToken)Match(input,38,FOLLOW_38_in_tikzpicture_start2633); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_38.Add(string_literal242);

            	char_literal243=(IToken)Match(input,41,FOLLOW_41_in_tikzpicture_start2635); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(char_literal243);

            	string_literal244=(IToken)Match(input,85,FOLLOW_85_in_tikzpicture_start2637); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_85.Add(string_literal244);

            	char_literal245=(IToken)Match(input,42,FOLLOW_42_in_tikzpicture_start2639); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_42.Add(char_literal245);



            	// AST REWRITE
            	// elements:          38
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 510:36: -> ^( IM_STARTTAG '\\\\begin' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:510:39: ^( IM_STARTTAG '\\\\begin' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_38.NextNode());

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:512:1: tikzpicture_end : '\\\\end' '{' 'tikzpicture' '}' -> ^( IM_ENDTAG '\\\\end' ) ;
    public simpletikzParser.tikzpicture_end_return tikzpicture_end() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_end_return retval = new simpletikzParser.tikzpicture_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal246 = null;
        IToken char_literal247 = null;
        IToken string_literal248 = null;
        IToken char_literal249 = null;

        object string_literal246_tree=null;
        object char_literal247_tree=null;
        object string_literal248_tree=null;
        object char_literal249_tree=null;
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_61 = new RewriteRuleTokenStream(adaptor,"token 61");
        RewriteRuleTokenStream stream_85 = new RewriteRuleTokenStream(adaptor,"token 85");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:513:2: ( '\\\\end' '{' 'tikzpicture' '}' -> ^( IM_ENDTAG '\\\\end' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:513:4: '\\\\end' '{' 'tikzpicture' '}'
            {
            	string_literal246=(IToken)Match(input,61,FOLLOW_61_in_tikzpicture_end2657); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_61.Add(string_literal246);

            	char_literal247=(IToken)Match(input,41,FOLLOW_41_in_tikzpicture_end2659); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(char_literal247);

            	string_literal248=(IToken)Match(input,85,FOLLOW_85_in_tikzpicture_end2661); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_85.Add(string_literal248);

            	char_literal249=(IToken)Match(input,42,FOLLOW_42_in_tikzpicture_end2663); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_42.Add(char_literal249);



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
            	// 513:34: -> ^( IM_ENDTAG '\\\\end' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:513:37: ^( IM_ENDTAG '\\\\end' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:515:1: tikzscope_start : '\\\\begin' '{' 'scope' '}' -> ^( IM_STARTTAG '\\\\begin' ) ;
    public simpletikzParser.tikzscope_start_return tikzscope_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_start_return retval = new simpletikzParser.tikzscope_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal250 = null;
        IToken char_literal251 = null;
        IToken string_literal252 = null;
        IToken char_literal253 = null;

        object string_literal250_tree=null;
        object char_literal251_tree=null;
        object string_literal252_tree=null;
        object char_literal253_tree=null;
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_86 = new RewriteRuleTokenStream(adaptor,"token 86");
        RewriteRuleTokenStream stream_38 = new RewriteRuleTokenStream(adaptor,"token 38");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:516:2: ( '\\\\begin' '{' 'scope' '}' -> ^( IM_STARTTAG '\\\\begin' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:516:4: '\\\\begin' '{' 'scope' '}'
            {
            	string_literal250=(IToken)Match(input,38,FOLLOW_38_in_tikzscope_start2681); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_38.Add(string_literal250);

            	char_literal251=(IToken)Match(input,41,FOLLOW_41_in_tikzscope_start2683); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(char_literal251);

            	string_literal252=(IToken)Match(input,86,FOLLOW_86_in_tikzscope_start2685); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_86.Add(string_literal252);

            	char_literal253=(IToken)Match(input,42,FOLLOW_42_in_tikzscope_start2687); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_42.Add(char_literal253);



            	// AST REWRITE
            	// elements:          38
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 516:30: -> ^( IM_STARTTAG '\\\\begin' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:516:33: ^( IM_STARTTAG '\\\\begin' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_38.NextNode());

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:518:1: tikzscope_end : '\\\\end' '{' 'scope' '}' -> ^( IM_ENDTAG '\\\\end' ) ;
    public simpletikzParser.tikzscope_end_return tikzscope_end() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_end_return retval = new simpletikzParser.tikzscope_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal254 = null;
        IToken char_literal255 = null;
        IToken string_literal256 = null;
        IToken char_literal257 = null;

        object string_literal254_tree=null;
        object char_literal255_tree=null;
        object string_literal256_tree=null;
        object char_literal257_tree=null;
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_86 = new RewriteRuleTokenStream(adaptor,"token 86");
        RewriteRuleTokenStream stream_61 = new RewriteRuleTokenStream(adaptor,"token 61");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:519:2: ( '\\\\end' '{' 'scope' '}' -> ^( IM_ENDTAG '\\\\end' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:519:4: '\\\\end' '{' 'scope' '}'
            {
            	string_literal254=(IToken)Match(input,61,FOLLOW_61_in_tikzscope_end2705); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_61.Add(string_literal254);

            	char_literal255=(IToken)Match(input,41,FOLLOW_41_in_tikzscope_end2707); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(char_literal255);

            	string_literal256=(IToken)Match(input,86,FOLLOW_86_in_tikzscope_end2709); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_86.Add(string_literal256);

            	char_literal257=(IToken)Match(input,42,FOLLOW_42_in_tikzscope_end2711); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_42.Add(char_literal257);



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
            	// 519:28: -> ^( IM_ENDTAG '\\\\end' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:519:31: ^( IM_ENDTAG '\\\\end' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:521:1: path_start : path_start_tag -> ^( IM_STARTTAG path_start_tag ) ;
    public simpletikzParser.path_start_return path_start() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_return retval = new simpletikzParser.path_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.path_start_tag_return path_start_tag258 = default(simpletikzParser.path_start_tag_return);


        RewriteRuleSubtreeStream stream_path_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule path_start_tag");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:522:2: ( path_start_tag -> ^( IM_STARTTAG path_start_tag ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:522:4: path_start_tag
            {
            	PushFollow(FOLLOW_path_start_tag_in_path_start2730);
            	path_start_tag258 = path_start_tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_path_start_tag.Add(path_start_tag258.Tree);


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
            	// 522:19: -> ^( IM_STARTTAG path_start_tag )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:522:22: ^( IM_STARTTAG path_start_tag )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:524:1: node_start : node_start_tag -> ^( IM_STARTTAG node_start_tag ) ;
    public simpletikzParser.node_start_return node_start() // throws RecognitionException [1]
    {   
        simpletikzParser.node_start_return retval = new simpletikzParser.node_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.node_start_tag_return node_start_tag259 = default(simpletikzParser.node_start_tag_return);


        RewriteRuleSubtreeStream stream_node_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule node_start_tag");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:525:2: ( node_start_tag -> ^( IM_STARTTAG node_start_tag ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:525:4: node_start_tag
            {
            	PushFollow(FOLLOW_node_start_tag_in_node_start2748);
            	node_start_tag259 = node_start_tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_node_start_tag.Add(node_start_tag259.Tree);


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
            	// 525:19: -> ^( IM_STARTTAG node_start_tag )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:525:22: ^( IM_STARTTAG node_start_tag )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:527:1: matrix_start : matrix_start_tag -> ^( IM_STARTTAG matrix_start_tag ) ;
    public simpletikzParser.matrix_start_return matrix_start() // throws RecognitionException [1]
    {   
        simpletikzParser.matrix_start_return retval = new simpletikzParser.matrix_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.matrix_start_tag_return matrix_start_tag260 = default(simpletikzParser.matrix_start_tag_return);


        RewriteRuleSubtreeStream stream_matrix_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule matrix_start_tag");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:528:2: ( matrix_start_tag -> ^( IM_STARTTAG matrix_start_tag ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:528:4: matrix_start_tag
            {
            	PushFollow(FOLLOW_matrix_start_tag_in_matrix_start2766);
            	matrix_start_tag260 = matrix_start_tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_matrix_start_tag.Add(matrix_start_tag260.Tree);


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
            	// 528:21: -> ^( IM_STARTTAG matrix_start_tag )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:528:24: ^( IM_STARTTAG matrix_start_tag )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:530:1: node_start_tag : '\\\\node' ;
    public simpletikzParser.node_start_tag_return node_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.node_start_tag_return retval = new simpletikzParser.node_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal261 = null;

        object string_literal261_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:531:2: ( '\\\\node' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:531:4: '\\\\node'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal261=(IToken)Match(input,62,FOLLOW_62_in_node_start_tag2784); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal261_tree = (object)adaptor.Create(string_literal261);
            		adaptor.AddChild(root_0, string_literal261_tree);
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:533:1: matrix_start_tag : '\\\\matrix' ;
    public simpletikzParser.matrix_start_tag_return matrix_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.matrix_start_tag_return retval = new simpletikzParser.matrix_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal262 = null;

        object string_literal262_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:534:2: ( '\\\\matrix' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:534:4: '\\\\matrix'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal262=(IToken)Match(input,63,FOLLOW_63_in_matrix_start_tag2794); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal262_tree = (object)adaptor.Create(string_literal262);
            		adaptor.AddChild(root_0, string_literal262_tree);
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:536:1: coordinate_start : '\\\\coordinate' -> ^( IM_STARTTAG '\\\\coordinate' ) ;
    public simpletikzParser.coordinate_start_return coordinate_start() // throws RecognitionException [1]
    {   
        simpletikzParser.coordinate_start_return retval = new simpletikzParser.coordinate_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal263 = null;

        object string_literal263_tree=null;
        RewriteRuleTokenStream stream_64 = new RewriteRuleTokenStream(adaptor,"token 64");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:537:2: ( '\\\\coordinate' -> ^( IM_STARTTAG '\\\\coordinate' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:537:4: '\\\\coordinate'
            {
            	string_literal263=(IToken)Match(input,64,FOLLOW_64_in_coordinate_start2804); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_64.Add(string_literal263);



            	// AST REWRITE
            	// elements:          64
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 537:19: -> ^( IM_STARTTAG '\\\\coordinate' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:537:22: ^( IM_STARTTAG '\\\\coordinate' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_64.NextNode());

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:539:1: path_start_tag : ( '\\\\draw' | '\\\\fill' | '\\\\path' | '\\\\clip' );
    public simpletikzParser.path_start_tag_return path_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_tag_return retval = new simpletikzParser.path_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set264 = null;

        object set264_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:540:2: ( '\\\\draw' | '\\\\fill' | '\\\\path' | '\\\\clip' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set264 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 65 && input.LA(1) <= 68) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set264));
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
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:341:8: ( tikzcoordinate_core3 )
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:341:9: tikzcoordinate_core3
        {
        	PushFollow(FOLLOW_tikzcoordinate_core3_in_synpred1_simpletikz1679);
        	tikzcoordinate_core3();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred1_simpletikz"

    // $ANTLR start "synpred2_simpletikz"
    public void synpred2_simpletikz_fragment() {
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:342:12: ( tikzcoordinate_core2 )
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:342:13: tikzcoordinate_core2
        {
        	PushFollow(FOLLOW_tikzcoordinate_core2_in_synpred2_simpletikz1698);
        	tikzcoordinate_core2();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred2_simpletikz"

    // $ANTLR start "synpred3_simpletikz"
    public void synpred3_simpletikz_fragment() {
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:343:12: ( tikzcoordinate_core1 )
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:343:13: tikzcoordinate_core1
        {
        	PushFollow(FOLLOW_tikzcoordinate_core1_in_synpred3_simpletikz1718);
        	tikzcoordinate_core1();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred3_simpletikz"

    // $ANTLR start "synpred4_simpletikz"
    public void synpred4_simpletikz_fragment() {
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:352:21: ( tikzcoordinate_core3 )
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:352:22: tikzcoordinate_core3
        {
        	PushFollow(FOLLOW_tikzcoordinate_core3_in_synpred4_simpletikz1803);
        	tikzcoordinate_core3();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred4_simpletikz"

    // $ANTLR start "synpred5_simpletikz"
    public void synpred5_simpletikz_fragment() {
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:353:12: ( tikzcoordinate_core2 )
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:353:13: tikzcoordinate_core2
        {
        	PushFollow(FOLLOW_tikzcoordinate_core2_in_synpred5_simpletikz1822);
        	tikzcoordinate_core2();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred5_simpletikz"

    // $ANTLR start "synpred6_simpletikz"
    public void synpred6_simpletikz_fragment() {
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:354:12: ( tikzcoordinate_core1 )
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:354:13: tikzcoordinate_core1
        {
        	PushFollow(FOLLOW_tikzcoordinate_core1_in_synpred6_simpletikz1842);
        	tikzcoordinate_core1();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred6_simpletikz"

    // $ANTLR start "synpred7_simpletikz"
    public void synpred7_simpletikz_fragment() {
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:401:28: ( size )
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:401:29: size
        {
        	PushFollow(FOLLOW_size_in_synpred7_simpletikz2124);
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


   	protected DFA9 dfa9;
   	protected DFA14 dfa14;
   	protected DFA28 dfa28;
   	protected DFA29 dfa29;
   	protected DFA41 dfa41;
   	protected DFA45 dfa45;
   	protected DFA47 dfa47;
   	protected DFA54 dfa54;
   	protected DFA56 dfa56;
   	protected DFA60 dfa60;
   	protected DFA63 dfa63;
	private void InitializeCyclicDFAs()
	{
    	this.dfa9 = new DFA9(this);
    	this.dfa14 = new DFA14(this);
    	this.dfa28 = new DFA28(this);
    	this.dfa29 = new DFA29(this);
    	this.dfa41 = new DFA41(this);
    	this.dfa45 = new DFA45(this);
    	this.dfa47 = new DFA47(this);
    	this.dfa54 = new DFA54(this);
    	this.dfa56 = new DFA56(this);
    	this.dfa60 = new DFA60(this);
    	this.dfa63 = new DFA63(this);
	    this.dfa45.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA45_SpecialStateTransition);
	    this.dfa47.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA47_SpecialStateTransition);
	    this.dfa54.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA54_SpecialStateTransition);
	}

    const string DFA9_eotS =
        "\x04\uffff";
    const string DFA9_eofS =
        "\x04\uffff";
    const string DFA9_minS =
        "\x02\x04\x02\uffff";
    const string DFA9_maxS =
        "\x02\x56\x02\uffff";
    const string DFA9_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA9_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA9_transitionS = {
            "\x25\x01\x03\uffff\x01\x01\x04\uffff\x01\x01\x05\uffff\x20"+
            "\x01",
            "\x25\x01\x01\uffff\x02\x02\x01\x01\x01\x02\x01\uffff\x02\x03"+
            "\x01\x01\x03\uffff\x01\x02\x01\uffff\x20\x01",
            "",
            ""
    };

    static readonly short[] DFA9_eot = DFA.UnpackEncodedString(DFA9_eotS);
    static readonly short[] DFA9_eof = DFA.UnpackEncodedString(DFA9_eofS);
    static readonly char[] DFA9_min = DFA.UnpackEncodedStringToUnsignedChars(DFA9_minS);
    static readonly char[] DFA9_max = DFA.UnpackEncodedStringToUnsignedChars(DFA9_maxS);
    static readonly short[] DFA9_accept = DFA.UnpackEncodedString(DFA9_acceptS);
    static readonly short[] DFA9_special = DFA.UnpackEncodedString(DFA9_specialS);
    static readonly short[][] DFA9_transition = DFA.UnpackEncodedStringArray(DFA9_transitionS);

    protected class DFA9 : DFA
    {
        public DFA9(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 9;
            this.eot = DFA9_eot;
            this.eof = DFA9_eof;
            this.min = DFA9_min;
            this.max = DFA9_max;
            this.accept = DFA9_accept;
            this.special = DFA9_special;
            this.transition = DFA9_transition;

        }

        override public string Description
        {
            get { return "170:1: option : ( option_style | option_kv );"; }
        }

    }

    const string DFA14_eotS =
        "\x38\uffff";
    const string DFA14_eofS =
        "\x38\uffff";
    const string DFA14_minS =
        "\x01\x04\x01\x2a\x01\x04\x02\uffff\x01\x2a\x01\uffff\x02\x04\x01"+
        "\uffff\x0f\x04\x01\uffff\x1e\x04";
    const string DFA14_maxS =
        "\x01\x56\x01\x3c\x01\x56\x02\uffff\x01\x35\x01\uffff\x02\x56\x01"+
        "\uffff\x0f\x56\x01\uffff\x1e\x56";
    const string DFA14_acceptS =
        "\x03\uffff\x01\x04\x01\x02\x01\uffff\x01\x01\x02\uffff\x01\x05"+
        "\x0f\uffff\x01\x03\x1e\uffff";
    const string DFA14_specialS =
        "\x38\uffff}>";
    static readonly string[] DFA14_transitionS = {
            "\x1a\x03\x02\x01\x09\x03\x01\x02\x02\uffff\x01\x03\x04\uffff"+
            "\x01\x03\x05\uffff\x20\x03",
            "\x01\x04\x02\uffff\x01\x04\x01\x06\x06\uffff\x01\x04\x01\uffff"+
            "\x06\x05",
            "\x2e\x09\x01\x07\x1e\x09\x02\x08\x04\x09",
            "",
            "",
            "\x01\x04\x02\uffff\x01\x04\x01\x06\x06\uffff\x01\x04",
            "",
            "\x1a\x0c\x02\x0a\x09\x0c\x01\x0b\x02\x09\x01\x0c\x04\x09\x01"+
            "\x0c\x05\x09\x20\x0c",
            "\x2e\x09\x01\x0d\x24\x09",
            "",
            "\x25\x0c\x02\x09\x01\x11\x01\x0c\x02\x0f\x02\x09\x01\x0c\x01"+
            "\x09\x01\x10\x03\x09\x06\x0e\x1a\x0c",
            "\x25\x12\x03\x09\x01\x12\x04\x09\x01\x12\x05\x09\x20\x12",
            "\x25\x0c\x02\x09\x01\x11\x01\x0c\x02\x13\x02\x09\x01\x0c\x01"+
            "\x09\x01\x10\x03\x09\x20\x0c",
            "\x1a\x15\x02\x14\x09\x15\x01\x0b\x02\x09\x01\x15\x04\x09\x01"+
            "\x15\x05\x09\x20\x15",
            "\x25\x0c\x02\x09\x01\x11\x01\x0c\x02\x0f\x02\x09\x01\x0c\x01"+
            "\x09\x01\x10\x03\x09\x20\x0c",
            "\x1a\x18\x02\x17\x09\x18\x01\x16\x02\x09\x01\x18\x04\x09\x01"+
            "\x18\x05\x09\x20\x18",
            "\x26\x09\x01\x19\x2c\x09",
            "\x1a\x09\x02\x1a\x37\x09",
            "\x25\x12\x01\x09\x01\x1b\x01\x09\x01\x12\x04\x09\x01\x12\x05"+
            "\x09\x20\x12",
            "\x25\x18\x01\x16\x02\x09\x01\x18\x04\x09\x01\x18\x05\x09\x20"+
            "\x18",
            "\x25\x15\x02\x09\x01\x11\x01\x15\x02\x0f\x02\x09\x01\x15\x05"+
            "\x09\x06\x1c\x1a\x15",
            "\x25\x15\x02\x09\x01\x11\x01\x15\x02\x13\x02\x09\x01\x15\x05"+
            "\x09\x20\x15",
            "\x25\x1d\x03\x09\x01\x1d\x04\x09\x01\x1d\x05\x09\x20\x1d",
            "\x25\x18\x02\x09\x01\x20\x01\x18\x04\x09\x01\x18\x01\x09\x01"+
            "\x1e\x03\x09\x06\x1f\x1a\x18",
            "\x25\x18\x02\x09\x01\x20\x01\x18\x04\x09\x01\x18\x01\x09\x01"+
            "\x21\x03\x09\x20\x18",
            "",
            "\x25\x24\x03\x09\x01\x24\x01\x23\x01\x13\x02\x09\x01\x24\x05"+
            "\x09\x06\x22\x1a\x24",
            "\x29\x09\x02\x25\x28\x09",
            "\x25\x15\x02\x09\x01\x11\x01\x15\x02\x0f\x02\x09\x01\x15\x05"+
            "\x09\x20\x15",
            "\x25\x1d\x01\x09\x01\x26\x01\x09\x01\x1d\x04\x09\x01\x1d\x05"+
            "\x09\x20\x1d",
            "\x26\x09\x01\x19\x2c\x09",
            "\x25\x18\x02\x09\x01\x20\x01\x18\x04\x09\x01\x18\x01\x09\x01"+
            "\x1e\x03\x09\x20\x18",
            "\x1a\x09\x02\x27\x37\x09",
            "\x26\x09\x01\x19\x2c\x09",
            "\x25\x24\x02\x09\x01\x11\x01\x24\x01\x23\x01\x13\x02\x09\x01"+
            "\x24\x05\x09\x20\x24",
            "\x25\x28\x01\x16\x02\x09\x01\x28\x02\x13\x02\x09\x01\x28\x05"+
            "\x09\x20\x28",
            "\x25\x24\x02\x09\x01\x11\x01\x24\x04\x09\x01\x24\x05\x09\x20"+
            "\x24",
            "\x25\x29\x01\x16\x02\x09\x01\x29\x04\x09\x01\x29\x05\x09\x20"+
            "\x29",
            "\x2f\x09\x01\x2a\x23\x09",
            "\x25\x2d\x03\x09\x01\x2d\x01\x2c\x03\x09\x01\x2d\x01\x09\x01"+
            "\x21\x03\x09\x06\x2b\x1a\x2d",
            "\x25\x28\x02\x09\x01\x2e\x01\x28\x04\x09\x01\x28\x01\x09\x01"+
            "\x21\x03\x09\x20\x28",
            "\x25\x29\x02\x09\x01\x2f\x01\x29\x04\x09\x01\x29\x01\x09\x01"+
            "\x2a\x03\x09\x20\x29",
            "\x26\x09\x01\x19\x2c\x09",
            "\x25\x2d\x02\x09\x01\x20\x01\x2d\x01\x2c\x03\x09\x01\x2d\x01"+
            "\x09\x01\x21\x03\x09\x20\x2d",
            "\x25\x2d\x03\x09\x01\x2d\x04\x09\x01\x2d\x01\x09\x01\x21\x03"+
            "\x09\x20\x2d",
            "\x25\x2d\x02\x09\x01\x20\x01\x2d\x04\x09\x01\x2d\x05\x09\x20"+
            "\x2d",
            "\x1a\x09\x02\x30\x37\x09",
            "\x1a\x09\x02\x31\x37\x09",
            "\x25\x34\x03\x09\x01\x34\x01\x33\x01\x13\x02\x09\x01\x34\x01"+
            "\x09\x01\x21\x03\x09\x06\x32\x1a\x34",
            "\x25\x37\x03\x09\x01\x37\x01\x36\x03\x09\x01\x37\x01\x09\x01"+
            "\x2a\x03\x09\x06\x35\x1a\x37",
            "\x25\x34\x02\x09\x01\x2e\x01\x34\x01\x33\x01\x13\x02\x09\x01"+
            "\x34\x01\x09\x01\x21\x03\x09\x20\x34",
            "\x25\x28\x01\x16\x02\x09\x01\x28\x02\x13\x02\x09\x01\x28\x01"+
            "\x09\x01\x21\x03\x09\x20\x28",
            "\x25\x34\x02\x09\x01\x2e\x01\x34\x04\x09\x01\x34\x05\x09\x20"+
            "\x34",
            "\x25\x37\x02\x09\x01\x2f\x01\x37\x01\x36\x03\x09\x01\x37\x01"+
            "\x09\x01\x2a\x03\x09\x20\x37",
            "\x25\x37\x03\x09\x01\x37\x04\x09\x01\x37\x01\x09\x01\x2a\x03"+
            "\x09\x20\x37",
            "\x25\x37\x02\x09\x01\x2f\x01\x37\x04\x09\x01\x37\x05\x09\x20"+
            "\x37"
    };

    static readonly short[] DFA14_eot = DFA.UnpackEncodedString(DFA14_eotS);
    static readonly short[] DFA14_eof = DFA.UnpackEncodedString(DFA14_eofS);
    static readonly char[] DFA14_min = DFA.UnpackEncodedStringToUnsignedChars(DFA14_minS);
    static readonly char[] DFA14_max = DFA.UnpackEncodedStringToUnsignedChars(DFA14_maxS);
    static readonly short[] DFA14_accept = DFA.UnpackEncodedString(DFA14_acceptS);
    static readonly short[] DFA14_special = DFA.UnpackEncodedString(DFA14_specialS);
    static readonly short[][] DFA14_transition = DFA.UnpackEncodedStringArray(DFA14_transitionS);

    protected class DFA14 : DFA
    {
        public DFA14(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 14;
            this.eot = DFA14_eot;
            this.eof = DFA14_eof;
            this.min = DFA14_min;
            this.max = DFA14_max;
            this.accept = DFA14_accept;
            this.special = DFA14_special;
            this.transition = DFA14_transition;

        }

        override public string Description
        {
            get { return "186:1: iddornumberunitorstringorrange : ( range | numberunit | bracedcoord | idd | tikzstring );"; }
        }

    }

    const string DFA28_eotS =
        "\x0d\uffff";
    const string DFA28_eofS =
        "\x0d\uffff";
    const string DFA28_minS =
        "\x01\x04\x01\x29\x08\uffff\x01\x1c\x02\uffff";
    const string DFA28_maxS =
        "\x01\x56\x01\x29\x08\uffff\x01\x56\x02\uffff";
    const string DFA28_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07\x01"+
        "\x09\x01\x0a\x01\uffff\x01\x01\x01\x08";
    const string DFA28_specialS =
        "\x0d\uffff}>";
    static readonly string[] DFA28_transitionS = {
            "\x22\x09\x01\x01\x01\x07\x01\x06\x0b\x09\x01\uffff\x08\x09"+
            "\x01\x08\x01\x03\x01\x04\x01\x05\x04\x02\x12\x09",
            "\x01\x0a",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0c\x39\uffff\x01\x0b",
            "",
            ""
    };

    static readonly short[] DFA28_eot = DFA.UnpackEncodedString(DFA28_eotS);
    static readonly short[] DFA28_eof = DFA.UnpackEncodedString(DFA28_eofS);
    static readonly char[] DFA28_min = DFA.UnpackEncodedStringToUnsignedChars(DFA28_minS);
    static readonly char[] DFA28_max = DFA.UnpackEncodedStringToUnsignedChars(DFA28_maxS);
    static readonly short[] DFA28_accept = DFA.UnpackEncodedString(DFA28_acceptS);
    static readonly short[] DFA28_special = DFA.UnpackEncodedString(DFA28_specialS);
    static readonly short[][] DFA28_transition = DFA.UnpackEncodedStringArray(DFA28_transitionS);

    protected class DFA28 : DFA
    {
        public DFA28(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 28;
            this.eot = DFA28_eot;
            this.eof = DFA28_eof;
            this.min = DFA28_min;
            this.max = DFA28_max;
            this.accept = DFA28_accept;
            this.special = DFA28_special;
            this.transition = DFA28_transition;

        }

        override public string Description
        {
            get { return "246:4: ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr )"; }
        }

    }

    const string DFA29_eotS =
        "\x10\uffff";
    const string DFA29_eofS =
        "\x10\uffff";
    const string DFA29_minS =
        "\x01\x04\x02\x29\x07\uffff\x02\x1c\x04\uffff";
    const string DFA29_maxS =
        "\x01\x56\x02\x29\x07\uffff\x02\x56\x04\uffff";
    const string DFA29_acceptS =
        "\x03\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07\x01"+
        "\x0a\x02\uffff\x01\x0b\x01\x09\x01\x01\x01\x08";
    const string DFA29_specialS =
        "\x10\uffff}>";
    static readonly string[] DFA29_transitionS = {
            "\x22\x09\x01\x02\x01\x08\x01\x07\x14\x09\x01\x01\x01\x04\x01"+
            "\x05\x01\x06\x04\x03\x12\x09",
            "\x01\x0a",
            "\x01\x0b",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0d\x38\uffff\x02\x0c",
            "\x01\x0f\x39\uffff\x01\x0e",
            "",
            "",
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
            get { return "()* loopback of 247:3: ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*"; }
        }

    }

    const string DFA41_eotS =
        "\x4b\uffff";
    const string DFA41_eofS =
        "\x4b\uffff";
    const string DFA41_minS =
        "\x01\x1c\x01\uffff\x01\x04\x08\uffff\x01\x04\x01\uffff\x0c\x04"+
        "\x01\uffff\x16\x04\x01\x1c\x0c\x04\x01\uffff\x05\x04\x01\x1c\x07"+
        "\x04";
    const string DFA41_maxS =
        "\x01\x53\x01\uffff\x01\x56\x08\uffff\x01\x56\x01\uffff\x0c\x56"+
        "\x01\uffff\x16\x56\x01\x53\x0c\x56\x01\uffff\x05\x56\x01\x53\x07"+
        "\x56";
    const string DFA41_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x01\x08\x01\x0a\x01\uffff\x01\x09\x0c\uffff\x01\x02"+
        "\x23\uffff\x01\x02\x0d\uffff";
    const string DFA41_specialS =
        "\x4b\uffff}>";
    static readonly string[] DFA41_transitionS = {
            "\x01\x0a\x0c\uffff\x01\x09\x08\uffff\x01\x02\x01\uffff\x01"+
            "\x01\x12\uffff\x01\x06\x01\x05\x01\uffff\x02\x07\x01\x08\x04"+
            "\x0a\x02\x03\x01\x04",
            "",
            "\x18\x03\x01\x13\x0c\x03\x01\x14\x02\uffff\x01\x03\x04\uffff"+
            "\x01\x03\x03\x0c\x02\uffff\x10\x03\x01\x0f\x01\x0e\x01\x03\x01"+
            "\x10\x01\x11\x01\x12\x04\x13\x02\x0b\x01\x0d\x03\x03",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x25\x03\x02\uffff\x04\x03\x02\uffff\x01\x03\x01\x0c\x01\x03"+
            "\x03\uffff\x20\x03",
            "",
            "\x25\x03\x02\uffff\x04\x03\x02\uffff\x01\x03\x01\uffff\x01"+
            "\x03\x03\uffff\x1d\x03\x01\x15\x02\x03",
            "\x25\x03\x01\x0c\x01\uffff\x04\x03\x02\uffff\x01\x03\x01\x0c"+
            "\x01\x03\x01\x0c\x02\uffff\x12\x03\x01\x16\x0d\x03",
            "\x18\x19\x01\x13\x0c\x19\x01\x0c\x01\uffff\x01\x03\x01\x19"+
            "\x01\x18\x01\x03\x02\uffff\x01\x19\x01\x0c\x01\x19\x01\x0c\x02"+
            "\uffff\x10\x19\x01\x0f\x01\x0e\x01\x17\x01\x10\x01\x11\x01\x12"+
            "\x04\x13\x02\x0b\x01\x0d\x03\x19",
            "\x18\x19\x01\x13\x0c\x19\x01\x0c\x01\uffff\x02\x19\x01\x18"+
            "\x01\x19\x02\uffff\x01\x19\x01\x0c\x01\x19\x01\x0c\x02\uffff"+
            "\x10\x19\x01\x0f\x01\x0e\x01\x19\x01\x10\x01\x11\x01\x12\x04"+
            "\x13\x02\x0b\x01\x0d\x03\x19",
            "\x18\x19\x01\x13\x0c\x19\x01\x0c\x01\uffff\x02\x19\x01\x18"+
            "\x01\x19\x02\uffff\x01\x19\x01\x0c\x01\x19\x01\x0c\x02\uffff"+
            "\x10\x19\x01\x0f\x01\x0e\x01\x19\x01\x10\x01\x11\x01\x12\x04"+
            "\x13\x02\x0b\x01\x0d\x03\x19",
            "\x18\x19\x01\x13\x0c\x19\x01\x0c\x01\uffff\x02\x19\x01\x18"+
            "\x01\x19\x02\uffff\x01\x19\x01\x0c\x01\x19\x01\x0c\x02\uffff"+
            "\x10\x19\x01\x0f\x01\x0e\x01\x19\x01\x10\x01\x11\x01\x12\x04"+
            "\x13\x02\x0b\x01\x0d\x03\x19",
            "\x18\x19\x01\x13\x0c\x19\x01\x0c\x01\uffff\x02\x19\x01\x18"+
            "\x01\x19\x02\uffff\x01\x19\x01\x0c\x01\x19\x01\x0c\x02\uffff"+
            "\x10\x19\x01\x0f\x01\x0e\x01\x19\x01\x10\x01\x11\x01\x12\x04"+
            "\x13\x02\x0b\x01\x0d\x03\x19",
            "\x18\x19\x01\x21\x0c\x19\x02\x0c\x01\uffff\x01\x19\x04\uffff"+
            "\x01\x19\x01\x0c\x01\uffff\x01\x0c\x02\uffff\x10\x19\x01\x1d"+
            "\x01\x1c\x01\x19\x01\x1e\x01\x1f\x01\x20\x04\x21\x02\x1a\x01"+
            "\x1b\x03\x19",
            "\x25\x19\x02\uffff\x04\x19\x02\uffff\x01\x19\x01\x0c\x01\x19"+
            "\x03\uffff\x1a\x19\x02\x22\x04\x19",
            "\x25\x19\x02\uffff\x04\x19\x02\uffff\x01\x19\x01\x0c\x01\x19"+
            "\x03\uffff\x1a\x19\x02\x23\x04\x19",
            "\x25\x19\x02\uffff\x04\x19\x02\uffff\x01\x19\x01\x0c\x01\x19"+
            "\x03\uffff\x1a\x19\x02\x24\x04\x19",
            "\x18\x19\x01\x2d\x0c\x19\x01\x26\x02\uffff\x01\x19\x04\uffff"+
            "\x01\x19\x03\x0c\x02\uffff\x10\x19\x01\x29\x01\x28\x01\x19\x01"+
            "\x2a\x01\x2b\x01\x2c\x04\x2d\x02\x25\x01\x27\x03\x19",
            "",
            "\x25\x19\x01\uffff\x01\x19\x01\uffff\x01\x19\x04\uffff\x01"+
            "\x19\x01\x0c\x04\uffff\x20\x19",
            "\x25\x19\x01\uffff\x01\x19\x01\uffff\x01\x19\x04\uffff\x01"+
            "\x19\x05\uffff\x1d\x19\x01\x2e\x02\x19",
            "\x25\x19\x01\x0c\x01\x19\x01\uffff\x01\x19\x04\uffff\x01\x19"+
            "\x01\x0c\x01\uffff\x01\x0c\x02\uffff\x12\x19\x01\x2f\x0d\x19",
            "\x18\x19\x01\x21\x0c\x19\x01\x0c\x01\x30\x01\uffff\x01\x19"+
            "\x01\x0c\x03\uffff\x01\x19\x01\x0c\x01\uffff\x01\x0c\x02\uffff"+
            "\x10\x19\x01\x1d\x01\x1c\x01\x31\x01\x1e\x01\x1f\x01\x20\x04"+
            "\x21\x02\x1a\x01\x1b\x03\x19",
            "\x18\x19\x01\x21\x0c\x19\x01\x0c\x01\x30\x01\uffff\x01\x19"+
            "\x01\x0c\x03\uffff\x01\x19\x01\x0c\x01\uffff\x01\x0c\x02\uffff"+
            "\x10\x19\x01\x1d\x01\x1c\x01\x19\x01\x1e\x01\x1f\x01\x20\x04"+
            "\x21\x02\x1a\x01\x1b\x03\x19",
            "\x18\x19\x01\x21\x0c\x19\x01\x0c\x01\x30\x01\uffff\x01\x19"+
            "\x01\x0c\x03\uffff\x01\x19\x01\x0c\x01\uffff\x01\x0c\x02\uffff"+
            "\x10\x19\x01\x1d\x01\x1c\x01\x19\x01\x1e\x01\x1f\x01\x20\x04"+
            "\x21\x02\x1a\x01\x1b\x03\x19",
            "\x18\x19\x01\x21\x0c\x19\x01\x0c\x01\x30\x01\uffff\x01\x19"+
            "\x01\x0c\x03\uffff\x01\x19\x01\x0c\x01\uffff\x01\x0c\x02\uffff"+
            "\x10\x19\x01\x1d\x01\x1c\x01\x19\x01\x1e\x01\x1f\x01\x20\x04"+
            "\x21\x02\x1a\x01\x1b\x03\x19",
            "\x18\x19\x01\x21\x0c\x19\x01\x0c\x01\x30\x01\uffff\x01\x19"+
            "\x01\x0c\x03\uffff\x01\x19\x01\x0c\x01\uffff\x01\x0c\x02\uffff"+
            "\x10\x19\x01\x1d\x01\x1c\x01\x19\x01\x1e\x01\x1f\x01\x20\x04"+
            "\x21\x02\x1a\x01\x1b\x03\x19",
            "\x25\x19\x02\uffff\x04\x19\x02\uffff\x01\x19\x01\x0c\x01\x19"+
            "\x03\uffff\x20\x19",
            "\x25\x19\x02\uffff\x04\x19\x02\uffff\x01\x19\x01\x0c\x01\x19"+
            "\x03\uffff\x20\x19",
            "\x25\x19\x02\uffff\x04\x19\x02\uffff\x01\x19\x01\x0c\x01\x19"+
            "\x03\uffff\x20\x19",
            "\x25\x19\x02\uffff\x02\x19\x04\uffff\x01\x19\x01\x0c\x01\x19"+
            "\x03\uffff\x20\x19",
            "\x18\x19\x01\x39\x0c\x19\x02\x0c\x01\uffff\x01\x19\x04\uffff"+
            "\x01\x19\x01\x0c\x01\uffff\x01\x0c\x02\uffff\x10\x19\x01\x35"+
            "\x01\x34\x01\x19\x01\x36\x01\x37\x01\x38\x04\x39\x02\x32\x01"+
            "\x33\x03\x19",
            "\x25\x19\x02\uffff\x02\x19\x04\uffff\x01\x19\x01\uffff\x01"+
            "\x19\x03\uffff\x1d\x19\x01\x3a\x02\x19",
            "\x25\x19\x01\x0c\x01\uffff\x02\x19\x04\uffff\x01\x19\x01\x0c"+
            "\x01\x19\x01\x0c\x02\uffff\x12\x19\x01\x3b\x0d\x19",
            "\x18\x3d\x01\x2d\x0c\x3d\x01\x0c\x01\uffff\x01\x19\x01\x3d"+
            "\x01\x0c\x03\uffff\x01\x3d\x01\x0c\x01\x3d\x01\x0c\x02\uffff"+
            "\x10\x3d\x01\x29\x01\x28\x01\x3c\x01\x2a\x01\x2b\x01\x2c\x04"+
            "\x2d\x02\x25\x01\x27\x03\x3d",
            "\x18\x3d\x01\x2d\x0c\x3d\x01\x0c\x01\uffff\x02\x3d\x01\x0c"+
            "\x03\uffff\x01\x3d\x01\x0c\x01\x3d\x01\x0c\x02\uffff\x10\x3d"+
            "\x01\x29\x01\x28\x01\x3d\x01\x2a\x01\x2b\x01\x2c\x04\x2d\x02"+
            "\x25\x01\x27\x03\x3d",
            "\x18\x3d\x01\x2d\x0c\x3d\x01\x0c\x01\uffff\x02\x3d\x01\x0c"+
            "\x03\uffff\x01\x3d\x01\x0c\x01\x3d\x01\x0c\x02\uffff\x10\x3d"+
            "\x01\x29\x01\x28\x01\x3d\x01\x2a\x01\x2b\x01\x2c\x04\x2d\x02"+
            "\x25\x01\x27\x03\x3d",
            "\x18\x3d\x01\x2d\x0c\x3d\x01\x0c\x01\uffff\x02\x3d\x01\x0c"+
            "\x03\uffff\x01\x3d\x01\x0c\x01\x3d\x01\x0c\x02\uffff\x10\x3d"+
            "\x01\x29\x01\x28\x01\x3d\x01\x2a\x01\x2b\x01\x2c\x04\x2d\x02"+
            "\x25\x01\x27\x03\x3d",
            "\x18\x3d\x01\x2d\x0c\x3d\x01\x0c\x01\uffff\x02\x3d\x01\x0c"+
            "\x03\uffff\x01\x3d\x01\x0c\x01\x3d\x01\x0c\x02\uffff\x10\x3d"+
            "\x01\x29\x01\x28\x01\x3d\x01\x2a\x01\x2b\x01\x2c\x04\x2d\x02"+
            "\x25\x01\x27\x03\x3d",
            "\x25\x3d\x01\uffff\x01\x3d\x01\uffff\x01\x3d\x04\uffff\x01"+
            "\x3d\x01\x0c\x04\uffff\x1a\x3d\x02\x3e\x04\x3d",
            "\x25\x3d\x01\uffff\x01\x3d\x01\uffff\x01\x3d\x04\uffff\x01"+
            "\x3d\x01\x0c\x04\uffff\x1a\x3d\x02\x3f\x04\x3d",
            "\x01\x0c\x0c\uffff\x01\x0c\x03\uffff\x01\x18\x01\x3d\x03\uffff"+
            "\x03\x0c\x12\uffff\x02\x0c\x01\uffff\x0a\x0c",
            "\x25\x3d\x01\uffff\x01\x3d\x01\uffff\x01\x3d\x04\uffff\x01"+
            "\x3d\x01\x0c\x04\uffff\x1a\x3d\x02\x40\x04\x3d",
            "\x25\x3d\x01\uffff\x01\x3d\x01\uffff\x01\x3d\x04\uffff\x01"+
            "\x3d\x01\x0c\x04\uffff\x20\x3d",
            "\x25\x3d\x01\uffff\x01\x3d\x01\uffff\x01\x3d\x04\uffff\x01"+
            "\x3d\x05\uffff\x1d\x3d\x01\x41\x02\x3d",
            "\x25\x3d\x01\x0c\x01\x3d\x01\uffff\x01\x3d\x04\uffff\x01\x3d"+
            "\x01\x0c\x01\uffff\x01\x0c\x02\uffff\x12\x3d\x01\x42\x0d\x3d",
            "\x18\x3d\x01\x39\x0c\x3d\x01\x0c\x01\x43\x01\uffff\x01\x3d"+
            "\x01\x0c\x03\uffff\x01\x3d\x01\x0c\x01\uffff\x01\x0c\x02\uffff"+
            "\x10\x3d\x01\x35\x01\x34\x01\x44\x01\x36\x01\x37\x01\x38\x04"+
            "\x39\x02\x32\x01\x33\x03\x3d",
            "\x18\x3d\x01\x39\x0c\x3d\x01\x0c\x01\x43\x01\uffff\x01\x3d"+
            "\x01\x0c\x03\uffff\x01\x3d\x01\x0c\x01\uffff\x01\x0c\x02\uffff"+
            "\x10\x3d\x01\x35\x01\x34\x01\x3d\x01\x36\x01\x37\x01\x38\x04"+
            "\x39\x02\x32\x01\x33\x03\x3d",
            "\x18\x3d\x01\x39\x0c\x3d\x01\x0c\x01\x43\x01\uffff\x01\x3d"+
            "\x01\x0c\x03\uffff\x01\x3d\x01\x0c\x01\uffff\x01\x0c\x02\uffff"+
            "\x10\x3d\x01\x35\x01\x34\x01\x3d\x01\x36\x01\x37\x01\x38\x04"+
            "\x39\x02\x32\x01\x33\x03\x3d",
            "\x18\x3d\x01\x39\x0c\x3d\x01\x0c\x01\x43\x01\uffff\x01\x3d"+
            "\x01\x0c\x03\uffff\x01\x3d\x01\x0c\x01\uffff\x01\x0c\x02\uffff"+
            "\x10\x3d\x01\x35\x01\x34\x01\x3d\x01\x36\x01\x37\x01\x38\x04"+
            "\x39\x02\x32\x01\x33\x03\x3d",
            "\x18\x3d\x01\x39\x0c\x3d\x01\x0c\x01\x43\x01\uffff\x01\x3d"+
            "\x01\x0c\x03\uffff\x01\x3d\x01\x0c\x01\uffff\x01\x0c\x02\uffff"+
            "\x10\x3d\x01\x35\x01\x34\x01\x3d\x01\x36\x01\x37\x01\x38\x04"+
            "\x39\x02\x32\x01\x33\x03\x3d",
            "\x25\x3d\x02\uffff\x02\x3d\x04\uffff\x01\x3d\x01\x0c\x01\x3d"+
            "\x03\uffff\x1a\x3d\x02\x45\x04\x3d",
            "\x25\x3d\x02\uffff\x02\x3d\x04\uffff\x01\x3d\x01\x0c\x01\x3d"+
            "\x03\uffff\x1a\x3d\x02\x46\x04\x3d",
            "\x25\x3d\x02\uffff\x02\x3d\x04\uffff\x01\x3d\x01\x0c\x01\x3d"+
            "\x03\uffff\x1a\x3d\x02\x47\x04\x3d",
            "",
            "\x25\x3d\x01\uffff\x01\x3d\x01\uffff\x01\x3d\x04\uffff\x01"+
            "\x3d\x01\x0c\x04\uffff\x20\x3d",
            "\x25\x3d\x01\uffff\x01\x3d\x01\uffff\x01\x3d\x04\uffff\x01"+
            "\x3d\x01\x0c\x04\uffff\x20\x3d",
            "\x25\x3d\x01\uffff\x01\x3d\x01\uffff\x01\x3d\x04\uffff\x01"+
            "\x3d\x01\x0c\x04\uffff\x20\x3d",
            "\x25\x3d\x01\uffff\x01\x3d\x01\uffff\x01\x3d\x04\uffff\x01"+
            "\x3d\x01\x0c\x04\uffff\x1a\x3d\x02\x48\x04\x3d",
            "\x25\x3d\x01\uffff\x01\x3d\x01\uffff\x01\x3d\x04\uffff\x01"+
            "\x3d\x01\x0c\x04\uffff\x1a\x3d\x02\x49\x04\x3d",
            "\x01\x0c\x0c\uffff\x01\x0c\x03\uffff\x01\x0c\x04\uffff\x01"+
            "\x0c\x01\x3d\x01\x0c\x12\uffff\x02\x0c\x01\uffff\x0a\x0c",
            "\x25\x3d\x01\uffff\x01\x3d\x01\uffff\x01\x3d\x04\uffff\x01"+
            "\x3d\x01\x0c\x04\uffff\x1a\x3d\x02\x4a\x04\x3d",
            "\x25\x3d\x02\uffff\x02\x3d\x04\uffff\x01\x3d\x01\x0c\x01\x3d"+
            "\x03\uffff\x20\x3d",
            "\x25\x3d\x02\uffff\x02\x3d\x04\uffff\x01\x3d\x01\x0c\x01\x3d"+
            "\x03\uffff\x20\x3d",
            "\x25\x3d\x02\uffff\x02\x3d\x04\uffff\x01\x3d\x01\x0c\x01\x3d"+
            "\x03\uffff\x20\x3d",
            "\x25\x3d\x01\uffff\x01\x3d\x01\uffff\x01\x3d\x04\uffff\x01"+
            "\x3d\x01\x0c\x04\uffff\x20\x3d",
            "\x25\x3d\x01\uffff\x01\x3d\x01\uffff\x01\x3d\x04\uffff\x01"+
            "\x3d\x01\x0c\x04\uffff\x20\x3d",
            "\x25\x3d\x01\uffff\x01\x3d\x01\uffff\x01\x3d\x04\uffff\x01"+
            "\x3d\x01\x0c\x04\uffff\x20\x3d"
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
            get { return "312:1: tikzpath_element_single : ( tikz_options | coord | controls | tikznode_int | tikzcoordinate_int | circle | arc | roundbr_start ( tikzpath_element )* roundbr_end -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end ) | '(' ( tikzpath_element )* ')' -> ^( IM_PATH '(' ( tikzpath_element )* ')' ) | edgeop );"; }
        }

    }

    const string DFA45_eotS =
        "\x11\uffff";
    const string DFA45_eofS =
        "\x11\uffff";
    const string DFA45_minS =
        "\x01\x1c\x03\x00\x0d\uffff";
    const string DFA45_maxS =
        "\x01\x53\x03\x00\x0d\uffff";
    const string DFA45_acceptS =
        "\x04\uffff\x01\x04\x09\uffff\x01\x01\x01\x02\x01\x03";
    const string DFA45_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x0d\uffff}>";
    static readonly string[] DFA45_transitionS = {
            "\x01\x04\x0c\uffff\x01\x04\x08\uffff\x01\x01\x01\uffff\x01"+
            "\x03\x01\uffff\x01\x04\x10\uffff\x02\x04\x01\x02\x0a\x04",
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
            get { return "341:5: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?"; }
        }

    }


    protected internal int DFA45_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA45_1 = input.LA(1);

                   	 
                   	int index45_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_simpletikz()) ) { s = 14; }

                   	else if ( (synpred2_simpletikz()) ) { s = 15; }

                   	else if ( (synpred3_simpletikz()) ) { s = 16; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index45_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA45_2 = input.LA(1);

                   	 
                   	int index45_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_simpletikz()) ) { s = 14; }

                   	else if ( (synpred2_simpletikz()) ) { s = 15; }

                   	else if ( (synpred3_simpletikz()) ) { s = 16; }

                   	 
                   	input.Seek(index45_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA45_3 = input.LA(1);

                   	 
                   	int index45_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_simpletikz()) ) { s = 14; }

                   	else if ( (synpred2_simpletikz()) ) { s = 15; }

                   	else if ( (synpred3_simpletikz()) ) { s = 16; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index45_3);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae45 =
            new NoViableAltException(dfa.Description, 45, _s, input);
        dfa.Error(nvae45);
        throw nvae45;
    }
    const string DFA47_eotS =
        "\x16\uffff";
    const string DFA47_eofS =
        "\x16\uffff";
    const string DFA47_minS =
        "\x01\x1c\x03\x00\x12\uffff";
    const string DFA47_maxS =
        "\x01\x53\x03\x00\x12\uffff";
    const string DFA47_acceptS =
        "\x04\uffff\x01\x04\x0e\uffff\x01\x01\x01\x02\x01\x03";
    const string DFA47_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x12\uffff}>";
    static readonly string[] DFA47_transitionS = {
            "\x02\x04\x0b\uffff\x02\x04\x02\uffff\x01\x04\x04\uffff\x01"+
            "\x01\x01\x04\x01\x03\x01\uffff\x01\x04\x01\uffff\x01\x04\x0e"+
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
            "",
            "",
            ""
    };

    static readonly short[] DFA47_eot = DFA.UnpackEncodedString(DFA47_eotS);
    static readonly short[] DFA47_eof = DFA.UnpackEncodedString(DFA47_eofS);
    static readonly char[] DFA47_min = DFA.UnpackEncodedStringToUnsignedChars(DFA47_minS);
    static readonly char[] DFA47_max = DFA.UnpackEncodedStringToUnsignedChars(DFA47_maxS);
    static readonly short[] DFA47_accept = DFA.UnpackEncodedString(DFA47_acceptS);
    static readonly short[] DFA47_special = DFA.UnpackEncodedString(DFA47_specialS);
    static readonly short[][] DFA47_transition = DFA.UnpackEncodedStringArray(DFA47_transitionS);

    protected class DFA47 : DFA
    {
        public DFA47(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 47;
            this.eot = DFA47_eot;
            this.eof = DFA47_eof;
            this.min = DFA47_min;
            this.max = DFA47_max;
            this.accept = DFA47_accept;
            this.special = DFA47_special;
            this.transition = DFA47_transition;

        }

        override public string Description
        {
            get { return "352:18: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?"; }
        }

    }


    protected internal int DFA47_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA47_1 = input.LA(1);

                   	 
                   	int index47_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred4_simpletikz()) ) { s = 19; }

                   	else if ( (synpred5_simpletikz()) ) { s = 20; }

                   	else if ( (synpred6_simpletikz()) ) { s = 21; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index47_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA47_2 = input.LA(1);

                   	 
                   	int index47_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred4_simpletikz()) ) { s = 19; }

                   	else if ( (synpred5_simpletikz()) ) { s = 20; }

                   	else if ( (synpred6_simpletikz()) ) { s = 21; }

                   	 
                   	input.Seek(index47_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA47_3 = input.LA(1);

                   	 
                   	int index47_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred4_simpletikz()) ) { s = 19; }

                   	else if ( (synpred5_simpletikz()) ) { s = 20; }

                   	else if ( (synpred6_simpletikz()) ) { s = 21; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index47_3);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae47 =
            new NoViableAltException(dfa.Description, 47, _s, input);
        dfa.Error(nvae47);
        throw nvae47;
    }
    const string DFA54_eotS =
        "\x0a\uffff";
    const string DFA54_eofS =
        "\x0a\uffff";
    const string DFA54_minS =
        "\x01\x1c\x01\x04\x01\uffff\x02\x04\x01\x00\x01\x04\x01\uffff\x02"+
        "\x04";
    const string DFA54_maxS =
        "\x01\x53\x01\x56\x01\uffff\x02\x56\x01\x00\x01\x56\x01\uffff\x02"+
        "\x56";
    const string DFA54_acceptS =
        "\x02\uffff\x01\x02\x04\uffff\x01\x01\x02\uffff";
    const string DFA54_specialS =
        "\x05\uffff\x01\x00\x04\uffff}>";
    static readonly string[] DFA54_transitionS = {
            "\x02\x02\x0b\uffff\x02\x02\x02\uffff\x01\x02\x04\uffff\x01"+
            "\x01\x02\x02\x01\uffff\x01\x02\x01\uffff\x01\x02\x0e\uffff\x02"+
            "\x02\x01\uffff\x0a\x02",
            "\x1a\x02\x02\x03\x0a\x02\x02\uffff\x01\x02\x04\uffff\x04\x02"+
            "\x02\uffff\x20\x02",
            "",
            "\x25\x02\x02\uffff\x04\x02\x02\uffff\x01\x02\x01\uffff\x01"+
            "\x05\x03\uffff\x06\x04\x09\x02\x01\x06\x10\x02",
            "\x25\x02\x02\uffff\x04\x02\x02\uffff\x01\x02\x01\uffff\x01"+
            "\x05\x03\uffff\x0f\x02\x01\x06\x10\x02",
            "\x01\uffff",
            "\x1a\x02\x02\x08\x09\x02\x02\uffff\x04\x02\x02\uffff\x01\x02"+
            "\x01\uffff\x01\x02\x03\uffff\x20\x02",
            "",
            "\x25\x02\x02\uffff\x04\x02\x02\uffff\x01\x02\x01\uffff\x01"+
            "\x05\x03\uffff\x06\x09\x1a\x02",
            "\x25\x02\x02\uffff\x04\x02\x02\uffff\x01\x02\x01\uffff\x01"+
            "\x05\x03\uffff\x20\x02"
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
            get { return "401:27: ( ( size )=> size )?"; }
        }

    }


    protected internal int DFA54_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA54_5 = input.LA(1);

                   	 
                   	int index54_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred7_simpletikz()) ) { s = 7; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index54_5);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae54 =
            new NoViableAltException(dfa.Description, 54, _s, input);
        dfa.Error(nvae54);
        throw nvae54;
    }
    const string DFA56_eotS =
        "\x0e\uffff";
    const string DFA56_eofS =
        "\x0e\uffff";
    const string DFA56_minS =
        "\x01\x1c\x01\x04\x01\uffff\x09\x04\x01\uffff\x01\x04";
    const string DFA56_maxS =
        "\x01\x53\x01\x56\x01\uffff\x09\x56\x01\uffff\x01\x56";
    const string DFA56_acceptS =
        "\x02\uffff\x01\x02\x09\uffff\x01\x01\x01\uffff";
    const string DFA56_specialS =
        "\x0e\uffff}>";
    static readonly string[] DFA56_transitionS = {
            "\x02\x02\x0b\uffff\x02\x02\x02\uffff\x01\x02\x04\uffff\x01"+
            "\x01\x02\x02\x01\uffff\x01\x02\x01\uffff\x01\x02\x0e\uffff\x02"+
            "\x02\x01\uffff\x0a\x02",
            "\x19\x02\x01\x04\x02\x03\x0a\x02\x02\uffff\x01\x02\x04\uffff"+
            "\x04\x02\x02\uffff\x20\x02",
            "",
            "\x25\x02\x02\uffff\x03\x02\x01\x06\x02\uffff\x01\x02\x01\uffff"+
            "\x01\x02\x03\uffff\x06\x05\x1a\x02",
            "\x25\x02\x02\uffff\x03\x02\x01\x07\x02\uffff\x01\x02\x01\uffff"+
            "\x01\x02\x03\uffff\x20\x02",
            "\x25\x02\x02\uffff\x03\x02\x01\x06\x02\uffff\x01\x02\x01\uffff"+
            "\x01\x02\x03\uffff\x20\x02",
            "\x19\x02\x01\x09\x02\x08\x0a\x02\x02\uffff\x01\x02\x04\uffff"+
            "\x01\x02\x05\uffff\x20\x02",
            "\x19\x02\x01\x09\x02\x0a\x0a\x02\x02\uffff\x01\x02\x04\uffff"+
            "\x01\x02\x05\uffff\x20\x02",
            "\x25\x02\x02\uffff\x02\x02\x01\uffff\x01\x0c\x02\uffff\x01"+
            "\x02\x01\uffff\x01\x02\x03\uffff\x06\x0b\x1a\x02",
            "\x25\x02\x02\uffff\x02\x02\x01\uffff\x01\x0c\x02\uffff\x01"+
            "\x02\x01\uffff\x01\x02\x03\uffff\x20\x02",
            "\x25\x02\x02\uffff\x02\x02\x01\uffff\x01\x0c\x02\uffff\x01"+
            "\x02\x01\uffff\x01\x02\x03\uffff\x06\x0d\x1a\x02",
            "\x25\x02\x02\uffff\x02\x02\x01\uffff\x01\x0c\x02\uffff\x01"+
            "\x02\x01\uffff\x01\x02\x03\uffff\x20\x02",
            "",
            "\x25\x02\x02\uffff\x02\x02\x01\uffff\x01\x0c\x02\uffff\x01"+
            "\x02\x01\uffff\x01\x02\x03\uffff\x20\x02"
    };

    static readonly short[] DFA56_eot = DFA.UnpackEncodedString(DFA56_eotS);
    static readonly short[] DFA56_eof = DFA.UnpackEncodedString(DFA56_eofS);
    static readonly char[] DFA56_min = DFA.UnpackEncodedStringToUnsignedChars(DFA56_minS);
    static readonly char[] DFA56_max = DFA.UnpackEncodedStringToUnsignedChars(DFA56_maxS);
    static readonly short[] DFA56_accept = DFA.UnpackEncodedString(DFA56_acceptS);
    static readonly short[] DFA56_special = DFA.UnpackEncodedString(DFA56_specialS);
    static readonly short[][] DFA56_transition = DFA.UnpackEncodedStringArray(DFA56_transitionS);

    protected class DFA56 : DFA
    {
        public DFA56(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 56;
            this.eot = DFA56_eot;
            this.eof = DFA56_eof;
            this.min = DFA56_min;
            this.max = DFA56_max;
            this.accept = DFA56_accept;
            this.special = DFA56_special;
            this.transition = DFA56_transition;

        }

        override public string Description
        {
            get { return "404:10: ( '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')' )?"; }
        }

    }

    const string DFA60_eotS =
        "\x0f\uffff";
    const string DFA60_eofS =
        "\x0f\uffff";
    const string DFA60_minS =
        "\x01\x32\x01\x04\x01\x32\x02\x04\x01\uffff\x01\x04\x01\uffff\x06"+
        "\x04\x01\uffff";
    const string DFA60_maxS =
        "\x01\x52\x01\x56\x01\x32\x02\x56\x01\uffff\x01\x56\x01\uffff\x06"+
        "\x56\x01\uffff";
    const string DFA60_acceptS =
        "\x05\uffff\x01\x03\x01\uffff\x01\x01\x06\uffff\x01\x02";
    const string DFA60_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA60_transitionS = {
            "\x01\x01\x1e\uffff\x02\x02",
            "\x1a\x04\x02\x03\x09\x04\x01\x05\x02\uffff\x01\x04\x04\uffff"+
            "\x01\x04\x05\uffff\x20\x04",
            "\x01\x06",
            "\x25\x04\x02\uffff\x01\x05\x01\x04\x02\x09\x02\uffff\x01\x04"+
            "\x01\uffff\x01\x07\x03\uffff\x06\x08\x1a\x04",
            "\x25\x04\x02\uffff\x01\x05\x01\x04\x02\x05\x02\uffff\x01\x04"+
            "\x01\uffff\x01\x07\x03\uffff\x20\x04",
            "",
            "\x1a\x05\x02\x0a\x0a\x05\x02\uffff\x01\x05\x04\uffff\x01\x05"+
            "\x05\uffff\x20\x05",
            "",
            "\x25\x04\x02\uffff\x01\x05\x01\x04\x02\x09\x02\uffff\x01\x04"+
            "\x01\uffff\x01\x07\x03\uffff\x20\x04",
            "\x1a\x05\x02\x0b\x0a\x05\x02\uffff\x01\x05\x04\uffff\x01\x05"+
            "\x05\uffff\x20\x05",
            "\x25\x05\x02\uffff\x02\x05\x02\x09\x02\uffff\x01\x05\x05\uffff"+
            "\x06\x0c\x1a\x05",
            "\x25\x05\x02\uffff\x02\x05\x04\uffff\x01\x05\x01\uffff\x01"+
            "\x0e\x03\uffff\x06\x0d\x1a\x05",
            "\x25\x05\x02\uffff\x02\x05\x02\x09\x02\uffff\x01\x05\x05\uffff"+
            "\x20\x05",
            "\x25\x05\x02\uffff\x02\x05\x04\uffff\x01\x05\x01\uffff\x01"+
            "\x0e\x03\uffff\x20\x05",
            ""
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
            get { return "415:1: coord : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) );"; }
        }

    }

    const string DFA63_eotS =
        "\x05\uffff";
    const string DFA63_eofS =
        "\x05\uffff";
    const string DFA63_minS =
        "\x02\x04\x03\uffff";
    const string DFA63_maxS =
        "\x02\x56\x03\uffff";
    const string DFA63_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x01";
    const string DFA63_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA63_transitionS = {
            "\x25\x01\x01\x02\x02\uffff\x01\x01\x04\uffff\x01\x01\x05\uffff"+
            "\x20\x01",
            "\x25\x01\x02\uffff\x01\x03\x01\x01\x02\x04\x02\uffff\x01\x01"+
            "\x01\uffff\x01\x04\x03\uffff\x20\x01",
            "",
            "",
            ""
    };

    static readonly short[] DFA63_eot = DFA.UnpackEncodedString(DFA63_eotS);
    static readonly short[] DFA63_eof = DFA.UnpackEncodedString(DFA63_eofS);
    static readonly char[] DFA63_min = DFA.UnpackEncodedStringToUnsignedChars(DFA63_minS);
    static readonly char[] DFA63_max = DFA.UnpackEncodedStringToUnsignedChars(DFA63_maxS);
    static readonly short[] DFA63_accept = DFA.UnpackEncodedString(DFA63_acceptS);
    static readonly short[] DFA63_special = DFA.UnpackEncodedString(DFA63_specialS);
    static readonly short[][] DFA63_transition = DFA.UnpackEncodedStringArray(DFA63_transitionS);

    protected class DFA63 : DFA
    {
        public DFA63(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 63;
            this.eot = DFA63_eot;
            this.eof = DFA63_eof;
            this.min = DFA63_min;
            this.max = DFA63_max;
            this.accept = DFA63_accept;
            this.special = DFA63_special;
            this.transition = DFA63_transition;

        }

        override public string Description
        {
            get { return "427:1: coord_part : ( idd -> ^( IM_DONTCARE idd ) | '{' idd '}' -> ^( IM_DONTCARE '{' idd '}' ) | ( idd '=' numberunit ( ',' )? )+ -> ^( IM_DONTCARE ( idd '=' numberunit ( ',' )? )+ ) );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_dontcare_preamble_in_tikzdocument256 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikz_styleorsetorcmd_in_tikzdocument260 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzdocument264 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikzpicture_in_tikzdocument269 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_dontcare_preamble_in_tikzdocument_wo_tikzpicture295 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikz_styleorsetorcmd_in_tikzdocument_wo_tikzpicture299 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzdocument_wo_tikzpicture303 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_EOF_in_tikzdocument_wo_tikzpicture308 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TIKZEDT_CMD_COMMENT_in_tikz_cmd_comment329 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikz_styleorsetorcmd351 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikz_styleorsetorcmd355 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_cmd_comment_in_tikz_styleorsetorcmd359 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_preamble370 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_otherbegin395 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_otherbegin397 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_idd2_in_otherbegin399 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_otherbegin401 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_tikz_style413 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_tikz_style415 = new BitSet(new ulong[]{0xFF8211FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_idd_in_tikz_style417 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_tikz_style419 = new BitSet(new ulong[]{0x0000180000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikz_style422 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_44_in_tikz_style426 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikz_style429 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_squarebr_start_in_tikz_options451 = new BitSet(new ulong[]{0xFFA211FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_options454 = new BitSet(new ulong[]{0xFFA231FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_45_in_tikz_options457 = new BitSet(new ulong[]{0xFF8211FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_options459 = new BitSet(new ulong[]{0xFFA231FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_45_in_tikz_options463 = new BitSet(new ulong[]{0xFFA211FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_squarebr_end_in_tikz_options468 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_option_style_in_option493 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_option_kv_in_option502 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_option_kv516 = new BitSet(new ulong[]{0x0000080000000002UL});
    public static readonly BitSet FOLLOW_43_in_option_kv519 = new BitSet(new ulong[]{0xFF8213FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_iddornumberunitorstringorrange_in_option_kv521 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_41_in_tikzstring549 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_no_rlbrace_in_tikzstring551 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikzstring555 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_no_rlbrace_in_tikzstring557 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_42_in_tikzstring562 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_no_rlbrace585 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_range_in_iddornumberunitorstringorrange603 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_numberunit_in_iddornumberunitorstringorrange607 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_bracedcoord_in_iddornumberunitorstringorrange611 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_iddornumberunitorstringorrange615 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzstring_in_iddornumberunitorstringorrange619 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_41_in_bracedcoord632 = new BitSet(new ulong[]{0x0004000000000000UL,0x0000000000060000UL});
    public static readonly BitSet FOLLOW_coord_in_bracedcoord636 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_bracedcoord638 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_numberunit_in_range649 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_range651 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_range653 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_option_style677 = new BitSet(new ulong[]{0x0001800000000000UL});
    public static readonly BitSet FOLLOW_47_in_option_style680 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_48_in_option_style685 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_option_style687 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_option_style691 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_option_style693 = new BitSet(new ulong[]{0xFF8235FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_option_kv_in_option_style696 = new BitSet(new ulong[]{0x0000240000000000UL});
    public static readonly BitSet FOLLOW_45_in_option_style699 = new BitSet(new ulong[]{0xFF8211FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_option_kv_in_option_style701 = new BitSet(new ulong[]{0x0000240000000000UL});
    public static readonly BitSet FOLLOW_45_in_option_style708 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_option_style711 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_heavenknowswhythisisnecessary_in_idd746 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_idd_heavenknowswhythisisnecessary766 = new BitSet(new ulong[]{0xFF8211FFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_ID_in_idd2825 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_numberunit_in_numberunitorvariable844 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COMMAND_in_numberunitorvariable849 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_number_in_numberunit862 = new BitSet(new ulong[]{0x1F80000000000002UL});
    public static readonly BitSet FOLLOW_unit_in_numberunit864 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_number890 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unit0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_set_start_in_tikz_set945 = new BitSet(new ulong[]{0xFF8215FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_set948 = new BitSet(new ulong[]{0xFF8235FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_45_in_tikz_set951 = new BitSet(new ulong[]{0xFF8211FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_set953 = new BitSet(new ulong[]{0xFF8235FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_45_in_tikz_set957 = new BitSet(new ulong[]{0xFF8215FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_roundbr_end_in_tikz_set962 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzpicture_start_in_tikzpicture990 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpicture992 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzpicture995 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikzpicture_end_in_tikzpicture998 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody1028 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody1032 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_ext_in_tikzbody1036 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikzmatrix_ext_in_tikzbody1040 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikzcoordinate_ext_in_tikzbody1044 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody1048 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody1052 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody1056 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody1061 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_dontcare_body_nobr_in_tikzbody1066 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody1077 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody1081 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_ext_in_tikzbody1085 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikzmatrix_ext_in_tikzbody1089 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikzcoordinate_ext_in_tikzbody1093 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody1097 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody1101 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody1105 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody1110 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_dontcare_body_in_tikzbody1115 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body_nobr1132 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body1194 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_61_in_otherend1253 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_otherend1255 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_idd2_in_otherend1257 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_otherend1259 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzscope_start_in_tikzscope1286 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzscope1288 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzscope1291 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikzscope_end_in_tikzscope1294 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_in_tikzpath1349 = new BitSet(new ulong[]{0x0054020010000000UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath1351 = new BitSet(new ulong[]{0x0054020010000000UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzpath1354 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_in_tikzpath1373 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_69_in_tikzpath1375 = new BitSet(new ulong[]{0x0100000020000000UL});
    public static readonly BitSet FOLLOW_let_assignment_in_tikzpath1377 = new BitSet(new ulong[]{0x0100000020000000UL});
    public static readonly BitSet FOLLOW_56_in_tikzpath1380 = new BitSet(new ulong[]{0x0054020030000000UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_COMMAND_in_tikzpath1383 = new BitSet(new ulong[]{0xFF8213FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikzpath1385 = new BitSet(new ulong[]{0x0054020010000000UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath1389 = new BitSet(new ulong[]{0x0054020010000000UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzpath1392 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COMMAND_in_let_assignment1419 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_let_assignment1421 = new BitSet(new ulong[]{0x0014020010000002UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_let_assignment1423 = new BitSet(new ulong[]{0x0014020010000002UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_tikzpath_element_single_in_tikzpath_element1435 = new BitSet(new ulong[]{0x0000200000000002UL});
    public static readonly BitSet FOLLOW_45_in_tikzpath_element1437 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpath_element_single1454 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_in_tikzpath_element_single1461 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_controls_in_tikzpath_element_single1467 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_int_in_tikzpath_element_single1473 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_int_in_tikzpath_element_single1479 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_circle_in_tikzpath_element_single1485 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arc_in_tikzpath_element_single1492 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_roundbr_start_in_tikzpath_element_single1498 = new BitSet(new ulong[]{0xFF9617FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath_element_single1500 = new BitSet(new ulong[]{0xFF9617FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_roundbr_end_in_tikzpath_element_single1503 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_50_in_tikzpath_element_single1523 = new BitSet(new ulong[]{0x001C020010000000UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath_element_single1525 = new BitSet(new ulong[]{0x001C020010000000UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_51_in_tikzpath_element_single1528 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_edgeop_in_tikzpath_element_single1547 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_controls_start_in_controls1562 = new BitSet(new ulong[]{0x0004000000000000UL,0x0000000000060000UL});
    public static readonly BitSet FOLLOW_coord_in_controls1564 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000080040UL});
    public static readonly BitSet FOLLOW_70_in_controls1567 = new BitSet(new ulong[]{0x0004000000000000UL,0x0000000000060000UL});
    public static readonly BitSet FOLLOW_coord_in_controls1569 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000080040UL});
    public static readonly BitSet FOLLOW_controls_end_in_controls1573 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_node_start_in_tikznode_ext1599 = new BitSet(new ulong[]{0xFF9613FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_core_in_tikznode_ext1601 = new BitSet(new ulong[]{0x0054020010000000UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikznode_ext1603 = new BitSet(new ulong[]{0x0054020010000000UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikznode_ext1606 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrix_start_in_tikzmatrix_ext1633 = new BitSet(new ulong[]{0xFF9613FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_core_in_tikzmatrix_ext1635 = new BitSet(new ulong[]{0x0054020010000000UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzmatrix_ext1637 = new BitSet(new ulong[]{0x0054020010000000UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzmatrix_ext1640 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coordinate_start_in_tikzcoordinate_ext1668 = new BitSet(new ulong[]{0x0054020010000000UL,0x00000000000FFF80UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_ext1683 = new BitSet(new ulong[]{0x0054020010000000UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_ext1702 = new BitSet(new ulong[]{0x0054020010000000UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_ext1722 = new BitSet(new ulong[]{0x0054020010000000UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzcoordinate_ext1733 = new BitSet(new ulong[]{0x0054020010000000UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzcoordinate_ext1736 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_71_in_tikzcoordinate_int1796 = new BitSet(new ulong[]{0x0014000000000002UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_int1807 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_int1826 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_int1846 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_72_in_tikznode_int1862 = new BitSet(new ulong[]{0xFF9613FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_core_in_tikznode_int1865 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikznode_core1875 = new BitSet(new ulong[]{0xFF9613FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikznode_core1878 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core31903 = new BitSet(new ulong[]{0x0014000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core31905 = new BitSet(new ulong[]{0x0014000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core31907 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core21941 = new BitSet(new ulong[]{0x0014000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core21943 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core11976 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_tikznode_decorator2013 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_73_in_tikznode_decorator2020 = new BitSet(new ulong[]{0x0004000000000000UL,0x0000000000060000UL});
    public static readonly BitSet FOLLOW_coord_in_tikznode_decorator2023 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_options_dontcare_in_tikznode_decorator2029 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_tikz_options_dontcare2039 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_no_rlbracket_in_tikz_options_dontcare2041 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikz_options_dontcare_in_tikz_options_dontcare2045 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_no_rlbracket_in_tikz_options_dontcare2047 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_53_in_tikz_options_dontcare2052 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_no_rlbracket2070 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_50_in_nodename2087 = new BitSet(new ulong[]{0xFF8211FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_idd_in_nodename2089 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_nodename2091 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_74_in_circle2115 = new BitSet(new ulong[]{0x0004000000000002UL});
    public static readonly BitSet FOLLOW_75_in_circle2119 = new BitSet(new ulong[]{0x0004000000000002UL});
    public static readonly BitSet FOLLOW_size_in_circle2128 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_76_in_arc2143 = new BitSet(new ulong[]{0x0004000000000002UL});
    public static readonly BitSet FOLLOW_50_in_arc2146 = new BitSet(new ulong[]{0x00000000E0000000UL});
    public static readonly BitSet FOLLOW_numberunitorvariable_in_arc2148 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_arc2150 = new BitSet(new ulong[]{0x00000000E0000000UL});
    public static readonly BitSet FOLLOW_numberunitorvariable_in_arc2152 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_arc2154 = new BitSet(new ulong[]{0x00000000E0000000UL});
    public static readonly BitSet FOLLOW_numberunitorvariable_in_arc2156 = new BitSet(new ulong[]{0x0008000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_70_in_arc2159 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_arc2161 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_arc2165 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_50_in_size2190 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_size2192 = new BitSet(new ulong[]{0x0008000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_70_in_size2195 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_size2197 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_size2201 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_coord2231 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord2255 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_coord2258 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord2260 = new BitSet(new ulong[]{0x0000600000000000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord2262 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord2264 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_coord2266 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord2290 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_coord2293 = new BitSet(new ulong[]{0xFF8213FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_coord2295 = new BitSet(new ulong[]{0x0000600000000000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord2297 = new BitSet(new ulong[]{0xFF8213FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_coord2299 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_coord2301 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_coord_part2334 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_41_in_coord_part2349 = new BitSet(new ulong[]{0xFF8211FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_idd_in_coord_part2351 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_coord_part2353 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_coord_part2371 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_coord_part2373 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord_part2375 = new BitSet(new ulong[]{0xFF8231FFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_45_in_coord_part2377 = new BitSet(new ulong[]{0xFF8211FFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_set_in_coord_sep2409 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_edgeop0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_coord_modifier0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_squarebr_start2483 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_53_in_squarebr_end2501 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_semicolon_end2520 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_41_in_roundbr_start2538 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_42_in_roundbr_end2556 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_83_in_controls_start2574 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_84_in_controls_start2576 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_83_in_controls_end2594 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_tikz_set_start2612 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_tikz_set_start2614 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_tikzpicture_start2633 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_tikzpicture_start2635 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_85_in_tikzpicture_start2637 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_tikzpicture_start2639 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_61_in_tikzpicture_end2657 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_tikzpicture_end2659 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_85_in_tikzpicture_end2661 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_tikzpicture_end2663 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_tikzscope_start2681 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_tikzscope_start2683 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_86_in_tikzscope_start2685 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_tikzscope_start2687 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_61_in_tikzscope_end2705 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_tikzscope_end2707 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_86_in_tikzscope_end2709 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_tikzscope_end2711 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_tag_in_path_start2730 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_node_start_tag_in_node_start2748 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrix_start_tag_in_matrix_start2766 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_62_in_node_start_tag2784 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_63_in_matrix_start_tag2794 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_64_in_coordinate_start2804 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_path_start_tag0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_synpred1_simpletikz1679 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_synpred2_simpletikz1698 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_synpred3_simpletikz1718 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_synpred4_simpletikz1803 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_synpred5_simpletikz1822 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_synpred6_simpletikz1842 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_size_in_synpred7_simpletikz2124 = new BitSet(new ulong[]{0x0000000000000002UL});

}
