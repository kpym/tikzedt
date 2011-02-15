// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g 2011-02-16 00:04:28

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
    public const int COMMAND = 31;
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
    public const int INT = 30;
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
    public const int FLOAT_WO_EXP = 29;
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
            	    case FLOAT_WO_EXP:
            	    case INT:
            	    case COMMAND:
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
            	    case FLOAT_WO_EXP:
            	    case INT:
            	    case COMMAND:
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
            	// elements:          option, squarebr_end, squarebr_start
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
            	// elements:          numberunit, 46, numberunit
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:218:1: numberunit : number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) ;
    public simpletikzParser.numberunit_return numberunit() // throws RecognitionException [1]
    {   
        simpletikzParser.numberunit_return retval = new simpletikzParser.numberunit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.number_return number68 = default(simpletikzParser.number_return);

        simpletikzParser.unit_return unit69 = default(simpletikzParser.unit_return);


        RewriteRuleSubtreeStream stream_unit = new RewriteRuleSubtreeStream(adaptor,"rule unit");
        RewriteRuleSubtreeStream stream_number = new RewriteRuleSubtreeStream(adaptor,"rule number");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:219:2: ( number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:219:4: number ( unit )?
            {
            	PushFollow(FOLLOW_number_in_numberunit848);
            	number68 = number();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_number.Add(number68.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:219:11: ( unit )?
            	int alt21 = 2;
            	int LA21_0 = input.LA(1);

            	if ( ((LA21_0 >= 55 && LA21_0 <= 60)) )
            	{
            	    alt21 = 1;
            	}
            	switch (alt21) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:219:11: unit
            	        {
            	        	PushFollow(FOLLOW_unit_in_numberunit850);
            	        	unit69 = unit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_unit.Add(unit69.Tree);

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
            	// 219:17: -> ^( IM_NUMBERUNIT number ( unit )? )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:219:20: ^( IM_NUMBERUNIT number ( unit )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NUMBERUNIT, "IM_NUMBERUNIT"), root_1);

            	    adaptor.AddChild(root_1, stream_number.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:219:43: ( unit )?
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:223:1: number : ( FLOAT_WO_EXP | INT ) ;
    public simpletikzParser.number_return number() // throws RecognitionException [1]
    {   
        simpletikzParser.number_return retval = new simpletikzParser.number_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set70 = null;

        object set70_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:224:2: ( ( FLOAT_WO_EXP | INT ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:224:4: ( FLOAT_WO_EXP | INT )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set70 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= FLOAT_WO_EXP && input.LA(1) <= INT) ) 
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:227:1: unit : ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' | 'em' );
    public simpletikzParser.unit_return unit() // throws RecognitionException [1]
    {   
        simpletikzParser.unit_return retval = new simpletikzParser.unit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set71 = null;

        object set71_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:228:2: ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' | 'em' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set71 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 55 && input.LA(1) <= 60) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set71));
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:231:1: tikz_set : tikz_set_start ( option ( ',' option )* ( ',' )? )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) ;
    public simpletikzParser.tikz_set_return tikz_set() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_set_return retval = new simpletikzParser.tikz_set_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal74 = null;
        IToken char_literal76 = null;
        simpletikzParser.tikz_set_start_return tikz_set_start72 = default(simpletikzParser.tikz_set_start_return);

        simpletikzParser.option_return option73 = default(simpletikzParser.option_return);

        simpletikzParser.option_return option75 = default(simpletikzParser.option_return);

        simpletikzParser.roundbr_end_return roundbr_end77 = default(simpletikzParser.roundbr_end_return);


        object char_literal74_tree=null;
        object char_literal76_tree=null;
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleSubtreeStream stream_tikz_set_start = new RewriteRuleSubtreeStream(adaptor,"rule tikz_set_start");
        RewriteRuleSubtreeStream stream_roundbr_end = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        RewriteRuleSubtreeStream stream_option = new RewriteRuleSubtreeStream(adaptor,"rule option");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:232:2: ( tikz_set_start ( option ( ',' option )* ( ',' )? )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:232:5: tikz_set_start ( option ( ',' option )* ( ',' )? )? roundbr_end
            {
            	PushFollow(FOLLOW_tikz_set_start_in_tikz_set931);
            	tikz_set_start72 = tikz_set_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikz_set_start.Add(tikz_set_start72.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:232:20: ( option ( ',' option )* ( ',' )? )?
            	int alt24 = 2;
            	int LA24_0 = input.LA(1);

            	if ( ((LA24_0 >= IM_PATH && LA24_0 <= 40) || LA24_0 == 44 || LA24_0 == 49 || (LA24_0 >= 55 && LA24_0 <= 86)) )
            	{
            	    alt24 = 1;
            	}
            	switch (alt24) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:232:21: option ( ',' option )* ( ',' )?
            	        {
            	        	PushFollow(FOLLOW_option_in_tikz_set934);
            	        	option73 = option();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_option.Add(option73.Tree);
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:232:28: ( ',' option )*
            	        	do 
            	        	{
            	        	    int alt22 = 2;
            	        	    int LA22_0 = input.LA(1);

            	        	    if ( (LA22_0 == 45) )
            	        	    {
            	        	        int LA22_1 = input.LA(2);

            	        	        if ( ((LA22_1 >= IM_PATH && LA22_1 <= 40) || LA22_1 == 44 || LA22_1 == 49 || (LA22_1 >= 55 && LA22_1 <= 86)) )
            	        	        {
            	        	            alt22 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt22) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:232:29: ',' option
            	        			    {
            	        			    	char_literal74=(IToken)Match(input,45,FOLLOW_45_in_tikz_set937); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_45.Add(char_literal74);

            	        			    	PushFollow(FOLLOW_option_in_tikz_set939);
            	        			    	option75 = option();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( (state.backtracking==0) ) stream_option.Add(option75.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop22;
            	        	    }
            	        	} while (true);

            	        	loop22:
            	        		;	// Stops C# compiler whining that label 'loop22' has no statements

            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:232:42: ( ',' )?
            	        	int alt23 = 2;
            	        	int LA23_0 = input.LA(1);

            	        	if ( (LA23_0 == 45) )
            	        	{
            	        	    alt23 = 1;
            	        	}
            	        	switch (alt23) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:232:42: ','
            	        	        {
            	        	        	char_literal76=(IToken)Match(input,45,FOLLOW_45_in_tikz_set943); if (state.failed) return retval; 
            	        	        	if ( (state.backtracking==0) ) stream_45.Add(char_literal76);


            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_roundbr_end_in_tikz_set948);
            	roundbr_end77 = roundbr_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_roundbr_end.Add(roundbr_end77.Tree);


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
            	// 232:61: -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:232:64: ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_TIKZSET, "IM_TIKZSET"), root_1);

            	    adaptor.AddChild(root_1, stream_tikz_set_start.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:232:92: ( option )*
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:237:1: tikzpicture : tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) ;
    public simpletikzParser.tikzpicture_return tikzpicture() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_return retval = new simpletikzParser.tikzpicture_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzpicture_start_return tikzpicture_start78 = default(simpletikzParser.tikzpicture_start_return);

        simpletikzParser.tikz_options_return tikz_options79 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody_return tikzbody80 = default(simpletikzParser.tikzbody_return);

        simpletikzParser.tikzpicture_end_return tikzpicture_end81 = default(simpletikzParser.tikzpicture_end_return);


        RewriteRuleSubtreeStream stream_tikzpicture_end = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_end");
        RewriteRuleSubtreeStream stream_tikzpicture_start = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_start");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:238:2: ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:238:5: tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end
            {
            	PushFollow(FOLLOW_tikzpicture_start_in_tikzpicture976);
            	tikzpicture_start78 = tikzpicture_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzpicture_start.Add(tikzpicture_start78.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:238:23: ( tikz_options )?
            	int alt25 = 2;
            	int LA25_0 = input.LA(1);

            	if ( (LA25_0 == 52) )
            	{
            	    alt25 = 1;
            	}
            	switch (alt25) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:238:23: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_tikzpicture978);
            	        	tikz_options79 = tikz_options();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_tikz_options.Add(tikz_options79.Tree);

            	        }
            	        break;

            	}

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:238:37: ( tikzbody )?
            	int alt26 = 2;
            	int LA26_0 = input.LA(1);

            	if ( ((LA26_0 >= IM_PATH && LA26_0 <= 51) || (LA26_0 >= 53 && LA26_0 <= 60) || (LA26_0 >= 62 && LA26_0 <= 86)) )
            	{
            	    alt26 = 1;
            	}
            	else if ( (LA26_0 == 61) )
            	{
            	    int LA26_2 = input.LA(2);

            	    if ( (LA26_2 == 41) )
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
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:238:37: tikzbody
            	        {
            	        	PushFollow(FOLLOW_tikzbody_in_tikzpicture981);
            	        	tikzbody80 = tikzbody();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_tikzbody.Add(tikzbody80.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzpicture_end_in_tikzpicture984);
            	tikzpicture_end81 = tikzpicture_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzpicture_end.Add(tikzpicture_end81.Tree);


            	// AST REWRITE
            	// elements:          tikzpicture_start, tikz_options, tikzbody, tikzpicture_end
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 238:64: -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:238:67: ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PICTURE, "IM_PICTURE"), root_1);

            	    adaptor.AddChild(root_1, stream_tikzpicture_start.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:238:98: ( tikz_options )?
            	    if ( stream_tikz_options.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikz_options.NextTree());

            	    }
            	    stream_tikz_options.Reset();
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:238:112: ( tikzbody )?
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:241:1: tikzbody : ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )* ;
    public simpletikzParser.tikzbody_return tikzbody() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzbody_return retval = new simpletikzParser.tikzbody_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_return tikzscope82 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath83 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznode_ext_return tikznode_ext84 = default(simpletikzParser.tikznode_ext_return);

        simpletikzParser.tikzmatrix_ext_return tikzmatrix_ext85 = default(simpletikzParser.tikzmatrix_ext_return);

        simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext86 = default(simpletikzParser.tikzcoordinate_ext_return);

        simpletikzParser.tikz_set_return tikz_set87 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style88 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin89 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend90 = default(simpletikzParser.otherend_return);

        simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr91 = default(simpletikzParser.dontcare_body_nobr_return);

        simpletikzParser.tikzscope_return tikzscope92 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath93 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznode_ext_return tikznode_ext94 = default(simpletikzParser.tikznode_ext_return);

        simpletikzParser.tikzmatrix_ext_return tikzmatrix_ext95 = default(simpletikzParser.tikzmatrix_ext_return);

        simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext96 = default(simpletikzParser.tikzcoordinate_ext_return);

        simpletikzParser.tikz_set_return tikz_set97 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style98 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin99 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend100 = default(simpletikzParser.otherend_return);

        simpletikzParser.dontcare_body_return dontcare_body101 = default(simpletikzParser.dontcare_body_return);



        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:242:2: ( ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )* )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:242:4: ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:242:4: ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr )
            	int alt27 = 10;
            	alt27 = dfa27.Predict(input);
            	switch (alt27) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:242:6: tikzscope
            	        {
            	        	PushFollow(FOLLOW_tikzscope_in_tikzbody1014);
            	        	tikzscope82 = tikzscope();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzscope82.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:242:18: tikzpath
            	        {
            	        	PushFollow(FOLLOW_tikzpath_in_tikzbody1018);
            	        	tikzpath83 = tikzpath();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath83.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:242:29: tikznode_ext
            	        {
            	        	PushFollow(FOLLOW_tikznode_ext_in_tikzbody1022);
            	        	tikznode_ext84 = tikznode_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_ext84.Tree);

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:242:44: tikzmatrix_ext
            	        {
            	        	PushFollow(FOLLOW_tikzmatrix_ext_in_tikzbody1026);
            	        	tikzmatrix_ext85 = tikzmatrix_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzmatrix_ext85.Tree);

            	        }
            	        break;
            	    case 5 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:242:61: tikzcoordinate_ext
            	        {
            	        	PushFollow(FOLLOW_tikzcoordinate_ext_in_tikzbody1030);
            	        	tikzcoordinate_ext86 = tikzcoordinate_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_ext86.Tree);

            	        }
            	        break;
            	    case 6 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:242:82: tikz_set
            	        {
            	        	PushFollow(FOLLOW_tikz_set_in_tikzbody1034);
            	        	tikz_set87 = tikz_set();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set87.Tree);

            	        }
            	        break;
            	    case 7 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:242:93: tikz_style
            	        {
            	        	PushFollow(FOLLOW_tikz_style_in_tikzbody1038);
            	        	tikz_style88 = tikz_style();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style88.Tree);

            	        }
            	        break;
            	    case 8 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:242:106: otherbegin
            	        {
            	        	PushFollow(FOLLOW_otherbegin_in_tikzbody1042);
            	        	otherbegin89 = otherbegin();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;
            	    case 9 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:242:120: otherend
            	        {
            	        	PushFollow(FOLLOW_otherend_in_tikzbody1047);
            	        	otherend90 = otherend();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;
            	    case 10 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:242:132: dontcare_body_nobr
            	        {
            	        	PushFollow(FOLLOW_dontcare_body_nobr_in_tikzbody1052);
            	        	dontcare_body_nobr91 = dontcare_body_nobr();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;

            	}

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:243:3: ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*
            	do 
            	{
            	    int alt28 = 11;
            	    alt28 = dfa28.Predict(input);
            	    switch (alt28) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:243:5: tikzscope
            			    {
            			    	PushFollow(FOLLOW_tikzscope_in_tikzbody1063);
            			    	tikzscope92 = tikzscope();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzscope92.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:243:17: tikzpath
            			    {
            			    	PushFollow(FOLLOW_tikzpath_in_tikzbody1067);
            			    	tikzpath93 = tikzpath();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath93.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:243:28: tikznode_ext
            			    {
            			    	PushFollow(FOLLOW_tikznode_ext_in_tikzbody1071);
            			    	tikznode_ext94 = tikznode_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_ext94.Tree);

            			    }
            			    break;
            			case 4 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:243:43: tikzmatrix_ext
            			    {
            			    	PushFollow(FOLLOW_tikzmatrix_ext_in_tikzbody1075);
            			    	tikzmatrix_ext95 = tikzmatrix_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzmatrix_ext95.Tree);

            			    }
            			    break;
            			case 5 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:243:60: tikzcoordinate_ext
            			    {
            			    	PushFollow(FOLLOW_tikzcoordinate_ext_in_tikzbody1079);
            			    	tikzcoordinate_ext96 = tikzcoordinate_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_ext96.Tree);

            			    }
            			    break;
            			case 6 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:243:81: tikz_set
            			    {
            			    	PushFollow(FOLLOW_tikz_set_in_tikzbody1083);
            			    	tikz_set97 = tikz_set();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set97.Tree);

            			    }
            			    break;
            			case 7 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:243:92: tikz_style
            			    {
            			    	PushFollow(FOLLOW_tikz_style_in_tikzbody1087);
            			    	tikz_style98 = tikz_style();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style98.Tree);

            			    }
            			    break;
            			case 8 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:243:105: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzbody1091);
            			    	otherbegin99 = otherbegin();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;
            			case 9 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:243:119: otherend
            			    {
            			    	PushFollow(FOLLOW_otherend_in_tikzbody1096);
            			    	otherend100 = otherend();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;
            			case 10 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:243:131: dontcare_body
            			    {
            			    	PushFollow(FOLLOW_dontcare_body_in_tikzbody1101);
            			    	dontcare_body101 = dontcare_body();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop28;
            	    }
            	} while (true);

            	loop28:
            		;	// Stops C# compiler whining that label 'loop28' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:246:1: dontcare_body_nobr : (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) ) ;
    public simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body_nobr_return retval = new simpletikzParser.dontcare_body_nobr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set102 = null;

        object set102_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:247:2: ( (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:247:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:247:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) )
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:247:5: ~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' )
            	{
            		set102 = (IToken)input.LT(1);
            		if ( (input.LA(1) >= IM_PATH && input.LA(1) <= SOMETHING) || (input.LA(1) >= 41 && input.LA(1) <= 51) || (input.LA(1) >= 53 && input.LA(1) <= 60) || (input.LA(1) >= 69 && input.LA(1) <= 86) ) 
            		{
            		    input.Consume();
            		    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set102));
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:249:1: dontcare_body : (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) ) ;
    public simpletikzParser.dontcare_body_return dontcare_body() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body_return retval = new simpletikzParser.dontcare_body_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set103 = null;

        object set103_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:250:2: ( (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:250:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:250:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) )
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:250:5: ~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' )
            	{
            		set103 = (IToken)input.LT(1);
            		if ( (input.LA(1) >= IM_PATH && input.LA(1) <= SOMETHING) || (input.LA(1) >= 41 && input.LA(1) <= 60) || (input.LA(1) >= 69 && input.LA(1) <= 86) ) 
            		{
            		    input.Consume();
            		    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set103));
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:252:1: otherend : '\\\\end' '{' idd2 '}' ;
    public simpletikzParser.otherend_return otherend() // throws RecognitionException [1]
    {   
        simpletikzParser.otherend_return retval = new simpletikzParser.otherend_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal104 = null;
        IToken char_literal105 = null;
        IToken char_literal107 = null;
        simpletikzParser.idd2_return idd2106 = default(simpletikzParser.idd2_return);


        object string_literal104_tree=null;
        object char_literal105_tree=null;
        object char_literal107_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:253:2: ( '\\\\end' '{' idd2 '}' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:253:4: '\\\\end' '{' idd2 '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal104=(IToken)Match(input,61,FOLLOW_61_in_otherend1239); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal104_tree = (object)adaptor.Create(string_literal104);
            		adaptor.AddChild(root_0, string_literal104_tree);
            	}
            	char_literal105=(IToken)Match(input,41,FOLLOW_41_in_otherend1241); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal105_tree = (object)adaptor.Create(char_literal105);
            		adaptor.AddChild(root_0, char_literal105_tree);
            	}
            	PushFollow(FOLLOW_idd2_in_otherend1243);
            	idd2106 = idd2();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idd2106.Tree);
            	char_literal107=(IToken)Match(input,42,FOLLOW_42_in_otherend1245); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal107_tree = (object)adaptor.Create(char_literal107);
            		adaptor.AddChild(root_0, char_literal107_tree);
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:267:1: tikzscope : tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end ) ;
    public simpletikzParser.tikzscope_return tikzscope() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_return retval = new simpletikzParser.tikzscope_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_start_return tikzscope_start108 = default(simpletikzParser.tikzscope_start_return);

        simpletikzParser.tikz_options_return tikz_options109 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody_return tikzbody110 = default(simpletikzParser.tikzbody_return);

        simpletikzParser.tikzscope_end_return tikzscope_end111 = default(simpletikzParser.tikzscope_end_return);


        RewriteRuleSubtreeStream stream_tikzscope_start = new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_start");
        RewriteRuleSubtreeStream stream_tikzscope_end = new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_end");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:268:2: ( tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:268:4: tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end
            {
            	PushFollow(FOLLOW_tikzscope_start_in_tikzscope1272);
            	tikzscope_start108 = tikzscope_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzscope_start.Add(tikzscope_start108.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:268:20: ( tikz_options )?
            	int alt29 = 2;
            	int LA29_0 = input.LA(1);

            	if ( (LA29_0 == 52) )
            	{
            	    alt29 = 1;
            	}
            	switch (alt29) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:268:20: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_tikzscope1274);
            	        	tikz_options109 = tikz_options();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_tikz_options.Add(tikz_options109.Tree);

            	        }
            	        break;

            	}

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:268:34: ( tikzbody )?
            	int alt30 = 2;
            	int LA30_0 = input.LA(1);

            	if ( ((LA30_0 >= IM_PATH && LA30_0 <= 51) || (LA30_0 >= 53 && LA30_0 <= 60) || (LA30_0 >= 62 && LA30_0 <= 86)) )
            	{
            	    alt30 = 1;
            	}
            	else if ( (LA30_0 == 61) )
            	{
            	    int LA30_2 = input.LA(2);

            	    if ( (LA30_2 == 41) )
            	    {
            	        int LA30_3 = input.LA(3);

            	        if ( (LA30_3 == ID) )
            	        {
            	            alt30 = 1;
            	        }
            	    }
            	}
            	switch (alt30) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:268:34: tikzbody
            	        {
            	        	PushFollow(FOLLOW_tikzbody_in_tikzscope1277);
            	        	tikzbody110 = tikzbody();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_tikzbody.Add(tikzbody110.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzscope_end_in_tikzscope1280);
            	tikzscope_end111 = tikzscope_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzscope_end.Add(tikzscope_end111.Tree);


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
            	// 268:59: -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:268:62: ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_SCOPE, "IM_SCOPE"), root_1);

            	    adaptor.AddChild(root_1, stream_tikzscope_start.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:268:89: ( tikz_options )?
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:294:1: tikzpath : ( path_start ( tikzpath_element )* semicolon_end -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end ) | path_start 'let' ( let_assignment )* 'in' ( COMMAND tikzstring )? ( tikzpath_element )* semicolon_end -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end ) );
    public simpletikzParser.tikzpath_return tikzpath() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_return retval = new simpletikzParser.tikzpath_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal116 = null;
        IToken string_literal118 = null;
        IToken COMMAND119 = null;
        simpletikzParser.path_start_return path_start112 = default(simpletikzParser.path_start_return);

        simpletikzParser.tikzpath_element_return tikzpath_element113 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end114 = default(simpletikzParser.semicolon_end_return);

        simpletikzParser.path_start_return path_start115 = default(simpletikzParser.path_start_return);

        simpletikzParser.let_assignment_return let_assignment117 = default(simpletikzParser.let_assignment_return);

        simpletikzParser.tikzstring_return tikzstring120 = default(simpletikzParser.tikzstring_return);

        simpletikzParser.tikzpath_element_return tikzpath_element121 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end122 = default(simpletikzParser.semicolon_end_return);


        object string_literal116_tree=null;
        object string_literal118_tree=null;
        object COMMAND119_tree=null;
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:295:2: ( path_start ( tikzpath_element )* semicolon_end -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end ) | path_start 'let' ( let_assignment )* 'in' ( COMMAND tikzstring )? ( tikzpath_element )* semicolon_end -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end ) )
            int alt35 = 2;
            int LA35_0 = input.LA(1);

            if ( ((LA35_0 >= 65 && LA35_0 <= 68)) )
            {
                int LA35_1 = input.LA(2);

                if ( (LA35_1 == 69) )
                {
                    alt35 = 2;
                }
                else if ( (LA35_1 == ID || LA35_1 == 41 || LA35_1 == 50 || LA35_1 == 52 || LA35_1 == 54 || (LA35_1 >= 71 && LA35_1 <= 72) || (LA35_1 >= 74 && LA35_1 <= 83)) )
                {
                    alt35 = 1;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d35s1 =
                        new NoViableAltException("", 35, 1, input);

                    throw nvae_d35s1;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d35s0 =
                    new NoViableAltException("", 35, 0, input);

                throw nvae_d35s0;
            }
            switch (alt35) 
            {
                case 1 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:295:4: path_start ( tikzpath_element )* semicolon_end
                    {
                    	PushFollow(FOLLOW_path_start_in_tikzpath1335);
                    	path_start112 = path_start();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_path_start.Add(path_start112.Tree);
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:295:15: ( tikzpath_element )*
                    	do 
                    	{
                    	    int alt31 = 2;
                    	    int LA31_0 = input.LA(1);

                    	    if ( (LA31_0 == ID || LA31_0 == 41 || LA31_0 == 50 || LA31_0 == 52 || (LA31_0 >= 71 && LA31_0 <= 72) || (LA31_0 >= 74 && LA31_0 <= 83)) )
                    	    {
                    	        alt31 = 1;
                    	    }


                    	    switch (alt31) 
                    		{
                    			case 1 :
                    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:295:15: tikzpath_element
                    			    {
                    			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath1337);
                    			    	tikzpath_element113 = tikzpath_element();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element113.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop31;
                    	    }
                    	} while (true);

                    	loop31:
                    		;	// Stops C# compiler whining that label 'loop31' has no statements

                    	PushFollow(FOLLOW_semicolon_end_in_tikzpath1340);
                    	semicolon_end114 = semicolon_end();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_semicolon_end.Add(semicolon_end114.Tree);


                    	// AST REWRITE
                    	// elements:          semicolon_end, tikzpath_element, path_start
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 295:47: -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end )
                    	{
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:295:50: ^( IM_PATH path_start ( tikzpath_element )* semicolon_end )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

                    	    adaptor.AddChild(root_1, stream_path_start.NextTree());
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:295:71: ( tikzpath_element )*
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
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:296:4: path_start 'let' ( let_assignment )* 'in' ( COMMAND tikzstring )? ( tikzpath_element )* semicolon_end
                    {
                    	PushFollow(FOLLOW_path_start_in_tikzpath1359);
                    	path_start115 = path_start();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_path_start.Add(path_start115.Tree);
                    	string_literal116=(IToken)Match(input,69,FOLLOW_69_in_tikzpath1361); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_69.Add(string_literal116);

                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:296:21: ( let_assignment )*
                    	do 
                    	{
                    	    int alt32 = 2;
                    	    int LA32_0 = input.LA(1);

                    	    if ( (LA32_0 == COMMAND) )
                    	    {
                    	        alt32 = 1;
                    	    }


                    	    switch (alt32) 
                    		{
                    			case 1 :
                    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:296:21: let_assignment
                    			    {
                    			    	PushFollow(FOLLOW_let_assignment_in_tikzpath1363);
                    			    	let_assignment117 = let_assignment();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_let_assignment.Add(let_assignment117.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop32;
                    	    }
                    	} while (true);

                    	loop32:
                    		;	// Stops C# compiler whining that label 'loop32' has no statements

                    	string_literal118=(IToken)Match(input,56,FOLLOW_56_in_tikzpath1366); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_56.Add(string_literal118);

                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:296:42: ( COMMAND tikzstring )?
                    	int alt33 = 2;
                    	int LA33_0 = input.LA(1);

                    	if ( (LA33_0 == COMMAND) )
                    	{
                    	    alt33 = 1;
                    	}
                    	switch (alt33) 
                    	{
                    	    case 1 :
                    	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:296:43: COMMAND tikzstring
                    	        {
                    	        	COMMAND119=(IToken)Match(input,COMMAND,FOLLOW_COMMAND_in_tikzpath1369); if (state.failed) return retval; 
                    	        	if ( (state.backtracking==0) ) stream_COMMAND.Add(COMMAND119);

                    	        	PushFollow(FOLLOW_tikzstring_in_tikzpath1371);
                    	        	tikzstring120 = tikzstring();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_tikzstring.Add(tikzstring120.Tree);

                    	        }
                    	        break;

                    	}

                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:296:64: ( tikzpath_element )*
                    	do 
                    	{
                    	    int alt34 = 2;
                    	    int LA34_0 = input.LA(1);

                    	    if ( (LA34_0 == ID || LA34_0 == 41 || LA34_0 == 50 || LA34_0 == 52 || (LA34_0 >= 71 && LA34_0 <= 72) || (LA34_0 >= 74 && LA34_0 <= 83)) )
                    	    {
                    	        alt34 = 1;
                    	    }


                    	    switch (alt34) 
                    		{
                    			case 1 :
                    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:296:64: tikzpath_element
                    			    {
                    			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath1375);
                    			    	tikzpath_element121 = tikzpath_element();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element121.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop34;
                    	    }
                    	} while (true);

                    	loop34:
                    		;	// Stops C# compiler whining that label 'loop34' has no statements

                    	PushFollow(FOLLOW_semicolon_end_in_tikzpath1378);
                    	semicolon_end122 = semicolon_end();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_semicolon_end.Add(semicolon_end122.Tree);


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
                    	// 296:96: -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end )
                    	{
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:296:99: ^( IM_PATH path_start ( tikzpath_element )* semicolon_end )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

                    	    adaptor.AddChild(root_1, stream_path_start.NextTree());
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:296:120: ( tikzpath_element )*
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:300:1: let_assignment : COMMAND '=' ( tikzpath_element )* ;
    public simpletikzParser.let_assignment_return let_assignment() // throws RecognitionException [1]
    {   
        simpletikzParser.let_assignment_return retval = new simpletikzParser.let_assignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken COMMAND123 = null;
        IToken char_literal124 = null;
        simpletikzParser.tikzpath_element_return tikzpath_element125 = default(simpletikzParser.tikzpath_element_return);


        object COMMAND123_tree=null;
        object char_literal124_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:301:2: ( COMMAND '=' ( tikzpath_element )* )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:301:4: COMMAND '=' ( tikzpath_element )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	COMMAND123=(IToken)Match(input,COMMAND,FOLLOW_COMMAND_in_let_assignment1405); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{COMMAND123_tree = (object)adaptor.Create(COMMAND123);
            		adaptor.AddChild(root_0, COMMAND123_tree);
            	}
            	char_literal124=(IToken)Match(input,43,FOLLOW_43_in_let_assignment1407); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal124_tree = (object)adaptor.Create(char_literal124);
            		adaptor.AddChild(root_0, char_literal124_tree);
            	}
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:301:16: ( tikzpath_element )*
            	do 
            	{
            	    int alt36 = 2;
            	    int LA36_0 = input.LA(1);

            	    if ( (LA36_0 == ID || LA36_0 == 41 || LA36_0 == 50 || LA36_0 == 52 || (LA36_0 >= 71 && LA36_0 <= 72) || (LA36_0 >= 74 && LA36_0 <= 83)) )
            	    {
            	        alt36 = 1;
            	    }


            	    switch (alt36) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:301:16: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_let_assignment1409);
            			    	tikzpath_element125 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath_element125.Tree);

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

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:304:1: tikzpath_element : tikzpath_element_single ( ',' )? ;
    public simpletikzParser.tikzpath_element_return tikzpath_element() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_element_return retval = new simpletikzParser.tikzpath_element_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal127 = null;
        simpletikzParser.tikzpath_element_single_return tikzpath_element_single126 = default(simpletikzParser.tikzpath_element_single_return);


        object char_literal127_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:305:2: ( tikzpath_element_single ( ',' )? )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:305:4: tikzpath_element_single ( ',' )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_tikzpath_element_single_in_tikzpath_element1421);
            	tikzpath_element_single126 = tikzpath_element_single();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath_element_single126.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:305:28: ( ',' )?
            	int alt37 = 2;
            	int LA37_0 = input.LA(1);

            	if ( (LA37_0 == 45) )
            	{
            	    alt37 = 1;
            	}
            	switch (alt37) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:305:28: ','
            	        {
            	        	char_literal127=(IToken)Match(input,45,FOLLOW_45_in_tikzpath_element1423); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal127_tree = (object)adaptor.Create(char_literal127);
            	        		adaptor.AddChild(root_0, char_literal127_tree);
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:308:1: tikzpath_element_single : ( tikz_options | coord | controls | tikznode_int | tikzcoordinate_int | circle | arc | roundbr_start ( tikzpath_element )* roundbr_end -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end ) | '(' ( tikzpath_element )* ')' -> ^( IM_PATH '(' ( tikzpath_element )* ')' ) | edgeop );
    public simpletikzParser.tikzpath_element_single_return tikzpath_element_single() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_element_single_return retval = new simpletikzParser.tikzpath_element_single_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal138 = null;
        IToken char_literal140 = null;
        simpletikzParser.tikz_options_return tikz_options128 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.coord_return coord129 = default(simpletikzParser.coord_return);

        simpletikzParser.controls_return controls130 = default(simpletikzParser.controls_return);

        simpletikzParser.tikznode_int_return tikznode_int131 = default(simpletikzParser.tikznode_int_return);

        simpletikzParser.tikzcoordinate_int_return tikzcoordinate_int132 = default(simpletikzParser.tikzcoordinate_int_return);

        simpletikzParser.circle_return circle133 = default(simpletikzParser.circle_return);

        simpletikzParser.arc_return arc134 = default(simpletikzParser.arc_return);

        simpletikzParser.roundbr_start_return roundbr_start135 = default(simpletikzParser.roundbr_start_return);

        simpletikzParser.tikzpath_element_return tikzpath_element136 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.roundbr_end_return roundbr_end137 = default(simpletikzParser.roundbr_end_return);

        simpletikzParser.tikzpath_element_return tikzpath_element139 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.edgeop_return edgeop141 = default(simpletikzParser.edgeop_return);


        object char_literal138_tree=null;
        object char_literal140_tree=null;
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_roundbr_start = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_start");
        RewriteRuleSubtreeStream stream_roundbr_end = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:309:2: ( tikz_options | coord | controls | tikznode_int | tikzcoordinate_int | circle | arc | roundbr_start ( tikzpath_element )* roundbr_end -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end ) | '(' ( tikzpath_element )* ')' -> ^( IM_PATH '(' ( tikzpath_element )* ')' ) | edgeop )
            int alt40 = 10;
            alt40 = dfa40.Predict(input);
            switch (alt40) 
            {
                case 1 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:310:5: tikz_options
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_options_in_tikzpath_element_single1440);
                    	tikz_options128 = tikz_options();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_options128.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:311:5: coord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_coord_in_tikzpath_element_single1447);
                    	coord129 = coord();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, coord129.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:312:5: controls
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_controls_in_tikzpath_element_single1453);
                    	controls130 = controls();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, controls130.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:313:5: tikznode_int
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikznode_int_in_tikzpath_element_single1459);
                    	tikznode_int131 = tikznode_int();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_int131.Tree);

                    }
                    break;
                case 5 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:314:5: tikzcoordinate_int
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikzcoordinate_int_in_tikzpath_element_single1465);
                    	tikzcoordinate_int132 = tikzcoordinate_int();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_int132.Tree);

                    }
                    break;
                case 6 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:315:5: circle
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_circle_in_tikzpath_element_single1471);
                    	circle133 = circle();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;

                    }
                    break;
                case 7 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:316:5: arc
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arc_in_tikzpath_element_single1478);
                    	arc134 = arc();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arc134.Tree);

                    }
                    break;
                case 8 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:317:5: roundbr_start ( tikzpath_element )* roundbr_end
                    {
                    	PushFollow(FOLLOW_roundbr_start_in_tikzpath_element_single1484);
                    	roundbr_start135 = roundbr_start();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_roundbr_start.Add(roundbr_start135.Tree);
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:317:19: ( tikzpath_element )*
                    	do 
                    	{
                    	    int alt38 = 2;
                    	    int LA38_0 = input.LA(1);

                    	    if ( (LA38_0 == ID || LA38_0 == 41 || LA38_0 == 50 || LA38_0 == 52 || (LA38_0 >= 71 && LA38_0 <= 72) || (LA38_0 >= 74 && LA38_0 <= 83)) )
                    	    {
                    	        alt38 = 1;
                    	    }


                    	    switch (alt38) 
                    		{
                    			case 1 :
                    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:317:19: tikzpath_element
                    			    {
                    			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath_element_single1486);
                    			    	tikzpath_element136 = tikzpath_element();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element136.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop38;
                    	    }
                    	} while (true);

                    	loop38:
                    		;	// Stops C# compiler whining that label 'loop38' has no statements

                    	PushFollow(FOLLOW_roundbr_end_in_tikzpath_element_single1489);
                    	roundbr_end137 = roundbr_end();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_roundbr_end.Add(roundbr_end137.Tree);


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
                    	// 317:49: -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end )
                    	{
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:317:52: ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

                    	    adaptor.AddChild(root_1, stream_roundbr_start.NextTree());
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:317:76: ( tikzpath_element )*
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
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:318:6: '(' ( tikzpath_element )* ')'
                    {
                    	char_literal138=(IToken)Match(input,50,FOLLOW_50_in_tikzpath_element_single1509); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_50.Add(char_literal138);

                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:318:10: ( tikzpath_element )*
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
                    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:318:10: tikzpath_element
                    			    {
                    			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath_element_single1511);
                    			    	tikzpath_element139 = tikzpath_element();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element139.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop39;
                    	    }
                    	} while (true);

                    	loop39:
                    		;	// Stops C# compiler whining that label 'loop39' has no statements

                    	char_literal140=(IToken)Match(input,51,FOLLOW_51_in_tikzpath_element_single1514); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_51.Add(char_literal140);



                    	// AST REWRITE
                    	// elements:          50, 51, tikzpath_element
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 318:32: -> ^( IM_PATH '(' ( tikzpath_element )* ')' )
                    	{
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:318:35: ^( IM_PATH '(' ( tikzpath_element )* ')' )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

                    	    adaptor.AddChild(root_1, stream_50.NextNode());
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:318:49: ( tikzpath_element )*
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
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:319:5: edgeop
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_edgeop_in_tikzpath_element_single1533);
                    	edgeop141 = edgeop();
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:322:1: controls : controls_start coord ( 'and' coord )? controls_end -> ^( IM_CONTROLS controls_start ( coord )+ controls_end ) ;
    public simpletikzParser.controls_return controls() // throws RecognitionException [1]
    {   
        simpletikzParser.controls_return retval = new simpletikzParser.controls_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal144 = null;
        simpletikzParser.controls_start_return controls_start142 = default(simpletikzParser.controls_start_return);

        simpletikzParser.coord_return coord143 = default(simpletikzParser.coord_return);

        simpletikzParser.coord_return coord145 = default(simpletikzParser.coord_return);

        simpletikzParser.controls_end_return controls_end146 = default(simpletikzParser.controls_end_return);


        object string_literal144_tree=null;
        RewriteRuleTokenStream stream_70 = new RewriteRuleTokenStream(adaptor,"token 70");
        RewriteRuleSubtreeStream stream_coord = new RewriteRuleSubtreeStream(adaptor,"rule coord");
        RewriteRuleSubtreeStream stream_controls_start = new RewriteRuleSubtreeStream(adaptor,"rule controls_start");
        RewriteRuleSubtreeStream stream_controls_end = new RewriteRuleSubtreeStream(adaptor,"rule controls_end");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:323:2: ( controls_start coord ( 'and' coord )? controls_end -> ^( IM_CONTROLS controls_start ( coord )+ controls_end ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:323:4: controls_start coord ( 'and' coord )? controls_end
            {
            	PushFollow(FOLLOW_controls_start_in_controls1548);
            	controls_start142 = controls_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_controls_start.Add(controls_start142.Tree);
            	PushFollow(FOLLOW_coord_in_controls1550);
            	coord143 = coord();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_coord.Add(coord143.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:323:25: ( 'and' coord )?
            	int alt41 = 2;
            	int LA41_0 = input.LA(1);

            	if ( (LA41_0 == 70) )
            	{
            	    alt41 = 1;
            	}
            	switch (alt41) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:323:26: 'and' coord
            	        {
            	        	string_literal144=(IToken)Match(input,70,FOLLOW_70_in_controls1553); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_70.Add(string_literal144);

            	        	PushFollow(FOLLOW_coord_in_controls1555);
            	        	coord145 = coord();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_coord.Add(coord145.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_controls_end_in_controls1559);
            	controls_end146 = controls_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_controls_end.Add(controls_end146.Tree);


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
            	// 323:53: -> ^( IM_CONTROLS controls_start ( coord )+ controls_end )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:323:56: ^( IM_CONTROLS controls_start ( coord )+ controls_end )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:326:1: tikznode_ext : node_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikznode_ext_return tikznode_ext() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_ext_return retval = new simpletikzParser.tikznode_ext_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.node_start_return node_start147 = default(simpletikzParser.node_start_return);

        simpletikzParser.tikznode_core_return tikznode_core148 = default(simpletikzParser.tikznode_core_return);

        simpletikzParser.tikzpath_element_return tikzpath_element149 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end150 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_node_start = new RewriteRuleSubtreeStream(adaptor,"rule node_start");
        RewriteRuleSubtreeStream stream_tikznode_core = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_core");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:327:2: ( node_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:327:4: node_start tikznode_core ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_node_start_in_tikznode_ext1585);
            	node_start147 = node_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_node_start.Add(node_start147.Tree);
            	PushFollow(FOLLOW_tikznode_core_in_tikznode_ext1587);
            	tikznode_core148 = tikznode_core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_core.Add(tikznode_core148.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:327:29: ( tikzpath_element )*
            	do 
            	{
            	    int alt42 = 2;
            	    int LA42_0 = input.LA(1);

            	    if ( (LA42_0 == ID || LA42_0 == 41 || LA42_0 == 50 || LA42_0 == 52 || (LA42_0 >= 71 && LA42_0 <= 72) || (LA42_0 >= 74 && LA42_0 <= 83)) )
            	    {
            	        alt42 = 1;
            	    }


            	    switch (alt42) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:327:29: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikznode_ext1589);
            			    	tikzpath_element149 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element149.Tree);

            			    }
            			    break;

            			default:
            			    goto loop42;
            	    }
            	} while (true);

            	loop42:
            		;	// Stops C# compiler whining that label 'loop42' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikznode_ext1592);
            	semicolon_end150 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_semicolon_end.Add(semicolon_end150.Tree);


            	// AST REWRITE
            	// elements:          tikznode_core, semicolon_end, tikzpath_element, node_start
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 327:61: -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:327:64: ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_node_start.NextTree());
            	    adaptor.AddChild(root_1, stream_tikznode_core.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:327:99: ( tikzpath_element )*
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:330:1: tikzmatrix_ext : matrix_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH matrix_start tikznode_core ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikzmatrix_ext_return tikzmatrix_ext() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzmatrix_ext_return retval = new simpletikzParser.tikzmatrix_ext_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.matrix_start_return matrix_start151 = default(simpletikzParser.matrix_start_return);

        simpletikzParser.tikznode_core_return tikznode_core152 = default(simpletikzParser.tikznode_core_return);

        simpletikzParser.tikzpath_element_return tikzpath_element153 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end154 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_matrix_start = new RewriteRuleSubtreeStream(adaptor,"rule matrix_start");
        RewriteRuleSubtreeStream stream_tikznode_core = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_core");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:331:2: ( matrix_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH matrix_start tikznode_core ( tikzpath_element )* semicolon_end ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:331:4: matrix_start tikznode_core ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_matrix_start_in_tikzmatrix_ext1619);
            	matrix_start151 = matrix_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_matrix_start.Add(matrix_start151.Tree);
            	PushFollow(FOLLOW_tikznode_core_in_tikzmatrix_ext1621);
            	tikznode_core152 = tikznode_core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_core.Add(tikznode_core152.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:331:31: ( tikzpath_element )*
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
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:331:31: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikzmatrix_ext1623);
            			    	tikzpath_element153 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element153.Tree);

            			    }
            			    break;

            			default:
            			    goto loop43;
            	    }
            	} while (true);

            	loop43:
            		;	// Stops C# compiler whining that label 'loop43' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikzmatrix_ext1626);
            	semicolon_end154 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_semicolon_end.Add(semicolon_end154.Tree);


            	// AST REWRITE
            	// elements:          tikznode_core, semicolon_end, matrix_start, tikzpath_element
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 331:63: -> ^( IM_PATH matrix_start tikznode_core ( tikzpath_element )* semicolon_end )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:331:66: ^( IM_PATH matrix_start tikznode_core ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_matrix_start.NextTree());
            	    adaptor.AddChild(root_1, stream_tikznode_core.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:331:103: ( tikzpath_element )*
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:335:1: tikzcoordinate_ext : coordinate_start ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ( tikzpath_element )* semicolon_end -> ^( IM_PATH coordinate_start ( tikzcoordinate_core3 )? ( tikzcoordinate_core2 )? ( tikzcoordinate_core1 )? ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_ext_return retval = new simpletikzParser.tikzcoordinate_ext_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.coordinate_start_return coordinate_start155 = default(simpletikzParser.coordinate_start_return);

        simpletikzParser.tikzcoordinate_core3_return tikzcoordinate_core3156 = default(simpletikzParser.tikzcoordinate_core3_return);

        simpletikzParser.tikzcoordinate_core2_return tikzcoordinate_core2157 = default(simpletikzParser.tikzcoordinate_core2_return);

        simpletikzParser.tikzcoordinate_core1_return tikzcoordinate_core1158 = default(simpletikzParser.tikzcoordinate_core1_return);

        simpletikzParser.tikzpath_element_return tikzpath_element159 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end160 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_tikzcoordinate_core3 = new RewriteRuleSubtreeStream(adaptor,"rule tikzcoordinate_core3");
        RewriteRuleSubtreeStream stream_tikzcoordinate_core2 = new RewriteRuleSubtreeStream(adaptor,"rule tikzcoordinate_core2");
        RewriteRuleSubtreeStream stream_coordinate_start = new RewriteRuleSubtreeStream(adaptor,"rule coordinate_start");
        RewriteRuleSubtreeStream stream_tikzcoordinate_core1 = new RewriteRuleSubtreeStream(adaptor,"rule tikzcoordinate_core1");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:336:2: ( coordinate_start ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ( tikzpath_element )* semicolon_end -> ^( IM_PATH coordinate_start ( tikzcoordinate_core3 )? ( tikzcoordinate_core2 )? ( tikzcoordinate_core1 )? ( tikzpath_element )* semicolon_end ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:336:4: coordinate_start ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_coordinate_start_in_tikzcoordinate_ext1654);
            	coordinate_start155 = coordinate_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_coordinate_start.Add(coordinate_start155.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:337:5: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?
            	int alt44 = 4;
            	alt44 = dfa44.Predict(input);
            	switch (alt44) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:337:7: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        {
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:337:7: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:337:8: ( tikzcoordinate_core3 )=> tikzcoordinate_core3
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_ext1669);
            	        		tikzcoordinate_core3156 = tikzcoordinate_core3();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( (state.backtracking==0) ) stream_tikzcoordinate_core3.Add(tikzcoordinate_core3156.Tree);

            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:338:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        {
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:338:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:338:12: ( tikzcoordinate_core2 )=> tikzcoordinate_core2
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_ext1688);
            	        		tikzcoordinate_core2157 = tikzcoordinate_core2();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( (state.backtracking==0) ) stream_tikzcoordinate_core2.Add(tikzcoordinate_core2157.Tree);

            	        	}


            	        }
            	        break;
            	    case 3 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:339:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        {
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:339:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:339:12: ( tikzcoordinate_core1 )=> tikzcoordinate_core1
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_ext1708);
            	        		tikzcoordinate_core1158 = tikzcoordinate_core1();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( (state.backtracking==0) ) stream_tikzcoordinate_core1.Add(tikzcoordinate_core1158.Tree);

            	        	}


            	        }
            	        break;

            	}

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:340:6: ( tikzpath_element )*
            	do 
            	{
            	    int alt45 = 2;
            	    int LA45_0 = input.LA(1);

            	    if ( (LA45_0 == ID || LA45_0 == 41 || LA45_0 == 50 || LA45_0 == 52 || (LA45_0 >= 71 && LA45_0 <= 72) || (LA45_0 >= 74 && LA45_0 <= 83)) )
            	    {
            	        alt45 = 1;
            	    }


            	    switch (alt45) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:340:6: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikzcoordinate_ext1719);
            			    	tikzpath_element159 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikzpath_element.Add(tikzpath_element159.Tree);

            			    }
            			    break;

            			default:
            			    goto loop45;
            	    }
            	} while (true);

            	loop45:
            		;	// Stops C# compiler whining that label 'loop45' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikzcoordinate_ext1722);
            	semicolon_end160 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_semicolon_end.Add(semicolon_end160.Tree);


            	// AST REWRITE
            	// elements:          tikzpath_element, semicolon_end, tikzcoordinate_core1, coordinate_start, tikzcoordinate_core2, tikzcoordinate_core3
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 341:6: -> ^( IM_PATH coordinate_start ( tikzcoordinate_core3 )? ( tikzcoordinate_core2 )? ( tikzcoordinate_core1 )? ( tikzpath_element )* semicolon_end )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:341:9: ^( IM_PATH coordinate_start ( tikzcoordinate_core3 )? ( tikzcoordinate_core2 )? ( tikzcoordinate_core1 )? ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_coordinate_start.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:342:6: ( tikzcoordinate_core3 )?
            	    if ( stream_tikzcoordinate_core3.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzcoordinate_core3.NextTree());

            	    }
            	    stream_tikzcoordinate_core3.Reset();
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:343:6: ( tikzcoordinate_core2 )?
            	    if ( stream_tikzcoordinate_core2.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzcoordinate_core2.NextTree());

            	    }
            	    stream_tikzcoordinate_core2.Reset();
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:344:6: ( tikzcoordinate_core1 )?
            	    if ( stream_tikzcoordinate_core1.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzcoordinate_core1.NextTree());

            	    }
            	    stream_tikzcoordinate_core1.Reset();
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:345:6: ( tikzpath_element )*
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:347:1: tikzcoordinate_int : 'coordinate' ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ;
    public simpletikzParser.tikzcoordinate_int_return tikzcoordinate_int() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_int_return retval = new simpletikzParser.tikzcoordinate_int_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal161 = null;
        simpletikzParser.tikzcoordinate_core3_return tikzcoordinate_core3162 = default(simpletikzParser.tikzcoordinate_core3_return);

        simpletikzParser.tikzcoordinate_core2_return tikzcoordinate_core2163 = default(simpletikzParser.tikzcoordinate_core2_return);

        simpletikzParser.tikzcoordinate_core1_return tikzcoordinate_core1164 = default(simpletikzParser.tikzcoordinate_core1_return);


        object string_literal161_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:348:2: ( 'coordinate' ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:348:4: 'coordinate' ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal161=(IToken)Match(input,71,FOLLOW_71_in_tikzcoordinate_int1782); if (state.failed) return retval;
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:348:18: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?
            	int alt46 = 4;
            	alt46 = dfa46.Predict(input);
            	switch (alt46) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:348:20: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        {
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:348:20: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:348:21: ( tikzcoordinate_core3 )=> tikzcoordinate_core3
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_int1793);
            	        		tikzcoordinate_core3162 = tikzcoordinate_core3();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_core3162.Tree);

            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:349:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        {
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:349:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:349:12: ( tikzcoordinate_core2 )=> tikzcoordinate_core2
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_int1812);
            	        		tikzcoordinate_core2163 = tikzcoordinate_core2();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_core2163.Tree);

            	        	}


            	        }
            	        break;
            	    case 3 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:350:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        {
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:350:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:350:12: ( tikzcoordinate_core1 )=> tikzcoordinate_core1
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_int1832);
            	        		tikzcoordinate_core1164 = tikzcoordinate_core1();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_core1164.Tree);

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:352:1: tikznode_int : 'node' tikznode_core ;
    public simpletikzParser.tikznode_int_return tikznode_int() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_int_return retval = new simpletikzParser.tikznode_int_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal165 = null;
        simpletikzParser.tikznode_core_return tikznode_core166 = default(simpletikzParser.tikznode_core_return);


        object string_literal165_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:353:2: ( 'node' tikznode_core )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:353:4: 'node' tikznode_core
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal165=(IToken)Match(input,72,FOLLOW_72_in_tikznode_int1848); if (state.failed) return retval;
            	PushFollow(FOLLOW_tikznode_core_in_tikznode_int1851);
            	tikznode_core166 = tikznode_core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_core166.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:355:1: tikznode_core : ( tikznode_decorator )* tikzstring -> ^( IM_NODE ( tikznode_decorator )* tikzstring ) ;
    public simpletikzParser.tikznode_core_return tikznode_core() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_core_return retval = new simpletikzParser.tikznode_core_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator167 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikzstring_return tikzstring168 = default(simpletikzParser.tikzstring_return);


        RewriteRuleSubtreeStream stream_tikzstring = new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:356:2: ( ( tikznode_decorator )* tikzstring -> ^( IM_NODE ( tikznode_decorator )* tikzstring ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:356:4: ( tikznode_decorator )* tikzstring
            {
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:356:4: ( tikznode_decorator )*
            	do 
            	{
            	    int alt47 = 2;
            	    int LA47_0 = input.LA(1);

            	    if ( (LA47_0 == 50 || LA47_0 == 52 || LA47_0 == 73) )
            	    {
            	        alt47 = 1;
            	    }


            	    switch (alt47) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:356:4: tikznode_decorator
            			    {
            			    	PushFollow(FOLLOW_tikznode_decorator_in_tikznode_core1861);
            			    	tikznode_decorator167 = tikznode_decorator();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator167.Tree);

            			    }
            			    break;

            			default:
            			    goto loop47;
            	    }
            	} while (true);

            	loop47:
            		;	// Stops C# compiler whining that label 'loop47' has no statements

            	PushFollow(FOLLOW_tikzstring_in_tikznode_core1864);
            	tikzstring168 = tikzstring();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikzstring.Add(tikzstring168.Tree);


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
            	// 356:36: -> ^( IM_NODE ( tikznode_decorator )* tikzstring )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:356:39: ^( IM_NODE ( tikznode_decorator )* tikzstring )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NODE, "IM_NODE"), root_1);

            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:356:49: ( tikznode_decorator )*
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:359:1: tikzcoordinate_core3 : tikznode_decorator tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator ) ;
    public simpletikzParser.tikzcoordinate_core3_return tikzcoordinate_core3() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_core3_return retval = new simpletikzParser.tikzcoordinate_core3_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator169 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikznode_decorator_return tikznode_decorator170 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikznode_decorator_return tikznode_decorator171 = default(simpletikzParser.tikznode_decorator_return);


        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:360:2: ( tikznode_decorator tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:360:6: tikznode_decorator tikznode_decorator tikznode_decorator
            {
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core31889);
            	tikznode_decorator169 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator169.Tree);
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core31891);
            	tikznode_decorator170 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator170.Tree);
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core31893);
            	tikznode_decorator171 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator171.Tree);


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
            	// 360:64: -> ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:360:67: ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:364:1: tikzcoordinate_core2 : tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator ) ;
    public simpletikzParser.tikzcoordinate_core2_return tikzcoordinate_core2() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_core2_return retval = new simpletikzParser.tikzcoordinate_core2_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator172 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikznode_decorator_return tikznode_decorator173 = default(simpletikzParser.tikznode_decorator_return);


        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:365:2: ( tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:366:4: tikznode_decorator tikznode_decorator
            {
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core21927);
            	tikznode_decorator172 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator172.Tree);
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core21929);
            	tikznode_decorator173 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator173.Tree);


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
            	// 366:47: -> ^( IM_NODE tikznode_decorator tikznode_decorator )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:366:50: ^( IM_NODE tikznode_decorator tikznode_decorator )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:369:1: tikzcoordinate_core1 : tikznode_decorator -> ^( IM_NODE tikznode_decorator ) ;
    public simpletikzParser.tikzcoordinate_core1_return tikzcoordinate_core1() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_core1_return retval = new simpletikzParser.tikzcoordinate_core1_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator174 = default(simpletikzParser.tikznode_decorator_return);


        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:370:2: ( tikznode_decorator -> ^( IM_NODE tikznode_decorator ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:371:4: tikznode_decorator
            {
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core11962);
            	tikznode_decorator174 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tikznode_decorator.Add(tikznode_decorator174.Tree);


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
            	// 371:31: -> ^( IM_NODE tikznode_decorator )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:371:34: ^( IM_NODE tikznode_decorator )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:378:1: tikznode_decorator : ( nodename | 'at' coord | tikz_options_dontcare );
    public simpletikzParser.tikznode_decorator_return tikznode_decorator() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_decorator_return retval = new simpletikzParser.tikznode_decorator_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal176 = null;
        simpletikzParser.nodename_return nodename175 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_return coord177 = default(simpletikzParser.coord_return);

        simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare178 = default(simpletikzParser.tikz_options_dontcare_return);


        object string_literal176_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:379:2: ( nodename | 'at' coord | tikz_options_dontcare )
            int alt48 = 3;
            switch ( input.LA(1) ) 
            {
            case 50:
            	{
                alt48 = 1;
                }
                break;
            case 73:
            	{
                alt48 = 2;
                }
                break;
            case 52:
            	{
                alt48 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d48s0 =
            	        new NoViableAltException("", 48, 0, input);

            	    throw nvae_d48s0;
            }

            switch (alt48) 
            {
                case 1 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:379:6: nodename
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_nodename_in_tikznode_decorator1999);
                    	nodename175 = nodename();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, nodename175.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:380:5: 'at' coord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal176=(IToken)Match(input,73,FOLLOW_73_in_tikznode_decorator2006); if (state.failed) return retval;
                    	PushFollow(FOLLOW_coord_in_tikznode_decorator2009);
                    	coord177 = coord();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, coord177.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:381:5: tikz_options_dontcare
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_options_dontcare_in_tikznode_decorator2015);
                    	tikz_options_dontcare178 = tikz_options_dontcare();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_options_dontcare178.Tree);

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:383:1: tikz_options_dontcare : '[' ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* ']' -> ^( IM_OPTIONS ) ;
    public simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_options_dontcare_return retval = new simpletikzParser.tikz_options_dontcare_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal179 = null;
        IToken char_literal183 = null;
        simpletikzParser.no_rlbracket_return no_rlbracket180 = default(simpletikzParser.no_rlbracket_return);

        simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare181 = default(simpletikzParser.tikz_options_dontcare_return);

        simpletikzParser.no_rlbracket_return no_rlbracket182 = default(simpletikzParser.no_rlbracket_return);


        object char_literal179_tree=null;
        object char_literal183_tree=null;
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleSubtreeStream stream_tikz_options_dontcare = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options_dontcare");
        RewriteRuleSubtreeStream stream_no_rlbracket = new RewriteRuleSubtreeStream(adaptor,"rule no_rlbracket");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:384:2: ( '[' ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* ']' -> ^( IM_OPTIONS ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:384:4: '[' ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* ']'
            {
            	char_literal179=(IToken)Match(input,52,FOLLOW_52_in_tikz_options_dontcare2025); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_52.Add(char_literal179);

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:384:8: ( no_rlbracket )*
            	do 
            	{
            	    int alt49 = 2;
            	    int LA49_0 = input.LA(1);

            	    if ( ((LA49_0 >= IM_PATH && LA49_0 <= 51) || (LA49_0 >= 54 && LA49_0 <= 86)) )
            	    {
            	        alt49 = 1;
            	    }


            	    switch (alt49) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:384:8: no_rlbracket
            			    {
            			    	PushFollow(FOLLOW_no_rlbracket_in_tikz_options_dontcare2027);
            			    	no_rlbracket180 = no_rlbracket();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_no_rlbracket.Add(no_rlbracket180.Tree);

            			    }
            			    break;

            			default:
            			    goto loop49;
            	    }
            	} while (true);

            	loop49:
            		;	// Stops C# compiler whining that label 'loop49' has no statements

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:384:22: ( tikz_options_dontcare ( no_rlbracket )* )*
            	do 
            	{
            	    int alt51 = 2;
            	    int LA51_0 = input.LA(1);

            	    if ( (LA51_0 == 52) )
            	    {
            	        alt51 = 1;
            	    }


            	    switch (alt51) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:384:23: tikz_options_dontcare ( no_rlbracket )*
            			    {
            			    	PushFollow(FOLLOW_tikz_options_dontcare_in_tikz_options_dontcare2031);
            			    	tikz_options_dontcare181 = tikz_options_dontcare();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tikz_options_dontcare.Add(tikz_options_dontcare181.Tree);
            			    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:384:45: ( no_rlbracket )*
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
            			    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:384:45: no_rlbracket
            			    			    {
            			    			    	PushFollow(FOLLOW_no_rlbracket_in_tikz_options_dontcare2033);
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


            			    }
            			    break;

            			default:
            			    goto loop51;
            	    }
            	} while (true);

            	loop51:
            		;	// Stops C# compiler whining that label 'loop51' has no statements

            	char_literal183=(IToken)Match(input,53,FOLLOW_53_in_tikz_options_dontcare2038); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_53.Add(char_literal183);



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
            	// 384:65: -> ^( IM_OPTIONS )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:384:68: ^( IM_OPTIONS )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:386:1: no_rlbracket : ~ ( '[' | ']' ) ;
    public simpletikzParser.no_rlbracket_return no_rlbracket() // throws RecognitionException [1]
    {   
        simpletikzParser.no_rlbracket_return retval = new simpletikzParser.no_rlbracket_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set184 = null;

        object set184_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:387:2: (~ ( '[' | ']' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:387:4: ~ ( '[' | ']' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set184 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= 51) || (input.LA(1) >= 54 && input.LA(1) <= 86) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set184));
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:389:1: nodename : '(' idd ')' -> ^( IM_NODENAME idd ) ;
    public simpletikzParser.nodename_return nodename() // throws RecognitionException [1]
    {   
        simpletikzParser.nodename_return retval = new simpletikzParser.nodename_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal185 = null;
        IToken char_literal187 = null;
        simpletikzParser.idd_return idd186 = default(simpletikzParser.idd_return);


        object char_literal185_tree=null;
        object char_literal187_tree=null;
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:390:2: ( '(' idd ')' -> ^( IM_NODENAME idd ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:390:4: '(' idd ')'
            {
            	char_literal185=(IToken)Match(input,50,FOLLOW_50_in_nodename2073); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_50.Add(char_literal185);

            	PushFollow(FOLLOW_idd_in_nodename2075);
            	idd186 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_idd.Add(idd186.Tree);
            	char_literal187=(IToken)Match(input,51,FOLLOW_51_in_nodename2077); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_51.Add(char_literal187);



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
            	// 390:17: -> ^( IM_NODENAME idd )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:390:20: ^( IM_NODENAME idd )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:396:1: circle : ( 'circle' | 'ellipse' ) ( ( size )=> size )? ->;
    public simpletikzParser.circle_return circle() // throws RecognitionException [1]
    {   
        simpletikzParser.circle_return retval = new simpletikzParser.circle_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal188 = null;
        IToken string_literal189 = null;
        simpletikzParser.size_return size190 = default(simpletikzParser.size_return);


        object string_literal188_tree=null;
        object string_literal189_tree=null;
        RewriteRuleTokenStream stream_74 = new RewriteRuleTokenStream(adaptor,"token 74");
        RewriteRuleTokenStream stream_75 = new RewriteRuleTokenStream(adaptor,"token 75");
        RewriteRuleSubtreeStream stream_size = new RewriteRuleSubtreeStream(adaptor,"rule size");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:397:2: ( ( 'circle' | 'ellipse' ) ( ( size )=> size )? ->)
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:397:4: ( 'circle' | 'ellipse' ) ( ( size )=> size )?
            {
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:397:4: ( 'circle' | 'ellipse' )
            	int alt52 = 2;
            	int LA52_0 = input.LA(1);

            	if ( (LA52_0 == 74) )
            	{
            	    alt52 = 1;
            	}
            	else if ( (LA52_0 == 75) )
            	{
            	    alt52 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d52s0 =
            	        new NoViableAltException("", 52, 0, input);

            	    throw nvae_d52s0;
            	}
            	switch (alt52) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:397:5: 'circle'
            	        {
            	        	string_literal188=(IToken)Match(input,74,FOLLOW_74_in_circle2101); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_74.Add(string_literal188);


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:397:16: 'ellipse'
            	        {
            	        	string_literal189=(IToken)Match(input,75,FOLLOW_75_in_circle2105); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_75.Add(string_literal189);


            	        }
            	        break;

            	}

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:397:27: ( ( size )=> size )?
            	int alt53 = 2;
            	alt53 = dfa53.Predict(input);
            	switch (alt53) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:397:28: ( size )=> size
            	        {
            	        	PushFollow(FOLLOW_size_in_circle2114);
            	        	size190 = size();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_size.Add(size190.Tree);

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
            	// 397:44: ->
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:399:1: arc : 'arc' ( '(' numberunit ':' numberunit ':' numberunit ( 'and' numberunit )? ')' )? -> ^( IM_ARC ( numberunit )+ ) ;
    public simpletikzParser.arc_return arc() // throws RecognitionException [1]
    {   
        simpletikzParser.arc_return retval = new simpletikzParser.arc_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal191 = null;
        IToken char_literal192 = null;
        IToken char_literal194 = null;
        IToken char_literal196 = null;
        IToken string_literal198 = null;
        IToken char_literal200 = null;
        simpletikzParser.numberunit_return numberunit193 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit195 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit197 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit199 = default(simpletikzParser.numberunit_return);


        object string_literal191_tree=null;
        object char_literal192_tree=null;
        object char_literal194_tree=null;
        object char_literal196_tree=null;
        object string_literal198_tree=null;
        object char_literal200_tree=null;
        RewriteRuleTokenStream stream_46 = new RewriteRuleTokenStream(adaptor,"token 46");
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_70 = new RewriteRuleTokenStream(adaptor,"token 70");
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleTokenStream stream_76 = new RewriteRuleTokenStream(adaptor,"token 76");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:400:2: ( 'arc' ( '(' numberunit ':' numberunit ':' numberunit ( 'and' numberunit )? ')' )? -> ^( IM_ARC ( numberunit )+ ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:400:4: 'arc' ( '(' numberunit ':' numberunit ':' numberunit ( 'and' numberunit )? ')' )?
            {
            	string_literal191=(IToken)Match(input,76,FOLLOW_76_in_arc2129); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_76.Add(string_literal191);

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:400:10: ( '(' numberunit ':' numberunit ':' numberunit ( 'and' numberunit )? ')' )?
            	int alt55 = 2;
            	int LA55_0 = input.LA(1);

            	if ( (LA55_0 == 50) )
            	{
            	    int LA55_1 = input.LA(2);

            	    if ( ((LA55_1 >= FLOAT_WO_EXP && LA55_1 <= INT)) )
            	    {
            	        int LA55_3 = input.LA(3);

            	        if ( ((LA55_3 >= 55 && LA55_3 <= 60)) )
            	        {
            	            int LA55_4 = input.LA(4);

            	            if ( (LA55_4 == 46) )
            	            {
            	                int LA55_5 = input.LA(5);

            	                if ( ((LA55_5 >= FLOAT_WO_EXP && LA55_5 <= INT)) )
            	                {
            	                    int LA55_6 = input.LA(6);

            	                    if ( ((LA55_6 >= 55 && LA55_6 <= 60)) )
            	                    {
            	                        int LA55_7 = input.LA(7);

            	                        if ( (LA55_7 == 46) )
            	                        {
            	                            alt55 = 1;
            	                        }
            	                    }
            	                    else if ( (LA55_6 == 46) )
            	                    {
            	                        alt55 = 1;
            	                    }
            	                }
            	            }
            	        }
            	        else if ( (LA55_3 == 46) )
            	        {
            	            int LA55_5 = input.LA(4);

            	            if ( ((LA55_5 >= FLOAT_WO_EXP && LA55_5 <= INT)) )
            	            {
            	                int LA55_6 = input.LA(5);

            	                if ( ((LA55_6 >= 55 && LA55_6 <= 60)) )
            	                {
            	                    int LA55_7 = input.LA(6);

            	                    if ( (LA55_7 == 46) )
            	                    {
            	                        alt55 = 1;
            	                    }
            	                }
            	                else if ( (LA55_6 == 46) )
            	                {
            	                    alt55 = 1;
            	                }
            	            }
            	        }
            	    }
            	}
            	switch (alt55) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:400:11: '(' numberunit ':' numberunit ':' numberunit ( 'and' numberunit )? ')'
            	        {
            	        	char_literal192=(IToken)Match(input,50,FOLLOW_50_in_arc2132); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_50.Add(char_literal192);

            	        	PushFollow(FOLLOW_numberunit_in_arc2134);
            	        	numberunit193 = numberunit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit193.Tree);
            	        	char_literal194=(IToken)Match(input,46,FOLLOW_46_in_arc2136); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_46.Add(char_literal194);

            	        	PushFollow(FOLLOW_numberunit_in_arc2138);
            	        	numberunit195 = numberunit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit195.Tree);
            	        	char_literal196=(IToken)Match(input,46,FOLLOW_46_in_arc2140); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_46.Add(char_literal196);

            	        	PushFollow(FOLLOW_numberunit_in_arc2142);
            	        	numberunit197 = numberunit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit197.Tree);
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:400:56: ( 'and' numberunit )?
            	        	int alt54 = 2;
            	        	int LA54_0 = input.LA(1);

            	        	if ( (LA54_0 == 70) )
            	        	{
            	        	    alt54 = 1;
            	        	}
            	        	switch (alt54) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:400:57: 'and' numberunit
            	        	        {
            	        	        	string_literal198=(IToken)Match(input,70,FOLLOW_70_in_arc2145); if (state.failed) return retval; 
            	        	        	if ( (state.backtracking==0) ) stream_70.Add(string_literal198);

            	        	        	PushFollow(FOLLOW_numberunit_in_arc2147);
            	        	        	numberunit199 = numberunit();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit199.Tree);

            	        	        }
            	        	        break;

            	        	}

            	        	char_literal200=(IToken)Match(input,51,FOLLOW_51_in_arc2151); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_51.Add(char_literal200);


            	        }
            	        break;

            	}



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
            	// 400:82: -> ^( IM_ARC ( numberunit )+ )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:400:85: ^( IM_ARC ( numberunit )+ )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ARC, "IM_ARC"), root_1);

            	    if ( !(stream_numberunit.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:403:1: size : '(' numberunit ( 'and' numberunit )? ')' -> ^( IM_SIZE ( numberunit )* ) ;
    public simpletikzParser.size_return size() // throws RecognitionException [1]
    {   
        simpletikzParser.size_return retval = new simpletikzParser.size_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal201 = null;
        IToken string_literal203 = null;
        IToken char_literal205 = null;
        simpletikzParser.numberunit_return numberunit202 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit204 = default(simpletikzParser.numberunit_return);


        object char_literal201_tree=null;
        object string_literal203_tree=null;
        object char_literal205_tree=null;
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_70 = new RewriteRuleTokenStream(adaptor,"token 70");
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:404:2: ( '(' numberunit ( 'and' numberunit )? ')' -> ^( IM_SIZE ( numberunit )* ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:404:6: '(' numberunit ( 'and' numberunit )? ')'
            {
            	char_literal201=(IToken)Match(input,50,FOLLOW_50_in_size2176); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_50.Add(char_literal201);

            	PushFollow(FOLLOW_numberunit_in_size2178);
            	numberunit202 = numberunit();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit202.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:404:21: ( 'and' numberunit )?
            	int alt56 = 2;
            	int LA56_0 = input.LA(1);

            	if ( (LA56_0 == 70) )
            	{
            	    alt56 = 1;
            	}
            	switch (alt56) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:404:22: 'and' numberunit
            	        {
            	        	string_literal203=(IToken)Match(input,70,FOLLOW_70_in_size2181); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_70.Add(string_literal203);

            	        	PushFollow(FOLLOW_numberunit_in_size2183);
            	        	numberunit204 = numberunit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit204.Tree);

            	        }
            	        break;

            	}

            	char_literal205=(IToken)Match(input,51,FOLLOW_51_in_size2187); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_51.Add(char_literal205);



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
            	// 404:46: -> ^( IM_SIZE ( numberunit )* )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:404:49: ^( IM_SIZE ( numberunit )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_SIZE, "IM_SIZE"), root_1);

            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:404:59: ( numberunit )*
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:411:1: coord : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) );
    public simpletikzParser.coord_return coord() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_return retval = new simpletikzParser.coord_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal208 = null;
        IToken char_literal212 = null;
        IToken char_literal214 = null;
        IToken char_literal218 = null;
        simpletikzParser.nodename_return nodename206 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_modifier_return coord_modifier207 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.numberunit_return numberunit209 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_sep_return coord_sep210 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.numberunit_return numberunit211 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_modifier_return coord_modifier213 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.coord_part_return coord_part215 = default(simpletikzParser.coord_part_return);

        simpletikzParser.coord_sep_return coord_sep216 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.coord_part_return coord_part217 = default(simpletikzParser.coord_part_return);


        object char_literal208_tree=null;
        object char_literal212_tree=null;
        object char_literal214_tree=null;
        object char_literal218_tree=null;
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_coord_part = new RewriteRuleSubtreeStream(adaptor,"rule coord_part");
        RewriteRuleSubtreeStream stream_coord_sep = new RewriteRuleSubtreeStream(adaptor,"rule coord_sep");
        RewriteRuleSubtreeStream stream_nodename = new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        RewriteRuleSubtreeStream stream_coord_modifier = new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:412:2: ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) )
            int alt59 = 3;
            alt59 = dfa59.Predict(input);
            switch (alt59) 
            {
                case 1 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:412:6: nodename
                    {
                    	PushFollow(FOLLOW_nodename_in_coord2217);
                    	nodename206 = nodename();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_nodename.Add(nodename206.Tree);


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
                    	// 412:23: -> ^( IM_COORD nodename )
                    	{
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:412:26: ^( IM_COORD nodename )
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
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:413:5: ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' )
                    {
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:413:5: ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' )
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:413:7: ( coord_modifier )? '(' numberunit coord_sep numberunit ')'
                    	{
                    		// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:413:7: ( coord_modifier )?
                    		int alt57 = 2;
                    		int LA57_0 = input.LA(1);

                    		if ( ((LA57_0 >= 81 && LA57_0 <= 82)) )
                    		{
                    		    alt57 = 1;
                    		}
                    		switch (alt57) 
                    		{
                    		    case 1 :
                    		        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:413:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord2241);
                    		        	coord_modifier207 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_coord_modifier.Add(coord_modifier207.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal208=(IToken)Match(input,50,FOLLOW_50_in_coord2244); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_50.Add(char_literal208);

                    		PushFollow(FOLLOW_numberunit_in_coord2246);
                    		numberunit209 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit209.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord2248);
                    		coord_sep210 = coord_sep();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_sep.Add(coord_sep210.Tree);
                    		PushFollow(FOLLOW_numberunit_in_coord2250);
                    		numberunit211 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_numberunit.Add(numberunit211.Tree);
                    		char_literal212=(IToken)Match(input,51,FOLLOW_51_in_coord2252); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_51.Add(char_literal212);


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
                    	// 413:65: -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep )
                    	{
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:413:68: ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:413:79: ( coord_modifier )?
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
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:414:5: ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' )
                    {
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:414:5: ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' )
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:414:7: ( coord_modifier )? '(' coord_part coord_sep coord_part ')'
                    	{
                    		// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:414:7: ( coord_modifier )?
                    		int alt58 = 2;
                    		int LA58_0 = input.LA(1);

                    		if ( ((LA58_0 >= 81 && LA58_0 <= 82)) )
                    		{
                    		    alt58 = 1;
                    		}
                    		switch (alt58) 
                    		{
                    		    case 1 :
                    		        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:414:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord2276);
                    		        	coord_modifier213 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_coord_modifier.Add(coord_modifier213.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal214=(IToken)Match(input,50,FOLLOW_50_in_coord2279); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_50.Add(char_literal214);

                    		PushFollow(FOLLOW_coord_part_in_coord2281);
                    		coord_part215 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_part.Add(coord_part215.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord2283);
                    		coord_sep216 = coord_sep();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_sep.Add(coord_sep216.Tree);
                    		PushFollow(FOLLOW_coord_part_in_coord2285);
                    		coord_part217 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_coord_part.Add(coord_part217.Tree);
                    		char_literal218=(IToken)Match(input,51,FOLLOW_51_in_coord2287); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_51.Add(char_literal218);


                    	}



                    	// AST REWRITE
                    	// elements:          coord_sep, coord_part, coord_modifier
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 414:65: -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep )
                    	{
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:414:68: ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:414:79: ( coord_modifier )?
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:418:1: coord_part : ( idd -> ^( IM_DONTCARE idd ) | '{' idd '}' -> ^( IM_DONTCARE '{' idd '}' ) );
    public simpletikzParser.coord_part_return coord_part() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_part_return retval = new simpletikzParser.coord_part_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal220 = null;
        IToken char_literal222 = null;
        simpletikzParser.idd_return idd219 = default(simpletikzParser.idd_return);

        simpletikzParser.idd_return idd221 = default(simpletikzParser.idd_return);


        object char_literal220_tree=null;
        object char_literal222_tree=null;
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:419:2: ( idd -> ^( IM_DONTCARE idd ) | '{' idd '}' -> ^( IM_DONTCARE '{' idd '}' ) )
            int alt60 = 2;
            int LA60_0 = input.LA(1);

            if ( ((LA60_0 >= IM_PATH && LA60_0 <= 40) || LA60_0 == 44 || LA60_0 == 49 || (LA60_0 >= 55 && LA60_0 <= 86)) )
            {
                alt60 = 1;
            }
            else if ( (LA60_0 == 41) )
            {
                alt60 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d60s0 =
                    new NoViableAltException("", 60, 0, input);

                throw nvae_d60s0;
            }
            switch (alt60) 
            {
                case 1 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:419:4: idd
                    {
                    	PushFollow(FOLLOW_idd_in_coord_part2315);
                    	idd219 = idd();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_idd.Add(idd219.Tree);


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
                    	// 419:9: -> ^( IM_DONTCARE idd )
                    	{
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:419:12: ^( IM_DONTCARE idd )
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
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:420:4: '{' idd '}'
                    {
                    	char_literal220=(IToken)Match(input,41,FOLLOW_41_in_coord_part2330); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_41.Add(char_literal220);

                    	PushFollow(FOLLOW_idd_in_coord_part2332);
                    	idd221 = idd();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_idd.Add(idd221.Tree);
                    	char_literal222=(IToken)Match(input,42,FOLLOW_42_in_coord_part2334); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_42.Add(char_literal222);



                    	// AST REWRITE
                    	// elements:          42, idd, 41
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 420:16: -> ^( IM_DONTCARE '{' idd '}' )
                    	{
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:420:19: ^( IM_DONTCARE '{' idd '}' )
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

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:422:1: coord_sep : ( ',' | ':' ) ;
    public simpletikzParser.coord_sep_return coord_sep() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_sep_return retval = new simpletikzParser.coord_sep_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set223 = null;

        object set223_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:423:2: ( ( ',' | ':' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:423:4: ( ',' | ':' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set223 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 45 && input.LA(1) <= 46) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set223));
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:427:1: edgeop : ( '--' | '->' | '|-' | '-|' | ID );
    public simpletikzParser.edgeop_return edgeop() // throws RecognitionException [1]
    {   
        simpletikzParser.edgeop_return retval = new simpletikzParser.edgeop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set224 = null;

        object set224_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:428:2: ( '--' | '->' | '|-' | '-|' | ID )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set224 = (IToken)input.LT(1);
            	if ( input.LA(1) == ID || (input.LA(1) >= 77 && input.LA(1) <= 80) ) 
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

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:432:1: coord_modifier : ( '+' | '++' );
    public simpletikzParser.coord_modifier_return coord_modifier() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_modifier_return retval = new simpletikzParser.coord_modifier_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set225 = null;

        object set225_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:433:2: ( '+' | '++' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set225 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 81 && input.LA(1) <= 82) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set225));
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:475:1: squarebr_start : '[' -> ^( IM_STARTTAG '[' ) ;
    public simpletikzParser.squarebr_start_return squarebr_start() // throws RecognitionException [1]
    {   
        simpletikzParser.squarebr_start_return retval = new simpletikzParser.squarebr_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal226 = null;

        object char_literal226_tree=null;
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:476:2: ( '[' -> ^( IM_STARTTAG '[' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:476:4: '['
            {
            	char_literal226=(IToken)Match(input,52,FOLLOW_52_in_squarebr_start2430); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_52.Add(char_literal226);



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
            	// 476:8: -> ^( IM_STARTTAG '[' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:476:11: ^( IM_STARTTAG '[' )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:478:1: squarebr_end : ']' -> ^( IM_ENDTAG ']' ) ;
    public simpletikzParser.squarebr_end_return squarebr_end() // throws RecognitionException [1]
    {   
        simpletikzParser.squarebr_end_return retval = new simpletikzParser.squarebr_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal227 = null;

        object char_literal227_tree=null;
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:479:2: ( ']' -> ^( IM_ENDTAG ']' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:479:4: ']'
            {
            	char_literal227=(IToken)Match(input,53,FOLLOW_53_in_squarebr_end2448); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_53.Add(char_literal227);



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
            	// 479:8: -> ^( IM_ENDTAG ']' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:479:11: ^( IM_ENDTAG ']' )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:481:1: semicolon_end : ';' -> ^( IM_ENDTAG ';' ) ;
    public simpletikzParser.semicolon_end_return semicolon_end() // throws RecognitionException [1]
    {   
        simpletikzParser.semicolon_end_return retval = new simpletikzParser.semicolon_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal228 = null;

        object char_literal228_tree=null;
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:482:2: ( ';' -> ^( IM_ENDTAG ';' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:482:4: ';'
            {
            	char_literal228=(IToken)Match(input,54,FOLLOW_54_in_semicolon_end2467); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_54.Add(char_literal228);



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
            	// 482:8: -> ^( IM_ENDTAG ';' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:482:11: ^( IM_ENDTAG ';' )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:484:1: roundbr_start : '{' -> ^( IM_STARTTAG '{' ) ;
    public simpletikzParser.roundbr_start_return roundbr_start() // throws RecognitionException [1]
    {   
        simpletikzParser.roundbr_start_return retval = new simpletikzParser.roundbr_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal229 = null;

        object char_literal229_tree=null;
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:485:2: ( '{' -> ^( IM_STARTTAG '{' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:485:4: '{'
            {
            	char_literal229=(IToken)Match(input,41,FOLLOW_41_in_roundbr_start2485); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(char_literal229);



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
            	// 485:8: -> ^( IM_STARTTAG '{' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:485:11: ^( IM_STARTTAG '{' )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:487:1: roundbr_end : '}' -> ^( IM_ENDTAG '}' ) ;
    public simpletikzParser.roundbr_end_return roundbr_end() // throws RecognitionException [1]
    {   
        simpletikzParser.roundbr_end_return retval = new simpletikzParser.roundbr_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal230 = null;

        object char_literal230_tree=null;
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:488:2: ( '}' -> ^( IM_ENDTAG '}' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:488:4: '}'
            {
            	char_literal230=(IToken)Match(input,42,FOLLOW_42_in_roundbr_end2503); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_42.Add(char_literal230);



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
            	// 488:8: -> ^( IM_ENDTAG '}' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:488:11: ^( IM_ENDTAG '}' )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:490:1: controls_start : '..' 'controls' -> ^( IM_STARTTAG '..' ) ;
    public simpletikzParser.controls_start_return controls_start() // throws RecognitionException [1]
    {   
        simpletikzParser.controls_start_return retval = new simpletikzParser.controls_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal231 = null;
        IToken string_literal232 = null;

        object string_literal231_tree=null;
        object string_literal232_tree=null;
        RewriteRuleTokenStream stream_83 = new RewriteRuleTokenStream(adaptor,"token 83");
        RewriteRuleTokenStream stream_84 = new RewriteRuleTokenStream(adaptor,"token 84");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:491:2: ( '..' 'controls' -> ^( IM_STARTTAG '..' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:491:4: '..' 'controls'
            {
            	string_literal231=(IToken)Match(input,83,FOLLOW_83_in_controls_start2521); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_83.Add(string_literal231);

            	string_literal232=(IToken)Match(input,84,FOLLOW_84_in_controls_start2523); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_84.Add(string_literal232);



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
            	// 491:20: -> ^( IM_STARTTAG '..' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:491:23: ^( IM_STARTTAG '..' )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:493:1: controls_end : '..' -> ^( IM_ENDTAG '..' ) ;
    public simpletikzParser.controls_end_return controls_end() // throws RecognitionException [1]
    {   
        simpletikzParser.controls_end_return retval = new simpletikzParser.controls_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal233 = null;

        object string_literal233_tree=null;
        RewriteRuleTokenStream stream_83 = new RewriteRuleTokenStream(adaptor,"token 83");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:494:2: ( '..' -> ^( IM_ENDTAG '..' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:494:4: '..'
            {
            	string_literal233=(IToken)Match(input,83,FOLLOW_83_in_controls_end2541); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_83.Add(string_literal233);



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
            	// 494:9: -> ^( IM_ENDTAG '..' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:494:12: ^( IM_ENDTAG '..' )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:496:1: tikz_set_start : '\\\\tikzset' '{' -> ^( IM_STARTTAG ) ;
    public simpletikzParser.tikz_set_start_return tikz_set_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_set_start_return retval = new simpletikzParser.tikz_set_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal234 = null;
        IToken char_literal235 = null;

        object string_literal234_tree=null;
        object char_literal235_tree=null;
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:497:2: ( '\\\\tikzset' '{' -> ^( IM_STARTTAG ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:497:4: '\\\\tikzset' '{'
            {
            	string_literal234=(IToken)Match(input,40,FOLLOW_40_in_tikz_set_start2559); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_40.Add(string_literal234);

            	char_literal235=(IToken)Match(input,41,FOLLOW_41_in_tikz_set_start2561); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(char_literal235);



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
            	// 497:21: -> ^( IM_STARTTAG )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:497:24: ^( IM_STARTTAG )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:499:1: tikzpicture_start : '\\\\begin' '{' 'tikzpicture' '}' -> ^( IM_STARTTAG '\\\\begin' ) ;
    public simpletikzParser.tikzpicture_start_return tikzpicture_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_start_return retval = new simpletikzParser.tikzpicture_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal236 = null;
        IToken char_literal237 = null;
        IToken string_literal238 = null;
        IToken char_literal239 = null;

        object string_literal236_tree=null;
        object char_literal237_tree=null;
        object string_literal238_tree=null;
        object char_literal239_tree=null;
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_85 = new RewriteRuleTokenStream(adaptor,"token 85");
        RewriteRuleTokenStream stream_38 = new RewriteRuleTokenStream(adaptor,"token 38");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:500:2: ( '\\\\begin' '{' 'tikzpicture' '}' -> ^( IM_STARTTAG '\\\\begin' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:500:4: '\\\\begin' '{' 'tikzpicture' '}'
            {
            	string_literal236=(IToken)Match(input,38,FOLLOW_38_in_tikzpicture_start2580); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_38.Add(string_literal236);

            	char_literal237=(IToken)Match(input,41,FOLLOW_41_in_tikzpicture_start2582); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(char_literal237);

            	string_literal238=(IToken)Match(input,85,FOLLOW_85_in_tikzpicture_start2584); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_85.Add(string_literal238);

            	char_literal239=(IToken)Match(input,42,FOLLOW_42_in_tikzpicture_start2586); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_42.Add(char_literal239);



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
            	// 500:36: -> ^( IM_STARTTAG '\\\\begin' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:500:39: ^( IM_STARTTAG '\\\\begin' )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:502:1: tikzpicture_end : '\\\\end' '{' 'tikzpicture' '}' -> ^( IM_ENDTAG '\\\\end' ) ;
    public simpletikzParser.tikzpicture_end_return tikzpicture_end() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_end_return retval = new simpletikzParser.tikzpicture_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal240 = null;
        IToken char_literal241 = null;
        IToken string_literal242 = null;
        IToken char_literal243 = null;

        object string_literal240_tree=null;
        object char_literal241_tree=null;
        object string_literal242_tree=null;
        object char_literal243_tree=null;
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_61 = new RewriteRuleTokenStream(adaptor,"token 61");
        RewriteRuleTokenStream stream_85 = new RewriteRuleTokenStream(adaptor,"token 85");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:503:2: ( '\\\\end' '{' 'tikzpicture' '}' -> ^( IM_ENDTAG '\\\\end' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:503:4: '\\\\end' '{' 'tikzpicture' '}'
            {
            	string_literal240=(IToken)Match(input,61,FOLLOW_61_in_tikzpicture_end2604); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_61.Add(string_literal240);

            	char_literal241=(IToken)Match(input,41,FOLLOW_41_in_tikzpicture_end2606); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(char_literal241);

            	string_literal242=(IToken)Match(input,85,FOLLOW_85_in_tikzpicture_end2608); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_85.Add(string_literal242);

            	char_literal243=(IToken)Match(input,42,FOLLOW_42_in_tikzpicture_end2610); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_42.Add(char_literal243);



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
            	// 503:34: -> ^( IM_ENDTAG '\\\\end' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:503:37: ^( IM_ENDTAG '\\\\end' )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:505:1: tikzscope_start : '\\\\begin' '{' 'scope' '}' -> ^( IM_STARTTAG '\\\\begin' ) ;
    public simpletikzParser.tikzscope_start_return tikzscope_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_start_return retval = new simpletikzParser.tikzscope_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal244 = null;
        IToken char_literal245 = null;
        IToken string_literal246 = null;
        IToken char_literal247 = null;

        object string_literal244_tree=null;
        object char_literal245_tree=null;
        object string_literal246_tree=null;
        object char_literal247_tree=null;
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_86 = new RewriteRuleTokenStream(adaptor,"token 86");
        RewriteRuleTokenStream stream_38 = new RewriteRuleTokenStream(adaptor,"token 38");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:506:2: ( '\\\\begin' '{' 'scope' '}' -> ^( IM_STARTTAG '\\\\begin' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:506:4: '\\\\begin' '{' 'scope' '}'
            {
            	string_literal244=(IToken)Match(input,38,FOLLOW_38_in_tikzscope_start2628); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_38.Add(string_literal244);

            	char_literal245=(IToken)Match(input,41,FOLLOW_41_in_tikzscope_start2630); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(char_literal245);

            	string_literal246=(IToken)Match(input,86,FOLLOW_86_in_tikzscope_start2632); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_86.Add(string_literal246);

            	char_literal247=(IToken)Match(input,42,FOLLOW_42_in_tikzscope_start2634); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_42.Add(char_literal247);



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
            	// 506:30: -> ^( IM_STARTTAG '\\\\begin' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:506:33: ^( IM_STARTTAG '\\\\begin' )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:508:1: tikzscope_end : '\\\\end' '{' 'scope' '}' -> ^( IM_ENDTAG '\\\\end' ) ;
    public simpletikzParser.tikzscope_end_return tikzscope_end() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_end_return retval = new simpletikzParser.tikzscope_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal248 = null;
        IToken char_literal249 = null;
        IToken string_literal250 = null;
        IToken char_literal251 = null;

        object string_literal248_tree=null;
        object char_literal249_tree=null;
        object string_literal250_tree=null;
        object char_literal251_tree=null;
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_86 = new RewriteRuleTokenStream(adaptor,"token 86");
        RewriteRuleTokenStream stream_61 = new RewriteRuleTokenStream(adaptor,"token 61");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:509:2: ( '\\\\end' '{' 'scope' '}' -> ^( IM_ENDTAG '\\\\end' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:509:4: '\\\\end' '{' 'scope' '}'
            {
            	string_literal248=(IToken)Match(input,61,FOLLOW_61_in_tikzscope_end2652); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_61.Add(string_literal248);

            	char_literal249=(IToken)Match(input,41,FOLLOW_41_in_tikzscope_end2654); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(char_literal249);

            	string_literal250=(IToken)Match(input,86,FOLLOW_86_in_tikzscope_end2656); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_86.Add(string_literal250);

            	char_literal251=(IToken)Match(input,42,FOLLOW_42_in_tikzscope_end2658); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_42.Add(char_literal251);



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
            	// 509:28: -> ^( IM_ENDTAG '\\\\end' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:509:31: ^( IM_ENDTAG '\\\\end' )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:511:1: path_start : path_start_tag -> ^( IM_STARTTAG path_start_tag ) ;
    public simpletikzParser.path_start_return path_start() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_return retval = new simpletikzParser.path_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.path_start_tag_return path_start_tag252 = default(simpletikzParser.path_start_tag_return);


        RewriteRuleSubtreeStream stream_path_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule path_start_tag");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:512:2: ( path_start_tag -> ^( IM_STARTTAG path_start_tag ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:512:4: path_start_tag
            {
            	PushFollow(FOLLOW_path_start_tag_in_path_start2677);
            	path_start_tag252 = path_start_tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_path_start_tag.Add(path_start_tag252.Tree);


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
            	// 512:19: -> ^( IM_STARTTAG path_start_tag )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:512:22: ^( IM_STARTTAG path_start_tag )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:514:1: node_start : node_start_tag -> ^( IM_STARTTAG node_start_tag ) ;
    public simpletikzParser.node_start_return node_start() // throws RecognitionException [1]
    {   
        simpletikzParser.node_start_return retval = new simpletikzParser.node_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.node_start_tag_return node_start_tag253 = default(simpletikzParser.node_start_tag_return);


        RewriteRuleSubtreeStream stream_node_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule node_start_tag");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:515:2: ( node_start_tag -> ^( IM_STARTTAG node_start_tag ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:515:4: node_start_tag
            {
            	PushFollow(FOLLOW_node_start_tag_in_node_start2695);
            	node_start_tag253 = node_start_tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_node_start_tag.Add(node_start_tag253.Tree);


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
            	// 515:19: -> ^( IM_STARTTAG node_start_tag )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:515:22: ^( IM_STARTTAG node_start_tag )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:517:1: matrix_start : matrix_start_tag -> ^( IM_STARTTAG matrix_start_tag ) ;
    public simpletikzParser.matrix_start_return matrix_start() // throws RecognitionException [1]
    {   
        simpletikzParser.matrix_start_return retval = new simpletikzParser.matrix_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.matrix_start_tag_return matrix_start_tag254 = default(simpletikzParser.matrix_start_tag_return);


        RewriteRuleSubtreeStream stream_matrix_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule matrix_start_tag");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:518:2: ( matrix_start_tag -> ^( IM_STARTTAG matrix_start_tag ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:518:4: matrix_start_tag
            {
            	PushFollow(FOLLOW_matrix_start_tag_in_matrix_start2713);
            	matrix_start_tag254 = matrix_start_tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_matrix_start_tag.Add(matrix_start_tag254.Tree);


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
            	// 518:21: -> ^( IM_STARTTAG matrix_start_tag )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:518:24: ^( IM_STARTTAG matrix_start_tag )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:520:1: node_start_tag : '\\\\node' ;
    public simpletikzParser.node_start_tag_return node_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.node_start_tag_return retval = new simpletikzParser.node_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal255 = null;

        object string_literal255_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:521:2: ( '\\\\node' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:521:4: '\\\\node'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal255=(IToken)Match(input,62,FOLLOW_62_in_node_start_tag2731); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal255_tree = (object)adaptor.Create(string_literal255);
            		adaptor.AddChild(root_0, string_literal255_tree);
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:523:1: matrix_start_tag : '\\\\matrix' ;
    public simpletikzParser.matrix_start_tag_return matrix_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.matrix_start_tag_return retval = new simpletikzParser.matrix_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal256 = null;

        object string_literal256_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:524:2: ( '\\\\matrix' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:524:4: '\\\\matrix'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal256=(IToken)Match(input,63,FOLLOW_63_in_matrix_start_tag2741); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal256_tree = (object)adaptor.Create(string_literal256);
            		adaptor.AddChild(root_0, string_literal256_tree);
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:526:1: coordinate_start : '\\\\coordinate' -> ^( IM_STARTTAG '\\\\coordinate' ) ;
    public simpletikzParser.coordinate_start_return coordinate_start() // throws RecognitionException [1]
    {   
        simpletikzParser.coordinate_start_return retval = new simpletikzParser.coordinate_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal257 = null;

        object string_literal257_tree=null;
        RewriteRuleTokenStream stream_64 = new RewriteRuleTokenStream(adaptor,"token 64");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:527:2: ( '\\\\coordinate' -> ^( IM_STARTTAG '\\\\coordinate' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:527:4: '\\\\coordinate'
            {
            	string_literal257=(IToken)Match(input,64,FOLLOW_64_in_coordinate_start2751); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_64.Add(string_literal257);



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
            	// 527:19: -> ^( IM_STARTTAG '\\\\coordinate' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:527:22: ^( IM_STARTTAG '\\\\coordinate' )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:529:1: path_start_tag : ( '\\\\draw' | '\\\\fill' | '\\\\path' | '\\\\clip' );
    public simpletikzParser.path_start_tag_return path_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_tag_return retval = new simpletikzParser.path_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set258 = null;

        object set258_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:530:2: ( '\\\\draw' | '\\\\fill' | '\\\\path' | '\\\\clip' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set258 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 65 && input.LA(1) <= 68) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set258));
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
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:337:8: ( tikzcoordinate_core3 )
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:337:9: tikzcoordinate_core3
        {
        	PushFollow(FOLLOW_tikzcoordinate_core3_in_synpred1_simpletikz1665);
        	tikzcoordinate_core3();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred1_simpletikz"

    // $ANTLR start "synpred2_simpletikz"
    public void synpred2_simpletikz_fragment() {
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:338:12: ( tikzcoordinate_core2 )
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:338:13: tikzcoordinate_core2
        {
        	PushFollow(FOLLOW_tikzcoordinate_core2_in_synpred2_simpletikz1684);
        	tikzcoordinate_core2();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred2_simpletikz"

    // $ANTLR start "synpred3_simpletikz"
    public void synpred3_simpletikz_fragment() {
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:339:12: ( tikzcoordinate_core1 )
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:339:13: tikzcoordinate_core1
        {
        	PushFollow(FOLLOW_tikzcoordinate_core1_in_synpred3_simpletikz1704);
        	tikzcoordinate_core1();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred3_simpletikz"

    // $ANTLR start "synpred4_simpletikz"
    public void synpred4_simpletikz_fragment() {
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:348:21: ( tikzcoordinate_core3 )
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:348:22: tikzcoordinate_core3
        {
        	PushFollow(FOLLOW_tikzcoordinate_core3_in_synpred4_simpletikz1789);
        	tikzcoordinate_core3();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred4_simpletikz"

    // $ANTLR start "synpred5_simpletikz"
    public void synpred5_simpletikz_fragment() {
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:349:12: ( tikzcoordinate_core2 )
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:349:13: tikzcoordinate_core2
        {
        	PushFollow(FOLLOW_tikzcoordinate_core2_in_synpred5_simpletikz1808);
        	tikzcoordinate_core2();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred5_simpletikz"

    // $ANTLR start "synpred6_simpletikz"
    public void synpred6_simpletikz_fragment() {
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:350:12: ( tikzcoordinate_core1 )
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:350:13: tikzcoordinate_core1
        {
        	PushFollow(FOLLOW_tikzcoordinate_core1_in_synpred6_simpletikz1828);
        	tikzcoordinate_core1();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred6_simpletikz"

    // $ANTLR start "synpred7_simpletikz"
    public void synpred7_simpletikz_fragment() {
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:397:28: ( size )
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:397:29: size
        {
        	PushFollow(FOLLOW_size_in_synpred7_simpletikz2110);
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
   	protected DFA27 dfa27;
   	protected DFA28 dfa28;
   	protected DFA40 dfa40;
   	protected DFA44 dfa44;
   	protected DFA46 dfa46;
   	protected DFA53 dfa53;
   	protected DFA59 dfa59;
	private void InitializeCyclicDFAs()
	{
    	this.dfa9 = new DFA9(this);
    	this.dfa14 = new DFA14(this);
    	this.dfa27 = new DFA27(this);
    	this.dfa28 = new DFA28(this);
    	this.dfa40 = new DFA40(this);
    	this.dfa44 = new DFA44(this);
    	this.dfa46 = new DFA46(this);
    	this.dfa53 = new DFA53(this);
    	this.dfa59 = new DFA59(this);
	    this.dfa44.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA44_SpecialStateTransition);
	    this.dfa46.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA46_SpecialStateTransition);
	    this.dfa53.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA53_SpecialStateTransition);
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
        "\x23\uffff";
    const string DFA14_eofS =
        "\x23\uffff";
    const string DFA14_minS =
        "\x01\x04\x01\x2a\x01\x04\x01\uffff\x01\x2a\x02\uffff\x01\x04\x01"+
        "\uffff\x0c\x04\x01\uffff\x0d\x04";
    const string DFA14_maxS =
        "\x01\x56\x01\x3c\x01\x56\x01\uffff\x01\x35\x02\uffff\x01\x56\x01"+
        "\uffff\x0c\x56\x01\uffff\x0d\x56";
    const string DFA14_acceptS =
        "\x03\uffff\x01\x04\x01\uffff\x01\x02\x01\x01\x01\uffff\x01\x05"+
        "\x0c\uffff\x01\x03\x0d\uffff";
    const string DFA14_specialS =
        "\x23\uffff}>";
    static readonly string[] DFA14_transitionS = {
            "\x19\x03\x02\x01\x0a\x03\x01\x02\x02\uffff\x01\x03\x04\uffff"+
            "\x01\x03\x05\uffff\x20\x03",
            "\x01\x05\x02\uffff\x01\x05\x01\x06\x06\uffff\x01\x05\x01\uffff"+
            "\x06\x04",
            "\x2e\x08\x01\x07\x1e\x08\x02\x09\x04\x08",
            "",
            "\x01\x05\x02\uffff\x01\x05\x01\x06\x06\uffff\x01\x05",
            "",
            "",
            "\x19\x0b\x02\x0a\x0a\x0b\x01\x0c\x02\x08\x01\x0b\x04\x08\x01"+
            "\x0b\x05\x08\x20\x0b",
            "",
            "\x2e\x08\x01\x0d\x24\x08",
            "\x25\x0b\x03\x08\x01\x0b\x02\x10\x02\x08\x01\x0b\x01\x08\x01"+
            "\x0e\x03\x08\x06\x0f\x1a\x0b",
            "\x25\x0b\x03\x08\x01\x0b\x02\x11\x02\x08\x01\x0b\x01\x08\x01"+
            "\x0e\x03\x08\x20\x0b",
            "\x25\x12\x03\x08\x01\x12\x04\x08\x01\x12\x05\x08\x20\x12",
            "\x19\x14\x02\x13\x0a\x14\x01\x0c\x02\x08\x01\x14\x04\x08\x01"+
            "\x14\x05\x08\x20\x14",
            "\x26\x08\x01\x15\x2c\x08",
            "\x25\x0b\x03\x08\x01\x0b\x02\x10\x02\x08\x01\x0b\x01\x08\x01"+
            "\x0e\x03\x08\x20\x0b",
            "\x19\x17\x02\x16\x0a\x17\x01\x18\x02\x08\x01\x17\x04\x08\x01"+
            "\x17\x05\x08\x20\x17",
            "\x25\x17\x01\x18\x02\x08\x01\x17\x04\x08\x01\x17\x05\x08\x20"+
            "\x17",
            "\x25\x12\x01\x08\x01\x19\x01\x08\x01\x12\x04\x08\x01\x12\x05"+
            "\x08\x20\x12",
            "\x25\x14\x03\x08\x01\x14\x02\x10\x02\x08\x01\x14\x05\x08\x06"+
            "\x1a\x1a\x14",
            "\x25\x14\x03\x08\x01\x14\x02\x11\x02\x08\x01\x14\x05\x08\x20"+
            "\x14",
            "",
            "\x25\x17\x03\x08\x01\x17\x04\x08\x01\x17\x01\x08\x01\x1b\x03"+
            "\x08\x06\x1c\x1a\x17",
            "\x25\x17\x03\x08\x01\x17\x04\x08\x01\x17\x01\x08\x01\x1d\x03"+
            "\x08\x20\x17",
            "\x25\x1e\x03\x08\x01\x1e\x04\x08\x01\x1e\x05\x08\x20\x1e",
            "\x29\x08\x02\x1f\x28\x08",
            "\x25\x14\x03\x08\x01\x14\x02\x10\x02\x08\x01\x14\x05\x08\x20"+
            "\x14",
            "\x26\x08\x01\x15\x2c\x08",
            "\x25\x17\x03\x08\x01\x17\x04\x08\x01\x17\x01\x08\x01\x1b\x03"+
            "\x08\x20\x17",
            "\x26\x08\x01\x15\x2c\x08",
            "\x25\x1e\x01\x08\x01\x20\x01\x08\x01\x1e\x04\x08\x01\x1e\x05"+
            "\x08\x20\x1e",
            "\x25\x21\x01\x18\x02\x08\x01\x21\x04\x08\x01\x21\x05\x08\x20"+
            "\x21",
            "\x2f\x08\x01\x22\x23\x08",
            "\x25\x21\x03\x08\x01\x21\x04\x08\x01\x21\x01\x08\x01\x22\x03"+
            "\x08\x20\x21",
            "\x26\x08\x01\x15\x2c\x08"
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

    const string DFA27_eotS =
        "\x0d\uffff";
    const string DFA27_eofS =
        "\x0d\uffff";
    const string DFA27_minS =
        "\x01\x04\x01\x29\x08\uffff\x01\x1c\x02\uffff";
    const string DFA27_maxS =
        "\x01\x56\x01\x29\x08\uffff\x01\x56\x02\uffff";
    const string DFA27_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07\x01"+
        "\x09\x01\x0a\x01\uffff\x01\x01\x01\x08";
    const string DFA27_specialS =
        "\x0d\uffff}>";
    static readonly string[] DFA27_transitionS = {
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
            get { return "242:4: ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr )"; }
        }

    }

    const string DFA28_eotS =
        "\x10\uffff";
    const string DFA28_eofS =
        "\x10\uffff";
    const string DFA28_minS =
        "\x01\x04\x02\x29\x07\uffff\x02\x1c\x04\uffff";
    const string DFA28_maxS =
        "\x01\x56\x02\x29\x07\uffff\x02\x56\x04\uffff";
    const string DFA28_acceptS =
        "\x03\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07\x01"+
        "\x0a\x02\uffff\x01\x0b\x01\x09\x01\x01\x01\x08";
    const string DFA28_specialS =
        "\x10\uffff}>";
    static readonly string[] DFA28_transitionS = {
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
            get { return "()* loopback of 243:3: ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*"; }
        }

    }

    const string DFA40_eotS =
        "\x4b\uffff";
    const string DFA40_eofS =
        "\x4b\uffff";
    const string DFA40_minS =
        "\x01\x1c\x01\uffff\x01\x04\x09\uffff\x0d\x04\x01\uffff\x17\x04"+
        "\x01\x1c\x03\x04\x01\uffff\x10\x04\x01\x1c\x04\x04";
    const string DFA40_maxS =
        "\x01\x53\x01\uffff\x01\x56\x09\uffff\x0d\x56\x01\uffff\x17\x56"+
        "\x01\x53\x03\x56\x01\uffff\x10\x56\x01\x53\x04\x56";
    const string DFA40_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x01\x08\x01\x0a\x01\x09\x0d\uffff\x01\x02\x1b\uffff"+
        "\x01\x02\x15\uffff";
    const string DFA40_specialS =
        "\x4b\uffff}>";
    static readonly string[] DFA40_transitionS = {
            "\x01\x0a\x0c\uffff\x01\x09\x08\uffff\x01\x02\x01\uffff\x01"+
            "\x01\x12\uffff\x01\x06\x01\x05\x01\uffff\x02\x07\x01\x08\x04"+
            "\x0a\x02\x03\x01\x04",
            "",
            "\x18\x03\x01\x14\x0c\x03\x01\x13\x02\uffff\x01\x03\x04\uffff"+
            "\x01\x03\x03\x0b\x02\uffff\x10\x03\x01\x0f\x01\x0e\x01\x03\x01"+
            "\x10\x01\x11\x01\x12\x04\x14\x02\x0c\x01\x0d\x03\x03",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x25\x03\x03\uffff\x03\x03\x02\uffff\x01\x03\x01\x0b\x01\x03"+
            "\x03\uffff\x20\x03",
            "\x25\x03\x03\uffff\x03\x03\x02\uffff\x01\x03\x01\uffff\x01"+
            "\x03\x03\uffff\x1d\x03\x01\x15\x02\x03",
            "\x25\x03\x01\x0b\x02\uffff\x03\x03\x02\uffff\x01\x03\x01\x0b"+
            "\x01\x03\x01\x0b\x02\uffff\x12\x03\x01\x16\x0d\x03",
            "\x18\x19\x01\x14\x0c\x19\x01\x0b\x02\uffff\x01\x19\x01\x18"+
            "\x01\x19\x02\uffff\x01\x19\x01\x0b\x01\x19\x01\x0b\x02\uffff"+
            "\x10\x19\x01\x0f\x01\x0e\x01\x17\x01\x10\x01\x11\x01\x12\x04"+
            "\x14\x02\x0c\x01\x0d\x03\x19",
            "\x18\x19\x01\x14\x0c\x19\x01\x0b\x02\uffff\x01\x19\x01\x18"+
            "\x01\x19\x02\uffff\x01\x19\x01\x0b\x01\x19\x01\x0b\x02\uffff"+
            "\x10\x19\x01\x0f\x01\x0e\x01\x19\x01\x10\x01\x11\x01\x12\x04"+
            "\x14\x02\x0c\x01\x0d\x03\x19",
            "\x18\x19\x01\x14\x0c\x19\x01\x0b\x02\uffff\x01\x19\x01\x18"+
            "\x01\x19\x02\uffff\x01\x19\x01\x0b\x01\x19\x01\x0b\x02\uffff"+
            "\x10\x19\x01\x0f\x01\x0e\x01\x19\x01\x10\x01\x11\x01\x12\x04"+
            "\x14\x02\x0c\x01\x0d\x03\x19",
            "\x18\x19\x01\x14\x0c\x19\x01\x0b\x02\uffff\x01\x19\x01\x18"+
            "\x01\x19\x02\uffff\x01\x19\x01\x0b\x01\x19\x01\x0b\x02\uffff"+
            "\x10\x19\x01\x0f\x01\x0e\x01\x19\x01\x10\x01\x11\x01\x12\x04"+
            "\x14\x02\x0c\x01\x0d\x03\x19",
            "\x18\x19\x01\x21\x0c\x19\x02\x0b\x01\uffff\x01\x19\x04\uffff"+
            "\x01\x19\x01\x0b\x01\uffff\x01\x0b\x02\uffff\x10\x19\x01\x1d"+
            "\x01\x1c\x01\x19\x01\x1e\x01\x1f\x01\x20\x04\x21\x02\x1a\x01"+
            "\x1b\x03\x19",
            "\x18\x19\x01\x14\x0c\x19\x01\x0b\x02\uffff\x01\x19\x01\x18"+
            "\x01\x19\x02\uffff\x01\x19\x01\x0b\x01\x19\x01\x0b\x02\uffff"+
            "\x10\x19\x01\x0f\x01\x0e\x01\x19\x01\x10\x01\x11\x01\x12\x04"+
            "\x14\x02\x0c\x01\x0d\x03\x19",
            "\x25\x19\x03\uffff\x03\x19\x02\uffff\x01\x19\x01\x0b\x01\x19"+
            "\x03\uffff\x1a\x19\x02\x22\x04\x19",
            "\x25\x19\x03\uffff\x03\x19\x02\uffff\x01\x19\x01\x0b\x01\x19"+
            "\x03\uffff\x1a\x19\x02\x23\x04\x19",
            "\x25\x19\x03\uffff\x03\x19\x02\uffff\x01\x19\x01\x0b\x01\x19"+
            "\x03\uffff\x1a\x19\x02\x24\x04\x19",
            "\x18\x19\x01\x2d\x0c\x19\x01\x2c\x02\uffff\x01\x19\x04\uffff"+
            "\x01\x19\x03\x0b\x02\uffff\x10\x19\x01\x28\x01\x27\x01\x19\x01"+
            "\x29\x01\x2a\x01\x2b\x04\x2d\x02\x25\x01\x26\x03\x19",
            "",
            "\x25\x19\x01\uffff\x01\x19\x01\uffff\x01\x19\x04\uffff\x01"+
            "\x19\x01\x0b\x04\uffff\x20\x19",
            "\x25\x19\x01\uffff\x01\x19\x01\uffff\x01\x19\x04\uffff\x01"+
            "\x19\x05\uffff\x1d\x19\x01\x2e\x02\x19",
            "\x25\x19\x01\x0b\x01\x19\x01\uffff\x01\x19\x04\uffff\x01\x19"+
            "\x01\x0b\x01\uffff\x01\x0b\x02\uffff\x12\x19\x01\x2f\x0d\x19",
            "\x18\x19\x01\x21\x0c\x19\x01\x0b\x01\x31\x01\uffff\x01\x19"+
            "\x01\x0b\x03\uffff\x01\x19\x01\x0b\x01\uffff\x01\x0b\x02\uffff"+
            "\x10\x19\x01\x1d\x01\x1c\x01\x30\x01\x1e\x01\x1f\x01\x20\x04"+
            "\x21\x02\x1a\x01\x1b\x03\x19",
            "\x18\x19\x01\x21\x0c\x19\x01\x0b\x01\x31\x01\uffff\x01\x19"+
            "\x01\x0b\x03\uffff\x01\x19\x01\x0b\x01\uffff\x01\x0b\x02\uffff"+
            "\x10\x19\x01\x1d\x01\x1c\x01\x19\x01\x1e\x01\x1f\x01\x20\x04"+
            "\x21\x02\x1a\x01\x1b\x03\x19",
            "\x18\x19\x01\x21\x0c\x19\x01\x0b\x01\x31\x01\uffff\x01\x19"+
            "\x01\x0b\x03\uffff\x01\x19\x01\x0b\x01\uffff\x01\x0b\x02\uffff"+
            "\x10\x19\x01\x1d\x01\x1c\x01\x19\x01\x1e\x01\x1f\x01\x20\x04"+
            "\x21\x02\x1a\x01\x1b\x03\x19",
            "\x18\x19\x01\x21\x0c\x19\x01\x0b\x01\x31\x01\uffff\x01\x19"+
            "\x01\x0b\x03\uffff\x01\x19\x01\x0b\x01\uffff\x01\x0b\x02\uffff"+
            "\x10\x19\x01\x1d\x01\x1c\x01\x19\x01\x1e\x01\x1f\x01\x20\x04"+
            "\x21\x02\x1a\x01\x1b\x03\x19",
            "\x18\x19\x01\x21\x0c\x19\x01\x0b\x01\x31\x01\uffff\x01\x19"+
            "\x01\x0b\x03\uffff\x01\x19\x01\x0b\x01\uffff\x01\x0b\x02\uffff"+
            "\x10\x19\x01\x1d\x01\x1c\x01\x19\x01\x1e\x01\x1f\x01\x20\x04"+
            "\x21\x02\x1a\x01\x1b\x03\x19",
            "\x25\x19\x03\uffff\x03\x19\x02\uffff\x01\x19\x01\x0b\x01\x19"+
            "\x03\uffff\x20\x19",
            "\x25\x19\x03\uffff\x03\x19\x02\uffff\x01\x19\x01\x0b\x01\x19"+
            "\x03\uffff\x20\x19",
            "\x25\x19\x03\uffff\x03\x19\x02\uffff\x01\x19\x01\x0b\x01\x19"+
            "\x03\uffff\x20\x19",
            "\x25\x19\x03\uffff\x01\x19\x04\uffff\x01\x19\x01\x0b\x01\x19"+
            "\x03\uffff\x20\x19",
            "\x25\x19\x03\uffff\x01\x19\x04\uffff\x01\x19\x01\uffff\x01"+
            "\x19\x03\uffff\x1d\x19\x01\x32\x02\x19",
            "\x25\x19\x01\x0b\x02\uffff\x01\x19\x04\uffff\x01\x19\x01\x0b"+
            "\x01\x19\x01\x0b\x02\uffff\x12\x19\x01\x33\x0d\x19",
            "\x18\x35\x01\x2d\x0c\x35\x01\x0b\x02\uffff\x01\x35\x01\x0b"+
            "\x03\uffff\x01\x35\x01\x0b\x01\x35\x01\x0b\x02\uffff\x10\x35"+
            "\x01\x28\x01\x27\x01\x34\x01\x29\x01\x2a\x01\x2b\x04\x2d\x02"+
            "\x25\x01\x26\x03\x35",
            "\x18\x35\x01\x2d\x0c\x35\x01\x0b\x02\uffff\x01\x35\x01\x0b"+
            "\x03\uffff\x01\x35\x01\x0b\x01\x35\x01\x0b\x02\uffff\x10\x35"+
            "\x01\x28\x01\x27\x01\x35\x01\x29\x01\x2a\x01\x2b\x04\x2d\x02"+
            "\x25\x01\x26\x03\x35",
            "\x18\x35\x01\x2d\x0c\x35\x01\x0b\x02\uffff\x01\x35\x01\x0b"+
            "\x03\uffff\x01\x35\x01\x0b\x01\x35\x01\x0b\x02\uffff\x10\x35"+
            "\x01\x28\x01\x27\x01\x35\x01\x29\x01\x2a\x01\x2b\x04\x2d\x02"+
            "\x25\x01\x26\x03\x35",
            "\x18\x35\x01\x2d\x0c\x35\x01\x0b\x02\uffff\x01\x35\x01\x0b"+
            "\x03\uffff\x01\x35\x01\x0b\x01\x35\x01\x0b\x02\uffff\x10\x35"+
            "\x01\x28\x01\x27\x01\x35\x01\x29\x01\x2a\x01\x2b\x04\x2d\x02"+
            "\x25\x01\x26\x03\x35",
            "\x18\x35\x01\x3d\x0c\x35\x02\x0b\x01\uffff\x01\x35\x04\uffff"+
            "\x01\x35\x01\x0b\x01\uffff\x01\x0b\x02\uffff\x10\x35\x01\x39"+
            "\x01\x38\x01\x35\x01\x3a\x01\x3b\x01\x3c\x04\x3d\x02\x36\x01"+
            "\x37\x03\x35",
            "\x18\x35\x01\x2d\x0c\x35\x01\x0b\x02\uffff\x01\x35\x01\x0b"+
            "\x03\uffff\x01\x35\x01\x0b\x01\x35\x01\x0b\x02\uffff\x10\x35"+
            "\x01\x28\x01\x27\x01\x35\x01\x29\x01\x2a\x01\x2b\x04\x2d\x02"+
            "\x25\x01\x26\x03\x35",
            "\x25\x35\x01\uffff\x01\x35\x01\uffff\x01\x35\x04\uffff\x01"+
            "\x35\x01\x0b\x04\uffff\x1a\x35\x02\x3e\x04\x35",
            "\x25\x35\x01\uffff\x01\x35\x01\uffff\x01\x35\x04\uffff\x01"+
            "\x35\x01\x0b\x04\uffff\x1a\x35\x02\x3f\x04\x35",
            "\x25\x35\x01\uffff\x01\x35\x01\uffff\x01\x35\x04\uffff\x01"+
            "\x35\x01\x0b\x04\uffff\x1a\x35\x02\x40\x04\x35",
            "\x01\x0b\x0c\uffff\x01\x0b\x03\uffff\x01\x18\x01\x35\x03\uffff"+
            "\x03\x0b\x12\uffff\x02\x0b\x01\uffff\x0a\x0b",
            "\x25\x35\x03\uffff\x01\x35\x04\uffff\x01\x35\x01\x0b\x01\x35"+
            "\x03\uffff\x1a\x35\x02\x41\x04\x35",
            "\x25\x35\x03\uffff\x01\x35\x04\uffff\x01\x35\x01\x0b\x01\x35"+
            "\x03\uffff\x1a\x35\x02\x42\x04\x35",
            "\x25\x35\x03\uffff\x01\x35\x04\uffff\x01\x35\x01\x0b\x01\x35"+
            "\x03\uffff\x1a\x35\x02\x43\x04\x35",
            "",
            "\x25\x35\x01\uffff\x01\x35\x01\uffff\x01\x35\x04\uffff\x01"+
            "\x35\x01\x0b\x04\uffff\x20\x35",
            "\x25\x35\x01\uffff\x01\x35\x01\uffff\x01\x35\x04\uffff\x01"+
            "\x35\x05\uffff\x1d\x35\x01\x44\x02\x35",
            "\x25\x35\x01\x0b\x01\x35\x01\uffff\x01\x35\x04\uffff\x01\x35"+
            "\x01\x0b\x01\uffff\x01\x0b\x02\uffff\x12\x35\x01\x45\x0d\x35",
            "\x18\x35\x01\x3d\x0c\x35\x01\x0b\x01\x46\x01\uffff\x01\x35"+
            "\x01\x0b\x03\uffff\x01\x35\x01\x0b\x01\uffff\x01\x0b\x02\uffff"+
            "\x10\x35\x01\x39\x01\x38\x01\x47\x01\x3a\x01\x3b\x01\x3c\x04"+
            "\x3d\x02\x36\x01\x37\x03\x35",
            "\x18\x35\x01\x3d\x0c\x35\x01\x0b\x01\x46\x01\uffff\x01\x35"+
            "\x01\x0b\x03\uffff\x01\x35\x01\x0b\x01\uffff\x01\x0b\x02\uffff"+
            "\x10\x35\x01\x39\x01\x38\x01\x35\x01\x3a\x01\x3b\x01\x3c\x04"+
            "\x3d\x02\x36\x01\x37\x03\x35",
            "\x18\x35\x01\x3d\x0c\x35\x01\x0b\x01\x46\x01\uffff\x01\x35"+
            "\x01\x0b\x03\uffff\x01\x35\x01\x0b\x01\uffff\x01\x0b\x02\uffff"+
            "\x10\x35\x01\x39\x01\x38\x01\x35\x01\x3a\x01\x3b\x01\x3c\x04"+
            "\x3d\x02\x36\x01\x37\x03\x35",
            "\x18\x35\x01\x3d\x0c\x35\x01\x0b\x01\x46\x01\uffff\x01\x35"+
            "\x01\x0b\x03\uffff\x01\x35\x01\x0b\x01\uffff\x01\x0b\x02\uffff"+
            "\x10\x35\x01\x39\x01\x38\x01\x35\x01\x3a\x01\x3b\x01\x3c\x04"+
            "\x3d\x02\x36\x01\x37\x03\x35",
            "\x18\x35\x01\x3d\x0c\x35\x01\x0b\x01\x46\x01\uffff\x01\x35"+
            "\x01\x0b\x03\uffff\x01\x35\x01\x0b\x01\uffff\x01\x0b\x02\uffff"+
            "\x10\x35\x01\x39\x01\x38\x01\x35\x01\x3a\x01\x3b\x01\x3c\x04"+
            "\x3d\x02\x36\x01\x37\x03\x35",
            "\x25\x35\x01\uffff\x01\x35\x01\uffff\x01\x35\x04\uffff\x01"+
            "\x35\x01\x0b\x04\uffff\x20\x35",
            "\x25\x35\x01\uffff\x01\x35\x01\uffff\x01\x35\x04\uffff\x01"+
            "\x35\x01\x0b\x04\uffff\x20\x35",
            "\x25\x35\x01\uffff\x01\x35\x01\uffff\x01\x35\x04\uffff\x01"+
            "\x35\x01\x0b\x04\uffff\x20\x35",
            "\x25\x35\x03\uffff\x01\x35\x04\uffff\x01\x35\x01\x0b\x01\x35"+
            "\x03\uffff\x20\x35",
            "\x25\x35\x03\uffff\x01\x35\x04\uffff\x01\x35\x01\x0b\x01\x35"+
            "\x03\uffff\x20\x35",
            "\x25\x35\x03\uffff\x01\x35\x04\uffff\x01\x35\x01\x0b\x01\x35"+
            "\x03\uffff\x20\x35",
            "\x25\x35\x01\uffff\x01\x35\x01\uffff\x01\x35\x04\uffff\x01"+
            "\x35\x01\x0b\x04\uffff\x1a\x35\x02\x48\x04\x35",
            "\x25\x35\x01\uffff\x01\x35\x01\uffff\x01\x35\x04\uffff\x01"+
            "\x35\x01\x0b\x04\uffff\x1a\x35\x02\x49\x04\x35",
            "\x01\x0b\x0c\uffff\x01\x0b\x03\uffff\x01\x0b\x04\uffff\x01"+
            "\x0b\x01\x35\x01\x0b\x12\uffff\x02\x0b\x01\uffff\x0a\x0b",
            "\x25\x35\x01\uffff\x01\x35\x01\uffff\x01\x35\x04\uffff\x01"+
            "\x35\x01\x0b\x04\uffff\x1a\x35\x02\x4a\x04\x35",
            "\x25\x35\x01\uffff\x01\x35\x01\uffff\x01\x35\x04\uffff\x01"+
            "\x35\x01\x0b\x04\uffff\x20\x35",
            "\x25\x35\x01\uffff\x01\x35\x01\uffff\x01\x35\x04\uffff\x01"+
            "\x35\x01\x0b\x04\uffff\x20\x35",
            "\x25\x35\x01\uffff\x01\x35\x01\uffff\x01\x35\x04\uffff\x01"+
            "\x35\x01\x0b\x04\uffff\x20\x35"
    };

    static readonly short[] DFA40_eot = DFA.UnpackEncodedString(DFA40_eotS);
    static readonly short[] DFA40_eof = DFA.UnpackEncodedString(DFA40_eofS);
    static readonly char[] DFA40_min = DFA.UnpackEncodedStringToUnsignedChars(DFA40_minS);
    static readonly char[] DFA40_max = DFA.UnpackEncodedStringToUnsignedChars(DFA40_maxS);
    static readonly short[] DFA40_accept = DFA.UnpackEncodedString(DFA40_acceptS);
    static readonly short[] DFA40_special = DFA.UnpackEncodedString(DFA40_specialS);
    static readonly short[][] DFA40_transition = DFA.UnpackEncodedStringArray(DFA40_transitionS);

    protected class DFA40 : DFA
    {
        public DFA40(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 40;
            this.eot = DFA40_eot;
            this.eof = DFA40_eof;
            this.min = DFA40_min;
            this.max = DFA40_max;
            this.accept = DFA40_accept;
            this.special = DFA40_special;
            this.transition = DFA40_transition;

        }

        override public string Description
        {
            get { return "308:1: tikzpath_element_single : ( tikz_options | coord | controls | tikznode_int | tikzcoordinate_int | circle | arc | roundbr_start ( tikzpath_element )* roundbr_end -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end ) | '(' ( tikzpath_element )* ')' -> ^( IM_PATH '(' ( tikzpath_element )* ')' ) | edgeop );"; }
        }

    }

    const string DFA44_eotS =
        "\x11\uffff";
    const string DFA44_eofS =
        "\x11\uffff";
    const string DFA44_minS =
        "\x01\x1c\x03\x00\x0d\uffff";
    const string DFA44_maxS =
        "\x01\x53\x03\x00\x0d\uffff";
    const string DFA44_acceptS =
        "\x04\uffff\x01\x04\x09\uffff\x01\x01\x01\x02\x01\x03";
    const string DFA44_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x0d\uffff}>";
    static readonly string[] DFA44_transitionS = {
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

    static readonly short[] DFA44_eot = DFA.UnpackEncodedString(DFA44_eotS);
    static readonly short[] DFA44_eof = DFA.UnpackEncodedString(DFA44_eofS);
    static readonly char[] DFA44_min = DFA.UnpackEncodedStringToUnsignedChars(DFA44_minS);
    static readonly char[] DFA44_max = DFA.UnpackEncodedStringToUnsignedChars(DFA44_maxS);
    static readonly short[] DFA44_accept = DFA.UnpackEncodedString(DFA44_acceptS);
    static readonly short[] DFA44_special = DFA.UnpackEncodedString(DFA44_specialS);
    static readonly short[][] DFA44_transition = DFA.UnpackEncodedStringArray(DFA44_transitionS);

    protected class DFA44 : DFA
    {
        public DFA44(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 44;
            this.eot = DFA44_eot;
            this.eof = DFA44_eof;
            this.min = DFA44_min;
            this.max = DFA44_max;
            this.accept = DFA44_accept;
            this.special = DFA44_special;
            this.transition = DFA44_transition;

        }

        override public string Description
        {
            get { return "337:5: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?"; }
        }

    }


    protected internal int DFA44_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA44_1 = input.LA(1);

                   	 
                   	int index44_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_simpletikz()) ) { s = 14; }

                   	else if ( (synpred2_simpletikz()) ) { s = 15; }

                   	else if ( (synpred3_simpletikz()) ) { s = 16; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index44_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA44_2 = input.LA(1);

                   	 
                   	int index44_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_simpletikz()) ) { s = 14; }

                   	else if ( (synpred2_simpletikz()) ) { s = 15; }

                   	else if ( (synpred3_simpletikz()) ) { s = 16; }

                   	 
                   	input.Seek(index44_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA44_3 = input.LA(1);

                   	 
                   	int index44_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_simpletikz()) ) { s = 14; }

                   	else if ( (synpred2_simpletikz()) ) { s = 15; }

                   	else if ( (synpred3_simpletikz()) ) { s = 16; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index44_3);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae44 =
            new NoViableAltException(dfa.Description, 44, _s, input);
        dfa.Error(nvae44);
        throw nvae44;
    }
    const string DFA46_eotS =
        "\x16\uffff";
    const string DFA46_eofS =
        "\x16\uffff";
    const string DFA46_minS =
        "\x01\x1c\x03\x00\x12\uffff";
    const string DFA46_maxS =
        "\x01\x53\x03\x00\x12\uffff";
    const string DFA46_acceptS =
        "\x04\uffff\x01\x04\x0e\uffff\x01\x01\x01\x02\x01\x03";
    const string DFA46_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x12\uffff}>";
    static readonly string[] DFA46_transitionS = {
            "\x01\x04\x02\uffff\x01\x04\x09\uffff\x02\x04\x02\uffff\x01"+
            "\x04\x04\uffff\x01\x01\x01\x04\x01\x03\x01\uffff\x01\x04\x01"+
            "\uffff\x01\x04\x0e\uffff\x02\x04\x01\x02\x0a\x04",
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

    static readonly short[] DFA46_eot = DFA.UnpackEncodedString(DFA46_eotS);
    static readonly short[] DFA46_eof = DFA.UnpackEncodedString(DFA46_eofS);
    static readonly char[] DFA46_min = DFA.UnpackEncodedStringToUnsignedChars(DFA46_minS);
    static readonly char[] DFA46_max = DFA.UnpackEncodedStringToUnsignedChars(DFA46_maxS);
    static readonly short[] DFA46_accept = DFA.UnpackEncodedString(DFA46_acceptS);
    static readonly short[] DFA46_special = DFA.UnpackEncodedString(DFA46_specialS);
    static readonly short[][] DFA46_transition = DFA.UnpackEncodedStringArray(DFA46_transitionS);

    protected class DFA46 : DFA
    {
        public DFA46(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 46;
            this.eot = DFA46_eot;
            this.eof = DFA46_eof;
            this.min = DFA46_min;
            this.max = DFA46_max;
            this.accept = DFA46_accept;
            this.special = DFA46_special;
            this.transition = DFA46_transition;

        }

        override public string Description
        {
            get { return "348:18: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?"; }
        }

    }


    protected internal int DFA46_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA46_1 = input.LA(1);

                   	 
                   	int index46_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred4_simpletikz()) ) { s = 19; }

                   	else if ( (synpred5_simpletikz()) ) { s = 20; }

                   	else if ( (synpred6_simpletikz()) ) { s = 21; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index46_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA46_2 = input.LA(1);

                   	 
                   	int index46_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred4_simpletikz()) ) { s = 19; }

                   	else if ( (synpred5_simpletikz()) ) { s = 20; }

                   	else if ( (synpred6_simpletikz()) ) { s = 21; }

                   	 
                   	input.Seek(index46_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA46_3 = input.LA(1);

                   	 
                   	int index46_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred4_simpletikz()) ) { s = 19; }

                   	else if ( (synpred5_simpletikz()) ) { s = 20; }

                   	else if ( (synpred6_simpletikz()) ) { s = 21; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index46_3);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae46 =
            new NoViableAltException(dfa.Description, 46, _s, input);
        dfa.Error(nvae46);
        throw nvae46;
    }
    const string DFA53_eotS =
        "\x0a\uffff";
    const string DFA53_eofS =
        "\x0a\uffff";
    const string DFA53_minS =
        "\x01\x1c\x01\x04\x01\uffff\x01\x04\x01\x00\x02\x04\x01\uffff\x02"+
        "\x04";
    const string DFA53_maxS =
        "\x01\x53\x01\x56\x01\uffff\x01\x56\x01\x00\x02\x56\x01\uffff\x02"+
        "\x56";
    const string DFA53_acceptS =
        "\x02\uffff\x01\x02\x04\uffff\x01\x01\x02\uffff";
    const string DFA53_specialS =
        "\x04\uffff\x01\x00\x05\uffff}>";
    static readonly string[] DFA53_transitionS = {
            "\x01\x02\x02\uffff\x01\x02\x09\uffff\x02\x02\x02\uffff\x01"+
            "\x02\x04\uffff\x01\x01\x02\x02\x01\uffff\x01\x02\x01\uffff\x01"+
            "\x02\x0e\uffff\x02\x02\x01\uffff\x0a\x02",
            "\x19\x02\x02\x03\x0b\x02\x02\uffff\x01\x02\x04\uffff\x04\x02"+
            "\x02\uffff\x20\x02",
            "",
            "\x25\x02\x03\uffff\x03\x02\x02\uffff\x01\x02\x01\uffff\x01"+
            "\x04\x03\uffff\x06\x05\x09\x02\x01\x06\x10\x02",
            "\x01\uffff",
            "\x25\x02\x03\uffff\x03\x02\x02\uffff\x01\x02\x01\uffff\x01"+
            "\x04\x03\uffff\x0f\x02\x01\x06\x10\x02",
            "\x19\x02\x02\x08\x0a\x02\x03\uffff\x03\x02\x02\uffff\x01\x02"+
            "\x01\uffff\x01\x02\x03\uffff\x20\x02",
            "",
            "\x25\x02\x03\uffff\x03\x02\x02\uffff\x01\x02\x01\uffff\x01"+
            "\x04\x03\uffff\x06\x09\x1a\x02",
            "\x25\x02\x03\uffff\x03\x02\x02\uffff\x01\x02\x01\uffff\x01"+
            "\x04\x03\uffff\x20\x02"
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
            get { return "397:27: ( ( size )=> size )?"; }
        }

    }


    protected internal int DFA53_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA53_4 = input.LA(1);

                   	 
                   	int index53_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred7_simpletikz()) ) { s = 7; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index53_4);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae53 =
            new NoViableAltException(dfa.Description, 53, _s, input);
        dfa.Error(nvae53);
        throw nvae53;
    }
    const string DFA59_eotS =
        "\x0f\uffff";
    const string DFA59_eofS =
        "\x0f\uffff";
    const string DFA59_minS =
        "\x01\x32\x01\x04\x01\x32\x01\x04\x01\uffff\x04\x04\x01\uffff\x04"+
        "\x04\x01\uffff";
    const string DFA59_maxS =
        "\x01\x52\x01\x56\x01\x32\x01\x56\x01\uffff\x04\x56\x01\uffff\x04"+
        "\x56\x01\uffff";
    const string DFA59_acceptS =
        "\x04\uffff\x01\x03\x04\uffff\x01\x01\x04\uffff\x01\x02";
    const string DFA59_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA59_transitionS = {
            "\x01\x01\x1e\uffff\x02\x02",
            "\x19\x05\x02\x03\x0a\x05\x01\x04\x02\uffff\x01\x05\x04\uffff"+
            "\x01\x05\x05\uffff\x20\x05",
            "\x01\x06",
            "\x25\x05\x03\uffff\x01\x05\x02\x07\x02\uffff\x01\x05\x01\uffff"+
            "\x01\x09\x03\uffff\x06\x08\x1a\x05",
            "",
            "\x25\x05\x03\uffff\x01\x05\x02\x04\x02\uffff\x01\x05\x01\uffff"+
            "\x01\x09\x03\uffff\x20\x05",
            "\x19\x04\x02\x0a\x0b\x04\x02\uffff\x01\x04\x04\uffff\x01\x04"+
            "\x05\uffff\x20\x04",
            "\x19\x04\x02\x0b\x0b\x04\x02\uffff\x01\x04\x04\uffff\x01\x04"+
            "\x05\uffff\x20\x04",
            "\x25\x05\x03\uffff\x01\x05\x02\x07\x02\uffff\x01\x05\x01\uffff"+
            "\x01\x09\x03\uffff\x20\x05",
            "",
            "\x25\x04\x03\uffff\x01\x04\x02\x07\x02\uffff\x01\x04\x05\uffff"+
            "\x06\x0c\x1a\x04",
            "\x25\x04\x03\uffff\x01\x04\x04\uffff\x01\x04\x01\uffff\x01"+
            "\x0e\x03\uffff\x06\x0d\x1a\x04",
            "\x25\x04\x03\uffff\x01\x04\x02\x07\x02\uffff\x01\x04\x05\uffff"+
            "\x20\x04",
            "\x25\x04\x03\uffff\x01\x04\x04\uffff\x01\x04\x01\uffff\x01"+
            "\x0e\x03\uffff\x20\x04",
            ""
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
            get { return "411:1: coord : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) );"; }
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
    public static readonly BitSet FOLLOW_46_in_range651 = new BitSet(new ulong[]{0x0000000060000000UL});
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
    public static readonly BitSet FOLLOW_number_in_numberunit848 = new BitSet(new ulong[]{0x1F80000000000002UL});
    public static readonly BitSet FOLLOW_unit_in_numberunit850 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_number876 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unit0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_set_start_in_tikz_set931 = new BitSet(new ulong[]{0xFF8215FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_set934 = new BitSet(new ulong[]{0xFF8235FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_45_in_tikz_set937 = new BitSet(new ulong[]{0xFF8211FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_set939 = new BitSet(new ulong[]{0xFF8235FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_45_in_tikz_set943 = new BitSet(new ulong[]{0xFF8215FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_roundbr_end_in_tikz_set948 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzpicture_start_in_tikzpicture976 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpicture978 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzpicture981 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikzpicture_end_in_tikzpicture984 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody1014 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody1018 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_ext_in_tikzbody1022 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikzmatrix_ext_in_tikzbody1026 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikzcoordinate_ext_in_tikzbody1030 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody1034 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody1038 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody1042 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody1047 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_dontcare_body_nobr_in_tikzbody1052 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody1063 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody1067 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_ext_in_tikzbody1071 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikzmatrix_ext_in_tikzbody1075 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikzcoordinate_ext_in_tikzbody1079 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody1083 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody1087 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody1091 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody1096 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_dontcare_body_in_tikzbody1101 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body_nobr1118 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body1180 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_61_in_otherend1239 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_otherend1241 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_idd2_in_otherend1243 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_otherend1245 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzscope_start_in_tikzscope1272 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzscope1274 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzscope1277 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikzscope_end_in_tikzscope1280 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_in_tikzpath1335 = new BitSet(new ulong[]{0x0054020010000000UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath1337 = new BitSet(new ulong[]{0x0054020010000000UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzpath1340 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_in_tikzpath1359 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_69_in_tikzpath1361 = new BitSet(new ulong[]{0x0100000080000000UL});
    public static readonly BitSet FOLLOW_let_assignment_in_tikzpath1363 = new BitSet(new ulong[]{0x0100000080000000UL});
    public static readonly BitSet FOLLOW_56_in_tikzpath1366 = new BitSet(new ulong[]{0x0054020090000000UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_COMMAND_in_tikzpath1369 = new BitSet(new ulong[]{0xFF8213FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikzpath1371 = new BitSet(new ulong[]{0x0054020010000000UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath1375 = new BitSet(new ulong[]{0x0054020010000000UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzpath1378 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COMMAND_in_let_assignment1405 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_let_assignment1407 = new BitSet(new ulong[]{0x0014020010000002UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_let_assignment1409 = new BitSet(new ulong[]{0x0014020010000002UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_tikzpath_element_single_in_tikzpath_element1421 = new BitSet(new ulong[]{0x0000200000000002UL});
    public static readonly BitSet FOLLOW_45_in_tikzpath_element1423 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpath_element_single1440 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_in_tikzpath_element_single1447 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_controls_in_tikzpath_element_single1453 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_int_in_tikzpath_element_single1459 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_int_in_tikzpath_element_single1465 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_circle_in_tikzpath_element_single1471 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arc_in_tikzpath_element_single1478 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_roundbr_start_in_tikzpath_element_single1484 = new BitSet(new ulong[]{0xFF9617FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath_element_single1486 = new BitSet(new ulong[]{0xFF9617FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_roundbr_end_in_tikzpath_element_single1489 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_50_in_tikzpath_element_single1509 = new BitSet(new ulong[]{0x001C020010000000UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath_element_single1511 = new BitSet(new ulong[]{0x001C020010000000UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_51_in_tikzpath_element_single1514 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_edgeop_in_tikzpath_element_single1533 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_controls_start_in_controls1548 = new BitSet(new ulong[]{0x0004000000000000UL,0x0000000000060000UL});
    public static readonly BitSet FOLLOW_coord_in_controls1550 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000080040UL});
    public static readonly BitSet FOLLOW_70_in_controls1553 = new BitSet(new ulong[]{0x0004000000000000UL,0x0000000000060000UL});
    public static readonly BitSet FOLLOW_coord_in_controls1555 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000080040UL});
    public static readonly BitSet FOLLOW_controls_end_in_controls1559 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_node_start_in_tikznode_ext1585 = new BitSet(new ulong[]{0xFF9613FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_core_in_tikznode_ext1587 = new BitSet(new ulong[]{0x0054020010000000UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikznode_ext1589 = new BitSet(new ulong[]{0x0054020010000000UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikznode_ext1592 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrix_start_in_tikzmatrix_ext1619 = new BitSet(new ulong[]{0xFF9613FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_core_in_tikzmatrix_ext1621 = new BitSet(new ulong[]{0x0054020010000000UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzmatrix_ext1623 = new BitSet(new ulong[]{0x0054020010000000UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzmatrix_ext1626 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coordinate_start_in_tikzcoordinate_ext1654 = new BitSet(new ulong[]{0x0054020010000000UL,0x00000000000FFF80UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_ext1669 = new BitSet(new ulong[]{0x0054020010000000UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_ext1688 = new BitSet(new ulong[]{0x0054020010000000UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_ext1708 = new BitSet(new ulong[]{0x0054020010000000UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzcoordinate_ext1719 = new BitSet(new ulong[]{0x0054020010000000UL,0x00000000000FFD80UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzcoordinate_ext1722 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_71_in_tikzcoordinate_int1782 = new BitSet(new ulong[]{0x0014000000000002UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_int1793 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_int1812 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_int1832 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_72_in_tikznode_int1848 = new BitSet(new ulong[]{0xFF9613FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_core_in_tikznode_int1851 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikznode_core1861 = new BitSet(new ulong[]{0xFF9613FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikznode_core1864 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core31889 = new BitSet(new ulong[]{0x0014000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core31891 = new BitSet(new ulong[]{0x0014000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core31893 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core21927 = new BitSet(new ulong[]{0x0014000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core21929 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core11962 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_tikznode_decorator1999 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_73_in_tikznode_decorator2006 = new BitSet(new ulong[]{0x0004000000000000UL,0x0000000000060000UL});
    public static readonly BitSet FOLLOW_coord_in_tikznode_decorator2009 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_options_dontcare_in_tikznode_decorator2015 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_tikz_options_dontcare2025 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_no_rlbracket_in_tikz_options_dontcare2027 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_tikz_options_dontcare_in_tikz_options_dontcare2031 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_no_rlbracket_in_tikz_options_dontcare2033 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_53_in_tikz_options_dontcare2038 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_no_rlbracket2056 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_50_in_nodename2073 = new BitSet(new ulong[]{0xFF8211FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_idd_in_nodename2075 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_nodename2077 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_74_in_circle2101 = new BitSet(new ulong[]{0x0004000000000002UL});
    public static readonly BitSet FOLLOW_75_in_circle2105 = new BitSet(new ulong[]{0x0004000000000002UL});
    public static readonly BitSet FOLLOW_size_in_circle2114 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_76_in_arc2129 = new BitSet(new ulong[]{0x0004000000000002UL});
    public static readonly BitSet FOLLOW_50_in_arc2132 = new BitSet(new ulong[]{0x0000000060000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_arc2134 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_arc2136 = new BitSet(new ulong[]{0x0000000060000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_arc2138 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_arc2140 = new BitSet(new ulong[]{0x0000000060000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_arc2142 = new BitSet(new ulong[]{0x0008000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_70_in_arc2145 = new BitSet(new ulong[]{0x0000000060000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_arc2147 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_arc2151 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_50_in_size2176 = new BitSet(new ulong[]{0x0000000060000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_size2178 = new BitSet(new ulong[]{0x0008000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_70_in_size2181 = new BitSet(new ulong[]{0x0000000060000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_size2183 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_size2187 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_coord2217 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord2241 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_coord2244 = new BitSet(new ulong[]{0x0000000060000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord2246 = new BitSet(new ulong[]{0x0000600000000000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord2248 = new BitSet(new ulong[]{0x0000000060000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord2250 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_coord2252 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord2276 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_coord2279 = new BitSet(new ulong[]{0xFF8213FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_coord2281 = new BitSet(new ulong[]{0x0000600000000000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord2283 = new BitSet(new ulong[]{0xFF8213FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_coord2285 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_coord2287 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_coord_part2315 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_41_in_coord_part2330 = new BitSet(new ulong[]{0xFF8211FFFFFFFFF0UL,0x00000000007FFFFFUL});
    public static readonly BitSet FOLLOW_idd_in_coord_part2332 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_coord_part2334 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_coord_sep2356 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_edgeop0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_coord_modifier0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_squarebr_start2430 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_53_in_squarebr_end2448 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_semicolon_end2467 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_41_in_roundbr_start2485 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_42_in_roundbr_end2503 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_83_in_controls_start2521 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_84_in_controls_start2523 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_83_in_controls_end2541 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_tikz_set_start2559 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_tikz_set_start2561 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_tikzpicture_start2580 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_tikzpicture_start2582 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_85_in_tikzpicture_start2584 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_tikzpicture_start2586 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_61_in_tikzpicture_end2604 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_tikzpicture_end2606 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_85_in_tikzpicture_end2608 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_tikzpicture_end2610 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_tikzscope_start2628 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_tikzscope_start2630 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_86_in_tikzscope_start2632 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_tikzscope_start2634 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_61_in_tikzscope_end2652 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_tikzscope_end2654 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_86_in_tikzscope_end2656 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_tikzscope_end2658 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_tag_in_path_start2677 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_node_start_tag_in_node_start2695 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrix_start_tag_in_matrix_start2713 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_62_in_node_start_tag2731 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_63_in_matrix_start_tag2741 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_64_in_coordinate_start2751 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_path_start_tag0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_synpred1_simpletikz1665 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_synpred2_simpletikz1684 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_synpred3_simpletikz1704 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_synpred4_simpletikz1789 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_synpred5_simpletikz1808 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_synpred6_simpletikz1828 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_size_in_synpred7_simpletikz2110 = new BitSet(new ulong[]{0x0000000000000002UL});

}
