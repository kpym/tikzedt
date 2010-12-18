// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g 2010-12-18 16:08:42

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
		"INT", 
		"FLOAT_WO_EXP", 
		"ID", 
		"COMMENT", 
		"WS", 
		"EXPONENT", 
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
		"'em'", 
		"'at'", 
		"'--'", 
		"'->'", 
		"'|-'", 
		"'-|'", 
		"'+'", 
		"'++'", 
		"'tikzpicture'", 
		"'scope'"
    };

    public const int T__66 = 66;
    public const int EXPONENT = 46;
    public const int T__64 = 64;
    public const int IM_STARTTAG = 31;
    public const int T__65 = 65;
    public const int T__62 = 62;
    public const int T__63 = 63;
    public const int RBR = 16;
    public const int IM_PATH = 23;
    public const int IM_ID = 36;
    public const int SOMETHING = 50;
    public const int ID = 43;
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
    public const int COMMENT = 44;
    public const int IM_OPTIONS = 33;
    public const int IM_OPTION_STYLE = 34;
    public const int NODE = 9;
    public const int TIKZSTYLE = 7;
    public const int TIKZSET = 8;
    public const int IM_COORD = 25;
    public const int IM_PICTURE = 28;
    public const int INT = 41;
    public const int LBRR = 17;
    public const int USETIKZLIB = 6;
    public const int IM_NODE = 24;
    public const int IM_STYLE = 40;
    public const int COLON = 22;
    public const int IM_SCOPE = 30;
    public const int IM_NUMBERUNIT = 27;
    public const int WS = 45;
    public const int KOMMA = 19;
    public const int EQU = 20;
    public const int RPAR = 14;
    public const int END = 5;
    public const int SEMIC = 21;
    public const int IM_NODENAME = 26;
    public const int FLOAT_WO_EXP = 42;
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
		get { return "C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g"; }
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:87:1: tikzdocument : ( dontcare_preamble | tikz_styleorset | otherbegin )* tikzpicture -> ^( IM_DOCUMENT ( tikz_styleorset )* tikzpicture ) ;
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:88:2: ( ( dontcare_preamble | tikz_styleorset | otherbegin )* tikzpicture -> ^( IM_DOCUMENT ( tikz_styleorset )* tikzpicture ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:88:5: ( dontcare_preamble | tikz_styleorset | otherbegin )* tikzpicture
            {
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:88:5: ( dontcare_preamble | tikz_styleorset | otherbegin )*
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

            	            if ( (LA1_4 == ID || (LA1_4 >= 59 && LA1_4 <= 62)) )
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
            	    case INT:
            	    case FLOAT_WO_EXP:
            	    case ID:
            	    case COMMENT:
            	    case WS:
            	    case EXPONENT:
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
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:88:6: dontcare_preamble
            			    {
            			    	PushFollow(FOLLOW_dontcare_preamble_in_tikzdocument340);
            			    	dontcare_preamble1 = dontcare_preamble();
            			    	state.followingStackPointer--;

            			    	stream_dontcare_preamble.Add(dontcare_preamble1.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:88:26: tikz_styleorset
            			    {
            			    	PushFollow(FOLLOW_tikz_styleorset_in_tikzdocument344);
            			    	tikz_styleorset2 = tikz_styleorset();
            			    	state.followingStackPointer--;

            			    	stream_tikz_styleorset.Add(tikz_styleorset2.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:88:44: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzdocument348);
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

            	PushFollow(FOLLOW_tikzpicture_in_tikzdocument353);
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
            	// 88:73: -> ^( IM_DOCUMENT ( tikz_styleorset )* tikzpicture )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:88:76: ^( IM_DOCUMENT ( tikz_styleorset )* tikzpicture )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DOCUMENT, "IM_DOCUMENT"), root_1);

            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:88:90: ( tikz_styleorset )*
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:91:1: tikz_styleorset : ( tikz_style | tikz_set );
    public simpletikzParser.tikz_styleorset_return tikz_styleorset() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_styleorset_return retval = new simpletikzParser.tikz_styleorset_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikz_style_return tikz_style5 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.tikz_set_return tikz_set6 = default(simpletikzParser.tikz_set_return);



        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:92:2: ( tikz_style | tikz_set )
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
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:92:4: tikz_style
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_style_in_tikz_styleorset378);
                    	tikz_style5 = tikz_style();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, tikz_style5.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:92:17: tikz_set
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikz_set_in_tikz_styleorset382);
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:95:1: dontcare_preamble : ~ ( BEGIN | TIKZSTYLE | TIKZSET ) ;
    public simpletikzParser.dontcare_preamble_return dontcare_preamble() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_preamble_return retval = new simpletikzParser.dontcare_preamble_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set7 = null;

        object set7_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:96:2: (~ ( BEGIN | TIKZSTYLE | TIKZSET ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:96:4: ~ ( BEGIN | TIKZSTYLE | TIKZSET )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set7 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= END && input.LA(1) <= USETIKZLIB) || (input.LA(1) >= NODE && input.LA(1) <= 66) ) 
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:98:1: otherbegin : BEGIN LBRR idd RBRR ;
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:99:2: ( BEGIN LBRR idd RBRR )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:99:4: BEGIN LBRR idd RBRR
            {
            	root_0 = (object)adaptor.GetNilNode();

            	BEGIN8=(IToken)Match(input,BEGIN,FOLLOW_BEGIN_in_otherbegin414); 
            		BEGIN8_tree = (object)adaptor.Create(BEGIN8);
            		adaptor.AddChild(root_0, BEGIN8_tree);

            	LBRR9=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_otherbegin416); 
            		LBRR9_tree = (object)adaptor.Create(LBRR9);
            		adaptor.AddChild(root_0, LBRR9_tree);

            	PushFollow(FOLLOW_idd_in_otherbegin418);
            	idd10 = idd();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, idd10.Tree);
            	RBRR11=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_otherbegin420); 
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:102:1: tikz_style : TIKZSTYLE LBRR idd RBRR '=' tikz_options -> ^( IM_STYLE idd tikz_options ) ;
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:103:2: ( TIKZSTYLE LBRR idd RBRR '=' tikz_options -> ^( IM_STYLE idd tikz_options ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:103:4: TIKZSTYLE LBRR idd RBRR '=' tikz_options
            {
            	TIKZSTYLE12=(IToken)Match(input,TIKZSTYLE,FOLLOW_TIKZSTYLE_in_tikz_style431);  
            	stream_TIKZSTYLE.Add(TIKZSTYLE12);

            	LBRR13=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_tikz_style433);  
            	stream_LBRR.Add(LBRR13);

            	PushFollow(FOLLOW_idd_in_tikz_style435);
            	idd14 = idd();
            	state.followingStackPointer--;

            	stream_idd.Add(idd14.Tree);
            	RBRR15=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_tikz_style437);  
            	stream_RBRR.Add(RBRR15);

            	char_literal16=(IToken)Match(input,EQU,FOLLOW_EQU_in_tikz_style439);  
            	stream_EQU.Add(char_literal16);

            	PushFollow(FOLLOW_tikz_options_in_tikz_style441);
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
            	// 103:45: -> ^( IM_STYLE idd tikz_options )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:103:48: ^( IM_STYLE idd tikz_options )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:106:1: tikz_options : squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) ;
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:107:2: ( squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:107:5: squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end
            {
            	PushFollow(FOLLOW_squarebr_start_in_tikz_options463);
            	squarebr_start18 = squarebr_start();
            	state.followingStackPointer--;

            	stream_squarebr_start.Add(squarebr_start18.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:107:20: ( option ( ',' option )* ( ',' )? )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == ID || (LA5_0 >= 59 && LA5_0 <= 62)) )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:107:21: option ( ',' option )* ( ',' )?
            	        {
            	        	PushFollow(FOLLOW_option_in_tikz_options466);
            	        	option19 = option();
            	        	state.followingStackPointer--;

            	        	stream_option.Add(option19.Tree);
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:107:28: ( ',' option )*
            	        	do 
            	        	{
            	        	    int alt3 = 2;
            	        	    int LA3_0 = input.LA(1);

            	        	    if ( (LA3_0 == KOMMA) )
            	        	    {
            	        	        int LA3_1 = input.LA(2);

            	        	        if ( (LA3_1 == ID || (LA3_1 >= 59 && LA3_1 <= 62)) )
            	        	        {
            	        	            alt3 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt3) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:107:29: ',' option
            	        			    {
            	        			    	char_literal20=(IToken)Match(input,KOMMA,FOLLOW_KOMMA_in_tikz_options469);  
            	        			    	stream_KOMMA.Add(char_literal20);

            	        			    	PushFollow(FOLLOW_option_in_tikz_options471);
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

            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:107:42: ( ',' )?
            	        	int alt4 = 2;
            	        	int LA4_0 = input.LA(1);

            	        	if ( (LA4_0 == KOMMA) )
            	        	{
            	        	    alt4 = 1;
            	        	}
            	        	switch (alt4) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:107:42: ','
            	        	        {
            	        	        	char_literal22=(IToken)Match(input,KOMMA,FOLLOW_KOMMA_in_tikz_options475);  
            	        	        	stream_KOMMA.Add(char_literal22);


            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_squarebr_end_in_tikz_options480);
            	squarebr_end23 = squarebr_end();
            	state.followingStackPointer--;

            	stream_squarebr_end.Add(squarebr_end23.Tree);


            	// AST REWRITE
            	// elements:          squarebr_end, option, squarebr_start
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 107:63: -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:107:66: ^( IM_OPTIONS squarebr_start ( option )* squarebr_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTIONS, "IM_OPTIONS"), root_1);

            	    adaptor.AddChild(root_1, stream_squarebr_start.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:107:94: ( option )*
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:110:1: option : ( option_style | option_kv );
    public simpletikzParser.option_return option() // throws RecognitionException [1]
    {   
        simpletikzParser.option_return retval = new simpletikzParser.option_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.option_style_return option_style24 = default(simpletikzParser.option_style_return);

        simpletikzParser.option_kv_return option_kv25 = default(simpletikzParser.option_kv_return);



        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:111:2: ( option_style | option_kv )
            int alt6 = 2;
            alt6 = dfa6.Predict(input);
            switch (alt6) 
            {
                case 1 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:111:4: option_style
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_option_style_in_option505);
                    	option_style24 = option_style();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, option_style24.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:112:5: option_kv
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_option_kv_in_option514);
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:115:1: option_kv : idd ( '=' iddornumberunitorstring )? -> ^( IM_OPTION_KV idd ( iddornumberunitorstring )? ) ;
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:116:2: ( idd ( '=' iddornumberunitorstring )? -> ^( IM_OPTION_KV idd ( iddornumberunitorstring )? ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:116:4: idd ( '=' iddornumberunitorstring )?
            {
            	PushFollow(FOLLOW_idd_in_option_kv528);
            	idd26 = idd();
            	state.followingStackPointer--;

            	stream_idd.Add(idd26.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:116:8: ( '=' iddornumberunitorstring )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( (LA7_0 == EQU) )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:116:9: '=' iddornumberunitorstring
            	        {
            	        	char_literal27=(IToken)Match(input,EQU,FOLLOW_EQU_in_option_kv531);  
            	        	stream_EQU.Add(char_literal27);

            	        	PushFollow(FOLLOW_iddornumberunitorstring_in_option_kv533);
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
            	// 116:40: -> ^( IM_OPTION_KV idd ( iddornumberunitorstring )? )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:116:43: ^( IM_OPTION_KV idd ( iddornumberunitorstring )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTION_KV, "IM_OPTION_KV"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:116:62: ( iddornumberunitorstring )?
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

    public class nodetype_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "nodetype"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:119:1: nodetype : LBR ( no_rlbracket )* ( nodetype ( no_rlbracket )* )* RBR -> ^( IM_STRING LBR RBR ) ;
    public simpletikzParser.nodetype_return nodetype() // throws RecognitionException [1]
    {   
        simpletikzParser.nodetype_return retval = new simpletikzParser.nodetype_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LBR29 = null;
        IToken RBR33 = null;
        simpletikzParser.no_rlbracket_return no_rlbracket30 = default(simpletikzParser.no_rlbracket_return);

        simpletikzParser.nodetype_return nodetype31 = default(simpletikzParser.nodetype_return);

        simpletikzParser.no_rlbracket_return no_rlbracket32 = default(simpletikzParser.no_rlbracket_return);


        object LBR29_tree=null;
        object RBR33_tree=null;
        RewriteRuleTokenStream stream_RBR = new RewriteRuleTokenStream(adaptor,"token RBR");
        RewriteRuleTokenStream stream_LBR = new RewriteRuleTokenStream(adaptor,"token LBR");
        RewriteRuleSubtreeStream stream_nodetype = new RewriteRuleSubtreeStream(adaptor,"rule nodetype");
        RewriteRuleSubtreeStream stream_no_rlbracket = new RewriteRuleSubtreeStream(adaptor,"rule no_rlbracket");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:120:2: ( LBR ( no_rlbracket )* ( nodetype ( no_rlbracket )* )* RBR -> ^( IM_STRING LBR RBR ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:120:4: LBR ( no_rlbracket )* ( nodetype ( no_rlbracket )* )* RBR
            {
            	LBR29=(IToken)Match(input,LBR,FOLLOW_LBR_in_nodetype561);  
            	stream_LBR.Add(LBR29);

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:120:8: ( no_rlbracket )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( ((LA8_0 >= BEGIN && LA8_0 <= RPAR) || (LA8_0 >= LBRR && LA8_0 <= 66)) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:120:8: no_rlbracket
            			    {
            			    	PushFollow(FOLLOW_no_rlbracket_in_nodetype563);
            			    	no_rlbracket30 = no_rlbracket();
            			    	state.followingStackPointer--;

            			    	stream_no_rlbracket.Add(no_rlbracket30.Tree);

            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:120:22: ( nodetype ( no_rlbracket )* )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( (LA10_0 == LBR) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:120:23: nodetype ( no_rlbracket )*
            			    {
            			    	PushFollow(FOLLOW_nodetype_in_nodetype567);
            			    	nodetype31 = nodetype();
            			    	state.followingStackPointer--;

            			    	stream_nodetype.Add(nodetype31.Tree);
            			    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:120:32: ( no_rlbracket )*
            			    	do 
            			    	{
            			    	    int alt9 = 2;
            			    	    int LA9_0 = input.LA(1);

            			    	    if ( ((LA9_0 >= BEGIN && LA9_0 <= RPAR) || (LA9_0 >= LBRR && LA9_0 <= 66)) )
            			    	    {
            			    	        alt9 = 1;
            			    	    }


            			    	    switch (alt9) 
            			    		{
            			    			case 1 :
            			    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:120:32: no_rlbracket
            			    			    {
            			    			    	PushFollow(FOLLOW_no_rlbracket_in_nodetype569);
            			    			    	no_rlbracket32 = no_rlbracket();
            			    			    	state.followingStackPointer--;

            			    			    	stream_no_rlbracket.Add(no_rlbracket32.Tree);

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

            	RBR33=(IToken)Match(input,RBR,FOLLOW_RBR_in_nodetype574);  
            	stream_RBR.Add(RBR33);



            	// AST REWRITE
            	// elements:          RBR, LBR
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 120:52: -> ^( IM_STRING LBR RBR )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:120:55: ^( IM_STRING LBR RBR )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STRING, "IM_STRING"), root_1);

            	    adaptor.AddChild(root_1, stream_LBR.NextNode());
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
    // $ANTLR end "nodetype"

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:123:1: no_rlbracket : ~ ( LBR | RBR ) ;
    public simpletikzParser.no_rlbracket_return no_rlbracket() // throws RecognitionException [1]
    {   
        simpletikzParser.no_rlbracket_return retval = new simpletikzParser.no_rlbracket_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set34 = null;

        object set34_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:124:2: (~ ( LBR | RBR ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:124:4: ~ ( LBR | RBR )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set34 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= BEGIN && input.LA(1) <= RPAR) || (input.LA(1) >= LBRR && input.LA(1) <= 66) ) 
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
    // $ANTLR end "no_rlbracket"

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:126:1: tikzstring : LBRR ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* RBRR -> ^( IM_STRING LBRR RBRR ) ;
    public simpletikzParser.tikzstring_return tikzstring() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzstring_return retval = new simpletikzParser.tikzstring_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LBRR35 = null;
        IToken RBRR39 = null;
        simpletikzParser.no_rlbrace_return no_rlbrace36 = default(simpletikzParser.no_rlbrace_return);

        simpletikzParser.tikzstring_return tikzstring37 = default(simpletikzParser.tikzstring_return);

        simpletikzParser.no_rlbrace_return no_rlbrace38 = default(simpletikzParser.no_rlbrace_return);


        object LBRR35_tree=null;
        object RBRR39_tree=null;
        RewriteRuleTokenStream stream_RBRR = new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleSubtreeStream stream_tikzstring = new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_no_rlbrace = new RewriteRuleSubtreeStream(adaptor,"rule no_rlbrace");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:127:2: ( LBRR ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* RBRR -> ^( IM_STRING LBRR RBRR ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:127:4: LBRR ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* RBRR
            {
            	LBRR35=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_tikzstring614);  
            	stream_LBRR.Add(LBRR35);

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:127:9: ( no_rlbrace )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( ((LA11_0 >= BEGIN && LA11_0 <= RBR) || (LA11_0 >= KOMMA && LA11_0 <= 66)) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:127:9: no_rlbrace
            			    {
            			    	PushFollow(FOLLOW_no_rlbrace_in_tikzstring616);
            			    	no_rlbrace36 = no_rlbrace();
            			    	state.followingStackPointer--;

            			    	stream_no_rlbrace.Add(no_rlbrace36.Tree);

            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:127:21: ( tikzstring ( no_rlbrace )* )*
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( (LA13_0 == LBRR) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:127:22: tikzstring ( no_rlbrace )*
            			    {
            			    	PushFollow(FOLLOW_tikzstring_in_tikzstring620);
            			    	tikzstring37 = tikzstring();
            			    	state.followingStackPointer--;

            			    	stream_tikzstring.Add(tikzstring37.Tree);
            			    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:127:33: ( no_rlbrace )*
            			    	do 
            			    	{
            			    	    int alt12 = 2;
            			    	    int LA12_0 = input.LA(1);

            			    	    if ( ((LA12_0 >= BEGIN && LA12_0 <= RBR) || (LA12_0 >= KOMMA && LA12_0 <= 66)) )
            			    	    {
            			    	        alt12 = 1;
            			    	    }


            			    	    switch (alt12) 
            			    		{
            			    			case 1 :
            			    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:127:33: no_rlbrace
            			    			    {
            			    			    	PushFollow(FOLLOW_no_rlbrace_in_tikzstring622);
            			    			    	no_rlbrace38 = no_rlbrace();
            			    			    	state.followingStackPointer--;

            			    			    	stream_no_rlbrace.Add(no_rlbrace38.Tree);

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

            	RBRR39=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_tikzstring627);  
            	stream_RBRR.Add(RBRR39);



            	// AST REWRITE
            	// elements:          LBRR, RBRR
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 127:52: -> ^( IM_STRING LBRR RBRR )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:127:55: ^( IM_STRING LBRR RBRR )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:130:1: no_rlbrace : ~ ( LBRR | RBRR ) ;
    public simpletikzParser.no_rlbrace_return no_rlbrace() // throws RecognitionException [1]
    {   
        simpletikzParser.no_rlbrace_return retval = new simpletikzParser.no_rlbrace_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set40 = null;

        object set40_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:131:2: (~ ( LBRR | RBRR ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:131:4: ~ ( LBRR | RBRR )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set40 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= BEGIN && input.LA(1) <= RBR) || (input.LA(1) >= KOMMA && input.LA(1) <= 66) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set40));
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:133:1: iddornumberunitorstring : ( idd | numberunit | tikzstring );
    public simpletikzParser.iddornumberunitorstring_return iddornumberunitorstring() // throws RecognitionException [1]
    {   
        simpletikzParser.iddornumberunitorstring_return retval = new simpletikzParser.iddornumberunitorstring_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.idd_return idd41 = default(simpletikzParser.idd_return);

        simpletikzParser.numberunit_return numberunit42 = default(simpletikzParser.numberunit_return);

        simpletikzParser.tikzstring_return tikzstring43 = default(simpletikzParser.tikzstring_return);



        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:134:2: ( idd | numberunit | tikzstring )
            int alt14 = 3;
            switch ( input.LA(1) ) 
            {
            case ID:
            case 59:
            case 60:
            case 61:
            case 62:
            	{
                alt14 = 1;
                }
                break;
            case INT:
            case FLOAT_WO_EXP:
            	{
                alt14 = 2;
                }
                break;
            case LBRR:
            	{
                alt14 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d14s0 =
            	        new NoViableAltException("", 14, 0, input);

            	    throw nvae_d14s0;
            }

            switch (alt14) 
            {
                case 1 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:134:4: idd
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_idd_in_iddornumberunitorstring667);
                    	idd41 = idd();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, idd41.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:134:10: numberunit
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_numberunit_in_iddornumberunitorstring671);
                    	numberunit42 = numberunit();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, numberunit42.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:134:23: tikzstring
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikzstring_in_iddornumberunitorstring675);
                    	tikzstring43 = tikzstring();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, tikzstring43.Tree);

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:136:1: option_style : idd '/.style' '=' LBRR ( option_kv ( ',' option_kv )* )? ( ',' )? RBRR -> ^( IM_OPTION_STYLE idd ( option_kv )* ) ;
    public simpletikzParser.option_style_return option_style() // throws RecognitionException [1]
    {   
        simpletikzParser.option_style_return retval = new simpletikzParser.option_style_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal45 = null;
        IToken char_literal46 = null;
        IToken LBRR47 = null;
        IToken char_literal49 = null;
        IToken char_literal51 = null;
        IToken RBRR52 = null;
        simpletikzParser.idd_return idd44 = default(simpletikzParser.idd_return);

        simpletikzParser.option_kv_return option_kv48 = default(simpletikzParser.option_kv_return);

        simpletikzParser.option_kv_return option_kv50 = default(simpletikzParser.option_kv_return);


        object string_literal45_tree=null;
        object char_literal46_tree=null;
        object LBRR47_tree=null;
        object char_literal49_tree=null;
        object char_literal51_tree=null;
        object RBRR52_tree=null;
        RewriteRuleTokenStream stream_EQU = new RewriteRuleTokenStream(adaptor,"token EQU");
        RewriteRuleTokenStream stream_RBRR = new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_KOMMA = new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_idd = new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_option_kv = new RewriteRuleSubtreeStream(adaptor,"rule option_kv");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:137:2: ( idd '/.style' '=' LBRR ( option_kv ( ',' option_kv )* )? ( ',' )? RBRR -> ^( IM_OPTION_STYLE idd ( option_kv )* ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:137:4: idd '/.style' '=' LBRR ( option_kv ( ',' option_kv )* )? ( ',' )? RBRR
            {
            	PushFollow(FOLLOW_idd_in_option_style685);
            	idd44 = idd();
            	state.followingStackPointer--;

            	stream_idd.Add(idd44.Tree);
            	string_literal45=(IToken)Match(input,51,FOLLOW_51_in_option_style687);  
            	stream_51.Add(string_literal45);

            	char_literal46=(IToken)Match(input,EQU,FOLLOW_EQU_in_option_style689);  
            	stream_EQU.Add(char_literal46);

            	LBRR47=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_option_style691);  
            	stream_LBRR.Add(LBRR47);

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:137:27: ( option_kv ( ',' option_kv )* )?
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( (LA16_0 == ID || (LA16_0 >= 59 && LA16_0 <= 62)) )
            	{
            	    alt16 = 1;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:137:28: option_kv ( ',' option_kv )*
            	        {
            	        	PushFollow(FOLLOW_option_kv_in_option_style694);
            	        	option_kv48 = option_kv();
            	        	state.followingStackPointer--;

            	        	stream_option_kv.Add(option_kv48.Tree);
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:137:38: ( ',' option_kv )*
            	        	do 
            	        	{
            	        	    int alt15 = 2;
            	        	    int LA15_0 = input.LA(1);

            	        	    if ( (LA15_0 == KOMMA) )
            	        	    {
            	        	        int LA15_1 = input.LA(2);

            	        	        if ( (LA15_1 == ID || (LA15_1 >= 59 && LA15_1 <= 62)) )
            	        	        {
            	        	            alt15 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt15) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:137:39: ',' option_kv
            	        			    {
            	        			    	char_literal49=(IToken)Match(input,KOMMA,FOLLOW_KOMMA_in_option_style697);  
            	        			    	stream_KOMMA.Add(char_literal49);

            	        			    	PushFollow(FOLLOW_option_kv_in_option_style699);
            	        			    	option_kv50 = option_kv();
            	        			    	state.followingStackPointer--;

            	        			    	stream_option_kv.Add(option_kv50.Tree);

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

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:137:58: ( ',' )?
            	int alt17 = 2;
            	int LA17_0 = input.LA(1);

            	if ( (LA17_0 == KOMMA) )
            	{
            	    alt17 = 1;
            	}
            	switch (alt17) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:137:58: ','
            	        {
            	        	char_literal51=(IToken)Match(input,KOMMA,FOLLOW_KOMMA_in_option_style706);  
            	        	stream_KOMMA.Add(char_literal51);


            	        }
            	        break;

            	}

            	RBRR52=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_option_style709);  
            	stream_RBRR.Add(RBRR52);



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
            	// 137:69: -> ^( IM_OPTION_STYLE idd ( option_kv )* )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:137:72: ^( IM_OPTION_STYLE idd ( option_kv )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTION_STYLE, "IM_OPTION_STYLE"), root_1);

            	    adaptor.AddChild(root_1, stream_idd.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:137:94: ( option_kv )*
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:145:1: idd : ( edgeop ( edgeop )* -> ^( IM_ID ( edgeop )* ) | edgeop INT -> ^( IM_ID edgeop INT ) );
    public simpletikzParser.idd_return idd() // throws RecognitionException [1]
    {   
        simpletikzParser.idd_return retval = new simpletikzParser.idd_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INT56 = null;
        simpletikzParser.edgeop_return edgeop53 = default(simpletikzParser.edgeop_return);

        simpletikzParser.edgeop_return edgeop54 = default(simpletikzParser.edgeop_return);

        simpletikzParser.edgeop_return edgeop55 = default(simpletikzParser.edgeop_return);


        object INT56_tree=null;
        RewriteRuleTokenStream stream_INT = new RewriteRuleTokenStream(adaptor,"token INT");
        RewriteRuleSubtreeStream stream_edgeop = new RewriteRuleSubtreeStream(adaptor,"rule edgeop");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:146:2: ( edgeop ( edgeop )* -> ^( IM_ID ( edgeop )* ) | edgeop INT -> ^( IM_ID edgeop INT ) )
            int alt19 = 2;
            int LA19_0 = input.LA(1);

            if ( (LA19_0 == ID || (LA19_0 >= 59 && LA19_0 <= 62)) )
            {
                int LA19_1 = input.LA(2);

                if ( (LA19_1 == RBR || (LA19_1 >= RBRR && LA19_1 <= EQU) || LA19_1 == ID || LA19_1 == 51 || (LA19_1 >= 59 && LA19_1 <= 62)) )
                {
                    alt19 = 1;
                }
                else if ( (LA19_1 == INT) )
                {
                    alt19 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d19s1 =
                        new NoViableAltException("", 19, 1, input);

                    throw nvae_d19s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d19s0 =
                    new NoViableAltException("", 19, 0, input);

                throw nvae_d19s0;
            }
            switch (alt19) 
            {
                case 1 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:146:4: edgeop ( edgeop )*
                    {
                    	PushFollow(FOLLOW_edgeop_in_idd740);
                    	edgeop53 = edgeop();
                    	state.followingStackPointer--;

                    	stream_edgeop.Add(edgeop53.Tree);
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:146:11: ( edgeop )*
                    	do 
                    	{
                    	    int alt18 = 2;
                    	    int LA18_0 = input.LA(1);

                    	    if ( (LA18_0 == ID || (LA18_0 >= 59 && LA18_0 <= 62)) )
                    	    {
                    	        alt18 = 1;
                    	    }


                    	    switch (alt18) 
                    		{
                    			case 1 :
                    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:146:12: edgeop
                    			    {
                    			    	PushFollow(FOLLOW_edgeop_in_idd743);
                    			    	edgeop54 = edgeop();
                    			    	state.followingStackPointer--;

                    			    	stream_edgeop.Add(edgeop54.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop18;
                    	    }
                    	} while (true);

                    	loop18:
                    		;	// Stops C# compiler whining that label 'loop18' has no statements



                    	// AST REWRITE
                    	// elements:          edgeop
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 146:21: -> ^( IM_ID ( edgeop )* )
                    	{
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:146:24: ^( IM_ID ( edgeop )* )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ID, "IM_ID"), root_1);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:146:32: ( edgeop )*
                    	    while ( stream_edgeop.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_edgeop.NextTree());

                    	    }
                    	    stream_edgeop.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:147:4: edgeop INT
                    {
                    	PushFollow(FOLLOW_edgeop_in_idd759);
                    	edgeop55 = edgeop();
                    	state.followingStackPointer--;

                    	stream_edgeop.Add(edgeop55.Tree);
                    	INT56=(IToken)Match(input,INT,FOLLOW_INT_in_idd761);  
                    	stream_INT.Add(INT56);



                    	// AST REWRITE
                    	// elements:          edgeop, INT
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 147:16: -> ^( IM_ID edgeop INT )
                    	{
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:147:19: ^( IM_ID edgeop INT )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ID, "IM_ID"), root_1);

                    	    adaptor.AddChild(root_1, stream_edgeop.NextTree());
                    	    adaptor.AddChild(root_1, stream_INT.NextNode());

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:153:1: numberunit : number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) ;
    public simpletikzParser.numberunit_return numberunit() // throws RecognitionException [1]
    {   
        simpletikzParser.numberunit_return retval = new simpletikzParser.numberunit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.number_return number57 = default(simpletikzParser.number_return);

        simpletikzParser.unit_return unit58 = default(simpletikzParser.unit_return);


        RewriteRuleSubtreeStream stream_unit = new RewriteRuleSubtreeStream(adaptor,"rule unit");
        RewriteRuleSubtreeStream stream_number = new RewriteRuleSubtreeStream(adaptor,"rule number");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:154:2: ( number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:154:4: number ( unit )?
            {
            	PushFollow(FOLLOW_number_in_numberunit790);
            	number57 = number();
            	state.followingStackPointer--;

            	stream_number.Add(number57.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:154:11: ( unit )?
            	int alt20 = 2;
            	int LA20_0 = input.LA(1);

            	if ( ((LA20_0 >= 52 && LA20_0 <= 57)) )
            	{
            	    alt20 = 1;
            	}
            	switch (alt20) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:154:11: unit
            	        {
            	        	PushFollow(FOLLOW_unit_in_numberunit792);
            	        	unit58 = unit();
            	        	state.followingStackPointer--;

            	        	stream_unit.Add(unit58.Tree);

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
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 154:17: -> ^( IM_NUMBERUNIT number ( unit )? )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:154:20: ^( IM_NUMBERUNIT number ( unit )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NUMBERUNIT, "IM_NUMBERUNIT"), root_1);

            	    adaptor.AddChild(root_1, stream_number.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:154:43: ( unit )?
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:158:1: number : ( FLOAT_WO_EXP | INT ) ;
    public simpletikzParser.number_return number() // throws RecognitionException [1]
    {   
        simpletikzParser.number_return retval = new simpletikzParser.number_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set59 = null;

        object set59_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:159:2: ( ( FLOAT_WO_EXP | INT ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:159:4: ( FLOAT_WO_EXP | INT )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set59 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= INT && input.LA(1) <= FLOAT_WO_EXP) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set59));
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:162:1: unit : ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' | 'em' );
    public simpletikzParser.unit_return unit() // throws RecognitionException [1]
    {   
        simpletikzParser.unit_return retval = new simpletikzParser.unit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set60 = null;

        object set60_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:163:2: ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' | 'em' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set60 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 52 && input.LA(1) <= 57) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set60));
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:166:1: tikz_set : tikz_set_start ( option ( ',' option )* )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) ;
    public simpletikzParser.tikz_set_return tikz_set() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_set_return retval = new simpletikzParser.tikz_set_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal63 = null;
        simpletikzParser.tikz_set_start_return tikz_set_start61 = default(simpletikzParser.tikz_set_start_return);

        simpletikzParser.option_return option62 = default(simpletikzParser.option_return);

        simpletikzParser.option_return option64 = default(simpletikzParser.option_return);

        simpletikzParser.roundbr_end_return roundbr_end65 = default(simpletikzParser.roundbr_end_return);


        object char_literal63_tree=null;
        RewriteRuleTokenStream stream_KOMMA = new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_tikz_set_start = new RewriteRuleSubtreeStream(adaptor,"rule tikz_set_start");
        RewriteRuleSubtreeStream stream_roundbr_end = new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        RewriteRuleSubtreeStream stream_option = new RewriteRuleSubtreeStream(adaptor,"rule option");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:167:2: ( tikz_set_start ( option ( ',' option )* )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:167:5: tikz_set_start ( option ( ',' option )* )? roundbr_end
            {
            	PushFollow(FOLLOW_tikz_set_start_in_tikz_set873);
            	tikz_set_start61 = tikz_set_start();
            	state.followingStackPointer--;

            	stream_tikz_set_start.Add(tikz_set_start61.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:167:20: ( option ( ',' option )* )?
            	int alt22 = 2;
            	int LA22_0 = input.LA(1);

            	if ( (LA22_0 == ID || (LA22_0 >= 59 && LA22_0 <= 62)) )
            	{
            	    alt22 = 1;
            	}
            	switch (alt22) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:167:21: option ( ',' option )*
            	        {
            	        	PushFollow(FOLLOW_option_in_tikz_set876);
            	        	option62 = option();
            	        	state.followingStackPointer--;

            	        	stream_option.Add(option62.Tree);
            	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:167:28: ( ',' option )*
            	        	do 
            	        	{
            	        	    int alt21 = 2;
            	        	    int LA21_0 = input.LA(1);

            	        	    if ( (LA21_0 == KOMMA) )
            	        	    {
            	        	        alt21 = 1;
            	        	    }


            	        	    switch (alt21) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:167:29: ',' option
            	        			    {
            	        			    	char_literal63=(IToken)Match(input,KOMMA,FOLLOW_KOMMA_in_tikz_set879);  
            	        			    	stream_KOMMA.Add(char_literal63);

            	        			    	PushFollow(FOLLOW_option_in_tikz_set881);
            	        			    	option64 = option();
            	        			    	state.followingStackPointer--;

            	        			    	stream_option.Add(option64.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop21;
            	        	    }
            	        	} while (true);

            	        	loop21:
            	        		;	// Stops C# compiler whining that label 'loop21' has no statements


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_roundbr_end_in_tikz_set887);
            	roundbr_end65 = roundbr_end();
            	state.followingStackPointer--;

            	stream_roundbr_end.Add(roundbr_end65.Tree);


            	// AST REWRITE
            	// elements:          option, tikz_set_start, roundbr_end
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 167:56: -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:167:59: ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_TIKZSET, "IM_TIKZSET"), root_1);

            	    adaptor.AddChild(root_1, stream_tikz_set_start.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:167:87: ( option )*
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:172:1: tikzpicture : tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) ;
    public simpletikzParser.tikzpicture_return tikzpicture() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_return retval = new simpletikzParser.tikzpicture_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzpicture_start_return tikzpicture_start66 = default(simpletikzParser.tikzpicture_start_return);

        simpletikzParser.tikz_options_return tikz_options67 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody_return tikzbody68 = default(simpletikzParser.tikzbody_return);

        simpletikzParser.tikzpicture_end_return tikzpicture_end69 = default(simpletikzParser.tikzpicture_end_return);


        RewriteRuleSubtreeStream stream_tikzpicture_end = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_end");
        RewriteRuleSubtreeStream stream_tikzpicture_start = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_start");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:173:2: ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:173:5: tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end
            {
            	PushFollow(FOLLOW_tikzpicture_start_in_tikzpicture915);
            	tikzpicture_start66 = tikzpicture_start();
            	state.followingStackPointer--;

            	stream_tikzpicture_start.Add(tikzpicture_start66.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:173:23: ( tikz_options )?
            	int alt23 = 2;
            	int LA23_0 = input.LA(1);

            	if ( (LA23_0 == LBR) )
            	{
            	    alt23 = 1;
            	}
            	switch (alt23) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:173:23: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_tikzpicture917);
            	        	tikz_options67 = tikz_options();
            	        	state.followingStackPointer--;

            	        	stream_tikz_options.Add(tikz_options67.Tree);

            	        }
            	        break;

            	}

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:173:37: ( tikzbody )?
            	int alt24 = 2;
            	int LA24_0 = input.LA(1);

            	if ( (LA24_0 == BEGIN || (LA24_0 >= USETIKZLIB && LA24_0 <= RPAR) || (LA24_0 >= RBR && LA24_0 <= 66)) )
            	{
            	    alt24 = 1;
            	}
            	else if ( (LA24_0 == END) )
            	{
            	    int LA24_2 = input.LA(2);

            	    if ( (LA24_2 == LBRR) )
            	    {
            	        int LA24_3 = input.LA(3);

            	        if ( (LA24_3 == ID || (LA24_3 >= 59 && LA24_3 <= 62)) )
            	        {
            	            alt24 = 1;
            	        }
            	    }
            	}
            	switch (alt24) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:173:37: tikzbody
            	        {
            	        	PushFollow(FOLLOW_tikzbody_in_tikzpicture920);
            	        	tikzbody68 = tikzbody();
            	        	state.followingStackPointer--;

            	        	stream_tikzbody.Add(tikzbody68.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzpicture_end_in_tikzpicture923);
            	tikzpicture_end69 = tikzpicture_end();
            	state.followingStackPointer--;

            	stream_tikzpicture_end.Add(tikzpicture_end69.Tree);


            	// AST REWRITE
            	// elements:          tikz_options, tikzbody, tikzpicture_end, tikzpicture_start
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 173:64: -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:173:67: ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PICTURE, "IM_PICTURE"), root_1);

            	    adaptor.AddChild(root_1, stream_tikzpicture_start.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:173:98: ( tikz_options )?
            	    if ( stream_tikz_options.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikz_options.NextTree());

            	    }
            	    stream_tikz_options.Reset();
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:173:112: ( tikzbody )?
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:176:1: tikzbody : ( tikzscope | tikzpath | tikznodee | dontcare_body_nobr | tikz_set | tikz_style | otherbegin | otherend ) ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )* ;
    public simpletikzParser.tikzbody_return tikzbody() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzbody_return retval = new simpletikzParser.tikzbody_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_return tikzscope70 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath71 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznodee_return tikznodee72 = default(simpletikzParser.tikznodee_return);

        simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr73 = default(simpletikzParser.dontcare_body_nobr_return);

        simpletikzParser.tikz_set_return tikz_set74 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style75 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin76 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend77 = default(simpletikzParser.otherend_return);

        simpletikzParser.tikzscope_return tikzscope78 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath79 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznodee_return tikznodee80 = default(simpletikzParser.tikznodee_return);

        simpletikzParser.dontcare_body_return dontcare_body81 = default(simpletikzParser.dontcare_body_return);

        simpletikzParser.tikz_set_return tikz_set82 = default(simpletikzParser.tikz_set_return);

        simpletikzParser.tikz_style_return tikz_style83 = default(simpletikzParser.tikz_style_return);

        simpletikzParser.otherbegin_return otherbegin84 = default(simpletikzParser.otherbegin_return);

        simpletikzParser.otherend_return otherend85 = default(simpletikzParser.otherend_return);



        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:177:2: ( ( tikzscope | tikzpath | tikznodee | dontcare_body_nobr | tikz_set | tikz_style | otherbegin | otherend ) ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )* )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:177:4: ( tikzscope | tikzpath | tikznodee | dontcare_body_nobr | tikz_set | tikz_style | otherbegin | otherend ) ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:177:4: ( tikzscope | tikzpath | tikznodee | dontcare_body_nobr | tikz_set | tikz_style | otherbegin | otherend )
            	int alt25 = 8;
            	alt25 = dfa25.Predict(input);
            	switch (alt25) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:177:6: tikzscope
            	        {
            	        	PushFollow(FOLLOW_tikzscope_in_tikzbody953);
            	        	tikzscope70 = tikzscope();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, tikzscope70.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:177:18: tikzpath
            	        {
            	        	PushFollow(FOLLOW_tikzpath_in_tikzbody957);
            	        	tikzpath71 = tikzpath();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, tikzpath71.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:177:29: tikznodee
            	        {
            	        	PushFollow(FOLLOW_tikznodee_in_tikzbody961);
            	        	tikznodee72 = tikznodee();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, tikznodee72.Tree);

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:177:41: dontcare_body_nobr
            	        {
            	        	PushFollow(FOLLOW_dontcare_body_nobr_in_tikzbody965);
            	        	dontcare_body_nobr73 = dontcare_body_nobr();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, dontcare_body_nobr73.Tree);

            	        }
            	        break;
            	    case 5 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:177:62: tikz_set
            	        {
            	        	PushFollow(FOLLOW_tikz_set_in_tikzbody969);
            	        	tikz_set74 = tikz_set();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, tikz_set74.Tree);

            	        }
            	        break;
            	    case 6 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:177:73: tikz_style
            	        {
            	        	PushFollow(FOLLOW_tikz_style_in_tikzbody973);
            	        	tikz_style75 = tikz_style();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, tikz_style75.Tree);

            	        }
            	        break;
            	    case 7 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:177:86: otherbegin
            	        {
            	        	PushFollow(FOLLOW_otherbegin_in_tikzbody977);
            	        	otherbegin76 = otherbegin();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, otherbegin76.Tree);

            	        }
            	        break;
            	    case 8 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:177:98: otherend
            	        {
            	        	PushFollow(FOLLOW_otherend_in_tikzbody980);
            	        	otherend77 = otherend();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, otherend77.Tree);

            	        }
            	        break;

            	}

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:178:3: ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )*
            	do 
            	{
            	    int alt26 = 9;
            	    alt26 = dfa26.Predict(input);
            	    switch (alt26) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:178:5: tikzscope
            			    {
            			    	PushFollow(FOLLOW_tikzscope_in_tikzbody990);
            			    	tikzscope78 = tikzscope();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, tikzscope78.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:178:17: tikzpath
            			    {
            			    	PushFollow(FOLLOW_tikzpath_in_tikzbody994);
            			    	tikzpath79 = tikzpath();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, tikzpath79.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:178:28: tikznodee
            			    {
            			    	PushFollow(FOLLOW_tikznodee_in_tikzbody998);
            			    	tikznodee80 = tikznodee();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, tikznodee80.Tree);

            			    }
            			    break;
            			case 4 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:178:40: dontcare_body
            			    {
            			    	PushFollow(FOLLOW_dontcare_body_in_tikzbody1002);
            			    	dontcare_body81 = dontcare_body();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, dontcare_body81.Tree);

            			    }
            			    break;
            			case 5 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:178:56: tikz_set
            			    {
            			    	PushFollow(FOLLOW_tikz_set_in_tikzbody1006);
            			    	tikz_set82 = tikz_set();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, tikz_set82.Tree);

            			    }
            			    break;
            			case 6 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:178:67: tikz_style
            			    {
            			    	PushFollow(FOLLOW_tikz_style_in_tikzbody1010);
            			    	tikz_style83 = tikz_style();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, tikz_style83.Tree);

            			    }
            			    break;
            			case 7 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:178:80: otherbegin
            			    {
            			    	PushFollow(FOLLOW_otherbegin_in_tikzbody1014);
            			    	otherbegin84 = otherbegin();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, otherbegin84.Tree);

            			    }
            			    break;
            			case 8 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:178:92: otherend
            			    {
            			    	PushFollow(FOLLOW_otherend_in_tikzbody1017);
            			    	otherend85 = otherend();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, otherend85.Tree);

            			    }
            			    break;

            			default:
            			    goto loop26;
            	    }
            	} while (true);

            	loop26:
            		;	// Stops C# compiler whining that label 'loop26' has no statements


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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:181:1: dontcare_body_nobr : (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET | LBR ) ) ;
    public simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body_nobr_return retval = new simpletikzParser.dontcare_body_nobr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set86 = null;

        object set86_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:182:2: ( (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET | LBR ) ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:182:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET | LBR ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:182:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET | LBR ) )
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:182:5: ~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET | LBR )
            	{
            		set86 = (IToken)input.LT(1);
            		if ( input.LA(1) == USETIKZLIB || (input.LA(1) >= LPAR && input.LA(1) <= RPAR) || (input.LA(1) >= RBR && input.LA(1) <= 66) ) 
            		{
            		    input.Consume();
            		    adaptor.AddChild(root_0, (object)adaptor.Create(set86));
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:184:1: dontcare_body : (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET ) ) ;
    public simpletikzParser.dontcare_body_return dontcare_body() // throws RecognitionException [1]
    {   
        simpletikzParser.dontcare_body_return retval = new simpletikzParser.dontcare_body_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set87 = null;

        object set87_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:185:2: ( (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET ) ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:185:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:185:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET ) )
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:185:5: ~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET )
            	{
            		set87 = (IToken)input.LT(1);
            		if ( input.LA(1) == USETIKZLIB || (input.LA(1) >= LPAR && input.LA(1) <= 66) ) 
            		{
            		    input.Consume();
            		    adaptor.AddChild(root_0, (object)adaptor.Create(set87));
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:187:1: otherend : END '{' idd '}' ;
    public simpletikzParser.otherend_return otherend() // throws RecognitionException [1]
    {   
        simpletikzParser.otherend_return retval = new simpletikzParser.otherend_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken END88 = null;
        IToken char_literal89 = null;
        IToken char_literal91 = null;
        simpletikzParser.idd_return idd90 = default(simpletikzParser.idd_return);


        object END88_tree=null;
        object char_literal89_tree=null;
        object char_literal91_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:188:2: ( END '{' idd '}' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:188:4: END '{' idd '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	END88=(IToken)Match(input,END,FOLLOW_END_in_otherend1127); 
            		END88_tree = (object)adaptor.Create(END88);
            		adaptor.AddChild(root_0, END88_tree);

            	char_literal89=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_otherend1129); 
            		char_literal89_tree = (object)adaptor.Create(char_literal89);
            		adaptor.AddChild(root_0, char_literal89_tree);

            	PushFollow(FOLLOW_idd_in_otherend1131);
            	idd90 = idd();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, idd90.Tree);
            	char_literal91=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_otherend1133); 
            		char_literal91_tree = (object)adaptor.Create(char_literal91);
            		adaptor.AddChild(root_0, char_literal91_tree);


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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:191:1: tikzpath : path_start ( tikz_options )? tikzpathi semicolon_end -> ^( IM_PATH path_start ( tikz_options )? tikzpathi semicolon_end ) ;
    public simpletikzParser.tikzpath_return tikzpath() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_return retval = new simpletikzParser.tikzpath_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.path_start_return path_start92 = default(simpletikzParser.path_start_return);

        simpletikzParser.tikz_options_return tikz_options93 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzpathi_return tikzpathi94 = default(simpletikzParser.tikzpathi_return);

        simpletikzParser.semicolon_end_return semicolon_end95 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_path_start = new RewriteRuleSubtreeStream(adaptor,"rule path_start");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        RewriteRuleSubtreeStream stream_tikzpathi = new RewriteRuleSubtreeStream(adaptor,"rule tikzpathi");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:192:2: ( path_start ( tikz_options )? tikzpathi semicolon_end -> ^( IM_PATH path_start ( tikz_options )? tikzpathi semicolon_end ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:192:4: path_start ( tikz_options )? tikzpathi semicolon_end
            {
            	PushFollow(FOLLOW_path_start_in_tikzpath1146);
            	path_start92 = path_start();
            	state.followingStackPointer--;

            	stream_path_start.Add(path_start92.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:192:15: ( tikz_options )?
            	int alt27 = 2;
            	int LA27_0 = input.LA(1);

            	if ( (LA27_0 == LBR) )
            	{
            	    alt27 = 1;
            	}
            	switch (alt27) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:192:15: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_tikzpath1148);
            	        	tikz_options93 = tikz_options();
            	        	state.followingStackPointer--;

            	        	stream_tikz_options.Add(tikz_options93.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzpathi_in_tikzpath1151);
            	tikzpathi94 = tikzpathi();
            	state.followingStackPointer--;

            	stream_tikzpathi.Add(tikzpathi94.Tree);
            	PushFollow(FOLLOW_semicolon_end_in_tikzpath1153);
            	semicolon_end95 = semicolon_end();
            	state.followingStackPointer--;

            	stream_semicolon_end.Add(semicolon_end95.Tree);


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
            	// 192:53: -> ^( IM_PATH path_start ( tikz_options )? tikzpathi semicolon_end )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:192:56: ^( IM_PATH path_start ( tikz_options )? tikzpathi semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_path_start.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:192:77: ( tikz_options )?
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:197:1: tikzpathi : coordornode_new ( edgeop coordornode_new )* ;
    public simpletikzParser.tikzpathi_return tikzpathi() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpathi_return retval = new simpletikzParser.tikzpathi_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.coordornode_new_return coordornode_new96 = default(simpletikzParser.coordornode_new_return);

        simpletikzParser.edgeop_return edgeop97 = default(simpletikzParser.edgeop_return);

        simpletikzParser.coordornode_new_return coordornode_new98 = default(simpletikzParser.coordornode_new_return);



        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:198:2: ( coordornode_new ( edgeop coordornode_new )* )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:198:4: coordornode_new ( edgeop coordornode_new )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_coordornode_new_in_tikzpathi1184);
            	coordornode_new96 = coordornode_new();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, coordornode_new96.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:198:20: ( edgeop coordornode_new )*
            	do 
            	{
            	    int alt28 = 2;
            	    int LA28_0 = input.LA(1);

            	    if ( (LA28_0 == ID || (LA28_0 >= 59 && LA28_0 <= 62)) )
            	    {
            	        alt28 = 1;
            	    }


            	    switch (alt28) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:198:21: edgeop coordornode_new
            			    {
            			    	PushFollow(FOLLOW_edgeop_in_tikzpathi1187);
            			    	edgeop97 = edgeop();
            			    	state.followingStackPointer--;

            			    	PushFollow(FOLLOW_coordornode_new_in_tikzpathi1190);
            			    	coordornode_new98 = coordornode_new();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, coordornode_new98.Tree);

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:203:1: tikzscope : tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end ) ;
    public simpletikzParser.tikzscope_return tikzscope() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_return retval = new simpletikzParser.tikzscope_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_start_return tikzscope_start99 = default(simpletikzParser.tikzscope_start_return);

        simpletikzParser.tikz_options_return tikz_options100 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody_return tikzbody101 = default(simpletikzParser.tikzbody_return);

        simpletikzParser.tikzscope_end_return tikzscope_end102 = default(simpletikzParser.tikzscope_end_return);


        RewriteRuleSubtreeStream stream_tikzscope_start = new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_start");
        RewriteRuleSubtreeStream stream_tikzscope_end = new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_end");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:204:2: ( tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:204:4: tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end
            {
            	PushFollow(FOLLOW_tikzscope_start_in_tikzscope1207);
            	tikzscope_start99 = tikzscope_start();
            	state.followingStackPointer--;

            	stream_tikzscope_start.Add(tikzscope_start99.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:204:20: ( tikz_options )?
            	int alt29 = 2;
            	int LA29_0 = input.LA(1);

            	if ( (LA29_0 == LBR) )
            	{
            	    alt29 = 1;
            	}
            	switch (alt29) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:204:20: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_tikzscope1209);
            	        	tikz_options100 = tikz_options();
            	        	state.followingStackPointer--;

            	        	stream_tikz_options.Add(tikz_options100.Tree);

            	        }
            	        break;

            	}

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:204:34: ( tikzbody )?
            	int alt30 = 2;
            	int LA30_0 = input.LA(1);

            	if ( (LA30_0 == BEGIN || (LA30_0 >= USETIKZLIB && LA30_0 <= RPAR) || (LA30_0 >= RBR && LA30_0 <= 66)) )
            	{
            	    alt30 = 1;
            	}
            	else if ( (LA30_0 == END) )
            	{
            	    int LA30_2 = input.LA(2);

            	    if ( (LA30_2 == LBRR) )
            	    {
            	        int LA30_3 = input.LA(3);

            	        if ( (LA30_3 == ID || (LA30_3 >= 59 && LA30_3 <= 62)) )
            	        {
            	            alt30 = 1;
            	        }
            	    }
            	}
            	switch (alt30) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:204:34: tikzbody
            	        {
            	        	PushFollow(FOLLOW_tikzbody_in_tikzscope1212);
            	        	tikzbody101 = tikzbody();
            	        	state.followingStackPointer--;

            	        	stream_tikzbody.Add(tikzbody101.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzscope_end_in_tikzscope1215);
            	tikzscope_end102 = tikzscope_end();
            	state.followingStackPointer--;

            	stream_tikzscope_end.Add(tikzscope_end102.Tree);


            	// AST REWRITE
            	// elements:          tikz_options, tikzbody, tikzscope_end, tikzscope_start
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 204:59: -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:204:62: ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_SCOPE, "IM_SCOPE"), root_1);

            	    adaptor.AddChild(root_1, stream_tikzscope_start.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:204:89: ( tikz_options )?
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:208:1: coordornode : ( coord | size | tikznodei );
    public simpletikzParser.coordornode_return coordornode() // throws RecognitionException [1]
    {   
        simpletikzParser.coordornode_return retval = new simpletikzParser.coordornode_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.coord_return coord103 = default(simpletikzParser.coord_return);

        simpletikzParser.size_return size104 = default(simpletikzParser.size_return);

        simpletikzParser.tikznodei_return tikznodei105 = default(simpletikzParser.tikznodei_return);



        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:209:2: ( coord | size | tikznodei )
            int alt31 = 3;
            switch ( input.LA(1) ) 
            {
            case LPAR:
            	{
                int LA31_1 = input.LA(2);

                if ( (LA31_1 == ID) )
                {
                    alt31 = 1;
                }
                else if ( ((LA31_1 >= INT && LA31_1 <= FLOAT_WO_EXP)) )
                {
                    switch ( input.LA(3) ) 
                    {
                    case 52:
                    case 53:
                    case 54:
                    case 55:
                    case 56:
                    case 57:
                    	{
                        int LA31_7 = input.LA(4);

                        if ( (LA31_7 == RPAR) )
                        {
                            alt31 = 2;
                        }
                        else if ( (LA31_7 == KOMMA || LA31_7 == COLON) )
                        {
                            alt31 = 1;
                        }
                        else 
                        {
                            NoViableAltException nvae_d31s7 =
                                new NoViableAltException("", 31, 7, input);

                            throw nvae_d31s7;
                        }
                        }
                        break;
                    case RPAR:
                    	{
                        alt31 = 2;
                        }
                        break;
                    case KOMMA:
                    case COLON:
                    	{
                        alt31 = 1;
                        }
                        break;
                    	default:
                    	    NoViableAltException nvae_d31s5 =
                    	        new NoViableAltException("", 31, 5, input);

                    	    throw nvae_d31s5;
                    }

                }
                else 
                {
                    NoViableAltException nvae_d31s1 =
                        new NoViableAltException("", 31, 1, input);

                    throw nvae_d31s1;
                }
                }
                break;
            case 63:
            case 64:
            	{
                int LA31_2 = input.LA(2);

                if ( (LA31_2 == LPAR) )
                {
                    int LA31_6 = input.LA(3);

                    if ( ((LA31_6 >= INT && LA31_6 <= FLOAT_WO_EXP)) )
                    {
                        switch ( input.LA(4) ) 
                        {
                        case 52:
                        case 53:
                        case 54:
                        case 55:
                        case 56:
                        case 57:
                        	{
                            int LA31_7 = input.LA(5);

                            if ( (LA31_7 == RPAR) )
                            {
                                alt31 = 2;
                            }
                            else if ( (LA31_7 == KOMMA || LA31_7 == COLON) )
                            {
                                alt31 = 1;
                            }
                            else 
                            {
                                NoViableAltException nvae_d31s7 =
                                    new NoViableAltException("", 31, 7, input);

                                throw nvae_d31s7;
                            }
                            }
                            break;
                        case RPAR:
                        	{
                            alt31 = 2;
                            }
                            break;
                        case KOMMA:
                        case COLON:
                        	{
                            alt31 = 1;
                            }
                            break;
                        	default:
                        	    NoViableAltException nvae_d31s5 =
                        	        new NoViableAltException("", 31, 5, input);

                        	    throw nvae_d31s5;
                        }

                    }
                    else 
                    {
                        NoViableAltException nvae_d31s6 =
                            new NoViableAltException("", 31, 6, input);

                        throw nvae_d31s6;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d31s2 =
                        new NoViableAltException("", 31, 2, input);

                    throw nvae_d31s2;
                }
                }
                break;
            case NODE:
            	{
                alt31 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d31s0 =
            	        new NoViableAltException("", 31, 0, input);

            	    throw nvae_d31s0;
            }

            switch (alt31) 
            {
                case 1 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:209:4: coord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_coord_in_coordornode1243);
                    	coord103 = coord();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, coord103.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:209:12: size
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_size_in_coordornode1247);
                    	size104 = size();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, size104.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:209:19: tikznodei
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikznodei_in_coordornode1251);
                    	tikznodei105 = tikznodei();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, tikznodei105.Tree);

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

    public class coordornode_new_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "coordornode_new"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:216:1: coordornode_new : ( coord ( ID ( nodetype )? ( tikzstring )? )? | size );
    public simpletikzParser.coordornode_new_return coordornode_new() // throws RecognitionException [1]
    {   
        simpletikzParser.coordornode_new_return retval = new simpletikzParser.coordornode_new_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID107 = null;
        simpletikzParser.coord_return coord106 = default(simpletikzParser.coord_return);

        simpletikzParser.nodetype_return nodetype108 = default(simpletikzParser.nodetype_return);

        simpletikzParser.tikzstring_return tikzstring109 = default(simpletikzParser.tikzstring_return);

        simpletikzParser.size_return size110 = default(simpletikzParser.size_return);


        object ID107_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:217:2: ( coord ( ID ( nodetype )? ( tikzstring )? )? | size )
            int alt35 = 2;
            int LA35_0 = input.LA(1);

            if ( (LA35_0 == LPAR) )
            {
                int LA35_1 = input.LA(2);

                if ( (LA35_1 == ID) )
                {
                    alt35 = 1;
                }
                else if ( ((LA35_1 >= INT && LA35_1 <= FLOAT_WO_EXP)) )
                {
                    switch ( input.LA(3) ) 
                    {
                    case 52:
                    case 53:
                    case 54:
                    case 55:
                    case 56:
                    case 57:
                    	{
                        int LA35_6 = input.LA(4);

                        if ( (LA35_6 == RPAR) )
                        {
                            alt35 = 2;
                        }
                        else if ( (LA35_6 == KOMMA || LA35_6 == COLON) )
                        {
                            alt35 = 1;
                        }
                        else 
                        {
                            NoViableAltException nvae_d35s6 =
                                new NoViableAltException("", 35, 6, input);

                            throw nvae_d35s6;
                        }
                        }
                        break;
                    case RPAR:
                    	{
                        alt35 = 2;
                        }
                        break;
                    case KOMMA:
                    case COLON:
                    	{
                        alt35 = 1;
                        }
                        break;
                    	default:
                    	    NoViableAltException nvae_d35s4 =
                    	        new NoViableAltException("", 35, 4, input);

                    	    throw nvae_d35s4;
                    }

                }
                else 
                {
                    NoViableAltException nvae_d35s1 =
                        new NoViableAltException("", 35, 1, input);

                    throw nvae_d35s1;
                }
            }
            else if ( ((LA35_0 >= 63 && LA35_0 <= 64)) )
            {
                int LA35_2 = input.LA(2);

                if ( (LA35_2 == LPAR) )
                {
                    int LA35_5 = input.LA(3);

                    if ( ((LA35_5 >= INT && LA35_5 <= FLOAT_WO_EXP)) )
                    {
                        switch ( input.LA(4) ) 
                        {
                        case 52:
                        case 53:
                        case 54:
                        case 55:
                        case 56:
                        case 57:
                        	{
                            int LA35_6 = input.LA(5);

                            if ( (LA35_6 == RPAR) )
                            {
                                alt35 = 2;
                            }
                            else if ( (LA35_6 == KOMMA || LA35_6 == COLON) )
                            {
                                alt35 = 1;
                            }
                            else 
                            {
                                NoViableAltException nvae_d35s6 =
                                    new NoViableAltException("", 35, 6, input);

                                throw nvae_d35s6;
                            }
                            }
                            break;
                        case RPAR:
                        	{
                            alt35 = 2;
                            }
                            break;
                        case KOMMA:
                        case COLON:
                        	{
                            alt35 = 1;
                            }
                            break;
                        	default:
                        	    NoViableAltException nvae_d35s4 =
                        	        new NoViableAltException("", 35, 4, input);

                        	    throw nvae_d35s4;
                        }

                    }
                    else 
                    {
                        NoViableAltException nvae_d35s5 =
                            new NoViableAltException("", 35, 5, input);

                        throw nvae_d35s5;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d35s2 =
                        new NoViableAltException("", 35, 2, input);

                    throw nvae_d35s2;
                }
            }
            else 
            {
                NoViableAltException nvae_d35s0 =
                    new NoViableAltException("", 35, 0, input);

                throw nvae_d35s0;
            }
            switch (alt35) 
            {
                case 1 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:217:4: coord ( ID ( nodetype )? ( tikzstring )? )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_coord_in_coordornode_new1268);
                    	coord106 = coord();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, coord106.Tree);
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:217:10: ( ID ( nodetype )? ( tikzstring )? )?
                    	int alt34 = 2;
                    	int LA34_0 = input.LA(1);

                    	if ( (LA34_0 == ID) )
                    	{
                    	    int LA34_1 = input.LA(2);

                    	    if ( (LA34_1 == LBR || LA34_1 == LBRR || LA34_1 == SEMIC || LA34_1 == ID || (LA34_1 >= 59 && LA34_1 <= 62)) )
                    	    {
                    	        alt34 = 1;
                    	    }
                    	}
                    	switch (alt34) 
                    	{
                    	    case 1 :
                    	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:217:11: ID ( nodetype )? ( tikzstring )?
                    	        {
                    	        	ID107=(IToken)Match(input,ID,FOLLOW_ID_in_coordornode_new1271); 
                    	        		ID107_tree = (object)adaptor.Create(ID107);
                    	        		adaptor.AddChild(root_0, ID107_tree);

                    	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:217:14: ( nodetype )?
                    	        	int alt32 = 2;
                    	        	int LA32_0 = input.LA(1);

                    	        	if ( (LA32_0 == LBR) )
                    	        	{
                    	        	    alt32 = 1;
                    	        	}
                    	        	switch (alt32) 
                    	        	{
                    	        	    case 1 :
                    	        	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:217:15: nodetype
                    	        	        {
                    	        	        	PushFollow(FOLLOW_nodetype_in_coordornode_new1274);
                    	        	        	nodetype108 = nodetype();
                    	        	        	state.followingStackPointer--;

                    	        	        	adaptor.AddChild(root_0, nodetype108.Tree);

                    	        	        }
                    	        	        break;

                    	        	}

                    	        	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:217:26: ( tikzstring )?
                    	        	int alt33 = 2;
                    	        	int LA33_0 = input.LA(1);

                    	        	if ( (LA33_0 == LBRR) )
                    	        	{
                    	        	    alt33 = 1;
                    	        	}
                    	        	switch (alt33) 
                    	        	{
                    	        	    case 1 :
                    	        	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:217:27: tikzstring
                    	        	        {
                    	        	        	PushFollow(FOLLOW_tikzstring_in_coordornode_new1279);
                    	        	        	tikzstring109 = tikzstring();
                    	        	        	state.followingStackPointer--;

                    	        	        	adaptor.AddChild(root_0, tikzstring109.Tree);

                    	        	        }
                    	        	        break;

                    	        	}


                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:218:4: size
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_size_in_coordornode_new1288);
                    	size110 = size();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, size110.Tree);

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
    // $ANTLR end "coordornode_new"

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:221:1: tikznodei : '\\\\node' tikznode ;
    public simpletikzParser.tikznodei_return tikznodei() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznodei_return retval = new simpletikzParser.tikznodei_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal111 = null;
        simpletikzParser.tikznode_return tikznode112 = default(simpletikzParser.tikznode_return);


        object string_literal111_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:222:2: ( '\\\\node' tikznode )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:222:4: '\\\\node' tikznode
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal111=(IToken)Match(input,NODE,FOLLOW_NODE_in_tikznodei1301); 
            	PushFollow(FOLLOW_tikznode_in_tikznodei1304);
            	tikznode112 = tikznode();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, tikznode112.Tree);

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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:225:1: nodename : LPAR id= ID RPAR -> ^( IM_NODENAME $id) ;
    public simpletikzParser.nodename_return nodename() // throws RecognitionException [1]
    {   
        simpletikzParser.nodename_return retval = new simpletikzParser.nodename_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken id = null;
        IToken LPAR113 = null;
        IToken RPAR114 = null;

        object id_tree=null;
        object LPAR113_tree=null;
        object RPAR114_tree=null;
        RewriteRuleTokenStream stream_RPAR = new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR = new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:226:2: ( LPAR id= ID RPAR -> ^( IM_NODENAME $id) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:226:4: LPAR id= ID RPAR
            {
            	LPAR113=(IToken)Match(input,LPAR,FOLLOW_LPAR_in_nodename1316);  
            	stream_LPAR.Add(LPAR113);

            	id=(IToken)Match(input,ID,FOLLOW_ID_in_nodename1320);  
            	stream_ID.Add(id);

            	RPAR114=(IToken)Match(input,RPAR,FOLLOW_RPAR_in_nodename1322);  
            	stream_RPAR.Add(RPAR114);



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
            	// 226:21: -> ^( IM_NODENAME $id)
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:226:24: ^( IM_NODENAME $id)
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:229:1: size : ( ( coord_modifier )? lc= LPAR numberunit RPAR ) ;
    public simpletikzParser.size_return size() // throws RecognitionException [1]
    {   
        simpletikzParser.size_return retval = new simpletikzParser.size_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken lc = null;
        IToken RPAR117 = null;
        simpletikzParser.coord_modifier_return coord_modifier115 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.numberunit_return numberunit116 = default(simpletikzParser.numberunit_return);


        object lc_tree=null;
        object RPAR117_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:230:2: ( ( ( coord_modifier )? lc= LPAR numberunit RPAR ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:230:6: ( ( coord_modifier )? lc= LPAR numberunit RPAR )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:230:6: ( ( coord_modifier )? lc= LPAR numberunit RPAR )
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:230:8: ( coord_modifier )? lc= LPAR numberunit RPAR
            	{
            		// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:230:8: ( coord_modifier )?
            		int alt36 = 2;
            		int LA36_0 = input.LA(1);

            		if ( ((LA36_0 >= 63 && LA36_0 <= 64)) )
            		{
            		    alt36 = 1;
            		}
            		switch (alt36) 
            		{
            		    case 1 :
            		        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:230:8: coord_modifier
            		        {
            		        	PushFollow(FOLLOW_coord_modifier_in_size1348);
            		        	coord_modifier115 = coord_modifier();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, coord_modifier115.Tree);

            		        }
            		        break;

            		}

            		lc=(IToken)Match(input,LPAR,FOLLOW_LPAR_in_size1353); 
            			lc_tree = (object)adaptor.Create(lc);
            			adaptor.AddChild(root_0, lc_tree);

            		PushFollow(FOLLOW_numberunit_in_size1355);
            		numberunit116 = numberunit();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, numberunit116.Tree);
            		RPAR117=(IToken)Match(input,RPAR,FOLLOW_RPAR_in_size1357); 
            			RPAR117_tree = (object)adaptor.Create(RPAR117);
            			adaptor.AddChild(root_0, RPAR117_tree);


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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:236:1: coord : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? lc= LPAR numberunit coord_sep numberunit RPAR ) -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ coord_sep ) );
    public simpletikzParser.coord_return coord() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_return retval = new simpletikzParser.coord_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken lc = null;
        IToken RPAR123 = null;
        simpletikzParser.nodename_return nodename118 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_modifier_return coord_modifier119 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.numberunit_return numberunit120 = default(simpletikzParser.numberunit_return);

        simpletikzParser.coord_sep_return coord_sep121 = default(simpletikzParser.coord_sep_return);

        simpletikzParser.numberunit_return numberunit122 = default(simpletikzParser.numberunit_return);


        object lc_tree=null;
        object RPAR123_tree=null;
        RewriteRuleTokenStream stream_RPAR = new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR = new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_coord_sep = new RewriteRuleSubtreeStream(adaptor,"rule coord_sep");
        RewriteRuleSubtreeStream stream_nodename = new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        RewriteRuleSubtreeStream stream_coord_modifier = new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:237:2: ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? lc= LPAR numberunit coord_sep numberunit RPAR ) -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ coord_sep ) )
            int alt38 = 2;
            int LA38_0 = input.LA(1);

            if ( (LA38_0 == LPAR) )
            {
                int LA38_1 = input.LA(2);

                if ( (LA38_1 == ID) )
                {
                    alt38 = 1;
                }
                else if ( ((LA38_1 >= INT && LA38_1 <= FLOAT_WO_EXP)) )
                {
                    alt38 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d38s1 =
                        new NoViableAltException("", 38, 1, input);

                    throw nvae_d38s1;
                }
            }
            else if ( ((LA38_0 >= 63 && LA38_0 <= 64)) )
            {
                alt38 = 2;
            }
            else 
            {
                NoViableAltException nvae_d38s0 =
                    new NoViableAltException("", 38, 0, input);

                throw nvae_d38s0;
            }
            switch (alt38) 
            {
                case 1 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:237:6: nodename
                    {
                    	PushFollow(FOLLOW_nodename_in_coord1379);
                    	nodename118 = nodename();
                    	state.followingStackPointer--;

                    	stream_nodename.Add(nodename118.Tree);


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
                    	// 237:23: -> ^( IM_COORD nodename )
                    	{
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:237:26: ^( IM_COORD nodename )
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
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:238:5: ( ( coord_modifier )? lc= LPAR numberunit coord_sep numberunit RPAR )
                    {
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:238:5: ( ( coord_modifier )? lc= LPAR numberunit coord_sep numberunit RPAR )
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:238:7: ( coord_modifier )? lc= LPAR numberunit coord_sep numberunit RPAR
                    	{
                    		// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:238:7: ( coord_modifier )?
                    		int alt37 = 2;
                    		int LA37_0 = input.LA(1);

                    		if ( ((LA37_0 >= 63 && LA37_0 <= 64)) )
                    		{
                    		    alt37 = 1;
                    		}
                    		switch (alt37) 
                    		{
                    		    case 1 :
                    		        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:238:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord1403);
                    		        	coord_modifier119 = coord_modifier();
                    		        	state.followingStackPointer--;

                    		        	stream_coord_modifier.Add(coord_modifier119.Tree);

                    		        }
                    		        break;

                    		}

                    		lc=(IToken)Match(input,LPAR,FOLLOW_LPAR_in_coord1408);  
                    		stream_LPAR.Add(lc);

                    		PushFollow(FOLLOW_numberunit_in_coord1410);
                    		numberunit120 = numberunit();
                    		state.followingStackPointer--;

                    		stream_numberunit.Add(numberunit120.Tree);
                    		PushFollow(FOLLOW_coord_sep_in_coord1412);
                    		coord_sep121 = coord_sep();
                    		state.followingStackPointer--;

                    		stream_coord_sep.Add(coord_sep121.Tree);
                    		PushFollow(FOLLOW_numberunit_in_coord1414);
                    		numberunit122 = numberunit();
                    		state.followingStackPointer--;

                    		stream_numberunit.Add(numberunit122.Tree);
                    		RPAR123=(IToken)Match(input,RPAR,FOLLOW_RPAR_in_coord1416);  
                    		stream_RPAR.Add(RPAR123);


                    	}



                    	// AST REWRITE
                    	// elements:          coord_modifier, numberunit, coord_sep
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 238:70: -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ coord_sep )
                    	{
                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:238:73: ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ coord_sep )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, lc), root_1);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:238:89: ( coord_modifier )?
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:240:1: coord_sep : ( ',' | ':' ) ;
    public simpletikzParser.coord_sep_return coord_sep() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_sep_return retval = new simpletikzParser.coord_sep_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set124 = null;

        object set124_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:241:2: ( ( ',' | ':' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:241:4: ( ',' | ':' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set124 = (IToken)input.LT(1);
            	if ( input.LA(1) == KOMMA || input.LA(1) == COLON ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set124));
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:244:1: tikznode : ( nodename )? ( 'at' coord )? ( nodetype )? tikzstring -> ^( IM_NODE ( nodename )? ( coord )? tikzstring ) ;
    public simpletikzParser.tikznode_return tikznode() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_return retval = new simpletikzParser.tikznode_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal126 = null;
        simpletikzParser.nodename_return nodename125 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_return coord127 = default(simpletikzParser.coord_return);

        simpletikzParser.nodetype_return nodetype128 = default(simpletikzParser.nodetype_return);

        simpletikzParser.tikzstring_return tikzstring129 = default(simpletikzParser.tikzstring_return);


        object string_literal126_tree=null;
        RewriteRuleTokenStream stream_58 = new RewriteRuleTokenStream(adaptor,"token 58");
        RewriteRuleSubtreeStream stream_coord = new RewriteRuleSubtreeStream(adaptor,"rule coord");
        RewriteRuleSubtreeStream stream_nodetype = new RewriteRuleSubtreeStream(adaptor,"rule nodetype");
        RewriteRuleSubtreeStream stream_tikzstring = new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_nodename = new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:245:2: ( ( nodename )? ( 'at' coord )? ( nodetype )? tikzstring -> ^( IM_NODE ( nodename )? ( coord )? tikzstring ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:245:4: ( nodename )? ( 'at' coord )? ( nodetype )? tikzstring
            {
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:245:4: ( nodename )?
            	int alt39 = 2;
            	int LA39_0 = input.LA(1);

            	if ( (LA39_0 == LPAR) )
            	{
            	    alt39 = 1;
            	}
            	switch (alt39) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:245:4: nodename
            	        {
            	        	PushFollow(FOLLOW_nodename_in_tikznode1463);
            	        	nodename125 = nodename();
            	        	state.followingStackPointer--;

            	        	stream_nodename.Add(nodename125.Tree);

            	        }
            	        break;

            	}

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:245:14: ( 'at' coord )?
            	int alt40 = 2;
            	int LA40_0 = input.LA(1);

            	if ( (LA40_0 == 58) )
            	{
            	    alt40 = 1;
            	}
            	switch (alt40) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:245:15: 'at' coord
            	        {
            	        	string_literal126=(IToken)Match(input,58,FOLLOW_58_in_tikznode1467);  
            	        	stream_58.Add(string_literal126);

            	        	PushFollow(FOLLOW_coord_in_tikznode1469);
            	        	coord127 = coord();
            	        	state.followingStackPointer--;

            	        	stream_coord.Add(coord127.Tree);

            	        }
            	        break;

            	}

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:245:28: ( nodetype )?
            	int alt41 = 2;
            	int LA41_0 = input.LA(1);

            	if ( (LA41_0 == LBR) )
            	{
            	    alt41 = 1;
            	}
            	switch (alt41) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:245:28: nodetype
            	        {
            	        	PushFollow(FOLLOW_nodetype_in_tikznode1473);
            	        	nodetype128 = nodetype();
            	        	state.followingStackPointer--;

            	        	stream_nodetype.Add(nodetype128.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzstring_in_tikznode1476);
            	tikzstring129 = tikzstring();
            	state.followingStackPointer--;

            	stream_tikzstring.Add(tikzstring129.Tree);


            	// AST REWRITE
            	// elements:          tikzstring, nodename, coord
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 245:50: -> ^( IM_NODE ( nodename )? ( coord )? tikzstring )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:245:53: ^( IM_NODE ( nodename )? ( coord )? tikzstring )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NODE, "IM_NODE"), root_1);

            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:245:63: ( nodename )?
            	    if ( stream_nodename.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_nodename.NextTree());

            	    }
            	    stream_nodename.Reset();
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:245:73: ( coord )?
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:249:1: edgeop : ( '--' | '->' | '|-' | '-|' | ID );
    public simpletikzParser.edgeop_return edgeop() // throws RecognitionException [1]
    {   
        simpletikzParser.edgeop_return retval = new simpletikzParser.edgeop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set130 = null;

        object set130_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:250:2: ( '--' | '->' | '|-' | '-|' | ID )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set130 = (IToken)input.LT(1);
            	if ( input.LA(1) == ID || (input.LA(1) >= 59 && input.LA(1) <= 62) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set130));
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:254:1: coord_modifier : ( '+' | '++' );
    public simpletikzParser.coord_modifier_return coord_modifier() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_modifier_return retval = new simpletikzParser.coord_modifier_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set131 = null;

        object set131_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:255:2: ( '+' | '++' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set131 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 63 && input.LA(1) <= 64) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set131));
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:258:1: tikznodee : node_start tikznode ( tikzpathi )? semicolon_end -> ^( IM_PATH node_start tikznode ( tikzpathi )? semicolon_end ) ;
    public simpletikzParser.tikznodee_return tikznodee() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznodee_return retval = new simpletikzParser.tikznodee_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.node_start_return node_start132 = default(simpletikzParser.node_start_return);

        simpletikzParser.tikznode_return tikznode133 = default(simpletikzParser.tikznode_return);

        simpletikzParser.tikzpathi_return tikzpathi134 = default(simpletikzParser.tikzpathi_return);

        simpletikzParser.semicolon_end_return semicolon_end135 = default(simpletikzParser.semicolon_end_return);


        RewriteRuleSubtreeStream stream_node_start = new RewriteRuleSubtreeStream(adaptor,"rule node_start");
        RewriteRuleSubtreeStream stream_tikznode = new RewriteRuleSubtreeStream(adaptor,"rule tikznode");
        RewriteRuleSubtreeStream stream_semicolon_end = new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        RewriteRuleSubtreeStream stream_tikzpathi = new RewriteRuleSubtreeStream(adaptor,"rule tikzpathi");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:259:2: ( node_start tikznode ( tikzpathi )? semicolon_end -> ^( IM_PATH node_start tikznode ( tikzpathi )? semicolon_end ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:259:4: node_start tikznode ( tikzpathi )? semicolon_end
            {
            	PushFollow(FOLLOW_node_start_in_tikznodee1551);
            	node_start132 = node_start();
            	state.followingStackPointer--;

            	stream_node_start.Add(node_start132.Tree);
            	PushFollow(FOLLOW_tikznode_in_tikznodee1553);
            	tikznode133 = tikznode();
            	state.followingStackPointer--;

            	stream_tikznode.Add(tikznode133.Tree);
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:259:24: ( tikzpathi )?
            	int alt42 = 2;
            	int LA42_0 = input.LA(1);

            	if ( (LA42_0 == LPAR || (LA42_0 >= 63 && LA42_0 <= 64)) )
            	{
            	    alt42 = 1;
            	}
            	switch (alt42) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:259:24: tikzpathi
            	        {
            	        	PushFollow(FOLLOW_tikzpathi_in_tikznodee1555);
            	        	tikzpathi134 = tikzpathi();
            	        	state.followingStackPointer--;

            	        	stream_tikzpathi.Add(tikzpathi134.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_semicolon_end_in_tikznodee1558);
            	semicolon_end135 = semicolon_end();
            	state.followingStackPointer--;

            	stream_semicolon_end.Add(semicolon_end135.Tree);


            	// AST REWRITE
            	// elements:          semicolon_end, node_start, tikzpathi, tikznode
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 259:49: -> ^( IM_PATH node_start tikznode ( tikzpathi )? semicolon_end )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:259:52: ^( IM_PATH node_start tikznode ( tikzpathi )? semicolon_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_node_start.NextTree());
            	    adaptor.AddChild(root_1, stream_tikznode.NextTree());
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:259:82: ( tikzpathi )?
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:262:1: node_start : NODE -> ^( IM_STARTTAG NODE ) ;
    public simpletikzParser.node_start_return node_start() // throws RecognitionException [1]
    {   
        simpletikzParser.node_start_return retval = new simpletikzParser.node_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NODE136 = null;

        object NODE136_tree=null;
        RewriteRuleTokenStream stream_NODE = new RewriteRuleTokenStream(adaptor,"token NODE");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:263:2: ( NODE -> ^( IM_STARTTAG NODE ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:263:4: NODE
            {
            	NODE136=(IToken)Match(input,NODE,FOLLOW_NODE_in_node_start1586);  
            	stream_NODE.Add(NODE136);



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
            	// 263:9: -> ^( IM_STARTTAG NODE )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:263:12: ^( IM_STARTTAG NODE )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:305:1: squarebr_start : LBR -> ^( IM_STARTTAG LBR ) ;
    public simpletikzParser.squarebr_start_return squarebr_start() // throws RecognitionException [1]
    {   
        simpletikzParser.squarebr_start_return retval = new simpletikzParser.squarebr_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LBR137 = null;

        object LBR137_tree=null;
        RewriteRuleTokenStream stream_LBR = new RewriteRuleTokenStream(adaptor,"token LBR");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:306:2: ( LBR -> ^( IM_STARTTAG LBR ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:306:4: LBR
            {
            	LBR137=(IToken)Match(input,LBR,FOLLOW_LBR_in_squarebr_start1612);  
            	stream_LBR.Add(LBR137);



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
            	// 306:8: -> ^( IM_STARTTAG LBR )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:306:11: ^( IM_STARTTAG LBR )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:308:1: squarebr_end : RBR -> ^( IM_ENDTAG RBR ) ;
    public simpletikzParser.squarebr_end_return squarebr_end() // throws RecognitionException [1]
    {   
        simpletikzParser.squarebr_end_return retval = new simpletikzParser.squarebr_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken RBR138 = null;

        object RBR138_tree=null;
        RewriteRuleTokenStream stream_RBR = new RewriteRuleTokenStream(adaptor,"token RBR");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:309:2: ( RBR -> ^( IM_ENDTAG RBR ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:309:4: RBR
            {
            	RBR138=(IToken)Match(input,RBR,FOLLOW_RBR_in_squarebr_end1630);  
            	stream_RBR.Add(RBR138);



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
            	// 309:8: -> ^( IM_ENDTAG RBR )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:309:11: ^( IM_ENDTAG RBR )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:311:1: semicolon_end : ';' -> ^( IM_ENDTAG ';' ) ;
    public simpletikzParser.semicolon_end_return semicolon_end() // throws RecognitionException [1]
    {   
        simpletikzParser.semicolon_end_return retval = new simpletikzParser.semicolon_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal139 = null;

        object char_literal139_tree=null;
        RewriteRuleTokenStream stream_SEMIC = new RewriteRuleTokenStream(adaptor,"token SEMIC");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:312:2: ( ';' -> ^( IM_ENDTAG ';' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:312:4: ';'
            {
            	char_literal139=(IToken)Match(input,SEMIC,FOLLOW_SEMIC_in_semicolon_end1649);  
            	stream_SEMIC.Add(char_literal139);



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
            	// 312:8: -> ^( IM_ENDTAG ';' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:312:11: ^( IM_ENDTAG ';' )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:314:1: roundbr_end : '}' -> ^( IM_ENDTAG '}' ) ;
    public simpletikzParser.roundbr_end_return roundbr_end() // throws RecognitionException [1]
    {   
        simpletikzParser.roundbr_end_return retval = new simpletikzParser.roundbr_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal140 = null;

        object char_literal140_tree=null;
        RewriteRuleTokenStream stream_RBRR = new RewriteRuleTokenStream(adaptor,"token RBRR");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:315:2: ( '}' -> ^( IM_ENDTAG '}' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:315:4: '}'
            {
            	char_literal140=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_roundbr_end1667);  
            	stream_RBRR.Add(char_literal140);



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
            	// 315:8: -> ^( IM_ENDTAG '}' )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:315:11: ^( IM_ENDTAG '}' )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:317:1: tikz_set_start : TIKZSET '{' -> ^( IM_STARTTAG ) ;
    public simpletikzParser.tikz_set_start_return tikz_set_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_set_start_return retval = new simpletikzParser.tikz_set_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken TIKZSET141 = null;
        IToken char_literal142 = null;

        object TIKZSET141_tree=null;
        object char_literal142_tree=null;
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_TIKZSET = new RewriteRuleTokenStream(adaptor,"token TIKZSET");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:318:2: ( TIKZSET '{' -> ^( IM_STARTTAG ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:318:4: TIKZSET '{'
            {
            	TIKZSET141=(IToken)Match(input,TIKZSET,FOLLOW_TIKZSET_in_tikz_set_start1685);  
            	stream_TIKZSET.Add(TIKZSET141);

            	char_literal142=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_tikz_set_start1687);  
            	stream_LBRR.Add(char_literal142);



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
            	// 318:17: -> ^( IM_STARTTAG )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:318:20: ^( IM_STARTTAG )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:320:1: tikzpicture_start : BEGIN '{' 'tikzpicture' '}' -> ^( IM_STARTTAG BEGIN ) ;
    public simpletikzParser.tikzpicture_start_return tikzpicture_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_start_return retval = new simpletikzParser.tikzpicture_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken BEGIN143 = null;
        IToken char_literal144 = null;
        IToken string_literal145 = null;
        IToken char_literal146 = null;

        object BEGIN143_tree=null;
        object char_literal144_tree=null;
        object string_literal145_tree=null;
        object char_literal146_tree=null;
        RewriteRuleTokenStream stream_RBRR = new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_65 = new RewriteRuleTokenStream(adaptor,"token 65");
        RewriteRuleTokenStream stream_BEGIN = new RewriteRuleTokenStream(adaptor,"token BEGIN");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:321:2: ( BEGIN '{' 'tikzpicture' '}' -> ^( IM_STARTTAG BEGIN ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:321:4: BEGIN '{' 'tikzpicture' '}'
            {
            	BEGIN143=(IToken)Match(input,BEGIN,FOLLOW_BEGIN_in_tikzpicture_start1706);  
            	stream_BEGIN.Add(BEGIN143);

            	char_literal144=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_tikzpicture_start1708);  
            	stream_LBRR.Add(char_literal144);

            	string_literal145=(IToken)Match(input,65,FOLLOW_65_in_tikzpicture_start1710);  
            	stream_65.Add(string_literal145);

            	char_literal146=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_tikzpicture_start1712);  
            	stream_RBRR.Add(char_literal146);



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
            	// 321:32: -> ^( IM_STARTTAG BEGIN )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:321:35: ^( IM_STARTTAG BEGIN )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:323:1: tikzpicture_end : END '{' 'tikzpicture' '}' -> ^( IM_ENDTAG END ) ;
    public simpletikzParser.tikzpicture_end_return tikzpicture_end() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_end_return retval = new simpletikzParser.tikzpicture_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken END147 = null;
        IToken char_literal148 = null;
        IToken string_literal149 = null;
        IToken char_literal150 = null;

        object END147_tree=null;
        object char_literal148_tree=null;
        object string_literal149_tree=null;
        object char_literal150_tree=null;
        RewriteRuleTokenStream stream_RBRR = new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_END = new RewriteRuleTokenStream(adaptor,"token END");
        RewriteRuleTokenStream stream_65 = new RewriteRuleTokenStream(adaptor,"token 65");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:324:2: ( END '{' 'tikzpicture' '}' -> ^( IM_ENDTAG END ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:324:4: END '{' 'tikzpicture' '}'
            {
            	END147=(IToken)Match(input,END,FOLLOW_END_in_tikzpicture_end1730);  
            	stream_END.Add(END147);

            	char_literal148=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_tikzpicture_end1732);  
            	stream_LBRR.Add(char_literal148);

            	string_literal149=(IToken)Match(input,65,FOLLOW_65_in_tikzpicture_end1734);  
            	stream_65.Add(string_literal149);

            	char_literal150=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_tikzpicture_end1736);  
            	stream_RBRR.Add(char_literal150);



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
            	// 324:30: -> ^( IM_ENDTAG END )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:324:33: ^( IM_ENDTAG END )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:326:1: tikzscope_start : BEGIN '{' 'scope' '}' -> ^( IM_STARTTAG BEGIN ) ;
    public simpletikzParser.tikzscope_start_return tikzscope_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_start_return retval = new simpletikzParser.tikzscope_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken BEGIN151 = null;
        IToken char_literal152 = null;
        IToken string_literal153 = null;
        IToken char_literal154 = null;

        object BEGIN151_tree=null;
        object char_literal152_tree=null;
        object string_literal153_tree=null;
        object char_literal154_tree=null;
        RewriteRuleTokenStream stream_66 = new RewriteRuleTokenStream(adaptor,"token 66");
        RewriteRuleTokenStream stream_RBRR = new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_BEGIN = new RewriteRuleTokenStream(adaptor,"token BEGIN");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:327:2: ( BEGIN '{' 'scope' '}' -> ^( IM_STARTTAG BEGIN ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:327:4: BEGIN '{' 'scope' '}'
            {
            	BEGIN151=(IToken)Match(input,BEGIN,FOLLOW_BEGIN_in_tikzscope_start1754);  
            	stream_BEGIN.Add(BEGIN151);

            	char_literal152=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_tikzscope_start1756);  
            	stream_LBRR.Add(char_literal152);

            	string_literal153=(IToken)Match(input,66,FOLLOW_66_in_tikzscope_start1758);  
            	stream_66.Add(string_literal153);

            	char_literal154=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_tikzscope_start1760);  
            	stream_RBRR.Add(char_literal154);



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
            	// 327:26: -> ^( IM_STARTTAG BEGIN )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:327:29: ^( IM_STARTTAG BEGIN )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:329:1: tikzscope_end : END '{' 'scope' '}' -> ^( IM_ENDTAG END ) ;
    public simpletikzParser.tikzscope_end_return tikzscope_end() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_end_return retval = new simpletikzParser.tikzscope_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken END155 = null;
        IToken char_literal156 = null;
        IToken string_literal157 = null;
        IToken char_literal158 = null;

        object END155_tree=null;
        object char_literal156_tree=null;
        object string_literal157_tree=null;
        object char_literal158_tree=null;
        RewriteRuleTokenStream stream_66 = new RewriteRuleTokenStream(adaptor,"token 66");
        RewriteRuleTokenStream stream_RBRR = new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR = new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_END = new RewriteRuleTokenStream(adaptor,"token END");

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:330:2: ( END '{' 'scope' '}' -> ^( IM_ENDTAG END ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:330:4: END '{' 'scope' '}'
            {
            	END155=(IToken)Match(input,END,FOLLOW_END_in_tikzscope_end1778);  
            	stream_END.Add(END155);

            	char_literal156=(IToken)Match(input,LBRR,FOLLOW_LBRR_in_tikzscope_end1780);  
            	stream_LBRR.Add(char_literal156);

            	string_literal157=(IToken)Match(input,66,FOLLOW_66_in_tikzscope_end1782);  
            	stream_66.Add(string_literal157);

            	char_literal158=(IToken)Match(input,RBRR,FOLLOW_RBRR_in_tikzscope_end1784);  
            	stream_RBRR.Add(char_literal158);



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
            	// 330:24: -> ^( IM_ENDTAG END )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:330:27: ^( IM_ENDTAG END )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:332:1: path_start : path_start_tag -> ^( IM_STARTTAG path_start_tag ) ;
    public simpletikzParser.path_start_return path_start() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_return retval = new simpletikzParser.path_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.path_start_tag_return path_start_tag159 = default(simpletikzParser.path_start_tag_return);


        RewriteRuleSubtreeStream stream_path_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule path_start_tag");
        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:333:2: ( path_start_tag -> ^( IM_STARTTAG path_start_tag ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:333:4: path_start_tag
            {
            	PushFollow(FOLLOW_path_start_tag_in_path_start1803);
            	path_start_tag159 = path_start_tag();
            	state.followingStackPointer--;

            	stream_path_start_tag.Add(path_start_tag159.Tree);


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
            	// 333:19: -> ^( IM_STARTTAG path_start_tag )
            	{
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:333:22: ^( IM_STARTTAG path_start_tag )
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:336:1: path_start_tag : ( DRAW | FILL | PATH );
    public simpletikzParser.path_start_tag_return path_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_tag_return retval = new simpletikzParser.path_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set160 = null;

        object set160_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:337:2: ( DRAW | FILL | PATH )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set160 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= DRAW && input.LA(1) <= FILL) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set160));
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
   	protected DFA25 dfa25;
   	protected DFA26 dfa26;
	private void InitializeCyclicDFAs()
	{
    	this.dfa6 = new DFA6(this);
    	this.dfa25 = new DFA25(this);
    	this.dfa26 = new DFA26(this);
	}

    const string DFA6_eotS =
        "\x06\uffff";
    const string DFA6_eofS =
        "\x06\uffff";
    const string DFA6_minS =
        "\x01\x2b\x03\x10\x02\uffff";
    const string DFA6_maxS =
        "\x02\x3e\x01\x33\x01\x3e\x02\uffff";
    const string DFA6_acceptS =
        "\x04\uffff\x01\x02\x01\x01";
    const string DFA6_specialS =
        "\x06\uffff}>";
    static readonly string[] DFA6_transitionS = {
            "\x01\x01\x0f\uffff\x04\x01",
            "\x01\x04\x01\uffff\x03\x04\x14\uffff\x01\x02\x01\uffff\x01"+
            "\x03\x07\uffff\x01\x05\x07\uffff\x04\x03",
            "\x01\x04\x01\uffff\x03\x04\x1e\uffff\x01\x05",
            "\x01\x04\x01\uffff\x03\x04\x16\uffff\x01\x03\x07\uffff\x01"+
            "\x05\x07\uffff\x04\x03",
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
            get { return "110:1: option : ( option_style | option_kv );"; }
        }

    }

    const string DFA25_eotS =
        "\x0b\uffff";
    const string DFA25_eofS =
        "\x0b\uffff";
    const string DFA25_minS =
        "\x01\x04\x01\x11\x06\uffff\x01\x2b\x02\uffff";
    const string DFA25_maxS =
        "\x01\x42\x01\x11\x06\uffff\x01\x42\x02\uffff";
    const string DFA25_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x08\x01"+
        "\uffff\x01\x01\x01\x07";
    const string DFA25_specialS =
        "\x0b\uffff}>";
    static readonly string[] DFA25_transitionS = {
            "\x01\x01\x01\x07\x01\x04\x01\x06\x01\x05\x01\x03\x03\x02\x02"+
            "\x04\x01\uffff\x33\x04",
            "\x01\x08",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0a\x0f\uffff\x04\x0a\x03\uffff\x01\x09",
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
            get { return "177:4: ( tikzscope | tikzpath | tikznodee | dontcare_body_nobr | tikz_set | tikz_style | otherbegin | otherend )"; }
        }

    }

    const string DFA26_eotS =
        "\x0e\uffff";
    const string DFA26_eofS =
        "\x0e\uffff";
    const string DFA26_minS =
        "\x01\x04\x02\x11\x05\uffff\x02\x2b\x04\uffff";
    const string DFA26_maxS =
        "\x01\x42\x02\x11\x05\uffff\x02\x42\x04\uffff";
    const string DFA26_acceptS =
        "\x03\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x02\uffff\x01"+
        "\x09\x01\x08\x01\x01\x01\x07";
    const string DFA26_specialS =
        "\x0e\uffff}>";
    static readonly string[] DFA26_transitionS = {
            "\x01\x02\x01\x01\x01\x05\x01\x07\x01\x06\x01\x04\x03\x03\x36"+
            "\x05",
            "\x01\x08",
            "\x01\x09",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0b\x0f\uffff\x04\x0b\x02\uffff\x02\x0a",
            "\x01\x0d\x0f\uffff\x04\x0d\x03\uffff\x01\x0c",
            "",
            "",
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
            get { return "()* loopback of 178:3: ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )*"; }
        }

    }

 

    public static readonly BitSet FOLLOW_dontcare_preamble_in_tikzdocument340 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_tikz_styleorset_in_tikzdocument344 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzdocument348 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_tikzpicture_in_tikzdocument353 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikz_styleorset378 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikz_styleorset382 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_preamble393 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BEGIN_in_otherbegin414 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_LBRR_in_otherbegin416 = new BitSet(new ulong[]{0x7800080000000000UL});
    public static readonly BitSet FOLLOW_idd_in_otherbegin418 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_RBRR_in_otherbegin420 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TIKZSTYLE_in_tikz_style431 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_LBRR_in_tikz_style433 = new BitSet(new ulong[]{0x7800080000000000UL});
    public static readonly BitSet FOLLOW_idd_in_tikz_style435 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_RBRR_in_tikz_style437 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_EQU_in_tikz_style439 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikz_style441 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_squarebr_start_in_tikz_options463 = new BitSet(new ulong[]{0x7800080000010000UL});
    public static readonly BitSet FOLLOW_option_in_tikz_options466 = new BitSet(new ulong[]{0x7800080000090000UL});
    public static readonly BitSet FOLLOW_KOMMA_in_tikz_options469 = new BitSet(new ulong[]{0x7800080000000000UL});
    public static readonly BitSet FOLLOW_option_in_tikz_options471 = new BitSet(new ulong[]{0x7800080000090000UL});
    public static readonly BitSet FOLLOW_KOMMA_in_tikz_options475 = new BitSet(new ulong[]{0x7800080000010000UL});
    public static readonly BitSet FOLLOW_squarebr_end_in_tikz_options480 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_option_style_in_option505 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_option_kv_in_option514 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_option_kv528 = new BitSet(new ulong[]{0x0000000000100002UL});
    public static readonly BitSet FOLLOW_EQU_in_option_kv531 = new BitSet(new ulong[]{0x78000E0000020000UL});
    public static readonly BitSet FOLLOW_iddornumberunitorstring_in_option_kv533 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBR_in_nodetype561 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_no_rlbracket_in_nodetype563 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_nodetype_in_nodetype567 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_no_rlbracket_in_nodetype569 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_RBR_in_nodetype574 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_no_rlbracket597 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRR_in_tikzstring614 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_no_rlbrace_in_tikzstring616 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikzstring620 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_no_rlbrace_in_tikzstring622 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_RBRR_in_tikzstring627 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_no_rlbrace650 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_iddornumberunitorstring667 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_numberunit_in_iddornumberunitorstring671 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzstring_in_iddornumberunitorstring675 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_option_style685 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_option_style687 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_EQU_in_option_style689 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_LBRR_in_option_style691 = new BitSet(new ulong[]{0x78000800000C0000UL});
    public static readonly BitSet FOLLOW_option_kv_in_option_style694 = new BitSet(new ulong[]{0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_KOMMA_in_option_style697 = new BitSet(new ulong[]{0x7800080000000000UL});
    public static readonly BitSet FOLLOW_option_kv_in_option_style699 = new BitSet(new ulong[]{0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_KOMMA_in_option_style706 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_RBRR_in_option_style709 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_edgeop_in_idd740 = new BitSet(new ulong[]{0x7800080000000002UL});
    public static readonly BitSet FOLLOW_edgeop_in_idd743 = new BitSet(new ulong[]{0x7800080000000002UL});
    public static readonly BitSet FOLLOW_edgeop_in_idd759 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_INT_in_idd761 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_number_in_numberunit790 = new BitSet(new ulong[]{0x03F0000000000002UL});
    public static readonly BitSet FOLLOW_unit_in_numberunit792 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_number818 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unit0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikz_set_start_in_tikz_set873 = new BitSet(new ulong[]{0x7800080000040000UL});
    public static readonly BitSet FOLLOW_option_in_tikz_set876 = new BitSet(new ulong[]{0x78000800000C0000UL});
    public static readonly BitSet FOLLOW_KOMMA_in_tikz_set879 = new BitSet(new ulong[]{0x7800080000000000UL});
    public static readonly BitSet FOLLOW_option_in_tikz_set881 = new BitSet(new ulong[]{0x78000800000C0000UL});
    public static readonly BitSet FOLLOW_roundbr_end_in_tikz_set887 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzpicture_start_in_tikzpicture915 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpicture917 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzpicture920 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_tikzpicture_end_in_tikzpicture923 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody953 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody957 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_tikznodee_in_tikzbody961 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_dontcare_body_nobr_in_tikzbody965 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody969 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody973 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody977 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody980 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody990 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody994 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_tikznodee_in_tikzbody998 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_dontcare_body_in_tikzbody1002 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_tikz_set_in_tikzbody1006 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_tikz_style_in_tikzbody1010 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_otherbegin_in_tikzbody1014 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_otherend_in_tikzbody1017 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF2UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body_nobr1033 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dontcare_body1083 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_END_in_otherend1127 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_LBRR_in_otherend1129 = new BitSet(new ulong[]{0x7800080000000000UL});
    public static readonly BitSet FOLLOW_idd_in_otherend1131 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_RBRR_in_otherend1133 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_in_tikzpath1146 = new BitSet(new ulong[]{0x800000000000A000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpath1148 = new BitSet(new ulong[]{0x800000000000A000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_tikzpathi_in_tikzpath1151 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikzpath1153 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coordornode_new_in_tikzpathi1184 = new BitSet(new ulong[]{0x7800080000000002UL});
    public static readonly BitSet FOLLOW_edgeop_in_tikzpathi1187 = new BitSet(new ulong[]{0x800000000000A000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_coordornode_new_in_tikzpathi1190 = new BitSet(new ulong[]{0x7800080000000002UL});
    public static readonly BitSet FOLLOW_tikzscope_start_in_tikzscope1207 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzscope1209 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzscope1212 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_tikzscope_end_in_tikzscope1215 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_in_coordornode1243 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_size_in_coordornode1247 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznodei_in_coordornode1251 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_in_coordornode_new1268 = new BitSet(new ulong[]{0x0000080000000002UL});
    public static readonly BitSet FOLLOW_ID_in_coordornode_new1271 = new BitSet(new ulong[]{0x78000E0000028002UL});
    public static readonly BitSet FOLLOW_nodetype_in_coordornode_new1274 = new BitSet(new ulong[]{0x78000E0000020002UL});
    public static readonly BitSet FOLLOW_tikzstring_in_coordornode_new1279 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_size_in_coordornode_new1288 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NODE_in_tikznodei1301 = new BitSet(new ulong[]{0x7C000E000002A000UL});
    public static readonly BitSet FOLLOW_tikznode_in_tikznodei1304 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAR_in_nodename1316 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_ID_in_nodename1320 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_RPAR_in_nodename1322 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_size1348 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LPAR_in_size1353 = new BitSet(new ulong[]{0x0000060000000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_size1355 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_RPAR_in_size1357 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_coord1379 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord1403 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LPAR_in_coord1408 = new BitSet(new ulong[]{0x0000060000000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord1410 = new BitSet(new ulong[]{0x0000000000480000UL});
    public static readonly BitSet FOLLOW_coord_sep_in_coord1412 = new BitSet(new ulong[]{0x0000060000000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord1414 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_RPAR_in_coord1416 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_coord_sep1443 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_tikznode1463 = new BitSet(new ulong[]{0x7C000E0000028000UL});
    public static readonly BitSet FOLLOW_58_in_tikznode1467 = new BitSet(new ulong[]{0x8000000000002000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_coord_in_tikznode1469 = new BitSet(new ulong[]{0x78000E0000028000UL});
    public static readonly BitSet FOLLOW_nodetype_in_tikznode1473 = new BitSet(new ulong[]{0x78000E0000020000UL});
    public static readonly BitSet FOLLOW_tikzstring_in_tikznode1476 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_edgeop0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_coord_modifier0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_node_start_in_tikznodee1551 = new BitSet(new ulong[]{0x7C000E000002A000UL});
    public static readonly BitSet FOLLOW_tikznode_in_tikznodee1553 = new BitSet(new ulong[]{0x800000000020A000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_tikzpathi_in_tikznodee1555 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_semicolon_end_in_tikznodee1558 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NODE_in_node_start1586 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBR_in_squarebr_start1612 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RBR_in_squarebr_end1630 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SEMIC_in_semicolon_end1649 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RBRR_in_roundbr_end1667 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TIKZSET_in_tikz_set_start1685 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_LBRR_in_tikz_set_start1687 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BEGIN_in_tikzpicture_start1706 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_LBRR_in_tikzpicture_start1708 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_65_in_tikzpicture_start1710 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_RBRR_in_tikzpicture_start1712 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_END_in_tikzpicture_end1730 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_LBRR_in_tikzpicture_end1732 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_65_in_tikzpicture_end1734 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_RBRR_in_tikzpicture_end1736 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BEGIN_in_tikzscope_start1754 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_LBRR_in_tikzscope_start1756 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_tikzscope_start1758 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_RBRR_in_tikzscope_start1760 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_END_in_tikzscope_end1778 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_LBRR_in_tikzscope_end1780 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_tikzscope_end1782 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_RBRR_in_tikzscope_end1784 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_tag_in_path_start1803 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_path_start_tag0 = new BitSet(new ulong[]{0x0000000000000002UL});

}
