// $ANTLR 3.1.1 C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g 2012-01-08 00:39:39

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
    public const int T__89 = 89;
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
		get { return "C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g"; }
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:140:1: tikzdocument : ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* tikzpicture ( . )* -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture ) ;
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
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:141:2: ( ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* tikzpicture ( . )* -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:141:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* tikzpicture ( . )*
            {
            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:141:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )*
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
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:141:5: dontcare_preamble
            			    {
            			    	PushFollow(FOLLOW_dontcare_preamble_in_tikzdocument257);
            			    	dontcare_preamble1 = dontcare_preamble();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_dontcare_preamble.Add(dontcare_preamble1.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:141:25: tikz_styleorsetorcmd
            			    {
            			    	PushFollow(FOLLOW_tikz_styleorsetorcmd_in_tikzdocument261);
            			    	tikz_styleorsetorcmd2 = tikz_styleorsetorcmd();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikz_styleorsetorcmd.Add(tikz_styleorsetorcmd2.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:141:48: otherbegin
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
            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:141:74: ( . )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= IM_PATH && LA2_0 <= 89)) )
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
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:141:74: .
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
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:141:80: ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* tikzpicture )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DOCUMENT, "IM_DOCUMENT"), root_1);

            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:141:94: ( tikz_styleorsetorcmd )*
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:144:1: tikzdocument_wo_tikzpicture : ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* EOF -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* ) ;
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
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:145:2: ( ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* EOF -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:145:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )* EOF
            {
            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:145:4: ( dontcare_preamble | tikz_styleorsetorcmd | otherbegin )*
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
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:145:5: dontcare_preamble
            			    {
            			    	PushFollow(FOLLOW_dontcare_preamble_in_tikzdocument_wo_tikzpicture296);
            			    	dontcare_preamble6 = dontcare_preamble();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_dontcare_preamble.Add(dontcare_preamble6.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:145:25: tikz_styleorsetorcmd
            			    {
            			    	PushFollow(FOLLOW_tikz_styleorsetorcmd_in_tikzdocument_wo_tikzpicture300);
            			    	tikz_styleorsetorcmd7 = tikz_styleorsetorcmd();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikz_styleorsetorcmd.Add(tikz_styleorsetorcmd7.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:145:48: otherbegin
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
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:145:69: ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DOCUMENT, "IM_DOCUMENT"), root_1);

            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:145:83: ( tikz_styleorsetorcmd )*
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:148:1: tikz_cmd_comment : TIKZEDT_CMD_COMMENT -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT ) ;
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
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:149:2: ( TIKZEDT_CMD_COMMENT -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:149:4: TIKZEDT_CMD_COMMENT
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
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:149:30: ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT )
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:152:1: tikz_styleorsetorcmd : ( tikz_style | tikz_set | tikz_cmd_comment );
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
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:153:2: ( tikz_style | tikz_set | tikz_cmd_comment )
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
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:153:4: tikz_style
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
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:153:17: tikz_set
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
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:153:28: tikz_cmd_comment
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:156:1: dontcare_preamble : ~ ( '\\\\begin' | '\\\\tikzstyle' | '\\\\tikzset' | '\\\\tikz' | TIKZEDT_CMD_COMMENT ) ;
    public simpletikzParser.dontcare_preamble_return dontcare_preamble() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_preamble_return retval = new simpletikzParser.dontcare_preamble_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set14 = null;

        object set14_tree=null;

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:157:2: (~ ( '\\\\begin' | '\\\\tikzstyle' | '\\\\tikzset' | '\\\\tikz' | TIKZEDT_CMD_COMMENT ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:157:4: ~ ( '\\\\begin' | '\\\\tikzstyle' | '\\\\tikzset' | '\\\\tikz' | TIKZEDT_CMD_COMMENT )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set14 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= IM_ARC) || (input.LA(1) >= ID && input.LA(1) <= SOMETHING1) || (input.LA(1) >= 43 && input.LA(1) <= 89) ) 
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:159:1: otherbegin : '\\\\begin' '{' idd2 '}' ;
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
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:160:2: ( '\\\\begin' '{' idd2 '}' )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:160:4: '\\\\begin' '{' idd2 '}'
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:163:1: tikz_style : '\\\\tikzstyle' '{' idd '}' ( '=' | '+=' ) tikz_options -> ^( IM_STYLE idd tikz_options ) ;
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
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:164:2: ( '\\\\tikzstyle' '{' idd '}' ( '=' | '+=' ) tikz_options -> ^( IM_STYLE idd tikz_options ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:164:4: '\\\\tikzstyle' '{' idd '}' ( '=' | '+=' ) tikz_options
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

            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:164:30: ( '=' | '+=' )
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
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:164:31: '='
            	        {
            	        	char_literal23=(IToken)Match(input,45,FOLLOW_45_in_tikz_style427); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_45.Add(char_literal23);


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:164:37: '+='
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
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:164:59: ^( IM_STYLE idd tikz_options )
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:167:1: tikz_options : squarebr_start ( option ( ',' option )* ( ',' )? )? ( tikzstring )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) ;
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
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:168:2: ( squarebr_start ( option ( ',' option )* ( ',' )? )? ( tikzstring )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:168:5: squarebr_start ( option ( ',' option )* ( ',' )? )? ( tikzstring )? squarebr_end
            {
            	PushFollow(FOLLOW_squarebr_start_in_tikz_options456);
            	squarebr_start26 = squarebr_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_squarebr_start.Add(squarebr_start26.Tree);
            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:168:20: ( option ( ',' option )* ( ',' )? )?
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( ((LA8_0 >= IM_PATH && LA8_0 <= 42) || LA8_0 == 46 || LA8_0 == 51 || (LA8_0 >= 57 && LA8_0 <= 89)) )
            	{
            	    alt8 = 1;
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:168:21: option ( ',' option )* ( ',' )?
            	        {
            	        	PushFollow(FOLLOW_option_in_tikz_options459);
            	        	option27 = option();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_option.Add(option27.Tree);
            	        	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:168:28: ( ',' option )*
            	        	do 
            	        	{
            	        	    int alt6 = 2;
            	        	    int LA6_0 = input.LA(1);

            	        	    if ( (LA6_0 == 47) )
            	        	    {
            	        	        int LA6_1 = input.LA(2);

            	        	        if ( ((LA6_1 >= IM_PATH && LA6_1 <= 42) || LA6_1 == 46 || LA6_1 == 51 || (LA6_1 >= 57 && LA6_1 <= 89)) )
            	        	        {
            	        	            alt6 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt6) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:168:29: ',' option
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

            	        	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:168:42: ( ',' )?
            	        	int alt7 = 2;
            	        	int LA7_0 = input.LA(1);

            	        	if ( (LA7_0 == 47) )
            	        	{
            	        	    alt7 = 1;
            	        	}
            	        	switch (alt7) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:168:42: ','
            	        	        {
            	        	        	char_literal30=(IToken)Match(input,47,FOLLOW_47_in_tikz_options468); if (state.failed) return retval; 
            	        	        	if ( state.backtracking==0 ) stream_47.Add(char_literal30);


            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:168:49: ( tikzstring )?
            	int alt9 = 2;
            	int LA9_0 = input.LA(1);

            	if ( (LA9_0 == 43) )
            	{
            	    alt9 = 1;
            	}
            	switch (alt9) 
            	{
            	    case 1 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:168:49: tikzstring
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
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:168:78: ^( IM_OPTIONS squarebr_start ( option )* squarebr_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTIONS, "IM_OPTIONS"), root_1);

            	    adaptor.AddChild(root_1, stream_squarebr_start.NextTree());
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:168:106: ( option )*
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:171:1: option : ( option_style | option_kv );
    public simpletikzParser.option_return option() // throws RecognitionException [1]
    {   
        simpletikzParser.option_return retval = new simpletikzParser.option_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.option_style_return option_style33 = default(simpletikzParser.option_style_return);

        simpletikzParser.option_kv_return option_kv34 = default(simpletikzParser.option_kv_return);



        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:172:2: ( option_style | option_kv )
            int alt10 = 2;
            alt10 = dfa10.Predict(input);
            switch (alt10) 
            {
                case 1 :
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:172:4: option_style
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
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:173:5: option_kv
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:176:1: option_kv : idd ( '=' iddornumberunitorstringorrange )? -> ^( IM_OPTION_KV idd ( iddornumberunitorstringorrange )? ) ;
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
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:177:2: ( idd ( '=' iddornumberunitorstringorrange )? -> ^( IM_OPTION_KV idd ( iddornumberunitorstringorrange )? ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:177:4: idd ( '=' iddornumberunitorstringorrange )?
            {
            	PushFollow(FOLLOW_idd_in_option_kv524);
            	idd35 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_idd.Add(idd35.Tree);
            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:177:8: ( '=' iddornumberunitorstringorrange )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == 45) )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:177:9: '=' iddornumberunitorstringorrange
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
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:177:50: ^( IM_OPTION_KV idd ( iddornumberunitorstringorrange )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTION_KV, "IM_OPTION_KV"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:177:69: ( iddornumberunitorstringorrange )?
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:180:1: tikzstring : '{' ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* '}' -> ^( IM_STRING '{' '}' ) ;
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
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:181:2: ( '{' ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* '}' -> ^( IM_STRING '{' '}' ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:181:4: '{' ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* '}'
            {
            	char_literal38=(IToken)Match(input,43,FOLLOW_43_in_tikzstring557); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_43.Add(char_literal38);

            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:181:8: ( no_rlbrace )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( ((LA12_0 >= IM_PATH && LA12_0 <= 42) || (LA12_0 >= 45 && LA12_0 <= 89)) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:181:8: no_rlbrace
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

            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:181:20: ( tikzstring ( no_rlbrace )* )*
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
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:181:21: tikzstring ( no_rlbrace )*
            			    {
            			    	PushFollow(FOLLOW_tikzstring_in_tikzstring563);
            			    	tikzstring40 = tikzstring();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikzstring.Add(tikzstring40.Tree);
            			    	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:181:32: ( no_rlbrace )*
            			    	do 
            			    	{
            			    	    int alt13 = 2;
            			    	    int LA13_0 = input.LA(1);

            			    	    if ( ((LA13_0 >= IM_PATH && LA13_0 <= 42) || (LA13_0 >= 45 && LA13_0 <= 89)) )
            			    	    {
            			    	        alt13 = 1;
            			    	    }


            			    	    switch (alt13) 
            			    		{
            			    			case 1 :
            			    			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:181:32: no_rlbrace
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
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:181:53: ^( IM_STRING '{' '}' )
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:184:1: no_rlbrace : ~ ( '{' | '}' ) ;
    public simpletikzParser.no_rlbrace_return no_rlbrace() // throws RecognitionException [1]
    {   
        simpletikzParser.no_rlbrace_return retval = new simpletikzParser.no_rlbrace_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set43 = null;

        object set43_tree=null;

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:185:2: (~ ( '{' | '}' ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:185:4: ~ ( '{' | '}' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set43 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= 42) || (input.LA(1) >= 45 && input.LA(1) <= 89) ) 
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:187:1: iddornumberunitorstringorrange : ( range | numberunit | bracedcoord | idd | ( ( number ':' )? tikzstring ) );
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
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:188:2: ( range | numberunit | bracedcoord | idd | ( ( number ':' )? tikzstring ) )
            int alt16 = 5;
            alt16 = dfa16.Predict(input);
            switch (alt16) 
            {
                case 1 :
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:188:5: range
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
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:188:13: numberunit
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
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:188:26: bracedcoord
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
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:188:40: idd
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
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:188:46: ( ( number ':' )? tikzstring )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:188:46: ( ( number ':' )? tikzstring )
                    	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:188:47: ( number ':' )? tikzstring
                    	{
                    		// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:188:47: ( number ':' )?
                    		int alt15 = 2;
                    		int LA15_0 = input.LA(1);

                    		if ( ((LA15_0 >= FLOAT_WO_EXP && LA15_0 <= INT)) )
                    		{
                    		    alt15 = 1;
                    		}
                    		switch (alt15) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:188:49: number ':'
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:190:1: bracedcoord : '{' coord_nooption '}' ;
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
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:191:2: ( '{' coord_nooption '}' )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:191:4: '{' coord_nooption '}'
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:193:1: range : numberunit ':' numberunit -> ^( IM_STRING numberunit ':' numberunit ) ;
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
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:194:2: ( numberunit ':' numberunit -> ^( IM_STRING numberunit ':' numberunit ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:194:4: numberunit ':' numberunit
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
            	// elements:          numberunit, 48, numberunit
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
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:194:33: ^( IM_STRING numberunit ':' numberunit )
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:196:1: option_style : idd ( '/.style' | ( '/.append' 'style' ) ) '=' '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}' -> ^( IM_OPTION_STYLE idd ( option_kv )* ) ;
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
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:197:2: ( idd ( '/.style' | ( '/.append' 'style' ) ) '=' '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}' -> ^( IM_OPTION_STYLE idd ( option_kv )* ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:197:4: idd ( '/.style' | ( '/.append' 'style' ) ) '=' '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}'
            {
            	PushFollow(FOLLOW_idd_in_option_style697);
            	idd57 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_idd.Add(idd57.Tree);
            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:197:8: ( '/.style' | ( '/.append' 'style' ) )
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
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:197:9: '/.style'
            	        {
            	        	string_literal58=(IToken)Match(input,49,FOLLOW_49_in_option_style700); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_49.Add(string_literal58);


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:197:21: ( '/.append' 'style' )
            	        {
            	        	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:197:21: ( '/.append' 'style' )
            	        	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:197:22: '/.append' 'style'
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

            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:197:51: ( option_kv ( ',' option_kv )* )?
            	int alt19 = 2;
            	int LA19_0 = input.LA(1);

            	if ( ((LA19_0 >= IM_PATH && LA19_0 <= 42) || LA19_0 == 46 || LA19_0 == 51 || (LA19_0 >= 57 && LA19_0 <= 89)) )
            	{
            	    alt19 = 1;
            	}
            	switch (alt19) 
            	{
            	    case 1 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:197:52: option_kv ( ',' option_kv )*
            	        {
            	        	PushFollow(FOLLOW_option_kv_in_option_style716);
            	        	option_kv63 = option_kv();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_option_kv.Add(option_kv63.Tree);
            	        	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:197:62: ( ',' option_kv )*
            	        	do 
            	        	{
            	        	    int alt18 = 2;
            	        	    int LA18_0 = input.LA(1);

            	        	    if ( (LA18_0 == 47) )
            	        	    {
            	        	        int LA18_1 = input.LA(2);

            	        	        if ( ((LA18_1 >= IM_PATH && LA18_1 <= 42) || LA18_1 == 46 || LA18_1 == 51 || (LA18_1 >= 57 && LA18_1 <= 89)) )
            	        	        {
            	        	            alt18 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt18) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:197:63: ',' option_kv
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

            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:197:82: ( ',' )?
            	int alt20 = 2;
            	int LA20_0 = input.LA(1);

            	if ( (LA20_0 == 47) )
            	{
            	    alt20 = 1;
            	}
            	switch (alt20) 
            	{
            	    case 1 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:197:82: ','
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
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:197:95: ^( IM_OPTION_STYLE idd ( option_kv )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTION_STYLE, "IM_OPTION_STYLE"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:197:117: ( option_kv )*
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:209:1: idd : idd_heavenknowswhythisisnecessary -> ^( IM_ID ) ;
    public simpletikzParser.idd_return idd() // throws RecognitionException [1]
    {   
        simpletikzParser.idd_return retval = new simpletikzParser.idd_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.idd_heavenknowswhythisisnecessary_return idd_heavenknowswhythisisnecessary68 = default(simpletikzParser.idd_heavenknowswhythisisnecessary_return);


        RewriteRuleSubtreeStream stream_idd_heavenknowswhythisisnecessary = new RewriteRuleSubtreeStream(adaptor,"rule idd_heavenknowswhythisisnecessary");
        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:210:2: ( idd_heavenknowswhythisisnecessary -> ^( IM_ID ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:210:4: idd_heavenknowswhythisisnecessary
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
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:210:42: ^( IM_ID )
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:212:1: idd_heavenknowswhythisisnecessary : (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' ) )+ ;
    public simpletikzParser.idd_heavenknowswhythisisnecessary_return idd_heavenknowswhythisisnecessary() // throws RecognitionException [1]
    {   
        simpletikzParser.idd_heavenknowswhythisisnecessary_return retval = new simpletikzParser.idd_heavenknowswhythisisnecessary_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set69 = null;

        object set69_tree=null;

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:213:3: ( (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' ) )+ )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:213:6: (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' ) )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:213:6: (~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' ) )+
            	int cnt21 = 0;
            	do 
            	{
            	    int alt21 = 2;
            	    int LA21_0 = input.LA(1);

            	    if ( (LA21_0 == 73) )
            	    {
            	        int LA21_2 = input.LA(2);

            	        if ( ((LA21_2 >= IM_PATH && LA21_2 <= COMMAND) || (LA21_2 >= WS && LA21_2 <= 51) || LA21_2 == 53 || LA21_2 == 55 || (LA21_2 >= 57 && LA21_2 <= 89)) )
            	        {
            	            alt21 = 1;
            	        }
            	        else if ( ((LA21_2 >= FLOAT_WO_EXP && LA21_2 <= INT)) )
            	        {
            	            alt21 = 1;
            	        }


            	    }
            	    else if ( ((LA21_0 >= IM_PATH && LA21_0 <= 42) || LA21_0 == 46 || LA21_0 == 51 || (LA21_0 >= 57 && LA21_0 <= 72) || (LA21_0 >= 74 && LA21_0 <= 89)) )
            	    {
            	        alt21 = 1;
            	    }


            	    switch (alt21) 
            		{
            			case 1 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:213:6: ~ ( '(' | ')' | '[' | ']' | '{' | '}' | ',' | '=' | ';' | ':' | '/.style' | '/.append' )
            			    {
            			    	set69 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= 42) || input.LA(1) == 46 || input.LA(1) == 51 || (input.LA(1) >= 57 && input.LA(1) <= 89) ) 
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:214:1: idd2 : ( ID )+ -> ^( IM_ID ) ;
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
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:215:2: ( ( ID )+ -> ^( IM_ID ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:215:4: ( ID )+
            {
            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:215:4: ( ID )+
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
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:215:4: ID
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
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:215:11: ^( IM_ID )
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:218:1: numberunitorvariable : ( numberunit | COMMAND );
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
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:219:2: ( numberunit | COMMAND )
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
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:219:4: numberunit
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
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:220:4: COMMAND
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:223:1: numberunit : number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) ;
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
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:224:2: ( number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:224:4: number ( unit )?
            {
            	PushFollow(FOLLOW_number_in_numberunit883);
            	number73 = number();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_number.Add(number73.Tree);
            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:224:11: ( unit )?
            	int alt24 = 2;
            	int LA24_0 = input.LA(1);

            	if ( ((LA24_0 >= 57 && LA24_0 <= 62)) )
            	{
            	    alt24 = 1;
            	}
            	switch (alt24) 
            	{
            	    case 1 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:224:11: unit
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
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:224:20: ^( IM_NUMBERUNIT number ( unit )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NUMBERUNIT, "IM_NUMBERUNIT"), root_1);

            	    adaptor.AddChild(root_1, stream_number.NextTree());
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:224:43: ( unit )?
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:228:1: number : ( FLOAT_WO_EXP | INT ) ;
    public simpletikzParser.number_return number() // throws RecognitionException [1]
    {   
        simpletikzParser.number_return retval = new simpletikzParser.number_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set75 = null;

        object set75_tree=null;

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:229:2: ( ( FLOAT_WO_EXP | INT ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:229:4: ( FLOAT_WO_EXP | INT )
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:232:1: unit : ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' | 'em' );
    public simpletikzParser.unit_return unit() // throws RecognitionException [1]
    {   
        simpletikzParser.unit_return retval = new simpletikzParser.unit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set76 = null;

        object set76_tree=null;

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:233:2: ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' | 'em' )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:236:1: tikz_set : tikz_set_start ( option ( ',' option )* ( ',' )? )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) ;
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
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:237:2: ( tikz_set_start ( option ( ',' option )* ( ',' )? )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:237:5: tikz_set_start ( option ( ',' option )* ( ',' )? )? roundbr_end
            {
            	PushFollow(FOLLOW_tikz_set_start_in_tikz_set966);
            	tikz_set_start77 = tikz_set_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikz_set_start.Add(tikz_set_start77.Tree);
            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:237:20: ( option ( ',' option )* ( ',' )? )?
            	int alt27 = 2;
            	int LA27_0 = input.LA(1);

            	if ( ((LA27_0 >= IM_PATH && LA27_0 <= 42) || LA27_0 == 46 || LA27_0 == 51 || (LA27_0 >= 57 && LA27_0 <= 89)) )
            	{
            	    alt27 = 1;
            	}
            	switch (alt27) 
            	{
            	    case 1 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:237:21: option ( ',' option )* ( ',' )?
            	        {
            	        	PushFollow(FOLLOW_option_in_tikz_set969);
            	        	option78 = option();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_option.Add(option78.Tree);
            	        	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:237:28: ( ',' option )*
            	        	do 
            	        	{
            	        	    int alt25 = 2;
            	        	    int LA25_0 = input.LA(1);

            	        	    if ( (LA25_0 == 47) )
            	        	    {
            	        	        int LA25_1 = input.LA(2);

            	        	        if ( ((LA25_1 >= IM_PATH && LA25_1 <= 42) || LA25_1 == 46 || LA25_1 == 51 || (LA25_1 >= 57 && LA25_1 <= 89)) )
            	        	        {
            	        	            alt25 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt25) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:237:29: ',' option
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

            	        	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:237:42: ( ',' )?
            	        	int alt26 = 2;
            	        	int LA26_0 = input.LA(1);

            	        	if ( (LA26_0 == 47) )
            	        	{
            	        	    alt26 = 1;
            	        	}
            	        	switch (alt26) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:237:42: ','
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
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:237:64: ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_TIKZSET, "IM_TIKZSET"), root_1);

            	    adaptor.AddChild(root_1, stream_tikz_set_start.NextTree());
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:237:92: ( option )*
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:242:1: tikzpicture : ( ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) | ( tikz_start ( tikz_options )? '{' ( tikzbody2 )? roundbr_end ) -> ^( IM_PICTURE tikz_start ( tikz_options )? ( tikzbody2 )? roundbr_end ) );
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
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:243:2: ( ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) | ( tikz_start ( tikz_options )? '{' ( tikzbody2 )? roundbr_end ) -> ^( IM_PICTURE tikz_start ( tikz_options )? ( tikzbody2 )? roundbr_end ) )
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
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:243:7: ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
                    {
                    	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:243:7: ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
                    	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:243:9: tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end
                    	{
                    		PushFollow(FOLLOW_tikzpicture_start_in_tikzpicture1015);
                    		tikzpicture_start83 = tikzpicture_start();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_tikzpicture_start.Add(tikzpicture_start83.Tree);
                    		// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:243:27: ( tikz_options )?
                    		int alt28 = 2;
                    		int LA28_0 = input.LA(1);

                    		if ( (LA28_0 == 54) )
                    		{
                    		    alt28 = 1;
                    		}
                    		switch (alt28) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:243:27: tikz_options
                    		        {
                    		        	PushFollow(FOLLOW_tikz_options_in_tikzpicture1017);
                    		        	tikz_options84 = tikz_options();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_tikz_options.Add(tikz_options84.Tree);

                    		        }
                    		        break;

                    		}

                    		// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:243:41: ( tikzbody )?
                    		int alt29 = 2;
                    		int LA29_0 = input.LA(1);

                    		if ( ((LA29_0 >= IM_PATH && LA29_0 <= 53) || (LA29_0 >= 55 && LA29_0 <= 62) || (LA29_0 >= 64 && LA29_0 <= 89)) )
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
                    		        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:243:41: tikzbody
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
                    	// elements:          tikzpicture_end, tikz_options, tikzpicture_start, tikzbody
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
                    	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:243:71: ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PICTURE, "IM_PICTURE"), root_1);

                    	    adaptor.AddChild(root_1, stream_tikzpicture_start.NextTree());
                    	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:243:102: ( tikz_options )?
                    	    if ( stream_tikz_options.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_tikz_options.NextTree());

                    	    }
                    	    stream_tikz_options.Reset();
                    	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:243:116: ( tikzbody )?
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
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:244:5: ( tikz_start ( tikz_options )? '{' ( tikzbody2 )? roundbr_end )
                    {
                    	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:244:5: ( tikz_start ( tikz_options )? '{' ( tikzbody2 )? roundbr_end )
                    	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:244:7: tikz_start ( tikz_options )? '{' ( tikzbody2 )? roundbr_end
                    	{
                    		PushFollow(FOLLOW_tikz_start_in_tikzpicture1048);
                    		tikz_start87 = tikz_start();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_tikz_start.Add(tikz_start87.Tree);
                    		// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:244:19: ( tikz_options )?
                    		int alt30 = 2;
                    		int LA30_0 = input.LA(1);

                    		if ( (LA30_0 == 54) )
                    		{
                    		    alt30 = 1;
                    		}
                    		switch (alt30) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:244:19: tikz_options
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

                    		// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:244:37: ( tikzbody2 )?
                    		int alt31 = 2;
                    		int LA31_0 = input.LA(1);

                    		if ( ((LA31_0 >= IM_PATH && LA31_0 <= 42) || (LA31_0 >= 45 && LA31_0 <= 53) || (LA31_0 >= 55 && LA31_0 <= 89)) )
                    		{
                    		    alt31 = 1;
                    		}
                    		switch (alt31) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:244:37: tikzbody2
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
                    	// elements:          tikz_start, tikzbody2, roundbr_end, tikz_options
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
                    	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:244:66: ^( IM_PICTURE tikz_start ( tikz_options )? ( tikzbody2 )? roundbr_end )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PICTURE, "IM_PICTURE"), root_1);

                    	    adaptor.AddChild(root_1, stream_tikz_start.NextTree());
                    	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:244:90: ( tikz_options )?
                    	    if ( stream_tikz_options.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_tikz_options.NextTree());

                    	    }
                    	    stream_tikz_options.Reset();
                    	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:244:104: ( tikzbody2 )?
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:247:1: tikzbody : ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )* ;
    public simpletikzParser.tikzbody_return tikzbody() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzbody_return retval = new simpletikzParser.tikzbody_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_return tikzscope92 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath93 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznode_ext_return tikznode_ext94 = default(simpletikzParser.tikznode_ext_return);

        simpletikzParser.tikzmatrix_ext_return tikzmatrix_ext95 = default(simpletikzParser.tikzmatrix_ext_return);

        simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext96 = default(simpletikzParser.tikzcoordinate_ext_return);

        simpletikzParser.tikz_set_return tikz_set97 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style98 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin99 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend100 = default(simpletikzParser.otherend_return);

        simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr101 = default(simpletikzParser.dontcare_body_nobr_return);

        simpletikzParser.tikzscope_return tikzscope102 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath103 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznode_ext_return tikznode_ext104 = default(simpletikzParser.tikznode_ext_return);

        simpletikzParser.tikzmatrix_ext_return tikzmatrix_ext105 = default(simpletikzParser.tikzmatrix_ext_return);

        simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext106 = default(simpletikzParser.tikzcoordinate_ext_return);

        simpletikzParser.tikz_set_return tikz_set107 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style108 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin109 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend110 = default(simpletikzParser.otherend_return);

        simpletikzParser.dontcare_body_return dontcare_body111 = default(simpletikzParser.dontcare_body_return);



        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:248:2: ( ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )* )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:248:4: ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr ) ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:248:4: ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr )
            	int alt33 = 10;
            	alt33 = dfa33.Predict(input);
            	switch (alt33) 
            	{
            	    case 1 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:248:6: tikzscope
            	        {
            	        	PushFollow(FOLLOW_tikzscope_in_tikzbody1091);
            	        	tikzscope92 = tikzscope();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzscope92.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:248:18: tikzpath
            	        {
            	        	PushFollow(FOLLOW_tikzpath_in_tikzbody1095);
            	        	tikzpath93 = tikzpath();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath93.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:248:29: tikznode_ext
            	        {
            	        	PushFollow(FOLLOW_tikznode_ext_in_tikzbody1099);
            	        	tikznode_ext94 = tikznode_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_ext94.Tree);

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:248:44: tikzmatrix_ext
            	        {
            	        	PushFollow(FOLLOW_tikzmatrix_ext_in_tikzbody1103);
            	        	tikzmatrix_ext95 = tikzmatrix_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzmatrix_ext95.Tree);

            	        }
            	        break;
            	    case 5 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:248:61: tikzcoordinate_ext
            	        {
            	        	PushFollow(FOLLOW_tikzcoordinate_ext_in_tikzbody1107);
            	        	tikzcoordinate_ext96 = tikzcoordinate_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_ext96.Tree);

            	        }
            	        break;
            	    case 6 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:248:82: tikz_set
            	        {
            	        	PushFollow(FOLLOW_tikz_set_in_tikzbody1111);
            	        	tikz_set97 = tikz_set();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set97.Tree);

            	        }
            	        break;
            	    case 7 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:248:93: tikz_style
            	        {
            	        	PushFollow(FOLLOW_tikz_style_in_tikzbody1115);
            	        	tikz_style98 = tikz_style();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style98.Tree);

            	        }
            	        break;
            	    case 8 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:248:106: otherbegin
            	        {
            	        	PushFollow(FOLLOW_otherbegin_in_tikzbody1119);
            	        	otherbegin99 = otherbegin();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;
            	    case 9 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:248:120: otherend
            	        {
            	        	PushFollow(FOLLOW_otherend_in_tikzbody1124);
            	        	otherend100 = otherend();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;
            	    case 10 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:248:132: dontcare_body_nobr
            	        {
            	        	PushFollow(FOLLOW_dontcare_body_nobr_in_tikzbody1129);
            	        	dontcare_body_nobr101 = dontcare_body_nobr();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;

            	}

            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:249:3: ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*
            	do 
            	{
            	    int alt34 = 11;
            	    alt34 = dfa34.Predict(input);
            	    switch (alt34) 
            		{
            			case 1 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:249:5: tikzscope
            			    {
            			    	PushFollow(FOLLOW_tikzscope_in_tikzbody1140);
            			    	tikzscope102 = tikzscope();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzscope102.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:249:17: tikzpath
            			    {
            			    	PushFollow(FOLLOW_tikzpath_in_tikzbody1144);
            			    	tikzpath103 = tikzpath();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath103.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:249:28: tikznode_ext
            			    {
            			    	PushFollow(FOLLOW_tikznode_ext_in_tikzbody1148);
            			    	tikznode_ext104 = tikznode_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_ext104.Tree);

            			    }
            			    break;
            			case 4 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:249:43: tikzmatrix_ext
            			    {
            			    	PushFollow(FOLLOW_tikzmatrix_ext_in_tikzbody1152);
            			    	tikzmatrix_ext105 = tikzmatrix_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzmatrix_ext105.Tree);

            			    }
            			    break;
            			case 5 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:249:60: tikzcoordinate_ext
            			    {
            			    	PushFollow(FOLLOW_tikzcoordinate_ext_in_tikzbody1156);
            			    	tikzcoordinate_ext106 = tikzcoordinate_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_ext106.Tree);

            			    }
            			    break;
            			case 6 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:249:81: tikz_set
            			    {
            			    	PushFollow(FOLLOW_tikz_set_in_tikzbody1160);
            			    	tikz_set107 = tikz_set();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set107.Tree);

            			    }
            			    break;
            			case 7 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:249:92: tikz_style
            			    {
            			    	PushFollow(FOLLOW_tikz_style_in_tikzbody1164);
            			    	tikz_style108 = tikz_style();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style108.Tree);

            			    }
            			    break;
            			case 8 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:249:105: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzbody1168);
            			    	otherbegin109 = otherbegin();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;
            			case 9 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:249:119: otherend
            			    {
            			    	PushFollow(FOLLOW_otherend_in_tikzbody1173);
            			    	otherend110 = otherend();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;
            			case 10 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:249:131: dontcare_body
            			    {
            			    	PushFollow(FOLLOW_dontcare_body_in_tikzbody1178);
            			    	dontcare_body111 = dontcare_body();
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:251:1: tikzbody2 : ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr2 ) ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body2 )* ;
    public simpletikzParser.tikzbody2_return tikzbody2() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzbody2_return retval = new simpletikzParser.tikzbody2_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_return tikzscope112 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath113 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznode_ext_return tikznode_ext114 = default(simpletikzParser.tikznode_ext_return);

        simpletikzParser.tikzmatrix_ext_return tikzmatrix_ext115 = default(simpletikzParser.tikzmatrix_ext_return);

        simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext116 = default(simpletikzParser.tikzcoordinate_ext_return);

        simpletikzParser.tikz_set_return tikz_set117 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style118 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin119 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend120 = default(simpletikzParser.otherend_return);

        simpletikzParser.dontcare_body_nobr2_return dontcare_body_nobr2121 = default(simpletikzParser.dontcare_body_nobr2_return);

        simpletikzParser.tikzscope_return tikzscope122 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath123 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznode_ext_return tikznode_ext124 = default(simpletikzParser.tikznode_ext_return);

        simpletikzParser.tikzmatrix_ext_return tikzmatrix_ext125 = default(simpletikzParser.tikzmatrix_ext_return);

        simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext126 = default(simpletikzParser.tikzcoordinate_ext_return);

        simpletikzParser.tikz_set_return tikz_set127 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style128 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin129 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend130 = default(simpletikzParser.otherend_return);

        simpletikzParser.dontcare_body2_return dontcare_body2131 = default(simpletikzParser.dontcare_body2_return);



        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:252:2: ( ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr2 ) ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body2 )* )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:252:4: ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr2 ) ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body2 )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:252:4: ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr2 )
            	int alt35 = 10;
            	alt35 = dfa35.Predict(input);
            	switch (alt35) 
            	{
            	    case 1 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:252:6: tikzscope
            	        {
            	        	PushFollow(FOLLOW_tikzscope_in_tikzbody21194);
            	        	tikzscope112 = tikzscope();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzscope112.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:252:18: tikzpath
            	        {
            	        	PushFollow(FOLLOW_tikzpath_in_tikzbody21198);
            	        	tikzpath113 = tikzpath();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath113.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:252:29: tikznode_ext
            	        {
            	        	PushFollow(FOLLOW_tikznode_ext_in_tikzbody21202);
            	        	tikznode_ext114 = tikznode_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_ext114.Tree);

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:252:44: tikzmatrix_ext
            	        {
            	        	PushFollow(FOLLOW_tikzmatrix_ext_in_tikzbody21206);
            	        	tikzmatrix_ext115 = tikzmatrix_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzmatrix_ext115.Tree);

            	        }
            	        break;
            	    case 5 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:252:61: tikzcoordinate_ext
            	        {
            	        	PushFollow(FOLLOW_tikzcoordinate_ext_in_tikzbody21210);
            	        	tikzcoordinate_ext116 = tikzcoordinate_ext();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_ext116.Tree);

            	        }
            	        break;
            	    case 6 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:252:82: tikz_set
            	        {
            	        	PushFollow(FOLLOW_tikz_set_in_tikzbody21214);
            	        	tikz_set117 = tikz_set();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set117.Tree);

            	        }
            	        break;
            	    case 7 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:252:93: tikz_style
            	        {
            	        	PushFollow(FOLLOW_tikz_style_in_tikzbody21218);
            	        	tikz_style118 = tikz_style();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style118.Tree);

            	        }
            	        break;
            	    case 8 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:252:106: otherbegin
            	        {
            	        	PushFollow(FOLLOW_otherbegin_in_tikzbody21222);
            	        	otherbegin119 = otherbegin();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;
            	    case 9 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:252:120: otherend
            	        {
            	        	PushFollow(FOLLOW_otherend_in_tikzbody21227);
            	        	otherend120 = otherend();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;
            	    case 10 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:252:132: dontcare_body_nobr2
            	        {
            	        	PushFollow(FOLLOW_dontcare_body_nobr2_in_tikzbody21232);
            	        	dontcare_body_nobr2121 = dontcare_body_nobr2();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;

            	}

            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:253:3: ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body2 )*
            	do 
            	{
            	    int alt36 = 11;
            	    alt36 = dfa36.Predict(input);
            	    switch (alt36) 
            		{
            			case 1 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:253:5: tikzscope
            			    {
            			    	PushFollow(FOLLOW_tikzscope_in_tikzbody21243);
            			    	tikzscope122 = tikzscope();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzscope122.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:253:17: tikzpath
            			    {
            			    	PushFollow(FOLLOW_tikzpath_in_tikzbody21247);
            			    	tikzpath123 = tikzpath();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath123.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:253:28: tikznode_ext
            			    {
            			    	PushFollow(FOLLOW_tikznode_ext_in_tikzbody21251);
            			    	tikznode_ext124 = tikznode_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_ext124.Tree);

            			    }
            			    break;
            			case 4 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:253:43: tikzmatrix_ext
            			    {
            			    	PushFollow(FOLLOW_tikzmatrix_ext_in_tikzbody21255);
            			    	tikzmatrix_ext125 = tikzmatrix_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzmatrix_ext125.Tree);

            			    }
            			    break;
            			case 5 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:253:60: tikzcoordinate_ext
            			    {
            			    	PushFollow(FOLLOW_tikzcoordinate_ext_in_tikzbody21259);
            			    	tikzcoordinate_ext126 = tikzcoordinate_ext();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_ext126.Tree);

            			    }
            			    break;
            			case 6 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:253:81: tikz_set
            			    {
            			    	PushFollow(FOLLOW_tikz_set_in_tikzbody21263);
            			    	tikz_set127 = tikz_set();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_set127.Tree);

            			    }
            			    break;
            			case 7 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:253:92: tikz_style
            			    {
            			    	PushFollow(FOLLOW_tikz_style_in_tikzbody21267);
            			    	tikz_style128 = tikz_style();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_style128.Tree);

            			    }
            			    break;
            			case 8 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:253:105: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzbody21271);
            			    	otherbegin129 = otherbegin();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;
            			case 9 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:253:119: otherend
            			    {
            			    	PushFollow(FOLLOW_otherend_in_tikzbody21276);
            			    	otherend130 = otherend();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;

            			    }
            			    break;
            			case 10 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:253:131: dontcare_body2
            			    {
            			    	PushFollow(FOLLOW_dontcare_body2_in_tikzbody21281);
            			    	dontcare_body2131 = dontcare_body2();
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:256:1: dontcare_body_nobr2 : (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\filldraw' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' | '{' | '}' ) ) ;
    public simpletikzParser.dontcare_body_nobr2_return dontcare_body_nobr2() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body_nobr2_return retval = new simpletikzParser.dontcare_body_nobr2_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set132 = null;

        object set132_tree=null;

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:257:2: ( (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\filldraw' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' | '{' | '}' ) ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:257:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\filldraw' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' | '{' | '}' ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:257:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\filldraw' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' | '{' | '}' ) )
            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:257:5: ~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\filldraw' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' | '{' | '}' )
            	{
            		set132 = (IToken)input.LT(1);
            		if ( (input.LA(1) >= IM_PATH && input.LA(1) <= SOMETHING1) || input.LA(1) == 42 || (input.LA(1) >= 45 && input.LA(1) <= 53) || (input.LA(1) >= 55 && input.LA(1) <= 62) || (input.LA(1) >= 72 && input.LA(1) <= 89) ) 
            		{
            		    input.Consume();
            		    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set132));
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:259:1: dontcare_body2 : (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\filldraw' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '{' | '}' ) ) ;
    public simpletikzParser.dontcare_body2_return dontcare_body2() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body2_return retval = new simpletikzParser.dontcare_body2_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set133 = null;

        object set133_tree=null;

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:260:2: ( (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\filldraw' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '{' | '}' ) ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:260:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\filldraw' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '{' | '}' ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:260:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\filldraw' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '{' | '}' ) )
            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:260:5: ~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\filldraw' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '{' | '}' )
            	{
            		set133 = (IToken)input.LT(1);
            		if ( (input.LA(1) >= IM_PATH && input.LA(1) <= SOMETHING1) || input.LA(1) == 42 || (input.LA(1) >= 45 && input.LA(1) <= 62) || (input.LA(1) >= 72 && input.LA(1) <= 89) ) 
            		{
            		    input.Consume();
            		    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set133));
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:262:1: dontcare_body_nobr : (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\filldraw' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) ) ;
    public simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body_nobr_return retval = new simpletikzParser.dontcare_body_nobr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set134 = null;

        object set134_tree=null;

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:263:2: ( (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\filldraw' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:263:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\filldraw' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:263:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\filldraw' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' ) )
            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:263:5: ~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\filldraw' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' | '[' )
            	{
            		set134 = (IToken)input.LT(1);
            		if ( (input.LA(1) >= IM_PATH && input.LA(1) <= SOMETHING1) || (input.LA(1) >= 42 && input.LA(1) <= 53) || (input.LA(1) >= 55 && input.LA(1) <= 62) || (input.LA(1) >= 72 && input.LA(1) <= 89) ) 
            		{
            		    input.Consume();
            		    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set134));
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:265:1: dontcare_body : (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\filldraw' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) ) ;
    public simpletikzParser.dontcare_body_return dontcare_body() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body_return retval = new simpletikzParser.dontcare_body_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set135 = null;

        object set135_tree=null;

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:266:2: ( (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\filldraw' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:266:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\filldraw' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:266:4: (~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\filldraw' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' ) )
            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:266:5: ~ ( '\\\\begin' | '\\\\end' | '\\\\node' | '\\\\matrix' | '\\\\coordinate' | '\\\\draw' | '\\\\path' | '\\\\filldraw' | '\\\\fill' | '\\\\clip' | '\\\\tikzstyle' | '\\\\tikzset' )
            	{
            		set135 = (IToken)input.LT(1);
            		if ( (input.LA(1) >= IM_PATH && input.LA(1) <= SOMETHING1) || (input.LA(1) >= 42 && input.LA(1) <= 62) || (input.LA(1) >= 72 && input.LA(1) <= 89) ) 
            		{
            		    input.Consume();
            		    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set135));
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:268:1: otherend : '\\\\end' '{' idd2 '}' ;
    public simpletikzParser.otherend_return otherend() // throws RecognitionException [1]
    {   
        simpletikzParser.otherend_return retval = new simpletikzParser.otherend_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal136 = null;
        IToken char_literal137 = null;
        IToken char_literal139 = null;
        simpletikzParser.idd2_return idd2138 = default(simpletikzParser.idd2_return);


        object string_literal136_tree=null;
        object char_literal137_tree=null;
        object char_literal139_tree=null;

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:269:2: ( '\\\\end' '{' idd2 '}' )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:269:4: '\\\\end' '{' idd2 '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal136=(IToken)Match(input,63,FOLLOW_63_in_otherend1572); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal136_tree = (object)adaptor.Create(string_literal136);
            		adaptor.AddChild(root_0, string_literal136_tree);
            	}
            	char_literal137=(IToken)Match(input,43,FOLLOW_43_in_otherend1574); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal137_tree = (object)adaptor.Create(char_literal137);
            		adaptor.AddChild(root_0, char_literal137_tree);
            	}
            	PushFollow(FOLLOW_idd2_in_otherend1576);
            	idd2138 = idd2();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idd2138.Tree);
            	char_literal139=(IToken)Match(input,44,FOLLOW_44_in_otherend1578); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal139_tree = (object)adaptor.Create(char_literal139);
            		adaptor.AddChild(root_0, char_literal139_tree);
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:283:1: tikzscope : tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end ) ;
    public simpletikzParser.tikzscope_return tikzscope() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_return retval = new simpletikzParser.tikzscope_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_start_return tikzscope_start140 = default(simpletikzParser.tikzscope_start_return);

        simpletikzParser.tikz_options_return tikz_options141 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody_return tikzbody142 = default(simpletikzParser.tikzbody_return);

        simpletikzParser.tikzscope_end_return tikzscope_end143 = default(simpletikzParser.tikzscope_end_return);


        RewriteRuleSubtreeStream stream_tikzscope_start = new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_start");
        RewriteRuleSubtreeStream stream_tikzscope_end = new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_end");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:284:2: ( tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:284:4: tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end
            {
            	PushFollow(FOLLOW_tikzscope_start_in_tikzscope1605);
            	tikzscope_start140 = tikzscope_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikzscope_start.Add(tikzscope_start140.Tree);
            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:284:20: ( tikz_options )?
            	int alt37 = 2;
            	int LA37_0 = input.LA(1);

            	if ( (LA37_0 == 54) )
            	{
            	    alt37 = 1;
            	}
            	switch (alt37) 
            	{
            	    case 1 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:284:20: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_tikzscope1607);
            	        	tikz_options141 = tikz_options();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_tikz_options.Add(tikz_options141.Tree);

            	        }
            	        break;

            	}

            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:284:34: ( tikzbody )?
            	int alt38 = 2;
            	int LA38_0 = input.LA(1);

            	if ( ((LA38_0 >= IM_PATH && LA38_0 <= 53) || (LA38_0 >= 55 && LA38_0 <= 62) || (LA38_0 >= 64 && LA38_0 <= 89)) )
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
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:284:34: tikzbody
            	        {
            	        	PushFollow(FOLLOW_tikzbody_in_tikzscope1610);
            	        	tikzbody142 = tikzbody();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_tikzbody.Add(tikzbody142.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzscope_end_in_tikzscope1613);
            	tikzscope_end143 = tikzscope_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikzscope_end.Add(tikzscope_end143.Tree);


            	// AST REWRITE
            	// elements:          tikzbody, tikz_options, tikzscope_end, tikzscope_start
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
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:284:62: ^( IM_SCOPE tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_SCOPE, "IM_SCOPE"), root_1);

            	    adaptor.AddChild(root_1, stream_tikzscope_start.NextTree());
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:284:89: ( tikz_options )?
            	    if ( stream_tikz_options.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikz_options.NextTree());

            	    }
            	    stream_tikz_options.Reset();
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:284:103: ( tikzbody )?
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:310:1: tikzpath : path_start ( tikzpath_element )* semicolon_end -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikzpath_return tikzpath() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_return retval = new simpletikzParser.tikzpath_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.path_start_return path_start144 = default(simpletikzParser.path_start_return);

        simpletikzParser.tikzpath_element_return tikzpath_element145 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end146 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_path_start = new RewriteRuleSubtreeStream(adaptor,"rule path_start");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:311:2: ( path_start ( tikzpath_element )* semicolon_end -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:311:4: path_start ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_path_start_in_tikzpath1669);
            	path_start144 = path_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_path_start.Add(path_start144.Tree);
            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:311:15: ( tikzpath_element )*
            	do 
            	{
            	    int alt39 = 2;
            	    int LA39_0 = input.LA(1);

            	    if ( ((LA39_0 >= ID && LA39_0 <= COMMAND) || LA39_0 == 43 || LA39_0 == 45 || LA39_0 == 52 || LA39_0 == 54 || LA39_0 == 58 || LA39_0 == 72 || (LA39_0 >= 74 && LA39_0 <= 75) || (LA39_0 >= 77 && LA39_0 <= 86)) )
            	    {
            	        alt39 = 1;
            	    }


            	    switch (alt39) 
            		{
            			case 1 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:311:15: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath1671);
            			    	tikzpath_element145 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikzpath_element.Add(tikzpath_element145.Tree);

            			    }
            			    break;

            			default:
            			    goto loop39;
            	    }
            	} while (true);

            	loop39:
            		;	// Stops C# compiler whining that label 'loop39' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikzpath1674);
            	semicolon_end146 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_semicolon_end.Add(semicolon_end146.Tree);


            	// AST REWRITE
            	// elements:          semicolon_end, tikzpath_element, path_start
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
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:311:50: ^( IM_PATH path_start ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_path_start.NextTree());
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:311:71: ( tikzpath_element )*
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:316:1: let_cmd_parts : ( 'let' | 'in' | '=' | COMMAND );
    public simpletikzParser.let_cmd_parts_return let_cmd_parts() // throws RecognitionException [1]
    {   
        simpletikzParser.let_cmd_parts_return retval = new simpletikzParser.let_cmd_parts_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set147 = null;

        object set147_tree=null;

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:317:2: ( 'let' | 'in' | '=' | COMMAND )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set147 = (IToken)input.LT(1);
            	if ( input.LA(1) == COMMAND || input.LA(1) == 45 || input.LA(1) == 58 || input.LA(1) == 72 ) 
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:321:1: tikzpath_element : tikzpath_element_single ( ',' )? ;
    public simpletikzParser.tikzpath_element_return tikzpath_element() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_element_return retval = new simpletikzParser.tikzpath_element_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal149 = null;
        simpletikzParser.tikzpath_element_single_return tikzpath_element_single148 = default(simpletikzParser.tikzpath_element_single_return);


        object char_literal149_tree=null;

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:322:2: ( tikzpath_element_single ( ',' )? )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:322:4: tikzpath_element_single ( ',' )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_tikzpath_element_single_in_tikzpath_element1730);
            	tikzpath_element_single148 = tikzpath_element_single();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzpath_element_single148.Tree);
            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:322:28: ( ',' )?
            	int alt40 = 2;
            	int LA40_0 = input.LA(1);

            	if ( (LA40_0 == 47) )
            	{
            	    alt40 = 1;
            	}
            	switch (alt40) 
            	{
            	    case 1 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:322:28: ','
            	        {
            	        	char_literal149=(IToken)Match(input,47,FOLLOW_47_in_tikzpath_element1732); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal149_tree = (object)adaptor.Create(char_literal149);
            	        		adaptor.AddChild(root_0, char_literal149_tree);
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:325:1: tikzpath_element_single : ( tikz_options | let_cmd_parts -> ^( IM_TIKZEDT_CMD ( let_cmd_parts )+ ) | arc | ( coord )=> coord | controls | tikznode_int | tikzcoordinate_int | circle | roundbr_start ( tikzpath_element )* roundbr_end -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end ) | '(' ( tikzpath_element )* ')' -> ^( IM_PATH '(' ( tikzpath_element )* ')' ) | edgeop );
    public simpletikzParser.tikzpath_element_single_return tikzpath_element_single() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_element_single_return retval = new simpletikzParser.tikzpath_element_single_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal161 = null;
        IToken char_literal163 = null;
        simpletikzParser.tikz_options_return tikz_options150 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.let_cmd_parts_return let_cmd_parts151 = default(simpletikzParser.let_cmd_parts_return);

        simpletikzParser.arc_return arc152 = default(simpletikzParser.arc_return);

        simpletikzParser.coord_return coord153 = default(simpletikzParser.coord_return);

        simpletikzParser.controls_return controls154 = default(simpletikzParser.controls_return);

        simpletikzParser.tikznode_int_return tikznode_int155 = default(simpletikzParser.tikznode_int_return);

        simpletikzParser.tikzcoordinate_int_return tikzcoordinate_int156 = default(simpletikzParser.tikzcoordinate_int_return);

        simpletikzParser.circle_return circle157 = default(simpletikzParser.circle_return);

        simpletikzParser.roundbr_start_return roundbr_start158 = default(simpletikzParser.roundbr_start_return);

        simpletikzParser.tikzpath_element_return tikzpath_element159 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.roundbr_end_return roundbr_end160 = default(simpletikzParser.roundbr_end_return);

        simpletikzParser.tikzpath_element_return tikzpath_element162 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.edgeop_return edgeop164 = default(simpletikzParser.edgeop_return);


        object char_literal161_tree=null;
        object char_literal163_tree=null;
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_roundbr_start = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_start");
        RewriteRuleSubtreeStream stream_roundbr_end = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        RewriteRuleSubtreeStream stream_let_cmd_parts = new RewriteRuleSubtreeStream(adaptor,"rule let_cmd_parts");
        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:326:2: ( tikz_options | let_cmd_parts -> ^( IM_TIKZEDT_CMD ( let_cmd_parts )+ ) | arc | ( coord )=> coord | controls | tikznode_int | tikzcoordinate_int | circle | roundbr_start ( tikzpath_element )* roundbr_end -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end ) | '(' ( tikzpath_element )* ')' -> ^( IM_PATH '(' ( tikzpath_element )* ')' ) | edgeop )
            int alt43 = 11;
            alt43 = dfa43.Predict(input);
            switch (alt43) 
            {
                case 1 :
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:327:5: tikz_options
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_options_in_tikzpath_element_single1749);
                    	tikz_options150 = tikz_options();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_options150.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:328:5: let_cmd_parts
                    {
                    	PushFollow(FOLLOW_let_cmd_parts_in_tikzpath_element_single1756);
                    	let_cmd_parts151 = let_cmd_parts();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_let_cmd_parts.Add(let_cmd_parts151.Tree);


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
                    	// 328:19: -> ^( IM_TIKZEDT_CMD ( let_cmd_parts )+ )
                    	{
                    	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:328:22: ^( IM_TIKZEDT_CMD ( let_cmd_parts )+ )
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
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:330:5: arc
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arc_in_tikzpath_element_single1774);
                    	arc152 = arc();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arc152.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:331:5: ( coord )=> coord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_coord_in_tikzpath_element_single1784);
                    	coord153 = coord();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, coord153.Tree);

                    }
                    break;
                case 5 :
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:332:5: controls
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_controls_in_tikzpath_element_single1790);
                    	controls154 = controls();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, controls154.Tree);

                    }
                    break;
                case 6 :
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:333:5: tikznode_int
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikznode_int_in_tikzpath_element_single1796);
                    	tikznode_int155 = tikznode_int();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_int155.Tree);

                    }
                    break;
                case 7 :
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:334:5: tikzcoordinate_int
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikzcoordinate_int_in_tikzpath_element_single1802);
                    	tikzcoordinate_int156 = tikzcoordinate_int();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_int156.Tree);

                    }
                    break;
                case 8 :
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:335:5: circle
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_circle_in_tikzpath_element_single1808);
                    	circle157 = circle();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;

                    }
                    break;
                case 9 :
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:336:5: roundbr_start ( tikzpath_element )* roundbr_end
                    {
                    	PushFollow(FOLLOW_roundbr_start_in_tikzpath_element_single1815);
                    	roundbr_start158 = roundbr_start();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_roundbr_start.Add(roundbr_start158.Tree);
                    	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:336:19: ( tikzpath_element )*
                    	do 
                    	{
                    	    int alt41 = 2;
                    	    int LA41_0 = input.LA(1);

                    	    if ( ((LA41_0 >= ID && LA41_0 <= COMMAND) || LA41_0 == 43 || LA41_0 == 45 || LA41_0 == 52 || LA41_0 == 54 || LA41_0 == 58 || LA41_0 == 72 || (LA41_0 >= 74 && LA41_0 <= 75) || (LA41_0 >= 77 && LA41_0 <= 86)) )
                    	    {
                    	        alt41 = 1;
                    	    }


                    	    switch (alt41) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:336:19: tikzpath_element
                    			    {
                    			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath_element_single1817);
                    			    	tikzpath_element159 = tikzpath_element();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking==0 ) stream_tikzpath_element.Add(tikzpath_element159.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop41;
                    	    }
                    	} while (true);

                    	loop41:
                    		;	// Stops C# compiler whining that label 'loop41' has no statements

                    	PushFollow(FOLLOW_roundbr_end_in_tikzpath_element_single1820);
                    	roundbr_end160 = roundbr_end();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_roundbr_end.Add(roundbr_end160.Tree);


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
                    	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:336:52: ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

                    	    adaptor.AddChild(root_1, stream_roundbr_start.NextTree());
                    	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:336:76: ( tikzpath_element )*
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
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:337:6: '(' ( tikzpath_element )* ')'
                    {
                    	char_literal161=(IToken)Match(input,52,FOLLOW_52_in_tikzpath_element_single1840); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_52.Add(char_literal161);

                    	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:337:10: ( tikzpath_element )*
                    	do 
                    	{
                    	    int alt42 = 2;
                    	    int LA42_0 = input.LA(1);

                    	    if ( ((LA42_0 >= ID && LA42_0 <= COMMAND) || LA42_0 == 43 || LA42_0 == 45 || LA42_0 == 52 || LA42_0 == 54 || LA42_0 == 58 || LA42_0 == 72 || (LA42_0 >= 74 && LA42_0 <= 75) || (LA42_0 >= 77 && LA42_0 <= 86)) )
                    	    {
                    	        alt42 = 1;
                    	    }


                    	    switch (alt42) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:337:10: tikzpath_element
                    			    {
                    			    	PushFollow(FOLLOW_tikzpath_element_in_tikzpath_element_single1842);
                    			    	tikzpath_element162 = tikzpath_element();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking==0 ) stream_tikzpath_element.Add(tikzpath_element162.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop42;
                    	    }
                    	} while (true);

                    	loop42:
                    		;	// Stops C# compiler whining that label 'loop42' has no statements

                    	char_literal163=(IToken)Match(input,53,FOLLOW_53_in_tikzpath_element_single1845); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_53.Add(char_literal163);



                    	// AST REWRITE
                    	// elements:          tikzpath_element, 52, 53
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
                    	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:337:35: ^( IM_PATH '(' ( tikzpath_element )* ')' )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

                    	    adaptor.AddChild(root_1, stream_52.NextNode());
                    	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:337:49: ( tikzpath_element )*
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
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:338:5: edgeop
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_edgeop_in_tikzpath_element_single1864);
                    	edgeop164 = edgeop();
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:341:1: controls : controls_start coord ( 'and' coord )? controls_end -> ^( IM_CONTROLS controls_start ( coord )+ controls_end ) ;
    public simpletikzParser.controls_return controls() // throws RecognitionException [1]
    {   
        simpletikzParser.controls_return retval = new simpletikzParser.controls_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal167 = null;
        simpletikzParser.controls_start_return controls_start165 = default(simpletikzParser.controls_start_return);

        simpletikzParser.coord_return coord166 = default(simpletikzParser.coord_return);

        simpletikzParser.coord_return coord168 = default(simpletikzParser.coord_return);

        simpletikzParser.controls_end_return controls_end169 = default(simpletikzParser.controls_end_return);


        object string_literal167_tree=null;
        RewriteRuleTokenStream stream_73 = new RewriteRuleTokenStream(adaptor,"token 73");
        RewriteRuleSubtreeStream stream_coord = new RewriteRuleSubtreeStream(adaptor,"rule coord");
        RewriteRuleSubtreeStream stream_controls_start = new RewriteRuleSubtreeStream(adaptor,"rule controls_start");
        RewriteRuleSubtreeStream stream_controls_end = new RewriteRuleSubtreeStream(adaptor,"rule controls_end");
        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:342:2: ( controls_start coord ( 'and' coord )? controls_end -> ^( IM_CONTROLS controls_start ( coord )+ controls_end ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:342:4: controls_start coord ( 'and' coord )? controls_end
            {
            	PushFollow(FOLLOW_controls_start_in_controls1879);
            	controls_start165 = controls_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_controls_start.Add(controls_start165.Tree);
            	PushFollow(FOLLOW_coord_in_controls1881);
            	coord166 = coord();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_coord.Add(coord166.Tree);
            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:342:25: ( 'and' coord )?
            	int alt44 = 2;
            	int LA44_0 = input.LA(1);

            	if ( (LA44_0 == 73) )
            	{
            	    alt44 = 1;
            	}
            	switch (alt44) 
            	{
            	    case 1 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:342:26: 'and' coord
            	        {
            	        	string_literal167=(IToken)Match(input,73,FOLLOW_73_in_controls1884); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_73.Add(string_literal167);

            	        	PushFollow(FOLLOW_coord_in_controls1886);
            	        	coord168 = coord();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_coord.Add(coord168.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_controls_end_in_controls1890);
            	controls_end169 = controls_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_controls_end.Add(controls_end169.Tree);


            	// AST REWRITE
            	// elements:          controls_end, controls_start, coord
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
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:342:56: ^( IM_CONTROLS controls_start ( coord )+ controls_end )
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:345:1: tikznode_ext : node_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikznode_ext_return tikznode_ext() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_ext_return retval = new simpletikzParser.tikznode_ext_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.node_start_return node_start170 = default(simpletikzParser.node_start_return);

        simpletikzParser.tikznode_core_return tikznode_core171 = default(simpletikzParser.tikznode_core_return);

        simpletikzParser.tikzpath_element_return tikzpath_element172 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end173 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_node_start = new RewriteRuleSubtreeStream(adaptor,"rule node_start");
        RewriteRuleSubtreeStream stream_tikznode_core = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_core");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:346:2: ( node_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:346:4: node_start tikznode_core ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_node_start_in_tikznode_ext1916);
            	node_start170 = node_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_node_start.Add(node_start170.Tree);
            	PushFollow(FOLLOW_tikznode_core_in_tikznode_ext1918);
            	tikznode_core171 = tikznode_core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_core.Add(tikznode_core171.Tree);
            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:346:29: ( tikzpath_element )*
            	do 
            	{
            	    int alt45 = 2;
            	    int LA45_0 = input.LA(1);

            	    if ( ((LA45_0 >= ID && LA45_0 <= COMMAND) || LA45_0 == 43 || LA45_0 == 45 || LA45_0 == 52 || LA45_0 == 54 || LA45_0 == 58 || LA45_0 == 72 || (LA45_0 >= 74 && LA45_0 <= 75) || (LA45_0 >= 77 && LA45_0 <= 86)) )
            	    {
            	        alt45 = 1;
            	    }


            	    switch (alt45) 
            		{
            			case 1 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:346:29: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikznode_ext1920);
            			    	tikzpath_element172 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikzpath_element.Add(tikzpath_element172.Tree);

            			    }
            			    break;

            			default:
            			    goto loop45;
            	    }
            	} while (true);

            	loop45:
            		;	// Stops C# compiler whining that label 'loop45' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikznode_ext1923);
            	semicolon_end173 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_semicolon_end.Add(semicolon_end173.Tree);


            	// AST REWRITE
            	// elements:          tikznode_core, node_start, tikzpath_element, semicolon_end
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
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:346:64: ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_node_start.NextTree());
            	    adaptor.AddChild(root_1, stream_tikznode_core.NextTree());
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:346:99: ( tikzpath_element )*
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:349:1: tikzmatrix_ext : matrix_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH matrix_start tikznode_core ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikzmatrix_ext_return tikzmatrix_ext() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzmatrix_ext_return retval = new simpletikzParser.tikzmatrix_ext_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.matrix_start_return matrix_start174 = default(simpletikzParser.matrix_start_return);

        simpletikzParser.tikznode_core_return tikznode_core175 = default(simpletikzParser.tikznode_core_return);

        simpletikzParser.tikzpath_element_return tikzpath_element176 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end177 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_matrix_start = new RewriteRuleSubtreeStream(adaptor,"rule matrix_start");
        RewriteRuleSubtreeStream stream_tikznode_core = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_core");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:350:2: ( matrix_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH matrix_start tikznode_core ( tikzpath_element )* semicolon_end ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:350:4: matrix_start tikznode_core ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_matrix_start_in_tikzmatrix_ext1950);
            	matrix_start174 = matrix_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_matrix_start.Add(matrix_start174.Tree);
            	PushFollow(FOLLOW_tikznode_core_in_tikzmatrix_ext1952);
            	tikznode_core175 = tikznode_core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_core.Add(tikznode_core175.Tree);
            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:350:31: ( tikzpath_element )*
            	do 
            	{
            	    int alt46 = 2;
            	    int LA46_0 = input.LA(1);

            	    if ( ((LA46_0 >= ID && LA46_0 <= COMMAND) || LA46_0 == 43 || LA46_0 == 45 || LA46_0 == 52 || LA46_0 == 54 || LA46_0 == 58 || LA46_0 == 72 || (LA46_0 >= 74 && LA46_0 <= 75) || (LA46_0 >= 77 && LA46_0 <= 86)) )
            	    {
            	        alt46 = 1;
            	    }


            	    switch (alt46) 
            		{
            			case 1 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:350:31: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikzmatrix_ext1954);
            			    	tikzpath_element176 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikzpath_element.Add(tikzpath_element176.Tree);

            			    }
            			    break;

            			default:
            			    goto loop46;
            	    }
            	} while (true);

            	loop46:
            		;	// Stops C# compiler whining that label 'loop46' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikzmatrix_ext1957);
            	semicolon_end177 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_semicolon_end.Add(semicolon_end177.Tree);


            	// AST REWRITE
            	// elements:          matrix_start, tikznode_core, tikzpath_element, semicolon_end
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 350:63: -> ^( IM_PATH matrix_start tikznode_core ( tikzpath_element )* semicolon_end )
            	{
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:350:66: ^( IM_PATH matrix_start tikznode_core ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_matrix_start.NextTree());
            	    adaptor.AddChild(root_1, stream_tikznode_core.NextTree());
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:350:103: ( tikzpath_element )*
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:354:1: tikzcoordinate_ext : coordinate_start ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ( tikzpath_element )* semicolon_end -> ^( IM_PATH coordinate_start ( tikzcoordinate_core3 )? ( tikzcoordinate_core2 )? ( tikzcoordinate_core1 )? ( tikzpath_element )* semicolon_end ) ;
    public simpletikzParser.tikzcoordinate_ext_return tikzcoordinate_ext() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_ext_return retval = new simpletikzParser.tikzcoordinate_ext_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.coordinate_start_return coordinate_start178 = default(simpletikzParser.coordinate_start_return);

        simpletikzParser.tikzcoordinate_core3_return tikzcoordinate_core3179 = default(simpletikzParser.tikzcoordinate_core3_return);

        simpletikzParser.tikzcoordinate_core2_return tikzcoordinate_core2180 = default(simpletikzParser.tikzcoordinate_core2_return);

        simpletikzParser.tikzcoordinate_core1_return tikzcoordinate_core1181 = default(simpletikzParser.tikzcoordinate_core1_return);

        simpletikzParser.tikzpath_element_return tikzpath_element182 = default(simpletikzParser.tikzpath_element_return);

        simpletikzParser.semicolon_end_return semicolon_end183 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_tikzpath_element = new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_tikzcoordinate_core3 = new RewriteRuleSubtreeStream(adaptor,"rule tikzcoordinate_core3");
        RewriteRuleSubtreeStream stream_tikzcoordinate_core2 = new RewriteRuleSubtreeStream(adaptor,"rule tikzcoordinate_core2");
        RewriteRuleSubtreeStream stream_coordinate_start = new RewriteRuleSubtreeStream(adaptor,"rule coordinate_start");
        RewriteRuleSubtreeStream stream_tikzcoordinate_core1 = new RewriteRuleSubtreeStream(adaptor,"rule tikzcoordinate_core1");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:355:2: ( coordinate_start ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ( tikzpath_element )* semicolon_end -> ^( IM_PATH coordinate_start ( tikzcoordinate_core3 )? ( tikzcoordinate_core2 )? ( tikzcoordinate_core1 )? ( tikzpath_element )* semicolon_end ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:355:4: coordinate_start ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ( tikzpath_element )* semicolon_end
            {
            	PushFollow(FOLLOW_coordinate_start_in_tikzcoordinate_ext1985);
            	coordinate_start178 = coordinate_start();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_coordinate_start.Add(coordinate_start178.Tree);
            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:356:5: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?
            	int alt47 = 4;
            	alt47 = dfa47.Predict(input);
            	switch (alt47) 
            	{
            	    case 1 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:356:7: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        {
            	        	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:356:7: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:356:8: ( tikzcoordinate_core3 )=> tikzcoordinate_core3
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_ext2000);
            	        		tikzcoordinate_core3179 = tikzcoordinate_core3();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking==0 ) stream_tikzcoordinate_core3.Add(tikzcoordinate_core3179.Tree);

            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:357:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        {
            	        	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:357:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:357:12: ( tikzcoordinate_core2 )=> tikzcoordinate_core2
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_ext2019);
            	        		tikzcoordinate_core2180 = tikzcoordinate_core2();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking==0 ) stream_tikzcoordinate_core2.Add(tikzcoordinate_core2180.Tree);

            	        	}


            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:358:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        {
            	        	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:358:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:358:12: ( tikzcoordinate_core1 )=> tikzcoordinate_core1
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_ext2039);
            	        		tikzcoordinate_core1181 = tikzcoordinate_core1();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking==0 ) stream_tikzcoordinate_core1.Add(tikzcoordinate_core1181.Tree);

            	        	}


            	        }
            	        break;

            	}

            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:359:6: ( tikzpath_element )*
            	do 
            	{
            	    int alt48 = 2;
            	    int LA48_0 = input.LA(1);

            	    if ( ((LA48_0 >= ID && LA48_0 <= COMMAND) || LA48_0 == 43 || LA48_0 == 45 || LA48_0 == 52 || LA48_0 == 54 || LA48_0 == 58 || LA48_0 == 72 || (LA48_0 >= 74 && LA48_0 <= 75) || (LA48_0 >= 77 && LA48_0 <= 86)) )
            	    {
            	        alt48 = 1;
            	    }


            	    switch (alt48) 
            		{
            			case 1 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:359:6: tikzpath_element
            			    {
            			    	PushFollow(FOLLOW_tikzpath_element_in_tikzcoordinate_ext2050);
            			    	tikzpath_element182 = tikzpath_element();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikzpath_element.Add(tikzpath_element182.Tree);

            			    }
            			    break;

            			default:
            			    goto loop48;
            	    }
            	} while (true);

            	loop48:
            		;	// Stops C# compiler whining that label 'loop48' has no statements

            	PushFollow(FOLLOW_semicolon_end_in_tikzcoordinate_ext2053);
            	semicolon_end183 = semicolon_end();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_semicolon_end.Add(semicolon_end183.Tree);


            	// AST REWRITE
            	// elements:          tikzcoordinate_core3, coordinate_start, semicolon_end, tikzcoordinate_core1, tikzpath_element, tikzcoordinate_core2
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 360:6: -> ^( IM_PATH coordinate_start ( tikzcoordinate_core3 )? ( tikzcoordinate_core2 )? ( tikzcoordinate_core1 )? ( tikzpath_element )* semicolon_end )
            	{
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:360:9: ^( IM_PATH coordinate_start ( tikzcoordinate_core3 )? ( tikzcoordinate_core2 )? ( tikzcoordinate_core1 )? ( tikzpath_element )* semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_coordinate_start.NextTree());
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:361:6: ( tikzcoordinate_core3 )?
            	    if ( stream_tikzcoordinate_core3.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzcoordinate_core3.NextTree());

            	    }
            	    stream_tikzcoordinate_core3.Reset();
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:362:6: ( tikzcoordinate_core2 )?
            	    if ( stream_tikzcoordinate_core2.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzcoordinate_core2.NextTree());

            	    }
            	    stream_tikzcoordinate_core2.Reset();
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:363:6: ( tikzcoordinate_core1 )?
            	    if ( stream_tikzcoordinate_core1.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzcoordinate_core1.NextTree());

            	    }
            	    stream_tikzcoordinate_core1.Reset();
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:364:6: ( tikzpath_element )*
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:366:1: tikzcoordinate_int : 'coordinate' ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? ;
    public simpletikzParser.tikzcoordinate_int_return tikzcoordinate_int() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_int_return retval = new simpletikzParser.tikzcoordinate_int_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal184 = null;
        simpletikzParser.tikzcoordinate_core3_return tikzcoordinate_core3185 = default(simpletikzParser.tikzcoordinate_core3_return);

        simpletikzParser.tikzcoordinate_core2_return tikzcoordinate_core2186 = default(simpletikzParser.tikzcoordinate_core2_return);

        simpletikzParser.tikzcoordinate_core1_return tikzcoordinate_core1187 = default(simpletikzParser.tikzcoordinate_core1_return);


        object string_literal184_tree=null;

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:367:2: ( 'coordinate' ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )? )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:367:4: 'coordinate' ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal184=(IToken)Match(input,74,FOLLOW_74_in_tikzcoordinate_int2113); if (state.failed) return retval;
            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:367:18: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?
            	int alt49 = 4;
            	alt49 = dfa49.Predict(input);
            	switch (alt49) 
            	{
            	    case 1 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:367:20: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        {
            	        	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:367:20: ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 )
            	        	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:367:21: ( tikzcoordinate_core3 )=> tikzcoordinate_core3
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_int2124);
            	        		tikzcoordinate_core3185 = tikzcoordinate_core3();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_core3185.Tree);

            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:368:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        {
            	        	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:368:11: ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 )
            	        	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:368:12: ( tikzcoordinate_core2 )=> tikzcoordinate_core2
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_int2143);
            	        		tikzcoordinate_core2186 = tikzcoordinate_core2();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_core2186.Tree);

            	        	}


            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:369:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        {
            	        	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:369:11: ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 )
            	        	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:369:12: ( tikzcoordinate_core1 )=> tikzcoordinate_core1
            	        	{
            	        		PushFollow(FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_int2163);
            	        		tikzcoordinate_core1187 = tikzcoordinate_core1();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikzcoordinate_core1187.Tree);

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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:371:1: tikznode_int : 'node' tikznode_core ;
    public simpletikzParser.tikznode_int_return tikznode_int() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_int_return retval = new simpletikzParser.tikznode_int_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal188 = null;
        simpletikzParser.tikznode_core_return tikznode_core189 = default(simpletikzParser.tikznode_core_return);


        object string_literal188_tree=null;

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:372:2: ( 'node' tikznode_core )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:372:4: 'node' tikznode_core
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal188=(IToken)Match(input,75,FOLLOW_75_in_tikznode_int2179); if (state.failed) return retval;
            	PushFollow(FOLLOW_tikznode_core_in_tikznode_int2182);
            	tikznode_core189 = tikznode_core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikznode_core189.Tree);

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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:374:1: tikznode_core : ( tikznode_decorator )* tikzstring -> ^( IM_NODE ( tikznode_decorator )* tikzstring ) ;
    public simpletikzParser.tikznode_core_return tikznode_core() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_core_return retval = new simpletikzParser.tikznode_core_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator190 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikzstring_return tikzstring191 = default(simpletikzParser.tikzstring_return);


        RewriteRuleSubtreeStream stream_tikzstring = new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:375:2: ( ( tikznode_decorator )* tikzstring -> ^( IM_NODE ( tikznode_decorator )* tikzstring ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:375:4: ( tikznode_decorator )* tikzstring
            {
            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:375:4: ( tikznode_decorator )*
            	do 
            	{
            	    int alt50 = 2;
            	    int LA50_0 = input.LA(1);

            	    if ( (LA50_0 == 52 || LA50_0 == 54 || LA50_0 == 76) )
            	    {
            	        alt50 = 1;
            	    }


            	    switch (alt50) 
            		{
            			case 1 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:375:4: tikznode_decorator
            			    {
            			    	PushFollow(FOLLOW_tikznode_decorator_in_tikznode_core2192);
            			    	tikznode_decorator190 = tikznode_decorator();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikznode_decorator.Add(tikznode_decorator190.Tree);

            			    }
            			    break;

            			default:
            			    goto loop50;
            	    }
            	} while (true);

            	loop50:
            		;	// Stops C# compiler whining that label 'loop50' has no statements

            	PushFollow(FOLLOW_tikzstring_in_tikznode_core2195);
            	tikzstring191 = tikzstring();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikzstring.Add(tikzstring191.Tree);


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
            	// 375:36: -> ^( IM_NODE ( tikznode_decorator )* tikzstring )
            	{
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:375:39: ^( IM_NODE ( tikznode_decorator )* tikzstring )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NODE, "IM_NODE"), root_1);

            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:375:49: ( tikznode_decorator )*
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:378:1: tikzcoordinate_core3 : tikznode_decorator tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator ) ;
    public simpletikzParser.tikzcoordinate_core3_return tikzcoordinate_core3() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_core3_return retval = new simpletikzParser.tikzcoordinate_core3_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator192 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikznode_decorator_return tikznode_decorator193 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikznode_decorator_return tikznode_decorator194 = default(simpletikzParser.tikznode_decorator_return);


        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:379:2: ( tikznode_decorator tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:379:6: tikznode_decorator tikznode_decorator tikznode_decorator
            {
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core32220);
            	tikznode_decorator192 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_decorator.Add(tikznode_decorator192.Tree);
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core32222);
            	tikznode_decorator193 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_decorator.Add(tikznode_decorator193.Tree);
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core32224);
            	tikznode_decorator194 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_decorator.Add(tikznode_decorator194.Tree);


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
            	// 379:64: -> ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator )
            	{
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:379:67: ^( IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator )
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:383:1: tikzcoordinate_core2 : tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator ) ;
    public simpletikzParser.tikzcoordinate_core2_return tikzcoordinate_core2() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_core2_return retval = new simpletikzParser.tikzcoordinate_core2_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator195 = default(simpletikzParser.tikznode_decorator_return);

        simpletikzParser.tikznode_decorator_return tikznode_decorator196 = default(simpletikzParser.tikznode_decorator_return);


        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:384:2: ( tikznode_decorator tikznode_decorator -> ^( IM_NODE tikznode_decorator tikznode_decorator ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:385:4: tikznode_decorator tikznode_decorator
            {
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core22258);
            	tikznode_decorator195 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_decorator.Add(tikznode_decorator195.Tree);
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core22260);
            	tikznode_decorator196 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_decorator.Add(tikznode_decorator196.Tree);


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
            	// 385:47: -> ^( IM_NODE tikznode_decorator tikznode_decorator )
            	{
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:385:50: ^( IM_NODE tikznode_decorator tikznode_decorator )
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:388:1: tikzcoordinate_core1 : tikznode_decorator -> ^( IM_NODE tikznode_decorator ) ;
    public simpletikzParser.tikzcoordinate_core1_return tikzcoordinate_core1() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzcoordinate_core1_return retval = new simpletikzParser.tikzcoordinate_core1_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator197 = default(simpletikzParser.tikznode_decorator_return);


        RewriteRuleSubtreeStream stream_tikznode_decorator = new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:389:2: ( tikznode_decorator -> ^( IM_NODE tikznode_decorator ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:390:4: tikznode_decorator
            {
            	PushFollow(FOLLOW_tikznode_decorator_in_tikzcoordinate_core12293);
            	tikznode_decorator197 = tikznode_decorator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_tikznode_decorator.Add(tikznode_decorator197.Tree);


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
            	// 390:31: -> ^( IM_NODE tikznode_decorator )
            	{
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:390:34: ^( IM_NODE tikznode_decorator )
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:397:1: tikznode_decorator : ( nodename | 'at' COMMAND | 'at' coord | tikz_options_dontcare );
    public simpletikzParser.tikznode_decorator_return tikznode_decorator() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_decorator_return retval = new simpletikzParser.tikznode_decorator_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal199 = null;
        IToken COMMAND200 = null;
        IToken string_literal201 = null;
        simpletikzParser.nodename_return nodename198 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_return coord202 = default(simpletikzParser.coord_return);

        simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare203 = default(simpletikzParser.tikz_options_dontcare_return);


        object string_literal199_tree=null;
        object COMMAND200_tree=null;
        object string_literal201_tree=null;

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:398:2: ( nodename | 'at' COMMAND | 'at' coord | tikz_options_dontcare )
            int alt51 = 4;
            switch ( input.LA(1) ) 
            {
            case 52:
            	{
                alt51 = 1;
                }
                break;
            case 76:
            	{
                int LA51_2 = input.LA(2);

                if ( (LA51_2 == COMMAND) )
                {
                    alt51 = 2;
                }
                else if ( (LA51_2 == 52 || (LA51_2 >= 84 && LA51_2 <= 85)) )
                {
                    alt51 = 3;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d51s2 =
                        new NoViableAltException("", 51, 2, input);

                    throw nvae_d51s2;
                }
                }
                break;
            case 54:
            	{
                alt51 = 4;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d51s0 =
            	        new NoViableAltException("", 51, 0, input);

            	    throw nvae_d51s0;
            }

            switch (alt51) 
            {
                case 1 :
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:398:6: nodename
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_nodename_in_tikznode_decorator2330);
                    	nodename198 = nodename();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, nodename198.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:399:5: 'at' COMMAND
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal199=(IToken)Match(input,76,FOLLOW_76_in_tikznode_decorator2337); if (state.failed) return retval;
                    	COMMAND200=(IToken)Match(input,COMMAND,FOLLOW_COMMAND_in_tikznode_decorator2340); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{COMMAND200_tree = (object)adaptor.Create(COMMAND200);
                    		adaptor.AddChild(root_0, COMMAND200_tree);
                    	}

                    }
                    break;
                case 3 :
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:400:5: 'at' coord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal201=(IToken)Match(input,76,FOLLOW_76_in_tikznode_decorator2346); if (state.failed) return retval;
                    	PushFollow(FOLLOW_coord_in_tikznode_decorator2349);
                    	coord202 = coord();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, coord202.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:401:5: tikz_options_dontcare
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_options_dontcare_in_tikznode_decorator2355);
                    	tikz_options_dontcare203 = tikz_options_dontcare();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tikz_options_dontcare203.Tree);

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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:403:1: tikz_options_dontcare : '[' ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* ']' -> ^( IM_OPTIONS ) ;
    public simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_options_dontcare_return retval = new simpletikzParser.tikz_options_dontcare_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal204 = null;
        IToken char_literal208 = null;
        simpletikzParser.no_rlbracket_return no_rlbracket205 = default(simpletikzParser.no_rlbracket_return);

        simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare206 = default(simpletikzParser.tikz_options_dontcare_return);

        simpletikzParser.no_rlbracket_return no_rlbracket207 = default(simpletikzParser.no_rlbracket_return);


        object char_literal204_tree=null;
        object char_literal208_tree=null;
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleSubtreeStream stream_tikz_options_dontcare = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options_dontcare");
        RewriteRuleSubtreeStream stream_no_rlbracket = new RewriteRuleSubtreeStream(adaptor,"rule no_rlbracket");
        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:404:2: ( '[' ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* ']' -> ^( IM_OPTIONS ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:404:4: '[' ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* ']'
            {
            	char_literal204=(IToken)Match(input,54,FOLLOW_54_in_tikz_options_dontcare2365); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_54.Add(char_literal204);

            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:404:8: ( no_rlbracket )*
            	do 
            	{
            	    int alt52 = 2;
            	    int LA52_0 = input.LA(1);

            	    if ( ((LA52_0 >= IM_PATH && LA52_0 <= 53) || (LA52_0 >= 56 && LA52_0 <= 89)) )
            	    {
            	        alt52 = 1;
            	    }


            	    switch (alt52) 
            		{
            			case 1 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:404:8: no_rlbracket
            			    {
            			    	PushFollow(FOLLOW_no_rlbracket_in_tikz_options_dontcare2367);
            			    	no_rlbracket205 = no_rlbracket();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_no_rlbracket.Add(no_rlbracket205.Tree);

            			    }
            			    break;

            			default:
            			    goto loop52;
            	    }
            	} while (true);

            	loop52:
            		;	// Stops C# compiler whining that label 'loop52' has no statements

            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:404:22: ( tikz_options_dontcare ( no_rlbracket )* )*
            	do 
            	{
            	    int alt54 = 2;
            	    int LA54_0 = input.LA(1);

            	    if ( (LA54_0 == 54) )
            	    {
            	        alt54 = 1;
            	    }


            	    switch (alt54) 
            		{
            			case 1 :
            			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:404:23: tikz_options_dontcare ( no_rlbracket )*
            			    {
            			    	PushFollow(FOLLOW_tikz_options_dontcare_in_tikz_options_dontcare2371);
            			    	tikz_options_dontcare206 = tikz_options_dontcare();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_tikz_options_dontcare.Add(tikz_options_dontcare206.Tree);
            			    	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:404:45: ( no_rlbracket )*
            			    	do 
            			    	{
            			    	    int alt53 = 2;
            			    	    int LA53_0 = input.LA(1);

            			    	    if ( ((LA53_0 >= IM_PATH && LA53_0 <= 53) || (LA53_0 >= 56 && LA53_0 <= 89)) )
            			    	    {
            			    	        alt53 = 1;
            			    	    }


            			    	    switch (alt53) 
            			    		{
            			    			case 1 :
            			    			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:404:45: no_rlbracket
            			    			    {
            			    			    	PushFollow(FOLLOW_no_rlbracket_in_tikz_options_dontcare2373);
            			    			    	no_rlbracket207 = no_rlbracket();
            			    			    	state.followingStackPointer--;
            			    			    	if (state.failed) return retval;
            			    			    	if ( state.backtracking==0 ) stream_no_rlbracket.Add(no_rlbracket207.Tree);

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop53;
            			    	    }
            			    	} while (true);

            			    	loop53:
            			    		;	// Stops C# compiler whining that label 'loop53' has no statements


            			    }
            			    break;

            			default:
            			    goto loop54;
            	    }
            	} while (true);

            	loop54:
            		;	// Stops C# compiler whining that label 'loop54' has no statements

            	char_literal208=(IToken)Match(input,55,FOLLOW_55_in_tikz_options_dontcare2378); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_55.Add(char_literal208);



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
            	// 404:65: -> ^( IM_OPTIONS )
            	{
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:404:68: ^( IM_OPTIONS )
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:406:1: no_rlbracket : ~ ( '[' | ']' ) ;
    public simpletikzParser.no_rlbracket_return no_rlbracket() // throws RecognitionException [1]
    {   
        simpletikzParser.no_rlbracket_return retval = new simpletikzParser.no_rlbracket_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set209 = null;

        object set209_tree=null;

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:407:2: (~ ( '[' | ']' ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:407:4: ~ ( '[' | ']' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set209 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IM_PATH && input.LA(1) <= 53) || (input.LA(1) >= 56 && input.LA(1) <= 89) ) 
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:409:1: nodename : '(' idd ')' -> ^( IM_NODENAME idd ) ;
    public simpletikzParser.nodename_return nodename() // throws RecognitionException [1]
    {   
        simpletikzParser.nodename_return retval = new simpletikzParser.nodename_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal210 = null;
        IToken char_literal212 = null;
        simpletikzParser.idd_return idd211 = default(simpletikzParser.idd_return);


        object char_literal210_tree=null;
        object char_literal212_tree=null;
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:410:2: ( '(' idd ')' -> ^( IM_NODENAME idd ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:410:4: '(' idd ')'
            {
            	char_literal210=(IToken)Match(input,52,FOLLOW_52_in_nodename2413); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_52.Add(char_literal210);

            	PushFollow(FOLLOW_idd_in_nodename2415);
            	idd211 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_idd.Add(idd211.Tree);
            	char_literal212=(IToken)Match(input,53,FOLLOW_53_in_nodename2417); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_53.Add(char_literal212);



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
            	// 410:17: -> ^( IM_NODENAME idd )
            	{
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:410:20: ^( IM_NODENAME idd )
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:416:1: circle : ( 'circle' | 'ellipse' ) ( ( size )=> size )? ->;
    public simpletikzParser.circle_return circle() // throws RecognitionException [1]
    {   
        simpletikzParser.circle_return retval = new simpletikzParser.circle_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal213 = null;
        IToken string_literal214 = null;
        simpletikzParser.size_return size215 = default(simpletikzParser.size_return);


        object string_literal213_tree=null;
        object string_literal214_tree=null;
        RewriteRuleTokenStream stream_78 = new RewriteRuleTokenStream(adaptor,"token 78");
        RewriteRuleTokenStream stream_77 = new RewriteRuleTokenStream(adaptor,"token 77");
        RewriteRuleSubtreeStream stream_size = new RewriteRuleSubtreeStream(adaptor,"rule size");
        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:417:2: ( ( 'circle' | 'ellipse' ) ( ( size )=> size )? ->)
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:417:4: ( 'circle' | 'ellipse' ) ( ( size )=> size )?
            {
            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:417:4: ( 'circle' | 'ellipse' )
            	int alt55 = 2;
            	int LA55_0 = input.LA(1);

            	if ( (LA55_0 == 77) )
            	{
            	    alt55 = 1;
            	}
            	else if ( (LA55_0 == 78) )
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
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:417:5: 'circle'
            	        {
            	        	string_literal213=(IToken)Match(input,77,FOLLOW_77_in_circle2442); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_77.Add(string_literal213);


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:417:16: 'ellipse'
            	        {
            	        	string_literal214=(IToken)Match(input,78,FOLLOW_78_in_circle2446); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_78.Add(string_literal214);


            	        }
            	        break;

            	}

            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:417:27: ( ( size )=> size )?
            	int alt56 = 2;
            	alt56 = dfa56.Predict(input);
            	switch (alt56) 
            	{
            	    case 1 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:417:28: ( size )=> size
            	        {
            	        	PushFollow(FOLLOW_size_in_circle2455);
            	        	size215 = size();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_size.Add(size215.Tree);

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
            	// 417:44: ->
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:419:1: arc : ( 'arc' ( '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')' ) -> ^( IM_ARC ( numberunitorvariable )+ ( numberunit )? ) | 'arc' ( '(' coord_part ':' coord_part ':' coord_part ( 'and' numberunit )? ')' ) -> ^( IM_ARC ( coord_part )+ ( numberunit )? ) | 'arc' tikz_options -> ^( IM_DONTCARE ) );
    public simpletikzParser.arc_return arc() // throws RecognitionException [1]
    {   
        simpletikzParser.arc_return retval = new simpletikzParser.arc_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal216 = null;
        IToken char_literal217 = null;
        IToken char_literal219 = null;
        IToken char_literal221 = null;
        IToken string_literal223 = null;
        IToken char_literal225 = null;
        IToken string_literal226 = null;
        IToken char_literal227 = null;
        IToken char_literal229 = null;
        IToken char_literal231 = null;
        IToken string_literal233 = null;
        IToken char_literal235 = null;
        IToken string_literal236 = null;
        simpletikzParser.numberunitorvariable_return numberunitorvariable218 = default(simpletikzParser.numberunitorvariable_return);

        simpletikzParser.numberunitorvariable_return numberunitorvariable220 = default(simpletikzParser.numberunitorvariable_return);

        simpletikzParser.numberunitorvariable_return numberunitorvariable222 = default(simpletikzParser.numberunitorvariable_return);

        simpletikzParser.numberunit_return numberunit224 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_part_return coord_part228 = default(simpletikzParser.coord_part_return);

        simpletikzParser.coord_part_return coord_part230 = default(simpletikzParser.coord_part_return);

        simpletikzParser.coord_part_return coord_part232 = default(simpletikzParser.coord_part_return);

        simpletikzParser.numberunit_return numberunit234 = default(simpletikzParser.numberunit_return);

        simpletikzParser.tikz_options_return tikz_options237 = default(simpletikzParser.tikz_options_return);


        object string_literal216_tree=null;
        object char_literal217_tree=null;
        object char_literal219_tree=null;
        object char_literal221_tree=null;
        object string_literal223_tree=null;
        object char_literal225_tree=null;
        object string_literal226_tree=null;
        object char_literal227_tree=null;
        object char_literal229_tree=null;
        object char_literal231_tree=null;
        object string_literal233_tree=null;
        object char_literal235_tree=null;
        object string_literal236_tree=null;
        RewriteRuleTokenStream stream_48 = new RewriteRuleTokenStream(adaptor,"token 48");
        RewriteRuleTokenStream stream_79 = new RewriteRuleTokenStream(adaptor,"token 79");
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleTokenStream stream_73 = new RewriteRuleTokenStream(adaptor,"token 73");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_numberunitorvariable = new RewriteRuleSubtreeStream(adaptor,"rule numberunitorvariable");
        RewriteRuleSubtreeStream stream_coord_part = new RewriteRuleSubtreeStream(adaptor,"rule coord_part");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:420:2: ( 'arc' ( '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')' ) -> ^( IM_ARC ( numberunitorvariable )+ ( numberunit )? ) | 'arc' ( '(' coord_part ':' coord_part ':' coord_part ( 'and' numberunit )? ')' ) -> ^( IM_ARC ( coord_part )+ ( numberunit )? ) | 'arc' tikz_options -> ^( IM_DONTCARE ) )
            int alt59 = 3;
            alt59 = dfa59.Predict(input);
            switch (alt59) 
            {
                case 1 :
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:420:4: 'arc' ( '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')' )
                    {
                    	string_literal216=(IToken)Match(input,79,FOLLOW_79_in_arc2470); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_79.Add(string_literal216);

                    	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:420:10: ( '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')' )
                    	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:420:11: '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')'
                    	{
                    		char_literal217=(IToken)Match(input,52,FOLLOW_52_in_arc2473); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_52.Add(char_literal217);

                    		PushFollow(FOLLOW_numberunitorvariable_in_arc2475);
                    		numberunitorvariable218 = numberunitorvariable();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_numberunitorvariable.Add(numberunitorvariable218.Tree);
                    		char_literal219=(IToken)Match(input,48,FOLLOW_48_in_arc2477); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_48.Add(char_literal219);

                    		PushFollow(FOLLOW_numberunitorvariable_in_arc2479);
                    		numberunitorvariable220 = numberunitorvariable();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_numberunitorvariable.Add(numberunitorvariable220.Tree);
                    		char_literal221=(IToken)Match(input,48,FOLLOW_48_in_arc2481); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_48.Add(char_literal221);

                    		PushFollow(FOLLOW_numberunitorvariable_in_arc2483);
                    		numberunitorvariable222 = numberunitorvariable();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_numberunitorvariable.Add(numberunitorvariable222.Tree);
                    		// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:420:86: ( 'and' numberunit )?
                    		int alt57 = 2;
                    		int LA57_0 = input.LA(1);

                    		if ( (LA57_0 == 73) )
                    		{
                    		    alt57 = 1;
                    		}
                    		switch (alt57) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:420:87: 'and' numberunit
                    		        {
                    		        	string_literal223=(IToken)Match(input,73,FOLLOW_73_in_arc2486); if (state.failed) return retval; 
                    		        	if ( state.backtracking==0 ) stream_73.Add(string_literal223);

                    		        	PushFollow(FOLLOW_numberunit_in_arc2488);
                    		        	numberunit224 = numberunit();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_numberunit.Add(numberunit224.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal225=(IToken)Match(input,53,FOLLOW_53_in_arc2492); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_53.Add(char_literal225);


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
                    	// 420:111: -> ^( IM_ARC ( numberunitorvariable )+ ( numberunit )? )
                    	{
                    	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:420:114: ^( IM_ARC ( numberunitorvariable )+ ( numberunit )? )
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
                    	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:420:145: ( numberunit )?
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
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:421:4: 'arc' ( '(' coord_part ':' coord_part ':' coord_part ( 'and' numberunit )? ')' )
                    {
                    	string_literal226=(IToken)Match(input,79,FOLLOW_79_in_arc2510); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_79.Add(string_literal226);

                    	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:421:10: ( '(' coord_part ':' coord_part ':' coord_part ( 'and' numberunit )? ')' )
                    	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:421:11: '(' coord_part ':' coord_part ':' coord_part ( 'and' numberunit )? ')'
                    	{
                    		char_literal227=(IToken)Match(input,52,FOLLOW_52_in_arc2513); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_52.Add(char_literal227);

                    		PushFollow(FOLLOW_coord_part_in_arc2515);
                    		coord_part228 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_part.Add(coord_part228.Tree);
                    		char_literal229=(IToken)Match(input,48,FOLLOW_48_in_arc2517); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_48.Add(char_literal229);

                    		PushFollow(FOLLOW_coord_part_in_arc2519);
                    		coord_part230 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_part.Add(coord_part230.Tree);
                    		char_literal231=(IToken)Match(input,48,FOLLOW_48_in_arc2521); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_48.Add(char_literal231);

                    		PushFollow(FOLLOW_coord_part_in_arc2523);
                    		coord_part232 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_part.Add(coord_part232.Tree);
                    		// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:421:56: ( 'and' numberunit )?
                    		int alt58 = 2;
                    		int LA58_0 = input.LA(1);

                    		if ( (LA58_0 == 73) )
                    		{
                    		    alt58 = 1;
                    		}
                    		switch (alt58) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:421:57: 'and' numberunit
                    		        {
                    		        	string_literal233=(IToken)Match(input,73,FOLLOW_73_in_arc2526); if (state.failed) return retval; 
                    		        	if ( state.backtracking==0 ) stream_73.Add(string_literal233);

                    		        	PushFollow(FOLLOW_numberunit_in_arc2528);
                    		        	numberunit234 = numberunit();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_numberunit.Add(numberunit234.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal235=(IToken)Match(input,53,FOLLOW_53_in_arc2532); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_53.Add(char_literal235);


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
                    	// 421:81: -> ^( IM_ARC ( coord_part )+ ( numberunit )? )
                    	{
                    	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:421:84: ^( IM_ARC ( coord_part )+ ( numberunit )? )
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
                    	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:421:105: ( numberunit )?
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
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:422:4: 'arc' tikz_options
                    {
                    	string_literal236=(IToken)Match(input,79,FOLLOW_79_in_arc2550); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_79.Add(string_literal236);

                    	PushFollow(FOLLOW_tikz_options_in_arc2552);
                    	tikz_options237 = tikz_options();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_tikz_options.Add(tikz_options237.Tree);


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
                    	// 422:23: -> ^( IM_DONTCARE )
                    	{
                    	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:422:25: ^( IM_DONTCARE )
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:429:1: size : '(' numberunit ( 'and' numberunit )? ')' -> ^( IM_SIZE ( numberunit )* ) ;
    public simpletikzParser.size_return size() // throws RecognitionException [1]
    {   
        simpletikzParser.size_return retval = new simpletikzParser.size_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal238 = null;
        IToken string_literal240 = null;
        IToken char_literal242 = null;
        simpletikzParser.numberunit_return numberunit239 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit241 = default(simpletikzParser.numberunit_return);


        object char_literal238_tree=null;
        object string_literal240_tree=null;
        object char_literal242_tree=null;
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleTokenStream stream_73 = new RewriteRuleTokenStream(adaptor,"token 73");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:430:2: ( '(' numberunit ( 'and' numberunit )? ')' -> ^( IM_SIZE ( numberunit )* ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:430:6: '(' numberunit ( 'and' numberunit )? ')'
            {
            	char_literal238=(IToken)Match(input,52,FOLLOW_52_in_size2577); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_52.Add(char_literal238);

            	PushFollow(FOLLOW_numberunit_in_size2579);
            	numberunit239 = numberunit();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_numberunit.Add(numberunit239.Tree);
            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:430:21: ( 'and' numberunit )?
            	int alt60 = 2;
            	int LA60_0 = input.LA(1);

            	if ( (LA60_0 == 73) )
            	{
            	    alt60 = 1;
            	}
            	switch (alt60) 
            	{
            	    case 1 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:430:22: 'and' numberunit
            	        {
            	        	string_literal240=(IToken)Match(input,73,FOLLOW_73_in_size2582); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_73.Add(string_literal240);

            	        	PushFollow(FOLLOW_numberunit_in_size2584);
            	        	numberunit241 = numberunit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_numberunit.Add(numberunit241.Tree);

            	        }
            	        break;

            	}

            	char_literal242=(IToken)Match(input,53,FOLLOW_53_in_size2588); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_53.Add(char_literal242);



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
            	// 430:46: -> ^( IM_SIZE ( numberunit )* )
            	{
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:430:49: ^( IM_SIZE ( numberunit )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_SIZE, "IM_SIZE"), root_1);

            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:430:59: ( numberunit )*
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:437:1: coord_nodename : '(' ( tikz_options )? idd ')' -> ^( IM_NODENAME idd ( tikz_options )? ) ;
    public simpletikzParser.coord_nodename_return coord_nodename() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_nodename_return retval = new simpletikzParser.coord_nodename_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal243 = null;
        IToken char_literal246 = null;
        simpletikzParser.tikz_options_return tikz_options244 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.idd_return idd245 = default(simpletikzParser.idd_return);


        object char_literal243_tree=null;
        object char_literal246_tree=null;
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:438:2: ( '(' ( tikz_options )? idd ')' -> ^( IM_NODENAME idd ( tikz_options )? ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:438:4: '(' ( tikz_options )? idd ')'
            {
            	char_literal243=(IToken)Match(input,52,FOLLOW_52_in_coord_nodename2616); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_52.Add(char_literal243);

            	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:438:8: ( tikz_options )?
            	int alt61 = 2;
            	int LA61_0 = input.LA(1);

            	if ( (LA61_0 == 54) )
            	{
            	    alt61 = 1;
            	}
            	switch (alt61) 
            	{
            	    case 1 :
            	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:438:8: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_coord_nodename2618);
            	        	tikz_options244 = tikz_options();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_tikz_options.Add(tikz_options244.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_idd_in_coord_nodename2621);
            	idd245 = idd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_idd.Add(idd245.Tree);
            	char_literal246=(IToken)Match(input,53,FOLLOW_53_in_coord_nodename2624); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_53.Add(char_literal246);



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
            	// 438:32: -> ^( IM_NODENAME idd ( tikz_options )? )
            	{
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:438:35: ^( IM_NODENAME idd ( tikz_options )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NODENAME, "IM_NODENAME"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:438:53: ( tikz_options )?
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:439:1: coord : ( ( ( coord_modifier )? coord_nodename ) -> ^( IM_COORD ( coord_modifier )? coord_nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) );
    public simpletikzParser.coord_return coord() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_return retval = new simpletikzParser.coord_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal250 = null;
        IToken char_literal254 = null;
        IToken char_literal256 = null;
        IToken char_literal260 = null;
        simpletikzParser.coord_modifier_return coord_modifier247 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.coord_nodename_return coord_nodename248 = default(simpletikzParser.coord_nodename_return);

        simpletikzParser.coord_modifier_return coord_modifier249 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.numberunit_return numberunit251 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_sep_return coord_sep252 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.numberunit_return numberunit253 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_modifier_return coord_modifier255 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.coord_part_return coord_part257 = default(simpletikzParser.coord_part_return);

        simpletikzParser.coord_sep_return coord_sep258 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.coord_part_return coord_part259 = default(simpletikzParser.coord_part_return);


        object char_literal250_tree=null;
        object char_literal254_tree=null;
        object char_literal256_tree=null;
        object char_literal260_tree=null;
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_coord_nodename = new RewriteRuleSubtreeStream(adaptor,"rule coord_nodename");
        RewriteRuleSubtreeStream stream_coord_part = new RewriteRuleSubtreeStream(adaptor,"rule coord_part");
        RewriteRuleSubtreeStream stream_coord_sep = new RewriteRuleSubtreeStream(adaptor,"rule coord_sep");
        RewriteRuleSubtreeStream stream_coord_modifier = new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:440:2: ( ( ( coord_modifier )? coord_nodename ) -> ^( IM_COORD ( coord_modifier )? coord_nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) )
            int alt65 = 3;
            alt65 = dfa65.Predict(input);
            switch (alt65) 
            {
                case 1 :
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:440:6: ( ( coord_modifier )? coord_nodename )
                    {
                    	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:440:6: ( ( coord_modifier )? coord_nodename )
                    	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:440:8: ( coord_modifier )? coord_nodename
                    	{
                    		// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:440:8: ( coord_modifier )?
                    		int alt62 = 2;
                    		int LA62_0 = input.LA(1);

                    		if ( ((LA62_0 >= 84 && LA62_0 <= 85)) )
                    		{
                    		    alt62 = 1;
                    		}
                    		switch (alt62) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:440:8: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord2650);
                    		        	coord_modifier247 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_coord_modifier.Add(coord_modifier247.Tree);

                    		        }
                    		        break;

                    		}

                    		PushFollow(FOLLOW_coord_nodename_in_coord2653);
                    		coord_nodename248 = coord_nodename();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_nodename.Add(coord_nodename248.Tree);

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
                    	// 440:44: -> ^( IM_COORD ( coord_modifier )? coord_nodename )
                    	{
                    	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:440:47: ^( IM_COORD ( coord_modifier )? coord_nodename )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:440:58: ( coord_modifier )?
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
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:441:5: ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' )
                    {
                    	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:441:5: ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' )
                    	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:441:7: ( coord_modifier )? '(' numberunit coord_sep numberunit ')'
                    	{
                    		// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:441:7: ( coord_modifier )?
                    		int alt63 = 2;
                    		int LA63_0 = input.LA(1);

                    		if ( ((LA63_0 >= 84 && LA63_0 <= 85)) )
                    		{
                    		    alt63 = 1;
                    		}
                    		switch (alt63) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:441:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord2679);
                    		        	coord_modifier249 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_coord_modifier.Add(coord_modifier249.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal250=(IToken)Match(input,52,FOLLOW_52_in_coord2682); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_52.Add(char_literal250);

                    		PushFollow(FOLLOW_numberunit_in_coord2684);
                    		numberunit251 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_numberunit.Add(numberunit251.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord2686);
                    		coord_sep252 = coord_sep();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_sep.Add(coord_sep252.Tree);
                    		PushFollow(FOLLOW_numberunit_in_coord2688);
                    		numberunit253 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_numberunit.Add(numberunit253.Tree);
                    		char_literal254=(IToken)Match(input,53,FOLLOW_53_in_coord2690); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_53.Add(char_literal254);


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
                    	// 441:65: -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep )
                    	{
                    	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:441:68: ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:441:79: ( coord_modifier )?
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
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:442:5: ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' )
                    {
                    	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:442:5: ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' )
                    	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:442:7: ( coord_modifier )? '(' coord_part coord_sep coord_part ')'
                    	{
                    		// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:442:7: ( coord_modifier )?
                    		int alt64 = 2;
                    		int LA64_0 = input.LA(1);

                    		if ( ((LA64_0 >= 84 && LA64_0 <= 85)) )
                    		{
                    		    alt64 = 1;
                    		}
                    		switch (alt64) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:442:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord2714);
                    		        	coord_modifier255 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_coord_modifier.Add(coord_modifier255.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal256=(IToken)Match(input,52,FOLLOW_52_in_coord2717); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_52.Add(char_literal256);

                    		PushFollow(FOLLOW_coord_part_in_coord2719);
                    		coord_part257 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_part.Add(coord_part257.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord2721);
                    		coord_sep258 = coord_sep();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_sep.Add(coord_sep258.Tree);
                    		PushFollow(FOLLOW_coord_part_in_coord2723);
                    		coord_part259 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_part.Add(coord_part259.Tree);
                    		char_literal260=(IToken)Match(input,53,FOLLOW_53_in_coord2725); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_53.Add(char_literal260);


                    	}



                    	// AST REWRITE
                    	// elements:          coord_part, coord_sep, coord_modifier
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 442:65: -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep )
                    	{
                    	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:442:68: ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:442:79: ( coord_modifier )?
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:444:1: coord_nooption : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) );
    public simpletikzParser.coord_nooption_return coord_nooption() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_nooption_return retval = new simpletikzParser.coord_nooption_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal263 = null;
        IToken char_literal267 = null;
        IToken char_literal269 = null;
        IToken char_literal273 = null;
        simpletikzParser.nodename_return nodename261 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_modifier_return coord_modifier262 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.numberunit_return numberunit264 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_sep_return coord_sep265 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.numberunit_return numberunit266 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_modifier_return coord_modifier268 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.coord_part_return coord_part270 = default(simpletikzParser.coord_part_return);

        simpletikzParser.coord_sep_return coord_sep271 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.coord_part_return coord_part272 = default(simpletikzParser.coord_part_return);


        object char_literal263_tree=null;
        object char_literal267_tree=null;
        object char_literal269_tree=null;
        object char_literal273_tree=null;
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_coord_part = new RewriteRuleSubtreeStream(adaptor,"rule coord_part");
        RewriteRuleSubtreeStream stream_coord_sep = new RewriteRuleSubtreeStream(adaptor,"rule coord_sep");
        RewriteRuleSubtreeStream stream_nodename = new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        RewriteRuleSubtreeStream stream_coord_modifier = new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:445:2: ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) )
            int alt68 = 3;
            alt68 = dfa68.Predict(input);
            switch (alt68) 
            {
                case 1 :
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:445:6: nodename
                    {
                    	PushFollow(FOLLOW_nodename_in_coord_nooption2754);
                    	nodename261 = nodename();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_nodename.Add(nodename261.Tree);


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
                    	// 445:22: -> ^( IM_COORD nodename )
                    	{
                    	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:445:25: ^( IM_COORD nodename )
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
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:446:5: ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' )
                    {
                    	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:446:5: ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' )
                    	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:446:7: ( coord_modifier )? '(' numberunit coord_sep numberunit ')'
                    	{
                    		// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:446:7: ( coord_modifier )?
                    		int alt66 = 2;
                    		int LA66_0 = input.LA(1);

                    		if ( ((LA66_0 >= 84 && LA66_0 <= 85)) )
                    		{
                    		    alt66 = 1;
                    		}
                    		switch (alt66) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:446:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord_nooption2778);
                    		        	coord_modifier262 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_coord_modifier.Add(coord_modifier262.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal263=(IToken)Match(input,52,FOLLOW_52_in_coord_nooption2781); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_52.Add(char_literal263);

                    		PushFollow(FOLLOW_numberunit_in_coord_nooption2783);
                    		numberunit264 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_numberunit.Add(numberunit264.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord_nooption2785);
                    		coord_sep265 = coord_sep();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_sep.Add(coord_sep265.Tree);
                    		PushFollow(FOLLOW_numberunit_in_coord_nooption2787);
                    		numberunit266 = numberunit();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_numberunit.Add(numberunit266.Tree);
                    		char_literal267=(IToken)Match(input,53,FOLLOW_53_in_coord_nooption2789); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_53.Add(char_literal267);


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
                    	// 446:65: -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep )
                    	{
                    	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:446:68: ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:446:79: ( coord_modifier )?
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
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:447:5: ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' )
                    {
                    	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:447:5: ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' )
                    	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:447:7: ( coord_modifier )? '(' coord_part coord_sep coord_part ')'
                    	{
                    		// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:447:7: ( coord_modifier )?
                    		int alt67 = 2;
                    		int LA67_0 = input.LA(1);

                    		if ( ((LA67_0 >= 84 && LA67_0 <= 85)) )
                    		{
                    		    alt67 = 1;
                    		}
                    		switch (alt67) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:447:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord_nooption2813);
                    		        	coord_modifier268 = coord_modifier();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( state.backtracking==0 ) stream_coord_modifier.Add(coord_modifier268.Tree);

                    		        }
                    		        break;

                    		}

                    		char_literal269=(IToken)Match(input,52,FOLLOW_52_in_coord_nooption2816); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_52.Add(char_literal269);

                    		PushFollow(FOLLOW_coord_part_in_coord_nooption2818);
                    		coord_part270 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_part.Add(coord_part270.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord_nooption2820);
                    		coord_sep271 = coord_sep();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_sep.Add(coord_sep271.Tree);
                    		PushFollow(FOLLOW_coord_part_in_coord_nooption2822);
                    		coord_part272 = coord_part();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking==0 ) stream_coord_part.Add(coord_part272.Tree);
                    		char_literal273=(IToken)Match(input,53,FOLLOW_53_in_coord_nooption2824); if (state.failed) return retval; 
                    		if ( state.backtracking==0 ) stream_53.Add(char_literal273);


                    	}



                    	// AST REWRITE
                    	// elements:          coord_sep, coord_part, coord_modifier
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 447:65: -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep )
                    	{
                    	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:447:68: ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:447:79: ( coord_modifier )?
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:456:1: coord_part : ( idd -> ^( IM_DONTCARE idd ) | '{' idd '}' -> ^( IM_DONTCARE '{' idd '}' ) | ( idd '=' numberunit ( ',' )? )+ -> ^( IM_DONTCARE ( idd '=' numberunit ( ',' )? )+ ) );
    public simpletikzParser.coord_part_return coord_part() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_part_return retval = new simpletikzParser.coord_part_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal275 = null;
        IToken char_literal277 = null;
        IToken char_literal279 = null;
        IToken char_literal281 = null;
        simpletikzParser.idd_return idd274 = default(simpletikzParser.idd_return);

        simpletikzParser.idd_return idd276 = default(simpletikzParser.idd_return);

        simpletikzParser.idd_return idd278 = default(simpletikzParser.idd_return);

        simpletikzParser.numberunit_return numberunit280 = default(simpletikzParser.numberunit_return);


        object char_literal275_tree=null;
        object char_literal277_tree=null;
        object char_literal279_tree=null;
        object char_literal281_tree=null;
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_47 = new RewriteRuleTokenStream(adaptor,"token 47");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:457:2: ( idd -> ^( IM_DONTCARE idd ) | '{' idd '}' -> ^( IM_DONTCARE '{' idd '}' ) | ( idd '=' numberunit ( ',' )? )+ -> ^( IM_DONTCARE ( idd '=' numberunit ( ',' )? )+ ) )
            int alt71 = 3;
            alt71 = dfa71.Predict(input);
            switch (alt71) 
            {
                case 1 :
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:457:4: idd
                    {
                    	PushFollow(FOLLOW_idd_in_coord_part2857);
                    	idd274 = idd();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_idd.Add(idd274.Tree);


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
                    	// 457:9: -> ^( IM_DONTCARE idd )
                    	{
                    	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:457:12: ^( IM_DONTCARE idd )
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
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:458:4: '{' idd '}'
                    {
                    	char_literal275=(IToken)Match(input,43,FOLLOW_43_in_coord_part2872); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_43.Add(char_literal275);

                    	PushFollow(FOLLOW_idd_in_coord_part2874);
                    	idd276 = idd();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_idd.Add(idd276.Tree);
                    	char_literal277=(IToken)Match(input,44,FOLLOW_44_in_coord_part2876); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_44.Add(char_literal277);



                    	// AST REWRITE
                    	// elements:          44, idd, 43
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 458:16: -> ^( IM_DONTCARE '{' idd '}' )
                    	{
                    	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:458:19: ^( IM_DONTCARE '{' idd '}' )
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
                    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:459:4: ( idd '=' numberunit ( ',' )? )+
                    {
                    	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:459:4: ( idd '=' numberunit ( ',' )? )+
                    	int cnt70 = 0;
                    	do 
                    	{
                    	    int alt70 = 2;
                    	    int LA70_0 = input.LA(1);

                    	    if ( (LA70_0 == 73) )
                    	    {
                    	        int LA70_2 = input.LA(2);

                    	        if ( ((LA70_2 >= IM_PATH && LA70_2 <= COMMAND) || (LA70_2 >= WS && LA70_2 <= 42) || (LA70_2 >= 45 && LA70_2 <= 46) || LA70_2 == 51 || (LA70_2 >= 57 && LA70_2 <= 89)) )
                    	        {
                    	            alt70 = 1;
                    	        }
                    	        else if ( ((LA70_2 >= FLOAT_WO_EXP && LA70_2 <= INT)) )
                    	        {
                    	            int LA70_4 = input.LA(3);

                    	            if ( ((LA70_4 >= 57 && LA70_4 <= 62)) )
                    	            {
                    	                int LA70_5 = input.LA(4);

                    	                if ( ((LA70_5 >= IM_PATH && LA70_5 <= 42) || (LA70_5 >= 45 && LA70_5 <= 46) || LA70_5 == 51 || (LA70_5 >= 57 && LA70_5 <= 89)) )
                    	                {
                    	                    alt70 = 1;
                    	                }


                    	            }
                    	            else if ( ((LA70_4 >= IM_PATH && LA70_4 <= 42) || (LA70_4 >= 45 && LA70_4 <= 46) || LA70_4 == 51 || (LA70_4 >= 63 && LA70_4 <= 89)) )
                    	            {
                    	                alt70 = 1;
                    	            }


                    	        }


                    	    }
                    	    else if ( ((LA70_0 >= IM_PATH && LA70_0 <= 42) || LA70_0 == 46 || LA70_0 == 51 || (LA70_0 >= 57 && LA70_0 <= 72) || (LA70_0 >= 74 && LA70_0 <= 89)) )
                    	    {
                    	        alt70 = 1;
                    	    }


                    	    switch (alt70) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:459:5: idd '=' numberunit ( ',' )?
                    			    {
                    			    	PushFollow(FOLLOW_idd_in_coord_part2894);
                    			    	idd278 = idd();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking==0 ) stream_idd.Add(idd278.Tree);
                    			    	char_literal279=(IToken)Match(input,45,FOLLOW_45_in_coord_part2896); if (state.failed) return retval; 
                    			    	if ( state.backtracking==0 ) stream_45.Add(char_literal279);

                    			    	PushFollow(FOLLOW_numberunit_in_coord_part2898);
                    			    	numberunit280 = numberunit();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking==0 ) stream_numberunit.Add(numberunit280.Tree);
                    			    	// C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:459:24: ( ',' )?
                    			    	int alt69 = 2;
                    			    	int LA69_0 = input.LA(1);

                    			    	if ( (LA69_0 == 47) )
                    			    	{
                    			    	    alt69 = 1;
                    			    	}
                    			    	switch (alt69) 
                    			    	{
                    			    	    case 1 :
                    			    	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:459:24: ','
                    			    	        {
                    			    	        	char_literal281=(IToken)Match(input,47,FOLLOW_47_in_coord_part2900); if (state.failed) return retval; 
                    			    	        	if ( state.backtracking==0 ) stream_47.Add(char_literal281);


                    			    	        }
                    			    	        break;

                    			    	}


                    			    }
                    			    break;

                    			default:
                    			    if ( cnt70 >= 1 ) goto loop70;
                    			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    		            EarlyExitException eee =
                    		                new EarlyExitException(70, input);
                    		            throw eee;
                    	    }
                    	    cnt70++;
                    	} while (true);

                    	loop70:
                    		;	// Stops C# compiler whinging that label 'loop70' has no statements



                    	// AST REWRITE
                    	// elements:          numberunit, idd, 47, 45
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 459:31: -> ^( IM_DONTCARE ( idd '=' numberunit ( ',' )? )+ )
                    	{
                    	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:459:34: ^( IM_DONTCARE ( idd '=' numberunit ( ',' )? )+ )
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
                    	        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:459:69: ( ',' )?
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:461:1: coord_sep : ( ',' | ':' ) ;
    public simpletikzParser.coord_sep_return coord_sep() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_sep_return retval = new simpletikzParser.coord_sep_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set282 = null;

        object set282_tree=null;

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:462:2: ( ( ',' | ':' ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:462:4: ( ',' | ':' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set282 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 47 && input.LA(1) <= 48) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set282));
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:466:1: edgeop : ( '--' | '->' | '|-' | '-|' | ID );
    public simpletikzParser.edgeop_return edgeop() // throws RecognitionException [1]
    {   
        simpletikzParser.edgeop_return retval = new simpletikzParser.edgeop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set283 = null;

        object set283_tree=null;

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:467:2: ( '--' | '->' | '|-' | '-|' | ID )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set283 = (IToken)input.LT(1);
            	if ( input.LA(1) == ID || (input.LA(1) >= 80 && input.LA(1) <= 83) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set283));
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:471:1: coord_modifier : ( '+' | '++' );
    public simpletikzParser.coord_modifier_return coord_modifier() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_modifier_return retval = new simpletikzParser.coord_modifier_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set284 = null;

        object set284_tree=null;

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:472:2: ( '+' | '++' )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set284 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 84 && input.LA(1) <= 85) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set284));
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:514:1: squarebr_start : '[' -> ^( IM_STARTTAG '[' ) ;
    public simpletikzParser.squarebr_start_return squarebr_start() // throws RecognitionException [1]
    {   
        simpletikzParser.squarebr_start_return retval = new simpletikzParser.squarebr_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal285 = null;

        object char_literal285_tree=null;
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:515:2: ( '[' -> ^( IM_STARTTAG '[' ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:515:4: '['
            {
            	char_literal285=(IToken)Match(input,54,FOLLOW_54_in_squarebr_start3006); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_54.Add(char_literal285);



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
            	// 515:8: -> ^( IM_STARTTAG '[' )
            	{
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:515:11: ^( IM_STARTTAG '[' )
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:517:1: squarebr_end : ']' -> ^( IM_ENDTAG ']' ) ;
    public simpletikzParser.squarebr_end_return squarebr_end() // throws RecognitionException [1]
    {   
        simpletikzParser.squarebr_end_return retval = new simpletikzParser.squarebr_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal286 = null;

        object char_literal286_tree=null;
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:518:2: ( ']' -> ^( IM_ENDTAG ']' ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:518:4: ']'
            {
            	char_literal286=(IToken)Match(input,55,FOLLOW_55_in_squarebr_end3024); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_55.Add(char_literal286);



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
            	// 518:8: -> ^( IM_ENDTAG ']' )
            	{
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:518:11: ^( IM_ENDTAG ']' )
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:520:1: semicolon_end : ';' -> ^( IM_ENDTAG ';' ) ;
    public simpletikzParser.semicolon_end_return semicolon_end() // throws RecognitionException [1]
    {   
        simpletikzParser.semicolon_end_return retval = new simpletikzParser.semicolon_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal287 = null;

        object char_literal287_tree=null;
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:521:2: ( ';' -> ^( IM_ENDTAG ';' ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:521:4: ';'
            {
            	char_literal287=(IToken)Match(input,56,FOLLOW_56_in_semicolon_end3043); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_56.Add(char_literal287);



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
            	// 521:8: -> ^( IM_ENDTAG ';' )
            	{
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:521:11: ^( IM_ENDTAG ';' )
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:523:1: roundbr_start : '{' -> ^( IM_STARTTAG '{' ) ;
    public simpletikzParser.roundbr_start_return roundbr_start() // throws RecognitionException [1]
    {   
        simpletikzParser.roundbr_start_return retval = new simpletikzParser.roundbr_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal288 = null;

        object char_literal288_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:524:2: ( '{' -> ^( IM_STARTTAG '{' ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:524:4: '{'
            {
            	char_literal288=(IToken)Match(input,43,FOLLOW_43_in_roundbr_start3061); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_43.Add(char_literal288);



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
            	// 524:8: -> ^( IM_STARTTAG '{' )
            	{
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:524:11: ^( IM_STARTTAG '{' )
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:526:1: roundbr_end : '}' -> ^( IM_ENDTAG '}' ) ;
    public simpletikzParser.roundbr_end_return roundbr_end() // throws RecognitionException [1]
    {   
        simpletikzParser.roundbr_end_return retval = new simpletikzParser.roundbr_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal289 = null;

        object char_literal289_tree=null;
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:527:2: ( '}' -> ^( IM_ENDTAG '}' ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:527:4: '}'
            {
            	char_literal289=(IToken)Match(input,44,FOLLOW_44_in_roundbr_end3079); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_44.Add(char_literal289);



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
            	// 527:8: -> ^( IM_ENDTAG '}' )
            	{
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:527:11: ^( IM_ENDTAG '}' )
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:529:1: controls_start : '..' 'controls' -> ^( IM_STARTTAG '..' ) ;
    public simpletikzParser.controls_start_return controls_start() // throws RecognitionException [1]
    {   
        simpletikzParser.controls_start_return retval = new simpletikzParser.controls_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal290 = null;
        IToken string_literal291 = null;

        object string_literal290_tree=null;
        object string_literal291_tree=null;
        RewriteRuleTokenStream stream_86 = new RewriteRuleTokenStream(adaptor,"token 86");
        RewriteRuleTokenStream stream_87 = new RewriteRuleTokenStream(adaptor,"token 87");

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:530:2: ( '..' 'controls' -> ^( IM_STARTTAG '..' ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:530:4: '..' 'controls'
            {
            	string_literal290=(IToken)Match(input,86,FOLLOW_86_in_controls_start3097); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_86.Add(string_literal290);

            	string_literal291=(IToken)Match(input,87,FOLLOW_87_in_controls_start3099); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_87.Add(string_literal291);



            	// AST REWRITE
            	// elements:          86
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 530:20: -> ^( IM_STARTTAG '..' )
            	{
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:530:23: ^( IM_STARTTAG '..' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_86.NextNode());

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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:532:1: controls_end : '..' -> ^( IM_ENDTAG '..' ) ;
    public simpletikzParser.controls_end_return controls_end() // throws RecognitionException [1]
    {   
        simpletikzParser.controls_end_return retval = new simpletikzParser.controls_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal292 = null;

        object string_literal292_tree=null;
        RewriteRuleTokenStream stream_86 = new RewriteRuleTokenStream(adaptor,"token 86");

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:533:2: ( '..' -> ^( IM_ENDTAG '..' ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:533:4: '..'
            {
            	string_literal292=(IToken)Match(input,86,FOLLOW_86_in_controls_end3117); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_86.Add(string_literal292);



            	// AST REWRITE
            	// elements:          86
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 533:9: -> ^( IM_ENDTAG '..' )
            	{
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:533:12: ^( IM_ENDTAG '..' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_86.NextNode());

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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:535:1: tikz_set_start : '\\\\tikzset' '{' -> ^( IM_STARTTAG ) ;
    public simpletikzParser.tikz_set_start_return tikz_set_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_set_start_return retval = new simpletikzParser.tikz_set_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal293 = null;
        IToken char_literal294 = null;

        object string_literal293_tree=null;
        object char_literal294_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:536:2: ( '\\\\tikzset' '{' -> ^( IM_STARTTAG ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:536:4: '\\\\tikzset' '{'
            {
            	string_literal293=(IToken)Match(input,41,FOLLOW_41_in_tikz_set_start3135); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_41.Add(string_literal293);

            	char_literal294=(IToken)Match(input,43,FOLLOW_43_in_tikz_set_start3137); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_43.Add(char_literal294);



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
            	// 536:21: -> ^( IM_STARTTAG )
            	{
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:536:24: ^( IM_STARTTAG )
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:538:1: tikzpicture_start : '\\\\begin' '{' 'tikzpicture' '}' -> ^( IM_STARTTAG '\\\\begin' ) ;
    public simpletikzParser.tikzpicture_start_return tikzpicture_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_start_return retval = new simpletikzParser.tikzpicture_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal295 = null;
        IToken char_literal296 = null;
        IToken string_literal297 = null;
        IToken char_literal298 = null;

        object string_literal295_tree=null;
        object char_literal296_tree=null;
        object string_literal297_tree=null;
        object char_literal298_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");
        RewriteRuleTokenStream stream_88 = new RewriteRuleTokenStream(adaptor,"token 88");

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:539:2: ( '\\\\begin' '{' 'tikzpicture' '}' -> ^( IM_STARTTAG '\\\\begin' ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:539:4: '\\\\begin' '{' 'tikzpicture' '}'
            {
            	string_literal295=(IToken)Match(input,39,FOLLOW_39_in_tikzpicture_start3156); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_39.Add(string_literal295);

            	char_literal296=(IToken)Match(input,43,FOLLOW_43_in_tikzpicture_start3158); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_43.Add(char_literal296);

            	string_literal297=(IToken)Match(input,88,FOLLOW_88_in_tikzpicture_start3160); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_88.Add(string_literal297);

            	char_literal298=(IToken)Match(input,44,FOLLOW_44_in_tikzpicture_start3162); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_44.Add(char_literal298);



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
            	// 539:36: -> ^( IM_STARTTAG '\\\\begin' )
            	{
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:539:39: ^( IM_STARTTAG '\\\\begin' )
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:541:1: tikz_start : '\\\\tikz' -> ^( IM_STARTTAG '\\\\tikz' ) ;
    public simpletikzParser.tikz_start_return tikz_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_start_return retval = new simpletikzParser.tikz_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal299 = null;

        object string_literal299_tree=null;
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:542:2: ( '\\\\tikz' -> ^( IM_STARTTAG '\\\\tikz' ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:542:4: '\\\\tikz'
            {
            	string_literal299=(IToken)Match(input,42,FOLLOW_42_in_tikz_start3180); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_42.Add(string_literal299);



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
            	// 542:13: -> ^( IM_STARTTAG '\\\\tikz' )
            	{
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:542:16: ^( IM_STARTTAG '\\\\tikz' )
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:544:1: tikzpicture_end : '\\\\end' '{' 'tikzpicture' '}' -> ^( IM_ENDTAG '\\\\end' ) ;
    public simpletikzParser.tikzpicture_end_return tikzpicture_end() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_end_return retval = new simpletikzParser.tikzpicture_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal300 = null;
        IToken char_literal301 = null;
        IToken string_literal302 = null;
        IToken char_literal303 = null;

        object string_literal300_tree=null;
        object char_literal301_tree=null;
        object string_literal302_tree=null;
        object char_literal303_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_63 = new RewriteRuleTokenStream(adaptor,"token 63");
        RewriteRuleTokenStream stream_88 = new RewriteRuleTokenStream(adaptor,"token 88");

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:545:2: ( '\\\\end' '{' 'tikzpicture' '}' -> ^( IM_ENDTAG '\\\\end' ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:545:4: '\\\\end' '{' 'tikzpicture' '}'
            {
            	string_literal300=(IToken)Match(input,63,FOLLOW_63_in_tikzpicture_end3198); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_63.Add(string_literal300);

            	char_literal301=(IToken)Match(input,43,FOLLOW_43_in_tikzpicture_end3200); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_43.Add(char_literal301);

            	string_literal302=(IToken)Match(input,88,FOLLOW_88_in_tikzpicture_end3202); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_88.Add(string_literal302);

            	char_literal303=(IToken)Match(input,44,FOLLOW_44_in_tikzpicture_end3204); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_44.Add(char_literal303);



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
            	// 545:34: -> ^( IM_ENDTAG '\\\\end' )
            	{
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:545:37: ^( IM_ENDTAG '\\\\end' )
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:547:1: tikzscope_start : '\\\\begin' '{' 'scope' '}' -> ^( IM_STARTTAG '\\\\begin' ) ;
    public simpletikzParser.tikzscope_start_return tikzscope_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_start_return retval = new simpletikzParser.tikzscope_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal304 = null;
        IToken char_literal305 = null;
        IToken string_literal306 = null;
        IToken char_literal307 = null;

        object string_literal304_tree=null;
        object char_literal305_tree=null;
        object string_literal306_tree=null;
        object char_literal307_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");
        RewriteRuleTokenStream stream_89 = new RewriteRuleTokenStream(adaptor,"token 89");

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:548:2: ( '\\\\begin' '{' 'scope' '}' -> ^( IM_STARTTAG '\\\\begin' ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:548:4: '\\\\begin' '{' 'scope' '}'
            {
            	string_literal304=(IToken)Match(input,39,FOLLOW_39_in_tikzscope_start3222); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_39.Add(string_literal304);

            	char_literal305=(IToken)Match(input,43,FOLLOW_43_in_tikzscope_start3224); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_43.Add(char_literal305);

            	string_literal306=(IToken)Match(input,89,FOLLOW_89_in_tikzscope_start3226); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_89.Add(string_literal306);

            	char_literal307=(IToken)Match(input,44,FOLLOW_44_in_tikzscope_start3228); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_44.Add(char_literal307);



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
            	// 548:30: -> ^( IM_STARTTAG '\\\\begin' )
            	{
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:548:33: ^( IM_STARTTAG '\\\\begin' )
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:550:1: tikzscope_end : '\\\\end' '{' 'scope' '}' -> ^( IM_ENDTAG '\\\\end' ) ;
    public simpletikzParser.tikzscope_end_return tikzscope_end() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_end_return retval = new simpletikzParser.tikzscope_end_return();
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
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_63 = new RewriteRuleTokenStream(adaptor,"token 63");
        RewriteRuleTokenStream stream_89 = new RewriteRuleTokenStream(adaptor,"token 89");

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:551:2: ( '\\\\end' '{' 'scope' '}' -> ^( IM_ENDTAG '\\\\end' ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:551:4: '\\\\end' '{' 'scope' '}'
            {
            	string_literal308=(IToken)Match(input,63,FOLLOW_63_in_tikzscope_end3246); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_63.Add(string_literal308);

            	char_literal309=(IToken)Match(input,43,FOLLOW_43_in_tikzscope_end3248); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_43.Add(char_literal309);

            	string_literal310=(IToken)Match(input,89,FOLLOW_89_in_tikzscope_end3250); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_89.Add(string_literal310);

            	char_literal311=(IToken)Match(input,44,FOLLOW_44_in_tikzscope_end3252); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_44.Add(char_literal311);



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
            	// 551:28: -> ^( IM_ENDTAG '\\\\end' )
            	{
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:551:31: ^( IM_ENDTAG '\\\\end' )
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:553:1: path_start : path_start_tag -> ^( IM_STARTTAG path_start_tag ) ;
    public simpletikzParser.path_start_return path_start() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_return retval = new simpletikzParser.path_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.path_start_tag_return path_start_tag312 = default(simpletikzParser.path_start_tag_return);


        RewriteRuleSubtreeStream stream_path_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule path_start_tag");
        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:554:2: ( path_start_tag -> ^( IM_STARTTAG path_start_tag ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:554:4: path_start_tag
            {
            	PushFollow(FOLLOW_path_start_tag_in_path_start3271);
            	path_start_tag312 = path_start_tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_path_start_tag.Add(path_start_tag312.Tree);


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
            	// 554:19: -> ^( IM_STARTTAG path_start_tag )
            	{
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:554:22: ^( IM_STARTTAG path_start_tag )
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:556:1: node_start : node_start_tag -> ^( IM_STARTTAG node_start_tag ) ;
    public simpletikzParser.node_start_return node_start() // throws RecognitionException [1]
    {   
        simpletikzParser.node_start_return retval = new simpletikzParser.node_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.node_start_tag_return node_start_tag313 = default(simpletikzParser.node_start_tag_return);


        RewriteRuleSubtreeStream stream_node_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule node_start_tag");
        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:557:2: ( node_start_tag -> ^( IM_STARTTAG node_start_tag ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:557:4: node_start_tag
            {
            	PushFollow(FOLLOW_node_start_tag_in_node_start3289);
            	node_start_tag313 = node_start_tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_node_start_tag.Add(node_start_tag313.Tree);


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
            	// 557:19: -> ^( IM_STARTTAG node_start_tag )
            	{
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:557:22: ^( IM_STARTTAG node_start_tag )
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:559:1: matrix_start : matrix_start_tag -> ^( IM_STARTTAG matrix_start_tag ) ;
    public simpletikzParser.matrix_start_return matrix_start() // throws RecognitionException [1]
    {   
        simpletikzParser.matrix_start_return retval = new simpletikzParser.matrix_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.matrix_start_tag_return matrix_start_tag314 = default(simpletikzParser.matrix_start_tag_return);


        RewriteRuleSubtreeStream stream_matrix_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule matrix_start_tag");
        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:560:2: ( matrix_start_tag -> ^( IM_STARTTAG matrix_start_tag ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:560:4: matrix_start_tag
            {
            	PushFollow(FOLLOW_matrix_start_tag_in_matrix_start3307);
            	matrix_start_tag314 = matrix_start_tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_matrix_start_tag.Add(matrix_start_tag314.Tree);


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
            	// 560:21: -> ^( IM_STARTTAG matrix_start_tag )
            	{
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:560:24: ^( IM_STARTTAG matrix_start_tag )
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:562:1: node_start_tag : '\\\\node' ;
    public simpletikzParser.node_start_tag_return node_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.node_start_tag_return retval = new simpletikzParser.node_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal315 = null;

        object string_literal315_tree=null;

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:563:2: ( '\\\\node' )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:563:4: '\\\\node'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal315=(IToken)Match(input,64,FOLLOW_64_in_node_start_tag3325); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal315_tree = (object)adaptor.Create(string_literal315);
            		adaptor.AddChild(root_0, string_literal315_tree);
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:565:1: matrix_start_tag : '\\\\matrix' ;
    public simpletikzParser.matrix_start_tag_return matrix_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.matrix_start_tag_return retval = new simpletikzParser.matrix_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal316 = null;

        object string_literal316_tree=null;

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:566:2: ( '\\\\matrix' )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:566:4: '\\\\matrix'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal316=(IToken)Match(input,65,FOLLOW_65_in_matrix_start_tag3335); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal316_tree = (object)adaptor.Create(string_literal316);
            		adaptor.AddChild(root_0, string_literal316_tree);
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:568:1: coordinate_start : '\\\\coordinate' -> ^( IM_STARTTAG '\\\\coordinate' ) ;
    public simpletikzParser.coordinate_start_return coordinate_start() // throws RecognitionException [1]
    {   
        simpletikzParser.coordinate_start_return retval = new simpletikzParser.coordinate_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal317 = null;

        object string_literal317_tree=null;
        RewriteRuleTokenStream stream_66 = new RewriteRuleTokenStream(adaptor,"token 66");

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:569:2: ( '\\\\coordinate' -> ^( IM_STARTTAG '\\\\coordinate' ) )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:569:4: '\\\\coordinate'
            {
            	string_literal317=(IToken)Match(input,66,FOLLOW_66_in_coordinate_start3345); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_66.Add(string_literal317);



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
            	// 569:19: -> ^( IM_STARTTAG '\\\\coordinate' )
            	{
            	    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:569:22: ^( IM_STARTTAG '\\\\coordinate' )
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
    // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:571:1: path_start_tag : ( '\\\\draw' | '\\\\fill' | '\\\\path' | '\\\\clip' | '\\\\filldraw' );
    public simpletikzParser.path_start_tag_return path_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_tag_return retval = new simpletikzParser.path_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set318 = null;

        object set318_tree=null;

        try 
    	{
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:572:2: ( '\\\\draw' | '\\\\fill' | '\\\\path' | '\\\\clip' | '\\\\filldraw' )
            // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set318 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 67 && input.LA(1) <= 71) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set318));
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
        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:331:5: ( coord )
        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:331:6: coord
        {
        	PushFollow(FOLLOW_coord_in_synpred1_simpletikz1781);
        	coord();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred1_simpletikz"

    // $ANTLR start "synpred2_simpletikz"
    public void synpred2_simpletikz_fragment() {
        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:356:8: ( tikzcoordinate_core3 )
        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:356:9: tikzcoordinate_core3
        {
        	PushFollow(FOLLOW_tikzcoordinate_core3_in_synpred2_simpletikz1996);
        	tikzcoordinate_core3();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred2_simpletikz"

    // $ANTLR start "synpred3_simpletikz"
    public void synpred3_simpletikz_fragment() {
        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:357:12: ( tikzcoordinate_core2 )
        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:357:13: tikzcoordinate_core2
        {
        	PushFollow(FOLLOW_tikzcoordinate_core2_in_synpred3_simpletikz2015);
        	tikzcoordinate_core2();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred3_simpletikz"

    // $ANTLR start "synpred4_simpletikz"
    public void synpred4_simpletikz_fragment() {
        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:358:12: ( tikzcoordinate_core1 )
        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:358:13: tikzcoordinate_core1
        {
        	PushFollow(FOLLOW_tikzcoordinate_core1_in_synpred4_simpletikz2035);
        	tikzcoordinate_core1();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred4_simpletikz"

    // $ANTLR start "synpred5_simpletikz"
    public void synpred5_simpletikz_fragment() {
        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:367:21: ( tikzcoordinate_core3 )
        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:367:22: tikzcoordinate_core3
        {
        	PushFollow(FOLLOW_tikzcoordinate_core3_in_synpred5_simpletikz2120);
        	tikzcoordinate_core3();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred5_simpletikz"

    // $ANTLR start "synpred6_simpletikz"
    public void synpred6_simpletikz_fragment() {
        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:368:12: ( tikzcoordinate_core2 )
        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:368:13: tikzcoordinate_core2
        {
        	PushFollow(FOLLOW_tikzcoordinate_core2_in_synpred6_simpletikz2139);
        	tikzcoordinate_core2();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred6_simpletikz"

    // $ANTLR start "synpred7_simpletikz"
    public void synpred7_simpletikz_fragment() {
        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:369:12: ( tikzcoordinate_core1 )
        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:369:13: tikzcoordinate_core1
        {
        	PushFollow(FOLLOW_tikzcoordinate_core1_in_synpred7_simpletikz2159);
        	tikzcoordinate_core1();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred7_simpletikz"

    // $ANTLR start "synpred8_simpletikz"
    public void synpred8_simpletikz_fragment() {
        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:417:28: ( size )
        // C:\\Users\\alw\\Documents\\Visual Studio 2010\\Projects\\trunk\\TikzParser\\simpletikz.g:417:29: size
        {
        	PushFollow(FOLLOW_size_in_synpred8_simpletikz2451);
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
   	protected DFA47 dfa47;
   	protected DFA49 dfa49;
   	protected DFA56 dfa56;
   	protected DFA59 dfa59;
   	protected DFA65 dfa65;
   	protected DFA68 dfa68;
   	protected DFA71 dfa71;
	private void InitializeCyclicDFAs()
	{
    	this.dfa10 = new DFA10(this);
    	this.dfa16 = new DFA16(this);
    	this.dfa33 = new DFA33(this);
    	this.dfa34 = new DFA34(this);
    	this.dfa35 = new DFA35(this);
    	this.dfa36 = new DFA36(this);
    	this.dfa43 = new DFA43(this);
    	this.dfa47 = new DFA47(this);
    	this.dfa49 = new DFA49(this);
    	this.dfa56 = new DFA56(this);
    	this.dfa59 = new DFA59(this);
    	this.dfa65 = new DFA65(this);
    	this.dfa68 = new DFA68(this);
    	this.dfa71 = new DFA71(this);






	    this.dfa43.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA43_SpecialStateTransition);
	    this.dfa47.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA47_SpecialStateTransition);
	    this.dfa49.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA49_SpecialStateTransition);
	    this.dfa56.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA56_SpecialStateTransition);




	}

    const string DFA10_eotS =
        "\x04\uffff";
    const string DFA10_eofS =
        "\x04\uffff";
    const string DFA10_minS =
        "\x02\x04\x02\uffff";
    const string DFA10_maxS =
        "\x02\x59\x02\uffff";
    const string DFA10_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA10_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA10_transitionS = {
            "\x27\x01\x03\uffff\x01\x01\x04\uffff\x01\x01\x05\uffff\x21"+
            "\x01",
            "\x27\x01\x03\x03\x01\x01\x01\x03\x01\uffff\x02\x02\x01\x01"+
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

    const string DFA16_eotS =
        "\x39\uffff";
    const string DFA16_eofS =
        "\x39\uffff";
    const string DFA16_minS =
        "\x01\x04\x01\x2b\x01\x04\x01\uffff\x01\x2b\x01\uffff\x01\x1e\x02"+
        "\x04\x02\uffff\x0c\x04\x01\uffff\x21\x04";
    const string DFA16_maxS =
        "\x01\x59\x01\x3e\x01\x59\x01\uffff\x01\x37\x01\uffff\x01\x2b\x02"+
        "\x59\x02\uffff\x0c\x59\x01\uffff\x21\x59";
    const string DFA16_acceptS =
        "\x03\uffff\x01\x04\x01\uffff\x01\x02\x03\uffff\x01\x05\x01\x01"+
        "\x0c\uffff\x01\x03\x21\uffff";
    const string DFA16_specialS =
        "\x39\uffff}>";
    static readonly string[] DFA16_transitionS = {
            "\x1a\x03\x02\x01\x0b\x03\x01\x02\x02\uffff\x01\x03\x04\uffff"+
            "\x01\x03\x05\uffff\x21\x03",
            "\x02\x05\x02\uffff\x01\x05\x01\x06\x06\uffff\x01\x05\x01\uffff"+
            "\x06\x04",
            "\x30\x09\x01\x07\x1f\x09\x02\x08\x04\x09",
            "",
            "\x02\x05\x02\uffff\x01\x05\x01\x0a\x06\uffff\x01\x05",
            "",
            "\x02\x0a\x0b\uffff\x01\x09",
            "\x1a\x0d\x02\x0b\x0b\x0d\x01\x0c\x02\x09\x01\x0d\x04\x09\x01"+
            "\x0d\x05\x09\x21\x0d",
            "\x30\x09\x01\x0e\x25\x09",
            "",
            "",
            "\x27\x0d\x02\x09\x01\x12\x01\x0d\x02\x11\x02\x09\x01\x0d\x01"+
            "\x09\x01\x0f\x03\x09\x06\x10\x1b\x0d",
            "\x27\x13\x03\x09\x01\x13\x04\x09\x01\x13\x05\x09\x21\x13",
            "\x27\x0d\x02\x09\x01\x12\x01\x0d\x02\x14\x02\x09\x01\x0d\x01"+
            "\x09\x01\x0f\x03\x09\x21\x0d",
            "\x1a\x16\x02\x15\x0b\x16\x01\x0c\x02\x09\x01\x16\x04\x09\x01"+
            "\x16\x05\x09\x21\x16",
            "\x28\x09\x01\x17\x2d\x09",
            "\x27\x0d\x02\x09\x01\x12\x01\x0d\x02\x11\x02\x09\x01\x0d\x01"+
            "\x09\x01\x0f\x03\x09\x21\x0d",
            "\x1a\x1a\x02\x18\x0b\x1a\x01\x19\x02\x09\x01\x1a\x04\x09\x01"+
            "\x1a\x05\x09\x21\x1a",
            "\x1a\x09\x02\x1b\x3a\x09",
            "\x27\x13\x01\x09\x01\x1c\x01\x09\x01\x13\x04\x09\x01\x13\x05"+
            "\x09\x21\x13",
            "\x27\x1a\x01\x19\x02\x09\x01\x1a\x04\x09\x01\x1a\x05\x09\x21"+
            "\x1a",
            "\x27\x16\x02\x09\x01\x12\x01\x16\x02\x11\x02\x09\x01\x16\x05"+
            "\x09\x06\x1d\x1b\x16",
            "\x27\x16\x02\x09\x01\x12\x01\x16\x02\x14\x02\x09\x01\x16\x05"+
            "\x09\x21\x16",
            "",
            "\x27\x1a\x02\x09\x01\x20\x01\x1a\x04\x09\x01\x1a\x01\x09\x01"+
            "\x1f\x03\x09\x06\x1e\x1b\x1a",
            "\x27\x21\x03\x09\x01\x21\x04\x09\x01\x21\x05\x09\x21\x21",
            "\x27\x1a\x02\x09\x01\x20\x01\x1a\x04\x09\x01\x1a\x01\x09\x01"+
            "\x22\x03\x09\x21\x1a",
            "\x27\x25\x03\x09\x01\x25\x01\x24\x01\x14\x02\x09\x01\x25\x05"+
            "\x09\x06\x23\x1b\x25",
            "\x2b\x09\x02\x26\x29\x09",
            "\x27\x16\x02\x09\x01\x12\x01\x16\x02\x11\x02\x09\x01\x16\x05"+
            "\x09\x21\x16",
            "\x27\x1a\x02\x09\x01\x20\x01\x1a\x04\x09\x01\x1a\x01\x09\x01"+
            "\x1f\x03\x09\x21\x1a",
            "\x28\x09\x01\x17\x2d\x09",
            "\x1a\x09\x02\x27\x3a\x09",
            "\x27\x21\x01\x09\x01\x28\x01\x09\x01\x21\x04\x09\x01\x21\x05"+
            "\x09\x21\x21",
            "\x28\x09\x01\x17\x2d\x09",
            "\x27\x25\x02\x09\x01\x12\x01\x25\x01\x24\x01\x14\x02\x09\x01"+
            "\x25\x05\x09\x21\x25",
            "\x27\x29\x01\x19\x02\x09\x01\x29\x02\x14\x02\x09\x01\x29\x05"+
            "\x09\x21\x29",
            "\x27\x25\x02\x09\x01\x12\x01\x25\x04\x09\x01\x25\x05\x09\x21"+
            "\x25",
            "\x27\x2a\x01\x19\x02\x09\x01\x2a\x04\x09\x01\x2a\x05\x09\x21"+
            "\x2a",
            "\x27\x2d\x03\x09\x01\x2d\x01\x2c\x03\x09\x01\x2d\x01\x09\x01"+
            "\x22\x03\x09\x06\x2b\x1b\x2d",
            "\x31\x09\x01\x2e\x24\x09",
            "\x27\x29\x02\x09\x01\x2f\x01\x29\x04\x09\x01\x29\x01\x09\x01"+
            "\x22\x03\x09\x21\x29",
            "\x27\x2a\x02\x09\x01\x30\x01\x2a\x04\x09\x01\x2a\x01\x09\x01"+
            "\x2e\x03\x09\x21\x2a",
            "\x27\x2d\x02\x09\x01\x20\x01\x2d\x01\x2c\x03\x09\x01\x2d\x01"+
            "\x09\x01\x22\x03\x09\x21\x2d",
            "\x27\x2d\x03\x09\x01\x2d\x04\x09\x01\x2d\x01\x09\x01\x22\x03"+
            "\x09\x21\x2d",
            "\x27\x2d\x02\x09\x01\x20\x01\x2d\x04\x09\x01\x2d\x05\x09\x21"+
            "\x2d",
            "\x28\x09\x01\x17\x2d\x09",
            "\x1a\x09\x02\x31\x3a\x09",
            "\x1a\x09\x02\x32\x3a\x09",
            "\x27\x35\x03\x09\x01\x35\x01\x34\x01\x14\x02\x09\x01\x35\x01"+
            "\x09\x01\x22\x03\x09\x06\x33\x1b\x35",
            "\x27\x38\x03\x09\x01\x38\x01\x37\x03\x09\x01\x38\x01\x09\x01"+
            "\x2e\x03\x09\x06\x36\x1b\x38",
            "\x27\x35\x02\x09\x01\x2f\x01\x35\x01\x34\x01\x14\x02\x09\x01"+
            "\x35\x01\x09\x01\x22\x03\x09\x21\x35",
            "\x27\x29\x01\x19\x02\x09\x01\x29\x02\x14\x02\x09\x01\x29\x01"+
            "\x09\x01\x22\x03\x09\x21\x29",
            "\x27\x35\x02\x09\x01\x2f\x01\x35\x04\x09\x01\x35\x05\x09\x21"+
            "\x35",
            "\x27\x38\x02\x09\x01\x30\x01\x38\x01\x37\x03\x09\x01\x38\x01"+
            "\x09\x01\x2e\x03\x09\x21\x38",
            "\x27\x38\x03\x09\x01\x38\x04\x09\x01\x38\x01\x09\x01\x2e\x03"+
            "\x09\x21\x38",
            "\x27\x38\x02\x09\x01\x30\x01\x38\x04\x09\x01\x38\x05\x09\x21"+
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
        "\x0d\uffff";
    const string DFA33_eofS =
        "\x0d\uffff";
    const string DFA33_minS =
        "\x01\x04\x01\x2b\x08\uffff\x01\x1c\x02\uffff";
    const string DFA33_maxS =
        "\x01\x59\x01\x2b\x08\uffff\x01\x59\x02\uffff";
    const string DFA33_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07\x01"+
        "\x09\x01\x0a\x01\uffff\x01\x01\x01\x08";
    const string DFA33_specialS =
        "\x0d\uffff}>";
    static readonly string[] DFA33_transitionS = {
            "\x23\x09\x01\x01\x01\x07\x01\x06\x0c\x09\x01\uffff\x08\x09"+
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
            "\x01\x0c\x3c\uffff\x01\x0b",
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
            get { return "248:4: ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr )"; }
        }

    }

    const string DFA34_eotS =
        "\x10\uffff";
    const string DFA34_eofS =
        "\x10\uffff";
    const string DFA34_minS =
        "\x01\x04\x02\x2b\x07\uffff\x02\x1c\x04\uffff";
    const string DFA34_maxS =
        "\x01\x59\x02\x2b\x07\uffff\x02\x59\x04\uffff";
    const string DFA34_acceptS =
        "\x03\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07\x01"+
        "\x0a\x02\uffff\x01\x0b\x01\x09\x01\x01\x01\x08";
    const string DFA34_specialS =
        "\x10\uffff}>";
    static readonly string[] DFA34_transitionS = {
            "\x23\x09\x01\x02\x01\x08\x01\x07\x15\x09\x01\x01\x01\x04\x01"+
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
            "\x01\x0d\x3b\uffff\x02\x0c",
            "\x01\x0f\x3c\uffff\x01\x0e",
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
            get { return "()* loopback of 249:3: ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body )*"; }
        }

    }

    const string DFA35_eotS =
        "\x0d\uffff";
    const string DFA35_eofS =
        "\x0d\uffff";
    const string DFA35_minS =
        "\x01\x04\x01\x2b\x08\uffff\x01\x1c\x02\uffff";
    const string DFA35_maxS =
        "\x01\x59\x01\x2b\x08\uffff\x01\x59\x02\uffff";
    const string DFA35_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07\x01"+
        "\x09\x01\x0a\x01\uffff\x01\x01\x01\x08";
    const string DFA35_specialS =
        "\x0d\uffff}>";
    static readonly string[] DFA35_transitionS = {
            "\x23\x09\x01\x01\x01\x07\x01\x06\x01\x09\x02\uffff\x09\x09"+
            "\x01\uffff\x08\x09\x01\x08\x01\x03\x01\x04\x01\x05\x05\x02\x12"+
            "\x09",
            "\x01\x0a",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0c\x3c\uffff\x01\x0b",
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
            get { return "252:4: ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body_nobr2 )"; }
        }

    }

    const string DFA36_eotS =
        "\x0e\uffff";
    const string DFA36_eofS =
        "\x0e\uffff";
    const string DFA36_minS =
        "\x01\x04\x01\uffff\x01\x2b\x08\uffff\x01\x1c\x02\uffff";
    const string DFA36_maxS =
        "\x01\x59\x01\uffff\x01\x2b\x08\uffff\x01\x59\x02\uffff";
    const string DFA36_acceptS =
        "\x01\uffff\x01\x0b\x01\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x01\x09\x01\x0a\x01\uffff\x01\x01\x01\x08";
    const string DFA36_specialS =
        "\x0e\uffff}>";
    static readonly string[] DFA36_transitionS = {
            "\x23\x0a\x01\x02\x01\x08\x01\x07\x01\x0a\x01\uffff\x01\x01"+
            "\x12\x0a\x01\x09\x01\x04\x01\x05\x01\x06\x05\x03\x12\x0a",
            "",
            "\x01\x0b",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0d\x3c\uffff\x01\x0c",
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
            get { return "()* loopback of 253:3: ( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin | otherend | dontcare_body2 )*"; }
        }

    }

    const string DFA43_eotS =
        "\x0e\uffff";
    const string DFA43_eofS =
        "\x0e\uffff";
    const string DFA43_minS =
        "\x01\x1c\x04\uffff\x01\x00\x08\uffff";
    const string DFA43_maxS =
        "\x01\x56\x04\uffff\x01\x00\x08\uffff";
    const string DFA43_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\uffff\x01\x05\x01"+
        "\x06\x01\x07\x01\x08\x01\uffff\x01\x09\x01\x0b\x01\x0a";
    const string DFA43_specialS =
        "\x01\x00\x04\uffff\x01\x01\x08\uffff}>";
    static readonly string[] DFA43_transitionS = {
            "\x01\x0c\x01\x02\x0d\uffff\x01\x0b\x01\uffff\x01\x02\x06\uffff"+
            "\x01\x05\x01\uffff\x01\x01\x03\uffff\x01\x02\x0d\uffff\x01\x02"+
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
            get { return "325:1: tikzpath_element_single : ( tikz_options | let_cmd_parts -> ^( IM_TIKZEDT_CMD ( let_cmd_parts )+ ) | arc | ( coord )=> coord | controls | tikznode_int | tikzcoordinate_int | circle | roundbr_start ( tikzpath_element )* roundbr_end -> ^( IM_PATH roundbr_start ( tikzpath_element )* roundbr_end ) | '(' ( tikzpath_element )* ')' -> ^( IM_PATH '(' ( tikzpath_element )* ')' ) | edgeop );"; }
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

                   	else if ( (LA43_0 == COMMAND || LA43_0 == 45 || LA43_0 == 58 || LA43_0 == 72) ) { s = 2; }

                   	else if ( (LA43_0 == 79) ) { s = 3; }

                   	else if ( ((LA43_0 >= 84 && LA43_0 <= 85)) && (synpred1_simpletikz()) ) { s = 4; }

                   	else if ( (LA43_0 == 52) ) { s = 5; }

                   	else if ( (LA43_0 == 86) ) { s = 6; }

                   	else if ( (LA43_0 == 75) ) { s = 7; }

                   	else if ( (LA43_0 == 74) ) { s = 8; }

                   	else if ( ((LA43_0 >= 77 && LA43_0 <= 78)) ) { s = 9; }

                   	else if ( (LA43_0 == 43) ) { s = 11; }

                   	else if ( (LA43_0 == ID || (LA43_0 >= 80 && LA43_0 <= 83)) ) { s = 12; }

                   	 
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
    const string DFA47_eotS =
        "\x12\uffff";
    const string DFA47_eofS =
        "\x12\uffff";
    const string DFA47_minS =
        "\x01\x1c\x03\x00\x0e\uffff";
    const string DFA47_maxS =
        "\x01\x56\x03\x00\x0e\uffff";
    const string DFA47_acceptS =
        "\x04\uffff\x01\x04\x0a\uffff\x01\x01\x01\x02\x01\x03";
    const string DFA47_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x0e\uffff}>";
    static readonly string[] DFA47_transitionS = {
            "\x02\x04\x0d\uffff\x01\x04\x01\uffff\x01\x04\x06\uffff\x01"+
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
            get { return "356:5: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?"; }
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
                   	if ( (synpred2_simpletikz()) ) { s = 15; }

                   	else if ( (synpred3_simpletikz()) ) { s = 16; }

                   	else if ( (synpred4_simpletikz()) ) { s = 17; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index47_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA47_2 = input.LA(1);

                   	 
                   	int index47_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred2_simpletikz()) ) { s = 15; }

                   	else if ( (synpred3_simpletikz()) ) { s = 16; }

                   	else if ( (synpred4_simpletikz()) ) { s = 17; }

                   	 
                   	input.Seek(index47_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA47_3 = input.LA(1);

                   	 
                   	int index47_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred2_simpletikz()) ) { s = 15; }

                   	else if ( (synpred3_simpletikz()) ) { s = 16; }

                   	else if ( (synpred4_simpletikz()) ) { s = 17; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index47_3);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae =
            new NoViableAltException(dfa.Description, 47, _s, input);
        dfa.Error(nvae);
        throw nvae;
    }
    const string DFA49_eotS =
        "\x15\uffff";
    const string DFA49_eofS =
        "\x15\uffff";
    const string DFA49_minS =
        "\x01\x1c\x03\x00\x11\uffff";
    const string DFA49_maxS =
        "\x01\x56\x03\x00\x11\uffff";
    const string DFA49_acceptS =
        "\x04\uffff\x01\x04\x0d\uffff\x01\x01\x01\x02\x01\x03";
    const string DFA49_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x11\uffff}>";
    static readonly string[] DFA49_transitionS = {
            "\x02\x04\x0d\uffff\x03\x04\x01\uffff\x01\x04\x04\uffff\x01"+
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

    static readonly short[] DFA49_eot = DFA.UnpackEncodedString(DFA49_eotS);
    static readonly short[] DFA49_eof = DFA.UnpackEncodedString(DFA49_eofS);
    static readonly char[] DFA49_min = DFA.UnpackEncodedStringToUnsignedChars(DFA49_minS);
    static readonly char[] DFA49_max = DFA.UnpackEncodedStringToUnsignedChars(DFA49_maxS);
    static readonly short[] DFA49_accept = DFA.UnpackEncodedString(DFA49_acceptS);
    static readonly short[] DFA49_special = DFA.UnpackEncodedString(DFA49_specialS);
    static readonly short[][] DFA49_transition = DFA.UnpackEncodedStringArray(DFA49_transitionS);

    protected class DFA49 : DFA
    {
        public DFA49(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 49;
            this.eot = DFA49_eot;
            this.eof = DFA49_eof;
            this.min = DFA49_min;
            this.max = DFA49_max;
            this.accept = DFA49_accept;
            this.special = DFA49_special;
            this.transition = DFA49_transition;

        }

        override public string Description
        {
            get { return "367:18: ( ( ( tikzcoordinate_core3 )=> tikzcoordinate_core3 ) | ( ( tikzcoordinate_core2 )=> tikzcoordinate_core2 ) | ( ( tikzcoordinate_core1 )=> tikzcoordinate_core1 ) )?"; }
        }

    }


    protected internal int DFA49_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA49_1 = input.LA(1);

                   	 
                   	int index49_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred5_simpletikz()) ) { s = 18; }

                   	else if ( (synpred6_simpletikz()) ) { s = 19; }

                   	else if ( (synpred7_simpletikz()) ) { s = 20; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index49_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA49_2 = input.LA(1);

                   	 
                   	int index49_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred5_simpletikz()) ) { s = 18; }

                   	else if ( (synpred6_simpletikz()) ) { s = 19; }

                   	else if ( (synpred7_simpletikz()) ) { s = 20; }

                   	 
                   	input.Seek(index49_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA49_3 = input.LA(1);

                   	 
                   	int index49_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred5_simpletikz()) ) { s = 18; }

                   	else if ( (synpred6_simpletikz()) ) { s = 19; }

                   	else if ( (synpred7_simpletikz()) ) { s = 20; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index49_3);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae =
            new NoViableAltException(dfa.Description, 49, _s, input);
        dfa.Error(nvae);
        throw nvae;
    }
    const string DFA56_eotS =
        "\x0a\uffff";
    const string DFA56_eofS =
        "\x0a\uffff";
    const string DFA56_minS =
        "\x01\x1c\x01\x04\x01\uffff\x02\x04\x01\x00\x01\x04\x01\uffff\x02"+
        "\x04";
    const string DFA56_maxS =
        "\x01\x56\x01\x59\x01\uffff\x02\x59\x01\x00\x01\x59\x01\uffff\x02"+
        "\x59";
    const string DFA56_acceptS =
        "\x02\uffff\x01\x02\x04\uffff\x01\x01\x02\uffff";
    const string DFA56_specialS =
        "\x05\uffff\x01\x00\x04\uffff}>";
    static readonly string[] DFA56_transitionS = {
            "\x02\x02\x0d\uffff\x03\x02\x01\uffff\x01\x02\x04\uffff\x01"+
            "\x01\x02\x02\x01\uffff\x01\x02\x01\uffff\x01\x02\x0d\uffff\x01"+
            "\x02\x01\uffff\x02\x02\x01\uffff\x0a\x02",
            "\x1a\x02\x02\x03\x0c\x02\x01\uffff\x02\x02\x04\uffff\x04\x02"+
            "\x02\uffff\x21\x02",
            "",
            "\x27\x02\x02\uffff\x04\x02\x02\uffff\x01\x02\x01\uffff\x01"+
            "\x05\x03\uffff\x06\x04\x0a\x02\x01\x06\x10\x02",
            "\x27\x02\x02\uffff\x04\x02\x02\uffff\x01\x02\x01\uffff\x01"+
            "\x05\x03\uffff\x10\x02\x01\x06\x10\x02",
            "\x01\uffff",
            "\x1a\x02\x02\x08\x0b\x02\x02\uffff\x04\x02\x02\uffff\x01\x02"+
            "\x01\uffff\x01\x02\x03\uffff\x21\x02",
            "",
            "\x27\x02\x02\uffff\x04\x02\x02\uffff\x01\x02\x01\uffff\x01"+
            "\x05\x03\uffff\x06\x09\x1b\x02",
            "\x27\x02\x02\uffff\x04\x02\x02\uffff\x01\x02\x01\uffff\x01"+
            "\x05\x03\uffff\x21\x02"
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
            get { return "417:27: ( ( size )=> size )?"; }
        }

    }


    protected internal int DFA56_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA56_5 = input.LA(1);

                   	 
                   	int index56_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_simpletikz()) ) { s = 7; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index56_5);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae =
            new NoViableAltException(dfa.Description, 56, _s, input);
        dfa.Error(nvae);
        throw nvae;
    }
    const string DFA59_eotS =
        "\x14\uffff";
    const string DFA59_eofS =
        "\x14\uffff";
    const string DFA59_minS =
        "\x01\x4f\x01\x34\x01\x04\x01\uffff\x01\x04\x01\uffff\x0b\x04\x01"+
        "\uffff\x02\x04";
    const string DFA59_maxS =
        "\x01\x4f\x01\x36\x01\x59\x01\uffff\x01\x59\x01\uffff\x0b\x59\x01"+
        "\uffff\x02\x59";
    const string DFA59_acceptS =
        "\x03\uffff\x01\x03\x01\uffff\x01\x02\x0b\uffff\x01\x01\x02\uffff";
    const string DFA59_specialS =
        "\x14\uffff}>";
    static readonly string[] DFA59_transitionS = {
            "\x01\x01",
            "\x01\x02\x01\uffff\x01\x03",
            "\x19\x05\x01\x06\x02\x04\x0c\x05\x02\uffff\x01\x05\x04\uffff"+
            "\x01\x05\x05\uffff\x21\x05",
            "",
            "\x27\x05\x02\uffff\x02\x05\x01\uffff\x01\x08\x02\uffff\x01"+
            "\x05\x05\uffff\x06\x07\x1b\x05",
            "",
            "\x27\x05\x02\uffff\x02\x05\x01\uffff\x01\x08\x02\uffff\x01"+
            "\x05\x05\uffff\x21\x05",
            "\x27\x05\x02\uffff\x02\x05\x01\uffff\x01\x08\x02\uffff\x01"+
            "\x05\x05\uffff\x21\x05",
            "\x19\x05\x01\x0a\x02\x09\x0c\x05\x02\uffff\x01\x05\x04\uffff"+
            "\x01\x05\x05\uffff\x21\x05",
            "\x27\x05\x02\uffff\x02\x05\x01\uffff\x01\x0c\x02\uffff\x01"+
            "\x05\x05\uffff\x06\x0b\x1b\x05",
            "\x27\x05\x02\uffff\x02\x05\x01\uffff\x01\x0c\x02\uffff\x01"+
            "\x05\x05\uffff\x21\x05",
            "\x27\x05\x02\uffff\x02\x05\x01\uffff\x01\x0c\x02\uffff\x01"+
            "\x05\x05\uffff\x21\x05",
            "\x19\x05\x01\x0e\x02\x0d\x0c\x05\x02\uffff\x01\x05\x04\uffff"+
            "\x01\x05\x05\uffff\x21\x05",
            "\x27\x05\x02\uffff\x02\x05\x04\uffff\x01\x05\x01\uffff\x01"+
            "\x11\x03\uffff\x06\x0f\x0a\x05\x01\x10\x10\x05",
            "\x27\x05\x02\uffff\x02\x05\x04\uffff\x01\x05\x01\uffff\x01"+
            "\x11\x03\uffff\x10\x05\x01\x10\x10\x05",
            "\x27\x05\x02\uffff\x02\x05\x04\uffff\x01\x05\x01\uffff\x01"+
            "\x11\x03\uffff\x10\x05\x01\x10\x10\x05",
            "\x1a\x05\x02\x12\x0b\x05\x02\uffff\x02\x05\x04\uffff\x01\x05"+
            "\x01\uffff\x01\x05\x03\uffff\x21\x05",
            "",
            "\x27\x05\x02\uffff\x02\x05\x04\uffff\x01\x05\x01\uffff\x01"+
            "\x11\x03\uffff\x06\x13\x1b\x05",
            "\x27\x05\x02\uffff\x02\x05\x04\uffff\x01\x05\x01\uffff\x01"+
            "\x11\x03\uffff\x21\x05"
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
            get { return "419:1: arc : ( 'arc' ( '(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ( 'and' numberunit )? ')' ) -> ^( IM_ARC ( numberunitorvariable )+ ( numberunit )? ) | 'arc' ( '(' coord_part ':' coord_part ':' coord_part ( 'and' numberunit )? ')' ) -> ^( IM_ARC ( coord_part )+ ( numberunit )? ) | 'arc' tikz_options -> ^( IM_DONTCARE ) );"; }
        }

    }

    const string DFA65_eotS =
        "\x0c\uffff";
    const string DFA65_eofS =
        "\x0c\uffff";
    const string DFA65_minS =
        "\x02\x34\x02\x04\x01\uffff\x01\x04\x01\uffff\x04\x04\x01\uffff";
    const string DFA65_maxS =
        "\x01\x55\x01\x34\x02\x59\x01\uffff\x01\x59\x01\uffff\x04\x59\x01"+
        "\uffff";
    const string DFA65_acceptS =
        "\x04\uffff\x01\x01\x01\uffff\x01\x03\x04\uffff\x01\x02";
    const string DFA65_specialS =
        "\x0c\uffff}>";
    static readonly string[] DFA65_transitionS = {
            "\x01\x02\x1f\uffff\x02\x01",
            "\x01\x02",
            "\x1a\x05\x02\x03\x0b\x05\x01\x06\x02\uffff\x01\x05\x04\uffff"+
            "\x01\x05\x02\uffff\x01\x04\x02\uffff\x21\x05",
            "\x27\x05\x02\uffff\x01\x06\x01\x05\x02\x08\x02\uffff\x01\x05"+
            "\x01\uffff\x01\x04\x03\uffff\x06\x07\x1b\x05",
            "",
            "\x27\x05\x02\uffff\x01\x06\x01\x05\x02\x06\x02\uffff\x01\x05"+
            "\x01\uffff\x01\x04\x03\uffff\x21\x05",
            "",
            "\x27\x05\x02\uffff\x01\x06\x01\x05\x02\x08\x02\uffff\x01\x05"+
            "\x01\uffff\x01\x04\x03\uffff\x21\x05",
            "\x1a\x06\x02\x09\x0c\x06\x02\uffff\x01\x06\x04\uffff\x01\x06"+
            "\x05\uffff\x21\x06",
            "\x27\x06\x02\uffff\x02\x06\x04\uffff\x01\x06\x01\uffff\x01"+
            "\x0b\x03\uffff\x06\x0a\x1b\x06",
            "\x27\x06\x02\uffff\x02\x06\x04\uffff\x01\x06\x01\uffff\x01"+
            "\x0b\x03\uffff\x21\x06",
            ""
    };

    static readonly short[] DFA65_eot = DFA.UnpackEncodedString(DFA65_eotS);
    static readonly short[] DFA65_eof = DFA.UnpackEncodedString(DFA65_eofS);
    static readonly char[] DFA65_min = DFA.UnpackEncodedStringToUnsignedChars(DFA65_minS);
    static readonly char[] DFA65_max = DFA.UnpackEncodedStringToUnsignedChars(DFA65_maxS);
    static readonly short[] DFA65_accept = DFA.UnpackEncodedString(DFA65_acceptS);
    static readonly short[] DFA65_special = DFA.UnpackEncodedString(DFA65_specialS);
    static readonly short[][] DFA65_transition = DFA.UnpackEncodedStringArray(DFA65_transitionS);

    protected class DFA65 : DFA
    {
        public DFA65(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 65;
            this.eot = DFA65_eot;
            this.eof = DFA65_eof;
            this.min = DFA65_min;
            this.max = DFA65_max;
            this.accept = DFA65_accept;
            this.special = DFA65_special;
            this.transition = DFA65_transition;

        }

        override public string Description
        {
            get { return "439:1: coord : ( ( ( coord_modifier )? coord_nodename ) -> ^( IM_COORD ( coord_modifier )? coord_nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) );"; }
        }

    }

    const string DFA68_eotS =
        "\x0f\uffff";
    const string DFA68_eofS =
        "\x0f\uffff";
    const string DFA68_minS =
        "\x01\x34\x01\x04\x01\x34\x02\x04\x01\uffff\x03\x04\x01\uffff\x04"+
        "\x04\x01\uffff";
    const string DFA68_maxS =
        "\x01\x55\x01\x59\x01\x34\x02\x59\x01\uffff\x03\x59\x01\uffff\x04"+
        "\x59\x01\uffff";
    const string DFA68_acceptS =
        "\x05\uffff\x01\x03\x03\uffff\x01\x01\x04\uffff\x01\x02";
    const string DFA68_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA68_transitionS = {
            "\x01\x01\x1f\uffff\x02\x02",
            "\x1a\x04\x02\x03\x0b\x04\x01\x05\x02\uffff\x01\x04\x04\uffff"+
            "\x01\x04\x05\uffff\x21\x04",
            "\x01\x06",
            "\x27\x04\x02\uffff\x01\x05\x01\x04\x02\x08\x02\uffff\x01\x04"+
            "\x01\uffff\x01\x09\x03\uffff\x06\x07\x1b\x04",
            "\x27\x04\x02\uffff\x01\x05\x01\x04\x02\x05\x02\uffff\x01\x04"+
            "\x01\uffff\x01\x09\x03\uffff\x21\x04",
            "",
            "\x1a\x05\x02\x0a\x0c\x05\x02\uffff\x01\x05\x04\uffff\x01\x05"+
            "\x05\uffff\x21\x05",
            "\x27\x04\x02\uffff\x01\x05\x01\x04\x02\x08\x02\uffff\x01\x04"+
            "\x01\uffff\x01\x09\x03\uffff\x21\x04",
            "\x1a\x05\x02\x0b\x0c\x05\x02\uffff\x01\x05\x04\uffff\x01\x05"+
            "\x05\uffff\x21\x05",
            "",
            "\x27\x05\x02\uffff\x02\x05\x02\x08\x02\uffff\x01\x05\x05\uffff"+
            "\x06\x0c\x1b\x05",
            "\x27\x05\x02\uffff\x02\x05\x04\uffff\x01\x05\x01\uffff\x01"+
            "\x0e\x03\uffff\x06\x0d\x1b\x05",
            "\x27\x05\x02\uffff\x02\x05\x02\x08\x02\uffff\x01\x05\x05\uffff"+
            "\x21\x05",
            "\x27\x05\x02\uffff\x02\x05\x04\uffff\x01\x05\x01\uffff\x01"+
            "\x0e\x03\uffff\x21\x05",
            ""
    };

    static readonly short[] DFA68_eot = DFA.UnpackEncodedString(DFA68_eotS);
    static readonly short[] DFA68_eof = DFA.UnpackEncodedString(DFA68_eofS);
    static readonly char[] DFA68_min = DFA.UnpackEncodedStringToUnsignedChars(DFA68_minS);
    static readonly char[] DFA68_max = DFA.UnpackEncodedStringToUnsignedChars(DFA68_maxS);
    static readonly short[] DFA68_accept = DFA.UnpackEncodedString(DFA68_acceptS);
    static readonly short[] DFA68_special = DFA.UnpackEncodedString(DFA68_specialS);
    static readonly short[][] DFA68_transition = DFA.UnpackEncodedStringArray(DFA68_transitionS);

    protected class DFA68 : DFA
    {
        public DFA68(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 68;
            this.eot = DFA68_eot;
            this.eof = DFA68_eof;
            this.min = DFA68_min;
            this.max = DFA68_max;
            this.accept = DFA68_accept;
            this.special = DFA68_special;
            this.transition = DFA68_transition;

        }

        override public string Description
        {
            get { return "444:1: coord_nooption : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? '(' numberunit coord_sep numberunit ')' ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) | ( ( coord_modifier )? '(' coord_part coord_sep coord_part ')' ) -> ^( IM_COORD ( coord_modifier )? ( coord_part )+ coord_sep ) );"; }
        }

    }

    const string DFA71_eotS =
        "\x08\uffff";
    const string DFA71_eofS =
        "\x08\uffff";
    const string DFA71_minS =
        "\x02\x04\x02\uffff\x01\x04\x01\uffff\x02\x04";
    const string DFA71_maxS =
        "\x02\x59\x02\uffff\x01\x59\x01\uffff\x02\x59";
    const string DFA71_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\uffff\x01\x01\x02\uffff";
    const string DFA71_specialS =
        "\x08\uffff}>";
    static readonly string[] DFA71_transitionS = {
            "\x27\x01\x01\x02\x02\uffff\x01\x01\x04\uffff\x01\x01\x05\uffff"+
            "\x21\x01",
            "\x27\x01\x02\uffff\x01\x03\x01\x01\x02\x05\x02\uffff\x01\x01"+
            "\x01\uffff\x01\x05\x03\uffff\x10\x01\x01\x04\x10\x01",
            "",
            "",
            "\x1a\x01\x02\x06\x0b\x01\x02\uffff\x01\x03\x01\x01\x02\x05"+
            "\x02\uffff\x01\x01\x01\uffff\x01\x05\x03\uffff\x10\x01\x01\x04"+
            "\x10\x01",
            "",
            "\x27\x01\x02\uffff\x01\x03\x01\x01\x02\x05\x02\uffff\x01\x01"+
            "\x01\uffff\x01\x05\x03\uffff\x06\x07\x0a\x01\x01\x04\x10\x01",
            "\x27\x01\x02\uffff\x01\x03\x01\x01\x02\x05\x02\uffff\x01\x01"+
            "\x01\uffff\x01\x05\x03\uffff\x10\x01\x01\x04\x10\x01"
    };

    static readonly short[] DFA71_eot = DFA.UnpackEncodedString(DFA71_eotS);
    static readonly short[] DFA71_eof = DFA.UnpackEncodedString(DFA71_eofS);
    static readonly char[] DFA71_min = DFA.UnpackEncodedStringToUnsignedChars(DFA71_minS);
    static readonly char[] DFA71_max = DFA.UnpackEncodedStringToUnsignedChars(DFA71_maxS);
    static readonly short[] DFA71_accept = DFA.UnpackEncodedString(DFA71_acceptS);
    static readonly short[] DFA71_special = DFA.UnpackEncodedString(DFA71_specialS);
    static readonly short[][] DFA71_transition = DFA.UnpackEncodedStringArray(DFA71_transitionS);

    protected class DFA71 : DFA
    {
        public DFA71(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 71;
            this.eot = DFA71_eot;
            this.eof = DFA71_eof;
            this.min = DFA71_min;
            this.max = DFA71_max;
            this.accept = DFA71_accept;
            this.special = DFA71_special;
            this.transition = DFA71_transition;

        }

        override public string Description
        {
            get { return "456:1: coord_part : ( idd -> ^( IM_DONTCARE idd ) | '{' idd '}' -> ^( IM_DONTCARE '{' idd '}' ) | ( idd '=' numberunit ( ',' )? )+ -> ^( IM_DONTCARE ( idd '=' numberunit ( ',' )? )+ ) );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_dontcare_preamble_in_tikzdocument257 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_styleorsetorcmd_in_tikzdocument261 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzdocument265 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpicture_in_tikzdocument270 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_dontcare_preamble_in_tikzdocument_wo_tikzpicture296 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_styleorsetorcmd_in_tikzdocument_wo_tikzpicture300 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzdocument_wo_tikzpicture304 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000003FFFFFFUL});
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
    public static readonly BitSet FOLLOW_43_in_tikz_style420 = new BitSet(new ulong[]{0xFE0847FFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_idd_in_tikz_style422 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_tikz_style424 = new BitSet(new ulong[]{0x0000600000000000UL});
    public static readonly BitSet FOLLOW_45_in_tikz_style427 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_46_in_tikz_style431 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikz_style434 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_squarebr_start_in_tikz_options456 = new BitSet(new ulong[]{0xFE884FFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_options459 = new BitSet(new ulong[]{0xFE88CFFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_47_in_tikz_options462 = new BitSet(new ulong[]{0xFE0847FFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_options464 = new BitSet(new ulong[]{0xFE88CFFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_47_in_tikz_options468 = new BitSet(new ulong[]{0xFE884FFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikz_options473 = new BitSet(new ulong[]{0xFE884FFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_squarebr_end_in_tikz_options476 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_option_style_in_option501 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_option_kv_in_option510 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_option_kv524 = new BitSet(new ulong[]{0x0000200000000002UL});
    public static readonly BitSet FOLLOW_45_in_option_kv527 = new BitSet(new ulong[]{0xFE084FFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_iddornumberunitorstringorrange_in_option_kv529 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_tikzstring557 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_no_rlbrace_in_tikzstring559 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikzstring563 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_no_rlbrace_in_tikzstring565 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_44_in_tikzstring570 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_no_rlbrace593 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_range_in_iddornumberunitorstringorrange611 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_numberunit_in_iddornumberunitorstringorrange615 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_bracedcoord_in_iddornumberunitorstringorrange619 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_iddornumberunitorstringorrange623 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_number_in_iddornumberunitorstringorrange630 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_iddornumberunitorstringorrange633 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_tikzstring_in_iddornumberunitorstringorrange638 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_bracedcoord652 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000300000UL});
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
    public static readonly BitSet FOLLOW_43_in_option_style713 = new BitSet(new ulong[]{0xFE08D7FFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_option_kv_in_option_style716 = new BitSet(new ulong[]{0x0000900000000000UL});
    public static readonly BitSet FOLLOW_47_in_option_style719 = new BitSet(new ulong[]{0xFE0847FFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_option_kv_in_option_style721 = new BitSet(new ulong[]{0x0000900000000000UL});
    public static readonly BitSet FOLLOW_47_in_option_style728 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_option_style731 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_heavenknowswhythisisnecessary_in_idd766 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_idd_heavenknowswhythisisnecessary786 = new BitSet(new ulong[]{0xFE0847FFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_ID_in_idd2846 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_numberunit_in_numberunitorvariable865 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COMMAND_in_numberunitorvariable870 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_number_in_numberunit883 = new BitSet(new ulong[]{0x7E00000000000002UL});
    public static readonly BitSet FOLLOW_unit_in_numberunit885 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_number911 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unit0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_set_start_in_tikz_set966 = new BitSet(new ulong[]{0xFE0857FFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_set969 = new BitSet(new ulong[]{0xFE08D7FFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_47_in_tikz_set972 = new BitSet(new ulong[]{0xFE0847FFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_option_in_tikz_set974 = new BitSet(new ulong[]{0xFE08D7FFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_47_in_tikz_set978 = new BitSet(new ulong[]{0xFE0857FFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_roundbr_end_in_tikz_set983 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzpicture_start_in_tikzpicture1015 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpicture1017 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzpicture1020 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpicture_end_in_tikzpicture1023 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_start_in_tikzpicture1048 = new BitSet(new ulong[]{0x0040080000000000UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpicture1051 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikzpicture1054 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzbody2_in_tikzpicture1056 = new BitSet(new ulong[]{0xFE0857FFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_roundbr_end_in_tikzpicture1059 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody1091 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody1095 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_ext_in_tikzbody1099 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzmatrix_ext_in_tikzbody1103 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzcoordinate_ext_in_tikzbody1107 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody1111 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody1115 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody1119 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody1124 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_dontcare_body_nobr_in_tikzbody1129 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody1140 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody1144 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_ext_in_tikzbody1148 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzmatrix_ext_in_tikzbody1152 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzcoordinate_ext_in_tikzbody1156 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody1160 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody1164 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody1168 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody1173 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_dontcare_body_in_tikzbody1178 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody21194 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody21198 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_ext_in_tikzbody21202 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzmatrix_ext_in_tikzbody21206 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzcoordinate_ext_in_tikzbody21210 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody21214 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody21218 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody21222 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody21227 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_dontcare_body_nobr2_in_tikzbody21232 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody21243 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody21247 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikznode_ext_in_tikzbody21251 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzmatrix_ext_in_tikzbody21255 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzcoordinate_ext_in_tikzbody21259 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody21263 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody21267 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody21271 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody21276 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_dontcare_body2_in_tikzbody21281 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body_nobr21298 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body21372 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body_nobr1442 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body1509 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_63_in_otherend1572 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_otherend1574 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_idd2_in_otherend1576 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_otherend1578 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzscope_start_in_tikzscope1605 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzscope1607 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzscope1610 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzscope_end_in_tikzscope1613 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_in_tikzpath1669 = new BitSet(new ulong[]{0x0550280030000000UL,0x00000000007FED00UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath1671 = new BitSet(new ulong[]{0x0550280030000000UL,0x00000000007FED00UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzpath1674 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_let_cmd_parts0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzpath_element_single_in_tikzpath_element1730 = new BitSet(new ulong[]{0x0000800000000002UL});
    public static readonly BitSet FOLLOW_47_in_tikzpath_element1732 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpath_element_single1749 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_let_cmd_parts_in_tikzpath_element_single1756 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arc_in_tikzpath_element_single1774 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_in_tikzpath_element_single1784 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_controls_in_tikzpath_element_single1790 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_int_in_tikzpath_element_single1796 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_int_in_tikzpath_element_single1802 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_circle_in_tikzpath_element_single1808 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_roundbr_start_in_tikzpath_element_single1815 = new BitSet(new ulong[]{0xFE587FFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath_element_single1817 = new BitSet(new ulong[]{0xFE587FFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_roundbr_end_in_tikzpath_element_single1820 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_tikzpath_element_single1840 = new BitSet(new ulong[]{0x0470280030000000UL,0x00000000007FED00UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzpath_element_single1842 = new BitSet(new ulong[]{0x0470280030000000UL,0x00000000007FED00UL});
    public static readonly BitSet FOLLOW_53_in_tikzpath_element_single1845 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_edgeop_in_tikzpath_element_single1864 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_controls_start_in_controls1879 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000300000UL});
    public static readonly BitSet FOLLOW_coord_in_controls1881 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000400200UL});
    public static readonly BitSet FOLLOW_73_in_controls1884 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000300000UL});
    public static readonly BitSet FOLLOW_coord_in_controls1886 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000400200UL});
    public static readonly BitSet FOLLOW_controls_end_in_controls1890 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_node_start_in_tikznode_ext1916 = new BitSet(new ulong[]{0x0050080000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_tikznode_core_in_tikznode_ext1918 = new BitSet(new ulong[]{0x0550280030000000UL,0x00000000007FED00UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikznode_ext1920 = new BitSet(new ulong[]{0x0550280030000000UL,0x00000000007FED00UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikznode_ext1923 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrix_start_in_tikzmatrix_ext1950 = new BitSet(new ulong[]{0x0050080000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_tikznode_core_in_tikzmatrix_ext1952 = new BitSet(new ulong[]{0x0550280030000000UL,0x00000000007FED00UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzmatrix_ext1954 = new BitSet(new ulong[]{0x0550280030000000UL,0x00000000007FED00UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzmatrix_ext1957 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coordinate_start_in_tikzcoordinate_ext1985 = new BitSet(new ulong[]{0x0550280030000000UL,0x00000000007FFD00UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_ext2000 = new BitSet(new ulong[]{0x0550280030000000UL,0x00000000007FED00UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_ext2019 = new BitSet(new ulong[]{0x0550280030000000UL,0x00000000007FED00UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_ext2039 = new BitSet(new ulong[]{0x0550280030000000UL,0x00000000007FED00UL});
    public static readonly BitSet FOLLOW_tikzpath_element_in_tikzcoordinate_ext2050 = new BitSet(new ulong[]{0x0550280030000000UL,0x00000000007FED00UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzcoordinate_ext2053 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_74_in_tikzcoordinate_int2113 = new BitSet(new ulong[]{0x0050000000000002UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_tikzcoordinate_int2124 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_tikzcoordinate_int2143 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_tikzcoordinate_int2163 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_75_in_tikznode_int2179 = new BitSet(new ulong[]{0x0050080000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_tikznode_core_in_tikznode_int2182 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikznode_core2192 = new BitSet(new ulong[]{0x0050080000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikznode_core2195 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core32220 = new BitSet(new ulong[]{0x0050000000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core32222 = new BitSet(new ulong[]{0x0050000000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core32224 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core22258 = new BitSet(new ulong[]{0x0050000000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core22260 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_decorator_in_tikzcoordinate_core12293 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_tikznode_decorator2330 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_76_in_tikznode_decorator2337 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_COMMAND_in_tikznode_decorator2340 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_76_in_tikznode_decorator2346 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000300000UL});
    public static readonly BitSet FOLLOW_coord_in_tikznode_decorator2349 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_options_dontcare_in_tikznode_decorator2355 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_tikz_options_dontcare2365 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_no_rlbracket_in_tikz_options_dontcare2367 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_options_dontcare_in_tikz_options_dontcare2371 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_no_rlbracket_in_tikz_options_dontcare2373 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_55_in_tikz_options_dontcare2378 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_no_rlbracket2396 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_nodename2413 = new BitSet(new ulong[]{0xFE0847FFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_idd_in_nodename2415 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_nodename2417 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_77_in_circle2442 = new BitSet(new ulong[]{0x0010000000000002UL});
    public static readonly BitSet FOLLOW_78_in_circle2446 = new BitSet(new ulong[]{0x0010000000000002UL});
    public static readonly BitSet FOLLOW_size_in_circle2455 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_79_in_arc2470 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_arc2473 = new BitSet(new ulong[]{0x00000000E0000000UL});
    public static readonly BitSet FOLLOW_numberunitorvariable_in_arc2475 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_arc2477 = new BitSet(new ulong[]{0x00000000E0000000UL});
    public static readonly BitSet FOLLOW_numberunitorvariable_in_arc2479 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_arc2481 = new BitSet(new ulong[]{0x00000000E0000000UL});
    public static readonly BitSet FOLLOW_numberunitorvariable_in_arc2483 = new BitSet(new ulong[]{0x0020000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_73_in_arc2486 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_arc2488 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_arc2492 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_79_in_arc2510 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_arc2513 = new BitSet(new ulong[]{0xFE084FFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_arc2515 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_arc2517 = new BitSet(new ulong[]{0xFE084FFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_arc2519 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_arc2521 = new BitSet(new ulong[]{0xFE084FFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_arc2523 = new BitSet(new ulong[]{0x0020000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_73_in_arc2526 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_arc2528 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_arc2532 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_79_in_arc2550 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_tikz_options_in_arc2552 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_size2577 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_size2579 = new BitSet(new ulong[]{0x0020000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_73_in_size2582 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_size2584 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_size2588 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_coord_nodename2616 = new BitSet(new ulong[]{0xFE4847FFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_tikz_options_in_coord_nodename2618 = new BitSet(new ulong[]{0xFE0847FFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_idd_in_coord_nodename2621 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_coord_nodename2624 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord2650 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000300000UL});
    public static readonly BitSet FOLLOW_coord_nodename_in_coord2653 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord2679 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_coord2682 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord2684 = new BitSet(new ulong[]{0x0001800000000000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord2686 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord2688 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_coord2690 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord2714 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_coord2717 = new BitSet(new ulong[]{0xFE084FFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_coord2719 = new BitSet(new ulong[]{0x0001800000000000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord2721 = new BitSet(new ulong[]{0xFE084FFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_coord2723 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_coord2725 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_coord_nooption2754 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord_nooption2778 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_coord_nooption2781 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord_nooption2783 = new BitSet(new ulong[]{0x0001800000000000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord_nooption2785 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord_nooption2787 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_coord_nooption2789 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord_nooption2813 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_coord_nooption2816 = new BitSet(new ulong[]{0xFE084FFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_coord_nooption2818 = new BitSet(new ulong[]{0x0001800000000000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord_nooption2820 = new BitSet(new ulong[]{0xFE084FFFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_coord_part_in_coord_nooption2822 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_coord_nooption2824 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_coord_part2857 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_coord_part2872 = new BitSet(new ulong[]{0xFE0847FFFFFFFFF0UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_idd_in_coord_part2874 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_coord_part2876 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_coord_part2894 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_coord_part2896 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord_part2898 = new BitSet(new ulong[]{0xFE08C7FFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_47_in_coord_part2900 = new BitSet(new ulong[]{0xFE0847FFFFFFFFF2UL,0x0000000003FFFFFFUL});
    public static readonly BitSet FOLLOW_set_in_coord_sep2932 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_edgeop0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_coord_modifier0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_squarebr_start3006 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_squarebr_end3024 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_semicolon_end3043 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_roundbr_start3061 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_44_in_roundbr_end3079 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_86_in_controls_start3097 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_87_in_controls_start3099 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_86_in_controls_end3117 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_41_in_tikz_set_start3135 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikz_set_start3137 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_tikzpicture_start3156 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikzpicture_start3158 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000001000000UL});
    public static readonly BitSet FOLLOW_88_in_tikzpicture_start3160 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_tikzpicture_start3162 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_42_in_tikz_start3180 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_63_in_tikzpicture_end3198 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikzpicture_end3200 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000001000000UL});
    public static readonly BitSet FOLLOW_88_in_tikzpicture_end3202 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_tikzpicture_end3204 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_tikzscope_start3222 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikzscope_start3224 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_89_in_tikzscope_start3226 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_tikzscope_start3228 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_63_in_tikzscope_end3246 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_tikzscope_end3248 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_89_in_tikzscope_end3250 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_tikzscope_end3252 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_tag_in_path_start3271 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_node_start_tag_in_node_start3289 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrix_start_tag_in_matrix_start3307 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_64_in_node_start_tag3325 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_65_in_matrix_start_tag3335 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_66_in_coordinate_start3345 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_path_start_tag0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_in_synpred1_simpletikz1781 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_synpred2_simpletikz1996 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_synpred3_simpletikz2015 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_synpred4_simpletikz2035 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core3_in_synpred5_simpletikz2120 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core2_in_synpred6_simpletikz2139 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzcoordinate_core1_in_synpred7_simpletikz2159 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_size_in_synpred8_simpletikz2451 = new BitSet(new ulong[]{0x0000000000000002UL});

}
