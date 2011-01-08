// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g 2011-01-08 09:59:10

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
    public const int EXPONENT = 51;
    public const int T__64 = 64;
    public const int T__65 = 65;
    public const int IM_STARTTAG = 34;
    public const int TIKZEDT_CMD_COMMENT = 45;
    public const int T__62 = 62;
    public const int COORDINATE = 10;
    public const int T__63 = 63;
    public const int RBR = 18;
    public const int IM_PATH = 25;
    public const int IM_ID = 39;
    public const int SOMETHING = 55;
    public const int ID = 46;
    public const int T__61 = 61;
    public const int EOF = -1;
    public const int T__60 = 60;
    public const int MATHSTRING = 53;
    public const int LBR = 17;
    public const int COMMAND = 54;
    public const int IM_ENDTAG = 35;
    public const int IM_USETIKZLIB = 41;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int IM_DOCUMENT = 32;
    public const int T__58 = 58;
    public const int RBRR = 20;
    public const int ESC_SEQ = 52;
    public const int IM_STRING = 42;
    public const int LPAR = 16;
    public const int FILL = 13;
    public const int PATH = 12;
    public const int IM_TIKZSET = 40;
    public const int T__59 = 59;
    public const int BEGIN = 4;
    public const int IM_OPTION_KV = 38;
    public const int CLIP = 14;
    public const int COMMENT = 50;
    public const int IM_TIKZEDT_CMD = 44;
    public const int IM_OPTIONS = 36;
    public const int STYLETAG = 15;
    public const int NODE = 9;
    public const int IM_OPTION_STYLE = 37;
    public const int TIKZSET = 8;
    public const int TIKZSTYLE = 7;
    public const int IM_COORD = 27;
    public const int IM_PICTURE = 31;
    public const int LBRR = 19;
    public const int INT = 48;
    public const int USETIKZLIB = 6;
    public const int IM_NODE = 26;
    public const int IM_STYLE = 43;
    public const int COLON = 24;
    public const int IM_NUMBERUNIT = 30;
    public const int IM_SCOPE = 33;
    public const int T__71 = 71;
    public const int WS = 49;
    public const int T__72 = 72;
    public const int T__70 = 70;
    public const int KOMMA = 21;
    public const int EQU = 22;
    public const int IM_SIZE = 28;
    public const int END = 5;
    public const int T__76 = 76;
    public const int SEMIC = 23;
    public const int T__75 = 75;
    public const int T__74 = 74;
    public const int T__73 = 73;
    public const int IM_NODENAME = 29;
    public const int DRAW = 11;
    public const int FLOAT_WO_EXP = 47;

        //@Override
        public override void ReportError(RecognitionException e) {
            throw e;
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
    	get { return "C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g";} 
    }

    // $ANTLR start "BEGIN"
    public void mBEGIN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BEGIN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:15:7: ( '\\\\begin' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:15:9: '\\\\begin'
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:16:5: ( '\\\\end' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:16:7: '\\\\end'
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:17:12: ( '\\\\usetikzlibrary' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:17:14: '\\\\usetikzlibrary'
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:18:11: ( '\\\\tikzstyle' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:18:13: '\\\\tikzstyle'
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:19:9: ( '\\\\tikzset' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:19:11: '\\\\tikzset'
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:20:6: ( '\\\\node' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:20:8: '\\\\node'
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

    // $ANTLR start "COORDINATE"
    public void mCOORDINATE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COORDINATE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:21:12: ( '\\\\coordinate' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:21:14: '\\\\coordinate'
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
    // $ANTLR end "COORDINATE"

    // $ANTLR start "DRAW"
    public void mDRAW() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DRAW;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:22:6: ( '\\\\draw' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:22:8: '\\\\draw'
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:23:6: ( '\\\\path' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:23:8: '\\\\path'
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:24:6: ( '\\\\fill' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:24:8: '\\\\fill'
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:25:6: ( '\\\\clip' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:25:8: '\\\\clip'
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

    // $ANTLR start "STYLETAG"
    public void mSTYLETAG() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STYLETAG;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:26:10: ( '/.style' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:26:12: '/.style'
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
    // $ANTLR end "STYLETAG"

    // $ANTLR start "LPAR"
    public void mLPAR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LPAR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:27:6: ( '(' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:27:8: '('
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

    // $ANTLR start "LBR"
    public void mLBR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LBR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:28:5: ( '[' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:28:7: '['
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:29:5: ( ']' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:29:7: ']'
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:30:6: ( '{' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:30:8: '{'
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:31:6: ( '}' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:31:8: '}'
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:32:7: ( ',' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:32:9: ','
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:33:5: ( '=' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:33:7: '='
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:34:7: ( ';' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:34:9: ';'
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:35:7: ( ':' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:35:9: ':'
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

    // $ANTLR start "T__56"
    public void mT__56() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__56;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:36:7: ( ')' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:36:9: ')'
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
    // $ANTLR end "T__56"

    // $ANTLR start "T__57"
    public void mT__57() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__57;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:37:7: ( 'cm' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:37:9: 'cm'
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
    // $ANTLR end "T__57"

    // $ANTLR start "T__58"
    public void mT__58() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__58;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:38:7: ( 'in' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:38:9: 'in'
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
    // $ANTLR end "T__58"

    // $ANTLR start "T__59"
    public void mT__59() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__59;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:39:7: ( 'ex' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:39:9: 'ex'
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
    // $ANTLR end "T__59"

    // $ANTLR start "T__60"
    public void mT__60() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__60;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:40:7: ( 'mm' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:40:9: 'mm'
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
    // $ANTLR end "T__60"

    // $ANTLR start "T__61"
    public void mT__61() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__61;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:41:7: ( 'pt' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:41:9: 'pt'
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
    // $ANTLR end "T__61"

    // $ANTLR start "T__62"
    public void mT__62() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__62;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:42:7: ( 'em' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:42:9: 'em'
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
    // $ANTLR end "T__62"

    // $ANTLR start "T__63"
    public void mT__63() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__63;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:43:7: ( 'node' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:43:9: 'node'
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
    // $ANTLR end "T__63"

    // $ANTLR start "T__64"
    public void mT__64() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__64;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:44:7: ( 'at' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:44:9: 'at'
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
    // $ANTLR end "T__64"

    // $ANTLR start "T__65"
    public void mT__65() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__65;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:45:7: ( 'circle' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:45:9: 'circle'
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
    // $ANTLR end "T__65"

    // $ANTLR start "T__66"
    public void mT__66() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__66;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:46:7: ( 'ellipse' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:46:9: 'ellipse'
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
    // $ANTLR end "T__66"

    // $ANTLR start "T__67"
    public void mT__67() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__67;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:47:7: ( 'arc' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:47:9: 'arc'
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
    // $ANTLR end "T__67"

    // $ANTLR start "T__68"
    public void mT__68() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__68;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:48:7: ( 'and' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:48:9: 'and'
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:49:7: ( '--' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:49:9: '--'
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
    // $ANTLR end "T__69"

    // $ANTLR start "T__70"
    public void mT__70() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__70;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:50:7: ( '->' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:50:9: '->'
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
    // $ANTLR end "T__70"

    // $ANTLR start "T__71"
    public void mT__71() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__71;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:51:7: ( '|-' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:51:9: '|-'
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
    // $ANTLR end "T__71"

    // $ANTLR start "T__72"
    public void mT__72() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__72;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:52:7: ( '-|' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:52:9: '-|'
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
    // $ANTLR end "T__72"

    // $ANTLR start "T__73"
    public void mT__73() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__73;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:53:7: ( '+' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:53:9: '+'
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
    // $ANTLR end "T__73"

    // $ANTLR start "T__74"
    public void mT__74() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__74;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:54:7: ( '++' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:54:9: '++'
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
    // $ANTLR end "T__74"

    // $ANTLR start "T__75"
    public void mT__75() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__75;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:55:7: ( 'tikzpicture' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:55:9: 'tikzpicture'
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
    // $ANTLR end "T__75"

    // $ANTLR start "T__76"
    public void mT__76() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__76;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:56:7: ( 'scope' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:56:9: 'scope'
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
    // $ANTLR end "T__76"

    // $ANTLR start "ID"
    public void mID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:428:5: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' | '!' )* )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:428:7: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' | '!' )*
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

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:428:31: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' | '!' )*
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:431:5: ( ( '-' )? ( '0' .. '9' )+ )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:431:7: ( '-' )? ( '0' .. '9' )+
            {
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:431:7: ( '-' )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == '-') )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:431:7: '-'
            	        {
            	        	Match('-'); 

            	        }
            	        break;

            	}

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:431:12: ( '0' .. '9' )+
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
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:431:12: '0' .. '9'
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:443:5: ( ( '-' )? ( '0' .. '9' )+ '.' ( '0' .. '9' )* | ( '-' )? '.' ( '0' .. '9' )+ )
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
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:443:9: ( '-' )? ( '0' .. '9' )+ '.' ( '0' .. '9' )*
                    {
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:443:9: ( '-' )?
                    	int alt4 = 2;
                    	int LA4_0 = input.LA(1);

                    	if ( (LA4_0 == '-') )
                    	{
                    	    alt4 = 1;
                    	}
                    	switch (alt4) 
                    	{
                    	    case 1 :
                    	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:443:9: '-'
                    	        {
                    	        	Match('-'); 

                    	        }
                    	        break;

                    	}

                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:443:14: ( '0' .. '9' )+
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
                    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:443:15: '0' .. '9'
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
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:443:30: ( '0' .. '9' )*
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
                    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:443:31: '0' .. '9'
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
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:444:9: ( '-' )? '.' ( '0' .. '9' )+
                    {
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:444:9: ( '-' )?
                    	int alt7 = 2;
                    	int LA7_0 = input.LA(1);

                    	if ( (LA7_0 == '-') )
                    	{
                    	    alt7 = 1;
                    	}
                    	switch (alt7) 
                    	{
                    	    case 1 :
                    	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:444:9: '-'
                    	        {
                    	        	Match('-'); 

                    	        }
                    	        break;

                    	}

                    	Match('.'); 
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:444:18: ( '0' .. '9' )+
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
                    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:444:19: '0' .. '9'
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:448:5: ( '%' WS '!TIKZEDT' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:448:9: '%' WS '!TIKZEDT' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
            {
            	Match('%'); 
            	mWS(); 
            	Match("!TIKZEDT"); 

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:448:29: (~ ( '\\n' | '\\r' ) )*
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
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:448:29: ~ ( '\\n' | '\\r' )
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

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:448:43: ( '\\r' )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == '\r') )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:448:43: '\\r'
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:452:5: ( '%' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:452:9: '%' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
            {
            	Match('%'); 
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:452:13: (~ ( '\\n' | '\\r' ) )*
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
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:452:13: ~ ( '\\n' | '\\r' )
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

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:452:27: ( '\\r' )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == '\r') )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:452:27: '\\r'
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:455:5: ( ( ' ' | '\\t' | '\\r' | '\\n' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:455:9: ( ' ' | '\\t' | '\\r' | '\\n' )
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:462:19: ( ( 'e' | 'E' ) ( '+' | '-' )? ( '0' .. '9' )+ )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:462:21: ( 'e' | 'E' ) ( '+' | '-' )? ( '0' .. '9' )+
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

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:462:31: ( '+' | '-' )?
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

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:462:42: ( '0' .. '9' )+
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
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:462:43: '0' .. '9'
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:469:2: ( '$' ( ESC_SEQ | ~ ( '\\\\' | '$' ) )* '$' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:469:4: '$' ( ESC_SEQ | ~ ( '\\\\' | '$' ) )* '$'
            {
            	Match('$'); 
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:469:8: ( ESC_SEQ | ~ ( '\\\\' | '$' ) )*
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
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:469:10: ESC_SEQ
            			    {
            			    	mESC_SEQ(); 

            			    }
            			    break;
            			case 2 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:469:20: ~ ( '\\\\' | '$' )
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:480:2: ( '\\\\' ID )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:480:4: '\\\\' ID
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:485:5: ( '\\\\' . )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:485:9: '\\\\' .
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:491:2: ( . )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:491:4: .
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
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:8: ( BEGIN | END | USETIKZLIB | TIKZSTYLE | TIKZSET | NODE | COORDINATE | DRAW | PATH | FILL | CLIP | STYLETAG | LPAR | LBR | RBR | LBRR | RBRR | KOMMA | EQU | SEMIC | COLON | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | ID | INT | FLOAT_WO_EXP | TIKZEDT_CMD_COMMENT | COMMENT | WS | MATHSTRING | COMMAND | ESC_SEQ | SOMETHING )
        int alt17 = 52;
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
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:54: COORDINATE
                {
                	mCOORDINATE(); 

                }
                break;
            case 8 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:65: DRAW
                {
                	mDRAW(); 

                }
                break;
            case 9 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:70: PATH
                {
                	mPATH(); 

                }
                break;
            case 10 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:75: FILL
                {
                	mFILL(); 

                }
                break;
            case 11 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:80: CLIP
                {
                	mCLIP(); 

                }
                break;
            case 12 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:85: STYLETAG
                {
                	mSTYLETAG(); 

                }
                break;
            case 13 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:94: LPAR
                {
                	mLPAR(); 

                }
                break;
            case 14 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:99: LBR
                {
                	mLBR(); 

                }
                break;
            case 15 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:103: RBR
                {
                	mRBR(); 

                }
                break;
            case 16 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:107: LBRR
                {
                	mLBRR(); 

                }
                break;
            case 17 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:112: RBRR
                {
                	mRBRR(); 

                }
                break;
            case 18 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:117: KOMMA
                {
                	mKOMMA(); 

                }
                break;
            case 19 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:123: EQU
                {
                	mEQU(); 

                }
                break;
            case 20 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:127: SEMIC
                {
                	mSEMIC(); 

                }
                break;
            case 21 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:133: COLON
                {
                	mCOLON(); 

                }
                break;
            case 22 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:139: T__56
                {
                	mT__56(); 

                }
                break;
            case 23 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:145: T__57
                {
                	mT__57(); 

                }
                break;
            case 24 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:151: T__58
                {
                	mT__58(); 

                }
                break;
            case 25 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:157: T__59
                {
                	mT__59(); 

                }
                break;
            case 26 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:163: T__60
                {
                	mT__60(); 

                }
                break;
            case 27 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:169: T__61
                {
                	mT__61(); 

                }
                break;
            case 28 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:175: T__62
                {
                	mT__62(); 

                }
                break;
            case 29 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:181: T__63
                {
                	mT__63(); 

                }
                break;
            case 30 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:187: T__64
                {
                	mT__64(); 

                }
                break;
            case 31 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:193: T__65
                {
                	mT__65(); 

                }
                break;
            case 32 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:199: T__66
                {
                	mT__66(); 

                }
                break;
            case 33 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:205: T__67
                {
                	mT__67(); 

                }
                break;
            case 34 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:211: T__68
                {
                	mT__68(); 

                }
                break;
            case 35 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:217: T__69
                {
                	mT__69(); 

                }
                break;
            case 36 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:223: T__70
                {
                	mT__70(); 

                }
                break;
            case 37 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:229: T__71
                {
                	mT__71(); 

                }
                break;
            case 38 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:235: T__72
                {
                	mT__72(); 

                }
                break;
            case 39 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:241: T__73
                {
                	mT__73(); 

                }
                break;
            case 40 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:247: T__74
                {
                	mT__74(); 

                }
                break;
            case 41 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:253: T__75
                {
                	mT__75(); 

                }
                break;
            case 42 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:259: T__76
                {
                	mT__76(); 

                }
                break;
            case 43 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:265: ID
                {
                	mID(); 

                }
                break;
            case 44 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:268: INT
                {
                	mINT(); 

                }
                break;
            case 45 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:272: FLOAT_WO_EXP
                {
                	mFLOAT_WO_EXP(); 

                }
                break;
            case 46 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:285: TIKZEDT_CMD_COMMENT
                {
                	mTIKZEDT_CMD_COMMENT(); 

                }
                break;
            case 47 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:305: COMMENT
                {
                	mCOMMENT(); 

                }
                break;
            case 48 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:313: WS
                {
                	mWS(); 

                }
                break;
            case 49 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:316: MATHSTRING
                {
                	mMATHSTRING(); 

                }
                break;
            case 50 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:327: COMMAND
                {
                	mCOMMAND(); 

                }
                break;
            case 51 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:335: ESC_SEQ
                {
                	mESC_SEQ(); 

                }
                break;
            case 52 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\simpletikz.g:1:343: SOMETHING
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
        "\x01\uffff\x02\x1f\x0a\uffff\x07\x38\x02\x1f\x01\x4a\x02\x38\x01"+
        "\uffff\x01\x4d\x02\x1f\x01\uffff\x01\x1f\x01\uffff\x09\x55\x0d\uffff"+
        "\x01\x5f\x01\x38\x01\uffff\x01\x61\x01\x62\x01\x63\x01\x38\x01\x65"+
        "\x01\x66\x01\x38\x01\x68\x02\x38\x03\uffff\x01\x4d\x04\uffff\x02"+
        "\x38\x04\uffff\x01\x50\x02\uffff\x01\x55\x01\uffff\x09\x55\x01\uffff"+
        "\x01\x38\x03\uffff\x01\x38\x02\uffff\x01\x38\x01\uffff\x01\x7c\x01"+
        "\x7d\x02\x38\x02\uffff\x01\x55\x01\u0082\x08\x55\x02\x38\x01\u008d"+
        "\x02\uffff\x02\x38\x01\uffff\x01\x55\x01\uffff\x02\x55\x01\u0094"+
        "\x01\x55\x01\u0096\x01\u0097\x01\u0098\x01\u0099\x02\x38\x01\uffff"+
        "\x01\x38\x01\u009d\x01\uffff\x01\u009f\x02\x55\x01\uffff\x01\x55"+
        "\x04\uffff\x01\u00a4\x02\x38\x03\uffff\x04\x55\x01\uffff\x01\u00ac"+
        "\x01\x38\x01\uffff\x02\x55\x01\u00b1\x01\x55\x01\uffff\x01\x38\x01"+
        "\uffff\x02\x55\x01\uffff\x01\x55\x01\x38\x01\uffff\x01\x55\x01\u00bb"+
        "\x01\x55\x01\x38\x01\uffff\x01\x55\x01\uffff\x01\u00c2\x01\u00c3"+
        "\x03\uffff\x01\x55\x02\uffff\x02\x55\x01\u00c7\x01\uffff";
    const string DFA17_eofS =
        "\u00c8\uffff";
    const string DFA17_minS =
        "\x02\x00\x01\x2e\x0a\uffff\x01\x69\x01\x6e\x01\x6c\x01\x6d\x01"+
        "\x74\x01\x6f\x01\x6e\x02\x2d\x01\x2b\x01\x69\x01\x63\x01\uffff\x01"+
        "\x2e\x01\x30\x01\x00\x01\uffff\x01\x00\x01\uffff\x01\x65\x01\x6e"+
        "\x01\x73\x01\x69\x01\x6f\x01\x6c\x01\x72\x01\x61\x01\x69\x0d\uffff"+
        "\x01\x21\x01\x72\x01\uffff\x03\x21\x01\x6c\x02\x21\x01\x64\x01\x21"+
        "\x01\x63\x01\x64\x03\uffff\x01\x2e\x04\uffff\x01\x6b\x01\x6f\x01"+
        "\uffff\x01\x00\x01\x0a\x01\uffff\x01\x21\x02\uffff\x01\x67\x01\uffff"+
        "\x01\x64\x01\x65\x01\x6b\x01\x64\x01\x6f\x01\x69\x01\x61\x01\x74"+
        "\x01\x6c\x01\uffff\x01\x63\x03\uffff\x01\x69\x02\uffff\x01\x65\x01"+
        "\uffff\x02\x21\x01\x7a\x01\x70\x01\x00\x01\uffff\x01\x69\x01\x21"+
        "\x01\x74\x01\x7a\x01\x65\x01\x72\x01\x70\x01\x77\x01\x68\x02\x6c"+
        "\x01\x70\x01\x21\x02\uffff\x01\x70\x01\x65\x01\x00\x01\x6e\x01\uffff"+
        "\x01\x69\x01\x73\x01\x21\x01\x64\x04\x21\x01\x65\x01\x73\x01\uffff"+
        "\x01\x69\x01\x21\x01\x00\x01\x21\x01\x6b\x01\x65\x01\uffff\x01\x69"+
        "\x04\uffff\x01\x21\x01\x65\x01\x63\x01\uffff\x01\x00\x01\uffff\x01"+
        "\x7a\x01\x79\x01\x74\x01\x6e\x01\uffff\x01\x21\x01\x74\x01\x00\x02"+
        "\x6c\x01\x21\x01\x61\x01\uffff\x01\x75\x01\x00\x01\x69\x01\x65\x01"+
        "\uffff\x01\x74\x01\x72\x01\x00\x01\x62\x01\x21\x02\x65\x01\x00\x01"+
        "\x72\x01\uffff\x02\x21\x01\x0a\x01\uffff\x01\x00\x01\x61\x02\uffff"+
        "\x01\x72\x01\x79\x01\x21\x01\uffff";
    const string DFA17_maxS =
        "\x02\uffff\x01\x2e\x0a\uffff\x01\x6d\x01\x6e\x01\x78\x01\x6d\x01"+
        "\x74\x01\x6f\x01\x74\x01\x7c\x01\x2d\x01\x2b\x01\x69\x01\x63\x01"+
        "\uffff\x02\x39\x01\uffff\x01\uffff\x01\uffff\x01\uffff\x01\x65\x01"+
        "\x6e\x01\x73\x01\x69\x02\x6f\x01\x72\x01\x61\x01\x69\x0d\uffff\x01"+
        "\x7a\x01\x72\x01\uffff\x03\x7a\x01\x6c\x02\x7a\x01\x64\x01\x7a\x01"+
        "\x63\x01\x64\x03\uffff\x01\x39\x04\uffff\x01\x6b\x01\x6f\x01\uffff"+
        "\x01\uffff\x01\x21\x01\uffff\x01\x21\x02\uffff\x01\x67\x01\uffff"+
        "\x01\x64\x01\x65\x01\x6b\x01\x64\x01\x6f\x01\x69\x01\x61\x01\x74"+
        "\x01\x6c\x01\uffff\x01\x63\x03\uffff\x01\x69\x02\uffff\x01\x65\x01"+
        "\uffff\x03\x7a\x01\x70\x01\uffff\x01\uffff\x01\x69\x01\x7a\x01\x74"+
        "\x01\x7a\x01\x65\x01\x72\x01\x70\x01\x77\x01\x68\x02\x6c\x01\x70"+
        "\x01\x7a\x02\uffff\x01\x70\x01\x65\x01\uffff\x01\x6e\x01\uffff\x01"+
        "\x69\x01\x73\x01\x7a\x01\x64\x04\x7a\x01\x65\x01\x73\x01\uffff\x01"+
        "\x69\x01\x7a\x01\uffff\x01\x7a\x01\x6b\x01\x74\x01\uffff\x01\x69"+
        "\x04\uffff\x01\x7a\x01\x65\x01\x63\x01\uffff\x01\uffff\x01\uffff"+
        "\x01\x7a\x01\x79\x01\x74\x01\x6e\x01\uffff\x01\x7a\x01\x74\x01\uffff"+
        "\x02\x6c\x01\x7a\x01\x61\x01\uffff\x01\x75\x01\uffff\x01\x69\x01"+
        "\x65\x01\uffff\x01\x74\x01\x72\x01\uffff\x01\x62\x01\x7a\x02\x65"+
        "\x01\uffff\x01\x72\x01\uffff\x02\x7a\x01\x0a\x01\uffff\x01\uffff"+
        "\x01\x61\x02\uffff\x01\x72\x01\x79\x01\x7a\x01\uffff";
    const string DFA17_acceptS =
        "\x03\uffff\x01\x0d\x01\x0e\x01\x0f\x01\x10\x01\x11\x01\x12\x01"+
        "\x13\x01\x14\x01\x15\x01\x16\x0c\uffff\x01\x2b\x03\uffff\x01\x30"+
        "\x01\uffff\x01\x34\x09\uffff\x01\x32\x01\x33\x01\x0c\x01\x0d\x01"+
        "\x0e\x01\x0f\x01\x10\x01\x11\x01\x12\x01\x13\x01\x14\x01\x15\x01"+
        "\x16\x02\uffff\x01\x2b\x0a\uffff\x01\x23\x01\x24\x01\x26\x01\uffff"+
        "\x01\x2d\x01\x25\x01\x28\x01\x27\x02\uffff\x01\x2c\x02\uffff\x01"+
        "\x2f\x01\uffff\x01\x30\x01\x31\x01\uffff\x01\x32\x09\uffff\x01\x17"+
        "\x01\uffff\x01\x18\x01\x19\x01\x1c\x01\uffff\x01\x1a\x01\x1b\x01"+
        "\uffff\x01\x1e\x05\uffff\x01\x2e\x0d\uffff\x01\x21\x01\x22\x04\uffff"+
        "\x01\x02\x0a\uffff\x01\x1d\x06\uffff\x01\x06\x01\uffff\x01\x0b\x01"+
        "\x08\x01\x09\x01\x0a\x03\uffff\x01\x2a\x01\uffff\x01\x01\x04\uffff"+
        "\x01\x1f\x07\uffff\x01\x20\x04\uffff\x01\x05\x09\uffff\x01\x04\x03"+
        "\uffff\x01\x2e\x02\uffff\x01\x07\x01\x29\x03\uffff\x01\x03";
    const string DFA17_specialS =
        "\x01\x08\x01\x09\x1a\uffff\x01\x0b\x01\uffff\x01\x00\x2f\uffff"+
        "\x01\x0a\x1e\uffff\x01\x03\x12\uffff\x01\x01\x0f\uffff\x01\x02\x0d"+
        "\uffff\x01\x06\x08\uffff\x01\x07\x06\uffff\x01\x04\x05\uffff\x01"+
        "\x05\x04\uffff\x01\x0d\x06\uffff\x01\x0c\x07\uffff}>";
    static readonly string[] DFA17_transitionS = {
            "\x09\x1f\x02\x1d\x02\x1f\x01\x1d\x12\x1f\x01\x1d\x03\x1f\x01"+
            "\x1e\x01\x1c\x02\x1f\x01\x03\x01\x0c\x01\x1f\x01\x16\x01\x08"+
            "\x01\x14\x01\x1b\x01\x02\x0a\x1a\x01\x0b\x01\x0a\x01\x1f\x01"+
            "\x09\x03\x1f\x1a\x19\x01\x04\x01\x01\x01\x05\x01\x1f\x01\x19"+
            "\x01\x1f\x01\x13\x01\x19\x01\x0d\x01\x19\x01\x0f\x03\x19\x01"+
            "\x0e\x03\x19\x01\x10\x01\x12\x01\x19\x01\x11\x02\x19\x01\x18"+
            "\x01\x17\x06\x19\x01\x06\x01\x15\x01\x07\uff82\x1f",
            "\x41\x2a\x1a\x29\x04\x2a\x01\x29\x01\x2a\x01\x29\x01\x20\x01"+
            "\x25\x01\x26\x01\x21\x01\x28\x07\x29\x01\x24\x01\x29\x01\x27"+
            "\x03\x29\x01\x23\x01\x22\x05\x29\uff85\x2a",
            "\x01\x2b",
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
            "\x09\x50\x01\x4e\x01\x51\x02\x50\x01\x4f\x12\x50\x01\x4e\uffdf"+
            "\x50",
            "",
            "\x00\x53",
            "",
            "\x01\x54",
            "\x01\x56",
            "\x01\x57",
            "\x01\x58",
            "\x01\x59",
            "\x01\x5b\x02\uffff\x01\x5a",
            "\x01\x5c",
            "\x01\x5d",
            "\x01\x5e",
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
            "\x01\x60",
            "",
            "\x01\x38\x0c\uffff\x01\x38\x01\uffff\x0a\x38\x07\uffff\x1a"+
            "\x38\x04\uffff\x01\x38\x01\uffff\x1a\x38",
            "\x01\x38\x0c\uffff\x01\x38\x01\uffff\x0a\x38\x07\uffff\x1a"+
            "\x38\x04\uffff\x01\x38\x01\uffff\x1a\x38",
            "\x01\x38\x0c\uffff\x01\x38\x01\uffff\x0a\x38\x07\uffff\x1a"+
            "\x38\x04\uffff\x01\x38\x01\uffff\x1a\x38",
            "\x01\x64",
            "\x01\x38\x0c\uffff\x01\x38\x01\uffff\x0a\x38\x07\uffff\x1a"+
            "\x38\x04\uffff\x01\x38\x01\uffff\x1a\x38",
            "\x01\x38\x0c\uffff\x01\x38\x01\uffff\x0a\x38\x07\uffff\x1a"+
            "\x38\x04\uffff\x01\x38\x01\uffff\x1a\x38",
            "\x01\x67",
            "\x01\x38\x0c\uffff\x01\x38\x01\uffff\x0a\x38\x07\uffff\x1a"+
            "\x38\x04\uffff\x01\x38\x01\uffff\x1a\x38",
            "\x01\x69",
            "\x01\x6a",
            "",
            "",
            "",
            "\x01\x47\x01\uffff\x0a\x46",
            "",
            "",
            "",
            "",
            "\x01\x6b",
            "\x01\x6c",
            "",
            "\x21\x50\x01\x6d\uffde\x50",
            "\x01\x50\x16\uffff\x01\x6e",
            "",
            "\x01\x6e",
            "",
            "",
            "\x01\x6f",
            "",
            "\x01\x70",
            "\x01\x71",
            "\x01\x72",
            "\x01\x73",
            "\x01\x74",
            "\x01\x75",
            "\x01\x76",
            "\x01\x77",
            "\x01\x78",
            "",
            "\x01\x79",
            "",
            "",
            "",
            "\x01\x7a",
            "",
            "",
            "\x01\x7b",
            "",
            "\x01\x38\x0c\uffff\x01\x38\x01\uffff\x0a\x38\x07\uffff\x1a"+
            "\x38\x04\uffff\x01\x38\x01\uffff\x1a\x38",
            "\x01\x38\x0c\uffff\x01\x38\x01\uffff\x0a\x38\x07\uffff\x1a"+
            "\x38\x04\uffff\x01\x38\x01\uffff\x1a\x38",
            "\x01\x7e",
            "\x01\x7f",
            "\x54\x50\x01\u0080\uffab\x50",
            "",
            "\x01\u0081",
            "\x01\x55\x0c\uffff\x01\x55\x01\uffff\x0a\x55\x07\uffff\x1a"+
            "\x55\x04\uffff\x01\x55\x01\uffff\x1a\x55",
            "\x01\u0083",
            "\x01\u0084",
            "\x01\u0085",
            "\x01\u0086",
            "\x01\u0087",
            "\x01\u0088",
            "\x01\u0089",
            "\x01\u008a",
            "\x01\u008b",
            "\x01\u008c",
            "\x01\x38\x0c\uffff\x01\x38\x01\uffff\x0a\x38\x07\uffff\x1a"+
            "\x38\x04\uffff\x01\x38\x01\uffff\x1a\x38",
            "",
            "",
            "\x01\u008e",
            "\x01\u008f",
            "\x49\x50\x01\u0090\uffb6\x50",
            "\x01\u0091",
            "",
            "\x01\u0092",
            "\x01\u0093",
            "\x01\x55\x0c\uffff\x01\x55\x01\uffff\x0a\x55\x07\uffff\x1a"+
            "\x55\x04\uffff\x01\x55\x01\uffff\x1a\x55",
            "\x01\u0095",
            "\x01\x55\x0c\uffff\x01\x55\x01\uffff\x0a\x55\x07\uffff\x1a"+
            "\x55\x04\uffff\x01\x55\x01\uffff\x1a\x55",
            "\x01\x55\x0c\uffff\x01\x55\x01\uffff\x0a\x55\x07\uffff\x1a"+
            "\x55\x04\uffff\x01\x55\x01\uffff\x1a\x55",
            "\x01\x55\x0c\uffff\x01\x55\x01\uffff\x0a\x55\x07\uffff\x1a"+
            "\x55\x04\uffff\x01\x55\x01\uffff\x1a\x55",
            "\x01\x55\x0c\uffff\x01\x55\x01\uffff\x0a\x55\x07\uffff\x1a"+
            "\x55\x04\uffff\x01\x55\x01\uffff\x1a\x55",
            "\x01\u009a",
            "\x01\u009b",
            "",
            "\x01\u009c",
            "\x01\x38\x0c\uffff\x01\x38\x01\uffff\x0a\x38\x07\uffff\x1a"+
            "\x38\x04\uffff\x01\x38\x01\uffff\x1a\x38",
            "\x4b\x50\x01\u009e\uffb4\x50",
            "\x01\x55\x0c\uffff\x01\x55\x01\uffff\x0a\x55\x07\uffff\x1a"+
            "\x55\x04\uffff\x01\x55\x01\uffff\x1a\x55",
            "\x01\u00a0",
            "\x01\u00a2\x0e\uffff\x01\u00a1",
            "",
            "\x01\u00a3",
            "",
            "",
            "",
            "",
            "\x01\x38\x0c\uffff\x01\x38\x01\uffff\x0a\x38\x07\uffff\x1a"+
            "\x38\x04\uffff\x01\x38\x01\uffff\x1a\x38",
            "\x01\u00a5",
            "\x01\u00a6",
            "",
            "\x5a\x50\x01\u00a7\uffa5\x50",
            "",
            "\x01\u00a8",
            "\x01\u00a9",
            "\x01\u00aa",
            "\x01\u00ab",
            "",
            "\x01\x38\x0c\uffff\x01\x38\x01\uffff\x0a\x38\x07\uffff\x1a"+
            "\x38\x04\uffff\x01\x38\x01\uffff\x1a\x38",
            "\x01\u00ad",
            "\x45\x50\x01\u00ae\uffba\x50",
            "\x01\u00af",
            "\x01\u00b0",
            "\x01\x55\x0c\uffff\x01\x55\x01\uffff\x0a\x55\x07\uffff\x1a"+
            "\x55\x04\uffff\x01\x55\x01\uffff\x1a\x55",
            "\x01\u00b2",
            "",
            "\x01\u00b3",
            "\x44\x50\x01\u00b4\uffbb\x50",
            "\x01\u00b5",
            "\x01\u00b6",
            "",
            "\x01\u00b7",
            "\x01\u00b8",
            "\x54\x50\x01\u00b9\uffab\x50",
            "\x01\u00ba",
            "\x01\x55\x0c\uffff\x01\x55\x01\uffff\x0a\x55\x07\uffff\x1a"+
            "\x55\x04\uffff\x01\x55\x01\uffff\x1a\x55",
            "\x01\u00bc",
            "\x01\u00bd",
            "\x0a\u00c0\x01\u00bf\x02\u00c0\x01\u00be\ufff2\u00c0",
            "\x01\u00c1",
            "",
            "\x01\x55\x0c\uffff\x01\x55\x01\uffff\x0a\x55\x07\uffff\x1a"+
            "\x55\x04\uffff\x01\x55\x01\uffff\x1a\x55",
            "\x01\x38\x0c\uffff\x01\x38\x01\uffff\x0a\x38\x07\uffff\x1a"+
            "\x38\x04\uffff\x01\x38\x01\uffff\x1a\x38",
            "\x01\u00bf",
            "",
            "\x0a\u00c0\x01\u00bf\x02\u00c0\x01\u00be\ufff2\u00c0",
            "\x01\u00c4",
            "",
            "",
            "\x01\u00c5",
            "\x01\u00c6",
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
            get { return "1:1: Tokens : ( BEGIN | END | USETIKZLIB | TIKZSTYLE | TIKZSET | NODE | COORDINATE | DRAW | PATH | FILL | CLIP | STYLETAG | LPAR | LBR | RBR | LBRR | RBRR | KOMMA | EQU | SEMIC | COLON | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | ID | INT | FLOAT_WO_EXP | TIKZEDT_CMD_COMMENT | COMMENT | WS | MATHSTRING | COMMAND | ESC_SEQ | SOMETHING );"; }
        }

    }


    protected internal int DFA17_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            IIntStream input = _input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA17_30 = input.LA(1);

                   	s = -1;
                   	if ( ((LA17_30 >= '\u0000' && LA17_30 <= '\uFFFF')) ) { s = 83; }

                   	else s = 31;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA17_128 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_128 == 'I') ) { s = 144; }

                   	else if ( ((LA17_128 >= '\u0000' && LA17_128 <= 'H') || (LA17_128 >= 'J' && LA17_128 <= '\uFFFF')) ) { s = 80; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA17_144 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_144 == 'K') ) { s = 158; }

                   	else if ( ((LA17_144 >= '\u0000' && LA17_144 <= 'J') || (LA17_144 >= 'L' && LA17_144 <= '\uFFFF')) ) { s = 80; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA17_109 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_109 == 'T') ) { s = 128; }

                   	else if ( ((LA17_109 >= '\u0000' && LA17_109 <= 'S') || (LA17_109 >= 'U' && LA17_109 <= '\uFFFF')) ) { s = 80; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA17_174 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_174 == 'D') ) { s = 180; }

                   	else if ( ((LA17_174 >= '\u0000' && LA17_174 <= 'C') || (LA17_174 >= 'E' && LA17_174 <= '\uFFFF')) ) { s = 80; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA17_180 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_180 == 'T') ) { s = 185; }

                   	else if ( ((LA17_180 >= '\u0000' && LA17_180 <= 'S') || (LA17_180 >= 'U' && LA17_180 <= '\uFFFF')) ) { s = 80; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA17_158 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_158 == 'Z') ) { s = 167; }

                   	else if ( ((LA17_158 >= '\u0000' && LA17_158 <= 'Y') || (LA17_158 >= '[' && LA17_158 <= '\uFFFF')) ) { s = 80; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA17_167 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_167 == 'E') ) { s = 174; }

                   	else if ( ((LA17_167 >= '\u0000' && LA17_167 <= 'D') || (LA17_167 >= 'F' && LA17_167 <= '\uFFFF')) ) { s = 80; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA17_0 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_0 == '\\') ) { s = 1; }

                   	else if ( (LA17_0 == '/') ) { s = 2; }

                   	else if ( (LA17_0 == '(') ) { s = 3; }

                   	else if ( (LA17_0 == '[') ) { s = 4; }

                   	else if ( (LA17_0 == ']') ) { s = 5; }

                   	else if ( (LA17_0 == '{') ) { s = 6; }

                   	else if ( (LA17_0 == '}') ) { s = 7; }

                   	else if ( (LA17_0 == ',') ) { s = 8; }

                   	else if ( (LA17_0 == '=') ) { s = 9; }

                   	else if ( (LA17_0 == ';') ) { s = 10; }

                   	else if ( (LA17_0 == ':') ) { s = 11; }

                   	else if ( (LA17_0 == ')') ) { s = 12; }

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
               	case 9 : 
                   	int LA17_1 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_1 == 'b') ) { s = 32; }

                   	else if ( (LA17_1 == 'e') ) { s = 33; }

                   	else if ( (LA17_1 == 'u') ) { s = 34; }

                   	else if ( (LA17_1 == 't') ) { s = 35; }

                   	else if ( (LA17_1 == 'n') ) { s = 36; }

                   	else if ( (LA17_1 == 'c') ) { s = 37; }

                   	else if ( (LA17_1 == 'd') ) { s = 38; }

                   	else if ( (LA17_1 == 'p') ) { s = 39; }

                   	else if ( (LA17_1 == 'f') ) { s = 40; }

                   	else if ( ((LA17_1 >= 'A' && LA17_1 <= 'Z') || LA17_1 == '_' || LA17_1 == 'a' || (LA17_1 >= 'g' && LA17_1 <= 'm') || LA17_1 == 'o' || (LA17_1 >= 'q' && LA17_1 <= 's') || (LA17_1 >= 'v' && LA17_1 <= 'z')) ) { s = 41; }

                   	else if ( ((LA17_1 >= '\u0000' && LA17_1 <= '@') || (LA17_1 >= '[' && LA17_1 <= '^') || LA17_1 == '`' || (LA17_1 >= '{' && LA17_1 <= '\uFFFF')) ) { s = 42; }

                   	else s = 31;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA17_78 = input.LA(1);

                   	s = -1;
                   	if ( ((LA17_78 >= '\u0000' && LA17_78 <= ' ') || (LA17_78 >= '\"' && LA17_78 <= '\uFFFF')) ) { s = 80; }

                   	else if ( (LA17_78 == '!') ) { s = 109; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA17_28 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_28 == '\t' || LA17_28 == ' ') ) { s = 78; }

                   	else if ( (LA17_28 == '\r') ) { s = 79; }

                   	else if ( ((LA17_28 >= '\u0000' && LA17_28 <= '\b') || (LA17_28 >= '\u000B' && LA17_28 <= '\f') || (LA17_28 >= '\u000E' && LA17_28 <= '\u001F') || (LA17_28 >= '!' && LA17_28 <= '\uFFFF')) ) { s = 80; }

                   	else if ( (LA17_28 == '\n') ) { s = 81; }

                   	else s = 31;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA17_192 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_192 == '\r') ) { s = 190; }

                   	else if ( (LA17_192 == '\n') ) { s = 191; }

                   	else if ( ((LA17_192 >= '\u0000' && LA17_192 <= '\t') || (LA17_192 >= '\u000B' && LA17_192 <= '\f') || (LA17_192 >= '\u000E' && LA17_192 <= '\uFFFF')) ) { s = 192; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 13 : 
                   	int LA17_185 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_185 == '\r') ) { s = 190; }

                   	else if ( (LA17_185 == '\n') ) { s = 191; }

                   	else if ( ((LA17_185 >= '\u0000' && LA17_185 <= '\t') || (LA17_185 >= '\u000B' && LA17_185 <= '\f') || (LA17_185 >= '\u000E' && LA17_185 <= '\uFFFF')) ) { s = 192; }

                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae17 =
            new NoViableAltException(dfa.Description, 17, _s, input);
        dfa.Error(nvae17);
        throw nvae17;
    }
 
    
}
