// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g 2010-11-25 01:48:24

import org.antlr.runtime.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;

public class simpletikzLexer extends Lexer {
    public static final int T__68=68;
    public static final int T__69=69;
    public static final int T__66=66;
    public static final int T__67=67;
    public static final int EXPONENT=58;
    public static final int T__64=64;
    public static final int T__65=65;
    public static final int IM_STARTTAG=50;
    public static final int T__62=62;
    public static final int T__63=63;
    public static final int RBR=17;
    public static final int IM_PATH=42;
    public static final int ST_LINEWIDTH=35;
    public static final int ST_DASHSTYLE=36;
    public static final int ST_FILL=31;
    public static final int FLOAT=55;
    public static final int BEGINTP=6;
    public static final int SOMETHING=57;
    public static final int ID=54;
    public static final int EOF=-1;
    public static final int LBR=16;
    public static final int IM_ENDTAG=51;
    public static final int AT=26;
    public static final int IM_DOCUMENT=48;
    public static final int RBRR=19;
    public static final int ESC_SEQ=61;
    public static final int IN=38;
    public static final int LPAR=14;
    public static final int EVERYLOOP=28;
    public static final int ENDTP=7;
    public static final int FILL=13;
    public static final int PATH=12;
    public static final int LOOP=37;
    public static final int BEGIN=4;
    public static final int ST_OUTERSEP=30;
    public static final int COMMENT=59;
    public static final int ST_INNERSEP=29;
    public static final int NODE=10;
    public static final int UN_PTS=40;
    public static final int STYLESEP=25;
    public static final int IM_COORD=44;
    public static final int IM_PICTURE=47;
    public static final int LBRR=18;
    public static final int BEGINSCOPE=8;
    public static final int INT=56;
    public static final int UN_CM=41;
    public static final int IM_NODE=43;
    public static final int COLON=24;
    public static final int ENDSCOPE=9;
    public static final int ST_DRAW=32;
    public static final int SCALE=21;
    public static final int IM_NUMBERUNIT=46;
    public static final int IM_SCOPE=49;
    public static final int T__71=71;
    public static final int WS=60;
    public static final int T__72=72;
    public static final int T__70=70;
    public static final int LABEL=27;
    public static final int ST_MINSIZE=34;
    public static final int OUT=39;
    public static final int KOMMA=20;
    public static final int ST_SHAPE=33;
    public static final int EQU=22;
    public static final int RPAR=15;
    public static final int SEMIC=23;
    public static final int END=5;
    public static final int IM_NODENAME=45;
    public static final int OPTIONS=52;
    public static final int DRAW=11;
    public static final int STRING=53;

    // delegates
    // delegators

    public simpletikzLexer() {;} 
    public simpletikzLexer(CharStream input) {
        this(input, new RecognizerSharedState());
    }
    public simpletikzLexer(CharStream input, RecognizerSharedState state) {
        super(input,state);

    }
    public String getGrammarFileName() { return "C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g"; }

