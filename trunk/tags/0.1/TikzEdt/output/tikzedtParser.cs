// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g 2010-12-20 22:48:27

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

public partial class tikzedtParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"TIKZEDT", 
		"INPUT", 
		"USEPACKAGE", 
		"USETIKZLIB", 
		"DOCUMENTCLASS", 
		"TIKZSTYLES", 
		"BEGIN", 
		"TIKZPICTURE", 
		"NODE", 
		"DRAW", 
		"PATH", 
		"STYLESEP", 
		"IM_COMMENT", 
		"NEWLINE", 
		"SOMETHING_IN_BRACKETS", 
		"SOMETHING_IN_CURLY_BRACKETS", 
		"WS", 
		"TIKZEDT_CMD_COMMENT", 
		"ID", 
		"INT", 
		"FLOAT", 
		"COMMENT", 
		"HEX_DIGIT"
    };

    public const int SOMETHING_IN_BRACKETS = 18;
    public const int TIKZEDT_CMD_COMMENT = 21;
    public const int NODE = 12;
    public const int TIKZPICTURE = 11;
    public const int STYLESEP = 15;
    public const int INPUT = 5;
    public const int HEX_DIGIT = 26;
    public const int FLOAT = 24;
    public const int INT = 23;
    public const int USEPACKAGE = 6;
    public const int ID = 22;
    public const int EOF = -1;
    public const int SOMETHING_IN_CURLY_BRACKETS = 19;
    public const int TIKZSTYLES = 9;
    public const int USETIKZLIB = 7;
    public const int WS = 20;
    public const int NEWLINE = 17;
    public const int PATH = 14;
    public const int BEGIN = 10;
    public const int TIKZEDT = 4;
    public const int IM_COMMENT = 16;
    public const int COMMENT = 25;
    public const int DOCUMENTCLASS = 8;
    public const int DRAW = 13;

    // delegates
    // delegators



        public tikzedtParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public tikzedtParser(ITokenStream input, RecognizerSharedState state)
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
		get { return tikzedtParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g"; }
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
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:51:1: tikzdocument : ( doublenewline | known_cmd | unknown_cmd )* ;
    public tikzedtParser.tikzdocument_return tikzdocument() // throws RecognitionException [1]
    {   
        tikzedtParser.tikzdocument_return retval = new tikzedtParser.tikzdocument_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        tikzedtParser.doublenewline_return doublenewline1 = default(tikzedtParser.doublenewline_return);

        tikzedtParser.known_cmd_return known_cmd2 = default(tikzedtParser.known_cmd_return);

        tikzedtParser.unknown_cmd_return unknown_cmd3 = default(tikzedtParser.unknown_cmd_return);



        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:52:2: ( ( doublenewline | known_cmd | unknown_cmd )* )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:52:5: ( doublenewline | known_cmd | unknown_cmd )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:52:5: ( doublenewline | known_cmd | unknown_cmd )*
            	do 
            	{
            	    int alt1 = 4;
            	    switch ( input.LA(1) ) 
            	    {
            	    case NEWLINE:
            	    	{
            	        alt1 = 1;
            	        }
            	        break;
            	    case INPUT:
            	    	{
            	        alt1 = 2;
            	        }
            	        break;
            	    case TIKZEDT:
            	    case USEPACKAGE:
            	    case USETIKZLIB:
            	    case DOCUMENTCLASS:
            	    case TIKZSTYLES:
            	    case BEGIN:
            	    case TIKZPICTURE:
            	    case NODE:
            	    case DRAW:
            	    case PATH:
            	    case STYLESEP:
            	    case IM_COMMENT:
            	    case SOMETHING_IN_BRACKETS:
            	    case SOMETHING_IN_CURLY_BRACKETS:
            	    case WS:
            	    case TIKZEDT_CMD_COMMENT:
            	    case ID:
            	    case INT:
            	    case FLOAT:
            	    case COMMENT:
            	    case HEX_DIGIT:
            	    	{
            	        alt1 = 3;
            	        }
            	        break;

            	    }

            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:52:6: doublenewline
            			    {
            			    	PushFollow(FOLLOW_doublenewline_in_tikzdocument174);
            			    	doublenewline1 = doublenewline();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, doublenewline1.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:52:22: known_cmd
            			    {
            			    	PushFollow(FOLLOW_known_cmd_in_tikzdocument178);
            			    	known_cmd2 = known_cmd();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, known_cmd2.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:52:34: unknown_cmd
            			    {
            			    	PushFollow(FOLLOW_unknown_cmd_in_tikzdocument182);
            			    	unknown_cmd3 = unknown_cmd();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, unknown_cmd3.Tree);

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements


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

    public class doublenewline_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "doublenewline"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:58:1: doublenewline : NEWLINE NEWLINE ;
    public tikzedtParser.doublenewline_return doublenewline() // throws RecognitionException [1]
    {   
        tikzedtParser.doublenewline_return retval = new tikzedtParser.doublenewline_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NEWLINE4 = null;
        IToken NEWLINE5 = null;

        object NEWLINE4_tree=null;
        object NEWLINE5_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:59:2: ( NEWLINE NEWLINE )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:59:4: NEWLINE NEWLINE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	NEWLINE4=(IToken)Match(input,NEWLINE,FOLLOW_NEWLINE_in_doublenewline199); 
            		NEWLINE4_tree = (object)adaptor.Create(NEWLINE4);
            		adaptor.AddChild(root_0, NEWLINE4_tree);

            	NEWLINE5=(IToken)Match(input,NEWLINE,FOLLOW_NEWLINE_in_doublenewline201); 
            		NEWLINE5_tree = (object)adaptor.Create(NEWLINE5);
            		adaptor.AddChild(root_0, NEWLINE5_tree);


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
    // $ANTLR end "doublenewline"

    public class unknown_cmd_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "unknown_cmd"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:63:1: unknown_cmd : (~ ( INPUT | NEWLINE ) )+ ( NEWLINE )? ;
    public tikzedtParser.unknown_cmd_return unknown_cmd() // throws RecognitionException [1]
    {   
        tikzedtParser.unknown_cmd_return retval = new tikzedtParser.unknown_cmd_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set6 = null;
        IToken NEWLINE7 = null;

        object set6_tree=null;
        object NEWLINE7_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:64:2: ( (~ ( INPUT | NEWLINE ) )+ ( NEWLINE )? )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:64:4: (~ ( INPUT | NEWLINE ) )+ ( NEWLINE )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:64:4: (~ ( INPUT | NEWLINE ) )+
            	int cnt2 = 0;
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == TIKZEDT || (LA2_0 >= USEPACKAGE && LA2_0 <= IM_COMMENT) || (LA2_0 >= SOMETHING_IN_BRACKETS && LA2_0 <= HEX_DIGIT)) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:64:4: ~ ( INPUT | NEWLINE )
            			    {
            			    	set6 = (IToken)input.LT(1);
            			    	if ( input.LA(1) == TIKZEDT || (input.LA(1) >= USEPACKAGE && input.LA(1) <= IM_COMMENT) || (input.LA(1) >= SOMETHING_IN_BRACKETS && input.LA(1) <= HEX_DIGIT) ) 
            			    	{
            			    	    input.Consume();
            			    	    adaptor.AddChild(root_0, (object)adaptor.Create(set6));
            			    	    state.errorRecovery = false;
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}


            			    }
            			    break;

            			default:
            			    if ( cnt2 >= 1 ) goto loop2;
            		            EarlyExitException eee2 =
            		                new EarlyExitException(2, input);
            		            throw eee2;
            	    }
            	    cnt2++;
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:64:24: ( NEWLINE )?
            	int alt3 = 2;
            	alt3 = dfa3.Predict(input);
            	switch (alt3) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:64:24: NEWLINE
            	        {
            	        	NEWLINE7=(IToken)Match(input,NEWLINE,FOLLOW_NEWLINE_in_unknown_cmd224); 
            	        		NEWLINE7_tree = (object)adaptor.Create(NEWLINE7);
            	        		adaptor.AddChild(root_0, NEWLINE7_tree);


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
    // $ANTLR end "unknown_cmd"

    public class known_cmd_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "known_cmd"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:67:1: known_cmd : INPUT ( SOMETHING_IN_BRACKETS )? SOMETHING_IN_CURLY_BRACKETS ;
    public tikzedtParser.known_cmd_return known_cmd() // throws RecognitionException [1]
    {   
        tikzedtParser.known_cmd_return retval = new tikzedtParser.known_cmd_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INPUT8 = null;
        IToken SOMETHING_IN_BRACKETS9 = null;
        IToken SOMETHING_IN_CURLY_BRACKETS10 = null;

        object INPUT8_tree=null;
        object SOMETHING_IN_BRACKETS9_tree=null;
        object SOMETHING_IN_CURLY_BRACKETS10_tree=null;

        try 
    	{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:68:2: ( INPUT ( SOMETHING_IN_BRACKETS )? SOMETHING_IN_CURLY_BRACKETS )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:68:4: INPUT ( SOMETHING_IN_BRACKETS )? SOMETHING_IN_CURLY_BRACKETS
            {
            	root_0 = (object)adaptor.GetNilNode();

            	INPUT8=(IToken)Match(input,INPUT,FOLLOW_INPUT_in_known_cmd236); 
            		INPUT8_tree = (object)adaptor.Create(INPUT8);
            		adaptor.AddChild(root_0, INPUT8_tree);

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:68:10: ( SOMETHING_IN_BRACKETS )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == SOMETHING_IN_BRACKETS) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:68:10: SOMETHING_IN_BRACKETS
            	        {
            	        	SOMETHING_IN_BRACKETS9=(IToken)Match(input,SOMETHING_IN_BRACKETS,FOLLOW_SOMETHING_IN_BRACKETS_in_known_cmd238); 
            	        		SOMETHING_IN_BRACKETS9_tree = (object)adaptor.Create(SOMETHING_IN_BRACKETS9);
            	        		adaptor.AddChild(root_0, SOMETHING_IN_BRACKETS9_tree);


            	        }
            	        break;

            	}

            	SOMETHING_IN_CURLY_BRACKETS10=(IToken)Match(input,SOMETHING_IN_CURLY_BRACKETS,FOLLOW_SOMETHING_IN_CURLY_BRACKETS_in_known_cmd241); 
            		SOMETHING_IN_CURLY_BRACKETS10_tree = (object)adaptor.Create(SOMETHING_IN_CURLY_BRACKETS10);
            		adaptor.AddChild(root_0, SOMETHING_IN_CURLY_BRACKETS10_tree);


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
    // $ANTLR end "known_cmd"

    // Delegated rules


   	protected DFA3 dfa3;
	private void InitializeCyclicDFAs()
	{
    	this.dfa3 = new DFA3(this);
	}

    const string DFA3_eotS =
        "\x06\uffff";
    const string DFA3_eofS =
        "\x01\x02\x01\x04\x01\uffff\x01\x02\x01\uffff\x01\x04";
    const string DFA3_minS =
        "\x02\x04\x01\uffff\x01\x04\x01\uffff\x01\x04";
    const string DFA3_maxS =
        "\x02\x1a\x01\uffff\x01\x1a\x01\uffff\x01\x1a";
    const string DFA3_acceptS =
        "\x02\uffff\x01\x02\x01\uffff\x01\x01\x01\uffff";
    const string DFA3_specialS =
        "\x06\uffff}>";
    static readonly string[] DFA3_transitionS = {
            "\x0d\x02\x01\x01\x09\x02",
            "\x0d\x04\x01\x03\x09\x04",
            "",
            "\x0d\x02\x01\x05\x09\x02",
            "",
            "\x0d\x04\x01\x03\x09\x04"
    };

    static readonly short[] DFA3_eot = DFA.UnpackEncodedString(DFA3_eotS);
    static readonly short[] DFA3_eof = DFA.UnpackEncodedString(DFA3_eofS);
    static readonly char[] DFA3_min = DFA.UnpackEncodedStringToUnsignedChars(DFA3_minS);
    static readonly char[] DFA3_max = DFA.UnpackEncodedStringToUnsignedChars(DFA3_maxS);
    static readonly short[] DFA3_accept = DFA.UnpackEncodedString(DFA3_acceptS);
    static readonly short[] DFA3_special = DFA.UnpackEncodedString(DFA3_specialS);
    static readonly short[][] DFA3_transition = DFA.UnpackEncodedStringArray(DFA3_transitionS);

    protected class DFA3 : DFA
    {
        public DFA3(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 3;
            this.eot = DFA3_eot;
            this.eof = DFA3_eof;
            this.min = DFA3_min;
            this.max = DFA3_max;
            this.accept = DFA3_accept;
            this.special = DFA3_special;
            this.transition = DFA3_transition;

        }

        override public string Description
        {
            get { return "64:24: ( NEWLINE )?"; }
        }

    }

 

    public static readonly BitSet FOLLOW_doublenewline_in_tikzdocument174 = new BitSet(new ulong[]{0x0000000007FFFFF2UL});
    public static readonly BitSet FOLLOW_known_cmd_in_tikzdocument178 = new BitSet(new ulong[]{0x0000000007FFFFF2UL});
    public static readonly BitSet FOLLOW_unknown_cmd_in_tikzdocument182 = new BitSet(new ulong[]{0x0000000007FFFFF2UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_doublenewline199 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_doublenewline201 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unknown_cmd214 = new BitSet(new ulong[]{0x0000000007FFFFD2UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_unknown_cmd224 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INPUT_in_known_cmd236 = new BitSet(new ulong[]{0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_SOMETHING_IN_BRACKETS_in_known_cmd238 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_SOMETHING_IN_CURLY_BRACKETS_in_known_cmd241 = new BitSet(new ulong[]{0x0000000000000002UL});

}
