// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g 2010-12-24 01:56:41

import org.antlr.runtime.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;

public class simpletikzLexer extends Lexer {
    public static final int T__68=68;
    public static final int T__69=69;
    public static final int T__66=66;
    public static final int T__67=67;
    public static final int EXPONENT=50;
    public static final int T__64=64;
    public static final int T__65=65;
    public static final int IM_STARTTAG=33;
    public static final int TIKZEDT_CMD_COMMENT=44;
    public static final int T__62=62;
    public static final int T__63=63;
    public static final int RBR=17;
    public static final int IM_PATH=24;
    public static final int IM_ID=38;
    public static final int SOMETHING=54;
    public static final int ID=47;
    public static final int T__61=61;
    public static final int EOF=-1;
    public static final int T__60=60;
    public static final int MATHSTRING=52;
    public static final int LBR=16;
    public static final int COMMAND=53;
    public static final int IM_ENDTAG=34;
    public static final int IM_USETIKZLIB=40;
    public static final int T__55=55;
    public static final int T__56=56;
    public static final int T__57=57;
    public static final int IM_DOCUMENT=31;
    public static final int T__58=58;
    public static final int RBRR=19;
    public static final int ESC_SEQ=51;
    public static final int IM_STRING=41;
    public static final int LPAR=14;
    public static final int FILL=12;
    public static final int PATH=11;
    public static final int IM_TIKZSET=39;
    public static final int T__59=59;
    public static final int BEGIN=4;
    public static final int IM_OPTION_KV=37;
    public static final int CLIP=13;
    public static final int COMMENT=49;
    public static final int IM_TIKZEDT_CMD=43;
    public static final int IM_OPTIONS=35;
    public static final int NODE=9;
    public static final int IM_OPTION_STYLE=36;
    public static final int TIKZSET=8;
    public static final int TIKZSTYLE=7;
    public static final int IM_COORD=26;
    public static final int IM_PICTURE=30;
    public static final int LBRR=18;
    public static final int INT=45;
    public static final int USETIKZLIB=6;
    public static final int IM_NODE=25;
    public static final int IM_STYLE=42;
    public static final int COLON=23;
    public static final int IM_NUMBERUNIT=29;
    public static final int IM_SCOPE=32;
    public static final int T__71=71;
    public static final int WS=48;
    public static final int T__72=72;
    public static final int T__70=70;
    public static final int KOMMA=20;
    public static final int EQU=21;
    public static final int IM_SIZE=27;
    public static final int RPAR=15;
    public static final int SEMIC=22;
    public static final int END=5;
    public static final int T__75=75;
    public static final int T__74=74;
    public static final int T__73=73;
    public static final int IM_NODENAME=28;
    public static final int DRAW=10;
    public static final int FLOAT_WO_EXP=46;

    // delegates
    // delegators

    public simpletikzLexer() {;} 
    public simpletikzLexer(CharStream input) {
        this(input, new RecognizerSharedState());
    }
    public simpletikzLexer(CharStream input, RecognizerSharedState state) {
        super(input,state);

    }
    public String getGrammarFileName() { return "C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g"; }

