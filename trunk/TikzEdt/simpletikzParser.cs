// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g 2010-12-12 23:24:32

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



using Antlr.Runtime.Tree;

public partial class simpletikzParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"BEGIN", 
		"END", 
		"USETIKZLIB", 
		"TIKZSTYLE", 
		"TIKZSET", 
		"NODE", 
		"DRAW", 
		"PATH", 
		"FILL", 
		"LPAR", 
		"RPAR", 
		"LBR", 
		"RBR", 
		"LBRR", 
		"RBRR", 
		"KOMMA", 
		"EQU", 
		"SEMIC", 
		"COLON", 
		"IM_PATH", 
		"IM_NODE", 
		"IM_COORD", 
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
		"ID", 
		"FLOAT", 
		"INT", 
		"EXPONENT", 
		"COMMENT", 
		"WS", 
		"ESC_SEQ", 
		"MATHSTRING", 
		"COMMAND", 
		"SOMETHING", 
		"'/.style'", 
		"'cm'", 
		"'in'", 
		"'ex'", 
		"'mm'", 
		"'pt'", 
		"'node'", 
		"'at'", 
		"'--'", 
		"'edge'", 
		"'->'", 
		"'|-'", 
		"'-|'", 
		"'to'", 
		"'grid'", 
		"'rectangle'", 
		"'+'", 
		"'++'", 
		"'tikzpicture'", 
		"'scope'"
    };

    public const int T__68 = 68;
    public const int T__69 = 69;
    public const int T__66 = 66;
    public const int EXPONENT = 44;
    public const int T__67 = 67;
    public const int T__64 = 64;
    public const int IM_STARTTAG = 31;
    public const int T__65 = 65;
    public const int T__62 = 62;
    public const int T__63 = 63;
    public const int RBR = 16;
    public const int IM_PATH = 23;
    public const int IM_ID = 36;
    public const int FLOAT = 42;
    public const int SOMETHING = 50;
    public const int ID = 41;
    public const int T__61 = 61;
    public const int T__60 = 60;
    public const int EOF = -1;
    public const int MATHSTRING = 48;
    public const int LBR = 15;
    public const int COMMAND = 49;
    public const int IM_ENDTAG = 32;
    public const int IM_USETIKZLIB = 38;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int IM_DOCUMENT = 29;
    public const int T__58 = 58;
    public const int RBRR = 18;
    public const int ESC_SEQ = 47;
    public const int IM_STRING = 39;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int LPAR = 13;
    public const int T__54 = 54;
    public const int FILL = 12;
    public const int PATH = 11;
    public const int IM_TIKZSET = 37;
    public const int T__59 = 59;
    public const int BEGIN = 4;
    public const int IM_OPTION_KV = 35;
    public const int COMMENT = 45;
    public const int IM_OPTIONS = 33;
    public const int IM_OPTION_STYLE = 34;
    public const int NODE = 9;
    public const int TIKZSTYLE = 7;
    public const int TIKZSET = 8;
    public const int IM_COORD = 25;
    public const int IM_PICTURE = 28;
    public const int INT = 43;
    public const int LBRR = 17;
    public const int IM_NODE = 24;
    public const int USETIKZLIB = 6;
    public const int IM_STYLE = 40;
    public const int COLON = 22;
    public const int IM_SCOPE = 30;
    public const int IM_NUMBERUNIT = 27;
    public const int WS = 46;
    public const int T__70 = 70;
    public const int KOMMA = 19;
    public const int EQU = 20;
    public const int RPAR = 14;
    public const int END = 5;
    public const int SEMIC = 21;
    public const int IM_NODENAME = 26;
    public const int DRAW = 10;

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:88:1: tikzdocument : ( dontcare_preamble | tikz_styleorset | otherbegin )* tikzpicture -> ^( IM_DOCUMENT ( tikz_styleorset )* tikzpicture ) ;
    public simpletikzParser.tikzdocument_return tikzdocument() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzdocument_return retval = new simpletikzParser.tikzdocument_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.dontcare_preamble_return dontcare_preamble1 = default(simpletikzParser.dontcare_preamble_return);

        simpletikzParser.tikz_styleorset_return tikz_styleorset2 = default(simpletikzParser.tikz_styleorset_return);

        simpletikzParser.otherbegin_return otherbegin3 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.tikzpicture_return tikzpicture4 = default(simpletikzParser.tikzpicture_return);


        RewriteRuleSubtreeStream stream_dontcare_preamble = new RewriteRuleSubtreeStream(adaptor,"rule dontcare_preamble");
        RewriteRuleSubtreeStream stream_tikzpicture = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture");
        RewriteRuleSubtreeStream stream_otherbegin = new RewriteRuleSubtreeStream(adaptor,"rule otherbegin");
        RewriteRuleSubtreeStream stream_tikz_styleorset = new RewriteRuleSubtreeStream(adaptor,"rule tikz_styleorset");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:2: ( ( dontcare_preamble | tikz_styleorset | otherbegin )* tikzpicture -> ^( IM_DOCUMENT ( tikz_styleorset )* tikzpicture ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:5: ( dontcare_preamble | tikz_styleorset | otherbegin )* tikzpicture
            {
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:5: ( dontcare_preamble | tikz_styleorset | otherbegin )*
            	do 
            	{
            	    int alt1 = 4;
            	    switch ( input.LA(1) ) 
            	    {
            	    case BEGIN:
            	    	{
            	        int LA1_1 = input.LA(2);

            	        if ( (LA1_1 == LBRR) )
            	        {
            	            int LA1_4 = input.LA(3);

            	            if ( (LA1_4 == ID) )
            	            {
            	                alt1 = 3;
            	            }


            	        }


            	        }
            	        break;
            	    case END:
            	    case USETIKZLIB:
            	    case NODE:
            	    case DRAW:
            	    case PATH:
            	    case FILL:
            	    case LPAR:
            	    case RPAR:
            	    case LBR:
            	    case RBR:
            	    case LBRR:
            	    case RBRR:
            	    case KOMMA:
            	    case EQU:
            	    case SEMIC:
            	    case COLON:
            	    case IM_PATH:
            	    case IM_NODE:
            	    case IM_COORD:
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
            	    case ID:
            	    case FLOAT:
            	    case INT:
            	    case EXPONENT:
            	    case COMMENT:
            	    case WS:
            	    case ESC_SEQ:
            	    case MATHSTRING:
            	    case COMMAND:
            	    case SOMETHING:
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
            	    	{
            	        alt1 = 1;
            	        }
            	        break;
            	    case TIKZSTYLE:
            	    case TIKZSET:
            	    	{
            	        alt1 = 2;
            	        }
            	        break;

            	    }

            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:6: dontcare_preamble
            			    {
            			    	PushFollow(FOLLOW_dontcare_preamble_in_tikzdocument341);
            			    	dontcare_preamble1 = dontcare_preamble();
            			    	state.followingStackPointer--;

            			    	stream_dontcare_preamble.Add(dontcare_preamble1.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:26: tikz_styleorset
            			    {
            			    	PushFollow(FOLLOW_tikz_styleorset_in_tikzdocument345);
            			    	tikz_styleorset2 = tikz_styleorset();
            			    	state.followingStackPointer--;

            			    	stream_tikz_styleorset.Add(tikz_styleorset2.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:44: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzdocument349);
            			    	otherbegin3 = otherbegin();
            			    	state.followingStackPointer--;

            			    	stream_otherbegin.Add(otherbegin3.Tree);

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	PushFollow(FOLLOW_tikzpicture_in_tikzdocument354);
            	tikzpicture4 = tikzpicture();
            	state.followingStackPointer--;

            	stream_tikzpicture.Add(tikzpicture4.Tree);


            	// AST REWRITE
            	// elements:          tikz_styleorset, tikzpicture
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 89:73: -> ^( IM_DOCUMENT ( tikz_styleorset )* tikzpicture )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:76: ^( IM_DOCUMENT ( tikz_styleorset )* tikzpicture )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DOCUMENT, "IM_DOCUMENT"), root_1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:90: ( tikz_styleorset )*
            	    while ( stream_tikz_styleorset.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikz_styleorset.NextTree());

            	    }
            	    stream_tikz_styleorset.Reset();
            	    adaptor.AddChild(root_1, stream_tikzpicture.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tikzdocument"

    public class tikz_styleorset_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikz_styleorset"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:92:1: tikz_styleorset : ( tikz_style | tikz_set );
    public simpletikzParser.tikz_styleorset_return tikz_styleorset() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_styleorset_return retval = new simpletikzParser.tikz_styleorset_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikz_style_return tikz_style5 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.tikz_set_return tikz_set6 = default(simpletikzParser.tikz_set_return);



        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:93:2: ( tikz_style | tikz_set )
            int alt2 = 2;
            int LA2_0 = input.LA(1);

            if ( (LA2_0 == TIKZSTYLE) )
            {
                alt2 = 1;
            }
            else if ( (LA2_0 == TIKZSET) )
            {
                alt2 = 2;
            }
            else 
            {
                NoViableAltException nvae_d2s0 =
                    new NoViableAltException("", 2, 0, input);

                throw nvae_d2s0;
            }
            switch (alt2) 
            {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:93:4: tikz_style
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_style_in_tikz_styleorset379);
                    	tikz_style5 = tikz_style();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, tikz_style5.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:93:17: tikz_set
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_set_in_tikz_styleorset383);
                    	tikz_set6 = tikz_set();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, tikz_set6.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tikz_styleorset"

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:96:1: dontcare_preamble : ~ ( BEGIN | TIKZSTYLE | TIKZSET ) ;
    public simpletikzParser.dontcare_preamble_return dontcare_preamble() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_preamble_return retval = new simpletikzParser.dontcare_preamble_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set7 = null;

        object set7_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:97:2: (~ ( BEGIN | TIKZSTYLE | TIKZSET ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:97:4: ~ ( BEGIN | TIKZSTYLE | TIKZSET )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set7 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= END && input.LA(1) <= USETIKZLIB) || (input.LA(1) >= NODE && input.LA(1) <= 70) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set7));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:99:1: otherbegin : BEGIN LBRR idd RBRR ;
    public simpletikzParser.otherbegin_return otherbegin() // throws RecognitionException [1]
    {   
        simpletikzParser.otherbegin_return retval = new simpletikzParser.otherbegin_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken BEGIN8 = null;
        IToken LBRR9 = null;
        IToken RBRR11 = null;
        simpletikzParser.idd_return idd10 = default(simpletikzParser.idd_return);


        object BEGIN8_tree=null;
        object LBRR9_tree=null;
        object RBRR11_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:2: ( BEGIN LBRR idd RBRR )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:4: BEGIN LBRR idd RBRR
            {
            	root_0 = (object)adaptor.GetNilNode();

            	BEGIN8=(IToken)Match(input,BEGIN,FOLLOW_BEGIN_in_otherbegin415); 
            		BEGIN8_tree = (object)adaptor.Create(BEGIN8);
            		adaptor.AddChild(root_0, BEGIN8_tree);

            	LBRR9=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_otherbegin417); 
            		LBRR9_tree = (object)adaptor.Create(LBRR9);
            		adaptor.AddChild(root_0, LBRR9_tree);

            	PushFollow(FOLLOW_idd_in_otherbegin419);
            	idd10 = idd();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, idd10.Tree);
            	RBRR11=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_otherbegin421); 
            		RBRR11_tree = (object)adaptor.Create(RBRR11);
            		adaptor.AddChild(root_0, RBRR11_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:103:1: tikz_style : TIKZSTYLE LBRR idd RBRR '=' tikz_options -> ^( IM_STYLE idd tikz_options ) ;
    public simpletikzParser.tikz_style_return tikz_style() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_style_return retval = new simpletikzParser.tikz_style_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken TIKZSTYLE12 = null;
        IToken LBRR13 = null;
        IToken RBRR15 = null;
        IToken char_literal16 = null;
        simpletikzParser.idd_return idd14 = default(simpletikzParser.idd_return);

        simpletikzParser.tikz_options_return tikz_options17 = default(simpletikzParser.tikz_options_return);


        object TIKZSTYLE12_tree=null;
        object LBRR13_tree=null;
        object RBRR15_tree=null;
        object char_literal16_tree=null;
        RewriteRuleTokenStream stream_EQU = new RewriteRuleTokenStream(adaptor,"token EQU");
        RewriteRuleTokenStream stream_RBRR = new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_TIKZSTYLE = new RewriteRuleTokenStream(adaptor,"token TIKZSTYLE");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:104:2: ( TIKZSTYLE LBRR idd RBRR '=' tikz_options -> ^( IM_STYLE idd tikz_options ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:104:4: TIKZSTYLE LBRR idd RBRR '=' tikz_options
            {
            	TIKZSTYLE12=(IToken)Match(input,TIKZSTYLE,FOLLOW_TIKZSTYLE_in_tikz_style432);  
            	stream_TIKZSTYLE.Add(TIKZSTYLE12);

            	LBRR13=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_tikz_style434);  
            	stream_LBRR.Add(LBRR13);

            	PushFollow(FOLLOW_idd_in_tikz_style436);
            	idd14 = idd();
            	state.followingStackPointer--;

            	stream_idd.Add(idd14.Tree);
            	RBRR15=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_tikz_style438);  
            	stream_RBRR.Add(RBRR15);

            	char_literal16=(IToken)Match(input,EQU,FOLLOW_EQU_in_tikz_style440);  
            	stream_EQU.Add(char_literal16);

            	PushFollow(FOLLOW_tikz_options_in_tikz_style442);
            	tikz_options17 = tikz_options();
            	state.followingStackPointer--;

            	stream_tikz_options.Add(tikz_options17.Tree);


            	// AST REWRITE
            	// elements:          idd, tikz_options
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 104:45: -> ^( IM_STYLE idd tikz_options )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:104:48: ^( IM_STYLE idd tikz_options )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STYLE, "IM_STYLE"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    adaptor.AddChild(root_1, stream_tikz_options.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:107:1: tikz_options : squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) ;
    public simpletikzParser.tikz_options_return tikz_options() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_options_return retval = new simpletikzParser.tikz_options_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal20 = null;
        IToken char_literal22 = null;
        simpletikzParser.squarebr_start_return squarebr_start18 = default(simpletikzParser.squarebr_start_return);

        simpletikzParser.option_return option19 = default(simpletikzParser.option_return);

        simpletikzParser.option_return option21 = default(simpletikzParser.option_return);

        simpletikzParser.squarebr_end_return squarebr_end23 = default(simpletikzParser.squarebr_end_return);


        object char_literal20_tree=null;
        object char_literal22_tree=null;
        RewriteRuleTokenStream stream_KOMMA = new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_squarebr_start = new RewriteRuleSubtreeStream(adaptor,"rule squarebr_start");
        RewriteRuleSubtreeStream stream_squarebr_end = new RewriteRuleSubtreeStream(adaptor,"rule squarebr_end");
        RewriteRuleSubtreeStream stream_option = new RewriteRuleSubtreeStream(adaptor,"rule option");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:2: ( squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:5: squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end
            {
            	PushFollow(FOLLOW_squarebr_start_in_tikz_options464);
            	squarebr_start18 = squarebr_start();
            	state.followingStackPointer--;

            	stream_squarebr_start.Add(squarebr_start18.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:20: ( option ( ',' option )* ( ',' )? )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == ID) )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:21: option ( ',' option )* ( ',' )?
            	        {
            	        	PushFollow(FOLLOW_option_in_tikz_options467);
            	        	option19 = option();
            	        	state.followingStackPointer--;

            	        	stream_option.Add(option19.Tree);
            	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:28: ( ',' option )*
            	        	do 
            	        	{
            	        	    int alt3 = 2;
            	        	    int LA3_0 = input.LA(1);

            	        	    if ( (LA3_0 == KOMMA) )
            	        	    {
            	        	        int LA3_1 = input.LA(2);

            	        	        if ( (LA3_1 == ID) )
            	        	        {
            	        	            alt3 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt3) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:29: ',' option
            	        			    {
            	        			    	char_literal20=(IToken)Match(input,KOMMA,FOLLOW_KOMMA_in_tikz_options470);  
            	        			    	stream_KOMMA.Add(char_literal20);

            	        			    	PushFollow(FOLLOW_option_in_tikz_options472);
            	        			    	option21 = option();
            	        			    	state.followingStackPointer--;

            	        			    	stream_option.Add(option21.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop3;
            	        	    }
            	        	} while (true);

            	        	loop3:
            	        		;	// Stops C# compiler whining that label 'loop3' has no statements

            	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:42: ( ',' )?
            	        	int alt4 = 2;
            	        	int LA4_0 = input.LA(1);

            	        	if ( (LA4_0 == KOMMA) )
            	        	{
            	        	    alt4 = 1;
            	        	}
            	        	switch (alt4) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:42: ','
            	        	        {
            	        	        	char_literal22=(IToken)Match(input,KOMMA,FOLLOW_KOMMA_in_tikz_options476);  
            	        	        	stream_KOMMA.Add(char_literal22);


            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_squarebr_end_in_tikz_options481);
            	squarebr_end23 = squarebr_end();
            	state.followingStackPointer--;

            	stream_squarebr_end.Add(squarebr_end23.Tree);


            	// AST REWRITE
            	// elements:          squarebr_start, squarebr_end, option
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 108:63: -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:66: ^( IM_OPTIONS squarebr_start ( option )* squarebr_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTIONS, "IM_OPTIONS"), root_1);

            	    adaptor.AddChild(root_1, stream_squarebr_start.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:94: ( option )*
            	    while ( stream_option.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_option.NextTree());

            	    }
            	    stream_option.Reset();
            	    adaptor.AddChild(root_1, stream_squarebr_end.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:111:1: option : ( option_style | option_kv );
    public simpletikzParser.option_return option() // throws RecognitionException [1]
    {   
        simpletikzParser.option_return retval = new simpletikzParser.option_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.option_style_return option_style24 = default(simpletikzParser.option_style_return);

        simpletikzParser.option_kv_return option_kv25 = default(simpletikzParser.option_kv_return);



        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:112:2: ( option_style | option_kv )
            int alt6 = 2;
            alt6 = dfa6.Predict(input);
            switch (alt6) 
            {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:112:4: option_style
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_option_style_in_option506);
                    	option_style24 = option_style();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, option_style24.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:113:5: option_kv
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_option_kv_in_option515);
                    	option_kv25 = option_kv();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, option_kv25.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:116:1: option_kv : idd ( '=' iddornumberunitorstring )? -> ^( IM_OPTION_KV idd ( iddornumberunitorstring )? ) ;
    public simpletikzParser.option_kv_return option_kv() // throws RecognitionException [1]
    {   
        simpletikzParser.option_kv_return retval = new simpletikzParser.option_kv_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal27 = null;
        simpletikzParser.idd_return idd26 = default(simpletikzParser.idd_return);

        simpletikzParser.iddornumberunitorstring_return iddornumberunitorstring28 = default(simpletikzParser.iddornumberunitorstring_return);


        object char_literal27_tree=null;
        RewriteRuleTokenStream stream_EQU = new RewriteRuleTokenStream(adaptor,"token EQU");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_iddornumberunitorstring = new RewriteRuleSubtreeStream(adaptor,"rule iddornumberunitorstring");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:2: ( idd ( '=' iddornumberunitorstring )? -> ^( IM_OPTION_KV idd ( iddornumberunitorstring )? ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:4: idd ( '=' iddornumberunitorstring )?
            {
            	PushFollow(FOLLOW_idd_in_option_kv529);
            	idd26 = idd();
            	state.followingStackPointer--;

            	stream_idd.Add(idd26.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:8: ( '=' iddornumberunitorstring )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( (LA7_0 == EQU) )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:9: '=' iddornumberunitorstring
            	        {
            	        	char_literal27=(IToken)Match(input,EQU,FOLLOW_EQU_in_option_kv532);  
            	        	stream_EQU.Add(char_literal27);

            	        	PushFollow(FOLLOW_iddornumberunitorstring_in_option_kv534);
            	        	iddornumberunitorstring28 = iddornumberunitorstring();
            	        	state.followingStackPointer--;

            	        	stream_iddornumberunitorstring.Add(iddornumberunitorstring28.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          iddornumberunitorstring, idd
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 117:40: -> ^( IM_OPTION_KV idd ( iddornumberunitorstring )? )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:43: ^( IM_OPTION_KV idd ( iddornumberunitorstring )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTION_KV, "IM_OPTION_KV"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:62: ( iddornumberunitorstring )?
            	    if ( stream_iddornumberunitorstring.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_iddornumberunitorstring.NextTree());

            	    }
            	    stream_iddornumberunitorstring.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:120:1: tikzstring : LBRR ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* RBRR -> ^( IM_STRING LBRR RBRR ) ;
    public simpletikzParser.tikzstring_return tikzstring() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzstring_return retval = new simpletikzParser.tikzstring_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LBRR29 = null;
        IToken RBRR33 = null;
        simpletikzParser.no_rlbrace_return no_rlbrace30 = default(simpletikzParser.no_rlbrace_return);

        simpletikzParser.tikzstring_return tikzstring31 = default(simpletikzParser.tikzstring_return);

        simpletikzParser.no_rlbrace_return no_rlbrace32 = default(simpletikzParser.no_rlbrace_return);


        object LBRR29_tree=null;
        object RBRR33_tree=null;
        RewriteRuleTokenStream stream_RBRR = new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleSubtreeStream stream_tikzstring = new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_no_rlbrace = new RewriteRuleSubtreeStream(adaptor,"rule no_rlbrace");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:2: ( LBRR ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* RBRR -> ^( IM_STRING LBRR RBRR ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:4: LBRR ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* RBRR
            {
            	LBRR29=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_tikzstring562);  
            	stream_LBRR.Add(LBRR29);

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:9: ( no_rlbrace )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( ((LA8_0 >= BEGIN && LA8_0 <= RBR) || (LA8_0 >= KOMMA && LA8_0 <= 70)) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:9: no_rlbrace
            			    {
            			    	PushFollow(FOLLOW_no_rlbrace_in_tikzstring564);
            			    	no_rlbrace30 = no_rlbrace();
            			    	state.followingStackPointer--;

            			    	stream_no_rlbrace.Add(no_rlbrace30.Tree);

            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:21: ( tikzstring ( no_rlbrace )* )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( (LA10_0 == LBRR) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:22: tikzstring ( no_rlbrace )*
            			    {
            			    	PushFollow(FOLLOW_tikzstring_in_tikzstring568);
            			    	tikzstring31 = tikzstring();
            			    	state.followingStackPointer--;

            			    	stream_tikzstring.Add(tikzstring31.Tree);
            			    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:33: ( no_rlbrace )*
            			    	do 
            			    	{
            			    	    int alt9 = 2;
            			    	    int LA9_0 = input.LA(1);

            			    	    if ( ((LA9_0 >= BEGIN && LA9_0 <= RBR) || (LA9_0 >= KOMMA && LA9_0 <= 70)) )
            			    	    {
            			    	        alt9 = 1;
            			    	    }


            			    	    switch (alt9) 
            			    		{
            			    			case 1 :
            			    			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:33: no_rlbrace
            			    			    {
            			    			    	PushFollow(FOLLOW_no_rlbrace_in_tikzstring570);
            			    			    	no_rlbrace32 = no_rlbrace();
            			    			    	state.followingStackPointer--;

            			    			    	stream_no_rlbrace.Add(no_rlbrace32.Tree);

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop9;
            			    	    }
            			    	} while (true);

            			    	loop9:
            			    		;	// Stops C# compiler whining that label 'loop9' has no statements


            			    }
            			    break;

            			default:
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements

            	RBRR33=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_tikzstring575);  
            	stream_RBRR.Add(RBRR33);



            	// AST REWRITE
            	// elements:          RBRR, LBRR
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 121:52: -> ^( IM_STRING LBRR RBRR )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:55: ^( IM_STRING LBRR RBRR )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STRING, "IM_STRING"), root_1);

            	    adaptor.AddChild(root_1, stream_LBRR.NextNode());
            	    adaptor.AddChild(root_1, stream_RBRR.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:124:1: no_rlbrace : ~ ( LBRR | RBRR ) ;
    public simpletikzParser.no_rlbrace_return no_rlbrace() // throws RecognitionException [1]
    {   
        simpletikzParser.no_rlbrace_return retval = new simpletikzParser.no_rlbrace_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set34 = null;

        object set34_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:125:2: (~ ( LBRR | RBRR ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:125:4: ~ ( LBRR | RBRR )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set34 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= BEGIN && input.LA(1) <= RBR) || (input.LA(1) >= KOMMA && input.LA(1) <= 70) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set34));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "no_rlbrace"

    public class iddornumberunitorstring_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "iddornumberunitorstring"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:127:1: iddornumberunitorstring : ( idd | numberunit | tikzstring );
    public simpletikzParser.iddornumberunitorstring_return iddornumberunitorstring() // throws RecognitionException [1]
    {   
        simpletikzParser.iddornumberunitorstring_return retval = new simpletikzParser.iddornumberunitorstring_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.idd_return idd35 = default(simpletikzParser.idd_return);

        simpletikzParser.numberunit_return numberunit36 = default(simpletikzParser.numberunit_return);

        simpletikzParser.tikzstring_return tikzstring37 = default(simpletikzParser.tikzstring_return);



        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:128:2: ( idd | numberunit | tikzstring )
            int alt11 = 3;
            switch ( input.LA(1) ) 
            {
            case ID:
            	{
                alt11 = 1;
                }
                break;
            case FLOAT:
            case INT:
            	{
                alt11 = 2;
                }
                break;
            case LBRR:
            	{
                alt11 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d11s0 =
            	        new NoViableAltException("", 11, 0, input);

            	    throw nvae_d11s0;
            }

            switch (alt11) 
            {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:128:4: idd
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_idd_in_iddornumberunitorstring615);
                    	idd35 = idd();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, idd35.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:128:10: numberunit
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_numberunit_in_iddornumberunitorstring619);
                    	numberunit36 = numberunit();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, numberunit36.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:128:23: tikzstring
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikzstring_in_iddornumberunitorstring623);
                    	tikzstring37 = tikzstring();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, tikzstring37.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "iddornumberunitorstring"

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:130:1: option_style : idd '/.style' '=' LBRR ( option_kv ( ',' option_kv )* )? ( ',' )? RBRR -> ^( IM_OPTION_STYLE idd ( option_kv )* ) ;
    public simpletikzParser.option_style_return option_style() // throws RecognitionException [1]
    {   
        simpletikzParser.option_style_return retval = new simpletikzParser.option_style_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal39 = null;
        IToken char_literal40 = null;
        IToken LBRR41 = null;
        IToken char_literal43 = null;
        IToken char_literal45 = null;
        IToken RBRR46 = null;
        simpletikzParser.idd_return idd38 = default(simpletikzParser.idd_return);

        simpletikzParser.option_kv_return option_kv42 = default(simpletikzParser.option_kv_return);

        simpletikzParser.option_kv_return option_kv44 = default(simpletikzParser.option_kv_return);


        object string_literal39_tree=null;
        object char_literal40_tree=null;
        object LBRR41_tree=null;
        object char_literal43_tree=null;
        object char_literal45_tree=null;
        object RBRR46_tree=null;
        RewriteRuleTokenStream stream_EQU = new RewriteRuleTokenStream(adaptor,"token EQU");
        RewriteRuleTokenStream stream_RBRR = new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_KOMMA = new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_option_kv = new RewriteRuleSubtreeStream(adaptor,"rule option_kv");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:131:2: ( idd '/.style' '=' LBRR ( option_kv ( ',' option_kv )* )? ( ',' )? RBRR -> ^( IM_OPTION_STYLE idd ( option_kv )* ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:131:4: idd '/.style' '=' LBRR ( option_kv ( ',' option_kv )* )? ( ',' )? RBRR
            {
            	PushFollow(FOLLOW_idd_in_option_style633);
            	idd38 = idd();
            	state.followingStackPointer--;

            	stream_idd.Add(idd38.Tree);
            	string_literal39=(IToken)Match(input,51,FOLLOW_51_in_option_style635);  
            	stream_51.Add(string_literal39);

            	char_literal40=(IToken)Match(input,EQU,FOLLOW_EQU_in_option_style637);  
            	stream_EQU.Add(char_literal40);

            	LBRR41=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_option_style639);  
            	stream_LBRR.Add(LBRR41);

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:131:27: ( option_kv ( ',' option_kv )* )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == ID) )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:131:28: option_kv ( ',' option_kv )*
            	        {
            	        	PushFollow(FOLLOW_option_kv_in_option_style642);
            	        	option_kv42 = option_kv();
            	        	state.followingStackPointer--;

            	        	stream_option_kv.Add(option_kv42.Tree);
            	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:131:38: ( ',' option_kv )*
            	        	do 
            	        	{
            	        	    int alt12 = 2;
            	        	    int LA12_0 = input.LA(1);

            	        	    if ( (LA12_0 == KOMMA) )
            	        	    {
            	        	        int LA12_1 = input.LA(2);

            	        	        if ( (LA12_1 == ID) )
            	        	        {
            	        	            alt12 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt12) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:131:39: ',' option_kv
            	        			    {
            	        			    	char_literal43=(IToken)Match(input,KOMMA,FOLLOW_KOMMA_in_option_style645);  
            	        			    	stream_KOMMA.Add(char_literal43);

            	        			    	PushFollow(FOLLOW_option_kv_in_option_style647);
            	        			    	option_kv44 = option_kv();
            	        			    	state.followingStackPointer--;

            	        			    	stream_option_kv.Add(option_kv44.Tree);

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

            	}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:131:58: ( ',' )?
            	int alt14 = 2;
            	int LA14_0 = input.LA(1);

            	if ( (LA14_0 == KOMMA) )
            	{
            	    alt14 = 1;
            	}
            	switch (alt14) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:131:58: ','
            	        {
            	        	char_literal45=(IToken)Match(input,KOMMA,FOLLOW_KOMMA_in_option_style654);  
            	        	stream_KOMMA.Add(char_literal45);


            	        }
            	        break;

            	}

            	RBRR46=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_option_style657);  
            	stream_RBRR.Add(RBRR46);



            	// AST REWRITE
            	// elements:          idd, option_kv
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 131:69: -> ^( IM_OPTION_STYLE idd ( option_kv )* )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:131:72: ^( IM_OPTION_STYLE idd ( option_kv )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTION_STYLE, "IM_OPTION_STYLE"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:131:94: ( option_kv )*
            	    while ( stream_option_kv.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_option_kv.NextTree());

            	    }
            	    stream_option_kv.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:135:1: idd : ID ( ID )* -> ^( IM_ID ( ID )* ) ;
    public simpletikzParser.idd_return idd() // throws RecognitionException [1]
    {   
        simpletikzParser.idd_return retval = new simpletikzParser.idd_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID47 = null;
        IToken ID48 = null;

        object ID47_tree=null;
        object ID48_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:136:2: ( ID ( ID )* -> ^( IM_ID ( ID )* ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:136:4: ID ( ID )*
            {
            	ID47=(IToken)Match(input,ID,FOLLOW_ID_in_idd683);  
            	stream_ID.Add(ID47);

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:136:7: ( ID )*
            	do 
            	{
            	    int alt15 = 2;
            	    int LA15_0 = input.LA(1);

            	    if ( (LA15_0 == ID) )
            	    {
            	        alt15 = 1;
            	    }


            	    switch (alt15) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:136:8: ID
            			    {
            			    	ID48=(IToken)Match(input,ID,FOLLOW_ID_in_idd686);  
            			    	stream_ID.Add(ID48);


            			    }
            			    break;

            			default:
            			    goto loop15;
            	    }
            	} while (true);

            	loop15:
            		;	// Stops C# compiler whining that label 'loop15' has no statements



            	// AST REWRITE
            	// elements:          ID
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 136:13: -> ^( IM_ID ( ID )* )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:136:16: ^( IM_ID ( ID )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ID, "IM_ID"), root_1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:136:24: ( ID )*
            	    while ( stream_ID.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_ID.NextNode());

            	    }
            	    stream_ID.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "idd"

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:139:1: numberunit : number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) ;
    public simpletikzParser.numberunit_return numberunit() // throws RecognitionException [1]
    {   
        simpletikzParser.numberunit_return retval = new simpletikzParser.numberunit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.number_return number49 = default(simpletikzParser.number_return);

        simpletikzParser.unit_return unit50 = default(simpletikzParser.unit_return);


        RewriteRuleSubtreeStream stream_unit = new RewriteRuleSubtreeStream(adaptor,"rule unit");
        RewriteRuleSubtreeStream stream_number = new RewriteRuleSubtreeStream(adaptor,"rule number");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:140:2: ( number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:140:4: number ( unit )?
            {
            	PushFollow(FOLLOW_number_in_numberunit708);
            	number49 = number();
            	state.followingStackPointer--;

            	stream_number.Add(number49.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:140:11: ( unit )?
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( ((LA16_0 >= 52 && LA16_0 <= 56)) )
            	{
            	    alt16 = 1;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:140:11: unit
            	        {
            	        	PushFollow(FOLLOW_unit_in_numberunit710);
            	        	unit50 = unit();
            	        	state.followingStackPointer--;

            	        	stream_unit.Add(unit50.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          unit, number
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 140:17: -> ^( IM_NUMBERUNIT number ( unit )? )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:140:20: ^( IM_NUMBERUNIT number ( unit )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NUMBERUNIT, "IM_NUMBERUNIT"), root_1);

            	    adaptor.AddChild(root_1, stream_number.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:140:43: ( unit )?
            	    if ( stream_unit.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_unit.NextTree());

            	    }
            	    stream_unit.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:142:1: number : ( FLOAT | INT ) ;
    public simpletikzParser.number_return number() // throws RecognitionException [1]
    {   
        simpletikzParser.number_return retval = new simpletikzParser.number_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set51 = null;

        object set51_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:143:2: ( ( FLOAT | INT ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:143:4: ( FLOAT | INT )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set51 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= FLOAT && input.LA(1) <= INT) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set51));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:145:1: unit : ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' );
    public simpletikzParser.unit_return unit() // throws RecognitionException [1]
    {   
        simpletikzParser.unit_return retval = new simpletikzParser.unit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set52 = null;

        object set52_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:146:2: ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set52 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 52 && input.LA(1) <= 56) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set52));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:149:1: tikz_set : tikz_set_start ( option ( ',' option )* )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) ;
    public simpletikzParser.tikz_set_return tikz_set() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_set_return retval = new simpletikzParser.tikz_set_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal55 = null;
        simpletikzParser.tikz_set_start_return tikz_set_start53 = default(simpletikzParser.tikz_set_start_return);

        simpletikzParser.option_return option54 = default(simpletikzParser.option_return);

        simpletikzParser.option_return option56 = default(simpletikzParser.option_return);

        simpletikzParser.roundbr_end_return roundbr_end57 = default(simpletikzParser.roundbr_end_return);


        object char_literal55_tree=null;
        RewriteRuleTokenStream stream_KOMMA = new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_tikz_set_start = new RewriteRuleSubtreeStream(adaptor,"rule tikz_set_start");
        RewriteRuleSubtreeStream stream_roundbr_end = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        RewriteRuleSubtreeStream stream_option = new RewriteRuleSubtreeStream(adaptor,"rule option");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:150:2: ( tikz_set_start ( option ( ',' option )* )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:150:5: tikz_set_start ( option ( ',' option )* )? roundbr_end
            {
            	PushFollow(FOLLOW_tikz_set_start_in_tikz_set780);
            	tikz_set_start53 = tikz_set_start();
            	state.followingStackPointer--;

            	stream_tikz_set_start.Add(tikz_set_start53.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:150:20: ( option ( ',' option )* )?
            	int alt18 = 2;
            	int LA18_0 = input.LA(1);

            	if ( (LA18_0 == ID) )
            	{
            	    alt18 = 1;
            	}
            	switch (alt18) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:150:21: option ( ',' option )*
            	        {
            	        	PushFollow(FOLLOW_option_in_tikz_set783);
            	        	option54 = option();
            	        	state.followingStackPointer--;

            	        	stream_option.Add(option54.Tree);
            	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:150:28: ( ',' option )*
            	        	do 
            	        	{
            	        	    int alt17 = 2;
            	        	    int LA17_0 = input.LA(1);

            	        	    if ( (LA17_0 == KOMMA) )
            	        	    {
            	        	        alt17 = 1;
            	        	    }


            	        	    switch (alt17) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:150:29: ',' option
            	        			    {
            	        			    	char_literal55=(IToken)Match(input,KOMMA,FOLLOW_KOMMA_in_tikz_set786);  
            	        			    	stream_KOMMA.Add(char_literal55);

            	        			    	PushFollow(FOLLOW_option_in_tikz_set788);
            	        			    	option56 = option();
            	        			    	state.followingStackPointer--;

            	        			    	stream_option.Add(option56.Tree);

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

            	PushFollow(FOLLOW_roundbr_end_in_tikz_set794);
            	roundbr_end57 = roundbr_end();
            	state.followingStackPointer--;

            	stream_roundbr_end.Add(roundbr_end57.Tree);


            	// AST REWRITE
            	// elements:          tikz_set_start, roundbr_end, option
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 150:56: -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:150:59: ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_TIKZSET, "IM_TIKZSET"), root_1);

            	    adaptor.AddChild(root_1, stream_tikz_set_start.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:150:87: ( option )*
            	    while ( stream_option.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_option.NextTree());

            	    }
            	    stream_option.Reset();
            	    adaptor.AddChild(root_1, stream_roundbr_end.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:155:1: tikzpicture : tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) ;
    public simpletikzParser.tikzpicture_return tikzpicture() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_return retval = new simpletikzParser.tikzpicture_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzpicture_start_return tikzpicture_start58 = default(simpletikzParser.tikzpicture_start_return);

        simpletikzParser.tikz_options_return tikz_options59 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody_return tikzbody60 = default(simpletikzParser.tikzbody_return);

        simpletikzParser.tikzpicture_end_return tikzpicture_end61 = default(simpletikzParser.tikzpicture_end_return);


        RewriteRuleSubtreeStream stream_tikzpicture_end = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_end");
        RewriteRuleSubtreeStream stream_tikzpicture_start = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_start");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:2: ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:5: tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end
            {
            	PushFollow(FOLLOW_tikzpicture_start_in_tikzpicture822);
            	tikzpicture_start58 = tikzpicture_start();
            	state.followingStackPointer--;

            	stream_tikzpicture_start.Add(tikzpicture_start58.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:23: ( tikz_options )?
            	int alt19 = 2;
            	int LA19_0 = input.LA(1);

            	if ( (LA19_0 == LBR) )
            	{
            	    alt19 = 1;
            	}
            	switch (alt19) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:23: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_tikzpicture824);
            	        	tikz_options59 = tikz_options();
            	        	state.followingStackPointer--;

            	        	stream_tikz_options.Add(tikz_options59.Tree);

            	        }
            	        break;

            	}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:37: ( tikzbody )?
            	int alt20 = 2;
            	int LA20_0 = input.LA(1);

            	if ( (LA20_0 == BEGIN || (LA20_0 >= USETIKZLIB && LA20_0 <= RPAR) || (LA20_0 >= RBR && LA20_0 <= 70)) )
            	{
            	    alt20 = 1;
            	}
            	else if ( (LA20_0 == END) )
            	{
            	    int LA20_2 = input.LA(2);

            	    if ( (LA20_2 == LBRR) )
            	    {
            	        int LA20_3 = input.LA(3);

            	        if ( (LA20_3 == ID) )
            	        {
            	            alt20 = 1;
            	        }
            	    }
            	}
            	switch (alt20) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:37: tikzbody
            	        {
            	        	PushFollow(FOLLOW_tikzbody_in_tikzpicture827);
            	        	tikzbody60 = tikzbody();
            	        	state.followingStackPointer--;

            	        	stream_tikzbody.Add(tikzbody60.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzpicture_end_in_tikzpicture830);
            	tikzpicture_end61 = tikzpicture_end();
            	state.followingStackPointer--;

            	stream_tikzpicture_end.Add(tikzpicture_end61.Tree);


            	// AST REWRITE
            	// elements:          tikzpicture_start, tikzbody, tikzpicture_end, tikz_options
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 156:64: -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:67: ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PICTURE, "IM_PICTURE"), root_1);

            	    adaptor.AddChild(root_1, stream_tikzpicture_start.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:98: ( tikz_options )?
            	    if ( stream_tikz_options.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikz_options.NextTree());

            	    }
            	    stream_tikz_options.Reset();
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:112: ( tikzbody )?
            	    if ( stream_tikzbody.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzbody.NextTree());

            	    }
            	    stream_tikzbody.Reset();
            	    adaptor.AddChild(root_1, stream_tikzpicture_end.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:159:1: tikzbody : ( tikzscope | tikzpath | tikznodee | dontcare_body_nobr | tikz_set | tikz_style | otherbegin | otherend ) ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )* ;
    public simpletikzParser.tikzbody_return tikzbody() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzbody_return retval = new simpletikzParser.tikzbody_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_return tikzscope62 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath63 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznodee_return tikznodee64 = default(simpletikzParser.tikznodee_return);

        simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr65 = default(simpletikzParser.dontcare_body_nobr_return);

        simpletikzParser.tikz_set_return tikz_set66 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style67 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin68 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend69 = default(simpletikzParser.otherend_return);

        simpletikzParser.tikzscope_return tikzscope70 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath71 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznodee_return tikznodee72 = default(simpletikzParser.tikznodee_return);

        simpletikzParser.dontcare_body_return dontcare_body73 = default(simpletikzParser.dontcare_body_return);

        simpletikzParser.tikz_set_return tikz_set74 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style75 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin76 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend77 = default(simpletikzParser.otherend_return);



        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:160:2: ( ( tikzscope | tikzpath | tikznodee | dontcare_body_nobr | tikz_set | tikz_style | otherbegin | otherend ) ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )* )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:160:4: ( tikzscope | tikzpath | tikznodee | dontcare_body_nobr | tikz_set | tikz_style | otherbegin | otherend ) ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:160:4: ( tikzscope | tikzpath | tikznodee | dontcare_body_nobr | tikz_set | tikz_style | otherbegin | otherend )
            	int alt21 = 8;
            	alt21 = dfa21.Predict(input);
            	switch (alt21) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:160:6: tikzscope
            	        {
            	        	PushFollow(FOLLOW_tikzscope_in_tikzbody860);
            	        	tikzscope62 = tikzscope();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, tikzscope62.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:160:18: tikzpath
            	        {
            	        	PushFollow(FOLLOW_tikzpath_in_tikzbody864);
            	        	tikzpath63 = tikzpath();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, tikzpath63.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:160:29: tikznodee
            	        {
            	        	PushFollow(FOLLOW_tikznodee_in_tikzbody868);
            	        	tikznodee64 = tikznodee();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, tikznodee64.Tree);

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:160:41: dontcare_body_nobr
            	        {
            	        	PushFollow(FOLLOW_dontcare_body_nobr_in_tikzbody872);
            	        	dontcare_body_nobr65 = dontcare_body_nobr();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, dontcare_body_nobr65.Tree);

            	        }
            	        break;
            	    case 5 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:160:62: tikz_set
            	        {
            	        	PushFollow(FOLLOW_tikz_set_in_tikzbody876);
            	        	tikz_set66 = tikz_set();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, tikz_set66.Tree);

            	        }
            	        break;
            	    case 6 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:160:73: tikz_style
            	        {
            	        	PushFollow(FOLLOW_tikz_style_in_tikzbody880);
            	        	tikz_style67 = tikz_style();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, tikz_style67.Tree);

            	        }
            	        break;
            	    case 7 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:160:86: otherbegin
            	        {
            	        	PushFollow(FOLLOW_otherbegin_in_tikzbody884);
            	        	otherbegin68 = otherbegin();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, otherbegin68.Tree);

            	        }
            	        break;
            	    case 8 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:160:98: otherend
            	        {
            	        	PushFollow(FOLLOW_otherend_in_tikzbody887);
            	        	otherend69 = otherend();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, otherend69.Tree);

            	        }
            	        break;

            	}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:3: ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )*
            	do 
            	{
            	    int alt22 = 9;
            	    alt22 = dfa22.Predict(input);
            	    switch (alt22) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:5: tikzscope
            			    {
            			    	PushFollow(FOLLOW_tikzscope_in_tikzbody897);
            			    	tikzscope70 = tikzscope();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, tikzscope70.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:17: tikzpath
            			    {
            			    	PushFollow(FOLLOW_tikzpath_in_tikzbody901);
            			    	tikzpath71 = tikzpath();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, tikzpath71.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:28: tikznodee
            			    {
            			    	PushFollow(FOLLOW_tikznodee_in_tikzbody905);
            			    	tikznodee72 = tikznodee();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, tikznodee72.Tree);

            			    }
            			    break;
            			case 4 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:40: dontcare_body
            			    {
            			    	PushFollow(FOLLOW_dontcare_body_in_tikzbody909);
            			    	dontcare_body73 = dontcare_body();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, dontcare_body73.Tree);

            			    }
            			    break;
            			case 5 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:56: tikz_set
            			    {
            			    	PushFollow(FOLLOW_tikz_set_in_tikzbody913);
            			    	tikz_set74 = tikz_set();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, tikz_set74.Tree);

            			    }
            			    break;
            			case 6 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:67: tikz_style
            			    {
            			    	PushFollow(FOLLOW_tikz_style_in_tikzbody917);
            			    	tikz_style75 = tikz_style();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, tikz_style75.Tree);

            			    }
            			    break;
            			case 7 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:80: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzbody921);
            			    	otherbegin76 = otherbegin();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, otherbegin76.Tree);

            			    }
            			    break;
            			case 8 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:92: otherend
            			    {
            			    	PushFollow(FOLLOW_otherend_in_tikzbody924);
            			    	otherend77 = otherend();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, otherend77.Tree);

            			    }
            			    break;

            			default:
            			    goto loop22;
            	    }
            	} while (true);

            	loop22:
            		;	// Stops C# compiler whining that label 'loop22' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:164:1: dontcare_body_nobr : (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET | LBR ) ) ;
    public simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body_nobr_return retval = new simpletikzParser.dontcare_body_nobr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set78 = null;

        object set78_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:2: ( (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET | LBR ) ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET | LBR ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET | LBR ) )
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:5: ~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET | LBR )
            	{
            		set78 = (IToken)input.LT(1);
            		if ( input.LA(1) == USETIKZLIB || (input.LA(1) >= LPAR && input.LA(1) <= RPAR) || (input.LA(1) >= RBR && input.LA(1) <= 70) ) 
            		{
            		    input.Consume();
            		    adaptor.AddChild(root_0, (object)adaptor.Create(set78));
            		    state.errorRecovery = false;
            		}
            		else 
            		{
            		    MismatchedSetException mse = new MismatchedSetException(null,input);
            		    throw mse;
            		}


            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:167:1: dontcare_body : (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET ) ) ;
    public simpletikzParser.dontcare_body_return dontcare_body() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body_return retval = new simpletikzParser.dontcare_body_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set79 = null;

        object set79_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:168:2: ( (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET ) ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:168:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:168:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET ) )
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:168:5: ~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET )
            	{
            		set79 = (IToken)input.LT(1);
            		if ( input.LA(1) == USETIKZLIB || (input.LA(1) >= LPAR && input.LA(1) <= 70) ) 
            		{
            		    input.Consume();
            		    adaptor.AddChild(root_0, (object)adaptor.Create(set79));
            		    state.errorRecovery = false;
            		}
            		else 
            		{
            		    MismatchedSetException mse = new MismatchedSetException(null,input);
            		    throw mse;
            		}


            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:170:1: otherend : END '{' idd '}' ;
    public simpletikzParser.otherend_return otherend() // throws RecognitionException [1]
    {   
        simpletikzParser.otherend_return retval = new simpletikzParser.otherend_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken END80 = null;
        IToken char_literal81 = null;
        IToken char_literal83 = null;
        simpletikzParser.idd_return idd82 = default(simpletikzParser.idd_return);


        object END80_tree=null;
        object char_literal81_tree=null;
        object char_literal83_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:171:2: ( END '{' idd '}' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:171:4: END '{' idd '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	END80=(IToken)Match(input,END,FOLLOW_END_in_otherend1034); 
            		END80_tree = (object)adaptor.Create(END80);
            		adaptor.AddChild(root_0, END80_tree);

            	char_literal81=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_otherend1036); 
            		char_literal81_tree = (object)adaptor.Create(char_literal81);
            		adaptor.AddChild(root_0, char_literal81_tree);

            	PushFollow(FOLLOW_idd_in_otherend1038);
            	idd82 = idd();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, idd82.Tree);
            	char_literal83=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_otherend1040); 
            		char_literal83_tree = (object)adaptor.Create(char_literal83);
            		adaptor.AddChild(root_0, char_literal83_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "otherend"

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:174:1: tikzpath : path_start ( tikz_options )? tikzpathi semicolon_end -> ^( IM_PATH path_start ( tikz_options )? tikzpathi semicolon_end ) ;
    public simpletikzParser.tikzpath_return tikzpath() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_return retval = new simpletikzParser.tikzpath_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.path_start_return path_start84 = default(simpletikzParser.path_start_return);

        simpletikzParser.tikz_options_return tikz_options85 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzpathi_return tikzpathi86 = default(simpletikzParser.tikzpathi_return);

        simpletikzParser.semicolon_end_return semicolon_end87 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_path_start = new RewriteRuleSubtreeStream(adaptor,"rule path_start");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        RewriteRuleSubtreeStream stream_tikzpathi = new RewriteRuleSubtreeStream(adaptor,"rule tikzpathi");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:175:2: ( path_start ( tikz_options )? tikzpathi semicolon_end -> ^( IM_PATH path_start ( tikz_options )? tikzpathi semicolon_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:175:4: path_start ( tikz_options )? tikzpathi semicolon_end
            {
            	PushFollow(FOLLOW_path_start_in_tikzpath1053);
            	path_start84 = path_start();
            	state.followingStackPointer--;

            	stream_path_start.Add(path_start84.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:175:15: ( tikz_options )?
            	int alt23 = 2;
            	int LA23_0 = input.LA(1);

            	if ( (LA23_0 == LBR) )
            	{
            	    alt23 = 1;
            	}
            	switch (alt23) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:175:15: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_tikzpath1055);
            	        	tikz_options85 = tikz_options();
            	        	state.followingStackPointer--;

            	        	stream_tikz_options.Add(tikz_options85.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzpathi_in_tikzpath1058);
            	tikzpathi86 = tikzpathi();
            	state.followingStackPointer--;

            	stream_tikzpathi.Add(tikzpathi86.Tree);
            	PushFollow(FOLLOW_semicolon_end_in_tikzpath1060);
            	semicolon_end87 = semicolon_end();
            	state.followingStackPointer--;

            	stream_semicolon_end.Add(semicolon_end87.Tree);


            	// AST REWRITE
            	// elements:          tikzpathi, semicolon_end, tikz_options, path_start
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 175:53: -> ^( IM_PATH path_start ( tikz_options )? tikzpathi semicolon_end )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:175:56: ^( IM_PATH path_start ( tikz_options )? tikzpathi semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_path_start.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:175:77: ( tikz_options )?
            	    if ( stream_tikz_options.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikz_options.NextTree());

            	    }
            	    stream_tikz_options.Reset();
            	    adaptor.AddChild(root_1, stream_tikzpathi.NextTree());
            	    adaptor.AddChild(root_1, stream_semicolon_end.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tikzpath"

    public class tikzpathi_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikzpathi"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:178:1: tikzpathi : coordornode ( coordornode | ( tikz_options )? edgeop coordornode )* ;
    public simpletikzParser.tikzpathi_return tikzpathi() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpathi_return retval = new simpletikzParser.tikzpathi_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.coordornode_return coordornode88 = default(simpletikzParser.coordornode_return);

        simpletikzParser.coordornode_return coordornode89 = default(simpletikzParser.coordornode_return);

        simpletikzParser.tikz_options_return tikz_options90 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.edgeop_return edgeop91 = default(simpletikzParser.edgeop_return);

        simpletikzParser.coordornode_return coordornode92 = default(simpletikzParser.coordornode_return);



        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:179:2: ( coordornode ( coordornode | ( tikz_options )? edgeop coordornode )* )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:179:5: coordornode ( coordornode | ( tikz_options )? edgeop coordornode )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_coordornode_in_tikzpathi1089);
            	coordornode88 = coordornode();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, coordornode88.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:179:17: ( coordornode | ( tikz_options )? edgeop coordornode )*
            	do 
            	{
            	    int alt25 = 3;
            	    int LA25_0 = input.LA(1);

            	    if ( (LA25_0 == LPAR || LA25_0 == 57 || (LA25_0 >= 67 && LA25_0 <= 68)) )
            	    {
            	        alt25 = 1;
            	    }
            	    else if ( (LA25_0 == LBR || (LA25_0 >= 59 && LA25_0 <= 66)) )
            	    {
            	        alt25 = 2;
            	    }


            	    switch (alt25) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:179:18: coordornode
            			    {
            			    	PushFollow(FOLLOW_coordornode_in_tikzpathi1092);
            			    	coordornode89 = coordornode();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, coordornode89.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:179:32: ( tikz_options )? edgeop coordornode
            			    {
            			    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:179:32: ( tikz_options )?
            			    	int alt24 = 2;
            			    	int LA24_0 = input.LA(1);

            			    	if ( (LA24_0 == LBR) )
            			    	{
            			    	    alt24 = 1;
            			    	}
            			    	switch (alt24) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:179:32: tikz_options
            			    	        {
            			    	        	PushFollow(FOLLOW_tikz_options_in_tikzpathi1096);
            			    	        	tikz_options90 = tikz_options();
            			    	        	state.followingStackPointer--;

            			    	        	adaptor.AddChild(root_0, tikz_options90.Tree);

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_edgeop_in_tikzpathi1099);
            			    	edgeop91 = edgeop();
            			    	state.followingStackPointer--;

            			    	PushFollow(FOLLOW_coordornode_in_tikzpathi1102);
            			    	coordornode92 = coordornode();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, coordornode92.Tree);

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

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tikzpathi"

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:1: tikzscope : tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end ) ;
    public simpletikzParser.tikzscope_return tikzscope() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_return retval = new simpletikzParser.tikzscope_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_start_return tikzscope_start93 = default(simpletikzParser.tikzscope_start_return);

        simpletikzParser.tikz_options_return tikz_options94 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody_return tikzbody95 = default(simpletikzParser.tikzbody_return);

        simpletikzParser.tikzscope_end_return tikzscope_end96 = default(simpletikzParser.tikzscope_end_return);


        RewriteRuleSubtreeStream stream_tikzscope_start = new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_start");
        RewriteRuleSubtreeStream stream_tikzscope_end = new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_end");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:2: ( tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:4: tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end
            {
            	PushFollow(FOLLOW_tikzscope_start_in_tikzscope1118);
            	tikzscope_start93 = tikzscope_start();
            	state.followingStackPointer--;

            	stream_tikzscope_start.Add(tikzscope_start93.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:20: ( tikz_options )?
            	int alt26 = 2;
            	int LA26_0 = input.LA(1);

            	if ( (LA26_0 == LBR) )
            	{
            	    alt26 = 1;
            	}
            	switch (alt26) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:20: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_tikzscope1120);
            	        	tikz_options94 = tikz_options();
            	        	state.followingStackPointer--;

            	        	stream_tikz_options.Add(tikz_options94.Tree);

            	        }
            	        break;

            	}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:34: ( tikzbody )?
            	int alt27 = 2;
            	int LA27_0 = input.LA(1);

            	if ( (LA27_0 == BEGIN || (LA27_0 >= USETIKZLIB && LA27_0 <= RPAR) || (LA27_0 >= RBR && LA27_0 <= 70)) )
            	{
            	    alt27 = 1;
            	}
            	else if ( (LA27_0 == END) )
            	{
            	    int LA27_2 = input.LA(2);

            	    if ( (LA27_2 == LBRR) )
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
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:34: tikzbody
            	        {
            	        	PushFollow(FOLLOW_tikzbody_in_tikzscope1123);
            	        	tikzbody95 = tikzbody();
            	        	state.followingStackPointer--;

            	        	stream_tikzbody.Add(tikzbody95.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzscope_end_in_tikzscope1126);
            	tikzscope_end96 = tikzscope_end();
            	state.followingStackPointer--;

            	stream_tikzscope_end.Add(tikzscope_end96.Tree);


            	// AST REWRITE
            	// elements:          tikzscope_end, tikz_options, tikzscope_start, tikzbody
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 183:59: -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:62: ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_SCOPE, "IM_SCOPE"), root_1);

            	    adaptor.AddChild(root_1, stream_tikzscope_start.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:89: ( tikz_options )?
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

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tikzscope"

    public class coordornode_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "coordornode"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:186:1: coordornode : ( coord | tikznodei );
    public simpletikzParser.coordornode_return coordornode() // throws RecognitionException [1]
    {   
        simpletikzParser.coordornode_return retval = new simpletikzParser.coordornode_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.coord_return coord97 = default(simpletikzParser.coord_return);

        simpletikzParser.tikznodei_return tikznodei98 = default(simpletikzParser.tikznodei_return);



        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:187:2: ( coord | tikznodei )
            int alt28 = 2;
            int LA28_0 = input.LA(1);

            if ( (LA28_0 == LPAR || (LA28_0 >= 67 && LA28_0 <= 68)) )
            {
                alt28 = 1;
            }
            else if ( (LA28_0 == 57) )
            {
                alt28 = 2;
            }
            else 
            {
                NoViableAltException nvae_d28s0 =
                    new NoViableAltException("", 28, 0, input);

                throw nvae_d28s0;
            }
            switch (alt28) 
            {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:187:4: coord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_coord_in_coordornode1153);
                    	coord97 = coord();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, coord97.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:187:12: tikznodei
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikznodei_in_coordornode1157);
                    	tikznodei98 = tikznodei();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, tikznodei98.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "coordornode"

    public class tikznodei_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikznodei"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:190:1: tikznodei : 'node' tikznode ;
    public simpletikzParser.tikznodei_return tikznodei() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznodei_return retval = new simpletikzParser.tikznodei_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal99 = null;
        simpletikzParser.tikznode_return tikznode100 = default(simpletikzParser.tikznode_return);


        object string_literal99_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:191:2: ( 'node' tikznode )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:191:4: 'node' tikznode
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal99=(IToken)Match(input,57,FOLLOW_57_in_tikznodei1169); 
            	PushFollow(FOLLOW_tikznode_in_tikznodei1172);
            	tikznode100 = tikznode();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, tikznode100.Tree);

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tikznodei"

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:194:1: nodename : LPAR id= ID RPAR -> ^( IM_NODENAME $id) ;
    public simpletikzParser.nodename_return nodename() // throws RecognitionException [1]
    {   
        simpletikzParser.nodename_return retval = new simpletikzParser.nodename_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken id = null;
        IToken LPAR101 = null;
        IToken RPAR102 = null;

        object id_tree=null;
        object LPAR101_tree=null;
        object RPAR102_tree=null;
        RewriteRuleTokenStream stream_RPAR = new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR = new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:2: ( LPAR id= ID RPAR -> ^( IM_NODENAME $id) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:4: LPAR id= ID RPAR
            {
            	LPAR101=(IToken)Match(input,LPAR,FOLLOW_LPAR_in_nodename1184);  
            	stream_LPAR.Add(LPAR101);

            	id=(IToken)Match(input,ID,FOLLOW_ID_in_nodename1188);  
            	stream_ID.Add(id);

            	RPAR102=(IToken)Match(input,RPAR,FOLLOW_RPAR_in_nodename1190);  
            	stream_RPAR.Add(RPAR102);



            	// AST REWRITE
            	// elements:          id
            	// token labels:      id
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleTokenStream stream_id = new RewriteRuleTokenStream(adaptor, "token id", id);
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 195:21: -> ^( IM_NODENAME $id)
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:24: ^( IM_NODENAME $id)
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NODENAME, "IM_NODENAME"), root_1);

            	    adaptor.AddChild(root_1, stream_id.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "nodename"

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:198:1: coord : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? lc= LPAR numberunit coord_sep numberunit RPAR ) -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ coord_sep ) );
    public simpletikzParser.coord_return coord() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_return retval = new simpletikzParser.coord_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken lc = null;
        IToken RPAR108 = null;
        simpletikzParser.nodename_return nodename103 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_modifier_return coord_modifier104 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.numberunit_return numberunit105 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_sep_return coord_sep106 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.numberunit_return numberunit107 = default(simpletikzParser.numberunit_return);


        object lc_tree=null;
        object RPAR108_tree=null;
        RewriteRuleTokenStream stream_RPAR = new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR = new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_coord_sep = new RewriteRuleSubtreeStream(adaptor,"rule coord_sep");
        RewriteRuleSubtreeStream stream_nodename = new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        RewriteRuleSubtreeStream stream_coord_modifier = new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:199:2: ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? lc= LPAR numberunit coord_sep numberunit RPAR ) -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ coord_sep ) )
            int alt30 = 2;
            int LA30_0 = input.LA(1);

            if ( (LA30_0 == LPAR) )
            {
                int LA30_1 = input.LA(2);

                if ( (LA30_1 == ID) )
                {
                    alt30 = 1;
                }
                else if ( ((LA30_1 >= FLOAT && LA30_1 <= INT)) )
                {
                    alt30 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d30s1 =
                        new NoViableAltException("", 30, 1, input);

                    throw nvae_d30s1;
                }
            }
            else if ( ((LA30_0 >= 67 && LA30_0 <= 68)) )
            {
                alt30 = 2;
            }
            else 
            {
                NoViableAltException nvae_d30s0 =
                    new NoViableAltException("", 30, 0, input);

                throw nvae_d30s0;
            }
            switch (alt30) 
            {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:199:6: nodename
                    {
                    	PushFollow(FOLLOW_nodename_in_coord1214);
                    	nodename103 = nodename();
                    	state.followingStackPointer--;

                    	stream_nodename.Add(nodename103.Tree);


                    	// AST REWRITE
                    	// elements:          nodename
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 199:23: -> ^( IM_COORD nodename )
                    	{
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:199:26: ^( IM_COORD nodename )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, "IM_COORD"), root_1);

                    	    adaptor.AddChild(root_1, stream_nodename.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:200:5: ( ( coord_modifier )? lc= LPAR numberunit coord_sep numberunit RPAR )
                    {
                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:200:5: ( ( coord_modifier )? lc= LPAR numberunit coord_sep numberunit RPAR )
                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:200:7: ( coord_modifier )? lc= LPAR numberunit coord_sep numberunit RPAR
                    	{
                    		// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:200:7: ( coord_modifier )?
                    		int alt29 = 2;
                    		int LA29_0 = input.LA(1);

                    		if ( ((LA29_0 >= 67 && LA29_0 <= 68)) )
                    		{
                    		    alt29 = 1;
                    		}
                    		switch (alt29) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:200:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord1238);
                    		        	coord_modifier104 = coord_modifier();
                    		        	state.followingStackPointer--;

                    		        	stream_coord_modifier.Add(coord_modifier104.Tree);

                    		        }
                    		        break;

                    		}

                    		lc=(IToken)Match(input,LPAR,FOLLOW_LPAR_in_coord1243);  
                    		stream_LPAR.Add(lc);

                    		PushFollow(FOLLOW_numberunit_in_coord1245);
                    		numberunit105 = numberunit();
                    		state.followingStackPointer--;

                    		stream_numberunit.Add(numberunit105.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord1247);
                    		coord_sep106 = coord_sep();
                    		state.followingStackPointer--;

                    		stream_coord_sep.Add(coord_sep106.Tree);
                    		PushFollow(FOLLOW_numberunit_in_coord1249);
                    		numberunit107 = numberunit();
                    		state.followingStackPointer--;

                    		stream_numberunit.Add(numberunit107.Tree);
                    		RPAR108=(IToken)Match(input,RPAR,FOLLOW_RPAR_in_coord1251);  
                    		stream_RPAR.Add(RPAR108);


                    	}



                    	// AST REWRITE
                    	// elements:          numberunit, coord_modifier, coord_sep
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 200:70: -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ coord_sep )
                    	{
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:200:73: ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ coord_sep )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, lc), root_1);

                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:200:89: ( coord_modifier )?
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

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "coord"

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:202:1: coord_sep : ( ',' | ':' ) ;
    public simpletikzParser.coord_sep_return coord_sep() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_sep_return retval = new simpletikzParser.coord_sep_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set109 = null;

        object set109_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:203:2: ( ( ',' | ':' ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:203:4: ( ',' | ':' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set109 = (IToken)input.LT(1);
            	if ( input.LA(1) == KOMMA || input.LA(1) == COLON ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set109));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "coord_sep"

    public class tikznode_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikznode"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:206:1: tikznode : ( nodename )? ( 'at' coord )? tikzstring -> ^( IM_NODE ( nodename )? ( coord )? tikzstring ) ;
    public simpletikzParser.tikznode_return tikznode() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_return retval = new simpletikzParser.tikznode_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal111 = null;
        simpletikzParser.nodename_return nodename110 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_return coord112 = default(simpletikzParser.coord_return);

        simpletikzParser.tikzstring_return tikzstring113 = default(simpletikzParser.tikzstring_return);


        object string_literal111_tree=null;
        RewriteRuleTokenStream stream_58 = new RewriteRuleTokenStream(adaptor,"token 58");
        RewriteRuleSubtreeStream stream_coord = new RewriteRuleSubtreeStream(adaptor,"rule coord");
        RewriteRuleSubtreeStream stream_tikzstring = new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_nodename = new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:207:2: ( ( nodename )? ( 'at' coord )? tikzstring -> ^( IM_NODE ( nodename )? ( coord )? tikzstring ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:207:4: ( nodename )? ( 'at' coord )? tikzstring
            {
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:207:4: ( nodename )?
            	int alt31 = 2;
            	int LA31_0 = input.LA(1);

            	if ( (LA31_0 == LPAR) )
            	{
            	    alt31 = 1;
            	}
            	switch (alt31) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:207:4: nodename
            	        {
            	        	PushFollow(FOLLOW_nodename_in_tikznode1298);
            	        	nodename110 = nodename();
            	        	state.followingStackPointer--;

            	        	stream_nodename.Add(nodename110.Tree);

            	        }
            	        break;

            	}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:207:14: ( 'at' coord )?
            	int alt32 = 2;
            	int LA32_0 = input.LA(1);

            	if ( (LA32_0 == 58) )
            	{
            	    alt32 = 1;
            	}
            	switch (alt32) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:207:15: 'at' coord
            	        {
            	        	string_literal111=(IToken)Match(input,58,FOLLOW_58_in_tikznode1302);  
            	        	stream_58.Add(string_literal111);

            	        	PushFollow(FOLLOW_coord_in_tikznode1304);
            	        	coord112 = coord();
            	        	state.followingStackPointer--;

            	        	stream_coord.Add(coord112.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzstring_in_tikznode1308);
            	tikzstring113 = tikzstring();
            	state.followingStackPointer--;

            	stream_tikzstring.Add(tikzstring113.Tree);


            	// AST REWRITE
            	// elements:          nodename, tikzstring, coord
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 207:40: -> ^( IM_NODE ( nodename )? ( coord )? tikzstring )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:207:43: ^( IM_NODE ( nodename )? ( coord )? tikzstring )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NODE, "IM_NODE"), root_1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:207:53: ( nodename )?
            	    if ( stream_nodename.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_nodename.NextTree());

            	    }
            	    stream_nodename.Reset();
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:207:63: ( coord )?
            	    if ( stream_coord.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_coord.NextTree());

            	    }
            	    stream_coord.Reset();
            	    adaptor.AddChild(root_1, stream_tikzstring.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tikznode"

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:210:1: edgeop : ( '--' | 'edge' | '->' | '|-' | '-|' | 'to' | 'grid' | 'rectangle' );
    public simpletikzParser.edgeop_return edgeop() // throws RecognitionException [1]
    {   
        simpletikzParser.edgeop_return retval = new simpletikzParser.edgeop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set114 = null;

        object set114_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:211:2: ( '--' | 'edge' | '->' | '|-' | '-|' | 'to' | 'grid' | 'rectangle' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set114 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 59 && input.LA(1) <= 66) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set114));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:215:1: coord_modifier : ( '+' | '++' );
    public simpletikzParser.coord_modifier_return coord_modifier() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_modifier_return retval = new simpletikzParser.coord_modifier_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set115 = null;

        object set115_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:216:2: ( '+' | '++' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set115 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 67 && input.LA(1) <= 68) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set115));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "coord_modifier"

    public class tikznodee_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tikznodee"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:219:1: tikznodee : node_start tikznode ( tikzpathi )? semicolon_end -> ^( IM_PATH node_start tikznode ( tikzpathi )? semicolon_end ) ;
    public simpletikzParser.tikznodee_return tikznodee() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznodee_return retval = new simpletikzParser.tikznodee_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.node_start_return node_start116 = default(simpletikzParser.node_start_return);

        simpletikzParser.tikznode_return tikznode117 = default(simpletikzParser.tikznode_return);

        simpletikzParser.tikzpathi_return tikzpathi118 = default(simpletikzParser.tikzpathi_return);

        simpletikzParser.semicolon_end_return semicolon_end119 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_node_start = new RewriteRuleSubtreeStream(adaptor,"rule node_start");
        RewriteRuleSubtreeStream stream_tikznode = new RewriteRuleSubtreeStream(adaptor,"rule tikznode");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        RewriteRuleSubtreeStream stream_tikzpathi = new RewriteRuleSubtreeStream(adaptor,"rule tikzpathi");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:220:2: ( node_start tikznode ( tikzpathi )? semicolon_end -> ^( IM_PATH node_start tikznode ( tikzpathi )? semicolon_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:220:4: node_start tikznode ( tikzpathi )? semicolon_end
            {
            	PushFollow(FOLLOW_node_start_in_tikznodee1395);
            	node_start116 = node_start();
            	state.followingStackPointer--;

            	stream_node_start.Add(node_start116.Tree);
            	PushFollow(FOLLOW_tikznode_in_tikznodee1397);
            	tikznode117 = tikznode();
            	state.followingStackPointer--;

            	stream_tikznode.Add(tikznode117.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:220:24: ( tikzpathi )?
            	int alt33 = 2;
            	int LA33_0 = input.LA(1);

            	if ( (LA33_0 == LPAR || LA33_0 == 57 || (LA33_0 >= 67 && LA33_0 <= 68)) )
            	{
            	    alt33 = 1;
            	}
            	switch (alt33) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:220:24: tikzpathi
            	        {
            	        	PushFollow(FOLLOW_tikzpathi_in_tikznodee1399);
            	        	tikzpathi118 = tikzpathi();
            	        	state.followingStackPointer--;

            	        	stream_tikzpathi.Add(tikzpathi118.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_semicolon_end_in_tikznodee1402);
            	semicolon_end119 = semicolon_end();
            	state.followingStackPointer--;

            	stream_semicolon_end.Add(semicolon_end119.Tree);


            	// AST REWRITE
            	// elements:          tikznode, tikzpathi, node_start, semicolon_end
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 220:49: -> ^( IM_PATH node_start tikznode ( tikzpathi )? semicolon_end )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:220:52: ^( IM_PATH node_start tikznode ( tikzpathi )? semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_node_start.NextTree());
            	    adaptor.AddChild(root_1, stream_tikznode.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:220:82: ( tikzpathi )?
            	    if ( stream_tikzpathi.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzpathi.NextTree());

            	    }
            	    stream_tikzpathi.Reset();
            	    adaptor.AddChild(root_1, stream_semicolon_end.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tikznodee"

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:223:1: node_start : NODE -> ^( IM_STARTTAG NODE ) ;
    public simpletikzParser.node_start_return node_start() // throws RecognitionException [1]
    {   
        simpletikzParser.node_start_return retval = new simpletikzParser.node_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NODE120 = null;

        object NODE120_tree=null;
        RewriteRuleTokenStream stream_NODE = new RewriteRuleTokenStream(adaptor,"token NODE");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:224:2: ( NODE -> ^( IM_STARTTAG NODE ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:224:4: NODE
            {
            	NODE120=(IToken)Match(input,NODE,FOLLOW_NODE_in_node_start1430);  
            	stream_NODE.Add(NODE120);



            	// AST REWRITE
            	// elements:          NODE
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 224:9: -> ^( IM_STARTTAG NODE )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:224:12: ^( IM_STARTTAG NODE )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_NODE.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "node_start"

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:266:1: squarebr_start : LBR -> ^( IM_STARTTAG LBR ) ;
    public simpletikzParser.squarebr_start_return squarebr_start() // throws RecognitionException [1]
    {   
        simpletikzParser.squarebr_start_return retval = new simpletikzParser.squarebr_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LBR121 = null;

        object LBR121_tree=null;
        RewriteRuleTokenStream stream_LBR = new RewriteRuleTokenStream(adaptor,"token LBR");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:267:2: ( LBR -> ^( IM_STARTTAG LBR ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:267:4: LBR
            {
            	LBR121=(IToken)Match(input,LBR,FOLLOW_LBR_in_squarebr_start1456);  
            	stream_LBR.Add(LBR121);



            	// AST REWRITE
            	// elements:          LBR
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 267:8: -> ^( IM_STARTTAG LBR )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:267:11: ^( IM_STARTTAG LBR )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_LBR.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:269:1: squarebr_end : RBR -> ^( IM_ENDTAG RBR ) ;
    public simpletikzParser.squarebr_end_return squarebr_end() // throws RecognitionException [1]
    {   
        simpletikzParser.squarebr_end_return retval = new simpletikzParser.squarebr_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken RBR122 = null;

        object RBR122_tree=null;
        RewriteRuleTokenStream stream_RBR = new RewriteRuleTokenStream(adaptor,"token RBR");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:270:2: ( RBR -> ^( IM_ENDTAG RBR ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:270:4: RBR
            {
            	RBR122=(IToken)Match(input,RBR,FOLLOW_RBR_in_squarebr_end1474);  
            	stream_RBR.Add(RBR122);



            	// AST REWRITE
            	// elements:          RBR
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 270:8: -> ^( IM_ENDTAG RBR )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:270:11: ^( IM_ENDTAG RBR )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_RBR.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:272:1: semicolon_end : ';' -> ^( IM_ENDTAG ';' ) ;
    public simpletikzParser.semicolon_end_return semicolon_end() // throws RecognitionException [1]
    {   
        simpletikzParser.semicolon_end_return retval = new simpletikzParser.semicolon_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal123 = null;

        object char_literal123_tree=null;
        RewriteRuleTokenStream stream_SEMIC = new RewriteRuleTokenStream(adaptor,"token SEMIC");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:273:2: ( ';' -> ^( IM_ENDTAG ';' ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:273:4: ';'
            {
            	char_literal123=(IToken)Match(input,SEMIC,FOLLOW_SEMIC_in_semicolon_end1493);  
            	stream_SEMIC.Add(char_literal123);



            	// AST REWRITE
            	// elements:          SEMIC
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 273:8: -> ^( IM_ENDTAG ';' )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:273:11: ^( IM_ENDTAG ';' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_SEMIC.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "semicolon_end"

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:275:1: roundbr_end : '}' -> ^( IM_ENDTAG '}' ) ;
    public simpletikzParser.roundbr_end_return roundbr_end() // throws RecognitionException [1]
    {   
        simpletikzParser.roundbr_end_return retval = new simpletikzParser.roundbr_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal124 = null;

        object char_literal124_tree=null;
        RewriteRuleTokenStream stream_RBRR = new RewriteRuleTokenStream(adaptor,"token RBRR");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:276:2: ( '}' -> ^( IM_ENDTAG '}' ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:276:4: '}'
            {
            	char_literal124=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_roundbr_end1511);  
            	stream_RBRR.Add(char_literal124);



            	// AST REWRITE
            	// elements:          RBRR
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 276:8: -> ^( IM_ENDTAG '}' )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:276:11: ^( IM_ENDTAG '}' )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_RBRR.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:278:1: tikz_set_start : TIKZSET '{' -> ^( IM_STARTTAG ) ;
    public simpletikzParser.tikz_set_start_return tikz_set_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_set_start_return retval = new simpletikzParser.tikz_set_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken TIKZSET125 = null;
        IToken char_literal126 = null;

        object TIKZSET125_tree=null;
        object char_literal126_tree=null;
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_TIKZSET = new RewriteRuleTokenStream(adaptor,"token TIKZSET");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:279:2: ( TIKZSET '{' -> ^( IM_STARTTAG ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:279:4: TIKZSET '{'
            {
            	TIKZSET125=(IToken)Match(input,TIKZSET,FOLLOW_TIKZSET_in_tikz_set_start1529);  
            	stream_TIKZSET.Add(TIKZSET125);

            	char_literal126=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_tikz_set_start1531);  
            	stream_LBRR.Add(char_literal126);



            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 279:17: -> ^( IM_STARTTAG )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:279:20: ^( IM_STARTTAG )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:281:1: tikzpicture_start : BEGIN '{' 'tikzpicture' '}' -> ^( IM_STARTTAG BEGIN ) ;
    public simpletikzParser.tikzpicture_start_return tikzpicture_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_start_return retval = new simpletikzParser.tikzpicture_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken BEGIN127 = null;
        IToken char_literal128 = null;
        IToken string_literal129 = null;
        IToken char_literal130 = null;

        object BEGIN127_tree=null;
        object char_literal128_tree=null;
        object string_literal129_tree=null;
        object char_literal130_tree=null;
        RewriteRuleTokenStream stream_69 = new RewriteRuleTokenStream(adaptor,"token 69");
        RewriteRuleTokenStream stream_RBRR = new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_BEGIN = new RewriteRuleTokenStream(adaptor,"token BEGIN");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:282:2: ( BEGIN '{' 'tikzpicture' '}' -> ^( IM_STARTTAG BEGIN ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:282:4: BEGIN '{' 'tikzpicture' '}'
            {
            	BEGIN127=(IToken)Match(input,BEGIN,FOLLOW_BEGIN_in_tikzpicture_start1550);  
            	stream_BEGIN.Add(BEGIN127);

            	char_literal128=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_tikzpicture_start1552);  
            	stream_LBRR.Add(char_literal128);

            	string_literal129=(IToken)Match(input,69,FOLLOW_69_in_tikzpicture_start1554);  
            	stream_69.Add(string_literal129);

            	char_literal130=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_tikzpicture_start1556);  
            	stream_RBRR.Add(char_literal130);



            	// AST REWRITE
            	// elements:          BEGIN
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 282:32: -> ^( IM_STARTTAG BEGIN )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:282:35: ^( IM_STARTTAG BEGIN )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_BEGIN.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:284:1: tikzpicture_end : END '{' 'tikzpicture' '}' -> ^( IM_ENDTAG END ) ;
    public simpletikzParser.tikzpicture_end_return tikzpicture_end() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_end_return retval = new simpletikzParser.tikzpicture_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken END131 = null;
        IToken char_literal132 = null;
        IToken string_literal133 = null;
        IToken char_literal134 = null;

        object END131_tree=null;
        object char_literal132_tree=null;
        object string_literal133_tree=null;
        object char_literal134_tree=null;
        RewriteRuleTokenStream stream_69 = new RewriteRuleTokenStream(adaptor,"token 69");
        RewriteRuleTokenStream stream_RBRR = new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_END = new RewriteRuleTokenStream(adaptor,"token END");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:285:2: ( END '{' 'tikzpicture' '}' -> ^( IM_ENDTAG END ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:285:4: END '{' 'tikzpicture' '}'
            {
            	END131=(IToken)Match(input,END,FOLLOW_END_in_tikzpicture_end1574);  
            	stream_END.Add(END131);

            	char_literal132=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_tikzpicture_end1576);  
            	stream_LBRR.Add(char_literal132);

            	string_literal133=(IToken)Match(input,69,FOLLOW_69_in_tikzpicture_end1578);  
            	stream_69.Add(string_literal133);

            	char_literal134=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_tikzpicture_end1580);  
            	stream_RBRR.Add(char_literal134);



            	// AST REWRITE
            	// elements:          END
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 285:30: -> ^( IM_ENDTAG END )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:285:33: ^( IM_ENDTAG END )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_END.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:287:1: tikzscope_start : BEGIN '{' 'scope' '}' -> ^( IM_STARTTAG BEGIN ) ;
    public simpletikzParser.tikzscope_start_return tikzscope_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_start_return retval = new simpletikzParser.tikzscope_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken BEGIN135 = null;
        IToken char_literal136 = null;
        IToken string_literal137 = null;
        IToken char_literal138 = null;

        object BEGIN135_tree=null;
        object char_literal136_tree=null;
        object string_literal137_tree=null;
        object char_literal138_tree=null;
        RewriteRuleTokenStream stream_RBRR = new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_70 = new RewriteRuleTokenStream(adaptor,"token 70");
        RewriteRuleTokenStream stream_BEGIN = new RewriteRuleTokenStream(adaptor,"token BEGIN");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:288:2: ( BEGIN '{' 'scope' '}' -> ^( IM_STARTTAG BEGIN ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:288:4: BEGIN '{' 'scope' '}'
            {
            	BEGIN135=(IToken)Match(input,BEGIN,FOLLOW_BEGIN_in_tikzscope_start1598);  
            	stream_BEGIN.Add(BEGIN135);

            	char_literal136=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_tikzscope_start1600);  
            	stream_LBRR.Add(char_literal136);

            	string_literal137=(IToken)Match(input,70,FOLLOW_70_in_tikzscope_start1602);  
            	stream_70.Add(string_literal137);

            	char_literal138=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_tikzscope_start1604);  
            	stream_RBRR.Add(char_literal138);



            	// AST REWRITE
            	// elements:          BEGIN
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 288:26: -> ^( IM_STARTTAG BEGIN )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:288:29: ^( IM_STARTTAG BEGIN )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_BEGIN.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:290:1: tikzscope_end : END '{' 'scope' '}' -> ^( IM_ENDTAG END ) ;
    public simpletikzParser.tikzscope_end_return tikzscope_end() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_end_return retval = new simpletikzParser.tikzscope_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken END139 = null;
        IToken char_literal140 = null;
        IToken string_literal141 = null;
        IToken char_literal142 = null;

        object END139_tree=null;
        object char_literal140_tree=null;
        object string_literal141_tree=null;
        object char_literal142_tree=null;
        RewriteRuleTokenStream stream_RBRR = new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_END = new RewriteRuleTokenStream(adaptor,"token END");
        RewriteRuleTokenStream stream_70 = new RewriteRuleTokenStream(adaptor,"token 70");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:291:2: ( END '{' 'scope' '}' -> ^( IM_ENDTAG END ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:291:4: END '{' 'scope' '}'
            {
            	END139=(IToken)Match(input,END,FOLLOW_END_in_tikzscope_end1622);  
            	stream_END.Add(END139);

            	char_literal140=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_tikzscope_end1624);  
            	stream_LBRR.Add(char_literal140);

            	string_literal141=(IToken)Match(input,70,FOLLOW_70_in_tikzscope_end1626);  
            	stream_70.Add(string_literal141);

            	char_literal142=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_tikzscope_end1628);  
            	stream_RBRR.Add(char_literal142);



            	// AST REWRITE
            	// elements:          END
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 291:24: -> ^( IM_ENDTAG END )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:291:27: ^( IM_ENDTAG END )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_END.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:293:1: path_start : path_start_tag -> ^( IM_STARTTAG path_start_tag ) ;
    public simpletikzParser.path_start_return path_start() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_return retval = new simpletikzParser.path_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.path_start_tag_return path_start_tag143 = default(simpletikzParser.path_start_tag_return);


        RewriteRuleSubtreeStream stream_path_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule path_start_tag");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:294:2: ( path_start_tag -> ^( IM_STARTTAG path_start_tag ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:294:4: path_start_tag
            {
            	PushFollow(FOLLOW_path_start_tag_in_path_start1647);
            	path_start_tag143 = path_start_tag();
            	state.followingStackPointer--;

            	stream_path_start_tag.Add(path_start_tag143.Tree);


            	// AST REWRITE
            	// elements:          path_start_tag
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 294:19: -> ^( IM_STARTTAG path_start_tag )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:294:22: ^( IM_STARTTAG path_start_tag )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_path_start_tag.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "path_start"

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:297:1: path_start_tag : ( DRAW | FILL | PATH );
    public simpletikzParser.path_start_tag_return path_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_tag_return retval = new simpletikzParser.path_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set144 = null;

        object set144_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:298:2: ( DRAW | FILL | PATH )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set144 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= DRAW && input.LA(1) <= FILL) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set144));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "path_start_tag"

    // Delegated rules


   	protected DFA6 dfa6;
   	protected DFA21 dfa21;
   	protected DFA22 dfa22;
	private void InitializeCyclicDFAs()
	{
    	this.dfa6 = new DFA6(this);
    	this.dfa21 = new DFA21(this);
    	this.dfa22 = new DFA22(this);
	}

    const string DFA6_eotS =
        "\x05\uffff";
    const string DFA6_eofS =
        "\x05\uffff";
    const string DFA6_minS =
        "\x01\x29\x02\x10\x02\uffff";
    const string DFA6_maxS =
        "\x01\x29\x02\x33\x02\uffff";
    const string DFA6_acceptS =
        "\x03\uffff\x01\x01\x01\x02";
    const string DFA6_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA6_transitionS = {
            "\x01\x01",
            "\x01\x04\x01\uffff\x03\x04\x14\uffff\x01\x02\x09\uffff\x01"+
            "\x03",
            "\x01\x04\x01\uffff\x03\x04\x14\uffff\x01\x02\x09\uffff\x01"+
            "\x03",
            "",
            ""
    };

    static readonly short[] DFA6_eot = DFA.UnpackEncodedString(DFA6_eotS);
    static readonly short[] DFA6_eof = DFA.UnpackEncodedString(DFA6_eofS);
    static readonly char[] DFA6_min = DFA.UnpackEncodedStringToUnsignedChars(DFA6_minS);
    static readonly char[] DFA6_max = DFA.UnpackEncodedStringToUnsignedChars(DFA6_maxS);
    static readonly short[] DFA6_accept = DFA.UnpackEncodedString(DFA6_acceptS);
    static readonly short[] DFA6_special = DFA.UnpackEncodedString(DFA6_specialS);
    static readonly short[][] DFA6_transition = DFA.UnpackEncodedStringArray(DFA6_transitionS);

    protected class DFA6 : DFA
    {
        public DFA6(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 6;
            this.eot = DFA6_eot;
            this.eof = DFA6_eof;
            this.min = DFA6_min;
            this.max = DFA6_max;
            this.accept = DFA6_accept;
            this.special = DFA6_special;
            this.transition = DFA6_transition;

        }

        override public string Description
        {
            get { return "111:1: option : ( option_style | option_kv );"; }
        }

    }

    const string DFA21_eotS =
        "\x0b\uffff";
    const string DFA21_eofS =
        "\x0b\uffff";
    const string DFA21_minS =
        "\x01\x04\x01\x11\x06\uffff\x01\x29\x02\uffff";
    const string DFA21_maxS =
        "\x01\x46\x01\x11\x06\uffff\x01\x46\x02\uffff";
    const string DFA21_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x08\x01"+
        "\uffff\x01\x01\x01\x07";
    const string DFA21_specialS =
        "\x0b\uffff}>";
    static readonly string[] DFA21_transitionS = {
            "\x01\x01\x01\x07\x01\x04\x01\x06\x01\x05\x01\x03\x03\x02\x02"+
            "\x04\x01\uffff\x37\x04",
            "\x01\x08",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0a\x1c\uffff\x01\x09",
            "",
            ""
    };

    static readonly short[] DFA21_eot = DFA.UnpackEncodedString(DFA21_eotS);
    static readonly short[] DFA21_eof = DFA.UnpackEncodedString(DFA21_eofS);
    static readonly char[] DFA21_min = DFA.UnpackEncodedStringToUnsignedChars(DFA21_minS);
    static readonly char[] DFA21_max = DFA.UnpackEncodedStringToUnsignedChars(DFA21_maxS);
    static readonly short[] DFA21_accept = DFA.UnpackEncodedString(DFA21_acceptS);
    static readonly short[] DFA21_special = DFA.UnpackEncodedString(DFA21_specialS);
    static readonly short[][] DFA21_transition = DFA.UnpackEncodedStringArray(DFA21_transitionS);

    protected class DFA21 : DFA
    {
        public DFA21(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 21;
            this.eot = DFA21_eot;
            this.eof = DFA21_eof;
            this.min = DFA21_min;
            this.max = DFA21_max;
            this.accept = DFA21_accept;
            this.special = DFA21_special;
            this.transition = DFA21_transition;

        }

        override public string Description
        {
            get { return "160:4: ( tikzscope | tikzpath | tikznodee | dontcare_body_nobr | tikz_set | tikz_style | otherbegin | otherend )"; }
        }

    }

    const string DFA22_eotS =
        "\x0e\uffff";
    const string DFA22_eofS =
        "\x0e\uffff";
    const string DFA22_minS =
        "\x01\x04\x02\x11\x05\uffff\x02\x29\x04\uffff";
    const string DFA22_maxS =
        "\x01\x46\x02\x11\x05\uffff\x02\x46\x04\uffff";
    const string DFA22_acceptS =
        "\x03\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x02\uffff\x01"+
        "\x09\x01\x08\x01\x01\x01\x07";
    const string DFA22_specialS =
        "\x0e\uffff}>";
    static readonly string[] DFA22_transitionS = {
            "\x01\x02\x01\x01\x01\x05\x01\x07\x01\x06\x01\x04\x03\x03\x3a"+
            "\x05",
            "\x01\x08",
            "\x01\x09",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0b\x1b\uffff\x02\x0a",
            "\x01\x0d\x1c\uffff\x01\x0c",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA22_eot = DFA.UnpackEncodedString(DFA22_eotS);
    static readonly short[] DFA22_eof = DFA.UnpackEncodedString(DFA22_eofS);
    static readonly char[] DFA22_min = DFA.UnpackEncodedStringToUnsignedChars(DFA22_minS);
    static readonly char[] DFA22_max = DFA.UnpackEncodedStringToUnsignedChars(DFA22_maxS);
    static readonly short[] DFA22_accept = DFA.UnpackEncodedString(DFA22_acceptS);
    static readonly short[] DFA22_special = DFA.UnpackEncodedString(DFA22_specialS);
    static readonly short[][] DFA22_transition = DFA.UnpackEncodedStringArray(DFA22_transitionS);

    protected class DFA22 : DFA
    {
        public DFA22(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 22;
            this.eot = DFA22_eot;
            this.eof = DFA22_eof;
            this.min = DFA22_min;
            this.max = DFA22_max;
            this.accept = DFA22_accept;
            this.special = DFA22_special;
            this.transition = DFA22_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 161:3: ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )*"; }
        }

    }

 

    public static readonly BitSet FOLLOW_dontcare_preamble_in_tikzdocument341 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_tikz_styleorset_in_tikzdocument345 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzdocument349 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_tikzpicture_in_tikzdocument354 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikz_styleorset379 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikz_styleorset383 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_preamble394 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BEGIN_in_otherbegin415 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_LBRR_in_otherbegin417 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_idd_in_otherbegin419 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_RBRR_in_otherbegin421 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TIKZSTYLE_in_tikz_style432 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_LBRR_in_tikz_style434 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_idd_in_tikz_style436 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_RBRR_in_tikz_style438 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_EQU_in_tikz_style440 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikz_style442 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_squarebr_start_in_tikz_options464 = new BitSet(new ulong[]{0x0000020000010000UL});
    public static readonly BitSet FOLLOW_option_in_tikz_options467 = new BitSet(new ulong[]{0x0000020000090000UL});
    public static readonly BitSet FOLLOW_KOMMA_in_tikz_options470 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_option_in_tikz_options472 = new BitSet(new ulong[]{0x0000020000090000UL});
    public static readonly BitSet FOLLOW_KOMMA_in_tikz_options476 = new BitSet(new ulong[]{0x0000020000010000UL});
    public static readonly BitSet FOLLOW_squarebr_end_in_tikz_options481 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_option_style_in_option506 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_option_kv_in_option515 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_option_kv529 = new BitSet(new ulong[]{0x0000000000100002UL});
    public static readonly BitSet FOLLOW_EQU_in_option_kv532 = new BitSet(new ulong[]{0x00000E0000020000UL});
    public static readonly BitSet FOLLOW_iddornumberunitorstring_in_option_kv534 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRR_in_tikzstring562 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_no_rlbrace_in_tikzstring564 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikzstring568 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_no_rlbrace_in_tikzstring570 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_RBRR_in_tikzstring575 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_no_rlbrace598 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_iddornumberunitorstring615 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_numberunit_in_iddornumberunitorstring619 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzstring_in_iddornumberunitorstring623 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_option_style633 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_option_style635 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_EQU_in_option_style637 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_LBRR_in_option_style639 = new BitSet(new ulong[]{0x00000200000C0000UL});
    public static readonly BitSet FOLLOW_option_kv_in_option_style642 = new BitSet(new ulong[]{0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_KOMMA_in_option_style645 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_option_kv_in_option_style647 = new BitSet(new ulong[]{0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_KOMMA_in_option_style654 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_RBRR_in_option_style657 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_idd683 = new BitSet(new ulong[]{0x0000020000000002UL});
    public static readonly BitSet FOLLOW_ID_in_idd686 = new BitSet(new ulong[]{0x0000020000000002UL});
    public static readonly BitSet FOLLOW_number_in_numberunit708 = new BitSet(new ulong[]{0x01F0000000000002UL});
    public static readonly BitSet FOLLOW_unit_in_numberunit710 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_number733 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unit0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_set_start_in_tikz_set780 = new BitSet(new ulong[]{0x0000020000040000UL});
    public static readonly BitSet FOLLOW_option_in_tikz_set783 = new BitSet(new ulong[]{0x00000200000C0000UL});
    public static readonly BitSet FOLLOW_KOMMA_in_tikz_set786 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_option_in_tikz_set788 = new BitSet(new ulong[]{0x00000200000C0000UL});
    public static readonly BitSet FOLLOW_roundbr_end_in_tikz_set794 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzpicture_start_in_tikzpicture822 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpicture824 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzpicture827 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_tikzpicture_end_in_tikzpicture830 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody860 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody864 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_tikznodee_in_tikzbody868 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_dontcare_body_nobr_in_tikzbody872 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody876 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody880 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody884 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody887 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody897 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody901 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_tikznodee_in_tikzbody905 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_dontcare_body_in_tikzbody909 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody913 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody917 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody921 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody924 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body_nobr940 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body990 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_END_in_otherend1034 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_LBRR_in_otherend1036 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_idd_in_otherend1038 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_RBRR_in_otherend1040 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_in_tikzpath1053 = new BitSet(new ulong[]{0x020000000000A000UL,0x0000000000000018UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpath1055 = new BitSet(new ulong[]{0x020000000000A000UL,0x0000000000000018UL});
    public static readonly BitSet FOLLOW_tikzpathi_in_tikzpath1058 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzpath1060 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coordornode_in_tikzpathi1089 = new BitSet(new ulong[]{0xFA0000000000A002UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_coordornode_in_tikzpathi1092 = new BitSet(new ulong[]{0xFA0000000000A002UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpathi1096 = new BitSet(new ulong[]{0xFA0000000000A000UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_edgeop_in_tikzpathi1099 = new BitSet(new ulong[]{0x020000000000A000UL,0x0000000000000018UL});
    public static readonly BitSet FOLLOW_coordornode_in_tikzpathi1102 = new BitSet(new ulong[]{0xFA0000000000A002UL,0x000000000000001FUL});
    public static readonly BitSet FOLLOW_tikzscope_start_in_tikzscope1118 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzscope1120 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzscope1123 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_tikzscope_end_in_tikzscope1126 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_in_coordornode1153 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznodei_in_coordornode1157 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_57_in_tikznodei1169 = new BitSet(new ulong[]{0x04000E0000022000UL});
    public static readonly BitSet FOLLOW_tikznode_in_tikznodei1172 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAR_in_nodename1184 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_ID_in_nodename1188 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_RPAR_in_nodename1190 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_coord1214 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord1238 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LPAR_in_coord1243 = new BitSet(new ulong[]{0x00000C0000000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord1245 = new BitSet(new ulong[]{0x0000000000480000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord1247 = new BitSet(new ulong[]{0x00000C0000000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord1249 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_RPAR_in_coord1251 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_coord_sep1278 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_tikznode1298 = new BitSet(new ulong[]{0x04000E0000020000UL});
    public static readonly BitSet FOLLOW_58_in_tikznode1302 = new BitSet(new ulong[]{0x0000000000002000UL,0x0000000000000018UL});
    public static readonly BitSet FOLLOW_coord_in_tikznode1304 = new BitSet(new ulong[]{0x00000E0000020000UL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikznode1308 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_edgeop0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_coord_modifier0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_node_start_in_tikznodee1395 = new BitSet(new ulong[]{0x04000E0000022000UL});
    public static readonly BitSet FOLLOW_tikznode_in_tikznodee1397 = new BitSet(new ulong[]{0x020000000020A000UL,0x0000000000000018UL});
    public static readonly BitSet FOLLOW_tikzpathi_in_tikznodee1399 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikznodee1402 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NODE_in_node_start1430 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBR_in_squarebr_start1456 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RBR_in_squarebr_end1474 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SEMIC_in_semicolon_end1493 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RBRR_in_roundbr_end1511 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TIKZSET_in_tikz_set_start1529 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_LBRR_in_tikz_set_start1531 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BEGIN_in_tikzpicture_start1550 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_LBRR_in_tikzpicture_start1552 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_69_in_tikzpicture_start1554 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_RBRR_in_tikzpicture_start1556 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_END_in_tikzpicture_end1574 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_LBRR_in_tikzpicture_end1576 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_69_in_tikzpicture_end1578 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_RBRR_in_tikzpicture_end1580 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BEGIN_in_tikzscope_start1598 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_LBRR_in_tikzscope_start1600 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_70_in_tikzscope_start1602 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_RBRR_in_tikzscope_start1604 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_END_in_tikzscope_end1622 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_LBRR_in_tikzscope_end1624 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_70_in_tikzscope_end1626 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_RBRR_in_tikzscope_end1628 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_tag_in_path_start1647 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_path_start_tag0 = new BitSet(new ulong[]{0x0000000000000002UL});

}
