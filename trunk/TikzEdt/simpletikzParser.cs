// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g 2010-12-05 09:56:35

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
		"SOMETHING", 
		"STRING", 
		"ID", 
		"FLOAT", 
		"INT", 
		"EXPONENT", 
		"COMMENT", 
		"WS", 
		"ESC_SEQ", 
		"'node'", 
		"'at'", 
		"'--'", 
		"'edge'", 
		"'->'", 
		"'|-'", 
		"'-|'", 
		"'to'", 
		"'+'", 
		"'++'", 
		"'cm'", 
		"'in'", 
		"'ex'", 
		"'mm'", 
		"'pt'", 
		"'/.style'"
    };

    public const int EXPONENT = 43;
    public const int IM_STARTTAG = 32;
    public const int T__62 = 62;
    public const int RBR = 17;
    public const int IM_PATH = 24;
    public const int IM_ID = 37;
    public const int FLOAT = 41;
    public const int BEGINTP = 6;
    public const int SOMETHING = 38;
    public const int ID = 40;
    public const int T__61 = 61;
    public const int T__60 = 60;
    public const int EOF = -1;
    public const int LBR = 16;
    public const int IM_ENDTAG = 33;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int IM_DOCUMENT = 30;
    public const int T__58 = 58;
    public const int RBRR = 19;
    public const int ESC_SEQ = 46;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int LPAR = 14;
    public const int T__54 = 54;
    public const int ENDTP = 7;
    public const int FILL = 13;
    public const int PATH = 12;
    public const int T__59 = 59;
    public const int BEGIN = 4;
    public const int IM_OPTION_KV = 36;
    public const int COMMENT = 44;
    public const int T__50 = 50;
    public const int IM_OPTIONS = 34;
    public const int T__47 = 47;
    public const int IM_OPTION_STYLE = 35;
    public const int NODE = 10;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int IM_COORD = 26;
    public const int IM_PICTURE = 29;
    public const int INT = 42;
    public const int BEGINSCOPE = 8;
    public const int LBRR = 18;
    public const int IM_NODE = 25;
    public const int COLON = 23;
    public const int ENDSCOPE = 9;
    public const int IM_SCOPE = 31;
    public const int IM_NUMBERUNIT = 28;
    public const int WS = 45;
    public const int KOMMA = 20;
    public const int EQU = 21;
    public const int RPAR = 15;
    public const int END = 5;
    public const int SEMIC = 22;
    public const int IM_NODENAME = 27;
    public const int STRING = 39;
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:75:1: tikzdocument : ( SOMETHING )* tikzpicture ( SOMETHING )* -> ^( IM_DOCUMENT tikzpicture ) ;
    public simpletikzParser.tikzdocument_return tikzdocument() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzdocument_return retval = new simpletikzParser.tikzdocument_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken SOMETHING1 = null;
        IToken SOMETHING3 = null;
        simpletikzParser.tikzpicture_return tikzpicture2 = default(simpletikzParser.tikzpicture_return);


        object SOMETHING1_tree=null;
        object SOMETHING3_tree=null;
        RewriteRuleTokenStream stream_SOMETHING = new RewriteRuleTokenStream(adaptor,"token SOMETHING");
        RewriteRuleSubtreeStream stream_tikzpicture = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:2: ( ( SOMETHING )* tikzpicture ( SOMETHING )* -> ^( IM_DOCUMENT tikzpicture ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:4: ( SOMETHING )* tikzpicture ( SOMETHING )*
            {
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:4: ( SOMETHING )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == SOMETHING) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:4: SOMETHING
            			    {
            			    	SOMETHING1=(IToken)Match(input,SOMETHING,FOLLOW_SOMETHING_in_tikzdocument315);  
            			    	stream_SOMETHING.Add(SOMETHING1);


            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	PushFollow(FOLLOW_tikzpicture_in_tikzdocument318);
            	tikzpicture2 = tikzpicture();
            	state.followingStackPointer--;

            	stream_tikzpicture.Add(tikzpicture2.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:28: ( SOMETHING )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == SOMETHING) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:28: SOMETHING
            			    {
            			    	SOMETHING3=(IToken)Match(input,SOMETHING,FOLLOW_SOMETHING_in_tikzdocument321);  
            			    	stream_SOMETHING.Add(SOMETHING3);


            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements



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
            	// 76:40: -> ^( IM_DOCUMENT tikzpicture )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:43: ^( IM_DOCUMENT tikzpicture )
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:79:1: tikzpath : path_start tikzpathi path_end -> ^( IM_PATH path_start tikzpathi path_end ) ;
    public simpletikzParser.tikzpath_return tikzpath() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpath_return retval = new simpletikzParser.tikzpath_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.path_start_return path_start4 = default(simpletikzParser.path_start_return);

        simpletikzParser.tikzpathi_return tikzpathi5 = default(simpletikzParser.tikzpathi_return);

        simpletikzParser.path_end_return path_end6 = default(simpletikzParser.path_end_return);


        RewriteRuleSubtreeStream stream_path_end = new RewriteRuleSubtreeStream(adaptor,"rule path_end");
        RewriteRuleSubtreeStream stream_path_start = new RewriteRuleSubtreeStream(adaptor,"rule path_start");
        RewriteRuleSubtreeStream stream_tikzpathi = new RewriteRuleSubtreeStream(adaptor,"rule tikzpathi");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:80:2: ( path_start tikzpathi path_end -> ^( IM_PATH path_start tikzpathi path_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:80:4: path_start tikzpathi path_end
            {
            	PushFollow(FOLLOW_path_start_in_tikzpath343);
            	path_start4 = path_start();
            	state.followingStackPointer--;

            	stream_path_start.Add(path_start4.Tree);
            	PushFollow(FOLLOW_tikzpathi_in_tikzpath345);
            	tikzpathi5 = tikzpathi();
            	state.followingStackPointer--;

            	stream_tikzpathi.Add(tikzpathi5.Tree);
            	PushFollow(FOLLOW_path_end_in_tikzpath347);
            	path_end6 = path_end();
            	state.followingStackPointer--;

            	stream_path_end.Add(path_end6.Tree);


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
            	// 80:34: -> ^( IM_PATH path_start tikzpathi path_end )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:80:37: ^( IM_PATH path_start tikzpathi path_end )
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:82:1: path_end : SEMIC -> ^( IM_ENDTAG SEMIC ) ;
    public simpletikzParser.path_end_return path_end() // throws RecognitionException [1]
    {   
        simpletikzParser.path_end_return retval = new simpletikzParser.path_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken SEMIC7 = null;

        object SEMIC7_tree=null;
        RewriteRuleTokenStream stream_SEMIC = new RewriteRuleTokenStream(adaptor,"token SEMIC");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:83:2: ( SEMIC -> ^( IM_ENDTAG SEMIC ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:83:4: SEMIC
            {
            	SEMIC7=(IToken)Match(input,SEMIC,FOLLOW_SEMIC_in_path_end370);  
            	stream_SEMIC.Add(SEMIC7);



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
            	// 83:10: -> ^( IM_ENDTAG SEMIC )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:83:13: ^( IM_ENDTAG SEMIC )
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:86:1: tikzpathi : coordornode ( coordornode | ( tikz_options )? edgeop coordornode )* ;
    public simpletikzParser.tikzpathi_return tikzpathi() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpathi_return retval = new simpletikzParser.tikzpathi_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.coordornode_return coordornode8 = default(simpletikzParser.coordornode_return);

        simpletikzParser.coordornode_return coordornode9 = default(simpletikzParser.coordornode_return);

        simpletikzParser.tikz_options_return tikz_options10 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.edgeop_return edgeop11 = default(simpletikzParser.edgeop_return);

        simpletikzParser.coordornode_return coordornode12 = default(simpletikzParser.coordornode_return);



        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:87:2: ( coordornode ( coordornode | ( tikz_options )? edgeop coordornode )* )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:87:5: coordornode ( coordornode | ( tikz_options )? edgeop coordornode )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_coordornode_in_tikzpathi390);
            	coordornode8 = coordornode();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, coordornode8.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:87:17: ( coordornode | ( tikz_options )? edgeop coordornode )*
            	do 
            	{
            	    int alt4 = 3;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == LPAR || LA4_0 == 47 || (LA4_0 >= 55 && LA4_0 <= 56)) )
            	    {
            	        alt4 = 1;
            	    }
            	    else if ( (LA4_0 == LBR || (LA4_0 >= 49 && LA4_0 <= 54)) )
            	    {
            	        alt4 = 2;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:87:18: coordornode
            			    {
            			    	PushFollow(FOLLOW_coordornode_in_tikzpathi393);
            			    	coordornode9 = coordornode();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, coordornode9.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:87:32: ( tikz_options )? edgeop coordornode
            			    {
            			    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:87:32: ( tikz_options )?
            			    	int alt3 = 2;
            			    	int LA3_0 = input.LA(1);

            			    	if ( (LA3_0 == LBR) )
            			    	{
            			    	    alt3 = 1;
            			    	}
            			    	switch (alt3) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:87:32: tikz_options
            			    	        {
            			    	        	PushFollow(FOLLOW_tikz_options_in_tikzpathi397);
            			    	        	tikz_options10 = tikz_options();
            			    	        	state.followingStackPointer--;

            			    	        	adaptor.AddChild(root_0, tikz_options10.Tree);

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_edgeop_in_tikzpathi400);
            			    	edgeop11 = edgeop();
            			    	state.followingStackPointer--;

            			    	PushFollow(FOLLOW_coordornode_in_tikzpathi403);
            			    	coordornode12 = coordornode();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, coordornode12.Tree);

            			    }
            			    break;

            			default:
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements


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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:1: coordornode : ( coord | tikznodei );
    public simpletikzParser.coordornode_return coordornode() // throws RecognitionException [1]
    {   
        simpletikzParser.coordornode_return retval = new simpletikzParser.coordornode_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.coord_return coord13 = default(simpletikzParser.coord_return);

        simpletikzParser.tikznodei_return tikznodei14 = default(simpletikzParser.tikznodei_return);



        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:91:2: ( coord | tikznodei )
            int alt5 = 2;
            int LA5_0 = input.LA(1);

            if ( (LA5_0 == LPAR || (LA5_0 >= 55 && LA5_0 <= 56)) )
            {
                alt5 = 1;
            }
            else if ( (LA5_0 == 47) )
            {
                alt5 = 2;
            }
            else 
            {
                NoViableAltException nvae_d5s0 =
                    new NoViableAltException("", 5, 0, input);

                throw nvae_d5s0;
            }
            switch (alt5) 
            {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:91:4: coord
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_coord_in_coordornode418);
                    	coord13 = coord();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, coord13.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:91:12: tikznodei
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tikznodei_in_coordornode422);
                    	tikznodei14 = tikznodei();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, tikznodei14.Tree);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:94:1: tikznodei : 'node' tikznode ;
    public simpletikzParser.tikznodei_return tikznodei() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznodei_return retval = new simpletikzParser.tikznodei_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal15 = null;
        simpletikzParser.tikznode_return tikznode16 = default(simpletikzParser.tikznode_return);


        object string_literal15_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:95:2: ( 'node' tikznode )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:95:4: 'node' tikznode
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal15=(IToken)Match(input,47,FOLLOW_47_in_tikznodei434); 
            	PushFollow(FOLLOW_tikznode_in_tikznodei437);
            	tikznode16 = tikznode();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, tikznode16.Tree);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:97:1: tikznodee : node_start tikznode ( tikzpathi )? path_end -> ^( IM_PATH node_start tikznode ( tikzpathi )? path_end ) ;
    public simpletikzParser.tikznodee_return tikznodee() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznodee_return retval = new simpletikzParser.tikznodee_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.node_start_return node_start17 = default(simpletikzParser.node_start_return);

        simpletikzParser.tikznode_return tikznode18 = default(simpletikzParser.tikznode_return);

        simpletikzParser.tikzpathi_return tikzpathi19 = default(simpletikzParser.tikzpathi_return);

        simpletikzParser.path_end_return path_end20 = default(simpletikzParser.path_end_return);


        RewriteRuleSubtreeStream stream_node_start = new RewriteRuleSubtreeStream(adaptor,"rule node_start");
        RewriteRuleSubtreeStream stream_path_end = new RewriteRuleSubtreeStream(adaptor,"rule path_end");
        RewriteRuleSubtreeStream stream_tikznode = new RewriteRuleSubtreeStream(adaptor,"rule tikznode");
        RewriteRuleSubtreeStream stream_tikzpathi = new RewriteRuleSubtreeStream(adaptor,"rule tikzpathi");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:98:2: ( node_start tikznode ( tikzpathi )? path_end -> ^( IM_PATH node_start tikznode ( tikzpathi )? path_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:98:4: node_start tikznode ( tikzpathi )? path_end
            {
            	PushFollow(FOLLOW_node_start_in_tikznodee447);
            	node_start17 = node_start();
            	state.followingStackPointer--;

            	stream_node_start.Add(node_start17.Tree);
            	PushFollow(FOLLOW_tikznode_in_tikznodee449);
            	tikznode18 = tikznode();
            	state.followingStackPointer--;

            	stream_tikznode.Add(tikznode18.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:98:24: ( tikzpathi )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( (LA6_0 == LPAR || LA6_0 == 47 || (LA6_0 >= 55 && LA6_0 <= 56)) )
            	{
            	    alt6 = 1;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:98:24: tikzpathi
            	        {
            	        	PushFollow(FOLLOW_tikzpathi_in_tikznodee451);
            	        	tikzpathi19 = tikzpathi();
            	        	state.followingStackPointer--;

            	        	stream_tikzpathi.Add(tikzpathi19.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_path_end_in_tikznodee454);
            	path_end20 = path_end();
            	state.followingStackPointer--;

            	stream_path_end.Add(path_end20.Tree);


            	// AST REWRITE
            	// elements:          tikzpathi, tikznode, node_start, path_end
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 98:44: -> ^( IM_PATH node_start tikznode ( tikzpathi )? path_end )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:98:47: ^( IM_PATH node_start tikznode ( tikzpathi )? path_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PATH, "IM_PATH"), root_1);

            	    adaptor.AddChild(root_1, stream_node_start.NextTree());
            	    adaptor.AddChild(root_1, stream_tikznode.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:98:77: ( tikzpathi )?
            	    if ( stream_tikzpathi.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikzpathi.NextTree());

            	    }
            	    stream_tikzpathi.Reset();
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:1: node_start : NODE -> ^( IM_STARTTAG NODE ) ;
    public simpletikzParser.node_start_return node_start() // throws RecognitionException [1]
    {   
        simpletikzParser.node_start_return retval = new simpletikzParser.node_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NODE21 = null;

        object NODE21_tree=null;
        RewriteRuleTokenStream stream_NODE = new RewriteRuleTokenStream(adaptor,"token NODE");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:101:2: ( NODE -> ^( IM_STARTTAG NODE ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:101:4: NODE
            {
            	NODE21=(IToken)Match(input,NODE,FOLLOW_NODE_in_node_start480);  
            	stream_NODE.Add(NODE21);



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
            	// 101:9: -> ^( IM_STARTTAG NODE )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:101:12: ^( IM_STARTTAG NODE )
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:103:1: tikznode : ( nodename )? ( 'at' coord )? STRING -> ^( IM_NODE ( nodename )? ( coord )? STRING ) ;
    public simpletikzParser.tikznode_return tikznode() // throws RecognitionException [1]
    {   
        simpletikzParser.tikznode_return retval = new simpletikzParser.tikznode_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal23 = null;
        IToken STRING25 = null;
        simpletikzParser.nodename_return nodename22 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_return coord24 = default(simpletikzParser.coord_return);


        object string_literal23_tree=null;
        object STRING25_tree=null;
        RewriteRuleTokenStream stream_48 = new RewriteRuleTokenStream(adaptor,"token 48");
        RewriteRuleTokenStream stream_STRING = new RewriteRuleTokenStream(adaptor,"token STRING");
        RewriteRuleSubtreeStream stream_coord = new RewriteRuleSubtreeStream(adaptor,"rule coord");
        RewriteRuleSubtreeStream stream_nodename = new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:104:2: ( ( nodename )? ( 'at' coord )? STRING -> ^( IM_NODE ( nodename )? ( coord )? STRING ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:104:4: ( nodename )? ( 'at' coord )? STRING
            {
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:104:4: ( nodename )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( (LA7_0 == LPAR) )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:104:4: nodename
            	        {
            	        	PushFollow(FOLLOW_nodename_in_tikznode498);
            	        	nodename22 = nodename();
            	        	state.followingStackPointer--;

            	        	stream_nodename.Add(nodename22.Tree);

            	        }
            	        break;

            	}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:104:14: ( 'at' coord )?
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( (LA8_0 == 48) )
            	{
            	    alt8 = 1;
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:104:15: 'at' coord
            	        {
            	        	string_literal23=(IToken)Match(input,48,FOLLOW_48_in_tikznode502);  
            	        	stream_48.Add(string_literal23);

            	        	PushFollow(FOLLOW_coord_in_tikznode504);
            	        	coord24 = coord();
            	        	state.followingStackPointer--;

            	        	stream_coord.Add(coord24.Tree);

            	        }
            	        break;

            	}

            	STRING25=(IToken)Match(input,STRING,FOLLOW_STRING_in_tikznode508);  
            	stream_STRING.Add(STRING25);



            	// AST REWRITE
            	// elements:          nodename, STRING, coord
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 104:36: -> ^( IM_NODE ( nodename )? ( coord )? STRING )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:104:39: ^( IM_NODE ( nodename )? ( coord )? STRING )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NODE, "IM_NODE"), root_1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:104:49: ( nodename )?
            	    if ( stream_nodename.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_nodename.NextTree());

            	    }
            	    stream_nodename.Reset();
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:104:59: ( coord )?
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:107:1: edgeop : ( '--' | 'edge' | '->' | '|-' | '-|' | 'to' );
    public simpletikzParser.edgeop_return edgeop() // throws RecognitionException [1]
    {   
        simpletikzParser.edgeop_return retval = new simpletikzParser.edgeop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set26 = null;

        object set26_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:2: ( '--' | 'edge' | '->' | '|-' | '-|' | 'to' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set26 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 49 && input.LA(1) <= 54) ) 
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:111:1: nodename : lc= LPAR id= ID RPAR -> ^( IM_NODENAME[$lc] $id) ;
    public simpletikzParser.nodename_return nodename() // throws RecognitionException [1]
    {   
        simpletikzParser.nodename_return retval = new simpletikzParser.nodename_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken lc = null;
        IToken id = null;
        IToken RPAR27 = null;

        object lc_tree=null;
        object id_tree=null;
        object RPAR27_tree=null;
        RewriteRuleTokenStream stream_RPAR = new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR = new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:112:2: (lc= LPAR id= ID RPAR -> ^( IM_NODENAME[$lc] $id) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:112:4: lc= LPAR id= ID RPAR
            {
            	lc=(IToken)Match(input,LPAR,FOLLOW_LPAR_in_nodename573);  
            	stream_LPAR.Add(lc);

            	id=(IToken)Match(input,ID,FOLLOW_ID_in_nodename577);  
            	stream_ID.Add(id);

            	RPAR27=(IToken)Match(input,RPAR,FOLLOW_RPAR_in_nodename579);  
            	stream_RPAR.Add(RPAR27);



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
            	// 112:24: -> ^( IM_NODENAME[$lc] $id)
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:112:27: ^( IM_NODENAME[$lc] $id)
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:115:1: coord : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR ) -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ ) );
    public simpletikzParser.coord_return coord() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_return retval = new simpletikzParser.coord_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken lc = null;
        IToken KOMMA31 = null;
        IToken RPAR33 = null;
        simpletikzParser.nodename_return nodename28 = default(simpletikzParser.nodename_return);

        simpletikzParser.coord_modifier_return coord_modifier29 = default(simpletikzParser.coord_modifier_return);

        simpletikzParser.numberunit_return numberunit30 = default(simpletikzParser.numberunit_return);

        simpletikzParser.numberunit_return numberunit32 = default(simpletikzParser.numberunit_return);


        object lc_tree=null;
        object KOMMA31_tree=null;
        object RPAR33_tree=null;
        RewriteRuleTokenStream stream_RPAR = new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR = new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleTokenStream stream_KOMMA = new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_numberunit = new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_nodename = new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        RewriteRuleSubtreeStream stream_coord_modifier = new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:116:2: ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR ) -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ ) )
            int alt10 = 2;
            int LA10_0 = input.LA(1);

            if ( (LA10_0 == LPAR) )
            {
                int LA10_1 = input.LA(2);

                if ( (LA10_1 == ID) )
                {
                    alt10 = 1;
                }
                else if ( ((LA10_1 >= FLOAT && LA10_1 <= INT)) )
                {
                    alt10 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d10s1 =
                        new NoViableAltException("", 10, 1, input);

                    throw nvae_d10s1;
                }
            }
            else if ( ((LA10_0 >= 55 && LA10_0 <= 56)) )
            {
                alt10 = 2;
            }
            else 
            {
                NoViableAltException nvae_d10s0 =
                    new NoViableAltException("", 10, 0, input);

                throw nvae_d10s0;
            }
            switch (alt10) 
            {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:116:6: nodename
                    {
                    	PushFollow(FOLLOW_nodename_in_coord604);
                    	nodename28 = nodename();
                    	state.followingStackPointer--;

                    	stream_nodename.Add(nodename28.Tree);


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
                    	// 116:23: -> ^( IM_COORD nodename )
                    	{
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:116:26: ^( IM_COORD nodename )
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
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:5: ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR )
                    {
                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:5: ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR )
                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:7: ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR
                    	{
                    		// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:7: ( coord_modifier )?
                    		int alt9 = 2;
                    		int LA9_0 = input.LA(1);

                    		if ( ((LA9_0 >= 55 && LA9_0 <= 56)) )
                    		{
                    		    alt9 = 1;
                    		}
                    		switch (alt9) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:7: coord_modifier
                    		        {
                    		        	PushFollow(FOLLOW_coord_modifier_in_coord628);
                    		        	coord_modifier29 = coord_modifier();
                    		        	state.followingStackPointer--;

                    		        	stream_coord_modifier.Add(coord_modifier29.Tree);

                    		        }
                    		        break;

                    		}

                    		lc=(IToken)Match(input,LPAR,FOLLOW_LPAR_in_coord633);  
                    		stream_LPAR.Add(lc);

                    		PushFollow(FOLLOW_numberunit_in_coord635);
                    		numberunit30 = numberunit();
                    		state.followingStackPointer--;

                    		stream_numberunit.Add(numberunit30.Tree);
                    		KOMMA31=(IToken)Match(input,KOMMA,FOLLOW_KOMMA_in_coord637);  
                    		stream_KOMMA.Add(KOMMA31);

                    		PushFollow(FOLLOW_numberunit_in_coord639);
                    		numberunit32 = numberunit();
                    		state.followingStackPointer--;

                    		stream_numberunit.Add(numberunit32.Tree);
                    		RPAR33=(IToken)Match(input,RPAR,FOLLOW_RPAR_in_coord641);  
                    		stream_RPAR.Add(RPAR33);


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
                    	// 117:66: -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ )
                    	{
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:69: ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_COORD, lc), root_1);

                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:85: ( coord_modifier )?
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:120:1: coord_modifier : ( '+' | '++' );
    public simpletikzParser.coord_modifier_return coord_modifier() // throws RecognitionException [1]
    {   
        simpletikzParser.coord_modifier_return retval = new simpletikzParser.coord_modifier_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set34 = null;

        object set34_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:2: ( '+' | '++' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set34 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 55 && input.LA(1) <= 56) ) 
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:124:1: numberunit : number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) ;
    public simpletikzParser.numberunit_return numberunit() // throws RecognitionException [1]
    {   
        simpletikzParser.numberunit_return retval = new simpletikzParser.numberunit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.number_return number35 = default(simpletikzParser.number_return);

        simpletikzParser.unit_return unit36 = default(simpletikzParser.unit_return);


        RewriteRuleSubtreeStream stream_unit = new RewriteRuleSubtreeStream(adaptor,"rule unit");
        RewriteRuleSubtreeStream stream_number = new RewriteRuleSubtreeStream(adaptor,"rule number");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:125:2: ( number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:125:4: number ( unit )?
            {
            	PushFollow(FOLLOW_number_in_numberunit683);
            	number35 = number();
            	state.followingStackPointer--;

            	stream_number.Add(number35.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:125:11: ( unit )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( ((LA11_0 >= 57 && LA11_0 <= 61)) )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:125:11: unit
            	        {
            	        	PushFollow(FOLLOW_unit_in_numberunit685);
            	        	unit36 = unit();
            	        	state.followingStackPointer--;

            	        	stream_unit.Add(unit36.Tree);

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
            	// 125:17: -> ^( IM_NUMBERUNIT number ( unit )? )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:125:20: ^( IM_NUMBERUNIT number ( unit )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_NUMBERUNIT, "IM_NUMBERUNIT"), root_1);

            	    adaptor.AddChild(root_1, stream_number.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:125:43: ( unit )?
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:127:1: number : ( FLOAT | INT ) ;
    public simpletikzParser.number_return number() // throws RecognitionException [1]
    {   
        simpletikzParser.number_return retval = new simpletikzParser.number_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set37 = null;

        object set37_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:128:2: ( ( FLOAT | INT ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:128:4: ( FLOAT | INT )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set37 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= FLOAT && input.LA(1) <= INT) ) 
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:130:1: unit : ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' );
    public simpletikzParser.unit_return unit() // throws RecognitionException [1]
    {   
        simpletikzParser.unit_return retval = new simpletikzParser.unit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set38 = null;

        object set38_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:131:2: ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set38 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 57 && input.LA(1) <= 61) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set38));
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:134:1: path_start : path_start_tag -> ^( IM_STARTTAG path_start_tag ) ;
    public simpletikzParser.path_start_return path_start() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_return retval = new simpletikzParser.path_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.path_start_tag_return path_start_tag39 = default(simpletikzParser.path_start_tag_return);


        RewriteRuleSubtreeStream stream_path_start_tag = new RewriteRuleSubtreeStream(adaptor,"rule path_start_tag");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:135:2: ( path_start_tag -> ^( IM_STARTTAG path_start_tag ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:135:4: path_start_tag
            {
            	PushFollow(FOLLOW_path_start_tag_in_path_start752);
            	path_start_tag39 = path_start_tag();
            	state.followingStackPointer--;

            	stream_path_start_tag.Add(path_start_tag39.Tree);


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
            	// 135:19: -> ^( IM_STARTTAG path_start_tag )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:135:22: ^( IM_STARTTAG path_start_tag )
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:1: path_start_tag : ( DRAW | FILL | PATH );
    public simpletikzParser.path_start_tag_return path_start_tag() // throws RecognitionException [1]
    {   
        simpletikzParser.path_start_tag_return retval = new simpletikzParser.path_start_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set40 = null;

        object set40_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:138:2: ( DRAW | FILL | PATH )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set40 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= DRAW && input.LA(1) <= FILL) ) 
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
    // $ANTLR end "path_start_tag"

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:141:1: tikzpicture : tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) ;
    public simpletikzParser.tikzpicture_return tikzpicture() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_return retval = new simpletikzParser.tikzpicture_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzpicture_start_return tikzpicture_start41 = default(simpletikzParser.tikzpicture_start_return);

        simpletikzParser.tikz_options_return tikz_options42 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody_return tikzbody43 = default(simpletikzParser.tikzbody_return);

        simpletikzParser.tikzpicture_end_return tikzpicture_end44 = default(simpletikzParser.tikzpicture_end_return);


        RewriteRuleSubtreeStream stream_tikzpicture_end = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_end");
        RewriteRuleSubtreeStream stream_tikzpicture_start = new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_start");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:142:2: ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:142:5: tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end
            {
            	PushFollow(FOLLOW_tikzpicture_start_in_tikzpicture791);
            	tikzpicture_start41 = tikzpicture_start();
            	state.followingStackPointer--;

            	stream_tikzpicture_start.Add(tikzpicture_start41.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:142:23: ( tikz_options )?
            	int alt12 = 2;
            	int LA12_0 = input.LA(1);

            	if ( (LA12_0 == LBR) )
            	{
            	    alt12 = 1;
            	}
            	switch (alt12) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:142:23: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_tikzpicture793);
            	        	tikz_options42 = tikz_options();
            	        	state.followingStackPointer--;

            	        	stream_tikz_options.Add(tikz_options42.Tree);

            	        }
            	        break;

            	}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:142:37: ( tikzbody )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == BEGINSCOPE || (LA13_0 >= NODE && LA13_0 <= FILL)) )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:142:37: tikzbody
            	        {
            	        	PushFollow(FOLLOW_tikzbody_in_tikzpicture796);
            	        	tikzbody43 = tikzbody();
            	        	state.followingStackPointer--;

            	        	stream_tikzbody.Add(tikzbody43.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzpicture_end_in_tikzpicture799);
            	tikzpicture_end44 = tikzpicture_end();
            	state.followingStackPointer--;

            	stream_tikzpicture_end.Add(tikzpicture_end44.Tree);


            	// AST REWRITE
            	// elements:          tikzbody, tikzpicture_start, tikz_options, tikzpicture_end
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 142:64: -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:142:67: ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_PICTURE, "IM_PICTURE"), root_1);

            	    adaptor.AddChild(root_1, stream_tikzpicture_start.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:142:98: ( tikz_options )?
            	    if ( stream_tikz_options.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tikz_options.NextTree());

            	    }
            	    stream_tikz_options.Reset();
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:142:112: ( tikzbody )?
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:144:1: tikzpicture_start : BEGINTP -> ^( IM_STARTTAG BEGINTP ) ;
    public simpletikzParser.tikzpicture_start_return tikzpicture_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_start_return retval = new simpletikzParser.tikzpicture_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken BEGINTP45 = null;

        object BEGINTP45_tree=null;
        RewriteRuleTokenStream stream_BEGINTP = new RewriteRuleTokenStream(adaptor,"token BEGINTP");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:145:2: ( BEGINTP -> ^( IM_STARTTAG BEGINTP ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:145:4: BEGINTP
            {
            	BEGINTP45=(IToken)Match(input,BEGINTP,FOLLOW_BEGINTP_in_tikzpicture_start826);  
            	stream_BEGINTP.Add(BEGINTP45);



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
            	// 145:12: -> ^( IM_STARTTAG BEGINTP )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:145:15: ^( IM_STARTTAG BEGINTP )
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:1: tikzpicture_end : ENDTP -> ^( IM_ENDTAG ENDTP ) ;
    public simpletikzParser.tikzpicture_end_return tikzpicture_end() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzpicture_end_return retval = new simpletikzParser.tikzpicture_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ENDTP46 = null;

        object ENDTP46_tree=null;
        RewriteRuleTokenStream stream_ENDTP = new RewriteRuleTokenStream(adaptor,"token ENDTP");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:148:2: ( ENDTP -> ^( IM_ENDTAG ENDTP ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:148:4: ENDTP
            {
            	ENDTP46=(IToken)Match(input,ENDTP,FOLLOW_ENDTP_in_tikzpicture_end844);  
            	stream_ENDTP.Add(ENDTP46);



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
            	// 148:10: -> ^( IM_ENDTAG ENDTP )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:148:13: ^( IM_ENDTAG ENDTP )
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:150:1: tikzbody : ( tikzscope | tikzpath | tikznodee )+ ;
    public simpletikzParser.tikzbody_return tikzbody() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzbody_return retval = new simpletikzParser.tikzbody_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_return tikzscope47 = default(simpletikzParser.tikzscope_return);

        simpletikzParser.tikzpath_return tikzpath48 = default(simpletikzParser.tikzpath_return);

        simpletikzParser.tikznodee_return tikznodee49 = default(simpletikzParser.tikznodee_return);



        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:2: ( ( tikzscope | tikzpath | tikznodee )+ )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:4: ( tikzscope | tikzpath | tikznodee )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:4: ( tikzscope | tikzpath | tikznodee )+
            	int cnt14 = 0;
            	do 
            	{
            	    int alt14 = 4;
            	    switch ( input.LA(1) ) 
            	    {
            	    case BEGINSCOPE:
            	    	{
            	        alt14 = 1;
            	        }
            	        break;
            	    case DRAW:
            	    case PATH:
            	    case FILL:
            	    	{
            	        alt14 = 2;
            	        }
            	        break;
            	    case NODE:
            	    	{
            	        alt14 = 3;
            	        }
            	        break;

            	    }

            	    switch (alt14) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:6: tikzscope
            			    {
            			    	PushFollow(FOLLOW_tikzscope_in_tikzbody864);
            			    	tikzscope47 = tikzscope();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, tikzscope47.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:18: tikzpath
            			    {
            			    	PushFollow(FOLLOW_tikzpath_in_tikzbody868);
            			    	tikzpath48 = tikzpath();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, tikzpath48.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:29: tikznodee
            			    {
            			    	PushFollow(FOLLOW_tikznodee_in_tikzbody872);
            			    	tikznodee49 = tikznodee();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, tikznodee49.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt14 >= 1 ) goto loop14;
            		            EarlyExitException eee14 =
            		                new EarlyExitException(14, input);
            		            throw eee14;
            	    }
            	    cnt14++;
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whining that label 'loop14' has no statements


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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:154:1: tikzscope : tikzscope_start ( tikz_options )? tikzbody tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end ) ;
    public simpletikzParser.tikzscope_return tikzscope() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_return retval = new simpletikzParser.tikzscope_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.tikzscope_start_return tikzscope_start50 = default(simpletikzParser.tikzscope_start_return);

        simpletikzParser.tikz_options_return tikz_options51 = default(simpletikzParser.tikz_options_return);

        simpletikzParser.tikzbody_return tikzbody52 = default(simpletikzParser.tikzbody_return);

        simpletikzParser.tikzscope_end_return tikzscope_end53 = default(simpletikzParser.tikzscope_end_return);


        RewriteRuleSubtreeStream stream_tikzscope_start = new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_start");
        RewriteRuleSubtreeStream stream_tikzscope_end = new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_end");
        RewriteRuleSubtreeStream stream_tikzbody = new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options = new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:155:2: ( tikzscope_start ( tikz_options )? tikzbody tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:155:4: tikzscope_start ( tikz_options )? tikzbody tikzscope_end
            {
            	PushFollow(FOLLOW_tikzscope_start_in_tikzscope885);
            	tikzscope_start50 = tikzscope_start();
            	state.followingStackPointer--;

            	stream_tikzscope_start.Add(tikzscope_start50.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:155:20: ( tikz_options )?
            	int alt15 = 2;
            	int LA15_0 = input.LA(1);

            	if ( (LA15_0 == LBR) )
            	{
            	    alt15 = 1;
            	}
            	switch (alt15) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:155:20: tikz_options
            	        {
            	        	PushFollow(FOLLOW_tikz_options_in_tikzscope887);
            	        	tikz_options51 = tikz_options();
            	        	state.followingStackPointer--;

            	        	stream_tikz_options.Add(tikz_options51.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_tikzbody_in_tikzscope890);
            	tikzbody52 = tikzbody();
            	state.followingStackPointer--;

            	stream_tikzbody.Add(tikzbody52.Tree);
            	PushFollow(FOLLOW_tikzscope_end_in_tikzscope892);
            	tikzscope_end53 = tikzscope_end();
            	state.followingStackPointer--;

            	stream_tikzscope_end.Add(tikzscope_end53.Tree);


            	// AST REWRITE
            	// elements:          tikzscope_start, tikzscope_end, tikzbody, tikz_options
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 155:58: -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:155:61: ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_SCOPE, "IM_SCOPE"), root_1);

            	    adaptor.AddChild(root_1, stream_tikzscope_start.NextTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:155:88: ( tikz_options )?
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:157:1: tikzscope_start : BEGINSCOPE -> ^( IM_STARTTAG BEGINSCOPE ) ;
    public simpletikzParser.tikzscope_start_return tikzscope_start() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_start_return retval = new simpletikzParser.tikzscope_start_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken BEGINSCOPE54 = null;

        object BEGINSCOPE54_tree=null;
        RewriteRuleTokenStream stream_BEGINSCOPE = new RewriteRuleTokenStream(adaptor,"token BEGINSCOPE");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:158:2: ( BEGINSCOPE -> ^( IM_STARTTAG BEGINSCOPE ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:158:4: BEGINSCOPE
            {
            	BEGINSCOPE54=(IToken)Match(input,BEGINSCOPE,FOLLOW_BEGINSCOPE_in_tikzscope_start918);  
            	stream_BEGINSCOPE.Add(BEGINSCOPE54);



            	// AST REWRITE
            	// elements:          BEGINSCOPE
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 158:15: -> ^( IM_STARTTAG BEGINSCOPE )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:158:18: ^( IM_STARTTAG BEGINSCOPE )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_STARTTAG, "IM_STARTTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_BEGINSCOPE.NextNode());

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:160:1: tikzscope_end : ENDSCOPE -> ^( IM_ENDTAG ENDSCOPE ) ;
    public simpletikzParser.tikzscope_end_return tikzscope_end() // throws RecognitionException [1]
    {   
        simpletikzParser.tikzscope_end_return retval = new simpletikzParser.tikzscope_end_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ENDSCOPE55 = null;

        object ENDSCOPE55_tree=null;
        RewriteRuleTokenStream stream_ENDSCOPE = new RewriteRuleTokenStream(adaptor,"token ENDSCOPE");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:2: ( ENDSCOPE -> ^( IM_ENDTAG ENDSCOPE ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:4: ENDSCOPE
            {
            	ENDSCOPE55=(IToken)Match(input,ENDSCOPE,FOLLOW_ENDSCOPE_in_tikzscope_end936);  
            	stream_ENDSCOPE.Add(ENDSCOPE55);



            	// AST REWRITE
            	// elements:          ENDSCOPE
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 161:13: -> ^( IM_ENDTAG ENDSCOPE )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:16: ^( IM_ENDTAG ENDSCOPE )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ENDTAG, "IM_ENDTAG"), root_1);

            	    adaptor.AddChild(root_1, stream_ENDSCOPE.NextNode());

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:164:1: tikz_options : LBR ( option ( ',' option )* )? RBR -> ^( IM_OPTIONS ( option )* ) ;
    public simpletikzParser.tikz_options_return tikz_options() // throws RecognitionException [1]
    {   
        simpletikzParser.tikz_options_return retval = new simpletikzParser.tikz_options_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LBR56 = null;
        IToken char_literal58 = null;
        IToken RBR60 = null;
        simpletikzParser.option_return option57 = default(simpletikzParser.option_return);

        simpletikzParser.option_return option59 = default(simpletikzParser.option_return);


        object LBR56_tree=null;
        object char_literal58_tree=null;
        object RBR60_tree=null;
        RewriteRuleTokenStream stream_KOMMA = new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleTokenStream stream_RBR = new RewriteRuleTokenStream(adaptor,"token RBR");
        RewriteRuleTokenStream stream_LBR = new RewriteRuleTokenStream(adaptor,"token LBR");
        RewriteRuleSubtreeStream stream_option = new RewriteRuleSubtreeStream(adaptor,"rule option");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:2: ( LBR ( option ( ',' option )* )? RBR -> ^( IM_OPTIONS ( option )* ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:5: LBR ( option ( ',' option )* )? RBR
            {
            	LBR56=(IToken)Match(input,LBR,FOLLOW_LBR_in_tikz_options956);  
            	stream_LBR.Add(LBR56);

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:9: ( option ( ',' option )* )?
            	int alt17 = 2;
            	int LA17_0 = input.LA(1);

            	if ( (LA17_0 == ID) )
            	{
            	    alt17 = 1;
            	}
            	switch (alt17) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:10: option ( ',' option )*
            	        {
            	        	PushFollow(FOLLOW_option_in_tikz_options959);
            	        	option57 = option();
            	        	state.followingStackPointer--;

            	        	stream_option.Add(option57.Tree);
            	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:17: ( ',' option )*
            	        	do 
            	        	{
            	        	    int alt16 = 2;
            	        	    int LA16_0 = input.LA(1);

            	        	    if ( (LA16_0 == KOMMA) )
            	        	    {
            	        	        alt16 = 1;
            	        	    }


            	        	    switch (alt16) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:18: ',' option
            	        			    {
            	        			    	char_literal58=(IToken)Match(input,KOMMA,FOLLOW_KOMMA_in_tikz_options962);  
            	        			    	stream_KOMMA.Add(char_literal58);

            	        			    	PushFollow(FOLLOW_option_in_tikz_options964);
            	        			    	option59 = option();
            	        			    	state.followingStackPointer--;

            	        			    	stream_option.Add(option59.Tree);

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

            	RBR60=(IToken)Match(input,RBR,FOLLOW_RBR_in_tikz_options970);  
            	stream_RBR.Add(RBR60);



            	// AST REWRITE
            	// elements:          option
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 165:38: -> ^( IM_OPTIONS ( option )* )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:41: ^( IM_OPTIONS ( option )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTIONS, "IM_OPTIONS"), root_1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:54: ( option )*
            	    while ( stream_option.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_option.NextTree());

            	    }
            	    stream_option.Reset();

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:168:1: option : ( option_style -> ^( IM_OPTION_STYLE option_style ) | option_kv -> ^( IM_OPTION_KV option_kv ) );
    public simpletikzParser.option_return option() // throws RecognitionException [1]
    {   
        simpletikzParser.option_return retval = new simpletikzParser.option_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        simpletikzParser.option_style_return option_style61 = default(simpletikzParser.option_style_return);

        simpletikzParser.option_kv_return option_kv62 = default(simpletikzParser.option_kv_return);


        RewriteRuleSubtreeStream stream_option_style = new RewriteRuleSubtreeStream(adaptor,"rule option_style");
        RewriteRuleSubtreeStream stream_option_kv = new RewriteRuleSubtreeStream(adaptor,"rule option_kv");
        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:169:2: ( option_style -> ^( IM_OPTION_STYLE option_style ) | option_kv -> ^( IM_OPTION_KV option_kv ) )
            int alt18 = 2;
            alt18 = dfa18.Predict(input);
            switch (alt18) 
            {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:169:4: option_style
                    {
                    	PushFollow(FOLLOW_option_style_in_option992);
                    	option_style61 = option_style();
                    	state.followingStackPointer--;

                    	stream_option_style.Add(option_style61.Tree);


                    	// AST REWRITE
                    	// elements:          option_style
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 169:19: -> ^( IM_OPTION_STYLE option_style )
                    	{
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:169:22: ^( IM_OPTION_STYLE option_style )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTION_STYLE, "IM_OPTION_STYLE"), root_1);

                    	    adaptor.AddChild(root_1, stream_option_style.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:170:5: option_kv
                    {
                    	PushFollow(FOLLOW_option_kv_in_option1008);
                    	option_kv62 = option_kv();
                    	state.followingStackPointer--;

                    	stream_option_kv.Add(option_kv62.Tree);


                    	// AST REWRITE
                    	// elements:          option_kv
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 170:16: -> ^( IM_OPTION_KV option_kv )
                    	{
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:170:19: ^( IM_OPTION_KV option_kv )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_OPTION_KV, "IM_OPTION_KV"), root_1);

                    	    adaptor.AddChild(root_1, stream_option_kv.NextTree());

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:172:1: option_kv : idd ( '=' ( idd | numberunit ) )? ;
    public simpletikzParser.option_kv_return option_kv() // throws RecognitionException [1]
    {   
        simpletikzParser.option_kv_return retval = new simpletikzParser.option_kv_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal64 = null;
        simpletikzParser.idd_return idd63 = default(simpletikzParser.idd_return);

        simpletikzParser.idd_return idd65 = default(simpletikzParser.idd_return);

        simpletikzParser.numberunit_return numberunit66 = default(simpletikzParser.numberunit_return);


        object char_literal64_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:2: ( idd ( '=' ( idd | numberunit ) )? )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:4: idd ( '=' ( idd | numberunit ) )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_idd_in_option_kv1027);
            	idd63 = idd();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, idd63.Tree);
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:8: ( '=' ( idd | numberunit ) )?
            	int alt20 = 2;
            	int LA20_0 = input.LA(1);

            	if ( (LA20_0 == EQU) )
            	{
            	    alt20 = 1;
            	}
            	switch (alt20) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:9: '=' ( idd | numberunit )
            	        {
            	        	char_literal64=(IToken)Match(input,EQU,FOLLOW_EQU_in_option_kv1030); 
            	        	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:14: ( idd | numberunit )
            	        	int alt19 = 2;
            	        	int LA19_0 = input.LA(1);

            	        	if ( (LA19_0 == ID) )
            	        	{
            	        	    alt19 = 1;
            	        	}
            	        	else if ( ((LA19_0 >= FLOAT && LA19_0 <= INT)) )
            	        	{
            	        	    alt19 = 2;
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
            	        	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:15: idd
            	        	        {
            	        	        	PushFollow(FOLLOW_idd_in_option_kv1034);
            	        	        	idd65 = idd();
            	        	        	state.followingStackPointer--;

            	        	        	adaptor.AddChild(root_0, idd65.Tree);

            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:21: numberunit
            	        	        {
            	        	        	PushFollow(FOLLOW_numberunit_in_option_kv1038);
            	        	        	numberunit66 = numberunit();
            	        	        	state.followingStackPointer--;

            	        	        	adaptor.AddChild(root_0, numberunit66.Tree);

            	        	        }
            	        	        break;

            	        	}


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
    // $ANTLR end "option_kv"

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:175:1: option_style : idd '/.style' '=' STRING ;
    public simpletikzParser.option_style_return option_style() // throws RecognitionException [1]
    {   
        simpletikzParser.option_style_return retval = new simpletikzParser.option_style_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal68 = null;
        IToken char_literal69 = null;
        IToken STRING70 = null;
        simpletikzParser.idd_return idd67 = default(simpletikzParser.idd_return);


        object string_literal68_tree=null;
        object char_literal69_tree=null;
        object STRING70_tree=null;

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:176:2: ( idd '/.style' '=' STRING )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:176:4: idd '/.style' '=' STRING
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_idd_in_option_style1051);
            	idd67 = idd();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, idd67.Tree);
            	string_literal68=(IToken)Match(input,62,FOLLOW_62_in_option_style1053); 
            	char_literal69=(IToken)Match(input,EQU,FOLLOW_EQU_in_option_style1056); 
            	STRING70=(IToken)Match(input,STRING,FOLLOW_STRING_in_option_style1059); 
            		STRING70_tree = (object)adaptor.Create(STRING70);
            		adaptor.AddChild(root_0, STRING70_tree);


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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:180:1: idd : ID ( ID )* -> ^( IM_ID ( ID )* ) ;
    public simpletikzParser.idd_return idd() // throws RecognitionException [1]
    {   
        simpletikzParser.idd_return retval = new simpletikzParser.idd_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID71 = null;
        IToken ID72 = null;

        object ID71_tree=null;
        object ID72_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:181:2: ( ID ( ID )* -> ^( IM_ID ( ID )* ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:181:4: ID ( ID )*
            {
            	ID71=(IToken)Match(input,ID,FOLLOW_ID_in_idd1072);  
            	stream_ID.Add(ID71);

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:181:7: ( ID )*
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
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:181:8: ID
            			    {
            			    	ID72=(IToken)Match(input,ID,FOLLOW_ID_in_idd1075);  
            			    	stream_ID.Add(ID72);


            			    }
            			    break;

            			default:
            			    goto loop21;
            	    }
            	} while (true);

            	loop21:
            		;	// Stops C# compiler whining that label 'loop21' has no statements



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
            	// 181:13: -> ^( IM_ID ( ID )* )
            	{
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:181:16: ^( IM_ID ( ID )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IM_ID, "IM_ID"), root_1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:181:24: ( ID )*
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

    // Delegated rules


   	protected DFA18 dfa18;
	private void InitializeCyclicDFAs()
	{
    	this.dfa18 = new DFA18(this);
	}

    const string DFA18_eotS =
        "\x05\uffff";
    const string DFA18_eofS =
        "\x05\uffff";
    const string DFA18_minS =
        "\x01\x28\x02\x11\x02\uffff";
    const string DFA18_maxS =
        "\x01\x28\x02\x3e\x02\uffff";
    const string DFA18_acceptS =
        "\x03\uffff\x01\x01\x01\x02";
    const string DFA18_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA18_transitionS = {
            "\x01\x01",
            "\x01\x04\x02\uffff\x02\x04\x12\uffff\x01\x02\x15\uffff\x01"+
            "\x03",
            "\x01\x04\x02\uffff\x02\x04\x12\uffff\x01\x02\x15\uffff\x01"+
            "\x03",
            "",
            ""
    };

    static readonly short[] DFA18_eot = DFA.UnpackEncodedString(DFA18_eotS);
    static readonly short[] DFA18_eof = DFA.UnpackEncodedString(DFA18_eofS);
    static readonly char[] DFA18_min = DFA.UnpackEncodedStringToUnsignedChars(DFA18_minS);
    static readonly char[] DFA18_max = DFA.UnpackEncodedStringToUnsignedChars(DFA18_maxS);
    static readonly short[] DFA18_accept = DFA.UnpackEncodedString(DFA18_acceptS);
    static readonly short[] DFA18_special = DFA.UnpackEncodedString(DFA18_specialS);
    static readonly short[][] DFA18_transition = DFA.UnpackEncodedStringArray(DFA18_transitionS);

    protected class DFA18 : DFA
    {
        public DFA18(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 18;
            this.eot = DFA18_eot;
            this.eof = DFA18_eof;
            this.min = DFA18_min;
            this.max = DFA18_max;
            this.accept = DFA18_accept;
            this.special = DFA18_special;
            this.transition = DFA18_transition;

        }

        override public string Description
        {
            get { return "168:1: option : ( option_style -> ^( IM_OPTION_STYLE option_style ) | option_kv -> ^( IM_OPTION_KV option_kv ) );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_SOMETHING_in_tikzdocument315 = new BitSet(new ulong[]{0x0000004000000040UL});
    public static readonly BitSet FOLLOW_tikzpicture_in_tikzdocument318 = new BitSet(new ulong[]{0x0000004000000002UL});
    public static readonly BitSet FOLLOW_SOMETHING_in_tikzdocument321 = new BitSet(new ulong[]{0x0000004000000002UL});
    public static readonly BitSet FOLLOW_path_start_in_tikzpath343 = new BitSet(new ulong[]{0x0180800000004000UL});
    public static readonly BitSet FOLLOW_tikzpathi_in_tikzpath345 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_path_end_in_tikzpath347 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SEMIC_in_path_end370 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coordornode_in_tikzpathi390 = new BitSet(new ulong[]{0x01FE800000014002UL});
    public static readonly BitSet FOLLOW_coordornode_in_tikzpathi393 = new BitSet(new ulong[]{0x01FE800000014002UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpathi397 = new BitSet(new ulong[]{0x01FE800000014000UL});
    public static readonly BitSet FOLLOW_edgeop_in_tikzpathi400 = new BitSet(new ulong[]{0x0180800000004000UL});
    public static readonly BitSet FOLLOW_coordornode_in_tikzpathi403 = new BitSet(new ulong[]{0x01FE800000014002UL});
    public static readonly BitSet FOLLOW_coord_in_coordornode418 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikznodei_in_coordornode422 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_47_in_tikznodei434 = new BitSet(new ulong[]{0x0001008000004000UL});
    public static readonly BitSet FOLLOW_tikznode_in_tikznodei437 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_node_start_in_tikznodee447 = new BitSet(new ulong[]{0x0001008000004000UL});
    public static readonly BitSet FOLLOW_tikznode_in_tikznodee449 = new BitSet(new ulong[]{0x0180800000404000UL});
    public static readonly BitSet FOLLOW_tikzpathi_in_tikznodee451 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_path_end_in_tikznodee454 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NODE_in_node_start480 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_tikznode498 = new BitSet(new ulong[]{0x0001008000000000UL});
    public static readonly BitSet FOLLOW_48_in_tikznode502 = new BitSet(new ulong[]{0x0180000000004000UL});
    public static readonly BitSet FOLLOW_coord_in_tikznode504 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_STRING_in_tikznode508 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_edgeop0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAR_in_nodename573 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_ID_in_nodename577 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RPAR_in_nodename579 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nodename_in_coord604 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_coord_modifier_in_coord628 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LPAR_in_coord633 = new BitSet(new ulong[]{0x0000060000000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord635 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_KOMMA_in_coord637 = new BitSet(new ulong[]{0x0000060000000000UL});
    public static readonly BitSet FOLLOW_numberunit_in_coord639 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RPAR_in_coord641 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_coord_modifier0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_number_in_numberunit683 = new BitSet(new ulong[]{0x3E00000000000002UL});
    public static readonly BitSet FOLLOW_unit_in_numberunit685 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_number708 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unit0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_path_start_tag_in_path_start752 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_path_start_tag0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzpicture_start_in_tikzpicture791 = new BitSet(new ulong[]{0x0000000000013D80UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzpicture793 = new BitSet(new ulong[]{0x0000000000013D80UL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzpicture796 = new BitSet(new ulong[]{0x0000000000013D80UL});
    public static readonly BitSet FOLLOW_tikzpicture_end_in_tikzpicture799 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BEGINTP_in_tikzpicture_start826 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ENDTP_in_tikzpicture_end844 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tikzscope_in_tikzbody864 = new BitSet(new ulong[]{0x0000000000003D02UL});
    public static readonly BitSet FOLLOW_tikzpath_in_tikzbody868 = new BitSet(new ulong[]{0x0000000000003D02UL});
    public static readonly BitSet FOLLOW_tikznodee_in_tikzbody872 = new BitSet(new ulong[]{0x0000000000003D02UL});
    public static readonly BitSet FOLLOW_tikzscope_start_in_tikzscope885 = new BitSet(new ulong[]{0x0000000000013D00UL});
    public static readonly BitSet FOLLOW_tikz_options_in_tikzscope887 = new BitSet(new ulong[]{0x0000000000003D00UL});
    public static readonly BitSet FOLLOW_tikzbody_in_tikzscope890 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_tikzscope_end_in_tikzscope892 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BEGINSCOPE_in_tikzscope_start918 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ENDSCOPE_in_tikzscope_end936 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBR_in_tikz_options956 = new BitSet(new ulong[]{0x0000010000020000UL});
    public static readonly BitSet FOLLOW_option_in_tikz_options959 = new BitSet(new ulong[]{0x0000000000120000UL});
    public static readonly BitSet FOLLOW_KOMMA_in_tikz_options962 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_option_in_tikz_options964 = new BitSet(new ulong[]{0x0000000000120000UL});
    public static readonly BitSet FOLLOW_RBR_in_tikz_options970 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_option_style_in_option992 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_option_kv_in_option1008 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_option_kv1027 = new BitSet(new ulong[]{0x0000000000200002UL});
    public static readonly BitSet FOLLOW_EQU_in_option_kv1030 = new BitSet(new ulong[]{0x0000070000000000UL});
    public static readonly BitSet FOLLOW_idd_in_option_kv1034 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_numberunit_in_option_kv1038 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_idd_in_option_style1051 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_62_in_option_style1053 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_EQU_in_option_style1056 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_STRING_in_option_style1059 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_idd1072 = new BitSet(new ulong[]{0x0000010000000002UL});
    public static readonly BitSet FOLLOW_ID_in_idd1075 = new BitSet(new ulong[]{0x0000010000000002UL});

}
