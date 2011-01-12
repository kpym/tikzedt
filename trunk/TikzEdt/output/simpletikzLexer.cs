// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g 2011-01-12 01:24:22

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
    public const int EXPONENT = 32;
    public const int T__64 = 64;
    public const int T__65 = 65;
    public const int IM_STARTTAG = 13;
    public const int TIKZEDT_CMD_COMMENT = 25;
    public const int T__62 = 62;
    public const int T__63 = 63;
    public const int IM_PATH = 4;
    public const int IM_ID = 18;
    public const int IM_DONTCARE = 24;
    public const int SOMETHING = 35;
    public const int ID = 26;
    public const int T__61 = 61;
    public const int EOF = -1;
    public const int T__60 = 60;
    public const int MATHSTRING = 34;
    public const int COMMAND = 29;
    public const int IM_ENDTAG = 14;
    public const int IM_USETIKZLIB = 20;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int IM_DOCUMENT = 11;
    public const int T__58 = 58;
    public const int ESC_SEQ = 33;
    public const int IM_STRING = 21;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int IM_TIKZSET = 19;
    public const int T__59 = 59;
    public const int IM_OPTION_KV = 17;
    public const int COMMENT = 31;
    public const int T__50 = 50;
    public const int IM_TIKZEDT_CMD = 23;
    public const int T__42 = 42;
    public const int T__43 = 43;
    public const int T__40 = 40;
    public const int T__41 = 41;
    public const int T__46 = 46;
    public const int IM_OPTIONS = 15;
    public const int T__47 = 47;
    public const int T__44 = 44;
    public const int IM_OPTION_STYLE = 16;
    public const int T__45 = 45;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int IM_COORD = 6;
    public const int IM_PICTURE = 10;
    public const int INT = 28;
    public const int IM_NODE = 5;
    public const int IM_STYLE = 22;
    public const int IM_NUMBERUNIT = 9;
    public const int IM_SCOPE = 12;
    public const int T__71 = 71;
    public const int WS = 30;
    public const int T__72 = 72;
    public const int T__70 = 70;
    public const int T__36 = 36;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int IM_SIZE = 7;
    public const int T__76 = 76;
    public const int T__75 = 75;
    public const int T__74 = 74;
    public const int T__73 = 73;
    public const int IM_NODENAME = 8;
    public const int T__78 = 78;
    public const int FLOAT_WO_EXP = 27;
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
    	get { return "C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g";} 
    }

    // $ANTLR start "T__36"
    public void mT__36() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__36;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:28:7: ( '\\\\begin' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:28:9: '\\\\begin'
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
    // $ANTLR end "T__36"

    // $ANTLR start "T__37"
    public void mT__37() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__37;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:29:7: ( '\\\\tikzstyle' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:29:9: '\\\\tikzstyle'
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
    // $ANTLR end "T__37"

    // $ANTLR start "T__38"
    public void mT__38() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__38;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:30:7: ( '\\\\tikzset' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:30:9: '\\\\tikzset'
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
    // $ANTLR end "T__38"

    // $ANTLR start "T__39"
    public void mT__39() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__39;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:31:7: ( '{' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:31:9: '{'
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
    // $ANTLR end "T__39"

    // $ANTLR start "T__40"
    public void mT__40() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__40;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:32:7: ( '}' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:32:9: '}'
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
    // $ANTLR end "T__40"

    // $ANTLR start "T__41"
    public void mT__41() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__41;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:33:7: ( '=' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:33:9: '='
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
    // $ANTLR end "T__41"

    // $ANTLR start "T__42"
    public void mT__42() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__42;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:34:7: ( ',' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:34:9: ','
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
    // $ANTLR end "T__42"

    // $ANTLR start "T__43"
    public void mT__43() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__43;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:35:7: ( ':' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:35:9: ':'
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
    // $ANTLR end "T__43"

    // $ANTLR start "T__44"
    public void mT__44() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__44;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:36:7: ( '/.style' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:36:9: '/.style'
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
    // $ANTLR end "T__44"

    // $ANTLR start "T__45"
    public void mT__45() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__45;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:37:7: ( '(' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:37:9: '('
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
    // $ANTLR end "T__45"

    // $ANTLR start "T__46"
    public void mT__46() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__46;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:38:7: ( ')' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:38:9: ')'
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
    // $ANTLR end "T__46"

    // $ANTLR start "T__47"
    public void mT__47() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__47;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:39:7: ( '[' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:39:9: '['
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
    // $ANTLR end "T__47"

    // $ANTLR start "T__48"
    public void mT__48() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__48;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:40:7: ( ']' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:40:9: ']'
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
    // $ANTLR end "T__48"

    // $ANTLR start "T__49"
    public void mT__49() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__49;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:41:7: ( ';' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:41:9: ';'
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
    // $ANTLR end "T__49"

    // $ANTLR start "T__50"
    public void mT__50() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__50;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:42:7: ( 'cm' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:42:9: 'cm'
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
    // $ANTLR end "T__50"

    // $ANTLR start "T__51"
    public void mT__51() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__51;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:43:7: ( 'in' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:43:9: 'in'
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
    // $ANTLR end "T__51"

    // $ANTLR start "T__52"
    public void mT__52() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__52;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:44:7: ( 'ex' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:44:9: 'ex'
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
    // $ANTLR end "T__52"

    // $ANTLR start "T__53"
    public void mT__53() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__53;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:45:7: ( 'mm' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:45:9: 'mm'
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
    // $ANTLR end "T__53"

    // $ANTLR start "T__54"
    public void mT__54() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__54;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:46:7: ( 'pt' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:46:9: 'pt'
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
    // $ANTLR end "T__54"

    // $ANTLR start "T__55"
    public void mT__55() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__55;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:47:7: ( 'em' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:47:9: 'em'
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
    // $ANTLR end "T__55"

    // $ANTLR start "T__56"
    public void mT__56() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__56;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:48:7: ( '\\\\end' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:48:9: '\\\\end'
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
    // $ANTLR end "T__56"

    // $ANTLR start "T__57"
    public void mT__57() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__57;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:49:7: ( '\\\\node' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:49:9: '\\\\node'
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
    // $ANTLR end "T__57"

    // $ANTLR start "T__58"
    public void mT__58() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__58;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:50:7: ( '\\\\coordinate' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:50:9: '\\\\coordinate'
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
    // $ANTLR end "T__58"

    // $ANTLR start "T__59"
    public void mT__59() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__59;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:51:7: ( '\\\\draw' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:51:9: '\\\\draw'
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
    // $ANTLR end "T__59"

    // $ANTLR start "T__60"
    public void mT__60() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__60;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:52:7: ( '\\\\path' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:52:9: '\\\\path'
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
    // $ANTLR end "T__60"

    // $ANTLR start "T__61"
    public void mT__61() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__61;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:53:7: ( '\\\\fill' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:53:9: '\\\\fill'
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
    // $ANTLR end "T__61"

    // $ANTLR start "T__62"
    public void mT__62() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__62;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:54:7: ( '\\\\clip' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:54:9: '\\\\clip'
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
    // $ANTLR end "T__62"

    // $ANTLR start "T__63"
    public void mT__63() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__63;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:55:7: ( 'let' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:55:9: 'let'
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
    // $ANTLR end "T__63"

    // $ANTLR start "T__64"
    public void mT__64() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__64;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:56:7: ( 'coordinate' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:56:9: 'coordinate'
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
    // $ANTLR end "T__64"

    // $ANTLR start "T__65"
    public void mT__65() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__65;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:57:7: ( 'node' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:57:9: 'node'
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
    // $ANTLR end "T__65"

    // $ANTLR start "T__66"
    public void mT__66() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__66;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:58:7: ( 'at' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:58:9: 'at'
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
    // $ANTLR end "T__66"

    // $ANTLR start "T__67"
    public void mT__67() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__67;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:59:7: ( 'circle' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:59:9: 'circle'
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
    // $ANTLR end "T__67"

    // $ANTLR start "T__68"
    public void mT__68() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__68;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:60:7: ( 'ellipse' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:60:9: 'ellipse'
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
    // $ANTLR end "T__68"

    // $ANTLR start "T__69"
    public void mT__69() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__69;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:61:7: ( 'arc' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:61:9: 'arc'
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
    // $ANTLR end "T__69"

    // $ANTLR start "T__70"
    public void mT__70() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__70;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:62:7: ( 'and' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:62:9: 'and'
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
    // $ANTLR end "T__70"

    // $ANTLR start "T__71"
    public void mT__71() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__71;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:63:7: ( '--' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:63:9: '--'
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
    // $ANTLR end "T__71"

    // $ANTLR start "T__72"
    public void mT__72() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__72;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:64:7: ( '->' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:64:9: '->'
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
    // $ANTLR end "T__72"

    // $ANTLR start "T__73"
    public void mT__73() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__73;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:65:7: ( '|-' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:65:9: '|-'
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
    // $ANTLR end "T__73"

    // $ANTLR start "T__74"
    public void mT__74() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__74;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:66:7: ( '-|' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:66:9: '-|'
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
    // $ANTLR end "T__74"

    // $ANTLR start "T__75"
    public void mT__75() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__75;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:67:7: ( '+' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:67:9: '+'
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
    // $ANTLR end "T__75"

    // $ANTLR start "T__76"
    public void mT__76() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__76;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:68:7: ( '++' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:68:9: '++'
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
    // $ANTLR end "T__76"

    // $ANTLR start "T__77"
    public void mT__77() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__77;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:69:7: ( 'tikzpicture' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:69:9: 'tikzpicture'
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
    // $ANTLR end "T__77"

    // $ANTLR start "T__78"
    public void mT__78() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__78;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:70:7: ( 'scope' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:70:9: 'scope'
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
    // $ANTLR end "T__78"

    // $ANTLR start "ID"
    public void mID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:500:5: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' | '!' )* )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:500:7: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' | '!' )*
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

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:500:31: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' | '!' )*
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
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:503:5: ( ( '-' )? ( '0' .. '9' )+ )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:503:7: ( '-' )? ( '0' .. '9' )+
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:503:7: ( '-' )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == '-') )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:503:7: '-'
            	        {
            	        	Match('-'); 

            	        }
            	        break;

            	}

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:503:12: ( '0' .. '9' )+
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
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:503:12: '0' .. '9'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:515:5: ( ( '-' )? ( '0' .. '9' )+ '.' ( '0' .. '9' )* | ( '-' )? '.' ( '0' .. '9' )+ )
            int alt9 = 2;
            switch ( input.LA(1) ) 
            {
            case '-':
            	{
                int LA9_1 = input.LA(2);

                if ( (LA9_1 == '.') )
                {
                    alt9 = 2;
                }
                else if ( ((LA9_1 >= '0' && LA9_1 <= '9')) )
                {
                    alt9 = 1;
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
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:515:9: ( '-' )? ( '0' .. '9' )+ '.' ( '0' .. '9' )*
                    {
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:515:9: ( '-' )?
                    	int alt4 = 2;
                    	int LA4_0 = input.LA(1);

                    	if ( (LA4_0 == '-') )
                    	{
                    	    alt4 = 1;
                    	}
                    	switch (alt4) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:515:9: '-'
                    	        {
                    	        	Match('-'); 

                    	        }
                    	        break;

                    	}

                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:515:14: ( '0' .. '9' )+
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
                    			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:515:15: '0' .. '9'
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
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:515:30: ( '0' .. '9' )*
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
                    			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:515:31: '0' .. '9'
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
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:516:9: ( '-' )? '.' ( '0' .. '9' )+
                    {
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:516:9: ( '-' )?
                    	int alt7 = 2;
                    	int LA7_0 = input.LA(1);

                    	if ( (LA7_0 == '-') )
                    	{
                    	    alt7 = 1;
                    	}
                    	switch (alt7) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:516:9: '-'
                    	        {
                    	        	Match('-'); 

                    	        }
                    	        break;

                    	}

                    	Match('.'); 
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:516:18: ( '0' .. '9' )+
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
                    			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:516:19: '0' .. '9'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:520:5: ( '%' WS '!TIKZEDT' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:520:9: '%' WS '!TIKZEDT' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
            {
            	Match('%'); 
            	mWS(); 
            	Match("!TIKZEDT"); 

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:520:29: (~ ( '\\n' | '\\r' ) )*
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
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:520:29: ~ ( '\\n' | '\\r' )
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

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:520:43: ( '\\r' )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == '\r') )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:520:43: '\\r'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:524:5: ( '%' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:524:9: '%' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
            {
            	Match('%'); 
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:524:13: (~ ( '\\n' | '\\r' ) )*
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
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:524:13: ~ ( '\\n' | '\\r' )
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

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:524:27: ( '\\r' )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == '\r') )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:524:27: '\\r'
            	        {
            	        	Match('\r'); 

            	        }
            	        break;

            	}

            	Match('\n'); 
            	_channel=HIDDEN;

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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:527:5: ( ( ' ' | '\\t' | '\\r' | '\\n' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:527:9: ( ' ' | '\\t' | '\\r' | '\\n' )
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:534:19: ( ( 'e' | 'E' ) ( '+' | '-' )? ( '0' .. '9' )+ )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:534:21: ( 'e' | 'E' ) ( '+' | '-' )? ( '0' .. '9' )+
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

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:534:31: ( '+' | '-' )?
            	int alt14 = 2;
            	int LA14_0 = input.LA(1);

            	if ( (LA14_0 == '+' || LA14_0 == '-') )
            	{
            	    alt14 = 1;
            	}
            	switch (alt14) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:
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

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:534:42: ( '0' .. '9' )+
            	int cnt15 = 0;
            	do 
            	{
            	    int alt15 = 2;
            	    int LA15_0 = input.LA(1);

            	    if ( ((LA15_0 >= '0' && LA15_0 <= '9')) )
            	    {
            	        alt15 = 1;
            	    }


            	    switch (alt15) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:534:43: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:541:2: ( '$' ( ESC_SEQ | ~ ( '\\\\' | '$' ) )* '$' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:541:4: '$' ( ESC_SEQ | ~ ( '\\\\' | '$' ) )* '$'
            {
            	Match('$'); 
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:541:8: ( ESC_SEQ | ~ ( '\\\\' | '$' ) )*
            	do 
            	{
            	    int alt16 = 3;
            	    int LA16_0 = input.LA(1);

            	    if ( (LA16_0 == '\\') )
            	    {
            	        alt16 = 1;
            	    }
            	    else if ( ((LA16_0 >= '\u0000' && LA16_0 <= '#') || (LA16_0 >= '%' && LA16_0 <= '[') || (LA16_0 >= ']' && LA16_0 <= '\uFFFF')) )
            	    {
            	        alt16 = 2;
            	    }


            	    switch (alt16) 
            		{
            			case 1 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:541:10: ESC_SEQ
            			    {
            			    	mESC_SEQ(); 

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:541:20: ~ ( '\\\\' | '$' )
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
            			    goto loop16;
            	    }
            	} while (true);

            	loop16:
            		;	// Stops C# compiler whining that label 'loop16' has no statements

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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:552:2: ( '\\\\' ID )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:552:4: '\\\\' ID
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:557:5: ( '\\\\' . )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:557:9: '\\\\' .
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:563:2: ( . )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:563:4: .
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
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:8: ( T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | T__77 | T__78 | ID | INT | FLOAT_WO_EXP | TIKZEDT_CMD_COMMENT | COMMENT | WS | MATHSTRING | COMMAND | ESC_SEQ | SOMETHING )
        int alt17 = 53;
        alt17 = dfa17.Predict(input);
        switch (alt17) 
        {
            case 1 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:10: T__36
                {
                	mT__36(); 

                }
                break;
            case 2 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:16: T__37
                {
                	mT__37(); 

                }
                break;
            case 3 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:22: T__38
                {
                	mT__38(); 

                }
                break;
            case 4 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:28: T__39
                {
                	mT__39(); 

                }
                break;
            case 5 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:34: T__40
                {
                	mT__40(); 

                }
                break;
            case 6 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:40: T__41
                {
                	mT__41(); 

                }
                break;
            case 7 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:46: T__42
                {
                	mT__42(); 

                }
                break;
            case 8 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:52: T__43
                {
                	mT__43(); 

                }
                break;
            case 9 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:58: T__44
                {
                	mT__44(); 

                }
                break;
            case 10 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:64: T__45
                {
                	mT__45(); 

                }
                break;
            case 11 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:70: T__46
                {
                	mT__46(); 

                }
                break;
            case 12 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:76: T__47
                {
                	mT__47(); 

                }
                break;
            case 13 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:82: T__48
                {
                	mT__48(); 

                }
                break;
            case 14 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:88: T__49
                {
                	mT__49(); 

                }
                break;
            case 15 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:94: T__50
                {
                	mT__50(); 

                }
                break;
            case 16 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:100: T__51
                {
                	mT__51(); 

                }
                break;
            case 17 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:106: T__52
                {
                	mT__52(); 

                }
                break;
            case 18 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:112: T__53
                {
                	mT__53(); 

                }
                break;
            case 19 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:118: T__54
                {
                	mT__54(); 

                }
                break;
            case 20 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:124: T__55
                {
                	mT__55(); 

                }
                break;
            case 21 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:130: T__56
                {
                	mT__56(); 

                }
                break;
            case 22 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:136: T__57
                {
                	mT__57(); 

                }
                break;
            case 23 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:142: T__58
                {
                	mT__58(); 

                }
                break;
            case 24 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:148: T__59
                {
                	mT__59(); 

                }
                break;
            case 25 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:154: T__60
                {
                	mT__60(); 

                }
                break;
            case 26 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:160: T__61
                {
                	mT__61(); 

                }
                break;
            case 27 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:166: T__62
                {
                	mT__62(); 

                }
                break;
            case 28 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:172: T__63
                {
                	mT__63(); 

                }
                break;
            case 29 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:178: T__64
                {
                	mT__64(); 

                }
                break;
            case 30 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:184: T__65
                {
                	mT__65(); 

                }
                break;
            case 31 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:190: T__66
                {
                	mT__66(); 

                }
                break;
            case 32 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:196: T__67
                {
                	mT__67(); 

                }
                break;
            case 33 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:202: T__68
                {
                	mT__68(); 

                }
                break;
            case 34 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:208: T__69
                {
                	mT__69(); 

                }
                break;
            case 35 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:214: T__70
                {
                	mT__70(); 

                }
                break;
            case 36 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:220: T__71
                {
                	mT__71(); 

                }
                break;
            case 37 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:226: T__72
                {
                	mT__72(); 

                }
                break;
            case 38 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:232: T__73
                {
                	mT__73(); 

                }
                break;
            case 39 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:238: T__74
                {
                	mT__74(); 

                }
                break;
            case 40 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:244: T__75
                {
                	mT__75(); 

                }
                break;
            case 41 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:250: T__76
                {
                	mT__76(); 

                }
                break;
            case 42 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:256: T__77
                {
                	mT__77(); 

                }
                break;
            case 43 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:262: T__78
                {
                	mT__78(); 

                }
                break;
            case 44 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:268: ID
                {
                	mID(); 

                }
                break;
            case 45 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:271: INT
                {
                	mINT(); 

                }
                break;
            case 46 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:275: FLOAT_WO_EXP
                {
                	mFLOAT_WO_EXP(); 

                }
                break;
            case 47 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:288: TIKZEDT_CMD_COMMENT
                {
                	mTIKZEDT_CMD_COMMENT(); 

                }
                break;
            case 48 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:308: COMMENT
                {
                	mCOMMENT(); 

                }
                break;
            case 49 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:316: WS
                {
                	mWS(); 

                }
                break;
            case 50 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:319: MATHSTRING
                {
                	mMATHSTRING(); 

                }
                break;
            case 51 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:330: COMMAND
                {
                	mCOMMAND(); 

                }
                break;
            case 52 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:338: ESC_SEQ
                {
                	mESC_SEQ(); 

                }
                break;
            case 53 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:346: SOMETHING
                {
                	mSOMETHING(); 

                }
                break;

        }

    }


    protected DFA17 dfa17;
	private void InitializeCyclicDFAs()
	{
	    this.dfa17 = new DFA17(this);
	    this.dfa17.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA17_SpecialStateTransition);
	}

    const string DFA17_eotS =
        "\x01\uffff\x01\x20\x05\uffff\x01\x20\x05\uffff\x08\x39\x02\x20"+
        "\x01\x4c\x02\x39\x01\uffff\x01\x4f\x02\x20\x01\uffff\x01\x20\x01"+
        "\uffff\x08\x57\x0d\uffff\x01\x60\x02\x39\x01\uffff\x01\x63\x01\x64"+
        "\x01\x65\x01\x39\x01\x67\x01\x68\x02\x39\x01\x6b\x02\x39\x03\uffff"+
        "\x01\x4f\x04\uffff\x02\x39\x03\uffff\x01\x53\x03\uffff\x01\x57\x01"+
        "\uffff\x08\x57\x01\uffff\x02\x39\x03\uffff\x01\x39\x02\uffff\x01"+
        "\x7e\x01\x39\x01\uffff\x01\u0080\x01\u0081\x02\x39\x02\uffff\x02"+
        "\x57\x01\u0087\x06\x57\x03\x39\x01\uffff\x01\u0091\x02\uffff\x02"+
        "\x39\x01\uffff\x02\x57\x01\uffff\x01\u0097\x01\x57\x01\u0099\x01"+
        "\u009a\x01\u009b\x01\u009c\x03\x39\x01\uffff\x01\x39\x01\u00a1\x01"+
        "\uffff\x01\u00a3\x01\x57\x01\uffff\x01\x57\x04\uffff\x01\x39\x01"+
        "\u00a8\x02\x39\x03\uffff\x03\x57\x01\x39\x01\uffff\x01\u00b0\x01"+
        "\x39\x01\uffff\x01\x57\x01\u00b4\x01\x57\x01\x39\x01\uffff\x01\x39"+
        "\x01\uffff\x01\x57\x01\uffff\x01\x57\x02\x39\x01\uffff\x01\u00be"+
        "\x01\x57\x01\u00c0\x01\x39\x02\uffff\x01\u00c5\x01\uffff\x01\u00c6"+
        "\x05\uffff";
    const string DFA17_eofS =
        "\u00c7\uffff";
    const string DFA17_minS =
        "\x02\x00\x05\uffff\x01\x2e\x05\uffff\x01\x69\x01\x6e\x01\x6c\x01"+
        "\x6d\x01\x74\x01\x65\x01\x6f\x01\x6e\x02\x2d\x01\x2b\x01\x69\x01"+
        "\x63\x01\uffff\x01\x2e\x01\x30\x01\x00\x01\uffff\x01\x00\x01\uffff"+
        "\x01\x65\x01\x69\x01\x6e\x01\x6f\x01\x6c\x01\x72\x01\x61\x01\x69"+
        "\x0d\uffff\x01\x21\x01\x6f\x01\x72\x01\uffff\x03\x21\x01\x6c\x02"+
        "\x21\x01\x74\x01\x64\x01\x21\x01\x63\x01\x64\x03\uffff\x01\x2e\x04"+
        "\uffff\x01\x6b\x01\x6f\x01\uffff\x01\x00\x01\x0a\x01\x21\x03\uffff"+
        "\x01\x67\x01\uffff\x01\x6b\x02\x64\x01\x6f\x01\x69\x01\x61\x01\x74"+
        "\x01\x6c\x01\uffff\x01\x72\x01\x63\x03\uffff\x01\x69\x02\uffff\x01"+
        "\x21\x01\x65\x01\uffff\x02\x21\x01\x7a\x01\x70\x01\x00\x01\uffff"+
        "\x01\x69\x01\x7a\x01\x21\x01\x65\x01\x72\x01\x70\x01\x77\x01\x68"+
        "\x01\x6c\x01\x64\x01\x6c\x01\x70\x01\uffff\x01\x21\x02\uffff\x01"+
        "\x70\x01\x65\x01\x00\x01\x6e\x01\x73\x01\uffff\x01\x21\x01\x64\x04"+
        "\x21\x01\x69\x01\x65\x01\x73\x01\uffff\x01\x69\x01\x21\x01\x00\x01"+
        "\x21\x01\x65\x01\uffff\x01\x69\x04\uffff\x01\x6e\x01\x21\x01\x65"+
        "\x01\x63\x01\uffff\x01\x00\x01\uffff\x01\x79\x01\x74\x01\x6e\x01"+
        "\x61\x01\uffff\x01\x21\x01\x74\x01\x00\x01\x6c\x01\x21\x01\x61\x01"+
        "\x74\x01\uffff\x01\x75\x01\x00\x01\x65\x01\uffff\x01\x74\x01\x65"+
        "\x01\x72\x01\x00\x01\x21\x01\x65\x01\x21\x01\x65\x01\x00\x01\uffff"+
        "\x01\x21\x01\uffff\x01\x21\x01\x0a\x01\uffff\x01\x00\x02\uffff";
    const string DFA17_maxS =
        "\x02\uffff\x05\uffff\x01\x2e\x05\uffff\x01\x6f\x01\x6e\x01\x78"+
        "\x01\x6d\x01\x74\x01\x65\x01\x6f\x01\x74\x01\x7c\x01\x2d\x01\x2b"+
        "\x01\x69\x01\x63\x01\uffff\x02\x39\x01\uffff\x01\uffff\x01\uffff"+
        "\x01\uffff\x01\x65\x01\x69\x01\x6e\x02\x6f\x01\x72\x01\x61\x01\x69"+
        "\x0d\uffff\x01\x7a\x01\x6f\x01\x72\x01\uffff\x03\x7a\x01\x6c\x02"+
        "\x7a\x01\x74\x01\x64\x01\x7a\x01\x63\x01\x64\x03\uffff\x01\x39\x04"+
        "\uffff\x01\x6b\x01\x6f\x01\uffff\x01\uffff\x02\x21\x03\uffff\x01"+
        "\x67\x01\uffff\x01\x6b\x02\x64\x01\x6f\x01\x69\x01\x61\x01\x74\x01"+
        "\x6c\x01\uffff\x01\x72\x01\x63\x03\uffff\x01\x69\x02\uffff\x01\x7a"+
        "\x01\x65\x01\uffff\x03\x7a\x01\x70\x01\uffff\x01\uffff\x01\x69\x02"+
        "\x7a\x01\x65\x01\x72\x01\x70\x01\x77\x01\x68\x01\x6c\x01\x64\x01"+
        "\x6c\x01\x70\x01\uffff\x01\x7a\x02\uffff\x01\x70\x01\x65\x01\uffff"+
        "\x01\x6e\x01\x73\x01\uffff\x01\x7a\x01\x64\x04\x7a\x01\x69\x01\x65"+
        "\x01\x73\x01\uffff\x01\x69\x01\x7a\x01\uffff\x01\x7a\x01\x74\x01"+
        "\uffff\x01\x69\x04\uffff\x01\x6e\x01\x7a\x01\x65\x01\x63\x01\uffff"+
        "\x01\uffff\x01\uffff\x01\x79\x01\x74\x01\x6e\x01\x61\x01\uffff\x01"+
        "\x7a\x01\x74\x01\uffff\x01\x6c\x01\x7a\x01\x61\x01\x74\x01\uffff"+
        "\x01\x75\x01\uffff\x01\x65\x01\uffff\x01\x74\x01\x65\x01\x72\x01"+
        "\uffff\x01\x7a\x01\x65\x01\x7a\x01\x65\x01\uffff\x01\uffff\x01\x7a"+
        "\x01\uffff\x01\x7a\x01\x0a\x01\uffff\x01\uffff\x02\uffff";
    const string DFA17_acceptS =
        "\x02\uffff\x01\x04\x01\x05\x01\x06\x01\x07\x01\x08\x01\uffff\x01"+
        "\x0a\x01\x0b\x01\x0c\x01\x0d\x01\x0e\x0d\uffff\x01\x2c\x03\uffff"+
        "\x01\x31\x01\uffff\x01\x35\x08\uffff\x01\x33\x01\x34\x01\x04\x01"+
        "\x05\x01\x06\x01\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x0c\x01"+
        "\x0d\x01\x0e\x03\uffff\x01\x2c\x0b\uffff\x01\x24\x01\x25\x01\x27"+
        "\x01\uffff\x01\x2e\x01\x26\x01\x29\x01\x28\x02\uffff\x01\x2d\x03"+
        "\uffff\x01\x30\x01\x31\x01\x32\x01\uffff\x01\x33\x08\uffff\x01\x0f"+
        "\x02\uffff\x01\x10\x01\x11\x01\x14\x01\uffff\x01\x12\x01\x13\x02"+
        "\uffff\x01\x1f\x05\uffff\x01\x2f\x0c\uffff\x01\x1c\x01\uffff\x01"+
        "\x22\x01\x23\x05\uffff\x01\x15\x09\uffff\x01\x1e\x05\uffff\x01\x16"+
        "\x01\uffff\x01\x1b\x01\x18\x01\x19\x01\x1a\x04\uffff\x01\x2b\x01"+
        "\uffff\x01\x01\x04\uffff\x01\x20\x07\uffff\x01\x21\x03\uffff\x01"+
        "\x03\x09\uffff\x01\x02\x01\uffff\x01\x1d\x02\uffff\x01\x2f\x01\uffff"+
        "\x01\x17\x01\x2a";
    const string DFA17_specialS =
        "\x01\x0d\x01\x09\x1b\uffff\x01\x07\x01\uffff\x01\x0b\x30\uffff"+
        "\x01\x08\x1f\uffff\x01\x00\x13\uffff\x01\x01\x0f\uffff\x01\x02\x0d"+
        "\uffff\x01\x03\x08\uffff\x01\x04\x06\uffff\x01\x05\x05\uffff\x01"+
        "\x06\x04\uffff\x01\x0a\x06\uffff\x01\x0c\x02\uffff}>";
    static readonly string[] DFA17_transitionS = {
            "\x09\x20\x02\x1e\x02\x20\x01\x1e\x12\x20\x01\x1e\x03\x20\x01"+
            "\x1f\x01\x1d\x02\x20\x01\x08\x01\x09\x01\x20\x01\x17\x01\x05"+
            "\x01\x15\x01\x1c\x01\x07\x0a\x1b\x01\x06\x01\x0c\x01\x20\x01"+
            "\x04\x03\x20\x1a\x1a\x01\x0a\x01\x01\x01\x0b\x01\x20\x01\x1a"+
            "\x01\x20\x01\x14\x01\x1a\x01\x0d\x01\x1a\x01\x0f\x03\x1a\x01"+
            "\x0e\x02\x1a\x01\x12\x01\x10\x01\x13\x01\x1a\x01\x11\x02\x1a"+
            "\x01\x19\x01\x18\x06\x1a\x01\x02\x01\x16\x01\x03\uff82\x20",
            "\x41\x2a\x1a\x29\x04\x2a\x01\x29\x01\x2a\x01\x29\x01\x21\x01"+
            "\x25\x01\x26\x01\x23\x01\x28\x07\x29\x01\x24\x01\x29\x01\x27"+
            "\x03\x29\x01\x22\x06\x29\uff85\x2a",
            "",
            "",
            "",
            "",
            "",
            "\x01\x30",
            "",
            "",
            "",
            "",
            "",
            "\x01\x38\x03\uffff\x01\x36\x01\uffff\x01\x37",
            "\x01\x3a",
            "\x01\x3d\x01\x3c\x0a\uffff\x01\x3b",
            "\x01\x3e",
            "\x01\x3f",
            "\x01\x40",
            "\x01\x41",
            "\x01\x44\x03\uffff\x01\x43\x01\uffff\x01\x42",
            "\x01\x45\x01\x49\x01\uffff\x0a\x48\x04\uffff\x01\x46\x3d\uffff"+
            "\x01\x47",
            "\x01\x4a",
            "\x01\x4b",
            "\x01\x4d",
            "\x01\x4e",
            "",
            "\x01\x49\x01\uffff\x0a\x48",
            "\x0a\x49",
            "\x09\x53\x01\x50\x01\x52\x02\x53\x01\x51\x12\x53\x01\x50\uffdf"+
            "\x53",
            "",
            "\x00\x55",
            "",
            "\x01\x56",
            "\x01\x58",
            "\x01\x59",
            "\x01\x5a",
            "\x01\x5c\x02\uffff\x01\x5b",
            "\x01\x5d",
            "\x01\x5e",
            "\x01\x5f",
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
            "\x01\x39\x0c\uffff\x01\x39\x01\uffff\x0a\x39\x07\uffff\x1a"+
            "\x39\x04\uffff\x01\x39\x01\uffff\x1a\x39",
            "\x01\x61",
            "\x01\x62",
            "",
            "\x01\x39\x0c\uffff\x01\x39\x01\uffff\x0a\x39\x07\uffff\x1a"+
            "\x39\x04\uffff\x01\x39\x01\uffff\x1a\x39",
            "\x01\x39\x0c\uffff\x01\x39\x01\uffff\x0a\x39\x07\uffff\x1a"+
            "\x39\x04\uffff\x01\x39\x01\uffff\x1a\x39",
            "\x01\x39\x0c\uffff\x01\x39\x01\uffff\x0a\x39\x07\uffff\x1a"+
            "\x39\x04\uffff\x01\x39\x01\uffff\x1a\x39",
            "\x01\x66",
            "\x01\x39\x0c\uffff\x01\x39\x01\uffff\x0a\x39\x07\uffff\x1a"+
            "\x39\x04\uffff\x01\x39\x01\uffff\x1a\x39",
            "\x01\x39\x0c\uffff\x01\x39\x01\uffff\x0a\x39\x07\uffff\x1a"+
            "\x39\x04\uffff\x01\x39\x01\uffff\x1a\x39",
            "\x01\x69",
            "\x01\x6a",
            "\x01\x39\x0c\uffff\x01\x39\x01\uffff\x0a\x39\x07\uffff\x1a"+
            "\x39\x04\uffff\x01\x39\x01\uffff\x1a\x39",
            "\x01\x6c",
            "\x01\x6d",
            "",
            "",
            "",
            "\x01\x49\x01\uffff\x0a\x48",
            "",
            "",
            "",
            "",
            "\x01\x6e",
            "\x01\x6f",
            "",
            "\x21\x53\x01\x70\uffde\x53",
            "\x01\x53\x16\uffff\x01\x71",
            "\x01\x71",
            "",
            "",
            "",
            "\x01\x72",
            "",
            "\x01\x73",
            "\x01\x74",
            "\x01\x75",
            "\x01\x76",
            "\x01\x77",
            "\x01\x78",
            "\x01\x79",
            "\x01\x7a",
            "",
            "\x01\x7b",
            "\x01\x7c",
            "",
            "",
            "",
            "\x01\x7d",
            "",
            "",
            "\x01\x39\x0c\uffff\x01\x39\x01\uffff\x0a\x39\x07\uffff\x1a"+
            "\x39\x04\uffff\x01\x39\x01\uffff\x1a\x39",
            "\x01\x7f",
            "",
            "\x01\x39\x0c\uffff\x01\x39\x01\uffff\x0a\x39\x07\uffff\x1a"+
            "\x39\x04\uffff\x01\x39\x01\uffff\x1a\x39",
            "\x01\x39\x0c\uffff\x01\x39\x01\uffff\x0a\x39\x07\uffff\x1a"+
            "\x39\x04\uffff\x01\x39\x01\uffff\x1a\x39",
            "\x01\u0082",
            "\x01\u0083",
            "\x54\x53\x01\u0084\uffab\x53",
            "",
            "\x01\u0085",
            "\x01\u0086",
            "\x01\x57\x0c\uffff\x01\x57\x01\uffff\x0a\x57\x07\uffff\x1a"+
            "\x57\x04\uffff\x01\x57\x01\uffff\x1a\x57",
            "\x01\u0088",
            "\x01\u0089",
            "\x01\u008a",
            "\x01\u008b",
            "\x01\u008c",
            "\x01\u008d",
            "\x01\u008e",
            "\x01\u008f",
            "\x01\u0090",
            "",
            "\x01\x39\x0c\uffff\x01\x39\x01\uffff\x0a\x39\x07\uffff\x1a"+
            "\x39\x04\uffff\x01\x39\x01\uffff\x1a\x39",
            "",
            "",
            "\x01\u0092",
            "\x01\u0093",
            "\x49\x53\x01\u0094\uffb6\x53",
            "\x01\u0095",
            "\x01\u0096",
            "",
            "\x01\x57\x0c\uffff\x01\x57\x01\uffff\x0a\x57\x07\uffff\x1a"+
            "\x57\x04\uffff\x01\x57\x01\uffff\x1a\x57",
            "\x01\u0098",
            "\x01\x57\x0c\uffff\x01\x57\x01\uffff\x0a\x57\x07\uffff\x1a"+
            "\x57\x04\uffff\x01\x57\x01\uffff\x1a\x57",
            "\x01\x57\x0c\uffff\x01\x57\x01\uffff\x0a\x57\x07\uffff\x1a"+
            "\x57\x04\uffff\x01\x57\x01\uffff\x1a\x57",
            "\x01\x57\x0c\uffff\x01\x57\x01\uffff\x0a\x57\x07\uffff\x1a"+
            "\x57\x04\uffff\x01\x57\x01\uffff\x1a\x57",
            "\x01\x57\x0c\uffff\x01\x57\x01\uffff\x0a\x57\x07\uffff\x1a"+
            "\x57\x04\uffff\x01\x57\x01\uffff\x1a\x57",
            "\x01\u009d",
            "\x01\u009e",
            "\x01\u009f",
            "",
            "\x01\u00a0",
            "\x01\x39\x0c\uffff\x01\x39\x01\uffff\x0a\x39\x07\uffff\x1a"+
            "\x39\x04\uffff\x01\x39\x01\uffff\x1a\x39",
            "\x4b\x53\x01\u00a2\uffb4\x53",
            "\x01\x57\x0c\uffff\x01\x57\x01\uffff\x0a\x57\x07\uffff\x1a"+
            "\x57\x04\uffff\x01\x57\x01\uffff\x1a\x57",
            "\x01\u00a5\x0e\uffff\x01\u00a4",
            "",
            "\x01\u00a6",
            "",
            "",
            "",
            "",
            "\x01\u00a7",
            "\x01\x39\x0c\uffff\x01\x39\x01\uffff\x0a\x39\x07\uffff\x1a"+
            "\x39\x04\uffff\x01\x39\x01\uffff\x1a\x39",
            "\x01\u00a9",
            "\x01\u00aa",
            "",
            "\x5a\x53\x01\u00ab\uffa5\x53",
            "",
            "\x01\u00ac",
            "\x01\u00ad",
            "\x01\u00ae",
            "\x01\u00af",
            "",
            "\x01\x39\x0c\uffff\x01\x39\x01\uffff\x0a\x39\x07\uffff\x1a"+
            "\x39\x04\uffff\x01\x39\x01\uffff\x1a\x39",
            "\x01\u00b1",
            "\x45\x53\x01\u00b2\uffba\x53",
            "\x01\u00b3",
            "\x01\x57\x0c\uffff\x01\x57\x01\uffff\x0a\x57\x07\uffff\x1a"+
            "\x57\x04\uffff\x01\x57\x01\uffff\x1a\x57",
            "\x01\u00b5",
            "\x01\u00b6",
            "",
            "\x01\u00b7",
            "\x44\x53\x01\u00b8\uffbb\x53",
            "\x01\u00b9",
            "",
            "\x01\u00ba",
            "\x01\u00bb",
            "\x01\u00bc",
            "\x54\x53\x01\u00bd\uffab\x53",
            "\x01\x57\x0c\uffff\x01\x57\x01\uffff\x0a\x57\x07\uffff\x1a"+
            "\x57\x04\uffff\x01\x57\x01\uffff\x1a\x57",
            "\x01\u00bf",
            "\x01\x39\x0c\uffff\x01\x39\x01\uffff\x0a\x39\x07\uffff\x1a"+
            "\x39\x04\uffff\x01\x39\x01\uffff\x1a\x39",
            "\x01\u00c1",
            "\x0a\u00c4\x01\u00c3\x02\u00c4\x01\u00c2\ufff2\u00c4",
            "",
            "\x01\x57\x0c\uffff\x01\x57\x01\uffff\x0a\x57\x07\uffff\x1a"+
            "\x57\x04\uffff\x01\x57\x01\uffff\x1a\x57",
            "",
            "\x01\x39\x0c\uffff\x01\x39\x01\uffff\x0a\x39\x07\uffff\x1a"+
            "\x39\x04\uffff\x01\x39\x01\uffff\x1a\x39",
            "\x01\u00c3",
            "",
            "\x0a\u00c4\x01\u00c3\x02\u00c4\x01\u00c2\ufff2\u00c4",
            "",
            ""
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
            get { return "1:1: Tokens : ( T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | T__77 | T__78 | ID | INT | FLOAT_WO_EXP | TIKZEDT_CMD_COMMENT | COMMENT | WS | MATHSTRING | COMMAND | ESC_SEQ | SOMETHING );"; }
        }

    }


    protected internal int DFA17_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            IIntStream input = _input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA17_112 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_112 == 'T') ) { s = 132; }

                   	else if ( ((LA17_112 >= '\u0000' && LA17_112 <= 'S') || (LA17_112 >= 'U' && LA17_112 <= '\uFFFF')) ) { s = 83; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA17_132 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_132 == 'I') ) { s = 148; }

                   	else if ( ((LA17_132 >= '\u0000' && LA17_132 <= 'H') || (LA17_132 >= 'J' && LA17_132 <= '\uFFFF')) ) { s = 83; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA17_148 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_148 == 'K') ) { s = 162; }

                   	else if ( ((LA17_148 >= '\u0000' && LA17_148 <= 'J') || (LA17_148 >= 'L' && LA17_148 <= '\uFFFF')) ) { s = 83; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA17_162 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_162 == 'Z') ) { s = 171; }

                   	else if ( ((LA17_162 >= '\u0000' && LA17_162 <= 'Y') || (LA17_162 >= '[' && LA17_162 <= '\uFFFF')) ) { s = 83; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA17_171 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_171 == 'E') ) { s = 178; }

                   	else if ( ((LA17_171 >= '\u0000' && LA17_171 <= 'D') || (LA17_171 >= 'F' && LA17_171 <= '\uFFFF')) ) { s = 83; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA17_178 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_178 == 'D') ) { s = 184; }

                   	else if ( ((LA17_178 >= '\u0000' && LA17_178 <= 'C') || (LA17_178 >= 'E' && LA17_178 <= '\uFFFF')) ) { s = 83; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA17_184 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_184 == 'T') ) { s = 189; }

                   	else if ( ((LA17_184 >= '\u0000' && LA17_184 <= 'S') || (LA17_184 >= 'U' && LA17_184 <= '\uFFFF')) ) { s = 83; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA17_29 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_29 == '\t' || LA17_29 == ' ') ) { s = 80; }

                   	else if ( (LA17_29 == '\r') ) { s = 81; }

                   	else if ( (LA17_29 == '\n') ) { s = 82; }

                   	else if ( ((LA17_29 >= '\u0000' && LA17_29 <= '\b') || (LA17_29 >= '\u000B' && LA17_29 <= '\f') || (LA17_29 >= '\u000E' && LA17_29 <= '\u001F') || (LA17_29 >= '!' && LA17_29 <= '\uFFFF')) ) { s = 83; }

                   	else s = 32;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA17_80 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_80 == '!') ) { s = 112; }

                   	else if ( ((LA17_80 >= '\u0000' && LA17_80 <= ' ') || (LA17_80 >= '\"' && LA17_80 <= '\uFFFF')) ) { s = 83; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA17_1 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_1 == 'b') ) { s = 33; }

                   	else if ( (LA17_1 == 't') ) { s = 34; }

                   	else if ( (LA17_1 == 'e') ) { s = 35; }

                   	else if ( (LA17_1 == 'n') ) { s = 36; }

                   	else if ( (LA17_1 == 'c') ) { s = 37; }

                   	else if ( (LA17_1 == 'd') ) { s = 38; }

                   	else if ( (LA17_1 == 'p') ) { s = 39; }

                   	else if ( (LA17_1 == 'f') ) { s = 40; }

                   	else if ( ((LA17_1 >= 'A' && LA17_1 <= 'Z') || LA17_1 == '_' || LA17_1 == 'a' || (LA17_1 >= 'g' && LA17_1 <= 'm') || LA17_1 == 'o' || (LA17_1 >= 'q' && LA17_1 <= 's') || (LA17_1 >= 'u' && LA17_1 <= 'z')) ) { s = 41; }

                   	else if ( ((LA17_1 >= '\u0000' && LA17_1 <= '@') || (LA17_1 >= '[' && LA17_1 <= '^') || LA17_1 == '`' || (LA17_1 >= '{' && LA17_1 <= '\uFFFF')) ) { s = 42; }

                   	else s = 32;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA17_189 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_189 == '\r') ) { s = 194; }

                   	else if ( (LA17_189 == '\n') ) { s = 195; }

                   	else if ( ((LA17_189 >= '\u0000' && LA17_189 <= '\t') || (LA17_189 >= '\u000B' && LA17_189 <= '\f') || (LA17_189 >= '\u000E' && LA17_189 <= '\uFFFF')) ) { s = 196; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA17_31 = input.LA(1);

                   	s = -1;
                   	if ( ((LA17_31 >= '\u0000' && LA17_31 <= '\uFFFF')) ) { s = 85; }

                   	else s = 32;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA17_196 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_196 == '\r') ) { s = 194; }

                   	else if ( (LA17_196 == '\n') ) { s = 195; }

                   	else if ( ((LA17_196 >= '\u0000' && LA17_196 <= '\t') || (LA17_196 >= '\u000B' && LA17_196 <= '\f') || (LA17_196 >= '\u000E' && LA17_196 <= '\uFFFF')) ) { s = 196; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 13 : 
                   	int LA17_0 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_0 == '\\') ) { s = 1; }

                   	else if ( (LA17_0 == '{') ) { s = 2; }

                   	else if ( (LA17_0 == '}') ) { s = 3; }

                   	else if ( (LA17_0 == '=') ) { s = 4; }

                   	else if ( (LA17_0 == ',') ) { s = 5; }

                   	else if ( (LA17_0 == ':') ) { s = 6; }

                   	else if ( (LA17_0 == '/') ) { s = 7; }

                   	else if ( (LA17_0 == '(') ) { s = 8; }

                   	else if ( (LA17_0 == ')') ) { s = 9; }

                   	else if ( (LA17_0 == '[') ) { s = 10; }

                   	else if ( (LA17_0 == ']') ) { s = 11; }

                   	else if ( (LA17_0 == ';') ) { s = 12; }

                   	else if ( (LA17_0 == 'c') ) { s = 13; }

                   	else if ( (LA17_0 == 'i') ) { s = 14; }

                   	else if ( (LA17_0 == 'e') ) { s = 15; }

                   	else if ( (LA17_0 == 'm') ) { s = 16; }

                   	else if ( (LA17_0 == 'p') ) { s = 17; }

                   	else if ( (LA17_0 == 'l') ) { s = 18; }

                   	else if ( (LA17_0 == 'n') ) { s = 19; }

                   	else if ( (LA17_0 == 'a') ) { s = 20; }

                   	else if ( (LA17_0 == '-') ) { s = 21; }

                   	else if ( (LA17_0 == '|') ) { s = 22; }

                   	else if ( (LA17_0 == '+') ) { s = 23; }

                   	else if ( (LA17_0 == 't') ) { s = 24; }

                   	else if ( (LA17_0 == 's') ) { s = 25; }

                   	else if ( ((LA17_0 >= 'A' && LA17_0 <= 'Z') || LA17_0 == '_' || LA17_0 == 'b' || LA17_0 == 'd' || (LA17_0 >= 'f' && LA17_0 <= 'h') || (LA17_0 >= 'j' && LA17_0 <= 'k') || LA17_0 == 'o' || (LA17_0 >= 'q' && LA17_0 <= 'r') || (LA17_0 >= 'u' && LA17_0 <= 'z')) ) { s = 26; }

                   	else if ( ((LA17_0 >= '0' && LA17_0 <= '9')) ) { s = 27; }

                   	else if ( (LA17_0 == '.') ) { s = 28; }

                   	else if ( (LA17_0 == '%') ) { s = 29; }

                   	else if ( ((LA17_0 >= '\t' && LA17_0 <= '\n') || LA17_0 == '\r' || LA17_0 == ' ') ) { s = 30; }

                   	else if ( (LA17_0 == '$') ) { s = 31; }

                   	else if ( ((LA17_0 >= '\u0000' && LA17_0 <= '\b') || (LA17_0 >= '\u000B' && LA17_0 <= '\f') || (LA17_0 >= '\u000E' && LA17_0 <= '\u001F') || (LA17_0 >= '!' && LA17_0 <= '#') || (LA17_0 >= '&' && LA17_0 <= '\'') || LA17_0 == '*' || LA17_0 == '<' || (LA17_0 >= '>' && LA17_0 <= '@') || LA17_0 == '^' || LA17_0 == '`' || (LA17_0 >= '~' && LA17_0 <= '\uFFFF')) ) { s = 32; }

                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae17 =
            new NoViableAltException(dfa.Description, 17, _s, input);
        dfa.Error(nvae17);
        throw nvae17;
    }
 
    
}
