// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g 2010-12-24 01:59:50

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
    public const int EXPONENT = 50;
    public const int T__64 = 64;
    public const int T__65 = 65;
    public const int IM_STARTTAG = 33;
    public const int TIKZEDT_CMD_COMMENT = 44;
    public const int T__62 = 62;
    public const int T__63 = 63;
    public const int RBR = 17;
    public const int IM_PATH = 24;
    public const int IM_ID = 38;
    public const int SOMETHING = 54;
    public const int ID = 47;
    public const int T__61 = 61;
    public const int EOF = -1;
    public const int T__60 = 60;
    public const int MATHSTRING = 52;
    public const int LBR = 16;
    public const int COMMAND = 53;
    public const int IM_ENDTAG = 34;
    public const int IM_USETIKZLIB = 40;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int IM_DOCUMENT = 31;
    public const int T__58 = 58;
    public const int RBRR = 19;
    public const int ESC_SEQ = 51;
    public const int IM_STRING = 41;
    public const int LPAR = 14;
    public const int FILL = 12;
    public const int PATH = 11;
    public const int IM_TIKZSET = 39;
    public const int T__59 = 59;
    public const int BEGIN = 4;
    public const int IM_OPTION_KV = 37;
    public const int CLIP = 13;
    public const int COMMENT = 49;
    public const int IM_TIKZEDT_CMD = 43;
    public const int IM_OPTIONS = 35;
    public const int NODE = 9;
    public const int IM_OPTION_STYLE = 36;
    public const int TIKZSET = 8;
    public const int TIKZSTYLE = 7;
    public const int IM_COORD = 26;
    public const int IM_PICTURE = 30;
    public const int LBRR = 18;
    public const int INT = 45;
    public const int USETIKZLIB = 6;
    public const int IM_NODE = 25;
    public const int IM_STYLE = 42;
    public const int COLON = 23;
    public const int IM_NUMBERUNIT = 29;
    public const int IM_SCOPE = 32;
    public const int T__71 = 71;
    public const int WS = 48;
    public const int T__72 = 72;
    public const int T__70 = 70;
    public const int KOMMA = 20;
    public const int EQU = 21;
    public const int IM_SIZE = 27;
    public const int RPAR = 15;
    public const int SEMIC = 22;
    public const int END = 5;
    public const int T__75 = 75;
    public const int T__74 = 74;
    public const int T__73 = 73;
    public const int IM_NODENAME = 28;
    public const int DRAW = 10;
    public const int FLOAT_WO_EXP = 46;

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

    // $ANTLR start "BEGIN"
    public void mBEGIN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BEGIN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:7:7: ( '\\\\begin' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:7:9: '\\\\begin'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:8:5: ( '\\\\end' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:8:7: '\\\\end'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:9:12: ( '\\\\usetikzlibrary' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:9:14: '\\\\usetikzlibrary'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:10:11: ( '\\\\tikzstyle' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:10:13: '\\\\tikzstyle'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:11:9: ( '\\\\tikzset' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:11:11: '\\\\tikzset'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:12:6: ( '\\\\node' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:12:8: '\\\\node'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:13:6: ( '\\\\draw' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:13:8: '\\\\draw'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:14:6: ( '\\\\path' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:14:8: '\\\\path'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:15:6: ( '\\\\fill' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:15:8: '\\\\fill'
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

    // $ANTLR start "CLIP"
    public void mCLIP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CLIP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:16:6: ( '\\\\clip' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:16:8: '\\\\clip'
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
    // $ANTLR end "CLIP"

    // $ANTLR start "LPAR"
    public void mLPAR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LPAR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:17:6: ( '(' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:17:8: '('
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:18:6: ( ')' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:18:8: ')'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:19:5: ( '[' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:19:7: '['
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:20:5: ( ']' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:20:7: ']'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:21:6: ( '{' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:21:8: '{'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:22:6: ( '}' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:22:8: '}'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:23:7: ( ',' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:23:9: ','
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:24:5: ( '=' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:24:7: '='
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:25:7: ( ';' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:25:9: ';'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:26:7: ( ':' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:26:9: ':'
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

    // $ANTLR start "T__55"
    public void mT__55() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__55;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:27:7: ( '/.style' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:27:9: '/.style'
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
    // $ANTLR end "T__55"

    // $ANTLR start "T__56"
    public void mT__56() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__56;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:28:7: ( 'cm' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:28:9: 'cm'
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
    // $ANTLR end "T__56"

    // $ANTLR start "T__57"
    public void mT__57() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__57;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:29:7: ( 'in' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:29:9: 'in'
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
    // $ANTLR end "T__57"

    // $ANTLR start "T__58"
    public void mT__58() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__58;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:30:7: ( 'ex' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:30:9: 'ex'
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
    // $ANTLR end "T__58"

    // $ANTLR start "T__59"
    public void mT__59() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__59;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:31:7: ( 'mm' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:31:9: 'mm'
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
    // $ANTLR end "T__59"

    // $ANTLR start "T__60"
    public void mT__60() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__60;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:32:7: ( 'pt' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:32:9: 'pt'
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
    // $ANTLR end "T__60"

    // $ANTLR start "T__61"
    public void mT__61() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__61;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:33:7: ( 'em' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:33:9: 'em'
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
    // $ANTLR end "T__61"

    // $ANTLR start "T__62"
    public void mT__62() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__62;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:34:7: ( 'node' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:34:9: 'node'
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
    // $ANTLR end "T__62"

    // $ANTLR start "T__63"
    public void mT__63() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__63;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:35:7: ( 'at' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:35:9: 'at'
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
    // $ANTLR end "T__63"

    // $ANTLR start "T__64"
    public void mT__64() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__64;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:36:7: ( 'circle' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:36:9: 'circle'
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
    // $ANTLR end "T__64"

    // $ANTLR start "T__65"
    public void mT__65() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__65;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:37:7: ( 'ellipse' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:37:9: 'ellipse'
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
    // $ANTLR end "T__65"

    // $ANTLR start "T__66"
    public void mT__66() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__66;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:38:7: ( 'arc' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:38:9: 'arc'
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
    // $ANTLR end "T__66"

    // $ANTLR start "T__67"
    public void mT__67() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__67;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:39:7: ( 'and' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:39:9: 'and'
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
    // $ANTLR end "T__67"

    // $ANTLR start "T__68"
    public void mT__68() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__68;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:40:7: ( '--' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:40:9: '--'
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
    // $ANTLR end "T__68"

    // $ANTLR start "T__69"
    public void mT__69() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__69;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:41:7: ( '->' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:41:9: '->'
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
    // $ANTLR end "T__69"

    // $ANTLR start "T__70"
    public void mT__70() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__70;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:42:7: ( '|-' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:42:9: '|-'
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
    // $ANTLR end "T__70"

    // $ANTLR start "T__71"
    public void mT__71() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__71;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:43:7: ( '-|' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:43:9: '-|'
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
    // $ANTLR end "T__71"

    // $ANTLR start "T__72"
    public void mT__72() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__72;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:44:7: ( '+' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:44:9: '+'
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
    // $ANTLR end "T__72"

    // $ANTLR start "T__73"
    public void mT__73() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__73;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:45:7: ( '++' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:45:9: '++'
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
    // $ANTLR end "T__73"

    // $ANTLR start "T__74"
    public void mT__74() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__74;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:46:7: ( 'tikzpicture' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:46:9: 'tikzpicture'
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
    // $ANTLR end "T__74"

    // $ANTLR start "T__75"
    public void mT__75() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__75;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:47:7: ( 'scope' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:47:9: 'scope'
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
    // $ANTLR end "T__75"

    // $ANTLR start "ID"
    public void mID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:376:5: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' | '!' )* )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:376:7: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' | '!' )*
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

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:376:31: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' | '!' )*
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:379:5: ( ( '-' )? ( '0' .. '9' )+ )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:379:7: ( '-' )? ( '0' .. '9' )+
            {
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:379:7: ( '-' )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == '-') )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:379:7: '-'
            	        {
            	        	Match('-'); 

            	        }
            	        break;

            	}

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:379:12: ( '0' .. '9' )+
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
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:379:12: '0' .. '9'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:391:5: ( ( '-' )? ( '0' .. '9' )+ '.' ( '0' .. '9' )* | ( '-' )? '.' ( '0' .. '9' )+ )
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
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:391:9: ( '-' )? ( '0' .. '9' )+ '.' ( '0' .. '9' )*
                    {
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:391:9: ( '-' )?
                    	int alt4 = 2;
                    	int LA4_0 = input.LA(1);

                    	if ( (LA4_0 == '-') )
                    	{
                    	    alt4 = 1;
                    	}
                    	switch (alt4) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:391:9: '-'
                    	        {
                    	        	Match('-'); 

                    	        }
                    	        break;

                    	}

                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:391:14: ( '0' .. '9' )+
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
                    			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:391:15: '0' .. '9'
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
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:391:30: ( '0' .. '9' )*
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
                    			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:391:31: '0' .. '9'
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
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:392:9: ( '-' )? '.' ( '0' .. '9' )+
                    {
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:392:9: ( '-' )?
                    	int alt7 = 2;
                    	int LA7_0 = input.LA(1);

                    	if ( (LA7_0 == '-') )
                    	{
                    	    alt7 = 1;
                    	}
                    	switch (alt7) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:392:9: '-'
                    	        {
                    	        	Match('-'); 

                    	        }
                    	        break;

                    	}

                    	Match('.'); 
                    	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:392:18: ( '0' .. '9' )+
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
                    			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:392:19: '0' .. '9'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:396:5: ( '%' WS '!TIKZEDT' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:396:9: '%' WS '!TIKZEDT' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
            {
            	Match('%'); 
            	mWS(); 
            	Match("!TIKZEDT"); 

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:396:29: (~ ( '\\n' | '\\r' ) )*
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
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:396:29: ~ ( '\\n' | '\\r' )
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

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:396:43: ( '\\r' )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == '\r') )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:396:43: '\\r'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:400:5: ( '%' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:400:9: '%' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
            {
            	Match('%'); 
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:400:13: (~ ( '\\n' | '\\r' ) )*
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
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:400:13: ~ ( '\\n' | '\\r' )
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

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:400:27: ( '\\r' )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == '\r') )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:400:27: '\\r'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:403:5: ( ( ' ' | '\\t' | '\\r' | '\\n' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:403:9: ( ' ' | '\\t' | '\\r' | '\\n' )
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:410:19: ( ( 'e' | 'E' ) ( '+' | '-' )? ( '0' .. '9' )+ )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:410:21: ( 'e' | 'E' ) ( '+' | '-' )? ( '0' .. '9' )+
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

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:410:31: ( '+' | '-' )?
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

            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:410:42: ( '0' .. '9' )+
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
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:410:43: '0' .. '9'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:417:2: ( '$' ( ESC_SEQ | ~ ( '\\\\' | '$' ) )* '$' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:417:4: '$' ( ESC_SEQ | ~ ( '\\\\' | '$' ) )* '$'
            {
            	Match('$'); 
            	// C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:417:8: ( ESC_SEQ | ~ ( '\\\\' | '$' ) )*
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
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:417:10: ESC_SEQ
            			    {
            			    	mESC_SEQ(); 

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:417:20: ~ ( '\\\\' | '$' )
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:428:2: ( '\\\\' ID )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:428:4: '\\\\' ID
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:433:5: ( '\\\\' . )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:433:9: '\\\\' .
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:439:2: ( . )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:439:4: .
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
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:8: ( BEGIN | END | USETIKZLIB | TIKZSTYLE | TIKZSET | NODE | DRAW | PATH | FILL | CLIP | LPAR | RPAR | LBR | RBR | LBRR | RBRR | KOMMA | EQU | SEMIC | COLON | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | ID | INT | FLOAT_WO_EXP | TIKZEDT_CMD_COMMENT | COMMENT | WS | MATHSTRING | COMMAND | ESC_SEQ | SOMETHING )
        int alt17 = 51;
        alt17 = dfa17.Predict(input);
        switch (alt17) 
        {
            case 1 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:10: BEGIN
                {
                	mBEGIN(); 

                }
                break;
            case 2 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:16: END
                {
                	mEND(); 

                }
                break;
            case 3 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:20: USETIKZLIB
                {
                	mUSETIKZLIB(); 

                }
                break;
            case 4 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:31: TIKZSTYLE
                {
                	mTIKZSTYLE(); 

                }
                break;
            case 5 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:41: TIKZSET
                {
                	mTIKZSET(); 

                }
                break;
            case 6 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:49: NODE
                {
                	mNODE(); 

                }
                break;
            case 7 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:54: DRAW
                {
                	mDRAW(); 

                }
                break;
            case 8 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:59: PATH
                {
                	mPATH(); 

                }
                break;
            case 9 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:64: FILL
                {
                	mFILL(); 

                }
                break;
            case 10 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:69: CLIP
                {
                	mCLIP(); 

                }
                break;
            case 11 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:74: LPAR
                {
                	mLPAR(); 

                }
                break;
            case 12 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:79: RPAR
                {
                	mRPAR(); 

                }
                break;
            case 13 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:84: LBR
                {
                	mLBR(); 

                }
                break;
            case 14 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:88: RBR
                {
                	mRBR(); 

                }
                break;
            case 15 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:92: LBRR
                {
                	mLBRR(); 

                }
                break;
            case 16 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:97: RBRR
                {
                	mRBRR(); 

                }
                break;
            case 17 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:102: KOMMA
                {
                	mKOMMA(); 

                }
                break;
            case 18 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:108: EQU
                {
                	mEQU(); 

                }
                break;
            case 19 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:112: SEMIC
                {
                	mSEMIC(); 

                }
                break;
            case 20 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:118: COLON
                {
                	mCOLON(); 

                }
                break;
            case 21 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:124: T__55
                {
                	mT__55(); 

                }
                break;
            case 22 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:130: T__56
                {
                	mT__56(); 

                }
                break;
            case 23 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:136: T__57
                {
                	mT__57(); 

                }
                break;
            case 24 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:142: T__58
                {
                	mT__58(); 

                }
                break;
            case 25 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:148: T__59
                {
                	mT__59(); 

                }
                break;
            case 26 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:154: T__60
                {
                	mT__60(); 

                }
                break;
            case 27 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:160: T__61
                {
                	mT__61(); 

                }
                break;
            case 28 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:166: T__62
                {
                	mT__62(); 

                }
                break;
            case 29 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:172: T__63
                {
                	mT__63(); 

                }
                break;
            case 30 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:178: T__64
                {
                	mT__64(); 

                }
                break;
            case 31 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:184: T__65
                {
                	mT__65(); 

                }
                break;
            case 32 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:190: T__66
                {
                	mT__66(); 

                }
                break;
            case 33 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:196: T__67
                {
                	mT__67(); 

                }
                break;
            case 34 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:202: T__68
                {
                	mT__68(); 

                }
                break;
            case 35 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:208: T__69
                {
                	mT__69(); 

                }
                break;
            case 36 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:214: T__70
                {
                	mT__70(); 

                }
                break;
            case 37 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:220: T__71
                {
                	mT__71(); 

                }
                break;
            case 38 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:226: T__72
                {
                	mT__72(); 

                }
                break;
            case 39 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:232: T__73
                {
                	mT__73(); 

                }
                break;
            case 40 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:238: T__74
                {
                	mT__74(); 

                }
                break;
            case 41 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:244: T__75
                {
                	mT__75(); 

                }
                break;
            case 42 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:250: ID
                {
                	mID(); 

                }
                break;
            case 43 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:253: INT
                {
                	mINT(); 

                }
                break;
            case 44 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:257: FLOAT_WO_EXP
                {
                	mFLOAT_WO_EXP(); 

                }
                break;
            case 45 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:270: TIKZEDT_CMD_COMMENT
                {
                	mTIKZEDT_CMD_COMMENT(); 

                }
                break;
            case 46 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:290: COMMENT
                {
                	mCOMMENT(); 

                }
                break;
            case 47 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:298: WS
                {
                	mWS(); 

                }
                break;
            case 48 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:301: MATHSTRING
                {
                	mMATHSTRING(); 

                }
                break;
            case 49 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:312: COMMAND
                {
                	mCOMMAND(); 

                }
                break;
            case 50 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:320: ESC_SEQ
                {
                	mESC_SEQ(); 

                }
                break;
            case 51 :
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:328: SOMETHING
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
        "\x01\uffff\x01\x1f\x0a\uffff\x01\x1f\x07\x38\x02\x1f\x01\x4a\x02"+
        "\x38\x01\uffff\x01\x4d\x02\x1f\x01\uffff\x01\x1f\x01\uffff\x09\x55"+
        "\x0d\uffff\x01\x5e\x01\x38\x01\uffff\x01\x60\x01\x61\x01\x62\x01"+
        "\x38\x01\x64\x01\x65\x01\x38\x01\x67\x02\x38\x03\uffff\x01\x4d\x04"+
        "\uffff\x02\x38\x03\uffff\x01\x51\x03\uffff\x01\x55\x01\uffff\x08"+
        "\x55\x01\uffff\x01\x38\x03\uffff\x01\x38\x02\uffff\x01\x38\x01\uffff"+
        "\x01\x7a\x01\x7b\x02\x38\x02\uffff\x01\x55\x01\u0080\x07\x55\x02"+
        "\x38\x01\u008a\x02\uffff\x02\x38\x01\uffff\x01\x55\x01\uffff\x02"+
        "\x55\x01\u0091\x01\u0092\x01\u0093\x01\u0094\x01\u0095\x02\x38\x01"+
        "\uffff\x01\x38\x01\u0099\x01\uffff\x01\u009b\x02\x55\x05\uffff\x01"+
        "\u009f\x02\x38\x03\uffff\x03\x55\x01\uffff\x01\u00a6\x01\x38\x01"+
        "\uffff\x02\x55\x01\u00ab\x01\uffff\x01\x38\x01\uffff\x02\x55\x01"+
        "\uffff\x01\x38\x01\uffff\x01\x55\x01\u00b3\x01\x38\x01\uffff\x01"+
        "\x55\x01\uffff\x01\u00b9\x03\uffff\x01\x55\x01\uffff\x02\x55\x01"+
        "\u00bd\x01\uffff";
    const string DFA17_eofS =
        "\u00be\uffff";
    const string DFA17_minS =
        "\x02\x00\x0a\uffff\x01\x2e\x01\x69\x01\x6e\x01\x6c\x01\x6d\x01"+
        "\x74\x01\x6f\x01\x6e\x02\x2d\x01\x2b\x01\x69\x01\x63\x01\uffff\x01"+
        "\x2e\x01\x30\x01\x00\x01\uffff\x01\x00\x01\uffff\x01\x65\x01\x6e"+
        "\x01\x73\x01\x69\x01\x6f\x01\x72\x01\x61\x01\x69\x01\x6c\x0d\uffff"+
        "\x01\x21\x01\x72\x01\uffff\x03\x21\x01\x6c\x02\x21\x01\x64\x01\x21"+
        "\x01\x63\x01\x64\x03\uffff\x01\x2e\x04\uffff\x01\x6b\x01\x6f\x01"+
        "\uffff\x01\x00\x01\x0a\x01\x21\x03\uffff\x01\x67\x01\uffff\x01\x64"+
        "\x01\x65\x01\x6b\x01\x64\x01\x61\x01\x74\x01\x6c\x01\x69\x01\uffff"+
        "\x01\x63\x03\uffff\x01\x69\x02\uffff\x01\x65\x01\uffff\x02\x21\x01"+
        "\x7a\x01\x70\x01\x00\x01\uffff\x01\x69\x01\x21\x01\x74\x01\x7a\x01"+
        "\x65\x01\x77\x01\x68\x01\x6c\x01\x70\x01\x6c\x01\x70\x01\x21\x02"+
        "\uffff\x01\x70\x01\x65\x01\x00\x01\x6e\x01\uffff\x01\x69\x01\x73"+
        "\x05\x21\x01\x65\x01\x73\x01\uffff\x01\x69\x01\x21\x01\x00\x01\x21"+
        "\x01\x6b\x01\x65\x05\uffff\x01\x21\x01\x65\x01\x63\x01\uffff\x01"+
        "\x00\x01\uffff\x01\x7a\x01\x79\x01\x74\x01\uffff\x01\x21\x01\x74"+
        "\x01\x00\x02\x6c\x01\x21\x01\uffff\x01\x75\x01\x00\x01\x69\x01\x65"+
        "\x01\uffff\x01\x72\x01\x00\x01\x62\x01\x21\x01\x65\x01\x00\x01\x72"+
        "\x01\uffff\x01\x21\x01\x00\x01\x0a\x01\uffff\x01\x61\x01\uffff\x01"+
        "\x72\x01\x79\x01\x21\x01\uffff";
    const string DFA17_maxS =
        "\x02\uffff\x0a\uffff\x01\x2e\x01\x6d\x01\x6e\x01\x78\x01\x6d\x01"+
        "\x74\x01\x6f\x01\x74\x01\x7c\x01\x2d\x01\x2b\x01\x69\x01\x63\x01"+
        "\uffff\x02\x39\x01\uffff\x01\uffff\x01\uffff\x01\uffff\x01\x65\x01"+
        "\x6e\x01\x73\x01\x69\x01\x6f\x01\x72\x01\x61\x01\x69\x01\x6c\x0d"+
        "\uffff\x01\x7a\x01\x72\x01\uffff\x03\x7a\x01\x6c\x02\x7a\x01\x64"+
        "\x01\x7a\x01\x63\x01\x64\x03\uffff\x01\x39\x04\uffff\x01\x6b\x01"+
        "\x6f\x01\uffff\x01\uffff\x02\x21\x03\uffff\x01\x67\x01\uffff\x01"+
        "\x64\x01\x65\x01\x6b\x01\x64\x01\x61\x01\x74\x01\x6c\x01\x69\x01"+
        "\uffff\x01\x63\x03\uffff\x01\x69\x02\uffff\x01\x65\x01\uffff\x03"+
        "\x7a\x01\x70\x01\uffff\x01\uffff\x01\x69\x01\x7a\x01\x74\x01\x7a"+
        "\x01\x65\x01\x77\x01\x68\x01\x6c\x01\x70\x01\x6c\x01\x70\x01\x7a"+
        "\x02\uffff\x01\x70\x01\x65\x01\uffff\x01\x6e\x01\uffff\x01\x69\x01"+
        "\x73\x05\x7a\x01\x65\x01\x73\x01\uffff\x01\x69\x01\x7a\x01\uffff"+
        "\x01\x7a\x01\x6b\x01\x74\x05\uffff\x01\x7a\x01\x65\x01\x63\x01\uffff"+
        "\x01\uffff\x01\uffff\x01\x7a\x01\x79\x01\x74\x01\uffff\x01\x7a\x01"+
        "\x74\x01\uffff\x02\x6c\x01\x7a\x01\uffff\x01\x75\x01\uffff\x01\x69"+
        "\x01\x65\x01\uffff\x01\x72\x01\uffff\x01\x62\x01\x7a\x01\x65\x01"+
        "\uffff\x01\x72\x01\uffff\x01\x7a\x01\uffff\x01\x0a\x01\uffff\x01"+
        "\x61\x01\uffff\x01\x72\x01\x79\x01\x7a\x01\uffff";
    const string DFA17_acceptS =
        "\x02\uffff\x01\x0b\x01\x0c\x01\x0d\x01\x0e\x01\x0f\x01\x10\x01"+
        "\x11\x01\x12\x01\x13\x01\x14\x0d\uffff\x01\x2a\x03\uffff\x01\x2f"+
        "\x01\uffff\x01\x33\x09\uffff\x01\x31\x01\x32\x01\x0b\x01\x0c\x01"+
        "\x0d\x01\x0e\x01\x0f\x01\x10\x01\x11\x01\x12\x01\x13\x01\x14\x01"+
        "\x15\x02\uffff\x01\x2a\x0a\uffff\x01\x22\x01\x23\x01\x25\x01\uffff"+
        "\x01\x2c\x01\x24\x01\x27\x01\x26\x02\uffff\x01\x2b\x03\uffff\x01"+
        "\x2e\x01\x2f\x01\x30\x01\uffff\x01\x31\x08\uffff\x01\x16\x01\uffff"+
        "\x01\x17\x01\x18\x01\x1b\x01\uffff\x01\x19\x01\x1a\x01\uffff\x01"+
        "\x1d\x05\uffff\x01\x2d\x0c\uffff\x01\x20\x01\x21\x04\uffff\x01\x02"+
        "\x09\uffff\x01\x1c\x06\uffff\x01\x06\x01\x07\x01\x08\x01\x09\x01"+
        "\x0a\x03\uffff\x01\x29\x01\uffff\x01\x01\x03\uffff\x01\x1e\x06\uffff"+
        "\x01\x1f\x04\uffff\x01\x05\x07\uffff\x01\x04\x03\uffff\x01\x2d\x01"+
        "\uffff\x01\x28\x03\uffff\x01\x03";
    const string DFA17_specialS =
        "\x01\x01\x01\x00\x1a\uffff\x01\x02\x01\uffff\x01\x0c\x2f\uffff"+
        "\x01\x0a\x1d\uffff\x01\x03\x11\uffff\x01\x04\x0e\uffff\x01\x05\x0c"+
        "\uffff\x01\x06\x07\uffff\x01\x07\x05\uffff\x01\x08\x04\uffff\x01"+
        "\x09\x03\uffff\x01\x0b\x03\uffff\x01\x0d\x08\uffff}>";
    static readonly string[] DFA17_transitionS = {
            "\x09\x1f\x02\x1d\x02\x1f\x01\x1d\x12\x1f\x01\x1d\x03\x1f\x01"+
            "\x1e\x01\x1c\x02\x1f\x01\x02\x01\x03\x01\x1f\x01\x16\x01\x08"+
            "\x01\x14\x01\x1b\x01\x0c\x0a\x1a\x01\x0b\x01\x0a\x01\x1f\x01"+
            "\x09\x03\x1f\x1a\x19\x01\x04\x01\x01\x01\x05\x01\x1f\x01\x19"+
            "\x01\x1f\x01\x13\x01\x19\x01\x0d\x01\x19\x01\x0f\x03\x19\x01"+
            "\x0e\x03\x19\x01\x10\x01\x12\x01\x19\x01\x11\x02\x19\x01\x18"+
            "\x01\x17\x06\x19\x01\x06\x01\x15\x01\x07\uff82\x1f",
            "\x41\x2a\x1a\x29\x04\x2a\x01\x29\x01\x2a\x01\x29\x01\x20\x01"+
            "\x28\x01\x25\x01\x21\x01\x27\x07\x29\x01\x24\x01\x29\x01\x26"+
            "\x03\x29\x01\x23\x01\x22\x05\x29\uff85\x2a",
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
            "\x01\x37\x03\uffff\x01\x36",
            "\x01\x39",
            "\x01\x3c\x01\x3b\x0a\uffff\x01\x3a",
            "\x01\x3d",
            "\x01\x3e",
            "\x01\x3f",
            "\x01\x42\x03\uffff\x01\x41\x01\uffff\x01\x40",
            "\x01\x43\x01\x47\x01\uffff\x0a\x46\x04\uffff\x01\x44\x3d\uffff"+
            "\x01\x45",
            "\x01\x48",
            "\x01\x49",
            "\x01\x4b",
            "\x01\x4c",
            "",
            "\x01\x47\x01\uffff\x0a\x46",
            "\x0a\x47",
            "\x09\x51\x01\x4e\x01\x50\x02\x51\x01\x4f\x12\x51\x01\x4e\uffdf"+
            "\x51",
            "",
            "\x00\x53",
            "",
            "\x01\x54",
            "\x01\x56",
            "\x01\x57",
            "\x01\x58",
            "\x01\x59",
            "\x01\x5a",
            "\x01\x5b",
            "\x01\x5c",
            "\x01\x5d",
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
            "\x01\x38\x0c\uffff\x01\x38\x01\uffff\x0a\x38\x07\uffff\x1a"+
            "\x38\x04\uffff\x01\x38\x01\uffff\x1a\x38",
            "\x01\x5f",
            "",
            "\x01\x38\x0c\uffff\x01\x38\x01\uffff\x0a\x38\x07\uffff\x1a"+
            "\x38\x04\uffff\x01\x38\x01\uffff\x1a\x38",
            "\x01\x38\x0c\uffff\x01\x38\x01\uffff\x0a\x38\x07\uffff\x1a"+
            "\x38\x04\uffff\x01\x38\x01\uffff\x1a\x38",
            "\x01\x38\x0c\uffff\x01\x38\x01\uffff\x0a\x38\x07\uffff\x1a"+
            "\x38\x04\uffff\x01\x38\x01\uffff\x1a\x38",
            "\x01\x63",
            "\x01\x38\x0c\uffff\x01\x38\x01\uffff\x0a\x38\x07\uffff\x1a"+
            "\x38\x04\uffff\x01\x38\x01\uffff\x1a\x38",
            "\x01\x38\x0c\uffff\x01\x38\x01\uffff\x0a\x38\x07\uffff\x1a"+
            "\x38\x04\uffff\x01\x38\x01\uffff\x1a\x38",
            "\x01\x66",
            "\x01\x38\x0c\uffff\x01\x38\x01\uffff\x0a\x38\x07\uffff\x1a"+
            "\x38\x04\uffff\x01\x38\x01\uffff\x1a\x38",
            "\x01\x68",
            "\x01\x69",
            "",
            "",
            "",
            "\x01\x47\x01\uffff\x0a\x46",
            "",
            "",
            "",
            "",
            "\x01\x6a",
            "\x01\x6b",
            "",
            "\x21\x51\x01\x6c\uffde\x51",
            "\x01\x51\x16\uffff\x01\x6d",
            "\x01\x6d",
            "",
            "",
            "",
            "\x01\x6e",
            "",
            "\x01\x6f",
            "\x01\x70",
            "\x01\x71",
            "\x01\x72",
            "\x01\x73",
            "\x01\x74",
            "\x01\x75",
            "\x01\x76",
            "",
            "\x01\x77",
            "",
            "",
            "",
            "\x01\x78",
            "",
            "",
            "\x01\x79",
            "",
            "\x01\x38\x0c\uffff\x01\x38\x01\uffff\x0a\x38\x07\uffff\x1a"+
            "\x38\x04\uffff\x01\x38\x01\uffff\x1a\x38",
            "\x01\x38\x0c\uffff\x01\x38\x01\uffff\x0a\x38\x07\uffff\x1a"+
            "\x38\x04\uffff\x01\x38\x01\uffff\x1a\x38",
            "\x01\x7c",
            "\x01\x7d",
            "\x54\x51\x01\x7e\uffab\x51",
            "",
            "\x01\x7f",
            "\x01\x55\x0c\uffff\x01\x55\x01\uffff\x0a\x55\x07\uffff\x1a"+
            "\x55\x04\uffff\x01\x55\x01\uffff\x1a\x55",
            "\x01\u0081",
            "\x01\u0082",
            "\x01\u0083",
            "\x01\u0084",
            "\x01\u0085",
            "\x01\u0086",
            "\x01\u0087",
            "\x01\u0088",
            "\x01\u0089",
            "\x01\x38\x0c\uffff\x01\x38\x01\uffff\x0a\x38\x07\uffff\x1a"+
            "\x38\x04\uffff\x01\x38\x01\uffff\x1a\x38",
            "",
            "",
            "\x01\u008b",
            "\x01\u008c",
            "\x49\x51\x01\u008d\uffb6\x51",
            "\x01\u008e",
            "",
            "\x01\u008f",
            "\x01\u0090",
            "\x01\x55\x0c\uffff\x01\x55\x01\uffff\x0a\x55\x07\uffff\x1a"+
            "\x55\x04\uffff\x01\x55\x01\uffff\x1a\x55",
            "\x01\x55\x0c\uffff\x01\x55\x01\uffff\x0a\x55\x07\uffff\x1a"+
            "\x55\x04\uffff\x01\x55\x01\uffff\x1a\x55",
            "\x01\x55\x0c\uffff\x01\x55\x01\uffff\x0a\x55\x07\uffff\x1a"+
            "\x55\x04\uffff\x01\x55\x01\uffff\x1a\x55",
            "\x01\x55\x0c\uffff\x01\x55\x01\uffff\x0a\x55\x07\uffff\x1a"+
            "\x55\x04\uffff\x01\x55\x01\uffff\x1a\x55",
            "\x01\x55\x0c\uffff\x01\x55\x01\uffff\x0a\x55\x07\uffff\x1a"+
            "\x55\x04\uffff\x01\x55\x01\uffff\x1a\x55",
            "\x01\u0096",
            "\x01\u0097",
            "",
            "\x01\u0098",
            "\x01\x38\x0c\uffff\x01\x38\x01\uffff\x0a\x38\x07\uffff\x1a"+
            "\x38\x04\uffff\x01\x38\x01\uffff\x1a\x38",
            "\x4b\x51\x01\u009a\uffb4\x51",
            "\x01\x55\x0c\uffff\x01\x55\x01\uffff\x0a\x55\x07\uffff\x1a"+
            "\x55\x04\uffff\x01\x55\x01\uffff\x1a\x55",
            "\x01\u009c",
            "\x01\u009e\x0e\uffff\x01\u009d",
            "",
            "",
            "",
            "",
            "",
            "\x01\x38\x0c\uffff\x01\x38\x01\uffff\x0a\x38\x07\uffff\x1a"+
            "\x38\x04\uffff\x01\x38\x01\uffff\x1a\x38",
            "\x01\u00a0",
            "\x01\u00a1",
            "",
            "\x5a\x51\x01\u00a2\uffa5\x51",
            "",
            "\x01\u00a3",
            "\x01\u00a4",
            "\x01\u00a5",
            "",
            "\x01\x38\x0c\uffff\x01\x38\x01\uffff\x0a\x38\x07\uffff\x1a"+
            "\x38\x04\uffff\x01\x38\x01\uffff\x1a\x38",
            "\x01\u00a7",
            "\x45\x51\x01\u00a8\uffba\x51",
            "\x01\u00a9",
            "\x01\u00aa",
            "\x01\x55\x0c\uffff\x01\x55\x01\uffff\x0a\x55\x07\uffff\x1a"+
            "\x55\x04\uffff\x01\x55\x01\uffff\x1a\x55",
            "",
            "\x01\u00ac",
            "\x44\x51\x01\u00ad\uffbb\x51",
            "\x01\u00ae",
            "\x01\u00af",
            "",
            "\x01\u00b0",
            "\x54\x51\x01\u00b1\uffab\x51",
            "\x01\u00b2",
            "\x01\x55\x0c\uffff\x01\x55\x01\uffff\x0a\x55\x07\uffff\x1a"+
            "\x55\x04\uffff\x01\x55\x01\uffff\x1a\x55",
            "\x01\u00b4",
            "\x0a\u00b5\x01\u00b7\x02\u00b5\x01\u00b6\ufff2\u00b5",
            "\x01\u00b8",
            "",
            "\x01\x38\x0c\uffff\x01\x38\x01\uffff\x0a\x38\x07\uffff\x1a"+
            "\x38\x04\uffff\x01\x38\x01\uffff\x1a\x38",
            "\x0a\u00b5\x01\u00b7\x02\u00b5\x01\u00b6\ufff2\u00b5",
            "\x01\u00b7",
            "",
            "\x01\u00ba",
            "",
            "\x01\u00bb",
            "\x01\u00bc",
            "\x01\x55\x0c\uffff\x01\x55\x01\uffff\x0a\x55\x07\uffff\x1a"+
            "\x55\x04\uffff\x01\x55\x01\uffff\x1a\x55",
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
            get { return "1:1: Tokens : ( BEGIN | END | USETIKZLIB | TIKZSTYLE | TIKZSET | NODE | DRAW | PATH | FILL | CLIP | LPAR | RPAR | LBR | RBR | LBRR | RBRR | KOMMA | EQU | SEMIC | COLON | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | ID | INT | FLOAT_WO_EXP | TIKZEDT_CMD_COMMENT | COMMENT | WS | MATHSTRING | COMMAND | ESC_SEQ | SOMETHING );"; }
        }

    }


    protected internal int DFA17_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            IIntStream input = _input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
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

                   	else if ( (LA17_1 == 'c') ) { s = 40; }

                   	else if ( ((LA17_1 >= 'A' && LA17_1 <= 'Z') || LA17_1 == '_' || LA17_1 == 'a' || (LA17_1 >= 'g' && LA17_1 <= 'm') || LA17_1 == 'o' || (LA17_1 >= 'q' && LA17_1 <= 's') || (LA17_1 >= 'v' && LA17_1 <= 'z')) ) { s = 41; }

                   	else if ( ((LA17_1 >= '\u0000' && LA17_1 <= '@') || (LA17_1 >= '[' && LA17_1 <= '^') || LA17_1 == '`' || (LA17_1 >= '{' && LA17_1 <= '\uFFFF')) ) { s = 42; }

                   	else s = 31;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
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

                   	else if ( (LA17_0 == '/') ) { s = 12; }

                   	else if ( (LA17_0 == 'c') ) { s = 13; }

                   	else if ( (LA17_0 == 'i') ) { s = 14; }

                   	else if ( (LA17_0 == 'e') ) { s = 15; }

                   	else if ( (LA17_0 == 'm') ) { s = 16; }

                   	else if ( (LA17_0 == 'p') ) { s = 17; }

                   	else if ( (LA17_0 == 'n') ) { s = 18; }

                   	else if ( (LA17_0 == 'a') ) { s = 19; }

                   	else if ( (LA17_0 == '-') ) { s = 20; }

                   	else if ( (LA17_0 == '|') ) { s = 21; }

                   	else if ( (LA17_0 == '+') ) { s = 22; }

                   	else if ( (LA17_0 == 't') ) { s = 23; }

                   	else if ( (LA17_0 == 's') ) { s = 24; }

                   	else if ( ((LA17_0 >= 'A' && LA17_0 <= 'Z') || LA17_0 == '_' || LA17_0 == 'b' || LA17_0 == 'd' || (LA17_0 >= 'f' && LA17_0 <= 'h') || (LA17_0 >= 'j' && LA17_0 <= 'l') || LA17_0 == 'o' || (LA17_0 >= 'q' && LA17_0 <= 'r') || (LA17_0 >= 'u' && LA17_0 <= 'z')) ) { s = 25; }

                   	else if ( ((LA17_0 >= '0' && LA17_0 <= '9')) ) { s = 26; }

                   	else if ( (LA17_0 == '.') ) { s = 27; }

                   	else if ( (LA17_0 == '%') ) { s = 28; }

                   	else if ( ((LA17_0 >= '\t' && LA17_0 <= '\n') || LA17_0 == '\r' || LA17_0 == ' ') ) { s = 29; }

                   	else if ( (LA17_0 == '$') ) { s = 30; }

                   	else if ( ((LA17_0 >= '\u0000' && LA17_0 <= '\b') || (LA17_0 >= '\u000B' && LA17_0 <= '\f') || (LA17_0 >= '\u000E' && LA17_0 <= '\u001F') || (LA17_0 >= '!' && LA17_0 <= '#') || (LA17_0 >= '&' && LA17_0 <= '\'') || LA17_0 == '*' || LA17_0 == '<' || (LA17_0 >= '>' && LA17_0 <= '@') || LA17_0 == '^' || LA17_0 == '`' || (LA17_0 >= '~' && LA17_0 <= '\uFFFF')) ) { s = 31; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA17_28 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_28 == '\t' || LA17_28 == ' ') ) { s = 78; }

                   	else if ( (LA17_28 == '\r') ) { s = 79; }

                   	else if ( (LA17_28 == '\n') ) { s = 80; }

                   	else if ( ((LA17_28 >= '\u0000' && LA17_28 <= '\b') || (LA17_28 >= '\u000B' && LA17_28 <= '\f') || (LA17_28 >= '\u000E' && LA17_28 <= '\u001F') || (LA17_28 >= '!' && LA17_28 <= '\uFFFF')) ) { s = 81; }

                   	else s = 31;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA17_108 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_108 == 'T') ) { s = 126; }

                   	else if ( ((LA17_108 >= '\u0000' && LA17_108 <= 'S') || (LA17_108 >= 'U' && LA17_108 <= '\uFFFF')) ) { s = 81; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA17_126 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_126 == 'I') ) { s = 141; }

                   	else if ( ((LA17_126 >= '\u0000' && LA17_126 <= 'H') || (LA17_126 >= 'J' && LA17_126 <= '\uFFFF')) ) { s = 81; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA17_141 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_141 == 'K') ) { s = 154; }

                   	else if ( ((LA17_141 >= '\u0000' && LA17_141 <= 'J') || (LA17_141 >= 'L' && LA17_141 <= '\uFFFF')) ) { s = 81; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA17_154 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_154 == 'Z') ) { s = 162; }

                   	else if ( ((LA17_154 >= '\u0000' && LA17_154 <= 'Y') || (LA17_154 >= '[' && LA17_154 <= '\uFFFF')) ) { s = 81; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA17_162 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_162 == 'E') ) { s = 168; }

                   	else if ( ((LA17_162 >= '\u0000' && LA17_162 <= 'D') || (LA17_162 >= 'F' && LA17_162 <= '\uFFFF')) ) { s = 81; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA17_168 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_168 == 'D') ) { s = 173; }

                   	else if ( ((LA17_168 >= '\u0000' && LA17_168 <= 'C') || (LA17_168 >= 'E' && LA17_168 <= '\uFFFF')) ) { s = 81; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA17_173 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_173 == 'T') ) { s = 177; }

                   	else if ( ((LA17_173 >= '\u0000' && LA17_173 <= 'S') || (LA17_173 >= 'U' && LA17_173 <= '\uFFFF')) ) { s = 81; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA17_78 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_78 == '!') ) { s = 108; }

                   	else if ( ((LA17_78 >= '\u0000' && LA17_78 <= ' ') || (LA17_78 >= '\"' && LA17_78 <= '\uFFFF')) ) { s = 81; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA17_177 = input.LA(1);

                   	s = -1;
                   	if ( ((LA17_177 >= '\u0000' && LA17_177 <= '\t') || (LA17_177 >= '\u000B' && LA17_177 <= '\f') || (LA17_177 >= '\u000E' && LA17_177 <= '\uFFFF')) ) { s = 181; }

                   	else if ( (LA17_177 == '\r') ) { s = 182; }

                   	else if ( (LA17_177 == '\n') ) { s = 183; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA17_30 = input.LA(1);

                   	s = -1;
                   	if ( ((LA17_30 >= '\u0000' && LA17_30 <= '\uFFFF')) ) { s = 83; }

                   	else s = 31;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 13 : 
                   	int LA17_181 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_181 == '\r') ) { s = 182; }

                   	else if ( (LA17_181 == '\n') ) { s = 183; }

                   	else if ( ((LA17_181 >= '\u0000' && LA17_181 <= '\t') || (LA17_181 >= '\u000B' && LA17_181 <= '\f') || (LA17_181 >= '\u000E' && LA17_181 <= '\uFFFF')) ) { s = 181; }

                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae17 =
            new NoViableAltException(dfa.Description, 17, _s, input);
        dfa.Error(nvae17);
        throw nvae17;
    }
 
    
}
