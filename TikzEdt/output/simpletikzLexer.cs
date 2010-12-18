// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g 2010-12-18 16:08:43

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
    public const int T__66 = 66;
    public const int EXPONENT = 46;
    public const int T__64 = 64;
    public const int T__65 = 65;
    public const int IM_STARTTAG = 31;
    public const int T__62 = 62;
    public const int T__63 = 63;
    public const int IM_PATH = 23;
    public const int RBR = 16;
    public const int IM_ID = 36;
    public const int SOMETHING = 50;
    public const int T__61 = 61;
    public const int ID = 43;
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
    public const int NODE = 9;
    public const int IM_OPTION_STYLE = 34;
    public const int TIKZSET = 8;
    public const int TIKZSTYLE = 7;
    public const int IM_COORD = 25;
    public const int IM_PICTURE = 28;
    public const int LBRR = 17;
    public const int INT = 41;
    public const int IM_NODE = 24;
    public const int USETIKZLIB = 6;
    public const int IM_STYLE = 40;
    public const int COLON = 22;
    public const int IM_NUMBERUNIT = 27;
    public const int IM_SCOPE = 30;
    public const int WS = 45;
    public const int KOMMA = 19;
    public const int EQU = 20;
    public const int RPAR = 14;
    public const int SEMIC = 21;
    public const int END = 5;
    public const int IM_NODENAME = 26;
    public const int DRAW = 10;
    public const int FLOAT_WO_EXP = 42;

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

    // $ANTLR start "T__51"
    public void mT__51() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__51;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:26:7: ( '/.style' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:26:9: '/.style'
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
    // $ANTLR end "T__51"

    // $ANTLR start "T__52"
    public void mT__52() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__52;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:27:7: ( 'cm' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:27:9: 'cm'
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
    // $ANTLR end "T__52"

    // $ANTLR start "T__53"
    public void mT__53() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__53;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:28:7: ( 'in' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:28:9: 'in'
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
    // $ANTLR end "T__53"

    // $ANTLR start "T__54"
    public void mT__54() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__54;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:29:7: ( 'ex' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:29:9: 'ex'
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
    // $ANTLR end "T__54"

    // $ANTLR start "T__55"
    public void mT__55() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__55;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:30:7: ( 'mm' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:30:9: 'mm'
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
    // $ANTLR end "T__55"

    // $ANTLR start "T__56"
    public void mT__56() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__56;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:31:7: ( 'pt' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:31:9: 'pt'
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
    // $ANTLR end "T__56"

    // $ANTLR start "T__57"
    public void mT__57() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__57;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:32:7: ( 'em' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:32:9: 'em'
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
    // $ANTLR end "T__57"

    // $ANTLR start "T__58"
    public void mT__58() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__58;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:33:7: ( 'at' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:33:9: 'at'
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
    // $ANTLR end "T__58"

    // $ANTLR start "T__59"
    public void mT__59() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__59;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:34:7: ( '--' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:34:9: '--'
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
    // $ANTLR end "T__59"

    // $ANTLR start "T__60"
    public void mT__60() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__60;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:35:7: ( '->' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:35:9: '->'
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
    // $ANTLR end "T__60"

    // $ANTLR start "T__61"
    public void mT__61() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__61;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:36:7: ( '|-' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:36:9: '|-'
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
    // $ANTLR end "T__61"

    // $ANTLR start "T__62"
    public void mT__62() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__62;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:37:7: ( '-|' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:37:9: '-|'
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
    // $ANTLR end "T__62"

    // $ANTLR start "T__63"
    public void mT__63() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__63;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:38:7: ( '+' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:38:9: '+'
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
    // $ANTLR end "T__63"

    // $ANTLR start "T__64"
    public void mT__64() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__64;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:39:7: ( '++' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:39:9: '++'
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
    // $ANTLR end "T__64"

    // $ANTLR start "T__65"
    public void mT__65() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__65;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:40:7: ( 'tikzpicture' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:40:9: 'tikzpicture'
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
    // $ANTLR end "T__65"

    // $ANTLR start "T__66"
    public void mT__66() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__66;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:41:7: ( 'scope' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:41:9: 'scope'
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
    // $ANTLR end "T__66"

    // $ANTLR start "ID"
    public void mID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:340:5: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' | '!' )* )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:340:7: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' | '!' )*
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

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:340:31: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' | '!' )*
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:343:5: ( ( '-' )? ( '0' .. '9' )+ )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:343:7: ( '-' )? ( '0' .. '9' )+
            {
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:343:7: ( '-' )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == '-') )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:343:7: '-'
            	        {
            	        	Match('-'); 

            	        }
            	        break;

            	}

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:343:12: ( '0' .. '9' )+
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
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:343:12: '0' .. '9'
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:355:5: ( ( '-' )? ( '0' .. '9' )+ '.' ( '0' .. '9' )* | ( '-' )? '.' ( '0' .. '9' )+ )
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
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:355:9: ( '-' )? ( '0' .. '9' )+ '.' ( '0' .. '9' )*
                    {
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:355:9: ( '-' )?
                    	int alt4 = 2;
                    	int LA4_0 = input.LA(1);

                    	if ( (LA4_0 == '-') )
                    	{
                    	    alt4 = 1;
                    	}
                    	switch (alt4) 
                    	{
                    	    case 1 :
                    	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:355:9: '-'
                    	        {
                    	        	Match('-'); 

                    	        }
                    	        break;

                    	}

                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:355:14: ( '0' .. '9' )+
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
                    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:355:15: '0' .. '9'
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
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:355:30: ( '0' .. '9' )*
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
                    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:355:31: '0' .. '9'
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
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:356:9: ( '-' )? '.' ( '0' .. '9' )+
                    {
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:356:9: ( '-' )?
                    	int alt7 = 2;
                    	int LA7_0 = input.LA(1);

                    	if ( (LA7_0 == '-') )
                    	{
                    	    alt7 = 1;
                    	}
                    	switch (alt7) 
                    	{
                    	    case 1 :
                    	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:356:9: '-'
                    	        {
                    	        	Match('-'); 

                    	        }
                    	        break;

                    	}

                    	Match('.'); 
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:356:18: ( '0' .. '9' )+
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
                    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:356:19: '0' .. '9'
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

    // $ANTLR start "COMMENT"
    public void mCOMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:362:5: ( '%' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:362:9: '%' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
            {
            	Match('%'); 
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:362:13: (~ ( '\\n' | '\\r' ) )*
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
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:362:13: ~ ( '\\n' | '\\r' )
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

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:362:27: ( '\\r' )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == '\r') )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:362:27: '\\r'
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:365:5: ( ( ' ' | '\\t' | '\\r' | '\\n' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:365:9: ( ' ' | '\\t' | '\\r' | '\\n' )
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:372:19: ( ( 'e' | 'E' ) ( '+' | '-' )? ( '0' .. '9' )+ )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:372:21: ( 'e' | 'E' ) ( '+' | '-' )? ( '0' .. '9' )+
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

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:372:31: ( '+' | '-' )?
            	int alt12 = 2;
            	int LA12_0 = input.LA(1);

            	if ( (LA12_0 == '+' || LA12_0 == '-') )
            	{
            	    alt12 = 1;
            	}
            	switch (alt12) 
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

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:372:42: ( '0' .. '9' )+
            	int cnt13 = 0;
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( ((LA13_0 >= '0' && LA13_0 <= '9')) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:372:43: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

            			    }
            			    break;

            			default:
            			    if ( cnt13 >= 1 ) goto loop13;
            		            EarlyExitException eee13 =
            		                new EarlyExitException(13, input);
            		            throw eee13;
            	    }
            	    cnt13++;
            	} while (true);

            	loop13:
            		;	// Stops C# compiler whining that label 'loop13' has no statements


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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:379:2: ( '$' ( ESC_SEQ | ~ ( '\\\\' | '$' ) )* '$' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:379:4: '$' ( ESC_SEQ | ~ ( '\\\\' | '$' ) )* '$'
            {
            	Match('$'); 
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:379:8: ( ESC_SEQ | ~ ( '\\\\' | '$' ) )*
            	do 
            	{
            	    int alt14 = 3;
            	    int LA14_0 = input.LA(1);

            	    if ( (LA14_0 == '\\') )
            	    {
            	        alt14 = 1;
            	    }
            	    else if ( ((LA14_0 >= '\u0000' && LA14_0 <= '#') || (LA14_0 >= '%' && LA14_0 <= '[') || (LA14_0 >= ']' && LA14_0 <= '\uFFFF')) )
            	    {
            	        alt14 = 2;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:379:10: ESC_SEQ
            			    {
            			    	mESC_SEQ(); 

            			    }
            			    break;
            			case 2 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:379:20: ~ ( '\\\\' | '$' )
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
            			    goto loop14;
            	    }
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whining that label 'loop14' has no statements

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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:390:2: ( '\\\\' ID )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:390:4: '\\\\' ID
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:395:5: ( '\\\\' . )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:395:9: '\\\\' .
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:401:2: ( . )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:401:4: .
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
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:8: ( BEGIN | END | USETIKZLIB | TIKZSTYLE | TIKZSET | NODE | DRAW | PATH | FILL | LPAR | RPAR | LBR | RBR | LBRR | RBRR | KOMMA | EQU | SEMIC | COLON | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | ID | INT | FLOAT_WO_EXP | COMMENT | WS | MATHSTRING | COMMAND | ESC_SEQ | SOMETHING )
        int alt15 = 44;
        alt15 = dfa15.Predict(input);
        switch (alt15) 
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
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:119: T__51
                {
                	mT__51(); 

                }
                break;
            case 21 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:125: T__52
                {
                	mT__52(); 

                }
                break;
            case 22 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:131: T__53
                {
                	mT__53(); 

                }
                break;
            case 23 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:137: T__54
                {
                	mT__54(); 

                }
                break;
            case 24 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:143: T__55
                {
                	mT__55(); 

                }
                break;
            case 25 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:149: T__56
                {
                	mT__56(); 

                }
                break;
            case 26 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:155: T__57
                {
                	mT__57(); 

                }
                break;
            case 27 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:161: T__58
                {
                	mT__58(); 

                }
                break;
            case 28 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:167: T__59
                {
                	mT__59(); 

                }
                break;
            case 29 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:173: T__60
                {
                	mT__60(); 

                }
                break;
            case 30 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:179: T__61
                {
                	mT__61(); 

                }
                break;
            case 31 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:185: T__62
                {
                	mT__62(); 

                }
                break;
            case 32 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:191: T__63
                {
                	mT__63(); 

                }
                break;
            case 33 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:197: T__64
                {
                	mT__64(); 

                }
                break;
            case 34 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:203: T__65
                {
                	mT__65(); 

                }
                break;
            case 35 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:209: T__66
                {
                	mT__66(); 

                }
                break;
            case 36 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:215: ID
                {
                	mID(); 

                }
                break;
            case 37 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:218: INT
                {
                	mINT(); 

                }
                break;
            case 38 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:222: FLOAT_WO_EXP
                {
                	mFLOAT_WO_EXP(); 

                }
                break;
            case 39 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:235: COMMENT
                {
                	mCOMMENT(); 

                }
                break;
            case 40 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:243: WS
                {
                	mWS(); 

                }
                break;
            case 41 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:246: MATHSTRING
                {
                	mMATHSTRING(); 

                }
                break;
            case 42 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:257: COMMAND
                {
                	mCOMMAND(); 

                }
                break;
            case 43 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:265: ESC_SEQ
                {
                	mESC_SEQ(); 

                }
                break;
            case 44 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:273: SOMETHING
                {
                	mSOMETHING(); 

                }
                break;

        }

    }


    protected DFA15 dfa15;
	private void InitializeCyclicDFAs()
	{
	    this.dfa15 = new DFA15(this);
	    this.dfa15.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA15_SpecialStateTransition);
	}

    const string DFA15_eotS =
        "\x01\uffff\x01\x1e\x0a\uffff\x01\x1e\x06\x35\x02\x1e\x01\x43\x02"+
        "\x35\x01\uffff\x01\x46\x02\x1e\x01\uffff\x01\x1e\x01\uffff\x08\x4b"+
        "\x0d\uffff\x01\x53\x01\uffff\x01\x54\x01\x55\x01\x56\x01\x57\x01"+
        "\x58\x01\x59\x03\uffff\x01\x46\x04\uffff\x02\x35\x04\uffff\x01\x4b"+
        "\x01\uffff\x07\x4b\x07\uffff\x02\x35\x01\x4b\x01\x67\x06\x4b\x02"+
        "\x35\x01\x4b\x01\uffff\x02\x4b\x01\x73\x01\x74\x01\x75\x01\x76\x01"+
        "\x35\x01\x78\x01\x79\x02\x4b\x04\uffff\x01\x35\x02\uffff\x03\x4b"+
        "\x01\x35\x02\x4b\x01\u0084\x01\x35\x02\x4b\x01\uffff\x01\x35\x01"+
        "\x4b\x01\u008a\x01\x35\x01\x4b\x01\uffff\x01\u008d\x01\x4b\x01\uffff"+
        "\x02\x4b\x01\u0091\x01\uffff";
    const string DFA15_eofS =
        "\u0092\uffff";
    const string DFA15_minS =
        "\x02\x00\x0a\uffff\x01\x2e\x01\x6d\x01\x6e\x02\x6d\x02\x74\x02"+
        "\x2d\x01\x2b\x01\x69\x01\x63\x01\uffff\x01\x2e\x01\x30\x01\x00\x01"+
        "\uffff\x01\x00\x01\uffff\x01\x65\x01\x6e\x01\x73\x01\x69\x01\x6f"+
        "\x01\x72\x01\x61\x01\x69\x0d\uffff\x01\x21\x01\uffff\x06\x21\x03"+
        "\uffff\x01\x2e\x04\uffff\x01\x6b\x01\x6f\x04\uffff\x01\x67\x01\uffff"+
        "\x01\x64\x01\x65\x01\x6b\x01\x64\x01\x61\x01\x74\x01\x6c\x07\uffff"+
        "\x01\x7a\x01\x70\x01\x69\x01\x21\x01\x74\x01\x7a\x01\x65\x01\x77"+
        "\x01\x68\x01\x6c\x01\x70\x01\x65\x01\x6e\x01\uffff\x01\x69\x01\x73"+
        "\x04\x21\x01\x69\x02\x21\x01\x6b\x01\x65\x04\uffff\x01\x63\x02\uffff"+
        "\x01\x7a\x01\x79\x02\x74\x02\x6c\x01\x21\x01\x75\x01\x69\x01\x65"+
        "\x01\uffff\x01\x72\x01\x62\x01\x21\x01\x65\x01\x72\x01\uffff\x01"+
        "\x21\x01\x61\x01\uffff\x01\x72\x01\x79\x01\x21\x01\uffff";
    const string DFA15_maxS =
        "\x02\uffff\x0a\uffff\x01\x2e\x01\x6d\x01\x6e\x01\x78\x01\x6d\x02"+
        "\x74\x01\x7c\x01\x2d\x01\x2b\x01\x69\x01\x63\x01\uffff\x02\x39\x01"+
        "\uffff\x01\uffff\x01\uffff\x01\uffff\x01\x65\x01\x6e\x01\x73\x01"+
        "\x69\x01\x6f\x01\x72\x01\x61\x01\x69\x0d\uffff\x01\x7a\x01\uffff"+
        "\x06\x7a\x03\uffff\x01\x39\x04\uffff\x01\x6b\x01\x6f\x04\uffff\x01"+
        "\x67\x01\uffff\x01\x64\x01\x65\x01\x6b\x01\x64\x01\x61\x01\x74\x01"+
        "\x6c\x07\uffff\x01\x7a\x01\x70\x01\x69\x01\x7a\x01\x74\x01\x7a\x01"+
        "\x65\x01\x77\x01\x68\x01\x6c\x01\x70\x01\x65\x01\x6e\x01\uffff\x01"+
        "\x69\x01\x73\x04\x7a\x01\x69\x02\x7a\x01\x6b\x01\x74\x04\uffff\x01"+
        "\x63\x02\uffff\x01\x7a\x01\x79\x02\x74\x02\x6c\x01\x7a\x01\x75\x01"+
        "\x69\x01\x65\x01\uffff\x01\x72\x01\x62\x01\x7a\x01\x65\x01\x72\x01"+
        "\uffff\x01\x7a\x01\x61\x01\uffff\x01\x72\x01\x79\x01\x7a\x01\uffff";
    const string DFA15_acceptS =
        "\x02\uffff\x01\x0a\x01\x0b\x01\x0c\x01\x0d\x01\x0e\x01\x0f\x01"+
        "\x10\x01\x11\x01\x12\x01\x13\x0c\uffff\x01\x24\x03\uffff\x01\x28"+
        "\x01\uffff\x01\x2c\x08\uffff\x01\x2a\x01\x2b\x01\x0a\x01\x0b\x01"+
        "\x0c\x01\x0d\x01\x0e\x01\x0f\x01\x10\x01\x11\x01\x12\x01\x13\x01"+
        "\x14\x01\uffff\x01\x24\x06\uffff\x01\x1c\x01\x1d\x01\x1f\x01\uffff"+
        "\x01\x26\x01\x1e\x01\x21\x01\x20\x02\uffff\x01\x25\x01\x27\x01\x28"+
        "\x01\x29\x01\uffff\x01\x2a\x07\uffff\x01\x15\x01\x16\x01\x17\x01"+
        "\x1a\x01\x18\x01\x19\x01\x1b\x0d\uffff\x01\x02\x0b\uffff\x01\x06"+
        "\x01\x07\x01\x08\x01\x09\x01\uffff\x01\x23\x01\x01\x0a\uffff\x01"+
        "\x05\x05\uffff\x01\x04\x02\uffff\x01\x22\x03\uffff\x01\x03";
    const string DFA15_specialS =
        "\x01\x03\x01\x00\x19\uffff\x01\x01\x01\uffff\x01\x02\x74\uffff}>";
    static readonly string[] DFA15_transitionS = {
            "\x09\x1e\x02\x1c\x02\x1e\x01\x1c\x12\x1e\x01\x1c\x03\x1e\x01"+
            "\x1d\x01\x1b\x02\x1e\x01\x02\x01\x03\x01\x1e\x01\x15\x01\x08"+
            "\x01\x13\x01\x1a\x01\x0c\x0a\x19\x01\x0b\x01\x0a\x01\x1e\x01"+
            "\x09\x03\x1e\x1a\x18\x01\x04\x01\x01\x01\x05\x01\x1e\x01\x18"+
            "\x01\x1e\x01\x12\x01\x18\x01\x0d\x01\x18\x01\x0f\x03\x18\x01"+
            "\x0e\x03\x18\x01\x10\x02\x18\x01\x11\x02\x18\x01\x17\x01\x16"+
            "\x06\x18\x01\x06\x01\x14\x01\x07\uff82\x1e",
            "\x41\x28\x1a\x27\x04\x28\x01\x27\x01\x28\x01\x27\x01\x1f\x01"+
            "\x27\x01\x24\x01\x20\x01\x26\x07\x27\x01\x23\x01\x27\x01\x25"+
            "\x03\x27\x01\x22\x01\x21\x05\x27\uff85\x28",
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
            "\x01\x33",
            "\x01\x34",
            "\x01\x36",
            "\x01\x38\x0a\uffff\x01\x37",
            "\x01\x39",
            "\x01\x3a",
            "\x01\x3b",
            "\x01\x3c\x01\x40\x01\uffff\x0a\x3f\x04\uffff\x01\x3d\x3d\uffff"+
            "\x01\x3e",
            "\x01\x41",
            "\x01\x42",
            "\x01\x44",
            "\x01\x45",
            "",
            "\x01\x40\x01\uffff\x0a\x3f",
            "\x0a\x40",
            "\x00\x47",
            "",
            "\x00\x49",
            "",
            "\x01\x4a",
            "\x01\x4c",
            "\x01\x4d",
            "\x01\x4e",
            "\x01\x4f",
            "\x01\x50",
            "\x01\x51",
            "\x01\x52",
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
            "\x01\x35\x0c\uffff\x01\x35\x01\uffff\x0a\x35\x07\uffff\x1a"+
            "\x35\x04\uffff\x01\x35\x01\uffff\x1a\x35",
            "",
            "\x01\x35\x0c\uffff\x01\x35\x01\uffff\x0a\x35\x07\uffff\x1a"+
            "\x35\x04\uffff\x01\x35\x01\uffff\x1a\x35",
            "\x01\x35\x0c\uffff\x01\x35\x01\uffff\x0a\x35\x07\uffff\x1a"+
            "\x35\x04\uffff\x01\x35\x01\uffff\x1a\x35",
            "\x01\x35\x0c\uffff\x01\x35\x01\uffff\x0a\x35\x07\uffff\x1a"+
            "\x35\x04\uffff\x01\x35\x01\uffff\x1a\x35",
            "\x01\x35\x0c\uffff\x01\x35\x01\uffff\x0a\x35\x07\uffff\x1a"+
            "\x35\x04\uffff\x01\x35\x01\uffff\x1a\x35",
            "\x01\x35\x0c\uffff\x01\x35\x01\uffff\x0a\x35\x07\uffff\x1a"+
            "\x35\x04\uffff\x01\x35\x01\uffff\x1a\x35",
            "\x01\x35\x0c\uffff\x01\x35\x01\uffff\x0a\x35\x07\uffff\x1a"+
            "\x35\x04\uffff\x01\x35\x01\uffff\x1a\x35",
            "",
            "",
            "",
            "\x01\x40\x01\uffff\x0a\x3f",
            "",
            "",
            "",
            "",
            "\x01\x5a",
            "\x01\x5b",
            "",
            "",
            "",
            "",
            "\x01\x5c",
            "",
            "\x01\x5d",
            "\x01\x5e",
            "\x01\x5f",
            "\x01\x60",
            "\x01\x61",
            "\x01\x62",
            "\x01\x63",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x64",
            "\x01\x65",
            "\x01\x66",
            "\x01\x4b\x0c\uffff\x01\x4b\x01\uffff\x0a\x4b\x07\uffff\x1a"+
            "\x4b\x04\uffff\x01\x4b\x01\uffff\x1a\x4b",
            "\x01\x68",
            "\x01\x69",
            "\x01\x6a",
            "\x01\x6b",
            "\x01\x6c",
            "\x01\x6d",
            "\x01\x6e",
            "\x01\x6f",
            "\x01\x70",
            "",
            "\x01\x71",
            "\x01\x72",
            "\x01\x4b\x0c\uffff\x01\x4b\x01\uffff\x0a\x4b\x07\uffff\x1a"+
            "\x4b\x04\uffff\x01\x4b\x01\uffff\x1a\x4b",
            "\x01\x4b\x0c\uffff\x01\x4b\x01\uffff\x0a\x4b\x07\uffff\x1a"+
            "\x4b\x04\uffff\x01\x4b\x01\uffff\x1a\x4b",
            "\x01\x4b\x0c\uffff\x01\x4b\x01\uffff\x0a\x4b\x07\uffff\x1a"+
            "\x4b\x04\uffff\x01\x4b\x01\uffff\x1a\x4b",
            "\x01\x4b\x0c\uffff\x01\x4b\x01\uffff\x0a\x4b\x07\uffff\x1a"+
            "\x4b\x04\uffff\x01\x4b\x01\uffff\x1a\x4b",
            "\x01\x77",
            "\x01\x35\x0c\uffff\x01\x35\x01\uffff\x0a\x35\x07\uffff\x1a"+
            "\x35\x04\uffff\x01\x35\x01\uffff\x1a\x35",
            "\x01\x4b\x0c\uffff\x01\x4b\x01\uffff\x0a\x4b\x07\uffff\x1a"+
            "\x4b\x04\uffff\x01\x4b\x01\uffff\x1a\x4b",
            "\x01\x7a",
            "\x01\x7c\x0e\uffff\x01\x7b",
            "",
            "",
            "",
            "",
            "\x01\x7d",
            "",
            "",
            "\x01\x7e",
            "\x01\x7f",
            "\x01\u0080",
            "\x01\u0081",
            "\x01\u0082",
            "\x01\u0083",
            "\x01\x4b\x0c\uffff\x01\x4b\x01\uffff\x0a\x4b\x07\uffff\x1a"+
            "\x4b\x04\uffff\x01\x4b\x01\uffff\x1a\x4b",
            "\x01\u0085",
            "\x01\u0086",
            "\x01\u0087",
            "",
            "\x01\u0088",
            "\x01\u0089",
            "\x01\x4b\x0c\uffff\x01\x4b\x01\uffff\x0a\x4b\x07\uffff\x1a"+
            "\x4b\x04\uffff\x01\x4b\x01\uffff\x1a\x4b",
            "\x01\u008b",
            "\x01\u008c",
            "",
            "\x01\x35\x0c\uffff\x01\x35\x01\uffff\x0a\x35\x07\uffff\x1a"+
            "\x35\x04\uffff\x01\x35\x01\uffff\x1a\x35",
            "\x01\u008e",
            "",
            "\x01\u008f",
            "\x01\u0090",
            "\x01\x4b\x0c\uffff\x01\x4b\x01\uffff\x0a\x4b\x07\uffff\x1a"+
            "\x4b\x04\uffff\x01\x4b\x01\uffff\x1a\x4b",
            ""
    };

    static readonly short[] DFA15_eot = DFA.UnpackEncodedString(DFA15_eotS);
    static readonly short[] DFA15_eof = DFA.UnpackEncodedString(DFA15_eofS);
    static readonly char[] DFA15_min = DFA.UnpackEncodedStringToUnsignedChars(DFA15_minS);
    static readonly char[] DFA15_max = DFA.UnpackEncodedStringToUnsignedChars(DFA15_maxS);
    static readonly short[] DFA15_accept = DFA.UnpackEncodedString(DFA15_acceptS);
    static readonly short[] DFA15_special = DFA.UnpackEncodedString(DFA15_specialS);
    static readonly short[][] DFA15_transition = DFA.UnpackEncodedStringArray(DFA15_transitionS);

    protected class DFA15 : DFA
    {
        public DFA15(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 15;
            this.eot = DFA15_eot;
            this.eof = DFA15_eof;
            this.min = DFA15_min;
            this.max = DFA15_max;
            this.accept = DFA15_accept;
            this.special = DFA15_special;
            this.transition = DFA15_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( BEGIN | END | USETIKZLIB | TIKZSTYLE | TIKZSET | NODE | DRAW | PATH | FILL | LPAR | RPAR | LBR | RBR | LBRR | RBRR | KOMMA | EQU | SEMIC | COLON | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | ID | INT | FLOAT_WO_EXP | COMMENT | WS | MATHSTRING | COMMAND | ESC_SEQ | SOMETHING );"; }
        }

    }


    protected internal int DFA15_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            IIntStream input = _input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA15_1 = input.LA(1);

                   	s = -1;
                   	if ( (LA15_1 == 'b') ) { s = 31; }

                   	else if ( (LA15_1 == 'e') ) { s = 32; }

                   	else if ( (LA15_1 == 'u') ) { s = 33; }

                   	else if ( (LA15_1 == 't') ) { s = 34; }

                   	else if ( (LA15_1 == 'n') ) { s = 35; }

                   	else if ( (LA15_1 == 'd') ) { s = 36; }

                   	else if ( (LA15_1 == 'p') ) { s = 37; }

                   	else if ( (LA15_1 == 'f') ) { s = 38; }

                   	else if ( ((LA15_1 >= 'A' && LA15_1 <= 'Z') || LA15_1 == '_' || LA15_1 == 'a' || LA15_1 == 'c' || (LA15_1 >= 'g' && LA15_1 <= 'm') || LA15_1 == 'o' || (LA15_1 >= 'q' && LA15_1 <= 's') || (LA15_1 >= 'v' && LA15_1 <= 'z')) ) { s = 39; }

                   	else if ( ((LA15_1 >= '\u0000' && LA15_1 <= '@') || (LA15_1 >= '[' && LA15_1 <= '^') || LA15_1 == '`' || (LA15_1 >= '{' && LA15_1 <= '\uFFFF')) ) { s = 40; }

                   	else s = 30;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA15_27 = input.LA(1);

                   	s = -1;
                   	if ( ((LA15_27 >= '\u0000' && LA15_27 <= '\uFFFF')) ) { s = 71; }

                   	else s = 30;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA15_29 = input.LA(1);

                   	s = -1;
                   	if ( ((LA15_29 >= '\u0000' && LA15_29 <= '\uFFFF')) ) { s = 73; }

                   	else s = 30;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA15_0 = input.LA(1);

                   	s = -1;
                   	if ( (LA15_0 == '\\') ) { s = 1; }

                   	else if ( (LA15_0 == '(') ) { s = 2; }

                   	else if ( (LA15_0 == ')') ) { s = 3; }

                   	else if ( (LA15_0 == '[') ) { s = 4; }

                   	else if ( (LA15_0 == ']') ) { s = 5; }

                   	else if ( (LA15_0 == '{') ) { s = 6; }

                   	else if ( (LA15_0 == '}') ) { s = 7; }

                   	else if ( (LA15_0 == ',') ) { s = 8; }

                   	else if ( (LA15_0 == '=') ) { s = 9; }

                   	else if ( (LA15_0 == ';') ) { s = 10; }

                   	else if ( (LA15_0 == ':') ) { s = 11; }

                   	else if ( (LA15_0 == '/') ) { s = 12; }

                   	else if ( (LA15_0 == 'c') ) { s = 13; }

                   	else if ( (LA15_0 == 'i') ) { s = 14; }

                   	else if ( (LA15_0 == 'e') ) { s = 15; }

                   	else if ( (LA15_0 == 'm') ) { s = 16; }

                   	else if ( (LA15_0 == 'p') ) { s = 17; }

                   	else if ( (LA15_0 == 'a') ) { s = 18; }

                   	else if ( (LA15_0 == '-') ) { s = 19; }

                   	else if ( (LA15_0 == '|') ) { s = 20; }

                   	else if ( (LA15_0 == '+') ) { s = 21; }

                   	else if ( (LA15_0 == 't') ) { s = 22; }

                   	else if ( (LA15_0 == 's') ) { s = 23; }

                   	else if ( ((LA15_0 >= 'A' && LA15_0 <= 'Z') || LA15_0 == '_' || LA15_0 == 'b' || LA15_0 == 'd' || (LA15_0 >= 'f' && LA15_0 <= 'h') || (LA15_0 >= 'j' && LA15_0 <= 'l') || (LA15_0 >= 'n' && LA15_0 <= 'o') || (LA15_0 >= 'q' && LA15_0 <= 'r') || (LA15_0 >= 'u' && LA15_0 <= 'z')) ) { s = 24; }

                   	else if ( ((LA15_0 >= '0' && LA15_0 <= '9')) ) { s = 25; }

                   	else if ( (LA15_0 == '.') ) { s = 26; }

                   	else if ( (LA15_0 == '%') ) { s = 27; }

                   	else if ( ((LA15_0 >= '\t' && LA15_0 <= '\n') || LA15_0 == '\r' || LA15_0 == ' ') ) { s = 28; }

                   	else if ( (LA15_0 == '$') ) { s = 29; }

                   	else if ( ((LA15_0 >= '\u0000' && LA15_0 <= '\b') || (LA15_0 >= '\u000B' && LA15_0 <= '\f') || (LA15_0 >= '\u000E' && LA15_0 <= '\u001F') || (LA15_0 >= '!' && LA15_0 <= '#') || (LA15_0 >= '&' && LA15_0 <= '\'') || LA15_0 == '*' || LA15_0 == '<' || (LA15_0 >= '>' && LA15_0 <= '@') || LA15_0 == '^' || LA15_0 == '`' || (LA15_0 >= '~' && LA15_0 <= '\uFFFF')) ) { s = 30; }

                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae15 =
            new NoViableAltException(dfa.Description, 15, _s, input);
        dfa.Error(nvae15);
        throw nvae15;
    }
 
    
}
