// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g 2010-11-23 13:32:35

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
		"IM_COORDDECO", 
		"IM_NODENAME", 
		"OPTIONS", 
		"STRING", 
		"ID", 
		"FLOAT", 
		"INT", 
		"EXPONENT", 
		"COMMENT", 
		"WS", 
		"ESC_SEQ", 
		"SOMETHING", 
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

    public const int EXPONENT = 48;
    public const int T__62 = 62;
    public const int T__63 = 63;
    public const int IM_PATH = 38;
    public const int RBR = 13;
    public const int ST_LINEWIDTH = 31;
    public const int ST_DASHSTYLE = 32;
    public const int ST_FILL = 27;
    public const int FLOAT = 46;
    public const int SOMETHING = 52;
    public const int ID = 45;
    public const int T__61 = 61;
    public const int T__60 = 60;
    public const int EOF = -1;
    public const int LBR = 12;
    public const int T__55 = 55;
    public const int AT = 22;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int RBRR = 15;
    public const int ESC_SEQ = 51;
    public const int IN = 34;
    public const int T__53 = 53;
    public const int LPAR = 10;
    public const int EVERYLOOP = 24;
    public const int T__54 = 54;
    public const int FILL = 9;
    public const int PATH = 8;
    public const int T__59 = 59;
    public const int LOOP = 33;
    public const int BEGIN = 4;
    public const int ST_OUTERSEP = 26;
    public const int COMMENT = 49;
    public const int ST_INNERSEP = 25;
    public const int NODE = 6;
    public const int UN_PTS = 36;
    public const int IM_COORDDECO = 41;
    public const int STYLESEP = 21;
    public const int IM_COORD = 40;
    public const int INT = 47;
    public const int LBRR = 14;
    public const int UN_CM = 37;
    public const int IM_NODE = 39;
    public const int COLON = 20;
    public const int ST_DRAW = 28;
    public const int SCALE = 17;
    public const int WS = 50;
    public const int OUT = 35;
    public const int LABEL = 23;
    public const int ST_MINSIZE = 30;
    public const int KOMMA = 16;
    public const int ST_SHAPE = 29;
    public const int EQU = 18;
    public const int RPAR = 11;
    public const int END = 5;
    public const int SEMIC = 19;
    public const int IM_NODENAME = 42;
    public const int OPTIONS = 43;
    public const int STRING = 44;
    public const int DRAW = 7;

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:62:1: tikzpath : path_start ( OPTIONS )? coordwithdeco ( coordwithdeco | ( OPTIONS )? edgeop coordwithdeco )* SEMIC -> ^( IM_PATH ( coordwithdeco )+ ) ;
    public simpletikzParser.tikzpath_return tikzpath() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_return retval = new simpletikzParser.tikzpath_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken OPTIONS2 = null;
        IToken OPTIONS5 = null;
        IToken SEMIC8 = null;
        simpletikzParser.path_start_return path_start1 = default(simpletikzParser.path_start_return);

        simpletikzParser.coordwithdeco_return coordwithdeco3 = default(simpletikzParser.coordwithdeco_return);

        simpletikzParser.coordwithdeco_return coordwithdeco4 = default(simpletikzParser.coordwithdeco_return);

        simpletikzParser.edgeop_return edgeop6 = default(simpletikzParser.edgeop_return);

        simpletikzParser.coordwithdeco_return coordwithdeco7 = default(simpletikzParser.coordwithdeco_return);


        object OPTIONS2_tree=null;
        object OPTIONS5_tree=null;
        object SEMIC8_tree=null;
        RewriteRuleTokenStream stream_SEMIC = new RewriteRuleTokenStream(adaptor,"token SEMIC");
        RewriteRuleTokenStream stream_OPTIONS = new RewriteRuleTokenStream(adaptor,"token OPTIONS");
        RewriteRuleSubtreeStream stream_edgeop = new RewriteRuleSubtreeStream(adaptor,"rule edgeop");
        RewriteRuleSubtreeStream stream_path_start = new RewriteRuleSubtreeStream(adaptor,"rule path_start");
        RewriteRuleSubtreeStream stream_coordwithdeco = new RewriteRuleSubtreeStream(adaptor,"rule coordwithdeco");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:63:2: ( path_start ( OPTIONS )? coordwithdeco ( coordwithdeco | ( OPTIONS )? edgeop coordwithdeco )* SEMIC -> ^( IM_PATH ( coordwithdeco )+ ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:63:4: path_start ( OPTIONS )? coordwithdeco ( coordwithdeco | ( OPTIONS )? edgeop coordwithdeco )* SEMIC
            {
            	PushFollow(FOLLOW_path_start_in_tikzpath368);
            	path_start1 = path_start();
            	state.followingStackPointer--;

            	stream_path_start.Add(path_start1.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:63:15: ( OPTIONS )?
            	int alt1 = 2;
            	int LA1_0 = input.LA(1);

            	if ( (LA1_0 == OPTIONS) )
            	{
            	    alt1 = 1;
            	}
            	switch (alt1) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:63:15: OPTIONS
            	        {
            	        	OPTIONS2=(IToken)Match(input,OPTIONS,FOLLOW_OPTIONS_in_tikzpath370);  
            	        	stream_OPTIONS.Add(OPTIONS2);


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_coordwithdeco_in_tikzpath373);
            	coordwithdeco3 = coordwithdeco();
            	state.followingStackPointer--;

            	stream_coordwithdeco.Add(coordwithdeco3.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:63:38: ( coordwithdeco | ( OPTIONS )? edgeop coordwithdeco )*
            	do 
            	{
            	    int alt3 = 3;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == LPAR || (LA3_0 >= 60 && LA3_0 <= 61)) )
            	    {
            	        alt3 = 1;
            	    }
            	    else if ( (LA3_0 == OPTIONS || (LA3_0 >= 54 && LA3_0 <= 59)) )
            	    {
            	        alt3 = 2;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:63:39: coordwithdeco
            			    {
            			    	PushFollow(FOLLOW_coordwithdeco_in_tikzpath376);
            			    	coordwithdeco4 = coordwithdeco();
            			    	state.followingStackPointer--;

            			    	stream_coordwithdeco.Add(coordwithdeco4.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:63:55: ( OPTIONS )? edgeop coordwithdeco
            			    {
            			    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:63:55: ( OPTIONS )?
            			    	int alt2 = 2;
            			    	int LA2_0 = input.LA(1);

            			    	if ( (LA2_0 == OPTIONS) )
            			    	{
            			    	    alt2 = 1;
            			    	}
            			    	switch (alt2) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:63:55: OPTIONS
            			    	        {
            			    	        	OPTIONS5=(IToken)Match(input,OPTIONS,FOLLOW_OPTIONS_in_tikzpath380);  
            			    	        	stream_OPTIONS.Add(OPTIONS5);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_edgeop_in_tikzpath383);
            			    	edgeop6 = edgeop();
            			    	state.followingStackPointer--;

            			    	stream_edgeop.Add(edgeop6.Tree);
            			    	PushFollow(FOLLOW_coordwithdeco_in_tikzpath385);
            			    	coordwithdeco7 = coordwithdeco();
            			    	state.followingStackPointer--;

            			    	stream_coordwithdeco.Add(coordwithdeco7.Tree);

            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements

            	SEMIC8=(IToken)Match(input,SEMIC,FOLLOW_SEMIC_in_tikzpath390);  
            	stream_SEMIC.Add(SEMIC8);



            	// AST REWRITE
            	// elements:          coordwithdeco
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 64:2: -> ^( IM_PATH ( coordwithdeco )+ )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:64:5: ^( IM_PATH ( coordwithdeco )+ )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    if ( !(stream_coordwithdeco.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_coordwithdeco.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_coordwithdeco.NextTree());

            	    }
            	    stream_coordwithdeco.Reset();

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

    public class coordwithdeco_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "coordwithdeco"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:67:1: coordwithdeco : coord ( tikznode )* -> ^( IM_COORDDECO coord ( tikznode )* ) ;
    public simpletikzParser.coordwithdeco_return coordwithdeco() // throws RecognitionException [1]
    {   
        simpletikzParser.coordwithdeco_return retval = new simpletikzParser.coordwithdeco_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.coord_return coord9 = default(simpletikzParser.coord_return);

        simpletikzParser.tikznode_return tikznode10 = default(simpletikzParser.tikznode_return);


        RewriteRuleSubtreeStream stream_coord = new RewriteRuleSubtreeStream(adaptor,"rule coord");
        RewriteRuleSubtreeStream stream_tikznode = new RewriteRuleSubtreeStream(adaptor,"rule tikznode");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:68:2: ( coord ( tikznode )* -> ^( IM_COORDDECO coord ( tikznode )* ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:68:4: coord ( tikznode )*
            {
            	PushFollow(FOLLOW_coord_in_coordwithdeco413);
            	coord9 = coord();
            	state.followingStackPointer--;

            	stream_coord.Add(coord9.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:68:10: ( tikznode )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == 53) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:68:10: tikznode
            			    {
            			    	PushFollow(FOLLOW_tikznode_in_coordwithdeco415);
            			    	tikznode10 = tikznode();
            			    	state.followingStackPointer--;

            			    	stream_tikznode.Add(tikznode10.Tree);

            			    }
            			    break;

            			default:
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements



            	// AST REWRITE
            	// elements:          tikznode, coord
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 68:20: -> ^( IM_COORDDECO coord ( tikznode )* )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:68:23: ^( IM_COORDDECO coord ( tikznode )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORDDECO, "IM_COORDDECO"), root_1);

            	    adaptor.AddChild(root_1, stream_coord.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:68:44: ( tikznode )*
            	    while ( stream_tikznode.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikznode.NextTree());

            	    }
            	    stream_tikznode.Reset();

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
    // $ANTLR end "coordwithdeco"

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:71:1: tikznode : 'node' ( OPTIONS )? ( nodename )? ( 'at' coord )? STRING -> ^( IM_NODE ( nodename )? ( coord )? ) ;
    public simpletikzParser.tikznode_return tikznode() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_return retval = new simpletikzParser.tikznode_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal11 = null;
        IToken OPTIONS12 = null;
        IToken string_literal14 = null;
        IToken STRING16 = null;
        simpletikzParser.nodename_return nodename13 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_return coord15 = default(simpletikzParser.coord_return);


        object string_literal11_tree=null;
        object OPTIONS12_tree=null;
        object string_literal14_tree=null;
        object STRING16_tree=null;
        RewriteRuleTokenStream stream_AT = new RewriteRuleTokenStream(adaptor,"token AT");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleTokenStream stream_OPTIONS = new RewriteRuleTokenStream(adaptor,"token OPTIONS");
        RewriteRuleTokenStream stream_STRING = new RewriteRuleTokenStream(adaptor,"token STRING");
        RewriteRuleSubtreeStream stream_coord = new RewriteRuleSubtreeStream(adaptor,"rule coord");
        RewriteRuleSubtreeStream stream_nodename = new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:72:2: ( 'node' ( OPTIONS )? ( nodename )? ( 'at' coord )? STRING -> ^( IM_NODE ( nodename )? ( coord )? ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:72:4: 'node' ( OPTIONS )? ( nodename )? ( 'at' coord )? STRING
            {
            	string_literal11=(IToken)Match(input,53,FOLLOW_53_in_tikznode439);  
            	stream_53.Add(string_literal11);

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:72:11: ( OPTIONS )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == OPTIONS) )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:72:11: OPTIONS
            	        {
            	        	OPTIONS12=(IToken)Match(input,OPTIONS,FOLLOW_OPTIONS_in_tikznode441);  
            	        	stream_OPTIONS.Add(OPTIONS12);


            	        }
            	        break;

            	}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:72:20: ( nodename )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( (LA6_0 == LPAR) )
            	{
            	    alt6 = 1;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:72:20: nodename
            	        {
            	        	PushFollow(FOLLOW_nodename_in_tikznode444);
            	        	nodename13 = nodename();
            	        	state.followingStackPointer--;

            	        	stream_nodename.Add(nodename13.Tree);

            	        }
            	        break;

            	}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:72:30: ( 'at' coord )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( (LA7_0 == AT) )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:72:31: 'at' coord
            	        {
            	        	string_literal14=(IToken)Match(input,AT,FOLLOW_AT_in_tikznode448);  
            	        	stream_AT.Add(string_literal14);

            	        	PushFollow(FOLLOW_coord_in_tikznode450);
            	        	coord15 = coord();
            	        	state.followingStackPointer--;

            	        	stream_coord.Add(coord15.Tree);

            	        }
            	        break;

            	}

            	STRING16=(IToken)Match(input,STRING,FOLLOW_STRING_in_tikznode454);  
            	stream_STRING.Add(STRING16);



            	// AST REWRITE
            	// elements:          coord, nodename
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 73:2: -> ^( IM_NODE ( nodename )? ( coord )? )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:73:5: ^( IM_NODE ( nodename )? ( coord )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NODE, "IM_NODE"), root_1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:73:15: ( nodename )?
            	    if ( stream_nodename.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_nodename.NextTree());

            	    }
            	    stream_nodename.Reset();
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:73:25: ( coord )?
            	    if ( stream_coord.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_coord.NextTree());

            	    }
            	    stream_coord.Reset();

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:1: edgeop : ( '--' | 'edge' | '->' | '|-' | '-|' | 'to' );
    public simpletikzParser.edgeop_return edgeop() // throws RecognitionException [1]
    {   
        simpletikzParser.edgeop_return retval = new simpletikzParser.edgeop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set17 = null;

        object set17_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:77:2: ( '--' | 'edge' | '->' | '|-' | '-|' | 'to' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set17 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 54 && input.LA(1) <= 59) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set17));
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:80:1: nodename : lc= LPAR id= ID RPAR -> ^( IM_NODENAME[$lc] $id) ;
    public simpletikzParser.nodename_return nodename() // throws RecognitionException [1]
    {   
        simpletikzParser.nodename_return retval = new simpletikzParser.nodename_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken lc = null;
        IToken id = null;
        IToken RPAR18 = null;

        object lc_tree=null;
        object id_tree=null;
        object RPAR18_tree=null;
        RewriteRuleTokenStream stream_RPAR = new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR = new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:81:2: (lc= LPAR id= ID RPAR -> ^( IM_NODENAME[$lc] $id) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:81:4: lc= LPAR id= ID RPAR
            {
            	lc=(IToken)Match(input,LPAR,FOLLOW_LPAR_in_nodename514);  
            	stream_LPAR.Add(lc);

            	id=(IToken)Match(input,ID,FOLLOW_ID_in_nodename518);  
            	stream_ID.Add(id);

            	RPAR18=(IToken)Match(input,RPAR,FOLLOW_RPAR_in_nodename520);  
            	stream_RPAR.Add(RPAR18);



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
            	// 81:24: -> ^( IM_NODENAME[$lc] $id)
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:81:27: ^( IM_NODENAME[$lc] $id)
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:84:1: coord : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR ) -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ ) );
    public simpletikzParser.coord_return coord() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_return retval = new simpletikzParser.coord_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken lc = null;
        IToken KOMMA22 = null;
        IToken RPAR24 = null;
        simpletikzParser.nodename_return nodename19 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_modifier_return coord_modifier20 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.numberunit_return numberunit21 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit23 = default(simpletikzParser.numberunit_return);


        object lc_tree=null;
        object KOMMA22_tree=null;
        object RPAR24_tree=null;
        RewriteRuleTokenStream stream_RPAR = new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR = new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleTokenStream stream_KOMMA = new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_nodename = new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        RewriteRuleSubtreeStream stream_coord_modifier = new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:85:2: ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR ) -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ ) )
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
            else if ( ((LA9_0 >= 60 && LA9_0 <= 61)) )
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
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:85:6: nodename
                    {
                    	PushFollow(FOLLOW_nodename_in_coord545);
                    	nodename19 = nodename();
                    	state.followingStackPointer--;

                    	stream_nodename.Add(nodename19.Tree);


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
                    	// 85:24: -> ^( IM_COORD nodename )
                    	{
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:85:27: ^( IM_COORD nodename )
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
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:86:5: ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR )
                    {
                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:86:5: ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR )
                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:86:7: ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR
                    	{
                    		// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:86:7: ( coord_modifier )?
                    		int alt8 = 2;
                    		int LA8_0 = input.LA(1);

                    		if ( ((LA8_0 >= 60 && LA8_0 <= 61)) )
                    		{
                    		    alt8 = 1;
                    		}
                    		switch (alt8) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:86:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord570);
                    		        	coord_modifier20 = coord_modifier();
                    		        	state.followingStackPointer--;

                    		        	stream_coord_modifier.Add(coord_modifier20.Tree);

                    		        }
                    		        break;

                    		}

                    		lc=(IToken)Match(input,LPAR,FOLLOW_LPAR_in_coord575);  
                    		stream_LPAR.Add(lc);

                    		PushFollow(FOLLOW_numberunit_in_coord577);
                    		numberunit21 = numberunit();
                    		state.followingStackPointer--;

                    		stream_numberunit.Add(numberunit21.Tree);
                    		KOMMA22=(IToken)Match(input,KOMMA,FOLLOW_KOMMA_in_coord579);  
                    		stream_KOMMA.Add(KOMMA22);

                    		PushFollow(FOLLOW_numberunit_in_coord581);
                    		numberunit23 = numberunit();
                    		state.followingStackPointer--;

                    		stream_numberunit.Add(numberunit23.Tree);
                    		RPAR24=(IToken)Match(input,RPAR,FOLLOW_RPAR_in_coord583);  
                    		stream_RPAR.Add(RPAR24);


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
                    	// 86:66: -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ )
                    	{
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:86:69: ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, lc), root_1);

                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:86:85: ( coord_modifier )?
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:1: coord_modifier : ( '+' | '++' );
    public simpletikzParser.coord_modifier_return coord_modifier() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_modifier_return retval = new simpletikzParser.coord_modifier_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set25 = null;

        object set25_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:2: ( '+' | '++' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set25 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 60 && input.LA(1) <= 61) ) 
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:93:1: numberunit : ( FLOAT | INT ) ( unit )? ;
    public simpletikzParser.numberunit_return numberunit() // throws RecognitionException [1]
    {   
        simpletikzParser.numberunit_return retval = new simpletikzParser.numberunit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set26 = null;
        simpletikzParser.unit_return unit27 = default(simpletikzParser.unit_return);


        object set26_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:94:2: ( ( FLOAT | INT ) ( unit )? )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:94:4: ( FLOAT | INT ) ( unit )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set26 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= FLOAT && input.LA(1) <= INT) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set26));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:94:16: ( unit )?
            	int alt10 = 2;
            	int LA10_0 = input.LA(1);

            	if ( (LA10_0 == IN || (LA10_0 >= UN_PTS && LA10_0 <= UN_CM) || (LA10_0 >= 62 && LA10_0 <= 63)) )
            	{
            	    alt10 = 1;
            	}
            	switch (alt10) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:94:16: unit
            	        {
            	        	PushFollow(FOLLOW_unit_in_numberunit631);
            	        	unit27 = unit();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, unit27.Tree);

            	        }
            	        break;

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
    // $ANTLR end "numberunit"

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:97:1: unit : ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' );
    public simpletikzParser.unit_return unit() // throws RecognitionException [1]
    {   
        simpletikzParser.unit_return retval = new simpletikzParser.unit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set28 = null;

        object set28_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:98:2: ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set28 = (IToken)input.LT(1);
            	if ( input.LA(1) == IN || (input.LA(1) >= UN_PTS && input.LA(1) <= UN_CM) || (input.LA(1) >= 62 && input.LA(1) <= 63) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set28));
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:101:1: path_start : ( DRAW | FILL | PATH );
    public simpletikzParser.path_start_return path_start() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_return retval = new simpletikzParser.path_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set29 = null;

        object set29_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:102:2: ( DRAW | FILL | PATH )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set29 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= DRAW && input.LA(1) <= FILL) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set29));
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

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_path_start_in_tikzpath368 = new BitSet(new ulong[]{0x3000080000000400UL});
    public static readonly BitSet FOLLOW_OPTIONS_in_tikzpath370 = new BitSet(new ulong[]{0x3000080000000400UL});
    public static readonly BitSet FOLLOW_coordwithdeco_in_tikzpath373 = new BitSet(new ulong[]{0x3FC0080000080400UL});
    public static readonly BitSet FOLLOW_coordwithdeco_in_tikzpath376 = new BitSet(new ulong[]{0x3FC0080000080400UL});
    public static readonly BitSet FOLLOW_OPTIONS_in_tikzpath380 = new BitSet(new ulong[]{0x3FC0080000000400UL});
    public static readonly BitSet FOLLOW_edgeop_in_tikzpath383 = new BitSet(new ulong[]{0x3000080000000400UL});
    public static readonly BitSet FOLLOW_coordwithdeco_in_tikzpath385 = new BitSet(new ulong[]{0x3FC0080000080400UL});
    public static readonly BitSet FOLLOW_SEMIC_in_tikzpath390 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_in_coordwithdeco413 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_tikznode_in_coordwithdeco415 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_53_in_tikznode439 = new BitSet(new ulong[]{0x0000180000400400UL});
    public static readonly BitSet FOLLOW_OPTIONS_in_tikznode441 = new BitSet(new ulong[]{0x0000100000400400UL});
    public static readonly BitSet FOLLOW_nodename_in_tikznode444 = new BitSet(new ulong[]{0x0000100000400000UL});
    public static readonly BitSet FOLLOW_AT_in_tikznode448 = new BitSet(new ulong[]{0x3000080000000400UL});
    public static readonly BitSet FOLLOW_coord_in_tikznode450 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_STRING_in_tikznode454 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_edgeop0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAR_in_nodename514 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_ID_in_nodename518 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_RPAR_in_nodename520 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_coord545 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord570 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LPAR_in_coord575 = new BitSet(new ulong[]{0x0000C00000000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord577 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_KOMMA_in_coord579 = new BitSet(new ulong[]{0x0000C00000000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord581 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_RPAR_in_coord583 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_coord_modifier0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_numberunit625 = new BitSet(new ulong[]{0xC000003400000002UL});
    public static readonly BitSet FOLLOW_unit_in_numberunit631 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unit0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_path_start0 = new BitSet(new ulong[]{0x0000000000000002UL});

}
