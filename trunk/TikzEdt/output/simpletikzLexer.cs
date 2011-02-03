// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g 2011-02-03 08:00:09

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public partial class simpletikzLexer : Lexer {
    public const int T__68 = 68;
    public const int T__69 = 69;
    public const int T__66 = 66;
    public const int T__67 = 67;
    public const int EXPONENT = 34;
    public const int T__64 = 64;
    public const int T__65 = 65;
    public const int IM_STARTTAG = 13;
    public const int TIKZEDT_CMD_COMMENT = 27;
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
    public const int T__46 = 46;
    public const int T__80 = 80;
    public const int IM_OPTIONS = 15;
    public const int T__47 = 47;
    public const int T__81 = 81;
    public const int T__44 = 44;
    public const int T__82 = 82;
    public const int IM_OPTION_STYLE = 16;
    public const int T__45 = 45;
    public const int T__83 = 83;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int IM_COORD = 6;
    public const int IM_PICTURE = 10;
    public const int INT = 30;
    public const int T__84 = 84;
    public const int IM_NODE = 5;
    public const int IM_STYLE = 22;
    public const int IM_NUMBERUNIT = 9;
    public const int IM_SCOPE = 12;
    public const int T__71 = 71;
    public const int WS = 32;
    public const int T__72 = 72;
    public const int T__70 = 70;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int IM_SIZE = 7;
    public const int T__76 = 76;
    public const int T__75 = 75;
    public const int T__74 = 74;
    public const int T__73 = 73;
    public const int IM_NODENAME = 8;
    public const int T__79 = 79;
    public const int T__78 = 78;
    public const int FLOAT_WO_EXP = 29;
    public const int T__77 = 77;

        //@Override
        public override void ReportError(RecognitionException e) {
        	//if there is no Node we forward what the parser was looking for.
            if(e.Node == null)    
    	    e.Node = ExpectedToken;
            throw e;
        }
        
        //Here we store what the parser is looking for next.
        //It it does not succeed, we can use this variable to tell the user what
        //the parser was looking for.
        string ExpectedToken;
        //@Override
        public override void Match(string s)
        {
            ExpectedToken = s;
            base.Match(s);
        }


    // delegates
    // delegators

    public simpletikzLexer() 
    {
		InitializeCyclicDFAs();
    }
    public simpletikzLexer(ICharStream input)
		: this(input, null) {
    }
    public simpletikzLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g";} 
    }

    // $ANTLR start "T__38"
    public void mT__38() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__38;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:28:7: ( '\\\\begin' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:28:9: '\\\\begin'
            {
            	Match("\\begin"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__38"

    // $ANTLR start "T__39"
    public void mT__39() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__39;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:29:7: ( '\\\\tikzstyle' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:29:9: '\\\\tikzstyle'
            {
            	Match("\\tikzstyle"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__39"

    // $ANTLR start "T__40"
    public void mT__40() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__40;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:30:7: ( '\\\\tikzset' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:30:9: '\\\\tikzset'
            {
            	Match("\\tikzset"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__40"

    // $ANTLR start "T__41"
    public void mT__41() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__41;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:31:7: ( '{' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:31:9: '{'
            {
            	Match('{'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__41"

    // $ANTLR start "T__42"
    public void mT__42() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__42;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:32:7: ( '}' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:32:9: '}'
            {
            	Match('}'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__42"

    // $ANTLR start "T__43"
    public void mT__43() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__43;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:33:7: ( '=' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:33:9: '='
            {
            	Match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__43"

    // $ANTLR start "T__44"
    public void mT__44() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__44;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:34:7: ( ',' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:34:9: ','
            {
            	Match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__44"

    // $ANTLR start "T__45"
    public void mT__45() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__45;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:35:7: ( ':' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:35:9: ':'
            {
            	Match(':'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__45"

    // $ANTLR start "T__46"
    public void mT__46() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__46;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:36:7: ( '/.style' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:36:9: '/.style'
            {
            	Match("/.style"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__46"

    // $ANTLR start "T__47"
    public void mT__47() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__47;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:37:7: ( '/.append' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:37:9: '/.append'
            {
            	Match("/.append"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__47"

    // $ANTLR start "T__48"
    public void mT__48() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__48;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:38:7: ( 'style' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:38:9: 'style'
            {
            	Match("style"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__48"

    // $ANTLR start "T__49"
    public void mT__49() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__49;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:39:7: ( '(' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:39:9: '('
            {
            	Match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__49"

    // $ANTLR start "T__50"
    public void mT__50() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__50;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:40:7: ( ')' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:40:9: ')'
            {
            	Match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__50"

    // $ANTLR start "T__51"
    public void mT__51() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__51;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:41:7: ( '[' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:41:9: '['
            {
            	Match('['); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__51"

    // $ANTLR start "T__52"
    public void mT__52() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__52;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:42:7: ( ']' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:42:9: ']'
            {
            	Match(']'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__52"

    // $ANTLR start "T__53"
    public void mT__53() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__53;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:43:7: ( ';' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:43:9: ';'
            {
            	Match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__53"

    // $ANTLR start "T__54"
    public void mT__54() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__54;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:44:7: ( 'cm' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:44:9: 'cm'
            {
            	Match("cm"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__54"

    // $ANTLR start "T__55"
    public void mT__55() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__55;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:45:7: ( 'in' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:45:9: 'in'
            {
            	Match("in"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__55"

    // $ANTLR start "T__56"
    public void mT__56() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__56;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:46:7: ( 'ex' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:46:9: 'ex'
            {
            	Match("ex"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__56"

    // $ANTLR start "T__57"
    public void mT__57() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__57;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:47:7: ( 'mm' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:47:9: 'mm'
            {
            	Match("mm"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__57"

    // $ANTLR start "T__58"
    public void mT__58() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__58;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:48:7: ( 'pt' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:48:9: 'pt'
            {
            	Match("pt"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__58"

    // $ANTLR start "T__59"
    public void mT__59() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__59;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:49:7: ( 'em' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:49:9: 'em'
            {
            	Match("em"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__59"

    // $ANTLR start "T__60"
    public void mT__60() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__60;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:50:7: ( '\\\\end' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:50:9: '\\\\end'
            {
            	Match("\\end"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__60"

    // $ANTLR start "T__61"
    public void mT__61() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__61;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:51:7: ( '\\\\node' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:51:9: '\\\\node'
            {
            	Match("\\node"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__61"

    // $ANTLR start "T__62"
    public void mT__62() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__62;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:52:7: ( '\\\\coordinate' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:52:9: '\\\\coordinate'
            {
            	Match("\\coordinate"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__62"

    // $ANTLR start "T__63"
    public void mT__63() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__63;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:53:7: ( '\\\\draw' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:53:9: '\\\\draw'
            {
            	Match("\\draw"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__63"

    // $ANTLR start "T__64"
    public void mT__64() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__64;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:54:7: ( '\\\\path' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:54:9: '\\\\path'
            {
            	Match("\\path"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__64"

    // $ANTLR start "T__65"
    public void mT__65() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__65;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:55:7: ( '\\\\fill' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:55:9: '\\\\fill'
            {
            	Match("\\fill"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__65"

    // $ANTLR start "T__66"
    public void mT__66() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__66;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:56:7: ( '\\\\clip' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:56:9: '\\\\clip'
            {
            	Match("\\clip"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__66"

    // $ANTLR start "T__67"
    public void mT__67() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__67;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:57:7: ( 'let' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:57:9: 'let'
            {
            	Match("let"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__67"

    // $ANTLR start "T__68"
    public void mT__68() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__68;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:58:7: ( 'and' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:58:9: 'and'
            {
            	Match("and"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__68"

    // $ANTLR start "T__69"
    public void mT__69() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__69;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:59:7: ( 'coordinate' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:59:9: 'coordinate'
            {
            	Match("coordinate"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__69"

    // $ANTLR start "T__70"
    public void mT__70() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__70;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:60:7: ( 'node' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:60:9: 'node'
            {
            	Match("node"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__70"

    // $ANTLR start "T__71"
    public void mT__71() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__71;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:61:7: ( 'at' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:61:9: 'at'
            {
            	Match("at"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__71"

    // $ANTLR start "T__72"
    public void mT__72() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__72;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:62:7: ( 'circle' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:62:9: 'circle'
            {
            	Match("circle"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__72"

    // $ANTLR start "T__73"
    public void mT__73() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__73;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:63:7: ( 'ellipse' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:63:9: 'ellipse'
            {
            	Match("ellipse"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__73"

    // $ANTLR start "T__74"
    public void mT__74() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__74;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:64:7: ( 'arc' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:64:9: 'arc'
            {
            	Match("arc"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__74"

    // $ANTLR start "T__75"
    public void mT__75() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__75;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:65:7: ( '--' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:65:9: '--'
            {
            	Match("--"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__75"

    // $ANTLR start "T__76"
    public void mT__76() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__76;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:66:7: ( '->' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:66:9: '->'
            {
            	Match("->"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__76"

    // $ANTLR start "T__77"
    public void mT__77() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__77;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:67:7: ( '|-' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:67:9: '|-'
            {
            	Match("|-"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__77"

    // $ANTLR start "T__78"
    public void mT__78() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__78;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:68:7: ( '-|' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:68:9: '-|'
            {
            	Match("-|"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__78"

    // $ANTLR start "T__79"
    public void mT__79() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__79;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:69:7: ( '+' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:69:9: '+'
            {
            	Match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__79"

    // $ANTLR start "T__80"
    public void mT__80() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__80;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:70:7: ( '++' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:70:9: '++'
            {
            	Match("++"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__80"

    // $ANTLR start "T__81"
    public void mT__81() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__81;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:71:7: ( '..' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:71:9: '..'
            {
            	Match(".."); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__81"

    // $ANTLR start "T__82"
    public void mT__82() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__82;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:72:7: ( 'controls' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:72:9: 'controls'
            {
            	Match("controls"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__82"

    // $ANTLR start "T__83"
    public void mT__83() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__83;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:73:7: ( 'tikzpicture' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:73:9: 'tikzpicture'
            {
            	Match("tikzpicture"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__83"

    // $ANTLR start "T__84"
    public void mT__84() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__84;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:74:7: ( 'scope' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:74:9: 'scope'
            {
            	Match("scope"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__84"

    // $ANTLR start "ID"
    public void mID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:517:5: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' | '!' )* )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:517:7: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' | '!' )*
            {
            	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:517:31: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' | '!' )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == '!' || LA1_0 == '.' || (LA1_0 >= '0' && LA1_0 <= '9') || (LA1_0 >= 'A' && LA1_0 <= 'Z') || LA1_0 == '_' || (LA1_0 >= 'a' && LA1_0 <= 'z')) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            			    {
            			    	if ( input.LA(1) == '!' || input.LA(1) == '.' || (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ID"

    // $ANTLR start "INT"
    public void mINT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:520:5: ( ( '-' )? ( '0' .. '9' )+ )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:520:7: ( '-' )? ( '0' .. '9' )+
            {
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:520:7: ( '-' )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == '-') )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:520:7: '-'
            	        {
            	        	Match('-'); 

            	        }
            	        break;

            	}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:520:12: ( '0' .. '9' )+
            	int cnt3 = 0;
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= '0' && LA3_0 <= '9')) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:520:12: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

            			    }
            			    break;

            			default:
            			    if ( cnt3 >= 1 ) goto loop3;
            		            EarlyExitException eee3 =
            		                new EarlyExitException(3, input);
            		            throw eee3;
            	    }
            	    cnt3++;
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INT"

    // $ANTLR start "FLOAT_WO_EXP"
    public void mFLOAT_WO_EXP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FLOAT_WO_EXP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:532:5: ( ( '-' )? ( '0' .. '9' )+ '.' ( '0' .. '9' )* | ( '-' )? '.' ( '0' .. '9' )+ )
            int alt9 = 2;
            switch ( input.LA(1) ) 
            {
            case '-':
            	{
                int LA9_1 = input.LA(2);

                if ( ((LA9_1 >= '0' && LA9_1 <= '9')) )
                {
                    alt9 = 1;
                }
                else if ( (LA9_1 == '.') )
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
                break;
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
            	{
                alt9 = 1;
                }
                break;
            case '.':
            	{
                alt9 = 2;
                }
                break;
            	default:
            	    NoViableAltException nvae_d9s0 =
            	        new NoViableAltException("", 9, 0, input);

            	    throw nvae_d9s0;
            }

            switch (alt9) 
            {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:532:9: ( '-' )? ( '0' .. '9' )+ '.' ( '0' .. '9' )*
                    {
                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:532:9: ( '-' )?
                    	int alt4 = 2;
                    	int LA4_0 = input.LA(1);

                    	if ( (LA4_0 == '-') )
                    	{
                    	    alt4 = 1;
                    	}
                    	switch (alt4) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:532:9: '-'
                    	        {
                    	        	Match('-'); 

                    	        }
                    	        break;

                    	}

                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:532:14: ( '0' .. '9' )+
                    	int cnt5 = 0;
                    	do 
                    	{
                    	    int alt5 = 2;
                    	    int LA5_0 = input.LA(1);

                    	    if ( ((LA5_0 >= '0' && LA5_0 <= '9')) )
                    	    {
                    	        alt5 = 1;
                    	    }


                    	    switch (alt5) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:532:15: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt5 >= 1 ) goto loop5;
                    		            EarlyExitException eee5 =
                    		                new EarlyExitException(5, input);
                    		            throw eee5;
                    	    }
                    	    cnt5++;
                    	} while (true);

                    	loop5:
                    		;	// Stops C# compiler whining that label 'loop5' has no statements

                    	Match('.'); 
                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:532:30: ( '0' .. '9' )*
                    	do 
                    	{
                    	    int alt6 = 2;
                    	    int LA6_0 = input.LA(1);

                    	    if ( ((LA6_0 >= '0' && LA6_0 <= '9')) )
                    	    {
                    	        alt6 = 1;
                    	    }


                    	    switch (alt6) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:532:31: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    goto loop6;
                    	    }
                    	} while (true);

                    	loop6:
                    		;	// Stops C# compiler whining that label 'loop6' has no statements


                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:533:9: ( '-' )? '.' ( '0' .. '9' )+
                    {
                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:533:9: ( '-' )?
                    	int alt7 = 2;
                    	int LA7_0 = input.LA(1);

                    	if ( (LA7_0 == '-') )
                    	{
                    	    alt7 = 1;
                    	}
                    	switch (alt7) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:533:9: '-'
                    	        {
                    	        	Match('-'); 

                    	        }
                    	        break;

                    	}

                    	Match('.'); 
                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:533:18: ( '0' .. '9' )+
                    	int cnt8 = 0;
                    	do 
                    	{
                    	    int alt8 = 2;
                    	    int LA8_0 = input.LA(1);

                    	    if ( ((LA8_0 >= '0' && LA8_0 <= '9')) )
                    	    {
                    	        alt8 = 1;
                    	    }


                    	    switch (alt8) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:533:19: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt8 >= 1 ) goto loop8;
                    		            EarlyExitException eee8 =
                    		                new EarlyExitException(8, input);
                    		            throw eee8;
                    	    }
                    	    cnt8++;
                    	} while (true);

                    	loop8:
                    		;	// Stops C# compiler whining that label 'loop8' has no statements


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FLOAT_WO_EXP"

    // $ANTLR start "TIKZEDT_CMD_COMMENT"
    public void mTIKZEDT_CMD_COMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TIKZEDT_CMD_COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:537:5: ( '%' WS '!TIKZEDT' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:537:9: '%' WS '!TIKZEDT' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
            {
            	Match('%'); 
            	mWS(); 
            	Match("!TIKZEDT"); 

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:537:29: (~ ( '\\n' | '\\r' ) )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( ((LA10_0 >= '\u0000' && LA10_0 <= '\t') || (LA10_0 >= '\u000B' && LA10_0 <= '\f') || (LA10_0 >= '\u000E' && LA10_0 <= '\uFFFF')) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:537:29: ~ ( '\\n' | '\\r' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '\uFFFF') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:537:43: ( '\\r' )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == '\r') )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:537:43: '\\r'
            	        {
            	        	Match('\r'); 

            	        }
            	        break;

            	}

            	Match('\n'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TIKZEDT_CMD_COMMENT"

    // $ANTLR start "COMMENT"
    public void mCOMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:541:5: ( '%' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' | '%/*' ( options {greedy=false; } : . )* '%*/' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' )
            int alt17 = 2;
            alt17 = dfa17.Predict(input);
            switch (alt17) 
            {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:541:9: '%' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
                    {
                    	Match('%'); 
                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:541:13: (~ ( '\\n' | '\\r' ) )*
                    	do 
                    	{
                    	    int alt12 = 2;
                    	    int LA12_0 = input.LA(1);

                    	    if ( ((LA12_0 >= '\u0000' && LA12_0 <= '\t') || (LA12_0 >= '\u000B' && LA12_0 <= '\f') || (LA12_0 >= '\u000E' && LA12_0 <= '\uFFFF')) )
                    	    {
                    	        alt12 = 1;
                    	    }


                    	    switch (alt12) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:541:13: ~ ( '\\n' | '\\r' )
                    			    {
                    			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '\uFFFF') ) 
                    			    	{
                    			    	    input.Consume();

                    			    	}
                    			    	else 
                    			    	{
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    Recover(mse);
                    			    	    throw mse;}


                    			    }
                    			    break;

                    			default:
                    			    goto loop12;
                    	    }
                    	} while (true);

                    	loop12:
                    		;	// Stops C# compiler whining that label 'loop12' has no statements

                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:541:27: ( '\\r' )?
                    	int alt13 = 2;
                    	int LA13_0 = input.LA(1);

                    	if ( (LA13_0 == '\r') )
                    	{
                    	    alt13 = 1;
                    	}
                    	switch (alt13) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:541:27: '\\r'
                    	        {
                    	        	Match('\r'); 

                    	        }
                    	        break;

                    	}

                    	Match('\n'); 
                    	_channel=HIDDEN;

                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:542:9: '%/*' ( options {greedy=false; } : . )* '%*/' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
                    {
                    	Match("%/*"); 

                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:542:15: ( options {greedy=false; } : . )*
                    	do 
                    	{
                    	    int alt14 = 2;
                    	    alt14 = dfa14.Predict(input);
                    	    switch (alt14) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:542:43: .
                    			    {
                    			    	MatchAny(); 

                    			    }
                    			    break;

                    			default:
                    			    goto loop14;
                    	    }
                    	} while (true);

                    	loop14:
                    		;	// Stops C# compiler whining that label 'loop14' has no statements

                    	Match("%*/"); 

                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:542:54: (~ ( '\\n' | '\\r' ) )*
                    	do 
                    	{
                    	    int alt15 = 2;
                    	    int LA15_0 = input.LA(1);

                    	    if ( ((LA15_0 >= '\u0000' && LA15_0 <= '\t') || (LA15_0 >= '\u000B' && LA15_0 <= '\f') || (LA15_0 >= '\u000E' && LA15_0 <= '\uFFFF')) )
                    	    {
                    	        alt15 = 1;
                    	    }


                    	    switch (alt15) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:542:54: ~ ( '\\n' | '\\r' )
                    			    {
                    			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '\uFFFF') ) 
                    			    	{
                    			    	    input.Consume();

                    			    	}
                    			    	else 
                    			    	{
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    Recover(mse);
                    			    	    throw mse;}


                    			    }
                    			    break;

                    			default:
                    			    goto loop15;
                    	    }
                    	} while (true);

                    	loop15:
                    		;	// Stops C# compiler whining that label 'loop15' has no statements

                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:542:68: ( '\\r' )?
                    	int alt16 = 2;
                    	int LA16_0 = input.LA(1);

                    	if ( (LA16_0 == '\r') )
                    	{
                    	    alt16 = 1;
                    	}
                    	switch (alt16) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:542:68: '\\r'
                    	        {
                    	        	Match('\r'); 

                    	        }
                    	        break;

                    	}

                    	Match('\n'); 
                    	_channel=HIDDEN;

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COMMENT"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:545:5: ( ( ' ' | '\\t' | '\\r' | '\\n' ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:545:9: ( ' ' | '\\t' | '\\r' | '\\n' )
            {
            	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || input.LA(1) == '\r' || input.LA(1) == ' ' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	_channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    // $ANTLR start "EXPONENT"
    public void mEXPONENT() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:552:19: ( ( 'e' | 'E' ) ( '+' | '-' )? ( '0' .. '9' )+ )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:552:21: ( 'e' | 'E' ) ( '+' | '-' )? ( '0' .. '9' )+
            {
            	if ( input.LA(1) == 'E' || input.LA(1) == 'e' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:552:31: ( '+' | '-' )?
            	int alt18 = 2;
            	int LA18_0 = input.LA(1);

            	if ( (LA18_0 == '+' || LA18_0 == '-') )
            	{
            	    alt18 = 1;
            	}
            	switch (alt18) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            	        {
            	        	if ( input.LA(1) == '+' || input.LA(1) == '-' ) 
            	        	{
            	        	    input.Consume();

            	        	}
            	        	else 
            	        	{
            	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        	    Recover(mse);
            	        	    throw mse;}


            	        }
            	        break;

            	}

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:552:42: ( '0' .. '9' )+
            	int cnt19 = 0;
            	do 
            	{
            	    int alt19 = 2;
            	    int LA19_0 = input.LA(1);

            	    if ( ((LA19_0 >= '0' && LA19_0 <= '9')) )
            	    {
            	        alt19 = 1;
            	    }


            	    switch (alt19) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:552:43: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

            			    }
            			    break;

            			default:
            			    if ( cnt19 >= 1 ) goto loop19;
            		            EarlyExitException eee19 =
            		                new EarlyExitException(19, input);
            		            throw eee19;
            	    }
            	    cnt19++;
            	} while (true);

            	loop19:
            		;	// Stops C# compiler whining that label 'loop19' has no statements


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "EXPONENT"

    // $ANTLR start "MATHSTRING"
    public void mMATHSTRING() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MATHSTRING;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:559:2: ( '$' ( ESC_SEQ | ~ ( '\\\\' | '$' ) )* '$' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:559:4: '$' ( ESC_SEQ | ~ ( '\\\\' | '$' ) )* '$'
            {
            	Match('$'); 
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:559:8: ( ESC_SEQ | ~ ( '\\\\' | '$' ) )*
            	do 
            	{
            	    int alt20 = 3;
            	    int LA20_0 = input.LA(1);

            	    if ( (LA20_0 == '\\') )
            	    {
            	        alt20 = 1;
            	    }
            	    else if ( ((LA20_0 >= '\u0000' && LA20_0 <= '#') || (LA20_0 >= '%' && LA20_0 <= '[') || (LA20_0 >= ']' && LA20_0 <= '\uFFFF')) )
            	    {
            	        alt20 = 2;
            	    }


            	    switch (alt20) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:559:10: ESC_SEQ
            			    {
            			    	mESC_SEQ(); 

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:559:20: ~ ( '\\\\' | '$' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '#') || (input.LA(1) >= '%' && input.LA(1) <= '[') || (input.LA(1) >= ']' && input.LA(1) <= '\uFFFF') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop20;
            	    }
            	} while (true);

            	loop20:
            		;	// Stops C# compiler whining that label 'loop20' has no statements

            	Match('$'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MATHSTRING"

    // $ANTLR start "COMMAND"
    public void mCOMMAND() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COMMAND;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:570:2: ( '\\\\' ID )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:570:4: '\\\\' ID
            {
            	Match('\\'); 
            	mID(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COMMAND"

    // $ANTLR start "ESC_SEQ"
    public void mESC_SEQ() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ESC_SEQ;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:575:5: ( '\\\\' . )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:575:9: '\\\\' .
            {
            	Match('\\'); 
            	MatchAny(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ESC_SEQ"

    // $ANTLR start "SOMETHING"
    public void mSOMETHING() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SOMETHING;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:581:2: ( . )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:581:4: .
            {
            	MatchAny(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SOMETHING"

    override public void mTokens() // throws RecognitionException 
    {
        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:8: ( T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | T__77 | T__78 | T__79 | T__80 | T__81 | T__82 | T__83 | T__84 | ID | INT | FLOAT_WO_EXP | TIKZEDT_CMD_COMMENT | COMMENT | WS | MATHSTRING | COMMAND | ESC_SEQ | SOMETHING )
        int alt21 = 57;
        alt21 = dfa21.Predict(input);
        switch (alt21) 
        {
            case 1 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:10: T__38
                {
                	mT__38(); 

                }
                break;
            case 2 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:16: T__39
                {
                	mT__39(); 

                }
                break;
            case 3 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:22: T__40
                {
                	mT__40(); 

                }
                break;
            case 4 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:28: T__41
                {
                	mT__41(); 

                }
                break;
            case 5 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:34: T__42
                {
                	mT__42(); 

                }
                break;
            case 6 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:40: T__43
                {
                	mT__43(); 

                }
                break;
            case 7 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:46: T__44
                {
                	mT__44(); 

                }
                break;
            case 8 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:52: T__45
                {
                	mT__45(); 

                }
                break;
            case 9 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:58: T__46
                {
                	mT__46(); 

                }
                break;
            case 10 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:64: T__47
                {
                	mT__47(); 

                }
                break;
            case 11 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:70: T__48
                {
                	mT__48(); 

                }
                break;
            case 12 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:76: T__49
                {
                	mT__49(); 

                }
                break;
            case 13 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:82: T__50
                {
                	mT__50(); 

                }
                break;
            case 14 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:88: T__51
                {
                	mT__51(); 

                }
                break;
            case 15 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:94: T__52
                {
                	mT__52(); 

                }
                break;
            case 16 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:100: T__53
                {
                	mT__53(); 

                }
                break;
            case 17 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:106: T__54
                {
                	mT__54(); 

                }
                break;
            case 18 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:112: T__55
                {
                	mT__55(); 

                }
                break;
            case 19 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:118: T__56
                {
                	mT__56(); 

                }
                break;
            case 20 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:124: T__57
                {
                	mT__57(); 

                }
                break;
            case 21 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:130: T__58
                {
                	mT__58(); 

                }
                break;
            case 22 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:136: T__59
                {
                	mT__59(); 

                }
                break;
            case 23 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:142: T__60
                {
                	mT__60(); 

                }
                break;
            case 24 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:148: T__61
                {
                	mT__61(); 

                }
                break;
            case 25 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:154: T__62
                {
                	mT__62(); 

                }
                break;
            case 26 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:160: T__63
                {
                	mT__63(); 

                }
                break;
            case 27 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:166: T__64
                {
                	mT__64(); 

                }
                break;
            case 28 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:172: T__65
                {
                	mT__65(); 

                }
                break;
            case 29 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:178: T__66
                {
                	mT__66(); 

                }
                break;
            case 30 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:184: T__67
                {
                	mT__67(); 

                }
                break;
            case 31 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:190: T__68
                {
                	mT__68(); 

                }
                break;
            case 32 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:196: T__69
                {
                	mT__69(); 

                }
                break;
            case 33 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:202: T__70
                {
                	mT__70(); 

                }
                break;
            case 34 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:208: T__71
                {
                	mT__71(); 

                }
                break;
            case 35 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:214: T__72
                {
                	mT__72(); 

                }
                break;
            case 36 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:220: T__73
                {
                	mT__73(); 

                }
                break;
            case 37 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:226: T__74
                {
                	mT__74(); 

                }
                break;
            case 38 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:232: T__75
                {
                	mT__75(); 

                }
                break;
            case 39 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:238: T__76
                {
                	mT__76(); 

                }
                break;
            case 40 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:244: T__77
                {
                	mT__77(); 

                }
                break;
            case 41 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:250: T__78
                {
                	mT__78(); 

                }
                break;
            case 42 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:256: T__79
                {
                	mT__79(); 

                }
                break;
            case 43 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:262: T__80
                {
                	mT__80(); 

                }
                break;
            case 44 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:268: T__81
                {
                	mT__81(); 

                }
                break;
            case 45 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:274: T__82
                {
                	mT__82(); 

                }
                break;
            case 46 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:280: T__83
                {
                	mT__83(); 

                }
                break;
            case 47 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:286: T__84
                {
                	mT__84(); 

                }
                break;
            case 48 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:292: ID
                {
                	mID(); 

                }
                break;
            case 49 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:295: INT
                {
                	mINT(); 

                }
                break;
            case 50 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:299: FLOAT_WO_EXP
                {
                	mFLOAT_WO_EXP(); 

                }
                break;
            case 51 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:312: TIKZEDT_CMD_COMMENT
                {
                	mTIKZEDT_CMD_COMMENT(); 

                }
                break;
            case 52 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:332: COMMENT
                {
                	mCOMMENT(); 

                }
                break;
            case 53 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:340: WS
                {
                	mWS(); 

                }
                break;
            case 54 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:343: MATHSTRING
                {
                	mMATHSTRING(); 

                }
                break;
            case 55 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:354: COMMAND
                {
                	mCOMMAND(); 

                }
                break;
            case 56 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:362: ESC_SEQ
                {
                	mESC_SEQ(); 

                }
                break;
            case 57 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:370: SOMETHING
                {
                	mSOMETHING(); 

                }
                break;

        }

    }


    protected DFA17 dfa17;
    protected DFA14 dfa14;
    protected DFA21 dfa21;
	private void InitializeCyclicDFAs()
	{
	    this.dfa17 = new DFA17(this);
	    this.dfa14 = new DFA14(this);
	    this.dfa21 = new DFA21(this);
	    this.dfa17.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA17_SpecialStateTransition);
	    this.dfa14.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA14_SpecialStateTransition);
	    this.dfa21.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA21_SpecialStateTransition);
	}

    const string DFA17_eotS =
        "\x06\uffff\x01\x03\x0b\uffff";
    const string DFA17_eofS =
        "\x12\uffff";
    const string DFA17_minS =
        "\x01\x25\x02\x00\x01\uffff\x05\x00\x01\uffff\x04\x00\x01\uffff"+
        "\x03\x00";
    const string DFA17_maxS =
        "\x01\x25\x02\uffff\x01\uffff\x05\uffff\x01\uffff\x04\uffff\x01"+
        "\uffff\x03\uffff";
    const string DFA17_acceptS =
        "\x03\uffff\x01\x01\x05\uffff\x01\x02\x04\uffff\x01\x01\x03\uffff";
    const string DFA17_specialS =
        "\x01\uffff\x01\x0b\x01\x06\x01\uffff\x01\x09\x01\x04\x01\x0a\x01"+
        "\x01\x01\x0d\x01\uffff\x01\x00\x01\x07\x01\x05\x01\x0c\x01\uffff"+
        "\x01\x08\x01\x03\x01\x02}>";
    static readonly string[] DFA17_transitionS = {
            "\x01\x01",
            "\x2f\x03\x01\x02\uffd0\x03",
            "\x2a\x03\x01\x04\uffd5\x03",
            "",
            "\x0a\x08\x01\x06\x02\x08\x01\x05\x17\x08\x01\x07\uffda\x08",
            "\x0a\x09\x01\x06\ufff5\x09",
            "\x00\x09",
            "\x0a\x08\x01\x06\x02\x08\x01\x05\x17\x08\x01\x07\x04\x08\x01"+
            "\x0a\uffd5\x08",
            "\x0a\x08\x01\x06\x02\x08\x01\x05\x17\x08\x01\x07\uffda\x08",
            "",
            "\x0a\x08\x01\x06\x02\x08\x01\x05\x17\x08\x01\x07\x09\x08\x01"+
            "\x0b\uffd0\x08",
            "\x0a\x0f\x01\x0e\x02\x0f\x01\x0d\x17\x0f\x01\x0c\uffda\x0f",
            "\x0a\x0f\x01\x0e\x02\x0f\x01\x0d\x17\x0f\x01\x0c\x04\x0f\x01"+
            "\x10\uffd5\x0f",
            "\x0a\x09\x01\x0e\ufff5\x09",
            "",
            "\x0a\x0f\x01\x0e\x02\x0f\x01\x0d\x17\x0f\x01\x0c\uffda\x0f",
            "\x0a\x0f\x01\x0e\x02\x0f\x01\x0d\x17\x0f\x01\x0c\x09\x0f\x01"+
            "\x11\uffd0\x0f",
            "\x0a\x0f\x01\x0e\x02\x0f\x01\x0d\x17\x0f\x01\x0c\uffda\x0f"
    };

    static readonly short[] DFA17_eot = DFA.UnpackEncodedString(DFA17_eotS);
    static readonly short[] DFA17_eof = DFA.UnpackEncodedString(DFA17_eofS);
    static readonly char[] DFA17_min = DFA.UnpackEncodedStringToUnsignedChars(DFA17_minS);
    static readonly char[] DFA17_max = DFA.UnpackEncodedStringToUnsignedChars(DFA17_maxS);
    static readonly short[] DFA17_accept = DFA.UnpackEncodedString(DFA17_acceptS);
    static readonly short[] DFA17_special = DFA.UnpackEncodedString(DFA17_specialS);
    static readonly short[][] DFA17_transition = DFA.UnpackEncodedStringArray(DFA17_transitionS);

    protected class DFA17 : DFA
    {
        public DFA17(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 17;
            this.eot = DFA17_eot;
            this.eof = DFA17_eof;
            this.min = DFA17_min;
            this.max = DFA17_max;
            this.accept = DFA17_accept;
            this.special = DFA17_special;
            this.transition = DFA17_transition;

        }

        override public string Description
        {
            get { return "540:1: COMMENT : ( '%' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' | '%/*' ( options {greedy=false; } : . )* '%*/' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' );"; }
        }

    }


    protected internal int DFA17_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            IIntStream input = _input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA17_10 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_10 == '/') ) { s = 11; }

                   	else if ( (LA17_10 == '%') ) { s = 7; }

                   	else if ( (LA17_10 == '\r') ) { s = 5; }

                   	else if ( (LA17_10 == '\n') ) { s = 6; }

                   	else if ( ((LA17_10 >= '\u0000' && LA17_10 <= '\t') || (LA17_10 >= '\u000B' && LA17_10 <= '\f') || (LA17_10 >= '\u000E' && LA17_10 <= '$') || (LA17_10 >= '&' && LA17_10 <= '.') || (LA17_10 >= '0' && LA17_10 <= '\uFFFF')) ) { s = 8; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA17_7 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_7 == '*') ) { s = 10; }

                   	else if ( (LA17_7 == '%') ) { s = 7; }

                   	else if ( (LA17_7 == '\r') ) { s = 5; }

                   	else if ( (LA17_7 == '\n') ) { s = 6; }

                   	else if ( ((LA17_7 >= '\u0000' && LA17_7 <= '\t') || (LA17_7 >= '\u000B' && LA17_7 <= '\f') || (LA17_7 >= '\u000E' && LA17_7 <= '$') || (LA17_7 >= '&' && LA17_7 <= ')') || (LA17_7 >= '+' && LA17_7 <= '\uFFFF')) ) { s = 8; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA17_17 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_17 == '%') ) { s = 12; }

                   	else if ( (LA17_17 == '\r') ) { s = 13; }

                   	else if ( (LA17_17 == '\n') ) { s = 14; }

                   	else if ( ((LA17_17 >= '\u0000' && LA17_17 <= '\t') || (LA17_17 >= '\u000B' && LA17_17 <= '\f') || (LA17_17 >= '\u000E' && LA17_17 <= '$') || (LA17_17 >= '&' && LA17_17 <= '\uFFFF')) ) { s = 15; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA17_16 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_16 == '/') ) { s = 17; }

                   	else if ( (LA17_16 == '\r') ) { s = 13; }

                   	else if ( (LA17_16 == '\n') ) { s = 14; }

                   	else if ( (LA17_16 == '%') ) { s = 12; }

                   	else if ( ((LA17_16 >= '\u0000' && LA17_16 <= '\t') || (LA17_16 >= '\u000B' && LA17_16 <= '\f') || (LA17_16 >= '\u000E' && LA17_16 <= '$') || (LA17_16 >= '&' && LA17_16 <= '.') || (LA17_16 >= '0' && LA17_16 <= '\uFFFF')) ) { s = 15; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA17_5 = input.LA(1);

                   	s = -1;
                   	if ( ((LA17_5 >= '\u0000' && LA17_5 <= '\t') || (LA17_5 >= '\u000B' && LA17_5 <= '\uFFFF')) ) { s = 9; }

                   	else if ( (LA17_5 == '\n') ) { s = 6; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA17_12 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_12 == '*') ) { s = 16; }

                   	else if ( (LA17_12 == '\r') ) { s = 13; }

                   	else if ( (LA17_12 == '\n') ) { s = 14; }

                   	else if ( (LA17_12 == '%') ) { s = 12; }

                   	else if ( ((LA17_12 >= '\u0000' && LA17_12 <= '\t') || (LA17_12 >= '\u000B' && LA17_12 <= '\f') || (LA17_12 >= '\u000E' && LA17_12 <= '$') || (LA17_12 >= '&' && LA17_12 <= ')') || (LA17_12 >= '+' && LA17_12 <= '\uFFFF')) ) { s = 15; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA17_2 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_2 == '*') ) { s = 4; }

                   	else if ( ((LA17_2 >= '\u0000' && LA17_2 <= ')') || (LA17_2 >= '+' && LA17_2 <= '\uFFFF')) ) { s = 3; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA17_11 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_11 == '%') ) { s = 12; }

                   	else if ( (LA17_11 == '\r') ) { s = 13; }

                   	else if ( (LA17_11 == '\n') ) { s = 14; }

                   	else if ( ((LA17_11 >= '\u0000' && LA17_11 <= '\t') || (LA17_11 >= '\u000B' && LA17_11 <= '\f') || (LA17_11 >= '\u000E' && LA17_11 <= '$') || (LA17_11 >= '&' && LA17_11 <= '\uFFFF')) ) { s = 15; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA17_15 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_15 == '\r') ) { s = 13; }

                   	else if ( (LA17_15 == '\n') ) { s = 14; }

                   	else if ( (LA17_15 == '%') ) { s = 12; }

                   	else if ( ((LA17_15 >= '\u0000' && LA17_15 <= '\t') || (LA17_15 >= '\u000B' && LA17_15 <= '\f') || (LA17_15 >= '\u000E' && LA17_15 <= '$') || (LA17_15 >= '&' && LA17_15 <= '\uFFFF')) ) { s = 15; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA17_4 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_4 == '\r') ) { s = 5; }

                   	else if ( (LA17_4 == '\n') ) { s = 6; }

                   	else if ( (LA17_4 == '%') ) { s = 7; }

                   	else if ( ((LA17_4 >= '\u0000' && LA17_4 <= '\t') || (LA17_4 >= '\u000B' && LA17_4 <= '\f') || (LA17_4 >= '\u000E' && LA17_4 <= '$') || (LA17_4 >= '&' && LA17_4 <= '\uFFFF')) ) { s = 8; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA17_6 = input.LA(1);

                   	s = -1;
                   	if ( ((LA17_6 >= '\u0000' && LA17_6 <= '\uFFFF')) ) { s = 9; }

                   	else s = 3;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA17_1 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_1 == '/') ) { s = 2; }

                   	else if ( ((LA17_1 >= '\u0000' && LA17_1 <= '.') || (LA17_1 >= '0' && LA17_1 <= '\uFFFF')) ) { s = 3; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA17_13 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_13 == '\n') ) { s = 14; }

                   	else if ( ((LA17_13 >= '\u0000' && LA17_13 <= '\t') || (LA17_13 >= '\u000B' && LA17_13 <= '\uFFFF')) ) { s = 9; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 13 : 
                   	int LA17_8 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_8 == '%') ) { s = 7; }

                   	else if ( (LA17_8 == '\r') ) { s = 5; }

                   	else if ( (LA17_8 == '\n') ) { s = 6; }

                   	else if ( ((LA17_8 >= '\u0000' && LA17_8 <= '\t') || (LA17_8 >= '\u000B' && LA17_8 <= '\f') || (LA17_8 >= '\u000E' && LA17_8 <= '$') || (LA17_8 >= '&' && LA17_8 <= '\uFFFF')) ) { s = 8; }

                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae17 =
            new NoViableAltException(dfa.Description, 17, _s, input);
        dfa.Error(nvae17);
        throw nvae17;
    }
    const string DFA14_eotS =
        "\x0c\uffff";
    const string DFA14_eofS =
        "\x0c\uffff";
    const string DFA14_minS =
        "\x02\x00\x01\uffff\x04\x00\x01\uffff\x02\x00\x02\uffff";
    const string DFA14_maxS =
        "\x02\uffff\x01\uffff\x04\uffff\x01\uffff\x02\uffff\x02\uffff";
    const string DFA14_acceptS =
        "\x02\uffff\x01\x01\x04\uffff\x01\x02\x02\uffff\x02\x02";
    const string DFA14_specialS =
        "\x01\x02\x01\x00\x01\uffff\x01\x07\x01\x03\x01\x04\x01\x06\x01"+
        "\uffff\x01\x05\x01\x01\x02\uffff}>";
    static readonly string[] DFA14_transitionS = {
            "\x25\x02\x01\x01\uffda\x02",
            "\x2a\x02\x01\x03\uffd5\x02",
            "",
            "\x2f\x02\x01\x04\uffd0\x02",
            "\x0a\x08\x01\x07\x02\x08\x01\x06\x17\x08\x01\x05\uffda\x08",
            "\x0a\x08\x01\x07\x02\x08\x01\x06\x17\x08\x01\x05\x04\x08\x01"+
            "\x09\uffd5\x08",
            "\x0a\x02\x01\x07\ufff5\x02",
            "",
            "\x0a\x08\x01\x0a\x02\x08\x01\x06\x17\x08\x01\x05\uffda\x08",
            "\x0a\x08\x01\x0a\x02\x08\x01\x06\x17\x08\x01\x05\x09\x08\x01"+
            "\x0b\uffd0\x08",
            "",
            ""
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
            get { return "()* loopback of 542:15: ( options {greedy=false; } : . )*"; }
        }

    }


    protected internal int DFA14_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            IIntStream input = _input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA14_1 = input.LA(1);

                   	s = -1;
                   	if ( (LA14_1 == '*') ) { s = 3; }

                   	else if ( ((LA14_1 >= '\u0000' && LA14_1 <= ')') || (LA14_1 >= '+' && LA14_1 <= '\uFFFF')) ) { s = 2; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA14_9 = input.LA(1);

                   	s = -1;
                   	if ( (LA14_9 == '/') ) { s = 11; }

                   	else if ( (LA14_9 == '\r') ) { s = 6; }

                   	else if ( (LA14_9 == '\n') ) { s = 10; }

                   	else if ( (LA14_9 == '%') ) { s = 5; }

                   	else if ( ((LA14_9 >= '\u0000' && LA14_9 <= '\t') || (LA14_9 >= '\u000B' && LA14_9 <= '\f') || (LA14_9 >= '\u000E' && LA14_9 <= '$') || (LA14_9 >= '&' && LA14_9 <= '.') || (LA14_9 >= '0' && LA14_9 <= '\uFFFF')) ) { s = 8; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA14_0 = input.LA(1);

                   	s = -1;
                   	if ( (LA14_0 == '%') ) { s = 1; }

                   	else if ( ((LA14_0 >= '\u0000' && LA14_0 <= '$') || (LA14_0 >= '&' && LA14_0 <= '\uFFFF')) ) { s = 2; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA14_4 = input.LA(1);

                   	s = -1;
                   	if ( (LA14_4 == '%') ) { s = 5; }

                   	else if ( (LA14_4 == '\r') ) { s = 6; }

                   	else if ( (LA14_4 == '\n') ) { s = 7; }

                   	else if ( ((LA14_4 >= '\u0000' && LA14_4 <= '\t') || (LA14_4 >= '\u000B' && LA14_4 <= '\f') || (LA14_4 >= '\u000E' && LA14_4 <= '$') || (LA14_4 >= '&' && LA14_4 <= '\uFFFF')) ) { s = 8; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA14_5 = input.LA(1);

                   	s = -1;
                   	if ( (LA14_5 == '*') ) { s = 9; }

                   	else if ( (LA14_5 == '\r') ) { s = 6; }

                   	else if ( (LA14_5 == '\n') ) { s = 7; }

                   	else if ( (LA14_5 == '%') ) { s = 5; }

                   	else if ( ((LA14_5 >= '\u0000' && LA14_5 <= '\t') || (LA14_5 >= '\u000B' && LA14_5 <= '\f') || (LA14_5 >= '\u000E' && LA14_5 <= '$') || (LA14_5 >= '&' && LA14_5 <= ')') || (LA14_5 >= '+' && LA14_5 <= '\uFFFF')) ) { s = 8; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA14_8 = input.LA(1);

                   	s = -1;
                   	if ( (LA14_8 == '\r') ) { s = 6; }

                   	else if ( (LA14_8 == '\n') ) { s = 10; }

                   	else if ( (LA14_8 == '%') ) { s = 5; }

                   	else if ( ((LA14_8 >= '\u0000' && LA14_8 <= '\t') || (LA14_8 >= '\u000B' && LA14_8 <= '\f') || (LA14_8 >= '\u000E' && LA14_8 <= '$') || (LA14_8 >= '&' && LA14_8 <= '\uFFFF')) ) { s = 8; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA14_6 = input.LA(1);

                   	s = -1;
                   	if ( (LA14_6 == '\n') ) { s = 7; }

                   	else if ( ((LA14_6 >= '\u0000' && LA14_6 <= '\t') || (LA14_6 >= '\u000B' && LA14_6 <= '\uFFFF')) ) { s = 2; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA14_3 = input.LA(1);

                   	s = -1;
                   	if ( (LA14_3 == '/') ) { s = 4; }

                   	else if ( ((LA14_3 >= '\u0000' && LA14_3 <= '.') || (LA14_3 >= '0' && LA14_3 <= '\uFFFF')) ) { s = 2; }

                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae14 =
            new NoViableAltException(dfa.Description, 14, _s, input);
        dfa.Error(nvae14);
        throw nvae14;
    }
    const string DFA21_eotS =
        "\x01\uffff\x01\x20\x05\uffff\x01\x20\x01\x33\x05\uffff\x08\x33"+
        "\x02\x20\x01\x4e\x01\x20\x01\x33\x01\uffff\x01\x51\x01\x20\x01\uffff"+
        "\x01\x20\x01\uffff\x08\x59\x08\uffff\x02\x33\x06\uffff\x01\x66\x02"+
        "\x33\x01\x6a\x01\x6b\x01\x6c\x01\x33\x01\x6e\x01\x6f\x02\x33\x01"+
        "\x72\x02\x33\x04\uffff\x01\x51\x04\uffff\x01\x33\x04\uffff\x01\x52"+
        "\x02\uffff\x01\x59\x01\uffff\x08\x59\x02\uffff\x02\x33\x01\uffff"+
        "\x03\x33\x03\uffff\x01\x33\x02\uffff\x01\u0087\x01\u0088\x01\uffff"+
        "\x01\u0089\x02\x33\x02\uffff\x02\x59\x01\u008f\x06\x59\x06\x33\x03"+
        "\uffff\x01\u009c\x01\x33\x01\uffff\x02\x59\x01\uffff\x01\u00a1\x01"+
        "\x59\x01\u00a3\x01\u00a4\x01\u00a5\x01\u00a6\x01\u00a7\x01\u00a8"+
        "\x04\x33\x01\uffff\x01\x33\x01\uffff\x01\u00af\x01\x59\x01\uffff"+
        "\x01\x59\x06\uffff\x02\x33\x01\u00b5\x02\x33\x02\uffff\x03\x59\x02"+
        "\x33\x01\uffff\x01\u00be\x01\x33\x01\uffff\x01\x59\x01\u00c2\x01"+
        "\x59\x01\x33\x01\u00c5\x01\uffff\x01\x33\x01\uffff\x01\x59\x01\uffff"+
        "\x01\x59\x01\x33\x01\uffff\x01\x33\x01\uffff\x01\u00cd\x01\x59\x01"+
        "\u00cf\x01\x33\x02\uffff\x01\u00d4\x01\uffff\x01\u00d5\x05\uffff";
    const string DFA21_eofS =
        "\u00d6\uffff";
    const string DFA21_minS =
        "\x02\x00\x05\uffff\x01\x2e\x01\x63\x05\uffff\x01\x69\x01\x6e\x01"+
        "\x6c\x01\x6d\x01\x74\x01\x65\x01\x6e\x01\x6f\x02\x2d\x01\x2b\x01"+
        "\x2e\x01\x69\x01\uffff\x01\x2e\x01\x00\x01\uffff\x01\x00\x01\uffff"+
        "\x01\x65\x01\x69\x01\x6e\x01\x6f\x01\x6c\x01\x72\x01\x61\x01\x69"+
        "\x07\uffff\x01\x61\x01\x79\x01\x6f\x06\uffff\x01\x21\x01\x6e\x01"+
        "\x72\x03\x21\x01\x6c\x02\x21\x01\x74\x01\x64\x01\x21\x01\x63\x01"+
        "\x64\x04\uffff\x01\x2e\x04\uffff\x01\x6b\x02\uffff\x01\x00\x01\x0a"+
        "\x01\x21\x02\uffff\x01\x67\x01\uffff\x01\x6b\x02\x64\x01\x6f\x01"+
        "\x69\x01\x61\x01\x74\x01\x6c\x02\uffff\x01\x6c\x01\x70\x01\uffff"+
        "\x01\x72\x01\x74\x01\x63\x03\uffff\x01\x69\x02\uffff\x02\x21\x01"+
        "\uffff\x01\x21\x01\x65\x01\x7a\x01\x00\x01\uffff\x01\x69\x01\x7a"+
        "\x01\x21\x01\x65\x01\x72\x01\x70\x01\x77\x01\x68\x01\x6c\x02\x65"+
        "\x01\x64\x01\x72\x01\x6c\x01\x70\x03\uffff\x01\x21\x01\x70\x01\x00"+
        "\x01\x6e\x01\x73\x01\uffff\x01\x21\x01\x64\x06\x21\x01\x69\x01\x6f"+
        "\x01\x65\x01\x73\x01\uffff\x01\x69\x01\x00\x01\x21\x01\x65\x01\uffff"+
        "\x01\x69\x06\uffff\x01\x6e\x01\x6c\x01\x21\x01\x65\x01\x63\x01\x00"+
        "\x01\uffff\x01\x79\x01\x74\x01\x6e\x01\x61\x01\x73\x01\uffff\x01"+
        "\x21\x01\x74\x01\x00\x01\x6c\x01\x21\x01\x61\x01\x74\x01\x21\x01"+
        "\uffff\x01\x75\x01\x00\x01\x65\x01\uffff\x01\x74\x01\x65\x01\uffff"+
        "\x01\x72\x01\x00\x01\x21\x01\x65\x01\x21\x01\x65\x01\x00\x01\uffff"+
        "\x01\x21\x01\uffff\x01\x21\x01\x00\x01\x0a\x03\uffff";
    const string DFA21_maxS =
        "\x02\uffff\x05\uffff\x01\x2e\x01\x74\x05\uffff\x01\x6f\x01\x6e"+
        "\x01\x78\x01\x6d\x01\x74\x01\x65\x01\x74\x01\x6f\x01\x7c\x01\x2d"+
        "\x01\x2b\x01\x39\x01\x69\x01\uffff\x01\x39\x01\uffff\x01\uffff\x01"+
        "\uffff\x01\uffff\x01\x65\x01\x69\x01\x6e\x02\x6f\x01\x72\x01\x61"+
        "\x01\x69\x07\uffff\x01\x73\x01\x79\x01\x6f\x06\uffff\x01\x7a\x01"+
        "\x6f\x01\x72\x03\x7a\x01\x6c\x02\x7a\x01\x74\x01\x64\x01\x7a\x01"+
        "\x63\x01\x64\x04\uffff\x01\x39\x04\uffff\x01\x6b\x02\uffff\x01\uffff"+
        "\x02\x21\x02\uffff\x01\x67\x01\uffff\x01\x6b\x02\x64\x01\x6f\x01"+
        "\x69\x01\x61\x01\x74\x01\x6c\x02\uffff\x01\x6c\x01\x70\x01\uffff"+
        "\x01\x72\x01\x74\x01\x63\x03\uffff\x01\x69\x02\uffff\x02\x7a\x01"+
        "\uffff\x01\x7a\x01\x65\x01\x7a\x01\uffff\x01\uffff\x01\x69\x02\x7a"+
        "\x01\x65\x01\x72\x01\x70\x01\x77\x01\x68\x01\x6c\x02\x65\x01\x64"+
        "\x01\x72\x01\x6c\x01\x70\x03\uffff\x01\x7a\x01\x70\x01\uffff\x01"+
        "\x6e\x01\x73\x01\uffff\x01\x7a\x01\x64\x06\x7a\x01\x69\x01\x6f\x01"+
        "\x65\x01\x73\x01\uffff\x01\x69\x01\uffff\x01\x7a\x01\x74\x01\uffff"+
        "\x01\x69\x06\uffff\x01\x6e\x01\x6c\x01\x7a\x01\x65\x01\x63\x01\uffff"+
        "\x01\uffff\x01\x79\x01\x74\x01\x6e\x01\x61\x01\x73\x01\uffff\x01"+
        "\x7a\x01\x74\x01\uffff\x01\x6c\x01\x7a\x01\x61\x01\x74\x01\x7a\x01"+
        "\uffff\x01\x75\x01\uffff\x01\x65\x01\uffff\x01\x74\x01\x65\x01\uffff"+
        "\x01\x72\x01\uffff\x01\x7a\x01\x65\x01\x7a\x01\x65\x01\uffff\x01"+
        "\uffff\x01\x7a\x01\uffff\x01\x7a\x01\uffff\x01\x0a\x03\uffff";
    const string DFA21_acceptS =
        "\x02\uffff\x01\x04\x01\x05\x01\x06\x01\x07\x01\x08\x02\uffff\x01"+
        "\x0c\x01\x0d\x01\x0e\x01\x0f\x01\x10\x0d\uffff\x01\x30\x02\uffff"+
        "\x01\x35\x01\uffff\x01\x39\x08\uffff\x01\x37\x01\x38\x01\x04\x01"+
        "\x05\x01\x06\x01\x07\x01\x08\x03\uffff\x01\x30\x01\x0c\x01\x0d\x01"+
        "\x0e\x01\x0f\x01\x10\x0e\uffff\x01\x26\x01\x27\x01\x29\x01\x32\x01"+
        "\uffff\x01\x28\x01\x2b\x01\x2a\x01\x2c\x01\uffff\x01\x31\x01\x34"+
        "\x03\uffff\x01\x35\x01\x36\x01\uffff\x01\x37\x08\uffff\x01\x09\x01"+
        "\x0a\x02\uffff\x01\x11\x03\uffff\x01\x12\x01\x13\x01\x16\x01\uffff"+
        "\x01\x14\x01\x15\x02\uffff\x01\x22\x04\uffff\x01\x33\x0f\uffff\x01"+
        "\x1e\x01\x1f\x01\x25\x05\uffff\x01\x17\x0c\uffff\x01\x21\x04\uffff"+
        "\x01\x18\x01\uffff\x01\x1d\x01\x1a\x01\x1b\x01\x1c\x01\x0b\x01\x2f"+
        "\x06\uffff\x01\x01\x05\uffff\x01\x23\x08\uffff\x01\x24\x03\uffff"+
        "\x01\x03\x02\uffff\x01\x2d\x07\uffff\x01\x02\x01\uffff\x01\x20\x03"+
        "\uffff\x01\x33\x01\x19\x01\x2e";
    const string DFA21_specialS =
        "\x01\x0c\x01\x01\x1b\uffff\x01\x0d\x01\uffff\x01\x00\x33\uffff"+
        "\x01\x02\x22\uffff\x01\x0b\x15\uffff\x01\x0a\x11\uffff\x01\x09\x0f"+
        "\uffff\x01\x08\x09\uffff\x01\x07\x07\uffff\x01\x06\x06\uffff\x01"+
        "\x05\x04\uffff\x01\x04\x04\uffff\x01\x03\x04\uffff}>";
    static readonly string[] DFA21_transitionS = {
            "\x09\x20\x02\x1e\x02\x20\x01\x1e\x12\x20\x01\x1e\x03\x20\x01"+
            "\x1f\x01\x1d\x02\x20\x01\x09\x01\x0a\x01\x20\x01\x18\x01\x05"+
            "\x01\x16\x01\x19\x01\x07\x0a\x1c\x01\x06\x01\x0d\x01\x20\x01"+
            "\x04\x03\x20\x1a\x1b\x01\x0b\x01\x01\x01\x0c\x01\x20\x01\x1b"+
            "\x01\x20\x01\x14\x01\x1b\x01\x0e\x01\x1b\x01\x10\x03\x1b\x01"+
            "\x0f\x02\x1b\x01\x13\x01\x11\x01\x15\x01\x1b\x01\x12\x02\x1b"+
            "\x01\x08\x01\x1a\x06\x1b\x01\x02\x01\x17\x01\x03\uff82\x20",
            "\x41\x2a\x1a\x29\x04\x2a\x01\x29\x01\x2a\x01\x29\x01\x21\x01"+
            "\x25\x01\x26\x01\x23\x01\x28\x07\x29\x01\x24\x01\x29\x01\x27"+
            "\x03\x29\x01\x22\x06\x29\uff85\x2a",
            "",
            "",
            "",
            "",
            "",
            "\x01\x30",
            "\x01\x32\x10\uffff\x01\x31",
            "",
            "",
            "",
            "",
            "",
            "\x01\x3b\x03\uffff\x01\x39\x01\uffff\x01\x3a",
            "\x01\x3c",
            "\x01\x3f\x01\x3e\x0a\uffff\x01\x3d",
            "\x01\x40",
            "\x01\x41",
            "\x01\x42",
            "\x01\x43\x03\uffff\x01\x45\x01\uffff\x01\x44",
            "\x01\x46",
            "\x01\x47\x01\x4a\x01\uffff\x0a\x4b\x04\uffff\x01\x48\x3d\uffff"+
            "\x01\x49",
            "\x01\x4c",
            "\x01\x4d",
            "\x01\x4f\x01\uffff\x0a\x4a",
            "\x01\x50",
            "",
            "\x01\x4a\x01\uffff\x0a\x4b",
            "\x09\x52\x01\x53\x01\x55\x02\x52\x01\x54\x12\x52\x01\x53\uffdf"+
            "\x52",
            "",
            "\x00\x57",
            "",
            "\x01\x58",
            "\x01\x5a",
            "\x01\x5b",
            "\x01\x5c",
            "\x01\x5e\x02\uffff\x01\x5d",
            "\x01\x5f",
            "\x01\x60",
            "\x01\x61",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x63\x11\uffff\x01\x62",
            "\x01\x64",
            "\x01\x65",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x33\x0c\uffff\x01\x33\x01\uffff\x0a\x33\x07\uffff\x1a"+
            "\x33\x04\uffff\x01\x33\x01\uffff\x1a\x33",
            "\x01\x68\x01\x67",
            "\x01\x69",
            "\x01\x33\x0c\uffff\x01\x33\x01\uffff\x0a\x33\x07\uffff\x1a"+
            "\x33\x04\uffff\x01\x33\x01\uffff\x1a\x33",
            "\x01\x33\x0c\uffff\x01\x33\x01\uffff\x0a\x33\x07\uffff\x1a"+
            "\x33\x04\uffff\x01\x33\x01\uffff\x1a\x33",
            "\x01\x33\x0c\uffff\x01\x33\x01\uffff\x0a\x33\x07\uffff\x1a"+
            "\x33\x04\uffff\x01\x33\x01\uffff\x1a\x33",
            "\x01\x6d",
            "\x01\x33\x0c\uffff\x01\x33\x01\uffff\x0a\x33\x07\uffff\x1a"+
            "\x33\x04\uffff\x01\x33\x01\uffff\x1a\x33",
            "\x01\x33\x0c\uffff\x01\x33\x01\uffff\x0a\x33\x07\uffff\x1a"+
            "\x33\x04\uffff\x01\x33\x01\uffff\x1a\x33",
            "\x01\x70",
            "\x01\x71",
            "\x01\x33\x0c\uffff\x01\x33\x01\uffff\x0a\x33\x07\uffff\x1a"+
            "\x33\x04\uffff\x01\x33\x01\uffff\x1a\x33",
            "\x01\x73",
            "\x01\x74",
            "",
            "",
            "",
            "",
            "\x01\x4a\x01\uffff\x0a\x4b",
            "",
            "",
            "",
            "",
            "\x01\x75",
            "",
            "",
            "\x21\x52\x01\x76\uffde\x52",
            "\x01\x52\x16\uffff\x01\x77",
            "\x01\x77",
            "",
            "",
            "\x01\x78",
            "",
            "\x01\x79",
            "\x01\x7a",
            "\x01\x7b",
            "\x01\x7c",
            "\x01\x7d",
            "\x01\x7e",
            "\x01\x7f",
            "\x01\u0080",
            "",
            "",
            "\x01\u0081",
            "\x01\u0082",
            "",
            "\x01\u0083",
            "\x01\u0084",
            "\x01\u0085",
            "",
            "",
            "",
            "\x01\u0086",
            "",
            "",
            "\x01\x33\x0c\uffff\x01\x33\x01\uffff\x0a\x33\x07\uffff\x1a"+
            "\x33\x04\uffff\x01\x33\x01\uffff\x1a\x33",
            "\x01\x33\x0c\uffff\x01\x33\x01\uffff\x0a\x33\x07\uffff\x1a"+
            "\x33\x04\uffff\x01\x33\x01\uffff\x1a\x33",
            "",
            "\x01\x33\x0c\uffff\x01\x33\x01\uffff\x0a\x33\x07\uffff\x1a"+
            "\x33\x04\uffff\x01\x33\x01\uffff\x1a\x33",
            "\x01\u008a",
            "\x01\u008b",
            "\x54\x52\x01\u008c\uffab\x52",
            "",
            "\x01\u008d",
            "\x01\u008e",
            "\x01\x59\x0c\uffff\x01\x59\x01\uffff\x0a\x59\x07\uffff\x1a"+
            "\x59\x04\uffff\x01\x59\x01\uffff\x1a\x59",
            "\x01\u0090",
            "\x01\u0091",
            "\x01\u0092",
            "\x01\u0093",
            "\x01\u0094",
            "\x01\u0095",
            "\x01\u0096",
            "\x01\u0097",
            "\x01\u0098",
            "\x01\u0099",
            "\x01\u009a",
            "\x01\u009b",
            "",
            "",
            "",
            "\x01\x33\x0c\uffff\x01\x33\x01\uffff\x0a\x33\x07\uffff\x1a"+
            "\x33\x04\uffff\x01\x33\x01\uffff\x1a\x33",
            "\x01\u009d",
            "\x49\x52\x01\u009e\uffb6\x52",
            "\x01\u009f",
            "\x01\u00a0",
            "",
            "\x01\x59\x0c\uffff\x01\x59\x01\uffff\x0a\x59\x07\uffff\x1a"+
            "\x59\x04\uffff\x01\x59\x01\uffff\x1a\x59",
            "\x01\u00a2",
            "\x01\x59\x0c\uffff\x01\x59\x01\uffff\x0a\x59\x07\uffff\x1a"+
            "\x59\x04\uffff\x01\x59\x01\uffff\x1a\x59",
            "\x01\x59\x0c\uffff\x01\x59\x01\uffff\x0a\x59\x07\uffff\x1a"+
            "\x59\x04\uffff\x01\x59\x01\uffff\x1a\x59",
            "\x01\x59\x0c\uffff\x01\x59\x01\uffff\x0a\x59\x07\uffff\x1a"+
            "\x59\x04\uffff\x01\x59\x01\uffff\x1a\x59",
            "\x01\x59\x0c\uffff\x01\x59\x01\uffff\x0a\x59\x07\uffff\x1a"+
            "\x59\x04\uffff\x01\x59\x01\uffff\x1a\x59",
            "\x01\x33\x0c\uffff\x01\x33\x01\uffff\x0a\x33\x07\uffff\x1a"+
            "\x33\x04\uffff\x01\x33\x01\uffff\x1a\x33",
            "\x01\x33\x0c\uffff\x01\x33\x01\uffff\x0a\x33\x07\uffff\x1a"+
            "\x33\x04\uffff\x01\x33\x01\uffff\x1a\x33",
            "\x01\u00a9",
            "\x01\u00aa",
            "\x01\u00ab",
            "\x01\u00ac",
            "",
            "\x01\u00ad",
            "\x4b\x52\x01\u00ae\uffb4\x52",
            "\x01\x59\x0c\uffff\x01\x59\x01\uffff\x0a\x59\x07\uffff\x1a"+
            "\x59\x04\uffff\x01\x59\x01\uffff\x1a\x59",
            "\x01\u00b1\x0e\uffff\x01\u00b0",
            "",
            "\x01\u00b2",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\u00b3",
            "\x01\u00b4",
            "\x01\x33\x0c\uffff\x01\x33\x01\uffff\x0a\x33\x07\uffff\x1a"+
            "\x33\x04\uffff\x01\x33\x01\uffff\x1a\x33",
            "\x01\u00b6",
            "\x01\u00b7",
            "\x5a\x52\x01\u00b8\uffa5\x52",
            "",
            "\x01\u00b9",
            "\x01\u00ba",
            "\x01\u00bb",
            "\x01\u00bc",
            "\x01\u00bd",
            "",
            "\x01\x33\x0c\uffff\x01\x33\x01\uffff\x0a\x33\x07\uffff\x1a"+
            "\x33\x04\uffff\x01\x33\x01\uffff\x1a\x33",
            "\x01\u00bf",
            "\x45\x52\x01\u00c0\uffba\x52",
            "\x01\u00c1",
            "\x01\x59\x0c\uffff\x01\x59\x01\uffff\x0a\x59\x07\uffff\x1a"+
            "\x59\x04\uffff\x01\x59\x01\uffff\x1a\x59",
            "\x01\u00c3",
            "\x01\u00c4",
            "\x01\x33\x0c\uffff\x01\x33\x01\uffff\x0a\x33\x07\uffff\x1a"+
            "\x33\x04\uffff\x01\x33\x01\uffff\x1a\x33",
            "",
            "\x01\u00c6",
            "\x44\x52\x01\u00c7\uffbb\x52",
            "\x01\u00c8",
            "",
            "\x01\u00c9",
            "\x01\u00ca",
            "",
            "\x01\u00cb",
            "\x54\x52\x01\u00cc\uffab\x52",
            "\x01\x59\x0c\uffff\x01\x59\x01\uffff\x0a\x59\x07\uffff\x1a"+
            "\x59\x04\uffff\x01\x59\x01\uffff\x1a\x59",
            "\x01\u00ce",
            "\x01\x33\x0c\uffff\x01\x33\x01\uffff\x0a\x33\x07\uffff\x1a"+
            "\x33\x04\uffff\x01\x33\x01\uffff\x1a\x33",
            "\x01\u00d0",
            "\x0a\u00d1\x01\u00d3\x02\u00d1\x01\u00d2\ufff2\u00d1",
            "",
            "\x01\x59\x0c\uffff\x01\x59\x01\uffff\x0a\x59\x07\uffff\x1a"+
            "\x59\x04\uffff\x01\x59\x01\uffff\x1a\x59",
            "",
            "\x01\x33\x0c\uffff\x01\x33\x01\uffff\x0a\x33\x07\uffff\x1a"+
            "\x33\x04\uffff\x01\x33\x01\uffff\x1a\x33",
            "\x0a\u00d1\x01\u00d3\x02\u00d1\x01\u00d2\ufff2\u00d1",
            "\x01\u00d3",
            "",
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
            get { return "1:1: Tokens : ( T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | T__77 | T__78 | T__79 | T__80 | T__81 | T__82 | T__83 | T__84 | ID | INT | FLOAT_WO_EXP | TIKZEDT_CMD_COMMENT | COMMENT | WS | MATHSTRING | COMMAND | ESC_SEQ | SOMETHING );"; }
        }

    }


    protected internal int DFA21_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            IIntStream input = _input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA21_31 = input.LA(1);

                   	s = -1;
                   	if ( ((LA21_31 >= '\u0000' && LA21_31 <= '\uFFFF')) ) { s = 87; }

                   	else s = 32;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA21_1 = input.LA(1);

                   	s = -1;
                   	if ( (LA21_1 == 'b') ) { s = 33; }

                   	else if ( (LA21_1 == 't') ) { s = 34; }

                   	else if ( (LA21_1 == 'e') ) { s = 35; }

                   	else if ( (LA21_1 == 'n') ) { s = 36; }

                   	else if ( (LA21_1 == 'c') ) { s = 37; }

                   	else if ( (LA21_1 == 'd') ) { s = 38; }

                   	else if ( (LA21_1 == 'p') ) { s = 39; }

                   	else if ( (LA21_1 == 'f') ) { s = 40; }

                   	else if ( ((LA21_1 >= 'A' && LA21_1 <= 'Z') || LA21_1 == '_' || LA21_1 == 'a' || (LA21_1 >= 'g' && LA21_1 <= 'm') || LA21_1 == 'o' || (LA21_1 >= 'q' && LA21_1 <= 's') || (LA21_1 >= 'u' && LA21_1 <= 'z')) ) { s = 41; }

                   	else if ( ((LA21_1 >= '\u0000' && LA21_1 <= '@') || (LA21_1 >= '[' && LA21_1 <= '^') || LA21_1 == '`' || (LA21_1 >= '{' && LA21_1 <= '\uFFFF')) ) { s = 42; }

                   	else s = 32;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA21_83 = input.LA(1);

                   	s = -1;
                   	if ( (LA21_83 == '!') ) { s = 118; }

                   	else if ( ((LA21_83 >= '\u0000' && LA21_83 <= ' ') || (LA21_83 >= '\"' && LA21_83 <= '\uFFFF')) ) { s = 82; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA21_209 = input.LA(1);

                   	s = -1;
                   	if ( (LA21_209 == '\r') ) { s = 210; }

                   	else if ( (LA21_209 == '\n') ) { s = 211; }

                   	else if ( ((LA21_209 >= '\u0000' && LA21_209 <= '\t') || (LA21_209 >= '\u000B' && LA21_209 <= '\f') || (LA21_209 >= '\u000E' && LA21_209 <= '\uFFFF')) ) { s = 209; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA21_204 = input.LA(1);

                   	s = -1;
                   	if ( ((LA21_204 >= '\u0000' && LA21_204 <= '\t') || (LA21_204 >= '\u000B' && LA21_204 <= '\f') || (LA21_204 >= '\u000E' && LA21_204 <= '\uFFFF')) ) { s = 209; }

                   	else if ( (LA21_204 == '\r') ) { s = 210; }

                   	else if ( (LA21_204 == '\n') ) { s = 211; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA21_199 = input.LA(1);

                   	s = -1;
                   	if ( (LA21_199 == 'T') ) { s = 204; }

                   	else if ( ((LA21_199 >= '\u0000' && LA21_199 <= 'S') || (LA21_199 >= 'U' && LA21_199 <= '\uFFFF')) ) { s = 82; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA21_192 = input.LA(1);

                   	s = -1;
                   	if ( (LA21_192 == 'D') ) { s = 199; }

                   	else if ( ((LA21_192 >= '\u0000' && LA21_192 <= 'C') || (LA21_192 >= 'E' && LA21_192 <= '\uFFFF')) ) { s = 82; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA21_184 = input.LA(1);

                   	s = -1;
                   	if ( (LA21_184 == 'E') ) { s = 192; }

                   	else if ( ((LA21_184 >= '\u0000' && LA21_184 <= 'D') || (LA21_184 >= 'F' && LA21_184 <= '\uFFFF')) ) { s = 82; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA21_174 = input.LA(1);

                   	s = -1;
                   	if ( (LA21_174 == 'Z') ) { s = 184; }

                   	else if ( ((LA21_174 >= '\u0000' && LA21_174 <= 'Y') || (LA21_174 >= '[' && LA21_174 <= '\uFFFF')) ) { s = 82; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA21_158 = input.LA(1);

                   	s = -1;
                   	if ( (LA21_158 == 'K') ) { s = 174; }

                   	else if ( ((LA21_158 >= '\u0000' && LA21_158 <= 'J') || (LA21_158 >= 'L' && LA21_158 <= '\uFFFF')) ) { s = 82; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA21_140 = input.LA(1);

                   	s = -1;
                   	if ( (LA21_140 == 'I') ) { s = 158; }

                   	else if ( ((LA21_140 >= '\u0000' && LA21_140 <= 'H') || (LA21_140 >= 'J' && LA21_140 <= '\uFFFF')) ) { s = 82; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA21_118 = input.LA(1);

                   	s = -1;
                   	if ( (LA21_118 == 'T') ) { s = 140; }

                   	else if ( ((LA21_118 >= '\u0000' && LA21_118 <= 'S') || (LA21_118 >= 'U' && LA21_118 <= '\uFFFF')) ) { s = 82; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA21_0 = input.LA(1);

                   	s = -1;
                   	if ( (LA21_0 == '\\') ) { s = 1; }

                   	else if ( (LA21_0 == '{') ) { s = 2; }

                   	else if ( (LA21_0 == '}') ) { s = 3; }

                   	else if ( (LA21_0 == '=') ) { s = 4; }

                   	else if ( (LA21_0 == ',') ) { s = 5; }

                   	else if ( (LA21_0 == ':') ) { s = 6; }

                   	else if ( (LA21_0 == '/') ) { s = 7; }

                   	else if ( (LA21_0 == 's') ) { s = 8; }

                   	else if ( (LA21_0 == '(') ) { s = 9; }

                   	else if ( (LA21_0 == ')') ) { s = 10; }

                   	else if ( (LA21_0 == '[') ) { s = 11; }

                   	else if ( (LA21_0 == ']') ) { s = 12; }

                   	else if ( (LA21_0 == ';') ) { s = 13; }

                   	else if ( (LA21_0 == 'c') ) { s = 14; }

                   	else if ( (LA21_0 == 'i') ) { s = 15; }

                   	else if ( (LA21_0 == 'e') ) { s = 16; }

                   	else if ( (LA21_0 == 'm') ) { s = 17; }

                   	else if ( (LA21_0 == 'p') ) { s = 18; }

                   	else if ( (LA21_0 == 'l') ) { s = 19; }

                   	else if ( (LA21_0 == 'a') ) { s = 20; }

                   	else if ( (LA21_0 == 'n') ) { s = 21; }

                   	else if ( (LA21_0 == '-') ) { s = 22; }

                   	else if ( (LA21_0 == '|') ) { s = 23; }

                   	else if ( (LA21_0 == '+') ) { s = 24; }

                   	else if ( (LA21_0 == '.') ) { s = 25; }

                   	else if ( (LA21_0 == 't') ) { s = 26; }

                   	else if ( ((LA21_0 >= 'A' && LA21_0 <= 'Z') || LA21_0 == '_' || LA21_0 == 'b' || LA21_0 == 'd' || (LA21_0 >= 'f' && LA21_0 <= 'h') || (LA21_0 >= 'j' && LA21_0 <= 'k') || LA21_0 == 'o' || (LA21_0 >= 'q' && LA21_0 <= 'r') || (LA21_0 >= 'u' && LA21_0 <= 'z')) ) { s = 27; }

                   	else if ( ((LA21_0 >= '0' && LA21_0 <= '9')) ) { s = 28; }

                   	else if ( (LA21_0 == '%') ) { s = 29; }

                   	else if ( ((LA21_0 >= '\t' && LA21_0 <= '\n') || LA21_0 == '\r' || LA21_0 == ' ') ) { s = 30; }

                   	else if ( (LA21_0 == '$') ) { s = 31; }

                   	else if ( ((LA21_0 >= '\u0000' && LA21_0 <= '\b') || (LA21_0 >= '\u000B' && LA21_0 <= '\f') || (LA21_0 >= '\u000E' && LA21_0 <= '\u001F') || (LA21_0 >= '!' && LA21_0 <= '#') || (LA21_0 >= '&' && LA21_0 <= '\'') || LA21_0 == '*' || LA21_0 == '<' || (LA21_0 >= '>' && LA21_0 <= '@') || LA21_0 == '^' || LA21_0 == '`' || (LA21_0 >= '~' && LA21_0 <= '\uFFFF')) ) { s = 32; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 13 : 
                   	int LA21_29 = input.LA(1);

                   	s = -1;
                   	if ( ((LA21_29 >= '\u0000' && LA21_29 <= '\b') || (LA21_29 >= '\u000B' && LA21_29 <= '\f') || (LA21_29 >= '\u000E' && LA21_29 <= '\u001F') || (LA21_29 >= '!' && LA21_29 <= '\uFFFF')) ) { s = 82; }

                   	else if ( (LA21_29 == '\t' || LA21_29 == ' ') ) { s = 83; }

                   	else if ( (LA21_29 == '\r') ) { s = 84; }

                   	else if ( (LA21_29 == '\n') ) { s = 85; }

                   	else s = 32;

                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae21 =
            new NoViableAltException(dfa.Description, 21, _s, input);
        dfa.Error(nvae21);
        throw nvae21;
    }
 
    
}
