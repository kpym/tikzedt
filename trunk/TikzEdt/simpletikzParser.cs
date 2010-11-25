// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g 2010-11-25 10:21:47

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
		"BEGINTP", 
		"ENDTP", 
		"BEGINSCOPE", 
		"ENDSCOPE", 
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
		"SCALE", 
		"EQU", 
		"SEMIC", 
		"COLON", 
		"STYLESEP", 
		"AT", 
		"LABEL", 
		"EVERYLOOP", 
		"ST_INNERSEP", 
		"ST_OUTERSEP", 
		"ST_FILL", 
		"ST_DRAW", 
		"ST_SHAPE", 
		"ST_MINSIZE", 
		"ST_LINEWIDTH", 
		"ST_DASHSTYLE", 
		"LOOP", 
		"IN", 
		"OUT", 
		"UN_PTS", 
		"UN_CM", 
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
		"OPTIONS", 
		"STRING", 
		"ID", 
		"FLOAT", 
		"INT", 
		"SOMETHING", 
		"EXPONENT", 
		"COMMENT", 
		"WS", 
		"ESC_SEQ", 
		"'node'", 
		"'--'", 
		"'edge'", 
		"'->'", 
		"'|-'", 
		"'-|'", 
		"'to'", 
		"'+'", 
		"'++'", 
		"'ex'", 
		"'mm'"
    };

    public const int T__68 = 68;
    public const int T__69 = 69;
    public const int T__66 = 66;
    public const int EXPONENT = 58;
    public const int T__67 = 67;
    public const int T__64 = 64;
    public const int IM_STARTTAG = 50;
    public const int T__65 = 65;
    public const int T__62 = 62;
    public const int T__63 = 63;
    public const int IM_PATH = 42;
    public const int RBR = 17;
    public const int ST_DASHSTYLE = 36;
    public const int ST_LINEWIDTH = 35;
    public const int ST_FILL = 31;
    public const int FLOAT = 55;
    public const int BEGINTP = 6;
    public const int SOMETHING = 57;
    public const int ID = 54;
    public const int EOF = -1;
    public const int LBR = 16;
    public const int IM_ENDTAG = 51;
    public const int AT = 26;
    public const int IM_DOCUMENT = 48;
    public const int RBRR = 19;
    public const int ESC_SEQ = 61;
    public const int IN = 38;
    public const int LPAR = 14;
    public const int EVERYLOOP = 28;
    public const int ENDTP = 7;
    public const int FILL = 13;
    public const int PATH = 12;
    public const int LOOP = 37;
    public const int BEGIN = 4;
    public const int ST_OUTERSEP = 30;
    public const int COMMENT = 59;
    public const int ST_INNERSEP = 29;
    public const int NODE = 10;
    public const int UN_PTS = 40;
    public const int STYLESEP = 25;
    public const int IM_COORD = 44;
    public const int IM_PICTURE = 47;
    public const int INT = 56;
    public const int BEGINSCOPE = 8;
    public const int LBRR = 18;
    public const int UN_CM = 41;
    public const int IM_NODE = 43;
    public const int COLON = 24;
    public const int ENDSCOPE = 9;
    public const int ST_DRAW = 32;
    public const int IM_SCOPE = 49;
    public const int IM_NUMBERUNIT = 46;
    public const int SCALE = 21;
    public const int WS = 60;
    public const int T__71 = 71;
    public const int T__72 = 72;
    public const int T__70 = 70;
    public const int OUT = 39;
    public const int ST_MINSIZE = 34;
    public const int LABEL = 27;
    public const int KOMMA = 20;
    public const int ST_SHAPE = 33;
    public const int EQU = 22;
    public const int RPAR = 15;
    public const int END = 5;
    public const int SEMIC = 23;
    public const int IM_NODENAME = 45;
    public const int OPTIONS = 52;
    public const int STRING = 53;
    public const int DRAW = 11;

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:71:1: tikzpath : path_start tikzpathi path_end -> ^( IM_PATH path_start tikzpathi path_end ) ;
    public simpletikzParser.tikzpath_return tikzpath() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_return retval = new simpletikzParser.tikzpath_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.path_start_return path_start1 = default(simpletikzParser.path_start_return);

        simpletikzParser.tikzpathi_return tikzpathi2 = default(simpletikzParser.tikzpathi_return);

        simpletikzParser.path_end_return path_end3 = default(simpletikzParser.path_end_return);


        RewriteRuleSubtreeStream stream_path_end = new RewriteRuleSubtreeStream(adaptor,"rule path_end");
        RewriteRuleSubtreeStream stream_path_start = new RewriteRuleSubtreeStream(adaptor,"rule path_start");
        RewriteRuleSubtreeStream stream_tikzpathi = new RewriteRuleSubtreeStream(adaptor,"rule tikzpathi");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:72:2: ( path_start tikzpathi path_end -> ^( IM_PATH path_start tikzpathi path_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:72:4: path_start tikzpathi path_end
            {
            	PushFollow(FOLLOW_path_start_in_tikzpath420);
            	path_start1 = path_start();
            	state.followingStackPointer--;

            	stream_path_start.Add(path_start1.Tree);
            	PushFollow(FOLLOW_tikzpathi_in_tikzpath422);
            	tikzpathi2 = tikzpathi();
            	state.followingStackPointer--;

            	stream_tikzpathi.Add(tikzpathi2.Tree);
            	PushFollow(FOLLOW_path_end_in_tikzpath424);
            	path_end3 = path_end();
            	state.followingStackPointer--;

            	stream_path_end.Add(path_end3.Tree);


            	// AST REWRITE
            	// elements:          tikzpathi, path_start, path_end
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 72:34: -> ^( IM_PATH path_start tikzpathi path_end )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:72:37: ^( IM_PATH path_start tikzpathi path_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_path_start.NextTree());
            	    adaptor.AddChild(root_1, stream_tikzpathi.NextTree());
            	    adaptor.AddChild(root_1, stream_path_end.NextTree());

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

    public class path_end_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "path_end"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:74:1: path_end : SEMIC -> ^( IM_ENDTAG SEMIC ) ;
    public simpletikzParser.path_end_return path_end() // throws RecognitionException [1]
    {   
        simpletikzParser.path_end_return retval = new simpletikzParser.path_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken SEMIC4 = null;

        object SEMIC4_tree=null;
        RewriteRuleTokenStream stream_SEMIC = new RewriteRuleTokenStream(adaptor,"token SEMIC");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:75:2: ( SEMIC -> ^( IM_ENDTAG SEMIC ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:75:4: SEMIC
            {
            	SEMIC4=(IToken)Match(input,SEMIC,FOLLOW_SEMIC_in_path_end447);  
            	stream_SEMIC.Add(SEMIC4);



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
            	// 75:10: -> ^( IM_ENDTAG SEMIC )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:75:13: ^( IM_ENDTAG SEMIC )
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
    // $ANTLR end "path_end"

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:78:1: tikzpathi : ( OPTIONS )? coordornode ( coordornode | ( OPTIONS )? edgeop coordornode )* ;
    public simpletikzParser.tikzpathi_return tikzpathi() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpathi_return retval = new simpletikzParser.tikzpathi_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken OPTIONS5 = null;
        IToken OPTIONS8 = null;
        simpletikzParser.coordornode_return coordornode6 = default(simpletikzParser.coordornode_return);

        simpletikzParser.coordornode_return coordornode7 = default(simpletikzParser.coordornode_return);

        simpletikzParser.edgeop_return edgeop9 = default(simpletikzParser.edgeop_return);

        simpletikzParser.coordornode_return coordornode10 = default(simpletikzParser.coordornode_return);


        object OPTIONS5_tree=null;
        object OPTIONS8_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:79:2: ( ( OPTIONS )? coordornode ( coordornode | ( OPTIONS )? edgeop coordornode )* )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:79:4: ( OPTIONS )? coordornode ( coordornode | ( OPTIONS )? edgeop coordornode )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:79:4: ( OPTIONS )?
            	int alt1 = 2;
            	int LA1_0 = input.LA(1);

            	if ( (LA1_0 == OPTIONS) )
            	{
            	    alt1 = 1;
            	}
            	switch (alt1) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:79:5: OPTIONS
            	        {
            	        	OPTIONS5=(IToken)Match(input,OPTIONS,FOLLOW_OPTIONS_in_tikzpathi467); 

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_coordornode_in_tikzpathi472);
            	coordornode6 = coordornode();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, coordornode6.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:79:28: ( coordornode | ( OPTIONS )? edgeop coordornode )*
            	do 
            	{
            	    int alt3 = 3;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == LPAR || LA3_0 == 62 || (LA3_0 >= 69 && LA3_0 <= 70)) )
            	    {
            	        alt3 = 1;
            	    }
            	    else if ( (LA3_0 == OPTIONS || (LA3_0 >= 63 && LA3_0 <= 68)) )
            	    {
            	        alt3 = 2;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:79:29: coordornode
            			    {
            			    	PushFollow(FOLLOW_coordornode_in_tikzpathi475);
            			    	coordornode7 = coordornode();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, coordornode7.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:79:43: ( OPTIONS )? edgeop coordornode
            			    {
            			    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:79:43: ( OPTIONS )?
            			    	int alt2 = 2;
            			    	int LA2_0 = input.LA(1);

            			    	if ( (LA2_0 == OPTIONS) )
            			    	{
            			    	    alt2 = 1;
            			    	}
            			    	switch (alt2) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:79:44: OPTIONS
            			    	        {
            			    	        	OPTIONS8=(IToken)Match(input,OPTIONS,FOLLOW_OPTIONS_in_tikzpathi480); 

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_edgeop_in_tikzpathi485);
            			    	edgeop9 = edgeop();
            			    	state.followingStackPointer--;

            			    	PushFollow(FOLLOW_coordornode_in_tikzpathi488);
            			    	coordornode10 = coordornode();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, coordornode10.Tree);

            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements


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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:82:1: coordornode : ( coord | tikznodei );
    public simpletikzParser.coordornode_return coordornode() // throws RecognitionException [1]
    {   
        simpletikzParser.coordornode_return retval = new simpletikzParser.coordornode_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.coord_return coord11 = default(simpletikzParser.coord_return);

        simpletikzParser.tikznodei_return tikznodei12 = default(simpletikzParser.tikznodei_return);



        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:83:2: ( coord | tikznodei )
            int alt4 = 2;
            int LA4_0 = input.LA(1);

            if ( (LA4_0 == LPAR || (LA4_0 >= 69 && LA4_0 <= 70)) )
            {
                alt4 = 1;
            }
            else if ( (LA4_0 == 62) )
            {
                alt4 = 2;
            }
            else 
            {
                NoViableAltException nvae_d4s0 =
                    new NoViableAltException("", 4, 0, input);

                throw nvae_d4s0;
            }
            switch (alt4) 
            {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:83:4: coord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_coord_in_coordornode503);
                    	coord11 = coord();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, coord11.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:83:12: tikznodei
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikznodei_in_coordornode507);
                    	tikznodei12 = tikznodei();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, tikznodei12.Tree);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:86:1: tikznodei : 'node' tikznode ;
    public simpletikzParser.tikznodei_return tikznodei() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznodei_return retval = new simpletikzParser.tikznodei_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal13 = null;
        simpletikzParser.tikznode_return tikznode14 = default(simpletikzParser.tikznode_return);


        object string_literal13_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:87:2: ( 'node' tikznode )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:87:4: 'node' tikznode
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal13=(IToken)Match(input,62,FOLLOW_62_in_tikznodei519); 
            	PushFollow(FOLLOW_tikznode_in_tikznodei522);
            	tikznode14 = tikznode();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, tikznode14.Tree);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:1: tikznodee : node_start tikznode tikzpathi path_end -> ^( IM_PATH node_start tikznode tikzpathi path_end ) ;
    public simpletikzParser.tikznodee_return tikznodee() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznodee_return retval = new simpletikzParser.tikznodee_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.node_start_return node_start15 = default(simpletikzParser.node_start_return);

        simpletikzParser.tikznode_return tikznode16 = default(simpletikzParser.tikznode_return);

        simpletikzParser.tikzpathi_return tikzpathi17 = default(simpletikzParser.tikzpathi_return);

        simpletikzParser.path_end_return path_end18 = default(simpletikzParser.path_end_return);


        RewriteRuleSubtreeStream stream_node_start = new RewriteRuleSubtreeStream(adaptor,"rule node_start");
        RewriteRuleSubtreeStream stream_path_end = new RewriteRuleSubtreeStream(adaptor,"rule path_end");
        RewriteRuleSubtreeStream stream_tikznode = new RewriteRuleSubtreeStream(adaptor,"rule tikznode");
        RewriteRuleSubtreeStream stream_tikzpathi = new RewriteRuleSubtreeStream(adaptor,"rule tikzpathi");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:2: ( node_start tikznode tikzpathi path_end -> ^( IM_PATH node_start tikznode tikzpathi path_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:4: node_start tikznode tikzpathi path_end
            {
            	PushFollow(FOLLOW_node_start_in_tikznodee532);
            	node_start15 = node_start();
            	state.followingStackPointer--;

            	stream_node_start.Add(node_start15.Tree);
            	PushFollow(FOLLOW_tikznode_in_tikznodee534);
            	tikznode16 = tikznode();
            	state.followingStackPointer--;

            	stream_tikznode.Add(tikznode16.Tree);
            	PushFollow(FOLLOW_tikzpathi_in_tikznodee536);
            	tikzpathi17 = tikzpathi();
            	state.followingStackPointer--;

            	stream_tikzpathi.Add(tikzpathi17.Tree);
            	PushFollow(FOLLOW_path_end_in_tikznodee538);
            	path_end18 = path_end();
            	state.followingStackPointer--;

            	stream_path_end.Add(path_end18.Tree);


            	// AST REWRITE
            	// elements:          tikznode, path_end, node_start, tikzpathi
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 90:43: -> ^( IM_PATH node_start tikznode tikzpathi path_end )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:46: ^( IM_PATH node_start tikznode tikzpathi path_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_node_start.NextTree());
            	    adaptor.AddChild(root_1, stream_tikznode.NextTree());
            	    adaptor.AddChild(root_1, stream_tikzpathi.NextTree());
            	    adaptor.AddChild(root_1, stream_path_end.NextTree());

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:92:1: node_start : NODE -> ^( IM_STARTTAG NODE ) ;
    public simpletikzParser.node_start_return node_start() // throws RecognitionException [1]
    {   
        simpletikzParser.node_start_return retval = new simpletikzParser.node_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NODE19 = null;

        object NODE19_tree=null;
        RewriteRuleTokenStream stream_NODE = new RewriteRuleTokenStream(adaptor,"token NODE");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:93:2: ( NODE -> ^( IM_STARTTAG NODE ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:93:4: NODE
            {
            	NODE19=(IToken)Match(input,NODE,FOLLOW_NODE_in_node_start563);  
            	stream_NODE.Add(NODE19);



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
            	// 93:9: -> ^( IM_STARTTAG NODE )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:93:12: ^( IM_STARTTAG NODE )
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:95:1: tikznode : ( OPTIONS )? ( nodename )? ( 'at' coord )? STRING -> ^( IM_NODE ( OPTIONS )? ( nodename )? ( coord )? STRING ) ;
    public simpletikzParser.tikznode_return tikznode() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_return retval = new simpletikzParser.tikznode_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken OPTIONS20 = null;
        IToken string_literal22 = null;
        IToken STRING24 = null;
        simpletikzParser.nodename_return nodename21 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_return coord23 = default(simpletikzParser.coord_return);


        object OPTIONS20_tree=null;
        object string_literal22_tree=null;
        object STRING24_tree=null;
        RewriteRuleTokenStream stream_AT = new RewriteRuleTokenStream(adaptor,"token AT");
        RewriteRuleTokenStream stream_OPTIONS = new RewriteRuleTokenStream(adaptor,"token OPTIONS");
        RewriteRuleTokenStream stream_STRING = new RewriteRuleTokenStream(adaptor,"token STRING");
        RewriteRuleSubtreeStream stream_coord = new RewriteRuleSubtreeStream(adaptor,"rule coord");
        RewriteRuleSubtreeStream stream_nodename = new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:96:2: ( ( OPTIONS )? ( nodename )? ( 'at' coord )? STRING -> ^( IM_NODE ( OPTIONS )? ( nodename )? ( coord )? STRING ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:96:4: ( OPTIONS )? ( nodename )? ( 'at' coord )? STRING
            {
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:96:4: ( OPTIONS )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == OPTIONS) )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:96:4: OPTIONS
            	        {
            	        	OPTIONS20=(IToken)Match(input,OPTIONS,FOLLOW_OPTIONS_in_tikznode581);  
            	        	stream_OPTIONS.Add(OPTIONS20);


            	        }
            	        break;

            	}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:96:13: ( nodename )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( (LA6_0 == LPAR) )
            	{
            	    alt6 = 1;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:96:13: nodename
            	        {
            	        	PushFollow(FOLLOW_nodename_in_tikznode584);
            	        	nodename21 = nodename();
            	        	state.followingStackPointer--;

            	        	stream_nodename.Add(nodename21.Tree);

            	        }
            	        break;

            	}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:96:23: ( 'at' coord )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( (LA7_0 == AT) )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:96:24: 'at' coord
            	        {
            	        	string_literal22=(IToken)Match(input,AT,FOLLOW_AT_in_tikznode588);  
            	        	stream_AT.Add(string_literal22);

            	        	PushFollow(FOLLOW_coord_in_tikznode590);
            	        	coord23 = coord();
            	        	state.followingStackPointer--;

            	        	stream_coord.Add(coord23.Tree);

            	        }
            	        break;

            	}

            	STRING24=(IToken)Match(input,STRING,FOLLOW_STRING_in_tikznode594);  
            	stream_STRING.Add(STRING24);



            	// AST REWRITE
            	// elements:          OPTIONS, nodename, coord, STRING
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 96:45: -> ^( IM_NODE ( OPTIONS )? ( nodename )? ( coord )? STRING )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:96:48: ^( IM_NODE ( OPTIONS )? ( nodename )? ( coord )? STRING )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NODE, "IM_NODE"), root_1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:96:58: ( OPTIONS )?
            	    if ( stream_OPTIONS.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_OPTIONS.NextNode());

            	    }
            	    stream_OPTIONS.Reset();
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:96:67: ( nodename )?
            	    if ( stream_nodename.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_nodename.NextTree());

            	    }
            	    stream_nodename.Reset();
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:96:77: ( coord )?
            	    if ( stream_coord.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_coord.NextTree());

            	    }
            	    stream_coord.Reset();
            	    adaptor.AddChild(root_1, stream_STRING.NextNode());

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:99:1: edgeop : ( '--' | 'edge' | '->' | '|-' | '-|' | 'to' );
    public simpletikzParser.edgeop_return edgeop() // throws RecognitionException [1]
    {   
        simpletikzParser.edgeop_return retval = new simpletikzParser.edgeop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set25 = null;

        object set25_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:2: ( '--' | 'edge' | '->' | '|-' | '-|' | 'to' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set25 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 63 && input.LA(1) <= 68) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set25));
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:103:1: nodename : lc= LPAR id= ID RPAR -> ^( IM_NODENAME[$lc] $id) ;
    public simpletikzParser.nodename_return nodename() // throws RecognitionException [1]
    {   
        simpletikzParser.nodename_return retval = new simpletikzParser.nodename_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken lc = null;
        IToken id = null;
        IToken RPAR26 = null;

        object lc_tree=null;
        object id_tree=null;
        object RPAR26_tree=null;
        RewriteRuleTokenStream stream_RPAR = new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR = new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:104:2: (lc= LPAR id= ID RPAR -> ^( IM_NODENAME[$lc] $id) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:104:4: lc= LPAR id= ID RPAR
            {
            	lc=(IToken)Match(input,LPAR,FOLLOW_LPAR_in_nodename662);  
            	stream_LPAR.Add(lc);

            	id=(IToken)Match(input,ID,FOLLOW_ID_in_nodename666);  
            	stream_ID.Add(id);

            	RPAR26=(IToken)Match(input,RPAR,FOLLOW_RPAR_in_nodename668);  
            	stream_RPAR.Add(RPAR26);



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
            	// 104:24: -> ^( IM_NODENAME[$lc] $id)
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:104:27: ^( IM_NODENAME[$lc] $id)
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NODENAME, lc), root_1);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:107:1: coord : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR ) -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ ) );
    public simpletikzParser.coord_return coord() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_return retval = new simpletikzParser.coord_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken lc = null;
        IToken KOMMA30 = null;
        IToken RPAR32 = null;
        simpletikzParser.nodename_return nodename27 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_modifier_return coord_modifier28 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.numberunit_return numberunit29 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit31 = default(simpletikzParser.numberunit_return);


        object lc_tree=null;
        object KOMMA30_tree=null;
        object RPAR32_tree=null;
        RewriteRuleTokenStream stream_RPAR = new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR = new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleTokenStream stream_KOMMA = new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_nodename = new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        RewriteRuleSubtreeStream stream_coord_modifier = new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:2: ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR ) -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ ) )
            int alt9 = 2;
            int LA9_0 = input.LA(1);

            if ( (LA9_0 == LPAR) )
            {
                int LA9_1 = input.LA(2);

                if ( (LA9_1 == ID) )
                {
                    alt9 = 1;
                }
                else if ( ((LA9_1 >= FLOAT && LA9_1 <= INT)) )
                {
                    alt9 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d9s1 =
                        new NoViableAltException("", 9, 1, input);

                    throw nvae_d9s1;
                }
            }
            else if ( ((LA9_0 >= 69 && LA9_0 <= 70)) )
            {
                alt9 = 2;
            }
            else 
            {
                NoViableAltException nvae_d9s0 =
                    new NoViableAltException("", 9, 0, input);

                throw nvae_d9s0;
            }
            switch (alt9) 
            {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:6: nodename
                    {
                    	PushFollow(FOLLOW_nodename_in_coord693);
                    	nodename27 = nodename();
                    	state.followingStackPointer--;

                    	stream_nodename.Add(nodename27.Tree);


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
                    	// 108:23: -> ^( IM_COORD nodename )
                    	{
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:26: ^( IM_COORD nodename )
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
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:109:5: ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR )
                    {
                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:109:5: ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR )
                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:109:7: ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR
                    	{
                    		// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:109:7: ( coord_modifier )?
                    		int alt8 = 2;
                    		int LA8_0 = input.LA(1);

                    		if ( ((LA8_0 >= 69 && LA8_0 <= 70)) )
                    		{
                    		    alt8 = 1;
                    		}
                    		switch (alt8) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:109:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord717);
                    		        	coord_modifier28 = coord_modifier();
                    		        	state.followingStackPointer--;

                    		        	stream_coord_modifier.Add(coord_modifier28.Tree);

                    		        }
                    		        break;

                    		}

                    		lc=(IToken)Match(input,LPAR,FOLLOW_LPAR_in_coord722);  
                    		stream_LPAR.Add(lc);

                    		PushFollow(FOLLOW_numberunit_in_coord724);
                    		numberunit29 = numberunit();
                    		state.followingStackPointer--;

                    		stream_numberunit.Add(numberunit29.Tree);
                    		KOMMA30=(IToken)Match(input,KOMMA,FOLLOW_KOMMA_in_coord726);  
                    		stream_KOMMA.Add(KOMMA30);

                    		PushFollow(FOLLOW_numberunit_in_coord728);
                    		numberunit31 = numberunit();
                    		state.followingStackPointer--;

                    		stream_numberunit.Add(numberunit31.Tree);
                    		RPAR32=(IToken)Match(input,RPAR,FOLLOW_RPAR_in_coord730);  
                    		stream_RPAR.Add(RPAR32);


                    	}



                    	// AST REWRITE
                    	// elements:          coord_modifier, numberunit
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 109:66: -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ )
                    	{
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:109:69: ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, lc), root_1);

                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:109:85: ( coord_modifier )?
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:112:1: coord_modifier : ( '+' | '++' );
    public simpletikzParser.coord_modifier_return coord_modifier() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_modifier_return retval = new simpletikzParser.coord_modifier_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set33 = null;

        object set33_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:113:2: ( '+' | '++' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set33 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 69 && input.LA(1) <= 70) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set33));
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:116:1: numberunit : number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) ;
    public simpletikzParser.numberunit_return numberunit() // throws RecognitionException [1]
    {   
        simpletikzParser.numberunit_return retval = new simpletikzParser.numberunit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.number_return number34 = default(simpletikzParser.number_return);

        simpletikzParser.unit_return unit35 = default(simpletikzParser.unit_return);


        RewriteRuleSubtreeStream stream_unit = new RewriteRuleSubtreeStream(adaptor,"rule unit");
        RewriteRuleSubtreeStream stream_number = new RewriteRuleSubtreeStream(adaptor,"rule number");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:2: ( number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:4: number ( unit )?
            {
            	PushFollow(FOLLOW_number_in_numberunit772);
            	number34 = number();
            	state.followingStackPointer--;

            	stream_number.Add(number34.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:11: ( unit )?
            	int alt10 = 2;
            	int LA10_0 = input.LA(1);

            	if ( (LA10_0 == IN || (LA10_0 >= UN_PTS && LA10_0 <= UN_CM) || (LA10_0 >= 71 && LA10_0 <= 72)) )
            	{
            	    alt10 = 1;
            	}
            	switch (alt10) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:11: unit
            	        {
            	        	PushFollow(FOLLOW_unit_in_numberunit774);
            	        	unit35 = unit();
            	        	state.followingStackPointer--;

            	        	stream_unit.Add(unit35.Tree);

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
            	// 117:17: -> ^( IM_NUMBERUNIT number ( unit )? )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:20: ^( IM_NUMBERUNIT number ( unit )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NUMBERUNIT, "IM_NUMBERUNIT"), root_1);

            	    adaptor.AddChild(root_1, stream_number.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:43: ( unit )?
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:119:1: number : ( FLOAT | INT ) ;
    public simpletikzParser.number_return number() // throws RecognitionException [1]
    {   
        simpletikzParser.number_return retval = new simpletikzParser.number_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set36 = null;

        object set36_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:120:2: ( ( FLOAT | INT ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:120:4: ( FLOAT | INT )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set36 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= FLOAT && input.LA(1) <= INT) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set36));
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:122:1: unit : ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' );
    public simpletikzParser.unit_return unit() // throws RecognitionException [1]
    {   
        simpletikzParser.unit_return retval = new simpletikzParser.unit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set37 = null;

        object set37_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:123:2: ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set37 = (IToken)input.LT(1);
            	if ( input.LA(1) == IN || (input.LA(1) >= UN_PTS && input.LA(1) <= UN_CM) || (input.LA(1) >= 71 && input.LA(1) <= 72) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set37));
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:126:1: path_start : path_start_tag -> ^( IM_STARTTAG path_start_tag ) ;
    public simpletikzParser.path_start_return path_start() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_return retval = new simpletikzParser.path_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.path_start_tag_return path_start_tag38 = default(simpletikzParser.path_start_tag_return);


        RewriteRuleSubtreeStream stream_path_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule path_start_tag");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:127:2: ( path_start_tag -> ^( IM_STARTTAG path_start_tag ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:127:4: path_start_tag
            {
            	PushFollow(FOLLOW_path_start_tag_in_path_start841);
            	path_start_tag38 = path_start_tag();
            	state.followingStackPointer--;

            	stream_path_start_tag.Add(path_start_tag38.Tree);


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
            	// 127:19: -> ^( IM_STARTTAG path_start_tag )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:127:22: ^( IM_STARTTAG path_start_tag )
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:1: path_start_tag : ( DRAW | FILL | PATH );
    public simpletikzParser.path_start_tag_return path_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_tag_return retval = new simpletikzParser.path_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set39 = null;

        object set39_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:130:2: ( DRAW | FILL | PATH )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set39 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= DRAW && input.LA(1) <= FILL) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set39));
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:133:1: tikzdocument : ( SOMETHING )* tikzpicture ( SOMETHING )* -> ^( IM_DOCUMENT tikzpicture ) ;
    public simpletikzParser.tikzdocument_return tikzdocument() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzdocument_return retval = new simpletikzParser.tikzdocument_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken SOMETHING40 = null;
        IToken SOMETHING42 = null;
        simpletikzParser.tikzpicture_return tikzpicture41 = default(simpletikzParser.tikzpicture_return);


        object SOMETHING40_tree=null;
        object SOMETHING42_tree=null;
        RewriteRuleTokenStream stream_SOMETHING = new RewriteRuleTokenStream(adaptor,"token SOMETHING");
        RewriteRuleSubtreeStream stream_tikzpicture = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:134:2: ( ( SOMETHING )* tikzpicture ( SOMETHING )* -> ^( IM_DOCUMENT tikzpicture ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:134:4: ( SOMETHING )* tikzpicture ( SOMETHING )*
            {
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:134:4: ( SOMETHING )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( (LA11_0 == SOMETHING) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:134:4: SOMETHING
            			    {
            			    	SOMETHING40=(IToken)Match(input,SOMETHING,FOLLOW_SOMETHING_in_tikzdocument878);  
            			    	stream_SOMETHING.Add(SOMETHING40);


            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements

            	PushFollow(FOLLOW_tikzpicture_in_tikzdocument881);
            	tikzpicture41 = tikzpicture();
            	state.followingStackPointer--;

            	stream_tikzpicture.Add(tikzpicture41.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:134:28: ( SOMETHING )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( (LA12_0 == SOMETHING) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:134:28: SOMETHING
            			    {
            			    	SOMETHING42=(IToken)Match(input,SOMETHING,FOLLOW_SOMETHING_in_tikzdocument884);  
            			    	stream_SOMETHING.Add(SOMETHING42);


            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements



            	// AST REWRITE
            	// elements:          tikzpicture
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 134:40: -> ^( IM_DOCUMENT tikzpicture )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:134:43: ^( IM_DOCUMENT tikzpicture )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_DOCUMENT, "IM_DOCUMENT"), root_1);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:1: tikzpicture : tikzpicture_start ( OPTIONS )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikzbody )? tikzpicture_end ) ;
    public simpletikzParser.tikzpicture_return tikzpicture() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_return retval = new simpletikzParser.tikzpicture_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken OPTIONS44 = null;
        simpletikzParser.tikzpicture_start_return tikzpicture_start43 = default(simpletikzParser.tikzpicture_start_return);

        simpletikzParser.tikzbody_return tikzbody45 = default(simpletikzParser.tikzbody_return);

        simpletikzParser.tikzpicture_end_return tikzpicture_end46 = default(simpletikzParser.tikzpicture_end_return);


        object OPTIONS44_tree=null;
        RewriteRuleTokenStream stream_OPTIONS = new RewriteRuleTokenStream(adaptor,"token OPTIONS");
        RewriteRuleSubtreeStream stream_tikzpicture_end = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_end");
        RewriteRuleSubtreeStream stream_tikzpicture_start = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_start");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:138:2: ( tikzpicture_start ( OPTIONS )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikzbody )? tikzpicture_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:138:5: tikzpicture_start ( OPTIONS )? ( tikzbody )? tikzpicture_end
            {
            	PushFollow(FOLLOW_tikzpicture_start_in_tikzpicture907);
            	tikzpicture_start43 = tikzpicture_start();
            	state.followingStackPointer--;

            	stream_tikzpicture_start.Add(tikzpicture_start43.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:138:23: ( OPTIONS )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == OPTIONS) )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:138:23: OPTIONS
            	        {
            	        	OPTIONS44=(IToken)Match(input,OPTIONS,FOLLOW_OPTIONS_in_tikzpicture909);  
            	        	stream_OPTIONS.Add(OPTIONS44);


            	        }
            	        break;

            	}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:138:32: ( tikzbody )?
            	int alt14 = 2;
            	int LA14_0 = input.LA(1);

            	if ( (LA14_0 == BEGINSCOPE || (LA14_0 >= NODE && LA14_0 <= FILL)) )
            	{
            	    alt14 = 1;
            	}
            	switch (alt14) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:138:32: tikzbody
            	        {
            	        	PushFollow(FOLLOW_tikzbody_in_tikzpicture912);
            	        	tikzbody45 = tikzbody();
            	        	state.followingStackPointer--;

            	        	stream_tikzbody.Add(tikzbody45.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzpicture_end_in_tikzpicture915);
            	tikzpicture_end46 = tikzpicture_end();
            	state.followingStackPointer--;

            	stream_tikzpicture_end.Add(tikzpicture_end46.Tree);


            	// AST REWRITE
            	// elements:          tikzpicture_end, tikzbody, tikzpicture_start
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 138:59: -> ^( IM_PICTURE tikzpicture_start ( tikzbody )? tikzpicture_end )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:138:62: ^( IM_PICTURE tikzpicture_start ( tikzbody )? tikzpicture_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PICTURE, "IM_PICTURE"), root_1);

            	    adaptor.AddChild(root_1, stream_tikzpicture_start.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:138:94: ( tikzbody )?
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:140:1: tikzpicture_start : BEGINTP -> ^( IM_STARTTAG BEGINTP ) ;
    public simpletikzParser.tikzpicture_start_return tikzpicture_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_start_return retval = new simpletikzParser.tikzpicture_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken BEGINTP47 = null;

        object BEGINTP47_tree=null;
        RewriteRuleTokenStream stream_BEGINTP = new RewriteRuleTokenStream(adaptor,"token BEGINTP");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:141:2: ( BEGINTP -> ^( IM_STARTTAG BEGINTP ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:141:4: BEGINTP
            {
            	BEGINTP47=(IToken)Match(input,BEGINTP,FOLLOW_BEGINTP_in_tikzpicture_start940);  
            	stream_BEGINTP.Add(BEGINTP47);



            	// AST REWRITE
            	// elements:          BEGINTP
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 141:12: -> ^( IM_STARTTAG BEGINTP )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:141:15: ^( IM_STARTTAG BEGINTP )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_BEGINTP.NextNode());

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:143:1: tikzpicture_end : ENDTP -> ^( IM_ENDTAG ENDTP ) ;
    public simpletikzParser.tikzpicture_end_return tikzpicture_end() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_end_return retval = new simpletikzParser.tikzpicture_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ENDTP48 = null;

        object ENDTP48_tree=null;
        RewriteRuleTokenStream stream_ENDTP = new RewriteRuleTokenStream(adaptor,"token ENDTP");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:144:2: ( ENDTP -> ^( IM_ENDTAG ENDTP ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:144:4: ENDTP
            {
            	ENDTP48=(IToken)Match(input,ENDTP,FOLLOW_ENDTP_in_tikzpicture_end958);  
            	stream_ENDTP.Add(ENDTP48);



            	// AST REWRITE
            	// elements:          ENDTP
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 144:10: -> ^( IM_ENDTAG ENDTP )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:144:13: ^( IM_ENDTAG ENDTP )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_ENDTP.NextNode());

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:146:1: tikzbody : ( tikzscope | tikzpath | tikznodee )+ ;
    public simpletikzParser.tikzbody_return tikzbody() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzbody_return retval = new simpletikzParser.tikzbody_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_return tikzscope49 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath50 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznodee_return tikznodee51 = default(simpletikzParser.tikznodee_return);



        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:2: ( ( tikzscope | tikzpath | tikznodee )+ )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:4: ( tikzscope | tikzpath | tikznodee )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:4: ( tikzscope | tikzpath | tikznodee )+
            	int cnt15 = 0;
            	do 
            	{
            	    int alt15 = 4;
            	    switch ( input.LA(1) ) 
            	    {
            	    case BEGINSCOPE:
            	    	{
            	        alt15 = 1;
            	        }
            	        break;
            	    case DRAW:
            	    case PATH:
            	    case FILL:
            	    	{
            	        alt15 = 2;
            	        }
            	        break;
            	    case NODE:
            	    	{
            	        alt15 = 3;
            	        }
            	        break;

            	    }

            	    switch (alt15) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:6: tikzscope
            			    {
            			    	PushFollow(FOLLOW_tikzscope_in_tikzbody978);
            			    	tikzscope49 = tikzscope();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, tikzscope49.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:18: tikzpath
            			    {
            			    	PushFollow(FOLLOW_tikzpath_in_tikzbody982);
            			    	tikzpath50 = tikzpath();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, tikzpath50.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:29: tikznodee
            			    {
            			    	PushFollow(FOLLOW_tikznodee_in_tikzbody986);
            			    	tikznodee51 = tikznodee();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, tikznodee51.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt15 >= 1 ) goto loop15;
            		            EarlyExitException eee15 =
            		                new EarlyExitException(15, input);
            		            throw eee15;
            	    }
            	    cnt15++;
            	} while (true);

            	loop15:
            		;	// Stops C# compiler whining that label 'loop15' has no statements


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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:150:1: tikzscope : BEGINSCOPE ( OPTIONS )? tikzbody ENDSCOPE -> ^( IM_SCOPE ^( IM_STARTTAG BEGINSCOPE ) tikzbody ^( IM_ENDTAG ENDSCOPE ) ) ;
    public simpletikzParser.tikzscope_return tikzscope() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_return retval = new simpletikzParser.tikzscope_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken BEGINSCOPE52 = null;
        IToken OPTIONS53 = null;
        IToken ENDSCOPE55 = null;
        simpletikzParser.tikzbody_return tikzbody54 = default(simpletikzParser.tikzbody_return);


        object BEGINSCOPE52_tree=null;
        object OPTIONS53_tree=null;
        object ENDSCOPE55_tree=null;
        RewriteRuleTokenStream stream_ENDSCOPE = new RewriteRuleTokenStream(adaptor,"token ENDSCOPE");
        RewriteRuleTokenStream stream_BEGINSCOPE = new RewriteRuleTokenStream(adaptor,"token BEGINSCOPE");
        RewriteRuleTokenStream stream_OPTIONS = new RewriteRuleTokenStream(adaptor,"token OPTIONS");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:2: ( BEGINSCOPE ( OPTIONS )? tikzbody ENDSCOPE -> ^( IM_SCOPE ^( IM_STARTTAG BEGINSCOPE ) tikzbody ^( IM_ENDTAG ENDSCOPE ) ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:4: BEGINSCOPE ( OPTIONS )? tikzbody ENDSCOPE
            {
            	BEGINSCOPE52=(IToken)Match(input,BEGINSCOPE,FOLLOW_BEGINSCOPE_in_tikzscope999);  
            	stream_BEGINSCOPE.Add(BEGINSCOPE52);

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:15: ( OPTIONS )?
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( (LA16_0 == OPTIONS) )
            	{
            	    alt16 = 1;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:15: OPTIONS
            	        {
            	        	OPTIONS53=(IToken)Match(input,OPTIONS,FOLLOW_OPTIONS_in_tikzscope1001);  
            	        	stream_OPTIONS.Add(OPTIONS53);


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzbody_in_tikzscope1004);
            	tikzbody54 = tikzbody();
            	state.followingStackPointer--;

            	stream_tikzbody.Add(tikzbody54.Tree);
            	ENDSCOPE55=(IToken)Match(input,ENDSCOPE,FOLLOW_ENDSCOPE_in_tikzscope1006);  
            	stream_ENDSCOPE.Add(ENDSCOPE55);



            	// AST REWRITE
            	// elements:          ENDSCOPE, BEGINSCOPE, tikzbody
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 151:43: -> ^( IM_SCOPE ^( IM_STARTTAG BEGINSCOPE ) tikzbody ^( IM_ENDTAG ENDSCOPE ) )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:46: ^( IM_SCOPE ^( IM_STARTTAG BEGINSCOPE ) tikzbody ^( IM_ENDTAG ENDSCOPE ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_SCOPE, "IM_SCOPE"), root_1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:57: ^( IM_STARTTAG BEGINSCOPE )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_2);

            	    adaptor.AddChild(root_2, stream_BEGINSCOPE.NextNode());

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    adaptor.AddChild(root_1, stream_tikzbody.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:92: ^( IM_ENDTAG ENDSCOPE )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_2);

            	    adaptor.AddChild(root_2, stream_ENDSCOPE.NextNode());

            	    adaptor.AddChild(root_1, root_2);
            	    }

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

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_path_start_in_tikzpath420 = new BitSet(new ulong[]{0x4010000000004000UL,0x0000000000000060UL});
    public static readonly BitSet FOLLOW_tikzpathi_in_tikzpath422 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_path_end_in_tikzpath424 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SEMIC_in_path_end447 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OPTIONS_in_tikzpathi467 = new BitSet(new ulong[]{0x4010000000004000UL,0x0000000000000060UL});
    public static readonly BitSet FOLLOW_coordornode_in_tikzpathi472 = new BitSet(new ulong[]{0xC010000000004002UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_coordornode_in_tikzpathi475 = new BitSet(new ulong[]{0xC010000000004002UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_OPTIONS_in_tikzpathi480 = new BitSet(new ulong[]{0xC010000000004000UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_edgeop_in_tikzpathi485 = new BitSet(new ulong[]{0x4010000000004000UL,0x0000000000000060UL});
    public static readonly BitSet FOLLOW_coordornode_in_tikzpathi488 = new BitSet(new ulong[]{0xC010000000004002UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_coord_in_coordornode503 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznodei_in_coordornode507 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_62_in_tikznodei519 = new BitSet(new ulong[]{0x0030000004004000UL});
    public static readonly BitSet FOLLOW_tikznode_in_tikznodei522 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_node_start_in_tikznodee532 = new BitSet(new ulong[]{0x0030000004004000UL});
    public static readonly BitSet FOLLOW_tikznode_in_tikznodee534 = new BitSet(new ulong[]{0x4010000000004000UL,0x0000000000000060UL});
    public static readonly BitSet FOLLOW_tikzpathi_in_tikznodee536 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_path_end_in_tikznodee538 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NODE_in_node_start563 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OPTIONS_in_tikznode581 = new BitSet(new ulong[]{0x0020000004004000UL});
    public static readonly BitSet FOLLOW_nodename_in_tikznode584 = new BitSet(new ulong[]{0x0020000004000000UL});
    public static readonly BitSet FOLLOW_AT_in_tikznode588 = new BitSet(new ulong[]{0x0000000000004000UL,0x0000000000000060UL});
    public static readonly BitSet FOLLOW_coord_in_tikznode590 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_STRING_in_tikznode594 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_edgeop0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAR_in_nodename662 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_ID_in_nodename666 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RPAR_in_nodename668 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_coord693 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord717 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LPAR_in_coord722 = new BitSet(new ulong[]{0x0180000000000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord724 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_KOMMA_in_coord726 = new BitSet(new ulong[]{0x0180000000000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord728 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RPAR_in_coord730 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_coord_modifier0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_number_in_numberunit772 = new BitSet(new ulong[]{0x0000034000000002UL,0x0000000000000180UL});
    public static readonly BitSet FOLLOW_unit_in_numberunit774 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_number797 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unit0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_tag_in_path_start841 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_path_start_tag0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SOMETHING_in_tikzdocument878 = new BitSet(new ulong[]{0x0200000000000040UL});
    public static readonly BitSet FOLLOW_tikzpicture_in_tikzdocument881 = new BitSet(new ulong[]{0x0200000000000002UL});
    public static readonly BitSet FOLLOW_SOMETHING_in_tikzdocument884 = new BitSet(new ulong[]{0x0200000000000002UL});
    public static readonly BitSet FOLLOW_tikzpicture_start_in_tikzpicture907 = new BitSet(new ulong[]{0x0010000000003D80UL});
    public static readonly BitSet FOLLOW_OPTIONS_in_tikzpicture909 = new BitSet(new ulong[]{0x0010000000003D80UL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzpicture912 = new BitSet(new ulong[]{0x0010000000003D80UL});
    public static readonly BitSet FOLLOW_tikzpicture_end_in_tikzpicture915 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BEGINTP_in_tikzpicture_start940 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ENDTP_in_tikzpicture_end958 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody978 = new BitSet(new ulong[]{0x0000000000003D02UL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody982 = new BitSet(new ulong[]{0x0000000000003D02UL});
    public static readonly BitSet FOLLOW_tikznodee_in_tikzbody986 = new BitSet(new ulong[]{0x0000000000003D02UL});
    public static readonly BitSet FOLLOW_BEGINSCOPE_in_tikzscope999 = new BitSet(new ulong[]{0x0010000000003D00UL});
    public static readonly BitSet FOLLOW_OPTIONS_in_tikzscope1001 = new BitSet(new ulong[]{0x0000000000003D00UL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzscope1004 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_ENDSCOPE_in_tikzscope1006 = new BitSet(new ulong[]{0x0000000000000002UL});

}
