// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g 2010-12-18 22:37:18

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
    public const int EXPONENT = 48;
    public const int T__64 = 64;
    public const int T__65 = 65;
    public const int IM_STARTTAG = 31;
    public const int TIKZEDT_CMD_COMMENT = 42;
    public const int T__62 = 62;
    public const int T__63 = 63;
    public const int IM_PATH = 23;
    public const int RBR = 16;
    public const int IM_ID = 37;
    public const int SOMETHING = 52;
    public const int ID = 45;
    public const int T__61 = 61;
    public const int EOF = -1;
    public const int T__60 = 60;
    public const int MATHSTRING = 50;
    public const int LBR = 15;
    public const int COMMAND = 51;
    public const int IM_ENDTAG = 32;
    public const int IM_USETIKZLIB = 39;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int IM_DOCUMENT = 29;
    public const int T__58 = 58;
    public const int RBRR = 18;
    public const int ESC_SEQ = 49;
    public const int IM_STRING = 40;
    public const int T__53 = 53;
    public const int LPAR = 13;
    public const int T__54 = 54;
    public const int FILL = 12;
    public const int PATH = 11;
    public const int IM_TIKZSET = 38;
    public const int T__59 = 59;
    public const int BEGIN = 4;
    public const int IM_OPTION_KV = 36;
    public const int COMMENT = 47;
    public const int IM_TIKZEDT_CMD = 34;
    public const int IM_OPTIONS = 33;
    public const int NODE = 9;
    public const int IM_OPTION_STYLE = 35;
    public const int TIKZSET = 8;
    public const int TIKZSTYLE = 7;
    public const int IM_COORD = 25;
    public const int IM_PICTURE = 28;
    public const int LBRR = 17;
    public const int INT = 43;
    public const int IM_NODE = 24;
    public const int USETIKZLIB = 6;
    public const int IM_STYLE = 41;
    public const int COLON = 22;
    public const int IM_NUMBERUNIT = 27;
    public const int IM_SCOPE = 30;
    public const int WS = 46;
    public const int KOMMA = 19;
    public const int EQU = 20;
    public const int RPAR = 14;
    public const int SEMIC = 21;
    public const int END = 5;
    public const int IM_NODENAME = 26;
    public const int DRAW = 10;
    public const int FLOAT_WO_EXP = 44;

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
    	get { return "C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g";} 
    }

    // $ANTLR start "BEGIN"
    public void mBEGIN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BEGIN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:7:7: ( '\\\\begin' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:7:9: '\\\\begin'
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
    // $ANTLR end "BEGIN"

    // $ANTLR start "END"
    public void mEND() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = END;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:8:5: ( '\\\\end' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:8:7: '\\\\end'
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
    // $ANTLR end "END"

    // $ANTLR start "USETIKZLIB"
    public void mUSETIKZLIB() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = USETIKZLIB;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:9:12: ( '\\\\usetikzlibrary' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:9:14: '\\\\usetikzlibrary'
            {
            	Match("\\usetikzlibrary"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "USETIKZLIB"

    // $ANTLR start "TIKZSTYLE"
    public void mTIKZSTYLE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TIKZSTYLE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:10:11: ( '\\\\tikzstyle' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:10:13: '\\\\tikzstyle'
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
    // $ANTLR end "TIKZSTYLE"

    // $ANTLR start "TIKZSET"
    public void mTIKZSET() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TIKZSET;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:11:9: ( '\\\\tikzset' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:11:11: '\\\\tikzset'
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
    // $ANTLR end "TIKZSET"

    // $ANTLR start "NODE"
    public void mNODE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NODE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:12:6: ( '\\\\node' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:12:8: '\\\\node'
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
    // $ANTLR end "NODE"

    // $ANTLR start "DRAW"
    public void mDRAW() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DRAW;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:13:6: ( '\\\\draw' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:13:8: '\\\\draw'
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
    // $ANTLR end "DRAW"

    // $ANTLR start "PATH"
    public void mPATH() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PATH;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:14:6: ( '\\\\path' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:14:8: '\\\\path'
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
    // $ANTLR end "PATH"

    // $ANTLR start "FILL"
    public void mFILL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FILL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:15:6: ( '\\\\fill' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:15:8: '\\\\fill'
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
    // $ANTLR end "FILL"

    // $ANTLR start "LPAR"
    public void mLPAR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LPAR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:16:6: ( '(' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:16:8: '('
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
    // $ANTLR end "LPAR"

    // $ANTLR start "RPAR"
    public void mRPAR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RPAR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:17:6: ( ')' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:17:8: ')'
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
    // $ANTLR end "RPAR"

    // $ANTLR start "LBR"
    public void mLBR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LBR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:18:5: ( '[' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:18:7: '['
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
    // $ANTLR end "LBR"

    // $ANTLR start "RBR"
    public void mRBR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RBR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:19:5: ( ']' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:19:7: ']'
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
    // $ANTLR end "RBR"

    // $ANTLR start "LBRR"
    public void mLBRR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LBRR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:20:6: ( '{' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:20:8: '{'
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
    // $ANTLR end "LBRR"

    // $ANTLR start "RBRR"
    public void mRBRR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RBRR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:21:6: ( '}' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:21:8: '}'
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
    // $ANTLR end "RBRR"

    // $ANTLR start "KOMMA"
    public void mKOMMA() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = KOMMA;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:22:7: ( ',' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:22:9: ','
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
    // $ANTLR end "KOMMA"

    // $ANTLR start "EQU"
    public void mEQU() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = EQU;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:23:5: ( '=' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:23:7: '='
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
    // $ANTLR end "EQU"

    // $ANTLR start "SEMIC"
    public void mSEMIC() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SEMIC;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:24:7: ( ';' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:24:9: ';'
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
    // $ANTLR end "SEMIC"

    // $ANTLR start "COLON"
    public void mCOLON() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COLON;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:25:7: ( ':' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:25:9: ':'
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
    // $ANTLR end "COLON"

    // $ANTLR start "T__53"
    public void mT__53() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__53;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:26:7: ( '~' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:26:9: '~'
            {
            	Match('~'); 

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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:27:7: ( '/.style' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:27:9: '/.style'
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
    // $ANTLR end "T__54"

    // $ANTLR start "T__55"
    public void mT__55() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__55;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:28:7: ( 'cm' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:28:9: 'cm'
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
    // $ANTLR end "T__55"

    // $ANTLR start "T__56"
    public void mT__56() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__56;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:29:7: ( 'in' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:29:9: 'in'
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
    // $ANTLR end "T__56"

    // $ANTLR start "T__57"
    public void mT__57() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__57;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:30:7: ( 'ex' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:30:9: 'ex'
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
    // $ANTLR end "T__57"

    // $ANTLR start "T__58"
    public void mT__58() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__58;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:31:7: ( 'mm' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:31:9: 'mm'
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
    // $ANTLR end "T__58"

    // $ANTLR start "T__59"
    public void mT__59() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__59;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:32:7: ( 'pt' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:32:9: 'pt'
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
    // $ANTLR end "T__59"

    // $ANTLR start "T__60"
    public void mT__60() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__60;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:33:7: ( 'em' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:33:9: 'em'
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
    // $ANTLR end "T__60"

    // $ANTLR start "T__61"
    public void mT__61() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__61;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:34:7: ( 'at' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:34:9: 'at'
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
    // $ANTLR end "T__61"

    // $ANTLR start "T__62"
    public void mT__62() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__62;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:35:7: ( '--' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:35:9: '--'
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
    // $ANTLR end "T__62"

    // $ANTLR start "T__63"
    public void mT__63() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__63;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:36:7: ( '->' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:36:9: '->'
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
    // $ANTLR end "T__63"

    // $ANTLR start "T__64"
    public void mT__64() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__64;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:37:7: ( '|-' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:37:9: '|-'
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
    // $ANTLR end "T__64"

    // $ANTLR start "T__65"
    public void mT__65() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__65;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:38:7: ( '-|' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:38:9: '-|'
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
    // $ANTLR end "T__65"

    // $ANTLR start "T__66"
    public void mT__66() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__66;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:39:7: ( '+' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:39:9: '+'
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
    // $ANTLR end "T__66"

    // $ANTLR start "T__67"
    public void mT__67() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__67;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:40:7: ( '++' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:40:9: '++'
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
    // $ANTLR end "T__67"

    // $ANTLR start "T__68"
    public void mT__68() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__68;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:41:7: ( 'tikzpicture' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:41:9: 'tikzpicture'
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
    // $ANTLR end "T__68"

    // $ANTLR start "T__69"
    public void mT__69() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__69;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:42:7: ( 'scope' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:42:9: 'scope'
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
    // $ANTLR end "T__69"

    // $ANTLR start "ID"
    public void mID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:350:5: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' | '!' )* )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:350:7: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' | '!' )*
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

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:350:31: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' | '!' )*
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
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:353:5: ( ( '-' )? ( '0' .. '9' )+ )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:353:7: ( '-' )? ( '0' .. '9' )+
            {
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:353:7: ( '-' )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == '-') )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:353:7: '-'
            	        {
            	        	Match('-'); 

            	        }
            	        break;

            	}

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:353:12: ( '0' .. '9' )+
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
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:353:12: '0' .. '9'
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:365:5: ( ( '-' )? ( '0' .. '9' )+ '.' ( '0' .. '9' )* | ( '-' )? '.' ( '0' .. '9' )+ )
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
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:365:9: ( '-' )? ( '0' .. '9' )+ '.' ( '0' .. '9' )*
                    {
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:365:9: ( '-' )?
                    	int alt4 = 2;
                    	int LA4_0 = input.LA(1);

                    	if ( (LA4_0 == '-') )
                    	{
                    	    alt4 = 1;
                    	}
                    	switch (alt4) 
                    	{
                    	    case 1 :
                    	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:365:9: '-'
                    	        {
                    	        	Match('-'); 

                    	        }
                    	        break;

                    	}

                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:365:14: ( '0' .. '9' )+
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
                    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:365:15: '0' .. '9'
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
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:365:30: ( '0' .. '9' )*
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
                    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:365:31: '0' .. '9'
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
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:366:9: ( '-' )? '.' ( '0' .. '9' )+
                    {
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:366:9: ( '-' )?
                    	int alt7 = 2;
                    	int LA7_0 = input.LA(1);

                    	if ( (LA7_0 == '-') )
                    	{
                    	    alt7 = 1;
                    	}
                    	switch (alt7) 
                    	{
                    	    case 1 :
                    	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:366:9: '-'
                    	        {
                    	        	Match('-'); 

                    	        }
                    	        break;

                    	}

                    	Match('.'); 
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:366:18: ( '0' .. '9' )+
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
                    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:366:19: '0' .. '9'
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:371:5: ( '%' WS '!TIKZEDT' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:371:9: '%' WS '!TIKZEDT' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
            {
            	Match('%'); 
            	mWS(); 
            	Match("!TIKZEDT"); 

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:371:29: (~ ( '\\n' | '\\r' ) )*
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
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:371:29: ~ ( '\\n' | '\\r' )
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

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:371:43: ( '\\r' )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == '\r') )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:371:43: '\\r'
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:377:5: ( '%' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:377:9: '%' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
            {
            	Match('%'); 
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:377:13: (~ ( '\\n' | '\\r' ) )*
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
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:377:13: ~ ( '\\n' | '\\r' )
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

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:377:27: ( '\\r' )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == '\r') )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:377:27: '\\r'
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:380:5: ( ( ' ' | '\\t' | '\\r' | '\\n' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:380:9: ( ' ' | '\\t' | '\\r' | '\\n' )
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:387:19: ( ( 'e' | 'E' ) ( '+' | '-' )? ( '0' .. '9' )+ )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:387:21: ( 'e' | 'E' ) ( '+' | '-' )? ( '0' .. '9' )+
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

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:387:31: ( '+' | '-' )?
            	int alt14 = 2;
            	int LA14_0 = input.LA(1);

            	if ( (LA14_0 == '+' || LA14_0 == '-') )
            	{
            	    alt14 = 1;
            	}
            	switch (alt14) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:
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

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:387:42: ( '0' .. '9' )+
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
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:387:43: '0' .. '9'
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:394:2: ( '$' ( ESC_SEQ | ~ ( '\\\\' | '$' ) )* '$' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:394:4: '$' ( ESC_SEQ | ~ ( '\\\\' | '$' ) )* '$'
            {
            	Match('$'); 
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:394:8: ( ESC_SEQ | ~ ( '\\\\' | '$' ) )*
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
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:394:10: ESC_SEQ
            			    {
            			    	mESC_SEQ(); 

            			    }
            			    break;
            			case 2 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:394:20: ~ ( '\\\\' | '$' )
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:405:2: ( '\\\\' ID )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:405:4: '\\\\' ID
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:410:5: ( '\\\\' . )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:410:9: '\\\\' .
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:416:2: ( . )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:416:4: .
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
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:8: ( BEGIN | END | USETIKZLIB | TIKZSTYLE | TIKZSET | NODE | DRAW | PATH | FILL | LPAR | RPAR | LBR | RBR | LBRR | RBRR | KOMMA | EQU | SEMIC | COLON | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | ID | INT | FLOAT_WO_EXP | TIKZEDT_CMD_COMMENT | COMMENT | WS | MATHSTRING | COMMAND | ESC_SEQ | SOMETHING )
        int alt17 = 46;
        alt17 = dfa17.Predict(input);
        switch (alt17) 
        {
            case 1 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:10: BEGIN
                {
                	mBEGIN(); 

                }
                break;
            case 2 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:16: END
                {
                	mEND(); 

                }
                break;
            case 3 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:20: USETIKZLIB
                {
                	mUSETIKZLIB(); 

                }
                break;
            case 4 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:31: TIKZSTYLE
                {
                	mTIKZSTYLE(); 

                }
                break;
            case 5 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:41: TIKZSET
                {
                	mTIKZSET(); 

                }
                break;
            case 6 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:49: NODE
                {
                	mNODE(); 

                }
                break;
            case 7 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:54: DRAW
                {
                	mDRAW(); 

                }
                break;
            case 8 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:59: PATH
                {
                	mPATH(); 

                }
                break;
            case 9 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:64: FILL
                {
                	mFILL(); 

                }
                break;
            case 10 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:69: LPAR
                {
                	mLPAR(); 

                }
                break;
            case 11 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:74: RPAR
                {
                	mRPAR(); 

                }
                break;
            case 12 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:79: LBR
                {
                	mLBR(); 

                }
                break;
            case 13 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:83: RBR
                {
                	mRBR(); 

                }
                break;
            case 14 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:87: LBRR
                {
                	mLBRR(); 

                }
                break;
            case 15 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:92: RBRR
                {
                	mRBRR(); 

                }
                break;
            case 16 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:97: KOMMA
                {
                	mKOMMA(); 

                }
                break;
            case 17 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:103: EQU
                {
                	mEQU(); 

                }
                break;
            case 18 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:107: SEMIC
                {
                	mSEMIC(); 

                }
                break;
            case 19 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:113: COLON
                {
                	mCOLON(); 

                }
                break;
            case 20 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:119: T__53
                {
                	mT__53(); 

                }
                break;
            case 21 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:125: T__54
                {
                	mT__54(); 

                }
                break;
            case 22 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:131: T__55
                {
                	mT__55(); 

                }
                break;
            case 23 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:137: T__56
                {
                	mT__56(); 

                }
                break;
            case 24 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:143: T__57
                {
                	mT__57(); 

                }
                break;
            case 25 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:149: T__58
                {
                	mT__58(); 

                }
                break;
            case 26 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:155: T__59
                {
                	mT__59(); 

                }
                break;
            case 27 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:161: T__60
                {
                	mT__60(); 

                }
                break;
            case 28 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:167: T__61
                {
                	mT__61(); 

                }
                break;
            case 29 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:173: T__62
                {
                	mT__62(); 

                }
                break;
            case 30 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:179: T__63
                {
                	mT__63(); 

                }
                break;
            case 31 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:185: T__64
                {
                	mT__64(); 

                }
                break;
            case 32 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:191: T__65
                {
                	mT__65(); 

                }
                break;
            case 33 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:197: T__66
                {
                	mT__66(); 

                }
                break;
            case 34 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:203: T__67
                {
                	mT__67(); 

                }
                break;
            case 35 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:209: T__68
                {
                	mT__68(); 

                }
                break;
            case 36 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:215: T__69
                {
                	mT__69(); 

                }
                break;
            case 37 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:221: ID
                {
                	mID(); 

                }
                break;
            case 38 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:224: INT
                {
                	mINT(); 

                }
                break;
            case 39 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:228: FLOAT_WO_EXP
                {
                	mFLOAT_WO_EXP(); 

                }
                break;
            case 40 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:241: TIKZEDT_CMD_COMMENT
                {
                	mTIKZEDT_CMD_COMMENT(); 

                }
                break;
            case 41 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:261: COMMENT
                {
                	mCOMMENT(); 

                }
                break;
            case 42 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:269: WS
                {
                	mWS(); 

                }
                break;
            case 43 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:272: MATHSTRING
                {
                	mMATHSTRING(); 

                }
                break;
            case 44 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:283: COMMAND
                {
                	mCOMMAND(); 

                }
                break;
            case 45 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:291: ESC_SEQ
                {
                	mESC_SEQ(); 

                }
                break;
            case 46 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:299: SOMETHING
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
        "\x01\uffff\x01\x1f\x0b\uffff\x01\x1f\x06\x37\x02\x1f\x01\x45\x02"+
        "\x37\x01\uffff\x01\x48\x02\x1f\x01\uffff\x01\x1f\x01\uffff\x08\x50"+
        "\x0e\uffff\x01\x58\x01\uffff\x01\x59\x01\x5a\x01\x5b\x01\x5c\x01"+
        "\x5d\x01\x5e\x03\uffff\x01\x48\x04\uffff\x02\x37\x04\uffff\x01\x4b"+
        "\x02\uffff\x01\x50\x01\uffff\x07\x50\x07\uffff\x02\x37\x02\uffff"+
        "\x01\x50\x01\x6f\x06\x50\x02\x37\x01\uffff\x01\x50\x01\uffff\x02"+
        "\x50\x01\x7c\x01\x7d\x01\x7e\x01\x7f\x01\x37\x01\u0081\x01\uffff"+
        "\x01\u0083\x02\x50\x04\uffff\x01\x37\x03\uffff\x03\x50\x01\x37\x01"+
        "\uffff\x02\x50\x01\u0090\x01\x37\x01\uffff\x02\x50\x01\uffff\x01"+
        "\x37\x01\uffff\x01\x50\x01\u0098\x01\x37\x01\uffff\x01\x50\x01\uffff"+
        "\x01\u009e\x03\uffff\x01\x50\x01\uffff\x02\x50\x01\u00a2\x01\uffff";
    const string DFA17_eofS =
        "\u00a3\uffff";
    const string DFA17_minS =
        "\x02\x00\x0b\uffff\x01\x2e\x01\x6d\x01\x6e\x02\x6d\x02\x74\x02"+
        "\x2d\x01\x2b\x01\x69\x01\x63\x01\uffff\x01\x2e\x01\x30\x01\x00\x01"+
        "\uffff\x01\x00\x01\uffff\x01\x65\x01\x6e\x01\x73\x01\x69\x01\x6f"+
        "\x01\x72\x01\x61\x01\x69\x0e\uffff\x01\x21\x01\uffff\x06\x21\x03"+
        "\uffff\x01\x2e\x04\uffff\x01\x6b\x01\x6f\x01\uffff\x01\x00\x01\x0a"+
        "\x01\uffff\x01\x21\x02\uffff\x01\x67\x01\uffff\x01\x64\x01\x65\x01"+
        "\x6b\x01\x64\x01\x61\x01\x74\x01\x6c\x07\uffff\x01\x7a\x01\x70\x01"+
        "\x00\x01\uffff\x01\x69\x01\x21\x01\x74\x01\x7a\x01\x65\x01\x77\x01"+
        "\x68\x01\x6c\x01\x70\x01\x65\x01\x00\x01\x6e\x01\uffff\x01\x69\x01"+
        "\x73\x04\x21\x01\x69\x01\x21\x01\x00\x01\x21\x01\x6b\x01\x65\x04"+
        "\uffff\x01\x63\x01\uffff\x01\x00\x01\uffff\x01\x7a\x01\x79\x02\x74"+
        "\x01\x00\x02\x6c\x01\x21\x01\x75\x01\x00\x01\x69\x01\x65\x01\uffff"+
        "\x01\x72\x01\x00\x01\x62\x01\x21\x01\x65\x01\x00\x01\x72\x01\uffff"+
        "\x01\x21\x01\x0a\x01\uffff\x01\x00\x01\x61\x01\uffff\x01\x72\x01"+
        "\x79\x01\x21\x01\uffff";
    const string DFA17_maxS =
        "\x02\uffff\x0b\uffff\x01\x2e\x01\x6d\x01\x6e\x01\x78\x01\x6d\x02"+
        "\x74\x01\x7c\x01\x2d\x01\x2b\x01\x69\x01\x63\x01\uffff\x02\x39\x01"+
        "\uffff\x01\uffff\x01\uffff\x01\uffff\x01\x65\x01\x6e\x01\x73\x01"+
        "\x69\x01\x6f\x01\x72\x01\x61\x01\x69\x0e\uffff\x01\x7a\x01\uffff"+
        "\x06\x7a\x03\uffff\x01\x39\x04\uffff\x01\x6b\x01\x6f\x01\uffff\x01"+
        "\uffff\x01\x21\x01\uffff\x01\x21\x02\uffff\x01\x67\x01\uffff\x01"+
        "\x64\x01\x65\x01\x6b\x01\x64\x01\x61\x01\x74\x01\x6c\x07\uffff\x01"+
        "\x7a\x01\x70\x01\uffff\x01\uffff\x01\x69\x01\x7a\x01\x74\x01\x7a"+
        "\x01\x65\x01\x77\x01\x68\x01\x6c\x01\x70\x01\x65\x01\uffff\x01\x6e"+
        "\x01\uffff\x01\x69\x01\x73\x04\x7a\x01\x69\x01\x7a\x01\uffff\x01"+
        "\x7a\x01\x6b\x01\x74\x04\uffff\x01\x63\x01\uffff\x01\uffff\x01\uffff"+
        "\x01\x7a\x01\x79\x02\x74\x01\uffff\x02\x6c\x01\x7a\x01\x75\x01\uffff"+
        "\x01\x69\x01\x65\x01\uffff\x01\x72\x01\uffff\x01\x62\x01\x7a\x01"+
        "\x65\x01\uffff\x01\x72\x01\uffff\x01\x7a\x01\x0a\x01\uffff\x01\uffff"+
        "\x01\x61\x01\uffff\x01\x72\x01\x79\x01\x7a\x01\uffff";
    const string DFA17_acceptS =
        "\x02\uffff\x01\x0a\x01\x0b\x01\x0c\x01\x0d\x01\x0e\x01\x0f\x01"+
        "\x10\x01\x11\x01\x12\x01\x13\x01\x14\x0c\uffff\x01\x25\x03\uffff"+
        "\x01\x2a\x01\uffff\x01\x2e\x08\uffff\x01\x2c\x01\x2d\x01\x0a\x01"+
        "\x0b\x01\x0c\x01\x0d\x01\x0e\x01\x0f\x01\x10\x01\x11\x01\x12\x01"+
        "\x13\x01\x14\x01\x15\x01\uffff\x01\x25\x06\uffff\x01\x1d\x01\x1e"+
        "\x01\x20\x01\uffff\x01\x27\x01\x1f\x01\x22\x01\x21\x02\uffff\x01"+
        "\x26\x02\uffff\x01\x29\x01\uffff\x01\x2a\x01\x2b\x01\uffff\x01\x2c"+
        "\x07\uffff\x01\x16\x01\x17\x01\x18\x01\x1b\x01\x19\x01\x1a\x01\x1c"+
        "\x03\uffff\x01\x28\x0c\uffff\x01\x02\x0c\uffff\x01\x06\x01\x07\x01"+
        "\x08\x01\x09\x01\uffff\x01\x24\x01\uffff\x01\x01\x0c\uffff\x01\x05"+
        "\x07\uffff\x01\x04\x02\uffff\x01\x28\x02\uffff\x01\x23\x03\uffff"+
        "\x01\x03";
    const string DFA17_specialS =
        "\x01\x0c\x01\x08\x1a\uffff\x01\x0d\x01\uffff\x01\x0b\x2a\uffff"+
        "\x01\x0a\x17\uffff\x01\x03\x0b\uffff\x01\x01\x0a\uffff\x01\x02\x09"+
        "\uffff\x01\x06\x05\uffff\x01\x07\x04\uffff\x01\x04\x04\uffff\x01"+
        "\x05\x03\uffff\x01\x00\x05\uffff\x01\x09\x06\uffff}>";
    static readonly string[] DFA17_transitionS = {
            "\x09\x1f\x02\x1d\x02\x1f\x01\x1d\x12\x1f\x01\x1d\x03\x1f\x01"+
            "\x1e\x01\x1c\x02\x1f\x01\x02\x01\x03\x01\x1f\x01\x16\x01\x08"+
            "\x01\x14\x01\x1b\x01\x0d\x0a\x1a\x01\x0b\x01\x0a\x01\x1f\x01"+
            "\x09\x03\x1f\x1a\x19\x01\x04\x01\x01\x01\x05\x01\x1f\x01\x19"+
            "\x01\x1f\x01\x13\x01\x19\x01\x0e\x01\x19\x01\x10\x03\x19\x01"+
            "\x0f\x03\x19\x01\x11\x02\x19\x01\x12\x02\x19\x01\x18\x01\x17"+
            "\x06\x19\x01\x06\x01\x15\x01\x07\x01\x0c\uff81\x1f",
            "\x41\x29\x1a\x28\x04\x29\x01\x28\x01\x29\x01\x28\x01\x20\x01"+
            "\x28\x01\x25\x01\x21\x01\x27\x07\x28\x01\x24\x01\x28\x01\x26"+
            "\x03\x28\x01\x23\x01\x22\x05\x28\uff85\x29",
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
            "\x01\x35",
            "\x01\x36",
            "\x01\x38",
            "\x01\x3a\x0a\uffff\x01\x39",
            "\x01\x3b",
            "\x01\x3c",
            "\x01\x3d",
            "\x01\x3e\x01\x42\x01\uffff\x0a\x41\x04\uffff\x01\x3f\x3d\uffff"+
            "\x01\x40",
            "\x01\x43",
            "\x01\x44",
            "\x01\x46",
            "\x01\x47",
            "",
            "\x01\x42\x01\uffff\x0a\x41",
            "\x0a\x42",
            "\x09\x4b\x01\x49\x01\x4c\x02\x4b\x01\x4a\x12\x4b\x01\x49\uffdf"+
            "\x4b",
            "",
            "\x00\x4e",
            "",
            "\x01\x4f",
            "\x01\x51",
            "\x01\x52",
            "\x01\x53",
            "\x01\x54",
            "\x01\x55",
            "\x01\x56",
            "\x01\x57",
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
            "\x01\x37\x0c\uffff\x01\x37\x01\uffff\x0a\x37\x07\uffff\x1a"+
            "\x37\x04\uffff\x01\x37\x01\uffff\x1a\x37",
            "",
            "\x01\x37\x0c\uffff\x01\x37\x01\uffff\x0a\x37\x07\uffff\x1a"+
            "\x37\x04\uffff\x01\x37\x01\uffff\x1a\x37",
            "\x01\x37\x0c\uffff\x01\x37\x01\uffff\x0a\x37\x07\uffff\x1a"+
            "\x37\x04\uffff\x01\x37\x01\uffff\x1a\x37",
            "\x01\x37\x0c\uffff\x01\x37\x01\uffff\x0a\x37\x07\uffff\x1a"+
            "\x37\x04\uffff\x01\x37\x01\uffff\x1a\x37",
            "\x01\x37\x0c\uffff\x01\x37\x01\uffff\x0a\x37\x07\uffff\x1a"+
            "\x37\x04\uffff\x01\x37\x01\uffff\x1a\x37",
            "\x01\x37\x0c\uffff\x01\x37\x01\uffff\x0a\x37\x07\uffff\x1a"+
            "\x37\x04\uffff\x01\x37\x01\uffff\x1a\x37",
            "\x01\x37\x0c\uffff\x01\x37\x01\uffff\x0a\x37\x07\uffff\x1a"+
            "\x37\x04\uffff\x01\x37\x01\uffff\x1a\x37",
            "",
            "",
            "",
            "\x01\x42\x01\uffff\x0a\x41",
            "",
            "",
            "",
            "",
            "\x01\x5f",
            "\x01\x60",
            "",
            "\x21\x4b\x01\x61\uffde\x4b",
            "\x01\x4b\x16\uffff\x01\x62",
            "",
            "\x01\x62",
            "",
            "",
            "\x01\x63",
            "",
            "\x01\x64",
            "\x01\x65",
            "\x01\x66",
            "\x01\x67",
            "\x01\x68",
            "\x01\x69",
            "\x01\x6a",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x6b",
            "\x01\x6c",
            "\x54\x4b\x01\x6d\uffab\x4b",
            "",
            "\x01\x6e",
            "\x01\x50\x0c\uffff\x01\x50\x01\uffff\x0a\x50\x07\uffff\x1a"+
            "\x50\x04\uffff\x01\x50\x01\uffff\x1a\x50",
            "\x01\x70",
            "\x01\x71",
            "\x01\x72",
            "\x01\x73",
            "\x01\x74",
            "\x01\x75",
            "\x01\x76",
            "\x01\x77",
            "\x49\x4b\x01\x78\uffb6\x4b",
            "\x01\x79",
            "",
            "\x01\x7a",
            "\x01\x7b",
            "\x01\x50\x0c\uffff\x01\x50\x01\uffff\x0a\x50\x07\uffff\x1a"+
            "\x50\x04\uffff\x01\x50\x01\uffff\x1a\x50",
            "\x01\x50\x0c\uffff\x01\x50\x01\uffff\x0a\x50\x07\uffff\x1a"+
            "\x50\x04\uffff\x01\x50\x01\uffff\x1a\x50",
            "\x01\x50\x0c\uffff\x01\x50\x01\uffff\x0a\x50\x07\uffff\x1a"+
            "\x50\x04\uffff\x01\x50\x01\uffff\x1a\x50",
            "\x01\x50\x0c\uffff\x01\x50\x01\uffff\x0a\x50\x07\uffff\x1a"+
            "\x50\x04\uffff\x01\x50\x01\uffff\x1a\x50",
            "\x01\u0080",
            "\x01\x37\x0c\uffff\x01\x37\x01\uffff\x0a\x37\x07\uffff\x1a"+
            "\x37\x04\uffff\x01\x37\x01\uffff\x1a\x37",
            "\x4b\x4b\x01\u0082\uffb4\x4b",
            "\x01\x50\x0c\uffff\x01\x50\x01\uffff\x0a\x50\x07\uffff\x1a"+
            "\x50\x04\uffff\x01\x50\x01\uffff\x1a\x50",
            "\x01\u0084",
            "\x01\u0086\x0e\uffff\x01\u0085",
            "",
            "",
            "",
            "",
            "\x01\u0087",
            "",
            "\x5a\x4b\x01\u0088\uffa5\x4b",
            "",
            "\x01\u0089",
            "\x01\u008a",
            "\x01\u008b",
            "\x01\u008c",
            "\x45\x4b\x01\u008d\uffba\x4b",
            "\x01\u008e",
            "\x01\u008f",
            "\x01\x50\x0c\uffff\x01\x50\x01\uffff\x0a\x50\x07\uffff\x1a"+
            "\x50\x04\uffff\x01\x50\x01\uffff\x1a\x50",
            "\x01\u0091",
            "\x44\x4b\x01\u0092\uffbb\x4b",
            "\x01\u0093",
            "\x01\u0094",
            "",
            "\x01\u0095",
            "\x54\x4b\x01\u0096\uffab\x4b",
            "\x01\u0097",
            "\x01\x50\x0c\uffff\x01\x50\x01\uffff\x0a\x50\x07\uffff\x1a"+
            "\x50\x04\uffff\x01\x50\x01\uffff\x1a\x50",
            "\x01\u0099",
            "\x0a\u009c\x01\u009b\x02\u009c\x01\u009a\ufff2\u009c",
            "\x01\u009d",
            "",
            "\x01\x37\x0c\uffff\x01\x37\x01\uffff\x0a\x37\x07\uffff\x1a"+
            "\x37\x04\uffff\x01\x37\x01\uffff\x1a\x37",
            "\x01\u009b",
            "",
            "\x0a\u009c\x01\u009b\x02\u009c\x01\u009a\ufff2\u009c",
            "\x01\u009f",
            "",
            "\x01\u00a0",
            "\x01\u00a1",
            "\x01\x50\x0c\uffff\x01\x50\x01\uffff\x0a\x50\x07\uffff\x1a"+
            "\x50\x04\uffff\x01\x50\x01\uffff\x1a\x50",
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
            get { return "1:1: Tokens : ( BEGIN | END | USETIKZLIB | TIKZSTYLE | TIKZSET | NODE | DRAW | PATH | FILL | LPAR | RPAR | LBR | RBR | LBRR | RBRR | KOMMA | EQU | SEMIC | COLON | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | ID | INT | FLOAT_WO_EXP | TIKZEDT_CMD_COMMENT | COMMENT | WS | MATHSTRING | COMMAND | ESC_SEQ | SOMETHING );"; }
        }

    }


    protected internal int DFA17_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            IIntStream input = _input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA17_150 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_150 == '\r') ) { s = 154; }

                   	else if ( (LA17_150 == '\n') ) { s = 155; }

                   	else if ( ((LA17_150 >= '\u0000' && LA17_150 <= '\t') || (LA17_150 >= '\u000B' && LA17_150 <= '\f') || (LA17_150 >= '\u000E' && LA17_150 <= '\uFFFF')) ) { s = 156; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA17_109 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_109 == 'I') ) { s = 120; }

                   	else if ( ((LA17_109 >= '\u0000' && LA17_109 <= 'H') || (LA17_109 >= 'J' && LA17_109 <= '\uFFFF')) ) { s = 75; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA17_120 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_120 == 'K') ) { s = 130; }

                   	else if ( ((LA17_120 >= '\u0000' && LA17_120 <= 'J') || (LA17_120 >= 'L' && LA17_120 <= '\uFFFF')) ) { s = 75; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA17_97 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_97 == 'T') ) { s = 109; }

                   	else if ( ((LA17_97 >= '\u0000' && LA17_97 <= 'S') || (LA17_97 >= 'U' && LA17_97 <= '\uFFFF')) ) { s = 75; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA17_141 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_141 == 'D') ) { s = 146; }

                   	else if ( ((LA17_141 >= '\u0000' && LA17_141 <= 'C') || (LA17_141 >= 'E' && LA17_141 <= '\uFFFF')) ) { s = 75; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA17_146 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_146 == 'T') ) { s = 150; }

                   	else if ( ((LA17_146 >= '\u0000' && LA17_146 <= 'S') || (LA17_146 >= 'U' && LA17_146 <= '\uFFFF')) ) { s = 75; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA17_130 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_130 == 'Z') ) { s = 136; }

                   	else if ( ((LA17_130 >= '\u0000' && LA17_130 <= 'Y') || (LA17_130 >= '[' && LA17_130 <= '\uFFFF')) ) { s = 75; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA17_136 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_136 == 'E') ) { s = 141; }

                   	else if ( ((LA17_136 >= '\u0000' && LA17_136 <= 'D') || (LA17_136 >= 'F' && LA17_136 <= '\uFFFF')) ) { s = 75; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA17_1 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_1 == 'b') ) { s = 32; }

                   	else if ( (LA17_1 == 'e') ) { s = 33; }

                   	else if ( (LA17_1 == 'u') ) { s = 34; }

                   	else if ( (LA17_1 == 't') ) { s = 35; }

                   	else if ( (LA17_1 == 'n') ) { s = 36; }

                   	else if ( (LA17_1 == 'd') ) { s = 37; }

                   	else if ( (LA17_1 == 'p') ) { s = 38; }

                   	else if ( (LA17_1 == 'f') ) { s = 39; }

                   	else if ( ((LA17_1 >= 'A' && LA17_1 <= 'Z') || LA17_1 == '_' || LA17_1 == 'a' || LA17_1 == 'c' || (LA17_1 >= 'g' && LA17_1 <= 'm') || LA17_1 == 'o' || (LA17_1 >= 'q' && LA17_1 <= 's') || (LA17_1 >= 'v' && LA17_1 <= 'z')) ) { s = 40; }

                   	else if ( ((LA17_1 >= '\u0000' && LA17_1 <= '@') || (LA17_1 >= '[' && LA17_1 <= '^') || LA17_1 == '`' || (LA17_1 >= '{' && LA17_1 <= '\uFFFF')) ) { s = 41; }

                   	else s = 31;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA17_156 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_156 == '\r') ) { s = 154; }

                   	else if ( (LA17_156 == '\n') ) { s = 155; }

                   	else if ( ((LA17_156 >= '\u0000' && LA17_156 <= '\t') || (LA17_156 >= '\u000B' && LA17_156 <= '\f') || (LA17_156 >= '\u000E' && LA17_156 <= '\uFFFF')) ) { s = 156; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA17_73 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_73 == '!') ) { s = 97; }

                   	else if ( ((LA17_73 >= '\u0000' && LA17_73 <= ' ') || (LA17_73 >= '\"' && LA17_73 <= '\uFFFF')) ) { s = 75; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA17_30 = input.LA(1);

                   	s = -1;
                   	if ( ((LA17_30 >= '\u0000' && LA17_30 <= '\uFFFF')) ) { s = 78; }

                   	else s = 31;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA17_0 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_0 == '\\') ) { s = 1; }

                   	else if ( (LA17_0 == '(') ) { s = 2; }

                   	else if ( (LA17_0 == ')') ) { s = 3; }

                   	else if ( (LA17_0 == '[') ) { s = 4; }

                   	else if ( (LA17_0 == ']') ) { s = 5; }

                   	else if ( (LA17_0 == '{') ) { s = 6; }

                   	else if ( (LA17_0 == '}') ) { s = 7; }

                   	else if ( (LA17_0 == ',') ) { s = 8; }

                   	else if ( (LA17_0 == '=') ) { s = 9; }

                   	else if ( (LA17_0 == ';') ) { s = 10; }

                   	else if ( (LA17_0 == ':') ) { s = 11; }

                   	else if ( (LA17_0 == '~') ) { s = 12; }

                   	else if ( (LA17_0 == '/') ) { s = 13; }

                   	else if ( (LA17_0 == 'c') ) { s = 14; }

                   	else if ( (LA17_0 == 'i') ) { s = 15; }

                   	else if ( (LA17_0 == 'e') ) { s = 16; }

                   	else if ( (LA17_0 == 'm') ) { s = 17; }

                   	else if ( (LA17_0 == 'p') ) { s = 18; }

                   	else if ( (LA17_0 == 'a') ) { s = 19; }

                   	else if ( (LA17_0 == '-') ) { s = 20; }

                   	else if ( (LA17_0 == '|') ) { s = 21; }

                   	else if ( (LA17_0 == '+') ) { s = 22; }

                   	else if ( (LA17_0 == 't') ) { s = 23; }

                   	else if ( (LA17_0 == 's') ) { s = 24; }

                   	else if ( ((LA17_0 >= 'A' && LA17_0 <= 'Z') || LA17_0 == '_' || LA17_0 == 'b' || LA17_0 == 'd' || (LA17_0 >= 'f' && LA17_0 <= 'h') || (LA17_0 >= 'j' && LA17_0 <= 'l') || (LA17_0 >= 'n' && LA17_0 <= 'o') || (LA17_0 >= 'q' && LA17_0 <= 'r') || (LA17_0 >= 'u' && LA17_0 <= 'z')) ) { s = 25; }

                   	else if ( ((LA17_0 >= '0' && LA17_0 <= '9')) ) { s = 26; }

                   	else if ( (LA17_0 == '.') ) { s = 27; }

                   	else if ( (LA17_0 == '%') ) { s = 28; }

                   	else if ( ((LA17_0 >= '\t' && LA17_0 <= '\n') || LA17_0 == '\r' || LA17_0 == ' ') ) { s = 29; }

                   	else if ( (LA17_0 == '$') ) { s = 30; }

                   	else if ( ((LA17_0 >= '\u0000' && LA17_0 <= '\b') || (LA17_0 >= '\u000B' && LA17_0 <= '\f') || (LA17_0 >= '\u000E' && LA17_0 <= '\u001F') || (LA17_0 >= '!' && LA17_0 <= '#') || (LA17_0 >= '&' && LA17_0 <= '\'') || LA17_0 == '*' || LA17_0 == '<' || (LA17_0 >= '>' && LA17_0 <= '@') || LA17_0 == '^' || LA17_0 == '`' || (LA17_0 >= '\u007F' && LA17_0 <= '\uFFFF')) ) { s = 31; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 13 : 
                   	int LA17_28 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_28 == '\t' || LA17_28 == ' ') ) { s = 73; }

                   	else if ( (LA17_28 == '\r') ) { s = 74; }

                   	else if ( ((LA17_28 >= '\u0000' && LA17_28 <= '\b') || (LA17_28 >= '\u000B' && LA17_28 <= '\f') || (LA17_28 >= '\u000E' && LA17_28 <= '\u001F') || (LA17_28 >= '!' && LA17_28 <= '\uFFFF')) ) { s = 75; }

                   	else if ( (LA17_28 == '\n') ) { s = 76; }

                   	else s = 31;

                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae17 =
            new NoViableAltException(dfa.Description, 17, _s, input);
        dfa.Error(nvae17);
        throw nvae17;
    }
 
    
}