    // $ANTLR start "BEGIN"
    public final void mBEGIN() throws RecognitionException {
        try {
            int _type = BEGIN;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:3:7: ( '\\\\begin' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:3:9: '\\\\begin'
            {
            match("\\begin"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "BEGIN"

    // $ANTLR start "END"
    public final void mEND() throws RecognitionException {
        try {
            int _type = END;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:4:5: ( '\\\\end' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:4:7: '\\\\end'
            {
            match("\\end"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "END"

    // $ANTLR start "BEGINTP"
    public final void mBEGINTP() throws RecognitionException {
        try {
            int _type = BEGINTP;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:5:9: ( '\\\\begin{tikzpicture}' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:5:11: '\\\\begin{tikzpicture}'
            {
            match("\\begin{tikzpicture}"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "BEGINTP"

    // $ANTLR start "ENDTP"
    public final void mENDTP() throws RecognitionException {
        try {
            int _type = ENDTP;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:6:7: ( '\\\\end{tikzpicture}' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:6:9: '\\\\end{tikzpicture}'
            {
            match("\\end{tikzpicture}"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "ENDTP"

    // $ANTLR start "BEGINSCOPE"
    public final void mBEGINSCOPE() throws RecognitionException {
        try {
            int _type = BEGINSCOPE;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:7:12: ( '\\\\begin{scope}' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:7:14: '\\\\begin{scope}'
            {
            match("\\begin{scope}"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "BEGINSCOPE"

    // $ANTLR start "ENDSCOPE"
    public final void mENDSCOPE() throws RecognitionException {
        try {
            int _type = ENDSCOPE;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:8:10: ( '\\\\end{scope}' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:8:12: '\\\\end{scope}'
            {
            match("\\end{scope}"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "ENDSCOPE"

    // $ANTLR start "NODE"
    public final void mNODE() throws RecognitionException {
        try {
            int _type = NODE;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:9:6: ( '\\\\node' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:9:8: '\\\\node'
            {
            match("\\node"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "NODE"

    // $ANTLR start "DRAW"
    public final void mDRAW() throws RecognitionException {
        try {
            int _type = DRAW;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:10:6: ( '\\\\draw' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:10:8: '\\\\draw'
            {
            match("\\draw"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "DRAW"

    // $ANTLR start "PATH"
    public final void mPATH() throws RecognitionException {
        try {
            int _type = PATH;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:11:6: ( '\\\\path' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:11:8: '\\\\path'
            {
            match("\\path"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "PATH"

    // $ANTLR start "FILL"
    public final void mFILL() throws RecognitionException {
        try {
            int _type = FILL;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:12:6: ( '\\\\fill' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:12:8: '\\\\fill'
            {
            match("\\fill"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "FILL"

    // $ANTLR start "LPAR"
    public final void mLPAR() throws RecognitionException {
        try {
            int _type = LPAR;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:13:6: ( '(' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:13:8: '('
            {
            match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "LPAR"

    // $ANTLR start "RPAR"
    public final void mRPAR() throws RecognitionException {
        try {
            int _type = RPAR;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:14:6: ( ')' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:14:8: ')'
            {
            match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "RPAR"

    // $ANTLR start "LBR"
    public final void mLBR() throws RecognitionException {
        try {
            int _type = LBR;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:15:5: ( '[' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:15:7: '['
            {
            match('['); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "LBR"

    // $ANTLR start "RBR"
    public final void mRBR() throws RecognitionException {
        try {
            int _type = RBR;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:16:5: ( ']' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:16:7: ']'
            {
            match(']'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "RBR"

    // $ANTLR start "LBRR"
    public final void mLBRR() throws RecognitionException {
        try {
            int _type = LBRR;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:17:6: ( '{' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:17:8: '{'
            {
            match('{'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "LBRR"

    // $ANTLR start "RBRR"
    public final void mRBRR() throws RecognitionException {
        try {
            int _type = RBRR;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:18:6: ( '}' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:18:8: '}'
            {
            match('}'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "RBRR"

    // $ANTLR start "KOMMA"
    public final void mKOMMA() throws RecognitionException {
        try {
            int _type = KOMMA;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:19:7: ( ',' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:19:9: ','
            {
            match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "KOMMA"

    // $ANTLR start "SCALE"
    public final void mSCALE() throws RecognitionException {
        try {
            int _type = SCALE;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:20:7: ( 'scale' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:20:9: 'scale'
            {
            match("scale"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "SCALE"

    // $ANTLR start "EQU"
    public final void mEQU() throws RecognitionException {
        try {
            int _type = EQU;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:21:5: ( '=' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:21:7: '='
            {
            match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "EQU"

    // $ANTLR start "SEMIC"
    public final void mSEMIC() throws RecognitionException {
        try {
            int _type = SEMIC;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:22:7: ( ';' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:22:9: ';'
            {
            match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "SEMIC"

    // $ANTLR start "COLON"
    public final void mCOLON() throws RecognitionException {
        try {
            int _type = COLON;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:23:7: ( ':' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:23:9: ':'
            {
            match(':'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "COLON"

    // $ANTLR start "STYLESEP"
    public final void mSTYLESEP() throws RecognitionException {
        try {
            int _type = STYLESEP;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:24:10: ( '/.style' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:24:12: '/.style'
            {
            match("/.style"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "STYLESEP"

    // $ANTLR start "AT"
    public final void mAT() throws RecognitionException {
        try {
            int _type = AT;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:25:4: ( 'at' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:25:6: 'at'
            {
            match("at"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "AT"

    // $ANTLR start "LABEL"
    public final void mLABEL() throws RecognitionException {
        try {
            int _type = LABEL;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:26:7: ( 'label' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:26:9: 'label'
            {
            match("label"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "LABEL"

    // $ANTLR start "EVERYLOOP"
    public final void mEVERYLOOP() throws RecognitionException {
        try {
            int _type = EVERYLOOP;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:27:11: ( 'every loop' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:27:13: 'every loop'
            {
            match("every loop"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "EVERYLOOP"

    // $ANTLR start "ST_INNERSEP"
    public final void mST_INNERSEP() throws RecognitionException {
        try {
            int _type = ST_INNERSEP;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:28:13: ( 'inner sep' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:28:15: 'inner sep'
            {
            match("inner sep"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "ST_INNERSEP"

    // $ANTLR start "ST_OUTERSEP"
    public final void mST_OUTERSEP() throws RecognitionException {
        try {
            int _type = ST_OUTERSEP;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:29:13: ( 'outer sep' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:29:15: 'outer sep'
            {
            match("outer sep"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "ST_OUTERSEP"

    // $ANTLR start "ST_FILL"
    public final void mST_FILL() throws RecognitionException {
        try {
            int _type = ST_FILL;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:30:9: ( 'fill' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:30:11: 'fill'
            {
            match("fill"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "ST_FILL"

    // $ANTLR start "ST_DRAW"
    public final void mST_DRAW() throws RecognitionException {
        try {
            int _type = ST_DRAW;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:31:9: ( 'draw' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:31:11: 'draw'
            {
            match("draw"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "ST_DRAW"

    // $ANTLR start "ST_SHAPE"
    public final void mST_SHAPE() throws RecognitionException {
        try {
            int _type = ST_SHAPE;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:32:10: ( 'shape' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:32:12: 'shape'
            {
            match("shape"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "ST_SHAPE"

    // $ANTLR start "ST_MINSIZE"
    public final void mST_MINSIZE() throws RecognitionException {
        try {
            int _type = ST_MINSIZE;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:33:12: ( 'minimum size' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:33:14: 'minimum size'
            {
            match("minimum size"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "ST_MINSIZE"

    // $ANTLR start "ST_LINEWIDTH"
    public final void mST_LINEWIDTH() throws RecognitionException {
        try {
            int _type = ST_LINEWIDTH;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:34:14: ( 'line width' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:34:16: 'line width'
            {
            match("line width"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "ST_LINEWIDTH"

    // $ANTLR start "ST_DASHSTYLE"
    public final void mST_DASHSTYLE() throws RecognitionException {
        try {
            int _type = ST_DASHSTYLE;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:35:14: ( 'dash style' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:35:16: 'dash style'
            {
            match("dash style"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "ST_DASHSTYLE"

    // $ANTLR start "LOOP"
    public final void mLOOP() throws RecognitionException {
        try {
            int _type = LOOP;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:36:6: ( 'loop' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:36:8: 'loop'
            {
            match("loop"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "LOOP"

    // $ANTLR start "IN"
    public final void mIN() throws RecognitionException {
        try {
            int _type = IN;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:37:4: ( 'in' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:37:6: 'in'
            {
            match("in"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "IN"

    // $ANTLR start "OUT"
    public final void mOUT() throws RecognitionException {
        try {
            int _type = OUT;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:38:5: ( 'out' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:38:7: 'out'
            {
            match("out"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "OUT"

    // $ANTLR start "UN_PTS"
    public final void mUN_PTS() throws RecognitionException {
        try {
            int _type = UN_PTS;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:39:8: ( 'pt' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:39:10: 'pt'
            {
            match("pt"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "UN_PTS"

    // $ANTLR start "UN_CM"
    public final void mUN_CM() throws RecognitionException {
        try {
            int _type = UN_CM;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:40:7: ( 'cm' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:40:9: 'cm'
            {
            match("cm"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "UN_CM"

    // $ANTLR start "T__62"
    public final void mT__62() throws RecognitionException {
        try {
            int _type = T__62;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:41:7: ( 'node' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:41:9: 'node'
            {
            match("node"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__62"

    // $ANTLR start "T__63"
    public final void mT__63() throws RecognitionException {
        try {
            int _type = T__63;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:42:7: ( '--' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:42:9: '--'
            {
            match("--"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__63"

    // $ANTLR start "T__64"
    public final void mT__64() throws RecognitionException {
        try {
            int _type = T__64;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:43:7: ( 'edge' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:43:9: 'edge'
            {
            match("edge"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__64"

    // $ANTLR start "T__65"
    public final void mT__65() throws RecognitionException {
        try {
            int _type = T__65;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:44:7: ( '->' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:44:9: '->'
            {
            match("->"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__65"

    // $ANTLR start "T__66"
    public final void mT__66() throws RecognitionException {
        try {
            int _type = T__66;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:45:7: ( '|-' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:45:9: '|-'
            {
            match("|-"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__66"

    // $ANTLR start "T__67"
    public final void mT__67() throws RecognitionException {
        try {
            int _type = T__67;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:46:7: ( '-|' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:46:9: '-|'
            {
            match("-|"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__67"

    // $ANTLR start "T__68"
    public final void mT__68() throws RecognitionException {
        try {
            int _type = T__68;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:47:7: ( 'to' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:47:9: 'to'
            {
            match("to"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__68"

    // $ANTLR start "T__69"
    public final void mT__69() throws RecognitionException {
        try {
            int _type = T__69;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:48:7: ( '+' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:48:9: '+'
            {
            match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__69"

    // $ANTLR start "T__70"
    public final void mT__70() throws RecognitionException {
        try {
            int _type = T__70;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:49:7: ( '++' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:49:9: '++'
            {
            match("++"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__70"

    // $ANTLR start "T__71"
    public final void mT__71() throws RecognitionException {
        try {
            int _type = T__71;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:50:7: ( 'ex' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:50:9: 'ex'
            {
            match("ex"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__71"

    // $ANTLR start "T__72"
    public final void mT__72() throws RecognitionException {
        try {
            int _type = T__72;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:51:7: ( 'mm' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:51:9: 'mm'
            {
            match("mm"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__72"

    // $ANTLR start "ID"
    public final void mID() throws RecognitionException {
        try {
            int _type = ID;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:144:5: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:144:7: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
            {
            if ( (input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z') ) {
                input.consume();

            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                recover(mse);
                throw mse;}

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:144:31: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
            loop1:
            do {
                int alt1=2;
                int LA1_0 = input.LA(1);

                if ( ((LA1_0>='0' && LA1_0<='9')||(LA1_0>='A' && LA1_0<='Z')||LA1_0=='_'||(LA1_0>='a' && LA1_0<='z')) ) {
                    alt1=1;
                }


                switch (alt1) {
            	case 1 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            	    {
            	    if ( (input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z') ) {
            	        input.consume();

            	    }
            	    else {
            	        MismatchedSetException mse = new MismatchedSetException(null,input);
            	        recover(mse);
            	        throw mse;}


            	    }
            	    break;

            	default :
            	    break loop1;
                }
            } while (true);


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "ID"

    // $ANTLR start "INT"
    public final void mINT() throws RecognitionException {
        try {
            int _type = INT;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:5: ( ( '0' .. '9' )+ )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:7: ( '0' .. '9' )+
            {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:7: ( '0' .. '9' )+
            int cnt2=0;
            loop2:
            do {
                int alt2=2;
                int LA2_0 = input.LA(1);

                if ( ((LA2_0>='0' && LA2_0<='9')) ) {
                    alt2=1;
                }


                switch (alt2) {
            	case 1 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:7: '0' .. '9'
            	    {
            	    matchRange('0','9'); 

            	    }
            	    break;

            	default :
            	    if ( cnt2 >= 1 ) break loop2;
                        EarlyExitException eee =
                            new EarlyExitException(2, input);
                        throw eee;
                }
                cnt2++;
            } while (true);


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "INT"

    // $ANTLR start "FLOAT"
    public final void mFLOAT() throws RecognitionException {
        try {
            int _type = FLOAT;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:5: ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* ( EXPONENT )? | '.' ( '0' .. '9' )+ ( EXPONENT )? | ( '0' .. '9' )+ EXPONENT )
            int alt9=3;
            alt9 = dfa9.predict(input);
            switch (alt9) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:9: ( '0' .. '9' )+ '.' ( '0' .. '9' )* ( EXPONENT )?
                    {
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:9: ( '0' .. '9' )+
                    int cnt3=0;
                    loop3:
                    do {
                        int alt3=2;
                        int LA3_0 = input.LA(1);

                        if ( ((LA3_0>='0' && LA3_0<='9')) ) {
                            alt3=1;
                        }


                        switch (alt3) {
                    	case 1 :
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:10: '0' .. '9'
                    	    {
                    	    matchRange('0','9'); 

                    	    }
                    	    break;

                    	default :
                    	    if ( cnt3 >= 1 ) break loop3;
                                EarlyExitException eee =
                                    new EarlyExitException(3, input);
                                throw eee;
                        }
                        cnt3++;
                    } while (true);

                    match('.'); 
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:25: ( '0' .. '9' )*
                    loop4:
                    do {
                        int alt4=2;
                        int LA4_0 = input.LA(1);

                        if ( ((LA4_0>='0' && LA4_0<='9')) ) {
                            alt4=1;
                        }


                        switch (alt4) {
                    	case 1 :
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:26: '0' .. '9'
                    	    {
                    	    matchRange('0','9'); 

                    	    }
                    	    break;

                    	default :
                    	    break loop4;
                        }
                    } while (true);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:37: ( EXPONENT )?
                    int alt5=2;
                    int LA5_0 = input.LA(1);

                    if ( (LA5_0=='E'||LA5_0=='e') ) {
                        alt5=1;
                    }
                    switch (alt5) {
                        case 1 :
                            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:37: EXPONENT
                            {
                            mEXPONENT(); 

                            }
                            break;

                    }


                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:152:9: '.' ( '0' .. '9' )+ ( EXPONENT )?
                    {
                    match('.'); 
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:152:13: ( '0' .. '9' )+
                    int cnt6=0;
                    loop6:
                    do {
                        int alt6=2;
                        int LA6_0 = input.LA(1);

                        if ( ((LA6_0>='0' && LA6_0<='9')) ) {
                            alt6=1;
                        }


                        switch (alt6) {
                    	case 1 :
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:152:14: '0' .. '9'
                    	    {
                    	    matchRange('0','9'); 

                    	    }
                    	    break;

                    	default :
                    	    if ( cnt6 >= 1 ) break loop6;
                                EarlyExitException eee =
                                    new EarlyExitException(6, input);
                                throw eee;
                        }
                        cnt6++;
                    } while (true);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:152:25: ( EXPONENT )?
                    int alt7=2;
                    int LA7_0 = input.LA(1);

                    if ( (LA7_0=='E'||LA7_0=='e') ) {
                        alt7=1;
                    }
                    switch (alt7) {
                        case 1 :
                            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:152:25: EXPONENT
                            {
                            mEXPONENT(); 

                            }
                            break;

                    }


                    }
                    break;
                case 3 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:153:9: ( '0' .. '9' )+ EXPONENT
                    {
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:153:9: ( '0' .. '9' )+
                    int cnt8=0;
                    loop8:
                    do {
                        int alt8=2;
                        int LA8_0 = input.LA(1);

                        if ( ((LA8_0>='0' && LA8_0<='9')) ) {
                            alt8=1;
                        }


                        switch (alt8) {
                    	case 1 :
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:153:10: '0' .. '9'
                    	    {
                    	    matchRange('0','9'); 

                    	    }
                    	    break;

                    	default :
                    	    if ( cnt8 >= 1 ) break loop8;
                                EarlyExitException eee =
                                    new EarlyExitException(8, input);
                                throw eee;
                        }
                        cnt8++;
                    } while (true);

                    mEXPONENT(); 

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "FLOAT"

    // $ANTLR start "COMMENT"
    public final void mCOMMENT() throws RecognitionException {
        try {
            int _type = COMMENT;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:157:5: ( '%' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:157:9: '%' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
            {
            match('%'); 
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:157:13: (~ ( '\\n' | '\\r' ) )*
            loop10:
            do {
                int alt10=2;
                int LA10_0 = input.LA(1);

                if ( ((LA10_0>='\u0000' && LA10_0<='\t')||(LA10_0>='\u000B' && LA10_0<='\f')||(LA10_0>='\u000E' && LA10_0<='\uFFFF')) ) {
                    alt10=1;
                }


                switch (alt10) {
            	case 1 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:157:13: ~ ( '\\n' | '\\r' )
            	    {
            	    if ( (input.LA(1)>='\u0000' && input.LA(1)<='\t')||(input.LA(1)>='\u000B' && input.LA(1)<='\f')||(input.LA(1)>='\u000E' && input.LA(1)<='\uFFFF') ) {
            	        input.consume();

            	    }
            	    else {
            	        MismatchedSetException mse = new MismatchedSetException(null,input);
            	        recover(mse);
            	        throw mse;}


            	    }
            	    break;

            	default :
            	    break loop10;
                }
            } while (true);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:157:27: ( '\\r' )?
            int alt11=2;
            int LA11_0 = input.LA(1);

            if ( (LA11_0=='\r') ) {
                alt11=1;
            }
            switch (alt11) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:157:27: '\\r'
                    {
                    match('\r'); 

                    }
                    break;

            }

            match('\n'); 
            _channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "COMMENT"

    // $ANTLR start "WS"
    public final void mWS() throws RecognitionException {
        try {
            int _type = WS;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:160:5: ( ( ' ' | '\\t' | '\\r' | '\\n' ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:160:9: ( ' ' | '\\t' | '\\r' | '\\n' )
            {
            if ( (input.LA(1)>='\t' && input.LA(1)<='\n')||input.LA(1)=='\r'||input.LA(1)==' ' ) {
                input.consume();

            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                recover(mse);
                throw mse;}

            _channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "WS"

    // $ANTLR start "EXPONENT"
    public final void mEXPONENT() throws RecognitionException {
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:168:10: ( ( 'e' | 'E' ) ( '+' | '-' )? ( '0' .. '9' )+ )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:168:12: ( 'e' | 'E' ) ( '+' | '-' )? ( '0' .. '9' )+
            {
            if ( input.LA(1)=='E'||input.LA(1)=='e' ) {
                input.consume();

            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                recover(mse);
                throw mse;}

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:168:22: ( '+' | '-' )?
            int alt12=2;
            int LA12_0 = input.LA(1);

            if ( (LA12_0=='+'||LA12_0=='-') ) {
                alt12=1;
            }
            switch (alt12) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
                    {
                    if ( input.LA(1)=='+'||input.LA(1)=='-' ) {
                        input.consume();

                    }
                    else {
                        MismatchedSetException mse = new MismatchedSetException(null,input);
                        recover(mse);
                        throw mse;}


                    }
                    break;

            }

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:168:33: ( '0' .. '9' )+
            int cnt13=0;
            loop13:
            do {
                int alt13=2;
                int LA13_0 = input.LA(1);

                if ( ((LA13_0>='0' && LA13_0<='9')) ) {
                    alt13=1;
                }


                switch (alt13) {
            	case 1 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:168:34: '0' .. '9'
            	    {
            	    matchRange('0','9'); 

            	    }
            	    break;

            	default :
            	    if ( cnt13 >= 1 ) break loop13;
                        EarlyExitException eee =
                            new EarlyExitException(13, input);
                        throw eee;
                }
                cnt13++;
            } while (true);


            }

        }
        finally {
        }
    }
    // $ANTLR end "EXPONENT"

    // $ANTLR start "OPTIONS"
    public final void mOPTIONS() throws RecognitionException {
        try {
            int _type = OPTIONS;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:170:9: ( '[' (~ ( ']' ) )* ']' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:170:11: '[' (~ ( ']' ) )* ']'
            {
            match('['); 
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:170:15: (~ ( ']' ) )*
            loop14:
            do {
                int alt14=2;
                int LA14_0 = input.LA(1);

                if ( ((LA14_0>='\u0000' && LA14_0<='\\')||(LA14_0>='^' && LA14_0<='\uFFFF')) ) {
                    alt14=1;
                }


                switch (alt14) {
            	case 1 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:170:15: ~ ( ']' )
            	    {
            	    if ( (input.LA(1)>='\u0000' && input.LA(1)<='\\')||(input.LA(1)>='^' && input.LA(1)<='\uFFFF') ) {
            	        input.consume();

            	    }
            	    else {
            	        MismatchedSetException mse = new MismatchedSetException(null,input);
            	        recover(mse);
            	        throw mse;}


            	    }
            	    break;

            	default :
            	    break loop14;
                }
            } while (true);

            match(']'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "OPTIONS"

    // $ANTLR start "STRING"
    public final void mSTRING() throws RecognitionException {
        try {
            int _type = STRING;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:172:8: ( '{' ( ESC_SEQ | ~ ( '\\\\' | '}' ) )* '}' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:172:10: '{' ( ESC_SEQ | ~ ( '\\\\' | '}' ) )* '}'
            {
            match('{'); 
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:172:14: ( ESC_SEQ | ~ ( '\\\\' | '}' ) )*
            loop15:
            do {
                int alt15=3;
                int LA15_0 = input.LA(1);

                if ( (LA15_0=='\\') ) {
                    alt15=1;
                }
                else if ( ((LA15_0>='\u0000' && LA15_0<='[')||(LA15_0>=']' && LA15_0<='|')||(LA15_0>='~' && LA15_0<='\uFFFF')) ) {
                    alt15=2;
                }


                switch (alt15) {
            	case 1 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:172:16: ESC_SEQ
            	    {
            	    mESC_SEQ(); 

            	    }
            	    break;
            	case 2 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:172:26: ~ ( '\\\\' | '}' )
            	    {
            	    if ( (input.LA(1)>='\u0000' && input.LA(1)<='[')||(input.LA(1)>=']' && input.LA(1)<='|')||(input.LA(1)>='~' && input.LA(1)<='\uFFFF') ) {
            	        input.consume();

            	    }
            	    else {
            	        MismatchedSetException mse = new MismatchedSetException(null,input);
            	        recover(mse);
            	        throw mse;}


            	    }
            	    break;

            	default :
            	    break loop15;
                }
            } while (true);

            match('}'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "STRING"

    // $ANTLR start "ESC_SEQ"
    public final void mESC_SEQ() throws RecognitionException {
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:5: ( '\\\\' . )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:9: '\\\\' .
            {
            match('\\'); 
            matchAny(); 

            }

        }
        finally {
        }
    }
    // $ANTLR end "ESC_SEQ"

    // $ANTLR start "SOMETHING"
    public final void mSOMETHING() throws RecognitionException {
        try {
            int _type = SOMETHING;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:188:2: ( . )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:188:4: .
            {
            matchAny(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "SOMETHING"

    public void mTokens() throws RecognitionException {
        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:1:8: ( BEGIN | END | BEGINTP | ENDTP | BEGINSCOPE | ENDSCOPE | NODE | DRAW | PATH | FILL | LPAR | RPAR | LBR | RBR | LBRR | RBRR | KOMMA | SCALE | EQU | SEMIC | COLON | STYLESEP | AT | LABEL | EVERYLOOP | ST_INNERSEP | ST_OUTERSEP | ST_FILL | ST_DRAW | ST_SHAPE | ST_MINSIZE | ST_LINEWIDTH | ST_DASHSTYLE | LOOP | IN | OUT | UN_PTS | UN_CM | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | ID | INT | FLOAT | COMMENT | WS | OPTIONS | STRING | SOMETHING )
        int alt16=57;
        alt16 = dfa16.predict(input);
        switch (alt16) {
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


    protected DFA9 dfa9 = new DFA9(this);
    protected DFA16 dfa16 = new DFA16(this);
    static final String DFA9_eotS =
        "\5\uffff";
    static final String DFA9_eofS =
        "\5\uffff";
    static final String DFA9_minS =
        "\2\56\3\uffff";
    static final String DFA9_maxS =
        "\1\71\1\145\3\uffff";
    static final String DFA9_acceptS =
        "\2\uffff\1\2\1\3\1\1";
    static final String DFA9_specialS =
        "\5\uffff}>";
    static final String[] DFA9_transitionS = {
            "\1\2\1\uffff\12\1",
            "\1\4\1\uffff\12\1\13\uffff\1\3\37\uffff\1\3",
            "",
            "",
            ""
    };

    static final short[] DFA9_eot = DFA.unpackEncodedString(DFA9_eotS);
    static final short[] DFA9_eof = DFA.unpackEncodedString(DFA9_eofS);
    static final char[] DFA9_min = DFA.unpackEncodedStringToUnsignedChars(DFA9_minS);
    static final char[] DFA9_max = DFA.unpackEncodedStringToUnsignedChars(DFA9_maxS);
    static final short[] DFA9_accept = DFA.unpackEncodedString(DFA9_acceptS);
    static final short[] DFA9_special = DFA.unpackEncodedString(DFA9_specialS);
    static final short[][] DFA9_transition;

    static {
        int numStates = DFA9_transitionS.length;
        DFA9_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA9_transition[i] = DFA.unpackEncodedString(DFA9_transitionS[i]);
        }
    }

    class DFA9 extends DFA {

        public DFA9(BaseRecognizer recognizer) {
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
        public String getDescription() {
            return "150:1: FLOAT : ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* ( EXPONENT )? | '.' ( '0' .. '9' )+ ( EXPONENT )? | ( '0' .. '9' )+ EXPONENT );";
        }
    }
    static final String DFA16_eotS =
        "\1\uffff\1\42\2\uffff\1\53\1\uffff\1\56\2\uffff\1\64\3\uffff\1"+
        "\42\13\64\2\42\1\64\1\120\1\uffff\1\121\2\42\21\uffff\2\64\5\uffff"+
        "\1\132\5\64\1\140\1\142\5\64\1\150\1\151\1\152\1\64\4\uffff\1\154"+
        "\3\uffff\1\121\5\uffff\2\64\1\uffff\5\64\1\uffff\1\64\1\uffff\1"+
        "\170\4\64\3\uffff\1\64\2\uffff\1\u0080\4\64\1\u0085\1\64\1\u0087"+
        "\2\64\1\uffff\1\u008a\1\u008b\2\64\1\u008e\3\uffff\1\u0092\1\u0093"+
        "\1\u0094\2\uffff\1\64\1\uffff\2\64\3\uffff\1\64\1\uffff\1\u009a"+
        "\10\uffff\1\64\2\uffff\1\64\3\uffff";
    static final String DFA16_eofS =
        "\u009f\uffff";
    static final String DFA16_minS =
        "\1\0\1\142\2\uffff\1\0\1\uffff\1\0\2\uffff\1\143\3\uffff\1\56\1"+
        "\164\1\141\1\144\1\156\1\165\1\151\1\141\1\151\1\164\1\155\1\157"+
        "\2\55\1\157\1\53\1\uffff\1\56\1\60\1\0\2\uffff\1\145\1\156\15\uffff"+
        "\2\141\5\uffff\1\60\1\142\1\156\1\157\1\145\1\147\2\60\1\164\1\154"+
        "\1\141\1\163\1\156\3\60\1\144\4\uffff\1\60\3\uffff\1\56\3\uffff"+
        "\1\147\1\144\1\154\1\160\1\uffff\2\145\1\160\1\162\1\145\1\uffff"+
        "\1\145\1\uffff\1\60\1\154\1\167\1\150\1\151\3\uffff\1\145\1\uffff"+
        "\1\151\1\173\2\145\1\154\1\40\1\60\1\171\1\60\2\162\1\uffff\2\60"+
        "\1\40\1\155\1\60\1\156\1\163\1\uffff\3\60\2\uffff\1\40\1\uffff\2"+
        "\40\3\uffff\1\165\1\uffff\1\173\10\uffff\1\155\1\163\1\uffff\1\40"+
        "\3\uffff";
    static final String DFA16_maxS =
        "\1\uffff\1\160\2\uffff\1\uffff\1\uffff\1\uffff\2\uffff\1\150\3"+
        "\uffff\1\56\1\164\1\157\1\170\1\156\1\165\1\151\1\162\1\155\1\164"+
        "\1\155\1\157\1\174\1\55\1\157\1\53\1\uffff\1\145\1\71\1\uffff\2"+
        "\uffff\1\145\1\156\15\uffff\2\141\5\uffff\1\172\1\142\1\156\1\157"+
        "\1\145\1\147\2\172\1\164\1\154\1\141\1\163\1\156\3\172\1\144\4\uffff"+
        "\1\172\3\uffff\1\145\3\uffff\1\147\1\144\1\154\1\160\1\uffff\2\145"+
        "\1\160\1\162\1\145\1\uffff\1\145\1\uffff\1\172\1\154\1\167\1\150"+
        "\1\151\3\uffff\1\145\1\uffff\1\151\1\173\2\145\1\154\1\40\1\172"+
        "\1\171\1\172\2\162\1\uffff\2\172\1\40\1\155\1\172\1\156\1\164\1"+
        "\uffff\3\172\2\uffff\1\40\1\uffff\2\40\3\uffff\1\165\1\uffff\1\173"+
        "\10\uffff\1\155\1\164\1\uffff\1\40\3\uffff";
    static final String DFA16_acceptS =
        "\2\uffff\1\13\1\14\1\uffff\1\16\1\uffff\1\20\1\21\1\uffff\1\23"+
        "\1\24\1\25\20\uffff\1\62\3\uffff\1\66\1\71\2\uffff\1\7\1\10\1\11"+
        "\1\12\1\13\1\14\1\15\1\67\1\16\1\17\1\70\1\20\1\21\2\uffff\1\62"+
        "\1\23\1\24\1\25\1\26\21\uffff\1\50\1\52\1\54\1\53\1\uffff\1\57\1"+
        "\56\1\63\1\uffff\1\64\1\65\1\66\4\uffff\1\27\5\uffff\1\60\1\uffff"+
        "\1\43\5\uffff\1\61\1\45\1\46\1\uffff\1\55\13\uffff\1\44\7\uffff"+
        "\1\2\3\uffff\1\40\1\42\1\uffff\1\51\2\uffff\1\34\1\35\1\41\1\uffff"+
        "\1\47\1\uffff\1\4\1\6\1\22\1\36\1\30\1\31\1\32\1\33\2\uffff\1\1"+
        "\1\uffff\1\3\1\5\1\37";
    static final String DFA16_specialS =
        "\1\3\3\uffff\1\2\1\uffff\1\1\31\uffff\1\0\176\uffff}>";
    static final String[] DFA16_transitionS = {
            "\11\42\2\41\2\42\1\41\22\42\1\41\4\42\1\40\2\42\1\2\1\3\1\42"+
            "\1\34\1\10\1\31\1\37\1\15\12\36\1\14\1\13\1\42\1\12\3\42\32"+
            "\35\1\4\1\1\1\5\1\42\1\35\1\42\1\16\1\35\1\27\1\24\1\20\1\23"+
            "\2\35\1\21\2\35\1\17\1\25\1\30\1\22\1\26\2\35\1\11\1\33\6\35"+
            "\1\6\1\32\1\7\uff82\42",
            "\1\43\1\uffff\1\46\1\44\1\50\7\uffff\1\45\1\uffff\1\47",
            "",
            "",
            "\0\54",
            "",
            "\0\57",
            "",
            "",
            "\1\62\4\uffff\1\63",
            "",
            "",
            "",
            "\1\70",
            "\1\71",
            "\1\72\7\uffff\1\73\5\uffff\1\74",
            "\1\76\21\uffff\1\75\1\uffff\1\77",
            "\1\100",
            "\1\101",
            "\1\102",
            "\1\104\20\uffff\1\103",
            "\1\105\3\uffff\1\106",
            "\1\107",
            "\1\110",
            "\1\111",
            "\1\112\20\uffff\1\113\75\uffff\1\114",
            "\1\115",
            "\1\116",
            "\1\117",
            "",
            "\1\123\1\uffff\12\122\13\uffff\1\123\37\uffff\1\123",
            "\12\123",
            "\0\124",
            "",
            "",
            "\1\126",
            "\1\127",
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
            "\1\130",
            "\1\131",
            "",
            "",
            "",
            "",
            "",
            "\12\64\7\uffff\32\64\4\uffff\1\64\1\uffff\32\64",
            "\1\133",
            "\1\134",
            "\1\135",
            "\1\136",
            "\1\137",
            "\12\64\7\uffff\32\64\4\uffff\1\64\1\uffff\32\64",
            "\12\64\7\uffff\32\64\4\uffff\1\64\1\uffff\15\64\1\141\14\64",
            "\1\143",
            "\1\144",
            "\1\145",
            "\1\146",
            "\1\147",
            "\12\64\7\uffff\32\64\4\uffff\1\64\1\uffff\32\64",
            "\12\64\7\uffff\32\64\4\uffff\1\64\1\uffff\32\64",
            "\12\64\7\uffff\32\64\4\uffff\1\64\1\uffff\32\64",
            "\1\153",
            "",
            "",
            "",
            "",
            "\12\64\7\uffff\32\64\4\uffff\1\64\1\uffff\32\64",
            "",
            "",
            "",
            "\1\123\1\uffff\12\122\13\uffff\1\123\37\uffff\1\123",
            "",
            "",
            "",
            "\1\155",
            "\1\156",
            "\1\157",
            "\1\160",
            "",
            "\1\161",
            "\1\162",
            "\1\163",
            "\1\164",
            "\1\165",
            "",
            "\1\166",
            "",
            "\12\64\7\uffff\32\64\4\uffff\1\64\1\uffff\4\64\1\167\25\64",
            "\1\171",
            "\1\172",
            "\1\173",
            "\1\174",
            "",
            "",
            "",
            "\1\175",
            "",
            "\1\176",
            "\1\177",
            "\1\u0081",
            "\1\u0082",
            "\1\u0083",
            "\1\u0084",
            "\12\64\7\uffff\32\64\4\uffff\1\64\1\uffff\32\64",
            "\1\u0086",
            "\12\64\7\uffff\32\64\4\uffff\1\64\1\uffff\32\64",
            "\1\u0088",
            "\1\u0089",
            "",
            "\12\64\7\uffff\32\64\4\uffff\1\64\1\uffff\32\64",
            "\12\64\7\uffff\32\64\4\uffff\1\64\1\uffff\32\64",
            "\1\u008c",
            "\1\u008d",
            "\12\64\7\uffff\32\64\4\uffff\1\64\1\uffff\32\64",
            "\1\u008f",
            "\1\u0091\1\u0090",
            "",
            "\12\64\7\uffff\32\64\4\uffff\1\64\1\uffff\32\64",
            "\12\64\7\uffff\32\64\4\uffff\1\64\1\uffff\32\64",
            "\12\64\7\uffff\32\64\4\uffff\1\64\1\uffff\32\64",
            "",
            "",
            "\1\u0095",
            "",
            "\1\u0096",
            "\1\u0097",
            "",
            "",
            "",
            "\1\u0098",
            "",
            "\1\u0099",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\1\u009b",
            "\1\u009d\1\u009c",
            "",
            "\1\u009e",
            "",
            "",
            ""
    };

    static final short[] DFA16_eot = DFA.unpackEncodedString(DFA16_eotS);
    static final short[] DFA16_eof = DFA.unpackEncodedString(DFA16_eofS);
    static final char[] DFA16_min = DFA.unpackEncodedStringToUnsignedChars(DFA16_minS);
    static final char[] DFA16_max = DFA.unpackEncodedStringToUnsignedChars(DFA16_maxS);
    static final short[] DFA16_accept = DFA.unpackEncodedString(DFA16_acceptS);
    static final short[] DFA16_special = DFA.unpackEncodedString(DFA16_specialS);
    static final short[][] DFA16_transition;

    static {
        int numStates = DFA16_transitionS.length;
        DFA16_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA16_transition[i] = DFA.unpackEncodedString(DFA16_transitionS[i]);
        }
    }

    class DFA16 extends DFA {

        public DFA16(BaseRecognizer recognizer) {
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
        public String getDescription() {
            return "1:1: Tokens : ( BEGIN | END | BEGINTP | ENDTP | BEGINSCOPE | ENDSCOPE | NODE | DRAW | PATH | FILL | LPAR | RPAR | LBR | RBR | LBRR | RBRR | KOMMA | SCALE | EQU | SEMIC | COLON | STYLESEP | AT | LABEL | EVERYLOOP | ST_INNERSEP | ST_OUTERSEP | ST_FILL | ST_DRAW | ST_SHAPE | ST_MINSIZE | ST_LINEWIDTH | ST_DASHSTYLE | LOOP | IN | OUT | UN_PTS | UN_CM | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | ID | INT | FLOAT | COMMENT | WS | OPTIONS | STRING | SOMETHING );";
        }
        public int specialStateTransition(int s, IntStream _input) throws NoViableAltException {
            IntStream input = _input;
        	int _s = s;
            switch ( s ) {
                    case 0 : 
                        int LA16_32 = input.LA(1);

                        s = -1;
                        if ( ((LA16_32>='\u0000' && LA16_32<='\uFFFF')) ) {s = 84;}

                        else s = 34;

                        if ( s>=0 ) return s;
                        break;
                    case 1 : 
                        int LA16_6 = input.LA(1);

                        s = -1;
                        if ( ((LA16_6>='\u0000' && LA16_6<='\uFFFF')) ) {s = 47;}

                        else s = 46;

                        if ( s>=0 ) return s;
                        break;
                    case 2 : 
                        int LA16_4 = input.LA(1);

                        s = -1;
                        if ( ((LA16_4>='\u0000' && LA16_4<='\uFFFF')) ) {s = 44;}

                        else s = 43;

                        if ( s>=0 ) return s;
                        break;
                    case 3 : 
                        int LA16_0 = input.LA(1);

                        s = -1;
                        if ( (LA16_0=='\\') ) {s = 1;}

                        else if ( (LA16_0=='(') ) {s = 2;}

                        else if ( (LA16_0==')') ) {s = 3;}

                        else if ( (LA16_0=='[') ) {s = 4;}

                        else if ( (LA16_0==']') ) {s = 5;}

                        else if ( (LA16_0=='{') ) {s = 6;}

                        else if ( (LA16_0=='}') ) {s = 7;}

                        else if ( (LA16_0==',') ) {s = 8;}

                        else if ( (LA16_0=='s') ) {s = 9;}

                        else if ( (LA16_0=='=') ) {s = 10;}

                        else if ( (LA16_0==';') ) {s = 11;}

                        else if ( (LA16_0==':') ) {s = 12;}

                        else if ( (LA16_0=='/') ) {s = 13;}

                        else if ( (LA16_0=='a') ) {s = 14;}

                        else if ( (LA16_0=='l') ) {s = 15;}

                        else if ( (LA16_0=='e') ) {s = 16;}

                        else if ( (LA16_0=='i') ) {s = 17;}

                        else if ( (LA16_0=='o') ) {s = 18;}

                        else if ( (LA16_0=='f') ) {s = 19;}

                        else if ( (LA16_0=='d') ) {s = 20;}

                        else if ( (LA16_0=='m') ) {s = 21;}

                        else if ( (LA16_0=='p') ) {s = 22;}

                        else if ( (LA16_0=='c') ) {s = 23;}

                        else if ( (LA16_0=='n') ) {s = 24;}

                        else if ( (LA16_0=='-') ) {s = 25;}

                        else if ( (LA16_0=='|') ) {s = 26;}

                        else if ( (LA16_0=='t') ) {s = 27;}

                        else if ( (LA16_0=='+') ) {s = 28;}

                        else if ( ((LA16_0>='A' && LA16_0<='Z')||LA16_0=='_'||LA16_0=='b'||(LA16_0>='g' && LA16_0<='h')||(LA16_0>='j' && LA16_0<='k')||(LA16_0>='q' && LA16_0<='r')||(LA16_0>='u' && LA16_0<='z')) ) {s = 29;}

                        else if ( ((LA16_0>='0' && LA16_0<='9')) ) {s = 30;}

                        else if ( (LA16_0=='.') ) {s = 31;}

                        else if ( (LA16_0=='%') ) {s = 32;}

                        else if ( ((LA16_0>='\t' && LA16_0<='\n')||LA16_0=='\r'||LA16_0==' ') ) {s = 33;}

                        else if ( ((LA16_0>='\u0000' && LA16_0<='\b')||(LA16_0>='\u000B' && LA16_0<='\f')||(LA16_0>='\u000E' && LA16_0<='\u001F')||(LA16_0>='!' && LA16_0<='$')||(LA16_0>='&' && LA16_0<='\'')||LA16_0=='*'||LA16_0=='<'||(LA16_0>='>' && LA16_0<='@')||LA16_0=='^'||LA16_0=='`'||(LA16_0>='~' && LA16_0<='\uFFFF')) ) {s = 34;}

                        if ( s>=0 ) return s;
                        break;
            }
            NoViableAltException nvae =
                new NoViableAltException(getDescription(), 16, _s, input);
            error(nvae);
            throw nvae;
        }
    }
 

}