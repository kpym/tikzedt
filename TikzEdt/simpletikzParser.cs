// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g 2010-11-25 01:48:44

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:71:1: tikzpath : path_start tikzpathi ;
    public simpletikzParser.tikzpath_return tikzpath() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_return retval = new simpletikzParser.tikzpath_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.path_start_return path_start1 = default(simpletikzParser.path_start_return);

        simpletikzParser.tikzpathi_return tikzpathi2 = default(simpletikzParser.tikzpathi_return);



        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:72:2: ( path_start tikzpathi )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:72:4: path_start tikzpathi
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_path_start_in_tikzpath420);
            	path_start1 = path_start();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_tikzpathi_in_tikzpath423);
            	tikzpathi2 = tikzpathi();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, tikzpathi2.Tree);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:75:1: tikzpathi : ( OPTIONS )? coordornode ( coordornode | ( OPTIONS )? edgeop coordornode )* SEMIC -> ^( IM_PATH ( coordornode )+ ) ;
    public simpletikzParser.tikzpathi_return tikzpathi() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpathi_return retval = new simpletikzParser.tikzpathi_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken OPTIONS3 = null;
        IToken OPTIONS6 = null;
        IToken SEMIC9 = null;
        simpletikzParser.coordornode_return coordornode4 = default(simpletikzParser.coordornode_return);

        simpletikzParser.coordornode_return coordornode5 = default(simpletikzParser.coordornode_return);

        simpletikzParser.edgeop_return edgeop7 = default(simpletikzParser.edgeop_return);

        simpletikzParser.coordornode_return coordornode8 = default(simpletikzParser.coordornode_return);


        object OPTIONS3_tree=null;
        object OPTIONS6_tree=null;
        object SEMIC9_tree=null;
        RewriteRuleTokenStream stream_SEMIC = new RewriteRuleTokenStream(adaptor,"token SEMIC");
        RewriteRuleTokenStream stream_OPTIONS = new RewriteRuleTokenStream(adaptor,"token OPTIONS");
        RewriteRuleSubtreeStream stream_coordornode = new RewriteRuleSubtreeStream(adaptor,"rule coordornode");
        RewriteRuleSubtreeStream stream_edgeop = new RewriteRuleSubtreeStream(adaptor,"rule edgeop");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:2: ( ( OPTIONS )? coordornode ( coordornode | ( OPTIONS )? edgeop coordornode )* SEMIC -> ^( IM_PATH ( coordornode )+ ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:4: ( OPTIONS )? coordornode ( coordornode | ( OPTIONS )? edgeop coordornode )* SEMIC
            {
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:4: ( OPTIONS )?
            	int alt1 = 2;
            	int LA1_0 = input.LA(1);

            	if ( (LA1_0 == OPTIONS) )
            	{
            	    alt1 = 1;
            	}
            	switch (alt1) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:4: OPTIONS
            	        {
            	        	OPTIONS3=(IToken)Match(input,OPTIONS,FOLLOW_OPTIONS_in_tikzpathi434);  
            	        	stream_OPTIONS.Add(OPTIONS3);


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_coordornode_in_tikzpathi437);
            	coordornode4 = coordornode();
            	state.followingStackPointer--;

            	stream_coordornode.Add(coordornode4.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:25: ( coordornode | ( OPTIONS )? edgeop coordornode )*
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
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:26: coordornode
            			    {
            			    	PushFollow(FOLLOW_coordornode_in_tikzpathi440);
            			    	coordornode5 = coordornode();
            			    	state.followingStackPointer--;

            			    	stream_coordornode.Add(coordornode5.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:40: ( OPTIONS )? edgeop coordornode
            			    {
            			    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:40: ( OPTIONS )?
            			    	int alt2 = 2;
            			    	int LA2_0 = input.LA(1);

            			    	if ( (LA2_0 == OPTIONS) )
            			    	{
            			    	    alt2 = 1;
            			    	}
            			    	switch (alt2) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:40: OPTIONS
            			    	        {
            			    	        	OPTIONS6=(IToken)Match(input,OPTIONS,FOLLOW_OPTIONS_in_tikzpathi444);  
            			    	        	stream_OPTIONS.Add(OPTIONS6);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_edgeop_in_tikzpathi447);
            			    	edgeop7 = edgeop();
            			    	state.followingStackPointer--;

            			    	stream_edgeop.Add(edgeop7.Tree);
            			    	PushFollow(FOLLOW_coordornode_in_tikzpathi449);
            			    	coordornode8 = coordornode();
            			    	state.followingStackPointer--;

            			    	stream_coordornode.Add(coordornode8.Tree);

            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements

            	SEMIC9=(IToken)Match(input,SEMIC,FOLLOW_SEMIC_in_tikzpathi454);  
            	stream_SEMIC.Add(SEMIC9);



            	// AST REWRITE
            	// elements:          coordornode
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 76:79: -> ^( IM_PATH ( coordornode )+ )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:82: ^( IM_PATH ( coordornode )+ )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    if ( !(stream_coordornode.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_coordornode.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_coordornode.NextTree());

            	    }
            	    stream_coordornode.Reset();

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:79:1: coordornode : ( coord | tikznodei );
    public simpletikzParser.coordornode_return coordornode() // throws RecognitionException [1]
    {   
        simpletikzParser.coordornode_return retval = new simpletikzParser.coordornode_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.coord_return coord10 = default(simpletikzParser.coord_return);

        simpletikzParser.tikznodei_return tikznodei11 = default(simpletikzParser.tikznodei_return);



        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:80:2: ( coord | tikznodei )
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
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:80:4: coord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_coord_in_coordornode477);
                    	coord10 = coord();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, coord10.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:80:12: tikznodei
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikznodei_in_coordornode481);
                    	tikznodei11 = tikznodei();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, tikznodei11.Tree);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:83:1: tikznodei : 'node' tikznode ;
    public simpletikzParser.tikznodei_return tikznodei() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznodei_return retval = new simpletikzParser.tikznodei_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal12 = null;
        simpletikzParser.tikznode_return tikznode13 = default(simpletikzParser.tikznode_return);


        object string_literal12_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:84:2: ( 'node' tikznode )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:84:4: 'node' tikznode
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal12=(IToken)Match(input,62,FOLLOW_62_in_tikznodei493); 
            	PushFollow(FOLLOW_tikznode_in_tikznodei496);
            	tikznode13 = tikznode();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, tikznode13.Tree);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:86:1: tikznodee : NODE tikznode tikzpathi ;
    public simpletikzParser.tikznodee_return tikznodee() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznodee_return retval = new simpletikzParser.tikznodee_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NODE14 = null;
        simpletikzParser.tikznode_return tikznode15 = default(simpletikzParser.tikznode_return);

        simpletikzParser.tikzpathi_return tikzpathi16 = default(simpletikzParser.tikzpathi_return);


        object NODE14_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:87:2: ( NODE tikznode tikzpathi )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:87:4: NODE tikznode tikzpathi
            {
            	root_0 = (object)adaptor.GetNilNode();

            	NODE14=(IToken)Match(input,NODE,FOLLOW_NODE_in_tikznodee506); 
            		NODE14_tree = (object)adaptor.Create(NODE14);
            		adaptor.AddChild(root_0, NODE14_tree);

            	PushFollow(FOLLOW_tikznode_in_tikznodee508);
            	tikznode15 = tikznode();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, tikznode15.Tree);
            	PushFollow(FOLLOW_tikzpathi_in_tikznodee510);
            	tikzpathi16 = tikzpathi();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, tikzpathi16.Tree);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:1: tikznode : ( OPTIONS )? ( nodename )? ( 'at' coord )? STRING -> ^( IM_NODE ( OPTIONS )? ( nodename )? ( coord )? STRING ) ;
    public simpletikzParser.tikznode_return tikznode() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_return retval = new simpletikzParser.tikznode_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken OPTIONS17 = null;
        IToken string_literal19 = null;
        IToken STRING21 = null;
        simpletikzParser.nodename_return nodename18 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_return coord20 = default(simpletikzParser.coord_return);


        object OPTIONS17_tree=null;
        object string_literal19_tree=null;
        object STRING21_tree=null;
        RewriteRuleTokenStream stream_AT = new RewriteRuleTokenStream(adaptor,"token AT");
        RewriteRuleTokenStream stream_OPTIONS = new RewriteRuleTokenStream(adaptor,"token OPTIONS");
        RewriteRuleTokenStream stream_STRING = new RewriteRuleTokenStream(adaptor,"token STRING");
        RewriteRuleSubtreeStream stream_coord = new RewriteRuleSubtreeStream(adaptor,"rule coord");
        RewriteRuleSubtreeStream stream_nodename = new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:2: ( ( OPTIONS )? ( nodename )? ( 'at' coord )? STRING -> ^( IM_NODE ( OPTIONS )? ( nodename )? ( coord )? STRING ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:4: ( OPTIONS )? ( nodename )? ( 'at' coord )? STRING
            {
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:4: ( OPTIONS )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == OPTIONS) )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:4: OPTIONS
            	        {
            	        	OPTIONS17=(IToken)Match(input,OPTIONS,FOLLOW_OPTIONS_in_tikznode520);  
            	        	stream_OPTIONS.Add(OPTIONS17);


            	        }
            	        break;

            	}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:13: ( nodename )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( (LA6_0 == LPAR) )
            	{
            	    alt6 = 1;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:13: nodename
            	        {
            	        	PushFollow(FOLLOW_nodename_in_tikznode523);
            	        	nodename18 = nodename();
            	        	state.followingStackPointer--;

            	        	stream_nodename.Add(nodename18.Tree);

            	        }
            	        break;

            	}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:23: ( 'at' coord )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( (LA7_0 == AT) )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:24: 'at' coord
            	        {
            	        	string_literal19=(IToken)Match(input,AT,FOLLOW_AT_in_tikznode527);  
            	        	stream_AT.Add(string_literal19);

            	        	PushFollow(FOLLOW_coord_in_tikznode529);
            	        	coord20 = coord();
            	        	state.followingStackPointer--;

            	        	stream_coord.Add(coord20.Tree);

            	        }
            	        break;

            	}

            	STRING21=(IToken)Match(input,STRING,FOLLOW_STRING_in_tikznode533);  
            	stream_STRING.Add(STRING21);



            	// AST REWRITE
            	// elements:          STRING, coord, nodename, OPTIONS
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 90:45: -> ^( IM_NODE ( OPTIONS )? ( nodename )? ( coord )? STRING )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:48: ^( IM_NODE ( OPTIONS )? ( nodename )? ( coord )? STRING )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NODE, "IM_NODE"), root_1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:58: ( OPTIONS )?
            	    if ( stream_OPTIONS.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_OPTIONS.NextNode());

            	    }
            	    stream_OPTIONS.Reset();
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:67: ( nodename )?
            	    if ( stream_nodename.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_nodename.NextTree());

            	    }
            	    stream_nodename.Reset();
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:77: ( coord )?
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:93:1: edgeop : ( '--' | 'edge' | '->' | '|-' | '-|' | 'to' );
    public simpletikzParser.edgeop_return edgeop() // throws RecognitionException [1]
    {   
        simpletikzParser.edgeop_return retval = new simpletikzParser.edgeop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set22 = null;

        object set22_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:94:2: ( '--' | 'edge' | '->' | '|-' | '-|' | 'to' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set22 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 63 && input.LA(1) <= 68) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set22));
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:97:1: nodename : lc= LPAR id= ID RPAR -> ^( IM_NODENAME[$lc] $id) ;
    public simpletikzParser.nodename_return nodename() // throws RecognitionException [1]
    {   
        simpletikzParser.nodename_return retval = new simpletikzParser.nodename_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken lc = null;
        IToken id = null;
        IToken RPAR23 = null;

        object lc_tree=null;
        object id_tree=null;
        object RPAR23_tree=null;
        RewriteRuleTokenStream stream_RPAR = new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR = new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:98:2: (lc= LPAR id= ID RPAR -> ^( IM_NODENAME[$lc] $id) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:98:4: lc= LPAR id= ID RPAR
            {
            	lc=(IToken)Match(input,LPAR,FOLLOW_LPAR_in_nodename601);  
            	stream_LPAR.Add(lc);

            	id=(IToken)Match(input,ID,FOLLOW_ID_in_nodename605);  
            	stream_ID.Add(id);

            	RPAR23=(IToken)Match(input,RPAR,FOLLOW_RPAR_in_nodename607);  
            	stream_RPAR.Add(RPAR23);



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
            	// 98:24: -> ^( IM_NODENAME[$lc] $id)
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:98:27: ^( IM_NODENAME[$lc] $id)
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:101:1: coord : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR ) -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ ) );
    public simpletikzParser.coord_return coord() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_return retval = new simpletikzParser.coord_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken lc = null;
        IToken KOMMA27 = null;
        IToken RPAR29 = null;
        simpletikzParser.nodename_return nodename24 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_modifier_return coord_modifier25 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.numberunit_return numberunit26 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit28 = default(simpletikzParser.numberunit_return);


        object lc_tree=null;
        object KOMMA27_tree=null;
        object RPAR29_tree=null;
        RewriteRuleTokenStream stream_RPAR = new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR = new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleTokenStream stream_KOMMA = new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_nodename = new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        RewriteRuleSubtreeStream stream_coord_modifier = new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:102:2: ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR ) -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ ) )
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
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:102:6: nodename
                    {
                    	PushFollow(FOLLOW_nodename_in_coord632);
                    	nodename24 = nodename();
                    	state.followingStackPointer--;

                    	stream_nodename.Add(nodename24.Tree);


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
                    	// 102:23: -> ^( IM_COORD nodename )
                    	{
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:102:26: ^( IM_COORD nodename )
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
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:103:5: ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR )
                    {
                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:103:5: ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR )
                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:103:7: ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR
                    	{
                    		// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:103:7: ( coord_modifier )?
                    		int alt8 = 2;
                    		int LA8_0 = input.LA(1);

                    		if ( ((LA8_0 >= 69 && LA8_0 <= 70)) )
                    		{
                    		    alt8 = 1;
                    		}
                    		switch (alt8) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:103:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord656);
                    		        	coord_modifier25 = coord_modifier();
                    		        	state.followingStackPointer--;

                    		        	stream_coord_modifier.Add(coord_modifier25.Tree);

                    		        }
                    		        break;

                    		}

                    		lc=(IToken)Match(input,LPAR,FOLLOW_LPAR_in_coord661);  
                    		stream_LPAR.Add(lc);

                    		PushFollow(FOLLOW_numberunit_in_coord663);
                    		numberunit26 = numberunit();
                    		state.followingStackPointer--;

                    		stream_numberunit.Add(numberunit26.Tree);
                    		KOMMA27=(IToken)Match(input,KOMMA,FOLLOW_KOMMA_in_coord665);  
                    		stream_KOMMA.Add(KOMMA27);

                    		PushFollow(FOLLOW_numberunit_in_coord667);
                    		numberunit28 = numberunit();
                    		state.followingStackPointer--;

                    		stream_numberunit.Add(numberunit28.Tree);
                    		RPAR29=(IToken)Match(input,RPAR,FOLLOW_RPAR_in_coord669);  
                    		stream_RPAR.Add(RPAR29);


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
                    	// 103:66: -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ )
                    	{
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:103:69: ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, lc), root_1);

                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:103:85: ( coord_modifier )?
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:106:1: coord_modifier : ( '+' | '++' );
    public simpletikzParser.coord_modifier_return coord_modifier() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_modifier_return retval = new simpletikzParser.coord_modifier_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set30 = null;

        object set30_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:107:2: ( '+' | '++' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set30 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 69 && input.LA(1) <= 70) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set30));
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:110:1: numberunit : number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) ;
    public simpletikzParser.numberunit_return numberunit() // throws RecognitionException [1]
    {   
        simpletikzParser.numberunit_return retval = new simpletikzParser.numberunit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.number_return number31 = default(simpletikzParser.number_return);

        simpletikzParser.unit_return unit32 = default(simpletikzParser.unit_return);


        RewriteRuleSubtreeStream stream_unit = new RewriteRuleSubtreeStream(adaptor,"rule unit");
        RewriteRuleSubtreeStream stream_number = new RewriteRuleSubtreeStream(adaptor,"rule number");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:111:2: ( number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:111:4: number ( unit )?
            {
            	PushFollow(FOLLOW_number_in_numberunit711);
            	number31 = number();
            	state.followingStackPointer--;

            	stream_number.Add(number31.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:111:11: ( unit )?
            	int alt10 = 2;
            	int LA10_0 = input.LA(1);

            	if ( (LA10_0 == IN || (LA10_0 >= UN_PTS && LA10_0 <= UN_CM) || (LA10_0 >= 71 && LA10_0 <= 72)) )
            	{
            	    alt10 = 1;
            	}
            	switch (alt10) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:111:11: unit
            	        {
            	        	PushFollow(FOLLOW_unit_in_numberunit713);
            	        	unit32 = unit();
            	        	state.followingStackPointer--;

            	        	stream_unit.Add(unit32.Tree);

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
            	// 111:17: -> ^( IM_NUMBERUNIT number ( unit )? )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:111:20: ^( IM_NUMBERUNIT number ( unit )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NUMBERUNIT, "IM_NUMBERUNIT"), root_1);

            	    adaptor.AddChild(root_1, stream_number.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:111:43: ( unit )?
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:113:1: number : ( FLOAT | INT ) ;
    public simpletikzParser.number_return number() // throws RecognitionException [1]
    {   
        simpletikzParser.number_return retval = new simpletikzParser.number_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set33 = null;

        object set33_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:114:2: ( ( FLOAT | INT ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:114:4: ( FLOAT | INT )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set33 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= FLOAT && input.LA(1) <= INT) ) 
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:116:1: unit : ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' );
    public simpletikzParser.unit_return unit() // throws RecognitionException [1]
    {   
        simpletikzParser.unit_return retval = new simpletikzParser.unit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set34 = null;

        object set34_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:2: ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set34 = (IToken)input.LT(1);
            	if ( input.LA(1) == IN || (input.LA(1) >= UN_PTS && input.LA(1) <= UN_CM) || (input.LA(1) >= 71 && input.LA(1) <= 72) ) 
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:120:1: path_start : ( DRAW | FILL | PATH );
    public simpletikzParser.path_start_return path_start() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_return retval = new simpletikzParser.path_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set35 = null;

        object set35_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:2: ( DRAW | FILL | PATH )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set35 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= DRAW && input.LA(1) <= FILL) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set35));
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
    // $ANTLR end "path_start"

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:124:1: tikzdocument : ( SOMETHING )* tikzpicture ( SOMETHING )* -> ^( IM_DOCUMENT tikzpicture ) ;
    public simpletikzParser.tikzdocument_return tikzdocument() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzdocument_return retval = new simpletikzParser.tikzdocument_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken SOMETHING36 = null;
        IToken SOMETHING38 = null;
        simpletikzParser.tikzpicture_return tikzpicture37 = default(simpletikzParser.tikzpicture_return);


        object SOMETHING36_tree=null;
        object SOMETHING38_tree=null;
        RewriteRuleTokenStream stream_SOMETHING = new RewriteRuleTokenStream(adaptor,"token SOMETHING");
        RewriteRuleSubtreeStream stream_tikzpicture = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:125:2: ( ( SOMETHING )* tikzpicture ( SOMETHING )* -> ^( IM_DOCUMENT tikzpicture ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:125:4: ( SOMETHING )* tikzpicture ( SOMETHING )*
            {
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:125:4: ( SOMETHING )*
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
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:125:4: SOMETHING
            			    {
            			    	SOMETHING36=(IToken)Match(input,SOMETHING,FOLLOW_SOMETHING_in_tikzdocument799);  
            			    	stream_SOMETHING.Add(SOMETHING36);


            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements

            	PushFollow(FOLLOW_tikzpicture_in_tikzdocument802);
            	tikzpicture37 = tikzpicture();
            	state.followingStackPointer--;

            	stream_tikzpicture.Add(tikzpicture37.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:125:28: ( SOMETHING )*
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
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:125:28: SOMETHING
            			    {
            			    	SOMETHING38=(IToken)Match(input,SOMETHING,FOLLOW_SOMETHING_in_tikzdocument805);  
            			    	stream_SOMETHING.Add(SOMETHING38);


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
            	// 125:40: -> ^( IM_DOCUMENT tikzpicture )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:125:43: ^( IM_DOCUMENT tikzpicture )
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:128:1: tikzpicture : BEGINTP ( OPTIONS )? ( tikzbody )? ENDTP -> ^( IM_PICTURE ( tikzbody )? ) ;
    public simpletikzParser.tikzpicture_return tikzpicture() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_return retval = new simpletikzParser.tikzpicture_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken BEGINTP39 = null;
        IToken OPTIONS40 = null;
        IToken ENDTP42 = null;
        simpletikzParser.tikzbody_return tikzbody41 = default(simpletikzParser.tikzbody_return);


        object BEGINTP39_tree=null;
        object OPTIONS40_tree=null;
        object ENDTP42_tree=null;
        RewriteRuleTokenStream stream_BEGINTP = new RewriteRuleTokenStream(adaptor,"token BEGINTP");
        RewriteRuleTokenStream stream_ENDTP = new RewriteRuleTokenStream(adaptor,"token ENDTP");
        RewriteRuleTokenStream stream_OPTIONS = new RewriteRuleTokenStream(adaptor,"token OPTIONS");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:2: ( BEGINTP ( OPTIONS )? ( tikzbody )? ENDTP -> ^( IM_PICTURE ( tikzbody )? ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:5: BEGINTP ( OPTIONS )? ( tikzbody )? ENDTP
            {
            	BEGINTP39=(IToken)Match(input,BEGINTP,FOLLOW_BEGINTP_in_tikzpicture828);  
            	stream_BEGINTP.Add(BEGINTP39);

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:13: ( OPTIONS )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == OPTIONS) )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:13: OPTIONS
            	        {
            	        	OPTIONS40=(IToken)Match(input,OPTIONS,FOLLOW_OPTIONS_in_tikzpicture830);  
            	        	stream_OPTIONS.Add(OPTIONS40);


            	        }
            	        break;

            	}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:22: ( tikzbody )?
            	int alt14 = 2;
            	int LA14_0 = input.LA(1);

            	if ( (LA14_0 == BEGINSCOPE || (LA14_0 >= NODE && LA14_0 <= FILL)) )
            	{
            	    alt14 = 1;
            	}
            	switch (alt14) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:22: tikzbody
            	        {
            	        	PushFollow(FOLLOW_tikzbody_in_tikzpicture833);
            	        	tikzbody41 = tikzbody();
            	        	state.followingStackPointer--;

            	        	stream_tikzbody.Add(tikzbody41.Tree);

            	        }
            	        break;

            	}

            	ENDTP42=(IToken)Match(input,ENDTP,FOLLOW_ENDTP_in_tikzpicture836);  
            	stream_ENDTP.Add(ENDTP42);



            	// AST REWRITE
            	// elements:          tikzbody
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 129:39: -> ^( IM_PICTURE ( tikzbody )? )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:42: ^( IM_PICTURE ( tikzbody )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PICTURE, "IM_PICTURE"), root_1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:55: ( tikzbody )?
            	    if ( stream_tikzbody.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzbody.NextTree());

            	    }
            	    stream_tikzbody.Reset();

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:132:1: tikzbody : ( tikzscope | tikzpath | tikznodee )+ ;
    public simpletikzParser.tikzbody_return tikzbody() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzbody_return retval = new simpletikzParser.tikzbody_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_return tikzscope43 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath44 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznodee_return tikznodee45 = default(simpletikzParser.tikznodee_return);



        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:133:2: ( ( tikzscope | tikzpath | tikznodee )+ )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:133:4: ( tikzscope | tikzpath | tikznodee )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:133:4: ( tikzscope | tikzpath | tikznodee )+
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
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:133:6: tikzscope
            			    {
            			    	PushFollow(FOLLOW_tikzscope_in_tikzbody859);
            			    	tikzscope43 = tikzscope();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, tikzscope43.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:133:18: tikzpath
            			    {
            			    	PushFollow(FOLLOW_tikzpath_in_tikzbody863);
            			    	tikzpath44 = tikzpath();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, tikzpath44.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:133:29: tikznodee
            			    {
            			    	PushFollow(FOLLOW_tikznodee_in_tikzbody867);
            			    	tikznodee45 = tikznodee();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, tikznodee45.Tree);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:136:1: tikzscope : BEGINSCOPE ( OPTIONS )? tikzbody ENDSCOPE -> ^( IM_SCOPE tikzbody ) ;
    public simpletikzParser.tikzscope_return tikzscope() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_return retval = new simpletikzParser.tikzscope_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken BEGINSCOPE46 = null;
        IToken OPTIONS47 = null;
        IToken ENDSCOPE49 = null;
        simpletikzParser.tikzbody_return tikzbody48 = default(simpletikzParser.tikzbody_return);


        object BEGINSCOPE46_tree=null;
        object OPTIONS47_tree=null;
        object ENDSCOPE49_tree=null;
        RewriteRuleTokenStream stream_ENDSCOPE = new RewriteRuleTokenStream(adaptor,"token ENDSCOPE");
        RewriteRuleTokenStream stream_BEGINSCOPE = new RewriteRuleTokenStream(adaptor,"token BEGINSCOPE");
        RewriteRuleTokenStream stream_OPTIONS = new RewriteRuleTokenStream(adaptor,"token OPTIONS");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:2: ( BEGINSCOPE ( OPTIONS )? tikzbody ENDSCOPE -> ^( IM_SCOPE tikzbody ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:4: BEGINSCOPE ( OPTIONS )? tikzbody ENDSCOPE
            {
            	BEGINSCOPE46=(IToken)Match(input,BEGINSCOPE,FOLLOW_BEGINSCOPE_in_tikzscope880);  
            	stream_BEGINSCOPE.Add(BEGINSCOPE46);

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:15: ( OPTIONS )?
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( (LA16_0 == OPTIONS) )
            	{
            	    alt16 = 1;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:15: OPTIONS
            	        {
            	        	OPTIONS47=(IToken)Match(input,OPTIONS,FOLLOW_OPTIONS_in_tikzscope882);  
            	        	stream_OPTIONS.Add(OPTIONS47);


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzbody_in_tikzscope885);
            	tikzbody48 = tikzbody();
            	state.followingStackPointer--;

            	stream_tikzbody.Add(tikzbody48.Tree);
            	ENDSCOPE49=(IToken)Match(input,ENDSCOPE,FOLLOW_ENDSCOPE_in_tikzscope887);  
            	stream_ENDSCOPE.Add(ENDSCOPE49);



            	// AST REWRITE
            	// elements:          tikzbody
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 137:43: -> ^( IM_SCOPE tikzbody )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:46: ^( IM_SCOPE tikzbody )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_SCOPE, "IM_SCOPE"), root_1);

            	    adaptor.AddChild(root_1, stream_tikzbody.NextTree());

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
    public static readonly BitSet FOLLOW_tikzpathi_in_tikzpath423 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OPTIONS_in_tikzpathi434 = new BitSet(new ulong[]{0x4010000000004000UL,0x0000000000000060UL});
    public static readonly BitSet FOLLOW_coordornode_in_tikzpathi437 = new BitSet(new ulong[]{0xC010000000804000UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_coordornode_in_tikzpathi440 = new BitSet(new ulong[]{0xC010000000804000UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_OPTIONS_in_tikzpathi444 = new BitSet(new ulong[]{0xC010000000004000UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_edgeop_in_tikzpathi447 = new BitSet(new ulong[]{0x4010000000004000UL,0x0000000000000060UL});
    public static readonly BitSet FOLLOW_coordornode_in_tikzpathi449 = new BitSet(new ulong[]{0xC010000000804000UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_SEMIC_in_tikzpathi454 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_in_coordornode477 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznodei_in_coordornode481 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_62_in_tikznodei493 = new BitSet(new ulong[]{0x0030000004004000UL});
    public static readonly BitSet FOLLOW_tikznode_in_tikznodei496 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NODE_in_tikznodee506 = new BitSet(new ulong[]{0x0030000004004000UL});
    public static readonly BitSet FOLLOW_tikznode_in_tikznodee508 = new BitSet(new ulong[]{0x4010000000004000UL,0x0000000000000060UL});
    public static readonly BitSet FOLLOW_tikzpathi_in_tikznodee510 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OPTIONS_in_tikznode520 = new BitSet(new ulong[]{0x0020000004004000UL});
    public static readonly BitSet FOLLOW_nodename_in_tikznode523 = new BitSet(new ulong[]{0x0020000004000000UL});
    public static readonly BitSet FOLLOW_AT_in_tikznode527 = new BitSet(new ulong[]{0x0000000000004000UL,0x0000000000000060UL});
    public static readonly BitSet FOLLOW_coord_in_tikznode529 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_STRING_in_tikznode533 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_edgeop0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAR_in_nodename601 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_ID_in_nodename605 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RPAR_in_nodename607 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_coord632 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord656 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LPAR_in_coord661 = new BitSet(new ulong[]{0x0180000000000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord663 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_KOMMA_in_coord665 = new BitSet(new ulong[]{0x0180000000000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord667 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RPAR_in_coord669 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_coord_modifier0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_number_in_numberunit711 = new BitSet(new ulong[]{0x0000034000000002UL,0x0000000000000180UL});
    public static readonly BitSet FOLLOW_unit_in_numberunit713 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_number736 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unit0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_path_start0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SOMETHING_in_tikzdocument799 = new BitSet(new ulong[]{0x0200000000000040UL});
    public static readonly BitSet FOLLOW_tikzpicture_in_tikzdocument802 = new BitSet(new ulong[]{0x0200000000000002UL});
    public static readonly BitSet FOLLOW_SOMETHING_in_tikzdocument805 = new BitSet(new ulong[]{0x0200000000000002UL});
    public static readonly BitSet FOLLOW_BEGINTP_in_tikzpicture828 = new BitSet(new ulong[]{0x0010000000003D80UL});
    public static readonly BitSet FOLLOW_OPTIONS_in_tikzpicture830 = new BitSet(new ulong[]{0x0000000000003D80UL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzpicture833 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_ENDTP_in_tikzpicture836 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody859 = new BitSet(new ulong[]{0x0000000000003D02UL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody863 = new BitSet(new ulong[]{0x0000000000003D02UL});
    public static readonly BitSet FOLLOW_tikznodee_in_tikzbody867 = new BitSet(new ulong[]{0x0000000000003D02UL});
    public static readonly BitSet FOLLOW_BEGINSCOPE_in_tikzscope880 = new BitSet(new ulong[]{0x0010000000003D00UL});
    public static readonly BitSet FOLLOW_OPTIONS_in_tikzscope882 = new BitSet(new ulong[]{0x0000000000003D00UL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzscope885 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_ENDSCOPE_in_tikzscope887 = new BitSet(new ulong[]{0x0000000000000002UL});

}
