// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g 2010-11-25 10:21:47

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
    public const int EXPONENT = 58;
    public const int T__64 = 64;
    public const int T__65 = 65;
    public const int IM_STARTTAG = 50;
    public const int T__62 = 62;
    public const int T__63 = 63;
    public const int RBR = 17;
    public const int IM_PATH = 42;
    public const int ST_LINEWIDTH = 35;
    public const int ST_DASHSTYLE = 36;
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
    public const int LBRR = 18;
    public const int BEGINSCOPE = 8;
    public const int INT = 56;
    public const int UN_CM = 41;
    public const int IM_NODE = 43;
    public const int COLON = 24;
    public const int ENDSCOPE = 9;
    public const int ST_DRAW = 32;
    public const int SCALE = 21;
    public const int IM_NUMBERUNIT = 46;
    public const int IM_SCOPE = 49;
    public const int T__71 = 71;
    public const int WS = 60;
    public const int T__72 = 72;
    public const int T__70 = 70;
    public const int LABEL = 27;
    public const int ST_MINSIZE = 34;
    public const int OUT = 39;
    public const int KOMMA = 20;
    public const int ST_SHAPE = 33;
    public const int EQU = 22;
    public const int RPAR = 15;
    public const int SEMIC = 23;
    public const int END = 5;
    public const int IM_NODENAME = 45;
    public const int OPTIONS = 52;
    public const int DRAW = 11;
    public const int STRING = 53;

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

    // $ANTLR start "BEGIN"
    public void mBEGIN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BEGIN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:7:7: ( '\\\\begin' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:7:9: '\\\\begin'
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
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:8:5: ( '\\\\end' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:8:7: '\\\\end'
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

    // $ANTLR start "BEGINTP"
    public void mBEGINTP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BEGINTP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:9:9: ( '\\\\begin{tikzpicture}' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:9:11: '\\\\begin{tikzpicture}'
            {
            	Match("\\begin{tikzpicture}"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BEGINTP"

    // $ANTLR start "ENDTP"
    public void mENDTP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ENDTP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:10:7: ( '\\\\end{tikzpicture}' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:10:9: '\\\\end{tikzpicture}'
            {
            	Match("\\end{tikzpicture}"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ENDTP"

    // $ANTLR start "BEGINSCOPE"
    public void mBEGINSCOPE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BEGINSCOPE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:11:12: ( '\\\\begin{scope}' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:11:14: '\\\\begin{scope}'
            {
            	Match("\\begin{scope}"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BEGINSCOPE"

    // $ANTLR start "ENDSCOPE"
    public void mENDSCOPE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ENDSCOPE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:12:10: ( '\\\\end{scope}' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:12:12: '\\\\end{scope}'
            {
            	Match("\\end{scope}"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ENDSCOPE"

    // $ANTLR start "NODE"
    public void mNODE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NODE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:13:6: ( '\\\\node' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:13:8: '\\\\node'
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
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:14:6: ( '\\\\draw' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:14:8: '\\\\draw'
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
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:15:6: ( '\\\\path' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:15:8: '\\\\path'
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
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:16:6: ( '\\\\fill' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:16:8: '\\\\fill'
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
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:17:6: ( '(' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:17:8: '('
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
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:18:6: ( ')' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:18:8: ')'
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
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:19:5: ( '[' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:19:7: '['
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
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:20:5: ( ']' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:20:7: ']'
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
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:21:6: ( '{' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:21:8: '{'
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
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:22:6: ( '}' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:22:8: '}'
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
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:23:7: ( ',' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:23:9: ','
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

    // $ANTLR start "SCALE"
    public void mSCALE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SCALE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:24:7: ( 'scale' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:24:9: 'scale'
            {
            	Match("scale"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SCALE"

    // $ANTLR start "EQU"
    public void mEQU() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = EQU;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:25:5: ( '=' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:25:7: '='
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
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:26:7: ( ';' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:26:9: ';'
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
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:27:7: ( ':' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:27:9: ':'
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

    // $ANTLR start "STYLESEP"
    public void mSTYLESEP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STYLESEP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:28:10: ( '/.style' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:28:12: '/.style'
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
    // $ANTLR end "STYLESEP"

    // $ANTLR start "AT"
    public void mAT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = AT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:29:4: ( 'at' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:29:6: 'at'
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
    // $ANTLR end "AT"

    // $ANTLR start "LABEL"
    public void mLABEL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LABEL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:30:7: ( 'label' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:30:9: 'label'
            {
            	Match("label"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LABEL"

    // $ANTLR start "EVERYLOOP"
    public void mEVERYLOOP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = EVERYLOOP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:31:11: ( 'every loop' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:31:13: 'every loop'
            {
            	Match("every loop"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "EVERYLOOP"

    // $ANTLR start "ST_INNERSEP"
    public void mST_INNERSEP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ST_INNERSEP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:32:13: ( 'inner sep' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:32:15: 'inner sep'
            {
            	Match("inner sep"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ST_INNERSEP"

    // $ANTLR start "ST_OUTERSEP"
    public void mST_OUTERSEP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ST_OUTERSEP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:33:13: ( 'outer sep' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:33:15: 'outer sep'
            {
            	Match("outer sep"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ST_OUTERSEP"

    // $ANTLR start "ST_FILL"
    public void mST_FILL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ST_FILL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:34:9: ( 'fill' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:34:11: 'fill'
            {
            	Match("fill"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ST_FILL"

    // $ANTLR start "ST_DRAW"
    public void mST_DRAW() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ST_DRAW;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:35:9: ( 'draw' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:35:11: 'draw'
            {
            	Match("draw"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ST_DRAW"

    // $ANTLR start "ST_SHAPE"
    public void mST_SHAPE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ST_SHAPE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:36:10: ( 'shape' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:36:12: 'shape'
            {
            	Match("shape"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ST_SHAPE"

    // $ANTLR start "ST_MINSIZE"
    public void mST_MINSIZE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ST_MINSIZE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:37:12: ( 'minimum size' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:37:14: 'minimum size'
            {
            	Match("minimum size"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ST_MINSIZE"

    // $ANTLR start "ST_LINEWIDTH"
    public void mST_LINEWIDTH() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ST_LINEWIDTH;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:38:14: ( 'line width' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:38:16: 'line width'
            {
            	Match("line width"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ST_LINEWIDTH"

    // $ANTLR start "ST_DASHSTYLE"
    public void mST_DASHSTYLE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ST_DASHSTYLE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:39:14: ( 'dash style' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:39:16: 'dash style'
            {
            	Match("dash style"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ST_DASHSTYLE"

    // $ANTLR start "LOOP"
    public void mLOOP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LOOP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:40:6: ( 'loop' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:40:8: 'loop'
            {
            	Match("loop"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LOOP"

    // $ANTLR start "IN"
    public void mIN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:41:4: ( 'in' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:41:6: 'in'
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
    // $ANTLR end "IN"

    // $ANTLR start "OUT"
    public void mOUT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OUT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:42:5: ( 'out' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:42:7: 'out'
            {
            	Match("out"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OUT"

    // $ANTLR start "UN_PTS"
    public void mUN_PTS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = UN_PTS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:43:8: ( 'pt' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:43:10: 'pt'
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
    // $ANTLR end "UN_PTS"

    // $ANTLR start "UN_CM"
    public void mUN_CM() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = UN_CM;
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
    // $ANTLR end "UN_CM"

    // $ANTLR start "T__62"
    public void mT__62() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__62;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:45:7: ( 'node' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:45:9: 'node'
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
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:46:7: ( '--' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:46:9: '--'
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
    // $ANTLR end "T__63"

    // $ANTLR start "T__64"
    public void mT__64() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__64;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:47:7: ( 'edge' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:47:9: 'edge'
            {
            	Match("edge"); 


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
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:48:7: ( '->' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:48:9: '->'
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
    // $ANTLR end "T__65"

    // $ANTLR start "T__66"
    public void mT__66() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__66;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:49:7: ( '|-' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:49:9: '|-'
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
    // $ANTLR end "T__66"

    // $ANTLR start "T__67"
    public void mT__67() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__67;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:50:7: ( '-|' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:50:9: '-|'
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
    // $ANTLR end "T__67"

    // $ANTLR start "T__68"
    public void mT__68() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__68;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:51:7: ( 'to' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:51:9: 'to'
            {
            	Match("to"); 


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
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:52:7: ( '+' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:52:9: '+'
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
    // $ANTLR end "T__69"

    // $ANTLR start "T__70"
    public void mT__70() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__70;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:53:7: ( '++' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:53:9: '++'
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
    // $ANTLR end "T__70"

    // $ANTLR start "T__71"
    public void mT__71() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__71;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:54:7: ( 'ex' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:54:9: 'ex'
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
    // $ANTLR end "T__71"

    // $ANTLR start "T__72"
    public void mT__72() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__72;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:55:7: ( 'mm' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:55:9: 'mm'
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
    // $ANTLR end "T__72"

    // $ANTLR start "ID"
    public void mID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:158:5: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:158:7: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
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

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:158:31: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= '0' && LA1_0 <= '9') || (LA1_0 >= 'A' && LA1_0 <= 'Z') || LA1_0 == '_' || (LA1_0 >= 'a' && LA1_0 <= 'z')) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            			    {
            			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
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
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:5: ( ( '0' .. '9' )+ )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:7: ( '0' .. '9' )+
            {
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:7: ( '0' .. '9' )+
            	int cnt2 = 0;
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= '0' && LA2_0 <= '9')) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:7: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

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


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INT"

    // $ANTLR start "FLOAT"
    public void mFLOAT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FLOAT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:5: ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* ( EXPONENT )? | '.' ( '0' .. '9' )+ ( EXPONENT )? | ( '0' .. '9' )+ EXPONENT )
            int alt9 = 3;
            alt9 = dfa9.Predict(input);
            switch (alt9) 
            {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:9: ( '0' .. '9' )+ '.' ( '0' .. '9' )* ( EXPONENT )?
                    {
                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:9: ( '0' .. '9' )+
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
                    			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:10: '0' .. '9'
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

                    	Match('.'); 
                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:25: ( '0' .. '9' )*
                    	do 
                    	{
                    	    int alt4 = 2;
                    	    int LA4_0 = input.LA(1);

                    	    if ( ((LA4_0 >= '0' && LA4_0 <= '9')) )
                    	    {
                    	        alt4 = 1;
                    	    }


                    	    switch (alt4) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:26: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    goto loop4;
                    	    }
                    	} while (true);

                    	loop4:
                    		;	// Stops C# compiler whining that label 'loop4' has no statements

                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:37: ( EXPONENT )?
                    	int alt5 = 2;
                    	int LA5_0 = input.LA(1);

                    	if ( (LA5_0 == 'E' || LA5_0 == 'e') )
                    	{
                    	    alt5 = 1;
                    	}
                    	switch (alt5) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:37: EXPONENT
                    	        {
                    	        	mEXPONENT(); 

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:166:9: '.' ( '0' .. '9' )+ ( EXPONENT )?
                    {
                    	Match('.'); 
                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:166:13: ( '0' .. '9' )+
                    	int cnt6 = 0;
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
                    			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:166:14: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt6 >= 1 ) goto loop6;
                    		            EarlyExitException eee6 =
                    		                new EarlyExitException(6, input);
                    		            throw eee6;
                    	    }
                    	    cnt6++;
                    	} while (true);

                    	loop6:
                    		;	// Stops C# compiler whining that label 'loop6' has no statements

                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:166:25: ( EXPONENT )?
                    	int alt7 = 2;
                    	int LA7_0 = input.LA(1);

                    	if ( (LA7_0 == 'E' || LA7_0 == 'e') )
                    	{
                    	    alt7 = 1;
                    	}
                    	switch (alt7) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:166:25: EXPONENT
                    	        {
                    	        	mEXPONENT(); 

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 3 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:167:9: ( '0' .. '9' )+ EXPONENT
                    {
                    	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:167:9: ( '0' .. '9' )+
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
                    			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:167:10: '0' .. '9'
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

                    	mEXPONENT(); 

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
    // $ANTLR end "FLOAT"

    // $ANTLR start "COMMENT"
    public void mCOMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:171:5: ( '%' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:171:9: '%' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
            {
            	Match('%'); 
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:171:13: (~ ( '\\n' | '\\r' ) )*
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
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:171:13: ~ ( '\\n' | '\\r' )
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

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:171:27: ( '\\r' )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == '\r') )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:171:27: '\\r'
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
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:174:5: ( ( ' ' | '\\t' | '\\r' | '\\n' ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:174:9: ( ' ' | '\\t' | '\\r' | '\\n' )
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
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:10: ( ( 'e' | 'E' ) ( '+' | '-' )? ( '0' .. '9' )+ )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:12: ( 'e' | 'E' ) ( '+' | '-' )? ( '0' .. '9' )+
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

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:22: ( '+' | '-' )?
            	int alt12 = 2;
            	int LA12_0 = input.LA(1);

            	if ( (LA12_0 == '+' || LA12_0 == '-') )
            	{
            	    alt12 = 1;
            	}
            	switch (alt12) 
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

            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:33: ( '0' .. '9' )+
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
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:34: '0' .. '9'
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

    // $ANTLR start "OPTIONS"
    public void mOPTIONS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OPTIONS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:184:9: ( '[' (~ ( ']' ) )* ']' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:184:11: '[' (~ ( ']' ) )* ']'
            {
            	Match('['); 
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:184:15: (~ ( ']' ) )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( ((LA14_0 >= '\u0000' && LA14_0 <= '\\') || (LA14_0 >= '^' && LA14_0 <= '\uFFFF')) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:184:15: ~ ( ']' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\\') || (input.LA(1) >= '^' && input.LA(1) <= '\uFFFF') ) 
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

            	Match(']'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OPTIONS"

    // $ANTLR start "STRING"
    public void mSTRING() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STRING;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:186:8: ( '{' ( ESC_SEQ | ~ ( '\\\\' | '}' ) )* '}' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:186:10: '{' ( ESC_SEQ | ~ ( '\\\\' | '}' ) )* '}'
            {
            	Match('{'); 
            	// C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:186:14: ( ESC_SEQ | ~ ( '\\\\' | '}' ) )*
            	do 
            	{
            	    int alt15 = 3;
            	    int LA15_0 = input.LA(1);

            	    if ( (LA15_0 == '\\') )
            	    {
            	        alt15 = 1;
            	    }
            	    else if ( ((LA15_0 >= '\u0000' && LA15_0 <= '[') || (LA15_0 >= ']' && LA15_0 <= '|') || (LA15_0 >= '~' && LA15_0 <= '\uFFFF')) )
            	    {
            	        alt15 = 2;
            	    }


            	    switch (alt15) 
            		{
            			case 1 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:186:16: ESC_SEQ
            			    {
            			    	mESC_SEQ(); 

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:186:26: ~ ( '\\\\' | '}' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '[') || (input.LA(1) >= ']' && input.LA(1) <= '|') || (input.LA(1) >= '~' && input.LA(1) <= '\uFFFF') ) 
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

            	Match('}'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "STRING"

    // $ANTLR start "ESC_SEQ"
    public void mESC_SEQ() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:197:5: ( '\\\\' . )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:197:9: '\\\\' .
            {
            	Match('\\'); 
            	MatchAny(); 

            }

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
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:202:2: ( . )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:202:4: .
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
        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:8: ( BEGIN | END | BEGINTP | ENDTP | BEGINSCOPE | ENDSCOPE | NODE | DRAW | PATH | FILL | LPAR | RPAR | LBR | RBR | LBRR | RBRR | KOMMA | SCALE | EQU | SEMIC | COLON | STYLESEP | AT | LABEL | EVERYLOOP | ST_INNERSEP | ST_OUTERSEP | ST_FILL | ST_DRAW | ST_SHAPE | ST_MINSIZE | ST_LINEWIDTH | ST_DASHSTYLE | LOOP | IN | OUT | UN_PTS | UN_CM | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | ID | INT | FLOAT | COMMENT | WS | OPTIONS | STRING | SOMETHING )
        int alt16 = 57;
        alt16 = dfa16.Predict(input);
        switch (alt16) 
        {
            case 1 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:10: BEGIN
                {
                	mBEGIN(); 

                }
                break;
            case 2 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:16: END
                {
                	mEND(); 

                }
                break;
            case 3 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:20: BEGINTP
                {
                	mBEGINTP(); 

                }
                break;
            case 4 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:28: ENDTP
                {
                	mENDTP(); 

                }
                break;
            case 5 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:34: BEGINSCOPE
                {
                	mBEGINSCOPE(); 

                }
                break;
            case 6 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:45: ENDSCOPE
                {
                	mENDSCOPE(); 

                }
                break;
            case 7 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:54: NODE
                {
                	mNODE(); 

                }
                break;
            case 8 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:59: DRAW
                {
                	mDRAW(); 

                }
                break;
            case 9 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:64: PATH
                {
                	mPATH(); 

                }
                break;
            case 10 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:69: FILL
                {
                	mFILL(); 

                }
                break;
            case 11 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:74: LPAR
                {
                	mLPAR(); 

                }
                break;
            case 12 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:79: RPAR
                {
                	mRPAR(); 

                }
                break;
            case 13 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:84: LBR
                {
                	mLBR(); 

                }
                break;
            case 14 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:88: RBR
                {
                	mRBR(); 

                }
                break;
            case 15 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:92: LBRR
                {
                	mLBRR(); 

                }
                break;
            case 16 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:97: RBRR
                {
                	mRBRR(); 

                }
                break;
            case 17 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:102: KOMMA
                {
                	mKOMMA(); 

                }
                break;
            case 18 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:108: SCALE
                {
                	mSCALE(); 

                }
                break;
            case 19 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:114: EQU
                {
                	mEQU(); 

                }
                break;
            case 20 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:118: SEMIC
                {
                	mSEMIC(); 

                }
                break;
            case 21 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:124: COLON
                {
                	mCOLON(); 

                }
                break;
            case 22 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:130: STYLESEP
                {
                	mSTYLESEP(); 

                }
                break;
            case 23 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:139: AT
                {
                	mAT(); 

                }
                break;
            case 24 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:142: LABEL
                {
                	mLABEL(); 

                }
                break;
            case 25 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:148: EVERYLOOP
                {
                	mEVERYLOOP(); 

                }
                break;
            case 26 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:158: ST_INNERSEP
                {
                	mST_INNERSEP(); 

                }
                break;
            case 27 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:170: ST_OUTERSEP
                {
                	mST_OUTERSEP(); 

                }
                break;
            case 28 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:182: ST_FILL
                {
                	mST_FILL(); 

                }
                break;
            case 29 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:190: ST_DRAW
                {
                	mST_DRAW(); 

                }
                break;
            case 30 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:198: ST_SHAPE
                {
                	mST_SHAPE(); 

                }
                break;
            case 31 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:207: ST_MINSIZE
                {
                	mST_MINSIZE(); 

                }
                break;
            case 32 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:218: ST_LINEWIDTH
                {
                	mST_LINEWIDTH(); 

                }
                break;
            case 33 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:231: ST_DASHSTYLE
                {
                	mST_DASHSTYLE(); 

                }
                break;
            case 34 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:244: LOOP
                {
                	mLOOP(); 

                }
                break;
            case 35 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:249: IN
                {
                	mIN(); 

                }
                break;
            case 36 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:252: OUT
                {
                	mOUT(); 

                }
                break;
            case 37 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:256: UN_PTS
                {
                	mUN_PTS(); 

                }
                break;
            case 38 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:263: UN_CM
                {
                	mUN_CM(); 

                }
                break;
            case 39 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:269: T__62
                {
                	mT__62(); 

                }
                break;
            case 40 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:275: T__63
                {
                	mT__63(); 

                }
                break;
            case 41 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:281: T__64
                {
                	mT__64(); 

                }
                break;
            case 42 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:287: T__65
                {
                	mT__65(); 

                }
                break;
            case 43 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:293: T__66
                {
                	mT__66(); 

                }
                break;
            case 44 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:299: T__67
                {
                	mT__67(); 

                }
                break;
            case 45 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:305: T__68
                {
                	mT__68(); 

                }
                break;
            case 46 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:311: T__69
                {
                	mT__69(); 

                }
                break;
            case 47 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:317: T__70
                {
                	mT__70(); 

                }
                break;
            case 48 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:323: T__71
                {
                	mT__71(); 

                }
                break;
            case 49 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:329: T__72
                {
                	mT__72(); 

                }
                break;
            case 50 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:335: ID
                {
                	mID(); 

                }
                break;
            case 51 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:338: INT
                {
                	mINT(); 

                }
                break;
            case 52 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:342: FLOAT
                {
                	mFLOAT(); 

                }
                break;
            case 53 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:348: COMMENT
                {
                	mCOMMENT(); 

                }
                break;
            case 54 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:356: WS
                {
                	mWS(); 

                }
                break;
            case 55 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:359: OPTIONS
                {
                	mOPTIONS(); 

                }
                break;
            case 56 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:367: STRING
                {
                	mSTRING(); 

                }
                break;
            case 57 :
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:374: SOMETHING
                {
                	mSOMETHING(); 

                }
                break;

        }

    }


    protected DFA9 dfa9;
    protected DFA16 dfa16;
	private void InitializeCyclicDFAs()
	{
	    this.dfa9 = new DFA9(this);
	    this.dfa16 = new DFA16(this);
	    this.dfa16.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA16_SpecialStateTransition);
	}

    const string DFA9_eotS =
        "\x05\uffff";
    const string DFA9_eofS =
        "\x05\uffff";
    const string DFA9_minS =
        "\x02\x2e\x03\uffff";
    const string DFA9_maxS =
        "\x01\x39\x01\x65\x03\uffff";
    const string DFA9_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x01";
    const string DFA9_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA9_transitionS = {
            "\x01\x02\x01\uffff\x0a\x01",
            "\x01\x04\x01\uffff\x0a\x01\x0b\uffff\x01\x03\x1f\uffff\x01"+
            "\x03",
            "",
            "",
            ""
    };

    static readonly short[] DFA9_eot = DFA.UnpackEncodedString(DFA9_eotS);
    static readonly short[] DFA9_eof = DFA.UnpackEncodedString(DFA9_eofS);
    static readonly char[] DFA9_min = DFA.UnpackEncodedStringToUnsignedChars(DFA9_minS);
    static readonly char[] DFA9_max = DFA.UnpackEncodedStringToUnsignedChars(DFA9_maxS);
    static readonly short[] DFA9_accept = DFA.UnpackEncodedString(DFA9_acceptS);
    static readonly short[] DFA9_special = DFA.UnpackEncodedString(DFA9_specialS);
    static readonly short[][] DFA9_transition = DFA.UnpackEncodedStringArray(DFA9_transitionS);

    protected class DFA9 : DFA
    {
        public DFA9(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 9;
            this.eot = DFA9_eot;
            this.eof = DFA9_eof;
            this.min = DFA9_min;
            this.max = DFA9_max;
            this.accept = DFA9_accept;
            this.special = DFA9_special;
            this.transition = DFA9_transition;

        }

        override public string Description
        {
            get { return "164:1: FLOAT : ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* ( EXPONENT )? | '.' ( '0' .. '9' )+ ( EXPONENT )? | ( '0' .. '9' )+ EXPONENT );"; }
        }

    }

    const string DFA16_eotS =
        "\x01\uffff\x01\x22\x02\uffff\x01\x2b\x01\uffff\x01\x2e\x02\uffff"+
        "\x01\x34\x03\uffff\x01\x22\x0b\x34\x02\x22\x01\x34\x01\x50\x01\uffff"+
        "\x01\x51\x02\x22\x11\uffff\x02\x34\x05\uffff\x01\x5a\x05\x34\x01"+
        "\x60\x01\x62\x05\x34\x01\x68\x01\x69\x01\x6a\x01\x34\x04\uffff\x01"+
        "\x6c\x03\uffff\x01\x51\x05\uffff\x02\x34\x01\uffff\x05\x34\x01\uffff"+
        "\x01\x34\x01\uffff\x01\x78\x04\x34\x03\uffff\x01\x34\x02\uffff\x01"+
        "\u0080\x04\x34\x01\u0085\x01\x34\x01\u0087\x02\x34\x01\uffff\x01"+
        "\u008a\x01\u008b\x02\x34\x01\u008e\x03\uffff\x01\u0092\x01\u0093"+
        "\x01\u0094\x02\uffff\x01\x34\x01\uffff\x02\x34\x03\uffff\x01\x34"+
        "\x01\uffff\x01\u009a\x08\uffff\x01\x34\x02\uffff\x01\x34\x03\uffff";
    const string DFA16_eofS =
        "\u009f\uffff";
    const string DFA16_minS =
        "\x01\x00\x01\x62\x02\uffff\x01\x00\x01\uffff\x01\x00\x02\uffff"+
        "\x01\x63\x03\uffff\x01\x2e\x01\x74\x01\x61\x01\x64\x01\x6e\x01\x75"+
        "\x01\x69\x01\x61\x01\x69\x01\x74\x01\x6d\x01\x6f\x02\x2d\x01\x6f"+
        "\x01\x2b\x01\uffff\x01\x2e\x01\x30\x01\x00\x02\uffff\x01\x65\x01"+
        "\x6e\x0d\uffff\x02\x61\x05\uffff\x01\x30\x01\x62\x01\x6e\x01\x6f"+
        "\x01\x65\x01\x67\x02\x30\x01\x74\x01\x6c\x01\x61\x01\x73\x01\x6e"+
        "\x03\x30\x01\x64\x04\uffff\x01\x30\x03\uffff\x01\x2e\x03\uffff\x01"+
        "\x67\x01\x64\x01\x6c\x01\x70\x01\uffff\x02\x65\x01\x70\x01\x72\x01"+
        "\x65\x01\uffff\x01\x65\x01\uffff\x01\x30\x01\x6c\x01\x77\x01\x68"+
        "\x01\x69\x03\uffff\x01\x65\x01\uffff\x01\x69\x01\x7b\x02\x65\x01"+
        "\x6c\x01\x20\x01\x30\x01\x79\x01\x30\x02\x72\x01\uffff\x02\x30\x01"+
        "\x20\x01\x6d\x01\x30\x01\x6e\x01\x73\x01\uffff\x03\x30\x02\uffff"+
        "\x01\x20\x01\uffff\x02\x20\x03\uffff\x01\x75\x01\uffff\x01\x7b\x08"+
        "\uffff\x01\x6d\x01\x73\x01\uffff\x01\x20\x03\uffff";
    const string DFA16_maxS =
        "\x01\uffff\x01\x70\x02\uffff\x01\uffff\x01\uffff\x01\uffff\x02"+
        "\uffff\x01\x68\x03\uffff\x01\x2e\x01\x74\x01\x6f\x01\x78\x01\x6e"+
        "\x01\x75\x01\x69\x01\x72\x01\x6d\x01\x74\x01\x6d\x01\x6f\x01\x7c"+
        "\x01\x2d\x01\x6f\x01\x2b\x01\uffff\x01\x65\x01\x39\x01\uffff\x02"+
        "\uffff\x01\x65\x01\x6e\x0d\uffff\x02\x61\x05\uffff\x01\x7a\x01\x62"+
        "\x01\x6e\x01\x6f\x01\x65\x01\x67\x02\x7a\x01\x74\x01\x6c\x01\x61"+
        "\x01\x73\x01\x6e\x03\x7a\x01\x64\x04\uffff\x01\x7a\x03\uffff\x01"+
        "\x65\x03\uffff\x01\x67\x01\x64\x01\x6c\x01\x70\x01\uffff\x02\x65"+
        "\x01\x70\x01\x72\x01\x65\x01\uffff\x01\x65\x01\uffff\x01\x7a\x01"+
        "\x6c\x01\x77\x01\x68\x01\x69\x03\uffff\x01\x65\x01\uffff\x01\x69"+
        "\x01\x7b\x02\x65\x01\x6c\x01\x20\x01\x7a\x01\x79\x01\x7a\x02\x72"+
        "\x01\uffff\x02\x7a\x01\x20\x01\x6d\x01\x7a\x01\x6e\x01\x74\x01\uffff"+
        "\x03\x7a\x02\uffff\x01\x20\x01\uffff\x02\x20\x03\uffff\x01\x75\x01"+
        "\uffff\x01\x7b\x08\uffff\x01\x6d\x01\x74\x01\uffff\x01\x20\x03\uffff";
    const string DFA16_acceptS =
        "\x02\uffff\x01\x0b\x01\x0c\x01\uffff\x01\x0e\x01\uffff\x01\x10"+
        "\x01\x11\x01\uffff\x01\x13\x01\x14\x01\x15\x10\uffff\x01\x32\x03"+
        "\uffff\x01\x36\x01\x39\x02\uffff\x01\x07\x01\x08\x01\x09\x01\x0a"+
        "\x01\x0b\x01\x0c\x01\x0d\x01\x37\x01\x0e\x01\x0f\x01\x38\x01\x10"+
        "\x01\x11\x02\uffff\x01\x32\x01\x13\x01\x14\x01\x15\x01\x16\x11\uffff"+
        "\x01\x28\x01\x2a\x01\x2c\x01\x2b\x01\uffff\x01\x2f\x01\x2e\x01\x33"+
        "\x01\uffff\x01\x34\x01\x35\x01\x36\x04\uffff\x01\x17\x05\uffff\x01"+
        "\x30\x01\uffff\x01\x23\x05\uffff\x01\x31\x01\x25\x01\x26\x01\uffff"+
        "\x01\x2d\x0b\uffff\x01\x24\x07\uffff\x01\x02\x03\uffff\x01\x20\x01"+
        "\x22\x01\uffff\x01\x29\x02\uffff\x01\x1c\x01\x1d\x01\x21\x01\uffff"+
        "\x01\x27\x01\uffff\x01\x04\x01\x06\x01\x12\x01\x1e\x01\x18\x01\x19"+
        "\x01\x1a\x01\x1b\x02\uffff\x01\x01\x01\uffff\x01\x03\x01\x05\x01"+
        "\x1f";
    const string DFA16_specialS =
        "\x01\x03\x03\uffff\x01\x02\x01\uffff\x01\x01\x19\uffff\x01\x00"+
        "\x7e\uffff}>";
    static readonly string[] DFA16_transitionS = {
            "\x09\x22\x02\x21\x02\x22\x01\x21\x12\x22\x01\x21\x04\x22\x01"+
            "\x20\x02\x22\x01\x02\x01\x03\x01\x22\x01\x1c\x01\x08\x01\x19"+
            "\x01\x1f\x01\x0d\x0a\x1e\x01\x0c\x01\x0b\x01\x22\x01\x0a\x03"+
            "\x22\x1a\x1d\x01\x04\x01\x01\x01\x05\x01\x22\x01\x1d\x01\x22"+
            "\x01\x0e\x01\x1d\x01\x17\x01\x14\x01\x10\x01\x13\x02\x1d\x01"+
            "\x11\x02\x1d\x01\x0f\x01\x15\x01\x18\x01\x12\x01\x16\x02\x1d"+
            "\x01\x09\x01\x1b\x06\x1d\x01\x06\x01\x1a\x01\x07\uff82\x22",
            "\x01\x23\x01\uffff\x01\x26\x01\x24\x01\x28\x07\uffff\x01\x25"+
            "\x01\uffff\x01\x27",
            "",
            "",
            "\x00\x2c",
            "",
            "\x00\x2f",
            "",
            "",
            "\x01\x32\x04\uffff\x01\x33",
            "",
            "",
            "",
            "\x01\x38",
            "\x01\x39",
            "\x01\x3a\x07\uffff\x01\x3b\x05\uffff\x01\x3c",
            "\x01\x3e\x11\uffff\x01\x3d\x01\uffff\x01\x3f",
            "\x01\x40",
            "\x01\x41",
            "\x01\x42",
            "\x01\x44\x10\uffff\x01\x43",
            "\x01\x45\x03\uffff\x01\x46",
            "\x01\x47",
            "\x01\x48",
            "\x01\x49",
            "\x01\x4a\x10\uffff\x01\x4b\x3d\uffff\x01\x4c",
            "\x01\x4d",
            "\x01\x4e",
            "\x01\x4f",
            "",
            "\x01\x53\x01\uffff\x0a\x52\x0b\uffff\x01\x53\x1f\uffff\x01"+
            "\x53",
            "\x0a\x53",
            "\x00\x54",
            "",
            "",
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
            "\x01\x58",
            "\x01\x59",
            "",
            "",
            "",
            "",
            "",
            "\x0a\x34\x07\uffff\x1a\x34\x04\uffff\x01\x34\x01\uffff\x1a"+
            "\x34",
            "\x01\x5b",
            "\x01\x5c",
            "\x01\x5d",
            "\x01\x5e",
            "\x01\x5f",
            "\x0a\x34\x07\uffff\x1a\x34\x04\uffff\x01\x34\x01\uffff\x1a"+
            "\x34",
            "\x0a\x34\x07\uffff\x1a\x34\x04\uffff\x01\x34\x01\uffff\x0d"+
            "\x34\x01\x61\x0c\x34",
            "\x01\x63",
            "\x01\x64",
            "\x01\x65",
            "\x01\x66",
            "\x01\x67",
            "\x0a\x34\x07\uffff\x1a\x34\x04\uffff\x01\x34\x01\uffff\x1a"+
            "\x34",
            "\x0a\x34\x07\uffff\x1a\x34\x04\uffff\x01\x34\x01\uffff\x1a"+
            "\x34",
            "\x0a\x34\x07\uffff\x1a\x34\x04\uffff\x01\x34\x01\uffff\x1a"+
            "\x34",
            "\x01\x6b",
            "",
            "",
            "",
            "",
            "\x0a\x34\x07\uffff\x1a\x34\x04\uffff\x01\x34\x01\uffff\x1a"+
            "\x34",
            "",
            "",
            "",
            "\x01\x53\x01\uffff\x0a\x52\x0b\uffff\x01\x53\x1f\uffff\x01"+
            "\x53",
            "",
            "",
            "",
            "\x01\x6d",
            "\x01\x6e",
            "\x01\x6f",
            "\x01\x70",
            "",
            "\x01\x71",
            "\x01\x72",
            "\x01\x73",
            "\x01\x74",
            "\x01\x75",
            "",
            "\x01\x76",
            "",
            "\x0a\x34\x07\uffff\x1a\x34\x04\uffff\x01\x34\x01\uffff\x04"+
            "\x34\x01\x77\x15\x34",
            "\x01\x79",
            "\x01\x7a",
            "\x01\x7b",
            "\x01\x7c",
            "",
            "",
            "",
            "\x01\x7d",
            "",
            "\x01\x7e",
            "\x01\x7f",
            "\x01\u0081",
            "\x01\u0082",
            "\x01\u0083",
            "\x01\u0084",
            "\x0a\x34\x07\uffff\x1a\x34\x04\uffff\x01\x34\x01\uffff\x1a"+
            "\x34",
            "\x01\u0086",
            "\x0a\x34\x07\uffff\x1a\x34\x04\uffff\x01\x34\x01\uffff\x1a"+
            "\x34",
            "\x01\u0088",
            "\x01\u0089",
            "",
            "\x0a\x34\x07\uffff\x1a\x34\x04\uffff\x01\x34\x01\uffff\x1a"+
            "\x34",
            "\x0a\x34\x07\uffff\x1a\x34\x04\uffff\x01\x34\x01\uffff\x1a"+
            "\x34",
            "\x01\u008c",
            "\x01\u008d",
            "\x0a\x34\x07\uffff\x1a\x34\x04\uffff\x01\x34\x01\uffff\x1a"+
            "\x34",
            "\x01\u008f",
            "\x01\u0091\x01\u0090",
            "",
            "\x0a\x34\x07\uffff\x1a\x34\x04\uffff\x01\x34\x01\uffff\x1a"+
            "\x34",
            "\x0a\x34\x07\uffff\x1a\x34\x04\uffff\x01\x34\x01\uffff\x1a"+
            "\x34",
            "\x0a\x34\x07\uffff\x1a\x34\x04\uffff\x01\x34\x01\uffff\x1a"+
            "\x34",
            "",
            "",
            "\x01\u0095",
            "",
            "\x01\u0096",
            "\x01\u0097",
            "",
            "",
            "",
            "\x01\u0098",
            "",
            "\x01\u0099",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\u009b",
            "\x01\u009d\x01\u009c",
            "",
            "\x01\u009e",
            "",
            "",
            ""
    };

    static readonly short[] DFA16_eot = DFA.UnpackEncodedString(DFA16_eotS);
    static readonly short[] DFA16_eof = DFA.UnpackEncodedString(DFA16_eofS);
    static readonly char[] DFA16_min = DFA.UnpackEncodedStringToUnsignedChars(DFA16_minS);
    static readonly char[] DFA16_max = DFA.UnpackEncodedStringToUnsignedChars(DFA16_maxS);
    static readonly short[] DFA16_accept = DFA.UnpackEncodedString(DFA16_acceptS);
    static readonly short[] DFA16_special = DFA.UnpackEncodedString(DFA16_specialS);
    static readonly short[][] DFA16_transition = DFA.UnpackEncodedStringArray(DFA16_transitionS);

    protected class DFA16 : DFA
    {
        public DFA16(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 16;
            this.eot = DFA16_eot;
            this.eof = DFA16_eof;
            this.min = DFA16_min;
            this.max = DFA16_max;
            this.accept = DFA16_accept;
            this.special = DFA16_special;
            this.transition = DFA16_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( BEGIN | END | BEGINTP | ENDTP | BEGINSCOPE | ENDSCOPE | NODE | DRAW | PATH | FILL | LPAR | RPAR | LBR | RBR | LBRR | RBRR | KOMMA | SCALE | EQU | SEMIC | COLON | STYLESEP | AT | LABEL | EVERYLOOP | ST_INNERSEP | ST_OUTERSEP | ST_FILL | ST_DRAW | ST_SHAPE | ST_MINSIZE | ST_LINEWIDTH | ST_DASHSTYLE | LOOP | IN | OUT | UN_PTS | UN_CM | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | ID | INT | FLOAT | COMMENT | WS | OPTIONS | STRING | SOMETHING );"; }
        }

    }


    protected internal int DFA16_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            IIntStream input = _input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA16_32 = input.LA(1);

                   	s = -1;
                   	if ( ((LA16_32 >= '\u0000' && LA16_32 <= '\uFFFF')) ) { s = 84; }

                   	else s = 34;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA16_6 = input.LA(1);

                   	s = -1;
                   	if ( ((LA16_6 >= '\u0000' && LA16_6 <= '\uFFFF')) ) { s = 47; }

                   	else s = 46;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA16_4 = input.LA(1);

                   	s = -1;
                   	if ( ((LA16_4 >= '\u0000' && LA16_4 <= '\uFFFF')) ) { s = 44; }

                   	else s = 43;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA16_0 = input.LA(1);

                   	s = -1;
                   	if ( (LA16_0 == '\\') ) { s = 1; }

                   	else if ( (LA16_0 == '(') ) { s = 2; }

                   	else if ( (LA16_0 == ')') ) { s = 3; }

                   	else if ( (LA16_0 == '[') ) { s = 4; }

                   	else if ( (LA16_0 == ']') ) { s = 5; }

                   	else if ( (LA16_0 == '{') ) { s = 6; }

                   	else if ( (LA16_0 == '}') ) { s = 7; }

                   	else if ( (LA16_0 == ',') ) { s = 8; }

                   	else if ( (LA16_0 == 's') ) { s = 9; }

                   	else if ( (LA16_0 == '=') ) { s = 10; }

                   	else if ( (LA16_0 == ';') ) { s = 11; }

                   	else if ( (LA16_0 == ':') ) { s = 12; }

                   	else if ( (LA16_0 == '/') ) { s = 13; }

                   	else if ( (LA16_0 == 'a') ) { s = 14; }

                   	else if ( (LA16_0 == 'l') ) { s = 15; }

                   	else if ( (LA16_0 == 'e') ) { s = 16; }

                   	else if ( (LA16_0 == 'i') ) { s = 17; }

                   	else if ( (LA16_0 == 'o') ) { s = 18; }

                   	else if ( (LA16_0 == 'f') ) { s = 19; }

                   	else if ( (LA16_0 == 'd') ) { s = 20; }

                   	else if ( (LA16_0 == 'm') ) { s = 21; }

                   	else if ( (LA16_0 == 'p') ) { s = 22; }

                   	else if ( (LA16_0 == 'c') ) { s = 23; }

                   	else if ( (LA16_0 == 'n') ) { s = 24; }

                   	else if ( (LA16_0 == '-') ) { s = 25; }

                   	else if ( (LA16_0 == '|') ) { s = 26; }

                   	else if ( (LA16_0 == 't') ) { s = 27; }

                   	else if ( (LA16_0 == '+') ) { s = 28; }

                   	else if ( ((LA16_0 >= 'A' && LA16_0 <= 'Z') || LA16_0 == '_' || LA16_0 == 'b' || (LA16_0 >= 'g' && LA16_0 <= 'h') || (LA16_0 >= 'j' && LA16_0 <= 'k') || (LA16_0 >= 'q' && LA16_0 <= 'r') || (LA16_0 >= 'u' && LA16_0 <= 'z')) ) { s = 29; }

                   	else if ( ((LA16_0 >= '0' && LA16_0 <= '9')) ) { s = 30; }

                   	else if ( (LA16_0 == '.') ) { s = 31; }

                   	else if ( (LA16_0 == '%') ) { s = 32; }

                   	else if ( ((LA16_0 >= '\t' && LA16_0 <= '\n') || LA16_0 == '\r' || LA16_0 == ' ') ) { s = 33; }

                   	else if ( ((LA16_0 >= '\u0000' && LA16_0 <= '\b') || (LA16_0 >= '\u000B' && LA16_0 <= '\f') || (LA16_0 >= '\u000E' && LA16_0 <= '\u001F') || (LA16_0 >= '!' && LA16_0 <= '$') || (LA16_0 >= '&' && LA16_0 <= '\'') || LA16_0 == '*' || LA16_0 == '<' || (LA16_0 >= '>' && LA16_0 <= '@') || LA16_0 == '^' || LA16_0 == '`' || (LA16_0 >= '~' && LA16_0 <= '\uFFFF')) ) { s = 34; }

                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae16 =
            new NoViableAltException(dfa.Description, 16, _s, input);
        dfa.Error(nvae16);
        throw nvae16;
    }
 
    
}