    // $ANTLR start "BEGIN"
    public final void mBEGIN() throws RecognitionException {
        try {
            int _type = BEGIN;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:3:7: ( '\\\\begin' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:3:9: '\\\\begin'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:4:5: ( '\\\\end' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:4:7: '\\\\end'
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

    // $ANTLR start "USETIKZLIB"
    public final void mUSETIKZLIB() throws RecognitionException {
        try {
            int _type = USETIKZLIB;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:5:12: ( '\\\\usetikzlibrary' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:5:14: '\\\\usetikzlibrary'
            {
            match("\\usetikzlibrary"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "USETIKZLIB"

    // $ANTLR start "TIKZSTYLE"
    public final void mTIKZSTYLE() throws RecognitionException {
        try {
            int _type = TIKZSTYLE;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:6:11: ( '\\\\tikzstyle' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:6:13: '\\\\tikzstyle'
            {
            match("\\tikzstyle"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "TIKZSTYLE"

    // $ANTLR start "TIKZSET"
    public final void mTIKZSET() throws RecognitionException {
        try {
            int _type = TIKZSET;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:7:9: ( '\\\\tikzset' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:7:11: '\\\\tikzset'
            {
            match("\\tikzset"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "TIKZSET"

    // $ANTLR start "NODE"
    public final void mNODE() throws RecognitionException {
        try {
            int _type = NODE;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:8:6: ( '\\\\node' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:8:8: '\\\\node'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:9:6: ( '\\\\draw' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:9:8: '\\\\draw'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:10:6: ( '\\\\path' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:10:8: '\\\\path'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:11:6: ( '\\\\fill' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:11:8: '\\\\fill'
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

    // $ANTLR start "CLIP"
    public final void mCLIP() throws RecognitionException {
        try {
            int _type = CLIP;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:12:6: ( '\\\\clip' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:12:8: '\\\\clip'
            {
            match("\\clip"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "CLIP"

    // $ANTLR start "LPAR"
    public final void mLPAR() throws RecognitionException {
        try {
            int _type = LPAR;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:13:6: ( '(' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:13:8: '('
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:14:6: ( ')' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:14:8: ')'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:15:5: ( '[' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:15:7: '['
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:16:5: ( ']' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:16:7: ']'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:17:6: ( '{' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:17:8: '{'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:18:6: ( '}' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:18:8: '}'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:19:7: ( ',' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:19:9: ','
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

    // $ANTLR start "EQU"
    public final void mEQU() throws RecognitionException {
        try {
            int _type = EQU;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:20:5: ( '=' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:20:7: '='
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:21:7: ( ';' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:21:9: ';'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:22:7: ( ':' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:22:9: ':'
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

    // $ANTLR start "T__55"
    public final void mT__55() throws RecognitionException {
        try {
            int _type = T__55;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:23:7: ( '/.style' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:23:9: '/.style'
            {
            match("/.style"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__55"

    // $ANTLR start "T__56"
    public final void mT__56() throws RecognitionException {
        try {
            int _type = T__56;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:24:7: ( 'cm' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:24:9: 'cm'
            {
            match("cm"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__56"

    // $ANTLR start "T__57"
    public final void mT__57() throws RecognitionException {
        try {
            int _type = T__57;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:25:7: ( 'in' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:25:9: 'in'
            {
            match("in"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__57"

    // $ANTLR start "T__58"
    public final void mT__58() throws RecognitionException {
        try {
            int _type = T__58;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:26:7: ( 'ex' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:26:9: 'ex'
            {
            match("ex"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__58"

    // $ANTLR start "T__59"
    public final void mT__59() throws RecognitionException {
        try {
            int _type = T__59;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:27:7: ( 'mm' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:27:9: 'mm'
            {
            match("mm"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__59"

    // $ANTLR start "T__60"
    public final void mT__60() throws RecognitionException {
        try {
            int _type = T__60;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:28:7: ( 'pt' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:28:9: 'pt'
            {
            match("pt"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__60"

    // $ANTLR start "T__61"
    public final void mT__61() throws RecognitionException {
        try {
            int _type = T__61;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:29:7: ( 'em' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:29:9: 'em'
            {
            match("em"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__61"

    // $ANTLR start "T__62"
    public final void mT__62() throws RecognitionException {
        try {
            int _type = T__62;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:30:7: ( 'node' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:30:9: 'node'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:31:7: ( 'at' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:31:9: 'at'
            {
            match("at"); 


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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:32:7: ( 'circle' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:32:9: 'circle'
            {
            match("circle"); 


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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:33:7: ( 'ellipse' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:33:9: 'ellipse'
            {
            match("ellipse"); 


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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:34:7: ( 'arc' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:34:9: 'arc'
            {
            match("arc"); 


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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:35:7: ( 'and' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:35:9: 'and'
            {
            match("and"); 


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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:36:7: ( '--' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:36:9: '--'
            {
            match("--"); 


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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:37:7: ( '->' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:37:9: '->'
            {
            match("->"); 


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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:38:7: ( '|-' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:38:9: '|-'
            {
            match("|-"); 


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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:39:7: ( '-|' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:39:9: '-|'
            {
            match("-|"); 


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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:40:7: ( '+' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:40:9: '+'
            {
            match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__72"

    // $ANTLR start "T__73"
    public final void mT__73() throws RecognitionException {
        try {
            int _type = T__73;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:41:7: ( '++' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:41:9: '++'
            {
            match("++"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__73"

    // $ANTLR start "T__74"
    public final void mT__74() throws RecognitionException {
        try {
            int _type = T__74;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:42:7: ( 'tikzpicture' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:42:9: 'tikzpicture'
            {
            match("tikzpicture"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__74"

    // $ANTLR start "T__75"
    public final void mT__75() throws RecognitionException {
        try {
            int _type = T__75;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:43:7: ( 'scope' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:43:9: 'scope'
            {
            match("scope"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__75"

    // $ANTLR start "ID"
    public final void mID() throws RecognitionException {
        try {
            int _type = ID;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:376:5: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' | '!' )* )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:376:7: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' | '!' )*
            {
            if ( (input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z') ) {
                input.consume();

            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                recover(mse);
                throw mse;}

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:376:31: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' | '!' )*
            loop1:
            do {
                int alt1=2;
                int LA1_0 = input.LA(1);

                if ( (LA1_0=='!'||LA1_0=='.'||(LA1_0>='0' && LA1_0<='9')||(LA1_0>='A' && LA1_0<='Z')||LA1_0=='_'||(LA1_0>='a' && LA1_0<='z')) ) {
                    alt1=1;
                }


                switch (alt1) {
            	case 1 :
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:
            	    {
            	    if ( input.LA(1)=='!'||input.LA(1)=='.'||(input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z') ) {
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:379:5: ( ( '-' )? ( '0' .. '9' )+ )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:379:7: ( '-' )? ( '0' .. '9' )+
            {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:379:7: ( '-' )?
            int alt2=2;
            int LA2_0 = input.LA(1);

            if ( (LA2_0=='-') ) {
                alt2=1;
            }
            switch (alt2) {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:379:7: '-'
                    {
                    match('-'); 

                    }
                    break;

            }

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:379:12: ( '0' .. '9' )+
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
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:379:12: '0' .. '9'
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


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "INT"

    // $ANTLR start "FLOAT_WO_EXP"
    public final void mFLOAT_WO_EXP() throws RecognitionException {
        try {
            int _type = FLOAT_WO_EXP;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:391:5: ( ( '-' )? ( '0' .. '9' )+ '.' ( '0' .. '9' )* | ( '-' )? '.' ( '0' .. '9' )+ )
            int alt9=2;
            switch ( input.LA(1) ) {
            case '-':
                {
                int LA9_1 = input.LA(2);

                if ( ((LA9_1>='0' && LA9_1<='9')) ) {
                    alt9=1;
                }
                else if ( (LA9_1=='.') ) {
                    alt9=2;
                }
                else {
                    NoViableAltException nvae =
                        new NoViableAltException("", 9, 1, input);

                    throw nvae;
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
                alt9=1;
                }
                break;
            case '.':
                {
                alt9=2;
                }
                break;
            default:
                NoViableAltException nvae =
                    new NoViableAltException("", 9, 0, input);

                throw nvae;
            }

            switch (alt9) {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:391:9: ( '-' )? ( '0' .. '9' )+ '.' ( '0' .. '9' )*
                    {
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:391:9: ( '-' )?
                    int alt4=2;
                    int LA4_0 = input.LA(1);

                    if ( (LA4_0=='-') ) {
                        alt4=1;
                    }
                    switch (alt4) {
                        case 1 :
                            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:391:9: '-'
                            {
                            match('-'); 

                            }
                            break;

                    }

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:391:14: ( '0' .. '9' )+
                    int cnt5=0;
                    loop5:
                    do {
                        int alt5=2;
                        int LA5_0 = input.LA(1);

                        if ( ((LA5_0>='0' && LA5_0<='9')) ) {
                            alt5=1;
                        }


                        switch (alt5) {
                    	case 1 :
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:391:15: '0' .. '9'
                    	    {
                    	    matchRange('0','9'); 

                    	    }
                    	    break;

                    	default :
                    	    if ( cnt5 >= 1 ) break loop5;
                                EarlyExitException eee =
                                    new EarlyExitException(5, input);
                                throw eee;
                        }
                        cnt5++;
                    } while (true);

                    match('.'); 
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:391:30: ( '0' .. '9' )*
                    loop6:
                    do {
                        int alt6=2;
                        int LA6_0 = input.LA(1);

                        if ( ((LA6_0>='0' && LA6_0<='9')) ) {
                            alt6=1;
                        }


                        switch (alt6) {
                    	case 1 :
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:391:31: '0' .. '9'
                    	    {
                    	    matchRange('0','9'); 

                    	    }
                    	    break;

                    	default :
                    	    break loop6;
                        }
                    } while (true);


                    }
                    break;
                case 2 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:392:9: ( '-' )? '.' ( '0' .. '9' )+
                    {
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:392:9: ( '-' )?
                    int alt7=2;
                    int LA7_0 = input.LA(1);

                    if ( (LA7_0=='-') ) {
                        alt7=1;
                    }
                    switch (alt7) {
                        case 1 :
                            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:392:9: '-'
                            {
                            match('-'); 

                            }
                            break;

                    }

                    match('.'); 
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:392:18: ( '0' .. '9' )+
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
                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:392:19: '0' .. '9'
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


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "FLOAT_WO_EXP"

    // $ANTLR start "TIKZEDT_CMD_COMMENT"
    public final void mTIKZEDT_CMD_COMMENT() throws RecognitionException {
        try {
            int _type = TIKZEDT_CMD_COMMENT;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:396:5: ( '%' WS '!TIKZEDT' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:396:9: '%' WS '!TIKZEDT' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
            {
            match('%'); 
            mWS(); 
            match("!TIKZEDT"); 

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:396:29: (~ ( '\\n' | '\\r' ) )*
            loop10:
            do {
                int alt10=2;
                int LA10_0 = input.LA(1);

                if ( ((LA10_0>='\u0000' && LA10_0<='\t')||(LA10_0>='\u000B' && LA10_0<='\f')||(LA10_0>='\u000E' && LA10_0<='\uFFFF')) ) {
                    alt10=1;
                }


                switch (alt10) {
            	case 1 :
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:396:29: ~ ( '\\n' | '\\r' )
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

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:396:43: ( '\\r' )?
            int alt11=2;
            int LA11_0 = input.LA(1);

            if ( (LA11_0=='\r') ) {
                alt11=1;
            }
            switch (alt11) {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:396:43: '\\r'
                    {
                    match('\r'); 

                    }
                    break;

            }

            match('\n'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "TIKZEDT_CMD_COMMENT"

    // $ANTLR start "COMMENT"
    public final void mCOMMENT() throws RecognitionException {
        try {
            int _type = COMMENT;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:400:5: ( '%' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:400:9: '%' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
            {
            match('%'); 
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:400:13: (~ ( '\\n' | '\\r' ) )*
            loop12:
            do {
                int alt12=2;
                int LA12_0 = input.LA(1);

                if ( ((LA12_0>='\u0000' && LA12_0<='\t')||(LA12_0>='\u000B' && LA12_0<='\f')||(LA12_0>='\u000E' && LA12_0<='\uFFFF')) ) {
                    alt12=1;
                }


                switch (alt12) {
            	case 1 :
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:400:13: ~ ( '\\n' | '\\r' )
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
            	    break loop12;
                }
            } while (true);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:400:27: ( '\\r' )?
            int alt13=2;
            int LA13_0 = input.LA(1);

            if ( (LA13_0=='\r') ) {
                alt13=1;
            }
            switch (alt13) {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:400:27: '\\r'
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:403:5: ( ( ' ' | '\\t' | '\\r' | '\\n' ) )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:403:9: ( ' ' | '\\t' | '\\r' | '\\n' )
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:410:19: ( ( 'e' | 'E' ) ( '+' | '-' )? ( '0' .. '9' )+ )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:410:21: ( 'e' | 'E' ) ( '+' | '-' )? ( '0' .. '9' )+
            {
            if ( input.LA(1)=='E'||input.LA(1)=='e' ) {
                input.consume();

            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                recover(mse);
                throw mse;}

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:410:31: ( '+' | '-' )?
            int alt14=2;
            int LA14_0 = input.LA(1);

            if ( (LA14_0=='+'||LA14_0=='-') ) {
                alt14=1;
            }
            switch (alt14) {
                case 1 :
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:
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

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:410:42: ( '0' .. '9' )+
            int cnt15=0;
            loop15:
            do {
                int alt15=2;
                int LA15_0 = input.LA(1);

                if ( ((LA15_0>='0' && LA15_0<='9')) ) {
                    alt15=1;
                }


                switch (alt15) {
            	case 1 :
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:410:43: '0' .. '9'
            	    {
            	    matchRange('0','9'); 

            	    }
            	    break;

            	default :
            	    if ( cnt15 >= 1 ) break loop15;
                        EarlyExitException eee =
                            new EarlyExitException(15, input);
                        throw eee;
                }
                cnt15++;
            } while (true);


            }

        }
        finally {
        }
    }
    // $ANTLR end "EXPONENT"

    // $ANTLR start "MATHSTRING"
    public final void mMATHSTRING() throws RecognitionException {
        try {
            int _type = MATHSTRING;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:417:2: ( '$' ( ESC_SEQ | ~ ( '\\\\' | '$' ) )* '$' )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:417:4: '$' ( ESC_SEQ | ~ ( '\\\\' | '$' ) )* '$'
            {
            match('$'); 
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:417:8: ( ESC_SEQ | ~ ( '\\\\' | '$' ) )*
            loop16:
            do {
                int alt16=3;
                int LA16_0 = input.LA(1);

                if ( (LA16_0=='\\') ) {
                    alt16=1;
                }
                else if ( ((LA16_0>='\u0000' && LA16_0<='#')||(LA16_0>='%' && LA16_0<='[')||(LA16_0>=']' && LA16_0<='\uFFFF')) ) {
                    alt16=2;
                }


                switch (alt16) {
            	case 1 :
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:417:10: ESC_SEQ
            	    {
            	    mESC_SEQ(); 

            	    }
            	    break;
            	case 2 :
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:417:20: ~ ( '\\\\' | '$' )
            	    {
            	    if ( (input.LA(1)>='\u0000' && input.LA(1)<='#')||(input.LA(1)>='%' && input.LA(1)<='[')||(input.LA(1)>=']' && input.LA(1)<='\uFFFF') ) {
            	        input.consume();

            	    }
            	    else {
            	        MismatchedSetException mse = new MismatchedSetException(null,input);
            	        recover(mse);
            	        throw mse;}


            	    }
            	    break;

            	default :
            	    break loop16;
                }
            } while (true);

            match('$'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "MATHSTRING"

    // $ANTLR start "COMMAND"
    public final void mCOMMAND() throws RecognitionException {
        try {
            int _type = COMMAND;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:428:2: ( '\\\\' ID )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:428:4: '\\\\' ID
            {
            match('\\'); 
            mID(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "COMMAND"

    // $ANTLR start "ESC_SEQ"
    public final void mESC_SEQ() throws RecognitionException {
        try {
            int _type = ESC_SEQ;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:433:5: ( '\\\\' . )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:433:9: '\\\\' .
            {
            match('\\'); 
            matchAny(); 

            }

            state.type = _type;
            state.channel = _channel;
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
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:439:2: ( . )
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:439:4: .
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
        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:1:8: ( BEGIN | END | USETIKZLIB | TIKZSTYLE | TIKZSET | NODE | DRAW | PATH | FILL | CLIP | LPAR | RPAR | LBR | RBR | LBRR | RBRR | KOMMA | EQU | SEMIC | COLON | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | ID | INT | FLOAT_WO_EXP | TIKZEDT_CMD_COMMENT | COMMENT | WS | MATHSTRING | COMMAND | ESC_SEQ | SOMETHING )
        int alt17=51;
        alt17 = dfa17.predict(input);
        switch (alt17) {
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


    protected DFA17 dfa17 = new DFA17(this);
    static final String DFA17_eotS =
        "\1\uffff\1\37\12\uffff\1\37\7\70\2\37\1\112\2\70\1\uffff\1\115"+
        "\2\37\1\uffff\1\37\1\uffff\11\125\15\uffff\1\136\1\70\1\uffff\1"+
        "\140\1\141\1\142\1\70\1\144\1\145\1\70\1\147\2\70\3\uffff\1\115"+
        "\4\uffff\2\70\3\uffff\1\121\3\uffff\1\125\1\uffff\10\125\1\uffff"+
        "\1\70\3\uffff\1\70\2\uffff\1\70\1\uffff\1\172\1\173\2\70\2\uffff"+
        "\1\125\1\u0080\7\125\2\70\1\u008a\2\uffff\2\70\1\uffff\1\125\1\uffff"+
        "\2\125\1\u0091\1\u0092\1\u0093\1\u0094\1\u0095\2\70\1\uffff\1\70"+
        "\1\u0099\1\uffff\1\u009b\2\125\5\uffff\1\u009f\2\70\3\uffff\3\125"+
        "\1\uffff\1\u00a6\1\70\1\uffff\2\125\1\u00ab\1\uffff\1\70\1\uffff"+
        "\2\125\1\uffff\1\70\1\uffff\1\125\1\u00b3\1\70\1\uffff\1\125\1\uffff"+
        "\1\u00b9\3\uffff\1\125\1\uffff\2\125\1\u00bd\1\uffff";
    static final String DFA17_eofS =
        "\u00be\uffff";
    static final String DFA17_minS =
        "\2\0\12\uffff\1\56\1\151\1\156\1\154\1\155\1\164\1\157\1\156\2"+
        "\55\1\53\1\151\1\143\1\uffff\1\56\1\60\1\0\1\uffff\1\0\1\uffff\1"+
        "\145\1\156\1\163\1\151\1\157\1\162\1\141\1\151\1\154\15\uffff\1"+
        "\41\1\162\1\uffff\3\41\1\154\2\41\1\144\1\41\1\143\1\144\3\uffff"+
        "\1\56\4\uffff\1\153\1\157\1\uffff\1\0\1\12\1\41\3\uffff\1\147\1"+
        "\uffff\1\144\1\145\1\153\1\144\1\141\1\164\1\154\1\151\1\uffff\1"+
        "\143\3\uffff\1\151\2\uffff\1\145\1\uffff\2\41\1\172\1\160\1\0\1"+
        "\uffff\1\151\1\41\1\164\1\172\1\145\1\167\1\150\1\154\1\160\1\154"+
        "\1\160\1\41\2\uffff\1\160\1\145\1\0\1\156\1\uffff\1\151\1\163\5"+
        "\41\1\145\1\163\1\uffff\1\151\1\41\1\0\1\41\1\153\1\145\5\uffff"+
        "\1\41\1\145\1\143\1\uffff\1\0\1\uffff\1\172\1\171\1\164\1\uffff"+
        "\1\41\1\164\1\0\2\154\1\41\1\uffff\1\165\1\0\1\151\1\145\1\uffff"+
        "\1\162\1\0\1\142\1\41\1\145\1\0\1\162\1\uffff\1\41\1\0\1\12\1\uffff"+
        "\1\141\1\uffff\1\162\1\171\1\41\1\uffff";
    static final String DFA17_maxS =
        "\2\uffff\12\uffff\1\56\1\155\1\156\1\170\1\155\1\164\1\157\1\164"+
        "\1\174\1\55\1\53\1\151\1\143\1\uffff\2\71\1\uffff\1\uffff\1\uffff"+
        "\1\uffff\1\145\1\156\1\163\1\151\1\157\1\162\1\141\1\151\1\154\15"+
        "\uffff\1\172\1\162\1\uffff\3\172\1\154\2\172\1\144\1\172\1\143\1"+
        "\144\3\uffff\1\71\4\uffff\1\153\1\157\1\uffff\1\uffff\2\41\3\uffff"+
        "\1\147\1\uffff\1\144\1\145\1\153\1\144\1\141\1\164\1\154\1\151\1"+
        "\uffff\1\143\3\uffff\1\151\2\uffff\1\145\1\uffff\3\172\1\160\1\uffff"+
        "\1\uffff\1\151\1\172\1\164\1\172\1\145\1\167\1\150\1\154\1\160\1"+
        "\154\1\160\1\172\2\uffff\1\160\1\145\1\uffff\1\156\1\uffff\1\151"+
        "\1\163\5\172\1\145\1\163\1\uffff\1\151\1\172\1\uffff\1\172\1\153"+
        "\1\164\5\uffff\1\172\1\145\1\143\1\uffff\1\uffff\1\uffff\1\172\1"+
        "\171\1\164\1\uffff\1\172\1\164\1\uffff\2\154\1\172\1\uffff\1\165"+
        "\1\uffff\1\151\1\145\1\uffff\1\162\1\uffff\1\142\1\172\1\145\1\uffff"+
        "\1\162\1\uffff\1\172\1\uffff\1\12\1\uffff\1\141\1\uffff\1\162\1"+
        "\171\1\172\1\uffff";
    static final String DFA17_acceptS =
        "\2\uffff\1\13\1\14\1\15\1\16\1\17\1\20\1\21\1\22\1\23\1\24\15\uffff"+
        "\1\52\3\uffff\1\57\1\uffff\1\63\11\uffff\1\61\1\62\1\13\1\14\1\15"+
        "\1\16\1\17\1\20\1\21\1\22\1\23\1\24\1\25\2\uffff\1\52\12\uffff\1"+
        "\42\1\43\1\45\1\uffff\1\54\1\44\1\47\1\46\2\uffff\1\53\3\uffff\1"+
        "\56\1\57\1\60\1\uffff\1\61\10\uffff\1\26\1\uffff\1\27\1\30\1\33"+
        "\1\uffff\1\31\1\32\1\uffff\1\35\5\uffff\1\55\14\uffff\1\40\1\41"+
        "\4\uffff\1\2\11\uffff\1\34\6\uffff\1\6\1\7\1\10\1\11\1\12\3\uffff"+
        "\1\51\1\uffff\1\1\3\uffff\1\36\6\uffff\1\37\4\uffff\1\5\7\uffff"+
        "\1\4\3\uffff\1\55\1\uffff\1\50\3\uffff\1\3";
    static final String DFA17_specialS =
        "\1\1\1\0\32\uffff\1\2\1\uffff\1\14\57\uffff\1\12\35\uffff\1\3\21"+
        "\uffff\1\4\16\uffff\1\5\14\uffff\1\6\7\uffff\1\7\5\uffff\1\10\4"+
        "\uffff\1\11\3\uffff\1\13\3\uffff\1\15\10\uffff}>";
    static final String[] DFA17_transitionS = {
            "\11\37\2\35\2\37\1\35\22\37\1\35\3\37\1\36\1\34\2\37\1\2\1"+
            "\3\1\37\1\26\1\10\1\24\1\33\1\14\12\32\1\13\1\12\1\37\1\11\3"+
            "\37\32\31\1\4\1\1\1\5\1\37\1\31\1\37\1\23\1\31\1\15\1\31\1\17"+
            "\3\31\1\16\3\31\1\20\1\22\1\31\1\21\2\31\1\30\1\27\6\31\1\6"+
            "\1\25\1\7\uff82\37",
            "\101\52\32\51\4\52\1\51\1\52\1\51\1\40\1\50\1\45\1\41\1\47"+
            "\7\51\1\44\1\51\1\46\3\51\1\43\1\42\5\51\uff85\52",
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
            "\1\65",
            "\1\67\3\uffff\1\66",
            "\1\71",
            "\1\74\1\73\12\uffff\1\72",
            "\1\75",
            "\1\76",
            "\1\77",
            "\1\102\3\uffff\1\101\1\uffff\1\100",
            "\1\103\1\107\1\uffff\12\106\4\uffff\1\104\75\uffff\1\105",
            "\1\110",
            "\1\111",
            "\1\113",
            "\1\114",
            "",
            "\1\107\1\uffff\12\106",
            "\12\107",
            "\11\121\1\116\1\120\2\121\1\117\22\121\1\116\uffdf\121",
            "",
            "\0\123",
            "",
            "\1\124",
            "\1\126",
            "\1\127",
            "\1\130",
            "\1\131",
            "\1\132",
            "\1\133",
            "\1\134",
            "\1\135",
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
            "\1\70\14\uffff\1\70\1\uffff\12\70\7\uffff\32\70\4\uffff\1"+
            "\70\1\uffff\32\70",
            "\1\137",
            "",
            "\1\70\14\uffff\1\70\1\uffff\12\70\7\uffff\32\70\4\uffff\1"+
            "\70\1\uffff\32\70",
            "\1\70\14\uffff\1\70\1\uffff\12\70\7\uffff\32\70\4\uffff\1"+
            "\70\1\uffff\32\70",
            "\1\70\14\uffff\1\70\1\uffff\12\70\7\uffff\32\70\4\uffff\1"+
            "\70\1\uffff\32\70",
            "\1\143",
            "\1\70\14\uffff\1\70\1\uffff\12\70\7\uffff\32\70\4\uffff\1"+
            "\70\1\uffff\32\70",
            "\1\70\14\uffff\1\70\1\uffff\12\70\7\uffff\32\70\4\uffff\1"+
            "\70\1\uffff\32\70",
            "\1\146",
            "\1\70\14\uffff\1\70\1\uffff\12\70\7\uffff\32\70\4\uffff\1"+
            "\70\1\uffff\32\70",
            "\1\150",
            "\1\151",
            "",
            "",
            "",
            "\1\107\1\uffff\12\106",
            "",
            "",
            "",
            "",
            "\1\152",
            "\1\153",
            "",
            "\41\121\1\154\uffde\121",
            "\1\121\26\uffff\1\155",
            "\1\155",
            "",
            "",
            "",
            "\1\156",
            "",
            "\1\157",
            "\1\160",
            "\1\161",
            "\1\162",
            "\1\163",
            "\1\164",
            "\1\165",
            "\1\166",
            "",
            "\1\167",
            "",
            "",
            "",
            "\1\170",
            "",
            "",
            "\1\171",
            "",
            "\1\70\14\uffff\1\70\1\uffff\12\70\7\uffff\32\70\4\uffff\1"+
            "\70\1\uffff\32\70",
            "\1\70\14\uffff\1\70\1\uffff\12\70\7\uffff\32\70\4\uffff\1"+
            "\70\1\uffff\32\70",
            "\1\174",
            "\1\175",
            "\124\121\1\176\uffab\121",
            "",
            "\1\177",
            "\1\125\14\uffff\1\125\1\uffff\12\125\7\uffff\32\125\4\uffff"+
            "\1\125\1\uffff\32\125",
            "\1\u0081",
            "\1\u0082",
            "\1\u0083",
            "\1\u0084",
            "\1\u0085",
            "\1\u0086",
            "\1\u0087",
            "\1\u0088",
            "\1\u0089",
            "\1\70\14\uffff\1\70\1\uffff\12\70\7\uffff\32\70\4\uffff\1"+
            "\70\1\uffff\32\70",
            "",
            "",
            "\1\u008b",
            "\1\u008c",
            "\111\121\1\u008d\uffb6\121",
            "\1\u008e",
            "",
            "\1\u008f",
            "\1\u0090",
            "\1\125\14\uffff\1\125\1\uffff\12\125\7\uffff\32\125\4\uffff"+
            "\1\125\1\uffff\32\125",
            "\1\125\14\uffff\1\125\1\uffff\12\125\7\uffff\32\125\4\uffff"+
            "\1\125\1\uffff\32\125",
            "\1\125\14\uffff\1\125\1\uffff\12\125\7\uffff\32\125\4\uffff"+
            "\1\125\1\uffff\32\125",
            "\1\125\14\uffff\1\125\1\uffff\12\125\7\uffff\32\125\4\uffff"+
            "\1\125\1\uffff\32\125",
            "\1\125\14\uffff\1\125\1\uffff\12\125\7\uffff\32\125\4\uffff"+
            "\1\125\1\uffff\32\125",
            "\1\u0096",
            "\1\u0097",
            "",
            "\1\u0098",
            "\1\70\14\uffff\1\70\1\uffff\12\70\7\uffff\32\70\4\uffff\1"+
            "\70\1\uffff\32\70",
            "\113\121\1\u009a\uffb4\121",
            "\1\125\14\uffff\1\125\1\uffff\12\125\7\uffff\32\125\4\uffff"+
            "\1\125\1\uffff\32\125",
            "\1\u009c",
            "\1\u009e\16\uffff\1\u009d",
            "",
            "",
            "",
            "",
            "",
            "\1\70\14\uffff\1\70\1\uffff\12\70\7\uffff\32\70\4\uffff\1"+
            "\70\1\uffff\32\70",
            "\1\u00a0",
            "\1\u00a1",
            "",
            "\132\121\1\u00a2\uffa5\121",
            "",
            "\1\u00a3",
            "\1\u00a4",
            "\1\u00a5",
            "",
            "\1\70\14\uffff\1\70\1\uffff\12\70\7\uffff\32\70\4\uffff\1"+
            "\70\1\uffff\32\70",
            "\1\u00a7",
            "\105\121\1\u00a8\uffba\121",
            "\1\u00a9",
            "\1\u00aa",
            "\1\125\14\uffff\1\125\1\uffff\12\125\7\uffff\32\125\4\uffff"+
            "\1\125\1\uffff\32\125",
            "",
            "\1\u00ac",
            "\104\121\1\u00ad\uffbb\121",
            "\1\u00ae",
            "\1\u00af",
            "",
            "\1\u00b0",
            "\124\121\1\u00b1\uffab\121",
            "\1\u00b2",
            "\1\125\14\uffff\1\125\1\uffff\12\125\7\uffff\32\125\4\uffff"+
            "\1\125\1\uffff\32\125",
            "\1\u00b4",
            "\12\u00b5\1\u00b7\2\u00b5\1\u00b6\ufff2\u00b5",
            "\1\u00b8",
            "",
            "\1\70\14\uffff\1\70\1\uffff\12\70\7\uffff\32\70\4\uffff\1"+
            "\70\1\uffff\32\70",
            "\12\u00b5\1\u00b7\2\u00b5\1\u00b6\ufff2\u00b5",
            "\1\u00b7",
            "",
            "\1\u00ba",
            "",
            "\1\u00bb",
            "\1\u00bc",
            "\1\125\14\uffff\1\125\1\uffff\12\125\7\uffff\32\125\4\uffff"+
            "\1\125\1\uffff\32\125",
            ""
    };

    static final short[] DFA17_eot = DFA.unpackEncodedString(DFA17_eotS);
    static final short[] DFA17_eof = DFA.unpackEncodedString(DFA17_eofS);
    static final char[] DFA17_min = DFA.unpackEncodedStringToUnsignedChars(DFA17_minS);
    static final char[] DFA17_max = DFA.unpackEncodedStringToUnsignedChars(DFA17_maxS);
    static final short[] DFA17_accept = DFA.unpackEncodedString(DFA17_acceptS);
    static final short[] DFA17_special = DFA.unpackEncodedString(DFA17_specialS);
    static final short[][] DFA17_transition;

    static {
        int numStates = DFA17_transitionS.length;
        DFA17_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA17_transition[i] = DFA.unpackEncodedString(DFA17_transitionS[i]);
        }
    }

    class DFA17 extends DFA {

        public DFA17(BaseRecognizer recognizer) {
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
        public String getDescription() {
            return "1:1: Tokens : ( BEGIN | END | USETIKZLIB | TIKZSTYLE | TIKZSET | NODE | DRAW | PATH | FILL | CLIP | LPAR | RPAR | LBR | RBR | LBRR | RBRR | KOMMA | EQU | SEMIC | COLON | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | ID | INT | FLOAT_WO_EXP | TIKZEDT_CMD_COMMENT | COMMENT | WS | MATHSTRING | COMMAND | ESC_SEQ | SOMETHING );";
        }
        public int specialStateTransition(int s, IntStream _input) throws NoViableAltException {
            IntStream input = _input;
        	int _s = s;
            switch ( s ) {
                    case 0 : 
                        int LA17_1 = input.LA(1);

                        s = -1;
                        if ( (LA17_1=='b') ) {s = 32;}

                        else if ( (LA17_1=='e') ) {s = 33;}

                        else if ( (LA17_1=='u') ) {s = 34;}

                        else if ( (LA17_1=='t') ) {s = 35;}

                        else if ( (LA17_1=='n') ) {s = 36;}

                        else if ( (LA17_1=='d') ) {s = 37;}

                        else if ( (LA17_1=='p') ) {s = 38;}

                        else if ( (LA17_1=='f') ) {s = 39;}

                        else if ( (LA17_1=='c') ) {s = 40;}

                        else if ( ((LA17_1>='A' && LA17_1<='Z')||LA17_1=='_'||LA17_1=='a'||(LA17_1>='g' && LA17_1<='m')||LA17_1=='o'||(LA17_1>='q' && LA17_1<='s')||(LA17_1>='v' && LA17_1<='z')) ) {s = 41;}

                        else if ( ((LA17_1>='\u0000' && LA17_1<='@')||(LA17_1>='[' && LA17_1<='^')||LA17_1=='`'||(LA17_1>='{' && LA17_1<='\uFFFF')) ) {s = 42;}

                        else s = 31;

                        if ( s>=0 ) return s;
                        break;
                    case 1 : 
                        int LA17_0 = input.LA(1);

                        s = -1;
                        if ( (LA17_0=='\\') ) {s = 1;}

                        else if ( (LA17_0=='(') ) {s = 2;}

                        else if ( (LA17_0==')') ) {s = 3;}

                        else if ( (LA17_0=='[') ) {s = 4;}

                        else if ( (LA17_0==']') ) {s = 5;}

                        else if ( (LA17_0=='{') ) {s = 6;}

                        else if ( (LA17_0=='}') ) {s = 7;}

                        else if ( (LA17_0==',') ) {s = 8;}

                        else if ( (LA17_0=='=') ) {s = 9;}

                        else if ( (LA17_0==';') ) {s = 10;}

                        else if ( (LA17_0==':') ) {s = 11;}

                        else if ( (LA17_0=='/') ) {s = 12;}

                        else if ( (LA17_0=='c') ) {s = 13;}

                        else if ( (LA17_0=='i') ) {s = 14;}

                        else if ( (LA17_0=='e') ) {s = 15;}

                        else if ( (LA17_0=='m') ) {s = 16;}

                        else if ( (LA17_0=='p') ) {s = 17;}

                        else if ( (LA17_0=='n') ) {s = 18;}

                        else if ( (LA17_0=='a') ) {s = 19;}

                        else if ( (LA17_0=='-') ) {s = 20;}

                        else if ( (LA17_0=='|') ) {s = 21;}

                        else if ( (LA17_0=='+') ) {s = 22;}

                        else if ( (LA17_0=='t') ) {s = 23;}

                        else if ( (LA17_0=='s') ) {s = 24;}

                        else if ( ((LA17_0>='A' && LA17_0<='Z')||LA17_0=='_'||LA17_0=='b'||LA17_0=='d'||(LA17_0>='f' && LA17_0<='h')||(LA17_0>='j' && LA17_0<='l')||LA17_0=='o'||(LA17_0>='q' && LA17_0<='r')||(LA17_0>='u' && LA17_0<='z')) ) {s = 25;}

                        else if ( ((LA17_0>='0' && LA17_0<='9')) ) {s = 26;}

                        else if ( (LA17_0=='.') ) {s = 27;}

                        else if ( (LA17_0=='%') ) {s = 28;}

                        else if ( ((LA17_0>='\t' && LA17_0<='\n')||LA17_0=='\r'||LA17_0==' ') ) {s = 29;}

                        else if ( (LA17_0=='$') ) {s = 30;}

                        else if ( ((LA17_0>='\u0000' && LA17_0<='\b')||(LA17_0>='\u000B' && LA17_0<='\f')||(LA17_0>='\u000E' && LA17_0<='\u001F')||(LA17_0>='!' && LA17_0<='#')||(LA17_0>='&' && LA17_0<='\'')||LA17_0=='*'||LA17_0=='<'||(LA17_0>='>' && LA17_0<='@')||LA17_0=='^'||LA17_0=='`'||(LA17_0>='~' && LA17_0<='\uFFFF')) ) {s = 31;}

                        if ( s>=0 ) return s;
                        break;
                    case 2 : 
                        int LA17_28 = input.LA(1);

                        s = -1;
                        if ( (LA17_28=='\t'||LA17_28==' ') ) {s = 78;}

                        else if ( (LA17_28=='\r') ) {s = 79;}

                        else if ( (LA17_28=='\n') ) {s = 80;}

                        else if ( ((LA17_28>='\u0000' && LA17_28<='\b')||(LA17_28>='\u000B' && LA17_28<='\f')||(LA17_28>='\u000E' && LA17_28<='\u001F')||(LA17_28>='!' && LA17_28<='\uFFFF')) ) {s = 81;}

                        else s = 31;

                        if ( s>=0 ) return s;
                        break;
                    case 3 : 
                        int LA17_108 = input.LA(1);

                        s = -1;
                        if ( (LA17_108=='T') ) {s = 126;}

                        else if ( ((LA17_108>='\u0000' && LA17_108<='S')||(LA17_108>='U' && LA17_108<='\uFFFF')) ) {s = 81;}

                        if ( s>=0 ) return s;
                        break;
                    case 4 : 
                        int LA17_126 = input.LA(1);

                        s = -1;
                        if ( (LA17_126=='I') ) {s = 141;}

                        else if ( ((LA17_126>='\u0000' && LA17_126<='H')||(LA17_126>='J' && LA17_126<='\uFFFF')) ) {s = 81;}

                        if ( s>=0 ) return s;
                        break;
                    case 5 : 
                        int LA17_141 = input.LA(1);

                        s = -1;
                        if ( (LA17_141=='K') ) {s = 154;}

                        else if ( ((LA17_141>='\u0000' && LA17_141<='J')||(LA17_141>='L' && LA17_141<='\uFFFF')) ) {s = 81;}

                        if ( s>=0 ) return s;
                        break;
                    case 6 : 
                        int LA17_154 = input.LA(1);

                        s = -1;
                        if ( (LA17_154=='Z') ) {s = 162;}

                        else if ( ((LA17_154>='\u0000' && LA17_154<='Y')||(LA17_154>='[' && LA17_154<='\uFFFF')) ) {s = 81;}

                        if ( s>=0 ) return s;
                        break;
                    case 7 : 
                        int LA17_162 = input.LA(1);

                        s = -1;
                        if ( (LA17_162=='E') ) {s = 168;}

                        else if ( ((LA17_162>='\u0000' && LA17_162<='D')||(LA17_162>='F' && LA17_162<='\uFFFF')) ) {s = 81;}

                        if ( s>=0 ) return s;
                        break;
                    case 8 : 
                        int LA17_168 = input.LA(1);

                        s = -1;
                        if ( (LA17_168=='D') ) {s = 173;}

                        else if ( ((LA17_168>='\u0000' && LA17_168<='C')||(LA17_168>='E' && LA17_168<='\uFFFF')) ) {s = 81;}

                        if ( s>=0 ) return s;
                        break;
                    case 9 : 
                        int LA17_173 = input.LA(1);

                        s = -1;
                        if ( (LA17_173=='T') ) {s = 177;}

                        else if ( ((LA17_173>='\u0000' && LA17_173<='S')||(LA17_173>='U' && LA17_173<='\uFFFF')) ) {s = 81;}

                        if ( s>=0 ) return s;
                        break;
                    case 10 : 
                        int LA17_78 = input.LA(1);

                        s = -1;
                        if ( (LA17_78=='!') ) {s = 108;}

                        else if ( ((LA17_78>='\u0000' && LA17_78<=' ')||(LA17_78>='\"' && LA17_78<='\uFFFF')) ) {s = 81;}

                        if ( s>=0 ) return s;
                        break;
                    case 11 : 
                        int LA17_177 = input.LA(1);

                        s = -1;
                        if ( ((LA17_177>='\u0000' && LA17_177<='\t')||(LA17_177>='\u000B' && LA17_177<='\f')||(LA17_177>='\u000E' && LA17_177<='\uFFFF')) ) {s = 181;}

                        else if ( (LA17_177=='\r') ) {s = 182;}

                        else if ( (LA17_177=='\n') ) {s = 183;}

                        if ( s>=0 ) return s;
                        break;
                    case 12 : 
                        int LA17_30 = input.LA(1);

                        s = -1;
                        if ( ((LA17_30>='\u0000' && LA17_30<='\uFFFF')) ) {s = 83;}

                        else s = 31;

                        if ( s>=0 ) return s;
                        break;
                    case 13 : 
                        int LA17_181 = input.LA(1);

                        s = -1;
                        if ( (LA17_181=='\r') ) {s = 182;}

                        else if ( (LA17_181=='\n') ) {s = 183;}

                        else if ( ((LA17_181>='\u0000' && LA17_181<='\t')||(LA17_181>='\u000B' && LA17_181<='\f')||(LA17_181>='\u000E' && LA17_181<='\uFFFF')) ) {s = 181;}

                        if ( s>=0 ) return s;
                        break;
            }
            NoViableAltException nvae =
                new NoViableAltException(getDescription(), 17, _s, input);
            error(nvae);
            throw nvae;
        }
    }
 

}